<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanYuCekStock
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SanYuCekStock))
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.btnTampilkan = New DevExpress.XtraEditors.SimpleButton()
    Me.xGridLokasi = New DevExpress.XtraGrid.GridControl()
    Me.xGridLokasiView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLokasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xGridStock = New DevExpress.XtraGrid.GridControl()
    Me.xGridStockView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyIn = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtNama = New DevExpress.XtraEditors.TextEdit()
    Me.txtKode = New DevExpress.XtraEditors.TextEdit()
    Me.lyLokasi = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.cmdHistory = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetakData = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.btnHistoryHPP = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCekSerial = New DevExpress.XtraBars.BarButtonItem()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.xGridLokasi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridLokasiView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridStock, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridStockView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lyLokasi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.btnTampilkan)
    Me.LayoutControl1.Controls.Add(Me.xGridLokasi)
    Me.LayoutControl1.Controls.Add(Me.xGridStock)
    Me.LayoutControl1.Controls.Add(Me.txtNama)
    Me.LayoutControl1.Controls.Add(Me.txtKode)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lyLokasi})
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(579, 264, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(984, 436)
    Me.LayoutControl1.TabIndex = 0
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'btnTampilkan
    '
    Me.btnTampilkan.Location = New System.Drawing.Point(324, 22)
    Me.btnTampilkan.Name = "btnTampilkan"
    Me.btnTampilkan.Size = New System.Drawing.Size(115, 22)
    Me.btnTampilkan.StyleController = Me.LayoutControl1
    Me.btnTampilkan.TabIndex = 8
    Me.btnTampilkan.Text = "Tampilkan Data"
    '
    'xGridLokasi
    '
    Me.xGridLokasi.Location = New System.Drawing.Point(562, 98)
    Me.xGridLokasi.MainView = Me.xGridLokasiView
    Me.xGridLokasi.Name = "xGridLokasi"
    Me.xGridLokasi.Size = New System.Drawing.Size(380, 353)
    Me.xGridLokasi.TabIndex = 7
    Me.xGridLokasi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridLokasiView})
    '
    'xGridLokasiView
    '
    Me.xGridLokasiView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colLokasi})
    Me.xGridLokasiView.GridControl = Me.xGridLokasi
    Me.xGridLokasiView.Name = "xGridLokasiView"
    Me.xGridLokasiView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridLokasiView.OptionsView.ShowGroupPanel = False
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode"
    Me.GridColumn1.FieldName = "Barang.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama"
    Me.GridColumn2.FieldName = "Barang.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Gudang"
    Me.GridColumn3.FieldName = "Gudang.Nama"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'colLokasi
    '
    Me.colLokasi.Caption = "Lokasi"
    Me.colLokasi.FieldName = "Lokasi"
    Me.colLokasi.Name = "colLokasi"
    Me.colLokasi.Visible = True
    Me.colLokasi.VisibleIndex = 3
    '
    'xGridStock
    '
    Me.xGridStock.Location = New System.Drawing.Point(25, 97)
    Me.xGridStock.MainView = Me.xGridStockView
    Me.xGridStock.Name = "xGridStock"
    Me.xGridStock.Size = New System.Drawing.Size(902, 353)
    Me.xGridStock.TabIndex = 6
    Me.xGridStock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridStockView})
    '
    'xGridStockView
    '
    Me.xGridStockView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.colId1, Me.GridColumn4, Me.colKode, Me.colNama, Me.colQtyIn, Me.colQtyOut, Me.colStock})
    Me.xGridStockView.GridControl = Me.xGridStock
    Me.xGridStockView.GroupCount = 1
    Me.xGridStockView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Stock", Nothing, "  ({0})")})
    Me.xGridStockView.Name = "xGridStockView"
    Me.xGridStockView.OptionsBehavior.Editable = False
    Me.xGridStockView.OptionsBehavior.ReadOnly = True
    Me.xGridStockView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridStockView.OptionsView.ColumnAutoWidth = False
    Me.xGridStockView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn8, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Tipe"
    Me.GridColumn8.FieldName = "Barang.TipeBarang"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 0
    '
    'colId1
    '
    Me.colId1.FieldName = "Id"
    Me.colId1.Name = "colId1"
    '
    'colKode
    '
    Me.colKode.Caption = "Kode"
    Me.colKode.FieldName = "Barang.Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Barang.Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    '
    'colQtyIn
    '
    Me.colQtyIn.Caption = "Masuk"
    Me.colQtyIn.DisplayFormat.FormatString = "n0"
    Me.colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQtyIn.FieldName = "QtyIn"
    Me.colQtyIn.Name = "colQtyIn"
    Me.colQtyIn.Visible = True
    Me.colQtyIn.VisibleIndex = 3
    '
    'colQtyOut
    '
    Me.colQtyOut.Caption = "Keluar"
    Me.colQtyOut.DisplayFormat.FormatString = "n0"
    Me.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQtyOut.FieldName = "QtyOut"
    Me.colQtyOut.Name = "colQtyOut"
    Me.colQtyOut.Visible = True
    Me.colQtyOut.VisibleIndex = 4
    '
    'colStock
    '
    Me.colStock.Caption = "Stock"
    Me.colStock.DisplayFormat.FormatString = "n0"
    Me.colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colStock.FieldName = "Stock"
    Me.colStock.Name = "colStock"
    Me.colStock.Visible = True
    Me.colStock.VisibleIndex = 5
    '
    'txtNama
    '
    Me.txtNama.Location = New System.Drawing.Point(80, 46)
    Me.txtNama.Name = "txtNama"
    Me.txtNama.Size = New System.Drawing.Size(228, 20)
    Me.txtNama.StyleController = Me.LayoutControl1
    Me.txtNama.TabIndex = 5
    '
    'txtKode
    '
    Me.txtKode.Location = New System.Drawing.Point(80, 22)
    Me.txtKode.Name = "txtKode"
    Me.txtKode.Size = New System.Drawing.Size(228, 20)
    Me.txtKode.StyleController = Me.LayoutControl1
    Me.txtKode.TabIndex = 4
    '
    'lyLokasi
    '
    Me.lyLokasi.Control = Me.xGridLokasi
    Me.lyLokasi.CustomizationFormText = "LayoutControlItem4"
    Me.lyLokasi.Location = New System.Drawing.Point(550, 70)
    Me.lyLokasi.MinSize = New System.Drawing.Size(104, 40)
    Me.lyLokasi.Name = "lyLokasi"
    Me.lyLokasi.Size = New System.Drawing.Size(384, 373)
    Me.lyLokasi.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.lyLokasi.Text = "Data Lokasi"
    Me.lyLokasi.TextLocation = DevExpress.Utils.Locations.Top
    Me.lyLokasi.TextSize = New System.Drawing.Size(55, 13)
    Me.lyLokasi.TextToControlDistance = 5
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem6, Me.LayoutControlItem3, Me.EmptySpaceItem5, Me.EmptySpaceItem7, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem8, Me.LayoutControlItem5})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(967, 462)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(934, 10)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(13, 432)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(13, 0)
    Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(0, 10)
    Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(934, 10)
    Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 0)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(13, 442)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(13, 58)
    Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(0, 11)
    Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(10, 11)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(921, 11)
    Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.xGridStock
    Me.LayoutControlItem3.CustomizationFormText = "Data Stock"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(13, 69)
    Me.LayoutControlItem3.MinSize = New System.Drawing.Size(104, 40)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(906, 373)
    Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem3.Text = "Data Stock"
    Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(52, 13)
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(919, 69)
    Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(15, 373)
    Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(15, 373)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(15, 373)
    Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem7
    '
    Me.EmptySpaceItem7.AllowHotTrack = False
    Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Location = New System.Drawing.Point(300, 10)
    Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Size = New System.Drawing.Size(12, 48)
    Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
    Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKode
    Me.LayoutControlItem1.CustomizationFormText = "Kode"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(13, 10)
    Me.LayoutControlItem1.MinSize = New System.Drawing.Size(112, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(287, 24)
    Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem1.Text = "Kode"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtNama
    Me.LayoutControlItem2.CustomizationFormText = "Nama"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(13, 34)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(287, 24)
    Me.LayoutControlItem2.Text = "Nama"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
    '
    'EmptySpaceItem8
    '
    Me.EmptySpaceItem8.AllowHotTrack = False
    Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Location = New System.Drawing.Point(431, 10)
    Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(104, 24)
    Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Size = New System.Drawing.Size(503, 48)
    Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
    Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.btnTampilkan
    Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(312, 10)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(119, 48)
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCetakData, Me.cmdHistory, Me.btnHistoryHPP, Me.btnCekSerial})
    Me.BarManager1.MaxItemId = 4
    Me.BarManager1.StatusBar = Me.Bar3
    '
    'Bar3
    '
    Me.Bar3.BarName = "Status bar"
    Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.Bar3.DockCol = 0
    Me.Bar3.DockRow = 0
    Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdHistory, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetakData, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.Bar3.OptionsBar.AllowQuickCustomization = False
    Me.Bar3.OptionsBar.DrawDragBorder = False
    Me.Bar3.OptionsBar.UseWholeRow = True
    Me.Bar3.Text = "Status bar"
    '
    'cmdHistory
    '
    Me.cmdHistory.Caption = "History Stock"
    Me.cmdHistory.Glyph = CType(resources.GetObject("cmdHistory.Glyph"), System.Drawing.Image)
    Me.cmdHistory.Id = 1
    Me.cmdHistory.LargeGlyph = CType(resources.GetObject("cmdHistory.LargeGlyph"), System.Drawing.Image)
    Me.cmdHistory.Name = "cmdHistory"
    '
    'btnCetakData
    '
    Me.btnCetakData.Caption = "Cetak Data"
    Me.btnCetakData.Glyph = CType(resources.GetObject("btnCetakData.Glyph"), System.Drawing.Image)
    Me.btnCetakData.Id = 0
    Me.btnCetakData.LargeGlyph = CType(resources.GetObject("btnCetakData.LargeGlyph"), System.Drawing.Image)
    Me.btnCetakData.Name = "btnCetakData"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Size = New System.Drawing.Size(984, 0)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 436)
    Me.barDockControlBottom.Size = New System.Drawing.Size(984, 27)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 436)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(984, 0)
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 436)
    '
    'btnHistoryHPP
    '
    Me.btnHistoryHPP.Caption = "History HPP"
    Me.btnHistoryHPP.Glyph = CType(resources.GetObject("btnHistoryHPP.Glyph"), System.Drawing.Image)
    Me.btnHistoryHPP.Id = 2
    Me.btnHistoryHPP.LargeGlyph = CType(resources.GetObject("btnHistoryHPP.LargeGlyph"), System.Drawing.Image)
    Me.btnHistoryHPP.Name = "btnHistoryHPP"
    Me.btnHistoryHPP.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'btnCekSerial
    '
    Me.btnCekSerial.Caption = "Cek Stock Serial"
    Me.btnCekSerial.Glyph = CType(resources.GetObject("btnCekSerial.Glyph"), System.Drawing.Image)
    Me.btnCekSerial.Id = 3
    Me.btnCekSerial.LargeGlyph = CType(resources.GetObject("btnCekSerial.LargeGlyph"), System.Drawing.Image)
    Me.btnCekSerial.Name = "btnCekSerial"
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Gudang"
    Me.GridColumn4.FieldName = "Gudang.Kode"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 2
    '
    'UI_SanYuCekStock
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(984, 463)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "UI_SanYuCekStock"
    Me.Text = "Cek Stock SanYu"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.xGridLokasi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridLokasiView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridStock, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridStockView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lyLokasi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents xGridLokasi As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridLokasiView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents xGridStock As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridStockView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents lyLokasi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents btnTampilkan As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLokasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnCetakData As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents cmdHistory As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnHistoryHPP As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCekSerial As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
