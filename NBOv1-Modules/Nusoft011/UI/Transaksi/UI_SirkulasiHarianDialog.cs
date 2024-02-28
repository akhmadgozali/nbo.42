using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_SirkulasiHarianDialog : InputMDI {
		public UI_SirkulasiHarianDialog() {
			InitializeComponent();
			txtTanggal.EditValueChanged += new EventHandler(TanggalChanged);
			txtHariKhusus.CheckedChanged += new EventHandler(TanggalChanged);
			AutoCloseOnSave = true;
		}
		private List<SirkulasiHarianDetailForSave> detail;
		private SirkulasiHarian originalEdit;

		private void TanggalChanged(object sender, EventArgs e) {
			if (Tipe == InputType.Tambah) {
				detail = SirkulasiHarianService.GetMutasiDetail(session, txtTanggal.DateTime, txtHariKhusus.Checked);
				xGrid.DataSource = detail;
			}
		}
		private void DisableControl() {
			AllowSave = false;

			txtTanggal.Enabled = false;
			txtHariKhusus.Enabled = false;
			txtKeterangan.Enabled = false;
			colJatahMutasi.OptionsColumn.AllowEdit = false;
			colJatahMutasi.OptionsColumn.ReadOnly = true;
			colJatahMutasi.AppearanceCell.BackColor = Color.Transparent;
			colKonsiMutasi.OptionsColumn.AllowEdit = false;
			colKonsiMutasi.OptionsColumn.ReadOnly = true;
			colKonsiMutasi.AppearanceCell.BackColor = Color.Transparent;
			colGratisMutasi.OptionsColumn.AllowEdit = false;
			colGratisMutasi.OptionsColumn.ReadOnly = true;
			colGratisMutasi.AppearanceCell.BackColor = Color.Transparent;
			colHargaJatah.OptionsColumn.AllowEdit = false;
			colHargaJatah.OptionsColumn.ReadOnly = true;
			colHargaJatah.AppearanceCell.BackColor = Color.Transparent;
			colHargaKonsi.OptionsColumn.AllowEdit = false;
			colHargaKonsi.OptionsColumn.ReadOnly = true;
			colHargaKonsi.AppearanceCell.BackColor = Color.Transparent;
		}

		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Sirkulasi Harian Koran : Tambah";
				txtTanggal.DateTime = DateTime.Now.Date;
				txtHariKhusus.Checked = false;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = SirkulasiHarianService.GetItem(session, session.GetObjectByKey<SirkulasiHarian>(Convert.ToInt64(IdToEdit)));
				Text = "Sirkulasi Harian Koran : Edit - " + originalEdit.Tanggal.ToString("dd MMMM yyyy");

				txtTanggal.DateTime = originalEdit.Tanggal;
				txtHariKhusus.Checked = originalEdit.HariKhusus;
				txtKeterangan.Text = originalEdit.Keterangan;
				detail = originalEdit.DetailForSave;
				xGrid.DataSource = detail;

				// cek disable
				if (SirkulasiHarianService.CheckIsInUse(session, originalEdit.Tanggal)) DisableControl();
			}
			txtTanggal.Focus();
		}
		public override void SimpanData() {
			SirkulasiHarian instance;
			if (Tipe == InputType.Tambah) instance = new SirkulasiHarian(session);
			else instance = session.GetObjectByKey<SirkulasiHarian>(Convert.ToInt64(IdToEdit));
			var service = new SirkulasiHarianService(session, originalEdit);
			instance.Tanggal = txtTanggal.DateTime;
			instance.HariKhusus = txtHariKhusus.Checked;
			instance.Keterangan = txtKeterangan.Text;
			instance.DetailForSave = detail;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggal.Focus(); break;
			}
		}
	}
}
