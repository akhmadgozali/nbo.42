<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_DPPembelianDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_DPPembelianDialog))
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
        Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
        Me.txtPOReffNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtPOGudang = New DevExpress.XtraEditors.TextEdit()
        Me.txtPOUraian = New DevExpress.XtraEditors.TextEdit()
        Me.txtPOTanggal = New DevExpress.XtraEditors.TextEdit()
        Me.xGridPO = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPPN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPPH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPajakInV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPajakOutV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProyek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustom1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustom2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustom3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustom4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustom5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPOKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
        Me.lblNilaiPO = New DevExpress.XtraEditors.LabelControl()
        Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNoFakturPajak = New DevExpress.XtraEditors.TextEdit()
        Me.txtJenisPajak = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNilaiPajak = New DevExpress.XtraEditors.TextEdit()
        Me.txtPajak = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNilaiDPValas = New DevExpress.XtraEditors.TextEdit()
        Me.txtKurs = New DevExpress.XtraEditors.TextEdit()
        Me.txtNilaiDP = New DevExpress.XtraEditors.TextEdit()
        Me.txtNilaiDPp = New DevExpress.XtraEditors.TextEdit()
        Me.txtNilaiPO = New DevExpress.XtraEditors.TextEdit()
        Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
        Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPO = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPOKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOUraian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lbNilaiPO = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
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
        CType(Me.txtPOReffNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoFakturPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJenisPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiDPValas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiDP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiDPp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbNilaiPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
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
        Me.lytTransaksi.Controls.Add(Me.txtPOReffNumber)
        Me.lytTransaksi.Controls.Add(Me.txtPOGudang)
        Me.lytTransaksi.Controls.Add(Me.txtPOUraian)
        Me.lytTransaksi.Controls.Add(Me.txtPOTanggal)
        Me.lytTransaksi.Controls.Add(Me.xGridPO)
        Me.lytTransaksi.Controls.Add(Me.txtPOKode)
        Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
        Me.lytTransaksi.Controls.Add(Me.lblNilaiPO)
        Me.lytTransaksi.Controls.Add(Me.txtStatus)
        Me.lytTransaksi.Controls.Add(Me.txtUang)
        Me.lytTransaksi.Controls.Add(Me.txtNoFakturPajak)
        Me.lytTransaksi.Controls.Add(Me.txtJenisPajak)
        Me.lytTransaksi.Controls.Add(Me.txtNilaiPajak)
        Me.lytTransaksi.Controls.Add(Me.txtPajak)
        Me.lytTransaksi.Controls.Add(Me.txtNilaiDPValas)
        Me.lytTransaksi.Controls.Add(Me.txtKurs)
        Me.lytTransaksi.Controls.Add(Me.txtNilaiDP)
        Me.lytTransaksi.Controls.Add(Me.txtNilaiDPp)
        Me.lytTransaksi.Controls.Add(Me.txtNilaiPO)
        Me.lytTransaksi.Controls.Add(Me.txtRegional)
        Me.lytTransaksi.Controls.Add(Me.txtTanggal)
        Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
        Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
        Me.lytTransaksi.Controls.Add(Me.txtUraian)
        Me.lytTransaksi.Controls.Add(Me.txtKontak)
        Me.lytTransaksi.Controls.Add(Me.txtPO)
        Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1})
        Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.lytTransaksi.Name = "lytTransaksi"
        Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(237, 342, 250, 350)
        Me.lytTransaksi.Root = Me.LayoutControlGroup1
        Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
        Me.lytTransaksi.TabIndex = 0
        Me.lytTransaksi.Text = "LayoutControl1"
        '
        'txtPOReffNumber
        '
        Me.txtPOReffNumber.Location = New System.Drawing.Point(648, 297)
        Me.txtPOReffNumber.MenuManager = Me.barMan
        Me.txtPOReffNumber.Name = "txtPOReffNumber"
        Me.txtPOReffNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPOReffNumber.Properties.ReadOnly = True
        Me.txtPOReffNumber.Size = New System.Drawing.Size(456, 20)
        Me.txtPOReffNumber.StyleController = Me.lytTransaksi
        Me.txtPOReffNumber.TabIndex = 19
        '
        'txtPOGudang
        '
        Me.txtPOGudang.Location = New System.Drawing.Point(648, 273)
        Me.txtPOGudang.MenuManager = Me.barMan
        Me.txtPOGudang.Name = "txtPOGudang"
        Me.txtPOGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPOGudang.Properties.ReadOnly = True
        Me.txtPOGudang.Size = New System.Drawing.Size(456, 20)
        Me.txtPOGudang.StyleController = Me.lytTransaksi
        Me.txtPOGudang.TabIndex = 18
        '
        'txtPOUraian
        '
        Me.txtPOUraian.Location = New System.Drawing.Point(106, 321)
        Me.txtPOUraian.MenuManager = Me.barMan
        Me.txtPOUraian.Name = "txtPOUraian"
        Me.txtPOUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPOUraian.Properties.ReadOnly = True
        Me.txtPOUraian.Size = New System.Drawing.Size(998, 20)
        Me.txtPOUraian.StyleController = Me.lytTransaksi
        Me.txtPOUraian.TabIndex = 17
        '
        'txtPOTanggal
        '
        Me.txtPOTanggal.Location = New System.Drawing.Point(106, 297)
        Me.txtPOTanggal.MenuManager = Me.barMan
        Me.txtPOTanggal.Name = "txtPOTanggal"
        Me.txtPOTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPOTanggal.Properties.ReadOnly = True
        Me.txtPOTanggal.Size = New System.Drawing.Size(456, 20)
        Me.txtPOTanggal.StyleController = Me.lytTransaksi
        Me.txtPOTanggal.TabIndex = 16
        '
        'xGridPO
        '
        Me.xGridPO.Location = New System.Drawing.Point(24, 345)
        Me.xGridPO.MainView = Me.xGridView
        Me.xGridPO.MenuManager = Me.barMan
        Me.xGridPO.Name = "xGridPO"
        Me.xGridPO.Size = New System.Drawing.Size(1080, 66)
        Me.xGridPO.TabIndex = 20
        Me.xGridPO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colHarga, Me.colDiscP, Me.colDisc, Me.colPPN, Me.colPPH, Me.colSubTotal, Me.colPajakInV, Me.colPajakOutV, Me.colTotal, Me.colCatatan, Me.colDivisi, Me.colProyek, Me.colCustom1, Me.colCustom2, Me.colCustom3, Me.colCustom4, Me.colCustom5})
        Me.xGridView.GridControl = Me.xGridPO
        Me.xGridView.Name = "xGridView"
        Me.xGridView.NewItemRowText = "Tambah Data"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsCustomization.AllowGroup = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colKodeBarang
        '
        Me.colKodeBarang.Caption = "Kode Barang"
        Me.colKodeBarang.FieldName = "Barang.Kode"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 0
        Me.colKodeBarang.Width = 90
        '
        'colNamaBarang
        '
        Me.colNamaBarang.Caption = "Nama Barang"
        Me.colNamaBarang.FieldName = "Barang.Nama"
        Me.colNamaBarang.Name = "colNamaBarang"
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
        Me.colQty.DisplayFormat.FormatString = "n0"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowSize = False
        Me.colQty.OptionsColumn.FixedWidth = True
        Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
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
        Me.colSatuan.FieldName = "Satuan.Kode"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 3
        Me.colSatuan.Width = 69
        '
        'colHarga
        '
        Me.colHarga.Caption = "Harga"
        Me.colHarga.DisplayFormat.FormatString = "n0"
        Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHarga.FieldName = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 4
        Me.colHarga.Width = 78
        '
        'colDiscP
        '
        Me.colDiscP.Caption = "Disc [%]"
        Me.colDiscP.FieldName = "DiscountPersen"
        Me.colDiscP.Name = "colDiscP"
        Me.colDiscP.Visible = True
        Me.colDiscP.VisibleIndex = 5
        '
        'colDisc
        '
        Me.colDisc.Caption = "Disc"
        Me.colDisc.DisplayFormat.FormatString = "n0"
        Me.colDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDisc.FieldName = "Discount"
        Me.colDisc.Name = "colDisc"
        '
        'colPPN
        '
        Me.colPPN.Caption = "Pajak IN"
        Me.colPPN.FieldName = "PPN.Kode"
        Me.colPPN.Name = "colPPN"
        Me.colPPN.Visible = True
        Me.colPPN.VisibleIndex = 6
        Me.colPPN.Width = 72
        '
        'colPPH
        '
        Me.colPPH.Caption = "Pajak Out"
        Me.colPPH.FieldName = "PPH.Kode"
        Me.colPPH.Name = "colPPH"
        Me.colPPH.Visible = True
        Me.colPPH.VisibleIndex = 7
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "Sub Total"
        Me.colSubTotal.DisplayFormat.FormatString = "n0"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        '
        'colPajakInV
        '
        Me.colPajakInV.Caption = "Pajak IN"
        Me.colPajakInV.FieldName = "PPNv"
        Me.colPajakInV.Name = "colPajakInV"
        '
        'colPajakOutV
        '
        Me.colPajakOutV.Caption = "Pajak Out"
        Me.colPajakOutV.FieldName = "PPHv"
        Me.colPajakOutV.Name = "colPajakOutV"
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "n0"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowEdit = False
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n0}")})
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 8
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
        Me.colCatatan.VisibleIndex = 9
        Me.colCatatan.Width = 204
        '
        'colDivisi
        '
        Me.colDivisi.Caption = "Divisi"
        Me.colDivisi.FieldName = "Divisi.Kode"
        Me.colDivisi.Name = "colDivisi"
        Me.colDivisi.Visible = True
        Me.colDivisi.VisibleIndex = 10
        Me.colDivisi.Width = 71
        '
        'colProyek
        '
        Me.colProyek.Caption = "Proyek"
        Me.colProyek.FieldName = "Proyek.Kode"
        Me.colProyek.Name = "colProyek"
        Me.colProyek.Visible = True
        Me.colProyek.VisibleIndex = 11
        Me.colProyek.Width = 85
        '
        'colCustom1
        '
        Me.colCustom1.Caption = "Custom1"
        Me.colCustom1.FieldName = "Barang.Custom1"
        Me.colCustom1.Name = "colCustom1"
        '
        'colCustom2
        '
        Me.colCustom2.Caption = "Custom2"
        Me.colCustom2.FieldName = "Barang.Custom2"
        Me.colCustom2.Name = "colCustom2"
        '
        'colCustom3
        '
        Me.colCustom3.Caption = "Custom3"
        Me.colCustom3.FieldName = "Barang.Custom3"
        Me.colCustom3.Name = "colCustom3"
        '
        'colCustom4
        '
        Me.colCustom4.Caption = "Custom4"
        Me.colCustom4.FieldName = "Barang.Custom4"
        Me.colCustom4.Name = "colCustom4"
        '
        'colCustom5
        '
        Me.colCustom5.Caption = "Custom5"
        Me.colCustom5.FieldName = "Barang.Custom5"
        Me.colCustom5.Name = "colCustom5"
        '
        'txtPOKode
        '
        Me.txtPOKode.Location = New System.Drawing.Point(106, 273)
        Me.txtPOKode.MenuManager = Me.barMan
        Me.txtPOKode.Name = "txtPOKode"
        Me.txtPOKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPOKode.Properties.ReadOnly = True
        Me.txtPOKode.Size = New System.Drawing.Size(456, 20)
        Me.txtPOKode.StyleController = Me.lytTransaksi
        Me.txtPOKode.TabIndex = 15
        '
        'lblKontakNama
        '
        Me.lblKontakNama.Location = New System.Drawing.Point(257, 37)
        Me.lblKontakNama.Name = "lblKontakNama"
        Me.lblKontakNama.Size = New System.Drawing.Size(282, 27)
        Me.lblKontakNama.StyleController = Me.lytTransaksi
        Me.lblKontakNama.TabIndex = 21
        '
        'lblNilaiPO
        '
        Me.lblNilaiPO.Location = New System.Drawing.Point(687, 106)
        Me.lblNilaiPO.Name = "lblNilaiPO"
        Me.lblNilaiPO.Size = New System.Drawing.Size(429, 23)
        Me.lblNilaiPO.StyleController = Me.lytTransaksi
        Me.lblNilaiPO.TabIndex = 23
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(981, 61)
        Me.txtStatus.MenuManager = Me.barMan
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
        Me.txtStatus.Properties.DisplayMember = "Value"
        Me.txtStatus.Properties.NullText = "<Status>"
        Me.txtStatus.Properties.ValueMember = "Key"
        Me.txtStatus.Size = New System.Drawing.Size(99, 20)
        Me.txtStatus.StyleController = Me.lytTransaksi
        Me.txtStatus.TabIndex = 5
        '
        'txtUang
        '
        Me.txtUang.Location = New System.Drawing.Point(95, 135)
        Me.txtUang.MenuManager = Me.barMan
        Me.txtUang.Name = "txtUang"
        Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtUang.Properties.DisplayMember = "Kode"
        Me.txtUang.Properties.NullText = "<Uang>"
        Me.txtUang.Properties.ReadOnly = True
        Me.txtUang.Properties.ValueMember = "This"
        Me.txtUang.Size = New System.Drawing.Size(188, 20)
        Me.txtUang.StyleController = Me.lytTransaksi
        Me.txtUang.TabIndex = 14
        '
        'txtNoFakturPajak
        '
        Me.txtNoFakturPajak.Location = New System.Drawing.Point(524, 205)
        Me.txtNoFakturPajak.MenuManager = Me.barMan
        Me.txtNoFakturPajak.Name = "txtNoFakturPajak"
        Me.txtNoFakturPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNoFakturPajak.Properties.NullText = "<Masukkan Nomor Faktur Pajak>"
        Me.txtNoFakturPajak.Size = New System.Drawing.Size(151, 20)
        Me.txtNoFakturPajak.StyleController = Me.lytTransaksi
        Me.txtNoFakturPajak.TabIndex = 14
        '
        'txtJenisPajak
        '
        Me.txtJenisPajak.Location = New System.Drawing.Point(524, 181)
        Me.txtJenisPajak.MenuManager = Me.barMan
        Me.txtJenisPajak.Name = "txtJenisPajak"
        Me.txtJenisPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtJenisPajak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJenisPajak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
        Me.txtJenisPajak.Properties.DisplayMember = "Value"
        Me.txtJenisPajak.Properties.NullText = "<Pilih Jenis Pajak>"
        Me.txtJenisPajak.Properties.ValueMember = "Key"
        Me.txtJenisPajak.Size = New System.Drawing.Size(151, 20)
        Me.txtJenisPajak.StyleController = Me.lytTransaksi
        Me.txtJenisPajak.TabIndex = 13
        '
        'txtNilaiPajak
        '
        Me.txtNilaiPajak.Location = New System.Drawing.Point(524, 157)
        Me.txtNilaiPajak.MenuManager = Me.barMan
        Me.txtNilaiPajak.Name = "txtNilaiPajak"
        Me.txtNilaiPajak.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNilaiPajak.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNilaiPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNilaiPajak.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txtNilaiPajak.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiPajak.Properties.Mask.EditMask = "n2"
        Me.txtNilaiPajak.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiPajak.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNilaiPajak.Properties.NullText = "0"
        Me.txtNilaiPajak.Properties.ReadOnly = True
        Me.txtNilaiPajak.Size = New System.Drawing.Size(151, 20)
        Me.txtNilaiPajak.StyleController = Me.lytTransaksi
        Me.txtNilaiPajak.TabIndex = 12
        '
        'txtPajak
        '
        Me.txtPajak.Location = New System.Drawing.Point(524, 133)
        Me.txtPajak.MenuManager = Me.barMan
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPajak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPajak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
        Me.txtPajak.Properties.DisplayMember = "Kode"
        Me.txtPajak.Properties.NullText = "<Pilih Pajak>"
        Me.txtPajak.Properties.ValueMember = "This"
        Me.txtPajak.Size = New System.Drawing.Size(151, 20)
        Me.txtPajak.StyleController = Me.lytTransaksi
        Me.txtPajak.TabIndex = 11
        '
        'txtNilaiDPValas
        '
        Me.txtNilaiDPValas.Location = New System.Drawing.Point(92, 106)
        Me.txtNilaiDPValas.MenuManager = Me.barMan
        Me.txtNilaiDPValas.Name = "txtNilaiDPValas"
        Me.txtNilaiDPValas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNilaiDPValas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNilaiDPValas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNilaiDPValas.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txtNilaiDPValas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiDPValas.Properties.Mask.EditMask = "n2"
        Me.txtNilaiDPValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiDPValas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNilaiDPValas.Properties.NullText = "0"
        Me.txtNilaiDPValas.Properties.ReadOnly = True
        Me.txtNilaiDPValas.Size = New System.Drawing.Size(160, 20)
        Me.txtNilaiDPValas.StyleController = Me.lytTransaksi
        Me.txtNilaiDPValas.TabIndex = 6
        '
        'txtKurs
        '
        Me.txtKurs.Location = New System.Drawing.Point(92, 178)
        Me.txtKurs.MenuManager = Me.barMan
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKurs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtKurs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtKurs.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txtKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKurs.Properties.Mask.EditMask = "n2"
        Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtKurs.Properties.NullText = "0"
        Me.txtKurs.Size = New System.Drawing.Size(160, 20)
        Me.txtKurs.StyleController = Me.lytTransaksi
        Me.txtKurs.TabIndex = 9
        '
        'txtNilaiDP
        '
        Me.txtNilaiDP.Location = New System.Drawing.Point(92, 154)
        Me.txtNilaiDP.MenuManager = Me.barMan
        Me.txtNilaiDP.Name = "txtNilaiDP"
        Me.txtNilaiDP.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNilaiDP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNilaiDP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNilaiDP.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txtNilaiDP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiDP.Properties.Mask.EditMask = "n2"
        Me.txtNilaiDP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiDP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNilaiDP.Properties.NullText = "0"
        Me.txtNilaiDP.Properties.ReadOnly = True
        Me.txtNilaiDP.Size = New System.Drawing.Size(160, 20)
        Me.txtNilaiDP.StyleController = Me.lytTransaksi
        Me.txtNilaiDP.TabIndex = 8
        '
        'txtNilaiDPp
        '
        Me.txtNilaiDPp.Location = New System.Drawing.Point(92, 130)
        Me.txtNilaiDPp.MenuManager = Me.barMan
        Me.txtNilaiDPp.Name = "txtNilaiDPp"
        Me.txtNilaiDPp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNilaiDPp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNilaiDPp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNilaiDPp.Properties.Mask.EditMask = "n"
        Me.txtNilaiDPp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiDPp.Properties.NullText = "0"
        Me.txtNilaiDPp.Size = New System.Drawing.Size(160, 20)
        Me.txtNilaiDPp.StyleController = Me.lytTransaksi
        Me.txtNilaiDPp.TabIndex = 7
        '
        'txtNilaiPO
        '
        Me.txtNilaiPO.Location = New System.Drawing.Point(92, 106)
        Me.txtNilaiPO.MenuManager = Me.barMan
        Me.txtNilaiPO.Name = "txtNilaiPO"
        Me.txtNilaiPO.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNilaiPO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNilaiPO.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txtNilaiPO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiPO.Properties.Mask.EditMask = "n2"
        Me.txtNilaiPO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiPO.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNilaiPO.Properties.NullText = "0"
        Me.txtNilaiPO.Properties.ReadOnly = True
        Me.txtNilaiPO.Size = New System.Drawing.Size(160, 20)
        Me.txtNilaiPO.StyleController = Me.lytTransaksi
        Me.txtNilaiPO.TabIndex = 11
        '
        'txtRegional
        '
        Me.txtRegional.Location = New System.Drawing.Point(814, 61)
        Me.txtRegional.MenuManager = Me.barMan
        Me.txtRegional.Name = "txtRegional"
        Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
        Me.txtRegional.Properties.DisplayMember = "Nama"
        Me.txtRegional.Properties.NullText = "<Pilih Regional>"
        Me.txtRegional.Properties.ValueMember = "This"
        Me.txtRegional.Size = New System.Drawing.Size(100, 20)
        Me.txtRegional.StyleController = Me.lytTransaksi
        Me.txtRegional.TabIndex = 3
        '
        'txtTanggal
        '
        Me.txtTanggal.EditValue = Nothing
        Me.txtTanggal.Location = New System.Drawing.Point(814, 37)
        Me.txtTanggal.MenuManager = Me.barMan
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
        Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTanggal.Size = New System.Drawing.Size(100, 20)
        Me.txtTanggal.StyleController = Me.lytTransaksi
        Me.txtTanggal.TabIndex = 2
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
        Me.btnRefreshNomor.TabIndex = 22
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.Location = New System.Drawing.Point(981, 37)
        Me.txtNoTransaksi.MenuManager = Me.barMan
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNoTransaksi.Size = New System.Drawing.Size(99, 20)
        Me.txtNoTransaksi.StyleController = Me.lytTransaksi
        Me.txtNoTransaksi.TabIndex = 4
        '
        'txtUraian
        '
        Me.txtUraian.Location = New System.Drawing.Point(92, 202)
        Me.txtUraian.MenuManager = Me.barMan
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUraian.Properties.MaxLength = 255
        Me.txtUraian.Properties.NullText = "<Masukkan Uraian>"
        Me.txtUraian.Size = New System.Drawing.Size(330, 20)
        Me.txtUraian.StyleController = Me.lytTransaksi
        Me.txtUraian.TabIndex = 10
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
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(93, 61)
        Me.txtPO.MenuManager = Me.barMan
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPO.Properties.DisplayMember = "Kode"
        Me.txtPO.Properties.NullText = "<Pilih No PO>"
        Me.txtPO.Properties.ValueMember = "This"
        Me.txtPO.Properties.View = Me.GridView1
        Me.txtPO.Size = New System.Drawing.Size(160, 20)
        Me.txtPO.StyleController = Me.lytTransaksi
        Me.txtPO.TabIndex = 1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPOKode, Me.colPOTanggal, Me.colPOUraian})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPOKode
        '
        Me.colPOKode.Caption = "Kode"
        Me.colPOKode.FieldName = "Kode"
        Me.colPOKode.Name = "colPOKode"
        Me.colPOKode.Visible = True
        Me.colPOKode.VisibleIndex = 0
        Me.colPOKode.Width = 90
        '
        'colPOTanggal
        '
        Me.colPOTanggal.Caption = "Tanggal"
        Me.colPOTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colPOTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPOTanggal.FieldName = "Tanggal"
        Me.colPOTanggal.Name = "colPOTanggal"
        Me.colPOTanggal.Visible = True
        Me.colPOTanggal.VisibleIndex = 1
        Me.colPOTanggal.Width = 90
        '
        'colPOUraian
        '
        Me.colPOUraian.Caption = "Uraian"
        Me.colPOUraian.FieldName = "Uraian"
        Me.colPOUraian.Name = "colPOUraian"
        Me.colPOUraian.Visible = True
        Me.colPOUraian.VisibleIndex = 2
        Me.colPOUraian.Width = 204
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtUang
        Me.LayoutControlItem2.CustomizationFormText = "Mata Uang"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(243, 48)
        Me.LayoutControlItem2.Text = "Mata Uang"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNilaiPO
        Me.LayoutControlItem1.CustomizationFormText = "Nilai PO"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(244, 24)
        Me.LayoutControlItem1.Text = "Nilai PO"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem9, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem18, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlGroup4, Me.EmptySpaceItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
        Me.LayoutControlGroup1.Text = "Root"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem7, Me.lytRegional, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlItem10, Me.lbNilaiPO})
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
        Me.layKontak.Size = New System.Drawing.Size(239, 24)
        Me.layKontak.Text = "Vendor   "
        Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layKontak.TextSize = New System.Drawing.Size(70, 13)
        Me.layKontak.TextToControlDistance = 5
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtTanggal
        Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(748, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(152, 24)
        Me.LayoutControlItem15.Text = "Tanggal    "
        Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(43, 13)
        Me.LayoutControlItem15.TextToControlDistance = 5
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtNoTransaksi
        Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(900, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(166, 24)
        Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem16.Text = "No. Bukti    "
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
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.lblKontakNama
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(239, 0)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(4, 17)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(286, 31)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'lytRegional
        '
        Me.lytRegional.Control = Me.txtRegional
        Me.lytRegional.CustomizationFormText = "Regional"
        Me.lytRegional.Location = New System.Drawing.Point(748, 24)
        Me.lytRegional.Name = "lytRegional"
        Me.lytRegional.Size = New System.Drawing.Size(152, 24)
        Me.lytRegional.Text = "Regional"
        Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lytRegional.TextSize = New System.Drawing.Size(43, 13)
        Me.lytRegional.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtStatus
        Me.LayoutControlItem4.CustomizationFormText = "Status"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(900, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(166, 24)
        Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem4.Text = "Status     "
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(43, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(525, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(223, 48)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem10.Control = Me.txtPO
        Me.LayoutControlItem10.CustomizationFormText = "Pajak"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(239, 24)
        Me.LayoutControlItem10.Text = "Ambil No. PO   "
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(70, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'lbNilaiPO
        '
        Me.lbNilaiPO.AllowHotTrack = False
        Me.lbNilaiPO.CustomizationFormText = "-"
        Me.lbNilaiPO.Location = New System.Drawing.Point(239, 31)
        Me.lbNilaiPO.Name = "lbNilaiPO"
        Me.lbNilaiPO.Size = New System.Drawing.Size(286, 17)
        Me.lbNilaiPO.Text = "-"
        Me.lbNilaiPO.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup3.CustomizationFormText = "Pajak"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(414, 94)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(261, 131)
        Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlGroup3.Text = "Pajak"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtPajak
        Me.LayoutControlItem11.CustomizationFormText = "Pajak"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem11.Text = "Pajak"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtNilaiPajak
        Me.LayoutControlItem12.CustomizationFormText = "Nilai Pajak"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem12.Text = "Nilai Pajak"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtJenisPajak
        Me.LayoutControlItem13.CustomizationFormText = "Jenis Pajak"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem13.Text = "Jenis Pajak"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtNoFakturPajak
        Me.LayoutControlItem14.CustomizationFormText = "No Faktur"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem14.Text = "No Faktur"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtNilaiDPValas
        Me.LayoutControlItem9.CustomizationFormText = "Nilai DP [Valas]"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(244, 24)
        Me.LayoutControlItem9.Text = "Nilai DP [Valas]   "
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtNilaiDPp
        Me.LayoutControlItem5.CustomizationFormText = "Nilai DP"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 118)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(244, 24)
        Me.LayoutControlItem5.Text = "Nilai DP [%]"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtNilaiDP
        Me.LayoutControlItem6.CustomizationFormText = "Nilai DP"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(244, 24)
        Me.LayoutControlItem6.Text = "Nilai DP"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtKurs
        Me.LayoutControlItem8.CustomizationFormText = "Kurs [Pajak]"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 166)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(244, 24)
        Me.LayoutControlItem8.Text = "Kurs [Pajak]"
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.lblNilaiPO
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(675, 94)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(433, 27)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(433, 27)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(433, 131)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "LayoutControlItem18"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextToControlDistance = 0
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(244, 94)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(170, 96)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtUraian
        Me.LayoutControlItem3.CustomizationFormText = "Uraian"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 190)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(414, 35)
        Me.LayoutControlItem3.Text = "Uraian"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup4.CustomizationFormText = "Informasi Order Pembelian [PO]"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem24, Me.LayoutControlItem23})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 230)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1108, 185)
        Me.LayoutControlGroup4.Text = "Informasi Order Pembelian [PO]"
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtPOKode
        Me.LayoutControlItem19.CustomizationFormText = "Nomor PO"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(542, 24)
        Me.LayoutControlItem19.Text = "Nomor PO"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.xGridPO
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(1084, 70)
        Me.LayoutControlItem20.Text = "LayoutControlItem20"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextToControlDistance = 0
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtPOTanggal
        Me.LayoutControlItem21.CustomizationFormText = "Tanggal"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(542, 24)
        Me.LayoutControlItem21.Text = "Tanggal"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtPOUraian
        Me.LayoutControlItem22.CustomizationFormText = "Uraian"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(1084, 24)
        Me.LayoutControlItem22.Text = "Uraian"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtPOReffNumber
        Me.LayoutControlItem24.CustomizationFormText = "Reff Number      "
        Me.LayoutControlItem24.Location = New System.Drawing.Point(542, 24)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(542, 24)
        Me.LayoutControlItem24.Text = "Reff Number      "
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtPOGudang
        Me.LayoutControlItem23.CustomizationFormText = "Gudang"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(542, 0)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(542, 24)
        Me.LayoutControlItem23.Text = "Gudang"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(79, 13)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 225)
        Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(0, 5)
        Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(10, 5)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(1108, 5)
        Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
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
        'UI_DPPembelianDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 468)
        Me.Controls.Add(Me.hideContainerRight)
        Me.KeyPreview = True
        Me.Name = "UI_DPPembelianDialog"
        Me.Text = "DP Pembelian"
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
        CType(Me.txtPOReffNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoFakturPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJenisPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiDPValas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiDP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiDPp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbNilaiPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
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
 Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
 Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents txtNilaiPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNilaiDPp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNilaiDP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNilaiDPValas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPajak As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtJenisPajak As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNoFakturPajak As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNilaiPajak As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblNilaiPO As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbNilaiPO As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPO As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPOKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOUraian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPOKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xGridPO As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPPN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPPH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPajakInV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPajakOutV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProyek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustom1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustom2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustom3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustom4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustom5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPOUraian As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPOTanggal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPOReffNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPOGudang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
End Class
