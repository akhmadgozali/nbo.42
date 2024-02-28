using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services {
	public class PPnMasukanService : ServiceBase<PPnMasukan> {
		public PPnMasukanService(UnitOfWork connection) : base(connection) { }
		public PPnMasukanService(UnitOfWork connection, PPnMasukan originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(PPnMasukan obj) { return CheckDataBeforeDeleted(obj, ModuleId.TaxManagement); }
		protected internal override bool CheckBeforeSave(PPnMasukan obj) { return CheckDataBeforeSave(uow, obj, _dataOriginalEdit); }
		protected internal override void SaveAction(PPnMasukan obj) { SaveData(obj, ModuleId.TaxManagement); }

		private static bool CheckDataBeforeDeleted(PPnMasukan obj, ModuleId modulesId) {
			if (obj.ModuleId != modulesId) throw new Utils.Exception(string.Format("Data {0} tidak bisa dihapus, karena harus dari module " + obj.ModuleId.ToString(), obj.NomorFaktur));

			return true;
		}
		private static bool CheckDataBeforeSave(UnitOfWork session, PPnMasukan obj, PPnMasukan originalEdit) {
			if (string.IsNullOrEmpty(obj.NomorFaktur)) throw new Utils.Exception("Masukkan nomor faktur", -1);
			if (obj.Tanggal == null) throw new Utils.Exception("Masukkan tanggal", -2);
			if (string.IsNullOrEmpty(obj.SupplierNama)) throw new Utils.Exception("Masukkan nama supplier", -3);
			if (string.IsNullOrEmpty(obj.SupplierNPWP)) throw new Utils.Exception("Masukkan npwp supplier", -4);
			if (obj.MasaPajak == 0) throw new Utils.Exception("Masukkan masa pajak", -5);
			if (obj.TahunPajak == 0) throw new Utils.Exception("Masukkan tahun pajak", -6);
			if (obj.Dpp == 0) throw new Utils.Exception("Masukkan dpp", -7);
			if ((obj.PPn == 0) && (obj.PPnBM == 0)) throw new Utils.Exception("Masukkan ppn", -8);

			// check no seri
			if (!session.IsNewObject(obj) && originalEdit.NomorFaktur == obj.NomorFaktur) return true;
			if (session.FindObject<PPnMasukan>(new BinaryOperator(nameof(PPnMasukan.NomorFaktur), obj.NomorFaktur, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor faktur pajak masukan sudah ada yang memakai.\r\nSilahkan ganti nomor yang lain", -1);

			return true;
		}
		private static void SaveData(PPnMasukan obj, ModuleId moduleId) {
			obj.ModuleId = moduleId;
		}

		public static void SaveData(UnitOfWork session, PPnMasukan obj, PPnMasukan originalEdit, ModuleId moduleId) {
			if (CheckDataBeforeSave(session, obj, originalEdit)) SaveData(obj, moduleId);
		}
	}
}
