<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_zNishiOrderPenjualan
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_zNishiOrderPenjualan))
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUnposting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
    Me.btnResetStatus = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetak = New DevExpress.XtraBars.BarButtonItem()
    Me.btnHistory = New DevExpress.XtraBars.BarButtonItem()
    Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJenisJO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.cold_blno = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnUpdate, Me.btnPosting, Me.btnUnposting, Me.btnClosing, Me.BarButtonItem4, Me.btnSaveLayout, Me.btnCetak, Me.btnHistory, Me.btnResetStatus, Me.BarButtonItem1})
    Me.barMan.MaxItemId = 23
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTipe, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.colCustomer, Me.colStatus, Me.colJenisJO, Me.cold_blno})
    Me.xGridView.GroupCount = 2
    Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = "Id;Tahun;Bulan;Urutan;Kode;Tanggal;StatusTransaksi;Pelanggan.Nama;Catatan;JenisJO" &
    ";d_blno;TipeBarangJO"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.NishiOrderPembelian)
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
    Me.colKode.VisibleIndex = 1
    '
    'colTanggal
    '
    Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 2
    '
    'colCustomer
    '
    Me.colCustomer.Caption = "Customer"
    Me.colCustomer.FieldName = "Pelanggan.Nama"
    Me.colCustomer.Name = "colCustomer"
    Me.colCustomer.OptionsColumn.ReadOnly = True
    Me.colCustomer.Visible = True
    Me.colCustomer.VisibleIndex = 3
    '
    'btnUpdate
    '
    Me.btnUpdate.Caption = "&Update Status"
    Me.btnUpdate.Glyph = CType(resources.GetObject("btnUpdate.Glyph"), System.Drawing.Image)
    Me.btnUpdate.Id = 13
    Me.btnUpdate.LargeGlyph = CType(resources.GetObject("btnUpdate.LargeGlyph"), System.Drawing.Image)
    Me.btnUpdate.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUnposting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClosing, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnResetStatus, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
    'btnResetStatus
    '
    Me.btnResetStatus.Caption = "Reset Status Transaksi"
    Me.btnResetStatus.Glyph = CType(resources.GetObject("btnResetStatus.Glyph"), System.Drawing.Image)
    Me.btnResetStatus.Id = 21
    Me.btnResetStatus.LargeGlyph = CType(resources.GetObject("btnResetStatus.LargeGlyph"), System.Drawing.Image)
    Me.btnResetStatus.Name = "btnResetStatus"
    Me.btnResetStatus.Tag = "mereset"
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
    'colStatus
    '
    Me.colStatus.Caption = "Status"
    Me.colStatus.FieldName = "StatusTransaksi"
    Me.colStatus.Name = "colStatus"
    Me.colStatus.Visible = True
    Me.colStatus.VisibleIndex = 5
    '
    'colJenisJO
    '
    Me.colJenisJO.FieldName = "JenisJO"
    Me.colJenisJO.Name = "colJenisJO"
    Me.colJenisJO.Visible = True
    Me.colJenisJO.VisibleIndex = 4
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "BarButtonItem1"
    Me.BarButtonItem1.Id = 22
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'cold_blno
    '
    Me.cold_blno.Caption = "No BL"
    Me.cold_blno.FieldName = "d_blno"
    Me.cold_blno.Name = "cold_blno"
    Me.cold_blno.Visible = True
    Me.cold_blno.VisibleIndex = 6
    '
    'colTipe
    '
    Me.colTipe.AppearanceHeader.Options.UseTextOptions = True
    Me.colTipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colTipe.Caption = "Tipe"
    Me.colTipe.FieldName = "TipeBarangJO"
    Me.colTipe.Name = "colTipe"
    Me.colTipe.Visible = True
    Me.colTipe.VisibleIndex = 0
    '
    'UI_zNishiOrderPenjualan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_zNishiOrderPenjualan"
    Me.Text = "Job Order (JO)"
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
  Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUnposting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetak As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnHistory As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnResetStatus As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colJenisJO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents cold_blno As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
End Class
