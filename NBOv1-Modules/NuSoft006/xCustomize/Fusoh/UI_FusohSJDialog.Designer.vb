<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohSJDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohSJDialog))
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
        Me.txtCheckStock = New DevExpress.XtraEditors.MemoEdit()
        Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNamaDriver = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoKendaraan = New DevExpress.XtraEditors.TextEdit()
        Me.txtJenisKendaraan = New DevExpress.XtraEditors.TextEdit()
        Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCommand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommandRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colNoPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSisaQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduksiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.colProduksiRepoLookup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpin = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colODID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrossWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPODetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyPalletHidden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPalletHidden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduksiDetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
        Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtOtomatisProduksi = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnAmbilDataSO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAmbilDataSO2 = New DevExpress.XtraBars.BarButtonItem()
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
        CType(Me.txtCheckStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaDriver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJenisKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colCommandRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colProduksiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colProduksiRepoLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtomatisProduksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barMan
        '
        Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.btnAmbilDataSO, Me.btnRefresh, Me.btnAmbilDataSO2})
        Me.barMan.MaxItemId = 11
        '
        'barMenu
        '
        Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAmbilDataSO, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAmbilDataSO2, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2, True)})
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
        Me.lytTransaksi.Controls.Add(Me.txtCheckStock)
        Me.lytTransaksi.Controls.Add(Me.txtStatus)
        Me.lytTransaksi.Controls.Add(Me.txtNamaDriver)
        Me.lytTransaksi.Controls.Add(Me.txtNoKendaraan)
        Me.lytTransaksi.Controls.Add(Me.txtJenisKendaraan)
        Me.lytTransaksi.Controls.Add(Me.txtRegional)
        Me.lytTransaksi.Controls.Add(Me.txtTanggal)
        Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
        Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
        Me.lytTransaksi.Controls.Add(Me.xGrid)
        Me.lytTransaksi.Controls.Add(Me.txtUraian)
        Me.lytTransaksi.Controls.Add(Me.txtKontak)
        Me.lytTransaksi.Controls.Add(Me.txtOtomatisProduksi)
        Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.lytTransaksi.Name = "lytTransaksi"
        Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 6, 250, 350)
        Me.lytTransaksi.Root = Me.LayoutControlGroup1
        Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
        Me.lytTransaksi.TabIndex = 0
        Me.lytTransaksi.Text = "LayoutControl1"
        '
        'txtCheckStock
        '
        Me.txtCheckStock.Location = New System.Drawing.Point(798, 106)
        Me.txtCheckStock.MenuManager = Me.barMan
        Me.txtCheckStock.Name = "txtCheckStock"
        Me.txtCheckStock.Size = New System.Drawing.Size(126, 92)
        Me.txtCheckStock.StyleController = Me.lytTransaksi
        Me.txtCheckStock.TabIndex = 12
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(889, 61)
        Me.txtStatus.MenuManager = Me.barMan
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
        Me.txtStatus.Properties.DisplayMember = "Value"
        Me.txtStatus.Properties.NullText = "<Status>"
        Me.txtStatus.Properties.ValueMember = "Key"
        Me.txtStatus.Size = New System.Drawing.Size(191, 20)
        Me.txtStatus.StyleController = Me.lytTransaksi
        Me.txtStatus.TabIndex = 5
        '
        'txtNamaDriver
        '
        Me.txtNamaDriver.Location = New System.Drawing.Point(114, 130)
        Me.txtNamaDriver.MenuManager = Me.barMan
        Me.txtNamaDriver.Name = "txtNamaDriver"
        Me.txtNamaDriver.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNamaDriver.Size = New System.Drawing.Size(439, 20)
        Me.txtNamaDriver.StyleController = Me.lytTransaksi
        Me.txtNamaDriver.TabIndex = 8
        '
        'txtNoKendaraan
        '
        Me.txtNoKendaraan.Location = New System.Drawing.Point(114, 106)
        Me.txtNoKendaraan.MenuManager = Me.barMan
        Me.txtNoKendaraan.Name = "txtNoKendaraan"
        Me.txtNoKendaraan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNoKendaraan.Size = New System.Drawing.Size(439, 20)
        Me.txtNoKendaraan.StyleController = Me.lytTransaksi
        Me.txtNoKendaraan.TabIndex = 6
        '
        'txtJenisKendaraan
        '
        Me.txtJenisKendaraan.Location = New System.Drawing.Point(114, 154)
        Me.txtJenisKendaraan.MenuManager = Me.barMan
        Me.txtJenisKendaraan.Name = "txtJenisKendaraan"
        Me.txtJenisKendaraan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtJenisKendaraan.Size = New System.Drawing.Size(439, 20)
        Me.txtJenisKendaraan.StyleController = Me.lytTransaksi
        Me.txtJenisKendaraan.TabIndex = 9
        '
        'txtRegional
        '
        Me.txtRegional.Location = New System.Drawing.Point(636, 61)
        Me.txtRegional.MenuManager = Me.barMan
        Me.txtRegional.Name = "txtRegional"
        Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
        Me.txtRegional.Properties.DisplayMember = "Nama"
        Me.txtRegional.Properties.NullText = "<Pilih Regional>"
        Me.txtRegional.Properties.PopupWidth = 120
        Me.txtRegional.Properties.ValueMember = "This"
        Me.txtRegional.Size = New System.Drawing.Size(186, 20)
        Me.txtRegional.StyleController = Me.lytTransaksi
        Me.txtRegional.TabIndex = 4
        '
        'txtTanggal
        '
        Me.txtTanggal.EditValue = Nothing
        Me.txtTanggal.Location = New System.Drawing.Point(636, 37)
        Me.txtTanggal.MenuManager = Me.barMan
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
        Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTanggal.Size = New System.Drawing.Size(186, 20)
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
        Me.txtNoTransaksi.Location = New System.Drawing.Point(889, 37)
        Me.txtNoTransaksi.MenuManager = Me.barMan
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNoTransaksi.Size = New System.Drawing.Size(191, 20)
        Me.txtNoTransaksi.StyleController = Me.lytTransaksi
        Me.txtNoTransaksi.TabIndex = 2
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(12, 202)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.MenuManager = Me.barMan
        Me.xGrid.Name = "xGrid"
        Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpin, Me.colCommandRepo, Me.colProduksiRepo})
        Me.xGrid.Size = New System.Drawing.Size(1104, 216)
        Me.xGrid.TabIndex = 11
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommand, Me.colNoPO, Me.colKodeBarang, Me.colNamaBarang, Me.colSisaQty, Me.colProduksi, Me.colQty, Me.colCatatan, Me.colOD, Me.colODID, Me.colT, Me.colL, Me.colNetWeight, Me.colGrossWeight, Me.colLot, Me.colSO, Me.colNoPODetail, Me.colPOLine, Me.colQtyPalletHidden, Me.colNoPalletHidden, Me.colNoProduksi, Me.colNoLot, Me.colProduksiDetail})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.NewItemRowText = "Tambah Data"
        Me.xGridView.OptionsCustomization.AllowGroup = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.xGridView.OptionsView.ColumnAutoWidth = False
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colCommand
        '
        Me.colCommand.ColumnEdit = Me.colCommandRepo
        Me.colCommand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colCommand.Name = "colCommand"
        Me.colCommand.Visible = True
        Me.colCommand.VisibleIndex = 0
        Me.colCommand.Width = 58
        '
        'colCommandRepo
        '
        Me.colCommandRepo.AutoHeight = False
        Me.colCommandRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.colCommandRepo.Name = "colCommandRepo"
        Me.colCommandRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colNoPO
        '
        Me.colNoPO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNoPO.AppearanceCell.Options.UseBackColor = True
        Me.colNoPO.Caption = "No. PO"
        Me.colNoPO.FieldName = "SODetail.Main.NomorPO"
        Me.colNoPO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colNoPO.Name = "colNoPO"
        Me.colNoPO.OptionsColumn.AllowEdit = False
        Me.colNoPO.OptionsColumn.ReadOnly = True
        Me.colNoPO.Visible = True
        Me.colNoPO.VisibleIndex = 1
        Me.colNoPO.Width = 73
        '
        'colKodeBarang
        '
        Me.colKodeBarang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colKodeBarang.AppearanceCell.Options.UseBackColor = True
        Me.colKodeBarang.Caption = "Part No."
        Me.colKodeBarang.FieldName = "Barang.Kode"
        Me.colKodeBarang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.OptionsColumn.AllowEdit = False
        Me.colKodeBarang.OptionsColumn.ReadOnly = True
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 2
        Me.colKodeBarang.Width = 100
        '
        'colNamaBarang
        '
        Me.colNamaBarang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNamaBarang.AppearanceCell.Options.UseBackColor = True
        Me.colNamaBarang.Caption = "Material"
        Me.colNamaBarang.FieldName = "Barang.Nama"
        Me.colNamaBarang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.OptionsColumn.AllowEdit = False
        Me.colNamaBarang.OptionsColumn.ReadOnly = True
        Me.colNamaBarang.Visible = True
        Me.colNamaBarang.VisibleIndex = 3
        Me.colNamaBarang.Width = 90
        '
        'colSisaQty
        '
        Me.colSisaQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSisaQty.AppearanceCell.Options.UseBackColor = True
        Me.colSisaQty.AppearanceCell.Options.UseTextOptions = True
        Me.colSisaQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSisaQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colSisaQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSisaQty.Caption = "Sisa Qty SO"
        Me.colSisaQty.DisplayFormat.FormatString = "n0"
        Me.colSisaQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSisaQty.FieldName = "SisaQty"
        Me.colSisaQty.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colSisaQty.Name = "colSisaQty"
        Me.colSisaQty.OptionsColumn.AllowEdit = False
        Me.colSisaQty.OptionsColumn.FixedWidth = True
        Me.colSisaQty.OptionsColumn.ReadOnly = True
        Me.colSisaQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSisaQty.Visible = True
        Me.colSisaQty.VisibleIndex = 4
        Me.colSisaQty.Width = 65
        '
        'colProduksi
        '
        Me.colProduksi.Caption = "Produksi"
        Me.colProduksi.ColumnEdit = Me.colProduksiRepo
        Me.colProduksi.FieldName = "ProduksiDetail!"
        Me.colProduksi.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colProduksi.Name = "colProduksi"
        Me.colProduksi.Visible = True
        Me.colProduksi.VisibleIndex = 5
        Me.colProduksi.Width = 110
        '
        'colProduksiRepo
        '
        Me.colProduksiRepo.AutoHeight = False
        Me.colProduksiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colProduksiRepo.DisplayMember = "Kode"
        Me.colProduksiRepo.Name = "colProduksiRepo"
        Me.colProduksiRepo.NullText = "<Pilih Kode Produksi>"
        Me.colProduksiRepo.ValueMember = "Id"
        Me.colProduksiRepo.View = Me.colProduksiRepoLookup
        '
        'colProduksiRepoLookup
        '
        Me.colProduksiRepoLookup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.colProduksiRepoLookup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.colProduksiRepoLookup.Name = "colProduksiRepoLookup"
        Me.colProduksiRepoLookup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.colProduksiRepoLookup.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "No. Produksi"
        Me.GridColumn1.FieldName = "Kode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tanggal"
        Me.GridColumn2.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn2.FieldName = "Tanggal"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Sisa Produksi"
        Me.GridColumn3.DisplayFormat.FormatString = "n0"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "QtySisa"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "LOT NO"
        Me.GridColumn4.FieldName = "LOT"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Nomor PDO"
        Me.GridColumn5.FieldName = "NoPDO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'colQty
        '
        Me.colQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQty.Caption = "Qty Dikirim"
        Me.colQty.ColumnEdit = Me.colSpin
        Me.colQty.DisplayFormat.FormatString = "n0"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.FieldName = "Qty"
        Me.colQty.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colQty.Name = "colQty"
        Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 6
        Me.colQty.Width = 60
        '
        'colSpin
        '
        Me.colSpin.AutoHeight = False
        Me.colSpin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colSpin.DisplayFormat.FormatString = "n0"
        Me.colSpin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSpin.EditFormat.FormatString = "n0"
        Me.colSpin.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSpin.Name = "colSpin"
        '
        'colCatatan
        '
        Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
        Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
        Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCatatan.Caption = "Catatan"
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 7
        Me.colCatatan.Width = 214
        '
        'colOD
        '
        Me.colOD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOD.AppearanceCell.Options.UseBackColor = True
        Me.colOD.Caption = "OD"
        Me.colOD.DisplayFormat.FormatString = "n1"
        Me.colOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOD.FieldName = "OutDiameter"
        Me.colOD.Name = "colOD"
        Me.colOD.OptionsColumn.AllowEdit = False
        Me.colOD.OptionsColumn.ReadOnly = True
        Me.colOD.Visible = True
        Me.colOD.VisibleIndex = 8
        Me.colOD.Width = 40
        '
        'colODID
        '
        Me.colODID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colODID.AppearanceCell.Options.UseBackColor = True
        Me.colODID.Caption = "ID"
        Me.colODID.DisplayFormat.FormatString = "n1"
        Me.colODID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colODID.FieldName = "InDiameter"
        Me.colODID.Name = "colODID"
        Me.colODID.OptionsColumn.AllowEdit = False
        Me.colODID.OptionsColumn.ReadOnly = True
        Me.colODID.Visible = True
        Me.colODID.VisibleIndex = 9
        Me.colODID.Width = 40
        '
        'colT
        '
        Me.colT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colT.AppearanceCell.Options.UseBackColor = True
        Me.colT.Caption = "T"
        Me.colT.DisplayFormat.FormatString = "n1"
        Me.colT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colT.FieldName = "Thickness"
        Me.colT.Name = "colT"
        Me.colT.OptionsColumn.AllowEdit = False
        Me.colT.OptionsColumn.ReadOnly = True
        Me.colT.Visible = True
        Me.colT.VisibleIndex = 10
        Me.colT.Width = 40
        '
        'colL
        '
        Me.colL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colL.AppearanceCell.Options.UseBackColor = True
        Me.colL.Caption = "L"
        Me.colL.DisplayFormat.FormatString = "n1"
        Me.colL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colL.FieldName = "Length"
        Me.colL.Name = "colL"
        Me.colL.OptionsColumn.AllowEdit = False
        Me.colL.OptionsColumn.ReadOnly = True
        Me.colL.Visible = True
        Me.colL.VisibleIndex = 11
        Me.colL.Width = 40
        '
        'colNetWeight
        '
        Me.colNetWeight.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNetWeight.AppearanceCell.Options.UseBackColor = True
        Me.colNetWeight.Caption = "Net Weight"
        Me.colNetWeight.DisplayFormat.FormatString = "n2"
        Me.colNetWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNetWeight.FieldName = "Weight"
        Me.colNetWeight.Name = "colNetWeight"
        Me.colNetWeight.OptionsColumn.AllowEdit = False
        Me.colNetWeight.OptionsColumn.ReadOnly = True
        Me.colNetWeight.Visible = True
        Me.colNetWeight.VisibleIndex = 12
        Me.colNetWeight.Width = 62
        '
        'colGrossWeight
        '
        Me.colGrossWeight.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGrossWeight.AppearanceCell.Options.UseBackColor = True
        Me.colGrossWeight.Caption = "Gross Weight"
        Me.colGrossWeight.DisplayFormat.FormatString = "n2"
        Me.colGrossWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrossWeight.FieldName = "GrossWeight"
        Me.colGrossWeight.Name = "colGrossWeight"
        Me.colGrossWeight.OptionsColumn.AllowEdit = False
        Me.colGrossWeight.OptionsColumn.ReadOnly = True
        Me.colGrossWeight.Visible = True
        Me.colGrossWeight.VisibleIndex = 13
        Me.colGrossWeight.Width = 72
        '
        'colLot
        '
        Me.colLot.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colLot.AppearanceCell.Options.UseBackColor = True
        Me.colLot.Caption = "No. Lot"
        Me.colLot.FieldName = "ProduksiDetail.Main.DempyouLot"
        Me.colLot.Name = "colLot"
        Me.colLot.OptionsColumn.AllowEdit = False
        Me.colLot.OptionsColumn.ReadOnly = True
        Me.colLot.Visible = True
        Me.colLot.VisibleIndex = 14
        Me.colLot.Width = 60
        '
        'colSO
        '
        Me.colSO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSO.AppearanceCell.Options.UseBackColor = True
        Me.colSO.Caption = "No. SO"
        Me.colSO.FieldName = "SODetail.Main.Kode"
        Me.colSO.Name = "colSO"
        Me.colSO.OptionsColumn.AllowEdit = False
        Me.colSO.OptionsColumn.ReadOnly = True
        Me.colSO.Visible = True
        Me.colSO.VisibleIndex = 15
        Me.colSO.Width = 90
        '
        'colNoPODetail
        '
        Me.colNoPODetail.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNoPODetail.AppearanceCell.Options.UseBackColor = True
        Me.colNoPODetail.Caption = "No PO Detail"
        Me.colNoPODetail.FieldName = "SODetail.NoPODetail"
        Me.colNoPODetail.Name = "colNoPODetail"
        Me.colNoPODetail.OptionsColumn.AllowEdit = False
        Me.colNoPODetail.OptionsColumn.ReadOnly = True
        Me.colNoPODetail.Visible = True
        Me.colNoPODetail.VisibleIndex = 16
        Me.colNoPODetail.Width = 80
        '
        'colPOLine
        '
        Me.colPOLine.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPOLine.AppearanceCell.Options.UseBackColor = True
        Me.colPOLine.Caption = "PO Line"
        Me.colPOLine.FieldName = "SODetail.POLine"
        Me.colPOLine.Name = "colPOLine"
        Me.colPOLine.OptionsColumn.AllowEdit = False
        Me.colPOLine.OptionsColumn.ReadOnly = True
        Me.colPOLine.Visible = True
        Me.colPOLine.VisibleIndex = 17
        Me.colPOLine.Width = 55
        '
        'colQtyPalletHidden
        '
        Me.colQtyPalletHidden.Caption = "Qty/Pallet"
        Me.colQtyPalletHidden.ColumnEdit = Me.colSpin
        Me.colQtyPalletHidden.DisplayFormat.FormatString = "n0"
        Me.colQtyPalletHidden.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyPalletHidden.FieldName = "Qty"
        Me.colQtyPalletHidden.Name = "colQtyPalletHidden"
        Me.colQtyPalletHidden.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
        Me.colQtyPalletHidden.Width = 44
        '
        'colNoPalletHidden
        '
        Me.colNoPalletHidden.Caption = "No. Pallet"
        Me.colNoPalletHidden.FieldName = "NoPallet"
        Me.colNoPalletHidden.Name = "colNoPalletHidden"
        Me.colNoPalletHidden.Width = 38
        '
        'colNoProduksi
        '
        Me.colNoProduksi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNoProduksi.AppearanceCell.Options.UseBackColor = True
        Me.colNoProduksi.Caption = "No. Produksi"
        Me.colNoProduksi.FieldName = "ProduksiDetail.Main.Kode"
        Me.colNoProduksi.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colNoProduksi.Name = "colNoProduksi"
        Me.colNoProduksi.OptionsColumn.AllowEdit = False
        Me.colNoProduksi.OptionsColumn.ReadOnly = True
        Me.colNoProduksi.Width = 73
        '
        'colNoLot
        '
        Me.colNoLot.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNoLot.AppearanceCell.Options.UseBackColor = True
        Me.colNoLot.Caption = "No. Lot"
        Me.colNoLot.FieldName = "ProduksiDetail.Main.DempyouLot"
        Me.colNoLot.Name = "colNoLot"
        Me.colNoLot.OptionsColumn.AllowEdit = False
        Me.colNoLot.OptionsColumn.ReadOnly = True
        Me.colNoLot.Width = 36
        '
        'colProduksiDetail
        '
        Me.colProduksiDetail.Caption = "DetailId"
        Me.colProduksiDetail.FieldName = "ProduksiDetail.Id"
        Me.colProduksiDetail.Name = "colProduksiDetail"
        '
        'txtUraian
        '
        Me.txtUraian.Location = New System.Drawing.Point(114, 178)
        Me.txtUraian.MenuManager = Me.barMan
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUraian.Properties.MaxLength = 255
        Me.txtUraian.Size = New System.Drawing.Size(439, 20)
        Me.txtUraian.StyleController = Me.lytTransaksi
        Me.txtUraian.TabIndex = 10
        '
        'txtKontak
        '
        Me.txtKontak.Location = New System.Drawing.Point(92, 37)
        Me.txtKontak.MenuManager = Me.barMan
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKontak.Properties.DisplayMember = "Kode"
        Me.txtKontak.Properties.NullText = "<Pilih Customer>"
        Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(330, 0)
        Me.txtKontak.Properties.ShowClearButton = False
        Me.txtKontak.Properties.ShowFooter = False
        Me.txtKontak.Properties.ValueMember = "This"
        Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
        Me.txtKontak.Size = New System.Drawing.Size(199, 20)
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
        'txtOtomatisProduksi
        '
        Me.txtOtomatisProduksi.EditValue = Nothing
        Me.txtOtomatisProduksi.Location = New System.Drawing.Point(557, 106)
        Me.txtOtomatisProduksi.MenuManager = Me.barMan
        Me.txtOtomatisProduksi.Name = "txtOtomatisProduksi"
        Me.txtOtomatisProduksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtOtomatisProduksi.Properties.Caption = "Otomatis Ambil Kode Produksi"
        Me.txtOtomatisProduksi.Size = New System.Drawing.Size(176, 21)
        Me.txtOtomatisProduksi.StyleController = Me.lytTransaksi
        Me.txtOtomatisProduksi.TabIndex = 7
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtCheckStock
        Me.LayoutControlItem2.CustomizationFormText = "Check Stock"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(725, 94)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(191, 96)
        Me.LayoutControlItem2.Text = "Check Stock"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 20)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.EmptySpaceItem9, Me.LayoutControlGroup2, Me.LayoutControlItem6, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
        Me.LayoutControlGroup1.Text = "Root"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.xGrid
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 190)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1108, 220)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(0, 410)
        Me.EmptySpaceItem9.MaxSize = New System.Drawing.Size(0, 5)
        Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(10, 5)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(1108, 5)
        Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem17, Me.LayoutControlItem16, Me.LayoutControlItem15, Me.LayoutControlItem4, Me.lytRegional, Me.EmptySpaceItem3})
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
        Me.layKontak.CustomizationFormText = "Vendor"
        Me.layKontak.Location = New System.Drawing.Point(0, 0)
        Me.layKontak.Name = "layKontak"
        Me.layKontak.Size = New System.Drawing.Size(277, 48)
        Me.layKontak.Text = "Customer   "
        Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layKontak.TextSize = New System.Drawing.Size(69, 13)
        Me.layKontak.TextToControlDistance = 5
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
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtNoTransaksi
        Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(808, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(258, 24)
        Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem16.Text = "No. Bukti   "
        Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(43, 13)
        Me.LayoutControlItem16.TextToControlDistance = 5
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtTanggal
        Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(570, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(238, 24)
        Me.LayoutControlItem15.Text = "Tanggal   "
        Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(43, 13)
        Me.LayoutControlItem15.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtStatus
        Me.LayoutControlItem4.CustomizationFormText = "Status"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(808, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(258, 24)
        Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem4.Text = "Status   "
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(43, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'lytRegional
        '
        Me.lytRegional.Control = Me.txtRegional
        Me.lytRegional.CustomizationFormText = "Regional"
        Me.lytRegional.Location = New System.Drawing.Point(570, 24)
        Me.lytRegional.Name = "lytRegional"
        Me.lytRegional.Size = New System.Drawing.Size(238, 24)
        Me.lytRegional.Text = "Regional"
        Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lytRegional.TextSize = New System.Drawing.Size(43, 13)
        Me.lytRegional.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(277, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(293, 48)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtNoKendaraan
        Me.LayoutControlItem6.CustomizationFormText = "No Kendaraan"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(545, 24)
        Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem6.Text = "No Kendaraan"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtNamaDriver
        Me.LayoutControlItem10.CustomizationFormText = "Nama Driver"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 118)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(545, 24)
        Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem10.Text = "Nama Driver"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(92, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtUraian
        Me.LayoutControlItem3.CustomizationFormText = "Uraian"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 166)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(545, 24)
        Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem3.Text = "Uraian"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtJenisKendaraan
        Me.LayoutControlItem5.CustomizationFormText = "No Dokumen"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(545, 24)
        Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
        Me.LayoutControlItem5.Text = "Jenis Kendaraan"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(725, 94)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(383, 96)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtOtomatisProduksi
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(545, 94)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(180, 96)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
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
        'btnAmbilDataSO2
        '
        Me.btnAmbilDataSO2.Caption = "Ambil Data SO"
        Me.btnAmbilDataSO2.Glyph = CType(resources.GetObject("btnAmbilDataSO2.Glyph"), System.Drawing.Image)
        Me.btnAmbilDataSO2.Id = 10
        Me.btnAmbilDataSO2.LargeGlyph = CType(resources.GetObject("btnAmbilDataSO2.LargeGlyph"), System.Drawing.Image)
        Me.btnAmbilDataSO2.Name = "btnAmbilDataSO2"
        '
        'UI_FusohSJDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 468)
        Me.Controls.Add(Me.hideContainerRight)
        Me.KeyPreview = True
        Me.Name = "UI_FusohSJDialog"
        Me.Text = "Pengiriman Barang"
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
        CType(Me.txtCheckStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaDriver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJenisKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colCommandRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colProduksiRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colProduksiRepoLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtomatisProduksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSisaQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
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
  Friend WithEvents txtJenisKendaraan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNamaDriver As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNoKendaraan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents btnAmbilDataSO As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colOD As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colT As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colL As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLot As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyPalletHidden As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSpin As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents colNoPalletHidden As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNetWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colGrossWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCommand As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCommandRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents colNoPO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colProduksiDetail As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoProduksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoLot As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoPODetail As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPOLine As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnAmbilDataSO2 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colProduksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colProduksiRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
	Friend WithEvents colProduksiRepoLookup As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtOtomatisProduksi As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtCheckStock As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colODID As DevExpress.XtraGrid.Columns.GridColumn
End Class
