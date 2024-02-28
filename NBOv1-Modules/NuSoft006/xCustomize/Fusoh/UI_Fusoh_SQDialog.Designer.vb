<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_Fusoh_SQDialog
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Fusoh_SQDialog))
		Me.xxHapus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager()
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
		Me.txtCatatan = New DevExpress.XtraEditors.MemoEdit()
		Me.txtYourReff = New DevExpress.XtraEditors.TextEdit()
		Me.txtValidiity2 = New DevExpress.XtraEditors.DateEdit()
		Me.txtInspection = New DevExpress.XtraEditors.TextEdit()
		Me.txtPayment = New DevExpress.XtraEditors.TextEdit()
		Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
		Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtTermin = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtValidiity1 = New DevExpress.XtraEditors.DateEdit()
		Me.txtTermPrice = New DevExpress.XtraEditors.TextEdit()
		Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
		Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
		Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colNoPart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPartRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.colInD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
		Me.colProcessingPrice = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaRp = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtOthers = New DevExpress.XtraEditors.TextEdit()
		Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtAlamatText = New DevExpress.XtraEditors.MemoEdit()
		Me.txtAlamat = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtKurs = New DevExpress.XtraEditors.SpinEdit()
		Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
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
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager()
		Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
		Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
		Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
		Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
		Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
		Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
		Me.XpCollection1 = New DevExpress.Xpo.XPCollection()
		Me.btnImpor = New DevExpress.XtraBars.BarButtonItem()
		Me.btnDownload = New DevExpress.XtraBars.BarButtonItem()
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
		CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtYourReff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtValidiity2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtValidiity2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtInspection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtValidiity1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtValidiity1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTermPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colPartRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtOthers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAlamatText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
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
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnImpor, Me.btnDownload})
		Me.barMan.MaxItemId = 8
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImpor, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDownload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
		Me.lytTransaksi.Controls.Add(Me.txtCatatan)
		Me.lytTransaksi.Controls.Add(Me.txtYourReff)
		Me.lytTransaksi.Controls.Add(Me.txtValidiity2)
		Me.lytTransaksi.Controls.Add(Me.txtInspection)
		Me.lytTransaksi.Controls.Add(Me.txtPayment)
		Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
		Me.lytTransaksi.Controls.Add(Me.txtStatus)
		Me.lytTransaksi.Controls.Add(Me.txtTermin)
		Me.lytTransaksi.Controls.Add(Me.txtUang)
		Me.lytTransaksi.Controls.Add(Me.txtValidiity1)
		Me.lytTransaksi.Controls.Add(Me.txtTermPrice)
		Me.lytTransaksi.Controls.Add(Me.txtKontakPerson)
		Me.lytTransaksi.Controls.Add(Me.txtRegional)
		Me.lytTransaksi.Controls.Add(Me.txtTanggal)
		Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
		Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
		Me.lytTransaksi.Controls.Add(Me.xGrid)
		Me.lytTransaksi.Controls.Add(Me.txtOthers)
		Me.lytTransaksi.Controls.Add(Me.txtKontak)
		Me.lytTransaksi.Controls.Add(Me.txtAlamatText)
		Me.lytTransaksi.Controls.Add(Me.txtAlamat)
		Me.lytTransaksi.Controls.Add(Me.txtKurs)
		Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksi.Name = "lytTransaksi"
		Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 333, 250, 350)
		Me.lytTransaksi.Root = Me.layoutControlGroup1
		Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
		Me.lytTransaksi.TabIndex = 0
		Me.lytTransaksi.Text = "lytTransaksi"
		'
		'txtCatatan
		'
		Me.txtCatatan.EnterMoveNextControl = True
		Me.txtCatatan.Location = New System.Drawing.Point(256, 122)
		Me.txtCatatan.MenuManager = Me.barMan
		Me.txtCatatan.Name = "txtCatatan"
		Me.txtCatatan.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtCatatan.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtCatatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCatatan.Size = New System.Drawing.Size(203, 76)
		Me.txtCatatan.StyleController = Me.lytTransaksi
		Me.txtCatatan.TabIndex = 8
		'
		'txtYourReff
		'
		Me.txtYourReff.EditValue = ""
		Me.txtYourReff.EnterMoveNextControl = True
		Me.txtYourReff.Location = New System.Drawing.Point(558, 178)
		Me.txtYourReff.MenuManager = Me.barMan
		Me.txtYourReff.Name = "txtYourReff"
		Me.txtYourReff.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtYourReff.Properties.NullText = "<Your Reff>"
		Me.txtYourReff.Size = New System.Drawing.Size(111, 20)
		Me.txtYourReff.StyleController = Me.lytTransaksi
		Me.txtYourReff.TabIndex = 17
		'
		'txtValidiity2
		'
		Me.txtValidiity2.EditValue = Nothing
		Me.txtValidiity2.EnterMoveNextControl = True
		Me.txtValidiity2.Location = New System.Drawing.Point(952, 130)
		Me.txtValidiity2.MenuManager = Me.barMan
		Me.txtValidiity2.Name = "txtValidiity2"
		Me.txtValidiity2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtValidiity2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtValidiity2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtValidiity2.Size = New System.Drawing.Size(164, 20)
		Me.txtValidiity2.StyleController = Me.lytTransaksi
		Me.txtValidiity2.TabIndex = 15
		'
		'txtInspection
		'
		Me.txtInspection.EditValue = ""
		Me.txtInspection.EnterMoveNextControl = True
		Me.txtInspection.Location = New System.Drawing.Point(737, 130)
		Me.txtInspection.MenuManager = Me.barMan
		Me.txtInspection.Name = "txtInspection"
		Me.txtInspection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtInspection.Properties.NullText = "<Inspection>"
		Me.txtInspection.Size = New System.Drawing.Size(156, 20)
		Me.txtInspection.StyleController = Me.lytTransaksi
		Me.txtInspection.TabIndex = 14
		'
		'txtPayment
		'
		Me.txtPayment.EditValue = ""
		Me.txtPayment.EnterMoveNextControl = True
		Me.txtPayment.Location = New System.Drawing.Point(737, 106)
		Me.txtPayment.MenuManager = Me.barMan
		Me.txtPayment.Name = "txtPayment"
		Me.txtPayment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtPayment.Properties.NullText = "<Payment>"
		Me.txtPayment.Size = New System.Drawing.Size(156, 20)
		Me.txtPayment.StyleController = Me.lytTransaksi
		Me.txtPayment.TabIndex = 10
		'
		'lblKontakNama
		'
		Me.lblKontakNama.Location = New System.Drawing.Point(256, 37)
		Me.lblKontakNama.Name = "lblKontakNama"
		Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
		Me.lblKontakNama.StyleController = Me.lytTransaksi
		Me.lblKontakNama.TabIndex = 18
		'
		'txtStatus
		'
		Me.txtStatus.EnterMoveNextControl = True
		Me.txtStatus.Location = New System.Drawing.Point(938, 61)
		Me.txtStatus.MenuManager = Me.barMan
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
		Me.txtStatus.Properties.DisplayMember = "Value"
		Me.txtStatus.Properties.NullText = "<Status>"
		Me.txtStatus.Properties.ValueMember = "Key"
		Me.txtStatus.Size = New System.Drawing.Size(142, 20)
		Me.txtStatus.StyleController = Me.lytTransaksi
		Me.txtStatus.TabIndex = 6
		'
		'txtTermin
		'
		Me.txtTermin.EnterMoveNextControl = True
		Me.txtTermin.Location = New System.Drawing.Point(558, 130)
		Me.txtTermin.MenuManager = Me.barMan
		Me.txtTermin.Name = "txtTermin"
		Me.txtTermin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTermin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTermin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
		Me.txtTermin.Properties.DisplayMember = "Kode"
		Me.txtTermin.Properties.NullText = "<Term of Price>"
		Me.txtTermin.Properties.ValueMember = "This"
		Me.txtTermin.Size = New System.Drawing.Size(110, 20)
		Me.txtTermin.StyleController = Me.lytTransaksi
		Me.txtTermin.TabIndex = 13
		'
		'txtUang
		'
		Me.txtUang.EnterMoveNextControl = True
		Me.txtUang.Location = New System.Drawing.Point(768, 178)
		Me.txtUang.MenuManager = Me.barMan
		Me.txtUang.Name = "txtUang"
		Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.txtUang.Properties.DisplayMember = "Kode"
		Me.txtUang.Properties.NullText = "<Uang>"
		Me.txtUang.Properties.ValueMember = "This"
		Me.txtUang.Size = New System.Drawing.Size(126, 20)
		Me.txtUang.StyleController = Me.lytTransaksi
		Me.txtUang.TabIndex = 18
		'
		'txtValidiity1
		'
		Me.txtValidiity1.EditValue = Nothing
		Me.txtValidiity1.EnterMoveNextControl = True
		Me.txtValidiity1.Location = New System.Drawing.Point(952, 106)
		Me.txtValidiity1.MenuManager = Me.barMan
		Me.txtValidiity1.Name = "txtValidiity1"
		Me.txtValidiity1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtValidiity1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtValidiity1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtValidiity1.Size = New System.Drawing.Size(164, 20)
		Me.txtValidiity1.StyleController = Me.lytTransaksi
		Me.txtValidiity1.TabIndex = 11
		'
		'txtTermPrice
		'
		Me.txtTermPrice.EditValue = ""
		Me.txtTermPrice.EnterMoveNextControl = True
		Me.txtTermPrice.Location = New System.Drawing.Point(558, 106)
		Me.txtTermPrice.MenuManager = Me.barMan
		Me.txtTermPrice.Name = "txtTermPrice"
		Me.txtTermPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTermPrice.Properties.NullText = "<Term of delivery>"
		Me.txtTermPrice.Size = New System.Drawing.Size(110, 20)
		Me.txtTermPrice.StyleController = Me.lytTransaksi
		Me.txtTermPrice.TabIndex = 9
		'
		'txtKontakPerson
		'
		Me.txtKontakPerson.EnterMoveNextControl = True
		Me.txtKontakPerson.Location = New System.Drawing.Point(92, 61)
		Me.txtKontakPerson.MenuManager = Me.barMan
		Me.txtKontakPerson.Name = "txtKontakPerson"
		Me.txtKontakPerson.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtKontakPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtKontakPerson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.txtKontakPerson.Properties.DisplayMember = "Nama"
		Me.txtKontakPerson.Properties.NullText = "<Pilih Kontak Person>"
		Me.txtKontakPerson.Properties.ValueMember = "Nama"
		Me.txtKontakPerson.Size = New System.Drawing.Size(160, 20)
		Me.txtKontakPerson.StyleController = Me.lytTransaksi
		Me.txtKontakPerson.TabIndex = 4
		'
		'txtRegional
		'
		Me.txtRegional.EnterMoveNextControl = True
		Me.txtRegional.Location = New System.Drawing.Point(737, 61)
		Me.txtRegional.MenuManager = Me.barMan
		Me.txtRegional.Name = "txtRegional"
		Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
		Me.txtRegional.Properties.DisplayMember = "Nama"
		Me.txtRegional.Properties.NullText = "<Pilih Regional>"
		Me.txtRegional.Properties.ValueMember = "This"
		Me.txtRegional.Size = New System.Drawing.Size(144, 20)
		Me.txtRegional.StyleController = Me.lytTransaksi
		Me.txtRegional.TabIndex = 5
		'
		'txtTanggal
		'
		Me.txtTanggal.EditValue = Nothing
		Me.txtTanggal.EnterMoveNextControl = True
		Me.txtTanggal.Location = New System.Drawing.Point(737, 37)
		Me.txtTanggal.MenuManager = Me.barMan
		Me.txtTanggal.Name = "txtTanggal"
		Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal.Size = New System.Drawing.Size(144, 20)
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
		Me.txtNoTransaksi.EnterMoveNextControl = True
		Me.txtNoTransaksi.Location = New System.Drawing.Point(938, 37)
		Me.txtNoTransaksi.MenuManager = Me.barMan
		Me.txtNoTransaksi.Name = "txtNoTransaksi"
		Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoTransaksi.Size = New System.Drawing.Size(142, 20)
		Me.txtNoTransaksi.StyleController = Me.lytTransaksi
		Me.txtNoTransaksi.TabIndex = 2
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 202)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.MenuManager = Me.barMan
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colHargaRepo, Me.colSpekRepo, Me.colPartRepo})
		Me.xGrid.Size = New System.Drawing.Size(1104, 221)
		Me.xGrid.TabIndex = 20
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
		Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.xGridView.ColumnPanelRowHeight = 30
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoPart, Me.colPartName, Me.colMaterial, Me.colOD, Me.colInD, Me.colThickness, Me.colLength, Me.colQty, Me.colWeight, Me.colHarga, Me.colProcessingPrice, Me.colHargaRp, Me.colTotal, Me.colCatatan})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
		Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colNoPart
		'
		Me.colNoPart.Caption = "Part No."
		Me.colNoPart.ColumnEdit = Me.colPartRepo
		Me.colNoPart.FieldName = "PartNo"
		Me.colNoPart.Name = "colNoPart"
		Me.colNoPart.Visible = True
		Me.colNoPart.VisibleIndex = 0
		Me.colNoPart.Width = 97
		'
		'colPartRepo
		'
		Me.colPartRepo.AutoHeight = False
		Me.colPartRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.colPartRepo.Name = "colPartRepo"
		'
		'colPartName
		'
		Me.colPartName.Caption = "Part Name"
		Me.colPartName.FieldName = "Barang"
		Me.colPartName.Name = "colPartName"
		Me.colPartName.Visible = True
		Me.colPartName.VisibleIndex = 1
		'
		'colMaterial
		'
		Me.colMaterial.AppearanceCell.Options.UseTextOptions = True
		Me.colMaterial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colMaterial.AppearanceHeader.Options.UseTextOptions = True
		Me.colMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colMaterial.Caption = "Material"
		Me.colMaterial.FieldName = "Material"
		Me.colMaterial.Name = "colMaterial"
		Me.colMaterial.Visible = True
		Me.colMaterial.VisibleIndex = 2
		Me.colMaterial.Width = 115
		'
		'colOD
		'
		Me.colOD.AppearanceCell.Options.UseTextOptions = True
		Me.colOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colOD.AppearanceHeader.Options.UseTextOptions = True
		Me.colOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colOD.Caption = "OD"
		Me.colOD.ColumnEdit = Me.colSpekRepo
		Me.colOD.DisplayFormat.FormatString = "n1"
		Me.colOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colOD.FieldName = "OutDiameter"
		Me.colOD.Name = "colOD"
		Me.colOD.Visible = True
		Me.colOD.VisibleIndex = 4
		Me.colOD.Width = 43
		'
		'colSpekRepo
		'
		Me.colSpekRepo.AutoHeight = False
		Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colSpekRepo.Name = "colSpekRepo"
		'
		'colInD
		'
		Me.colInD.AppearanceCell.Options.UseTextOptions = True
		Me.colInD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colInD.AppearanceHeader.Options.UseTextOptions = True
		Me.colInD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colInD.Caption = "ID"
		Me.colInD.ColumnEdit = Me.colSpekRepo
		Me.colInD.DisplayFormat.FormatString = "n1"
		Me.colInD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colInD.FieldName = "InDiameter"
		Me.colInD.Name = "colInD"
		Me.colInD.Visible = True
		Me.colInD.VisibleIndex = 3
		Me.colInD.Width = 43
		'
		'colThickness
		'
		Me.colThickness.AppearanceCell.Options.UseTextOptions = True
		Me.colThickness.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colThickness.AppearanceHeader.Options.UseTextOptions = True
		Me.colThickness.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colThickness.Caption = "T"
		Me.colThickness.ColumnEdit = Me.colSpekRepo
		Me.colThickness.DisplayFormat.FormatString = "n1"
		Me.colThickness.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colThickness.FieldName = "Thickness"
		Me.colThickness.Name = "colThickness"
		Me.colThickness.Visible = True
		Me.colThickness.VisibleIndex = 5
		Me.colThickness.Width = 43
		'
		'colLength
		'
		Me.colLength.AppearanceCell.Options.UseTextOptions = True
		Me.colLength.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLength.AppearanceHeader.Options.UseTextOptions = True
		Me.colLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLength.Caption = "L"
		Me.colLength.ColumnEdit = Me.colSpekRepo
		Me.colLength.DisplayFormat.FormatString = "n1"
		Me.colLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLength.FieldName = "Length"
		Me.colLength.Name = "colLength"
		Me.colLength.Visible = True
		Me.colLength.VisibleIndex = 6
		Me.colLength.Width = 43
		'
		'colQty
		'
		Me.colQty.AppearanceCell.Options.UseTextOptions = True
		Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colQty.AppearanceHeader.Options.UseTextOptions = True
		Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colQty.Caption = "Min Qty"
		Me.colQty.ColumnEdit = Me.colSpekRepo
		Me.colQty.DisplayFormat.FormatString = "n0"
		Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.OptionsColumn.AllowSize = False
		Me.colQty.OptionsColumn.FixedWidth = True
		Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 7
		Me.colQty.Width = 70
		'
		'colWeight
		'
		Me.colWeight.AppearanceCell.Options.UseTextOptions = True
		Me.colWeight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colWeight.AppearanceHeader.Options.UseTextOptions = True
		Me.colWeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colWeight.Caption = "Total Weight"
		Me.colWeight.DisplayFormat.FormatString = "n3"
		Me.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colWeight.FieldName = "Weight"
		Me.colWeight.Name = "colWeight"
		Me.colWeight.OptionsColumn.AllowEdit = False
		Me.colWeight.OptionsColumn.ReadOnly = True
		Me.colWeight.Visible = True
		Me.colWeight.VisibleIndex = 8
		Me.colWeight.Width = 76
		'
		'colHarga
		'
		Me.colHarga.AppearanceCell.Options.UseTextOptions = True
		Me.colHarga.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHarga.AppearanceHeader.Options.UseTextOptions = True
		Me.colHarga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colHarga.Caption = "Current Price"
		Me.colHarga.ColumnEdit = Me.colHargaRepo
		Me.colHarga.DisplayFormat.FormatString = "n2"
		Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga.FieldName = "Harga"
		Me.colHarga.Name = "colHarga"
		Me.colHarga.Visible = True
		Me.colHarga.VisibleIndex = 9
		Me.colHarga.Width = 69
		'
		'colHargaRepo
		'
		Me.colHargaRepo.AutoHeight = False
		Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colHargaRepo.Name = "colHargaRepo"
		'
		'colProcessingPrice
		'
		Me.colProcessingPrice.AppearanceCell.Options.UseTextOptions = True
		Me.colProcessingPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colProcessingPrice.AppearanceHeader.Options.UseTextOptions = True
		Me.colProcessingPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colProcessingPrice.Caption = "Harga"
		Me.colProcessingPrice.DisplayFormat.FormatString = "n0"
		Me.colProcessingPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colProcessingPrice.FieldName = "HargaProses"
		Me.colProcessingPrice.Name = "colProcessingPrice"
		Me.colProcessingPrice.Visible = True
		Me.colProcessingPrice.VisibleIndex = 10
		Me.colProcessingPrice.Width = 80
		'
		'colHargaRp
		'
		Me.colHargaRp.AppearanceCell.Options.UseTextOptions = True
		Me.colHargaRp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHargaRp.AppearanceHeader.Options.UseTextOptions = True
		Me.colHargaRp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colHargaRp.Caption = "Price"
		Me.colHargaRp.DisplayFormat.FormatString = "n0"
		Me.colHargaRp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHargaRp.FieldName = "HargaKurs"
		Me.colHargaRp.Name = "colHargaRp"
		Me.colHargaRp.OptionsColumn.AllowEdit = False
		Me.colHargaRp.OptionsColumn.ReadOnly = True
		Me.colHargaRp.Visible = True
		Me.colHargaRp.VisibleIndex = 11
		Me.colHargaRp.Width = 90
		'
		'colTotal
		'
		Me.colTotal.AppearanceCell.Options.UseTextOptions = True
		Me.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colTotal.AppearanceHeader.Options.UseTextOptions = True
		Me.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colTotal.Caption = "Total"
		Me.colTotal.DisplayFormat.FormatString = "n0"
		Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colTotal.FieldName = "SubTotal"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.OptionsColumn.AllowEdit = False
		Me.colTotal.OptionsColumn.ReadOnly = True
		Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colTotal.Visible = True
		Me.colTotal.VisibleIndex = 12
		Me.colTotal.Width = 100
		'
		'colCatatan
		'
		Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
		Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
		Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colCatatan.Caption = "Remarks"
		Me.colCatatan.FieldName = "Catatan"
		Me.colCatatan.Name = "colCatatan"
		Me.colCatatan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colCatatan.Visible = True
		Me.colCatatan.VisibleIndex = 13
		Me.colCatatan.Width = 170
		'
		'txtOthers
		'
		Me.txtOthers.EnterMoveNextControl = True
		Me.txtOthers.Location = New System.Drawing.Point(558, 154)
		Me.txtOthers.MenuManager = Me.barMan
		Me.txtOthers.Name = "txtOthers"
		Me.txtOthers.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtOthers.Properties.MaxLength = 255
		Me.txtOthers.Size = New System.Drawing.Size(558, 20)
		Me.txtOthers.StyleController = Me.lytTransaksi
		Me.txtOthers.TabIndex = 16
		'
		'txtKontak
		'
		Me.txtKontak.EnterMoveNextControl = True
		Me.txtKontak.Location = New System.Drawing.Point(92, 37)
		Me.txtKontak.MenuManager = Me.barMan
		Me.txtKontak.Name = "txtKontak"
		Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtKontak.Properties.DisplayMember = "Kode"
		Me.txtKontak.Properties.NullText = "<Pilih Customer>"
		Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
		Me.txtKontak.Properties.ShowClearButton = False
		Me.txtKontak.Properties.ShowFooter = False
		Me.txtKontak.Properties.ValueMember = "This"
		Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
		Me.txtKontak.Size = New System.Drawing.Size(160, 20)
		Me.txtKontak.StyleController = Me.lytTransaksi
		Me.txtKontak.TabIndex = 0
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
		'txtAlamatText
		'
		Me.txtAlamatText.EnterMoveNextControl = True
		Me.txtAlamatText.Location = New System.Drawing.Point(17, 130)
		Me.txtAlamatText.MenuManager = Me.barMan
		Me.txtAlamatText.Name = "txtAlamatText"
		Me.txtAlamatText.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtAlamatText.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtAlamatText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtAlamatText.Properties.ReadOnly = True
		Me.txtAlamatText.Size = New System.Drawing.Size(235, 68)
		Me.txtAlamatText.StyleController = Me.lytTransaksi
		Me.txtAlamatText.TabIndex = 12
		'
		'txtAlamat
		'
		Me.txtAlamat.EnterMoveNextControl = True
		Me.txtAlamat.Location = New System.Drawing.Point(74, 106)
		Me.txtAlamat.MenuManager = Me.barMan
		Me.txtAlamat.Name = "txtAlamat"
		Me.txtAlamat.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtAlamat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtAlamat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtAlamat.Properties.DisplayMember = "Kode"
		Me.txtAlamat.Properties.NullText = "<Pilih Alamat>"
		Me.txtAlamat.Properties.ShowClearButton = False
		Me.txtAlamat.Properties.ShowFooter = False
		Me.txtAlamat.Properties.ValueMember = "This"
		Me.txtAlamat.Properties.View = Me.GridView2
		Me.txtAlamat.Size = New System.Drawing.Size(178, 20)
		Me.txtAlamat.StyleController = Me.lytTransaksi
		Me.txtAlamat.TabIndex = 7
		'
		'GridView2
		'
		Me.GridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
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
		Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
		Me.GridColumn3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.GridColumn3.Caption = "Kode"
		Me.GridColumn3.FieldName = "Kode"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 0
		Me.GridColumn3.Width = 355
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Alamat"
		Me.GridColumn4.FieldName = "Alamat"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 1
		Me.GridColumn4.Width = 723
		'
		'txtKurs
		'
		Me.txtKurs.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtKurs.EnterMoveNextControl = True
		Me.txtKurs.Location = New System.Drawing.Point(958, 178)
		Me.txtKurs.MenuManager = Me.barMan
		Me.txtKurs.Name = "txtKurs"
		Me.txtKurs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtKurs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtKurs.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.txtKurs.Properties.MaxLength = 255
		Me.txtKurs.Size = New System.Drawing.Size(158, 20)
		Me.txtKurs.StyleController = Me.lytTransaksi
		Me.txtKurs.TabIndex = 19
		'
		'layoutControlGroup1
		'
		Me.layoutControlGroup1.CustomizationFormText = "Root"
		Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.layoutControlGroup1.GroupBordersVisible = False
		Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlGroup3, Me.LayoutControlItem3, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem12, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem13})
		Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.layoutControlGroup1.Name = "Root"
		Me.layoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
		Me.layoutControlGroup1.Text = "Root"
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.xGrid
		Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 190)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(1108, 225)
		Me.LayoutControlItem7.Text = "LayoutControlItem7"
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem7.TextToControlDistance = 0
		Me.LayoutControlItem7.TextVisible = False
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
		Me.layKontak.AppearanceItemCaption.Options.UseFont = True
		Me.layKontak.Control = Me.txtKontak
		Me.layKontak.CustomizationFormText = "Customer"
		Me.layKontak.Location = New System.Drawing.Point(0, 0)
		Me.layKontak.Name = "layKontak"
		Me.layKontak.Size = New System.Drawing.Size(238, 24)
		Me.layKontak.Text = "Customer"
		Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.layKontak.TextSize = New System.Drawing.Size(69, 13)
		Me.layKontak.TextToControlDistance = 5
		'
		'LayoutControlItem15
		'
		Me.LayoutControlItem15.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem15.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem15.Control = Me.txtTanggal
		Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
		Me.LayoutControlItem15.Location = New System.Drawing.Point(634, 0)
		Me.LayoutControlItem15.Name = "LayoutControlItem15"
		Me.LayoutControlItem15.Size = New System.Drawing.Size(233, 24)
		Me.LayoutControlItem15.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem15.Text = "Tanggal Reff"
		Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem15.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem15.TextToControlDistance = 5
		'
		'LayoutControlItem16
		'
		Me.LayoutControlItem16.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem16.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem16.Control = Me.txtNoTransaksi
		Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
		Me.LayoutControlItem16.Location = New System.Drawing.Point(867, 0)
		Me.LayoutControlItem16.Name = "LayoutControlItem16"
		Me.LayoutControlItem16.Size = New System.Drawing.Size(199, 24)
		Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem16.Text = "Reff No."
		Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem16.TextSize = New System.Drawing.Size(43, 13)
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
		Me.LayoutControlItem1.Control = Me.txtKontakPerson
		Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(238, 24)
		Me.LayoutControlItem1.Text = "Kontak Person"
		Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
		Me.LayoutControlItem1.TextToControlDistance = 5
		'
		'lytRegional
		'
		Me.lytRegional.Control = Me.txtRegional
		Me.lytRegional.CustomizationFormText = "Regional"
		Me.lytRegional.Location = New System.Drawing.Point(634, 24)
		Me.lytRegional.Name = "lytRegional"
		Me.lytRegional.Size = New System.Drawing.Size(233, 24)
		Me.lytRegional.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.lytRegional.Text = "Regional"
		Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.lytRegional.TextSize = New System.Drawing.Size(75, 13)
		Me.lytRegional.TextToControlDistance = 5
		'
		'LayoutControlItem14
		'
		Me.LayoutControlItem14.Control = Me.txtStatus
		Me.LayoutControlItem14.CustomizationFormText = "Status"
		Me.LayoutControlItem14.Location = New System.Drawing.Point(867, 24)
		Me.LayoutControlItem14.Name = "LayoutControlItem14"
		Me.LayoutControlItem14.Size = New System.Drawing.Size(199, 24)
		Me.LayoutControlItem14.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem14.Text = "Status"
		Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem14.TextSize = New System.Drawing.Size(43, 13)
		Me.LayoutControlItem14.TextToControlDistance = 5
		'
		'EmptySpaceItem3
		'
		Me.EmptySpaceItem3.AllowHotTrack = False
		Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Location = New System.Drawing.Point(454, 0)
		Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Size = New System.Drawing.Size(180, 48)
		Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
		Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem20
		'
		Me.LayoutControlItem20.Control = Me.lblKontakNama
		Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
		Me.LayoutControlItem20.Location = New System.Drawing.Point(238, 0)
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
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(238, 24)
		Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtOthers
		Me.LayoutControlItem3.CustomizationFormText = "Uraian"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(451, 142)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(657, 24)
		Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem3.Text = "Others"
		Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
		Me.LayoutControlItem3.TextToControlDistance = 5
		'
		'LayoutControlItem21
		'
		Me.LayoutControlItem21.Control = Me.txtAlamat
		Me.LayoutControlItem21.CustomizationFormText = "Alamat"
		Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 94)
		Me.LayoutControlItem21.Name = "LayoutControlItem21"
		Me.LayoutControlItem21.Size = New System.Drawing.Size(244, 24)
		Me.LayoutControlItem21.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem21.Text = "Alamat"
		Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem21.TextSize = New System.Drawing.Size(52, 13)
		Me.LayoutControlItem21.TextToControlDistance = 5
		'
		'LayoutControlItem22
		'
		Me.LayoutControlItem22.Control = Me.txtAlamatText
		Me.LayoutControlItem22.CustomizationFormText = "Alamat Text"
		Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 118)
		Me.LayoutControlItem22.Name = "LayoutControlItem22"
		Me.LayoutControlItem22.Size = New System.Drawing.Size(244, 72)
		Me.LayoutControlItem22.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem22.Text = "Alamat Text"
		Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem22.TextToControlDistance = 0
		Me.LayoutControlItem22.TextVisible = False
		'
		'LayoutControlItem12
		'
		Me.LayoutControlItem12.Control = Me.txtTermin
		Me.LayoutControlItem12.CustomizationFormText = "Termin"
		Me.LayoutControlItem12.Location = New System.Drawing.Point(451, 118)
		Me.LayoutControlItem12.Name = "LayoutControlItem12"
		Me.LayoutControlItem12.Size = New System.Drawing.Size(209, 24)
		Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem12.Text = "Term of Price"
		Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem12.TextSize = New System.Drawing.Size(85, 13)
		Me.LayoutControlItem12.TextToControlDistance = 5
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtTermPrice
		Me.LayoutControlItem5.CustomizationFormText = "Lead Time"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(451, 94)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(209, 24)
		Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem5.Text = "Term of Price"
		Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(85, 13)
		Me.LayoutControlItem5.TextToControlDistance = 5
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtPayment
		Me.LayoutControlItem2.CustomizationFormText = "Payment"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(660, 94)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(225, 24)
		Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem2.Text = "Term of Payment"
		Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(55, 13)
		Me.LayoutControlItem2.TextToControlDistance = 5
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtInspection
		Me.LayoutControlItem4.CustomizationFormText = "Inspection"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(660, 118)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(225, 24)
		Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem4.Text = "Validity"
		Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(55, 13)
		Me.LayoutControlItem4.TextToControlDistance = 5
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem8.Control = Me.txtUang
		Me.LayoutControlItem8.CustomizationFormText = "Uang"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(661, 166)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(225, 24)
		Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem8.Text = "Currency"
		Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(85, 13)
		Me.LayoutControlItem8.TextToControlDistance = 5
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtValidiity1
		Me.LayoutControlItem6.CustomizationFormText = "Tgl Berlaku"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(885, 94)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(223, 24)
		Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem6.Text = "Period"
		Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(45, 13)
		Me.LayoutControlItem6.TextToControlDistance = 5
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtValidiity2
		Me.LayoutControlItem9.CustomizationFormText = "s/d"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(885, 118)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(223, 24)
		Me.LayoutControlItem9.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem9.Text = "s/d"
		Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(45, 13)
		Me.LayoutControlItem9.TextToControlDistance = 5
		'
		'LayoutControlItem10
		'
		Me.LayoutControlItem10.Control = Me.txtKurs
		Me.LayoutControlItem10.CustomizationFormText = "Kurs"
		Me.LayoutControlItem10.Location = New System.Drawing.Point(886, 166)
		Me.LayoutControlItem10.Name = "LayoutControlItem10"
		Me.LayoutControlItem10.Size = New System.Drawing.Size(222, 24)
		Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem10.Text = "Kurs"
		Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem10.TextSize = New System.Drawing.Size(50, 20)
		Me.LayoutControlItem10.TextToControlDistance = 5
		'
		'LayoutControlItem11
		'
		Me.LayoutControlItem11.Control = Me.txtYourReff
		Me.LayoutControlItem11.CustomizationFormText = "Your Reff"
		Me.LayoutControlItem11.Location = New System.Drawing.Point(451, 166)
		Me.LayoutControlItem11.Name = "LayoutControlItem11"
		Me.LayoutControlItem11.Size = New System.Drawing.Size(210, 24)
		Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem11.Text = "Term of Delivery"
		Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem11.TextSize = New System.Drawing.Size(85, 20)
		Me.LayoutControlItem11.TextToControlDistance = 5
		'
		'LayoutControlItem13
		'
		Me.LayoutControlItem13.Control = Me.txtCatatan
		Me.LayoutControlItem13.CustomizationFormText = "Catatan"
		Me.LayoutControlItem13.Location = New System.Drawing.Point(244, 94)
		Me.LayoutControlItem13.Name = "LayoutControlItem13"
		Me.LayoutControlItem13.Size = New System.Drawing.Size(207, 96)
		Me.LayoutControlItem13.Text = "Catatan"
		Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem13.TextSize = New System.Drawing.Size(39, 13)
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
		'btnImpor
		'
		Me.btnImpor.Caption = "Impor"
		Me.btnImpor.Glyph = CType(resources.GetObject("btnImpor.Glyph"), System.Drawing.Image)
		Me.btnImpor.Id = 6
		Me.btnImpor.LargeGlyph = CType(resources.GetObject("btnImpor.LargeGlyph"), System.Drawing.Image)
		Me.btnImpor.Name = "btnImpor"
		'
		'btnDownload
		'
		Me.btnDownload.Caption = "Download Template Impor"
		Me.btnDownload.Glyph = CType(resources.GetObject("btnDownload.Glyph"), System.Drawing.Image)
		Me.btnDownload.Id = 7
		Me.btnDownload.LargeGlyph = CType(resources.GetObject("btnDownload.LargeGlyph"), System.Drawing.Image)
		Me.btnDownload.Name = "btnDownload"
		'
		'UI_Fusoh_SQDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1134, 468)
		Me.Controls.Add(Me.hideContainerRight)
		Me.KeyPreview = True
		Me.Name = "UI_Fusoh_SQDialog"
		Me.Text = "Penawaran Penjualan [SQ]"
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
		CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtYourReff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtValidiity2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtValidiity2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtInspection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtValidiity1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtValidiity1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTermPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colPartRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtOthers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAlamatText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
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
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents txtOthers As DevExpress.XtraEditors.TextEdit
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
	Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
	Friend WithEvents colMaterial As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	Friend WithEvents txtKontakPerson As DevExpress.XtraEditors.LookUpEdit
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
	Friend WithEvents txtTermPrice As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtValidiity1 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtTermin As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
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
	Friend WithEvents colHargaRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
	Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtAlamatText As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
	Friend WithEvents txtAlamat As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtInspection As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtPayment As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtValidiity2 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtKurs As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents colOD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colInD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colThickness As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHargaRp As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
	Friend WithEvents txtYourReff As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colNoPart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPartRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents txtCatatan As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colProcessingPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImpor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDownload As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
End Class
