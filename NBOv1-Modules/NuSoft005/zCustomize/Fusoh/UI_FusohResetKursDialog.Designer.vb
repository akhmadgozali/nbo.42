<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohResetKursDialog
	Inherits Core.Win.Forms.InputDialog

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.lytMasterTermin = New DevExpress.XtraLayout.LayoutControl()
		Me.txtKurs = New DevExpress.XtraEditors.SpinEdit()
		Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit()
		Me.txtBulan = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.txtTahun = New DevExpress.XtraEditors.SpinEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.txtMataUang = New DevExpress.XtraEditors.LookUpEdit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytMasterTermin.SuspendLayout()
		CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lytMasterTermin
		'
		Me.lytMasterTermin.Controls.Add(Me.txtKurs)
		Me.lytMasterTermin.Controls.Add(Me.txtKeterangan)
		Me.lytMasterTermin.Controls.Add(Me.txtBulan)
		Me.lytMasterTermin.Controls.Add(Me.txtTahun)
		Me.lytMasterTermin.Controls.Add(Me.txtMataUang)
		Me.lytMasterTermin.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytMasterTermin.Location = New System.Drawing.Point(0, 0)
		Me.lytMasterTermin.Name = "lytMasterTermin"
		Me.lytMasterTermin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(684, 234, 250, 350)
		Me.lytMasterTermin.Root = Me.LayoutControlGroup1
		Me.lytMasterTermin.Size = New System.Drawing.Size(332, 152)
		Me.lytMasterTermin.TabIndex = 0
		Me.lytMasterTermin.Text = "LayoutControl1"
		'
		'txtKurs
		'
		Me.txtKurs.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtKurs.EnterMoveNextControl = True
		Me.txtKurs.Location = New System.Drawing.Point(89, 60)
		Me.txtKurs.Name = "txtKurs"
		Me.txtKurs.Properties.Appearance.Options.UseTextOptions = True
		Me.txtKurs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtKurs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtKurs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtKurs.Properties.DisplayFormat.FormatString = "n2"
		Me.txtKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtKurs.Properties.EditFormat.FormatString = "n2"
		Me.txtKurs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtKurs.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtKurs.Size = New System.Drawing.Size(231, 20)
		Me.txtKurs.StyleController = Me.lytMasterTermin
		Me.txtKurs.TabIndex = 3
		'
		'txtKeterangan
		'
		Me.txtKeterangan.EnterMoveNextControl = True
		Me.txtKeterangan.Location = New System.Drawing.Point(89, 84)
		Me.txtKeterangan.Name = "txtKeterangan"
		Me.txtKeterangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtKeterangan.Size = New System.Drawing.Size(231, 56)
		Me.txtKeterangan.StyleController = Me.lytMasterTermin
		Me.txtKeterangan.TabIndex = 4
		'
		'txtBulan
		'
		Me.txtBulan.Location = New System.Drawing.Point(89, 12)
		Me.txtBulan.Name = "txtBulan"
		Me.txtBulan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtBulan.Size = New System.Drawing.Size(145, 20)
		Me.txtBulan.StyleController = Me.lytMasterTermin
		Me.txtBulan.TabIndex = 0
		'
		'txtTahun
		'
		Me.txtTahun.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtTahun.Location = New System.Drawing.Point(238, 12)
		Me.txtTahun.Name = "txtTahun"
		Me.txtTahun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTahun.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtTahun.Size = New System.Drawing.Size(82, 20)
		Me.txtTahun.StyleController = Me.lytMasterTermin
		Me.txtTahun.TabIndex = 1
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem10, Me.LayoutControlItem7, Me.LayoutControlItem3})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(332, 152)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtBulan
		Me.LayoutControlItem1.CustomizationFormText = "Kode"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(226, 24)
		Me.LayoutControlItem1.Text = "Periode"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtKurs
		Me.LayoutControlItem2.CustomizationFormText = "Kurs"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(312, 24)
		Me.LayoutControlItem2.Text = "Kurs"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem10
		'
		Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
		Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
		Me.LayoutControlItem10.Control = Me.txtKeterangan
		Me.LayoutControlItem10.CustomizationFormText = "Keterangan"
		Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 72)
		Me.LayoutControlItem10.Name = "LayoutControlItem10"
		Me.LayoutControlItem10.Size = New System.Drawing.Size(312, 60)
		Me.LayoutControlItem10.Text = "Keterangan      "
		Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.[Default]
		Me.LayoutControlItem10.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.txtTahun
		Me.LayoutControlItem7.CustomizationFormText = "Nomor Lampiran   "
		Me.LayoutControlItem7.Location = New System.Drawing.Point(226, 0)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(86, 24)
		Me.LayoutControlItem7.Text = "Nomor Lampiran   "
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem7.TextToControlDistance = 0
		Me.LayoutControlItem7.TextVisible = False
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtMataUang
		Me.LayoutControlItem3.CustomizationFormText = "Mata Uang"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(312, 24)
		Me.LayoutControlItem3.Text = "Mata Uang"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(74, 13)
		'
		'txtMataUang
		'
		Me.txtMataUang.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtMataUang.Location = New System.Drawing.Point(89, 36)
		Me.txtMataUang.Name = "txtMataUang"
		Me.txtMataUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMataUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtMataUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
		Me.txtMataUang.Properties.DisplayMember = "Kode"
		Me.txtMataUang.Properties.NullText = "[ Masukkan Mata Uang ]"
		Me.txtMataUang.Properties.ShowHeader = False
		Me.txtMataUang.Properties.ValueMember = "This"
		Me.txtMataUang.Size = New System.Drawing.Size(231, 20)
		Me.txtMataUang.StyleController = Me.lytMasterTermin
		Me.txtMataUang.TabIndex = 2
		'
		'UI_FusohResetKursDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(332, 201)
		Me.Controls.Add(Me.lytMasterTermin)
		Me.Name = "UI_FusohResetKursDialog"
		Me.Text = "Reset Kurs :"
		Me.Controls.SetChildIndex(Me.lytMasterTermin, 0)
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytMasterTermin.ResumeLayout(False)
		CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lytMasterTermin As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtKurs As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtBulan As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents txtTahun As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtMataUang As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
