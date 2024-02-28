<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_AktivaTetap
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_AktivaTetap))
		Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggalBeli = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggalPakai = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNilaiResidu = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNilaiAmortisasi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNilaiBuku = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKelompok = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnPembelian = New DevExpress.XtraBars.BarButtonItem()
		Me.btnPenyusutan = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSaldoAwal = New DevExpress.XtraBars.BarButtonItem()
		Me.btnHistory = New DevExpress.XtraBars.BarButtonItem()
		Me.btnPenjualan = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnWriteOff = New DevExpress.XtraBars.BarButtonItem()
		Me.btnTransaksiAktiva = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnResetNilaiAktiva = New DevExpress.XtraBars.BarButtonItem()
		Me.btnHapusAktiva = New DevExpress.XtraBars.BarButtonItem()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.xGrid.DataSource = Me.xpCol
		Me.xGrid.Size = New System.Drawing.Size(1023, 598)
		'
		'xpCol
		'
		Me.xpCol.DisplayableProperties = resources.GetString("xpCol.DisplayableProperties")
		Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.viewAktivaTetap)
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout, Me.btnPembelian, Me.btnPenyusutan, Me.btnSaldoAwal, Me.btnHistory, Me.btnPenjualan, Me.BarButtonItem2, Me.btnWriteOff, Me.btnTransaksiAktiva, Me.BarButtonItem1, Me.btnResetNilaiAktiva, Me.btnHapusAktiva})
		Me.barMan.MaxItemId = 25
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKelompok, Me.colKode, Me.colNama, Me.colQty, Me.colTanggalBeli, Me.colTanggalPakai, Me.colHarga, Me.colNilaiResidu, Me.colNilaiAmortisasi, Me.colNilaiBuku, Me.GridColumn1})
		Me.xGridView.GroupCount = 2
		Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "d_price", Nothing, " - Nilai : {0:n2}")})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKelompok, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'popMenu
		'
		Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnHistory, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnResetNilaiAktiva), New DevExpress.XtraBars.LinkPersistInfo(Me.btnHapusAktiva)})
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPembelian, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPenyusutan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPenjualan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnWriteOff, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSaldoAwal, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'btnSaveLayout
		'
		Me.btnSaveLayout.Caption = "Save Layout"
		Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
		Me.btnSaveLayout.Id = 13
		Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
		Me.btnSaveLayout.Name = "btnSaveLayout"
		'
		'colId
		'
		Me.colId.Caption = "Id"
		Me.colId.FieldName = "p_Id"
		Me.colId.Name = "colId"
		'
		'colKode
		'
		Me.colKode.Caption = "Kode"
		Me.colKode.FieldName = "f_asset.Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 0
		'
		'colNama
		'
		Me.colNama.Caption = "Nama"
		Me.colNama.FieldName = "f_asset.Nama"
		Me.colNama.Name = "colNama"
		Me.colNama.Visible = True
		Me.colNama.VisibleIndex = 1
		'
		'colQty
		'
		Me.colQty.Caption = "Qty"
		Me.colQty.FieldName = "f_asset.Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 2
		'
		'colTanggalBeli
		'
		Me.colTanggalBeli.Caption = "Tgl Beli"
		Me.colTanggalBeli.FieldName = "f_asset.TanggalBeli"
		Me.colTanggalBeli.Name = "colTanggalBeli"
		Me.colTanggalBeli.Visible = True
		Me.colTanggalBeli.VisibleIndex = 3
		'
		'colTanggalPakai
		'
		Me.colTanggalPakai.Caption = "Tgl Pakai"
		Me.colTanggalPakai.FieldName = "f_asset.TanggalPakai"
		Me.colTanggalPakai.Name = "colTanggalPakai"
		Me.colTanggalPakai.Visible = True
		Me.colTanggalPakai.VisibleIndex = 4
		'
		'colHarga
		'
		Me.colHarga.Caption = "Harga Beli"
		Me.colHarga.FieldName = "d_price"
		Me.colHarga.GroupFormat.FormatString = "n"
		Me.colHarga.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga.Name = "colHarga"
		Me.colHarga.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colHarga.Visible = True
		Me.colHarga.VisibleIndex = 5
		'
		'colNilaiResidu
		'
		Me.colNilaiResidu.Caption = "Nilai Residu"
		Me.colNilaiResidu.FieldName = "d_residuvalue"
		Me.colNilaiResidu.Name = "colNilaiResidu"
		Me.colNilaiResidu.Visible = True
		Me.colNilaiResidu.VisibleIndex = 6
		'
		'colNilaiAmortisasi
		'
		Me.colNilaiAmortisasi.Caption = "Nilai Amortisasi"
		Me.colNilaiAmortisasi.FieldName = "d_amortization"
		Me.colNilaiAmortisasi.Name = "colNilaiAmortisasi"
		Me.colNilaiAmortisasi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colNilaiAmortisasi.Visible = True
		Me.colNilaiAmortisasi.VisibleIndex = 7
		'
		'colNilaiBuku
		'
		Me.colNilaiBuku.Caption = "Nilai Buku"
		Me.colNilaiBuku.FieldName = "d_bookvalue"
		Me.colNilaiBuku.Name = "colNilaiBuku"
		Me.colNilaiBuku.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colNilaiBuku.Visible = True
		Me.colNilaiBuku.VisibleIndex = 8
		'
		'colKelompok
		'
		Me.colKelompok.Caption = "Kelompok"
		Me.colKelompok.FieldName = "f_asset.Kelompok.Kode"
		Me.colKelompok.GroupFormat.FormatString = "n"
		Me.colKelompok.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colKelompok.Name = "colKelompok"
		Me.colKelompok.Visible = True
		Me.colKelompok.VisibleIndex = 9
		'
		'btnPembelian
		'
		Me.btnPembelian.Caption = "Pembelian"
		Me.btnPembelian.Glyph = CType(resources.GetObject("btnPembelian.Glyph"), System.Drawing.Image)
		Me.btnPembelian.Id = 14
		Me.btnPembelian.LargeGlyph = CType(resources.GetObject("btnPembelian.LargeGlyph"), System.Drawing.Image)
		Me.btnPembelian.Name = "btnPembelian"
		'
		'btnPenyusutan
		'
		Me.btnPenyusutan.Caption = "Penyusutan"
		Me.btnPenyusutan.Glyph = CType(resources.GetObject("btnPenyusutan.Glyph"), System.Drawing.Image)
		Me.btnPenyusutan.Id = 15
		Me.btnPenyusutan.LargeGlyph = CType(resources.GetObject("btnPenyusutan.LargeGlyph"), System.Drawing.Image)
		Me.btnPenyusutan.Name = "btnPenyusutan"
		'
		'btnSaldoAwal
		'
		Me.btnSaldoAwal.Caption = "Saldo Awal"
		Me.btnSaldoAwal.Glyph = CType(resources.GetObject("btnSaldoAwal.Glyph"), System.Drawing.Image)
		Me.btnSaldoAwal.Id = 16
		Me.btnSaldoAwal.LargeGlyph = CType(resources.GetObject("btnSaldoAwal.LargeGlyph"), System.Drawing.Image)
		Me.btnSaldoAwal.Name = "btnSaldoAwal"
		'
		'btnHistory
		'
		Me.btnHistory.Caption = "History"
		Me.btnHistory.Glyph = CType(resources.GetObject("btnHistory.Glyph"), System.Drawing.Image)
		Me.btnHistory.Id = 17
		Me.btnHistory.Name = "btnHistory"
		'
		'btnPenjualan
		'
		Me.btnPenjualan.Caption = "Penjualan"
		Me.btnPenjualan.Glyph = CType(resources.GetObject("btnPenjualan.Glyph"), System.Drawing.Image)
		Me.btnPenjualan.Id = 18
		Me.btnPenjualan.LargeGlyph = CType(resources.GetObject("btnPenjualan.LargeGlyph"), System.Drawing.Image)
		Me.btnPenjualan.Name = "btnPenjualan"
		'
		'BarButtonItem2
		'
		Me.BarButtonItem2.Caption = "BarButtonItem2"
		Me.BarButtonItem2.Id = 19
		Me.BarButtonItem2.Name = "BarButtonItem2"
		'
		'btnWriteOff
		'
		Me.btnWriteOff.Caption = "Write Off"
		Me.btnWriteOff.Glyph = CType(resources.GetObject("btnWriteOff.Glyph"), System.Drawing.Image)
		Me.btnWriteOff.Id = 20
		Me.btnWriteOff.LargeGlyph = CType(resources.GetObject("btnWriteOff.LargeGlyph"), System.Drawing.Image)
		Me.btnWriteOff.Name = "btnWriteOff"
		'
		'btnTransaksiAktiva
		'
		Me.btnTransaksiAktiva.Caption = "Transaksi Aktiva Tetap"
		Me.btnTransaksiAktiva.Glyph = CType(resources.GetObject("btnTransaksiAktiva.Glyph"), System.Drawing.Image)
		Me.btnTransaksiAktiva.Id = 21
		Me.btnTransaksiAktiva.LargeGlyph = CType(resources.GetObject("btnTransaksiAktiva.LargeGlyph"), System.Drawing.Image)
		Me.btnTransaksiAktiva.Name = "btnTransaksiAktiva"
		'
		'BarButtonItem1
		'
		Me.BarButtonItem1.Caption = "BarButtonItem1"
		Me.BarButtonItem1.Id = 22
		Me.BarButtonItem1.Name = "BarButtonItem1"
		'
		'btnResetNilaiAktiva
		'
		Me.btnResetNilaiAktiva.Caption = "Reset Nilai Aktiva"
		Me.btnResetNilaiAktiva.Glyph = CType(resources.GetObject("btnResetNilaiAktiva.Glyph"), System.Drawing.Image)
		Me.btnResetNilaiAktiva.Id = 23
		Me.btnResetNilaiAktiva.LargeGlyph = CType(resources.GetObject("btnResetNilaiAktiva.LargeGlyph"), System.Drawing.Image)
		Me.btnResetNilaiAktiva.Name = "btnResetNilaiAktiva"
		'
		'btnHapusAktiva
		'
		Me.btnHapusAktiva.Caption = "Hapus Transaksi Aktiva"
		Me.btnHapusAktiva.Glyph = CType(resources.GetObject("btnHapusAktiva.Glyph"), System.Drawing.Image)
		Me.btnHapusAktiva.Id = 24
		Me.btnHapusAktiva.LargeGlyph = CType(resources.GetObject("btnHapusAktiva.LargeGlyph"), System.Drawing.Image)
		Me.btnHapusAktiva.Name = "btnHapusAktiva"
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Reg"
		Me.GridColumn1.FieldName = "f_asset.Regional.Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 10
		'
		'UI_AktivaTetap
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1023, 625)
		Me.Name = "UI_AktivaTetap"
		Me.Text = "Daftar Aktiva Tetap"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKelompok As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalBeli As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalPakai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiResidu As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiAmortisasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiBuku As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnPembelian As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnPenyusutan As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSaldoAwal As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnHistory As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnPenjualan As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnWriteOff As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnTransaksiAktiva As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnResetNilaiAktiva As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnHapusAktiva As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
