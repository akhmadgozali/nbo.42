using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Linq;
using static NuSoft.NUI.Win.Forms.Modules.NuSoft011.MainClass;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter {
	internal partial class UI_FilterBulan : FilterForm {
		private readonly ReportName _kodeLaporan;
		public UI_FilterBulan(ReportName KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case ReportName.SirkulasiBulananRekap: Text = "Filter Laporan - Rekap Sirkulasi Bulanan"; break;
				case ReportName.SirkulasiBulananRincian : Text = "Filter Laporan - Rincian Sirkulasi Bulanan"; break;
				case ReportName.BulananOmzetPerTanggalRekap: Text = "Filter Laporan - Rekap Omzet Per Tanggal"; break;
				case ReportName.BulananOmzetPerRuteRekap: Text = "Filter Laporan - Rekap Omzet Per Rute"; break;
				case ReportName.BulananOmzetPerRuteRincian: Text = "Filter Laporan - Rincian Omzet Per Rute"; break;
				case ReportName.BulananPembayaranRekap: Text = "Filter Laporan - Rekap Pembayaran Per Rute"; break;
				case ReportName.BulananPembayaranRincian: Text = "Filter Laporan - Rincian Pembayaran Per Rute"; break;
				case ReportName.BulananPiutangRekap: Text = "Filter Laporan - Rekap Piutang Per Rute"; break;
				case ReportName.BulananPiutangRincian: Text = "Filter Laporan - Rincian Piutang Per Rute"; break;
			}
		}

		public override void InitializeData() {
			txtBulan.Properties.Items.Clear();
			for (int i = 1; i <= 12; i++) {
				txtBulan.Properties.Items.Add(new DateTime(DateTime.Now.Year, i,1).ToString("MMMM"));
			}
			txtTahun.Properties.MaxValue = DateTime.Now.Year + 10;
			txtBulan.SelectedIndex = DateTime.Now.Month - 1; txtTahun.Value = DateTime.Now.Year;
			layCek.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

			switch (_kodeLaporan) {
				case ReportName.BulananPiutangRekap:
				case ReportName.BulananPiutangRincian: 
					txtCek.Checked = false; 
					layCek.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
					break;
			}
		}
		public override void Filter() {
			if (txtTahun.Value == default(decimal)) throw new Utils.Exception("Masukkan tahun", -1);

			var setting = new NuSoftModSys.LogicLayer.Config(_sesi);
			if (setting != null) {
				AddParameter("NamaPerusahaan", setting.NamaPerusahaan, typeof(string));
				AddParameter("NamaAlias", setting.NamaAlias, typeof(string));
				AddParameter("Slogan", setting.Slogan, typeof(string));
				AddParameter("Alamat1", setting.Alamat1, typeof(string));
				AddParameter("Alamat2", setting.Alamat2, typeof(string));
				AddParameter("NoTelp", setting.NoTelp, typeof(string));
				AddParameter("NoFax", setting.NoFax, typeof(string));
			}
			AddParameter("Bulan", txtBulan.Text, typeof(string));
			AddParameter("Tahun", txtTahun.Value.ToString(), typeof(string));

			switch (_kodeLaporan) {
				case ReportName.SirkulasiBulananRekap:
				case ReportName.SirkulasiBulananRincian:
					_dataSource = new XPQuery<SirkulasiHarianDetail>(_sesi).Where(w => w.Main.Tanggal.Year == txtTahun.Value && w.Main.Tanggal.Month == txtBulan.SelectedIndex + 1).ToList();
					break;
				case ReportName.BulananOmzetPerTanggalRekap:
				case ReportName.BulananOmzetPerRuteRekap:
				case ReportName.BulananOmzetPerRuteRincian:
					var jmlHari = new XPQuery<SirkulasiHarian>(_sesi).Where(w => w.Tanggal.Year == txtTahun.Value && w.Tanggal.Month == txtBulan.SelectedIndex + 1).Count();
					AddParameter("JumlahHari", jmlHari, typeof(int));
					_dataSource = new XPQuery<SirkulasiHarianDetail>(_sesi).Where(w => w.Main.Tanggal.Year == txtTahun.Value && w.Main.Tanggal.Month == txtBulan.SelectedIndex + 1).ToList();
					break;
				case ReportName.BulananPembayaranRekap:
				case ReportName.BulananPembayaranRincian:
					_dataSource = new XPQuery<BayarKoran>(_sesi).Where(w => w.Tanggal.Year == txtTahun.Value && w.Tanggal.Month == txtBulan.SelectedIndex + 1).ToList();
					break;
				case ReportName.BulananPiutangRekap:
				case ReportName.BulananPiutangRincian:
					if (txtCek.Checked) {
						var jmlHariAkumulasi = new XPQuery<SirkulasiHarian>(_sesi).Where(w => w.Tanggal.Year == txtTahun.Value && w.Tanggal.Month <= txtBulan.SelectedIndex + 1).Count();
						AddParameter("JumlahHari", jmlHariAkumulasi, typeof(int));
						AddParameter("BulanX", "Januari - " + txtBulan.Text, typeof(string));
					}
					else {
						var jmlHari1 = new XPQuery<SirkulasiHarian>(_sesi).Where(w => w.Tanggal.Year == txtTahun.Value && w.Tanggal.Month == txtBulan.SelectedIndex + 1).Count();
						AddParameter("JumlahHari", jmlHari1, typeof(int));
						AddParameter("BulanX", txtBulan.Text, typeof(string));
					}
					_dataSource = PiutangService.GetPiutangBerjalanKoran(_sesi, (int)txtTahun.Value, txtBulan.SelectedIndex + 1, false, false, txtCek.Checked, string.Empty, string.Empty, string.Empty, null); ; ;
					break;
			}
		}
	}
}