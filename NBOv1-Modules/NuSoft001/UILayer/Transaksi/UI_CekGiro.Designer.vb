<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_CekGiro
  Inherits Core.Win.Forms.GridOutput

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
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_CekGiro))
    Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.nChart = New DevExpress.XtraCharts.ChartControl()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCair = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnCairkanGiro = New DevExpress.XtraBars.BarButtonItem()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager()
    Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
    Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
    Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
    Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
    Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
    Me.btnGM = New DevExpress.XtraBars.BarButtonItem()
    Me.btnGK = New DevExpress.XtraBars.BarButtonItem()
    Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBuktiCair = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerControl1.SuspendLayout()
    CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nChart, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCairkanGiro, Me.BarSubItem3, Me.btnGM, Me.btnGK})
    Me.barMan.MaxItemId = 28
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.ViewGiro)
    '
    'xGrid
    '
    Me.xGrid.DataSource = Nothing
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
    Me.xGrid.Size = New System.Drawing.Size(888, 195)
    '
    'xGridView
    '
    Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.xGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.xGridView.Appearance.ViewCaption.Options.UseTextOptions = True
    Me.xGridView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.colNilai, Me.colCair, Me.colBuktiCair, Me.colTipe})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    Me.xGridView.OptionsView.ShowViewCaption = True
    Me.xGridView.ViewCaption = "Data Giro Masuk"
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem3, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCairkanGiro, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'SplitContainerControl1
    '
    Me.SplitContainerControl1.Panel2.Controls.Add(Me.nChart)
    Me.SplitContainerControl1.SplitterPosition = 195
    '
    'colID
    '
    Me.colID.Caption = "ID"
    Me.colID.FieldName = "Id"
    Me.colID.Name = "colID"
    '
    'RepositoryItemCheckEdit1
    '
    Me.RepositoryItemCheckEdit1.AutoHeight = False
    Me.RepositoryItemCheckEdit1.Caption = "Check"
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    '
    'RepositoryItemCheckEdit2
    '
    Me.RepositoryItemCheckEdit2.AutoHeight = False
    Me.RepositoryItemCheckEdit2.Caption = "Check"
    Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
    '
    'nChart
    '
    XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
    XyDiagram1.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
    XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
    Me.nChart.Diagram = XyDiagram1
    Me.nChart.Dock = System.Windows.Forms.DockStyle.Fill
    Me.nChart.EmptyChartText.Text = "Data Kosong"
    Me.nChart.Location = New System.Drawing.Point(0, 0)
    Me.nChart.Name = "nChart"
    Series1.ArgumentDataMember = "SelisihHariNama"
    PointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
    PointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
    Series1.LegendPointOptions = PointOptions1
    Series1.LegendText = "Legend"
    Series1.Name = "Series 1"
    Series1.SummaryFunction = "SUM([Nilai])"
    Series1.SynchronizePointOptions = False
    SideBySideBarSeriesView1.ColorEach = True
    Series1.View = SideBySideBarSeriesView1
    Me.nChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
    Me.nChart.Size = New System.Drawing.Size(888, 178)
    Me.nChart.TabIndex = 0
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "No Bukti"
    Me.GridColumn1.FieldName = "NoBukti.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tanggal"
    Me.GridColumn2.FieldName = "NoBukti.Tanggal"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "No Giro"
    Me.GridColumn3.FieldName = "NoGiro"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Bank"
    Me.GridColumn4.FieldName = "Bank"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "AC No"
    Me.GridColumn5.FieldName = "NoACBank"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Tgl Tempo"
    Me.GridColumn6.FieldName = "TglJatuhTempo"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    '
    'colCair
    '
    Me.colCair.Caption = "Cair"
    Me.colCair.ColumnEdit = Me.RepositoryItemCheckEdit2
    Me.colCair.FieldName = "Status"
    Me.colCair.Name = "colCair"
    Me.colCair.Visible = True
    Me.colCair.VisibleIndex = 7
    '
    'colNilai
    '
    Me.colNilai.Caption = "Nilai"
    Me.colNilai.FieldName = "Nilai"
    Me.colNilai.Name = "colNilai"
    Me.colNilai.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colNilai.Visible = True
    Me.colNilai.VisibleIndex = 6
    '
    'btnCairkanGiro
    '
    Me.btnCairkanGiro.Caption = "Cairkan Giro"
    Me.btnCairkanGiro.Glyph = CType(resources.GetObject("btnCairkanGiro.Glyph"), System.Drawing.Image)
    Me.btnCairkanGiro.Id = 24
    Me.btnCairkanGiro.LargeGlyph = CType(resources.GetObject("btnCairkanGiro.LargeGlyph"), System.Drawing.Image)
    Me.btnCairkanGiro.Name = "btnCairkanGiro"
    '
    'BarManager1
    '
    Me.BarManager1.DockControls.Add(Me.BarDockControl1)
    Me.BarManager1.DockControls.Add(Me.BarDockControl2)
    Me.BarManager1.DockControls.Add(Me.BarDockControl3)
    Me.BarManager1.DockControls.Add(Me.BarDockControl4)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2})
    Me.BarManager1.MaxItemId = 2
    '
    'BarDockControl1
    '
    Me.BarDockControl1.CausesValidation = False
    Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
    Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
    Me.BarDockControl1.Size = New System.Drawing.Size(888, 0)
    '
    'BarDockControl2
    '
    Me.BarDockControl2.CausesValidation = False
    Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.BarDockControl2.Location = New System.Drawing.Point(0, 405)
    Me.BarDockControl2.Size = New System.Drawing.Size(888, 0)
    '
    'BarDockControl3
    '
    Me.BarDockControl3.CausesValidation = False
    Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
    Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
    Me.BarDockControl3.Size = New System.Drawing.Size(0, 405)
    '
    'BarDockControl4
    '
    Me.BarDockControl4.CausesValidation = False
    Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
    Me.BarDockControl4.Location = New System.Drawing.Point(888, 0)
    Me.BarDockControl4.Size = New System.Drawing.Size(0, 405)
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Caption = "Filter"
    Me.BarSubItem1.Id = 0
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'BarSubItem2
    '
    Me.BarSubItem2.Caption = "Filter"
    Me.BarSubItem2.Id = 1
    Me.BarSubItem2.Name = "BarSubItem2"
    '
    'BarSubItem3
    '
    Me.BarSubItem3.Caption = "Filter"
    Me.BarSubItem3.Glyph = CType(resources.GetObject("BarSubItem3.Glyph"), System.Drawing.Image)
    Me.BarSubItem3.Id = 25
    Me.BarSubItem3.LargeGlyph = CType(resources.GetObject("BarSubItem3.LargeGlyph"), System.Drawing.Image)
    Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGK, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.BarSubItem3.Name = "BarSubItem3"
    '
    'btnGM
    '
    Me.btnGM.Caption = "Giro Masuk"
    Me.btnGM.Glyph = CType(resources.GetObject("btnGM.Glyph"), System.Drawing.Image)
    Me.btnGM.Id = 26
    Me.btnGM.LargeGlyph = CType(resources.GetObject("btnGM.LargeGlyph"), System.Drawing.Image)
    Me.btnGM.Name = "btnGM"
    '
    'btnGK
    '
    Me.btnGK.Caption = "Giro Keluar"
    Me.btnGK.Glyph = CType(resources.GetObject("btnGK.Glyph"), System.Drawing.Image)
    Me.btnGK.Id = 27
    Me.btnGK.LargeGlyph = CType(resources.GetObject("btnGK.LargeGlyph"), System.Drawing.Image)
    Me.btnGK.Name = "btnGK"
    '
    'colTipe
    '
    Me.colTipe.Caption = "Tipe"
    Me.colTipe.FieldName = "Tipe"
    Me.colTipe.Name = "colTipe"
    '
    'colBuktiCair
    '
    Me.colBuktiCair.Caption = "No Bukti Cair"
    Me.colBuktiCair.FieldName = "NoBuktiCair.Kode"
    Me.colBuktiCair.Name = "colBuktiCair"
    Me.colBuktiCair.Visible = True
    Me.colBuktiCair.VisibleIndex = 8
    '
    'UI_CekGiro
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(888, 405)
    Me.Controls.Add(Me.BarDockControl3)
    Me.Controls.Add(Me.BarDockControl4)
    Me.Controls.Add(Me.BarDockControl2)
    Me.Controls.Add(Me.BarDockControl1)
    Me.Name = "UI_CekGiro"
    Me.Text = "Cek/Giro"
    Me.xpCol = Me.xpCol
    Me.Controls.SetChildIndex(Me.BarDockControl1, 0)
    Me.Controls.SetChildIndex(Me.BarDockControl2, 0)
    Me.Controls.SetChildIndex(Me.BarDockControl4, 0)
    Me.Controls.SetChildIndex(Me.BarDockControl3, 0)
    Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerControl1.ResumeLayout(False)
    CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nChart, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents nChart As DevExpress.XtraCharts.ChartControl
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCair As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnCairkanGiro As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents btnGM As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnGK As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBuktiCair As DevExpress.XtraGrid.Columns.GridColumn
End Class
