using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_KurirDialog : InputDialog {
		public UI_KurirDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		Kurir originalEdit;

		public override void LoadBeforeInitialize() {
			txtNama.Properties.MaxLength = 50;
			txtKeterangan.Properties.MaxLength = 255;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Kurir : Tambah";
				txtNama.Text = "";
				txtAktif.Checked = true;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Kurir>(Convert.ToInt32(IdToEdit));
				Text = "Kurir : Edit - " + originalEdit.Nama;
				txtNama.Text = originalEdit.Nama;
				txtAktif.Checked = originalEdit.Aktif;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtNama.Focus();
		}
		public override void SimpanData() {
			Kurir instance;
			if (Tipe == InputType.Tambah) instance = new Kurir(session);
			else instance = session.GetObjectByKey<Kurir>(Convert.ToInt32(IdToEdit));
			var service = new KurirService(session, originalEdit);

			instance.Nama = txtNama.Text;
			instance.Aktif = txtAktif.Checked;
			instance.Keterangan = txtKeterangan.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtNama.Focus(); break;
			}
		}
	}
}
