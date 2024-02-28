<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_AktivaTetapSaldoAwal
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_AktivaTetapSaldoAwal))
    Me.lytPembelian = New DevExpress.XtraLayout.LayoutControl()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeAsset = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaAsset = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiMasuk = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.txtRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtRegionalNama = New DevExpress.XtraEditors.LabelControl()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytPembelian.SuspendLayout()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lytPembelian
    '
    Me.lytPembelian.Controls.Add(Me.xGrid)
    Me.lytPembelian.Controls.Add(Me.txtUraian)
    Me.lytPembelian.Controls.Add(Me.txtKontakNama)
    Me.lytPembelian.Controls.Add(Me.txtRefreshNomor)
    Me.lytPembelian.Controls.Add(Me.txtRegionalNama)
    Me.lytPembelian.Controls.Add(Me.txtNoTransaksi)
    Me.lytPembelian.Controls.Add(Me.txtTanggal)
    Me.lytPembelian.Controls.Add(Me.txtKontak)
    Me.lytPembelian.Controls.Add(Me.txtRegional)
    Me.lytPembelian.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytPembelian.Location = New System.Drawing.Point(0, 0)
    Me.lytPembelian.Name = "lytPembelian"
    Me.lytPembelian.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(30, 173, 250, 350)
    Me.lytPembelian.Root = Me.LayoutControlGroup1
    Me.lytPembelian.Size = New System.Drawing.Size(773, 393)
    Me.lytPembelian.TabIndex = 100
    Me.lytPembelian.Text = "LayoutControl1"
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 129)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(749, 252)
    Me.xGrid.TabIndex = 13
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTanggal, Me.colKodeAsset, Me.colNamaAsset, Me.colQty, Me.colNilaiMasuk, Me.colKeterangan})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.OptionsColumn.AllowEdit = False
    Me.colTanggal.OptionsColumn.ReadOnly = True
    '
    'colKodeAsset
    '
    Me.colKodeAsset.Caption = "Kode Asset"
    Me.colKodeAsset.FieldName = "Asset.Kode"
    Me.colKodeAsset.Name = "colKodeAsset"
    Me.colKodeAsset.OptionsColumn.AllowEdit = False
    Me.colKodeAsset.OptionsColumn.ReadOnly = True
    Me.colKodeAsset.Visible = True
    Me.colKodeAsset.VisibleIndex = 0
    Me.colKodeAsset.Width = 139
    '
    'colNamaAsset
    '
    Me.colNamaAsset.Caption = "Nama Asset"
    Me.colNamaAsset.FieldName = "Asset.Nama"
    Me.colNamaAsset.Name = "colNamaAsset"
    Me.colNamaAsset.OptionsColumn.AllowEdit = False
    Me.colNamaAsset.OptionsColumn.ReadOnly = True
    Me.colNamaAsset.Visible = True
    Me.colNamaAsset.VisibleIndex = 1
    Me.colNamaAsset.Width = 228
    '
    'colQty
    '
    Me.colQty.Caption = "Qty"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.OptionsColumn.AllowEdit = False
    Me.colQty.OptionsColumn.ReadOnly = True
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 2
    Me.colQty.Width = 52
    '
    'colNilaiMasuk
    '
    Me.colNilaiMasuk.Caption = "Nilai Beli"
    Me.colNilaiMasuk.FieldName = "NilaiMasuk"
    Me.colNilaiMasuk.Name = "colNilaiMasuk"
    Me.colNilaiMasuk.OptionsColumn.AllowEdit = False
    Me.colNilaiMasuk.OptionsColumn.ReadOnly = True
    Me.colNilaiMasuk.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colNilaiMasuk.Visible = True
    Me.colNilaiMasuk.VisibleIndex = 3
    Me.colNilaiMasuk.Width = 90
    '
    'colKeterangan
    '
    Me.colKeterangan.Caption = "Catatan"
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 4
    Me.colKeterangan.Width = 222
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(56, 105)
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Size = New System.Drawing.Size(705, 20)
    Me.txtUraian.StyleController = Me.lytPembelian
    Me.txtUraian.TabIndex = 12
    '
    'txtKontakNama
    '
    Me.txtKontakNama.Location = New System.Drawing.Point(24, 69)
    Me.txtKontakNama.Name = "txtKontakNama"
    Me.txtKontakNama.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
    Me.txtKontakNama.Size = New System.Drawing.Size(330, 20)
    Me.txtKontakNama.StyleController = Me.lytPembelian
    Me.txtKontakNama.TabIndex = 11
    Me.txtKontakNama.Text = "-"
    '
    'txtRefreshNomor
    '
    Me.txtRefreshNomor.Image = CType(resources.GetObject("txtRefreshNomor.Image"), System.Drawing.Image)
    Me.txtRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.txtRefreshNomor.Location = New System.Drawing.Point(723, 43)
    Me.txtRefreshNomor.Name = "txtRefreshNomor"
    Me.txtRefreshNomor.Size = New System.Drawing.Size(26, 22)
    Me.txtRefreshNomor.StyleController = Me.lytPembelian
    Me.txtRefreshNomor.TabIndex = 10
    '
    'txtRegionalNama
    '
    Me.txtRegionalNama.Location = New System.Drawing.Point(551, 69)
    Me.txtRegionalNama.Name = "txtRegionalNama"
    Me.txtRegionalNama.Size = New System.Drawing.Size(198, 20)
    Me.txtRegionalNama.StyleController = Me.lytPembelian
    Me.txtRegionalNama.TabIndex = 9
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(595, 43)
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Size = New System.Drawing.Size(124, 20)
    Me.txtNoTransaksi.StyleController = Me.lytPembelian
    Me.txtNoTransaksi.TabIndex = 6
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(402, 43)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.Mask.EditMask = ""
    Me.txtTanggal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTanggal.Size = New System.Drawing.Size(145, 20)
    Me.txtTanggal.StyleController = Me.lytPembelian
    Me.txtTanggal.TabIndex = 7
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(68, 43)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = ""
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(172, 20)
    Me.txtKontak.StyleController = Me.lytPembelian
    Me.txtKontak.TabIndex = 4
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
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(402, 69)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Kode"
    Me.txtRegional.Properties.NullText = ""
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(145, 20)
    Me.txtRegional.StyleController = Me.lytPembelian
    Me.txtRegional.TabIndex = 5
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem8, Me.LayoutControlItem9})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(773, 393)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem3, Me.LayoutControlItem5})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(753, 93)
    Me.LayoutControlGroup2.Text = "Info Utama"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKontak
    Me.LayoutControlItem1.CustomizationFormText = "Kontak"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.MinSize = New System.Drawing.Size(127, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(220, 26)
    Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem1.Text = "Kontak"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(41, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtTanggal
    Me.LayoutControlItem4.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(334, 0)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(193, 26)
    Me.LayoutControlItem4.Text = "Tanggal"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(41, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtNoTransaksi
    Me.LayoutControlItem3.CustomizationFormText = "No Bukti"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(527, 0)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(172, 26)
    Me.LayoutControlItem3.Text = "No Bukti"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(41, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtRegional
    Me.LayoutControlItem2.CustomizationFormText = "Regional"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(334, 26)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(193, 24)
    Me.LayoutControlItem2.Text = "Regional"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(41, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtRegionalNama
    Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(527, 26)
    Me.LayoutControlItem6.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(202, 24)
    Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem6.Text = "LayoutControlItem6"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem6.TextToControlDistance = 0
    Me.LayoutControlItem6.TextVisible = False
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtRefreshNomor
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(699, 0)
    Me.LayoutControlItem7.MinSize = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem7.Text = "LayoutControlItem7"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(220, 0)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(114, 26)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKontakNama
    Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 26)
    Me.LayoutControlItem5.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(334, 24)
    Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtUraian
    Me.LayoutControlItem8.CustomizationFormText = "Uraian"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 93)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(753, 24)
    Me.LayoutControlItem8.Text = "Uraian"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(41, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.xGrid
    Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 117)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(753, 256)
    Me.LayoutControlItem9.Text = "LayoutControlItem9"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem9.TextToControlDistance = 0
    Me.LayoutControlItem9.TextVisible = False
    '
    'UI_AktivaTetapSaldoAwal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(773, 442)
    Me.Controls.Add(Me.lytPembelian)
    Me.Name = "UI_AktivaTetapSaldoAwal"
    Me.Text = "Saldo Awal Aktiva Tetap"
    Me.Controls.SetChildIndex(Me.lytPembelian, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPembelian, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytPembelian.ResumeLayout(False)
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lytPembelian As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtRegionalNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtKontakNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeAsset As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaAsset As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiMasuk As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
End Class
