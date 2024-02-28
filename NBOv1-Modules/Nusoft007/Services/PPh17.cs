using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services {
	public class TarihPPh17Service : ServiceBase<TarifPPh17> {
		public TarihPPh17Service(UnitOfWork connection) : base(connection) { }
		public TarihPPh17Service(UnitOfWork connection, TarifPPh17 originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(TarifPPh17 obj) { return true; }
		protected internal override bool CheckBeforeSave(TarifPPh17 obj) {
			if (obj.Tarif == default) throw new Utils.Exception("Masukkan tarif pph 17", -1);

			return true;
		}

		public static decimal GetTarif(UnitOfWork session, decimal penghasilan) {
			var data = new XPQuery<TarifPPh17>(session).ToList();
			foreach (var x in data) {
				if (x.BatasBawah == 0) {
					if (penghasilan <= x.BatasAtas) return x.Tarif;
				}
				else if (x.BatasAtas == 0) {
					if (penghasilan > x.BatasBawah) return x.Tarif;
				}
				else {
					if (penghasilan <= x.BatasAtas && penghasilan > x.BatasBawah) return x.Tarif;
				}
			}
			return 0;
		}
	}
}
