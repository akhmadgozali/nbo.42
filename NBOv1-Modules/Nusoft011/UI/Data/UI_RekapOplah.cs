using NuSoft.Core.Win.Forms;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data {
	public partial class UI_RekapOplah : PivotOutput {
		public UI_RekapOplah() {
			InitializeComponent();
			xChart = nChart;
			showChart = true;
			showFilter = false;
		}

		public override void FirstLoad() {
			xPivot.CollapseAll();
			xPivot.ExpandValueAsync(true, new object[] { DateTime.Now.Year });
		}
	}
}