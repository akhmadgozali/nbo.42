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
	public partial class UI_MutasiKaryawanDialog : InputDialog
	{
		public UI_MutasiKaryawanDialog()
		{
			InitializeComponent();
		}
		private PromosiKaryawan originalEdit;
		public override void LoadBeforeInitialize()
		{
			txtKaryawan.Properties.DataSource = new XPCollection<Karyawan>(session);//.Where(w => w.Jenis != eTipeKaryawan.Resign).OrderBy(o => o.Kode);
			txtJabatan.Properties.DataSource = new XPCollection<Jabatan>(session);
			txtPremiKehadiran.Properties.DataSource = new XPCollection<Kehadiran>(session);
			txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(typeof(eTipeKaryawan));
		}
		public override void InitializeData()
		{
			if (Tipe == InputType.Tambah)
			{
				Text = "Mutasi Karyawan : Tambah";
				txtTanggal.DateTime = DateTime.Now;
				txtGajiPokok.EditValue = 0.0;
				txtTunjanganJabatan.EditValue = 0.0;
				txtTunjanganKeluarga.EditValue = 0.0;
				txtTunjanganTransport.EditValue = 0.0;
				txtPotKerja.EditValue = 0.0;
				txtPotKesehatan.EditValue = 0.0;
				txtPotLain.EditValue = 0.0;
				txtPotPensiun.EditValue = 0.0;
			}
			else
			{
				Text = "Mutasi Karyawan : Edit";
				originalEdit = session.GetObjectByKey<PromosiKaryawan>(Convert.ToInt64(IdToEdit));
				txtKaryawan.EditValue = originalEdit.Karyawan;
				txtTanggal.DateTime = originalEdit.Tanggal;
				txtTanggal.Properties.ReadOnly = true;
				txtGajiPokok.EditValue = originalEdit.GajiPokok;
				txtTunjanganJabatan.EditValue = originalEdit.TunjanganJabatan;
				txtTunjanganKeluarga.EditValue = originalEdit.TunjanganKeluarga;
				txtTunjanganTransport.EditValue = originalEdit.TunjanganTransport;
				txtPotKerja.EditValue = originalEdit.PotonganTenagaKerja;
				txtPotKesehatan.EditValue = originalEdit.PotonganKesehatan;
				txtPotLain.EditValue = originalEdit.PotonganLain;
				txtPotPensiun.EditValue = originalEdit.PotonganPensiun;
				txtPremiKehadiran.EditValue = originalEdit.PremiKehadiran;
				txtCatatan.EditValue = originalEdit.Catatan;
				
			}
			txtTanggal.Focus();
		}
		public override void SimpanData()
		{
			PromosiKaryawan instance;
			if (Tipe == InputType.Tambah) instance = new PromosiKaryawan(session);
			else instance = session.GetObjectByKey<PromosiKaryawan>(Convert.ToInt64(IdToEdit));
			var service = new MutasiKaryawanServices(session, originalEdit);
			instance.Karyawan = txtKaryawan.EditValue == null ? null : (Karyawan)txtKaryawan.EditValue;
			instance.Tanggal = txtTanggal.DateTime;
			instance.Jabatan = (Jabatan)txtJabatan.EditValue;
			instance.Jenis = (eTipeKaryawan)txtTipe.EditValue;
			//instance.GajiPokok = (double)txtGajiPokok.EditValue;
			instance.TunjanganJabatan= (double)txtTunjanganJabatan.EditValue;
			instance.TunjanganKeluarga= (double)txtTunjanganKeluarga.EditValue;
			instance.TunjanganTransport= (double)txtTunjanganTransport.EditValue;
			instance.PotonganTenagaKerja= (double)txtPotKerja.EditValue;
			instance.PotonganKesehatan= (double)txtPotKesehatan.EditValue;
			instance.PotonganLain= (double)txtPotLain.EditValue;
			instance.PotonganPensiun= (double)txtPotPensiun.EditValue;
			instance.PremiKehadiran= (Kehadiran)txtPremiKehadiran.EditValue;
			instance.Catatan= (string)txtCatatan.EditValue;

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
