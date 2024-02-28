<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_zParamaSO
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_zParamaSO))
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn92 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn131 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
    Me.BarDockingMenuItem2 = New DevExpress.XtraBars.BarDockingMenuItem()
    Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
    Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUpdateTransaksi = New DevExpress.XtraBars.BarSubItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetakVoucher = New DevExpress.XtraBars.BarButtonItem()
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
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarDockingMenuItem1, Me.BarDockingMenuItem2, Me.btnUpdate, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.btnUpdateTransaksi, Me.btnPosting, Me.btnUnPosting, Me.btnClosing, Me.BarButtonItem6, Me.BarButtonItem7, Me.btnCetakVoucher})
    Me.barMan.MaxItemId = 28
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.GridColumn10, Me.GridColumn29, Me.GridColumn92, Me.GridColumn131, Me.colTotal, Me.colStatusTransaksi})
    Me.xGridView.GroupCount = 2
    Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.zParamaOrderPenjualan)
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetakVoucher, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUpdateTransaksi, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
    Me.colBulan.VisibleIndex = 0
    '
    'colKode
    '
    Me.colKode.Caption = "No Transaksi"
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
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Regional"
    Me.GridColumn10.FieldName = "Regional.Kode"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.OptionsColumn.ReadOnly = True
    '
    'GridColumn29
    '
    Me.GridColumn29.Caption = "Pelanggan"
    Me.GridColumn29.FieldName = "Pelanggan.Nama"
    Me.GridColumn29.Name = "GridColumn29"
    Me.GridColumn29.OptionsColumn.ReadOnly = True
    Me.GridColumn29.Visible = True
    Me.GridColumn29.VisibleIndex = 2
    '
    'GridColumn92
    '
    Me.GridColumn92.Caption = "Karyawan"
    Me.GridColumn92.FieldName = "Karyawan.Nama"
    Me.GridColumn92.Name = "GridColumn92"
    Me.GridColumn92.OptionsColumn.ReadOnly = True
    Me.GridColumn92.Visible = True
    Me.GridColumn92.VisibleIndex = 3
    '
    'GridColumn131
    '
    Me.GridColumn131.Caption = "Uang"
    Me.GridColumn131.FieldName = "Uang.Kode"
    Me.GridColumn131.Name = "GridColumn131"
    Me.GridColumn131.OptionsColumn.ReadOnly = True
    Me.GridColumn131.Visible = True
    Me.GridColumn131.VisibleIndex = 4
    '
    'colStatusTransaksi
    '
    Me.colStatusTransaksi.Caption = "Status"
    Me.colStatusTransaksi.FieldName = "StatusTransaksi"
    Me.colStatusTransaksi.Name = "colStatusTransaksi"
    Me.colStatusTransaksi.Visible = True
    Me.colStatusTransaksi.VisibleIndex = 6
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total Transaksi"
    Me.colTotal.FieldName = "Total"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 5
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "UnPosting"
    Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
    Me.BarButtonItem1.Id = 13
    Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'BarButtonItem2
    '
    Me.BarButtonItem2.Caption = "Posting"
    Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
    Me.BarButtonItem2.Id = 14
    Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
    Me.BarButtonItem2.Name = "BarButtonItem2"
    '
    'BarDockingMenuItem1
    '
    Me.BarDockingMenuItem1.Caption = "BarDockingMenuItem1"
    Me.BarDockingMenuItem1.Id = 15
    Me.BarDockingMenuItem1.Name = "BarDockingMenuItem1"
    '
    'BarDockingMenuItem2
    '
    Me.BarDockingMenuItem2.Caption = "Update Status"
    Me.BarDockingMenuItem2.Id = 16
    Me.BarDockingMenuItem2.Name = "BarDockingMenuItem2"
    '
    'btnUpdate
    '
    Me.btnUpdate.Caption = "Update Status"
    Me.btnUpdate.Id = 17
    Me.btnUpdate.LargeGlyph = CType(resources.GetObject("btnUpdate.LargeGlyph"), System.Drawing.Image)
    Me.btnUpdate.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem5, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.btnUpdate.Name = "btnUpdate"
    '
    'BarButtonItem3
    '
    Me.BarButtonItem3.Caption = "Posting Transaksi"
    Me.BarButtonItem3.Id = 18
    Me.BarButtonItem3.Name = "BarButtonItem3"
    '
    'BarButtonItem4
    '
    Me.BarButtonItem4.Caption = "UnPosting Transaksi"
    Me.BarButtonItem4.Id = 19
    Me.BarButtonItem4.Name = "BarButtonItem4"
    '
    'BarButtonItem5
    '
    Me.BarButtonItem5.Caption = "Closing Transaksi"
    Me.BarButtonItem5.Id = 20
    Me.BarButtonItem5.Name = "BarButtonItem5"
    '
    'btnUpdateTransaksi
    '
    Me.btnUpdateTransaksi.Caption = "&Update Status"
    Me.btnUpdateTransaksi.Glyph = CType(resources.GetObject("btnUpdateTransaksi.Glyph"), System.Drawing.Image)
    Me.btnUpdateTransaksi.Id = 21
    Me.btnUpdateTransaksi.LargeGlyph = CType(resources.GetObject("btnUpdateTransaksi.LargeGlyph"), System.Drawing.Image)
    Me.btnUpdateTransaksi.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClosing, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.btnUpdateTransaksi.Name = "btnUpdateTransaksi"
    '
    'btnPosting
    '
    Me.btnPosting.Caption = "Posting Transaksi"
    Me.btnPosting.Glyph = CType(resources.GetObject("btnPosting.Glyph"), System.Drawing.Image)
    Me.btnPosting.Id = 22
    Me.btnPosting.LargeGlyph = CType(resources.GetObject("btnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnPosting.Name = "btnPosting"
    Me.btnPosting.Tag = "memposting"
    '
    'btnUnPosting
    '
    Me.btnUnPosting.Caption = "UnPosting Transaksi"
    Me.btnUnPosting.Glyph = CType(resources.GetObject("btnUnPosting.Glyph"), System.Drawing.Image)
    Me.btnUnPosting.Id = 23
    Me.btnUnPosting.LargeGlyph = CType(resources.GetObject("btnUnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnUnPosting.Name = "btnUnPosting"
    Me.btnUnPosting.Tag = "mengunposting"
    '
    'btnClosing
    '
    Me.btnClosing.Caption = "Closing Transaksi"
    Me.btnClosing.Id = 24
    Me.btnClosing.Name = "btnClosing"
    Me.btnClosing.Tag = "mengclosing"
    '
    'BarButtonItem6
    '
    Me.BarButtonItem6.Caption = "BarButtonItem6"
    Me.BarButtonItem6.Id = 25
    Me.BarButtonItem6.Name = "BarButtonItem6"
    '
    'BarButtonItem7
    '
    Me.BarButtonItem7.Caption = "Testing"
    Me.BarButtonItem7.Id = 26
    Me.BarButtonItem7.Name = "BarButtonItem7"
    '
    'btnCetakVoucher
    '
    Me.btnCetakVoucher.Caption = "Cetak Voucher"
    Me.btnCetakVoucher.Glyph = CType(resources.GetObject("btnCetakVoucher.Glyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Id = 27
    Me.btnCetakVoucher.LargeGlyph = CType(resources.GetObject("btnCetakVoucher.LargeGlyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Name = "btnCetakVoucher"
    '
    'UI_zParamaSO
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_zParamaSO"
    Me.Text = "Order Penjualan [SO]"
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
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn92 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn131 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
  Friend WithEvents BarDockingMenuItem2 As DevExpress.XtraBars.BarDockingMenuItem
  Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUpdateTransaksi As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetakVoucher As DevExpress.XtraBars.BarButtonItem
End Class
