<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_DaftarGL
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_DaftarGL))
    Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarCheckItem()
    Me.cmdTampilkan = New DevExpress.XtraBars.BarButtonItem()
    Me.colDebitValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKreditValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout, Me.cmdTampilkan})
    Me.barMan.MaxItemId = 24
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.GlMainDetail)
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSaveLayout, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    '
    'xGrid
    '
    Me.xGrid.Size = New System.Drawing.Size(894, 212)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoBukti, Me.colTanggal, Me.colKontak, Me.colDebit, Me.colKredit, Me.colKeterangan, Me.colTahun, Me.colBulan, Me.colAkun, Me.colDebitValas, Me.colKreditValas, Me.colKurs})
    Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(739, 182, 210, 179)
    Me.xGridView.GroupCount = 3
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAkun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdTampilkan, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'SplitContainerControl1
    '
    Me.SplitContainerControl1.Size = New System.Drawing.Size(894, 385)
    '
    'colDebit
    '
    Me.colDebit.FieldName = "Debit"
    Me.colDebit.Name = "colDebit"
    Me.colDebit.Visible = True
    Me.colDebit.VisibleIndex = 3
    Me.colDebit.Width = 83
    '
    'colKredit
    '
    Me.colKredit.FieldName = "Kredit"
    Me.colKredit.Name = "colKredit"
    Me.colKredit.Visible = True
    Me.colKredit.VisibleIndex = 4
    '
    'colKeterangan
    '
    Me.colKeterangan.Caption = "Keterangan"
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 5
    '
    'colTahun
    '
    Me.colTahun.Caption = "Tahun"
    Me.colTahun.FieldName = "Main.Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 1
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
    Me.colBulan.VisibleIndex = 1
    '
    'colAkun
    '
    Me.colAkun.Caption = "Akun"
    Me.colAkun.FieldName = "colAkun"
    Me.colAkun.Name = "colAkun"
    Me.colAkun.UnboundExpression = "Concat([Akun.Kode],' | ', [Akun.Nama])"
    Me.colAkun.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.colAkun.Visible = True
    Me.colAkun.VisibleIndex = 1
    '
    'colNoBukti
    '
    Me.colNoBukti.Caption = "No. Bukti"
    Me.colNoBukti.FieldName = "Main.Kode"
    Me.colNoBukti.Name = "colNoBukti"
    Me.colNoBukti.Visible = True
    Me.colNoBukti.VisibleIndex = 0
    Me.colNoBukti.Width = 83
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.DisplayFormat.FormatString = "D"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggal.FieldName = "Main.Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'colKontak
    '
    Me.colKontak.Caption = "Kontak"
    Me.colKontak.FieldName = "Main.Kontak.Nama"
    Me.colKontak.Name = "colKontak"
    Me.colKontak.Visible = True
    Me.colKontak.VisibleIndex = 2
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
    'colDebitValas
    '
    Me.colDebitValas.Caption = "Debit Valas"
    Me.colDebitValas.FieldName = "DebitValas"
    Me.colDebitValas.Name = "colDebitValas"
    '
    'colKreditValas
    '
    Me.colKreditValas.Caption = "Kredit Valas"
    Me.colKreditValas.FieldName = "KreditValas"
    Me.colKreditValas.Name = "colKreditValas"
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs"
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    '
    'UI_DaftarGL
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(894, 412)
    Me.Name = "UI_DaftarGL"
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
  Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarCheckItem
  Friend WithEvents cmdTampilkan As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colDebitValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKreditValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
End Class
