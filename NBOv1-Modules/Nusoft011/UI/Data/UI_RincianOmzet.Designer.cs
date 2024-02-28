namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data
{
	partial class UI_RincianOmzet
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
			this.colAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRute = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOmzetKonsi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOmzetJatah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRetur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBruto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNetto = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).BeginInit();
			this.SuspendLayout();
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Id;Main.Tanggal;Main.Tahun;Main.Bulan;Main.Minggu;Agen.Rute.KodeNama;Agen.Nama;Om" +
    "zetJatah;OmzetKonsi;Omzet;OmzetRetur;OmzetDikurangiRetur";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.SirkulasiHarianDetail);
			// 
			// xGrid
			// 
			this.xGrid.DataSource = this.ifSource;
			this.xGrid.Size = new System.Drawing.Size(880, 212);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colRute,
            this.colAgen,
            this.colTanggal,
            this.colOmzetJatah,
            this.colOmzetKonsi,
            this.colBruto,
            this.colRetur,
            this.colNetto});
			this.xGridView.GroupCount = 4;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetJatah", null, "| Jatah : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetKonsi", null, "| Konsi : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Omzet", null, "| Bruto : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetRetur", null, "| Retur : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetDikurangiRetur", null, "| Netto : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRute, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAgen, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// SplitContainerControl1
			// 
			this.SplitContainerControl1.Size = new System.Drawing.Size(880, 377);
			// 
			// colAgen
			// 
			this.colAgen.Caption = "Agen";
			this.colAgen.FieldName = "Agen.Nama";
			this.colAgen.Name = "colAgen";
			this.colAgen.Visible = true;
			this.colAgen.VisibleIndex = 0;
			this.colAgen.Width = 170;
			// 
			// colRute
			// 
			this.colRute.Caption = "Rute";
			this.colRute.FieldName = "Agen.Rute.KodeNama";
			this.colRute.Name = "colRute";
			this.colRute.Visible = true;
			this.colRute.VisibleIndex = 1;
			// 
			// colOmzetKonsi
			// 
			this.colOmzetKonsi.Caption = "Konsi";
			this.colOmzetKonsi.DisplayFormat.FormatString = "n0";
			this.colOmzetKonsi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOmzetKonsi.FieldName = "OmzetKonsi";
			this.colOmzetKonsi.Name = "colOmzetKonsi";
			this.colOmzetKonsi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetKonsi", "{0:n0}")});
			this.colOmzetKonsi.Visible = true;
			this.colOmzetKonsi.VisibleIndex = 2;
			this.colOmzetKonsi.Width = 115;
			// 
			// colTahun
			// 
			this.colTahun.Caption = "Tahun";
			this.colTahun.FieldName = "Main.Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 4;
			// 
			// colBulan
			// 
			this.colBulan.Caption = "Bulan";
			this.colBulan.DisplayFormat.FormatString = "MMMM";
			this.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.FieldName = "Main.Bulan";
			this.colBulan.GroupFormat.FormatString = "MMMM";
			this.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.Name = "colBulan";
			this.colBulan.Visible = true;
			this.colBulan.VisibleIndex = 4;
			// 
			// colOmzetJatah
			// 
			this.colOmzetJatah.Caption = "Jatah";
			this.colOmzetJatah.DisplayFormat.FormatString = "n0";
			this.colOmzetJatah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOmzetJatah.FieldName = "OmzetJatah";
			this.colOmzetJatah.Name = "colOmzetJatah";
			this.colOmzetJatah.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetJatah", "{0:n0}")});
			this.colOmzetJatah.Visible = true;
			this.colOmzetJatah.VisibleIndex = 1;
			this.colOmzetJatah.Width = 115;
			// 
			// colRetur
			// 
			this.colRetur.Caption = "Retur";
			this.colRetur.DisplayFormat.FormatString = "n0";
			this.colRetur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRetur.FieldName = "OmzetRetur";
			this.colRetur.Name = "colRetur";
			this.colRetur.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetRetur", "{0:n0}")});
			this.colRetur.Visible = true;
			this.colRetur.VisibleIndex = 4;
			this.colRetur.Width = 90;
			// 
			// colBruto
			// 
			this.colBruto.Caption = "Bruto";
			this.colBruto.DisplayFormat.FormatString = "n0";
			this.colBruto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colBruto.FieldName = "Omzet";
			this.colBruto.Name = "colBruto";
			this.colBruto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Omzet", "{0:n0}")});
			this.colBruto.Visible = true;
			this.colBruto.VisibleIndex = 3;
			this.colBruto.Width = 115;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Main.Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 0;
			this.colTanggal.Width = 138;
			// 
			// colNetto
			// 
			this.colNetto.Caption = "Netto";
			this.colNetto.DisplayFormat.FormatString = "n0";
			this.colNetto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colNetto.FieldName = "OmzetDikurangiRetur";
			this.colNetto.Name = "colNetto";
			this.colNetto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetDikurangiRetur", "{0:n0}")});
			this.colNetto.Visible = true;
			this.colNetto.VisibleIndex = 5;
			this.colNetto.Width = 123;
			// 
			// UI_RincianOmzet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 404);
			this.Name = "UI_RincianOmzet";
			this.Text = "Rincian Omzet";
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
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colRute;
		private DevExpress.XtraGrid.Columns.GridColumn colAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colOmzetJatah;
		private DevExpress.XtraGrid.Columns.GridColumn colOmzetKonsi;
		private DevExpress.XtraGrid.Columns.GridColumn colRetur;
		private DevExpress.XtraGrid.Columns.GridColumn colBruto;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colNetto;
	}
}
