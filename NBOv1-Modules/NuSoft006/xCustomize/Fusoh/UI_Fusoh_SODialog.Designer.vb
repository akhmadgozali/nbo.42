<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_Fusoh_SODialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Fusoh_SODialog))
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
        Me.txtTipeSO = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTglPO = New DevExpress.XtraEditors.DateEdit()
        Me.txtDelivery = New DevExpress.XtraEditors.DateEdit()
        Me.txtNoPO = New DevExpress.XtraEditors.TextEdit()
        Me.txtPajak = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtPPH = New DevExpress.XtraEditors.TextEdit()
        Me.txtPPN = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtValidiity1 = New DevExpress.XtraEditors.DateEdit()
        Me.txtNoPenawaran = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtValidiity2 = New DevExpress.XtraEditors.DateEdit()
        Me.txtInspection = New DevExpress.XtraEditors.TextEdit()
        Me.txtPayment = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTermin = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTermPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPOLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.colKodeRepoView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colInD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colHargaRp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPajakIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPajakOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPODetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colTglSanggup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
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
        Me.txtUraian = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
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
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.btnImpor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAmbilSQ = New DevExpress.XtraBars.BarButtonItem()
        Me.colETAMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.txtTipeSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTglPO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTglPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDelivery.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDelivery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidiity1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidiity1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoPenawaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidiity2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidiity2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInspection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTermPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colKodeRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colKodeRepoView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlamatText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barMan
        '
        Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.btnRefresh, Me.btnImpor, Me.btnAmbilSQ})
        Me.barMan.MaxItemId = 10
        '
        'barMenu
        '
        Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAmbilSQ, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImpor, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2, True)})
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
        Me.lytTransaksi.Controls.Add(Me.txtTipeSO)
        Me.lytTransaksi.Controls.Add(Me.txtTglPO)
        Me.lytTransaksi.Controls.Add(Me.txtDelivery)
        Me.lytTransaksi.Controls.Add(Me.txtNoPO)
        Me.lytTransaksi.Controls.Add(Me.txtPajak)
        Me.lytTransaksi.Controls.Add(Me.txtTotal)
        Me.lytTransaksi.Controls.Add(Me.txtPPH)
        Me.lytTransaksi.Controls.Add(Me.txtPPN)
        Me.lytTransaksi.Controls.Add(Me.txtSubTotal)
        Me.lytTransaksi.Controls.Add(Me.txtValidiity1)
        Me.lytTransaksi.Controls.Add(Me.txtNoPenawaran)
        Me.lytTransaksi.Controls.Add(Me.txtValidiity2)
        Me.lytTransaksi.Controls.Add(Me.txtInspection)
        Me.lytTransaksi.Controls.Add(Me.txtPayment)
        Me.lytTransaksi.Controls.Add(Me.txtStatus)
        Me.lytTransaksi.Controls.Add(Me.txtTermin)
        Me.lytTransaksi.Controls.Add(Me.txtUang)
        Me.lytTransaksi.Controls.Add(Me.txtTermPrice)
        Me.lytTransaksi.Controls.Add(Me.txtKontakPerson)
        Me.lytTransaksi.Controls.Add(Me.txtRegional)
        Me.lytTransaksi.Controls.Add(Me.txtTanggal)
        Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
        Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
        Me.lytTransaksi.Controls.Add(Me.xGrid)
        Me.lytTransaksi.Controls.Add(Me.txtKontak)
        Me.lytTransaksi.Controls.Add(Me.txtAlamatText)
        Me.lytTransaksi.Controls.Add(Me.txtAlamat)
        Me.lytTransaksi.Controls.Add(Me.txtKurs)
        Me.lytTransaksi.Controls.Add(Me.txtUraian)
        Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12})
        Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.lytTransaksi.Name = "lytTransaksi"
        Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 333, 250, 350)
        Me.lytTransaksi.Root = Me.layoutControlGroup1
        Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
        Me.lytTransaksi.TabIndex = 0
        Me.lytTransaksi.Text = "lytTransaksi"
        '
        'txtTipeSO
        '
        Me.txtTipeSO.Location = New System.Drawing.Point(955, 106)
        Me.txtTipeSO.MenuManager = Me.barMan
        Me.txtTipeSO.Name = "txtTipeSO"
        Me.txtTipeSO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTipeSO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value")})
        Me.txtTipeSO.Properties.DisplayMember = "Value"
        Me.txtTipeSO.Properties.NullText = "<Pilih Tipe SO>"
        Me.txtTipeSO.Properties.ValueMember = "Key"
        Me.txtTipeSO.Size = New System.Drawing.Size(161, 20)
        Me.txtTipeSO.StyleController = Me.lytTransaksi
        Me.txtTipeSO.TabIndex = 9
        '
        'txtTglPO
        '
        Me.txtTglPO.EditValue = Nothing
        Me.txtTglPO.Location = New System.Drawing.Point(407, 307)
        Me.txtTglPO.MenuManager = Me.barMan
        Me.txtTglPO.Name = "txtTglPO"
        Me.txtTglPO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTglPO.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTglPO.Size = New System.Drawing.Size(219, 20)
        Me.txtTglPO.StyleController = Me.lytTransaksi
        Me.txtTglPO.TabIndex = 17
        '
        'txtDelivery
        '
        Me.txtDelivery.EditValue = Nothing
        Me.txtDelivery.Location = New System.Drawing.Point(101, 355)
        Me.txtDelivery.MenuManager = Me.barMan
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDelivery.Size = New System.Drawing.Size(218, 20)
        Me.txtDelivery.StyleController = Me.lytTransaksi
        Me.txtDelivery.TabIndex = 25
        '
        'txtNoPO
        '
        Me.txtNoPO.EditValue = ""
        Me.txtNoPO.EnterMoveNextControl = True
        Me.txtNoPO.Location = New System.Drawing.Point(101, 307)
        Me.txtNoPO.MenuManager = Me.barMan
        Me.txtNoPO.Name = "txtNoPO"
        Me.txtNoPO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNoPO.Properties.NullText = "<PO No.>"
        Me.txtNoPO.Size = New System.Drawing.Size(218, 20)
        Me.txtNoPO.StyleController = Me.lytTransaksi
        Me.txtNoPO.TabIndex = 16
        '
        'txtPajak
        '
        Me.txtPajak.EnterMoveNextControl = True
        Me.txtPajak.Location = New System.Drawing.Point(690, 307)
        Me.txtPajak.MenuManager = Me.barMan
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPajak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPajak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
        Me.txtPajak.Properties.DisplayMember = "Value"
        Me.txtPajak.Properties.NullText = "<Pilih Tipe Pajak>"
        Me.txtPajak.Properties.PopupWidth = 20
        Me.txtPajak.Properties.ValueMember = "Key"
        Me.txtPajak.Size = New System.Drawing.Size(131, 20)
        Me.txtPajak.StyleController = Me.lytTransaksi
        Me.txtPajak.TabIndex = 18
        '
        'txtTotal
        '
        Me.txtTotal.EnterMoveNextControl = True
        Me.txtTotal.Location = New System.Drawing.Point(921, 391)
        Me.txtTotal.MenuManager = Me.barMan
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtTotal.Properties.Mask.EditMask = "n2"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(183, 20)
        Me.txtTotal.StyleController = Me.lytTransaksi
        Me.txtTotal.TabIndex = 22
        '
        'txtPPH
        '
        Me.txtPPH.EnterMoveNextControl = True
        Me.txtPPH.Location = New System.Drawing.Point(921, 367)
        Me.txtPPH.MenuManager = Me.barMan
        Me.txtPPH.Name = "txtPPH"
        Me.txtPPH.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPPH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPPH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPPH.Properties.Mask.EditMask = "n2"
        Me.txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPPH.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPPH.Properties.ReadOnly = True
        Me.txtPPH.Size = New System.Drawing.Size(183, 20)
        Me.txtPPH.StyleController = Me.lytTransaksi
        Me.txtPPH.TabIndex = 21
        '
        'txtPPN
        '
        Me.txtPPN.EnterMoveNextControl = True
        Me.txtPPN.Location = New System.Drawing.Point(921, 343)
        Me.txtPPN.MenuManager = Me.barMan
        Me.txtPPN.Name = "txtPPN"
        Me.txtPPN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPPN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPPN.Properties.Mask.EditMask = "n2"
        Me.txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPPN.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPPN.Properties.ReadOnly = True
        Me.txtPPN.Size = New System.Drawing.Size(183, 20)
        Me.txtPPN.StyleController = Me.lytTransaksi
        Me.txtPPN.TabIndex = 20
        '
        'txtSubTotal
        '
        Me.txtSubTotal.EnterMoveNextControl = True
        Me.txtSubTotal.Location = New System.Drawing.Point(921, 319)
        Me.txtSubTotal.MenuManager = Me.barMan
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSubTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtSubTotal.Properties.Mask.EditMask = "n2"
        Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSubTotal.Properties.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(183, 20)
        Me.txtSubTotal.StyleController = Me.lytTransaksi
        Me.txtSubTotal.TabIndex = 19
        '
        'txtValidiity1
        '
        Me.txtValidiity1.EditValue = Nothing
        Me.txtValidiity1.EnterMoveNextControl = True
        Me.txtValidiity1.Location = New System.Drawing.Point(739, 154)
        Me.txtValidiity1.MenuManager = Me.barMan
        Me.txtValidiity1.Name = "txtValidiity1"
        Me.txtValidiity1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtValidiity1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtValidiity1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtValidiity1.Size = New System.Drawing.Size(152, 20)
        Me.txtValidiity1.StyleController = Me.lytTransaksi
        Me.txtValidiity1.TabIndex = 13
        '
        'txtNoPenawaran
        '
        Me.txtNoPenawaran.EnterMoveNextControl = True
        Me.txtNoPenawaran.Location = New System.Drawing.Point(739, 106)
        Me.txtNoPenawaran.MenuManager = Me.barMan
        Me.txtNoPenawaran.Name = "txtNoPenawaran"
        Me.txtNoPenawaran.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNoPenawaran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNoPenawaran.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 90, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tanggal", "Tanggal", 70, DevExpress.Utils.FormatType.Custom, "dd MMM yyyy", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TanggalBerlakuAwal", "Awal Tgl Berlaku", 70, DevExpress.Utils.FormatType.Custom, "dd MMM yyyy", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TanggalBerlakuAkhir", "Akhir Tgl Berlaku", 70, DevExpress.Utils.FormatType.Custom, "dd MMM yyyy", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.txtNoPenawaran.Properties.DisplayMember = "Kode"
        Me.txtNoPenawaran.Properties.NullText = "<Pilih No SQ>"
        Me.txtNoPenawaran.Properties.PopupWidth = 400
        Me.txtNoPenawaran.Properties.ValueMember = "This"
        Me.txtNoPenawaran.Size = New System.Drawing.Size(152, 20)
        Me.txtNoPenawaran.StyleController = Me.lytTransaksi
        Me.txtNoPenawaran.TabIndex = 8
        '
        'txtValidiity2
        '
        Me.txtValidiity2.EditValue = Nothing
        Me.txtValidiity2.EnterMoveNextControl = True
        Me.txtValidiity2.Location = New System.Drawing.Point(955, 154)
        Me.txtValidiity2.MenuManager = Me.barMan
        Me.txtValidiity2.Name = "txtValidiity2"
        Me.txtValidiity2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtValidiity2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtValidiity2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtValidiity2.Size = New System.Drawing.Size(161, 20)
        Me.txtValidiity2.StyleController = Me.lytTransaksi
        Me.txtValidiity2.TabIndex = 14
        '
        'txtInspection
        '
        Me.txtInspection.EditValue = ""
        Me.txtInspection.EnterMoveNextControl = True
        Me.txtInspection.Location = New System.Drawing.Point(101, 403)
        Me.txtInspection.MenuManager = Me.barMan
        Me.txtInspection.Name = "txtInspection"
        Me.txtInspection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtInspection.Properties.NullText = "<Inspection>"
        Me.txtInspection.Size = New System.Drawing.Size(218, 20)
        Me.txtInspection.StyleController = Me.lytTransaksi
        Me.txtInspection.TabIndex = 27
        '
        'txtPayment
        '
        Me.txtPayment.EditValue = ""
        Me.txtPayment.EnterMoveNextControl = True
        Me.txtPayment.Location = New System.Drawing.Point(101, 379)
        Me.txtPayment.MenuManager = Me.barMan
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPayment.Properties.NullText = "<Payment>"
        Me.txtPayment.Size = New System.Drawing.Size(218, 20)
        Me.txtPayment.StyleController = Me.lytTransaksi
        Me.txtPayment.TabIndex = 26
        '
        'txtStatus
        '
        Me.txtStatus.EnterMoveNextControl = True
        Me.txtStatus.Location = New System.Drawing.Point(947, 61)
        Me.txtStatus.MenuManager = Me.barMan
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
        Me.txtStatus.Properties.DisplayMember = "Value"
        Me.txtStatus.Properties.NullText = "<Status>"
        Me.txtStatus.Properties.ValueMember = "Key"
        Me.txtStatus.Size = New System.Drawing.Size(133, 20)
        Me.txtStatus.StyleController = Me.lytTransaksi
        Me.txtStatus.TabIndex = 6
        '
        'txtTermin
        '
        Me.txtTermin.EnterMoveNextControl = True
        Me.txtTermin.Location = New System.Drawing.Point(101, 331)
        Me.txtTermin.MenuManager = Me.barMan
        Me.txtTermin.Name = "txtTermin"
        Me.txtTermin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtTermin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTermin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
        Me.txtTermin.Properties.DisplayMember = "Kode"
        Me.txtTermin.Properties.NullText = "<Termin>"
        Me.txtTermin.Properties.ValueMember = "This"
        Me.txtTermin.Size = New System.Drawing.Size(218, 20)
        Me.txtTermin.StyleController = Me.lytTransaksi
        Me.txtTermin.TabIndex = 16
        '
        'txtUang
        '
        Me.txtUang.EnterMoveNextControl = True
        Me.txtUang.Location = New System.Drawing.Point(739, 130)
        Me.txtUang.MenuManager = Me.barMan
        Me.txtUang.Name = "txtUang"
        Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtUang.Properties.DisplayMember = "Kode"
        Me.txtUang.Properties.NullText = "<Uang>"
        Me.txtUang.Properties.ValueMember = "This"
        Me.txtUang.Size = New System.Drawing.Size(152, 20)
        Me.txtUang.StyleController = Me.lytTransaksi
        Me.txtUang.TabIndex = 11
        '
        'txtTermPrice
        '
        Me.txtTermPrice.EditValue = ""
        Me.txtTermPrice.EnterMoveNextControl = True
        Me.txtTermPrice.Location = New System.Drawing.Point(101, 331)
        Me.txtTermPrice.MenuManager = Me.barMan
        Me.txtTermPrice.Name = "txtTermPrice"
        Me.txtTermPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtTermPrice.Properties.NullText = "<Term of Price>"
        Me.txtTermPrice.Size = New System.Drawing.Size(218, 20)
        Me.txtTermPrice.StyleController = Me.lytTransaksi
        Me.txtTermPrice.TabIndex = 23
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
        Me.txtKontakPerson.Size = New System.Drawing.Size(512, 20)
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
        Me.txtRegional.Size = New System.Drawing.Size(153, 20)
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
        Me.txtTanggal.Size = New System.Drawing.Size(153, 20)
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
        Me.txtNoTransaksi.Location = New System.Drawing.Point(947, 37)
        Me.txtNoTransaksi.MenuManager = Me.barMan
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNoTransaksi.Size = New System.Drawing.Size(133, 20)
        Me.txtNoTransaksi.StyleController = Me.lytTransaksi
        Me.txtNoTransaksi.TabIndex = 2
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(12, 178)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.MenuManager = Me.barMan
        Me.xGrid.Name = "xGrid"
        Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colHargaRepo, Me.colSpekRepo, Me.colKodeRepo, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.xGrid.Size = New System.Drawing.Size(1104, 125)
        Me.xGrid.TabIndex = 15
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.xGridView.ColumnPanelRowHeight = 30
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPOLine, Me.colKodeBarang, Me.colNamaBarang, Me.colOD, Me.colInD, Me.colThickness, Me.colLength, Me.colQty, Me.colWeight, Me.colHarga, Me.colHargaRp, Me.colSubTotal, Me.colPajakIn, Me.colPajakOut, Me.colTotal, Me.colCatatan, Me.colNoPODetail, Me.colDeliveryDate, Me.colTglSanggup, Me.colETAMaterial})
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
        'colPOLine
        '
        Me.colPOLine.Caption = "PO Line"
        Me.colPOLine.FieldName = "POLine"
        Me.colPOLine.Name = "colPOLine"
        Me.colPOLine.Visible = True
        Me.colPOLine.VisibleIndex = 0
        Me.colPOLine.Width = 43
        '
        'colKodeBarang
        '
        Me.colKodeBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.colKodeBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKodeBarang.Caption = "Part No."
        Me.colKodeBarang.ColumnEdit = Me.colKodeRepo
        Me.colKodeBarang.FieldName = "Barang!"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 1
        Me.colKodeBarang.Width = 95
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
        Me.colKodeRepoView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.colKodeRepoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.colKodeRepoView.Name = "colKodeRepoView"
        Me.colKodeRepoView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.colKodeRepoView.OptionsView.ShowAutoFilterRow = True
        Me.colKodeRepoView.OptionsView.ShowGroupPanel = False
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
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Out"
        Me.GridColumn5.FieldName = "OutDiameter"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "IN"
        Me.GridColumn6.FieldName = "InDiameter"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Length"
        Me.GridColumn7.FieldName = "Length"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Thickness"
        Me.GridColumn8.FieldName = "Thickness"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        '
        'colNamaBarang
        '
        Me.colNamaBarang.AppearanceCell.Options.UseTextOptions = True
        Me.colNamaBarang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNamaBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.colNamaBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNamaBarang.Caption = "Material"
        Me.colNamaBarang.FieldName = "NamaBarang"
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.OptionsColumn.AllowEdit = False
        Me.colNamaBarang.OptionsColumn.ReadOnly = True
        Me.colNamaBarang.Visible = True
        Me.colNamaBarang.VisibleIndex = 2
        Me.colNamaBarang.Width = 95
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
        Me.colOD.VisibleIndex = 3
        Me.colOD.Width = 45
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
        Me.colInD.VisibleIndex = 4
        Me.colInD.Width = 45
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
        Me.colThickness.Width = 45
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
        Me.colLength.Width = 45
        '
        'colQty
        '
        Me.colQty.AppearanceCell.Options.UseTextOptions = True
        Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQty.Caption = "Min Qty"
        Me.colQty.ColumnEdit = Me.colSpekRepo
        Me.colQty.DisplayFormat.FormatString = "n2"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowSize = False
        Me.colQty.OptionsColumn.FixedWidth = True
        Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 7
        Me.colQty.Width = 50
        '
        'colWeight
        '
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
        Me.colWeight.Visible = True
        Me.colWeight.VisibleIndex = 8
        Me.colWeight.Width = 55
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
        Me.colHarga.Width = 70
        '
        'colHargaRepo
        '
        Me.colHargaRepo.AutoHeight = False
        Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colHargaRepo.Name = "colHargaRepo"
        '
        'colHargaRp
        '
        Me.colHargaRp.AppearanceCell.Options.UseTextOptions = True
        Me.colHargaRp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHargaRp.AppearanceHeader.Options.UseTextOptions = True
        Me.colHargaRp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHargaRp.Caption = "Price"
        Me.colHargaRp.DisplayFormat.FormatString = "n2"
        Me.colHargaRp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHargaRp.FieldName = "HargaKurs"
        Me.colHargaRp.Name = "colHargaRp"
        Me.colHargaRp.OptionsColumn.AllowEdit = False
        Me.colHargaRp.OptionsColumn.ReadOnly = True
        Me.colHargaRp.Visible = True
        Me.colHargaRp.VisibleIndex = 10
        Me.colHargaRp.Width = 80
        '
        'colSubTotal
        '
        Me.colSubTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubTotal.Caption = "Sub Total"
        Me.colSubTotal.DisplayFormat.FormatString = "n2"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.OptionsColumn.AllowEdit = False
        Me.colSubTotal.OptionsColumn.ReadOnly = True
        Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 11
        Me.colSubTotal.Width = 90
        '
        'colPajakIn
        '
        Me.colPajakIn.AppearanceHeader.Options.UseTextOptions = True
        Me.colPajakIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPajakIn.Caption = "Pajak In"
        Me.colPajakIn.FieldName = "PPN.Kode"
        Me.colPajakIn.Name = "colPajakIn"
        Me.colPajakIn.OptionsColumn.AllowEdit = False
        Me.colPajakIn.OptionsColumn.ReadOnly = True
        Me.colPajakIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPNv", "")})
        Me.colPajakIn.Visible = True
        Me.colPajakIn.VisibleIndex = 12
        Me.colPajakIn.Width = 50
        '
        'colPajakOut
        '
        Me.colPajakOut.AppearanceHeader.Options.UseTextOptions = True
        Me.colPajakOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPajakOut.Caption = "Pajak Out"
        Me.colPajakOut.FieldName = "PPH.Kode"
        Me.colPajakOut.Name = "colPajakOut"
        Me.colPajakOut.OptionsColumn.AllowEdit = False
        Me.colPajakOut.OptionsColumn.ReadOnly = True
        Me.colPajakOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPHv", "")})
        Me.colPajakOut.Visible = True
        Me.colPajakOut.VisibleIndex = 13
        Me.colPajakOut.Width = 55
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "n2"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowEdit = False
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 14
        Me.colTotal.Width = 90
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
        Me.colCatatan.VisibleIndex = 15
        Me.colCatatan.Width = 116
        '
        'colNoPODetail
        '
        Me.colNoPODetail.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoPODetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoPODetail.Caption = "No. PO"
        Me.colNoPODetail.FieldName = "NoPODetail"
        Me.colNoPODetail.Name = "colNoPODetail"
        Me.colNoPODetail.Visible = True
        Me.colNoPODetail.VisibleIndex = 16
        '
        'colDeliveryDate
        '
        Me.colDeliveryDate.Caption = "Delivery Date"
        Me.colDeliveryDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colDeliveryDate.FieldName = "DeliveryDate"
        Me.colDeliveryDate.Name = "colDeliveryDate"
        Me.colDeliveryDate.Visible = True
        Me.colDeliveryDate.VisibleIndex = 17
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colTglSanggup
        '
        Me.colTglSanggup.Caption = "Tgl Sanggup"
        Me.colTglSanggup.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.colTglSanggup.FieldName = "TanggalSanggup"
        Me.colTglSanggup.Name = "colTglSanggup"
        Me.colTglSanggup.Visible = True
        Me.colTglSanggup.VisibleIndex = 18
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
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
        Me.txtKontak.Properties.DisplayMember = "Nama"
        Me.txtKontak.Properties.NullText = "<Pilih Customer>"
        Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
        Me.txtKontak.Properties.ShowClearButton = False
        Me.txtKontak.Properties.ShowFooter = False
        Me.txtKontak.Properties.ValueMember = "This"
        Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
        Me.txtKontak.Size = New System.Drawing.Size(512, 20)
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
        Me.txtAlamatText.Size = New System.Drawing.Size(235, 44)
        Me.txtAlamatText.StyleController = Me.lytTransaksi
        Me.txtAlamatText.TabIndex = 10
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
        Me.txtKurs.Location = New System.Drawing.Point(955, 130)
        Me.txtKurs.MenuManager = Me.barMan
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtKurs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKurs.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtKurs.Properties.MaxLength = 255
        Me.txtKurs.Size = New System.Drawing.Size(161, 20)
        Me.txtKurs.StyleController = Me.lytTransaksi
        Me.txtKurs.TabIndex = 12
        '
        'txtUraian
        '
        Me.txtUraian.EnterMoveNextControl = True
        Me.txtUraian.Location = New System.Drawing.Point(328, 347)
        Me.txtUraian.MenuManager = Me.barMan
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUraian.Properties.MaxLength = 255
        Me.txtUraian.Size = New System.Drawing.Size(298, 76)
        Me.txtUraian.StyleController = Me.lytTransaksi
        Me.txtUraian.TabIndex = 24
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtTermin
        Me.LayoutControlItem12.CustomizationFormText = "Termin"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 319)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem12.Text = "Term of Delivery"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(81, 13)
        Me.LayoutControlItem12.TextToControlDistance = 5
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.CustomizationFormText = "Root"
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlGroup3, Me.EmptySpaceItem1, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem11, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlGroup4, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem4, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem23, Me.LayoutControlItem27})
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
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1108, 129)
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
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem1, Me.lytRegional, Me.LayoutControlItem14, Me.EmptySpaceItem3})
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
        Me.layKontak.Size = New System.Drawing.Size(590, 24)
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
        Me.LayoutControlItem15.Size = New System.Drawing.Size(242, 24)
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
        Me.LayoutControlItem16.Location = New System.Drawing.Point(876, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(190, 24)
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
        Me.LayoutControlItem1.Size = New System.Drawing.Size(590, 24)
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
        Me.lytRegional.Size = New System.Drawing.Size(242, 24)
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
        Me.LayoutControlItem14.Location = New System.Drawing.Point(876, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(190, 24)
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
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(590, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(44, 48)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(244, 94)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(398, 72)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
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
        Me.LayoutControlItem22.Size = New System.Drawing.Size(244, 48)
        Me.LayoutControlItem22.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem22.Text = "Alamat Text"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextToControlDistance = 0
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem11.Control = Me.txtNoPenawaran
        Me.LayoutControlItem11.CustomizationFormText = "Tarik SQ"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(642, 94)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(241, 24)
        Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem11.Text = "Tarik SQ"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtTermPrice
        Me.LayoutControlItem5.CustomizationFormText = "Lead Time"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 319)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem5.Text = "Term of Price"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtValidiity1
        Me.LayoutControlItem6.CustomizationFormText = "Validity"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(642, 142)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(241, 24)
        Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem6.Text = "Validity"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtValidiity2
        Me.LayoutControlItem9.CustomizationFormText = "s/d"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(883, 142)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem9.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem9.Text = "s/d"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(50, 13)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(813, 295)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(295, 120)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup4"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtSubTotal
        Me.LayoutControlItem13.CustomizationFormText = "Sub Total"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(271, 24)
        Me.LayoutControlItem13.Text = "Sub Total"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtPPN
        Me.LayoutControlItem18.CustomizationFormText = "PPN"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(271, 24)
        Me.LayoutControlItem18.Text = "PPN"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtPPH
        Me.LayoutControlItem19.CustomizationFormText = "PPH"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(271, 24)
        Me.LayoutControlItem19.Text = "PPH"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtTotal
        Me.LayoutControlItem20.CustomizationFormText = "Total Transaksi   "
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(271, 24)
        Me.LayoutControlItem20.Text = "Total Transaksi   "
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtPayment
        Me.LayoutControlItem2.CustomizationFormText = "Payment"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 367)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem2.Text = "Payment"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtInspection
        Me.LayoutControlItem4.CustomizationFormText = "Inspection"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 391)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem4.Text = "Inspection"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(618, 319)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(195, 96)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.Control = Me.txtUang
        Me.LayoutControlItem8.CustomizationFormText = "Uang"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(642, 118)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(241, 24)
        Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem8.Text = "Currency"
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtKurs
        Me.LayoutControlItem10.CustomizationFormText = "Kurs"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(883, 118)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem10.Text = "Kurs"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(50, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtUraian
        Me.LayoutControlItem3.CustomizationFormText = "Uraian"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(311, 319)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(307, 96)
        Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem3.Text = "Others"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem24.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem24.Control = Me.txtNoPO
        Me.LayoutControlItem24.CustomizationFormText = "PO No."
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 295)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem24.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem24.Text = "PO No."
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtDelivery
        Me.LayoutControlItem25.CustomizationFormText = "Term of Delivery"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 343)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem25.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem25.Text = "Term of Delivery"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtTglPO
        Me.LayoutControlItem26.CustomizationFormText = "Tgl PO"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(311, 295)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(307, 24)
        Me.LayoutControlItem26.Text = "Tgl PO"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtPajak
        Me.LayoutControlItem23.CustomizationFormText = "Pajak"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(618, 295)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem23.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem23.Text = "Pajak"
        Me.LayoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(50, 20)
        Me.LayoutControlItem23.TextToControlDistance = 5
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtTipeSO
        Me.LayoutControlItem27.CustomizationFormText = "Tipe"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(883, 94)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem27.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem27.Text = "Tipe"
        Me.LayoutControlItem27.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(50, 13)
        Me.LayoutControlItem27.TextToControlDistance = 5
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
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(865, 295)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(243, 120)
        Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'btnImpor
        '
        Me.btnImpor.Caption = "&Impor"
        Me.btnImpor.Glyph = CType(resources.GetObject("btnImpor.Glyph"), System.Drawing.Image)
        Me.btnImpor.Id = 9
        Me.btnImpor.LargeGlyph = CType(resources.GetObject("btnImpor.LargeGlyph"), System.Drawing.Image)
        Me.btnImpor.Name = "btnImpor"
        '
        'btnAmbilSQ
        '
        Me.btnAmbilSQ.Caption = "Ambil Data SQ"
        Me.btnAmbilSQ.Glyph = CType(resources.GetObject("btnAmbilSQ.Glyph"), System.Drawing.Image)
        Me.btnAmbilSQ.Id = 9
        Me.btnAmbilSQ.LargeGlyph = CType(resources.GetObject("btnAmbilSQ.LargeGlyph"), System.Drawing.Image)
        Me.btnAmbilSQ.Name = "btnAmbilSQ"
        '
        'colETAMaterial
        '
        Me.colETAMaterial.Caption = "ETA Material"
        Me.colETAMaterial.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.colETAMaterial.FieldName = "ETAMaterial"
        Me.colETAMaterial.Name = "colETAMaterial"
        Me.colETAMaterial.Visible = True
        Me.colETAMaterial.VisibleIndex = 19
        '
        'UI_Fusoh_SODialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 468)
        Me.Controls.Add(Me.hideContainerRight)
        Me.KeyPreview = True
        Me.Name = "UI_Fusoh_SODialog"
        Me.Text = "Order Penjualan [SO]"
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
        CType(Me.txtTipeSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTglPO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTglPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDelivery.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDelivery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidiity1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidiity1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoPenawaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidiity2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidiity2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInspection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTermPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colKodeRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colKodeRepoView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlamatText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtTermin As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
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
	Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
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
	Friend WithEvents txtNoPenawaran As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents txtValidiity1 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtPPN As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtPPH As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtUraian As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents colPajakIn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPajakOut As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtPajak As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
	Friend WithEvents colKodeRepoView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents txtNoPO As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colPOLine As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnImpor As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNoPODetail As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtDelivery As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTglPO As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents txtTipeSO As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents btnAmbilSQ As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colTglSanggup As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colETAMaterial As DevExpress.XtraGrid.Columns.GridColumn
End Class
