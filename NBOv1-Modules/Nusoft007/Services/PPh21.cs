using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using System.IO;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services {
	public class PPh21KomisiService : ServiceBase<PPh21Komisi> {
		public PPh21KomisiService(UnitOfWork connection) : base(connection) { }
		public PPh21KomisiService(UnitOfWork connection, PPh21Komisi originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(PPh21Komisi obj) { return true; }
		protected internal override bool CheckBeforeSave(PPh21Komisi obj) { return CheckDataBeforeSave(uow, obj, _dataOriginalEdit); }
		protected internal override void SaveAction(PPh21Komisi obj) { SaveData(obj, ModuleId.TaxManagement); }

		private static bool CheckDataBeforeSave(UnitOfWork session, PPh21Komisi obj, PPh21Komisi originalEdit) {
			if (string.IsNullOrEmpty(obj.NoInvoice)) throw new Utils.Exception("Masukkan nomor invoice", -1);
			if (string.IsNullOrEmpty(obj.NoKwitansi)) throw new Utils.Exception("Masukkan nomor kwitansi", -2);
			if (obj.TanggalInvoice == default) throw new Utils.Exception("Masukkan tanggal invoice", -3);
			if (obj.TanggalKwitansi == default) throw new Utils.Exception("Masukkan tanggal kwitansi", -4);
			if (string.IsNullOrEmpty(obj.Wilayah)) throw new Utils.Exception("Masukkan wilayah", -5);
			if (string.IsNullOrEmpty(obj.KeteranganInvoice)) throw new Utils.Exception("Masukkan keterangan invoice", -6);
			if (string.IsNullOrEmpty(obj.Penerima)) throw new Utils.Exception("Masukkan nama penerima komisi", -7);
			if (string.IsNullOrEmpty(obj.NPWPPenerima)) throw new Utils.Exception("Masukkan npwp penerima komisi", -8);
			if (obj.DppKomisi == default) throw new Utils.Exception("Masukkan dpp komisi", -9);
			if (obj.KomisiPersen == default) throw new Utils.Exception("Masukkan prosentase komisi", -10);
			if (obj.KomisiNominal == default) throw new Utils.Exception("Masukkan nominal komisi", -11);
			if (obj.TarifPPh21 == default) throw new Utils.Exception("Masukkan tarif pph", -12);
			if (obj.PPh21 == default) throw new Utils.Exception("Masukkan nominal potongan pph 21", -12);

			if (!session.IsNewObject(obj) && originalEdit.NoInvoice == obj.NoInvoice) return true;
			if (session.FindObject<PPh21Komisi>(new BinaryOperator(nameof(PPh21Komisi.NoInvoice), obj.NoInvoice, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("No. Invoice sudah pernah di entri sebelumnya.\r\nSilahkan cek data", -1);

			return true;
		}
		private static void SaveData(PPh21Komisi obj, ModuleId moduleId) {
			obj.ModuleId = moduleId;
		}

		public static void SaveData(UnitOfWork session, PPh21Komisi obj, PPh21Komisi originalEdit, ModuleId moduleId) {
			if (CheckDataBeforeSave(session, obj, originalEdit)) SaveData(obj, moduleId);
		}

		public static void UploadBuktiPotong(UnitOfWork session, string LokasiFile, PPh21Komisi data) {
			var fileInfo = new FileInfo(LokasiFile);
			if (fileInfo.Length > 1024000) throw new System.Exception("Ukuran max file yang diupload adalah 1024 KB.\r\nUkuran file '" + LokasiFile + "' adalah " + fileInfo.Length / 1000 + " KB.");

			if (data.BuktiPotong == null) data.BuktiPotong = new BuktiPotongPPh(session);
			data.BuktiPotong.LokasiFile = LokasiFile;
			data.BuktiPotong.FileBlob = Utils.Binary.ConvertToBinary(LokasiFile);

			session.CommitChanges();
		}
	}
}
