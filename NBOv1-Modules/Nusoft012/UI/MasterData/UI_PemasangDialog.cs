using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_PemasangDialog : InputDialog {
		public UI_PemasangDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		Pemasang originalEdit;

		public override void LoadBeforeInitialize() {
			txtKode.Properties.MaxLength = 30;
			txtNama.Properties.MaxLength = 100;
			txtAlamat.Properties.MaxLength = 250;
			txtNoTelp.Properties.MaxLength = 40;
			txtNoFax.Properties.MaxLength = 20;
			txtNoHP1.Properties.MaxLength = 20;
			txtNoHP2.Properties.MaxLength = 20;
			txtEmail.Properties.MaxLength = 30;
			txtNPWP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
			txtNPWP.Properties.Mask.EditMask = PPnKeluaranService.GetNPWPMask();
			txtNIK.Properties.MaxLength = 30;
			txtJatuhTempo.Properties.MaxValue = 360;
			txtDiskon.Properties.MaxValue = 100;
			txtKontakPerson.Properties.MaxLength = 100;
			txtKeterangan.Properties.MaxLength = 255;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Pemasang : Tambah";
				txtKode.Text = "";
				txtAktif.Checked = true;
				txtNama.Text = "";
				txtAlamat.Text = "";
				txtNoTelp.Text = "";
				txtNoFax.Text = "";
				txtNoHP1.Text = "";
				txtNoHP2.Text = "";
				txtEmail.Text = "";
				txtNPWP.EditValue = PPnKeluaranService.GetDefaultNPWP();
				txtKodeFaktur.SelectedIndex = 0;
				txtNIK.Text = "";
				txtJatuhTempo.EditValue = 0;
				txtDiskon.EditValue = 0;
				txtKontakPerson.Text = "";
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Pemasang>(Convert.ToInt32(IdToEdit));
				Text = "Pemasang : Edit - " + originalEdit.Kode;
				txtKode.Text = originalEdit.Kode;
				txtAktif.Checked = originalEdit.Aktif;
				txtNama.Text = originalEdit.Nama;
				txtAlamat.Text = originalEdit.Alamat;
				txtNoTelp.Text = originalEdit.NoTelpon;
				txtNoFax.Text = originalEdit.NoFax;
				txtNoHP1.Text = originalEdit.NoHP1;
				txtNoHP2.Text = originalEdit.NoHP2;
				txtEmail.Text = originalEdit.Email;
				txtNPWP.EditValue = originalEdit.NPWP;
				txtKodeFaktur.Text = originalEdit.KodeFaktur;
				txtNIK.Text = originalEdit.NIK;
				txtJatuhTempo.Value = originalEdit.JatuhTempoDefault;
				txtDiskon.Value = originalEdit.DiskonDefault;
				txtKontakPerson.Text = originalEdit.KontakPerson;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtKode.Focus();
		}
		public override void SimpanData() {
			Pemasang instance;
			if (Tipe == InputType.Tambah) instance = new Pemasang(session);
			else instance = session.GetObjectByKey<Pemasang>(Convert.ToInt32(IdToEdit));
			var service = new PemasangService(session, originalEdit);

			instance.Kode = txtKode.Text;
			instance.Aktif = txtAktif.Checked;
			instance.Nama = txtNama.Text;
			instance.Alamat = txtAlamat.Text;
			instance.NoTelpon = txtNoTelp.Text;
			instance.NoFax = txtNoFax.Text;
			instance.NoHP1 = txtNoHP1.Text;
			instance.NoHP2 = txtNoHP2.Text;
			instance.Email = txtEmail.Text;
			instance.NPWP = txtNPWP.Text;
			instance.KodeFaktur = txtKodeFaktur.Text;
			instance.NIK = txtNIK.Text;
			instance.JatuhTempoDefault = (int)txtJatuhTempo.Value;
			instance.DiskonDefault = txtDiskon.Value;
			instance.KontakPerson = txtKontakPerson.Text;
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
