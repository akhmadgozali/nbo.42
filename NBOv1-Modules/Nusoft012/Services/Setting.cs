using DevExpress.Xpo;
using NuSoft.Core.Modules;
using NuSoft.NPO.Modules;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services {
	internal class IklanSetting : SettingBase {
		public IklanSetting(UnitOfWork connection) : base(connection) { }
		public override ModuleId ModuleId() { return MainClass.GetModuleId(); }

		public string FormatNomorInvoice { get; set; }
		public string FormatNomorOrder { get; set; }
		public string FormatNomorPembayaran { get; set; }
		public string FormatNomorPencairanCashback { get; set; }
		public string FormatNomorPencairanKomisi { get; set; }
		public string UraianOrder { get; set; }
		public string CaraBayarOrder { get; set; }
		public string UraianPembayaran { get; set; }
		public string UraianPencairanCashback { get; set; }
		public string UraianPencairanKomisi { get; set; }

		public int UmurPiutang1 { get; set; }
		public int UmurPiutang2 { get; set; }
		public int UmurPiutang3 { get; set; }
		public int UmurPiutang4 { get; set; }

		public decimal PajakPersenPPn { get; set; }
		public int MaxKarakterDeret { get; set; }
		public bool KomisiDipotongPPh21 { get; set; }

		public string TtdNamaKomisiMengajukan { get; set; }
		public string TtdJabatanKomisiMengajukan { get; set; }
		public string TtdNamaKomisiMenyetujui { get; set; }
		public string TtdJabatanKomisiMenyetujui { get; set; }
		public string TtdNamaKomisiMengetahui { get; set; }
		public string TtdJabatanKomisiMengetahui { get; set; }

		public string TtdNamaCashbackMengajukan { get; set; }
		public string TtdJabatanCashbackMengajukan { get; set; }
		public string TtdNamaCashbackMenyetujui { get; set; }
		public string TtdJabatanCashbackMenyetujui { get; set; }
		public string TtdNamaCashbackMengetahui { get; set; }
		public string TtdJabatanCashbackMengetahui { get; set; }
	}

	internal class IntegrasiIklanSetting : SettingBase {
		public IntegrasiIklanSetting(UnitOfWork connection) : base(connection) { }
		public override ModuleId ModuleId() { return MainClass.GetModuleId(); }

		public bool AktifkanIntegrasi { get; set; }
		public int PeriodeBulanMulai { get; set; }
		public int PeriodeTahunMulai { get; set; }
		public DateTime PeriodeMulai => new DateTime(PeriodeTahunMulai, PeriodeBulanMulai, 1);
		public string KeteranganOmzet { get; set; }
		public string KeteranganPembayaran { get; set; }
		public int MataUangDefault { get; set; }

		public bool PajakGabungPPnNonNPWP { get; set; }
		public string PajakGabungPPnNonNPWPAtasNama { get; set; }
		public bool PajakTampilkanTanggalTerbit { get; set; }
		public bool PajakTampilkanUkuran { get; set; }

		public int CoaHutangPPn { get; set; }
	}
}