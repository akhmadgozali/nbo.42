<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_zForwarderInvoiceDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_zForwarderInvoiceDialog))
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
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
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtPPH = New DevExpress.XtraEditors.TextEdit()
    Me.txtDiscount = New DevExpress.XtraEditors.TextEdit()
    Me.txtPPN = New DevExpress.XtraEditors.TextEdit()
    Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoPPN = New DevExpress.XtraEditors.TextEdit()
    Me.txtShipment = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDestination = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDestinationRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCTNS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartay20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartay40 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartayLCL = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceShipmentFee20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceShipmentFee40 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceShipmentFeeTBS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceCustomInspection = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceCOO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceVHCItem = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceVHCValue = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceSealFee = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceRecooling20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceRecooling40 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceMonitoring20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceMonitoring40 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIceNotulPeb = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryCTNSValue = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryTrucking20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryTrucking40 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryTruckingLCL = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryCOO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryPhytosanitary20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryPhytosanitary40 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryJaring20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryJaring40 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryCargo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryTriplek = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryMeratus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryDocFee = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDrySealFee = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryServiceCharge = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryLOLO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDryNotulPeb = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBiayaLainLain = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtAlamat = New DevExpress.XtraEditors.MemoEdit()
    Me.txtCatatan = New DevExpress.XtraEditors.MemoExEdit()
    Me.txtProduk = New DevExpress.XtraEditors.CheckedComboBoxEdit()
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
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem21 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem13 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem20 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
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
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtShipment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDestinationRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2})
    Me.barMan.MaxItemId = 9
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colKodeBarangRepo
    '
    Me.colKodeBarangRepo.AutoHeight = False
    Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKodeBarangRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "No. Akun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama Akun")})
    Me.colKodeBarangRepo.DisplayMember = "Kode"
    Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
    Me.colKodeBarangRepo.NullText = "<Pilih Barang>"
    Me.colKodeBarangRepo.PopupWidth = 300
    Me.colKodeBarangRepo.ValueMember = "This"
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
    Me.hideContainerRight.Location = New System.Drawing.Point(978, 0)
    Me.hideContainerRight.Name = "hideContainerRight"
    Me.hideContainerRight.Size = New System.Drawing.Size(19, 489)
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
    Me.DockPanel1.Size = New System.Drawing.Size(250, 489)
    Me.DockPanel1.Text = "Panel Informasi"
    Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
    '
    'DockPanel1_Container
    '
    Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
    Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
    Me.DockPanel1_Container.Name = "DockPanel1_Container"
    Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 462)
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
    Me.NavBarControl1.Size = New System.Drawing.Size(242, 462)
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
    Me.DockPanel2.OriginalSize = New System.Drawing.Size(991, 483)
    Me.DockPanel2.Text = "DockPanel2"
    '
    'DockPanel2_Container
    '
    Me.DockPanel2_Container.Controls.Add(Me.LayoutControl1)
    Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
    Me.DockPanel2_Container.Name = "DockPanel2_Container"
    Me.DockPanel2_Container.Size = New System.Drawing.Size(991, 483)
    Me.DockPanel2_Container.TabIndex = 0
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtPPH)
    Me.LayoutControl1.Controls.Add(Me.txtDiscount)
    Me.LayoutControl1.Controls.Add(Me.txtPPN)
    Me.LayoutControl1.Controls.Add(Me.txtSubTotal)
    Me.LayoutControl1.Controls.Add(Me.txtTotal)
    Me.LayoutControl1.Controls.Add(Me.txtStatus)
    Me.LayoutControl1.Controls.Add(Me.txtNoPPN)
    Me.LayoutControl1.Controls.Add(Me.txtShipment)
    Me.LayoutControl1.Controls.Add(Me.txtKontakPerson)
    Me.LayoutControl1.Controls.Add(Me.txtRegional)
    Me.LayoutControl1.Controls.Add(Me.txtTanggal)
    Me.LayoutControl1.Controls.Add(Me.btnRefreshNomor)
    Me.LayoutControl1.Controls.Add(Me.txtNoTransaksi)
    Me.LayoutControl1.Controls.Add(Me.xGrid)
    Me.LayoutControl1.Controls.Add(Me.txtUraian)
    Me.LayoutControl1.Controls.Add(Me.txtKontak)
    Me.LayoutControl1.Controls.Add(Me.txtAlamat)
    Me.LayoutControl1.Controls.Add(Me.txtCatatan)
    Me.LayoutControl1.Controls.Add(Me.txtProduk)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(344, 333, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(991, 483)
    Me.LayoutControl1.TabIndex = 0
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtPPH
    '
    Me.txtPPH.Location = New System.Drawing.Point(817, 398)
    Me.txtPPH.MenuManager = Me.barMan
    Me.txtPPH.Name = "txtPPH"
    Me.txtPPH.Properties.Mask.EditMask = "n2"
    Me.txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPH.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPH.Size = New System.Drawing.Size(124, 20)
    Me.txtPPH.StyleController = Me.LayoutControl1
    Me.txtPPH.TabIndex = 17
    '
    'txtDiscount
    '
    Me.txtDiscount.Location = New System.Drawing.Point(817, 326)
    Me.txtDiscount.MenuManager = Me.barMan
    Me.txtDiscount.Name = "txtDiscount"
    Me.txtDiscount.Properties.Mask.EditMask = "n2"
    Me.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDiscount.Size = New System.Drawing.Size(124, 20)
    Me.txtDiscount.StyleController = Me.LayoutControl1
    Me.txtDiscount.TabIndex = 14
    '
    'txtPPN
    '
    Me.txtPPN.Location = New System.Drawing.Point(817, 374)
    Me.txtPPN.MenuManager = Me.barMan
    Me.txtPPN.Name = "txtPPN"
    Me.txtPPN.Properties.Appearance.Options.UseTextOptions = True
    Me.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtPPN.Properties.Mask.EditMask = "n2"
    Me.txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPN.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPN.Size = New System.Drawing.Size(124, 20)
    Me.txtPPN.StyleController = Me.LayoutControl1
    Me.txtPPN.TabIndex = 16
    '
    'txtSubTotal
    '
    Me.txtSubTotal.Location = New System.Drawing.Point(817, 350)
    Me.txtSubTotal.MenuManager = Me.barMan
    Me.txtSubTotal.Name = "txtSubTotal"
    Me.txtSubTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtSubTotal.Properties.Mask.EditMask = "n2"
    Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtSubTotal.Size = New System.Drawing.Size(124, 20)
    Me.txtSubTotal.StyleController = Me.LayoutControl1
    Me.txtSubTotal.TabIndex = 15
    '
    'txtTotal
    '
    Me.txtTotal.Location = New System.Drawing.Point(817, 422)
    Me.txtTotal.MenuManager = Me.barMan
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtTotal.Properties.Mask.EditMask = "n2"
    Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtTotal.Size = New System.Drawing.Size(124, 20)
    Me.txtTotal.StyleController = Me.LayoutControl1
    Me.txtTotal.TabIndex = 18
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(868, 22)
    Me.txtStatus.MenuManager = Me.barMan
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtStatus.Properties.DisplayMember = "Value"
    Me.txtStatus.Properties.NullText = "<Status>"
    Me.txtStatus.Properties.ValueMember = "Key"
    Me.txtStatus.Size = New System.Drawing.Size(98, 20)
    Me.txtStatus.StyleController = Me.LayoutControl1
    Me.txtStatus.TabIndex = 4
    '
    'txtNoPPN
    '
    Me.txtNoPPN.Location = New System.Drawing.Point(206, 330)
    Me.txtNoPPN.MenuManager = Me.barMan
    Me.txtNoPPN.Name = "txtNoPPN"
    Me.txtNoPPN.Size = New System.Drawing.Size(141, 20)
    Me.txtNoPPN.StyleController = Me.LayoutControl1
    Me.txtNoPPN.TabIndex = 13
    '
    'txtShipment
    '
    Me.txtShipment.Location = New System.Drawing.Point(792, 79)
    Me.txtShipment.MenuManager = Me.barMan
    Me.txtShipment.Name = "txtShipment"
    Me.txtShipment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtShipment.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtShipment.Properties.DisplayMember = "Kode"
    Me.txtShipment.Properties.NullText = "<Pilih Shipment Mode>"
    Me.txtShipment.Properties.ValueMember = "This"
    Me.txtShipment.Size = New System.Drawing.Size(173, 20)
    Me.txtShipment.StyleController = Me.LayoutControl1
    Me.txtShipment.TabIndex = 7
    '
    'txtKontakPerson
    '
    Me.txtKontakPerson.Location = New System.Drawing.Point(88, 63)
    Me.txtKontakPerson.MenuManager = Me.barMan
    Me.txtKontakPerson.Name = "txtKontakPerson"
    Me.txtKontakPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontakPerson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 30, "Nama")})
    Me.txtKontakPerson.Properties.DisplayMember = "Nama"
    Me.txtKontakPerson.Properties.NullText = "<Pilih Kontak Person>"
    Me.txtKontakPerson.Properties.PopupWidth = 30
    Me.txtKontakPerson.Properties.ValueMember = "Nama"
    Me.txtKontakPerson.Size = New System.Drawing.Size(143, 20)
    Me.txtKontakPerson.StyleController = Me.LayoutControl1
    Me.txtKontakPerson.TabIndex = 5
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(558, 79)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.PopupWidth = 200
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(230, 20)
    Me.txtRegional.StyleController = Me.LayoutControl1
    Me.txtRegional.TabIndex = 6
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(463, 22)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(110, 20)
    Me.txtTanggal.StyleController = Me.LayoutControl1
    Me.txtTanggal.TabIndex = 1
    '
    'btnRefreshNomor
    '
    Me.btnRefreshNomor.AutoWidthInLayoutControl = True
    Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
    Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnRefreshNomor.Location = New System.Drawing.Point(765, 22)
    Me.btnRefreshNomor.Name = "btnRefreshNomor"
    Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
    Me.btnRefreshNomor.StyleController = Me.LayoutControl1
    Me.btnRefreshNomor.TabIndex = 3
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(660, 22)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Size = New System.Drawing.Size(101, 20)
    Me.txtNoTransaksi.StyleController = Me.LayoutControl1
    Me.txtNoTransaksi.TabIndex = 2
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 172)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colDestinationRepo})
    Me.xGrid.Size = New System.Drawing.Size(970, 133)
    Me.xGrid.TabIndex = 11
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoice, Me.colDestination, Me.colTotal, Me.colCTNS, Me.colPartay20, Me.colPartay40, Me.colPartayLCL, Me.colIceShipmentFee20, Me.colIceShipmentFee40, Me.colIceShipmentFeeTBS, Me.colIceCustomInspection, Me.colIceCOO, Me.colIceVHCItem, Me.colIceVHCValue, Me.colIceSealFee, Me.colIceRecooling20, Me.colIceRecooling40, Me.colIceMonitoring20, Me.colIceMonitoring40, Me.colIceNotulPeb, Me.colDryCTNSValue, Me.colDryTrucking20, Me.colDryTrucking40, Me.colDryTruckingLCL, Me.colDryCOO, Me.colDryPhytosanitary20, Me.colDryPhytosanitary40, Me.colDryJaring20, Me.colDryJaring40, Me.colDryCargo, Me.colDryTriplek, Me.colDryMeratus, Me.colDryDocFee, Me.colDrySealFee, Me.colDryServiceCharge, Me.colDryLOLO, Me.colDryNotulPeb, Me.colBiayaLainLain})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsPrint.AutoWidth = False
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colInvoice
    '
    Me.colInvoice.Caption = "Invoice"
    Me.colInvoice.FieldName = "InvoiceNo"
    Me.colInvoice.Name = "colInvoice"
    Me.colInvoice.OptionsColumn.AllowMove = False
    Me.colInvoice.Visible = True
    Me.colInvoice.VisibleIndex = 0
    Me.colInvoice.Width = 205
    '
    'colDestination
    '
    Me.colDestination.AppearanceCell.Options.UseTextOptions = True
    Me.colDestination.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colDestination.AppearanceHeader.Options.UseTextOptions = True
    Me.colDestination.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colDestination.Caption = "Destination"
    Me.colDestination.ColumnEdit = Me.colDestinationRepo
    Me.colDestination.FieldName = "Destination!"
    Me.colDestination.Name = "colDestination"
    Me.colDestination.OptionsColumn.AllowMove = False
    Me.colDestination.Visible = True
    Me.colDestination.VisibleIndex = 1
    Me.colDestination.Width = 131
    '
    'colDestinationRepo
    '
    Me.colDestinationRepo.AutoHeight = False
    Me.colDestinationRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colDestinationRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colDestinationRepo.DisplayMember = "Kode"
    Me.colDestinationRepo.Name = "colDestinationRepo"
    Me.colDestinationRepo.NullText = "<Pilih Destination>"
    Me.colDestinationRepo.ValueMember = "This"
    '
    'colTotal
    '
    Me.colTotal.AppearanceHeader.Options.UseTextOptions = True
    Me.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colTotal.Caption = "Total"
    Me.colTotal.FieldName = "Harga"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 2
    Me.colTotal.Width = 110
    '
    'colCTNS
    '
    Me.colCTNS.Caption = "CTNS"
    Me.colCTNS.FieldName = "CTNS"
    Me.colCTNS.Name = "colCTNS"
    Me.colCTNS.Visible = True
    Me.colCTNS.VisibleIndex = 3
    '
    'colPartay20
    '
    Me.colPartay20.Caption = "Partay 20'"
    Me.colPartay20.FieldName = "Partay20"
    Me.colPartay20.Name = "colPartay20"
    Me.colPartay20.Visible = True
    Me.colPartay20.VisibleIndex = 4
    '
    'colPartay40
    '
    Me.colPartay40.Caption = "Partay 40'"
    Me.colPartay40.FieldName = "Partay40"
    Me.colPartay40.Name = "colPartay40"
    Me.colPartay40.Visible = True
    Me.colPartay40.VisibleIndex = 5
    '
    'colPartayLCL
    '
    Me.colPartayLCL.Caption = "Partay LCL"
    Me.colPartayLCL.FieldName = "PartayLCL"
    Me.colPartayLCL.Name = "colPartayLCL"
    Me.colPartayLCL.Visible = True
    Me.colPartayLCL.VisibleIndex = 6
    '
    'colIceShipmentFee20
    '
    Me.colIceShipmentFee20.Caption = "Shipment Fee 20"
    Me.colIceShipmentFee20.FieldName = "IceShipmentFee20"
    Me.colIceShipmentFee20.Name = "colIceShipmentFee20"
    Me.colIceShipmentFee20.Visible = True
    Me.colIceShipmentFee20.VisibleIndex = 7
    '
    'colIceShipmentFee40
    '
    Me.colIceShipmentFee40.Caption = "Shipment Fee 40"
    Me.colIceShipmentFee40.FieldName = "IceShipmentFee40"
    Me.colIceShipmentFee40.Name = "colIceShipmentFee40"
    Me.colIceShipmentFee40.Visible = True
    Me.colIceShipmentFee40.VisibleIndex = 8
    '
    'colIceShipmentFeeTBS
    '
    Me.colIceShipmentFeeTBS.Caption = "Shipment Fee TBS/KIAT"
    Me.colIceShipmentFeeTBS.FieldName = "IceShipmentFeeTBS"
    Me.colIceShipmentFeeTBS.Name = "colIceShipmentFeeTBS"
    Me.colIceShipmentFeeTBS.Visible = True
    Me.colIceShipmentFeeTBS.VisibleIndex = 9
    '
    'colIceCustomInspection
    '
    Me.colIceCustomInspection.Caption = "Custom Inspection"
    Me.colIceCustomInspection.FieldName = "IceCustomInspection"
    Me.colIceCustomInspection.Name = "colIceCustomInspection"
    Me.colIceCustomInspection.Visible = True
    Me.colIceCustomInspection.VisibleIndex = 10
    '
    'colIceCOO
    '
    Me.colIceCOO.Caption = "COO"
    Me.colIceCOO.FieldName = "IceCOO"
    Me.colIceCOO.Name = "colIceCOO"
    Me.colIceCOO.Visible = True
    Me.colIceCOO.VisibleIndex = 11
    '
    'colIceVHCItem
    '
    Me.colIceVHCItem.FieldName = "IceVHCItem"
    Me.colIceVHCItem.Name = "colIceVHCItem"
    Me.colIceVHCItem.Visible = True
    Me.colIceVHCItem.VisibleIndex = 12
    '
    'colIceVHCValue
    '
    Me.colIceVHCValue.FieldName = "IceVHCValue"
    Me.colIceVHCValue.Name = "colIceVHCValue"
    Me.colIceVHCValue.Visible = True
    Me.colIceVHCValue.VisibleIndex = 13
    '
    'colIceSealFee
    '
    Me.colIceSealFee.FieldName = "IceSealFee"
    Me.colIceSealFee.Name = "colIceSealFee"
    Me.colIceSealFee.Visible = True
    Me.colIceSealFee.VisibleIndex = 14
    '
    'colIceRecooling20
    '
    Me.colIceRecooling20.FieldName = "IceRecooling20"
    Me.colIceRecooling20.Name = "colIceRecooling20"
    Me.colIceRecooling20.Visible = True
    Me.colIceRecooling20.VisibleIndex = 15
    '
    'colIceRecooling40
    '
    Me.colIceRecooling40.FieldName = "IceRecooling40"
    Me.colIceRecooling40.Name = "colIceRecooling40"
    Me.colIceRecooling40.Visible = True
    Me.colIceRecooling40.VisibleIndex = 16
    '
    'colIceMonitoring20
    '
    Me.colIceMonitoring20.FieldName = "IceMonitoring20"
    Me.colIceMonitoring20.Name = "colIceMonitoring20"
    Me.colIceMonitoring20.Visible = True
    Me.colIceMonitoring20.VisibleIndex = 17
    '
    'colIceMonitoring40
    '
    Me.colIceMonitoring40.FieldName = "IceMonitoring40"
    Me.colIceMonitoring40.Name = "colIceMonitoring40"
    Me.colIceMonitoring40.Visible = True
    Me.colIceMonitoring40.VisibleIndex = 18
    '
    'colIceNotulPeb
    '
    Me.colIceNotulPeb.FieldName = "IceNotulPeb"
    Me.colIceNotulPeb.Name = "colIceNotulPeb"
    Me.colIceNotulPeb.Visible = True
    Me.colIceNotulPeb.VisibleIndex = 19
    '
    'colDryCTNSValue
    '
    Me.colDryCTNSValue.FieldName = "DryCTNSValue"
    Me.colDryCTNSValue.Name = "colDryCTNSValue"
    Me.colDryCTNSValue.Visible = True
    Me.colDryCTNSValue.VisibleIndex = 20
    '
    'colDryTrucking20
    '
    Me.colDryTrucking20.FieldName = "DryTrucking20"
    Me.colDryTrucking20.Name = "colDryTrucking20"
    Me.colDryTrucking20.Visible = True
    Me.colDryTrucking20.VisibleIndex = 21
    '
    'colDryTrucking40
    '
    Me.colDryTrucking40.FieldName = "DryTrucking40"
    Me.colDryTrucking40.Name = "colDryTrucking40"
    Me.colDryTrucking40.Visible = True
    Me.colDryTrucking40.VisibleIndex = 22
    '
    'colDryTruckingLCL
    '
    Me.colDryTruckingLCL.FieldName = "DryTruckingLCL"
    Me.colDryTruckingLCL.Name = "colDryTruckingLCL"
    Me.colDryTruckingLCL.Visible = True
    Me.colDryTruckingLCL.VisibleIndex = 23
    '
    'colDryCOO
    '
    Me.colDryCOO.FieldName = "DryCOO"
    Me.colDryCOO.Name = "colDryCOO"
    Me.colDryCOO.Visible = True
    Me.colDryCOO.VisibleIndex = 24
    '
    'colDryPhytosanitary20
    '
    Me.colDryPhytosanitary20.FieldName = "DryPhytosanitary20"
    Me.colDryPhytosanitary20.Name = "colDryPhytosanitary20"
    Me.colDryPhytosanitary20.Visible = True
    Me.colDryPhytosanitary20.VisibleIndex = 25
    '
    'colDryPhytosanitary40
    '
    Me.colDryPhytosanitary40.FieldName = "DryPhytosanitary40"
    Me.colDryPhytosanitary40.Name = "colDryPhytosanitary40"
    Me.colDryPhytosanitary40.Visible = True
    Me.colDryPhytosanitary40.VisibleIndex = 26
    '
    'colDryJaring20
    '
    Me.colDryJaring20.FieldName = "DryJaring20"
    Me.colDryJaring20.Name = "colDryJaring20"
    Me.colDryJaring20.Visible = True
    Me.colDryJaring20.VisibleIndex = 27
    '
    'colDryJaring40
    '
    Me.colDryJaring40.FieldName = "DryJaring40"
    Me.colDryJaring40.Name = "colDryJaring40"
    Me.colDryJaring40.Visible = True
    Me.colDryJaring40.VisibleIndex = 28
    '
    'colDryCargo
    '
    Me.colDryCargo.FieldName = "DryCargo"
    Me.colDryCargo.Name = "colDryCargo"
    Me.colDryCargo.Visible = True
    Me.colDryCargo.VisibleIndex = 29
    '
    'colDryTriplek
    '
    Me.colDryTriplek.FieldName = "DryTriplek"
    Me.colDryTriplek.Name = "colDryTriplek"
    Me.colDryTriplek.Visible = True
    Me.colDryTriplek.VisibleIndex = 30
    '
    'colDryMeratus
    '
    Me.colDryMeratus.FieldName = "DryMeratus"
    Me.colDryMeratus.Name = "colDryMeratus"
    Me.colDryMeratus.Visible = True
    Me.colDryMeratus.VisibleIndex = 31
    '
    'colDryDocFee
    '
    Me.colDryDocFee.FieldName = "DryDocFee"
    Me.colDryDocFee.Name = "colDryDocFee"
    Me.colDryDocFee.Visible = True
    Me.colDryDocFee.VisibleIndex = 32
    '
    'colDrySealFee
    '
    Me.colDrySealFee.FieldName = "DrySealFee"
    Me.colDrySealFee.Name = "colDrySealFee"
    Me.colDrySealFee.Visible = True
    Me.colDrySealFee.VisibleIndex = 33
    '
    'colDryServiceCharge
    '
    Me.colDryServiceCharge.FieldName = "DryServiceCharge"
    Me.colDryServiceCharge.Name = "colDryServiceCharge"
    Me.colDryServiceCharge.Visible = True
    Me.colDryServiceCharge.VisibleIndex = 34
    '
    'colDryLOLO
    '
    Me.colDryLOLO.FieldName = "DryLOLO"
    Me.colDryLOLO.Name = "colDryLOLO"
    Me.colDryLOLO.Visible = True
    Me.colDryLOLO.VisibleIndex = 35
    '
    'colDryNotulPeb
    '
    Me.colDryNotulPeb.FieldName = "DryNotulPeb"
    Me.colDryNotulPeb.Name = "colDryNotulPeb"
    Me.colDryNotulPeb.Visible = True
    Me.colDryNotulPeb.VisibleIndex = 36
    '
    'colBiayaLainLain
    '
    Me.colBiayaLainLain.FieldName = "BiayaLainLain"
    Me.colBiayaLainLain.Name = "colBiayaLainLain"
    Me.colBiayaLainLain.Visible = True
    Me.colBiayaLainLain.VisibleIndex = 37
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(88, 143)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(894, 20)
    Me.txtUraian.StyleController = Me.LayoutControl1
    Me.txtUraian.TabIndex = 10
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
    Me.txtKontak.Size = New System.Drawing.Size(124, 20)
    Me.txtKontak.StyleController = Me.LayoutControl1
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
    'txtAlamat
    '
    Me.txtAlamat.Location = New System.Drawing.Point(88, 87)
    Me.txtAlamat.MenuManager = Me.barMan
    Me.txtAlamat.Name = "txtAlamat"
    Me.txtAlamat.Size = New System.Drawing.Size(143, 52)
    Me.txtAlamat.StyleController = Me.LayoutControl1
    Me.txtAlamat.TabIndex = 8
    Me.txtAlamat.UseOptimizedRendering = True
    '
    'txtCatatan
    '
    Me.txtCatatan.Location = New System.Drawing.Point(12, 330)
    Me.txtCatatan.MenuManager = Me.barMan
    Me.txtCatatan.Name = "txtCatatan"
    Me.txtCatatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCatatan.Size = New System.Drawing.Size(190, 20)
    Me.txtCatatan.StyleController = Me.LayoutControl1
    Me.txtCatatan.TabIndex = 12
    '
    'txtProduk
    '
    Me.txtProduk.EditValue = ""
    Me.txtProduk.Location = New System.Drawing.Point(558, 119)
    Me.txtProduk.MenuManager = Me.barMan
    Me.txtProduk.Name = "txtProduk"
    Me.txtProduk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProduk.Size = New System.Drawing.Size(407, 20)
    Me.txtProduk.StyleController = Me.LayoutControl1
    Me.txtProduk.TabIndex = 9
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlGroup3, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.EmptySpaceItem9, Me.LayoutControlItem1, Me.EmptySpaceItem13, Me.EmptySpaceItem10, Me.EmptySpaceItem11, Me.EmptySpaceItem20, Me.LayoutControlGroup2, Me.lytRegional, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem19, Me.LayoutControlItem10, Me.LayoutControlItem11})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(994, 466)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 131)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(974, 24)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGrid
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 160)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(974, 137)
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
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem16, Me.layKontakNama, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem15, Me.EmptySpaceItem6, Me.LayoutControlItem14, Me.LayoutControlItem17, Me.EmptySpaceItem21})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(974, 46)
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
    Me.layKontak.Size = New System.Drawing.Size(188, 26)
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
    Me.LayoutControlItem16.Location = New System.Drawing.Point(591, 10)
    Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(162, 26)
    Me.LayoutControlItem16.MinSize = New System.Drawing.Size(162, 26)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(162, 26)
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
    Me.layKontakNama.Location = New System.Drawing.Point(198, 10)
    Me.layKontakNama.Name = "layKontakNama"
    Me.layKontakNama.Size = New System.Drawing.Size(201, 26)
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
    Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(948, 10)
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
    Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(948, 10)
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
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(958, 0)
    Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(16, 46)
    Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(16, 46)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(16, 46)
    Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(399, 10)
    Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(166, 26)
    Me.LayoutControlItem15.MinSize = New System.Drawing.Size(166, 26)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(166, 26)
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
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(565, 10)
    Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(26, 26)
    Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(26, 26)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(26, 26)
    Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtStatus
    Me.LayoutControlItem14.CustomizationFormText = "Status"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(811, 10)
    Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(147, 26)
    Me.LayoutControlItem14.MinSize = New System.Drawing.Size(147, 26)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(147, 26)
    Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem14.Text = "Status   "
    Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(40, 13)
    Me.LayoutControlItem14.TextToControlDistance = 5
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.btnRefreshNomor
    Me.LayoutControlItem17.CustomizationFormText = " "
    Me.LayoutControlItem17.Location = New System.Drawing.Point(753, 10)
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
    'EmptySpaceItem21
    '
    Me.EmptySpaceItem21.AllowHotTrack = False
    Me.EmptySpaceItem21.CustomizationFormText = "EmptySpaceItem21"
    Me.EmptySpaceItem21.Location = New System.Drawing.Point(783, 10)
    Me.EmptySpaceItem21.MaxSize = New System.Drawing.Size(28, 26)
    Me.EmptySpaceItem21.MinSize = New System.Drawing.Size(28, 26)
    Me.EmptySpaceItem21.Name = "EmptySpaceItem21"
    Me.EmptySpaceItem21.Size = New System.Drawing.Size(28, 26)
    Me.EmptySpaceItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem21.Text = "EmptySpaceItem21"
    Me.EmptySpaceItem21.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem7
    '
    Me.EmptySpaceItem7.AllowHotTrack = False
    Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 46)
    Me.EmptySpaceItem7.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Size = New System.Drawing.Size(974, 5)
    Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
    Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem8
    '
    Me.EmptySpaceItem8.AllowHotTrack = False
    Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 155)
    Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Size = New System.Drawing.Size(974, 5)
    Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
    Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem9
    '
    Me.EmptySpaceItem9.AllowHotTrack = False
    Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Location = New System.Drawing.Point(0, 297)
    Me.EmptySpaceItem9.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Size = New System.Drawing.Size(974, 5)
    Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
    Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKontakPerson
    Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 51)
    Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(223, 24)
    Me.LayoutControlItem1.MinSize = New System.Drawing.Size(223, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(223, 24)
    Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem1.Text = "Kontak Person"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(73, 13)
    '
    'EmptySpaceItem13
    '
    Me.EmptySpaceItem13.AllowHotTrack = False
    Me.EmptySpaceItem13.CustomizationFormText = "EmptySpaceItem13"
    Me.EmptySpaceItem13.Location = New System.Drawing.Point(945, 302)
    Me.EmptySpaceItem13.Name = "EmptySpaceItem13"
    Me.EmptySpaceItem13.Size = New System.Drawing.Size(29, 144)
    Me.EmptySpaceItem13.Text = "EmptySpaceItem13"
    Me.EmptySpaceItem13.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem10
    '
    Me.EmptySpaceItem10.AllowHotTrack = False
    Me.EmptySpaceItem10.CustomizationFormText = "EmptySpaceItem10"
    Me.EmptySpaceItem10.Location = New System.Drawing.Point(957, 51)
    Me.EmptySpaceItem10.MaxSize = New System.Drawing.Size(17, 80)
    Me.EmptySpaceItem10.MinSize = New System.Drawing.Size(17, 80)
    Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
    Me.EmptySpaceItem10.Size = New System.Drawing.Size(17, 80)
    Me.EmptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem10.Text = "EmptySpaceItem10"
    Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem11
    '
    Me.EmptySpaceItem11.AllowHotTrack = False
    Me.EmptySpaceItem11.CustomizationFormText = "EmptySpaceItem11"
    Me.EmptySpaceItem11.Location = New System.Drawing.Point(223, 51)
    Me.EmptySpaceItem11.MinSize = New System.Drawing.Size(104, 24)
    Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
    Me.EmptySpaceItem11.Size = New System.Drawing.Size(323, 80)
    Me.EmptySpaceItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem11.Text = "EmptySpaceItem11"
    Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem20
    '
    Me.EmptySpaceItem20.AllowHotTrack = False
    Me.EmptySpaceItem20.CustomizationFormText = "EmptySpaceItem20"
    Me.EmptySpaceItem20.Location = New System.Drawing.Point(339, 302)
    Me.EmptySpaceItem20.Name = "EmptySpaceItem20"
    Me.EmptySpaceItem20.Size = New System.Drawing.Size(378, 144)
    Me.EmptySpaceItem20.Text = "EmptySpaceItem20"
    Me.EmptySpaceItem20.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem23, Me.LayoutControlItem13, Me.LayoutControlItem5, Me.LayoutControlItem6})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(717, 302)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(228, 144)
    Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
    Me.LayoutControlGroup2.TextVisible = False
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtTotal
    Me.LayoutControlItem9.CustomizationFormText = "Total Transaksi"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(204, 24)
    Me.LayoutControlItem9.Text = "Total Transaksi"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem23
    '
    Me.LayoutControlItem23.Control = Me.txtPPN
    Me.LayoutControlItem23.CustomizationFormText = "PPN"
    Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem23.Name = "LayoutControlItem23"
    Me.LayoutControlItem23.Size = New System.Drawing.Size(204, 24)
    Me.LayoutControlItem23.Text = "PPN"
    Me.LayoutControlItem23.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtSubTotal
    Me.LayoutControlItem13.CustomizationFormText = "Sub Total"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(204, 24)
    Me.LayoutControlItem13.Text = "Sub Total"
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtDiscount
    Me.LayoutControlItem5.CustomizationFormText = "Discount"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(204, 24)
    Me.LayoutControlItem5.Text = "Discount"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtPPH
    Me.LayoutControlItem6.CustomizationFormText = "PPH"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(204, 24)
    Me.LayoutControlItem6.Text = "PPH"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(73, 13)
    '
    'lytRegional
    '
    Me.lytRegional.Control = Me.txtRegional
    Me.lytRegional.CustomizationFormText = "Regional"
    Me.lytRegional.Location = New System.Drawing.Point(546, 51)
    Me.lytRegional.MinSize = New System.Drawing.Size(77, 40)
    Me.lytRegional.Name = "lytRegional"
    Me.lytRegional.Size = New System.Drawing.Size(234, 40)
    Me.lytRegional.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.lytRegional.Text = "Regional"
    Me.lytRegional.TextLocation = DevExpress.Utils.Locations.Top
    Me.lytRegional.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtAlamat
    Me.LayoutControlItem2.CustomizationFormText = "Alamat"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 75)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(223, 56)
    Me.LayoutControlItem2.Text = "Alamat"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtCatatan
    Me.LayoutControlItem4.CustomizationFormText = "Catatan"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 302)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(194, 144)
    Me.LayoutControlItem4.Text = "Catatan"
    Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.txtNoPPN
    Me.LayoutControlItem19.CustomizationFormText = "No Faktur PPN"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(194, 302)
    Me.LayoutControlItem19.MinSize = New System.Drawing.Size(106, 40)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(145, 144)
    Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem19.Text = "No Faktur PPN"
    Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtShipment
    Me.LayoutControlItem10.CustomizationFormText = "Pajak"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(780, 51)
    Me.LayoutControlItem10.MinSize = New System.Drawing.Size(77, 40)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(177, 40)
    Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem10.Text = "Shipment Mode"
    Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(73, 13)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtProduk
    Me.LayoutControlItem11.CustomizationFormText = "Bag Pembelian"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(546, 91)
    Me.LayoutControlItem11.MinSize = New System.Drawing.Size(50, 25)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(411, 40)
    Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem11.Text = "Produk"
    Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(73, 13)
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
    'UI_zForwarderInvoiceDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(997, 516)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "UI_zForwarderInvoiceDialog"
    Me.Text = "Penerimaan Invoice"
    Me.Controls.SetChildIndex(Me.hideContainerRight, 0)
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
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
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtShipment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDestinationRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
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
  Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
  Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
  Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem13 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtShipment As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtNoPPN As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem20 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem21 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPPN As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colInvoice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDestination As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtAlamat As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents txtCatatan As DevExpress.XtraEditors.MemoExEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtProduk As DevExpress.XtraEditors.CheckedComboBoxEdit
  Friend WithEvents colDestinationRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtPPH As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDiscount As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colCTNS As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPartay20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPartay40 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPartayLCL As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceShipmentFee20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceShipmentFee40 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceShipmentFeeTBS As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceCustomInspection As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceCOO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceVHCItem As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceVHCValue As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceSealFee As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceRecooling20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceRecooling40 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceMonitoring20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceMonitoring40 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIceNotulPeb As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryCTNSValue As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryTrucking20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryTrucking40 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryTruckingLCL As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryCOO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryPhytosanitary20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryPhytosanitary40 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryJaring20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryJaring40 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryCargo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryTriplek As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryMeratus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryDocFee As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDrySealFee As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryServiceCharge As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryLOLO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDryNotulPeb As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBiayaLainLain As DevExpress.XtraGrid.Columns.GridColumn
End Class
