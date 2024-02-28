namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan
{
	partial class UI_RekapPembayaran
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_RekapPembayaran));
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
			this.fieldPembayaranMinggu = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPembayaranTanggal = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPembayaranRegionalNama = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldInvoiceWilayahNama = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTahunInvoice = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldBulanInvoice = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldJmlBayar = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPembayaranCaraBayarAlias = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTriwulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPemasang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldInvoiceSalesNama = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldKoreksi = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTotal = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPembayaranSemester = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldInvoiceTipeInvoiceNama = new DevExpress.XtraPivotGrid.PivotGridField();
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
			this.xpCol.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.PembayaranIklanDetail);
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
            this.fieldPembayaranMinggu,
            this.fieldPembayaranTanggal,
            this.fieldJmlBayar,
            this.fieldKoreksi,
            this.fieldTotal,
            this.fieldPembayaranRegionalNama,
            this.fieldInvoiceWilayahNama,
            this.fieldPembayaranSemester,
            this.fieldTriwulan,
            this.fieldInvoiceSalesNama,
            this.fieldPemasang,
            this.fieldInvoiceTipeInvoiceNama,
            this.fieldPembayaranCaraBayarAlias,
            this.fieldTahunInvoice,
            this.fieldBulanInvoice});
			pivotGridGroup1.Fields.Add(this.fieldTahun);
			pivotGridGroup1.Fields.Add(this.fieldBulan);
			pivotGridGroup1.Fields.Add(this.fieldPembayaranMinggu);
			pivotGridGroup1.Fields.Add(this.fieldPembayaranTanggal);
			pivotGridGroup1.Hierarchy = null;
			pivotGridGroup1.ShowNewValues = true;
			pivotGridGroup2.Fields.Add(this.fieldPembayaranRegionalNama);
			pivotGridGroup2.Fields.Add(this.fieldInvoiceWilayahNama);
			pivotGridGroup2.Hierarchy = null;
			pivotGridGroup2.ShowNewValues = true;
			pivotGridGroup3.Fields.Add(this.fieldTahunInvoice);
			pivotGridGroup3.Fields.Add(this.fieldBulanInvoice);
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
			this.fieldTahun.FieldName = "Pembayaran.Tanggal";
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
			this.fieldBulan.FieldName = "Pembayaran.Tanggal";
			this.fieldBulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldBulan.Name = "fieldBulan";
			this.fieldBulan.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldBulan.UnboundFieldName = "fieldBulan";
			// 
			// fieldPembayaranMinggu
			// 
			this.fieldPembayaranMinggu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldPembayaranMinggu.AreaIndex = 2;
			this.fieldPembayaranMinggu.Caption = "Minggu";
			this.fieldPembayaranMinggu.ExpandedInFieldsGroup = false;
			this.fieldPembayaranMinggu.FieldName = "Pembayaran.Minggu";
			this.fieldPembayaranMinggu.Name = "fieldPembayaranMinggu";
			this.fieldPembayaranMinggu.Visible = false;
			// 
			// fieldPembayaranTanggal
			// 
			this.fieldPembayaranTanggal.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldPembayaranTanggal.AreaIndex = 3;
			this.fieldPembayaranTanggal.Caption = "Tanggal";
			this.fieldPembayaranTanggal.FieldName = "Pembayaran.Tanggal";
			this.fieldPembayaranTanggal.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
			this.fieldPembayaranTanggal.Name = "fieldPembayaranTanggal";
			this.fieldPembayaranTanggal.UnboundFieldName = "fieldPembayaranTanggal";
			this.fieldPembayaranTanggal.Visible = false;
			// 
			// fieldPembayaranRegionalNama
			// 
			this.fieldPembayaranRegionalNama.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldPembayaranRegionalNama.AreaIndex = 0;
			this.fieldPembayaranRegionalNama.Caption = "Regional";
			this.fieldPembayaranRegionalNama.FieldName = "Pembayaran.Regional.Nama";
			this.fieldPembayaranRegionalNama.Name = "fieldPembayaranRegionalNama";
			// 
			// fieldInvoiceWilayahNama
			// 
			this.fieldInvoiceWilayahNama.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldInvoiceWilayahNama.AreaIndex = 1;
			this.fieldInvoiceWilayahNama.Caption = "Wilayah";
			this.fieldInvoiceWilayahNama.FieldName = "Invoice.Wilayah.Nama";
			this.fieldInvoiceWilayahNama.Name = "fieldInvoiceWilayahNama";
			// 
			// fieldTahunInvoice
			// 
			this.fieldTahunInvoice.AreaIndex = 6;
			this.fieldTahunInvoice.Caption = "Tahun Invoice";
			this.fieldTahunInvoice.FieldName = "Invoice.TanggalOmzet";
			this.fieldTahunInvoice.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldTahunInvoice.Name = "fieldTahunInvoice";
			this.fieldTahunInvoice.UnboundFieldName = "fieldTahunInvoice";
			// 
			// fieldBulanInvoice
			// 
			this.fieldBulanInvoice.AreaIndex = 7;
			this.fieldBulanInvoice.Caption = "Bulan Invoice";
			this.fieldBulanInvoice.FieldName = "Invoice.TanggalOmzet";
			this.fieldBulanInvoice.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldBulanInvoice.Name = "fieldBulanInvoice";
			this.fieldBulanInvoice.UnboundFieldName = "fieldBulanInvoice";
			// 
			// fieldJmlBayar
			// 
			this.fieldJmlBayar.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldJmlBayar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldJmlBayar.AreaIndex = 0;
			this.fieldJmlBayar.Caption = "Jml. Bayar";
			this.fieldJmlBayar.CellFormat.FormatString = "n0";
			this.fieldJmlBayar.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldJmlBayar.FieldName = "PembayaranNonKoreksi";
			this.fieldJmlBayar.Name = "fieldJmlBayar";
			// 
			// fieldPembayaranCaraBayarAlias
			// 
			this.fieldPembayaranCaraBayarAlias.AreaIndex = 5;
			this.fieldPembayaranCaraBayarAlias.Caption = "Cara Bayar";
			this.fieldPembayaranCaraBayarAlias.FieldName = "Pembayaran.CaraBayar.Alias";
			this.fieldPembayaranCaraBayarAlias.Name = "fieldPembayaranCaraBayarAlias";
			// 
			// fieldTriwulan
			// 
			this.fieldTriwulan.AreaIndex = 1;
			this.fieldTriwulan.Caption = "Triwulan";
			this.fieldTriwulan.FieldName = "Pembayaran.Tanggal";
			this.fieldTriwulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
			this.fieldTriwulan.Name = "fieldTriwulan";
			this.fieldTriwulan.UnboundFieldName = "fieldTriwulan";
			// 
			// fieldPemasang
			// 
			this.fieldPemasang.AreaIndex = 3;
			this.fieldPemasang.Caption = "Pemasang";
			this.fieldPemasang.FieldName = "Invoice.InvoiceNama";
			this.fieldPemasang.Name = "fieldPemasang";
			// 
			// fieldInvoiceSalesNama
			// 
			this.fieldInvoiceSalesNama.AreaIndex = 2;
			this.fieldInvoiceSalesNama.Caption = "Sales";
			this.fieldInvoiceSalesNama.FieldName = "Invoice.Sales.Nama";
			this.fieldInvoiceSalesNama.Name = "fieldInvoiceSalesNama";
			// 
			// fieldKoreksi
			// 
			this.fieldKoreksi.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldKoreksi.AreaIndex = 1;
			this.fieldKoreksi.Caption = "Koreksi";
			this.fieldKoreksi.CellFormat.FormatString = "n0";
			this.fieldKoreksi.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldKoreksi.FieldName = "PembayaranKoreksi";
			this.fieldKoreksi.Name = "fieldKoreksi";
			// 
			// fieldTotal
			// 
			this.fieldTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldTotal.AreaIndex = 2;
			this.fieldTotal.Caption = "Total";
			this.fieldTotal.CellFormat.FormatString = "n0";
			this.fieldTotal.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldTotal.FieldName = "NominalBayar";
			this.fieldTotal.Name = "fieldTotal";
			// 
			// fieldPembayaranSemester
			// 
			this.fieldPembayaranSemester.AreaIndex = 0;
			this.fieldPembayaranSemester.Caption = "Semester";
			this.fieldPembayaranSemester.FieldName = "Pembayaran.Semester";
			this.fieldPembayaranSemester.Name = "fieldPembayaranSemester";
			// 
			// fieldInvoiceTipeInvoiceNama
			// 
			this.fieldInvoiceTipeInvoiceNama.AreaIndex = 4;
			this.fieldInvoiceTipeInvoiceNama.Caption = "Tipe Invoice";
			this.fieldInvoiceTipeInvoiceNama.FieldName = "Invoice.TipeInvoice.Nama";
			this.fieldInvoiceTipeInvoiceNama.Name = "fieldInvoiceTipeInvoiceNama";
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
			chartTitle1.Text = "Rekap Pembayaran";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// UI_RekapPembayaran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_RekapPembayaran";
			this.Text = "Rekap Pembayaran";
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
		private DevExpress.XtraPivotGrid.PivotGridField fieldJmlBayar;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPembayaranRegionalNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldInvoiceWilayahNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTriwulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldInvoiceSalesNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPemasang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPembayaranCaraBayarAlias;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPembayaranMinggu;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPembayaranTanggal;
		private DevExpress.XtraPivotGrid.PivotGridField fieldKoreksi;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTotal;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPembayaranSemester;
		private DevExpress.XtraPivotGrid.PivotGridField fieldInvoiceTipeInvoiceNama;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTahunInvoice;
		private DevExpress.XtraPivotGrid.PivotGridField fieldBulanInvoice;
		internal DevExpress.XtraCharts.ChartControl nChart;
	}
}
