using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Properties;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataCashback;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataKomisi;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Konfigurasi;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Utility;
using System.Drawing;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012 {
  public class MainClass {
    public static Image GetSmallImage() => Resources.StackedLayout_16x16;
    public static Image GetLargeImage() => Resources.StackedLayout_32x32;
    public static ModuleId GetModuleId() => ModuleId.IklanKoran;

    private enum MenuName {
      TransaksiSaldoAwal,
      TransaksiIklanKolom,
      TransaksiIklanDeret,
      TransaksiPenagihanIklan,
      TransaksiGabungIklan,
      TransaksiKoreksiOmzet,
      TransaksiPembayaranIklan,
      TransaksiBatalBayar,
      TransaksiPencairanKomisi,
      TransaksiPencairanCashback,
      UtilityWarningTerbit,
      UtilityEditMateri,
      UtilityPracetak,
      UtilityFakturPajak,
      DataIklanRekapOmzet,
      DataIklanRincianOmzet,
      DataIklanRekapPembayaran,
      DataIklanRincianPembayaran,
      DataIklanRekapPiutang,
      DataIklanRincianPiutang,
      DataIklanPiutangBerjalan,
      DataIklanPiutangJatuhTempo,
      DataIklanRekapUmurPiutang,
      DataIklanRincianUmurPiutang,
      DataKomisiRekapKomisi,
      DataKomisiRincianKomisi,
      DataKomisiRekapPencairanKomisi,
      DataKomisiRincianPencairanKomisi,
      DataKomisiRekapHutangKomisi,
      DataKomisiRincianHutangKomisi,
      DataCashbackRekapCashback,
      DataCashbackRincianCashback,
      DataCashbackRekapPencairanCashback,
      DataCashbackRincianPencairanCashback,
      DataCashbackRekapHutangCashback,
      DataCashbackRincianHutangCashback,
      MasterKelompokOmzet,
      MasterWilayah,
      MasterSales,
      MasterPemasang,
      MasterTipeInvoice,
      MasterCaraBayar,
      MasterTarifIklan,
      MasterProduk,
      MasterMerk,
      MasterKurir,
      SettingIklan,
      SettingIntegrasi,
      Null
    }
    private static MenuName GetMenu(string menuCode) {
      switch (menuCode) {
        case "1201.01": return MenuName.TransaksiSaldoAwal;
        case "1201.02": return MenuName.TransaksiIklanKolom;
        case "1201.03": return MenuName.TransaksiIklanDeret;
        case "1201.04": return MenuName.TransaksiPenagihanIklan;
        case "1201.05": return MenuName.TransaksiGabungIklan;
        case "1201.06": return MenuName.TransaksiKoreksiOmzet;
        case "1201.07": return MenuName.TransaksiPembayaranIklan;
        case "1201.08": return MenuName.TransaksiBatalBayar;
        case "1201.09": return MenuName.TransaksiPencairanKomisi;
        case "1201.10": return MenuName.TransaksiPencairanCashback;
        case "1202.01": return MenuName.UtilityWarningTerbit;
        case "1202.02": return MenuName.UtilityEditMateri;
        case "1202.03": return MenuName.UtilityPracetak;
        case "1202.04": return MenuName.UtilityFakturPajak;
        case "1203.01": return MenuName.DataIklanRekapOmzet;
        case "1203.02": return MenuName.DataIklanRincianOmzet;
        case "1203.03": return MenuName.DataIklanRekapPembayaran;
        case "1203.04": return MenuName.DataIklanRincianPembayaran;
        case "1203.05": return MenuName.DataIklanRekapPiutang;
        case "1203.06": return MenuName.DataIklanRincianPiutang;
        case "1203.07": return MenuName.DataIklanPiutangBerjalan;
        case "1203.08": return MenuName.DataIklanPiutangJatuhTempo;
        case "1203.09": return MenuName.DataIklanRekapUmurPiutang;
        case "1203.10": return MenuName.DataIklanRincianUmurPiutang;
        case "1204.01": return MenuName.DataKomisiRekapKomisi;
        case "1204.02": return MenuName.DataKomisiRincianKomisi;
        case "1204.03": return MenuName.DataKomisiRekapPencairanKomisi;
        case "1204.04": return MenuName.DataKomisiRincianPencairanKomisi;
        case "1204.05": return MenuName.DataKomisiRekapHutangKomisi;
        case "1204.06": return MenuName.DataKomisiRincianHutangKomisi;
        case "1205.01": return MenuName.DataCashbackRekapCashback;
        case "1205.02": return MenuName.DataCashbackRincianCashback;
        case "1205.03": return MenuName.DataCashbackRekapPencairanCashback;
        case "1205.04": return MenuName.DataCashbackRincianPencairanCashback;
        case "1205.05": return MenuName.DataCashbackRekapHutangCashback;
        case "1205.06": return MenuName.DataCashbackRincianHutangCashback;
        case "1298.01": return MenuName.MasterKelompokOmzet;
        case "1298.02": return MenuName.MasterWilayah;
        case "1298.03.01": return MenuName.MasterSales;
        case "1298.03.02": return MenuName.MasterPemasang;
        case "1298.04.01": return MenuName.MasterTipeInvoice;
        case "1298.04.02": return MenuName.MasterCaraBayar;
        case "1298.04.03": return MenuName.MasterTarifIklan;
        case "1298.05.01": return MenuName.MasterProduk;
        case "1298.05.02": return MenuName.MasterMerk;
        case "1298.05.03": return MenuName.MasterKurir;
        case "1299.01": return MenuName.SettingIklan;
        case "1299.02": return MenuName.SettingIntegrasi;
        default: return MenuName.Null;
      }
    }
    public static NuSoftForm GetForm(string menuCode) {
      switch (GetMenu(menuCode)) {
        case MenuName.MasterKelompokOmzet: return new UI_KelompokOmzet();
        case MenuName.MasterWilayah: return new UI_Wilayah();
        case MenuName.MasterSales: return new UI_Sales();
        case MenuName.MasterPemasang: return new UI_Pemasang();
        case MenuName.MasterTipeInvoice: return new UI_TipeInvoice();
        case MenuName.MasterCaraBayar: return new UI_CaraBayar();
        case MenuName.MasterTarifIklan: return new UI_TarifIklan();
        case MenuName.MasterProduk: return new UI_Produk();
        case MenuName.MasterMerk: return new UI_Merk();
        case MenuName.MasterKurir: return new UI_Kurir();
        case MenuName.SettingIklan: return new UI_SettingIklan();
        case MenuName.SettingIntegrasi: return new UI_IntegrasiIklan();
        case MenuName.TransaksiSaldoAwal: return new UI_SaldoAwal();
        case MenuName.TransaksiIklanKolom: return new UI_Iklan(Persistent.ETipeIklan.Kolom);
        case MenuName.TransaksiIklanDeret: return new UI_Iklan(Persistent.ETipeIklan.Deret);
        case MenuName.TransaksiPenagihanIklan: return new UI_IklanPenagihan();
        case MenuName.TransaksiGabungIklan: return new UI_GabungIklan();
        case MenuName.TransaksiKoreksiOmzet: return new UI_KoreksiOmzet();
        case MenuName.TransaksiPembayaranIklan: return new UI_PembayaranIklan();
        case MenuName.TransaksiBatalBayar: return new UI_BatalBayar();
        case MenuName.TransaksiPencairanKomisi: return new UI_PencairanKomisi();
        case MenuName.TransaksiPencairanCashback: return new UI_PencairanCashback();
        case MenuName.UtilityWarningTerbit: return new UI_WarningTerbit();
        case MenuName.UtilityEditMateri: return new UI_EditTanggalTerbit();
        case MenuName.UtilityPracetak: return new UI_Pracetak();
        case MenuName.UtilityFakturPajak: return new UI_FPKeluaran(GetModuleId(), false);
        case MenuName.DataIklanRekapOmzet: return new UI_RekapOmzet();
        case MenuName.DataIklanRincianOmzet: return new UI_RincianOmzet();
        case MenuName.DataIklanRekapPembayaran: return new UI_RekapPembayaran();
        case MenuName.DataIklanRincianPembayaran: return new UI_RincianPembayaran();
        case MenuName.DataIklanRekapPiutang: return new UI_RekapPiutang();
        case MenuName.DataIklanRincianPiutang: return new UI_RincianPiutang();
        case MenuName.DataIklanPiutangBerjalan: return new UI_PiutangBerjalan();
        case MenuName.DataIklanPiutangJatuhTempo: return new UI_PiutangJatuhTempo();
        case MenuName.DataIklanRekapUmurPiutang: return new UI_RekapUmurPiutang();
        case MenuName.DataIklanRincianUmurPiutang: return new UI_RincianUmurPiutang();
        case MenuName.DataKomisiRekapKomisi: return new UI_RekapKomisi();
        case MenuName.DataKomisiRincianKomisi: return new UI_RincianKomisi();
        case MenuName.DataKomisiRekapPencairanKomisi: return new UI_RekapPencairanKomisi();
        case MenuName.DataKomisiRincianPencairanKomisi: return new UI_RincianPencairanKomisi();
        case MenuName.DataKomisiRekapHutangKomisi: return new UI_RekapHutangKomisi();
        case MenuName.DataKomisiRincianHutangKomisi: return new UI_RincianHutangKomisi();
        case MenuName.DataCashbackRekapCashback: return new UI_RekapCashback();
        case MenuName.DataCashbackRincianCashback: return new UI_RincianCashback();
        case MenuName.DataCashbackRekapPencairanCashback: return new UI_RekapPencairanCashback();
        case MenuName.DataCashbackRincianPencairanCashback: return new UI_RincianPencairanCashback();
        case MenuName.DataCashbackRekapHutangCashback: return new UI_RekapHutangCashback();
        case MenuName.DataCashbackRincianHutangCashback: return new UI_RincianHutangCashback();
        default: return null;
      }
    }

    public static ReportFilter GetReportFilter(string reportCode) {
      switch (reportCode) {
        case ReportCodeTransaksiInvoiceKolom:
        case ReportCodeTransaksiInvoiceDeret:
        case ReportCodeTransaksiInvoiceGabungan:
        case ReportCodeTransaksiOrderIklan:
        case ReportCodeTransaksiTandaTerima: return new UI_FilterInvoice(reportCode);
        case ReportCodeTransaksiKwitansi:
        case ReportCodeTransaksiSuratKomisi:
        case ReportCodeTransaksiSuratCashback:
        case ReportCodeTransaksiBuktiPencairanKomisi:
        case ReportCodeTransaksiBuktiPencairanCashback: return new UI_FilterKwitansi(reportCode);
        case ReportCodePiutangIklanTermuatKolom:
        case ReportCodePiutangIklanTermuatDeret: return new UI_FilterRegister(reportCode);
        case ReportCodePiutangPenerimaanPembayaran:
        case ReportCodePiutangRincianPembayaran: return new UI_FilterPembayaran(reportCode);
        case ReportCodePiutangPiutangJatuhTempo: return new UI_FilterJatuhTempo(reportCode);
        case ReportCodePiutangKonfirmasiPiutang: return new UI_FilterKonfirmasiPiutang(reportCode);
        case ReportCodeBulananRekapOmzet:
        case ReportCodeBulananRincianOmzet:
        case ReportCodeBulananRekapPembayaran:
        case ReportCodeBulananRincianPembayaran:
        case ReportCodeBulananRekapPiutang:
        case ReportCodeBulananRincianPiutang:
        case ReportCodeBulananRekapHutangKomisi:
        case ReportCodeBulananRincianHutangKomisi:
        case ReportCodeBulananRekapHutangCashback:
        case ReportCodeBulananRincianHutangCashback:
          return new UI_FilterBulan(reportCode);
        default: return null;
      }
    }

    internal const string ReportCodeTransaksiInvoiceKolom = "1201.01";
    internal const string ReportCodeTransaksiInvoiceDeret = "1201.02";
    internal const string ReportCodeTransaksiInvoiceGabungan = "1201.03";
    internal const string ReportCodeTransaksiOrderIklan = "1201.04";
    internal const string ReportCodeTransaksiTandaTerima = "1201.05";
    internal const string ReportCodeTransaksiKwitansi = "1201.06";
    internal const string ReportCodeTransaksiSuratKomisi = "1201.07";
    internal const string ReportCodeTransaksiSuratCashback = "1201.08";
    internal const string ReportCodeTransaksiBuktiPencairanKomisi = "1201.09";
    internal const string ReportCodeTransaksiBuktiPencairanCashback = "1201.10";
    internal const string ReportCodePiutangIklanTermuatKolom = "1202.01";
    internal const string ReportCodePiutangIklanTermuatDeret = "1202.02";
    internal const string ReportCodePiutangPenerimaanPembayaran = "1202.03";
    internal const string ReportCodePiutangRincianPembayaran = "1202.04";
    internal const string ReportCodePiutangPiutangJatuhTempo = "1202.05";
    internal const string ReportCodePiutangKonfirmasiPiutang = "1202.06";
    internal const string ReportCodeBulananRekapOmzet = "1203.01";
    internal const string ReportCodeBulananRincianOmzet = "1203.02";
    internal const string ReportCodeBulananRekapPembayaran = "1203.03";
    internal const string ReportCodeBulananRincianPembayaran = "1203.04";
    internal const string ReportCodeBulananRekapPiutang = "1203.05";
    internal const string ReportCodeBulananRincianPiutang = "1203.06";
    internal const string ReportCodeBulananRekapHutangKomisi = "1203.07";
    internal const string ReportCodeBulananRincianHutangKomisi = "1203.08";
    internal const string ReportCodeBulananRekapHutangCashback = "1203.09";
    internal const string ReportCodeBulananRincianHutangCashback = "1203.10";
  }
}
