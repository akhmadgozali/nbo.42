namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data {
	partial class UI_RekapOmzet
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
			this.fieldOmzetKonsi = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldBruto = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOmzetJatah = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRetur = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldWilayah = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldAgen = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRegional = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOmzetDikurangiRetur = new DevExpress.XtraPivotGrid.PivotGridField();
			this.nChart = new DevExpress.XtraCharts.ChartControl();
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
			this.xpCol.DisplayableProperties = "Id;OmzetJatah;OmzetKonsi;Omzet;OmzetRetur;OmzetDikurangiRetur;Agen.Nama;Agen.Rute" +
    ".KodeNama;Agen.Rute.Regional.Nama;Main.Minggu;Main.Tanggal";
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
            this.fieldBulan,
            this.fieldTahun,
            this.fieldMainMinggu,
            this.fieldMainTanggal,
            this.fieldOmzetJatah,
            this.fieldOmzetKonsi,
            this.fieldBruto,
            this.fieldRetur,
            this.fieldWilayah,
            this.fieldAgen,
            this.fieldRegional,
            this.fieldOmzetDikurangiRetur});
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
			this.fieldMainMinggu.UnboundFieldName = "fieldMinggu";
			this.fieldMainMinggu.Visible = false;
			// 
			// fieldMainTanggal
			// 
			this.fieldMainTanggal.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
			this.fieldMainTanggal.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldMainTanggal.AreaIndex = 3;
			this.fieldMainTanggal.Caption = "Tanggal";
			this.fieldMainTanggal.FieldName = "Main.Tanggal";
			this.fieldMainTanggal.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
			this.fieldMainTanggal.Name = "fieldMainTanggal";
			this.fieldMainTanggal.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldMainTanggal.UnboundFieldName = "fieldTanggal";
			this.fieldMainTanggal.Visible = false;
			// 
			// fieldOmzetKonsi
			// 
			this.fieldOmzetKonsi.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldOmzetKonsi.AreaIndex = 1;
			this.fieldOmzetKonsi.Caption = "Konsi";
			this.fieldOmzetKonsi.CellFormat.FormatString = "n0";
			this.fieldOmzetKonsi.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldOmzetKonsi.FieldName = "OmzetKonsi";
			this.fieldOmzetKonsi.Name = "fieldOmzetKonsi";
			// 
			// fieldBruto
			// 
			this.fieldBruto.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldBruto.AreaIndex = 2;
			this.fieldBruto.Caption = "Bruto";
			this.fieldBruto.CellFormat.FormatString = "n0";
			this.fieldBruto.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldBruto.FieldName = "Omzet";
			this.fieldBruto.Name = "fieldBruto";
			// 
			// fieldOmzetJatah
			// 
			this.fieldOmzetJatah.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldOmzetJatah.AreaIndex = 0;
			this.fieldOmzetJatah.Caption = "Jatah";
			this.fieldOmzetJatah.CellFormat.FormatString = "n0";
			this.fieldOmzetJatah.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldOmzetJatah.FieldName = "OmzetJatah";
			this.fieldOmzetJatah.Name = "fieldOmzetJatah";
			// 
			// fieldRetur
			// 
			this.fieldRetur.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldRetur.AreaIndex = 3;
			this.fieldRetur.Caption = "Retur";
			this.fieldRetur.CellFormat.FormatString = "n0";
			this.fieldRetur.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldRetur.FieldName = "OmzetRetur";
			this.fieldRetur.Name = "fieldRetur";
			// 
			// fieldWilayah
			// 
			this.fieldWilayah.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldWilayah.AreaIndex = 0;
			this.fieldWilayah.Caption = "Rute";
			this.fieldWilayah.FieldName = "Agen.Rute.KodeNama";
			this.fieldWilayah.Name = "fieldWilayah";
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
			// fieldRegional
			// 
			this.fieldRegional.AreaIndex = 0;
			this.fieldRegional.Caption = "Regional";
			this.fieldRegional.FieldName = "Agen.Rute.Regional.Nama";
			this.fieldRegional.Name = "fieldRegional";
			// 
			// fieldOmzetDikurangiRetur
			// 
			this.fieldOmzetDikurangiRetur.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldOmzetDikurangiRetur.AreaIndex = 4;
			this.fieldOmzetDikurangiRetur.Caption = "Netto";
			this.fieldOmzetDikurangiRetur.CellFormat.FormatString = "n0";
			this.fieldOmzetDikurangiRetur.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldOmzetDikurangiRetur.FieldName = "OmzetDikurangiRetur";
			this.fieldOmzetDikurangiRetur.Name = "fieldOmzetDikurangiRetur";
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
			this.nChart.TabIndex = 16;
			chartTitle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartTitle1.Text = "Rekap Omzet";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// UI_RekapOmzet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 471);
			this.Name = "UI_RekapOmzet";
			this.Text = "Rekap Omzet";
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
		private DevExpress.XtraPivotGrid.PivotGridField fieldOmzetJatah;
		private DevExpress.XtraPivotGrid.PivotGridField fieldOmzetKonsi;
		private DevExpress.XtraPivotGrid.PivotGridField fieldBruto;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRetur;
		private DevExpress.XtraPivotGrid.PivotGridField fieldWilayah;
		private DevExpress.XtraPivotGrid.PivotGridField fieldAgen;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRegional;
		private DevExpress.XtraPivotGrid.PivotGridField fieldOmzetDikurangiRetur;
		private DevExpress.XtraPivotGrid.PivotGridField fieldMainTanggal;
		private DevExpress.XtraPivotGrid.PivotGridField fieldMainMinggu;
		internal DevExpress.XtraCharts.ChartControl nChart;
	}
}
