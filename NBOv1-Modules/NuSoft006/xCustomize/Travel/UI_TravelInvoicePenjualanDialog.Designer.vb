<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TravelInvoicePenjualanDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TravelInvoicePenjualanDialog))
    Me.xcolKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.xxHapus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
    Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
    Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
    Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
    Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.txtTipeInvoice = New DevExpress.XtraEditors.LookUpEdit()
    Me.xGridDP = New DevExpress.XtraGrid.GridControl()
    Me.xGridDPView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colNoDP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNominal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtTermin = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoSO = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtJatuhTempo = New DevExpress.XtraEditors.DateEdit()
    Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.colKodeBarangRepoView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSpinEditRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDisc = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDiscP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colFOC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colProyek = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colProyekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.colProyekRepoView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
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
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtCatatan = New DevExpress.XtraEditors.MemoEdit()
    Me.txtSubTotal = New DevExpress.XtraEditors.SpinEdit()
    Me.txtDP = New DevExpress.XtraEditors.SpinEdit()
    Me.txtTotal = New DevExpress.XtraEditors.SpinEdit()
    Me.txtKurs = New DevExpress.XtraEditors.SpinEdit()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lyNoOrder = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xcolKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xxHapus, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.DockPanel2.SuspendLayout()
    Me.DockPanel2_Container.SuspendLayout()
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksi.SuspendLayout()
    CType(Me.txtTipeInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDP, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDPView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJatuhTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJatuhTempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepoView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSpinEditRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colProyekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colProyekRepoView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAlamatText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lyNoOrder, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.btnRefresh})
    Me.barMan.MaxItemId = 10
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'xcolKodeBarangRepo
    '
    Me.xcolKodeBarangRepo.AutoHeight = False
    Me.xcolKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.xcolKodeBarangRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "No. Akun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama Akun")})
    Me.xcolKodeBarangRepo.DisplayMember = "Kode"
    Me.xcolKodeBarangRepo.Name = "xcolKodeBarangRepo"
    Me.xcolKodeBarangRepo.NullText = "<Pilih Barang>"
    Me.xcolKodeBarangRepo.PopupWidth = 300
    Me.xcolKodeBarangRepo.ValueMember = "This"
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
    Me.DockManager1.Form = Me
    Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
    Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
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
    Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
    Me.lytTransaksi.Controls.Add(Me.txtTipeInvoice)
    Me.lytTransaksi.Controls.Add(Me.xGridDP)
    Me.lytTransaksi.Controls.Add(Me.txtTermin)
    Me.lytTransaksi.Controls.Add(Me.txtNoSO)
    Me.lytTransaksi.Controls.Add(Me.txtJatuhTempo)
    Me.lytTransaksi.Controls.Add(Me.txtKontakPerson)
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.xGrid)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.txtUang)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.txtKaryawan)
    Me.lytTransaksi.Controls.Add(Me.txtAlamatText)
    Me.lytTransaksi.Controls.Add(Me.txtAlamat)
    Me.lytTransaksi.Controls.Add(Me.txtCatatan)
    Me.lytTransaksi.Controls.Add(Me.txtSubTotal)
    Me.lytTransaksi.Controls.Add(Me.txtDP)
    Me.lytTransaksi.Controls.Add(Me.txtTotal)
    Me.lytTransaksi.Controls.Add(Me.txtKurs)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem20})
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(157, 147, 250, 350)
    Me.lytTransaksi.Root = Me.LayoutControlGroup1
    Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
    Me.lytTransaksi.TabIndex = 0
    Me.lytTransaksi.Text = "lytTransaksi"
    '
    'lblKontakNama
    '
    Me.lblKontakNama.Location = New System.Drawing.Point(256, 37)
    Me.lblKontakNama.Name = "lblKontakNama"
    Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
    Me.lblKontakNama.StyleController = Me.lytTransaksi
    Me.lblKontakNama.TabIndex = 28
    '
    'txtTipeInvoice
    '
    Me.txtTipeInvoice.Location = New System.Drawing.Point(375, 106)
    Me.txtTipeInvoice.MenuManager = Me.barMan
    Me.txtTipeInvoice.Name = "txtTipeInvoice"
    Me.txtTipeInvoice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTipeInvoice.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Tipe")})
    Me.txtTipeInvoice.Properties.DisplayMember = "Value"
    Me.txtTipeInvoice.Properties.NullText = "<Tipe Invoice>"
    Me.txtTipeInvoice.Properties.ValueMember = "Key"
    Me.txtTipeInvoice.Size = New System.Drawing.Size(152, 20)
    Me.txtTipeInvoice.StyleController = Me.lytTransaksi
    Me.txtTipeInvoice.TabIndex = 13
    '
    'xGridDP
    '
    Me.xGridDP.Location = New System.Drawing.Point(387, 321)
    Me.xGridDP.MainView = Me.xGridDPView
    Me.xGridDP.MenuManager = Me.barMan
    Me.xGridDP.Name = "xGridDP"
    Me.xGridDP.Size = New System.Drawing.Size(454, 102)
    Me.xGridDP.TabIndex = 20
    Me.xGridDP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridDPView})
    '
    'xGridDPView
    '
    Me.xGridDPView.Appearance.ViewCaption.Options.UseTextOptions = True
    Me.xGridDPView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.xGridDPView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoDP, Me.colUang, Me.colKurs, Me.colNominal})
    Me.xGridDPView.GridControl = Me.xGridDP
    Me.xGridDPView.Name = "xGridDPView"
    Me.xGridDPView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridDPView.OptionsView.ShowGroupPanel = False
    Me.xGridDPView.OptionsView.ShowViewCaption = True
    Me.xGridDPView.ViewCaption = "DP Penjualan"
    '
    'colNoDP
    '
    Me.colNoDP.Caption = "No DP"
    Me.colNoDP.FieldName = "Kode"
    Me.colNoDP.Name = "colNoDP"
    Me.colNoDP.OptionsColumn.AllowEdit = False
    Me.colNoDP.OptionsColumn.ReadOnly = True
    Me.colNoDP.Visible = True
    Me.colNoDP.VisibleIndex = 0
    '
    'colUang
    '
    Me.colUang.Caption = "Mata Uang"
    Me.colUang.FieldName = "Uang.Kode"
    Me.colUang.Name = "colUang"
    Me.colUang.OptionsColumn.AllowEdit = False
    Me.colUang.OptionsColumn.ReadOnly = True
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 1
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs"
    Me.colKurs.DisplayFormat.FormatString = "n2"
    Me.colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.OptionsColumn.AllowEdit = False
    Me.colKurs.OptionsColumn.ReadOnly = True
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 2
    '
    'colNominal
    '
    Me.colNominal.Caption = "Nominal"
    Me.colNominal.DisplayFormat.FormatString = "n2"
    Me.colNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colNominal.FieldName = "Nominal"
    Me.colNominal.Name = "colNominal"
    Me.colNominal.OptionsColumn.AllowEdit = False
    Me.colNominal.OptionsColumn.ReadOnly = True
    Me.colNominal.Visible = True
    Me.colNominal.VisibleIndex = 3
    '
    'txtTermin
    '
    Me.txtTermin.Location = New System.Drawing.Point(610, 106)
    Me.txtTermin.MenuManager = Me.barMan
    Me.txtTermin.Name = "txtTermin"
    Me.txtTermin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTermin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtTermin.Properties.DisplayMember = "Kode"
    Me.txtTermin.Properties.NullText = "<Termin>"
    Me.txtTermin.Properties.ValueMember = "This"
    Me.txtTermin.Size = New System.Drawing.Size(117, 20)
    Me.txtTermin.StyleController = Me.lytTransaksi
    Me.txtTermin.TabIndex = 9
    '
    'txtNoSO
    '
    Me.txtNoSO.Location = New System.Drawing.Point(373, 130)
    Me.txtNoSO.MenuManager = Me.barMan
    Me.txtNoSO.Name = "txtNoSO"
    Me.txtNoSO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoSO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 90, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tanggal", "Tanggal", 70, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yy", True, DevExpress.Utils.HorzAlignment.[Default])})
    Me.txtNoSO.Properties.DisplayMember = "Kode"
    Me.txtNoSO.Properties.NullText = "<Pilih No Order>"
    Me.txtNoSO.Properties.PopupWidth = 300
    Me.txtNoSO.Properties.ValueMember = "This"
    Me.txtNoSO.Size = New System.Drawing.Size(154, 20)
    Me.txtNoSO.StyleController = Me.lytTransaksi
    Me.txtNoSO.TabIndex = 8
    '
    'txtJatuhTempo
    '
    Me.txtJatuhTempo.EditValue = Nothing
    Me.txtJatuhTempo.Location = New System.Drawing.Point(810, 106)
    Me.txtJatuhTempo.MenuManager = Me.barMan
    Me.txtJatuhTempo.Name = "txtJatuhTempo"
    Me.txtJatuhTempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtJatuhTempo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtJatuhTempo.Size = New System.Drawing.Size(117, 20)
    Me.txtJatuhTempo.StyleController = Me.lytTransaksi
    Me.txtJatuhTempo.TabIndex = 10
    '
    'txtKontakPerson
    '
    Me.txtKontakPerson.Location = New System.Drawing.Point(92, 61)
    Me.txtKontakPerson.MenuManager = Me.barMan
    Me.txtKontakPerson.Name = "txtKontakPerson"
    Me.txtKontakPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontakPerson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 30, "Nama")})
    Me.txtKontakPerson.Properties.DisplayMember = "Nama"
    Me.txtKontakPerson.Properties.NullText = "<Pilih Kontak Person>"
    Me.txtKontakPerson.Properties.PopupWidth = 30
    Me.txtKontakPerson.Properties.ValueMember = "Nama"
    Me.txtKontakPerson.Size = New System.Drawing.Size(160, 20)
    Me.txtKontakPerson.StyleController = Me.lytTransaksi
    Me.txtKontakPerson.TabIndex = 4
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(773, 61)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.PopupWidth = 200
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(123, 20)
    Me.txtRegional.StyleController = Me.lytTransaksi
    Me.txtRegional.TabIndex = 5
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(773, 37)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(123, 20)
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
    Me.txtNoTransaksi.Location = New System.Drawing.Point(963, 37)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Size = New System.Drawing.Size(117, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksi
    Me.txtNoTransaksi.TabIndex = 2
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 178)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colKodeBarangRepo, Me.colProyekRepo, Me.colSpinEditRepo})
    Me.xGrid.Size = New System.Drawing.Size(1104, 139)
    Me.xGrid.TabIndex = 18
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colHarga, Me.colDisc, Me.colDiscP, Me.colSubTotal, Me.colFOC, Me.colTotal, Me.colCatatan, Me.colDivisi, Me.colProyek})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
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
    Me.colKodeBarangRepo.AutoHeight = False
    Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKodeBarangRepo.DisplayMember = "Kode"
    Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
    Me.colKodeBarangRepo.NullText = "<Pilih Barang>"
    Me.colKodeBarangRepo.ValueMember = "This"
    Me.colKodeBarangRepo.View = Me.colKodeBarangRepoView
    '
    'colKodeBarangRepoView
    '
    Me.colKodeBarangRepoView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
    Me.colKodeBarangRepoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.colKodeBarangRepoView.Name = "colKodeBarangRepoView"
    Me.colKodeBarangRepoView.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.colKodeBarangRepoView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Kode"
    Me.GridColumn5.FieldName = "Kode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 0
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Nama"
    Me.GridColumn6.FieldName = "Nama"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 1
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
    Me.colQty.ColumnEdit = Me.colSpinEditRepo
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.OptionsColumn.AllowSize = False
    Me.colQty.OptionsColumn.FixedWidth = True
    Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 2
    Me.colQty.Width = 57
    '
    'colSpinEditRepo
    '
    Me.colSpinEditRepo.AutoHeight = False
    Me.colSpinEditRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colSpinEditRepo.Name = "colSpinEditRepo"
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
    Me.colSatuan.VisibleIndex = 3
    Me.colSatuan.Width = 70
    '
    'colHarga
    '
    Me.colHarga.Caption = "Harga"
    Me.colHarga.ColumnEdit = Me.colSpinEditRepo
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    Me.colHarga.Visible = True
    Me.colHarga.VisibleIndex = 4
    Me.colHarga.Width = 80
    '
    'colDisc
    '
    Me.colDisc.Caption = "Discount"
    Me.colDisc.FieldName = "Discount"
    Me.colDisc.Name = "colDisc"
    Me.colDisc.Visible = True
    Me.colDisc.VisibleIndex = 5
    '
    'colDiscP
    '
    Me.colDiscP.Caption = "Discount %"
    Me.colDiscP.FieldName = "DiscountPersen"
    Me.colDiscP.Name = "colDiscP"
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
    'colFOC
    '
    Me.colFOC.Caption = "FOC"
    Me.colFOC.ColumnEdit = Me.colSpinEditRepo
    Me.colFOC.FieldName = "FOC"
    Me.colFOC.Name = "colFOC"
    Me.colFOC.Visible = True
    Me.colFOC.VisibleIndex = 6
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total"
    Me.colTotal.FieldName = "SubTotal"
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
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 8
    Me.colCatatan.Width = 204
    '
    'colDivisi
    '
    Me.colDivisi.Caption = "Divisi"
    Me.colDivisi.FieldName = "Divisi.Kode"
    Me.colDivisi.Name = "colDivisi"
    Me.colDivisi.OptionsColumn.AllowEdit = False
    Me.colDivisi.OptionsColumn.ReadOnly = True
    Me.colDivisi.Visible = True
    Me.colDivisi.VisibleIndex = 9
    Me.colDivisi.Width = 82
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
    Me.colProyekRepo.DisplayMember = "Kode"
    Me.colProyekRepo.Name = "colProyekRepo"
    Me.colProyekRepo.NullText = "<Pilih Proyek>"
    Me.colProyekRepo.ValueMember = "This"
    Me.colProyekRepo.View = Me.colProyekRepoView
    '
    'colProyekRepoView
    '
    Me.colProyekRepoView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8})
    Me.colProyekRepoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.colProyekRepoView.Name = "colProyekRepoView"
    Me.colProyekRepoView.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.colProyekRepoView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Kode"
    Me.GridColumn7.FieldName = "Kode"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 0
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Nama"
    Me.GridColumn8.FieldName = "Nama"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 1
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(372, 154)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(744, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 17
    '
    'txtUang
    '
    Me.txtUang.Location = New System.Drawing.Point(610, 130)
    Me.txtUang.MenuManager = Me.barMan
    Me.txtUang.Name = "txtUang"
    Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtUang.Properties.DisplayMember = "Kode"
    Me.txtUang.Properties.NullText = "<Uang>"
    Me.txtUang.Properties.ValueMember = "This"
    Me.txtUang.Size = New System.Drawing.Size(117, 20)
    Me.txtUang.StyleController = Me.lytTransaksi
    Me.txtUang.TabIndex = 15
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(92, 37)
    Me.txtKontak.MenuManager = Me.barMan
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
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
    'txtKaryawan
    '
    Me.txtKaryawan.Location = New System.Drawing.Point(1010, 106)
    Me.txtKaryawan.MenuManager = Me.barMan
    Me.txtKaryawan.Name = "txtKaryawan"
    Me.txtKaryawan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKaryawan.Properties.DisplayMember = "Nama"
    Me.txtKaryawan.Properties.NullText = "<Pilih Karyawan>"
    Me.txtKaryawan.Properties.ShowClearButton = False
    Me.txtKaryawan.Properties.ShowFooter = False
    Me.txtKaryawan.Properties.ValueMember = "This"
    Me.txtKaryawan.Properties.View = Me.GridView1
    Me.txtKaryawan.Size = New System.Drawing.Size(106, 20)
    Me.txtKaryawan.StyleController = Me.lytTransaksi
    Me.txtKaryawan.TabIndex = 14
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
    Me.txtAlamatText.Size = New System.Drawing.Size(237, 44)
    Me.txtAlamatText.StyleController = Me.lytTransaksi
    Me.txtAlamatText.TabIndex = 12
    '
    'txtAlamat
    '
    Me.txtAlamat.Location = New System.Drawing.Point(55, 106)
    Me.txtAlamat.MenuManager = Me.barMan
    Me.txtAlamat.Name = "txtAlamat"
    Me.txtAlamat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAlamat.Properties.DisplayMember = "Kode"
    Me.txtAlamat.Properties.NullText = ""
    Me.txtAlamat.Properties.ValueMember = "This"
    Me.txtAlamat.Properties.View = Me.GridView2
    Me.txtAlamat.Size = New System.Drawing.Size(199, 20)
    Me.txtAlamat.StyleController = Me.lytTransaksi
    Me.txtAlamat.TabIndex = 7
    '
    'GridView2
    '
    Me.GridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
    Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsFind.FindDelay = 500
    Me.GridView2.OptionsFind.SearchInPreview = True
    Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView2.OptionsView.ShowGroupPanel = False
    Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn3
    '
    Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridColumn3.Caption = "Kode"
    Me.GridColumn3.FieldName = "Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    Me.GridColumn3.Width = 355
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Alamat"
    Me.GridColumn4.FieldName = "Alamat"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    Me.GridColumn4.Width = 723
    '
    'txtCatatan
    '
    Me.txtCatatan.Location = New System.Drawing.Point(89, 321)
    Me.txtCatatan.MenuManager = Me.barMan
    Me.txtCatatan.Name = "txtCatatan"
    Me.txtCatatan.Size = New System.Drawing.Size(279, 102)
    Me.txtCatatan.StyleController = Me.lytTransaksi
    Me.txtCatatan.TabIndex = 29
    '
    'txtSubTotal
    '
    Me.txtSubTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtSubTotal.Enabled = False
    Me.txtSubTotal.Location = New System.Drawing.Point(932, 333)
    Me.txtSubTotal.MenuManager = Me.barMan
    Me.txtSubTotal.Name = "txtSubTotal"
    Me.txtSubTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSubTotal.Properties.DisplayFormat.FormatString = "n2"
    Me.txtSubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtSubTotal.Properties.EditFormat.FormatString = "n2"
    Me.txtSubTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtSubTotal.Size = New System.Drawing.Size(172, 20)
    Me.txtSubTotal.StyleController = Me.lytTransaksi
    Me.txtSubTotal.TabIndex = 21
    '
    'txtDP
    '
    Me.txtDP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtDP.Enabled = False
    Me.txtDP.Location = New System.Drawing.Point(932, 357)
    Me.txtDP.MenuManager = Me.barMan
    Me.txtDP.Name = "txtDP"
    Me.txtDP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtDP.Properties.DisplayFormat.FormatString = "n2"
    Me.txtDP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtDP.Properties.EditFormat.FormatString = "n2"
    Me.txtDP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtDP.Size = New System.Drawing.Size(172, 20)
    Me.txtDP.StyleController = Me.lytTransaksi
    Me.txtDP.TabIndex = 24
    '
    'txtTotal
    '
    Me.txtTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtTotal.Enabled = False
    Me.txtTotal.Location = New System.Drawing.Point(932, 381)
    Me.txtTotal.MenuManager = Me.barMan
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTotal.Properties.DisplayFormat.FormatString = "n2"
    Me.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtTotal.Properties.EditFormat.FormatString = "n2"
    Me.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtTotal.Size = New System.Drawing.Size(172, 20)
    Me.txtTotal.StyleController = Me.lytTransaksi
    Me.txtTotal.TabIndex = 25
    '
    'txtKurs
    '
    Me.txtKurs.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtKurs.Location = New System.Drawing.Point(810, 130)
    Me.txtKurs.MenuManager = Me.barMan
    Me.txtKurs.Name = "txtKurs"
    Me.txtKurs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKurs.Properties.DisplayFormat.FormatString = "n2"
    Me.txtKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtKurs.Properties.EditFormat.FormatString = "n2"
    Me.txtKurs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtKurs.Size = New System.Drawing.Size(117, 20)
    Me.txtKurs.StyleController = Me.lytTransaksi
    Me.txtKurs.TabIndex = 16
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.CustomizationFormText = "No Invoice Vendor"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(501, 94)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(217, 24)
    Me.LayoutControlItem5.Text = "No Invoice Vendor"
    Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(88, 13)
    Me.LayoutControlItem5.TextToControlDistance = 5
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.CustomizationFormText = "Tipe Transaksi"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 271)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(245, 24)
    Me.LayoutControlItem2.Text = "Jenis Transaksi"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(72, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'LayoutControlItem20
    '
    Me.LayoutControlItem20.CustomizationFormText = "No Faktur PPh"
    Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 319)
    Me.LayoutControlItem20.Name = "LayoutControlItem20"
    Me.LayoutControlItem20.Size = New System.Drawing.Size(245, 24)
    Me.LayoutControlItem20.Text = "No Faktur PPh"
    Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem20.TextSize = New System.Drawing.Size(72, 13)
    Me.LayoutControlItem20.TextToControlDistance = 5
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem21, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem25, Me.LayoutControlItem12, Me.LayoutControlItem8, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.EmptySpaceItem5, Me.LayoutControlItem3, Me.LayoutControlItem26, Me.lyNoOrder, Me.LayoutControlItem11, Me.EmptySpaceItem6, Me.LayoutControlItem4})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGrid
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 166)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(1108, 143)
    Me.LayoutControlItem7.Text = "LayoutControlItem7"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtJatuhTempo
    Me.LayoutControlItem6.CustomizationFormText = "Tgl Berlaku"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(719, 94)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(200, 24)
    Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem6.Text = "Jatuh Tempo"
    Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem6.TextToControlDistance = 5
    '
    'LayoutControlItem21
    '
    Me.LayoutControlItem21.Control = Me.xGridDP
    Me.LayoutControlItem21.CustomizationFormText = "DP Pembelian"
    Me.LayoutControlItem21.Location = New System.Drawing.Point(360, 309)
    Me.LayoutControlItem21.Name = "LayoutControlItem21"
    Me.LayoutControlItem21.Size = New System.Drawing.Size(473, 106)
    Me.LayoutControlItem21.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem21.Text = "DP Penjualan"
    Me.LayoutControlItem21.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem21.TextToControlDistance = 0
    Me.LayoutControlItem21.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem22, Me.LayoutControlItem13, Me.EmptySpaceItem4})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(833, 309)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(275, 106)
    Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
    Me.LayoutControlGroup2.TextVisible = False
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtTotal
    Me.LayoutControlItem9.CustomizationFormText = "Total Transaksi"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(251, 24)
    Me.LayoutControlItem9.Text = "Total Transaksi"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem22
    '
    Me.LayoutControlItem22.Control = Me.txtDP
    Me.LayoutControlItem22.CustomizationFormText = "DP"
    Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem22.Name = "LayoutControlItem22"
    Me.LayoutControlItem22.Size = New System.Drawing.Size(251, 24)
    Me.LayoutControlItem22.Text = "DP"
    Me.LayoutControlItem22.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtSubTotal
    Me.LayoutControlItem13.CustomizationFormText = "Sub Total"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(251, 24)
    Me.LayoutControlItem13.Text = "Sub Total"
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(72, 13)
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 72)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(251, 10)
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.lytRegional, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem27, Me.EmptySpaceItem1, Me.EmptySpaceItem3})
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
    Me.layKontak.Size = New System.Drawing.Size(238, 24)
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
    Me.LayoutControlItem15.Size = New System.Drawing.Size(175, 24)
    Me.LayoutControlItem15.Text = "Tanggal   "
    Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem15.TextToControlDistance = 5
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtNoTransaksi
    Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(882, 0)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(184, 24)
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
    Me.lytRegional.Size = New System.Drawing.Size(175, 24)
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
    Me.LayoutControlItem1.Size = New System.Drawing.Size(238, 24)
    Me.LayoutControlItem1.Text = "Kontak Person"
    Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem1.TextToControlDistance = 5
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(454, 0)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(253, 48)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem27
    '
    Me.LayoutControlItem27.Control = Me.lblKontakNama
    Me.LayoutControlItem27.CustomizationFormText = "LayoutControlItem27"
    Me.LayoutControlItem27.Location = New System.Drawing.Point(238, 0)
    Me.LayoutControlItem27.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem27.Name = "LayoutControlItem27"
    Me.LayoutControlItem27.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem27.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem27.Text = "LayoutControlItem27"
    Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem27.TextToControlDistance = 0
    Me.LayoutControlItem27.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(238, 24)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(882, 24)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(184, 24)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem25
    '
    Me.LayoutControlItem25.Control = Me.txtCatatan
    Me.LayoutControlItem25.CustomizationFormText = "Catatan"
    Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 309)
    Me.LayoutControlItem25.Name = "LayoutControlItem25"
    Me.LayoutControlItem25.Size = New System.Drawing.Size(360, 106)
    Me.LayoutControlItem25.Text = "Catatan"
    Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem25.TextSize = New System.Drawing.Size(72, 13)
    Me.LayoutControlItem25.TextToControlDistance = 5
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtTermin
    Me.LayoutControlItem12.CustomizationFormText = "Termin"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(519, 94)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(200, 24)
    Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem12.Text = "Termin"
    Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem12.TextToControlDistance = 5
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtUang
    Me.LayoutControlItem8.CustomizationFormText = "Mata Uang"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(519, 118)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(200, 24)
    Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem8.Text = "Mata Uang"
    Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem8.TextToControlDistance = 5
    '
    'LayoutControlItem28
    '
    Me.LayoutControlItem28.Control = Me.txtAlamat
    Me.LayoutControlItem28.CustomizationFormText = "Alamat"
    Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 94)
    Me.LayoutControlItem28.Name = "LayoutControlItem28"
    Me.LayoutControlItem28.Size = New System.Drawing.Size(246, 24)
    Me.LayoutControlItem28.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem28.Text = "Alamat"
    Me.LayoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem28.TextSize = New System.Drawing.Size(33, 13)
    Me.LayoutControlItem28.TextToControlDistance = 5
    '
    'LayoutControlItem29
    '
    Me.LayoutControlItem29.Control = Me.txtAlamatText
    Me.LayoutControlItem29.CustomizationFormText = "Alamat Text"
    Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 118)
    Me.LayoutControlItem29.Name = "LayoutControlItem29"
    Me.LayoutControlItem29.Size = New System.Drawing.Size(246, 48)
    Me.LayoutControlItem29.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem29.Text = "Alamat Text"
    Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem29.TextToControlDistance = 0
    Me.LayoutControlItem29.TextVisible = False
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(246, 94)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(35, 72)
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(281, 142)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(827, 24)
    Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'LayoutControlItem26
    '
    Me.LayoutControlItem26.Control = Me.txtTipeInvoice
    Me.LayoutControlItem26.CustomizationFormText = "Tipe Transaksi"
    Me.LayoutControlItem26.Location = New System.Drawing.Point(281, 94)
    Me.LayoutControlItem26.Name = "LayoutControlItem26"
    Me.LayoutControlItem26.Size = New System.Drawing.Size(238, 24)
    Me.LayoutControlItem26.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem26.Text = "Tipe"
    Me.LayoutControlItem26.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem26.TextSize = New System.Drawing.Size(72, 13)
    Me.LayoutControlItem26.TextToControlDistance = 5
    '
    'lyNoOrder
    '
    Me.lyNoOrder.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lyNoOrder.AppearanceItemCaption.Options.UseFont = True
    Me.lyNoOrder.Control = Me.txtNoSO
    Me.lyNoOrder.CustomizationFormText = "No Order"
    Me.lyNoOrder.Location = New System.Drawing.Point(281, 118)
    Me.lyNoOrder.Name = "lyNoOrder"
    Me.lyNoOrder.Size = New System.Drawing.Size(238, 24)
    Me.lyNoOrder.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.lyNoOrder.Text = "Tarik No. SO"
    Me.lyNoOrder.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtKaryawan
    Me.LayoutControlItem11.CustomizationFormText = "Bag Pembelian"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(919, 94)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(189, 24)
    Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem11.Text = "Bag Penjualan"
    Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem11.TextToControlDistance = 5
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(919, 118)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(189, 24)
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtKurs
    Me.LayoutControlItem4.CustomizationFormText = "Kurs [Tax]"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(719, 118)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(200, 24)
    Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem4.Text = "Kurs"
    Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
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
    Me.btnRefresh.Id = 9
    Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
    Me.btnRefresh.Name = "btnRefresh"
    '
    'UI_TravelInvoicePenjualanDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1134, 468)
    Me.KeyPreview = True
    Me.Name = "UI_TravelInvoicePenjualanDialog"
    Me.Text = "Penerimaan Invoice"
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xcolKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xxHapus, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.DockPanel2.ResumeLayout(False)
    Me.DockPanel2_Container.ResumeLayout(False)
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksi.ResumeLayout(False)
    CType(Me.txtTipeInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDP, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDPView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJatuhTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJatuhTempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepoView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSpinEditRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colProyekRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colProyekRepoView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAlamatText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lyNoOrder, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
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
    Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xcolKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtKontakPerson As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
    Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents txtJatuhTempo As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoSO As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lyNoOrder As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTermin As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xGridDP As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridDPView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colNoDP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTipeInvoice As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtKaryawan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlamatText As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAlamat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colFOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents colKodeBarangRepoView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProyek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProyekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents colProyekRepoView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCatatan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDP As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtKurs As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colNominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSpinEditRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
End Class
