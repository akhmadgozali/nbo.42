﻿using DevExpress.Data.Async.Helpers;
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

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	public partial class UI_SPKL: GridInput
	{
		public UI_SPKL()
		{
			InitializeComponent();
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(SPKL.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
		}
		public override InputBase GetDialogForm() { return new UI_SPKLDialog(); }
	}
}
