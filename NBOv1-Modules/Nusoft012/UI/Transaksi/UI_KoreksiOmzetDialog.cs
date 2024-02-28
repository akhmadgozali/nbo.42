using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_KoreksiOmzetDialog : InputDialog {
		private bool _editAssign;
		private bool _editDiskon;
		private bool _editPajak;
		private Invoice originalEdit;

		public UI_KoreksiOmzetDialog() {
			InitializeComponent();
			txtPeriode.EditValueChanging += new ChangingEventHandler(Periode_Changing);
			txtNoInvoice.EditValueChanging += new ChangingEventHandler(Invoice_Changing);
			txtKoreksiBruto.EditValueChanging += new ChangingEventHandler(KoreksiBruto_Changing);
			txtKoreksiDiskon.EditValueChanging += new ChangingEventHandler(KoreksiDiskon_Changing);
			txtKoreksiPajak.EditValueChanging += new ChangingEventHandler(KoreksiPajak_Changing);
		}

		private void Periode_Changing(object sender, ChangingEventArgs e) {
			txtNoInvoice.EditValue = null;
			if (e.NewValue == null) return;
			var tgl = (DateTime)e.NewValue;
			List<Invoice> invoice;

			if (Tipe == InputType.Tambah)
				invoice = new XPQuery<Invoice>(session).Where(w => (!w.SaldoAwal && w.TanggalOmzet.Year == tgl.Year && w.TanggalOmzet.Month == tgl.Month
					&& (w.TaxId == null || w.TaxId.StatusFaktur == EFakturStatus.Edit) && w.StatusBayar == 0 && w.IndukInvoice == null && w.KoreksiInvoice == null)).ToList();
			else
				invoice = new XPQuery<Invoice>(session).Where(w => w == originalEdit.KoreksiInvoice || (
					!w.SaldoAwal && w.TanggalOmzet.Year == tgl.Year && w.TanggalOmzet.Month == tgl.Month 
					&& (w.TaxId == null || w.TaxId.StatusFaktur == EFakturStatus.Edit) && w.StatusBayar == 0 && w.IndukInvoice == null && w.KoreksiInvoice == null)).ToList();

			txtNoInvoice.Properties.DataSource = invoice;
		}
		private void Invoice_Changing(object sender, ChangingEventArgs e) {
			if (_editAssign) return;

			try {
				txtTanggalInvoice.Text = ""; txtSales.Text = ""; txtPemasang.Text = "";
				txtInvoiceBruto.Value = 0; txtInvoiceDiskon.Value = 0; txtInvoiceNetto.Value = 0;
				txtInvoicePajak.Value = 0; txtInvoiceTotal.Value = 0;
				txtKoreksiBruto.Value = 0; txtKoreksiDiskon.Value = 0; 
				txtSelisihBruto.Value = 0; txtSelisihDiskon.Value = 0; txtSelisihNetto.Value = 0;
				txtSelisihPajak.Value = 0; txtSelisihTotal.Value = 0;

				if (e.NewValue == null) return;
				var inv = (Invoice)e.NewValue;
				txtTanggalInvoice.Text = inv.TanggalOmzet.ToString("dd MMM yyyy");
				txtSales.Text = inv.Sales.Nama;
				txtPemasang.Text = inv.InvoiceNama;
				txtInvoiceBruto.Value = inv.Bruto;
				txtInvoiceDiskonPersen.Value = inv.DiskonPersen;
				txtInvoiceDiskon.Value = inv.DiskonNominal;
				txtInvoiceNetto.Value = inv.Netto;
				txtInvoicePajakPersen.Value = inv.PajakPersen;
				txtInvoicePajak.Value = inv.PajakNominal;
				txtInvoiceTotal.Value = inv.Total;
				txtKoreksiBruto.Value = inv.Bruto;
				txtKoreksiDiskon.Value = inv.DiskonNominal;
				//txtKoreksiBruto.Properties.MaxValue = inv.TotalBruto;
				//txtKoreksiDiskon.Properties.MaxValue = inv.TotalDiskonNominal;
			}
			catch (Exception ex) { throw new Exception(ex.Message, ex.InnerException); }
		}
		private void KoreksiBruto_Changing(object sender, ChangingEventArgs e) { SetTotal(e.NewValue, null, null); }
		private void KoreksiDiskon_Changing(object sender, ChangingEventArgs e) { if (!_editDiskon) SetTotal(null, e.NewValue, null); }
		private void KoreksiPajak_Changing(object sender, ChangingEventArgs e) { if (!_editPajak) SetTotal(null, null, e.NewValue); }

		private void DisableControl() {
			EnableVisibleSaveButton(false, true);
			txtPeriode.Enabled = false;
			txtNoInvoice.Enabled = false;
			txtTanggalKoreksi.Enabled = false;
			txtKeteranganKoreksi.Enabled = false;
			txtKoreksiBruto.Enabled = false;
			txtKoreksiDiskon.Enabled = false;
			txtKoreksiPajak.Enabled = false;
		}
		private void SetTotal(object Bruto, object Diskon, object Pajak) {
			decimal _bruto, _diskon, _netto, _pajak, _total;

			if (Bruto != null) _bruto = decimal.Parse(Bruto.ToString());
			else _bruto = txtKoreksiBruto.Value;
			txtSelisihBruto.Value = _bruto - txtInvoiceBruto.Value;

			if (Diskon != null) _diskon = decimal.Parse(Diskon.ToString());
			else if (Bruto == null) _diskon = txtKoreksiDiskon.Value;
			else {
				_editDiskon = true;
				_diskon = Math.Round((_bruto * txtInvoiceDiskonPersen.Value) / 100);
				txtKoreksiDiskon.Value = _diskon;
				_editDiskon = false;
			}
			txtSelisihDiskon.Value = _diskon - txtInvoiceDiskon.Value;

			_netto = _bruto - _diskon;
			txtKoreksiNetto.Value = _netto;
			txtSelisihNetto.Value = _netto - txtInvoiceNetto.Value;

			if (Pajak == null) {
				_editPajak = true;
				_pajak = Math.Round((_netto * txtInvoicePajakPersen.Value) / 100);
				txtKoreksiPajak.Value = _pajak;
				_editPajak = false;
			}
			else {
				_pajak = decimal.Parse(Pajak.ToString());
			}
			txtSelisihPajak.Value = _pajak - txtInvoicePajak.Value;

			_total = _netto + _pajak;
			txtKoreksiTotal.Value = _total;
			txtSelisihTotal.Value = _total - txtInvoiceTotal.Value;
		}

		public override void LoadBeforeInitialize() {
			txtPeriode.Properties.DataSource = IntegrasiService.GetPeriode(session);
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Koreksi Omzet : Tambah";
				txtTanggalKoreksi.DateTime = DateTime.Now.Date;
				txtKeteranganKoreksi.Text = string.Empty;
				txtKoreksiBruto.Value = 0;
				txtKoreksiDiskon.Value = 0;
				txtKoreksiPajak.Value = 0;
			}
			else {
				_editAssign = true;
				originalEdit = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));
				Text = "Koreksi Omzet : Edit - " + originalEdit.NoInvoice;
				txtPeriode.EditValue = new DateTime(originalEdit.TanggalOmzet.Year, originalEdit.TanggalOmzet.Month, 1);
				txtNoInvoice.EditValue = originalEdit.KoreksiInvoice;

				txtTanggalInvoice.Text = originalEdit.KoreksiInvoice.TanggalOmzet.ToString("dd MMM yyyy");
				txtSales.Text = originalEdit.KoreksiInvoice.Sales.Nama;
				txtPemasang.Text = originalEdit.KoreksiInvoice.InvoiceNama;

				txtInvoiceBruto.Value = originalEdit.KoreksiInvoice.Bruto;
				txtInvoiceDiskonPersen.Value = originalEdit.KoreksiInvoice.DiskonPersen;
				txtInvoiceDiskon.Value = originalEdit.KoreksiInvoice.DiskonNominal;
				txtInvoiceNetto.Value = originalEdit.KoreksiInvoice.Netto;
				txtInvoicePajakPersen.Value = originalEdit.KoreksiInvoice.PajakPersen;
				txtInvoicePajak.Value = originalEdit.KoreksiInvoice.PajakNominal;
				txtInvoiceTotal.Value = originalEdit.KoreksiInvoice.Total;

				txtTanggalKoreksi.DateTime = originalEdit.TanggalOmzet;
				txtKeteranganKoreksi.Text = originalEdit.InvoiceKeterangan;
				txtKoreksiBruto.Value = txtInvoiceBruto.Value + originalEdit.Bruto;
				txtKoreksiDiskon.Value = txtInvoiceDiskon.Value + originalEdit.DiskonNominal;
				txtKoreksiPajak.Value = txtInvoicePajak.Value + originalEdit.PajakNominal;

				SetTotal(null, null, txtKoreksiPajak.EditValue);

				// cek disable
				try { InvoiceService.CheckIsInUse(session, originalEdit); }
				catch { DisableControl(); }
				_editAssign = false;
			}
			txtPeriode.Focus();
		}
		public override void SimpanData() {
			if (txtNoInvoice.EditValue == null) throw new Utils.Exception("Masukkan invoice yang akan dikoreksi", -1);
			if (txtTanggalKoreksi.DateTime == default) throw new Utils.Exception("Masukkan tanggal koreksi", -2);
			if (string.IsNullOrEmpty(txtKeteranganKoreksi.Text)) throw new Utils.Exception("Masukkan keterangan koreksi", -3);
			if (txtSelisihBruto.Value == 0) throw new Utils.Exception("Masukkan nilai koreksi", -4);

			Invoice instance;
			if (Tipe == InputType.Tambah) instance = new Invoice(session);
			else instance = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));
			var service = new InvoiceService(session, originalEdit);

			instance.TanggalOmzet = txtTanggalKoreksi.DateTime;
			instance.TanggalInvoice = txtTanggalKoreksi.DateTime;
			instance.TanggalJatuhTempo = txtTanggalKoreksi.DateTime;
			instance.InvoiceKeterangan = txtKeteranganKoreksi.Text;
			instance.KoreksiInvoice = txtNoInvoice.EditValue == null ? null : (Invoice)txtNoInvoice.EditValue;
			instance.HargaIklan = txtSelisihBruto.Value;
			instance.Bruto = txtSelisihBruto.Value;
			instance.DiskonPersen = txtInvoiceDiskonPersen.Value;
			instance.DiskonNominal = txtSelisihDiskon.Value;
			instance.Netto = txtSelisihNetto.Value;
			instance.PajakPersen = txtInvoicePajakPersen.Value;
			instance.PajakNominal = txtSelisihPajak.Value;
			instance.Total = txtSelisihTotal.Value;

			instance.Wilayah = instance.KoreksiInvoice.Wilayah;
			instance.Sales = instance.KoreksiInvoice.Sales;
			instance.Pemasang = instance.KoreksiInvoice.Pemasang;
			instance.TipeInvoice = instance.KoreksiInvoice.TipeInvoice;

			instance.NoOrder = instance.KoreksiInvoice.NoOrder + "-kor";
			instance.NoInvoice = instance.KoreksiInvoice.NoInvoice + "-kor";
			instance.InvoiceNama = instance.KoreksiInvoice.InvoiceNama;
			instance.InvoiceAlamat = instance.KoreksiInvoice.InvoiceAlamat;
			instance.InvoiceNPWP = instance.KoreksiInvoice.InvoiceNPWP;
			instance.InvoiceNIK = instance.KoreksiInvoice.InvoiceNIK;
			instance.InvoiceTtdNama = instance.KoreksiInvoice.InvoiceTtdNama;
			instance.InvoiceTtdJabatan = instance.KoreksiInvoice.InvoiceTtdJabatan;

			instance.OrderBayarVia = instance.KoreksiInvoice.OrderBayarVia;
			instance.OrderDp = instance.KoreksiInvoice.OrderDp;
			instance.OrderKeterangan = instance.KoreksiInvoice.OrderKeterangan;
			instance.OrderKontakPerson = instance.KoreksiInvoice.OrderKontakPerson;
			instance.OrderTanggalBayar = instance.KoreksiInvoice.OrderTanggalBayar;
			instance.OrderTtdNama = instance.KoreksiInvoice.OrderTtdNama;

			instance.WarnaBW = instance.KoreksiInvoice.WarnaBW;
			instance.Merk = instance.KoreksiInvoice.Merk;
			instance.UkuranX = instance.KoreksiInvoice.UkuranX;
			instance.UkuranY = instance.KoreksiInvoice.UkuranY;
			instance.Halaman = instance.KoreksiInvoice.Halaman;
			instance.JudulIklan = instance.KoreksiInvoice.JudulIklan;
			instance.MateriDeretBaris = instance.KoreksiInvoice.MateriDeretBaris;
			instance.MateriDeretLinear = instance.KoreksiInvoice.MateriDeretLinear;
			instance.JumlahBarisDeret = instance.KoreksiInvoice.JumlahBarisDeret;

			instance.HargaTermasukPajak = false;
			instance.Kurir = null;
			instance.TarifIklan = null;
			instance.CashbackPersen = 0;
			instance.CashbackNominal = 0;
			instance.PotonganKomisiNominal = 0;
			instance.KomisiPersen = 0;
			instance.KomisiNominal = 0;

			instance.TanggalMulai = default;
			instance.TanggalAkhir = default;
			instance.TanggalTerbitForSave = null;
			instance.SaldoAwal = false;

			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtNoInvoice.Focus(); break;
				case -2: txtTanggalKoreksi.Focus(); break;
				case -3: txtKeteranganKoreksi.Focus(); break;
				case -4: txtKoreksiBruto.Focus(); break;
			}
		}
	}
}
