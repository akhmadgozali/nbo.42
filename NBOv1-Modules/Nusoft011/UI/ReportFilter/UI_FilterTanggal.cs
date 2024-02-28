using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Linq;
using static NuSoft.NUI.Win.Forms.Modules.NuSoft011.MainClass;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter {
	internal partial class UI_FilterTanggal : FilterForm {
		private readonly ReportName _kodeLaporan;
		public UI_FilterTanggal(ReportName KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case ReportName.OrderSampul: Text = "Filter Laporan - Sampul Order"; break;
				case ReportName.OrderRekap: Text = "Filter Laporan - Rekap Order"; break;
				case ReportName.OrderRincian: Text = "Filter Laporan - Rincian Order"; break;
				case ReportName.SirkulasiHarianRekap: Text = "Filter Laporan - Rekap Sirkulasi Harian"; break;
				case ReportName.SirkulasiHarianRincian: Text = "Filter Laporan - Rincian Sirkulasi Harian"; break;
			}
		}

		public override void InitializeData() {
			switch (_kodeLaporan) {
				case ReportName.OrderSampul:
				case ReportName.OrderRekap:
				case ReportName.OrderRincian: SetDefaultOrder(); break;
				case ReportName.SirkulasiHarianRekap:
				case ReportName.SirkulasiHarianRincian: SetDefaultMutasi(); break;
			}
		}
		private void SetDefaultOrder() { txtTanggal.DateTime = DateTime.Now.AddDays(1); }
		private void SetDefaultMutasi() { txtTanggal.DateTime = DateTime.Now; }
		public override void Filter() {
				if (txtTanggal.DateTime == null || txtTanggal.DateTime == default(DateTime)) throw new Utils.Exception("Masukkan tanggal", -1);

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
				var settingSirkulasi = new SirkulasiSetting(_sesi);
				if (settingSirkulasi != null) {
					AddParameter("TTdNama", settingSirkulasi.OrderCetakTtdNama, typeof(string));
					AddParameter("TTdJabatan", settingSirkulasi.OrderCetakTtdJabatan, typeof(string));
				}
				AddParameter("Tanggal", txtTanggal.DateTime, typeof(DateTime));
				AddParameter("TglKemarin", txtTanggal.DateTime.AddDays(-1), typeof(DateTime));

				switch (_kodeLaporan) {
					case ReportName.OrderSampul:
						var jmlCetak = new XPQuery<OrderKoran>(_sesi).Where(w => w.Tanggal == txtTanggal.DateTime.Date).Sum(s => s.TotalOplah);
						AddParameter("JumlahCetak", jmlCetak, typeof(int));
						_dataSource = new XPCollection<Rute>(_sesi);
						break;
					case ReportName.OrderRekap:
					case ReportName.OrderRincian:
						_dataSource = SirkulasiHarianService.GetMutasiDetail(_sesi, txtTanggal.DateTime, false);
						break;
					case ReportName.SirkulasiHarianRekap:
					case ReportName.SirkulasiHarianRincian:
						_dataSource = new XPQuery<SirkulasiHarianDetail>(_sesi).Where(w => w.Main.Tanggal.Date == txtTanggal.DateTime.Date).ToList();
						break;
				}
		}
	}
}