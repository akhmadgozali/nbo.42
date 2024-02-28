<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_TransaksiGLDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TransaksiGLDialog))
    Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
    Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
    Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
    Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
    Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
    Me.navInfo = New DevExpress.XtraNavBar.NavBarGroup()
    Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
    Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
    Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
    Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
    Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
    Me.xGHistory = New DevExpress.XtraGrid.GridControl()
    Me.xGHistoryView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.navHistory = New DevExpress.XtraNavBar.NavBarGroup()
    Me.navCatatan = New DevExpress.XtraNavBar.NavBarGroup()
    Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
    Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtValas = New DevExpress.XtraEditors.TextEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoAC = New DevExpress.XtraEditors.TextEdit()
    Me.txtCashAdvance = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.txtKontak = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtJatuhTempo = New DevExpress.XtraEditors.DateEdit()
    Me.txtAkunGiro = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtBank = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoCekGiro = New DevExpress.XtraEditors.TextEdit()
    Me.txtCaraBayar = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtCatatan = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colNoAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkunRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colAkunNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colValasDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colValasKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtMataUang = New DevExpress.XtraEditors.TextEdit()
    Me.txtKurs = New DevExpress.XtraEditors.TextEdit()
    Me.txtAkun = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtTipe = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layTipe = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layAkunKasBank = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layTipeEmpty = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.layMataUang = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layAkunKasBankNama = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layCatatan = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layKontakNama = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.SimpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleLabelItem4 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.layCashAdvance = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layCashAdvanceText = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layCaraBayar = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layCaraBayarDetail = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layJatuhTempo = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layAkunValas = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layKurs = New DevExpress.XtraLayout.LayoutControlItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
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
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtValas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoAC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCashAdvance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJatuhTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJatuhTempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkunGiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoCekGiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCaraBayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colAkunRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colUangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layTipe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layAkunKasBank, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layTipeEmpty, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layMataUang, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layAkunKasBankNama, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layCatatan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontakNama, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleLabelItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layCashAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layCashAdvanceText, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layCaraBayar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layCaraBayarDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layJatuhTempo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layAkunValas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKurs, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.hideContainerRight.Location = New System.Drawing.Point(1009, 0)
    Me.hideContainerRight.Name = "hideContainerRight"
    Me.hideContainerRight.Size = New System.Drawing.Size(19, 431)
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
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl21)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl18)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl19)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl17)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl16)
    Me.NavBarGroupControlContainer3.Name = "NavBarGroupControlContainer3"
    Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(234, 103)
    Me.NavBarGroupControlContainer3.TabIndex = 2
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
    'LabelControl18
    '
    Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl18.Location = New System.Drawing.Point(11, 66)
    Me.LabelControl18.Name = "LabelControl18"
    Me.LabelControl18.Size = New System.Drawing.Size(65, 13)
    Me.LabelControl18.TabIndex = 3
    Me.LabelControl18.Text = "Credit Limit"
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
    'LabelControl17
    '
    Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl17.Location = New System.Drawing.Point(11, 28)
    Me.LabelControl17.Name = "LabelControl17"
    Me.LabelControl17.Size = New System.Drawing.Size(51, 13)
    Me.LabelControl17.TabIndex = 1
    Me.LabelControl17.Text = "Saldo AR"
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
    Me.xGHistoryView.GridControl = Me.xGHistory
    Me.xGHistoryView.Name = "xGHistoryView"
    Me.xGHistoryView.OptionsDetail.EnableMasterViewMode = False
    Me.xGHistoryView.OptionsView.ShowGroupPanel = False
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
    Me.DockPanel2.OriginalSize = New System.Drawing.Size(1022, 425)
    Me.DockPanel2.Text = "DockPanel2"
    '
    'DockPanel2_Container
    '
    Me.DockPanel2_Container.Controls.Add(Me.LayoutControl1)
    Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
    Me.DockPanel2_Container.Name = "DockPanel2_Container"
    Me.DockPanel2_Container.Size = New System.Drawing.Size(1022, 425)
    Me.DockPanel2_Container.TabIndex = 0
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtValas)
    Me.LayoutControl1.Controls.Add(Me.txtRegional)
    Me.LayoutControl1.Controls.Add(Me.txtNoAC)
    Me.LayoutControl1.Controls.Add(Me.txtCashAdvance)
    Me.LayoutControl1.Controls.Add(Me.txtTanggal)
    Me.LayoutControl1.Controls.Add(Me.btnRefreshNomor)
    Me.LayoutControl1.Controls.Add(Me.txtNoTransaksi)
    Me.LayoutControl1.Controls.Add(Me.txtKontak)
    Me.LayoutControl1.Controls.Add(Me.txtJatuhTempo)
    Me.LayoutControl1.Controls.Add(Me.txtAkunGiro)
    Me.LayoutControl1.Controls.Add(Me.txtBank)
    Me.LayoutControl1.Controls.Add(Me.txtNoCekGiro)
    Me.LayoutControl1.Controls.Add(Me.txtCaraBayar)
    Me.LayoutControl1.Controls.Add(Me.txtCatatan)
    Me.LayoutControl1.Controls.Add(Me.xGrid)
    Me.LayoutControl1.Controls.Add(Me.txtMataUang)
    Me.LayoutControl1.Controls.Add(Me.txtKurs)
    Me.LayoutControl1.Controls.Add(Me.txtAkun)
    Me.LayoutControl1.Controls.Add(Me.txtUraian)
    Me.LayoutControl1.Controls.Add(Me.txtTipe)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(344, 276, 444, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(1022, 425)
    Me.LayoutControl1.TabIndex = 0
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtValas
    '
    Me.txtValas.Location = New System.Drawing.Point(904, 128)
    Me.txtValas.MenuManager = Me.barMan
    Me.txtValas.Name = "txtValas"
    Me.txtValas.Properties.Appearance.Options.UseTextOptions = True
    Me.txtValas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtValas.Properties.Mask.EditMask = "n2"
    Me.txtValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtValas.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtValas.Size = New System.Drawing.Size(106, 20)
    Me.txtValas.StyleController = Me.LayoutControl1
    Me.txtValas.TabIndex = 11
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(-195, 80)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(179, 20)
    Me.txtRegional.StyleController = Me.LayoutControl1
    Me.txtRegional.TabIndex = 4
    '
    'txtNoAC
    '
    Me.txtNoAC.Location = New System.Drawing.Point(142, 188)
    Me.txtNoAC.MenuManager = Me.barMan
    Me.txtNoAC.Name = "txtNoAC"
    Me.txtNoAC.Properties.MaxLength = 50
    Me.txtNoAC.Size = New System.Drawing.Size(192, 20)
    Me.txtNoAC.StyleController = Me.LayoutControl1
    Me.txtNoAC.TabIndex = 16
    '
    'txtCashAdvance
    '
    Me.txtCashAdvance.Location = New System.Drawing.Point(355, 80)
    Me.txtCashAdvance.MenuManager = Me.barMan
    Me.txtCashAdvance.Name = "txtCashAdvance"
    Me.txtCashAdvance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCashAdvance.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tanggal", "Tanggal", 30, DevExpress.Utils.FormatType.Custom, "dd MMM yyy", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kontak", 90, "Kontak")})
    Me.txtCashAdvance.Properties.DisplayMember = "Kode"
    Me.txtCashAdvance.Properties.NullText = "<Pilih No. Cash Advance>"
    Me.txtCashAdvance.Properties.PopupWidth = 500
    Me.txtCashAdvance.Properties.ValueMember = "Id"
    Me.txtCashAdvance.Size = New System.Drawing.Size(179, 20)
    Me.txtCashAdvance.StyleController = Me.LayoutControl1
    Me.txtCashAdvance.TabIndex = 6
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(608, 38)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(146, 20)
    Me.txtTanggal.StyleController = Me.LayoutControl1
    Me.txtTanggal.TabIndex = 1
    '
    'btnRefreshNomor
    '
    Me.btnRefreshNomor.AutoWidthInLayoutControl = True
    Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
    Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnRefreshNomor.Location = New System.Drawing.Point(973, 39)
    Me.btnRefreshNomor.Name = "btnRefreshNomor"
    Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
    Me.btnRefreshNomor.StyleController = Me.LayoutControl1
    Me.btnRefreshNomor.TabIndex = 3
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(823, 38)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Size = New System.Drawing.Size(146, 20)
    Me.txtNoTransaksi.StyleController = Me.LayoutControl1
    Me.txtNoTransaksi.TabIndex = 2
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(-277, 38)
    Me.txtKontak.MenuManager = Me.barMan
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Kontak>"
    Me.txtKontak.Properties.PopupWidth = 150
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Size = New System.Drawing.Size(146, 20)
    Me.txtKontak.StyleController = Me.LayoutControl1
    Me.txtKontak.TabIndex = 0
    '
    'txtJatuhTempo
    '
    Me.txtJatuhTempo.EditValue = Nothing
    Me.txtJatuhTempo.Location = New System.Drawing.Point(717, 164)
    Me.txtJatuhTempo.MenuManager = Me.barMan
    Me.txtJatuhTempo.Name = "txtJatuhTempo"
    Me.txtJatuhTempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtJatuhTempo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtJatuhTempo.Properties.DisplayFormat.FormatString = "D"
    Me.txtJatuhTempo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtJatuhTempo.Size = New System.Drawing.Size(262, 20)
    Me.txtJatuhTempo.StyleController = Me.LayoutControl1
    Me.txtJatuhTempo.TabIndex = 15
    '
    'txtAkunGiro
    '
    Me.txtAkunGiro.Location = New System.Drawing.Point(430, 188)
    Me.txtAkunGiro.MenuManager = Me.barMan
    Me.txtAkunGiro.Name = "txtAkunGiro"
    Me.txtAkunGiro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkunGiro.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "No. Akun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama Akun")})
    Me.txtAkunGiro.Properties.DisplayMember = "Kode"
    Me.txtAkunGiro.Properties.NullText = "<Pilih Akun Giro>"
    Me.txtAkunGiro.Properties.PopupWidth = 300
    Me.txtAkunGiro.Properties.ValueMember = "This"
    Me.txtAkunGiro.Size = New System.Drawing.Size(191, 20)
    Me.txtAkunGiro.StyleController = Me.LayoutControl1
    Me.txtAkunGiro.TabIndex = 17
    '
    'txtBank
    '
    Me.txtBank.Location = New System.Drawing.Point(430, 164)
    Me.txtBank.MenuManager = Me.barMan
    Me.txtBank.Name = "txtBank"
    Me.txtBank.Properties.MaxLength = 50
    Me.txtBank.Size = New System.Drawing.Size(191, 20)
    Me.txtBank.StyleController = Me.LayoutControl1
    Me.txtBank.TabIndex = 14
    '
    'txtNoCekGiro
    '
    Me.txtNoCekGiro.Location = New System.Drawing.Point(142, 164)
    Me.txtNoCekGiro.MenuManager = Me.barMan
    Me.txtNoCekGiro.Name = "txtNoCekGiro"
    Me.txtNoCekGiro.Properties.MaxLength = 50
    Me.txtNoCekGiro.Size = New System.Drawing.Size(192, 20)
    Me.txtNoCekGiro.StyleController = Me.LayoutControl1
    Me.txtNoCekGiro.TabIndex = 13
    '
    'txtCaraBayar
    '
    Me.txtCaraBayar.Location = New System.Drawing.Point(-195, 152)
    Me.txtCaraBayar.MenuManager = Me.barMan
    Me.txtCaraBayar.Name = "txtCaraBayar"
    Me.txtCaraBayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCaraBayar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtCaraBayar.Properties.DisplayMember = "Nama"
    Me.txtCaraBayar.Properties.NullText = "<Pilih Cara Pembayaran>"
    Me.txtCaraBayar.Properties.ShowHeader = False
    Me.txtCaraBayar.Properties.ValueMember = "Id"
    Me.txtCaraBayar.Size = New System.Drawing.Size(229, 20)
    Me.txtCaraBayar.StyleController = Me.LayoutControl1
    Me.txtCaraBayar.TabIndex = 12
    '
    'txtCatatan
    '
    Me.txtCatatan.Location = New System.Drawing.Point(-195, 376)
    Me.txtCatatan.MenuManager = Me.barMan
    Me.txtCatatan.Name = "txtCatatan"
    Me.txtCatatan.Properties.MaxLength = 255
    Me.txtCatatan.Size = New System.Drawing.Size(1205, 20)
    Me.txtCatatan.StyleController = Me.LayoutControl1
    Me.txtCatatan.TabIndex = 19
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(-287, 224)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colAkunRepo, Me.colDivisiRepo, Me.colUangRepo, Me.RepositoryItemCalcEdit1, Me.RepositoryItemCalcEdit2})
    Me.xGrid.Size = New System.Drawing.Size(1297, 143)
    Me.xGrid.TabIndex = 18
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoAkun, Me.colAkunNama, Me.colDebit, Me.colKredit, Me.colUang, Me.colKurs, Me.colValasDebit, Me.colValasKredit, Me.colDivisi, Me.colCatatan})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
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
    Me.colNoAkun.Width = 150
    '
    'colAkunRepo
    '
    Me.colAkunRepo.AutoHeight = False
    Me.colAkunRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colAkunRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "No. Akun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama Akun")})
    Me.colAkunRepo.DisplayMember = "Kode"
    Me.colAkunRepo.Name = "colAkunRepo"
    Me.colAkunRepo.NullText = "<Pilih Akun>"
    Me.colAkunRepo.PopupWidth = 300
    Me.colAkunRepo.ValueMember = "This"
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
    Me.colAkunNama.Width = 250
    '
    'colDebit
    '
    Me.colDebit.AppearanceCell.Options.UseTextOptions = True
    Me.colDebit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colDebit.AppearanceHeader.Options.UseTextOptions = True
    Me.colDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colDebit.Caption = "Jumlah [D]"
    Me.colDebit.ColumnEdit = Me.RepositoryItemCalcEdit1
    Me.colDebit.FieldName = "Debit"
    Me.colDebit.Name = "colDebit"
    Me.colDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colDebit.Visible = True
    Me.colDebit.VisibleIndex = 2
    Me.colDebit.Width = 80
    '
    'RepositoryItemCalcEdit1
    '
    Me.RepositoryItemCalcEdit1.AutoHeight = False
    Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
    '
    'colKredit
    '
    Me.colKredit.AppearanceCell.Options.UseTextOptions = True
    Me.colKredit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colKredit.AppearanceHeader.Options.UseTextOptions = True
    Me.colKredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colKredit.Caption = "Jumlah [K]"
    Me.colKredit.ColumnEdit = Me.RepositoryItemCalcEdit2
    Me.colKredit.FieldName = "Kredit"
    Me.colKredit.Name = "colKredit"
    Me.colKredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colKredit.Visible = True
    Me.colKredit.VisibleIndex = 3
    Me.colKredit.Width = 80
    '
    'RepositoryItemCalcEdit2
    '
    Me.RepositoryItemCalcEdit2.AutoHeight = False
    Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.ColumnEdit = Me.colUangRepo
    Me.colUang.FieldName = "MataUang!"
    Me.colUang.Name = "colUang"
    Me.colUang.OptionsColumn.AllowEdit = False
    Me.colUang.OptionsColumn.ReadOnly = True
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 4
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
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 5
    '
    'colValasDebit
    '
    Me.colValasDebit.AppearanceCell.Options.UseTextOptions = True
    Me.colValasDebit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colValasDebit.AppearanceHeader.Options.UseTextOptions = True
    Me.colValasDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colValasDebit.Caption = "Valas"
    Me.colValasDebit.FieldName = "DebitValas"
    Me.colValasDebit.Name = "colValasDebit"
    Me.colValasDebit.OptionsColumn.AllowEdit = False
    Me.colValasDebit.OptionsColumn.ReadOnly = True
    Me.colValasDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colValasDebit.Visible = True
    Me.colValasDebit.VisibleIndex = 6
    Me.colValasDebit.Width = 80
    '
    'colValasKredit
    '
    Me.colValasKredit.AppearanceCell.Options.UseTextOptions = True
    Me.colValasKredit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colValasKredit.AppearanceHeader.Options.UseTextOptions = True
    Me.colValasKredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colValasKredit.Caption = "Valas"
    Me.colValasKredit.FieldName = "KreditValas"
    Me.colValasKredit.Name = "colValasKredit"
    Me.colValasKredit.OptionsColumn.AllowEdit = False
    Me.colValasKredit.OptionsColumn.ReadOnly = True
    Me.colValasKredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colValasKredit.Visible = True
    Me.colValasKredit.VisibleIndex = 7
    Me.colValasKredit.Width = 80
    '
    'colDivisi
    '
    Me.colDivisi.Caption = "Divisi"
    Me.colDivisi.ColumnEdit = Me.colDivisiRepo
    Me.colDivisi.FieldName = "Divisi!"
    Me.colDivisi.Name = "colDivisi"
    Me.colDivisi.Visible = True
    Me.colDivisi.VisibleIndex = 8
    Me.colDivisi.Width = 110
    '
    'colDivisiRepo
    '
    Me.colDivisiRepo.AutoHeight = False
    Me.colDivisiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colDivisiRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colDivisiRepo.DisplayMember = "Kode"
    Me.colDivisiRepo.Name = "colDivisiRepo"
    Me.colDivisiRepo.NullText = "<Pilih Divisi>"
    Me.colDivisiRepo.ShowHeader = False
    Me.colDivisiRepo.ValueMember = "This"
    '
    'colCatatan
    '
    Me.colCatatan.Caption = "Catatan"
    Me.colCatatan.FieldName = "Keterangan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 9
    Me.colCatatan.Width = 174
    '
    'txtMataUang
    '
    Me.txtMataUang.Enabled = False
    Me.txtMataUang.Location = New System.Drawing.Point(613, 128)
    Me.txtMataUang.MenuManager = Me.barMan
    Me.txtMataUang.Name = "txtMataUang"
    Me.txtMataUang.Size = New System.Drawing.Size(66, 20)
    Me.txtMataUang.StyleController = Me.LayoutControl1
    Me.txtMataUang.TabIndex = 9
    '
    'txtKurs
    '
    Me.txtKurs.Location = New System.Drawing.Point(717, 128)
    Me.txtKurs.MenuManager = Me.barMan
    Me.txtKurs.Name = "txtKurs"
    Me.txtKurs.Properties.Appearance.Options.UseTextOptions = True
    Me.txtKurs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtKurs.Properties.Mask.EditMask = "n"
    Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtKurs.Size = New System.Drawing.Size(91, 20)
    Me.txtKurs.StyleController = Me.LayoutControl1
    Me.txtKurs.TabIndex = 10
    '
    'txtAkun
    '
    Me.txtAkun.Location = New System.Drawing.Point(-195, 128)
    Me.txtAkun.MenuManager = Me.barMan
    Me.txtAkun.Name = "txtAkun"
    Me.txtAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "No. Akun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama Akun")})
    Me.txtAkun.Properties.DisplayMember = "Kode"
    Me.txtAkun.Properties.NullText = "<Pilih Akun Kas/Bank>"
    Me.txtAkun.Properties.PopupWidth = 300
    Me.txtAkun.Properties.ValueMember = "This"
    Me.txtAkun.Size = New System.Drawing.Size(179, 20)
    Me.txtAkun.StyleController = Me.LayoutControl1
    Me.txtAkun.TabIndex = 8
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(-195, 104)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(1205, 20)
    Me.txtUraian.StyleController = Me.LayoutControl1
    Me.txtUraian.TabIndex = 7
    '
    'txtTipe
    '
    Me.txtTipe.Location = New System.Drawing.Point(80, 80)
    Me.txtTipe.MenuManager = Me.barMan
    Me.txtTipe.Name = "txtTipe"
    Me.txtTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtTipe.Properties.DisplayMember = "Nama"
    Me.txtTipe.Properties.NullText = "<Pilih Tipe>"
    Me.txtTipe.Properties.ShowHeader = False
    Me.txtTipe.Properties.ValueMember = "Id"
    Me.txtTipe.Size = New System.Drawing.Size(179, 20)
    Me.txtTipe.StyleController = Me.LayoutControl1
    Me.txtTipe.TabIndex = 5
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layTipe, Me.LayoutControlItem3, Me.layAkunKasBank, Me.layTipeEmpty, Me.layMataUang, Me.layAkunKasBankNama, Me.LayoutControlItem7, Me.layCatatan, Me.LayoutControlGroup3, Me.EmptySpaceItem7, Me.EmptySpaceItem9, Me.layCashAdvance, Me.layCashAdvanceText, Me.LayoutControlItem2, Me.layCaraBayar, Me.layCaraBayarDetail, Me.layAkunValas, Me.layKurs})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(-299, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1321, 408)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'layTipe
    '
    Me.layTipe.Control = Me.txtTipe
    Me.layTipe.CustomizationFormText = "Tipe"
    Me.layTipe.Location = New System.Drawing.Point(275, 68)
    Me.layTipe.MaxSize = New System.Drawing.Size(275, 24)
    Me.layTipe.MinSize = New System.Drawing.Size(275, 24)
    Me.layTipe.Name = "layTipe"
    Me.layTipe.Size = New System.Drawing.Size(275, 24)
    Me.layTipe.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layTipe.Text = "Tipe"
    Me.layTipe.TextSize = New System.Drawing.Size(89, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 92)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(1301, 24)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(89, 13)
    '
    'layAkunKasBank
    '
    Me.layAkunKasBank.Control = Me.txtAkun
    Me.layAkunKasBank.CustomizationFormText = "Akun Kas/Bank [D]"
    Me.layAkunKasBank.FillControlToClientArea = False
    Me.layAkunKasBank.Location = New System.Drawing.Point(0, 116)
    Me.layAkunKasBank.MaxSize = New System.Drawing.Size(275, 24)
    Me.layAkunKasBank.MinSize = New System.Drawing.Size(275, 24)
    Me.layAkunKasBank.Name = "layAkunKasBank"
    Me.layAkunKasBank.Size = New System.Drawing.Size(275, 24)
    Me.layAkunKasBank.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layAkunKasBank.Text = "Akun Kas/Bank [D]"
    Me.layAkunKasBank.TextSize = New System.Drawing.Size(89, 13)
    '
    'layTipeEmpty
    '
    Me.layTipeEmpty.AllowHotTrack = False
    Me.layTipeEmpty.CustomizationFormText = "EmptySpaceItem1"
    Me.layTipeEmpty.Location = New System.Drawing.Point(1291, 68)
    Me.layTipeEmpty.Name = "layTipeEmpty"
    Me.layTipeEmpty.Size = New System.Drawing.Size(10, 24)
    Me.layTipeEmpty.Text = "layTipeEmpty"
    Me.layTipeEmpty.TextSize = New System.Drawing.Size(0, 0)
    '
    'layMataUang
    '
    Me.layMataUang.Control = Me.txtMataUang
    Me.layMataUang.CustomizationFormText = "Mata Uang"
    Me.layMataUang.Location = New System.Drawing.Point(843, 116)
    Me.layMataUang.MaxSize = New System.Drawing.Size(135, 24)
    Me.layMataUang.MinSize = New System.Drawing.Size(135, 24)
    Me.layMataUang.Name = "layMataUang"
    Me.layMataUang.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 10, 2, 2)
    Me.layMataUang.Size = New System.Drawing.Size(135, 24)
    Me.layMataUang.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layMataUang.Text = "Mata Uang"
    Me.layMataUang.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layMataUang.TextSize = New System.Drawing.Size(52, 13)
    Me.layMataUang.TextToControlDistance = 5
    '
    'layAkunKasBankNama
    '
    Me.layAkunKasBankNama.AllowHotTrack = False
    Me.layAkunKasBankNama.CustomizationFormText = "Akun Nama"
    Me.layAkunKasBankNama.Location = New System.Drawing.Point(275, 116)
    Me.layAkunKasBankNama.MaxSize = New System.Drawing.Size(568, 24)
    Me.layAkunKasBankNama.MinSize = New System.Drawing.Size(568, 24)
    Me.layAkunKasBankNama.Name = "layAkunKasBankNama"
    Me.layAkunKasBankNama.Size = New System.Drawing.Size(568, 24)
    Me.layAkunKasBankNama.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layAkunKasBankNama.Text = "Akun Nama"
    Me.layAkunKasBankNama.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layAkunKasBankNama.TextSize = New System.Drawing.Size(54, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGrid
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 212)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(1301, 147)
    Me.LayoutControlItem7.Text = "LayoutControlItem7"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'layCatatan
    '
    Me.layCatatan.Control = Me.txtCatatan
    Me.layCatatan.CustomizationFormText = "Catatan"
    Me.layCatatan.Location = New System.Drawing.Point(0, 364)
    Me.layCatatan.Name = "layCatatan"
    Me.layCatatan.Size = New System.Drawing.Size(1301, 24)
    Me.layCatatan.Text = "Catatan"
    Me.layCatatan.TextSize = New System.Drawing.Size(89, 13)
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
    Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
    Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
    Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
    Me.LayoutControlGroup3.GroupBordersVisible = False
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem16, Me.layKontakNama, Me.SimpleLabelItem3, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem17, Me.LayoutControlItem15, Me.SimpleLabelItem4, Me.EmptySpaceItem6})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(1301, 63)
    Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
    Me.LayoutControlGroup3.TextVisible = False
    '
    'layKontak
    '
    Me.layKontak.Control = Me.txtKontak
    Me.layKontak.CustomizationFormText = "Sudah terima dari"
    Me.layKontak.Location = New System.Drawing.Point(10, 10)
    Me.layKontak.MaxSize = New System.Drawing.Size(150, 40)
    Me.layKontak.MinSize = New System.Drawing.Size(150, 40)
    Me.layKontak.Name = "layKontak"
    Me.layKontak.Size = New System.Drawing.Size(150, 43)
    Me.layKontak.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layKontak.Text = "Sudah Terima Dari"
    Me.layKontak.TextLocation = DevExpress.Utils.Locations.Top
    Me.layKontak.TextSize = New System.Drawing.Size(89, 13)
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtNoTransaksi
    Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(1110, 10)
    Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(150, 40)
    Me.LayoutControlItem16.MinSize = New System.Drawing.Size(150, 40)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(150, 43)
    Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem16.Text = "No. Transaksi"
    Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(89, 13)
    '
    'layKontakNama
    '
    Me.layKontakNama.AllowHotTrack = False
    Me.layKontakNama.CustomizationFormText = "kontak nama"
    Me.layKontakNama.Location = New System.Drawing.Point(160, 27)
    Me.layKontakNama.Name = "layKontakNama"
    Me.layKontakNama.Size = New System.Drawing.Size(735, 26)
    Me.layKontakNama.Text = "kontak nama"
    Me.layKontakNama.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layKontakNama.TextSize = New System.Drawing.Size(61, 13)
    '
    'SimpleLabelItem3
    '
    Me.SimpleLabelItem3.AllowHotTrack = False
    Me.SimpleLabelItem3.CustomizationFormText = " "
    Me.SimpleLabelItem3.Location = New System.Drawing.Point(160, 10)
    Me.SimpleLabelItem3.Name = "SimpleLabelItem3"
    Me.SimpleLabelItem3.Size = New System.Drawing.Size(735, 17)
    Me.SimpleLabelItem3.Text = " "
    Me.SimpleLabelItem3.TextSize = New System.Drawing.Size(89, 13)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.FillControlToClientArea = False
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(10, 0)
    Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(0, 24)
    Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(104, 10)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(1280, 10)
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
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(10, 53)
    Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
    Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(1280, 10)
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
    Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(10, 0)
    Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 63)
    Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(1290, 0)
    Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(0, 10)
    Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(11, 63)
    Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.btnRefreshNomor
    Me.LayoutControlItem17.CustomizationFormText = " "
    Me.LayoutControlItem17.Location = New System.Drawing.Point(1260, 27)
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
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(895, 10)
    Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(150, 40)
    Me.LayoutControlItem15.MinSize = New System.Drawing.Size(150, 40)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(150, 43)
    Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem15.Text = "Tanggal"
    Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(89, 13)
    '
    'SimpleLabelItem4
    '
    Me.SimpleLabelItem4.AllowHotTrack = False
    Me.SimpleLabelItem4.CustomizationFormText = " "
    Me.SimpleLabelItem4.Location = New System.Drawing.Point(1260, 10)
    Me.SimpleLabelItem4.Name = "SimpleLabelItem4"
    Me.SimpleLabelItem4.Size = New System.Drawing.Size(30, 17)
    Me.SimpleLabelItem4.Text = " "
    Me.SimpleLabelItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.SimpleLabelItem4.TextSize = New System.Drawing.Size(3, 13)
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(1045, 10)
    Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(65, 0)
    Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(65, 10)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(65, 43)
    Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem7
    '
    Me.EmptySpaceItem7.AllowHotTrack = False
    Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 63)
    Me.EmptySpaceItem7.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Size = New System.Drawing.Size(1301, 5)
    Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
    Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem9
    '
    Me.EmptySpaceItem9.AllowHotTrack = False
    Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Location = New System.Drawing.Point(0, 359)
    Me.EmptySpaceItem9.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Size = New System.Drawing.Size(1301, 5)
    Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
    Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
    '
    'layCashAdvance
    '
    Me.layCashAdvance.Control = Me.txtCashAdvance
    Me.layCashAdvance.CustomizationFormText = "No. Cash Advance"
    Me.layCashAdvance.Location = New System.Drawing.Point(550, 68)
    Me.layCashAdvance.MaxSize = New System.Drawing.Size(275, 24)
    Me.layCashAdvance.MinSize = New System.Drawing.Size(275, 24)
    Me.layCashAdvance.Name = "layCashAdvance"
    Me.layCashAdvance.Size = New System.Drawing.Size(275, 24)
    Me.layCashAdvance.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layCashAdvance.Text = "No. Cash Advance"
    Me.layCashAdvance.TextSize = New System.Drawing.Size(89, 13)
    '
    'layCashAdvanceText
    '
    Me.layCashAdvanceText.AllowHotTrack = False
    Me.layCashAdvanceText.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.layCashAdvanceText.AppearanceItemCaption.Options.UseFont = True
    Me.layCashAdvanceText.CustomizationFormText = "(Silahkan pilih nomor Cash Advance untuk membuat transaksi Settlement/pertanggung" & _
    " jawaban."
    Me.layCashAdvanceText.Location = New System.Drawing.Point(825, 68)
    Me.layCashAdvanceText.Name = "layCashAdvanceText"
    Me.layCashAdvanceText.Size = New System.Drawing.Size(466, 24)
    Me.layCashAdvanceText.Text = "(Silahkan pilih nomor Cash Advance untuk membuat transaksi Settlement/pertanggung" & _
    " jawaban)"
    Me.layCashAdvanceText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layCashAdvanceText.TextSize = New System.Drawing.Size(462, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtRegional
    Me.LayoutControlItem2.CustomizationFormText = "Regional"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 68)
    Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(275, 24)
    Me.LayoutControlItem2.MinSize = New System.Drawing.Size(275, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(275, 24)
    Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem2.Text = "Regional"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(89, 13)
    '
    'layCaraBayar
    '
    Me.layCaraBayar.Control = Me.txtCaraBayar
    Me.layCaraBayar.CustomizationFormText = "Cara Pembayaran"
    Me.layCaraBayar.Location = New System.Drawing.Point(0, 140)
    Me.layCaraBayar.Name = "layCaraBayar"
    Me.layCaraBayar.Size = New System.Drawing.Size(325, 72)
    Me.layCaraBayar.Text = "Cara Pembayaran"
    Me.layCaraBayar.TextSize = New System.Drawing.Size(89, 13)
    '
    'layCaraBayarDetail
    '
    Me.layCaraBayarDetail.CustomizationFormText = "Detail"
    Me.layCaraBayarDetail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem13, Me.LayoutControlItem12, Me.layJatuhTempo, Me.LayoutControlItem1})
    Me.layCaraBayarDetail.Location = New System.Drawing.Point(325, 140)
    Me.layCaraBayarDetail.Name = "layCaraBayarDetail"
    Me.layCaraBayarDetail.Size = New System.Drawing.Size(976, 72)
    Me.layCaraBayarDetail.Text = "Detail"
    Me.layCaraBayarDetail.TextLocation = DevExpress.Utils.Locations.Right
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtNoCekGiro
    Me.LayoutControlItem10.CustomizationFormText = "No. Cek/Giro"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(288, 24)
    Me.LayoutControlItem10.Text = "No. Cek/Giro"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(89, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtAkunGiro
    Me.LayoutControlItem13.CustomizationFormText = "Akun Giro"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(288, 24)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(287, 24)
    Me.LayoutControlItem13.Text = "Akun Giro"
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(89, 13)
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtBank
    Me.LayoutControlItem12.CustomizationFormText = "Bank"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(288, 0)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(287, 24)
    Me.LayoutControlItem12.Text = "Bank"
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(89, 13)
    '
    'layJatuhTempo
    '
    Me.layJatuhTempo.Control = Me.txtJatuhTempo
    Me.layJatuhTempo.CustomizationFormText = "Jatuh Tempo"
    Me.layJatuhTempo.Location = New System.Drawing.Point(575, 0)
    Me.layJatuhTempo.Name = "layJatuhTempo"
    Me.layJatuhTempo.Size = New System.Drawing.Size(358, 48)
    Me.layJatuhTempo.Text = "Jatuh Tempo"
    Me.layJatuhTempo.TextSize = New System.Drawing.Size(89, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtNoAC
    Me.LayoutControlItem1.CustomizationFormText = "No. A/C"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(288, 24)
    Me.LayoutControlItem1.Text = "No. A/C"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(89, 13)
    '
    'layAkunValas
    '
    Me.layAkunValas.Control = Me.txtValas
    Me.layAkunValas.CustomizationFormText = "Valas"
    Me.layAkunValas.Location = New System.Drawing.Point(1099, 116)
    Me.layAkunValas.MaxSize = New System.Drawing.Size(202, 24)
    Me.layAkunValas.MinSize = New System.Drawing.Size(202, 24)
    Me.layAkunValas.Name = "layAkunValas"
    Me.layAkunValas.Size = New System.Drawing.Size(202, 24)
    Me.layAkunValas.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layAkunValas.Text = "Valas"
    Me.layAkunValas.TextSize = New System.Drawing.Size(89, 13)
    '
    'layKurs
    '
    Me.layKurs.Control = Me.txtKurs
    Me.layKurs.CustomizationFormText = "Kurs"
    Me.layKurs.Location = New System.Drawing.Point(978, 116)
    Me.layKurs.MaxSize = New System.Drawing.Size(121, 24)
    Me.layKurs.MinSize = New System.Drawing.Size(121, 24)
    Me.layKurs.Name = "layKurs"
    Me.layKurs.Size = New System.Drawing.Size(121, 24)
    Me.layKurs.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layKurs.Text = "Kurs"
    Me.layKurs.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layKurs.TextSize = New System.Drawing.Size(21, 13)
    Me.layKurs.TextToControlDistance = 5
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
    'UI_TransaksiGLDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1028, 458)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "UI_TransaksiGLDialog"
    Me.Text = "UI_TransaksiGLDialog"
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
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtValas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoAC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCashAdvance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJatuhTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJatuhTempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkunGiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoCekGiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCaraBayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colAkunRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colUangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layTipe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layAkunKasBank, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layTipeEmpty, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layMataUang, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layAkunKasBankNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layCatatan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontakNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleLabelItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layCashAdvance, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layCashAdvanceText, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layCaraBayar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layCaraBayarDetail, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layJatuhTempo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layAkunValas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKurs, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents txtTipe As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents layTipe As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtAkun As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents layAkunKasBank As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layTipeEmpty As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtMataUang As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
  Friend WithEvents layKurs As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layMataUang As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layAkunKasBankNama As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtCatatan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents layCatatan As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtCaraBayar As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents layCaraBayar As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layCaraBayarDetail As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtNoCekGiro As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtJatuhTempo As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtAkunGiro As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtBank As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layJatuhTempo As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layKontakNama As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents SimpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
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
  Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtCashAdvance As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents layCashAdvance As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layCashAdvanceText As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents txtNoAC As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colNoAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkunRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colAkunNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colValasDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colValasKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDivisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDivisiRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
  Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
  Friend WithEvents txtValas As DevExpress.XtraEditors.TextEdit
  Friend WithEvents layAkunValas As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
End Class
