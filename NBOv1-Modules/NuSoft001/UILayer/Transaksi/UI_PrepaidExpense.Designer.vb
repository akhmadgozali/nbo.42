<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_PrepaidExpense
  Inherits NuSoft.Core.Win.Forms.GridInput

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_PrepaidExpense))
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTglMulai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTglSelesai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUmur = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAmortisasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAmortisasiJumlah = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colRegional = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
    Me.mnAmortisasi = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    Me.xGrid.Size = New System.Drawing.Size(950, 348)
    '
    'xpCol
    '
    Me.xpCol.DisplayableProperties = "Id;Gl.Regional.Nama;Nilai;TanggalMulai;Umur;Gl.Kontak.Nama;Gl.Uraian;Akumulasi;Ni" & _
    "laiPerBulan;TanggalSelesai"
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.PrepaidExpense)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.mnAmortisasi})
    Me.barMan.MaxItemId = 17
    '
    'xGridView
    '
    Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.xGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colRegional, Me.colKontak, Me.colUraian, Me.colNilai, Me.colTglMulai, Me.colTglSelesai, Me.colUmur, Me.colAmortisasi, Me.colAmortisasiJumlah, Me.colSaldo})
    Me.xGridView.GroupCount = 1
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRegional, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTglMulai, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnAmortisasi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'GridControl1
    '
    Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GridControl1.Location = New System.Drawing.Point(0, 0)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(950, 348)
    Me.GridControl1.TabIndex = 0
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Uraian"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn2.Caption = "Nilai"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn3.Caption = "Tgl Mulai"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn4.Caption = "Tgl Selesai"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn5.Caption = "Umur"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    '
    'GridColumn6
    '
    Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn6.Caption = "Amortisasi per Bulan"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    '
    'GridColumn7
    '
    Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn7.Caption = "Akumulasi  Amortisasi"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 6
    '
    'GridColumn8
    '
    Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn8.Caption = "Saldo"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 7
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Gl.Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 1
    '
    'colNilai
    '
    Me.colNilai.Caption = "Nilai"
    Me.colNilai.FieldName = "Nilai"
    Me.colNilai.Name = "colNilai"
    Me.colNilai.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colNilai.Visible = True
    Me.colNilai.VisibleIndex = 2
    '
    'colTglMulai
    '
    Me.colTglMulai.Caption = "Tgl Mulai"
    Me.colTglMulai.DisplayFormat.FormatString = "D"
    Me.colTglMulai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTglMulai.FieldName = "TanggalMulai"
    Me.colTglMulai.Name = "colTglMulai"
    Me.colTglMulai.Visible = True
    Me.colTglMulai.VisibleIndex = 3
    '
    'colTglSelesai
    '
    Me.colTglSelesai.Caption = "Tgl Selesai"
    Me.colTglSelesai.DisplayFormat.FormatString = "D"
    Me.colTglSelesai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTglSelesai.FieldName = "TanggalSelesai"
    Me.colTglSelesai.Name = "colTglSelesai"
    Me.colTglSelesai.Visible = True
    Me.colTglSelesai.VisibleIndex = 4
    '
    'colUmur
    '
    Me.colUmur.AppearanceCell.Options.UseTextOptions = True
    Me.colUmur.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colUmur.Caption = "Umur"
    Me.colUmur.FieldName = "Umur"
    Me.colUmur.Name = "colUmur"
    Me.colUmur.Visible = True
    Me.colUmur.VisibleIndex = 5
    '
    'colAmortisasi
    '
    Me.colAmortisasi.AppearanceCell.Options.UseTextOptions = True
    Me.colAmortisasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colAmortisasi.Caption = "Amortisasi per Bulan"
    Me.colAmortisasi.FieldName = "NilaiPerBulan"
    Me.colAmortisasi.Name = "colAmortisasi"
    Me.colAmortisasi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colAmortisasi.Visible = True
    Me.colAmortisasi.VisibleIndex = 6
    '
    'colAmortisasiJumlah
    '
    Me.colAmortisasiJumlah.AppearanceCell.Options.UseTextOptions = True
    Me.colAmortisasiJumlah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colAmortisasiJumlah.Caption = "Akumulasi Amortisasi"
    Me.colAmortisasiJumlah.FieldName = "Akumulasi"
    Me.colAmortisasiJumlah.Name = "colAmortisasiJumlah"
    Me.colAmortisasiJumlah.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colAmortisasiJumlah.Visible = True
    Me.colAmortisasiJumlah.VisibleIndex = 7
    '
    'colSaldo
    '
    Me.colSaldo.AppearanceCell.Options.UseTextOptions = True
    Me.colSaldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colSaldo.Caption = "Saldo"
    Me.colSaldo.FieldName = "Saldo"
    Me.colSaldo.Name = "colSaldo"
    Me.colSaldo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colSaldo.UnboundExpression = "Nilai-NilaiAmortisasi"
    Me.colSaldo.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    '
    'colKontak
    '
    Me.colKontak.Caption = "Kontak"
    Me.colKontak.FieldName = "Gl.Kontak.Nama"
    Me.colKontak.Name = "colKontak"
    Me.colKontak.Visible = True
    Me.colKontak.VisibleIndex = 0
    '
    'colRegional
    '
    Me.colRegional.Caption = "Regional"
    Me.colRegional.FieldName = "Gl.Regional.Nama"
    Me.colRegional.Name = "colRegional"
    Me.colRegional.Visible = True
    Me.colRegional.VisibleIndex = 0
    '
    'colID
    '
    Me.colID.Caption = "ID"
    Me.colID.FieldName = "Id"
    Me.colID.Name = "colID"
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "Amortisasi"
    Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
    Me.BarButtonItem1.Id = 13
    Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'BarButtonItem2
    '
    Me.BarButtonItem2.Caption = "Amortisasi"
    Me.BarButtonItem2.Glyph = Global.NuSoft.NUI.Win.Forms.Modules.NuSoft001.My.Resources.Resources.cellsautoheight__16x16
    Me.BarButtonItem2.Id = 14
    Me.BarButtonItem2.LargeGlyph = Global.NuSoft.NUI.Win.Forms.Modules.NuSoft001.My.Resources.Resources.cellsautoheight__32x32
    Me.BarButtonItem2.Name = "BarButtonItem2"
    '
    'BarButtonItem3
    '
    Me.BarButtonItem3.Caption = "BarButtonItem3"
    Me.BarButtonItem3.Id = 15
    Me.BarButtonItem3.Name = "BarButtonItem3"
    '
    'mnAmortisasi
    '
    Me.mnAmortisasi.Caption = "Amortisasi"
    Me.mnAmortisasi.Glyph = Global.NuSoft.NUI.Win.Forms.Modules.NuSoft001.My.Resources.Resources.cellsautoheight__16x16
    Me.mnAmortisasi.Id = 16
    Me.mnAmortisasi.Name = "mnAmortisasi"
    '
    'UI_PrepaidExpense
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(950, 375)
    Me.Controls.Add(Me.GridControl1)
    Me.Name = "UI_PrepaidExpense"
    Me.Text = "Prepaid Expense"
    Me.xpCol = Me.xpCol
    Me.Controls.SetChildIndex(Me.GridControl1, 0)
    Me.Controls.SetChildIndex(Me.xGrid, 0)
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTglMulai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTglSelesai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUmur As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAmortisasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAmortisasiJumlah As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colRegional As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents mnAmortisasi As DevExpress.XtraBars.BarButtonItem
End Class
