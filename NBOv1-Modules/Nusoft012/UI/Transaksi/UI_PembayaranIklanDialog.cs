using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_PembayaranIklanDialog : InputDialog {
		public UI_PembayaranIklanDialog() {
			InitializeComponent();
			var printer = new System.Drawing.Printing.PrinterSettings();
			layCetak.Text = printer?.PrinterName;
			txtRegional.EditValueChanging += new ChangingEventHandler(RegionalChanging);
			txtTanggal.DateTimeChanged += new EventHandler(TanggalChanged);
			txtSales.EditValueChanging += new ChangingEventHandler(SalesChanging);
			txtPemasang.EditValueChanging += new ChangingEventHandler(PemasangChanging);
			xGridViewBand.ShowingEditor += new CancelEventHandler(GridShowingEditor);
			xGridViewBand.CellValueChanged += new CellValueChangedEventHandler(GridCellValueChanged);
		}

		private bool _editAssign;
		private IklanSetting setting;
		private PembayaranIklan originalEdit;
		private List<PembayaranIklanDetailForSave> _detail;

		private void ChangeNoBukti(DateTime tanggal, Regional regional) {
			if (_editAssign) return;
			if (Tipe == InputType.Edit) {
				if (txtTanggal.DateTime.ToString("yyyyMM") != originalEdit.Tanggal.ToString("yyyyMM") || originalEdit.Regional != regional) txtNoKwitansi.Text = string.Empty;
				else {
					if (originalEdit.NoKwitansi != txtNoKwitansi.Text) txtNoKwitansi.Text = originalEdit.NoKwitansi;
				}
			}

			txtNoKwitansi.Properties.Mask.MaskType = MaskType.Regular;
			txtNoKwitansi.Properties.Mask.EditMask = NomorService.GetMaskNomorPembayaran(session, setting, tanggal, regional);
		}
		private void TanggalChanged(object sender, EventArgs e) {
			ChangeNoBukti(txtTanggal.DateTime, txtRegional.EditValue == null ? null : (Regional)txtRegional.EditValue);
		}
		private void RegionalChanging(object sender, ChangingEventArgs e) {
			ChangeNoBukti(txtTanggal.DateTime, e.NewValue == null ? null : (Regional)e.NewValue);
			if (e.NewValue == null) return;
			if (txtSales.EditValue != null) {
				if (Tipe == InputType.Tambah) _detail = PembayaranIklanService.GetDetailPiutang(session, (Sales)txtSales.EditValue, string.Empty, null);
				else _detail = PembayaranIklanService.GetDetailPiutang(session, (Sales)txtSales.EditValue, string.Empty, originalEdit);
				xGrid.DataSource = _detail.Where(w => w.Invoice.Wilayah.Regional == (Regional)e.NewValue).ToList();
			}
			else if (txtPemasang.EditValue != null) {
				if (Tipe == InputType.Tambah) _detail = PembayaranIklanService.GetDetailPiutang(session, null, txtPemasang.EditValue.ToString(), null);
				else _detail = PembayaranIklanService.GetDetailPiutang(session, null, txtPemasang.EditValue.ToString(), originalEdit);
				xGrid.DataSource = _detail.Where(w => w.Invoice.Wilayah.Regional == (Regional)e.NewValue).ToList();
			}
		}
		private void SalesChanging(object sender, ChangingEventArgs e) {
			xGrid.DataSource = null;
			if (e.NewValue == null) return;

			txtPemasang.EditValue = null;
			colPemasang.Caption = "Pemasang";
			colPemasang.FieldName = "Invoice.InvoiceNama";

			if (Tipe == InputType.Tambah) _detail = PembayaranIklanService.GetDetailPiutang(session, (Sales)e.NewValue, string.Empty, null);
			else _detail = PembayaranIklanService.GetDetailPiutang(session, (Sales)e.NewValue, string.Empty, originalEdit);
			if (txtRegional.EditValue != null) xGrid.DataSource = _detail.Where(w => w.Invoice.Wilayah.Regional == (Regional)txtRegional.EditValue).ToList();
		}
		private void PemasangChanging(object sender, ChangingEventArgs e) {
			xGrid.DataSource = null;
			if (e.NewValue == null) return;

			txtSales.EditValue = null;
			colPemasang.Caption = "Sales";
			colPemasang.FieldName = "Invoice.Sales.Nama";

			if (Tipe == InputType.Tambah) _detail = PembayaranIklanService.GetDetailPiutang(session, null, e.NewValue.ToString(), null);
			else _detail = PembayaranIklanService.GetDetailPiutang(session, null, e.NewValue.ToString(), originalEdit);
			if (txtRegional.EditValue != null) xGrid.DataSource = _detail.Where(w => w.Invoice.Wilayah.Regional == (Regional)txtRegional.EditValue).ToList();
		}

		private void GridShowingEditor(object sender, CancelEventArgs e) {
			var row = (PembayaranIklanDetailForSave)xGridViewBand.GetRow(xGridViewBand.FocusedRowHandle);
			if (!row.AllowEdit) e.Cancel = true;
		}
		private void GridCellValueChanged(object sender, CellValueChangedEventArgs e) {
			var row = (PembayaranIklanDetailForSave)xGridViewBand.GetRow(e.RowHandle);
			if (e.Column == colCashbackPersen) {
				row.CashbackNominal = (row.Invoice.Netto * row.CashbackPersen) / 100;
			}
			else if (e.Column == colCashbackNominal) {
				row.CashbackPersen = (row.CashbackNominal * 100) / row.Invoice.Netto;
			}
			else if (e.Column == colKomisiPersen || e.Column == colPotonganKomisi) {
				var dpp = row.Invoice.Netto - row.CashbackNominal - row.PotonganKomisiNominal;
				row.KomisiNominal = (dpp * row.KomisiPersen) / 100;
			}
			else if (e.Column == colKomisiNominal) {
				var dpp = row.Invoice.Netto - row.CashbackNominal - row.PotonganKomisiNominal;
				row.KomisiPersen = (row.KomisiNominal * 100) / dpp;
			}
		}
		private void DisableControl() {
			EnableVisibleSaveButton(false, true);
			txtTanggal.Enabled = false;
			txtCaraBayar.Enabled = false;
			txtRegional.Enabled = false;
			txtSales.Enabled = false;
			txtPemasang.Enabled = false;
			txtKeterangan.Enabled = false;
			txtNoKwitansi.Enabled = false;
			xGridViewBand.OptionsBehavior.Editable = false;
			colNominalBayar.AppearanceCell.BackColor = Color.Transparent;
			colCashbackPersen.AppearanceCell.BackColor = Color.Transparent;
			colCashbackNominal.AppearanceCell.BackColor = Color.Transparent;
			colPotonganKomisi.AppearanceCell.BackColor = Color.Transparent;
			colKomisiPersen.AppearanceCell.BackColor = Color.Transparent;
			colKomisiNominal.AppearanceCell.BackColor = Color.Transparent;
		}

		public override void LoadBeforeInitialize() {
			setting = new IklanSetting(session);
			txtCaraBayar.Properties.DataSource = new XPQuery<CaraBayar>(session).Where(w => w.Aktif).ToList();
			txtSales.Properties.DataSource = new XPCollection<Invoice>(session).GroupBy(g => g.Sales).Select(s => s.Key).ToList();
			txtPemasang.Properties.DataSource = new XPCollection<Invoice>(session).GroupBy(g => g.InvoiceNama).Select(s => new { Pemasang = s.Key }).ToList();
			txtRegional.Properties.DataSource = new XPCollection<Regional>(session).ToList();

			txtCaraBayar.EditValue = ((List<CaraBayar>)txtCaraBayar.Properties.DataSource)[0];
			_editAssign = true;
			txtTanggal.DateTime = DateTime.Now.Date;
			_editAssign = false;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Pembayaran Iklan : Tambah";
				txtRegional.EditValue = null;
				txtRegional.EditValue = ((List<Regional>)txtRegional.Properties.DataSource)[0];
				txtKeterangan.Text = setting.UraianPembayaran;
				txtNoKwitansi.Text = "";
			}
			else {
				_editAssign = true;
				originalEdit = session.GetObjectByKey<PembayaranIklan>(Convert.ToInt64(IdToEdit));
				Text = "Pembayaran Iklan : Edit - " + originalEdit.NoKwitansi;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtCaraBayar.EditValue = originalEdit.CaraBayar;
				txtRegional.EditValue = originalEdit.Regional;
				txtKeterangan.Text = originalEdit.Keterangan;
				txtNoKwitansi.Text = originalEdit.NoKwitansi;

				if (originalEdit.Sales != null) txtSales.EditValue = originalEdit.Sales;
				else txtPemasang.EditValue = originalEdit.Pemasang;

				// cek disable
				try { PembayaranIklanService.CheckIsInUse(session, originalEdit); }
				catch { DisableControl(); }
				_editAssign = false;
			}
			txtTanggal.Focus();
		}
		public override void SimpanData() {
			PembayaranIklan instance;
			if (Tipe == InputType.Tambah) instance = new PembayaranIklan(session);
			else instance = session.GetObjectByKey<PembayaranIklan>(Convert.ToInt64(IdToEdit));
			var service = new PembayaranIklanService(session, originalEdit);

			instance.Tanggal = txtTanggal.DateTime;
			instance.CaraBayar = txtCaraBayar.EditValue == null ? null : (CaraBayar)txtCaraBayar.EditValue;
			instance.Regional = txtRegional.EditValue == null ? null : (Regional)txtRegional.EditValue;
			instance.Keterangan = txtKeterangan.Text;
			instance.NoKwitansi = txtNoKwitansi.Text;
			instance.DetailForSave = (List<PembayaranIklanDetailForSave>)xGrid.DataSource;
			if (txtSales.EditValue == null) {
				instance.Sales = null;
				instance.Pemasang = txtPemasang.Text;
			}
			else {
				instance.Sales = (Sales)txtSales.EditValue;
				instance.Pemasang = string.Empty;
			}

			if (service.Save(instance)) {
				//if (txtCetakKwitansi.Checked) ((UI_PembayaranIklanTV)BaseForm).CetakKwitansi(item.NomorKwitansi, true);
				//if (txtCetakBKM.Checked) ((UI_PembayaranIklanTV)BaseForm).CetakKwitansi(item.NomorKwitansi, false);
				if (txtCetakKwitansi.Checked) {
					var reportCode = MainClass.ReportCodeTransaksiKwitansi;
					var frm = new UI_FilterKwitansi(reportCode);
					frm.txtKwitansi1.Text = instance.NoKwitansi;
					Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, string.Empty, false);
				}
			}
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggal.Focus(); break;
				case -2: txtRegional.Focus(); break;
				case -3: txtCaraBayar.Focus(); break;
				case -4: txtKeterangan.Focus(); break;
				case -6: txtNoKwitansi.Focus(); break;
				case -99: xGridViewBand.Focus(); break;
			}
		}
	}
}
