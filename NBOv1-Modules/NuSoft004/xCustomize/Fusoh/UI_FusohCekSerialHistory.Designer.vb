<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohCekSerialHistory
	Inherits Core.Win.Forms.BlankForm

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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohCekSerialHistory))
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSisaLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xGrid.Location = New System.Drawing.Point(0, 0)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(860, 348)
		Me.xGrid.TabIndex = 0
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn5, Me.colQtyIn, Me.GridColumn4, Me.colQtyOut, Me.colSisaLength, Me.GridColumn3})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "No Bukti"
		Me.GridColumn1.FieldName = "NoBukti"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		Me.GridColumn1.Width = 137
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Tanggal"
		Me.GridColumn2.DisplayFormat.FormatString = "D"
		Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.GridColumn2.FieldName = "Tanggal"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		Me.GridColumn2.Width = 137
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Gudang"
		Me.GridColumn5.FieldName = "Gudang"
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.Visible = True
		Me.GridColumn5.VisibleIndex = 2
		Me.GridColumn5.Width = 183
		'
		'colQtyIn
		'
		Me.colQtyIn.AppearanceHeader.Options.UseTextOptions = True
		Me.colQtyIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQtyIn.Caption = "Length In"
		Me.colQtyIn.DisplayFormat.FormatString = "n0"
		Me.colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyIn.FieldName = "LengthIn"
		Me.colQtyIn.Name = "colQtyIn"
		Me.colQtyIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LengthIn", "{0:n0}")})
		Me.colQtyIn.Visible = True
		Me.colQtyIn.VisibleIndex = 3
		Me.colQtyIn.Width = 95
		'
		'colQtyOut
		'
		Me.colQtyOut.AppearanceHeader.Options.UseTextOptions = True
		Me.colQtyOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQtyOut.Caption = "Length Out"
		Me.colQtyOut.DisplayFormat.FormatString = "n0"
		Me.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyOut.FieldName = "LengthOut"
		Me.colQtyOut.Name = "colQtyOut"
		Me.colQtyOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LengthOut", "{0:n0}")})
		Me.colQtyOut.Visible = True
		Me.colQtyOut.VisibleIndex = 5
		Me.colQtyOut.Width = 88
		'
		'colSisaLength
		'
		Me.colSisaLength.AppearanceHeader.Options.UseTextOptions = True
		Me.colSisaLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colSisaLength.Caption = "SisaLength"
		Me.colSisaLength.DisplayFormat.FormatString = "n0"
		Me.colSisaLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSisaLength.FieldName = "colSisaLength"
		Me.colSisaLength.Name = "colSisaLength"
		Me.colSisaLength.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colSisaLength", "{0:n0}")})
		Me.colSisaLength.UnboundExpression = "[LengthIn] - [LengthOut] - [SisaDempyou]"
		Me.colSisaLength.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colSisaLength.Visible = True
		Me.colSisaLength.VisibleIndex = 6
		Me.colSisaLength.Width = 107
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Kode Dempyou"
		Me.GridColumn3.FieldName = "KodeDempyou"
		Me.GridColumn3.Name = "GridColumn3"
		'
		'GridColumn4
		'
		Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
		Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.GridColumn4.Caption = "Length Dempyou"
		Me.GridColumn4.DisplayFormat.FormatString = "n0"
		Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.GridColumn4.FieldName = "SisaDempyou"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SisaDempyou", "{0:n0}")})
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 4
		Me.GridColumn4.Width = 95
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExport})
		Me.BarManager1.MaxItemId = 1
		Me.BarManager1.StatusBar = Me.Bar3
		'
		'Bar3
		'
		Me.Bar3.BarName = "Status bar"
		Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
		Me.Bar3.DockCol = 0
		Me.Bar3.DockRow = 0
		Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
		Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.Bar3.OptionsBar.AllowQuickCustomization = False
		Me.Bar3.OptionsBar.DrawDragBorder = False
		Me.Bar3.OptionsBar.UseWholeRow = True
		Me.Bar3.Text = "Status bar"
		'
		'btnExport
		'
		Me.btnExport.Caption = "Export"
		Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
		Me.btnExport.Id = 0
		Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
		Me.btnExport.Name = "btnExport"
		'
		'barDockControlTop
		'
		Me.barDockControlTop.CausesValidation = False
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Size = New System.Drawing.Size(860, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 348)
		Me.barDockControlBottom.Size = New System.Drawing.Size(860, 27)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 348)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(860, 0)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 348)
		'
		'UI_FusohCekSerialHistory
		'
		Me.AllowMdiBar = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(860, 375)
		Me.Controls.Add(Me.xGrid)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.IsMdiContainer = True
		Me.MinimizeBox = False
		Me.Name = "UI_FusohCekSerialHistory"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "History Stock"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyIn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSisaLength As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
	Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
