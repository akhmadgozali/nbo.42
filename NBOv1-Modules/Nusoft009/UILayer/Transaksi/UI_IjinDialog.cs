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
namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi{
	public partial class UI_IjinDialog : InputDialog{
		public UI_IjinDialog(){
			InitializeComponent();
			txtTanggalMulai.EditValueChanged += new EventHandler(xDataChanged);
			txtTanggalSelesai.EditValueChanged += new EventHandler(xDataChanged);
			txtKaryawan.EditValueChanged += new EventHandler(xDataChanged);
		}
		private List<IjinDetailForSave> detail;
		private Ijin originalEdit;
		public override void LoadBeforeInitialize()	{
			txtKaryawan.Properties.DataSource = new XPCollection<Karyawan>(session);//.Where(w => w.Jenis != eTipeKaryawan.Resign).OrderBy(o => o.Kode);
			txtJenis.Properties.DataSource = new XPCollection<MasterIjin>(session);//.Where(w => w.Jenis != eTipeKaryawan.Resign).OrderBy(o => o.Kode);		
			colStatusAbsenRepo.DataSource = new XPCollection<AbsensiTipe>(session);
		}
		private void xDataChanged(object sender, EventArgs e)	{
			if (txtKaryawan.EditValue == null) {

			} else {
				detail = IjinServices.GetDetailIjin(session, txtTanggalMulai.DateTime, txtTanggalSelesai.DateTime, (Karyawan)txtKaryawan.EditValue);
				xGrid.DataSource = detail;
			}
		}
		public override void InitializeData()	{
			if (Tipe == InputType.Tambah) {
				Text = "Surat Ijin Karyawan : Tambah";
				txtTanggal.DateTime = DateTime.Now;
				txtKeterangan.EditValue = "";
				//txtTanggalMulai.DateTime = DateTime.Now;
				//txtTanggalSelesai.DateTime = DateTime.Now;
				//detail = IjinServices.GetDetailIjin(session, txtTanggalMulai.DateTime, txtTanggalSelesai.DateTime, (Karyawan)txtKaryawan.EditValue);
				//xGrid.DataSource = detail;
			}
			else {
				Text = "Surat Ijin Karyawan : Edit";
				originalEdit = session.GetObjectByKey<Ijin>(Convert.ToInt64(IdToEdit));
				txtKaryawan.EditValue = originalEdit.Karyawan;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtTanggal.Properties.ReadOnly = true;
				txtNoBukti.EditValue = originalEdit.Kode;
				txtJenis.EditValue = originalEdit.Jenis;
				txtKeterangan.EditValue = originalEdit.Keterangan;
			}
			txtTanggal.Focus();
			xGridView.OptionsBehavior.ReadOnly = true;
		}
		public override void SimpanData()	{
			Ijin instance;
			if (Tipe == InputType.Tambah) instance = new Ijin(session);
			else instance = session.GetObjectByKey<Ijin>(Convert.ToInt64(IdToEdit));
			var service = new IjinServices(session, originalEdit);
			instance.Karyawan = txtKaryawan.EditValue == null ? null : (Karyawan)txtKaryawan.EditValue;
			instance.Tanggal = txtTanggal.DateTime;
			instance.Keterangan = (string)txtKeterangan.EditValue;
			instance.DetailForSave = detail;
			service.Save(instance);
			this.Close();
		}
		public override void ErrorSimpan(Utils.Exception ex)	{
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber)
			{
				case -1: txtTanggal.Focus(); break;
				case -2: txtKaryawan.Focus(); break;
			}
		}


	}
}
