<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Aktiva
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Aktiva))
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
    Me.colDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnResetUlang = New DevExpress.XtraBars.BarButtonItem()
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
    Me.xGrid.Size = New System.Drawing.Size(765, 374)
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft008.Persistent.AktivaTetap)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout, Me.btnResetUlang})
    Me.barMan.MaxItemId = 15
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKelompok, Me.colKode, Me.colNama, Me.colQty, Me.colTanggalBeli, Me.colTanggalPakai, Me.colHarga, Me.colNilaiResidu, Me.colNilaiAmortisasi, Me.colNilaiBuku, Me.colDivisi, Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colQtyOut})
    Me.xGridView.GroupCount = 1
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKelompok, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnResetUlang, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    '
    'barMenu
    '
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
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colKode
    '
    Me.colKode.Caption = "Kode"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    '
    'colQty
    '
    Me.colQty.Caption = "Qty"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 2
    '
    'colTanggalBeli
    '
    Me.colTanggalBeli.Caption = "Tgl Beli"
    Me.colTanggalBeli.FieldName = "TanggalBeli"
    Me.colTanggalBeli.Name = "colTanggalBeli"
    Me.colTanggalBeli.Visible = True
    Me.colTanggalBeli.VisibleIndex = 3
    '
    'colTanggalPakai
    '
    Me.colTanggalPakai.Caption = "Tgl Pakai"
    Me.colTanggalPakai.FieldName = "TanggalPakai"
    Me.colTanggalPakai.Name = "colTanggalPakai"
    Me.colTanggalPakai.Visible = True
    Me.colTanggalPakai.VisibleIndex = 4
    '
    'colHarga
    '
    Me.colHarga.Caption = "Harga Beli"
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    Me.colHarga.Visible = True
    Me.colHarga.VisibleIndex = 5
    '
    'colNilaiResidu
    '
    Me.colNilaiResidu.Caption = "Nilai Residu"
    Me.colNilaiResidu.FieldName = "NilaiResidu"
    Me.colNilaiResidu.Name = "colNilaiResidu"
    Me.colNilaiResidu.Visible = True
    Me.colNilaiResidu.VisibleIndex = 6
    '
    'colNilaiAmortisasi
    '
    Me.colNilaiAmortisasi.Caption = "Nilai Amortisasi"
    Me.colNilaiAmortisasi.FieldName = "NilaiAmortisasi"
    Me.colNilaiAmortisasi.Name = "colNilaiAmortisasi"
    Me.colNilaiAmortisasi.Visible = True
    Me.colNilaiAmortisasi.VisibleIndex = 7
    '
    'colNilaiBuku
    '
    Me.colNilaiBuku.Caption = "Nilai Buku"
    Me.colNilaiBuku.FieldName = "NilaiBuku"
    Me.colNilaiBuku.Name = "colNilaiBuku"
    Me.colNilaiBuku.Visible = True
    Me.colNilaiBuku.VisibleIndex = 8
    '
    'colKelompok
    '
    Me.colKelompok.Caption = "Kelompok"
    Me.colKelompok.FieldName = "Kelompok.Kode"
    Me.colKelompok.Name = "colKelompok"
    Me.colKelompok.Visible = True
    Me.colKelompok.VisibleIndex = 9
    '
    'colDivisi
    '
    Me.colDivisi.Caption = "Divisi"
    Me.colDivisi.FieldName = "Kode"
    Me.colDivisi.Name = "colDivisi"
    '
    'colcreated_date
    '
    Me.colcreated_date.Caption = "Tanggal Create"
    Me.colcreated_date.FieldName = "created_date"
    Me.colcreated_date.Name = "colcreated_date"
    '
    'colcreated_user
    '
    Me.colcreated_user.Caption = "User Create"
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
    'colQtyOut
    '
    Me.colQtyOut.Caption = "Qty Out"
    Me.colQtyOut.FieldName = "QtyOut"
    Me.colQtyOut.Name = "colQtyOut"
    '
    'btnResetUlang
    '
    Me.btnResetUlang.Caption = "Reset Ulang Tabel Penyusutan"
    Me.btnResetUlang.Id = 14
    Me.btnResetUlang.Name = "btnResetUlang"
    '
    'UI_Aktiva
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 401)
    Me.Name = "UI_Aktiva"
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
  Friend WithEvents colDivisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnResetUlang As DevExpress.XtraBars.BarButtonItem
End Class
