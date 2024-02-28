<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_DataDataTransaksi
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
  Me.txtCatatan = New DevExpress.XtraEditors.TextEdit()
  Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
  Me.txtDivisi = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.txtGudang = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
  Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
  Me.txtNoBukti1 = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.colGridKode = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.txtNoBukti2 = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.colTxtBukti2 = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.txtKontak = New DevExpress.XtraEditors.GridLookUpEdit()
  Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.coltxtKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colTxtKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
  CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.LayoutControl1.SuspendLayout()
  CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'txtCatatan
  '
  Me.txtCatatan.Location = New System.Drawing.Point(63, 132)
  Me.txtCatatan.Name = "txtCatatan"
  Me.txtCatatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtCatatan.Size = New System.Drawing.Size(312, 20)
  Me.txtCatatan.StyleController = Me.LayoutControl1
  Me.txtCatatan.TabIndex = 107
  '
  'LayoutControl1
  '
  Me.LayoutControl1.Controls.Add(Me.txtDivisi)
  Me.LayoutControl1.Controls.Add(Me.txtGudang)
  Me.LayoutControl1.Controls.Add(Me.txtCatatan)
  Me.LayoutControl1.Controls.Add(Me.txtTgl2)
  Me.LayoutControl1.Controls.Add(Me.txtTgl1)
  Me.LayoutControl1.Controls.Add(Me.txtNoBukti1)
  Me.LayoutControl1.Controls.Add(Me.txtNoBukti2)
  Me.LayoutControl1.Controls.Add(Me.txtKontak)
  Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
  Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControl1.Name = "LayoutControl1"
  Me.LayoutControl1.Root = Me.LayoutControlGroup1
  Me.LayoutControl1.Size = New System.Drawing.Size(387, 165)
  Me.LayoutControl1.TabIndex = 115
  Me.LayoutControl1.Text = "LayoutControl1"
  '
  'txtDivisi
  '
  Me.txtDivisi.Location = New System.Drawing.Point(63, 108)
  Me.txtDivisi.Name = "txtDivisi"
  Me.txtDivisi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtDivisi.Properties.AutoComplete = False
  Me.txtDivisi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
  Me.txtDivisi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtDivisi.Properties.DisplayMember = "Kode"
  Me.txtDivisi.Properties.ImmediatePopup = True
  Me.txtDivisi.Properties.NullText = ""
  Me.txtDivisi.Properties.NullValuePrompt = "<Semua>"
  Me.txtDivisi.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtDivisi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtDivisi.Properties.ValueMember = "This"
  Me.txtDivisi.Properties.View = Me.GridView5
  Me.txtDivisi.Size = New System.Drawing.Size(312, 20)
  Me.txtDivisi.StyleController = Me.LayoutControl1
  Me.txtDivisi.TabIndex = 117
  '
  'GridView5
  '
  Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3})
  Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView5.Name = "GridView5"
  Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView5.OptionsView.ShowGroupPanel = False
  '
  'GridColumn3
  '
  Me.GridColumn3.Caption = "Kode"
  Me.GridColumn3.FieldName = "Kode"
  Me.GridColumn3.Name = "GridColumn3"
  Me.GridColumn3.Visible = True
  Me.GridColumn3.VisibleIndex = 0
  '
  'txtGudang
  '
  Me.txtGudang.Location = New System.Drawing.Point(63, 84)
  Me.txtGudang.Name = "txtGudang"
  Me.txtGudang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtGudang.Properties.AutoComplete = False
  Me.txtGudang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
  Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtGudang.Properties.DisplayMember = "Nama"
  Me.txtGudang.Properties.ImmediatePopup = True
  Me.txtGudang.Properties.NullText = ""
  Me.txtGudang.Properties.NullValuePrompt = "<Semua>"
  Me.txtGudang.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtGudang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtGudang.Properties.ValueMember = "This"
  Me.txtGudang.Properties.View = Me.GridView4
  Me.txtGudang.Size = New System.Drawing.Size(312, 20)
  Me.txtGudang.StyleController = Me.LayoutControl1
  Me.txtGudang.TabIndex = 116
  '
  'GridView4
  '
  Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
  Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView4.Name = "GridView4"
  Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView4.OptionsView.ShowGroupPanel = False
  '
  'GridColumn1
  '
  Me.GridColumn1.Caption = "Kode"
  Me.GridColumn1.FieldName = "Kode"
  Me.GridColumn1.Name = "GridColumn1"
  Me.GridColumn1.Visible = True
  Me.GridColumn1.VisibleIndex = 0
  '
  'GridColumn2
  '
  Me.GridColumn2.Caption = "Nama"
  Me.GridColumn2.FieldName = "Nama"
  Me.GridColumn2.Name = "GridColumn2"
  Me.GridColumn2.Visible = True
  Me.GridColumn2.VisibleIndex = 1
  '
  'txtTgl2
  '
  Me.txtTgl2.EditValue = Nothing
  Me.txtTgl2.Location = New System.Drawing.Point(237, 36)
  Me.txtTgl2.Name = "txtTgl2"
  Me.txtTgl2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtTgl2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
  Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
  Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
  Me.txtTgl2.Size = New System.Drawing.Size(138, 20)
  Me.txtTgl2.StyleController = Me.LayoutControl1
  Me.txtTgl2.TabIndex = 104
  '
  'txtTgl1
  '
  Me.txtTgl1.EditValue = Nothing
  Me.txtTgl1.Location = New System.Drawing.Point(63, 36)
  Me.txtTgl1.Name = "txtTgl1"
  Me.txtTgl1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtTgl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
  Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
  Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
  Me.txtTgl1.Size = New System.Drawing.Size(145, 20)
  Me.txtTgl1.StyleController = Me.LayoutControl1
  Me.txtTgl1.TabIndex = 103
  '
  'txtNoBukti1
  '
  Me.txtNoBukti1.Location = New System.Drawing.Point(63, 12)
  Me.txtNoBukti1.Name = "txtNoBukti1"
  Me.txtNoBukti1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtNoBukti1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
  Me.txtNoBukti1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtNoBukti1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtNoBukti1.Properties.DisplayMember = "Kode"
  Me.txtNoBukti1.Properties.ImmediatePopup = True
  Me.txtNoBukti1.Properties.NullText = ""
  Me.txtNoBukti1.Properties.NullValuePrompt = "<Semua>"
  Me.txtNoBukti1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtNoBukti1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtNoBukti1.Properties.ValueMember = "Kode"
  Me.txtNoBukti1.Properties.View = Me.GridView1
  Me.txtNoBukti1.Size = New System.Drawing.Size(145, 20)
  Me.txtNoBukti1.StyleController = Me.LayoutControl1
  Me.txtNoBukti1.TabIndex = 101
  '
  'GridView1
  '
  Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGridKode})
  Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView1.Name = "GridView1"
  Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView1.OptionsView.ShowGroupPanel = False
  '
  'colGridKode
  '
  Me.colGridKode.Caption = "No. Bukti"
  Me.colGridKode.FieldName = "Kode"
  Me.colGridKode.Name = "colGridKode"
  Me.colGridKode.Visible = True
  Me.colGridKode.VisibleIndex = 0
  '
  'txtNoBukti2
  '
  Me.txtNoBukti2.Location = New System.Drawing.Point(237, 12)
  Me.txtNoBukti2.Name = "txtNoBukti2"
  Me.txtNoBukti2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtNoBukti2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
  Me.txtNoBukti2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtNoBukti2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtNoBukti2.Properties.DisplayMember = "Kode"
  Me.txtNoBukti2.Properties.ImmediatePopup = True
  Me.txtNoBukti2.Properties.NullText = ""
  Me.txtNoBukti2.Properties.NullValuePrompt = "<Semua>"
  Me.txtNoBukti2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtNoBukti2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtNoBukti2.Properties.ValueMember = "Kode"
  Me.txtNoBukti2.Properties.View = Me.GridView2
  Me.txtNoBukti2.Size = New System.Drawing.Size(138, 20)
  Me.txtNoBukti2.StyleController = Me.LayoutControl1
  Me.txtNoBukti2.TabIndex = 102
  '
  'GridView2
  '
  Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTxtBukti2})
  Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView2.Name = "GridView2"
  Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView2.OptionsView.ShowGroupPanel = False
  '
  'colTxtBukti2
  '
  Me.colTxtBukti2.Caption = "No. Bukti"
  Me.colTxtBukti2.FieldName = "Kode"
  Me.colTxtBukti2.Name = "colTxtBukti2"
  Me.colTxtBukti2.Visible = True
  Me.colTxtBukti2.VisibleIndex = 0
  '
  'txtKontak
  '
  Me.txtKontak.Location = New System.Drawing.Point(63, 60)
  Me.txtKontak.Name = "txtKontak"
  Me.txtKontak.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtKontak.Properties.AutoComplete = False
  Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
  Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtKontak.Properties.DisplayMember = "Nama"
  Me.txtKontak.Properties.ImmediatePopup = True
  Me.txtKontak.Properties.NullText = ""
  Me.txtKontak.Properties.NullValuePrompt = "<Semua>"
  Me.txtKontak.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
  Me.txtKontak.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
  Me.txtKontak.Properties.ValueMember = "This"
  Me.txtKontak.Properties.View = Me.GridView3
  Me.txtKontak.Size = New System.Drawing.Size(312, 20)
  Me.txtKontak.StyleController = Me.LayoutControl1
  Me.txtKontak.TabIndex = 106
  '
  'GridView3
  '
  Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coltxtKontakKode, Me.colTxtKontakNama})
  Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
  Me.GridView3.Name = "GridView3"
  Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
  Me.GridView3.OptionsView.ShowGroupPanel = False
  '
  'coltxtKontakKode
  '
  Me.coltxtKontakKode.Caption = "Kode"
  Me.coltxtKontakKode.FieldName = "Kode"
  Me.coltxtKontakKode.Name = "coltxtKontakKode"
  Me.coltxtKontakKode.Visible = True
  Me.coltxtKontakKode.VisibleIndex = 0
  '
  'colTxtKontakNama
  '
  Me.colTxtKontakNama.Caption = "Nama"
  Me.colTxtKontakNama.FieldName = "Nama"
  Me.colTxtKontakNama.Name = "colTxtKontakNama"
  Me.colTxtKontakNama.Visible = True
  Me.colTxtKontakNama.VisibleIndex = 1
  '
  'LayoutControlGroup1
  '
  Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
  Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
  Me.LayoutControlGroup1.GroupBordersVisible = False
  Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem6})
  Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
  Me.LayoutControlGroup1.Size = New System.Drawing.Size(387, 165)
  Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
  Me.LayoutControlGroup1.TextVisible = False
  '
  'LayoutControlItem1
  '
  Me.LayoutControlItem1.Control = Me.txtNoBukti1
  Me.LayoutControlItem1.CustomizationFormText = "No. Bukti"
  Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlItem1.Name = "LayoutControlItem1"
  Me.LayoutControlItem1.Size = New System.Drawing.Size(200, 24)
  Me.LayoutControlItem1.Text = "No. Bukti"
  Me.LayoutControlItem1.TextSize = New System.Drawing.Size(48, 13)
  '
  'LayoutControlItem2
  '
  Me.LayoutControlItem2.Control = Me.txtNoBukti2
  Me.LayoutControlItem2.CustomizationFormText = "s/d"
  Me.LayoutControlItem2.Location = New System.Drawing.Point(200, 0)
  Me.LayoutControlItem2.Name = "LayoutControlItem2"
  Me.LayoutControlItem2.Size = New System.Drawing.Size(167, 24)
  Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
  Me.LayoutControlItem2.Text = "s/d"
  Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
  Me.LayoutControlItem2.TextSize = New System.Drawing.Size(15, 13)
  Me.LayoutControlItem2.TextToControlDistance = 5
  '
  'LayoutControlItem3
  '
  Me.LayoutControlItem3.Control = Me.txtTgl1
  Me.LayoutControlItem3.CustomizationFormText = "Tanggal"
  Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
  Me.LayoutControlItem3.Name = "LayoutControlItem3"
  Me.LayoutControlItem3.Size = New System.Drawing.Size(200, 24)
  Me.LayoutControlItem3.Text = "Tanggal"
  Me.LayoutControlItem3.TextSize = New System.Drawing.Size(48, 13)
  '
  'LayoutControlItem4
  '
  Me.LayoutControlItem4.Control = Me.txtTgl2
  Me.LayoutControlItem4.CustomizationFormText = "s/d"
  Me.LayoutControlItem4.Location = New System.Drawing.Point(200, 24)
  Me.LayoutControlItem4.Name = "LayoutControlItem4"
  Me.LayoutControlItem4.Size = New System.Drawing.Size(167, 24)
  Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
  Me.LayoutControlItem4.Text = "s/d"
  Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
  Me.LayoutControlItem4.TextSize = New System.Drawing.Size(15, 13)
  Me.LayoutControlItem4.TextToControlDistance = 5
  '
  'LayoutControlItem5
  '
  Me.LayoutControlItem5.Control = Me.txtKontak
  Me.LayoutControlItem5.CustomizationFormText = "Karyawan"
  Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
  Me.LayoutControlItem5.Name = "LayoutControlItem5"
  Me.LayoutControlItem5.Size = New System.Drawing.Size(367, 24)
  Me.LayoutControlItem5.Text = "Karyawan"
  Me.LayoutControlItem5.TextSize = New System.Drawing.Size(48, 13)
  '
  'LayoutControlItem6
  '
  Me.LayoutControlItem6.Control = Me.txtCatatan
  Me.LayoutControlItem6.CustomizationFormText = "Keterangan"
  Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
  Me.LayoutControlItem6.Name = "LayoutControlItem6"
  Me.LayoutControlItem6.Size = New System.Drawing.Size(367, 25)
  Me.LayoutControlItem6.Text = "Catatan"
  Me.LayoutControlItem6.TextSize = New System.Drawing.Size(48, 13)
  '
  'LayoutControlItem7
  '
  Me.LayoutControlItem7.Control = Me.txtGudang
  Me.LayoutControlItem7.CustomizationFormText = "Gudang"
  Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
  Me.LayoutControlItem7.Name = "LayoutControlItem7"
  Me.LayoutControlItem7.Size = New System.Drawing.Size(367, 24)
  Me.LayoutControlItem7.Text = "Gudang"
  Me.LayoutControlItem7.TextSize = New System.Drawing.Size(48, 13)
  '
  'LayoutControlItem8
  '
  Me.LayoutControlItem8.Control = Me.txtDivisi
  Me.LayoutControlItem8.CustomizationFormText = "Divisi"
  Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 96)
  Me.LayoutControlItem8.Name = "LayoutControlItem8"
  Me.LayoutControlItem8.Size = New System.Drawing.Size(367, 24)
  Me.LayoutControlItem8.Text = "Divisi"
  Me.LayoutControlItem8.TextSize = New System.Drawing.Size(48, 13)
  '
  'RF_DataDataTransaksi
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(387, 214)
  Me.Controls.Add(Me.LayoutControl1)
  Me.Name = "RF_DataDataTransaksi"
  Me.Text = "Filter Laporan"
  Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
  CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
  Me.LayoutControl1.ResumeLayout(False)
  CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)

 End Sub
 Friend WithEvents txtCatatan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
 Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents txtNoBukti1 As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colGridKode As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents txtNoBukti2 As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colTxtBukti2 As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents txtKontak As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents coltxtKontakKode As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colTxtKontakNama As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents txtGudang As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents txtDivisi As DevExpress.XtraEditors.GridLookUpEdit
 Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
