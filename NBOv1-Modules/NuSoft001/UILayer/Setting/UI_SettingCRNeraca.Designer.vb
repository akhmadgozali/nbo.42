<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SettingCRNeraca
	Inherits Core.Win.Forms.BlankForm

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SettingCRNeraca))
    Me.barMan = New DevExpress.XtraBars.BarManager(Me.components)
    Me.barMenu = New DevExpress.XtraBars.Bar()
    Me.barMenuRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.barMenuSave = New DevExpress.XtraBars.BarButtonItem()
    Me.barMenuCancel = New DevExpress.XtraBars.BarButtonItem()
    Me.barMenuExcel = New DevExpress.XtraBars.BarButtonItem()
    Me.barMenuPrint = New DevExpress.XtraBars.BarButtonItem()
    Me.barText = New DevExpress.XtraBars.BarStaticItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
    Me.xpAktiva = New DevExpress.Xpo.XPCollection(Me.components)
    Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
    Me.xGridA = New DevExpress.XtraGrid.GridControl()
    Me.xGridViewA = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.colLevel = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLevelRepo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.colSpasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUrutan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCashFlowTanda = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
    Me.btnADown = New DevExpress.XtraEditors.SimpleButton()
    Me.btnAUp = New DevExpress.XtraEditors.SimpleButton()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.xGridP = New DevExpress.XtraGrid.GridControl()
    Me.xpPassiva = New DevExpress.Xpo.XPCollection(Me.components)
    Me.xGridViewP = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colPNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPNamaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.colPJenis = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPJenisRepo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.colPSpasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPTipe = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPUrutan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPCashFlow = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.btnPDown = New DevExpress.XtraEditors.SimpleButton()
    Me.btnPUp = New DevExpress.XtraEditors.SimpleButton()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpAktiva, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerControl1.SuspendLayout()
    CType(Me.xGridA, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridViewA, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colNamaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colLevelRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl2.SuspendLayout()
    CType(Me.xGridP, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpPassiva, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridViewP, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colPNamaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colPJenisRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.AllowCustomization = False
    Me.barMan.AllowMoveBarOnToolbar = False
    Me.barMan.AllowQuickCustomization = False
    Me.barMan.AllowShowToolbarsPopup = False
    Me.barMan.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barMenu})
    Me.barMan.DockControls.Add(Me.barDockControlTop)
    Me.barMan.DockControls.Add(Me.barDockControlBottom)
    Me.barMan.DockControls.Add(Me.barDockControlLeft)
    Me.barMan.DockControls.Add(Me.barDockControlRight)
    Me.barMan.Form = Me
    Me.barMan.HideBarsWhenMerging = False
    Me.barMan.Images = Me.ImageCollection1
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barMenuRefresh, Me.barMenuSave, Me.barMenuCancel, Me.barMenuExcel, Me.barMenuPrint, Me.barText})
    Me.barMan.MaxItemId = 6
    Me.barMan.StatusBar = Me.barMenu
    '
    'barMenu
    '
    Me.barMenu.BarName = "Menu"
    Me.barMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.barMenu.DockCol = 0
    Me.barMenu.DockRow = 0
    Me.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuSave, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuExcel, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barText)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    Me.barMenu.Text = "Status bar"
    '
    'barMenuRefresh
    '
    Me.barMenuRefresh.Caption = "&Refresh"
    Me.barMenuRefresh.Id = 0
    Me.barMenuRefresh.ImageIndex = 0
    Me.barMenuRefresh.Name = "barMenuRefresh"
    '
    'barMenuSave
    '
    Me.barMenuSave.Caption = "&Simpan"
    Me.barMenuSave.Id = 1
    Me.barMenuSave.ImageIndex = 1
    Me.barMenuSave.Name = "barMenuSave"
    '
    'barMenuCancel
    '
    Me.barMenuCancel.Caption = "&Tutup"
    Me.barMenuCancel.Id = 2
    Me.barMenuCancel.ImageIndex = 4
    Me.barMenuCancel.Name = "barMenuCancel"
    '
    'barMenuExcel
    '
    Me.barMenuExcel.Caption = "&Export Excel"
    Me.barMenuExcel.Id = 3
    Me.barMenuExcel.ImageIndex = 2
    Me.barMenuExcel.Name = "barMenuExcel"
    '
    'barMenuPrint
    '
    Me.barMenuPrint.Caption = "&Cetak"
    Me.barMenuPrint.Id = 4
    Me.barMenuPrint.ImageIndex = 3
    Me.barMenuPrint.Name = "barMenuPrint"
    '
    'barText
    '
    Me.barText.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
    Me.barText.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.barText.Caption = "Tekan Ctrl+Del untuk menghapus baris"
    Me.barText.Id = 5
    Me.barText.Name = "barText"
    Me.barText.TextAlignment = System.Drawing.StringAlignment.Far
    Me.barText.Width = 32
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Size = New System.Drawing.Size(688, 0)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 387)
    Me.barDockControlBottom.Size = New System.Drawing.Size(688, 27)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 387)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(688, 0)
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 387)
    '
    'ImageCollection1
    '
    Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
    Me.ImageCollection1.Images.SetKeyName(0, "table_refresh.png")
    Me.ImageCollection1.Images.SetKeyName(1, "table_save.png")
    Me.ImageCollection1.Images.SetKeyName(2, "export_excel.png")
    Me.ImageCollection1.Images.SetKeyName(3, "printer.png")
    Me.ImageCollection1.Images.SetKeyName(4, "cancel.png")
    Me.ImageCollection1.Images.SetKeyName(5, "arrow_down.png")
    Me.ImageCollection1.Images.SetKeyName(6, "arrow_up.png")
    '
    'xpAktiva
    '
    Me.xpAktiva.CriteriaString = "[Tipe] = 1L"
    Me.xpAktiva.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.CustomReportMain)
    Me.xpAktiva.SelectDeleted = True
    '
    'SplitContainerControl1
    '
    Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
    Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainerControl1.Name = "SplitContainerControl1"
    Me.SplitContainerControl1.Panel1.Controls.Add(Me.xGridA)
    Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl2)
    Me.SplitContainerControl1.Panel1.Text = "Panel1"
    Me.SplitContainerControl1.Panel2.Controls.Add(Me.xGridP)
    Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl1)
    Me.SplitContainerControl1.Panel2.Text = "Panel2"
    Me.SplitContainerControl1.Size = New System.Drawing.Size(688, 387)
    Me.SplitContainerControl1.SplitterPosition = 352
    Me.SplitContainerControl1.TabIndex = 5
    Me.SplitContainerControl1.Text = "SplitContainerControl1"
    '
    'xGridA
    '
    Me.xGridA.DataSource = Me.xpAktiva
    Me.xGridA.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGridA.Location = New System.Drawing.Point(0, 43)
    Me.xGridA.MainView = Me.xGridViewA
    Me.xGridA.MenuManager = Me.barMan
    Me.xGridA.Name = "xGridA"
    Me.xGridA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colLevelRepo, Me.colNamaRepo})
    Me.xGridA.Size = New System.Drawing.Size(352, 344)
    Me.xGridA.TabIndex = 2
    Me.xGridA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridViewA})
    '
    'xGridViewA
    '
    Me.xGridViewA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNama, Me.colLevel, Me.colSpasi, Me.colTipe, Me.colUrutan, Me.colCashFlowTanda, Me.colKode})
    Me.xGridViewA.GridControl = Me.xGridA
    Me.xGridViewA.Name = "xGridViewA"
    Me.xGridViewA.NewItemRowText = "<Tambah Data>"
    Me.xGridViewA.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
    Me.xGridViewA.OptionsCustomization.AllowSort = False
    Me.xGridViewA.OptionsDetail.EnableMasterViewMode = False
    Me.xGridViewA.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridViewA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridViewA.OptionsView.ShowGroupPanel = False
    Me.xGridViewA.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUrutan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colNama
    '
    Me.colNama.ColumnEdit = Me.colNamaRepo
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 0
    '
    'colNamaRepo
    '
    Me.colNamaRepo.AutoHeight = False
    Me.colNamaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.colNamaRepo.Name = "colNamaRepo"
    '
    'colLevel
    '
    Me.colLevel.Caption = "Jenis"
    Me.colLevel.ColumnEdit = Me.colLevelRepo
    Me.colLevel.FieldName = "Level"
    Me.colLevel.Name = "colLevel"
    Me.colLevel.Visible = True
    Me.colLevel.VisibleIndex = 1
    '
    'colLevelRepo
    '
    Me.colLevelRepo.AutoHeight = False
    Me.colLevelRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colLevelRepo.Items.AddRange(New Object() {"HEADER", "DETAIL", "SUBTOTAL", "TOTAL"})
    Me.colLevelRepo.Name = "colLevelRepo"
    Me.colLevelRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    '
    'colSpasi
    '
    Me.colSpasi.FieldName = "Spasi"
    Me.colSpasi.Name = "colSpasi"
    Me.colSpasi.Visible = True
    Me.colSpasi.VisibleIndex = 2
    '
    'colTipe
    '
    Me.colTipe.FieldName = "Tipe"
    Me.colTipe.Name = "colTipe"
    '
    'colUrutan
    '
    Me.colUrutan.FieldName = "Urutan"
    Me.colUrutan.Name = "colUrutan"
    '
    'colCashFlowTanda
    '
    Me.colCashFlowTanda.FieldName = "CashFlowTanda"
    Me.colCashFlowTanda.Name = "colCashFlowTanda"
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    '
    'PanelControl2
    '
    Me.PanelControl2.Controls.Add(Me.btnADown)
    Me.PanelControl2.Controls.Add(Me.btnAUp)
    Me.PanelControl2.Controls.Add(Me.LabelControl1)
    Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
    Me.PanelControl2.Name = "PanelControl2"
    Me.PanelControl2.Size = New System.Drawing.Size(352, 43)
    Me.PanelControl2.TabIndex = 1
    '
    'btnADown
    '
    Me.btnADown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnADown.ImageIndex = 5
    Me.btnADown.ImageList = Me.ImageCollection1
    Me.btnADown.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnADown.Location = New System.Drawing.Point(320, 8)
    Me.btnADown.Name = "btnADown"
    Me.btnADown.Size = New System.Drawing.Size(25, 25)
    Me.btnADown.TabIndex = 2
    '
    'btnAUp
    '
    Me.btnAUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAUp.ImageIndex = 6
    Me.btnAUp.ImageList = Me.ImageCollection1
    Me.btnAUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnAUp.Location = New System.Drawing.Point(289, 8)
    Me.btnAUp.Name = "btnAUp"
    Me.btnAUp.Size = New System.Drawing.Size(25, 25)
    Me.btnAUp.TabIndex = 1
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Location = New System.Drawing.Point(10, 8)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(80, 25)
    Me.LabelControl1.TabIndex = 0
    Me.LabelControl1.Text = "AKTIVA"
    '
    'xGridP
    '
    Me.xGridP.DataSource = Me.xpPassiva
    Me.xGridP.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGridP.Location = New System.Drawing.Point(0, 43)
    Me.xGridP.MainView = Me.xGridViewP
    Me.xGridP.MenuManager = Me.barMan
    Me.xGridP.Name = "xGridP"
    Me.xGridP.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colPJenisRepo, Me.colPNamaRepo})
    Me.xGridP.Size = New System.Drawing.Size(331, 344)
    Me.xGridP.TabIndex = 3
    Me.xGridP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridViewP})
    '
    'xpPassiva
    '
    Me.xpPassiva.CriteriaString = "[Tipe] = 2L"
    Me.xpPassiva.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.CustomReportMain)
    Me.xpPassiva.SelectDeleted = True
    '
    'xGridViewP
    '
    Me.xGridViewP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPNama, Me.colPJenis, Me.colPSpasi, Me.colPTipe, Me.colPUrutan, Me.colPCashFlow, Me.colPKode})
    Me.xGridViewP.GridControl = Me.xGridP
    Me.xGridViewP.Name = "xGridViewP"
    Me.xGridViewP.NewItemRowText = "<Tambah Data>"
    Me.xGridViewP.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
    Me.xGridViewP.OptionsCustomization.AllowSort = False
    Me.xGridViewP.OptionsDetail.EnableMasterViewMode = False
    Me.xGridViewP.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridViewP.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridViewP.OptionsView.ShowGroupPanel = False
    Me.xGridViewP.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPUrutan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colPNama
    '
    Me.colPNama.ColumnEdit = Me.colPNamaRepo
    Me.colPNama.FieldName = "Nama"
    Me.colPNama.Name = "colPNama"
    Me.colPNama.Visible = True
    Me.colPNama.VisibleIndex = 0
    '
    'colPNamaRepo
    '
    Me.colPNamaRepo.AutoHeight = False
    Me.colPNamaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.colPNamaRepo.Name = "colPNamaRepo"
    '
    'colPJenis
    '
    Me.colPJenis.Caption = "Jenis"
    Me.colPJenis.ColumnEdit = Me.colPJenisRepo
    Me.colPJenis.FieldName = "Level"
    Me.colPJenis.Name = "colPJenis"
    Me.colPJenis.Visible = True
    Me.colPJenis.VisibleIndex = 1
    '
    'colPJenisRepo
    '
    Me.colPJenisRepo.AutoHeight = False
    Me.colPJenisRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colPJenisRepo.Items.AddRange(New Object() {"HEADER", "DETAIL", "SUBTOTAL", "TOTAL"})
    Me.colPJenisRepo.Name = "colPJenisRepo"
    Me.colPJenisRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    '
    'colPSpasi
    '
    Me.colPSpasi.FieldName = "Spasi"
    Me.colPSpasi.Name = "colPSpasi"
    Me.colPSpasi.Visible = True
    Me.colPSpasi.VisibleIndex = 2
    '
    'colPTipe
    '
    Me.colPTipe.FieldName = "Tipe"
    Me.colPTipe.Name = "colPTipe"
    '
    'colPUrutan
    '
    Me.colPUrutan.FieldName = "Urutan"
    Me.colPUrutan.Name = "colPUrutan"
    '
    'colPCashFlow
    '
    Me.colPCashFlow.FieldName = "CashFlowTanda"
    Me.colPCashFlow.Name = "colPCashFlow"
    '
    'colPKode
    '
    Me.colPKode.FieldName = "Kode"
    Me.colPKode.Name = "colPKode"
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.btnPDown)
    Me.PanelControl1.Controls.Add(Me.btnPUp)
    Me.PanelControl1.Controls.Add(Me.LabelControl2)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(331, 43)
    Me.PanelControl1.TabIndex = 0
    '
    'btnPDown
    '
    Me.btnPDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnPDown.ImageIndex = 5
    Me.btnPDown.ImageList = Me.ImageCollection1
    Me.btnPDown.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnPDown.Location = New System.Drawing.Point(299, 8)
    Me.btnPDown.Name = "btnPDown"
    Me.btnPDown.Size = New System.Drawing.Size(25, 25)
    Me.btnPDown.TabIndex = 4
    '
    'btnPUp
    '
    Me.btnPUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnPUp.ImageIndex = 6
    Me.btnPUp.ImageList = Me.ImageCollection1
    Me.btnPUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnPUp.Location = New System.Drawing.Point(268, 8)
    Me.btnPUp.Name = "btnPUp"
    Me.btnPUp.Size = New System.Drawing.Size(25, 25)
    Me.btnPUp.TabIndex = 3
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Location = New System.Drawing.Point(10, 8)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(92, 25)
    Me.LabelControl2.TabIndex = 1
    Me.LabelControl2.Text = "PASSIVA"
    '
    'UI_SettingCRNeraca
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(688, 414)
    Me.Controls.Add(Me.SplitContainerControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.KeyPreview = True
    Me.Name = "UI_SettingCRNeraca"
    Me.ShowInTaskbar = False
    Me.Text = "Setting Neraca"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpAktiva, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerControl1.ResumeLayout(False)
    CType(Me.xGridA, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridViewA, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colNamaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colLevelRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl2.ResumeLayout(False)
    Me.PanelControl2.PerformLayout()
    CType(Me.xGridP, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpPassiva, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridViewP, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colPNamaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colPJenisRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    Me.PanelControl1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Public WithEvents barMan As DevExpress.XtraBars.BarManager
  Friend WithEvents barMenu As DevExpress.XtraBars.Bar
  Friend WithEvents barMenuRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barMenuSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barMenuCancel As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barMenuExcel As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barMenuPrint As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barText As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Public WithEvents xpAktiva As DevExpress.Xpo.XPCollection
	Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
  Friend WithEvents xGridA As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridViewA As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnADown As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnAUp As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnPDown As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnPUp As DevExpress.XtraEditors.SimpleButton
  Public WithEvents xpPassiva As DevExpress.Xpo.XPCollection
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLevel As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSpasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents colLevelRepo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUrutan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCashFlowTanda As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xGridP As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridViewP As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colPNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPNamaRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents colPJenis As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPJenisRepo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents colPSpasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPTipe As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPUrutan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPCashFlow As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection

End Class
