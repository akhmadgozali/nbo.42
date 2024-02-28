using DevExpress.Data.Async.Helpers;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.MasterData {
	public partial class UI_Rute : GridInput {
		public UI_Rute() { 
			InitializeComponent();
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(Rute.Id);
			useFeedbackSource = true; 
			useMDIforDialog = false;
			UseDbSystem = false;
		}

		public override InputBase GetDialogForm() { return new UI_RuteDialog(); }
		public override List<GridDeletedData> GetKeteranganHapus(int[] selectedRows) {
			var result = new List<GridDeletedData>();
			GridDeletedData item;

			for (int i = selectedRows.GetLowerBound(0); i <= selectedRows.GetUpperBound(0); i++) {
				if (!xGridView.IsGroupRow(selectedRows[i])) {
					item = new GridDeletedData() {
						Row = selectedRows[i],
						Data = string.Format("{0} - {1}\r\n",
							xGridView.GetRowCellValue(selectedRows[i], nameof(Rute.Kode)),
							xGridView.GetRowCellValue(selectedRows[i], nameof(Rute.Nama)))
					};
					result.Add(item);
				}
			}
			return result;
		}
		public override bool HapusData(List<GridDeletedData> selectedData) {
			var service = new RuteService(session);
			List<Rute> deleted = new List<Rute>();

			foreach (var x in selectedData) {
				if (!xGridView.IsGroupRow(x.Row)) {
					deleted.Add((Rute)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(x.Row)).OriginalRow);
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
	}
}