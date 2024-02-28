using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services {
	internal class KelompokOmzetService : ServiceBase<KelompokOmzet> {
		public KelompokOmzetService(UnitOfWork connection) : base(connection) { }
		public KelompokOmzetService(UnitOfWork connection, KelompokOmzet originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(KelompokOmzet obj) {
			if (uow.FindObject<Wilayah>(new BinaryOperator(nameof(Wilayah.KelompokOmzet), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di wilayah.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(KelompokOmzet obj) {
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode kelompok omzet", -1);
			if (string.IsNullOrEmpty(obj.TtdNama)) throw new Utils.Exception("Masukkan nama penandatangan", -2);
			if (string.IsNullOrEmpty(obj.TtdJabatan)) throw new Utils.Exception("Masukkan nama penandatangan", -3);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<KelompokOmzet>(new BinaryOperator(nameof(KelompokOmzet.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode kelompok omzet sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -1);

			return true;
		}
	}
	internal class WilayahService : ServiceBase<Wilayah> {
		public WilayahService(UnitOfWork connection) : base(connection) { }
		public WilayahService(UnitOfWork connection, Wilayah originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Wilayah obj) {
			if (uow.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.Wilayah), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di invoice iklan.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(Wilayah obj) {
			if (obj.Regional == null) throw new Utils.Exception("Masukkan regional", -1);
			if (obj.KelompokOmzet == null) throw new Utils.Exception("Masukkan kelompok omzet", -2);
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode wilayah", -3);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama wilayah", -4);
			if (obj.Kode.Length > 3) throw new Utils.Exception("Panjang karakter kode wilayah tidak boleh lebih dari 3", -3);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<Wilayah>(new BinaryOperator(nameof(Wilayah.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode wilayah sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -3);

			return true;
		}
	}

	internal class SalesService : ServiceBase<Sales> {
		public SalesService(UnitOfWork connection) : base(connection) { }
		public SalesService(UnitOfWork connection, Sales originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Sales obj) {
			if (uow.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.Sales), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di invoice iklan.", obj.Kode));
			if (uow.FindObject<PembayaranIklan>(new BinaryOperator(nameof(PembayaranIklan.Sales), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di pembayaran iklan.", obj.Kode));
			if (uow.FindObject<PencairanKomisi>(new BinaryOperator(nameof(PencairanKomisi.Sales), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di pembayaran komisi.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(Sales obj) {
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode sales", -1);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama sales", -2);
			if (string.IsNullOrEmpty(obj.NPWP)) throw new Utils.Exception("Masukkan npwp sales.\r\nJika tidak punya, masukkan " + PPnKeluaranService.GetDefaultNPWP(), -3);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<Sales>(new BinaryOperator(nameof(Sales.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode sales sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -2);

			return true;
		}
	}
	internal class PemasangService : ServiceBase<Pemasang> {
		public PemasangService(UnitOfWork connection) : base(connection) { }
		public PemasangService(UnitOfWork connection, Pemasang originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Pemasang obj) {
			if (uow.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.Pemasang), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di invoice iklan.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(Pemasang obj) {
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode pemasang", -1);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama pemasang", -2);
			if (string.IsNullOrEmpty(obj.NPWP)) throw new Utils.Exception("Masukkan npwp pemasang.\r\nJika tidak punya, masukkan " + PPnKeluaranService.GetDefaultNPWP(), -3);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<Pemasang>(new BinaryOperator(nameof(Pemasang.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode pemasang sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -2);

			return true;
		}
	}

	internal class CaraBayarService : ServiceBase<CaraBayar> {
		public CaraBayarService(UnitOfWork connection) : base(connection) { }
		public CaraBayarService(UnitOfWork connection, CaraBayar originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(CaraBayar obj) {
			if (uow.FindObject<PembayaranIklan>(new BinaryOperator(nameof(PembayaranIklan.CaraBayar), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di pembayaran iklan.", obj.Alias));
			if (uow.FindObject<PencairanKomisi>(new BinaryOperator(nameof(PencairanKomisi.CaraBayar), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di pembayaran komisi.", obj.Alias));
			if (uow.FindObject<PencairanCashback>(new BinaryOperator(nameof(PencairanCashback.CaraBayar), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di pembayaran cashback.", obj.Alias));

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
	internal class TipeInvoiceService : ServiceBase<TipeInvoice> {
		public TipeInvoiceService(UnitOfWork connection) : base(connection) { }
		public TipeInvoiceService(UnitOfWork connection, TipeInvoice originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(TipeInvoice obj) {
			if (uow.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.TipeInvoice), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di invoice.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(TipeInvoice obj) {
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode tipe invoice", -1);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama tipe invoice", -2);
			if (obj.Kode.Length > 3) throw new Utils.Exception("Panjang karakter kode tipe invoice tidak boleh lebih dari 3", -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<TipeInvoice>(new BinaryOperator(nameof(TipeInvoice.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode tipe invoice sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -1);

			return true;
		}
	}
	internal class KurirService : ServiceBase<Kurir> {
		public KurirService(UnitOfWork connection) : base(connection) { }
		public KurirService(UnitOfWork connection, Kurir originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Kurir obj) {
			if (uow.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.Kurir), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di invoice.", obj.Nama));

			return true;
		}
		protected internal override bool CheckBeforeSave(Kurir obj) {
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama kurir", -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Nama == obj.Nama) return true;
			if (uow.FindObject<Kurir>(new BinaryOperator(nameof(Kurir.Nama), obj.Nama, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nama kurir sudah ada yang memakai.\r\nSilahkan ganti nama yang lain", -1);

			return true;
		}
	}

	internal class TarifIklanService : ServiceBase<TarifIklan> {
		public TarifIklanService(UnitOfWork connection) : base(connection) { }
		public TarifIklanService(UnitOfWork connection, TarifIklan originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(TarifIklan obj) {
			if (uow.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.TarifIklan), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di invoice.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(TarifIklan obj) {
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode tarif iklan", -1);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama tarif iklan", -2);
			if (obj.TipeIklan == default) throw new Utils.Exception("Masukkan tipe iklan", -3);
			if (obj.Tarif == default) throw new Utils.Exception("Masukkan tarif iklan", -4);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<TarifIklan>(new BinaryOperator(nameof(TarifIklan.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode tarif iklan sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -1);

			return true;
		}
	}
	internal class ProdukService : ServiceBase<Produk> {
		public ProdukService(UnitOfWork connection) : base(connection) { }
		public ProdukService(UnitOfWork connection, Produk originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Produk obj) {
			if (uow.FindObject<Merk>(new BinaryOperator(nameof(Merk.Produk), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di merk.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(Produk obj) {
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode produk", -1);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama produk", -2);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<Produk>(new BinaryOperator(nameof(Produk.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode produk sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -1);

			return true;
		}
	}
	internal class MerkService : ServiceBase<Merk> {
		public MerkService(UnitOfWork connection) : base(connection) { }
		public MerkService(UnitOfWork connection, Merk originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Merk obj) {
			if (uow.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.Merk), obj, BinaryOperatorType.Equal)) != null)
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di invoice.", obj.Kode));

			return true;
		}
		protected internal override bool CheckBeforeSave(Merk obj) {
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode merk", -1);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama merk", -2);
			if (obj.Produk == null) throw new Utils.Exception("Masukkan produk", -3);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<Merk>(new BinaryOperator(nameof(Merk.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode merk sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -1);

			return true;
		}
	}
}
