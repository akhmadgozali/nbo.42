﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_PenerimaanReturDialog
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_PenerimaanReturDialog))
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
    Me.txtAlamatID = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTipe = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtAlamat = New DevExpress.XtraEditors.MemoEdit()
    Me.txtNamaDriver = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoKendaraan = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoDokumen = New DevExpress.XtraEditors.TextEdit()
    Me.txtKurs = New DevExpress.XtraEditors.TextEdit()
    Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layKontakNama = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleLabelItem4 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem15 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem14 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.layTipe = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lyUang = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lyKurs = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.btnAmbilDataSO = New DevExpress.XtraBars.BarButtonItem()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtKaryawan = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
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
    CType(Me.txtAlamatID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNamaDriver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoDokumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontakNama, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleLabelItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layTipe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lyUang, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lyKurs, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.btnAmbilDataSO, Me.btnRefresh})
    Me.barMan.MaxItemId = 10
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAmbilDataSO, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2, True)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
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
    Me.hideContainerRight.Size = New System.Drawing.Size(19, 403)
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
    Me.DockPanel1.Size = New System.Drawing.Size(250, 403)
    Me.DockPanel1.Text = "Panel Informasi"
    Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
    '
    'DockPanel1_Container
    '
    Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
    Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
    Me.DockPanel1_Container.Name = "DockPanel1_Container"
    Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 376)
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
    Me.NavBarControl1.Size = New System.Drawing.Size(242, 376)
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
    Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(234, 103)
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
    Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(234, 93)
    Me.NavBarGroupControlContainer1.TabIndex = 0
    '
    'MemoEdit1
    '
    Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
    Me.MemoEdit1.MenuManager = Me.barMan
    Me.MemoEdit1.Name = "MemoEdit1"
    Me.MemoEdit1.Size = New System.Drawing.Size(234, 93)
    Me.MemoEdit1.TabIndex = 0
    Me.MemoEdit1.UseOptimizedRendering = True
    '
    'NavBarGroupControlContainer2
    '
    Me.NavBarGroupControlContainer2.Controls.Add(Me.xGHistory)
    Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
    Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(234, 193)
    Me.NavBarGroupControlContainer2.TabIndex = 1
    '
    'xGHistory
    '
    Me.xGHistory.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGHistory.Location = New System.Drawing.Point(0, 0)
    Me.xGHistory.MainView = Me.xGHistoryView
    Me.xGHistory.MenuManager = Me.barMan
    Me.xGHistory.Name = "xGHistory"
    Me.xGHistory.Size = New System.Drawing.Size(234, 193)
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
    Me.DockPanel2.OriginalSize = New System.Drawing.Size(1010, 397)
    Me.DockPanel2.Text = "DockPanel2"
    '
    'DockPanel2_Container
    '
    Me.DockPanel2_Container.Controls.Add(Me.lytTransaksi)
    Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
    Me.DockPanel2_Container.Name = "DockPanel2_Container"
    Me.DockPanel2_Container.Size = New System.Drawing.Size(1010, 397)
    Me.DockPanel2_Container.TabIndex = 0
    '
    'lytTransaksi
    '
    Me.lytTransaksi.Controls.Add(Me.txtAlamatID)
    Me.lytTransaksi.Controls.Add(Me.txtTipe)
    Me.lytTransaksi.Controls.Add(Me.txtStatus)
    Me.lytTransaksi.Controls.Add(Me.txtAlamat)
    Me.lytTransaksi.Controls.Add(Me.txtNamaDriver)
    Me.lytTransaksi.Controls.Add(Me.txtNoKendaraan)
    Me.lytTransaksi.Controls.Add(Me.txtNoDokumen)
    Me.lytTransaksi.Controls.Add(Me.txtKurs)
    Me.lytTransaksi.Controls.Add(Me.txtUang)
    Me.lytTransaksi.Controls.Add(Me.txtGudang)
    Me.lytTransaksi.Controls.Add(Me.txtKontakPerson)
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.xGrid)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.txtKaryawan)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(344, 333, 250, 350)
    Me.lytTransaksi.Root = Me.LayoutControlGroup1
    Me.lytTransaksi.Size = New System.Drawing.Size(1010, 397)
    Me.lytTransaksi.TabIndex = 0
    Me.lytTransaksi.Text = "LayoutControl1"
    '
    'txtAlamatID
    '
    Me.txtAlamatID.Location = New System.Drawing.Point(110, 87)
    Me.txtAlamatID.MenuManager = Me.barMan
    Me.txtAlamatID.Name = "txtAlamatID"
    Me.txtAlamatID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAlamatID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", 5, "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tipe", 15, "Tipe"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat", 40, "Alamat")})
    Me.txtAlamatID.Properties.DisplayMember = "Tipe"
    Me.txtAlamatID.Properties.NullText = "<Pilih Alamat>"
    Me.txtAlamatID.Properties.ValueMember = "This"
    Me.txtAlamatID.Size = New System.Drawing.Size(154, 20)
    Me.txtAlamatID.StyleController = Me.lytTransaksi
    Me.txtAlamatID.TabIndex = 11
    '
    'txtTipe
    '
    Me.txtTipe.Location = New System.Drawing.Point(464, 79)
    Me.txtTipe.MenuManager = Me.barMan
    Me.txtTipe.Name = "txtTipe"
    Me.txtTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtTipe.Properties.DisplayMember = "Kode"
    Me.txtTipe.Properties.NullText = "<Tipe>"
    Me.txtTipe.Properties.ValueMember = "This"
    Me.txtTipe.Size = New System.Drawing.Size(91, 20)
    Me.txtTipe.StyleController = Me.lytTransaksi
    Me.txtTipe.TabIndex = 7
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(888, 22)
    Me.txtStatus.MenuManager = Me.barMan
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtStatus.Properties.DisplayMember = "Value"
    Me.txtStatus.Properties.NullText = "<Status>"
    Me.txtStatus.Properties.ValueMember = "Key"
    Me.txtStatus.Size = New System.Drawing.Size(99, 20)
    Me.txtStatus.StyleController = Me.lytTransaksi
    Me.txtStatus.TabIndex = 4
    '
    'txtAlamat
    '
    Me.txtAlamat.Location = New System.Drawing.Point(110, 111)
    Me.txtAlamat.MenuManager = Me.barMan
    Me.txtAlamat.Name = "txtAlamat"
    Me.txtAlamat.Size = New System.Drawing.Size(154, 70)
    Me.txtAlamat.StyleController = Me.lytTransaksi
    Me.txtAlamat.TabIndex = 16
    Me.txtAlamat.UseOptimizedRendering = True
    '
    'txtNamaDriver
    '
    Me.txtNamaDriver.Location = New System.Drawing.Point(699, 120)
    Me.txtNamaDriver.MenuManager = Me.barMan
    Me.txtNamaDriver.Name = "txtNamaDriver"
    Me.txtNamaDriver.Size = New System.Drawing.Size(118, 20)
    Me.txtNamaDriver.StyleController = Me.lytTransaksi
    Me.txtNamaDriver.TabIndex = 15
    '
    'txtNoKendaraan
    '
    Me.txtNoKendaraan.Location = New System.Drawing.Point(699, 79)
    Me.txtNoKendaraan.MenuManager = Me.barMan
    Me.txtNoKendaraan.Name = "txtNoKendaraan"
    Me.txtNoKendaraan.Size = New System.Drawing.Size(118, 20)
    Me.txtNoKendaraan.StyleController = Me.lytTransaksi
    Me.txtNoKendaraan.TabIndex = 9
    '
    'txtNoDokumen
    '
    Me.txtNoDokumen.Location = New System.Drawing.Point(559, 79)
    Me.txtNoDokumen.MenuManager = Me.barMan
    Me.txtNoDokumen.Name = "txtNoDokumen"
    Me.txtNoDokumen.Size = New System.Drawing.Size(116, 20)
    Me.txtNoDokumen.StyleController = Me.lytTransaksi
    Me.txtNoDokumen.TabIndex = 8
    '
    'txtKurs
    '
    Me.txtKurs.Location = New System.Drawing.Point(369, 120)
    Me.txtKurs.MenuManager = Me.barMan
    Me.txtKurs.Name = "txtKurs"
    Me.txtKurs.Properties.ReadOnly = True
    Me.txtKurs.Size = New System.Drawing.Size(91, 20)
    Me.txtKurs.StyleController = Me.lytTransaksi
    Me.txtKurs.TabIndex = 13
    '
    'txtUang
    '
    Me.txtUang.Location = New System.Drawing.Point(369, 79)
    Me.txtUang.MenuManager = Me.barMan
    Me.txtUang.Name = "txtUang"
    Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtUang.Properties.DisplayMember = "Kode"
    Me.txtUang.Properties.NullText = "<Uang>"
    Me.txtUang.Properties.ReadOnly = True
    Me.txtUang.Properties.ValueMember = "This"
    Me.txtUang.Size = New System.Drawing.Size(91, 20)
    Me.txtUang.StyleController = Me.lytTransaksi
    Me.txtUang.TabIndex = 6
    '
    'txtGudang
    '
    Me.txtGudang.Location = New System.Drawing.Point(559, 120)
    Me.txtGudang.MenuManager = Me.barMan
    Me.txtGudang.Name = "txtGudang"
    Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 30, "Nama")})
    Me.txtGudang.Properties.DisplayMember = "Kode"
    Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
    Me.txtGudang.Properties.PopupWidth = 50
    Me.txtGudang.Properties.ValueMember = "This"
    Me.txtGudang.Size = New System.Drawing.Size(116, 20)
    Me.txtGudang.StyleController = Me.lytTransaksi
    Me.txtGudang.TabIndex = 14
    '
    'txtKontakPerson
    '
    Me.txtKontakPerson.Location = New System.Drawing.Point(110, 63)
    Me.txtKontakPerson.MenuManager = Me.barMan
    Me.txtKontakPerson.Name = "txtKontakPerson"
    Me.txtKontakPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontakPerson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtKontakPerson.Properties.DisplayMember = "Nama"
    Me.txtKontakPerson.Properties.NullText = "<Pilih Kontak Person>"
    Me.txtKontakPerson.Properties.ValueMember = "Nama"
    Me.txtKontakPerson.Size = New System.Drawing.Size(154, 20)
    Me.txtKontakPerson.StyleController = Me.lytTransaksi
    Me.txtKontakPerson.TabIndex = 5
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(845, 79)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.PopupWidth = 120
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(117, 20)
    Me.txtRegional.StyleController = Me.lytTransaksi
    Me.txtRegional.TabIndex = 10
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(469, 22)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(115, 20)
    Me.txtTanggal.StyleController = Me.lytTransaksi
    Me.txtTanggal.TabIndex = 1
    '
    'btnRefreshNomor
    '
    Me.btnRefreshNomor.AutoWidthInLayoutControl = True
    Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
    Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnRefreshNomor.Location = New System.Drawing.Point(788, 22)
    Me.btnRefreshNomor.Name = "btnRefreshNomor"
    Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
    Me.btnRefreshNomor.StyleController = Me.lytTransaksi
    Me.btnRefreshNomor.TabIndex = 3
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(679, 22)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Size = New System.Drawing.Size(105, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksi
    Me.txtNoTransaksi.TabIndex = 2
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 214)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colDivisiRepo, Me.colSatuanRepo, Me.colKodeBarangRepo})
    Me.xGrid.Size = New System.Drawing.Size(986, 166)
    Me.xGrid.TabIndex = 18
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colDivisi, Me.colCatatan})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colKodeBarang
    '
    Me.colKodeBarang.Caption = "Kode Barang"
    Me.colKodeBarang.ColumnEdit = Me.colKodeBarangRepo
    Me.colKodeBarang.FieldName = "Barang!"
    Me.colKodeBarang.Name = "colKodeBarang"
    Me.colKodeBarang.Visible = True
    Me.colKodeBarang.VisibleIndex = 0
    Me.colKodeBarang.Width = 125
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
    Me.colNamaBarang.Width = 179
    '
    'colQty
    '
    Me.colQty.AppearanceCell.Options.UseTextOptions = True
    Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colQty.AppearanceHeader.Options.UseTextOptions = True
    Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colQty.Caption = "Qty"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.OptionsColumn.AllowSize = False
    Me.colQty.OptionsColumn.FixedWidth = True
    Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 2
    Me.colQty.Width = 65
    '
    'colSatuan
    '
    Me.colSatuan.AppearanceCell.Options.UseTextOptions = True
    Me.colSatuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colSatuan.AppearanceHeader.Options.UseTextOptions = True
    Me.colSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colSatuan.Caption = "Satuan"
    Me.colSatuan.ColumnEdit = Me.colSatuanRepo
    Me.colSatuan.FieldName = "Satuan!"
    Me.colSatuan.Name = "colSatuan"
    Me.colSatuan.Visible = True
    Me.colSatuan.VisibleIndex = 3
    Me.colSatuan.Width = 89
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
    'colDivisi
    '
    Me.colDivisi.Caption = "Divisi"
    Me.colDivisi.ColumnEdit = Me.colDivisiRepo
    Me.colDivisi.FieldName = "Divisi!"
    Me.colDivisi.Name = "colDivisi"
    Me.colDivisi.Visible = True
    Me.colDivisi.VisibleIndex = 4
    Me.colDivisi.Width = 103
    '
    'colDivisiRepo
    '
    Me.colDivisiRepo.AutoHeight = False
    Me.colDivisiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colDivisiRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending)})
    Me.colDivisiRepo.DisplayMember = "Kode"
    Me.colDivisiRepo.Name = "colDivisiRepo"
    Me.colDivisiRepo.NullText = "<Divisi>"
    Me.colDivisiRepo.ValueMember = "This"
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
    Me.colCatatan.VisibleIndex = 5
    Me.colCatatan.Width = 192
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(110, 185)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(888, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 17
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlGroup3, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.EmptySpaceItem9, Me.LayoutControlItem1, Me.EmptySpaceItem15, Me.LayoutControlItem11, Me.LayoutControlItem6, Me.LayoutControlItem10, Me.EmptySpaceItem10, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem12, Me.LayoutControlItem12, Me.EmptySpaceItem14, Me.layTipe, Me.LayoutControlItem5, Me.lyUang, Me.lyKurs, Me.lytRegional, Me.LayoutControlItem8})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1010, 397)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 173)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(990, 24)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(95, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGrid
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 202)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(990, 170)
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
    Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
    Me.LayoutControlGroup3.GroupBordersVisible = False
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem16, Me.layKontakNama, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem15, Me.EmptySpaceItem6, Me.LayoutControlItem4, Me.LayoutControlItem17, Me.SimpleLabelItem4})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(990, 46)
    Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
    Me.LayoutControlGroup3.TextVisible = False
    '
    'layKontak
    '
    Me.layKontak.Control = Me.txtKontak
    Me.layKontak.CustomizationFormText = "Vendor"
    Me.layKontak.Location = New System.Drawing.Point(10, 10)
    Me.layKontak.MinSize = New System.Drawing.Size(50, 25)
    Me.layKontak.Name = "layKontak"
    Me.layKontak.Size = New System.Drawing.Size(198, 26)
    Me.layKontak.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layKontak.Text = "Customer   "
    Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layKontak.TextSize = New System.Drawing.Size(55, 13)
    Me.layKontak.TextToControlDistance = 5
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtNoTransaksi
    Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(610, 10)
    Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(166, 26)
    Me.LayoutControlItem16.MinSize = New System.Drawing.Size(166, 26)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(166, 26)
    Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem16.Text = "No. Bukti   "
    Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(52, 13)
    Me.LayoutControlItem16.TextToControlDistance = 5
    '
    'layKontakNama
    '
    Me.layKontakNama.AllowHotTrack = False
    Me.layKontakNama.CustomizationFormText = "kontak nama"
    Me.layKontakNama.Location = New System.Drawing.Point(208, 10)
    Me.layKontakNama.Name = "layKontakNama"
    Me.layKontakNama.Size = New System.Drawing.Size(197, 26)
    Me.layKontakNama.Text = "-"
    Me.layKontakNama.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layKontakNama.TextSize = New System.Drawing.Size(4, 13)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.FillControlToClientArea = False
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(10, 0)
    Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(969, 10)
    Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(969, 10)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(969, 10)
    Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.EmptySpaceItem2.TrimClientAreaToControl = False
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.FillControlToClientArea = False
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(10, 36)
    Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(969, 10)
    Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(969, 10)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(969, 10)
    Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    Me.EmptySpaceItem3.TrimClientAreaToControl = False
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 0)
    Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(10, 46)
    Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 46)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 46)
    Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(979, 0)
    Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(11, 46)
    Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(11, 46)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(11, 46)
    Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(405, 10)
    Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(171, 26)
    Me.LayoutControlItem15.MinSize = New System.Drawing.Size(171, 26)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(171, 26)
    Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem15.Text = "Tanggal   "
    Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(47, 13)
    Me.LayoutControlItem15.TextToControlDistance = 5
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(576, 10)
    Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(34, 26)
    Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(34, 26)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(34, 26)
    Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtStatus
    Me.LayoutControlItem4.CustomizationFormText = "Status"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(831, 10)
    Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(148, 26)
    Me.LayoutControlItem4.MinSize = New System.Drawing.Size(148, 26)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(148, 26)
    Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem4.Text = "Status   "
    Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(40, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.btnRefreshNomor
    Me.LayoutControlItem17.CustomizationFormText = " "
    Me.LayoutControlItem17.Location = New System.Drawing.Point(776, 10)
    Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem17.MinSize = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem17.Name = "LayoutControlItem17"
    Me.LayoutControlItem17.Size = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem17.Text = " "
    Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem17.TextToControlDistance = 0
    Me.LayoutControlItem17.TextVisible = False
    Me.LayoutControlItem17.TrimClientAreaToControl = False
    '
    'SimpleLabelItem4
    '
    Me.SimpleLabelItem4.AllowHotTrack = False
    Me.SimpleLabelItem4.CustomizationFormText = " "
    Me.SimpleLabelItem4.Location = New System.Drawing.Point(806, 10)
    Me.SimpleLabelItem4.MaxSize = New System.Drawing.Size(25, 26)
    Me.SimpleLabelItem4.MinSize = New System.Drawing.Size(25, 26)
    Me.SimpleLabelItem4.Name = "SimpleLabelItem4"
    Me.SimpleLabelItem4.Size = New System.Drawing.Size(25, 26)
    Me.SimpleLabelItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.SimpleLabelItem4.Text = " "
    Me.SimpleLabelItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.SimpleLabelItem4.TextSize = New System.Drawing.Size(3, 13)
    '
    'EmptySpaceItem7
    '
    Me.EmptySpaceItem7.AllowHotTrack = False
    Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 46)
    Me.EmptySpaceItem7.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Size = New System.Drawing.Size(990, 5)
    Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
    Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem8
    '
    Me.EmptySpaceItem8.AllowHotTrack = False
    Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 197)
    Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Size = New System.Drawing.Size(990, 5)
    Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
    Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem9
    '
    Me.EmptySpaceItem9.AllowHotTrack = False
    Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Location = New System.Drawing.Point(0, 372)
    Me.EmptySpaceItem9.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Size = New System.Drawing.Size(990, 5)
    Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
    Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKontakPerson
    Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 51)
    Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(256, 24)
    Me.LayoutControlItem1.MinSize = New System.Drawing.Size(256, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(256, 24)
    Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem1.Text = "Kontak Person"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(95, 13)
    '
    'EmptySpaceItem15
    '
    Me.EmptySpaceItem15.AllowHotTrack = False
    Me.EmptySpaceItem15.CustomizationFormText = "EmptySpaceItem15"
    Me.EmptySpaceItem15.Location = New System.Drawing.Point(954, 51)
    Me.EmptySpaceItem15.MaxSize = New System.Drawing.Size(36, 82)
    Me.EmptySpaceItem15.MinSize = New System.Drawing.Size(36, 82)
    Me.EmptySpaceItem15.Name = "EmptySpaceItem15"
    Me.EmptySpaceItem15.Size = New System.Drawing.Size(36, 82)
    Me.EmptySpaceItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem15.Text = "EmptySpaceItem15"
    Me.EmptySpaceItem15.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtKaryawan
    Me.LayoutControlItem11.CustomizationFormText = "Bag Pembelian"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(833, 91)
    Me.LayoutControlItem11.MinSize = New System.Drawing.Size(50, 25)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(121, 42)
    Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem11.Text = "Karyawan Penerima"
    Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(95, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtNoKendaraan
    Me.LayoutControlItem6.CustomizationFormText = "No Kendaraan"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(687, 51)
    Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(122, 41)
    Me.LayoutControlItem6.MinSize = New System.Drawing.Size(122, 41)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(122, 41)
    Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem6.Text = "No Kendaraan"
    Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(95, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtNamaDriver
    Me.LayoutControlItem10.CustomizationFormText = "Nama Driver"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(687, 92)
    Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(122, 41)
    Me.LayoutControlItem10.MinSize = New System.Drawing.Size(122, 41)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(122, 41)
    Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem10.Text = "Nama Driver"
    Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(95, 13)
    '
    'EmptySpaceItem10
    '
    Me.EmptySpaceItem10.AllowHotTrack = False
    Me.EmptySpaceItem10.CustomizationFormText = "EmptySpaceItem10"
    Me.EmptySpaceItem10.Location = New System.Drawing.Point(667, 51)
    Me.EmptySpaceItem10.MaxSize = New System.Drawing.Size(20, 82)
    Me.EmptySpaceItem10.MinSize = New System.Drawing.Size(20, 82)
    Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
    Me.EmptySpaceItem10.Size = New System.Drawing.Size(20, 82)
    Me.EmptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem10.Text = "EmptySpaceItem10"
    Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtGudang
    Me.LayoutControlItem2.CustomizationFormText = "Gudang"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(547, 92)
    Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(120, 41)
    Me.LayoutControlItem2.MinSize = New System.Drawing.Size(120, 41)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(120, 41)
    Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem2.Text = "Gudang"
    Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(95, 13)
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(256, 51)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(101, 82)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem12
    '
    Me.EmptySpaceItem12.AllowHotTrack = False
    Me.EmptySpaceItem12.CustomizationFormText = "EmptySpaceItem12"
    Me.EmptySpaceItem12.Location = New System.Drawing.Point(809, 51)
    Me.EmptySpaceItem12.MaxSize = New System.Drawing.Size(24, 82)
    Me.EmptySpaceItem12.MinSize = New System.Drawing.Size(24, 82)
    Me.EmptySpaceItem12.Name = "EmptySpaceItem12"
    Me.EmptySpaceItem12.Size = New System.Drawing.Size(24, 82)
    Me.EmptySpaceItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem12.Text = "EmptySpaceItem12"
    Me.EmptySpaceItem12.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtAlamat
    Me.LayoutControlItem12.CustomizationFormText = "Alamat"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 99)
    Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(256, 74)
    Me.LayoutControlItem12.MinSize = New System.Drawing.Size(256, 74)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(256, 74)
    Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem12.Text = "Alamat"
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(95, 13)
    '
    'EmptySpaceItem14
    '
    Me.EmptySpaceItem14.AllowHotTrack = False
    Me.EmptySpaceItem14.CustomizationFormText = "EmptySpaceItem14"
    Me.EmptySpaceItem14.Location = New System.Drawing.Point(256, 133)
    Me.EmptySpaceItem14.Name = "EmptySpaceItem14"
    Me.EmptySpaceItem14.Size = New System.Drawing.Size(734, 40)
    Me.EmptySpaceItem14.Text = "EmptySpaceItem14"
    Me.EmptySpaceItem14.TextSize = New System.Drawing.Size(0, 0)
    '
    'layTipe
    '
    Me.layTipe.Control = Me.txtTipe
    Me.layTipe.CustomizationFormText = "Tipe"
    Me.layTipe.Location = New System.Drawing.Point(452, 51)
    Me.layTipe.MaxSize = New System.Drawing.Size(95, 82)
    Me.layTipe.MinSize = New System.Drawing.Size(95, 82)
    Me.layTipe.Name = "layTipe"
    Me.layTipe.Size = New System.Drawing.Size(95, 82)
    Me.layTipe.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layTipe.Text = "Tipe"
    Me.layTipe.TextLocation = DevExpress.Utils.Locations.Top
    Me.layTipe.TextSize = New System.Drawing.Size(95, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtNoDokumen
    Me.LayoutControlItem5.CustomizationFormText = "No Dokumen"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(547, 51)
    Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(120, 41)
    Me.LayoutControlItem5.MinSize = New System.Drawing.Size(120, 41)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(120, 41)
    Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem5.Text = "No Dokumen"
    Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(95, 13)
    '
    'lyUang
    '
    Me.lyUang.Control = Me.txtUang
    Me.lyUang.CustomizationFormText = "Uang"
    Me.lyUang.Location = New System.Drawing.Point(357, 51)
    Me.lyUang.MaxSize = New System.Drawing.Size(95, 41)
    Me.lyUang.MinSize = New System.Drawing.Size(95, 41)
    Me.lyUang.Name = "lyUang"
    Me.lyUang.Size = New System.Drawing.Size(95, 41)
    Me.lyUang.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.lyUang.Text = "Uang"
    Me.lyUang.TextLocation = DevExpress.Utils.Locations.Top
    Me.lyUang.TextSize = New System.Drawing.Size(95, 13)
    '
    'lyKurs
    '
    Me.lyKurs.Control = Me.txtKurs
    Me.lyKurs.CustomizationFormText = "Kurs"
    Me.lyKurs.Location = New System.Drawing.Point(357, 92)
    Me.lyKurs.MaxSize = New System.Drawing.Size(95, 41)
    Me.lyKurs.MinSize = New System.Drawing.Size(95, 41)
    Me.lyKurs.Name = "lyKurs"
    Me.lyKurs.Size = New System.Drawing.Size(95, 41)
    Me.lyKurs.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.lyKurs.Text = "Kurs"
    Me.lyKurs.TextLocation = DevExpress.Utils.Locations.Top
    Me.lyKurs.TextSize = New System.Drawing.Size(95, 13)
    '
    'lytRegional
    '
    Me.lytRegional.Control = Me.txtRegional
    Me.lytRegional.CustomizationFormText = "Regional"
    Me.lytRegional.Location = New System.Drawing.Point(833, 51)
    Me.lytRegional.MaxSize = New System.Drawing.Size(121, 40)
    Me.lytRegional.MinSize = New System.Drawing.Size(121, 40)
    Me.lytRegional.Name = "lytRegional"
    Me.lytRegional.Size = New System.Drawing.Size(121, 40)
    Me.lytRegional.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.lytRegional.Text = "Regional"
    Me.lytRegional.TextLocation = DevExpress.Utils.Locations.Top
    Me.lytRegional.TextSize = New System.Drawing.Size(95, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtAlamatID
    Me.LayoutControlItem8.CustomizationFormText = "Alamat"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 75)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(256, 24)
    Me.LayoutControlItem8.Text = "Alamat"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(95, 13)
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
    'btnAmbilDataSO
    '
    Me.btnAmbilDataSO.Caption = "Ambil Data SO"
    Me.btnAmbilDataSO.Glyph = CType(resources.GetObject("btnAmbilDataSO.Glyph"), System.Drawing.Image)
    Me.btnAmbilDataSO.Id = 8
    Me.btnAmbilDataSO.LargeGlyph = CType(resources.GetObject("btnAmbilDataSO.LargeGlyph"), System.Drawing.Image)
    Me.btnAmbilDataSO.Name = "btnAmbilDataSO"
    Me.btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'btnRefresh
    '
    Me.btnRefresh.Caption = "Refresh"
    Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
    Me.btnRefresh.Id = 9
    Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
    Me.btnRefresh.Name = "btnRefresh"
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(82, 22)
    Me.txtKontak.MenuManager = Me.barMan
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Customer>"
    Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(330, 0)
    Me.txtKontak.Properties.ShowClearButton = False
    Me.txtKontak.Properties.ShowFooter = False
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(134, 20)
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
    'txtKaryawan
    '
    Me.txtKaryawan.Location = New System.Drawing.Point(845, 119)
    Me.txtKaryawan.MenuManager = Me.barMan
    Me.txtKaryawan.Name = "txtKaryawan"
    Me.txtKaryawan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKaryawan.Properties.DisplayMember = "Nama"
    Me.txtKaryawan.Properties.NullText = "<Pilih Karyawan>"
    Me.txtKaryawan.Properties.ShowClearButton = False
    Me.txtKaryawan.Properties.ShowFooter = False
    Me.txtKaryawan.Properties.ValueMember = "This"
    Me.txtKaryawan.Properties.View = Me.GridView1
    Me.txtKaryawan.Size = New System.Drawing.Size(117, 20)
    Me.txtKaryawan.StyleController = Me.lytTransaksi
    Me.txtKaryawan.TabIndex = 12
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsFind.FindDelay = 500
    Me.GridView1.OptionsFind.SearchInPreview = True
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode"
    Me.GridColumn1.FieldName = "Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 355
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama"
    Me.GridColumn2.FieldName = "Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 723
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
    'UI_PenerimaanReturDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1016, 430)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "UI_PenerimaanReturDialog"
    Me.Text = "Penerimaan Retur"
    Me.Controls.SetChildIndex(Me.hideContainerRight, 0)
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
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
    CType(Me.txtAlamatID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNamaDriver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoDokumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontakNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleLabelItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layTipe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lyUang, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lyKurs, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layKontakNama As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents SimpleLabelItem4 As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKontakPerson As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
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
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
  Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lyUang As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem15 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents colDivisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lyKurs As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoDokumen As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNamaDriver As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNoKendaraan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtAlamat As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem14 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTipe As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents layTipe As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents btnAmbilDataSO As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents txtAlamatID As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colDivisiRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colSatuanRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtKaryawan As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
End Class