<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohDataProduksiSJ
  Inherits NuSoft.Core.Win.Forms.BlankForm

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohDataProduksiSJ))
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colOutDiameter = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colInDiameter = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNOLOT = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeProduksiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
		Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnDuplicate = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeProduksiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xGrid.Location = New System.Drawing.Point(0, 0)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colKodeProduksiRepo})
		Me.xGrid.Size = New System.Drawing.Size(890, 400)
		Me.xGrid.TabIndex = 0
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colQtyOut, Me.colHarga, Me.colOutDiameter, Me.colInDiameter, Me.colThickness, Me.colLength, Me.colWeight, Me.colCatatan, Me.colNOLOT, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		Me.colId.OptionsColumn.AllowEdit = False
		Me.colId.OptionsColumn.ReadOnly = True
		Me.colId.Visible = True
		Me.colId.VisibleIndex = 0
		'
		'colQtyOut
		'
		Me.colQtyOut.DisplayFormat.FormatString = "n0"
		Me.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyOut.FieldName = "QtyOut"
		Me.colQtyOut.Name = "colQtyOut"
		Me.colQtyOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOut", "{0:n0}")})
		Me.colQtyOut.Visible = True
		Me.colQtyOut.VisibleIndex = 6
		'
		'colHarga
		'
		Me.colHarga.DisplayFormat.FormatString = "n2"
		Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga.FieldName = "Harga"
		Me.colHarga.Name = "colHarga"
		Me.colHarga.OptionsColumn.AllowEdit = False
		Me.colHarga.OptionsColumn.ReadOnly = True
		Me.colHarga.Visible = True
		Me.colHarga.VisibleIndex = 7
		'
		'colOutDiameter
		'
		Me.colOutDiameter.FieldName = "OutDiameter"
		Me.colOutDiameter.Name = "colOutDiameter"
		Me.colOutDiameter.OptionsColumn.ReadOnly = True
		'
		'colInDiameter
		'
		Me.colInDiameter.FieldName = "InDiameter"
		Me.colInDiameter.Name = "colInDiameter"
		Me.colInDiameter.OptionsColumn.ReadOnly = True
		'
		'colThickness
		'
		Me.colThickness.FieldName = "Thickness"
		Me.colThickness.Name = "colThickness"
		Me.colThickness.OptionsColumn.ReadOnly = True
		'
		'colLength
		'
		Me.colLength.FieldName = "Length"
		Me.colLength.Name = "colLength"
		Me.colLength.OptionsColumn.ReadOnly = True
		'
		'colWeight
		'
		Me.colWeight.FieldName = "Weight"
		Me.colWeight.Name = "colWeight"
		Me.colWeight.OptionsColumn.ReadOnly = True
		'
		'colCatatan
		'
		Me.colCatatan.FieldName = "Catatan"
		Me.colCatatan.Name = "colCatatan"
		Me.colCatatan.Visible = True
		Me.colCatatan.VisibleIndex = 8
		'
		'colNOLOT
		'
		Me.colNOLOT.FieldName = "NOLOT"
		Me.colNOLOT.Name = "colNOLOT"
		Me.colNOLOT.OptionsColumn.ReadOnly = True
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Kode Barang"
		Me.GridColumn1.FieldName = "Barang.Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.OptionsColumn.AllowEdit = False
		Me.GridColumn1.OptionsColumn.ReadOnly = True
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 3
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Nama Barang"
		Me.GridColumn2.FieldName = "Barang.Nama"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.OptionsColumn.AllowEdit = False
		Me.GridColumn2.OptionsColumn.ReadOnly = True
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 4
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "No Bukti"
		Me.GridColumn3.FieldName = "Main.Kode"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.OptionsColumn.AllowEdit = False
		Me.GridColumn3.OptionsColumn.ReadOnly = True
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 2
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Tanggal"
		Me.GridColumn4.FieldName = "Main.Tanggal"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.OptionsColumn.AllowEdit = False
		Me.GridColumn4.OptionsColumn.ReadOnly = True
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 1
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Kode Produksi"
		Me.GridColumn5.ColumnEdit = Me.colKodeProduksiRepo
		Me.GridColumn5.FieldName = "ProduksiDetail"
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.Visible = True
		Me.GridColumn5.VisibleIndex = 5
		'
		'colKodeProduksiRepo
		'
		Me.colKodeProduksiRepo.AutoHeight = False
		Me.colKodeProduksiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colKodeProduksiRepo.DisplayMember = "Main.Kode"
		Me.colKodeProduksiRepo.Name = "colKodeProduksiRepo"
		Me.colKodeProduksiRepo.NullText = "<Pilih Kode Produksi>"
		Me.colKodeProduksiRepo.ValueMember = "This"
		Me.colKodeProduksiRepo.View = Me.RepositoryItemSearchLookUpEdit1View
		'
		'RepositoryItemSearchLookUpEdit1View
		'
		Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7})
		Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
		Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		'
		'GridColumn6
		'
		Me.GridColumn6.Caption = "No Bukti"
		Me.GridColumn6.FieldName = "Main.Kode"
		Me.GridColumn6.Name = "GridColumn6"
		Me.GridColumn6.Visible = True
		Me.GridColumn6.VisibleIndex = 0
		'
		'GridColumn7
		'
		Me.GridColumn7.Caption = "Tanggal"
		Me.GridColumn7.FieldName = "Main.Tanggal"
		Me.GridColumn7.Name = "GridColumn7"
		Me.GridColumn7.Visible = True
		Me.GridColumn7.VisibleIndex = 1
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnDuplicate, Me.btnSave, Me.BarButtonItem3})
		Me.BarManager1.MaxItemId = 3
		Me.BarManager1.StatusBar = Me.Bar3
		'
		'Bar3
		'
		Me.Bar3.BarName = "Status bar"
		Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
		Me.Bar3.DockCol = 0
		Me.Bar3.DockRow = 0
		Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
		Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDuplicate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSave, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.Bar3.OptionsBar.AllowQuickCustomization = False
		Me.Bar3.OptionsBar.DrawDragBorder = False
		Me.Bar3.OptionsBar.UseWholeRow = True
		Me.Bar3.Text = "Status bar"
		'
		'btnDuplicate
		'
		Me.btnDuplicate.Caption = "Duplicate"
		Me.btnDuplicate.Glyph = CType(resources.GetObject("btnDuplicate.Glyph"), System.Drawing.Image)
		Me.btnDuplicate.Id = 0
		Me.btnDuplicate.LargeGlyph = CType(resources.GetObject("btnDuplicate.LargeGlyph"), System.Drawing.Image)
		Me.btnDuplicate.Name = "btnDuplicate"
		'
		'btnSave
		'
		Me.btnSave.Caption = "Save"
		Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
		Me.btnSave.Id = 1
		Me.btnSave.LargeGlyph = CType(resources.GetObject("btnSave.LargeGlyph"), System.Drawing.Image)
		Me.btnSave.Name = "btnSave"
		'
		'BarButtonItem3
		'
		Me.BarButtonItem3.Caption = "Cancel"
		Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
		Me.BarButtonItem3.Id = 2
		Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
		Me.BarButtonItem3.Name = "BarButtonItem3"
		'
		'barDockControlTop
		'
		Me.barDockControlTop.CausesValidation = False
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Size = New System.Drawing.Size(890, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 400)
		Me.barDockControlBottom.Size = New System.Drawing.Size(890, 27)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 400)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(890, 0)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 400)
		'
		'UI_FusohDataProduksiSJ
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(890, 427)
		Me.ControlBox = False
		Me.Controls.Add(Me.xGrid)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.Name = "UI_FusohDataProduksiSJ"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "UI_FusohDataProduksiSJ"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeProduksiRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colOutDiameter As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colInDiameter As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colThickness As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNOLOT As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnDuplicate As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents colKodeProduksiRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
