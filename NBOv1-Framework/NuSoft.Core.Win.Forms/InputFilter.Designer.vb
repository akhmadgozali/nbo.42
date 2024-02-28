Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class InputFilter
    Inherits NuSoftForm

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
      Me.btnFilter = New DevExpress.XtraEditors.SimpleButton()
      Me.btnBatal = New DevExpress.XtraEditors.SimpleButton()
      CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanelControl1.SuspendLayout()
      Me.SuspendLayout()
      '
      'PanelControl1
      '
      Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
      Me.PanelControl1.Controls.Add(Me.btnFilter)
      Me.PanelControl1.Controls.Add(Me.btnBatal)
      Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.PanelControl1.Location = New System.Drawing.Point(0, 92)
      Me.PanelControl1.Name = "PanelControl1"
      Me.PanelControl1.Size = New System.Drawing.Size(331, 49)
      Me.PanelControl1.TabIndex = 100
      '
      'btnFilter
      '
      Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnFilter.Appearance.ForeColor = System.Drawing.Color.Green
      Me.btnFilter.Appearance.Options.UseForeColor = True
      Me.btnFilter.Location = New System.Drawing.Point(137, 12)
      Me.btnFilter.Name = "btnFilter"
      Me.btnFilter.Size = New System.Drawing.Size(87, 26)
      Me.btnFilter.TabIndex = 0
      Me.btnFilter.Text = "&Filter"
      '
      'btnBatal
      '
      Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnBatal.Appearance.ForeColor = System.Drawing.Color.Red
      Me.btnBatal.Appearance.Options.UseForeColor = True
      Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnBatal.Location = New System.Drawing.Point(230, 12)
      Me.btnBatal.Name = "btnBatal"
      Me.btnBatal.Size = New System.Drawing.Size(87, 26)
      Me.btnBatal.TabIndex = 1
      Me.btnBatal.Text = "&Batal"
      '
      'InputFilter
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(331, 141)
      Me.Controls.Add(Me.PanelControl1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "InputFilter"
      Me.ShowIcon = False
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "GridInputFilter"
      CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanelControl1.ResumeLayout(False)
      Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFilter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
  End Class
End Namespace