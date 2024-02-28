using DevExpress.Xpo;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraSplashScreen;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_BatalBayarDialog : InputDialog {
		public UI_BatalBayarDialog() {
			InitializeComponent();
			txtPeriode.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(Periode_Changing);
			txtKwitansi.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(Kwitansi_Changing);
			AutoCloseOnSave = true;
		}
		private BayarKoran originalEdit;
		private bool editAssign;

		private void Periode_Changing(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
			txtKwitansi.EditValue = null;
			if (e.NewValue == null) return;
			var tgl = (DateTime)e.NewValue;
			var source = PembayaranService.GetSourcePembayaranKoreksi(session, tgl, Tipe == InputType.Tambah ? null : originalEdit);
			txtKwitansi.Properties.DataSource = source;
		}
		private void Kwitansi_Changing(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
			if (editAssign) return;

			try {
				txtNoKwitansi.Text = ""; txtTanggalKwitansi.Text = ""; txtKwitansiNominal.Text = ""; txtKwitansiAgen.Text = "";
				txtKwitansiKeterangan.Text = "";
				txtNominalKoreksi.Properties.MaxValue = 0;

				if (e.NewValue == null) return;
				var kwitansi = (BayarKoran)e.NewValue;
				txtNoKwitansi.Text = kwitansi.Kode;
				txtTanggalKwitansi.Text = kwitansi.Tanggal.ToString("dd MMMM yyyy");
				txtKwitansiNominal.Text = kwitansi.TotalBayar.ToString("n0");
				txtKwitansiAgen.Text = kwitansi.Agen.Nama;
				txtCaraBayar.Text = kwitansi.CaraBayar.Alias;
				txtKwitansiKeterangan.Text = kwitansi.Keterangan;
				txtNominalKoreksi.Properties.MaxValue = (decimal)kwitansi.TotalBayar;
				txtNominalKoreksi.Value = (decimal)kwitansi.TotalBayar;
				txtNoKoreksi.Text = kwitansi.Kode + "-kor";
			}
			catch (Exception ex) { throw new Exception(ex.Message, ex.InnerException); }
		}
		private void DisableControl() {
			EnableVisibleSaveButton(false, true);

			txtPeriode.Enabled = false;
			txtKwitansi.Enabled = false;
			txtTanggalKoreksi.Enabled = false;
			txtCaraBayar.Enabled = false;
			txtNoKoreksi.Enabled = false;
			txtTanggalKoreksi.Enabled = false;
			txtKeteranganKoreksi.Enabled = false;
		}

		public override void LoadBeforeInitialize() {
			var periode = new List<KeyValuePair<DateTime, string>>();
			var aaa = new XPQuery<PeriodeAkuntansi>(session).Where(w => w.Tutup).Select(s => s.Periode).ToList();
			if (aaa.Count > 0) {
				var m = aaa.Min().AddMonths(-1);
				foreach (var x in aaa.OrderByDescending(o => o))
					periode.Add(new KeyValuePair<DateTime, string>(x, x.ToString("MMMM yyyy")));
				periode.Add(new KeyValuePair<DateTime, string>(m, m.ToString("MMMM yyyy")));
				txtPeriode.Properties.DataSource = periode;
			}

			txtCaraBayarKoreksi.Properties.DataSource = new XPQuery<CaraBayar>(session).Where(w => w.Aktif && w.Akun.TipeAkun != TipeAkun.Kas && w.Akun.TipeAkun != TipeAkun.Bank).ToList();
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Batal Bayar : Tambah";
				txtPeriode.EditValue = txtPeriode.Properties.DataSource == null ? default(DateTime) : ((List<KeyValuePair<DateTime, string>>)txtPeriode.Properties.DataSource)[0].Key;
				txtNoKoreksi.Text = "";
				txtTanggalKoreksi.DateTime = DateTime.Now.Date;
				txtNominalKoreksi.Value = 0;
			}
			else {
				editAssign = true;
				originalEdit = session.GetObjectByKey<BayarKoran>(Convert.ToInt64(IdToEdit));
				Text = "Batal Bayar : Edit - " + originalEdit.Kode;
				txtPeriode.EditValue = new DateTime(originalEdit.BatalBayarId.Tanggal.Year, originalEdit.BatalBayarId.Tanggal.Month, 1);
				txtKwitansi.EditValue = originalEdit.BatalBayarId;

				txtNoKwitansi.Text = originalEdit.BatalBayarId.Kode;
				txtTanggalKwitansi.Text = originalEdit.BatalBayarId.Tanggal.ToString("dd MMMM yyyy");
				txtKwitansiNominal.Text = originalEdit.BatalBayarId.TotalBayar.ToString("n0");
				txtKwitansiAgen.Text = originalEdit.BatalBayarId.Agen.Nama;
				txtCaraBayar.Text = originalEdit.BatalBayarId.CaraBayar.Alias;
				txtKwitansiKeterangan.Text = originalEdit.BatalBayarId.Keterangan;
				txtNominalKoreksi.Properties.MaxValue = (decimal)originalEdit.BatalBayarId.TotalBayar;

				txtNoKoreksi.Text = originalEdit.Kode;
				txtTanggalKoreksi.DateTime = originalEdit.Tanggal;
				txtNominalKoreksi.EditValue = originalEdit.BatalBayarId.TotalBayar + originalEdit.TotalBayar;
				txtKeteranganKoreksi.Text = originalEdit.Keterangan;

				// cek disable
				try { PembayaranService.CheckIsInUse(session, originalEdit); }
				catch { DisableControl(); }
				editAssign = false;
			}
			txtPeriode.Focus();
		}
		public override void SimpanData() {
			BayarKoran instance;
			if (Tipe == InputType.Tambah) instance = new BayarKoran(session);
			else instance = session.GetObjectByKey<BayarKoran>(Convert.ToInt64(IdToEdit));
			var service = new PembayaranService(session, originalEdit);
			instance.Kode = txtNoKoreksi.Text;
			instance.Tanggal = txtTanggalKoreksi.DateTime;
			instance.Agen = txtKwitansi.EditValue == null ? null : ((BayarKoran)txtKwitansi.EditValue).Agen;
			instance.CaraBayar = txtCaraBayarKoreksi.EditValue == null ? null : (CaraBayar)txtCaraBayarKoreksi.EditValue;
			instance.Keterangan = txtKeteranganKoreksi.Text;
			instance.BatalBayarId = txtKwitansi.EditValue == null ? null : ((BayarKoran)txtKwitansi.EditValue);
			instance.TotalBayar = (double)txtNominalKoreksi.Value;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggalKoreksi.Focus(); break;
				case -2: txtKwitansi.Focus(); break;
				case -3: txtCaraBayarKoreksi.Focus(); break;
				case -4: txtKeteranganKoreksi.Focus(); break;
				case -5: txtNominalKoreksi.Focus(); break;
				case -6: txtNoKoreksi.Focus(); break;
			}
		}
	}
}