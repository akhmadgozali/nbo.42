using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Utility {
	public partial class UI_EditTanggalTerbit : GridInput {
		public UI_EditTanggalTerbit() { 
			InitializeComponent();
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(Invoice.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
			allowAdd = false; 
			allowDelete = false; 
		}

		public override InputBase GetDialogForm() { return new UI_EditTanggalTerbitDialog(); }
	}
}
