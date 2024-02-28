<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_Fusoh_SOPPIC
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
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Fusoh_SOPPIC))
    Me.colJumlahDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUnposting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
    Me.btnResetStatus = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetak = New DevExpress.XtraBars.BarButtonItem()
    Me.btnHistory = New DevExpress.XtraBars.BarButtonItem()
    Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNomorPO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnHistoryDempyou = New DevExpress.XtraBars.BarButtonItem()
    Me.colTanggalPO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTipeSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnShowLog = New DevExpress.XtraBars.BarButtonItem()
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
        Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnUpdate, Me.btnPosting, Me.btnUnposting, Me.btnClosing, Me.BarButtonItem4, Me.btnSaveLayout, Me.btnCetak, Me.btnHistory, Me.btnResetStatus, Me.btnHistoryDempyou, Me.btnShowLog})
        Me.barMan.MaxItemId = 24
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.colCustomer, Me.colUang, Me.colTotal, Me.colStatus, Me.colNomorPO, Me.colCatatan, Me.colDeliveryDate, Me.colTanggalPO, Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colTipeSO, Me.colJumlahDempyou})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colJumlahDempyou
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[JumlahDempyou] == 0"
        Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.xGridView.GroupCount = 2
        Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsSelection.MultiSelect = True
        Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ifSource
        '
        Me.ifSource.DisplayableProperties = "Id;Tahun;Bulan;Urutan;Kode;Tanggal;StatusTransaksi;Pelanggan.Nama;Uang.Kode;Total" &
    ";NomorPO;Catatan;DeliveryDate;TanggalPO;last_date;last_modified;created_date;cre" &
    "ated_user;TipeSO;JumlahDempyou"
        Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.Fusoh_OrderPenjualan)
        '
        'popMenu
        '
        Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetak, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnHistory, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnHistoryDempyou), New DevExpress.XtraBars.LinkPersistInfo(Me.btnShowLog, True)})
        '
        'barMenu
        '
        Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barMenu.OptionsBar.AllowQuickCustomization = False
        Me.barMenu.OptionsBar.DrawDragBorder = False
        Me.barMenu.OptionsBar.UseWholeRow = True
        '
        'colJumlahDempyou
        '
        Me.colJumlahDempyou.Caption = "Dempyou"
        Me.colJumlahDempyou.FieldName = "JumlahDempyou"
        Me.colJumlahDempyou.Name = "colJumlahDempyou"
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
        Me.colBulan.DisplayFormat.FormatString = "MMMM"
        Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.FieldName = "Bulan"
        Me.colBulan.GroupFormat.FormatString = "MMMM"
        Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.Name = "colBulan"
        Me.colBulan.OptionsColumn.ReadOnly = True
        Me.colBulan.Visible = True
        Me.colBulan.VisibleIndex = 4
        '
        'colKode
        '
        Me.colKode.Caption = "No Transaksi"
        Me.colKode.FieldName = "Kode"
        Me.colKode.Name = "colKode"
        Me.colKode.Visible = True
        Me.colKode.VisibleIndex = 1
        '
        'colTanggal
        '
        Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTanggal.FieldName = "Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 2
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer"
        Me.colCustomer.FieldName = "Pelanggan.Nama"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.OptionsColumn.ReadOnly = True
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 3
        '
        'colUang
        '
        Me.colUang.Caption = "Uang"
        Me.colUang.FieldName = "Uang.Kode"
        Me.colUang.Name = "colUang"
        Me.colUang.OptionsColumn.ReadOnly = True
        Me.colUang.Visible = True
        Me.colUang.VisibleIndex = 4
        '
        'colTotal
        '
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.Caption = "&Update Status"
        Me.btnUpdate.Glyph = CType(resources.GetObject("btnUpdate.Glyph"), System.Drawing.Image)
        Me.btnUpdate.Id = 13
        Me.btnUpdate.LargeGlyph = CType(resources.GetObject("btnUpdate.LargeGlyph"), System.Drawing.Image)
        Me.btnUpdate.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUnposting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClosing, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnResetStatus, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.btnUpdate.Name = "btnUpdate"
        '
        'btnPosting
        '
        Me.btnPosting.Caption = "Posting Transaksi"
        Me.btnPosting.Glyph = CType(resources.GetObject("btnPosting.Glyph"), System.Drawing.Image)
        Me.btnPosting.Id = 14
        Me.btnPosting.LargeGlyph = CType(resources.GetObject("btnPosting.LargeGlyph"), System.Drawing.Image)
        Me.btnPosting.Name = "btnPosting"
        Me.btnPosting.Tag = "memposting"
        '
        'btnUnposting
        '
        Me.btnUnposting.Caption = "UnPosting Transaksi"
        Me.btnUnposting.Glyph = CType(resources.GetObject("btnUnposting.Glyph"), System.Drawing.Image)
        Me.btnUnposting.Id = 15
        Me.btnUnposting.LargeGlyph = CType(resources.GetObject("btnUnposting.LargeGlyph"), System.Drawing.Image)
        Me.btnUnposting.Name = "btnUnposting"
        Me.btnUnposting.Tag = "mengunposting"
        '
        'btnClosing
        '
        Me.btnClosing.Caption = "Closing Transaksi"
        Me.btnClosing.Id = 16
        Me.btnClosing.Name = "btnClosing"
        Me.btnClosing.Tag = "mengclosing"
        '
        'btnResetStatus
        '
        Me.btnResetStatus.Caption = "Reset Status Transaksi"
        Me.btnResetStatus.Glyph = CType(resources.GetObject("btnResetStatus.Glyph"), System.Drawing.Image)
        Me.btnResetStatus.Id = 21
        Me.btnResetStatus.LargeGlyph = CType(resources.GetObject("btnResetStatus.LargeGlyph"), System.Drawing.Image)
        Me.btnResetStatus.Name = "btnResetStatus"
        Me.btnResetStatus.Tag = "mereset"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Id = 17
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'btnSaveLayout
        '
        Me.btnSaveLayout.Caption = "Save Layout"
        Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
        Me.btnSaveLayout.Id = 18
        Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
        Me.btnSaveLayout.Name = "btnSaveLayout"
        '
        'btnCetak
        '
        Me.btnCetak.Caption = "Cetak Voucher"
        Me.btnCetak.Glyph = CType(resources.GetObject("btnCetak.Glyph"), System.Drawing.Image)
        Me.btnCetak.Id = 19
        Me.btnCetak.LargeGlyph = CType(resources.GetObject("btnCetak.LargeGlyph"), System.Drawing.Image)
        Me.btnCetak.Name = "btnCetak"
        '
        'btnHistory
        '
        Me.btnHistory.Caption = "Cek History Data"
        Me.btnHistory.Glyph = CType(resources.GetObject("btnHistory.Glyph"), System.Drawing.Image)
        Me.btnHistory.Id = 20
        Me.btnHistory.LargeGlyph = CType(resources.GetObject("btnHistory.LargeGlyph"), System.Drawing.Image)
        Me.btnHistory.Name = "btnHistory"
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "StatusTransaksi"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 6
        '
        'colNomorPO
        '
        Me.colNomorPO.FieldName = "NomorPO"
        Me.colNomorPO.Name = "colNomorPO"
        Me.colNomorPO.Visible = True
        Me.colNomorPO.VisibleIndex = 7
        '
        'colCatatan
        '
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 8
        '
        'colDeliveryDate
        '
        Me.colDeliveryDate.FieldName = "DeliveryDate"
        Me.colDeliveryDate.Name = "colDeliveryDate"
        Me.colDeliveryDate.Visible = True
        Me.colDeliveryDate.VisibleIndex = 9
        '
        'btnHistoryDempyou
        '
        Me.btnHistoryDempyou.Caption = "History Dempyou"
        Me.btnHistoryDempyou.Id = 22
        Me.btnHistoryDempyou.Name = "btnHistoryDempyou"
        '
        'colTanggalPO
        '
        Me.colTanggalPO.Caption = "Tgl PO"
        Me.colTanggalPO.FieldName = "TanggalPO"
        Me.colTanggalPO.Name = "colTanggalPO"
        Me.colTanggalPO.Visible = True
        Me.colTanggalPO.VisibleIndex = 10
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
        'colTipeSO
        '
        Me.colTipeSO.FieldName = "TipeSO"
        Me.colTipeSO.Name = "colTipeSO"
        Me.colTipeSO.Visible = True
        Me.colTipeSO.VisibleIndex = 0
        '
        'btnShowLog
        '
        Me.btnShowLog.Caption = "Show Log"
        Me.btnShowLog.Glyph = CType(resources.GetObject("btnShowLog.Glyph"), System.Drawing.Image)
        Me.btnShowLog.Id = 23
        Me.btnShowLog.LargeGlyph = CType(resources.GetObject("btnShowLog.LargeGlyph"), System.Drawing.Image)
        Me.btnShowLog.Name = "btnShowLog"
        '
        'UI_Fusoh_SOPPIC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 395)
        Me.Name = "UI_Fusoh_SOPPIC"
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
  Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUnposting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetak As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnHistory As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNomorPO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnResetStatus As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnHistoryDempyou As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colTanggalPO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTipeSO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJumlahDempyou As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnShowLog As DevExpress.XtraBars.BarButtonItem
End Class
