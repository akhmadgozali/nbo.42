<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pjp_SaldoARAP
  Inherits Core.Win.Forms.BlankForm

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
    Me.components = New System.ComponentModel.Container()
    Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pjp_SaldoARAP))
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.nChart = New DevExpress.XtraCharts.ChartControl()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJumlah = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBayar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.coLSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJumlahValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBayarValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldoValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.btnDetail = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.btnSetup = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.nChart, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.nChart)
    Me.LayoutControl1.Controls.Add(Me.xGrid)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(607, 197, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(759, 368)
    Me.LayoutControl1.TabIndex = 0
    Me.LayoutControl1.Text = "lytControl"
    '
    'nChart
    '
    XyDiagram2.AxisX.Label.Angle = 20
    XyDiagram2.AxisX.Label.Staggered = True
    XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
    XyDiagram2.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
    XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
    Me.nChart.Diagram = XyDiagram2
    Me.nChart.EmptyChartText.Text = "Data Kosong"
    Me.nChart.Location = New System.Drawing.Point(12, 178)
    Me.nChart.Name = "nChart"
    Series2.ArgumentDataMember = "Kode"
    PointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
    PointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
    PointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
    PointOptions2.ValueNumericOptions.Precision = 0
    Series2.LegendPointOptions = PointOptions2
    Series2.LegendText = "Legend"
    Series2.Name = "Series1"
    Series2.SynchronizePointOptions = False
    Series2.TopNOptions.Count = 10
    Series2.TopNOptions.Enabled = True
    Series2.ValueDataMembersSerializable = "saldo"
    SideBySideBarSeriesView2.ColorEach = True
    Series2.View = SideBySideBarSeriesView2
    Me.nChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
    Me.nChart.Size = New System.Drawing.Size(735, 178)
    Me.nChart.TabIndex = 5
    ChartTitle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
    Me.nChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 12)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
    Me.xGrid.Size = New System.Drawing.Size(735, 157)
    Me.xGrid.TabIndex = 4
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colNama, Me.colUang, Me.colJumlah, Me.colBayar, Me.coLSaldo, Me.colJumlahValas, Me.colBayarValas, Me.colSaldoValas})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.GroupCount = 1
    Me.xGridView.GroupPanelText = "Drag pada judul kolom untuk mengelompokkan data"
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah data"
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUang, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colKode
    '
    Me.colKode.Caption = "Kode"
    Me.colKode.ColumnEdit = Me.RepositoryItemButtonEdit1
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.OptionsColumn.ReadOnly = True
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'RepositoryItemButtonEdit1
    '
    Me.RepositoryItemButtonEdit1.AutoHeight = False
    Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.OptionsColumn.ReadOnly = True
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.FieldName = "Uang"
    Me.colUang.Name = "colUang"
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 2
    '
    'colJumlah
    '
    Me.colJumlah.Caption = "Jumlah"
    Me.colJumlah.FieldName = "Jumlah"
    Me.colJumlah.Name = "colJumlah"
    Me.colJumlah.Visible = True
    Me.colJumlah.VisibleIndex = 2
    '
    'colBayar
    '
    Me.colBayar.Caption = "Bayar"
    Me.colBayar.FieldName = "Bayar"
    Me.colBayar.Name = "colBayar"
    Me.colBayar.Visible = True
    Me.colBayar.VisibleIndex = 3
    '
    'coLSaldo
    '
    Me.coLSaldo.Caption = "Saldo"
    Me.coLSaldo.FieldName = "Saldo"
    Me.coLSaldo.Name = "coLSaldo"
    Me.coLSaldo.Visible = True
    Me.coLSaldo.VisibleIndex = 4
    '
    'colJumlahValas
    '
    Me.colJumlahValas.Caption = "Jumlah Valas"
    Me.colJumlahValas.FieldName = "JumlahValas"
    Me.colJumlahValas.Name = "colJumlahValas"
    Me.colJumlahValas.Visible = True
    Me.colJumlahValas.VisibleIndex = 5
    '
    'colBayarValas
    '
    Me.colBayarValas.Caption = "Bayar Valas"
    Me.colBayarValas.FieldName = "BayarValas"
    Me.colBayarValas.Name = "colBayarValas"
    Me.colBayarValas.Visible = True
    Me.colBayarValas.VisibleIndex = 6
    '
    'colSaldoValas
    '
    Me.colSaldoValas.Caption = "Saldo Valas"
    Me.colSaldoValas.FieldName = "SaldoValas"
    Me.colSaldoValas.Name = "colSaldoValas"
    Me.colSaldoValas.Visible = True
    Me.colSaldoValas.VisibleIndex = 7
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.SplitterItem1})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(759, 368)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.xGrid
    Me.LayoutControlItem1.CustomizationFormText = "Grid Data"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(739, 161)
    Me.LayoutControlItem1.Text = "Grid Data"
    Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextToControlDistance = 0
    Me.LayoutControlItem1.TextVisible = False
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.nChart
    Me.LayoutControlItem2.CustomizationFormText = "Chart Data"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 166)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(739, 182)
    Me.LayoutControlItem2.Text = "Chart Data"
    Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem2.TextToControlDistance = 0
    Me.LayoutControlItem2.TextVisible = False
    '
    'SplitterItem1
    '
    Me.SplitterItem1.AllowHotTrack = True
    Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
    Me.SplitterItem1.Location = New System.Drawing.Point(0, 161)
    Me.SplitterItem1.Name = "SplitterItem1"
    Me.SplitterItem1.Size = New System.Drawing.Size(739, 5)
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnDetail, Me.btnSetup})
    Me.BarManager1.MaxItemId = 2
    Me.BarManager1.StatusBar = Me.Bar3
    '
    'Bar3
    '
    Me.Bar3.BarName = "Status bar"
    Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.Bar3.DockCol = 0
    Me.Bar3.DockRow = 0
    Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDetail, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSetup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.Bar3.OptionsBar.AllowQuickCustomization = False
    Me.Bar3.OptionsBar.DrawDragBorder = False
    Me.Bar3.OptionsBar.UseWholeRow = True
    Me.Bar3.Text = "Status bar"
    '
    'btnDetail
    '
    Me.btnDetail.Caption = "Detail"
    Me.btnDetail.Glyph = CType(resources.GetObject("btnDetail.Glyph"), System.Drawing.Image)
    Me.btnDetail.Id = 0
    Me.btnDetail.LargeGlyph = CType(resources.GetObject("btnDetail.LargeGlyph"), System.Drawing.Image)
    Me.btnDetail.Name = "btnDetail"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Size = New System.Drawing.Size(759, 0)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 368)
    Me.barDockControlBottom.Size = New System.Drawing.Size(759, 27)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 368)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(759, 0)
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 368)
    '
    'btnSetup
    '
    Me.btnSetup.Caption = "Setup"
    Me.btnSetup.Glyph = CType(resources.GetObject("btnSetup.Glyph"), System.Drawing.Image)
    Me.btnSetup.Id = 1
    Me.btnSetup.LargeGlyph = CType(resources.GetObject("btnSetup.LargeGlyph"), System.Drawing.Image)
    Me.btnSetup.Name = "btnSetup"
    '
    'UI_SaldoARAPNew
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "UI_SaldoARAPNew"
    Me.Text = "UI_SaldoARAPNew"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nChart, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents nChart As DevExpress.XtraCharts.ChartControl
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJumlah As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBayar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents coLSaldo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJumlahValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBayarValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldoValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents btnDetail As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSetup As DevExpress.XtraBars.BarButtonItem
End Class
