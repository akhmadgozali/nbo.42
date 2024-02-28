<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Setting
  Inherits DevExpress.XtraEditors.XtraForm

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
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.btnCekUpdate = New DevExpress.XtraEditors.SimpleButton()
    Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
    Me.xTree = New DevExpress.XtraTreeList.TreeList()
    Me.treeFileName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.treeCRC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.xTree, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PanelControl1
    '
    Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.PanelControl1.Controls.Add(Me.btnCekUpdate)
    Me.PanelControl1.Controls.Add(Me.btnOK)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.PanelControl1.Location = New System.Drawing.Point(0, 332)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(322, 49)
    Me.PanelControl1.TabIndex = 4
    '
    'btnCekUpdate
    '
    Me.btnCekUpdate.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btnCekUpdate.Appearance.Options.UseForeColor = True
    Me.btnCekUpdate.Location = New System.Drawing.Point(12, 12)
    Me.btnCekUpdate.Name = "btnCekUpdate"
    Me.btnCekUpdate.Size = New System.Drawing.Size(87, 26)
    Me.btnCekUpdate.TabIndex = 0
    Me.btnCekUpdate.Text = "&Cek Update"
    '
    'btnOK
    '
    Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnOK.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btnOK.Appearance.Options.UseForeColor = True
    Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnOK.Location = New System.Drawing.Point(221, 12)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(87, 26)
    Me.btnOK.TabIndex = 1
    Me.btnOK.Text = "&OK"
    '
    'xTree
    '
    Me.xTree.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeFileName, Me.treeCRC})
    Me.xTree.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xTree.Location = New System.Drawing.Point(0, 0)
    Me.xTree.Name = "xTree"
    Me.xTree.OptionsPrint.UsePrintStyles = True
    Me.xTree.OptionsView.ShowCheckBoxes = True
    Me.xTree.Size = New System.Drawing.Size(322, 332)
    Me.xTree.TabIndex = 5
    '
    'treeFileName
    '
    Me.treeFileName.Caption = "Pilih file report yang akan disinkronisasi"
    Me.treeFileName.FieldName = "Name"
    Me.treeFileName.MinWidth = 120
    Me.treeFileName.Name = "treeFileName"
    Me.treeFileName.OptionsColumn.AllowEdit = False
    Me.treeFileName.OptionsColumn.ReadOnly = True
    Me.treeFileName.Visible = True
    Me.treeFileName.VisibleIndex = 0
    Me.treeFileName.Width = 120
    '
    'treeCRC
    '
    Me.treeCRC.Caption = "TreeCRC"
    Me.treeCRC.FieldName = "hash"
    Me.treeCRC.Name = "treeCRC"
    '
    'Frm_Setting
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(322, 381)
    Me.Controls.Add(Me.xTree)
    Me.Controls.Add(Me.PanelControl1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Frm_Setting"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Setting Sync"
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.xTree, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents xTree As DevExpress.XtraTreeList.TreeList
  Friend WithEvents treeFileName As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents treeCRC As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents btnCekUpdate As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton

End Class
