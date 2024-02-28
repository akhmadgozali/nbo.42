namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataKomisi
{
	partial class UI_RekapHutangKomisi
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
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
			this.fieldTahun = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldBulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldMinggu = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldHari = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRegional = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldWilayah = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldHutang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPemasang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldSales = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTipeInvoice = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTriwulan = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldKomisiCashback = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPembayaran = new DevExpress.XtraPivotGrid.PivotGridField();
			this.nChart = new DevExpress.XtraCharts.ChartControl();
			this.txtPeriodeEdit = new DevExpress.XtraBars.BarEditItem();
			this.txtPeriode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.txtTampilkanSaldo0Edit = new DevExpress.XtraBars.BarEditItem();
			this.txtTampilkanSaldo0 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
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
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTampilkanSaldo0)).BeginInit();
			this.SuspendLayout();
			// 
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtPeriodeEdit,
            this.txtTampilkanSaldo0Edit});
			this.barMan.MaxItemId = 25;
			this.barMan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPeriode,
            this.txtTampilkanSaldo0});
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtPeriodeEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtTampilkanSaldo0Edit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// SplitContainerControl1
			// 
			this.SplitContainerControl1.Panel2.Controls.Add(this.nChart);
			this.SplitContainerControl1.Size = new System.Drawing.Size(895, 391);
			// 
			// xPivot
			// 
			this.xPivot.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldTahun,
            this.fieldBulan,
            this.fieldHutang,
            this.fieldRegional,
            this.fieldWilayah,
            this.fieldTriwulan,
            this.fieldPemasang,
            this.fieldSales,
            this.fieldTipeInvoice,
            this.fieldMinggu,
            this.fieldHari,
            this.fieldKomisiCashback,
            this.fieldPembayaran});
			pivotGridGroup1.Fields.Add(this.fieldTahun);
			pivotGridGroup1.Fields.Add(this.fieldBulan);
			pivotGridGroup1.Fields.Add(this.fieldMinggu);
			pivotGridGroup1.Fields.Add(this.fieldHari);
			pivotGridGroup1.Hierarchy = null;
			pivotGridGroup1.ShowNewValues = true;
			pivotGridGroup2.Fields.Add(this.fieldRegional);
			pivotGridGroup2.Fields.Add(this.fieldWilayah);
			pivotGridGroup2.Hierarchy = null;
			pivotGridGroup2.ShowNewValues = true;
			this.xPivot.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2});
			this.xPivot.OptionsChartDataSource.ProvideDataByColumns = false;
			this.xPivot.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
			this.xPivot.OptionsView.RowTreeWidth = 180;
			this.xPivot.Size = new System.Drawing.Size(895, 212);
			// 
			// fieldTahun
			// 
			this.fieldTahun.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldTahun.AreaIndex = 0;
			this.fieldTahun.Caption = "Tahun";
			this.fieldTahun.FieldName = "Tanggal";
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
			this.fieldBulan.FieldName = "Tanggal";
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
			this.fieldHari.FieldName = "Tanggal";
			this.fieldHari.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
			this.fieldHari.Name = "fieldHari";
			this.fieldHari.UnboundFieldName = "fieldHari";
			this.fieldHari.Visible = false;
			// 
			// fieldRegional
			// 
			this.fieldRegional.AreaIndex = 5;
			this.fieldRegional.FieldName = "Regional";
			this.fieldRegional.Name = "fieldRegional";
			// 
			// fieldWilayah
			// 
			this.fieldWilayah.AreaIndex = 6;
			this.fieldWilayah.FieldName = "Wilayah";
			this.fieldWilayah.Name = "fieldWilayah";
			// 
			// fieldHutang
			// 
			this.fieldHutang.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldHutang.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldHutang.AreaIndex = 0;
			this.fieldHutang.CellFormat.FormatString = "n0";
			this.fieldHutang.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldHutang.FieldName = "Hutang";
			this.fieldHutang.Name = "fieldHutang";
			// 
			// fieldPemasang
			// 
			this.fieldPemasang.AreaIndex = 1;
			this.fieldPemasang.FieldName = "Pemasang";
			this.fieldPemasang.Name = "fieldPemasang";
			// 
			// fieldSales
			// 
			this.fieldSales.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldSales.AreaIndex = 0;
			this.fieldSales.FieldName = "Sales";
			this.fieldSales.Name = "fieldSales";
			// 
			// fieldTipeInvoice
			// 
			this.fieldTipeInvoice.AreaIndex = 2;
			this.fieldTipeInvoice.Caption = "Tipe Invoice";
			this.fieldTipeInvoice.FieldName = "TipeInvoice";
			this.fieldTipeInvoice.Name = "fieldTipeInvoice";
			// 
			// fieldTriwulan
			// 
			this.fieldTriwulan.AreaIndex = 0;
			this.fieldTriwulan.Caption = "Triwulan";
			this.fieldTriwulan.FieldName = "Tanggal";
			this.fieldTriwulan.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
			this.fieldTriwulan.Name = "fieldTriwulan";
			this.fieldTriwulan.UnboundFieldName = "pivotGridField1";
			// 
			// fieldKomisiCashback
			// 
			this.fieldKomisiCashback.AreaIndex = 3;
			this.fieldKomisiCashback.Caption = "Komisi";
			this.fieldKomisiCashback.CellFormat.FormatString = "n0";
			this.fieldKomisiCashback.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldKomisiCashback.FieldName = "KomisiCashback";
			this.fieldKomisiCashback.Name = "fieldKomisiCashback";
			// 
			// fieldPembayaran
			// 
			this.fieldPembayaran.AreaIndex = 4;
			this.fieldPembayaran.CellFormat.FormatString = "n0";
			this.fieldPembayaran.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldPembayaran.FieldName = "Pembayaran";
			this.fieldPembayaran.Name = "fieldPembayaran";
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
			this.nChart.Size = new System.Drawing.Size(895, 174);
			this.nChart.TabIndex = 18;
			chartTitle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartTitle1.Text = "Rekap Hutang Komisi";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// txtPeriodeEdit
			// 
			this.txtPeriodeEdit.Caption = "Periode   ";
			this.txtPeriodeEdit.Edit = this.txtPeriode;
			this.txtPeriodeEdit.Id = 22;
			this.txtPeriodeEdit.Name = "txtPeriodeEdit";
			this.txtPeriodeEdit.Width = 176;
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
			// txtTampilkanSaldo0Edit
			// 
			this.txtTampilkanSaldo0Edit.Caption = "Tampilkan Saldo 0    ";
			this.txtTampilkanSaldo0Edit.Edit = this.txtTampilkanSaldo0;
			this.txtTampilkanSaldo0Edit.EditValue = false;
			this.txtTampilkanSaldo0Edit.Id = 24;
			this.txtTampilkanSaldo0Edit.Name = "txtTampilkanSaldo0Edit";
			this.txtTampilkanSaldo0Edit.Width = 20;
			// 
			// txtTampilkanSaldo0
			// 
			this.txtTampilkanSaldo0.AutoHeight = false;
			this.txtTampilkanSaldo0.Caption = "Check";
			this.txtTampilkanSaldo0.Name = "txtTampilkanSaldo0";
			// 
			// UI_RekapHutangKomisi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(895, 418);
			this.Name = "UI_RekapHutangKomisi";
			this.Text = "Rekap Hutang Komisi";
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
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTampilkanSaldo0)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraPivotGrid.PivotGridField fieldTahun;
		private DevExpress.XtraPivotGrid.PivotGridField fieldBulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldHutang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRegional;
		private DevExpress.XtraPivotGrid.PivotGridField fieldWilayah;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTriwulan;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPemasang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldSales;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTipeInvoice;
		private DevExpress.XtraPivotGrid.PivotGridField fieldMinggu;
		private DevExpress.XtraPivotGrid.PivotGridField fieldHari;
		private DevExpress.XtraPivotGrid.PivotGridField fieldKomisiCashback;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPembayaran;
		internal DevExpress.XtraCharts.ChartControl nChart;
		private DevExpress.XtraBars.BarEditItem txtPeriodeEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit txtPeriode;
		private DevExpress.XtraBars.BarEditItem txtTampilkanSaldo0Edit;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit txtTampilkanSaldo0;
	}
}
