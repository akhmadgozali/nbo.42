<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohCekStockHistory
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohCekStockHistory))
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoBuktiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyIn = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyOutRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotalRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.colWeightIN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoX = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHargaProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIdMain = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHPPSN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
    Me.btnExportGridSerial = New DevExpress.XtraBars.BarButtonItem()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.btnShowGridSerial = New DevExpress.XtraBars.BarButtonItem()
    Me.btnShowDempyou = New DevExpress.XtraBars.BarButtonItem()
    Me.btnProduksi = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.xGridProduksi = New DevExpress.XtraGrid.GridControl()
    Me.xGridProduksiView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
    Me.btnTransfer = New DevExpress.XtraEditors.SimpleButton()
    Me.xGridDempyou = New DevExpress.XtraGrid.GridControl()
    Me.xGridDempyouView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.chkGabung = New DevExpress.XtraEditors.CheckEdit()
    Me.xGridSerial = New DevExpress.XtraGrid.GridControl()
    Me.xGridSerialView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colInD = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colMillSheet = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLengthSN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colMaterialLength = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHargaBeli = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHPP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLeghtBeli = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytSerial2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytSerial = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lblDataSerial = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.lytSerial3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.lytDempyouGrup = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytDempyou = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layoutProduksi = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colNoBuktiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colQtyOutRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colTotalRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.xGridProduksi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridProduksiView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDempyou, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDempyouView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkGabung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridSerial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridSerialView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytSerial2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytSerial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lblDataSerial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytSerial3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytDempyouGrup, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytDempyou, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layoutProduksi, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 28)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colNoBuktiRepo, Me.colTotalRepo, Me.colQtyOutRepo})
    Me.xGrid.Size = New System.Drawing.Size(946, 169)
    Me.xGrid.TabIndex = 0
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView, Me.GridView1})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoBukti, Me.colTanggal, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.colQtyIn, Me.colQtyOut, Me.colHarga, Me.colTotal, Me.colWeightIN, Me.colWeightOut, Me.colWeight, Me.colID, Me.GridColumn9, Me.GridColumn10, Me.colNoX, Me.colHargaProduksi, Me.colIdMain, Me.GridColumn13, Me.GridColumn15, Me.colHPPSN, Me.GridColumn16})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Nothing, "Total Amount :  ({0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyStock", Nothing, "SisaStock :  ({0})")})
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTanggal, DevExpress.Data.ColumnSortOrder.Descending)})
    '
    'colNoBukti
    '
    Me.colNoBukti.Caption = "No Bukti"
    Me.colNoBukti.ColumnEdit = Me.colNoBuktiRepo
    Me.colNoBukti.FieldName = "NoBukti"
    Me.colNoBukti.Name = "colNoBukti"
    Me.colNoBukti.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.colNoBukti.Visible = True
    Me.colNoBukti.VisibleIndex = 1
    Me.colNoBukti.Width = 120
    '
    'colNoBuktiRepo
    '
    Me.colNoBuktiRepo.AutoHeight = False
    Me.colNoBuktiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.colNoBuktiRepo.Name = "colNoBuktiRepo"
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.DisplayFormat.FormatString = "dd MMMM yy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 2
    Me.colTanggal.Width = 72
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode Barang"
    Me.GridColumn3.FieldName = "KodeBarang"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 3
    Me.GridColumn3.Width = 72
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Nama Barang"
    Me.GridColumn4.FieldName = "NamaBarang"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 4
    Me.GridColumn4.Width = 72
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Satuan"
    Me.GridColumn5.FieldName = "Satuan"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 5
    Me.GridColumn5.Width = 72
    '
    'colQtyIn
    '
    Me.colQtyIn.Caption = "Qty In"
    Me.colQtyIn.DisplayFormat.FormatString = "n0"
    Me.colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQtyIn.FieldName = "QtyIn"
    Me.colQtyIn.Name = "colQtyIn"
    Me.colQtyIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQtyIn.Visible = True
    Me.colQtyIn.VisibleIndex = 6
    Me.colQtyIn.Width = 72
    '
    'colQtyOut
    '
    Me.colQtyOut.Caption = "Qty Out"
    Me.colQtyOut.ColumnEdit = Me.colQtyOutRepo
    Me.colQtyOut.DisplayFormat.FormatString = "n0"
    Me.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQtyOut.FieldName = "QtyOut"
    Me.colQtyOut.Name = "colQtyOut"
    Me.colQtyOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQtyOut.Visible = True
    Me.colQtyOut.VisibleIndex = 7
    Me.colQtyOut.Width = 72
    '
    'colQtyOutRepo
    '
    Me.colQtyOutRepo.AutoHeight = False
    Me.colQtyOutRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.colQtyOutRepo.Name = "colQtyOutRepo"
    '
    'colHarga
    '
    Me.colHarga.Caption = "Harga"
    Me.colHarga.DisplayFormat.FormatString = "n2"
    Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    Me.colHarga.Visible = True
    Me.colHarga.VisibleIndex = 8
    Me.colHarga.Width = 72
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total"
    Me.colTotal.ColumnEdit = Me.colTotalRepo
    Me.colTotal.DisplayFormat.FormatString = "n2"
    Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTotal.FieldName = "Total"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n0}")})
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 9
    Me.colTotal.Width = 72
    '
    'colTotalRepo
    '
    Me.colTotalRepo.AutoHeight = False
    Me.colTotalRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.colTotalRepo.Name = "colTotalRepo"
    '
    'colWeightIN
    '
    Me.colWeightIN.Caption = "Weight IN"
    Me.colWeightIN.FieldName = "SerialWeightIN"
    Me.colWeightIN.Name = "colWeightIN"
    Me.colWeightIN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colWeightIN.Visible = True
    Me.colWeightIN.VisibleIndex = 10
    Me.colWeightIN.Width = 72
    '
    'colWeightOut
    '
    Me.colWeightOut.Caption = "Weight Out"
    Me.colWeightOut.FieldName = "SerialWeightOut"
    Me.colWeightOut.Name = "colWeightOut"
    Me.colWeightOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colWeightOut.Visible = True
    Me.colWeightOut.VisibleIndex = 11
    Me.colWeightOut.Width = 72
    '
    'colWeight
    '
    Me.colWeight.Caption = "Weight"
    Me.colWeight.DisplayFormat.FormatString = "n2"
    Me.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colWeight.FieldName = "SerialWeight"
    Me.colWeight.Name = "colWeight"
    Me.colWeight.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colWeight.Visible = True
    Me.colWeight.VisibleIndex = 12
    Me.colWeight.Width = 88
    '
    'colID
    '
    Me.colID.Caption = "Id"
    Me.colID.FieldName = "Id"
    Me.colID.Name = "colID"
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "LOT NO"
    Me.GridColumn9.FieldName = "NoLOT"
    Me.GridColumn9.Name = "GridColumn9"
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "No Produksi"
    Me.GridColumn10.FieldName = "NoProduksi"
    Me.GridColumn10.Name = "GridColumn10"
    '
    'colNoX
    '
    Me.colNoX.Caption = "NoX"
    Me.colNoX.FieldName = "NoX"
    Me.colNoX.Name = "colNoX"
    Me.colNoX.Visible = True
    Me.colNoX.VisibleIndex = 0
    '
    'colHargaProduksi
    '
    Me.colHargaProduksi.Caption = "HPP Produksi"
    Me.colHargaProduksi.FieldName = "HargaProduksi"
    Me.colHargaProduksi.Name = "colHargaProduksi"
    '
    'colIdMain
    '
    Me.colIdMain.Caption = "Id Main"
    Me.colIdMain.FieldName = "IdMain"
    Me.colIdMain.Name = "colIdMain"
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "Weight Detail"
    Me.GridColumn13.FieldName = "Weight"
    Me.GridColumn13.Name = "GridColumn13"
    '
    'GridColumn15
    '
    Me.GridColumn15.Caption = "WeightX"
    Me.GridColumn15.FieldName = "WeightX"
    Me.GridColumn15.Name = "GridColumn15"
    '
    'colHPPSN
    '
    Me.colHPPSN.Caption = "Hpp Per SN"
    Me.colHPPSN.FieldName = "NilaiHPPSN"
    Me.colHPPSN.Name = "colHPPSN"
    '
    'GridColumn16
    '
    Me.GridColumn16.Caption = "Qty SN"
    Me.GridColumn16.FieldName = "QtySN"
    Me.GridColumn16.Name = "GridColumn16"
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
    Me.GridView1.GridControl = Me.xGrid
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Serial"
    Me.GridColumn6.FieldName = "Serial"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 0
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Length IN"
    Me.GridColumn7.FieldName = "LengthIn"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 1
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Length OUT"
    Me.GridColumn8.FieldName = "LengthOut"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 2
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExport, Me.btnExportGridSerial, Me.BarButtonItem1, Me.BarSubItem1, Me.btnShowGridSerial, Me.btnShowDempyou, Me.btnProduksi})
    Me.BarManager1.MaxItemId = 7
    Me.BarManager1.StatusBar = Me.Bar3
    '
    'Bar3
    '
    Me.Bar3.BarName = "Status bar"
    Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.Bar3.DockCol = 0
    Me.Bar3.DockRow = 0
    Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExportGridSerial, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True)})
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
    'btnExportGridSerial
    '
    Me.btnExportGridSerial.Caption = "Export Grid Serial"
    Me.btnExportGridSerial.Glyph = CType(resources.GetObject("btnExportGridSerial.Glyph"), System.Drawing.Image)
    Me.btnExportGridSerial.Id = 1
    Me.btnExportGridSerial.LargeGlyph = CType(resources.GetObject("btnExportGridSerial.LargeGlyph"), System.Drawing.Image)
    Me.btnExportGridSerial.Name = "btnExportGridSerial"
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Show Layout"
    Me.BarSubItem1.Id = 3
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnShowGridSerial), New DevExpress.XtraBars.LinkPersistInfo(Me.btnShowDempyou), New DevExpress.XtraBars.LinkPersistInfo(Me.btnProduksi)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'btnShowGridSerial
    '
    Me.btnShowGridSerial.Caption = "Grid Serial"
    Me.btnShowGridSerial.Id = 4
    Me.btnShowGridSerial.Name = "btnShowGridSerial"
    '
    'btnShowDempyou
    '
    Me.btnShowDempyou.Caption = "Grid Serial Dempyou"
    Me.btnShowDempyou.Id = 5
    Me.btnShowDempyou.Name = "btnShowDempyou"
    '
    'btnProduksi
    '
    Me.btnProduksi.Caption = "Grid Stock Per No. Produksi"
    Me.btnProduksi.Id = 6
    Me.btnProduksi.Name = "btnProduksi"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Size = New System.Drawing.Size(970, 0)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 563)
    Me.barDockControlBottom.Size = New System.Drawing.Size(970, 27)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 563)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(970, 0)
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 563)
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "BarButtonItem1"
    Me.BarButtonItem1.Id = 2
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.xGridProduksi)
    Me.LayoutControl1.Controls.Add(Me.btnSimpan)
    Me.LayoutControl1.Controls.Add(Me.btnTransfer)
    Me.LayoutControl1.Controls.Add(Me.xGridDempyou)
    Me.LayoutControl1.Controls.Add(Me.chkGabung)
    Me.LayoutControl1.Controls.Add(Me.xGridSerial)
    Me.LayoutControl1.Controls.Add(Me.xGrid)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(396, 190, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(970, 563)
    Me.LayoutControl1.TabIndex = 6
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'xGridProduksi
    '
    Me.xGridProduksi.Location = New System.Drawing.Point(12, 404)
    Me.xGridProduksi.MainView = Me.xGridProduksiView
    Me.xGridProduksi.MenuManager = Me.BarManager1
    Me.xGridProduksi.Name = "xGridProduksi"
    Me.xGridProduksi.Size = New System.Drawing.Size(946, 147)
    Me.xGridProduksi.TabIndex = 9
    Me.xGridProduksi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridProduksiView})
    '
    'xGridProduksiView
    '
    Me.xGridProduksiView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
    Me.xGridProduksiView.GridControl = Me.xGridProduksi
    Me.xGridProduksiView.Name = "xGridProduksiView"
    Me.xGridProduksiView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn17
    '
    Me.GridColumn17.Caption = "No Produksi"
    Me.GridColumn17.FieldName = "NoX"
    Me.GridColumn17.Name = "GridColumn17"
    Me.GridColumn17.Visible = True
    Me.GridColumn17.VisibleIndex = 0
    '
    'GridColumn18
    '
    Me.GridColumn18.Caption = "Qty"
    Me.GridColumn18.DisplayFormat.FormatString = "n"
    Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn18.FieldName = "Qty"
    Me.GridColumn18.Name = "GridColumn18"
    Me.GridColumn18.Visible = True
    Me.GridColumn18.VisibleIndex = 1
    '
    'GridColumn19
    '
    Me.GridColumn19.Caption = "Amount"
    Me.GridColumn19.DisplayFormat.FormatString = "n4"
    Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn19.FieldName = "Amount"
    Me.GridColumn19.Name = "GridColumn19"
    Me.GridColumn19.Visible = True
    Me.GridColumn19.VisibleIndex = 2
    '
    'btnSimpan
    '
    Me.btnSimpan.Location = New System.Drawing.Point(822, 350)
    Me.btnSimpan.Name = "btnSimpan"
    Me.btnSimpan.Size = New System.Drawing.Size(124, 22)
    Me.btnSimpan.StyleController = Me.LayoutControl1
    Me.btnSimpan.TabIndex = 8
    Me.btnSimpan.Text = "Simpan"
    '
    'btnTransfer
    '
    Me.btnTransfer.Location = New System.Drawing.Point(723, 350)
    Me.btnTransfer.Name = "btnTransfer"
    Me.btnTransfer.Size = New System.Drawing.Size(95, 22)
    Me.btnTransfer.StyleController = Me.LayoutControl1
    Me.btnTransfer.TabIndex = 7
    Me.btnTransfer.Text = "Transfer from AM"
    '
    'xGridDempyou
    '
    Me.xGridDempyou.Location = New System.Drawing.Point(723, 255)
    Me.xGridDempyou.MainView = Me.xGridDempyouView
    Me.xGridDempyou.MenuManager = Me.BarManager1
    Me.xGridDempyou.Name = "xGridDempyou"
    Me.xGridDempyou.Size = New System.Drawing.Size(223, 91)
    Me.xGridDempyou.TabIndex = 6
    Me.xGridDempyou.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridDempyouView})
    '
    'xGridDempyouView
    '
    Me.xGridDempyouView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn11, Me.GridColumn12})
    Me.xGridDempyouView.GridControl = Me.xGridDempyou
    Me.xGridDempyouView.Name = "xGridDempyouView"
    Me.xGridDempyouView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridDempyouView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Serial"
    Me.GridColumn2.FieldName = "Serial"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 0
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "MillSheet"
    Me.GridColumn11.FieldName = "Millsheet"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 1
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "Length"
    Me.GridColumn12.FieldName = "Length"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 2
    '
    'chkGabung
    '
    Me.chkGabung.Location = New System.Drawing.Point(831, 201)
    Me.chkGabung.MenuManager = Me.BarManager1
    Me.chkGabung.Name = "chkGabung"
    Me.chkGabung.Properties.Caption = "Gabung Data"
    Me.chkGabung.Size = New System.Drawing.Size(127, 19)
    Me.chkGabung.StyleController = Me.LayoutControl1
    Me.chkGabung.TabIndex = 5
    '
    'xGridSerial
    '
    Me.xGridSerial.Location = New System.Drawing.Point(12, 224)
    Me.xGridSerial.MainView = Me.xGridSerialView
    Me.xGridSerial.MenuManager = Me.BarManager1
    Me.xGridSerial.Name = "xGridSerial"
    Me.xGridSerial.Size = New System.Drawing.Size(685, 160)
    Me.xGridSerial.TabIndex = 4
    Me.xGridSerial.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridSerialView})
    '
    'xGridSerialView
    '
    Me.xGridSerialView.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.xGridSerialView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xGridSerialView.ColumnPanelRowHeight = 30
    Me.xGridSerialView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colOD, Me.colInD, Me.colThickness, Me.colLength, Me.colMillSheet, Me.colSN, Me.colLengthSN, Me.colMaterialLength, Me.colQty, Me.GridColumn1, Me.colCatatan, Me.colHargaBeli, Me.GridColumn14, Me.colHPP, Me.colLeghtBeli})
    Me.xGridSerialView.GridControl = Me.xGridSerial
    Me.xGridSerialView.Name = "xGridSerialView"
    Me.xGridSerialView.NewItemRowText = "Tambah Data"
    Me.xGridSerialView.OptionsBehavior.Editable = False
    Me.xGridSerialView.OptionsBehavior.ReadOnly = True
    Me.xGridSerialView.OptionsCustomization.AllowGroup = False
    Me.xGridSerialView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridSerialView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridSerialView.OptionsView.AllowHtmlDrawHeaders = True
    Me.xGridSerialView.OptionsView.ShowFooter = True
    Me.xGridSerialView.OptionsView.ShowGroupPanel = False
    '
    'colKodeBarang
    '
    Me.colKodeBarang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colKodeBarang.AppearanceCell.Options.UseBackColor = True
    Me.colKodeBarang.AppearanceHeader.Options.UseTextOptions = True
    Me.colKodeBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colKodeBarang.Caption = "Part No."
    Me.colKodeBarang.FieldName = "Barang.Kode"
    Me.colKodeBarang.Name = "colKodeBarang"
    Me.colKodeBarang.OptionsColumn.AllowEdit = False
    Me.colKodeBarang.OptionsColumn.ReadOnly = True
    Me.colKodeBarang.Visible = True
    Me.colKodeBarang.VisibleIndex = 0
    Me.colKodeBarang.Width = 120
    '
    'colNamaBarang
    '
    Me.colNamaBarang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colNamaBarang.AppearanceCell.Options.UseBackColor = True
    Me.colNamaBarang.AppearanceCell.Options.UseTextOptions = True
    Me.colNamaBarang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colNamaBarang.AppearanceHeader.Options.UseTextOptions = True
    Me.colNamaBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colNamaBarang.Caption = "Material"
    Me.colNamaBarang.FieldName = "Barang.Nama"
    Me.colNamaBarang.Name = "colNamaBarang"
    Me.colNamaBarang.OptionsColumn.AllowEdit = False
    Me.colNamaBarang.OptionsColumn.ReadOnly = True
    Me.colNamaBarang.Visible = True
    Me.colNamaBarang.VisibleIndex = 1
    Me.colNamaBarang.Width = 120
    '
    'colOD
    '
    Me.colOD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colOD.AppearanceCell.Options.UseBackColor = True
    Me.colOD.AppearanceCell.Options.UseTextOptions = True
    Me.colOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colOD.AppearanceHeader.Options.UseTextOptions = True
    Me.colOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colOD.Caption = "OD"
    Me.colOD.DisplayFormat.FormatString = "n1"
    Me.colOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colOD.FieldName = "Barang.OutDiameter"
    Me.colOD.Name = "colOD"
    Me.colOD.OptionsColumn.AllowEdit = False
    Me.colOD.OptionsColumn.ReadOnly = True
    Me.colOD.Visible = True
    Me.colOD.VisibleIndex = 2
    Me.colOD.Width = 56
    '
    'colInD
    '
    Me.colInD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colInD.AppearanceCell.Options.UseBackColor = True
    Me.colInD.AppearanceCell.Options.UseTextOptions = True
    Me.colInD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colInD.AppearanceHeader.Options.UseTextOptions = True
    Me.colInD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colInD.Caption = "ID"
    Me.colInD.DisplayFormat.FormatString = "n1"
    Me.colInD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colInD.FieldName = "Barang.InDiameter"
    Me.colInD.Name = "colInD"
    Me.colInD.OptionsColumn.AllowEdit = False
    Me.colInD.OptionsColumn.ReadOnly = True
    Me.colInD.Visible = True
    Me.colInD.VisibleIndex = 3
    Me.colInD.Width = 56
    '
    'colThickness
    '
    Me.colThickness.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colThickness.AppearanceCell.Options.UseBackColor = True
    Me.colThickness.AppearanceCell.Options.UseTextOptions = True
    Me.colThickness.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colThickness.AppearanceHeader.Options.UseTextOptions = True
    Me.colThickness.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colThickness.Caption = "T"
    Me.colThickness.DisplayFormat.FormatString = "n1"
    Me.colThickness.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colThickness.FieldName = "Barang.Thickness"
    Me.colThickness.Name = "colThickness"
    Me.colThickness.OptionsColumn.AllowEdit = False
    Me.colThickness.OptionsColumn.ReadOnly = True
    Me.colThickness.Visible = True
    Me.colThickness.VisibleIndex = 4
    Me.colThickness.Width = 56
    '
    'colLength
    '
    Me.colLength.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colLength.AppearanceCell.Options.UseBackColor = True
    Me.colLength.AppearanceCell.Options.UseTextOptions = True
    Me.colLength.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colLength.AppearanceHeader.Options.UseTextOptions = True
    Me.colLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colLength.Caption = "L"
    Me.colLength.DisplayFormat.FormatString = "n1"
    Me.colLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colLength.FieldName = "Barang.Length"
    Me.colLength.Name = "colLength"
    Me.colLength.OptionsColumn.AllowEdit = False
    Me.colLength.OptionsColumn.ReadOnly = True
    Me.colLength.Visible = True
    Me.colLength.VisibleIndex = 5
    Me.colLength.Width = 56
    '
    'colMillSheet
    '
    Me.colMillSheet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colMillSheet.AppearanceCell.Options.UseBackColor = True
    Me.colMillSheet.AppearanceHeader.Options.UseTextOptions = True
    Me.colMillSheet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colMillSheet.Caption = "Millsheet"
    Me.colMillSheet.FieldName = "Millsheet"
    Me.colMillSheet.Name = "colMillSheet"
    Me.colMillSheet.OptionsColumn.AllowEdit = False
    Me.colMillSheet.OptionsColumn.ReadOnly = True
    Me.colMillSheet.Visible = True
    Me.colMillSheet.VisibleIndex = 6
    Me.colMillSheet.Width = 113
    '
    'colSN
    '
    Me.colSN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colSN.AppearanceCell.Options.UseBackColor = True
    Me.colSN.AppearanceHeader.Options.UseTextOptions = True
    Me.colSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colSN.Caption = "SN"
    Me.colSN.FieldName = "Serial"
    Me.colSN.Name = "colSN"
    Me.colSN.OptionsColumn.AllowEdit = False
    Me.colSN.OptionsColumn.ReadOnly = True
    Me.colSN.Visible = True
    Me.colSN.VisibleIndex = 7
    Me.colSN.Width = 100
    '
    'colLengthSN
    '
    Me.colLengthSN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colLengthSN.AppearanceCell.Options.UseBackColor = True
    Me.colLengthSN.AppearanceCell.Options.UseTextOptions = True
    Me.colLengthSN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colLengthSN.AppearanceHeader.Options.UseTextOptions = True
    Me.colLengthSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colLengthSN.Caption = "Length SN"
    Me.colLengthSN.DisplayFormat.FormatString = "n0"
    Me.colLengthSN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colLengthSN.FieldName = "SNLength"
    Me.colLengthSN.Name = "colLengthSN"
    Me.colLengthSN.OptionsColumn.AllowEdit = False
    Me.colLengthSN.OptionsColumn.ReadOnly = True
    Me.colLengthSN.Visible = True
    Me.colLengthSN.VisibleIndex = 8
    Me.colLengthSN.Width = 87
    '
    'colMaterialLength
    '
    Me.colMaterialLength.Caption = "Material Length"
    Me.colMaterialLength.DisplayFormat.FormatString = "n0"
    Me.colMaterialLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colMaterialLength.FieldName = "Length"
    Me.colMaterialLength.Name = "colMaterialLength"
    Me.colMaterialLength.Visible = True
    Me.colMaterialLength.VisibleIndex = 9
    Me.colMaterialLength.Width = 94
    '
    'colQty
    '
    Me.colQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colQty.AppearanceCell.Options.UseBackColor = True
    Me.colQty.AppearanceCell.Options.UseTextOptions = True
    Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colQty.AppearanceHeader.Options.UseTextOptions = True
    Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colQty.Caption = "Qty"
    Me.colQty.DisplayFormat.FormatString = "n0"
    Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.OptionsColumn.AllowEdit = False
    Me.colQty.OptionsColumn.AllowSize = False
    Me.colQty.OptionsColumn.FixedWidth = True
    Me.colQty.OptionsColumn.ReadOnly = True
    Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 10
    Me.colQty.Width = 50
    '
    'GridColumn1
    '
    Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn1.Caption = "Total Weight"
    Me.GridColumn1.DisplayFormat.FormatString = "n1"
    Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn1.FieldName = "Weight"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowEdit = False
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Width = 55
    '
    'colCatatan
    '
    Me.colCatatan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.colCatatan.AppearanceCell.Options.UseBackColor = True
    Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
    Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
    Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colCatatan.Caption = "Remarks"
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.OptionsColumn.AllowEdit = False
    Me.colCatatan.OptionsColumn.ReadOnly = True
    Me.colCatatan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 11
    Me.colCatatan.Width = 158
    '
    'colHargaBeli
    '
    Me.colHargaBeli.Caption = "Harga"
    Me.colHargaBeli.FieldName = "HargaSN"
    Me.colHargaBeli.Name = "colHargaBeli"
    Me.colHargaBeli.Visible = True
    Me.colHargaBeli.VisibleIndex = 12
    '
    'GridColumn14
    '
    Me.GridColumn14.Caption = "No Pembelian"
    Me.GridColumn14.FieldName = "NoPembelian"
    Me.GridColumn14.Name = "GridColumn14"
    '
    'colHPP
    '
    Me.colHPP.Caption = "HPP"
    Me.colHPP.FieldName = "NilaiHPP"
    Me.colHPP.Name = "colHPP"
    Me.colHPP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colHPP.Visible = True
    Me.colHPP.VisibleIndex = 13
    '
    'colLeghtBeli
    '
    Me.colLeghtBeli.Caption = "Length"
    Me.colLeghtBeli.FieldName = "LengthBeli"
    Me.colLeghtBeli.Name = "colLeghtBeli"
    Me.colLeghtBeli.Visible = True
    Me.colLeghtBeli.VisibleIndex = 14
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.lytSerial2, Me.lytSerial, Me.lblDataSerial, Me.lytSerial3, Me.lytDempyouGrup, Me.layoutProduksi})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(970, 563)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.xGrid
    Me.LayoutControlItem1.CustomizationFormText = "Stock"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(950, 189)
    Me.LayoutControlItem1.Text = "Stock"
    Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(119, 13)
    '
    'lytSerial2
    '
    Me.lytSerial2.Control = Me.xGridSerial
    Me.lytSerial2.CustomizationFormText = "Data Serial : AM0001"
    Me.lytSerial2.Location = New System.Drawing.Point(0, 212)
    Me.lytSerial2.Name = "lytSerial2"
    Me.lytSerial2.Size = New System.Drawing.Size(689, 164)
    Me.lytSerial2.Text = "Data Serial : AM0001"
    Me.lytSerial2.TextLocation = DevExpress.Utils.Locations.Top
    Me.lytSerial2.TextSize = New System.Drawing.Size(0, 0)
    Me.lytSerial2.TextToControlDistance = 0
    Me.lytSerial2.TextVisible = False
    Me.lytSerial2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
    '
    'lytSerial
    '
    Me.lytSerial.Control = Me.chkGabung
    Me.lytSerial.CustomizationFormText = "lytSerial"
    Me.lytSerial.Location = New System.Drawing.Point(819, 189)
    Me.lytSerial.MaxSize = New System.Drawing.Size(131, 23)
    Me.lytSerial.MinSize = New System.Drawing.Size(131, 23)
    Me.lytSerial.Name = "lytSerial"
    Me.lytSerial.Size = New System.Drawing.Size(131, 23)
    Me.lytSerial.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.lytSerial.Text = "lytSerial"
    Me.lytSerial.TextLocation = DevExpress.Utils.Locations.Right
    Me.lytSerial.TextSize = New System.Drawing.Size(0, 0)
    Me.lytSerial.TextToControlDistance = 0
    Me.lytSerial.TextVisible = False
    Me.lytSerial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
    '
    'lblDataSerial
    '
    Me.lblDataSerial.AllowHotTrack = False
    Me.lblDataSerial.CustomizationFormText = "Data Serial Produksi"
    Me.lblDataSerial.Location = New System.Drawing.Point(0, 189)
    Me.lblDataSerial.Name = "lblDataSerial"
    Me.lblDataSerial.Size = New System.Drawing.Size(819, 23)
    Me.lblDataSerial.Text = "Data Serial Produksi"
    Me.lblDataSerial.TextSize = New System.Drawing.Size(119, 13)
    Me.lblDataSerial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
    '
    'lytSerial3
    '
    Me.lytSerial3.AllowHotTrack = False
    Me.lytSerial3.CustomizationFormText = "lytSerial3"
    Me.lytSerial3.Location = New System.Drawing.Point(689, 212)
    Me.lytSerial3.MaxSize = New System.Drawing.Size(10, 0)
    Me.lytSerial3.MinSize = New System.Drawing.Size(10, 10)
    Me.lytSerial3.Name = "lytSerial3"
    Me.lytSerial3.Size = New System.Drawing.Size(10, 164)
    Me.lytSerial3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.lytSerial3.Text = "lytSerial3"
    Me.lytSerial3.TextSize = New System.Drawing.Size(0, 0)
    Me.lytSerial3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
    '
    'lytDempyouGrup
    '
    Me.lytDempyouGrup.CustomizationFormText = "Dempyou"
    Me.lytDempyouGrup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytDempyou, Me.LayoutControlItem2, Me.LayoutControlItem3})
    Me.lytDempyouGrup.Location = New System.Drawing.Point(699, 212)
    Me.lytDempyouGrup.Name = "lytDempyouGrup"
    Me.lytDempyouGrup.Size = New System.Drawing.Size(251, 164)
    Me.lytDempyouGrup.Text = "Dempyou"
    Me.lytDempyouGrup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
    '
    'lytDempyou
    '
    Me.lytDempyou.Control = Me.xGridDempyou
    Me.lytDempyou.CustomizationFormText = "Serial Dempyou"
    Me.lytDempyou.Location = New System.Drawing.Point(0, 0)
    Me.lytDempyou.Name = "lytDempyou"
    Me.lytDempyou.Size = New System.Drawing.Size(227, 95)
    Me.lytDempyou.Text = "Serial Dempyou"
    Me.lytDempyou.TextLocation = DevExpress.Utils.Locations.Top
    Me.lytDempyou.TextSize = New System.Drawing.Size(0, 0)
    Me.lytDempyou.TextToControlDistance = 0
    Me.lytDempyou.TextVisible = False
    Me.lytDempyou.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.btnTransfer
    Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 95)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(99, 26)
    Me.LayoutControlItem2.Text = "LayoutControlItem2"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem2.TextToControlDistance = 0
    Me.LayoutControlItem2.TextVisible = False
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.btnSimpan
    Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(99, 95)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(128, 26)
    Me.LayoutControlItem3.Text = "LayoutControlItem3"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem3.TextToControlDistance = 0
    Me.LayoutControlItem3.TextVisible = False
    '
    'layoutProduksi
    '
    Me.layoutProduksi.Control = Me.xGridProduksi
    Me.layoutProduksi.CustomizationFormText = "Data Per Nomor Produksi"
    Me.layoutProduksi.Location = New System.Drawing.Point(0, 376)
    Me.layoutProduksi.Name = "layoutProduksi"
    Me.layoutProduksi.Size = New System.Drawing.Size(950, 167)
    Me.layoutProduksi.Text = "Data Per Nomor Produksi"
    Me.layoutProduksi.TextLocation = DevExpress.Utils.Locations.Top
    Me.layoutProduksi.TextSize = New System.Drawing.Size(119, 13)
    Me.layoutProduksi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    '
    'UI_FusohCekStockHistory
    '
    Me.AllowMdiBar = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(970, 590)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.IsMdiContainer = True
    Me.MinimizeBox = False
    Me.Name = "UI_FusohCekStockHistory"
    Me.ShowIcon = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "History Stock"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colNoBuktiRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colQtyOutRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colTotalRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.xGridProduksi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridProduksiView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDempyou, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDempyouView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkGabung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridSerial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridSerialView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytSerial2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytSerial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lblDataSerial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytSerial3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytDempyouGrup, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytDempyou, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layoutProduksi, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOut As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightIN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoBuktiRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoX As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaProduksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotalRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents xGridSerial As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridSerialView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytSerial2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colQtyOutRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colOD As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colInD As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colThickness As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthSN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colMaterialLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIdMain As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnExportGridSerial As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents chkGabung As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents lytSerial As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lblDataSerial As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents xGridDempyou As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridDempyouView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents lytDempyou As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytSerial3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnShowGridSerial As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnShowDempyou As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnTransfer As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytDempyouGrup As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents colHargaBeli As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHPP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLeghtBeli As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHPPSN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnProduksi As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents xGridProduksi As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridProduksiView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents layoutProduksi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
End Class
