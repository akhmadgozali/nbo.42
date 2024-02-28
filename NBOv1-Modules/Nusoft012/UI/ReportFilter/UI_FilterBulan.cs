using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter {
	public partial class UI_FilterBulan : FilterForm {
		public UI_FilterBulan(string KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case MainClass.ReportCodeBulananRekapOmzet: Text = "Filter Laporan - Rekap Omzet"; break;
				case MainClass.ReportCodeBulananRincianOmzet: Text = "Filter Laporan - Rincian Omzet"; break;
				case MainClass.ReportCodeBulananRekapPembayaran: Text = "Filter Laporan - Rekap Pembayaran"; break;
				case MainClass.ReportCodeBulananRincianPembayaran: Text = "Filter Laporan - Rincian Pembayaran"; break;
				case MainClass.ReportCodeBulananRekapPiutang: Text = "Filter Laporan - Rekap Piutang"; break;
				case MainClass.ReportCodeBulananRincianPiutang: Text = "Filter Laporan - Rincian Piutang"; break;
				case MainClass.ReportCodeBulananRekapHutangKomisi: Text = "Filter Laporan - Rekap Hutang Komisi"; break;
				case MainClass.ReportCodeBulananRincianHutangKomisi: Text = "Filter Laporan - Rincian Hutang Komisi"; break;
				case MainClass.ReportCodeBulananRekapHutangCashback: Text = "Filter Laporan - Rekap Hutang Cashback"; break;
				case MainClass.ReportCodeBulananRincianHutangCashback: Text = "Filter Laporan - Rincian Hutang Cashback"; break;
			}
		}
		private readonly string _kodeLaporan;

		public override void InitializeData() {
			txtBulan.Properties.Items.Clear();
			for (int i = 1; i <= 12; i++)
			{
				txtBulan.Properties.Items.Add(new DateTime(DateTime.Now.Year, i, 1).ToString("MMMM"));
			}
			txtTahun.Properties.MaxValue = DateTime.Now.Year + 10;
			txtBulan.SelectedIndex = DateTime.Now.Month - 1; txtTahun.Value = DateTime.Now.Year;
		}

		public override void Filter() {
			try {
				if (txtTahun.Value == default(decimal)) throw new Utils.Exception("Masukkan tahun", -1);

				var _setting = new NuSoftModSys.LogicLayer.Config(_sesi);
				if (_setting != null) {
					AddParameter("CompanyName", _setting.NamaPerusahaan, typeof(string));
					AddParameter("CompanyAlias", _setting.NamaAlias, typeof(string));
					AddParameter("CompanyAlamat", string.Format("{0} {1}", _setting.Alamat1, _setting.Alamat2), typeof(string));
					AddParameter("CompanyTelp", _setting.NoTelp, typeof(string));
					AddParameter("CompanyFax", _setting.NoFax, typeof(string));
				}
				AddParameter("Bulan", txtBulan.Text, typeof(string));
				AddParameter("Tahun", txtTahun.Value.ToString(), typeof(string));

				var periodeawal = txtAkumulasi.Checked ? new DateTime((int)txtTahun.Value, 1, 1) : new DateTime((int)txtTahun.Value, txtBulan.SelectedIndex + 1, 1);
				var periodeakhir = new DateTime((int)txtTahun.Value, txtBulan.SelectedIndex + 1, DateTime.DaysInMonth((int)txtTahun.Value, txtBulan.SelectedIndex + 1));
				AddParameter("Judul", txtAkumulasi.Checked ? periodeawal.ToString("MMMM yyyy") + " s/d " + periodeakhir.ToString("MMMM yyyy") : periodeakhir.ToString("MMMM yyyy"), typeof(string));

				switch (_kodeLaporan) {
					case MainClass.ReportCodeBulananRekapOmzet:
					case MainClass.ReportCodeBulananRincianOmzet:
						_dataSource = new XPQuery<Invoice>(_sesi).Where(w => w.TanggalOmzet.Date >= periodeawal.Date && w.TanggalOmzet.Date <= periodeakhir.Date).ToList();
						break;
					case MainClass.ReportCodeBulananRekapPembayaran:
					case MainClass.ReportCodeBulananRincianPembayaran:
						_dataSource = new XPQuery<PembayaranIklanDetail>(_sesi).Where(w => w.Pembayaran.Tanggal.Date >= periodeawal.Date && w.Pembayaran.Tanggal.Date <= periodeakhir.Date).ToList();
						break;
					case MainClass.ReportCodeBulananRekapPiutang:
					case MainClass.ReportCodeBulananRincianPiutang:
						_dataSource = PiutangServices.GetRekapPiutang(_sesi, periodeawal, periodeakhir);
						break;
					case MainClass.ReportCodeBulananRekapHutangKomisi:
					case MainClass.ReportCodeBulananRincianHutangKomisi:
						_dataSource = HutangServices.GetRekapHutangKomisi(_sesi, periodeawal, periodeakhir);
						break;
					case MainClass.ReportCodeBulananRekapHutangCashback:
					case MainClass.ReportCodeBulananRincianHutangCashback:
						_dataSource = HutangServices.GetRekapHutangCashback(_sesi, periodeawal, periodeakhir);
						break;
				}
			}
			catch (Utils.Exception ex) { ex.ShowWinMessageBox(); }
		}
	}
}