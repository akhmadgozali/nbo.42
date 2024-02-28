using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_IklanPenagihanDialog : InputDialog {
		private BindingList<InvoicePenagihanForSave> _detail;
		private Invoice originalEdit;

		public UI_IklanPenagihanDialog() { 
			InitializeComponent();
			xGridView.KeyDown += new KeyEventHandler(ViewKeyDown);
			AutoCloseOnSave = true;
		}

		private void CheckDisableControl(Invoice obj) {
			bool disable = false;
			if (obj.StatusBayar > 1) disable = true;

			if (disable) {
				txtKurir.Enabled = false;
				txtKeterangan.Enabled = false;
				xGridView.OptionsBehavior.Editable = false;
				EnableVisibleSaveButton(false, true);
			}
		}
		private void ViewKeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Delete) {
				InvoicePenagihanForSave item = (InvoicePenagihanForSave)xGridView.GetRow(xGridView.FocusedRowHandle);
				xGridView.DeleteRow(xGridView.FocusedRowHandle);
				_detail.Remove(item);
			}
		}

		public override void LoadBeforeInitialize() {
			txtKurir.Properties.DataSource = new XPQuery<Kurir>(session).Where(w => w.Aktif).ToList();
			txtKeterangan.Properties.MaxLength = 255;
			colKeteranganRepo.MaxLength = 255;

			txtKurir.EditValue = ((List<Kurir>)txtKurir.Properties.DataSource)[0];
		}
		public override void InitializeData() {
			_detail = new BindingList<InvoicePenagihanForSave>();
			if (Tipe == InputType.Tambah) {
				//throw new Exception("Tidak boleh ada kosong invoice nya");
			}
			else {
				originalEdit = PenagihanInvoiceService.GetItem(session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit)));
				Text = "Pengiriman Invoice : " + originalEdit.NoInvoice;
				txtKurir.EditValue = originalEdit.Kurir;
				txtKeterangan.Text = originalEdit.Keterangan;
				foreach (var x in originalEdit.PenagihanForSave) _detail.Add(x);
				CheckDisableControl(originalEdit);
			}
			txtKurir.Focus();
			xGrid.DataSource = _detail;
		}
		public override void SimpanData() {
			Invoice instance;
			if (Tipe == InputType.Tambah) instance = new Invoice(session);
			else instance = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));
			var service = new PenagihanInvoiceService(session, originalEdit);

			instance.Kurir = txtKurir.EditValue == null ? null : (Kurir)txtKurir.EditValue;
			instance.Keterangan = txtKeterangan.Text;
			instance.PenagihanForSave = _detail.ToList();
			if (service.Save(instance)) {
				//if (txtCetak.Checked)
				//	((UI_IklanKirimInvoice)BaseForm).CetakTandaTerima(item.NomorInvoice);
				if (txtCetak.Checked) {
					var frm = new UI_FilterInvoice(MainClass.ReportCodeTransaksiTandaTerima);
					frm.txtInvoice1.Text = instance.NoInvoice;
					Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, MainClass.ReportCodeTransaksiTandaTerima, string.Empty, false);
				}
			};
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtKurir.Focus(); break;
				case -2: txtKeterangan.Focus(); break;
				case -99: xGridView.Focus(); break;
			}
		}
	}
}
