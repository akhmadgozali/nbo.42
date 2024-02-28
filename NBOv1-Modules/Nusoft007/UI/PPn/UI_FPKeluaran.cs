using DevExpress.Data;
using DevExpress.Data.Async.Helpers;
using DevExpress.Data.Filtering;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn {
	public partial class UI_FPKeluaran : GridInput {
		public UI_FPKeluaran(ModuleId moduleId, bool OnlyList) {
			InitializeComponent();
			xGridView.SelectionChanged += new SelectionChangedEventHandler(GridViewSelectionChanged);
			btnStatusValid.ItemClick += new ItemClickEventHandler(ValidClick);
			btnStatusEksporCSV.ItemClick += new ItemClickEventHandler(EksporCSVClick);
			btnStatusApproval.ItemClick += new ItemClickEventHandler(ApprovalClick);
			btnStatusFPPengganti.ItemClick += new ItemClickEventHandler(FPDigantiClick);
			btnStatusFPBatal.ItemClick += new ItemClickEventHandler(FPDibatalkanClick);
			btnStatusEdit.ItemClick += new ItemClickEventHandler(EditClick);
			btnPDF.ItemClick += new ItemClickEventHandler(ShowPDF);

			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(PPnKeluaran.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
			_moduleId = moduleId;

			if (OnlyList) {
				Text = "Daftar PPn";
				allowAdd = false;
				allowDelete = false;
				ifSource.FixedFilterCriteria = new NullOperator(nameof(PPnKeluaran.NomorSeriValid));
				btnUpdateStatus.Visibility = BarItemVisibility.Never;
				btnPDF.Visibility = BarItemVisibility.Never;
			}
			else {
				Text = "PPn Keluaran";
				if (moduleId != ModuleId.TaxManagement) {
					Text = "PPn Keluaran - " + moduleId.ToString();
					allowAdd = false;
					allowDelete = false;
					collast_modified.Visible = false;
					ifSource.FixedFilterCriteria =
						new GroupOperator(GroupOperatorType.And,
						new NotOperator(new NullOperator(nameof(PPnKeluaran.NomorSeriValid))),
						new BinaryOperator(nameof(PPnKeluaran.ModuleId), _moduleId, BinaryOperatorType.Equal));
				}
				else {
					ifSource.FixedFilterCriteria = new NotOperator(new NullOperator(nameof(PPnKeluaran.NomorSeriValid)));
				}
			}
		}
		private readonly ModuleId _moduleId;

		public override InputBase GetDialogForm() { return new UI_FPKeluaranDialog(_moduleId); }
		public override List<GridDeletedData> GetKeteranganHapus(int[] selectedRows) {
			var result = new List<GridDeletedData>();
			GridDeletedData item;

			for (int i = selectedRows.GetLowerBound(0); i <= selectedRows.GetUpperBound(0); i++) {
				if (!xGridView.IsGroupRow(selectedRows[i])) {
					item = new GridDeletedData() {
						Row = selectedRows[i],
						Data = string.Format("{0}\r\n",
							xGridView.GetRowCellValue(selectedRows[i], nameof(PPnKeluaran.NomorSeri)))
					};
					result.Add(item);
				}
			}
			return result;
		}
		public override bool HapusData(List<GridDeletedData> selectedData) {
			var service = new PPnKeluaranService(session);
			List<PPnKeluaran> deleted = new List<PPnKeluaran>();

			foreach (var x in selectedData) {
				if (!xGridView.IsGroupRow(x.Row)) {
					deleted.Add((PPnKeluaran)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(x.Row)).OriginalRow);
				}
			}

			try {
				return service.Delete(deleted);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}
		}

		public override void GridViewRowStyle(object sender, RowStyleEventArgs e) {
			try {
				if (xGridView.IsGroupRow(e.RowHandle)) return;

				PPnKeluaran item = (PPnKeluaran)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(e.RowHandle)).OriginalRow;
				switch (item.ModuleId) {
					case ModuleId.Sales: e.Appearance.BackColor = Color.SeaGreen; break;
					case ModuleId.SirkulasiKoran: e.Appearance.BackColor = Color.Khaki; break;
					case ModuleId.IklanKoran: e.Appearance.BackColor = Color.IndianRed; break;
					default:
						break;
				}
				if (item.StatusFaktur == EFakturStatus.FPDiBatalkan) {
					var x = new Font(e.Appearance.Font, FontStyle.Strikeout | FontStyle.Bold);
					e.Appearance.Font = x;
				}
				else if (item.StatusFaktur == EFakturStatus.FPDiganti) {
					var x = new Font(e.Appearance.Font, FontStyle.Strikeout);
					e.Appearance.Font = x;
				}
			}
			catch { }
		}
		private void GridViewSelectionChanged(object sender, SelectionChangedEventArgs e) {
			try {
				btnStatusValid.Visibility = BarItemVisibility.Never;
				btnStatusEksporCSV.Visibility = BarItemVisibility.Never;
				btnStatusApproval.Visibility = BarItemVisibility.Never;
				btnStatusFPBatal.Visibility = BarItemVisibility.Never;
				btnStatusFPPengganti.Visibility = BarItemVisibility.Never;
				btnStatusEdit.Visibility = BarItemVisibility.Never;
				btnPDF.Visibility = BarItemVisibility.Never;

				ReadonlyThreadSafeProxyForObjectFromAnotherThread proxy;
				var rows = xGridView.GetSelectedRows();
				PPnKeluaran item;
				List<EFakturStatus> status = new List<EFakturStatus>();

				for (int i = rows.GetLowerBound(0); i <= rows.GetUpperBound(0); i++) {
					if (!xGridView.IsGroupRow(rows[i])) {
						proxy = xGridView.GetRow(rows[i]) as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
						item = proxy.OriginalRow as PPnKeluaran;
						status.Add(item.StatusFaktur);
					}
				}

				if (status.Count <= 0) return;

				if (status.TrueForAll(m => m == EFakturStatus.Edit)) {
					btnStatusValid.Visibility = BarItemVisibility.Always;
				}
				else if (status.TrueForAll(m => m == EFakturStatus.Valid)) {
					btnStatusEksporCSV.Visibility = BarItemVisibility.Always;
					btnStatusApproval.Visibility = BarItemVisibility.Always;
					btnStatusEdit.Visibility = BarItemVisibility.Always;
				}
				else if (status.TrueForAll(m => m == EFakturStatus.ExportCSV)) {
					btnStatusApproval.Visibility = BarItemVisibility.Always;
					btnStatusEdit.Visibility = BarItemVisibility.Always;
				}
				else if (status.TrueForAll(m => m == EFakturStatus.Approval)) {
					btnStatusFPPengganti.Visibility = BarItemVisibility.Always;
					btnStatusFPBatal.Visibility = BarItemVisibility.Always;
					btnPDF.Visibility = BarItemVisibility.Always;
				}
				else if (status.TrueForAll(m => m == EFakturStatus.FPDiganti) || status.TrueForAll(m => m == EFakturStatus.FPDiBatalkan)) {
					btnPDF.Visibility = BarItemVisibility.Always;
				}
			}
			catch { }
		}

		private bool ConfirmationUpdateStatus(string message, string caption) {
			var rows = xGridView.GetSelectedRows();
			return (MessageBox.Show(message + "\r\n" + ((int)rows.GetUpperBound(0) + 1) + " item terpilih.", caption, 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
		}
		private void ValidClick(object sender, ItemClickEventArgs e) {
			if (ConfirmationUpdateStatus("Apakah anda yakin untuk memvalidkan faktur pajak yang terpilih ?", "Update Valid")) {
				var rows = xGridView.GetSelectedRows();
				for (int i = rows.GetLowerBound(0); i <= rows.GetUpperBound(0); i++) {
					if (!xGridView.IsGroupRow(rows[i])) {
						ReadonlyThreadSafeProxyForObjectFromAnotherThread proxy;
						proxy = xGridView.GetRow(rows[i]) as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
						(proxy.OriginalRow as PPnKeluaran).StatusFaktur = EFakturStatus.Valid;
					}
				}
				session.CommitChanges();
				RefreshData();
				xGridView.SelectRow(xGridView.FocusedRowHandle);
			}
		}
		private void EksporCSVClick(object sender, ItemClickEventArgs e) {
			var dialog = new SaveFileDialog();
			dialog.Filter = "CSV Files|*.csv";
			dialog.Title = "Pilih lokasi file hasil ekspor CSV";
			dialog.ShowDialog();
			if (!string.IsNullOrEmpty(dialog.FileName)) {
				var rows = xGridView.GetSelectedRows();
				var listData = new List<PPnKeluaran>();
				for (int i = rows.GetLowerBound(0); i <= rows.GetUpperBound(0); i++) {
					if (!xGridView.IsGroupRow(rows[i])) {
						ReadonlyThreadSafeProxyForObjectFromAnotherThread proxy;
						proxy = xGridView.GetRow(rows[i]) as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
						listData.Add(proxy.OriginalRow as PPnKeluaran);
					}
				}

				try {
					PPnKeluaranService.EksporCSV(session, dialog.FileName, listData);
					MessageBox.Show("File CSV '" + dialog.FileName + "' berhasil diekspor.", "Ekspor CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
					RefreshData();
					xGridView.SelectRow(xGridView.FocusedRowHandle);
				}
				catch (Exception ex) {
					MessageBox.Show("Ekspor file CSV '" + dialog.FileName + "' gagal.\r\n" + ex.Message, "Ekspor CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ApprovalClick(object sender, ItemClickEventArgs e) {
			if (!xGridView.IsDataRow(xGridView.FocusedRowHandle)) return;
			var row = (PPnKeluaran)(xGridView.GetFocusedRow() as ReadonlyThreadSafeProxyForObjectFromAnotherThread).OriginalRow;
			
			var dialog = new OpenFileDialog();
			dialog.Filter = "PDF Files|*.pdf";
			dialog.Title = "Upload file PDF untuk nomor faktur " + row.NoSeriLengkap;
			dialog.ShowDialog();
			if (!string.IsNullOrEmpty(dialog.FileName)) {
				try {
					PPnKeluaranService.Approval(session, dialog.FileName, row);
					MessageBox.Show("Approval faktur '" + row.NoSeriLengkap + "' berhasil.", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
					RefreshData();
					xGridView.SelectRow(xGridView.FocusedRowHandle);
				}
				catch (Exception ex) {
					MessageBox.Show("Approval faktur '" + row.NoSeriLengkap + "' gagal.\r\n" + ex.Message, "Approval", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void FPDigantiClick(object sender, ItemClickEventArgs e) {
			if (ConfirmationUpdateStatus("Apakah anda yakin untuk mengganti faktur pajak yang terpilih ?", "FP Pengganti")) {
				var rows = xGridView.GetSelectedRows();
				var listData = new List<PPnKeluaran>();
				for (int i = rows.GetLowerBound(0); i <= rows.GetUpperBound(0); i++) {
					if (!xGridView.IsGroupRow(rows[i])) {
						ReadonlyThreadSafeProxyForObjectFromAnotherThread proxy;
						proxy = xGridView.GetRow(rows[i]) as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
						listData.Add(proxy.OriginalRow as PPnKeluaran);
					}
				}
				PPnKeluaranService.FPBatalPengganti(session, listData, false);
				RefreshData();
				xGridView.SelectRow(xGridView.FocusedRowHandle);
			}
		}
		private void FPDibatalkanClick(object sender, ItemClickEventArgs e) {
			if (ConfirmationUpdateStatus("Apakah anda yakin untuk membatalkan faktur pajak yang terpilih ?", "FP Batal")) {
				var rows = xGridView.GetSelectedRows();
				var listData = new List<PPnKeluaran>();
				for (int i = rows.GetLowerBound(0); i <= rows.GetUpperBound(0); i++) {
					if (!xGridView.IsGroupRow(rows[i])) {
						ReadonlyThreadSafeProxyForObjectFromAnotherThread proxy;
						proxy = xGridView.GetRow(rows[i]) as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
						listData.Add(proxy.OriginalRow as PPnKeluaran);
					}
				}
				PPnKeluaranService.FPBatalPengganti(session, listData, true);
				RefreshData();
				xGridView.SelectRow(xGridView.FocusedRowHandle);
			}
		}
		private void EditClick(object sender, ItemClickEventArgs e) {
			if (ConfirmationUpdateStatus("Apakah anda yakin untuk merubah status ke edit pada faktur pajak yang terpilih ?", "Update Valid")) {
				var rows = xGridView.GetSelectedRows();
				for (int i = rows.GetLowerBound(0); i <= rows.GetUpperBound(0); i++) {
					if (!xGridView.IsGroupRow(rows[i])) {
						ReadonlyThreadSafeProxyForObjectFromAnotherThread proxy;
						proxy = xGridView.GetRow(rows[i]) as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
						(proxy.OriginalRow as PPnKeluaran).StatusFaktur = EFakturStatus.Edit;
					}
				}
				session.CommitChanges();
				RefreshData();
				xGridView.SelectRow(xGridView.FocusedRowHandle);
			}
		}
		private void ShowPDF(object sender, ItemClickEventArgs e) {
			if (!xGridView.IsDataRow(xGridView.FocusedRowHandle)) return;
			var row = (PPnKeluaran)(xGridView.GetFocusedRow() as ReadonlyThreadSafeProxyForObjectFromAnotherThread).OriginalRow;

			if (row.ApprovalPDF != null && row.ApprovalPDF.PDF != null) {
				var frm = new UI_PDFViewer();
				frm.Text = "File PDF - " + row.NoSeriLengkap;
				frm.LoadFromStream(row.ApprovalPDF.PDF);
				frm.Show();
			}
		}
	}
}
