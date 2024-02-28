Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class GridInput
    Inherits NuSoftForm

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
      Me.barMan = New DevExpress.XtraBars.BarManager(Me.components)
      Me.barMenu = New DevExpress.XtraBars.Bar()
      Me.barMenuRefresh = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuAdd = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuEdit = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuDelete = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuExcel = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuPrint = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuFilter = New DevExpress.XtraBars.BarButtonItem()
      Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
      Me.popMenuTambah = New DevExpress.XtraBars.BarButtonItem()
      Me.popMenuEdit = New DevExpress.XtraBars.BarButtonItem()
      Me.popMenuHapus = New DevExpress.XtraBars.BarButtonItem()
      Me.popMenuEksport = New DevExpress.XtraBars.BarButtonItem()
      Me.popMenuCetak = New DevExpress.XtraBars.BarButtonItem()
      Me.xGrid = New DevExpress.XtraGrid.GridControl()
      Me.xpCol = New DevExpress.Xpo.XPCollection(Me.components)
      Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
      Me.toolTip = New DevExpress.Utils.ToolTipController(Me.components)
      Me.session = New DevExpress.Xpo.UnitOfWork(Me.components)
      Me.ifSource = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
      Me.popMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
      CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'barMan
      '
      Me.barMan.AllowCustomization = False
      Me.barMan.AllowMoveBarOnToolbar = False
      Me.barMan.AllowQuickCustomization = False
      Me.barMan.AllowShowToolbarsPopup = False
      Me.barMan.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barMenu})
      Me.barMan.DockControls.Add(Me.barDockControlTop)
      Me.barMan.DockControls.Add(Me.barDockControlBottom)
      Me.barMan.DockControls.Add(Me.barDockControlLeft)
      Me.barMan.DockControls.Add(Me.barDockControlRight)
      Me.barMan.Form = Me
      Me.barMan.HideBarsWhenMerging = False
      Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barMenuRefresh, Me.barMenuAdd, Me.barMenuEdit, Me.barMenuExcel, Me.barMenuPrint, Me.barMenuDelete, Me.barMenuFilter, Me.popMenuTambah, Me.popMenuEdit, Me.popMenuHapus, Me.popMenuEksport, Me.popMenuCetak})
      Me.barMan.MaxItemId = 13
      Me.barMan.StatusBar = Me.barMenu
      '
      'barMenu
      '
      Me.barMenu.BarName = "Menu"
      Me.barMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
      Me.barMenu.DockCol = 0
      Me.barMenu.DockRow = 0
      Me.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
      Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuAdd, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuExcel, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuFilter, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
      Me.barMenu.OptionsBar.AllowQuickCustomization = False
      Me.barMenu.OptionsBar.DrawDragBorder = False
      Me.barMenu.OptionsBar.UseWholeRow = True
      Me.barMenu.Text = "Status bar"
      '
      'barMenuRefresh
      '
      Me.barMenuRefresh.Caption = "&Refresh"
      Me.barMenuRefresh.Glyph = Global.My.Resources.Resources.table_refresh
      Me.barMenuRefresh.Id = 0
      Me.barMenuRefresh.Name = "barMenuRefresh"
      '
      'barMenuAdd
      '
      Me.barMenuAdd.Caption = "&Tambah"
      Me.barMenuAdd.Glyph = Global.My.Resources.Resources.application_form_add
      Me.barMenuAdd.Id = 1
      Me.barMenuAdd.Name = "barMenuAdd"
      '
      'barMenuEdit
      '
      Me.barMenuEdit.Caption = "E&dit"
      Me.barMenuEdit.Glyph = Global.My.Resources.Resources.application_form_edit
      Me.barMenuEdit.Id = 2
      Me.barMenuEdit.Name = "barMenuEdit"
      '
      'barMenuDelete
      '
      Me.barMenuDelete.Caption = "&Hapus"
      Me.barMenuDelete.Glyph = Global.My.Resources.Resources.application_form_delete
      Me.barMenuDelete.Id = 6
      Me.barMenuDelete.Name = "barMenuDelete"
      '
      'barMenuExcel
      '
      Me.barMenuExcel.Caption = "&Eksport Excel"
      Me.barMenuExcel.Glyph = Global.My.Resources.Resources.export_excel
      Me.barMenuExcel.Id = 3
      Me.barMenuExcel.Name = "barMenuExcel"
      '
      'barMenuPrint
      '
      Me.barMenuPrint.Caption = "&Cetak"
      Me.barMenuPrint.Glyph = Global.My.Resources.Resources.printer
      Me.barMenuPrint.Id = 4
      Me.barMenuPrint.Name = "barMenuPrint"
      '
      'barMenuFilter
      '
      Me.barMenuFilter.Caption = "&Filter"
      Me.barMenuFilter.Glyph = Global.My.Resources.Resources.filter
      Me.barMenuFilter.Id = 7
      Me.barMenuFilter.Name = "barMenuFilter"
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
      'popMenuTambah
      '
      Me.popMenuTambah.Caption = "Tambah"
      Me.popMenuTambah.Glyph = Global.My.Resources.Resources.application_form_add
      Me.popMenuTambah.Id = 8
      Me.popMenuTambah.Name = "popMenuTambah"
      '
      'popMenuEdit
      '
      Me.popMenuEdit.Caption = "Edit"
      Me.popMenuEdit.Glyph = Global.My.Resources.Resources.application_form_edit
      Me.popMenuEdit.Id = 9
      Me.popMenuEdit.Name = "popMenuEdit"
      '
      'popMenuHapus
      '
      Me.popMenuHapus.Caption = "Hapus"
      Me.popMenuHapus.Glyph = Global.My.Resources.Resources.application_form_delete
      Me.popMenuHapus.Id = 10
      Me.popMenuHapus.Name = "popMenuHapus"
      '
      'popMenuEksport
      '
      Me.popMenuEksport.Caption = "Eksport"
      Me.popMenuEksport.Glyph = Global.My.Resources.Resources.export_excel
      Me.popMenuEksport.Id = 11
      Me.popMenuEksport.Name = "popMenuEksport"
      '
      'popMenuCetak
      '
      Me.popMenuCetak.Caption = "Cetak"
      Me.popMenuCetak.Glyph = Global.My.Resources.Resources.printer
      Me.popMenuCetak.Id = 12
      Me.popMenuCetak.Name = "popMenuCetak"
      '
      'xGrid
      '
      Me.xGrid.DataSource = Me.xpCol
      Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
      Me.xGrid.Location = New System.Drawing.Point(0, 0)
      Me.xGrid.MainView = Me.xGridView
      Me.xGrid.MenuManager = Me.barMan
      Me.xGrid.Name = "xGrid"
      Me.xGrid.Size = New System.Drawing.Size(759, 368)
      Me.xGrid.TabIndex = 4
      Me.xGrid.ToolTipController = Me.toolTip
      Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
      '
      'xpCol
      '
      Me.xpCol.SelectDeleted = True
      '
      'xGridView
      '
      Me.xGridView.GridControl = Me.xGrid
      Me.xGridView.GroupPanelText = "Drag pada judul kolom untuk mengelompokkan data"
      Me.xGridView.Name = "xGridView"
      Me.xGridView.NewItemRowText = "Tambah data"
      Me.xGridView.OptionsBehavior.Editable = False
      Me.xGridView.OptionsDetail.EnableMasterViewMode = False
      Me.xGridView.OptionsSelection.MultiSelect = True
      '
      'session
      '
      Me.session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None
      Me.session.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
      Me.session.TrackPropertiesModifications = False
      '
      'ifSource
      '
      '
      'popMenu
      '
      Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuTambah), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuHapus), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuEksport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuCetak)})
      Me.popMenu.Manager = Me.barMan
      Me.popMenu.Name = "popMenu"
      '
      'GridInput
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(759, 395)
      Me.Controls.Add(Me.xGrid)
      Me.Controls.Add(Me.barDockControlLeft)
      Me.Controls.Add(Me.barDockControlRight)
      Me.Controls.Add(Me.barDockControlBottom)
      Me.Controls.Add(Me.barDockControlTop)
      Me.Name = "GridInput"
      Me.Text = "GridInput"
      CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barMenuRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuPrint As DevExpress.XtraBars.BarButtonItem
    Public WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Public WithEvents xpCol As DevExpress.Xpo.XPCollection
    Public WithEvents barMan As DevExpress.XtraBars.BarManager
    Public WithEvents session As DevExpress.Xpo.UnitOfWork
    Public WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barMenuDelete As DevExpress.XtraBars.BarButtonItem
    Public WithEvents ifSource As DevExpress.Xpo.XPInstantFeedbackSource
    Friend WithEvents barMenuFilter As DevExpress.XtraBars.BarButtonItem
    Public WithEvents toolTip As DevExpress.Utils.ToolTipController
    Public WithEvents popMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents popMenuTambah As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuHapus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuEksport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuCetak As DevExpress.XtraBars.BarButtonItem
    Public WithEvents barMenu As DevExpress.XtraBars.Bar
  End Class
End Namespace