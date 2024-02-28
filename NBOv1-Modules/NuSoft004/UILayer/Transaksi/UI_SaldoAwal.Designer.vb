<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SaldoAwal
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SaldoAwal))
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnImporData})
		Me.barMan.MaxItemId = 14
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colId, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.colQtyIn, Me.colHargaIn, Me.colTotal})
		Me.xGridView.GroupCount = 1
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn15, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'ifSource
		'
		Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.StockDetail)
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImporData, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Tanggal Input"
		Me.GridColumn1.FieldName = "Main.created_date"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.OptionsColumn.ReadOnly = True
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "User Input"
		Me.GridColumn2.FieldName = "Main.created_user"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.OptionsColumn.ReadOnly = True
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Tanggal Edit"
		Me.GridColumn3.FieldName = "Main.last_date"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.OptionsColumn.ReadOnly = True
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "User edit"
		Me.GridColumn4.FieldName = "Main.last_modified"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.OptionsColumn.ReadOnly = True
		'
		'colId
		'
		Me.colId.Caption = "ID"
		Me.colId.FieldName = "Main.Id"
		Me.colId.Name = "colId"
		Me.colId.OptionsColumn.ReadOnly = True
		'
		'GridColumn6
		'
		Me.GridColumn6.Caption = "Tahun"
		Me.GridColumn6.FieldName = "Main.Tahun"
		Me.GridColumn6.Name = "GridColumn6"
		Me.GridColumn6.OptionsColumn.ReadOnly = True
		'
		'GridColumn7
		'
		Me.GridColumn7.Caption = "Bulan"
		Me.GridColumn7.FieldName = "Main.Bulan"
		Me.GridColumn7.Name = "GridColumn7"
		Me.GridColumn7.OptionsColumn.ReadOnly = True
		'
		'GridColumn8
		'
		Me.GridColumn8.Caption = "No Bukti"
		Me.GridColumn8.FieldName = "Main.Kode"
		Me.GridColumn8.Name = "GridColumn8"
		Me.GridColumn8.OptionsColumn.ReadOnly = True
		Me.GridColumn8.Visible = True
		Me.GridColumn8.VisibleIndex = 0
		Me.GridColumn8.Width = 104
		'
		'GridColumn9
		'
		Me.GridColumn9.Caption = "Tanggal"
		Me.GridColumn9.FieldName = "Main.Tanggal"
		Me.GridColumn9.Name = "GridColumn9"
		Me.GridColumn9.OptionsColumn.ReadOnly = True
		'
		'GridColumn10
		'
		Me.GridColumn10.Caption = "Regional Kode"
		Me.GridColumn10.FieldName = "Main.Regional.Kode"
		Me.GridColumn10.Name = "GridColumn10"
		Me.GridColumn10.OptionsColumn.ReadOnly = True
		'
		'GridColumn11
		'
		Me.GridColumn11.Caption = "Regional Nama"
		Me.GridColumn11.FieldName = "Main.Regional.Nama"
		Me.GridColumn11.Name = "GridColumn11"
		Me.GridColumn11.OptionsColumn.ReadOnly = True
		'
		'GridColumn12
		'
		Me.GridColumn12.Caption = "Karyawan"
		Me.GridColumn12.FieldName = "Main.KaryawanKirim.Kode"
		Me.GridColumn12.Name = "GridColumn12"
		Me.GridColumn12.OptionsColumn.ReadOnly = True
		Me.GridColumn12.Visible = True
		Me.GridColumn12.VisibleIndex = 7
		Me.GridColumn12.Width = 90
		'
		'GridColumn13
		'
		Me.GridColumn13.Caption = "Nama Karyawan"
		Me.GridColumn13.FieldName = "Main.KaryawanKirim.Nama"
		Me.GridColumn13.Name = "GridColumn13"
		Me.GridColumn13.OptionsColumn.ReadOnly = True
		Me.GridColumn13.Width = 159
		'
		'GridColumn14
		'
		Me.GridColumn14.Caption = "Kode Gudang"
		Me.GridColumn14.FieldName = "Main.Gudang.Kode"
		Me.GridColumn14.Name = "GridColumn14"
		Me.GridColumn14.OptionsColumn.ReadOnly = True
		'
		'GridColumn15
		'
		Me.GridColumn15.Caption = "Gudang"
		Me.GridColumn15.FieldName = "Main.Gudang.Nama"
		Me.GridColumn15.Name = "GridColumn15"
		Me.GridColumn15.OptionsColumn.ReadOnly = True
		Me.GridColumn15.Visible = True
		Me.GridColumn15.VisibleIndex = 3
		'
		'GridColumn16
		'
		Me.GridColumn16.Caption = "Status"
		Me.GridColumn16.FieldName = "Main.StatusTransaksi"
		Me.GridColumn16.Name = "GridColumn16"
		Me.GridColumn16.OptionsColumn.ReadOnly = True
		Me.GridColumn16.Visible = True
		Me.GridColumn16.VisibleIndex = 8
		Me.GridColumn16.Width = 130
		'
		'GridColumn17
		'
		Me.GridColumn17.Caption = "No Bukti GL"
		Me.GridColumn17.FieldName = "Main.Gl.Kode"
		Me.GridColumn17.Name = "GridColumn17"
		Me.GridColumn17.OptionsColumn.ReadOnly = True
		'
		'GridColumn18
		'
		Me.GridColumn18.Caption = "Kode Barang"
		Me.GridColumn18.FieldName = "Barang.Kode"
		Me.GridColumn18.Name = "GridColumn18"
		Me.GridColumn18.OptionsColumn.ReadOnly = True
		Me.GridColumn18.Visible = True
		Me.GridColumn18.VisibleIndex = 1
		Me.GridColumn18.Width = 110
		'
		'GridColumn19
		'
		Me.GridColumn19.Caption = "Nama Barang"
		Me.GridColumn19.FieldName = "Barang.Nama"
		Me.GridColumn19.Name = "GridColumn19"
		Me.GridColumn19.OptionsColumn.ReadOnly = True
		Me.GridColumn19.Visible = True
		Me.GridColumn19.VisibleIndex = 2
		Me.GridColumn19.Width = 113
		'
		'GridColumn20
		'
		Me.GridColumn20.Caption = "Satuan"
		Me.GridColumn20.FieldName = "Satuan.Kode"
		Me.GridColumn20.Name = "GridColumn20"
		Me.GridColumn20.OptionsColumn.ReadOnly = True
		Me.GridColumn20.Visible = True
		Me.GridColumn20.VisibleIndex = 3
		Me.GridColumn20.Width = 89
		'
		'GridColumn21
		'
		Me.GridColumn21.Caption = "Nama Satuan"
		Me.GridColumn21.FieldName = "Satuan.Nama"
		Me.GridColumn21.Name = "GridColumn21"
		Me.GridColumn21.OptionsColumn.ReadOnly = True
		'
		'colQtyIn
		'
		Me.colQtyIn.Caption = "Qty"
		Me.colQtyIn.FieldName = "QtyIn"
		Me.colQtyIn.Name = "colQtyIn"
		Me.colQtyIn.Visible = True
		Me.colQtyIn.VisibleIndex = 4
		Me.colQtyIn.Width = 46
		'
		'colHargaIn
		'
		Me.colHargaIn.Caption = "Harga"
		Me.colHargaIn.FieldName = "HargaIn"
		Me.colHargaIn.Name = "colHargaIn"
		Me.colHargaIn.Visible = True
		Me.colHargaIn.VisibleIndex = 5
		Me.colHargaIn.Width = 59
		'
		'colTotal
		'
		Me.colTotal.Caption = "Total"
		Me.colTotal.FieldName = "colTotal"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colTotal", "SUM={0:0.##}")})
		Me.colTotal.UnboundExpression = "[QtyIn]*[HargaIn]"
		Me.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colTotal.Visible = True
		Me.colTotal.VisibleIndex = 6
		'
		'btnImporData
		'
		Me.btnImporData.Caption = "Impor Data"
		Me.btnImporData.Glyph = CType(resources.GetObject("btnImporData.Glyph"), System.Drawing.Image)
		Me.btnImporData.Id = 13
		Me.btnImporData.LargeGlyph = CType(resources.GetObject("btnImporData.LargeGlyph"), System.Drawing.Image)
		Me.btnImporData.Name = "btnImporData"
		'
		'UI_SaldoAwal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_SaldoAwal"
		Me.Text = "Saldo Awal Stock"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnImporData As DevExpress.XtraBars.BarButtonItem
End Class
