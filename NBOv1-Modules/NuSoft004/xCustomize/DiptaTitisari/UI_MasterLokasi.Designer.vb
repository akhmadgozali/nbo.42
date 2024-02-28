<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_MasterLokasi
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
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBlok = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKolom = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBaris = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPosisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPosisiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colPosisiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colPosisiRepo})
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.xDiptaMasterLOkasi)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKode, Me.colBlok, Me.colKolom, Me.colBaris, Me.colPosisi})
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
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colBlok
    '
    Me.colBlok.FieldName = "Blok"
    Me.colBlok.Name = "colBlok"
    Me.colBlok.Visible = True
    Me.colBlok.VisibleIndex = 1
    '
    'colKolom
    '
    Me.colKolom.FieldName = "Kolom"
    Me.colKolom.Name = "colKolom"
    Me.colKolom.Visible = True
    Me.colKolom.VisibleIndex = 2
    '
    'colBaris
    '
    Me.colBaris.FieldName = "Baris"
    Me.colBaris.Name = "colBaris"
    Me.colBaris.Visible = True
    Me.colBaris.VisibleIndex = 3
    '
    'colPosisi
    '
    Me.colPosisi.ColumnEdit = Me.colPosisiRepo
    Me.colPosisi.FieldName = "Posisi"
    Me.colPosisi.Name = "colPosisi"
    Me.colPosisi.Visible = True
    Me.colPosisi.VisibleIndex = 4
    '
    'colPosisiRepo
    '
    Me.colPosisiRepo.AutoHeight = False
    Me.colPosisiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colPosisiRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.colPosisiRepo.DisplayMember = "Value"
    Me.colPosisiRepo.Name = "colPosisiRepo"
    Me.colPosisiRepo.NullText = "<Pilih Posisi>"
    Me.colPosisiRepo.ValueMember = "Key"
    '
    'UI_MasterLokasi
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_MasterLokasi"
    Me.Text = "Master Lokasi"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colPosisiRepo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBlok As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKolom As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBaris As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPosisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPosisiRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
