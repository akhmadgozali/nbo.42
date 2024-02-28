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
	public partial class UI_AbsensiCreate : InputDialog	{
		public UI_AbsensiCreate()	{
			InitializeComponent();
		}
		private Absensi originalEdit;
		public override void LoadBeforeInitialize()
		{

		}
		public override void SimpanData()
		{
			Absensi instance;

			TimeSpan timeSpan = txtTglSelesai.DateTime.Subtract(txtTglMulai.DateTime);
			int Jumlah = timeSpan.Days;
			for (int i = 1; i <= Jumlah; i++) {
				instance = new Absensi(session);
				var service = new AbsensiServices(session, originalEdit);
				//instance.Karyawan = Karyawan;
				instance.Tanggal = txtTglMulai.DateTime;
				
				service.Save(instance);
			}
		}
		public override void ErrorSimpan(Utils.Exception ex)
		{
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber)
			{
				case -1: txtTglMulai.Focus(); break;
			}
		}

	}
}
