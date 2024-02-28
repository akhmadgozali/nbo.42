<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanYuKuotaImporDialog
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
    Me.txtNomorHS = New DevExpress.XtraEditors.TextEdit()
    Me.lytMasterTermin = New DevExpress.XtraLayout.LayoutControl()
    Me.txtPelabuhan = New DevExpress.XtraEditors.TextEdit()
    Me.txtNomorLampiran = New DevExpress.XtraEditors.TextEdit()
    Me.txtVolume = New DevExpress.XtraEditors.SpinEdit()
    Me.txtSatuan = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtHarga = New DevExpress.XtraEditors.CalcEdit()
    Me.txtMataUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNegara = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.txtExpired = New DevExpress.XtraEditors.DateEdit()
    Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNomorHS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytMasterTermin.SuspendLayout()
    CType(Me.txtPelabuhan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNomorLampiran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtVolume.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNegara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtExpired.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtExpired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNomorHS
    '
    Me.txtNomorHS.EnterMoveNextControl = True
    Me.txtNomorHS.Location = New System.Drawing.Point(101, 12)
    Me.txtNomorHS.Name = "txtNomorHS"
    Me.txtNomorHS.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNomorHS.Size = New System.Drawing.Size(330, 20)
    Me.txtNomorHS.StyleController = Me.lytMasterTermin
    Me.txtNomorHS.TabIndex = 0
    '
    'lytMasterTermin
    '
    Me.lytMasterTermin.Controls.Add(Me.txtPelabuhan)
    Me.lytMasterTermin.Controls.Add(Me.txtNomorLampiran)
    Me.lytMasterTermin.Controls.Add(Me.txtNomorHS)
    Me.lytMasterTermin.Controls.Add(Me.txtVolume)
    Me.lytMasterTermin.Controls.Add(Me.txtSatuan)
    Me.lytMasterTermin.Controls.Add(Me.txtHarga)
    Me.lytMasterTermin.Controls.Add(Me.txtMataUang)
    Me.lytMasterTermin.Controls.Add(Me.txtNegara)
    Me.lytMasterTermin.Controls.Add(Me.txtExpired)
    Me.lytMasterTermin.Controls.Add(Me.txtKeterangan)
    Me.lytMasterTermin.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytMasterTermin.Location = New System.Drawing.Point(0, 0)
    Me.lytMasterTermin.Name = "lytMasterTermin"
    Me.lytMasterTermin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(684, 234, 250, 350)
    Me.lytMasterTermin.Root = Me.LayoutControlGroup1
    Me.lytMasterTermin.Size = New System.Drawing.Size(443, 262)
    Me.lytMasterTermin.TabIndex = 0
    Me.lytMasterTermin.Text = "LayoutControl1"
    '
    'txtPelabuhan
    '
    Me.txtPelabuhan.EnterMoveNextControl = True
    Me.txtPelabuhan.Location = New System.Drawing.Point(101, 132)
    Me.txtPelabuhan.Name = "txtPelabuhan"
    Me.txtPelabuhan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPelabuhan.Size = New System.Drawing.Size(330, 20)
    Me.txtPelabuhan.StyleController = Me.lytMasterTermin
    Me.txtPelabuhan.TabIndex = 7
    '
    'txtNomorLampiran
    '
    Me.txtNomorLampiran.EnterMoveNextControl = True
    Me.txtNomorLampiran.Location = New System.Drawing.Point(101, 36)
    Me.txtNomorLampiran.Name = "txtNomorLampiran"
    Me.txtNomorLampiran.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNomorLampiran.Size = New System.Drawing.Size(330, 20)
    Me.txtNomorLampiran.StyleController = Me.lytMasterTermin
    Me.txtNomorLampiran.TabIndex = 1
    '
    'txtVolume
    '
    Me.txtVolume.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtVolume.EnterMoveNextControl = True
    Me.txtVolume.Location = New System.Drawing.Point(101, 60)
    Me.txtVolume.Name = "txtVolume"
    Me.txtVolume.Properties.Appearance.Options.UseTextOptions = True
    Me.txtVolume.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtVolume.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtVolume.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtVolume.Properties.DisplayFormat.FormatString = "n2"
    Me.txtVolume.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtVolume.Properties.EditFormat.FormatString = "n2"
    Me.txtVolume.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtVolume.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
    Me.txtVolume.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtVolume.Size = New System.Drawing.Size(123, 20)
    Me.txtVolume.StyleController = Me.lytMasterTermin
    Me.txtVolume.TabIndex = 2
    '
    'txtSatuan
    '
    Me.txtSatuan.EnterMoveNextControl = True
    Me.txtSatuan.Location = New System.Drawing.Point(317, 60)
    Me.txtSatuan.Name = "txtSatuan"
    Me.txtSatuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtSatuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSatuan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtSatuan.Properties.DisplayMember = "Kode"
    Me.txtSatuan.Properties.NullText = ""
    Me.txtSatuan.Properties.ValueMember = "This"
    Me.txtSatuan.Size = New System.Drawing.Size(114, 20)
    Me.txtSatuan.StyleController = Me.lytMasterTermin
    Me.txtSatuan.TabIndex = 3
    '
    'txtHarga
    '
    Me.txtHarga.EnterMoveNextControl = True
    Me.txtHarga.Location = New System.Drawing.Point(317, 84)
    Me.txtHarga.Name = "txtHarga"
    Me.txtHarga.Properties.Appearance.Options.UseTextOptions = True
    Me.txtHarga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtHarga.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtHarga.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtHarga.Properties.DisplayFormat.FormatString = "n0"
    Me.txtHarga.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtHarga.Properties.EditFormat.FormatString = "n0"
    Me.txtHarga.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtHarga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtHarga.Size = New System.Drawing.Size(114, 20)
    Me.txtHarga.StyleController = Me.lytMasterTermin
    Me.txtHarga.TabIndex = 5
    '
    'txtMataUang
    '
    Me.txtMataUang.EnterMoveNextControl = True
    Me.txtMataUang.Location = New System.Drawing.Point(101, 84)
    Me.txtMataUang.Name = "txtMataUang"
    Me.txtMataUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtMataUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtMataUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtMataUang.Properties.DisplayMember = "Kode"
    Me.txtMataUang.Properties.NullText = ""
    Me.txtMataUang.Properties.ValueMember = "This"
    Me.txtMataUang.Size = New System.Drawing.Size(123, 20)
    Me.txtMataUang.StyleController = Me.lytMasterTermin
    Me.txtMataUang.TabIndex = 4
    '
    'txtNegara
    '
    Me.txtNegara.EnterMoveNextControl = True
    Me.txtNegara.Location = New System.Drawing.Point(101, 108)
    Me.txtNegara.Name = "txtNegara"
    Me.txtNegara.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNegara.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNegara.Properties.Items.AddRange(New Object() {"Afganistan", "Afrika Selatan", "Afrika Tengah", "Albania", "Aljazair", "Amerika Serikat", "Andorra", "Angola", "Antigua dan Barbuda", "Arab Saudi", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahama", "Bahrain", "Bangladesh", "Barbados", "Belanda", "Belarus", "Belgia", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia dan Herzegovina", "Botswana", "Brasil", "Britania Raya", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Ceko", "Chad", "Chili", "China", "Denmark", "Djibouti", "Dominika", "Ekuador", "El Salvador", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Filipina", "Finlandia", "Gabon", "Gambia", "Georgia", "Ghana", "Grenada", "Guatemala", "Guinea", "Guinea Bissau", "Guinea Khatulistiwa", "Guyana", "Haiti", "Honduras", "Hongaria", "India", "Indonesia", "Irak", "Iran", "Irlandia", "Islandia", "Israel", "Italia", "Jamaika", "Jepang", "Jerman", "Kamboja", "Kamerun", "Kanada", "Kazakhstan", "Kenya", "Kirgizstan", "Kiribati", "Kolombia", "Komoro", "Republik Kongo", "Korea Selatan", "Korea Utara", "Kosta Rika", "Kroasia", "Kuba", "Kuwait", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lituania", "Luksemburg", "Madagaskar", "Makedonia", "Maladewa", "Malawi", "Malaysia", "Mali", "Malta", "Maroko", "Marshall", "Mauritania", "Mauritius", "Meksiko", "Mesir", "Mikronesia", "Moldova", "Monako", "Mongolia", "Montenegro", "Mozambik", "Myanmar", "Namibia", "Nauru", "Nepal", "Niger", "Nigeria", "Nikaragua", "Norwegia", "Oman", "Pakistan", "Palau", "Panama", "Pantai Gading", "Papua Nugini", "Paraguay", "Perancis", "Peru", "Polandia", "Portugal", "Qatar", "Republik Demokratik Kongo", "Republik Dominika", "Rumania", "Rusia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Selandia Baru", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapura", "Siprus", "Slovenia", "Slowakia", "Solomon", "Somalia", "Spanyol", "Sri Lanka", "Sudan", "Sudan Selatan", "Suriah", "Suriname", "Swaziland", "Swedia", "Swiss", "Tajikistan", "Tanjung Verde", "Tanzania", "Thailand", "Timor Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turki", "Turkmenistan", "Tuvalu", "Uganda", "Ukraina", "Uni Emirat Arab", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yaman", "Yordania", "Yunani", "Zambia", "Zimbabwe"})
    Me.txtNegara.Size = New System.Drawing.Size(330, 20)
    Me.txtNegara.StyleController = Me.lytMasterTermin
    Me.txtNegara.TabIndex = 6
    '
    'txtExpired
    '
    Me.txtExpired.EditValue = Nothing
    Me.txtExpired.EnterMoveNextControl = True
    Me.txtExpired.Location = New System.Drawing.Point(101, 156)
    Me.txtExpired.Name = "txtExpired"
    Me.txtExpired.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtExpired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtExpired.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtExpired.Properties.DisplayFormat.FormatString = "D"
    Me.txtExpired.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtExpired.Properties.Mask.EditMask = ""
    Me.txtExpired.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtExpired.Size = New System.Drawing.Size(330, 20)
    Me.txtExpired.StyleController = Me.lytMasterTermin
    Me.txtExpired.TabIndex = 8
    '
    'txtKeterangan
    '
    Me.txtKeterangan.EnterMoveNextControl = True
    Me.txtKeterangan.Location = New System.Drawing.Point(101, 180)
    Me.txtKeterangan.Name = "txtKeterangan"
    Me.txtKeterangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKeterangan.Size = New System.Drawing.Size(330, 70)
    Me.txtKeterangan.StyleController = Me.lytMasterTermin
    Me.txtKeterangan.TabIndex = 9
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.LayoutControlItem4})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(443, 262)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtNomorHS
    Me.LayoutControlItem1.CustomizationFormText = "Kode"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(423, 24)
    Me.LayoutControlItem1.Text = "Nomor HS"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtVolume
    Me.LayoutControlItem2.CustomizationFormText = "Jatuh Tempo"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem2.Text = "Volume"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtNomorLampiran
    Me.LayoutControlItem7.CustomizationFormText = "Nomor Lampiran   "
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(423, 24)
    Me.LayoutControlItem7.Text = "Nomor Lampiran   "
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtMataUang
    Me.LayoutControlItem5.CustomizationFormText = "Mata Uang"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem5.Text = "Mata Uang"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtNegara
    Me.LayoutControlItem6.CustomizationFormText = "Negara"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(423, 24)
    Me.LayoutControlItem6.Text = "Negara"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtPelabuhan
    Me.LayoutControlItem8.CustomizationFormText = "Pelabuhan"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(423, 24)
    Me.LayoutControlItem8.Text = "Pelabuhan"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtExpired
    Me.LayoutControlItem9.CustomizationFormText = "Expired"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(423, 24)
    Me.LayoutControlItem9.Text = "Expired"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
    Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
    Me.LayoutControlItem10.Control = Me.txtKeterangan
    Me.LayoutControlItem10.CustomizationFormText = "Keterangan"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 168)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(423, 74)
    Me.LayoutControlItem10.Text = "Keterangan"
    Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.[Default]
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtSatuan
    Me.LayoutControlItem3.CustomizationFormText = "Akan Mendapatkan Diskon"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(216, 48)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(207, 24)
    Me.LayoutControlItem3.Text = "Satuan"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(86, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtHarga
    Me.LayoutControlItem4.CustomizationFormText = "Akan Mendapatkan Denda"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(216, 72)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(207, 24)
    Me.LayoutControlItem4.Text = "Harga"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(86, 13)
    '
    'UI_FusohKuotaImporDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(443, 311)
    Me.Controls.Add(Me.lytMasterTermin)
    Me.Name = "UI_FusohKuotaImporDialog"
    Me.Text = "Kuota Impor :"
    Me.Controls.SetChildIndex(Me.lytMasterTermin, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNomorHS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytMasterTermin.ResumeLayout(False)
    CType(Me.txtPelabuhan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNomorLampiran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtVolume.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNegara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtExpired.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtExpired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtNomorHS As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lytMasterTermin As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNomorLampiran As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPelabuhan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtVolume As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents txtSatuan As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtHarga As DevExpress.XtraEditors.CalcEdit
  Friend WithEvents txtMataUang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNegara As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents txtExpired As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
End Class
