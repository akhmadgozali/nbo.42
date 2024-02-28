<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Barang
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
		Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Barang))
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuan2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colJenisBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustom1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustom2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustom3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustom4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustom5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btSaveLayout = New DevExpress.XtraBars.BarButtonItem()
		Me.colHargaJual1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaJual2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaJual3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaJual5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaJual4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCoaHPP = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCoaPendapatanDiskon = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCoaBiayaDiskon = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCoaPendapatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCoaReturPembelian = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCoaReturPenjualan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCoaPersediaan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.colHargaBeli = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKategori = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnLokasi = New DevExpress.XtraBars.BarButtonItem()
		Me.colFeeAgen = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTipeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnImporData = New DevExpress.XtraBars.BarButtonItem()
		Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
		Me.btnImporAssembly = New DevExpress.XtraBars.BarButtonItem()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.DataSource = Me.xpCol
		GridLevelNode1.LevelTemplate = Me.GridView1
		GridLevelNode1.RelationName = "ItemLocation"
		Me.xGrid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
		Me.xGrid.Size = New System.Drawing.Size(1147, 539)
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
		'
		'xpCol
		'
		Me.xpCol.DisplayableProperties = resources.GetString("xpCol.DisplayableProperties")
		Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Barang)
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btSaveLayout, Me.BarButtonItem1, Me.btnLokasi, Me.btnImporData, Me.BarSubItem1, Me.btnImporAssembly})
		Me.barMan.MaxItemId = 21
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKategori, Me.colCode, Me.colName, Me.colSatuan2, Me.colHargaBeli, Me.colCustom1, Me.colJenisBarang, Me.colCustom2, Me.colCustom3, Me.colCustom4, Me.colCustom5, Me.colHargaJual1, Me.colHargaJual2, Me.colHargaJual3, Me.colHargaJual4, Me.colHargaJual5, Me.colCoaHPP, Me.colCoaPendapatanDiskon, Me.colCoaBiayaDiskon, Me.colCoaPendapatan, Me.colCoaReturPembelian, Me.colCoaReturPenjualan, Me.colCoaPersediaan, Me.collast_date, Me.collast_modified, Me.colcreated_date, Me.colcreated_user, Me.colFeeAgen, Me.colTipeBarang})
		Me.xGridView.GroupCount = 1
		Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKategori, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLokasi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'GridView1
		'
		Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
		Me.GridView1.GridControl = Me.xGrid
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsDetail.EnableMasterViewMode = False
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Gudang"
		Me.GridColumn1.FieldName = "Gudang.Nama"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Lokasi/RAK"
		Me.GridColumn2.FieldName = "Lokasi"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		'
		'colCode
		'
		Me.colCode.AppearanceCell.Options.UseTextOptions = True
		Me.colCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colCode.Caption = "Kode"
		Me.colCode.FieldName = "Kode"
		Me.colCode.Name = "colCode"
		Me.colCode.Visible = True
		Me.colCode.VisibleIndex = 0
		'
		'colName
		'
		Me.colName.Caption = "Nama"
		Me.colName.FieldName = "Nama"
		Me.colName.Name = "colName"
		Me.colName.Visible = True
		Me.colName.VisibleIndex = 1
		'
		'colSatuan2
		'
		Me.colSatuan2.Caption = "Satuan"
		Me.colSatuan2.FieldName = "SatuanD.Kode"
		Me.colSatuan2.Name = "colSatuan2"
		Me.colSatuan2.Visible = True
		Me.colSatuan2.VisibleIndex = 2
		'
		'colJenisBarang
		'
		Me.colJenisBarang.AppearanceCell.Options.UseTextOptions = True
		Me.colJenisBarang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colJenisBarang.Caption = "Jenis"
		Me.colJenisBarang.FieldName = "Jenis"
		Me.colJenisBarang.Name = "colJenisBarang"
		Me.colJenisBarang.Tag = "Test Jali"
		'
		'colId
		'
		Me.colId.Caption = "ID"
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'colCustom1
		'
		Me.colCustom1.Caption = "Custom1"
		Me.colCustom1.FieldName = "Custom1"
		Me.colCustom1.Name = "colCustom1"
		'
		'colCustom2
		'
		Me.colCustom2.Caption = "Custom2"
		Me.colCustom2.FieldName = "Custom2"
		Me.colCustom2.Name = "colCustom2"
		'
		'colCustom3
		'
		Me.colCustom3.Caption = "Custom3"
		Me.colCustom3.FieldName = "Custom3"
		Me.colCustom3.Name = "colCustom3"
		'
		'colCustom4
		'
		Me.colCustom4.Caption = "Custom4"
		Me.colCustom4.FieldName = "Custom4"
		Me.colCustom4.Name = "colCustom4"
		'
		'colCustom5
		'
		Me.colCustom5.Caption = "Custom5"
		Me.colCustom5.FieldName = "Custom5"
		Me.colCustom5.Name = "colCustom5"
		'
		'btSaveLayout
		'
		Me.btSaveLayout.Caption = "Save Layout"
		Me.btSaveLayout.Glyph = CType(resources.GetObject("btSaveLayout.Glyph"), System.Drawing.Image)
		Me.btSaveLayout.Id = 15
		Me.btSaveLayout.LargeGlyph = CType(resources.GetObject("btSaveLayout.LargeGlyph"), System.Drawing.Image)
		Me.btSaveLayout.Name = "btSaveLayout"
		'
		'colHargaJual1
		'
		Me.colHargaJual1.FieldName = "HargaJual1"
		Me.colHargaJual1.Name = "colHargaJual1"
		'
		'colHargaJual2
		'
		Me.colHargaJual2.FieldName = "HargaJual2"
		Me.colHargaJual2.Name = "colHargaJual2"
		'
		'colHargaJual3
		'
		Me.colHargaJual3.FieldName = "HargaJual3"
		Me.colHargaJual3.Name = "colHargaJual3"
		'
		'colHargaJual5
		'
		Me.colHargaJual5.FieldName = "HargaJual5"
		Me.colHargaJual5.Name = "colHargaJual5"
		'
		'colHargaJual4
		'
		Me.colHargaJual4.FieldName = "HargaJual4"
		Me.colHargaJual4.Name = "colHargaJual4"
		'
		'colCoaHPP
		'
		Me.colCoaHPP.Caption = "COA HPP"
		Me.colCoaHPP.FieldName = "CoaCost.Kode"
		Me.colCoaHPP.Name = "colCoaHPP"
		'
		'colCoaPendapatanDiskon
		'
		Me.colCoaPendapatanDiskon.Caption = "Coa Diskon Pembelian"
		Me.colCoaPendapatanDiskon.FieldName = "CoaDiscIncome.Kode"
		Me.colCoaPendapatanDiskon.Name = "colCoaPendapatanDiskon"
		'
		'colCoaBiayaDiskon
		'
		Me.colCoaBiayaDiskon.Caption = "Coa Diskon Penjualan"
		Me.colCoaBiayaDiskon.FieldName = "CoaDiscOut.Kode"
		Me.colCoaBiayaDiskon.Name = "colCoaBiayaDiskon"
		'
		'colCoaPendapatan
		'
		Me.colCoaPendapatan.Caption = "Coa Pendapatan"
		Me.colCoaPendapatan.FieldName = "CoaIncome.Kode"
		Me.colCoaPendapatan.Name = "colCoaPendapatan"
		'
		'colCoaReturPembelian
		'
		Me.colCoaReturPembelian.Caption = "Coa Retur Pembelian"
		Me.colCoaReturPembelian.FieldName = "CoaReturnIn.Kode"
		Me.colCoaReturPembelian.Name = "colCoaReturPembelian"
		'
		'colCoaReturPenjualan
		'
		Me.colCoaReturPenjualan.Caption = "Coa Retur Penjualan"
		Me.colCoaReturPenjualan.FieldName = "CoaReturnOut.Kode"
		Me.colCoaReturPenjualan.Name = "colCoaReturPenjualan"
		'
		'colCoaPersediaan
		'
		Me.colCoaPersediaan.Caption = "Coa Persediaan"
		Me.colCoaPersediaan.FieldName = "CoaStock.Kode"
		Me.colCoaPersediaan.Name = "colCoaPersediaan"
		'
		'collast_date
		'
		Me.collast_date.Caption = "Tgl Edit"
		Me.collast_date.FieldName = "last_date"
		Me.collast_date.Name = "collast_date"
		'
		'collast_modified
		'
		Me.collast_modified.Caption = "User Edit"
		Me.collast_modified.FieldName = "last_modified"
		Me.collast_modified.Name = "collast_modified"
		'
		'colcreated_date
		'
		Me.colcreated_date.Caption = "Tgl Create"
		Me.colcreated_date.FieldName = "created_date"
		Me.colcreated_date.Name = "colcreated_date"
		'
		'colcreated_user
		'
		Me.colcreated_user.Caption = "User Create"
		Me.colcreated_user.FieldName = "created_user"
		Me.colcreated_user.Name = "colcreated_user"
		'
		'BarButtonItem1
		'
		Me.BarButtonItem1.Caption = "BarButtonItem1"
		Me.BarButtonItem1.Id = 16
		Me.BarButtonItem1.Name = "BarButtonItem1"
		'
		'RepositoryItemLookUpEdit1
		'
		Me.RepositoryItemLookUpEdit1.AutoHeight = False
		Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
		'
		'colHargaBeli
		'
		Me.colHargaBeli.Caption = "Harga Beli"
		Me.colHargaBeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHargaBeli.FieldName = "LastPurchase"
		Me.colHargaBeli.Name = "colHargaBeli"
		Me.colHargaBeli.Visible = True
		Me.colHargaBeli.VisibleIndex = 3
		'
		'colKategori
		'
		Me.colKategori.Caption = "Kategori"
		Me.colKategori.FieldName = "Kategori.Nama"
		Me.colKategori.Name = "colKategori"
		Me.colKategori.Visible = True
		Me.colKategori.VisibleIndex = 3
		'
		'btnLokasi
		'
		Me.btnLokasi.Caption = "Lokasi Barang"
		Me.btnLokasi.Glyph = CType(resources.GetObject("btnLokasi.Glyph"), System.Drawing.Image)
		Me.btnLokasi.Id = 17
		Me.btnLokasi.LargeGlyph = CType(resources.GetObject("btnLokasi.LargeGlyph"), System.Drawing.Image)
		Me.btnLokasi.Name = "btnLokasi"
		'
		'colFeeAgen
		'
		Me.colFeeAgen.Caption = "Fee Agen"
		Me.colFeeAgen.FieldName = "FeeAgen"
		Me.colFeeAgen.Name = "colFeeAgen"
		'
		'colTipeBarang
		'
		Me.colTipeBarang.Caption = "Tipe"
		Me.colTipeBarang.FieldName = "TipeBarang"
		Me.colTipeBarang.Name = "colTipeBarang"
		'
		'btnImporData
		'
		Me.btnImporData.Caption = "Impor Barang"
		Me.btnImporData.Glyph = CType(resources.GetObject("btnImporData.Glyph"), System.Drawing.Image)
		Me.btnImporData.Id = 18
		Me.btnImporData.LargeGlyph = CType(resources.GetObject("btnImporData.LargeGlyph"), System.Drawing.Image)
		Me.btnImporData.Name = "btnImporData"
		'
		'BarSubItem1
		'
		Me.BarSubItem1.Caption = "Impor Data"
		Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
		Me.BarSubItem1.Id = 19
		Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
		Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImporData, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImporAssembly, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.BarSubItem1.Name = "BarSubItem1"
		'
		'btnImporAssembly
		'
		Me.btnImporAssembly.Caption = "Impor Assembly"
		Me.btnImporAssembly.Glyph = CType(resources.GetObject("btnImporAssembly.Glyph"), System.Drawing.Image)
		Me.btnImporAssembly.Id = 20
		Me.btnImporAssembly.LargeGlyph = CType(resources.GetObject("btnImporAssembly.LargeGlyph"), System.Drawing.Image)
		Me.btnImporAssembly.Name = "btnImporAssembly"
		'
		'UI_Barang
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(1147, 566)
		Me.Name = "UI_Barang"
		Me.Text = "Master Data Item"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJenis As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLastPurchase As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPajakIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPajakOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStockCurrent As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJenisBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCustom1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCustom2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCustom3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCustom4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCustom5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colHargaJual1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaJual2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaJual3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaJual4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaJual5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaHPP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaPendapatanDiskon As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaBiayaDiskon As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaPendapatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaReturPembelian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaReturPenjualan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaPersediaan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
 Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
 Friend WithEvents colHargaBeli As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colKategori As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnLokasi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colFeeAgen As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTipeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnImporData As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
	Friend WithEvents btnImporAssembly As DevExpress.XtraBars.BarButtonItem
End Class
