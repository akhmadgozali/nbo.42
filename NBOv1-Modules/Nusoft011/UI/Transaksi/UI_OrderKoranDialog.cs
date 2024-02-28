using System;
using System.Drawing;
using System.Collections.Generic;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_OrderKoranDialog : InputMDI {
		public UI_OrderKoranDialog() {
			InitializeComponent();
			txtTanggal.EditValueChanged += new EventHandler(TanggalChanged);
			txtHariKhusus.CheckedChanged += new EventHandler(TanggalChanged);
			AutoCloseOnSave = true;
		}
		private List<OrderKoranDetailForSave> detail;
		private OrderKoran originalEdit;

		private void TanggalChanged(object sender, EventArgs e) {
			if (Tipe == InputType.Tambah) {
				detail = OrderKoranService.GetOrderDetail(session, txtTanggal.DateTime, txtHariKhusus.Checked);
				xGrid.DataSource = detail;
			}
		}
		private void DisableControl() {
			AllowSave = false;
			
			txtTanggal.Enabled = false;
			txtHariKhusus.Enabled = false;
			txtKeterangan.Enabled = false;
			colJatah.OptionsColumn.AllowEdit = false;
			colJatah.OptionsColumn.ReadOnly = true;
			colJatah.AppearanceCell.BackColor = Color.Transparent;
			colKonsi.OptionsColumn.AllowEdit = false;
			colKonsi.OptionsColumn.ReadOnly = true;
			colKonsi.AppearanceCell.BackColor = Color.Transparent;
			colGratis.OptionsColumn.AllowEdit = false;
			colGratis.OptionsColumn.ReadOnly = true;
			colGratis.AppearanceCell.BackColor = Color.Transparent;
		}

		public override void InitializeData() {
			if (Tipe == InputType.Tambah) {
				Text = "Order Koran : Tambah";
				txtTanggal.DateTime = DateTime.Now.AddDays(1);
				txtHariKhusus.Checked = false;
				txtKeterangan.Text = "";
			}
			else {
				originalEdit = OrderKoranService.GetItem(session, session.GetObjectByKey<OrderKoran>(Convert.ToInt64(IdToEdit)));
				Text = "Order Koran : Edit - " + originalEdit.Tanggal.ToString("dd MMMM yyyy");

				txtTanggal.DateTime = originalEdit.Tanggal;
				txtHariKhusus.Checked = originalEdit.HariKhusus;
				txtKeterangan.Text = originalEdit.Keterangan;
				detail = originalEdit.DetailForSave;
				xGrid.DataSource = detail;

				// cek disable
				if (OrderKoranService.CheckIsInUse(session, originalEdit.Tanggal)) DisableControl();
			}
			txtTanggal.Focus();
		}
		public override void SimpanData() {
			OrderKoran instance;
			if (Tipe == InputType.Tambah) instance = new OrderKoran(session);
			else instance = session.GetObjectByKey<OrderKoran>(Convert.ToInt64(IdToEdit));
			var service = new OrderKoranService(session, originalEdit);
			instance.Tanggal = txtTanggal.DateTime;
			instance.HariKhusus = txtHariKhusus.Checked;
			instance.Keterangan = txtKeterangan.Text;
			instance.DetailForSave = detail;
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggal.Focus(); break;
			}
		}
	}
}
