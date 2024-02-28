<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x_Setting
  Inherits Core.Win.Forms.DialogForm

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
    Me.txtCheck = New DevExpress.XtraEditors.CheckEdit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.txtCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(94, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(187, 11)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 33)
    Me.PanelControl1.Size = New System.Drawing.Size(286, 49)
    '
    'txtCheck
    '
    Me.txtCheck.Location = New System.Drawing.Point(13, 13)
    Me.txtCheck.Name = "txtCheck"
    Me.txtCheck.Properties.Caption = "Laporan terpisah dari menu"
    Me.txtCheck.Size = New System.Drawing.Size(168, 19)
    Me.txtCheck.TabIndex = 4
    '
    'x_Setting
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(286, 82)
    Me.Controls.Add(Me.txtCheck)
    Me.Name = "x_Setting"
    Me.Text = "Setting Framework"
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.txtCheck, 0)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.txtCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtCheck As DevExpress.XtraEditors.CheckEdit
End Class
