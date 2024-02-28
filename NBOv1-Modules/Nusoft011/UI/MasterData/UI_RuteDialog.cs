using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.MasterData {
	public partial class UI_RuteDialog : InputDialog {
		public UI_RuteDialog() { InitializeComponent(); }
		private Rute originalEdit;

		public override void LoadBeforeInitialize() {
			txtRegional.Properties.DataSource = new XPCollection<Regional>(session);
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Rute : Tambah";
				txtRegional.EditValue = ((XPCollection<Regional>)txtRegional.Properties.DataSource)[0];
				txtKode.Text = ""; 
				txtNama.Text = ""; 
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Rute>(Convert.ToInt32(IdToEdit));
				Text = "Rute : Edit - " + originalEdit.Kode;
				txtRegional.EditValue = originalEdit.Regional;
				txtKode.Text = originalEdit.Kode; 
				txtNama.Text = originalEdit.Nama;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtKode.Focus();
		}
		public override void SimpanData() {
			Rute instance;
			if (Tipe == InputType.Tambah) instance = new Rute(session);
			else instance = session.GetObjectByKey<Rute>(Convert.ToInt32(IdToEdit));
			var service = new RuteService(session, originalEdit);
			instance.Regional = txtRegional.EditValue == null ? null : (Regional)txtRegional.EditValue;
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
