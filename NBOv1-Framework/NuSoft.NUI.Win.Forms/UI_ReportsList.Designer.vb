<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ReportsList
  Inherits Core.Win.Forms.GridBinding

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colParent = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaFile = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAktif = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUrutan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDb = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDbRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDbRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colDbRepo})
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NPO.SSystem.Laporan)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.GridColumn2, Me.colKode, Me.colNama, Me.colParent, Me.colNamaFile, Me.colAktif, Me.colUrutan, Me.colDb})
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    Me.colId.Visible = True
    Me.colId.VisibleIndex = 0
    Me.colId.Width = 84
    '
    'GridColumn2
    '
    Me.GridColumn2.FieldName = "Modul!Key"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 84
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 2
    Me.colKode.Width = 84
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 3
    Me.colNama.Width = 84
    '
    'colParent
    '
    Me.colParent.FieldName = "Induk!Key"
    Me.colParent.Name = "colParent"
    Me.colParent.Visible = True
    Me.colParent.VisibleIndex = 4
    Me.colParent.Width = 84
    '
    'colNamaFile
    '
    Me.colNamaFile.FieldName = "NamaFile"
    Me.colNamaFile.Name = "colNamaFile"
    Me.colNamaFile.Visible = True
    Me.colNamaFile.VisibleIndex = 5
    Me.colNamaFile.Width = 84
    '
    'colAktif
    '
    Me.colAktif.FieldName = "Aktif"
    Me.colAktif.Name = "colAktif"
    Me.colAktif.Visible = True
    Me.colAktif.VisibleIndex = 6
    Me.colAktif.Width = 84
    '
    'colUrutan
    '
    Me.colUrutan.FieldName = "Urutan"
    Me.colUrutan.Name = "colUrutan"
    Me.colUrutan.Visible = True
    Me.colUrutan.VisibleIndex = 7
    Me.colUrutan.Width = 84
    '
    'colDb
    '
    Me.colDb.Caption = "Database"
    Me.colDb.ColumnEdit = Me.colDbRepo
    Me.colDb.FieldName = "colDb"
    Me.colDb.Name = "colDb"
    Me.colDb.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
    Me.colDb.Visible = True
    Me.colDb.VisibleIndex = 8
    Me.colDb.Width = 50
    '
    'colDbRepo
    '
    Me.colDbRepo.AutoHeight = False
    Me.colDbRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.colDbRepo.Name = "colDbRepo"
    Me.colDbRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
    '
    'UI_ReportsList
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_ReportsList"
    Me.Text = "Daftar Laporan"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDbRepo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colParent As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaFile As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAktif As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUrutan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDbRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents colDb As DevExpress.XtraGrid.Columns.GridColumn
End Class
