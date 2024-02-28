<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SaldoAwalDialog
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
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.txtCOA = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontak = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiValas = New DevExpress.XtraEditors.TextEdit()
    Me.txtKurs = New DevExpress.XtraEditors.TextEdit()
    Me.txtUang = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilai = New DevExpress.XtraEditors.TextEdit()
    Me.lytTransaksiGroup = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksi.SuspendLayout()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiValas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTransaksiGroup, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(274, 67)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.ReadOnly = True
    Me.txtTanggal.Size = New System.Drawing.Size(121, 20)
    Me.txtTanggal.StyleController = Me.lytTransaksi
    Me.txtTanggal.TabIndex = 100
    '
    'lytTransaksi
    '
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.txtCOA)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiValas)
    Me.lytTransaksi.Controls.Add(Me.txtKurs)
    Me.lytTransaksi.Controls.Add(Me.txtUang)
    Me.lytTransaksi.Controls.Add(Me.txtNilai)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(474, 59, 250, 350)
    Me.lytTransaksi.Root = Me.lytTransaksiGroup
    Me.lytTransaksi.Size = New System.Drawing.Size(419, 260)
    Me.lytTransaksi.TabIndex = 105
    Me.lytTransaksi.Text = "lytTransaksi"
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(79, 67)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Kode"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(121, 20)
    Me.txtRegional.StyleController = Me.lytTransaksi
    Me.txtRegional.TabIndex = 104
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(274, 43)
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Properties.DisplayFormat.FormatString = "D"
    Me.txtNoTransaksi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtNoTransaksi.Properties.ReadOnly = True
    Me.txtNoTransaksi.Size = New System.Drawing.Size(121, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksi
    Me.txtNoTransaksi.TabIndex = 102
    '
    'txtCOA
    '
    Me.txtCOA.Location = New System.Drawing.Point(79, 134)
    Me.txtCOA.Name = "txtCOA"
    Me.txtCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCOA.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtCOA.Properties.DisplayFormat.FormatString = "D"
    Me.txtCOA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtCOA.Properties.DisplayMember = "Kode"
    Me.txtCOA.Properties.NullText = ""
    Me.txtCOA.Properties.ValueMember = "This"
    Me.txtCOA.Size = New System.Drawing.Size(122, 20)
    Me.txtCOA.StyleController = Me.lytTransaksi
    Me.txtCOA.TabIndex = 102
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(79, 43)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtKontak.Properties.DisplayFormat.FormatString = "D"
    Me.txtKontak.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = ""
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Size = New System.Drawing.Size(121, 20)
    Me.txtKontak.StyleController = Me.lytTransaksi
    Me.txtKontak.TabIndex = 102
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(79, 206)
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Properties.DisplayFormat.FormatString = "D"
    Me.txtUraian.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtUraian.Size = New System.Drawing.Size(316, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 102
    '
    'txtNilaiValas
    '
    Me.txtNilaiValas.Location = New System.Drawing.Point(275, 182)
    Me.txtNilaiValas.Name = "txtNilaiValas"
    Me.txtNilaiValas.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilaiValas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilaiValas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilaiValas.Properties.DisplayFormat.FormatString = "D"
    Me.txtNilaiValas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtNilaiValas.Properties.Mask.EditMask = "n2"
    Me.txtNilaiValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilaiValas.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilaiValas.Properties.ReadOnly = True
    Me.txtNilaiValas.Size = New System.Drawing.Size(120, 20)
    Me.txtNilaiValas.StyleController = Me.lytTransaksi
    Me.txtNilaiValas.TabIndex = 102
    '
    'txtKurs
    '
    Me.txtKurs.Location = New System.Drawing.Point(275, 158)
    Me.txtKurs.Name = "txtKurs"
    Me.txtKurs.Properties.Appearance.Options.UseTextOptions = True
    Me.txtKurs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtKurs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKurs.Properties.DisplayFormat.FormatString = "D"
    Me.txtKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtKurs.Properties.Mask.EditMask = "n2"
    Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtKurs.Properties.ReadOnly = True
    Me.txtKurs.Size = New System.Drawing.Size(120, 20)
    Me.txtKurs.StyleController = Me.lytTransaksi
    Me.txtKurs.TabIndex = 102
    '
    'txtUang
    '
    Me.txtUang.Location = New System.Drawing.Point(275, 134)
    Me.txtUang.Name = "txtUang"
    Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUang.Properties.DisplayFormat.FormatString = "D"
    Me.txtUang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtUang.Properties.ReadOnly = True
    Me.txtUang.Size = New System.Drawing.Size(120, 20)
    Me.txtUang.StyleController = Me.lytTransaksi
    Me.txtUang.TabIndex = 102
    '
    'txtNilai
    '
    Me.txtNilai.Location = New System.Drawing.Point(79, 158)
    Me.txtNilai.Name = "txtNilai"
    Me.txtNilai.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilai.Properties.DisplayFormat.FormatString = "n2"
    Me.txtNilai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtNilai.Properties.Mask.EditMask = "n2"
    Me.txtNilai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilai.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilai.Size = New System.Drawing.Size(122, 20)
    Me.txtNilai.StyleController = Me.lytTransaksi
    Me.txtNilai.TabIndex = 102
    '
    'lytTransaksiGroup
    '
    Me.lytTransaksiGroup.CustomizationFormText = "LayoutControlGroup1"
    Me.lytTransaksiGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.lytTransaksiGroup.GroupBordersVisible = False
    Me.lytTransaksiGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
    Me.lytTransaksiGroup.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksiGroup.Name = "lytTransaksiGroup"
    Me.lytTransaksiGroup.Size = New System.Drawing.Size(419, 260)
    Me.lytTransaksiGroup.Text = "lytTransaksiGroup"
    Me.lytTransaksiGroup.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem12, Me.LayoutControlItem2, Me.LayoutControlItem1})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(399, 91)
    Me.LayoutControlGroup2.Text = "Info Utama"
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKontak
    Me.LayoutControlItem5.CustomizationFormText = "Kontak"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(180, 24)
    Me.LayoutControlItem5.Text = "Kontak"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtRegional
    Me.LayoutControlItem12.CustomizationFormText = "Regional"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(180, 24)
    Me.LayoutControlItem12.Text = "Regional"
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtNoTransaksi
    Me.LayoutControlItem2.CustomizationFormText = "No. Bukti"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(180, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(195, 24)
    Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem2.Text = "No. Bukti"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTanggal
    Me.LayoutControlItem1.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(180, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(195, 24)
    Me.LayoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem1.Text = "Tanggal"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Data Saldo"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem8, Me.LayoutControlItem7, Me.LayoutControlItem11, Me.LayoutControlItem10, Me.LayoutControlItem9})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 91)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(399, 149)
    Me.LayoutControlGroup3.Text = "Data Saldo"
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtCOA
    Me.LayoutControlItem3.CustomizationFormText = "CoA"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(181, 24)
    Me.LayoutControlItem3.Text = "CoA"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtNilai
    Me.LayoutControlItem8.CustomizationFormText = "Nilai"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(181, 48)
    Me.LayoutControlItem8.Text = "Nilai"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtUraian
    Me.LayoutControlItem7.CustomizationFormText = "Uraian"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(375, 34)
    Me.LayoutControlItem7.Text = "Uraian"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtNilaiValas
    Me.LayoutControlItem11.CustomizationFormText = "Valas"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(181, 48)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem11.Text = "Valas"
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtKurs
    Me.LayoutControlItem10.CustomizationFormText = "Kurs"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(181, 24)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem10.Text = "Kurs"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(52, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtUang
    Me.LayoutControlItem9.CustomizationFormText = "Mata Uang"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(181, 0)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem9.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem9.Text = "Mata Uang"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(52, 13)
    '
    'UI_SaldoAwalDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(419, 309)
    Me.Controls.Add(Me.lytTransaksi)
    Me.Name = "UI_SaldoAwalDialog"
    Me.Text = "Saldo Awal"
    Me.Controls.SetChildIndex(Me.lytTransaksi, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksi.ResumeLayout(False)
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiValas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTransaksiGroup, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtUang As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNilaiValas As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtCOA As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytTransaksi As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents lytTransaksiGroup As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtNilai As DevExpress.XtraEditors.TextEdit
End Class
