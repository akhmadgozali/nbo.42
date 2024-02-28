using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_ReturDialog : InputDialog {
		public UI_ReturDialog() {
			InitializeComponent();
			xGridView.ShownEditor += new EventHandler(View_ShownEditor);
			AutoCloseOnSave = true;
		}
		private SirkulasiAgen item;

		private void DisableControl() {
			EnableVisibleSaveButton(false, true);

			colRetur.OptionsColumn.AllowEdit = false;
			colRetur.OptionsColumn.ReadOnly = true;
			colRetur.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
		}
		private void View_ShownEditor(object sender, System.EventArgs e) {
			GridView view = (GridView)sender;
			if (view.FocusedColumn == colRetur && view.ActiveEditor.GetType() == typeof(SpinEdit))
			{
				SpinEdit edit = (SpinEdit)view.ActiveEditor;
				int konsi = (int)view.GetRowCellValue(xGridView.FocusedRowHandle, colKonsiTotal);
				edit.Properties.MaxValue = konsi;
			}
		}

		public override void InitializeData() {
			if (Tipe == InputType.Edit) {
				item = session.GetObjectByKey<SirkulasiAgen>(Convert.ToUInt64(IdToEdit));

				Text = "Retur Koran";
				txtAgen.Text = item.Agen.Kode + " - " + item.Agen.Nama;
				txtPeriode.Text = item.Tanggal.ToString("MMMM yyyy");
				xGrid.DataSource = SirkulasiHarianService.GetMutasiPerAgen(session, item);

				// cek disable
				if (SirkulasiHarianService.CheckIsInUse(session, item.Tanggal)) DisableControl();
			}
		}
		public override void SimpanData() {
			SirkulasiHarianService.SaveMutasiPerAgen(session, item, (List<SirkulasiHarianDetail>)xGrid.DataSource);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinExceptionBox();
		}
	}
}
