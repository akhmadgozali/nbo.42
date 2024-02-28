using DevExpress.Data.PLinq.Helpers;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
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
	public partial class UI_AbsensiDialog : InputDialog	{
		public UI_AbsensiDialog()	{
			InitializeComponent();
		}
		private Absensi originalEdit;
		public override void LoadBeforeInitialize()	{

			txtKaryawan.Properties.DataSource = new XPCollection<Karyawan>(session);//.Where(w => w.Jenis != eTipeKaryawan.Resign).OrderBy(o => o.Kode);
			txtKaryawanCreate.Properties.DataSource = new XPCollection<Karyawan>(session);//.Where(w => w.Jenis != eTipeKaryawan.Resign).OrderBy(o => o.Kode);
			//txtKaryawan.EditValue = ((XPCollection<Karyawan>)txtKaryawan.Properties.DataSource)[0];
			txtStatus.Properties.DataSource = new XPCollection<AbsensiTipe>(session);
			txtStatus.EditValue = ((XPCollection<AbsensiTipe>)txtStatus.Properties.DataSource)[0];
			txtShift.Properties.DataSource = new XPCollection<Shift>(session);
			txtShift.EditValue = ((XPCollection<Shift>)txtShift.Properties.DataSource)[0];
		}
		public override void InitializeData()	{
			if (Tipe == InputType.Tambah) {
				Text = "Absensi : Tambah";
				txtTanggal.DateTime = DateTime.Now;
			} else {
				Text = "Absensi : Edit";
				originalEdit = session.GetObjectByKey<Absensi>(Convert.ToInt64(IdToEdit));
				txtKaryawan.EditValue = originalEdit.Karyawan;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtJamMasuk.EditValue = originalEdit.JamMasuk;
				txtJamKeluar.EditValue = originalEdit.JamPulang;
				txtStatus.EditValue = originalEdit.Status;
				txtShift.EditValue = originalEdit.Shift;
				txtTanggal.Properties.ReadOnly = true;

			}
			txtTanggal.Focus();
		}
		public override void SimpanData()	{
			Absensi instance;
			AbsensiTipe Status;
			if (Tipe == InputType.Tambah) instance = new Absensi(session);
			else instance = session.GetObjectByKey<Absensi>(Convert.ToInt64(IdToEdit));
			var service = new AbsensiServices(session, originalEdit);
			instance.Karyawan = txtKaryawan.EditValue == null ? null : (Karyawan)txtKaryawan.EditValue;
			instance.Tanggal = txtTanggal.DateTime;
			instance.Divisi = instance.Karyawan.Divisi;
			instance.JamMasuk = (TimeSpan)txtJamMasuk.Time.TimeOfDay;
			instance.JamPulang = (TimeSpan)txtJamKeluar.Time.TimeOfDay;

			//jika sabtu minggu, paksa status=libur
			if (Tipe == InputType.Tambah){
				if (instance.Tanggal.DayOfWeek == DayOfWeek.Saturday || instance.Tanggal.DayOfWeek == DayOfWeek.Sunday){
					Status = session.GetObjectByKey<AbsensiTipe>(Convert.ToInt64(5));
					instance.Status = Status;
				}else{
					Status = session.GetObjectByKey<AbsensiTipe>(Convert.ToInt64(0));
					instance.Status = Status;
				}
			}
			else {
				instance.Status = txtStatus.EditValue == null ? null : (AbsensiTipe)txtStatus.EditValue;
			}

			instance.Shift = txtShift.EditValue == null ? null : (Shift)txtShift.EditValue;
			service.Save(instance);

		}
		public override void ErrorSimpan(Utils.Exception ex){
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber)	{
				case -1: txtTanggal.Focus(); break;
				case -2: txtKaryawan.Focus(); break;
			}
		}

		private void btnCreate_Click(object sender, EventArgs e){

		}
	}
}
