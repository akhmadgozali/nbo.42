<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Akun
  Inherits Core.Win.Forms.TreeInput

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Akun))
    Me.colKode = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colNama = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colNamaCashFlowTambah = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colNamaCashFlowMinus = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colTipeAkun = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colAktif = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colGabungCashFlow = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.colDivisi = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.cmdExpand = New DevExpress.XtraBars.BarButtonItem()
    Me.cmdCollapse = New DevExpress.XtraBars.BarButtonItem()
    Me.colUang = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.btnDetail = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xTree, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xpCol
    '
    Me.xpCol.DisplayableProperties = "This;last_date;last_modified;Id;Tipe.Kode;Kode;Nama;NamaCashFlowTambah;NamaCashFl" & _
    "owMinus;Induk!;Induk;Aktif;Internal;MultiCashFlow;GabungCashFlow;Keterangan;Indu" & _
    "k.Id;Divisi.Kode;MataUang.Kode"
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft008.Persistent.Coa)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdExpand, Me.cmdCollapse, Me.btnSaveLayout, Me.btnDetail})
    Me.barMan.MaxItemId = 18
    '
    'xTree
    '
    Me.xTree.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colKode, Me.colNama, Me.colNamaCashFlowTambah, Me.colNamaCashFlowMinus, Me.colTipeAkun, Me.colAktif, Me.colGabungCashFlow, Me.colDivisi, Me.colUang})
    Me.xTree.CustomizationFormBounds = New System.Drawing.Rectangle(557, 359, 216, 178)
    Me.xTree.OptionsBehavior.Editable = False
    Me.xTree.OptionsBehavior.EnableFiltering = True
    Me.xTree.OptionsFilter.ShowAllValuesInFilterPopup = True
    Me.xTree.OptionsFind.AllowFindPanel = True
    Me.xTree.OptionsLayout.StoreAppearance = True
    Me.xTree.OptionsPrint.PrintAllNodes = True
    Me.xTree.OptionsPrint.PrintPreview = True
    Me.xTree.OptionsSelection.MultiSelect = True
    Me.xTree.Size = New System.Drawing.Size(718, 361)
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDetail, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdExpand, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdCollapse, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSaveLayout, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.SortOrder = System.Windows.Forms.SortOrder.Ascending
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 80
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    Me.colNama.Width = 150
    '
    'colNamaCashFlowTambah
    '
    Me.colNamaCashFlowTambah.Caption = "Nama CF (+)"
    Me.colNamaCashFlowTambah.FieldName = "NamaCashFlowTambah"
    Me.colNamaCashFlowTambah.Name = "colNamaCashFlowTambah"
    Me.colNamaCashFlowTambah.Visible = True
    Me.colNamaCashFlowTambah.VisibleIndex = 2
    Me.colNamaCashFlowTambah.Width = 80
    '
    'colNamaCashFlowMinus
    '
    Me.colNamaCashFlowMinus.Caption = "Nama CF (-)"
    Me.colNamaCashFlowMinus.FieldName = "NamaCashFlowMinus"
    Me.colNamaCashFlowMinus.Name = "colNamaCashFlowMinus"
    Me.colNamaCashFlowMinus.Visible = True
    Me.colNamaCashFlowMinus.VisibleIndex = 3
    Me.colNamaCashFlowMinus.Width = 80
    '
    'colTipeAkun
    '
    Me.colTipeAkun.Caption = "Tipe Akun"
    Me.colTipeAkun.FieldName = "Tipe.Kode"
    Me.colTipeAkun.Name = "colTipeAkun"
    Me.colTipeAkun.Visible = True
    Me.colTipeAkun.VisibleIndex = 4
    Me.colTipeAkun.Width = 80
    '
    'colAktif
    '
    Me.colAktif.AppearanceHeader.Options.UseTextOptions = True
    Me.colAktif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colAktif.FieldName = "Aktif"
    Me.colAktif.Name = "colAktif"
    Me.colAktif.Visible = True
    Me.colAktif.VisibleIndex = 5
    Me.colAktif.Width = 50
    '
    'colGabungCashFlow
    '
    Me.colGabungCashFlow.AppearanceHeader.Options.UseTextOptions = True
    Me.colGabungCashFlow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colGabungCashFlow.Caption = "Gabung CF"
    Me.colGabungCashFlow.FieldName = "GabungCashFlow"
    Me.colGabungCashFlow.Name = "colGabungCashFlow"
    Me.colGabungCashFlow.Visible = True
    Me.colGabungCashFlow.VisibleIndex = 6
    Me.colGabungCashFlow.Width = 50
    '
    'colDivisi
    '
    Me.colDivisi.AppearanceHeader.Options.UseTextOptions = True
    Me.colDivisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colDivisi.Caption = "Divisi"
    Me.colDivisi.FieldName = "Divisi.Kode"
    Me.colDivisi.Name = "colDivisi"
    Me.colDivisi.Visible = True
    Me.colDivisi.VisibleIndex = 7
    Me.colDivisi.Width = 50
    '
    'cmdExpand
    '
    Me.cmdExpand.Caption = "Expand All"
    Me.cmdExpand.Glyph = CType(resources.GetObject("cmdExpand.Glyph"), System.Drawing.Image)
    Me.cmdExpand.Id = 14
    Me.cmdExpand.LargeGlyph = CType(resources.GetObject("cmdExpand.LargeGlyph"), System.Drawing.Image)
    Me.cmdExpand.Name = "cmdExpand"
    '
    'cmdCollapse
    '
    Me.cmdCollapse.Caption = "Collapse All"
    Me.cmdCollapse.Glyph = CType(resources.GetObject("cmdCollapse.Glyph"), System.Drawing.Image)
    Me.cmdCollapse.Id = 15
    Me.cmdCollapse.LargeGlyph = CType(resources.GetObject("cmdCollapse.LargeGlyph"), System.Drawing.Image)
    Me.cmdCollapse.Name = "cmdCollapse"
    '
    'colUang
    '
    Me.colUang.AppearanceHeader.Options.UseTextOptions = True
    Me.colUang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colUang.Caption = "Uang"
    Me.colUang.FieldName = "MataUang.Kode"
    Me.colUang.Name = "colUang"
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 8
    '
    'btnSaveLayout
    '
    Me.btnSaveLayout.Caption = "Save Layout"
    Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
    Me.btnSaveLayout.Id = 16
    Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btnSaveLayout.Name = "btnSaveLayout"
    '
    'btnDetail
    '
    Me.btnDetail.Caption = "Daftar GL"
    Me.btnDetail.Id = 17
    Me.btnDetail.Name = "btnDetail"
    '
    'UI_Akun
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(718, 388)
    Me.Name = "UI_Akun"
    Me.Text = "Akun"
    Me.xpCol = Me.xpCol
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xTree, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colKode As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colNama As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colNamaCashFlowTambah As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colNamaCashFlowMinus As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colTipeAkun As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colAktif As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colGabungCashFlow As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents colDivisi As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents cmdExpand As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents cmdCollapse As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colUang As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnDetail As DevExpress.XtraBars.BarButtonItem
End Class
