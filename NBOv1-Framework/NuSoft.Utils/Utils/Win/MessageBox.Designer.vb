Namespace NuSoft.Utils.Win
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class MessageBox
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBox))
      Me.imageCol = New DevExpress.Utils.ImageCollection(Me.components)
      Me.lbl = New DevExpress.XtraEditors.LabelControl()
      Me.lblSolution = New DevExpress.XtraEditors.LabelControl()
      Me.btn1 = New DevExpress.XtraEditors.SimpleButton()
      Me.btn2 = New DevExpress.XtraEditors.SimpleButton()
      Me.x_icon = New System.Windows.Forms.PictureBox()
      CType(Me.imageCol, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.x_icon, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'imageCol
      '
      Me.imageCol.ImageSize = New System.Drawing.Size(64, 64)
      Me.imageCol.ImageStream = CType(resources.GetObject("imageCol.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
      Me.imageCol.Images.SetKeyName(0, "warning_64.png")
      Me.imageCol.Images.SetKeyName(1, "gnome-help.png")
      Me.imageCol.Images.SetKeyName(2, "info_64.png")
      '
      'lbl
      '
      Me.lbl.Appearance.ForeColor = System.Drawing.Color.Red
      Me.lbl.Location = New System.Drawing.Point(82, 12)
      Me.lbl.Name = "lbl"
      Me.lbl.Size = New System.Drawing.Size(66, 13)
      Me.lbl.TabIndex = 1
      Me.lbl.Text = "LabelControl1"
      Me.lbl.Visible = False
      '
      'lblSolution
      '
      Me.lblSolution.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSolution.Location = New System.Drawing.Point(82, 31)
      Me.lblSolution.Name = "lblSolution"
      Me.lblSolution.Size = New System.Drawing.Size(80, 13)
      Me.lblSolution.TabIndex = 2
      Me.lblSolution.Text = "LabelControl2"
      Me.lblSolution.Visible = False
      '
      'btn1
      '
      Me.btn1.Location = New System.Drawing.Point(82, 50)
      Me.btn1.Name = "btn1"
      Me.btn1.Size = New System.Drawing.Size(74, 26)
      Me.btn1.TabIndex = 3
      Me.btn1.Text = "OK"
      Me.btn1.Visible = False
      '
      'btn2
      '
      Me.btn2.Location = New System.Drawing.Point(162, 50)
      Me.btn2.Name = "btn2"
      Me.btn2.Size = New System.Drawing.Size(74, 26)
      Me.btn2.TabIndex = 4
      Me.btn2.Text = "Cancel"
      Me.btn2.Visible = False
      '
      'x_icon
      '
      Me.x_icon.Location = New System.Drawing.Point(12, 12)
      Me.x_icon.Name = "x_icon"
      Me.x_icon.Size = New System.Drawing.Size(64, 64)
      Me.x_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
      Me.x_icon.TabIndex = 5
      Me.x_icon.TabStop = False
      '
      'MessageBox
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(633, 76)
      Me.ControlBox = False
      Me.Controls.Add(Me.x_icon)
      Me.Controls.Add(Me.btn2)
      Me.Controls.Add(Me.btn1)
      Me.Controls.Add(Me.lblSolution)
      Me.Controls.Add(Me.lbl)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "MessageBox"
      Me.ShowIcon = False
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "SyBiruMessageBox"
      CType(Me.imageCol, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.x_icon, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

    End Sub
    Friend WithEvents imageCol As DevExpress.Utils.ImageCollection
    Friend WithEvents lbl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSolution As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents x_icon As System.Windows.Forms.PictureBox
  End Class
End Namespace