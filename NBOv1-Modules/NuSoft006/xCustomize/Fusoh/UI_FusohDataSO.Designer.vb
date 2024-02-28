<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohDataSO
  Inherits Core.Win.Forms.BlankForm

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
    Me.components = New System.ComponentModel.Container()
    Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohDataSO))
    Me.xGridSJ = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gridSQ = New DevExpress.XtraGrid.GridControl()
    Me.xpCol = New DevExpress.Xpo.XPCollection(Me.components)
    Me.xGridSQ = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyKirim = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPOLine = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoPODetail = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.btnExportExcell = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridSJ, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gridSQ, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridSQ, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGridSJ
    '
    Me.xGridSJ.ActiveFilterString = "[QtySJ] > '0'"
    Me.xGridSJ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn11, Me.GridColumn13, Me.GridColumn14})
    Me.xGridSJ.GridControl = Me.gridSQ
    Me.xGridSJ.Name = "xGridSJ"
    Me.xGridSJ.OptionsBehavior.Editable = False
    Me.xGridSJ.OptionsBehavior.ReadOnly = True
    Me.xGridSJ.OptionsDetail.EnableMasterViewMode = False
    Me.xGridSJ.OptionsView.ShowGroupPanel = False
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Tanggal"
    Me.GridColumn7.FieldName = "Main.Tanggal"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 0
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "No Transaksi"
    Me.GridColumn8.FieldName = "Main.Kode"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 1
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "Qty"
    Me.GridColumn9.FieldName = "QtySJ"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 2
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Sumber"
    Me.GridColumn11.FieldName = "Main.Sumber.Kode"
    Me.GridColumn11.Name = "GridColumn11"
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "No Produksi"
    Me.GridColumn13.FieldName = "ProduksiDetail.Main.Kode"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 3
    '
    'GridColumn14
    '
    Me.GridColumn14.Caption = "No SO Produksi"
    Me.GridColumn14.FieldName = "ProduksiDetail.SODetail.Main.Kode"
    Me.GridColumn14.Name = "GridColumn14"
    '
    'gridSQ
    '
    Me.gridSQ.DataSource = Me.xpCol
    Me.gridSQ.Dock = System.Windows.Forms.DockStyle.Fill
    GridLevelNode1.LevelTemplate = Me.xGridSJ
    GridLevelNode1.RelationName = "SuratJalanDetail"
    Me.gridSQ.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
    Me.gridSQ.Location = New System.Drawing.Point(0, 0)
    Me.gridSQ.MainView = Me.xGridSQ
    Me.gridSQ.Name = "gridSQ"
    Me.gridSQ.Size = New System.Drawing.Size(800, 423)
    Me.gridSQ.TabIndex = 8
    Me.gridSQ.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridSQ, Me.xGridSJ})
    '
    'xpCol
    '
    Me.xpCol.DisplayableProperties = resources.GetString("xpCol.DisplayableProperties")
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.Fusoh_OrderPenjualanDetail)
    '
    'xGridSQ
    '
    Me.xGridSQ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.colQtyKirim, Me.colQty, Me.GridColumn12, Me.GridColumn10, Me.colPOLine, Me.colNoPODetail, Me.colId, Me.GridColumn15, Me.colDeliveryDate})
    Me.xGridSQ.GridControl = Me.gridSQ
    Me.xGridSQ.GroupCount = 1
    Me.xGridSQ.Name = "xGridSQ"
    Me.xGridSQ.OptionsBehavior.Editable = False
    Me.xGridSQ.OptionsBehavior.ReadOnly = True
    Me.xGridSQ.OptionsDetail.SmartDetailHeight = True
    Me.xGridSQ.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn10, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn1
    '
    Me.GridColumn1.FieldName = "Main.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.FieldName = "Main.Tanggal"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.FieldName = "Main.Pelanggan.Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.FieldName = "Main.Pelanggan.Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.FieldName = "Barang.Kode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 5
    '
    'GridColumn6
    '
    Me.GridColumn6.FieldName = "Barang.Nama"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 6
    '
    'colQtyKirim
    '
    Me.colQtyKirim.FieldName = "QtyKirim"
    Me.colQtyKirim.Name = "colQtyKirim"
    Me.colQtyKirim.Visible = True
    Me.colQtyKirim.VisibleIndex = 8
    '
    'colQty
    '
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 7
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "Qty Sisa"
    Me.GridColumn12.FieldName = "QtySisa"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 9
    '
    'GridColumn10
    '
    Me.GridColumn10.FieldName = "Main.Tahun"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 0
    '
    'colPOLine
    '
    Me.colPOLine.FieldName = "POLine"
    Me.colPOLine.Name = "colPOLine"
    Me.colPOLine.Visible = True
    Me.colPOLine.VisibleIndex = 4
    '
    'colNoPODetail
    '
    Me.colNoPODetail.FieldName = "NoPODetail"
    Me.colNoPODetail.Name = "colNoPODetail"
    Me.colNoPODetail.Visible = True
    Me.colNoPODetail.VisibleIndex = 10
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExportExcell})
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
    Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExportExcell, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.Bar3.OptionsBar.AllowQuickCustomization = False
    Me.Bar3.OptionsBar.DrawDragBorder = False
    Me.Bar3.OptionsBar.UseWholeRow = True
    Me.Bar3.Text = "Status bar"
    '
    'btnExportExcell
    '
    Me.btnExportExcell.Caption = "Export Excell"
    Me.btnExportExcell.Glyph = CType(resources.GetObject("btnExportExcell.Glyph"), System.Drawing.Image)
    Me.btnExportExcell.Id = 0
    Me.btnExportExcell.LargeGlyph = CType(resources.GetObject("btnExportExcell.LargeGlyph"), System.Drawing.Image)
    Me.btnExportExcell.Name = "btnExportExcell"
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
    'GridColumn15
    '
    Me.GridColumn15.Caption = "Term Delivery"
    Me.GridColumn15.FieldName = "Main.DeliveryDate"
    Me.GridColumn15.Name = "GridColumn15"
    Me.GridColumn15.Visible = True
    Me.GridColumn15.VisibleIndex = 11
    '
    'colDeliveryDate
    '
    Me.colDeliveryDate.Caption = "Delivery Date"
    Me.colDeliveryDate.FieldName = "DeliveryDate"
    Me.colDeliveryDate.Name = "colDeliveryDate"
    Me.colDeliveryDate.Visible = True
    Me.colDeliveryDate.VisibleIndex = 12
    '
    'UI_FusohDataSO
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.gridSQ)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "UI_FusohDataSO"
    Me.Text = "Data SO"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridSJ, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gridSQ, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridSQ, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents gridSQ As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridSQ As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents xpCol As DevExpress.Xpo.XPCollection
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyKirim As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xGridSJ As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPOLine As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnExportExcell As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents colNoPODetail As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
