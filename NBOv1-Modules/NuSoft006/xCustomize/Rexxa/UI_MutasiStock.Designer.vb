<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zRexaUI_MutasiStock
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zRexaUI_MutasiStock))
    Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUnposting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colRegional = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPengirimKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPengirimNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPenerimaKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPenerimaNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colGudang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colGudangNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoPermintaan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.btnCetakVoucher1 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetakVoucher2 = New DevExpress.XtraBars.BarButtonItem()
    Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnUpdate, Me.btnPosting, Me.btnUnposting, Me.btnClosing, Me.btnSaveLayout, Me.BarSubItem1, Me.btnCetakVoucher1, Me.btnCetakVoucher2})
    Me.barMan.MaxItemId = 21
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.colRegional, Me.colPengirimKode, Me.colPengirimNama, Me.colPenerimaKode, Me.colPenerimaNama, Me.colGudang, Me.colGudangNama, Me.colCatatan, Me.colNoPermintaan, Me.colStatusTransaksi})
    Me.xGridView.GroupCount = 2
    Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsLayout.Columns.StoreAllOptions = True
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.zRexaStockMain)
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUpdate, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'btnUpdate
    '
    Me.btnUpdate.Caption = "&Update Status"
    Me.btnUpdate.Glyph = CType(resources.GetObject("btnUpdate.Glyph"), System.Drawing.Image)
    Me.btnUpdate.Id = 13
    Me.btnUpdate.LargeGlyph = CType(resources.GetObject("btnUpdate.LargeGlyph"), System.Drawing.Image)
    Me.btnUpdate.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPosting), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUnposting), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClosing, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.btnUpdate.Name = "btnUpdate"
    '
    'btnPosting
    '
    Me.btnPosting.Caption = "Posting Transaksi"
    Me.btnPosting.Enabled = False
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
    'btnSaveLayout
    '
    Me.btnSaveLayout.Caption = "Save Layout"
    Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
    Me.btnSaveLayout.Id = 17
    Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btnSaveLayout.Name = "btnSaveLayout"
    '
    'colcreated_date
    '
    Me.colcreated_date.Caption = "Tanggal Input"
    Me.colcreated_date.FieldName = "created_date"
    Me.colcreated_date.Name = "colcreated_date"
    '
    'colcreated_user
    '
    Me.colcreated_user.Caption = "User Input"
    Me.colcreated_user.FieldName = "created_user"
    Me.colcreated_user.Name = "colcreated_user"
    '
    'collast_date
    '
    Me.collast_date.Caption = "Tanggal Edit"
    Me.collast_date.FieldName = "last_date"
    Me.collast_date.Name = "collast_date"
    '
    'collast_modified
    '
    Me.collast_modified.Caption = "User Edit"
    Me.collast_modified.FieldName = "last_modified"
    Me.collast_modified.Name = "collast_modified"
    '
    'colId
    '
    Me.colId.Caption = "Id"
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    Me.colId.OptionsColumn.ReadOnly = True
    '
    'colTahun
    '
    Me.colTahun.Caption = "Tahun"
    Me.colTahun.FieldName = "Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.OptionsColumn.ReadOnly = True
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 0
    '
    'colBulan
    '
    Me.colBulan.Caption = "Bulan"
    Me.colBulan.FieldName = "Bulan"
    Me.colBulan.Name = "colBulan"
    Me.colBulan.OptionsColumn.ReadOnly = True
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 2
    '
    'colKode
    '
    Me.colKode.Caption = "No Bukti"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 103
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    Me.colTanggal.Width = 103
    '
    'colRegional
    '
    Me.colRegional.Caption = "Regional"
    Me.colRegional.FieldName = "Regional.Kode"
    Me.colRegional.Name = "colRegional"
    Me.colRegional.OptionsColumn.ReadOnly = True
    '
    'colPengirimKode
    '
    Me.colPengirimKode.Caption = "Kode Pengirim"
    Me.colPengirimKode.FieldName = "KaryawanKirim.Kode"
    Me.colPengirimKode.Name = "colPengirimKode"
    Me.colPengirimKode.OptionsColumn.ReadOnly = True
    Me.colPengirimKode.Width = 213
    '
    'colPengirimNama
    '
    Me.colPengirimNama.Caption = "Nama Pengirim"
    Me.colPengirimNama.FieldName = "KaryawanKirim.Nama"
    Me.colPengirimNama.Name = "colPengirimNama"
    Me.colPengirimNama.OptionsColumn.ReadOnly = True
    Me.colPengirimNama.Visible = True
    Me.colPengirimNama.VisibleIndex = 2
    '
    'colPenerimaKode
    '
    Me.colPenerimaKode.Caption = "Kode Penerima"
    Me.colPenerimaKode.FieldName = "KaryawanTerima.Kode"
    Me.colPenerimaKode.Name = "colPenerimaKode"
    Me.colPenerimaKode.OptionsColumn.ReadOnly = True
    Me.colPenerimaKode.Width = 122
    '
    'colPenerimaNama
    '
    Me.colPenerimaNama.Caption = "Nama Penerima"
    Me.colPenerimaNama.FieldName = "KaryawanTerima.Nama"
    Me.colPenerimaNama.Name = "colPenerimaNama"
    Me.colPenerimaNama.OptionsColumn.ReadOnly = True
    Me.colPenerimaNama.Width = 65
    '
    'colGudang
    '
    Me.colGudang.Caption = "Gudang"
    Me.colGudang.FieldName = "Gudang.Kode"
    Me.colGudang.Name = "colGudang"
    Me.colGudang.OptionsColumn.ReadOnly = True
    Me.colGudang.Visible = True
    Me.colGudang.VisibleIndex = 3
    Me.colGudang.Width = 65
    '
    'colGudangNama
    '
    Me.colGudangNama.Caption = "Gudang Nama"
    Me.colGudangNama.FieldName = "Gudang.Nama"
    Me.colGudangNama.Name = "colGudangNama"
    Me.colGudangNama.OptionsColumn.ReadOnly = True
    Me.colGudangNama.Width = 65
    '
    'colCatatan
    '
    Me.colCatatan.Caption = "Catatan"
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 4
    Me.colCatatan.Width = 65
    '
    'colNoPermintaan
    '
    Me.colNoPermintaan.Caption = "No Sales Order"
    Me.colNoPermintaan.FieldName = "OrderPenjualan.Kode"
    Me.colNoPermintaan.Name = "colNoPermintaan"
    Me.colNoPermintaan.OptionsColumn.ReadOnly = True
    Me.colNoPermintaan.Visible = True
    Me.colNoPermintaan.VisibleIndex = 5
    Me.colNoPermintaan.Width = 78
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Cetak Voucher"
    Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
    Me.BarSubItem1.Id = 18
    Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnCetakVoucher1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCetakVoucher2)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'btnCetakVoucher1
    '
    Me.btnCetakVoucher1.Caption = "Voucher Surat Jalan Masuk"
    Me.btnCetakVoucher1.Glyph = CType(resources.GetObject("btnCetakVoucher1.Glyph"), System.Drawing.Image)
    Me.btnCetakVoucher1.Id = 19
    Me.btnCetakVoucher1.LargeGlyph = CType(resources.GetObject("btnCetakVoucher1.LargeGlyph"), System.Drawing.Image)
    Me.btnCetakVoucher1.Name = "btnCetakVoucher1"
    '
    'btnCetakVoucher2
    '
    Me.btnCetakVoucher2.Caption = "Voucher Surat Jalan Keluar"
    Me.btnCetakVoucher2.Glyph = CType(resources.GetObject("btnCetakVoucher2.Glyph"), System.Drawing.Image)
    Me.btnCetakVoucher2.Id = 20
    Me.btnCetakVoucher2.LargeGlyph = CType(resources.GetObject("btnCetakVoucher2.LargeGlyph"), System.Drawing.Image)
    Me.btnCetakVoucher2.Name = "btnCetakVoucher2"
    '
    'colStatusTransaksi
    '
    Me.colStatusTransaksi.FieldName = "StatusTransaksi"
    Me.colStatusTransaksi.Name = "colStatusTransaksi"
    Me.colStatusTransaksi.Visible = True
    Me.colStatusTransaksi.VisibleIndex = 6
    '
    'zRexaUI_MutasiStock
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "zRexaUI_MutasiStock"
    Me.Text = "Mutasi Stock"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUnposting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colRegional As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPengirimKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPengirimNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPenerimaKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPenerimaNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colGudang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colGudangNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoPermintaan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnCetakVoucher1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetakVoucher2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
End Class
