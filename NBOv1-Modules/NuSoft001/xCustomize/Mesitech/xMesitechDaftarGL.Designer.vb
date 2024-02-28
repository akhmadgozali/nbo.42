<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xMesitechDaftarGL
  Inherits Core.Win.Forms.GridOutput

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xMesitechDaftarGL))
    Me.btnSaveLayout = New DevExpress.XtraBars.BarCheckItem()
    Me.cmdTampilkan = New DevExpress.XtraBars.BarButtonItem()
    Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkunKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebitValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKreditValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colProyekKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colProyekNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colRegional = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCreated = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCreatedUser = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colModified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnFilter = New DevExpress.XtraBars.BarButtonItem()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.btnFilterCustom = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilter1 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilter2 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilter3 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilter4 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilter5 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilter6 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilter7 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnPending = New DevExpress.XtraBars.BarButtonItem()
    Me.btnVerifikasi = New DevExpress.XtraBars.BarButtonItem()
    Me.colSubProyek = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSumber = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerControl1.SuspendLayout()
    CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout, Me.cmdTampilkan, Me.btnFilter, Me.BarSubItem1, Me.btnFilterCustom, Me.btnFilter1, Me.btnFilter2, Me.btnFilter3, Me.btnFilter4, Me.btnFilter5, Me.btnFilter6, Me.btnFilter7, Me.btnPending, Me.btnVerifikasi})
    Me.barMan.MaxItemId = 36
    '
    'xpCol
    '
    Me.xpCol.DisplayableProperties = resources.GetString("xpCol.DisplayableProperties")
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.xMesitechGlDetail)
    '
    'xGrid
    '
    Me.xGrid.Size = New System.Drawing.Size(894, 301)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoBukti, Me.colTanggal, Me.colTahun, Me.colBulan, Me.colAkunKode, Me.colNamaAkun, Me.colDebit, Me.colKredit, Me.colUang, Me.colKurs, Me.colDebitValas, Me.colKreditValas, Me.colDivisi, Me.colProyekKode, Me.colProyekNama, Me.colKodeKontak, Me.colNamaKontak, Me.colKeterangan, Me.colUraian, Me.colRegional, Me.colCreated, Me.colCreatedUser, Me.colModified, Me.colModifiedUser, Me.colNama, Me.colSubProyek, Me.colSumber, Me.colStatus})
    Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(739, 182, 210, 179)
    Me.xGridView.GroupCount = 4
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsLayout.Columns.StoreAllOptions = True
    Me.xGridView.OptionsLayout.Columns.StoreAppearance = True
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRegional, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNama, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDivisi, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdTampilkan, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'SplitContainerControl1
    '
    Me.SplitContainerControl1.Size = New System.Drawing.Size(894, 385)
    Me.SplitContainerControl1.SplitterPosition = 301
    '
    'btnSaveLayout
    '
    Me.btnSaveLayout.Caption = "Save Layout"
    Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
    Me.btnSaveLayout.Id = 22
    Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btnSaveLayout.Name = "btnSaveLayout"
    '
    'cmdTampilkan
    '
    Me.cmdTampilkan.Caption = "Tampilkan Transaksi"
    Me.cmdTampilkan.Glyph = CType(resources.GetObject("cmdTampilkan.Glyph"), System.Drawing.Image)
    Me.cmdTampilkan.Id = 23
    Me.cmdTampilkan.LargeGlyph = CType(resources.GetObject("cmdTampilkan.LargeGlyph"), System.Drawing.Image)
    Me.cmdTampilkan.Name = "cmdTampilkan"
    '
    'colNoBukti
    '
    Me.colNoBukti.Caption = "No Bukti"
    Me.colNoBukti.FieldName = "Main.Kode"
    Me.colNoBukti.Name = "colNoBukti"
    Me.colNoBukti.OptionsColumn.ReadOnly = True
    Me.colNoBukti.Visible = True
    Me.colNoBukti.VisibleIndex = 0
    Me.colNoBukti.Width = 104
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.DisplayFormat.FormatString = "dd-MMM-yy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggal.FieldName = "Main.Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.OptionsColumn.ReadOnly = True
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    Me.colTanggal.Width = 114
    '
    'colTahun
    '
    Me.colTahun.Caption = "Tahun"
    Me.colTahun.FieldName = "Main.Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.OptionsColumn.ReadOnly = True
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 2
    Me.colTahun.Width = 71
    '
    'colBulan
    '
    Me.colBulan.Caption = "Bulan"
    Me.colBulan.DisplayFormat.FormatString = "MMMM"
    Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.FieldName = "Main.Bulan"
    Me.colBulan.GroupFormat.FormatString = "MMMM"
    Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.Name = "colBulan"
    Me.colBulan.OptionsColumn.ReadOnly = True
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 2
    Me.colBulan.Width = 109
    '
    'colAkunKode
    '
    Me.colAkunKode.Caption = "Kode Akun"
    Me.colAkunKode.FieldName = "Akun.Kode"
    Me.colAkunKode.Name = "colAkunKode"
    Me.colAkunKode.OptionsColumn.ReadOnly = True
    Me.colAkunKode.Width = 99
    '
    'colNamaAkun
    '
    Me.colNamaAkun.Caption = "Nama Akun"
    Me.colNamaAkun.FieldName = "Akun.Nama"
    Me.colNamaAkun.Name = "colNamaAkun"
    Me.colNamaAkun.OptionsColumn.ReadOnly = True
    Me.colNamaAkun.Width = 70
    '
    'colDebit
    '
    Me.colDebit.Caption = "Debit"
    Me.colDebit.FieldName = "Debit"
    Me.colDebit.Name = "colDebit"
    Me.colDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colDebit.Visible = True
    Me.colDebit.VisibleIndex = 2
    Me.colDebit.Width = 96
    '
    'colKredit
    '
    Me.colKredit.Caption = "Kredit"
    Me.colKredit.FieldName = "Kredit"
    Me.colKredit.Name = "colKredit"
    Me.colKredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colKredit.Visible = True
    Me.colKredit.VisibleIndex = 3
    Me.colKredit.Width = 77
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.FieldName = "MataUang.Kode"
    Me.colUang.Name = "colUang"
    Me.colUang.OptionsColumn.ReadOnly = True
    Me.colUang.Width = 80
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs"
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Width = 21
    '
    'colDebitValas
    '
    Me.colDebitValas.Caption = "Debit Valas"
    Me.colDebitValas.FieldName = "DebitValas"
    Me.colDebitValas.Name = "colDebitValas"
    Me.colDebitValas.Width = 21
    '
    'colKreditValas
    '
    Me.colKreditValas.Caption = "Kredit Valas"
    Me.colKreditValas.FieldName = "KreditValas"
    Me.colKreditValas.Name = "colKreditValas"
    Me.colKreditValas.Width = 21
    '
    'colDivisi
    '
    Me.colDivisi.Caption = "Divisi"
    Me.colDivisi.FieldName = "Divisi.Kode"
    Me.colDivisi.Name = "colDivisi"
    Me.colDivisi.OptionsColumn.ReadOnly = True
    Me.colDivisi.Width = 94
    '
    'colProyekKode
    '
    Me.colProyekKode.Caption = "Kode Proyek"
    Me.colProyekKode.FieldName = "Proyek.Kode"
    Me.colProyekKode.Name = "colProyekKode"
    Me.colProyekKode.OptionsColumn.ReadOnly = True
    Me.colProyekKode.Width = 20
    '
    'colProyekNama
    '
    Me.colProyekNama.Caption = "Nama Proyek"
    Me.colProyekNama.FieldName = "Proyek.Nama"
    Me.colProyekNama.Name = "colProyekNama"
    Me.colProyekNama.OptionsColumn.ReadOnly = True
    Me.colProyekNama.Width = 20
    '
    'colKodeKontak
    '
    Me.colKodeKontak.Caption = "Kode Kontak"
    Me.colKodeKontak.FieldName = "Main.Kontak.Kode"
    Me.colKodeKontak.Name = "colKodeKontak"
    Me.colKodeKontak.OptionsColumn.ReadOnly = True
    Me.colKodeKontak.Width = 112
    '
    'colNamaKontak
    '
    Me.colNamaKontak.Caption = "Nama Kontak"
    Me.colNamaKontak.FieldName = "Main.Kontak.Nama"
    Me.colNamaKontak.Name = "colNamaKontak"
    Me.colNamaKontak.OptionsColumn.ReadOnly = True
    Me.colNamaKontak.Visible = True
    Me.colNamaKontak.VisibleIndex = 4
    Me.colNamaKontak.Width = 112
    '
    'colKeterangan
    '
    Me.colKeterangan.Caption = "Catatan"
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 5
    Me.colKeterangan.Width = 112
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Main.Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.OptionsColumn.ReadOnly = True
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 6
    Me.colUraian.Width = 112
    '
    'colRegional
    '
    Me.colRegional.Caption = "Regional"
    Me.colRegional.FieldName = "Main.Regional.Kode"
    Me.colRegional.Name = "colRegional"
    Me.colRegional.OptionsColumn.ReadOnly = True
    Me.colRegional.Visible = True
    Me.colRegional.VisibleIndex = 7
    Me.colRegional.Width = 153
    '
    'colCreated
    '
    Me.colCreated.Caption = "Tgl Input"
    Me.colCreated.FieldName = "Main.created_date"
    Me.colCreated.Name = "colCreated"
    Me.colCreated.OptionsColumn.ReadOnly = True
    Me.colCreated.Width = 20
    '
    'colCreatedUser
    '
    Me.colCreatedUser.Caption = "User Input"
    Me.colCreatedUser.FieldName = "Main.created_user"
    Me.colCreatedUser.Name = "colCreatedUser"
    Me.colCreatedUser.OptionsColumn.ReadOnly = True
    Me.colCreatedUser.Width = 20
    '
    'colModified
    '
    Me.colModified.Caption = "Tgl Edit"
    Me.colModified.FieldName = "Main.last_date"
    Me.colModified.Name = "colModified"
    Me.colModified.OptionsColumn.ReadOnly = True
    Me.colModified.Width = 20
    '
    'colModifiedUser
    '
    Me.colModifiedUser.Caption = "User Edit"
    Me.colModifiedUser.FieldName = "Main.last_modified"
    Me.colModifiedUser.Name = "colModifiedUser"
    Me.colModifiedUser.OptionsColumn.ReadOnly = True
    Me.colModifiedUser.Width = 140
    '
    'colNama
    '
    Me.colNama.Caption = "Akun"
    Me.colNama.FieldName = "colNama"
    Me.colNama.Name = "colNama"
    Me.colNama.UnboundExpression = "Concat([Akun.Kode],' | ',[Akun.Nama])"
    Me.colNama.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 7
    '
    'btnFilter
    '
    Me.btnFilter.Caption = "Filter"
    Me.btnFilter.Glyph = CType(resources.GetObject("btnFilter.Glyph"), System.Drawing.Image)
    Me.btnFilter.Id = 24
    Me.btnFilter.LargeGlyph = CType(resources.GetObject("btnFilter.LargeGlyph"), System.Drawing.Image)
    Me.btnFilter.Name = "btnFilter"
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Filter"
    Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
    Me.BarSubItem1.Id = 25
    Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilterCustom), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter2), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter3), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter5), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter6), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter7), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPending, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnVerifikasi)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'btnFilterCustom
    '
    Me.btnFilterCustom.Caption = "Filter Data"
    Me.btnFilterCustom.Glyph = CType(resources.GetObject("btnFilterCustom.Glyph"), System.Drawing.Image)
    Me.btnFilterCustom.Id = 26
    Me.btnFilterCustom.LargeGlyph = CType(resources.GetObject("btnFilterCustom.LargeGlyph"), System.Drawing.Image)
    Me.btnFilterCustom.Name = "btnFilterCustom"
    '
    'btnFilter1
    '
    Me.btnFilter1.Caption = "Transaksi Hari Ini"
    Me.btnFilter1.Id = 27
    Me.btnFilter1.Name = "btnFilter1"
    Me.btnFilter1.Tag = "Hari Ini"
    '
    'btnFilter2
    '
    Me.btnFilter2.Caption = "Transaksi Minggu Ini"
    Me.btnFilter2.Id = 28
    Me.btnFilter2.Name = "btnFilter2"
    Me.btnFilter2.Tag = "Minggu Ini"
    '
    'btnFilter3
    '
    Me.btnFilter3.Caption = "Transaksi Bulan Ini"
    Me.btnFilter3.Id = 29
    Me.btnFilter3.Name = "btnFilter3"
    Me.btnFilter3.Tag = "Bulan Ini"
    '
    'btnFilter4
    '
    Me.btnFilter4.Caption = "Transaksi Bukti Kas"
    Me.btnFilter4.Id = 30
    Me.btnFilter4.Name = "btnFilter4"
    Me.btnFilter4.Tag = "Bukti Kas"
    '
    'btnFilter5
    '
    Me.btnFilter5.Caption = "Transaksi Bukti Bank"
    Me.btnFilter5.Id = 31
    Me.btnFilter5.Name = "btnFilter5"
    Me.btnFilter5.Tag = "Bukti Bank"
    '
    'btnFilter6
    '
    Me.btnFilter6.Caption = "Transaksi Jurnal Memo"
    Me.btnFilter6.Id = 32
    Me.btnFilter6.Name = "btnFilter6"
    Me.btnFilter6.Tag = "Jurnal Memo"
    '
    'btnFilter7
    '
    Me.btnFilter7.Caption = "Transaksi APP"
    Me.btnFilter7.Id = 33
    Me.btnFilter7.Name = "btnFilter7"
    Me.btnFilter7.Tag = "Jurnal APP"
    '
    'btnPending
    '
    Me.btnPending.Caption = "Transaksi Pending"
    Me.btnPending.Id = 34
    Me.btnPending.Name = "btnPending"
    Me.btnPending.Tag = "Transaksi Pending"
    '
    'btnVerifikasi
    '
    Me.btnVerifikasi.Caption = "Transaksi Verifikasi"
    Me.btnVerifikasi.Id = 35
    Me.btnVerifikasi.Name = "btnVerifikasi"
    Me.btnVerifikasi.Tag = "Transaksi Verifikasi"
    '
    'colSubProyek
    '
    Me.colSubProyek.Caption = "Sub Proyek"
    Me.colSubProyek.FieldName = "ProyekSub.Kode"
    Me.colSubProyek.Name = "colSubProyek"
    '
    'colSumber
    '
    Me.colSumber.Caption = "Sumber"
    Me.colSumber.FieldName = "Main.Sumber.Kode"
    Me.colSumber.Name = "colSumber"
    '
    'colStatus
    '
    Me.colStatus.Caption = "Status"
    Me.colStatus.FieldName = "Main.Status"
    Me.colStatus.Name = "colStatus"
    Me.colStatus.Visible = True
    Me.colStatus.VisibleIndex = 7
    '
    'xMesitechDaftarGL
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(894, 412)
    Me.Name = "xMesitechDaftarGL"
    Me.Text = "Data Transaksi [GL]"
    Me.xpCol = Me.xpCol
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerControl1.ResumeLayout(False)
    CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarCheckItem
  Friend WithEvents cmdTampilkan As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkunKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebitValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKreditValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDivisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colProyekKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colProyekNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colRegional As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCreated As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCreatedUser As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colModified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnFilter As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnFilterCustom As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnFilter1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colSubProyek As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSumber As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnFilter2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnFilter3 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnFilter4 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnFilter5 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnFilter6 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnFilter7 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnPending As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnVerifikasi As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
