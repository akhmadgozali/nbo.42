<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SaldoHutang
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
    Me.colUangg = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUangg, Me.colKode, Me.colNama, Me.colUang, Me.colNilaiInvoice, Me.colNilaiBayar, Me.colSaldo, Me.GridColumn1})
    Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(733, 182, 210, 179)
    Me.xGridView.GroupCount = 1
    Me.xGridView.OptionsBehavior.AutoExpandAllGroups = True
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUangg, DevExpress.Data.ColumnSortOrder.Ascending)})
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
    Series1.ArgumentDataMember = "Kode"
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
    ChartTitle1.Text = "Top 10 Saldo Hutang"
    Me.nChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
    '
    'colKode
    '
    Me.colKode.Caption = "Kode"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 1
    Me.colKode.Width = 136
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 2
    Me.colNama.Width = 136
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.FieldName = "MataUang"
    Me.colUang.Name = "colUang"
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 3
    Me.colUang.Width = 136
    '
    'colNilaiInvoice
    '
    Me.colNilaiInvoice.Caption = "Nilai Invoice"
    Me.colNilaiInvoice.FieldName = "TotalInvoice"
    Me.colNilaiInvoice.Name = "colNilaiInvoice"
    Me.colNilaiInvoice.Visible = True
    Me.colNilaiInvoice.VisibleIndex = 4
    Me.colNilaiInvoice.Width = 136
    '
    'colNilaiBayar
    '
    Me.colNilaiBayar.Caption = "Terbayar"
    Me.colNilaiBayar.FieldName = "TotalBayar"
    Me.colNilaiBayar.Name = "colNilaiBayar"
    Me.colNilaiBayar.Visible = True
    Me.colNilaiBayar.VisibleIndex = 5
    Me.colNilaiBayar.Width = 136
    '
    'colSaldo
    '
    Me.colSaldo.Caption = "Saldo"
    Me.colSaldo.FieldName = "SisaSaldo"
    Me.colSaldo.Name = "colSaldo"
    Me.colSaldo.Visible = True
    Me.colSaldo.VisibleIndex = 6
    Me.colSaldo.Width = 137
    '
    'colUangg
    '
    Me.colUangg.Caption = "Uang"
    Me.colUangg.FieldName = "MataUang"
    Me.colUangg.Name = "colUangg"
    Me.colUangg.Visible = True
    Me.colUangg.VisibleIndex = 0
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Regional"
    Me.GridColumn1.FieldName = "Regional.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 53
    '
    'UI_SaldoHutang
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(888, 405)
    Me.Name = "UI_SaldoHutang"
    Me.Text = "Saldo Hutang Per Vendor"
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
  Friend WithEvents colUangg As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
