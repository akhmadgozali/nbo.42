<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_TravelDPDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TravelDPDialog))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtSOTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtSOUraian = New DevExpress.XtraEditors.TextEdit()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNominalValas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtAkun = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.txtPelanggan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtOrder = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNoTransaksi = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtUraian = New DevExpress.XtraEditors.MemoEdit()
        Me.txtKurs = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNominal = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSOJmlJamaah = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtSOTotalLay = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtSOTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSOUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPelanggan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNominal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSOJmlJamaah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSOTotalLay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtSOTotal)
        Me.LayoutControl1.Controls.Add(Me.txtSOUraian)
        Me.LayoutControl1.Controls.Add(Me.xGrid)
        Me.LayoutControl1.Controls.Add(Me.txtUang)
        Me.LayoutControl1.Controls.Add(Me.txtAkun)
        Me.LayoutControl1.Controls.Add(Me.txtTanggal)
        Me.LayoutControl1.Controls.Add(Me.txtPelanggan)
        Me.LayoutControl1.Controls.Add(Me.txtOrder)
        Me.LayoutControl1.Controls.Add(Me.txtNoTransaksi)
        Me.LayoutControl1.Controls.Add(Me.txtRegional)
        Me.LayoutControl1.Controls.Add(Me.txtUraian)
        Me.LayoutControl1.Controls.Add(Me.txtKurs)
        Me.LayoutControl1.Controls.Add(Me.txtNominal)
        Me.LayoutControl1.Controls.Add(Me.txtSOJmlJamaah)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(673, 202, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(794, 352)
        Me.LayoutControl1.TabIndex = 100
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtSOTotal
        '
        Me.txtSOTotal.Location = New System.Drawing.Point(468, 91)
        Me.txtSOTotal.Name = "txtSOTotal"
        Me.txtSOTotal.Properties.ReadOnly = True
        Me.txtSOTotal.Size = New System.Drawing.Size(302, 20)
        Me.txtSOTotal.StyleController = Me.LayoutControl1
        Me.txtSOTotal.TabIndex = 104
        '
        'txtSOUraian
        '
        Me.txtSOUraian.Location = New System.Drawing.Point(468, 67)
        Me.txtSOUraian.Name = "txtSOUraian"
        Me.txtSOUraian.Properties.ReadOnly = True
        Me.txtSOUraian.Size = New System.Drawing.Size(302, 20)
        Me.txtSOUraian.StyleController = Me.LayoutControl1
        Me.txtSOUraian.TabIndex = 103
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(375, 158)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.Size = New System.Drawing.Size(395, 170)
        Me.xGrid.TabIndex = 103
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUang, Me.colKode, Me.colTanggal, Me.colNominalValas, Me.colKurs, Me.colNominal})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.GroupCount = 1
        Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nominal", Nothing, " (Nominal : {0:n0})")})
        Me.xGridView.Name = "xGridView"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsView.ShowGroupPanel = False
        Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUang, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colUang
        '
        Me.colUang.Caption = "Mata Uang"
        Me.colUang.FieldName = "Uang.Kode"
        Me.colUang.Name = "colUang"
        Me.colUang.Visible = True
        Me.colUang.VisibleIndex = 0
        '
        'colKode
        '
        Me.colKode.Caption = "Kode"
        Me.colKode.FieldName = "Kode"
        Me.colKode.Name = "colKode"
        Me.colKode.Visible = True
        Me.colKode.VisibleIndex = 0
        Me.colKode.Width = 80
        '
        'colTanggal
        '
        Me.colTanggal.Caption = "Tanggal"
        Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTanggal.FieldName = "Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 1
        Me.colTanggal.Width = 80
        '
        'colNominalValas
        '
        Me.colNominalValas.Caption = "Nominal Valas"
        Me.colNominalValas.DisplayFormat.FormatString = "n0"
        Me.colNominalValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNominalValas.FieldName = "Nominal"
        Me.colNominalValas.Name = "colNominalValas"
        Me.colNominalValas.Visible = True
        Me.colNominalValas.VisibleIndex = 2
        Me.colNominalValas.Width = 80
        '
        'colKurs
        '
        Me.colKurs.Caption = "Kurs"
        Me.colKurs.DisplayFormat.FormatString = "n0"
        Me.colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKurs.FieldName = "Kurs"
        Me.colKurs.Name = "colKurs"
        Me.colKurs.Visible = True
        Me.colKurs.VisibleIndex = 3
        Me.colKurs.Width = 57
        '
        'colNominal
        '
        Me.colNominal.Caption = "Nominal"
        Me.colNominal.DisplayFormat.FormatString = "n0"
        Me.colNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNominal.FieldName = "NominalKurs"
        Me.colNominal.Name = "colNominal"
        Me.colNominal.Visible = True
        Me.colNominal.VisibleIndex = 4
        Me.colNominal.Width = 80
        '
        'txtUang
        '
        Me.txtUang.Location = New System.Drawing.Point(105, 160)
        Me.txtUang.Name = "txtUang"
        Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
        Me.txtUang.Properties.DisplayMember = "Kode"
        Me.txtUang.Properties.NullText = "<Uang>"
        Me.txtUang.Properties.ReadOnly = True
        Me.txtUang.Properties.ValueMember = "This"
        Me.txtUang.Size = New System.Drawing.Size(254, 20)
        Me.txtUang.StyleController = Me.LayoutControl1
        Me.txtUang.TabIndex = 101
        '
        'txtAkun
        '
        Me.txtAkun.Location = New System.Drawing.Point(105, 136)
        Me.txtAkun.Name = "txtAkun"
        Me.txtAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkun.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtAkun.Properties.DisplayMember = "Nama"
        Me.txtAkun.Properties.NullText = "<Pilih Coa>"
        Me.txtAkun.Properties.ValueMember = "This"
        Me.txtAkun.Size = New System.Drawing.Size(254, 20)
        Me.txtAkun.StyleController = Me.LayoutControl1
        Me.txtAkun.TabIndex = 101
        '
        'txtTanggal
        '
        Me.txtTanggal.EditValue = Nothing
        Me.txtTanggal.Location = New System.Drawing.Point(105, 112)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
        Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTanggal.Size = New System.Drawing.Size(254, 20)
        Me.txtTanggal.StyleController = Me.LayoutControl1
        Me.txtTanggal.TabIndex = 101
        '
        'txtPelanggan
        '
        Me.txtPelanggan.Location = New System.Drawing.Point(105, 62)
        Me.txtPelanggan.Name = "txtPelanggan"
        Me.txtPelanggan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPelanggan.Properties.DisplayMember = "Nama"
        Me.txtPelanggan.Properties.NullText = "<Pilih Pelanggan>"
        Me.txtPelanggan.Properties.PopupFormSize = New System.Drawing.Size(330, 0)
        Me.txtPelanggan.Properties.ShowClearButton = False
        Me.txtPelanggan.Properties.ShowFooter = False
        Me.txtPelanggan.Properties.ValueMember = "This"
        Me.txtPelanggan.Properties.View = Me.SearchLookUpEdit1View
        Me.txtPelanggan.Size = New System.Drawing.Size(254, 20)
        Me.txtPelanggan.StyleController = Me.LayoutControl1
        Me.txtPelanggan.TabIndex = 101
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
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(105, 86)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOrder.Properties.DisplayMember = "Kode"
        Me.txtOrder.Properties.NullText = "<Pilih Nomor SO>"
        Me.txtOrder.Properties.ValueMember = "This"
        Me.txtOrder.Properties.View = Me.GridView3
        Me.txtOrder.Size = New System.Drawing.Size(254, 20)
        Me.txtOrder.StyleController = Me.LayoutControl1
        Me.txtOrder.TabIndex = 101
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Kode"
        Me.GridColumn7.FieldName = "Kode"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tanggal"
        Me.GridColumn8.DisplayFormat.FormatString = "dd-MM-yy"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn8.FieldName = "Tanggal"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Pelanggan"
        Me.GridColumn9.FieldName = "Pelanggan.Nama"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Uraian"
        Me.GridColumn10.FieldName = "Uraian"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.Location = New System.Drawing.Point(105, 36)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtNoTransaksi.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtNoTransaksi.Size = New System.Drawing.Size(254, 22)
        Me.txtNoTransaksi.StyleController = Me.LayoutControl1
        Me.txtNoTransaksi.TabIndex = 102
        '
        'txtRegional
        '
        Me.txtRegional.Location = New System.Drawing.Point(105, 12)
        Me.txtRegional.Name = "txtRegional"
        Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
        Me.txtRegional.Properties.DisplayMember = "Nama"
        Me.txtRegional.Properties.NullText = "<Pilih Regional>"
        Me.txtRegional.Properties.PopupWidth = 200
        Me.txtRegional.Properties.ValueMember = "This"
        Me.txtRegional.Size = New System.Drawing.Size(254, 20)
        Me.txtRegional.StyleController = Me.LayoutControl1
        Me.txtRegional.TabIndex = 101
        '
        'txtUraian
        '
        Me.txtUraian.Location = New System.Drawing.Point(105, 234)
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.Size = New System.Drawing.Size(254, 106)
        Me.txtUraian.StyleController = Me.LayoutControl1
        Me.txtUraian.TabIndex = 101
        '
        'txtKurs
        '
        Me.txtKurs.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtKurs.Location = New System.Drawing.Point(105, 186)
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKurs.Properties.DisplayFormat.FormatString = "n"
        Me.txtKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKurs.Properties.EditFormat.FormatString = "n"
        Me.txtKurs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKurs.Size = New System.Drawing.Size(254, 20)
        Me.txtKurs.StyleController = Me.LayoutControl1
        Me.txtKurs.TabIndex = 101
        '
        'txtNominal
        '
        Me.txtNominal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominal.Location = New System.Drawing.Point(105, 210)
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNominal.Properties.DisplayFormat.FormatString = "n"
        Me.txtNominal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNominal.Properties.EditFormat.FormatString = "n"
        Me.txtNominal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNominal.Size = New System.Drawing.Size(254, 20)
        Me.txtNominal.StyleController = Me.LayoutControl1
        Me.txtNominal.TabIndex = 101
        '
        'txtSOJmlJamaah
        '
        Me.txtSOJmlJamaah.Location = New System.Drawing.Point(468, 43)
        Me.txtSOJmlJamaah.Name = "txtSOJmlJamaah"
        Me.txtSOJmlJamaah.Properties.ReadOnly = True
        Me.txtSOJmlJamaah.Size = New System.Drawing.Size(302, 20)
        Me.txtSOJmlJamaah.StyleController = Me.LayoutControl1
        Me.txtSOJmlJamaah.TabIndex = 102
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.SimpleSeparator1, Me.SimpleSeparator2, Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(794, 352)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtRegional
        Me.LayoutControlItem1.CustomizationFormText = "Regional"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem1.Text = "Regional"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNoTransaksi
        Me.LayoutControlItem2.CustomizationFormText = "No. Transaksi"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(351, 26)
        Me.LayoutControlItem2.Text = "No. Transaksi"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtOrder
        Me.LayoutControlItem3.CustomizationFormText = "Travel Order"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem3.Text = "Travel Order"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtPelanggan
        Me.LayoutControlItem4.CustomizationFormText = "Pelanggan"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem4.Text = "Pelanggan"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtTanggal
        Me.LayoutControlItem5.CustomizationFormText = "Tanggal"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem5.Text = "Tanggal"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtAkun
        Me.LayoutControlItem6.CustomizationFormText = "Coa Kas / Bank      "
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem6.Text = "Coa Kas / Bank      "
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtUang
        Me.LayoutControlItem7.CustomizationFormText = "Uang"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem7.Text = "Mata Uang"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtKurs
        Me.LayoutControlItem8.CustomizationFormText = "Kurs"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 174)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem8.Text = "Kurs"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtNominal
        Me.LayoutControlItem9.CustomizationFormText = "Nominal"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 198)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem9.Text = "Nominal"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtUraian
        Me.LayoutControlItem10.CustomizationFormText = "Uraian"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 222)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(351, 110)
        Me.LayoutControlItem10.Text = "Uraian"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(90, 13)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 98)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(351, 2)
        Me.SimpleSeparator1.Text = "SimpleSeparator1"
        '
        'SimpleSeparator2
        '
        Me.SimpleSeparator2.AllowHotTrack = False
        Me.SimpleSeparator2.CustomizationFormText = "SimpleSeparator2"
        Me.SimpleSeparator2.Location = New System.Drawing.Point(0, 172)
        Me.SimpleSeparator2.Name = "SimpleSeparator2"
        Me.SimpleSeparator2.Size = New System.Drawing.Size(351, 2)
        Me.SimpleSeparator2.Text = "SimpleSeparator2"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "Informasi Travel Order [SO]"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.txtSOTotalLay})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(351, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(423, 115)
        Me.LayoutControlGroup2.Text = "Informasi Travel Order [SO]"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtSOJmlJamaah
        Me.LayoutControlItem12.CustomizationFormText = "Jml. Jamaah"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(399, 24)
        Me.LayoutControlItem12.Text = "Jml. Jamaah"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtSOUraian
        Me.LayoutControlItem13.CustomizationFormText = "Uraian"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(399, 24)
        Me.LayoutControlItem13.Text = "Uraian"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(90, 13)
        '
        'txtSOTotalLay
        '
        Me.txtSOTotalLay.Control = Me.txtSOTotal
        Me.txtSOTotalLay.CustomizationFormText = "Total"
        Me.txtSOTotalLay.Location = New System.Drawing.Point(0, 48)
        Me.txtSOTotalLay.Name = "txtSOTotalLay"
        Me.txtSOTotalLay.Size = New System.Drawing.Size(399, 24)
        Me.txtSOTotalLay.Text = "Total"
        Me.txtSOTotalLay.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.CustomizationFormText = "Informasi DP Sebelumnya"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(351, 115)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(423, 217)
        Me.LayoutControlGroup3.Text = "Informasi DP Sebelumnya"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.xGrid
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(399, 174)
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'UI_TravelDPDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 401)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UI_TravelDPDialog"
        Me.Text = "UI_TravelDPDialog"
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtSOTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSOUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPelanggan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNominal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSOJmlJamaah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSOTotalLay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtOrder As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPelanggan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAkun As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUraian As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents txtKurs As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNominal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSOJmlJamaah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSOUraian As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSOTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSOTotalLay As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNominalValas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNominal As DevExpress.XtraGrid.Columns.GridColumn
End Class
