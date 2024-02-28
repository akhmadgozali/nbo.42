using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Properties;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.Konfigurasi;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPh;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn;
using System.Drawing;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007 {
  public class MainClass {
    public static Image GetSmallImage() => Resources.Percentage_16x16;
    public static Image GetLargeImage() => Resources.Percentage_32x32;
    public static ModuleId GetModuleId() => ModuleId.TaxManagement;

    private enum MenuName {
      PPnNomorSeri,
      PPnDaftar,
      PPnKeluaran,
      PPnMasukan,
      PPhTarif17,
      PPh21Komisi,
      PPh23,
      KonfigurasiPajak,
      Null
    }
    private static MenuName GetMenu(string menuCode) {
      switch (menuCode) {
        case "0701.01": return MenuName.PPnNomorSeri;
        case "0701.02": return MenuName.PPnDaftar;
        case "0701.03": return MenuName.PPnKeluaran;
        case "0701.06": return MenuName.PPnMasukan;
        case "0702.01": return MenuName.PPhTarif17;
        case "0702.02": return MenuName.PPh21Komisi;
        case "0702.03": return MenuName.PPh23;
        case "0709.01": return MenuName.KonfigurasiPajak;
        default: return MenuName.Null;
      }
    }
    public static NuSoftForm GetForm(string menuCode) {
      switch (GetMenu(menuCode)) {
        case MenuName.KonfigurasiPajak: return new UI_SettingPajak();
        case MenuName.PPhTarif17: return new UI_TarifPPhPs17();
        case MenuName.PPh21Komisi: return new UI_PPh21();
        case MenuName.PPh23: return new UI_PPh23();
        case MenuName.PPnNomorSeri: return new UI_NomorFaktur();
        case MenuName.PPnDaftar: return new UI_FPKeluaran(GetModuleId(), true);
        case MenuName.PPnKeluaran: return new UI_FPKeluaran(GetModuleId(), false);
        case MenuName.PPnMasukan: return new UI_FPMasukan(GetModuleId());
        default: return null;
      }
    }

    internal enum ReportName {
      Null
    }
    private static ReportName GetReport(string reportCode) {
      switch (reportCode) {
        default: return ReportName.Null;
      }
    }
    public static ReportFilter GetReportFilter(string reportCode) {
      var kode = GetReport(reportCode);
      switch (kode) {
        default: return null;
      }
    }
  }
}