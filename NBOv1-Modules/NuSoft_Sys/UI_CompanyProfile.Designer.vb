<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_CompanyProfile
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
    Me.xProp = New DevExpress.XtraVerticalGrid.PropertyGridControl()
    Me.NamaPerusahaan = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    Me.NamaAlias = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    Me.BidangUsaha = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    Me.Slogan = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    Me.Alamat1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    Me.Alamat2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    Me.KodePos = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    Me.NoTelp = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    Me.NoFax = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.xProp, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(362, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(455, 11)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 328)
    Me.PanelControl1.Size = New System.Drawing.Size(554, 49)
    '
    'xProp
    '
    Me.xProp.Cursor = System.Windows.Forms.Cursors.SizeNS
    Me.xProp.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xProp.Location = New System.Drawing.Point(0, 0)
    Me.xProp.Name = "xProp"
    Me.xProp.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort
    Me.xProp.RecordWidth = 153
    Me.xProp.RowHeaderWidth = 47
    Me.xProp.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.NamaPerusahaan, Me.NamaAlias, Me.BidangUsaha, Me.Slogan, Me.Alamat1, Me.Alamat2, Me.KodePos, Me.NoTelp, Me.NoFax})
    Me.xProp.Size = New System.Drawing.Size(554, 328)
    Me.xProp.TabIndex = 4
    '
    'NamaPerusahaan
    '
    Me.NamaPerusahaan.Height = 17
    Me.NamaPerusahaan.Name = "NamaPerusahaan"
    Me.NamaPerusahaan.Properties.Caption = "Nama Perusahaan"
    Me.NamaPerusahaan.Properties.FieldName = "NamaPerusahaan"
    Me.NamaPerusahaan.Properties.ReadOnly = False
    '
    'NamaAlias
    '
    Me.NamaAlias.Name = "NamaAlias"
    Me.NamaAlias.Properties.Caption = "Nama Alias"
    Me.NamaAlias.Properties.FieldName = "NamaAlias"
    '
    'BidangUsaha
    '
    Me.BidangUsaha.Name = "BidangUsaha"
    Me.BidangUsaha.Properties.Caption = "Bidang Usaha"
    Me.BidangUsaha.Properties.FieldName = "BidangUsaha"
    '
    'Slogan
    '
    Me.Slogan.Name = "Slogan"
    Me.Slogan.Properties.Caption = "Slogan"
    Me.Slogan.Properties.FieldName = "Slogan"
    '
    'Alamat1
    '
    Me.Alamat1.Name = "Alamat1"
    Me.Alamat1.Properties.Caption = "Alamat1"
    Me.Alamat1.Properties.FieldName = "Alamat1"
    '
    'Alamat2
    '
    Me.Alamat2.Name = "Alamat2"
    Me.Alamat2.Properties.Caption = "Alamat2"
    Me.Alamat2.Properties.FieldName = "Alamat2"
    '
    'KodePos
    '
    Me.KodePos.Name = "KodePos"
    Me.KodePos.Properties.Caption = "KodePos"
    Me.KodePos.Properties.FieldName = "KodePos"
    '
    'NoTelp
    '
    Me.NoTelp.Name = "NoTelp"
    Me.NoTelp.Properties.Caption = "NoTelp"
    Me.NoTelp.Properties.FieldName = "NoTelp"
    '
    'NoFax
    '
    Me.NoFax.Name = "NoFax"
    Me.NoFax.Properties.Caption = "NoFax"
    Me.NoFax.Properties.FieldName = "NoFax"
    '
    'UI_CompanyProfile
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(554, 377)
    Me.Controls.Add(Me.xProp)
    Me.Name = "UI_CompanyProfile"
    Me.Text = "Profil Perusahaan"
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.xProp, 0)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.xProp, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents xProp As DevExpress.XtraVerticalGrid.PropertyGridControl
  Friend WithEvents NamaPerusahaan As DevExpress.XtraVerticalGrid.Rows.EditorRow
  Friend WithEvents NamaAlias As DevExpress.XtraVerticalGrid.Rows.EditorRow
  Friend WithEvents BidangUsaha As DevExpress.XtraVerticalGrid.Rows.EditorRow
  Friend WithEvents Slogan As DevExpress.XtraVerticalGrid.Rows.EditorRow
  Friend WithEvents Alamat1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
  Friend WithEvents Alamat2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
  Friend WithEvents KodePos As DevExpress.XtraVerticalGrid.Rows.EditorRow
  Friend WithEvents NoTelp As DevExpress.XtraVerticalGrid.Rows.EditorRow
  Friend WithEvents NoFax As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class
