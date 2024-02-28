<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SanYuPenerimaanBarang
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SanYuPenerimaanBarang))
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUrutan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colFromDomestik = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnPending = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetakVoucher = New DevExpress.XtraBars.BarButtonItem()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.ifSource
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
    Me.xGrid.Size = New System.Drawing.Size(800, 423)
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'xpCol
    '
    Me.xpCol.DisplayableProperties = "This;created_date;created_user;last_date;last_modified;Number;Id;Tahun;Bulan;Urut" &
    "an;Kode;Tanggal;Regional.Kode;Vendor.Kode;Vendor.Nama;Gudang.Kode;Uraian;StatusT" &
    "ransaksi;KontakPerson"
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.SanYu_PenerimaanBarang)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.btnPosting, Me.btnPending, Me.btnCetakVoucher})
    Me.barMan.MaxItemId = 17
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colNumber, Me.colId, Me.colTahun, Me.colBulan, Me.colUrutan, Me.colKode, Me.colTanggal, Me.colFromDomestik, Me.GridColumn1, Me.GridColumn2, Me.colUraian, Me.colStatusTransaksi, Me.GridColumn6, Me.GridColumn7})
    Me.xGridView.GroupCount = 2
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFromDomestik, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = "created_date;created_user;last_date;last_modified;Id;Tahun;Bulan;Urutan;Kode;Tang" &
    "gal;Vendor.Nama;Gudang.Kode;StatusTransaksi;Uraian;FromDomestik;Gl.Kode;PIB.Kode" &
    ";PIB.ReffNo"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.SanYu_PenerimaanBarang)
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnCetakVoucher)})
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
    Me.GridView1.GridControl = Me.xGrid
    Me.GridView1.Name = "GridView1"
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "GridColumn3"
    Me.GridColumn3.FieldName = "Barang.Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "GridColumn4"
    Me.GridColumn4.FieldName = "Barang.Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "GridColumn5"
    Me.GridColumn5.FieldName = "Qty"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 2
    '
    'colcreated_date
    '
    Me.colcreated_date.FieldName = "created_date"
    Me.colcreated_date.Name = "colcreated_date"
    '
    'colcreated_user
    '
    Me.colcreated_user.FieldName = "created_user"
    Me.colcreated_user.Name = "colcreated_user"
    '
    'collast_date
    '
    Me.collast_date.FieldName = "last_date"
    Me.collast_date.Name = "collast_date"
    '
    'collast_modified
    '
    Me.collast_modified.FieldName = "last_modified"
    Me.collast_modified.Name = "collast_modified"
    '
    'colNumber
    '
    Me.colNumber.FieldName = "Number"
    Me.colNumber.Name = "colNumber"
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
    Me.colBulan.OptionsColumn.ReadOnly = True
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 3
    '
    'colUrutan
    '
    Me.colUrutan.FieldName = "Urutan"
    Me.colUrutan.Name = "colUrutan"
    Me.colUrutan.OptionsColumn.ReadOnly = True
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 1
    Me.colKode.Width = 115
    '
    'colTanggal
    '
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 0
    Me.colTanggal.Width = 115
    '
    'colUraian
    '
    Me.colUraian.FieldName = "Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 5
    Me.colUraian.Width = 121
    '
    'colStatusTransaksi
    '
    Me.colStatusTransaksi.FieldName = "StatusTransaksi"
    Me.colStatusTransaksi.Name = "colStatusTransaksi"
    Me.colStatusTransaksi.Visible = True
    Me.colStatusTransaksi.VisibleIndex = 6
    Me.colStatusTransaksi.Width = 127
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Vendor"
    Me.GridColumn1.FieldName = "Vendor.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    Me.GridColumn1.Width = 115
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Gudang"
    Me.GridColumn2.FieldName = "Gudang.Kode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 4
    Me.GridColumn2.Width = 121
    '
    'colFromDomestik
    '
    Me.colFromDomestik.Caption = "Dom"
    Me.colFromDomestik.ColumnEdit = Me.RepositoryItemCheckEdit1
    Me.colFromDomestik.FieldName = "FromDomestik"
    Me.colFromDomestik.Name = "colFromDomestik"
    Me.colFromDomestik.Visible = True
    Me.colFromDomestik.VisibleIndex = 3
    Me.colFromDomestik.Width = 68
    '
    'RepositoryItemCheckEdit1
    '
    Me.RepositoryItemCheckEdit1.AutoHeight = False
    Me.RepositoryItemCheckEdit1.Caption = "Check"
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Update Status"
    Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
    Me.BarSubItem1.Id = 13
    Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPending, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'btnPosting
    '
    Me.btnPosting.Caption = "Posting"
    Me.btnPosting.Glyph = CType(resources.GetObject("btnPosting.Glyph"), System.Drawing.Image)
    Me.btnPosting.Id = 14
    Me.btnPosting.LargeGlyph = CType(resources.GetObject("btnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnPosting.Name = "btnPosting"
    Me.btnPosting.Tag = "memposting"
    '
    'btnPending
    '
    Me.btnPending.Caption = "Pending"
    Me.btnPending.Glyph = CType(resources.GetObject("btnPending.Glyph"), System.Drawing.Image)
    Me.btnPending.Id = 15
    Me.btnPending.LargeGlyph = CType(resources.GetObject("btnPending.LargeGlyph"), System.Drawing.Image)
    Me.btnPending.Name = "btnPending"
    Me.btnPending.Tag = "mempending"
    '
    'btnCetakVoucher
    '
    Me.btnCetakVoucher.Caption = "Cetak Voucher"
    Me.btnCetakVoucher.Glyph = CType(resources.GetObject("btnCetakVoucher.Glyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Id = 16
    Me.btnCetakVoucher.LargeGlyph = CType(resources.GetObject("btnCetakVoucher.LargeGlyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Name = "btnCetakVoucher"
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "No Bukti PIB"
    Me.GridColumn6.FieldName = "PIB.Kode"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 7
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "No PIB"
    Me.GridColumn7.FieldName = "PIB.ReffNo"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 8
    '
    'UI_SanYuPenerimaanBarang
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Name = "UI_SanYuPenerimaanBarang"
    Me.Text = "Peneriman Barang"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUrutan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents colFromDomestik As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnPending As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetakVoucher As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
