Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class TreeBinding
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
      Me.barMenuSave = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuCancel = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuExcel = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuPrint = New DevExpress.XtraBars.BarButtonItem()
      Me.barText = New DevExpress.XtraBars.BarStaticItem()
      Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
      Me.xpCol = New DevExpress.Xpo.XPCollection(Me.components)
      Me.session = New DevExpress.Xpo.UnitOfWork(Me.components)
      Me.xTree = New DevExpress.XtraTreeList.TreeList()
      CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xTree, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barMenuRefresh, Me.barMenuSave, Me.barMenuCancel, Me.barMenuExcel, Me.barMenuPrint, Me.barText})
      Me.barMan.MaxItemId = 6
      Me.barMan.StatusBar = Me.barMenu
      '
      'barMenu
      '
      Me.barMenu.BarName = "Menu"
      Me.barMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
      Me.barMenu.DockCol = 0
      Me.barMenu.DockRow = 0
      Me.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
      Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuSave, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuExcel, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barText)})
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
      'barMenuSave
      '
      Me.barMenuSave.Caption = "&Simpan"
      Me.barMenuSave.Glyph = Global.My.Resources.Resources.table_save
      Me.barMenuSave.Id = 1
      Me.barMenuSave.Name = "barMenuSave"
      '
      'barMenuCancel
      '
      Me.barMenuCancel.Caption = "&Tutup"
      Me.barMenuCancel.Glyph = Global.My.Resources.Resources.cancel
      Me.barMenuCancel.Id = 2
      Me.barMenuCancel.Name = "barMenuCancel"
      '
      'barMenuExcel
      '
      Me.barMenuExcel.Caption = "&Export Excel"
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
      'barText
      '
      Me.barText.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
      Me.barText.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
      Me.barText.Caption = "Tekan Ctrl+Del untuk menghapus baris"
      Me.barText.Id = 5
      Me.barText.Name = "barText"
      Me.barText.TextAlignment = System.Drawing.StringAlignment.Far
      Me.barText.Width = 32
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
      'xpCol
      '
      Me.xpCol.SelectDeleted = True
      '
      'session
      '
      Me.session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None
      Me.session.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
      Me.session.TrackPropertiesModifications = False
      '
      'xTree
      '
      Me.xTree.DataSource = Me.xpCol
      Me.xTree.Dock = System.Windows.Forms.DockStyle.Fill
      Me.xTree.KeyFieldName = "This"
      Me.xTree.Location = New System.Drawing.Point(0, 0)
      Me.xTree.Name = "xTree"
      Me.xTree.ParentFieldName = "Induk!"
      Me.xTree.Size = New System.Drawing.Size(759, 368)
      Me.xTree.TabIndex = 9
      '
      'TreeBinding
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(759, 395)
      Me.Controls.Add(Me.xTree)
      Me.Controls.Add(Me.barDockControlLeft)
      Me.Controls.Add(Me.barDockControlRight)
      Me.Controls.Add(Me.barDockControlBottom)
      Me.Controls.Add(Me.barDockControlTop)
      Me.Name = "TreeBinding"
      Me.Text = "TreeBinding"
      CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xTree, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barMenuRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barText As DevExpress.XtraBars.BarStaticItem
    Public WithEvents xpCol As DevExpress.Xpo.XPCollection
    Public WithEvents barMan As DevExpress.XtraBars.BarManager
    Public WithEvents session As DevExpress.Xpo.UnitOfWork
    Public WithEvents xTree As DevExpress.XtraTreeList.TreeList
    Public WithEvents barMenu As DevExpress.XtraBars.Bar
  End Class
End Namespace