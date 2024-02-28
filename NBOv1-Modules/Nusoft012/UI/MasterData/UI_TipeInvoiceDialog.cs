using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_TipeInvoiceDialog : InputDialog {
		public UI_TipeInvoiceDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		TipeInvoice originalEdit;

		public override void LoadBeforeInitialize() {
			var tipeIklan = TipeIklan.GetCollection();
			txtTipe.Properties.DataSource = tipeIklan;
			txtKode.Properties.MaxLength = 3;
			txtNama.Properties.MaxLength = 20;
			txtKeterangan.Properties.MaxLength = 255;

			if (tipeIklan.Count > 0) txtTipe.EditValue = tipeIklan[0].Id;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Tipe Invoice : Tambah";
				txtKode.Text = "";
				txtNama.Text = "";
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<TipeInvoice>(Convert.ToInt32(IdToEdit));
				Text = "Tipe Invoice : Edit - " + originalEdit.Nama;
				txtTipe.EditValue = originalEdit.TipeIklan;
				txtKode.Text = originalEdit.Kode;
				txtNama.Text = originalEdit.Nama;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtTipe.Focus();
		}
		public override void SimpanData() {
			TipeInvoice instance;
			if (Tipe == InputType.Tambah) instance = new TipeInvoice(session);
			else instance = session.GetObjectByKey<TipeInvoice>(Convert.ToInt32(IdToEdit));
			var service = new TipeInvoiceService(session, originalEdit);

			instance.TipeIklan = (ETipeIklan)txtTipe.EditValue;
			instance.Kode = txtKode.Text;
			instance.Nama = txtNama.Text;
			instance.Keterangan = txtKeterangan.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtKode.Focus(); break;
				case -2: txtNama.Focus(); break;
			}
		}
	}
}
