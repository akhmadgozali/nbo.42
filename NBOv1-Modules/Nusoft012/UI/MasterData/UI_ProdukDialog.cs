using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_ProdukDialog : InputDialog {
		public UI_ProdukDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		Produk originalEdit;

		public override void LoadBeforeInitialize() {
			txtKode.Properties.MaxLength = 10;
			txtNama.Properties.MaxLength = 50;
			txtKeterangan.Properties.MaxLength = 255;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Produk : Tambah";
				txtKode.Text = "";
				txtNama.Text = "";
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Produk>(Convert.ToInt32(IdToEdit));
				Text = "Produk : Edit - " + originalEdit.Kode;
				txtKode.Text = originalEdit.Kode;
				txtNama.Text = originalEdit.Nama;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtKode.Focus();
		}
		public override void SimpanData() {
			Produk instance;
			if (Tipe == InputType.Tambah) instance = new Produk(session);
			else instance = session.GetObjectByKey<Produk>(Convert.ToInt32(IdToEdit));
			var service = new ProdukService(session, originalEdit);

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
