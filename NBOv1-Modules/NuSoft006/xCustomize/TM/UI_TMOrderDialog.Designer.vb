<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TMOrderDialog
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TMOrderDialog))
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
		Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
		Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtTglBerlaku = New DevExpress.XtraEditors.DateEdit()
		Me.txtOrderType = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtOrderStatus = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
		Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
		Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
		Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.colScheduled = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLoaded = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colRemaining = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtCustomer = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtDescription = New DevExpress.XtraEditors.MemoEdit()
		Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
		Me.txtEndDate = New DevExpress.XtraEditors.DateEdit()
		Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem19 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.FOB = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
		Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
		Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
		Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
		Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
		Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
		Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
		Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
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
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTglBerlaku.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTglBerlaku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtOrderType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtOrderStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem19, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FOB, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.btnRefresh})
		Me.barMan.MaxItemId = 9
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
		Me.DockPanel1.Size = New System.Drawing.Size(250, 431)
		Me.DockPanel1.Text = "Panel Informasi"
		Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
		'
		'DockPanel1_Container
		'
		Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
		Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
		Me.DockPanel1_Container.Name = "DockPanel1_Container"
		Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 404)
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
		Me.NavBarControl1.Size = New System.Drawing.Size(242, 404)
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
		Me.xGHistoryView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
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
		Me.colKode.Width = 117
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		Me.colTanggal.Width = 120
		'
		'colKeterangan
		'
		Me.colKeterangan.Caption = "Keterangan"
		Me.colKeterangan.FieldName = "Catatan"
		Me.colKeterangan.Name = "colKeterangan"
		Me.colKeterangan.Visible = True
		Me.colKeterangan.VisibleIndex = 2
		Me.colKeterangan.Width = 417
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
		Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
		Me.lytTransaksi.Controls.Add(Me.txtStatus)
		Me.lytTransaksi.Controls.Add(Me.txtTglBerlaku)
		Me.lytTransaksi.Controls.Add(Me.txtOrderType)
		Me.lytTransaksi.Controls.Add(Me.txtOrderStatus)
		Me.lytTransaksi.Controls.Add(Me.txtRegional)
		Me.lytTransaksi.Controls.Add(Me.txtTanggal)
		Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
		Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
		Me.lytTransaksi.Controls.Add(Me.xGrid)
		Me.lytTransaksi.Controls.Add(Me.txtCustomer)
		Me.lytTransaksi.Controls.Add(Me.txtDescription)
		Me.lytTransaksi.Controls.Add(Me.txtRemarks)
		Me.lytTransaksi.Controls.Add(Me.txtEndDate)
		Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksi.Name = "lytTransaksi"
		Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 333, 250, 350)
		Me.lytTransaksi.Root = Me.layoutControlGroup1
		Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
		Me.lytTransaksi.TabIndex = 0
		Me.lytTransaksi.Text = "lytTransaksi"
		'
		'lblKontakNama
		'
		Me.lblKontakNama.Location = New System.Drawing.Point(286, 37)
		Me.lblKontakNama.Name = "lblKontakNama"
		Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
		Me.lblKontakNama.StyleController = Me.lytTransaksi
		Me.lblKontakNama.TabIndex = 22
		'
		'txtStatus
		'
		Me.txtStatus.Location = New System.Drawing.Point(967, 61)
		Me.txtStatus.MenuManager = Me.barMan
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
		Me.txtStatus.Properties.DisplayMember = "Value"
		Me.txtStatus.Properties.NullText = "<Status>"
		Me.txtStatus.Properties.ValueMember = "Key"
		Me.txtStatus.Size = New System.Drawing.Size(113, 20)
		Me.txtStatus.StyleController = Me.lytTransaksi
		Me.txtStatus.TabIndex = 6
		'
		'txtTglBerlaku
		'
		Me.txtTglBerlaku.EditValue = Nothing
		Me.txtTglBerlaku.Location = New System.Drawing.Point(117, 106)
		Me.txtTglBerlaku.MenuManager = Me.barMan
		Me.txtTglBerlaku.Name = "txtTglBerlaku"
		Me.txtTglBerlaku.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTglBerlaku.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTglBerlaku.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTglBerlaku.Size = New System.Drawing.Size(165, 20)
		Me.txtTglBerlaku.StyleController = Me.lytTransaksi
		Me.txtTglBerlaku.TabIndex = 7
		'
		'txtOrderType
		'
		Me.txtOrderType.Location = New System.Drawing.Point(117, 154)
		Me.txtOrderType.MenuManager = Me.barMan
		Me.txtOrderType.Name = "txtOrderType"
		Me.txtOrderType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtOrderType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtOrderType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
		Me.txtOrderType.Properties.DisplayMember = "Value"
		Me.txtOrderType.Properties.NullText = "<Order Type>"
		Me.txtOrderType.Properties.ShowHeader = False
		Me.txtOrderType.Properties.ValueMember = "Key"
		Me.txtOrderType.Size = New System.Drawing.Size(165, 20)
		Me.txtOrderType.StyleController = Me.lytTransaksi
		Me.txtOrderType.TabIndex = 11
		'
		'txtOrderStatus
		'
		Me.txtOrderStatus.Location = New System.Drawing.Point(118, 61)
		Me.txtOrderStatus.MenuManager = Me.barMan
		Me.txtOrderStatus.Name = "txtOrderStatus"
		Me.txtOrderStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtOrderStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtOrderStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
		Me.txtOrderStatus.Properties.DisplayMember = "Value"
		Me.txtOrderStatus.Properties.NullText = "<Order Status>"
		Me.txtOrderStatus.Properties.ShowHeader = False
		Me.txtOrderStatus.Properties.ValueMember = "Key"
		Me.txtOrderStatus.Size = New System.Drawing.Size(164, 20)
		Me.txtOrderStatus.StyleController = Me.lytTransaksi
		Me.txtOrderStatus.TabIndex = 4
		'
		'txtRegional
		'
		Me.txtRegional.Location = New System.Drawing.Point(744, 61)
		Me.txtRegional.MenuManager = Me.barMan
		Me.txtRegional.Name = "txtRegional"
		Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
		Me.txtRegional.Properties.DisplayMember = "Nama"
		Me.txtRegional.Properties.NullText = "<Shareholders>"
		Me.txtRegional.Properties.ValueMember = "This"
		Me.txtRegional.Size = New System.Drawing.Size(149, 20)
		Me.txtRegional.StyleController = Me.lytTransaksi
		Me.txtRegional.TabIndex = 5
		'
		'txtTanggal
		'
		Me.txtTanggal.EditValue = Nothing
		Me.txtTanggal.Location = New System.Drawing.Point(744, 37)
		Me.txtTanggal.MenuManager = Me.barMan
		Me.txtTanggal.Name = "txtTanggal"
		Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal.Size = New System.Drawing.Size(149, 20)
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
		Me.txtNoTransaksi.Location = New System.Drawing.Point(967, 37)
		Me.txtNoTransaksi.MenuManager = Me.barMan
		Me.txtNoTransaksi.Name = "txtNoTransaksi"
		Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoTransaksi.Size = New System.Drawing.Size(113, 20)
		Me.txtNoTransaksi.StyleController = Me.lytTransaksi
		Me.txtNoTransaksi.TabIndex = 2
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 178)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.MenuManager = Me.barMan
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSatuanRepo, Me.colKodeBarangRepo})
		Me.xGrid.Size = New System.Drawing.Size(1104, 221)
		Me.xGrid.TabIndex = 12
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colScheduled, Me.colLoaded, Me.colRemaining})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colKodeBarang
		'
		Me.colKodeBarang.Caption = "Product Code"
		Me.colKodeBarang.ColumnEdit = Me.colKodeBarangRepo
		Me.colKodeBarang.FieldName = "Barang!"
		Me.colKodeBarang.Name = "colKodeBarang"
		Me.colKodeBarang.Visible = True
		Me.colKodeBarang.VisibleIndex = 0
		Me.colKodeBarang.Width = 175
		'
		'colKodeBarangRepo
		'
		Me.colKodeBarangRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colKodeBarangRepo.DisplayMember = "Kode"
		Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
		Me.colKodeBarangRepo.NullText = "<Product Code>"
		Me.colKodeBarangRepo.ShowClearButton = False
		Me.colKodeBarangRepo.ShowFooter = False
		Me.colKodeBarangRepo.ValueMember = "This"
		Me.colKodeBarangRepo.View = Me.RepositoryItemSearchLookUpEdit1View
		'
		'RepositoryItemSearchLookUpEdit1View
		'
		Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama, Me.gcSatuan})
		Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
		Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		'
		'gcKode
		'
		Me.gcKode.Caption = "Kode"
		Me.gcKode.FieldName = "Kode"
		Me.gcKode.Name = "gcKode"
		Me.gcKode.Visible = True
		Me.gcKode.VisibleIndex = 0
		Me.gcKode.Width = 293
		'
		'gcNama
		'
		Me.gcNama.Caption = "Nama"
		Me.gcNama.FieldName = "Nama"
		Me.gcNama.Name = "gcNama"
		Me.gcNama.Visible = True
		Me.gcNama.VisibleIndex = 1
		Me.gcNama.Width = 519
		'
		'gcSatuan
		'
		Me.gcSatuan.Caption = "Satuan"
		Me.gcSatuan.FieldName = "Satuan.Nama"
		Me.gcSatuan.Name = "gcSatuan"
		Me.gcSatuan.Visible = True
		Me.gcSatuan.VisibleIndex = 2
		Me.gcSatuan.Width = 266
		'
		'colNamaBarang
		'
		Me.colNamaBarang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.colNamaBarang.AppearanceCell.Options.UseBackColor = True
		Me.colNamaBarang.Caption = "Product Name"
		Me.colNamaBarang.FieldName = "Barang.Nama"
		Me.colNamaBarang.Name = "colNamaBarang"
		Me.colNamaBarang.OptionsColumn.AllowEdit = False
		Me.colNamaBarang.OptionsColumn.ReadOnly = True
		Me.colNamaBarang.Visible = True
		Me.colNamaBarang.VisibleIndex = 1
		Me.colNamaBarang.Width = 250
		'
		'colQty
		'
		Me.colQty.AppearanceCell.Options.UseTextOptions = True
		Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQty.AppearanceHeader.Options.UseTextOptions = True
		Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQty.Caption = "Quantity"
		Me.colQty.DisplayFormat.FormatString = "n0"
		Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.OptionsColumn.AllowSize = False
		Me.colQty.OptionsColumn.FixedWidth = True
		Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 2
		Me.colQty.Width = 100
		'
		'colSatuan
		'
		Me.colSatuan.AppearanceCell.Options.UseTextOptions = True
		Me.colSatuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colSatuan.AppearanceHeader.Options.UseTextOptions = True
		Me.colSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colSatuan.Caption = "Quantity UOM"
		Me.colSatuan.ColumnEdit = Me.colSatuanRepo
		Me.colSatuan.FieldName = "Satuan!"
		Me.colSatuan.Name = "colSatuan"
		Me.colSatuan.Visible = True
		Me.colSatuan.VisibleIndex = 3
		Me.colSatuan.Width = 100
		'
		'colSatuanRepo
		'
		Me.colSatuanRepo.AutoHeight = False
		Me.colSatuanRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colSatuanRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.colSatuanRepo.DisplayMember = "Kode"
		Me.colSatuanRepo.Name = "colSatuanRepo"
		Me.colSatuanRepo.NullText = "<Quantity UOM>"
		Me.colSatuanRepo.ValueMember = "This"
		'
		'colScheduled
		'
		Me.colScheduled.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.colScheduled.AppearanceCell.Options.UseBackColor = True
		Me.colScheduled.Caption = "Scheduled Quantity"
		Me.colScheduled.DisplayFormat.FormatString = "n0"
		Me.colScheduled.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colScheduled.FieldName = "Qty"
		Me.colScheduled.Name = "colScheduled"
		Me.colScheduled.OptionsColumn.AllowEdit = False
		Me.colScheduled.OptionsColumn.ReadOnly = True
		Me.colScheduled.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
		Me.colScheduled.Visible = True
		Me.colScheduled.VisibleIndex = 4
		Me.colScheduled.Width = 120
		'
		'colLoaded
		'
		Me.colLoaded.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.colLoaded.AppearanceCell.Options.UseBackColor = True
		Me.colLoaded.AppearanceCell.Options.UseTextOptions = True
		Me.colLoaded.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colLoaded.AppearanceHeader.Options.UseTextOptions = True
		Me.colLoaded.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colLoaded.Caption = "Loaded Quantity"
		Me.colLoaded.DisplayFormat.FormatString = "n0"
		Me.colLoaded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLoaded.FieldName = "LoadedQty"
		Me.colLoaded.Name = "colLoaded"
		Me.colLoaded.OptionsColumn.AllowEdit = False
		Me.colLoaded.OptionsColumn.ReadOnly = True
		Me.colLoaded.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LoadedQty", "{0:n0}")})
		Me.colLoaded.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colLoaded.Visible = True
		Me.colLoaded.VisibleIndex = 5
		Me.colLoaded.Width = 120
		'
		'colRemaining
		'
		Me.colRemaining.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.colRemaining.AppearanceCell.Options.UseBackColor = True
		Me.colRemaining.Caption = "Remaining Quantity"
		Me.colRemaining.DisplayFormat.FormatString = "n0"
		Me.colRemaining.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colRemaining.FieldName = "RemainingQty"
		Me.colRemaining.Name = "colRemaining"
		Me.colRemaining.OptionsColumn.AllowEdit = False
		Me.colRemaining.OptionsColumn.ReadOnly = True
		Me.colRemaining.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RemainingQty", "{0:n0}")})
		Me.colRemaining.Visible = True
		Me.colRemaining.VisibleIndex = 6
		Me.colRemaining.Width = 221
		'
		'txtCustomer
		'
		Me.txtCustomer.Location = New System.Drawing.Point(118, 37)
		Me.txtCustomer.MenuManager = Me.barMan
		Me.txtCustomer.Name = "txtCustomer"
		Me.txtCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCustomer.Properties.DisplayMember = "Kode"
		Me.txtCustomer.Properties.NullText = "<Customer>"
		Me.txtCustomer.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
		Me.txtCustomer.Properties.ShowClearButton = False
		Me.txtCustomer.Properties.ShowFooter = False
		Me.txtCustomer.Properties.ValueMember = "This"
		Me.txtCustomer.Properties.View = Me.SearchLookUpEdit1View
		Me.txtCustomer.Size = New System.Drawing.Size(164, 20)
		Me.txtCustomer.StyleController = Me.lytTransaksi
		Me.txtCustomer.TabIndex = 0
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
		'txtDescription
		'
		Me.txtDescription.Location = New System.Drawing.Point(358, 106)
		Me.txtDescription.MenuManager = Me.barMan
		Me.txtDescription.Name = "txtDescription"
		Me.txtDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtDescription.Properties.MaxLength = 255
		Me.txtDescription.Size = New System.Drawing.Size(401, 68)
		Me.txtDescription.StyleController = Me.lytTransaksi
		Me.txtDescription.TabIndex = 8
		'
		'txtRemarks
		'
		Me.txtRemarks.Location = New System.Drawing.Point(823, 106)
		Me.txtRemarks.MenuManager = Me.barMan
		Me.txtRemarks.Name = "txtRemarks"
		Me.txtRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRemarks.Size = New System.Drawing.Size(293, 68)
		Me.txtRemarks.StyleController = Me.lytTransaksi
		Me.txtRemarks.TabIndex = 9
		'
		'txtEndDate
		'
		Me.txtEndDate.EditValue = Nothing
		Me.txtEndDate.Location = New System.Drawing.Point(117, 130)
		Me.txtEndDate.MenuManager = Me.barMan
		Me.txtEndDate.Name = "txtEndDate"
		Me.txtEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtEndDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.txtEndDate.Size = New System.Drawing.Size(165, 20)
		Me.txtEndDate.StyleController = Me.lytTransaksi
		Me.txtEndDate.TabIndex = 10
		'
		'layoutControlGroup1
		'
		Me.layoutControlGroup1.CustomizationFormText = "Root"
		Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.layoutControlGroup1.GroupBordersVisible = False
		Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.EmptySpaceItem19, Me.LayoutControlGroup3, Me.LayoutControlItem4, Me.FOB, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem3})
		Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.layoutControlGroup1.Name = "Root"
		Me.layoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
		Me.layoutControlGroup1.Text = "Root"
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.xGrid
		Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 166)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(1108, 225)
		Me.LayoutControlItem7.Text = "LayoutControlItem7"
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem7.TextToControlDistance = 0
		Me.LayoutControlItem7.TextVisible = False
		'
		'EmptySpaceItem19
		'
		Me.EmptySpaceItem19.AllowHotTrack = False
		Me.EmptySpaceItem19.CustomizationFormText = "EmptySpaceItem19"
		Me.EmptySpaceItem19.Location = New System.Drawing.Point(0, 391)
		Me.EmptySpaceItem19.Name = "EmptySpaceItem19"
		Me.EmptySpaceItem19.Size = New System.Drawing.Size(1108, 24)
		Me.EmptySpaceItem19.Text = "EmptySpaceItem19"
		Me.EmptySpaceItem19.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlGroup3
		'
		Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
		Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
		Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
		Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
		Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem1, Me.lytRegional, Me.LayoutControlItem14, Me.EmptySpaceItem3, Me.LayoutControlItem20, Me.EmptySpaceItem2})
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
		Me.layKontak.Control = Me.txtCustomer
		Me.layKontak.CustomizationFormText = "Customer"
		Me.layKontak.Location = New System.Drawing.Point(0, 0)
		Me.layKontak.Name = "layKontak"
		Me.layKontak.Size = New System.Drawing.Size(268, 24)
		Me.layKontak.Text = "Customer"
		Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.layKontak.TextSize = New System.Drawing.Size(95, 13)
		Me.layKontak.TextToControlDistance = 5
		'
		'LayoutControlItem15
		'
		Me.LayoutControlItem15.Control = Me.txtTanggal
		Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
		Me.LayoutControlItem15.Location = New System.Drawing.Point(656, 0)
		Me.LayoutControlItem15.Name = "LayoutControlItem15"
		Me.LayoutControlItem15.Size = New System.Drawing.Size(223, 24)
		Me.LayoutControlItem15.Text = "Order Date"
		Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem15.TextSize = New System.Drawing.Size(65, 13)
		Me.LayoutControlItem15.TextToControlDistance = 5
		'
		'LayoutControlItem16
		'
		Me.LayoutControlItem16.Control = Me.txtNoTransaksi
		Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
		Me.LayoutControlItem16.Location = New System.Drawing.Point(879, 0)
		Me.LayoutControlItem16.Name = "LayoutControlItem16"
		Me.LayoutControlItem16.Size = New System.Drawing.Size(187, 24)
		Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
		Me.LayoutControlItem16.Text = "Order Code"
		Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem16.TextSize = New System.Drawing.Size(55, 13)
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
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtOrderStatus
		Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(268, 24)
		Me.LayoutControlItem1.Text = "Order Status"
		Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(95, 13)
		Me.LayoutControlItem1.TextToControlDistance = 5
		'
		'lytRegional
		'
		Me.lytRegional.Control = Me.txtRegional
		Me.lytRegional.CustomizationFormText = "Regional"
		Me.lytRegional.Location = New System.Drawing.Point(656, 24)
		Me.lytRegional.Name = "lytRegional"
		Me.lytRegional.Size = New System.Drawing.Size(223, 24)
		Me.lytRegional.Text = "Shareholders"
		Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.lytRegional.TextSize = New System.Drawing.Size(65, 13)
		Me.lytRegional.TextToControlDistance = 5
		'
		'LayoutControlItem14
		'
		Me.LayoutControlItem14.Control = Me.txtStatus
		Me.LayoutControlItem14.CustomizationFormText = "Status"
		Me.LayoutControlItem14.Location = New System.Drawing.Point(879, 24)
		Me.LayoutControlItem14.Name = "LayoutControlItem14"
		Me.LayoutControlItem14.Size = New System.Drawing.Size(187, 24)
		Me.LayoutControlItem14.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
		Me.LayoutControlItem14.Text = "Status"
		Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem14.TextSize = New System.Drawing.Size(55, 13)
		Me.LayoutControlItem14.TextToControlDistance = 5
		'
		'EmptySpaceItem3
		'
		Me.EmptySpaceItem3.AllowHotTrack = False
		Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Location = New System.Drawing.Point(484, 0)
		Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Size = New System.Drawing.Size(172, 48)
		Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
		Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem20
		'
		Me.LayoutControlItem20.Control = Me.lblKontakNama
		Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
		Me.LayoutControlItem20.Location = New System.Drawing.Point(268, 0)
		Me.LayoutControlItem20.MinSize = New System.Drawing.Size(70, 17)
		Me.LayoutControlItem20.Name = "LayoutControlItem20"
		Me.LayoutControlItem20.Size = New System.Drawing.Size(216, 24)
		Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.LayoutControlItem20.Text = "LayoutControlItem20"
		Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem20.TextToControlDistance = 0
		Me.LayoutControlItem20.TextVisible = False
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(268, 24)
		Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
		Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem4.AppearanceItemCaption.Options.UseForeColor = True
		Me.LayoutControlItem4.Control = Me.txtEndDate
		Me.LayoutControlItem4.CustomizationFormText = "Via"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 118)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(274, 24)
		Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem4.Text = "Order End Date"
		Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(95, 13)
		Me.LayoutControlItem4.TextToControlDistance = 5
		'
		'FOB
		'
		Me.FOB.Control = Me.txtOrderType
		Me.FOB.CustomizationFormText = "Order Type"
		Me.FOB.Location = New System.Drawing.Point(0, 142)
		Me.FOB.Name = "FOB"
		Me.FOB.Size = New System.Drawing.Size(274, 24)
		Me.FOB.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.FOB.Text = "Order Type"
		Me.FOB.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.FOB.TextSize = New System.Drawing.Size(95, 13)
		Me.FOB.TextToControlDistance = 5
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
		Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem6.AppearanceItemCaption.Options.UseForeColor = True
		Me.LayoutControlItem6.Control = Me.txtTglBerlaku
		Me.LayoutControlItem6.CustomizationFormText = "Tgl Berlaku"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 94)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(274, 24)
		Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem6.Text = "Order Start Date"
		Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(95, 13)
		Me.LayoutControlItem6.TextToControlDistance = 5
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtRemarks
		Me.LayoutControlItem5.CustomizationFormText = "Lead Time"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(751, 94)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(357, 72)
		Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem5.Text = "Remarks   "
		Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(50, 13)
		Me.LayoutControlItem5.TextToControlDistance = 5
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtDescription
		Me.LayoutControlItem3.CustomizationFormText = "Uraian"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(274, 94)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(477, 72)
		Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem3.Text = "Description   "
		Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(62, 13)
		Me.LayoutControlItem3.TextToControlDistance = 5
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
		'btnRefresh
		'
		Me.btnRefresh.Caption = "Refresh"
		Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
		Me.btnRefresh.Id = 8
		Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
		Me.btnRefresh.Name = "btnRefresh"
		'
		'XpCollection1
		'
		Me.XpCollection1.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.KontakAlamat)
		'
		'UI_TMOrderDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1134, 468)
		Me.Controls.Add(Me.hideContainerRight)
		Me.KeyPreview = True
		Me.Name = "UI_TMOrderDialog"
		Me.Text = "Order"
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
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTglBerlaku.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTglBerlaku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtOrderType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtOrderStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem19, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FOB, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
	Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
	Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLoaded As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	Friend WithEvents txtOrderStatus As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents colSatuanRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
	Friend WithEvents txtOrderType As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtTglBerlaku As DevExpress.XtraEditors.DateEdit
	Friend WithEvents colScheduled As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colRemaining As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents FOB As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem19 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtCustomer As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
	Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
	Friend WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtEndDate As DevExpress.XtraEditors.DateEdit
End Class
