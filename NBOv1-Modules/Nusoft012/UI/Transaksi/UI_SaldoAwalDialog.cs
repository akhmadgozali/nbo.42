using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_SaldoAwalDialog : InputDialog {
		public UI_SaldoAwalDialog() {
			InitializeComponent();

			txtTanggal.DateTimeChanged += new EventHandler(TanggalChanged);
			txtSaldoPiutang.ValueChanged += new EventHandler(PiutangChanged);
			AutoCloseOnSave = true;
		}
		Invoice originalEdit;

		private void TanggalChanged(object sender, EventArgs e) {
			txtJatuhTempo.Properties.MinValue = txtTanggal.DateTime;
		}
		private void PiutangChanged(object sender, EventArgs e) {
			txtOmzet.Properties.MinValue = txtSaldoPiutang.Value;
			txtOmzet.Properties.MaxValue = decimal.MaxValue;
		}

		private void CheckDisableControl(Invoice obj) {
			bool disable;
			try { InvoiceService.CheckIsInUse(session, obj); disable = false; }
			catch { disable = true; }

			if (disable) {
				txtWilayah.Enabled = false;
				txtTipeInvoice.Enabled = false;
				txtNomorInvoice.Enabled = false;
				txtTanggal.Enabled = false;
				txtJatuhTempo.Enabled = false;
				txtSales.Enabled = false;
				txtPemasang.Enabled = false;
				txtSaldoPiutang.Enabled = false;
				txtOmzet.Enabled = false;
				txtCashbackPersen.Enabled = false;
				txtCashbackNominal.Enabled = false;
				txtKeterangan.Enabled = false;
				txtKomisiPersen.Enabled = false;
				txtKomisiNominal.Enabled = false;

				EnableVisibleSaveButton(false, true);
			}
		}

		public override void LoadBeforeInitialize() {
			txtWilayah.Properties.DataSource = new XPCollection<Wilayah>(session).ToList();

			txtTipeInvoice.Properties.DataSource = new XPCollection<TipeInvoice>(session);
			txtNomorInvoice.Properties.MaxLength = 30;
			txtSales.Properties.DataSource = new XPQuery<Sales>(session).Where(w => w.Aktif).ToList();
			txtPemasang.Properties.MaxLength = 100;
			txtKeterangan.Properties.MaxLength = 255;

			txtWilayah.EditValue = ((List<Wilayah>)txtWilayah.Properties.DataSource)[0];
			txtTipeInvoice.EditValue = ((XPCollection<TipeInvoice>)txtTipeInvoice.Properties.DataSource)[0];
			txtSales.EditValue = ((List<Sales>)txtSales.Properties.DataSource)[0];
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Saldo Awal Piutang : Tambah";
				txtNomorInvoice.Text = "";
				txtTanggal.DateTime = DateTime.Now;
				txtJatuhTempo.DateTime = DateTime.Now;
				txtPemasang.Text = "";
				txtSaldoPiutang.Value = 0;
				txtOmzet.Value = 0;
				txtKomisiPersen.Value = 0;
				txtKomisiNominal.Value = 0;
				txtCashbackPersen.Value = 0;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));
				Text = "Saldo Awal Piutang : Edit - " + originalEdit.NoInvoice;
				txtWilayah.EditValue = originalEdit.Wilayah;
				txtTipeInvoice.EditValue = originalEdit.TipeInvoice;
				txtNomorInvoice.Text = originalEdit.NoInvoice;
				txtTanggal.DateTime = originalEdit.TanggalOmzet;
				txtJatuhTempo.DateTime = originalEdit.TanggalJatuhTempo;
				txtSales.EditValue = originalEdit.Sales;
				txtPemasang.Text = originalEdit.InvoiceNama;
				txtSaldoPiutang.Value = originalEdit.Total;
				txtOmzet.Value = originalEdit.Netto;
				txtCashbackPersen.Value = originalEdit.CashbackPersen;
				txtCashbackNominal.Value = originalEdit.CashbackNominal;
				txtKeterangan.Text = originalEdit.Keterangan;
				txtKomisiPersen.Value = originalEdit.KomisiPersen;
				txtKomisiNominal.Value = originalEdit.KomisiNominal;
				CheckDisableControl(originalEdit);
			}
			txtWilayah.Focus();
		}
		public override void SimpanData() {
			Invoice instance;
			if (Tipe == InputType.Tambah) instance = new Invoice(session);
			else instance = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));
			var service = new InvoiceService(session, originalEdit);

			instance.Wilayah = txtWilayah.EditValue == null ? null : (Wilayah)txtWilayah.EditValue;
			instance.TipeInvoice = txtTipeInvoice.EditValue == null ? null : (TipeInvoice)txtTipeInvoice.EditValue;
			instance.NoInvoice = txtNomorInvoice.Text;
			instance.TanggalOmzet = txtTanggal.DateTime;
			instance.TanggalJatuhTempo = txtJatuhTempo.DateTime;
			instance.Sales = txtSales.EditValue == null ? null : (Sales)txtSales.EditValue;
			instance.InvoiceNama = txtPemasang.Text;
			instance.Total = txtSaldoPiutang.Value;
			instance.Netto = txtOmzet.Value;
			instance.KomisiPersen = txtKomisiPersen.Value;
			instance.KomisiNominal = txtKomisiNominal.Value;
			instance.CashbackPersen = txtCashbackPersen.Value;
			instance.CashbackNominal = txtCashbackNominal.Value;
			instance.Keterangan = txtKeterangan.Text;

			instance.SaldoAwal = true;
			instance.TanggalInvoice = txtTanggal.DateTime;
			if (instance.Wilayah != null) instance.InvoiceAlamat = instance.Wilayah.Nama;
			instance.InvoiceNPWP = PPnKeluaranService.GetDefaultNPWP();
			instance.Bruto = 0;
			instance.DiskonPersen = 0;
			instance.DiskonNominal = 0;
			instance.HargaTermasukPajak = false;
			instance.PajakPersen = 0;
			instance.PajakNominal = 0;

			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1:
				case -2: txtTanggal.Focus(); break;
				case -3: txtJatuhTempo.Focus(); break;
				case -4: txtWilayah.Focus(); break;
				case -5: txtSales.Focus(); break;
				case -6: txtTipeInvoice.Focus(); break;
				case -7: txtPemasang.Focus(); break;
				case -8: txtWilayah.Focus(); break;
				case -9: txtPemasang.Focus(); break;
				case -10: txtOmzet.Focus(); break;
				case -11: txtSaldoPiutang.Focus(); break;
				case -99: txtNomorInvoice.Focus(); break;
			}
		}
	}
}
