using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn {
	public partial class UI_FPKeluaranDialog : InputDialog {
		public UI_FPKeluaranDialog(ModuleId moduleId) {
			InitializeComponent();
			_moduleId = moduleId;
			txtTanggal.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(TanggalChanged);
			txtRegional.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(RegionalChanged);
			xGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(GridInitNewRow);
			xGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(GridChanged);
			txtPotonganHarga.EditValueChanged += new EventHandler(TotalChanged);
			txtUangMuka.EditValueChanged += new EventHandler(TotalChanged);
			txtPersenPPn.EditValueChanged += new EventHandler(TotalChanged);
			AutoCloseOnSave = true;
		}
		private TaxSetting settingPajak;
		private PPnKeluaran originalEdit;
		private BindingList<PPnKeluaranDetailForSave> Detail;
		private bool editAssign;
		private readonly ModuleId _moduleId;

		private void TanggalChanged(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
			if (!editAssign && e.NewValue != null && (e.OldValue == null || ((DateTime)e.OldValue).Year != ((DateTime)e.NewValue).Year)) {
				SetNomorFakturPajak(e.NewValue, txtRegional.EditValue);
			}
		}
		private void RegionalChanged(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
			if (!editAssign && e.NewValue != null) {
				var dd = (RegionalPajak)e.NewValue;
				txtNama.Text = dd.TtdNama;
				txtJabatan.Text = dd.TtdJabatan;
			}
		}
		private void GridChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
			if (e.Column == colHarga || e.Column == colQty) Summary();
		}
		private void GridInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) {
			PPnKeluaranDetailForSave row = (PPnKeluaranDetailForSave)xGridView.GetRow(e.RowHandle);
			row.Nama = "";
			row.Qty = 1;
			row.Harga = 0;
		}
		private void TotalChanged(object sender, EventArgs e) { Summary(); }
		private void Summary() {
			var subtotal = Detail.Sum(s => s.Harga * s.Qty);
			var diskon = txtPotonganHarga.Value;
			var um = txtUangMuka.Value;
			var dpp = subtotal - diskon - um;
			var persen = txtPersenPPn.Value;
			var ppn = (dpp * persen) / 100;

			txtHargaJual.Text = subtotal.ToString("n0");
			txtDPP.Text = dpp.ToString("n0");
			txtNilaiPPn.Value = ppn;
		}
		private void CheckDisableControl(PPnKeluaran item) {
			var disable = false;
			//if (PeriodePajakServices.CekPeriodePPnTutup(session, item.Tanggal)) disable = true;
			if (item.StatusFaktur != EFakturStatus.Edit) {
				disable = true;
				EnableVisibleSaveButton(false, true);
			}
			if (_moduleId != ModuleId.TaxManagement || item.ModuleId != ModuleId.TaxManagement) {
				disable = true;
			}
			if (disable) {
				txtKodeTransaksi.Enabled = false;
				txtNoSeri.Enabled = false;
				txtNoInvoice.Enabled = false;
				txtPelangganNama.Enabled = false;
				txtPelangganAlamat.Enabled = false;
				txtPelangganNPWP.Enabled = false;
				txtPelangganNIK.Enabled = false;
				//txtPotonganHarga.Enabled = false;
				txtUangMuka.Enabled = false;
				txtPersenPPn.Enabled = false;
				txtRegional.Enabled = false;
				txtTanggal.Enabled = false;
				txtNama.Enabled = false;
				txtJabatan.Enabled = false;
				xGrid.Enabled = false;

				if (item.ModuleId != ModuleId.TaxManagement && item.StatusFaktur == EFakturStatus.Edit) {
					txtKodeTransaksi.Enabled = true;
					txtNoSeri.Enabled = _moduleId == ModuleId.TaxManagement;
					txtTanggal.Enabled = true;
				}
			}
		}

		private void SetNomorFakturPajak(object Tanggal, object Regional) {
			if (Tanggal == null) return;
			var tgl = (DateTime)Tanggal;
			if (Tipe == InputType.Tambah) {
				txtNoSeri.Properties.DataSource = new XPQuery<NomorSeriPajakDetail>(session)
					.Where(w => w.Main.TanggalMulaiBerlaku.Year == tgl.Year &&
					w.Main.TanggalMulaiBerlaku.Date <= tgl.Date && !w.Terpakai).ToList(); 
			}
			else {
				txtNoSeri.Properties.DataSource = new XPQuery<NomorSeriPajakDetail>(session)
					.Where(w => w == originalEdit.NomorSeriValid || (w.Main.TanggalMulaiBerlaku.Year == tgl.Year &&
					w.Main.TanggalMulaiBerlaku.Date <= tgl.Date && !w.Terpakai)).ToList();
			}
		}

		public override void LoadBeforeInitialize() {
			settingPajak = new TaxSetting(session);
			txtRegional.Properties.DataSource = new XPQuery<RegionalPajak>(session).ToList();

			txtPelangganNPWP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
			txtPelangganNPWP.Properties.Mask.EditMask = PPnKeluaranService.GetNPWPMask();
		}
		public override void InitializeData() {
			Detail = new BindingList<PPnKeluaranDetailForSave>();

			if (Tipe == InputType.Tambah) {
				Text = "PPn Keluaran : Tambah";
				txtTanggal.DateTime = DateTime.Now;
				txtKodeTransaksi.SelectedIndex = 0;
				txtKodeStatus.Text = "0";
				txtNoInvoice.Text = "";
				txtPKPNama.Text = settingPajak.PerusahaanNama;
				txtPKPAlamat.Text = settingPajak.PerusahaanAlamat;
				txtPKPNPWP.Text = settingPajak.PerusahaanNPWP;
				txtPelangganNama.Text = "";
				txtPelangganAlamat.Text = "";
				txtPelangganNPWP.Text = PPnKeluaranService.GetDefaultNPWP();
				txtPelangganNIK.Text = "";
				txtPotonganHarga.EditValue = 0;
				txtUangMuka.EditValue = 0;
				txtPersenPPn.Value = 10;
				if (txtRegional.Properties.DataSource != null) txtRegional.EditValue = ((List<RegionalPajak>)txtRegional.Properties.DataSource)[0];
				if (((List<NomorSeriPajakDetail>)txtNoSeri.Properties.DataSource).Count > 0) txtNoSeri.EditValue = ((List<NomorSeriPajakDetail>)txtNoSeri.Properties.DataSource)[0];
			}
			else {
				editAssign = true;
				originalEdit = session.GetObjectByKey<PPnKeluaran>(Convert.ToInt64(IdToEdit));
				Text = "PPn Keluaran : Edit - " + originalEdit.NomorSeri;

				txtKodeTransaksi.Text = originalEdit.KodeTransaksi;
				txtKodeStatus.Text = originalEdit.KodeStatus;
				txtNoSeri.EditValue = originalEdit.NomorSeriValid;
				txtNoInvoice.Text = originalEdit.NomorInvoice;
				txtPKPNama.Text = originalEdit.NamaPerusahaan;
				txtPKPAlamat.Text = originalEdit.AlamatPerusahaan;
				txtPKPNPWP.Text = originalEdit.NPWPPerusahaan;
				txtPelangganNama.Text = originalEdit.NamaPelanggan;
				txtPelangganAlamat.Text = originalEdit.AlamatPelanggan;
				txtPelangganNPWP.Text = originalEdit.NPWPPelanggan;
				txtPelangganNIK.Text = originalEdit.NIKPelanggan;
				txtPotonganHarga.Value = originalEdit.Diskon;
				txtUangMuka.Value = originalEdit.UangMuka;
				txtPersenPPn.Value = originalEdit.PPnPersen;
				txtNilaiPPn.Value = originalEdit.PPnNominal;
				txtRegional.EditValue = originalEdit.Regional;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtNama.Text = originalEdit.TtdNama;
				txtJabatan.Text = originalEdit.TtdJabatan;

				var obj = PPnKeluaranService.GetItem(originalEdit);
				foreach (var item in obj.DetailForSave) Detail.Add(item);

				Summary();
				CheckDisableControl(originalEdit);
				editAssign = false;
				SetNomorFakturPajak(txtTanggal.DateTime, txtRegional.EditValue);
			}
			txtKodeTransaksi.Focus();

			xGrid.DataSource = Detail;
		}
		public override void SimpanData() {
			PPnKeluaran instance;
			if (Tipe == InputType.Tambah) instance = new PPnKeluaran(session);
			else instance = session.GetObjectByKey<PPnKeluaran>(Convert.ToInt64(IdToEdit));
			var service = new PPnKeluaranService(session, originalEdit);

			instance.KodeTransaksi = txtKodeTransaksi.Text;
			instance.KodeStatus = txtKodeStatus.Text;
			if (txtNoSeri.EditValue != null) {
				instance.NomorSeriValid = (NomorSeriPajakDetail)txtNoSeri.EditValue;
				instance.NomorSeri = instance.NomorSeriValid.NomorSeriFaktur;
			}
			instance.NomorInvoice = txtNoInvoice.Text;
			instance.NamaPerusahaan = txtPKPNama.Text;
			instance.AlamatPerusahaan = txtPKPAlamat.Text;
			instance.NPWPPerusahaan = txtPKPNPWP.Text;
			instance.NamaPelanggan = txtPelangganNama.Text;
			instance.AlamatPelanggan = txtPelangganAlamat.Text;
			instance.NPWPPelanggan = txtPelangganNPWP.Text;
			instance.NIKPelanggan = txtPelangganNIK.Text;
			instance.UangMuka = txtUangMuka.Value;
			instance.PPnPersen = (short)txtPersenPPn.Value;
			instance.PPnNominal = txtNilaiPPn.Value;
			instance.Regional = txtRegional.EditValue == null ? null : (RegionalPajak)txtRegional.EditValue;
			instance.Tanggal = txtTanggal.DateTime;
			instance.TtdNama = txtNama.Text;
			instance.TtdJabatan = txtJabatan.Text;
			instance.DetailForSave = Detail.ToList();

			// set referensiId
			var maxId = instance.DetailForSave.Where(w => !string.IsNullOrEmpty(w.ReferensiId)).Max(m => m.ReferensiId);
			int refId = 0;
			if (!string.IsNullOrEmpty(maxId)) refId = int.Parse(maxId);
			foreach (var fd in instance.DetailForSave.Where(w => string.IsNullOrEmpty(w.ReferensiId))) {
				fd.ReferensiId = (++refId).ToString();
			}

			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggal.Focus(); break;
				case -2: txtPelangganNama.Focus(); break;
				case -3: txtPelangganAlamat.Focus(); break;
				case -4: txtPelangganNPWP.Focus(); break;
				case -5: txtNoInvoice.Focus(); break;
				case -6: txtRegional.Focus(); break;
				case -7: txtPersenPPn.Focus(); break;
				case -8: txtNilaiPPn.Focus(); break;
				case -99: xGridView.Focus(); break;
				case -100: txtNoSeri.Focus(); break;
			}
		}
	}
}
