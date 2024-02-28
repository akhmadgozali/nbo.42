<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_TutupBukuDialogOld
  Inherits Core.Win.Forms.ProsesDialog

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
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.txtBulanIni = New DevExpress.XtraEditors.TextEdit()
    Me.txtBulanNext = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl2.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBulanIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBulanNext.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PanelControl2
    '
    Me.PanelControl2.Size = New System.Drawing.Size(442, 49)
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(222, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(315, 11)
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(39, 67)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
    Me.LabelControl1.TabIndex = 4
    Me.LabelControl1.Text = "Periode Saat Ini"
    '
    'txtBulanIni
    '
    Me.txtBulanIni.Enabled = False
    Me.txtBulanIni.Location = New System.Drawing.Point(151, 64)
    Me.txtBulanIni.Name = "txtBulanIni"
    Me.txtBulanIni.Size = New System.Drawing.Size(251, 20)
    Me.txtBulanIni.TabIndex = 5
    '
    'txtBulanNext
    '
    Me.txtBulanNext.Enabled = False
    Me.txtBulanNext.Location = New System.Drawing.Point(151, 90)
    Me.txtBulanNext.Name = "txtBulanNext"
    Me.txtBulanNext.Size = New System.Drawing.Size(251, 20)
    Me.txtBulanNext.TabIndex = 7
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(39, 93)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(96, 13)
    Me.LabelControl2.TabIndex = 6
    Me.LabelControl2.Text = "Periode Selanjutnya"
    '
    'UI_TutupBuku
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(442, 163)
    Me.Controls.Add(Me.txtBulanNext)
    Me.Controls.Add(Me.LabelControl2)
    Me.Controls.Add(Me.txtBulanIni)
    Me.Controls.Add(Me.LabelControl1)
    Me.Name = "UI_TutupBuku"
    Me.Text = "Tutup Buku"
    Me.Controls.SetChildIndex(Me.PanelControl2, 0)
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.txtBulanIni, 0)
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.txtBulanNext, 0)
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl2.ResumeLayout(False)
    Me.PanelControl2.PerformLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBulanIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBulanNext.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtBulanIni As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtBulanNext As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
