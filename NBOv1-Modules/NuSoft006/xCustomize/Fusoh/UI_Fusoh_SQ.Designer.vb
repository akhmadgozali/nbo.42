<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_Fusoh_SQ
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Fusoh_SQ))
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
		Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
		Me.btnUnposting = New DevExpress.XtraBars.BarButtonItem()
		Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
		Me.btnCetakVoucher1 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnHistory = New DevExpress.XtraBars.BarButtonItem()
		Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggalBerlakuAkhir = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggalBerlakuAwal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnCetakVoucher2 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnShowLog = New DevExpress.XtraBars.BarButtonItem()
		Me.colRevisi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colOthers = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnUpdate, Me.btnPosting, Me.btnUnposting, Me.btnClosing, Me.BarButtonItem4, Me.btnSaveLayout, Me.btnCetakVoucher1, Me.btnHistory, Me.btnCetakVoucher2, Me.btnShowLog})
		Me.barMan.MaxItemId = 23
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colRevisi, Me.colTanggal, Me.colCustomer, Me.colUang, Me.colTotal, Me.colTanggalBerlakuAwal, Me.colTanggalBerlakuAkhir, Me.colStatus, Me.colOthers})
		Me.xGridView.GroupCount = 2
		Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'ifSource
		'
		Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.Fusoh_Penawaran)
		'
		'popMenu
		'
		Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetakVoucher1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetakVoucher2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnHistory, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnShowLog, True)})
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
		Me.colTahun.FieldName = "Tahun"
		Me.colTahun.Name = "colTahun"
		Me.colTahun.OptionsColumn.ReadOnly = True
		Me.colTahun.Visible = True
		Me.colTahun.VisibleIndex = 0
		'
		'colBulan
		'
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
		Me.colKode.Caption = "No Transaksi"
		Me.colKode.FieldName = "Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 0
		'
		'colTanggal
		'
		Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		'
		'colCustomer
		'
		Me.colCustomer.Caption = "Customer"
		Me.colCustomer.FieldName = "Pelanggan.Nama"
		Me.colCustomer.Name = "colCustomer"
		Me.colCustomer.OptionsColumn.ReadOnly = True
		Me.colCustomer.Visible = True
		Me.colCustomer.VisibleIndex = 2
		'
		'colUang
		'
		Me.colUang.Caption = "Uang"
		Me.colUang.FieldName = "Uang.Kode"
		Me.colUang.Name = "colUang"
		Me.colUang.OptionsColumn.ReadOnly = True
		Me.colUang.Visible = True
		Me.colUang.VisibleIndex = 3
		'
		'colTotal
		'
		Me.colTotal.FieldName = "Total"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.Visible = True
		Me.colTotal.VisibleIndex = 5
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
		'btnCetakVoucher1
		'
		Me.btnCetakVoucher1.Caption = "Cetak Voucher 1"
		Me.btnCetakVoucher1.Glyph = CType(resources.GetObject("btnCetakVoucher1.Glyph"), System.Drawing.Image)
		Me.btnCetakVoucher1.Id = 19
		Me.btnCetakVoucher1.LargeGlyph = CType(resources.GetObject("btnCetakVoucher1.LargeGlyph"), System.Drawing.Image)
		Me.btnCetakVoucher1.Name = "btnCetakVoucher1"
		'
		'btnHistory
		'
		Me.btnHistory.Caption = "Cek History Data"
		Me.btnHistory.Glyph = CType(resources.GetObject("btnHistory.Glyph"), System.Drawing.Image)
		Me.btnHistory.Id = 20
		Me.btnHistory.LargeGlyph = CType(resources.GetObject("btnHistory.LargeGlyph"), System.Drawing.Image)
		Me.btnHistory.Name = "btnHistory"
		'
		'colStatus
		'
		Me.colStatus.Caption = "Status"
		Me.colStatus.FieldName = "StatusTransaksi"
		Me.colStatus.Name = "colStatus"
		Me.colStatus.Visible = True
		Me.colStatus.VisibleIndex = 8
		'
		'colTanggalBerlakuAkhir
		'
		Me.colTanggalBerlakuAkhir.Caption = "Akhir Tgl Berlaku"
		Me.colTanggalBerlakuAkhir.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggalBerlakuAkhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggalBerlakuAkhir.FieldName = "TanggalBerlakuAkhir"
		Me.colTanggalBerlakuAkhir.Name = "colTanggalBerlakuAkhir"
		Me.colTanggalBerlakuAkhir.Visible = True
		Me.colTanggalBerlakuAkhir.VisibleIndex = 7
		'
		'colTanggalBerlakuAwal
		'
		Me.colTanggalBerlakuAwal.Caption = "Awal Tgl Berlaku"
		Me.colTanggalBerlakuAwal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggalBerlakuAwal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggalBerlakuAwal.FieldName = "TanggalBerlakuAwal"
		Me.colTanggalBerlakuAwal.Name = "colTanggalBerlakuAwal"
		Me.colTanggalBerlakuAwal.Visible = True
		Me.colTanggalBerlakuAwal.VisibleIndex = 6
		'
		'btnCetakVoucher2
		'
		Me.btnCetakVoucher2.Caption = "Cetak Voucher 2"
		Me.btnCetakVoucher2.Glyph = CType(resources.GetObject("btnCetakVoucher2.Glyph"), System.Drawing.Image)
		Me.btnCetakVoucher2.Id = 21
		Me.btnCetakVoucher2.LargeGlyph = CType(resources.GetObject("btnCetakVoucher2.LargeGlyph"), System.Drawing.Image)
		Me.btnCetakVoucher2.Name = "btnCetakVoucher2"
		'
		'btnShowLog
		'
		Me.btnShowLog.Caption = "Show Log"
		Me.btnShowLog.Glyph = CType(resources.GetObject("btnShowLog.Glyph"), System.Drawing.Image)
		Me.btnShowLog.Id = 22
		Me.btnShowLog.LargeGlyph = CType(resources.GetObject("btnShowLog.LargeGlyph"), System.Drawing.Image)
		Me.btnShowLog.Name = "btnShowLog"
		'
		'colRevisi
		'
		Me.colRevisi.Caption = "Rev"
		Me.colRevisi.FieldName = "Revisi"
		Me.colRevisi.Name = "colRevisi"
		Me.colRevisi.Visible = True
		Me.colRevisi.VisibleIndex = 4
		'
		'colOthers
		'
		Me.colOthers.Caption = "Others"
		Me.colOthers.FieldName = "Others"
		Me.colOthers.Name = "colOthers"
		Me.colOthers.Visible = True
		Me.colOthers.VisibleIndex = 9
		'
		'UI_Fusoh_SQ
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_Fusoh_SQ"
		Me.Text = "Penawaran Penjualan [SQ]"
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
	Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
	Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnUnposting As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnCetakVoucher1 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnHistory As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggalBerlakuAwal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggalBerlakuAkhir As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnCetakVoucher2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowLog As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colRevisi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colOthers As DevExpress.XtraGrid.Columns.GridColumn
End Class
