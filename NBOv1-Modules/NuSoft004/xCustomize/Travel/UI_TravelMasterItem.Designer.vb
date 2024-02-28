<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TravelMasterItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TravelMasterItem))
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatuan2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colHargaBeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHargaJual1 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Barang)
        '
        'barMan
        '
        Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btSaveLayout, Me.BarButtonItem1})
        Me.barMan.MaxItemId = 17
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colCode, Me.colName, Me.colSatuan2, Me.colHargaBeli, Me.colHargaJual1})
        Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsSelection.MultiSelect = True
        Me.xGridView.OptionsView.ShowAutoFilterRow = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
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
        Me.colCode.Width = 150
        '
        'colName
        '
        Me.colName.Caption = "Nama"
        Me.colName.FieldName = "Nama"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        Me.colName.Width = 300
        '
        'colSatuan2
        '
        Me.colSatuan2.Caption = "Satuan"
        Me.colSatuan2.FieldName = "SatuanD.Kode"
        Me.colSatuan2.Name = "colSatuan2"
        Me.colSatuan2.Visible = True
        Me.colSatuan2.VisibleIndex = 2
        Me.colSatuan2.Width = 100
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
        Me.colHargaBeli.DisplayFormat.FormatString = "n0"
        Me.colHargaBeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHargaBeli.FieldName = "LastPurchase"
        Me.colHargaBeli.Name = "colHargaBeli"
        Me.colHargaBeli.Visible = True
        Me.colHargaBeli.VisibleIndex = 3
        Me.colHargaBeli.Width = 92
        '
        'colHargaJual1
        '
        Me.colHargaJual1.Caption = "Harga Jual"
        Me.colHargaJual1.DisplayFormat.FormatString = "n0"
        Me.colHargaJual1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHargaJual1.FieldName = "HargaJual1"
        Me.colHargaJual1.Name = "colHargaJual1"
        Me.colHargaJual1.Visible = True
        Me.colHargaJual1.VisibleIndex = 4
        Me.colHargaJual1.Width = 99
        '
        'UI_TravelMasterItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(759, 395)
        Me.Name = "UI_TravelMasterItem"
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
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colHargaBeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHargaJual1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
