﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohOrderProduksiDialog
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohOrderProduksiDialog))
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
		Me.chkTampilkanMaster = New DevExpress.XtraEditors.CheckEdit()
		Me.txtPrioritas = New DevExpress.XtraEditors.CheckEdit()
		Me.txtNoPDO = New DevExpress.XtraEditors.TextEdit()
		Me.txtTargetFinish = New DevExpress.XtraEditors.TextEdit()
		Me.txtRMDibutuhkan = New DevExpress.XtraEditors.TextEdit()
		Me.txtCutting = New DevExpress.XtraEditors.TextEdit()
		Me.txtLength = New DevExpress.XtraEditors.TextEdit()
		Me.txtSize = New DevExpress.XtraEditors.TextEdit()
		Me.txtPartNo = New DevExpress.XtraEditors.TextEdit()
		Me.txtMaterial = New DevExpress.XtraEditors.TextEdit()
		Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtPOLine = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
		Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
		Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
		Me.colKodeRepoView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colBarangKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangID = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangT = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangL = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colInD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMillSheet = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSN = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSNRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.colLengthSN = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMaterialLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colScrap = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
		Me.txtLengthTolerance = New DevExpress.XtraEditors.MemoEdit()
		Me.txtMaterialCorner = New DevExpress.XtraEditors.MemoEdit()
		Me.txtColourCode = New DevExpress.XtraEditors.MemoEdit()
		Me.txtQty = New DevExpress.XtraEditors.SpinEdit()
		Me.txtNoLOT = New DevExpress.XtraEditors.TextEdit()
		Me.txtNoDrawing = New DevExpress.XtraEditors.TextEdit()
		Me.txtMaterialFlow = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.txtDeliveryDate = New DevExpress.XtraEditors.TextEdit()
		Me.txtNoPO = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colNomorPO = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggalPO = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTipeSO = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtNoCutting = New DevExpress.XtraEditors.CheckEdit()
		Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
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
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
		Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
		Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
		Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
		Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
		Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
		Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
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
		CType(Me.chkTampilkanMaster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPrioritas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoPDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTargetFinish.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRMDibutuhkan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCutting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtLength.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPOLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colKodeRepoView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSNRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtLengthTolerance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMaterialCorner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtColourCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoLOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoDrawing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMaterialFlow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDeliveryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoCutting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
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
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barMenu
		'
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
		Me.hideContainerRight.Location = New System.Drawing.Point(997, 0)
		Me.hideContainerRight.Name = "hideContainerRight"
		Me.hideContainerRight.Size = New System.Drawing.Size(19, 527)
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
		Me.DockPanel1.Size = New System.Drawing.Size(250, 527)
		Me.DockPanel1.Text = "Panel Informasi"
		Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
		'
		'DockPanel1_Container
		'
		Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
		Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
		Me.DockPanel1_Container.Name = "DockPanel1_Container"
		Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 500)
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
		Me.NavBarControl1.Size = New System.Drawing.Size(242, 500)
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
		Me.DockPanel2.OriginalSize = New System.Drawing.Size(1010, 521)
		Me.DockPanel2.Text = "DockPanel2"
		'
		'DockPanel2_Container
		'
		Me.DockPanel2_Container.Controls.Add(Me.lytTransaksi)
		Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
		Me.DockPanel2_Container.Name = "DockPanel2_Container"
		Me.DockPanel2_Container.Size = New System.Drawing.Size(1010, 521)
		Me.DockPanel2_Container.TabIndex = 0
		'
		'lytTransaksi
		'
		Me.lytTransaksi.Controls.Add(Me.chkTampilkanMaster)
		Me.lytTransaksi.Controls.Add(Me.txtPrioritas)
		Me.lytTransaksi.Controls.Add(Me.txtNoPDO)
		Me.lytTransaksi.Controls.Add(Me.txtTargetFinish)
		Me.lytTransaksi.Controls.Add(Me.txtRMDibutuhkan)
		Me.lytTransaksi.Controls.Add(Me.txtCutting)
		Me.lytTransaksi.Controls.Add(Me.txtLength)
		Me.lytTransaksi.Controls.Add(Me.txtSize)
		Me.lytTransaksi.Controls.Add(Me.txtPartNo)
		Me.lytTransaksi.Controls.Add(Me.txtMaterial)
		Me.lytTransaksi.Controls.Add(Me.txtStatus)
		Me.lytTransaksi.Controls.Add(Me.txtPOLine)
		Me.lytTransaksi.Controls.Add(Me.txtGudang)
		Me.lytTransaksi.Controls.Add(Me.txtRegional)
		Me.lytTransaksi.Controls.Add(Me.txtTanggal)
		Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
		Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
		Me.lytTransaksi.Controls.Add(Me.xGrid)
		Me.lytTransaksi.Controls.Add(Me.txtKontak)
		Me.lytTransaksi.Controls.Add(Me.txtRemark)
		Me.lytTransaksi.Controls.Add(Me.txtLengthTolerance)
		Me.lytTransaksi.Controls.Add(Me.txtMaterialCorner)
		Me.lytTransaksi.Controls.Add(Me.txtColourCode)
		Me.lytTransaksi.Controls.Add(Me.txtQty)
		Me.lytTransaksi.Controls.Add(Me.txtNoLOT)
		Me.lytTransaksi.Controls.Add(Me.txtNoDrawing)
		Me.lytTransaksi.Controls.Add(Me.txtMaterialFlow)
		Me.lytTransaksi.Controls.Add(Me.txtDeliveryDate)
		Me.lytTransaksi.Controls.Add(Me.txtNoPO)
		Me.lytTransaksi.Controls.Add(Me.txtNoCutting)
		Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem22})
		Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksi.Name = "lytTransaksi"
		Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(356, 268, 250, 350)
		Me.lytTransaksi.Root = Me.layoutControlGroup1
		Me.lytTransaksi.Size = New System.Drawing.Size(1010, 521)
		Me.lytTransaksi.TabIndex = 0
		Me.lytTransaksi.Text = "lytTransaksi"
		'
		'chkTampilkanMaster
		'
		Me.chkTampilkanMaster.Location = New System.Drawing.Point(18, 197)
		Me.chkTampilkanMaster.MenuManager = Me.barMan
		Me.chkTampilkanMaster.Name = "chkTampilkanMaster"
		Me.chkTampilkanMaster.Properties.Caption = "Tampilkan Hanya Master Produksi"
		Me.chkTampilkanMaster.Size = New System.Drawing.Size(182, 19)
		Me.chkTampilkanMaster.StyleController = Me.lytTransaksi
		Me.chkTampilkanMaster.TabIndex = 14
		'
		'txtPrioritas
		'
		Me.txtPrioritas.EditValue = Nothing
		Me.txtPrioritas.Location = New System.Drawing.Point(789, 202)
		Me.txtPrioritas.MenuManager = Me.barMan
		Me.txtPrioritas.Name = "txtPrioritas"
		Me.txtPrioritas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtPrioritas.Properties.Caption = "Prioritas"
		Me.txtPrioritas.Size = New System.Drawing.Size(209, 21)
		Me.txtPrioritas.StyleController = Me.lytTransaksi
		Me.txtPrioritas.TabIndex = 22
		'
		'txtNoPDO
		'
		Me.txtNoPDO.Location = New System.Drawing.Point(661, 130)
		Me.txtNoPDO.MenuManager = Me.barMan
		Me.txtNoPDO.Name = "txtNoPDO"
		Me.txtNoPDO.Size = New System.Drawing.Size(337, 20)
		Me.txtNoPDO.StyleController = Me.lytTransaksi
		Me.txtNoPDO.TabIndex = 18
		'
		'txtTargetFinish
		'
		Me.txtTargetFinish.Location = New System.Drawing.Point(661, 202)
		Me.txtTargetFinish.MenuManager = Me.barMan
		Me.txtTargetFinish.Name = "txtTargetFinish"
		Me.txtTargetFinish.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTargetFinish.Size = New System.Drawing.Size(337, 20)
		Me.txtTargetFinish.StyleController = Me.lytTransaksi
		Me.txtTargetFinish.TabIndex = 26
		'
		'txtRMDibutuhkan
		'
		Me.txtRMDibutuhkan.Location = New System.Drawing.Point(383, 221)
		Me.txtRMDibutuhkan.MenuManager = Me.barMan
		Me.txtRMDibutuhkan.Name = "txtRMDibutuhkan"
		Me.txtRMDibutuhkan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtRMDibutuhkan.Properties.Appearance.Options.UseBackColor = True
		Me.txtRMDibutuhkan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRMDibutuhkan.Properties.DisplayFormat.FormatString = "n0"
		Me.txtRMDibutuhkan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtRMDibutuhkan.Properties.ReadOnly = True
		Me.txtRMDibutuhkan.Size = New System.Drawing.Size(170, 20)
		Me.txtRMDibutuhkan.StyleController = Me.lytTransaksi
		Me.txtRMDibutuhkan.TabIndex = 16
		'
		'txtCutting
		'
		Me.txtCutting.Location = New System.Drawing.Point(383, 197)
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
		Me.txtCutting.Size = New System.Drawing.Size(170, 20)
		Me.txtCutting.StyleController = Me.lytTransaksi
		Me.txtCutting.TabIndex = 15
		'
		'txtLength
		'
		Me.txtLength.EnterMoveNextControl = True
		Me.txtLength.Location = New System.Drawing.Point(385, 173)
		Me.txtLength.MenuManager = Me.barMan
		Me.txtLength.Name = "txtLength"
		Me.txtLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtLength.Properties.Appearance.Options.UseBackColor = True
		Me.txtLength.Properties.Appearance.Options.UseTextOptions = True
		Me.txtLength.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtLength.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtLength.Properties.ReadOnly = True
		Me.txtLength.Size = New System.Drawing.Size(82, 20)
		Me.txtLength.StyleController = Me.lytTransaksi
		Me.txtLength.TabIndex = 12
		'
		'txtSize
		'
		Me.txtSize.EnterMoveNextControl = True
		Me.txtSize.Location = New System.Drawing.Point(292, 173)
		Me.txtSize.MenuManager = Me.barMan
		Me.txtSize.Name = "txtSize"
		Me.txtSize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtSize.Properties.Appearance.Options.UseBackColor = True
		Me.txtSize.Properties.Appearance.Options.UseTextOptions = True
		Me.txtSize.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtSize.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtSize.Properties.ReadOnly = True
		Me.txtSize.Size = New System.Drawing.Size(84, 20)
		Me.txtSize.StyleController = Me.lytTransaksi
		Me.txtSize.TabIndex = 11
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
		Me.txtPartNo.Size = New System.Drawing.Size(182, 20)
		Me.txtPartNo.StyleController = Me.lytTransaksi
		Me.txtPartNo.TabIndex = 9
		'
		'txtMaterial
		'
		Me.txtMaterial.EditValue = ""
		Me.txtMaterial.EnterMoveNextControl = True
		Me.txtMaterial.Location = New System.Drawing.Point(209, 173)
		Me.txtMaterial.MenuManager = Me.barMan
		Me.txtMaterial.Name = "txtMaterial"
		Me.txtMaterial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtMaterial.Properties.Appearance.Options.UseBackColor = True
		Me.txtMaterial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMaterial.Properties.ReadOnly = True
		Me.txtMaterial.Size = New System.Drawing.Size(74, 20)
		Me.txtMaterial.StyleController = Me.lytTransaksi
		Me.txtMaterial.TabIndex = 10
		'
		'txtStatus
		'
		Me.txtStatus.EnterMoveNextControl = True
		Me.txtStatus.Location = New System.Drawing.Point(844, 61)
		Me.txtStatus.MenuManager = Me.barMan
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
		Me.txtStatus.Properties.DisplayMember = "Value"
		Me.txtStatus.Properties.NullText = "<Status>"
		Me.txtStatus.Properties.ValueMember = "Key"
		Me.txtStatus.Size = New System.Drawing.Size(118, 20)
		Me.txtStatus.StyleController = Me.lytTransaksi
		Me.txtStatus.TabIndex = 6
		'
		'txtPOLine
		'
		Me.txtPOLine.EnterMoveNextControl = True
		Me.txtPOLine.Location = New System.Drawing.Point(366, 131)
		Me.txtPOLine.MenuManager = Me.barMan
		Me.txtPOLine.Name = "txtPOLine"
		Me.txtPOLine.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtPOLine.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtPOLine.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtPOLine.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoPODetail", "PO Detail"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POLine", 15, "PO Line"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KodeBarang", 50, "Part No."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaBarang", 50, "Material"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OutDiameter", "OD", 15, DevExpress.Utils.FormatType.Numeric, "n1", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Thickness", "T", 15, DevExpress.Utils.FormatType.Numeric, "n1", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Length", "L", 15, DevExpress.Utils.FormatType.Numeric, "n1", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Qty", "Qty", 15, DevExpress.Utils.FormatType.Numeric, "n0", True, DevExpress.Utils.HorzAlignment.[Default])})
		Me.txtPOLine.Properties.DisplayMember = "POLine"
		Me.txtPOLine.Properties.NullText = "<Pilih PO Line>"
		Me.txtPOLine.Properties.PopupWidth = 600
		Me.txtPOLine.Properties.ValueMember = "This"
		Me.txtPOLine.Size = New System.Drawing.Size(187, 20)
		Me.txtPOLine.StyleController = Me.lytTransaksi
		Me.txtPOLine.TabIndex = 8
		'
		'txtGudang
		'
		Me.txtGudang.EnterMoveNextControl = True
		Me.txtGudang.Location = New System.Drawing.Point(92, 61)
		Me.txtGudang.MenuManager = Me.barMan
		Me.txtGudang.Name = "txtGudang"
		Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
		Me.txtGudang.Properties.DisplayMember = "Kode"
		Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
		Me.txtGudang.Properties.ValueMember = "This"
		Me.txtGudang.Size = New System.Drawing.Size(168, 20)
		Me.txtGudang.StyleController = Me.lytTransaksi
		Me.txtGudang.TabIndex = 4
		'
		'txtRegional
		'
		Me.txtRegional.EnterMoveNextControl = True
		Me.txtRegional.Location = New System.Drawing.Point(675, 61)
		Me.txtRegional.MenuManager = Me.barMan
		Me.txtRegional.Name = "txtRegional"
		Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
		Me.txtRegional.Properties.DisplayMember = "Nama"
		Me.txtRegional.Properties.NullText = "<Pilih Regional>"
		Me.txtRegional.Properties.ValueMember = "This"
		Me.txtRegional.Size = New System.Drawing.Size(112, 20)
		Me.txtRegional.StyleController = Me.lytTransaksi
		Me.txtRegional.TabIndex = 5
		'
		'txtTanggal
		'
		Me.txtTanggal.EditValue = Nothing
		Me.txtTanggal.EnterMoveNextControl = True
		Me.txtTanggal.Location = New System.Drawing.Point(675, 37)
		Me.txtTanggal.MenuManager = Me.barMan
		Me.txtTanggal.Name = "txtTanggal"
		Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal.Size = New System.Drawing.Size(112, 20)
		Me.txtTanggal.StyleController = Me.lytTransaksi
		Me.txtTanggal.TabIndex = 1
		'
		'btnRefreshNomor
		'
		Me.btnRefreshNomor.AutoWidthInLayoutControl = True
		Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
		Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
		Me.btnRefreshNomor.Location = New System.Drawing.Point(966, 37)
		Me.btnRefreshNomor.Name = "btnRefreshNomor"
		Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
		Me.btnRefreshNomor.StyleController = Me.lytTransaksi
		Me.btnRefreshNomor.TabIndex = 3
		'
		'txtNoTransaksi
		'
		Me.txtNoTransaksi.EnterMoveNextControl = True
		Me.txtNoTransaksi.Location = New System.Drawing.Point(844, 37)
		Me.txtNoTransaksi.MenuManager = Me.barMan
		Me.txtNoTransaksi.Name = "txtNoTransaksi"
		Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoTransaksi.Size = New System.Drawing.Size(118, 20)
		Me.txtNoTransaksi.StyleController = Me.lytTransaksi
		Me.txtNoTransaksi.TabIndex = 2
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 279)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.MenuManager = Me.barMan
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpekRepo, Me.colKodeRepo, Me.colSNRepo})
		Me.xGrid.Size = New System.Drawing.Size(986, 123)
		Me.xGrid.TabIndex = 23
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
		Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.xGridView.ColumnPanelRowHeight = 30
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colOD, Me.colInD, Me.colThickness, Me.colLength, Me.colMillSheet, Me.colSN, Me.colLengthSN, Me.colMaterialLength, Me.colQty, Me.colWeight, Me.colScrap, Me.colCatatan})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.IndicatorWidth = 30
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
		'colKodeBarang
		'
		Me.colKodeBarang.AppearanceHeader.Options.UseTextOptions = True
		Me.colKodeBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colKodeBarang.Caption = "Part No."
		Me.colKodeBarang.ColumnEdit = Me.colKodeRepo
		Me.colKodeBarang.FieldName = "Barang!"
		Me.colKodeBarang.Name = "colKodeBarang"
		Me.colKodeBarang.Visible = True
		Me.colKodeBarang.VisibleIndex = 0
		Me.colKodeBarang.Width = 98
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
		Me.colKodeRepoView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBarangKode, Me.colBarangNama, Me.colBarangOD, Me.colBarangID, Me.colBarangT, Me.colBarangL})
		Me.colKodeRepoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.colKodeRepoView.Name = "colKodeRepoView"
		Me.colKodeRepoView.OptionsFind.FindDelay = 500
		Me.colKodeRepoView.OptionsFind.SearchInPreview = True
		Me.colKodeRepoView.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.colKodeRepoView.OptionsView.ShowAutoFilterRow = True
		Me.colKodeRepoView.OptionsView.ShowGroupPanel = False
		'
		'colBarangKode
		'
		Me.colBarangKode.Caption = "Kode"
		Me.colBarangKode.FieldName = "Kode"
		Me.colBarangKode.Name = "colBarangKode"
		Me.colBarangKode.Visible = True
		Me.colBarangKode.VisibleIndex = 0
		Me.colBarangKode.Width = 90
		'
		'colBarangNama
		'
		Me.colBarangNama.Caption = "Nama"
		Me.colBarangNama.FieldName = "Nama"
		Me.colBarangNama.Name = "colBarangNama"
		Me.colBarangNama.Visible = True
		Me.colBarangNama.VisibleIndex = 1
		Me.colBarangNama.Width = 90
		'
		'colBarangOD
		'
		Me.colBarangOD.Caption = "OD"
		Me.colBarangOD.DisplayFormat.FormatString = "n0"
		Me.colBarangOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colBarangOD.FieldName = "OutDiameter"
		Me.colBarangOD.Name = "colBarangOD"
		Me.colBarangOD.Visible = True
		Me.colBarangOD.VisibleIndex = 2
		Me.colBarangOD.Width = 50
		'
		'colBarangID
		'
		Me.colBarangID.Caption = "ID"
		Me.colBarangID.DisplayFormat.FormatString = "n0"
		Me.colBarangID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colBarangID.FieldName = "InDiameter"
		Me.colBarangID.Name = "colBarangID"
		Me.colBarangID.Visible = True
		Me.colBarangID.VisibleIndex = 3
		Me.colBarangID.Width = 50
		'
		'colBarangT
		'
		Me.colBarangT.Caption = "T"
		Me.colBarangT.DisplayFormat.FormatString = "n0"
		Me.colBarangT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colBarangT.FieldName = "Thickness"
		Me.colBarangT.Name = "colBarangT"
		Me.colBarangT.Visible = True
		Me.colBarangT.VisibleIndex = 4
		Me.colBarangT.Width = 50
		'
		'colBarangL
		'
		Me.colBarangL.Caption = "L"
		Me.colBarangL.DisplayFormat.FormatString = "n0"
		Me.colBarangL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colBarangL.FieldName = "Length"
		Me.colBarangL.Name = "colBarangL"
		Me.colBarangL.Visible = True
		Me.colBarangL.VisibleIndex = 5
		Me.colBarangL.Width = 54
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
		Me.colNamaBarang.VisibleIndex = 1
		Me.colNamaBarang.Width = 98
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
		Me.colOD.VisibleIndex = 2
		Me.colOD.Width = 46
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
		Me.colInD.VisibleIndex = 3
		Me.colInD.Width = 46
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
		Me.colThickness.VisibleIndex = 4
		Me.colThickness.Width = 46
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
		Me.colLength.VisibleIndex = 5
		Me.colLength.Width = 46
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
		Me.colMillSheet.VisibleIndex = 6
		Me.colMillSheet.Width = 92
		'
		'colSN
		'
		Me.colSN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colSN.AppearanceCell.Options.UseBackColor = True
		Me.colSN.AppearanceHeader.Options.UseTextOptions = True
		Me.colSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colSN.Caption = "SN"
		Me.colSN.ColumnEdit = Me.colSNRepo
		Me.colSN.FieldName = "Serial"
		Me.colSN.Name = "colSN"
		Me.colSN.OptionsColumn.ReadOnly = True
		Me.colSN.Visible = True
		Me.colSN.VisibleIndex = 7
		Me.colSN.Width = 82
		'
		'colSNRepo
		'
		Me.colSNRepo.AutoHeight = False
		Me.colSNRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.colSNRepo.Name = "colSNRepo"
		'
		'colLengthSN
		'
		Me.colLengthSN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.colLengthSN.AppearanceCell.Options.UseBackColor = True
		Me.colLengthSN.AppearanceCell.Options.UseTextOptions = True
		Me.colLengthSN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colLengthSN.AppearanceHeader.Options.UseTextOptions = True
		Me.colLengthSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLengthSN.Caption = "Length SN"
		Me.colLengthSN.DisplayFormat.FormatString = "n0"
		Me.colLengthSN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLengthSN.FieldName = "SNLength"
		Me.colLengthSN.Name = "colLengthSN"
		Me.colLengthSN.OptionsColumn.AllowEdit = False
		Me.colLengthSN.OptionsColumn.ReadOnly = True
		Me.colLengthSN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SNLength", "{0:n0}")})
		Me.colLengthSN.ToolTip = "Length SN (terakhir) pada saat dibuat dempyou"
		Me.colLengthSN.Visible = True
		Me.colLengthSN.VisibleIndex = 8
		Me.colLengthSN.Width = 43
		'
		'colMaterialLength
		'
		Me.colMaterialLength.Caption = "Length Dempyou"
		Me.colMaterialLength.ColumnEdit = Me.colSpekRepo
		Me.colMaterialLength.DisplayFormat.FormatString = "n0"
		Me.colMaterialLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colMaterialLength.FieldName = "Length"
		Me.colMaterialLength.Name = "colMaterialLength"
		Me.colMaterialLength.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Length", "{0:n0}")})
		Me.colMaterialLength.ToolTip = "Length SN yang dibuat dempyou"
		Me.colMaterialLength.Visible = True
		Me.colMaterialLength.VisibleIndex = 9
		Me.colMaterialLength.Width = 41
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
		Me.colQty.VisibleIndex = 10
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
		Me.colScrap.VisibleIndex = 11
		Me.colScrap.Width = 45
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
		Me.colCatatan.VisibleIndex = 12
		Me.colCatatan.Width = 221
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
		Me.txtKontak.Properties.DisplayMember = "KontakNama"
		Me.txtKontak.Properties.NullText = "<Pilih Customer>"
		Me.txtKontak.Properties.ShowClearButton = False
		Me.txtKontak.Properties.ShowFooter = False
		Me.txtKontak.Properties.ValueMember = "This"
		Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
		Me.txtKontak.Size = New System.Drawing.Size(408, 20)
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
		'txtRemark
		'
		Me.txtRemark.EnterMoveNextControl = True
		Me.txtRemark.Location = New System.Drawing.Point(585, 432)
		Me.txtRemark.MenuManager = Me.barMan
		Me.txtRemark.Name = "txtRemark"
		Me.txtRemark.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtRemark.Properties.MaxLength = 255
		Me.txtRemark.Size = New System.Drawing.Size(202, 77)
		Me.txtRemark.StyleController = Me.lytTransaksi
		Me.txtRemark.TabIndex = 27
		'
		'txtLengthTolerance
		'
		Me.txtLengthTolerance.EditValue = ""
		Me.txtLengthTolerance.Location = New System.Drawing.Point(17, 432)
		Me.txtLengthTolerance.MenuManager = Me.barMan
		Me.txtLengthTolerance.Name = "txtLengthTolerance"
		Me.txtLengthTolerance.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtLengthTolerance.Size = New System.Drawing.Size(179, 77)
		Me.txtLengthTolerance.StyleController = Me.lytTransaksi
		Me.txtLengthTolerance.TabIndex = 24
		'
		'txtMaterialCorner
		'
		Me.txtMaterialCorner.EditValue = ""
		Me.txtMaterialCorner.Location = New System.Drawing.Point(205, 432)
		Me.txtMaterialCorner.MenuManager = Me.barMan
		Me.txtMaterialCorner.Name = "txtMaterialCorner"
		Me.txtMaterialCorner.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMaterialCorner.Size = New System.Drawing.Size(175, 77)
		Me.txtMaterialCorner.StyleController = Me.lytTransaksi
		Me.txtMaterialCorner.TabIndex = 25
		'
		'txtColourCode
		'
		Me.txtColourCode.EditValue = ""
		Me.txtColourCode.Location = New System.Drawing.Point(389, 432)
		Me.txtColourCode.MenuManager = Me.barMan
		Me.txtColourCode.Name = "txtColourCode"
		Me.txtColourCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtColourCode.Size = New System.Drawing.Size(187, 77)
		Me.txtColourCode.StyleController = Me.lytTransaksi
		Me.txtColourCode.TabIndex = 26
		'
		'txtQty
		'
		Me.txtQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtQty.Location = New System.Drawing.Point(471, 173)
		Me.txtQty.MenuManager = Me.barMan
		Me.txtQty.Name = "txtQty"
		Me.txtQty.Properties.Appearance.Options.UseTextOptions = True
		Me.txtQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtQty.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtQty.Properties.Mask.EditMask = "n0"
		Me.txtQty.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtQty.Size = New System.Drawing.Size(82, 20)
		Me.txtQty.StyleController = Me.lytTransaksi
		Me.txtQty.TabIndex = 13
		'
		'txtNoLOT
		'
		Me.txtNoLOT.Location = New System.Drawing.Point(661, 106)
		Me.txtNoLOT.MenuManager = Me.barMan
		Me.txtNoLOT.Name = "txtNoLOT"
		Me.txtNoLOT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoLOT.Size = New System.Drawing.Size(337, 20)
		Me.txtNoLOT.StyleController = Me.lytTransaksi
		Me.txtNoLOT.TabIndex = 17
		'
		'txtNoDrawing
		'
		Me.txtNoDrawing.Location = New System.Drawing.Point(796, 434)
		Me.txtNoDrawing.MenuManager = Me.barMan
		Me.txtNoDrawing.Name = "txtNoDrawing"
		Me.txtNoDrawing.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoDrawing.Size = New System.Drawing.Size(178, 20)
		Me.txtNoDrawing.StyleController = Me.lytTransaksi
		Me.txtNoDrawing.TabIndex = 28
		'
		'txtMaterialFlow
		'
		Me.txtMaterialFlow.EditValue = ""
		Me.txtMaterialFlow.Enabled = False
		Me.txtMaterialFlow.Location = New System.Drawing.Point(661, 178)
		Me.txtMaterialFlow.MenuManager = Me.barMan
		Me.txtMaterialFlow.Name = "txtMaterialFlow"
		Me.txtMaterialFlow.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMaterialFlow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtMaterialFlow.Properties.Items.AddRange(New Object() {"Cutting", "Cutting & Processing", "Cutting & QT & Proccessing"})
		Me.txtMaterialFlow.Properties.PopupSizeable = True
		Me.txtMaterialFlow.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.txtMaterialFlow.Size = New System.Drawing.Size(337, 20)
		Me.txtMaterialFlow.StyleController = Me.lytTransaksi
		Me.txtMaterialFlow.TabIndex = 20
		'
		'txtDeliveryDate
		'
		Me.txtDeliveryDate.Location = New System.Drawing.Point(661, 154)
		Me.txtDeliveryDate.MenuManager = Me.barMan
		Me.txtDeliveryDate.Name = "txtDeliveryDate"
		Me.txtDeliveryDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtDeliveryDate.Size = New System.Drawing.Size(337, 20)
		Me.txtDeliveryDate.StyleController = Me.lytTransaksi
		Me.txtDeliveryDate.TabIndex = 19
		'
		'txtNoPO
		'
		Me.txtNoPO.Location = New System.Drawing.Point(92, 131)
		Me.txtNoPO.MenuManager = Me.barMan
		Me.txtNoPO.Name = "txtNoPO"
		Me.txtNoPO.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtNoPO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoPO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtNoPO.Properties.DisplayMember = "NomorPO"
		Me.txtNoPO.Properties.NullText = "<Pilih PO>"
		Me.txtNoPO.Properties.ShowFooter = False
		Me.txtNoPO.Properties.ValueMember = "This"
		Me.txtNoPO.Properties.View = Me.GridView1
		Me.txtNoPO.Size = New System.Drawing.Size(191, 20)
		Me.txtNoPO.StyleController = Me.lytTransaksi
		Me.txtNoPO.TabIndex = 7
		'
		'GridView1
		'
		Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNomorPO, Me.colTanggalPO, Me.colTipeSO, Me.colNoBukti})
		Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView1.OptionsView.ShowGroupPanel = False
		'
		'colNomorPO
		'
		Me.colNomorPO.Caption = "Nomor PO"
		Me.colNomorPO.FieldName = "NomorPO"
		Me.colNomorPO.Name = "colNomorPO"
		Me.colNomorPO.Visible = True
		Me.colNomorPO.VisibleIndex = 0
		Me.colNomorPO.Width = 200
		'
		'colTanggalPO
		'
		Me.colTanggalPO.Caption = "Tanggal"
		Me.colTanggalPO.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggalPO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggalPO.FieldName = "Tanggal"
		Me.colTanggalPO.Name = "colTanggalPO"
		Me.colTanggalPO.Visible = True
		Me.colTanggalPO.VisibleIndex = 1
		Me.colTanggalPO.Width = 184
		'
		'colTipeSO
		'
		Me.colTipeSO.Caption = "Tipe"
		Me.colTipeSO.FieldName = "TipeSO"
		Me.colTipeSO.Name = "colTipeSO"
		Me.colTipeSO.Visible = True
		Me.colTipeSO.VisibleIndex = 2
		'
		'colNoBukti
		'
		Me.colNoBukti.Caption = "No Bukti"
		Me.colNoBukti.FieldName = "Kode"
		Me.colNoBukti.Name = "colNoBukti"
		Me.colNoBukti.Visible = True
		Me.colNoBukti.VisibleIndex = 3
		'
		'txtNoCutting
		'
		Me.txtNoCutting.EditValue = Nothing
		Me.txtNoCutting.Location = New System.Drawing.Point(576, 202)
		Me.txtNoCutting.MenuManager = Me.barMan
		Me.txtNoCutting.Name = "txtNoCutting"
		Me.txtNoCutting.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtNoCutting.Properties.Caption = "Tidak butuh proses cutting"
		Me.txtNoCutting.Size = New System.Drawing.Size(209, 21)
		Me.txtNoCutting.StyleController = Me.lytTransaksi
		Me.txtNoCutting.TabIndex = 21
		'
		'LayoutControlItem22
		'
		Me.LayoutControlItem22.Control = Me.txtTargetFinish
		Me.LayoutControlItem22.CustomizationFormText = "Target Finish"
		Me.LayoutControlItem22.Location = New System.Drawing.Point(564, 190)
		Me.LayoutControlItem22.Name = "LayoutControlItem22"
		Me.LayoutControlItem22.Size = New System.Drawing.Size(426, 24)
		Me.LayoutControlItem22.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem22.Text = "Target Finish"
		Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem22.TextSize = New System.Drawing.Size(75, 20)
		Me.LayoutControlItem22.TextToControlDistance = 5
		'
		'layoutControlGroup1
		'
		Me.layoutControlGroup1.CustomizationFormText = "Root"
		Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.layoutControlGroup1.GroupBordersVisible = False
		Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlGroup3, Me.EmptySpaceItem1, Me.LayoutControlItem11, Me.LayoutControlItem3, Me.LayoutControlItem24, Me.LayoutControlGroup5, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem23, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem25, Me.LayoutControlItem10, Me.EmptySpaceItem6, Me.LayoutControlItem26, Me.LayoutControlItem27})
		Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.layoutControlGroup1.Name = "Root"
		Me.layoutControlGroup1.Size = New System.Drawing.Size(1010, 521)
		Me.layoutControlGroup1.Text = "Root"
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem7.Control = Me.xGrid
		Me.LayoutControlItem7.CustomizationFormText = "Bahan Penyusun"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 251)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(990, 143)
		Me.LayoutControlItem7.Text = "Bahan Penyusun"
		Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(93, 13)
		'
		'LayoutControlGroup3
		'
		Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
		Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
		Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
		Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
		Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem1, Me.lytRegional, Me.LayoutControlItem14, Me.EmptySpaceItem3, Me.EmptySpaceItem2})
		Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
		Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
		Me.LayoutControlGroup3.Size = New System.Drawing.Size(990, 94)
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
		Me.layKontak.Size = New System.Drawing.Size(486, 24)
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
		Me.LayoutControlItem15.Location = New System.Drawing.Point(572, 0)
		Me.LayoutControlItem15.Name = "LayoutControlItem15"
		Me.LayoutControlItem15.Size = New System.Drawing.Size(201, 24)
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
		Me.LayoutControlItem16.Location = New System.Drawing.Point(773, 0)
		Me.LayoutControlItem16.Name = "LayoutControlItem16"
		Me.LayoutControlItem16.Size = New System.Drawing.Size(175, 24)
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
		Me.LayoutControlItem17.Location = New System.Drawing.Point(948, 0)
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
		Me.LayoutControlItem1.Control = Me.txtGudang
		Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(246, 24)
		Me.LayoutControlItem1.MinSize = New System.Drawing.Size(246, 24)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(246, 24)
		Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.LayoutControlItem1.Text = "Gudang"
		Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
		Me.LayoutControlItem1.TextToControlDistance = 5
		'
		'lytRegional
		'
		Me.lytRegional.Control = Me.txtRegional
		Me.lytRegional.CustomizationFormText = "Regional"
		Me.lytRegional.Location = New System.Drawing.Point(572, 24)
		Me.lytRegional.Name = "lytRegional"
		Me.lytRegional.Size = New System.Drawing.Size(201, 24)
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
		Me.LayoutControlItem14.Location = New System.Drawing.Point(773, 24)
		Me.LayoutControlItem14.Name = "LayoutControlItem14"
		Me.LayoutControlItem14.Size = New System.Drawing.Size(175, 24)
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
		Me.EmptySpaceItem3.Location = New System.Drawing.Point(486, 0)
		Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(86, 0)
		Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(86, 10)
		Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
		Me.EmptySpaceItem3.Size = New System.Drawing.Size(86, 48)
		Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
		Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(246, 24)
		Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(240, 24)
		Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 239)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(990, 12)
		Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem11
		'
		Me.LayoutControlItem11.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem11.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem11.Control = Me.txtNoLOT
		Me.LayoutControlItem11.CustomizationFormText = "Tarik SQ"
		Me.LayoutControlItem11.Location = New System.Drawing.Point(564, 94)
		Me.LayoutControlItem11.Name = "LayoutControlItem11"
		Me.LayoutControlItem11.Size = New System.Drawing.Size(426, 24)
		Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem11.Text = "No. LOT"
		Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem11.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem11.TextToControlDistance = 5
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtRemark
		Me.LayoutControlItem3.CustomizationFormText = "Uraian"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(568, 404)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(211, 97)
		Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem3.Text = "Remark"
		Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 13)
		'
		'LayoutControlItem24
		'
		Me.LayoutControlItem24.Control = Me.txtLengthTolerance
		Me.LayoutControlItem24.CustomizationFormText = "PO No."
		Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 404)
		Me.LayoutControlItem24.Name = "LayoutControlItem24"
		Me.LayoutControlItem24.Size = New System.Drawing.Size(188, 97)
		Me.LayoutControlItem24.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem24.Text = "Length Tolerance"
		Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem24.TextSize = New System.Drawing.Size(93, 13)
		'
		'LayoutControlGroup5
		'
		Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
		Me.LayoutControlGroup5.CustomizationFormText = "PO"
		Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlItem12, Me.LayoutControlItem4, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem13, Me.LayoutControlItem20, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem28})
		Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 94)
		Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
		Me.LayoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
		Me.LayoutControlGroup5.Size = New System.Drawing.Size(551, 145)
		Me.LayoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
		Me.LayoutControlGroup5.Text = "PO"
		'
		'LayoutControlItem21
		'
		Me.LayoutControlItem21.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem21.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem21.Control = Me.txtNoPO
		Me.LayoutControlItem21.CustomizationFormText = "Alamat"
		Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem21.Name = "LayoutControlItem21"
		Me.LayoutControlItem21.Size = New System.Drawing.Size(269, 24)
		Me.LayoutControlItem21.Text = "No. PO"
		Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem21.TextSize = New System.Drawing.Size(69, 13)
		Me.LayoutControlItem21.TextToControlDistance = 5
		'
		'LayoutControlItem12
		'
		Me.LayoutControlItem12.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LayoutControlItem12.AppearanceItemCaption.Options.UseFont = True
		Me.LayoutControlItem12.Control = Me.txtPOLine
		Me.LayoutControlItem12.CustomizationFormText = "Termin"
		Me.LayoutControlItem12.Location = New System.Drawing.Point(269, 0)
		Me.LayoutControlItem12.Name = "LayoutControlItem12"
		Me.LayoutControlItem12.Size = New System.Drawing.Size(270, 24)
		Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem12.Text = "PO Line"
		Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem12.TextSize = New System.Drawing.Size(69, 13)
		Me.LayoutControlItem12.TextToControlDistance = 5
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtMaterial
		Me.LayoutControlItem4.CustomizationFormText = "Inspection"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(186, 24)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(83, 90)
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
		Me.LayoutControlItem18.Location = New System.Drawing.Point(269, 24)
		Me.LayoutControlItem18.Name = "LayoutControlItem18"
		Me.LayoutControlItem18.Size = New System.Drawing.Size(93, 42)
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
		Me.LayoutControlItem19.Location = New System.Drawing.Point(362, 24)
		Me.LayoutControlItem19.Name = "LayoutControlItem19"
		Me.LayoutControlItem19.Size = New System.Drawing.Size(91, 42)
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
		Me.LayoutControlItem13.Size = New System.Drawing.Size(186, 42)
		Me.LayoutControlItem13.Text = "Part No."
		Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem13.TextSize = New System.Drawing.Size(40, 13)
		Me.LayoutControlItem13.TextToControlDistance = 5
		'
		'LayoutControlItem20
		'
		Me.LayoutControlItem20.Control = Me.txtQty
		Me.LayoutControlItem20.CustomizationFormText = "Total Transaksi   "
		Me.LayoutControlItem20.Location = New System.Drawing.Point(453, 24)
		Me.LayoutControlItem20.Name = "LayoutControlItem20"
		Me.LayoutControlItem20.Size = New System.Drawing.Size(86, 42)
		Me.LayoutControlItem20.Text = "Qty"
		Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem20.TextSize = New System.Drawing.Size(18, 13)
		Me.LayoutControlItem20.TextToControlDistance = 5
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.txtCutting
		Me.LayoutControlItem8.CustomizationFormText = "Cutting"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(269, 66)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(270, 24)
		Me.LayoutControlItem8.Text = "Cutting"
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(93, 13)
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtRMDibutuhkan
		Me.LayoutControlItem9.CustomizationFormText = "RM Dibutuhkan"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(269, 90)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(270, 24)
		Me.LayoutControlItem9.Text = "RM Dibutuhkan"
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(93, 13)
		'
		'LayoutControlItem28
		'
		Me.LayoutControlItem28.Control = Me.chkTampilkanMaster
		Me.LayoutControlItem28.CustomizationFormText = "LayoutControlItem28"
		Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 66)
		Me.LayoutControlItem28.Name = "LayoutControlItem28"
		Me.LayoutControlItem28.Size = New System.Drawing.Size(186, 48)
		Me.LayoutControlItem28.Text = "LayoutControlItem28"
		Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem28.TextToControlDistance = 0
		Me.LayoutControlItem28.TextVisible = False
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtColourCode
		Me.LayoutControlItem2.CustomizationFormText = "Payment"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(372, 404)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(196, 97)
		Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem2.Text = "Colour Code"
		Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 13)
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtMaterialCorner
		Me.LayoutControlItem5.CustomizationFormText = "Lead Time"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(188, 404)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(184, 97)
		Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem5.Text = "Material Corner"
		Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(93, 13)
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtDeliveryDate
		Me.LayoutControlItem6.CustomizationFormText = "Validity"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(564, 142)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(426, 24)
		Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem6.Text = "Delivery Date"
		Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem6.TextToControlDistance = 5
		'
		'LayoutControlItem23
		'
		Me.LayoutControlItem23.Control = Me.txtMaterialFlow
		Me.LayoutControlItem23.CustomizationFormText = "Pajak"
		Me.LayoutControlItem23.Location = New System.Drawing.Point(564, 166)
		Me.LayoutControlItem23.Name = "LayoutControlItem23"
		Me.LayoutControlItem23.Size = New System.Drawing.Size(426, 24)
		Me.LayoutControlItem23.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem23.Text = "Material Flow"
		Me.LayoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem23.TextSize = New System.Drawing.Size(75, 20)
		Me.LayoutControlItem23.TextToControlDistance = 5
		'
		'EmptySpaceItem4
		'
		Me.EmptySpaceItem4.AllowHotTrack = False
		Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Location = New System.Drawing.Point(551, 94)
		Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Size = New System.Drawing.Size(13, 145)
		Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
		Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem5
		'
		Me.EmptySpaceItem5.AllowHotTrack = False
		Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
		Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 394)
		Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
		Me.EmptySpaceItem5.Size = New System.Drawing.Size(990, 10)
		Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
		Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem25
		'
		Me.LayoutControlItem25.Control = Me.txtNoCutting
		Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
		Me.LayoutControlItem25.Location = New System.Drawing.Point(564, 190)
		Me.LayoutControlItem25.Name = "LayoutControlItem25"
		Me.LayoutControlItem25.Size = New System.Drawing.Size(213, 49)
		Me.LayoutControlItem25.Text = "LayoutControlItem25"
		Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem25.TextToControlDistance = 0
		Me.LayoutControlItem25.TextVisible = False
		'
		'LayoutControlItem10
		'
		Me.LayoutControlItem10.Control = Me.txtNoDrawing
		Me.LayoutControlItem10.CustomizationFormText = "Kurs"
		Me.LayoutControlItem10.Location = New System.Drawing.Point(779, 404)
		Me.LayoutControlItem10.MinSize = New System.Drawing.Size(139, 24)
		Me.LayoutControlItem10.Name = "LayoutControlItem10"
		Me.LayoutControlItem10.Size = New System.Drawing.Size(187, 97)
		Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem10.Text = "No. Drawing"
		Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem10.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem10.TextToControlDistance = 5
		'
		'EmptySpaceItem6
		'
		Me.EmptySpaceItem6.AllowHotTrack = False
		Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
		Me.EmptySpaceItem6.Location = New System.Drawing.Point(966, 404)
		Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
		Me.EmptySpaceItem6.Size = New System.Drawing.Size(24, 97)
		Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
		Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem26
		'
		Me.LayoutControlItem26.Control = Me.txtNoPDO
		Me.LayoutControlItem26.CustomizationFormText = "No. PDO"
		Me.LayoutControlItem26.Location = New System.Drawing.Point(564, 118)
		Me.LayoutControlItem26.Name = "LayoutControlItem26"
		Me.LayoutControlItem26.Size = New System.Drawing.Size(426, 24)
		Me.LayoutControlItem26.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
		Me.LayoutControlItem26.Text = "No. PDO"
		Me.LayoutControlItem26.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
		Me.LayoutControlItem26.TextSize = New System.Drawing.Size(75, 13)
		Me.LayoutControlItem26.TextToControlDistance = 5
		'
		'LayoutControlItem27
		'
		Me.LayoutControlItem27.Control = Me.txtPrioritas
		Me.LayoutControlItem27.CustomizationFormText = "LayoutControlItem27"
		Me.LayoutControlItem27.Location = New System.Drawing.Point(777, 190)
		Me.LayoutControlItem27.Name = "LayoutControlItem27"
		Me.LayoutControlItem27.Size = New System.Drawing.Size(213, 49)
		Me.LayoutControlItem27.Text = "LayoutControlItem27"
		Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem27.TextToControlDistance = 0
		Me.LayoutControlItem27.TextVisible = False
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
		'UI_FusohOrderProduksiDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1016, 554)
		Me.Controls.Add(Me.hideContainerRight)
		Me.KeyPreview = True
		Me.Name = "UI_FusohOrderProduksiDialog"
		Me.Text = "Order Produksi [Dempyou]"
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
		CType(Me.chkTampilkanMaster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPrioritas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoPDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTargetFinish.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRMDibutuhkan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCutting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtLength.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPOLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colKodeRepoView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSNRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtLengthTolerance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMaterialCorner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtColourCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoLOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoDrawing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMaterialFlow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDeliveryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoCutting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
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
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents txtGudang As DevExpress.XtraEditors.LookUpEdit
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
  Friend WithEvents txtPOLine As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents colLengthSN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
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
	Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtMaterial As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
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
	Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
	Friend WithEvents colKodeRepoView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtLengthTolerance As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtMaterialCorner As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtColourCode As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtQty As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtNoLOT As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtNoDrawing As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtMaterialFlow As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents colMaterialLength As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents colSNRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents colBarangKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangOD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangID As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangT As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangL As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtCutting As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtDeliveryDate As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtRMDibutuhkan As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtNoPO As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colNomorPO As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggalPO As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colScrap As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtTargetFinish As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNoCutting As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtNoPDO As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colTipeSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPrioritas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents chkTampilkanMaster As DevExpress.XtraEditors.CheckEdit
	Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
End Class