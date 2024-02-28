﻿using DevExpress.Data.Async.Helpers;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	public partial class UI_Wilayah : GridInput {
		public UI_Wilayah() { 
			InitializeComponent();
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(Wilayah.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
		}

		public override InputBase GetDialogForm() { return new UI_WilayahDialog(); }
		public override List<GridDeletedData> GetKeteranganHapus(int[] selectedRows) {
			var result = new List<GridDeletedData>();
			GridDeletedData item;

			for (int i = selectedRows.GetLowerBound(0); i <= selectedRows.GetUpperBound(0); i++) {
				if (!xGridView.IsGroupRow(selectedRows[i])) {
					item = new GridDeletedData() {
						Row = selectedRows[i],
						Data = string.Format("{0}",
							xGridView.GetRowCellValue(selectedRows[i], nameof(Wilayah.Nama)))
					};
					result.Add(item);
				}
			}
			return result;
		}
		public override bool HapusData(List<GridDeletedData> selectedData) {
			var service = new WilayahService(session);
			List<Wilayah> deleted = new List<Wilayah>();

			foreach (var x in selectedData) {
				if (!xGridView.IsGroupRow(x.Row)) {
					deleted.Add((Wilayah)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(x.Row)).OriginalRow);
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
