<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xMesitechVerifikasiJurnal2
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xMesitechVerifikasiJurnal2))
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatusRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colStatusRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colStatusRepo})
    '
    'xpCol
    '
    Me.xpCol.DisplayableProperties = resources.GetString("xpCol.DisplayableProperties")
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.xMesitechGLMain)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTanggal, Me.colKode, Me.GridColumn1, Me.colUraian, Me.colSaldo, Me.colStatus, Me.colcreated_date, Me.colcreated_user})
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowGroupPanel = False
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTanggal, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.OptionsColumn.AllowEdit = False
    Me.colTanggal.OptionsColumn.ReadOnly = True
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 0
    '
    'colKode
    '
    Me.colKode.Caption = "No Bukti"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.OptionsColumn.AllowEdit = False
    Me.colKode.OptionsColumn.ReadOnly = True
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 1
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kontak"
    Me.GridColumn1.FieldName = "Kontak.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowEdit = False
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.OptionsColumn.AllowEdit = False
    Me.colUraian.OptionsColumn.ReadOnly = True
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 3
    '
    'colSaldo
    '
    Me.colSaldo.Caption = "Total Transaksi"
    Me.colSaldo.FieldName = "Saldo"
    Me.colSaldo.Name = "colSaldo"
    Me.colSaldo.OptionsColumn.AllowEdit = False
    Me.colSaldo.OptionsColumn.ReadOnly = True
    Me.colSaldo.Visible = True
    Me.colSaldo.VisibleIndex = 4
    '
    'colcreated_date
    '
    Me.colcreated_date.Caption = "Tanggal Input"
    Me.colcreated_date.FieldName = "created_date"
    Me.colcreated_date.Name = "colcreated_date"
    Me.colcreated_date.OptionsColumn.AllowEdit = False
    Me.colcreated_date.OptionsColumn.ReadOnly = True
    Me.colcreated_date.Visible = True
    Me.colcreated_date.VisibleIndex = 6
    '
    'colcreated_user
    '
    Me.colcreated_user.Caption = "User Input"
    Me.colcreated_user.FieldName = "created_user"
    Me.colcreated_user.Name = "colcreated_user"
    Me.colcreated_user.Visible = True
    Me.colcreated_user.VisibleIndex = 7
    '
    'colStatus
    '
    Me.colStatus.Caption = "Status"
    Me.colStatus.ColumnEdit = Me.colStatusRepo
    Me.colStatus.FieldName = "Status"
    Me.colStatus.Name = "colStatus"
    Me.colStatus.Visible = True
    Me.colStatus.VisibleIndex = 5
    '
    'colStatusRepo
    '
    Me.colStatusRepo.AutoHeight = False
    Me.colStatusRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colStatusRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Status")})
    Me.colStatusRepo.DisplayMember = "Value"
    Me.colStatusRepo.Name = "colStatusRepo"
    Me.colStatusRepo.NullText = "<Status>"
    Me.colStatusRepo.ValueMember = "Key"
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'xMesitechVerifikasiJurnal2
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "xMesitechVerifikasiJurnal2"
    Me.Text = "Verifikasi Jurnal"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colStatusRepo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatusRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
End Class
