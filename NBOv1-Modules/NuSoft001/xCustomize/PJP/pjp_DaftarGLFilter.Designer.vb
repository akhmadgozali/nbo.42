<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pjp_DaftarGLFilter
  Inherits Core.Win.Forms.DialogForm

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
    Me.lytFilterData = New DevExpress.XtraLayout.LayoutControl()
    Me.txtTipe = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
    Me.txtAkun1 = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.txtAkun2 = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.txtDivisi = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtSubProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytControl = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.lytFilterData, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytFilterData.SuspendLayout()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytControl, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(159, 12)
    Me.btn1.Text = "&Filter"
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(252, 12)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 189)
    Me.PanelControl1.Size = New System.Drawing.Size(349, 49)
    '
    'lytFilterData
    '
    Me.lytFilterData.Controls.Add(Me.txtTipe)
    Me.lytFilterData.Controls.Add(Me.txtUraian)
    Me.lytFilterData.Controls.Add(Me.txtTgl1)
    Me.lytFilterData.Controls.Add(Me.txtTgl2)
    Me.lytFilterData.Controls.Add(Me.txtAkun1)
    Me.lytFilterData.Controls.Add(Me.txtAkun2)
    Me.lytFilterData.Controls.Add(Me.txtKontak)
    Me.lytFilterData.Controls.Add(Me.txtDivisi)
    Me.lytFilterData.Controls.Add(Me.txtProyek)
    Me.lytFilterData.Controls.Add(Me.txtSubProyek)
    Me.lytFilterData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytFilterData.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
    Me.lytFilterData.Location = New System.Drawing.Point(0, 0)
    Me.lytFilterData.Name = "lytFilterData"
    Me.lytFilterData.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(437, 287, 250, 350)
    Me.lytFilterData.Root = Me.lytControl
    Me.lytFilterData.Size = New System.Drawing.Size(349, 189)
    Me.lytFilterData.TabIndex = 4
    Me.lytFilterData.Text = "lytFilterData"
    '
    'txtTipe
    '
    Me.txtTipe.Location = New System.Drawing.Point(83, 12)
    Me.txtTipe.Name = "txtTipe"
    Me.txtTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Tipe"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", 60, "Nama")})
    Me.txtTipe.Properties.DisplayMember = "Value"
    Me.txtTipe.Properties.NullText = "<Pilih Tipe Transaksi>"
    Me.txtTipe.Properties.ValueMember = "Key"
    Me.txtTipe.Size = New System.Drawing.Size(254, 20)
    Me.txtTipe.StyleController = Me.lytFilterData
    Me.txtTipe.TabIndex = 14
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(83, 108)
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Size = New System.Drawing.Size(254, 20)
    Me.txtUraian.StyleController = Me.lytFilterData
    Me.txtUraian.TabIndex = 6
    '
    'txtTgl1
    '
    Me.txtTgl1.EditValue = Nothing
    Me.txtTgl1.Location = New System.Drawing.Point(83, 36)
    Me.txtTgl1.Name = "txtTgl1"
    Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.Mask.EditMask = ""
    Me.txtTgl1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTgl1.Size = New System.Drawing.Size(101, 20)
    Me.txtTgl1.StyleController = Me.lytFilterData
    Me.txtTgl1.TabIndex = 4
    '
    'txtTgl2
    '
    Me.txtTgl2.EditValue = Nothing
    Me.txtTgl2.Location = New System.Drawing.Point(208, 36)
    Me.txtTgl2.Name = "txtTgl2"
    Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.Mask.EditMask = ""
    Me.txtTgl2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTgl2.Size = New System.Drawing.Size(129, 20)
    Me.txtTgl2.StyleController = Me.lytFilterData
    Me.txtTgl2.TabIndex = 13
    '
    'txtAkun1
    '
    Me.txtAkun1.Location = New System.Drawing.Point(83, 60)
    Me.txtAkun1.Name = "txtAkun1"
    Me.txtAkun1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun1.Properties.DisplayMember = "Kode"
    Me.txtAkun1.Properties.NullText = ""
    Me.txtAkun1.Properties.ValueMember = "Kode"
    Me.txtAkun1.Properties.View = Me.SearchLookUpEdit1View
    Me.txtAkun1.Size = New System.Drawing.Size(101, 20)
    Me.txtAkun1.StyleController = Me.lytFilterData
    Me.txtAkun1.TabIndex = 12
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'txtAkun2
    '
    Me.txtAkun2.Location = New System.Drawing.Point(208, 60)
    Me.txtAkun2.Name = "txtAkun2"
    Me.txtAkun2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun2.Properties.DisplayMember = "Kode"
    Me.txtAkun2.Properties.NullText = ""
    Me.txtAkun2.Properties.ValueMember = "Kode"
    Me.txtAkun2.Properties.View = Me.GridView1
    Me.txtAkun2.Size = New System.Drawing.Size(129, 20)
    Me.txtAkun2.StyleController = Me.lytFilterData
    Me.txtAkun2.TabIndex = 5
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsFind.AlwaysVisible = True
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(83, 84)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = ""
    Me.txtKontak.Properties.ValueMember = "Kode"
    Me.txtKontak.Properties.View = Me.GridView2
    Me.txtKontak.Size = New System.Drawing.Size(254, 20)
    Me.txtKontak.StyleController = Me.lytFilterData
    Me.txtKontak.TabIndex = 7
    '
    'GridView2
    '
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKontakKode, Me.colKontakNama})
    Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsFind.FindDelay = 500
    Me.GridView2.OptionsFind.SearchInPreview = True
    Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView2.OptionsView.ShowGroupPanel = False
    Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKontakKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'txtDivisi
    '
    Me.txtDivisi.Location = New System.Drawing.Point(83, 132)
    Me.txtDivisi.Name = "txtDivisi"
    Me.txtDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtDivisi.Properties.DisplayMember = "Kode"
    Me.txtDivisi.Properties.NullText = ""
    Me.txtDivisi.Properties.ValueMember = "Kode"
    Me.txtDivisi.Size = New System.Drawing.Size(254, 20)
    Me.txtDivisi.StyleController = Me.lytFilterData
    Me.txtDivisi.TabIndex = 8
    '
    'txtProyek
    '
    Me.txtProyek.Location = New System.Drawing.Point(83, 156)
    Me.txtProyek.Name = "txtProyek"
    Me.txtProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtProyek.Properties.DisplayMember = "Kode"
    Me.txtProyek.Properties.NullText = ""
    Me.txtProyek.Properties.ValueMember = "Kode"
    Me.txtProyek.Size = New System.Drawing.Size(254, 20)
    Me.txtProyek.StyleController = Me.lytFilterData
    Me.txtProyek.TabIndex = 9
    '
    'txtSubProyek
    '
    Me.txtSubProyek.Location = New System.Drawing.Point(69, 156)
    Me.txtSubProyek.Name = "txtSubProyek"
    Me.txtSubProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSubProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtSubProyek.Properties.DisplayMember = "Kode"
    Me.txtSubProyek.Properties.NullText = ""
    Me.txtSubProyek.Properties.ValueMember = "Kode"
    Me.txtSubProyek.Size = New System.Drawing.Size(268, 20)
    Me.txtSubProyek.StyleController = Me.lytFilterData
    Me.txtSubProyek.TabIndex = 10
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtSubProyek
    Me.LayoutControlItem7.CustomizationFormText = "Sub Proyek"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(329, 25)
    Me.LayoutControlItem7.Text = "Sub Proyek"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(54, 13)
    Me.LayoutControlItem7.TextToControlDistance = 5
    '
    'lytControl
    '
    Me.lytControl.CustomizationFormText = "lytControl"
    Me.lytControl.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.lytControl.GroupBordersVisible = False
    Me.lytControl.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem10, Me.LayoutControlItem8})
    Me.lytControl.Location = New System.Drawing.Point(0, 0)
    Me.lytControl.Name = "lytControl"
    Me.lytControl.Size = New System.Drawing.Size(349, 189)
    Me.lytControl.Text = "lytControl"
    Me.lytControl.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTgl1
    Me.LayoutControlItem1.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(176, 24)
    Me.LayoutControlItem1.Text = "Tanggal"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(68, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(329, 24)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtKontak
    Me.LayoutControlItem4.CustomizationFormText = "Kontak"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(329, 24)
    Me.LayoutControlItem4.Text = "Kontak"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(68, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtDivisi
    Me.LayoutControlItem5.CustomizationFormText = "Divisi"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(329, 24)
    Me.LayoutControlItem5.Text = "Divisi"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(68, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtProyek
    Me.LayoutControlItem6.CustomizationFormText = "Proyek"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(329, 25)
    Me.LayoutControlItem6.Text = "Proyek"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(68, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtAkun1
    Me.LayoutControlItem9.CustomizationFormText = "Akun"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(176, 24)
    Me.LayoutControlItem9.Text = "Akun"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(68, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtAkun2
    Me.LayoutControlItem2.CustomizationFormText = "s/d"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(176, 48)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(153, 24)
    Me.LayoutControlItem2.Text = "s/d"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(15, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtTgl2
    Me.LayoutControlItem10.CustomizationFormText = "s/d"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(176, 24)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(153, 24)
    Me.LayoutControlItem10.Text = "s/d"
    Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(15, 13)
    Me.LayoutControlItem10.TextToControlDistance = 5
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtTipe
    Me.LayoutControlItem8.CustomizationFormText = "Tipe Transaksi"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(329, 24)
    Me.LayoutControlItem8.Text = "Tipe Transaksi"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(68, 13)
    '
    'gcKode
    '
    Me.gcKode.Caption = "Kode"
    Me.gcKode.FieldName = "Kode"
    Me.gcKode.Name = "gcKode"
    Me.gcKode.Visible = True
    Me.gcKode.VisibleIndex = 0
    Me.gcKode.Width = 276
    '
    'gcNama
    '
    Me.gcNama.Caption = "Nama"
    Me.gcNama.FieldName = "Nama"
    Me.gcNama.Name = "gcNama"
    Me.gcNama.Visible = True
    Me.gcNama.VisibleIndex = 1
    Me.gcNama.Width = 802
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode"
    Me.GridColumn1.FieldName = "Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 276
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama"
    Me.GridColumn2.FieldName = "Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 802
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
    'UI_DaftarGLFilter
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(349, 238)
    Me.Controls.Add(Me.lytFilterData)
    Me.Name = "UI_DaftarGLFilter"
    Me.Text = "Filter Data"
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.lytFilterData, 0)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.lytFilterData, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytFilterData.ResumeLayout(False)
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytControl, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lytFilterData As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents lytControl As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtAkun1 As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtAkun2 As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtDivisi As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtSubProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtTipe As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
