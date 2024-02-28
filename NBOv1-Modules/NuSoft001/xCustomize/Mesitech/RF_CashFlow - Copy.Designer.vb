<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_CashFlowMesitechx
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
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtLevel = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtDivisi = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtSubProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.chkSaldoNol = New DevExpress.XtraEditors.CheckEdit()
    Me.txtPeriodeAkhir = New DevExpress.XtraEditors.DateEdit()
    Me.txtPeriodeAwal = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytLevel = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytLevel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtLevel)
    Me.LayoutControl1.Controls.Add(Me.txtDivisi)
    Me.LayoutControl1.Controls.Add(Me.txtSubProyek)
    Me.LayoutControl1.Controls.Add(Me.txtProyek)
    Me.LayoutControl1.Controls.Add(Me.chkSaldoNol)
    Me.LayoutControl1.Controls.Add(Me.txtPeriodeAkhir)
    Me.LayoutControl1.Controls.Add(Me.txtPeriodeAwal)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(566, 136, 534, 549)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(410, 228)
    Me.LayoutControl1.TabIndex = 108
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtLevel
    '
    Me.txtLevel.Location = New System.Drawing.Point(102, 139)
    Me.txtLevel.Name = "txtLevel"
    Me.txtLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtLevel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Level")})
    Me.txtLevel.Properties.DisplayMember = "Value"
    Me.txtLevel.Properties.NullText = ""
    Me.txtLevel.Properties.ValueMember = "Key"
    Me.txtLevel.Size = New System.Drawing.Size(284, 20)
    Me.txtLevel.StyleController = Me.LayoutControl1
    Me.txtLevel.TabIndex = 112
    '
    'txtDivisi
    '
    Me.txtDivisi.Location = New System.Drawing.Point(102, 91)
    Me.txtDivisi.Name = "txtDivisi"
    Me.txtDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 40, "Nama")})
    Me.txtDivisi.Properties.DisplayMember = "Kode"
    Me.txtDivisi.Properties.NullText = "<Pilih Divisi>"
    Me.txtDivisi.Properties.ValueMember = "This"
    Me.txtDivisi.Size = New System.Drawing.Size(284, 20)
    Me.txtDivisi.StyleController = Me.LayoutControl1
    Me.txtDivisi.TabIndex = 111
    '
    'txtSubProyek
    '
    Me.txtSubProyek.Location = New System.Drawing.Point(102, 67)
    Me.txtSubProyek.Name = "txtSubProyek"
    Me.txtSubProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSubProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 50, "Nama")})
    Me.txtSubProyek.Properties.DisplayMember = "Kode"
    Me.txtSubProyek.Properties.NullText = "<Pilih Sub Proyek>"
    Me.txtSubProyek.Properties.ValueMember = "This"
    Me.txtSubProyek.Size = New System.Drawing.Size(284, 20)
    Me.txtSubProyek.StyleController = Me.LayoutControl1
    Me.txtSubProyek.TabIndex = 110
    '
    'txtProyek
    '
    Me.txtProyek.Location = New System.Drawing.Point(102, 43)
    Me.txtProyek.Name = "txtProyek"
    Me.txtProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
    Me.txtProyek.Properties.DisplayMember = "Kode"
    Me.txtProyek.Properties.NullText = "<Pilih Proyek>"
    Me.txtProyek.Properties.ValueMember = "This"
    Me.txtProyek.Size = New System.Drawing.Size(284, 20)
    Me.txtProyek.StyleController = Me.LayoutControl1
    Me.txtProyek.TabIndex = 107
    '
    'chkSaldoNol
    '
    Me.chkSaldoNol.Location = New System.Drawing.Point(24, 163)
    Me.chkSaldoNol.Name = "chkSaldoNol"
    Me.chkSaldoNol.Properties.Caption = "Tampilkan Saldo Nol"
    Me.chkSaldoNol.Size = New System.Drawing.Size(362, 19)
    Me.chkSaldoNol.StyleController = Me.LayoutControl1
    Me.chkSaldoNol.TabIndex = 106
    '
    'txtPeriodeAkhir
    '
    Me.txtPeriodeAkhir.EditValue = Nothing
    Me.txtPeriodeAkhir.Location = New System.Drawing.Point(284, 115)
    Me.txtPeriodeAkhir.Name = "txtPeriodeAkhir"
    Me.txtPeriodeAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Size = New System.Drawing.Size(102, 20)
    Me.txtPeriodeAkhir.StyleController = Me.LayoutControl1
    Me.txtPeriodeAkhir.TabIndex = 105
    Me.txtPeriodeAkhir.Visible = False
    '
    'txtPeriodeAwal
    '
    Me.txtPeriodeAwal.EditValue = Nothing
    Me.txtPeriodeAwal.Location = New System.Drawing.Point(102, 115)
    Me.txtPeriodeAwal.Name = "txtPeriodeAwal"
    Me.txtPeriodeAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Size = New System.Drawing.Size(100, 20)
    Me.txtPeriodeAwal.StyleController = Me.LayoutControl1
    Me.txtPeriodeAwal.TabIndex = 104
    Me.txtPeriodeAwal.Visible = False
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(410, 228)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Filter Data"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.lytPeriode1, Me.lytPeriode2, Me.LayoutControlItem5, Me.lytLevel})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(390, 208)
    Me.LayoutControlGroup2.Text = "Filter Data"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtProyek
    Me.LayoutControlItem1.CustomizationFormText = "Proyek"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(366, 24)
    Me.LayoutControlItem1.Text = "Proyek"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtSubProyek
    Me.LayoutControlItem2.CustomizationFormText = "Sub Proyek"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(366, 24)
    Me.LayoutControlItem2.Text = "Sub Proyek"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtDivisi
    Me.LayoutControlItem3.CustomizationFormText = "Divisi"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(366, 24)
    Me.LayoutControlItem3.Text = "Divisi"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(75, 13)
    '
    'lytPeriode1
    '
    Me.lytPeriode1.Control = Me.txtPeriodeAwal
    Me.lytPeriode1.CustomizationFormText = "Periode"
    Me.lytPeriode1.Location = New System.Drawing.Point(0, 72)
    Me.lytPeriode1.Name = "lytPeriode1"
    Me.lytPeriode1.Size = New System.Drawing.Size(182, 24)
    Me.lytPeriode1.Text = "Periode"
    Me.lytPeriode1.TextSize = New System.Drawing.Size(75, 13)
    '
    'lytPeriode2
    '
    Me.lytPeriode2.Control = Me.txtPeriodeAkhir
    Me.lytPeriode2.CustomizationFormText = "Periode2"
    Me.lytPeriode2.Location = New System.Drawing.Point(182, 72)
    Me.lytPeriode2.Name = "lytPeriode2"
    Me.lytPeriode2.Size = New System.Drawing.Size(184, 24)
    Me.lytPeriode2.Text = "s/d"
    Me.lytPeriode2.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.chkSaldoNol
    Me.LayoutControlItem5.CustomizationFormText = "TampilkanSaldoNol"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(366, 45)
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'lytLevel
    '
    Me.lytLevel.Control = Me.txtLevel
    Me.lytLevel.CustomizationFormText = "Tampilkan Level"
    Me.lytLevel.Location = New System.Drawing.Point(0, 96)
    Me.lytLevel.Name = "lytLevel"
    Me.lytLevel.Size = New System.Drawing.Size(366, 24)
    Me.lytLevel.Text = "Tampilkan Level"
    Me.lytLevel.TextSize = New System.Drawing.Size(75, 13)
    '
    'RF_CashFlowMesitech
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(410, 277)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_CashFlowMesitech"
    Me.Text = "RF_CashFlow"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytLevel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents txtLevel As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtDivisi As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtSubProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents chkSaldoNol As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtPeriodeAkhir As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtPeriodeAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytLevel As DevExpress.XtraLayout.LayoutControlItem
End Class
