using DevExpress.Data;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_GabungIklanDialog : InputDialog {
		private Invoice originalEdit;

		public UI_GabungIklanDialog() {
			InitializeComponent();
			txtTahun.ValueChanged += new EventHandler(TahunChanged);
			txtInvoice.EditValueChanging += new ChangingEventHandler(InvoiceChanged);
			xGridView.SelectionChanged += new SelectionChangedEventHandler(GridSelectionChanged);
			AutoCloseOnSave = true;
		}

		private void TahunChanged(object sender, EventArgs e) {
			txtInvoice.EditValue = null;
			List<Invoice> source;
			if (Tipe == InputType.Tambah)
				source = new XPQuery<Invoice>(session).Where(w => w.TanggalOmzet.Year == txtTahun.Value && w.IndukInvoice == null 
					&& !w.SaldoAwal && w.StatusBayar == 0 && w.KoreksiInvoice == null && w.TipeInvoice.TipeIklan == ETipeIklan.Kolom).ToList();
			else
				source = new XPQuery<Invoice>(session).Where(w => (w.TanggalOmzet.Year == txtTahun.Value && w.IndukInvoice == null
					&& !w.SaldoAwal && w.StatusBayar == 0 && w.KoreksiInvoice == null && w.TipeInvoice.TipeIklan == ETipeIklan.Kolom) || (w == originalEdit)).ToList();

			txtInvoice.Properties.DataSource = source;
		}
		private void InvoiceChanged(object sender, ChangingEventArgs e) {
			xGrid.DataSource = null;
			if (e.NewValue != null) {
				var inv = (Invoice)e.NewValue;

				var source = new XPQuery<Invoice>(session).Where(w => !w.SaldoAwal && w.InvoiceNama == inv.InvoiceNama 
					&& w.TanggalOmzet.Year == inv.TanggalOmzet.Year && w.StatusBayar == 0 && w.KoreksiInvoice == null
					&& w != inv && (w.IndukInvoice == null || w.IndukInvoice == inv)).ToList();
				xGrid.DataSource = source;

				txtSales.Text = inv.Sales.Nama;
				txtPemasang.Text = inv.InvoiceNama;
				txtJudulIklan.Text = inv.InvoiceKeterangan;
				txtOmzetIklan.Value = inv.Total;
				SetTotal(inv);
			}
		}
		private void GridSelectionChanged(object sender, SelectionChangedEventArgs e) {
			if (txtInvoice.EditValue != null) {
				SetTotal((Invoice)txtInvoice.EditValue);
			}
		}
		private void SetTotal(Invoice invoice) {
			List<Invoice> listData = new List<Invoice>();

			var x = xGridView.GetSelectedRows();
			for (var i = x.GetLowerBound(0); i <= x.GetUpperBound(0); i++) {
				listData.Add((Invoice)xGridView.GetRow(x[i]));
			}
			txtBruto.Value = invoice.Bruto + listData.Sum(s => s.Bruto);
			txtDiskon.Value = invoice.DiskonNominal + listData.Sum(s => s.DiskonNominal);
			txtNetto.Value = invoice.Netto + listData.Sum(s => s.Netto);
			txtPajak.Value = invoice.PajakNominal + listData.Sum(s => s.PajakNominal);
			txtTotal.Value = invoice.Total + listData.Sum(s => s.Total);
		}

		private void CheckDisableControl(Invoice obj) {
			bool disable = false;
			if (obj.StatusBayar > 0) disable = true;

			if (disable) {
				txtTahun.Enabled = false;
				txtInvoice.Enabled = false;
				xGridView.OptionsBehavior.Editable = false;
				xGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
				EnableVisibleSaveButton(false, true);
			}
		}

		public override void LoadBeforeInitialize() {
			txtTahun.Properties.MaxValue = DateTime.Now.Year;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Gabung Iklan : Tambah";
				txtTahun.Value = DateTime.Now.Year;
			}
			else {
				originalEdit = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));
				Text = "Gabung Iklan : Edit - " + originalEdit.NoInvoice;
				txtTahun.Value = originalEdit.TanggalOmzet.Year;
				txtInvoice.EditValue = originalEdit;

				foreach (var d in originalEdit.DaftarAnak) {
					int rowHandle = xGridView.LocateByValue(nameof(Invoice.NoInvoice), d.NoInvoice);
					if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
						xGridView.SelectRow(rowHandle);
				}

				CheckDisableControl(originalEdit);
			}
		}
		public override void SimpanData() {
			if (txtInvoice.EditValue == null) throw new Utils.Exception("Masukkan invoice induk", -2);
			var listData = new List<Invoice>();

			var x = xGridView.GetSelectedRows();
			for (var i = x.GetLowerBound(0); i <= x.GetUpperBound(0); i++) {
				listData.Add((Invoice)xGridView.GetRow(x[i]));
			}

			var service = new GabungInvoiceService(session, originalEdit);
			var inv = (Invoice)txtInvoice.EditValue;
			inv.GabungIklanForSave = listData;
			service.Save(inv);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: xGrid.Focus(); break;
				case -2: txtInvoice.Focus(); break;
			}
		}
	}
}
