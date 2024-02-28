<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SaldoAwalPiutang
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SaldoAwalPiutang))
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotalValas = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
		Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
		Me.colNilaiSaldoAwal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnImporData = New DevExpress.XtraBars.BarButtonItem()
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
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout, Me.BarButtonItem1, Me.btnUpdate, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.btnImporData})
		Me.barMan.MaxItemId = 20
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.colCustomer, Me.colUang, Me.colTotal, Me.colKurs, Me.colTotalValas, Me.colStatus, Me.colNilaiSaldoAwal})
		Me.xGridView.GroupCount = 2
		Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'ifSource
		'
		Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.InvoicePenjualan)
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImporData, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
		Me.colTahun.VisibleIndex = 1
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
		Me.colBulan.VisibleIndex = 1
		'
		'colKode
		'
		Me.colKode.Caption = "No. Transaksi"
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
		'colCustomer
		'
		Me.colCustomer.Caption = "Customer"
		Me.colCustomer.FieldName = "Pelanggan.Nama"
		Me.colCustomer.Name = "colCustomer"
		Me.colCustomer.OptionsColumn.ReadOnly = True
		Me.colCustomer.Visible = True
		Me.colCustomer.VisibleIndex = 2
		'
		'colUang
		'
		Me.colUang.Caption = "Uang"
		Me.colUang.FieldName = "Uang.Kode"
		Me.colUang.Name = "colUang"
		Me.colUang.Visible = True
		Me.colUang.VisibleIndex = 3
		'
		'colTotalValas
		'
		Me.colTotalValas.Caption = "Valas"
		Me.colTotalValas.FieldName = "NilaiInvoiceValas"
		Me.colTotalValas.Name = "colTotalValas"
		Me.colTotalValas.Visible = True
		Me.colTotalValas.VisibleIndex = 6
		'
		'colKurs
		'
		Me.colKurs.Caption = "Kurs"
		Me.colKurs.FieldName = "Kurs"
		Me.colKurs.Name = "colKurs"
		Me.colKurs.Visible = True
		Me.colKurs.VisibleIndex = 5
		'
		'colTotal
		'
		Me.colTotal.Caption = "Saldo"
		Me.colTotal.FieldName = "colTotal"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colTotal.UnboundExpression = "[NilaiSaldoAwal]*[Kurs]"
		Me.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colTotal.Visible = True
		Me.colTotal.VisibleIndex = 4
		'
		'colStatus
		'
		Me.colStatus.FieldName = "StatusTransaksi"
		Me.colStatus.Name = "colStatus"
		Me.colStatus.Visible = True
		Me.colStatus.VisibleIndex = 7
		'
		'btnSaveLayout
		'
		Me.btnSaveLayout.Caption = "Save Layout"
		Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
		Me.btnSaveLayout.Id = 13
		Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
		Me.btnSaveLayout.Name = "btnSaveLayout"
		'
		'BarButtonItem1
		'
		Me.BarButtonItem1.Caption = "Transaksi"
		Me.BarButtonItem1.Id = 14
		Me.BarButtonItem1.Name = "BarButtonItem1"
		'
		'btnUpdate
		'
		Me.btnUpdate.Caption = "Update Status"
		Me.btnUpdate.Id = 15
		Me.btnUpdate.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
		Me.btnUpdate.Name = "btnUpdate"
		'
		'BarButtonItem2
		'
		Me.BarButtonItem2.Caption = "Posting Transaksi"
		Me.BarButtonItem2.Id = 16
		Me.BarButtonItem2.Name = "BarButtonItem2"
		'
		'BarButtonItem3
		'
		Me.BarButtonItem3.Caption = "Unposting Transaksi"
		Me.BarButtonItem3.Id = 17
		Me.BarButtonItem3.Name = "BarButtonItem3"
		'
		'BarButtonItem4
		'
		Me.BarButtonItem4.Caption = "Closing Transaksi"
		Me.BarButtonItem4.Id = 18
		Me.BarButtonItem4.Name = "BarButtonItem4"
		'
		'colNilaiSaldoAwal
		'
		Me.colNilaiSaldoAwal.FieldName = "NilaiSaldoAwal"
		Me.colNilaiSaldoAwal.Name = "colNilaiSaldoAwal"
		'
		'btnImporData
		'
		Me.btnImporData.Caption = "Impor Data"
		Me.btnImporData.Glyph = CType(resources.GetObject("btnImporData.Glyph"), System.Drawing.Image)
		Me.btnImporData.Id = 19
		Me.btnImporData.LargeGlyph = CType(resources.GetObject("btnImporData.LargeGlyph"), System.Drawing.Image)
		Me.btnImporData.Name = "btnImporData"
		'
		'UI_SaldoAwalPiutang
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_SaldoAwalPiutang"
		Me.Text = "Saldo Awal Piutang"
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
  Friend WithEvents colTotalValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colNilaiSaldoAwal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnImporData As DevExpress.XtraBars.BarButtonItem
End Class
