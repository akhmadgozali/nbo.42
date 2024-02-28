<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohCostSheetResetSingle
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohCostSheetResetSingle))
		Me.xGridViewOut = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKodePart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaPart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthOut = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHPP = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
		Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
		Me.colNoPenerimaan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colPartNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colMaterial = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colQty1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colHarga1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colSubtotal1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
		Me.colHarga2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colSubtotal2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colDetailSNRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.xGridViewIn = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colInKodePart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colInNamaPart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnStartReset = New DevExpress.XtraBars.BarButtonItem()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.txtNoCostSheet = New DevExpress.XtraEditors.TextEdit()
		Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
		Me.txtTotalInvoiceCostSheet = New DevExpress.XtraEditors.TextEdit()
		Me.txtTotalCostSheet = New DevExpress.XtraEditors.TextEdit()
		Me.txtTotalInvoice = New DevExpress.XtraEditors.TextEdit()
		Me.txtNomorPO = New DevExpress.XtraEditors.TextEdit()
		Me.txtSupplier = New DevExpress.XtraEditors.TextEdit()
		Me.txtNoInvoice = New DevExpress.XtraEditors.TextEdit()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridViewOut, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colDetailSNRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridViewIn, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoCostSheet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytTransaksi.SuspendLayout()
		CType(Me.txtTotalInvoiceCostSheet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTotalCostSheet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTotalInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNomorPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.xGrid.Location = New System.Drawing.Point(12, 142)
		Me.xGrid.MainView = Me.BandedGridView1
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colDetailSNRepo})
		Me.xGrid.Size = New System.Drawing.Size(698, 241)
		Me.xGrid.TabIndex = 0
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1, Me.xGridViewIn, Me.xGridViewOut})
		'
		'BandedGridView1
		'
		Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2})
		Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colNoPenerimaan, Me.colPartNo, Me.colMaterial, Me.colQty1, Me.colHarga1, Me.colSubtotal1, Me.colHarga2, Me.colSubtotal2})
		Me.BandedGridView1.GridControl = Me.xGrid
		Me.BandedGridView1.Name = "BandedGridView1"
		Me.BandedGridView1.OptionsBehavior.Editable = False
		Me.BandedGridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
		Me.BandedGridView1.OptionsView.ShowFooter = True
		Me.BandedGridView1.OptionsView.ShowGroupPanel = False
		'
		'GridBand1
		'
		Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
		Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.GridBand1.Caption = "Penerimaan Barang"
		Me.GridBand1.Columns.Add(Me.colNoPenerimaan)
		Me.GridBand1.Columns.Add(Me.colPartNo)
		Me.GridBand1.Columns.Add(Me.colMaterial)
		Me.GridBand1.Columns.Add(Me.colQty1)
		Me.GridBand1.Columns.Add(Me.colHarga1)
		Me.GridBand1.Columns.Add(Me.colSubtotal1)
		Me.GridBand1.Name = "GridBand1"
		Me.GridBand1.VisibleIndex = 0
		Me.GridBand1.Width = 539
		'
		'colNoPenerimaan
		'
		Me.colNoPenerimaan.Caption = "No. Penerimaan"
		Me.colNoPenerimaan.FieldName = "NoPenerimaan"
		Me.colNoPenerimaan.Name = "colNoPenerimaan"
		Me.colNoPenerimaan.Visible = True
		Me.colNoPenerimaan.Width = 100
		'
		'colPartNo
		'
		Me.colPartNo.Caption = "Part No."
		Me.colPartNo.FieldName = "KodeBarang"
		Me.colPartNo.Name = "colPartNo"
		Me.colPartNo.Visible = True
		Me.colPartNo.Width = 120
		'
		'colMaterial
		'
		Me.colMaterial.Caption = "Material"
		Me.colMaterial.FieldName = "NamaBarang"
		Me.colMaterial.Name = "colMaterial"
		Me.colMaterial.Visible = True
		Me.colMaterial.Width = 120
		'
		'colQty1
		'
		Me.colQty1.AppearanceHeader.Options.UseTextOptions = True
		Me.colQty1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQty1.Caption = "Qty"
		Me.colQty1.DisplayFormat.FormatString = "n2"
		Me.colQty1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQty1.FieldName = "Qty"
		Me.colQty1.Name = "colQty1"
		Me.colQty1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n2}")})
		Me.colQty1.Visible = True
		Me.colQty1.Width = 55
		'
		'colHarga1
		'
		Me.colHarga1.AppearanceHeader.Options.UseTextOptions = True
		Me.colHarga1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHarga1.Caption = "Harga"
		Me.colHarga1.DisplayFormat.FormatString = "n2"
		Me.colHarga1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga1.FieldName = "Harga"
		Me.colHarga1.Name = "colHarga1"
		Me.colHarga1.Visible = True
		Me.colHarga1.Width = 65
		'
		'colSubtotal1
		'
		Me.colSubtotal1.AppearanceHeader.Options.UseTextOptions = True
		Me.colSubtotal1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colSubtotal1.Caption = "Subtotal"
		Me.colSubtotal1.DisplayFormat.FormatString = "n2"
		Me.colSubtotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSubtotal1.FieldName = "Subtotal"
		Me.colSubtotal1.Name = "colSubtotal1"
		Me.colSubtotal1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "{0:n2}")})
		Me.colSubtotal1.Visible = True
		Me.colSubtotal1.Width = 79
		'
		'gridBand2
		'
		Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
		Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.gridBand2.Caption = "Hasil Reset"
		Me.gridBand2.Columns.Add(Me.colHarga2)
		Me.gridBand2.Columns.Add(Me.colSubtotal2)
		Me.gridBand2.Name = "gridBand2"
		Me.gridBand2.VisibleIndex = 1
		Me.gridBand2.Width = 140
		'
		'colHarga2
		'
		Me.colHarga2.AppearanceHeader.Options.UseTextOptions = True
		Me.colHarga2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHarga2.Caption = "Harga"
		Me.colHarga2.DisplayFormat.FormatString = "n2"
		Me.colHarga2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga2.FieldName = "HargaReset"
		Me.colHarga2.Name = "colHarga2"
		Me.colHarga2.Visible = True
		Me.colHarga2.Width = 65
		'
		'colSubtotal2
		'
		Me.colSubtotal2.AppearanceHeader.Options.UseTextOptions = True
		Me.colSubtotal2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colSubtotal2.Caption = "Subtotal"
		Me.colSubtotal2.DisplayFormat.FormatString = "n2"
		Me.colSubtotal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSubtotal2.FieldName = "SubtotalReset"
		Me.colSubtotal2.Name = "colSubtotal2"
		Me.colSubtotal2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalReset", "{0:n2}")})
		Me.colSubtotal2.Visible = True
		'
		'colDetailSNRepo
		'
		Me.colDetailSNRepo.AutoHeight = False
		Me.colDetailSNRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.colDetailSNRepo.Name = "colDetailSNRepo"
		Me.colDetailSNRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
		Me.barDockControlTop.Size = New System.Drawing.Size(722, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 395)
		Me.barDockControlBottom.Size = New System.Drawing.Size(722, 27)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 395)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(722, 0)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 395)
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(722, 395)
		Me.LayoutControlGroup1.Text = "Root"
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.xGrid
		Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 130)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(702, 245)
		Me.LayoutControlItem1.Text = "LayoutControlItem1"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem1.TextToControlDistance = 0
		Me.LayoutControlItem1.TextVisible = False
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtNoCostSheet
		Me.LayoutControlItem2.CustomizationFormText = "No. Cost Sheet    "
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 72)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(351, 48)
		Me.LayoutControlItem2.Text = "No. Cost Sheet    "
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(85, 13)
		'
		'txtNoCostSheet
		'
		Me.txtNoCostSheet.Enabled = False
		Me.txtNoCostSheet.Location = New System.Drawing.Point(100, 84)
		Me.txtNoCostSheet.Name = "txtNoCostSheet"
		Me.txtNoCostSheet.Size = New System.Drawing.Size(259, 20)
		Me.txtNoCostSheet.StyleController = Me.lytTransaksi
		Me.txtNoCostSheet.TabIndex = 12
		'
		'lytTransaksi
		'
		Me.lytTransaksi.Controls.Add(Me.txtTotalInvoiceCostSheet)
		Me.lytTransaksi.Controls.Add(Me.txtTotalCostSheet)
		Me.lytTransaksi.Controls.Add(Me.txtTotalInvoice)
		Me.lytTransaksi.Controls.Add(Me.txtNomorPO)
		Me.lytTransaksi.Controls.Add(Me.txtSupplier)
		Me.lytTransaksi.Controls.Add(Me.txtNoInvoice)
		Me.lytTransaksi.Controls.Add(Me.txtNoCostSheet)
		Me.lytTransaksi.Controls.Add(Me.xGrid)
		Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksi.Name = "lytTransaksi"
		Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(208, 296, 250, 350)
		Me.lytTransaksi.Root = Me.LayoutControlGroup1
		Me.lytTransaksi.Size = New System.Drawing.Size(722, 395)
		Me.lytTransaksi.TabIndex = 5
		Me.lytTransaksi.Text = "LayoutControl1"
		'
		'txtTotalInvoiceCostSheet
		'
		Me.txtTotalInvoiceCostSheet.Enabled = False
		Me.txtTotalInvoiceCostSheet.Location = New System.Drawing.Point(503, 108)
		Me.txtTotalInvoiceCostSheet.Name = "txtTotalInvoiceCostSheet"
		Me.txtTotalInvoiceCostSheet.Properties.Appearance.Options.UseTextOptions = True
		Me.txtTotalInvoiceCostSheet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtTotalInvoiceCostSheet.Size = New System.Drawing.Size(207, 20)
		Me.txtTotalInvoiceCostSheet.StyleController = Me.lytTransaksi
		Me.txtTotalInvoiceCostSheet.TabIndex = 15
		'
		'txtTotalCostSheet
		'
		Me.txtTotalCostSheet.Enabled = False
		Me.txtTotalCostSheet.Location = New System.Drawing.Point(503, 84)
		Me.txtTotalCostSheet.Name = "txtTotalCostSheet"
		Me.txtTotalCostSheet.Properties.Appearance.Options.UseTextOptions = True
		Me.txtTotalCostSheet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtTotalCostSheet.Size = New System.Drawing.Size(207, 20)
		Me.txtTotalCostSheet.StyleController = Me.lytTransaksi
		Me.txtTotalCostSheet.TabIndex = 14
		'
		'txtTotalInvoice
		'
		Me.txtTotalInvoice.Enabled = False
		Me.txtTotalInvoice.Location = New System.Drawing.Point(503, 60)
		Me.txtTotalInvoice.Name = "txtTotalInvoice"
		Me.txtTotalInvoice.Properties.Appearance.Options.UseTextOptions = True
		Me.txtTotalInvoice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtTotalInvoice.Size = New System.Drawing.Size(207, 20)
		Me.txtTotalInvoice.StyleController = Me.lytTransaksi
		Me.txtTotalInvoice.TabIndex = 14
		'
		'txtNomorPO
		'
		Me.txtNomorPO.Enabled = False
		Me.txtNomorPO.Location = New System.Drawing.Point(100, 36)
		Me.txtNomorPO.Name = "txtNomorPO"
		Me.txtNomorPO.Size = New System.Drawing.Size(610, 20)
		Me.txtNomorPO.StyleController = Me.lytTransaksi
		Me.txtNomorPO.TabIndex = 13
		'
		'txtSupplier
		'
		Me.txtSupplier.Enabled = False
		Me.txtSupplier.Location = New System.Drawing.Point(100, 12)
		Me.txtSupplier.Name = "txtSupplier"
		Me.txtSupplier.Size = New System.Drawing.Size(610, 20)
		Me.txtSupplier.StyleController = Me.lytTransaksi
		Me.txtSupplier.TabIndex = 13
		'
		'txtNoInvoice
		'
		Me.txtNoInvoice.Enabled = False
		Me.txtNoInvoice.Location = New System.Drawing.Point(100, 60)
		Me.txtNoInvoice.Name = "txtNoInvoice"
		Me.txtNoInvoice.Size = New System.Drawing.Size(259, 20)
		Me.txtNoInvoice.StyleController = Me.lytTransaksi
		Me.txtNoInvoice.TabIndex = 13
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtSupplier
		Me.LayoutControlItem4.CustomizationFormText = "Supplier"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(702, 24)
		Me.LayoutControlItem4.Text = "Vendor"
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(85, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtNoInvoice
		Me.LayoutControlItem3.CustomizationFormText = "No. Invoice"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(351, 24)
		Me.LayoutControlItem3.Text = "No. Invoice"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 120)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(702, 10)
		Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtNomorPO
		Me.LayoutControlItem5.CustomizationFormText = "No. PO"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(702, 24)
		Me.LayoutControlItem5.Text = "No. PO"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(85, 13)
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtTotalInvoice
		Me.LayoutControlItem6.CustomizationFormText = "Total Invoice"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(351, 48)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(351, 24)
		Me.LayoutControlItem6.Text = "Total Invoice"
		Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(135, 13)
		Me.LayoutControlItem6.TextToControlDistance = 5
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.txtTotalCostSheet
		Me.LayoutControlItem7.CustomizationFormText = "Total Cost Sheet"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(351, 72)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(351, 24)
		Me.LayoutControlItem7.Text = "Total Cost Sheet"
		Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(135, 13)
		Me.LayoutControlItem7.TextToControlDistance = 5
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.txtTotalInvoiceCostSheet
		Me.LayoutControlItem8.CustomizationFormText = "Total Invoice + Cost Sheet   "
		Me.LayoutControlItem8.Location = New System.Drawing.Point(351, 96)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(351, 24)
		Me.LayoutControlItem8.Text = "Total Invoice + Cost Sheet   "
		Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(135, 20)
		Me.LayoutControlItem8.TextToControlDistance = 5
		'
		'UI_FusohCostSheetResetSingle
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(722, 422)
		Me.Controls.Add(Me.lytTransaksi)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "UI_FusohCostSheetResetSingle"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Reset HPP "
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridViewOut, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colDetailSNRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridViewIn, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoCostSheet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytTransaksi.ResumeLayout(False)
		CType(Me.txtTotalInvoiceCostSheet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTotalCostSheet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTotalInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNomorPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
	Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
	Friend WithEvents btnStartReset As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
	Friend WithEvents colDetailSNRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
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
	Friend WithEvents lytTransaksi As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtNoCostSheet As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtNomorPO As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtNoInvoice As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
	Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	Friend WithEvents colNoPenerimaan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colPartNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colMaterial As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colQty1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colHarga1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colSubtotal1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	Friend WithEvents colHarga2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colSubtotal2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents txtTotalCostSheet As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtTotalInvoice As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtTotalInvoiceCostSheet As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
