<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohSerialDialog2
	Inherits Core.Win.Forms.BlankForm

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
		Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colMillSheet = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMillsheetRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthIN = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.lytMasterTermin = New DevExpress.XtraLayout.LayoutControl()
		Me.txtMulaiDari = New DevExpress.XtraEditors.SpinEdit()
		Me.btnMillsheet = New DevExpress.XtraEditors.SimpleButton()
		Me.txtMillsheet = New DevExpress.XtraEditors.TextEdit()
		Me.txtUrutan2 = New DevExpress.XtraEditors.SpinEdit()
		Me.txtUrutan1 = New DevExpress.XtraEditors.SpinEdit()
		Me.btn1 = New DevExpress.XtraEditors.SimpleButton()
		Me.txtAwalan = New DevExpress.XtraEditors.TextEdit()
		Me.txtDigit = New DevExpress.XtraEditors.SpinEdit()
		Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colMillsheetRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytMasterTermin.SuspendLayout()
		CType(Me.txtMulaiDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMillsheet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUrutan2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUrutan1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAwalan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDigit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 12)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colMillsheetRepo})
		Me.xGrid.ShowOnlyPredefinedDetails = True
		Me.xGrid.Size = New System.Drawing.Size(451, 395)
		Me.xGrid.TabIndex = 0
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMillSheet, Me.colSerial, Me.colLengthIN, Me.colId})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
		Me.xGridView.OptionsDetail.ShowDetailTabs = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colMillSheet
		'
		Me.colMillSheet.Caption = "Nama Millsheet"
		Me.colMillSheet.ColumnEdit = Me.colMillsheetRepo
		Me.colMillSheet.FieldName = "MillSheet"
		Me.colMillSheet.Name = "colMillSheet"
		Me.colMillSheet.Visible = True
		Me.colMillSheet.VisibleIndex = 0
		Me.colMillSheet.Width = 180
		'
		'colMillsheetRepo
		'
		Me.colMillsheetRepo.AutoHeight = False
		Me.colMillsheetRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Hapus Serial", Nothing, Nothing, True)})
		Me.colMillsheetRepo.Name = "colMillsheetRepo"
		'
		'colSerial
		'
		Me.colSerial.AppearanceCell.Options.UseTextOptions = True
		Me.colSerial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colSerial.AppearanceHeader.Options.UseTextOptions = True
		Me.colSerial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colSerial.Caption = "Nama Serial"
		Me.colSerial.FieldName = "Serial"
		Me.colSerial.Name = "colSerial"
		Me.colSerial.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colSerial.Visible = True
		Me.colSerial.VisibleIndex = 1
		Me.colSerial.Width = 179
		'
		'colLengthIN
		'
		Me.colLengthIN.Caption = "Length"
		Me.colLengthIN.FieldName = "LengthIn"
		Me.colLengthIN.Name = "colLengthIN"
		Me.colLengthIN.Visible = True
		Me.colLengthIN.VisibleIndex = 2
		'
		'colId
		'
		Me.colId.Caption = "Id"
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
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
		Me.lytMasterTermin.Controls.Add(Me.txtMulaiDari)
		Me.lytMasterTermin.Controls.Add(Me.btnMillsheet)
		Me.lytMasterTermin.Controls.Add(Me.txtMillsheet)
		Me.lytMasterTermin.Controls.Add(Me.txtUrutan2)
		Me.lytMasterTermin.Controls.Add(Me.txtUrutan1)
		Me.lytMasterTermin.Controls.Add(Me.btn1)
		Me.lytMasterTermin.Controls.Add(Me.xGrid)
		Me.lytMasterTermin.Controls.Add(Me.txtAwalan)
		Me.lytMasterTermin.Controls.Add(Me.txtDigit)
		Me.lytMasterTermin.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytMasterTermin.Location = New System.Drawing.Point(0, 0)
		Me.lytMasterTermin.Name = "lytMasterTermin"
		Me.lytMasterTermin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(782, 232, 250, 350)
		Me.lytMasterTermin.Root = Me.LayoutControlGroup5
		Me.lytMasterTermin.Size = New System.Drawing.Size(691, 419)
		Me.lytMasterTermin.TabIndex = 109
		Me.lytMasterTermin.Text = "LayoutControl1"
		'
		'txtMulaiDari
		'
		Me.txtMulaiDari.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.txtMulaiDari.Location = New System.Drawing.Point(534, 67)
		Me.txtMulaiDari.Name = "txtMulaiDari"
		Me.txtMulaiDari.Properties.Appearance.Options.UseTextOptions = True
		Me.txtMulaiDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtMulaiDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtMulaiDari.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtMulaiDari.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.txtMulaiDari.Size = New System.Drawing.Size(133, 20)
		Me.txtMulaiDari.StyleController = Me.lytMasterTermin
		Me.txtMulaiDari.TabIndex = 110
		'
		'btnMillsheet
		'
		Me.btnMillsheet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnMillsheet.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btnMillsheet.Appearance.Options.UseForeColor = True
		Me.btnMillsheet.Location = New System.Drawing.Point(479, 252)
		Me.btnMillsheet.Name = "btnMillsheet"
		Me.btnMillsheet.Size = New System.Drawing.Size(188, 22)
		Me.btnMillsheet.StyleController = Me.lytMasterTermin
		Me.btnMillsheet.TabIndex = 111
		Me.btnMillsheet.Text = "&Generate"
		'
		'txtMillsheet
		'
		Me.txtMillsheet.Location = New System.Drawing.Point(534, 218)
		Me.txtMillsheet.Name = "txtMillsheet"
		Me.txtMillsheet.Size = New System.Drawing.Size(133, 20)
		Me.txtMillsheet.StyleController = Me.lytMasterTermin
		Me.txtMillsheet.TabIndex = 110
		'
		'txtUrutan2
		'
		Me.txtUrutan2.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
		Me.txtUrutan2.Location = New System.Drawing.Point(617, 194)
		Me.txtUrutan2.Name = "txtUrutan2"
		Me.txtUrutan2.Properties.Appearance.Options.UseTextOptions = True
		Me.txtUrutan2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtUrutan2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtUrutan2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtUrutan2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.txtUrutan2.Size = New System.Drawing.Size(50, 20)
		Me.txtUrutan2.StyleController = Me.lytMasterTermin
		Me.txtUrutan2.TabIndex = 110
		'
		'txtUrutan1
		'
		Me.txtUrutan1.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
		Me.txtUrutan1.Location = New System.Drawing.Point(534, 194)
		Me.txtUrutan1.Name = "txtUrutan1"
		Me.txtUrutan1.Properties.Appearance.Options.UseTextOptions = True
		Me.txtUrutan1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtUrutan1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtUrutan1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtUrutan1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.txtUrutan1.Size = New System.Drawing.Size(56, 20)
		Me.txtUrutan1.StyleController = Me.lytMasterTermin
		Me.txtUrutan1.TabIndex = 110
		'
		'btn1
		'
		Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btn1.Appearance.Options.UseForeColor = True
		Me.btn1.Location = New System.Drawing.Point(479, 125)
		Me.btn1.Name = "btn1"
		Me.btn1.Size = New System.Drawing.Size(188, 22)
		Me.btn1.StyleController = Me.lytMasterTermin
		Me.btn1.TabIndex = 110
		Me.btn1.Text = "&Generate"
		'
		'txtAwalan
		'
		Me.txtAwalan.Location = New System.Drawing.Point(534, 43)
		Me.txtAwalan.Name = "txtAwalan"
		Me.txtAwalan.Size = New System.Drawing.Size(133, 20)
		Me.txtAwalan.StyleController = Me.lytMasterTermin
		Me.txtAwalan.TabIndex = 1
		'
		'txtDigit
		'
		Me.txtDigit.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
		Me.txtDigit.Location = New System.Drawing.Point(534, 91)
		Me.txtDigit.Name = "txtDigit"
		Me.txtDigit.Properties.Appearance.Options.UseTextOptions = True
		Me.txtDigit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtDigit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDigit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtDigit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.txtDigit.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
		Me.txtDigit.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
		Me.txtDigit.Size = New System.Drawing.Size(133, 20)
		Me.txtDigit.StyleController = Me.lytMasterTermin
		Me.txtDigit.TabIndex = 2
		'
		'LayoutControlGroup5
		'
		Me.LayoutControlGroup5.CustomizationFormText = "Root"
		Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup5.GroupBordersVisible = False
		Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup6, Me.LayoutControlGroup7, Me.EmptySpaceItem3})
		Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup5.Name = "Root"
		Me.LayoutControlGroup5.Size = New System.Drawing.Size(691, 419)
		Me.LayoutControlGroup5.Text = "Root"
		Me.LayoutControlGroup5.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.xGrid
		Me.LayoutControlItem1.CustomizationFormText = "Barang Serial"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(455, 399)
		Me.LayoutControlItem1.Text = "Barang Serial"
		Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem1.TextToControlDistance = 0
		Me.LayoutControlItem1.TextVisible = False
		'
		'LayoutControlGroup6
		'
		Me.LayoutControlGroup6.CustomizationFormText = "Generate Nama Serial"
		Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.EmptySpaceItem2, Me.LayoutControlItem9})
		Me.LayoutControlGroup6.Location = New System.Drawing.Point(455, 0)
		Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
		Me.LayoutControlGroup6.Size = New System.Drawing.Size(216, 151)
		Me.LayoutControlGroup6.Text = "Generate Nama Serial"
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtDigit
		Me.LayoutControlItem6.CustomizationFormText = "Digit"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(192, 24)
		Me.LayoutControlItem6.Text = "Digit"
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(52, 13)
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtAwalan
		Me.LayoutControlItem5.CustomizationFormText = "Awalan   "
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(192, 24)
		Me.LayoutControlItem5.Text = "Awalan   "
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(52, 13)
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.btn1
		Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 82)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(192, 26)
		Me.LayoutControlItem2.Text = "LayoutControlItem2"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem2.TextToControlDistance = 0
		Me.LayoutControlItem2.TextVisible = False
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 72)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(192, 10)
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtMulaiDari
		Me.LayoutControlItem9.CustomizationFormText = "Mulai Dari  "
		Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(192, 24)
		Me.LayoutControlItem9.Text = "Mulai Dari  "
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(52, 13)
		'
		'LayoutControlGroup7
		'
		Me.LayoutControlGroup7.CustomizationFormText = "Generate Nama Millsheet"
		Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem1})
		Me.LayoutControlGroup7.Location = New System.Drawing.Point(455, 151)
		Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
		Me.LayoutControlGroup7.Size = New System.Drawing.Size(216, 127)
		Me.LayoutControlGroup7.Text = "Generate Nama Millsheet"
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtUrutan1
		Me.LayoutControlItem3.CustomizationFormText = "Urutan"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(115, 24)
		Me.LayoutControlItem3.Text = "Urutan"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(52, 13)
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtUrutan2
		Me.LayoutControlItem4.CustomizationFormText = " s/d"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(115, 0)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(77, 24)
		Me.LayoutControlItem4.Text = " s/d"
		Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(18, 13)
		Me.LayoutControlItem4.TextToControlDistance = 5
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.txtMillsheet
		Me.LayoutControlItem7.CustomizationFormText = "Millsheet "
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(192, 24)
		Me.LayoutControlItem7.Text = "Millsheet "
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(52, 13)
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.btnMillsheet
		Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 58)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(192, 26)
		Me.LayoutControlItem8.Text = "LayoutControlItem8"
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem8.TextToControlDistance = 0
		Me.LayoutControlItem8.TextVisible = False
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 48)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(192, 10)
		Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem3
		'
		Me.EmptySpaceItem3.AllowHotTrack = False
		Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Location = New System.Drawing.Point(455, 278)
		Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Size = New System.Drawing.Size(216, 121)
		Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
		Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
		'
		'UI_FusohSerialDialog1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(691, 419)
		Me.Controls.Add(Me.lytMasterTermin)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "UI_FusohSerialDialog1"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "UI_FusohEximDialogSerial"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colMillsheetRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytMasterTermin.ResumeLayout(False)
		CType(Me.txtMulaiDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMillsheet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUrutan2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUrutan1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAwalan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDigit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents lytMasterTermin As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents txtAwalan As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtDigit As DevExpress.XtraEditors.SpinEdit
	Protected Friend WithEvents btn1 As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents txtMillsheet As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtUrutan2 As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtUrutan1 As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Protected Friend WithEvents btnMillsheet As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtMulaiDari As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colLengthIN As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMillsheetRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
