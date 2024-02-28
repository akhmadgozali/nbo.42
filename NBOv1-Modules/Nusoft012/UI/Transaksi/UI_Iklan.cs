using DevExpress.Data.Async.Helpers;
using DevExpress.Data.Filtering;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_Iklan : GridInput {
		private readonly ETipeIklan _tipeIklan;

		internal UI_Iklan(ETipeIklan TipeIklan) {
			InitializeComponent();
			_tipeIklan = TipeIklan;
			Text = _tipeIklan == ETipeIklan.Kolom ? "Iklan Kolom" : "Iklan Deret";
			ifSource.FixedFilterCriteria =
				new GroupOperator(GroupOperatorType.And,
					new BinaryOperator(nameof(Invoice.SaldoAwal), false),
					new NullOperator(nameof(Invoice.KoreksiInvoice)),
					new BinaryOperator(nameof(Invoice.TipeInvoice) + "." + nameof(TipeInvoice.TipeIklan), _tipeIklan, BinaryOperatorType.Equal)
				);

			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(Invoice.Id);
			useFeedbackSource = true;
			useMDIforDialog = true;
			UseDbSystem = false;
		}

		public override InputBase GetDialogForm() { return new UI_IklanDialog(_tipeIklan, false); }
		public override List<GridDeletedData> GetKeteranganHapus(int[] selectedRows) {
			var result = new List<GridDeletedData>();
			GridDeletedData item;

			for (int i = selectedRows.GetLowerBound(0); i <= selectedRows.GetUpperBound(0); i++) {
				if (!xGridView.IsGroupRow(selectedRows[i])) {
					item = new GridDeletedData() {
						Row = selectedRows[i],
						Data = string.Format("{0}\r\n",
							xGridView.GetRowCellValue(selectedRows[i], nameof(Invoice.NoInvoice)))
					};
					result.Add(item);
				}
			}
			return result;
		}
		public override bool HapusData(List<GridDeletedData> selectedData) {
			var service = new InvoiceService(session);
			List<Invoice> deleted = new List<Invoice>();

			foreach (var x in selectedData) {
				if (!xGridView.IsGroupRow(x.Row)) {
					deleted.Add((Invoice)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(x.Row)).OriginalRow);
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