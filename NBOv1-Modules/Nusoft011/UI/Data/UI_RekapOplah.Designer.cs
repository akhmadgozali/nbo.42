namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data { 
	partial class UI_RekapOplah
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
			DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
			this.fieldTahun = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldBulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldMainMinggu = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldMainTanggal = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldKonsi = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldGratis = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldJatah = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOplah = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRetur = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOplahDikurangiRetur = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRute = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldAgen = new DevExpress.XtraPivotGrid.PivotGridField();
			this.nChart = new DevExpress.XtraCharts.ChartControl();
			this.fieldRegional = new DevExpress.XtraPivotGrid.PivotGridField();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xPivot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// xpCol
			// 
			this.xpCol.DisplayableProperties = "Id;Main.Tanggal;Agen.Nama;Retur;Jatah;Konsi;Gratis;Oplah;OplahDikurangiRetur;Agen" +
    ".Rute.Nama;Main.Minggu;Agen.Rute.Regional.Nama";
			this.xpCol.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.SirkulasiHarianDetail);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// SplitContainerControl1
			// 
			this.SplitContainerControl1.Panel2.Controls.Add(this.nChart);
			this.SplitContainerControl1.Size = new System.Drawing.Size(858, 444);
			// 
			// xPivot
			// 
			this.xPivot.DataSource = this.xpCol;
			this.xPivot.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldTahun,
            this.fieldBulan,
            this.fieldMainMinggu,
            this.fieldMainTanggal,
            this.fieldJatah,
            this.fieldKonsi,
            this.fieldGratis,
            this.fieldOplah,
            this.fieldRetur,
            this.fieldOplahDikurangiRetur,
            this.fieldRute,
            this.fieldAgen,
            this.fieldRegional});
			pivotGridGroup1.Fields.Add(this.fieldTahun);
			pivotGridGroup1.Fields.Add(this.fieldBulan);
			pivotGridGroup1.Fields.Add(this.fieldMainMinggu);
			pivotGridGroup1.Fields.Add(this.fieldMainTanggal);
			pivotGridGroup1.Hierarchy = null;
			pivotGridGroup1.ShowNewValues = true;
			this.xPivot.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
			this.xPivot.OptionsChartDataSource.ProvideDataByColumns = false;
			this.xPivot.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
			this.xPivot.OptionsView.RowTreeWidth = 200;
			this.xPivot.Size = new System.Drawing.Size(858, 212);
			// 
			// fieldTahun
			// 
			this.fieldTahun.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
			this.fieldTahun.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldTahun.AreaIndex = 0;
			this.fieldTahun.Caption = "Tahun";
			this.fieldTahun.FieldName = "Main.Tanggal";
			this.fieldTahun.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldTahun.Name = "fieldTahun";
			this.fieldTahun.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldTahun.UnboundFieldName = "fieldTahun";
			// 
			// fieldBulan
			// 
			this.fieldBulan.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
			this.fieldBulan.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldBulan.AreaIndex = 1;
			this.fieldBulan.Caption = "Bulan";
			this.fieldBulan.ExpandedInFieldsGroup = false;
			this.fieldBulan.FieldName = "Main.Tanggal";
			this.fieldBulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldBulan.Name = "fieldBulan";
			this.fieldBulan.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldBulan.UnboundFieldName = "fieldBulan";
			// 
			// fieldMainMinggu
			// 
			this.fieldMainMinggu.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
			this.fieldMainMinggu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldMainMinggu.AreaIndex = 2;
			this.fieldMainMinggu.Caption = "Minggu";
			this.fieldMainMinggu.ExpandedInFieldsGroup = false;
			this.fieldMainMinggu.FieldName = "Main.Minggu";
			this.fieldMainMinggu.Name = "fieldMainMinggu";
			this.fieldMainMinggu.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldMainMinggu.Visible = false;
			// 
			// fieldMainTanggal
			// 
			this.fieldMainTanggal.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
			this.fieldMainTanggal.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldMainTanggal.AreaIndex = 2;
			this.fieldMainTanggal.Caption = "Tanggal";
			this.fieldMainTanggal.FieldName = "Main.Tanggal";
			this.fieldMainTanggal.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
			this.fieldMainTanggal.Name = "fieldMainTanggal";
			this.fieldMainTanggal.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldMainTanggal.UnboundFieldName = "fieldTanggal";
			this.fieldMainTanggal.Visible = false;
			// 
			// fieldKonsi
			// 
			this.fieldKonsi.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldKonsi.AreaIndex = 1;
			this.fieldKonsi.CellFormat.FormatString = "n0";
			this.fieldKonsi.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldKonsi.FieldName = "Konsi";
			this.fieldKonsi.Name = "fieldKonsi";
			this.fieldKonsi.Width = 50;
			// 
			// fieldGratis
			// 
			this.fieldGratis.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldGratis.AreaIndex = 2;
			this.fieldGratis.CellFormat.FormatString = "n0";
			this.fieldGratis.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldGratis.FieldName = "Gratis";
			this.fieldGratis.Name = "fieldGratis";
			this.fieldGratis.Width = 50;
			// 
			// fieldJatah
			// 
			this.fieldJatah.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldJatah.AreaIndex = 0;
			this.fieldJatah.Caption = "Jatah";
			this.fieldJatah.CellFormat.FormatString = "n0";
			this.fieldJatah.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldJatah.FieldName = "Jatah";
			this.fieldJatah.Name = "fieldJatah";
			this.fieldJatah.Width = 65;
			// 
			// fieldOplah
			// 
			this.fieldOplah.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldOplah.AreaIndex = 3;
			this.fieldOplah.Caption = "Oplah Bruto";
			this.fieldOplah.CellFormat.FormatString = "n0";
			this.fieldOplah.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldOplah.FieldName = "Oplah";
			this.fieldOplah.Name = "fieldOplah";
			this.fieldOplah.Width = 80;
			// 
			// fieldRetur
			// 
			this.fieldRetur.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldRetur.AreaIndex = 4;
			this.fieldRetur.Caption = "Retur";
			this.fieldRetur.CellFormat.FormatString = "n0";
			this.fieldRetur.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldRetur.FieldName = "Retur";
			this.fieldRetur.Name = "fieldRetur";
			this.fieldRetur.Width = 50;
			// 
			// fieldOplahDikurangiRetur
			// 
			this.fieldOplahDikurangiRetur.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldOplahDikurangiRetur.AreaIndex = 5;
			this.fieldOplahDikurangiRetur.Caption = "Oplah Netto";
			this.fieldOplahDikurangiRetur.CellFormat.FormatString = "n0";
			this.fieldOplahDikurangiRetur.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldOplahDikurangiRetur.FieldName = "OplahDikurangiRetur";
			this.fieldOplahDikurangiRetur.Name = "fieldOplahDikurangiRetur";
			this.fieldOplahDikurangiRetur.Width = 72;
			// 
			// fieldRute
			// 
			this.fieldRute.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldRute.AreaIndex = 0;
			this.fieldRute.Caption = "Rute";
			this.fieldRute.FieldName = "Agen.Rute.Nama";
			this.fieldRute.Name = "fieldRute";
			// 
			// fieldAgen
			// 
			this.fieldAgen.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldAgen.AreaIndex = 1;
			this.fieldAgen.Caption = "Agen";
			this.fieldAgen.ExpandedInFieldsGroup = false;
			this.fieldAgen.FieldName = "Agen.Nama";
			this.fieldAgen.Name = "fieldAgen";
			// 
			// nChart
			// 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			this.nChart.Diagram = xyDiagram1;
			this.nChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nChart.EmptyChartText.Text = "Data Kosong";
			this.nChart.Location = new System.Drawing.Point(0, 0);
			this.nChart.Name = "nChart";
			series1.ArgumentDataMember = "Kode";
			pointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
			pointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
			pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
			pointOptions1.ValueNumericOptions.Precision = 0;
			series1.LegendPointOptions = pointOptions1;
			series1.LegendText = "Legend";
			series1.Name = "SeriesJali";
			series1.SynchronizePointOptions = false;
			series1.ValueDataMembersSerializable = "SisaSaldo";
			sideBySideBarSeriesView1.ColorEach = true;
			series1.View = sideBySideBarSeriesView1;
			this.nChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.nChart.Size = new System.Drawing.Size(858, 227);
			this.nChart.TabIndex = 15;
			chartTitle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartTitle1.Text = "Rekap Oplah";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// fieldRegional
			// 
			this.fieldRegional.AreaIndex = 0;
			this.fieldRegional.Caption = "Regional";
			this.fieldRegional.FieldName = "Agen.Rute.Regional.Nama";
			this.fieldRegional.Name = "fieldRegional";
			// 
			// UI_RekapOplah
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 471);
			this.Name = "UI_RekapOplah";
			this.Text = "Rekap Oplah";
			this.xpCol = this.xpCol;
			((System.ComponentModel.ISupportInitialize)(this.barMan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xPivot)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraPivotGrid.PivotGridField fieldBulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTahun;
		private DevExpress.XtraPivotGrid.PivotGridField fieldJatah;
		private DevExpress.XtraPivotGrid.PivotGridField fieldKonsi;
		private DevExpress.XtraPivotGrid.PivotGridField fieldGratis;
		private DevExpress.XtraPivotGrid.PivotGridField fieldOplah;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRetur;
		private DevExpress.XtraPivotGrid.PivotGridField fieldOplahDikurangiRetur;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRute;
		private DevExpress.XtraPivotGrid.PivotGridField fieldAgen;
		private DevExpress.XtraPivotGrid.PivotGridField fieldMainMinggu;
		private DevExpress.XtraPivotGrid.PivotGridField fieldMainTanggal;
		internal DevExpress.XtraCharts.ChartControl nChart;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRegional;
	}
}
