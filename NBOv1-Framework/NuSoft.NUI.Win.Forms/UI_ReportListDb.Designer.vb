<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ReportListDb
  Inherits Core.Win.Forms.DialogForm

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
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xpReport = New DevExpress.Xpo.XPCollection(Me.components)
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDatabase = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDatabaseRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.xpDb = New DevExpress.Xpo.XPCollection(Me.components)
		Me.colFileName = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colReport = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.Session1 = New DevExpress.Xpo.Session(Me.components)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpReport, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colDatabaseRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpDb, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Session1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn1
		'
		Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btn1.Appearance.Options.UseForeColor = True
		Me.btn1.Location = New System.Drawing.Point(12, 11)
		'
		'btn2
		'
		Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
		Me.btn2.Appearance.Options.UseForeColor = True
		Me.btn2.Location = New System.Drawing.Point(105, 11)
		'
		'PanelControl1
		'
		Me.PanelControl1.Location = New System.Drawing.Point(0, 278)
		Me.PanelControl1.Size = New System.Drawing.Size(595, 49)
		'
		'xGrid
		'
		Me.xGrid.DataSource = Me.xpReport
		Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xGrid.Location = New System.Drawing.Point(0, 0)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colDatabaseRepo})
		Me.xGrid.Size = New System.Drawing.Size(595, 278)
		Me.xGrid.TabIndex = 4
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xpReport
		'
		Me.xpReport.ObjectType = GetType(NuSoft.NPO.SSystem.LaporanPerDatabase)
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDatabase, Me.colFileName, Me.colKeterangan, Me.colReport})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'colDatabase
		'
		Me.colDatabase.ColumnEdit = Me.colDatabaseRepo
		Me.colDatabase.FieldName = "Database!"
		Me.colDatabase.Name = "colDatabase"
		Me.colDatabase.Visible = True
		Me.colDatabase.VisibleIndex = 0
		'
		'colDatabaseRepo
		'
		Me.colDatabaseRepo.AutoHeight = False
		Me.colDatabaseRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colDatabaseRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaAlias", "Nama Alias", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
		Me.colDatabaseRepo.DataSource = Me.xpDb
		Me.colDatabaseRepo.DisplayMember = "NamaAlias"
		Me.colDatabaseRepo.Name = "colDatabaseRepo"
		Me.colDatabaseRepo.NullText = "<Pilih Database>"
		Me.colDatabaseRepo.ValueMember = "This"
		'
		'xpDb
		'
		Me.xpDb.ObjectType = GetType(NuSoft.NPO.SSystem.Database)
		'
		'colFileName
		'
		Me.colFileName.FieldName = "NamaFile"
		Me.colFileName.Name = "colFileName"
		Me.colFileName.Visible = True
		Me.colFileName.VisibleIndex = 1
		'
		'colKeterangan
		'
		Me.colKeterangan.FieldName = "Keterangan"
		Me.colKeterangan.Name = "colKeterangan"
		Me.colKeterangan.Visible = True
		Me.colKeterangan.VisibleIndex = 2
		'
		'colReport
		'
		Me.colReport.Caption = "Report"
		Me.colReport.FieldName = "Report!"
		Me.colReport.Name = "colReport"
		'
		'Session1
		'
		Me.Session1.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
		Me.Session1.TrackPropertiesModifications = False
		'
		'UI_ReportListDb
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(595, 327)
		Me.Controls.Add(Me.xGrid)
		Me.Name = "UI_ReportListDb"
		Me.Text = "Laporan Per Database"
		Me.Controls.SetChildIndex(Me.PanelControl1, 0)
		Me.Controls.SetChildIndex(Me.xGrid, 0)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpReport, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colDatabaseRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpDb, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Session1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents Session1 As DevExpress.Xpo.Session
  Friend WithEvents xpReport As DevExpress.Xpo.XPCollection
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDatabase As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colFileName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xpDb As DevExpress.Xpo.XPCollection
  Friend WithEvents colDatabaseRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colReport As DevExpress.XtraGrid.Columns.GridColumn
End Class
