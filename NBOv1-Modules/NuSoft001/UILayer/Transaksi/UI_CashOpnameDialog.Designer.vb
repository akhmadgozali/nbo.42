<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_CashOpnameDialog
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
  Me.lytCo = New DevExpress.XtraLayout.LayoutControl()
  Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
  Me.txtAkunNama = New DevExpress.XtraEditors.LabelControl()
  Me.txtAkun = New DevExpress.XtraEditors.LookUpEdit()
  Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
  Me.txtUser = New DevExpress.XtraEditors.TextEdit()
  Me.txtUserNama = New DevExpress.XtraEditors.LabelControl()
  Me.txtNilai = New DevExpress.XtraEditors.TextEdit()
  Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
  Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
  CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.lytCo, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.lytCo.SuspendLayout()
  CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtNilai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'lytCo
  '
  Me.lytCo.Controls.Add(Me.txtTanggal)
  Me.lytCo.Controls.Add(Me.txtAkunNama)
  Me.lytCo.Controls.Add(Me.txtAkun)
  Me.lytCo.Controls.Add(Me.txtUraian)
  Me.lytCo.Controls.Add(Me.txtUser)
  Me.lytCo.Controls.Add(Me.txtUserNama)
  Me.lytCo.Controls.Add(Me.txtNilai)
  Me.lytCo.Dock = System.Windows.Forms.DockStyle.Fill
  Me.lytCo.Location = New System.Drawing.Point(0, 0)
  Me.lytCo.Name = "lytCo"
  Me.lytCo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(55, 151, 250, 350)
  Me.lytCo.Root = Me.LayoutControlGroup1
  Me.lytCo.Size = New System.Drawing.Size(456, 140)
  Me.lytCo.TabIndex = 2
  Me.lytCo.Text = "LayoutControl1"
  '
  'txtTanggal
  '
  Me.txtTanggal.EditValue = Nothing
  Me.txtTanggal.Location = New System.Drawing.Point(59, 12)
  Me.txtTanggal.Name = "txtTanggal"
  Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
  Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
  Me.txtTanggal.Size = New System.Drawing.Size(120, 20)
  Me.txtTanggal.StyleController = Me.lytCo
  Me.txtTanggal.TabIndex = 0
  '
  'txtAkunNama
  '
  Me.txtAkunNama.Location = New System.Drawing.Point(183, 60)
  Me.txtAkunNama.Name = "txtAkunNama"
  Me.txtAkunNama.Size = New System.Drawing.Size(261, 20)
  Me.txtAkunNama.StyleController = Me.lytCo
  Me.txtAkunNama.TabIndex = 10
  Me.txtAkunNama.Text = "Nama Akun"
  '
  'txtAkun
  '
  Me.txtAkun.Location = New System.Drawing.Point(59, 60)
  Me.txtAkun.Name = "txtAkun"
  Me.txtAkun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtAkun.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
  Me.txtAkun.Properties.DisplayMember = "Kode"
  Me.txtAkun.Properties.NullText = "<Pilih Akun>"
  Me.txtAkun.Properties.PopupWidth = 300
  Me.txtAkun.Properties.ValueMember = "This"
  Me.txtAkun.Size = New System.Drawing.Size(120, 20)
  Me.txtAkun.StyleController = Me.lytCo
  Me.txtAkun.TabIndex = 3
  '
  'txtUraian
  '
  Me.txtUraian.Location = New System.Drawing.Point(59, 108)
  Me.txtUraian.Name = "txtUraian"
  Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtUraian.Size = New System.Drawing.Size(385, 20)
  Me.txtUraian.StyleController = Me.lytCo
  Me.txtUraian.TabIndex = 2
  '
  'txtUser
  '
  Me.txtUser.Enabled = False
  Me.txtUser.Location = New System.Drawing.Point(59, 36)
  Me.txtUser.Name = "txtUser"
  Me.txtUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtUser.Size = New System.Drawing.Size(120, 20)
  Me.txtUser.StyleController = Me.lytCo
  Me.txtUser.TabIndex = 1
  '
  'txtUserNama
  '
  Me.txtUserNama.Location = New System.Drawing.Point(183, 36)
  Me.txtUserNama.Name = "txtUserNama"
  Me.txtUserNama.Size = New System.Drawing.Size(261, 20)
  Me.txtUserNama.StyleController = Me.lytCo
  Me.txtUserNama.TabIndex = 9
  Me.txtUserNama.Text = "Nama User"
  '
  'txtNilai
  '
  Me.txtNilai.Location = New System.Drawing.Point(59, 84)
  Me.txtNilai.Name = "txtNilai"
  Me.txtNilai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtNilai.Properties.Mask.EditMask = "c"
  Me.txtNilai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
  Me.txtNilai.Properties.Mask.UseMaskAsDisplayFormat = True
  Me.txtNilai.Size = New System.Drawing.Size(120, 20)
  Me.txtNilai.StyleController = Me.lytCo
  Me.txtNilai.TabIndex = 4
  '
  'LayoutControlGroup1
  '
  Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
  Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
  Me.LayoutControlGroup1.GroupBordersVisible = False
  Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.EmptySpaceItem1})
  Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup1.Name = "Root"
  Me.LayoutControlGroup1.Size = New System.Drawing.Size(456, 140)
  Me.LayoutControlGroup1.Text = "Root"
  Me.LayoutControlGroup1.TextVisible = False
  '
  'LayoutControlItem1
  '
  Me.LayoutControlItem1.Control = Me.txtUser
  Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
  Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
  Me.LayoutControlItem1.Name = "LayoutControlItem1"
  Me.LayoutControlItem1.Size = New System.Drawing.Size(171, 24)
  Me.LayoutControlItem1.Text = "User"
  Me.LayoutControlItem1.TextSize = New System.Drawing.Size(44, 13)
  '
  'LayoutControlItem5
  '
  Me.LayoutControlItem5.Control = Me.txtAkun
  Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
  Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
  Me.LayoutControlItem5.Name = "LayoutControlItem5"
  Me.LayoutControlItem5.Size = New System.Drawing.Size(171, 24)
  Me.LayoutControlItem5.Text = "Akun Kas"
  Me.LayoutControlItem5.TextSize = New System.Drawing.Size(44, 13)
  '
  'LayoutControlItem2
  '
  Me.LayoutControlItem2.Control = Me.txtUserNama
  Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
  Me.LayoutControlItem2.Location = New System.Drawing.Point(171, 24)
  Me.LayoutControlItem2.MinSize = New System.Drawing.Size(56, 17)
  Me.LayoutControlItem2.Name = "LayoutControlItem2"
  Me.LayoutControlItem2.Size = New System.Drawing.Size(265, 24)
  Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
  Me.LayoutControlItem2.Text = "LayoutControlItem2"
  Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
  Me.LayoutControlItem2.TextToControlDistance = 0
  Me.LayoutControlItem2.TextVisible = False
  '
  'LayoutControlItem6
  '
  Me.LayoutControlItem6.Control = Me.txtAkunNama
  Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
  Me.LayoutControlItem6.Location = New System.Drawing.Point(171, 48)
  Me.LayoutControlItem6.MinSize = New System.Drawing.Size(58, 17)
  Me.LayoutControlItem6.Name = "LayoutControlItem6"
  Me.LayoutControlItem6.Size = New System.Drawing.Size(265, 24)
  Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
  Me.LayoutControlItem6.Text = "LayoutControlItem6"
  Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
  Me.LayoutControlItem6.TextToControlDistance = 0
  Me.LayoutControlItem6.TextVisible = False
  '
  'LayoutControlItem3
  '
  Me.LayoutControlItem3.Control = Me.txtNilai
  Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
  Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
  Me.LayoutControlItem3.Name = "LayoutControlItem3"
  Me.LayoutControlItem3.Size = New System.Drawing.Size(171, 24)
  Me.LayoutControlItem3.Text = "Nilai"
  Me.LayoutControlItem3.TextSize = New System.Drawing.Size(44, 13)
  '
  'LayoutControlItem4
  '
  Me.LayoutControlItem4.Control = Me.txtUraian
  Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
  Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
  Me.LayoutControlItem4.Name = "LayoutControlItem4"
  Me.LayoutControlItem4.Size = New System.Drawing.Size(436, 24)
  Me.LayoutControlItem4.Text = "Uraian"
  Me.LayoutControlItem4.TextSize = New System.Drawing.Size(44, 13)
  '
  'EmptySpaceItem2
  '
  Me.EmptySpaceItem2.AllowHotTrack = False
  Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
  Me.EmptySpaceItem2.Location = New System.Drawing.Point(171, 72)
  Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
  Me.EmptySpaceItem2.Size = New System.Drawing.Size(265, 24)
  Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
  Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
  '
  'LayoutControlItem7
  '
  Me.LayoutControlItem7.Control = Me.txtTanggal
  Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
  Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlItem7.Name = "LayoutControlItem7"
  Me.LayoutControlItem7.Size = New System.Drawing.Size(171, 24)
  Me.LayoutControlItem7.Text = "Tanggal"
  Me.LayoutControlItem7.TextSize = New System.Drawing.Size(44, 13)
  '
  'EmptySpaceItem1
  '
  Me.EmptySpaceItem1.AllowHotTrack = False
  Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
  Me.EmptySpaceItem1.Location = New System.Drawing.Point(171, 0)
  Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(104, 24)
  Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
  Me.EmptySpaceItem1.Size = New System.Drawing.Size(265, 24)
  Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
  Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
  Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
  '
  'UI_CashOpnameDialog
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(456, 189)
  Me.Controls.Add(Me.lytCo)
  Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
  Me.Name = "UI_CashOpnameDialog"
  Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
  Me.Text = "Cash Opname"
  Me.Controls.SetChildIndex(Me.lytCo, 0)
  CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.lytCo, System.ComponentModel.ISupportInitialize).EndInit()
  Me.lytCo.ResumeLayout(False)
  CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtNilai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)

 End Sub
 Friend WithEvents lytCo As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
 Friend WithEvents txtAkunNama As DevExpress.XtraEditors.LabelControl
 Friend WithEvents txtAkun As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtUserNama As DevExpress.XtraEditors.LabelControl
 Friend WithEvents txtNilai As DevExpress.XtraEditors.TextEdit
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
 Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

End Class
