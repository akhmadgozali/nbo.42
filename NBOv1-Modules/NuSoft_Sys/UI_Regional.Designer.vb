<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Regional
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
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKota = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPropinsi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodePos = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.Size = New System.Drawing.Size(765, 374)
    '
    'xpCol
    '
		Me.xpCol.ObjectType = GetType(NuSoft.NPO.Modules.ModSys.Regional)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKode, Me.colNama, Me.colAlamat, Me.colKota, Me.colPropinsi, Me.colKodePos, Me.colKeterangan})
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
    Me.colId.Width = 40
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 1
    Me.colKode.Width = 80
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 2
    Me.colNama.Width = 150
    '
    'colAlamat
    '
    Me.colAlamat.FieldName = "Alamat"
    Me.colAlamat.Name = "colAlamat"
    Me.colAlamat.Visible = True
    Me.colAlamat.VisibleIndex = 3
    '
    'colKota
    '
    Me.colKota.FieldName = "Kota"
    Me.colKota.Name = "colKota"
    Me.colKota.Visible = True
    Me.colKota.VisibleIndex = 4
    '
    'colPropinsi
    '
    Me.colPropinsi.FieldName = "Propinsi"
    Me.colPropinsi.Name = "colPropinsi"
    Me.colPropinsi.Visible = True
    Me.colPropinsi.VisibleIndex = 5
    '
    'colKodePos
    '
    Me.colKodePos.FieldName = "KodePos"
    Me.colKodePos.Name = "colKodePos"
    Me.colKodePos.Visible = True
    Me.colKodePos.VisibleIndex = 6
    '
    'colKeterangan
    '
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 7
    '
    'UI_Regional
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 401)
    Me.Name = "UI_Regional"
    Me.Text = "Regional"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKota As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPropinsi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodePos As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
End Class
