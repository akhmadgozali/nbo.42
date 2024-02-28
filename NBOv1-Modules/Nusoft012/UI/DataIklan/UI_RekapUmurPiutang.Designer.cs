namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan
{
	partial class UI_RekapUmurPiutang
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
			this.fieldWilayah = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldKelompokUmurPiutang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPiutang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPemasang = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldSales = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTipeInvoice = new DevExpress.XtraPivotGrid.PivotGridField();
			this.nChart = new DevExpress.XtraCharts.ChartControl();
			this.txtPeriodeEdit = new DevExpress.XtraBars.BarEditItem();
			this.txtPeriode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
			this.SuspendLayout();
			// 
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtPeriodeEdit});
			this.barMan.MaxItemId = 23;
			this.barMan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPeriode});
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtPeriodeEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
			this.xPivot.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldKelompokUmurPiutang,
            this.fieldPiutang,
            this.fieldWilayah,
            this.fieldPemasang,
            this.fieldSales,
            this.fieldTipeInvoice});
			pivotGridGroup1.Fields.Add(this.fieldWilayah);
			pivotGridGroup1.Hierarchy = null;
			pivotGridGroup1.ShowNewValues = true;
			this.xPivot.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
			this.xPivot.OptionsChartDataSource.ProvideDataByColumns = false;
			this.xPivot.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
			this.xPivot.OptionsView.RowTreeWidth = 120;
			// 
			// fieldWilayah
			// 
			this.fieldWilayah.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldWilayah.AreaIndex = 0;
			this.fieldWilayah.Caption = "Wilayah";
			this.fieldWilayah.FieldName = "Wilayah";
			this.fieldWilayah.Name = "fieldWilayah";
			// 
			// fieldKelompokUmurPiutang
			// 
			this.fieldKelompokUmurPiutang.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldKelompokUmurPiutang.AreaIndex = 0;
			this.fieldKelompokUmurPiutang.Caption = "Umur Piutang";
			this.fieldKelompokUmurPiutang.FieldName = "KelompokUmurPiutang";
			this.fieldKelompokUmurPiutang.Name = "fieldKelompokUmurPiutang";
			// 
			// fieldPiutang
			// 
			this.fieldPiutang.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldPiutang.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldPiutang.AreaIndex = 0;
			this.fieldPiutang.Caption = "Piutang";
			this.fieldPiutang.CellFormat.FormatString = "n0";
			this.fieldPiutang.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldPiutang.FieldName = "Piutang";
			this.fieldPiutang.Name = "fieldPiutang";
			// 
			// fieldPemasang
			// 
			this.fieldPemasang.AreaIndex = 0;
			this.fieldPemasang.Caption = "Pemasang";
			this.fieldPemasang.FieldName = "Pemasang";
			this.fieldPemasang.Name = "fieldPemasang";
			// 
			// fieldSales
			// 
			this.fieldSales.AreaIndex = 1;
			this.fieldSales.Caption = "Sales";
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
			chartTitle1.Text = "Rekap Umur Piutang";
			this.nChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// txtPeriodeEdit
			// 
			this.txtPeriodeEdit.Caption = "Periode :  ";
			this.txtPeriodeEdit.Edit = this.txtPeriode;
			this.txtPeriodeEdit.Id = 22;
			this.txtPeriodeEdit.Name = "txtPeriodeEdit";
			this.txtPeriodeEdit.Width = 152;
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
			// UI_RekapUmurPiutang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_RekapUmurPiutang";
			this.Text = "Rekap Umur Piutang";
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
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraPivotGrid.PivotGridField fieldKelompokUmurPiutang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPiutang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldWilayah;
		private DevExpress.XtraPivotGrid.PivotGridField fieldPemasang;
		private DevExpress.XtraPivotGrid.PivotGridField fieldSales;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTipeInvoice;
		internal DevExpress.XtraCharts.ChartControl nChart;
		private DevExpress.XtraBars.BarEditItem txtPeriodeEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit txtPeriode;
	}
}
