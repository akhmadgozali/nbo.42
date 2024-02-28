<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohBreakdownWIP
	Inherits Core.Win.Forms.BlankForm

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohBreakdownWIP))
    Me.xGridViewDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colDetBarangKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDetNamaPart = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDetDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDetQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNomorDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoLot = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBarangKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartDesc = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyIn = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xGridViewProduksi = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colProdKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
    Me.btnTampilkan = New DevExpress.XtraEditors.SimpleButton()
    Me.txtFTanggalAkhir = New DevExpress.XtraEditors.DateEdit()
    Me.txtFTanggalAwal = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.colBahanJadi = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridViewDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridViewProduksi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtFTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGridViewDetail
    '
    Me.xGridViewDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetBarangKode, Me.colDetNamaPart, Me.colDetDescription, Me.colDetQty})
    Me.xGridViewDetail.GridControl = Me.xGrid
    Me.xGridViewDetail.Name = "xGridViewDetail"
    Me.xGridViewDetail.OptionsBehavior.Editable = False
    Me.xGridViewDetail.OptionsDetail.EnableMasterViewMode = False
    Me.xGridViewDetail.OptionsView.ShowGroupPanel = False
    Me.xGridViewDetail.ViewCaption = "Bahan Baku"
    '
    'colDetBarangKode
    '
    Me.colDetBarangKode.Caption = "Part No."
    Me.colDetBarangKode.FieldName = "Barang.Kode"
    Me.colDetBarangKode.Name = "colDetBarangKode"
    Me.colDetBarangKode.Visible = True
    Me.colDetBarangKode.VisibleIndex = 0
    '
    'colDetNamaPart
    '
    Me.colDetNamaPart.Caption = "Nama Part"
    Me.colDetNamaPart.Name = "colDetNamaPart"
    Me.colDetNamaPart.Visible = True
    Me.colDetNamaPart.VisibleIndex = 1
    '
    'colDetDescription
    '
    Me.colDetDescription.Caption = "Description"
    Me.colDetDescription.Name = "colDetDescription"
    Me.colDetDescription.Visible = True
    Me.colDetDescription.VisibleIndex = 2
    '
    'colDetQty
    '
    Me.colDetQty.Caption = "Qty"
    Me.colDetQty.DisplayFormat.FormatString = "n0"
    Me.colDetQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colDetQty.Name = "colDetQty"
    Me.colDetQty.Visible = True
    Me.colDetQty.VisibleIndex = 3
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 81)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(880, 327)
    Me.xGrid.TabIndex = 4
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView, Me.xGridViewProduksi, Me.GridView1, Me.xGridViewDetail})
    '
    'xGridView
    '
    Me.xGridView.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
    Me.xGridView.Appearance.GroupPanel.Options.UseFont = True
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTahun, Me.colBulan, Me.colNoTransaksi, Me.colTanggal, Me.colCustomer, Me.colNomorDempyou, Me.colNoLot, Me.colBarangKode, Me.colPartName, Me.colPartDesc, Me.colQtyIn, Me.colQtyOut, Me.colCatatan, Me.colStatusTransaksi, Me.colBahanJadi})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.GroupCount = 2
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.ShowAutoFilterRow = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Descending)})
    '
    'colTahun
    '
    Me.colTahun.AppearanceHeader.Options.UseTextOptions = True
    Me.colTahun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colTahun.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colTahun.Caption = "Tahun"
    Me.colTahun.FieldName = "Main.Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 3
    Me.colTahun.Width = 100
    '
    'colBulan
    '
    Me.colBulan.AppearanceHeader.Options.UseTextOptions = True
    Me.colBulan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colBulan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colBulan.Caption = "Bulan"
    Me.colBulan.DisplayFormat.FormatString = "MMMM"
    Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.FieldName = "Main.Bulan"
    Me.colBulan.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
    Me.colBulan.GroupFormat.FormatString = "MMMM"
    Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.Name = "colBulan"
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 3
    Me.colBulan.Width = 130
    '
    'colNoTransaksi
    '
    Me.colNoTransaksi.AppearanceHeader.Options.UseTextOptions = True
    Me.colNoTransaksi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colNoTransaksi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colNoTransaksi.Caption = "No. Transaksi"
    Me.colNoTransaksi.FieldName = "Main.Kode"
    Me.colNoTransaksi.Name = "colNoTransaksi"
    Me.colNoTransaksi.Visible = True
    Me.colNoTransaksi.VisibleIndex = 0
    Me.colNoTransaksi.Width = 150
    '
    'colTanggal
    '
    Me.colTanggal.AppearanceCell.Options.UseTextOptions = True
    Me.colTanggal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colTanggal.AppearanceHeader.Options.UseTextOptions = True
    Me.colTanggal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colTanggal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.DisplayFormat.FormatString = "dd-MMM-yy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colTanggal.FieldName = "Main.Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    Me.colTanggal.Width = 70
    '
    'colCustomer
    '
    Me.colCustomer.AppearanceHeader.Options.UseTextOptions = True
    Me.colCustomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colCustomer.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colCustomer.Caption = "Customer"
    Me.colCustomer.FieldName = "Main.Pelanggan.Nama"
    Me.colCustomer.Name = "colCustomer"
    Me.colCustomer.Visible = True
    Me.colCustomer.VisibleIndex = 2
    Me.colCustomer.Width = 200
    '
    'colNomorDempyou
    '
    Me.colNomorDempyou.AppearanceCell.Options.UseTextOptions = True
    Me.colNomorDempyou.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colNomorDempyou.AppearanceHeader.Options.UseTextOptions = True
    Me.colNomorDempyou.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colNomorDempyou.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colNomorDempyou.Caption = "No. Dempyou"
    Me.colNomorDempyou.FieldName = "Main.OrderProduksi.Kode"
    Me.colNomorDempyou.Name = "colNomorDempyou"
    Me.colNomorDempyou.Visible = True
    Me.colNomorDempyou.VisibleIndex = 3
    Me.colNomorDempyou.Width = 92
    '
    'colNoLot
    '
    Me.colNoLot.AppearanceCell.Options.UseTextOptions = True
    Me.colNoLot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colNoLot.AppearanceHeader.Options.UseTextOptions = True
    Me.colNoLot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colNoLot.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colNoLot.Caption = "No. Lot"
    Me.colNoLot.FieldName = "Main.DempyouLot"
    Me.colNoLot.Name = "colNoLot"
    Me.colNoLot.Visible = True
    Me.colNoLot.VisibleIndex = 4
    Me.colNoLot.Width = 70
    '
    'colBarangKode
    '
    Me.colBarangKode.AppearanceHeader.Options.UseTextOptions = True
    Me.colBarangKode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colBarangKode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colBarangKode.Caption = "Part No"
    Me.colBarangKode.FieldName = "Barang.Kode"
    Me.colBarangKode.Name = "colBarangKode"
    Me.colBarangKode.Visible = True
    Me.colBarangKode.VisibleIndex = 5
    Me.colBarangKode.Width = 100
    '
    'colPartName
    '
    Me.colPartName.AppearanceHeader.Options.UseTextOptions = True
    Me.colPartName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colPartName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colPartName.Caption = "Part Name"
    Me.colPartName.FieldName = "Barang.NamaPart"
    Me.colPartName.Name = "colPartName"
    Me.colPartName.Visible = True
    Me.colPartName.VisibleIndex = 6
    Me.colPartName.Width = 150
    '
    'colPartDesc
    '
    Me.colPartDesc.AppearanceHeader.Options.UseTextOptions = True
    Me.colPartDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colPartDesc.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colPartDesc.Caption = "Part Description"
    Me.colPartDesc.FieldName = "Barang.FGSize"
    Me.colPartDesc.Name = "colPartDesc"
    Me.colPartDesc.Visible = True
    Me.colPartDesc.VisibleIndex = 7
    Me.colPartDesc.Width = 200
    '
    'colQtyIn
    '
    Me.colQtyIn.AppearanceHeader.Options.UseTextOptions = True
    Me.colQtyIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colQtyIn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colQtyIn.Caption = "Qty In"
    Me.colQtyIn.DisplayFormat.FormatString = "n0"
    Me.colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQtyIn.FieldName = "QtyIn"
    Me.colQtyIn.Name = "colQtyIn"
    Me.colQtyIn.Visible = True
    Me.colQtyIn.VisibleIndex = 8
    Me.colQtyIn.Width = 60
    '
    'colQtyOut
    '
    Me.colQtyOut.AppearanceHeader.Options.UseTextOptions = True
    Me.colQtyOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colQtyOut.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colQtyOut.Caption = "Qty Out"
    Me.colQtyOut.DisplayFormat.FormatString = "n0"
    Me.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQtyOut.FieldName = "QtyOut"
    Me.colQtyOut.Name = "colQtyOut"
    Me.colQtyOut.Visible = True
    Me.colQtyOut.VisibleIndex = 9
    Me.colQtyOut.Width = 60
    '
    'colCatatan
    '
    Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
    Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
    Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colCatatan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colCatatan.Caption = "Catatan"
    Me.colCatatan.FieldName = "Main.Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 10
    Me.colCatatan.Width = 150
    '
    'colStatusTransaksi
    '
    Me.colStatusTransaksi.AppearanceCell.Options.UseTextOptions = True
    Me.colStatusTransaksi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colStatusTransaksi.AppearanceHeader.Options.UseTextOptions = True
    Me.colStatusTransaksi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colStatusTransaksi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.colStatusTransaksi.Caption = "Status Transaksi"
    Me.colStatusTransaksi.FieldName = "Main.StatusTransaksi"
    Me.colStatusTransaksi.Name = "colStatusTransaksi"
    Me.colStatusTransaksi.Visible = True
    Me.colStatusTransaksi.VisibleIndex = 11
    Me.colStatusTransaksi.Width = 110
    '
    'xGridViewProduksi
    '
    Me.xGridViewProduksi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProdKode})
    Me.xGridViewProduksi.GridControl = Me.xGrid
    Me.xGridViewProduksi.Name = "xGridViewProduksi"
    Me.xGridViewProduksi.OptionsBehavior.Editable = False
    Me.xGridViewProduksi.OptionsDetail.EnableMasterViewMode = False
    Me.xGridViewProduksi.OptionsView.ShowGroupPanel = False
    Me.xGridViewProduksi.ViewCaption = "Produksi"
    '
    'colProdKode
    '
    Me.colProdKode.Caption = "No. Produksi"
    Me.colProdKode.FieldName = "Kode"
    Me.colProdKode.Name = "colProdKode"
    Me.colProdKode.Visible = True
    Me.colProdKode.VisibleIndex = 0
    '
    'GridView1
    '
    Me.GridView1.GridControl = Me.xGrid
    Me.GridView1.Name = "GridView1"
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.btnExport)
    Me.LayoutControl1.Controls.Add(Me.btnTampilkan)
    Me.LayoutControl1.Controls.Add(Me.txtFTanggalAkhir)
    Me.LayoutControl1.Controls.Add(Me.txtFTanggalAwal)
    Me.LayoutControl1.Controls.Add(Me.xGrid)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(378, 388, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(904, 420)
    Me.LayoutControl1.TabIndex = 0
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'btnExport
    '
    Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
    Me.btnExport.Location = New System.Drawing.Point(604, 43)
    Me.btnExport.Name = "btnExport"
    Me.btnExport.Size = New System.Drawing.Size(116, 22)
    Me.btnExport.StyleController = Me.LayoutControl1
    Me.btnExport.TabIndex = 9
    Me.btnExport.Text = "Export Excell"
    '
    'btnTampilkan
    '
    Me.btnTampilkan.Image = CType(resources.GetObject("btnTampilkan.Image"), System.Drawing.Image)
    Me.btnTampilkan.Location = New System.Drawing.Point(484, 43)
    Me.btnTampilkan.Name = "btnTampilkan"
    Me.btnTampilkan.Size = New System.Drawing.Size(116, 22)
    Me.btnTampilkan.StyleController = Me.LayoutControl1
    Me.btnTampilkan.TabIndex = 8
    Me.btnTampilkan.Text = "Tampilkan Data"
    '
    'txtFTanggalAkhir
    '
    Me.txtFTanggalAkhir.EditValue = Nothing
    Me.txtFTanggalAkhir.Location = New System.Drawing.Point(285, 43)
    Me.txtFTanggalAkhir.Name = "txtFTanggalAkhir"
    Me.txtFTanggalAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtFTanggalAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtFTanggalAkhir.Size = New System.Drawing.Size(185, 20)
    Me.txtFTanggalAkhir.StyleController = Me.LayoutControl1
    Me.txtFTanggalAkhir.TabIndex = 6
    '
    'txtFTanggalAwal
    '
    Me.txtFTanggalAwal.EditValue = Nothing
    Me.txtFTanggalAwal.Location = New System.Drawing.Point(77, 43)
    Me.txtFTanggalAwal.Name = "txtFTanggalAwal"
    Me.txtFTanggalAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtFTanggalAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtFTanggalAwal.Size = New System.Drawing.Size(168, 20)
    Me.txtFTanggalAwal.StyleController = Me.LayoutControl1
    Me.txtFTanggalAwal.TabIndex = 5
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(904, 420)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.xGrid
    Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 69)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(884, 331)
    Me.LayoutControlItem1.Text = "LayoutControlItem1"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextToControlDistance = 0
    Me.LayoutControlItem1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
    Me.LayoutControlGroup2.CustomizationFormText = "Filter Data Dempyou"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(884, 69)
    Me.LayoutControlGroup2.Text = "Filter Data"
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtFTanggalAwal
    Me.LayoutControlItem2.CustomizationFormText = "Tgl Awal"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem2.MinSize = New System.Drawing.Size(104, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(225, 26)
    Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem2.Text = "Tanggal    "
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtFTanggalAkhir
    Me.LayoutControlItem3.CustomizationFormText = "sd"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(225, 0)
    Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem3.MinSize = New System.Drawing.Size(90, 24)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 2, 2)
    Me.LayoutControlItem3.Size = New System.Drawing.Size(225, 26)
    Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem3.Text = "   s/d   "
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(33, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.btnTampilkan
    Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(460, 0)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(120, 26)
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.btnExport
    Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(580, 0)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(120, 26)
    Me.LayoutControlItem6.Text = "LayoutControlItem6"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem6.TextToControlDistance = 0
    Me.LayoutControlItem6.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(700, 0)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(160, 26)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(450, 0)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 26)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'colBahanJadi
    '
    Me.colBahanJadi.Caption = "Bahan Jadi"
    Me.colBahanJadi.FieldName = "Main.OrderProduksi.SODetail.Barang.Nama"
    Me.colBahanJadi.Name = "colBahanJadi"
    '
    'UI_FusohBreakdownWIP
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(904, 420)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "UI_FusohBreakdownWIP"
    Me.Text = "Breakdown WIP"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridViewDetail, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridViewProduksi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtFTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents txtFTanggalAkhir As DevExpress.XtraEditors.DateEdit
	Friend WithEvents txtFTanggalAwal As DevExpress.XtraEditors.DateEdit
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents btnTampilkan As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNoTransaksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOut As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorDempyou As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xGridViewDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetBarangKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetNamaPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xGridViewProduksi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProdKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBarangKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartDesc As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBahanJadi As DevExpress.XtraGrid.Columns.GridColumn
End Class
