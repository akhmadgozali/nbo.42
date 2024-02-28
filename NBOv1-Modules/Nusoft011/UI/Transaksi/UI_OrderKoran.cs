using DevExpress.Data.Async.Helpers;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_OrderKoran : GridInput {
		public UI_OrderKoran() { 
			InitializeComponent();
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(OrderKoran.Id);
			useFeedbackSource = true; 
			useMDIforDialog = true;
			UseDbSystem = false;
		}

		public override InputBase GetDialogForm() { return new UI_OrderKoranDialog(); }
		public override List<GridDeletedData> GetKeteranganHapus(int[] selectedRows) {
			var result = new List<GridDeletedData>();
			GridDeletedData item;

			for (int i = selectedRows.GetLowerBound(0); i <= selectedRows.GetUpperBound(0); i++) {
				if (!xGridView.IsGroupRow(selectedRows[i])) {
					item = new GridDeletedData() {
						Row = selectedRows[i],
						Data = string.Format("{0:dd MMM yyyy}\r\n",
							xGridView.GetRowCellValue(selectedRows[i], nameof(OrderKoran.Tanggal)))
					};
					result.Add(item);
				}
			}
			return result;
		}
		public override bool HapusData(List<GridDeletedData> selectedData) {
			var service = new OrderKoranService(session);
			List<OrderKoran> deleted = new List<OrderKoran>();

			foreach (var x in selectedData) {
				if (!xGridView.IsGroupRow(x.Row)) {
					deleted.Add((OrderKoran)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(x.Row)).OriginalRow);
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