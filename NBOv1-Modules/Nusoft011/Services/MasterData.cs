using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class RuteService : ServiceBase<Rute> {
		public RuteService(UnitOfWork connection) : base(connection) { }
		public RuteService(UnitOfWork connection, Rute originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Rute obj) {
			if (uow.FindObject<Agen>(new BinaryOperator(nameof(Agen.Rute), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di agen.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(Rute obj) {
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode rute", -1);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama rute", -2);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<Rute>(new BinaryOperator(nameof(Rute.Kode), obj.Kode, BinaryOperatorType.Equal)) != null) 
				throw new Utils.Exception("Kode rute sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -1);

			return true;
		}
	}
	internal class AgenService : ServiceBase<Agen> {
		public AgenService(UnitOfWork connection) : base(connection) { }
		public AgenService(UnitOfWork connection, Agen originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Agen obj) {
			if (uow.FindObject<OrderKoranDetail>(new BinaryOperator(nameof(OrderKoranDetail.Agen), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di order koran.", obj.Kode));
			if (uow.FindObject<SirkulasiHarianDetail>(new BinaryOperator(nameof(SirkulasiHarianDetail.Agen), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di sirkulasi harian.", obj.Kode));
			if (uow.FindObject<BayarKoran>(new BinaryOperator(nameof(BayarKoran.Agen), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di pembayaran koran.", obj.Kode));
			if (obj.SaldoPiutangAwal != default)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah masih ada data piutang awal.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(Agen obj) {
			if (obj.Rute == null) throw new Utils.Exception("Masukkan rute", -1);
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode agen", -2);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama agen", -3);
			if (string.IsNullOrEmpty(obj.KodePelanggan)) throw new Utils.Exception("Masukkan kode di pelanggan", -4);
			if (string.IsNullOrEmpty(obj.NPWP)) throw new Utils.Exception("Masukkan npwp agen.\r\nJika tidak punya, masukkan " + PPnKeluaranService.GetDefaultNPWP(), -5);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<Agen>(new BinaryOperator(nameof(Agen.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode agen sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -2);

			return true;
		}
		protected internal override void SaveAction(Agen obj) {
			// Delete detail
			for (var ji = obj.DetailOrderTetap.Count - 1; ji >= 0; ji--) {
				var detail = obj.DetailOrderTetap[ji];
				if (!obj.OrderTetap) { obj.DetailOrderTetap.Remove(detail); detail.Delete(); }
				else {
					var find = obj.DetailOrderTetapForSave.Find(f => f.IndexHari == detail.IndexHari);
					if (find == null) { obj.DetailOrderTetap.Remove(detail); detail.Delete(); }
				}
			}

			// Insert Update
			if (obj.OrderTetap) {
				//bool pertama = true; var i = 0;
				foreach (var detail in obj.DetailOrderTetapForSave) {
					var find = obj.DetailOrderTetap.ToList().Find(f => f.IndexHari == detail.IndexHari);
					if (find == null) {
						find = new AgenOrderTetap(uow) { Agen = obj, IndexHari = detail.IndexHari };
						//if (pertama) { pertama = false; i = find.Id; }
						//else find.Id = ++i;
					}
					find.Gratis = detail.Gratis;
					find.Jatah= detail.Jatah;
					find.Konsi = detail.Konsi;
					find.Gratis = detail.Gratis;
				}
			}
		}

		public static Agen GetItem(Agen obj) {
			List<AgenOrderTetapForSave> temp = GetNewOrderTetapData();
			foreach (var det in obj.DetailOrderTetap) {
				var x = temp.Find(f => f.IndexHari == det.IndexHari);
				if (x == null) {
					x = new AgenOrderTetapForSave() { IndexHari = det.IndexHari };
					temp.Add(x);
				}

				x.Gratis = det.Gratis;
				x.Konsi = det.Konsi;
				x.Jatah = det.Jatah;
			}

			obj.DetailOrderTetapForSave = temp;
			return obj;
		}
		public static List<AgenOrderTetapForSave> GetNewOrderTetapData() {
			var result = new List<AgenOrderTetapForSave>();
			for (int i = 0; i <= 7; i++)
				result.Add(new AgenOrderTetapForSave() { IndexHari = (EWeekdayName)i, Gratis = 0, Jatah = 0, Konsi = 0 });

			return result;
		}

		public static void CheckIsInUseSaldoAwal(UnitOfWork session) {
			var setting = new SirkulasiSetting(session);
			if (!string.IsNullOrEmpty(setting.TanggalAwalPiutang)) {
				var tgl = Convert.ToDateTime(setting.TanggalAwalPiutang).AddMonths(1);

				if (IntegrasiService.CekPeriodeTutupBuku(session, tgl))
					throw new Utils.Exception("Saldo awal tidak bisa diedit, karena periode nya sudah ditutup.", -1);
			}
		}
	}
	internal class CaraBayarService : ServiceBase<CaraBayar> {
		public CaraBayarService(UnitOfWork connection) : base(connection) { }
		public CaraBayarService(UnitOfWork connection, CaraBayar originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(CaraBayar obj) {
			if (uow.FindObject<BayarKoran>(new BinaryOperator(nameof(BayarKoran.CaraBayar), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di pembayaran.", obj.Alias));

			return true;
		}
		protected internal override bool CheckBeforeSave(CaraBayar obj) {
			if (obj.Akun == null) throw new Utils.Exception("Masukkan COA", -1);
			if (string.IsNullOrEmpty(obj.Alias)) throw new Utils.Exception("Masukkan alias cara bayar", -2);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Akun == obj.Akun) return true;
			if (uow.FindObject<CaraBayar>(new BinaryOperator(nameof(CaraBayar.Akun), obj.Akun, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("COA sudah ada yang memakai.\r\nSilahkan ganti COA yang lain", -1);

			return true;
		}
	}
}
