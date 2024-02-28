using DevExpress.Xpo;
using NuSoft.Core.Modules;
using NuSoft.NPO.Modules;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services {
	public class TaxSetting : SettingBase {
		public TaxSetting(UnitOfWork connection) : base(connection) { }
		public override ModuleId ModuleId() => MainClass.GetModuleId();

		public string PerusahaanNama { get; set; }
		public string PerusahaanAlamat { get; set; }
		public string PerusahaanNPWP { get; set; }
		public DateTime PerusahaanTglPKP { get; set; }

		public bool PPnAktif { get; set; }
		public int PPnProsentase { get; set; }
		public int PPh23Prosentase { get; set; }
		public decimal PPh21PengaliNonNpwpPersen { get; set; }
		public decimal PPh21DppProsentase { get; set; }

		public bool TampilkanNoInvoice { get; set; }
	}
}
