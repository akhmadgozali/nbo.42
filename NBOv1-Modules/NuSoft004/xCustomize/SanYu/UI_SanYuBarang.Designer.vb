<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanYuBarang
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SanYuBarang))
    Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJenisBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colHargaBeli = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKategori = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTipeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnReset = New DevExpress.XtraBars.BarButtonItem()
    Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colInDiameter = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colOutDiameter = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKITE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.btnImporExcel = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemCheckEdit1})
    '
    'xpCol
    '
    Me.xpCol.DisplayableProperties = "This;created_date;created_user;last_date;last_modified;Id;Kode;Nama;Satuan.Kode;J" &
    "enis;TipeBarang;Kategori.Nama;Thickness;TipeBarang;KITE"
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.SanYu_Barang)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btSaveLayout, Me.BarButtonItem1, Me.btnReset, Me.btnImporExcel})
    Me.barMan.MaxItemId = 19
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKategori, Me.colCode, Me.colName, Me.colSatuan2, Me.colHargaBeli, Me.colJenisBarang, Me.colTipeBarang, Me.colThickness, Me.colWeight, Me.colLength, Me.colInDiameter, Me.colOutDiameter, Me.colKITE})
    Me.xGridView.GroupCount = 2
    Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTipeBarang, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKategori, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKITE, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImporExcel, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
    Me.colCode.VisibleIndex = 1
    '
    'colName
    '
    Me.colName.Caption = "Nama"
    Me.colName.FieldName = "Nama"
    Me.colName.Name = "colName"
    Me.colName.Visible = True
    Me.colName.VisibleIndex = 2
    '
    'colSatuan2
    '
    Me.colSatuan2.Caption = "Satuan"
    Me.colSatuan2.FieldName = "Satuan.Kode"
    Me.colSatuan2.Name = "colSatuan2"
    Me.colSatuan2.Visible = True
    Me.colSatuan2.VisibleIndex = 3
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
    'btSaveLayout
    '
    Me.btSaveLayout.Caption = "Save Layout"
    Me.btSaveLayout.Glyph = CType(resources.GetObject("btSaveLayout.Glyph"), System.Drawing.Image)
    Me.btSaveLayout.Id = 15
    Me.btSaveLayout.LargeGlyph = CType(resources.GetObject("btSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btSaveLayout.Name = "btSaveLayout"
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
    Me.colHargaBeli.VisibleIndex = 4
    '
    'colKategori
    '
    Me.colKategori.Caption = "Kategori"
    Me.colKategori.FieldName = "Kategori.Nama"
    Me.colKategori.Name = "colKategori"
    '
    'colTipeBarang
    '
    Me.colTipeBarang.Caption = "Tipe"
    Me.colTipeBarang.FieldName = "TipeBarang"
    Me.colTipeBarang.Name = "colTipeBarang"
    Me.colTipeBarang.Visible = True
    Me.colTipeBarang.VisibleIndex = 5
    '
    'btnReset
    '
    Me.btnReset.Caption = "Reset Weight"
    Me.btnReset.Glyph = CType(resources.GetObject("btnReset.Glyph"), System.Drawing.Image)
    Me.btnReset.Id = 17
    Me.btnReset.LargeGlyph = CType(resources.GetObject("btnReset.LargeGlyph"), System.Drawing.Image)
    Me.btnReset.Name = "btnReset"
    Me.btnReset.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'colThickness
    '
    Me.colThickness.FieldName = "Thickness"
    Me.colThickness.Name = "colThickness"
    Me.colThickness.Visible = True
    Me.colThickness.VisibleIndex = 5
    '
    'colWeight
    '
    Me.colWeight.FieldName = "Weight"
    Me.colWeight.Name = "colWeight"
    '
    'colLength
    '
    Me.colLength.FieldName = "Length"
    Me.colLength.Name = "colLength"
    '
    'colInDiameter
    '
    Me.colInDiameter.FieldName = "InDiameter"
    Me.colInDiameter.Name = "colInDiameter"
    '
    'colOutDiameter
    '
    Me.colOutDiameter.FieldName = "OutDiameter"
    Me.colOutDiameter.Name = "colOutDiameter"
    '
    'colKITE
    '
    Me.colKITE.Caption = "Fasilitas"
    Me.colKITE.ColumnEdit = Me.RepositoryItemCheckEdit1
    Me.colKITE.FieldName = "KITE"
    Me.colKITE.Name = "colKITE"
    Me.colKITE.Visible = True
    Me.colKITE.VisibleIndex = 0
    Me.colKITE.Width = 62
    '
    'RepositoryItemCheckEdit1
    '
    Me.RepositoryItemCheckEdit1.AutoHeight = False
    Me.RepositoryItemCheckEdit1.Caption = "Check"
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    '
    'btnImporExcel
    '
    Me.btnImporExcel.Caption = "Impor"
    Me.btnImporExcel.Glyph = CType(resources.GetObject("btnImporExcel.Glyph"), System.Drawing.Image)
    Me.btnImporExcel.Id = 18
    Me.btnImporExcel.LargeGlyph = CType(resources.GetObject("btnImporExcel.LargeGlyph"), System.Drawing.Image)
    Me.btnImporExcel.Name = "btnImporExcel"
    '
    'UI_SanYuBarang
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_SanYuBarang"
    Me.Text = "Master Data Item"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents btSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colHargaBeli As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKategori As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTipeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnReset As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colThickness As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colInDiameter As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colOutDiameter As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKITE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents btnImporExcel As DevExpress.XtraBars.BarButtonItem
End Class
