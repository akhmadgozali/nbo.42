using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter;
using System;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_PembayaranDialog : InputDialog {
		public UI_PembayaranDialog() {
			InitializeComponent();
			var printer = new System.Drawing.Printing.PrinterSettings();
			layCetak.Text = printer?.PrinterName;
			txtTanggal.DateTimeChanged += new EventHandler(TanggalChanged);
			txtDiskon.EditValueChanging += new ChangingEventHandler(DiskonChanging);
			txtJumlahBayar.EditValueChanging += new ChangingEventHandler(BayarChanging);
		}
		private BayarKoran originalEdit;
		private bool editAssign;

		private void ChangeNoBukti(DateTime tanggal) {
			txtNoKwitansi.Properties.Mask.MaskType = MaskType.Regular;
			txtNoKwitansi.Properties.Mask.EditMask = NomorService.GetMaskNomorPemasaran(session, null, 1, tanggal);
		}
		private void TanggalChanged(object sender, EventArgs e) {
			if (editAssign) return;
			if (Tipe == InputType.Edit) {
				if (txtTanggal.DateTime.ToString("yyyyMM") != originalEdit.Tanggal.ToString("yyyyMM")) txtNoKwitansi.Text = string.Empty;
				else {
					if (originalEdit.Kode != txtNoKwitansi.Text) txtNoKwitansi.Text = originalEdit.Kode;
				}
			}
			ChangeNoBukti(txtTanggal.DateTime);
		}
		private void DisableControl() {
			EnableVisibleSaveButton(false, true);

			txtNoKwitansi.Enabled = false;
			txtTanggal.Enabled = false;
			txtAgen.Enabled = false;
			txtCaraBayar.Enabled = false;
			txtKeterangan.Enabled = false;
			txtJumlahBayar.Enabled = false;
			txtDiskon.Enabled = false;
		}

		private void BayarChanging(object sender, ChangingEventArgs e) => txtJumlahSetor.Value = Convert.ToDecimal(e.NewValue) - txtDiskon.Value;
		private void DiskonChanging(object sender, ChangingEventArgs e) => txtJumlahSetor.Value = txtJumlahBayar.Value - Convert.ToDecimal(e.NewValue);

		public override void LoadBeforeInitialize() {
			txtAgen.Properties.DataSource = new XPQuery<Agen>(session).ToList();
			txtCaraBayar.Properties.DataSource = new XPQuery<CaraBayar>(session).Where(w => w.Aktif).ToList();
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				var setting = new SirkulasiSetting(session);
				Text = "Pembayaran : Tambah";
				txtNoKwitansi.Text = "";
				txtTanggal.DateTime = DateTime.Now.Date;
				txtKeterangan.Text = setting.UraianPembayaran;
				txtJumlahBayar.Value = 0;
				txtDiskon.Value = 0;
				txtJumlahSetor.Value = 0;

				var bfr = txtAgen.EditValue;
				txtAgen.EditValue = null;
				txtAgen.EditValue = bfr;
			}
			else {
				editAssign = true;
				originalEdit = session.GetObjectByKey<BayarKoran>(Convert.ToInt64(IdToEdit));
				Text = "Pembayaran : Edit - " + originalEdit.Kode;

				txtNoKwitansi.Text = originalEdit.Kode;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtAgen.EditValue = originalEdit.Agen;
				txtCaraBayar.EditValue = originalEdit.CaraBayar;
				txtKeterangan.Text = originalEdit.Keterangan;
				txtJumlahBayar.EditValue = originalEdit.TotalBayar;
				txtDiskon.EditValue = originalEdit.Diskon;
				txtJumlahSetor.EditValue = originalEdit.TotalSetor;

				// cek disable
				try { PembayaranService.CheckIsInUse(session, originalEdit); }
				catch { DisableControl(); }
				editAssign = false;
			}
			txtTanggal.Focus();
		}
		public override void SimpanData() {
			BayarKoran instance;
			if (Tipe == InputType.Tambah) instance = new BayarKoran(session);
			else instance = session.GetObjectByKey<BayarKoran>(Convert.ToInt64(IdToEdit));
			var service = new PembayaranService(session, originalEdit);
			instance.Kode = txtNoKwitansi.Text;
			instance.Tanggal = txtTanggal.DateTime;
			instance.Agen = txtAgen.EditValue == null ? null : (Agen)txtAgen.EditValue;
			instance.CaraBayar = txtCaraBayar.EditValue == null ? null : (CaraBayar)txtCaraBayar.EditValue;
			instance.Keterangan = txtKeterangan.Text;
			instance.TotalBayar = (double)txtJumlahBayar.Value;
			instance.Diskon = (double)txtDiskon.Value;
			service.Save(instance);

			if (txtCetak.Checked) {				
				var frm = new UI_FilterPembayaranAgen(MainClass.ReportName.AgenKwitansi);
				frm.txtNoKwitansi.Text = instance.Kode;
				var message = "Apakah anda ingin mencetak kwitansi dengan nomor '" + instance.Kode + "' ?";
				Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, "1103.03", string.Empty, false);
			}
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggal.Focus(); break;
				case -2: txtAgen.Focus(); break;
				case -3: txtCaraBayar.Focus(); break;
				case -4: txtKeterangan.Focus(); break;
				case -5: txtJumlahBayar.Focus(); break;
				case -6: txtNoKwitansi.Focus(); break;
			}
		}
	}
}
