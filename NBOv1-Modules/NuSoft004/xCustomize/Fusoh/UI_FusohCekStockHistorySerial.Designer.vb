<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohCekStockHistorySerial
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohCekStockHistorySerial))
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLengthIn = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLengthOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightIN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGrid.Location = New System.Drawing.Point(0, 0)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(800, 423)
    Me.xGrid.TabIndex = 0
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSerial, Me.colLengthIn, Me.colLengthOut, Me.GridColumn1, Me.colWeightIN, Me.colWeightOut, Me.GridColumn2, Me.GridColumn4})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colSerial
    '
    Me.colSerial.Caption = "Serial"
    Me.colSerial.FieldName = "Serial"
    Me.colSerial.Name = "colSerial"
    Me.colSerial.OptionsColumn.ReadOnly = True
    Me.colSerial.Visible = True
    Me.colSerial.VisibleIndex = 0
    '
    'colLengthIn
    '
    Me.colLengthIn.Caption = "Length IN"
    Me.colLengthIn.FieldName = "LengthIn"
    Me.colLengthIn.Name = "colLengthIn"
    Me.colLengthIn.OptionsColumn.AllowEdit = False
    Me.colLengthIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colLengthIn.Visible = True
    Me.colLengthIn.VisibleIndex = 1
    '
    'colLengthOut
    '
    Me.colLengthOut.Caption = "Length Out"
    Me.colLengthOut.FieldName = "LengthOut"
    Me.colLengthOut.Name = "colLengthOut"
    Me.colLengthOut.OptionsColumn.AllowEdit = False
    Me.colLengthOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colLengthOut.Visible = True
    Me.colLengthOut.VisibleIndex = 2
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Item Length"
    Me.GridColumn1.FieldName = "DetailMain.Barang.Length"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowEdit = False
    '
    'colWeightIN
    '
    Me.colWeightIN.Caption = "Weight IN"
    Me.colWeightIN.FieldName = "WeightIN"
    Me.colWeightIN.Name = "colWeightIN"
    Me.colWeightIN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colWeightIN.Visible = True
    Me.colWeightIN.VisibleIndex = 3
    '
    'colWeightOut
    '
    Me.colWeightOut.Caption = "Weight Out"
    Me.colWeightOut.FieldName = "WeightOUT"
    Me.colWeightOut.Name = "colWeightOut"
    Me.colWeightOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colWeightOut.Visible = True
    Me.colWeightOut.VisibleIndex = 4
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "NilaiHPP"
    Me.GridColumn2.FieldName = "NilaiHPPSN"
    Me.GridColumn2.Name = "GridColumn2"
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExport})
    Me.BarManager1.MaxItemId = 1
    Me.BarManager1.StatusBar = Me.Bar3
    '
    'Bar3
    '
    Me.Bar3.BarName = "Status bar"
    Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.Bar3.DockCol = 0
    Me.Bar3.DockRow = 0
    Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.Bar3.OptionsBar.AllowQuickCustomization = False
    Me.Bar3.OptionsBar.DrawDragBorder = False
    Me.Bar3.OptionsBar.UseWholeRow = True
    Me.Bar3.Text = "Status bar"
    '
    'btnExport
    '
    Me.btnExport.Caption = "Export"
    Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
    Me.btnExport.Id = 0
    Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
    Me.btnExport.Name = "btnExport"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Size = New System.Drawing.Size(800, 0)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 423)
    Me.barDockControlBottom.Size = New System.Drawing.Size(800, 27)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 423)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(800, 0)
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 423)
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Harga"
    Me.GridColumn4.FieldName = "HargaPerMM"
    Me.GridColumn4.Name = "GridColumn4"
    '
    'UI_FusohCekStockHistorySerial
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.xGrid)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.MinimizeBox = False
    Me.Name = "UI_FusohCekStockHistorySerial"
    Me.ShowIcon = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "UI_FusohCekStockHistorySerial"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colWeightIN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
