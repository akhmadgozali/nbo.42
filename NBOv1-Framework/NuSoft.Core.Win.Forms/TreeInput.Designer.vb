Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class TreeInput
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
      Me.xpCol = New DevExpress.Xpo.XPCollection(Me.components)
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
      Me.session = New DevExpress.Xpo.UnitOfWork(Me.components)
      Me.ifSource = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
      Me.xTree = New DevExpress.XtraTreeList.TreeList()
      Me.popMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
      CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xTree, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'xpCol
      '
      Me.xpCol.SelectDeleted = True
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
      Me.barDockControlTop.Size = New System.Drawing.Size(712, 0)
      '
      'barDockControlBottom
      '
      Me.barDockControlBottom.CausesValidation = False
      Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.barDockControlBottom.Location = New System.Drawing.Point(0, 355)
      Me.barDockControlBottom.Size = New System.Drawing.Size(712, 27)
      '
      'barDockControlLeft
      '
      Me.barDockControlLeft.CausesValidation = False
      Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
      Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
      Me.barDockControlLeft.Size = New System.Drawing.Size(0, 355)
      '
      'barDockControlRight
      '
      Me.barDockControlRight.CausesValidation = False
      Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
      Me.barDockControlRight.Location = New System.Drawing.Point(712, 0)
      Me.barDockControlRight.Size = New System.Drawing.Size(0, 355)
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
      Me.popMenuEksport.Caption = "Eksport Excel"
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
      'session
      '
      Me.session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None
      Me.session.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
      Me.session.TrackPropertiesModifications = False
      '
      'ifSource
      '
      '
      'xTree
      '
      Me.xTree.DataSource = Me.xpCol
      Me.xTree.Dock = System.Windows.Forms.DockStyle.Fill
      Me.xTree.KeyFieldName = "This"
      Me.xTree.Location = New System.Drawing.Point(0, 0)
      Me.xTree.Name = "xTree"
      Me.xTree.OptionsBehavior.Editable = False
      Me.xTree.OptionsSelection.MultiSelect = True
      Me.xTree.ParentFieldName = "Induk!"
      Me.xTree.Size = New System.Drawing.Size(712, 355)
      Me.xTree.TabIndex = 4
      '
      'popMenu
      '
      Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuTambah), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuHapus), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuEksport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuCetak)})
      Me.popMenu.Manager = Me.barMan
      Me.popMenu.Name = "popMenu"
      '
      'TreeInput
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(712, 382)
      Me.Controls.Add(Me.xTree)
      Me.Controls.Add(Me.barDockControlLeft)
      Me.Controls.Add(Me.barDockControlRight)
      Me.Controls.Add(Me.barDockControlBottom)
      Me.Controls.Add(Me.barDockControlTop)
      Me.Name = "TreeInput"
      Me.Text = "TreeInput"
      CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xTree, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

    End Sub
    Public WithEvents xpCol As DevExpress.Xpo.XPCollection
    Public WithEvents barMan As DevExpress.XtraBars.BarManager
    Friend WithEvents barMenuRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Public WithEvents session As DevExpress.Xpo.UnitOfWork
    Public WithEvents ifSource As DevExpress.Xpo.XPInstantFeedbackSource
    Public WithEvents xTree As DevExpress.XtraTreeList.TreeList
    Friend WithEvents popMenuTambah As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuHapus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuEksport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuCetak As DevExpress.XtraBars.BarButtonItem
    Public WithEvents popMenu As DevExpress.XtraBars.PopupMenu
    Public WithEvents barMenu As DevExpress.XtraBars.Bar
  End Class
End Namespace