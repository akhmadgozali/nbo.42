<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIX_UserManagerDialog
  Inherits Core.Win.Forms.InputDialog

    'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        xpMenu.Dispose()
        xpReport.Dispose()
        xpUserMenu.Dispose()
        xpUserReport.Dispose()
        xpUserRegional.Dispose()
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
		Me.xTabControl = New DevExpress.XtraTab.XtraTabControl()
		Me.xTabUser = New DevExpress.XtraTab.XtraTabPage()
		Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
		Me.txtDivisiTertentu = New DevExpress.XtraEditors.CheckEdit()
		Me.txtLevel = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.txtWilayahTertentu = New DevExpress.XtraEditors.CheckEdit()
		Me.txtAktif = New DevExpress.XtraEditors.CheckEdit()
		Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
		Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.txtNama = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.txtUser = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.txtDashboardModul = New DevExpress.XtraEditors.CheckedComboBoxEdit()
		Me.txtDashboardId = New DevExpress.XtraEditors.SpinEdit()
		Me.txtHomeMenu = New DevExpress.XtraEditors.TreeListLookUpEdit()
		Me.TreeListLookUpEdit1TreeList = New DevExpress.XtraTreeList.TreeList()
		Me.colMenuNama = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.xTabMenu = New DevExpress.XtraTab.XtraTabPage()
		Me.treeMenu = New DevExpress.XtraTreeList.TreeList()
		Me.colMenu = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colBuka = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colTambah = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colEdit = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colHapus = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colEksport = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colCetak = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
		Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
		Me.txtDbMenu = New DevExpress.XtraEditors.LookUpEdit()
		Me.xpDb = New DevExpress.Xpo.XPCollection(Me.components)
		Me.xTabReport = New DevExpress.XtraTab.XtraTabPage()
		Me.treeReport = New DevExpress.XtraTreeList.TreeList()
		Me.colReportName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colReportBuka = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colReportEksport = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colReportCetak = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
		Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
		Me.txtDbReport = New DevExpress.XtraEditors.LookUpEdit()
		Me.xTabRegional = New DevExpress.XtraTab.XtraTabPage()
		Me.treeRegional = New DevExpress.XtraTreeList.TreeList()
		Me.colRegionalNama = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colRegionalBuka = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.colRegionalDefault = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
		Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
		Me.txtDbRegional = New DevExpress.XtraEditors.LookUpEdit()
		Me.xTabDivisi = New DevExpress.XtraTab.XtraTabPage()
		Me.treeDivisi = New DevExpress.XtraTreeList.TreeList()
		Me.treeDivisiName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.treeDivisiOpen = New DevExpress.XtraTreeList.Columns.TreeListColumn()
		Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
		Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
		Me.txtDbDivisi = New DevExpress.XtraEditors.LookUpEdit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.xTabControl.SuspendLayout()
		Me.xTabUser.SuspendLayout()
		CType(Me.txtDivisiTertentu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtWilayahTertentu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDashboardModul.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDashboardId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtHomeMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TreeListLookUpEdit1TreeList, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.xTabMenu.SuspendLayout()
		CType(Me.treeMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl2.SuspendLayout()
		CType(Me.txtDbMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpDb, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.xTabReport.SuspendLayout()
		CType(Me.treeReport, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl3.SuspendLayout()
		CType(Me.txtDbReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.xTabRegional.SuspendLayout()
		CType(Me.treeRegional, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl4.SuspendLayout()
		CType(Me.txtDbRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.xTabDivisi.SuspendLayout()
		CType(Me.treeDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl5.SuspendLayout()
		CType(Me.txtDbDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xTabControl
		'
		Me.xTabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xTabControl.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
		Me.xTabControl.Location = New System.Drawing.Point(0, 0)
		Me.xTabControl.Name = "xTabControl"
		Me.xTabControl.SelectedTabPage = Me.xTabUser
		Me.xTabControl.Size = New System.Drawing.Size(530, 359)
		Me.xTabControl.TabIndex = 0
		Me.xTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xTabUser, Me.xTabMenu, Me.xTabReport, Me.xTabRegional, Me.xTabDivisi})
		'
		'xTabUser
		'
		Me.xTabUser.Appearance.Header.Options.UseTextOptions = True
		Me.xTabUser.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.xTabUser.Controls.Add(Me.LabelControl12)
		Me.xTabUser.Controls.Add(Me.LabelControl11)
		Me.xTabUser.Controls.Add(Me.LabelControl10)
		Me.xTabUser.Controls.Add(Me.txtDivisiTertentu)
		Me.xTabUser.Controls.Add(Me.txtLevel)
		Me.xTabUser.Controls.Add(Me.txtWilayahTertentu)
		Me.xTabUser.Controls.Add(Me.txtAktif)
		Me.xTabUser.Controls.Add(Me.txtKeterangan)
		Me.xTabUser.Controls.Add(Me.LabelControl5)
		Me.xTabUser.Controls.Add(Me.LabelControl4)
		Me.xTabUser.Controls.Add(Me.txtPassword)
		Me.xTabUser.Controls.Add(Me.LabelControl3)
		Me.xTabUser.Controls.Add(Me.txtNama)
		Me.xTabUser.Controls.Add(Me.LabelControl2)
		Me.xTabUser.Controls.Add(Me.txtUser)
		Me.xTabUser.Controls.Add(Me.LabelControl1)
		Me.xTabUser.Controls.Add(Me.txtDashboardModul)
		Me.xTabUser.Controls.Add(Me.txtDashboardId)
		Me.xTabUser.Controls.Add(Me.txtHomeMenu)
		Me.xTabUser.Name = "xTabUser"
		Me.xTabUser.Size = New System.Drawing.Size(524, 331)
		Me.xTabUser.Text = "Info User"
		'
		'LabelControl12
		'
		Me.LabelControl12.Location = New System.Drawing.Point(19, 212)
		Me.LabelControl12.Name = "LabelControl12"
		Me.LabelControl12.Size = New System.Drawing.Size(56, 13)
		Me.LabelControl12.TabIndex = 101
		Me.LabelControl12.Text = "Home Menu"
		'
		'LabelControl11
		'
		Me.LabelControl11.Location = New System.Drawing.Point(20, 160)
		Me.LabelControl11.Name = "LabelControl11"
		Me.LabelControl11.Size = New System.Drawing.Size(65, 13)
		Me.LabelControl11.TabIndex = 100
		Me.LabelControl11.Text = "Dashboard Id"
		'
		'LabelControl10
		'
		Me.LabelControl10.Location = New System.Drawing.Point(19, 186)
		Me.LabelControl10.Name = "LabelControl10"
		Me.LabelControl10.Size = New System.Drawing.Size(83, 13)
		Me.LabelControl10.TabIndex = 100
		Me.LabelControl10.Text = "Dashboard Modul"
		'
		'txtDivisiTertentu
		'
		Me.txtDivisiTertentu.Location = New System.Drawing.Point(111, 285)
		Me.txtDivisiTertentu.Name = "txtDivisiTertentu"
		Me.txtDivisiTertentu.Properties.Caption = "Divisi terbatas pada daftar"
		Me.txtDivisiTertentu.Size = New System.Drawing.Size(152, 19)
		Me.txtDivisiTertentu.TabIndex = 12
		'
		'txtLevel
		'
		Me.txtLevel.EnterMoveNextControl = True
		Me.txtLevel.Location = New System.Drawing.Point(113, 105)
		Me.txtLevel.Name = "txtLevel"
		Me.txtLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtLevel.Properties.Items.AddRange(New Object() {"User X", "User", "Administrator", "Super Admin"})
		Me.txtLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.txtLevel.Size = New System.Drawing.Size(310, 20)
		Me.txtLevel.TabIndex = 3
		'
		'txtWilayahTertentu
		'
		Me.txtWilayahTertentu.Location = New System.Drawing.Point(111, 260)
		Me.txtWilayahTertentu.Name = "txtWilayahTertentu"
		Me.txtWilayahTertentu.Properties.Caption = "Regional terbatas pada daftar"
		Me.txtWilayahTertentu.Size = New System.Drawing.Size(169, 19)
		Me.txtWilayahTertentu.TabIndex = 6
		'
		'txtAktif
		'
		Me.txtAktif.Location = New System.Drawing.Point(111, 235)
		Me.txtAktif.Name = "txtAktif"
		Me.txtAktif.Properties.Caption = "Aktif"
		Me.txtAktif.Size = New System.Drawing.Size(48, 19)
		Me.txtAktif.TabIndex = 5
		'
		'txtKeterangan
		'
		Me.txtKeterangan.EnterMoveNextControl = True
		Me.txtKeterangan.Location = New System.Drawing.Point(113, 131)
		Me.txtKeterangan.Name = "txtKeterangan"
		Me.txtKeterangan.Size = New System.Drawing.Size(310, 20)
		Me.txtKeterangan.TabIndex = 4
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(20, 134)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
		Me.LabelControl5.TabIndex = 7
		Me.LabelControl5.Text = "Keterangan"
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(20, 108)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
		Me.LabelControl4.TabIndex = 8
		Me.LabelControl4.Text = "Level"
		'
		'txtPassword
		'
		Me.txtPassword.EnterMoveNextControl = True
		Me.txtPassword.Location = New System.Drawing.Point(113, 79)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(310, 20)
		Me.txtPassword.TabIndex = 2
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(20, 82)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl3.TabIndex = 9
		Me.LabelControl3.Text = "Password"
		'
		'txtNama
		'
		Me.txtNama.EnterMoveNextControl = True
		Me.txtNama.Location = New System.Drawing.Point(113, 53)
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Size = New System.Drawing.Size(310, 20)
		Me.txtNama.TabIndex = 1
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(20, 56)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
		Me.LabelControl2.TabIndex = 10
		Me.LabelControl2.Text = "Nama"
		'
		'txtUser
		'
		Me.txtUser.EnterMoveNextControl = True
		Me.txtUser.Location = New System.Drawing.Point(113, 27)
		Me.txtUser.Name = "txtUser"
		Me.txtUser.Size = New System.Drawing.Size(310, 20)
		Me.txtUser.TabIndex = 0
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(20, 30)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
		Me.LabelControl1.TabIndex = 11
		Me.LabelControl1.Text = "User ID"
		'
		'txtDashboardModul
		'
		Me.txtDashboardModul.EnterMoveNextControl = True
		Me.txtDashboardModul.Location = New System.Drawing.Point(112, 183)
		Me.txtDashboardModul.Name = "txtDashboardModul"
		Me.txtDashboardModul.Properties.AutoHeight = False
		Me.txtDashboardModul.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDashboardModul.Properties.DisplayMember = "Nama"
		Me.txtDashboardModul.Properties.ValueMember = "Id"
		Me.txtDashboardModul.Size = New System.Drawing.Size(310, 20)
		Me.txtDashboardModul.TabIndex = 100
		'
		'txtDashboardId
		'
		Me.txtDashboardId.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtDashboardId.EnterMoveNextControl = True
		Me.txtDashboardId.Location = New System.Drawing.Point(112, 157)
		Me.txtDashboardId.Name = "txtDashboardId"
		Me.txtDashboardId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDashboardId.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtDashboardId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.txtDashboardId.Size = New System.Drawing.Size(310, 20)
		Me.txtDashboardId.TabIndex = 100
		'
		'txtHomeMenu
		'
		Me.txtHomeMenu.Location = New System.Drawing.Point(112, 209)
		Me.txtHomeMenu.Name = "txtHomeMenu"
		Me.txtHomeMenu.Properties.AutoHeight = False
		Me.txtHomeMenu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
		Me.txtHomeMenu.Properties.DisplayMember = "MenuNama"
		Me.txtHomeMenu.Properties.NullText = ""
		Me.txtHomeMenu.Properties.TreeList = Me.TreeListLookUpEdit1TreeList
		Me.txtHomeMenu.Properties.ValueMember = "Menu"
		Me.txtHomeMenu.Size = New System.Drawing.Size(310, 20)
		Me.txtHomeMenu.TabIndex = 101
		'
		'TreeListLookUpEdit1TreeList
		'
		Me.TreeListLookUpEdit1TreeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colMenuNama})
		Me.TreeListLookUpEdit1TreeList.KeyFieldName = "Menu"
		Me.TreeListLookUpEdit1TreeList.Location = New System.Drawing.Point(0, 0)
		Me.TreeListLookUpEdit1TreeList.Name = "TreeListLookUpEdit1TreeList"
		Me.TreeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = True
		Me.TreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = True
		Me.TreeListLookUpEdit1TreeList.ParentFieldName = "MenuParent"
		Me.TreeListLookUpEdit1TreeList.Size = New System.Drawing.Size(400, 200)
		Me.TreeListLookUpEdit1TreeList.TabIndex = 0
		'
		'colMenuNama
		'
		Me.colMenuNama.Caption = "Menu"
		Me.colMenuNama.FieldName = "MenuNama"
		Me.colMenuNama.Name = "colMenuNama"
		Me.colMenuNama.Visible = True
		Me.colMenuNama.VisibleIndex = 0
		'
		'xTabMenu
		'
		Me.xTabMenu.Appearance.Header.Options.UseTextOptions = True
		Me.xTabMenu.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.xTabMenu.Controls.Add(Me.treeMenu)
		Me.xTabMenu.Controls.Add(Me.PanelControl2)
		Me.xTabMenu.Name = "xTabMenu"
		Me.xTabMenu.Size = New System.Drawing.Size(524, 331)
		Me.xTabMenu.Text = "Menu"
		'
		'treeMenu
		'
		Me.treeMenu.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colMenu, Me.colBuka, Me.colTambah, Me.colEdit, Me.colHapus, Me.colEksport, Me.colCetak})
		Me.treeMenu.Dock = System.Windows.Forms.DockStyle.Fill
		Me.treeMenu.KeyFieldName = "Menu"
		Me.treeMenu.Location = New System.Drawing.Point(0, 43)
		Me.treeMenu.Name = "treeMenu"
		Me.treeMenu.ParentFieldName = "MenuParent"
		Me.treeMenu.Size = New System.Drawing.Size(524, 288)
		Me.treeMenu.TabIndex = 1
		'
		'colMenu
		'
		Me.colMenu.Caption = "Menu"
		Me.colMenu.FieldName = "MenuNama"
		Me.colMenu.Name = "colMenu"
		Me.colMenu.OptionsColumn.AllowEdit = False
		Me.colMenu.OptionsColumn.AllowSort = False
		Me.colMenu.OptionsColumn.ReadOnly = True
		Me.colMenu.Visible = True
		Me.colMenu.VisibleIndex = 0
		Me.colMenu.Width = 180
		'
		'colBuka
		'
		Me.colBuka.AppearanceHeader.Options.UseTextOptions = True
		Me.colBuka.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colBuka.FieldName = "Buka"
		Me.colBuka.Name = "colBuka"
		Me.colBuka.OptionsColumn.AllowSort = False
		Me.colBuka.Visible = True
		Me.colBuka.VisibleIndex = 1
		Me.colBuka.Width = 30
		'
		'colTambah
		'
		Me.colTambah.AppearanceHeader.Options.UseTextOptions = True
		Me.colTambah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colTambah.FieldName = "Tambah"
		Me.colTambah.Name = "colTambah"
		Me.colTambah.OptionsColumn.AllowSort = False
		Me.colTambah.Visible = True
		Me.colTambah.VisibleIndex = 2
		Me.colTambah.Width = 30
		'
		'colEdit
		'
		Me.colEdit.AppearanceHeader.Options.UseTextOptions = True
		Me.colEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colEdit.FieldName = "Edit"
		Me.colEdit.Name = "colEdit"
		Me.colEdit.OptionsColumn.AllowSort = False
		Me.colEdit.Visible = True
		Me.colEdit.VisibleIndex = 3
		Me.colEdit.Width = 30
		'
		'colHapus
		'
		Me.colHapus.AppearanceHeader.Options.UseTextOptions = True
		Me.colHapus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colHapus.FieldName = "Hapus"
		Me.colHapus.Name = "colHapus"
		Me.colHapus.OptionsColumn.AllowSort = False
		Me.colHapus.Visible = True
		Me.colHapus.VisibleIndex = 4
		Me.colHapus.Width = 30
		'
		'colEksport
		'
		Me.colEksport.AppearanceHeader.Options.UseTextOptions = True
		Me.colEksport.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colEksport.FieldName = "Eksport"
		Me.colEksport.Name = "colEksport"
		Me.colEksport.OptionsColumn.AllowSort = False
		Me.colEksport.Visible = True
		Me.colEksport.VisibleIndex = 5
		Me.colEksport.Width = 30
		'
		'colCetak
		'
		Me.colCetak.AppearanceHeader.Options.UseTextOptions = True
		Me.colCetak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colCetak.FieldName = "Cetak"
		Me.colCetak.Name = "colCetak"
		Me.colCetak.OptionsColumn.AllowSort = False
		Me.colCetak.Visible = True
		Me.colCetak.VisibleIndex = 6
		Me.colCetak.Width = 30
		'
		'PanelControl2
		'
		Me.PanelControl2.Controls.Add(Me.LabelControl6)
		Me.PanelControl2.Controls.Add(Me.txtDbMenu)
		Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
		Me.PanelControl2.Name = "PanelControl2"
		Me.PanelControl2.Size = New System.Drawing.Size(524, 43)
		Me.PanelControl2.TabIndex = 0
		'
		'LabelControl6
		'
		Me.LabelControl6.Location = New System.Drawing.Point(50, 15)
		Me.LabelControl6.Name = "LabelControl6"
		Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl6.TabIndex = 1
		Me.LabelControl6.Text = "Database"
		'
		'txtDbMenu
		'
		Me.txtDbMenu.Location = New System.Drawing.Point(122, 12)
		Me.txtDbMenu.Name = "txtDbMenu"
		Me.txtDbMenu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDbMenu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaAlias", "Name1")})
		Me.txtDbMenu.Properties.DataSource = Me.xpDb
		Me.txtDbMenu.Properties.DisplayMember = "NamaAlias"
		Me.txtDbMenu.Properties.NullText = "<Pilih Database>"
		Me.txtDbMenu.Properties.ShowHeader = False
		Me.txtDbMenu.Properties.ValueMember = "This"
		Me.txtDbMenu.Size = New System.Drawing.Size(208, 20)
		Me.txtDbMenu.TabIndex = 0
		'
		'xpDb
		'
		Me.xpDb.CriteriaString = "[Aktif] = True"
		Me.xpDb.ObjectType = GetType(NuSoft.NPO.SSystem.Database)
		'
		'xTabReport
		'
		Me.xTabReport.Appearance.Header.Options.UseTextOptions = True
		Me.xTabReport.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.xTabReport.Controls.Add(Me.treeReport)
		Me.xTabReport.Controls.Add(Me.PanelControl3)
		Me.xTabReport.Name = "xTabReport"
		Me.xTabReport.Size = New System.Drawing.Size(524, 331)
		Me.xTabReport.Text = "Laporan"
		'
		'treeReport
		'
		Me.treeReport.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colReportName, Me.colReportBuka, Me.colReportEksport, Me.colReportCetak})
		Me.treeReport.Dock = System.Windows.Forms.DockStyle.Fill
		Me.treeReport.KeyFieldName = "Report"
		Me.treeReport.Location = New System.Drawing.Point(0, 43)
		Me.treeReport.Name = "treeReport"
		Me.treeReport.ParentFieldName = "ReportParent"
		Me.treeReport.Size = New System.Drawing.Size(524, 288)
		Me.treeReport.TabIndex = 3
		'
		'colReportName
		'
		Me.colReportName.Caption = "Nama"
		Me.colReportName.FieldName = "ReportNama"
		Me.colReportName.Name = "colReportName"
		Me.colReportName.OptionsColumn.AllowEdit = False
		Me.colReportName.OptionsColumn.AllowSort = False
		Me.colReportName.OptionsColumn.ReadOnly = True
		Me.colReportName.Visible = True
		Me.colReportName.VisibleIndex = 0
		Me.colReportName.Width = 300
		'
		'colReportBuka
		'
		Me.colReportBuka.AppearanceHeader.Options.UseTextOptions = True
		Me.colReportBuka.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colReportBuka.Caption = "Buka"
		Me.colReportBuka.FieldName = "Buka"
		Me.colReportBuka.Name = "colReportBuka"
		Me.colReportBuka.OptionsColumn.AllowSort = False
		Me.colReportBuka.Visible = True
		Me.colReportBuka.VisibleIndex = 1
		'
		'colReportEksport
		'
		Me.colReportEksport.AppearanceHeader.Options.UseTextOptions = True
		Me.colReportEksport.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colReportEksport.Caption = "Eksport"
		Me.colReportEksport.FieldName = "Eksport"
		Me.colReportEksport.Name = "colReportEksport"
		Me.colReportEksport.OptionsColumn.AllowSort = False
		Me.colReportEksport.Visible = True
		Me.colReportEksport.VisibleIndex = 2
		'
		'colReportCetak
		'
		Me.colReportCetak.AppearanceHeader.Options.UseTextOptions = True
		Me.colReportCetak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colReportCetak.Caption = "Cetak"
		Me.colReportCetak.FieldName = "Cetak"
		Me.colReportCetak.Name = "colReportCetak"
		Me.colReportCetak.OptionsColumn.AllowSort = False
		Me.colReportCetak.Visible = True
		Me.colReportCetak.VisibleIndex = 3
		'
		'PanelControl3
		'
		Me.PanelControl3.Controls.Add(Me.LabelControl7)
		Me.PanelControl3.Controls.Add(Me.txtDbReport)
		Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
		Me.PanelControl3.Name = "PanelControl3"
		Me.PanelControl3.Size = New System.Drawing.Size(524, 43)
		Me.PanelControl3.TabIndex = 2
		'
		'LabelControl7
		'
		Me.LabelControl7.Location = New System.Drawing.Point(50, 15)
		Me.LabelControl7.Name = "LabelControl7"
		Me.LabelControl7.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl7.TabIndex = 1
		Me.LabelControl7.Text = "Database"
		'
		'txtDbReport
		'
		Me.txtDbReport.Location = New System.Drawing.Point(122, 12)
		Me.txtDbReport.Name = "txtDbReport"
		Me.txtDbReport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDbReport.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaAlias", "Name2")})
		Me.txtDbReport.Properties.DataSource = Me.xpDb
		Me.txtDbReport.Properties.DisplayMember = "NamaAlias"
		Me.txtDbReport.Properties.NullText = "<Pilih Database>"
		Me.txtDbReport.Properties.ShowHeader = False
		Me.txtDbReport.Properties.ValueMember = "This"
		Me.txtDbReport.Size = New System.Drawing.Size(208, 20)
		Me.txtDbReport.TabIndex = 0
		'
		'xTabRegional
		'
		Me.xTabRegional.Appearance.Header.Options.UseTextOptions = True
		Me.xTabRegional.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.xTabRegional.Controls.Add(Me.treeRegional)
		Me.xTabRegional.Controls.Add(Me.PanelControl4)
		Me.xTabRegional.Name = "xTabRegional"
		Me.xTabRegional.Size = New System.Drawing.Size(524, 331)
		Me.xTabRegional.Text = "Regional"
		'
		'treeRegional
		'
		Me.treeRegional.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colRegionalNama, Me.colRegionalBuka, Me.colRegionalDefault})
		Me.treeRegional.Dock = System.Windows.Forms.DockStyle.Fill
		Me.treeRegional.Location = New System.Drawing.Point(0, 43)
		Me.treeRegional.Name = "treeRegional"
		Me.treeRegional.Size = New System.Drawing.Size(524, 288)
		Me.treeRegional.TabIndex = 3
		'
		'colRegionalNama
		'
		Me.colRegionalNama.Caption = "Nama Regional"
		Me.colRegionalNama.FieldName = "RegionalNama"
		Me.colRegionalNama.Name = "colRegionalNama"
		Me.colRegionalNama.OptionsColumn.AllowEdit = False
		Me.colRegionalNama.OptionsColumn.AllowSort = False
		Me.colRegionalNama.OptionsColumn.ReadOnly = True
		Me.colRegionalNama.Visible = True
		Me.colRegionalNama.VisibleIndex = 0
		Me.colRegionalNama.Width = 350
		'
		'colRegionalBuka
		'
		Me.colRegionalBuka.AppearanceHeader.Options.UseTextOptions = True
		Me.colRegionalBuka.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colRegionalBuka.Caption = "Buka"
		Me.colRegionalBuka.FieldName = "Buka"
		Me.colRegionalBuka.Name = "colRegionalBuka"
		Me.colRegionalBuka.OptionsColumn.AllowSort = False
		Me.colRegionalBuka.Visible = True
		Me.colRegionalBuka.VisibleIndex = 1
		'
		'colRegionalDefault
		'
		Me.colRegionalDefault.AppearanceHeader.Options.UseTextOptions = True
		Me.colRegionalDefault.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colRegionalDefault.Caption = "Default"
		Me.colRegionalDefault.FieldName = "IsDefault"
		Me.colRegionalDefault.Name = "colRegionalDefault"
		Me.colRegionalDefault.Visible = True
		Me.colRegionalDefault.VisibleIndex = 2
		'
		'PanelControl4
		'
		Me.PanelControl4.Controls.Add(Me.LabelControl8)
		Me.PanelControl4.Controls.Add(Me.txtDbRegional)
		Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
		Me.PanelControl4.Name = "PanelControl4"
		Me.PanelControl4.Size = New System.Drawing.Size(524, 43)
		Me.PanelControl4.TabIndex = 2
		'
		'LabelControl8
		'
		Me.LabelControl8.Location = New System.Drawing.Point(50, 15)
		Me.LabelControl8.Name = "LabelControl8"
		Me.LabelControl8.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl8.TabIndex = 1
		Me.LabelControl8.Text = "Database"
		'
		'txtDbRegional
		'
		Me.txtDbRegional.Location = New System.Drawing.Point(122, 12)
		Me.txtDbRegional.Name = "txtDbRegional"
		Me.txtDbRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDbRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaAlias", "Name5")})
		Me.txtDbRegional.Properties.DataSource = Me.xpDb
		Me.txtDbRegional.Properties.DisplayMember = "NamaAlias"
		Me.txtDbRegional.Properties.NullText = "<Pilih Database>"
		Me.txtDbRegional.Properties.ShowHeader = False
		Me.txtDbRegional.Properties.ValueMember = "This"
		Me.txtDbRegional.Size = New System.Drawing.Size(208, 20)
		Me.txtDbRegional.TabIndex = 0
		'
		'xTabDivisi
		'
		Me.xTabDivisi.Appearance.Header.Options.UseTextOptions = True
		Me.xTabDivisi.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.xTabDivisi.Controls.Add(Me.treeDivisi)
		Me.xTabDivisi.Controls.Add(Me.PanelControl5)
		Me.xTabDivisi.Name = "xTabDivisi"
		Me.xTabDivisi.Size = New System.Drawing.Size(524, 331)
		Me.xTabDivisi.Text = "Divisi"
		'
		'treeDivisi
		'
		Me.treeDivisi.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeDivisiName, Me.treeDivisiOpen})
		Me.treeDivisi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.treeDivisi.Location = New System.Drawing.Point(0, 43)
		Me.treeDivisi.Name = "treeDivisi"
		Me.treeDivisi.Size = New System.Drawing.Size(524, 288)
		Me.treeDivisi.TabIndex = 5
		'
		'treeDivisiName
		'
		Me.treeDivisiName.Caption = "Nama Divisi"
		Me.treeDivisiName.FieldName = "DivisiNama"
		Me.treeDivisiName.Name = "treeDivisiName"
		Me.treeDivisiName.OptionsColumn.AllowEdit = False
		Me.treeDivisiName.OptionsColumn.AllowSort = False
		Me.treeDivisiName.OptionsColumn.ReadOnly = True
		Me.treeDivisiName.Visible = True
		Me.treeDivisiName.VisibleIndex = 0
		Me.treeDivisiName.Width = 350
		'
		'treeDivisiOpen
		'
		Me.treeDivisiOpen.AppearanceHeader.Options.UseTextOptions = True
		Me.treeDivisiOpen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.treeDivisiOpen.Caption = "Buka"
		Me.treeDivisiOpen.FieldName = "Buka"
		Me.treeDivisiOpen.Name = "treeDivisiOpen"
		Me.treeDivisiOpen.OptionsColumn.AllowSort = False
		Me.treeDivisiOpen.Visible = True
		Me.treeDivisiOpen.VisibleIndex = 1
		'
		'PanelControl5
		'
		Me.PanelControl5.Controls.Add(Me.LabelControl9)
		Me.PanelControl5.Controls.Add(Me.txtDbDivisi)
		Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
		Me.PanelControl5.Name = "PanelControl5"
		Me.PanelControl5.Size = New System.Drawing.Size(524, 43)
		Me.PanelControl5.TabIndex = 4
		'
		'LabelControl9
		'
		Me.LabelControl9.Location = New System.Drawing.Point(50, 15)
		Me.LabelControl9.Name = "LabelControl9"
		Me.LabelControl9.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl9.TabIndex = 1
		Me.LabelControl9.Text = "Database"
		'
		'txtDbDivisi
		'
		Me.txtDbDivisi.Location = New System.Drawing.Point(122, 12)
		Me.txtDbDivisi.Name = "txtDbDivisi"
		Me.txtDbDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDbDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaAlias", "Name5")})
		Me.txtDbDivisi.Properties.DataSource = Me.xpDb
		Me.txtDbDivisi.Properties.DisplayMember = "NamaAlias"
		Me.txtDbDivisi.Properties.NullText = "<Pilih Database>"
		Me.txtDbDivisi.Properties.ShowHeader = False
		Me.txtDbDivisi.Properties.ValueMember = "This"
		Me.txtDbDivisi.Size = New System.Drawing.Size(208, 20)
		Me.txtDbDivisi.TabIndex = 0
		'
		'UIX_UserManagerDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(530, 408)
		Me.Controls.Add(Me.xTabControl)
		Me.Name = "UIX_UserManagerDialog"
		Me.Text = "User Manager"
		Me.Controls.SetChildIndex(Me.xTabControl, 0)
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xTabControl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.xTabControl.ResumeLayout(False)
		Me.xTabUser.ResumeLayout(False)
		Me.xTabUser.PerformLayout()
		CType(Me.txtDivisiTertentu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtWilayahTertentu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDashboardModul.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDashboardId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtHomeMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TreeListLookUpEdit1TreeList, System.ComponentModel.ISupportInitialize).EndInit()
		Me.xTabMenu.ResumeLayout(False)
		CType(Me.treeMenu, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl2.ResumeLayout(False)
		Me.PanelControl2.PerformLayout()
		CType(Me.txtDbMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpDb, System.ComponentModel.ISupportInitialize).EndInit()
		Me.xTabReport.ResumeLayout(False)
		CType(Me.treeReport, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl3.ResumeLayout(False)
		Me.PanelControl3.PerformLayout()
		CType(Me.txtDbReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.xTabRegional.ResumeLayout(False)
		CType(Me.treeRegional, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl4.ResumeLayout(False)
		Me.PanelControl4.PerformLayout()
		CType(Me.txtDbRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.xTabDivisi.ResumeLayout(False)
		CType(Me.treeDivisi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl5.ResumeLayout(False)
		Me.PanelControl5.PerformLayout()
		CType(Me.txtDbDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xTabControl As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents xTabUser As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents xTabMenu As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents xTabReport As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents xTabRegional As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtWilayahTertentu As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtAktif As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtLevel As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents treeMenu As DevExpress.XtraTreeList.TreeList
  Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtDbMenu As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents treeReport As DevExpress.XtraTreeList.TreeList
  Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtDbReport As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents treeRegional As DevExpress.XtraTreeList.TreeList
  Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtDbRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents xpDb As DevExpress.Xpo.XPCollection
  Friend WithEvents colMenu As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colBuka As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colTambah As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colEdit As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colHapus As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colEksport As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colCetak As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colReportName As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colReportBuka As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colReportEksport As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colReportCetak As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colRegionalNama As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colRegionalBuka As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents txtDivisiTertentu As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents xTabDivisi As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents treeDivisi As DevExpress.XtraTreeList.TreeList
  Friend WithEvents treeDivisiName As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents treeDivisiOpen As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtDbDivisi As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents colRegionalDefault As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtDashboardModul As DevExpress.XtraEditors.CheckedComboBoxEdit
	Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtDashboardId As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtHomeMenu As DevExpress.XtraEditors.TreeListLookUpEdit
	Friend WithEvents TreeListLookUpEdit1TreeList As DevExpress.XtraTreeList.TreeList
	Friend WithEvents colMenuNama As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
