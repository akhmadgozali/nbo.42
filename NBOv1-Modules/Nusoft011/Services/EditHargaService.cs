using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class EditHargaService : ServiceBase<EditHarga> {
		public EditHargaService(UnitOfWork connection) : base(connection) { }
		public EditHargaService(UnitOfWork connection, EditHarga originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(EditHarga obj) { return false; }
		protected internal override bool CheckBeforeSave(EditHarga obj) {
			if (obj.Tahun == default(int)) throw new Utils.Exception("Masukkan periode tahun", -1);
			if (obj.Bulan == default(int)) throw new Utils.Exception("Masukkan periode bulan", -1);

			if (IntegrasiService.CekPeriodeTutupBuku(uow, new DateTime(obj.Tahun, obj.Bulan, 1)))
				throw new Utils.Exception(string.Format("Data tidak bisa disimpan, karena periode nya sudah ditutup."), -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Tahun.ToString("0000") + _dataOriginalEdit.Bulan.ToString("00") == obj.Tahun.ToString("0000") + obj.Bulan.ToString("00")) return true;
			if (uow.FindObject<EditHarga>(new GroupOperator(GroupOperatorType.And,
				new BinaryOperator(nameof(EditHarga.Tahun), obj.Tahun, BinaryOperatorType.Equal),
				new BinaryOperator(nameof(EditHarga.Bulan), obj.Bulan, BinaryOperatorType.Equal))) != null)
				throw new Utils.Exception("Periode sudah ada yang memakai.\r\nSilahkan ganti periode yang lain", -1);

			return true;
		}
		protected internal override void SaveAction(EditHarga obj) {
			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.DetailForSave.Find(f => f.Agen == detail.Agen);
				if (find == null) { obj.Detail.Remove(detail); detail.Delete(); }
			}

			// Insert Update
			foreach (var detail in obj.DetailForSave) {
				var find = obj.Detail.ToList().Find(f => f.Agen == detail.Agen);
				if (find == null) find = new EditHargaDetail(uow) { Main = obj };
				find.Agen = detail.Agen;
				find.HargaJatahBaru	= detail.HargaJatahBaru;
				find.HargaJatahLama = detail.HargaJatahLama;
				find.HargaKonsiBaru = detail.HargaKonsiBaru;
				find.HargaKonsiLama = detail.HargaKonsiLama;
				find.Keterangan = detail.Keterangan;

				UpdateHargaAgenMutasi(obj, find.Agen, detail);
			}
		}
		protected internal override void AfterSaveCommit(EditHarga obj) {
			// update omzet gl
			//var reg = new XPQuery<Regional>(uow).ToList();
			var agen = obj.Detail.Select(s => s.Agen).ToList();
			IntegrasiService.SaveIntegrasiKoran(uow, new DateTime(obj.Tahun, obj.Bulan, 1), default(DateTime), agen, null);
		}
		private void UpdateHargaAgenMutasi(EditHarga obj, Agen Agen, EditHargaDetailForSave detail) {
			// update master data agen
			Agen.HargaJatah = detail.HargaJatahBaru;
			Agen.HargaKonsi = detail.HargaKonsiBaru;

			//update omzet perbulan
			var mutasi = new XPQuery<SirkulasiHarianDetail>(uow).Where(w => w.Main.Tanggal.Year == obj.Tahun && w.Main.Tanggal.Month == obj.Bulan && w.Agen == detail.Agen);
			foreach (var mut in mutasi) {
				mut.HargaJatah = detail.HargaJatahBaru;
				mut.HargaKonsi = detail.HargaKonsiBaru;
			}
		}

		public static EditHarga GetItem(UnitOfWork session, EditHarga obj) {
			List<EditHargaDetailForSave> temp = new List<EditHargaDetailForSave>();
			foreach (var detail in obj.Detail) {
				temp.Add(new EditHargaDetailForSave() {
					Agen = detail.Agen,
					HargaJatahBaru = detail.HargaJatahBaru,
					HargaJatahLama = detail.HargaJatahLama,
					HargaKonsiBaru = detail.HargaKonsiBaru,
					HargaKonsiLama = detail.HargaKonsiLama,
					Keterangan = detail.Keterangan,
					Id = detail.Id
				});
			}

			var listAgen = new XPQuery<Agen>(session).Where(w => w.Aktif).ToList();
			foreach (var agen in listAgen) {
				var x = temp.Find(f => f.Agen == agen);
				if (x == null) {
					temp.Add(new EditHargaDetailForSave() {
						Agen = agen,
						HargaJatahBaru = agen.HargaJatah,
						HargaJatahLama = agen.HargaJatah,
						HargaKonsiBaru = agen.HargaKonsi,
						HargaKonsiLama = agen.HargaKonsi,
					});
				}
			}

			obj.DetailForSave = temp;
			return obj;
		}
		public static List<EditHargaDetailForSave> GetNewDetail(UnitOfWork session) {
			var temp = new List<EditHargaDetailForSave>();
			var listAgen = new XPQuery<Agen>(session).Where(w => w.Aktif).ToList();
			foreach (var agen in listAgen) {
				temp.Add(new EditHargaDetailForSave() {
					Agen = agen,
					HargaJatahBaru = agen.HargaJatah,
					HargaJatahLama = agen.HargaJatah,
					HargaKonsiBaru = agen.HargaKonsi,
					HargaKonsiLama = agen.HargaKonsi,
				});
			}

			return temp;
		}
		public static List<KeyValuePair<DateTime, string>> GetPeriode(UnitOfWork session) {
			var result = new List<KeyValuePair<DateTime, string>>();
			var listSaved = new XPQuery<EditHarga>(session).ToList();
			var data = new XPQuery<SirkulasiHarian>(session).GroupBy(g => new { Tahun = g.Tanggal.Year, Bulan = g.Tanggal.Month }).Select(s => s.Key);
			foreach (var x in data) {
				if (listSaved.Find(f => f.Tahun == x.Tahun && f.Bulan == x.Bulan) == null) {
					var item = new DateTime(x.Tahun, x.Bulan, 1);
					result.Add(new KeyValuePair<DateTime, string>(item, item.ToString("MMMM yyyy")));
				}
			}

			return result;
		}
	}
}
