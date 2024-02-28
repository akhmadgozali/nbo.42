<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xMesitechGL
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
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xMesitechGL))
    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
    Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colRegional = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetakVoucher = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.btnFilterData = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilterHariIni = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilterMingguIni = New DevExpress.XtraBars.BarButtonItem()
    Me.btnFilterBulanIni = New DevExpress.XtraBars.BarButtonItem()
    Me.cmdCetakBuktiKas = New DevExpress.XtraBars.BarSubItem()
    Me.btnKasKeluar = New DevExpress.XtraBars.BarButtonItem()
    Me.btnKasMasuk = New DevExpress.XtraBars.BarButtonItem()
    Me.cmdCetakBuktiBank = New DevExpress.XtraBars.BarSubItem()
    Me.btnBankKeluar = New DevExpress.XtraBars.BarButtonItem()
    Me.btnBankMasuk = New DevExpress.XtraBars.BarButtonItem()
    Me.cmdCetakBuktiAPP = New DevExpress.XtraBars.BarSubItem()
    Me.btnBuktiAPP = New DevExpress.XtraBars.BarButtonItem()
    Me.btnBuktiAPP2 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnJurnalMemo = New DevExpress.XtraBars.BarButtonItem()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.Size = New System.Drawing.Size(765, 375)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout, Me.btnCetakVoucher, Me.BarButtonItem1, Me.BarSubItem1, Me.btnFilterHariIni, Me.btnFilterMingguIni, Me.btnFilterBulanIni, Me.cmdCetakBuktiKas, Me.btnKasKeluar, Me.btnKasMasuk, Me.cmdCetakBuktiBank, Me.cmdCetakBuktiAPP, Me.btnBankKeluar, Me.btnBankMasuk, Me.btnBuktiAPP, Me.btnBuktiAPP2, Me.btnJurnalMemo, Me.btnFilterData})
    Me.barMan.MaxItemId = 31
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colNoBukti, Me.colTanggal, Me.colKontakNama, Me.colKeterangan, Me.colRegional, Me.GridColumn1, Me.GridColumn2, Me.colDebit, Me.colKredit, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
    StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Silver
    StyleFormatCondition1.Appearance.Options.UseBackColor = True
    StyleFormatCondition1.ApplyToRow = True
    StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
    StyleFormatCondition1.Value1 = CType(2, Short)
    Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
    Me.xGridView.GroupCount = 3
    Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRegional, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.xMesitechGlDetail)
    '
    'toolTip
    '
    Me.toolTip.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdCetakBuktiKas, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdCetakBuktiBank), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdCetakBuktiAPP), New DevExpress.XtraBars.LinkPersistInfo(Me.btnJurnalMemo)})
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colId
    '
    Me.colId.FieldName = "Main.Id"
    Me.colId.Name = "colId"
    '
    'colTahun
    '
    Me.colTahun.FieldName = "Main.Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 0
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
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 0
    '
    'colNoBukti
    '
    Me.colNoBukti.Caption = "No. Transaksi"
    Me.colNoBukti.FieldName = "Main.Kode"
    Me.colNoBukti.Name = "colNoBukti"
    Me.colNoBukti.Visible = True
    Me.colNoBukti.VisibleIndex = 0
    Me.colNoBukti.Width = 135
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colTanggal.FieldName = "Main.Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    Me.colTanggal.Width = 90
    '
    'colKontakNama
    '
    Me.colKontakNama.Caption = "Kontak"
    Me.colKontakNama.FieldName = "Main.Kontak.Nama"
    Me.colKontakNama.Name = "colKontakNama"
    Me.colKontakNama.Visible = True
    Me.colKontakNama.VisibleIndex = 2
    Me.colKontakNama.Width = 127
    '
    'colKeterangan
    '
    Me.colKeterangan.Caption = "Uraian"
    Me.colKeterangan.FieldName = "Main.Uraian"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 3
    Me.colKeterangan.Width = 218
    '
    'colRegional
    '
    Me.colRegional.Caption = "Regional"
    Me.colRegional.FieldName = "Main.Regional.Nama"
    Me.colRegional.Name = "colRegional"
    Me.colRegional.Visible = True
    Me.colRegional.VisibleIndex = 5
    '
    'btnSaveLayout
    '
    Me.btnSaveLayout.Caption = "Save Layout"
    Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
    Me.btnSaveLayout.Id = 13
    Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btnSaveLayout.Name = "btnSaveLayout"
    '
    'btnCetakVoucher
    '
    Me.btnCetakVoucher.Caption = "Cetak Voucher"
    Me.btnCetakVoucher.Glyph = CType(resources.GetObject("btnCetakVoucher.Glyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Id = 14
    Me.btnCetakVoucher.LargeGlyph = CType(resources.GetObject("btnCetakVoucher.LargeGlyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Name = "btnCetakVoucher"
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "BarButtonItem1"
    Me.BarButtonItem1.Id = 15
    Me.BarButtonItem1.Name = "BarButtonItem1"
    ToolTipTitleItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
    ToolTipTitleItem1.Appearance.Options.UseImage = True
    ToolTipTitleItem1.Image = CType(resources.GetObject("ToolTipTitleItem1.Image"), System.Drawing.Image)
    ToolTipTitleItem1.Text = "Voucher : PRM-DD-KK14040007"
    ToolTipItem1.LeftIndent = 6
    ToolTipItem1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "11000800  Uang Muka Pembelian Tiket (Deposit)" & Global.Microsoft.VisualBasic.ChrW(9) & "5.000.000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10010102  Kas Kecil (I" & _
    "DR) DD" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "5.000.000"
    SuperToolTip1.Items.Add(ToolTipTitleItem1)
    SuperToolTip1.Items.Add(ToolTipItem1)
    Me.BarButtonItem1.SuperTip = SuperToolTip1
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Quick Filter"
    Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
    Me.BarSubItem1.Id = 16
    Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilterData), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilterHariIni, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilterMingguIni), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilterBulanIni)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'btnFilterData
    '
    Me.btnFilterData.Caption = "Filter Data"
    Me.btnFilterData.Glyph = CType(resources.GetObject("btnFilterData.Glyph"), System.Drawing.Image)
    Me.btnFilterData.Id = 30
    Me.btnFilterData.LargeGlyph = CType(resources.GetObject("btnFilterData.LargeGlyph"), System.Drawing.Image)
    Me.btnFilterData.Name = "btnFilterData"
    '
    'btnFilterHariIni
    '
    Me.btnFilterHariIni.Caption = "Transaksi Hari Ini"
    Me.btnFilterHariIni.Id = 17
    Me.btnFilterHariIni.Name = "btnFilterHariIni"
    '
    'btnFilterMingguIni
    '
    Me.btnFilterMingguIni.Caption = "Transaksi Minggu Ini"
    Me.btnFilterMingguIni.Id = 18
    Me.btnFilterMingguIni.Name = "btnFilterMingguIni"
    '
    'btnFilterBulanIni
    '
    Me.btnFilterBulanIni.Caption = "Transaksi Bulan Ini"
    Me.btnFilterBulanIni.Id = 19
    Me.btnFilterBulanIni.Name = "btnFilterBulanIni"
    '
    'cmdCetakBuktiKas
    '
    Me.cmdCetakBuktiKas.Caption = "Cetak Bukti Kas"
    Me.cmdCetakBuktiKas.Id = 20
    Me.cmdCetakBuktiKas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnKasKeluar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnKasMasuk)})
    Me.cmdCetakBuktiKas.Name = "cmdCetakBuktiKas"
    Me.cmdCetakBuktiKas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'btnKasKeluar
    '
    Me.btnKasKeluar.Caption = "Kas Keluar"
    Me.btnKasKeluar.Id = 21
    Me.btnKasKeluar.Name = "btnKasKeluar"
    Me.btnKasKeluar.Tag = "KasKeluar"
    '
    'btnKasMasuk
    '
    Me.btnKasMasuk.Caption = "Kas Masuk"
    Me.btnKasMasuk.Id = 22
    Me.btnKasMasuk.Name = "btnKasMasuk"
    Me.btnKasMasuk.Tag = "KasMasuk"
    '
    'cmdCetakBuktiBank
    '
    Me.cmdCetakBuktiBank.Caption = "Cetak Bukti Bank"
    Me.cmdCetakBuktiBank.Id = 23
    Me.cmdCetakBuktiBank.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnBankKeluar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBankMasuk)})
    Me.cmdCetakBuktiBank.Name = "cmdCetakBuktiBank"
    Me.cmdCetakBuktiBank.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'btnBankKeluar
    '
    Me.btnBankKeluar.Caption = "Bank Keluar"
    Me.btnBankKeluar.Id = 25
    Me.btnBankKeluar.Name = "btnBankKeluar"
    Me.btnBankKeluar.Tag = "BankKeluar"
    '
    'btnBankMasuk
    '
    Me.btnBankMasuk.Caption = "Bank Masuk"
    Me.btnBankMasuk.Id = 26
    Me.btnBankMasuk.Name = "btnBankMasuk"
    Me.btnBankMasuk.Tag = "BankMasuk"
    '
    'cmdCetakBuktiAPP
    '
    Me.cmdCetakBuktiAPP.Caption = "Cetak Bukti APP"
    Me.cmdCetakBuktiAPP.Id = 24
    Me.cmdCetakBuktiAPP.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnBuktiAPP), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBuktiAPP2)})
    Me.cmdCetakBuktiAPP.Name = "cmdCetakBuktiAPP"
    Me.cmdCetakBuktiAPP.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'btnBuktiAPP
    '
    Me.btnBuktiAPP.Caption = "Voucher APP"
    Me.btnBuktiAPP.Id = 27
    Me.btnBuktiAPP.Name = "btnBuktiAPP"
    Me.btnBuktiAPP.Tag = "BuktiAPP"
    '
    'btnBuktiAPP2
    '
    Me.btnBuktiAPP2.Caption = "Voucher APP Dropping"
    Me.btnBuktiAPP2.Id = 28
    Me.btnBuktiAPP2.Name = "btnBuktiAPP2"
    Me.btnBuktiAPP2.Tag = "BuktiAPPDropship"
    '
    'btnJurnalMemo
    '
    Me.btnJurnalMemo.Caption = "Cetak Jurnal Memo"
    Me.btnJurnalMemo.Id = 29
    Me.btnJurnalMemo.Name = "btnJurnalMemo"
    Me.btnJurnalMemo.Tag = "JurnalMemo"
    Me.btnJurnalMemo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode COA"
    Me.GridColumn1.FieldName = "Akun.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 4
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama COA"
    Me.GridColumn2.FieldName = "Akun.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 5
    '
    'colDebit
    '
    Me.colDebit.Caption = "Debit"
    Me.colDebit.FieldName = "Debit"
    Me.colDebit.Name = "colDebit"
    Me.colDebit.Visible = True
    Me.colDebit.VisibleIndex = 6
    '
    'colKredit
    '
    Me.colKredit.Caption = "Kredit"
    Me.colKredit.FieldName = "Kredit"
    Me.colKredit.Name = "colKredit"
    Me.colKredit.Visible = True
    Me.colKredit.VisibleIndex = 7
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Divisi"
    Me.GridColumn3.FieldName = "Divisi.Kode"
    Me.GridColumn3.Name = "GridColumn3"
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Kode Proyek"
    Me.GridColumn4.FieldName = "Proyek.Kode"
    Me.GridColumn4.Name = "GridColumn4"
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Nama Proyek"
    Me.GridColumn5.FieldName = "Proyek.Nama"
    Me.GridColumn5.Name = "GridColumn5"
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Kode Sub Proyek"
    Me.GridColumn6.FieldName = "ProyekSub.Kode"
    Me.GridColumn6.Name = "GridColumn6"
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Nama Sub Proyek"
    Me.GridColumn7.FieldName = "ProyekSub.Nama"
    Me.GridColumn7.Name = "GridColumn7"
    '
    'xMesitechGL
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 402)
    Me.Name = "xMesitechGL"
    Me.Text = "Transaksi GL"
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
  Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colRegional As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetakVoucher As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnFilterHariIni As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnFilterMingguIni As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnFilterBulanIni As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents cmdCetakBuktiKas As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnKasKeluar As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnKasMasuk As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents cmdCetakBuktiBank As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnBankKeluar As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnBankMasuk As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents cmdCetakBuktiAPP As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnBuktiAPP As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnBuktiAPP2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnJurnalMemo As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnFilterData As DevExpress.XtraBars.BarButtonItem
End Class