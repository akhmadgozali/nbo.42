namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data
{
	partial class UI_RincianOplah
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
			this.colKonsi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGratis = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJatah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOplah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRetur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOplahNetto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.ifSource.DisplayableProperties = "Id;Main.Tanggal;Main.Tahun;Main.Bulan;Main.Minggu;Agen.Rute.KodeNama;Agen.Kode;Ag" +
    "en.Nama;Retur;Jatah;Konsi;Gratis;Oplah;OplahDikurangiRetur";
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
            this.colJatah,
            this.colKonsi,
            this.colGratis,
            this.colOplah,
            this.colRetur,
            this.colOplahNetto});
			this.xGridView.GroupCount = 4;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jatah", null, "| Jatah : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Konsi", null, "| Konsi : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gratis", null, "| Gratis : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", null, "| Oplah Bruto : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Retur", null, "| Retur : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OplahDikurangiRetur", null, "| Oplah Netto : {0:n0}")});
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
			// colKonsi
			// 
			this.colKonsi.DisplayFormat.FormatString = "n0";
			this.colKonsi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsi.FieldName = "Konsi";
			this.colKonsi.Name = "colKonsi";
			this.colKonsi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Konsi", "{0:n0}")});
			this.colKonsi.Visible = true;
			this.colKonsi.VisibleIndex = 2;
			this.colKonsi.Width = 84;
			// 
			// colGratis
			// 
			this.colGratis.DisplayFormat.FormatString = "n0";
			this.colGratis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colGratis.FieldName = "Gratis";
			this.colGratis.Name = "colGratis";
			this.colGratis.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gratis", "{0:n0}")});
			this.colGratis.Visible = true;
			this.colGratis.VisibleIndex = 3;
			this.colGratis.Width = 84;
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
			// colJatah
			// 
			this.colJatah.Caption = "Jatah";
			this.colJatah.DisplayFormat.FormatString = "n0";
			this.colJatah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJatah.FieldName = "Jatah";
			this.colJatah.Name = "colJatah";
			this.colJatah.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jatah", "{0:n0}")});
			this.colJatah.Visible = true;
			this.colJatah.VisibleIndex = 1;
			this.colJatah.Width = 84;
			// 
			// colOplah
			// 
			this.colOplah.Caption = "Oplah Bruto";
			this.colOplah.DisplayFormat.FormatString = "n0";
			this.colOplah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOplah.FieldName = "Oplah";
			this.colOplah.Name = "colOplah";
			this.colOplah.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", "{0:n0}")});
			this.colOplah.Visible = true;
			this.colOplah.VisibleIndex = 4;
			this.colOplah.Width = 73;
			// 
			// colRetur
			// 
			this.colRetur.Caption = "Retur";
			this.colRetur.DisplayFormat.FormatString = "n0";
			this.colRetur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRetur.FieldName = "Retur";
			this.colRetur.Name = "colRetur";
			this.colRetur.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Retur", "{0:n0}")});
			this.colRetur.Visible = true;
			this.colRetur.VisibleIndex = 5;
			this.colRetur.Width = 66;
			// 
			// colOplahNetto
			// 
			this.colOplahNetto.Caption = "Oplah Netto";
			this.colOplahNetto.DisplayFormat.FormatString = "n0";
			this.colOplahNetto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOplahNetto.FieldName = "OplahDikurangiRetur";
			this.colOplahNetto.Name = "colOplahNetto";
			this.colOplahNetto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OplahDikurangiRetur", "{0:n0}")});
			this.colOplahNetto.Visible = true;
			this.colOplahNetto.VisibleIndex = 6;
			this.colOplahNetto.Width = 73;
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
			this.colTanggal.Width = 104;
			// 
			// UI_RincianOplah
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 404);
			this.Name = "UI_RincianOplah";
			this.Text = "Rincian Oplah";
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
		private DevExpress.XtraGrid.Columns.GridColumn colJatah;
		private DevExpress.XtraGrid.Columns.GridColumn colKonsi;
		private DevExpress.XtraGrid.Columns.GridColumn colGratis;
		private DevExpress.XtraGrid.Columns.GridColumn colOplah;
		private DevExpress.XtraGrid.Columns.GridColumn colRetur;
		private DevExpress.XtraGrid.Columns.GridColumn colOplahNetto;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
	}
}
