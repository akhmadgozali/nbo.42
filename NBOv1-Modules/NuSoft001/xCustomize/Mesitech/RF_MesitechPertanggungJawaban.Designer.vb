<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_MesitechPertanggungJawaban
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
    Me.treeAkun = New DevExpress.XtraTreeList.TreeList()
    Me.colKode = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colNama = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.txtLevel = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtSubProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.chkSaldoNol = New DevExpress.XtraEditors.CheckEdit()
    Me.txtPeriodeAkhir = New DevExpress.XtraEditors.DateEdit()
    Me.txtPeriodeAwal = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytLevel = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.treeAkun, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytLevel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.treeAkun)
    Me.LayoutControl1.Controls.Add(Me.txtLevel)
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
    Me.LayoutControl1.Size = New System.Drawing.Size(485, 314)
    Me.LayoutControl1.TabIndex = 109
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'treeAkun
    '
    Me.treeAkun.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colKode, Me.colNama})
    Me.treeAkun.KeyFieldName = "This"
    Me.treeAkun.Location = New System.Drawing.Point(24, 46)
    Me.treeAkun.Name = "treeAkun"
    Me.treeAkun.OptionsBehavior.AllowRecursiveNodeChecking = True
    Me.treeAkun.OptionsBehavior.PopulateServiceColumns = True
    Me.treeAkun.OptionsView.ShowCheckBoxes = True
    Me.treeAkun.ParentFieldName = "Induk!"
    Me.treeAkun.Size = New System.Drawing.Size(437, 244)
    Me.treeAkun.TabIndex = 113
    '
    'colKode
    '
    Me.colKode.Caption = "Kode Akun"
    Me.colKode.FieldName = "Kode"
    Me.colKode.MinWidth = 34
    Me.colKode.Name = "colKode"
    Me.colKode.OptionsColumn.AllowEdit = False
    Me.colKode.OptionsColumn.ReadOnly = True
    Me.colKode.SortOrder = System.Windows.Forms.SortOrder.Ascending
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 50
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.OptionsColumn.AllowEdit = False
    Me.colNama.OptionsColumn.ReadOnly = True
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    Me.colNama.Width = 200
    '
    'txtLevel
    '
    Me.txtLevel.Location = New System.Drawing.Point(102, 118)
    Me.txtLevel.Name = "txtLevel"
    Me.txtLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtLevel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Level")})
    Me.txtLevel.Properties.DisplayMember = "Value"
    Me.txtLevel.Properties.NullText = ""
    Me.txtLevel.Properties.ValueMember = "Key"
    Me.txtLevel.Size = New System.Drawing.Size(359, 20)
    Me.txtLevel.StyleController = Me.LayoutControl1
    Me.txtLevel.TabIndex = 112
    '
    'txtSubProyek
    '
    Me.txtSubProyek.Location = New System.Drawing.Point(102, 70)
    Me.txtSubProyek.Name = "txtSubProyek"
    Me.txtSubProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSubProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 50, "Nama")})
    Me.txtSubProyek.Properties.DisplayMember = "Kode"
    Me.txtSubProyek.Properties.NullText = "<Pilih Sub Proyek>"
    Me.txtSubProyek.Properties.ValueMember = "This"
    Me.txtSubProyek.Size = New System.Drawing.Size(359, 20)
    Me.txtSubProyek.StyleController = Me.LayoutControl1
    Me.txtSubProyek.TabIndex = 110
    '
    'txtProyek
    '
    Me.txtProyek.Location = New System.Drawing.Point(102, 46)
    Me.txtProyek.Name = "txtProyek"
    Me.txtProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
    Me.txtProyek.Properties.DisplayMember = "Kode"
    Me.txtProyek.Properties.NullText = "<Pilih Proyek>"
    Me.txtProyek.Properties.ValueMember = "This"
    Me.txtProyek.Size = New System.Drawing.Size(359, 20)
    Me.txtProyek.StyleController = Me.LayoutControl1
    Me.txtProyek.TabIndex = 107
    '
    'chkSaldoNol
    '
    Me.chkSaldoNol.Location = New System.Drawing.Point(24, 142)
    Me.chkSaldoNol.Name = "chkSaldoNol"
    Me.chkSaldoNol.Properties.Caption = "Tampilkan Saldo Nol"
    Me.chkSaldoNol.Size = New System.Drawing.Size(437, 19)
    Me.chkSaldoNol.StyleController = Me.LayoutControl1
    Me.chkSaldoNol.TabIndex = 106
    '
    'txtPeriodeAkhir
    '
    Me.txtPeriodeAkhir.EditValue = Nothing
    Me.txtPeriodeAkhir.Location = New System.Drawing.Point(321, 94)
    Me.txtPeriodeAkhir.Name = "txtPeriodeAkhir"
    Me.txtPeriodeAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Size = New System.Drawing.Size(140, 20)
    Me.txtPeriodeAkhir.StyleController = Me.LayoutControl1
    Me.txtPeriodeAkhir.TabIndex = 105
    Me.txtPeriodeAkhir.Visible = False
    '
    'txtPeriodeAwal
    '
    Me.txtPeriodeAwal.EditValue = Nothing
    Me.txtPeriodeAwal.Location = New System.Drawing.Point(102, 94)
    Me.txtPeriodeAwal.Name = "txtPeriodeAwal"
    Me.txtPeriodeAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Size = New System.Drawing.Size(137, 20)
    Me.txtPeriodeAwal.StyleController = Me.LayoutControl1
    Me.txtPeriodeAwal.TabIndex = 104
    Me.txtPeriodeAwal.Visible = False
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(485, 314)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'TabbedControlGroup1
    '
    Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
    Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
    Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
    Me.TabbedControlGroup1.SelectedTabPageIndex = 0
    Me.TabbedControlGroup1.Size = New System.Drawing.Size(465, 294)
    Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
    Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Filter Data"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.lytPeriode1, Me.lytPeriode2, Me.LayoutControlItem5, Me.lytLevel})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(441, 248)
    Me.LayoutControlGroup2.Text = "Filter Data"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtProyek
    Me.LayoutControlItem1.CustomizationFormText = "Proyek"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(441, 24)
    Me.LayoutControlItem1.Text = "Proyek"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtSubProyek
    Me.LayoutControlItem2.CustomizationFormText = "Sub Proyek"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(441, 24)
    Me.LayoutControlItem2.Text = "Sub Proyek"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
    '
    'lytPeriode1
    '
    Me.lytPeriode1.Control = Me.txtPeriodeAwal
    Me.lytPeriode1.CustomizationFormText = "Periode"
    Me.lytPeriode1.Location = New System.Drawing.Point(0, 48)
    Me.lytPeriode1.Name = "lytPeriode1"
    Me.lytPeriode1.Size = New System.Drawing.Size(219, 24)
    Me.lytPeriode1.Text = "Periode"
    Me.lytPeriode1.TextSize = New System.Drawing.Size(75, 13)
    '
    'lytPeriode2
    '
    Me.lytPeriode2.Control = Me.txtPeriodeAkhir
    Me.lytPeriode2.CustomizationFormText = "Periode2"
    Me.lytPeriode2.Location = New System.Drawing.Point(219, 48)
    Me.lytPeriode2.Name = "lytPeriode2"
    Me.lytPeriode2.Size = New System.Drawing.Size(222, 24)
    Me.lytPeriode2.Text = "s/d"
    Me.lytPeriode2.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.chkSaldoNol
    Me.LayoutControlItem5.CustomizationFormText = "TampilkanSaldoNol"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(441, 152)
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'lytLevel
    '
    Me.lytLevel.Control = Me.txtLevel
    Me.lytLevel.CustomizationFormText = "Tampilkan Level"
    Me.lytLevel.Location = New System.Drawing.Point(0, 72)
    Me.lytLevel.Name = "lytLevel"
    Me.lytLevel.Size = New System.Drawing.Size(441, 24)
    Me.lytLevel.Text = "Tampilkan Level"
    Me.lytLevel.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Filter COA"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(441, 248)
    Me.LayoutControlGroup3.Text = "Filter COA"
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.treeAkun
    Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(441, 248)
    Me.LayoutControlItem4.Text = "LayoutControlItem4"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem4.TextToControlDistance = 0
    Me.LayoutControlItem4.TextVisible = False
    '
    'RF_MesitechPertanggungJawaban
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(485, 363)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_MesitechPertanggungJawaban"
    Me.Text = "RF_MesitechPertanggungJawaban"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.treeAkun, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytLevel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents txtLevel As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtSubProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents chkSaldoNol As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtPeriodeAkhir As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtPeriodeAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytLevel As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents treeAkun As DevExpress.XtraTreeList.TreeList
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKode As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colNama As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
