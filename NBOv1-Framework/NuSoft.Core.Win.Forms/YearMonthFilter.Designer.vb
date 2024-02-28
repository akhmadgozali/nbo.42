Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class YearMonthFilter
    Inherits InputFilter

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
      Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
      Me.txtTahun = New DevExpress.XtraEditors.ComboBoxEdit()
      Me.txtBulan = New DevExpress.XtraEditors.ComboBoxEdit()
      CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'LabelControl1
      '
      Me.LabelControl1.Location = New System.Drawing.Point(13, 16)
      Me.LabelControl1.Name = "LabelControl1"
      Me.LabelControl1.Size = New System.Drawing.Size(30, 13)
      Me.LabelControl1.TabIndex = 101
      Me.LabelControl1.Text = "Tahun"
      '
      'LabelControl2
      '
      Me.LabelControl2.Location = New System.Drawing.Point(13, 42)
      Me.LabelControl2.Name = "LabelControl2"
      Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
      Me.LabelControl2.TabIndex = 102
      Me.LabelControl2.Text = "Bulan"
      '
      'txtTahun
      '
      Me.txtTahun.Location = New System.Drawing.Point(83, 13)
      Me.txtTahun.Name = "txtTahun"
      Me.txtTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
      Me.txtTahun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
      Me.txtTahun.Size = New System.Drawing.Size(100, 20)
      Me.txtTahun.TabIndex = 103
      '
      'txtBulan
      '
      Me.txtBulan.Location = New System.Drawing.Point(83, 39)
      Me.txtBulan.Name = "txtBulan"
      Me.txtBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
      Me.txtBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
      Me.txtBulan.Size = New System.Drawing.Size(170, 20)
      Me.txtBulan.TabIndex = 104
      '
      'YearMonthFilter
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(267, 114)
      Me.Controls.Add(Me.txtBulan)
      Me.Controls.Add(Me.txtTahun)
      Me.Controls.Add(Me.LabelControl2)
      Me.Controls.Add(Me.LabelControl1)
      Me.Name = "YearMonthFilter"
      Me.Text = "Filter"
      Me.Controls.SetChildIndex(Me.LabelControl1, 0)
      Me.Controls.SetChildIndex(Me.LabelControl2, 0)
      Me.Controls.SetChildIndex(Me.txtTahun, 0)
      Me.Controls.SetChildIndex(Me.txtBulan, 0)
      CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTahun As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtBulan As DevExpress.XtraEditors.ComboBoxEdit
  End Class
End Namespace