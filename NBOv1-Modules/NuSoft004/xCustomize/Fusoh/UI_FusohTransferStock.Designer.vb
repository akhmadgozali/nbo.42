<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohTransferStock
  Inherits Core.Win.Forms.GridInput

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohTransferStock))
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnReset = New DevExpress.XtraBars.BarButtonItem()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTSBahanBakuQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTSBarangJadiQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        '
        'barMan
        '
        Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnReset})
        Me.barMan.MaxItemId = 14
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKode, Me.colBulan, Me.colTahun, Me.GridColumn1, Me.colStatusTransaksi, Me.colTanggal, Me.GridColumn2, Me.colCatatan, Me.GridColumn3, Me.colTSBahanBakuQty, Me.GridColumn4, Me.colTSBarangJadiQty, Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.GridColumn5, Me.GridColumn6})
        Me.xGridView.GroupCount = 3
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsSelection.MultiSelect = True
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ifSource
        '
        Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
        Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_StokMain)
        '
        'barMenu
        '
        Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barMenu.OptionsBar.AllowQuickCustomization = False
        Me.barMenu.OptionsBar.DrawDragBorder = False
        Me.barMenu.OptionsBar.UseWholeRow = True
        '
        'colId
        '
        Me.colId.Caption = "Id"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colKode
        '
        Me.colKode.Caption = "No Bukti"
        Me.colKode.FieldName = "Kode"
        Me.colKode.Name = "colKode"
        Me.colKode.Visible = True
        Me.colKode.VisibleIndex = 0
        Me.colKode.Width = 83
        '
        'colBulan
        '
        Me.colBulan.Caption = "Bulan"
        Me.colBulan.DisplayFormat.FormatString = "MMMM"
        Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.FieldName = "Bulan"
        Me.colBulan.GroupFormat.FormatString = "MMMM"
        Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.Name = "colBulan"
        Me.colBulan.Visible = True
        Me.colBulan.VisibleIndex = 1
        '
        'colTahun
        '
        Me.colTahun.Caption = "Tahun"
        Me.colTahun.FieldName = "Tahun"
        Me.colTahun.Name = "colTahun"
        Me.colTahun.Visible = True
        Me.colTahun.VisibleIndex = 9
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Regional"
        Me.GridColumn1.FieldName = "Regional.Kode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 13
        '
        'colStatusTransaksi
        '
        Me.colStatusTransaksi.Caption = "Status"
        Me.colStatusTransaksi.FieldName = "StatusTransaksi"
        Me.colStatusTransaksi.Name = "colStatusTransaksi"
        Me.colStatusTransaksi.Visible = True
        Me.colStatusTransaksi.VisibleIndex = 10
        '
        'colTanggal
        '
        Me.colTanggal.Caption = "Tanggal"
        Me.colTanggal.FieldName = "Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Kontak"
        Me.GridColumn2.FieldName = "Pelanggan.Nama"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'colCatatan
        '
        Me.colCatatan.Caption = "Catatan"
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 9
        '
        'btnReset
        '
        Me.btnReset.Caption = "Reset TS"
        Me.btnReset.Glyph = CType(resources.GetObject("btnReset.Glyph"), System.Drawing.Image)
        Me.btnReset.Id = 13
        Me.btnReset.LargeGlyph = CType(resources.GetObject("btnReset.LargeGlyph"), System.Drawing.Image)
        Me.btnReset.Name = "btnReset"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Part Asal"
        Me.GridColumn3.FieldName = "TSBahanBaku.Kode"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'colTSBahanBakuQty
        '
        Me.colTSBahanBakuQty.Caption = "Qty"
        Me.colTSBahanBakuQty.FieldName = "TSBahanBakuQty"
        Me.colTSBahanBakuQty.Name = "colTSBahanBakuQty"
        Me.colTSBahanBakuQty.Visible = True
        Me.colTSBahanBakuQty.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Part Tujuan"
        Me.GridColumn4.FieldName = "TSBarangJadi.Kode"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'colTSBarangJadiQty
        '
        Me.colTSBarangJadiQty.Caption = "Qty"
        Me.colTSBarangJadiQty.FieldName = "TSBarangJadiQty"
        Me.colTSBarangJadiQty.Name = "colTSBarangJadiQty"
        Me.colTSBarangJadiQty.Visible = True
        Me.colTSBarangJadiQty.VisibleIndex = 6
        '
        'colcreated_date
        '
        Me.colcreated_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colcreated_date.FieldName = "created_date"
        Me.colcreated_date.Name = "colcreated_date"
        '
        'colcreated_user
        '
        Me.colcreated_user.FieldName = "created_user"
        Me.colcreated_user.Name = "colcreated_user"
        '
        'collast_date
        '
        Me.collast_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.collast_date.FieldName = "last_date"
        Me.collast_date.Name = "collast_date"
        '
        'collast_modified
        '
        Me.collast_modified.FieldName = "last_modified"
        Me.collast_modified.Name = "collast_modified"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "No Produksi"
        Me.GridColumn5.FieldName = "ProduksiDetail.Main.Kode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "No LOT"
        Me.GridColumn6.FieldName = "ProduksiDetail.Main.DempyouLot"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        '
        'UI_FusohTransferStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 395)
        Me.Name = "UI_FusohTransferStock"
        Me.Text = "Transfer Finish Goods"
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
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnReset As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTSBahanBakuQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTSBarangJadiQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
