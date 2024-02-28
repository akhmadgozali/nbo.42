using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_TarifIklanDialog : InputDialog {
		public UI_TarifIklanDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		TarifIklan originalEdit;

		public override void LoadBeforeInitialize() {
			var tipeIklan = TipeIklan.GetCollection();
			txtTipe.Properties.DataSource = tipeIklan;
			txtKode.Properties.MaxLength = 10;
			txtNama.Properties.MaxLength = 50;
			txtKeterangan.Properties.MaxLength = 255;

			if (tipeIklan.Count > 0) txtTipe.EditValue = tipeIklan[0].Id;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Tarif Iklan : Tambah";
				txtKode.Text = "";
				txtNama.Text = "";
				txtAktif.Checked = true;
				txtHarga.Value = 0;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<TarifIklan>(Convert.ToInt32(IdToEdit));
				Text = "Tarif Iklan : Edit - " + originalEdit.Nama;
				txtTipe.EditValue = originalEdit.TipeIklan;
				txtKode.Text = originalEdit.Kode;
				txtNama.Text = originalEdit.Nama;
				txtAktif.Checked = originalEdit.Aktif;
				txtHarga.Value = originalEdit.Tarif;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtTipe.Focus();
		}
		public override void SimpanData() {
			TarifIklan instance;
			if (Tipe == InputType.Tambah) instance = new TarifIklan(session);
			else instance = session.GetObjectByKey<TarifIklan>(Convert.ToInt32(IdToEdit));
			var service = new TarifIklanService(session, originalEdit);

			instance.TipeIklan = (ETipeIklan)txtTipe.EditValue;
			instance.Kode = txtKode.Text;
			instance.Nama = txtNama.Text;
			instance.Aktif = txtAktif.Checked;
			instance.Tarif = txtHarga.Value;
			instance.Keterangan = txtKeterangan.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtKode.Focus(); break;
				case -2: txtNama.Focus(); break;
				case -3: txtTipe.Focus(); break;
				case -4: txtHarga.Focus(); break;
			}
		}
	}
}
