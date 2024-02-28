<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_AktivaTetapHistory
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_AktivaTetapHistory))
		Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.txtQty = New DevExpress.XtraEditors.TextEdit()
		Me.txtNilaiBuku = New DevExpress.XtraEditors.TextEdit()
		Me.txtAkumulasiDepr = New DevExpress.XtraEditors.TextEdit()
		Me.txtNilaiResidu = New DevExpress.XtraEditors.TextEdit()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNilaiMasuk = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNilaiKeluar = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaMasuk = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaKeluar = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtNama = New DevExpress.XtraEditors.TextEdit()
		Me.txtUmur = New DevExpress.XtraEditors.TextEdit()
		Me.txtHargaBeli = New DevExpress.XtraEditors.TextEdit()
		Me.txtKode = New DevExpress.XtraEditors.TextEdit()
		Me.txtTglBeli = New DevExpress.XtraEditors.DateEdit()
		Me.txtKelompok = New DevExpress.XtraEditors.TextEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.btnResetNilai = New DevExpress.XtraBars.BarButtonItem()
		Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytTransaksi.SuspendLayout()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNilaiBuku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAkumulasiDepr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNilaiResidu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUmur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtHargaBeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTglBeli.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTglBeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKelompok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnResetNilai, Me.btnExport})
		Me.barMan.MaxItemId = 8
		'
		'barMenu
		'
		Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnResetNilai, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'lytTransaksi
		'
		Me.lytTransaksi.Controls.Add(Me.LabelControl1)
		Me.lytTransaksi.Controls.Add(Me.txtQty)
		Me.lytTransaksi.Controls.Add(Me.txtNilaiBuku)
		Me.lytTransaksi.Controls.Add(Me.txtAkumulasiDepr)
		Me.lytTransaksi.Controls.Add(Me.txtNilaiResidu)
		Me.lytTransaksi.Controls.Add(Me.xGrid)
		Me.lytTransaksi.Controls.Add(Me.txtNama)
		Me.lytTransaksi.Controls.Add(Me.txtUmur)
		Me.lytTransaksi.Controls.Add(Me.txtHargaBeli)
		Me.lytTransaksi.Controls.Add(Me.txtKode)
		Me.lytTransaksi.Controls.Add(Me.txtTglBeli)
		Me.lytTransaksi.Controls.Add(Me.txtKelompok)
		Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksi.Name = "lytTransaksi"
		Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(407, 355, 250, 350)
		Me.lytTransaksi.Root = Me.LayoutControlGroup1
		Me.lytTransaksi.Size = New System.Drawing.Size(843, 406)
		Me.lytTransaksi.TabIndex = 4
		Me.lytTransaksi.Text = "lytTransaksi"
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(627, 87)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
		Me.LabelControl1.StyleController = Me.lytTransaksi
		Me.LabelControl1.TabIndex = 15
		Me.LabelControl1.Text = "Bulan"
		'
		'txtQty
		'
		Me.txtQty.Location = New System.Drawing.Point(572, 111)
		Me.txtQty.MenuManager = Me.barMan
		Me.txtQty.Name = "txtQty"
		Me.txtQty.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtQty.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtQty.Properties.ReadOnly = True
		Me.txtQty.Size = New System.Drawing.Size(251, 20)
		Me.txtQty.StyleController = Me.lytTransaksi
		Me.txtQty.TabIndex = 14
		'
		'txtNilaiBuku
		'
		Me.txtNilaiBuku.Location = New System.Drawing.Point(572, 159)
		Me.txtNilaiBuku.MenuManager = Me.barMan
		Me.txtNilaiBuku.Name = "txtNilaiBuku"
		Me.txtNilaiBuku.Properties.Appearance.Options.UseTextOptions = True
		Me.txtNilaiBuku.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtNilaiBuku.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtNilaiBuku.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtNilaiBuku.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtNilaiBuku.Properties.ReadOnly = True
		Me.txtNilaiBuku.Size = New System.Drawing.Size(251, 20)
		Me.txtNilaiBuku.StyleController = Me.lytTransaksi
		Me.txtNilaiBuku.TabIndex = 13
		'
		'txtAkumulasiDepr
		'
		Me.txtAkumulasiDepr.Location = New System.Drawing.Point(169, 159)
		Me.txtAkumulasiDepr.MenuManager = Me.barMan
		Me.txtAkumulasiDepr.Name = "txtAkumulasiDepr"
		Me.txtAkumulasiDepr.Properties.Appearance.Options.UseTextOptions = True
		Me.txtAkumulasiDepr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtAkumulasiDepr.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtAkumulasiDepr.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtAkumulasiDepr.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtAkumulasiDepr.Properties.ReadOnly = True
		Me.txtAkumulasiDepr.Size = New System.Drawing.Size(250, 20)
		Me.txtAkumulasiDepr.StyleController = Me.lytTransaksi
		Me.txtAkumulasiDepr.TabIndex = 12
		'
		'txtNilaiResidu
		'
		Me.txtNilaiResidu.Location = New System.Drawing.Point(572, 135)
		Me.txtNilaiResidu.MenuManager = Me.barMan
		Me.txtNilaiResidu.Name = "txtNilaiResidu"
		Me.txtNilaiResidu.Properties.Appearance.Options.UseTextOptions = True
		Me.txtNilaiResidu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtNilaiResidu.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtNilaiResidu.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtNilaiResidu.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtNilaiResidu.Properties.ReadOnly = True
		Me.txtNilaiResidu.Size = New System.Drawing.Size(251, 20)
		Me.txtNilaiResidu.StyleController = Me.lytTransaksi
		Me.txtNilaiResidu.TabIndex = 11
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(17, 212)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.MenuManager = Me.barMan
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(809, 177)
		Me.xGrid.TabIndex = 10
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colTanggal, Me.colUraian, Me.colQty, Me.colNilaiMasuk, Me.colNilaiKeluar, Me.colHargaMasuk, Me.colHargaKeluar, Me.colTipe})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTanggal, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'colKode
		'
		Me.colKode.Caption = "No Bukti"
		Me.colKode.FieldName = "Main.Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.OptionsColumn.AllowEdit = False
		Me.colKode.OptionsColumn.ReadOnly = True
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 0
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.OptionsColumn.AllowEdit = False
		Me.colTanggal.OptionsColumn.ReadOnly = True
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		'
		'colUraian
		'
		Me.colUraian.Caption = "Keterangan"
		Me.colUraian.FieldName = "Keterangan"
		Me.colUraian.Name = "colUraian"
		Me.colUraian.OptionsColumn.AllowEdit = False
		Me.colUraian.OptionsColumn.ReadOnly = True
		'
		'colQty
		'
		Me.colQty.Caption = "Qty"
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.OptionsColumn.AllowEdit = False
		Me.colQty.OptionsColumn.ReadOnly = True
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 3
		'
		'colNilaiMasuk
		'
		Me.colNilaiMasuk.Caption = "Total Masuk"
		Me.colNilaiMasuk.FieldName = "TotalMasuk"
		Me.colNilaiMasuk.Name = "colNilaiMasuk"
		Me.colNilaiMasuk.OptionsColumn.AllowEdit = False
		Me.colNilaiMasuk.OptionsColumn.ReadOnly = True
		Me.colNilaiMasuk.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colNilaiMasuk.Visible = True
		Me.colNilaiMasuk.VisibleIndex = 6
		'
		'colNilaiKeluar
		'
		Me.colNilaiKeluar.Caption = "Total Keluar"
		Me.colNilaiKeluar.FieldName = "TotalKeluar"
		Me.colNilaiKeluar.Name = "colNilaiKeluar"
		Me.colNilaiKeluar.OptionsColumn.AllowEdit = False
		Me.colNilaiKeluar.OptionsColumn.ReadOnly = True
		Me.colNilaiKeluar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colNilaiKeluar.Visible = True
		Me.colNilaiKeluar.VisibleIndex = 7
		'
		'colHargaMasuk
		'
		Me.colHargaMasuk.Caption = "Nilai Masuk"
		Me.colHargaMasuk.FieldName = "NilaiMasuk"
		Me.colHargaMasuk.Name = "colHargaMasuk"
		Me.colHargaMasuk.Visible = True
		Me.colHargaMasuk.VisibleIndex = 4
		'
		'colHargaKeluar
		'
		Me.colHargaKeluar.Caption = "Nilai Keluar"
		Me.colHargaKeluar.FieldName = "NilaiKeluar"
		Me.colHargaKeluar.Name = "colHargaKeluar"
		Me.colHargaKeluar.Visible = True
		Me.colHargaKeluar.VisibleIndex = 5
		'
		'colTipe
		'
		Me.colTipe.Caption = "Tipe"
		Me.colTipe.FieldName = "Main.Tipe"
		Me.colTipe.Name = "colTipe"
		Me.colTipe.Visible = True
		Me.colTipe.VisibleIndex = 2
		'
		'txtNama
		'
		Me.txtNama.Location = New System.Drawing.Point(169, 63)
		Me.txtNama.MenuManager = Me.barMan
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtNama.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtNama.Properties.ReadOnly = True
		Me.txtNama.Size = New System.Drawing.Size(654, 20)
		Me.txtNama.StyleController = Me.lytTransaksi
		Me.txtNama.TabIndex = 9
		'
		'txtUmur
		'
		Me.txtUmur.Location = New System.Drawing.Point(572, 87)
		Me.txtUmur.MenuManager = Me.barMan
		Me.txtUmur.Name = "txtUmur"
		Me.txtUmur.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtUmur.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtUmur.Properties.ReadOnly = True
		Me.txtUmur.Size = New System.Drawing.Size(51, 20)
		Me.txtUmur.StyleController = Me.lytTransaksi
		Me.txtUmur.TabIndex = 7
		'
		'txtHargaBeli
		'
		Me.txtHargaBeli.Location = New System.Drawing.Point(169, 135)
		Me.txtHargaBeli.MenuManager = Me.barMan
		Me.txtHargaBeli.Name = "txtHargaBeli"
		Me.txtHargaBeli.Properties.Appearance.Options.UseTextOptions = True
		Me.txtHargaBeli.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtHargaBeli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtHargaBeli.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtHargaBeli.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtHargaBeli.Properties.ReadOnly = True
		Me.txtHargaBeli.Size = New System.Drawing.Size(250, 20)
		Me.txtHargaBeli.StyleController = Me.lytTransaksi
		Me.txtHargaBeli.TabIndex = 6
		'
		'txtKode
		'
		Me.txtKode.Location = New System.Drawing.Point(169, 39)
		Me.txtKode.MenuManager = Me.barMan
		Me.txtKode.Name = "txtKode"
		Me.txtKode.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtKode.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtKode.Properties.ReadOnly = True
		Me.txtKode.Size = New System.Drawing.Size(654, 20)
		Me.txtKode.StyleController = Me.lytTransaksi
		Me.txtKode.TabIndex = 5
		'
		'txtTglBeli
		'
		Me.txtTglBeli.EditValue = Nothing
		Me.txtTglBeli.Location = New System.Drawing.Point(169, 111)
		Me.txtTglBeli.MenuManager = Me.barMan
		Me.txtTglBeli.Name = "txtTglBeli"
		Me.txtTglBeli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtTglBeli.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtTglBeli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTglBeli.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTglBeli.Properties.DisplayFormat.FormatString = "D"
		Me.txtTglBeli.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTglBeli.Properties.Mask.EditMask = ""
		Me.txtTglBeli.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.txtTglBeli.Properties.ReadOnly = True
		Me.txtTglBeli.Size = New System.Drawing.Size(250, 20)
		Me.txtTglBeli.StyleController = Me.lytTransaksi
		Me.txtTglBeli.TabIndex = 4
		'
		'txtKelompok
		'
		Me.txtKelompok.Location = New System.Drawing.Point(169, 87)
		Me.txtKelompok.MenuManager = Me.barMan
		Me.txtKelompok.Name = "txtKelompok"
		Me.txtKelompok.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtKelompok.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtKelompok.Properties.ReadOnly = True
		Me.txtKelompok.Size = New System.Drawing.Size(250, 20)
		Me.txtKelompok.StyleController = Me.lytTransaksi
		Me.txtKelompok.TabIndex = 8
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlGroup2})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(843, 406)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.xGrid
		Me.LayoutControlItem7.CustomizationFormText = "History Transaksi Aktiva Tetap"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 179)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 7)
		Me.LayoutControlItem7.Size = New System.Drawing.Size(823, 207)
		Me.LayoutControlItem7.Text = "History Transaksi Aktiva Tetap"
		Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlGroup2
		'
		Me.LayoutControlGroup2.CustomizationFormText = "Info Aktiva Tetap"
		Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12})
		Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
		Me.LayoutControlGroup2.Size = New System.Drawing.Size(823, 179)
		Me.LayoutControlGroup2.Text = "Info Aktiva Tetap"
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtHargaBeli
		Me.LayoutControlItem3.CustomizationFormText = "Harga Beli"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 96)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(403, 24)
		Me.LayoutControlItem3.Text = "Harga Beli"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtNama
		Me.LayoutControlItem6.CustomizationFormText = "Nama Aktiva"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(807, 24)
		Me.LayoutControlItem6.Text = "Nama Aktiva"
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtKode
		Me.LayoutControlItem2.CustomizationFormText = "Kode Aktiva"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(807, 24)
		Me.LayoutControlItem2.Text = "Kode Aktiva"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtKelompok
		Me.LayoutControlItem5.CustomizationFormText = "Kelompok Aktiva"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(403, 24)
		Me.LayoutControlItem5.Text = "Kelompok Aktiva"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtTglBeli
		Me.LayoutControlItem1.CustomizationFormText = "Tanggal Beli"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(403, 24)
		Me.LayoutControlItem1.Text = "Tanggal Beli"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtUmur
		Me.LayoutControlItem4.CustomizationFormText = "Bulan"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(403, 48)
		Me.LayoutControlItem4.MinSize = New System.Drawing.Size(204, 24)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(204, 24)
		Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.LayoutControlItem4.Text = "Umur"
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(146, 13)
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "Bulan"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(637, 48)
		Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(104, 24)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(170, 24)
		Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.EmptySpaceItem1.Text = "Bulan"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.txtNilaiResidu
		Me.LayoutControlItem8.CustomizationFormText = "Nilai Residu"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(403, 96)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(404, 24)
		Me.LayoutControlItem8.Text = "Nilai Residu"
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtAkumulasiDepr
		Me.LayoutControlItem9.CustomizationFormText = "Akumulasi Depresiasi"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 120)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(403, 24)
		Me.LayoutControlItem9.Text = "Akumulasi Depresiasi"
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem10
		'
		Me.LayoutControlItem10.Control = Me.txtNilaiBuku
		Me.LayoutControlItem10.CustomizationFormText = "Nilai Buku"
		Me.LayoutControlItem10.Location = New System.Drawing.Point(403, 120)
		Me.LayoutControlItem10.Name = "LayoutControlItem10"
		Me.LayoutControlItem10.Size = New System.Drawing.Size(404, 24)
		Me.LayoutControlItem10.Text = "Nilai Buku"
		Me.LayoutControlItem10.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem11
		'
		Me.LayoutControlItem11.Control = Me.txtQty
		Me.LayoutControlItem11.CustomizationFormText = "Qty"
		Me.LayoutControlItem11.Location = New System.Drawing.Point(403, 72)
		Me.LayoutControlItem11.Name = "LayoutControlItem11"
		Me.LayoutControlItem11.Size = New System.Drawing.Size(404, 24)
		Me.LayoutControlItem11.Text = "Qty"
		Me.LayoutControlItem11.TextSize = New System.Drawing.Size(146, 13)
		'
		'LayoutControlItem12
		'
		Me.LayoutControlItem12.Control = Me.LabelControl1
		Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
		Me.LayoutControlItem12.Location = New System.Drawing.Point(607, 48)
		Me.LayoutControlItem12.Name = "LayoutControlItem12"
		Me.LayoutControlItem12.Size = New System.Drawing.Size(30, 24)
		Me.LayoutControlItem12.Text = "LayoutControlItem12"
		Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem12.TextToControlDistance = 0
		Me.LayoutControlItem12.TextVisible = False
		'
		'btnResetNilai
		'
		Me.btnResetNilai.Caption = "Reset Nilai"
		Me.btnResetNilai.Glyph = CType(resources.GetObject("btnResetNilai.Glyph"), System.Drawing.Image)
		Me.btnResetNilai.Id = 6
		Me.btnResetNilai.LargeGlyph = CType(resources.GetObject("btnResetNilai.LargeGlyph"), System.Drawing.Image)
		Me.btnResetNilai.Name = "btnResetNilai"
		'
		'btnExport
		'
		Me.btnExport.Caption = "Export"
		Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
		Me.btnExport.Id = 7
		Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
		Me.btnExport.Name = "btnExport"
		'
		'UI_AktivaTetapHistory
		'
		Me.AllowMdiBar = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(843, 433)
		Me.Controls.Add(Me.lytTransaksi)
		Me.Name = "UI_AktivaTetapHistory"
		Me.Text = "UI_AktivaTetapHistory"
		Me.Controls.SetChildIndex(Me.lytTransaksi, 0)
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytTransaksi.ResumeLayout(False)
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNilaiBuku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAkumulasiDepr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNilaiResidu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUmur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtHargaBeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTglBeli.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTglBeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKelompok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lytTransaksi As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtUmur As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtHargaBeli As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtNilaiResidu As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNilaiBuku As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtAkumulasiDepr As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTglBeli As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKelompok As DevExpress.XtraEditors.TextEdit
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiMasuk As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiKeluar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaMasuk As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaKeluar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnResetNilai As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
End Class
