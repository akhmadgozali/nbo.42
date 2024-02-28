using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using System.IO;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services {
	public class PPh23Service : ServiceBase<PPh23> {
		public PPh23Service(UnitOfWork connection) : base(connection) { }
		public PPh23Service(UnitOfWork connection, PPh23 originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(PPh23 obj) { return true; }
		protected internal override bool CheckBeforeSave(PPh23 obj) { return CheckDataBeforeSave(uow, obj, _dataOriginalEdit); }
		protected internal override void SaveAction(PPh23 obj) { SaveData(obj, ModuleId.TaxManagement); }

		private static bool CheckDataBeforeSave(UnitOfWork session, PPh23 obj, PPh23 originalEdit) {
			if (string.IsNullOrEmpty(obj.NoInvoice)) throw new Utils.Exception("Masukkan nomor invoice", -1);
			if (string.IsNullOrEmpty(obj.NoKwitansi)) throw new Utils.Exception("Masukkan nomor kwitansi", -2);
			if (obj.TanggalInvoice == default) throw new Utils.Exception("Masukkan tanggal invoice", -3);
			if (obj.TanggalKwitansi == default) throw new Utils.Exception("Masukkan tanggal kwitansi", -4);
			if (string.IsNullOrEmpty(obj.Wilayah)) throw new Utils.Exception("Masukkan wilayah", -5);
			if (string.IsNullOrEmpty(obj.KeteranganInvoice)) throw new Utils.Exception("Masukkan keterangan invoice", -6);
			if (string.IsNullOrEmpty(obj.Pemasang)) throw new Utils.Exception("Masukkan nama pelanggan", -7);
			if (obj.DppPPh23 == default) throw new Utils.Exception("Masukkan dpp pph 23", -8);
			if (obj.PPh23Persen == default) throw new Utils.Exception("Masukkan prosentase pph 23", -9);
			if (obj.PPh23Nominal == default) throw new Utils.Exception("Masukkan nominal pph 23", -10);

			if (!session.IsNewObject(obj) && originalEdit.NoInvoice == obj.NoInvoice) return true;
			if (session.FindObject<PPh23>(new BinaryOperator(nameof(PPh23.NoInvoice), obj.NoInvoice, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("No. Invoice sudah pernah di entri sebelumnya.\r\nSilahkan cek data", -1);

			return true;
		}
		private static void SaveData(PPh23 obj, ModuleId moduleId) {
			obj.ModuleId = moduleId;
		}

		public static void SaveData(UnitOfWork session, PPh23 obj, PPh23 originalEdit, ModuleId moduleId) {
			if (CheckDataBeforeSave(session, obj, originalEdit)) SaveData(obj, moduleId);
		}

		public static void UploadBuktiPotong(UnitOfWork session, string LokasiFile, PPh23 data) {
			var fileInfo = new FileInfo(LokasiFile);
			if (fileInfo.Length > 1024000) throw new System.Exception("Ukuran max file yang diupload adalah 1024 KB.\r\nUkuran file '" + LokasiFile + "' adalah " + fileInfo.Length / 1000 + " KB.");

			if (data.BuktiPotong == null) data.BuktiPotong = new BuktiPotongPPh(session);
			data.BuktiPotong.LokasiFile = LokasiFile;
			data.BuktiPotong.FileBlob = Utils.Binary.ConvertToBinary(LokasiFile);

			session.CommitChanges();
		}
	}
}
