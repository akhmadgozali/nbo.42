<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohStockTacking
  Inherits Core.Win.Forms.BlankForm

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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colQtyOP1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOP2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOP3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOP4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOP5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTampilkan = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.txtFTanggalAkhir = New DevExpress.XtraEditors.DateEdit()
        Me.txtFTanggalAwal = New DevExpress.XtraEditors.DateEdit()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomorLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFGSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProcess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalWIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyWIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyCutting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyFG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyDelivery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colQtyOP1
        '
        Me.colQtyOP1.Caption = "Qty OP 1"
        Me.colQtyOP1.DisplayFormat.FormatString = "n0"
        Me.colQtyOP1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyOP1.FieldName = "QtyOP1"
        Me.colQtyOP1.Name = "colQtyOP1"
        Me.colQtyOP1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP1", "{0:n0}")})
        Me.colQtyOP1.Visible = True
        Me.colQtyOP1.VisibleIndex = 10
        '
        'colQtyOP2
        '
        Me.colQtyOP2.Caption = "Qty OP 2"
        Me.colQtyOP2.DisplayFormat.FormatString = "n0"
        Me.colQtyOP2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyOP2.FieldName = "QtyOP2"
        Me.colQtyOP2.Name = "colQtyOP2"
        Me.colQtyOP2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP2", "{0:n0}")})
        Me.colQtyOP2.Visible = True
        Me.colQtyOP2.VisibleIndex = 11
        '
        'colQtyOP3
        '
        Me.colQtyOP3.Caption = "Qty OP 3"
        Me.colQtyOP3.DisplayFormat.FormatString = "n0"
        Me.colQtyOP3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyOP3.FieldName = "QtyOP3"
        Me.colQtyOP3.Name = "colQtyOP3"
        Me.colQtyOP3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP3", "{0:n0}")})
        Me.colQtyOP3.Visible = True
        Me.colQtyOP3.VisibleIndex = 12
        '
        'colQtyOP4
        '
        Me.colQtyOP4.Caption = "Qty OP 4"
        Me.colQtyOP4.DisplayFormat.FormatString = "n0"
        Me.colQtyOP4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyOP4.FieldName = "QtyOP4"
        Me.colQtyOP4.Name = "colQtyOP4"
        Me.colQtyOP4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP4", "{0:n0}")})
        '
        'colQtyOP5
        '
        Me.colQtyOP5.Caption = "Qty OP 5"
        Me.colQtyOP5.DisplayFormat.FormatString = "n0"
        Me.colQtyOP5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyOP5.FieldName = "QtyOP5"
        Me.colQtyOP5.Name = "colQtyOP5"
        Me.colQtyOP5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP5", "{0:n0}")})
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnExport)
        Me.LayoutControl1.Controls.Add(Me.btnTampilkan)
        Me.LayoutControl1.Controls.Add(Me.txtTanggal)
        Me.LayoutControl1.Controls.Add(Me.txtFTanggalAkhir)
        Me.LayoutControl1.Controls.Add(Me.txtFTanggalAwal)
        Me.LayoutControl1.Controls.Add(Me.xGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(378, 388, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(904, 420)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(668, 194)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(212, 22)
        Me.btnExport.StyleController = Me.LayoutControl1
        Me.btnExport.TabIndex = 9
        Me.btnExport.Text = "Export Excell"
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(668, 158)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(212, 22)
        Me.btnTampilkan.StyleController = Me.LayoutControl1
        Me.btnTampilkan.TabIndex = 8
        Me.btnTampilkan.Text = "Tampilkan Data"
        '
        'txtTanggal
        '
        Me.txtTanggal.EditValue = Nothing
        Me.txtTanggal.Location = New System.Drawing.Point(665, 134)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Size = New System.Drawing.Size(215, 20)
        Me.txtTanggal.StyleController = Me.LayoutControl1
        Me.txtTanggal.TabIndex = 7
        '
        'txtFTanggalAkhir
        '
        Me.txtFTanggalAkhir.EditValue = Nothing
        Me.txtFTanggalAkhir.Location = New System.Drawing.Point(663, 67)
        Me.txtFTanggalAkhir.Name = "txtFTanggalAkhir"
        Me.txtFTanggalAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFTanggalAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFTanggalAkhir.Size = New System.Drawing.Size(217, 20)
        Me.txtFTanggalAkhir.StyleController = Me.LayoutControl1
        Me.txtFTanggalAkhir.TabIndex = 6
        '
        'txtFTanggalAwal
        '
        Me.txtFTanggalAwal.EditValue = Nothing
        Me.txtFTanggalAwal.Location = New System.Drawing.Point(665, 43)
        Me.txtFTanggalAwal.Name = "txtFTanggalAwal"
        Me.txtFTanggalAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFTanggalAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFTanggalAwal.Size = New System.Drawing.Size(215, 20)
        Me.txtFTanggalAwal.StyleController = Me.LayoutControl1
        Me.txtFTanggalAwal.TabIndex = 5
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(12, 12)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.Size = New System.Drawing.Size(577, 396)
        Me.xGrid.TabIndex = 4
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomer, Me.colNoDempyou, Me.colNomorLot, Me.colPartNo, Me.colFGSize, Me.colProcess, Me.colQty, Me.colTanggalWIP, Me.colQtyWIP, Me.colQtyCutting, Me.colQtyOP1, Me.colQtyOP2, Me.colQtyOP3, Me.colQtyOP4, Me.colQtyOP5, Me.colQtyFG, Me.colQtyDelivery})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.colQtyOP1
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.colQtyOP2
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.colQtyOP3
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Column = Me.colQtyOP4
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.Column = Me.colQtyOP5
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsView.ColumnAutoWidth = False
        Me.xGridView.OptionsView.ShowAutoFilterRow = True
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer"
        Me.colCustomer.FieldName = "Dempyou.Pelanggan.Nama"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 0
        '
        'colNoDempyou
        '
        Me.colNoDempyou.Caption = "No Dempyou"
        Me.colNoDempyou.FieldName = "Dempyou.Kode"
        Me.colNoDempyou.Name = "colNoDempyou"
        Me.colNoDempyou.Visible = True
        Me.colNoDempyou.VisibleIndex = 1
        '
        'colNomorLot
        '
        Me.colNomorLot.Caption = "No LOT"
        Me.colNomorLot.FieldName = "Dempyou.NomorLot"
        Me.colNomorLot.Name = "colNomorLot"
        Me.colNomorLot.Visible = True
        Me.colNomorLot.VisibleIndex = 2
        '
        'colPartNo
        '
        Me.colPartNo.Caption = "Part No"
        Me.colPartNo.FieldName = "Dempyou.SODetail.Barang.Kode"
        Me.colPartNo.Name = "colPartNo"
        Me.colPartNo.Visible = True
        Me.colPartNo.VisibleIndex = 3
        '
        'colFGSize
        '
        Me.colFGSize.Caption = "Finish Good Size"
        Me.colFGSize.FieldName = "Dempyou.SODetail.Barang.FGSize"
        Me.colFGSize.Name = "colFGSize"
        Me.colFGSize.Visible = True
        Me.colFGSize.VisibleIndex = 4
        '
        'colProcess
        '
        Me.colProcess.Caption = "Process"
        Me.colProcess.FieldName = "Dempyou.SODetail.Barang.MaterialProses.Nama"
        Me.colProcess.Name = "colProcess"
        Me.colProcess.Visible = True
        Me.colProcess.VisibleIndex = 5
        '
        'colQty
        '
        Me.colQty.Caption = "Qty Dempyou"
        Me.colQty.DisplayFormat.FormatString = "n0"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.FieldName = "Dempyou.Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dempyou.Qty", "{0:n0}")})
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 6
        '
        'colTanggalWIP
        '
        Me.colTanggalWIP.Caption = "WIP Date"
        Me.colTanggalWIP.FieldName = "TanggalWIP"
        Me.colTanggalWIP.Name = "colTanggalWIP"
        Me.colTanggalWIP.Visible = True
        Me.colTanggalWIP.VisibleIndex = 7
        '
        'colQtyWIP
        '
        Me.colQtyWIP.Caption = "Qty WIP"
        Me.colQtyWIP.DisplayFormat.FormatString = "n0"
        Me.colQtyWIP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyWIP.FieldName = "QtyWIP"
        Me.colQtyWIP.Name = "colQtyWIP"
        Me.colQtyWIP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyWIP", "{0:n0}")})
        Me.colQtyWIP.Visible = True
        Me.colQtyWIP.VisibleIndex = 8
        '
        'colQtyCutting
        '
        Me.colQtyCutting.Caption = "Qty Cutting"
        Me.colQtyCutting.DisplayFormat.FormatString = "n0"
        Me.colQtyCutting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyCutting.FieldName = "QtyCutting"
        Me.colQtyCutting.Name = "colQtyCutting"
        Me.colQtyCutting.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyCutting", "{0:n0}")})
        Me.colQtyCutting.Visible = True
        Me.colQtyCutting.VisibleIndex = 9
        '
        'colQtyFG
        '
        Me.colQtyFG.Caption = "Qty FG"
        Me.colQtyFG.DisplayFormat.FormatString = "n0"
        Me.colQtyFG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyFG.FieldName = "QtyFinishGood"
        Me.colQtyFG.Name = "colQtyFG"
        Me.colQtyFG.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyFinishGood", "{0:n0}")})
        Me.colQtyFG.Visible = True
        Me.colQtyFG.VisibleIndex = 13
        '
        'colQtyDelivery
        '
        Me.colQtyDelivery.Caption = "Qty Delivery"
        Me.colQtyDelivery.DisplayFormat.FormatString = "n0"
        Me.colQtyDelivery.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyDelivery.FieldName = "QtyDelivery"
        Me.colQtyDelivery.Name = "colQtyDelivery"
        Me.colQtyDelivery.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyDelivery", "{0:n0}")})
        Me.colQtyDelivery.Visible = True
        Me.colQtyDelivery.VisibleIndex = 14
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(904, 420)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.xGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(581, 400)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Filter Data Dempyou"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(581, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(303, 91)
        Me.LayoutControlGroup2.Text = "Filter Data Dempyou"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtFTanggalAwal
        Me.LayoutControlItem2.CustomizationFormText = "Tgl Awal"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Tanggal"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(57, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFTanggalAkhir
        Me.LayoutControlItem3.CustomizationFormText = "sd"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 2, 2)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem3.Text = "      sd"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(57, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Stock Tacking"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlItem5, Me.EmptySpaceItem4, Me.EmptySpaceItem1, Me.LayoutControlItem6})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(581, 91)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(303, 309)
        Me.LayoutControlGroup3.Text = "Stock Tacking"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtTanggal
        Me.LayoutControlItem4.CustomizationFormText = "Per Tanggal"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem4.Text = "Per Tanggal"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(57, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(63, 242)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnTampilkan
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(63, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(216, 26)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(63, 86)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(216, 180)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(63, 50)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(216, 10)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnExport
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(63, 60)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(216, 26)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'UI_FusohStockTacking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 420)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UI_FusohStockTacking"
        Me.Text = "Stock Tacking"
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtFTanggalAkhir As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtFTanggalAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents btnTampilkan As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoDempyou As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNomorLot As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPartNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colFGSize As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOP1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOP2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOP3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOP4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOP5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyFG As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colTanggalWIP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyCutting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProcess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyWIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyDelivery As DevExpress.XtraGrid.Columns.GridColumn
End Class
