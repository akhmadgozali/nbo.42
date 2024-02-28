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
	public partial class UI_ResignDialog : InputDialog
	{
		public UI_ResignDialog()
		{
			InitializeComponent();
		}
		private Resign originalEdit;
		public override void LoadBeforeInitialize()
		{
			txtKaryawan.Properties.DataSource = new XPCollection<Karyawan>(session);//.Where(w => w.Jenis != eTipeKaryawan.Resign).OrderBy(o => o.Kode);
			txtJenis.Properties.DataSource = Utils.Helper.EnumDescription.ToList(typeof(eJenisResign));
		}
		public override void InitializeData()
		{
			if (Tipe == InputType.Tambah)
			{
				Text = "Resign Karyawan : Tambah";
				txtTanggal.DateTime = DateTime.Now;
				txtKeterangan.EditValue = "";
			}
			else
			{
				Text = "Resign Karyawan : Edit";
				originalEdit = session.GetObjectByKey<Resign>(Convert.ToInt64(IdToEdit));
				txtKaryawan.EditValue = originalEdit.Karyawan;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtTanggal.Properties.ReadOnly = true;
				txtNoBukti.EditValue = originalEdit.Kode;
				txtJenis.EditValue = originalEdit.Jenis;
				txtKeterangan.EditValue = originalEdit.Keterangan;
			}
			txtTanggal.Focus();
		}
		public override void SimpanData()
		{
			Resign instance;
			if (Tipe == InputType.Tambah) instance = new Resign(session);
			else instance = session.GetObjectByKey<Resign>(Convert.ToInt64(IdToEdit));
			var service = new ResignServices(session, originalEdit);
			instance.Karyawan = txtKaryawan.EditValue == null ? null : (Karyawan)txtKaryawan.EditValue;
			instance.Tanggal = txtTanggal.DateTime;
			instance.Jenis = (eJenisResign)txtJenis.EditValue;
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
