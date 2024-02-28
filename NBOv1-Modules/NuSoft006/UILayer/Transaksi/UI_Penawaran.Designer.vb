<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Penawaran
  Inherits Core.Win.Forms.GridInput

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Penawaran))
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSalesman = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
		Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
		Me.btnUnposting = New DevExpress.XtraBars.BarButtonItem()
		Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
		Me.btnCetak = New DevExpress.XtraBars.BarButtonItem()
		Me.btnHistory = New DevExpress.XtraBars.BarButtonItem()
		Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLeadTime = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan1 = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnUpdate, Me.btnPosting, Me.btnUnposting, Me.btnClosing, Me.BarButtonItem4, Me.btnSaveLayout, Me.btnCetak, Me.btnHistory})
		Me.barMan.MaxItemId = 21
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.colCustomer, Me.colTipe, Me.colSalesman, Me.colUang, Me.colTotal, Me.colStatusTransaksi, Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colCatatan, Me.GridColumn1, Me.colLeadTime, Me.colCatatan1})
		Me.xGridView.GroupCount = 2
		Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'ifSource
		'
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.Penawaran)
		'
		'popMenu
		'
		Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetak, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnHistory, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
		Me.colBulan.FieldName = "Bulan"
		Me.colBulan.Name = "colBulan"
    Me.colBulan.DisplayFormat.FormatString = "MMMM"
    Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.GroupFormat.FormatString = "MMMM"
    Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.OptionsColumn.ReadOnly = True
    Me.colBulan.Visible = True
		Me.colBulan.VisibleIndex = 8
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
		'colTipe
		'
		Me.colTipe.Caption = "Tipe"
		Me.colTipe.FieldName = "TipeTransaksi.Kode"
		Me.colTipe.Name = "colTipe"
		Me.colTipe.OptionsColumn.ReadOnly = True
		'
		'colSalesman
		'
		Me.colSalesman.Caption = "Salesman"
		Me.colSalesman.FieldName = "Salesman.Nama"
		Me.colSalesman.Name = "colSalesman"
		Me.colSalesman.OptionsColumn.ReadOnly = True
		'
		'colUang
		'
		Me.colUang.Caption = "Uang"
		Me.colUang.FieldName = "Uang.Kode"
		Me.colUang.Name = "colUang"
		Me.colUang.OptionsColumn.ReadOnly = True
		Me.colUang.Visible = True
		Me.colUang.VisibleIndex = 4
		'
		'colStatusTransaksi
		'
		Me.colStatusTransaksi.FieldName = "StatusTransaksi"
		Me.colStatusTransaksi.Name = "colStatusTransaksi"
		Me.colStatusTransaksi.Visible = True
		Me.colStatusTransaksi.VisibleIndex = 6
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
		'btnCetak
		'
		Me.btnCetak.Caption = "Cetak Voucher"
		Me.btnCetak.Glyph = CType(resources.GetObject("btnCetak.Glyph"), System.Drawing.Image)
		Me.btnCetak.Id = 19
		Me.btnCetak.LargeGlyph = CType(resources.GetObject("btnCetak.LargeGlyph"), System.Drawing.Image)
		Me.btnCetak.Name = "btnCetak"
		'
		'btnHistory
		'
		Me.btnHistory.Caption = "Cek History Data"
		Me.btnHistory.Glyph = CType(resources.GetObject("btnHistory.Glyph"), System.Drawing.Image)
		Me.btnHistory.Id = 20
		Me.btnHistory.LargeGlyph = CType(resources.GetObject("btnHistory.LargeGlyph"), System.Drawing.Image)
		Me.btnHistory.Name = "btnHistory"
		'
		'colcreated_date
		'
		Me.colcreated_date.Caption = "Create Date"
		Me.colcreated_date.FieldName = "created_date"
		Me.colcreated_date.Name = "colcreated_date"
		'
		'colcreated_user
		'
		Me.colcreated_user.Caption = "Create User"
		Me.colcreated_user.FieldName = "created_user"
		Me.colcreated_user.Name = "colcreated_user"
		'
		'collast_date
		'
		Me.collast_date.Caption = "Modified Date"
		Me.collast_date.FieldName = "last_date"
		Me.collast_date.Name = "collast_date"
		'
		'collast_modified
		'
		Me.collast_modified.Caption = "Modified User"
		Me.collast_modified.FieldName = "last_modified"
		Me.collast_modified.Name = "collast_modified"
		'
		'colCatatan
		'
		Me.colCatatan.Caption = "Uraian"
		Me.colCatatan.FieldName = "Uraian"
		Me.colCatatan.Name = "colCatatan"
		Me.colCatatan.Visible = True
		Me.colCatatan.VisibleIndex = 3
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Alamat"
		Me.GridColumn1.FieldName = "Alamat.Kode"
		Me.GridColumn1.Name = "GridColumn1"
		'
		'colLeadTime
		'
		Me.colLeadTime.Caption = "Lead Time"
		Me.colLeadTime.FieldName = "LeadTime"
		Me.colLeadTime.Name = "colLeadTime"
		'
		'colCatatan1
		'
		Me.colCatatan1.Caption = "Catatan"
		Me.colCatatan1.FieldName = "Catatan"
		Me.colCatatan1.Name = "colCatatan1"
		'
		'UI_Penawaran
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_Penawaran"
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
  Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSalesman As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUnposting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetak As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnHistory As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLeadTime As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCatatan1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
