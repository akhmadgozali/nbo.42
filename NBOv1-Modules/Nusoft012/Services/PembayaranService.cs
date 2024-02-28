using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services {
	internal class PembayaranIklanService : ServiceBase<PembayaranIklan> {
		internal PembayaranIklanService(UnitOfWork connection) : base(connection) { }
		internal PembayaranIklanService(UnitOfWork connection, PembayaranIklan originalDataEdit) : base(connection, originalDataEdit) { }

		private GlMain deletedGL;
		protected internal override bool CheckBeforeDelete(PembayaranIklan obj) {
			CheckIsInUse(uow, obj);
			return true;
		}
		protected internal override void BeforeDeleteAction(PembayaranIklan obj) { deletedGL = obj.GLId; }
		protected internal override void AfterDeleteAction(PembayaranIklan obj) { deletedGL.Delete(); }

		protected internal override bool CheckBeforeSave(PembayaranIklan obj) {
			if (obj.Tanggal == default) throw new Utils.Exception("Masukkan tanggal pembayaran", -1);
			if (obj.Regional == null) throw new Utils.Exception("Masukkan regional", -2);
			if (obj.CaraBayar == null) throw new Utils.Exception("Masukkan cara pembayaran", -3);
			if (string.IsNullOrEmpty(obj.Keterangan)) throw new Utils.Exception("Masukkan keterangan", -4);

			if (obj.DetailForSave != null && obj.DetailForSave.Sum(s => s.NominalBayar) == 0) throw new Utils.Exception("Masukkan jumlah pembayaran", -99);
			foreach (var detail in obj.DetailForSave) {
				if (detail.NominalBayar > 0 && detail.NominalBayar > detail.Piutang)
					throw new Utils.Exception("Jumlah bayar tidak boleh lebih besar dari piutang. ==> " + detail.NominalBayar + " > " + detail.Piutang, -99);
			}

			if (IntegrasiService.CekPeriodeTutupBuku(uow, obj.Tanggal))
				throw new Utils.Exception("Data pembayaran tidak bisa disimpan, karena periode nya sudah ditutup.", -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.NoKwitansi == obj.NoKwitansi) return true;
			if (!string.IsNullOrEmpty(obj.NoKwitansi) && uow.FindObject<PembayaranIklan>(new BinaryOperator(nameof(PembayaranIklan.NoKwitansi), obj.NoKwitansi, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor pembayaran sudah ada yang memakai.\r\nSilahkan ganti dengan nomor yang lain", -6);

			return true;
		}
		protected internal override void SaveAction(PembayaranIklan obj) {
			if (string.IsNullOrEmpty(obj.NoKwitansi)) obj.NoKwitansi = NomorService.GetNomorPembayaran(uow, obj.Tanggal, obj.Regional);

			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.DetailForSave.Find(f => f.Invoice == detail.Invoice);
				if (find == null) { obj.Detail.Remove(detail); detail.Delete(); }
				else if (find.NominalBayar == 0) detail.Delete();
			}
			// Insert Update
			foreach (var detail in obj.DetailForSave) {
				if (detail.NominalBayar == 0) continue;
				var find = obj.Detail.ToList().Find(f => f.Invoice == detail.Invoice);
				if (find == null) find = new PembayaranIklanDetail(uow) { Pembayaran = obj, Invoice = detail.Invoice };
				find.NominalBayar = detail.NominalBayar;
				find.Keterangan = detail.Keterangan;

				if (obj.BatalBayarId != null) find.NominalBayar *= -1;

				// cek lunas atau belum
				DateTime tglDibuat = uow.IsNewObject(find) ? DateTime.Now : find.created_date;
				var pembayaranSebelumnya = new XPQuery<PembayaranIklanDetail>(uow).Where(w => w.Invoice == detail.Invoice && w.created_date < tglDibuat).ToList();

				// lunas secara bruto --> buatkan data komisinya
				if ((detail.Omzet - pembayaranSebelumnya.Sum(s => s.NominalBayar)) == detail.NominalBayar) {
					find.Lunas = true;
					find.CashbackPersen = detail.CashbackPersen;
					find.CashbackNominal = detail.CashbackNominal;
					find.PotonganKomisiNominal = detail.PotonganKomisiNominal;
					find.KomisiPersen = detail.KomisiPersen;
					find.KomisiNominal = detail.KomisiNominal;
				}
				else {
					find.Lunas = false;
					find.CashbackPersen = 0;
					find.CashbackNominal = 0;
					find.PotonganKomisiNominal = 0;
					find.KomisiPersen = 0;
					find.KomisiNominal = 0;
				}

				// link ke pph23
				if (obj.CaraBayar.IsPPh23) {
					IntegrasiService.SavePajakPPh23(uow, find);
				}
				else {
					if (find.PPh23Id != null) {
						var pph23 = find.PPh23Id;
						find.PPh23Id = null;
						pph23.Delete();
					}
				}
			}

			IntegrasiService.SavePembayaranIklan(uow, obj);
		}

		internal static bool CheckKomisiCashbackDibayar(UnitOfWork session, PembayaranIklanDetail detailBayar) {
			if (new XPQuery<PembayaranIklanDetail>(session).Where(w => w.Invoice == detailBayar.Invoice && w.Lunas &&
					w != detailBayar).Count() > 0)
				return true;

			return detailBayar.BayarKomisi.Count > 0 || detailBayar.BayarCashback.Count > 0;
		}

		internal static void CheckIsInUse(UnitOfWork session, PembayaranIklan obj) {
			if (IntegrasiService.CekPeriodeTutupBuku(session, obj.Tanggal))
				throw new Utils.Exception(string.Format("Data pembayaran {0} tidak bisa dihapus, karena periode nya sudah ditutup.", obj.NoKwitansi) , -1);
			if (session.FindObject<PembayaranIklan>(new BinaryOperator(nameof(PembayaranIklan.BatalBayarId), obj, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception(string.Format("Data pembayaran {0} tidak bisa dihapus, karena sudah dikoreksi.", obj.NoKwitansi), -1);
			if (session.FindObject<PencairanKomisiDetail>(new InOperator(nameof(PencairanKomisiDetail.Komisi), obj.Detail.ToList())) != null)
				throw new Utils.Exception(string.Format("Data pembayaran {0} tidak bisa dihapus, karena sudah dibayar komisi nya.", obj.NoKwitansi), -1);
			if (session.FindObject<PencairanCashbackDetail>(new InOperator(nameof(PencairanCashbackDetail.Cashback), obj.Detail.ToList())) != null)
				throw new Utils.Exception(string.Format("Data pembayaran {0} tidak bisa dihapus, karena sudah dibayar cashback nya.", obj.NoKwitansi), -1);
		}
		internal static List<PembayaranIklanDetailForSave> GetDetailPiutang(UnitOfWork session, Sales sales, string pemasang, PembayaranIklan pembayaranEdit) {
			var listEdit = new List<PembayaranIklanDetail>();
			if (pembayaranEdit != null)
				foreach (var c in pembayaranEdit.Detail) listEdit.Add(c);

			List<PembayaranIklanDetailForSave> result = new List<PembayaranIklanDetailForSave>();
			var listId = listEdit.Select(s => s.Invoice);

			List<Invoice> dataPiutang;
			if (sales == null) dataPiutang = new XPQuery<Invoice>(session).Where(w => (w.IndukInvoice == null && w.KoreksiInvoice == null && w.Piutang > 0 && w.InvoiceNama == pemasang) || listId.Contains(w)).ToList();
			else dataPiutang = new XPQuery<Invoice>(session).Where(w => (w.IndukInvoice == null && w.KoreksiInvoice == null && w.Piutang > 0 && w.Sales == sales) || listId.Contains(w)).ToList();

			foreach (var x in dataPiutang) {
				var edited = listEdit.Find(c => c.Invoice == x);
				var item = new PembayaranIklanDetailForSave() {
					Id = edited == null ? 0 : edited.Id,
					Invoice = x,
					Omzet = x.TotalGabungan,
					Terbayar = edited == null ? x.JumlahBayar : x.JumlahBayar - edited.NominalBayar,
					AllowEdit = edited == null ? true : !CheckKomisiCashbackDibayar(session, edited),
					
					NominalBayar = edited == null ? 0 : edited.NominalBayar,
					CashbackPersen = edited == null || !edited.Lunas ? x.CashbackPersen : edited.CashbackPersen,
					CashbackNominal = edited == null || !edited.Lunas ? x.CashbackNominal : edited.CashbackNominal,
					PotonganKomisiNominal = edited == null || !edited.Lunas ? x.PotonganKomisiNominal : edited.PotonganKomisiNominal,
					KomisiPersen = edited == null || !edited.Lunas ? x.KomisiPersen : edited.KomisiPersen,
					KomisiNominal = edited == null || !edited.Lunas ? x.KomisiNominal : edited.KomisiNominal,
					Keterangan = edited == null ? string.Empty : edited.Keterangan
				};

				result.Add(item);
			}

			return result;
		}

		internal static bool IsATransaction(UnitOfWork session) { return ((int)session.Evaluate<PembayaranIklan>(CriteriaOperator.Parse("Count()"), null)) > 0; }
	}
	internal class BatalBayarService : ServiceBase<PembayaranIklan> {
		public BatalBayarService(UnitOfWork connection) : base(connection) { }
		public BatalBayarService(UnitOfWork connection, PembayaranIklan originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(PembayaranIklan obj) { return false; }
		protected internal override bool CheckBeforeSave(PembayaranIklan obj) {
			if (obj.Tanggal == default) throw new Utils.Exception("Masukkan tanggal batal bayar", -1);
			if (string.IsNullOrEmpty(obj.Keterangan)) throw new Utils.Exception("Masukkan keterangan", -2);
			if (obj.BatalBayarId == null) throw new Utils.Exception("Masukkan pembayaran yang akan dibatalkan", -3);
			if (obj.CaraBayar == null) throw new Utils.Exception("Masukkan cara bayar", -4);

			if (obj.BatalBayarDetailForSave != null && obj.BatalBayarDetailForSave.Sum(s => s.SelisihNominalBayar) == 0) throw new Utils.Exception("Masukkan jumlah koreksi pembatalan", -99);
			foreach (var detail in obj.BatalBayarDetailForSave) {
				if (detail.SelisihNominalBayar > 0)
					throw new Utils.Exception("Nilai koreksi pembatalan tidak boleh lebih besar dari pembayaran", -99);
			}

			if (IntegrasiService.CekPeriodeTutupBuku(uow, obj.Tanggal))
				throw new Utils.Exception("Data batal bayar tidak bisa disimpan, karena periode nya sudah ditutup.", -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.NoKwitansi == obj.NoKwitansi) return true;
			if (!string.IsNullOrEmpty(obj.NoKwitansi) && uow.FindObject<PembayaranIklan>(new BinaryOperator(nameof(PembayaranIklan.NoKwitansi), obj.NoKwitansi, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor pembatalan sudah ada yang memakai.\r\nSilahkan ganti dengan nomor yang lain", -5);

			return true;
		}
		protected internal override void SaveAction(PembayaranIklan obj) {
			obj.Regional = obj.BatalBayarId.Regional;
			obj.Sales = obj.BatalBayarId.Sales;
			obj.Pemasang = obj.BatalBayarId.Pemasang;
			if (string.IsNullOrEmpty(obj.NoKwitansi)) obj.NoKwitansi = NomorService.GetNomorPembayaran(uow, obj.Tanggal, obj.Regional);

			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.BatalBayarDetailForSave.Find(f => f.PembayaranDetail == detail);
				if (find == null) { obj.Detail.Remove(detail); detail.Delete(); }
			}

			// Insert Update
			foreach (var detail in obj.BatalBayarDetailForSave) {
				var find = obj.Detail.ToList().Find(f => f == detail.PembayaranDetail);
				if (find == null) find = new PembayaranIklanDetail(uow) { Pembayaran = obj };
				find.Invoice = detail.PembayaranDetail.Invoice;
				find.NominalBayar = detail.SelisihNominalBayar;

				find.Lunas = false;
				find.CashbackPersen = 0;
				find.CashbackNominal = 0;
				find.PotonganKomisiNominal = 0;
				find.KomisiNominal = 0;
				find.KomisiPersen = 0;

				detail.PembayaranDetail.Lunas = false;
				detail.PembayaranDetail.CashbackPersen = 0;
				detail.PembayaranDetail.CashbackNominal = 0;
				detail.PembayaranDetail.PotonganKomisiNominal = 0;
				detail.PembayaranDetail.KomisiNominal = 0;
				detail.PembayaranDetail.KomisiPersen = 0;
			}

			IntegrasiService.SavePembayaranIklan(uow, obj);
		}

		public static List<BatalBayarIklanDetailForSave> GetKoreksiPembayaranDetail(UnitOfWork session, PembayaranIklan pembayaranKoreksi, PembayaranIklan pembayaranEdit) {
			List<PembayaranIklanDetail> detailEdit = new List<PembayaranIklanDetail>();
			if (pembayaranEdit != null) detailEdit = pembayaranEdit.Detail.ToList();

			var result = new List<BatalBayarIklanDetailForSave>();
			foreach (var x in pembayaranKoreksi.Detail) {
				var edited = detailEdit.Find(f => f.Invoice == x.Invoice);
				result.Add(new BatalBayarIklanDetailForSave() {
					Id = edited == null ? 0 : edited.Id,
					PembayaranDetail = x,
					AllowEdit = edited == null ? true : !PembayaranIklanService.CheckKomisiCashbackDibayar(session, x),
					NoInvoice = x.Invoice.NoInvoice,
					Tanggal = x.Invoice.TanggalInvoice,
					Sales = x.Invoice.Sales.Nama,
					Pemasang = x.Invoice.InvoiceNama,
					Keterangan = x.Invoice.InvoiceKeterangan,
					InvoiceNominalBayar = x.NominalBayar,
					KoreksiNominalBayar = edited == null ? x.NominalBayar : x.NominalBayar + edited.NominalBayar
				});
			}

			return result;
		}
		public static List<PembayaranIklan> GetSourcePembayaranKoreksi(UnitOfWork session, DateTime periode, PembayaranIklan objEdit) {
			var dataSdhKoreksi = new XPQuery<PembayaranIklan>(session).Where(w => w.BatalBayarId != null).GroupBy(g => g.BatalBayarId).Select(s => s.Key).ToList();
			if (objEdit == null)
				return new XPQuery<PembayaranIklan>(session).Where(w => (w.Tanggal.Year == periode.Year && w.Tanggal.Month == periode.Month
				&& !dataSdhKoreksi.Contains(w))).ToList();
			else
				return new XPQuery<PembayaranIklan>(session).Where(w => w == objEdit.BatalBayarId || (
					w.Tanggal.Year == periode.Year && w.Tanggal.Month == periode.Month && !dataSdhKoreksi.Contains(w))).ToList();
		}
	}
}