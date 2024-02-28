using DevExpress.Data;
using DevExpress.Data.Async.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPh {
	public partial class UI_PPh21 : GridInput {
		public UI_PPh21() { 
			InitializeComponent();
			xGridView.SelectionChanged += new SelectionChangedEventHandler(GridViewSelectionChanged);
			btnUploadBuktiPotong.ItemClick += new ItemClickEventHandler(UploadClick);
			btnLihatBuktiPotong.ItemClick += new ItemClickEventHandler(ShowImage);

			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(PPh23.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
			allowAdd = false; 
			allowEdit = false; 
			allowDelete = false; 
		}

		public override void GridViewRowStyle(object sender, RowStyleEventArgs e) {
			try {
				if (xGridView.IsGroupRow(e.RowHandle)) return;

				PPh21Komisi item = (PPh21Komisi)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(e.RowHandle)).OriginalRow;
				switch (item.ModuleId) {
					case ModuleId.Sales: e.Appearance.BackColor = Color.SeaGreen; break;
					case ModuleId.SirkulasiKoran: e.Appearance.BackColor = Color.Khaki; break;
					case ModuleId.IklanKoran: e.Appearance.BackColor = Color.IndianRed; break;
					default:
						break;
				}
				if (item.BuktiPotong != null) {
					var x = new Font(e.Appearance.Font, FontStyle.Bold);
					e.Appearance.Font = x;
				}
			}
			catch { }
		}
		private void GridViewSelectionChanged(object sender, SelectionChangedEventArgs e) {
			try {
				btnUploadBuktiPotong.Visibility = BarItemVisibility.Always;
				btnLihatBuktiPotong.Visibility = BarItemVisibility.Never;
				if (!xGridView.IsDataRow(xGridView.FocusedRowHandle)) return;
				var row = (PPh21Komisi)(xGridView.GetFocusedRow() as ReadonlyThreadSafeProxyForObjectFromAnotherThread).OriginalRow;

				if (row.IsUploadBuktiPotong) btnLihatBuktiPotong.Visibility = BarItemVisibility.Always;
			}
			catch { }
		}
		private void UploadClick(object sender, ItemClickEventArgs e) {
			if (!xGridView.IsDataRow(xGridView.FocusedRowHandle)) return;
			var row = (PPh21Komisi)(xGridView.GetFocusedRow() as ReadonlyThreadSafeProxyForObjectFromAnotherThread).OriginalRow;

			var dialog = new OpenFileDialog();
			dialog.Filter = "Images Files|*.jpg;*.jpeg;*.png;";
			dialog.Title = "Upload file bukti potong komisi untuk invoice " + row.NoInvoice;
			dialog.ShowDialog();
			if (!string.IsNullOrEmpty(dialog.FileName)) {
				try {
					PPh21KomisiService.UploadBuktiPotong(session, dialog.FileName, row);
					MessageBox.Show("Upload bukti potong '" + row.NoInvoice + "' berhasil.", "Upload Bukti Potong", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex) {
					MessageBox.Show("Upload bukti potong '" + row.NoInvoice + "' gagal.\r\n" + ex.Message, "Upload Bukti Potong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ShowImage(object sender, ItemClickEventArgs e) {
			if (!xGridView.IsDataRow(xGridView.FocusedRowHandle)) return;
			var row = (PPh21Komisi)(xGridView.GetFocusedRow() as ReadonlyThreadSafeProxyForObjectFromAnotherThread).OriginalRow;

			if (row.BuktiPotong != null && row.BuktiPotong.FileBlob != null) {
				var frm = new UI_ImageViewer();
				frm.Text = "Bukti Potong PPh 21 Komisi untuk invoice - " + row.NoInvoice;
				frm.LoadFromStream(row.BuktiPotong.FileBlob);
				frm.ShowDialog();
			}
		}
	}
}
