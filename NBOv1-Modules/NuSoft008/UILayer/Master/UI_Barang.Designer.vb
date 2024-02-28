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
  Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Barang))
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
  CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'xGrid
  '
  Me.xGrid.DataSource = Me.xpCol
  Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
  '
  'xpCol
  '
    Me.xpCol.ObjectType = GetType(Persistent.Barang)
  '
  'barMan
  '
  Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btSaveLayout, Me.BarButtonItem1})
  Me.barMan.MaxItemId = 17
  '
  'xGridView
  '
  Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKategori, Me.colCode, Me.colName, Me.colSatuan2, Me.colHargaBeli, Me.colCustom1, Me.colJenisBarang, Me.colCustom2, Me.colCustom3, Me.colCustom4, Me.colCustom5, Me.colHargaJual1, Me.colHargaJual2, Me.colHargaJual3, Me.colHargaJual4, Me.colHargaJual5, Me.colCoaHPP, Me.colCoaPendapatanDiskon, Me.colCoaBiayaDiskon, Me.colCoaPendapatan, Me.colCoaReturPembelian, Me.colCoaReturPenjualan, Me.colCoaPersediaan, Me.collast_date, Me.collast_modified, Me.colcreated_date, Me.colcreated_user})
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
  Me.barMenu.OptionsBar.AllowQuickCustomization = False
  Me.barMenu.OptionsBar.DrawDragBorder = False
  Me.barMenu.OptionsBar.UseWholeRow = True
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
  'UI_Barang
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.ClientSize = New System.Drawing.Size(759, 395)
  Me.Name = "UI_Barang"
  Me.Text = "Master Data Item"
  Me.xpCol = Me.xpCol
  CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
