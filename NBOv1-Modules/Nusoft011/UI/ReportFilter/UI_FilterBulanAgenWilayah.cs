using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Linq;
using static NuSoft.NUI.Win.Forms.Modules.NuSoft011.MainClass;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter {
	internal partial class UI_FilterBulanAgenWilayah : FilterForm {
		private readonly ReportName _kodeLaporan;
		public UI_FilterBulanAgenWilayah(ReportName KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case ReportName.AgenTagihanBulanan: Text = "Filter Laporan - Tagihan Bulanan Agen"; break;
			}
		}

		public override void InitializeData() {
			txtBulan.Properties.Items.Clear();
			for (int i = 1; i <= 12; i++) {
				txtBulan.Properties.Items.Add(new DateTime(DateTime.Now.Year, i, 1).ToString("MMMM"));
			}
			txtTahun.Properties.MaxValue = DateTime.Now.Year + 10;

			txtRute.Properties.DataSource = new XPQuery<Rute>(_sesi).ToList();
			switch (_kodeLaporan) {
				case ReportName.AgenTagihanBulanan:
					SetDefaultInvoice();
					break;
			}
		}
		private void SetDefaultInvoice() {
			txtBulan.SelectedIndex = DateTime.Now.Month - 1;
			txtTahun.Value = DateTime.Now.Year;
			txtRute.CheckAll();
		}

		public override void Filter() {
			var setting = new NuSoftModSys.LogicLayer.Config(_sesi);
			if (setting != null) {
				AddParameter("NamaPerusahaan", setting.NamaPerusahaan, typeof(string));
				AddParameter("NamaAlias", setting.NamaAlias, typeof(string));
				AddParameter("Slogan", setting.Slogan, typeof(string));
				AddParameter("Alamat1", setting.Alamat1, typeof(string));
				AddParameter("Alamat2", setting.Alamat2, typeof(string));
				AddParameter("AlamatPerusahaan", setting.Alamat1 + " " + setting.Alamat2, typeof(string));
				AddParameter("NoTelp", setting.NoTelp, typeof(string));
				AddParameter("NoFax", setting.NoFax, typeof(string));
			}
			AddParameter("Bulan", txtBulan.Text, typeof(string));
			AddParameter("Tahun", txtTahun.Value.ToString(), typeof(string));
			var settingSirkulasi = new SirkulasiSetting(_sesi);
			var tahun = (int)txtTahun.Value; var bulan = txtBulan.SelectedIndex + 1;

			switch (_kodeLaporan) {
				case ReportName.AgenTagihanBulanan:
					if (txtTahun.Value == default(decimal)) throw new Utils.Exception("Masukkan tahun", -1);
					if (txtRute.Properties.GetItems().GetCheckedValues().Count() < 0) throw new Utils.Exception("Masukkan rute", -1);

					AddParameter("AkhirBulan", new DateTime(tahun, bulan, DateTime.DaysInMonth(tahun, bulan)), typeof(DateTime));
					AddParameter("TglTempo", new DateTime(tahun, bulan, settingSirkulasi.TagihanJatuhTempo).AddMonths(1), typeof(DateTime));
					AddParameter("NamaTTd", settingSirkulasi.TagihanTTdNama, typeof(string));
					AddParameter("JabatanTTd", settingSirkulasi.TagihanTTdJabatan, typeof(string));
					AddParameter("Rekening", settingSirkulasi.TagihanRekeningBank, typeof(string));
					_dataSource = PiutangService.GetPiutangBerjalanKoran(_sesi, tahun, bulan, false, true, false, txtKodeAgen1.Text, txtKodeAgen2.Text, txtNamaAgen.Text, txtRute.Properties.GetItems().GetCheckedValues());
					break;
			}
		}
	}
}
