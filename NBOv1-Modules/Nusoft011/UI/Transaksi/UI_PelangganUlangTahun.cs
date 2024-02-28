using DevExpress.Data.Filtering;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_PelangganUlangTahun : GridInput {
		public UI_PelangganUlangTahun() {
			InitializeComponent();
			allowAdd = false;
			allowEdit = false;
			allowDelete = false;
			txtBulan.SelectedIndexChanged += new EventHandler(BulanChanged);

			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(Pelanggan.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
		}

		public override void FirstLoad() {
			base.FirstLoad();
			txtBulan.Properties.Items.Clear();
			for (int i = 1; i <= 12; i++) {
				txtBulan.Properties.Items.Add((new DateTime(DateTime.Now.Year, i, 1)).ToString("MMMM"));
			}
			txtBulan.SelectedIndex = DateTime.Now.Month - 1;
		}
		private void BulanChanged(object sender, EventArgs e) {
			xGridView.ActiveFilterCriteria = new BinaryOperator(nameof(Pelanggan.BulanLahir), txtBulan.SelectedIndex + 1, BinaryOperatorType.Equal);
		}
	}
}
