<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x_Login
  Inherits DevExpress.XtraEditors.XtraForm

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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.lblVersi = New DevExpress.XtraEditors.LabelControl()
    Me.Pic2 = New System.Windows.Forms.PictureBox()
    Me.Pic1 = New System.Windows.Forms.PictureBox()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.btnSetting = New DevExpress.XtraEditors.SimpleButton()
    Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
    Me.btnKeluar = New DevExpress.XtraEditors.SimpleButton()
    Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtUser = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.Panel1.SuspendLayout()
    CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.lblVersi)
    Me.Panel1.Controls.Add(Me.Pic2)
    Me.Panel1.Controls.Add(Me.Pic1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(391, 65)
    Me.Panel1.TabIndex = 0
    '
    'lblVersi
    '
    Me.lblVersi.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVersi.Appearance.ForeColor = System.Drawing.Color.Navy
    Me.lblVersi.Location = New System.Drawing.Point(8, 46)
    Me.lblVersi.Name = "lblVersi"
    Me.lblVersi.Size = New System.Drawing.Size(56, 11)
    Me.lblVersi.TabIndex = 0
    Me.lblVersi.Text = "LabelControl1"
    Me.lblVersi.Visible = False
    '
    'Pic2
    '
    Me.Pic2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Pic2.BackColor = System.Drawing.Color.Transparent
    Me.Pic2.Location = New System.Drawing.Point(386, 5)
    Me.Pic2.Name = "Pic2"
    Me.Pic2.Size = New System.Drawing.Size(1, 1)
    Me.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.Pic2.TabIndex = 1
    Me.Pic2.TabStop = False
    '
    'Pic1
    '
    Me.Pic1.BackColor = System.Drawing.Color.Transparent
    Me.Pic1.Image = Global.NuSoft.NUI.Win.Forms.My.Resources.Resources.PCL1
    Me.Pic1.Location = New System.Drawing.Point(5, 5)
    Me.Pic1.Name = "Pic1"
    Me.Pic1.Size = New System.Drawing.Size(169, 52)
    Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.Pic1.TabIndex = 0
    Me.Pic1.TabStop = False
    '
    'PanelControl1
    '
    Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.PanelControl1.Controls.Add(Me.btnSetting)
    Me.PanelControl1.Controls.Add(Me.btnLogin)
    Me.PanelControl1.Controls.Add(Me.btnKeluar)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.PanelControl1.Location = New System.Drawing.Point(0, 182)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(391, 57)
    Me.PanelControl1.TabIndex = 2
    '
    'btnSetting
    '
    Me.btnSetting.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
    Me.btnSetting.Appearance.Options.UseForeColor = True
    Me.btnSetting.Location = New System.Drawing.Point(12, 15)
    Me.btnSetting.Name = "btnSetting"
    Me.btnSetting.Size = New System.Drawing.Size(87, 26)
    Me.btnSetting.TabIndex = 2
    Me.btnSetting.Text = "&Setting"
    '
    'btnLogin
    '
    Me.btnLogin.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btnLogin.Appearance.Options.UseForeColor = True
    Me.btnLogin.Location = New System.Drawing.Point(199, 15)
    Me.btnLogin.Name = "btnLogin"
    Me.btnLogin.Size = New System.Drawing.Size(87, 26)
    Me.btnLogin.TabIndex = 0
    Me.btnLogin.Text = "&Login"
    '
    'btnKeluar
    '
    Me.btnKeluar.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btnKeluar.Appearance.Options.UseForeColor = True
    Me.btnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnKeluar.Location = New System.Drawing.Point(292, 15)
    Me.btnKeluar.Name = "btnKeluar"
    Me.btnKeluar.Size = New System.Drawing.Size(87, 26)
    Me.btnKeluar.TabIndex = 1
    Me.btnKeluar.Text = "&Keluar"
    '
    'PanelControl2
    '
    Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.PanelControl2.Controls.Add(Me.GroupBox1)
    Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl2.Location = New System.Drawing.Point(0, 65)
    Me.PanelControl2.Name = "PanelControl2"
    Me.PanelControl2.Size = New System.Drawing.Size(391, 117)
    Me.PanelControl2.TabIndex = 1
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.txtPassword)
    Me.GroupBox1.Controls.Add(Me.LabelControl2)
    Me.GroupBox1.Controls.Add(Me.txtUser)
    Me.GroupBox1.Controls.Add(Me.LabelControl1)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(367, 103)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "   Informasi Login   "
    '
    'txtPassword
    '
    Me.txtPassword.Location = New System.Drawing.Point(101, 57)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtPassword.Size = New System.Drawing.Size(240, 20)
    Me.txtPassword.TabIndex = 1
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(20, 60)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
    Me.LabelControl2.TabIndex = 3
    Me.LabelControl2.Text = "Password"
    '
    'txtUser
    '
    Me.txtUser.Location = New System.Drawing.Point(101, 31)
    Me.txtUser.Name = "txtUser"
    Me.txtUser.Size = New System.Drawing.Size(240, 20)
    Me.txtUser.TabIndex = 0
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(20, 34)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
    Me.LabelControl1.TabIndex = 2
    Me.LabelControl1.Text = "User ID"
    '
    'x_Login
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnKeluar
    Me.ClientSize = New System.Drawing.Size(391, 239)
    Me.ControlBox = False
    Me.Controls.Add(Me.PanelControl2)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.PanelControl1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "x_Login"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " "
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl2.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Pic2 As System.Windows.Forms.PictureBox
  Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
  Friend WithEvents lblVersi As DevExpress.XtraEditors.LabelControl
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnKeluar As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnSetting As DevExpress.XtraEditors.SimpleButton
End Class
