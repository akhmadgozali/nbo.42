<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohTransferStockDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohTransferStockDialog))
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
        Me.txtTotalWeightBB = New DevExpress.XtraEditors.TextEdit()
        Me.txtThicknesBB = New DevExpress.XtraEditors.TextEdit()
        Me.txtIDBB = New DevExpress.XtraEditors.TextEdit()
        Me.txtODBB = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarksBB = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockBJ = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalWeightBJ = New DevExpress.XtraEditors.TextEdit()
        Me.txtIDBJ = New DevExpress.XtraEditors.TextEdit()
        Me.txtThicknesBJ = New DevExpress.XtraEditors.TextEdit()
        Me.txtODBJ = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarksBJ = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.txtGudang = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGudangKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGudangNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtUraian = New DevExpress.XtraEditors.MemoEdit()
        Me.txtItemBJ = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtKodeProduksi = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtItemBB = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtLengthBJ = New DevExpress.XtraEditors.SpinEdit()
        Me.txtQtyBJ = New DevExpress.XtraEditors.SpinEdit()
        Me.txtQtyBB = New DevExpress.XtraEditors.SpinEdit()
        Me.txtLengthBB = New DevExpress.XtraEditors.SpinEdit()
        Me.txtPelanggan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtInfoLOT = New DevExpress.XtraEditors.MemoEdit()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.layGudang = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCekSistem = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
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
        CType(Me.txtTotalWeightBB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThicknesBB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDBB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtODBB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarksBB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalWeightBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThicknesBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtODBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarksBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodeProduksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemBB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLengthBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyBJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyBB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLengthBB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPelanggan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfoLOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barMan
        '
        Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.btnCekSistem, Me.BarButtonItem2})
        Me.barMan.MaxItemId = 9
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
        Me.hideContainerRight.Size = New System.Drawing.Size(19, 462)
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
        Me.DockPanel1.Size = New System.Drawing.Size(250, 462)
        Me.DockPanel1.Text = "Panel Informasi"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 435)
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
        Me.NavBarControl1.Size = New System.Drawing.Size(242, 435)
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
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(1128, 456)
        Me.DockPanel2.Text = "DockPanel2"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.lytTransaksi)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(1128, 456)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'lytTransaksi
        '
        Me.lytTransaksi.Controls.Add(Me.txtTotalWeightBB)
        Me.lytTransaksi.Controls.Add(Me.txtThicknesBB)
        Me.lytTransaksi.Controls.Add(Me.txtIDBB)
        Me.lytTransaksi.Controls.Add(Me.txtODBB)
        Me.lytTransaksi.Controls.Add(Me.txtRemarksBB)
        Me.lytTransaksi.Controls.Add(Me.txtStockBJ)
        Me.lytTransaksi.Controls.Add(Me.txtTotalWeightBJ)
        Me.lytTransaksi.Controls.Add(Me.txtIDBJ)
        Me.lytTransaksi.Controls.Add(Me.txtThicknesBJ)
        Me.lytTransaksi.Controls.Add(Me.txtODBJ)
        Me.lytTransaksi.Controls.Add(Me.txtRemarksBJ)
        Me.lytTransaksi.Controls.Add(Me.txtStatus)
        Me.lytTransaksi.Controls.Add(Me.txtRegional)
        Me.lytTransaksi.Controls.Add(Me.txtTanggal)
        Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
        Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
        Me.lytTransaksi.Controls.Add(Me.txtGudang)
        Me.lytTransaksi.Controls.Add(Me.txtUraian)
        Me.lytTransaksi.Controls.Add(Me.txtItemBJ)
        Me.lytTransaksi.Controls.Add(Me.txtKodeProduksi)
        Me.lytTransaksi.Controls.Add(Me.txtItemBB)
        Me.lytTransaksi.Controls.Add(Me.txtLengthBJ)
        Me.lytTransaksi.Controls.Add(Me.txtQtyBJ)
        Me.lytTransaksi.Controls.Add(Me.txtQtyBB)
        Me.lytTransaksi.Controls.Add(Me.txtLengthBB)
        Me.lytTransaksi.Controls.Add(Me.txtPelanggan)
        Me.lytTransaksi.Controls.Add(Me.txtInfoLOT)
        Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.lytTransaksi.Name = "lytTransaksi"
        Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 346, 250, 350)
        Me.lytTransaksi.Root = Me.layoutControlGroup1
        Me.lytTransaksi.Size = New System.Drawing.Size(1128, 456)
        Me.lytTransaksi.TabIndex = 0
        Me.lytTransaksi.Text = "lytTransaksi"
        '
        'txtTotalWeightBB
        '
        Me.txtTotalWeightBB.Location = New System.Drawing.Point(623, 412)
        Me.txtTotalWeightBB.MenuManager = Me.barMan
        Me.txtTotalWeightBB.Name = "txtTotalWeightBB"
        Me.txtTotalWeightBB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalWeightBB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalWeightBB.Properties.ReadOnly = True
        Me.txtTotalWeightBB.Size = New System.Drawing.Size(198, 20)
        Me.txtTotalWeightBB.StyleController = Me.lytTransaksi
        Me.txtTotalWeightBB.TabIndex = 26
        '
        'txtThicknesBB
        '
        Me.txtThicknesBB.Location = New System.Drawing.Point(623, 388)
        Me.txtThicknesBB.MenuManager = Me.barMan
        Me.txtThicknesBB.Name = "txtThicknesBB"
        Me.txtThicknesBB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtThicknesBB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtThicknesBB.Properties.ReadOnly = True
        Me.txtThicknesBB.Size = New System.Drawing.Size(198, 20)
        Me.txtThicknesBB.StyleController = Me.lytTransaksi
        Me.txtThicknesBB.TabIndex = 24
        '
        'txtIDBB
        '
        Me.txtIDBB.Location = New System.Drawing.Point(623, 364)
        Me.txtIDBB.MenuManager = Me.barMan
        Me.txtIDBB.Name = "txtIDBB"
        Me.txtIDBB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIDBB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIDBB.Properties.ReadOnly = True
        Me.txtIDBB.Size = New System.Drawing.Size(198, 20)
        Me.txtIDBB.StyleController = Me.lytTransaksi
        Me.txtIDBB.TabIndex = 22
        '
        'txtODBB
        '
        Me.txtODBB.Location = New System.Drawing.Point(623, 340)
        Me.txtODBB.MenuManager = Me.barMan
        Me.txtODBB.Name = "txtODBB"
        Me.txtODBB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtODBB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtODBB.Properties.ReadOnly = True
        Me.txtODBB.Size = New System.Drawing.Size(198, 20)
        Me.txtODBB.StyleController = Me.lytTransaksi
        Me.txtODBB.TabIndex = 20
        '
        'txtRemarksBB
        '
        Me.txtRemarksBB.Location = New System.Drawing.Point(88, 412)
        Me.txtRemarksBB.MenuManager = Me.barMan
        Me.txtRemarksBB.Name = "txtRemarksBB"
        Me.txtRemarksBB.Size = New System.Drawing.Size(467, 20)
        Me.txtRemarksBB.StyleController = Me.lytTransaksi
        Me.txtRemarksBB.TabIndex = 25
        '
        'txtStockBJ
        '
        Me.txtStockBJ.Location = New System.Drawing.Point(888, 201)
        Me.txtStockBJ.MenuManager = Me.barMan
        Me.txtStockBJ.Name = "txtStockBJ"
        Me.txtStockBJ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockBJ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockBJ.Properties.ReadOnly = True
        Me.txtStockBJ.Size = New System.Drawing.Size(199, 20)
        Me.txtStockBJ.StyleController = Me.lytTransaksi
        Me.txtStockBJ.TabIndex = 10
        '
        'txtTotalWeightBJ
        '
        Me.txtTotalWeightBJ.Location = New System.Drawing.Point(622, 273)
        Me.txtTotalWeightBJ.MenuManager = Me.barMan
        Me.txtTotalWeightBJ.Name = "txtTotalWeightBJ"
        Me.txtTotalWeightBJ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalWeightBJ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalWeightBJ.Properties.ReadOnly = True
        Me.txtTotalWeightBJ.Size = New System.Drawing.Size(198, 20)
        Me.txtTotalWeightBJ.StyleController = Me.lytTransaksi
        Me.txtTotalWeightBJ.TabIndex = 18
        '
        'txtIDBJ
        '
        Me.txtIDBJ.Location = New System.Drawing.Point(622, 225)
        Me.txtIDBJ.MenuManager = Me.barMan
        Me.txtIDBJ.Name = "txtIDBJ"
        Me.txtIDBJ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIDBJ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIDBJ.Properties.ReadOnly = True
        Me.txtIDBJ.Size = New System.Drawing.Size(198, 20)
        Me.txtIDBJ.StyleController = Me.lytTransaksi
        Me.txtIDBJ.TabIndex = 12
        '
        'txtThicknesBJ
        '
        Me.txtThicknesBJ.Location = New System.Drawing.Point(622, 249)
        Me.txtThicknesBJ.MenuManager = Me.barMan
        Me.txtThicknesBJ.Name = "txtThicknesBJ"
        Me.txtThicknesBJ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtThicknesBJ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtThicknesBJ.Properties.ReadOnly = True
        Me.txtThicknesBJ.Size = New System.Drawing.Size(198, 20)
        Me.txtThicknesBJ.StyleController = Me.lytTransaksi
        Me.txtThicknesBJ.TabIndex = 15
        '
        'txtODBJ
        '
        Me.txtODBJ.Location = New System.Drawing.Point(622, 201)
        Me.txtODBJ.MenuManager = Me.barMan
        Me.txtODBJ.Name = "txtODBJ"
        Me.txtODBJ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtODBJ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtODBJ.Properties.ReadOnly = True
        Me.txtODBJ.Size = New System.Drawing.Size(198, 20)
        Me.txtODBJ.StyleController = Me.lytTransaksi
        Me.txtODBJ.TabIndex = 9
        '
        'txtRemarksBJ
        '
        Me.txtRemarksBJ.Location = New System.Drawing.Point(88, 273)
        Me.txtRemarksBJ.MenuManager = Me.barMan
        Me.txtRemarksBJ.Name = "txtRemarksBJ"
        Me.txtRemarksBJ.Size = New System.Drawing.Size(466, 20)
        Me.txtRemarksBJ.StyleController = Me.lytTransaksi
        Me.txtRemarksBJ.TabIndex = 17
        '
        'txtStatus
        '
        Me.txtStatus.EnterMoveNextControl = True
        Me.txtStatus.Location = New System.Drawing.Point(975, 61)
        Me.txtStatus.MenuManager = Me.barMan
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
        Me.txtStatus.Properties.DisplayMember = "Value"
        Me.txtStatus.Properties.NullText = "<Status>"
        Me.txtStatus.Properties.ValueMember = "Key"
        Me.txtStatus.Size = New System.Drawing.Size(88, 20)
        Me.txtStatus.StyleController = Me.lytTransaksi
        Me.txtStatus.TabIndex = 6
        '
        'txtRegional
        '
        Me.txtRegional.EnterMoveNextControl = True
        Me.txtRegional.Location = New System.Drawing.Point(792, 61)
        Me.txtRegional.MenuManager = Me.barMan
        Me.txtRegional.Name = "txtRegional"
        Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
        Me.txtRegional.Properties.DisplayMember = "Nama"
        Me.txtRegional.Properties.NullText = "<Pilih Regional>"
        Me.txtRegional.Properties.ValueMember = "This"
        Me.txtRegional.Size = New System.Drawing.Size(126, 20)
        Me.txtRegional.StyleController = Me.lytTransaksi
        Me.txtRegional.TabIndex = 5
        '
        'txtTanggal
        '
        Me.txtTanggal.EditValue = Nothing
        Me.txtTanggal.EnterMoveNextControl = True
        Me.txtTanggal.Location = New System.Drawing.Point(792, 37)
        Me.txtTanggal.MenuManager = Me.barMan
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
        Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTanggal.Size = New System.Drawing.Size(126, 20)
        Me.txtTanggal.StyleController = Me.lytTransaksi
        Me.txtTanggal.TabIndex = 1
        '
        'btnRefreshNomor
        '
        Me.btnRefreshNomor.AutoWidthInLayoutControl = True
        Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
        Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshNomor.Location = New System.Drawing.Point(1067, 37)
        Me.btnRefreshNomor.Name = "btnRefreshNomor"
        Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
        Me.btnRefreshNomor.StyleController = Me.lytTransaksi
        Me.btnRefreshNomor.TabIndex = 3
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.EnterMoveNextControl = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(975, 37)
        Me.txtNoTransaksi.MenuManager = Me.barMan
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNoTransaksi.Size = New System.Drawing.Size(88, 20)
        Me.txtNoTransaksi.StyleController = Me.lytTransaksi
        Me.txtNoTransaksi.TabIndex = 2
        '
        'txtGudang
        '
        Me.txtGudang.EnterMoveNextControl = True
        Me.txtGudang.Location = New System.Drawing.Point(83, 61)
        Me.txtGudang.MenuManager = Me.barMan
        Me.txtGudang.Name = "txtGudang"
        Me.txtGudang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGudang.Properties.DisplayMember = "Kode"
        Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
        Me.txtGudang.Properties.ShowClearButton = False
        Me.txtGudang.Properties.ShowFooter = False
        Me.txtGudang.Properties.ValueMember = "This"
        Me.txtGudang.Properties.View = Me.SearchLookUpEdit1View
        Me.txtGudang.Size = New System.Drawing.Size(208, 20)
        Me.txtGudang.StyleController = Me.lytTransaksi
        Me.txtGudang.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGudangKode, Me.colGudangNama})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsFind.FindDelay = 500
        Me.SearchLookUpEdit1View.OptionsFind.SearchInPreview = True
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGudangKode, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colGudangKode
        '
        Me.colGudangKode.Caption = "Kode"
        Me.colGudangKode.FieldName = "Kode"
        Me.colGudangKode.Name = "colGudangKode"
        Me.colGudangKode.Visible = True
        Me.colGudangKode.VisibleIndex = 0
        Me.colGudangKode.Width = 355
        '
        'colGudangNama
        '
        Me.colGudangNama.Caption = "Nama"
        Me.colGudangNama.FieldName = "Nama"
        Me.colGudangNama.Name = "colGudangNama"
        Me.colGudangNama.Visible = True
        Me.colGudangNama.VisibleIndex = 1
        Me.colGudangNama.Width = 723
        '
        'txtUraian
        '
        Me.txtUraian.Location = New System.Drawing.Point(83, 95)
        Me.txtUraian.MenuManager = Me.barMan
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUraian.Size = New System.Drawing.Size(1010, 50)
        Me.txtUraian.StyleController = Me.lytTransaksi
        Me.txtUraian.TabIndex = 7
        '
        'txtItemBJ
        '
        Me.txtItemBJ.EditValue = "<Pilih Item>"
        Me.txtItemBJ.Location = New System.Drawing.Point(88, 201)
        Me.txtItemBJ.MenuManager = Me.barMan
        Me.txtItemBJ.Name = "txtItemBJ"
        Me.txtItemBJ.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.txtItemBJ.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtItemBJ.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItemBJ.Properties.DisplayMember = "Kode"
        Me.txtItemBJ.Properties.NullText = "<Pilih Item>"
        Me.txtItemBJ.Properties.ValueMember = "This"
        Me.txtItemBJ.Properties.View = Me.GridView1
        Me.txtItemBJ.Size = New System.Drawing.Size(466, 20)
        Me.txtItemBJ.StyleController = Me.lytTransaksi
        Me.txtItemBJ.TabIndex = 8
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama, Me.gcSatuan})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.Location = New System.Drawing.Point(888, 225)
        Me.txtKodeProduksi.MenuManager = Me.barMan
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKodeProduksi.Properties.DisplayMember = "StockDetail.Main.DempyouLot"
        Me.txtKodeProduksi.Properties.NullText = "<Pilih LOT NO>"
        Me.txtKodeProduksi.Properties.ValueMember = "This"
        Me.txtKodeProduksi.Properties.View = Me.GridView3
        Me.txtKodeProduksi.Size = New System.Drawing.Size(199, 20)
        Me.txtKodeProduksi.StyleController = Me.lytTransaksi
        Me.txtKodeProduksi.TabIndex = 13
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "LOT NO"
        Me.GridColumn4.FieldName = "StockDetail.Main.DempyouLot"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "No Bukti"
        Me.GridColumn5.FieldName = "StockDetail.Main.Kode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tanggal"
        Me.GridColumn6.FieldName = "StockDetail.Main.Tanggal"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Sisa"
        Me.GridColumn7.FieldName = "QtySisa"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'txtItemBB
        '
        Me.txtItemBB.Location = New System.Drawing.Point(88, 340)
        Me.txtItemBB.MenuManager = Me.barMan
        Me.txtItemBB.Name = "txtItemBB"
        Me.txtItemBB.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.txtItemBB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtItemBB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItemBB.Properties.DisplayMember = "Kode"
        Me.txtItemBB.Properties.NullText = "<Pilih Item>"
        Me.txtItemBB.Properties.ValueMember = "This"
        Me.txtItemBB.Properties.View = Me.GridView2
        Me.txtItemBB.Size = New System.Drawing.Size(467, 20)
        Me.txtItemBB.StyleController = Me.lytTransaksi
        Me.txtItemBB.TabIndex = 19
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Kode"
        Me.GridColumn1.FieldName = "Kode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 293
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nama"
        Me.GridColumn2.FieldName = "Nama"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 519
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Satuan"
        Me.GridColumn3.FieldName = "Satuan.Nama"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 266
        '
        'txtLengthBJ
        '
        Me.txtLengthBJ.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLengthBJ.Location = New System.Drawing.Point(88, 249)
        Me.txtLengthBJ.MenuManager = Me.barMan
        Me.txtLengthBJ.Name = "txtLengthBJ"
        Me.txtLengthBJ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLengthBJ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLengthBJ.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLengthBJ.Properties.DisplayFormat.FormatString = "n4"
        Me.txtLengthBJ.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLengthBJ.Properties.EditFormat.FormatString = "n4"
        Me.txtLengthBJ.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLengthBJ.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtLengthBJ.Size = New System.Drawing.Size(466, 20)
        Me.txtLengthBJ.StyleController = Me.lytTransaksi
        Me.txtLengthBJ.TabIndex = 14
        '
        'txtQtyBJ
        '
        Me.txtQtyBJ.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtQtyBJ.Location = New System.Drawing.Point(88, 225)
        Me.txtQtyBJ.MenuManager = Me.barMan
        Me.txtQtyBJ.Name = "txtQtyBJ"
        Me.txtQtyBJ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtyBJ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtyBJ.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtQtyBJ.Properties.DisplayFormat.FormatString = "n0"
        Me.txtQtyBJ.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQtyBJ.Properties.EditFormat.FormatString = "n0"
        Me.txtQtyBJ.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQtyBJ.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtQtyBJ.Size = New System.Drawing.Size(466, 20)
        Me.txtQtyBJ.StyleController = Me.lytTransaksi
        Me.txtQtyBJ.TabIndex = 11
        '
        'txtQtyBB
        '
        Me.txtQtyBB.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtQtyBB.Location = New System.Drawing.Point(88, 364)
        Me.txtQtyBB.MenuManager = Me.barMan
        Me.txtQtyBB.Name = "txtQtyBB"
        Me.txtQtyBB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtyBB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtyBB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtQtyBB.Properties.DisplayFormat.FormatString = "n0"
        Me.txtQtyBB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQtyBB.Properties.EditFormat.FormatString = "n0"
        Me.txtQtyBB.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQtyBB.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtQtyBB.Size = New System.Drawing.Size(467, 20)
        Me.txtQtyBB.StyleController = Me.lytTransaksi
        Me.txtQtyBB.TabIndex = 21
        '
        'txtLengthBB
        '
        Me.txtLengthBB.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLengthBB.Location = New System.Drawing.Point(88, 388)
        Me.txtLengthBB.MenuManager = Me.barMan
        Me.txtLengthBB.Name = "txtLengthBB"
        Me.txtLengthBB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLengthBB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLengthBB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLengthBB.Properties.DisplayFormat.FormatString = "n4"
        Me.txtLengthBB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLengthBB.Properties.EditFormat.FormatString = "n4"
        Me.txtLengthBB.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLengthBB.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtLengthBB.Size = New System.Drawing.Size(467, 20)
        Me.txtLengthBB.StyleController = Me.lytTransaksi
        Me.txtLengthBB.TabIndex = 23
        '
        'txtPelanggan
        '
        Me.txtPelanggan.Location = New System.Drawing.Point(82, 37)
        Me.txtPelanggan.MenuManager = Me.barMan
        Me.txtPelanggan.Name = "txtPelanggan"
        Me.txtPelanggan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txtPelanggan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPelanggan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPelanggan.Properties.DisplayMember = "Kode"
        Me.txtPelanggan.Properties.NullText = "<Pilih Customer>"
        Me.txtPelanggan.Properties.ValueMember = "This"
        Me.txtPelanggan.Properties.View = Me.GridView4
        Me.txtPelanggan.Size = New System.Drawing.Size(209, 20)
        Me.txtPelanggan.StyleController = Me.lytTransaksi
        Me.txtPelanggan.TabIndex = 0
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKontakKode, Me.colKontakNama})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsFind.FindDelay = 500
        Me.GridView4.OptionsFind.SearchInPreview = True
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKontakKode, DevExpress.Data.ColumnSortOrder.Ascending)})
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
        'txtInfoLOT
        '
        Me.txtInfoLOT.Location = New System.Drawing.Point(824, 249)
        Me.txtInfoLOT.MenuManager = Me.barMan
        Me.txtInfoLOT.Name = "txtInfoLOT"
        Me.txtInfoLOT.Size = New System.Drawing.Size(263, 44)
        Me.txtInfoLOT.StyleController = Me.lytTransaksi
        Me.txtInfoLOT.TabIndex = 16
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.CustomizationFormText = "Root"
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.EmptySpaceItem8})
        Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(1111, 466)
        Me.layoutControlGroup1.Text = "Root"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layGudang, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.lytRegional, Me.LayoutControlItem14, Me.EmptySpaceItem3, Me.LayoutControlItem2, Me.LayoutControlItem24, Me.EmptySpaceItem5})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1091, 158)
        Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
        Me.LayoutControlGroup3.Text = "Info Utama"
        '
        'layGudang
        '
        Me.layGudang.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.layGudang.AppearanceItemCaption.Options.UseFont = True
        Me.layGudang.Control = Me.txtGudang
        Me.layGudang.CustomizationFormText = "Customer"
        Me.layGudang.Location = New System.Drawing.Point(0, 24)
        Me.layGudang.Name = "layGudang"
        Me.layGudang.Size = New System.Drawing.Size(277, 24)
        Me.layGudang.Text = "Gudang    "
        Me.layGudang.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layGudang.TextSize = New System.Drawing.Size(60, 13)
        Me.layGudang.TextToControlDistance = 5
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem15.Control = Me.txtTanggal
        Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(689, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(215, 24)
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
        Me.LayoutControlItem16.Location = New System.Drawing.Point(904, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(145, 24)
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
        Me.LayoutControlItem17.Location = New System.Drawing.Point(1049, 0)
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
        Me.lytRegional.Location = New System.Drawing.Point(689, 24)
        Me.lytRegional.Name = "lytRegional"
        Me.lytRegional.Size = New System.Drawing.Size(215, 24)
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
        Me.LayoutControlItem14.Location = New System.Drawing.Point(904, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(145, 24)
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
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(277, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(412, 48)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtUraian
        Me.LayoutControlItem2.CustomizationFormText = "Uraian     "
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 54)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(79, 54)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1079, 54)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Uraian     "
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(60, 20)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtPelanggan
        Me.LayoutControlItem24.CustomizationFormText = "Customer"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(277, 24)
        Me.LayoutControlItem24.Text = "Customer"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(0, 10)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(10, 10)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(1079, 10)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Bahan Jadi"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem25})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 158)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1091, 139)
        Me.LayoutControlGroup4.Text = "Barang Sumber"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtItemBJ
        Me.LayoutControlItem3.CustomizationFormText = "Item"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem3.Text = "Part No"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtQtyBJ
        Me.LayoutControlItem4.CustomizationFormText = "Qty"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem4.Text = "Qty"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtLengthBJ
        Me.LayoutControlItem5.CustomizationFormText = "Length"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem5.Text = "Length (mm)"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtODBJ
        Me.LayoutControlItem8.CustomizationFormText = "Out Diameter"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(534, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem8.Text = "OD (mm)"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtThicknesBJ
        Me.LayoutControlItem9.CustomizationFormText = "Tebal"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(534, 48)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem9.Text = "T (mm)"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtIDBJ
        Me.LayoutControlItem6.CustomizationFormText = "In Diameter"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(534, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem6.Text = "ID (mm)"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtRemarksBJ
        Me.LayoutControlItem7.CustomizationFormText = "Remarks"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem7.Text = "Remarks"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtTotalWeightBJ
        Me.LayoutControlItem10.CustomizationFormText = "Total Weight"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(534, 72)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem10.Text = "Total Weight"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtStockBJ
        Me.LayoutControlItem11.CustomizationFormText = "Sisa Stock"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(800, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem11.Text = "Sisa Stock"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtKodeProduksi
        Me.LayoutControlItem12.CustomizationFormText = "LOT NO"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(800, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem12.Text = "LOT NO"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtInfoLOT
        Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(800, 48)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(267, 48)
        Me.LayoutControlItem25.Text = "LayoutControlItem25"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextToControlDistance = 0
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Bahan Baku"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem13, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.EmptySpaceItem2})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 297)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1091, 139)
        Me.LayoutControlGroup5.Text = "Barang Tujuan"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtItemBB
        Me.LayoutControlItem1.CustomizationFormText = "Part No"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(535, 24)
        Me.LayoutControlItem1.Text = "Part No"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtQtyBB
        Me.LayoutControlItem13.CustomizationFormText = "Qty"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(535, 24)
        Me.LayoutControlItem13.Text = "Qty"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtODBB
        Me.LayoutControlItem20.CustomizationFormText = "OD (mm)"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(535, 0)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem20.Text = "OD (mm)"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtIDBB
        Me.LayoutControlItem21.CustomizationFormText = "ID (mm)"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(535, 24)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem21.Text = "ID (mm)"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtLengthBB
        Me.LayoutControlItem18.CustomizationFormText = "Length (mm)"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(535, 24)
        Me.LayoutControlItem18.Text = "Length (mm)"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtRemarksBB
        Me.LayoutControlItem19.CustomizationFormText = "Remarks"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(535, 24)
        Me.LayoutControlItem19.Text = "Remarks"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtThicknesBB
        Me.LayoutControlItem22.CustomizationFormText = "T (mm)"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(535, 48)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem22.Text = "T (mm)"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtTotalWeightBB
        Me.LayoutControlItem23.CustomizationFormText = "Total Weight"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(535, 72)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem23.Text = "Total Weight"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(801, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(266, 96)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 436)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(1091, 10)
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnCekSistem
        '
        Me.btnCekSistem.Caption = "Cek Sistem"
        Me.btnCekSistem.Id = 7
        Me.btnCekSistem.Name = "btnCekSistem"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Cek Sisa Produksi"
        Me.BarButtonItem2.Id = 8
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'UI_FusohTransferStockDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 489)
        Me.Controls.Add(Me.hideContainerRight)
        Me.KeyPreview = True
        Me.Name = "UI_FusohTransferStockDialog"
        Me.Text = "Transfer Finish Goods"
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
        CType(Me.txtTotalWeightBB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThicknesBB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDBB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtODBB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarksBB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalWeightBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThicknesBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtODBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarksBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodeProduksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemBB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLengthBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyBJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyBB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLengthBB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPelanggan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfoLOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
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
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents layGudang As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtGudang As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colGudangKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colGudangNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtUraian As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtItemBJ As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtStockBJ As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTotalWeightBJ As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtIDBJ As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtThicknesBJ As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtODBJ As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtRemarksBJ As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKodeProduksi As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTotalWeightBB As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtThicknesBB As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtIDBB As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtODBB As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtRemarksBB As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
  Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
  Friend WithEvents txtItemBB As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtLengthBJ As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents txtQtyBJ As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents txtQtyBB As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents txtLengthBB As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPelanggan As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCekSistem As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents txtInfoLOT As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
