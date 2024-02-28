<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_SaldoCOA
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
    Me.txtPeriodeBulan = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
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
        Me.layRegional = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
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
        CType(Me.layRegional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPeriodeBulan
        '
        Me.txtPeriodeBulan.Location = New System.Drawing.Point(65, 12)
        Me.txtPeriodeBulan.Name = "txtPeriodeBulan"
        Me.txtPeriodeBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPeriodeBulan.Size = New System.Drawing.Size(158, 20)
        Me.txtPeriodeBulan.StyleController = Me.LayoutControl1
        Me.txtPeriodeBulan.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkSaldoNol)
        Me.LayoutControl1.Controls.Add(Me.txtPeriodeAkhir)
        Me.LayoutControl1.Controls.Add(Me.txtPeriodeAwal)
        Me.LayoutControl1.Controls.Add(Me.txtPeriodeTahun)
        Me.LayoutControl1.Controls.Add(Me.txtPeriodeBulan)
        Me.LayoutControl1.Controls.Add(Me.txtRegional)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(566, 136, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(333, 116)
        Me.LayoutControl1.TabIndex = 106
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkSaldoNol
        '
        Me.chkSaldoNol.Location = New System.Drawing.Point(12, 84)
        Me.chkSaldoNol.Name = "chkSaldoNol"
        Me.chkSaldoNol.Properties.Caption = "Tampilkan Saldo Nol"
        Me.chkSaldoNol.Size = New System.Drawing.Size(309, 19)
        Me.chkSaldoNol.StyleController = Me.LayoutControl1
        Me.chkSaldoNol.TabIndex = 106
        '
        'txtPeriodeAkhir
        '
        Me.txtPeriodeAkhir.EditValue = Nothing
        Me.txtPeriodeAkhir.Location = New System.Drawing.Point(188, 36)
        Me.txtPeriodeAkhir.Name = "txtPeriodeAkhir"
        Me.txtPeriodeAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeAkhir.Size = New System.Drawing.Size(133, 20)
        Me.txtPeriodeAkhir.StyleController = Me.LayoutControl1
        Me.txtPeriodeAkhir.TabIndex = 105
        Me.txtPeriodeAkhir.Visible = False
        '
        'txtPeriodeAwal
        '
        Me.txtPeriodeAwal.EditValue = Nothing
        Me.txtPeriodeAwal.Location = New System.Drawing.Point(65, 36)
        Me.txtPeriodeAwal.Name = "txtPeriodeAwal"
        Me.txtPeriodeAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodeAwal.Size = New System.Drawing.Size(119, 20)
        Me.txtPeriodeAwal.StyleController = Me.LayoutControl1
        Me.txtPeriodeAwal.TabIndex = 104
        Me.txtPeriodeAwal.Visible = False
        '
        'txtPeriodeTahun
        '
        Me.txtPeriodeTahun.Location = New System.Drawing.Point(227, 12)
        Me.txtPeriodeTahun.Name = "txtPeriodeTahun"
        Me.txtPeriodeTahun.Properties.Mask.EditMask = "0000"
        Me.txtPeriodeTahun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtPeriodeTahun.Size = New System.Drawing.Size(94, 20)
        Me.txtPeriodeTahun.StyleController = Me.LayoutControl1
        Me.txtPeriodeTahun.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytPeriode1, Me.lytPeriode11, Me.lytPeriode2, Me.lytPeriode22, Me.LayoutControlItem5, Me.layRegional})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(333, 116)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lytPeriode1
        '
        Me.lytPeriode1.Control = Me.txtPeriodeBulan
        Me.lytPeriode1.CustomizationFormText = "Periode"
        Me.lytPeriode1.Location = New System.Drawing.Point(0, 0)
        Me.lytPeriode1.Name = "lytPeriode1"
        Me.lytPeriode1.Size = New System.Drawing.Size(215, 24)
        Me.lytPeriode1.Text = "Periode"
        Me.lytPeriode1.TextSize = New System.Drawing.Size(50, 13)
        '
        'lytPeriode11
        '
        Me.lytPeriode11.Control = Me.txtPeriodeTahun
        Me.lytPeriode11.CustomizationFormText = "Tahun"
        Me.lytPeriode11.Location = New System.Drawing.Point(215, 0)
        Me.lytPeriode11.Name = "lytPeriode11"
        Me.lytPeriode11.Size = New System.Drawing.Size(98, 24)
        Me.lytPeriode11.Text = "Tahun"
        Me.lytPeriode11.TextSize = New System.Drawing.Size(0, 0)
        Me.lytPeriode11.TextToControlDistance = 0
        Me.lytPeriode11.TextVisible = False
        '
        'lytPeriode2
        '
        Me.lytPeriode2.Control = Me.txtPeriodeAwal
        Me.lytPeriode2.CustomizationFormText = "Periode"
        Me.lytPeriode2.Location = New System.Drawing.Point(0, 24)
        Me.lytPeriode2.Name = "lytPeriode2"
        Me.lytPeriode2.Size = New System.Drawing.Size(176, 24)
        Me.lytPeriode2.Text = "Periode"
        Me.lytPeriode2.TextSize = New System.Drawing.Size(50, 13)
        '
        'lytPeriode22
        '
        Me.lytPeriode22.Control = Me.txtPeriodeAkhir
        Me.lytPeriode22.CustomizationFormText = "Tahun"
        Me.lytPeriode22.Location = New System.Drawing.Point(176, 24)
        Me.lytPeriode22.Name = "lytPeriode22"
        Me.lytPeriode22.Size = New System.Drawing.Size(137, 24)
        Me.lytPeriode22.Text = "Tahun"
        Me.lytPeriode22.TextSize = New System.Drawing.Size(0, 0)
        Me.lytPeriode22.TextToControlDistance = 0
        Me.lytPeriode22.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkSaldoNol
        Me.LayoutControlItem5.CustomizationFormText = "TampilkanSaldoNol"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(313, 24)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'layRegional
        '
        Me.layRegional.Control = Me.txtRegional
        Me.layRegional.CustomizationFormText = "Regional   "
        Me.layRegional.Location = New System.Drawing.Point(0, 48)
        Me.layRegional.Name = "layRegional"
        Me.layRegional.Size = New System.Drawing.Size(313, 24)
        Me.layRegional.Text = "Regional   "
        Me.layRegional.TextSize = New System.Drawing.Size(50, 13)
        '
        'txtRegional
        '
        Me.txtRegional.Location = New System.Drawing.Point(65, 60)
        Me.txtRegional.Name = "txtRegional"
        Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtRegional.Properties.DisplayMember = "Nama"
        Me.txtRegional.Properties.NullText = "<Semua Regional>"
        Me.txtRegional.Properties.PopupSizeable = False
        Me.txtRegional.Properties.ShowHeader = False
        Me.txtRegional.Properties.ValueMember = "This"
        Me.txtRegional.Size = New System.Drawing.Size(256, 20)
        Me.txtRegional.StyleController = Me.LayoutControl1
        Me.txtRegional.TabIndex = 107
        '
        'RF_SaldoCOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 165)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "RF_SaldoCOA"
        Me.Text = "Filter Laporan - Neraca"
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
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
        CType(Me.layRegional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents layRegional As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
End Class
