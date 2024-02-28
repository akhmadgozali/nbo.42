<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohOrderPembelianDialogRevisiLength
	Inherits Core.Win.Forms.DialogForm

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
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lytMasterTermin = New DevExpress.XtraLayout.LayoutControl()
        Me.txtGudang = New DevExpress.XtraEditors.TextEdit()
        Me.txtVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtTanggalPO = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoPO = New DevExpress.XtraEditors.TextEdit()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeExim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeGR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEditRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLengthLama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLengthBaru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJmlRevisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.SimpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lytMasterTermin.SuspendLayout()
        CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggalPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
        Me.btn1.Appearance.Options.UseForeColor = True
        Me.btn1.Location = New System.Drawing.Point(867, 11)
        Me.btn1.Text = "&Proses"
        '
        'btn2
        '
        Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btn2.Appearance.Options.UseForeColor = True
        Me.btn2.Location = New System.Drawing.Point(960, 11)
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(0, 396)
        Me.PanelControl1.Size = New System.Drawing.Size(1059, 49)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1108, 94)
        Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
        Me.LayoutControlGroup2.Text = "Info Utama"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Info Utama"
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1108, 94)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
        Me.LayoutControlGroup1.Text = "Info Utama"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Root"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(443, 117)
        Me.LayoutControlGroup3.Text = "Root"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Root"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "Root"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(443, 117)
        Me.LayoutControlGroup4.Text = "Root"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'lytMasterTermin
        '
        Me.lytMasterTermin.Controls.Add(Me.txtGudang)
        Me.lytMasterTermin.Controls.Add(Me.txtVendor)
        Me.lytMasterTermin.Controls.Add(Me.txtTanggalPO)
        Me.lytMasterTermin.Controls.Add(Me.txtNoPO)
        Me.lytMasterTermin.Controls.Add(Me.xGrid)
        Me.lytMasterTermin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytMasterTermin.Location = New System.Drawing.Point(0, 0)
        Me.lytMasterTermin.Name = "lytMasterTermin"
        Me.lytMasterTermin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(584, 232, 250, 350)
        Me.lytMasterTermin.Root = Me.LayoutControlGroup5
        Me.lytMasterTermin.Size = New System.Drawing.Size(1059, 396)
        Me.lytMasterTermin.TabIndex = 109
        Me.lytMasterTermin.Text = "LayoutControl1"
        '
        'txtGudang
        '
        Me.txtGudang.Location = New System.Drawing.Point(117, 84)
        Me.txtGudang.Name = "txtGudang"
        Me.txtGudang.Properties.ReadOnly = True
        Me.txtGudang.Size = New System.Drawing.Size(294, 20)
        Me.txtGudang.StyleController = Me.lytMasterTermin
        Me.txtGudang.TabIndex = 111
        '
        'txtVendor
        '
        Me.txtVendor.Location = New System.Drawing.Point(117, 60)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Properties.ReadOnly = True
        Me.txtVendor.Size = New System.Drawing.Size(294, 20)
        Me.txtVendor.StyleController = Me.lytMasterTermin
        Me.txtVendor.TabIndex = 111
        '
        'txtTanggalPO
        '
        Me.txtTanggalPO.Location = New System.Drawing.Point(117, 36)
        Me.txtTanggalPO.Name = "txtTanggalPO"
        Me.txtTanggalPO.Properties.ReadOnly = True
        Me.txtTanggalPO.Size = New System.Drawing.Size(294, 20)
        Me.txtTanggalPO.StyleController = Me.lytMasterTermin
        Me.txtTanggalPO.TabIndex = 111
        '
        'txtNoPO
        '
        Me.txtNoPO.Location = New System.Drawing.Point(117, 12)
        Me.txtNoPO.Name = "txtNoPO"
        Me.txtNoPO.Properties.ReadOnly = True
        Me.txtNoPO.Size = New System.Drawing.Size(294, 20)
        Me.txtNoPO.StyleController = Me.lytMasterTermin
        Me.txtNoPO.TabIndex = 110
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(12, 110)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1, Me.btnEditRepo})
        Me.xGrid.Size = New System.Drawing.Size(1035, 274)
        Me.xGrid.TabIndex = 110
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colKodeExim, Me.colKodeGR, Me.colDempyou, Me.colProduksi, Me.colLengthLama, Me.colLengthBaru, Me.colCatatan, Me.colJmlRevisi})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.NewItemRowText = "Tambah Data"
        Me.xGridView.OptionsCustomization.AllowGroup = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colKodeBarang
        '
        Me.colKodeBarang.Caption = "Part No."
        Me.colKodeBarang.FieldName = "PODetail.Barang.Kode"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.OptionsColumn.FixedWidth = True
        Me.colKodeBarang.OptionsColumn.ReadOnly = True
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 0
        Me.colKodeBarang.Width = 120
        '
        'colNamaBarang
        '
        Me.colNamaBarang.Caption = "Material"
        Me.colNamaBarang.FieldName = "PODetail.Barang.Nama"
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.OptionsColumn.FixedWidth = True
        Me.colNamaBarang.OptionsColumn.ReadOnly = True
        Me.colNamaBarang.Visible = True
        Me.colNamaBarang.VisibleIndex = 1
        Me.colNamaBarang.Width = 130
        '
        'colQty
        '
        Me.colQty.AppearanceCell.Options.UseTextOptions = True
        Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "PODetail.Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowSize = False
        Me.colQty.OptionsColumn.FixedWidth = True
        Me.colQty.OptionsColumn.ReadOnly = True
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 2
        Me.colQty.Width = 45
        '
        'colKodeExim
        '
        Me.colKodeExim.Caption = "No. Exim"
        Me.colKodeExim.FieldName = "EximDetail.Main.Kode"
        Me.colKodeExim.Name = "colKodeExim"
        Me.colKodeExim.OptionsColumn.FixedWidth = True
        Me.colKodeExim.OptionsColumn.ReadOnly = True
        Me.colKodeExim.Visible = True
        Me.colKodeExim.VisibleIndex = 3
        Me.colKodeExim.Width = 90
        '
        'colKodeGR
        '
        Me.colKodeGR.Caption = "Nomor GRN"
        Me.colKodeGR.FieldName = "GRDetail.Main.Kode"
        Me.colKodeGR.Name = "colKodeGR"
        Me.colKodeGR.OptionsColumn.FixedWidth = True
        Me.colKodeGR.OptionsColumn.ReadOnly = True
        Me.colKodeGR.Visible = True
        Me.colKodeGR.VisibleIndex = 4
        Me.colKodeGR.Width = 90
        '
        'colDempyou
        '
        Me.colDempyou.Caption = "Jml Dempyou"
        Me.colDempyou.ColumnEdit = Me.btnEditRepo
        Me.colDempyou.FieldName = "JumlahDempyou"
        Me.colDempyou.Name = "colDempyou"
        Me.colDempyou.OptionsColumn.FixedWidth = True
        Me.colDempyou.OptionsColumn.ReadOnly = True
        Me.colDempyou.Visible = True
        Me.colDempyou.VisibleIndex = 5
        Me.colDempyou.Width = 70
        '
        'btnEditRepo
        '
        Me.btnEditRepo.AutoHeight = False
        Me.btnEditRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnEditRepo.Name = "btnEditRepo"
        '
        'colProduksi
        '
        Me.colProduksi.Caption = "Jml WIP/Produksi"
        Me.colProduksi.ColumnEdit = Me.btnEditRepo
        Me.colProduksi.FieldName = "JumlahProduksi"
        Me.colProduksi.Name = "colProduksi"
        Me.colProduksi.OptionsColumn.FixedWidth = True
        Me.colProduksi.OptionsColumn.ReadOnly = True
        Me.colProduksi.Visible = True
        Me.colProduksi.VisibleIndex = 6
        Me.colProduksi.Width = 90
        '
        'colLengthLama
        '
        Me.colLengthLama.Caption = "Length Lama"
        Me.colLengthLama.DisplayFormat.FormatString = "n2"
        Me.colLengthLama.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLengthLama.FieldName = "PODetail.Length"
        Me.colLengthLama.Name = "colLengthLama"
        Me.colLengthLama.OptionsColumn.FixedWidth = True
        Me.colLengthLama.OptionsColumn.ReadOnly = True
        Me.colLengthLama.Visible = True
        Me.colLengthLama.VisibleIndex = 7
        Me.colLengthLama.Width = 70
        '
        'colLengthBaru
        '
        Me.colLengthBaru.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colLengthBaru.AppearanceCell.Options.UseBackColor = True
        Me.colLengthBaru.Caption = "Length Baru"
        Me.colLengthBaru.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colLengthBaru.FieldName = "LengthBaru"
        Me.colLengthBaru.Name = "colLengthBaru"
        Me.colLengthBaru.OptionsColumn.FixedWidth = True
        Me.colLengthBaru.Visible = True
        Me.colLengthBaru.VisibleIndex = 8
        Me.colLengthBaru.Width = 70
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colCatatan
        '
        Me.colCatatan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCatatan.AppearanceCell.Options.UseBackColor = True
        Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
        Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
        Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCatatan.Caption = "Catatan"
        Me.colCatatan.FieldName = "Keterangan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.OptionsColumn.FixedWidth = True
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 9
        Me.colCatatan.Width = 180
        '
        'colJmlRevisi
        '
        Me.colJmlRevisi.Caption = "Jml Revisi"
        Me.colJmlRevisi.DisplayFormat.FormatString = "n0"
        Me.colJmlRevisi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colJmlRevisi.FieldName = "JumlahRevisi"
        Me.colJmlRevisi.Name = "colJmlRevisi"
        Me.colJmlRevisi.Visible = True
        Me.colJmlRevisi.VisibleIndex = 10
        Me.colJmlRevisi.Width = 62
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Root"
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.SimpleSeparator1, Me.EmptySpaceItem1, Me.SimpleLabelItem1, Me.SimpleLabelItem2, Me.SimpleLabelItem3, Me.EmptySpaceItem2})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "Root"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1059, 396)
        Me.LayoutControlGroup5.Text = "Root"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.xGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1039, 278)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNoPO
        Me.LayoutControlItem2.CustomizationFormText = "Nomor PO"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(403, 24)
        Me.LayoutControlItem2.Text = "Nomor PO"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 20)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtTanggalPO
        Me.LayoutControlItem3.CustomizationFormText = "Tanggal PO"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(403, 24)
        Me.LayoutControlItem3.Text = "Tanggal PO"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 20)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtVendor
        Me.LayoutControlItem4.CustomizationFormText = "Vendor"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(403, 24)
        Me.LayoutControlItem4.Text = "Vendor"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 20)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtGudang
        Me.LayoutControlItem5.CustomizationFormText = "Gudang"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(403, 24)
        Me.LayoutControlItem5.Text = "Gudang"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 20)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 96)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(403, 2)
        Me.SimpleSeparator1.Text = "SimpleSeparator1"
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(403, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(29, 98)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.SimpleLabelItem1.CustomizationFormText = "Keterangan :"
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(432, 0)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(607, 17)
        Me.SimpleLabelItem1.Text = "Keterangan :"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(442, 13)
        '
        'SimpleLabelItem2
        '
        Me.SimpleLabelItem2.AllowHotTrack = False
        Me.SimpleLabelItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseForeColor = True
        Me.SimpleLabelItem2.CustomizationFormText = "- Proses ini akan mempengaruhi jumlah stok apabila sudah ada proses cutting WIP /" &
    " Produksi"
        Me.SimpleLabelItem2.Location = New System.Drawing.Point(432, 17)
        Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
        Me.SimpleLabelItem2.Size = New System.Drawing.Size(607, 17)
        Me.SimpleLabelItem2.Text = "- Proses ini akan mempengaruhi jumlah stok apabila sudah ada proses cutting WIP /" &
    " Produksi"
        Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(442, 13)
        '
        'SimpleLabelItem3
        '
        Me.SimpleLabelItem3.AllowHotTrack = False
        Me.SimpleLabelItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.SimpleLabelItem3.AppearanceItemCaption.Options.UseForeColor = True
        Me.SimpleLabelItem3.CustomizationFormText = "- Proses ini tidak dapat dibatalkan"
        Me.SimpleLabelItem3.Location = New System.Drawing.Point(432, 34)
        Me.SimpleLabelItem3.Name = "SimpleLabelItem3"
        Me.SimpleLabelItem3.Size = New System.Drawing.Size(607, 17)
        Me.SimpleLabelItem3.Text = "- Proses ini tidak dapat dibatalkan"
        Me.SimpleLabelItem3.TextSize = New System.Drawing.Size(442, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(432, 51)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(607, 47)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'UI_FusohOrderPembelianDialogRevisiLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 445)
        Me.Controls.Add(Me.lytMasterTermin)
        Me.Name = "UI_FusohOrderPembelianDialogRevisiLength"
        Me.Text = "PO - Revisi Length"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.lytMasterTermin, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lytMasterTermin.ResumeLayout(False)
        CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggalPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lytMasterTermin As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLengthLama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colKodeGR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDempyou As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLengthBaru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents SimpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents txtNoPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTanggalPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtGudang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colJmlRevisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colKodeExim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEditRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
