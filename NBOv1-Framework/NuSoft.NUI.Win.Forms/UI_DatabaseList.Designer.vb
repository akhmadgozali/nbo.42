<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_DatabaseList
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
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaPerusahaan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaAlias = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaDatabase = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAktif = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NPO.SSystem.Database)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNamaPerusahaan, Me.colNamaAlias, Me.colNamaDatabase, Me.colAktif, Me.collast_date, Me.collast_modified})
    Me.xGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
    Me.xGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Size = New System.Drawing.Size(759, 0)
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    Me.colId.Visible = True
    Me.colId.VisibleIndex = 0
    '
    'colNamaPerusahaan
    '
    Me.colNamaPerusahaan.FieldName = "NamaPerusahaan"
    Me.colNamaPerusahaan.Name = "colNamaPerusahaan"
    Me.colNamaPerusahaan.Visible = True
    Me.colNamaPerusahaan.VisibleIndex = 1
    '
    'colNamaAlias
    '
    Me.colNamaAlias.FieldName = "NamaAlias"
    Me.colNamaAlias.Name = "colNamaAlias"
    Me.colNamaAlias.Visible = True
    Me.colNamaAlias.VisibleIndex = 2
    '
    'colNamaDatabase
    '
    Me.colNamaDatabase.FieldName = "NamaDatabase"
    Me.colNamaDatabase.Name = "colNamaDatabase"
    Me.colNamaDatabase.Visible = True
    Me.colNamaDatabase.VisibleIndex = 3
    '
    'colAktif
    '
    Me.colAktif.FieldName = "Aktif"
    Me.colAktif.Name = "colAktif"
    Me.colAktif.Visible = True
    Me.colAktif.VisibleIndex = 4
    '
    'collast_date
    '
    Me.collast_date.FieldName = "last_date"
    Me.collast_date.Name = "collast_date"
    '
    'collast_modified
    '
    Me.collast_modified.FieldName = "last_modified"
    Me.collast_modified.Name = "collast_modified"
    '
    'UI_DatabaseList
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_DatabaseList"
    Me.Text = "Daftar Database"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaPerusahaan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaAlias As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaDatabase As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAktif As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
End Class
