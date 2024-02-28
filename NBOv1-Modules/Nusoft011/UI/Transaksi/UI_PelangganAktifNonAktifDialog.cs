using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using static NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services.PelangganService;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_PelangganAktifNonAktifDialog : DialogForm {
		internal UI_PelangganAktifNonAktifDialog(ModeStatusPelanggan status) {
			InitializeComponent();
			_status = status;
			if (status == ModeStatusPelanggan.NonAktifkan) Text = "Non Aktifkan Pelanggan";
			else if (status == ModeStatusPelanggan.TambahExp) Text = "Tambah Exp Pelanggan";
			else Text = "Aktifkan Pelanggan";
			txtTanggal.EditValueChanged += new EventHandler(TanggalChanged);
			AutoCloseOnSave = true;
		}
		private readonly ModeStatusPelanggan _status;
		private Pelanggan item;

		private void TanggalChanged(object sender, EventArgs e) {
			if (txtTanggal.DateTime != default(DateTime)) {
				if (_status == ModeStatusPelanggan.NonAktifkan)
					txtKeterangan.Text = "Berhenti langganan per " + txtTanggal.DateTime.ToString("dd MMM yyyy");
				else if (_status == ModeStatusPelanggan.TambahExp)
					txtKeterangan.Text = "Tambah Exp langganan per " + txtTanggal.DateTime.ToString("dd MMM yyyy");
				else
					txtKeterangan.Text = "Langganan kembali per " + txtTanggal.DateTime.ToString("dd MMM yyyy");
			}
		}
		internal void SetData(UnitOfWork Session, Pelanggan obj) {
			session = Session;
			item = obj;
			txtNomor.Text = obj.Kode;
			txtNama.Text = obj.Nama;
			txtTanggal.DateTime = DateTime.Now;
			txtJmlExp.Properties.MinValue = 1;
			if (_status == ModeStatusPelanggan.TambahExp) {
				txtJmlExp.Value = 1;
				txtJmlExp.Properties.MaxValue = 99999;
			}
			else {
				txtJmlExp.Value = obj.JumlahExp;
				txtJmlExp.Properties.MaxValue = obj.JumlahExp;
			}
			txtAlamat.Text = obj.Alamat + " " + obj.Kelurahan?.Kode + " " + obj.Kecamatan?.Kode + " " + obj.Kabupaten?.Kode + " " + obj.Propinsi?.Kode;
		}

		public override void Btn1Click() {
			PelangganService.SetStatusPelanggan(session, item, (int)txtJmlExp.Value, txtTanggal.DateTime, _status, txtKeterangan.Text);
			session.CommitChanges();
		}
		public override void ErrorBtn1Click(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			txtKeterangan.Focus();
		}
	}
}
