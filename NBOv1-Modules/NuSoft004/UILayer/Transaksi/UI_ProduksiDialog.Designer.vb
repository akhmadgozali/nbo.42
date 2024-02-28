<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ProduksiDialog
    Inherits Core.Win.Forms.InputMDI

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_ProduksiDialog))
		Me.colDivisiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
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
		Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
		Me.txtSatuan = New DevExpress.XtraEditors.TextEdit()
		Me.txtQty = New DevExpress.XtraEditors.TextEdit()
		Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
		Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
		Me.xGridCost = New DevExpress.XtraGrid.GridControl()
		Me.xGridCostView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKodeCoa = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeCostRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.colNamaCoa = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colJumlah = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatanCOA = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.xGridBahanJadi = New DevExpress.XtraGrid.GridControl()
		Me.xGridBahanJadiView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKodeBarangBJ = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeBarangBJRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
		Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarangBJ = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyBJ = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuanBJ = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuanBJRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.colHPPBJ = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatanBJ = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtGudangTujuan = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
		Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
		Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
		Me.xGridBahanBaku = New DevExpress.XtraGrid.GridControl()
		Me.xGridBahanBakuView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colGudangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
		Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtKodeBarang = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.layTipeEmpty = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
		Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager()
		Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
		Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
		Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
		Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
		Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
		Me.ImageList1 = New System.Windows.Forms.ImageList()
		Me.ImageList2 = New System.Windows.Forms.ImageList()
		Me.btnTemplate = New DevExpress.XtraBars.BarButtonItem()
		Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
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
		CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridCost, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridCostView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeCostRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridBahanJadi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridBahanJadiView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeBarangBJRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSatuanBJRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtGudangTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridBahanBaku, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridBahanBakuView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colGudangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.layTipeEmpty, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.btnTemplate, Me.btnRefresh})
		Me.barMan.MaxItemId = 11
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTemplate, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'colDivisiRepo
		'
		Me.colDivisiRepo.AutoHeight = False
		Me.colDivisiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colDivisiRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
		Me.colDivisiRepo.DisplayMember = "Kode"
		Me.colDivisiRepo.Name = "colDivisiRepo"
		Me.colDivisiRepo.NullText = "<Pilih Divisi>"
		Me.colDivisiRepo.ShowHeader = False
		Me.colDivisiRepo.ValueMember = "This"
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
		Me.DockPanel1.Size = New System.Drawing.Size(250, 518)
		Me.DockPanel1.Text = "Panel Informasi"
		Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
		'
		'DockPanel1_Container
		'
		Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
		Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
		Me.DockPanel1_Container.Name = "DockPanel1_Container"
		Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 491)
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
		Me.NavBarControl1.Size = New System.Drawing.Size(242, 491)
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
		Me.xGHistoryView.OptionsDetail.EnableMasterViewMode = False
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
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 0
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		'
		'colKeterangan
		'
		Me.colKeterangan.Caption = "Keterangan"
		Me.colKeterangan.Name = "colKeterangan"
		Me.colKeterangan.Visible = True
		Me.colKeterangan.VisibleIndex = 2
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
		Me.lytTransaksi.Controls.Add(Me.btnOK)
		Me.lytTransaksi.Controls.Add(Me.txtSatuan)
		Me.lytTransaksi.Controls.Add(Me.txtQty)
		Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
		Me.lytTransaksi.Controls.Add(Me.txtStatus)
		Me.lytTransaksi.Controls.Add(Me.xGridCost)
		Me.lytTransaksi.Controls.Add(Me.xGridBahanJadi)
		Me.lytTransaksi.Controls.Add(Me.txtGudangTujuan)
		Me.lytTransaksi.Controls.Add(Me.txtGudang)
		Me.lytTransaksi.Controls.Add(Me.txtRegional)
		Me.lytTransaksi.Controls.Add(Me.txtTanggal)
		Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
		Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
		Me.lytTransaksi.Controls.Add(Me.xGridBahanBaku)
		Me.lytTransaksi.Controls.Add(Me.txtUraian)
		Me.lytTransaksi.Controls.Add(Me.txtKontak)
		Me.lytTransaksi.Controls.Add(Me.txtKodeBarang)
		Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11})
		Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksi.Name = "lytTransaksi"
		Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(152, 114, 250, 350)
		Me.lytTransaksi.Root = Me.LayoutControlGroup1
		Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
		Me.lytTransaksi.TabIndex = 0
		Me.lytTransaksi.Text = "LayoutControl1"
		'
		'btnOK
		'
		Me.btnOK.Location = New System.Drawing.Point(394, 185)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(185, 22)
		Me.btnOK.StyleController = Me.lytTransaksi
		Me.btnOK.TabIndex = 12
		Me.btnOK.Text = "OK"
		'
		'txtSatuan
		'
		Me.txtSatuan.Location = New System.Drawing.Point(433, 185)
		Me.txtSatuan.MenuManager = Me.barMan
		Me.txtSatuan.Name = "txtSatuan"
		Me.txtSatuan.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtSatuan.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtSatuan.Properties.ReadOnly = True
		Me.txtSatuan.Size = New System.Drawing.Size(101, 20)
		Me.txtSatuan.StyleController = Me.lytTransaksi
		Me.txtSatuan.TabIndex = 11
		'
		'txtQty
		'
		Me.txtQty.Location = New System.Drawing.Point(317, 185)
		Me.txtQty.MenuManager = Me.barMan
		Me.txtQty.Name = "txtQty"
		Me.txtQty.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtQty.Size = New System.Drawing.Size(73, 20)
		Me.txtQty.StyleController = Me.lytTransaksi
		Me.txtQty.TabIndex = 10
		'
		'lblKontakNama
		'
		Me.lblKontakNama.Location = New System.Drawing.Point(238, 37)
		Me.lblKontakNama.Name = "lblKontakNama"
		Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
		Me.lblKontakNama.StyleController = Me.lytTransaksi
		Me.lblKontakNama.TabIndex = 12
		'
		'txtStatus
		'
		Me.txtStatus.Location = New System.Drawing.Point(958, 61)
		Me.txtStatus.MenuManager = Me.barMan
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtStatus.Properties.AppearanceFocused.Options.UseBackColor = True
		Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
		Me.txtStatus.Properties.DisplayMember = "Value"
		Me.txtStatus.Properties.NullText = "<Status>"
		Me.txtStatus.Properties.ValueMember = "Key"
		Me.txtStatus.Size = New System.Drawing.Size(120, 20)
		Me.txtStatus.StyleController = Me.lytTransaksi
		Me.txtStatus.TabIndex = 6
		'
		'xGridCost
		'
		Me.xGridCost.Location = New System.Drawing.Point(16, 249)
		Me.xGridCost.MainView = Me.xGridCostView
		Me.xGridCost.MenuManager = Me.barMan
		Me.xGridCost.Name = "xGridCost"
		Me.xGridCost.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colKodeCostRepo})
		Me.xGridCost.Size = New System.Drawing.Size(1096, 170)
		Me.xGridCost.TabIndex = 10
		Me.xGridCost.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridCostView})
		'
		'xGridCostView
		'
		Me.xGridCostView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeCoa, Me.colNamaCoa, Me.colJumlah, Me.colCatatanCOA})
		Me.xGridCostView.GridControl = Me.xGridCost
		Me.xGridCostView.Name = "xGridCostView"
		Me.xGridCostView.NewItemRowText = "Tambah Data"
		Me.xGridCostView.OptionsCustomization.AllowGroup = False
		Me.xGridCostView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridCostView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridCostView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		Me.xGridCostView.OptionsView.ShowFooter = True
		Me.xGridCostView.OptionsView.ShowGroupPanel = False
		'
		'colKodeCoa
		'
		Me.colKodeCoa.Caption = "Kode Cost"
		Me.colKodeCoa.ColumnEdit = Me.colKodeCostRepo
		Me.colKodeCoa.FieldName = "Cost"
		Me.colKodeCoa.Name = "colKodeCoa"
		Me.colKodeCoa.Visible = True
		Me.colKodeCoa.VisibleIndex = 0
		Me.colKodeCoa.Width = 218
		'
		'colKodeCostRepo
		'
		Me.colKodeCostRepo.AutoHeight = False
		Me.colKodeCostRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colKodeCostRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.colKodeCostRepo.DisplayMember = "Kode"
		Me.colKodeCostRepo.Name = "colKodeCostRepo"
		Me.colKodeCostRepo.NullText = "<Pilih Cost>"
		Me.colKodeCostRepo.ValueMember = "This"
		'
		'colNamaCoa
		'
		Me.colNamaCoa.Caption = "Nama Cost"
		Me.colNamaCoa.FieldName = "Cost.Nama"
		Me.colNamaCoa.Name = "colNamaCoa"
		Me.colNamaCoa.OptionsColumn.AllowEdit = False
		Me.colNamaCoa.OptionsColumn.ReadOnly = True
		Me.colNamaCoa.Visible = True
		Me.colNamaCoa.VisibleIndex = 1
		'
		'colJumlah
		'
		Me.colJumlah.AppearanceCell.Options.UseTextOptions = True
		Me.colJumlah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colJumlah.AppearanceHeader.Options.UseTextOptions = True
		Me.colJumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colJumlah.Caption = "Jumlah"
		Me.colJumlah.FieldName = "Jumlah"
		Me.colJumlah.Name = "colJumlah"
		Me.colJumlah.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colJumlah.Visible = True
		Me.colJumlah.VisibleIndex = 2
		'
		'colCatatanCOA
		'
		Me.colCatatanCOA.Caption = "Catatan"
		Me.colCatatanCOA.FieldName = "Catatan"
		Me.colCatatanCOA.Name = "colCatatanCOA"
		Me.colCatatanCOA.Visible = True
		Me.colCatatanCOA.VisibleIndex = 3
		'
		'xGridBahanJadi
		'
		Me.xGridBahanJadi.Location = New System.Drawing.Point(16, 249)
		Me.xGridBahanJadi.MainView = Me.xGridBahanJadiView
		Me.xGridBahanJadi.MenuManager = Me.barMan
		Me.xGridBahanJadi.Name = "xGridBahanJadi"
		Me.xGridBahanJadi.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSatuanBJRepo, Me.colKodeBarangBJRepo})
		Me.xGridBahanJadi.Size = New System.Drawing.Size(1096, 170)
		Me.xGridBahanJadi.TabIndex = 10
		Me.xGridBahanJadi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridBahanJadiView})
		'
		'xGridBahanJadiView
		'
		Me.xGridBahanJadiView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarangBJ, Me.colNamaBarangBJ, Me.colQtyBJ, Me.colSatuanBJ, Me.colHPPBJ, Me.colCatatanBJ})
		Me.xGridBahanJadiView.GridControl = Me.xGridBahanJadi
		Me.xGridBahanJadiView.Name = "xGridBahanJadiView"
		Me.xGridBahanJadiView.NewItemRowText = "Tambah Data"
		Me.xGridBahanJadiView.OptionsCustomization.AllowGroup = False
		Me.xGridBahanJadiView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridBahanJadiView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridBahanJadiView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		Me.xGridBahanJadiView.OptionsView.ShowFooter = True
		Me.xGridBahanJadiView.OptionsView.ShowGroupPanel = False
		'
		'colKodeBarangBJ
		'
		Me.colKodeBarangBJ.Caption = "Kode Barang"
		Me.colKodeBarangBJ.ColumnEdit = Me.colKodeBarangBJRepo
		Me.colKodeBarangBJ.FieldName = "Barang"
		Me.colKodeBarangBJ.Name = "colKodeBarangBJ"
		Me.colKodeBarangBJ.Visible = True
		Me.colKodeBarangBJ.VisibleIndex = 0
		Me.colKodeBarangBJ.Width = 218
		'
		'colKodeBarangBJRepo
		'
		Me.colKodeBarangBJRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.colKodeBarangBJRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colKodeBarangBJRepo.DisplayMember = "Kode"
		Me.colKodeBarangBJRepo.Name = "colKodeBarangBJRepo"
		Me.colKodeBarangBJRepo.NullText = "<Pilih Barang>"
		Me.colKodeBarangBJRepo.ShowClearButton = False
		Me.colKodeBarangBJRepo.ShowFooter = False
		Me.colKodeBarangBJRepo.ValueMember = "This"
		Me.colKodeBarangBJRepo.View = Me.RepositoryItemSearchLookUpEdit1View
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
		'colNamaBarangBJ
		'
		Me.colNamaBarangBJ.Caption = "Nama Barang"
		Me.colNamaBarangBJ.FieldName = "Barang.Nama"
		Me.colNamaBarangBJ.Name = "colNamaBarangBJ"
		Me.colNamaBarangBJ.OptionsColumn.AllowEdit = False
		Me.colNamaBarangBJ.OptionsColumn.ReadOnly = True
		Me.colNamaBarangBJ.Visible = True
		Me.colNamaBarangBJ.VisibleIndex = 1
		Me.colNamaBarangBJ.Width = 295
		'
		'colQtyBJ
		'
		Me.colQtyBJ.AppearanceCell.Options.UseTextOptions = True
		Me.colQtyBJ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQtyBJ.AppearanceHeader.Options.UseTextOptions = True
		Me.colQtyBJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQtyBJ.Caption = "Qty"
		Me.colQtyBJ.FieldName = "QtyIn"
		Me.colQtyBJ.Name = "colQtyBJ"
		Me.colQtyBJ.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyBJ.Visible = True
		Me.colQtyBJ.VisibleIndex = 2
		Me.colQtyBJ.Width = 83
		'
		'colSatuanBJ
		'
		Me.colSatuanBJ.Caption = "Satuan"
		Me.colSatuanBJ.ColumnEdit = Me.colSatuanBJRepo
		Me.colSatuanBJ.FieldName = "Satuan"
		Me.colSatuanBJ.Name = "colSatuanBJ"
		Me.colSatuanBJ.Visible = True
		Me.colSatuanBJ.VisibleIndex = 3
		Me.colSatuanBJ.Width = 118
		'
		'colSatuanBJRepo
		'
		Me.colSatuanBJRepo.AutoHeight = False
		Me.colSatuanBJRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colSatuanBJRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.colSatuanBJRepo.DisplayMember = "Kode"
		Me.colSatuanBJRepo.Name = "colSatuanBJRepo"
		Me.colSatuanBJRepo.NullText = "<Pilih Satuan>"
		Me.colSatuanBJRepo.ValueMember = "This"
		'
		'colHPPBJ
		'
		Me.colHPPBJ.AppearanceCell.Options.UseTextOptions = True
		Me.colHPPBJ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHPPBJ.AppearanceHeader.Options.UseTextOptions = True
		Me.colHPPBJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHPPBJ.Caption = "HPP"
		Me.colHPPBJ.FieldName = "PersentaseHPP"
		Me.colHPPBJ.Name = "colHPPBJ"
		Me.colHPPBJ.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colHPPBJ.Visible = True
		Me.colHPPBJ.VisibleIndex = 4
		Me.colHPPBJ.Width = 60
		'
		'colCatatanBJ
		'
		Me.colCatatanBJ.Caption = "Catatan"
		Me.colCatatanBJ.FieldName = "Catatan"
		Me.colCatatanBJ.Name = "colCatatanBJ"
		Me.colCatatanBJ.Visible = True
		Me.colCatatanBJ.VisibleIndex = 5
		Me.colCatatanBJ.Width = 186
		'
		'txtGudangTujuan
		'
		Me.txtGudangTujuan.Location = New System.Drawing.Point(88, 106)
		Me.txtGudangTujuan.MenuManager = Me.barMan
		Me.txtGudangTujuan.Name = "txtGudangTujuan"
		Me.txtGudangTujuan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtGudangTujuan.Properties.AppearanceFocused.Options.UseBackColor = True
		Me.txtGudangTujuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtGudangTujuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtGudangTujuan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
		Me.txtGudangTujuan.Properties.DisplayMember = "Kode"
		Me.txtGudangTujuan.Properties.NullText = "<Pilih Gudang>"
		Me.txtGudangTujuan.Properties.PopupWidth = 200
		Me.txtGudangTujuan.Properties.ValueMember = "This"
		Me.txtGudangTujuan.Size = New System.Drawing.Size(158, 20)
		Me.txtGudangTujuan.StyleController = Me.lytTransaksi
		Me.txtGudangTujuan.TabIndex = 7
		'
		'txtGudang
		'
		Me.txtGudang.Location = New System.Drawing.Point(71, 61)
		Me.txtGudang.MenuManager = Me.barMan
		Me.txtGudang.Name = "txtGudang"
		Me.txtGudang.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtGudang.Properties.AppearanceFocused.Options.UseBackColor = True
		Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
		Me.txtGudang.Properties.DisplayMember = "Kode"
		Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
		Me.txtGudang.Properties.PopupWidth = 200
		Me.txtGudang.Properties.ValueMember = "This"
		Me.txtGudang.Size = New System.Drawing.Size(163, 20)
		Me.txtGudang.StyleController = Me.lytTransaksi
		Me.txtGudang.TabIndex = 4
		'
		'txtRegional
		'
		Me.txtRegional.Location = New System.Drawing.Point(771, 61)
		Me.txtRegional.MenuManager = Me.barMan
		Me.txtRegional.Name = "txtRegional"
		Me.txtRegional.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtRegional.Properties.AppearanceFocused.Options.UseBackColor = True
		Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
		Me.txtRegional.Properties.DisplayMember = "Nama"
		Me.txtRegional.Properties.NullText = "<Pilih Regional>"
		Me.txtRegional.Properties.PopupWidth = 200
		Me.txtRegional.Properties.ValueMember = "This"
		Me.txtRegional.Size = New System.Drawing.Size(120, 20)
		Me.txtRegional.StyleController = Me.lytTransaksi
		Me.txtRegional.TabIndex = 5
		'
		'txtTanggal
		'
		Me.txtTanggal.EditValue = Nothing
		Me.txtTanggal.Location = New System.Drawing.Point(771, 37)
		Me.txtTanggal.MenuManager = Me.barMan
		Me.txtTanggal.Name = "txtTanggal"
		Me.txtTanggal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtTanggal.Properties.AppearanceFocused.Options.UseBackColor = True
		Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal.Size = New System.Drawing.Size(120, 20)
		Me.txtTanggal.StyleController = Me.lytTransaksi
		Me.txtTanggal.TabIndex = 1
		'
		'btnRefreshNomor
		'
		Me.btnRefreshNomor.AutoWidthInLayoutControl = True
		Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
		Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
		Me.btnRefreshNomor.Location = New System.Drawing.Point(1082, 37)
		Me.btnRefreshNomor.Name = "btnRefreshNomor"
		Me.btnRefreshNomor.Size = New System.Drawing.Size(28, 22)
		Me.btnRefreshNomor.StyleController = Me.lytTransaksi
		Me.btnRefreshNomor.TabIndex = 3
		'
		'txtNoTransaksi
		'
		Me.txtNoTransaksi.Location = New System.Drawing.Point(958, 37)
		Me.txtNoTransaksi.MenuManager = Me.barMan
		Me.txtNoTransaksi.Name = "txtNoTransaksi"
		Me.txtNoTransaksi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtNoTransaksi.Properties.AppearanceFocused.Options.UseBackColor = True
		Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoTransaksi.Size = New System.Drawing.Size(120, 20)
		Me.txtNoTransaksi.StyleController = Me.lytTransaksi
		Me.txtNoTransaksi.TabIndex = 2
		'
		'xGridBahanBaku
		'
		Me.xGridBahanBaku.Location = New System.Drawing.Point(16, 249)
		Me.xGridBahanBaku.MainView = Me.xGridBahanBakuView
		Me.xGridBahanBaku.MenuManager = Me.barMan
		Me.xGridBahanBaku.Name = "xGridBahanBaku"
		Me.xGridBahanBaku.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colGudangRepo, Me.colSatuanRepo, Me.colKodeBarangRepo})
		Me.xGridBahanBaku.Size = New System.Drawing.Size(1096, 170)
		Me.xGridBahanBaku.TabIndex = 14
		Me.xGridBahanBaku.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridBahanBakuView})
		'
		'xGridBahanBakuView
		'
		Me.xGridBahanBakuView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colCatatan})
		Me.xGridBahanBakuView.GridControl = Me.xGridBahanBaku
		Me.xGridBahanBakuView.Name = "xGridBahanBakuView"
		Me.xGridBahanBakuView.NewItemRowText = "Tambah Data"
		Me.xGridBahanBakuView.OptionsCustomization.AllowGroup = False
		Me.xGridBahanBakuView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridBahanBakuView.OptionsFilter.AllowFilterEditor = False
		Me.xGridBahanBakuView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridBahanBakuView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		Me.xGridBahanBakuView.OptionsView.ShowFooter = True
		Me.xGridBahanBakuView.OptionsView.ShowGroupPanel = False
		'
		'colKodeBarang
		'
		Me.colKodeBarang.Caption = "Kode Barang"
		Me.colKodeBarang.ColumnEdit = Me.colKodeBarangRepo
		Me.colKodeBarang.FieldName = "Barang"
		Me.colKodeBarang.Name = "colKodeBarang"
		Me.colKodeBarang.Visible = True
		Me.colKodeBarang.VisibleIndex = 0
		Me.colKodeBarang.Width = 150
		'
		'colKodeBarangRepo
		'
		Me.colKodeBarangRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colKodeBarangRepo.DisplayMember = "Kode"
		Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
		Me.colKodeBarangRepo.NullText = "<Pilih Barang>"
		Me.colKodeBarangRepo.ShowClearButton = False
		Me.colKodeBarangRepo.ShowFooter = False
		Me.colKodeBarangRepo.ValueMember = "This"
		Me.colKodeBarangRepo.View = Me.GridView1
		'
		'GridView1
		'
		Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
		Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView1.OptionsView.ShowGroupPanel = False
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Kode"
		Me.GridColumn1.FieldName = "Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		Me.GridColumn1.Width = 293
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Nama"
		Me.GridColumn2.FieldName = "Nama"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		Me.GridColumn2.Width = 519
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Satuan"
		Me.GridColumn3.FieldName = "Satuan.Nama"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 2
		Me.GridColumn3.Width = 266
		'
		'colNamaBarang
		'
		Me.colNamaBarang.Caption = "Nama Barang"
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
		Me.colQty.Caption = "Qty"
		Me.colQty.FieldName = "QtyOut"
		Me.colQty.Name = "colQty"
		Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 2
		Me.colQty.Width = 80
		'
		'colSatuan
		'
		Me.colSatuan.AppearanceCell.Options.UseTextOptions = True
		Me.colSatuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colSatuan.AppearanceHeader.Options.UseTextOptions = True
		Me.colSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colSatuan.Caption = "Satuan"
		Me.colSatuan.ColumnEdit = Me.colSatuanRepo
		Me.colSatuan.FieldName = "Satuan"
		Me.colSatuan.Name = "colSatuan"
		Me.colSatuan.Visible = True
		Me.colSatuan.VisibleIndex = 3
		Me.colSatuan.Width = 80
		'
		'colSatuanRepo
		'
		Me.colSatuanRepo.AutoHeight = False
		Me.colSatuanRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colSatuanRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.colSatuanRepo.DisplayMember = "Kode"
		Me.colSatuanRepo.Name = "colSatuanRepo"
		Me.colSatuanRepo.NullText = "<Pilih Satuan>"
		Me.colSatuanRepo.ValueMember = "This"
		'
		'colCatatan
		'
		Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
		Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
		Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colCatatan.Caption = "Catatan"
		Me.colCatatan.FieldName = "Catatan"
		Me.colCatatan.Name = "colCatatan"
		Me.colCatatan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colCatatan.Visible = True
		Me.colCatatan.VisibleIndex = 4
		Me.colCatatan.Width = 80
		'
		'colGudangRepo
		'
		Me.colGudangRepo.AutoHeight = False
		Me.colGudangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colGudangRepo.Name = "colGudangRepo"
		Me.colGudangRepo.NullText = "<Pilih Gudang>"
		'
		'txtUraian
		'
		Me.txtUraian.Location = New System.Drawing.Point(88, 130)
		Me.txtUraian.MenuManager = Me.barMan
		Me.txtUraian.Name = "txtUraian"
		Me.txtUraian.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtUraian.Properties.AppearanceFocused.Options.UseBackColor = True
		Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtUraian.Properties.MaxLength = 255
		Me.txtUraian.Size = New System.Drawing.Size(660, 20)
		Me.txtUraian.StyleController = Me.lytTransaksi
		Me.txtUraian.TabIndex = 8
		'
		'txtKontak
		'
		Me.txtKontak.Location = New System.Drawing.Point(71, 37)
		Me.txtKontak.MenuManager = Me.barMan
		Me.txtKontak.Name = "txtKontak"
		Me.txtKontak.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtKontak.Properties.AppearanceFocused.Options.UseBackColor = True
		Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtKontak.Properties.DisplayMember = "Kode"
		Me.txtKontak.Properties.NullText = "<Pilih Karyawan>"
		Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(330, 0)
		Me.txtKontak.Properties.ShowClearButton = False
		Me.txtKontak.Properties.ShowFooter = False
		Me.txtKontak.Properties.ValueMember = "This"
		Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
		Me.txtKontak.Size = New System.Drawing.Size(163, 20)
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
		'txtKodeBarang
		'
		Me.txtKodeBarang.Location = New System.Drawing.Point(100, 185)
		Me.txtKodeBarang.MenuManager = Me.barMan
		Me.txtKodeBarang.Name = "txtKodeBarang"
		Me.txtKodeBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtKodeBarang.Properties.DisplayMember = "Kode"
		Me.txtKodeBarang.Properties.NullText = ""
		Me.txtKodeBarang.Properties.ValueMember = "This"
		Me.txtKodeBarang.Properties.View = Me.GridView2
		Me.txtKodeBarang.Size = New System.Drawing.Size(190, 20)
		Me.txtKodeBarang.StyleController = Me.lytTransaksi
		Me.txtKodeBarang.TabIndex = 9
		'
		'GridView2
		'
		Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
		Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView2.Name = "GridView2"
		Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView2.OptionsView.ShowGroupPanel = False
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Kode"
		Me.GridColumn4.FieldName = "Kode"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 0
		Me.GridColumn4.Width = 293
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Nama"
		Me.GridColumn5.FieldName = "Nama"
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.Visible = True
		Me.GridColumn5.VisibleIndex = 1
		Me.GridColumn5.Width = 519
		'
		'GridColumn6
		'
		Me.GridColumn6.Caption = "Satuan"
		Me.GridColumn6.FieldName = "Satuan.Nama"
		Me.GridColumn6.Name = "GridColumn6"
		Me.GridColumn6.Visible = True
		Me.GridColumn6.VisibleIndex = 2
		Me.GridColumn6.Width = 266
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.layTipeEmpty, Me.LayoutControlGroup2, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.TabbedControlGroup1, Me.LayoutControlGroup6})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
		Me.LayoutControlGroup1.Text = "Root"
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtUraian
		Me.LayoutControlItem3.CustomizationFormText = "Uraian"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 118)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(740, 24)
		Me.LayoutControlItem3.Text = "Uraian       "
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(73, 13)
		'
		'layTipeEmpty
		'
		Me.layTipeEmpty.AllowHotTrack = False
		Me.layTipeEmpty.CustomizationFormText = "EmptySpaceItem1"
		Me.layTipeEmpty.Location = New System.Drawing.Point(238, 94)
		Me.layTipeEmpty.Name = "layTipeEmpty"
		Me.layTipeEmpty.Size = New System.Drawing.Size(502, 24)
		Me.layTipeEmpty.Text = "layTipeEmpty"
		Me.layTipeEmpty.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlGroup2
		'
		Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
		Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.lytRegional, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem3, Me.LayoutControlItem8, Me.EmptySpaceItem2})
		Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
		Me.LayoutControlGroup2.Size = New System.Drawing.Size(1108, 94)
		Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
		Me.LayoutControlGroup2.Text = "Info Utama"
		'
		'layKontak
		'
		Me.layKontak.Control = Me.txtKontak
		Me.layKontak.CustomizationFormText = "Karyawan"
		Me.layKontak.Location = New System.Drawing.Point(0, 0)
		Me.layKontak.Name = "layKontak"
		Me.layKontak.Size = New System.Drawing.Size(220, 24)
		Me.layKontak.Text = "Karyawan"
		Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.layKontak.TextSize = New System.Drawing.Size(48, 13)
		Me.layKontak.TextToControlDistance = 5
		'
		'LayoutControlItem15
		'
		Me.LayoutControlItem15.Control = Me.txtTanggal
		Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
		Me.LayoutControlItem15.Location = New System.Drawing.Point(705, 0)
		Me.LayoutControlItem15.Name = "LayoutControlItem15"
		Me.LayoutControlItem15.Size = New System.Drawing.Size(172, 24)
		Me.LayoutControlItem15.Text = "Tanggal"
		Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem15.TextSize = New System.Drawing.Size(43, 13)
		Me.LayoutControlItem15.TextToControlDistance = 5
		'
		'LayoutControlItem16
		'
		Me.LayoutControlItem16.Control = Me.txtNoTransaksi
		Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
		Me.LayoutControlItem16.Location = New System.Drawing.Point(877, 0)
		Me.LayoutControlItem16.Name = "LayoutControlItem16"
		Me.LayoutControlItem16.Size = New System.Drawing.Size(187, 24)
		Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
		Me.LayoutControlItem16.Text = "No. Bukti"
		Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem16.TextSize = New System.Drawing.Size(43, 13)
		Me.LayoutControlItem16.TextToControlDistance = 5
		'
		'LayoutControlItem17
		'
		Me.LayoutControlItem17.Control = Me.btnRefreshNomor
		Me.LayoutControlItem17.CustomizationFormText = " "
		Me.LayoutControlItem17.Location = New System.Drawing.Point(1064, 0)
		Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(32, 26)
		Me.LayoutControlItem17.MinSize = New System.Drawing.Size(32, 26)
		Me.LayoutControlItem17.Name = "LayoutControlItem17"
		Me.LayoutControlItem17.Size = New System.Drawing.Size(32, 48)
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
		Me.lytRegional.Location = New System.Drawing.Point(705, 24)
		Me.lytRegional.Name = "lytRegional"
		Me.lytRegional.Size = New System.Drawing.Size(172, 24)
		Me.lytRegional.Text = "Regional"
		Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.lytRegional.TextSize = New System.Drawing.Size(43, 13)
		Me.lytRegional.TextToControlDistance = 5
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtGudang
		Me.LayoutControlItem2.CustomizationFormText = "Gudang"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(220, 24)
		Me.LayoutControlItem2.Text = "Gudang   "
		Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(48, 13)
		Me.LayoutControlItem2.TextToControlDistance = 5
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtStatus
		Me.LayoutControlItem4.CustomizationFormText = "Status"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(877, 24)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(187, 24)
		Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
		Me.LayoutControlItem4.Text = "Status"
		Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(43, 13)
		Me.LayoutControlItem4.TextToControlDistance = 5
		'
		'EmptySpaceItem3
		'
		Me.EmptySpaceItem3.AllowHotTrack = False
		Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Location = New System.Drawing.Point(436, 0)
		Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Size = New System.Drawing.Size(269, 48)
		Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
		Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.lblKontakNama
		Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(220, 0)
		Me.LayoutControlItem8.MinSize = New System.Drawing.Size(70, 17)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(216, 24)
		Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.LayoutControlItem8.Text = "LayoutControlItem8"
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem8.TextToControlDistance = 0
		Me.LayoutControlItem8.TextVisible = False
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(220, 24)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(216, 24)
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtGudangTujuan
		Me.LayoutControlItem1.CustomizationFormText = "Gudang Tujuan"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 94)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(238, 24)
		Me.LayoutControlItem1.Text = "Gudang Tujuan"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(73, 13)
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(740, 94)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(368, 48)
		Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'TabbedControlGroup1
		'
		Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
		Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 211)
		Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
		Me.TabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
		Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
		Me.TabbedControlGroup1.SelectedTabPageIndex = 0
		Me.TabbedControlGroup1.Size = New System.Drawing.Size(1108, 204)
		Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5})
		Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
		'
		'LayoutControlGroup3
		'
		Me.LayoutControlGroup3.CustomizationFormText = "Bahan Baku"
		Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
		Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
		Me.LayoutControlGroup3.Size = New System.Drawing.Size(1100, 174)
		Me.LayoutControlGroup3.Text = "Bahan Baku"
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.xGridBahanBaku
		Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(1100, 174)
		Me.LayoutControlItem7.Text = "LayoutControlItem7"
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem7.TextToControlDistance = 0
		Me.LayoutControlItem7.TextVisible = False
		'
		'LayoutControlGroup4
		'
		Me.LayoutControlGroup4.CustomizationFormText = "Biaya Produksi"
		Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
		Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
		Me.LayoutControlGroup4.Size = New System.Drawing.Size(1100, 174)
		Me.LayoutControlGroup4.Text = "Biaya Produksi"
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.xGridCost
		Me.LayoutControlItem5.CustomizationFormText = "Coa"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(1100, 174)
		Me.LayoutControlItem5.Text = "Coa"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem5.TextToControlDistance = 0
		Me.LayoutControlItem5.TextVisible = False
		'
		'LayoutControlGroup5
		'
		Me.LayoutControlGroup5.CustomizationFormText = "Bahan Jadi"
		Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
		Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
		Me.LayoutControlGroup5.Size = New System.Drawing.Size(1100, 174)
		Me.LayoutControlGroup5.Text = "Bahan Jadi"
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.xGridBahanJadi
		Me.LayoutControlItem6.CustomizationFormText = "Bahan Jadi"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(1100, 174)
		Me.LayoutControlItem6.Text = "Bahan Jadi"
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem6.TextToControlDistance = 0
		Me.LayoutControlItem6.TextVisible = False
		'
		'LayoutControlGroup6
		'
		Me.LayoutControlGroup6.CustomizationFormText = "Template"
		Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.EmptySpaceItem4, Me.LayoutControlItem10, Me.LayoutControlItem12})
		Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 142)
		Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
		Me.LayoutControlGroup6.Size = New System.Drawing.Size(1108, 69)
		Me.LayoutControlGroup6.Text = "Template"
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtKodeBarang
		Me.LayoutControlItem9.CustomizationFormText = "Kode Barang"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(270, 26)
		Me.LayoutControlItem9.Text = "Kode Barang"
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(73, 13)
		'
		'EmptySpaceItem4
		'
		Me.EmptySpaceItem4.AllowHotTrack = False
		Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Location = New System.Drawing.Point(559, 0)
		Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Size = New System.Drawing.Size(525, 26)
		Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
		Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem10
		'
		Me.LayoutControlItem10.Control = Me.txtQty
		Me.LayoutControlItem10.CustomizationFormText = "Qty"
		Me.LayoutControlItem10.Location = New System.Drawing.Point(270, 0)
		Me.LayoutControlItem10.Name = "LayoutControlItem10"
		Me.LayoutControlItem10.Size = New System.Drawing.Size(100, 26)
		Me.LayoutControlItem10.Text = "Qty"
		Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem10.TextSize = New System.Drawing.Size(18, 13)
		Me.LayoutControlItem10.TextToControlDistance = 5
		'
		'LayoutControlItem11
		'
		Me.LayoutControlItem11.Control = Me.txtSatuan
		Me.LayoutControlItem11.CustomizationFormText = "Satuan"
		Me.LayoutControlItem11.Location = New System.Drawing.Point(370, 0)
		Me.LayoutControlItem11.Name = "LayoutControlItem11"
		Me.LayoutControlItem11.Size = New System.Drawing.Size(144, 26)
		Me.LayoutControlItem11.Text = "Satuan"
		Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem11.TextSize = New System.Drawing.Size(34, 13)
		Me.LayoutControlItem11.TextToControlDistance = 5
		'
		'LayoutControlItem12
		'
		Me.LayoutControlItem12.Control = Me.btnOK
		Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
		Me.LayoutControlItem12.Location = New System.Drawing.Point(370, 0)
		Me.LayoutControlItem12.Name = "LayoutControlItem12"
		Me.LayoutControlItem12.Size = New System.Drawing.Size(189, 26)
		Me.LayoutControlItem12.Text = "LayoutControlItem12"
		Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem12.TextToControlDistance = 0
		Me.LayoutControlItem12.TextVisible = False
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
		'ImageList1
		'
		Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		'
		'ImageList2
		'
		Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
		'
		'btnTemplate
		'
		Me.btnTemplate.Caption = "Template"
		Me.btnTemplate.Enabled = False
		Me.btnTemplate.Glyph = CType(resources.GetObject("btnTemplate.Glyph"), System.Drawing.Image)
		Me.btnTemplate.Id = 8
		Me.btnTemplate.LargeGlyph = CType(resources.GetObject("btnTemplate.LargeGlyph"), System.Drawing.Image)
		Me.btnTemplate.Name = "btnTemplate"
		Me.btnTemplate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
		'
		'btnRefresh
		'
		Me.btnRefresh.Caption = "Refresh"
		Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
		Me.btnRefresh.Id = 9
		Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
		Me.btnRefresh.Name = "btnRefresh"
		'
		'UI_ProduksiDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1134, 468)
		Me.Controls.Add(Me.hideContainerRight)
		Me.KeyPreview = True
		Me.Name = "UI_ProduksiDialog"
		Me.Text = "Produksi [Assembly/Disassembly]"
		Me.Controls.SetChildIndex(Me.hideContainerRight, 0)
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).EndInit()
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
		CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridCost, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridCostView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeCostRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridBahanJadi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridBahanJadiView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeBarangBJRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSatuanBJRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtGudangTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridBahanBaku, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridBahanBakuView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colGudangRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.layTipeEmpty, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents xGridBahanBaku As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridBahanBakuView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents colDivisiRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colGudangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
  Friend WithEvents txtGudang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
  Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents txtGudangTujuan As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents xGridBahanJadi As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridBahanJadiView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents xGridCost As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridCostView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKodeBarangBJ As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarangBJ As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyBJ As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuanBJ As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHPPBJ As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatanBJ As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeCoa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaCoa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJumlah As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatanCOA As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeCostRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colSatuanBJRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
  Friend WithEvents btnTemplate As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layTipeEmpty As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarangBJRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
	Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
	Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtSatuan As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
