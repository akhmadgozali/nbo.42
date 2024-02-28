<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_MataUang
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
        Me.colIDUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNegaraUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSimbolUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeteranganUang = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft008.Persistent.MataUang)
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDUang, Me.colKodeUang, Me.colNama, Me.colNegaraUang, Me.colSimbolUang, Me.colKeteranganUang})
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsSelection.MultiSelect = True
        '
        'colIDUang
        '
        Me.colIDUang.FieldName = "Id"
        Me.colIDUang.Name = "colIDUang"
        '
        'colKodeUang
        '
        Me.colKodeUang.FieldName = "Kode"
        Me.colKodeUang.Name = "colKodeUang"
        Me.colKodeUang.Visible = True
        Me.colKodeUang.VisibleIndex = 0
        '
        'colNama
        '
        Me.colNama.FieldName = "Nama"
        Me.colNama.Name = "colNama"
        Me.colNama.Visible = True
        Me.colNama.VisibleIndex = 1
        '
        'colNegaraUang
        '
        Me.colNegaraUang.FieldName = "Negara"
        Me.colNegaraUang.Name = "colNegaraUang"
        Me.colNegaraUang.Visible = True
        Me.colNegaraUang.VisibleIndex = 2
        '
        'colSimbolUang
        '
        Me.colSimbolUang.FieldName = "Simbol"
        Me.colSimbolUang.Name = "colSimbolUang"
        Me.colSimbolUang.Visible = True
        Me.colSimbolUang.VisibleIndex = 3
        '
        'colKeteranganUang
        '
        Me.colKeteranganUang.FieldName = "Keterangan"
        Me.colKeteranganUang.Name = "colKeteranganUang"
        Me.colKeteranganUang.Visible = True
        Me.colKeteranganUang.VisibleIndex = 4
        '
        'UI_MataUang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(759, 395)
        Me.Name = "UI_MataUang"
        Me.Text = "Master Data : Uang"
        Me.xpCol = Me.xpCol
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNegara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSimbol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDUang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeUang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNegaraUang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSimbolUang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeteranganUang As DevExpress.XtraGrid.Columns.GridColumn
End Class
