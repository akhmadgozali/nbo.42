<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SOOutstanding
  Inherits Core.Win.Forms.GridOutput

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.nChart = New DevExpress.XtraCharts.ChartControl()
        Me.colNoSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtySO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyStok = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPelanggan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xGrid
        '
        Me.xGrid.DataSource = Nothing
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoSO, Me.colTanggal, Me.colReff, Me.colKodeBarang, Me.colNamaBarang, Me.colQtySO, Me.colQtyStok, Me.colPelanggan, Me.colKeterangan})
        Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(733, 182, 210, 179)
        Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtySO", Nothing, "Qty SO : {0:n0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyStok", Nothing, "Qty Stok : {0:n0}")})
        Me.xGridView.OptionsBehavior.AutoExpandAllGroups = True
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsSelection.MultiSelect = True
        '
        'barMenu
        '
        Me.barMenu.OptionsBar.AllowQuickCustomization = False
        Me.barMenu.OptionsBar.DrawDragBorder = False
        Me.barMenu.OptionsBar.UseWholeRow = True
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.nChart)
        '
        'nChart
        '
        XyDiagram1.AxisX.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram1.AxisX.Label.NumericOptions.Precision = 0
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram1.AxisY.Label.NumericOptions.Precision = 0
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.nChart.Diagram = XyDiagram1
        Me.nChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nChart.EmptyChartText.Text = "Data Kosong"
        Me.nChart.Location = New System.Drawing.Point(0, 0)
        Me.nChart.Name = "nChart"
        Series1.ArgumentDataMember = "Barang.Kode"
        PointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions1.ArgumentNumericOptions.Precision = 0
        PointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions1.ValueNumericOptions.Precision = 0
        Series1.LegendPointOptions = PointOptions1
        Series1.LegendText = "Legend"
        Series1.Name = "SeriesJali"
        Series1.SynchronizePointOptions = False
        Series1.ValueDataMembersSerializable = "QtySO"
        SideBySideBarSeriesView1.ColorEach = True
        Series1.View = SideBySideBarSeriesView1
        Me.nChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.nChart.Size = New System.Drawing.Size(888, 161)
        Me.nChart.TabIndex = 0
        ChartTitle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle1.Text = "Umur Piutang"
        Me.nChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'colNoSO
        '
        Me.colNoSO.Caption = "No. SO"
        Me.colNoSO.FieldName = "NomorSO"
        Me.colNoSO.Name = "colNoSO"
        Me.colNoSO.OptionsColumn.ReadOnly = True
        Me.colNoSO.Visible = True
        Me.colNoSO.VisibleIndex = 0
        Me.colNoSO.Width = 80
        '
        'colTanggal
        '
        Me.colTanggal.Caption = "Tanggal"
        Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTanggal.FieldName = "Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.OptionsColumn.AllowEdit = False
        Me.colTanggal.OptionsColumn.ReadOnly = True
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 1
        Me.colTanggal.Width = 90
        '
        'colReff
        '
        Me.colReff.Caption = "No. Reff"
        Me.colReff.FieldName = "NomorReff"
        Me.colReff.Name = "colReff"
        Me.colReff.OptionsColumn.ReadOnly = True
        Me.colReff.Visible = True
        Me.colReff.VisibleIndex = 2
        Me.colReff.Width = 80
        '
        'colQtySO
        '
        Me.colQtySO.Caption = "Qty SO"
        Me.colQtySO.DisplayFormat.FormatString = "n0"
        Me.colQtySO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtySO.FieldName = "QtySO"
        Me.colQtySO.Name = "colQtySO"
        Me.colQtySO.OptionsColumn.AllowEdit = False
        Me.colQtySO.OptionsColumn.ReadOnly = True
        Me.colQtySO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtySO", "{0:n0}")})
        Me.colQtySO.Visible = True
        Me.colQtySO.VisibleIndex = 5
        Me.colQtySO.Width = 50
        '
        'colQtyStok
        '
        Me.colQtyStok.Caption = "Qty Stok"
        Me.colQtyStok.DisplayFormat.FormatString = "n0"
        Me.colQtyStok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyStok.FieldName = "QtyStok"
        Me.colQtyStok.Name = "colQtyStok"
        Me.colQtyStok.OptionsColumn.AllowEdit = False
        Me.colQtyStok.OptionsColumn.ReadOnly = True
        Me.colQtyStok.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyStok", "{0:n0}")})
        Me.colQtyStok.Visible = True
        Me.colQtyStok.VisibleIndex = 6
        Me.colQtyStok.Width = 50
        '
        'colPelanggan
        '
        Me.colPelanggan.Caption = "Pelanggan"
        Me.colPelanggan.FieldName = "Pelanggan.Nama"
        Me.colPelanggan.Name = "colPelanggan"
        Me.colPelanggan.OptionsColumn.ReadOnly = True
        Me.colPelanggan.Visible = True
        Me.colPelanggan.VisibleIndex = 7
        Me.colPelanggan.Width = 120
        '
        'colNamaBarang
        '
        Me.colNamaBarang.Caption = "Nama Barang"
        Me.colNamaBarang.FieldName = "Barang.Nama"
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.OptionsColumn.AllowEdit = False
        Me.colNamaBarang.OptionsColumn.ReadOnly = True
        Me.colNamaBarang.Visible = True
        Me.colNamaBarang.VisibleIndex = 4
        Me.colNamaBarang.Width = 120
        '
        'colKodeBarang
        '
        Me.colKodeBarang.Caption = "Kode Barang"
        Me.colKodeBarang.FieldName = "Barang.Kode"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.OptionsColumn.ReadOnly = True
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 3
        Me.colKodeBarang.Width = 90
        '
        'colKeterangan
        '
        Me.colKeterangan.Caption = "Keterangan"
        Me.colKeterangan.FieldName = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        Me.colKeterangan.OptionsColumn.ReadOnly = True
        Me.colKeterangan.Visible = True
        Me.colKeterangan.VisibleIndex = 8
        Me.colKeterangan.Width = 190
        '
        'UI_SOOutstanding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 405)
        Me.Name = "UI_SOOutstanding"
        Me.Text = "SO Outstanding"
        Me.xpCol = Me.xpCol
        CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nChart As DevExpress.XtraCharts.ChartControl
  Friend WithEvents colNoSO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colReff As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtySO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyStok As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPelanggan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
End Class
