<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohDataProduksi
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohDataProduksi))
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNoProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeItem = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaItem = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtySisa = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnShowSJ = New DevExpress.XtraBars.BarButtonItem()
		Me.colIdTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.ifSource = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
		Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
		Me.btnCetakData = New DevExpress.XtraBars.BarButtonItem()
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
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Tanggal Produksi"
		Me.GridColumn1.FieldName = "Tanggal"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.OptionsColumn.AllowEdit = False
		Me.GridColumn1.OptionsColumn.ReadOnly = True
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		'
		'colNoProduksi
		'
		Me.colNoProduksi.Caption = "No Produksi"
		Me.colNoProduksi.FieldName = "Kode"
		Me.colNoProduksi.Name = "colNoProduksi"
		Me.colNoProduksi.OptionsColumn.AllowEdit = False
		Me.colNoProduksi.OptionsColumn.ReadOnly = True
		Me.colNoProduksi.Visible = True
		Me.colNoProduksi.VisibleIndex = 1
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "No LOT"
		Me.GridColumn3.FieldName = "LOT"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.OptionsColumn.AllowEdit = False
		Me.GridColumn3.OptionsColumn.ReadOnly = True
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 2
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Qty"
		Me.GridColumn4.DisplayFormat.FormatString = "n0"
		Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.GridColumn4.FieldName = "QtyIN"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.OptionsColumn.AllowEdit = False
		Me.GridColumn4.OptionsColumn.ReadOnly = True
		Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyIN", "{0:n0}")})
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 5
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Qty SJ"
		Me.GridColumn5.DisplayFormat.FormatString = "n0"
		Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.GridColumn5.FieldName = "QtyKirim"
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.OptionsColumn.AllowEdit = False
		Me.GridColumn5.OptionsColumn.ReadOnly = True
		Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyKirim", "{0:n0}")})
		Me.GridColumn5.Visible = True
		Me.GridColumn5.VisibleIndex = 6
		'
		'colKodeItem
		'
		Me.colKodeItem.FieldName = "KodeItem"
		Me.colKodeItem.Name = "colKodeItem"
		Me.colKodeItem.Visible = True
		Me.colKodeItem.VisibleIndex = 3
		'
		'colNamaItem
		'
		Me.colNamaItem.FieldName = "NamaItem"
		Me.colNamaItem.Name = "colNamaItem"
		Me.colNamaItem.OptionsColumn.AllowEdit = False
		Me.colNamaItem.OptionsColumn.ReadOnly = True
		Me.colNamaItem.Visible = True
		Me.colNamaItem.VisibleIndex = 4
		'
		'colQtySisa
		'
		Me.colQtySisa.Caption = "Sisa"
		Me.colQtySisa.DisplayFormat.FormatString = "n0"
		Me.colQtySisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtySisa.FieldName = "QtySisa"
		Me.colQtySisa.Name = "colQtySisa"
		Me.colQtySisa.OptionsColumn.AllowEdit = False
		Me.colQtySisa.OptionsColumn.ReadOnly = True
		Me.colQtySisa.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtySisa", "{0:n0}")})
		Me.colQtySisa.Visible = True
		Me.colQtySisa.VisibleIndex = 7
		'
		'btnShowSJ
		'
		Me.btnShowSJ.Caption = "Show Data SJ"
		Me.btnShowSJ.Glyph = CType(resources.GetObject("btnShowSJ.Glyph"), System.Drawing.Image)
		Me.btnShowSJ.Id = 6
		Me.btnShowSJ.LargeGlyph = CType(resources.GetObject("btnShowSJ.LargeGlyph"), System.Drawing.Image)
		Me.btnShowSJ.Name = "btnShowSJ"
		'
		'colIdTransaksi
		'
		Me.colIdTransaksi.Caption = "ID"
		Me.colIdTransaksi.FieldName = "Id"
		Me.colIdTransaksi.Name = "colIdTransaksi"
		Me.colIdTransaksi.OptionsColumn.AllowEdit = False
		Me.colIdTransaksi.OptionsColumn.ReadOnly = True
		'
		'xGrid
		'
		Me.xGrid.DataSource = Me.ifSource
		Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xGrid.Location = New System.Drawing.Point(0, 0)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(934, 368)
		Me.xGrid.TabIndex = 1
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'ifSource
		'
		Me.ifSource.DisplayableProperties = "Id;Kode;KodeItem;NamaItem;Tanggal;LOT;QtyIN;QtyKirim;QtySisa"
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.FusohVwProduksi)
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colNoProduksi, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.colKodeItem, Me.colNamaItem, Me.colQtySisa, Me.colIdTransaksi})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowAutoFilterRow = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCetakData, Me.btnExport, Me.btnShowSJ, Me.btnRefresh})
		Me.BarManager1.MaxItemId = 6
		Me.BarManager1.StatusBar = Me.Bar3
		'
		'Bar3
		'
		Me.Bar3.BarName = "Status bar"
		Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
		Me.Bar3.DockCol = 0
		Me.Bar3.DockRow = 0
		Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
		Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetakData, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnShowSJ, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.Bar3.OptionsBar.AllowQuickCustomization = False
		Me.Bar3.OptionsBar.DrawDragBorder = False
		Me.Bar3.OptionsBar.UseWholeRow = True
		Me.Bar3.Text = "Status bar"
		'
		'btnRefresh
		'
		Me.btnRefresh.Caption = "Refresh"
		Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
		Me.btnRefresh.Id = 5
		Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
		Me.btnRefresh.Name = "btnRefresh"
		'
		'btnExport
		'
		Me.btnExport.Caption = "Export Data"
		Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
		Me.btnExport.Id = 4
		Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
		Me.btnExport.Name = "btnExport"
		'
		'btnCetakData
		'
		Me.btnCetakData.Caption = "Cetak Data"
		Me.btnCetakData.Glyph = CType(resources.GetObject("btnCetakData.Glyph"), System.Drawing.Image)
		Me.btnCetakData.Id = 0
		Me.btnCetakData.LargeGlyph = CType(resources.GetObject("btnCetakData.LargeGlyph"), System.Drawing.Image)
		Me.btnCetakData.Name = "btnCetakData"
		'
		'barDockControlTop
		'
		Me.barDockControlTop.CausesValidation = False
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Size = New System.Drawing.Size(934, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 368)
		Me.barDockControlBottom.Size = New System.Drawing.Size(934, 27)
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
		Me.barDockControlRight.Location = New System.Drawing.Point(934, 0)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 368)
		'
		'UI_FusohDataProduksi
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(934, 395)
		Me.Controls.Add(Me.xGrid)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.Name = "UI_FusohDataProduksi"
		Me.Text = "Data Produksi"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNoProduksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeItem As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaItem As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtySisa As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnShowSJ As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents colIdTransaksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Private WithEvents ifSource As DevExpress.Xpo.XPInstantFeedbackSource
	Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
	Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
	Friend WithEvents btnCetakData As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
	Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
End Class
