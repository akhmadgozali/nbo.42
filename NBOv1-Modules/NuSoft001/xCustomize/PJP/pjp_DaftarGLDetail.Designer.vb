<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pjp_DaftarGLDetail
  Inherits Core.Win.Forms.BlankForm

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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pjp_DaftarGLDetail))
    Me.lytControl = New DevExpress.XtraLayout.LayoutControl()
    Me.xGridVoucher = New DevExpress.XtraGrid.GridControl()
    Me.xGridVoucherView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vColDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vColKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vColKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vColDebitValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vColKreditValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeCoa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaCoa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebitValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKreditValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.lytControlx = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lyGroupVoucher = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lyGroupData = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.btnTampilkan = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetak = New DevExpress.XtraBars.BarButtonItem()
    Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytControl, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytControl.SuspendLayout()
    CType(Me.xGridVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridVoucherView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytControlx, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lyGroupVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lyGroupData, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lytControl
    '
    Me.lytControl.Controls.Add(Me.xGridVoucher)
    Me.lytControl.Controls.Add(Me.xGrid)
    Me.lytControl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytControl.Location = New System.Drawing.Point(0, 0)
    Me.lytControl.Name = "lytControl"
    Me.lytControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(564, 194, 250, 350)
    Me.lytControl.Root = Me.lytControlx
    Me.lytControl.Size = New System.Drawing.Size(759, 368)
    Me.lytControl.TabIndex = 0
    Me.lytControl.Text = "LayoutControl1"
    '
    'xGridVoucher
    '
    Me.xGridVoucher.Location = New System.Drawing.Point(24, 202)
    Me.xGridVoucher.MainView = Me.xGridVoucherView
    Me.xGridVoucher.Name = "xGridVoucher"
    Me.xGridVoucher.Size = New System.Drawing.Size(711, 142)
    Me.xGridVoucher.TabIndex = 5
    Me.xGridVoucher.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridVoucherView})
    '
    'xGridVoucherView
    '
    Me.xGridVoucherView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.vColDebit, Me.vColKredit, Me.vColKurs, Me.colUang, Me.vColDebitValas, Me.vColKreditValas})
    Me.xGridVoucherView.GridControl = Me.xGridVoucher
    Me.xGridVoucherView.Name = "xGridVoucherView"
    Me.xGridVoucherView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridVoucherView.OptionsView.ColumnAutoWidth = False
    Me.xGridVoucherView.OptionsView.ShowFooter = True
    Me.xGridVoucherView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Coa"
    Me.GridColumn1.FieldName = "Akun.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 66
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama Coa"
    Me.GridColumn2.FieldName = "Akun.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 238
    '
    'vColDebit
    '
    Me.vColDebit.Caption = "Debit"
    Me.vColDebit.FieldName = "Debit"
    Me.vColDebit.Name = "vColDebit"
    Me.vColDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.vColDebit.Visible = True
    Me.vColDebit.VisibleIndex = 2
    Me.vColDebit.Width = 82
    '
    'vColKredit
    '
    Me.vColKredit.Caption = "Kredit"
    Me.vColKredit.FieldName = "Kredit"
    Me.vColKredit.Name = "vColKredit"
    Me.vColKredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.vColKredit.Visible = True
    Me.vColKredit.VisibleIndex = 3
    Me.vColKredit.Width = 93
    '
    'vColKurs
    '
    Me.vColKurs.Caption = "Kurs"
    Me.vColKurs.FieldName = "Kurs"
    Me.vColKurs.Name = "vColKurs"
    Me.vColKurs.Visible = True
    Me.vColKurs.VisibleIndex = 5
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.FieldName = "MataUang.Kode"
    Me.colUang.Name = "colUang"
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 4
    '
    'vColDebitValas
    '
    Me.vColDebitValas.Caption = "Debit Valas"
    Me.vColDebitValas.FieldName = "DebitValas"
    Me.vColDebitValas.Name = "vColDebitValas"
    Me.vColDebitValas.Visible = True
    Me.vColDebitValas.VisibleIndex = 6
    '
    'vColKreditValas
    '
    Me.vColKreditValas.Caption = "Kredit Valas"
    Me.vColKreditValas.FieldName = "KreditValas"
    Me.vColKreditValas.Name = "vColKreditValas"
    Me.vColKreditValas.Visible = True
    Me.vColKreditValas.VisibleIndex = 7
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(24, 43)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(711, 112)
    Me.xGrid.TabIndex = 4
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colTanggal, Me.colKontak, Me.colKodeCoa, Me.colNamaCoa, Me.colUraian, Me.colDebit, Me.colKredit, Me.colKurs, Me.colDebitValas, Me.colKreditValas})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsBehavior.ReadOnly = True
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colKode
    '
    Me.colKode.Caption = "No Transaksi"
    Me.colKode.FieldName = "Main.Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.DisplayFormat.FormatString = "dd/MMM/yyyy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggal.FieldName = "Main.Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'colKontak
    '
    Me.colKontak.Caption = "Kontak"
    Me.colKontak.FieldName = "Main.Kontak.Nama"
    Me.colKontak.Name = "colKontak"
    Me.colKontak.Visible = True
    Me.colKontak.VisibleIndex = 2
    '
    'colKodeCoa
    '
    Me.colKodeCoa.Caption = "COA"
    Me.colKodeCoa.FieldName = "Akun.Kode"
    Me.colKodeCoa.Name = "colKodeCoa"
    Me.colKodeCoa.Visible = True
    Me.colKodeCoa.VisibleIndex = 3
    '
    'colNamaCoa
    '
    Me.colNamaCoa.Caption = "Nama COA"
    Me.colNamaCoa.FieldName = "Akun.Nama"
    Me.colNamaCoa.Name = "colNamaCoa"
    Me.colNamaCoa.Visible = True
    Me.colNamaCoa.VisibleIndex = 4
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Main.Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 5
    '
    'colDebit
    '
    Me.colDebit.Caption = "Debit"
    Me.colDebit.FieldName = "Debit"
    Me.colDebit.Name = "colDebit"
    Me.colDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colDebit.Visible = True
    Me.colDebit.VisibleIndex = 6
    '
    'colKredit
    '
    Me.colKredit.Caption = "Kredit"
    Me.colKredit.FieldName = "Kredit"
    Me.colKredit.Name = "colKredit"
    Me.colKredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colKredit.Visible = True
    Me.colKredit.VisibleIndex = 7
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs"
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 8
    '
    'colDebitValas
    '
    Me.colDebitValas.Caption = "Debit Valas"
    Me.colDebitValas.FieldName = "DebitValas"
    Me.colDebitValas.Name = "colDebitValas"
    Me.colDebitValas.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colDebitValas.Visible = True
    Me.colDebitValas.VisibleIndex = 9
    '
    'colKreditValas
    '
    Me.colKreditValas.Caption = "Kredit Valas"
    Me.colKreditValas.FieldName = "KreditValas"
    Me.colKreditValas.Name = "colKreditValas"
    Me.colKreditValas.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colKreditValas.Visible = True
    Me.colKreditValas.VisibleIndex = 10
    '
    'lytControlx
    '
    Me.lytControlx.CustomizationFormText = "LayoutControlGroup1"
    Me.lytControlx.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.lytControlx.GroupBordersVisible = False
    Me.lytControlx.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lyGroupVoucher, Me.lyGroupData})
    Me.lytControlx.Location = New System.Drawing.Point(0, 0)
    Me.lytControlx.Name = "lytControlx"
    Me.lytControlx.Size = New System.Drawing.Size(759, 368)
    Me.lytControlx.Text = "lytControlx"
    Me.lytControlx.TextVisible = False
    '
    'lyGroupVoucher
    '
    Me.lyGroupVoucher.CustomizationFormText = "Jurnal Voucher : - "
    Me.lyGroupVoucher.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
    Me.lyGroupVoucher.Location = New System.Drawing.Point(0, 159)
    Me.lyGroupVoucher.Name = "lyGroupVoucher"
    Me.lyGroupVoucher.Size = New System.Drawing.Size(739, 189)
    Me.lyGroupVoucher.Text = "Jurnal Voucher : - "
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.xGridVoucher
    Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 146)
    Me.LayoutControlItem2.MinSize = New System.Drawing.Size(104, 146)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(715, 146)
    Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem2.Text = "LayoutControlItem2"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem2.TextToControlDistance = 0
    Me.LayoutControlItem2.TextVisible = False
    '
    'lyGroupData
    '
    Me.lyGroupData.CustomizationFormText = "lyGroupData"
    Me.lyGroupData.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
    Me.lyGroupData.Location = New System.Drawing.Point(0, 0)
    Me.lyGroupData.Name = "lyGroupData"
    Me.lyGroupData.Size = New System.Drawing.Size(739, 159)
    Me.lyGroupData.Text = "lyGroupData"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.xGrid
    Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(715, 116)
    Me.LayoutControlItem1.Text = "LayoutControlItem1"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextToControlDistance = 0
    Me.LayoutControlItem1.TextVisible = False
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnTampilkan, Me.btnCetak, Me.btnExport})
    Me.BarManager1.MaxItemId = 3
    Me.BarManager1.StatusBar = Me.Bar3
    '
    'Bar3
    '
    Me.Bar3.BarName = "Status bar"
    Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.Bar3.DockCol = 0
    Me.Bar3.DockRow = 0
    Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTampilkan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetak, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.Bar3.OptionsBar.AllowQuickCustomization = False
    Me.Bar3.OptionsBar.DrawDragBorder = False
    Me.Bar3.OptionsBar.UseWholeRow = True
    Me.Bar3.Text = "Status bar"
    '
    'btnTampilkan
    '
    Me.btnTampilkan.Caption = "Tampilkan Transaksi"
    Me.btnTampilkan.Glyph = CType(resources.GetObject("btnTampilkan.Glyph"), System.Drawing.Image)
    Me.btnTampilkan.Id = 0
    Me.btnTampilkan.LargeGlyph = CType(resources.GetObject("btnTampilkan.LargeGlyph"), System.Drawing.Image)
    Me.btnTampilkan.Name = "btnTampilkan"
    '
    'btnCetak
    '
    Me.btnCetak.Caption = "Cetak"
    Me.btnCetak.Glyph = CType(resources.GetObject("btnCetak.Glyph"), System.Drawing.Image)
    Me.btnCetak.Id = 1
    Me.btnCetak.LargeGlyph = CType(resources.GetObject("btnCetak.LargeGlyph"), System.Drawing.Image)
    Me.btnCetak.Name = "btnCetak"
    '
    'btnExport
    '
    Me.btnExport.Caption = "Export"
    Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
    Me.btnExport.Id = 2
    Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
    Me.btnExport.Name = "btnExport"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Size = New System.Drawing.Size(759, 0)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 368)
    Me.barDockControlBottom.Size = New System.Drawing.Size(759, 27)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 368)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(759, 0)
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 368)
    '
    'UI_DaftarGLDetail2
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Controls.Add(Me.lytControl)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "UI_DaftarGLDetail2"
    Me.Text = "Form1"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytControl, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytControl.ResumeLayout(False)
    CType(Me.xGridVoucher, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridVoucherView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytControlx, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lyGroupVoucher, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lyGroupData, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lytControl As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents lytControlx As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGridVoucher As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridVoucherView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lyGroupVoucher As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents lyGroupData As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents vColDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents vColKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents vColKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents vColDebitValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents vColKreditValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeCoa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaCoa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebitValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKreditValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents btnTampilkan As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetak As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
End Class
