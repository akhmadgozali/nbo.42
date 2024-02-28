using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_BatalBayarDialog : InputDialog {
		private List<BatalBayarIklanDetailForSave> detailKoreksi;
		private PembayaranIklan originalEdit;

		public UI_BatalBayarDialog() {
			InitializeComponent();
			txtPeriode.EditValueChanging += new ChangingEventHandler(Periode_Changing);
			txtPembayaran.EditValueChanging += new ChangingEventHandler(Pembayaran_Changing);
			xGridView.ShowingEditor += new CancelEventHandler(GridShowingEditor);
			xGridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridValidatingEditor);
		}

		private void Periode_Changing(object sender, ChangingEventArgs e) {
			txtPembayaran.EditValue = null;
			if (e.NewValue == null) return;
			var tgl = (DateTime)e.NewValue;

			txtPembayaran.Properties.DataSource = BatalBayarService.GetSourcePembayaranKoreksi(session, tgl, Tipe == InputType.Tambah ? null : originalEdit);
		}
		private void Pembayaran_Changing(object sender, ChangingEventArgs e) {
			txtRegionalKwitansi.Text = ""; txtTanggalKwitansi.Text = ""; txtCaraBayarKwitansi.Text = ""; txtPemasang.Text = ""; 

			if (e.NewValue == null) return;
			var inv = (PembayaranIklan)e.NewValue;
			txtTanggalKwitansi.Text = inv.Tanggal.ToString("dd MMM yyyy");
			txtRegionalKwitansi.Text = inv.Regional.Nama;
			txtCaraBayarKwitansi.Text = inv.CaraBayar.Alias;
			txtPemasang.Text = inv.AtasNama;
			txtNoKoreksi.Text = inv.NoKwitansi + "-kor";

			detailKoreksi = BatalBayarService.GetKoreksiPembayaranDetail(session, inv, Tipe == InputType.Tambah ? null : originalEdit);
			xGrid.DataSource = detailKoreksi;
		}
		private void GridShowingEditor(object sender, CancelEventArgs e) {
			var row = (BatalBayarIklanDetailForSave)xGridView.GetRow(xGridView.FocusedRowHandle);
			if (!row.AllowEdit) e.Cancel = true;
		}
		private void GridValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e) {
			var view = xGridView;
			var row = (BatalBayarIklanDetailForSave)view.GetRow(xGridView.FocusedRowHandle);
			if (row != null) {
				var value = decimal.Parse(e.Value.ToString());
				if (view.FocusedColumn == colGKoreksi && value > row.InvoiceNominalBayar) {
					e.Valid = false;
					e.ErrorText = "Jumlah di setor tidak boleh lebih dari " + row.InvoiceNominalBayar.ToString("n0");
				}
			}
		}
		private void DisableControl() {
			EnableVisibleSaveButton(false, true);
			txtPeriode.Enabled = false;
			txtPembayaran.Enabled = false;
			txtNoKoreksi.Enabled = false;
			txtTanggalKoreksi.Enabled = false;
			txtKeteranganKoreksi.Enabled = false;

			xGridView.OptionsBehavior.Editable = false;
			colGKoreksi.AppearanceCell.BackColor = Color.Transparent;
			colGSelisih.AppearanceCell.BackColor = Color.Transparent;
		}

		public override void LoadBeforeInitialize() {
			txtPeriode.Properties.DataSource = IntegrasiService.GetPeriode(session);
			txtCaraBayarKoreksi.Properties.DataSource = new XPQuery<CaraBayar>(session).Where(w => w.Aktif && w.Akun.TipeAkun != TipeAkun.Kas && w.Akun.TipeAkun != TipeAkun.Bank).ToList();
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Batal Bayar Iklan : Tambah";
				txtPembayaran.EditValue = null;
				txtTanggalKoreksi.DateTime = DateTime.Now.Date;
				txtKeteranganKoreksi.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<PembayaranIklan>(Convert.ToInt64(IdToEdit));
				Text = "Batal Bayar Iklan : Edit - " + originalEdit.NoKwitansi;
				txtPeriode.EditValue = new DateTime(originalEdit.BatalBayarId.Tanggal.Year, originalEdit.BatalBayarId.Tanggal.Month, 1);
				txtPembayaran.EditValue = originalEdit.BatalBayarId;

				txtTanggalKoreksi.DateTime = originalEdit.Tanggal;
				txtNoKoreksi.Text = originalEdit.NoKwitansi;
				txtCaraBayarKoreksi.EditValue = originalEdit.CaraBayar;
				txtKeteranganKoreksi.Text = originalEdit.Keterangan;

				// cek disable
				try { PembayaranIklanService.CheckIsInUse(session, originalEdit); }
				catch { DisableControl(); }
			}
			txtPeriode.Focus();
		}
		public override void SimpanData() {
			PembayaranIklan instance;
			if (Tipe == InputType.Tambah) instance = new PembayaranIklan(session);
			else instance = session.GetObjectByKey<PembayaranIklan>(Convert.ToInt64(IdToEdit));
			var service = new BatalBayarService(session, originalEdit);

			instance.Tanggal = txtTanggalKoreksi.DateTime;
			instance.Keterangan = txtKeteranganKoreksi.Text;
			instance.NoKwitansi = txtNoKoreksi.Text;
			instance.CaraBayar = txtCaraBayarKoreksi.EditValue == null ? null : (CaraBayar)txtCaraBayarKoreksi.EditValue;
			instance.BatalBayarId = txtPembayaran.EditValue == null ? null : (PembayaranIklan)txtPembayaran.EditValue;
			instance.BatalBayarDetailForSave = detailKoreksi;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggalKoreksi.Focus(); break;
				case -2: txtKeteranganKoreksi.Focus(); break;
				case -3: txtPembayaran.Focus(); break;
				case -4: txtCaraBayarKoreksi.Focus(); break;
				case -5: txtNoKoreksi.Focus(); break;
			}
		}
	}
}
