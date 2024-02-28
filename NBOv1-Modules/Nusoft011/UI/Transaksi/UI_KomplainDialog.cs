using DevExpress.Xpo;
using System;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_KomplainDialog : InputDialog {
		public UI_KomplainDialog() {
			InitializeComponent();
			txtNomor.EditValueChanging += new ChangingEventHandler(NomorPelangganChanging);
			txtTanggal.DateTimeChanged += new EventHandler(TanggalChanged);
			AutoCloseOnSave = true;
		}
		private PelangganKomplain originalEdit;
		internal Pelanggan Pelanggan { get; set; }

		private void NomorPelangganChanging(object sender, ChangingEventArgs e) {
			xGrid.DataSource = null;
			txtAgen.Text = "";
			txtNama.Text = "";
			txtAlamat.Text = "";
			if (e.NewValue != null) {
				var item = (Pelanggan)e.NewValue;
				txtAgen.Text = item.Agen.Nama;
				txtNama.Text = item.Nama;
				txtAlamat.Text = item.Alamat + " " + item.Kelurahan?.Kode + " " + item.Kecamatan?.Kode + " " + item.Kabupaten?.Kode + " " + item.Propinsi?.Kode;
				if (Tipe == InputType.Edit) xGrid.DataSource = item.Komplain.Where(w => w != originalEdit);
				else xGrid.DataSource = item.Komplain;
			}
		}
		private void TanggalChanged(object sender, EventArgs e) { txtBatasWaktu.DateTime = txtTanggal.DateTime.AddMonths(1); }

		public override void LoadBeforeInitialize() {
			txtNomor.Properties.DataSource = new XPQuery<Pelanggan>(session).Where(w => w.Aktif).ToList();

			var penerimaKeluhan = new XPQuery<PelangganKomplain>(session).GroupBy(g => g.Penerima).Select(s => s.Key).ToList();
			var autoString = new AutoCompleteStringCollection();
			autoString.AddRange(penerimaKeluhan.ToArray());

			txtPenerima.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtPenerima.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtPenerima.MaskBox.AutoCompleteCustomSource = autoString;
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Komplain Pelanggan : Tambah";
				txtNomor.EditValue = null;
				txtTanggal.DateTime = DateTime.Now.Date;
				txtKeluhan.Text = "";
				txtSelesai.Checked = false;
				txtSolusi.Text = "";
				if (Pelanggan != null) {
					txtNomor.EditValue = Pelanggan;
					txtNomor.Enabled = false;
				}
			}
			else {
				originalEdit = session.GetObjectByKey<PelangganKomplain>(Convert.ToInt64(IdToEdit));
				Text = "Komplain Pelanggan : Edit - " + originalEdit.Pelanggan.Kode;
				txtNomor.EditValue = originalEdit.Pelanggan;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtPenerima.Text = originalEdit.Penerima;
				txtKeluhan.Text = originalEdit.Keluhan;
				txtBatasWaktu.DateTime = originalEdit.BatasWaktu;
				txtSelesai.Checked = originalEdit.Selesai;
				txtSolusi.Text = originalEdit.Solusi;
			}
			txtNomor.Focus();
		}
		public override void SimpanData() {
			PelangganKomplain instance;
			if (Tipe == InputType.Tambah) instance = new PelangganKomplain(session);
			else instance = session.GetObjectByKey<PelangganKomplain>(Convert.ToInt64(IdToEdit));
			var service = new KomplainPelangganService(session, originalEdit);
			instance.Pelanggan = txtNomor.EditValue == null ? null : (Pelanggan)txtNomor.EditValue;
			instance.Tanggal = txtTanggal.DateTime;
			instance.Penerima = txtPenerima.Text;
			instance.Keluhan = txtKeluhan.Text;
			instance.BatasWaktu = txtBatasWaktu.DateTime;
			instance.Selesai = txtSelesai.Checked;
			instance.Solusi = txtSolusi.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtNomor.Focus(); break;
				case -2: txtTanggal.Focus(); break;
				case -3: txtPenerima.Focus(); break;
				case -4: txtKeluhan.Focus(); break;
			}
		}
	}
}
