﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xMesitechBuktiKas
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xMesitechBuktiKas))
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
    Me.lytTransaksiJU = New DevExpress.XtraLayout.LayoutControl()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtPrint = New DevExpress.XtraEditors.RadioGroup()
    Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colNoAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkunRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkunNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebitRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKreditRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colValasDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colValasKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colProyek = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colProyekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colProyekSub = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colProyekSubRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colAPP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAPPrepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.colAPPRepoGrid = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAPPTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAPPNilai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDBMutasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBPLain = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBersihDibayar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.txtCatatan = New DevExpress.XtraEditors.MemoExEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layCatatan = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
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
    CType(Me.lytTransaksiJU, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksiJU.SuspendLayout()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colAkunRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDebitRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKreditRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colUangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colProyekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colProyekSubRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colAPPrepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colAPPRepoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layCatatan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.DockPanel2_Container.Controls.Add(Me.lytTransaksiJU)
    Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
    Me.DockPanel2_Container.Name = "DockPanel2_Container"
    Me.DockPanel2_Container.Size = New System.Drawing.Size(1128, 435)
    Me.DockPanel2_Container.TabIndex = 0
    '
    'lytTransaksiJU
    '
    Me.lytTransaksiJU.Controls.Add(Me.txtStatus)
    Me.lytTransaksiJU.Controls.Add(Me.txtPrint)
    Me.lytTransaksiJU.Controls.Add(Me.lblKontakNama)
    Me.lytTransaksiJU.Controls.Add(Me.txtUraian)
    Me.lytTransaksiJU.Controls.Add(Me.xGrid)
    Me.lytTransaksiJU.Controls.Add(Me.txtRegional)
    Me.lytTransaksiJU.Controls.Add(Me.txtTanggal)
    Me.lytTransaksiJU.Controls.Add(Me.btnRefreshNomor)
    Me.lytTransaksiJU.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksiJU.Controls.Add(Me.txtCatatan)
    Me.lytTransaksiJU.Controls.Add(Me.txtKontak)
    Me.lytTransaksiJU.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksiJU.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksiJU.Name = "lytTransaksiJU"
    Me.lytTransaksiJU.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(725, 179, 316, 296)
    Me.lytTransaksiJU.Root = Me.LayoutControlGroup1
    Me.lytTransaksiJU.Size = New System.Drawing.Size(1128, 435)
    Me.lytTransaksiJU.TabIndex = 0
    Me.lytTransaksiJU.Text = "LayoutControl1"
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(960, 61)
    Me.txtStatus.MenuManager = Me.barMan
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStatus.Properties.DisplayMember = "Value"
    Me.txtStatus.Properties.NullText = "<Status>"
    Me.txtStatus.Properties.ValueMember = "Key"
    Me.txtStatus.Size = New System.Drawing.Size(120, 20)
    Me.txtStatus.StyleController = Me.lytTransaksiJU
    Me.txtStatus.TabIndex = 10
    '
    'txtPrint
    '
    Me.txtPrint.Location = New System.Drawing.Point(102, 398)
    Me.txtPrint.MenuManager = Me.barMan
    Me.txtPrint.Name = "txtPrint"
    Me.txtPrint.Properties.Columns = 2
    Me.txtPrint.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Voucher Kas Masuk"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Voucher Kas Keluar")})
    Me.txtPrint.Size = New System.Drawing.Size(460, 25)
    Me.txtPrint.StyleController = Me.lytTransaksiJU
    Me.txtPrint.TabIndex = 8
    '
    'lblKontakNama
    '
    Me.lblKontakNama.Location = New System.Drawing.Point(220, 37)
    Me.lblKontakNama.Name = "lblKontakNama"
    Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
    Me.lblKontakNama.StyleController = Me.lytTransaksiJU
    Me.lblKontakNama.TabIndex = 9
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(102, 106)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Size = New System.Drawing.Size(1014, 20)
    Me.txtUraian.StyleController = Me.lytTransaksiJU
    Me.txtUraian.TabIndex = 5
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 131)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colUangRepo, Me.colDivisiRepo, Me.colAkunRepo, Me.colDebitRepo, Me.colKreditRepo, Me.colProyekRepo, Me.colAPPrepo, Me.colProyekSubRepo})
    Me.xGrid.Size = New System.Drawing.Size(1104, 239)
    Me.xGrid.TabIndex = 6
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoAkun, Me.colAkunNama, Me.colDebit, Me.colKredit, Me.colUang, Me.colKurs, Me.colValasDebit, Me.colValasKredit, Me.colCatatan, Me.colDivisi, Me.colProyek, Me.colProyekSub, Me.colAPP, Me.colAPPTanggal, Me.colAPPNilai, Me.colDBMutasi, Me.colBPLain, Me.colBersihDibayar})
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
    'colNoAkun
    '
    Me.colNoAkun.Caption = "No. Akun"
    Me.colNoAkun.ColumnEdit = Me.colAkunRepo
    Me.colNoAkun.FieldName = "Akun!"
    Me.colNoAkun.Name = "colNoAkun"
    Me.colNoAkun.Visible = True
    Me.colNoAkun.VisibleIndex = 0
    Me.colNoAkun.Width = 92
    '
    'colAkunRepo
    '
    Me.colAkunRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.colAkunRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colAkunRepo.DisplayMember = "Kode"
    Me.colAkunRepo.Name = "colAkunRepo"
    Me.colAkunRepo.NullText = "<Pilih COA>"
    Me.colAkunRepo.ShowClearButton = False
    Me.colAkunRepo.ShowFooter = False
    Me.colAkunRepo.ValueMember = "This"
    Me.colAkunRepo.View = Me.RepositoryItemSearchLookUpEdit1View
    '
    'RepositoryItemSearchLookUpEdit1View
    '
    Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama})
    Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
    Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
    Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.RepositoryItemSearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'gcKode
    '
    Me.gcKode.Caption = "Kode"
    Me.gcKode.FieldName = "Kode"
    Me.gcKode.Name = "gcKode"
    Me.gcKode.Visible = True
    Me.gcKode.VisibleIndex = 0
    Me.gcKode.Width = 276
    '
    'gcNama
    '
    Me.gcNama.Caption = "Nama"
    Me.gcNama.FieldName = "Nama"
    Me.gcNama.Name = "gcNama"
    Me.gcNama.Visible = True
    Me.gcNama.VisibleIndex = 1
    Me.gcNama.Width = 802
    '
    'colAkunNama
    '
    Me.colAkunNama.Caption = "Nama Akun"
    Me.colAkunNama.FieldName = "Akun.Nama"
    Me.colAkunNama.Name = "colAkunNama"
    Me.colAkunNama.OptionsColumn.AllowEdit = False
    Me.colAkunNama.OptionsColumn.ReadOnly = True
    Me.colAkunNama.Visible = True
    Me.colAkunNama.VisibleIndex = 1
    Me.colAkunNama.Width = 177
    '
    'colDebit
    '
    Me.colDebit.AppearanceCell.Options.UseTextOptions = True
    Me.colDebit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colDebit.AppearanceHeader.Options.UseTextOptions = True
    Me.colDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colDebit.Caption = "Jumlah [D]"
    Me.colDebit.ColumnEdit = Me.colDebitRepo
    Me.colDebit.FieldName = "Debit"
    Me.colDebit.Name = "colDebit"
    Me.colDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colDebit.Visible = True
    Me.colDebit.VisibleIndex = 2
    Me.colDebit.Width = 66
    '
    'colDebitRepo
    '
    Me.colDebitRepo.AutoHeight = False
    Me.colDebitRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colDebitRepo.Name = "colDebitRepo"
    '
    'colKredit
    '
    Me.colKredit.AppearanceCell.Options.UseTextOptions = True
    Me.colKredit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colKredit.AppearanceHeader.Options.UseTextOptions = True
    Me.colKredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colKredit.Caption = "Jumlah [K]"
    Me.colKredit.ColumnEdit = Me.colKreditRepo
    Me.colKredit.FieldName = "Kredit"
    Me.colKredit.Name = "colKredit"
    Me.colKredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colKredit.Visible = True
    Me.colKredit.VisibleIndex = 3
    Me.colKredit.Width = 66
    '
    'colKreditRepo
    '
    Me.colKreditRepo.AutoHeight = False
    Me.colKreditRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKreditRepo.Name = "colKreditRepo"
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.ColumnEdit = Me.colUangRepo
    Me.colUang.FieldName = "MataUang!"
    Me.colUang.Name = "colUang"
    Me.colUang.OptionsColumn.AllowEdit = False
    Me.colUang.OptionsColumn.ReadOnly = True
    Me.colUang.Width = 40
    '
    'colUangRepo
    '
    Me.colUangRepo.AutoHeight = False
    Me.colUangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colUangRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.colUangRepo.DisplayMember = "Kode"
    Me.colUangRepo.Name = "colUangRepo"
    Me.colUangRepo.NullText = "<Uang>"
    Me.colUangRepo.ValueMember = "This"
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs"
    Me.colKurs.DisplayFormat.FormatString = "n2"
    Me.colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Width = 54
    '
    'colValasDebit
    '
    Me.colValasDebit.AppearanceCell.Options.UseTextOptions = True
    Me.colValasDebit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colValasDebit.AppearanceHeader.Options.UseTextOptions = True
    Me.colValasDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colValasDebit.Caption = "Valas Debit"
    Me.colValasDebit.FieldName = "DebitValas"
    Me.colValasDebit.Name = "colValasDebit"
    Me.colValasDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colValasDebit.Width = 63
    '
    'colValasKredit
    '
    Me.colValasKredit.AppearanceCell.Options.UseTextOptions = True
    Me.colValasKredit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colValasKredit.AppearanceHeader.Options.UseTextOptions = True
    Me.colValasKredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colValasKredit.Caption = "Valas Kredit"
    Me.colValasKredit.FieldName = "KreditValas"
    Me.colValasKredit.Name = "colValasKredit"
    Me.colValasKredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colValasKredit.Width = 65
    '
    'colCatatan
    '
    Me.colCatatan.Caption = "Catatan"
    Me.colCatatan.FieldName = "Keterangan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 6
    Me.colCatatan.Width = 70
    '
    'colDivisi
    '
    Me.colDivisi.Caption = "Divisi"
    Me.colDivisi.ColumnEdit = Me.colDivisiRepo
    Me.colDivisi.FieldName = "Divisi!"
    Me.colDivisi.Name = "colDivisi"
    Me.colDivisi.Width = 92
    '
    'colDivisiRepo
    '
    Me.colDivisiRepo.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
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
    Me.colProyek.VisibleIndex = 4
    Me.colProyek.Width = 81
    '
    'colProyekRepo
    '
    Me.colProyekRepo.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
    Me.colProyekRepo.AutoHeight = False
    Me.colProyekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colProyekRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 70, "Nama")})
    Me.colProyekRepo.DisplayMember = "Kode"
    Me.colProyekRepo.Name = "colProyekRepo"
    Me.colProyekRepo.NullText = "<Pilih Proyek>"
    Me.colProyekRepo.ValueMember = "This"
    '
    'colProyekSub
    '
    Me.colProyekSub.Caption = "Sub Proyek"
    Me.colProyekSub.ColumnEdit = Me.colProyekSubRepo
    Me.colProyekSub.FieldName = "ProyekSub!"
    Me.colProyekSub.Name = "colProyekSub"
    Me.colProyekSub.Visible = True
    Me.colProyekSub.VisibleIndex = 5
    Me.colProyekSub.Width = 108
    '
    'colProyekSubRepo
    '
    Me.colProyekSubRepo.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
    Me.colProyekSubRepo.AutoHeight = False
    Me.colProyekSubRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colProyekSubRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 50, "Nama")})
    Me.colProyekSubRepo.DisplayMember = "Kode"
    Me.colProyekSubRepo.Name = "colProyekSubRepo"
    Me.colProyekSubRepo.NullText = "<Pilih Sub Proyek>"
    Me.colProyekSubRepo.ValueMember = "This"
    '
    'colAPP
    '
    Me.colAPP.Caption = "No APP"
    Me.colAPP.ColumnEdit = Me.colAPPrepo
    Me.colAPP.FieldName = "NomorAPP!"
    Me.colAPP.Name = "colAPP"
    Me.colAPP.Visible = True
    Me.colAPP.VisibleIndex = 7
    Me.colAPP.Width = 149
    '
    'colAPPrepo
    '
    Me.colAPPrepo.AutoHeight = False
    Me.colAPPrepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colAPPrepo.DisplayMember = "Kode"
    Me.colAPPrepo.Name = "colAPPrepo"
    Me.colAPPrepo.NullText = "<Pilih No. APP>"
    Me.colAPPrepo.ValueMember = "This"
    Me.colAPPrepo.View = Me.colAPPRepoGrid
    '
    'colAPPRepoGrid
    '
    Me.colAPPRepoGrid.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.colAPPRepoGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.colAPPRepoGrid.Name = "colAPPRepoGrid"
    Me.colAPPRepoGrid.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.colAPPRepoGrid.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "No Bukti"
    Me.GridColumn1.FieldName = "Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 293
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tanggal"
    Me.GridColumn2.DisplayFormat.FormatString = "dd-MMM-yy"
    Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn2.FieldName = "Tanggal"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 519
    '
    'colAPPTanggal
    '
    Me.colAPPTanggal.Caption = "Tgl APP"
    Me.colAPPTanggal.DisplayFormat.FormatString = "dd-MMM-yy"
    Me.colAPPTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colAPPTanggal.FieldName = "NomorAPP.Tanggal"
    Me.colAPPTanggal.Name = "colAPPTanggal"
    Me.colAPPTanggal.OptionsColumn.AllowEdit = False
    Me.colAPPTanggal.OptionsColumn.ReadOnly = True
    Me.colAPPTanggal.Visible = True
    Me.colAPPTanggal.VisibleIndex = 8
    '
    'colAPPNilai
    '
    Me.colAPPNilai.Caption = "Nilai APP"
    Me.colAPPNilai.DisplayFormat.FormatString = "n2"
    Me.colAPPNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colAPPNilai.FieldName = "NomorAPP.Saldo"
    Me.colAPPNilai.Name = "colAPPNilai"
    Me.colAPPNilai.OptionsColumn.AllowEdit = False
    Me.colAPPNilai.OptionsColumn.ReadOnly = True
    Me.colAPPNilai.Visible = True
    Me.colAPPNilai.VisibleIndex = 9
    '
    'colDBMutasi
    '
    Me.colDBMutasi.Caption = "DB Mutasi APP"
    Me.colDBMutasi.FieldName = "DBMutasiAPP"
    Me.colDBMutasi.Name = "colDBMutasi"
    Me.colDBMutasi.Visible = True
    Me.colDBMutasi.VisibleIndex = 10
    '
    'colBPLain
    '
    Me.colBPLain.Caption = "B/P Lain"
    Me.colBPLain.FieldName = "BPLain"
    Me.colBPLain.Name = "colBPLain"
    Me.colBPLain.Visible = True
    Me.colBPLain.VisibleIndex = 11
    '
    'colBersihDibayar
    '
    Me.colBersihDibayar.Caption = "Bersih Dibayar"
    Me.colBersihDibayar.FieldName = "BersihDibayar"
    Me.colBersihDibayar.Name = "colBersihDibayar"
    Me.colBersihDibayar.OptionsColumn.AllowEdit = False
    Me.colBersihDibayar.OptionsColumn.ReadOnly = True
    Me.colBersihDibayar.Visible = True
    Me.colBersihDibayar.VisibleIndex = 12
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(751, 61)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(120, 20)
    Me.txtRegional.StyleController = Me.lytTransaksiJU
    Me.txtRegional.TabIndex = 4
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(751, 37)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(120, 20)
    Me.txtTanggal.StyleController = Me.lytTransaksiJU
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
    Me.btnRefreshNomor.StyleController = Me.lytTransaksiJU
    Me.btnRefreshNomor.TabIndex = 3
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(960, 37)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Size = New System.Drawing.Size(120, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksiJU
    Me.txtNoTransaksi.TabIndex = 2
    '
    'txtCatatan
    '
    Me.txtCatatan.Location = New System.Drawing.Point(102, 374)
    Me.txtCatatan.MenuManager = Me.barMan
    Me.txtCatatan.Name = "txtCatatan"
    Me.txtCatatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCatatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCatatan.Properties.PopupFormMinSize = New System.Drawing.Size(200, 100)
    Me.txtCatatan.Properties.PopupFormSize = New System.Drawing.Size(376, 100)
    Me.txtCatatan.Size = New System.Drawing.Size(1014, 20)
    Me.txtCatatan.StyleController = Me.lytTransaksiJU
    Me.txtCatatan.TabIndex = 7
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(56, 37)
    Me.txtKontak.MenuManager = Me.barMan
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Kontak>"
    Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(150, 0)
    Me.txtKontak.Properties.ShowClearButton = False
    Me.txtKontak.Properties.ShowFooter = False
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(160, 20)
    Me.txtKontak.StyleController = Me.lytTransaksiJU
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
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlItem4, Me.layCatatan, Me.LayoutControlItem3, Me.EmptySpaceItem3})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.xGrid
    Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 119)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(1108, 243)
    Me.LayoutControlItem1.Text = "LayoutControlItem1"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextToControlDistance = 0
    Me.LayoutControlItem1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.lytRegional, Me.EmptySpaceItem2, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem5})
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
    Me.layKontak.Size = New System.Drawing.Size(202, 48)
    Me.layKontak.Text = "Kontak"
    Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layKontak.TextSize = New System.Drawing.Size(33, 13)
    Me.layKontak.TextToControlDistance = 5
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(685, 0)
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
    Me.LayoutControlItem16.Location = New System.Drawing.Point(857, 0)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(209, 24)
    Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem16.Text = "No. Transaksi"
    Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(65, 13)
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
    Me.lytRegional.Location = New System.Drawing.Point(685, 24)
    Me.lytRegional.Name = "lytRegional"
    Me.lytRegional.Size = New System.Drawing.Size(172, 24)
    Me.lytRegional.Text = "Regional"
    Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.lytRegional.TextSize = New System.Drawing.Size(43, 13)
    Me.lytRegional.TextToControlDistance = 5
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(418, 0)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(267, 48)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.lblKontakNama
    Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(202, 0)
    Me.LayoutControlItem2.MinSize = New System.Drawing.Size(4, 17)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem2.Text = "LayoutControlItem2"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem2.TextToControlDistance = 0
    Me.LayoutControlItem2.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(202, 24)
    Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtStatus
    Me.LayoutControlItem5.CustomizationFormText = "Status"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(857, 24)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(209, 24)
    Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem5.Text = "Status"
    Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(65, 13)
    Me.LayoutControlItem5.TextToControlDistance = 5
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtUraian
    Me.LayoutControlItem4.CustomizationFormText = "Uraian"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 94)
    Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 25)
    Me.LayoutControlItem4.MinSize = New System.Drawing.Size(144, 25)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(1108, 25)
    Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem4.Text = "Uraian"
    Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(85, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
    '
    'layCatatan
    '
    Me.layCatatan.Control = Me.txtCatatan
    Me.layCatatan.CustomizationFormText = "Catatan"
    Me.layCatatan.Location = New System.Drawing.Point(0, 362)
    Me.layCatatan.Name = "layCatatan"
    Me.layCatatan.Size = New System.Drawing.Size(1108, 24)
    Me.layCatatan.Text = "Catatan"
    Me.layCatatan.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.layCatatan.TextSize = New System.Drawing.Size(85, 13)
    Me.layCatatan.TextToControlDistance = 5
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtPrint
    Me.LayoutControlItem3.CustomizationFormText = "Options Cetak"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 386)
    Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 29)
    Me.LayoutControlItem3.MinSize = New System.Drawing.Size(144, 29)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(554, 29)
    Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem3.Text = "Options Cetak"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(554, 386)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(554, 29)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
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
    'xMesitechBuktiKas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1134, 468)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "xMesitechBuktiKas"
    Me.Text = "Bukti Kas"
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
    CType(Me.lytTransaksiJU, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksiJU.ResumeLayout(False)
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colAkunRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDebitRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKreditRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colUangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colProyekRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colProyekSubRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colAPPrepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colAPPRepoGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layCatatan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents lytTransaksiJU As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
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
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colNoAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkunNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colValasDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colValasKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDivisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layCatatan As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colUangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colDivisiRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtCatatan As DevExpress.XtraEditors.MemoExEdit
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkunRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebitRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents colKreditRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents colProyek As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colProyekRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colAPP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAPPTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAPPNilai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDBMutasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBPLain As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBersihDibayar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAPPrepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents colAPPRepoGrid As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colProyekSub As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colProyekSubRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtPrint As DevExpress.XtraEditors.RadioGroup
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class