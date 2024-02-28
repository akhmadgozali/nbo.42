using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.MasterData {
	public partial class UI_CaraBayarDialog : InputDialog {
		public UI_CaraBayarDialog() { InitializeComponent(); }
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
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = session.GetObjectByKey<CaraBayar>(Convert.ToInt32(IdToEdit));
				Text = "Cara Bayar : Edit - " + originalEdit.Alias;
				txtAkun.EditValue = originalEdit.Akun;
				txtAlias.Text = originalEdit.Alias; 
				txtAktif.Checked = originalEdit.Aktif;
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
