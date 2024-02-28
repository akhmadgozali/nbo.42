<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SettingCRAkun
	Inherits Core.Win.Forms.InputDialog

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
    Me.treeAkun = New DevExpress.XtraTreeList.TreeList()
    Me.colKode = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colNama = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.treeAkun, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'treeAkun
    '
    Me.treeAkun.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colKode, Me.colNama})
    Me.treeAkun.Dock = System.Windows.Forms.DockStyle.Fill
    Me.treeAkun.KeyFieldName = "This"
    Me.treeAkun.Location = New System.Drawing.Point(0, 0)
    Me.treeAkun.Name = "treeAkun"
    Me.treeAkun.OptionsBehavior.AllowRecursiveNodeChecking = True
    Me.treeAkun.OptionsView.ShowCheckBoxes = True
    Me.treeAkun.ParentFieldName = "Induk!"
    Me.treeAkun.Size = New System.Drawing.Size(501, 354)
    Me.treeAkun.TabIndex = 4
    '
    'colKode
    '
    Me.colKode.Caption = "Kode Akun"
    Me.colKode.FieldName = "Kode"
    Me.colKode.MinWidth = 32
    Me.colKode.Name = "colKode"
    Me.colKode.OptionsColumn.AllowEdit = False
    Me.colKode.OptionsColumn.ReadOnly = True
    Me.colKode.SortOrder = System.Windows.Forms.SortOrder.Ascending
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 50
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.OptionsColumn.AllowEdit = False
    Me.colNama.OptionsColumn.ReadOnly = True
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    Me.colNama.Width = 200
    '
    'UI_SettingCRAkun
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(501, 403)
    Me.Controls.Add(Me.treeAkun)
    Me.Name = "UI_SettingCRAkun"
    Me.Text = "Pilih Akun"
    Me.Controls.SetChildIndex(Me.treeAkun, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.treeAkun, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents treeAkun As DevExpress.XtraTreeList.TreeList
  Friend WithEvents colKode As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colNama As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
