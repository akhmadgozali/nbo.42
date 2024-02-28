<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Proyek
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
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoKontrak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTglAkhir = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTglAwal = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft008.Persistent.Proyek)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colNama, Me.colId, Me.colNoKontrak, Me.colTglAkhir, Me.colTglAwal})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsCustomization.AllowGroup = False
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
    'colKode
    '
    Me.colKode.Caption = "Kode"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colNoKontrak
    '
    Me.colNoKontrak.FieldName = "NoKontrak"
    Me.colNoKontrak.Name = "colNoKontrak"
    Me.colNoKontrak.Visible = True
    Me.colNoKontrak.VisibleIndex = 2
    '
    'colTglAkhir
    '
    Me.colTglAkhir.FieldName = "TglAkhir"
    Me.colTglAkhir.Name = "colTglAkhir"
    Me.colTglAkhir.Visible = True
    Me.colTglAkhir.VisibleIndex = 3
    '
    'colTglAwal
    '
    Me.colTglAwal.FieldName = "TglAwal"
    Me.colTglAwal.Name = "colTglAwal"
    Me.colTglAwal.Visible = True
    Me.colTglAwal.VisibleIndex = 4
    '
    'UI_Proyek
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_Proyek"
    Me.Text = "Master Proyek"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoKontrak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTglAkhir As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTglAwal As DevExpress.XtraGrid.Columns.GridColumn
End Class
