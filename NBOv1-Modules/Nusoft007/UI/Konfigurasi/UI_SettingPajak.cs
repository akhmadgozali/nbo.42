using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.Konfigurasi {
	public partial class UI_SettingPajak : DialogForm {
		public UI_SettingPajak() { InitializeComponent(); AutoCloseOnSave = true; }

		TaxSetting item;
		public override void InitializeData() {
			GetSession();
			item = new TaxSetting(session);

			txtPKPNama.Text = item.PerusahaanNama;
			txtPKPAlamat.Text = item.PerusahaanAlamat;
			txtPKPNPWP.Text = item.PerusahaanNPWP;
			txtPKPTanggal.DateTime = item.PerusahaanTglPKP;
			txtPPnAktif.Checked = item.PPnAktif;
			txtPPnProsentase.Value = item.PPnProsentase;
			txtPPh23Prosentase.Value = item.PPh23Prosentase;
			txtPPh21NonNPWPProsentase.Value = item.PPh21PengaliNonNpwpPersen;
			txtPPh21DppProsentase.Value = item.PPh21DppProsentase;
			txtTampilkanNoInvoiceDiFaktur.Checked = item.TampilkanNoInvoice;

			var reg = new XPCollection<Regional>(session);
			var regCol = new XPCollection<RegionalPajak>(session);

			foreach (var item in reg) {
				var find = regCol.ToList().Find(f => f.Id == item);
				if (find == null) {
					find = new RegionalPajak(session) { Id = item };
					regCol.Add(find);
				}
			}

			xGrid.DataSource = regCol;
		}
		public override void Btn1Click() {
			item.PerusahaanNama = txtPKPNama.Text;
			item.PerusahaanAlamat = txtPKPAlamat.Text;
			item.PerusahaanNPWP = txtPKPNPWP.Text;
			item.PerusahaanTglPKP = txtPKPTanggal.DateTime;

			item.PPnAktif = txtPPnAktif.Checked;
			item.PPnProsentase = (int)txtPPnProsentase.Value;
			item.PPh23Prosentase = (int)txtPPh23Prosentase.Value;
			item.PPh21PengaliNonNpwpPersen = txtPPh21NonNPWPProsentase.Value;
			item.PPh21DppProsentase = txtPPh21DppProsentase.Value;

			item.TampilkanNoInvoice = txtTampilkanNoInvoiceDiFaktur.Checked;
			item.Save();
			session.CommitChanges();
		}
		public override void Btn2Click() {
			session.RollbackTransaction();
		}
	}
}
