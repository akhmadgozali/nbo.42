using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraLayout.Utils;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_IklanDialog : InputMDI {
		private readonly ETipeIklan _tipeIklan;
		private readonly bool _isReadOnly;
		private IklanSetting _settingIklan;
		private List<InvoiceTerbitForSave> _detailTerbit;
		private List<KeyValuePair<string, string>> listPemasang;
		private AutoCompleteStringCollection autoPemasang;
		private Invoice originalEdit;
		private bool _editJmlHari;
		private bool _editBruto;
		private bool _editDiskonP;
		private bool _editDiskonN;
		private bool _editCashbackP;
		private bool _editCashbackN;
		private bool _editKomisiP;
		private bool _editKomisiN;
		private bool _editAssign;

		internal UI_IklanDialog(ETipeIklan TipeIklan, bool IsReadOnly) {
			InitializeComponent();
			_tipeIklan = TipeIklan;
			_isReadOnly = IsReadOnly;
			groupDeret.Visibility = _tipeIklan == ETipeIklan.Deret ? LayoutVisibility.Always : LayoutVisibility.Never;
			groupKolom.Visibility = _tipeIklan == ETipeIklan.Kolom ? LayoutVisibility.Always : LayoutVisibility.Never;
			var printer = new System.Drawing.Printing.PrinterSettings();
			labelLayCetak.Text = printer?.PrinterName;

			txtWilayah.EditValueChanging += new ChangingEventHandler(WilayahChanging);
			txtTipeInvoice.EditValueChanging += new ChangingEventHandler(TipeInvoiceChanging);
			txtSales.EditValueChanged += new EventHandler(SalesChanged);
			txtPemasang.ButtonClick += new ButtonPressedEventHandler(PemasangButtonClick);
			txtPemasang.EditValueChanging += new ChangingEventHandler(PemasangChanging);
			txtTanggal.DateTimeChanged += new EventHandler(TanggalChanged);
			txtJatuhTempo.DateTimeChanged += new EventHandler(JatuhTempoChanged);
			txtInvoicePemasang.EditValueChanging += new ChangingEventHandler(InvoicePemasangChanging);
			txtKolomProduk.EditValueChanging += new ChangingEventHandler(KolomProdukChanging);
			txtDeretProduk.EditValueChanging += new ChangingEventHandler(DeretProdukChanging);
			txtTanggalMulai.EditValueChanging += new ChangingEventHandler(TanggalMulaiChanged);
			txtTanggalAkhir.EditValueChanging += new ChangingEventHandler(TanggalAkhirChanged);
			txtJmlHari.EditValueChanged += new EventHandler(JmlHariChanged);
			txtTarif.EditValueChanged += new EventHandler(TarifChanged);
			txtTarif.ButtonClick += new ButtonPressedEventHandler(TarifButtonClick);
			txtKolomX.EditValueChanged += new EventHandler(TotalChanged);
			txtKolomY.EditValueChanged += new EventHandler(TotalChanged);
			txtDeretJmlBaris.TextChanged += new EventHandler(TotalChanged);
			txtHargaTermasukPajak.CheckedChanged += new EventHandler(TotalChanged);
			txtDeretMateriLinier.TextChanged += new EventHandler(MateriLinierChanged);

			txtBruto.EditValueChanging += new ChangingEventHandler(BrutoChanging);
			txtDiskonPersen.EditValueChanging += new ChangingEventHandler(DiskonPersenChanging);
			txtDiskonNominal.EditValueChanging += new ChangingEventHandler(DiskonNominalChanging);
			txtPajakPersen.EditValueChanging += new ChangingEventHandler(PPnPersenChanging);
			txtCashbackPersen.EditValueChanging += new ChangingEventHandler(CashbackPersenChanging);
			txtCashbackNominal.EditValueChanging += new ChangingEventHandler(CashbackNominalChanging);
			txtPotonganKomisi.EditValueChanging += new ChangingEventHandler(PotonganKomisiChanging);
			txtKomisiPersen.EditValueChanging += new ChangingEventHandler(KomisiPersenChanging);
			txtKomisiNominal.EditValueChanging += new ChangingEventHandler(KomisiNominalChanging);
			xGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(GridCellValueChanged);
			colTanggal.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

			txtInvoicePemasang.EditValueChanged += new EventHandler(InvoicePemasangChanged);
		}

		private void InvoicePemasangChanged(object sender, EventArgs e) {
			if (!_editAssign) {
				var row = listPemasang.FindAll(f => f.Key == txtInvoicePemasang.Text);
				if (row.Count > 0) {
					txtInvoiceAlamat.Text = row[0].Value;
				}
				else {
					txtInvoiceAlamat.Text = txtWilayah.Text;
				}
			}
		}
		private void WilayahChanging(object sender, ChangingEventArgs e) {
			if (e.NewValue != null) {
				txtInvoiceTTdNama.Text = ((Wilayah)e.NewValue).KelompokOmzet.TtdNama;
				txtInvoiceTTdJabatan.Text = ((Wilayah)e.NewValue).KelompokOmzet.TtdJabatan;

				if (txtInvoiceAlamat.Enabled && (string.IsNullOrEmpty(txtInvoiceAlamat.Text) || (e.OldValue != null && txtInvoiceAlamat.Text == ((Wilayah)e.OldValue).Nama)))
					txtInvoiceAlamat.Text = ((Wilayah)e.NewValue).Nama;
			}

			ChangeNoBukti(txtTanggal.DateTime, e.NewValue, txtTipeInvoice.EditValue);
			SetJatuhTempo(txtTanggal.DateTime, e.NewValue, txtPemasang.EditValue);
		}
		private void SalesChanged(object sender, EventArgs e) {
			if (txtSales.EditValue != null) {
				var x = (Sales)txtSales.EditValue;
				txtKomisiPersen.Value = x.KomisiDefault;
			}
			SetTotal(null, null, null, null, null, null, null, null, null);
		}
		private void PemasangButtonClick(object sender, ButtonPressedEventArgs e) {
			if (e.Button.Kind == ButtonPredefines.Delete) txtPemasang.EditValue = null;
		}
		private void PemasangChanging(object sender, ChangingEventArgs e) {
			txtInvoicePemasang.Enabled = (e.NewValue == null);
			txtInvoiceAlamat.Enabled = (e.NewValue == null);
			txtInvoiceNPWP.Enabled = (e.NewValue == null);
			txtInvoiceNIK.Enabled = (e.NewValue == null);

			if (e.NewValue == null) {
				txtInvoicePemasang.Text = "";
				txtInvoiceAlamat.Text = txtWilayah.Text;
				txtInvoiceNPWP.Text = PPnKeluaranService.GetDefaultNPWP();
				txtInvoiceNIK.Enabled = (e.NewValue == null);
				txtDiskonPersen.Value = 0;
			}
			else {
				var pemasang = (Pemasang)e.NewValue;
				txtInvoicePemasang.Text = pemasang.Nama;
				txtInvoiceAlamat.Text = string.IsNullOrEmpty(pemasang.Alamat) ? txtWilayah.Text : pemasang.Alamat;
				txtInvoiceNPWP.Text = string.IsNullOrEmpty(pemasang.NPWP) ? PPnKeluaranService.GetDefaultNPWP() : pemasang.NPWP;
				txtInvoiceNIK.Text = pemasang.NIK;
				txtDiskonPersen.Value = pemasang.DiskonDefault;
			}
		}
		private void TipeInvoiceChanging(object sender, ChangingEventArgs e) {
			if (_editAssign) return;
			ChangeNoBukti(txtTanggal.DateTime, txtWilayah.EditValue, e.NewValue);

			if (Tipe == InputType.Edit && _settingIklan.FormatNomorInvoice.Contains(NomorService.KodeFormatTipeInvoice)) {
				if (e.NewValue != originalEdit.TipeInvoice) txtInvoiceNomor.Text = "";
				else txtInvoiceNomor.Text = originalEdit.NoInvoice;
			}
			if (Tipe == InputType.Edit && _settingIklan.FormatNomorOrder.Contains(NomorService.KodeFormatTipeInvoice)) {
				if (e.NewValue != originalEdit.TipeInvoice) txtOrderNomor.Text = "";
				else txtOrderNomor.Text = originalEdit.NoOrder;
			}
		}
		private void TanggalChanged(object sender, EventArgs e) {
			ChangeNoBukti(txtTanggal.DateTime, txtWilayah.EditValue, txtTipeInvoice.EditValue);
			SetJatuhTempo(txtTanggal.DateTime, txtWilayah.EditValue, txtPemasang.EditValue);
			txtTanggalInvoice.DateTime = txtTanggal.DateTime;

			if ((txtTanggalAkhir.DateTime == default || txtTanggalAkhir.DateTime <= txtTanggal.DateTime) && Tipe == InputType.Tambah) txtTanggalAkhir.DateTime = txtTanggal.DateTime.AddDays(1);
			if (txtTanggalMulai.DateTime == default) txtTanggalMulai.DateTime = txtTanggal.DateTime.AddDays(1);
			txtJatuhTempo.Properties.MinValue = txtTanggal.DateTime;
			txtOrderWaktuBayar.Properties.MinValue = txtTanggal.DateTime;
		}
		private void JatuhTempoChanged(object sender, EventArgs e) {
			txtOrderWaktuBayar.DateTime = txtJatuhTempo.DateTime;
		}
		private void InvoicePemasangChanging(object sender, ChangingEventArgs e) {
			if (Tipe == InputType.Tambah) txtOrderKontakPerson.Text = e.NewValue.ToString();
		}
		private void KolomProdukChanging(object sender, ChangingEventArgs e) {
			if (e.NewValue != null) {
				txtKolomMerk.Properties.DataSource = new XPQuery<Merk>(session).Where(w => w.Produk == e.NewValue).ToList();
				if (((List<Merk>)txtKolomMerk.Properties.DataSource).Count > 0) txtKolomMerk.EditValue = ((List<Merk>)txtKolomMerk.Properties.DataSource)[0];
			}
		}
		private void DeretProdukChanging(object sender, ChangingEventArgs e) {
			if (e.NewValue != null) {
				txtDeretMerk.Properties.DataSource = new XPQuery<Merk>(session).Where(w => w.Produk == e.NewValue).ToList();
				if (((List<Merk>)txtDeretMerk.Properties.DataSource).Count > 0) txtDeretMerk.EditValue = ((List<Merk>)txtDeretMerk.Properties.DataSource)[0];
			}
		}
		private void TanggalMulaiChanged(object sender, ChangingEventArgs e) {
			e.Cancel = !SetTanggalTerbit((DateTime)e.NewValue, txtTanggalAkhir.DateTime);
			if (!e.Cancel) {
				txtTanggalAkhir.Properties.MinValue = (DateTime)e.NewValue;
			}
		}
		private void TanggalAkhirChanged(object sender, ChangingEventArgs e) {
			e.Cancel = !SetTanggalTerbit(txtTanggalMulai.DateTime, (DateTime)e.NewValue);
		}
		private void JmlHariChanged(object sender, EventArgs e) {
			if (!_editJmlHari) txtTanggalAkhir.DateTime = txtTanggalMulai.DateTime.AddDays((int)txtJmlHari.Value - 1);
		}
		private void TarifButtonClick(object sender, ButtonPressedEventArgs e) {
			if (e.Button.Kind == ButtonPredefines.Delete) txtTarif.EditValue = null;
		}
		private void TarifChanged(object sender, EventArgs e) {
			txtBruto.Enabled = (txtTarif.EditValue == null);
			SetTotal(null, null, null, null, null, null, null, null, null);
		}
		private void TotalChanged(object sender, EventArgs e) {
			SetTotal(null, null, null, null, null, null, null, null, null);
		}
		private void BrutoChanging(object sender, ChangingEventArgs e) {
			if (!_editBruto) SetTotal(e.NewValue, null, null, null, null, null, null, null, null);
		}
		private void DiskonPersenChanging(object sender, ChangingEventArgs e) {
			if (!_editDiskonP) SetTotal(null, e.NewValue, null, null, null, null, null, null, null);
		}
		private void DiskonNominalChanging(object sender, ChangingEventArgs e) {
			if (!_editDiskonN) SetTotal(null, null, e.NewValue, null, null, null, null, null, null);
		}
		private void PPnPersenChanging(object sender, ChangingEventArgs e) {
			SetTotal(null, null, null, e.NewValue, null, null, null, null, null);
		}
		private void CashbackPersenChanging(object sender, ChangingEventArgs e) {
			if (!_editCashbackP) SetTotal(null, null, null, null, e.NewValue, null, null, null, null);
		}
		private void CashbackNominalChanging(object sender, ChangingEventArgs e) {
			if (!_editCashbackN) SetTotal(null, null, null, null, null, e.NewValue, null, null, null);
		}
		private void PotonganKomisiChanging(object sender, ChangingEventArgs e) {
			SetTotal(null, null, null, null, null, null, e.NewValue, null, null);
		}
		private void KomisiPersenChanging(object sender, ChangingEventArgs e) {
			if (!_editKomisiP) SetTotal(null, null, null, null, null, null, null, e.NewValue, null);
		}
		private void KomisiNominalChanging(object sender, ChangingEventArgs e) {
			if (!_editKomisiN) SetTotal(null, null, null, null, null, null, null, null, e.NewValue);
		}
		private void GridCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
			SetJumlahTerbit();
			SetTotal(null, null, null, null, null, null, null, null, null);
		}
		private void MateriLinierChanged(object sender, EventArgs e) {
			var str = txtDeretMateriLinier.Text;
			var chunkLength = _settingIklan.MaxKarakterDeret;
			var result = "";

			if (string.IsNullOrEmpty(str)) {
				txtDeretMateriBaris.Text = "";
				txtDeretJmlBaris.Text = "0";
				return;
			}
			if (chunkLength < 1) return;

			for (int i = 0; i < str.Length; i += chunkLength) {
				if (chunkLength + i > str.Length)
					chunkLength = str.Length - i;

				result += str.Substring(i, chunkLength) + "\r\n";
			}
			txtDeretMateriBaris.Text = result;
			string[] stringSeparators = new string[] { "\r\n" };
			txtDeretJmlBaris.Text = (result.Split(stringSeparators, StringSplitOptions.None).Count() - 1).ToString("n0");
		}
		private void SetJumlahTerbit() { txtJumlahTerbit.Text = "Jml. Terbit : " + _detailTerbit.Where(w => w.Aktif).Count(); }

		private void ChangeNoBukti(DateTime tanggal, object wilayah, object tipeInvoiceIklan) {
			if (wilayah == null || tipeInvoiceIklan == null) return;
			txtInvoiceNomor.Properties.Mask.MaskType = MaskType.Regular;
			txtInvoiceNomor.Properties.Mask.EditMask = NomorService.GetMaskNomorOrderInvoice(session, _settingIklan, tanggal, true, (Wilayah)wilayah, (TipeInvoice)tipeInvoiceIklan);
			txtOrderNomor.Properties.Mask.MaskType = MaskType.Regular;
			txtOrderNomor.Properties.Mask.EditMask = NomorService.GetMaskNomorOrderInvoice(session, _settingIklan, tanggal, false, (Wilayah)wilayah, (TipeInvoice)tipeInvoiceIklan);
		}
		private void SetJatuhTempo(DateTime tanggal, object wilayah, object pemasang) {
			if (tanggal == default(DateTime)) return;
			if (wilayah == null && pemasang == null) return;
			if (pemasang == null && wilayah != null) txtJatuhTempo.DateTime = tanggal.AddDays(((Wilayah)wilayah).JatuhTempo);
			else txtJatuhTempo.DateTime = tanggal.AddDays(((Pemasang)pemasang).JatuhTempoDefault);
		}
		private bool SetTanggalTerbit(DateTime tanggalMulai, DateTime tanggalAkhir) {
			if (_editAssign) return true;
			if (tanggalMulai == default) return true;
			if (tanggalAkhir == default) return true;
			if (tanggalMulai > tanggalAkhir) {
				MessageBox.Show("Tanggal mulai tidak boleh lebih besar dari tanggal akhir", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			var selisih = tanggalAkhir.Subtract(tanggalMulai).Days;
			_editJmlHari = true;
			txtJmlHari.EditValue = selisih + 1;
			_editJmlHari = false;

			//====== delete date before start
			_detailTerbit.RemoveAll(m => m.TanggalTerbit < tanggalMulai);
			//'====== delete date after end
			_detailTerbit.RemoveAll(m => m.TanggalTerbit > tanggalAkhir);

			for (int i = 0; i <= selisih; i++) {
				var tgl = tanggalMulai.AddDays(i);
				var item = _detailTerbit.Find(f => f.TanggalTerbit.Date == tgl.Date);
				if (item == null) {
					item = new InvoiceTerbitForSave() { Aktif = true, TanggalTerbit = tgl };
					_detailTerbit.Add(item);
				}
			}

			xGrid.DataSource = null;
			xGrid.DataSource = _detailTerbit;
			SetJumlahTerbit();
			SetTotal(null, null, null, null, null, null, null, null, null);
			return true;
		}
		private void SetTotal(object bruto, object diskonP, object diskonN, object ppnP, object cashbackP, object cashbackN, object potonganKomisi, object feeP, object feeN) {
			decimal _bruto, _diskonP, _diskonN, _netto, _ppnP, _ppnN, _total;
			decimal _cashbackP, _cashbackN, _potonganKomisi, _feeP, _feeN;

			if (_editAssign) return;

			// bruto
			if (txtTarif.EditValue != null) {
				var jmlTerbit = _detailTerbit.Where(w => w.Aktif).Count();
				var tarif = ((TarifIklan)txtTarif.EditValue).Tarif;

				if (_tipeIklan == ETipeIklan.Deret) {
					_bruto = tarif * jmlTerbit * int.Parse(txtDeretJmlBaris.Text);
				} else {
					_bruto = tarif * jmlTerbit * txtKolomX.Value * txtKolomY.Value;
				}
				_editBruto = true; txtBruto.Value = _bruto; _editBruto = false;
			}
			else _bruto = bruto == null ? txtBruto.Value : decimal.Parse(bruto.ToString());
			var brutoAsli = _bruto;

			// harga termasuk pajak
			_ppnP = ppnP == null ? txtPajakPersen.Value : decimal.Parse(ppnP.ToString().Replace(".", ","));
			if (txtHargaTermasukPajak.Checked) {
				_bruto = (_bruto / ((100 + _ppnP) / 100));
				if (txtTarif.EditValue != null) {
					_editBruto = true; txtBruto.Value = _bruto; _editBruto = false;
				}
			}

			// diskon
			if (diskonN == null) {
				_diskonP = diskonP == null ? txtDiskonPersen.Value : decimal.Parse(diskonP.ToString().Replace(".", ","));
				_diskonN = (_bruto * _diskonP) / 100;
				if (txtHargaTermasukPajak.Checked && _diskonP > 0) {
					var _hrg = brutoAsli - ((brutoAsli * _diskonP) / 100);
					var total = (_bruto - _diskonN) + (((_bruto - _diskonN) * _ppnP) / 100);
					if (total != _hrg) _diskonN += (total - _hrg);
				}
				_editDiskonN = true; txtDiskonNominal.Value = _diskonN; _editDiskonN = false;
			}
			else {
				_diskonN = decimal.Parse(diskonN.ToString());
				_diskonP = _bruto == 0 ? 0 : (_diskonN * 100) / _bruto;
				_editDiskonP = true; txtDiskonPersen.Value = _diskonP; _editDiskonP = false;
			}

			// netto
			_netto = _bruto - _diskonN;
			txtNetto.Text = _netto.ToString("n0");

			// ppn
			_ppnN = (_netto * _ppnP) / 100;
			txtPajakNominal.Text = _ppnN.ToString("n0");

			// total
			_total = _netto + _ppnN;
			txtTotal.Text = _total.ToString("n0");

			// cashback
			if (cashbackP == null) {
				_cashbackN = cashbackN == null ? txtCashbackNominal.Value : decimal.Parse(cashbackN.ToString());
				_cashbackP = _netto == 0 ? 0 : (_cashbackN * 100) / _netto;
				_editCashbackP = true; txtCashbackPersen.Value = _cashbackP; _editCashbackP = false;
			}
			else {
				_cashbackP = decimal.Parse(cashbackP.ToString().Replace(".", ","));
				_cashbackN = (_cashbackP * _netto) / 100;
				_editCashbackN = true; txtCashbackNominal.Value = _cashbackN; _editCashbackN = false;
			}

			// potongan komisi
			if (potonganKomisi == null) _potonganKomisi = txtPotonganKomisi.Value;
			else _potonganKomisi = decimal.Parse(potonganKomisi.ToString());

			// komisi
			decimal _dppKomisi = _netto - _cashbackN - _potonganKomisi;
			if (feeN == null) {
				_feeP = feeP == null ? txtKomisiPersen.Value : decimal.Parse(feeP.ToString().Replace(".", ","));
				_feeN = (_dppKomisi * _feeP) / 100;
				_editKomisiN = true; txtKomisiNominal.Value = _feeN; _editKomisiN = false;
			}
			else {
				_feeN = feeN == null ? txtKomisiNominal.Value : decimal.Parse(feeN.ToString());
				_feeP = _dppKomisi == 0 ? 0 : (_feeN * 100) / _dppKomisi;
				_editKomisiP = true; txtKomisiPersen.Value = _feeP; _editKomisiP = false;
			}
		}

		private void CheckDisableControl(Invoice obj) {
			bool disable;
			try { InvoiceService.CheckIsInUse(session, obj); disable = false; }
			catch { disable = true; }

			if (_isReadOnly) disable = true;

			if (disable) {
				txtWilayah.Enabled = false;
				txtSales.Enabled = false;
				txtPemasang.Enabled = false;
				txtTipeInvoice.Enabled = false;
				txtTanggal.Enabled = false;
				txtJatuhTempo.Enabled = false;
				txtTanggalInvoice.Enabled = false;

				txtOrderNomor.Enabled = false;
				txtOrderWaktuBayar.Enabled = false;
				txtOrderJenisBayar.Enabled = false;
				txtOrderDP.Enabled = false;
				txtOrderKontakPerson.Enabled = false;
				txtOrderKeterangan.Properties.ReadOnly = true;
				txtOrderTtd.Enabled = false;

				txtInvoiceNomor.Enabled = false;
				txtInvoicePemasang.Enabled = false;
				txtInvoiceAlamat.Enabled = false;
				txtInvoiceNPWP.Enabled = false;
				txtInvoiceNIK.Enabled = false;
				txtInvoiceTTdNama.Enabled = false;
				txtInvoiceTTdJabatan.Enabled = false;

				txtKolomIsBW.Enabled = false;
				txtKolomProduk.Enabled = false;
				txtKolomMerk.Enabled = false;
				txtKolomX.Enabled = false;
				txtKolomY.Enabled = false;
				txtKolomHalaman.Enabled = false;
				txtKolomJudul.Properties.ReadOnly = true;
				txtDeretIsBW.Enabled = false;
				txtDeretProduk.Enabled = false;
				txtDeretMerk.Enabled = false;
				txtDeretMateriLinier.Properties.ReadOnly = true;
				txtDeretMateriBaris.Properties.ReadOnly = true;
				txtDeretJmlBaris.Enabled = false;

				txtTarif.Enabled = false;
				txtHargaTermasukPajak.Enabled = false;
				txtBruto.Properties.ReadOnly = true;
				txtDiskonPersen.Properties.ReadOnly = true;
				txtDiskonNominal.Properties.ReadOnly = true;
				txtPajakPersen.Properties.ReadOnly = true;
				txtCashbackPersen.Properties.ReadOnly = true;
				txtCashbackNominal.Properties.ReadOnly = true;
				txtPotonganKomisi.Properties.ReadOnly = true;
				txtKomisiPersen.Properties.ReadOnly = true;
				txtKomisiNominal.Properties.ReadOnly = true;

				txtTanggalMulai.Enabled = false;
				txtJmlHari.Enabled = false;
				txtTanggalAkhir.Enabled = false;
				xGridView.OptionsBehavior.Editable = false;
				AllowSave = false;
			}
		}

		public override void LoadBeforeInitialize() {
			// auto complete pemasang
			var df = new XPQuery<Invoice>(session).Where(w => w.TipeInvoice.TipeIklan == _tipeIklan && w.Pemasang == null)
				.GroupBy(s => s.InvoiceNama).Select(f => new { Pemasang = f.Key, Alamat = f.Min(d => d.InvoiceAlamat) })
				.ToList();
			listPemasang = new List<KeyValuePair<string, string>>();
			foreach (var x in df) listPemasang.Add(new KeyValuePair<string, string>(x.Pemasang, x.Alamat));
			txtInvoicePemasang.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtInvoicePemasang.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

			_detailTerbit = new List<InvoiceTerbitForSave>();
			_settingIklan = new IklanSetting(session);
			txtInvoiceNPWP.Properties.Mask.MaskType = MaskType.Regular;
			txtInvoiceNPWP.Properties.Mask.EditMask = PPnKeluaranService.GetNPWPMask();
			//txtCetakInvoice.Checked = _settingIklan.DefaultCetakInvoice;
			//txtCetakOrder.Checked = _settingIklan.DefaultCetakOrder;
			txtOrderTtd.Text = Core.SSystem.UserInfo.GetUserName();
			txtPajakPersen.Value = _settingIklan.PajakPersenPPn;

			txtWilayah.Properties.DataSource = new XPQuery<Wilayah>(session).ToList();
			txtSales.Properties.DataSource = new XPQuery<Sales>(session).Where(w => w.Aktif).ToList();
			txtPemasang.Properties.DataSource = new XPQuery<Pemasang>(session).Where(w => w.Aktif).ToList();
			txtTipeInvoice.Properties.DataSource = new XPQuery<TipeInvoice>(session).Where(w => w.TipeIklan == _tipeIklan).ToList();
			txtKolomProduk.Properties.DataSource = new XPQuery<Produk>(session).ToList();
			txtDeretProduk.Properties.DataSource = new XPQuery<Produk>(session).ToList();
			txtTarif.Properties.DataSource = new XPQuery<TarifIklan>(session).Where(w => w.Aktif && w.TipeIklan == _tipeIklan).ToList();

			if (((List<Wilayah>)txtWilayah.Properties.DataSource).Count > 0) txtWilayah.EditValue = ((List<Wilayah>)txtWilayah.Properties.DataSource)[0];
			if (((List<Sales>)txtSales.Properties.DataSource).Count > 0) txtSales.EditValue = ((List<Sales>)txtSales.Properties.DataSource)[0];
			txtTanggal.DateTime = DateTime.Now;
			if (((List<Produk>)txtKolomProduk.Properties.DataSource).Count > 0) txtKolomProduk.EditValue = ((List<Produk>)txtKolomProduk.Properties.DataSource)[0];
			if (((List<Produk>)txtDeretProduk.Properties.DataSource).Count > 0) txtDeretProduk.EditValue = ((List<Produk>)txtDeretProduk.Properties.DataSource)[0];

			txtInvoicePemasang.Text = "";
			txtInvoiceAlamat.Text = txtWilayah.Text;
			txtInvoiceNPWP.Text = PPnKeluaranService.GetDefaultNPWP();
			txtDiskonPersen.Value = 0;
			txtJmlHari.Properties.MinValue = 1;
			txtJmlHari.Properties.MaxValue = 1000;
			_editAssign = true;
			if (((List<TipeInvoice>)txtTipeInvoice.Properties.DataSource).Count > 0) txtTipeInvoice.EditValue = ((List<TipeInvoice>)txtTipeInvoice.Properties.DataSource)[0];
			if (((List<TarifIklan>)txtTarif.Properties.DataSource).Count > 0) txtTarif.EditValue = ((List<TarifIklan>)txtTarif.Properties.DataSource)[0];
			_editAssign = false;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				_editAssign = true;
				Text = _tipeIklan == ETipeIklan.Kolom ? "Iklan Kolom : Tambah" : "Iklan Deret : Tambah";
				txtPemasang.EditValue = null;
				txtInvoiceNomor.Text = "";
				txtInvoicePemasang.Text = "";
				txtInvoiceAlamat.Text = txtWilayah.Text;
				txtInvoiceNPWP.Text = PPnKeluaranService.GetDefaultNPWP();
				txtOrderNomor.Text = "";
				txtOrderJenisBayar.Text = _settingIklan.CaraBayarOrder;
				txtOrderKeterangan.Text = _settingIklan.UraianOrder;
				txtKolomX.Value = 0;
				txtKolomY.Value = 0;
				txtKolomHalaman.Value = 0;
				txtKolomJudul.Text = "";
				txtDeretMateriLinier.Text = "";
				txtDeretJmlBaris.Text = "0";
				//txtTarif.EditValue = null;
				txtBruto.Value = 0;
				txtDiskonPersen.Value = 0;
				txtCashbackPersen.Value = 0;
				txtPotonganKomisi.Value = 0;
				txtKomisiPersen.Value = 0;
				txtKomisiNominal.Value = 0;
				_editAssign = false;
				ChangeNoBukti(txtTanggal.DateTime, txtWilayah.EditValue, txtTipeInvoice.EditValue);
				SetTotal(null, null, null, null, null, null, null, null, null);
			}
			else {
				originalEdit = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));

				_editAssign = true;
				_editJmlHari = true; _editBruto = true; _editDiskonP = true; _editDiskonN = true; _editCashbackP = true; _editCashbackN = true;
				var item = InvoiceService.GetItem(originalEdit);
				Text = (_tipeIklan == ETipeIklan.Kolom ? "Iklan Kolom : Edit - " : "Iklan Deret : Edit - ") + item.NoInvoice;
				txtWilayah.EditValue = item.Wilayah;
				txtSales.EditValue = item.Sales;
				txtPemasang.EditValue = item.Pemasang;
				txtTipeInvoice.EditValue = item.TipeInvoice;
				txtTanggal.DateTime = item.TanggalOmzet;
				txtJatuhTempo.DateTime = item.TanggalJatuhTempo;
				txtTanggalInvoice.DateTime = item.TanggalInvoice;

				txtOrderNomor.Text = item.NoOrder;
				txtOrderWaktuBayar.DateTime = item.OrderTanggalBayar;
				txtOrderJenisBayar.Text = item.OrderBayarVia;
				txtOrderDP.Value = item.OrderDp;
				txtOrderKontakPerson.Text = item.OrderKontakPerson;
				txtOrderKeterangan.Text = item.OrderKeterangan;
				txtOrderTtd.Text = item.OrderTtdNama;

				txtInvoiceNomor.Text = item.NoInvoice;
				txtInvoicePemasang.Text = item.InvoiceNama;
				txtInvoiceAlamat.Text = item.InvoiceAlamat;
				txtInvoiceNPWP.Text = item.InvoiceNPWP;
				txtInvoiceNIK.Text = item.InvoiceNIK;
				txtInvoiceTTdNama.Text = item.InvoiceTtdNama;
				txtInvoiceTTdJabatan.Text = item.InvoiceTtdJabatan;

				if (item.TipeInvoice.TipeIklan == ETipeIklan.Kolom) {
					txtKolomIsBW.Checked = item.WarnaBW;
					txtKolomProduk.EditValue = item.Merk?.Produk;
					txtKolomMerk.EditValue = item.Merk;
					txtKolomX.Value = (decimal)item.UkuranX;
					txtKolomY.Value = (decimal)item.UkuranY;
					txtKolomHalaman.Value = item.Halaman;
					txtKolomJudul.Text = item.JudulIklan;
				}
				else {
					txtDeretIsBW.Checked = item.WarnaBW;
					txtDeretProduk.EditValue = item.Merk?.Produk;
					txtDeretMerk.EditValue = item.Merk;
					txtDeretMateriLinier.Text = item.MateriDeretLinear;
					txtDeretMateriBaris.Text = item.MateriDeretBaris;
					txtDeretJmlBaris.Text = item.JumlahBarisDeret.ToString("n0");
				}

				txtTanggalAkhir.DateTime = item.TanggalAkhir;
				txtTanggalMulai.DateTime = item.TanggalMulai;

				txtTarif.EditValue = item.TarifIklan;
				txtHargaTermasukPajak.Checked = item.HargaTermasukPajak;
				if (item.HargaTermasukPajak) txtBruto.Value = item.Netto + item.PajakNominal + item.DiskonNominal;
				else txtBruto.Value = item.Bruto;
				txtDiskonPersen.Value = item.DiskonPersen;
				txtDiskonNominal.Value = item.DiskonNominal;
				txtNetto.Value = item.Netto;
				txtPajakPersen.Value = item.PajakPersen;
				txtPajakNominal.Value = item.PajakNominal;
				txtTotal.Value = item.Total;
				txtCashbackPersen.Value = item.CashbackPersen;
				txtCashbackNominal.Value = item.CashbackNominal;
				txtPotonganKomisi.Value = item.PotonganKomisiNominal;
				txtKomisiPersen.Value = item.KomisiPersen;
				txtKomisiNominal.EditValue = item.KomisiNominal;

				_detailTerbit = item.TanggalTerbitForSave;
				_editJmlHari = false; _editBruto = false; _editDiskonP = false; _editDiskonN = false; _editCashbackP = false; _editCashbackN = false;
				SetTanggalTerbit(item.TanggalMulai, item.TanggalAkhir);

				CheckDisableControl(item);
				_editAssign = false;
			}

			xGrid.DataSource = _detailTerbit;
			txtWilayah.Focus();
			SetJumlahTerbit();

			// auto complete
			autoPemasang = new AutoCompleteStringCollection();
			autoPemasang.AddRange(listPemasang.Select(s => s.Key).ToArray());
			txtInvoicePemasang.MaskBox.AutoCompleteCustomSource = autoPemasang;
		}
		public override void SimpanData() {
			Invoice instance;
			if (Tipe == InputType.Tambah) instance = new Invoice(session);
			else instance = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));
			var service = new InvoiceService(session, originalEdit);

			instance.Wilayah = txtWilayah.EditValue == null ? null : (Wilayah)txtWilayah.EditValue;
			instance.Sales = txtSales.EditValue == null ? null : (Sales)txtSales.EditValue;
			instance.Pemasang = txtPemasang.EditValue == null ? null : (Pemasang)txtPemasang.EditValue;
			instance.TipeInvoice = txtTipeInvoice.EditValue == null ? null : (TipeInvoice)txtTipeInvoice.EditValue;
			instance.TanggalOmzet = txtTanggal.DateTime;
			instance.TanggalInvoice = txtTanggalInvoice.DateTime;
			instance.TanggalJatuhTempo = txtJatuhTempo.DateTime;

			instance.NoOrder = txtOrderNomor.Text;
			instance.OrderTanggalBayar = txtOrderWaktuBayar.DateTime;
			instance.OrderBayarVia = txtOrderJenisBayar.Text;
			instance.OrderDp = txtOrderDP.Value;
			instance.OrderKontakPerson = txtOrderKontakPerson.Text;
			instance.OrderKeterangan = txtOrderKeterangan.Text;
			instance.OrderTtdNama = txtOrderTtd.Text;

			instance.NoInvoice = txtInvoiceNomor.Text;
			instance.InvoiceNama = txtInvoicePemasang.Text;
			instance.InvoiceAlamat = txtInvoiceAlamat.Text;
			instance.InvoiceNPWP = txtInvoiceNPWP.Text;
			instance.InvoiceNIK = txtInvoiceNIK.Text;
			instance.InvoiceTtdNama = txtInvoiceTTdNama.Text;
			instance.InvoiceTtdJabatan = txtInvoiceTTdJabatan.Text;

			if (_tipeIklan == ETipeIklan.Kolom) {
				instance.WarnaBW = txtKolomIsBW.Checked;
				instance.Merk = txtKolomMerk.EditValue == null ? null : (Merk)txtKolomMerk.EditValue;
				instance.UkuranX = txtKolomX.Value;
				instance.UkuranY = txtKolomY.Value;
				instance.Halaman = (int)txtKolomHalaman.Value;
				instance.JudulIklan = txtKolomJudul.Text;
			}
			else {
				instance.WarnaBW = txtDeretIsBW.Checked;
				instance.Merk = txtDeretMerk.EditValue == null ? null : (Merk)txtDeretMerk.EditValue;
				instance.MateriDeretLinear = txtDeretMateriLinier.Text;
				instance.MateriDeretBaris = txtDeretMateriBaris.Text;
				instance.JumlahBarisDeret = int.Parse(txtDeretJmlBaris.Text);
			}

			instance.TanggalMulai = txtTanggalMulai.DateTime;
			instance.TanggalAkhir = txtTanggalAkhir.DateTime;

			var brut = decimal.Parse(txtNetto.Text) + txtDiskonNominal.Value;
			instance.TarifIklan = txtTarif.EditValue == null ? null : (TarifIklan)txtTarif.EditValue;
			instance.HargaIklan = txtTarif.EditValue == null ? brut : ((TarifIklan)txtTarif.EditValue).Tarif;
			instance.HargaTermasukPajak = txtHargaTermasukPajak.Checked;
			instance.Bruto = brut;
			instance.DiskonPersen = txtDiskonPersen.Value;
			instance.DiskonNominal = txtDiskonNominal.Value;
			instance.Netto = txtNetto.Value;
			instance.PajakPersen = txtPajakPersen.Value;
			instance.PajakNominal = txtPajakNominal.Value;
			instance.Total = txtTotal.Value;
			instance.CashbackPersen = txtCashbackPersen.Value;
			instance.CashbackNominal = txtCashbackNominal.Value;
			instance.PotonganKomisiNominal = txtPotonganKomisi.Value;
			instance.KomisiPersen = txtKomisiPersen.Value;
			instance.KomisiNominal = txtKomisiNominal.Value;

			instance.TanggalTerbitForSave = _detailTerbit;
			if (service.Save(instance)) {
				MessageBox.Show(string.Format("Invoice '{0}' berhasil disimpan.", instance.NoInvoice), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
				//if (txtCetakInvoice.Checked)
				//	((UI_Iklan)BaseForm).CetakInvoice(item.NomorInvoice);
				//if (txtCetakOrder.Checked)
				//	((UI_Iklan)BaseForm).CetakOrder(item.NomorOrder);

				if (txtCetakInvoice.Checked) {
					var reportCode = _tipeIklan == ETipeIklan.Kolom ? MainClass.ReportCodeTransaksiInvoiceKolom : MainClass.ReportCodeTransaksiInvoiceDeret;
					var frm = new UI_FilterInvoice(reportCode);
					frm.txtInvoice1.Text = instance.NoInvoice;
					var message = "Apakah anda ingin mencetak invoice dengan nomor '" + instance.NoInvoice + "' ?";
					Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, string.Empty, false);
				}
				if (txtCetakOrder.Checked) {
					var reportCode = MainClass.ReportCodeTransaksiOrderIklan;
					var frm = new UI_FilterInvoice(reportCode);
					frm.txtOrder1.Text = instance.NoOrder;
					var message = "Apakah anda ingin mencetak order dengan nomor '" + instance.NoOrder + "' ?";
					Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, string.Empty, false);
				}
			};

			//tambah auto pemasang
			if (instance.Pemasang == null) {
				var x = listPemasang.FindAll(f => f.Key == instance.InvoiceNama);
				if (x.Count <= 0) listPemasang.Add(new KeyValuePair<string, string>(instance.InvoiceNama, instance.InvoiceAlamat));
			}
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggal.Focus(); break;
				case -2: txtTanggalInvoice.Focus(); break;
				case -3: txtJatuhTempo.Focus(); break;
				case -4: txtWilayah.Focus(); break;
				case -5: txtSales.Focus(); break;
				case -6: txtTipeInvoice.Focus(); break;
				case -7: txtPemasang.Focus(); break;
				case -8: txtInvoiceAlamat.Focus(); break;
				case -9: txtInvoiceNPWP.Focus(); break;
				case -12: txtTanggalMulai.Focus(); break;
				case -13: txtTanggalAkhir.Focus(); break;
				case -14: txtKolomX.Focus(); break;
				case -15: txtKolomY.Focus(); break;
				case -16: txtKolomHalaman.Focus(); break;
				case -17: txtKolomJudul.Focus(); break;
				case -18: 
				case -19: txtDeretMateriLinier.Focus(); break;
				case -98: txtOrderNomor.Focus(); break;
				case -99: txtInvoiceNomor.Focus(); break;
			}
		}
	}
}