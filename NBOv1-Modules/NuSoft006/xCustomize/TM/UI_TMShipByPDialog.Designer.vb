<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TMShipByPDialog
	Inherits Core.Win.Forms.InputMDI

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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TMShipByPDialog))
		Me.xxHapus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
		Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
		Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
		Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
		Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
		Me.navInfo = New DevExpress.XtraNavBar.NavBarGroup()
		Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
		Me.txtDebitLimit = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
		Me.txtCreditLimit = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
		Me.txtSaldoAP = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
		Me.txtSaldoAR = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
		Me.txtPhoneNumber = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
		Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
		Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
		Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
		Me.xGHistory = New DevExpress.XtraGrid.GridControl()
		Me.xGHistoryView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.navHistory = New DevExpress.XtraNavBar.NavBarGroup()
		Me.navCatatan = New DevExpress.XtraNavBar.NavBarGroup()
		Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
		Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
		Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
		Me.txtCustom4 = New DevExpress.XtraEditors.TextEdit()
		Me.txtCustom5 = New DevExpress.XtraEditors.TextEdit()
		Me.txtCustom3 = New DevExpress.XtraEditors.TextEdit()
		Me.txtCustom2 = New DevExpress.XtraEditors.TextEdit()
		Me.txtCustom1 = New DevExpress.XtraEditors.TextEdit()
		Me.txtDriver = New DevExpress.XtraEditors.TextEdit()
		Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtShipmentUOM = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtShipmentSequence = New DevExpress.XtraEditors.TextEdit()
		Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
		Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
		Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colOrder = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
		Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colOrderCode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colProductCodex = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomerx = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDestination = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
		Me.txtDescription = New DevExpress.XtraEditors.MemoEdit()
		Me.txtCarrierCompany = New DevExpress.XtraEditors.TextEdit()
		Me.txtShipmentStatus = New DevExpress.XtraEditors.TextEdit()
		Me.txtPriority = New DevExpress.XtraEditors.CheckEdit()
		Me.txtVehicle = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtShipmentCreatedFrom = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem17 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
		Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
		Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
		Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
		Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
		Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xxHapus, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.hideContainerRight.SuspendLayout()
		Me.DockPanel1.SuspendLayout()
		Me.DockPanel1_Container.SuspendLayout()
		CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.NavBarControl1.SuspendLayout()
		Me.NavBarGroupControlContainer3.SuspendLayout()
		Me.NavBarGroupControlContainer1.SuspendLayout()
		CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.NavBarGroupControlContainer2.SuspendLayout()
		CType(Me.xGHistory, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGHistoryView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.DockPanel2.SuspendLayout()
		Me.DockPanel2_Container.SuspendLayout()
		CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytTransaksi.SuspendLayout()
		CType(Me.txtCustom4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustom5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustom3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustom2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustom1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDriver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipmentUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipmentSequence.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCarrierCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipmentStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVehicle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipmentCreatedFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.BarButtonItem1, Me.btnRefresh, Me.BarButtonItem2})
		Me.barMan.MaxItemId = 11
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'xxHapus
		'
		Me.xxHapus.AutoHeight = False
		Me.xxHapus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.xxHapus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
		Me.xxHapus.DisplayMember = "Kode"
		Me.xxHapus.Name = "xxHapus"
		Me.xxHapus.NullText = "<Pilih Divisi>"
		Me.xxHapus.ShowHeader = False
		Me.xxHapus.ValueMember = "This"
		'
		'DockManager1
		'
		Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
		Me.DockManager1.Form = Me
		Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
		Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
		'
		'hideContainerRight
		'
		Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
		Me.hideContainerRight.Controls.Add(Me.DockPanel1)
		Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.hideContainerRight.Location = New System.Drawing.Point(1115, 0)
		Me.hideContainerRight.Name = "hideContainerRight"
		Me.hideContainerRight.Size = New System.Drawing.Size(19, 441)
		'
		'DockPanel1
		'
		Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
		Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
		Me.DockPanel1.ID = New System.Guid("6988d464-fb4c-47a6-9314-7c4a87e69e68")
		Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
		Me.DockPanel1.Name = "DockPanel1"
		Me.DockPanel1.OriginalSize = New System.Drawing.Size(250, 200)
		Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
		Me.DockPanel1.SavedIndex = 0
		Me.DockPanel1.Size = New System.Drawing.Size(250, 441)
		Me.DockPanel1.Text = "Panel Informasi"
		Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
		'
		'DockPanel1_Container
		'
		Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
		Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
		Me.DockPanel1_Container.Name = "DockPanel1_Container"
		Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 414)
		Me.DockPanel1_Container.TabIndex = 0
		'
		'NavBarControl1
		'
		Me.NavBarControl1.ActiveGroup = Me.navInfo
		Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
		Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer2)
		Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer3)
		Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navInfo, Me.navHistory, Me.navCatatan})
		Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
		Me.NavBarControl1.Name = "NavBarControl1"
		Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 242
		Me.NavBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
		Me.NavBarControl1.Size = New System.Drawing.Size(242, 414)
		Me.NavBarControl1.TabIndex = 0
		Me.NavBarControl1.Text = "NavBarControl1"
		'
		'navInfo
		'
		Me.navInfo.Caption = "Informasi Kontak"
		Me.navInfo.ControlContainer = Me.NavBarGroupControlContainer3
		Me.navInfo.Expanded = True
		Me.navInfo.GroupClientHeight = 110
		Me.navInfo.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
		Me.navInfo.Name = "navInfo"
		'
		'NavBarGroupControlContainer3
		'
		Me.NavBarGroupControlContainer3.Controls.Add(Me.txtDebitLimit)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl21)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.txtCreditLimit)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl18)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.txtSaldoAP)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl19)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.txtSaldoAR)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl17)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.txtPhoneNumber)
		Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl16)
		Me.NavBarGroupControlContainer3.Name = "NavBarGroupControlContainer3"
		Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(234, 106)
		Me.NavBarGroupControlContainer3.TabIndex = 2
		'
		'txtDebitLimit
		'
		Me.txtDebitLimit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDebitLimit.Location = New System.Drawing.Point(97, 85)
		Me.txtDebitLimit.Name = "txtDebitLimit"
		Me.txtDebitLimit.Size = New System.Drawing.Size(7, 13)
		Me.txtDebitLimit.TabIndex = 4
		Me.txtDebitLimit.Text = "0"
		'
		'LabelControl21
		'
		Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelControl21.Location = New System.Drawing.Point(11, 85)
		Me.LabelControl21.Name = "LabelControl21"
		Me.LabelControl21.Size = New System.Drawing.Size(61, 13)
		Me.LabelControl21.TabIndex = 4
		Me.LabelControl21.Text = "Debit Limit"
		'
		'txtCreditLimit
		'
		Me.txtCreditLimit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCreditLimit.Location = New System.Drawing.Point(97, 66)
		Me.txtCreditLimit.Name = "txtCreditLimit"
		Me.txtCreditLimit.Size = New System.Drawing.Size(7, 13)
		Me.txtCreditLimit.TabIndex = 3
		Me.txtCreditLimit.Text = "0"
		'
		'LabelControl18
		'
		Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelControl18.Location = New System.Drawing.Point(11, 66)
		Me.LabelControl18.Name = "LabelControl18"
		Me.LabelControl18.Size = New System.Drawing.Size(65, 13)
		Me.LabelControl18.TabIndex = 3
		Me.LabelControl18.Text = "Credit Limit"
		'
		'txtSaldoAP
		'
		Me.txtSaldoAP.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaldoAP.Location = New System.Drawing.Point(97, 46)
		Me.txtSaldoAP.Name = "txtSaldoAP"
		Me.txtSaldoAP.Size = New System.Drawing.Size(7, 13)
		Me.txtSaldoAP.TabIndex = 2
		Me.txtSaldoAP.Text = "0"
		'
		'LabelControl19
		'
		Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelControl19.Location = New System.Drawing.Point(11, 47)
		Me.LabelControl19.Name = "LabelControl19"
		Me.LabelControl19.Size = New System.Drawing.Size(49, 13)
		Me.LabelControl19.TabIndex = 2
		Me.LabelControl19.Text = "Saldo AP"
		'
		'txtSaldoAR
		'
		Me.txtSaldoAR.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaldoAR.Location = New System.Drawing.Point(97, 28)
		Me.txtSaldoAR.Name = "txtSaldoAR"
		Me.txtSaldoAR.Size = New System.Drawing.Size(7, 13)
		Me.txtSaldoAR.TabIndex = 1
		Me.txtSaldoAR.Text = "0"
		'
		'LabelControl17
		'
		Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelControl17.Location = New System.Drawing.Point(11, 28)
		Me.LabelControl17.Name = "LabelControl17"
		Me.LabelControl17.Size = New System.Drawing.Size(51, 13)
		Me.LabelControl17.TabIndex = 1
		Me.LabelControl17.Text = "Saldo AR"
		'
		'txtPhoneNumber
		'
		Me.txtPhoneNumber.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPhoneNumber.Location = New System.Drawing.Point(99, 9)
		Me.txtPhoneNumber.Name = "txtPhoneNumber"
		Me.txtPhoneNumber.Size = New System.Drawing.Size(5, 13)
		Me.txtPhoneNumber.TabIndex = 0
		Me.txtPhoneNumber.Text = "-"
		'
		'LabelControl16
		'
		Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelControl16.Location = New System.Drawing.Point(11, 9)
		Me.LabelControl16.Name = "LabelControl16"
		Me.LabelControl16.Size = New System.Drawing.Size(55, 13)
		Me.LabelControl16.TabIndex = 0
		Me.LabelControl16.Text = "Phone No."
		'
		'NavBarGroupControlContainer1
		'
		Me.NavBarGroupControlContainer1.Controls.Add(Me.MemoEdit1)
		Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
		Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(234, 96)
		Me.NavBarGroupControlContainer1.TabIndex = 0
		'
		'MemoEdit1
		'
		Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
		Me.MemoEdit1.MenuManager = Me.barMan
		Me.MemoEdit1.Name = "MemoEdit1"
		Me.MemoEdit1.Size = New System.Drawing.Size(234, 96)
		Me.MemoEdit1.TabIndex = 0
		'
		'NavBarGroupControlContainer2
		'
		Me.NavBarGroupControlContainer2.Controls.Add(Me.xGHistory)
		Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
		Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(234, 196)
		Me.NavBarGroupControlContainer2.TabIndex = 1
		'
		'xGHistory
		'
		Me.xGHistory.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xGHistory.Location = New System.Drawing.Point(0, 0)
		Me.xGHistory.MainView = Me.xGHistoryView
		Me.xGHistory.MenuManager = Me.barMan
		Me.xGHistory.Name = "xGHistory"
		Me.xGHistory.Size = New System.Drawing.Size(234, 196)
		Me.xGHistory.TabIndex = 0
		Me.xGHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGHistoryView})
		'
		'xGHistoryView
		'
		Me.xGHistoryView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colKode, Me.colTanggal, Me.colKeterangan})
		Me.xGHistoryView.GridControl = Me.xGHistory
		Me.xGHistoryView.Name = "xGHistoryView"
		Me.xGHistoryView.OptionsBehavior.Editable = False
		Me.xGHistoryView.OptionsBehavior.ReadOnly = True
		Me.xGHistoryView.OptionsDetail.EnableMasterViewMode = False
		Me.xGHistoryView.OptionsView.ColumnAutoWidth = False
		Me.xGHistoryView.OptionsView.ShowGroupPanel = False
		'
		'colID
		'
		Me.colID.Caption = "ID"
		Me.colID.Name = "colID"
		'
		'colKode
		'
		Me.colKode.Caption = "No. Transaksi"
		Me.colKode.FieldName = "Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 0
		Me.colKode.Width = 106
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.DisplayFormat.FormatString = "dd/MM/yy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		Me.colTanggal.Width = 81
		'
		'colKeterangan
		'
		Me.colKeterangan.Caption = "Keterangan"
		Me.colKeterangan.FieldName = "Catatan"
		Me.colKeterangan.Name = "colKeterangan"
		Me.colKeterangan.Visible = True
		Me.colKeterangan.VisibleIndex = 2
		Me.colKeterangan.Width = 361
		'
		'navHistory
		'
		Me.navHistory.Caption = "History Transaksi"
		Me.navHistory.ControlContainer = Me.NavBarGroupControlContainer2
		Me.navHistory.Expanded = True
		Me.navHistory.GroupClientHeight = 200
		Me.navHistory.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
		Me.navHistory.Name = "navHistory"
		'
		'navCatatan
		'
		Me.navCatatan.Caption = "Catatan Kontak"
		Me.navCatatan.ControlContainer = Me.NavBarGroupControlContainer1
		Me.navCatatan.Expanded = True
		Me.navCatatan.GroupClientHeight = 100
		Me.navCatatan.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
		Me.navCatatan.Name = "navCatatan"
		'
		'DockPanel2
		'
		Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
		Me.DockPanel2.DockedAsTabbedDocument = True
		Me.DockPanel2.ID = New System.Guid("b7129287-a5f5-4623-9bff-ab6c88adf43f")
		Me.DockPanel2.Name = "DockPanel2"
		Me.DockPanel2.OriginalSize = New System.Drawing.Size(1128, 435)
		Me.DockPanel2.Text = "DockPanel2"
		'
		'DockPanel2_Container
		'
		Me.DockPanel2_Container.Controls.Add(Me.lytTransaksi)
		Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
		Me.DockPanel2_Container.Name = "DockPanel2_Container"
		Me.DockPanel2_Container.Size = New System.Drawing.Size(1128, 435)
		Me.DockPanel2_Container.TabIndex = 0
		'
		'lytTransaksi
		'
		Me.lytTransaksi.Controls.Add(Me.txtCustom4)
		Me.lytTransaksi.Controls.Add(Me.txtCustom5)
		Me.lytTransaksi.Controls.Add(Me.txtCustom3)
		Me.lytTransaksi.Controls.Add(Me.txtCustom2)
		Me.lytTransaksi.Controls.Add(Me.txtCustom1)
		Me.lytTransaksi.Controls.Add(Me.txtDriver)
		Me.lytTransaksi.Controls.Add(Me.txtStatus)
		Me.lytTransaksi.Controls.Add(Me.txtShipmentUOM)
		Me.lytTransaksi.Controls.Add(Me.txtShipmentSequence)
		Me.lytTransaksi.Controls.Add(Me.txtRegional)
		Me.lytTransaksi.Controls.Add(Me.txtTanggal)
		Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
		Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
		Me.lytTransaksi.Controls.Add(Me.xGrid)
		Me.lytTransaksi.Controls.Add(Me.txtRemarks)
		Me.lytTransaksi.Controls.Add(Me.txtDescription)
		Me.lytTransaksi.Controls.Add(Me.txtCarrierCompany)
		Me.lytTransaksi.Controls.Add(Me.txtShipmentStatus)
		Me.lytTransaksi.Controls.Add(Me.txtPriority)
		Me.lytTransaksi.Controls.Add(Me.txtVehicle)
		Me.lytTransaksi.Controls.Add(Me.txtShipmentCreatedFrom)
		Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem27, Me.LayoutControlItem26})
		Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksi.Name = "lytTransaksi"
		Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 225, 250, 350)
		Me.lytTransaksi.Root = Me.LayoutControlGroup1
		Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
		Me.lytTransaksi.TabIndex = 0
		Me.lytTransaksi.Text = "LayoutControl1"
		'
		'txtCustom4
		'
		Me.txtCustom4.Location = New System.Drawing.Point(400, 316)
		Me.txtCustom4.MenuManager = Me.barMan
		Me.txtCustom4.Name = "txtCustom4"
		Me.txtCustom4.Size = New System.Drawing.Size(243, 20)
		Me.txtCustom4.StyleController = Me.lytTransaksi
		Me.txtCustom4.TabIndex = 29
		'
		'txtCustom5
		'
		Me.txtCustom5.Location = New System.Drawing.Point(400, 316)
		Me.txtCustom5.MenuManager = Me.barMan
		Me.txtCustom5.Name = "txtCustom5"
		Me.txtCustom5.Size = New System.Drawing.Size(243, 20)
		Me.txtCustom5.StyleController = Me.lytTransaksi
		Me.txtCustom5.TabIndex = 28
		'
		'txtCustom3
		'
		Me.txtCustom3.Location = New System.Drawing.Point(400, 316)
		Me.txtCustom3.MenuManager = Me.barMan
		Me.txtCustom3.Name = "txtCustom3"
		Me.txtCustom3.Size = New System.Drawing.Size(243, 20)
		Me.txtCustom3.StyleController = Me.lytTransaksi
		Me.txtCustom3.TabIndex = 27
		'
		'txtCustom2
		'
		Me.txtCustom2.Location = New System.Drawing.Point(400, 316)
		Me.txtCustom2.MenuManager = Me.barMan
		Me.txtCustom2.Name = "txtCustom2"
		Me.txtCustom2.Size = New System.Drawing.Size(243, 20)
		Me.txtCustom2.StyleController = Me.lytTransaksi
		Me.txtCustom2.TabIndex = 26
		'
		'txtCustom1
		'
		Me.txtCustom1.Location = New System.Drawing.Point(400, 316)
		Me.txtCustom1.MenuManager = Me.barMan
		Me.txtCustom1.Name = "txtCustom1"
		Me.txtCustom1.Size = New System.Drawing.Size(243, 20)
		Me.txtCustom1.StyleController = Me.lytTransaksi
		Me.txtCustom1.TabIndex = 25
		'
		'txtDriver
		'
		Me.txtDriver.Location = New System.Drawing.Point(157, 154)
		Me.txtDriver.MenuManager = Me.barMan
		Me.txtDriver.Name = "txtDriver"
		Me.txtDriver.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtDriver.Size = New System.Drawing.Size(155, 20)
		Me.txtDriver.StyleController = Me.lytTransaksi
		Me.txtDriver.TabIndex = 13
		'
		'txtStatus
		'
		Me.txtStatus.Location = New System.Drawing.Point(928, 61)
		Me.txtStatus.MenuManager = Me.barMan
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
		Me.txtStatus.Properties.DisplayMember = "Value"
		Me.txtStatus.Properties.NullText = "<Status>"
		Me.txtStatus.Properties.ValueMember = "Key"
		Me.txtStatus.Size = New System.Drawing.Size(152, 20)
		Me.txtStatus.StyleController = Me.lytTransaksi
		Me.txtStatus.TabIndex = 6
		'
		'txtShipmentUOM
		'
		Me.txtShipmentUOM.Location = New System.Drawing.Point(157, 106)
		Me.txtShipmentUOM.MenuManager = Me.barMan
		Me.txtShipmentUOM.Name = "txtShipmentUOM"
		Me.txtShipmentUOM.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtShipmentUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtShipmentUOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 90, "Kode")})
		Me.txtShipmentUOM.Properties.DisplayMember = "Kode"
		Me.txtShipmentUOM.Properties.NullText = "<Shipment UOM>"
		Me.txtShipmentUOM.Properties.PopupWidth = 300
		Me.txtShipmentUOM.Properties.ShowHeader = False
		Me.txtShipmentUOM.Properties.ValueMember = "This"
		Me.txtShipmentUOM.Size = New System.Drawing.Size(155, 20)
		Me.txtShipmentUOM.StyleController = Me.lytTransaksi
		Me.txtShipmentUOM.TabIndex = 7
		'
		'txtShipmentSequence
		'
		Me.txtShipmentSequence.Location = New System.Drawing.Point(426, 130)
		Me.txtShipmentSequence.MenuManager = Me.barMan
		Me.txtShipmentSequence.Name = "txtShipmentSequence"
		Me.txtShipmentSequence.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtShipmentSequence.Size = New System.Drawing.Size(148, 20)
		Me.txtShipmentSequence.StyleController = Me.lytTransaksi
		Me.txtShipmentSequence.TabIndex = 12
		'
		'txtRegional
		'
		Me.txtRegional.Location = New System.Drawing.Point(674, 61)
		Me.txtRegional.MenuManager = Me.barMan
		Me.txtRegional.Name = "txtRegional"
		Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
		Me.txtRegional.Properties.DisplayMember = "Nama"
		Me.txtRegional.Properties.NullText = "<Shareholders>"
		Me.txtRegional.Properties.PopupWidth = 200
		Me.txtRegional.Properties.ValueMember = "This"
		Me.txtRegional.Size = New System.Drawing.Size(160, 20)
		Me.txtRegional.StyleController = Me.lytTransaksi
		Me.txtRegional.TabIndex = 5
		'
		'txtTanggal
		'
		Me.txtTanggal.EditValue = Nothing
		Me.txtTanggal.Location = New System.Drawing.Point(674, 37)
		Me.txtTanggal.MenuManager = Me.barMan
		Me.txtTanggal.Name = "txtTanggal"
		Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal.Size = New System.Drawing.Size(160, 20)
		Me.txtTanggal.StyleController = Me.lytTransaksi
		Me.txtTanggal.TabIndex = 1
		'
		'btnRefreshNomor
		'
		Me.btnRefreshNomor.AutoWidthInLayoutControl = True
		Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
		Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
		Me.btnRefreshNomor.Location = New System.Drawing.Point(1084, 37)
		Me.btnRefreshNomor.Name = "btnRefreshNomor"
		Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
		Me.btnRefreshNomor.StyleController = Me.lytTransaksi
		Me.btnRefreshNomor.TabIndex = 3
		'
		'txtNoTransaksi
		'
		Me.txtNoTransaksi.Location = New System.Drawing.Point(928, 37)
		Me.txtNoTransaksi.MenuManager = Me.barMan
		Me.txtNoTransaksi.Name = "txtNoTransaksi"
		Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoTransaksi.Size = New System.Drawing.Size(152, 20)
		Me.txtNoTransaksi.StyleController = Me.lytTransaksi
		Me.txtNoTransaksi.TabIndex = 2
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 179)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.MenuManager = Me.barMan
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colKodeBarangRepo})
		Me.xGrid.Size = New System.Drawing.Size(1104, 220)
		Me.xGrid.TabIndex = 15
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrder, Me.colProductCode, Me.colCustomer, Me.colDestination, Me.colQty})
		Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(750, 426, 210, 172)
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsLayout.StoreAllOptions = True
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colOrder
		'
		Me.colOrder.Caption = "Order Code"
		Me.colOrder.ColumnEdit = Me.colKodeBarangRepo
		Me.colOrder.FieldName = "PenawaranDetail!"
		Me.colOrder.Name = "colOrder"
		Me.colOrder.Visible = True
		Me.colOrder.VisibleIndex = 0
		Me.colOrder.Width = 175
		'
		'colKodeBarangRepo
		'
		Me.colKodeBarangRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colKodeBarangRepo.DisplayMember = "Kode"
		Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
		Me.colKodeBarangRepo.NullText = "<Order Code>"
		Me.colKodeBarangRepo.ShowClearButton = False
		Me.colKodeBarangRepo.ShowFooter = False
		Me.colKodeBarangRepo.ValueMember = "This"
		Me.colKodeBarangRepo.View = Me.RepositoryItemSearchLookUpEdit1View
		'
		'RepositoryItemSearchLookUpEdit1View
		'
		Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderCode, Me.colProductCodex, Me.colCustomerx})
		Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
		Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.FindDelay = 500
		Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.SearchInPreview = True
		Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		Me.RepositoryItemSearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOrderCode, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'colOrderCode
		'
		Me.colOrderCode.Caption = "Order Code"
		Me.colOrderCode.FieldName = "Main.Kode"
		Me.colOrderCode.Name = "colOrderCode"
		Me.colOrderCode.Visible = True
		Me.colOrderCode.VisibleIndex = 0
		Me.colOrderCode.Width = 144
		'
		'colProductCodex
		'
		Me.colProductCodex.Caption = "Product Code"
		Me.colProductCodex.FieldName = "Barang.Kode"
		Me.colProductCodex.Name = "colProductCodex"
		Me.colProductCodex.Visible = True
		Me.colProductCodex.VisibleIndex = 1
		Me.colProductCodex.Width = 168
		'
		'colCustomerx
		'
		Me.colCustomerx.Caption = "Customer"
		Me.colCustomerx.FieldName = "Main.Pelanggan.Nama"
		Me.colCustomerx.Name = "colCustomerx"
		Me.colCustomerx.Visible = True
		Me.colCustomerx.VisibleIndex = 2
		Me.colCustomerx.Width = 175
		'
		'colProductCode
		'
		Me.colProductCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.colProductCode.AppearanceCell.Options.UseBackColor = True
		Me.colProductCode.Caption = "Product Code"
		Me.colProductCode.FieldName = "PenawaranDetail.Barang.Kode"
		Me.colProductCode.Name = "colProductCode"
		Me.colProductCode.OptionsColumn.AllowEdit = False
		Me.colProductCode.OptionsColumn.ReadOnly = True
		Me.colProductCode.Visible = True
		Me.colProductCode.VisibleIndex = 1
		Me.colProductCode.Width = 250
		'
		'colCustomer
		'
		Me.colCustomer.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.colCustomer.AppearanceCell.Options.UseBackColor = True
		Me.colCustomer.Caption = "Customer"
		Me.colCustomer.FieldName = "PenawaranDetail.Main.Pelanggan.Nama"
		Me.colCustomer.Name = "colCustomer"
		Me.colCustomer.OptionsColumn.AllowEdit = False
		Me.colCustomer.OptionsColumn.ReadOnly = True
		Me.colCustomer.Visible = True
		Me.colCustomer.VisibleIndex = 2
		Me.colCustomer.Width = 275
		'
		'colDestination
		'
		Me.colDestination.AppearanceCell.Options.UseTextOptions = True
		Me.colDestination.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colDestination.AppearanceHeader.Options.UseTextOptions = True
		Me.colDestination.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colDestination.Caption = "Destination"
		Me.colDestination.FieldName = "Destination"
		Me.colDestination.Name = "colDestination"
		Me.colDestination.Visible = True
		Me.colDestination.VisibleIndex = 3
		Me.colDestination.Width = 250
		'
		'colQty
		'
		Me.colQty.AppearanceCell.Options.UseTextOptions = True
		Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQty.AppearanceHeader.Options.UseTextOptions = True
		Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQty.Caption = "Qty"
		Me.colQty.DisplayFormat.FormatString = "n0"
		Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 4
		Me.colQty.Width = 136
		'
		'txtRemarks
		'
		Me.txtRemarks.Location = New System.Drawing.Point(929, 106)
		Me.txtRemarks.MenuManager = Me.barMan
		Me.txtRemarks.Name = "txtRemarks"
		Me.txtRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRemarks.Size = New System.Drawing.Size(187, 69)
		Me.txtRemarks.StyleController = Me.lytTransaksi
		Me.txtRemarks.TabIndex = 10
		'
		'txtDescription
		'
		Me.txtDescription.Location = New System.Drawing.Point(678, 106)
		Me.txtDescription.MenuManager = Me.barMan
		Me.txtDescription.Name = "txtDescription"
		Me.txtDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtDescription.Properties.MaxLength = 255
		Me.txtDescription.Size = New System.Drawing.Size(157, 69)
		Me.txtDescription.StyleController = Me.lytTransaksi
		Me.txtDescription.TabIndex = 9
		'
		'txtCarrierCompany
		'
		Me.txtCarrierCompany.Enabled = False
		Me.txtCarrierCompany.Location = New System.Drawing.Point(158, 61)
		Me.txtCarrierCompany.MenuManager = Me.barMan
		Me.txtCarrierCompany.Name = "txtCarrierCompany"
		Me.txtCarrierCompany.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCarrierCompany.Size = New System.Drawing.Size(152, 20)
		Me.txtCarrierCompany.StyleController = Me.lytTransaksi
		Me.txtCarrierCompany.TabIndex = 4
		'
		'txtShipmentStatus
		'
		Me.txtShipmentStatus.EditValue = ""
		Me.txtShipmentStatus.Location = New System.Drawing.Point(426, 106)
		Me.txtShipmentStatus.MenuManager = Me.barMan
		Me.txtShipmentStatus.Name = "txtShipmentStatus"
		Me.txtShipmentStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtShipmentStatus.Size = New System.Drawing.Size(148, 20)
		Me.txtShipmentStatus.StyleController = Me.lytTransaksi
		Me.txtShipmentStatus.TabIndex = 8
		'
		'txtPriority
		'
		Me.txtPriority.EditValue = Nothing
		Me.txtPriority.Location = New System.Drawing.Point(321, 154)
		Me.txtPriority.MenuManager = Me.barMan
		Me.txtPriority.Name = "txtPriority"
		Me.txtPriority.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtPriority.Properties.Caption = "Is Shipment Prority ?"
		Me.txtPriority.Properties.NullText = "<Uang>"
		Me.txtPriority.Size = New System.Drawing.Size(253, 21)
		Me.txtPriority.StyleController = Me.lytTransaksi
		Me.txtPriority.TabIndex = 14
		'
		'txtVehicle
		'
		Me.txtVehicle.Location = New System.Drawing.Point(158, 37)
		Me.txtVehicle.MenuManager = Me.barMan
		Me.txtVehicle.Name = "txtVehicle"
		Me.txtVehicle.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtVehicle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtVehicle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtVehicle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", 30, "Vehicle"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", 90, "Carrier Company")})
		Me.txtVehicle.Properties.DisplayMember = "Key"
		Me.txtVehicle.Properties.NullText = "<Vehicle>"
		Me.txtVehicle.Properties.PopupWidth = 330
		Me.txtVehicle.Properties.ShowFooter = False
		Me.txtVehicle.Properties.ValueMember = "Key"
		Me.txtVehicle.Size = New System.Drawing.Size(152, 20)
		Me.txtVehicle.StyleController = Me.lytTransaksi
		Me.txtVehicle.TabIndex = 0
		'
		'txtShipmentCreatedFrom
		'
		Me.txtShipmentCreatedFrom.Location = New System.Drawing.Point(157, 130)
		Me.txtShipmentCreatedFrom.MenuManager = Me.barMan
		Me.txtShipmentCreatedFrom.Name = "txtShipmentCreatedFrom"
		Me.txtShipmentCreatedFrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtShipmentCreatedFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtShipmentCreatedFrom.Properties.Items.AddRange(New Object() {"ORDER"})
		Me.txtShipmentCreatedFrom.Properties.PopupSizeable = True
		Me.txtShipmentCreatedFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.txtShipmentCreatedFrom.Size = New System.Drawing.Size(155, 20)
		Me.txtShipmentCreatedFrom.StyleController = Me.lytTransaksi
		Me.txtShipmentCreatedFrom.TabIndex = 11
		'
		'LayoutControlItem23
		'
		Me.LayoutControlItem23.Control = Me.txtCustom1
		Me.LayoutControlItem23.CustomizationFormText = "Custom1"
		Me.LayoutControlItem23.Location = New System.Drawing.Point(307, 304)
		Me.LayoutControlItem23.Name = "LayoutControlItem23"
		Me.LayoutControlItem23.Size = New System.Drawing.Size(328, 24)
		Me.LayoutControlItem23.Text = "Custom1"
		Me.LayoutControlItem23.TextSize = New System.Drawing.Size(50, 20)
		Me.LayoutControlItem23.TextToControlDistance = 5
		'
		'LayoutControlItem24
		'
		Me.LayoutControlItem24.Control = Me.txtCustom2
		Me.LayoutControlItem24.CustomizationFormText = "Custom2"
		Me.LayoutControlItem24.Location = New System.Drawing.Point(307, 304)
		Me.LayoutControlItem24.Name = "LayoutControlItem24"
		Me.LayoutControlItem24.Size = New System.Drawing.Size(328, 24)
		Me.LayoutControlItem24.Text = "Custom2"
		Me.LayoutControlItem24.TextSize = New System.Drawing.Size(50, 20)
		Me.LayoutControlItem24.TextToControlDistance = 5
		'
		'LayoutControlItem25
		'
		Me.LayoutControlItem25.Control = Me.txtCustom3
		Me.LayoutControlItem25.CustomizationFormText = "Custom3"
		Me.LayoutControlItem25.Location = New System.Drawing.Point(307, 304)
		Me.LayoutControlItem25.Name = "LayoutControlItem25"
		Me.LayoutControlItem25.Size = New System.Drawing.Size(328, 24)
		Me.LayoutControlItem25.Text = "Custom3"
		Me.LayoutControlItem25.TextSize = New System.Drawing.Size(50, 20)
		Me.LayoutControlItem25.TextToControlDistance = 5
		'
		'LayoutControlItem27
		'
		Me.LayoutControlItem27.Control = Me.txtCustom4
		Me.LayoutControlItem27.CustomizationFormText = "Custom4"
		Me.LayoutControlItem27.Location = New System.Drawing.Point(307, 304)
		Me.LayoutControlItem27.Name = "LayoutControlItem27"
		Me.LayoutControlItem27.Size = New System.Drawing.Size(328, 24)
		Me.LayoutControlItem27.Text = "Custom4"
		Me.LayoutControlItem27.TextSize = New System.Drawing.Size(50, 20)
		Me.LayoutControlItem27.TextToControlDistance = 5
		'
		'LayoutControlItem26
		'
		Me.LayoutControlItem26.Control = Me.txtCustom5
		Me.LayoutControlItem26.CustomizationFormText = "Custom5"
		Me.LayoutControlItem26.Location = New System.Drawing.Point(307, 304)
		Me.LayoutControlItem26.Name = "LayoutControlItem26"
		Me.LayoutControlItem26.Size = New System.Drawing.Size(328, 120)
		Me.LayoutControlItem26.Text = "Custom5"
		Me.LayoutControlItem26.TextSize = New System.Drawing.Size(50, 20)
		Me.LayoutControlItem26.TextToControlDistance = 5
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.EmptySpaceItem17, Me.LayoutControlGroup3, Me.LayoutControlItem9, Me.LayoutControlItem4, Me.LayoutControlItem21, Me.LayoutControlItem3, Me.LayoutControlItem22, Me.LayoutControlItem12, Me.LayoutControlItem5, Me.LayoutControlItem8})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
		Me.LayoutControlGroup1.Text = "Root"
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.xGrid
		Me.LayoutControlItem7.CustomizationFormText = "Detail"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 167)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(1108, 224)
		Me.LayoutControlItem7.Text = "Detail"
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem7.TextToControlDistance = 0
		Me.LayoutControlItem7.TextVisible = False
		'
		'EmptySpaceItem17
		'
		Me.EmptySpaceItem17.AllowHotTrack = False
		Me.EmptySpaceItem17.CustomizationFormText = "EmptySpaceItem17"
		Me.EmptySpaceItem17.Location = New System.Drawing.Point(0, 391)
		Me.EmptySpaceItem17.Name = "EmptySpaceItem17"
		Me.EmptySpaceItem17.Size = New System.Drawing.Size(1108, 24)
		Me.EmptySpaceItem17.Text = "EmptySpaceItem17"
		Me.EmptySpaceItem17.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlGroup3
		'
		Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
		Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.lytRegional, Me.LayoutControlItem1, Me.LayoutControlItem14, Me.EmptySpaceItem6})
		Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
		Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
		Me.LayoutControlGroup3.Size = New System.Drawing.Size(1108, 94)
		Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
		Me.LayoutControlGroup3.Text = "Info Utama"
		'
		'layKontak
		'
		Me.layKontak.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.layKontak.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
		Me.layKontak.AppearanceItemCaption.Options.UseFont = True
		Me.layKontak.AppearanceItemCaption.Options.UseForeColor = True
		Me.layKontak.Control = Me.txtVehicle
		Me.layKontak.CustomizationFormText = "Vendor"
		Me.layKontak.Location = New System.Drawing.Point(0, 0)
		Me.layKontak.Name = "layKontak"
		Me.layKontak.Size = New System.Drawing.Size(296, 24)
		Me.layKontak.Text = "Vehicle"
		Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.layKontak.TextSize = New System.Drawing.Size(135, 13)
		Me.layKontak.TextToControlDistance = 5
		'
		'LayoutControlItem15
		'
		Me.LayoutControlItem15.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem15.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
		Me.LayoutControlItem15.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem15.AppearanceItemCaption.Options.UseForeColor = True
		Me.LayoutControlItem15.Control = Me.txtTanggal
		Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
		Me.LayoutControlItem15.Location = New System.Drawing.Point(561, 0)
		Me.LayoutControlItem15.Name = "LayoutControlItem15"
		Me.LayoutControlItem15.Size = New System.Drawing.Size(259, 24)
		Me.LayoutControlItem15.Text = "Scheduled Date"
		Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem15.TextSize = New System.Drawing.Size(90, 13)
		Me.LayoutControlItem15.TextToControlDistance = 5
		'
		'LayoutControlItem16
		'
		Me.LayoutControlItem16.Control = Me.txtNoTransaksi
		Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
		Me.LayoutControlItem16.Location = New System.Drawing.Point(820, 0)
		Me.LayoutControlItem16.Name = "LayoutControlItem16"
		Me.LayoutControlItem16.Size = New System.Drawing.Size(246, 24)
		Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
		Me.LayoutControlItem16.Text = "Shipment Code"
		Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem16.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem16.TextToControlDistance = 5
		'
		'LayoutControlItem17
		'
		Me.LayoutControlItem17.Control = Me.btnRefreshNomor
		Me.LayoutControlItem17.CustomizationFormText = " "
		Me.LayoutControlItem17.Location = New System.Drawing.Point(1066, 0)
		Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(30, 26)
		Me.LayoutControlItem17.MinSize = New System.Drawing.Size(30, 26)
		Me.LayoutControlItem17.Name = "LayoutControlItem17"
		Me.LayoutControlItem17.Size = New System.Drawing.Size(30, 48)
		Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.LayoutControlItem17.Text = " "
		Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem17.TextToControlDistance = 0
		Me.LayoutControlItem17.TextVisible = False
		Me.LayoutControlItem17.TrimClientAreaToControl = False
		'
		'lytRegional
		'
		Me.lytRegional.Control = Me.txtRegional
		Me.lytRegional.CustomizationFormText = "Regional"
		Me.lytRegional.Location = New System.Drawing.Point(561, 24)
		Me.lytRegional.Name = "lytRegional"
		Me.lytRegional.Size = New System.Drawing.Size(259, 24)
		Me.lytRegional.Text = "Shareholders"
		Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.lytRegional.TextSize = New System.Drawing.Size(90, 13)
		Me.lytRegional.TextToControlDistance = 5
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtCarrierCompany
		Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(296, 24)
		Me.LayoutControlItem1.Text = "Carrier Company "
		Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(135, 13)
		Me.LayoutControlItem1.TextToControlDistance = 5
		'
		'LayoutControlItem14
		'
		Me.LayoutControlItem14.Control = Me.txtStatus
		Me.LayoutControlItem14.CustomizationFormText = "Status"
		Me.LayoutControlItem14.Location = New System.Drawing.Point(820, 24)
		Me.LayoutControlItem14.Name = "LayoutControlItem14"
		Me.LayoutControlItem14.Size = New System.Drawing.Size(246, 24)
		Me.LayoutControlItem14.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
		Me.LayoutControlItem14.Text = "Status   "
		Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem14.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem14.TextToControlDistance = 5
		'
		'EmptySpaceItem6
		'
		Me.EmptySpaceItem6.AllowHotTrack = False
		Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
		Me.EmptySpaceItem6.Location = New System.Drawing.Point(296, 0)
		Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
		Me.EmptySpaceItem6.Size = New System.Drawing.Size(265, 48)
		Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
		Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LayoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
		Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem9.AppearanceItemCaption.Options.UseForeColor = True
		Me.LayoutControlItem9.Control = Me.txtShipmentUOM
		Me.LayoutControlItem9.CustomizationFormText = "No Penawaran"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 94)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(304, 24)
		Me.LayoutControlItem9.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem9.Text = "Shipment UOM"
		Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(135, 13)
		Me.LayoutControlItem9.TextToControlDistance = 5
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtShipmentStatus
		Me.LayoutControlItem4.CustomizationFormText = "Via"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(304, 94)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(262, 24)
		Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem4.Text = "Shipment Status"
		Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
		Me.LayoutControlItem4.TextToControlDistance = 5
		'
		'LayoutControlItem21
		'
		Me.LayoutControlItem21.Control = Me.txtDriver
		Me.LayoutControlItem21.CustomizationFormText = "Reff Number"
		Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 142)
		Me.LayoutControlItem21.Name = "LayoutControlItem21"
		Me.LayoutControlItem21.Size = New System.Drawing.Size(304, 25)
		Me.LayoutControlItem21.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem21.Text = "Driver"
		Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem21.TextSize = New System.Drawing.Size(135, 13)
		Me.LayoutControlItem21.TextToControlDistance = 5
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtDescription
		Me.LayoutControlItem3.CustomizationFormText = "Uraian"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(566, 94)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(261, 73)
		Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem3.Text = "Description  "
		Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(90, 13)
		Me.LayoutControlItem3.TextToControlDistance = 5
		'
		'LayoutControlItem22
		'
		Me.LayoutControlItem22.Control = Me.txtRemarks
		Me.LayoutControlItem22.CustomizationFormText = "Catatan"
		Me.LayoutControlItem22.Location = New System.Drawing.Point(827, 94)
		Me.LayoutControlItem22.Name = "LayoutControlItem22"
		Me.LayoutControlItem22.Size = New System.Drawing.Size(281, 73)
		Me.LayoutControlItem22.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
		Me.LayoutControlItem22.Text = "Remarks  "
		Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem22.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem22.TextToControlDistance = 5
		'
		'LayoutControlItem12
		'
		Me.LayoutControlItem12.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem12.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
		Me.LayoutControlItem12.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem12.AppearanceItemCaption.Options.UseForeColor = True
		Me.LayoutControlItem12.Control = Me.txtShipmentCreatedFrom
		Me.LayoutControlItem12.CustomizationFormText = "Termin"
		Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 118)
		Me.LayoutControlItem12.Name = "LayoutControlItem12"
		Me.LayoutControlItem12.Size = New System.Drawing.Size(304, 24)
		Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem12.Text = "Shipment Created From"
		Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem12.TextSize = New System.Drawing.Size(135, 13)
		Me.LayoutControlItem12.TextToControlDistance = 5
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtShipmentSequence
		Me.LayoutControlItem5.CustomizationFormText = "Lead Time"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(304, 118)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(262, 24)
		Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem5.Text = "Shipment Sequence"
		Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
		Me.LayoutControlItem5.TextToControlDistance = 5
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.txtPriority
		Me.LayoutControlItem8.CustomizationFormText = "Uang"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(304, 142)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(262, 25)
		Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem8.Text = "Is Priority Shipment ?"
		Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem8.TextToControlDistance = 0
		Me.LayoutControlItem8.TextVisible = False
		'
		'DocumentManager1
		'
		Me.DocumentManager1.ContainerControl = Me
		Me.DocumentManager1.View = Me.TabbedView1
		Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
		'
		'TabbedView1
		'
		Me.TabbedView1.DocumentGroupProperties.ShowTabHeader = False
		Me.TabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.DocumentGroup1})
		Me.TabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document1})
		'
		'DocumentGroup1
		'
		Me.DocumentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.Document1})
		'
		'Document1
		'
		Me.Document1.Caption = "DockPanel2"
		Me.Document1.FloatLocation = New System.Drawing.Point(0, 0)
		Me.Document1.FloatSize = New System.Drawing.Size(200, 200)
		Me.Document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[True]
		Me.Document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
		Me.Document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
		Me.Document1.Properties.ShowPinButton = DevExpress.Utils.DefaultBoolean.[True]
		'
		'BarStaticItem1
		'
		Me.BarStaticItem1.Caption = "xx"
		Me.BarStaticItem1.Id = 6
		Me.BarStaticItem1.Name = "BarStaticItem1"
		Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
		'
		'BarStaticItem2
		'
		Me.BarStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
		Me.BarStaticItem2.Caption = "Tekan Ctrl+Del untuk Menghapus Baris Pada Grid"
		Me.BarStaticItem2.Id = 7
		Me.BarStaticItem2.Name = "BarStaticItem2"
		Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
		'
		'BarButtonItem1
		'
		Me.BarButtonItem1.Caption = "Refresh Master"
		Me.BarButtonItem1.Id = 8
		Me.BarButtonItem1.Name = "BarButtonItem1"
		'
		'btnRefresh
		'
		Me.btnRefresh.Caption = "Refresh"
		Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
		Me.btnRefresh.Id = 9
		Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
		Me.btnRefresh.Name = "btnRefresh"
		'
		'BarButtonItem2
		'
		Me.BarButtonItem2.Caption = "BarButtonItem2"
		Me.BarButtonItem2.Id = 10
		Me.BarButtonItem2.Name = "BarButtonItem2"
		'
		'UI_TMShipByPDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1134, 468)
		Me.Controls.Add(Me.hideContainerRight)
		Me.KeyPreview = True
		Me.Name = "UI_TMShipByPDialog"
		Me.Text = "Shipment by Product"
		Me.Controls.SetChildIndex(Me.hideContainerRight, 0)
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xxHapus, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.hideContainerRight.ResumeLayout(False)
		Me.DockPanel1.ResumeLayout(False)
		Me.DockPanel1_Container.ResumeLayout(False)
		CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.NavBarControl1.ResumeLayout(False)
		Me.NavBarGroupControlContainer3.ResumeLayout(False)
		Me.NavBarGroupControlContainer3.PerformLayout()
		Me.NavBarGroupControlContainer1.ResumeLayout(False)
		CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.NavBarGroupControlContainer2.ResumeLayout(False)
		CType(Me.xGHistory, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGHistoryView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.DockPanel2.ResumeLayout(False)
		Me.DockPanel2_Container.ResumeLayout(False)
		CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytTransaksi.ResumeLayout(False)
		CType(Me.txtCustom4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustom5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustom3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustom2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustom1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDriver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipmentUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipmentSequence.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCarrierCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipmentStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVehicle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipmentCreatedFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
	Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
	Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
	Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
	Friend WithEvents navInfo As DevExpress.XtraNavBar.NavBarGroup
	Friend WithEvents navHistory As DevExpress.XtraNavBar.NavBarGroup
	Friend WithEvents navCatatan As DevExpress.XtraNavBar.NavBarGroup
	Friend WithEvents NavBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
	Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
	Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
	Friend WithEvents xGHistory As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGHistoryView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
	Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
	Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
	Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
	Friend WithEvents lytTransaksi As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
	Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
	Friend WithEvents colOrder As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colProductCode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDestination As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	Friend WithEvents txtPhoneNumber As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtDebitLimit As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtCreditLimit As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtSaldoAP As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtSaldoAR As DevExpress.XtraEditors.LabelControl
	Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
	Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
	Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtShipmentSequence As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtShipmentUOM As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtDriver As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents txtCustom4 As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtCustom5 As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtCustom3 As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtCustom2 As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtCustom1 As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem17 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
	Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colOrderCode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colProductCodex As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtCarrierCompany As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtShipmentStatus As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtPriority As DevExpress.XtraEditors.CheckEdit
	Friend WithEvents txtVehicle As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtShipmentCreatedFrom As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCustomerx As DevExpress.XtraGrid.Columns.GridColumn
End Class
