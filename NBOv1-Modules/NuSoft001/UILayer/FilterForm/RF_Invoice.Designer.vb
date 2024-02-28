<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_Invoice
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
    Me.txtPeriodeAkhir = New DevExpress.XtraEditors.DateEdit()
    Me.txtPeriodeAwal = New DevExpress.XtraEditors.DateEdit()
    Me.txtNoMemo = New DevExpress.XtraEditors.TextEdit()
    Me.txtProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytPeriode1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoMemo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtPeriodeAkhir)
    Me.LayoutControl1.Controls.Add(Me.txtPeriodeAwal)
    Me.LayoutControl1.Controls.Add(Me.txtNoMemo)
    Me.LayoutControl1.Controls.Add(Me.txtProyek)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(566, 136, 534, 549)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(444, 171)
    Me.LayoutControl1.TabIndex = 107
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtPeriodeAkhir
    '
    Me.txtPeriodeAkhir.EditValue = Nothing
    Me.txtPeriodeAkhir.Location = New System.Drawing.Point(288, 43)
    Me.txtPeriodeAkhir.Name = "txtPeriodeAkhir"
    Me.txtPeriodeAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Size = New System.Drawing.Size(132, 20)
    Me.txtPeriodeAkhir.StyleController = Me.LayoutControl1
    Me.txtPeriodeAkhir.TabIndex = 105
    Me.txtPeriodeAkhir.Visible = False
    '
    'txtPeriodeAwal
    '
    Me.txtPeriodeAwal.EditValue = Nothing
    Me.txtPeriodeAwal.Location = New System.Drawing.Point(89, 43)
    Me.txtPeriodeAwal.Name = "txtPeriodeAwal"
    Me.txtPeriodeAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Size = New System.Drawing.Size(130, 20)
    Me.txtPeriodeAwal.StyleController = Me.LayoutControl1
    Me.txtPeriodeAwal.TabIndex = 104
    Me.txtPeriodeAwal.Visible = False
    '
    'txtNoMemo
    '
    Me.txtNoMemo.EditValue = ""
    Me.txtNoMemo.Location = New System.Drawing.Point(89, 67)
    Me.txtNoMemo.Name = "txtNoMemo"
    Me.txtNoMemo.Properties.NullText = "[EditValue is null]"
    Me.txtNoMemo.Size = New System.Drawing.Size(331, 20)
    Me.txtNoMemo.StyleController = Me.LayoutControl1
    Me.txtNoMemo.TabIndex = 107
    '
    'txtProyek
    '
    Me.txtProyek.Location = New System.Drawing.Point(89, 91)
    Me.txtProyek.Name = "txtProyek"
    Me.txtProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 40, "Nama")})
    Me.txtProyek.Properties.DisplayMember = "Kode"
    Me.txtProyek.Properties.NullText = "<Pilih Proyek>"
    Me.txtProyek.Properties.ValueMember = "Kode"
    Me.txtProyek.Size = New System.Drawing.Size(331, 20)
    Me.txtProyek.StyleController = Me.LayoutControl1
    Me.txtProyek.TabIndex = 108
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(444, 171)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Filter Data"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytPeriode1, Me.lytPeriode2, Me.LayoutControlItem1, Me.LayoutControlItem2})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(424, 115)
    Me.LayoutControlGroup2.Text = "Filter Data"
    '
    'lytPeriode1
    '
    Me.lytPeriode1.Control = Me.txtPeriodeAwal
    Me.lytPeriode1.CustomizationFormText = "Periode"
    Me.lytPeriode1.Location = New System.Drawing.Point(0, 0)
    Me.lytPeriode1.Name = "lytPeriode1"
    Me.lytPeriode1.Size = New System.Drawing.Size(199, 24)
    Me.lytPeriode1.Text = "Tgl Memo AR"
    Me.lytPeriode1.TextSize = New System.Drawing.Size(62, 13)
    '
    'lytPeriode2
    '
    Me.lytPeriode2.Control = Me.txtPeriodeAkhir
    Me.lytPeriode2.CustomizationFormText = "Periode2"
    Me.lytPeriode2.Location = New System.Drawing.Point(199, 0)
    Me.lytPeriode2.Name = "lytPeriode2"
    Me.lytPeriode2.Size = New System.Drawing.Size(201, 24)
    Me.lytPeriode2.Text = "s/d"
    Me.lytPeriode2.TextSize = New System.Drawing.Size(62, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtNoMemo
    Me.LayoutControlItem1.CustomizationFormText = "No Memo AR"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(400, 24)
    Me.LayoutControlItem1.Text = "No Memo AR"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(62, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtProyek
    Me.LayoutControlItem2.CustomizationFormText = "Project"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(400, 24)
    Me.LayoutControlItem2.Text = "Project"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(62, 13)
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 115)
    Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
    Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(424, 10)
    Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 125)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(424, 26)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'RF_Invoice
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(444, 220)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_Invoice"
    Me.Text = "Filter Saldo GL"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoMemo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents txtPeriodeAkhir As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtPeriodeAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents lytPeriode1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtNoMemo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
