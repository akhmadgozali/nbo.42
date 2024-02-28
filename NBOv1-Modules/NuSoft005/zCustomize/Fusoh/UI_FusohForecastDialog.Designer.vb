<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohForecastDialog
	Inherits Core.Win.Forms.InputDialog

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
		Me.lytMasterTermin = New DevExpress.XtraLayout.LayoutControl()
		Me.txtStokAwal = New DevExpress.XtraEditors.SpinEdit()
		Me.txtMSize = New DevExpress.XtraEditors.TextEdit()
		Me.txtMNama = New DevExpress.XtraEditors.TextEdit()
		Me.txtFGSize = New DevExpress.XtraEditors.TextEdit()
		Me.txtMQty = New DevExpress.XtraEditors.SpinEdit()
		Me.txtFGQty = New DevExpress.XtraEditors.SpinEdit()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
		Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
		Me.colBulan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colStokAwal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
		Me.colIncomingBatang = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colSpinRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.colIncomingPcs = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
		Me.colDelivery = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colStokAkhir = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colStokRatio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.colBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.txtLotPerBatang = New DevExpress.XtraEditors.SpinEdit()
		Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit()
		Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
		Me.txtFGNama = New DevExpress.XtraEditors.TextEdit()
		Me.txtCustomer = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colCustKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtFinishGood = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colFgKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colFgNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colFgOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colFgT = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colFgL = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtMaterial = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colMKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMT = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colML = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.layGroup = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
		Me.SimpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
		Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytMasterTermin.SuspendLayout()
		CType(Me.txtStokAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFGSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFGQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSpinRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtLotPerBatang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFGNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFinishGood.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.layGroup, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lytMasterTermin
		'
		Me.lytMasterTermin.Controls.Add(Me.txtStokAwal)
		Me.lytMasterTermin.Controls.Add(Me.txtMSize)
		Me.lytMasterTermin.Controls.Add(Me.txtMNama)
		Me.lytMasterTermin.Controls.Add(Me.txtFGSize)
		Me.lytMasterTermin.Controls.Add(Me.txtMQty)
		Me.lytMasterTermin.Controls.Add(Me.txtFGQty)
		Me.lytMasterTermin.Controls.Add(Me.xGrid)
		Me.lytMasterTermin.Controls.Add(Me.txtLotPerBatang)
		Me.lytMasterTermin.Controls.Add(Me.txtKeterangan)
		Me.lytMasterTermin.Controls.Add(Me.txtTanggal)
		Me.lytMasterTermin.Controls.Add(Me.txtFGNama)
		Me.lytMasterTermin.Controls.Add(Me.txtCustomer)
		Me.lytMasterTermin.Controls.Add(Me.txtFinishGood)
		Me.lytMasterTermin.Controls.Add(Me.txtMaterial)
		Me.lytMasterTermin.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytMasterTermin.Location = New System.Drawing.Point(0, 0)
		Me.lytMasterTermin.Name = "lytMasterTermin"
		Me.lytMasterTermin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(398, 325, 250, 350)
		Me.lytMasterTermin.Root = Me.LayoutControlGroup1
		Me.lytMasterTermin.Size = New System.Drawing.Size(795, 475)
		Me.lytMasterTermin.TabIndex = 0
		Me.lytMasterTermin.Text = "LayoutControl1"
		'
		'txtStokAwal
		'
		Me.txtStokAwal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtStokAwal.EnterMoveNextControl = True
		Me.txtStokAwal.Location = New System.Drawing.Point(278, 142)
		Me.txtStokAwal.Name = "txtStokAwal"
		Me.txtStokAwal.Properties.Appearance.Options.UseTextOptions = True
		Me.txtStokAwal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtStokAwal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtStokAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtStokAwal.Properties.DisplayFormat.FormatString = "n0"
		Me.txtStokAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtStokAwal.Properties.EditFormat.FormatString = "n0"
		Me.txtStokAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtStokAwal.Properties.ReadOnly = True
		Me.txtStokAwal.Size = New System.Drawing.Size(167, 20)
		Me.txtStokAwal.StyleController = Me.lytMasterTermin
		Me.txtStokAwal.TabIndex = 100
		'
		'txtMSize
		'
		Me.txtMSize.EditValue = ""
		Me.txtMSize.EnterMoveNextControl = True
		Me.txtMSize.Location = New System.Drawing.Point(547, 84)
		Me.txtMSize.Name = "txtMSize"
		Me.txtMSize.Properties.Appearance.Options.UseTextOptions = True
		Me.txtMSize.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtMSize.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMSize.Properties.ReadOnly = True
		Me.txtMSize.Size = New System.Drawing.Size(146, 20)
		Me.txtMSize.StyleController = Me.lytMasterTermin
		Me.txtMSize.TabIndex = 102
		'
		'txtMNama
		'
		Me.txtMNama.EditValue = ""
		Me.txtMNama.EnterMoveNextControl = True
		Me.txtMNama.Location = New System.Drawing.Point(397, 84)
		Me.txtMNama.Name = "txtMNama"
		Me.txtMNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMNama.Properties.ReadOnly = True
		Me.txtMNama.Size = New System.Drawing.Size(146, 20)
		Me.txtMNama.StyleController = Me.lytMasterTermin
		Me.txtMNama.TabIndex = 102
		'
		'txtFGSize
		'
		Me.txtFGSize.EditValue = ""
		Me.txtFGSize.EnterMoveNextControl = True
		Me.txtFGSize.Location = New System.Drawing.Point(547, 60)
		Me.txtFGSize.Name = "txtFGSize"
		Me.txtFGSize.Properties.Appearance.Options.UseTextOptions = True
		Me.txtFGSize.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtFGSize.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtFGSize.Properties.ReadOnly = True
		Me.txtFGSize.Size = New System.Drawing.Size(146, 20)
		Me.txtFGSize.StyleController = Me.lytMasterTermin
		Me.txtFGSize.TabIndex = 102
		'
		'txtMQty
		'
		Me.txtMQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtMQty.EnterMoveNextControl = True
		Me.txtMQty.Location = New System.Drawing.Point(697, 84)
		Me.txtMQty.Name = "txtMQty"
		Me.txtMQty.Properties.Appearance.Options.UseTextOptions = True
		Me.txtMQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtMQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtMQty.Properties.DisplayFormat.FormatString = "n2"
		Me.txtMQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtMQty.Properties.EditFormat.FormatString = "n2"
		Me.txtMQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtMQty.Properties.ReadOnly = True
		Me.txtMQty.Size = New System.Drawing.Size(74, 20)
		Me.txtMQty.StyleController = Me.lytMasterTermin
		Me.txtMQty.TabIndex = 100
		'
		'txtFGQty
		'
		Me.txtFGQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtFGQty.EnterMoveNextControl = True
		Me.txtFGQty.Location = New System.Drawing.Point(697, 60)
		Me.txtFGQty.Name = "txtFGQty"
		Me.txtFGQty.Properties.Appearance.Options.UseTextOptions = True
		Me.txtFGQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtFGQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtFGQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtFGQty.Properties.DisplayFormat.FormatString = "n2"
		Me.txtFGQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtFGQty.Properties.EditFormat.FormatString = "n2"
		Me.txtFGQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtFGQty.Properties.ReadOnly = True
		Me.txtFGQty.Size = New System.Drawing.Size(74, 20)
		Me.txtFGQty.StyleController = Me.lytMasterTermin
		Me.txtFGQty.TabIndex = 100
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 194)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colBarangRepo, Me.colSpinRepo})
		Me.xGrid.ShowOnlyPredefinedDetails = True
		Me.xGrid.Size = New System.Drawing.Size(771, 269)
		Me.xGrid.TabIndex = 100
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.gridBand3})
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colBulan, Me.colStokAwal, Me.colIncomingBatang, Me.colIncomingPcs, Me.colDelivery, Me.colStokAkhir, Me.colStokRatio})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'GridBand1
		'
		Me.GridBand1.Caption = " "
		Me.GridBand1.Columns.Add(Me.colBulan)
		Me.GridBand1.Columns.Add(Me.colStokAwal)
		Me.GridBand1.Name = "GridBand1"
		Me.GridBand1.VisibleIndex = 0
		Me.GridBand1.Width = 340
		'
		'colBulan
		'
		Me.colBulan.AppearanceHeader.Options.UseTextOptions = True
		Me.colBulan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colBulan.Caption = "Bulan"
		Me.colBulan.DisplayFormat.FormatString = "MMMM yyyy"
		Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.FieldName = "Bulan"
		Me.colBulan.Name = "colBulan"
		Me.colBulan.OptionsColumn.AllowEdit = False
		Me.colBulan.OptionsColumn.ReadOnly = True
		Me.colBulan.Visible = True
		Me.colBulan.Width = 250
		'
		'colStokAwal
		'
		Me.colStokAwal.AppearanceHeader.Options.UseTextOptions = True
		Me.colStokAwal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colStokAwal.Caption = "Stok Awal"
		Me.colStokAwal.DisplayFormat.FormatString = "n0"
		Me.colStokAwal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colStokAwal.FieldName = "StokAwal"
		Me.colStokAwal.Name = "colStokAwal"
		Me.colStokAwal.OptionsColumn.AllowEdit = False
		Me.colStokAwal.OptionsColumn.ReadOnly = True
		Me.colStokAwal.Visible = True
		Me.colStokAwal.Width = 90
		'
		'gridBand2
		'
		Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
		Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.gridBand2.Caption = "Incoming"
		Me.gridBand2.Columns.Add(Me.colIncomingBatang)
		Me.gridBand2.Columns.Add(Me.colIncomingPcs)
		Me.gridBand2.Name = "gridBand2"
		Me.gridBand2.VisibleIndex = 1
		Me.gridBand2.Width = 164
		'
		'colIncomingBatang
		'
		Me.colIncomingBatang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colIncomingBatang.AppearanceCell.Options.UseBackColor = True
		Me.colIncomingBatang.AppearanceHeader.Options.UseTextOptions = True
		Me.colIncomingBatang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colIncomingBatang.Caption = "Batang"
		Me.colIncomingBatang.ColumnEdit = Me.colSpinRepo
		Me.colIncomingBatang.DisplayFormat.FormatString = "n0"
		Me.colIncomingBatang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colIncomingBatang.FieldName = "IncomingBatang"
		Me.colIncomingBatang.Name = "colIncomingBatang"
		Me.colIncomingBatang.Visible = True
		Me.colIncomingBatang.Width = 82
		'
		'colSpinRepo
		'
		Me.colSpinRepo.AutoHeight = False
		Me.colSpinRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colSpinRepo.DisplayFormat.FormatString = "n0"
		Me.colSpinRepo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSpinRepo.EditFormat.FormatString = "n0"
		Me.colSpinRepo.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSpinRepo.Name = "colSpinRepo"
		'
		'colIncomingPcs
		'
		Me.colIncomingPcs.AppearanceHeader.Options.UseTextOptions = True
		Me.colIncomingPcs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colIncomingPcs.Caption = "Pcs"
		Me.colIncomingPcs.DisplayFormat.FormatString = "n0"
		Me.colIncomingPcs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colIncomingPcs.FieldName = "IncomingPcs"
		Me.colIncomingPcs.Name = "colIncomingPcs"
		Me.colIncomingPcs.OptionsColumn.AllowEdit = False
		Me.colIncomingPcs.OptionsColumn.ReadOnly = True
		Me.colIncomingPcs.Visible = True
		Me.colIncomingPcs.Width = 82
		'
		'gridBand3
		'
		Me.gridBand3.Caption = " "
		Me.gridBand3.Columns.Add(Me.colDelivery)
		Me.gridBand3.Columns.Add(Me.colStokAkhir)
		Me.gridBand3.Columns.Add(Me.colStokRatio)
		Me.gridBand3.Name = "gridBand3"
		Me.gridBand3.VisibleIndex = 2
		Me.gridBand3.Width = 249
		'
		'colDelivery
		'
		Me.colDelivery.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colDelivery.AppearanceCell.Options.UseBackColor = True
		Me.colDelivery.AppearanceHeader.Options.UseTextOptions = True
		Me.colDelivery.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colDelivery.Caption = "Delivery"
		Me.colDelivery.DisplayFormat.FormatString = "n0"
		Me.colDelivery.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colDelivery.FieldName = "Delivery"
		Me.colDelivery.Name = "colDelivery"
		Me.colDelivery.Visible = True
		Me.colDelivery.Width = 82
		'
		'colStokAkhir
		'
		Me.colStokAkhir.AppearanceHeader.Options.UseTextOptions = True
		Me.colStokAkhir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colStokAkhir.Caption = "Stok Akhir"
		Me.colStokAkhir.DisplayFormat.FormatString = "n0"
		Me.colStokAkhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colStokAkhir.FieldName = "StokAkhir"
		Me.colStokAkhir.Name = "colStokAkhir"
		Me.colStokAkhir.OptionsColumn.AllowEdit = False
		Me.colStokAkhir.OptionsColumn.ReadOnly = True
		Me.colStokAkhir.Visible = True
		Me.colStokAkhir.Width = 82
		'
		'colStokRatio
		'
		Me.colStokRatio.AppearanceHeader.Options.UseTextOptions = True
		Me.colStokRatio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colStokRatio.Caption = "Stok Ratio"
		Me.colStokRatio.DisplayFormat.FormatString = "n1"
		Me.colStokRatio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colStokRatio.FieldName = "StokRatio"
		Me.colStokRatio.Name = "colStokRatio"
		Me.colStokRatio.OptionsColumn.AllowEdit = False
		Me.colStokRatio.OptionsColumn.ReadOnly = True
		Me.colStokRatio.Visible = True
		Me.colStokRatio.Width = 85
		'
		'colBarangRepo
		'
		Me.colBarangRepo.AutoHeight = False
		Me.colBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Serial", Nothing, Nothing, True)})
		Me.colBarangRepo.Name = "colBarangRepo"
		Me.colBarangRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
		'
		'txtLotPerBatang
		'
		Me.txtLotPerBatang.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtLotPerBatang.EnterMoveNextControl = True
		Me.txtLotPerBatang.Location = New System.Drawing.Point(278, 118)
		Me.txtLotPerBatang.Name = "txtLotPerBatang"
		Me.txtLotPerBatang.Properties.Appearance.Options.UseTextOptions = True
		Me.txtLotPerBatang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtLotPerBatang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtLotPerBatang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtLotPerBatang.Properties.DisplayFormat.FormatString = "n0"
		Me.txtLotPerBatang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtLotPerBatang.Properties.EditFormat.FormatString = "n0"
		Me.txtLotPerBatang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtLotPerBatang.Size = New System.Drawing.Size(167, 20)
		Me.txtLotPerBatang.StyleController = Me.lytMasterTermin
		Me.txtLotPerBatang.TabIndex = 3
		'
		'txtKeterangan
		'
		Me.txtKeterangan.EnterMoveNextControl = True
		Me.txtKeterangan.Location = New System.Drawing.Point(12, 108)
		Me.txtKeterangan.Name = "txtKeterangan"
		Me.txtKeterangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtKeterangan.Size = New System.Drawing.Size(173, 66)
		Me.txtKeterangan.StyleController = Me.lytMasterTermin
		Me.txtKeterangan.TabIndex = 4
		'
		'txtTanggal
		'
		Me.txtTanggal.EditValue = Nothing
		Me.txtTanggal.EnterMoveNextControl = True
		Me.txtTanggal.Location = New System.Drawing.Point(12, 28)
		Me.txtTanggal.Name = "txtTanggal"
		Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal.Size = New System.Drawing.Size(173, 20)
		Me.txtTanggal.StyleController = Me.lytMasterTermin
		Me.txtTanggal.TabIndex = 0
		'
		'txtFGNama
		'
		Me.txtFGNama.EditValue = ""
		Me.txtFGNama.EnterMoveNextControl = True
		Me.txtFGNama.Location = New System.Drawing.Point(397, 60)
		Me.txtFGNama.Name = "txtFGNama"
		Me.txtFGNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtFGNama.Properties.ReadOnly = True
		Me.txtFGNama.Size = New System.Drawing.Size(146, 20)
		Me.txtFGNama.StyleController = Me.lytMasterTermin
		Me.txtFGNama.TabIndex = 101
		'
		'txtCustomer
		'
		Me.txtCustomer.EnterMoveNextControl = True
		Me.txtCustomer.Location = New System.Drawing.Point(12, 68)
		Me.txtCustomer.Name = "txtCustomer"
		Me.txtCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCustomer.Properties.DisplayMember = "Kode"
		Me.txtCustomer.Properties.NullText = "[ Masukkan Customer ]"
		Me.txtCustomer.Properties.ValueMember = "This"
		Me.txtCustomer.Properties.View = Me.SearchLookUpEdit1View
		Me.txtCustomer.Size = New System.Drawing.Size(173, 20)
		Me.txtCustomer.StyleController = Me.lytMasterTermin
		Me.txtCustomer.TabIndex = 2
		'
		'SearchLookUpEdit1View
		'
		Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustKode, Me.colCustNama})
		Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
		Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		'
		'colCustKode
		'
		Me.colCustKode.Caption = "Kode"
		Me.colCustKode.FieldName = "Kode"
		Me.colCustKode.Name = "colCustKode"
		Me.colCustKode.Visible = True
		Me.colCustKode.VisibleIndex = 0
		Me.colCustKode.Width = 120
		'
		'colCustNama
		'
		Me.colCustNama.Caption = "Nama"
		Me.colCustNama.FieldName = "Nama"
		Me.colCustNama.Name = "colCustNama"
		Me.colCustNama.Visible = True
		Me.colCustNama.VisibleIndex = 1
		Me.colCustNama.Width = 264
		'
		'txtFinishGood
		'
		Me.txtFinishGood.EnterMoveNextControl = True
		Me.txtFinishGood.Location = New System.Drawing.Point(278, 60)
		Me.txtFinishGood.Name = "txtFinishGood"
		Me.txtFinishGood.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtFinishGood.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtFinishGood.Properties.DisplayMember = "Kode"
		Me.txtFinishGood.Properties.NullText = "[ Finish Good ]"
		Me.txtFinishGood.Properties.ValueMember = "This"
		Me.txtFinishGood.Properties.View = Me.GridView1
		Me.txtFinishGood.Size = New System.Drawing.Size(115, 20)
		Me.txtFinishGood.StyleController = Me.lytMasterTermin
		Me.txtFinishGood.TabIndex = 100
		'
		'GridView1
		'
		Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFgKode, Me.colFgNama, Me.colFgOD, Me.colFgT, Me.colFgL})
		Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView1.OptionsView.ShowGroupPanel = False
		'
		'colFgKode
		'
		Me.colFgKode.Caption = "Kode"
		Me.colFgKode.FieldName = "Kode"
		Me.colFgKode.Name = "colFgKode"
		Me.colFgKode.Visible = True
		Me.colFgKode.VisibleIndex = 0
		Me.colFgKode.Width = 70
		'
		'colFgNama
		'
		Me.colFgNama.Caption = "Nama Part"
		Me.colFgNama.FieldName = "NamaPart"
		Me.colFgNama.Name = "colFgNama"
		Me.colFgNama.Visible = True
		Me.colFgNama.VisibleIndex = 1
		Me.colFgNama.Width = 150
		'
		'colFgOD
		'
		Me.colFgOD.Caption = "OD"
		Me.colFgOD.FieldName = "OutDiameter"
		Me.colFgOD.Name = "colFgOD"
		Me.colFgOD.Visible = True
		Me.colFgOD.VisibleIndex = 2
		Me.colFgOD.Width = 55
		'
		'colFgT
		'
		Me.colFgT.Caption = "T"
		Me.colFgT.FieldName = "Thickness"
		Me.colFgT.Name = "colFgT"
		Me.colFgT.Visible = True
		Me.colFgT.VisibleIndex = 3
		Me.colFgT.Width = 55
		'
		'colFgL
		'
		Me.colFgL.Caption = "L"
		Me.colFgL.FieldName = "Length"
		Me.colFgL.Name = "colFgL"
		Me.colFgL.Visible = True
		Me.colFgL.VisibleIndex = 4
		Me.colFgL.Width = 54
		'
		'txtMaterial
		'
		Me.txtMaterial.EnterMoveNextControl = True
		Me.txtMaterial.Location = New System.Drawing.Point(278, 84)
		Me.txtMaterial.Name = "txtMaterial"
		Me.txtMaterial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMaterial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtMaterial.Properties.DisplayMember = "Kode"
		Me.txtMaterial.Properties.NullText = "[ Material ]"
		Me.txtMaterial.Properties.ValueMember = "This"
		Me.txtMaterial.Properties.View = Me.GridView2
		Me.txtMaterial.Size = New System.Drawing.Size(115, 20)
		Me.txtMaterial.StyleController = Me.lytMasterTermin
		Me.txtMaterial.TabIndex = 100
		'
		'GridView2
		'
		Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMKode, Me.colMNama, Me.colMOD, Me.colMT, Me.colML})
		Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView2.Name = "GridView2"
		Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView2.OptionsView.ShowGroupPanel = False
		'
		'colMKode
		'
		Me.colMKode.Caption = "Kode"
		Me.colMKode.FieldName = "Kode"
		Me.colMKode.Name = "colMKode"
		Me.colMKode.Visible = True
		Me.colMKode.VisibleIndex = 0
		Me.colMKode.Width = 70
		'
		'colMNama
		'
		Me.colMNama.Caption = "Nama"
		Me.colMNama.FieldName = "Nama"
		Me.colMNama.Name = "colMNama"
		Me.colMNama.Visible = True
		Me.colMNama.VisibleIndex = 1
		Me.colMNama.Width = 150
		'
		'colMOD
		'
		Me.colMOD.Caption = "OD"
		Me.colMOD.FieldName = "OutDiameter"
		Me.colMOD.Name = "colMOD"
		Me.colMOD.Visible = True
		Me.colMOD.VisibleIndex = 2
		Me.colMOD.Width = 55
		'
		'colMT
		'
		Me.colMT.Caption = "T"
		Me.colMT.FieldName = "Thickness"
		Me.colMT.Name = "colMT"
		Me.colMT.Visible = True
		Me.colMT.VisibleIndex = 3
		Me.colMT.Width = 55
		'
		'colML
		'
		Me.colML.Caption = "L"
		Me.colML.FieldName = "Length"
		Me.colML.Name = "colML"
		Me.colML.Visible = True
		Me.colML.VisibleIndex = 4
		Me.colML.Width = 54
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.layGroup})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(795, 475)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtTanggal
		Me.LayoutControlItem1.CustomizationFormText = "Kode"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(177, 40)
		Me.LayoutControlItem1.Text = "Tanggal"
		Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem10
		'
		Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
		Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
		Me.LayoutControlItem10.Control = Me.txtKeterangan
		Me.LayoutControlItem10.CustomizationFormText = "Keterangan"
		Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 80)
		Me.LayoutControlItem10.Name = "LayoutControlItem10"
		Me.LayoutControlItem10.Size = New System.Drawing.Size(177, 86)
		Me.LayoutControlItem10.Text = "Keterangan      "
		Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem10.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtCustomer
		Me.LayoutControlItem3.CustomizationFormText = "Mata Uang"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 40)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(177, 40)
		Me.LayoutControlItem3.Text = "Customer"
		Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem4.Control = Me.xGrid
		Me.LayoutControlItem4.CustomizationFormText = "Detail : "
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 166)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(775, 289)
		Me.LayoutControlItem4.Text = "Detail : "
		Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(74, 13)
		'
		'layGroup
		'
		Me.layGroup.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.layGroup.AppearanceGroup.Options.UseFont = True
		Me.layGroup.CustomizationFormText = "Customer Name"
		Me.layGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.SimpleLabelItem1, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.EmptySpaceItem3, Me.LayoutControlItem2, Me.LayoutControlItem9, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.SimpleLabelItem2, Me.SimpleLabelItem3, Me.LayoutControlItem11, Me.LayoutControlItem14, Me.EmptySpaceItem4, Me.EmptySpaceItem5})
		Me.layGroup.Location = New System.Drawing.Point(177, 0)
		Me.layGroup.Name = "layGroup"
		Me.layGroup.Size = New System.Drawing.Size(598, 166)
		Me.layGroup.Text = "Customer Name"
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtFinishGood
		Me.LayoutControlItem5.CustomizationFormText = "Finish Good"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 17)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(196, 24)
		Me.LayoutControlItem5.Text = "Finish Good"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.txtFGQty
		Me.LayoutControlItem7.CustomizationFormText = "Qty"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(496, 17)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(78, 24)
		Me.LayoutControlItem7.Text = "Qty"
		Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem7.TextToControlDistance = 0
		Me.LayoutControlItem7.TextVisible = False
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(196, 17)
		Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 65)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(196, 10)
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'SimpleLabelItem1
		'
		Me.SimpleLabelItem1.AllowHotTrack = False
		Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
		Me.SimpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.SimpleLabelItem1.CustomizationFormText = "Qty"
		Me.SimpleLabelItem1.Location = New System.Drawing.Point(496, 0)
		Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
		Me.SimpleLabelItem1.Size = New System.Drawing.Size(78, 17)
		Me.SimpleLabelItem1.Text = "Qty"
		Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtMaterial
		Me.LayoutControlItem6.CustomizationFormText = "Material"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 41)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(196, 24)
		Me.LayoutControlItem6.Text = "Material"
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.txtMQty
		Me.LayoutControlItem8.CustomizationFormText = "Qty"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(496, 41)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(78, 24)
		Me.LayoutControlItem8.Text = "Qty"
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem8.TextToControlDistance = 0
		Me.LayoutControlItem8.TextVisible = False
		'
		'EmptySpaceItem3
		'
		Me.EmptySpaceItem3.AllowHotTrack = False
		Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Location = New System.Drawing.Point(196, 65)
		Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Size = New System.Drawing.Size(378, 10)
		Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
		Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtLotPerBatang
		Me.LayoutControlItem2.CustomizationFormText = "Kurs"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 75)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(248, 24)
		Me.LayoutControlItem2.Text = "Lot Per Batang"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(74, 13)
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtFGNama
		Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(196, 17)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(150, 24)
		Me.LayoutControlItem9.Text = "LayoutControlItem9"
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem9.TextToControlDistance = 0
		Me.LayoutControlItem9.TextVisible = False
		'
		'LayoutControlItem12
		'
		Me.LayoutControlItem12.Control = Me.txtMNama
		Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
		Me.LayoutControlItem12.Location = New System.Drawing.Point(196, 41)
		Me.LayoutControlItem12.Name = "LayoutControlItem12"
		Me.LayoutControlItem12.Size = New System.Drawing.Size(150, 24)
		Me.LayoutControlItem12.Text = "LayoutControlItem12"
		Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem12.TextToControlDistance = 0
		Me.LayoutControlItem12.TextVisible = False
		'
		'LayoutControlItem13
		'
		Me.LayoutControlItem13.Control = Me.txtMSize
		Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
		Me.LayoutControlItem13.Location = New System.Drawing.Point(346, 41)
		Me.LayoutControlItem13.Name = "LayoutControlItem13"
		Me.LayoutControlItem13.Size = New System.Drawing.Size(150, 24)
		Me.LayoutControlItem13.Text = "LayoutControlItem13"
		Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem13.TextToControlDistance = 0
		Me.LayoutControlItem13.TextVisible = False
		'
		'SimpleLabelItem2
		'
		Me.SimpleLabelItem2.AllowHotTrack = False
		Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseTextOptions = True
		Me.SimpleLabelItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.SimpleLabelItem2.CustomizationFormText = "Nama"
		Me.SimpleLabelItem2.Location = New System.Drawing.Point(196, 0)
		Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
		Me.SimpleLabelItem2.Size = New System.Drawing.Size(150, 17)
		Me.SimpleLabelItem2.Text = "Nama"
		Me.SimpleLabelItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(50, 13)
		'
		'SimpleLabelItem3
		'
		Me.SimpleLabelItem3.AllowHotTrack = False
		Me.SimpleLabelItem3.AppearanceItemCaption.Options.UseTextOptions = True
		Me.SimpleLabelItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.SimpleLabelItem3.CustomizationFormText = "Size"
		Me.SimpleLabelItem3.Location = New System.Drawing.Point(346, 0)
		Me.SimpleLabelItem3.Name = "SimpleLabelItem3"
		Me.SimpleLabelItem3.Size = New System.Drawing.Size(150, 17)
		Me.SimpleLabelItem3.Text = "Size"
		Me.SimpleLabelItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.SimpleLabelItem3.TextSize = New System.Drawing.Size(60, 13)
		'
		'LayoutControlItem11
		'
		Me.LayoutControlItem11.Control = Me.txtFGSize
		Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
		Me.LayoutControlItem11.Location = New System.Drawing.Point(346, 17)
		Me.LayoutControlItem11.Name = "LayoutControlItem11"
		Me.LayoutControlItem11.Size = New System.Drawing.Size(150, 24)
		Me.LayoutControlItem11.Text = "LayoutControlItem11"
		Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem11.TextToControlDistance = 0
		Me.LayoutControlItem11.TextVisible = False
		'
		'LayoutControlItem14
		'
		Me.LayoutControlItem14.Control = Me.txtStokAwal
		Me.LayoutControlItem14.CustomizationFormText = "Stok Awal"
		Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 99)
		Me.LayoutControlItem14.Name = "LayoutControlItem14"
		Me.LayoutControlItem14.Size = New System.Drawing.Size(248, 24)
		Me.LayoutControlItem14.Text = "Stok Awal"
		Me.LayoutControlItem14.TextSize = New System.Drawing.Size(74, 13)
		'
		'EmptySpaceItem4
		'
		Me.EmptySpaceItem4.AllowHotTrack = False
		Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Location = New System.Drawing.Point(248, 75)
		Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Size = New System.Drawing.Size(326, 24)
		Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
		Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem5
		'
		Me.EmptySpaceItem5.AllowHotTrack = False
		Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
		Me.EmptySpaceItem5.Location = New System.Drawing.Point(248, 99)
		Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
		Me.EmptySpaceItem5.Size = New System.Drawing.Size(326, 24)
		Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
		Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
		'
		'UI_FusohForecastDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(795, 524)
		Me.Controls.Add(Me.lytMasterTermin)
		Me.Name = "UI_FusohForecastDialog"
		Me.Text = "Reset Kurs :"
		Me.Controls.SetChildIndex(Me.lytMasterTermin, 0)
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytMasterTermin.ResumeLayout(False)
		CType(Me.txtStokAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFGSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFGQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSpinRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtLotPerBatang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFGNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFinishGood.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.layGroup, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lytMasterTermin As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtLotPerBatang As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents colBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtMQty As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtFGQty As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents layGroup As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
	Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtMSize As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtMNama As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtFGSize As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtFGNama As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
	Friend WithEvents SimpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
	Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtStokAwal As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtCustomer As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colCustKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCustNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtFinishGood As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents txtMaterial As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colFgKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFgNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFgOD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFgT As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFgL As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMOD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMT As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colML As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents colSpinRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
	Friend WithEvents colBulan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colStokAwal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colIncomingBatang As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colIncomingPcs As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colDelivery As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colStokAkhir As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents colStokRatio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
