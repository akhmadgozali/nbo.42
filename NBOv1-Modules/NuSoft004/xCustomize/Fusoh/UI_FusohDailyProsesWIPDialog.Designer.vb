<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohDailyProsesWIPDialog
	Inherits Core.Win.Forms.InputDialog

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
    Me.lytMaster = New DevExpress.XtraLayout.LayoutControl()
    Me.xGridHistory = New DevExpress.XtraGrid.GridControl()
    Me.xGridHistoryView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colHistoryTgl = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryMesin = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryShift = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryProcess = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryOP1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryOP2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryOP3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryOP4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryOP5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryFinishGood = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHistoryProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtCuttingStok = New DevExpress.XtraEditors.SpinEdit()
    Me.txtWIP = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colWIPKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWIPDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWIPLot = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtNG = New DevExpress.XtraEditors.SpinEdit()
    Me.txtFG = New DevExpress.XtraEditors.SpinEdit()
    Me.txtCutting = New DevExpress.XtraEditors.SpinEdit()
    Me.txtCuttingFGSize = New DevExpress.XtraEditors.TextEdit()
    Me.txtCuttingPartNumber = New DevExpress.XtraEditors.TextEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.txtCuttingNomorLot = New DevExpress.XtraEditors.TextEdit()
    Me.txtShift = New DevExpress.XtraEditors.SpinEdit()
    Me.txtJamKerja = New DevExpress.XtraEditors.SpinEdit()
    Me.txtQtyFG = New DevExpress.XtraEditors.SpinEdit()
    Me.txtStopline = New DevExpress.XtraEditors.SpinEdit()
    Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit()
    Me.txtCuttingKodeDempyou = New DevExpress.XtraEditors.TextEdit()
    Me.txtCuttingQtyDempyou = New DevExpress.XtraEditors.SpinEdit()
    Me.txtCuttingQty = New DevExpress.XtraEditors.SpinEdit()
    Me.txtCustomer = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colCustomerKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCustomerNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtMesin = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtProcess = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtQtyOP1 = New DevExpress.XtraEditors.SpinEdit()
    Me.txtQtyOP2 = New DevExpress.XtraEditors.SpinEdit()
    Me.txtQtyOP3 = New DevExpress.XtraEditors.SpinEdit()
    Me.txtQtyOP4 = New DevExpress.XtraEditors.SpinEdit()
    Me.txtQtyOP5 = New DevExpress.XtraEditors.SpinEdit()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleSeparator3 = New DevExpress.XtraLayout.SimpleSeparator()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleSeparator4 = New DevExpress.XtraLayout.SimpleSeparator()
    Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
    Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.txtPDO = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytMaster.SuspendLayout()
    CType(Me.xGridHistory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridHistoryView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCuttingStok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtWIP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCutting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCuttingFGSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCuttingPartNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCuttingNomorLot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtShift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJamKerja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQtyFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStopline.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCuttingKodeDempyou.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCuttingQtyDempyou.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCuttingQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMesin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQtyOP1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQtyOP2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQtyOP3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQtyOP4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQtyOP5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleSeparator4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lytMaster
    '
    Me.lytMaster.Controls.Add(Me.txtPDO)
    Me.lytMaster.Controls.Add(Me.xGridHistory)
    Me.lytMaster.Controls.Add(Me.txtCuttingStok)
    Me.lytMaster.Controls.Add(Me.txtWIP)
    Me.lytMaster.Controls.Add(Me.txtNG)
    Me.lytMaster.Controls.Add(Me.txtFG)
    Me.lytMaster.Controls.Add(Me.txtCutting)
    Me.lytMaster.Controls.Add(Me.txtCuttingFGSize)
    Me.lytMaster.Controls.Add(Me.txtCuttingPartNumber)
    Me.lytMaster.Controls.Add(Me.txtTanggal)
    Me.lytMaster.Controls.Add(Me.txtCuttingNomorLot)
    Me.lytMaster.Controls.Add(Me.txtShift)
    Me.lytMaster.Controls.Add(Me.txtJamKerja)
    Me.lytMaster.Controls.Add(Me.txtQtyFG)
    Me.lytMaster.Controls.Add(Me.txtStopline)
    Me.lytMaster.Controls.Add(Me.txtKeterangan)
    Me.lytMaster.Controls.Add(Me.txtCuttingKodeDempyou)
    Me.lytMaster.Controls.Add(Me.txtCuttingQtyDempyou)
    Me.lytMaster.Controls.Add(Me.txtCuttingQty)
    Me.lytMaster.Controls.Add(Me.txtCustomer)
    Me.lytMaster.Controls.Add(Me.txtMesin)
    Me.lytMaster.Controls.Add(Me.txtProcess)
    Me.lytMaster.Controls.Add(Me.txtQtyOP1)
    Me.lytMaster.Controls.Add(Me.txtQtyOP2)
    Me.lytMaster.Controls.Add(Me.txtQtyOP3)
    Me.lytMaster.Controls.Add(Me.txtQtyOP4)
    Me.lytMaster.Controls.Add(Me.txtQtyOP5)
    Me.lytMaster.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytMaster.Location = New System.Drawing.Point(0, 0)
    Me.lytMaster.Name = "lytMaster"
    Me.lytMaster.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(764, 111, 250, 350)
    Me.lytMaster.Root = Me.LayoutControlGroup3
    Me.lytMaster.Size = New System.Drawing.Size(801, 519)
    Me.lytMaster.TabIndex = 134
    Me.lytMaster.Text = "LayoutControl1"
    '
    'xGridHistory
    '
    Me.xGridHistory.Location = New System.Drawing.Point(24, 325)
    Me.xGridHistory.MainView = Me.xGridHistoryView
    Me.xGridHistory.Name = "xGridHistory"
    Me.xGridHistory.Size = New System.Drawing.Size(753, 170)
    Me.xGridHistory.TabIndex = 135
    Me.xGridHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridHistoryView})
    '
    'xGridHistoryView
    '
    Me.xGridHistoryView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHistoryTgl, Me.colHistoryMesin, Me.colHistoryShift, Me.colHistoryProcess, Me.colHistoryOP1, Me.colHistoryOP2, Me.colHistoryOP3, Me.colHistoryOP4, Me.colHistoryOP5, Me.colHistoryFinishGood, Me.colHistoryProduksi})
    Me.xGridHistoryView.GridControl = Me.xGridHistory
    Me.xGridHistoryView.Name = "xGridHistoryView"
    Me.xGridHistoryView.OptionsBehavior.Editable = False
    Me.xGridHistoryView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridHistoryView.OptionsView.ShowFooter = True
    Me.xGridHistoryView.OptionsView.ShowGroupPanel = False
    '
    'colHistoryTgl
    '
    Me.colHistoryTgl.Caption = "Tanggal"
    Me.colHistoryTgl.DisplayFormat.FormatString = "dd MMM yyyy"
    Me.colHistoryTgl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colHistoryTgl.FieldName = "Tanggal"
    Me.colHistoryTgl.Name = "colHistoryTgl"
    Me.colHistoryTgl.Visible = True
    Me.colHistoryTgl.VisibleIndex = 0
    Me.colHistoryTgl.Width = 100
    '
    'colHistoryMesin
    '
    Me.colHistoryMesin.Caption = "Mesin"
    Me.colHistoryMesin.FieldName = "Mesin.Nama"
    Me.colHistoryMesin.Name = "colHistoryMesin"
    Me.colHistoryMesin.Visible = True
    Me.colHistoryMesin.VisibleIndex = 1
    Me.colHistoryMesin.Width = 120
    '
    'colHistoryShift
    '
    Me.colHistoryShift.Caption = "Shift"
    Me.colHistoryShift.FieldName = "Shift"
    Me.colHistoryShift.Name = "colHistoryShift"
    Me.colHistoryShift.Visible = True
    Me.colHistoryShift.VisibleIndex = 2
    Me.colHistoryShift.Width = 40
    '
    'colHistoryProcess
    '
    Me.colHistoryProcess.Caption = "Process"
    Me.colHistoryProcess.FieldName = "ProcessCutting.Nama"
    Me.colHistoryProcess.Name = "colHistoryProcess"
    Me.colHistoryProcess.Visible = True
    Me.colHistoryProcess.VisibleIndex = 3
    Me.colHistoryProcess.Width = 120
    '
    'colHistoryOP1
    '
    Me.colHistoryOP1.Caption = "OP 1"
    Me.colHistoryOP1.DisplayFormat.FormatString = "n0"
    Me.colHistoryOP1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHistoryOP1.FieldName = "QtyOP1"
    Me.colHistoryOP1.Name = "colHistoryOP1"
    Me.colHistoryOP1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP1", "{0:n0}")})
    Me.colHistoryOP1.Visible = True
    Me.colHistoryOP1.VisibleIndex = 4
    Me.colHistoryOP1.Width = 55
    '
    'colHistoryOP2
    '
    Me.colHistoryOP2.Caption = "OP 2"
    Me.colHistoryOP2.DisplayFormat.FormatString = "n0"
    Me.colHistoryOP2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHistoryOP2.FieldName = "QtyOP2"
    Me.colHistoryOP2.Name = "colHistoryOP2"
    Me.colHistoryOP2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP2", "{0:n0}")})
    Me.colHistoryOP2.Visible = True
    Me.colHistoryOP2.VisibleIndex = 5
    Me.colHistoryOP2.Width = 55
    '
    'colHistoryOP3
    '
    Me.colHistoryOP3.Caption = "OP 3"
    Me.colHistoryOP3.DisplayFormat.FormatString = "n0"
    Me.colHistoryOP3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHistoryOP3.FieldName = "QtyOP3"
    Me.colHistoryOP3.Name = "colHistoryOP3"
    Me.colHistoryOP3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP3", "{0:n0}")})
    Me.colHistoryOP3.Visible = True
    Me.colHistoryOP3.VisibleIndex = 6
    Me.colHistoryOP3.Width = 55
    '
    'colHistoryOP4
    '
    Me.colHistoryOP4.Caption = "OP 4"
    Me.colHistoryOP4.DisplayFormat.FormatString = "n0"
    Me.colHistoryOP4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHistoryOP4.FieldName = "QtyOP4"
    Me.colHistoryOP4.Name = "colHistoryOP4"
    Me.colHistoryOP4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP4", "{0:n0}")})
    Me.colHistoryOP4.Visible = True
    Me.colHistoryOP4.VisibleIndex = 7
    Me.colHistoryOP4.Width = 55
    '
    'colHistoryOP5
    '
    Me.colHistoryOP5.Caption = "OP 5"
    Me.colHistoryOP5.DisplayFormat.FormatString = "n0"
    Me.colHistoryOP5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHistoryOP5.FieldName = "QtyOP5"
    Me.colHistoryOP5.Name = "colHistoryOP5"
    Me.colHistoryOP5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOP5", "{0:n0}")})
    Me.colHistoryOP5.Visible = True
    Me.colHistoryOP5.VisibleIndex = 8
    Me.colHistoryOP5.Width = 55
    '
    'colHistoryFinishGood
    '
    Me.colHistoryFinishGood.Caption = "Finish Good"
    Me.colHistoryFinishGood.DisplayFormat.FormatString = "n0"
    Me.colHistoryFinishGood.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHistoryFinishGood.FieldName = "QtyFinishGood"
    Me.colHistoryFinishGood.Name = "colHistoryFinishGood"
    Me.colHistoryFinishGood.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyFinishGood", "{0:n0}")})
    Me.colHistoryFinishGood.Visible = True
    Me.colHistoryFinishGood.VisibleIndex = 9
    Me.colHistoryFinishGood.Width = 80
    '
    'colHistoryProduksi
    '
    Me.colHistoryProduksi.Caption = "Produksi"
    Me.colHistoryProduksi.FieldName = "Produksi.Kode"
    Me.colHistoryProduksi.Name = "colHistoryProduksi"
    Me.colHistoryProduksi.Visible = True
    Me.colHistoryProduksi.VisibleIndex = 10
    '
    'txtCuttingStok
    '
    Me.txtCuttingStok.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtCuttingStok.Location = New System.Drawing.Point(111, 141)
    Me.txtCuttingStok.Name = "txtCuttingStok"
    Me.txtCuttingStok.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtCuttingStok.Properties.Appearance.Options.UseBackColor = True
    Me.txtCuttingStok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCuttingStok.Properties.ReadOnly = True
    Me.txtCuttingStok.Size = New System.Drawing.Size(220, 20)
    Me.txtCuttingStok.StyleController = Me.lytMaster
    Me.txtCuttingStok.TabIndex = 136
    '
    'txtWIP
    '
    Me.txtWIP.Location = New System.Drawing.Point(434, 67)
    Me.txtWIP.Name = "txtWIP"
    Me.txtWIP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtWIP.Properties.DisplayMember = "Kode"
    Me.txtWIP.Properties.NullText = ""
    Me.txtWIP.Properties.ValueMember = "This"
    Me.txtWIP.Properties.View = Me.GridView1
    Me.txtWIP.Size = New System.Drawing.Size(343, 20)
    Me.txtWIP.StyleController = Me.lytMaster
    Me.txtWIP.TabIndex = 136
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWIPKode, Me.colWIPDempyou, Me.colWIPLot})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'colWIPKode
    '
    Me.colWIPKode.Caption = "Kode"
    Me.colWIPKode.FieldName = "Kode"
    Me.colWIPKode.Name = "colWIPKode"
    Me.colWIPKode.Visible = True
    Me.colWIPKode.VisibleIndex = 0
    '
    'colWIPDempyou
    '
    Me.colWIPDempyou.Caption = "No. Dempyou"
    Me.colWIPDempyou.FieldName = "OrderProduksi.Kode"
    Me.colWIPDempyou.Name = "colWIPDempyou"
    Me.colWIPDempyou.Visible = True
    Me.colWIPDempyou.VisibleIndex = 1
    '
    'colWIPLot
    '
    Me.colWIPLot.Caption = "Nomor Lot"
    Me.colWIPLot.FieldName = "DempyouLot"
    Me.colWIPLot.Name = "colWIPLot"
    Me.colWIPLot.Visible = True
    Me.colWIPLot.VisibleIndex = 2
    '
    'txtNG
    '
    Me.txtNG.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtNG.Location = New System.Drawing.Point(614, 203)
    Me.txtNG.Name = "txtNG"
    Me.txtNG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNG.Size = New System.Drawing.Size(81, 20)
    Me.txtNG.StyleController = Me.lytMaster
    Me.txtNG.TabIndex = 136
    '
    'txtFG
    '
    Me.txtFG.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtFG.Location = New System.Drawing.Point(529, 203)
    Me.txtFG.Name = "txtFG"
    Me.txtFG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtFG.Size = New System.Drawing.Size(81, 20)
    Me.txtFG.StyleController = Me.lytMaster
    Me.txtFG.TabIndex = 136
    '
    'txtCutting
    '
    Me.txtCutting.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtCutting.Location = New System.Drawing.Point(444, 203)
    Me.txtCutting.Name = "txtCutting"
    Me.txtCutting.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCutting.Size = New System.Drawing.Size(81, 20)
    Me.txtCutting.StyleController = Me.lytMaster
    Me.txtCutting.TabIndex = 136
    '
    'txtCuttingFGSize
    '
    Me.txtCuttingFGSize.EnterMoveNextControl = True
    Me.txtCuttingFGSize.Location = New System.Drawing.Point(111, 117)
    Me.txtCuttingFGSize.Name = "txtCuttingFGSize"
    Me.txtCuttingFGSize.Properties.ReadOnly = True
    Me.txtCuttingFGSize.Size = New System.Drawing.Size(220, 20)
    Me.txtCuttingFGSize.StyleController = Me.lytMaster
    Me.txtCuttingFGSize.TabIndex = 135
    '
    'txtCuttingPartNumber
    '
    Me.txtCuttingPartNumber.EnterMoveNextControl = True
    Me.txtCuttingPartNumber.Location = New System.Drawing.Point(111, 93)
    Me.txtCuttingPartNumber.Name = "txtCuttingPartNumber"
    Me.txtCuttingPartNumber.Properties.ReadOnly = True
    Me.txtCuttingPartNumber.Size = New System.Drawing.Size(220, 20)
    Me.txtCuttingPartNumber.StyleController = Me.lytMaster
    Me.txtCuttingPartNumber.TabIndex = 135
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(434, 91)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(143, 20)
    Me.txtTanggal.StyleController = Me.lytMaster
    Me.txtTanggal.TabIndex = 120
    '
    'txtCuttingNomorLot
    '
    Me.txtCuttingNomorLot.EnterMoveNextControl = True
    Me.txtCuttingNomorLot.Location = New System.Drawing.Point(111, 167)
    Me.txtCuttingNomorLot.Name = "txtCuttingNomorLot"
    Me.txtCuttingNomorLot.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtCuttingNomorLot.Properties.Appearance.Options.UseBackColor = True
    Me.txtCuttingNomorLot.Properties.ReadOnly = True
    Me.txtCuttingNomorLot.Size = New System.Drawing.Size(220, 20)
    Me.txtCuttingNomorLot.StyleController = Me.lytMaster
    Me.txtCuttingNomorLot.TabIndex = 128
    '
    'txtShift
    '
    Me.txtShift.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtShift.Location = New System.Drawing.Point(626, 115)
    Me.txtShift.Name = "txtShift"
    Me.txtShift.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtShift.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
    Me.txtShift.Size = New System.Drawing.Size(151, 20)
    Me.txtShift.StyleController = Me.lytMaster
    Me.txtShift.TabIndex = 116
    '
    'txtJamKerja
    '
    Me.txtJamKerja.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtJamKerja.Location = New System.Drawing.Point(359, 203)
    Me.txtJamKerja.Name = "txtJamKerja"
    Me.txtJamKerja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtJamKerja.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
    Me.txtJamKerja.Size = New System.Drawing.Size(81, 20)
    Me.txtJamKerja.StyleController = Me.lytMaster
    Me.txtJamKerja.TabIndex = 112
    '
    'txtQtyFG
    '
    Me.txtQtyFG.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtQtyFG.Location = New System.Drawing.Point(709, 159)
    Me.txtQtyFG.Name = "txtQtyFG"
    Me.txtQtyFG.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtQtyFG.Properties.Appearance.Options.UseBackColor = True
    Me.txtQtyFG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtQtyFG.Size = New System.Drawing.Size(68, 20)
    Me.txtQtyFG.StyleController = Me.lytMaster
    Me.txtQtyFG.TabIndex = 114
    '
    'txtStopline
    '
    Me.txtStopline.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtStopline.Location = New System.Drawing.Point(699, 203)
    Me.txtStopline.Name = "txtStopline"
    Me.txtStopline.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStopline.Properties.MaxValue = New Decimal(New Integer() {2000, 0, 0, 0})
    Me.txtStopline.Size = New System.Drawing.Size(78, 20)
    Me.txtStopline.StyleController = Me.lytMaster
    Me.txtStopline.TabIndex = 126
    '
    'txtKeterangan
    '
    Me.txtKeterangan.Location = New System.Drawing.Point(99, 251)
    Me.txtKeterangan.Name = "txtKeterangan"
    Me.txtKeterangan.Size = New System.Drawing.Size(690, 39)
    Me.txtKeterangan.StyleController = Me.lytMaster
    Me.txtKeterangan.TabIndex = 132
    '
    'txtCuttingKodeDempyou
    '
    Me.txtCuttingKodeDempyou.Location = New System.Drawing.Point(111, 43)
    Me.txtCuttingKodeDempyou.Name = "txtCuttingKodeDempyou"
    Me.txtCuttingKodeDempyou.Properties.ReadOnly = True
    Me.txtCuttingKodeDempyou.Size = New System.Drawing.Size(220, 20)
    Me.txtCuttingKodeDempyou.StyleController = Me.lytMaster
    Me.txtCuttingKodeDempyou.TabIndex = 100
    '
    'txtCuttingQtyDempyou
    '
    Me.txtCuttingQtyDempyou.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtCuttingQtyDempyou.Location = New System.Drawing.Point(111, 191)
    Me.txtCuttingQtyDempyou.Name = "txtCuttingQtyDempyou"
    Me.txtCuttingQtyDempyou.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCuttingQtyDempyou.Properties.ReadOnly = True
    Me.txtCuttingQtyDempyou.Size = New System.Drawing.Size(220, 20)
    Me.txtCuttingQtyDempyou.StyleController = Me.lytMaster
    Me.txtCuttingQtyDempyou.TabIndex = 135
    '
    'txtCuttingQty
    '
    Me.txtCuttingQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtCuttingQty.Location = New System.Drawing.Point(111, 215)
    Me.txtCuttingQty.Name = "txtCuttingQty"
    Me.txtCuttingQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCuttingQty.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
    Me.txtCuttingQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtCuttingQty.Properties.ReadOnly = True
    Me.txtCuttingQty.Size = New System.Drawing.Size(220, 20)
    Me.txtCuttingQty.StyleController = Me.lytMaster
    Me.txtCuttingQty.TabIndex = 135
    '
    'txtCustomer
    '
    Me.txtCustomer.Location = New System.Drawing.Point(434, 43)
    Me.txtCustomer.Name = "txtCustomer"
    Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCustomer.Properties.DisplayMember = "Nama"
    Me.txtCustomer.Properties.NullText = ""
    Me.txtCustomer.Properties.ValueMember = "This"
    Me.txtCustomer.Properties.View = Me.SearchLookUpEdit1View
    Me.txtCustomer.Size = New System.Drawing.Size(343, 20)
    Me.txtCustomer.StyleController = Me.lytMaster
    Me.txtCustomer.TabIndex = 135
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerKode, Me.colCustomerNama})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    '
    'colCustomerKode
    '
    Me.colCustomerKode.Caption = "Kode"
    Me.colCustomerKode.FieldName = "Kode"
    Me.colCustomerKode.Name = "colCustomerKode"
    Me.colCustomerKode.Visible = True
    Me.colCustomerKode.VisibleIndex = 0
    Me.colCustomerKode.Width = 70
    '
    'colCustomerNama
    '
    Me.colCustomerNama.Caption = "Nama"
    Me.colCustomerNama.FieldName = "Nama"
    Me.colCustomerNama.Name = "colCustomerNama"
    Me.colCustomerNama.Visible = True
    Me.colCustomerNama.VisibleIndex = 1
    Me.colCustomerNama.Width = 314
    '
    'txtMesin
    '
    Me.txtMesin.EditValue = ""
    Me.txtMesin.Location = New System.Drawing.Point(434, 115)
    Me.txtMesin.Name = "txtMesin"
    Me.txtMesin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtMesin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtMesin.Properties.DisplayMember = "Nama"
    Me.txtMesin.Properties.NullText = "[ Pilih Mesin ]"
    Me.txtMesin.Properties.ShowHeader = False
    Me.txtMesin.Properties.ValueMember = "This"
    Me.txtMesin.Size = New System.Drawing.Size(143, 20)
    Me.txtMesin.StyleController = Me.lytMaster
    Me.txtMesin.TabIndex = 118
    '
    'txtProcess
    '
    Me.txtProcess.Location = New System.Drawing.Point(626, 91)
    Me.txtProcess.Name = "txtProcess"
    Me.txtProcess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProcess.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtProcess.Properties.DisplayMember = "Nama"
    Me.txtProcess.Properties.NullText = "[ Pilih Process ]"
    Me.txtProcess.Properties.ShowHeader = False
    Me.txtProcess.Properties.ValueMember = "This"
    Me.txtProcess.Size = New System.Drawing.Size(151, 20)
    Me.txtProcess.StyleController = Me.lytMaster
    Me.txtProcess.TabIndex = 135
    '
    'txtQtyOP1
    '
    Me.txtQtyOP1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtQtyOP1.Location = New System.Drawing.Point(359, 159)
    Me.txtQtyOP1.Name = "txtQtyOP1"
    Me.txtQtyOP1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtQtyOP1.Properties.Appearance.Options.UseBackColor = True
    Me.txtQtyOP1.Properties.Appearance.Options.UseTextOptions = True
    Me.txtQtyOP1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtQtyOP1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtQtyOP1.Size = New System.Drawing.Size(66, 20)
    Me.txtQtyOP1.StyleController = Me.lytMaster
    Me.txtQtyOP1.TabIndex = 110
    '
    'txtQtyOP2
    '
    Me.txtQtyOP2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtQtyOP2.Location = New System.Drawing.Point(429, 159)
    Me.txtQtyOP2.Name = "txtQtyOP2"
    Me.txtQtyOP2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtQtyOP2.Properties.Appearance.Options.UseBackColor = True
    Me.txtQtyOP2.Properties.Appearance.Options.UseTextOptions = True
    Me.txtQtyOP2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtQtyOP2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtQtyOP2.Size = New System.Drawing.Size(66, 20)
    Me.txtQtyOP2.StyleController = Me.lytMaster
    Me.txtQtyOP2.TabIndex = 124
    '
    'txtQtyOP3
    '
    Me.txtQtyOP3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtQtyOP3.Location = New System.Drawing.Point(499, 159)
    Me.txtQtyOP3.Name = "txtQtyOP3"
    Me.txtQtyOP3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtQtyOP3.Properties.Appearance.Options.UseBackColor = True
    Me.txtQtyOP3.Properties.Appearance.Options.UseTextOptions = True
    Me.txtQtyOP3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtQtyOP3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtQtyOP3.Size = New System.Drawing.Size(66, 20)
    Me.txtQtyOP3.StyleController = Me.lytMaster
    Me.txtQtyOP3.TabIndex = 122
    '
    'txtQtyOP4
    '
    Me.txtQtyOP4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtQtyOP4.Location = New System.Drawing.Point(569, 159)
    Me.txtQtyOP4.Name = "txtQtyOP4"
    Me.txtQtyOP4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtQtyOP4.Properties.Appearance.Options.UseBackColor = True
    Me.txtQtyOP4.Properties.Appearance.Options.UseTextOptions = True
    Me.txtQtyOP4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtQtyOP4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtQtyOP4.Size = New System.Drawing.Size(66, 20)
    Me.txtQtyOP4.StyleController = Me.lytMaster
    Me.txtQtyOP4.TabIndex = 136
    '
    'txtQtyOP5
    '
    Me.txtQtyOP5.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtQtyOP5.Location = New System.Drawing.Point(639, 159)
    Me.txtQtyOP5.Name = "txtQtyOP5"
    Me.txtQtyOP5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtQtyOP5.Properties.Appearance.Options.UseBackColor = True
    Me.txtQtyOP5.Properties.Appearance.Options.UseTextOptions = True
    Me.txtQtyOP5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtQtyOP5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtQtyOP5.Size = New System.Drawing.Size(66, 20)
    Me.txtQtyOP5.StyleController = Me.lytMaster
    Me.txtQtyOP5.TabIndex = 135
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Root"
    Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup3.GroupBordersVisible = False
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup6, Me.LayoutControlItem12})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "Root"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(801, 519)
    Me.LayoutControlGroup3.Text = "Root"
    Me.LayoutControlGroup3.TextVisible = False
    '
    'LayoutControlGroup4
    '
    Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
    Me.LayoutControlGroup4.CustomizationFormText = "Dempyou"
    Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem10, Me.SimpleSeparator3, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.SimpleSeparator4, Me.LayoutControlItem21, Me.LayoutControlItem27})
    Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
    Me.LayoutControlGroup4.Size = New System.Drawing.Size(335, 239)
    Me.LayoutControlGroup4.Text = "Info Cutting [WIP]"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtCuttingKodeDempyou
    Me.LayoutControlItem1.CustomizationFormText = "Kode"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem1.Text = "Kode Dempyou"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(84, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtCuttingNomorLot
    Me.LayoutControlItem10.CustomizationFormText = "Nomor Lot"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 124)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem10.Text = "Nomor Lot"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(84, 13)
    '
    'SimpleSeparator3
    '
    Me.SimpleSeparator3.AllowHotTrack = False
    Me.SimpleSeparator3.CustomizationFormText = "SimpleSeparator3"
    Me.SimpleSeparator3.Location = New System.Drawing.Point(0, 48)
    Me.SimpleSeparator3.Name = "SimpleSeparator3"
    Me.SimpleSeparator3.Size = New System.Drawing.Size(311, 2)
    Me.SimpleSeparator3.Text = "SimpleSeparator3"
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.txtCuttingQtyDempyou
    Me.LayoutControlItem17.CustomizationFormText = "Qty Dempyou"
    Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 148)
    Me.LayoutControlItem17.Name = "LayoutControlItem17"
    Me.LayoutControlItem17.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem17.Text = "Qty Dempyou"
    Me.LayoutControlItem17.TextSize = New System.Drawing.Size(84, 13)
    '
    'LayoutControlItem18
    '
    Me.LayoutControlItem18.Control = Me.txtCuttingQty
    Me.LayoutControlItem18.CustomizationFormText = "Cutting"
    Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 172)
    Me.LayoutControlItem18.Name = "LayoutControlItem18"
    Me.LayoutControlItem18.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem18.Text = "Qty Cutting"
    Me.LayoutControlItem18.TextSize = New System.Drawing.Size(84, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtCuttingPartNumber
    Me.LayoutControlItem13.CustomizationFormText = "Part Number (FG)"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 50)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem13.Text = "Part Number (FG)"
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(84, 13)
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtCuttingFGSize
    Me.LayoutControlItem14.CustomizationFormText = "Finish Good Size"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 74)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem14.Text = "Finish Good Size"
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(84, 13)
    '
    'SimpleSeparator4
    '
    Me.SimpleSeparator4.AllowHotTrack = False
    Me.SimpleSeparator4.CustomizationFormText = "SimpleSeparator4"
    Me.SimpleSeparator4.Location = New System.Drawing.Point(0, 122)
    Me.SimpleSeparator4.Name = "SimpleSeparator4"
    Me.SimpleSeparator4.Size = New System.Drawing.Size(311, 2)
    Me.SimpleSeparator4.Text = "SimpleSeparator4"
    '
    'LayoutControlItem21
    '
    Me.LayoutControlItem21.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LayoutControlItem21.AppearanceItemCaption.Options.UseFont = True
    Me.LayoutControlItem21.Control = Me.txtCuttingStok
    Me.LayoutControlItem21.CustomizationFormText = "Stok"
    Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 98)
    Me.LayoutControlItem21.Name = "LayoutControlItem21"
    Me.LayoutControlItem21.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem21.Text = "Stok"
    Me.LayoutControlItem21.TextSize = New System.Drawing.Size(84, 13)
    '
    'LayoutControlGroup5
    '
    Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
    Me.LayoutControlGroup5.CustomizationFormText = "Daily Process"
    Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem25, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.SimpleSeparator1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem9, Me.LayoutControlItem5, Me.SimpleSeparator2, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem11, Me.LayoutControlItem15})
    Me.LayoutControlGroup5.Location = New System.Drawing.Point(335, 0)
    Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
    Me.LayoutControlGroup5.Size = New System.Drawing.Size(446, 239)
    Me.LayoutControlGroup5.Text = "Daily Process"
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtCustomer
    Me.LayoutControlItem16.CustomizationFormText = "Customer"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(422, 24)
    Me.LayoutControlItem16.Text = "Customer"
    Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(70, 13)
    Me.LayoutControlItem16.TextToControlDistance = 5
    '
    'LayoutControlItem25
    '
    Me.LayoutControlItem25.Control = Me.txtWIP
    Me.LayoutControlItem25.CustomizationFormText = "Cutting [WIP]"
    Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem25.Name = "LayoutControlItem25"
    Me.LayoutControlItem25.Size = New System.Drawing.Size(422, 24)
    Me.LayoutControlItem25.Text = "Cutting [WIP]"
    Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem25.TextSize = New System.Drawing.Size(70, 20)
    Me.LayoutControlItem25.TextToControlDistance = 5
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtTanggal
    Me.LayoutControlItem2.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(222, 24)
    Me.LayoutControlItem2.Text = "Tanggal"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(70, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtMesin
    Me.LayoutControlItem3.CustomizationFormText = "Mesin"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(222, 24)
    Me.LayoutControlItem3.Text = "Mesin"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(70, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtShift
    Me.LayoutControlItem4.CustomizationFormText = "Shift"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(222, 72)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(200, 24)
    Me.LayoutControlItem4.Text = "Shift"
    Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(40, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtQtyOP1
    Me.LayoutControlItem6.CustomizationFormText = "Qty OP 1"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 98)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(70, 42)
    Me.LayoutControlItem6.Text = "OP 1"
    Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(23, 13)
    Me.LayoutControlItem6.TextToControlDistance = 5
    '
    'SimpleSeparator1
    '
    Me.SimpleSeparator1.AllowHotTrack = False
    Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
    Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 96)
    Me.SimpleSeparator1.Name = "SimpleSeparator1"
    Me.SimpleSeparator1.Size = New System.Drawing.Size(422, 2)
    Me.SimpleSeparator1.Text = "SimpleSeparator1"
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtQtyOP2
    Me.LayoutControlItem7.CustomizationFormText = "Qty OP 2"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(70, 98)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(70, 42)
    Me.LayoutControlItem7.Text = "OP 2"
    Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(23, 13)
    Me.LayoutControlItem7.TextToControlDistance = 5
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtQtyOP3
    Me.LayoutControlItem8.CustomizationFormText = "Qty OP 3"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(140, 98)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(70, 42)
    Me.LayoutControlItem8.Text = "OP 3"
    Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(23, 13)
    Me.LayoutControlItem8.TextToControlDistance = 5
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.txtQtyOP4
    Me.LayoutControlItem19.CustomizationFormText = "Qty OP 4"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(210, 98)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(70, 42)
    Me.LayoutControlItem19.Text = "OP 4"
    Me.LayoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(23, 13)
    Me.LayoutControlItem19.TextToControlDistance = 5
    '
    'LayoutControlItem20
    '
    Me.LayoutControlItem20.Control = Me.txtQtyOP5
    Me.LayoutControlItem20.CustomizationFormText = "Qty OP 5"
    Me.LayoutControlItem20.Location = New System.Drawing.Point(280, 98)
    Me.LayoutControlItem20.Name = "LayoutControlItem20"
    Me.LayoutControlItem20.Size = New System.Drawing.Size(70, 42)
    Me.LayoutControlItem20.Text = "OP 5"
    Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem20.TextSize = New System.Drawing.Size(23, 13)
    Me.LayoutControlItem20.TextToControlDistance = 5
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtQtyFG
    Me.LayoutControlItem9.CustomizationFormText = "Qty FG"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(350, 98)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(72, 42)
    Me.LayoutControlItem9.Text = "Finish Good"
    Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(55, 13)
    Me.LayoutControlItem9.TextToControlDistance = 5
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtJamKerja
    Me.LayoutControlItem5.CustomizationFormText = "Jam Kerja"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 142)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(85, 54)
    Me.LayoutControlItem5.Text = "Jam Kerja"
    Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(47, 13)
    Me.LayoutControlItem5.TextToControlDistance = 5
    '
    'SimpleSeparator2
    '
    Me.SimpleSeparator2.AllowHotTrack = False
    Me.SimpleSeparator2.CustomizationFormText = "SimpleSeparator2"
    Me.SimpleSeparator2.Location = New System.Drawing.Point(0, 140)
    Me.SimpleSeparator2.Name = "SimpleSeparator2"
    Me.SimpleSeparator2.Size = New System.Drawing.Size(422, 2)
    Me.SimpleSeparator2.Text = "SimpleSeparator2"
    '
    'LayoutControlItem22
    '
    Me.LayoutControlItem22.Control = Me.txtCutting
    Me.LayoutControlItem22.CustomizationFormText = "Cutting"
    Me.LayoutControlItem22.Location = New System.Drawing.Point(85, 142)
    Me.LayoutControlItem22.Name = "LayoutControlItem22"
    Me.LayoutControlItem22.Size = New System.Drawing.Size(85, 54)
    Me.LayoutControlItem22.Text = "Cutting"
    Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem22.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem22.TextSize = New System.Drawing.Size(35, 13)
    Me.LayoutControlItem22.TextToControlDistance = 5
    '
    'LayoutControlItem23
    '
    Me.LayoutControlItem23.Control = Me.txtFG
    Me.LayoutControlItem23.CustomizationFormText = "FG"
    Me.LayoutControlItem23.Location = New System.Drawing.Point(170, 142)
    Me.LayoutControlItem23.Name = "LayoutControlItem23"
    Me.LayoutControlItem23.Size = New System.Drawing.Size(85, 54)
    Me.LayoutControlItem23.Text = "FG"
    Me.LayoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem23.TextSize = New System.Drawing.Size(13, 13)
    Me.LayoutControlItem23.TextToControlDistance = 5
    '
    'LayoutControlItem24
    '
    Me.LayoutControlItem24.Control = Me.txtNG
    Me.LayoutControlItem24.CustomizationFormText = "NG"
    Me.LayoutControlItem24.Location = New System.Drawing.Point(255, 142)
    Me.LayoutControlItem24.Name = "LayoutControlItem24"
    Me.LayoutControlItem24.Size = New System.Drawing.Size(85, 54)
    Me.LayoutControlItem24.Text = "NG"
    Me.LayoutControlItem24.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem24.TextSize = New System.Drawing.Size(14, 13)
    Me.LayoutControlItem24.TextToControlDistance = 5
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtStopline
    Me.LayoutControlItem11.CustomizationFormText = "Stopline"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(340, 142)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(82, 54)
    Me.LayoutControlItem11.Text = "Stopline (menit)"
    Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(75, 13)
    Me.LayoutControlItem11.TextToControlDistance = 5
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtProcess
    Me.LayoutControlItem15.CustomizationFormText = "Process"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(222, 48)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(200, 24)
    Me.LayoutControlItem15.Text = "Process"
    Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(40, 13)
    Me.LayoutControlItem15.TextToControlDistance = 5
    '
    'LayoutControlGroup6
    '
    Me.LayoutControlGroup6.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LayoutControlGroup6.AppearanceGroup.Options.UseFont = True
    Me.LayoutControlGroup6.CustomizationFormText = "History Daily Process"
    Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem26})
    Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 282)
    Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
    Me.LayoutControlGroup6.Size = New System.Drawing.Size(781, 217)
    Me.LayoutControlGroup6.Text = "History Daily Process"
    '
    'LayoutControlItem26
    '
    Me.LayoutControlItem26.Control = Me.xGridHistory
    Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
    Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem26.Name = "LayoutControlItem26"
    Me.LayoutControlItem26.Size = New System.Drawing.Size(757, 174)
    Me.LayoutControlItem26.Text = "LayoutControlItem26"
    Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem26.TextToControlDistance = 0
    Me.LayoutControlItem26.TextVisible = False
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtKeterangan
    Me.LayoutControlItem12.CustomizationFormText = "Remarks"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 239)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(781, 43)
    Me.LayoutControlItem12.Text = "Keterangan"
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(84, 13)
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(392, 71)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Root"
    Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup2.GroupBordersVisible = False
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "Root"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(392, 71)
    Me.LayoutControlGroup2.Text = "Root"
    Me.LayoutControlGroup2.TextVisible = False
    '
    'txtPDO
    '
    Me.txtPDO.Location = New System.Drawing.Point(111, 67)
    Me.txtPDO.Name = "txtPDO"
    Me.txtPDO.Properties.ReadOnly = True
    Me.txtPDO.Size = New System.Drawing.Size(220, 20)
    Me.txtPDO.StyleController = Me.lytMaster
    Me.txtPDO.TabIndex = 137
    '
    'LayoutControlItem27
    '
    Me.LayoutControlItem27.Control = Me.txtPDO
    Me.LayoutControlItem27.CustomizationFormText = "No. PDO"
    Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem27.Name = "LayoutControlItem27"
    Me.LayoutControlItem27.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem27.Text = "No. PDO"
    Me.LayoutControlItem27.TextSize = New System.Drawing.Size(84, 13)
    '
    'UI_FusohDailyProsesWIPDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(801, 568)
    Me.Controls.Add(Me.lytMaster)
    Me.Name = "UI_FusohDailyProsesWIPDialog"
    Me.Text = "Daily Proses"
    Me.Controls.SetChildIndex(Me.lytMaster, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytMaster.ResumeLayout(False)
    CType(Me.xGridHistory, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridHistoryView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCuttingStok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtWIP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCutting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCuttingFGSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCuttingPartNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCuttingNomorLot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtShift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJamKerja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQtyFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStopline.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCuttingKodeDempyou.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCuttingQtyDempyou.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCuttingQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMesin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQtyOP1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQtyOP2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQtyOP3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQtyOP4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQtyOP5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleSeparator4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtCuttingNomorLot As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents lytMaster As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents txtShift As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtJamKerja As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtQtyFG As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtStopline As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleSeparator3 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents txtCuttingFGSize As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuttingPartNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator4 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCuttingKodeDempyou As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNG As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtFG As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtCutting As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCuttingQtyDempyou As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtCuttingQty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtWIP As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMesin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtProcess As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtQtyOP1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtQtyOP2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtQtyOP3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtQtyOP4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtQtyOP5 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents txtCuttingStok As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents xGridHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridHistoryView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHistoryTgl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryMesin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryShift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryProcess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryOP1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryOP2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryOP3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryOP4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryOP5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryFinishGood As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCustomerKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWIPKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWIPDempyou As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWIPLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHistoryProduksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtPDO As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
End Class
