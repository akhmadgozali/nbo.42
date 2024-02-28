<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanYuPIB
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SanYuPIB))
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoPengajuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoPendaftaran = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTglPendaftaran = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKPBC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUmur = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJatuhTempo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colReffNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnPending = New DevExpress.XtraBars.BarButtonItem()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.Size = New System.Drawing.Size(961, 423)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarSubItem1, Me.btnPosting, Me.btnPending})
    Me.barMan.MaxItemId = 17
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.GridColumn1, Me.GridColumn2, Me.GridColumn5, Me.colCatatan, Me.GridColumn3, Me.GridColumn4, Me.colKurs, Me.colNoPengajuan, Me.colNoPendaftaran, Me.colTglPendaftaran, Me.colKPBC, Me.colUmur, Me.colJatuhTempo, Me.colReffNo, Me.colStatusTransaksi})
    Me.xGridView.GroupCount = 2
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Descending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.SanYu_PIB)
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 0
    '
    'colBulan
    '
    Me.colBulan.FieldName = "Bulan"
    Me.colBulan.Name = "colBulan"
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 17
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 1
    Me.colKode.Width = 146
    '
    'colTanggal
    '
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 2
    Me.colTanggal.Width = 69
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Vendor"
    Me.GridColumn1.FieldName = "Vendor.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 3
    Me.GridColumn1.Width = 151
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "No Invoice"
    Me.GridColumn2.FieldName = "InvoicePembelian.Kode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 0
    Me.GridColumn2.Width = 99
    '
    'colCatatan
    '
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 5
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Uang"
    Me.GridColumn3.FieldName = "Uang.Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 6
    Me.GridColumn3.Width = 48
    '
    'colKurs
    '
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 8
    Me.colKurs.Width = 51
    '
    'colNoPengajuan
    '
    Me.colNoPengajuan.FieldName = "NoPengajuan"
    Me.colNoPengajuan.Name = "colNoPengajuan"
    Me.colNoPengajuan.Visible = True
    Me.colNoPengajuan.VisibleIndex = 9
    Me.colNoPengajuan.Width = 190
    '
    'colNoPendaftaran
    '
    Me.colNoPendaftaran.FieldName = "NoPendaftaran"
    Me.colNoPendaftaran.Name = "colNoPendaftaran"
    Me.colNoPendaftaran.Visible = True
    Me.colNoPendaftaran.VisibleIndex = 10
    Me.colNoPendaftaran.Width = 84
    '
    'colTglPendaftaran
    '
    Me.colTglPendaftaran.FieldName = "TglPendaftaran"
    Me.colTglPendaftaran.Name = "colTglPendaftaran"
    Me.colTglPendaftaran.Visible = True
    Me.colTglPendaftaran.VisibleIndex = 11
    Me.colTglPendaftaran.Width = 94
    '
    'colKPBC
    '
    Me.colKPBC.FieldName = "KPBC"
    Me.colKPBC.Name = "colKPBC"
    Me.colKPBC.Visible = True
    Me.colKPBC.VisibleIndex = 12
    Me.colKPBC.Width = 51
    '
    'colUmur
    '
    Me.colUmur.FieldName = "Umur"
    Me.colUmur.Name = "colUmur"
    Me.colUmur.Visible = True
    Me.colUmur.VisibleIndex = 13
    Me.colUmur.Width = 41
    '
    'colJatuhTempo
    '
    Me.colJatuhTempo.FieldName = "JatuhTempo"
    Me.colJatuhTempo.Name = "colJatuhTempo"
    Me.colJatuhTempo.Visible = True
    Me.colJatuhTempo.VisibleIndex = 14
    '
    'colReffNo
    '
    Me.colReffNo.Caption = "No PIB"
    Me.colReffNo.FieldName = "ReffNo"
    Me.colReffNo.Name = "colReffNo"
    Me.colReffNo.Visible = True
    Me.colReffNo.VisibleIndex = 4
    Me.colReffNo.Width = 73
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "BarButtonItem1"
    Me.BarButtonItem1.Id = 13
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'colStatusTransaksi
    '
    Me.colStatusTransaksi.FieldName = "StatusTransaksi"
    Me.colStatusTransaksi.Name = "colStatusTransaksi"
    Me.colStatusTransaksi.Visible = True
    Me.colStatusTransaksi.VisibleIndex = 15
    Me.colStatusTransaksi.Width = 90
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Update Status"
    Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
    Me.BarSubItem1.Id = 14
    Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPending, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'btnPosting
    '
    Me.btnPosting.Caption = "Posting"
    Me.btnPosting.Glyph = CType(resources.GetObject("btnPosting.Glyph"), System.Drawing.Image)
    Me.btnPosting.Id = 15
    Me.btnPosting.LargeGlyph = CType(resources.GetObject("btnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnPosting.Name = "btnPosting"
    Me.btnPosting.Tag = "memposting"
    '
    'btnPending
    '
    Me.btnPending.Caption = "Pending"
    Me.btnPending.Glyph = CType(resources.GetObject("btnPending.Glyph"), System.Drawing.Image)
    Me.btnPending.Id = 16
    Me.btnPending.LargeGlyph = CType(resources.GetObject("btnPending.LargeGlyph"), System.Drawing.Image)
    Me.btnPending.Name = "btnPending"
    Me.btnPending.Tag = "mempending"
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "No Invoice"
    Me.GridColumn4.FieldName = "InvoicePembelian.Kode"
    Me.GridColumn4.Name = "GridColumn4"
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Invoice Pembelian"
    Me.GridColumn5.FieldName = "InvoicePembelian.NoReffVendor"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 7
    Me.GridColumn5.Width = 123
    '
    'UI_SanYuPIB
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(961, 450)
    Me.Name = "UI_SanYuPIB"
    Me.Text = "PIB"
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
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoPengajuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoPendaftaran As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTglPendaftaran As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKPBC As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUmur As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJatuhTempo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colReffNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnPending As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
