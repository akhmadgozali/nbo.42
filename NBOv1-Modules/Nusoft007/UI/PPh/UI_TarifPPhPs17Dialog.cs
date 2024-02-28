using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPh {
	public partial class UI_TarifPPhPs17Dialog : InputDialog {
		public UI_TarifPPhPs17Dialog() { 
			InitializeComponent();
			AutoCloseOnSave = true;
		}
		private TarifPPh17 originalEdit;

		public override void LoadBeforeInitialize() {
			txtBatasBawah.Properties.MaxValue = decimal.MaxValue;
			txtBatasAtas.Properties.MaxValue = decimal.MaxValue;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Tarif PPh Pasal 17 : Tambah";
				txtTarif.Value = 0;
				txtBatasBawah.Value = 0;
				txtBatasAtas.Value = 0;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<TarifPPh17>(Convert.ToInt32(IdToEdit));
				Text = "Tarif PPh Pasal 17 : Edit";
				txtTarif.Value = originalEdit.Tarif;
				txtBatasBawah.Value = originalEdit.BatasBawah;
				txtBatasAtas.Value = originalEdit.BatasAtas;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtTarif.Focus();
		}
		public override void SimpanData() {
			TarifPPh17 instance;
			if (Tipe == InputType.Tambah) instance = new TarifPPh17(session);
			else instance = session.GetObjectByKey<TarifPPh17>(Convert.ToInt32(IdToEdit));
			var service = new TarihPPh17Service(session, originalEdit);
			instance.Tarif = txtTarif.Value;
			instance.BatasBawah = txtBatasBawah.Value;
			instance.BatasAtas = txtBatasAtas.Value;
			instance.Keterangan = txtKeterangan.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTarif.Focus(); break;
			}
		}
	}
}
