Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class GridOutput
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
      Me.barChart = New DevExpress.XtraBars.BarButtonItem()
      Me.barMenuFilter = New DevExpress.XtraBars.BarButtonItem()
      Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
      Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
      Me.popMenuEksport = New DevExpress.XtraBars.BarButtonItem()
      Me.popMenuCetak = New DevExpress.XtraBars.BarButtonItem()
      Me.chartPopUpEkspor = New DevExpress.XtraBars.BarSubItem()
      Me.chartPopUpCetak = New DevExpress.XtraBars.BarButtonItem()
      Me.chartPopUpAppearance = New DevExpress.XtraBars.BarSubItem()
      Me.chartPopUpPallette = New DevExpress.XtraBars.BarSubItem()
      Me.chartPopUpWizard = New DevExpress.XtraBars.BarButtonItem()
      Me.xpCol = New DevExpress.Xpo.XPCollection(Me.components)
      Me.toolTip = New DevExpress.Utils.ToolTipController(Me.components)
      Me.session = New DevExpress.Xpo.UnitOfWork(Me.components)
      Me.ifSource = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
      Me.popMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
      Me.xGrid = New DevExpress.XtraGrid.GridControl()
      Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
      Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
      Me.chartPopUp = New DevExpress.XtraBars.PopupMenu(Me.components)
      CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainerControl1.SuspendLayout()
      CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barMenuRefresh, Me.barMenuFilter, Me.popMenuEksport, Me.popMenuCetak, Me.barChart, Me.chartPopUpEkspor, Me.chartPopUpCetak, Me.chartPopUpAppearance, Me.chartPopUpPallette, Me.chartPopUpWizard})
      Me.barMan.MaxItemId = 22
      Me.barMan.StatusBar = Me.barMenu
      '
      'barMenu
      '
      Me.barMenu.BarName = "Menu"
      Me.barMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
      Me.barMenu.DockCol = 0
      Me.barMenu.DockRow = 0
      Me.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
      Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barChart, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barMenuFilter, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
      'barChart
      '
      Me.barChart.Caption = "Sembunyikan &Grafik"
      Me.barChart.Glyph = Global.My.Resources.Resources.chart_bar
      Me.barChart.Id = 13
      Me.barChart.Name = "barChart"
      Me.barChart.Tag = True
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
      Me.barDockControlTop.Size = New System.Drawing.Size(888, 0)
      '
      'barDockControlBottom
      '
      Me.barDockControlBottom.CausesValidation = False
      Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.barDockControlBottom.Location = New System.Drawing.Point(0, 378)
      Me.barDockControlBottom.Size = New System.Drawing.Size(888, 27)
      '
      'barDockControlLeft
      '
      Me.barDockControlLeft.CausesValidation = False
      Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
      Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
      Me.barDockControlLeft.Size = New System.Drawing.Size(0, 378)
      '
      'barDockControlRight
      '
      Me.barDockControlRight.CausesValidation = False
      Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
      Me.barDockControlRight.Location = New System.Drawing.Point(888, 0)
      Me.barDockControlRight.Size = New System.Drawing.Size(0, 378)
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
      'chartPopUpEkspor
      '
      Me.chartPopUpEkspor.Caption = "Ekspor"
      Me.chartPopUpEkspor.Glyph = Global.My.Resources.Resources.layer_export
      Me.chartPopUpEkspor.Id = 14
      Me.chartPopUpEkspor.Name = "chartPopUpEkspor"
      '
      'chartPopUpCetak
      '
      Me.chartPopUpCetak.Caption = "Cetak"
      Me.chartPopUpCetak.Glyph = Global.My.Resources.Resources.printer
      Me.chartPopUpCetak.Id = 15
      Me.chartPopUpCetak.Name = "chartPopUpCetak"
      '
      'chartPopUpAppearance
      '
      Me.chartPopUpAppearance.Caption = "Appearance"
      Me.chartPopUpAppearance.Id = 18
      Me.chartPopUpAppearance.Name = "chartPopUpAppearance"
      '
      'chartPopUpPallette
      '
      Me.chartPopUpPallette.Caption = "Pallette"
      Me.chartPopUpPallette.Id = 20
      Me.chartPopUpPallette.Name = "chartPopUpPallette"
      '
      'chartPopUpWizard
      '
      Me.chartPopUpWizard.Caption = "Wizard"
      Me.chartPopUpWizard.Id = 21
      Me.chartPopUpWizard.Name = "chartPopUpWizard"
      '
      'xpCol
      '
      Me.xpCol.SelectDeleted = True
      '
      'session
      '
      Me.session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None
      '
      'ifSource
      '
      '
      'popMenu
      '
      Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuEksport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.popMenuCetak)})
      Me.popMenu.Manager = Me.barMan
      Me.popMenu.Name = "popMenu"
      '
      'xGrid
      '
      Me.xGrid.DataSource = Me.xpCol
      Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
      Me.xGrid.Location = New System.Drawing.Point(0, 0)
      Me.xGrid.MainView = Me.xGridView
      Me.xGrid.MenuManager = Me.barMan
      Me.xGrid.Name = "xGrid"
      Me.xGrid.Size = New System.Drawing.Size(888, 212)
      Me.xGrid.TabIndex = 5
      Me.xGrid.ToolTipController = Me.toolTip
      Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
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
      'SplitContainerControl1
      '
      Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainerControl1.Horizontal = False
      Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainerControl1.Name = "SplitContainerControl1"
      Me.SplitContainerControl1.Panel1.Controls.Add(Me.xGrid)
      Me.SplitContainerControl1.Panel1.Text = "Panel1"
      Me.SplitContainerControl1.Panel2.Text = "Panel2"
      Me.SplitContainerControl1.Size = New System.Drawing.Size(888, 378)
      Me.SplitContainerControl1.SplitterPosition = 212
      Me.SplitContainerControl1.TabIndex = 10
      Me.SplitContainerControl1.Text = "SplitContainerControl1"
      '
      'chartPopUp
      '
      Me.chartPopUp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.chartPopUpEkspor), New DevExpress.XtraBars.LinkPersistInfo(Me.chartPopUpCetak), New DevExpress.XtraBars.LinkPersistInfo(Me.chartPopUpAppearance, True), New DevExpress.XtraBars.LinkPersistInfo(Me.chartPopUpPallette), New DevExpress.XtraBars.LinkPersistInfo(Me.chartPopUpWizard)})
      Me.chartPopUp.Manager = Me.barMan
      Me.chartPopUp.Name = "chartPopUp"
      '
      'GridOutput
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(888, 405)
      Me.Controls.Add(Me.SplitContainerControl1)
      Me.Controls.Add(Me.barDockControlLeft)
      Me.Controls.Add(Me.barDockControlRight)
      Me.Controls.Add(Me.barDockControlBottom)
      Me.Controls.Add(Me.barDockControlTop)
      Me.Name = "GridOutput"
      Me.Text = "GridOutput"
      CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainerControl1.ResumeLayout(False)
      CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

    End Sub
    Public WithEvents barMan As DevExpress.XtraBars.BarManager
    Friend WithEvents barMenuRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barMenuFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents popMenuEksport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popMenuCetak As DevExpress.XtraBars.BarButtonItem
    Public WithEvents xpCol As DevExpress.Xpo.XPCollection
    Public WithEvents toolTip As DevExpress.Utils.ToolTipController
    Public WithEvents session As DevExpress.Xpo.UnitOfWork
    Public WithEvents ifSource As DevExpress.Xpo.XPInstantFeedbackSource
    Public WithEvents popMenu As DevExpress.XtraBars.PopupMenu
    Public WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Public WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barChart As DevExpress.XtraBars.BarButtonItem
    Public WithEvents barMenu As DevExpress.XtraBars.Bar
    Friend WithEvents chartPopUpEkspor As DevExpress.XtraBars.BarSubItem
    Friend WithEvents chartPopUpCetak As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chartPopUpAppearance As DevExpress.XtraBars.BarSubItem
    Friend WithEvents chartPopUpPallette As DevExpress.XtraBars.BarSubItem
    Friend WithEvents chartPopUpWizard As DevExpress.XtraBars.BarButtonItem
    Public WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Public WithEvents chartPopUp As DevExpress.XtraBars.PopupMenu
  End Class
End Namespace