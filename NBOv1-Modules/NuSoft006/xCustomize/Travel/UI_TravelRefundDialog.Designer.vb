<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TravelRefundDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_TravelRefundDialog))
        Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.xxHapus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
        Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalBayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalRefund = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSisaRefund = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJumlahRefundValas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpinEditRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colKursRefund = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJumlahRefund = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtAkun = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
        Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtKurs = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNilaiKas = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNilaiValas = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.layAkunKasBankNama = New DevExpress.XtraLayout.SimpleLabelItem()
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
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lytTransaksi.SuspendLayout()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colSpinEditRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiKas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiValas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layAkunKasBankNama, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lytTransaksi.Controls.Add(Me.xGrid)
        Me.lytTransaksi.Controls.Add(Me.txtUang)
        Me.lytTransaksi.Controls.Add(Me.txtAkun)
        Me.lytTransaksi.Controls.Add(Me.txtStatus)
        Me.lytTransaksi.Controls.Add(Me.txtRegional)
        Me.lytTransaksi.Controls.Add(Me.txtTanggal)
        Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
        Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
        Me.lytTransaksi.Controls.Add(Me.txtUraian)
        Me.lytTransaksi.Controls.Add(Me.txtKontak)
        Me.lytTransaksi.Controls.Add(Me.txtKurs)
        Me.lytTransaksi.Controls.Add(Me.txtNilaiKas)
        Me.lytTransaksi.Controls.Add(Me.txtNilaiValas)
        Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.lytTransaksi.Name = "lytTransaksi"
        Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 347, 288, 350)
        Me.lytTransaksi.Root = Me.LayoutControlGroup1
        Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
        Me.lytTransaksi.TabIndex = 0
        Me.lytTransaksi.Text = "LayoutControl1"
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
        Me.xGrid.Location = New System.Drawing.Point(12, 190)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.MenuManager = Me.barMan
        Me.xGrid.Name = "xGrid"
        Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpinEditRepo})
        Me.xGrid.Size = New System.Drawing.Size(1104, 228)
        Me.xGrid.TabIndex = 24
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoice, Me.colTgl, Me.colUang, Me.colTotalBayar, Me.colTotalRefund, Me.colSisaRefund, Me.colJumlahRefundValas, Me.colKursRefund, Me.colJumlahRefund, Me.colCatatan})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsFilter.AllowColumnMRUFilterList = False
        Me.xGridView.OptionsFilter.AllowFilterEditor = False
        Me.xGridView.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.xGridView.OptionsFilter.AllowMRUFilterList = False
        Me.xGridView.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = False
        Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTgl, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colInvoice
        '
        Me.colInvoice.Caption = "No Invoice"
        Me.colInvoice.FieldName = "Invoice.Kode"
        Me.colInvoice.Name = "colInvoice"
        Me.colInvoice.OptionsColumn.AllowEdit = False
        Me.colInvoice.OptionsColumn.ReadOnly = True
        Me.colInvoice.Visible = True
        Me.colInvoice.VisibleIndex = 0
        Me.colInvoice.Width = 130
        '
        'colTgl
        '
        Me.colTgl.Caption = "Tanggal"
        Me.colTgl.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colTgl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTgl.FieldName = "Invoice.Tanggal"
        Me.colTgl.Name = "colTgl"
        Me.colTgl.OptionsColumn.AllowEdit = False
        Me.colTgl.OptionsColumn.ReadOnly = True
        Me.colTgl.Visible = True
        Me.colTgl.VisibleIndex = 1
        Me.colTgl.Width = 90
        '
        'colUang
        '
        Me.colUang.Caption = "Mata Uang"
        Me.colUang.FieldName = "Invoice.Uang.Kode"
        Me.colUang.Name = "colUang"
        Me.colUang.OptionsColumn.AllowEdit = False
        Me.colUang.OptionsColumn.ReadOnly = True
        Me.colUang.Visible = True
        Me.colUang.VisibleIndex = 2
        Me.colUang.Width = 60
        '
        'colTotalBayar
        '
        Me.colTotalBayar.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalBayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalBayar.Caption = "Total Bayar"
        Me.colTotalBayar.FieldName = "Invoice.TotalPembayaran"
        Me.colTotalBayar.Name = "colTotalBayar"
        Me.colTotalBayar.OptionsColumn.AllowEdit = False
        Me.colTotalBayar.OptionsColumn.ReadOnly = True
        Me.colTotalBayar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalBayar.Visible = True
        Me.colTotalBayar.VisibleIndex = 3
        Me.colTotalBayar.Width = 90
        '
        'colTotalRefund
        '
        Me.colTotalRefund.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalRefund.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalRefund.Caption = "Total Refund"
        Me.colTotalRefund.FieldName = "Terbayar"
        Me.colTotalRefund.Name = "colTotalRefund"
        Me.colTotalRefund.OptionsColumn.AllowEdit = False
        Me.colTotalRefund.OptionsColumn.ReadOnly = True
        Me.colTotalRefund.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalRefund.Visible = True
        Me.colTotalRefund.VisibleIndex = 4
        Me.colTotalRefund.Width = 90
        '
        'colSisaRefund
        '
        Me.colSisaRefund.AppearanceHeader.Options.UseTextOptions = True
        Me.colSisaRefund.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSisaRefund.Caption = "Sisa Refund"
        Me.colSisaRefund.FieldName = "SisaRefund"
        Me.colSisaRefund.Name = "colSisaRefund"
        Me.colSisaRefund.OptionsColumn.AllowEdit = False
        Me.colSisaRefund.OptionsColumn.ReadOnly = True
        Me.colSisaRefund.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSisaRefund.Visible = True
        Me.colSisaRefund.VisibleIndex = 5
        Me.colSisaRefund.Width = 90
        '
        'colJumlahRefundValas
        '
        Me.colJumlahRefundValas.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colJumlahRefundValas.AppearanceCell.Options.UseBackColor = True
        Me.colJumlahRefundValas.AppearanceHeader.Options.UseTextOptions = True
        Me.colJumlahRefundValas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colJumlahRefundValas.Caption = "Jml. Refund (Valas)"
        Me.colJumlahRefundValas.ColumnEdit = Me.colSpinEditRepo
        Me.colJumlahRefundValas.FieldName = "JumlahBayarValas"
        Me.colJumlahRefundValas.Name = "colJumlahRefundValas"
        Me.colJumlahRefundValas.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colJumlahRefundValas.Visible = True
        Me.colJumlahRefundValas.VisibleIndex = 6
        Me.colJumlahRefundValas.Width = 90
        '
        'colSpinEditRepo
        '
        Me.colSpinEditRepo.AutoHeight = False
        Me.colSpinEditRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colSpinEditRepo.Name = "colSpinEditRepo"
        '
        'colKursRefund
        '
        Me.colKursRefund.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colKursRefund.AppearanceCell.Options.UseBackColor = True
        Me.colKursRefund.AppearanceHeader.Options.UseTextOptions = True
        Me.colKursRefund.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colKursRefund.Caption = "Kurs Refund"
        Me.colKursRefund.ColumnEdit = Me.colSpinEditRepo
        Me.colKursRefund.FieldName = "KursBayar"
        Me.colKursRefund.Name = "colKursRefund"
        Me.colKursRefund.Visible = True
        Me.colKursRefund.VisibleIndex = 7
        Me.colKursRefund.Width = 79
        '
        'colJumlahRefund
        '
        Me.colJumlahRefund.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colJumlahRefund.AppearanceCell.Options.UseBackColor = True
        Me.colJumlahRefund.AppearanceHeader.Options.UseTextOptions = True
        Me.colJumlahRefund.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colJumlahRefund.Caption = "Jml. Refund"
        Me.colJumlahRefund.ColumnEdit = Me.colSpinEditRepo
        Me.colJumlahRefund.FieldName = "JumlahBayar"
        Me.colJumlahRefund.Name = "colJumlahRefund"
        Me.colJumlahRefund.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colJumlahRefund.Visible = True
        Me.colJumlahRefund.VisibleIndex = 8
        Me.colJumlahRefund.Width = 90
        '
        'colCatatan
        '
        Me.colCatatan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCatatan.AppearanceCell.Options.UseBackColor = True
        Me.colCatatan.Caption = "Catatan"
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 9
        Me.colCatatan.Width = 277
        '
        'txtUang
        '
        Me.txtUang.Location = New System.Drawing.Point(390, 112)
        Me.txtUang.MenuManager = Me.barMan
        Me.txtUang.Name = "txtUang"
        Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
        Me.txtUang.Properties.DisplayMember = "Kode"
        Me.txtUang.Properties.NullText = "<Uang>"
        Me.txtUang.Properties.ReadOnly = True
        Me.txtUang.Properties.ValueMember = "This"
        Me.txtUang.Size = New System.Drawing.Size(127, 20)
        Me.txtUang.StyleController = Me.lytTransaksi
        Me.txtUang.TabIndex = 8
        '
        'txtAkun
        '
        Me.txtAkun.Location = New System.Drawing.Point(107, 106)
        Me.txtAkun.MenuManager = Me.barMan
        Me.txtAkun.Name = "txtAkun"
        Me.txtAkun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkun.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtAkun.Properties.DisplayMember = "Kode"
        Me.txtAkun.Properties.NullText = "<Pilih Coa>"
        Me.txtAkun.Properties.ValueMember = "This"
        Me.txtAkun.Size = New System.Drawing.Size(193, 20)
        Me.txtAkun.StyleController = Me.lytTransaksi
        Me.txtAkun.TabIndex = 7
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
        Me.txtUraian.Location = New System.Drawing.Point(107, 166)
        Me.txtUraian.MenuManager = Me.barMan
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUraian.Properties.MaxLength = 255
        Me.txtUraian.Size = New System.Drawing.Size(1009, 20)
        Me.txtUraian.StyleController = Me.lytTransaksi
        Me.txtUraian.TabIndex = 23
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
        'txtKurs
        '
        Me.txtKurs.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtKurs.Location = New System.Drawing.Point(601, 112)
        Me.txtKurs.MenuManager = Me.barMan
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtKurs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKurs.Size = New System.Drawing.Size(127, 20)
        Me.txtKurs.StyleController = Me.lytTransaksi
        Me.txtKurs.TabIndex = 11
        '
        'txtNilaiKas
        '
        Me.txtNilaiKas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNilaiKas.Location = New System.Drawing.Point(601, 136)
        Me.txtNilaiKas.MenuManager = Me.barMan
        Me.txtNilaiKas.Name = "txtNilaiKas"
        Me.txtNilaiKas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNilaiKas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNilaiKas.Properties.ReadOnly = True
        Me.txtNilaiKas.Size = New System.Drawing.Size(127, 20)
        Me.txtNilaiKas.StyleController = Me.lytTransaksi
        Me.txtNilaiKas.TabIndex = 14
        '
        'txtNilaiValas
        '
        Me.txtNilaiValas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNilaiValas.Location = New System.Drawing.Point(390, 136)
        Me.txtNilaiValas.MenuManager = Me.barMan
        Me.txtNilaiValas.Name = "txtNilaiValas"
        Me.txtNilaiValas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNilaiValas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNilaiValas.Properties.ReadOnly = True
        Me.txtNilaiValas.Size = New System.Drawing.Size(127, 20)
        Me.txtNilaiValas.StyleController = Me.lytTransaksi
        Me.txtNilaiValas.TabIndex = 9
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem8, Me.LayoutControlItem11, Me.LayoutControlGroup4, Me.EmptySpaceItem11, Me.layAkunKasBankNama, Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlItem3})
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
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtAkun
        Me.LayoutControlItem11.CustomizationFormText = "Coa Kas/Bank"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(292, 24)
        Me.LayoutControlItem11.Text = "Coa Kas/Bank"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(90, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CaptionImagePadding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlGroup4.CustomizationFormText = "Detail"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem12, Me.EmptySpaceItem3, Me.LayoutControlItem9, Me.LayoutControlItem13})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(292, 94)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(816, 60)
        Me.LayoutControlGroup4.Text = "Detail"
        Me.LayoutControlGroup4.TextLocation = DevExpress.Utils.Locations.Right
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtUang
        Me.LayoutControlItem10.CustomizationFormText = "Uang"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem10.Text = "Uang"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(75, 20)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtNilaiKas
        Me.LayoutControlItem12.CustomizationFormText = "Nilai Kas"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(211, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem12.Text = "  Nilai Kas"
        Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem12.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(422, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(363, 48)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtKurs
        Me.LayoutControlItem9.CustomizationFormText = "Kurs"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(211, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem9.Text = "  Kurs"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtNilaiValas
        Me.LayoutControlItem13.CustomizationFormText = "Nilai Valas"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem13.Text = "Nilai Valas"
        Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AllowHotTrack = False
        Me.EmptySpaceItem11.CustomizationFormText = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(0, 118)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(98, 36)
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
        Me.layAkunKasBankNama.Location = New System.Drawing.Point(98, 118)
        Me.layAkunKasBankNama.Name = "layAkunKasBankNama"
        Me.layAkunKasBankNama.Size = New System.Drawing.Size(194, 36)
        Me.layAkunKasBankNama.Text = "Nama Coa Kas/Bank"
        Me.layAkunKasBankNama.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layAkunKasBankNama.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.xGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 178)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1108, 232)
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
        Me.LayoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 154)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1108, 24)
        Me.LayoutControlItem3.Text = "Uraian"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(90, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
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
        'UI_TravelRefundDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 468)
        Me.KeyPreview = True
        Me.Name = "UI_TravelRefundDialog"
        Me.Text = "Refund [RF]"
        CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xxHapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lytTransaksi.ResumeLayout(False)
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colSpinEditRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiKas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiValas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layAkunKasBankNama, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
	Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
	Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
	Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtAkun As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents layAkunKasBankNama As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colInvoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalBayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalRefund As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKursRefund As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJumlahRefund As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtKurs As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNilaiKas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNilaiValas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colSisaRefund As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJumlahRefundValas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSpinEditRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
