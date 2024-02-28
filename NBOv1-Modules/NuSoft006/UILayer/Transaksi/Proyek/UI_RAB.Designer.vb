<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_RAB
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_RAB))
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUnposting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUpdateStatus = New DevExpress.XtraBars.BarSubItem()
    Me.zBtnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.zBtnUnposting = New DevExpress.XtraBars.BarButtonItem()
    Me.zBtnClosing = New DevExpress.XtraBars.BarButtonItem()
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
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.btnPosting, Me.btnUnposting, Me.btnClosing, Me.btnUpdateStatus, Me.zBtnPosting, Me.zBtnUnposting, Me.zBtnClosing})
    Me.barMan.MaxItemId = 21
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.colCustomer, Me.colUraian, Me.colStatusTransaksi})
    Me.xGridView.GroupCount = 2
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = "created_date;created_user;last_date;last_modified;Id;Tahun;Bulan;Urutan;Kode;Tang" & _
    "gal;Sumber.Kode;Regional.Kode;Regional.Nama;Pelanggan.Kode;Pelanggan.Nama;Uraian" & _
    ";StatusTransaksi;TotalQty;SubTotal"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.RAB)
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUpdateStatus, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colTahun
    '
    Me.colTahun.Caption = "Tahun"
    Me.colTahun.FieldName = "Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 0
    '
    'colBulan
    '
    Me.colBulan.Caption = "Bulan"
    Me.colBulan.FieldName = "Bulan"
    Me.colBulan.Name = "colBulan"
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 0
    '
    'colKode
    '
    Me.colKode.Caption = "No Bukti"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'colStatusTransaksi
    '
    Me.colStatusTransaksi.Caption = "Status"
    Me.colStatusTransaksi.FieldName = "StatusTransaksi"
    Me.colStatusTransaksi.Name = "colStatusTransaksi"
    Me.colStatusTransaksi.Visible = True
    Me.colStatusTransaksi.VisibleIndex = 3
    '
    'colCustomer
    '
    Me.colCustomer.Caption = "Customer"
    Me.colCustomer.FieldName = "Pelanggan.Kode"
    Me.colCustomer.Name = "colCustomer"
    Me.colCustomer.Visible = True
    Me.colCustomer.VisibleIndex = 2
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 4
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Update Status"
    Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
    Me.BarSubItem1.Id = 13
    Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPosting), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUnposting), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClosing, True)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'btnPosting
    '
    Me.btnPosting.Caption = "Posting Transaksi"
    Me.btnPosting.Glyph = CType(resources.GetObject("btnPosting.Glyph"), System.Drawing.Image)
    Me.btnPosting.Id = 14
    Me.btnPosting.LargeGlyph = CType(resources.GetObject("btnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnPosting.Name = "btnPosting"
    '
    'btnUnposting
    '
    Me.btnUnposting.Caption = "UnPosting Transaksi"
    Me.btnUnposting.Glyph = CType(resources.GetObject("btnUnposting.Glyph"), System.Drawing.Image)
    Me.btnUnposting.Id = 15
    Me.btnUnposting.LargeGlyph = CType(resources.GetObject("btnUnposting.LargeGlyph"), System.Drawing.Image)
    Me.btnUnposting.Name = "btnUnposting"
    '
    'btnClosing
    '
    Me.btnClosing.Caption = "Closing Transaksi"
    Me.btnClosing.Id = 16
    Me.btnClosing.Name = "btnClosing"
    '
    'btnUpdateStatus
    '
    Me.btnUpdateStatus.Caption = "Update Status"
    Me.btnUpdateStatus.Glyph = CType(resources.GetObject("btnUpdateStatus.Glyph"), System.Drawing.Image)
    Me.btnUpdateStatus.Id = 17
    Me.btnUpdateStatus.LargeGlyph = CType(resources.GetObject("btnUpdateStatus.LargeGlyph"), System.Drawing.Image)
    Me.btnUpdateStatus.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.zBtnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.zBtnUnposting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.zBtnClosing, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.btnUpdateStatus.Name = "btnUpdateStatus"
    '
    'zBtnPosting
    '
    Me.zBtnPosting.Caption = "Posting Transaksi"
    Me.zBtnPosting.Glyph = CType(resources.GetObject("zBtnPosting.Glyph"), System.Drawing.Image)
    Me.zBtnPosting.Id = 18
    Me.zBtnPosting.LargeGlyph = CType(resources.GetObject("zBtnPosting.LargeGlyph"), System.Drawing.Image)
    Me.zBtnPosting.Name = "zBtnPosting"
    Me.zBtnPosting.Tag = "memposting"
    '
    'zBtnUnposting
    '
    Me.zBtnUnposting.Caption = "UnPosting Transaksi"
    Me.zBtnUnposting.Glyph = CType(resources.GetObject("zBtnUnposting.Glyph"), System.Drawing.Image)
    Me.zBtnUnposting.Id = 19
    Me.zBtnUnposting.LargeGlyph = CType(resources.GetObject("zBtnUnposting.LargeGlyph"), System.Drawing.Image)
    Me.zBtnUnposting.Name = "zBtnUnposting"
    Me.zBtnUnposting.Tag = "mengunposting"
    '
    'zBtnClosing
    '
    Me.zBtnClosing.Caption = "Closing Transaksi"
    Me.zBtnClosing.Id = 20
    Me.zBtnClosing.Name = "zBtnClosing"
    Me.zBtnClosing.Tag = "mengclosing"
    '
    'UI_RAB
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_RAB"
    Me.Text = "RAB"
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
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUnposting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUpdateStatus As DevExpress.XtraBars.BarSubItem
  Friend WithEvents zBtnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents zBtnUnposting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents zBtnClosing As DevExpress.XtraBars.BarButtonItem
End Class
