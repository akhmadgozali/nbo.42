Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class InputDialog
    Inherits InputBase

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
      Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
      Me.btn1 = New DevExpress.XtraEditors.SimpleButton()
      Me.btn2 = New DevExpress.XtraEditors.SimpleButton()
      CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanelControl1.SuspendLayout()
      Me.SuspendLayout()
      '
      'PanelControl1
      '
      Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
      Me.PanelControl1.Controls.Add(Me.btn1)
      Me.PanelControl1.Controls.Add(Me.btn2)
      Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.PanelControl1.Location = New System.Drawing.Point(0, 234)
      Me.PanelControl1.Name = "PanelControl1"
      Me.PanelControl1.Size = New System.Drawing.Size(342, 49)
      Me.PanelControl1.TabIndex = 99
      '
      'btn1
      '
      Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
      Me.btn1.Appearance.Options.UseForeColor = True
      Me.btn1.Location = New System.Drawing.Point(148, 12)
      Me.btn1.Name = "btn1"
      Me.btn1.Size = New System.Drawing.Size(87, 26)
      Me.btn1.TabIndex = 0
      Me.btn1.Text = "&Simpan"
      '
      'btn2
      '
      Me.btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
      Me.btn2.Appearance.Options.UseForeColor = True
      Me.btn2.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btn2.Location = New System.Drawing.Point(241, 12)
      Me.btn2.Name = "btn2"
      Me.btn2.Size = New System.Drawing.Size(87, 26)
      Me.btn2.TabIndex = 1
      Me.btn2.Text = "&Batal"
      '
      'InputDialog
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(342, 283)
      Me.Controls.Add(Me.PanelControl1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "InputDialog"
      Me.ShowIcon = False
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "InputDialog"
      CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanelControl1.ResumeLayout(False)
      Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn2 As DevExpress.XtraEditors.SimpleButton
  End Class
End Namespace