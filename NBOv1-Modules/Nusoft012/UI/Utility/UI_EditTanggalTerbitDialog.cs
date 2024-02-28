using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Utility {
	public partial class UI_EditTanggalTerbitDialog : InputDialog {
		public UI_EditTanggalTerbitDialog() {
			InitializeComponent();
			txtTanggalMulai.EditValueChanging += new ChangingEventHandler(TanggalMulaiChanged);
			txtTanggalAkhir.EditValueChanging += new ChangingEventHandler(TanggalAkhirChanged);
			txtJmlHari.EditValueChanged += new EventHandler(JmlHariChanged);
			txtLinear.TextChanged += new EventHandler(MateriLinierChanged);
			xGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(GridCellValueChanged);
			txtTipeInvoice.EditValueChanging += new ChangingEventHandler(TipeInvoiceChanging);
			txtWilayah.EditValueChanging += new ChangingEventHandler(WilayahChanging);
			AutoCloseOnSave = true;
		}

		private List<InvoiceTerbitForSave> _detailTerbit;
		private bool _editJmlHari;
		private bool _editAssign;
		private bool _updateGl;
		private bool _editTanggal;
		private IklanSetting setting;
		private Invoice originalEdit;

		private void MateriLinierChanged(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(txtLinear.Text)) {
				txtDeret.Text = "";
				return;
			}

			txtDeret.Text = InvoiceService.SetMateriBaris(txtLinear.Text, setting.MaxKarakterDeret);
		}

		private void TanggalMulaiChanged(object sender, ChangingEventArgs e) {
			if (_editAssign) return;
			e.Cancel = !SetTanggalTerbit((DateTime)e.NewValue, txtTanggalAkhir.DateTime);
			if (!e.Cancel) {
				txtTanggalAkhir.Properties.MinValue = (DateTime)e.NewValue;
			}
		}
		private void TanggalAkhirChanged(object sender, ChangingEventArgs e) {
			if (_editAssign) return;
			e.Cancel = !SetTanggalTerbit(txtTanggalMulai.DateTime, (DateTime)e.NewValue);
			if (!e.Cancel) {
				txtTanggalMulai.Properties.MaxValue = (DateTime)e.NewValue;
			}
		}
		private void JmlHariChanged(object sender, EventArgs e) {
			if (_editAssign) return;
			if (!_editJmlHari) txtTanggalAkhir.DateTime = txtTanggalMulai.DateTime.AddDays((int)txtJmlHari.Value - 1);
		}
		private bool SetTanggalTerbit(DateTime tanggalMulai, DateTime tanggalAkhir) {
			if (tanggalMulai == default(DateTime)) return true;
			if (tanggalAkhir == default(DateTime)) return true;
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
					item = new InvoiceTerbitForSave() { Aktif = colAktif.OptionsColumn.ReadOnly ? false : true, TanggalTerbit = tgl };
					_detailTerbit.Add(item);
				}
			}

			xGrid.DataSource = null;
			xGrid.DataSource = _detailTerbit;
			SetJumlahTerbit();
			return true;
		}
		private void SetJumlahTerbit() { txtJmlTerbit.Text = "Jml. Terbit : " + _detailTerbit.Where(w => w.Aktif).Count(); }
		private void GridCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
			SetJumlahTerbit();
			if (e.Column == colTanggal) _editTanggal = true;
		}

		private void TipeInvoiceChanging(object sender, ChangingEventArgs e) {
			if (_editAssign) return;
			if (setting.FormatNomorInvoice.Contains(NomorService.KodeFormatTipeInvoice) && e.OldValue != null) {
				var itemJenisIklan = (TipeInvoice)e.NewValue;

				if (originalEdit.TipeInvoice == itemJenisIklan) {
					txtNoInvoice.Text = originalEdit.NoInvoice;
					_updateGl = false;
				}
				else {
					if (MessageBox.Show("Mengganti tipe invoice berakibat mengganti nomor invoice.\r\nApakah anda ingin meneruskan ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
						txtNoInvoice.Text = "";
						_updateGl = true;
					}
					else e.Cancel = true;
				}
			}
		}
		private void WilayahChanging(object sender, ChangingEventArgs e) {
			if (_editAssign) return;

			if (setting.FormatNomorInvoice.Contains(NomorService.KodeFormatWilayah) && e.OldValue != null) {
				var itemWilayah = (Wilayah)e.NewValue;

				if (originalEdit.Wilayah == itemWilayah) {
					txtNoInvoice.Text = originalEdit.NoInvoice;
					_updateGl = false;
					if (txtAlamat.Enabled && (string.IsNullOrEmpty(txtAlamat.Text) || (e.OldValue != null && txtAlamat.Text == ((Wilayah)e.OldValue).Nama)))
						txtAlamat.Text = ((Wilayah)e.NewValue).Nama;
				}
				else {
					if (MessageBox.Show("Mengganti wilayah berakibat mengganti nomor invoice.\r\nApakah anda ingin meneruskan ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
						txtNoInvoice.Text = "";
						_updateGl = true;
						if (txtAlamat.Enabled && (string.IsNullOrEmpty(txtAlamat.Text) || (e.OldValue != null && txtAlamat.Text == ((Wilayah)e.OldValue).Nama)))
							txtAlamat.Text = ((Wilayah)e.NewValue).Nama;
					}
					else e.Cancel = true;
				}
			}
		}

		private void CheckDisableControl(Invoice obj) {
			try { CheckFaktur(obj); }
			catch {
				txtNoInvoice.Enabled = false;
				txtNoOrder.Enabled = false;
				txtTanggal.Enabled = false;
				txtSales.Enabled = true;
				txtPemasang.Enabled = false;
				txtJudul.Enabled = false;
				txtAlamat.Enabled = false;
				txtTglInvoice.Enabled = false;
				txtJatuhTempo.Enabled = false;
				txtNPWP.Enabled = false;
				txtNIK.Enabled = false;

				txtTanggalMulai.Enabled = false;
				txtTanggalAkhir.Enabled = false;
				txtJmlHari.Enabled = false;
				txtKeterangan.Enabled = false;

				xGridView.OptionsBehavior.Editable = false;
			}

			try { CheckPeriode(obj); }
			catch {
				txtNoInvoice.Enabled = false;
				txtNoOrder.Enabled = false;
				txtTanggal.Enabled = false;
				txtWilayah.Enabled = false;
				txtTipeInvoice.Enabled = false;
				txtSales.Enabled = false;
				txtJatuhTempo.Enabled = false;
			}

			try { CheckPembayaran(obj); }
			catch {
				txtNoInvoice.Enabled = false;
				txtNoOrder.Enabled = false;
				txtTanggal.Enabled = false;
				txtWilayah.Enabled = false;
				txtTipeInvoice.Enabled = false;
				txtSales.Enabled = false;
				txtTglInvoice.Enabled = false;
				txtJatuhTempo.Enabled = false;
				txtCashback.Enabled = false;
				txtKontakPerson.Enabled = false;

				txtTanggalMulai.Enabled = false;
				txtTanggalAkhir.Enabled = false;
				txtJmlHari.Enabled = false;
				txtNPWP.Enabled = false;
				txtNIK.Enabled = false;
			}

			if (obj.TarifIklan == null) {
				txtTanggalMulai.Enabled = true;
				txtTanggalAkhir.Enabled = true;
				txtJmlHari.Enabled = true;
				xGridView.OptionsBehavior.Editable = true;
			}
			else {
				txtTanggalMulai.Enabled = false;
				txtTanggalAkhir.Enabled = false;
				txtJmlHari.Enabled = false;
				xGridView.OptionsBehavior.Editable = true;
				colAktif.OptionsColumn.AllowEdit = false;
				colAktif.OptionsColumn.ReadOnly = true;
				colTanggal.OptionsColumn.AllowEdit = true;
				colTanggal.OptionsColumn.ReadOnly = false;
			}
		}
		private void CheckFaktur(Invoice obj) {
			if (obj.TaxId != null && obj.TaxId.StatusFaktur != EFakturStatus.Edit)
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena faktur pajak nya sudah di proses.", obj.NoInvoice), -1);
		}
		private void CheckPembayaran(Invoice obj) {
			if (session.FindObject<PembayaranIklanDetail>(new BinaryOperator(nameof(PembayaranIklanDetail.Invoice), obj, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena sudah di bayar.", obj.NoInvoice), -1);
		}
		private void CheckPeriode(Invoice obj) {
			if (IntegrasiService.CekPeriodeTutupBuku(session, obj.TanggalOmzet))
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena sudah di tutup periode nya.", obj.NoInvoice), -1);
		}

		public override void LoadBeforeInitialize() {
			setting = new IklanSetting(session);
			txtWilayah.Properties.DataSource = new XPQuery<Wilayah>(session);
			txtSales.Properties.DataSource = new XPQuery<Sales>(session).Where(w => w.Aktif).ToList();
			txtNPWP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
			txtNPWP.Properties.Mask.EditMask = PPnKeluaranService.GetNPWPMask();
		}
		public override void InitializeData() {
			Text = "Edit Detail Iklan";
			if (Tipe == InputType.Edit) {
				originalEdit = session.GetObjectByKey<Invoice>(Convert.ToInt64(IdToEdit));
				_editAssign = true;
				_editJmlHari = true;
				_detailTerbit = new List<InvoiceTerbitForSave>();

				txtTipeInvoice.Properties.DataSource = new XPQuery<TipeInvoice>(session).Where(w => w.TipeIklan == originalEdit.TipeInvoice.TipeIklan);

				txtNoInvoice.Text = originalEdit.NoInvoice;
				txtNoOrder.Text = originalEdit.NoOrder;
				txtTanggal.Text = originalEdit.TanggalOmzet.ToString("dd MMMM yyyy");
				txtWilayah.EditValue = originalEdit.Wilayah;
				txtTipeInvoice.EditValue = originalEdit.TipeInvoice;
				txtSales.EditValue = originalEdit.Sales;
				txtPemasang.Text = originalEdit.InvoiceNama;
				txtKontakPerson.Text = originalEdit.OrderKontakPerson;
				txtJudul.Text = originalEdit.JudulIklan;
				txtAlamat.Text = originalEdit.InvoiceAlamat;
				txtTglInvoice.DateTime = originalEdit.TanggalInvoice;
				txtJatuhTempo.DateTime = originalEdit.TanggalJatuhTempo;
				txtNPWP.Text = originalEdit.InvoiceNPWP;
				txtNIK.Text = originalEdit.InvoiceNIK;
				txtCashback.Value = originalEdit.CashbackNominal;
				if (originalEdit.TipeInvoice.TipeIklan == ETipeIklan.Deret) {
					layDeret.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
					layJudul.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					txtLinear.Text = originalEdit.MateriDeretLinear;
					txtDeret.Text = originalEdit.MateriDeretBaris;
				}
				else {
					layDeret.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					layJudul.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
				}

				txtTanggalMulai.DateTime = originalEdit.TanggalMulai;
				txtTanggalAkhir.DateTime = originalEdit.TanggalAkhir;
				var selisih = originalEdit.TanggalAkhir.Subtract(originalEdit.TanggalMulai).Days;
				txtJmlHari.Value = selisih + 1;

				for (var i = 0; i <= selisih; i++) {
					var d = new InvoiceTerbitForSave() { TanggalTerbit = originalEdit.TanggalMulai.AddDays(i) };
					var exist = originalEdit.DaftarTerbit.ToList().Find(f => f.TanggalTerbit == d.TanggalTerbit);
					if (exist != null) {
						d.Id = exist.Id;
						d.Aktif = exist.Aktif;
						d.Keterangan = exist.Keterangan;
					}
					_detailTerbit.Add(d);
				}

				txtKeterangan.Text = originalEdit.OrderKeterangan;
				xGrid.DataSource = _detailTerbit;
				_editJmlHari = false;
				_editAssign = false;
				_updateGl = false;
				_editTanggal = false;
				SetJumlahTerbit();
				CheckDisableControl(originalEdit);
			}
		}
		public override void SimpanData() {
			if (Tipe == InputType.Edit) {
				originalEdit.TanggalMulai = txtTanggalMulai.DateTime;
				originalEdit.TanggalAkhir = txtTanggalAkhir.DateTime;
				if (originalEdit.TipeInvoice.TipeIklan == ETipeIklan.Kolom) originalEdit.JudulIklan = txtJudul.Text;
				else {
					originalEdit.MateriDeretLinear = txtLinear.Text;
					originalEdit.MateriDeretBaris = txtDeret.Text;
				}

				if (_editTanggal && originalEdit.TarifIklan != null) {
					originalEdit.TanggalMulai = _detailTerbit.OrderBy(o => o.TanggalTerbit).ToList()[0].TanggalTerbit;
					originalEdit.TanggalAkhir = _detailTerbit.OrderByDescending(o => o.TanggalTerbit).ToList()[0].TanggalTerbit;
				}

				originalEdit.OrderKeterangan = txtKeterangan.Text;
				originalEdit.OrderKontakPerson = txtKontakPerson.Text;
				originalEdit.NoInvoice = txtNoInvoice.Text;
				originalEdit.InvoiceKeterangan = originalEdit.TipeInvoice.TipeIklan == ETipeIklan.Kolom ? txtJudul.Text : txtLinear.Text;
				originalEdit.InvoiceNama = txtPemasang.Text;
				originalEdit.InvoiceAlamat = txtAlamat.Text;
				originalEdit.TanggalInvoice = txtTglInvoice.DateTime;
				originalEdit.TanggalJatuhTempo = txtJatuhTempo.DateTime;
				originalEdit.InvoiceNPWP = txtNPWP.Text;
				originalEdit.InvoiceNIK = txtNIK.Text;
				originalEdit.CashbackNominal = txtCashback.Value;
				originalEdit.Wilayah = (Wilayah)txtWilayah.EditValue;
				originalEdit.TipeInvoice = (TipeInvoice)txtTipeInvoice.EditValue;
				originalEdit.Sales = (Sales)txtSales.EditValue;

				InvoiceService.SaveEditTanggalTerbit(session, originalEdit, _detailTerbit, _updateGl);
			}
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
		}
	}
}