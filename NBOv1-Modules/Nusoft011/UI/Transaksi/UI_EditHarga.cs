using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_EditHarga : GridInput {
		public UI_EditHarga() { 
			InitializeComponent(); 
			allowDelete = false;
			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(EditHarga.Id);
			useFeedbackSource = true;
			useMDIforDialog = true;
			UseDbSystem = false;
		}
		public override InputBase GetDialogForm() { return new UI_EditHargaDialog(); }
	}
}
