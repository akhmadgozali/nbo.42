<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_PinjamanDialog
  Inherits NuSoft.Core.Win.Forms.InputDialog

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_PinjamanDialog))
    Me.txtKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.lytLa = New DevExpress.XtraLayout.LayoutControl()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTempo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPokok = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBiaya = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSisa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCicilan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnProses = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.txtBiaya = New DevExpress.XtraEditors.TextEdit()
    Me.txtRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtTermin = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiHutang = New DevExpress.XtraEditors.TextEdit()
    Me.txtMataUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.txtKontak = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegionalNama = New DevExpress.XtraEditors.LabelControl()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtTanggalAwal = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytLa, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytLa.SuspendLayout()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBiaya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtKontakNama
    '
    Me.txtKontakNama.Appearance.ForeColor = System.Drawing.Color.Black
    Me.txtKontakNama.Location = New System.Drawing.Point(189, 37)
    Me.txtKontakNama.Name = "txtKontakNama"
    Me.txtKontakNama.Size = New System.Drawing.Size(148, 20)
    Me.txtKontakNama.StyleController = Me.lytLa
    Me.txtKontakNama.TabIndex = 7
    '
    'lytLa
    '
    Me.lytLa.Controls.Add(Me.xGrid)
    Me.lytLa.Controls.Add(Me.btnProses)
    Me.lytLa.Controls.Add(Me.txtKontakNama)
    Me.lytLa.Controls.Add(Me.txtNoTransaksi)
    Me.lytLa.Controls.Add(Me.txtBiaya)
    Me.lytLa.Controls.Add(Me.txtRefreshNomor)
    Me.lytLa.Controls.Add(Me.txtTermin)
    Me.lytLa.Controls.Add(Me.txtNilaiHutang)
    Me.lytLa.Controls.Add(Me.txtMataUang)
    Me.lytLa.Controls.Add(Me.txtTanggal)
    Me.lytLa.Controls.Add(Me.txtKontak)
    Me.lytLa.Controls.Add(Me.txtRegionalNama)
    Me.lytLa.Controls.Add(Me.txtRegional)
    Me.lytLa.Controls.Add(Me.txtUraian)
    Me.lytLa.Controls.Add(Me.txtTanggalAwal)
    Me.lytLa.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytLa.Location = New System.Drawing.Point(0, 0)
    Me.lytLa.Name = "lytLa"
    Me.lytLa.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(590, 355, 250, 350)
    Me.lytLa.Root = Me.LayoutControlGroup1
    Me.lytLa.Size = New System.Drawing.Size(776, 432)
    Me.lytLa.TabIndex = 101
    Me.lytLa.Text = "LayoutControl1"
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 180)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(752, 240)
    Me.xGrid.TabIndex = 9
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNo, Me.colTempo, Me.colPokok, Me.colBiaya, Me.colSisa, Me.colCicilan, Me.colCatatan})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colNo
    '
    Me.colNo.AppearanceHeader.Options.UseTextOptions = True
    Me.colNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colNo.Caption = "No"
    Me.colNo.FieldName = "Urutan"
    Me.colNo.Name = "colNo"
    Me.colNo.OptionsColumn.AllowEdit = False
    Me.colNo.OptionsColumn.ReadOnly = True
    Me.colNo.Visible = True
    Me.colNo.VisibleIndex = 0
    Me.colNo.Width = 30
    '
    'colTempo
    '
    Me.colTempo.AppearanceHeader.Options.UseTextOptions = True
    Me.colTempo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colTempo.Caption = "Tanggal Tempo"
    Me.colTempo.DisplayFormat.FormatString = "D"
    Me.colTempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTempo.FieldName = "JatuhTempo"
    Me.colTempo.Name = "colTempo"
    Me.colTempo.OptionsColumn.AllowEdit = False
    Me.colTempo.OptionsColumn.ReadOnly = True
    Me.colTempo.Visible = True
    Me.colTempo.VisibleIndex = 1
    Me.colTempo.Width = 128
    '
    'colPokok
    '
    Me.colPokok.AppearanceHeader.Options.UseTextOptions = True
    Me.colPokok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colPokok.Caption = "Nilai Pokok"
    Me.colPokok.FieldName = "Pokok"
    Me.colPokok.Name = "colPokok"
    Me.colPokok.OptionsColumn.AllowEdit = False
    Me.colPokok.OptionsColumn.ReadOnly = True
    Me.colPokok.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colPokok.Visible = True
    Me.colPokok.VisibleIndex = 2
    Me.colPokok.Width = 118
    '
    'colBiaya
    '
    Me.colBiaya.AppearanceHeader.Options.UseTextOptions = True
    Me.colBiaya.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colBiaya.Caption = "Biaya"
    Me.colBiaya.FieldName = "Biaya"
    Me.colBiaya.Name = "colBiaya"
    Me.colBiaya.OptionsColumn.AllowEdit = False
    Me.colBiaya.OptionsColumn.ReadOnly = True
    Me.colBiaya.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colBiaya.Visible = True
    Me.colBiaya.VisibleIndex = 3
    Me.colBiaya.Width = 108
    '
    'colSisa
    '
    Me.colSisa.AppearanceHeader.Options.UseTextOptions = True
    Me.colSisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colSisa.Caption = "Sisa"
    Me.colSisa.FieldName = "Sisa"
    Me.colSisa.Name = "colSisa"
    Me.colSisa.OptionsColumn.AllowEdit = False
    Me.colSisa.OptionsColumn.ReadOnly = True
    Me.colSisa.Visible = True
    Me.colSisa.VisibleIndex = 5
    Me.colSisa.Width = 118
    '
    'colCicilan
    '
    Me.colCicilan.AppearanceHeader.Options.UseTextOptions = True
    Me.colCicilan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colCicilan.Caption = "Jml. Cicilan"
    Me.colCicilan.FieldName = "colCicilan"
    Me.colCicilan.Name = "colCicilan"
    Me.colCicilan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colCicilan.UnboundExpression = "[Pokok] + [Biaya]"
    Me.colCicilan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.colCicilan.Visible = True
    Me.colCicilan.VisibleIndex = 4
    Me.colCicilan.Width = 118
    '
    'colCatatan
    '
    Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
    Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colCatatan.Caption = "Catatan"
    Me.colCatatan.FieldName = "Keterangan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 6
    Me.colCatatan.Width = 112
    '
    'btnProses
    '
    Me.btnProses.Location = New System.Drawing.Point(597, 154)
    Me.btnProses.Name = "btnProses"
    Me.btnProses.Size = New System.Drawing.Size(167, 22)
    Me.btnProses.StyleController = Me.lytLa
    Me.btnProses.TabIndex = 8
    Me.btnProses.Text = "Proses Perhitungan"
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(608, 37)
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Size = New System.Drawing.Size(120, 20)
    Me.txtNoTransaksi.StyleController = Me.lytLa
    Me.txtNoTransaksi.TabIndex = 2
    '
    'txtBiaya
    '
    Me.txtBiaya.Location = New System.Drawing.Point(70, 154)
    Me.txtBiaya.Name = "txtBiaya"
    Me.txtBiaya.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtBiaya.Properties.Mask.EditMask = "P2"
    Me.txtBiaya.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtBiaya.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtBiaya.Size = New System.Drawing.Size(59, 20)
    Me.txtBiaya.StyleController = Me.lytLa
    Me.txtBiaya.TabIndex = 7
    '
    'txtRefreshNomor
    '
    Me.txtRefreshNomor.Image = CType(resources.GetObject("txtRefreshNomor.Image"), System.Drawing.Image)
    Me.txtRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.txtRefreshNomor.Location = New System.Drawing.Point(732, 37)
    Me.txtRefreshNomor.Name = "txtRefreshNomor"
    Me.txtRefreshNomor.Size = New System.Drawing.Size(26, 22)
    Me.txtRefreshNomor.StyleController = Me.lytLa
    Me.txtRefreshNomor.TabIndex = 3
    '
    'txtTermin
    '
    Me.txtTermin.Location = New System.Drawing.Point(462, 106)
    Me.txtTermin.Name = "txtTermin"
    Me.txtTermin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTermin.Properties.Mask.EditMask = "n0"
    Me.txtTermin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtTermin.Size = New System.Drawing.Size(120, 20)
    Me.txtTermin.StyleController = Me.lytLa
    Me.txtTermin.TabIndex = 6
    '
    'txtNilaiHutang
    '
    Me.txtNilaiHutang.Location = New System.Drawing.Point(70, 130)
    Me.txtNilaiHutang.Name = "txtNilaiHutang"
    Me.txtNilaiHutang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNilaiHutang.Size = New System.Drawing.Size(129, 20)
    Me.txtNilaiHutang.StyleController = Me.lytLa
    Me.txtNilaiHutang.TabIndex = 5
    '
    'txtMataUang
    '
    Me.txtMataUang.Location = New System.Drawing.Point(70, 106)
    Me.txtMataUang.Name = "txtMataUang"
    Me.txtMataUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtMataUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtMataUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode")})
    Me.txtMataUang.Properties.DisplayMember = "Kode"
    Me.txtMataUang.Properties.NullText = "<Pilih Mata Uang>"
    Me.txtMataUang.Properties.ShowHeader = False
    Me.txtMataUang.Properties.ValueMember = "This"
    Me.txtMataUang.Size = New System.Drawing.Size(129, 20)
    Me.txtMataUang.StyleController = Me.lytLa
    Me.txtMataUang.TabIndex = 3
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(422, 37)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(120, 20)
    Me.txtTanggal.StyleController = Me.lytLa
    Me.txtTanggal.TabIndex = 1
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(65, 37)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Kontak>"
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Size = New System.Drawing.Size(120, 20)
    Me.txtKontak.StyleController = Me.lytLa
    Me.txtKontak.TabIndex = 0
    '
    'txtRegionalNama
    '
    Me.txtRegionalNama.Location = New System.Drawing.Point(546, 61)
    Me.txtRegionalNama.Name = "txtRegionalNama"
    Me.txtRegionalNama.Size = New System.Drawing.Size(182, 20)
    Me.txtRegionalNama.StyleController = Me.lytLa
    Me.txtRegionalNama.TabIndex = 14
    Me.txtRegionalNama.Text = "Regional"
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(422, 61)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Kode"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(120, 20)
    Me.txtRegional.StyleController = Me.lytLa
    Me.txtRegional.TabIndex = 1
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(287, 130)
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Size = New System.Drawing.Size(477, 20)
    Me.txtUraian.StyleController = Me.lytLa
    Me.txtUraian.TabIndex = 2
    '
    'txtTanggalAwal
    '
    Me.txtTanggalAwal.EditValue = Nothing
    Me.txtTanggalAwal.Location = New System.Drawing.Point(287, 106)
    Me.txtTanggalAwal.Name = "txtTanggalAwal"
    Me.txtTanggalAwal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggalAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggalAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggalAwal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggalAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggalAwal.Size = New System.Drawing.Size(120, 20)
    Me.txtTanggalAwal.StyleController = Me.lytLa
    Me.txtTanggalAwal.TabIndex = 4
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlGroup2, Me.LayoutControlItem6, Me.EmptySpaceItem3, Me.LayoutControlItem12, Me.LayoutControlItem11, Me.LayoutControlItem9, Me.LayoutControlItem8, Me.EmptySpaceItem4, Me.LayoutControlItem13, Me.SimpleLabelItem1, Me.LayoutControlItem14})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(776, 432)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.xGrid
    Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 168)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(756, 244)
    Me.LayoutControlItem15.Text = "LayoutControlItem15"
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem15.TextToControlDistance = 0
    Me.LayoutControlItem15.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem10, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(756, 94)
    Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
    Me.LayoutControlGroup2.Text = "Info Utama"
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtKontak
    Me.LayoutControlItem2.CustomizationFormText = "Bayar ke"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(171, 48)
    Me.LayoutControlItem2.Text = "Bayar ke"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(42, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtTanggal
    Me.LayoutControlItem3.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(358, 0)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(170, 24)
    Me.LayoutControlItem3.Text = "Tanggal"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(41, 20)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKontakNama
    Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(171, 0)
    Me.LayoutControlItem5.MinSize = New System.Drawing.Size(42, 17)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(152, 24)
    Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtNoTransaksi
    Me.LayoutControlItem1.CustomizationFormText = "No. Kontrak"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(528, 0)
    Me.LayoutControlItem1.MinSize = New System.Drawing.Size(116, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(186, 24)
    Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem1.Text = "No. Kontrak"
    Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(57, 13)
    Me.LayoutControlItem1.TextToControlDistance = 5
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtRefreshNomor
    Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(714, 0)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(30, 48)
    Me.LayoutControlItem4.Text = "LayoutControlItem4"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem4.TextToControlDistance = 0
    Me.LayoutControlItem4.TextVisible = False
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtRegional
    Me.LayoutControlItem7.CustomizationFormText = "Regional"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(358, 24)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(170, 24)
    Me.LayoutControlItem7.Text = "Regional"
    Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(41, 13)
    Me.LayoutControlItem7.TextToControlDistance = 5
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtRegionalNama
    Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(528, 24)
    Me.LayoutControlItem10.MinSize = New System.Drawing.Size(45, 17)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(186, 24)
    Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem10.Text = "LayoutControlItem10"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem10.TextToControlDistance = 0
    Me.LayoutControlItem10.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(323, 0)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(35, 48)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(171, 24)
    Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(152, 0)
    Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(152, 10)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(152, 24)
    Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtNilaiHutang
    Me.LayoutControlItem6.CustomizationFormText = "Nilai Hitung"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 118)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(191, 24)
    Me.LayoutControlItem6.Text = "Nilai Hitung"
    Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(53, 13)
    Me.LayoutControlItem6.TextToControlDistance = 5
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(574, 94)
    Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(104, 24)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(182, 24)
    Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtTermin
    Me.LayoutControlItem12.CustomizationFormText = "Termin"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(399, 94)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(175, 24)
    Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem12.Text = "Termin"
    Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(31, 13)
    Me.LayoutControlItem12.TextToControlDistance = 5
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtMataUang
    Me.LayoutControlItem11.CustomizationFormText = "Mata Uang"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 94)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(191, 24)
    Me.LayoutControlItem11.Text = "Mata Uang"
    Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(53, 13)
    Me.LayoutControlItem11.TextToControlDistance = 5
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtTanggalAwal
    Me.LayoutControlItem9.CustomizationFormText = "Tanggal Awal"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(191, 94)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(208, 24)
    Me.LayoutControlItem9.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem9.Text = "Tanggal Awal"
    Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(64, 13)
    Me.LayoutControlItem9.TextToControlDistance = 5
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtUraian
    Me.LayoutControlItem8.CustomizationFormText = "Uraian"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(191, 118)
    Me.LayoutControlItem8.MinSize = New System.Drawing.Size(121, 24)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(565, 24)
    Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem8.Text = "Uraian"
    Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(64, 13)
    Me.LayoutControlItem8.TextToControlDistance = 5
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(191, 142)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(394, 26)
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtBiaya
    Me.LayoutControlItem13.CustomizationFormText = "Bunga"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 142)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(121, 26)
    Me.LayoutControlItem13.Text = "Biaya"
    Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(53, 13)
    Me.LayoutControlItem13.TextToControlDistance = 5
    '
    'SimpleLabelItem1
    '
    Me.SimpleLabelItem1.AllowHotTrack = False
    Me.SimpleLabelItem1.CustomizationFormText = "per bulan"
    Me.SimpleLabelItem1.Location = New System.Drawing.Point(121, 142)
    Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
    Me.SimpleLabelItem1.Size = New System.Drawing.Size(70, 26)
    Me.SimpleLabelItem1.Text = "per bulan"
    Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(45, 13)
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.btnProses
    Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(585, 142)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(171, 26)
    Me.LayoutControlItem14.Text = "LayoutControlItem14"
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem14.TextToControlDistance = 0
    Me.LayoutControlItem14.TextVisible = False
    '
    'UI_PinjamanDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(776, 481)
    Me.Controls.Add(Me.lytLa)
    Me.Name = "UI_PinjamanDialog"
    Me.Text = "UI_PinjamanDialog"
    Me.Controls.SetChildIndex(Me.lytLa, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytLa, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytLa.ResumeLayout(False)
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBiaya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggalAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtKontakNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtRegionalNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents colPokok As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBiaya As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSisa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtMataUang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNilaiHutang As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTermin As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtBiaya As DevExpress.XtraEditors.TextEdit
 Friend WithEvents btnProses As DevExpress.XtraEditors.SimpleButton
 Friend WithEvents colNo As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colTempo As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colCicilan As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents lytLa As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
 Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
 Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
 Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
 Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
