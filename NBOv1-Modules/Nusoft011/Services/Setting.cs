using DevExpress.Xpo;
using NuSoft.Core.Modules;
using NuSoft.NPO.Modules;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class SirkulasiSetting : SettingBase {
    public SirkulasiSetting(UnitOfWork connection) : base(connection) { }
		public override ModuleId ModuleId() {
      return MainClass.GetModuleId();
		}

		public string FormatNomorPembayaran { get; set; }
		public string UraianPembayaran { get; set; }

		public string TagihanTTdNama { get; set; }
		public string TagihanTTdJabatan { get; set; }
		public string TagihanRekeningBank { get; set; }
		public int TagihanJatuhTempo { get; set; }
		public string OrderCetakTtdNama { get; set; }
		public string OrderCetakTtdJabatan { get; set; }

		public string TanggalAwalPiutang { get; set; }

		public int SatuKoliPerEks { get; set; }
		public int ToleransiKoli { get; set; }
	}

	internal class IntegrasiSirkulasiSetting : SettingBase {
		public IntegrasiSirkulasiSetting(UnitOfWork connection) : base(connection) { }
		public override ModuleId ModuleId() { return MainClass.GetModuleId(); }

		public bool AktifkanIntegrasi { get; set; }
		public int PeriodeBulanMulai { get; set; }
		public int PeriodeTahunMulai { get; set; }
		public string KeteranganOmzet { get; set; }
		public string KeteranganPembayaran { get; set; }
		public int MataUangDefault { get; set; }
		public long KaryawanDefault { get; set; }

		public bool PajakOmzetKenaPPn { get; set; }
		public decimal PajakPersenPPn { get; set; }
		public int PajakCoaHutangPPn { get; set; }
		public bool PajakGabungPPnNonNPWP { get; set; }
		public string PajakGabungPPnNonNPWPAtasNama { get; set; }
	}
}