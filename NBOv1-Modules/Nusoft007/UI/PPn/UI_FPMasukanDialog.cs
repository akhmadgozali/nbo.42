using DevExpress.XtraEditors.Mask;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn {
	public partial class UI_FPMasukanDialog : InputDialog {
		public UI_FPMasukanDialog(ModuleId moduleId) {
			InitializeComponent();
			_moduleId = moduleId;
			txtDpp.EditValueChanged += new EventHandler(DppChanged);
			txtPPn.EditValueChanged += (sender, e) => { editPPn = true; if (!editPPnBM) txtPPnBM.Value = 0; editPPn = false; };
			txtPPnBM.EditValueChanged += (sender, e) => { editPPnBM = true; if (!editPPn) txtPPn.Value = 0; editPPnBM = false; };
			AutoCloseOnSave = true;
		}
		private readonly ModuleId _moduleId;
		private bool editPPn = false;
		private bool editPPnBM = false;
		private PPnMasukan originalEdit;

		private void DppChanged(object sender, EventArgs e) { txtPPn.Value = txtDpp.Value * (10 / 100); }
		private void CheckDisableControl(PPnMasukan item) {
			var disable = false;
			//if (PeriodePajakServices.CekPeriodePPnTutup(session, item.Tanggal)) disable = true;
			if (_moduleId != ModuleId.TaxManagement) {
				disable = true;
				EnableVisibleSaveButton(false, true);
			}
			if (disable) {
				txtNomorFaktur.Enabled = false;
				txtSupplierNama.Enabled = false;
				txtSupplierNPWP.Enabled = false;
				txtTanggal.Enabled = false;
				txtMasaPajak.Enabled = false;
				txtTahunPajak.Enabled = false;
				txtDapatDikreditkan.Enabled = false;
				txtDpp.Enabled = false;
				txtPPn.Enabled = false;
				txtPPnBM.Enabled = false;
			}
			if (item.ModuleId != ModuleId.TaxManagement) {
				txtSupplierNama.Enabled = false;
				txtSupplierNPWP.Enabled = false;
				txtDpp.Enabled = false;
				txtPPn.Enabled = false;
				txtPPnBM.Enabled = false;
			}
		}

		public override void LoadBeforeInitialize() {
			txtNomorFaktur.Properties.Mask.MaskType = MaskType.Regular;
			txtNomorFaktur.Properties.Mask.EditMask = PPnKeluaranService.GetNomorFakturMask();
			txtSupplierNPWP.Properties.Mask.MaskType = MaskType.Regular;
			txtSupplierNPWP.Properties.Mask.EditMask = PPnKeluaranService.GetNPWPMask();

			txtMasaPajak.Properties.Items.Clear();
			for (int i = 1; i <= 12; i++) txtMasaPajak.Properties.Items.Add((new DateTime(DateTime.Now.Year, i, 1)).ToString("MMMM"));
			txtTahunPajak.Properties.MinValue = DateTime.Now.Year - 10;
			txtTahunPajak.Properties.MaxValue = DateTime.Now.Year + 10;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Ppn Masukan : Tambah";
				txtNomorFaktur.Text = "";
				txtSupplierNama.Text = "";
				txtSupplierNPWP.Text = "";
				txtTanggal.DateTime = DateTime.Now;
				txtMasaPajak.SelectedIndex = DateTime.Now.Month - 1;
				txtTahunPajak.Value = DateTime.Now.Year;
				txtDapatDikreditkan.Checked = true;
				txtDpp.Value = 0;
				txtPPn.Value = 0;
				txtPPnBM.Value = 0;
			}
			else {
				originalEdit = session.GetObjectByKey<PPnMasukan>(Convert.ToInt64(IdToEdit));
				Text = "Ppn Masukan : Edit - " + originalEdit.NomorFaktur;
				txtNomorFaktur.Text = originalEdit.NomorFaktur;
				txtSupplierNama.Text = originalEdit.SupplierNama;
				txtSupplierNPWP.Text = originalEdit.SupplierNPWP;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtMasaPajak.SelectedIndex = originalEdit.MasaPajak - 1;
				txtTahunPajak.Value = originalEdit.TahunPajak;
				txtDapatDikreditkan.Checked = originalEdit.IsKredit;
				txtDpp.Value = originalEdit.Dpp;
				txtPPn.Value = originalEdit.PPn;
				txtPPnBM.Value = originalEdit.PPnBM;

				CheckDisableControl(originalEdit);
			}
			txtNomorFaktur.Focus();
		}
		public override void SimpanData() {
			PPnMasukan instance;
			if (Tipe == InputType.Tambah) instance = new PPnMasukan(session);
			else instance = session.GetObjectByKey<PPnMasukan>(Convert.ToInt64(IdToEdit));
			var service = new PPnMasukanService(session, originalEdit);
			instance.NomorFaktur = txtNomorFaktur.Text;
			instance.SupplierNama = txtSupplierNama.Text;
			instance.SupplierNPWP = txtSupplierNPWP.Text;
			instance.Tanggal = txtTanggal.DateTime;
			instance.MasaPajak = txtMasaPajak.SelectedIndex + 1;
			instance.TahunPajak = (int)txtTahunPajak.Value;
			instance.IsKredit = txtDapatDikreditkan.Checked;
			instance.Dpp = txtDpp.Value;
			instance.PPn = txtPPn.Value;
			instance.PPnBM = txtPPnBM.Value;

			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtNomorFaktur.Focus(); break;
				case -2: txtTanggal.Focus(); break;
				case -3: txtSupplierNama.Focus(); break;
				case -4: txtSupplierNPWP.Focus(); break;
				case -5: txtMasaPajak.Focus(); break;
				case -6: txtTahunPajak.Focus(); break;
				case -7: txtDpp.Focus(); break;
				case -8: txtPPn.Focus(); break;
			}
		}
	}
}
