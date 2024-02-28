namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataCashback
{
	partial class UI_RekapPencairanCashback
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_RekapPencairanCashback));
			DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
			DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
			DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup3 = new DevExpress.XtraPivotGrid.PivotGridGroup();
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
			this.fieldTahun = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldBulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPencairanCashbackMinggu = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPencairanCashbackTanggal = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldCashbackInvoiceWilayahRegionalNama = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldCashbackInvoiceWilayahNama = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPencairanCashbackCaraBayarAlias = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTriwulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPencairanCashbackPemasang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTotal = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldCashbackInvoiceTipeInvoiceNama = new DevExpress.XtraPivotGrid.PivotGridField();
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
			this.xpCol.DisplayableProperties = resources.GetString("xpCol.DisplayableProperties");
			this.xpCol.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.PencairanCashbackDetail);
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
			// 
			// xPivot
			// 
			this.xPivot.DataSource = this.xpCol;
			this.xPivot.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldTahun,
            this.fieldBulan,
            this.fieldPencairanCashbackMinggu,
            this.fieldPencairanCashbackTanggal,
            this.fieldTotal,
            this.fieldCashbackInvoiceWilayahRegionalNama,
            this.fieldCashbackInvoiceWilayahNama,
            this.fieldTriwulan,
            this.fieldPencairanCashbackPemasang,
            this.fieldCashbackInvoiceTipeInvoiceNama,
            this.fieldPencairanCashbackCaraBayarAlias});
			pivotGridGroup1.Fields.Add(this.fieldTahun);
			pivotGridGroup1.Fields.Add(this.fieldBulan);
			pivotGridGroup1.Fields.Add(this.fieldPencairanCashbackMinggu);
			pivotGridGroup1.Fields.Add(this.fieldPencairanCashbackTanggal);
			pivotGridGroup1.Hierarchy = null;
			pivotGridGroup1.ShowNewValues = true;
			pivotGridGroup2.Fields.Add(this.fieldCashbackInvoiceWilayahRegionalNama);
			pivotGridGroup2.Fields.Add(this.fieldCashbackInvoiceWilayahNama);
			pivotGridGroup2.Hierarchy = null;
			pivotGridGroup2.ShowNewValues = true;
			pivotGridGroup3.Hierarchy = null;
			pivotGridGroup3.ShowNewValues = true;
			this.xPivot.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2,
            pivotGridGroup3});
			this.xPivot.OptionsChartDataSource.ProvideDataByColumns = false;
			this.xPivot.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
			this.xPivot.OptionsView.RowTreeWidth = 170;
			// 
			// fieldTahun
			// 
			this.fieldTahun.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldTahun.AreaIndex = 0;
			this.fieldTahun.Caption = "Tahun";
			this.fieldTahun.FieldName = "PencairanCashback.Tanggal";
			this.fieldTahun.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldTahun.Name = "fieldTahun";
			this.fieldTahun.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldTahun.UnboundFieldName = "fieldTahun";
			// 
			// fieldBulan
			// 
			this.fieldBulan.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldBulan.AreaIndex = 1;
			this.fieldBulan.Caption = "Bulan";
			this.fieldBulan.ExpandedInFieldsGroup = false;
			this.fieldBulan.FieldName = "PencairanCashback.Tanggal";
			this.fieldBulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldBulan.Name = "fieldBulan";
			this.fieldBulan.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldBulan.UnboundFieldName = "fieldBulan";
			// 
			// fieldPencairanCashbackMinggu
			// 
			this.fieldPencairanCashbackMinggu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldPencairanCashbackMinggu.AreaIndex = 2;
			this.fieldPencairanCashbackMinggu.Caption = "Minggu";
			this.fieldPencairanCashbackMinggu.ExpandedInFieldsGroup = false;
			this.fieldPencairanCashbackMinggu.FieldName = "PencairanCashback.Minggu";
			this.fieldPencairanCashbackMinggu.Name = "fieldPencairanCashbackMinggu";
			this.fieldPencairanCashbackMinggu.Visible = false;
			// 
			// fieldPencairanCashbackTanggal
			// 
			this.fieldPencairanCashbackTanggal.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldPencairanCashbackTanggal.AreaIndex = 3;
			this.fieldPencairanCashbackTanggal.Caption = "Tanggal";
			this.fieldPencairanCashbackTanggal.FieldName = "PencairanCashback.Tanggal";
			this.fieldPencairanCashbackTanggal.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
			this.fieldPencairanCashbackTanggal.Name = "fieldPencairanCashbackTanggal";
			this.fieldPencairanCashbackTanggal.UnboundFieldName = "fieldPembayaranTanggal";
			this.fieldPencairanCashbackTanggal.Visible = false;
			// 
			// fieldCashbackInvoiceWilayahRegionalNama
			// 
			this.fieldCashbackInvoiceWilayahRegionalNama.AreaIndex = 3;
			this.fieldCashbackInvoiceWilayahRegionalNama.Caption = "Regional";
			this.fieldCashbackInvoiceWilayahRegionalNama.FieldName = "Cashback.Invoice.Wilayah.Regional.Nama";
			this.fieldCashbackInvoiceWilayahRegionalNama.Name = "fieldCashbackInvoiceWilayahRegionalNama";
			// 
			// fieldCashbackInvoiceWilayahNama
			// 
			this.fieldCashbackInvoiceWilayahNama.AreaIndex = 4;
			this.fieldCashbackInvoiceWilayahNama.Caption = "Wilayah";
			this.fieldCashbackInvoiceWilayahNama.FieldName = "Cashback.Invoice.Wilayah.Nama";
			this.fieldCashbackInvoiceWilayahNama.Name = "fieldCashbackInvoiceWilayahNama";
			// 
			// fieldPencairanCashbackCaraBayarAlias
			// 
			this.fieldPencairanCashbackCaraBayarAlias.AreaIndex = 2;
			this.fieldPencairanCashbackCaraBayarAlias.Caption = "Cara Bayar";
			this.fieldPencairanCashbackCaraBayarAlias.FieldName = "PencairanCashback.CaraBayar.Alias";
			this.fieldPencairanCashbackCaraBayarAlias.Name = "fieldPencairanCashbackCaraBayarAlias";
			// 
			// fieldTriwulan
			// 
			this.fieldTriwulan.AreaIndex = 0;
			this.fieldTriwulan.Caption = "Triwulan";
			this.fieldTriwulan.FieldName = "PencairanCashback.Tanggal";
			this.fieldTriwulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
			this.fieldTriwulan.Name = "fieldTriwulan";
			this.fieldTriwulan.UnboundFieldName = "fieldTriwulan";
			// 
			// fieldPencairanCashbackPemasang
			// 
			this.fieldPencairanCashbackPemasang.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldPencairanCashbackPemasang.AreaIndex = 0;
			this.fieldPencairanCashbackPemasang.Caption = "Pemasang";
			this.fieldPencairanCashbackPemasang.FieldName = "PencairanCashback.Pemasang";
			this.fieldPencairanCashbackPemasang.Name = "fieldPencairanCashbackPemasang";
			// 
			// fieldTotal
			// 
			this.fieldTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldTotal.AreaIndex = 0;
			this.fieldTotal.Caption = "Cashback";
			this.fieldTotal.CellFormat.FormatString = "n0";
			this.fieldTotal.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldTotal.FieldName = "NominalCair";
			this.fieldTotal.Name = "fieldTotal";
			// 
			// fieldCashbackInvoiceTipeInvoiceNama
			// 
			this.fieldCashbackInvoiceTipeInvoiceNama.AreaIndex = 1;
			this.fieldCashbackInvoiceTipeInvoiceNama.Caption = "Tipe Invoice";
			this.fieldCashbackInvoiceTipeInvoiceNama.FieldName = "Cashback.Invoice.TipeInvoice.Nama";
			this.fieldCashbackInvoiceTipeInvoiceNama.Name = "fieldCashbackInvoiceTipeInvoiceNama";
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
			this.nChart.Size = new System.Drawing.Size(888, 161);
			this.nChart.TabIndex = 18;
			chartTitle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartTitle1.Text = "Rekap Pencairan Cashback";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// UI_RekapPencairanCashback
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_RekapPencairanCashback";
			this.Text = "Rekap Pencairan Cashback";
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

		private DevExpress.XtraPivotGrid.PivotGridField fieldTahun;
		private DevExpress.XtraPivotGrid.PivotGridField fieldBulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldCashbackInvoiceWilayahRegionalNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldCashbackInvoiceWilayahNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTriwulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPencairanCashbackPemasang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPencairanCashbackCaraBayarAlias;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPencairanCashbackMinggu;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPencairanCashbackTanggal;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTotal;
		private DevExpress.XtraPivotGrid.PivotGridField fieldCashbackInvoiceTipeInvoiceNama;
		internal DevExpress.XtraCharts.ChartControl nChart;
	}
}
