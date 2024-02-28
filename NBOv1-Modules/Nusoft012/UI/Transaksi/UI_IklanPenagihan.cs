using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	public partial class UI_IklanPenagihan : GridInput {
		public UI_IklanPenagihan() {
			InitializeComponent();
			allowAdd = false; 
			allowDelete = false;
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(Invoice.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
		}

		public override InputBase GetDialogForm() { return new UI_IklanPenagihanDialog(); }
	}
}
