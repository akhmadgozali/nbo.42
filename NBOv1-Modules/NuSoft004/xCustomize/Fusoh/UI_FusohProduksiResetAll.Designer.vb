<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohProduksiResetAll
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohProduksiResetAll))
        Me.xGridViewOut = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKodePart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLengthIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLengthOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridViewIn = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInKodePart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInNamaPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNoTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomorPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomorLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalHPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalQtyIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPPPerQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetailSNRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnStartReset = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lytMaster = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.txtNoTransaksi1 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtNoTransaksi2 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtNomorPO = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.btnFilter = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
        Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridViewOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridViewIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colDetailSNRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lytMaster.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTransaksi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTransaksi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomorPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xGridViewOut
        '
        Me.xGridViewOut.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodePart, Me.colNamaPart, Me.colSerial, Me.colHarga, Me.colLengthIn, Me.colLengthOut, Me.colHPP})
        Me.xGridViewOut.GridControl = Me.xGrid
        Me.xGridViewOut.Name = "xGridViewOut"
        Me.xGridViewOut.OptionsBehavior.Editable = False
        Me.xGridViewOut.OptionsDetail.EnableMasterViewMode = False
        Me.xGridViewOut.OptionsView.ShowFooter = True
        Me.xGridViewOut.OptionsView.ShowGroupPanel = False
        '
        'colKodePart
        '
        Me.colKodePart.Caption = "Kode Part"
        Me.colKodePart.FieldName = "KodePart"
        Me.colKodePart.Name = "colKodePart"
        Me.colKodePart.Visible = True
        Me.colKodePart.VisibleIndex = 0
        '
        'colNamaPart
        '
        Me.colNamaPart.Caption = "Nama Part"
        Me.colNamaPart.FieldName = "NamaPart"
        Me.colNamaPart.Name = "colNamaPart"
        Me.colNamaPart.Visible = True
        Me.colNamaPart.VisibleIndex = 1
        '
        'colSerial
        '
        Me.colSerial.Caption = "Serial Number"
        Me.colSerial.FieldName = "SerialNumber"
        Me.colSerial.Name = "colSerial"
        Me.colSerial.Visible = True
        Me.colSerial.VisibleIndex = 2
        '
        'colHarga
        '
        Me.colHarga.AppearanceHeader.Options.UseTextOptions = True
        Me.colHarga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHarga.Caption = "Harga"
        Me.colHarga.DisplayFormat.FormatString = "n2"
        Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHarga.FieldName = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 3
        '
        'colLengthIn
        '
        Me.colLengthIn.AppearanceHeader.Options.UseTextOptions = True
        Me.colLengthIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colLengthIn.Caption = "Length In"
        Me.colLengthIn.DisplayFormat.FormatString = "n2"
        Me.colLengthIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLengthIn.FieldName = "LengthIn"
        Me.colLengthIn.Name = "colLengthIn"
        Me.colLengthIn.Visible = True
        Me.colLengthIn.VisibleIndex = 4
        '
        'colLengthOut
        '
        Me.colLengthOut.AppearanceHeader.Options.UseTextOptions = True
        Me.colLengthOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colLengthOut.Caption = "Length Out"
        Me.colLengthOut.DisplayFormat.FormatString = "n2"
        Me.colLengthOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLengthOut.FieldName = "LengthOut"
        Me.colLengthOut.Name = "colLengthOut"
        Me.colLengthOut.Visible = True
        Me.colLengthOut.VisibleIndex = 5
        '
        'colHPP
        '
        Me.colHPP.AppearanceHeader.Options.UseTextOptions = True
        Me.colHPP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHPP.Caption = "HPP"
        Me.colHPP.DisplayFormat.FormatString = "n2"
        Me.colHPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHPP.FieldName = "HPP"
        Me.colHPP.Name = "colHPP"
        Me.colHPP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HPP", "{0:n2}")})
        Me.colHPP.Visible = True
        Me.colHPP.VisibleIndex = 6
        '
        'xGrid
        '
        GridLevelNode1.LevelTemplate = Me.xGridViewOut
        GridLevelNode1.RelationName = "HPPOut"
        GridLevelNode2.LevelTemplate = Me.xGridViewIn
        GridLevelNode2.RelationName = "HPPIn"
        Me.xGrid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.xGrid.Location = New System.Drawing.Point(194, 12)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colDetailSNRepo})
        Me.xGrid.Size = New System.Drawing.Size(963, 355)
        Me.xGrid.TabIndex = 0
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridViewIn, Me.xGridView, Me.xGridViewOut})
        '
        'xGridViewIn
        '
        Me.xGridViewIn.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInKodePart, Me.colInNamaPart, Me.colQty})
        Me.xGridViewIn.GridControl = Me.xGrid
        Me.xGridViewIn.Name = "xGridViewIn"
        Me.xGridViewIn.OptionsBehavior.Editable = False
        Me.xGridViewIn.OptionsDetail.EnableMasterViewMode = False
        Me.xGridViewIn.OptionsView.ShowFooter = True
        Me.xGridViewIn.OptionsView.ShowGroupPanel = False
        '
        'colInKodePart
        '
        Me.colInKodePart.Caption = "Kode Part"
        Me.colInKodePart.FieldName = "KodePart"
        Me.colInKodePart.Name = "colInKodePart"
        Me.colInKodePart.Visible = True
        Me.colInKodePart.VisibleIndex = 0
        '
        'colInNamaPart
        '
        Me.colInNamaPart.Caption = "Nama Part"
        Me.colInNamaPart.FieldName = "NamaPart"
        Me.colInNamaPart.Name = "colInNamaPart"
        Me.colInNamaPart.Visible = True
        Me.colInNamaPart.VisibleIndex = 1
        '
        'colQty
        '
        Me.colQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQty.Caption = "Qty"
        Me.colQty.DisplayFormat.FormatString = "n2"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n2}")})
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 2
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoTransaksi, Me.colTanggal, Me.colCustomer, Me.colNomorPO, Me.colNomorLot, Me.colTotalQtyOut, Me.colTotalHPP, Me.colTotalQtyIn, Me.colHPPPerQty, Me.colStatus})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsView.ShowAutoFilterRow = True
        Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colNoTransaksi
        '
        Me.colNoTransaksi.Caption = "No. Transaksi"
        Me.colNoTransaksi.FieldName = "Kode"
        Me.colNoTransaksi.Name = "colNoTransaksi"
        Me.colNoTransaksi.Visible = True
        Me.colNoTransaksi.VisibleIndex = 0
        Me.colNoTransaksi.Width = 100
        '
        'colTanggal
        '
        Me.colTanggal.Caption = "Tanggal"
        Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTanggal.FieldName = "Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 1
        Me.colTanggal.Width = 76
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer"
        Me.colCustomer.FieldName = "NamaPelanggan"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 2
        Me.colCustomer.Width = 130
        '
        'colNomorPO
        '
        Me.colNomorPO.Caption = "Nomor PO"
        Me.colNomorPO.FieldName = "NomorPO"
        Me.colNomorPO.Name = "colNomorPO"
        Me.colNomorPO.Visible = True
        Me.colNomorPO.VisibleIndex = 3
        Me.colNomorPO.Width = 80
        '
        'colNomorLot
        '
        Me.colNomorLot.Caption = "Nomor Lot"
        Me.colNomorLot.FieldName = "NomorLot"
        Me.colNomorLot.Name = "colNomorLot"
        Me.colNomorLot.Visible = True
        Me.colNomorLot.VisibleIndex = 4
        Me.colNomorLot.Width = 80
        '
        'colTotalQtyOut
        '
        Me.colTotalQtyOut.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalQtyOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalQtyOut.Caption = "Total Qty Out"
        Me.colTotalQtyOut.DisplayFormat.FormatString = "n2"
        Me.colTotalQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalQtyOut.FieldName = "TotalQtyOut"
        Me.colTotalQtyOut.Name = "colTotalQtyOut"
        Me.colTotalQtyOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyOut", "{0:n2}")})
        Me.colTotalQtyOut.Visible = True
        Me.colTotalQtyOut.VisibleIndex = 5
        Me.colTotalQtyOut.Width = 85
        '
        'colTotalHPP
        '
        Me.colTotalHPP.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalHPP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalHPP.Caption = "Total HPP"
        Me.colTotalHPP.DisplayFormat.FormatString = "n2"
        Me.colTotalHPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalHPP.FieldName = "TotalHPP"
        Me.colTotalHPP.Name = "colTotalHPP"
        Me.colTotalHPP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalHPP", "{0:n2}")})
        Me.colTotalHPP.Visible = True
        Me.colTotalHPP.VisibleIndex = 6
        Me.colTotalHPP.Width = 85
        '
        'colTotalQtyIn
        '
        Me.colTotalQtyIn.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalQtyIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalQtyIn.Caption = "Total Qty In"
        Me.colTotalQtyIn.DisplayFormat.FormatString = "n2"
        Me.colTotalQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalQtyIn.FieldName = "TotalQtyIn"
        Me.colTotalQtyIn.Name = "colTotalQtyIn"
        Me.colTotalQtyIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyIn", "{0:n2}")})
        Me.colTotalQtyIn.Visible = True
        Me.colTotalQtyIn.VisibleIndex = 7
        Me.colTotalQtyIn.Width = 80
        '
        'colHPPPerQty
        '
        Me.colHPPPerQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colHPPPerQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHPPPerQty.Caption = "HPP Per Qty"
        Me.colHPPPerQty.DisplayFormat.FormatString = "n2"
        Me.colHPPPerQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHPPPerQty.FieldName = "HPPPerQty"
        Me.colHPPPerQty.Name = "colHPPPerQty"
        Me.colHPPPerQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HPPPerQty", "{0:n2}")})
        Me.colHPPPerQty.Visible = True
        Me.colHPPPerQty.VisibleIndex = 8
        Me.colHPPPerQty.Width = 85
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 9
        Me.colStatus.Width = 49
        '
        'colDetailSNRepo
        '
        Me.colDetailSNRepo.AutoHeight = False
        Me.colDetailSNRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.colDetailSNRepo.Name = "colDetailSNRepo"
        Me.colDetailSNRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnStartReset})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnStartReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnStartReset
        '
        Me.btnStartReset.Caption = "Start Reset"
        Me.btnStartReset.Glyph = CType(resources.GetObject("btnStartReset.Glyph"), System.Drawing.Image)
        Me.btnStartReset.Id = 0
        Me.btnStartReset.LargeGlyph = CType(resources.GetObject("btnStartReset.LargeGlyph"), System.Drawing.Image)
        Me.btnStartReset.Name = "btnStartReset"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1169, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 379)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1169, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 379)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1169, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 379)
        '
        'lytMaster
        '
        Me.lytMaster.Controls.Add(Me.btnFilter)
        Me.lytMaster.Controls.Add(Me.txtNomorPO)
        Me.lytMaster.Controls.Add(Me.txtCustomer)
        Me.lytMaster.Controls.Add(Me.txtNoTransaksi2)
        Me.lytMaster.Controls.Add(Me.txtNoTransaksi1)
        Me.lytMaster.Controls.Add(Me.xGrid)
        Me.lytMaster.Controls.Add(Me.txtTgl1)
        Me.lytMaster.Controls.Add(Me.txtTgl2)
        Me.lytMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytMaster.Location = New System.Drawing.Point(0, 0)
        Me.lytMaster.Name = "lytMaster"
        Me.lytMaster.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(431, 93, 250, 350)
        Me.lytMaster.Root = Me.LayoutControlGroup1
        Me.lytMaster.Size = New System.Drawing.Size(1169, 379)
        Me.lytMaster.TabIndex = 111
        Me.lytMaster.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1169, 379)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtTgl1
        Me.LayoutControlItem1.CustomizationFormText = "Kode"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(158, 40)
        Me.LayoutControlItem1.Text = "Dari Tanggal"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.txtTgl2
        Me.LayoutControlItem41.CustomizationFormText = "Nama Part"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(158, 40)
        Me.LayoutControlItem41.Text = "s/d"
        Me.LayoutControlItem41.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.xGrid
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(182, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(967, 359)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "Filter Data"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem41, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem8, Me.SimpleSeparator1, Me.SimpleSeparator2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(182, 359)
        Me.LayoutControlGroup2.Text = "Filter Data"
        '
        'txtNoTransaksi1
        '
        Me.txtNoTransaksi1.Location = New System.Drawing.Point(24, 141)
        Me.txtNoTransaksi1.Name = "txtNoTransaksi1"
        Me.txtNoTransaksi1.Size = New System.Drawing.Size(154, 20)
        Me.txtNoTransaksi1.StyleController = Me.lytMaster
        Me.txtNoTransaksi1.TabIndex = 112
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtNoTransaksi1
        Me.LayoutControlItem4.CustomizationFormText = "Dari No. Transaksi"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(158, 40)
        Me.LayoutControlItem4.Text = "Dari No. Transaksi"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(87, 13)
        '
        'txtNoTransaksi2
        '
        Me.txtNoTransaksi2.Location = New System.Drawing.Point(24, 181)
        Me.txtNoTransaksi2.Name = "txtNoTransaksi2"
        Me.txtNoTransaksi2.Size = New System.Drawing.Size(154, 20)
        Me.txtNoTransaksi2.StyleController = Me.lytMaster
        Me.txtNoTransaksi2.TabIndex = 112
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtNoTransaksi2
        Me.LayoutControlItem5.CustomizationFormText = "s/d"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(158, 40)
        Me.LayoutControlItem5.Text = "s/d"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(87, 13)
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(24, 223)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(154, 20)
        Me.txtCustomer.StyleController = Me.lytMaster
        Me.txtCustomer.TabIndex = 112
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCustomer
        Me.LayoutControlItem6.CustomizationFormText = "Customer"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 164)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(158, 40)
        Me.LayoutControlItem6.Text = "Customer"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(87, 13)
        '
        'txtNomorPO
        '
        Me.txtNomorPO.Location = New System.Drawing.Point(24, 263)
        Me.txtNomorPO.Name = "txtNomorPO"
        Me.txtNomorPO.Size = New System.Drawing.Size(154, 20)
        Me.txtNomorPO.StyleController = Me.lytMaster
        Me.txtNomorPO.TabIndex = 112
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtNomorPO
        Me.LayoutControlItem7.CustomizationFormText = "Nomor PO"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 204)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(158, 40)
        Me.LayoutControlItem7.Text = "Nomor PO"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(87, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 244)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(158, 46)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'btnFilter
        '
        Me.btnFilter.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Appearance.ForeColor = System.Drawing.Color.Green
        Me.btnFilter.Appearance.Options.UseFont = True
        Me.btnFilter.Appearance.Options.UseForeColor = True
        Me.btnFilter.Location = New System.Drawing.Point(24, 333)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(154, 22)
        Me.btnFilter.StyleController = Me.lytMaster
        Me.btnFilter.TabIndex = 112
        Me.btnFilter.Text = "Filter"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnFilter
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 290)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(158, 26)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 80)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(158, 2)
        Me.SimpleSeparator1.Text = "SimpleSeparator1"
        '
        'SimpleSeparator2
        '
        Me.SimpleSeparator2.AllowHotTrack = False
        Me.SimpleSeparator2.CustomizationFormText = "SimpleSeparator2"
        Me.SimpleSeparator2.Location = New System.Drawing.Point(0, 162)
        Me.SimpleSeparator2.Name = "SimpleSeparator2"
        Me.SimpleSeparator2.Size = New System.Drawing.Size(158, 2)
        Me.SimpleSeparator2.Text = "SimpleSeparator2"
        '
        'txtTgl1
        '
        Me.txtTgl1.EditValue = Nothing
        Me.txtTgl1.Location = New System.Drawing.Point(24, 59)
        Me.txtTgl1.Name = "txtTgl1"
        Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
        Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTgl1.Size = New System.Drawing.Size(154, 20)
        Me.txtTgl1.StyleController = Me.lytMaster
        Me.txtTgl1.TabIndex = 100
        '
        'txtTgl2
        '
        Me.txtTgl2.EditValue = Nothing
        Me.txtTgl2.Location = New System.Drawing.Point(24, 99)
        Me.txtTgl2.Name = "txtTgl2"
        Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
        Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTgl2.Size = New System.Drawing.Size(154, 20)
        Me.txtTgl2.StyleController = Me.lytMaster
        Me.txtTgl2.TabIndex = 111
        '
        'UI_FusohProduksiResetAll
        '
        Me.AllowMdiBar = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 406)
        Me.Controls.Add(Me.lytMaster)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UI_FusohProduksiResetAll"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset HPP Produksi"
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridViewOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridViewIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colDetailSNRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lytMaster.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTransaksi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTransaksi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomorPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colNoTransaksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalQtyOut As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalHPP As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
	Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
	Friend WithEvents btnStartReset As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNomorPO As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNomorLot As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDetailSNRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalQtyIn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHPPPerQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents xGridViewOut As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents xGridViewIn As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colInKodePart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colInNamaPart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodePart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaPart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLengthIn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLengthOut As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lytMaster As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtNomorPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoTransaksi2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoTransaksi1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnFilter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
End Class
