using DevExpress.Data.PLinq.Helpers;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.Utils.CustomAttribute;
using NuSoft.NUI.Win.Forms.Modules.NuSoft009.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	public partial class UI_SuratPeringatanDialog : InputDialog
	{
		public UI_SuratPeringatanDialog()
		{
			InitializeComponent();
		}
		private SuratPeringatan originalEdit;
		public override void LoadBeforeInitialize()
		{
			txtKaryawan.Properties.DataSource = new XPCollection<Karyawan>(session);//.Where(w => w.Jenis != eTipeKaryawan.Resign).OrderBy(o => o.Kode);
			txtJenis.Properties.DataSource = Utils.Helper.EnumDescription.ToList(typeof(eJenisSP));
		}
		public override void InitializeData()
		{
			if (Tipe == InputType.Tambah)
			{
				Text = "Surat Peringatan Karyawan : Tambah";
				txtTanggal.DateTime = DateTime.Now;
				txtKeterangan.EditValue = "";
			}
			else
			{
				Text = "Surat Peringatan Karyawan : Edit";
				originalEdit = session.GetObjectByKey<SuratPeringatan>(Convert.ToInt64(IdToEdit));
				txtKaryawan.EditValue = originalEdit.Karyawan;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtTanggal.Properties.ReadOnly = true;
				txtNoBukti.EditValue = originalEdit.Kode;
				txtJenis.EditValue = originalEdit.Jenis;
				txtKeterangan.EditValue = originalEdit.Keterangan;
				txtExpired.DateTime = originalEdit.Expired;
			}
			txtTanggal.Focus();
		}
		public override void SimpanData()
		{
			SuratPeringatan instance;
			if (Tipe == InputType.Tambah) instance = new SuratPeringatan(session);
			else instance = session.GetObjectByKey<SuratPeringatan>(Convert.ToInt64(IdToEdit));
			var service = new SuratPeringatanServices(session, originalEdit);
			instance.Karyawan = txtKaryawan.EditValue == null ? null : (Karyawan)txtKaryawan.EditValue;
			instance.Tanggal = txtTanggal.DateTime;
			instance.Jenis = (eJenisSP)txtJenis.EditValue;
			instance.Expired = txtExpired.DateTime;
			instance.Keterangan = (string)txtKeterangan.EditValue;

			service.Save(instance);
			this.Close();
		}
		public override void ErrorSimpan(Utils.Exception ex)
		{
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber)
			{
				case -1: txtTanggal.Focus(); break;
				case -2: txtKaryawan.Focus(); break;
			}
		}
	}
}
