using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_SaldoAwalAgen : DialogForm {
		public UI_SaldoAwalAgen() { InitializeComponent(); AutoCloseOnSave = true; }

		private void CheckDisableControl() {
			bool disable;
			try { AgenService.CheckIsInUseSaldoAwal(session); disable = false; }
			catch { disable = true; }

			if (disable) {
				btn1.Visible = false;
				Btn2IsClosedButton = true;
				xGridView.OptionsBehavior.Editable = false;
				colSaldoAwal.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
				colKeterangan.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
			}
		}

		public override void InitializeData() {
			GetSession();
			xGrid.DataSource = new XPQuery<Agen>(session); 
			CheckDisableControl();
		}
		public override void Btn1Click() {
			session.CommitChanges();
		}
		public override void Btn2Click() {
			session.RollbackTransaction();
		}
	}
}