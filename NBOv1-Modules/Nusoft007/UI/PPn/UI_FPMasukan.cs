using DevExpress.Data.Async.Helpers;
using DevExpress.Data.Filtering;
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
	public partial class UI_FPMasukan : GridInput {
		public UI_FPMasukan(ModuleId moduleId) {
			InitializeComponent();
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(PPnMasukan.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;

			_moduleId = moduleId;
			if (moduleId != ModuleId.TaxManagement) {
				allowAdd = false;
				allowDelete = false;
				collast_modified.Visible = false;
				ifSource.FixedFilterCriteria = new BinaryOperator(nameof(PPnMasukan.ModuleId), _moduleId, BinaryOperatorType.Equal);
			}
		}

		private readonly ModuleId _moduleId;

		public override InputBase GetDialogForm() { return new UI_FPMasukanDialog(_moduleId); }
		public override List<GridDeletedData> GetKeteranganHapus(int[] selectedRows) {
			var result = new List<GridDeletedData>();
			GridDeletedData item;

			for (int i = selectedRows.GetLowerBound(0); i <= selectedRows.GetUpperBound(0); i++) {
				if (!xGridView.IsGroupRow(selectedRows[i])) {
					item = new GridDeletedData() {
						Row = selectedRows[i],
						Data = string.Format("{0}\r\n",
							xGridView.GetRowCellValue(selectedRows[i], nameof(PPnMasukan.NomorFaktur)))
					};
					result.Add(item);
				}
			}
			return result;
		}
		public override bool HapusData(List<GridDeletedData> selectedData) {
			var service = new PPnMasukanService(session);
			List<PPnMasukan> deleted = new List<PPnMasukan>();

			foreach (var x in selectedData) {
				if (!xGridView.IsGroupRow(x.Row)) {
					deleted.Add((PPnMasukan)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(x.Row)).OriginalRow);
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

				PPnMasukan item = (PPnMasukan)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(e.RowHandle)).OriginalRow;
				switch (item.ModuleId) {
					case ModuleId.AssetManagement: e.Appearance.BackColor = Color.Aqua; break;
					case ModuleId.Purchase: e.Appearance.BackColor = Color.Plum; break;
					default:
						break;
				}
			}
			catch { }
		}
	}
}
