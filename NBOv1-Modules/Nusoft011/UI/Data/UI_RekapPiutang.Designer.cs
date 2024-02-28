namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data
{
	partial class UI_RekapPiutang
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
			this.fieldPembayaran = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPiutang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOmzet = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRute = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldAgen = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRegionalNama = new DevExpress.XtraPivotGrid.PivotGridField();
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
			this.xpCol.DisplayableProperties = "This;Id;Tanggal;Minggu;AgenNama;RuteKodeNama;RegionalNama;OmzetNetto;Pembayaran;P" +
    "iutang";
			this.xpCol.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.vwRekapitulasi);
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
            this.fieldOmzet,
            this.fieldPembayaran,
            this.fieldPiutang,
            this.fieldRute,
            this.fieldAgen,
            this.fieldRegionalNama});
			pivotGridGroup1.Fields.Add(this.fieldTahun);
			pivotGridGroup1.Fields.Add(this.fieldBulan);
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
			this.fieldTahun.FieldName = "Tanggal";
			this.fieldTahun.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldTahun.Name = "fieldTahun";
			this.fieldTahun.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldTahun.UnboundFieldName = "fieldTanggal";
			// 
			// fieldBulan
			// 
			this.fieldBulan.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
			this.fieldBulan.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldBulan.AreaIndex = 1;
			this.fieldBulan.Caption = "Bulan";
			this.fieldBulan.FieldName = "Tanggal";
			this.fieldBulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldBulan.Name = "fieldBulan";
			this.fieldBulan.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldBulan.UnboundFieldName = "fieldBulan";
			// 
			// fieldPembayaran
			// 
			this.fieldPembayaran.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldPembayaran.AreaIndex = 1;
			this.fieldPembayaran.Caption = "Pembayaran";
			this.fieldPembayaran.CellFormat.FormatString = "n0";
			this.fieldPembayaran.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldPembayaran.FieldName = "Pembayaran";
			this.fieldPembayaran.Name = "fieldPembayaran";
			// 
			// fieldPiutang
			// 
			this.fieldPiutang.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldPiutang.AreaIndex = 2;
			this.fieldPiutang.Caption = "Piutang";
			this.fieldPiutang.CellFormat.FormatString = "n0";
			this.fieldPiutang.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldPiutang.FieldName = "Piutang";
			this.fieldPiutang.Name = "fieldPiutang";
			// 
			// fieldOmzet
			// 
			this.fieldOmzet.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldOmzet.AreaIndex = 0;
			this.fieldOmzet.Caption = "Omzet";
			this.fieldOmzet.CellFormat.FormatString = "n0";
			this.fieldOmzet.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldOmzet.FieldName = "OmzetNetto";
			this.fieldOmzet.Name = "fieldOmzet";
			// 
			// fieldRute
			// 
			this.fieldRute.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldRute.AreaIndex = 0;
			this.fieldRute.Caption = "Rute";
			this.fieldRute.FieldName = "RuteKodeNama";
			this.fieldRute.Name = "fieldRute";
			// 
			// fieldAgen
			// 
			this.fieldAgen.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldAgen.AreaIndex = 1;
			this.fieldAgen.Caption = "Agen";
			this.fieldAgen.ExpandedInFieldsGroup = false;
			this.fieldAgen.FieldName = "AgenNama";
			this.fieldAgen.Name = "fieldAgen";
			// 
			// fieldRegionalNama
			// 
			this.fieldRegionalNama.AreaIndex = 0;
			this.fieldRegionalNama.Caption = "Regional";
			this.fieldRegionalNama.FieldName = "RegionalNama";
			this.fieldRegionalNama.Name = "fieldRegionalNama";
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
			this.nChart.TabIndex = 18;
			chartTitle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartTitle1.Text = "Rekap Piutang";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// UI_RekapPiutang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 471);
			this.Name = "UI_RekapPiutang";
			this.Text = "Rekap Piutang";
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
		private DevExpress.XtraPivotGrid.PivotGridField fieldOmzet;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPembayaran;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPiutang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRute;
		private DevExpress.XtraPivotGrid.PivotGridField fieldAgen;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRegionalNama;
		internal DevExpress.XtraCharts.ChartControl nChart;
	}
}
