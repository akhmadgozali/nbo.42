<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_LK
  Inherits Core.Win.Forms.FilterForm

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
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtPeriodeBulan = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.txtPeriodeTahun = New DevExpress.XtraEditors.TextEdit()
    Me.xRadio = New DevExpress.XtraEditors.RadioGroup()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xRadio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(12, 15)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
    Me.LabelControl2.TabIndex = 10
    Me.LabelControl2.Text = "Periode"
    '
    'txtPeriodeBulan
    '
    Me.txtPeriodeBulan.Location = New System.Drawing.Point(71, 12)
    Me.txtPeriodeBulan.Name = "txtPeriodeBulan"
    Me.txtPeriodeBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.txtPeriodeBulan.Size = New System.Drawing.Size(170, 20)
    Me.txtPeriodeBulan.TabIndex = 0
    '
    'txtPeriodeTahun
    '
    Me.txtPeriodeTahun.Location = New System.Drawing.Point(247, 12)
    Me.txtPeriodeTahun.Name = "txtPeriodeTahun"
    Me.txtPeriodeTahun.Properties.Mask.EditMask = "0000"
    Me.txtPeriodeTahun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
    Me.txtPeriodeTahun.Size = New System.Drawing.Size(75, 20)
    Me.txtPeriodeTahun.TabIndex = 1
    '
    'xRadio
    '
    Me.xRadio.EditValue = True
    Me.xRadio.Location = New System.Drawing.Point(71, 36)
    Me.xRadio.Name = "xRadio"
    Me.xRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
    Me.xRadio.Properties.Appearance.Options.UseBackColor = True
    Me.xRadio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Akumulasi"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Per Bulan")})
    Me.xRadio.Size = New System.Drawing.Size(251, 20)
    Me.xRadio.TabIndex = 101
    '
    'RF_LK
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(337, 115)
    Me.Controls.Add(Me.xRadio)
    Me.Controls.Add(Me.txtPeriodeTahun)
    Me.Controls.Add(Me.txtPeriodeBulan)
    Me.Controls.Add(Me.LabelControl2)
    Me.Name = "RF_LK"
    Me.Text = "Filter Laporan - Buku Besar"
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.txtPeriodeBulan, 0)
    Me.Controls.SetChildIndex(Me.txtPeriodeTahun, 0)
    Me.Controls.SetChildIndex(Me.xRadio, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xRadio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtPeriodeBulan As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents txtPeriodeTahun As DevExpress.XtraEditors.TextEdit
  Friend WithEvents xRadio As DevExpress.XtraEditors.RadioGroup
End Class
