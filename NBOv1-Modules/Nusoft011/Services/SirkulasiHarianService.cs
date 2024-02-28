using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class SirkulasiHarianService : ServiceBase<SirkulasiHarian> {
		public SirkulasiHarianService(UnitOfWork connection) : base(connection) { }
		public SirkulasiHarianService(UnitOfWork connection, SirkulasiHarian originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(SirkulasiHarian obj) {
			if (CheckIsInUse(uow, obj.Tanggal))
				throw new Utils.Exception(string.Format("Data sirkulasi harian tanggal {0} tidak bisa dihapus, karena periode nya sudah ditutup.", obj.Tanggal.ToString("dd MMM yyyy")), -1);

			return true;
		}
		protected internal override bool CheckBeforeSave(SirkulasiHarian obj) {
			if (obj.Tanggal == null) throw new Utils.Exception("Masukkan tanggal sirkulasi harian koran", -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Tanggal == obj.Tanggal) return true;
			if (uow.FindObject<SirkulasiHarian>(new BinaryOperator(nameof(SirkulasiHarian.Tanggal), obj.Tanggal.ToString("yyyy-MM-dd"), BinaryOperatorType.Equal)) != null) 
				throw new Utils.Exception("Tanggal sirkulasi harian sudah ada yang memakai.\r\nSilahkan ganti tanggal yang lain", -1);

			if (IntegrasiService.CekPeriodeTutupBuku(uow, obj.Tanggal))
				throw new Utils.Exception(string.Format("Data sirkulasi harian tanggal {0} tidak bisa disimpan, karena periode nya sudah ditutup.", obj.Tanggal.ToString("dd MMM yyyy")), -1);

			foreach (var det in obj.DetailForSave) {
				if (det.Konsi < det.Retur) 
					throw new Utils.Exception(string.Format("Konsi tidak boleh lebih kecil dari retur pada agen {0}.\r\nKonsi = {1}\r\nRetur = {2}", det.Agen.Nama, det.Konsi, det.Retur), -99);
			}

			return true;
		}
		protected internal override void SaveAction(SirkulasiHarian obj) {
			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.DetailForSave.Find(f => f.Agen == detail.Agen);
				if (find == null || find.Oplah == 0) { obj.Detail.Remove(detail); detail.Delete(); }
			}

			// Insert Update
			foreach (var detail in obj.DetailForSave) {
				if (detail.Oplah == 0) continue;
				var find = obj.Detail.ToList().Find(f => f.Agen == detail.Agen);
				if (find == null) find = new SirkulasiHarianDetail(uow) { Main = obj, Agen = detail.Agen };
				find.JatahMutasi = detail.JatahMutasi;
				find.JatahOrder = detail.JatahOrder;
				find.KonsiMutasi = detail.KonsiMutasi;
				find.KonsiOrder = detail.KonsiOrder;
				find.GratisMutasi = detail.GratisMutasi;
				find.GratisOrder = detail.GratisOrder;
				find.HargaJatah = detail.HargaJatah;
				find.HargaKonsi = detail.HargaKonsi;
			}

		}
		public static bool CheckIsInUse(UnitOfWork session, DateTime tanggal) {
			return IntegrasiService.CekPeriodeTutupBuku(session, tanggal);
		}
		public static SirkulasiHarian GetItem(UnitOfWork session, SirkulasiHarian obj) {
			List<SirkulasiHarianDetailForSave> temp = new List<SirkulasiHarianDetailForSave>();
			foreach (var det in obj.Detail) {
				temp.Add(new SirkulasiHarianDetailForSave() {
					Id = det.Id,
					Agen = det.Agen,
					JatahOrder = det.JatahOrder,
					JatahMutasi = det.JatahMutasi,
					KonsiOrder = det.KonsiOrder,
					KonsiMutasi = det.KonsiMutasi,
					GratisOrder = det.GratisOrder,
					GratisMutasi = det.GratisMutasi,
					Keterangan = det.Keterangan,
					Retur = det.Retur,
					KeteranganRetur = det.KeteranganRetur,
					HargaJatah = det.HargaJatah,
					HargaKonsi = det.HargaKonsi
				});
			}
			var listAgen = new XPQuery<Agen>(session).Where(w => w.Aktif).ToList();
			foreach (var agen in listAgen) {
				var x = temp.Find(f => f.Agen == agen);
				if (x == null) {
					temp.Add(new SirkulasiHarianDetailForSave() {
						Id = (long)agen.Id,
						Agen = agen,
						JatahOrder = 0,
						JatahMutasi = 0,
						KonsiOrder = 0,
						KonsiMutasi = 0,
						GratisOrder = 0,
						GratisMutasi = 0,
						Keterangan = "",
						Retur = 0,
						KeteranganRetur = "",
						HargaJatah = agen.HargaJatah,
						HargaKonsi = agen.HargaKonsi
					});
				}
			}

			obj.DetailForSave = temp;
			return obj;
		}
		public static List<SirkulasiHarianDetailForSave> GetMutasiDetail(UnitOfWork session, DateTime Tanggal, bool hariKhusus) {
			var result = new List<SirkulasiHarianDetailForSave>();
			var listAgen = new XPQuery<Agen>(session).Where(w => w.Aktif).ToList();
			var listOrder = new XPQuery<OrderKoranDetail>(session).Where(w => w.Main.Tanggal == Tanggal.Date).ToList();
			var mutasi = new XPQuery<SirkulasiHarian>(session).Where(w => w.Tanggal.Date < Tanggal.Date).OrderByDescending(o => o.Tanggal).Take(1).SingleOrDefault();

			foreach (var agen in listAgen) {
				int jatah = 0; int konsi = 0; int gratis = 0; 
				var order = listOrder.Find(f => f.Agen == agen);

				if (order != null) {
					jatah = order.Jatah; konsi = order.Konsi; gratis = order.Gratis;
				}
				else {
					if (listOrder.Count > 0) continue;
					if (agen.OrderTetap) {
						var index = (int)Tanggal.DayOfWeek;
						if (hariKhusus) index = 0;
						else if (index == 0) index = 7;

						var othari = agen.DetailOrderTetap.ToList().Find(f => (int)f.IndexHari == index);
						if (othari != null) { jatah = othari.Jatah; konsi = othari.Konsi; gratis = othari.Gratis; }
					}
					else {
						if (mutasi != null) {
							var m = mutasi.Detail.ToList().Find(f => f.Agen == agen);
							if (m != null) { jatah = m.Jatah; konsi = m.Konsi; gratis = m.Gratis; }
						}
					}
				}

				result.Add(new SirkulasiHarianDetailForSave() {
					Agen = agen,
					GratisOrder = gratis,
					JatahOrder = jatah,
					KonsiOrder = konsi,
					HargaKonsi = agen.HargaKonsi,
					HargaJatah = agen.HargaJatah				
				});
			}
			return result;
		}

		public static bool IsATransaction(UnitOfWork session) { return ((int)session.Evaluate<SirkulasiHarian>(CriteriaOperator.Parse("Count()"), null)) > 0; }

		// retur koran
		public static List<SirkulasiHarianDetail> GetMutasiPerAgen(UnitOfWork session, SirkulasiAgen obj) {
			return new XPQuery<SirkulasiHarianDetail>(session).Where(w => w.Agen == obj.Agen && w.Main.Bulan.Date == obj.Tanggal.Date).ToList();
		}
		public static void SaveMutasiPerAgen(UnitOfWork session, SirkulasiAgen obj, List<SirkulasiHarianDetail> listMutasi) {
			foreach (var det in listMutasi) {
				if (det.Retur > det.Konsi) throw new Utils.Exception(string.Format("Retur tidak boleh melebihi konsi pada agen {0}.\r\nKonsi = {1}\r\nRetur = {2}", det.Agen.Nama, det.Konsi, det.Retur), -1);
			}
			session.CommitChanges();
			IntegrasiService.SaveIntegrasiKoran(session, obj);
		}

		// integrasi keuangan
		private List<KeyValuePair<DateTime, Agen>> deletedForGL;
		protected internal override void BeforeDeleteCommit(List<SirkulasiHarian> objs) {
			deletedForGL = new List<KeyValuePair<DateTime, Agen>>();
			foreach (var item in objs) {
				foreach (var x in item.Detail) {
					deletedForGL.Add(new KeyValuePair<DateTime, Agen>(DateTime.Parse(item.Tanggal.ToString("yyyy-MM-01")), x.Agen));
				}
			}
		}
		protected internal override void AfterDeleteCommit() {
			var queryGL = deletedForGL.GroupBy(g => g.Key).Select(s => new { Periode = s.Key, listAgen = s.Select(f => f.Value).ToList() });
			foreach (var g in queryGL)
				IntegrasiService.SaveIntegrasiKoran(uow, g.Periode, default(DateTime), g.listAgen, null);
		}
		protected internal override void AfterSaveCommit(SirkulasiHarian obj) {
			IntegrasiService.SaveIntegrasiKoran(uow, obj, _dataOriginalEdit);
		}
	}
}