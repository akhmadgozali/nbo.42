namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan
{
	partial class UI_RincianUmurPiutang
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
			this.colUmurPiutang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPemasang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTipeInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOmzet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTerbayar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPiutang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUmur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJatuhTempo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtPeriodeEdit = new DevExpress.XtraBars.BarEditItem();
			this.txtPeriode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
			this.SuspendLayout();
			// 
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtPeriodeEdit});
			this.barMan.MaxItemId = 23;
			this.barMan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPeriode});
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUmurPiutang,
            this.colNoInvoice,
            this.colTanggal,
            this.colJatuhTempo,
            this.colWilayah,
            this.colPemasang,
            this.colSales,
            this.colTipeInvoice,
            this.colOmzet,
            this.colTerbayar,
            this.colPiutang,
            this.colUmur});
			this.xGridView.GroupCount = 1;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Piutang", null, "| Piutang : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUmurPiutang, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtPeriodeEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colUmurPiutang
			// 
			this.colUmurPiutang.Caption = "Umur Piutang";
			this.colUmurPiutang.FieldName = "KelompokUmurPiutang";
			this.colUmurPiutang.Name = "colUmurPiutang";
			this.colUmurPiutang.Visible = true;
			this.colUmurPiutang.VisibleIndex = 0;
			// 
			// colNoInvoice
			// 
			this.colNoInvoice.Caption = "No. Invoice";
			this.colNoInvoice.FieldName = "NoInvoice";
			this.colNoInvoice.Name = "colNoInvoice";
			this.colNoInvoice.Visible = true;
			this.colNoInvoice.VisibleIndex = 0;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 1;
			// 
			// colWilayah
			// 
			this.colWilayah.Caption = "Wilayah";
			this.colWilayah.FieldName = "Wilayah";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 3;
			// 
			// colPemasang
			// 
			this.colPemasang.Caption = "Pemasang";
			this.colPemasang.FieldName = "Pemasang";
			this.colPemasang.Name = "colPemasang";
			this.colPemasang.Visible = true;
			this.colPemasang.VisibleIndex = 4;
			// 
			// colSales
			// 
			this.colSales.Caption = "Sales";
			this.colSales.FieldName = "Sales";
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 5;
			// 
			// colTipeInvoice
			// 
			this.colTipeInvoice.Caption = "Tipe Invoice";
			this.colTipeInvoice.FieldName = "TipeInvoice";
			this.colTipeInvoice.Name = "colTipeInvoice";
			this.colTipeInvoice.Visible = true;
			this.colTipeInvoice.VisibleIndex = 6;
			// 
			// colOmzet
			// 
			this.colOmzet.Caption = "Omzet";
			this.colOmzet.DisplayFormat.FormatString = "n0";
			this.colOmzet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOmzet.FieldName = "Omzet";
			this.colOmzet.Name = "colOmzet";
			this.colOmzet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Omzet", "{0:n0}")});
			this.colOmzet.Visible = true;
			this.colOmzet.VisibleIndex = 7;
			// 
			// colTerbayar
			// 
			this.colTerbayar.Caption = "Terbayar";
			this.colTerbayar.DisplayFormat.FormatString = "n0";
			this.colTerbayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTerbayar.FieldName = "Terbayar";
			this.colTerbayar.Name = "colTerbayar";
			this.colTerbayar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Terbayar", "{0:n0}")});
			this.colTerbayar.Visible = true;
			this.colTerbayar.VisibleIndex = 8;
			// 
			// colPiutang
			// 
			this.colPiutang.Caption = "Piutang";
			this.colPiutang.DisplayFormat.FormatString = "n0";
			this.colPiutang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPiutang.FieldName = "Piutang";
			this.colPiutang.Name = "colPiutang";
			this.colPiutang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Piutang", "{0:n0}")});
			this.colPiutang.Visible = true;
			this.colPiutang.VisibleIndex = 9;
			// 
			// colUmur
			// 
			this.colUmur.Caption = "Umur";
			this.colUmur.DisplayFormat.FormatString = "n0";
			this.colUmur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colUmur.FieldName = "UmurPiutang";
			this.colUmur.Name = "colUmur";
			this.colUmur.Visible = true;
			this.colUmur.VisibleIndex = 10;
			// 
			// colJatuhTempo
			// 
			this.colJatuhTempo.Caption = "Jatuh Tempo";
			this.colJatuhTempo.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colJatuhTempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colJatuhTempo.FieldName = "JatuhTempo";
			this.colJatuhTempo.Name = "colJatuhTempo";
			this.colJatuhTempo.Visible = true;
			this.colJatuhTempo.VisibleIndex = 2;
			// 
			// txtPeriodeEdit
			// 
			this.txtPeriodeEdit.Caption = "Periode :  ";
			this.txtPeriodeEdit.Edit = this.txtPeriode;
			this.txtPeriodeEdit.Id = 22;
			this.txtPeriodeEdit.Name = "txtPeriodeEdit";
			this.txtPeriodeEdit.Width = 159;
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
			// UI_RincianUmurPiutang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_RincianUmurPiutang";
			this.Text = "Rincian Umur Piutang";
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
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Columns.GridColumn colUmurPiutang;
		private DevExpress.XtraGrid.Columns.GridColumn colNoInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colPemasang;
		private DevExpress.XtraGrid.Columns.GridColumn colSales;
		private DevExpress.XtraGrid.Columns.GridColumn colTipeInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colOmzet;
		private DevExpress.XtraGrid.Columns.GridColumn colTerbayar;
		private DevExpress.XtraGrid.Columns.GridColumn colPiutang;
		private DevExpress.XtraGrid.Columns.GridColumn colUmur;
		private DevExpress.XtraGrid.Columns.GridColumn colJatuhTempo;
		private DevExpress.XtraBars.BarEditItem txtPeriodeEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit txtPeriode;
	}
}
