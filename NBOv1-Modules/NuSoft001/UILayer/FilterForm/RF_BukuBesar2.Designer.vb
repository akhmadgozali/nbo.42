<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_BukuBesar2
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
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtDivisi = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtCoaKasBank = New DevExpress.XtraEditors.LookUpEdit()
    Me.chkKosong = New DevExpress.XtraEditors.CheckEdit()
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
    Me.txtAkun1 = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtAkun2 = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytKodeAkun1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytMutasi = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytKasBank = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytDivisi = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytKodeAkun2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCoaKasBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkKosong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytKodeAkun1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytMutasi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytKasBank, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytKodeAkun2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtRegional)
    Me.LayoutControl1.Controls.Add(Me.txtKontak)
    Me.LayoutControl1.Controls.Add(Me.txtDivisi)
    Me.LayoutControl1.Controls.Add(Me.txtCoaKasBank)
    Me.LayoutControl1.Controls.Add(Me.chkKosong)
    Me.LayoutControl1.Controls.Add(Me.txtTgl1)
    Me.LayoutControl1.Controls.Add(Me.txtTgl2)
    Me.LayoutControl1.Controls.Add(Me.txtAkun1)
    Me.LayoutControl1.Controls.Add(Me.txtAkun2)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(55, 176, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(473, 318)
    Me.LayoutControl1.TabIndex = 105
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(93, 43)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Kode"
    Me.txtRegional.Properties.NullText = "[Pilih Regional]"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(356, 20)
    Me.txtRegional.StyleController = Me.LayoutControl1
    Me.txtRegional.TabIndex = 108
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(93, 115)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Kontak>"
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(356, 20)
    Me.txtKontak.StyleController = Me.LayoutControl1
    Me.txtKontak.TabIndex = 107
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKontakKode, Me.colKontakNama})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsFind.FindDelay = 500
    Me.SearchLookUpEdit1View.OptionsFind.SearchInPreview = True
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKontakKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colKontakKode
    '
    Me.colKontakKode.Caption = "Kode"
    Me.colKontakKode.FieldName = "Kode"
    Me.colKontakKode.Name = "colKontakKode"
    Me.colKontakKode.Visible = True
    Me.colKontakKode.VisibleIndex = 0
    Me.colKontakKode.Width = 355
    '
    'colKontakNama
    '
    Me.colKontakNama.Caption = "Nama"
    Me.colKontakNama.FieldName = "Nama"
    Me.colKontakNama.Name = "colKontakNama"
    Me.colKontakNama.Visible = True
    Me.colKontakNama.VisibleIndex = 1
    Me.colKontakNama.Width = 723
    '
    'txtDivisi
    '
    Me.txtDivisi.Location = New System.Drawing.Point(93, 186)
    Me.txtDivisi.Name = "txtDivisi"
    Me.txtDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtDivisi.Properties.DisplayMember = "Kode"
    Me.txtDivisi.Properties.NullText = "<Pilih Divisi>"
    Me.txtDivisi.Properties.ValueMember = "This"
    Me.txtDivisi.Size = New System.Drawing.Size(356, 20)
    Me.txtDivisi.StyleController = Me.LayoutControl1
    Me.txtDivisi.TabIndex = 106
    '
    'txtCoaKasBank
    '
    Me.txtCoaKasBank.Location = New System.Drawing.Point(93, 162)
    Me.txtCoaKasBank.Name = "txtCoaKasBank"
    Me.txtCoaKasBank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCoaKasBank.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 80, "Nama")})
    Me.txtCoaKasBank.Properties.DisplayMember = "Kode"
    Me.txtCoaKasBank.Properties.NullText = "<Silahkan Pilih Coa Kas/Bank>"
    Me.txtCoaKasBank.Properties.ValueMember = "This"
    Me.txtCoaKasBank.Size = New System.Drawing.Size(356, 20)
    Me.txtCoaKasBank.StyleController = Me.LayoutControl1
    Me.txtCoaKasBank.TabIndex = 105
    '
    'chkKosong
    '
    Me.chkKosong.EditValue = True
    Me.chkKosong.Location = New System.Drawing.Point(24, 139)
    Me.chkKosong.Name = "chkKosong"
    Me.chkKosong.Properties.Caption = "Tampilkan Mutasi Kosong"
    Me.chkKosong.Size = New System.Drawing.Size(425, 19)
    Me.chkKosong.StyleController = Me.LayoutControl1
    Me.chkKosong.TabIndex = 104
    '
    'txtTgl1
    '
    Me.txtTgl1.EditValue = Nothing
    Me.txtTgl1.Location = New System.Drawing.Point(93, 67)
    Me.txtTgl1.Name = "txtTgl1"
    Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl1.Size = New System.Drawing.Size(141, 20)
    Me.txtTgl1.StyleController = Me.LayoutControl1
    Me.txtTgl1.TabIndex = 101
    '
    'txtTgl2
    '
    Me.txtTgl2.EditValue = Nothing
    Me.txtTgl2.Location = New System.Drawing.Point(307, 67)
    Me.txtTgl2.Name = "txtTgl2"
    Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl2.Size = New System.Drawing.Size(142, 20)
    Me.txtTgl2.StyleController = Me.LayoutControl1
    Me.txtTgl2.TabIndex = 102
    '
    'txtAkun1
    '
    Me.txtAkun1.Location = New System.Drawing.Point(93, 91)
    Me.txtAkun1.Name = "txtAkun1"
    Me.txtAkun1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun1.Properties.DisplayMember = "Kode"
    Me.txtAkun1.Properties.NullText = ""
    Me.txtAkun1.Properties.ValueMember = "Kode"
    Me.txtAkun1.Properties.View = Me.GridView1
    Me.txtAkun1.Size = New System.Drawing.Size(141, 20)
    Me.txtAkun1.StyleController = Me.LayoutControl1
    Me.txtAkun1.TabIndex = 2
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsFind.FindDelay = 500
    Me.GridView1.OptionsFind.SearchInPreview = True
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode"
    Me.GridColumn1.FieldName = "Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 355
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama"
    Me.GridColumn2.FieldName = "Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 723
    '
    'txtAkun2
    '
    Me.txtAkun2.Location = New System.Drawing.Point(307, 91)
    Me.txtAkun2.Name = "txtAkun2"
    Me.txtAkun2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun2.Properties.DisplayMember = "Kode"
    Me.txtAkun2.Properties.NullText = ""
    Me.txtAkun2.Properties.ValueMember = "Kode"
    Me.txtAkun2.Properties.View = Me.GridView2
    Me.txtAkun2.Size = New System.Drawing.Size(142, 20)
    Me.txtAkun2.StyleController = Me.LayoutControl1
    Me.txtAkun2.TabIndex = 3
    '
    'GridView2
    '
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
    Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsFind.FindDelay = 500
    Me.GridView2.OptionsFind.SearchInPreview = True
    Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView2.OptionsView.ShowGroupPanel = False
    Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode"
    Me.GridColumn3.FieldName = "Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    Me.GridColumn3.Width = 355
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Nama"
    Me.GridColumn4.FieldName = "Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    Me.GridColumn4.Width = 723
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(473, 318)
    Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Filter Data"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.lytKodeAkun1, Me.lytMutasi, Me.lytKasBank, Me.lytDivisi, Me.LayoutControlItem3, Me.lytKodeAkun2, Me.LayoutControlItem4})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(453, 298)
    Me.LayoutControlGroup2.Text = "Filter Data"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTgl1
    Me.LayoutControlItem1.CustomizationFormText = "Periode"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(214, 24)
    Me.LayoutControlItem1.Text = "Periode"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(66, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtTgl2
    Me.LayoutControlItem2.CustomizationFormText = "s/d"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(214, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(215, 24)
    Me.LayoutControlItem2.Text = "s/d"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(66, 13)
    '
    'lytKodeAkun1
    '
    Me.lytKodeAkun1.Control = Me.txtAkun1
    Me.lytKodeAkun1.CustomizationFormText = "Kode Akun"
    Me.lytKodeAkun1.Location = New System.Drawing.Point(0, 48)
    Me.lytKodeAkun1.Name = "lytKodeAkun1"
    Me.lytKodeAkun1.Size = New System.Drawing.Size(214, 24)
    Me.lytKodeAkun1.Text = "Kode Akun"
    Me.lytKodeAkun1.TextSize = New System.Drawing.Size(66, 13)
    '
    'lytMutasi
    '
    Me.lytMutasi.Control = Me.chkKosong
    Me.lytMutasi.CustomizationFormText = "Tampilkan Mutasi Kosong"
    Me.lytMutasi.Location = New System.Drawing.Point(0, 96)
    Me.lytMutasi.Name = "lytMutasi"
    Me.lytMutasi.Size = New System.Drawing.Size(429, 23)
    Me.lytMutasi.Text = "Tampilkan Mutasi Kosong"
    Me.lytMutasi.TextSize = New System.Drawing.Size(0, 0)
    Me.lytMutasi.TextToControlDistance = 0
    Me.lytMutasi.TextVisible = False
    '
    'lytKasBank
    '
    Me.lytKasBank.Control = Me.txtCoaKasBank
    Me.lytKasBank.CustomizationFormText = "Coa Kas/Bank"
    Me.lytKasBank.Location = New System.Drawing.Point(0, 119)
    Me.lytKasBank.Name = "lytKasBank"
    Me.lytKasBank.Size = New System.Drawing.Size(429, 24)
    Me.lytKasBank.Text = "Coa Kas/Bank"
    Me.lytKasBank.TextSize = New System.Drawing.Size(66, 13)
    '
    'lytDivisi
    '
    Me.lytDivisi.Control = Me.txtDivisi
    Me.lytDivisi.CustomizationFormText = "Divisi"
    Me.lytDivisi.Location = New System.Drawing.Point(0, 143)
    Me.lytDivisi.Name = "lytDivisi"
    Me.lytDivisi.Size = New System.Drawing.Size(429, 112)
    Me.lytDivisi.Text = "Divisi"
    Me.lytDivisi.TextSize = New System.Drawing.Size(66, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtKontak
    Me.LayoutControlItem3.CustomizationFormText = "Kontak"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(429, 24)
    Me.LayoutControlItem3.Text = "Kontak"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(66, 13)
    '
    'lytKodeAkun2
    '
    Me.lytKodeAkun2.Control = Me.txtAkun2
    Me.lytKodeAkun2.CustomizationFormText = "s/d"
    Me.lytKodeAkun2.Location = New System.Drawing.Point(214, 48)
    Me.lytKodeAkun2.Name = "lytKodeAkun2"
    Me.lytKodeAkun2.Size = New System.Drawing.Size(215, 24)
    Me.lytKodeAkun2.Text = "s/d"
    Me.lytKodeAkun2.TextSize = New System.Drawing.Size(66, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtRegional
    Me.LayoutControlItem4.CustomizationFormText = "Regional"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(429, 24)
    Me.LayoutControlItem4.Text = "Regional"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(66, 13)
    '
    'RF_BukuBesar2
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(473, 367)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_BukuBesar2"
    Me.Text = "Filter Laporan - Buku Besar"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCoaKasBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkKosong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytKodeAkun1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytMutasi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytKasBank, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytDivisi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytKodeAkun2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents chkKosong As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytKodeAkun1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytKodeAkun2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytMutasi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtCoaKasBank As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytKasBank As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtDivisi As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytDivisi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtAkun1 As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtAkun2 As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
