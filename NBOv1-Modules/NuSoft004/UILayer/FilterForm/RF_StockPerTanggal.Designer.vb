<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_StockPerTanggal
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
  Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
  Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.txtKodeBarang1 = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.colTxtBarangKode = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtBarangNama = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.txtKodeBarang2 = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.colTxtBarang2Kode = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtBarang2Nama = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.txtGudang = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GriName = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.txtKategori = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.txtSubKategori = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.txtMerk = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.colTxtGudangKode = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtGudangNama = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtKategoriKode = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtKategoriNama = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtSubKategoriKode = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtSubKategoriNama = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtMerkKode = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtMerkNama = New DevExpress.XtraGrid.Columns.GridColumn()
  CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.LayoutControl1.SuspendLayout()
  CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKodeBarang1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKodeBarang2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GriName, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtSubKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'LayoutControl1
  '
  Me.LayoutControl1.Controls.Add(Me.txtTanggal)
  Me.LayoutControl1.Controls.Add(Me.txtKodeBarang1)
  Me.LayoutControl1.Controls.Add(Me.txtKodeBarang2)
  Me.LayoutControl1.Controls.Add(Me.txtGudang)
  Me.LayoutControl1.Controls.Add(Me.txtKategori)
  Me.LayoutControl1.Controls.Add(Me.txtSubKategori)
  Me.LayoutControl1.Controls.Add(Me.txtMerk)
  Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
  Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControl1.Name = "LayoutControl1"
  Me.LayoutControl1.Root = Me.LayoutControlGroup1
  Me.LayoutControl1.Size = New System.Drawing.Size(370, 164)
  Me.LayoutControl1.TabIndex = 101
  Me.LayoutControl1.Text = "LayoutControl1"
  '
  'txtTanggal
  '
  Me.txtTanggal.EditValue = Nothing
  Me.txtTanggal.Location = New System.Drawing.Point(75, 36)
  Me.txtTanggal.Name = "txtTanggal"
  Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTanggal.Size = New System.Drawing.Size(283, 20)
  Me.txtTanggal.StyleController = Me.LayoutControl1
  Me.txtTanggal.TabIndex = 6
  '
  'LayoutControlGroup1
  '
  Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
  Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
  Me.LayoutControlGroup1.GroupBordersVisible = False
  Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
  Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
  Me.LayoutControlGroup1.Size = New System.Drawing.Size(370, 164)
  Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
  Me.LayoutControlGroup1.TextVisible = False
  '
  'LayoutControlItem1
  '
  Me.LayoutControlItem1.Control = Me.txtKodeBarang1
  Me.LayoutControlItem1.CustomizationFormText = "Item"
  Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlItem1.Name = "LayoutControlItem1"
  Me.LayoutControlItem1.Size = New System.Drawing.Size(191, 24)
  Me.LayoutControlItem1.Text = "Item"
  Me.LayoutControlItem1.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem2
  '
  Me.LayoutControlItem2.Control = Me.txtKodeBarang2
  Me.LayoutControlItem2.CustomizationFormText = "s/d"
  Me.LayoutControlItem2.Location = New System.Drawing.Point(191, 0)
  Me.LayoutControlItem2.Name = "LayoutControlItem2"
  Me.LayoutControlItem2.Size = New System.Drawing.Size(159, 24)
  Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
  Me.LayoutControlItem2.Text = "s/d"
  Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
  Me.LayoutControlItem2.TextSize = New System.Drawing.Size(15, 13)
  Me.LayoutControlItem2.TextToControlDistance = 5
  '
  'LayoutControlItem3
  '
  Me.LayoutControlItem3.Control = Me.txtTanggal
  Me.LayoutControlItem3.CustomizationFormText = "Tanggal"
  Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
  Me.LayoutControlItem3.Name = "LayoutControlItem3"
  Me.LayoutControlItem3.Size = New System.Drawing.Size(350, 24)
  Me.LayoutControlItem3.Text = "Tanggal"
  Me.LayoutControlItem3.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem4
  '
  Me.LayoutControlItem4.Control = Me.txtGudang
  Me.LayoutControlItem4.CustomizationFormText = "Gudang"
  Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
  Me.LayoutControlItem4.Name = "LayoutControlItem4"
  Me.LayoutControlItem4.Size = New System.Drawing.Size(350, 24)
  Me.LayoutControlItem4.Text = "Gudang"
  Me.LayoutControlItem4.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem5
  '
  Me.LayoutControlItem5.Control = Me.txtKategori
  Me.LayoutControlItem5.CustomizationFormText = "Kategori"
  Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
  Me.LayoutControlItem5.Name = "LayoutControlItem5"
  Me.LayoutControlItem5.Size = New System.Drawing.Size(350, 24)
  Me.LayoutControlItem5.Text = "Kategori"
  Me.LayoutControlItem5.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem6
  '
  Me.LayoutControlItem6.Control = Me.txtSubKategori
  Me.LayoutControlItem6.CustomizationFormText = "Sub kategori"
  Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
  Me.LayoutControlItem6.Name = "LayoutControlItem6"
  Me.LayoutControlItem6.Size = New System.Drawing.Size(350, 24)
  Me.LayoutControlItem6.Text = "Sub kategori"
  Me.LayoutControlItem6.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem7
  '
  Me.LayoutControlItem7.Control = Me.txtMerk
  Me.LayoutControlItem7.CustomizationFormText = "Merk"
  Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 120)
  Me.LayoutControlItem7.Name = "LayoutControlItem7"
  Me.LayoutControlItem7.Size = New System.Drawing.Size(350, 24)
  Me.LayoutControlItem7.Text = "Merk"
  Me.LayoutControlItem7.TextSize = New System.Drawing.Size(60, 13)
  '
  'txtKodeBarang1
  '
  Me.txtKodeBarang1.Location = New System.Drawing.Point(75, 12)
  Me.txtKodeBarang1.Name = "txtKodeBarang1"
  Me.txtKodeBarang1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtKodeBarang1.Properties.AutoComplete = False
  Me.txtKodeBarang1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
  Me.txtKodeBarang1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKodeBarang1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtKodeBarang1.Properties.DisplayMember = "Nama"
  Me.txtKodeBarang1.Properties.ImmediatePopup = True
  Me.txtKodeBarang1.Properties.NullText = ""
  Me.txtKodeBarang1.Properties.NullValuePrompt = "<Semua>"
  Me.txtKodeBarang1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtKodeBarang1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtKodeBarang1.Properties.ValueMember = "This"
  Me.txtKodeBarang1.Properties.View = Me.GridLookUpEdit1View
  Me.txtKodeBarang1.Size = New System.Drawing.Size(124, 20)
  Me.txtKodeBarang1.StyleController = Me.LayoutControl1
  Me.txtKodeBarang1.TabIndex = 4
  '
  'GridLookUpEdit1View
  '
  Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTxtBarangKode, Me.colTxtBarangNama})
  Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
  Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
  '
  'colTxtBarangKode
  '
  Me.colTxtBarangKode.Caption = "Kode"
  Me.colTxtBarangKode.FieldName = "Kode"
  Me.colTxtBarangKode.Name = "colTxtBarangKode"
  Me.colTxtBarangKode.Visible = True
  Me.colTxtBarangKode.VisibleIndex = 0
  '
  'colTxtBarangNama
  '
  Me.colTxtBarangNama.Caption = "Nama"
  Me.colTxtBarangNama.FieldName = "Nama"
  Me.colTxtBarangNama.Name = "colTxtBarangNama"
  Me.colTxtBarangNama.Visible = True
  Me.colTxtBarangNama.VisibleIndex = 1
  '
  'txtKodeBarang2
  '
  Me.txtKodeBarang2.Location = New System.Drawing.Point(228, 12)
  Me.txtKodeBarang2.Name = "txtKodeBarang2"
  Me.txtKodeBarang2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtKodeBarang2.Properties.AutoComplete = False
  Me.txtKodeBarang2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
  Me.txtKodeBarang2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKodeBarang2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtKodeBarang2.Properties.DisplayMember = "Nama"
  Me.txtKodeBarang2.Properties.ImmediatePopup = True
  Me.txtKodeBarang2.Properties.NullText = ""
  Me.txtKodeBarang2.Properties.NullValuePrompt = "<Semua>"
  Me.txtKodeBarang2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtKodeBarang2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtKodeBarang2.Properties.ValueMember = "This"
  Me.txtKodeBarang2.Properties.View = Me.GridView1
  Me.txtKodeBarang2.Size = New System.Drawing.Size(130, 20)
  Me.txtKodeBarang2.StyleController = Me.LayoutControl1
  Me.txtKodeBarang2.TabIndex = 5
  '
  'GridView1
  '
  Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTxtBarang2Kode, Me.colTxtBarang2Nama})
  Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView1.Name = "GridView1"
  Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView1.OptionsView.ShowGroupPanel = False
  '
  'colTxtBarang2Kode
  '
  Me.colTxtBarang2Kode.Caption = "Kode"
  Me.colTxtBarang2Kode.FieldName = "Kode"
  Me.colTxtBarang2Kode.Name = "colTxtBarang2Kode"
  Me.colTxtBarang2Kode.Visible = True
  Me.colTxtBarang2Kode.VisibleIndex = 0
  '
  'colTxtBarang2Nama
  '
  Me.colTxtBarang2Nama.Caption = "Nama"
  Me.colTxtBarang2Nama.FieldName = "Nama"
  Me.colTxtBarang2Nama.Name = "colTxtBarang2Nama"
  Me.colTxtBarang2Nama.Visible = True
  Me.colTxtBarang2Nama.VisibleIndex = 1
  '
  'txtGudang
  '
  Me.txtGudang.Location = New System.Drawing.Point(75, 60)
  Me.txtGudang.Name = "txtGudang"
  Me.txtGudang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtGudang.Properties.AutoComplete = False
  Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtGudang.Properties.DisplayMember = "Nama"
  Me.txtGudang.Properties.ImmediatePopup = True
  Me.txtGudang.Properties.NullText = ""
  Me.txtGudang.Properties.NullValuePrompt = "<Semua>"
  Me.txtGudang.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtGudang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtGudang.Properties.ValueMember = "This"
  Me.txtGudang.Properties.View = Me.GriName
  Me.txtGudang.Size = New System.Drawing.Size(283, 20)
  Me.txtGudang.StyleController = Me.LayoutControl1
  Me.txtGudang.TabIndex = 7
  '
  'GriName
  '
  Me.GriName.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTxtGudangKode, Me.colTxtGudangNama})
  Me.GriName.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GriName.Name = "GriName"
  Me.GriName.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GriName.OptionsView.ShowGroupPanel = False
  '
  'txtKategori
  '
  Me.txtKategori.Location = New System.Drawing.Point(75, 84)
  Me.txtKategori.Name = "txtKategori"
  Me.txtKategori.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtKategori.Properties.AutoComplete = False
  Me.txtKategori.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtKategori.Properties.DisplayMember = "Nama"
  Me.txtKategori.Properties.ImmediatePopup = True
  Me.txtKategori.Properties.NullText = ""
  Me.txtKategori.Properties.NullValuePrompt = "<Semua>"
  Me.txtKategori.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtKategori.Properties.ValueMember = "This"
  Me.txtKategori.Properties.View = Me.GridView3
  Me.txtKategori.Size = New System.Drawing.Size(283, 20)
  Me.txtKategori.StyleController = Me.LayoutControl1
  Me.txtKategori.TabIndex = 8
  '
  'GridView3
  '
  Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTxtKategoriKode, Me.colTxtKategoriNama})
  Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView3.Name = "GridView3"
  Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView3.OptionsView.ShowGroupPanel = False
  '
  'txtSubKategori
  '
  Me.txtSubKategori.Location = New System.Drawing.Point(75, 108)
  Me.txtSubKategori.Name = "txtSubKategori"
  Me.txtSubKategori.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtSubKategori.Properties.AutoComplete = False
  Me.txtSubKategori.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtSubKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtSubKategori.Properties.DisplayMember = "Nama"
  Me.txtSubKategori.Properties.ImmediatePopup = True
  Me.txtSubKategori.Properties.NullText = ""
  Me.txtSubKategori.Properties.NullValuePrompt = "<Semua>"
  Me.txtSubKategori.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtSubKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtSubKategori.Properties.ValueMember = "This"
  Me.txtSubKategori.Properties.View = Me.GridView4
  Me.txtSubKategori.Size = New System.Drawing.Size(283, 20)
  Me.txtSubKategori.StyleController = Me.LayoutControl1
  Me.txtSubKategori.TabIndex = 9
  '
  'GridView4
  '
  Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTxtSubKategoriKode, Me.colTxtSubKategoriNama})
  Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView4.Name = "GridView4"
  Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView4.OptionsView.ShowGroupPanel = False
  '
  'txtMerk
  '
  Me.txtMerk.Location = New System.Drawing.Point(75, 132)
  Me.txtMerk.Name = "txtMerk"
  Me.txtMerk.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtMerk.Properties.AutoComplete = False
  Me.txtMerk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtMerk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtMerk.Properties.DisplayMember = "Nama"
  Me.txtMerk.Properties.ImmediatePopup = True
  Me.txtMerk.Properties.NullText = ""
  Me.txtMerk.Properties.NullValuePrompt = "<Semua>"
  Me.txtMerk.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtMerk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtMerk.Properties.ValueMember = "This"
  Me.txtMerk.Properties.View = Me.GridView5
  Me.txtMerk.Size = New System.Drawing.Size(283, 20)
  Me.txtMerk.StyleController = Me.LayoutControl1
  Me.txtMerk.TabIndex = 10
  '
  'GridView5
  '
  Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTxtMerkKode, Me.colTxtMerkNama})
  Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView5.Name = "GridView5"
  Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView5.OptionsView.ShowGroupPanel = False
  '
  'colTxtGudangKode
  '
  Me.colTxtGudangKode.Caption = "Kode"
  Me.colTxtGudangKode.FieldName = "Kode"
  Me.colTxtGudangKode.Name = "colTxtGudangKode"
  Me.colTxtGudangKode.Visible = True
  Me.colTxtGudangKode.VisibleIndex = 0
  '
  'colTxtGudangNama
  '
  Me.colTxtGudangNama.Caption = "Nama"
  Me.colTxtGudangNama.FieldName = "Nama"
  Me.colTxtGudangNama.Name = "colTxtGudangNama"
  Me.colTxtGudangNama.Visible = True
  Me.colTxtGudangNama.VisibleIndex = 1
  '
  'colTxtKategoriKode
  '
  Me.colTxtKategoriKode.Caption = "Kode"
  Me.colTxtKategoriKode.FieldName = "Kode"
  Me.colTxtKategoriKode.Name = "colTxtKategoriKode"
  Me.colTxtKategoriKode.Visible = True
  Me.colTxtKategoriKode.VisibleIndex = 0
  '
  'colTxtKategoriNama
  '
  Me.colTxtKategoriNama.Caption = "Nama"
  Me.colTxtKategoriNama.FieldName = "Nama"
  Me.colTxtKategoriNama.Name = "colTxtKategoriNama"
  Me.colTxtKategoriNama.Visible = True
  Me.colTxtKategoriNama.VisibleIndex = 1
  '
  'colTxtSubKategoriKode
  '
  Me.colTxtSubKategoriKode.Caption = "Kode"
  Me.colTxtSubKategoriKode.FieldName = "Kode"
  Me.colTxtSubKategoriKode.Name = "colTxtSubKategoriKode"
  Me.colTxtSubKategoriKode.Visible = True
  Me.colTxtSubKategoriKode.VisibleIndex = 0
  '
  'colTxtSubKategoriNama
  '
  Me.colTxtSubKategoriNama.Caption = "Nama"
  Me.colTxtSubKategoriNama.FieldName = "Nama"
  Me.colTxtSubKategoriNama.Name = "colTxtSubKategoriNama"
  Me.colTxtSubKategoriNama.Visible = True
  Me.colTxtSubKategoriNama.VisibleIndex = 1
  '
  'colTxtMerkKode
  '
  Me.colTxtMerkKode.Caption = "Kode"
  Me.colTxtMerkKode.FieldName = "Kode"
  Me.colTxtMerkKode.Name = "colTxtMerkKode"
  Me.colTxtMerkKode.Visible = True
  Me.colTxtMerkKode.VisibleIndex = 0
  '
  'colTxtMerkNama
  '
  Me.colTxtMerkNama.Caption = "Nama"
  Me.colTxtMerkNama.FieldName = "Nama"
  Me.colTxtMerkNama.Name = "colTxtMerkNama"
  Me.colTxtMerkNama.Visible = True
  Me.colTxtMerkNama.VisibleIndex = 1
  '
  'RF_StockPerTanggal
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(370, 213)
  Me.Controls.Add(Me.LayoutControl1)
  Me.Name = "RF_StockPerTanggal"
  Me.Text = "Filter Laporan Stock per Tanggal"
  Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
  CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
  Me.LayoutControl1.ResumeLayout(False)
  CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKodeBarang1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKodeBarang2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GriName, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtSubKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)

 End Sub
 Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents txtKodeBarang1 As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colTxtBarangKode As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colTxtBarangNama As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents txtKodeBarang2 As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colTxtBarang2Kode As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colTxtBarang2Nama As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents txtGudang As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GriName As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colTxtGudangKode As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colTxtGudangNama As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents txtKategori As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colTxtKategoriKode As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colTxtKategoriNama As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents txtSubKategori As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colTxtSubKategoriKode As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colTxtSubKategoriNama As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents txtMerk As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colTxtMerkKode As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colTxtMerkNama As DevExpress.XtraGrid.Columns.GridColumn
End Class
