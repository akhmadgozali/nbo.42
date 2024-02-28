<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_zMustofaPOS
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_POS))
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUpdateStatus = New DevExpress.XtraBars.BarButtonItem()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.colPOSTotalTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.Size = New System.Drawing.Size(765, 374)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.btnUpdateStatus, Me.BarSubItem1, Me.btnPosting, Me.btnUnPosting})
    Me.barMan.MaxItemId = 18
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.colStatusTransaksi, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.colUraian, Me.colPOSTotalTransaksi})
    Me.xGridView.GroupCount = 2
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPOSTotalTransaksi, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.PengirimanBarang)
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
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
    Me.colId.Caption = "ID"
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
    Me.colKode.Width = 83
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    Me.colTanggal.Width = 62
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Regional"
    Me.GridColumn3.FieldName = "Regional.Nama"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.OptionsColumn.ReadOnly = True
    Me.GridColumn3.Width = 57
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Kode Gudang"
    Me.GridColumn4.FieldName = "Gudang.Kode"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.OptionsColumn.ReadOnly = True
    Me.GridColumn4.Width = 57
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Nama Gudang"
    Me.GridColumn5.FieldName = "Gudang.Nama"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.OptionsColumn.ReadOnly = True
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    Me.GridColumn5.Width = 57
    '
    'colStatusTransaksi
    '
    Me.colStatusTransaksi.Caption = "Status"
    Me.colStatusTransaksi.FieldName = "StatusTransaksi"
    Me.colStatusTransaksi.Name = "colStatusTransaksi"
    Me.colStatusTransaksi.Visible = True
    Me.colStatusTransaksi.VisibleIndex = 5
    Me.colStatusTransaksi.Width = 57
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "No Bukti GL"
    Me.GridColumn6.FieldName = "Gl.Kode"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.OptionsColumn.ReadOnly = True
    Me.GridColumn6.Width = 57
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Nama Pelanggan"
    Me.GridColumn7.FieldName = "Pelanggan.Nama"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.OptionsColumn.ReadOnly = True
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 2
    Me.GridColumn7.Width = 57
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Kode Pelanggan"
    Me.GridColumn8.FieldName = "Pelanggan.Kode"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.OptionsColumn.ReadOnly = True
    Me.GridColumn8.Width = 63
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 3
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "BarButtonItem1"
    Me.BarButtonItem1.Id = 13
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'btnUpdateStatus
    '
    Me.btnUpdateStatus.Caption = "Update Status"
    Me.btnUpdateStatus.Glyph = CType(resources.GetObject("btnUpdateStatus.Glyph"), System.Drawing.Image)
    Me.btnUpdateStatus.Id = 14
    Me.btnUpdateStatus.LargeGlyph = CType(resources.GetObject("btnUpdateStatus.LargeGlyph"), System.Drawing.Image)
    Me.btnUpdateStatus.Name = "btnUpdateStatus"
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Update Status"
    Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
    Me.BarSubItem1.Id = 15
    Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPosting), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUnPosting)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'btnPosting
    '
    Me.btnPosting.Caption = "Posting Transaksi"
    Me.btnPosting.Glyph = CType(resources.GetObject("btnPosting.Glyph"), System.Drawing.Image)
    Me.btnPosting.Id = 16
    Me.btnPosting.LargeGlyph = CType(resources.GetObject("btnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnPosting.Name = "btnPosting"
    Me.btnPosting.Tag = "memposting"
    '
    'btnUnPosting
    '
    Me.btnUnPosting.Caption = "UnPosting Transaksi"
    Me.btnUnPosting.Glyph = CType(resources.GetObject("btnUnPosting.Glyph"), System.Drawing.Image)
    Me.btnUnPosting.Id = 17
    Me.btnUnPosting.LargeGlyph = CType(resources.GetObject("btnUnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnUnPosting.Name = "btnUnPosting"
    Me.btnUnPosting.Tag = "mengunposting"
    '
    'colPOSTotalTransaksi
    '
    Me.colPOSTotalTransaksi.FieldName = "POSTotalTransaksi"
    Me.colPOSTotalTransaksi.Name = "colPOSTotalTransaksi"
    '
    'UI_POS
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 401)
    Me.Name = "UI_POS"
    Me.Text = "POS (Point Of Sales - Quick)"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUpdateStatus As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colPOSTotalTransaksi As DevExpress.XtraGrid.Columns.GridColumn
End Class
