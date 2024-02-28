<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohDataSerial2
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohDataSerial2))
		Me.cmdFilter = New DevExpress.XtraEditors.SimpleButton()
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.grdDempyou = New DevExpress.XtraGrid.GridControl()
		Me.grdDempyouView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMillsheet1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSerial1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSNLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colScrap = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		Me.gridStockSerial = New DevExpress.XtraGrid.GridControl()
		Me.gridStockSerialView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.cmdSimpan = New DevExpress.XtraEditors.SimpleButton()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMillSheet = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthOut = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtSerial = New DevExpress.XtraEditors.TextEdit()
		Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
		Me.btnExport2 = New DevExpress.XtraBars.BarButtonItem()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.grdDempyou, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdDempyouView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridStockSerial, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridStockSerialView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSerial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cmdFilter
		'
		Me.cmdFilter.Location = New System.Drawing.Point(681, 91)
		Me.cmdFilter.Name = "cmdFilter"
		Me.cmdFilter.Size = New System.Drawing.Size(232, 22)
		Me.cmdFilter.StyleController = Me.LayoutControl1
		Me.cmdFilter.TabIndex = 1
		Me.cmdFilter.Text = "Tampilkan"
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.grdDempyou)
		Me.LayoutControl1.Controls.Add(Me.gridStockSerial)
		Me.LayoutControl1.Controls.Add(Me.cmdSimpan)
		Me.LayoutControl1.Controls.Add(Me.xGrid)
		Me.LayoutControl1.Controls.Add(Me.cmdFilter)
		Me.LayoutControl1.Controls.Add(Me.txtSerial)
		Me.LayoutControl1.Controls.Add(Me.txtItem)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(350, 171, 250, 350)
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(937, 391)
		Me.LayoutControl1.TabIndex = 4
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'grdDempyou
		'
		Me.grdDempyou.Location = New System.Drawing.Point(12, 214)
		Me.grdDempyou.MainView = Me.grdDempyouView
		Me.grdDempyou.MenuManager = Me.BarManager1
		Me.grdDempyou.Name = "grdDempyou"
		Me.grdDempyou.Size = New System.Drawing.Size(653, 165)
		Me.grdDempyou.TabIndex = 6
		Me.grdDempyou.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDempyouView})
		'
		'grdDempyouView
		'
		Me.grdDempyouView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colId, Me.GridColumn13, Me.GridColumn14, Me.colMillsheet1, Me.colSerial1, Me.colSNLength, Me.colLength, Me.colQty1, Me.colWeight, Me.colCatatan, Me.colScrap})
		Me.grdDempyouView.GridControl = Me.grdDempyou
		Me.grdDempyouView.Name = "grdDempyouView"
		Me.grdDempyouView.OptionsDetail.EnableMasterViewMode = False
		Me.grdDempyouView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colcreated_date, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'colcreated_date
		'
		Me.colcreated_date.FieldName = "created_date"
		Me.colcreated_date.Name = "colcreated_date"
		Me.colcreated_date.Visible = True
		Me.colcreated_date.VisibleIndex = 0
		'
		'colcreated_user
		'
		Me.colcreated_user.FieldName = "created_user"
		Me.colcreated_user.Name = "colcreated_user"
		'
		'collast_date
		'
		Me.collast_date.FieldName = "last_date"
		Me.collast_date.Name = "collast_date"
		'
		'collast_modified
		'
		Me.collast_modified.FieldName = "last_modified"
		Me.collast_modified.Name = "collast_modified"
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		Me.colId.Visible = True
		Me.colId.VisibleIndex = 1
		'
		'GridColumn13
		'
		Me.GridColumn13.Caption = "No Dempyou"
		Me.GridColumn13.FieldName = "Main.Kode"
		Me.GridColumn13.Name = "GridColumn13"
		Me.GridColumn13.Visible = True
		Me.GridColumn13.VisibleIndex = 2
		'
		'GridColumn14
		'
		Me.GridColumn14.Caption = "Tanggal Dempyou"
		Me.GridColumn14.FieldName = "Main.Tanggal"
		Me.GridColumn14.Name = "GridColumn14"
		Me.GridColumn14.Visible = True
		Me.GridColumn14.VisibleIndex = 3
		'
		'colMillsheet1
		'
		Me.colMillsheet1.Caption = "MillSheet"
		Me.colMillsheet1.FieldName = "Millsheet"
		Me.colMillsheet1.Name = "colMillsheet1"
		Me.colMillsheet1.Visible = True
		Me.colMillsheet1.VisibleIndex = 4
		'
		'colSerial1
		'
		Me.colSerial1.Caption = "No Serial"
		Me.colSerial1.FieldName = "Serial"
		Me.colSerial1.Name = "colSerial1"
		Me.colSerial1.Visible = True
		Me.colSerial1.VisibleIndex = 5
		'
		'colSNLength
		'
		Me.colSNLength.Caption = "Length SN"
		Me.colSNLength.FieldName = "SNLength"
		Me.colSNLength.Name = "colSNLength"
		Me.colSNLength.Visible = True
		Me.colSNLength.VisibleIndex = 6
		'
		'colLength
		'
		Me.colLength.Caption = "Length Dempyou"
		Me.colLength.FieldName = "Length"
		Me.colLength.Name = "colLength"
		Me.colLength.Visible = True
		Me.colLength.VisibleIndex = 7
		'
		'colQty1
		'
		Me.colQty1.Caption = "Qty"
		Me.colQty1.FieldName = "Qty"
		Me.colQty1.Name = "colQty1"
		Me.colQty1.Visible = True
		Me.colQty1.VisibleIndex = 8
		'
		'colWeight
		'
		Me.colWeight.FieldName = "Weight"
		Me.colWeight.Name = "colWeight"
		Me.colWeight.Visible = True
		Me.colWeight.VisibleIndex = 9
		'
		'colCatatan
		'
		Me.colCatatan.FieldName = "Catatan"
		Me.colCatatan.Name = "colCatatan"
		Me.colCatatan.Visible = True
		Me.colCatatan.VisibleIndex = 10
		'
		'colScrap
		'
		Me.colScrap.FieldName = "Scrap"
		Me.colScrap.Name = "colScrap"
		Me.colScrap.Visible = True
		Me.colScrap.VisibleIndex = 11
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExport, Me.btnExport2})
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
		Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
		Me.barDockControlTop.Size = New System.Drawing.Size(937, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 391)
		Me.barDockControlBottom.Size = New System.Drawing.Size(937, 27)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 391)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(937, 0)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 391)
		'
		'gridStockSerial
		'
		Me.gridStockSerial.Location = New System.Drawing.Point(669, 129)
		Me.gridStockSerial.MainView = Me.gridStockSerialView
		Me.gridStockSerial.MenuManager = Me.BarManager1
		Me.gridStockSerial.Name = "gridStockSerial"
		Me.gridStockSerial.Size = New System.Drawing.Size(256, 193)
		Me.gridStockSerial.TabIndex = 5
		Me.gridStockSerial.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridStockSerialView})
		'
		'gridStockSerialView
		'
		Me.gridStockSerialView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
		Me.gridStockSerialView.GridControl = Me.gridStockSerial
		Me.gridStockSerialView.Name = "gridStockSerialView"
		'
		'GridColumn9
		'
		Me.GridColumn9.Caption = "Serial"
		Me.GridColumn9.FieldName = "Serial"
		Me.GridColumn9.Name = "GridColumn9"
		Me.GridColumn9.Visible = True
		Me.GridColumn9.VisibleIndex = 0
		'
		'GridColumn10
		'
		Me.GridColumn10.Caption = "Length"
		Me.GridColumn10.FieldName = "SisaLength"
		Me.GridColumn10.Name = "GridColumn10"
		Me.GridColumn10.Visible = True
		Me.GridColumn10.VisibleIndex = 1
		'
		'GridColumn11
		'
		Me.GridColumn11.Caption = "Qty"
		Me.GridColumn11.FieldName = "Qty"
		Me.GridColumn11.Name = "GridColumn11"
		Me.GridColumn11.Visible = True
		Me.GridColumn11.VisibleIndex = 2
		'
		'cmdSimpan
		'
		Me.cmdSimpan.Location = New System.Drawing.Point(669, 357)
		Me.cmdSimpan.Name = "cmdSimpan"
		Me.cmdSimpan.Size = New System.Drawing.Size(256, 22)
		Me.cmdSimpan.StyleController = Me.LayoutControl1
		Me.cmdSimpan.TabIndex = 3
		Me.cmdSimpan.Text = "Simpan Data"
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 12)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(653, 367)
		Me.xGrid.TabIndex = 4
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn12, Me.GridColumn5, Me.GridColumn3, Me.GridColumn4, Me.colMillSheet, Me.colSerial, Me.colLengthIn, Me.colLengthOut, Me.colQty, Me.GridColumn7, Me.GridColumn8, Me.GridColumn15, Me.GridColumn17, Me.GridColumn16, Me.GridColumn18, Me.GridColumn19})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah data"
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'GridColumn6
		'
		Me.GridColumn6.Caption = "No Bukti"
		Me.GridColumn6.FieldName = "DetailMain.Main.Kode"
		Me.GridColumn6.Name = "GridColumn6"
		Me.GridColumn6.Visible = True
		Me.GridColumn6.VisibleIndex = 0
		'
		'GridColumn12
		'
		Me.GridColumn12.Caption = "No Dempyou"
		Me.GridColumn12.FieldName = "DetailMain.Main.OrderProduksi.Kode"
		Me.GridColumn12.Name = "GridColumn12"
		Me.GridColumn12.Visible = True
		Me.GridColumn12.VisibleIndex = 1
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Tanggal"
		Me.GridColumn5.FieldName = "DetailMain.Main.Tanggal"
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.Visible = True
		Me.GridColumn5.VisibleIndex = 2
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Kode Barang"
		Me.GridColumn3.FieldName = "DetailMain.Barang.Kode"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.OptionsColumn.AllowEdit = False
		Me.GridColumn3.OptionsColumn.ReadOnly = True
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 3
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Nama Barang"
		Me.GridColumn4.FieldName = "DetailMain.Barang.Nama"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.OptionsColumn.AllowEdit = False
		Me.GridColumn4.OptionsColumn.ReadOnly = True
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 4
		'
		'colMillSheet
		'
		Me.colMillSheet.Caption = "Mill Sheet"
		Me.colMillSheet.FieldName = "MillSheet"
		Me.colMillSheet.Name = "colMillSheet"
		Me.colMillSheet.Visible = True
		Me.colMillSheet.VisibleIndex = 5
		'
		'colSerial
		'
		Me.colSerial.Caption = "Serial"
		Me.colSerial.FieldName = "Serial"
		Me.colSerial.Name = "colSerial"
		Me.colSerial.Visible = True
		Me.colSerial.VisibleIndex = 6
		'
		'colLengthIn
		'
		Me.colLengthIn.FieldName = "LengthIn"
		Me.colLengthIn.Name = "colLengthIn"
		Me.colLengthIn.OptionsColumn.AllowEdit = False
		Me.colLengthIn.OptionsColumn.ReadOnly = True
		Me.colLengthIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colLengthIn.Visible = True
		Me.colLengthIn.VisibleIndex = 7
		'
		'colLengthOut
		'
		Me.colLengthOut.FieldName = "LengthOut"
		Me.colLengthOut.Name = "colLengthOut"
		Me.colLengthOut.OptionsColumn.AllowEdit = False
		Me.colLengthOut.OptionsColumn.ReadOnly = True
		Me.colLengthOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colLengthOut.Visible = True
		Me.colLengthOut.VisibleIndex = 8
		'
		'colQty
		'
		Me.colQty.Caption = "Qty"
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 9
		'
		'GridColumn7
		'
		Me.GridColumn7.Caption = "Weight IN"
		Me.GridColumn7.FieldName = "WeightIN"
		Me.GridColumn7.Name = "GridColumn7"
		Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		'
		'GridColumn8
		'
		Me.GridColumn8.Caption = "Weight Out"
		Me.GridColumn8.FieldName = "WeightOUT"
		Me.GridColumn8.Name = "GridColumn8"
		Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		'
		'GridColumn15
		'
		Me.GridColumn15.Caption = "Harga (perMM)"
		Me.GridColumn15.FieldName = "HargaSerialMM"
		Me.GridColumn15.Name = "GridColumn15"
		'
		'GridColumn17
		'
		Me.GridColumn17.Caption = "Nilai IN"
		Me.GridColumn17.FieldName = "NilaiIN"
		Me.GridColumn17.Name = "GridColumn17"
		'
		'GridColumn16
		'
		Me.GridColumn16.Caption = "Nilai Out"
		Me.GridColumn16.FieldName = "NilaiHPPSN"
		Me.GridColumn16.Name = "GridColumn16"
		'
		'GridColumn18
		'
		Me.GridColumn18.Caption = "Created Date"
		Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.GridColumn18.FieldName = "DetailMain.Main.created_date"
		Me.GridColumn18.Name = "GridColumn18"
		'
		'GridColumn19
		'
		Me.GridColumn19.Caption = "Last Modified"
		Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.GridColumn19.FieldName = "DetailMain.Main.last_date"
		Me.GridColumn19.Name = "GridColumn19"
		'
		'txtSerial
		'
		Me.txtSerial.Location = New System.Drawing.Point(733, 67)
		Me.txtSerial.Name = "txtSerial"
		Me.txtSerial.Size = New System.Drawing.Size(180, 20)
		Me.txtSerial.StyleController = Me.LayoutControl1
		Me.txtSerial.TabIndex = 2
		'
		'txtItem
		'
		Me.txtItem.Location = New System.Drawing.Point(733, 43)
		Me.txtItem.Name = "txtItem"
		Me.txtItem.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
		Me.txtItem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtItem.Properties.DisplayMember = "Kode"
		Me.txtItem.Properties.NullText = ""
		Me.txtItem.Properties.ValueMember = "This"
		Me.txtItem.Properties.View = Me.SearchLookUpEdit1View
		Me.txtItem.Size = New System.Drawing.Size(180, 20)
		Me.txtItem.StyleController = Me.LayoutControl1
		Me.txtItem.TabIndex = 0
		'
		'SearchLookUpEdit1View
		'
		Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
		Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
		Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Kode"
		Me.GridColumn1.FieldName = "Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Nama"
		Me.GridColumn2.FieldName = "Nama"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.grdDempyou
		Me.LayoutControlItem7.CustomizationFormText = "Data Dempyou"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 186)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(657, 185)
		Me.LayoutControlItem7.Text = "Data Dempyou"
		Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(71, 13)
		Me.LayoutControlItem7.TextToControlDistance = 5
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlGroup2, Me.LayoutControlItem6})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(937, 391)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.xGrid
		Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(657, 371)
		Me.LayoutControlItem1.Text = "LayoutControlItem1"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem1.TextToControlDistance = 0
		Me.LayoutControlItem1.TextVisible = False
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.cmdSimpan
		Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(657, 345)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(260, 26)
		Me.LayoutControlItem5.Text = "LayoutControlItem5"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem5.TextToControlDistance = 0
		Me.LayoutControlItem5.TextVisible = False
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(657, 314)
		Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(0, 31)
		Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(10, 31)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(260, 31)
		Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlGroup2
		'
		Me.LayoutControlGroup2.CustomizationFormText = "Filter Data"
		Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
		Me.LayoutControlGroup2.Location = New System.Drawing.Point(657, 0)
		Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Size = New System.Drawing.Size(260, 117)
		Me.LayoutControlGroup2.Text = "Filter Data"
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtItem
		Me.LayoutControlItem2.CustomizationFormText = "Kode Item"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(236, 24)
		Me.LayoutControlItem2.Text = "Kode Item"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(49, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtSerial
		Me.LayoutControlItem3.CustomizationFormText = "Serial"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(236, 24)
		Me.LayoutControlItem3.Text = "Serial"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(49, 13)
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.cmdFilter
		Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(236, 26)
		Me.LayoutControlItem4.Text = "LayoutControlItem4"
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem4.TextToControlDistance = 0
		Me.LayoutControlItem4.TextVisible = False
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.gridStockSerial
		Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(657, 117)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(260, 197)
		Me.LayoutControlItem6.Text = "LayoutControlItem6"
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem6.TextToControlDistance = 0
		Me.LayoutControlItem6.TextVisible = False
		'
		'btnExport2
		'
		Me.btnExport2.Caption = "Export Grid SN"
		Me.btnExport2.Glyph = CType(resources.GetObject("btnExport2.Glyph"), System.Drawing.Image)
		Me.btnExport2.Id = 1
		Me.btnExport2.LargeGlyph = CType(resources.GetObject("btnExport2.LargeGlyph"), System.Drawing.Image)
		Me.btnExport2.Name = "btnExport2"
		'
		'UI_FusohDataSerial2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(937, 418)
		Me.Controls.Add(Me.LayoutControl1)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.Name = "UI_FusohDataSerial2"
		Me.Text = "Data Serial"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.grdDempyou, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdDempyouView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridStockSerial, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridStockSerialView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSerial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents cmdFilter As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents cmdSimpan As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtSerial As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtItem As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gridStockSerial As DevExpress.XtraGrid.GridControl
  Friend WithEvents gridStockSerialView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents grdDempyou As DevExpress.XtraGrid.GridControl
  Friend WithEvents grdDempyouView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colMillsheet1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSerial1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSNLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colScrap As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnExport2 As DevExpress.XtraBars.BarButtonItem
End Class
