using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_PelangganDialog : InputDialog {
		public UI_PelangganDialog() {
			InitializeComponent();
			txtAgen.EditValueChanging += new ChangingEventHandler(AgenChanging);
			txtPropinsi.EditValueChanging += new ChangingEventHandler(PropinsiChanging);
			txtKabupaten.EditValueChanging += new ChangingEventHandler(KabupatenChanging);
			txtKecamatan.EditValueChanging += new ChangingEventHandler(KecamatanChanging);
			AutoCloseOnSave = true;
		}
		private Pelanggan originalEdit;

		private void AgenChanging(object sender, ChangingEventArgs e) {
			if (e.NewValue != null && Tipe == InputType.Tambah) {
				SetMaskNomor(((Agen)e.NewValue).KodePelanggan);
				txtHargaLangganan.EditValue = ((Agen)e.NewValue).HargaLangganan;
			}
		}
		private void PropinsiChanging(object sender, ChangingEventArgs e) {
			txtKabupaten.EditValue = null;
			if (e.NewValue != null) txtKabupaten.Properties.DataSource = new XPQuery<Kabupaten>(session).Where(w => w.Propinsi == e.NewValue).ToList();
		}
		private void KabupatenChanging(object sender, ChangingEventArgs e) {
			txtKecamatan.EditValue = null;
			if (e.NewValue != null) txtKecamatan.Properties.DataSource = new XPQuery<Kecamatan>(session).Where(w => w.Kabupaten == e.NewValue).ToList();
		}
		private void KecamatanChanging(object sender, ChangingEventArgs e) {
			txtKelurahan.EditValue = null;
			if (e.NewValue != null) txtKelurahan.Properties.DataSource = new XPQuery<Kelurahan>(session).Where(w => w.Kecamatan == e.NewValue).ToList();
		}
		private void SetMaskNomor(string mask) {
			txtNomor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
			txtNomor.Properties.Mask.EditMask = mask + @"-\d\d\d\d\d";
			txtNomor.Properties.Mask.UseMaskAsDisplayFormat = true;
			txtNomor.Text = mask + "-" + PelangganService.GetNomor(session, mask).ToString("00000");
		}
		private void DisableControl() {
			EnableVisibleSaveButton(false, true);

			txtAgen.Enabled = false;
			txtTanggalMasuk.Enabled = false;
			txtHargaLangganan.Enabled = false;
			txtPropinsi.Enabled = false;
			txtKabupaten.Enabled = false;
			txtKecamatan.Enabled = false;
			txtKelurahan.Enabled = false;
			txtAlamat.Enabled = false;
			txtNomor.Enabled = false;
			txtNama.Enabled = false;
			txtNoKTP.Enabled = false;
			txtTempatLahir.Enabled = false;
			txtTanggalLahir.Enabled = false;
			txtPekerjaan.Enabled = false;
			txtTelpRumah.Enabled = false;
			txtTelpKantor.Enabled = false;
			txtNoHP.Enabled = false;
			txtEmail.Enabled = false;
			txtKeterangan.Enabled = false;
		}

		public override void LoadBeforeInitialize() {
			txtAgen.Properties.DataSource = new XPQuery<Agen>(session).Where(w => w.Aktif).ToList();
			txtPropinsi.Properties.DataSource = new XPQuery<Propinsi>(session).ToList();
			txtJmlExp.Properties.MinValue = 1;
			txtJmlExp.Properties.MaxValue = 99999;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Pelanggan : Tambah";
				txtTanggalMasuk.DateTime = DateTime.Now;
				txtJmlExp.Value = 1;
				txtAgen.EditValue = null;
				txtHargaLangganan.Value = 0;
				txtNomor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
				txtNomor.Text = "";
				txtKeterangan.Text = "";
				txtPropinsi.EditValue = null; 
				txtAlamat.Text = ""; 
				txtNama.Text = ""; 
				txtNoKTP.Text = ""; 
				txtTempatLahir.Text = ""; 
				txtTanggalLahir.DateTime = default(DateTime);
				txtPekerjaan.Text = ""; 
				txtTelpRumah.Text = ""; 
				txtTelpKantor.Text = ""; 
				txtNoHP.Text = ""; 
				txtEmail.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<Pelanggan>(Convert.ToInt64(IdToEdit));
				Text = "Pelanggan : Edit - " + originalEdit.Kode;

				txtTanggalMasuk.DateTime = originalEdit.TanggalMulaiLangganan; txtTanggalMasuk.Enabled = false;
				txtJmlExp.Value = originalEdit.JumlahExp; txtJmlExp.Enabled = false;
				txtAgen.EditValue = originalEdit.Agen;
				txtHargaLangganan.Value = (decimal)originalEdit.HargaLangganan;
				txtNomor.EditValue = originalEdit.Kode;
				txtKeterangan.Text = originalEdit.Keterangan;

				txtPropinsi.EditValue = originalEdit.Propinsi;
				txtKabupaten.EditValue = originalEdit.Kabupaten;
				txtKecamatan.EditValue = originalEdit.Kecamatan;
				txtKelurahan.EditValue = originalEdit.Kelurahan;
				txtAlamat.Text = originalEdit.Alamat;

				txtNama.Text = originalEdit.Nama;
				txtNoKTP.Text = originalEdit.NIK;
				txtTempatLahir.Text = originalEdit.TempatLahir;
				txtTanggalLahir.DateTime = originalEdit.TanggalLahir;
				txtPekerjaan.Text = originalEdit.Pekerjaan;
				txtTelpRumah.Text = originalEdit.NoTelpRumah;
				txtTelpKantor.Text = originalEdit.NoTelpKantor;
				txtNoHP.Text = originalEdit.NoHP;
				txtEmail.Text = originalEdit.Email;
				if (!originalEdit.Aktif) DisableControl();
			}
			txtTanggalMasuk.Focus();
		}
		public override void SimpanData() {
			Pelanggan instance;
			if (Tipe == InputType.Tambah) instance = new Pelanggan(session);
			else instance = session.GetObjectByKey<Pelanggan>(Convert.ToInt64(IdToEdit));
			var service = new PelangganService(session, originalEdit);
			instance.TanggalMulaiLangganan = txtTanggalMasuk.DateTime;
			instance.JumlahExpAwal = (int)txtJmlExp.Value;
			instance.Agen = txtAgen.EditValue == null ? null : (Agen)txtAgen.EditValue;
			instance.Harga = (double)txtHargaLangganan.Value;
			instance.Kode = txtNomor.Text;
			instance.Keterangan = txtKeterangan.Text;

			instance.Propinsi = txtPropinsi.EditValue == null ? null : (Propinsi)txtPropinsi.EditValue;
			instance.Kabupaten = txtKabupaten.EditValue == null ? null : (Kabupaten)txtKabupaten.EditValue;
			instance.Kecamatan = txtKecamatan.EditValue == null ? null : (Kecamatan)txtKecamatan.EditValue;
			instance.Kelurahan = txtKelurahan.EditValue == null ? null : (Kelurahan)txtKelurahan.EditValue;
			instance.Alamat = txtAlamat.Text;

			instance.Nama = txtNama.Text;
			instance.NIK = txtNoKTP.Text;
			instance.TempatLahir = txtTempatLahir.Text;
			instance.TanggalLahir = txtTanggalLahir.DateTime;
			instance.Pekerjaan = txtPekerjaan.Text;
			instance.NoTelpRumah = txtTelpRumah.Text;
			instance.NoTelpKantor = txtTelpKantor.Text;
			instance.NoHP = txtNoHP.Text;
			instance.Email = txtEmail.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtAgen.Focus(); break;
				case -2: txtNomor.Focus(); break;
				case -3: txtNama.Focus(); break;
			}
		}
	}
}
