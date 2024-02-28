using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Properties;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Konfigurasi;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.MasterData;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi;
using System.Drawing;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011 {
  public class MainClass {
    public static Image GetSmallImage() => Resources.Template_16x16;
    public static Image GetLargeImage() => Resources.Template_32x32;
    public static ModuleId GetModuleId() => ModuleId.SirkulasiKoran;

    private enum MenuName { 
      MasterRute,
      MasterAgen,
      MasterCaraBayar,
      KonfigurasiSirkulasi,
      KonfigurasiIntegrasiSirkulasi,
      TransaksiSaldoAwal,
      TransaksiOrderKoran,
      TransaksiSirkulasiHarian,
      TransaksiReturKoran,
      TransaksiPembayaranKoran,
      TransaksiBatalBayar,
      TransaksiFakturPajak,
      TransaksiEditHarga,
      PelangganAktif,
      PelangganNonAktif,
      PelangganPengingatUltah,
      PelangganKomplain,
      DataRekapOplah,
      DataRincianOplah,
      DataRekapOmzet,
      DataRincianOmzet,
      DataRekapPembayaran,
      DataRincianPembayaran,
      DataRekapPiutang,
      DataRincianPiutang,
      Null
    }
    private static MenuName GetMenu(string menuCode) {
      switch (menuCode) {
        case "1198.01": return MenuName.MasterRute;
        case "1198.02": return MenuName.MasterAgen;
        case "1198.03": return MenuName.MasterCaraBayar;
        case "1199.01": return MenuName.KonfigurasiSirkulasi;
        case "1199.02": return MenuName.KonfigurasiIntegrasiSirkulasi;
        case "1101.01": return MenuName.TransaksiSaldoAwal;
        case "1101.02": return MenuName.TransaksiOrderKoran;
        case "1101.03": return MenuName.TransaksiSirkulasiHarian;
        case "1101.04": return MenuName.TransaksiReturKoran;
        case "1101.05": return MenuName.TransaksiPembayaranKoran;
        case "1101.06": return MenuName.TransaksiBatalBayar;
        case "1101.98": return MenuName.TransaksiFakturPajak;
        case "1101.99": return MenuName.TransaksiEditHarga;
        case "1102.01": return MenuName.PelangganAktif;
        case "1102.02": return MenuName.PelangganNonAktif;
        case "1102.03": return MenuName.PelangganPengingatUltah;
        case "1102.04": return MenuName.PelangganKomplain;
        case "1103.01": return MenuName.DataRekapOplah;
        case "1103.02": return MenuName.DataRincianOplah;
        case "1103.03": return MenuName.DataRekapOmzet;
        case "1103.04": return MenuName.DataRincianOmzet;
        case "1103.05": return MenuName.DataRekapPembayaran;
        case "1103.06": return MenuName.DataRincianPembayaran;
        case "1103.07": return MenuName.DataRekapPiutang;
        case "1103.08": return MenuName.DataRincianPiutang;
        default: return MenuName.Null;
      }
    }
    public static NuSoftForm GetForm(string menuCode) {
      switch (GetMenu(menuCode)) {
        case MenuName.MasterRute: return new UI_Rute();
        case MenuName.MasterAgen: return new UI_Agen();
        case MenuName.MasterCaraBayar: return new UI_CaraBayar();
        case MenuName.KonfigurasiSirkulasi: return new UI_SettingSirkulasi();
        case MenuName.KonfigurasiIntegrasiSirkulasi: return new UI_IntegrasiKoran();
        case MenuName.TransaksiSaldoAwal: return new UI_SaldoAwalAgen();
        case MenuName.TransaksiOrderKoran: return new UI_OrderKoran();
        case MenuName.TransaksiSirkulasiHarian: return new UI_SirkulasiHarian();
        case MenuName.TransaksiReturKoran: return new UI_Retur();
        case MenuName.TransaksiPembayaranKoran: return new UI_Pembayaran();
        case MenuName.TransaksiBatalBayar: return new UI_BatalBayar();
        case MenuName.TransaksiFakturPajak: return new UI_FPKeluaran(GetModuleId(), false);
        case MenuName.TransaksiEditHarga: return new UI_EditHarga();
        case MenuName.PelangganAktif: return new UI_Pelanggan(true);
        case MenuName.PelangganNonAktif: return new UI_Pelanggan(false);
        case MenuName.PelangganPengingatUltah: return new UI_PelangganUlangTahun();
        case MenuName.PelangganKomplain: return new UI_Komplain();
        case MenuName.DataRekapOplah: return new UI_RekapOplah();
        case MenuName.DataRincianOplah: return new UI_RincianOplah();
        case MenuName.DataRekapOmzet: return new UI_RekapOmzet();
        case MenuName.DataRincianOmzet: return new UI_RincianOmzet();
        case MenuName.DataRekapPembayaran: return new UI_RekapPembayaran();
        case MenuName.DataRincianPembayaran: return new UI_RincianPembayaran();
        case MenuName.DataRekapPiutang: return new UI_RekapPiutang();
        case MenuName.DataRincianPiutang: return new UI_RincianPiutang();
        default: return null;
      }
    }

    internal enum ReportName {
      OrderSampul,
      OrderRekap,
      OrderRincian,
      OrderLabel,
      SirkulasiHarianRekap,
      SirkulasiHarianRincian,
      SirkulasiBulananRekap,
      SirkulasiBulananRincian,
      AgenTagihanBulanan,
      AgenTagihanLabel,
      AgenKwitansi,
      AgenPembayaranHarianRekap,
      PelangganKwitansi,
      PelangganDaftar,
      BulananOmzetPerTanggalRekap,
      BulananOmzetPerRuteRekap,
      BulananOmzetPerRuteRincian,
      BulananPembayaranRekap,
      BulananPembayaranRincian,
      BulananPiutangRekap,
      BulananPiutangRincian,
      Null
    }
    internal static ReportName GetReport(string reportCode) {
      switch (reportCode) {
        case "1101.01": return ReportName.OrderSampul;
        case "1101.02": return ReportName.OrderRekap;
        case "1101.03": return ReportName.OrderRincian;
        case "1101.04": return ReportName.OrderLabel;
        case "1102.01": return ReportName.SirkulasiHarianRekap;
        case "1102.02": return ReportName.SirkulasiHarianRincian;
        case "1102.03": return ReportName.SirkulasiBulananRekap;
        case "1102.04": return ReportName.SirkulasiBulananRincian;
        case "1103.01": return ReportName.AgenTagihanBulanan;
        case "1103.02": return ReportName.AgenTagihanLabel;
        case "1103.03": return ReportName.AgenKwitansi;
        case "1103.04": return ReportName.AgenPembayaranHarianRekap;
        case "1104.01": return ReportName.PelangganKwitansi;
        case "1104.02": return ReportName.PelangganDaftar;
        case "1105.01": return ReportName.BulananOmzetPerTanggalRekap;
        case "1105.02": return ReportName.BulananOmzetPerRuteRekap;
        case "1105.03": return ReportName.BulananOmzetPerRuteRincian;
        case "1105.04": return ReportName.BulananPembayaranRekap;
        case "1105.05": return ReportName.BulananPembayaranRincian;
        case "1105.06": return ReportName.BulananPiutangRekap;
        case "1105.07": return ReportName.BulananPiutangRincian;
        default: return ReportName.Null;
      }
    }
    public static ReportFilter GetReportFilter(string reportCode) {
      var kode = GetReport(reportCode);
      switch (kode) {
        case ReportName.OrderSampul:
        case ReportName.OrderRekap:
        case ReportName.OrderRincian:
        case ReportName.SirkulasiHarianRekap: 
        case ReportName.SirkulasiHarianRincian: return new UI_FilterTanggal(kode);
        case ReportName.OrderLabel:
        case ReportName.AgenPembayaranHarianRekap: return new UI_FilterTanggalAgenWilayah(kode);
        case ReportName.SirkulasiBulananRekap:
        case ReportName.SirkulasiBulananRincian:
        case ReportName.BulananOmzetPerTanggalRekap:
        case ReportName.BulananOmzetPerRuteRekap:
        case ReportName.BulananOmzetPerRuteRincian:
        case ReportName.BulananPembayaranRekap:
        case ReportName.BulananPembayaranRincian:
        case ReportName.BulananPiutangRekap:
        case ReportName.BulananPiutangRincian: return new UI_FilterBulan(kode);
        case ReportName.AgenTagihanBulanan: return new UI_FilterBulanAgenWilayah(kode);
        case ReportName.AgenTagihanLabel: return new UI_FilterAgenWilayah(kode);
        case ReportName.AgenKwitansi: return new UI_FilterPembayaranAgen(kode);
        case ReportName.PelangganKwitansi:
        case ReportName.PelangganDaftar: return new UI_FilterPelanggan(kode);
        default: return null;
      }
    }
  }
}