using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_Retur : GridInput {
		public UI_Retur() { 
			InitializeComponent(); 
			allowAdd = false; 
			allowDelete = false;
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(SirkulasiAgen.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;
		}

		public override InputBase GetDialogForm() { return new UI_ReturDialog(); }
	}
}
