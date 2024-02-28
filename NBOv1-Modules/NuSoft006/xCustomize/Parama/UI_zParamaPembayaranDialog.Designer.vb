<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_zParamaPembayaranDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_zParamaPembayaranDialog))
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
    Me.txtCreditLimit = New DevExpress.XtraEditors.LabelControl()
    Me.txtSaldoAP = New DevExpress.XtraEditors.LabelControl()
    Me.txtSaldoAR = New DevExpress.XtraEditors.LabelControl()
    Me.txtPhoneNumber = New DevExpress.XtraEditors.LabelControl()
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
    Me.txtWapuKurs = New DevExpress.XtraEditors.TextEdit()
    Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colOK = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTgl = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTerbayar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKursInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJumlahBayar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSisa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.lbTotal = New DevExpress.XtraEditors.LabelControl()
    Me.txtNoPPH = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiValas = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiKas = New DevExpress.XtraEditors.TextEdit()
    Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
    Me.txtKurs = New DevExpress.XtraEditors.TextEdit()
    Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
    Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
    Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
    Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCaraBayar = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.chkPajak = New DevExpress.XtraEditors.CheckEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtAkun = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNilaiPembulatan = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiAdministrasi = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiPPH = New DevExpress.XtraEditors.TextEdit()
    Me.txtPPNWapu = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiPendapatan = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.layCaraBayarDetail = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layJatuhTempo = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.layCaraBayar = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.layAkunKasBankNama = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
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
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksi.SuspendLayout()
    CType(Me.txtWapuKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiValas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiKas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCaraBayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiPembulatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiAdministrasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiPPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPPNWapu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiPendapatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layCaraBayarDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layJatuhTempo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layCaraBayar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layAkunKasBankNama, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.btnRefresh})
    Me.barMan.MaxItemId = 9
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtCreditLimit)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtSaldoAP)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtSaldoAR)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtPhoneNumber)
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
    'txtCreditLimit
    '
    Me.txtCreditLimit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCreditLimit.Location = New System.Drawing.Point(97, 66)
    Me.txtCreditLimit.Name = "txtCreditLimit"
    Me.txtCreditLimit.Size = New System.Drawing.Size(7, 13)
    Me.txtCreditLimit.TabIndex = 3
    Me.txtCreditLimit.Text = "0"
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
    'txtSaldoAR
    '
    Me.txtSaldoAR.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSaldoAR.Location = New System.Drawing.Point(97, 28)
    Me.txtSaldoAR.Name = "txtSaldoAR"
    Me.txtSaldoAR.Size = New System.Drawing.Size(7, 13)
    Me.txtSaldoAR.TabIndex = 1
    Me.txtSaldoAR.Text = "0"
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
    Me.lytTransaksi.Controls.Add(Me.txtWapuKurs)
    Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
    Me.lytTransaksi.Controls.Add(Me.xGrid)
    Me.lytTransaksi.Controls.Add(Me.lbTotal)
    Me.lytTransaksi.Controls.Add(Me.txtNoPPH)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiValas)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiKas)
    Me.lytTransaksi.Controls.Add(Me.TextEdit4)
    Me.lytTransaksi.Controls.Add(Me.txtKurs)
    Me.lytTransaksi.Controls.Add(Me.txtUang)
    Me.lytTransaksi.Controls.Add(Me.DateEdit1)
    Me.lytTransaksi.Controls.Add(Me.TextEdit3)
    Me.lytTransaksi.Controls.Add(Me.TextEdit2)
    Me.lytTransaksi.Controls.Add(Me.TextEdit1)
    Me.lytTransaksi.Controls.Add(Me.txtCaraBayar)
    Me.lytTransaksi.Controls.Add(Me.txtStatus)
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.chkPajak)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.txtAkun)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiPembulatan)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiAdministrasi)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiPPH)
    Me.lytTransaksi.Controls.Add(Me.txtPPNWapu)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiPendapatan)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(262, 446, 288, 350)
    Me.lytTransaksi.Root = Me.LayoutControlGroup1
    Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
    Me.lytTransaksi.TabIndex = 0
    Me.lytTransaksi.Text = "LayoutControl1"
    '
    'txtWapuKurs
    '
    Me.txtWapuKurs.Location = New System.Drawing.Point(736, 207)
    Me.txtWapuKurs.MenuManager = Me.barMan
    Me.txtWapuKurs.Name = "txtWapuKurs"
    Me.txtWapuKurs.Properties.Appearance.Options.UseTextOptions = True
    Me.txtWapuKurs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtWapuKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtWapuKurs.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtWapuKurs.Size = New System.Drawing.Size(120, 20)
    Me.txtWapuKurs.StyleController = Me.lytTransaksi
    Me.txtWapuKurs.TabIndex = 17
    '
    'lblKontakNama
    '
    Me.lblKontakNama.Location = New System.Drawing.Point(233, 37)
    Me.lblKontakNama.Name = "lblKontakNama"
    Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
    Me.lblKontakNama.StyleController = Me.lytTransaksi
    Me.lblKontakNama.TabIndex = 26
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 333)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(1104, 85)
    Me.xGrid.TabIndex = 26
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOK, Me.colInvoice, Me.colTgl, Me.colUraian, Me.colUang, Me.colTotal, Me.colTerbayar, Me.colKursInvoice, Me.colJumlahBayar, Me.colKurs, Me.colCatatan, Me.colSisa})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsFilter.AllowColumnMRUFilterList = False
    Me.xGridView.OptionsFilter.AllowFilterEditor = False
    Me.xGridView.OptionsFilter.AllowFilterIncrementalSearch = False
    Me.xGridView.OptionsFilter.AllowMRUFilterList = False
    Me.xGridView.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = False
    Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
    Me.xGridView.OptionsView.ShowGroupPanel = False
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTgl, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colOK
    '
    Me.colOK.AppearanceCell.Options.UseTextOptions = True
    Me.colOK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colOK.AppearanceHeader.Options.UseTextOptions = True
    Me.colOK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colOK.Caption = "X"
    Me.colOK.FieldName = "OK"
    Me.colOK.Name = "colOK"
    Me.colOK.OptionsColumn.AllowEdit = False
    Me.colOK.OptionsColumn.FixedWidth = True
    Me.colOK.OptionsColumn.ReadOnly = True
    Me.colOK.Visible = True
    Me.colOK.VisibleIndex = 0
    Me.colOK.Width = 24
    '
    'colInvoice
    '
    Me.colInvoice.Caption = "No Invoice"
    Me.colInvoice.FieldName = "NoInvoice.Kode"
    Me.colInvoice.Name = "colInvoice"
    Me.colInvoice.OptionsColumn.AllowEdit = False
    Me.colInvoice.OptionsColumn.ReadOnly = True
    Me.colInvoice.Visible = True
    Me.colInvoice.VisibleIndex = 1
    Me.colInvoice.Width = 115
    '
    'colTgl
    '
    Me.colTgl.Caption = "Tanggal"
    Me.colTgl.FieldName = "NoInvoice.Tanggal"
    Me.colTgl.Name = "colTgl"
    Me.colTgl.OptionsColumn.AllowEdit = False
    Me.colTgl.OptionsColumn.ReadOnly = True
    Me.colTgl.Visible = True
    Me.colTgl.VisibleIndex = 2
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "NoInvoice.Catatan"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 3
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.FieldName = "NoInvoice.Uang.Kode"
    Me.colUang.Name = "colUang"
    Me.colUang.OptionsColumn.AllowEdit = False
    Me.colUang.OptionsColumn.ReadOnly = True
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 5
    Me.colUang.Width = 115
    '
    'colTotal
    '
    Me.colTotal.Caption = "Nilai Invoice"
    Me.colTotal.FieldName = "NoInvoice.NilaiInvoice"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.OptionsColumn.AllowEdit = False
    Me.colTotal.OptionsColumn.ReadOnly = True
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 4
    Me.colTotal.Width = 115
    '
    'colTerbayar
    '
    Me.colTerbayar.Caption = "Terbayar"
    Me.colTerbayar.FieldName = "Terbayar"
    Me.colTerbayar.Name = "colTerbayar"
    Me.colTerbayar.OptionsColumn.AllowEdit = False
    Me.colTerbayar.OptionsColumn.ReadOnly = True
    Me.colTerbayar.Visible = True
    Me.colTerbayar.VisibleIndex = 6
    Me.colTerbayar.Width = 115
    '
    'colKursInvoice
    '
    Me.colKursInvoice.Caption = "Kurs Invoice"
    Me.colKursInvoice.FieldName = "NoInvoice.Kurs"
    Me.colKursInvoice.Name = "colKursInvoice"
    Me.colKursInvoice.OptionsColumn.AllowEdit = False
    Me.colKursInvoice.OptionsColumn.ReadOnly = True
    Me.colKursInvoice.Visible = True
    Me.colKursInvoice.VisibleIndex = 7
    Me.colKursInvoice.Width = 115
    '
    'colJumlahBayar
    '
    Me.colJumlahBayar.Caption = "Nilai Bayar"
    Me.colJumlahBayar.FieldName = "NilaiBayarCash"
    Me.colJumlahBayar.Name = "colJumlahBayar"
    Me.colJumlahBayar.Visible = True
    Me.colJumlahBayar.VisibleIndex = 8
    Me.colJumlahBayar.Width = 115
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs Bayar"
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 9
    Me.colKurs.Width = 115
    '
    'colCatatan
    '
    Me.colCatatan.Caption = "Catatan"
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 10
    Me.colCatatan.Width = 117
    '
    'colSisa
    '
    Me.colSisa.Caption = "SisaInvoice"
    Me.colSisa.FieldName = "ColSisa"
    Me.colSisa.Name = "colSisa"
    Me.colSisa.OptionsColumn.AllowEdit = False
    Me.colSisa.OptionsColumn.ReadOnly = True
    Me.colSisa.UnboundExpression = "NoInvoice.NilaiInvoice-Terbayar"
    Me.colSisa.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    '
    'lbTotal
    '
    Me.lbTotal.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.lbTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.lbTotal.Location = New System.Drawing.Point(860, 135)
    Me.lbTotal.Name = "lbTotal"
    Me.lbTotal.Size = New System.Drawing.Size(231, 92)
    Me.lbTotal.StyleController = Me.lytTransaksi
    Me.lbTotal.TabIndex = 25
    Me.lbTotal.Text = "Total : Rp. 0"
    '
    'txtNoPPH
    '
    Me.txtNoPPH.Location = New System.Drawing.Point(180, 170)
    Me.txtNoPPH.MenuManager = Me.barMan
    Me.txtNoPPH.Name = "txtNoPPH"
    Me.txtNoPPH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoPPH.Size = New System.Drawing.Size(63, 20)
    Me.txtNoPPH.StyleController = Me.lytTransaksi
    Me.txtNoPPH.TabIndex = 18
    '
    'txtNilaiValas
    '
    Me.txtNilaiValas.Location = New System.Drawing.Point(517, 135)
    Me.txtNilaiValas.MenuManager = Me.barMan
    Me.txtNilaiValas.Name = "txtNilaiValas"
    Me.txtNilaiValas.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilaiValas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilaiValas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilaiValas.Properties.Mask.EditMask = "n"
    Me.txtNilaiValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilaiValas.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilaiValas.Properties.ReadOnly = True
    Me.txtNilaiValas.Size = New System.Drawing.Size(120, 20)
    Me.txtNilaiValas.StyleController = Me.lytTransaksi
    Me.txtNilaiValas.TabIndex = 9
    '
    'txtNilaiKas
    '
    Me.txtNilaiKas.Location = New System.Drawing.Point(298, 183)
    Me.txtNilaiKas.MenuManager = Me.barMan
    Me.txtNilaiKas.Name = "txtNilaiKas"
    Me.txtNilaiKas.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilaiKas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilaiKas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilaiKas.Properties.Mask.EditMask = "n"
    Me.txtNilaiKas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilaiKas.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilaiKas.Properties.ReadOnly = True
    Me.txtNilaiKas.Size = New System.Drawing.Size(120, 20)
    Me.txtNilaiKas.StyleController = Me.lytTransaksi
    Me.txtNilaiKas.TabIndex = 14
    '
    'TextEdit4
    '
    Me.TextEdit4.Location = New System.Drawing.Point(511, 273)
    Me.TextEdit4.MenuManager = Me.barMan
    Me.TextEdit4.Name = "TextEdit4"
    Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.TextEdit4.Size = New System.Drawing.Size(120, 20)
    Me.TextEdit4.StyleController = Me.lytTransaksi
    Me.TextEdit4.TabIndex = 24
    '
    'txtKurs
    '
    Me.txtKurs.Location = New System.Drawing.Point(298, 159)
    Me.txtKurs.MenuManager = Me.barMan
    Me.txtKurs.Name = "txtKurs"
    Me.txtKurs.Properties.Appearance.Options.UseTextOptions = True
    Me.txtKurs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtKurs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKurs.Properties.Mask.EditMask = "n"
    Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtKurs.Size = New System.Drawing.Size(120, 20)
    Me.txtKurs.StyleController = Me.lytTransaksi
    Me.txtKurs.TabIndex = 11
    '
    'txtUang
    '
    Me.txtUang.Location = New System.Drawing.Point(298, 135)
    Me.txtUang.MenuManager = Me.barMan
    Me.txtUang.Name = "txtUang"
    Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtUang.Properties.DisplayMember = "Kode"
    Me.txtUang.Properties.NullText = "<Uang>"
    Me.txtUang.Properties.ReadOnly = True
    Me.txtUang.Properties.ValueMember = "This"
    Me.txtUang.Size = New System.Drawing.Size(120, 20)
    Me.txtUang.StyleController = Me.lytTransaksi
    Me.txtUang.TabIndex = 8
    '
    'DateEdit1
    '
    Me.DateEdit1.EditValue = Nothing
    Me.DateEdit1.Location = New System.Drawing.Point(717, 249)
    Me.DateEdit1.MenuManager = Me.barMan
    Me.DateEdit1.Name = "DateEdit1"
    Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.DateEdit1.Size = New System.Drawing.Size(120, 20)
    Me.DateEdit1.StyleController = Me.lytTransaksi
    Me.DateEdit1.TabIndex = 22
    '
    'TextEdit3
    '
    Me.TextEdit3.Location = New System.Drawing.Point(511, 249)
    Me.TextEdit3.MenuManager = Me.barMan
    Me.TextEdit3.Name = "TextEdit3"
    Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.TextEdit3.Size = New System.Drawing.Size(120, 20)
    Me.TextEdit3.StyleController = Me.lytTransaksi
    Me.TextEdit3.TabIndex = 21
    '
    'TextEdit2
    '
    Me.TextEdit2.Location = New System.Drawing.Point(321, 249)
    Me.TextEdit2.MenuManager = Me.barMan
    Me.TextEdit2.Name = "TextEdit2"
    Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.TextEdit2.Size = New System.Drawing.Size(120, 20)
    Me.TextEdit2.StyleController = Me.lytTransaksi
    Me.TextEdit2.TabIndex = 20
    '
    'TextEdit1
    '
    Me.TextEdit1.Location = New System.Drawing.Point(321, 273)
    Me.TextEdit1.MenuManager = Me.barMan
    Me.TextEdit1.Name = "TextEdit1"
    Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.TextEdit1.Size = New System.Drawing.Size(120, 20)
    Me.TextEdit1.StyleController = Me.lytTransaksi
    Me.TextEdit1.TabIndex = 23
    '
    'txtCaraBayar
    '
    Me.txtCaraBayar.Location = New System.Drawing.Point(83, 237)
    Me.txtCaraBayar.MenuManager = Me.barMan
    Me.txtCaraBayar.Name = "txtCaraBayar"
    Me.txtCaraBayar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCaraBayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCaraBayar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtCaraBayar.Properties.DisplayMember = "Key"
    Me.txtCaraBayar.Properties.NullText = "<Cara Bayar>"
    Me.txtCaraBayar.Properties.ValueMember = "Value"
    Me.txtCaraBayar.Size = New System.Drawing.Size(160, 20)
    Me.txtCaraBayar.StyleController = Me.lytTransaksi
    Me.txtCaraBayar.TabIndex = 19
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(960, 61)
    Me.txtStatus.MenuManager = Me.barMan
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Nama")})
    Me.txtStatus.Properties.DisplayMember = "Value"
    Me.txtStatus.Properties.NullText = "<Status>"
    Me.txtStatus.Properties.ReadOnly = True
    Me.txtStatus.Properties.ValueMember = "Key"
    Me.txtStatus.Size = New System.Drawing.Size(120, 20)
    Me.txtStatus.StyleController = Me.lytTransaksi
    Me.txtStatus.TabIndex = 5
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(773, 61)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(120, 20)
    Me.txtRegional.StyleController = Me.lytTransaksi
    Me.txtRegional.TabIndex = 4
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
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(283, 309)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(833, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 25
    '
    'chkPajak
    '
    Me.chkPajak.EditValue = Nothing
    Me.chkPajak.Location = New System.Drawing.Point(12, 106)
    Me.chkPajak.MenuManager = Me.barMan
    Me.chkPajak.Name = "chkPajak"
    Me.chkPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
    Me.chkPajak.Properties.Caption = "Pembayaran Pajak"
    Me.chkPajak.Size = New System.Drawing.Size(1104, 19)
    Me.chkPajak.StyleController = Me.lytTransaksi
    Me.chkPajak.TabIndex = 6
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(69, 37)
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
    'txtAkun
    '
    Me.txtAkun.Location = New System.Drawing.Point(83, 129)
    Me.txtAkun.MenuManager = Me.barMan
    Me.txtAkun.Name = "txtAkun"
    Me.txtAkun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 40, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
    Me.txtAkun.Properties.DisplayMember = "Kode"
    Me.txtAkun.Properties.NullText = "<Pilih Coa>"
    Me.txtAkun.Properties.ValueMember = "This"
    Me.txtAkun.Size = New System.Drawing.Size(160, 20)
    Me.txtAkun.StyleController = Me.lytTransaksi
    Me.txtAkun.TabIndex = 7
    '
    'txtNilaiPembulatan
    '
    Me.txtNilaiPembulatan.Location = New System.Drawing.Point(517, 183)
    Me.txtNilaiPembulatan.MenuManager = Me.barMan
    Me.txtNilaiPembulatan.Name = "txtNilaiPembulatan"
    Me.txtNilaiPembulatan.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilaiPembulatan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilaiPembulatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilaiPembulatan.Properties.Mask.EditMask = "n"
    Me.txtNilaiPembulatan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilaiPembulatan.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilaiPembulatan.Size = New System.Drawing.Size(120, 20)
    Me.txtNilaiPembulatan.StyleController = Me.lytTransaksi
    Me.txtNilaiPembulatan.TabIndex = 15
    '
    'txtNilaiAdministrasi
    '
    Me.txtNilaiAdministrasi.Location = New System.Drawing.Point(517, 159)
    Me.txtNilaiAdministrasi.MenuManager = Me.barMan
    Me.txtNilaiAdministrasi.Name = "txtNilaiAdministrasi"
    Me.txtNilaiAdministrasi.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilaiAdministrasi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilaiAdministrasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilaiAdministrasi.Properties.Mask.EditMask = "n"
    Me.txtNilaiAdministrasi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilaiAdministrasi.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilaiAdministrasi.Size = New System.Drawing.Size(120, 20)
    Me.txtNilaiAdministrasi.StyleController = Me.lytTransaksi
    Me.txtNilaiAdministrasi.TabIndex = 12
    '
    'txtNilaiPPH
    '
    Me.txtNilaiPPH.Location = New System.Drawing.Point(736, 159)
    Me.txtNilaiPPH.MenuManager = Me.barMan
    Me.txtNilaiPPH.Name = "txtNilaiPPH"
    Me.txtNilaiPPH.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilaiPPH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilaiPPH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilaiPPH.Properties.Mask.EditMask = "n2"
    Me.txtNilaiPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilaiPPH.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilaiPPH.Size = New System.Drawing.Size(120, 20)
    Me.txtNilaiPPH.StyleController = Me.lytTransaksi
    Me.txtNilaiPPH.TabIndex = 13
    '
    'txtPPNWapu
    '
    Me.txtPPNWapu.Location = New System.Drawing.Point(736, 183)
    Me.txtPPNWapu.MenuManager = Me.barMan
    Me.txtPPNWapu.Name = "txtPPNWapu"
    Me.txtPPNWapu.Properties.Appearance.Options.UseTextOptions = True
    Me.txtPPNWapu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtPPNWapu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPPNWapu.Properties.Mask.EditMask = "n2"
    Me.txtPPNWapu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPNWapu.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPNWapu.Size = New System.Drawing.Size(120, 20)
    Me.txtPPNWapu.StyleController = Me.lytTransaksi
    Me.txtPPNWapu.TabIndex = 16
    '
    'txtNilaiPendapatan
    '
    Me.txtNilaiPendapatan.Location = New System.Drawing.Point(736, 135)
    Me.txtNilaiPendapatan.MenuManager = Me.barMan
    Me.txtNilaiPendapatan.Name = "txtNilaiPendapatan"
    Me.txtNilaiPendapatan.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilaiPendapatan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilaiPendapatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilaiPendapatan.Properties.Mask.EditMask = "n"
    Me.txtNilaiPendapatan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilaiPendapatan.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilaiPendapatan.Size = New System.Drawing.Size(120, 20)
    Me.txtNilaiPendapatan.StyleController = Me.lytTransaksi
    Me.txtNilaiPendapatan.TabIndex = 10
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem8, Me.layCaraBayarDetail, Me.layCaraBayar, Me.LayoutControlItem11, Me.LayoutControlGroup4, Me.EmptySpaceItem11, Me.layAkunKasBankNama, Me.LayoutControlItem21, Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlItem3, Me.LayoutControlItem8})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'EmptySpaceItem8
    '
    Me.EmptySpaceItem8.AllowHotTrack = False
    Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 410)
    Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Size = New System.Drawing.Size(1108, 5)
    Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
    Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
    '
    'layCaraBayarDetail
    '
    Me.layCaraBayarDetail.CustomizationFormText = "Detail"
    Me.layCaraBayarDetail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.layJatuhTempo, Me.LayoutControlItem7, Me.EmptySpaceItem3})
    Me.layCaraBayarDetail.Location = New System.Drawing.Point(235, 225)
    Me.layCaraBayarDetail.Name = "layCaraBayarDetail"
    Me.layCaraBayarDetail.Size = New System.Drawing.Size(873, 72)
    Me.layCaraBayarDetail.Text = "Detail"
    Me.layCaraBayarDetail.TextLocation = DevExpress.Utils.Locations.Right
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.TextEdit2
    Me.LayoutControlItem6.CustomizationFormText = "No Cek/Giro"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(186, 24)
    Me.LayoutControlItem6.Text = "No Cek/Giro"
    Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(57, 13)
    Me.LayoutControlItem6.TextToControlDistance = 5
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.TextEdit1
    Me.LayoutControlItem5.CustomizationFormText = "No A/C"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(186, 24)
    Me.LayoutControlItem5.Text = "No A/C"
    Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(57, 13)
    Me.LayoutControlItem5.TextToControlDistance = 5
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.TextEdit3
    Me.LayoutControlItem2.CustomizationFormText = "Bank"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(186, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(190, 24)
    Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem2.Text = "Bank"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(46, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'layJatuhTempo
    '
    Me.layJatuhTempo.Control = Me.DateEdit1
    Me.layJatuhTempo.CustomizationFormText = "Jatuh Tempo"
    Me.layJatuhTempo.Location = New System.Drawing.Point(376, 0)
    Me.layJatuhTempo.Name = "layJatuhTempo"
    Me.layJatuhTempo.Size = New System.Drawing.Size(206, 48)
    Me.layJatuhTempo.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.layJatuhTempo.Text = "Jatuh Tempo"
    Me.layJatuhTempo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layJatuhTempo.TextSize = New System.Drawing.Size(62, 13)
    Me.layJatuhTempo.TextToControlDistance = 5
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.TextEdit4
    Me.LayoutControlItem7.CustomizationFormText = "Akun Giro"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(186, 24)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(190, 24)
    Me.LayoutControlItem7.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem7.Text = "Akun Giro"
    Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(46, 13)
    Me.LayoutControlItem7.TextToControlDistance = 5
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(582, 0)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(248, 48)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'layCaraBayar
    '
    Me.layCaraBayar.Control = Me.txtCaraBayar
    Me.layCaraBayar.CustomizationFormText = "Tipe Pembayaran"
    Me.layCaraBayar.Location = New System.Drawing.Point(0, 225)
    Me.layCaraBayar.Name = "layCaraBayar"
    Me.layCaraBayar.Size = New System.Drawing.Size(235, 96)
    Me.layCaraBayar.Text = "Tipe Pembayaran"
    Me.layCaraBayar.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.layCaraBayar.TextSize = New System.Drawing.Size(66, 13)
    Me.layCaraBayar.TextToControlDistance = 5
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtAkun
    Me.LayoutControlItem11.CustomizationFormText = "Coa Kas/Bank"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 117)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(235, 24)
    Me.LayoutControlItem11.Text = "Coa Kas/Bank"
    Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(66, 13)
    Me.LayoutControlItem11.TextToControlDistance = 5
    '
    'LayoutControlGroup4
    '
    Me.LayoutControlGroup4.CaptionImagePadding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
    Me.LayoutControlGroup4.CustomizationFormText = "Detail"
    Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem12, Me.LayoutControlItem20, Me.LayoutControlItem19, Me.LayoutControlItem13, Me.LayoutControlItem4, Me.LayoutControlItem18, Me.LayoutControlItem22, Me.LayoutControlItem24, Me.LayoutControlItem25})
    Me.LayoutControlGroup4.Location = New System.Drawing.Point(235, 117)
    Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
    Me.LayoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
    Me.LayoutControlGroup4.Size = New System.Drawing.Size(873, 108)
    Me.LayoutControlGroup4.Text = "Detail"
    Me.LayoutControlGroup4.TextLocation = DevExpress.Utils.Locations.Right
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtUang
    Me.LayoutControlItem10.CustomizationFormText = "Uang"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(169, 24)
    Me.LayoutControlItem10.Text = "Uang"
    Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(40, 20)
    Me.LayoutControlItem10.TextToControlDistance = 5
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtKurs
    Me.LayoutControlItem9.CustomizationFormText = "Kurs"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(169, 24)
    Me.LayoutControlItem9.Text = "Kurs"
    Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(40, 13)
    Me.LayoutControlItem9.TextToControlDistance = 5
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtNilaiKas
    Me.LayoutControlItem12.CustomizationFormText = "Nilai Kas"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(169, 48)
    Me.LayoutControlItem12.Text = "Nilai Kas"
    Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(40, 13)
    Me.LayoutControlItem12.TextToControlDistance = 5
    '
    'LayoutControlItem20
    '
    Me.LayoutControlItem20.Control = Me.txtNilaiPendapatan
    Me.LayoutControlItem20.CustomizationFormText = "Pendapatan"
    Me.LayoutControlItem20.Location = New System.Drawing.Point(388, 0)
    Me.LayoutControlItem20.Name = "LayoutControlItem20"
    Me.LayoutControlItem20.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem20.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem20.Text = "Pendapatan(+)"
    Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem20.TextSize = New System.Drawing.Size(75, 13)
    Me.LayoutControlItem20.TextToControlDistance = 5
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.txtNilaiPembulatan
    Me.LayoutControlItem19.CustomizationFormText = "Pembulatan"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(169, 48)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(219, 48)
    Me.LayoutControlItem19.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem19.Text = "Pembulatan(+)"
    Me.LayoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(75, 13)
    Me.LayoutControlItem19.TextToControlDistance = 5
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtNilaiValas
    Me.LayoutControlItem13.CustomizationFormText = "Nilai Valas"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(169, 0)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem13.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem13.Text = "Nilai Valas"
    Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(75, 13)
    Me.LayoutControlItem13.TextToControlDistance = 5
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtNilaiPPH
    Me.LayoutControlItem4.CustomizationFormText = "Nilai PPH"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(388, 24)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem4.Text = "Nilai PPH (-)"
    Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(75, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
    '
    'LayoutControlItem18
    '
    Me.LayoutControlItem18.Control = Me.txtNilaiAdministrasi
    Me.LayoutControlItem18.CustomizationFormText = "Biaya Administrasi"
    Me.LayoutControlItem18.Location = New System.Drawing.Point(169, 24)
    Me.LayoutControlItem18.Name = "LayoutControlItem18"
    Me.LayoutControlItem18.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem18.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem18.Text = "Administrasi (-)"
    Me.LayoutControlItem18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem18.TextSize = New System.Drawing.Size(75, 13)
    Me.LayoutControlItem18.TextToControlDistance = 5
    '
    'LayoutControlItem22
    '
    Me.LayoutControlItem22.Control = Me.lbTotal
    Me.LayoutControlItem22.CustomizationFormText = "LayoutControlItem22"
    Me.LayoutControlItem22.Location = New System.Drawing.Point(607, 0)
    Me.LayoutControlItem22.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem22.Name = "LayoutControlItem22"
    Me.LayoutControlItem22.Size = New System.Drawing.Size(235, 96)
    Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem22.Text = "LayoutControlItem22"
    Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem22.TextToControlDistance = 0
    Me.LayoutControlItem22.TextVisible = False
    '
    'LayoutControlItem24
    '
    Me.LayoutControlItem24.Control = Me.txtPPNWapu
    Me.LayoutControlItem24.CustomizationFormText = "Nilai PPN (-)"
    Me.LayoutControlItem24.Location = New System.Drawing.Point(388, 48)
    Me.LayoutControlItem24.Name = "LayoutControlItem24"
    Me.LayoutControlItem24.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem24.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem24.Text = "Nilai PPN (-)"
    Me.LayoutControlItem24.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem24.TextSize = New System.Drawing.Size(75, 13)
    Me.LayoutControlItem24.TextToControlDistance = 5
    '
    'LayoutControlItem25
    '
    Me.LayoutControlItem25.Control = Me.txtWapuKurs
    Me.LayoutControlItem25.CustomizationFormText = "Kurs WAPU"
    Me.LayoutControlItem25.Location = New System.Drawing.Point(388, 72)
    Me.LayoutControlItem25.Name = "LayoutControlItem25"
    Me.LayoutControlItem25.Size = New System.Drawing.Size(219, 24)
    Me.LayoutControlItem25.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem25.Text = "Kurs WAPU"
    Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem25.TextSize = New System.Drawing.Size(75, 13)
    Me.LayoutControlItem25.TextToControlDistance = 5
    '
    'EmptySpaceItem11
    '
    Me.EmptySpaceItem11.AllowHotTrack = False
    Me.EmptySpaceItem11.CustomizationFormText = "EmptySpaceItem11"
    Me.EmptySpaceItem11.Location = New System.Drawing.Point(0, 141)
    Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
    Me.EmptySpaceItem11.Size = New System.Drawing.Size(73, 84)
    Me.EmptySpaceItem11.Text = "EmptySpaceItem11"
    Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
    '
    'layAkunKasBankNama
    '
    Me.layAkunKasBankNama.AllowHotTrack = False
    Me.layAkunKasBankNama.AppearanceItemCaption.Options.UseTextOptions = True
    Me.layAkunKasBankNama.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
    Me.layAkunKasBankNama.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.layAkunKasBankNama.CustomizationFormText = "LabelSimpleLabelItem1"
    Me.layAkunKasBankNama.Location = New System.Drawing.Point(73, 141)
    Me.layAkunKasBankNama.MaxSize = New System.Drawing.Size(162, 17)
    Me.layAkunKasBankNama.MinSize = New System.Drawing.Size(162, 17)
    Me.layAkunKasBankNama.Name = "layAkunKasBankNama"
    Me.layAkunKasBankNama.Size = New System.Drawing.Size(162, 17)
    Me.layAkunKasBankNama.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layAkunKasBankNama.Text = "Nama Coa Kas/Bank"
    Me.layAkunKasBankNama.TextSize = New System.Drawing.Size(96, 13)
    '
    'LayoutControlItem21
    '
    Me.LayoutControlItem21.Control = Me.chkPajak
    Me.LayoutControlItem21.CustomizationFormText = "LayoutControlItem21"
    Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 94)
    Me.LayoutControlItem21.Name = "LayoutControlItem21"
    Me.LayoutControlItem21.Size = New System.Drawing.Size(1108, 23)
    Me.LayoutControlItem21.Text = "LayoutControlItem21"
    Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem21.TextToControlDistance = 0
    Me.LayoutControlItem21.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.xGrid
    Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 321)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(1108, 89)
    Me.LayoutControlItem1.Text = "LayoutControlItem1"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextToControlDistance = 0
    Me.LayoutControlItem1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.lytRegional, Me.LayoutControlItem14, Me.EmptySpaceItem2, Me.LayoutControlItem23, Me.EmptySpaceItem1})
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
    Me.layKontak.Size = New System.Drawing.Size(215, 48)
    Me.layKontak.Text = "Customer"
    Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layKontak.TextSize = New System.Drawing.Size(46, 13)
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
    Me.LayoutControlItem17.Name = "LayoutControlItem17"
    Me.LayoutControlItem17.Size = New System.Drawing.Size(30, 48)
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
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(431, 0)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(276, 48)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem23
    '
    Me.LayoutControlItem23.Control = Me.lblKontakNama
    Me.LayoutControlItem23.CustomizationFormText = "LayoutControlItem23"
    Me.LayoutControlItem23.Location = New System.Drawing.Point(215, 0)
    Me.LayoutControlItem23.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem23.Name = "LayoutControlItem23"
    Me.LayoutControlItem23.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem23.Text = "LayoutControlItem23"
    Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem23.TextToControlDistance = 0
    Me.LayoutControlItem23.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(215, 24)
    Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(235, 297)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(873, 24)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(31, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtNoPPH
    Me.LayoutControlItem8.CustomizationFormText = "No PPH"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(73, 158)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(162, 67)
    Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem8.Text = "No PPH"
    Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(75, 20)
    Me.LayoutControlItem8.TextToControlDistance = 5
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
    'UI_zParamaPembayaranDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1134, 468)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "UI_zParamaPembayaranDialog"
    Me.Text = "Pembayaran Piutang [CP]"
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
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksi.ResumeLayout(False)
    CType(Me.txtWapuKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiValas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiKas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCaraBayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiPembulatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiAdministrasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiPPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPPNWapu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiPendapatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layCaraBayarDetail, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layJatuhTempo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layCaraBayar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layAkunKasBankNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
  Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
  Friend WithEvents lytTransaksi As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtCaraBayar As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents layCaraBayar As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents layCaraBayarDetail As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents layJatuhTempo As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents layAkunKasBankNama As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNilaiValas As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNilaiKas As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoPPH As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lbTotal As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents chkPajak As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colOK As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colInvoice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTgl As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTerbayar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKursInvoice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJumlahBayar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSisa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtAkun As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtNilaiPembulatan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNilaiAdministrasi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNilaiPPH As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPPNWapu As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNilaiPendapatan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtWapuKurs As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
End Class
