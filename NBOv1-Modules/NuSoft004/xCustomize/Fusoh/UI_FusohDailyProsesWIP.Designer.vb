<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohDailyProsesWIP
	Inherits Core.Win.Forms.GridInput

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohDailyProsesWIP))
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPelanggan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDempyouLot = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
		Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
		Me.btnUnposting = New DevExpress.XtraBars.BarButtonItem()
		Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
		Me.btnReset = New DevExpress.XtraBars.BarButtonItem()
		Me.colDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPartNumber = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPartNumberRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.colFGSize = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOP1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOP2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOP3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOP4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOP5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMesin = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colProcess = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyFinishGood = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyFG = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyCutting = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyNG = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colShift = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWaktuStopLine = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colJamKerja = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnCekStock = New DevExpress.XtraBars.BarButtonItem()
		Me.colPDO = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colPartNumberRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.DataSource = Me.ifSource
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colPartNumberRepo})
		Me.xGrid.Size = New System.Drawing.Size(912, 368)
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnUpdate, Me.btnPosting, Me.btnUnposting, Me.btnClosing, Me.btnReset, Me.btnCekStock})
		Me.barMan.MaxItemId = 30
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colCode, Me.colTanggal, Me.colPelanggan, Me.colDempyou, Me.colDempyouLot, Me.colPDO, Me.colPartNumber, Me.colFGSize, Me.colMesin, Me.colShift, Me.colJamKerja, Me.colProcess, Me.colQtyDempyou, Me.colQtyOP1, Me.colQtyOP2, Me.colQtyOP3, Me.colQtyOP4, Me.colQtyOP5, Me.colQtyFinishGood, Me.colQtyCutting, Me.colQtyFG, Me.colQtyNG, Me.colWaktuStopLine, Me.colKeterangan, Me.colProduksi})
		Me.xGridView.GroupCount = 2
		Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
		Me.xGridView.OptionsView.ColumnAutoWidth = False
		Me.xGridView.OptionsView.ShowAutoFilterRow = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPDO, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'ifSource
		'
		Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_DailyProcess)
		'
		'popMenu
		'
		Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnCekStock, True)})
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUpdate, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		Me.colId.OptionsColumn.ReadOnly = True
		Me.colId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		'
		'colTahun
		'
		Me.colTahun.Caption = "Tahun"
		Me.colTahun.FieldName = "Tahun"
		Me.colTahun.Name = "colTahun"
		Me.colTahun.OptionsColumn.ReadOnly = True
		Me.colTahun.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colTahun.Visible = True
		Me.colTahun.VisibleIndex = 7
		'
		'colBulan
		'
		Me.colBulan.Caption = "Bulan"
		Me.colBulan.DisplayFormat.FormatString = "MMMM"
		Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.FieldName = "Bulan"
		Me.colBulan.GroupFormat.FormatString = "MMMM"
		Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.Name = "colBulan"
		Me.colBulan.OptionsColumn.ReadOnly = True
		Me.colBulan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colBulan.Visible = True
		Me.colBulan.VisibleIndex = 9
		'
		'colCode
		'
		Me.colCode.Caption = "No. Cutting [WIP]"
		Me.colCode.FieldName = "CuttingWIP.Kode"
		Me.colCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
		Me.colCode.Name = "colCode"
		Me.colCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colCode.Visible = True
		Me.colCode.VisibleIndex = 0
		Me.colCode.Width = 130
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		Me.colTanggal.Width = 80
		'
		'colPelanggan
		'
		Me.colPelanggan.Caption = "Customer"
		Me.colPelanggan.FieldName = "CuttingWIP.Pelanggan.Nama"
		Me.colPelanggan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
		Me.colPelanggan.Name = "colPelanggan"
		Me.colPelanggan.OptionsColumn.ReadOnly = True
		Me.colPelanggan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colPelanggan.Visible = True
		Me.colPelanggan.VisibleIndex = 2
		Me.colPelanggan.Width = 150
		'
		'colDempyouLot
		'
		Me.colDempyouLot.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colDempyouLot.AppearanceCell.Options.UseBackColor = True
		Me.colDempyouLot.Caption = "No. Lot"
		Me.colDempyouLot.FieldName = "CuttingWIP.DempyouLot"
		Me.colDempyouLot.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
		Me.colDempyouLot.Name = "colDempyouLot"
		Me.colDempyouLot.OptionsColumn.ReadOnly = True
		Me.colDempyouLot.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colDempyouLot.Visible = True
		Me.colDempyouLot.VisibleIndex = 4
		Me.colDempyouLot.Width = 60
		'
		'colProduksi
		'
		Me.colProduksi.Caption = "Produksi"
		Me.colProduksi.FieldName = "Produksi.Kode"
		Me.colProduksi.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
		Me.colProduksi.Name = "colProduksi"
		Me.colProduksi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colProduksi.Visible = True
		Me.colProduksi.VisibleIndex = 24
		Me.colProduksi.Width = 90
		'
		'btnUpdate
		'
		Me.btnUpdate.Caption = "&Update Status"
		Me.btnUpdate.Glyph = CType(resources.GetObject("btnUpdate.Glyph"), System.Drawing.Image)
		Me.btnUpdate.Id = 13
		Me.btnUpdate.LargeGlyph = CType(resources.GetObject("btnUpdate.LargeGlyph"), System.Drawing.Image)
		Me.btnUpdate.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPosting), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUnposting), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClosing, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnReset, True)})
		Me.btnUpdate.Name = "btnUpdate"
		'
		'btnPosting
		'
		Me.btnPosting.Caption = "Posting Transaksi"
		Me.btnPosting.Glyph = CType(resources.GetObject("btnPosting.Glyph"), System.Drawing.Image)
		Me.btnPosting.Id = 14
		Me.btnPosting.LargeGlyph = CType(resources.GetObject("btnPosting.LargeGlyph"), System.Drawing.Image)
		Me.btnPosting.Name = "btnPosting"
		Me.btnPosting.Tag = "memposting"
		'
		'btnUnposting
		'
		Me.btnUnposting.Caption = "UnPosting Transaksi"
		Me.btnUnposting.Glyph = CType(resources.GetObject("btnUnposting.Glyph"), System.Drawing.Image)
		Me.btnUnposting.Id = 15
		Me.btnUnposting.LargeGlyph = CType(resources.GetObject("btnUnposting.LargeGlyph"), System.Drawing.Image)
		Me.btnUnposting.Name = "btnUnposting"
		Me.btnUnposting.Tag = "mengunposting"
		'
		'btnClosing
		'
		Me.btnClosing.Caption = "Closing Transaksi"
		Me.btnClosing.Enabled = False
		Me.btnClosing.Id = 16
		Me.btnClosing.Name = "btnClosing"
		Me.btnClosing.Tag = "mengclosing"
		'
		'btnReset
		'
		Me.btnReset.Caption = "Reset Status"
		Me.btnReset.Glyph = CType(resources.GetObject("btnReset.Glyph"), System.Drawing.Image)
		Me.btnReset.Id = 19
		Me.btnReset.LargeGlyph = CType(resources.GetObject("btnReset.LargeGlyph"), System.Drawing.Image)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
		'
		'colDempyou
		'
		Me.colDempyou.Caption = "Nomor Dempyou"
		Me.colDempyou.FieldName = "CuttingWIP.OrderProduksi.Kode"
		Me.colDempyou.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
		Me.colDempyou.Name = "colDempyou"
		Me.colDempyou.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colDempyou.Visible = True
		Me.colDempyou.VisibleIndex = 3
		Me.colDempyou.Width = 90
		'
		'colPartNumber
		'
		Me.colPartNumber.Caption = "Part Number (FG)"
		Me.colPartNumber.ColumnEdit = Me.colPartNumberRepo
		Me.colPartNumber.FieldName = "CuttingWIP.OrderProduksi.SODetail.Barang.Kode"
		Me.colPartNumber.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
		Me.colPartNumber.Name = "colPartNumber"
		Me.colPartNumber.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colPartNumber.Visible = True
		Me.colPartNumber.VisibleIndex = 5
		Me.colPartNumber.Width = 95
		'
		'colPartNumberRepo
		'
		Me.colPartNumberRepo.AutoHeight = False
		Me.colPartNumberRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.colPartNumberRepo.Name = "colPartNumberRepo"
		'
		'colFGSize
		'
		Me.colFGSize.Caption = "Finish Good Size"
		Me.colFGSize.FieldName = "CuttingWIP.OrderProduksi.SODetail.Barang.FGSize"
		Me.colFGSize.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
		Me.colFGSize.Name = "colFGSize"
		Me.colFGSize.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colFGSize.Visible = True
		Me.colFGSize.VisibleIndex = 6
		Me.colFGSize.Width = 150
		'
		'colQtyDempyou
		'
		Me.colQtyDempyou.Caption = "Qty Dempyou"
		Me.colQtyDempyou.FieldName = "CuttingWIP.OrderProduksi.Qty"
		Me.colQtyDempyou.Name = "colQtyDempyou"
		Me.colQtyDempyou.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyDempyou.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyDempyou.Visible = True
		Me.colQtyDempyou.VisibleIndex = 12
		Me.colQtyDempyou.Width = 50
		'
		'colQtyOP1
		'
		Me.colQtyOP1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colQtyOP1.AppearanceCell.Options.UseBackColor = True
		Me.colQtyOP1.Caption = "Qty OP 1"
		Me.colQtyOP1.FieldName = "QtyOP1"
		Me.colQtyOP1.Name = "colQtyOP1"
		Me.colQtyOP1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyOP1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyOP1.Visible = True
		Me.colQtyOP1.VisibleIndex = 13
		Me.colQtyOP1.Width = 50
		'
		'colQtyOP2
		'
		Me.colQtyOP2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colQtyOP2.AppearanceCell.Options.UseBackColor = True
		Me.colQtyOP2.FieldName = "QtyOP2"
		Me.colQtyOP2.Name = "colQtyOP2"
		Me.colQtyOP2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyOP2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyOP2.Visible = True
		Me.colQtyOP2.VisibleIndex = 14
		Me.colQtyOP2.Width = 50
		'
		'colQtyOP3
		'
		Me.colQtyOP3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colQtyOP3.AppearanceCell.Options.UseBackColor = True
		Me.colQtyOP3.FieldName = "QtyOP3"
		Me.colQtyOP3.Name = "colQtyOP3"
		Me.colQtyOP3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyOP3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyOP3.Visible = True
		Me.colQtyOP3.VisibleIndex = 15
		Me.colQtyOP3.Width = 50
		'
		'colQtyOP4
		'
		Me.colQtyOP4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colQtyOP4.AppearanceCell.Options.UseBackColor = True
		Me.colQtyOP4.FieldName = "QtyOP4"
		Me.colQtyOP4.Name = "colQtyOP4"
		Me.colQtyOP4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyOP4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyOP4.Visible = True
		Me.colQtyOP4.VisibleIndex = 16
		Me.colQtyOP4.Width = 50
		'
		'colQtyOP5
		'
		Me.colQtyOP5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colQtyOP5.AppearanceCell.Options.UseBackColor = True
		Me.colQtyOP5.FieldName = "QtyOP5"
		Me.colQtyOP5.Name = "colQtyOP5"
		Me.colQtyOP5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyOP5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyOP5.Visible = True
		Me.colQtyOP5.VisibleIndex = 17
		Me.colQtyOP5.Width = 50
		'
		'colMesin
		'
		Me.colMesin.Caption = "Mesin"
		Me.colMesin.FieldName = "Mesin.Nama"
		Me.colMesin.Name = "colMesin"
		Me.colMesin.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colMesin.Visible = True
		Me.colMesin.VisibleIndex = 8
		Me.colMesin.Width = 80
		'
		'colProcess
		'
		Me.colProcess.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colProcess.AppearanceCell.Options.UseBackColor = True
		Me.colProcess.Caption = "Process"
		Me.colProcess.FieldName = "ProcessCutting.Nama"
		Me.colProcess.Name = "colProcess"
		Me.colProcess.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colProcess.Visible = True
		Me.colProcess.VisibleIndex = 11
		Me.colProcess.Width = 100
		'
		'colQtyFinishGood
		'
		Me.colQtyFinishGood.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colQtyFinishGood.AppearanceCell.Options.UseBackColor = True
		Me.colQtyFinishGood.FieldName = "QtyFinishGood"
		Me.colQtyFinishGood.Name = "colQtyFinishGood"
		Me.colQtyFinishGood.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyFinishGood.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyFinishGood.Visible = True
		Me.colQtyFinishGood.VisibleIndex = 18
		Me.colQtyFinishGood.Width = 50
		'
		'colQtyFG
		'
		Me.colQtyFG.Caption = "FG"
		Me.colQtyFG.FieldName = "QtyFG"
		Me.colQtyFG.Name = "colQtyFG"
		Me.colQtyFG.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyFG.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyFG.Visible = True
		Me.colQtyFG.VisibleIndex = 20
		Me.colQtyFG.Width = 50
		'
		'colQtyCutting
		'
		Me.colQtyCutting.Caption = "Cutting"
		Me.colQtyCutting.FieldName = "QtyCutting"
		Me.colQtyCutting.Name = "colQtyCutting"
		Me.colQtyCutting.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyCutting.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyCutting.Visible = True
		Me.colQtyCutting.VisibleIndex = 19
		Me.colQtyCutting.Width = 50
		'
		'colQtyNG
		'
		Me.colQtyNG.Caption = "NG"
		Me.colQtyNG.FieldName = "QtyNG"
		Me.colQtyNG.Name = "colQtyNG"
		Me.colQtyNG.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colQtyNG.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyNG.Visible = True
		Me.colQtyNG.VisibleIndex = 21
		Me.colQtyNG.Width = 50
		'
		'colShift
		'
		Me.colShift.Caption = "Shift"
		Me.colShift.FieldName = "Shift"
		Me.colShift.Name = "colShift"
		Me.colShift.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colShift.Visible = True
		Me.colShift.VisibleIndex = 9
		Me.colShift.Width = 50
		'
		'colWaktuStopLine
		'
		Me.colWaktuStopLine.FieldName = "WaktuStopLine"
		Me.colWaktuStopLine.Name = "colWaktuStopLine"
		Me.colWaktuStopLine.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colWaktuStopLine.Visible = True
		Me.colWaktuStopLine.VisibleIndex = 22
		Me.colWaktuStopLine.Width = 80
		'
		'colKeterangan
		'
		Me.colKeterangan.FieldName = "Keterangan"
		Me.colKeterangan.Name = "colKeterangan"
		Me.colKeterangan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colKeterangan.Visible = True
		Me.colKeterangan.VisibleIndex = 23
		Me.colKeterangan.Width = 150
		'
		'colJamKerja
		'
		Me.colJamKerja.Caption = "Jam Kerja"
		Me.colJamKerja.FieldName = "JamKerja"
		Me.colJamKerja.Name = "colJamKerja"
		Me.colJamKerja.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
		Me.colJamKerja.Visible = True
		Me.colJamKerja.VisibleIndex = 10
		Me.colJamKerja.Width = 50
		'
		'btnCekStock
		'
		Me.btnCekStock.Caption = "Cek Stock"
		Me.btnCekStock.Id = 29
		Me.btnCekStock.Name = "btnCekStock"
		'
		'colPDO
		'
		Me.colPDO.Caption = "No. PDO"
		Me.colPDO.FieldName = "CuttingWIP.OrderProduksi.NomorPDO"
		Me.colPDO.Name = "colPDO"
		Me.colPDO.Visible = True
		Me.colPDO.VisibleIndex = 7
		'
		'UI_FusohDailyProsesWIP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(912, 395)
		Me.Name = "UI_FusohDailyProsesWIP"
		Me.Text = "Daily Process"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colPartNumberRepo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPelanggan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDempyouLot As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colProduksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDempyou As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
	Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnUnposting As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnReset As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colPartNumber As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFGSize As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyDempyou As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOP1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOP2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOP3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOP4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOP5 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMesin As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colProcess As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyFinishGood As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyFG As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyCutting As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyNG As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colShift As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colWaktuStopLine As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colJamKerja As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPartNumberRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents btnCekStock As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colPDO As DevExpress.XtraGrid.Columns.GridColumn
End Class
