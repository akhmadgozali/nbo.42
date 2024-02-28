using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_MerkDialog : InputDialog {
		public UI_MerkDialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		Merk originalEdit;

		public override void LoadBeforeInitialize() {
			var produk = new XPCollection<Produk>(session);
			txtProduk.Properties.DataSource = produk;
			txtKode.Properties.MaxLength = 10;
			txtNama.Properties.MaxLength = 50;
			txtKeterangan.Properties.MaxLength = 255;

			if (produk.Count > 0) txtProduk.EditValue = produk[0];
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Merk : Tambah";
				txtKode.Text = "";
				txtNama.Text = "";
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Merk>(Convert.ToInt32(IdToEdit));
				Text = "Merk : Edit - " + originalEdit.Nama;
				txtProduk.EditValue = originalEdit.Produk;
				txtKode.Text = originalEdit.Kode;
				txtNama.Text = originalEdit.Nama;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtProduk.Focus();
		}
		public override void SimpanData() {
			Merk instance;
			if (Tipe == InputType.Tambah) instance = new Merk(session);
			else instance = session.GetObjectByKey<Merk>(Convert.ToInt32(IdToEdit));
			var service = new MerkService(session, originalEdit);

			instance.Produk = txtProduk.EditValue == null ? null : (Produk)txtProduk.EditValue;
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
				case -3: txtProduk.Focus(); break;
			}
		}
	}
}
