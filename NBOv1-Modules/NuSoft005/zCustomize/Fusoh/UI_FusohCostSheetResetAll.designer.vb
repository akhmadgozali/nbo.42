<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohCostSheetResetAll
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
		Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohCostSheetResetAll))
		Me.xGridViewOut = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colNoPenerimaan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSubtotal1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSubtotal2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colNoInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colVendor = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNomorPO = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotalInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotalCostSheet = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotalInvoiceCostSheet = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDetailSNRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.xGridViewIn = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colInKodePart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colInNamaPart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnStartReset = New DevExpress.XtraBars.BarButtonItem()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridViewOut, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colDetailSNRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridViewIn, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGridViewOut
		'
		Me.xGridViewOut.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoPenerimaan, Me.colKodeBarang, Me.colNamaBarang, Me.colQty1, Me.colHarga1, Me.colSubtotal1, Me.colHarga2, Me.colSubtotal2})
		Me.xGridViewOut.GridControl = Me.xGrid
		Me.xGridViewOut.Name = "xGridViewOut"
		Me.xGridViewOut.OptionsBehavior.Editable = False
		Me.xGridViewOut.OptionsDetail.EnableMasterViewMode = False
		Me.xGridViewOut.OptionsView.ShowFooter = True
		Me.xGridViewOut.OptionsView.ShowGroupPanel = False
		'
		'colNoPenerimaan
		'
		Me.colNoPenerimaan.Caption = "No. Penerimaan"
		Me.colNoPenerimaan.FieldName = "NoPenerimaan"
		Me.colNoPenerimaan.Name = "colNoPenerimaan"
		Me.colNoPenerimaan.Visible = True
		Me.colNoPenerimaan.VisibleIndex = 0
		'
		'colKodeBarang
		'
		Me.colKodeBarang.Caption = "Part No."
		Me.colKodeBarang.FieldName = "KodeBarang"
		Me.colKodeBarang.Name = "colKodeBarang"
		Me.colKodeBarang.Visible = True
		Me.colKodeBarang.VisibleIndex = 1
		'
		'colNamaBarang
		'
		Me.colNamaBarang.Caption = "Material"
		Me.colNamaBarang.FieldName = "NamaBarang"
		Me.colNamaBarang.Name = "colNamaBarang"
		Me.colNamaBarang.Visible = True
		Me.colNamaBarang.VisibleIndex = 2
		'
		'colQty1
		'
		Me.colQty1.AppearanceHeader.Options.UseTextOptions = True
		Me.colQty1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQty1.Caption = "Qty"
		Me.colQty1.DisplayFormat.FormatString = "n2"
		Me.colQty1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQty1.FieldName = "Qty"
		Me.colQty1.Name = "colQty1"
		Me.colQty1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n2}")})
		Me.colQty1.Visible = True
		Me.colQty1.VisibleIndex = 3
		'
		'colHarga1
		'
		Me.colHarga1.AppearanceHeader.Options.UseTextOptions = True
		Me.colHarga1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHarga1.Caption = "Harga"
		Me.colHarga1.DisplayFormat.FormatString = "n2"
		Me.colHarga1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga1.FieldName = "Harga"
		Me.colHarga1.Name = "colHarga1"
		Me.colHarga1.Visible = True
		Me.colHarga1.VisibleIndex = 4
		'
		'colSubtotal1
		'
		Me.colSubtotal1.AppearanceHeader.Options.UseTextOptions = True
		Me.colSubtotal1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colSubtotal1.Caption = "Subtotal"
		Me.colSubtotal1.DisplayFormat.FormatString = "n2"
		Me.colSubtotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSubtotal1.FieldName = "Subtotal"
		Me.colSubtotal1.Name = "colSubtotal1"
		Me.colSubtotal1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "{0:n2}")})
		Me.colSubtotal1.Visible = True
		Me.colSubtotal1.VisibleIndex = 5
		'
		'colHarga2
		'
		Me.colHarga2.AppearanceHeader.Options.UseTextOptions = True
		Me.colHarga2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHarga2.Caption = "Harga Reset"
		Me.colHarga2.DisplayFormat.FormatString = "n2"
		Me.colHarga2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga2.FieldName = "HargaReset"
		Me.colHarga2.Name = "colHarga2"
		Me.colHarga2.Visible = True
		Me.colHarga2.VisibleIndex = 6
		'
		'colSubtotal2
		'
		Me.colSubtotal2.AppearanceHeader.Options.UseTextOptions = True
		Me.colSubtotal2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colSubtotal2.Caption = "Subtotal Reset"
		Me.colSubtotal2.DisplayFormat.FormatString = "n2"
		Me.colSubtotal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSubtotal2.FieldName = "SubtotalReset"
		Me.colSubtotal2.Name = "colSubtotal2"
		Me.colSubtotal2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalReset", "{0:n2}")})
		Me.colSubtotal2.Visible = True
		Me.colSubtotal2.VisibleIndex = 7
		'
		'xGrid
		'
		Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
		GridLevelNode1.LevelTemplate = Me.xGridViewOut
		GridLevelNode1.RelationName = "Detail"
		Me.xGrid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
		Me.xGrid.Location = New System.Drawing.Point(0, 0)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colDetailSNRepo})
		Me.xGrid.Size = New System.Drawing.Size(938, 379)
		Me.xGrid.TabIndex = 0
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView, Me.xGridViewIn, Me.xGridViewOut})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoInvoice, Me.colTanggal, Me.colVendor, Me.colNomorPO, Me.colTotalInvoice, Me.colTotalCostSheet, Me.colTotalInvoiceCostSheet, Me.colStatus})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsView.ShowAutoFilterRow = True
		Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colNoInvoice
		'
		Me.colNoInvoice.Caption = "No. Invoice"
		Me.colNoInvoice.FieldName = "NomorInvoice"
		Me.colNoInvoice.Name = "colNoInvoice"
		Me.colNoInvoice.Visible = True
		Me.colNoInvoice.VisibleIndex = 0
		Me.colNoInvoice.Width = 100
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		Me.colTanggal.Width = 76
		'
		'colVendor
		'
		Me.colVendor.Caption = "Vendor"
		Me.colVendor.FieldName = "Vendor"
		Me.colVendor.Name = "colVendor"
		Me.colVendor.Visible = True
		Me.colVendor.VisibleIndex = 2
		Me.colVendor.Width = 130
		'
		'colNomorPO
		'
		Me.colNomorPO.Caption = "Nomor PO"
		Me.colNomorPO.FieldName = "NomorPO"
		Me.colNomorPO.Name = "colNomorPO"
		Me.colNomorPO.Visible = True
		Me.colNomorPO.VisibleIndex = 3
		Me.colNomorPO.Width = 80
		'
		'colTotalInvoice
		'
		Me.colTotalInvoice.AppearanceHeader.Options.UseTextOptions = True
		Me.colTotalInvoice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colTotalInvoice.Caption = "Total Invoice"
		Me.colTotalInvoice.DisplayFormat.FormatString = "n2"
		Me.colTotalInvoice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colTotalInvoice.FieldName = "TotalInvoice"
		Me.colTotalInvoice.Name = "colTotalInvoice"
		Me.colTotalInvoice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalInvoice", "{0:n2}")})
		Me.colTotalInvoice.Visible = True
		Me.colTotalInvoice.VisibleIndex = 4
		Me.colTotalInvoice.Width = 85
		'
		'colTotalCostSheet
		'
		Me.colTotalCostSheet.AppearanceHeader.Options.UseTextOptions = True
		Me.colTotalCostSheet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colTotalCostSheet.Caption = "Total Cost Sheet"
		Me.colTotalCostSheet.DisplayFormat.FormatString = "n2"
		Me.colTotalCostSheet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colTotalCostSheet.FieldName = "TotalCostSheet"
		Me.colTotalCostSheet.Name = "colTotalCostSheet"
		Me.colTotalCostSheet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCostSheet", "{0:n2}")})
		Me.colTotalCostSheet.Visible = True
		Me.colTotalCostSheet.VisibleIndex = 5
		Me.colTotalCostSheet.Width = 80
		'
		'colTotalInvoiceCostSheet
		'
		Me.colTotalInvoiceCostSheet.AppearanceHeader.Options.UseTextOptions = True
		Me.colTotalInvoiceCostSheet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colTotalInvoiceCostSheet.Caption = "Total Invoice + Cost Sheet"
		Me.colTotalInvoiceCostSheet.DisplayFormat.FormatString = "n2"
		Me.colTotalInvoiceCostSheet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colTotalInvoiceCostSheet.FieldName = "TotalInvoiceCostSheet"
		Me.colTotalInvoiceCostSheet.Name = "colTotalInvoiceCostSheet"
		Me.colTotalInvoiceCostSheet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalInvoiceCostSheet", "{0:n2}")})
		Me.colTotalInvoiceCostSheet.Visible = True
		Me.colTotalInvoiceCostSheet.VisibleIndex = 6
		Me.colTotalInvoiceCostSheet.Width = 85
		'
		'colStatus
		'
		Me.colStatus.Caption = "Status"
		Me.colStatus.FieldName = "Status"
		Me.colStatus.Name = "colStatus"
		Me.colStatus.Visible = True
		Me.colStatus.VisibleIndex = 7
		Me.colStatus.Width = 49
		'
		'colDetailSNRepo
		'
		Me.colDetailSNRepo.AutoHeight = False
		Me.colDetailSNRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.colDetailSNRepo.Name = "colDetailSNRepo"
		Me.colDetailSNRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
		'
		'xGridViewIn
		'
		Me.xGridViewIn.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInKodePart, Me.colInNamaPart, Me.colQty})
		Me.xGridViewIn.GridControl = Me.xGrid
		Me.xGridViewIn.Name = "xGridViewIn"
		Me.xGridViewIn.OptionsBehavior.Editable = False
		Me.xGridViewIn.OptionsDetail.EnableMasterViewMode = False
		Me.xGridViewIn.OptionsView.ShowFooter = True
		Me.xGridViewIn.OptionsView.ShowGroupPanel = False
		'
		'colInKodePart
		'
		Me.colInKodePart.Caption = "Kode Part"
		Me.colInKodePart.FieldName = "KodePart"
		Me.colInKodePart.Name = "colInKodePart"
		Me.colInKodePart.Visible = True
		Me.colInKodePart.VisibleIndex = 0
		'
		'colInNamaPart
		'
		Me.colInNamaPart.Caption = "Nama Part"
		Me.colInNamaPart.FieldName = "NamaPart"
		Me.colInNamaPart.Name = "colInNamaPart"
		Me.colInNamaPart.Visible = True
		Me.colInNamaPart.VisibleIndex = 1
		'
		'colQty
		'
		Me.colQty.AppearanceHeader.Options.UseTextOptions = True
		Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colQty.Caption = "Qty"
		Me.colQty.DisplayFormat.FormatString = "n2"
		Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n2}")})
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 2
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnStartReset})
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
		Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnStartReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.Bar3.OptionsBar.AllowQuickCustomization = False
		Me.Bar3.OptionsBar.DrawDragBorder = False
		Me.Bar3.OptionsBar.UseWholeRow = True
		Me.Bar3.Text = "Status bar"
		'
		'btnStartReset
		'
		Me.btnStartReset.Caption = "Start Reset"
		Me.btnStartReset.Glyph = CType(resources.GetObject("btnStartReset.Glyph"), System.Drawing.Image)
		Me.btnStartReset.Id = 0
		Me.btnStartReset.LargeGlyph = CType(resources.GetObject("btnStartReset.LargeGlyph"), System.Drawing.Image)
		Me.btnStartReset.Name = "btnStartReset"
		'
		'barDockControlTop
		'
		Me.barDockControlTop.CausesValidation = False
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Size = New System.Drawing.Size(938, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 379)
		Me.barDockControlBottom.Size = New System.Drawing.Size(938, 27)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 379)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(938, 0)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 379)
		'
		'UI_FusohCostSheetResetAll
		'
		Me.AllowMdiBar = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(938, 406)
		Me.Controls.Add(Me.xGrid)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.IsMdiContainer = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "UI_FusohCostSheetResetAll"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Reset HPP"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridViewOut, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colDetailSNRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridViewIn, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colNoInvoice As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalInvoice As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
	Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
	Friend WithEvents btnStartReset As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colVendor As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNomorPO As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDetailSNRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalCostSheet As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalInvoiceCostSheet As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents xGridViewOut As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents xGridViewIn As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colInKodePart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colInNamaPart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNoPenerimaan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHarga1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSubtotal1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHarga2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSubtotal2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
