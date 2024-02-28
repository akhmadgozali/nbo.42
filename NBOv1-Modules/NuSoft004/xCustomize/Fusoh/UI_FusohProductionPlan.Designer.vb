<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohProductionPlan
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohProductionPlan))
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition9 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition10 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition11 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition12 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition13 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Me.colQtyDrill = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUrgent = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIsFinish = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyCutting = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyKampuh = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
    Me.btnTampilkan = New DevExpress.XtraEditors.SimpleButton()
    Me.txtFTanggalAkhir = New DevExpress.XtraEditors.DateEdit()
    Me.txtFTanggalAwal = New DevExpress.XtraEditors.DateEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoPDO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNomorPO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPOLine = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colMaterialSize = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colFGSize = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyFinishGoods = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyDelivery = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.SimpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.SimpleLabelItem4 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.colQtyAdjust = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKetAdjust = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtFTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colQtyDrill
        '
        Me.colQtyDrill.AppearanceCell.Options.UseTextOptions = True
        Me.colQtyDrill.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyDrill.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyDrill.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyDrill.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtyDrill.Caption = "Qty Drill"
        Me.colQtyDrill.DisplayFormat.FormatString = "n0"
        Me.colQtyDrill.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyDrill.FieldName = "QtyDrill"
        Me.colQtyDrill.Name = "colQtyDrill"
        Me.colQtyDrill.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyDrill", "{0:n0}")})
        Me.colQtyDrill.Visible = True
        Me.colQtyDrill.VisibleIndex = 15
        Me.colQtyDrill.Width = 50
        '
        'colUrgent
        '
        Me.colUrgent.Caption = "Urgent"
        Me.colUrgent.FieldName = "Dempyou.Urgent"
        Me.colUrgent.Name = "colUrgent"
        '
        'colIsFinish
        '
        Me.colIsFinish.Caption = "IsFinish"
        Me.colIsFinish.FieldName = "IsFinish"
        Me.colIsFinish.Name = "colIsFinish"
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 20
        '
        'colQtyCutting
        '
        Me.colQtyCutting.AppearanceCell.Options.UseTextOptions = True
        Me.colQtyCutting.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyCutting.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyCutting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyCutting.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtyCutting.Caption = "Qty Cutting"
        Me.colQtyCutting.DisplayFormat.FormatString = "n0"
        Me.colQtyCutting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyCutting.FieldName = "QtyCutting"
        Me.colQtyCutting.Name = "colQtyCutting"
        Me.colQtyCutting.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyCutting", "{0:n0}")})
        Me.colQtyCutting.Visible = True
        Me.colQtyCutting.VisibleIndex = 13
        Me.colQtyCutting.Width = 50
        '
        'colQtyKampuh
        '
        Me.colQtyKampuh.AppearanceCell.Options.UseTextOptions = True
        Me.colQtyKampuh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyKampuh.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyKampuh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyKampuh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtyKampuh.Caption = "Qty Kampuh"
        Me.colQtyKampuh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyKampuh.FieldName = "QtyKampuh"
        Me.colQtyKampuh.Name = "colQtyKampuh"
        Me.colQtyKampuh.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyKampuh", "{0:n0}")})
        Me.colQtyKampuh.Visible = True
        Me.colQtyKampuh.VisibleIndex = 14
        Me.colQtyKampuh.Width = 50
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnExport)
        Me.LayoutControl1.Controls.Add(Me.btnTampilkan)
        Me.LayoutControl1.Controls.Add(Me.txtFTanggalAkhir)
        Me.LayoutControl1.Controls.Add(Me.txtFTanggalAwal)
        Me.LayoutControl1.Controls.Add(Me.xGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(378, 388, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(904, 393)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(604, 43)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(116, 22)
        Me.btnExport.StyleController = Me.LayoutControl1
        Me.btnExport.TabIndex = 9
        Me.btnExport.Text = "Export Excell"
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Image = CType(resources.GetObject("btnTampilkan.Image"), System.Drawing.Image)
        Me.btnTampilkan.Location = New System.Drawing.Point(484, 43)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(116, 22)
        Me.btnTampilkan.StyleController = Me.LayoutControl1
        Me.btnTampilkan.TabIndex = 8
        Me.btnTampilkan.Text = "Tampilkan Data"
        '
        'txtFTanggalAkhir
        '
        Me.txtFTanggalAkhir.EditValue = Nothing
        Me.txtFTanggalAkhir.Location = New System.Drawing.Point(285, 43)
        Me.txtFTanggalAkhir.Name = "txtFTanggalAkhir"
        Me.txtFTanggalAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFTanggalAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFTanggalAkhir.Size = New System.Drawing.Size(185, 20)
        Me.txtFTanggalAkhir.StyleController = Me.LayoutControl1
        Me.txtFTanggalAkhir.TabIndex = 6
        '
        'txtFTanggalAwal
        '
        Me.txtFTanggalAwal.EditValue = Nothing
        Me.txtFTanggalAwal.Location = New System.Drawing.Point(77, 43)
        Me.txtFTanggalAwal.Name = "txtFTanggalAwal"
        Me.txtFTanggalAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFTanggalAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFTanggalAwal.Size = New System.Drawing.Size(168, 20)
        Me.txtFTanggalAwal.StyleController = Me.LayoutControl1
        Me.txtFTanggalAwal.TabIndex = 5
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(12, 81)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.Size = New System.Drawing.Size(880, 268)
        Me.xGrid.TabIndex = 4
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xGridView.Appearance.GroupPanel.Options.UseFont = True
        Me.xGridView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xGridView.Appearance.GroupRow.Options.UseFont = True
        Me.xGridView.ColumnPanelRowHeight = 35
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomer, Me.GridColumn1, Me.colNoPDO, Me.colPartNo, Me.GridColumn3, Me.colPartName, Me.colNomorPO, Me.colPOLine, Me.colDueDate, Me.colMaterialSize, Me.colFGSize, Me.colQty, Me.GridColumn2, Me.colMachine, Me.colQtyCutting, Me.colQtyKampuh, Me.colQtyDrill, Me.colQtyFinishGoods, Me.colQtyDelivery, Me.colQtyAdjust, Me.colKetAdjust, Me.colStatus, Me.colIsFinish, Me.colUrgent})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.colQtyDrill
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colUrgent
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colIsFinish
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = True
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Column = Me.colStatus
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition4.Expression = "[IsFinish] == False"
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.Column = Me.colQtyCutting
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition5.Expression = "[IsFinish] == False And [QtyCutting] <= 0"
        StyleFormatCondition6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition6.Appearance.Options.UseBackColor = True
        StyleFormatCondition6.Column = Me.colQtyCutting
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition6.Expression = "[IsFinish] == False And [QtyCutting] > 0 And [QtyCutting] < [Dempyou.Qty]"
        StyleFormatCondition7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition7.Appearance.Options.UseBackColor = True
        StyleFormatCondition7.Column = Me.colQtyCutting
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition7.Expression = "[IsFinish] == False And [QtyCutting] >= [Dempyou.Qty]"
        StyleFormatCondition8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition8.Appearance.Options.UseBackColor = True
        StyleFormatCondition8.Column = Me.colQtyKampuh
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition8.Expression = "[IsFinish] == False And [QtyKampuh] <= 0"
        StyleFormatCondition9.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition9.Appearance.Options.UseBackColor = True
        StyleFormatCondition9.Column = Me.colQtyKampuh
        StyleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition9.Expression = "[IsFinish] == False And [QtyKampuh] > 0 And [QtyKampuh] < [Dempyou.Qty]"
        StyleFormatCondition10.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition10.Appearance.Options.UseBackColor = True
        StyleFormatCondition10.Column = Me.colQtyKampuh
        StyleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition10.Expression = "[IsFinish] == False And [QtyKampuh] >= [Dempyou.Qty]"
        StyleFormatCondition11.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition11.Appearance.Options.UseBackColor = True
        StyleFormatCondition11.Column = Me.colQtyDrill
        StyleFormatCondition11.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition11.Expression = "[IsFinish] == False And [QtyDrill] != null And [QtyDrill] <= 0"
        StyleFormatCondition12.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition12.Appearance.Options.UseBackColor = True
        StyleFormatCondition12.Column = Me.colQtyDrill
        StyleFormatCondition12.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition12.Expression = "[IsFinish] == False And [QtyDrill] != null And [QtyDrill] > 0 And [QtyDrill] < [D" &
    "empyou.Qty]"
        StyleFormatCondition13.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition13.Appearance.Options.UseBackColor = True
        StyleFormatCondition13.Column = Me.colQtyDrill
        StyleFormatCondition13.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition13.Expression = "[IsFinish] == False And [QtyDrill] != null And [QtyDrill] >= [Dempyou.Qty]"
        Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6, StyleFormatCondition7, StyleFormatCondition8, StyleFormatCondition9, StyleFormatCondition10, StyleFormatCondition11, StyleFormatCondition12, StyleFormatCondition13})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.GroupCount = 1
        Me.xGridView.Name = "xGridView"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsView.ColumnAutoWidth = False
        Me.xGridView.OptionsView.ShowAutoFilterRow = True
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCustomer, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer"
        Me.colCustomer.FieldName = "Dempyou.Pelanggan.Nama"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "No LOT"
        Me.GridColumn1.FieldName = "Dempyou.NomorLot"
        Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 88
        '
        'colNoPDO
        '
        Me.colNoPDO.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoPDO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoPDO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colNoPDO.Caption = "Nomor PDO"
        Me.colNoPDO.FieldName = "Dempyou.NomorPDO"
        Me.colNoPDO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colNoPDO.Name = "colNoPDO"
        Me.colNoPDO.Visible = True
        Me.colNoPDO.VisibleIndex = 1
        Me.colNoPDO.Width = 90
        '
        'colPartNo
        '
        Me.colPartNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPartNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPartNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPartNo.Caption = "Part Number"
        Me.colPartNo.FieldName = "Dempyou.SODetail.Barang.Kode"
        Me.colPartNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colPartNo.Name = "colPartNo"
        Me.colPartNo.Visible = True
        Me.colPartNo.VisibleIndex = 2
        Me.colPartNo.Width = 100
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "No Dempyou"
        Me.GridColumn3.FieldName = "Dempyou.Kode"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'colPartName
        '
        Me.colPartName.AppearanceHeader.Options.UseTextOptions = True
        Me.colPartName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPartName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPartName.Caption = "Part Name"
        Me.colPartName.FieldName = "Dempyou.SODetail.Barang.NamaPart"
        Me.colPartName.Name = "colPartName"
        Me.colPartName.Visible = True
        Me.colPartName.VisibleIndex = 3
        Me.colPartName.Width = 130
        '
        'colNomorPO
        '
        Me.colNomorPO.AppearanceCell.Options.UseTextOptions = True
        Me.colNomorPO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNomorPO.AppearanceHeader.Options.UseTextOptions = True
        Me.colNomorPO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNomorPO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colNomorPO.Caption = "Nomor PO"
        Me.colNomorPO.FieldName = "Dempyou.SODetail.Main.NomorPO"
        Me.colNomorPO.Name = "colNomorPO"
        Me.colNomorPO.Visible = True
        Me.colNomorPO.VisibleIndex = 5
        Me.colNomorPO.Width = 76
        '
        'colPOLine
        '
        Me.colPOLine.AppearanceCell.Options.UseTextOptions = True
        Me.colPOLine.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOLine.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOLine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOLine.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPOLine.Caption = "PO Line"
        Me.colPOLine.FieldName = "Dempyou.SODetail.POLine"
        Me.colPOLine.Name = "colPOLine"
        Me.colPOLine.Visible = True
        Me.colPOLine.VisibleIndex = 6
        Me.colPOLine.Width = 55
        '
        'colDueDate
        '
        Me.colDueDate.AppearanceCell.Options.UseTextOptions = True
        Me.colDueDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDueDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDueDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDueDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDueDate.Caption = "Due Date"
        Me.colDueDate.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.colDueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDueDate.FieldName = "Dempyou.SODetail.DeliveryDate"
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.Visible = True
        Me.colDueDate.VisibleIndex = 7
        Me.colDueDate.Width = 70
        '
        'colMaterialSize
        '
        Me.colMaterialSize.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaterialSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaterialSize.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colMaterialSize.Caption = "Material Size"
        Me.colMaterialSize.FieldName = "MaterialSize"
        Me.colMaterialSize.Name = "colMaterialSize"
        Me.colMaterialSize.Visible = True
        Me.colMaterialSize.VisibleIndex = 8
        Me.colMaterialSize.Width = 160
        '
        'colFGSize
        '
        Me.colFGSize.AppearanceHeader.Options.UseTextOptions = True
        Me.colFGSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFGSize.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colFGSize.Caption = "Finish Goods Size"
        Me.colFGSize.FieldName = "Dempyou.SODetail.Barang.FGSize"
        Me.colFGSize.Name = "colFGSize"
        Me.colFGSize.Visible = True
        Me.colFGSize.VisibleIndex = 9
        Me.colFGSize.Width = 160
        '
        'colQty
        '
        Me.colQty.AppearanceCell.Options.UseTextOptions = True
        Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQty.Caption = "Qty Process"
        Me.colQty.DisplayFormat.FormatString = "n0"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.FieldName = "Dempyou.Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dempyou.Qty", "{0:n0}")})
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 10
        Me.colQty.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Material Proses"
        Me.GridColumn2.FieldName = "Dempyou.MaterialFlow"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 12
        '
        'colMachine
        '
        Me.colMachine.AppearanceCell.Options.UseTextOptions = True
        Me.colMachine.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMachine.AppearanceHeader.Options.UseTextOptions = True
        Me.colMachine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMachine.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colMachine.Caption = "Machine"
        Me.colMachine.FieldName = "Machine.Nama"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 11
        Me.colMachine.Width = 100
        '
        'colQtyFinishGoods
        '
        Me.colQtyFinishGoods.AppearanceCell.Options.UseTextOptions = True
        Me.colQtyFinishGoods.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyFinishGoods.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyFinishGoods.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyFinishGoods.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtyFinishGoods.Caption = "Qty Finish Goods"
        Me.colQtyFinishGoods.DisplayFormat.FormatString = "n0"
        Me.colQtyFinishGoods.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyFinishGoods.FieldName = "QtyFinishGoods"
        Me.colQtyFinishGoods.Name = "colQtyFinishGoods"
        Me.colQtyFinishGoods.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyFinishGoods", "{0:n0}")})
        Me.colQtyFinishGoods.Visible = True
        Me.colQtyFinishGoods.VisibleIndex = 16
        Me.colQtyFinishGoods.Width = 50
        '
        'colQtyDelivery
        '
        Me.colQtyDelivery.AppearanceCell.Options.UseTextOptions = True
        Me.colQtyDelivery.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyDelivery.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyDelivery.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyDelivery.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtyDelivery.Caption = "Qty Delivery"
        Me.colQtyDelivery.DisplayFormat.FormatString = "n0"
        Me.colQtyDelivery.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyDelivery.FieldName = "QtyDelivery"
        Me.colQtyDelivery.Name = "colQtyDelivery"
        Me.colQtyDelivery.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyDelivery", "{0:n0}")})
        Me.colQtyDelivery.Visible = True
        Me.colQtyDelivery.VisibleIndex = 17
        Me.colQtyDelivery.Width = 50
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.SimpleLabelItem1, Me.SimpleLabelItem2, Me.SimpleLabelItem3, Me.SimpleLabelItem4, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(904, 393)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.xGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 69)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(884, 272)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "Filter Data Dempyou"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(884, 69)
        Me.LayoutControlGroup2.Text = "Filter Data"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtFTanggalAwal
        Me.LayoutControlItem2.CustomizationFormText = "Tgl Awal"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(225, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Tanggal    "
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFTanggalAkhir
        Me.LayoutControlItem3.CustomizationFormText = "sd"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(225, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(90, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 2, 2)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(225, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "   s/d   "
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(33, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnTampilkan
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(460, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnExport
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(580, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(700, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(160, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(450, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseBackColor = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem1.CustomizationFormText = "Prioritas"
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(390, 341)
        Me.SimpleLabelItem1.MaxSize = New System.Drawing.Size(0, 35)
        Me.SimpleLabelItem1.MinSize = New System.Drawing.Size(62, 31)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 5, 6)
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(130, 32)
        Me.SimpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.SimpleLabelItem1.Text = "Prioritas"
        Me.SimpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(50, 20)
        '
        'SimpleLabelItem2
        '
        Me.SimpleLabelItem2.AllowHotTrack = False
        Me.SimpleLabelItem2.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleLabelItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseBackColor = True
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem2.CustomizationFormText = "Selesai Proses"
        Me.SimpleLabelItem2.Location = New System.Drawing.Point(260, 341)
        Me.SimpleLabelItem2.MaxSize = New System.Drawing.Size(0, 35)
        Me.SimpleLabelItem2.MinSize = New System.Drawing.Size(62, 31)
        Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
        Me.SimpleLabelItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 5, 6)
        Me.SimpleLabelItem2.Size = New System.Drawing.Size(130, 32)
        Me.SimpleLabelItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.SimpleLabelItem2.Text = "Selesai Proses"
        Me.SimpleLabelItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(50, 20)
        '
        'SimpleLabelItem3
        '
        Me.SimpleLabelItem3.AllowHotTrack = False
        Me.SimpleLabelItem3.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleLabelItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabelItem3.AppearanceItemCaption.Options.UseBackColor = True
        Me.SimpleLabelItem3.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem3.CustomizationFormText = "Belum Proses"
        Me.SimpleLabelItem3.Location = New System.Drawing.Point(0, 341)
        Me.SimpleLabelItem3.MaxSize = New System.Drawing.Size(0, 35)
        Me.SimpleLabelItem3.MinSize = New System.Drawing.Size(112, 31)
        Me.SimpleLabelItem3.Name = "SimpleLabelItem3"
        Me.SimpleLabelItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 5, 6)
        Me.SimpleLabelItem3.Size = New System.Drawing.Size(130, 32)
        Me.SimpleLabelItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.SimpleLabelItem3.Text = "Belum Proses"
        Me.SimpleLabelItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.SimpleLabelItem3.TextSize = New System.Drawing.Size(100, 20)
        '
        'SimpleLabelItem4
        '
        Me.SimpleLabelItem4.AllowHotTrack = False
        Me.SimpleLabelItem4.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleLabelItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabelItem4.AppearanceItemCaption.Options.UseBackColor = True
        Me.SimpleLabelItem4.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem4.CustomizationFormText = "Sedang Proses"
        Me.SimpleLabelItem4.Location = New System.Drawing.Point(130, 341)
        Me.SimpleLabelItem4.MaxSize = New System.Drawing.Size(0, 35)
        Me.SimpleLabelItem4.MinSize = New System.Drawing.Size(62, 31)
        Me.SimpleLabelItem4.Name = "SimpleLabelItem4"
        Me.SimpleLabelItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 5, 6)
        Me.SimpleLabelItem4.Size = New System.Drawing.Size(130, 32)
        Me.SimpleLabelItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.SimpleLabelItem4.Text = "Sedang Proses"
        Me.SimpleLabelItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.SimpleLabelItem4.TextSize = New System.Drawing.Size(50, 20)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(520, 341)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(364, 32)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnRefresh})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        Me.btnRefresh.Id = 0
        Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(904, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 393)
        Me.barDockControlBottom.Size = New System.Drawing.Size(904, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 393)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(904, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 393)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300000
        '
        'colQtyAdjust
        '
        Me.colQtyAdjust.AppearanceCell.Options.UseTextOptions = True
        Me.colQtyAdjust.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyAdjust.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyAdjust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyAdjust.Caption = "Qty Adjust"
        Me.colQtyAdjust.DisplayFormat.FormatString = "n0"
        Me.colQtyAdjust.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyAdjust.FieldName = "QtyAdjust"
        Me.colQtyAdjust.Name = "colQtyAdjust"
        Me.colQtyAdjust.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyAdjust", "{0:n0}")})
        Me.colQtyAdjust.Visible = True
        Me.colQtyAdjust.VisibleIndex = 18
        Me.colQtyAdjust.Width = 50
        '
        'colKetAdjust
        '
        Me.colKetAdjust.Caption = "Ket Adjust"
        Me.colKetAdjust.FieldName = "KetAdjust"
        Me.colKetAdjust.Name = "colKetAdjust"
        Me.colKetAdjust.Visible = True
        Me.colKetAdjust.VisibleIndex = 19
        Me.colKetAdjust.Width = 100
        '
        'UI_FusohProductionPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 420)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "UI_FusohProductionPlan"
        Me.Text = "Production Plan"
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtFTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtFTanggalAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFTanggalAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnTampilkan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoPDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyKampuh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyDrill As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyFinishGoods As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colQtyCutting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyDelivery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents SimpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents SimpleLabelItem4 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsFinish As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUrgent As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents Timer1 As Windows.Forms.Timer
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyAdjust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKetAdjust As DevExpress.XtraGrid.Columns.GridColumn
End Class
