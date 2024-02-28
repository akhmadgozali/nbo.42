Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class ProsesDialog
    Inherits DialogForm

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
      Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
      Me.txtJudul = New DevExpress.XtraEditors.LabelControl()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanelControl2.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btn1
      '
      Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
      Me.btn1.Appearance.Options.UseForeColor = True
      Me.btn1.Location = New System.Drawing.Point(250, 12)
      Me.btn1.Text = "&Proses"
      '
      'btn2
      '
      Me.btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
      Me.btn2.Appearance.Options.UseForeColor = True
      Me.btn2.Location = New System.Drawing.Point(343, 12)
      '
      'PanelControl2
      '
      Me.PanelControl2.Controls.Add(Me.txtJudul)
      Me.PanelControl2.Controls.Add(Me.PictureBox1)
      Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
      Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
      Me.PanelControl2.Name = "PanelControl2"
      Me.PanelControl2.Size = New System.Drawing.Size(444, 49)
      Me.PanelControl2.TabIndex = 4
      '
      'txtJudul
      '
      Me.txtJudul.Location = New System.Drawing.Point(61, 17)
      Me.txtJudul.Name = "txtJudul"
      Me.txtJudul.Size = New System.Drawing.Size(341, 13)
      Me.txtJudul.TabIndex = 1
      Me.txtJudul.Text = "Klik tombol [Proses] untuk melakukan proses tutup buku bulan berjalan."
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.My.Resources.Resources.information
      Me.PictureBox1.Location = New System.Drawing.Point(39, 16)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
      Me.PictureBox1.TabIndex = 0
      Me.PictureBox1.TabStop = False
      '
      'ProsesDialog
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(444, 184)
      Me.Controls.Add(Me.PanelControl2)
      Me.Name = "ProsesDialog"
      Me.Text = "ProsesDialog"
      Me.Controls.SetChildIndex(Me.PanelControl2, 0)
      CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanelControl2.ResumeLayout(False)
      Me.PanelControl2.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

    End Sub
    Public WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Protected Friend WithEvents txtJudul As DevExpress.XtraEditors.LabelControl
    Protected Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  End Class
End Namespace