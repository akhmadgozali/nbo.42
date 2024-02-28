using NuSoft.Core.Win.Forms;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataKomisi {
	public partial class UI_RekapKomisi : PivotOutput {
		public UI_RekapKomisi() {
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
