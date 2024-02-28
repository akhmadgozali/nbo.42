﻿using NuSoft.Core.Win.Forms;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataCashback {
	public partial class UI_RekapPencairanCashback : PivotOutput {
		public UI_RekapPencairanCashback() {
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
