<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zRexxaUI_SaldoPiutangUmur
  Inherits Core.Win.Forms.GridOutput

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Me.nChart = New DevExpress.XtraCharts.ChartControl()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiBayar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.colKode, Me.colNama, Me.colUang, Me.GridColumn2, Me.GridColumn1, Me.colNilaiInvoice, Me.colNilaiBayar, Me.colSaldo})
    Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(733, 182, 210, 179)
    Me.xGridView.GroupCount = 1
    Me.xGridView.OptionsBehavior.AutoExpandAllGroups = True
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
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
    XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
    XyDiagram1.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
    XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
    Me.nChart.Diagram = XyDiagram1
    Me.nChart.Dock = System.Windows.Forms.DockStyle.Fill
    Me.nChart.EmptyChartText.Text = "Data Kosong"
    Me.nChart.Location = New System.Drawing.Point(0, 0)
    Me.nChart.Name = "nChart"
    Series1.ArgumentDataMember = "d_differentdays"
    PointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
    PointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
    PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
    PointOptions1.ValueNumericOptions.Precision = 0
    Series1.LegendPointOptions = PointOptions1
    Series1.LegendText = "Legend"
    Series1.Name = "SeriesJali"
    Series1.SynchronizePointOptions = False
    Series1.ValueDataMembersSerializable = "SisaSaldo"
    SideBySideBarSeriesView1.ColorEach = True
    Series1.View = SideBySideBarSeriesView1
    Me.nChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
    Me.nChart.Size = New System.Drawing.Size(888, 161)
    Me.nChart.TabIndex = 0
    ChartTitle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    ChartTitle1.Text = "Umur Piutang"
    Me.nChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
    '
    'colKode
    '
    Me.colKode.Caption = "Kode"
    Me.colKode.FieldName = "p_id.Pelanggan.Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "p_id.Pelanggan.Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.FieldName = "p_id.MataUang.Kode"
    Me.colUang.Name = "colUang"
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 2
    '
    'colNilaiInvoice
    '
    Me.colNilaiInvoice.Caption = "Nilai Invoice"
    Me.colNilaiInvoice.FieldName = "p_id.Total"
    Me.colNilaiInvoice.Name = "colNilaiInvoice"
    Me.colNilaiInvoice.Visible = True
    Me.colNilaiInvoice.VisibleIndex = 5
    '
    'colNilaiBayar
    '
    Me.colNilaiBayar.Caption = "Terbayar"
    Me.colNilaiBayar.FieldName = "d_payment"
    Me.colNilaiBayar.Name = "colNilaiBayar"
    Me.colNilaiBayar.Visible = True
    Me.colNilaiBayar.VisibleIndex = 6
    '
    'colSaldo
    '
    Me.colSaldo.Caption = "Saldo"
    Me.colSaldo.FieldName = "SisaSaldo"
    Me.colSaldo.Name = "colSaldo"
    Me.colSaldo.UnboundExpression = "p_id.Total-d_payment"
    Me.colSaldo.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.colSaldo.Visible = True
    Me.colSaldo.VisibleIndex = 7
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Tempo"
    Me.GridColumn1.FieldName = "d_differentdays"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 4
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tgl Tempo"
    Me.GridColumn2.FieldName = "p_id.TanggalBerlaku"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 3
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Tempo"
    Me.GridColumn3.FieldName = "d_differentdays"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    '
    'UI_SaldoPiutangUmur
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(888, 405)
    Me.Name = "UI_SaldoPiutangUmur"
    Me.Text = "Saldo Piutang Per Customer"
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
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiInvoice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiBayar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
