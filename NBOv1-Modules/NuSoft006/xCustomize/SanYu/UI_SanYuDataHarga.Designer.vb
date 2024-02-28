<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanYuDataHarga
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SanYuDataHarga))
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
    Me.BarDockingMenuItem2 = New DevExpress.XtraBars.BarDockingMenuItem()
    Me.btnUpdate = New DevExpress.XtraBars.BarSubItem()
    Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUpdateTransaksi = New DevExpress.XtraBars.BarSubItem()
    Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnUnPosting = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClosing = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.btnCetak = New DevExpress.XtraBars.BarButtonItem()
    Me.btnHistory = New DevExpress.XtraBars.BarButtonItem()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarDockingMenuItem1, Me.BarDockingMenuItem2, Me.btnUpdate, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.btnUpdateTransaksi, Me.btnPosting, Me.btnUnPosting, Me.btnClosing, Me.BarButtonItem6, Me.BarButtonItem7, Me.btnSaveLayout, Me.btnCetak, Me.btnHistory, Me.BarButtonItem8})
    Me.barMan.MaxItemId = 31
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKode, Me.colNama})
    Me.xGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kode", Nothing, "  (Record : {0})")})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    '
    'ifSource
    '
    Me.ifSource.FixedFilterString = "[TipeKontak.Id] = 2"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.SanYu_Kontak)
    '
    'toolTip
    '
    Me.toolTip.ToolTipStyle = DevExpress.Utils.ToolTipStyle.Windows7
    Me.toolTip.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetak, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnHistory, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    Me.colId.OptionsColumn.ReadOnly = True
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "UnPosting"
    Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
    Me.BarButtonItem1.Id = 13
    Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'BarButtonItem2
    '
    Me.BarButtonItem2.Caption = "Posting"
    Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
    Me.BarButtonItem2.Id = 14
    Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
    Me.BarButtonItem2.Name = "BarButtonItem2"
    '
    'BarDockingMenuItem1
    '
    Me.BarDockingMenuItem1.Caption = "BarDockingMenuItem1"
    Me.BarDockingMenuItem1.Id = 15
    Me.BarDockingMenuItem1.Name = "BarDockingMenuItem1"
    '
    'BarDockingMenuItem2
    '
    Me.BarDockingMenuItem2.Caption = "Update Status"
    Me.BarDockingMenuItem2.Id = 16
    Me.BarDockingMenuItem2.Name = "BarDockingMenuItem2"
    '
    'btnUpdate
    '
    Me.btnUpdate.Caption = "Update Status"
    Me.btnUpdate.Id = 17
    Me.btnUpdate.LargeGlyph = CType(resources.GetObject("btnUpdate.LargeGlyph"), System.Drawing.Image)
    Me.btnUpdate.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem5, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.btnUpdate.Name = "btnUpdate"
    '
    'BarButtonItem3
    '
    Me.BarButtonItem3.Caption = "Posting Transaksi"
    Me.BarButtonItem3.Id = 18
    Me.BarButtonItem3.Name = "BarButtonItem3"
    '
    'BarButtonItem4
    '
    Me.BarButtonItem4.Caption = "UnPosting Transaksi"
    Me.BarButtonItem4.Id = 19
    Me.BarButtonItem4.Name = "BarButtonItem4"
    '
    'BarButtonItem5
    '
    Me.BarButtonItem5.Caption = "Closing Transaksi"
    Me.BarButtonItem5.Id = 20
    Me.BarButtonItem5.Name = "BarButtonItem5"
    '
    'btnUpdateTransaksi
    '
    Me.btnUpdateTransaksi.Caption = "&Update Status"
    Me.btnUpdateTransaksi.Glyph = CType(resources.GetObject("btnUpdateTransaksi.Glyph"), System.Drawing.Image)
    Me.btnUpdateTransaksi.Id = 21
    Me.btnUpdateTransaksi.LargeGlyph = CType(resources.GetObject("btnUpdateTransaksi.LargeGlyph"), System.Drawing.Image)
    Me.btnUpdateTransaksi.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUnPosting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClosing, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.btnUpdateTransaksi.Name = "btnUpdateTransaksi"
    '
    'BarButtonItem8
    '
    Me.BarButtonItem8.Caption = "Approve"
    Me.BarButtonItem8.Id = 30
    Me.BarButtonItem8.Name = "BarButtonItem8"
    '
    'btnPosting
    '
    Me.btnPosting.Caption = "Posting Transaksi"
    Me.btnPosting.Glyph = CType(resources.GetObject("btnPosting.Glyph"), System.Drawing.Image)
    Me.btnPosting.Id = 22
    Me.btnPosting.LargeGlyph = CType(resources.GetObject("btnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnPosting.Name = "btnPosting"
    Me.btnPosting.Tag = "memposting"
    '
    'btnUnPosting
    '
    Me.btnUnPosting.Caption = "UnPosting Transaksi"
    Me.btnUnPosting.Glyph = CType(resources.GetObject("btnUnPosting.Glyph"), System.Drawing.Image)
    Me.btnUnPosting.Id = 23
    Me.btnUnPosting.LargeGlyph = CType(resources.GetObject("btnUnPosting.LargeGlyph"), System.Drawing.Image)
    Me.btnUnPosting.Name = "btnUnPosting"
    Me.btnUnPosting.Tag = "mengunposting"
    '
    'btnClosing
    '
    Me.btnClosing.Caption = "Closing Transaksi"
    Me.btnClosing.Id = 24
    Me.btnClosing.Name = "btnClosing"
    Me.btnClosing.Tag = "mengclosing"
    '
    'BarButtonItem6
    '
    Me.BarButtonItem6.Caption = "BarButtonItem6"
    Me.BarButtonItem6.Id = 25
    Me.BarButtonItem6.Name = "BarButtonItem6"
    '
    'BarButtonItem7
    '
    Me.BarButtonItem7.Caption = "Testing"
    Me.BarButtonItem7.Id = 26
    Me.BarButtonItem7.Name = "BarButtonItem7"
    '
    'btnSaveLayout
    '
    Me.btnSaveLayout.Caption = "Save Layout"
    Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
    Me.btnSaveLayout.Id = 27
    Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btnSaveLayout.Name = "btnSaveLayout"
    '
    'btnCetak
    '
    Me.btnCetak.Caption = "Cetak Voucher"
    Me.btnCetak.Glyph = CType(resources.GetObject("btnCetak.Glyph"), System.Drawing.Image)
    Me.btnCetak.Id = 28
    Me.btnCetak.LargeGlyph = CType(resources.GetObject("btnCetak.LargeGlyph"), System.Drawing.Image)
    Me.btnCetak.Name = "btnCetak"
    '
    'btnHistory
    '
    Me.btnHistory.Caption = "Cek History Data"
    Me.btnHistory.Glyph = CType(resources.GetObject("btnHistory.Glyph"), System.Drawing.Image)
    Me.btnHistory.Id = 29
    Me.btnHistory.LargeGlyph = CType(resources.GetObject("btnHistory.LargeGlyph"), System.Drawing.Image)
    Me.btnHistory.Name = "btnHistory"
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
    'UI_SanYuDataHarga
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_SanYuDataHarga"
    Me.Text = "Daftar Harga Barang"
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
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
  Friend WithEvents BarDockingMenuItem2 As DevExpress.XtraBars.BarDockingMenuItem
  Friend WithEvents btnUpdate As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUpdateTransaksi As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnUnPosting As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClosing As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnCetak As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnHistory As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
End Class
