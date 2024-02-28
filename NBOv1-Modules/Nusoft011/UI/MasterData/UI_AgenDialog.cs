using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.MasterData {
	public partial class UI_AgenDialog : InputDialog {
		public UI_AgenDialog() {
			InitializeComponent();
			txtKode.EditValueChanging += new ChangingEventHandler(KodeValueChanging);
			txtOrderTetap.CheckedChanged += new EventHandler(OrderTetapCheckedChanged);
		}
		private List<AgenOrderTetapForSave> orderTetapSources;
		private Agen originalEdit;

		private void KodeValueChanging(object sender, ChangingEventArgs e) {
			if (string.IsNullOrEmpty(txtKodePelanggan.Text) || txtKodePelanggan.EditValue == e.OldValue) txtKodePelanggan.EditValue = e.NewValue;
		}
		private void OrderTetapCheckedChanged(object sender, EventArgs e) {
			xGridViewOrderTetap.OptionsBehavior.Editable = txtOrderTetap.Checked;
			xGridOrderTetap.Enabled = txtOrderTetap.Checked;
		}

		public override void LoadBeforeInitialize() {
			txtNPWP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
			txtNPWP.Properties.Mask.EditMask = PPnKeluaranService.GetNPWPMask();

			txtRute.Properties.DataSource = new XPCollection<Rute>(session);
			txtRute.EditValue = ((XPCollection<Rute>)txtRute.Properties.DataSource)[0];
			txtHargaJatah.Value = 0;
			txtHargaKonsi.Value = 0;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Agen : Tambah";
				txtKode.Text = ""; 
				txtNama.Text = ""; 
				txtAktif.Checked = true;
				txtAlamat.Text = "";
				txtKodePelanggan.Text = "";
				txtHargaPelanggan.Value = 0;
				txtKeterangan.Text = "";
				txtNPWP.Text = PPnKeluaranService.GetDefaultNPWP();
				txtNIK.Text = ""; 
				txtNoHP1.Text = ""; 
				txtNoHP2.Text = ""; 
				txtNoTelp.Text = "";
				txtNoFax.Text = "";
				txtEmail.Text = "";
				txtOrderTetap.Checked = true;
				txtOrderTetap.Checked = false;
				orderTetapSources = AgenService.GetNewOrderTetapData();
			}
			else {
				originalEdit = AgenService.GetItem(session.GetObjectByKey<Agen>(Convert.ToInt32(IdToEdit)));
				Text = "Agen : Edit - " + originalEdit.Kode;
				txtRute.EditValue = originalEdit.Rute;
				txtKode.Text = originalEdit.Kode;
				txtNama.Text = originalEdit.Nama;
				txtAktif.Checked = originalEdit.Aktif;
				txtHargaJatah.EditValue = originalEdit.HargaJatah;
				txtHargaKonsi.EditValue = originalEdit.HargaKonsi;
				txtAlamat.Text = originalEdit.Alamat;
				txtKodePelanggan.Text = originalEdit.KodePelanggan;
				txtHargaPelanggan.EditValue = originalEdit.HargaLangganan;
				txtKeterangan.Text = originalEdit.Keterangan;
				txtNPWP.Text = originalEdit.NPWP;
				txtNIK.Text = originalEdit.NIK;
				txtNoTelp.Text = originalEdit.NoTelpon;
				txtNoHP1.Text = originalEdit.NoHP1;
				txtNoHP2.Text = originalEdit.NoHP2;
				txtNoFax.Text = originalEdit.NoFax;
				txtEmail.Text = originalEdit.Email;
				txtOrderTetap.Checked = !originalEdit.OrderTetap;
				txtOrderTetap.Checked = originalEdit.OrderTetap;
				orderTetapSources = originalEdit.DetailOrderTetapForSave;
			}
			txtRute.Focus();
			xGridOrderTetap.DataSource = orderTetapSources;
		}

		public override void SimpanData() {
			Agen instance;
			if (Tipe == InputType.Tambah) instance = new Agen(session);
			else instance = session.GetObjectByKey<Agen>(Convert.ToInt32(IdToEdit));
			var service = new AgenService(session, originalEdit);
			instance.Rute = txtRute.EditValue == null ? null : (Rute)txtRute.EditValue;
			instance.Kode = txtKode.Text;
			instance.Nama = txtNama.Text;
			instance.Aktif = txtAktif.Checked;
			instance.HargaJatah = (double)txtHargaJatah.Value;
			instance.HargaKonsi = (double)txtHargaKonsi.Value;
			instance.Alamat = txtAlamat.Text;
			instance.KodePelanggan = txtKodePelanggan.Text;
			instance.HargaLangganan = (double)txtHargaPelanggan.Value;
			instance.Keterangan = txtKeterangan.Text;
			instance.NPWP = txtNPWP.Text;
			instance.NIK = txtNIK.Text;
			instance.NoTelpon = txtNoTelp.Text;
			instance.NoHP1 = txtNoHP1.Text;
			instance.NoHP2 = txtNoHP2.Text;
			instance.NoFax = txtNoFax.Text;
			instance.Email = txtEmail.Text;
			instance.OrderTetap = txtOrderTetap.Checked;
			instance.DetailOrderTetapForSave = orderTetapSources;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtRute.Focus(); break;
				case -2: txtKode.Focus(); break;
				case -3: txtNama.Focus(); break;
				case -4: txtKodePelanggan.Focus(); break;
				case -5: txtNPWP.Focus(); break;
			}
		}
	}
}
