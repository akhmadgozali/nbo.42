<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_SaldoCOAGlobal
  Inherits Core.Win.Forms.FilterForm

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
    Me.txtPeriodeBulan = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtDivisi = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTipeLR = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTipeNeraca = New DevExpress.XtraEditors.LookUpEdit()
    Me.chkSaldoNol = New DevExpress.XtraEditors.CheckEdit()
    Me.txtPeriodeAkhir = New DevExpress.XtraEditors.DateEdit()
    Me.txtPeriodeAwal = New DevExpress.XtraEditors.DateEdit()
    Me.txtPeriodeTahun = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytPeriode1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytNeraca = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytLR = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytDivisi = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytProyek = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipeLR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipeNeraca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytPeriode11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytPeriode22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytNeraca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytProyek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPeriodeBulan
        '
        Me.txtPeriodeBulan.Location = New System.Drawing.Point(56, 60)
        Me.txtPeriodeBulan.Name = "txtPeriodeBulan"
        Me.txtPeriodeBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPeriodeBulan.Size = New System.Drawing.Size(186, 20)
        Me.txtPeriodeBulan.StyleController = Me.LayoutControl1
        Me.txtPeriodeBulan.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtProyek)
        Me.LayoutControl1.Controls.Add(Me.txtDivisi)
        Me.LayoutControl1.Controls.Add(Me.txtTipeLR)
        Me.LayoutControl1.Controls.Add(Me.txtRegional)
        Me.LayoutControl1.Controls.Add(Me.txtTipeNeraca)
        Me.LayoutControl1.Controls.Add(Me.chkSaldoNol)
        Me.LayoutControl1.Controls.Add(Me.txtPeriodeAkhir)
        Me.LayoutControl1.Controls.Add(Me.txtPeriodeAwal)
        Me.LayoutControl1.Controls.Add(Me.txtPeriodeTahun)
        Me.LayoutControl1.Controls.Add(Me.txtPeriodeBulan)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(566, 136, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(374, 212)
        Me.LayoutControl1.TabIndex = 106
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtProyek
        '
        Me.txtProyek.Location = New System.Drawing.Point(56, 156)
        Me.txtProyek.Name = "txtProyek"
        Me.txtProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtProyek.Properties.DisplayMember = "Kode"
        Me.txtProyek.Properties.NullText = "<Pilih Proyek>"
        Me.txtProyek.Properties.ValueMember = "This"
        Me.txtProyek.Size = New System.Drawing.Size(306, 20)
        Me.txtProyek.StyleController = Me.LayoutControl1
        Me.txtProyek.TabIndex = 111
        '
        'txtDivisi
        '
        Me.txtDivisi.Location = New System.Drawing.Point(56, 132)
        Me.txtDivisi.Name = "txtDivisi"
        Me.txtDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtDivisi.Properties.DisplayMember = "Kode"
        Me.txtDivisi.Properties.NullText = "<Pilih Divisi>"
        Me.txtDivisi.Properties.ValueMember = "This"
        Me.txtDivisi.Size = New System.Drawing.Size(306, 20)
        Me.txtDivisi.StyleController = Me.LayoutControl1
        Me.txtDivisi.TabIndex = 110
        '
        'txtTipeLR
        '
        Me.txtTipeLR.Location = New System.Drawing.Point(56, 36)
        Me.txtTipeLR.Name = "txtTipeLR"
        Me.txtTipeLR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTipeLR.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Tipe")})
        Me.txtTipeLR.Properties.DisplayMember = "Value"
        Me.txtTipeLR.Properties.NullText = "<Pilih Tipe Report>"
        Me.txtTipeLR.Properties.ValueMember = "Key"
        Me.txtTipeLR.Size = New System.Drawing.Size(306, 20)
        Me.txtTipeLR.StyleController = Me.LayoutControl1
        Me.txtTipeLR.TabIndex = 109
        '
        'txtRegional
        '
        Me.txtRegional.Location = New System.Drawing.Point(56, 108)
        Me.txtRegional.Name = "txtRegional"
        Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtRegional.Properties.DisplayMember = "Nama"
        Me.txtRegional.Properties.NullText = "<Semua Regional>"
        Me.txtRegional.Properties.ShowHeader = False
        Me.txtRegional.Properties.ValueMember = "This"
        Me.txtRegional.Size = New System.Drawing.Size(306, 20)
        Me.txtRegional.StyleController = Me.LayoutControl1
        Me.txtRegional.TabIndex = 108
        '
        'txtTipeNeraca
        '
        Me.txtTipeNeraca.Location = New System.Drawing.Point(56, 12)
        Me.txtTipeNeraca.Name = "txtTipeNeraca"
        Me.txtTipeNeraca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTipeNeraca.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Tipe")})
        Me.txtTipeNeraca.Properties.DisplayMember = "Value"
        Me.txtTipeNeraca.Properties.NullText = "<Pilih Tipe Report>"
        Me.txtTipeNeraca.Properties.ValueMember = "Key"
        Me.txtTipeNeraca.Size = New System.Drawing.Size(291, 20)
        Me.txtTipeNeraca.StyleController = Me.LayoutControl1
        Me.txtTipeNeraca.TabIndex = 107
        '
        'chkSaldoNol
        '
        Me.chkSaldoNol.Location = New System.Drawing.Point(12, 180)
        Me.chkSaldoNol.Name = "chkSaldoNol"
        Me.chkSaldoNol.Properties.Caption = "Tampilkan Saldo Nol"
        Me.chkSaldoNol.Size = New System.Drawing.Size(350, 19)
        Me.chkSaldoNol.StyleController = Me.LayoutControl1
        Me.chkSaldoNol.TabIndex = 106
        '
        'txtPeriodeAkhir
        '
        Me.txtPeriodeAkhir.EditValue = Nothing
        Me.txtPeriodeAkhir.Location = New System.Drawing.Point(203, 84)
        Me.txtPeriodeAkhir.Name = "txtPeriodeAkhir"
        Me.txtPeriodeAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeAkhir.Size = New System.Drawing.Size(159, 20)
        Me.txtPeriodeAkhir.StyleController = Me.LayoutControl1
        Me.txtPeriodeAkhir.TabIndex = 105
        Me.txtPeriodeAkhir.Visible = False
        '
        'txtPeriodeAwal
        '
        Me.txtPeriodeAwal.EditValue = Nothing
        Me.txtPeriodeAwal.Location = New System.Drawing.Point(56, 84)
        Me.txtPeriodeAwal.Name = "txtPeriodeAwal"
        Me.txtPeriodeAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeAwal.Size = New System.Drawing.Size(143, 20)
        Me.txtPeriodeAwal.StyleController = Me.LayoutControl1
        Me.txtPeriodeAwal.TabIndex = 104
        Me.txtPeriodeAwal.Visible = False
        '
        'txtPeriodeTahun
        '
        Me.txtPeriodeTahun.Location = New System.Drawing.Point(246, 60)
        Me.txtPeriodeTahun.Name = "txtPeriodeTahun"
        Me.txtPeriodeTahun.Properties.Mask.EditMask = "0000"
        Me.txtPeriodeTahun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtPeriodeTahun.Size = New System.Drawing.Size(116, 20)
        Me.txtPeriodeTahun.StyleController = Me.LayoutControl1
        Me.txtPeriodeTahun.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytPeriode1, Me.lytPeriode11, Me.lytPeriode2, Me.lytPeriode22, Me.LayoutControlItem5, Me.lytNeraca, Me.lytRegional, Me.lytLR, Me.lytDivisi, Me.lytProyek})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(374, 212)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lytPeriode1
        '
        Me.lytPeriode1.Control = Me.txtPeriodeBulan
        Me.lytPeriode1.CustomizationFormText = "Periode"
        Me.lytPeriode1.Location = New System.Drawing.Point(0, 48)
        Me.lytPeriode1.Name = "lytPeriode1"
        Me.lytPeriode1.Size = New System.Drawing.Size(234, 24)
        Me.lytPeriode1.Text = "Periode"
        Me.lytPeriode1.TextSize = New System.Drawing.Size(41, 13)
        '
        'lytPeriode11
        '
        Me.lytPeriode11.Control = Me.txtPeriodeTahun
        Me.lytPeriode11.CustomizationFormText = "Tahun"
        Me.lytPeriode11.Location = New System.Drawing.Point(234, 48)
        Me.lytPeriode11.Name = "lytPeriode11"
        Me.lytPeriode11.Size = New System.Drawing.Size(120, 24)
        Me.lytPeriode11.Text = "Tahun"
        Me.lytPeriode11.TextSize = New System.Drawing.Size(0, 0)
        Me.lytPeriode11.TextToControlDistance = 0
        Me.lytPeriode11.TextVisible = False
        '
        'lytPeriode2
        '
        Me.lytPeriode2.Control = Me.txtPeriodeAwal
        Me.lytPeriode2.CustomizationFormText = "Periode"
        Me.lytPeriode2.Location = New System.Drawing.Point(0, 72)
        Me.lytPeriode2.Name = "lytPeriode2"
        Me.lytPeriode2.Size = New System.Drawing.Size(191, 24)
        Me.lytPeriode2.Text = "Periode"
        Me.lytPeriode2.TextSize = New System.Drawing.Size(41, 13)
        Me.lytPeriode2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lytPeriode22
        '
        Me.lytPeriode22.Control = Me.txtPeriodeAkhir
        Me.lytPeriode22.CustomizationFormText = "Tahun"
        Me.lytPeriode22.Location = New System.Drawing.Point(191, 72)
        Me.lytPeriode22.Name = "lytPeriode22"
        Me.lytPeriode22.Size = New System.Drawing.Size(163, 24)
        Me.lytPeriode22.Text = "Tahun"
        Me.lytPeriode22.TextSize = New System.Drawing.Size(0, 0)
        Me.lytPeriode22.TextToControlDistance = 0
        Me.lytPeriode22.TextVisible = False
        Me.lytPeriode22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkSaldoNol
        Me.LayoutControlItem5.CustomizationFormText = "TampilkanSaldoNol"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(354, 24)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'lytNeraca
        '
        Me.lytNeraca.Control = Me.txtTipeNeraca
        Me.lytNeraca.CustomizationFormText = "Tipe"
        Me.lytNeraca.Location = New System.Drawing.Point(0, 0)
        Me.lytNeraca.MaxSize = New System.Drawing.Size(339, 24)
        Me.lytNeraca.MinSize = New System.Drawing.Size(339, 24)
        Me.lytNeraca.Name = "lytNeraca"
        Me.lytNeraca.Size = New System.Drawing.Size(354, 24)
        Me.lytNeraca.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lytNeraca.Text = "Tipe"
        Me.lytNeraca.TextSize = New System.Drawing.Size(41, 13)
        Me.lytNeraca.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lytRegional
        '
        Me.lytRegional.Control = Me.txtRegional
        Me.lytRegional.CustomizationFormText = "Regional"
        Me.lytRegional.Location = New System.Drawing.Point(0, 96)
        Me.lytRegional.Name = "lytRegional"
        Me.lytRegional.Size = New System.Drawing.Size(354, 24)
        Me.lytRegional.Text = "Regional"
        Me.lytRegional.TextSize = New System.Drawing.Size(41, 13)
        Me.lytRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lytLR
        '
        Me.lytLR.Control = Me.txtTipeLR
        Me.lytLR.CustomizationFormText = "Tipe"
        Me.lytLR.Location = New System.Drawing.Point(0, 24)
        Me.lytLR.Name = "lytLR"
        Me.lytLR.Size = New System.Drawing.Size(354, 24)
        Me.lytLR.Text = "Tipe"
        Me.lytLR.TextSize = New System.Drawing.Size(41, 13)
        Me.lytLR.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lytDivisi
        '
        Me.lytDivisi.Control = Me.txtDivisi
        Me.lytDivisi.CustomizationFormText = "Divisi"
        Me.lytDivisi.Location = New System.Drawing.Point(0, 120)
        Me.lytDivisi.Name = "lytDivisi"
        Me.lytDivisi.Size = New System.Drawing.Size(354, 24)
        Me.lytDivisi.Text = "Divisi"
        Me.lytDivisi.TextSize = New System.Drawing.Size(41, 13)
        Me.lytDivisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lytProyek
        '
        Me.lytProyek.Control = Me.txtProyek
        Me.lytProyek.CustomizationFormText = "Proyek"
        Me.lytProyek.Location = New System.Drawing.Point(0, 144)
        Me.lytProyek.Name = "lytProyek"
        Me.lytProyek.Size = New System.Drawing.Size(354, 24)
        Me.lytProyek.Text = "Proyek"
        Me.lytProyek.TextSize = New System.Drawing.Size(41, 13)
        Me.lytProyek.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'RF_SaldoCOAGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 261)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "RF_SaldoCOAGlobal"
        Me.Text = "Filter Laporan - Neraca"
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipeLR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipeNeraca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytPeriode11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytPeriode22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytNeraca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytLR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytProyek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPeriodeBulan As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents txtPeriodeTahun As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPeriodeAkhir As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtPeriodeAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents lytPeriode1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents chkSaldoNol As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTipeNeraca As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytNeraca As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTipeLR As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytLR As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtDivisi As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytDivisi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytProyek As DevExpress.XtraLayout.LayoutControlItem
End Class
