using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_CaraBayarDialog : InputDialog {
		public UI_CaraBayarDialog() { 
			InitializeComponent();
			txtIsPPh23.CheckedChanged += (s, e) => txtPPh23Persen.Enabled = txtIsPPh23.Checked;
			AutoCloseOnSave = true;
		}
		private CaraBayar originalEdit;

		public override void LoadBeforeInitialize() {
			txtAkun.Properties.DataSource = AkunService.GetAkunCollection(session, true).OrderBy(o => o.Kode).ToList();  //new XPCollection<Akun>(session).OrderBy(o => o.Kode).ToList();
		}
		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Cara Bayar : Tambah";
				txtAkun.EditValue = ((List<Akun>)txtAkun.Properties.DataSource)[0];
				txtAlias.Text = ""; 
				txtAktif.Checked = true;
				txtIsPPh23.Checked = false;
				txtPPh23Persen.Value = 0;
				txtIsPPh21.Checked = false;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<CaraBayar>(Convert.ToInt32(IdToEdit));
				Text = "Cara Bayar : Edit - " + originalEdit.Alias;
				txtAkun.EditValue = originalEdit.Akun;
				txtAlias.Text = originalEdit.Alias; 
				txtAktif.Checked = originalEdit.Aktif;
				txtIsPPh23.Checked = originalEdit.IsPPh23;
				txtPPh23Persen.Value = originalEdit.PPh23Persen;
				txtIsPPh21.Checked = originalEdit.IsPPh21;
				txtKeterangan.Text = originalEdit.Keterangan;
			}
			txtAkun.Focus();
		}
		public override void SimpanData() {
			CaraBayar instance;
			if (Tipe == InputType.Tambah) instance = new CaraBayar(session);
			else instance = session.GetObjectByKey<CaraBayar>(Convert.ToInt32(IdToEdit));
			var service = new CaraBayarService(session, originalEdit);
			instance.Akun = txtAkun.EditValue == null ? null : (Akun)txtAkun.EditValue;
			instance.Alias = txtAlias.Text;
			instance.Aktif = txtAktif.Checked;
			instance.IsPPh23 = txtIsPPh23.Checked;
			instance.PPh23Persen = txtPPh23Persen.Value;
			instance.IsPPh21 = txtIsPPh21.Checked;
			instance.Keterangan = txtKeterangan.Text;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtAkun.Focus(); break;
				case -2: txtAlias.Focus(); break;
			}
		}
	}
}
