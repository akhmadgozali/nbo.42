<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x_Main
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NuSoft.NUI.Win.Forms.x_Splash), True, True)
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(x_Main))
    Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
    Me.barStatus = New DevExpress.XtraBars.Bar()
    Me.barTxtDatabase = New DevExpress.XtraBars.BarStaticItem()
    Me.barDtDatabase = New DevExpress.XtraBars.BarEditItem()
    Me.barDtDatabaseRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.barSubTools = New DevExpress.XtraBars.BarSubItem()
    Me.barBtnCloseAllWindow = New DevExpress.XtraBars.BarButtonItem()
    Me.barBtnChangePassword = New DevExpress.XtraBars.BarButtonItem()
    Me.barBtnLogOff = New DevExpress.XtraBars.BarButtonItem()
    Me.barBtnCekUpdate = New DevExpress.XtraBars.BarButtonItem()
    Me.barSubSkin = New DevExpress.XtraBars.BarSubItem()
    Me.barTxtUser = New DevExpress.XtraBars.BarStaticItem()
    Me.barTxtVersi = New DevExpress.XtraBars.BarStaticItem()
    Me.barTxtInfo = New DevExpress.XtraBars.BarStaticItem()
    Me.barTxtJam = New DevExpress.XtraBars.BarStaticItem()
    Me.barDockController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
    Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
    Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
    Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
    Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
    Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
    Me.dockMenu = New DevExpress.XtraBars.Docking.DockPanel()
    Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
    Me.barNavControl = New DevExpress.XtraNavBar.NavBarControl()
    Me.barNavAdmin = New DevExpress.XtraNavBar.NavBarGroup()
    Me.barNavAdminUserman = New DevExpress.XtraNavBar.NavBarItem()
    Me.barNavAdminUserlog = New DevExpress.XtraNavBar.NavBarItem()
    Me.barNavAdminSystemLog = New DevExpress.XtraNavBar.NavBarItem()
    Me.barNavAdminSetting = New DevExpress.XtraNavBar.NavBarItem()
    Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
    Me.treeReport = New DevExpress.XtraTreeList.TreeList()
    Me.colTreeReport = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colTreeModule = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.imageManager = New System.Windows.Forms.ImageList(Me.components)
    Me.barNavReport = New DevExpress.XtraNavBar.NavBarGroup()
    Me.barNavSuperAdmin = New DevExpress.XtraNavBar.NavBarGroup()
    Me.barNavSuperAdminDatabase = New DevExpress.XtraNavBar.NavBarItem()
    Me.barNavSuperAdminModule = New DevExpress.XtraNavBar.NavBarItem()
    Me.barNavSuperAdminMenu = New DevExpress.XtraNavBar.NavBarItem()
    Me.barNavSuperAdminReport = New DevExpress.XtraNavBar.NavBarItem()
    Me.barNavSerial = New DevExpress.XtraNavBar.NavBarItem()
    Me.imageBarLarge = New System.Windows.Forms.ImageList(Me.components)
    Me.imageBarSmall = New System.Windows.Forms.ImageList(Me.components)
    Me.tabManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
    Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
    Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
    Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
    CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barDtDatabaseRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barDockController, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.dockMenu.SuspendLayout()
    Me.DockPanel1_Container.SuspendLayout()
    CType(Me.barNavControl, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.barNavControl.SuspendLayout()
    Me.NavBarGroupControlContainer1.SuspendLayout()
    CType(Me.treeReport, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.tabManager, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barManager
    '
    Me.barManager.AllowCustomization = False
    Me.barManager.AllowMoveBarOnToolbar = False
    Me.barManager.AllowQuickCustomization = False
    Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barStatus})
    Me.barManager.Controller = Me.barDockController
    Me.barManager.DockControls.Add(Me.BarDockControl1)
    Me.barManager.DockControls.Add(Me.BarDockControl2)
    Me.barManager.DockControls.Add(Me.BarDockControl3)
    Me.barManager.DockControls.Add(Me.BarDockControl4)
    Me.barManager.DockManager = Me.dockManager
    Me.barManager.Form = Me
    Me.barManager.HideBarsWhenMerging = False
    Me.barManager.Images = Me.imageManager
    Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barTxtDatabase, Me.barDtDatabase, Me.barSubTools, Me.barSubSkin, Me.barTxtUser, Me.barTxtVersi, Me.barTxtInfo, Me.barBtnCloseAllWindow, Me.barBtnChangePassword, Me.barBtnLogOff, Me.barBtnCekUpdate, Me.barTxtJam})
    Me.barManager.MaxItemId = 15
    Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.barDtDatabaseRepo})
    Me.barManager.StatusBar = Me.barStatus
    '
    'barStatus
    '
    Me.barStatus.BarName = "Status bar"
    Me.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.barStatus.DockCol = 0
    Me.barStatus.DockRow = 0
    Me.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.barStatus.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barTxtDatabase), New DevExpress.XtraBars.LinkPersistInfo(Me.barDtDatabase), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barSubTools, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubSkin, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barTxtUser, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barTxtVersi, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barTxtInfo, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Caption), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barTxtJam, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barStatus.OptionsBar.AllowQuickCustomization = False
    Me.barStatus.OptionsBar.DrawDragBorder = False
    Me.barStatus.OptionsBar.UseWholeRow = True
    Me.barStatus.Text = "Status bar"
    '
    'barTxtDatabase
    '
    Me.barTxtDatabase.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.barTxtDatabase.Caption = "Database :"
    Me.barTxtDatabase.Id = 0
    Me.barTxtDatabase.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.barTxtDatabase.ItemAppearance.Normal.Options.UseFont = True
    Me.barTxtDatabase.Name = "barTxtDatabase"
    Me.barTxtDatabase.TextAlignment = System.Drawing.StringAlignment.Near
    '
    'barDtDatabase
    '
    Me.barDtDatabase.Caption = "Database"
    Me.barDtDatabase.Edit = Me.barDtDatabaseRepo
    Me.barDtDatabase.Id = 2
    Me.barDtDatabase.Name = "barDtDatabase"
    Me.barDtDatabase.Width = 150
    '
    'barDtDatabaseRepo
    '
    Me.barDtDatabaseRepo.AutoHeight = False
    Me.barDtDatabaseRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.barDtDatabaseRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaAlias", "Nama", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending)})
    Me.barDtDatabaseRepo.DisplayMember = "NamaAlias"
    Me.barDtDatabaseRepo.DropDownRows = 15
    Me.barDtDatabaseRepo.Name = "barDtDatabaseRepo"
    Me.barDtDatabaseRepo.NullText = "<Pilih Database>"
    Me.barDtDatabaseRepo.ShowFooter = False
    Me.barDtDatabaseRepo.ShowHeader = False
    Me.barDtDatabaseRepo.ValueMember = "NamaDatabase"
    '
    'barSubTools
    '
    Me.barSubTools.Caption = "Tools"
    Me.barSubTools.Id = 3
    Me.barSubTools.ImageIndex = 0
    Me.barSubTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barBtnCloseAllWindow), New DevExpress.XtraBars.LinkPersistInfo(Me.barBtnChangePassword), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barBtnLogOff, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barBtnCekUpdate, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barSubTools.Name = "barSubTools"
    '
    'barBtnCloseAllWindow
    '
    Me.barBtnCloseAllWindow.Caption = "Tutup Semua Jendela"
    Me.barBtnCloseAllWindow.Id = 9
    Me.barBtnCloseAllWindow.Name = "barBtnCloseAllWindow"
    '
    'barBtnChangePassword
    '
    Me.barBtnChangePassword.Caption = "Ganti Password"
    Me.barBtnChangePassword.Id = 11
    Me.barBtnChangePassword.ImageIndex = 5
    Me.barBtnChangePassword.Name = "barBtnChangePassword"
    '
    'barBtnLogOff
    '
    Me.barBtnLogOff.Caption = "Log Off"
    Me.barBtnLogOff.Id = 12
    Me.barBtnLogOff.ImageIndex = 1
    Me.barBtnLogOff.Name = "barBtnLogOff"
    '
    'barBtnCekUpdate
    '
    Me.barBtnCekUpdate.Caption = "Cek Update"
    Me.barBtnCekUpdate.Id = 13
    Me.barBtnCekUpdate.ImageIndex = 2
    Me.barBtnCekUpdate.Name = "barBtnCekUpdate"
    '
    'barSubSkin
    '
    Me.barSubSkin.Caption = "Skin: "
    Me.barSubSkin.Id = 4
    Me.barSubSkin.Name = "barSubSkin"
    '
    'barTxtUser
    '
    Me.barTxtUser.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.barTxtUser.Id = 5
    Me.barTxtUser.ImageIndex = 3
    Me.barTxtUser.Name = "barTxtUser"
    Me.barTxtUser.TextAlignment = System.Drawing.StringAlignment.Near
    '
    'barTxtVersi
    '
    Me.barTxtVersi.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.barTxtVersi.Id = 6
    Me.barTxtVersi.ImageIndex = 4
    Me.barTxtVersi.Name = "barTxtVersi"
    Me.barTxtVersi.TextAlignment = System.Drawing.StringAlignment.Near
    '
    'barTxtInfo
    '
    Me.barTxtInfo.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
    Me.barTxtInfo.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.barTxtInfo.Id = 8
    Me.barTxtInfo.ImageIndex = 6
    Me.barTxtInfo.Name = "barTxtInfo"
    Me.barTxtInfo.TextAlignment = System.Drawing.StringAlignment.Far
    Me.barTxtInfo.Width = 32
    '
    'barTxtJam
    '
    Me.barTxtJam.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.barTxtJam.Id = 14
    Me.barTxtJam.ImageIndex = 7
    Me.barTxtJam.Name = "barTxtJam"
    Me.barTxtJam.TextAlignment = System.Drawing.StringAlignment.Near
    '
    'barDockController
    '
    Me.barDockController.AppearancesDocking.ActiveTab.Options.UseTextOptions = True
    Me.barDockController.AppearancesDocking.ActiveTab.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.barDockController.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
    Me.barDockController.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
    '
    'BarDockControl1
    '
    Me.BarDockControl1.CausesValidation = False
    Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
    Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
    Me.BarDockControl1.Size = New System.Drawing.Size(845, 0)
    '
    'BarDockControl2
    '
    Me.BarDockControl2.CausesValidation = False
    Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.BarDockControl2.Location = New System.Drawing.Point(0, 405)
    Me.BarDockControl2.Size = New System.Drawing.Size(845, 27)
    '
    'BarDockControl3
    '
    Me.BarDockControl3.CausesValidation = False
    Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
    Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
    Me.BarDockControl3.Size = New System.Drawing.Size(0, 405)
    '
    'BarDockControl4
    '
    Me.BarDockControl4.CausesValidation = False
    Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
    Me.BarDockControl4.Location = New System.Drawing.Point(845, 0)
    Me.BarDockControl4.Size = New System.Drawing.Size(0, 405)
    '
    'dockManager
    '
    Me.dockManager.AutoHiddenPanelCaptionShowMode = DevExpress.XtraBars.Docking.AutoHiddenPanelCaptionShowMode.ShowForActivePanel
    Me.dockManager.Controller = Me.barDockController
    Me.dockManager.DockingOptions.ShowCloseButton = False
    Me.dockManager.Form = Me
    Me.dockManager.MenuManager = Me.barManager
    Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockMenu})
    Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
    '
    'dockMenu
    '
    Me.dockMenu.Controls.Add(Me.DockPanel1_Container)
    Me.dockMenu.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
    Me.dockMenu.DockVertical = DevExpress.Utils.DefaultBoolean.[True]
    Me.dockMenu.FloatVertical = True
    Me.dockMenu.ID = New System.Guid("8729ff57-e57e-4db1-86b1-fd5ace06b5d0")
    Me.dockMenu.Location = New System.Drawing.Point(0, 0)
    Me.dockMenu.Name = "dockMenu"
    Me.dockMenu.OriginalSize = New System.Drawing.Size(200, 200)
    Me.dockMenu.Size = New System.Drawing.Size(200, 405)
    Me.dockMenu.Text = "PANEL MENU"
    '
    'DockPanel1_Container
    '
    Me.DockPanel1_Container.Controls.Add(Me.barNavControl)
    Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
    Me.DockPanel1_Container.Name = "DockPanel1_Container"
    Me.DockPanel1_Container.Size = New System.Drawing.Size(192, 378)
    Me.DockPanel1_Container.TabIndex = 0
    '
    'barNavControl
    '
    Me.barNavControl.ActiveGroup = Me.barNavAdmin
    Me.barNavControl.Controls.Add(Me.NavBarGroupControlContainer1)
    Me.barNavControl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.barNavControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.barNavReport, Me.barNavAdmin, Me.barNavSuperAdmin})
    Me.barNavControl.HideGroupCaptions = True
    Me.barNavControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.barNavAdminUserman, Me.barNavAdminUserlog, Me.barNavSuperAdminDatabase, Me.barNavSuperAdminReport, Me.barNavSuperAdminMenu, Me.barNavSuperAdminModule, Me.barNavAdminSystemLog, Me.barNavSerial, Me.barNavAdminSetting})
    Me.barNavControl.LargeImages = Me.imageBarLarge
    Me.barNavControl.Location = New System.Drawing.Point(0, 0)
    Me.barNavControl.Name = "barNavControl"
    Me.barNavControl.NavigationPaneMaxVisibleGroups = 5
    Me.barNavControl.OptionsNavPane.ExpandedWidth = 192
    Me.barNavControl.OptionsNavPane.ShowExpandButton = False
    Me.barNavControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
    Me.barNavControl.Size = New System.Drawing.Size(192, 378)
    Me.barNavControl.SmallImages = Me.imageBarSmall
    Me.barNavControl.StoreDefaultPaintStyleName = True
    Me.barNavControl.TabIndex = 0
    Me.barNavControl.Text = "NavBarControl1"
    '
    'barNavAdmin
    '
    Me.barNavAdmin.Caption = "Administrator"
    Me.barNavAdmin.Expanded = True
    Me.barNavAdmin.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
    Me.barNavAdmin.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
    Me.barNavAdmin.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavAdminUserman), New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavAdminUserlog), New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavAdminSystemLog), New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavAdminSetting)})
    Me.barNavAdmin.LargeImageIndex = 0
    Me.barNavAdmin.Name = "barNavAdmin"
    Me.barNavAdmin.SmallImageIndex = 0
    '
    'barNavAdminUserman
    '
    Me.barNavAdminUserman.Caption = "User Manager"
    Me.barNavAdminUserman.LargeImageIndex = 2
    Me.barNavAdminUserman.Name = "barNavAdminUserman"
    Me.barNavAdminUserman.SmallImageIndex = 2
    '
    'barNavAdminUserlog
    '
    Me.barNavAdminUserlog.Caption = "User Log"
    Me.barNavAdminUserlog.LargeImageIndex = 3
    Me.barNavAdminUserlog.Name = "barNavAdminUserlog"
    Me.barNavAdminUserlog.SmallImageIndex = 3
    '
    'barNavAdminSystemLog
    '
    Me.barNavAdminSystemLog.Caption = "System Log"
    Me.barNavAdminSystemLog.LargeImageIndex = 6
    Me.barNavAdminSystemLog.Name = "barNavAdminSystemLog"
    Me.barNavAdminSystemLog.SmallImageIndex = 6
    '
    'barNavAdminSetting
    '
    Me.barNavAdminSetting.Caption = "Setting"
    Me.barNavAdminSetting.LargeImageIndex = 7
    Me.barNavAdminSetting.Name = "barNavAdminSetting"
    Me.barNavAdminSetting.SmallImageIndex = 7
    '
    'NavBarGroupControlContainer1
    '
    Me.NavBarGroupControlContainer1.Controls.Add(Me.treeReport)
    Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
    Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(192, 189)
    Me.NavBarGroupControlContainer1.TabIndex = 0
    '
    'treeReport
    '
    Me.treeReport.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.treeReport.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colTreeReport, Me.colTreeModule})
    Me.treeReport.Dock = System.Windows.Forms.DockStyle.Fill
    Me.treeReport.KeyFieldName = "This"
    Me.treeReport.Location = New System.Drawing.Point(0, 0)
    Me.treeReport.Name = "treeReport"
    Me.treeReport.OptionsBehavior.Editable = False
    Me.treeReport.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.treeReport.OptionsView.ShowColumns = False
    Me.treeReport.OptionsView.ShowIndentAsRowStyle = True
    Me.treeReport.OptionsView.ShowIndicator = False
    Me.treeReport.ParentFieldName = "Induk"
    Me.treeReport.SelectImageList = Me.imageManager
    Me.treeReport.Size = New System.Drawing.Size(192, 189)
    Me.treeReport.TabIndex = 0
    '
    'colTreeReport
    '
    Me.colTreeReport.Caption = "Laporan"
    Me.colTreeReport.FieldName = "Nama"
    Me.colTreeReport.MinWidth = 35
    Me.colTreeReport.Name = "colTreeReport"
    Me.colTreeReport.OptionsColumn.AllowEdit = False
    Me.colTreeReport.OptionsColumn.AllowMove = False
    Me.colTreeReport.OptionsColumn.AllowMoveToCustomizationForm = False
    Me.colTreeReport.OptionsColumn.AllowSort = False
    Me.colTreeReport.OptionsColumn.ReadOnly = True
    Me.colTreeReport.OptionsColumn.ShowInCustomizationForm = False
    Me.colTreeReport.Visible = True
    Me.colTreeReport.VisibleIndex = 0
    '
    'colTreeModule
    '
    Me.colTreeModule.Caption = "Module"
    Me.colTreeModule.FieldName = "Modules.FileName"
    Me.colTreeModule.Name = "colTreeModule"
    '
    'imageManager
    '
    Me.imageManager.ImageStream = CType(resources.GetObject("imageManager.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageManager.TransparentColor = System.Drawing.Color.Transparent
    Me.imageManager.Images.SetKeyName(0, "toolbox.png")
    Me.imageManager.Images.SetKeyName(1, "sign.png")
    Me.imageManager.Images.SetKeyName(2, "update.png")
    Me.imageManager.Images.SetKeyName(3, "user_gray.png")
    Me.imageManager.Images.SetKeyName(4, "info_rhombus.png")
    Me.imageManager.Images.SetKeyName(5, "key_16.png")
    Me.imageManager.Images.SetKeyName(6, "clock_16.png")
    Me.imageManager.Images.SetKeyName(7, "calendar_16.png")
    Me.imageManager.Images.SetKeyName(8, "folder-open.png")
    Me.imageManager.Images.SetKeyName(9, "item.png")
    Me.imageManager.Images.SetKeyName(10, "folder-close.png")
    Me.imageManager.Images.SetKeyName(11, "report_user.png")
    '
    'barNavReport
    '
    Me.barNavReport.Caption = "Laporan"
    Me.barNavReport.ControlContainer = Me.NavBarGroupControlContainer1
    Me.barNavReport.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
    Me.barNavReport.GroupClientHeight = 80
    Me.barNavReport.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
    Me.barNavReport.LargeImageIndex = 5
    Me.barNavReport.Name = "barNavReport"
    Me.barNavReport.SmallImageIndex = 5
    '
    'barNavSuperAdmin
    '
    Me.barNavSuperAdmin.Caption = "Super Admin"
    Me.barNavSuperAdmin.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
    Me.barNavSuperAdmin.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
    Me.barNavSuperAdmin.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavSuperAdminDatabase), New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavSuperAdminModule), New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavSuperAdminMenu), New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavSuperAdminReport), New DevExpress.XtraNavBar.NavBarItemLink(Me.barNavSerial)})
    Me.barNavSuperAdmin.LargeImageIndex = 1
    Me.barNavSuperAdmin.Name = "barNavSuperAdmin"
    Me.barNavSuperAdmin.SmallImageIndex = 1
    '
    'barNavSuperAdminDatabase
    '
    Me.barNavSuperAdminDatabase.Caption = "Daftar Database"
    Me.barNavSuperAdminDatabase.LargeImageIndex = 4
    Me.barNavSuperAdminDatabase.Name = "barNavSuperAdminDatabase"
    Me.barNavSuperAdminDatabase.SmallImageIndex = 4
    '
    'barNavSuperAdminModule
    '
    Me.barNavSuperAdminModule.Caption = "Daftar Modul"
    Me.barNavSuperAdminModule.LargeImageIndex = 4
    Me.barNavSuperAdminModule.Name = "barNavSuperAdminModule"
    Me.barNavSuperAdminModule.SmallImageIndex = 4
    '
    'barNavSuperAdminMenu
    '
    Me.barNavSuperAdminMenu.Caption = "Daftar Menu"
    Me.barNavSuperAdminMenu.LargeImageIndex = 4
    Me.barNavSuperAdminMenu.Name = "barNavSuperAdminMenu"
    Me.barNavSuperAdminMenu.SmallImageIndex = 4
    '
    'barNavSuperAdminReport
    '
    Me.barNavSuperAdminReport.Caption = "Daftar Laporan"
    Me.barNavSuperAdminReport.LargeImageIndex = 4
    Me.barNavSuperAdminReport.Name = "barNavSuperAdminReport"
    Me.barNavSuperAdminReport.SmallImageIndex = 4
    '
    'barNavSerial
    '
    Me.barNavSerial.Caption = "Generate Serial"
    Me.barNavSerial.LargeImageIndex = 4
    Me.barNavSerial.Name = "barNavSerial"
    Me.barNavSerial.SmallImageIndex = 4
    Me.barNavSerial.Visible = False
    '
    'imageBarLarge
    '
    Me.imageBarLarge.ImageStream = CType(resources.GetObject("imageBarLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageBarLarge.TransparentColor = System.Drawing.Color.Transparent
    Me.imageBarLarge.Images.SetKeyName(0, "administrator.png")
    Me.imageBarLarge.Images.SetKeyName(1, "user_silhouette.png")
    Me.imageBarLarge.Images.SetKeyName(2, "user_add.png")
    Me.imageBarLarge.Images.SetKeyName(3, "user_comment.png")
    Me.imageBarLarge.Images.SetKeyName(4, "list.png")
    Me.imageBarLarge.Images.SetKeyName(5, "report.png")
    Me.imageBarLarge.Images.SetKeyName(6, "system_monitor.png")
    Me.imageBarLarge.Images.SetKeyName(7, "setting_tools.png")
    '
    'imageBarSmall
    '
    Me.imageBarSmall.ImageStream = CType(resources.GetObject("imageBarSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageBarSmall.TransparentColor = System.Drawing.Color.Transparent
    Me.imageBarSmall.Images.SetKeyName(0, "administrator.png")
    Me.imageBarSmall.Images.SetKeyName(1, "user_silhouette.png")
    Me.imageBarSmall.Images.SetKeyName(2, "user_add.png")
    Me.imageBarSmall.Images.SetKeyName(3, "user_comment.png")
    Me.imageBarSmall.Images.SetKeyName(4, "list.png")
    Me.imageBarSmall.Images.SetKeyName(5, "report.png")
    Me.imageBarSmall.Images.SetKeyName(6, "system_monitor.png")
    Me.imageBarSmall.Images.SetKeyName(7, "setting_tools.png")
    '
    'tabManager
    '
    Me.tabManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
    Me.tabManager.Controller = Me.barDockController
    Me.tabManager.MdiParent = Me
    '
    'tmrJam
    '
    Me.tmrJam.Enabled = True
    Me.tmrJam.Interval = 1000
    '
    'tmrUpdate
    '
    Me.tmrUpdate.Enabled = True
    Me.tmrUpdate.Interval = 300000
    '
    'BackgroundWorker1
    '
    Me.BackgroundWorker1.WorkerReportsProgress = True
    Me.BackgroundWorker1.WorkerSupportsCancellation = True
    '
    'x_Main
    '
    Me.AllowMdiBar = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(845, 432)
    Me.Controls.Add(Me.dockMenu)
    Me.Controls.Add(Me.BarDockControl3)
    Me.Controls.Add(Me.BarDockControl4)
    Me.Controls.Add(Me.BarDockControl2)
    Me.Controls.Add(Me.BarDockControl1)
    Me.IsMdiContainer = True
    Me.Name = "x_Main"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "x_Main"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barDtDatabaseRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barDockController, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
    Me.dockMenu.ResumeLayout(False)
    Me.DockPanel1_Container.ResumeLayout(False)
    CType(Me.barNavControl, System.ComponentModel.ISupportInitialize).EndInit()
    Me.barNavControl.ResumeLayout(False)
    Me.NavBarGroupControlContainer1.ResumeLayout(False)
    CType(Me.treeReport, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.tabManager, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tabManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
  Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barManager As DevExpress.XtraBars.BarManager
  Friend WithEvents barStatus As DevExpress.XtraBars.Bar
  Friend WithEvents barTxtDatabase As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents barDtDatabase As DevExpress.XtraBars.BarEditItem
  Friend WithEvents barDtDatabaseRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents barSubTools As DevExpress.XtraBars.BarSubItem
  Friend WithEvents barSubSkin As DevExpress.XtraBars.BarSubItem
  Friend WithEvents barTxtUser As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents barTxtVersi As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents barTxtInfo As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents barBtnCloseAllWindow As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barBtnChangePassword As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barBtnLogOff As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barBtnCekUpdate As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents tmrJam As System.Windows.Forms.Timer
  Friend WithEvents imageManager As System.Windows.Forms.ImageList
  Friend WithEvents barTxtJam As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents dockManager As DevExpress.XtraBars.Docking.DockManager
  Friend WithEvents barDockController As DevExpress.XtraBars.BarAndDockingController
  Friend WithEvents dockMenu As DevExpress.XtraBars.Docking.DockPanel
  Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
  Friend WithEvents barNavControl As DevExpress.XtraNavBar.NavBarControl
  Friend WithEvents barNavAdmin As DevExpress.XtraNavBar.NavBarGroup
  Friend WithEvents barNavSuperAdmin As DevExpress.XtraNavBar.NavBarGroup
  Friend WithEvents imageBarLarge As System.Windows.Forms.ImageList
  Friend WithEvents imageBarSmall As System.Windows.Forms.ImageList
  Friend WithEvents barNavAdminUserman As DevExpress.XtraNavBar.NavBarItem
  Friend WithEvents barNavAdminUserlog As DevExpress.XtraNavBar.NavBarItem
  Friend WithEvents barNavSuperAdminDatabase As DevExpress.XtraNavBar.NavBarItem
  Friend WithEvents barNavSuperAdminModule As DevExpress.XtraNavBar.NavBarItem
  Friend WithEvents barNavSuperAdminMenu As DevExpress.XtraNavBar.NavBarItem
  Friend WithEvents barNavSuperAdminReport As DevExpress.XtraNavBar.NavBarItem
  Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
  Friend WithEvents barNavReport As DevExpress.XtraNavBar.NavBarGroup
  Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
  Friend WithEvents treeReport As DevExpress.XtraTreeList.TreeList
  Friend WithEvents colTreeReport As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colTreeModule As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents barNavAdminSystemLog As DevExpress.XtraNavBar.NavBarItem
  Friend WithEvents barNavSerial As DevExpress.XtraNavBar.NavBarItem
  Friend WithEvents barNavAdminSetting As DevExpress.XtraNavBar.NavBarItem
End Class
