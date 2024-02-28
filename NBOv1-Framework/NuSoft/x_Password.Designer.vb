<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x_Password
  Inherits Core.Win.Forms.DialogForm

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
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.txtUserId = New DevExpress.XtraEditors.TextEdit()
    Me.txtPassOld = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtPassNew = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.txtPassConf = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.txtUserId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPassOld.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPassNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPassConf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(158, 11)
    '
    'btn2
    '
    Me.btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(251, 11)
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(12, 13)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
    Me.LabelControl1.TabIndex = 7
    Me.LabelControl1.Text = "User ID"
    '
    'txtUserId
    '
    Me.txtUserId.Enabled = False
    Me.txtUserId.Location = New System.Drawing.Point(104, 10)
    Me.txtUserId.Name = "txtUserId"
    Me.txtUserId.Size = New System.Drawing.Size(234, 20)
    Me.txtUserId.TabIndex = 0
    '
    'txtPassOld
    '
    Me.txtPassOld.Location = New System.Drawing.Point(104, 36)
    Me.txtPassOld.Name = "txtPassOld"
    Me.txtPassOld.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtPassOld.Size = New System.Drawing.Size(234, 20)
    Me.txtPassOld.TabIndex = 1
    Me.txtPassOld.ToolTip = "Masukkan password lama"
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(12, 39)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
    Me.LabelControl2.TabIndex = 6
    Me.LabelControl2.Text = "Password Lama"
    '
    'txtPassNew
    '
    Me.txtPassNew.Location = New System.Drawing.Point(104, 62)
    Me.txtPassNew.Name = "txtPassNew"
    Me.txtPassNew.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtPassNew.Size = New System.Drawing.Size(234, 20)
    Me.txtPassNew.TabIndex = 2
    Me.txtPassNew.ToolTip = "Masukkan password baru"
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(12, 65)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(71, 13)
    Me.LabelControl3.TabIndex = 5
    Me.LabelControl3.Text = "Password Baru"
    '
    'txtPassConf
    '
    Me.txtPassConf.Location = New System.Drawing.Point(104, 88)
    Me.txtPassConf.Name = "txtPassConf"
    Me.txtPassConf.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtPassConf.Size = New System.Drawing.Size(234, 20)
    Me.txtPassConf.TabIndex = 3
    Me.txtPassConf.ToolTip = "Konfirmasi password baru"
    '
    'LabelControl4
    '
    Me.LabelControl4.Location = New System.Drawing.Point(12, 91)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
    Me.LabelControl4.TabIndex = 4
    Me.LabelControl4.Text = "Konfirmasi"
    '
    'x_Password
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(347, 159)
    Me.Controls.Add(Me.txtPassConf)
    Me.Controls.Add(Me.LabelControl4)
    Me.Controls.Add(Me.txtPassNew)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.txtPassOld)
    Me.Controls.Add(Me.LabelControl2)
    Me.Controls.Add(Me.txtUserId)
    Me.Controls.Add(Me.LabelControl1)
    Me.Name = "x_Password"
    Me.ShowInTaskbar = False
    Me.Text = "Ganti Password"
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.txtUserId, 0)
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.txtPassOld, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.txtPassNew, 0)
    Me.Controls.SetChildIndex(Me.LabelControl4, 0)
    Me.Controls.SetChildIndex(Me.txtPassConf, 0)
    CType(Me.txtUserId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPassOld.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPassNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPassConf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtUserId As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPassOld As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtPassNew As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtPassConf As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
