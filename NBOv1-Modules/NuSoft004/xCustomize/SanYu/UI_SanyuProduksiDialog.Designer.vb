<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SanyuProduksiDialog
  Inherits Core.Win.Forms.InputDialog

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
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.lytTransaksiSA = New DevExpress.XtraLayout.LayoutControl()
    Me.txtPembantuTonase = New DevExpress.XtraEditors.TextEdit()
    Me.txtPembantuQty = New DevExpress.XtraEditors.TextEdit()
    Me.txtWasteTonase = New DevExpress.XtraEditors.TextEdit()
    Me.txtBahanJadiTonase = New DevExpress.XtraEditors.TextEdit()
    Me.txtBahanBakuTonase = New DevExpress.XtraEditors.TextEdit()
    Me.btnHitung = New DevExpress.XtraEditors.SimpleButton()
    Me.txtBahanJadiQty = New DevExpress.XtraEditors.TextEdit()
    Me.txtBahanBakuQty = New DevExpress.XtraEditors.TextEdit()
    Me.txtWasteQty = New DevExpress.XtraEditors.TextEdit()
    Me.txtReff = New DevExpress.XtraEditors.TextEdit()
    Me.xGridBahanPembantu = New DevExpress.XtraGrid.GridControl()
    Me.xGridBahanPembantuView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPembelian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPembelianRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.colTonasePembantu = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtNoPO = New DevExpress.XtraEditors.TextEdit()
    Me.xGridDetail = New DevExpress.XtraGrid.GridControl()
    Me.xGridDetailView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colBakuPembelian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBakuNoPembelianRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.colBakuKodeBarangRepoView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBakuUkuran = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBakuQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBakuQty2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colL = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTonase = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTonaseP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtPelanggan = New DevExpress.XtraEditors.TextEdit()
    Me.txtQty = New DevExpress.XtraEditors.TextEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoRencanaProduksi = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtBarangJadi = New DevExpress.XtraEditors.TextEdit()
    Me.txtBahanBaku = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoSebelumnya = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtProses = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtKodeWaste = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtBatch = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytgWaste = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.txtQtyPO = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTransaksiSA, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksiSA.SuspendLayout()
    CType(Me.txtPembantuTonase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPembantuQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtWasteTonase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBahanJadiTonase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBahanBakuTonase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBahanJadiQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBahanBakuQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtWasteQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtReff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridBahanPembantu, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridBahanPembantuView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colPembelianRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDetailView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colBakuNoPembelianRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colBakuKodeBarangRepoView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPelanggan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoRencanaProduksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBarangJadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBahanBaku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoSebelumnya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKodeWaste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBatch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytgWaste, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQtyPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(117, 36)
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Properties.ReadOnly = True
    Me.txtNoTransaksi.Size = New System.Drawing.Size(207, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksiSA
    Me.txtNoTransaksi.TabIndex = 104
    '
    'lytTransaksiSA
    '
    Me.lytTransaksiSA.Controls.Add(Me.txtQtyPO)
    Me.lytTransaksiSA.Controls.Add(Me.txtPembantuTonase)
    Me.lytTransaksiSA.Controls.Add(Me.txtPembantuQty)
    Me.lytTransaksiSA.Controls.Add(Me.txtWasteTonase)
    Me.lytTransaksiSA.Controls.Add(Me.txtBahanJadiTonase)
    Me.lytTransaksiSA.Controls.Add(Me.txtBahanBakuTonase)
    Me.lytTransaksiSA.Controls.Add(Me.btnHitung)
    Me.lytTransaksiSA.Controls.Add(Me.txtBahanJadiQty)
    Me.lytTransaksiSA.Controls.Add(Me.txtBahanBakuQty)
    Me.lytTransaksiSA.Controls.Add(Me.txtWasteQty)
    Me.lytTransaksiSA.Controls.Add(Me.txtReff)
    Me.lytTransaksiSA.Controls.Add(Me.xGridBahanPembantu)
    Me.lytTransaksiSA.Controls.Add(Me.txtNoPO)
    Me.lytTransaksiSA.Controls.Add(Me.xGridDetail)
    Me.lytTransaksiSA.Controls.Add(Me.txtPelanggan)
    Me.lytTransaksiSA.Controls.Add(Me.txtQty)
    Me.lytTransaksiSA.Controls.Add(Me.txtTanggal)
    Me.lytTransaksiSA.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksiSA.Controls.Add(Me.txtRegional)
    Me.lytTransaksiSA.Controls.Add(Me.txtNoRencanaProduksi)
    Me.lytTransaksiSA.Controls.Add(Me.txtBarangJadi)
    Me.lytTransaksiSA.Controls.Add(Me.txtBahanBaku)
    Me.lytTransaksiSA.Controls.Add(Me.txtNoSebelumnya)
    Me.lytTransaksiSA.Controls.Add(Me.txtProses)
    Me.lytTransaksiSA.Controls.Add(Me.txtKodeWaste)
    Me.lytTransaksiSA.Controls.Add(Me.txtBatch)
    Me.lytTransaksiSA.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksiSA.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksiSA.Name = "lytTransaksiSA"
    Me.lytTransaksiSA.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(138, 68, 250, 350)
    Me.lytTransaksiSA.Root = Me.LayoutControlGroup1
    Me.lytTransaksiSA.Size = New System.Drawing.Size(665, 475)
    Me.lytTransaksiSA.TabIndex = 114
    Me.lytTransaksiSA.Text = "LayoutControl1"
    '
    'txtPembantuTonase
    '
    Me.txtPembantuTonase.Location = New System.Drawing.Point(418, 336)
    Me.txtPembantuTonase.Name = "txtPembantuTonase"
    Me.txtPembantuTonase.Size = New System.Drawing.Size(223, 20)
    Me.txtPembantuTonase.StyleController = Me.lytTransaksiSA
    Me.txtPembantuTonase.TabIndex = 128
    '
    'txtPembantuQty
    '
    Me.txtPembantuQty.Location = New System.Drawing.Point(108, 336)
    Me.txtPembantuQty.Name = "txtPembantuQty"
    Me.txtPembantuQty.Size = New System.Drawing.Size(222, 20)
    Me.txtPembantuQty.StyleController = Me.lytTransaksiSA
    Me.txtPembantuQty.TabIndex = 127
    '
    'txtWasteTonase
    '
    Me.txtWasteTonase.Location = New System.Drawing.Point(418, 312)
    Me.txtWasteTonase.Name = "txtWasteTonase"
    Me.txtWasteTonase.Size = New System.Drawing.Size(223, 20)
    Me.txtWasteTonase.StyleController = Me.lytTransaksiSA
    Me.txtWasteTonase.TabIndex = 126
    '
    'txtBahanJadiTonase
    '
    Me.txtBahanJadiTonase.Location = New System.Drawing.Point(418, 288)
    Me.txtBahanJadiTonase.Name = "txtBahanJadiTonase"
    Me.txtBahanJadiTonase.Size = New System.Drawing.Size(223, 20)
    Me.txtBahanJadiTonase.StyleController = Me.lytTransaksiSA
    Me.txtBahanJadiTonase.TabIndex = 125
    '
    'txtBahanBakuTonase
    '
    Me.txtBahanBakuTonase.Location = New System.Drawing.Point(418, 264)
    Me.txtBahanBakuTonase.Name = "txtBahanBakuTonase"
    Me.txtBahanBakuTonase.Size = New System.Drawing.Size(223, 20)
    Me.txtBahanBakuTonase.StyleController = Me.lytTransaksiSA
    Me.txtBahanBakuTonase.TabIndex = 124
    '
    'btnHitung
    '
    Me.btnHitung.Location = New System.Drawing.Point(112, 360)
    Me.btnHitung.Name = "btnHitung"
    Me.btnHitung.Size = New System.Drawing.Size(116, 22)
    Me.btnHitung.StyleController = Me.lytTransaksiSA
    Me.btnHitung.TabIndex = 123
    Me.btnHitung.Text = "Hitung Waste"
    '
    'txtBahanJadiQty
    '
    Me.txtBahanJadiQty.Location = New System.Drawing.Point(108, 288)
    Me.txtBahanJadiQty.Name = "txtBahanJadiQty"
    Me.txtBahanJadiQty.Size = New System.Drawing.Size(222, 20)
    Me.txtBahanJadiQty.StyleController = Me.lytTransaksiSA
    Me.txtBahanJadiQty.TabIndex = 122
    '
    'txtBahanBakuQty
    '
    Me.txtBahanBakuQty.Location = New System.Drawing.Point(108, 264)
    Me.txtBahanBakuQty.Name = "txtBahanBakuQty"
    Me.txtBahanBakuQty.Size = New System.Drawing.Size(222, 20)
    Me.txtBahanBakuQty.StyleController = Me.lytTransaksiSA
    Me.txtBahanBakuQty.TabIndex = 121
    '
    'txtWasteQty
    '
    Me.txtWasteQty.Location = New System.Drawing.Point(108, 312)
    Me.txtWasteQty.Name = "txtWasteQty"
    Me.txtWasteQty.Size = New System.Drawing.Size(222, 20)
    Me.txtWasteQty.StyleController = Me.lytTransaksiSA
    Me.txtWasteQty.TabIndex = 120
    '
    'txtReff
    '
    Me.txtReff.Location = New System.Drawing.Point(576, 12)
    Me.txtReff.Name = "txtReff"
    Me.txtReff.Size = New System.Drawing.Size(77, 20)
    Me.txtReff.StyleController = Me.lytTransaksiSA
    Me.txtReff.TabIndex = 118
    '
    'xGridBahanPembantu
    '
    Me.xGridBahanPembantu.Location = New System.Drawing.Point(24, 214)
    Me.xGridBahanPembantu.MainView = Me.xGridBahanPembantuView
    Me.xGridBahanPembantu.Name = "xGridBahanPembantu"
    Me.xGridBahanPembantu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colKodeBarangRepo, Me.colPembelianRepo})
    Me.xGridBahanPembantu.Size = New System.Drawing.Size(617, 237)
    Me.xGridBahanPembantu.TabIndex = 116
    Me.xGridBahanPembantu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridBahanPembantuView})
    '
    'xGridBahanPembantuView
    '
    Me.xGridBahanPembantuView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colPembelian, Me.colTonasePembantu, Me.GridColumn18})
    Me.xGridBahanPembantuView.GridControl = Me.xGridBahanPembantu
    Me.xGridBahanPembantuView.Name = "xGridBahanPembantuView"
    Me.xGridBahanPembantuView.NewItemRowText = "<Tambah Data>"
    Me.xGridBahanPembantuView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridBahanPembantuView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridBahanPembantuView.OptionsView.ShowGroupPanel = False
    '
    'colKodeBarang
    '
    Me.colKodeBarang.Caption = "Kode Barang"
    Me.colKodeBarang.ColumnEdit = Me.colKodeBarangRepo
    Me.colKodeBarang.FieldName = "Barang!"
    Me.colKodeBarang.Name = "colKodeBarang"
    Me.colKodeBarang.Visible = True
    Me.colKodeBarang.VisibleIndex = 0
    '
    'colKodeBarangRepo
    '
    Me.colKodeBarangRepo.AutoHeight = False
    Me.colKodeBarangRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKodeBarangRepo.DisplayMember = "Kode"
    Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
    Me.colKodeBarangRepo.NullText = "<Pilih Barang>"
    Me.colKodeBarangRepo.ValueMember = "This"
    Me.colKodeBarangRepo.View = Me.RepositoryItemSearchLookUpEdit1View
    '
    'RepositoryItemSearchLookUpEdit1View
    '
    Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colNama})
    Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
    Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
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
    '
    'colQty
    '
    Me.colQty.Caption = "Qty"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 2
    Me.colQty.Width = 60
    '
    'colSatuan
    '
    Me.colSatuan.Caption = "Satuan"
    Me.colSatuan.FieldName = "Satuan.Kode"
    Me.colSatuan.Name = "colSatuan"
    Me.colSatuan.OptionsColumn.AllowEdit = False
    Me.colSatuan.OptionsColumn.ReadOnly = True
    Me.colSatuan.Visible = True
    Me.colSatuan.VisibleIndex = 3
    Me.colSatuan.Width = 95
    '
    'colPembelian
    '
    Me.colPembelian.Caption = "No Pembelian"
    Me.colPembelian.ColumnEdit = Me.colPembelianRepo
    Me.colPembelian.FieldName = "Pembelian.Main.Kode"
    Me.colPembelian.Name = "colPembelian"
    Me.colPembelian.Visible = True
    Me.colPembelian.VisibleIndex = 4
    '
    'colPembelianRepo
    '
    Me.colPembelianRepo.AutoHeight = False
    Me.colPembelianRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.colPembelianRepo.Name = "colPembelianRepo"
    '
    'colTonasePembantu
    '
    Me.colTonasePembantu.Caption = "Tn"
    Me.colTonasePembantu.DisplayFormat.FormatString = "n2"
    Me.colTonasePembantu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTonasePembantu.FieldName = "Tonase"
    Me.colTonasePembantu.Name = "colTonasePembantu"
    Me.colTonasePembantu.Visible = True
    Me.colTonasePembantu.VisibleIndex = 5
    '
    'GridColumn18
    '
    Me.GridColumn18.Caption = "Tn Pur"
    Me.GridColumn18.DisplayFormat.FormatString = "n2"
    Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn18.FieldName = "TonaseP"
    Me.GridColumn18.Name = "GridColumn18"
    Me.GridColumn18.OptionsColumn.AllowEdit = False
    Me.GridColumn18.OptionsColumn.ReadOnly = True
    Me.GridColumn18.Visible = True
    Me.GridColumn18.VisibleIndex = 6
    '
    'txtNoPO
    '
    Me.txtNoPO.Location = New System.Drawing.Point(382, 84)
    Me.txtNoPO.Name = "txtNoPO"
    Me.txtNoPO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoPO.Properties.ReadOnly = True
    Me.txtNoPO.Size = New System.Drawing.Size(128, 20)
    Me.txtNoPO.StyleController = Me.lytTransaksiSA
    Me.txtNoPO.TabIndex = 116
    '
    'xGridDetail
    '
    Me.xGridDetail.Location = New System.Drawing.Point(24, 214)
    Me.xGridDetail.MainView = Me.xGridDetailView
    Me.xGridDetail.Name = "xGridDetail"
    Me.xGridDetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colBakuNoPembelianRepo})
    Me.xGridDetail.Size = New System.Drawing.Size(617, 237)
    Me.xGridDetail.TabIndex = 115
    Me.xGridDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridDetailView})
    '
    'xGridDetailView
    '
    Me.xGridDetailView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBakuPembelian, Me.colBakuUkuran, Me.colBakuQty, Me.colBakuQty2, Me.colP, Me.colL, Me.colT, Me.colTonase, Me.colTonaseP, Me.GridColumn14, Me.GridColumn16, Me.GridColumn15})
    Me.xGridDetailView.GridControl = Me.xGridDetail
    Me.xGridDetailView.Name = "xGridDetailView"
    Me.xGridDetailView.NewItemRowText = "<Tambah Data>"
    Me.xGridDetailView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridDetailView.OptionsView.ColumnAutoWidth = False
    Me.xGridDetailView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridDetailView.OptionsView.ShowGroupPanel = False
    '
    'colBakuPembelian
    '
    Me.colBakuPembelian.Caption = "No Pembelian"
    Me.colBakuPembelian.ColumnEdit = Me.colBakuNoPembelianRepo
    Me.colBakuPembelian.FieldName = "Pembelian!"
    Me.colBakuPembelian.Name = "colBakuPembelian"
    Me.colBakuPembelian.Visible = True
    Me.colBakuPembelian.VisibleIndex = 0
    Me.colBakuPembelian.Width = 131
    '
    'colBakuNoPembelianRepo
    '
    Me.colBakuNoPembelianRepo.AutoHeight = False
    Me.colBakuNoPembelianRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colBakuNoPembelianRepo.DisplayMember = "Main.Kode"
    Me.colBakuNoPembelianRepo.Name = "colBakuNoPembelianRepo"
    Me.colBakuNoPembelianRepo.NullText = "<Pilih No Pembelian>"
    Me.colBakuNoPembelianRepo.ValueMember = "This"
    Me.colBakuNoPembelianRepo.View = Me.colBakuKodeBarangRepoView
    '
    'colBakuKodeBarangRepoView
    '
    Me.colBakuKodeBarangRepoView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn17})
    Me.colBakuKodeBarangRepoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.colBakuKodeBarangRepoView.Name = "colBakuKodeBarangRepoView"
    Me.colBakuKodeBarangRepoView.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.colBakuKodeBarangRepoView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Tanggal"
    Me.GridColumn1.FieldName = "Main.Tanggal"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "No Pembelian"
    Me.GridColumn2.FieldName = "Main.Kode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn17
    '
    Me.GridColumn17.Caption = "No PIB"
    Me.GridColumn17.FieldName = "NoPIB.Main.ReffNo"
    Me.GridColumn17.Name = "GridColumn17"
    Me.GridColumn17.Visible = True
    Me.GridColumn17.VisibleIndex = 2
    '
    'colBakuUkuran
    '
    Me.colBakuUkuran.Caption = "Ukuran"
    Me.colBakuUkuran.FieldName = "Ukuran"
    Me.colBakuUkuran.Name = "colBakuUkuran"
    Me.colBakuUkuran.Width = 207
    '
    'colBakuQty
    '
    Me.colBakuQty.Caption = "Qty [m3]"
    Me.colBakuQty.DisplayFormat.FormatString = "n4"
    Me.colBakuQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colBakuQty.FieldName = "Qty"
    Me.colBakuQty.Name = "colBakuQty"
    Me.colBakuQty.Visible = True
    Me.colBakuQty.VisibleIndex = 5
    Me.colBakuQty.Width = 55
    '
    'colBakuQty2
    '
    Me.colBakuQty2.Caption = "Pcs"
    Me.colBakuQty2.FieldName = "QtyPcs"
    Me.colBakuQty2.Name = "colBakuQty2"
    Me.colBakuQty2.Visible = True
    Me.colBakuQty2.VisibleIndex = 4
    Me.colBakuQty2.Width = 45
    '
    'colP
    '
    Me.colP.Caption = "P"
    Me.colP.DisplayFormat.FormatString = "n2"
    Me.colP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colP.FieldName = "Panjang"
    Me.colP.Name = "colP"
    Me.colP.Visible = True
    Me.colP.VisibleIndex = 1
    Me.colP.Width = 65
    '
    'colL
    '
    Me.colL.Caption = "L"
    Me.colL.DisplayFormat.FormatString = "n2"
    Me.colL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colL.FieldName = "Lebar"
    Me.colL.Name = "colL"
    Me.colL.Visible = True
    Me.colL.VisibleIndex = 2
    Me.colL.Width = 65
    '
    'colT
    '
    Me.colT.Caption = "T"
    Me.colT.DisplayFormat.FormatString = "n2"
    Me.colT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colT.FieldName = "Tebal"
    Me.colT.Name = "colT"
    Me.colT.Visible = True
    Me.colT.VisibleIndex = 3
    Me.colT.Width = 65
    '
    'colTonase
    '
    Me.colTonase.Caption = "Tn"
    Me.colTonase.FieldName = "Tonase"
    Me.colTonase.Name = "colTonase"
    Me.colTonase.Visible = True
    Me.colTonase.VisibleIndex = 6
    Me.colTonase.Width = 65
    '
    'colTonaseP
    '
    Me.colTonaseP.Caption = "Tn Pur"
    Me.colTonaseP.FieldName = "TonaseP"
    Me.colTonaseP.Name = "colTonaseP"
    Me.colTonaseP.OptionsColumn.AllowEdit = False
    Me.colTonaseP.OptionsColumn.ReadOnly = True
    Me.colTonaseP.Visible = True
    Me.colTonaseP.VisibleIndex = 7
    Me.colTonaseP.Width = 65
    '
    'GridColumn14
    '
    Me.GridColumn14.Caption = "TonasiM3"
    Me.GridColumn14.FieldName = "TonaseP"
    Me.GridColumn14.Name = "GridColumn14"
    Me.GridColumn14.OptionsColumn.AllowEdit = False
    Me.GridColumn14.OptionsColumn.ReadOnly = True
    '
    'GridColumn16
    '
    Me.GridColumn16.Caption = "Qty Pmb"
    Me.GridColumn16.FieldName = "Pembelian.QtyIn"
    Me.GridColumn16.Name = "GridColumn16"
    Me.GridColumn16.OptionsColumn.AllowEdit = False
    Me.GridColumn16.OptionsColumn.ReadOnly = True
    '
    'GridColumn15
    '
    Me.GridColumn15.Caption = "T Pmb"
    Me.GridColumn15.FieldName = "Pembelian.Tonase"
    Me.GridColumn15.Name = "GridColumn15"
    Me.GridColumn15.OptionsColumn.AllowEdit = False
    Me.GridColumn15.OptionsColumn.ReadOnly = True
    '
    'txtPelanggan
    '
    Me.txtPelanggan.Location = New System.Drawing.Point(117, 84)
    Me.txtPelanggan.Name = "txtPelanggan"
    Me.txtPelanggan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPelanggan.Properties.ReadOnly = True
    Me.txtPelanggan.Size = New System.Drawing.Size(206, 20)
    Me.txtPelanggan.StyleController = Me.lytTransaksiSA
    Me.txtPelanggan.TabIndex = 115
    '
    'txtQty
    '
    Me.txtQty.EditValue = "0"
    Me.txtQty.Location = New System.Drawing.Point(382, 132)
    Me.txtQty.Name = "txtQty"
    Me.txtQty.Properties.Appearance.Options.UseTextOptions = True
    Me.txtQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtQty.Properties.Mask.EditMask = "n2"
    Me.txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtQty.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtQty.Size = New System.Drawing.Size(128, 20)
    Me.txtQty.StyleController = Me.lytTransaksiSA
    Me.txtQty.TabIndex = 110
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(117, 12)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Properties.ReadOnly = True
    Me.txtTanggal.Size = New System.Drawing.Size(208, 20)
    Me.txtTanggal.StyleController = Me.lytTransaksiSA
    Me.txtTanggal.TabIndex = 106
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(384, 12)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.PopupWidth = 200
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(104, 20)
    Me.txtRegional.StyleController = Me.lytTransaksiSA
    Me.txtRegional.TabIndex = 107
    '
    'txtNoRencanaProduksi
    '
    Me.txtNoRencanaProduksi.Location = New System.Drawing.Point(117, 60)
    Me.txtNoRencanaProduksi.Name = "txtNoRencanaProduksi"
    Me.txtNoRencanaProduksi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtNoRencanaProduksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoRencanaProduksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoRencanaProduksi.Properties.DisplayMember = "Main.Kode"
    Me.txtNoRencanaProduksi.Properties.NullText = "<Pilih No Produksi>"
    Me.txtNoRencanaProduksi.Properties.PopupFormSize = New System.Drawing.Size(200, 0)
    Me.txtNoRencanaProduksi.Properties.ValueMember = "This"
    Me.txtNoRencanaProduksi.Properties.View = Me.SearchLookUpEdit1View
    Me.txtNoRencanaProduksi.Size = New System.Drawing.Size(393, 20)
    Me.txtNoRencanaProduksi.StyleController = Me.lytTransaksiSA
    Me.txtNoRencanaProduksi.TabIndex = 109
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn19, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsFind.FindDelay = 500
    Me.SearchLookUpEdit1View.OptionsFind.SearchInPreview = True
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    '
    'GridColumn19
    '
    Me.GridColumn19.Caption = "Kode Item"
    Me.GridColumn19.FieldName = "Barang.Kode"
    Me.GridColumn19.Name = "GridColumn19"
    Me.GridColumn19.Visible = True
    Me.GridColumn19.VisibleIndex = 0
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Bahan Jadi"
    Me.GridColumn4.FieldName = "Barang.Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Kode Rencana"
    Me.GridColumn5.FieldName = "Main.Kode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Width = 78
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Tanggal Rencana"
    Me.GridColumn6.FieldName = "Main.Tanggal"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Width = 92
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Pelanggan"
    Me.GridColumn7.FieldName = "Main.Pelanggan.Nama"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 2
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "No SO"
    Me.GridColumn8.FieldName = "OrderPenjualan.Main.Kode"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 3
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "No PO Pelanggan"
    Me.GridColumn9.FieldName = "OrderPenjualan.Main.NomorPO"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 4
    Me.GridColumn9.Width = 92
    '
    'txtBarangJadi
    '
    Me.txtBarangJadi.Location = New System.Drawing.Point(117, 108)
    Me.txtBarangJadi.Name = "txtBarangJadi"
    Me.txtBarangJadi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtBarangJadi.Properties.NullText = "<Pilih Bahan Jadi>"
    Me.txtBarangJadi.Properties.ReadOnly = True
    Me.txtBarangJadi.Size = New System.Drawing.Size(206, 20)
    Me.txtBarangJadi.StyleController = Me.lytTransaksiSA
    Me.txtBarangJadi.TabIndex = 108
    '
    'txtBahanBaku
    '
    Me.txtBahanBaku.Location = New System.Drawing.Point(117, 132)
    Me.txtBahanBaku.Name = "txtBahanBaku"
    Me.txtBahanBaku.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtBahanBaku.Properties.NullText = "<Pilih Bahan Baku>"
    Me.txtBahanBaku.Properties.ReadOnly = True
    Me.txtBahanBaku.Size = New System.Drawing.Size(206, 20)
    Me.txtBahanBaku.StyleController = Me.lytTransaksiSA
    Me.txtBahanBaku.TabIndex = 109
    '
    'txtNoSebelumnya
    '
    Me.txtNoSebelumnya.Location = New System.Drawing.Point(117, 156)
    Me.txtNoSebelumnya.Name = "txtNoSebelumnya"
    Me.txtNoSebelumnya.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtNoSebelumnya.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoSebelumnya.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoSebelumnya.Properties.DisplayMember = "Kode"
    Me.txtNoSebelumnya.Properties.NullText = "<Pilih Proses Sebelumnya>"
    Me.txtNoSebelumnya.Properties.ValueMember = "This"
    Me.txtNoSebelumnya.Properties.View = Me.GridView1
    Me.txtNoSebelumnya.Size = New System.Drawing.Size(206, 20)
    Me.txtNoSebelumnya.StyleController = Me.lytTransaksiSA
    Me.txtNoSebelumnya.TabIndex = 117
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTanggal, Me.colKode1, Me.GridColumn3})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.DisplayFormat.FormatString = "dd/MM/yy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 0
    '
    'colKode1
    '
    Me.colKode1.Caption = "No Bukti"
    Me.colKode1.FieldName = "Kode"
    Me.colKode1.Name = "colKode1"
    Me.colKode1.Visible = True
    Me.colKode1.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Proses"
    Me.GridColumn3.FieldName = "Proses.Nama"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'txtProses
    '
    Me.txtProses.Location = New System.Drawing.Point(383, 36)
    Me.txtProses.Name = "txtProses"
    Me.txtProses.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtProses.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtProses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProses.Properties.DisplayMember = "Nama"
    Me.txtProses.Properties.NullText = "<Pilih Proses>"
    Me.txtProses.Properties.PopupFormSize = New System.Drawing.Size(200, 0)
    Me.txtProses.Properties.ValueMember = "This"
    Me.txtProses.Properties.View = Me.GridView2
    Me.txtProses.Size = New System.Drawing.Size(127, 20)
    Me.txtProses.StyleController = Me.lytTransaksiSA
    Me.txtProses.TabIndex = 115
    '
    'GridView2
    '
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn12})
    Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView2.OptionsView.ShowGroupPanel = False
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Kode"
    Me.GridColumn10.FieldName = "Kode"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 0
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "Nama"
    Me.GridColumn12.FieldName = "Nama"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 1
    '
    'txtKodeWaste
    '
    Me.txtKodeWaste.Location = New System.Drawing.Point(108, 214)
    Me.txtKodeWaste.Name = "txtKodeWaste"
    Me.txtKodeWaste.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKodeWaste.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKodeWaste.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKodeWaste.Properties.DisplayMember = "Kode"
    Me.txtKodeWaste.Properties.NullText = "<Pilih Waste>"
    Me.txtKodeWaste.Properties.ValueMember = "This"
    Me.txtKodeWaste.Properties.View = Me.GridView3
    Me.txtKodeWaste.Size = New System.Drawing.Size(533, 20)
    Me.txtKodeWaste.StyleController = Me.lytTransaksiSA
    Me.txtKodeWaste.TabIndex = 119
    '
    'GridView3
    '
    Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn13})
    Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView3.Name = "GridView3"
    Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView3.OptionsView.ShowGroupPanel = False
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Kode"
    Me.GridColumn11.FieldName = "Kode"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 0
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "Nama"
    Me.GridColumn13.FieldName = "Nama"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 1
    '
    'txtBatch
    '
    Me.txtBatch.EditValue = ""
    Me.txtBatch.Location = New System.Drawing.Point(382, 156)
    Me.txtBatch.Name = "txtBatch"
    Me.txtBatch.Properties.NullText = "[EditValue is null]"
    Me.txtBatch.Size = New System.Drawing.Size(129, 20)
    Me.txtBatch.StyleController = Me.lytTransaksiSA
    Me.txtBatch.TabIndex = 129
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem11, Me.EmptySpaceItem1, Me.TabbedControlGroup1, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem25, Me.LayoutControlItem6, Me.LayoutControlItem26})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(665, 475)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTanggal
    Me.LayoutControlItem1.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(317, 24)
    Me.LayoutControlItem1.Text = "Tanggal"
    Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
    Me.LayoutControlItem1.TextToControlDistance = 5
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtNoRencanaProduksi
    Me.LayoutControlItem4.CustomizationFormText = "Gudang"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(502, 24)
    Me.LayoutControlItem4.Text = "No Rencana Prd"
    Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtRegional
    Me.LayoutControlItem3.CustomizationFormText = "Regional"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(317, 0)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(163, 24)
    Me.LayoutControlItem3.Text = "Regional"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(503, 144)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(142, 24)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtPelanggan
    Me.LayoutControlItem8.CustomizationFormText = "Pelanggan"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem8.Text = "Pelanggan"
    Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(100, 20)
    Me.LayoutControlItem8.TextToControlDistance = 5
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtNoPO
    Me.LayoutControlItem9.CustomizationFormText = "No PO"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(315, 72)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(187, 24)
    Me.LayoutControlItem9.Text = "No PO"
    Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem9.TextToControlDistance = 5
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtNoTransaksi
    Me.LayoutControlItem2.CustomizationFormText = "No. Bukti"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(316, 24)
    Me.LayoutControlItem2.Text = "No. Bukti"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtProses
    Me.LayoutControlItem11.CustomizationFormText = "Proses"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(316, 24)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(186, 24)
    Me.LayoutControlItem11.Text = "Proses"
    Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem11.TextToControlDistance = 5
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(502, 24)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(143, 120)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'TabbedControlGroup1
    '
    Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
    Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 168)
    Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
    Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
    Me.TabbedControlGroup1.SelectedTabPageIndex = 0
    Me.TabbedControlGroup1.Size = New System.Drawing.Size(645, 287)
    Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.lytgWaste})
    Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Detail Bahan Baku"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(621, 241)
    Me.LayoutControlGroup2.Text = "Detail Bahan Baku"
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.xGridDetail
    Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(621, 241)
    Me.LayoutControlItem10.Text = "LayoutControlItem10"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem10.TextToControlDistance = 0
    Me.LayoutControlItem10.TextVisible = False
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Bahan Baku Pembantu"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(621, 241)
    Me.LayoutControlGroup3.Text = "Bahan Baku Pembantu"
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.xGridBahanPembantu
    Me.LayoutControlItem12.CustomizationFormText = "Bahan Baku Pembantu"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(621, 241)
    Me.LayoutControlItem12.Text = "Bahan Baku Pembantu"
    Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem12.TextToControlDistance = 0
    Me.LayoutControlItem12.TextVisible = False
    '
    'lytgWaste
    '
    Me.lytgWaste.CustomizationFormText = "Barang Waste"
    Me.lytgWaste.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem19, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.LayoutControlItem16, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24})
    Me.lytgWaste.Location = New System.Drawing.Point(0, 0)
    Me.lytgWaste.Name = "lytgWaste"
    Me.lytgWaste.Size = New System.Drawing.Size(621, 241)
    Me.lytgWaste.Text = "Barang Waste"
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtKodeWaste
    Me.LayoutControlItem15.CustomizationFormText = "Barang Waste"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(621, 24)
    Me.LayoutControlItem15.Text = "Kode Waste"
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.txtBahanBakuQty
    Me.LayoutControlItem17.CustomizationFormText = "Total Bahan Baku [m3]"
    Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 50)
    Me.LayoutControlItem17.Name = "LayoutControlItem17"
    Me.LayoutControlItem17.Size = New System.Drawing.Size(310, 24)
    Me.LayoutControlItem17.Text = "Bahan Baku [M3]"
    Me.LayoutControlItem17.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem18
    '
    Me.LayoutControlItem18.Control = Me.txtBahanJadiQty
    Me.LayoutControlItem18.CustomizationFormText = "Total Bahan Jadi [m3]"
    Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 74)
    Me.LayoutControlItem18.Name = "LayoutControlItem18"
    Me.LayoutControlItem18.Size = New System.Drawing.Size(310, 24)
    Me.LayoutControlItem18.Text = "Bahan Jadi [M3]"
    Me.LayoutControlItem18.TextSize = New System.Drawing.Size(81, 13)
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 24)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(621, 26)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(208, 146)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(413, 26)
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.btnHitung
    Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(88, 146)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(120, 26)
    Me.LayoutControlItem19.Text = "LayoutControlItem19"
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem19.TextToControlDistance = 0
    Me.LayoutControlItem19.TextVisible = False
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 146)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(88, 26)
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 172)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(621, 69)
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtWasteQty
    Me.LayoutControlItem16.CustomizationFormText = "M3"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 98)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(310, 24)
    Me.LayoutControlItem16.Text = "Waste [M3]"
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem20
    '
    Me.LayoutControlItem20.Control = Me.txtBahanBakuTonase
    Me.LayoutControlItem20.CustomizationFormText = "Tonase"
    Me.LayoutControlItem20.Location = New System.Drawing.Point(310, 50)
    Me.LayoutControlItem20.Name = "LayoutControlItem20"
    Me.LayoutControlItem20.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem20.Text = "Tonase"
    Me.LayoutControlItem20.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem21
    '
    Me.LayoutControlItem21.Control = Me.txtBahanJadiTonase
    Me.LayoutControlItem21.CustomizationFormText = "Tonase"
    Me.LayoutControlItem21.Location = New System.Drawing.Point(310, 74)
    Me.LayoutControlItem21.Name = "LayoutControlItem21"
    Me.LayoutControlItem21.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem21.Text = "Tonase"
    Me.LayoutControlItem21.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem22
    '
    Me.LayoutControlItem22.Control = Me.txtWasteTonase
    Me.LayoutControlItem22.CustomizationFormText = "Tonase"
    Me.LayoutControlItem22.Location = New System.Drawing.Point(310, 98)
    Me.LayoutControlItem22.Name = "LayoutControlItem22"
    Me.LayoutControlItem22.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem22.Text = "Tonase"
    Me.LayoutControlItem22.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem23
    '
    Me.LayoutControlItem23.Control = Me.txtPembantuQty
    Me.LayoutControlItem23.CustomizationFormText = "Bahan Pembantu"
    Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 122)
    Me.LayoutControlItem23.Name = "LayoutControlItem23"
    Me.LayoutControlItem23.Size = New System.Drawing.Size(310, 24)
    Me.LayoutControlItem23.Text = "Bahan Pembantu"
    Me.LayoutControlItem23.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem24
    '
    Me.LayoutControlItem24.Control = Me.txtPembantuTonase
    Me.LayoutControlItem24.CustomizationFormText = "Tonase"
    Me.LayoutControlItem24.Location = New System.Drawing.Point(310, 122)
    Me.LayoutControlItem24.Name = "LayoutControlItem24"
    Me.LayoutControlItem24.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem24.Text = "Tonase"
    Me.LayoutControlItem24.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtNoSebelumnya
    Me.LayoutControlItem13.CustomizationFormText = "Proses Sebelumnya"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem13.Text = "Proses Sebelumnya"
    Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(100, 20)
    Me.LayoutControlItem13.TextToControlDistance = 5
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtReff
    Me.LayoutControlItem14.CustomizationFormText = "Reff"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(480, 0)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(165, 24)
    Me.LayoutControlItem14.Text = "Reff"
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(81, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtQty
    Me.LayoutControlItem6.CustomizationFormText = "Qty"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(315, 120)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(187, 24)
    Me.LayoutControlItem6.Text = "Qty"
    Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(50, 13)
    Me.LayoutControlItem6.TextToControlDistance = 5
    '
    'LayoutControlItem25
    '
    Me.LayoutControlItem25.Control = Me.txtBatch
    Me.LayoutControlItem25.CustomizationFormText = "Batch No"
    Me.LayoutControlItem25.Location = New System.Drawing.Point(315, 144)
    Me.LayoutControlItem25.Name = "LayoutControlItem25"
    Me.LayoutControlItem25.Size = New System.Drawing.Size(188, 24)
    Me.LayoutControlItem25.Text = "Batch No"
    Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem25.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem25.TextToControlDistance = 5
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtBarangJadi
    Me.LayoutControlItem5.CustomizationFormText = "Barang"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem5.Text = "Barang Jadi"
    Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
    Me.LayoutControlItem5.TextToControlDistance = 5
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtBahanBaku
    Me.LayoutControlItem7.CustomizationFormText = "Satuan"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem7.Text = "Bahan Baku"
    Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(100, 13)
    Me.LayoutControlItem7.TextToControlDistance = 5
    '
    'txtQtyPO
    '
    Me.txtQtyPO.Location = New System.Drawing.Point(382, 108)
    Me.txtQtyPO.Name = "txtQtyPO"
    Me.txtQtyPO.Properties.ReadOnly = True
    Me.txtQtyPO.Size = New System.Drawing.Size(128, 20)
    Me.txtQtyPO.StyleController = Me.lytTransaksiSA
    Me.txtQtyPO.TabIndex = 130
    '
    'LayoutControlItem26
    '
    Me.LayoutControlItem26.Control = Me.txtQtyPO
    Me.LayoutControlItem26.CustomizationFormText = "Qty PO"
    Me.LayoutControlItem26.Location = New System.Drawing.Point(315, 96)
    Me.LayoutControlItem26.Name = "LayoutControlItem26"
    Me.LayoutControlItem26.Size = New System.Drawing.Size(187, 24)
    Me.LayoutControlItem26.Text = "Qty PO"
    Me.LayoutControlItem26.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem26.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem26.TextToControlDistance = 5
    '
    'UI_SanyuProduksiDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(665, 524)
    Me.Controls.Add(Me.lytTransaksiSA)
    Me.Name = "UI_SanyuProduksiDialog"
    Me.Text = "Produksi"
    Me.Controls.SetChildIndex(Me.lytTransaksiSA, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTransaksiSA, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksiSA.ResumeLayout(False)
    CType(Me.txtPembantuTonase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPembantuQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtWasteTonase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBahanJadiTonase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBahanBakuTonase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBahanJadiQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBahanBakuQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtWasteQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtReff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridBahanPembantu, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridBahanPembantuView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colPembelianRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDetail, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDetailView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colBakuNoPembelianRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colBakuKodeBarangRepoView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPelanggan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoRencanaProduksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBarangJadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBahanBaku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoSebelumnya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKodeWaste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBatch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytgWaste, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQtyPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lytTransaksiSA As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGridDetail As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridDetailView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colBakuUkuran As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBakuPembelian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBakuQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBakuQty2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtNoPO As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPelanggan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoRencanaProduksi As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGridBahanPembantu As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridBahanPembantuView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBakuNoPembelianRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents colBakuKodeBarangRepoView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtBarangJadi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtBahanBaku As DevExpress.XtraEditors.TextEdit
  Friend WithEvents colPembelian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPembelianRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoSebelumnya As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtReff As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtProses As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colL As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colT As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents lytgWaste As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtBahanJadiQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtBahanBakuQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtWasteQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKodeWaste As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents btnHitung As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTonase As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtWasteTonase As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtBahanJadiTonase As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtBahanBakuTonase As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPembantuTonase As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPembantuQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colTonaseP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTonasePembantu As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtBatch As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtQtyPO As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
End Class
