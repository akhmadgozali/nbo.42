﻿namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan
{
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
			DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
			DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup3 = new DevExpress.XtraPivotGrid.PivotGridGroup();
			DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup4 = new DevExpress.XtraPivotGrid.PivotGridGroup();
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
			this.fieldTahun = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldBulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldMinggu = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldHari = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldSales = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTipeInvoice = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRegional = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldWilayah = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldProduk = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldMerk = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOmzet = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTriwulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPemasang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldKoreksi = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTotal = new DevExpress.XtraPivotGrid.PivotGridField();
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
			this.xpCol.CriteriaString = "[SaldoAwal] = False";
			this.xpCol.DisplayableProperties = "Id;Wilayah.Nama;TipeInvoice.Nama;Sales.Nama;SaldoAwal;TanggalOmzet;InvoiceNama;Me" +
    "rk.Nama;Total;Tahun;Semester;Bulan;Minggu;OmzetKoreksi;OmzetNonKoreksi";
			this.xpCol.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.Invoice);
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
            this.fieldRegional,
            this.fieldWilayah,
            this.fieldOmzet,
            this.fieldKoreksi,
            this.fieldTotal,
            this.fieldTahun,
            this.fieldBulan,
            this.fieldMinggu,
            this.fieldHari,
            this.fieldTriwulan,
            this.fieldTipeInvoice,
            this.fieldSales,
            this.fieldPemasang,
            this.fieldProduk,
            this.fieldMerk});
			pivotGridGroup1.Fields.Add(this.fieldTahun);
			pivotGridGroup1.Fields.Add(this.fieldBulan);
			pivotGridGroup1.Fields.Add(this.fieldMinggu);
			pivotGridGroup1.Fields.Add(this.fieldHari);
			pivotGridGroup1.Hierarchy = null;
			pivotGridGroup1.ShowNewValues = true;
			pivotGridGroup2.Fields.Add(this.fieldSales);
			pivotGridGroup2.Hierarchy = null;
			pivotGridGroup2.ShowNewValues = true;
			pivotGridGroup3.Fields.Add(this.fieldTipeInvoice);
			pivotGridGroup3.Hierarchy = null;
			pivotGridGroup3.ShowNewValues = true;
			pivotGridGroup4.Fields.Add(this.fieldRegional);
			pivotGridGroup4.Fields.Add(this.fieldWilayah);
			pivotGridGroup4.Hierarchy = null;
			pivotGridGroup4.ShowNewValues = true;
			this.xPivot.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2,
            pivotGridGroup3,
            pivotGridGroup4});
			this.xPivot.OptionsChartDataSource.ProvideDataByColumns = false;
			this.xPivot.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
			this.xPivot.OptionsView.RowTreeWidth = 180;
			// 
			// fieldTahun
			// 
			this.fieldTahun.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldTahun.AreaIndex = 0;
			this.fieldTahun.Caption = "Tahun";
			this.fieldTahun.FieldName = "TanggalOmzet";
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
			this.fieldBulan.FieldName = "TanggalOmzet";
			this.fieldBulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldBulan.Name = "fieldBulan";
			this.fieldBulan.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldBulan.UnboundFieldName = "fieldBulan";
			// 
			// fieldMinggu
			// 
			this.fieldMinggu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldMinggu.AreaIndex = 2;
			this.fieldMinggu.Caption = "Minggu";
			this.fieldMinggu.ExpandedInFieldsGroup = false;
			this.fieldMinggu.FieldName = "Minggu";
			this.fieldMinggu.Name = "fieldMinggu";
			this.fieldMinggu.Visible = false;
			// 
			// fieldHari
			// 
			this.fieldHari.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldHari.AreaIndex = 3;
			this.fieldHari.Caption = "Tanggal";
			this.fieldHari.FieldName = "TanggalOmzet";
			this.fieldHari.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
			this.fieldHari.Name = "fieldHari";
			this.fieldHari.UnboundFieldName = "fieldHari";
			this.fieldHari.Visible = false;
			// 
			// fieldSales
			// 
			this.fieldSales.AreaIndex = 2;
			this.fieldSales.Caption = "Sales";
			this.fieldSales.FieldName = "Sales.Nama";
			this.fieldSales.Name = "fieldSales";
			// 
			// fieldTipeInvoice
			// 
			this.fieldTipeInvoice.AreaIndex = 1;
			this.fieldTipeInvoice.Caption = "Tipe Invoice";
			this.fieldTipeInvoice.FieldName = "TipeInvoice.Nama";
			this.fieldTipeInvoice.Name = "fieldTipeInvoice";
			// 
			// fieldRegional
			// 
			this.fieldRegional.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldRegional.AreaIndex = 0;
			this.fieldRegional.Caption = "Regional";
			this.fieldRegional.FieldName = "Wilayah.Regional.Nama";
			this.fieldRegional.Name = "fieldRegional";
			this.fieldRegional.Width = 200;
			// 
			// fieldWilayah
			// 
			this.fieldWilayah.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldWilayah.AreaIndex = 1;
			this.fieldWilayah.Caption = "Wilayah";
			this.fieldWilayah.FieldName = "Wilayah.Nama";
			this.fieldWilayah.Name = "fieldWilayah";
			// 
			// fieldProduk
			// 
			this.fieldProduk.AreaIndex = 4;
			this.fieldProduk.Caption = "Produk";
			this.fieldProduk.FieldName = "Merk.Produk.Nama";
			this.fieldProduk.Name = "fieldProduk";
			// 
			// fieldMerk
			// 
			this.fieldMerk.AreaIndex = 5;
			this.fieldMerk.Caption = "Merk";
			this.fieldMerk.FieldName = "Merk.Nama";
			this.fieldMerk.Name = "fieldMerk";
			// 
			// fieldOmzet
			// 
			this.fieldOmzet.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldOmzet.AreaIndex = 0;
			this.fieldOmzet.Caption = "Omzet";
			this.fieldOmzet.CellFormat.FormatString = "n0";
			this.fieldOmzet.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldOmzet.FieldName = "OmzetNonKoreksi";
			this.fieldOmzet.Name = "fieldOmzet";
			this.fieldOmzet.Width = 80;
			// 
			// fieldTriwulan
			// 
			this.fieldTriwulan.AreaIndex = 0;
			this.fieldTriwulan.Caption = "Triwulan";
			this.fieldTriwulan.FieldName = "TanggalOmzet";
			this.fieldTriwulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
			this.fieldTriwulan.Name = "fieldTriwulan";
			this.fieldTriwulan.UnboundFieldName = "fieldTriwulan";
			// 
			// fieldPemasang
			// 
			this.fieldPemasang.AreaIndex = 3;
			this.fieldPemasang.Caption = "Pemasang";
			this.fieldPemasang.FieldName = "InvoiceNama";
			this.fieldPemasang.Name = "fieldPemasang";
			// 
			// fieldKoreksi
			// 
			this.fieldKoreksi.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldKoreksi.AreaIndex = 1;
			this.fieldKoreksi.Caption = "Koreksi";
			this.fieldKoreksi.CellFormat.FormatString = "n0";
			this.fieldKoreksi.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldKoreksi.FieldName = "OmzetKoreksi";
			this.fieldKoreksi.Name = "fieldKoreksi";
			this.fieldKoreksi.Width = 80;
			// 
			// fieldTotal
			// 
			this.fieldTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldTotal.AreaIndex = 2;
			this.fieldTotal.Caption = "Total";
			this.fieldTotal.CellFormat.FormatString = "n0";
			this.fieldTotal.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldTotal.FieldName = "Total";
			this.fieldTotal.Name = "fieldTotal";
			this.fieldTotal.Width = 80;
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
			this.nChart.TabIndex = 17;
			chartTitle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartTitle1.Text = "Rekap Omzet";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// UI_RekapOmzet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
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

		private DevExpress.XtraPivotGrid.PivotGridField fieldOmzet;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTahun;
		private DevExpress.XtraPivotGrid.PivotGridField fieldBulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldWilayah;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTriwulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRegional;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTipeInvoice;
		private DevExpress.XtraPivotGrid.PivotGridField fieldSales;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPemasang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldMerk;
		private DevExpress.XtraPivotGrid.PivotGridField fieldProduk;
		private DevExpress.XtraPivotGrid.PivotGridField fieldMinggu;
		private DevExpress.XtraPivotGrid.PivotGridField fieldHari;
		private DevExpress.XtraPivotGrid.PivotGridField fieldKoreksi;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTotal;
		internal DevExpress.XtraCharts.ChartControl nChart;
	}
}
