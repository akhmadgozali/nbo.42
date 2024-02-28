namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan
{
	partial class UI_PiutangBerjalan
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPemasangSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaldoAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOmzet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPembayaran = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPiutang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUmurPiutang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtPeriodeEdit = new DevExpress.XtraBars.BarEditItem();
			this.txtPeriode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.txtPemasangSalesEdit = new DevExpress.XtraBars.BarEditItem();
			this.txtPemasangSales = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.txtTampilkanSaldoNolEdit = new DevExpress.XtraBars.BarEditItem();
			this.txtTampilkanSaldoNol = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPemasangSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTampilkanSaldoNol)).BeginInit();
			this.SuspendLayout();
			// 
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtPeriodeEdit,
            this.txtPemasangSalesEdit,
            this.txtTampilkanSaldoNolEdit});
			this.barMan.MaxItemId = 26;
			this.barMan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPeriode,
            this.txtPemasangSales,
            this.txtTampilkanSaldoNol});
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWilayah,
            this.colPemasangSales,
            this.colSaldoAwal,
            this.colOmzet,
            this.colPembayaran,
            this.colPiutang,
            this.colUmurPiutang});
			this.xGridView.GroupCount = 1;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoAwal", this.colSaldoAwal, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Omzet", this.colOmzet, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pembayaran", this.colPembayaran, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Piutang", this.colPiutang, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Piutang", null, "| Piutang : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWilayah, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtPeriodeEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtPemasangSalesEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtTampilkanSaldoNolEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colWilayah
			// 
			this.colWilayah.Caption = "Wilayah";
			this.colWilayah.FieldName = "Wilayah";
			this.colWilayah.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 0;
			// 
			// colPemasangSales
			// 
			this.colPemasangSales.Caption = "Pemasang";
			this.colPemasangSales.FieldName = "PemasangSales";
			this.colPemasangSales.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
			this.colPemasangSales.Name = "colPemasangSales";
			this.colPemasangSales.Visible = true;
			this.colPemasangSales.VisibleIndex = 0;
			this.colPemasangSales.Width = 500;
			// 
			// colSaldoAwal
			// 
			this.colSaldoAwal.AppearanceHeader.Options.UseTextOptions = true;
			this.colSaldoAwal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colSaldoAwal.Caption = "SaldoAwal";
			this.colSaldoAwal.DisplayFormat.FormatString = "n0";
			this.colSaldoAwal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSaldoAwal.FieldName = "SaldoAwal";
			this.colSaldoAwal.Name = "colSaldoAwal";
			this.colSaldoAwal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoAwal", "{0:n0}")});
			this.colSaldoAwal.Visible = true;
			this.colSaldoAwal.VisibleIndex = 1;
			this.colSaldoAwal.Width = 125;
			// 
			// colOmzet
			// 
			this.colOmzet.AppearanceHeader.Options.UseTextOptions = true;
			this.colOmzet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colOmzet.Caption = "Omzet";
			this.colOmzet.DisplayFormat.FormatString = "n0";
			this.colOmzet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOmzet.FieldName = "Omzet";
			this.colOmzet.Name = "colOmzet";
			this.colOmzet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Omzet", "{0:n0}")});
			this.colOmzet.Visible = true;
			this.colOmzet.VisibleIndex = 2;
			this.colOmzet.Width = 125;
			// 
			// colPembayaran
			// 
			this.colPembayaran.AppearanceHeader.Options.UseTextOptions = true;
			this.colPembayaran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colPembayaran.Caption = "Pembayaran";
			this.colPembayaran.DisplayFormat.FormatString = "n0";
			this.colPembayaran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPembayaran.FieldName = "Pembayaran";
			this.colPembayaran.Name = "colPembayaran";
			this.colPembayaran.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pembayaran", "{0:n0}")});
			this.colPembayaran.Visible = true;
			this.colPembayaran.VisibleIndex = 3;
			this.colPembayaran.Width = 125;
			// 
			// colPiutang
			// 
			this.colPiutang.AppearanceHeader.Options.UseTextOptions = true;
			this.colPiutang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colPiutang.Caption = "Piutang";
			this.colPiutang.DisplayFormat.FormatString = "n0";
			this.colPiutang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPiutang.FieldName = "Piutang";
			this.colPiutang.Name = "colPiutang";
			this.colPiutang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Piutang", "{0:n0}")});
			this.colPiutang.Visible = true;
			this.colPiutang.VisibleIndex = 4;
			this.colPiutang.Width = 128;
			// 
			// colUmurPiutang
			// 
			this.colUmurPiutang.Caption = "Umur";
			this.colUmurPiutang.DisplayFormat.FormatString = "n0";
			this.colUmurPiutang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colUmurPiutang.FieldName = "UmurPiutang";
			this.colUmurPiutang.Name = "colUmurPiutang";
			this.colUmurPiutang.Visible = true;
			this.colUmurPiutang.VisibleIndex = 5;
			// 
			// txtPeriodeEdit
			// 
			this.txtPeriodeEdit.Caption = "Periode :   ";
			this.txtPeriodeEdit.Edit = this.txtPeriode;
			this.txtPeriodeEdit.Id = 22;
			this.txtPeriodeEdit.Name = "txtPeriodeEdit";
			this.txtPeriodeEdit.Width = 166;
			// 
			// txtPeriode
			// 
			this.txtPeriode.AutoHeight = false;
			this.txtPeriode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtPeriode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value")});
			this.txtPeriode.DisplayMember = "Value";
			this.txtPeriode.Name = "txtPeriode";
			this.txtPeriode.NullText = "[ Pilih Periode ]";
			this.txtPeriode.ShowHeader = false;
			this.txtPeriode.ValueMember = "Key";
			// 
			// txtPemasangSalesEdit
			// 
			this.txtPemasangSalesEdit.Caption = "Tampilkan Berdasarkan : ";
			this.txtPemasangSalesEdit.Edit = this.txtPemasangSales;
			this.txtPemasangSalesEdit.Id = 24;
			this.txtPemasangSalesEdit.Name = "txtPemasangSalesEdit";
			this.txtPemasangSalesEdit.Width = 141;
			// 
			// txtPemasangSales
			// 
			this.txtPemasangSales.AutoHeight = false;
			this.txtPemasangSales.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtPemasangSales.Items.AddRange(new object[] {
            "Pemasang",
            "Sales"});
			this.txtPemasangSales.Name = "txtPemasangSales";
			this.txtPemasangSales.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			// 
			// txtTampilkanSaldoNolEdit
			// 
			this.txtTampilkanSaldoNolEdit.Caption = "Tampilkan Saldo 0  ";
			this.txtTampilkanSaldoNolEdit.Edit = this.txtTampilkanSaldoNol;
			this.txtTampilkanSaldoNolEdit.EditValue = false;
			this.txtTampilkanSaldoNolEdit.Id = 25;
			this.txtTampilkanSaldoNolEdit.Name = "txtTampilkanSaldoNolEdit";
			this.txtTampilkanSaldoNolEdit.Width = 20;
			// 
			// txtTampilkanSaldoNol
			// 
			this.txtTampilkanSaldoNol.AutoHeight = false;
			this.txtTampilkanSaldoNol.Caption = "Check";
			this.txtTampilkanSaldoNol.Name = "txtTampilkanSaldoNol";
			// 
			// UI_PiutangBerjalan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_PiutangBerjalan";
			this.Text = "Piutang Berjalan";
			this.xpCol = this.xpCol;
			((System.ComponentModel.ISupportInitialize)(this.barMan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPemasangSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTampilkanSaldoNol)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colPemasangSales;
		private DevExpress.XtraGrid.Columns.GridColumn colSaldoAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colOmzet;
		private DevExpress.XtraGrid.Columns.GridColumn colPembayaran;
		private DevExpress.XtraGrid.Columns.GridColumn colPiutang;
		private DevExpress.XtraGrid.Columns.GridColumn colUmurPiutang;
		private DevExpress.XtraBars.BarEditItem txtPeriodeEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit txtPeriode;
		private DevExpress.XtraBars.BarEditItem txtPemasangSalesEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemComboBox txtPemasangSales;
		private DevExpress.XtraBars.BarEditItem txtTampilkanSaldoNolEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit txtTampilkanSaldoNol;
	}
}
