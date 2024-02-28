<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pjp_TransaksiGL
  Inherits Core.Win.Forms.GridInput

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
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pjp_TransaksiGL))
    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
    Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
    Me.colModuleId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colRegional = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetakVoucher = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.ifSource
    Me.xGrid.Size = New System.Drawing.Size(765, 375)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout, Me.btnCetakVoucher, Me.BarButtonItem1})
    Me.barMan.MaxItemId = 16
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colNoBukti, Me.colTanggal, Me.colTipe, Me.colKontakNama, Me.colSaldo, Me.colKeterangan, Me.colRegional, Me.colAkun, Me.colModuleId})
    StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Silver
    StyleFormatCondition1.Appearance.Options.UseBackColor = True
    StyleFormatCondition1.ApplyToRow = True
    StyleFormatCondition1.Column = Me.colModuleId
    StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
    StyleFormatCondition1.Value1 = CType(2, Short)
    Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
    Me.xGridView.GroupCount = 4
    Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRegional, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAkun, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = "Regional.Kode;Regional.Nama;Akun.Kode;Akun.Nama;Kode;Tanggal;KontakNama;Uraian;Mo" & _
    "duleId;Id;Bulan;Tahun;Saldo;Kontak.Nama;Tipe"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.GlMain)
    '
    'toolTip
    '
    Me.toolTip.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnCetakVoucher)})
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colModuleId
    '
    Me.colModuleId.FieldName = "ModuleId"
    Me.colModuleId.Name = "colModuleId"
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colTahun
    '
    Me.colTahun.FieldName = "Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 0
    '
    'colBulan
    '
    Me.colBulan.DisplayFormat.FormatString = "MMMM"
    Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.FieldName = "Bulan"
    Me.colBulan.GroupFormat.FormatString = "MMMM"
    Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.Name = "colBulan"
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 0
    '
    'colNoBukti
    '
    Me.colNoBukti.Caption = "No. Transaksi"
    Me.colNoBukti.FieldName = "Kode"
    Me.colNoBukti.Name = "colNoBukti"
    Me.colNoBukti.Visible = True
    Me.colNoBukti.VisibleIndex = 0
    Me.colNoBukti.Width = 135
    '
    'colTanggal
    '
    Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    Me.colTanggal.Width = 90
    '
    'colKontakNama
    '
    Me.colKontakNama.Caption = "Kontak"
    Me.colKontakNama.FieldName = "Kontak.Nama"
    Me.colKontakNama.Name = "colKontakNama"
    Me.colKontakNama.Visible = True
    Me.colKontakNama.VisibleIndex = 3
    Me.colKontakNama.Width = 127
    '
    'colSaldo
    '
    Me.colSaldo.AppearanceHeader.Options.UseTextOptions = True
    Me.colSaldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colSaldo.FieldName = "Saldo"
    Me.colSaldo.Name = "colSaldo"
    Me.colSaldo.Visible = True
    Me.colSaldo.VisibleIndex = 4
    Me.colSaldo.Width = 85
    '
    'colKeterangan
    '
    Me.colKeterangan.FieldName = "Uraian"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 5
    Me.colKeterangan.Width = 218
    '
    'colRegional
    '
    Me.colRegional.Caption = "Regional"
    Me.colRegional.FieldName = "Regional.Nama"
    Me.colRegional.Name = "colRegional"
    Me.colRegional.Visible = True
    Me.colRegional.VisibleIndex = 5
    '
    'colAkun
    '
    Me.colAkun.Caption = "Akun"
    Me.colAkun.FieldName = "Akun.Nama"
    Me.colAkun.Name = "colAkun"
    Me.colAkun.Visible = True
    Me.colAkun.VisibleIndex = 5
    '
    'btnSaveLayout
    '
    Me.btnSaveLayout.Caption = "Save Layout"
    Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
    Me.btnSaveLayout.Id = 13
    Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btnSaveLayout.Name = "btnSaveLayout"
    '
    'btnCetakVoucher
    '
    Me.btnCetakVoucher.Caption = "Cetak Voucher"
    Me.btnCetakVoucher.Glyph = CType(resources.GetObject("btnCetakVoucher.Glyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Id = 14
    Me.btnCetakVoucher.LargeGlyph = CType(resources.GetObject("btnCetakVoucher.LargeGlyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Name = "btnCetakVoucher"
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "BarButtonItem1"
    Me.BarButtonItem1.Id = 15
    Me.BarButtonItem1.Name = "BarButtonItem1"
    ToolTipTitleItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
    ToolTipTitleItem1.Appearance.Options.UseImage = True
    ToolTipTitleItem1.Image = CType(resources.GetObject("ToolTipTitleItem1.Image"), System.Drawing.Image)
    ToolTipTitleItem1.Text = "Voucher : PRM-DD-KK14040007"
    ToolTipItem1.LeftIndent = 6
    ToolTipItem1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "11000800  Uang Muka Pembelian Tiket (Deposit)" & Global.Microsoft.VisualBasic.ChrW(9) & "5.000.000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10010102  Kas Kecil (I" & _
    "DR) DD" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "5.000.000"
    SuperToolTip1.Items.Add(ToolTipTitleItem1)
    SuperToolTip1.Items.Add(ToolTipItem1)
    Me.BarButtonItem1.SuperTip = SuperToolTip1
    '
    'colTipe
    '
    Me.colTipe.AppearanceCell.Options.UseTextOptions = True
    Me.colTipe.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colTipe.AppearanceHeader.Options.UseTextOptions = True
    Me.colTipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colTipe.Caption = "Tipe"
    Me.colTipe.FieldName = "Tipe"
    Me.colTipe.Name = "colTipe"
    Me.colTipe.Visible = True
    Me.colTipe.VisibleIndex = 2
    Me.colTipe.Width = 92
    '
    'UI_TransaksiGL
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 402)
    Me.Name = "UI_TransaksiGL"
    Me.Text = "Transaksi GL"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colRegional As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colModuleId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetakVoucher As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
End Class