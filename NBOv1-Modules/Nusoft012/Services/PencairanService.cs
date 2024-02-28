using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services {
	internal class PencairanCashbackService : ServiceBase<PencairanCashback> {
		internal PencairanCashbackService(UnitOfWork connection) : base(connection) { }
		internal PencairanCashbackService(UnitOfWork connection, PencairanCashback originalDataEdit) : base(connection, originalDataEdit) { }

		private GlMain deletedGL;
		protected internal override bool CheckBeforeDelete(PencairanCashback obj) {
			CheckIsInUse(uow, obj);
			return true;
		}
		protected internal override void BeforeDeleteAction(PencairanCashback obj) { deletedGL = obj.GLId; }
		protected internal override void AfterDeleteAction(PencairanCashback obj) { deletedGL.Delete(); }

		protected internal override bool CheckBeforeSave(PencairanCashback obj) {
			if (obj.Tanggal == default) throw new Utils.Exception("Masukkan tanggal pembayaran", -1);
			if (obj.Regional == null) throw new Utils.Exception("Masukkan regional", -2);
			if (obj.CaraBayar == null) throw new Utils.Exception("Masukkan cara pembayaran", -3);
			if (string.IsNullOrEmpty(obj.Pemasang)) throw new Utils.Exception("Masukkan pemasang", -4);
			if (string.IsNullOrEmpty(obj.Keterangan)) throw new Utils.Exception("Masukkan keterangan", -5);

			if (obj.DetailForSave != null && obj.DetailForSave.Sum(s => s.NominalCair) == 0) throw new Utils.Exception("Masukkan nominal pencairan", -99);
			foreach (var detail in obj.DetailForSave) {
				if (detail.NominalCair > 0 && detail.NominalCair > detail.Cashback.CashbackNominal)
					throw new Utils.Exception("Jumlah pencairan tidak boleh lebih besar dari nominal cashback. ==> " + detail.NominalCair + " > " + detail.Cashback.CashbackNominal, -99);
			}

			if (IntegrasiService.CekPeriodeTutupBuku(uow, obj.Tanggal))
				throw new Utils.Exception("Data pencairan tidak bisa disimpan, karena periode nya sudah ditutup.", -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.NoBukti == obj.NoBukti) return true;
			if (!string.IsNullOrEmpty(obj.NoBukti) && uow.FindObject<PencairanCashback>(new BinaryOperator(nameof(PencairanCashback.NoBukti), obj.NoBukti, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor pencairan cashback sudah ada yang memakai.\r\nSilahkan ganti dengan nomor yang lain", -6);

			return true;
		}
		protected internal override void SaveAction(PencairanCashback obj) {
			if (string.IsNullOrEmpty(obj.NoBukti)) obj.NoBukti = NomorService.GetNomorPencairanCashback(uow, obj.Tanggal, obj.Regional);

			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.DetailForSave.Find(f => f.Cashback == detail.Cashback);
				if (find == null) { obj.Detail.Remove(detail); detail.Delete(); }
				else if (find.NominalCair == 0) detail.Delete();
			}
			// Insert Update
			foreach (var detail in obj.DetailForSave) {
				if (detail.NominalCair == 0) continue;
				var find = obj.Detail.ToList().Find(f => f.Cashback == detail.Cashback);
				if (find == null) find = new PencairanCashbackDetail(uow) { PencairanCashback = obj, Cashback = detail.Cashback };
				find.NominalCair = detail.NominalCair;
				find.Keterangan = detail.Keterangan;
			}

			IntegrasiService.SavePencairanCashback(uow, obj);
		}

		internal static void CheckIsInUse(UnitOfWork session, PencairanCashback obj) {
			if (IntegrasiService.CekPeriodeTutupBuku(session, obj.Tanggal))
				throw new Utils.Exception(string.Format("Data pencairan {0} tidak bisa dihapus, karena periode nya sudah ditutup.", obj.NoBukti), -1);
		}
		internal static List<PencairanCashbackDetailForSave> GetDetailHutangCashback(UnitOfWork session, string pemasang, PencairanCashback pencairanEdit) {
			if (string.IsNullOrEmpty(pemasang)) throw new Exception("Masukkan pemasang");
			var listEdit = new List<PencairanCashbackDetail>();
			if (pencairanEdit != null)
				foreach (var c in pencairanEdit.Detail) listEdit.Add(c);

			List<PencairanCashbackDetailForSave> result = new List<PencairanCashbackDetailForSave>();
			var listId = listEdit.Select(s => s.Cashback);

			List<PembayaranIklanDetail> dataHutangCashback;
			dataHutangCashback = new XPQuery<PembayaranIklanDetail>(session).Where(w => 
				(w.Lunas && w.CashbackNominal > 0 && w.Invoice.InvoiceNama == pemasang && w.HutangCashback > 0) 
				|| listId.Contains(w)
			).ToList();

			foreach (var x in dataHutangCashback) {
				var edited = listEdit.Find(c => c.Cashback == x);
				var item = new PencairanCashbackDetailForSave() {
					Id = edited == null ? 0 : edited.Id,
					Cashback = x,
					Nominal = x.CashbackNominal,
					Cair = edited == null ? x.JumlahCashbackCair : x.JumlahCashbackCair - edited.NominalCair,
					AllowEdit = edited == null ? true : true,

					NominalCair = edited == null ? 0 : edited.NominalCair,
					Keterangan = edited == null ? string.Empty : edited.Keterangan					
				};

				result.Add(item);
			}

			return result;
		}

		internal static bool IsATransaction(UnitOfWork session) { return ((int)session.Evaluate<PencairanCashback>(CriteriaOperator.Parse("Count()"), null)) > 0; }
	}
	internal class PencairanKomisiService : ServiceBase<PencairanKomisi> {
		internal PencairanKomisiService(UnitOfWork connection) : base(connection) { }
		internal PencairanKomisiService(UnitOfWork connection, PencairanKomisi originalDataEdit) : base(connection, originalDataEdit) { }

		private GlMain deletedGL;
		protected internal override bool CheckBeforeDelete(PencairanKomisi obj) {
			CheckIsInUse(uow, obj);
			return true;
		}
		protected internal override void BeforeDeleteAction(PencairanKomisi obj) { deletedGL = obj.GLId; }
		protected internal override void AfterDeleteAction(PencairanKomisi obj) { deletedGL.Delete(); }

		protected internal override bool CheckBeforeSave(PencairanKomisi obj) {
			if (obj.Tanggal == default) throw new Utils.Exception("Masukkan tanggal pembayaran", -1);
			if (obj.Regional == null) throw new Utils.Exception("Masukkan regional", -2);
			if (obj.CaraBayar == null) throw new Utils.Exception("Masukkan cara pembayaran", -3);
			if (obj.Sales == null) throw new Utils.Exception("Masukkan sales", -4);
			if (string.IsNullOrEmpty(obj.Keterangan)) throw new Utils.Exception("Masukkan keterangan", -5);

			if (obj.DetailForSave != null && obj.DetailForSave.Sum(s => s.NominalCair) == 0) throw new Utils.Exception("Masukkan nominal pencairan", -99);
			foreach (var detail in obj.DetailForSave) {
				if (detail.NominalCair > 0 && detail.NominalCair > detail.Komisi.KomisiNominal)
					throw new Utils.Exception("Jumlah pencairan tidak boleh lebih besar dari nominal komisi. ==> " + detail.NominalCair + " > " + detail.Komisi.KomisiNominal, -99);
			}

			if (IntegrasiService.CekPeriodeTutupBuku(uow, obj.Tanggal))
				throw new Utils.Exception("Data pencairan tidak bisa disimpan, karena periode nya sudah ditutup.", -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.NoBukti == obj.NoBukti) return true;
			if (!string.IsNullOrEmpty(obj.NoBukti) && uow.FindObject<PencairanKomisi>(new BinaryOperator(nameof(PencairanKomisi.NoBukti), obj.NoBukti, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor pencairan komisi sudah ada yang memakai.\r\nSilahkan ganti dengan nomor yang lain", -6);

			return true;
		}
		protected internal override void SaveAction(PencairanKomisi obj) {
			if (string.IsNullOrEmpty(obj.NoBukti)) obj.NoBukti = NomorService.GetNomorPencairanKomisi(uow, obj.Tanggal, obj.Regional);

			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.DetailForSave.Find(f => f.Komisi == detail.Komisi);
				if (find == null) { obj.Detail.Remove(detail); detail.Delete(); }
				else if (find.NominalCair == 0) detail.Delete();
			}
			// Insert Update
			foreach (var detail in obj.DetailForSave) {
				if (detail.NominalCair == 0) continue;
				var find = obj.Detail.ToList().Find(f => f.Komisi == detail.Komisi);
				if (find == null) find = new PencairanKomisiDetail(uow) { PencairanKomisi = obj, Komisi = detail.Komisi };
				find.NominalCair = detail.NominalCair;
				find.Keterangan = detail.Keterangan;

				// link ke pph21
				if (obj.CaraBayar.IsPPh21) {
					IntegrasiService.SavePajakPPh21(uow, find);
				}
				else {
					if (find.PPh21KomisiId != null) {
						var pph21 = find.PPh21KomisiId;
						find.PPh21KomisiId = null;
						pph21.Delete();
					}
				}
			}

			IntegrasiService.SavePencairanKomisi(uow, obj);
		}

		internal static void CheckIsInUse(UnitOfWork session, PencairanKomisi obj) {
			if (IntegrasiService.CekPeriodeTutupBuku(session, obj.Tanggal))
				throw new Utils.Exception(string.Format("Data pencairan {0} tidak bisa dihapus, karena periode nya sudah ditutup.", obj.NoBukti), -1);
		}
		internal static List<PencairanKomisiDetailForSave> GetDetailHutangKomisi(UnitOfWork session, Sales sales, PencairanKomisi pencairanEdit) {
			if (sales == null) throw new Exception("Masukkan sales");
			var listEdit = new List<PencairanKomisiDetail>();
			if (pencairanEdit != null)
				foreach (var c in pencairanEdit.Detail) listEdit.Add(c);

			List<PencairanKomisiDetailForSave> result = new List<PencairanKomisiDetailForSave>();
			var listId = listEdit.Select(s => s.Komisi);

			List<PembayaranIklanDetail> dataHutangKomisi;
			dataHutangKomisi = new XPQuery<PembayaranIklanDetail>(session).Where(w =>
				(w.Lunas && w.KomisiNominal > 0 && w.Invoice.Sales == sales && w.HutangKomisi > 0)
				|| listId.Contains(w)
			).ToList();

			foreach (var x in dataHutangKomisi) {
				var edited = listEdit.Find(c => c.Komisi == x);
				var item = new PencairanKomisiDetailForSave() {
					Id = edited == null ? 0 : edited.Id,
					Komisi = x,
					Nominal = x.KomisiNominal,
					Cair = edited == null ? x.JumlahKomisiCair : x.JumlahKomisiCair - edited.NominalCair,
					AllowEdit = edited == null ? true : true,

					NominalCair = edited == null ? 0 : edited.NominalCair,
					Keterangan = edited == null ? string.Empty : edited.Keterangan
				};

				result.Add(item);
			}

			return result;
		}

		internal static bool IsATransaction(UnitOfWork session) { return ((int)session.Evaluate<PencairanKomisi>(CriteriaOperator.Parse("Count()"), null)) > 0; }
	}
}
