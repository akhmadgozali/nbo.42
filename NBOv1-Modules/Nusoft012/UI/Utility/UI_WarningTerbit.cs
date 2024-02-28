using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Utility {
	public partial class UI_WarningTerbit : GridOutput {
		public UI_WarningTerbit() { 
			InitializeComponent();
			showChart = false;
			showFilter = false;
			useFeedbackSource = false;
		}
		public override void FirstLoad() {
			GetSession();
			RefreshData();
		}
		public override void RefreshData() {
			xGrid.DataSource = InvoiceService.GetWarningTerbit(session);
		}
	}
}
