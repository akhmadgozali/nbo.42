using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
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
	public partial class UI_PencairanCashbackDialog : InputDialog {
		public UI_PencairanCashbackDialog() {
			InitializeComponent();
			var printer = new System.Drawing.Printing.PrinterSettings();
			layCetak.Text = printer?.PrinterName;
			txtRegional.EditValueChanging += new ChangingEventHandler(RegionalChanging);
			txtTanggal.DateTimeChanged += new EventHandler(TanggalChanged);
			txtPemasang.EditValueChanging += new ChangingEventHandler(PemasangChanging);
			xGridView.ShowingEditor += new CancelEventHandler(GridShowingEditor);
		}

		private bool _editAssign;
		private IklanSetting setting;
		private PencairanCashback originalEdit;
		private List<PencairanCashbackDetailForSave> _detail;

		private void ChangeNoBukti(DateTime tanggal, Regional regional) {
			if (_editAssign) return;
			if (Tipe == InputType.Edit) {
				if (txtTanggal.DateTime.ToString("yyyyMM") != originalEdit.Tanggal.ToString("yyyyMM") || originalEdit.Regional != regional) txtNoBukti.Text = string.Empty;
				else {
					if (originalEdit.NoBukti != txtNoBukti.Text) txtNoBukti.Text = originalEdit.NoBukti;
				}
			}

			txtNoBukti.Properties.Mask.MaskType = MaskType.Regular;
			txtNoBukti.Properties.Mask.EditMask = NomorService.GetMaskNomorPencairanCashback(session, setting, tanggal, regional);
		}
		private void TanggalChanged(object sender, EventArgs e) {
			ChangeNoBukti(txtTanggal.DateTime, txtRegional.EditValue == null ? null : (Regional)txtRegional.EditValue);
		}
		private void RegionalChanging(object sender, ChangingEventArgs e) {
			ChangeNoBukti(txtTanggal.DateTime, e.NewValue == null ? null : (Regional)e.NewValue);
			if (e.NewValue == null || txtPemasang.EditValue == null) return;
			if (Tipe == InputType.Tambah) _detail = PencairanCashbackService.GetDetailHutangCashback(session, txtPemasang.EditValue.ToString(), null);
			else _detail = PencairanCashbackService.GetDetailHutangCashback(session, txtPemasang.EditValue.ToString(), originalEdit);
			xGrid.DataSource = _detail.Where(w => w.Cashback.Invoice.Wilayah.Regional == (Regional)e.NewValue).ToList();
		}
		private void PemasangChanging(object sender, ChangingEventArgs e) {
			xGrid.DataSource = null;
			if (e.NewValue == null || txtRegional.EditValue == null) return;

			if (Tipe == InputType.Tambah) _detail = PencairanCashbackService.GetDetailHutangCashback(session, e.NewValue.ToString(), null);
			else _detail = PencairanCashbackService.GetDetailHutangCashback(session, e.NewValue.ToString(), originalEdit);
			if (txtRegional.EditValue != null) xGrid.DataSource = _detail.Where(w => w.Cashback.Invoice.Wilayah.Regional == (Regional)txtRegional.EditValue).ToList();
		}

		private void GridShowingEditor(object sender, CancelEventArgs e) {
			var row = (PencairanCashbackDetailForSave)xGridView.GetRow(xGridView.FocusedRowHandle);
			if (!row.AllowEdit) e.Cancel = true;
		}
		private void DisableControl() {
			EnableVisibleSaveButton(false, true);
			txtTanggal.Enabled = false;
			txtCaraBayar.Enabled = false;
			txtRegional.Enabled = false;
			txtPemasang.Enabled = false;
			txtKeterangan.Enabled = false;
			txtNoBukti.Enabled = false;
			xGridView.OptionsBehavior.Editable = false;
			colJumlah.AppearanceCell.BackColor = Color.Transparent;
		}

		public override void LoadBeforeInitialize() {
			setting = new IklanSetting(session);
			txtCaraBayar.Properties.DataSource = new XPQuery<CaraBayar>(session).Where(w => w.Aktif).ToList();
			txtPemasang.Properties.DataSource = new XPCollection<PembayaranIklanDetail>(session).Where(w => w.Lunas && w.CashbackNominal > 0).GroupBy(g => g.Invoice.InvoiceNama).Select(s => new { Pemasang = s.Key }).ToList();
			txtRegional.Properties.DataSource = new XPCollection<Regional>(session).ToList();

			txtCaraBayar.EditValue = ((List<CaraBayar>)txtCaraBayar.Properties.DataSource)[0];
			_editAssign = true;
			txtTanggal.DateTime = DateTime.Now.Date;
			_editAssign = false;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Pencairan Cashback : Tambah";
				txtRegional.EditValue = null;
				txtRegional.EditValue = ((List<Regional>)txtRegional.Properties.DataSource)[0];
				txtKeterangan.Text = setting.UraianPencairanCashback;
				txtNoBukti.Text = "";
			}
			else {
				_editAssign = true;
				originalEdit = session.GetObjectByKey<PencairanCashback>(Convert.ToInt64(IdToEdit));
				Text = "Pencairan Cashback : Edit - " + originalEdit.NoBukti;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtCaraBayar.EditValue = originalEdit.CaraBayar;
				txtRegional.EditValue = originalEdit.Regional;
				txtKeterangan.Text = originalEdit.Keterangan;
				txtNoBukti.Text = originalEdit.NoBukti;
				txtPemasang.EditValue = originalEdit.Pemasang;

				// cek disable
				try { PencairanCashbackService.CheckIsInUse(session, originalEdit); }
				catch { DisableControl(); }
				_editAssign = false;
			}
			txtTanggal.Focus();
		}
		public override void SimpanData() {
			PencairanCashback instance;
			if (Tipe == InputType.Tambah) instance = new PencairanCashback(session);
			else instance = session.GetObjectByKey<PencairanCashback>(Convert.ToInt64(IdToEdit));
			var service = new PencairanCashbackService(session, originalEdit);

			instance.Tanggal = txtTanggal.DateTime;
			instance.CaraBayar = txtCaraBayar.EditValue == null ? null : (CaraBayar)txtCaraBayar.EditValue;
			instance.Regional = txtRegional.EditValue == null ? null : (Regional)txtRegional.EditValue;
			instance.Keterangan = txtKeterangan.Text;
			instance.Pemasang = txtPemasang.Text;
			instance.NoBukti = txtNoBukti.Text;
			instance.DetailForSave = (List<PencairanCashbackDetailForSave>)xGrid.DataSource;

			if (service.Save(instance)) {
				//if (txtCetakKwitansi.Checked) ((UI_PembayaranIklanTV)BaseForm).CetakKwitansi(item.NomorKwitansi, true);
				//if (txtCetakBKM.Checked) ((UI_PembayaranIklanTV)BaseForm).CetakKwitansi(item.NomorKwitansi, false);
				if (txtCetakBKM.Checked) {
					var reportCode = MainClass.ReportCodeTransaksiBuktiPencairanCashback;
					var frm = new UI_FilterKwitansi(reportCode);
					frm.txtKwitansi1.Text = instance.NoBukti;
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
				case -4: txtPemasang.Focus(); break;
				case -5: txtKeterangan.Focus(); break;
				case -6: txtNoBukti.Focus(); break;
				case -99: xGridView.Focus(); break;
			}
		}
	}
}
