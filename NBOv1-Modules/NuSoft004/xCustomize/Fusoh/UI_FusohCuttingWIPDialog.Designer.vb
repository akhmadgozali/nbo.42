<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohCuttingWIPDialog
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohCuttingWIPDialog))
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
		Me.txtSisaQty = New DevExpress.XtraEditors.SpinEdit()
		Me.txtCuttingQty = New DevExpress.XtraEditors.SpinEdit()
		Me.txtRMDibutuhkan = New DevExpress.XtraEditors.TextEdit()
		Me.txtCutting = New DevExpress.XtraEditors.TextEdit()
		Me.txtGudang = New DevExpress.XtraEditors.TextEdit()
		Me.txtLength = New DevExpress.XtraEditors.TextEdit()
		Me.txtSize = New DevExpress.XtraEditors.TextEdit()
		Me.txtPartNo = New DevExpress.XtraEditors.TextEdit()
		Me.txtMaterial = New DevExpress.XtraEditors.TextEdit()
		Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
		Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
		Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colCommand = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCommandRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colInD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMillSheet = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSN = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthSN = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMaterialLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colScrap = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
		Me.colKodeRepoView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colSNRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtQtyDempyou = New DevExpress.XtraEditors.SpinEdit()
		Me.txtCuttingNomorLot = New DevExpress.XtraEditors.TextEdit()
		Me.txtNoPO = New DevExpress.XtraEditors.TextEdit()
		Me.txtPOLine = New DevExpress.XtraEditors.TextEdit()
		Me.txtDempyou = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKodeDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNomorLot = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtCuttingMesin = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtCuttingShift = New DevExpress.XtraEditors.SpinEdit()
		Me.txtCuttingProcess = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtCuttingOP = New DevExpress.XtraEditors.ComboBoxEdit()
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
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.lblKontakNama = New DevExpress.XtraLayout.SimpleLabelItem()
		Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
		Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
		Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
		Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
		Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
		Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
		Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.btnAmbilUlangSN = New DevExpress.XtraBars.BarButtonItem()
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
		CType(Me.txtSisaQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCuttingQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRMDibutuhkan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCutting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtLength.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colCommandRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeRepoView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSNRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQtyDempyou.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCuttingNomorLot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPOLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDempyou.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCuttingMesin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCuttingShift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCuttingProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCuttingOP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblKontakNama, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAmbilUlangSN})
		Me.barMan.MaxItemId = 7
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAmbilUlangSN)})
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
		Me.hideContainerRight.Size = New System.Drawing.Size(19, 462)
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
		Me.DockPanel2.OriginalSize = New System.Drawing.Size(1128, 456)
		Me.DockPanel2.Text = "DockPanel2"
		'
		'DockPanel2_Container
		'
		Me.DockPanel2_Container.Controls.Add(Me.lytTransaksi)
		Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
		Me.DockPanel2_Container.Name = "DockPanel2_Container"
		Me.DockPanel2_Container.Size = New System.Drawing.Size(1128, 456)
		Me.DockPanel2_Container.TabIndex = 0
		'
		'lytTransaksi
		'
		Me.lytTransaksi.Controls.Add(Me.txtSisaQty)
		Me.lytTransaksi.Controls.Add(Me.txtCuttingQty)
		Me.lytTransaksi.Controls.Add(Me.txtRMDibutuhkan)
		Me.lytTransaksi.Controls.Add(Me.txtCutting)
		Me.lytTransaksi.Controls.Add(Me.txtGudang)
		Me.lytTransaksi.Controls.Add(Me.txtLength)
		Me.lytTransaksi.Controls.Add(Me.txtSize)
		Me.lytTransaksi.Controls.Add(Me.txtPartNo)
		Me.lytTransaksi.Controls.Add(Me.txtMaterial)
		Me.lytTransaksi.Controls.Add(Me.txtStatus)
		Me.lytTransaksi.Controls.Add(Me.txtRegional)
		Me.lytTransaksi.Controls.Add(Me.txtTanggal)
		Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
		Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
		Me.lytTransaksi.Controls.Add(Me.xGrid)
		Me.lytTransaksi.Controls.Add(Me.txtKontak)
		Me.lytTransaksi.Controls.Add(Me.txtQtyDempyou)
		Me.lytTransaksi.Controls.Add(Me.txtCuttingNomorLot)
		Me.lytTransaksi.Controls.Add(Me.txtNoPO)
		Me.lytTransaksi.Controls.Add(Me.txtPOLine)
		Me.lytTransaksi.Controls.Add(Me.txtDempyou)
		Me.lytTransaksi.Controls.Add(Me.txtCuttingMesin)
		Me.lytTransaksi.Controls.Add(Me.txtCuttingShift)
		Me.lytTransaksi.Controls.Add(Me.txtCuttingProcess)
		Me.lytTransaksi.Controls.Add(Me.txtCuttingOP)
		Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksi.Name = "lytTransaksi"
		Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(732, 187, 250, 350)
		Me.lytTransaksi.Root = Me.layoutControlGroup1
		Me.lytTransaksi.Size = New System.Drawing.Size(1128, 456)
		Me.lytTransaksi.TabIndex = 0
		Me.lytTransaksi.Text = "lytTransaksi"
		'
		'txtSisaQty
		'
		Me.txtSisaQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtSisaQty.Location = New System.Drawing.Point(435, 197)
		Me.txtSisaQty.MenuManager = Me.barMan
		Me.txtSisaQty.Name = "txtSisaQty"
		Me.txtSisaQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtSisaQty.Properties.Appearance.Options.UseBackColor = True
		Me.txtSisaQty.Properties.Appearance.Options.UseTextOptions = True
		Me.txtSisaQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtSisaQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtSisaQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtSisaQty.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtSisaQty.Properties.Mask.EditMask = "n0"
		Me.txtSisaQty.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtSisaQty.Properties.ReadOnly = True
		Me.txtSisaQty.Size = New System.Drawing.Size(187, 20)
		Me.txtSisaQty.StyleController = Me.lytTransaksi
		Me.txtSisaQty.TabIndex = 15
		'
		'txtCuttingQty
		'
		Me.txtCuttingQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtCuttingQty.Location = New System.Drawing.Point(741, 209)
		Me.txtCuttingQty.MenuManager = Me.barMan
		Me.txtCuttingQty.Name = "txtCuttingQty"
		Me.txtCuttingQty.Properties.Appearance.Options.UseTextOptions = True
		Me.txtCuttingQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtCuttingQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCuttingQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCuttingQty.Size = New System.Drawing.Size(223, 20)
		Me.txtCuttingQty.StyleController = Me.lytTransaksi
		Me.txtCuttingQty.TabIndex = 22
		'
		'txtRMDibutuhkan
		'
		Me.txtRMDibutuhkan.Location = New System.Drawing.Point(435, 245)
		Me.txtRMDibutuhkan.MenuManager = Me.barMan
		Me.txtRMDibutuhkan.Name = "txtRMDibutuhkan"
		Me.txtRMDibutuhkan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtRMDibutuhkan.Properties.Appearance.Options.UseBackColor = True
		Me.txtRMDibutuhkan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRMDibutuhkan.Properties.DisplayFormat.FormatString = "n0"
		Me.txtRMDibutuhkan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtRMDibutuhkan.Properties.ReadOnly = True
		Me.txtRMDibutuhkan.Size = New System.Drawing.Size(187, 20)
		Me.txtRMDibutuhkan.StyleController = Me.lytTransaksi
		Me.txtRMDibutuhkan.TabIndex = 17
		'
		'txtCutting
		'
		Me.txtCutting.Location = New System.Drawing.Point(435, 221)
		Me.txtCutting.MenuManager = Me.barMan
		Me.txtCutting.Name = "txtCutting"
		Me.txtCutting.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtCutting.Properties.Appearance.Options.UseBackColor = True
		Me.txtCutting.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCutting.Properties.DisplayFormat.FormatString = "n0"
		Me.txtCutting.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtCutting.Properties.Mask.EditMask = "n0"
		Me.txtCutting.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		Me.txtCutting.Properties.ReadOnly = True
		Me.txtCutting.Size = New System.Drawing.Size(187, 20)
		Me.txtCutting.StyleController = Me.lytTransaksi
		Me.txtCutting.TabIndex = 16
		'
		'txtGudang
		'
		Me.txtGudang.Location = New System.Drawing.Point(385, 131)
		Me.txtGudang.MenuManager = Me.barMan
		Me.txtGudang.Name = "txtGudang"
		Me.txtGudang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtGudang.Properties.Appearance.Options.UseBackColor = True
		Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtGudang.Properties.ReadOnly = True
		Me.txtGudang.Size = New System.Drawing.Size(121, 20)
		Me.txtGudang.StyleController = Me.lytTransaksi
		Me.txtGudang.TabIndex = 8
		'
		'txtLength
		'
		Me.txtLength.EnterMoveNextControl = True
		Me.txtLength.Location = New System.Drawing.Point(459, 173)
		Me.txtLength.MenuManager = Me.barMan
		Me.txtLength.Name = "txtLength"
		Me.txtLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtLength.Properties.Appearance.Options.UseBackColor = True
		Me.txtLength.Properties.Appearance.Options.UseTextOptions = True
		Me.txtLength.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtLength.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtLength.Properties.ReadOnly = True
		Me.txtLength.Size = New System.Drawing.Size(78, 20)
		Me.txtLength.StyleController = Me.lytTransaksi
		Me.txtLength.TabIndex = 13
		'
		'txtSize
		'
		Me.txtSize.EnterMoveNextControl = True
		Me.txtSize.Location = New System.Drawing.Point(342, 173)
		Me.txtSize.MenuManager = Me.barMan
		Me.txtSize.Name = "txtSize"
		Me.txtSize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtSize.Properties.Appearance.Options.UseBackColor = True
		Me.txtSize.Properties.Appearance.Options.UseTextOptions = True
		Me.txtSize.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtSize.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtSize.Properties.ReadOnly = True
		Me.txtSize.Size = New System.Drawing.Size(108, 20)
		Me.txtSize.StyleController = Me.lytTransaksi
		Me.txtSize.TabIndex = 12
		'
		'txtPartNo
		'
		Me.txtPartNo.EnterMoveNextControl = True
		Me.txtPartNo.Location = New System.Drawing.Point(18, 173)
		Me.txtPartNo.MenuManager = Me.barMan
		Me.txtPartNo.Name = "txtPartNo"
		Me.txtPartNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtPartNo.Properties.Appearance.Options.UseBackColor = True
		Me.txtPartNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtPartNo.Properties.ReadOnly = True
		Me.txtPartNo.Size = New System.Drawing.Size(131, 20)
		Me.txtPartNo.StyleController = Me.lytTransaksi
		Me.txtPartNo.TabIndex = 10
		'
		'txtMaterial
		'
		Me.txtMaterial.EditValue = ""
		Me.txtMaterial.EnterMoveNextControl = True
		Me.txtMaterial.Location = New System.Drawing.Point(158, 173)
		Me.txtMaterial.MenuManager = Me.barMan
		Me.txtMaterial.Name = "txtMaterial"
		Me.txtMaterial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtMaterial.Properties.Appearance.Options.UseBackColor = True
		Me.txtMaterial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMaterial.Properties.ReadOnly = True
		Me.txtMaterial.Size = New System.Drawing.Size(175, 20)
		Me.txtMaterial.StyleController = Me.lytTransaksi
		Me.txtMaterial.TabIndex = 11
		'
		'txtStatus
		'
		Me.txtStatus.EnterMoveNextControl = True
		Me.txtStatus.Location = New System.Drawing.Point(931, 61)
		Me.txtStatus.MenuManager = Me.barMan
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
		Me.txtStatus.Properties.DisplayMember = "Value"
		Me.txtStatus.Properties.NullText = "<Status>"
		Me.txtStatus.Properties.ValueMember = "Key"
		Me.txtStatus.Size = New System.Drawing.Size(149, 20)
		Me.txtStatus.StyleController = Me.lytTransaksi
		Me.txtStatus.TabIndex = 6
		'
		'txtRegional
		'
		Me.txtRegional.EnterMoveNextControl = True
		Me.txtRegional.Location = New System.Drawing.Point(727, 61)
		Me.txtRegional.MenuManager = Me.barMan
		Me.txtRegional.Name = "txtRegional"
		Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
		Me.txtRegional.Properties.DisplayMember = "Nama"
		Me.txtRegional.Properties.NullText = "<Pilih Regional>"
		Me.txtRegional.Properties.ValueMember = "This"
		Me.txtRegional.Size = New System.Drawing.Size(147, 20)
		Me.txtRegional.StyleController = Me.lytTransaksi
		Me.txtRegional.TabIndex = 5
		'
		'txtTanggal
		'
		Me.txtTanggal.EditValue = Nothing
		Me.txtTanggal.EnterMoveNextControl = True
		Me.txtTanggal.Location = New System.Drawing.Point(727, 37)
		Me.txtTanggal.MenuManager = Me.barMan
		Me.txtTanggal.Name = "txtTanggal"
		Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal.Size = New System.Drawing.Size(147, 20)
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
		Me.txtNoTransaksi.Location = New System.Drawing.Point(931, 37)
		Me.txtNoTransaksi.MenuManager = Me.barMan
		Me.txtNoTransaksi.Name = "txtNoTransaksi"
		Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoTransaksi.Size = New System.Drawing.Size(149, 20)
		Me.txtNoTransaksi.StyleController = Me.lytTransaksi
		Me.txtNoTransaksi.TabIndex = 2
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 291)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.MenuManager = Me.barMan
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpekRepo, Me.colKodeRepo, Me.colSNRepo, Me.colCommandRepo})
		Me.xGrid.Size = New System.Drawing.Size(1104, 153)
		Me.xGrid.TabIndex = 24
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
		Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.xGridView.ColumnPanelRowHeight = 30
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommand, Me.colKodeBarang, Me.colNamaBarang, Me.colOD, Me.colInD, Me.colThickness, Me.colLength, Me.colMillSheet, Me.colSN, Me.colLengthSN, Me.colMaterialLength, Me.colQty, Me.colWeight, Me.colScrap, Me.colCatatan})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colCommand
		'
		Me.colCommand.ColumnEdit = Me.colCommandRepo
		Me.colCommand.Name = "colCommand"
		Me.colCommand.Visible = True
		Me.colCommand.VisibleIndex = 0
		Me.colCommand.Width = 20
		'
		'colCommandRepo
		'
		Me.colCommandRepo.AutoHeight = False
		Me.colCommandRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
		Me.colCommandRepo.Name = "colCommandRepo"
		Me.colCommandRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
		'
		'colKodeBarang
		'
		Me.colKodeBarang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colKodeBarang.AppearanceCell.Options.UseBackColor = True
		Me.colKodeBarang.AppearanceHeader.Options.UseTextOptions = True
		Me.colKodeBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colKodeBarang.Caption = "Part No."
		Me.colKodeBarang.FieldName = "Barang.Kode"
		Me.colKodeBarang.Name = "colKodeBarang"
		Me.colKodeBarang.OptionsColumn.AllowEdit = False
		Me.colKodeBarang.OptionsColumn.ReadOnly = True
		Me.colKodeBarang.Visible = True
		Me.colKodeBarang.VisibleIndex = 1
		Me.colKodeBarang.Width = 110
		'
		'colNamaBarang
		'
		Me.colNamaBarang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colNamaBarang.AppearanceCell.Options.UseBackColor = True
		Me.colNamaBarang.AppearanceCell.Options.UseTextOptions = True
		Me.colNamaBarang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colNamaBarang.AppearanceHeader.Options.UseTextOptions = True
		Me.colNamaBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colNamaBarang.Caption = "Material"
		Me.colNamaBarang.FieldName = "Barang.Nama"
		Me.colNamaBarang.Name = "colNamaBarang"
		Me.colNamaBarang.OptionsColumn.AllowEdit = False
		Me.colNamaBarang.OptionsColumn.ReadOnly = True
		Me.colNamaBarang.Visible = True
		Me.colNamaBarang.VisibleIndex = 2
		Me.colNamaBarang.Width = 110
		'
		'colOD
		'
		Me.colOD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colOD.AppearanceCell.Options.UseBackColor = True
		Me.colOD.AppearanceCell.Options.UseTextOptions = True
		Me.colOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colOD.AppearanceHeader.Options.UseTextOptions = True
		Me.colOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colOD.Caption = "OD"
		Me.colOD.DisplayFormat.FormatString = "n1"
		Me.colOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colOD.FieldName = "Barang.OutDiameter"
		Me.colOD.Name = "colOD"
		Me.colOD.OptionsColumn.AllowEdit = False
		Me.colOD.OptionsColumn.ReadOnly = True
		Me.colOD.Visible = True
		Me.colOD.VisibleIndex = 3
		Me.colOD.Width = 51
		'
		'colInD
		'
		Me.colInD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colInD.AppearanceCell.Options.UseBackColor = True
		Me.colInD.AppearanceCell.Options.UseTextOptions = True
		Me.colInD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colInD.AppearanceHeader.Options.UseTextOptions = True
		Me.colInD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colInD.Caption = "ID"
		Me.colInD.DisplayFormat.FormatString = "n1"
		Me.colInD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colInD.FieldName = "Barang.InDiameter"
		Me.colInD.Name = "colInD"
		Me.colInD.OptionsColumn.AllowEdit = False
		Me.colInD.OptionsColumn.ReadOnly = True
		Me.colInD.Visible = True
		Me.colInD.VisibleIndex = 4
		Me.colInD.Width = 51
		'
		'colThickness
		'
		Me.colThickness.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colThickness.AppearanceCell.Options.UseBackColor = True
		Me.colThickness.AppearanceCell.Options.UseTextOptions = True
		Me.colThickness.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colThickness.AppearanceHeader.Options.UseTextOptions = True
		Me.colThickness.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colThickness.Caption = "T"
		Me.colThickness.DisplayFormat.FormatString = "n1"
		Me.colThickness.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colThickness.FieldName = "Barang.Thickness"
		Me.colThickness.Name = "colThickness"
		Me.colThickness.OptionsColumn.AllowEdit = False
		Me.colThickness.OptionsColumn.ReadOnly = True
		Me.colThickness.Visible = True
		Me.colThickness.VisibleIndex = 5
		Me.colThickness.Width = 51
		'
		'colLength
		'
		Me.colLength.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colLength.AppearanceCell.Options.UseBackColor = True
		Me.colLength.AppearanceCell.Options.UseTextOptions = True
		Me.colLength.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLength.AppearanceHeader.Options.UseTextOptions = True
		Me.colLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLength.Caption = "L"
		Me.colLength.DisplayFormat.FormatString = "n1"
		Me.colLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLength.FieldName = "Barang.Length"
		Me.colLength.Name = "colLength"
		Me.colLength.OptionsColumn.AllowEdit = False
		Me.colLength.OptionsColumn.ReadOnly = True
		Me.colLength.Visible = True
		Me.colLength.VisibleIndex = 6
		Me.colLength.Width = 51
		'
		'colMillSheet
		'
		Me.colMillSheet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colMillSheet.AppearanceCell.Options.UseBackColor = True
		Me.colMillSheet.AppearanceHeader.Options.UseTextOptions = True
		Me.colMillSheet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colMillSheet.Caption = "Millsheet"
		Me.colMillSheet.FieldName = "Millsheet"
		Me.colMillSheet.Name = "colMillSheet"
		Me.colMillSheet.OptionsColumn.AllowEdit = False
		Me.colMillSheet.OptionsColumn.ReadOnly = True
		Me.colMillSheet.Visible = True
		Me.colMillSheet.VisibleIndex = 7
		Me.colMillSheet.Width = 104
		'
		'colSN
		'
		Me.colSN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colSN.AppearanceCell.Options.UseBackColor = True
		Me.colSN.AppearanceHeader.Options.UseTextOptions = True
		Me.colSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colSN.Caption = "SN"
		Me.colSN.FieldName = "Serial"
		Me.colSN.Name = "colSN"
		Me.colSN.OptionsColumn.AllowEdit = False
		Me.colSN.OptionsColumn.ReadOnly = True
		Me.colSN.Visible = True
		Me.colSN.VisibleIndex = 8
		Me.colSN.Width = 92
		'
		'colLengthSN
		'
		Me.colLengthSN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colLengthSN.AppearanceCell.Options.UseBackColor = True
		Me.colLengthSN.AppearanceCell.Options.UseTextOptions = True
		Me.colLengthSN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colLengthSN.AppearanceHeader.Options.UseTextOptions = True
		Me.colLengthSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLengthSN.Caption = "Length Dempyou"
		Me.colLengthSN.DisplayFormat.FormatString = "n0"
		Me.colLengthSN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLengthSN.FieldName = "SNLength"
		Me.colLengthSN.Name = "colLengthSN"
		Me.colLengthSN.OptionsColumn.AllowEdit = False
		Me.colLengthSN.OptionsColumn.ReadOnly = True
		Me.colLengthSN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SNLength", "{0:n0}")})
		Me.colLengthSN.ToolTip = "Length yang diminta pada Dempyou - Length Produksi yang sudah diproses"
		Me.colLengthSN.Visible = True
		Me.colLengthSN.VisibleIndex = 9
		Me.colLengthSN.Width = 88
		'
		'colMaterialLength
		'
		Me.colMaterialLength.Caption = "Length Produksi"
		Me.colMaterialLength.ColumnEdit = Me.colSpekRepo
		Me.colMaterialLength.DisplayFormat.FormatString = "n0"
		Me.colMaterialLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colMaterialLength.FieldName = "Length"
		Me.colMaterialLength.Name = "colMaterialLength"
		Me.colMaterialLength.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Length", "{0:n0}")})
		Me.colMaterialLength.ToolTip = "Nilai length serial yang akan diproduksi"
		Me.colMaterialLength.Visible = True
		Me.colMaterialLength.VisibleIndex = 10
		Me.colMaterialLength.Width = 86
		'
		'colSpekRepo
		'
		Me.colSpekRepo.AutoHeight = False
		Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colSpekRepo.Name = "colSpekRepo"
		'
		'colQty
		'
		Me.colQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colQty.AppearanceCell.Options.UseBackColor = True
		Me.colQty.AppearanceCell.Options.UseTextOptions = True
		Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colQty.AppearanceHeader.Options.UseTextOptions = True
		Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colQty.Caption = "Qty"
		Me.colQty.ColumnEdit = Me.colSpekRepo
		Me.colQty.DisplayFormat.FormatString = "n0"
		Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.OptionsColumn.AllowEdit = False
		Me.colQty.OptionsColumn.AllowSize = False
		Me.colQty.OptionsColumn.FixedWidth = True
		Me.colQty.OptionsColumn.ReadOnly = True
		Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 11
		Me.colQty.Width = 50
		'
		'colWeight
		'
		Me.colWeight.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colWeight.AppearanceCell.Options.UseBackColor = True
		Me.colWeight.AppearanceCell.Options.UseTextOptions = True
		Me.colWeight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colWeight.AppearanceHeader.Options.UseTextOptions = True
		Me.colWeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colWeight.Caption = "Total Weight"
		Me.colWeight.DisplayFormat.FormatString = "n1"
		Me.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colWeight.FieldName = "Weight"
		Me.colWeight.Name = "colWeight"
		Me.colWeight.OptionsColumn.AllowEdit = False
		Me.colWeight.OptionsColumn.ReadOnly = True
		Me.colWeight.Width = 55
		'
		'colScrap
		'
		Me.colScrap.AppearanceHeader.Options.UseTextOptions = True
		Me.colScrap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colScrap.Caption = "Scrap"
		Me.colScrap.FieldName = "Scrap"
		Me.colScrap.Name = "colScrap"
		Me.colScrap.Visible = True
		Me.colScrap.VisibleIndex = 12
		Me.colScrap.Width = 35
		'
		'colCatatan
		'
		Me.colCatatan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colCatatan.AppearanceCell.Options.UseBackColor = True
		Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
		Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
		Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colCatatan.Caption = "Remarks"
		Me.colCatatan.FieldName = "Catatan"
		Me.colCatatan.Name = "colCatatan"
		Me.colCatatan.OptionsColumn.AllowEdit = False
		Me.colCatatan.OptionsColumn.ReadOnly = True
		Me.colCatatan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colCatatan.Visible = True
		Me.colCatatan.VisibleIndex = 13
		Me.colCatatan.Width = 188
		'
		'colKodeRepo
		'
		Me.colKodeRepo.AutoHeight = False
		Me.colKodeRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colKodeRepo.DisplayMember = "Kode"
		Me.colKodeRepo.Name = "colKodeRepo"
		Me.colKodeRepo.NullText = "<Pilih Part No>"
		Me.colKodeRepo.ValueMember = "This"
		Me.colKodeRepo.View = Me.colKodeRepoView
		'
		'colKodeRepoView
		'
		Me.colKodeRepoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.colKodeRepoView.Name = "colKodeRepoView"
		Me.colKodeRepoView.OptionsFind.FindDelay = 500
		Me.colKodeRepoView.OptionsFind.SearchInPreview = True
		Me.colKodeRepoView.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.colKodeRepoView.OptionsView.ShowGroupPanel = False
		'
		'colSNRepo
		'
		Me.colSNRepo.AutoHeight = False
		Me.colSNRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.colSNRepo.Name = "colSNRepo"
		'
		'txtKontak
		'
		Me.txtKontak.EnterMoveNextControl = True
		Me.txtKontak.Location = New System.Drawing.Point(178, 37)
		Me.txtKontak.MenuManager = Me.barMan
		Me.txtKontak.Name = "txtKontak"
		Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtKontak.Properties.DisplayMember = "Nama"
		Me.txtKontak.Properties.NullText = "<Pilih Customer>"
		Me.txtKontak.Properties.ShowClearButton = False
		Me.txtKontak.Properties.ShowFooter = False
		Me.txtKontak.Properties.ValueMember = "This"
		Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
		Me.txtKontak.Size = New System.Drawing.Size(186, 20)
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
		'txtQtyDempyou
		'
		Me.txtQtyDempyou.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtQtyDempyou.Location = New System.Drawing.Point(541, 173)
		Me.txtQtyDempyou.MenuManager = Me.barMan
		Me.txtQtyDempyou.Name = "txtQtyDempyou"
		Me.txtQtyDempyou.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtQtyDempyou.Properties.Appearance.Options.UseBackColor = True
		Me.txtQtyDempyou.Properties.Appearance.Options.UseTextOptions = True
		Me.txtQtyDempyou.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtQtyDempyou.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtQtyDempyou.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtQtyDempyou.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtQtyDempyou.Properties.Mask.EditMask = "n0"
		Me.txtQtyDempyou.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtQtyDempyou.Properties.ReadOnly = True
		Me.txtQtyDempyou.Size = New System.Drawing.Size(81, 20)
		Me.txtQtyDempyou.StyleController = Me.lytTransaksi
		Me.txtQtyDempyou.TabIndex = 14
		'
		'txtCuttingNomorLot
		'
		Me.txtCuttingNomorLot.Location = New System.Drawing.Point(741, 161)
		Me.txtCuttingNomorLot.MenuManager = Me.barMan
		Me.txtCuttingNomorLot.Name = "txtCuttingNomorLot"
		Me.txtCuttingNomorLot.Properties.Appearance.BackColor = System.Drawing.Color.White
		Me.txtCuttingNomorLot.Properties.Appearance.Options.UseBackColor = True
		Me.txtCuttingNomorLot.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCuttingNomorLot.Size = New System.Drawing.Size(363, 20)
		Me.txtCuttingNomorLot.StyleController = Me.lytTransaksi
		Me.txtCuttingNomorLot.TabIndex = 20
		'
		'txtNoPO
		'
		Me.txtNoPO.EditValue = ""
		Me.txtNoPO.Location = New System.Drawing.Point(73, 131)
		Me.txtNoPO.MenuManager = Me.barMan
		Me.txtNoPO.Name = "txtNoPO"
		Me.txtNoPO.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtNoPO.Properties.Appearance.Options.UseBackColor = True
		Me.txtNoPO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoPO.Properties.ReadOnly = True
		Me.txtNoPO.Size = New System.Drawing.Size(260, 20)
		Me.txtNoPO.StyleController = Me.lytTransaksi
		Me.txtNoPO.TabIndex = 7
		'
		'txtPOLine
		'
		Me.txtPOLine.EditValue = ""
		Me.txtPOLine.Location = New System.Drawing.Point(561, 131)
		Me.txtPOLine.MenuManager = Me.barMan
		Me.txtPOLine.Name = "txtPOLine"
		Me.txtPOLine.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtPOLine.Properties.Appearance.Options.UseBackColor = True
		Me.txtPOLine.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtPOLine.Properties.ReadOnly = True
		Me.txtPOLine.Size = New System.Drawing.Size(61, 20)
		Me.txtPOLine.StyleController = Me.lytTransaksi
		Me.txtPOLine.TabIndex = 9
		'
		'txtDempyou
		'
		Me.txtDempyou.Location = New System.Drawing.Point(178, 61)
		Me.txtDempyou.MenuManager = Me.barMan
		Me.txtDempyou.Name = "txtDempyou"
		Me.txtDempyou.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtDempyou.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDempyou.Properties.DisplayMember = "Kode"
		Me.txtDempyou.Properties.NullText = "<Pilih Order Produksi [Dempyou]>"
		Me.txtDempyou.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
		Me.txtDempyou.Properties.ValueMember = "This"
		Me.txtDempyou.Properties.View = Me.GridView1
		Me.txtDempyou.Size = New System.Drawing.Size(186, 20)
		Me.txtDempyou.StyleController = Me.lytTransaksi
		Me.txtDempyou.TabIndex = 4
		'
		'GridView1
		'
		Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeDempyou, Me.colNomorLot})
		Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView1.OptionsView.ShowGroupPanel = False
		'
		'colKodeDempyou
		'
		Me.colKodeDempyou.Caption = "Kode"
		Me.colKodeDempyou.FieldName = "Kode"
		Me.colKodeDempyou.Name = "colKodeDempyou"
		Me.colKodeDempyou.Visible = True
		Me.colKodeDempyou.VisibleIndex = 0
		'
		'colNomorLot
		'
		Me.colNomorLot.Caption = "Nomor Lot"
		Me.colNomorLot.FieldName = "NomorLot"
		Me.colNomorLot.Name = "colNomorLot"
		Me.colNomorLot.Visible = True
		Me.colNomorLot.VisibleIndex = 1
		'
		'txtCuttingMesin
		'
		Me.txtCuttingMesin.Location = New System.Drawing.Point(741, 137)
		Me.txtCuttingMesin.MenuManager = Me.barMan
		Me.txtCuttingMesin.Name = "txtCuttingMesin"
		Me.txtCuttingMesin.Properties.Appearance.BackColor = System.Drawing.Color.White
		Me.txtCuttingMesin.Properties.Appearance.Options.UseBackColor = True
		Me.txtCuttingMesin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCuttingMesin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCuttingMesin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.txtCuttingMesin.Properties.DisplayMember = "Nama"
		Me.txtCuttingMesin.Properties.NullText = "[Pilih Mesin]"
		Me.txtCuttingMesin.Properties.ShowHeader = False
		Me.txtCuttingMesin.Properties.ValueMember = "This"
		Me.txtCuttingMesin.Size = New System.Drawing.Size(226, 20)
		Me.txtCuttingMesin.StyleController = Me.lytTransaksi
		Me.txtCuttingMesin.TabIndex = 18
		'
		'txtCuttingShift
		'
		Me.txtCuttingShift.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.txtCuttingShift.Location = New System.Drawing.Point(1031, 137)
		Me.txtCuttingShift.MenuManager = Me.barMan
		Me.txtCuttingShift.Name = "txtCuttingShift"
		Me.txtCuttingShift.Properties.Appearance.BackColor = System.Drawing.Color.White
		Me.txtCuttingShift.Properties.Appearance.Options.UseBackColor = True
		Me.txtCuttingShift.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCuttingShift.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCuttingShift.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtCuttingShift.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
		Me.txtCuttingShift.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.txtCuttingShift.Size = New System.Drawing.Size(73, 20)
		Me.txtCuttingShift.StyleController = Me.lytTransaksi
		Me.txtCuttingShift.TabIndex = 19
		'
		'txtCuttingProcess
		'
		Me.txtCuttingProcess.EditValue = ""
		Me.txtCuttingProcess.Location = New System.Drawing.Point(741, 185)
		Me.txtCuttingProcess.MenuManager = Me.barMan
		Me.txtCuttingProcess.Name = "txtCuttingProcess"
		Me.txtCuttingProcess.Properties.Appearance.BackColor = System.Drawing.Color.White
		Me.txtCuttingProcess.Properties.Appearance.Options.UseBackColor = True
		Me.txtCuttingProcess.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCuttingProcess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCuttingProcess.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 150, "Nama")})
		Me.txtCuttingProcess.Properties.DisplayMember = "Nama"
		Me.txtCuttingProcess.Properties.NullText = "[Pilih Process Cutting]"
		Me.txtCuttingProcess.Properties.ShowHeader = False
		Me.txtCuttingProcess.Properties.ValueMember = "This"
		Me.txtCuttingProcess.Size = New System.Drawing.Size(363, 20)
		Me.txtCuttingProcess.StyleController = Me.lytTransaksi
		Me.txtCuttingProcess.TabIndex = 21
		'
		'txtCuttingOP
		'
		Me.txtCuttingOP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtCuttingOP.Location = New System.Drawing.Point(1028, 209)
		Me.txtCuttingOP.MenuManager = Me.barMan
		Me.txtCuttingOP.Name = "txtCuttingOP"
		Me.txtCuttingOP.Properties.Appearance.Options.UseTextOptions = True
		Me.txtCuttingOP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtCuttingOP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCuttingOP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCuttingOP.Properties.Items.AddRange(New Object() {"OP 1", "OP 2", "OP 3", "OP 4", "OP 5"})
		Me.txtCuttingOP.Properties.ReadOnly = True
		Me.txtCuttingOP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.txtCuttingOP.Size = New System.Drawing.Size(76, 20)
		Me.txtCuttingOP.StyleController = Me.lytTransaksi
		Me.txtCuttingOP.TabIndex = 23
		'
		'layoutControlGroup1
		'
		Me.layoutControlGroup1.CustomizationFormText = "Root"
		Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.layoutControlGroup1.GroupBordersVisible = False
		Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlGroup3, Me.LayoutControlGroup5, Me.EmptySpaceItem4, Me.LayoutControlGroup4})
		Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.layoutControlGroup1.Name = "Root"
		Me.layoutControlGroup1.Size = New System.Drawing.Size(1128, 456)
		Me.layoutControlGroup1.Text = "Root"
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem7.Control = Me.xGrid
		Me.LayoutControlItem7.CustomizationFormText = "Bahan Penyusun"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 263)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(1108, 173)
		Me.LayoutControlItem7.Text = "Bahan Penyusun"
		Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(95, 13)
		'
		'LayoutControlGroup3
		'
		Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
		Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
		Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
		Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
		Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem1, Me.lytRegional, Me.LayoutControlItem14, Me.EmptySpaceItem3, Me.EmptySpaceItem2, Me.lblKontakNama})
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
		Me.layKontak.Size = New System.Drawing.Size(350, 24)
		Me.layKontak.Text = "Customer"
		Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.layKontak.TextSize = New System.Drawing.Size(155, 13)
		Me.layKontak.TextToControlDistance = 5
		'
		'LayoutControlItem15
		'
		Me.LayoutControlItem15.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem15.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem15.Control = Me.txtTanggal
		Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
		Me.LayoutControlItem15.Location = New System.Drawing.Point(624, 0)
		Me.LayoutControlItem15.Name = "LayoutControlItem15"
		Me.LayoutControlItem15.Size = New System.Drawing.Size(236, 24)
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
		Me.LayoutControlItem16.Location = New System.Drawing.Point(860, 0)
		Me.LayoutControlItem16.Name = "LayoutControlItem16"
		Me.LayoutControlItem16.Size = New System.Drawing.Size(206, 24)
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
		Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem1.Control = Me.txtDempyou
		Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(350, 24)
		Me.LayoutControlItem1.Text = "Order Produksi [Dempyou]"
		Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(155, 13)
		Me.LayoutControlItem1.TextToControlDistance = 5
		'
		'lytRegional
		'
		Me.lytRegional.Control = Me.txtRegional
		Me.lytRegional.CustomizationFormText = "Regional"
		Me.lytRegional.Location = New System.Drawing.Point(624, 24)
		Me.lytRegional.Name = "lytRegional"
		Me.lytRegional.Size = New System.Drawing.Size(236, 24)
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
		Me.LayoutControlItem14.Location = New System.Drawing.Point(860, 24)
		Me.LayoutControlItem14.Name = "LayoutControlItem14"
		Me.LayoutControlItem14.Size = New System.Drawing.Size(206, 24)
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
		Me.EmptySpaceItem3.Location = New System.Drawing.Point(566, 0)
		Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Size = New System.Drawing.Size(58, 48)
		Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
		Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(350, 17)
		Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(216, 31)
		Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'lblKontakNama
		'
		Me.lblKontakNama.AllowHotTrack = False
		Me.lblKontakNama.CustomizationFormText = "LabellblKontakNama"
		Me.lblKontakNama.Location = New System.Drawing.Point(350, 0)
		Me.lblKontakNama.Name = "lblKontakNama"
		Me.lblKontakNama.Size = New System.Drawing.Size(216, 17)
		Me.lblKontakNama.Text = "LabellblKontakNama"
		Me.lblKontakNama.TextSize = New System.Drawing.Size(95, 13)
		Me.lblKontakNama.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
		'
		'LayoutControlGroup5
		'
		Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
		Me.LayoutControlGroup5.CustomizationFormText = "PO"
		Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlItem12, Me.LayoutControlItem4, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem13, Me.LayoutControlItem20, Me.LayoutControlItem8, Me.LayoutControlItem5, Me.LayoutControlItem9, Me.LayoutControlItem22})
		Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 94)
		Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
		Me.LayoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
		Me.LayoutControlGroup5.Size = New System.Drawing.Size(620, 169)
		Me.LayoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
		Me.LayoutControlGroup5.Text = "Informasi Order Produksi [Dempyou]"
		'
		'LayoutControlItem21
		'
		Me.LayoutControlItem21.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem21.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem21.Control = Me.txtNoPO
		Me.LayoutControlItem21.CustomizationFormText = "Alamat"
		Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem21.Name = "LayoutControlItem21"
		Me.LayoutControlItem21.Size = New System.Drawing.Size(319, 24)
		Me.LayoutControlItem21.Text = "No. PO     "
		Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem21.TextSize = New System.Drawing.Size(50, 13)
		Me.LayoutControlItem21.TextToControlDistance = 5
		'
		'LayoutControlItem12
		'
		Me.LayoutControlItem12.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem12.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem12.Control = Me.txtPOLine
		Me.LayoutControlItem12.CustomizationFormText = "Termin"
		Me.LayoutControlItem12.Location = New System.Drawing.Point(492, 0)
		Me.LayoutControlItem12.Name = "LayoutControlItem12"
		Me.LayoutControlItem12.Size = New System.Drawing.Size(116, 24)
		Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem12.Text = "PO Line"
		Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem12.TextSize = New System.Drawing.Size(41, 13)
		Me.LayoutControlItem12.TextToControlDistance = 5
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtMaterial
		Me.LayoutControlItem4.CustomizationFormText = "Inspection"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(135, 24)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(184, 114)
		Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem4.Text = "Material"
		Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(38, 13)
		Me.LayoutControlItem4.TextToControlDistance = 5
		'
		'LayoutControlItem18
		'
		Me.LayoutControlItem18.Control = Me.txtSize
		Me.LayoutControlItem18.CustomizationFormText = "PPN"
		Me.LayoutControlItem18.Location = New System.Drawing.Point(319, 24)
		Me.LayoutControlItem18.Name = "LayoutControlItem18"
		Me.LayoutControlItem18.Size = New System.Drawing.Size(117, 42)
		Me.LayoutControlItem18.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem18.Text = "Size"
		Me.LayoutControlItem18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem18.TextSize = New System.Drawing.Size(19, 13)
		Me.LayoutControlItem18.TextToControlDistance = 5
		'
		'LayoutControlItem19
		'
		Me.LayoutControlItem19.Control = Me.txtLength
		Me.LayoutControlItem19.CustomizationFormText = "PPH"
		Me.LayoutControlItem19.Location = New System.Drawing.Point(436, 24)
		Me.LayoutControlItem19.Name = "LayoutControlItem19"
		Me.LayoutControlItem19.Size = New System.Drawing.Size(87, 42)
		Me.LayoutControlItem19.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem19.Text = "Length"
		Me.LayoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem19.TextSize = New System.Drawing.Size(33, 13)
		Me.LayoutControlItem19.TextToControlDistance = 5
		'
		'LayoutControlItem13
		'
		Me.LayoutControlItem13.Control = Me.txtPartNo
		Me.LayoutControlItem13.CustomizationFormText = "Sub Total"
		Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem13.Name = "LayoutControlItem13"
		Me.LayoutControlItem13.Size = New System.Drawing.Size(135, 114)
		Me.LayoutControlItem13.Text = "Part No."
		Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem13.TextSize = New System.Drawing.Size(40, 13)
		Me.LayoutControlItem13.TextToControlDistance = 5
		'
		'LayoutControlItem20
		'
		Me.LayoutControlItem20.Control = Me.txtQtyDempyou
		Me.LayoutControlItem20.CustomizationFormText = "Total Transaksi   "
		Me.LayoutControlItem20.Location = New System.Drawing.Point(523, 24)
		Me.LayoutControlItem20.Name = "LayoutControlItem20"
		Me.LayoutControlItem20.Size = New System.Drawing.Size(85, 42)
		Me.LayoutControlItem20.Text = "Qty"
		Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem20.TextSize = New System.Drawing.Size(18, 13)
		Me.LayoutControlItem20.TextToControlDistance = 5
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.txtGudang
		Me.LayoutControlItem8.CustomizationFormText = "Gudang  "
		Me.LayoutControlItem8.Location = New System.Drawing.Point(319, 0)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(173, 24)
		Me.LayoutControlItem8.Text = "Gudang  "
		Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(43, 13)
		Me.LayoutControlItem8.TextToControlDistance = 5
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtSisaQty
		Me.LayoutControlItem5.CustomizationFormText = "Sisa Qty"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(319, 66)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(289, 24)
		Me.LayoutControlItem5.Text = "Sisa Qty"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(95, 13)
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtCutting
		Me.LayoutControlItem9.CustomizationFormText = "Cutting"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(319, 90)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(289, 24)
		Me.LayoutControlItem9.Text = "Cutting"
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(95, 13)
		'
		'LayoutControlItem22
		'
		Me.LayoutControlItem22.Control = Me.txtRMDibutuhkan
		Me.LayoutControlItem22.CustomizationFormText = "RM Dibutuhkan"
		Me.LayoutControlItem22.Location = New System.Drawing.Point(319, 114)
		Me.LayoutControlItem22.Name = "LayoutControlItem22"
		Me.LayoutControlItem22.Size = New System.Drawing.Size(289, 24)
		Me.LayoutControlItem22.Text = "RM Dibutuhkan"
		Me.LayoutControlItem22.TextSize = New System.Drawing.Size(95, 13)
		'
		'EmptySpaceItem4
		'
		Me.EmptySpaceItem4.AllowHotTrack = False
		Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Location = New System.Drawing.Point(620, 94)
		Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Size = New System.Drawing.Size(12, 169)
		Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
		Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlGroup4
		'
		Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
		Me.LayoutControlGroup4.CustomizationFormText = "Informasi Cutting [WIP]"
		Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem10, Me.LayoutControlItem6, Me.LayoutControlItem23, Me.LayoutControlItem2, Me.LayoutControlItem3})
		Me.LayoutControlGroup4.Location = New System.Drawing.Point(632, 94)
		Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
		Me.LayoutControlGroup4.Size = New System.Drawing.Size(476, 169)
		Me.LayoutControlGroup4.Text = "Informasi Cutting [WIP]"
		'
		'LayoutControlItem11
		'
		Me.LayoutControlItem11.Control = Me.txtCuttingNomorLot
		Me.LayoutControlItem11.CustomizationFormText = "Tarik SQ"
		Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem11.Name = "LayoutControlItem11"
		Me.LayoutControlItem11.Size = New System.Drawing.Size(452, 24)
		Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem11.Text = "No. Lot"
		Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem11.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem11.TextToControlDistance = 5
		'
		'LayoutControlItem10
		'
		Me.LayoutControlItem10.Control = Me.txtCuttingMesin
		Me.LayoutControlItem10.CustomizationFormText = "Kurs"
		Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem10.Name = "LayoutControlItem10"
		Me.LayoutControlItem10.Size = New System.Drawing.Size(315, 24)
		Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem10.Text = "Mesin"
		Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem10.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem10.TextToControlDistance = 5
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtCuttingShift
		Me.LayoutControlItem6.CustomizationFormText = "Validity"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(315, 0)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(137, 24)
		Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem6.Text = "Shift"
		Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(50, 13)
		Me.LayoutControlItem6.TextToControlDistance = 5
		'
		'LayoutControlItem23
		'
		Me.LayoutControlItem23.Control = Me.txtCuttingProcess
		Me.LayoutControlItem23.CustomizationFormText = "Pajak"
		Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem23.Name = "LayoutControlItem23"
		Me.LayoutControlItem23.Size = New System.Drawing.Size(452, 24)
		Me.LayoutControlItem23.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem23.Text = "Process"
		Me.LayoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem23.TextSize = New System.Drawing.Size(75, 20)
		Me.LayoutControlItem23.TextToControlDistance = 5
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtCuttingQty
		Me.LayoutControlItem2.CustomizationFormText = "Qty"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 72)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(312, 54)
		Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem2.Text = "Qty"
		Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 20)
		Me.LayoutControlItem2.TextToControlDistance = 5
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtCuttingOP
		Me.LayoutControlItem3.CustomizationFormText = "OP"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(312, 72)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(140, 54)
		Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem3.Text = "OP"
		Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 20)
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
		'LayoutControlGroup2
		'
		Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Location = New System.Drawing.Point(865, 295)
		Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Size = New System.Drawing.Size(243, 120)
		Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
		Me.LayoutControlGroup2.TextVisible = False
		'
		'btnAmbilUlangSN
		'
		Me.btnAmbilUlangSN.Caption = "Ambil Ulang SN"
		Me.btnAmbilUlangSN.Id = 6
		Me.btnAmbilUlangSN.Name = "btnAmbilUlangSN"
		Me.btnAmbilUlangSN.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
		'
		'UI_FusohCuttingWIPDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1134, 489)
		Me.Controls.Add(Me.hideContainerRight)
		Me.KeyPreview = True
		Me.Name = "UI_FusohCuttingWIPDialog"
		Me.Text = "Cutting [WIP]"
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
		CType(Me.txtSisaQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCuttingQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRMDibutuhkan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCutting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtLength.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colCommandRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeRepoView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSNRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQtyDempyou.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCuttingNomorLot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPOLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDempyou.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCuttingMesin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCuttingShift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCuttingProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCuttingOP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblKontakNama, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
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
  Friend WithEvents colLengthSN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
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
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtMaterial As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colOD As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colInD As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colThickness As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPartNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtSize As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtLength As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents colKodeRepoView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtQtyDempyou As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents txtCuttingNomorLot As DevExpress.XtraEditors.TextEdit
  Friend WithEvents colMaterialLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSNRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents txtGudang As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNoPO As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPOLine As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colCommand As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCommandRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents txtCutting As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtRMDibutuhkan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtDempyou As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKodeDempyou As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNomorLot As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colScrap As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtCuttingMesin As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtCuttingShift As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtCuttingQty As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtSisaQty As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtCuttingProcess As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtCuttingOP As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents lblKontakNama As DevExpress.XtraLayout.SimpleLabelItem
	Friend WithEvents btnAmbilUlangSN As DevExpress.XtraBars.BarButtonItem
End Class
