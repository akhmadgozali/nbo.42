<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanYuPIBDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SanYuPIBDialog))
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
    Me.txtKurs = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKite = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKiteRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHarga2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBMRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colPPN2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCIF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBMNilai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPNNilai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBeaMasukP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPNp = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.txtReffNo = New DevExpress.XtraEditors.TextEdit()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoIV = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGridBiaya = New DevExpress.XtraGrid.GridControl()
    Me.xGridBiayaView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.colKodeBarangRepoGrid = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colKuotaImporRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colPPNRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colPPHRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtNoPengajuan = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoPendaftaran = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiPPNBM = New DevExpress.XtraEditors.TextEdit()
    Me.txtJatuhTempo = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglPendaftaran = New DevExpress.XtraEditors.DateEdit()
    Me.txtUmur = New DevExpress.XtraEditors.TextEdit()
    Me.txtKPBC = New DevExpress.XtraEditors.TextEdit()
    Me.txtMataUang = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
    Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.item2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.btnAmbilPermintaan = New DevExpress.XtraBars.BarButtonItem()
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
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKiteRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colBMRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtReffNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoIV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridBiayaView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKuotaImporRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colPPNRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colPPHRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPengajuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPendaftaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiPPNBM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJatuhTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJatuhTempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglPendaftaran.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglPendaftaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUmur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKPBC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.item2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.DockPanel1.Size = New System.Drawing.Size(250, 441)
    Me.DockPanel1.Text = "Panel Informasi"
    Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
    '
    'DockPanel1_Container
    '
    Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
    Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
    Me.DockPanel1_Container.Name = "DockPanel1_Container"
    Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 414)
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
    Me.NavBarControl1.Size = New System.Drawing.Size(242, 414)
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
    Me.lytTransaksi.Controls.Add(Me.txtKurs)
    Me.lytTransaksi.Controls.Add(Me.xGrid)
    Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
    Me.lytTransaksi.Controls.Add(Me.txtReffNo)
    Me.lytTransaksi.Controls.Add(Me.txtStatus)
    Me.lytTransaksi.Controls.Add(Me.txtNoIV)
    Me.lytTransaksi.Controls.Add(Me.txtKontakPerson)
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.xGridBiaya)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.txtNoPengajuan)
    Me.lytTransaksi.Controls.Add(Me.txtNoPendaftaran)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiPPNBM)
    Me.lytTransaksi.Controls.Add(Me.txtJatuhTempo)
    Me.lytTransaksi.Controls.Add(Me.txtTglPendaftaran)
    Me.lytTransaksi.Controls.Add(Me.txtUmur)
    Me.lytTransaksi.Controls.Add(Me.txtKPBC)
    Me.lytTransaksi.Controls.Add(Me.txtMataUang)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 289, 250, 350)
    Me.lytTransaksi.Root = Me.LayoutControlGroup1
    Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
    Me.lytTransaksi.TabIndex = 0
    Me.lytTransaksi.Text = "LayoutControl1"
    '
    'txtKurs
    '
    Me.txtKurs.Location = New System.Drawing.Point(778, 107)
    Me.txtKurs.MenuManager = Me.barMan
    Me.txtKurs.Name = "txtKurs"
    Me.txtKurs.Properties.Mask.EditMask = "n2"
    Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtKurs.Size = New System.Drawing.Size(98, 20)
    Me.txtKurs.StyleController = Me.lytTransaksi
    Me.txtKurs.TabIndex = 10
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(24, 189)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colKiteRepo, Me.colBMRepo})
    Me.xGrid.Size = New System.Drawing.Size(1080, 222)
    Me.xGrid.TabIndex = 13
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKite, Me.GridColumn1, Me.GridColumn2, Me.colQty2, Me.colSatuan, Me.colHarga2, Me.colBM, Me.colPPN2, Me.colTotal2, Me.colCIF, Me.colBMNilai, Me.colPPNNilai, Me.GridColumn6, Me.colBeaMasukP, Me.colPPNp, Me.colKurs})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colKite
    '
    Me.colKite.Caption = "Kite"
    Me.colKite.ColumnEdit = Me.colKiteRepo
    Me.colKite.FieldName = "Kite"
    Me.colKite.Name = "colKite"
    Me.colKite.Visible = True
    Me.colKite.VisibleIndex = 0
    Me.colKite.Width = 32
    '
    'colKiteRepo
    '
    Me.colKiteRepo.AutoHeight = False
    Me.colKiteRepo.Caption = "Check"
    Me.colKiteRepo.Name = "colKiteRepo"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode Barang"
    Me.GridColumn1.FieldName = "Barang.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowEdit = False
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 1
    Me.GridColumn1.Width = 91
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama Barang"
    Me.GridColumn2.FieldName = "Barang.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.AllowEdit = False
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 2
    Me.GridColumn2.Width = 154
    '
    'colQty2
    '
    Me.colQty2.AppearanceCell.Options.UseTextOptions = True
    Me.colQty2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colQty2.AppearanceHeader.Options.UseTextOptions = True
    Me.colQty2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colQty2.Caption = "Qty"
    Me.colQty2.FieldName = "Qty"
    Me.colQty2.Name = "colQty2"
    Me.colQty2.OptionsColumn.AllowSize = False
    Me.colQty2.OptionsColumn.FixedWidth = True
    Me.colQty2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQty2.Visible = True
    Me.colQty2.VisibleIndex = 3
    Me.colQty2.Width = 57
    '
    'colSatuan
    '
    Me.colSatuan.AppearanceCell.Options.UseTextOptions = True
    Me.colSatuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colSatuan.AppearanceHeader.Options.UseTextOptions = True
    Me.colSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colSatuan.Caption = "Satuan"
    Me.colSatuan.FieldName = "Satuan.Kode"
    Me.colSatuan.Name = "colSatuan"
    Me.colSatuan.OptionsColumn.AllowEdit = False
    Me.colSatuan.OptionsColumn.ReadOnly = True
    Me.colSatuan.Visible = True
    Me.colSatuan.VisibleIndex = 4
    Me.colSatuan.Width = 70
    '
    'colHarga2
    '
    Me.colHarga2.Caption = "Harga"
    Me.colHarga2.FieldName = "Harga"
    Me.colHarga2.Name = "colHarga2"
    Me.colHarga2.OptionsColumn.AllowEdit = False
    Me.colHarga2.OptionsColumn.ReadOnly = True
    Me.colHarga2.Visible = True
    Me.colHarga2.VisibleIndex = 5
    Me.colHarga2.Width = 79
    '
    'colBM
    '
    Me.colBM.Caption = "BM"
    Me.colBM.ColumnEdit = Me.colBMRepo
    Me.colBM.FieldName = "BeaMasuk!"
    Me.colBM.Name = "colBM"
    Me.colBM.Visible = True
    Me.colBM.VisibleIndex = 8
    Me.colBM.Width = 81
    '
    'colBMRepo
    '
    Me.colBMRepo.AutoHeight = False
    Me.colBMRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colBMRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NilaiPajak", "Nilai")})
    Me.colBMRepo.DisplayMember = "Kode"
    Me.colBMRepo.Name = "colBMRepo"
    Me.colBMRepo.NullText = "<Pilih Pajak>"
    Me.colBMRepo.ValueMember = "This"
    '
    'colPPN2
    '
    Me.colPPN2.Caption = "PPN"
    Me.colPPN2.FieldName = "PPN.Kode"
    Me.colPPN2.Name = "colPPN2"
    Me.colPPN2.OptionsColumn.AllowEdit = False
    Me.colPPN2.OptionsColumn.ReadOnly = True
    Me.colPPN2.Visible = True
    Me.colPPN2.VisibleIndex = 9
    Me.colPPN2.Width = 54
    '
    'colTotal2
    '
    Me.colTotal2.Caption = "Total"
    Me.colTotal2.FieldName = "Total"
    Me.colTotal2.Name = "colTotal2"
    Me.colTotal2.OptionsColumn.AllowEdit = False
    Me.colTotal2.OptionsColumn.ReadOnly = True
    Me.colTotal2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colTotal2.Visible = True
    Me.colTotal2.VisibleIndex = 6
    Me.colTotal2.Width = 84
    '
    'colCIF
    '
    Me.colCIF.Caption = "CIFKite"
    Me.colCIF.FieldName = "CIFKite"
    Me.colCIF.Name = "colCIF"
    Me.colCIF.OptionsColumn.AllowEdit = False
    Me.colCIF.OptionsColumn.ReadOnly = True
    Me.colCIF.Visible = True
    Me.colCIF.VisibleIndex = 7
    Me.colCIF.Width = 64
    '
    'colBMNilai
    '
    Me.colBMNilai.Caption = "Nilai BM"
    Me.colBMNilai.FieldName = "BMNilai"
    Me.colBMNilai.Name = "colBMNilai"
    Me.colBMNilai.OptionsColumn.AllowEdit = False
    Me.colBMNilai.OptionsColumn.ReadOnly = True
    Me.colBMNilai.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colBMNilai.Visible = True
    Me.colBMNilai.VisibleIndex = 10
    '
    'colPPNNilai
    '
    Me.colPPNNilai.Caption = "Nilai PPN"
    Me.colPPNNilai.FieldName = "PPNNilai"
    Me.colPPNNilai.Name = "colPPNNilai"
    Me.colPPNNilai.OptionsColumn.AllowEdit = False
    Me.colPPNNilai.OptionsColumn.ReadOnly = True
    Me.colPPNNilai.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colPPNNilai.Visible = True
    Me.colPPNNilai.VisibleIndex = 11
    '
    'GridColumn6
    '
    Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.GridColumn6.Caption = "Catatan"
    Me.GridColumn6.FieldName = "Catatan"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 12
    Me.GridColumn6.Width = 200
    '
    'colBeaMasukP
    '
    Me.colBeaMasukP.FieldName = "BeaMasukP"
    Me.colBeaMasukP.Name = "colBeaMasukP"
    '
    'colPPNp
    '
    Me.colPPNp.FieldName = "PPNp"
    Me.colPPNp.Name = "colPPNp"
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs"
    Me.colKurs.FieldName = "Main.Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.OptionsColumn.AllowEdit = False
    Me.colKurs.OptionsColumn.ReadOnly = True
    '
    'lblKontakNama
    '
    Me.lblKontakNama.Location = New System.Drawing.Point(257, 37)
    Me.lblKontakNama.Name = "lblKontakNama"
    Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
    Me.lblKontakNama.StyleController = Me.lytTransaksi
    Me.lblKontakNama.TabIndex = 25
    '
    'txtReffNo
    '
    Me.txtReffNo.Location = New System.Drawing.Point(331, 107)
    Me.txtReffNo.MenuManager = Me.barMan
    Me.txtReffNo.Name = "txtReffNo"
    Me.txtReffNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtReffNo.Size = New System.Drawing.Size(208, 20)
    Me.txtReffNo.StyleController = Me.lytTransaksi
    Me.txtReffNo.TabIndex = 8
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
    Me.txtStatus.TabIndex = 5
    '
    'txtNoIV
    '
    Me.txtNoIV.Location = New System.Drawing.Point(107, 107)
    Me.txtNoIV.MenuManager = Me.barMan
    Me.txtNoIV.Name = "txtNoIV"
    Me.txtNoIV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoIV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoIV.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 90, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tanggal", "Tanggal", 70, DevExpress.Utils.FormatType.DateTime, "dd/MMM/yyyy", True, DevExpress.Utils.HorzAlignment.[Default])})
    Me.txtNoIV.Properties.DisplayMember = "Kode"
    Me.txtNoIV.Properties.NullText = "<Pilih No Invoice>"
    Me.txtNoIV.Properties.PopupWidth = 300
    Me.txtNoIV.Properties.ValueMember = "This"
    Me.txtNoIV.Size = New System.Drawing.Size(145, 20)
    Me.txtNoIV.StyleController = Me.lytTransaksi
    Me.txtNoIV.TabIndex = 7
    '
    'txtKontakPerson
    '
    Me.txtKontakPerson.Location = New System.Drawing.Point(93, 62)
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
    Me.txtKontakPerson.TabIndex = 6
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
    'xGridBiaya
    '
    Me.xGridBiaya.Location = New System.Drawing.Point(24, 189)
    Me.xGridBiaya.MainView = Me.xGridBiayaView
    Me.xGridBiaya.MenuManager = Me.barMan
    Me.xGridBiaya.Name = "xGridBiaya"
    Me.xGridBiaya.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSatuanRepo, Me.colKuotaImporRepo, Me.colHargaRepo, Me.colKodeBarangRepo, Me.colPPNRepo, Me.colPPHRepo})
    Me.xGridBiaya.Size = New System.Drawing.Size(1080, 222)
    Me.xGridBiaya.TabIndex = 13
    Me.xGridBiaya.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridBiayaView})
    '
    'xGridBiayaView
    '
    Me.xGridBiayaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colHarga, Me.colTotal, Me.colCatatan})
    Me.xGridBiayaView.GridControl = Me.xGridBiaya
    Me.xGridBiayaView.Name = "xGridBiayaView"
    Me.xGridBiayaView.NewItemRowText = "Tambah Data"
    Me.xGridBiayaView.OptionsCustomization.AllowGroup = False
    Me.xGridBiayaView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridBiayaView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridBiayaView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridBiayaView.OptionsView.ShowFooter = True
    Me.xGridBiayaView.OptionsView.ShowGroupPanel = False
    '
    'colKodeBarang
    '
    Me.colKodeBarang.Caption = "Kode Biaya"
    Me.colKodeBarang.ColumnEdit = Me.colKodeBarangRepo
    Me.colKodeBarang.FieldName = "Barang!"
    Me.colKodeBarang.Name = "colKodeBarang"
    Me.colKodeBarang.Visible = True
    Me.colKodeBarang.VisibleIndex = 0
    Me.colKodeBarang.Width = 80
    '
    'colKodeBarangRepo
    '
    Me.colKodeBarangRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
    Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKodeBarangRepo.DisplayMember = "Kode"
    Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
    Me.colKodeBarangRepo.NullText = "<Pilih Kode Biaya>"
    Me.colKodeBarangRepo.ShowClearButton = False
    Me.colKodeBarangRepo.ShowFooter = False
    Me.colKodeBarangRepo.ValueMember = "This"
    Me.colKodeBarangRepo.View = Me.colKodeBarangRepoGrid
    '
    'colKodeBarangRepoGrid
    '
    Me.colKodeBarangRepoGrid.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama})
    Me.colKodeBarangRepoGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.colKodeBarangRepoGrid.Name = "colKodeBarangRepoGrid"
    Me.colKodeBarangRepoGrid.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.colKodeBarangRepoGrid.OptionsView.ShowAutoFilterRow = True
    Me.colKodeBarangRepoGrid.OptionsView.ShowGroupPanel = False
    '
    'gcKode
    '
    Me.gcKode.Caption = "Kode"
    Me.gcKode.FieldName = "Kode"
    Me.gcKode.Name = "gcKode"
    Me.gcKode.Visible = True
    Me.gcKode.VisibleIndex = 0
    Me.gcKode.Width = 250
    '
    'gcNama
    '
    Me.gcNama.Caption = "Nama"
    Me.gcNama.FieldName = "Nama"
    Me.gcNama.Name = "gcNama"
    Me.gcNama.Visible = True
    Me.gcNama.VisibleIndex = 1
    Me.gcNama.Width = 300
    '
    'colNamaBarang
    '
    Me.colNamaBarang.Caption = "Nama Biaya"
    Me.colNamaBarang.FieldName = "Barang.Nama"
    Me.colNamaBarang.Name = "colNamaBarang"
    Me.colNamaBarang.OptionsColumn.AllowEdit = False
    Me.colNamaBarang.OptionsColumn.ReadOnly = True
    Me.colNamaBarang.Visible = True
    Me.colNamaBarang.VisibleIndex = 1
    Me.colNamaBarang.Width = 120
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
    Me.colQty.Width = 50
    '
    'colHarga
    '
    Me.colHarga.Caption = "Harga"
    Me.colHarga.ColumnEdit = Me.colHargaRepo
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    Me.colHarga.Visible = True
    Me.colHarga.VisibleIndex = 3
    Me.colHarga.Width = 70
    '
    'colHargaRepo
    '
    Me.colHargaRepo.AutoHeight = False
    Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colHargaRepo.Name = "colHargaRepo"
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
    Me.colTotal.VisibleIndex = 4
    Me.colTotal.Width = 67
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
    Me.colCatatan.Width = 179
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
    'colKuotaImporRepo
    '
    Me.colKuotaImporRepo.AutoHeight = False
    Me.colKuotaImporRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKuotaImporRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KodeHS", "Kode HS"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SisaVolume", "Sisa Volume", 20, DevExpress.Utils.FormatType.Numeric, "n0", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Expired", "Expired", 20, DevExpress.Utils.FormatType.Custom, "dd-MMM-yy", True, DevExpress.Utils.HorzAlignment.[Default])})
    Me.colKuotaImporRepo.DisplayMember = "KodeHS"
    Me.colKuotaImporRepo.Name = "colKuotaImporRepo"
    Me.colKuotaImporRepo.NullText = "<Kuota Impor>"
    Me.colKuotaImporRepo.ValueMember = "This"
    '
    'colPPNRepo
    '
    Me.colPPNRepo.AutoHeight = False
    Me.colPPNRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colPPNRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colPPNRepo.DisplayMember = "Kode"
    Me.colPPNRepo.Name = "colPPNRepo"
    Me.colPPNRepo.NullText = "<Pilih Pajak>"
    Me.colPPNRepo.ValueMember = "This"
    '
    'colPPHRepo
    '
    Me.colPPHRepo.AutoHeight = False
    Me.colPPHRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colPPHRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colPPHRepo.DisplayMember = "Kode"
    Me.colPPHRepo.Name = "colPPHRepo"
    Me.colPPHRepo.NullText = "<Pilih Pajak>"
    Me.colPPHRepo.ValueMember = "This"
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(107, 131)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(1009, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 11
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(93, 37)
    Me.txtKontak.MenuManager = Me.barMan
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Vendor>"
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
    'txtNoPengajuan
    '
    Me.txtNoPengajuan.EditValue = ""
    Me.txtNoPengajuan.Location = New System.Drawing.Point(106, 189)
    Me.txtNoPengajuan.MenuManager = Me.barMan
    Me.txtNoPengajuan.Name = "txtNoPengajuan"
    Me.txtNoPengajuan.Properties.NullText = "<Masukkan No AJOU>"
    Me.txtNoPengajuan.Size = New System.Drawing.Size(393, 20)
    Me.txtNoPengajuan.StyleController = Me.lytTransaksi
    Me.txtNoPengajuan.TabIndex = 13
    '
    'txtNoPendaftaran
    '
    Me.txtNoPendaftaran.EditValue = ""
    Me.txtNoPendaftaran.Location = New System.Drawing.Point(106, 213)
    Me.txtNoPendaftaran.MenuManager = Me.barMan
    Me.txtNoPendaftaran.Name = "txtNoPendaftaran"
    Me.txtNoPendaftaran.Properties.NullText = "<Masukkan No Dokumen>"
    Me.txtNoPendaftaran.Size = New System.Drawing.Size(393, 20)
    Me.txtNoPendaftaran.StyleController = Me.lytTransaksi
    Me.txtNoPendaftaran.TabIndex = 14
    '
    'txtNilaiPPNBM
    '
    Me.txtNilaiPPNBM.EditValue = ""
    Me.txtNilaiPPNBM.Location = New System.Drawing.Point(106, 333)
    Me.txtNilaiPPNBM.MenuManager = Me.barMan
    Me.txtNilaiPPNBM.Name = "txtNilaiPPNBM"
    Me.txtNilaiPPNBM.Properties.NullText = "<Masukkan Nilai PPN + BM>"
    Me.txtNilaiPPNBM.Size = New System.Drawing.Size(393, 20)
    Me.txtNilaiPPNBM.StyleController = Me.lytTransaksi
    Me.txtNilaiPPNBM.TabIndex = 19
    '
    'txtJatuhTempo
    '
    Me.txtJatuhTempo.EditValue = Nothing
    Me.txtJatuhTempo.Location = New System.Drawing.Point(106, 309)
    Me.txtJatuhTempo.MenuManager = Me.barMan
    Me.txtJatuhTempo.Name = "txtJatuhTempo"
    Me.txtJatuhTempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtJatuhTempo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtJatuhTempo.Properties.Mask.EditMask = ""
    Me.txtJatuhTempo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtJatuhTempo.Size = New System.Drawing.Size(393, 20)
    Me.txtJatuhTempo.StyleController = Me.lytTransaksi
    Me.txtJatuhTempo.TabIndex = 18
    '
    'txtTglPendaftaran
    '
    Me.txtTglPendaftaran.EditValue = Nothing
    Me.txtTglPendaftaran.Location = New System.Drawing.Point(106, 237)
    Me.txtTglPendaftaran.MenuManager = Me.barMan
    Me.txtTglPendaftaran.Name = "txtTglPendaftaran"
    Me.txtTglPendaftaran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglPendaftaran.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglPendaftaran.Properties.Mask.EditMask = ""
    Me.txtTglPendaftaran.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTglPendaftaran.Size = New System.Drawing.Size(393, 20)
    Me.txtTglPendaftaran.StyleController = Me.lytTransaksi
    Me.txtTglPendaftaran.TabIndex = 15
    '
    'txtUmur
    '
    Me.txtUmur.EditValue = ""
    Me.txtUmur.Location = New System.Drawing.Point(106, 285)
    Me.txtUmur.MenuManager = Me.barMan
    Me.txtUmur.Name = "txtUmur"
    Me.txtUmur.Properties.NullText = "<Masukkan Umur>"
    Me.txtUmur.Size = New System.Drawing.Size(393, 20)
    Me.txtUmur.StyleController = Me.lytTransaksi
    Me.txtUmur.TabIndex = 17
    '
    'txtKPBC
    '
    Me.txtKPBC.EditValue = ""
    Me.txtKPBC.Location = New System.Drawing.Point(106, 261)
    Me.txtKPBC.MenuManager = Me.barMan
    Me.txtKPBC.Name = "txtKPBC"
    Me.txtKPBC.Properties.NullText = "<Masukkan Kode KNT>"
    Me.txtKPBC.Size = New System.Drawing.Size(393, 20)
    Me.txtKPBC.StyleController = Me.lytTransaksi
    Me.txtKPBC.TabIndex = 16
    '
    'txtMataUang
    '
    Me.txtMataUang.Location = New System.Drawing.Point(625, 107)
    Me.txtMataUang.MenuManager = Me.barMan
    Me.txtMataUang.Name = "txtMataUang"
    Me.txtMataUang.Properties.ReadOnly = True
    Me.txtMataUang.Size = New System.Drawing.Size(67, 20)
    Me.txtMataUang.StyleController = Me.lytTransaksi
    Me.txtMataUang.TabIndex = 9
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlItem9, Me.TabbedControlGroup1, Me.LayoutControlItem13, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem19})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
    Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
    Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
    Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
    Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem17, Me.LayoutControlItem16, Me.LayoutControlItem14, Me.lytRegional, Me.LayoutControlItem1, Me.LayoutControlItem23, Me.EmptySpaceItem2, Me.EmptySpaceItem4})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(1108, 95)
    Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
    Me.LayoutControlGroup3.Text = "Info Utama"
    '
    'layKontak
    '
    Me.layKontak.Control = Me.txtKontak
    Me.layKontak.CustomizationFormText = "Vendor"
    Me.layKontak.Location = New System.Drawing.Point(0, 0)
    Me.layKontak.MinSize = New System.Drawing.Size(50, 25)
    Me.layKontak.Name = "layKontak"
    Me.layKontak.Size = New System.Drawing.Size(239, 25)
    Me.layKontak.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layKontak.Text = "Vendor   "
    Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.layKontak.TextSize = New System.Drawing.Size(70, 13)
    Me.layKontak.TextToControlDistance = 5
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(707, 0)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(172, 24)
    Me.LayoutControlItem15.Text = "Tanggal"
    Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem15.TextToControlDistance = 5
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.btnRefreshNomor
    Me.LayoutControlItem17.CustomizationFormText = " "
    Me.LayoutControlItem17.Location = New System.Drawing.Point(1066, 0)
    Me.LayoutControlItem17.Name = "LayoutControlItem17"
    Me.LayoutControlItem17.Size = New System.Drawing.Size(30, 49)
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
    Me.LayoutControlItem16.Location = New System.Drawing.Point(879, 0)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(187, 24)
    Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem16.Text = "No Bukti"
    Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem16.TextToControlDistance = 5
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtStatus
    Me.LayoutControlItem14.CustomizationFormText = "Status"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(879, 24)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(187, 25)
    Me.LayoutControlItem14.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem14.Text = "Status   "
    Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem14.TextToControlDistance = 5
    '
    'lytRegional
    '
    Me.lytRegional.Control = Me.txtRegional
    Me.lytRegional.CustomizationFormText = "Regional"
    Me.lytRegional.Location = New System.Drawing.Point(707, 24)
    Me.lytRegional.Name = "lytRegional"
    Me.lytRegional.Size = New System.Drawing.Size(172, 25)
    Me.lytRegional.Text = "Regional"
    Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.lytRegional.TextSize = New System.Drawing.Size(43, 13)
    Me.lytRegional.TextToControlDistance = 5
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKontakPerson
    Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 25)
    Me.LayoutControlItem1.MinSize = New System.Drawing.Size(139, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(239, 24)
    Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem1.Text = "Kontak Person"
    Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(70, 13)
    Me.LayoutControlItem1.TextToControlDistance = 5
    '
    'LayoutControlItem23
    '
    Me.LayoutControlItem23.Control = Me.lblKontakNama
    Me.LayoutControlItem23.CustomizationFormText = "LayoutControlItem23"
    Me.LayoutControlItem23.Location = New System.Drawing.Point(239, 0)
    Me.LayoutControlItem23.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem23.Name = "LayoutControlItem23"
    Me.LayoutControlItem23.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem23.Text = "LayoutControlItem23"
    Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem23.TextToControlDistance = 0
    Me.LayoutControlItem23.TextVisible = False
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(455, 0)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(252, 49)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(239, 24)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(216, 25)
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
    Me.LayoutControlItem9.Control = Me.txtNoIV
    Me.LayoutControlItem9.CustomizationFormText = "No Invoice"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 95)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(244, 24)
    Me.LayoutControlItem9.Text = "No Invoice"
    Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(90, 13)
    Me.LayoutControlItem9.TextToControlDistance = 5
    '
    'TabbedControlGroup1
    '
    Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
    Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 143)
    Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
    Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup5
    Me.TabbedControlGroup1.SelectedTabPageIndex = 0
    Me.TabbedControlGroup1.Size = New System.Drawing.Size(1108, 272)
    Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup5, Me.LayoutControlGroup2, Me.LayoutControlGroup4})
    Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
    '
    'LayoutControlGroup5
    '
    Me.LayoutControlGroup5.CustomizationFormText = "Item"
    Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem18})
    Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
    Me.LayoutControlGroup5.Size = New System.Drawing.Size(1084, 226)
    Me.LayoutControlGroup5.Text = "Item"
    '
    'LayoutControlItem18
    '
    Me.LayoutControlItem18.Control = Me.xGrid
    Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
    Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem18.Name = "LayoutControlItem18"
    Me.LayoutControlItem18.Size = New System.Drawing.Size(1084, 226)
    Me.LayoutControlItem18.Text = "LayoutControlItem18"
    Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem18.TextToControlDistance = 0
    Me.LayoutControlItem18.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Detail Biaya"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(1084, 226)
    Me.LayoutControlGroup2.Text = "Detail Biaya"
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGridBiaya
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(1084, 226)
    Me.LayoutControlItem7.Text = "LayoutControlItem7"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'LayoutControlGroup4
    '
    Me.LayoutControlGroup4.CustomizationFormText = "KITE"
    Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem3, Me.EmptySpaceItem5})
    Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
    Me.LayoutControlGroup4.Size = New System.Drawing.Size(1084, 226)
    Me.LayoutControlGroup4.Text = "KITE"
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtNoPengajuan
    Me.LayoutControlItem4.CustomizationFormText = "NO AJOU"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem4.MinSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem4.Text = "No Pengajuan"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(79, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtNoPendaftaran
    Me.LayoutControlItem5.CustomizationFormText = "NO Dokumen"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem5.MinSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem5.Text = "No Pendaftaran"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(79, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtNilaiPPNBM
    Me.LayoutControlItem6.CustomizationFormText = "Nilai PPN+BM"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(479, 25)
    Me.LayoutControlItem6.MinSize = New System.Drawing.Size(479, 25)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(479, 25)
    Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem6.Text = "Nilai PPN+BM"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(79, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtJatuhTempo
    Me.LayoutControlItem8.CustomizationFormText = "Tgl Jatuh Tempo"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem8.MinSize = New System.Drawing.Size(136, 24)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem8.Text = "Tgl Jatuh Tempo"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(79, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtTglPendaftaran
    Me.LayoutControlItem10.CustomizationFormText = "Tgl Dokumen"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem10.MinSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem10.Text = "Tgl Pendaftaran"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(79, 13)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtUmur
    Me.LayoutControlItem11.CustomizationFormText = "Umur"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem11.MinSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem11.Text = "Umur"
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(79, 13)
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtKPBC
    Me.LayoutControlItem12.CustomizationFormText = "Kode KNT"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem12.MinSize = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(479, 24)
    Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem12.Text = "KPBC"
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(79, 13)
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(479, 0)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(605, 226)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 169)
    Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(479, 0)
    Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(479, 10)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(479, 57)
    Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtReffNo
    Me.LayoutControlItem13.CustomizationFormText = "Reff Number"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(244, 95)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(287, 24)
    Me.LayoutControlItem13.Text = "No PEB"
    Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(70, 13)
    Me.LayoutControlItem13.TextToControlDistance = 5
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
    Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 119)
    Me.LayoutControlItem3.MinSize = New System.Drawing.Size(89, 24)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(1108, 24)
    Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(90, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(868, 95)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(240, 24)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtMataUang
    Me.LayoutControlItem2.CustomizationFormText = "Mata Uang"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(531, 95)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(153, 24)
    Me.LayoutControlItem2.Text = "Mata Uang"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(79, 13)
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.txtKurs
    Me.LayoutControlItem19.CustomizationFormText = "Kurs"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(684, 95)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(184, 24)
    Me.LayoutControlItem19.Text = "Kurs"
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(79, 13)
    '
    'item2
    '
    Me.item2.CustomizationFormText = "item2"
    Me.item2.Location = New System.Drawing.Point(0, 0)
    Me.item2.Name = "item2"
    Me.item2.Size = New System.Drawing.Size(0, 0)
    Me.item2.Text = "item2"
    Me.item2.TextSize = New System.Drawing.Size(50, 20)
    Me.item2.TextToControlDistance = 5
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
    'btnAmbilPermintaan
    '
    Me.btnAmbilPermintaan.Caption = "Ambil Permintaan"
    Me.btnAmbilPermintaan.Glyph = CType(resources.GetObject("btnAmbilPermintaan.Glyph"), System.Drawing.Image)
    Me.btnAmbilPermintaan.Id = 9
    Me.btnAmbilPermintaan.LargeGlyph = CType(resources.GetObject("btnAmbilPermintaan.LargeGlyph"), System.Drawing.Image)
    Me.btnAmbilPermintaan.Name = "btnAmbilPermintaan"
    Me.btnAmbilPermintaan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'UI_SanYuPIBDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1134, 468)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "UI_SanYuPIBDialog"
    Me.Text = "PIB"
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
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKiteRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colBMRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtReffNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoIV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridBiaya, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridBiayaView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepoGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKuotaImporRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colPPNRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colPPHRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPengajuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPendaftaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiPPNBM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJatuhTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJatuhTempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglPendaftaran.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglPendaftaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUmur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKPBC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.item2, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents xGridBiaya As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridBiayaView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtKontakPerson As DevExpress.XtraEditors.LookUpEdit
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
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents txtNoIV As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKuotaImporRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
  Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
  Friend WithEvents txtReffNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents item2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colHargaRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents colKodeBarangRepoGrid As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnAmbilPermintaan As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colPPNRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colPPHRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtNoPengajuan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNoPendaftaran As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKPBC As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtUmur As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNilaiPPNBM As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtJatuhTempo As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTglPendaftaran As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHarga2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPN2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
  Friend WithEvents colKite As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKiteRepo As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents colCIF As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBMRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colBMNilai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPNNilai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtMataUang As DevExpress.XtraEditors.TextEdit
  Friend WithEvents colBeaMasukP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPNp As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
End Class
