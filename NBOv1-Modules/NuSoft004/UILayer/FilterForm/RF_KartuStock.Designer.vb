<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_KartuStock
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
  Me.txtPeriodeTahun = New DevExpress.XtraEditors.TextEdit()
  Me.txtPeriodeBulan = New DevExpress.XtraEditors.ComboBoxEdit()
  Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
  Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
  Me.txtKodeBarang = New DevExpress.XtraEditors.LookUpEdit()
  CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'txtPeriodeTahun
  '
  Me.txtPeriodeTahun.Location = New System.Drawing.Point(288, 12)
  Me.txtPeriodeTahun.Name = "txtPeriodeTahun"
  Me.txtPeriodeTahun.Properties.Mask.EditMask = "0000"
  Me.txtPeriodeTahun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
  Me.txtPeriodeTahun.Size = New System.Drawing.Size(75, 20)
  Me.txtPeriodeTahun.TabIndex = 102
  '
  'txtPeriodeBulan
  '
  Me.txtPeriodeBulan.Location = New System.Drawing.Point(91, 12)
  Me.txtPeriodeBulan.Name = "txtPeriodeBulan"
  Me.txtPeriodeBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtPeriodeBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
  Me.txtPeriodeBulan.Size = New System.Drawing.Size(170, 20)
  Me.txtPeriodeBulan.TabIndex = 101
  '
  'LabelControl5
  '
  Me.LabelControl5.Location = New System.Drawing.Point(12, 41)
  Me.LabelControl5.Name = "LabelControl5"
  Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
  Me.LabelControl5.TabIndex = 105
  Me.LabelControl5.Text = "Kode Stock"
  '
  'LabelControl2
  '
  Me.LabelControl2.Location = New System.Drawing.Point(12, 15)
  Me.LabelControl2.Name = "LabelControl2"
  Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
  Me.LabelControl2.TabIndex = 106
  Me.LabelControl2.Text = "Periode"
  '
  'txtKodeBarang
  '
  Me.txtKodeBarang.Location = New System.Drawing.Point(91, 38)
  Me.txtKodeBarang.Name = "txtKodeBarang"
  Me.txtKodeBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtKodeBarang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
  Me.txtKodeBarang.Properties.DisplayMember = "Kode"
  Me.txtKodeBarang.Properties.NullText = "<Silahkan Pilih Barang>"
  Me.txtKodeBarang.Properties.ValueMember = "This"
  Me.txtKodeBarang.Size = New System.Drawing.Size(272, 20)
  Me.txtKodeBarang.TabIndex = 107
  '
  'RF_KartuStock
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(390, 130)
  Me.Controls.Add(Me.txtKodeBarang)
  Me.Controls.Add(Me.txtPeriodeTahun)
  Me.Controls.Add(Me.txtPeriodeBulan)
  Me.Controls.Add(Me.LabelControl5)
  Me.Controls.Add(Me.LabelControl2)
  Me.Name = "RF_KartuStock"
  Me.Text = "Filter Kartu Stock"
  Me.Controls.SetChildIndex(Me.LabelControl2, 0)
  Me.Controls.SetChildIndex(Me.LabelControl5, 0)
  Me.Controls.SetChildIndex(Me.txtPeriodeBulan, 0)
  Me.Controls.SetChildIndex(Me.txtPeriodeTahun, 0)
  Me.Controls.SetChildIndex(Me.txtKodeBarang, 0)
  CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)
  Me.PerformLayout()

 End Sub
  Friend WithEvents txtPeriodeTahun As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPeriodeBulan As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.LookUpEdit
End Class
