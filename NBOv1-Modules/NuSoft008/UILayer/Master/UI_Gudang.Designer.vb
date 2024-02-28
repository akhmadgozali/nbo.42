<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Gudang
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
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xpCol.ObjectType = GetType(Persistent.Gudang)
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colName, Me.colAddress, Me.colTelp, Me.colFax})
        Me.xGridView.OptionsCustomization.AllowGroup = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
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
        'colName
        '
        Me.colName.Caption = "Nama"
        Me.colName.FieldName = "Nama"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        '
        'colAddress
        '
        Me.colAddress.Caption = "Alamat"
        Me.colAddress.FieldName = "Alamat"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 2
        '
        'colTelp
        '
        Me.colTelp.Caption = "No Telp"
        Me.colTelp.FieldName = "NoTelp"
        Me.colTelp.Name = "colTelp"
        Me.colTelp.Visible = True
        Me.colTelp.VisibleIndex = 3
        '
        'colFax
        '
        Me.colFax.Caption = "No Fax"
        Me.colFax.FieldName = "NoFax"
        Me.colFax.Name = "colFax"
        Me.colFax.Visible = True
        Me.colFax.VisibleIndex = 4
        '
        'UI_Gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(759, 395)
        Me.Name = "UI_Gudang"
        Me.Text = "Master Data Gudang"
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
    Friend WithEvents colNoTelp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
End Class
