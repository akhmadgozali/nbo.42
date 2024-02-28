﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TMOrder
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TMOrder))
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colStart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colEnd = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
		Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
		Me.btnUnposting = New DevExpress.XtraBars.BarButtonItem()
		Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
		Me.btnCetak = New DevExpress.XtraBars.BarButtonItem()
		Me.btnHistory = New DevExpress.XtraBars.BarButtonItem()
		Me.colShareholders = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colShipment = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.DataSource = Me.ifSource
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnUpdate, Me.btnPosting, Me.btnUnposting, Me.btnClosing, Me.BarButtonItem4, Me.btnSaveLayout, Me.btnCetak, Me.btnHistory, Me.BarButtonItem1})
		Me.barMan.MaxItemId = 22
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colShareholders, Me.colKode, Me.colType, Me.colCustomer, Me.colTanggal, Me.colStart, Me.colEnd, Me.colOrderStatus, Me.colShipment, Me.colUpdated, Me.colStatusTransaksi})
		Me.xGridView.GroupCount = 3
		Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colShareholders, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'ifSource
		'
		Me.ifSource.DisplayableProperties = "last_modified;Id;Tahun;Bulan;Kode;Tanggal;Regional.Nama;Pelanggan.Nama;StatusTran" &
		"saksi;OrderType;OrderStatus;OrderStart;Remarks;Description;OrderEnd;TotalShipmen" &
		"t;TotalQty;last_date"
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.Tm_Penawaran)
		'
		'popMenu
		'
		Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetak, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnHistory, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		Me.colId.OptionsColumn.ReadOnly = True
		'
		'colTahun
		'
		Me.colTahun.Caption = "Year"
		Me.colTahun.FieldName = "Tahun"
		Me.colTahun.Name = "colTahun"
		Me.colTahun.OptionsColumn.ReadOnly = True
		Me.colTahun.Visible = True
		Me.colTahun.VisibleIndex = 1
		'
		'colBulan
		'
		Me.colBulan.Caption = "Month"
		Me.colBulan.DisplayFormat.FormatString = "MMMM"
		Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.FieldName = "Bulan"
		Me.colBulan.GroupFormat.FormatString = "MMMM"
		Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.Name = "colBulan"
		Me.colBulan.OptionsColumn.ReadOnly = True
		Me.colBulan.Visible = True
		Me.colBulan.VisibleIndex = 0
		'
		'colKode
		'
		Me.colKode.Caption = "Order Code"
		Me.colKode.FieldName = "Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 0
		Me.colKode.Width = 120
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Order Date"
		Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 3
		Me.colTanggal.Width = 64
		'
		'colCustomer
		'
		Me.colCustomer.Caption = "Customer"
		Me.colCustomer.FieldName = "Pelanggan.Nama"
		Me.colCustomer.Name = "colCustomer"
		Me.colCustomer.OptionsColumn.ReadOnly = True
		Me.colCustomer.Visible = True
		Me.colCustomer.VisibleIndex = 2
		Me.colCustomer.Width = 64
		'
		'colType
		'
		Me.colType.Caption = "Type"
		Me.colType.FieldName = "OrderType"
		Me.colType.Name = "colType"
		Me.colType.OptionsColumn.ReadOnly = True
		Me.colType.Visible = True
		Me.colType.VisibleIndex = 1
		Me.colType.Width = 64
		'
		'colStart
		'
		Me.colStart.Caption = "Start Date"
		Me.colStart.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colStart.FieldName = "OrderStart"
		Me.colStart.Name = "colStart"
		Me.colStart.OptionsColumn.ReadOnly = True
		Me.colStart.Visible = True
		Me.colStart.VisibleIndex = 4
		Me.colStart.Width = 64
		'
		'colStatusTransaksi
		'
		Me.colStatusTransaksi.Caption = "Status"
		Me.colStatusTransaksi.FieldName = "StatusTransaksi"
		Me.colStatusTransaksi.Name = "colStatusTransaksi"
		Me.colStatusTransaksi.Visible = True
		Me.colStatusTransaksi.VisibleIndex = 9
		Me.colStatusTransaksi.Width = 79
		'
		'colEnd
		'
		Me.colEnd.Caption = "End Date"
		Me.colEnd.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colEnd.FieldName = "OrderEnd"
		Me.colEnd.Name = "colEnd"
		Me.colEnd.Visible = True
		Me.colEnd.VisibleIndex = 5
		Me.colEnd.Width = 64
		'
		'btnUpdate
		'
		Me.btnUpdate.Caption = "&Update Status"
		Me.btnUpdate.Glyph = CType(resources.GetObject("btnUpdate.Glyph"), System.Drawing.Image)
		Me.btnUpdate.Id = 13
		Me.btnUpdate.LargeGlyph = CType(resources.GetObject("btnUpdate.LargeGlyph"), System.Drawing.Image)
		Me.btnUpdate.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUnposting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClosing, True)})
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
		Me.btnClosing.Id = 16
		Me.btnClosing.Name = "btnClosing"
		Me.btnClosing.Tag = "mengclosing"
		'
		'BarButtonItem4
		'
		Me.BarButtonItem4.Id = 17
		Me.BarButtonItem4.Name = "BarButtonItem4"
		'
		'btnSaveLayout
		'
		Me.btnSaveLayout.Caption = "Save Layout"
		Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
		Me.btnSaveLayout.Id = 18
		Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
		Me.btnSaveLayout.Name = "btnSaveLayout"
		'
		'btnCetak
		'
		Me.btnCetak.Caption = "Cetak Voucher"
		Me.btnCetak.Glyph = CType(resources.GetObject("btnCetak.Glyph"), System.Drawing.Image)
		Me.btnCetak.Id = 19
		Me.btnCetak.LargeGlyph = CType(resources.GetObject("btnCetak.LargeGlyph"), System.Drawing.Image)
		Me.btnCetak.Name = "btnCetak"
		Me.btnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
		'
		'btnHistory
		'
		Me.btnHistory.Caption = "Cek History Data"
		Me.btnHistory.Glyph = CType(resources.GetObject("btnHistory.Glyph"), System.Drawing.Image)
		Me.btnHistory.Id = 20
		Me.btnHistory.LargeGlyph = CType(resources.GetObject("btnHistory.LargeGlyph"), System.Drawing.Image)
		Me.btnHistory.Name = "btnHistory"
		'
		'colShareholders
		'
		Me.colShareholders.Caption = "Shareholders"
		Me.colShareholders.FieldName = "Regional.Nama"
		Me.colShareholders.Name = "colShareholders"
		Me.colShareholders.Visible = True
		Me.colShareholders.VisibleIndex = 5
		'
		'colOrderStatus
		'
		Me.colOrderStatus.Caption = "Order Status"
		Me.colOrderStatus.FieldName = "OrderStatus"
		Me.colOrderStatus.Name = "colOrderStatus"
		Me.colOrderStatus.Visible = True
		Me.colOrderStatus.VisibleIndex = 6
		Me.colOrderStatus.Width = 64
		'
		'colShipment
		'
		Me.colShipment.Caption = "# Shipment"
		Me.colShipment.FieldName = "TotalShipment"
		Me.colShipment.Name = "colShipment"
		Me.colShipment.Visible = True
		Me.colShipment.VisibleIndex = 7
		Me.colShipment.Width = 64
		'
		'colUpdated
		'
		Me.colUpdated.Caption = "Last Updated"
		Me.colUpdated.DisplayFormat.FormatString = "dd MMM yyyy hh:mm:ss"
		Me.colUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colUpdated.FieldName = "last_date"
		Me.colUpdated.Name = "colUpdated"
		Me.colUpdated.Visible = True
		Me.colUpdated.VisibleIndex = 8
		Me.colUpdated.Width = 64
		'
		'BarButtonItem1
		'
		Me.BarButtonItem1.Caption = "Get External Data"
		Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
		Me.BarButtonItem1.Id = 21
		Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
		Me.BarButtonItem1.Name = "BarButtonItem1"
		'
		'UI_TMOrder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_TMOrder"
		Me.Text = "Order"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colStart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colEnd As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
	Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnUnposting As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnCetak As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnHistory As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colShareholders As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colShipment As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colUpdated As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class