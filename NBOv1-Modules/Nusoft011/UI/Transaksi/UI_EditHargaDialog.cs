using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_EditHargaDialog : InputMDI {
		public UI_EditHargaDialog() {
			InitializeComponent();
			txtPeriode.EditValueChanging += new ChangingEventHandler(PeriodeChanging);
			txtUpdateJatah.EditValueChanging += new ChangingEventHandler(UpdateJatahChanging);
			txtUpdateKonsi.EditValueChanging += new ChangingEventHandler(UpdateKonsiChanging);
			AutoCloseOnSave = true;
		}
		private EditHarga originalEdit;

		private void UpdateJatahChanging(object sender, ChangingEventArgs e) {
			for (int i = 0; i <= xBandGrid.RowCount - 1; i++) {
				if (!xBandGrid.IsGroupRow(i)) {
					xBandGrid.SetRowCellValue(i, coJatahBaru, e.NewValue);
				}
			}
		}
		private void UpdateKonsiChanging(object sender, ChangingEventArgs e) {
			for (int i = 0; i <= xBandGrid.RowCount - 1; i++) {
				if (!xBandGrid.IsGroupRow(i)) {
					xBandGrid.SetRowCellValue(i, colKonsiBaru, e.NewValue);
				}
			}
		}
		private void PeriodeChanging(object sender, ChangingEventArgs e) {
			if (e.NewValue != null) {
				var d = (DateTime)e.NewValue;
				txtJmlHari.Value = DateTime.DaysInMonth(d.Year, d.Month);
				txtJmlHari.Properties.MaxValue = DateTime.DaysInMonth(d.Year, d.Month);
			}
		}

		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				txtPeriode.Properties.DataSource = EditHargaService.GetPeriode(session);
				Text = "Edit Harga - Tambah";
				txtPeriode.EditValue = null;
				txtKeterangan.Text = "";
				xGrid.DataSource = EditHargaService.GetNewDetail(session);
			}
			else {
				originalEdit = EditHargaService.GetItem(session, session.GetObjectByKey<EditHarga>(Convert.ToInt64(IdToEdit)));
				var tgl = new DateTime(originalEdit.Tahun, originalEdit.Bulan, 1);
				txtPeriode.Properties.DataSource = new List<KeyValuePair<DateTime, string>>() { new KeyValuePair<DateTime, string>(tgl, tgl.ToString("MMMM yyyy")) };
				Text = "Update Harga - Edit";
				txtPeriode.EditValue = tgl;
				txtPeriode.Enabled = false;
				txtJmlHari.Value = originalEdit.JumlahHari;
				txtKeterangan.Text = originalEdit.Keterangan;
				xGrid.DataSource = originalEdit.DetailForSave;
			}
		}
		public override void SimpanData() {
			EditHarga instance;
			if (Tipe == InputType.Tambah) instance = new EditHarga(session);
			else instance = session.GetObjectByKey<EditHarga>(Convert.ToInt64(IdToEdit));
			var service = new EditHargaService(session, originalEdit);
			var d = (DateTime)txtPeriode.EditValue;
			instance.Tahun = d.Year;
			instance.Bulan = d.Month;
			instance.JumlahHari = (int)txtJmlHari.Value;
			instance.Keterangan = txtKeterangan.Text;
			instance.DetailForSave = (List<EditHargaDetailForSave>)xGrid.DataSource;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) { ex.ShowWinMessageBox(); }
	}
}
