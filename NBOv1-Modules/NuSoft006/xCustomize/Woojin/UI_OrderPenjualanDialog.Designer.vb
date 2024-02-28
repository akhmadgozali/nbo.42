<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zWoojinUI_OrderPenjualanDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zWoojinUI_OrderPenjualanDialog))
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
    Me.txtCustom4 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustom5 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustom3 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustom2 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustom1 = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoRef = New DevExpress.XtraEditors.TextEdit()
    Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtPPH = New DevExpress.XtraEditors.TextEdit()
    Me.txtPPN = New DevExpress.XtraEditors.TextEdit()
    Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtPajak = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colPPN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPH = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colProyek = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colProyekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDiscountPersen = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDPP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPHp = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPHv = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPNp = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPNv = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtCatatan = New DevExpress.XtraEditors.MemoExEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtKaryawan = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtAlamatText = New DevExpress.XtraEditors.MemoEdit()
    Me.txtAlamat = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
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
    Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
    Me.txtProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
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
    CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colProyekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAlamatText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
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
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.DockPanel1.Size = New System.Drawing.Size(250, 450)
    Me.DockPanel1.Text = "Panel Informasi"
    Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
    '
    'DockPanel1_Container
    '
    Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
    Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
    Me.DockPanel1_Container.Name = "DockPanel1_Container"
    Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 423)
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
    Me.NavBarControl1.Size = New System.Drawing.Size(242, 423)
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
    Me.lytTransaksi.Controls.Add(Me.txtProyek)
    Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
    Me.lytTransaksi.Controls.Add(Me.txtCustom4)
    Me.lytTransaksi.Controls.Add(Me.txtCustom5)
    Me.lytTransaksi.Controls.Add(Me.txtCustom3)
    Me.lytTransaksi.Controls.Add(Me.txtCustom2)
    Me.lytTransaksi.Controls.Add(Me.txtCustom1)
    Me.lytTransaksi.Controls.Add(Me.txtNoRef)
    Me.lytTransaksi.Controls.Add(Me.txtTotal)
    Me.lytTransaksi.Controls.Add(Me.txtPPH)
    Me.lytTransaksi.Controls.Add(Me.txtPPN)
    Me.lytTransaksi.Controls.Add(Me.txtSubTotal)
    Me.lytTransaksi.Controls.Add(Me.txtStatus)
    Me.lytTransaksi.Controls.Add(Me.txtPajak)
    Me.lytTransaksi.Controls.Add(Me.txtUang)
    Me.lytTransaksi.Controls.Add(Me.txtKontakPerson)
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.xGrid)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.txtCatatan)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.txtKaryawan)
    Me.lytTransaksi.Controls.Add(Me.txtAlamatText)
    Me.lytTransaksi.Controls.Add(Me.txtAlamat)
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
    'lblKontakNama
    '
    Me.lblKontakNama.Location = New System.Drawing.Point(314, 37)
    Me.lblKontakNama.Name = "lblKontakNama"
    Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
    Me.lblKontakNama.StyleController = Me.lytTransaksi
    Me.lblKontakNama.TabIndex = 30
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
    'txtNoRef
    '
    Me.txtNoRef.Location = New System.Drawing.Point(455, 106)
    Me.txtNoRef.MenuManager = Me.barMan
    Me.txtNoRef.Name = "txtNoRef"
    Me.txtNoRef.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoRef.Size = New System.Drawing.Size(289, 20)
    Me.txtNoRef.StyleController = Me.lytTransaksi
    Me.txtNoRef.TabIndex = 13
    '
    'txtTotal
    '
    Me.txtTotal.Location = New System.Drawing.Point(964, 391)
    Me.txtTotal.MenuManager = Me.barMan
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTotal.Properties.Mask.EditMask = "n2"
    Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtTotal.Properties.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(140, 20)
    Me.txtTotal.StyleController = Me.lytTransaksi
    Me.txtTotal.TabIndex = 24
    '
    'txtPPH
    '
    Me.txtPPH.Location = New System.Drawing.Point(964, 367)
    Me.txtPPH.MenuManager = Me.barMan
    Me.txtPPH.Name = "txtPPH"
    Me.txtPPH.Properties.Appearance.Options.UseTextOptions = True
    Me.txtPPH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtPPH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPPH.Properties.Mask.EditMask = "n2"
    Me.txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPH.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPH.Properties.ReadOnly = True
    Me.txtPPH.Size = New System.Drawing.Size(140, 20)
    Me.txtPPH.StyleController = Me.lytTransaksi
    Me.txtPPH.TabIndex = 23
    '
    'txtPPN
    '
    Me.txtPPN.Location = New System.Drawing.Point(964, 343)
    Me.txtPPN.MenuManager = Me.barMan
    Me.txtPPN.Name = "txtPPN"
    Me.txtPPN.Properties.Appearance.Options.UseTextOptions = True
    Me.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtPPN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPPN.Properties.Mask.EditMask = "n2"
    Me.txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPN.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPN.Properties.ReadOnly = True
    Me.txtPPN.Size = New System.Drawing.Size(140, 20)
    Me.txtPPN.StyleController = Me.lytTransaksi
    Me.txtPPN.TabIndex = 22
    '
    'txtSubTotal
    '
    Me.txtSubTotal.Location = New System.Drawing.Point(964, 319)
    Me.txtSubTotal.MenuManager = Me.barMan
    Me.txtSubTotal.Name = "txtSubTotal"
    Me.txtSubTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtSubTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtSubTotal.Properties.Mask.EditMask = "n2"
    Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtSubTotal.Properties.ReadOnly = True
    Me.txtSubTotal.Size = New System.Drawing.Size(140, 20)
    Me.txtSubTotal.StyleController = Me.lytTransaksi
    Me.txtSubTotal.TabIndex = 21
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(960, 61)
    Me.txtStatus.MenuManager = Me.barMan
    Me.txtStatus.Name = "txtStatus"
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
    'txtPajak
    '
    Me.txtPajak.Location = New System.Drawing.Point(455, 130)
    Me.txtPajak.MenuManager = Me.barMan
    Me.txtPajak.Name = "txtPajak"
    Me.txtPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPajak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPajak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtPajak.Properties.DisplayMember = "Value"
    Me.txtPajak.Properties.NullText = "<Pilih Tipe Pajak>"
    Me.txtPajak.Properties.PopupWidth = 20
    Me.txtPajak.Properties.ValueMember = "Key"
    Me.txtPajak.Size = New System.Drawing.Size(127, 20)
    Me.txtPajak.StyleController = Me.lytTransaksi
    Me.txtPajak.TabIndex = 11
    '
    'txtUang
    '
    Me.txtUang.Location = New System.Drawing.Point(648, 130)
    Me.txtUang.MenuManager = Me.barMan
    Me.txtUang.Name = "txtUang"
    Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtUang.Properties.DisplayMember = "Kode"
    Me.txtUang.Properties.NullText = "<Uang>"
    Me.txtUang.Properties.PopupWidth = 40
    Me.txtUang.Properties.ValueMember = "This"
    Me.txtUang.Size = New System.Drawing.Size(95, 20)
    Me.txtUang.StyleController = Me.lytTransaksi
    Me.txtUang.TabIndex = 10
    '
    'txtKontakPerson
    '
    Me.txtKontakPerson.Location = New System.Drawing.Point(92, 61)
    Me.txtKontakPerson.MenuManager = Me.barMan
    Me.txtKontakPerson.Name = "txtKontakPerson"
    Me.txtKontakPerson.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontakPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontakPerson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 30, "Nama")})
    Me.txtKontakPerson.Properties.DisplayMember = "Nama"
    Me.txtKontakPerson.Properties.NullText = "<Pilih Kontak Person>"
    Me.txtKontakPerson.Properties.PopupWidth = 30
    Me.txtKontakPerson.Properties.ValueMember = "Nama"
    Me.txtKontakPerson.Size = New System.Drawing.Size(218, 20)
    Me.txtKontakPerson.StyleController = Me.lytTransaksi
    Me.txtKontakPerson.TabIndex = 4
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(773, 61)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
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
    Me.txtTanggal.Location = New System.Drawing.Point(773, 37)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
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
    Me.btnRefreshNomor.Location = New System.Drawing.Point(1084, 37)
    Me.btnRefreshNomor.Name = "btnRefreshNomor"
    Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
    Me.btnRefreshNomor.StyleController = Me.lytTransaksi
    Me.btnRefreshNomor.TabIndex = 3
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(960, 37)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Size = New System.Drawing.Size(120, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksi
    Me.txtNoTransaksi.TabIndex = 2
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 178)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSatuanRepo, Me.colDivisiRepo, Me.colProyekRepo, Me.colHargaRepo, Me.colKodeBarangRepo})
    Me.xGrid.Size = New System.Drawing.Size(1104, 125)
    Me.xGrid.TabIndex = 18
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colHarga, Me.colPPN, Me.colPPH, Me.colTotal, Me.colCatatan, Me.colDivisi, Me.colProyek, Me.colDiscount, Me.colDiscountPersen, Me.colDPP, Me.colPPHp, Me.colPPHv, Me.colPPNp, Me.colPPNv, Me.colSubTotal})
    Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(750, 426, 210, 172)
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsLayout.StoreAllOptions = True
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
    Me.colKodeBarang.Width = 92
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
    Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
    Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
    Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.FindDelay = 500
    Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.SearchInPreview = True
    Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.RepositoryItemSearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode"
    Me.GridColumn3.FieldName = "Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    Me.GridColumn3.Width = 355
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Nama"
    Me.GridColumn4.FieldName = "Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    Me.GridColumn4.Width = 723
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
    Me.colNamaBarang.Width = 152
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
    Me.colQty.Width = 57
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
    Me.colSatuan.Width = 70
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
    'colHarga
    '
    Me.colHarga.Caption = "Harga"
    Me.colHarga.ColumnEdit = Me.colHargaRepo
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    Me.colHarga.Visible = True
    Me.colHarga.VisibleIndex = 4
    Me.colHarga.Width = 80
    '
    'colHargaRepo
    '
    Me.colHargaRepo.AutoHeight = False
    Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colHargaRepo.Name = "colHargaRepo"
    '
    'colPPN
    '
    Me.colPPN.Caption = "Pajak IN"
    Me.colPPN.FieldName = "PPN.Kode"
    Me.colPPN.Name = "colPPN"
    Me.colPPN.OptionsColumn.AllowEdit = False
    Me.colPPN.OptionsColumn.ReadOnly = True
    Me.colPPN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPNv", "")})
    Me.colPPN.Visible = True
    Me.colPPN.VisibleIndex = 5
    Me.colPPN.Width = 57
    '
    'colPPH
    '
    Me.colPPH.Caption = "Pajak Out"
    Me.colPPH.FieldName = "PPH.Kode"
    Me.colPPH.Name = "colPPH"
    Me.colPPH.OptionsColumn.AllowEdit = False
    Me.colPPH.OptionsColumn.ReadOnly = True
    Me.colPPH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPHv", "")})
    Me.colPPH.Visible = True
    Me.colPPH.VisibleIndex = 6
    Me.colPPH.Width = 57
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total"
    Me.colTotal.FieldName = "Total"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.OptionsColumn.AllowEdit = False
    Me.colTotal.OptionsColumn.ReadOnly = True
    Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 7
    Me.colTotal.Width = 84
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
    Me.colCatatan.VisibleIndex = 8
    Me.colCatatan.Width = 204
    '
    'colDivisi
    '
    Me.colDivisi.Caption = "Divisi"
    Me.colDivisi.ColumnEdit = Me.colDivisiRepo
    Me.colDivisi.FieldName = "Divisi!"
    Me.colDivisi.Name = "colDivisi"
    Me.colDivisi.Visible = True
    Me.colDivisi.VisibleIndex = 9
    Me.colDivisi.Width = 82
    '
    'colDivisiRepo
    '
    Me.colDivisiRepo.AutoHeight = False
    Me.colDivisiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colDivisiRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colDivisiRepo.DisplayMember = "Kode"
    Me.colDivisiRepo.Name = "colDivisiRepo"
    Me.colDivisiRepo.NullText = "<Divisi>"
    Me.colDivisiRepo.ValueMember = "This"
    '
    'colProyek
    '
    Me.colProyek.Caption = "Proyek"
    Me.colProyek.ColumnEdit = Me.colProyekRepo
    Me.colProyek.FieldName = "Proyek!"
    Me.colProyek.Name = "colProyek"
    Me.colProyek.Visible = True
    Me.colProyek.VisibleIndex = 10
    '
    'colProyekRepo
    '
    Me.colProyekRepo.AutoHeight = False
    Me.colProyekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colProyekRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.colProyekRepo.DisplayMember = "Kode"
    Me.colProyekRepo.Name = "colProyekRepo"
    Me.colProyekRepo.NullText = "<Proyek>"
    Me.colProyekRepo.ValueMember = "This"
    '
    'colDiscount
    '
    Me.colDiscount.Caption = "Disc"
    Me.colDiscount.FieldName = "Discount"
    Me.colDiscount.Name = "colDiscount"
    '
    'colDiscountPersen
    '
    Me.colDiscountPersen.Caption = "Disc. %"
    Me.colDiscountPersen.FieldName = "DiscountPersen"
    Me.colDiscountPersen.Name = "colDiscountPersen"
    '
    'colDPP
    '
    Me.colDPP.Caption = "DPP"
    Me.colDPP.FieldName = "DPP"
    Me.colDPP.Name = "colDPP"
    Me.colDPP.OptionsColumn.AllowEdit = False
    Me.colDPP.OptionsColumn.ReadOnly = True
    '
    'colPPHp
    '
    Me.colPPHp.Caption = "PPH %"
    Me.colPPHp.FieldName = "PPHp"
    Me.colPPHp.Name = "colPPHp"
    Me.colPPHp.OptionsColumn.AllowEdit = False
    Me.colPPHp.OptionsColumn.ReadOnly = True
    '
    'colPPHv
    '
    Me.colPPHv.Caption = "PPH Value"
    Me.colPPHv.FieldName = "PPHv"
    Me.colPPHv.Name = "colPPHv"
    Me.colPPHv.OptionsColumn.AllowEdit = False
    Me.colPPHv.OptionsColumn.ReadOnly = True
    '
    'colPPNp
    '
    Me.colPPNp.Caption = "PPN %"
    Me.colPPNp.FieldName = "PPNp"
    Me.colPPNp.Name = "colPPNp"
    Me.colPPNp.OptionsColumn.AllowEdit = False
    Me.colPPNp.OptionsColumn.ReadOnly = True
    '
    'colPPNv
    '
    Me.colPPNv.Caption = "PPN Value"
    Me.colPPNv.FieldName = "PPNv"
    Me.colPPNv.Name = "colPPNv"
    Me.colPPNv.OptionsColumn.AllowEdit = False
    Me.colPPNv.OptionsColumn.ReadOnly = True
    '
    'colSubTotal
    '
    Me.colSubTotal.Caption = "Sub Total"
    Me.colSubTotal.FieldName = "SubTotal"
    Me.colSubTotal.Name = "colSubTotal"
    Me.colSubTotal.OptionsColumn.AllowEdit = False
    Me.colSubTotal.OptionsColumn.ReadOnly = True
    Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(455, 154)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(571, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 17
    '
    'txtCatatan
    '
    Me.txtCatatan.Location = New System.Drawing.Point(296, 307)
    Me.txtCatatan.MenuManager = Me.barMan
    Me.txtCatatan.Name = "txtCatatan"
    Me.txtCatatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCatatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCatatan.Size = New System.Drawing.Size(191, 20)
    Me.txtCatatan.StyleController = Me.lytTransaksi
    Me.txtCatatan.TabIndex = 20
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
    Me.txtKontak.Size = New System.Drawing.Size(218, 20)
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
    Me.txtKaryawan.Location = New System.Drawing.Point(94, 307)
    Me.txtKaryawan.MenuManager = Me.barMan
    Me.txtKaryawan.Name = "txtKaryawan"
    Me.txtKaryawan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKaryawan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKaryawan.Properties.DisplayMember = "Nama"
    Me.txtKaryawan.Properties.NullText = "<Pilih Karyawan>"
    Me.txtKaryawan.Properties.PopupFormSize = New System.Drawing.Size(200, 0)
    Me.txtKaryawan.Properties.ShowClearButton = False
    Me.txtKaryawan.Properties.ShowFooter = False
    Me.txtKaryawan.Properties.ValueMember = "This"
    Me.txtKaryawan.Properties.View = Me.GridView1
    Me.txtKaryawan.Size = New System.Drawing.Size(116, 20)
    Me.txtKaryawan.StyleController = Me.lytTransaksi
    Me.txtKaryawan.TabIndex = 26
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
    'txtAlamatText
    '
    Me.txtAlamatText.Location = New System.Drawing.Point(17, 130)
    Me.txtAlamatText.MenuManager = Me.barMan
    Me.txtAlamatText.Name = "txtAlamatText"
    Me.txtAlamatText.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
    Me.txtAlamatText.Properties.AppearanceReadOnly.Options.UseBackColor = True
    Me.txtAlamatText.Properties.ReadOnly = True
    Me.txtAlamatText.Size = New System.Drawing.Size(252, 44)
    Me.txtAlamatText.StyleController = Me.lytTransaksi
    Me.txtAlamatText.TabIndex = 12
    '
    'txtAlamat
    '
    Me.txtAlamat.Location = New System.Drawing.Point(92, 106)
    Me.txtAlamat.MenuManager = Me.barMan
    Me.txtAlamat.Name = "txtAlamat"
    Me.txtAlamat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAlamat.Properties.DisplayMember = "Kode"
    Me.txtAlamat.Properties.NullText = ""
    Me.txtAlamat.Properties.ValueMember = "This"
    Me.txtAlamat.Properties.View = Me.GridView2
    Me.txtAlamat.Size = New System.Drawing.Size(177, 20)
    Me.txtAlamat.StyleController = Me.lytTransaksi
    Me.txtAlamat.TabIndex = 7
    '
    'GridView2
    '
    Me.GridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
    Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsFind.FindDelay = 500
    Me.GridView2.OptionsFind.SearchInPreview = True
    Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView2.OptionsView.ShowGroupPanel = False
    Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn5
    '
    Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridColumn5.Caption = "Kode"
    Me.GridColumn5.FieldName = "Kode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 0
    Me.GridColumn5.Width = 355
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Alamat"
    Me.GridColumn6.FieldName = "Alamat"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 1
    Me.GridColumn6.Width = 723
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
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlGroup2, Me.LayoutControlItem22, Me.EmptySpaceItem17, Me.LayoutControlGroup3, Me.LayoutControlItem3, Me.LayoutControlItem11, Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlItem8, Me.LayoutControlItem21, Me.LayoutControlItem10, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGrid
    Me.LayoutControlItem7.CustomizationFormText = "Detail"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 166)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(1108, 129)
    Me.LayoutControlItem7.Text = "Detail"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(261, 94)
    Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(104, 24)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(104, 72)
    Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem13, Me.LayoutControlItem19, Me.LayoutControlItem20})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(865, 295)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(243, 120)
    Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
    Me.LayoutControlGroup2.TextVisible = False
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtSubTotal
    Me.LayoutControlItem6.CustomizationFormText = "Sub Total"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem6.Text = "Sub Total"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtPPN
    Me.LayoutControlItem13.CustomizationFormText = "PPN"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem13.Text = "PPN"
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.txtPPH
    Me.LayoutControlItem19.CustomizationFormText = "PPH"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem19.Text = "PPH"
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem20
    '
    Me.LayoutControlItem20.Control = Me.txtTotal
    Me.LayoutControlItem20.CustomizationFormText = "Total Transaksi"
    Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem20.Name = "LayoutControlItem20"
    Me.LayoutControlItem20.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem20.Text = "Total Transaksi"
    Me.LayoutControlItem20.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem22
    '
    Me.LayoutControlItem22.Control = Me.txtCatatan
    Me.LayoutControlItem22.CustomizationFormText = "Catatan"
    Me.LayoutControlItem22.Location = New System.Drawing.Point(202, 295)
    Me.LayoutControlItem22.Name = "LayoutControlItem22"
    Me.LayoutControlItem22.Size = New System.Drawing.Size(277, 120)
    Me.LayoutControlItem22.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem22.Text = "Catatan"
    Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem22.TextSize = New System.Drawing.Size(72, 13)
    Me.LayoutControlItem22.TextToControlDistance = 5
    '
    'EmptySpaceItem17
    '
    Me.EmptySpaceItem17.AllowHotTrack = False
    Me.EmptySpaceItem17.CustomizationFormText = "EmptySpaceItem17"
    Me.EmptySpaceItem17.Location = New System.Drawing.Point(479, 295)
    Me.EmptySpaceItem17.Name = "EmptySpaceItem17"
    Me.EmptySpaceItem17.Size = New System.Drawing.Size(386, 120)
    Me.EmptySpaceItem17.Text = "EmptySpaceItem17"
    Me.EmptySpaceItem17.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.lytRegional, Me.LayoutControlItem1, Me.LayoutControlItem14, Me.EmptySpaceItem6, Me.LayoutControlItem28, Me.EmptySpaceItem2})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(1108, 94)
    Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
    Me.LayoutControlGroup3.Text = "Info Utama"
    '
    'layKontak
    '
    Me.layKontak.Control = Me.txtKontak
    Me.layKontak.CustomizationFormText = "Vendor"
    Me.layKontak.Location = New System.Drawing.Point(0, 0)
    Me.layKontak.Name = "layKontak"
    Me.layKontak.Size = New System.Drawing.Size(296, 24)
    Me.layKontak.Text = "Customer   "
    Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.layKontak.TextSize = New System.Drawing.Size(69, 13)
    Me.layKontak.TextToControlDistance = 5
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(707, 0)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(172, 24)
    Me.LayoutControlItem15.Text = "Tanggal   "
    Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem15.TextToControlDistance = 5
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtNoTransaksi
    Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(879, 0)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(187, 24)
    Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem16.Text = "No. Bukti   "
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
    'lytRegional
    '
    Me.lytRegional.Control = Me.txtRegional
    Me.lytRegional.CustomizationFormText = "Regional"
    Me.lytRegional.Location = New System.Drawing.Point(707, 24)
    Me.lytRegional.Name = "lytRegional"
    Me.lytRegional.Size = New System.Drawing.Size(172, 24)
    Me.lytRegional.Text = "Regional"
    Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.lytRegional.TextSize = New System.Drawing.Size(43, 13)
    Me.lytRegional.TextToControlDistance = 5
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKontakPerson
    Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(296, 24)
    Me.LayoutControlItem1.Text = "Kontak Person   "
    Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem1.TextToControlDistance = 5
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtStatus
    Me.LayoutControlItem14.CustomizationFormText = "Status"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(879, 24)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(187, 24)
    Me.LayoutControlItem14.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem14.Text = "Status   "
    Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem14.TextToControlDistance = 5
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(512, 0)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(195, 48)
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem28
    '
    Me.LayoutControlItem28.Control = Me.lblKontakNama
    Me.LayoutControlItem28.CustomizationFormText = "NamaKontak"
    Me.LayoutControlItem28.Location = New System.Drawing.Point(296, 0)
    Me.LayoutControlItem28.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem28.Name = "LayoutControlItem28"
    Me.LayoutControlItem28.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem28.Text = "NamaKontak"
    Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem28.TextToControlDistance = 0
    Me.LayoutControlItem28.TextVisible = False
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(296, 24)
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
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(365, 142)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(653, 24)
    Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtKaryawan
    Me.LayoutControlItem11.CustomizationFormText = "Bag Pembelian"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 295)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(202, 120)
    Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem11.Text = "Bag Penjualan"
    Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(72, 13)
    Me.LayoutControlItem11.TextToControlDistance = 5
    '
    'LayoutControlItem29
    '
    Me.LayoutControlItem29.Control = Me.txtAlamat
    Me.LayoutControlItem29.CustomizationFormText = "Alamat"
    Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 94)
    Me.LayoutControlItem29.Name = "LayoutControlItem29"
    Me.LayoutControlItem29.Size = New System.Drawing.Size(261, 24)
    Me.LayoutControlItem29.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem29.Text = "Alamat"
    Me.LayoutControlItem29.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem30
    '
    Me.LayoutControlItem30.Control = Me.txtAlamatText
    Me.LayoutControlItem30.CustomizationFormText = "AlamatText"
    Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 118)
    Me.LayoutControlItem30.Name = "LayoutControlItem30"
    Me.LayoutControlItem30.Size = New System.Drawing.Size(261, 48)
    Me.LayoutControlItem30.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem30.Text = "AlamatText"
    Me.LayoutControlItem30.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem30.TextToControlDistance = 0
    Me.LayoutControlItem30.TextVisible = False
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtUang
    Me.LayoutControlItem8.CustomizationFormText = "Uang"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(574, 118)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(161, 24)
    Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem8.Text = "Uang"
    Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(52, 13)
    Me.LayoutControlItem8.TextToControlDistance = 5
    '
    'LayoutControlItem21
    '
    Me.LayoutControlItem21.Control = Me.txtNoRef
    Me.LayoutControlItem21.CustomizationFormText = "Reff Number"
    Me.LayoutControlItem21.Location = New System.Drawing.Point(365, 94)
    Me.LayoutControlItem21.Name = "LayoutControlItem21"
    Me.LayoutControlItem21.Size = New System.Drawing.Size(371, 24)
    Me.LayoutControlItem21.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem21.Text = "Reff Number"
    Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem21.TextSize = New System.Drawing.Size(68, 13)
    Me.LayoutControlItem21.TextToControlDistance = 5
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtPajak
    Me.LayoutControlItem10.CustomizationFormText = "Pajak"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(365, 118)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(209, 24)
    Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem10.Text = "Pajak"
    Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(68, 13)
    Me.LayoutControlItem10.TextToControlDistance = 5
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(736, 94)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(372, 24)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(949, 118)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(159, 24)
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(1018, 142)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(90, 24)
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
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
    'txtProyek
    '
    Me.txtProyek.Location = New System.Drawing.Point(809, 130)
    Me.txtProyek.MenuManager = Me.barMan
    Me.txtProyek.Name = "txtProyek"
    Me.txtProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtProyek.Properties.DisplayMember = "Kode"
    Me.txtProyek.Properties.NullText = "<Pilih Proyek>"
    Me.txtProyek.Properties.ValueMember = "This"
    Me.txtProyek.Size = New System.Drawing.Size(148, 20)
    Me.txtProyek.StyleController = Me.lytTransaksi
    Me.txtProyek.TabIndex = 31
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtProyek
    Me.LayoutControlItem2.CustomizationFormText = "Proyek"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(735, 118)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(214, 24)
    Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem2.Text = "Proyek"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'zWoojinUI_OrderPenjualanDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1134, 468)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "zWoojinUI_OrderPenjualanDialog"
    Me.Text = "Sales Order"
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
    CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colProyekRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAlamatText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
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
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtKontakPerson As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
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
  Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPajak As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPH As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDivisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDivisiRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPPH As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPPN As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtCatatan As DevExpress.XtraEditors.MemoExEdit
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colProyek As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colProyekRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDiscountPersen As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDPP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPHp As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPHv As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPNp As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPNv As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
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
  Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents colHargaRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
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
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtAlamatText As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtAlamat As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
