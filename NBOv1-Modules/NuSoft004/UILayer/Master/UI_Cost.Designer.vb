<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Cost
  Inherits Core.Win.Forms.GridBinding

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
    Me.components = New System.ComponentModel.Container()
    Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCoaIncome = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCoaIncomeRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.xpCOA = New DevExpress.Xpo.XPCollection(Me.components)
    Me.colCoaCost = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCoaCostRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colCoaIncomeRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCOA, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colCoaCostRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colCoaIncomeRepo, Me.colCoaCostRepo})
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.BiayaLain)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colNama, Me.colCoaIncome, Me.GridColumn1, Me.colCoaCost, Me.GridColumn2})
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
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
    Me.colCode.Caption = "Kode"
    Me.colCode.FieldName = "Kode"
    Me.colCode.Name = "colCode"
    Me.colCode.Visible = True
    Me.colCode.VisibleIndex = 0
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    '
    'colCoaIncome
    '
    Me.colCoaIncome.Caption = "Pendapatan"
    Me.colCoaIncome.ColumnEdit = Me.colCoaIncomeRepo
    Me.colCoaIncome.FieldName = "CoaPendapatan!"
    Me.colCoaIncome.Name = "colCoaIncome"
    Me.colCoaIncome.Visible = True
    Me.colCoaIncome.VisibleIndex = 2
    '
    'colCoaIncomeRepo
    '
    Me.colCoaIncomeRepo.AutoHeight = False
    Me.colCoaIncomeRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colCoaIncomeRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.colCoaIncomeRepo.DataSource = Me.xpCOA
    Me.colCoaIncomeRepo.DisplayMember = "Kode"
    Me.colCoaIncomeRepo.Name = "colCoaIncomeRepo"
    Me.colCoaIncomeRepo.NullText = "<Pilih COA>"
    Me.colCoaIncomeRepo.ValueMember = "This"
    '
    'xpCOA
    '
    Me.xpCOA.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa)
    '
    'colCoaCost
    '
    Me.colCoaCost.Caption = "Biaya"
    Me.colCoaCost.ColumnEdit = Me.colCoaCostRepo
    Me.colCoaCost.FieldName = "CoaCost!"
    Me.colCoaCost.Name = "colCoaCost"
    Me.colCoaCost.Visible = True
    Me.colCoaCost.VisibleIndex = 4
    '
    'colCoaCostRepo
    '
    Me.colCoaCostRepo.AutoHeight = False
    Me.colCoaCostRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colCoaCostRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.colCoaCostRepo.DataSource = Me.xpCOA
    Me.colCoaCostRepo.DisplayMember = "Kode"
    Me.colCoaCostRepo.Name = "colCoaCostRepo"
    Me.colCoaCostRepo.NullText = "<Pilih COA>"
    Me.colCoaCostRepo.ValueMember = "This"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Pendapatan"
    Me.GridColumn1.FieldName = "CoaPendapatan.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowEdit = False
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 3
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Biaya"
    Me.GridColumn2.FieldName = "CoaCost.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.AllowEdit = False
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 5
    '
    'UI_Cost
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_Cost"
    Me.Text = "Master Data Biaya Lain"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colCoaIncomeRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCOA, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colCoaCostRepo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiPajak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaIncome As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaCost As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaIncomeRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colCoaCostRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents xpCOA As DevExpress.Xpo.XPCollection
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
