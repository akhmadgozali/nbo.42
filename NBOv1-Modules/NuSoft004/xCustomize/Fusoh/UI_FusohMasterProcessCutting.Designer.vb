<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohMasterProcessCutting
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohMasterProcessCutting))
		Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btSaveLayout = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.btnReset = New DevExpress.XtraBars.BarButtonItem()
		Me.colDefaultFG = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_ProcessCutting)
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btSaveLayout, Me.BarButtonItem1, Me.btnReset})
		Me.barMan.MaxItemId = 18
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode1, Me.colName, Me.colDefaultFG, Me.colKeterangan, Me.colId})
		Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", Nothing, "  (Record : {0})")})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'barMenu
		'
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'colName
		'
		Me.colName.AppearanceCell.Options.UseTextOptions = True
		Me.colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colName.Caption = "Nama"
		Me.colName.FieldName = "Nama"
		Me.colName.Name = "colName"
		Me.colName.Visible = True
		Me.colName.VisibleIndex = 1
		Me.colName.Width = 250
		'
		'colKode1
		'
		Me.colKode1.Caption = "Kode"
		Me.colKode1.FieldName = "Kode"
		Me.colKode1.Name = "colKode1"
		Me.colKode1.Visible = True
		Me.colKode1.VisibleIndex = 0
		Me.colKode1.Width = 62
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
		'btnReset
		'
		Me.btnReset.Caption = "Reset Weight"
		Me.btnReset.Glyph = CType(resources.GetObject("btnReset.Glyph"), System.Drawing.Image)
		Me.btnReset.Id = 17
		Me.btnReset.LargeGlyph = CType(resources.GetObject("btnReset.LargeGlyph"), System.Drawing.Image)
		Me.btnReset.Name = "btnReset"
		'
		'colDefaultFG
		'
		Me.colDefaultFG.Caption = "Default OP"
		Me.colDefaultFG.FieldName = "DefaultFG"
		Me.colDefaultFG.Name = "colDefaultFG"
		Me.colDefaultFG.Visible = True
		Me.colDefaultFG.VisibleIndex = 2
		Me.colDefaultFG.Width = 80
		'
		'colKeterangan
		'
		Me.colKeterangan.Caption = "Keterangan"
		Me.colKeterangan.FieldName = "Keterangan"
		Me.colKeterangan.Name = "colKeterangan"
		Me.colKeterangan.Visible = True
		Me.colKeterangan.VisibleIndex = 3
		Me.colKeterangan.Width = 349
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'UI_FusohMasterProcessCutting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_FusohMasterProcessCutting"
		Me.Text = "Master Process Cutting"
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
	Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKode1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btSaveLayout As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	Friend WithEvents btnReset As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colDefaultFG As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
End Class
