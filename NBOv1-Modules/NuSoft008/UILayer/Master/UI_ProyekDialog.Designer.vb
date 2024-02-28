<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ProyekDialog
  Inherits Core.Win.Forms.InputDialog

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
  Me.txtKode = New DevExpress.XtraEditors.TextEdit()
  Me.lytMasterProyek = New DevExpress.XtraLayout.LayoutControl()
  Me.txtNoKontrak = New DevExpress.XtraEditors.TextEdit()
  Me.txtNama = New DevExpress.XtraEditors.TextEdit()
  Me.txtTglSelesai = New DevExpress.XtraEditors.DateEdit()
  Me.txtTglMulai = New DevExpress.XtraEditors.DateEdit()
  Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit()
  Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
  CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.lytMasterProyek, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.lytMasterProyek.SuspendLayout()
  CType(Me.txtNoKontrak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTglSelesai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTglSelesai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTglMulai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTglMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'txtKode
  '
  Me.txtKode.Location = New System.Drawing.Point(72, 12)
  Me.txtKode.Name = "txtKode"
  Me.txtKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKode.Size = New System.Drawing.Size(268, 20)
  Me.txtKode.StyleController = Me.lytMasterProyek
  Me.txtKode.TabIndex = 100
  '
  'lytMasterProyek
  '
  Me.lytMasterProyek.Controls.Add(Me.txtNoKontrak)
  Me.lytMasterProyek.Controls.Add(Me.txtKode)
  Me.lytMasterProyek.Controls.Add(Me.txtNama)
  Me.lytMasterProyek.Controls.Add(Me.txtTglSelesai)
  Me.lytMasterProyek.Controls.Add(Me.txtTglMulai)
  Me.lytMasterProyek.Controls.Add(Me.txtCustomer)
  Me.lytMasterProyek.Dock = System.Windows.Forms.DockStyle.Fill
  Me.lytMasterProyek.Location = New System.Drawing.Point(0, 0)
  Me.lytMasterProyek.Name = "lytMasterProyek"
  Me.lytMasterProyek.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(647, 154, 250, 350)
  Me.lytMasterProyek.Root = Me.LayoutControlGroup1
  Me.lytMasterProyek.Size = New System.Drawing.Size(352, 142)
  Me.lytMasterProyek.TabIndex = 112
  Me.lytMasterProyek.Text = "LayoutControl1"
  '
  'txtNoKontrak
  '
  Me.txtNoKontrak.Location = New System.Drawing.Point(72, 84)
  Me.txtNoKontrak.Name = "txtNoKontrak"
  Me.txtNoKontrak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtNoKontrak.Size = New System.Drawing.Size(268, 20)
  Me.txtNoKontrak.StyleController = Me.lytMasterProyek
  Me.txtNoKontrak.TabIndex = 106
  '
  'txtNama
  '
  Me.txtNama.Location = New System.Drawing.Point(72, 36)
  Me.txtNama.Name = "txtNama"
  Me.txtNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtNama.Size = New System.Drawing.Size(268, 20)
  Me.txtNama.StyleController = Me.lytMasterProyek
  Me.txtNama.TabIndex = 102
  '
  'txtTglSelesai
  '
  Me.txtTglSelesai.EditValue = Nothing
  Me.txtTglSelesai.Location = New System.Drawing.Point(220, 108)
  Me.txtTglSelesai.Name = "txtTglSelesai"
  Me.txtTglSelesai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtTglSelesai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTglSelesai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTglSelesai.Properties.Mask.EditMask = ""
  Me.txtTglSelesai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
  Me.txtTglSelesai.Size = New System.Drawing.Size(120, 20)
  Me.txtTglSelesai.StyleController = Me.lytMasterProyek
  Me.txtTglSelesai.TabIndex = 110
  '
  'txtTglMulai
  '
  Me.txtTglMulai.EditValue = Nothing
  Me.txtTglMulai.Location = New System.Drawing.Point(72, 108)
  Me.txtTglMulai.Name = "txtTglMulai"
  Me.txtTglMulai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtTglMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTglMulai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTglMulai.Properties.Mask.EditMask = ""
  Me.txtTglMulai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
  Me.txtTglMulai.Size = New System.Drawing.Size(121, 20)
  Me.txtTglMulai.StyleController = Me.lytMasterProyek
  Me.txtTglMulai.TabIndex = 108
  '
  'txtCustomer
  '
  Me.txtCustomer.Location = New System.Drawing.Point(72, 60)
  Me.txtCustomer.Name = "txtCustomer"
  Me.txtCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
  Me.txtCustomer.Properties.DisplayMember = "Kode"
  Me.txtCustomer.Properties.NullText = ""
  Me.txtCustomer.Properties.ValueMember = "This"
  Me.txtCustomer.Size = New System.Drawing.Size(268, 20)
  Me.txtCustomer.StyleController = Me.lytMasterProyek
  Me.txtCustomer.TabIndex = 104
  '
  'LayoutControlGroup1
  '
  Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
  Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
  Me.LayoutControlGroup1.GroupBordersVisible = False
  Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6})
  Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup1.Name = "Root"
  Me.LayoutControlGroup1.Size = New System.Drawing.Size(352, 142)
  Me.LayoutControlGroup1.Text = "Root"
  Me.LayoutControlGroup1.TextVisible = False
  '
  'LayoutControlItem1
  '
  Me.LayoutControlItem1.Control = Me.txtKode
  Me.LayoutControlItem1.CustomizationFormText = "Kode"
  Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlItem1.Name = "LayoutControlItem1"
  Me.LayoutControlItem1.Size = New System.Drawing.Size(332, 24)
  Me.LayoutControlItem1.Text = "Kode"
  Me.LayoutControlItem1.TextSize = New System.Drawing.Size(57, 13)
  '
  'LayoutControlItem2
  '
  Me.LayoutControlItem2.Control = Me.txtNama
  Me.LayoutControlItem2.CustomizationFormText = "Nama"
  Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
  Me.LayoutControlItem2.Name = "LayoutControlItem2"
  Me.LayoutControlItem2.Size = New System.Drawing.Size(332, 24)
  Me.LayoutControlItem2.Text = "Nama"
  Me.LayoutControlItem2.TextSize = New System.Drawing.Size(57, 13)
  '
  'LayoutControlItem3
  '
  Me.LayoutControlItem3.Control = Me.txtCustomer
  Me.LayoutControlItem3.CustomizationFormText = "Customer"
  Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
  Me.LayoutControlItem3.Name = "LayoutControlItem3"
  Me.LayoutControlItem3.Size = New System.Drawing.Size(332, 24)
  Me.LayoutControlItem3.Text = "Customer"
  Me.LayoutControlItem3.TextSize = New System.Drawing.Size(57, 13)
  '
  'LayoutControlItem4
  '
  Me.LayoutControlItem4.Control = Me.txtNoKontrak
  Me.LayoutControlItem4.CustomizationFormText = "No. Kontrak"
  Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
  Me.LayoutControlItem4.Name = "LayoutControlItem4"
  Me.LayoutControlItem4.Size = New System.Drawing.Size(332, 24)
  Me.LayoutControlItem4.Text = "No. Kontrak"
  Me.LayoutControlItem4.TextSize = New System.Drawing.Size(57, 13)
  '
  'LayoutControlItem5
  '
  Me.LayoutControlItem5.Control = Me.txtTglMulai
  Me.LayoutControlItem5.CustomizationFormText = "Tgl Mulai"
  Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
  Me.LayoutControlItem5.Name = "LayoutControlItem5"
  Me.LayoutControlItem5.Size = New System.Drawing.Size(185, 26)
  Me.LayoutControlItem5.Text = "Tgl Mulai"
  Me.LayoutControlItem5.TextSize = New System.Drawing.Size(57, 13)
  '
  'LayoutControlItem6
  '
  Me.LayoutControlItem6.Control = Me.txtTglSelesai
  Me.LayoutControlItem6.CustomizationFormText = " s/d"
  Me.LayoutControlItem6.Location = New System.Drawing.Point(185, 96)
  Me.LayoutControlItem6.Name = "LayoutControlItem6"
  Me.LayoutControlItem6.Size = New System.Drawing.Size(147, 26)
  Me.LayoutControlItem6.Text = " s/d"
  Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
  Me.LayoutControlItem6.TextSize = New System.Drawing.Size(18, 13)
  Me.LayoutControlItem6.TextToControlDistance = 5
  '
  'UI_ProyekDialog
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(352, 191)
  Me.Controls.Add(Me.lytMasterProyek)
  Me.Name = "UI_ProyekDialog"
  Me.Text = "Proyek :"
  Me.Controls.SetChildIndex(Me.lytMasterProyek, 0)
  CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.lytMasterProyek, System.ComponentModel.ISupportInitialize).EndInit()
  Me.lytMasterProyek.ResumeLayout(False)
  CType(Me.txtNoKontrak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTglSelesai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTglSelesai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTglMulai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTglMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)

 End Sub
 Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtNoKontrak As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtTglMulai As DevExpress.XtraEditors.DateEdit
 Friend WithEvents txtTglSelesai As DevExpress.XtraEditors.DateEdit
 Friend WithEvents lytMasterProyek As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
