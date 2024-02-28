namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataKomisi
{
	partial class UI_RekapPencairanKomisi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_RekapPencairanKomisi));
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
			this.fieldPencairanKomisiMinggu = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPencairanKomisiTanggal = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldKomisiInvoiceWilayahRegionalNama = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldKomisiInvoiceWilayahNama = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPencairanKomisiCaraBayarAlias = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTriwulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPencairanKomisiSalesNama = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTotal = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldKomisiInvoiceTipeInvoiceNama = new DevExpress.XtraPivotGrid.PivotGridField();
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
			this.xpCol.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.PencairanKomisiDetail);
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
            this.fieldPencairanKomisiMinggu,
            this.fieldPencairanKomisiTanggal,
            this.fieldTotal,
            this.fieldKomisiInvoiceWilayahRegionalNama,
            this.fieldKomisiInvoiceWilayahNama,
            this.fieldTriwulan,
            this.fieldPencairanKomisiSalesNama,
            this.fieldKomisiInvoiceTipeInvoiceNama,
            this.fieldPencairanKomisiCaraBayarAlias});
			pivotGridGroup1.Fields.Add(this.fieldTahun);
			pivotGridGroup1.Fields.Add(this.fieldBulan);
			pivotGridGroup1.Fields.Add(this.fieldPencairanKomisiMinggu);
			pivotGridGroup1.Fields.Add(this.fieldPencairanKomisiTanggal);
			pivotGridGroup1.Hierarchy = null;
			pivotGridGroup1.ShowNewValues = true;
			pivotGridGroup2.Fields.Add(this.fieldKomisiInvoiceWilayahRegionalNama);
			pivotGridGroup2.Fields.Add(this.fieldKomisiInvoiceWilayahNama);
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
			this.fieldTahun.FieldName = "PencairanKomisi.Tanggal";
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
			this.fieldBulan.FieldName = "PencairanKomisi.Tanggal";
			this.fieldBulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldBulan.Name = "fieldBulan";
			this.fieldBulan.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldBulan.UnboundFieldName = "fieldBulan";
			// 
			// fieldPencairanKomisiMinggu
			// 
			this.fieldPencairanKomisiMinggu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldPencairanKomisiMinggu.AreaIndex = 2;
			this.fieldPencairanKomisiMinggu.Caption = "Minggu";
			this.fieldPencairanKomisiMinggu.ExpandedInFieldsGroup = false;
			this.fieldPencairanKomisiMinggu.FieldName = "PencairanKomisi.Minggu";
			this.fieldPencairanKomisiMinggu.Name = "fieldPencairanKomisiMinggu";
			this.fieldPencairanKomisiMinggu.Visible = false;
			// 
			// fieldPencairanKomisiTanggal
			// 
			this.fieldPencairanKomisiTanggal.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldPencairanKomisiTanggal.AreaIndex = 3;
			this.fieldPencairanKomisiTanggal.Caption = "Tanggal";
			this.fieldPencairanKomisiTanggal.FieldName = "PencairanKomisi.Tanggal";
			this.fieldPencairanKomisiTanggal.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
			this.fieldPencairanKomisiTanggal.Name = "fieldPencairanKomisiTanggal";
			this.fieldPencairanKomisiTanggal.UnboundFieldName = "fieldPembayaranTanggal";
			this.fieldPencairanKomisiTanggal.Visible = false;
			// 
			// fieldKomisiInvoiceWilayahRegionalNama
			// 
			this.fieldKomisiInvoiceWilayahRegionalNama.AreaIndex = 3;
			this.fieldKomisiInvoiceWilayahRegionalNama.Caption = "Regional";
			this.fieldKomisiInvoiceWilayahRegionalNama.FieldName = "Komisi.Invoice.Wilayah.Regional.Nama";
			this.fieldKomisiInvoiceWilayahRegionalNama.Name = "fieldKomisiInvoiceWilayahRegionalNama";
			// 
			// fieldKomisiInvoiceWilayahNama
			// 
			this.fieldKomisiInvoiceWilayahNama.AreaIndex = 4;
			this.fieldKomisiInvoiceWilayahNama.Caption = "Wilayah";
			this.fieldKomisiInvoiceWilayahNama.FieldName = "Komisi.Invoice.Wilayah.Nama";
			this.fieldKomisiInvoiceWilayahNama.Name = "fieldKomisiInvoiceWilayahNama";
			// 
			// fieldPencairanKomisiCaraBayarAlias
			// 
			this.fieldPencairanKomisiCaraBayarAlias.AreaIndex = 2;
			this.fieldPencairanKomisiCaraBayarAlias.Caption = "Cara Bayar";
			this.fieldPencairanKomisiCaraBayarAlias.FieldName = "PencairanKomisi.CaraBayar.Alias";
			this.fieldPencairanKomisiCaraBayarAlias.Name = "fieldPencairanKomisiCaraBayarAlias";
			// 
			// fieldTriwulan
			// 
			this.fieldTriwulan.AreaIndex = 0;
			this.fieldTriwulan.Caption = "Triwulan";
			this.fieldTriwulan.FieldName = "PencairanKomisi.Tanggal";
			this.fieldTriwulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
			this.fieldTriwulan.Name = "fieldTriwulan";
			this.fieldTriwulan.UnboundFieldName = "fieldTriwulan";
			// 
			// fieldPencairanKomisiSalesNama
			// 
			this.fieldPencairanKomisiSalesNama.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldPencairanKomisiSalesNama.AreaIndex = 0;
			this.fieldPencairanKomisiSalesNama.Caption = "Sales";
			this.fieldPencairanKomisiSalesNama.FieldName = "PencairanKomisi.Sales.Nama";
			this.fieldPencairanKomisiSalesNama.Name = "fieldPencairanKomisiSalesNama";
			// 
			// fieldTotal
			// 
			this.fieldTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldTotal.AreaIndex = 0;
			this.fieldTotal.Caption = "Komisi";
			this.fieldTotal.CellFormat.FormatString = "n0";
			this.fieldTotal.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldTotal.FieldName = "NominalCair";
			this.fieldTotal.Name = "fieldTotal";
			// 
			// fieldKomisiInvoiceTipeInvoiceNama
			// 
			this.fieldKomisiInvoiceTipeInvoiceNama.AreaIndex = 1;
			this.fieldKomisiInvoiceTipeInvoiceNama.Caption = "Tipe Invoice";
			this.fieldKomisiInvoiceTipeInvoiceNama.FieldName = "Komisi.Invoice.TipeInvoice.Nama";
			this.fieldKomisiInvoiceTipeInvoiceNama.Name = "fieldKomisiInvoiceTipeInvoiceNama";
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
			chartTitle1.Text = "Rekap Pencairan Komisi";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// UI_RekapPencairanKomisi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_RekapPencairanKomisi";
			this.Text = "Rekap Pencairan Komisi";
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
		private DevExpress.XtraPivotGrid.PivotGridField fieldKomisiInvoiceWilayahRegionalNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldKomisiInvoiceWilayahNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTriwulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPencairanKomisiSalesNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPencairanKomisiCaraBayarAlias;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPencairanKomisiMinggu;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPencairanKomisiTanggal;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTotal;
		private DevExpress.XtraPivotGrid.PivotGridField fieldKomisiInvoiceTipeInvoiceNama;
		internal DevExpress.XtraCharts.ChartControl nChart;
	}
}
