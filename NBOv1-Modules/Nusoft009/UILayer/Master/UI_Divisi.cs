using DevExpress.Data.Async.Helpers;
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

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Master
{
	public partial class UI_Divisi : GridInput	{
		public UI_Divisi() {
			InitializeComponent();
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(Divisi.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
		}
		//public override InputBase GetDialogForm() { return new UI_AgenDialog(); }
		public override List<GridDeletedData> GetKeteranganHapus(int[] selectedRows)
		{
			var result = new List<GridDeletedData>();
			GridDeletedData item;

			for (int i = selectedRows.GetLowerBound(0); i <= selectedRows.GetUpperBound(0); i++)
			{
				if (!xGridView.IsGroupRow(selectedRows[i]))
				{
					item = new GridDeletedData()
					{
						Row = selectedRows[i],
						Data = string.Format("{0}\r\n",
							xGridView.GetRowCellValue(selectedRows[i], nameof(Divisi.Kode)))
					};
					result.Add(item);
				}
			}
			return result;
		}
		public override bool HapusData(List<GridDeletedData> selectedData)
		{
			var service = new DivisiService(session);
			List<Divisi> deleted = new List<Divisi>();

			foreach (var x in selectedData)
			{
				if (!xGridView.IsGroupRow(x.Row))
				{
					deleted.Add((Divisi)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(x.Row)).OriginalRow);
				}
			}

			try
			{
				return service.Delete(deleted);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}
		}

	}
}
