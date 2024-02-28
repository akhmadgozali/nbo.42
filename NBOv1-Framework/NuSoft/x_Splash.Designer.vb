<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x_Splash
  Inherits DevExpress.XtraSplashScreen.SplashScreen

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
    Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
    Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
    Me.txtProgress = New DevExpress.XtraEditors.LabelControl()
    Me.lblCopy = New DevExpress.XtraEditors.LabelControl()
    Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
    CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pictureEdit2
    '
    Me.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
    Me.pictureEdit2.EditValue = Global.NuSoft.NUI.Win.Forms.My.Resources.Resources.PCL2
    Me.pictureEdit2.Location = New System.Drawing.Point(12, 12)
    Me.pictureEdit2.Name = "pictureEdit2"
    Me.pictureEdit2.Properties.AllowFocused = False
    Me.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
    Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
    Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.pictureEdit2.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter
    Me.pictureEdit2.Properties.ShowMenu = False
    Me.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
    Me.pictureEdit2.Size = New System.Drawing.Size(426, 180)
    Me.pictureEdit2.TabIndex = 14
    '
    'pictureEdit1
    '
    Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
    Me.pictureEdit1.Location = New System.Drawing.Point(214, 263)
    Me.pictureEdit1.Name = "pictureEdit1"
    Me.pictureEdit1.Properties.AllowFocused = False
    Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
    Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
    Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.pictureEdit1.Properties.ShowMenu = False
    Me.pictureEdit1.Size = New System.Drawing.Size(219, 48)
    Me.pictureEdit1.TabIndex = 13
    Me.pictureEdit1.Visible = False
    '
    'txtProgress
    '
    Me.txtProgress.Location = New System.Drawing.Point(23, 206)
    Me.txtProgress.Name = "txtProgress"
    Me.txtProgress.Size = New System.Drawing.Size(53, 13)
    Me.txtProgress.TabIndex = 12
    Me.txtProgress.Text = "Memulai ..."
    '
    'lblCopy
    '
    Me.lblCopy.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.lblCopy.Location = New System.Drawing.Point(23, 286)
    Me.lblCopy.Name = "lblCopy"
    Me.lblCopy.Size = New System.Drawing.Size(115, 13)
    Me.lblCopy.TabIndex = 11
    Me.lblCopy.Text = "Copyright © 1998-2011"
    '
    'marqueeProgressBarControl1
    '
    Me.marqueeProgressBarControl1.EditValue = 0
    Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(23, 231)
    Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
    Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(404, 12)
    Me.marqueeProgressBarControl1.TabIndex = 10
    '
    'x_Splash
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(450, 320)
    Me.Controls.Add(Me.pictureEdit2)
    Me.Controls.Add(Me.pictureEdit1)
    Me.Controls.Add(Me.txtProgress)
    Me.Controls.Add(Me.lblCopy)
    Me.Controls.Add(Me.marqueeProgressBarControl1)
    Me.Name = "x_Splash"
    Me.Text = "Form1"
    CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents pictureEdit2 As DevExpress.XtraEditors.PictureEdit
  Private WithEvents pictureEdit1 As DevExpress.XtraEditors.PictureEdit
  Private WithEvents txtProgress As DevExpress.XtraEditors.LabelControl
  Private WithEvents lblCopy As DevExpress.XtraEditors.LabelControl
  Private WithEvents marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
End Class
