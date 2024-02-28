using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System.Linq;
using static NuSoft.NUI.Win.Forms.Modules.NuSoft011.MainClass;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter {
	internal partial class UI_FilterAgenWilayah : FilterForm {
		private readonly ReportName _kodeLaporan;
		public UI_FilterAgenWilayah(ReportName KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case ReportName.AgenTagihanLabel: Text = "Filter Laporan - Label Tagihan"; break;
			}
		}

		public override void InitializeData() {
			txtRute.Properties.DataSource = new XPQuery<Rute>(_sesi).ToList(); ;
			switch (_kodeLaporan) {
				case ReportName.AgenTagihanLabel: SetDefaultLabel(); break;
			}
		}
		private void SetDefaultLabel() {
			txtRute.CheckAll();
		}

		public override void Filter() {
			switch (_kodeLaporan) {
				case ReportName.AgenTagihanLabel:
					if (txtRute.Properties.GetItems().GetCheckedValues().Count() < 0) throw new Utils.Exception("Masukkan rute", -1);

					var ds = new XPQuery<Agen>(_sesi).Where(w => txtRute.Properties.GetItems().GetCheckedValues().Contains(w.Rute)).ToList();
					if (!string.IsNullOrEmpty(txtKodeAgen1.Text)) {
						if (string.IsNullOrEmpty(txtKodeAgen2.Text)) ds = ds.Where(w => w.Kode.ToLower().Contains(txtKodeAgen1.Text.ToLower())).ToList();
						else ds = ds.Where(w => w.Kode.ToLower().CompareTo(txtKodeAgen1.Text.ToLower()) >= 0 && w.Kode.ToLower().CompareTo(txtKodeAgen2.Text.ToLower()) <= 0).ToList();
					}
					if (!string.IsNullOrEmpty(txtNamaAgen.Text)) ds = ds.Where(w => w.Nama.ToLower().Contains(txtNamaAgen.Text.ToLower())).ToList();

					_dataSource = ds;
					break;
			}
		}
	}
}
