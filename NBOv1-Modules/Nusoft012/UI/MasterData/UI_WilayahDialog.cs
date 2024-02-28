using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_WilayahDialog : InputDialog {
		public UI_WilayahDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		Wilayah originalEdit;

		public override void LoadBeforeInitialize() {
			txtRegional.Properties.DataSource = new XPCollection<Regional>(session);
			txtKelompokOmzet.Properties.DataSource = new XPCollection<KelompokOmzet>(session);
			txtKodeInvoice.Properties.MaxLength = 3;
			txtNama.Properties.MaxLength = 30;
			txtJatuhTempo.Properties.MaxValue = 360;
			txtKeterangan.Properties.MaxLength = 255;

			txtRegional.EditValue = ((XPCollection<Regional>)txtRegional.Properties.DataSource)[0];
			txtKelompokOmzet.EditValue = ((XPCollection<KelompokOmzet>)txtKelompokOmzet.Properties.DataSource)[0];
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Wilayah : Tambah";
				txtKodeInvoice.Text = "";
				txtNama.Text = "";
				txtJatuhTempo.EditValue = 0;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Wilayah>(Convert.ToInt32(IdToEdit));
				Text = "Wilayah : Edit - " + originalEdit.Nama;
				txtRegional.EditValue = originalEdit.Regional;
				txtKelompokOmzet.EditValue = originalEdit.KelompokOmzet;
				txtNama.Text = originalEdit.Nama;
				txtJatuhTempo.EditValue = originalEdit.JatuhTempo;
				txtKodeInvoice.Text = originalEdit.Kode;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtRegional.Focus();
		}
		public override void SimpanData() {
			Wilayah instance;
			if (Tipe == InputType.Tambah) instance = new Wilayah(session);
			else instance = session.GetObjectByKey<Wilayah>(Convert.ToInt32(IdToEdit));
			var service = new WilayahService(session, originalEdit);

			instance.Regional = txtRegional.EditValue == null ? null : (Regional)txtRegional.EditValue;
			instance.KelompokOmzet = txtKelompokOmzet.EditValue == null ? null : (KelompokOmzet)txtKelompokOmzet.EditValue;
			instance.Kode = txtKodeInvoice.Text;
			instance.Nama = txtNama.Text;
			instance.JatuhTempo = (int)txtJatuhTempo.Value;
			instance.Keterangan = txtKeterangan.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtRegional.Focus(); break;
				case -2: txtKelompokOmzet.Focus(); break;
				case -3: txtKodeInvoice.Focus(); break;
				case -4: txtNama.Focus(); break;
			}
		}
	}
}
