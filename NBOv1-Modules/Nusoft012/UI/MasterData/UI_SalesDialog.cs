using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_SalesDialog : InputDialog {
		public UI_SalesDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		Sales originalEdit;

		public override void LoadBeforeInitialize() {
			txtKode.Properties.MaxLength = 30;
			txtNama.Properties.MaxLength = 100;
			txtAlamat.Properties.MaxLength = 250;
			txtNoTelp.Properties.MaxLength = 40;
			txtNoHP1.Properties.MaxLength = 20;
			txtNoHP2.Properties.MaxLength = 20;
			txtNIK.Properties.MaxLength = 30;
			txtEmail.Properties.MaxLength = 30;
			txtNPWP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
			txtNPWP.Properties.Mask.EditMask = PPnKeluaranService.GetNPWPMask();
			txtKeterangan.Properties.MaxLength = 255;
			txtKomisi.Properties.MinValue = 0;
			txtKomisi.Properties.MaxValue = 50;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Sales : Tambah";
				txtKode.Text = "";
				txtAktif.Checked = true;
				txtNama.Text = "";
				txtNPWP.EditValue = PPnKeluaranService.GetDefaultNPWP();
				txtAlamat.Text = "";
				txtNIK.Text = "";
				txtNoTelp.Text = "";
				txtNoHP1.Text = "";
				txtNoHP2.Text = "";
				txtEmail.Text = "";
				txtKomisi.Value = 0;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Sales>(Convert.ToInt32(IdToEdit));
				Text = "Sales : Edit - " + originalEdit.Kode;
				txtKode.Text = originalEdit.Kode;
				txtAktif.Checked = originalEdit.Aktif;
				txtNama.Text = originalEdit.Nama;
				txtNPWP.EditValue = originalEdit.NPWP;
				txtAlamat.Text = originalEdit.Alamat;
				txtNIK.Text = originalEdit.NIK;
				txtNoTelp.Text = originalEdit.NoTelpon;
				txtNoHP1.Text = originalEdit.NoHP1;
				txtNoHP2.Text = originalEdit.NoHP2;
				txtEmail.Text = originalEdit.Email;
				txtKomisi.Value = originalEdit.KomisiDefault;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtKode.Focus();
		}
		public override void SimpanData() {
			Sales instance;
			if (Tipe == InputType.Tambah) instance = new Sales(session);
			else instance = session.GetObjectByKey<Sales>(Convert.ToInt32(IdToEdit));
			var service = new SalesService(session, originalEdit);

			instance.Kode = txtKode.Text;
			instance.Aktif = txtAktif.Checked;
			instance.Nama = txtNama.Text;
			instance.NPWP = txtNPWP.Text;
			instance.Alamat = txtAlamat.Text;
			instance.NIK = txtNIK.Text;
			instance.NoTelpon = txtNoTelp.Text;
			instance.NoHP1 = txtNoHP1.Text;
			instance.NoHP2 = txtNoHP2.Text;
			instance.Email = txtEmail.Text;
			instance.KomisiDefault = txtKomisi.Value;
			instance.Keterangan = txtKeterangan.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtKode.Focus(); break;
				case -2: txtNama.Focus(); break;
				case -3: txtNPWP.Focus(); break;
			}
		}
	}
}
