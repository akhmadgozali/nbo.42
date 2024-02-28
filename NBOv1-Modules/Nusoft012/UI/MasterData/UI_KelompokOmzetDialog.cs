using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_KelompokOmzetDialog : InputDialog {
		public UI_KelompokOmzetDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		KelompokOmzet originalEdit;

		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Kelompok Omzet : Tambah";
				txtNama.Text = "";
				txtTTdNama.Text = "";
				txtTTdJabatan.Text = "";
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<KelompokOmzet>(Convert.ToInt32(IdToEdit));
				Text = "Kelompok Omzet : Edit - " + originalEdit.Kode;
				txtNama.Text = originalEdit.Kode;
				txtTTdNama.Text = originalEdit.TtdNama;
				txtTTdJabatan.Text = originalEdit.TtdJabatan;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtNama.Focus();
		}
		public override void SimpanData() {
			KelompokOmzet instance;
			if (Tipe == InputType.Tambah) instance = new KelompokOmzet(session);
			else instance = session.GetObjectByKey<KelompokOmzet>(Convert.ToInt32(IdToEdit));
			var service = new KelompokOmzetService(session, originalEdit);

			instance.Kode = txtNama.Text;
			instance.TtdNama = txtTTdNama.Text;
			instance.TtdJabatan = txtTTdJabatan.Text;
			instance.Keterangan = txtKeterangan.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtNama.Focus(); break;
				case -2: txtTTdNama.Focus(); break;
				case -3: txtTTdJabatan.Focus(); break;
			}
		}
	}
}
