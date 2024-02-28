<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TravelDP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TravelDP))
        Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn131 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCetak = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistory = New DevExpress.XtraBars.BarButtonItem()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnoSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarDockingMenuItem1, Me.BarDockingMenuItem2, Me.btnUpdate, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.btnUpdateTransaksi, Me.btnPosting, Me.btnUnPosting, Me.btnClosing, Me.BarButtonItem6, Me.BarButtonItem7, Me.btnSaveLayout, Me.btnCetak, Me.btnHistory})
        Me.barMan.MaxItemId = 30
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.GridColumn131, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.GridColumn29, Me.colnoSO, Me.GridColumn1, Me.colTotal, Me.colCatatan, Me.colStatusTransaksi, Me.colKurs})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colStatusTransaksi
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Invoice"
        Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.xGridView.GroupCount = 3
        Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nominal", Nothing, "  (Nominal : {0:n0})")})
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsSelection.MultiSelect = True
        Me.xGridView.OptionsView.ShowAutoFilterRow = True
        Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn131, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ifSource
        '
        Me.ifSource.DisplayableProperties = "Id;Kode;Pelanggan.Nama;TravelOrder.Kode;Tanggal;AkunKasBank.Kode;AkunKasBank.Nama" &
    ";Uang.Kode;Kurs;Nominal;Uraian;Bulan;Tahun;AutoStatus"
        Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent.Travel_DownPayment)
        '
        'toolTip
        '
        Me.toolTip.ToolTipStyle = DevExpress.Utils.ToolTipStyle.Windows7
        Me.toolTip.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
        '
        'popMenu
        '
        Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetak, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnHistory, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        '
        'barMenu
        '
        Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUpdateTransaksi, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barMenu.OptionsBar.AllowQuickCustomization = False
        Me.barMenu.OptionsBar.DrawDragBorder = False
        Me.barMenu.OptionsBar.UseWholeRow = True
        '
        'colStatusTransaksi
        '
        Me.colStatusTransaksi.Caption = "Status"
        Me.colStatusTransaksi.FieldName = "AutoStatus"
        Me.colStatusTransaksi.Name = "colStatusTransaksi"
        Me.colStatusTransaksi.Visible = True
        Me.colStatusTransaksi.VisibleIndex = 8
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
        Me.colBulan.DisplayFormat.FormatString = "MMMM"
        Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.FieldName = "Bulan"
        Me.colBulan.GroupFormat.FormatString = "MMMM"
        Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.Name = "colBulan"
        Me.colBulan.OptionsColumn.ReadOnly = True
        Me.colBulan.Visible = True
        Me.colBulan.VisibleIndex = 5
        '
        'colKode
        '
        Me.colKode.Caption = "No Transaksi"
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
        'GridColumn131
        '
        Me.GridColumn131.Caption = "Uang"
        Me.GridColumn131.FieldName = "Uang.Kode"
        Me.GridColumn131.Name = "GridColumn131"
        Me.GridColumn131.OptionsColumn.ReadOnly = True
        Me.GridColumn131.Visible = True
        Me.GridColumn131.VisibleIndex = 5
        '
        'colTotal
        '
        Me.colTotal.Caption = "Nominal"
        Me.colTotal.DisplayFormat.FormatString = "n0"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Nominal"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 6
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
        Me.btnUpdateTransaksi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        'btnSaveLayout
        '
        Me.btnSaveLayout.Caption = "Save Layout"
        Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
        Me.btnSaveLayout.Id = 27
        Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
        Me.btnSaveLayout.Name = "btnSaveLayout"
        '
        'btnCetak
        '
        Me.btnCetak.Caption = "Cetak Voucher"
        Me.btnCetak.Glyph = CType(resources.GetObject("btnCetak.Glyph"), System.Drawing.Image)
        Me.btnCetak.Id = 28
        Me.btnCetak.LargeGlyph = CType(resources.GetObject("btnCetak.LargeGlyph"), System.Drawing.Image)
        Me.btnCetak.Name = "btnCetak"
        '
        'btnHistory
        '
        Me.btnHistory.Caption = "Cek History Data"
        Me.btnHistory.Glyph = CType(resources.GetObject("btnHistory.Glyph"), System.Drawing.Image)
        Me.btnHistory.Id = 29
        Me.btnHistory.LargeGlyph = CType(resources.GetObject("btnHistory.LargeGlyph"), System.Drawing.Image)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'colCatatan
        '
        Me.colCatatan.Caption = "Uraian"
        Me.colCatatan.FieldName = "Uraian"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 7
        '
        'colnoSO
        '
        Me.colnoSO.Caption = "Nomor SO"
        Me.colnoSO.FieldName = "TravelOrder.Kode"
        Me.colnoSO.Name = "colnoSO"
        Me.colnoSO.Visible = True
        Me.colnoSO.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Akun"
        Me.GridColumn1.FieldName = "AkunKasBank.Nama"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        '
        'colKurs
        '
        Me.colKurs.DisplayFormat.FormatString = "n2"
        Me.colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKurs.FieldName = "Kurs"
        Me.colKurs.Name = "colKurs"
        Me.colKurs.Visible = True
        Me.colKurs.VisibleIndex = 5
        '
        'UI_TravelDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 395)
        Me.Name = "UI_TravelDP"
        Me.Text = "Travel Down Payment [DP]"
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
	Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
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
	Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnCetak As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnHistory As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colnoSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
End Class
