<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohDataCostSheet
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
    Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
    Me.xGridDetailView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCostLain = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDetTotalImportDuty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xGridMain = New DevExpress.XtraGrid.GridControl()
    Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
    Me.xGridDetailCostView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xGridMainView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotalImportDuty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotalPembelian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDetailView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridMain, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDetailCostView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridMainView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGridDetailView
    '
    Me.xGridDetailView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.colCostLain, Me.colDetTotalImportDuty, Me.GridColumn16})
    Me.xGridDetailView.GridControl = Me.xGridMain
    Me.xGridDetailView.Name = "xGridDetailView"
    Me.xGridDetailView.OptionsBehavior.Editable = False
    Me.xGridDetailView.OptionsBehavior.ReadOnly = True
    Me.xGridDetailView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode Barang"
    Me.GridColumn1.FieldName = "Barang.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama Barang"
    Me.GridColumn2.FieldName = "Barang.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Qty"
    Me.GridColumn3.DisplayFormat.FormatString = "n0"
    Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn3.FieldName = "Qty"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Satuan"
    Me.GridColumn4.FieldName = "Satuan.Kode"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Harga"
    Me.GridColumn5.DisplayFormat.FormatString = "n2"
    Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn5.FieldName = "HargaIDR"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Sub Total"
    Me.GridColumn6.DisplayFormat.FormatString = "n2"
    Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn6.FieldName = "TotalIDR"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalIDR", "n2")})
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    '
    'colCostLain
    '
    Me.colCostLain.Caption = "Cost"
    Me.colCostLain.DisplayFormat.FormatString = "n2"
    Me.colCostLain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colCostLain.FieldName = "TotalCostBukanImportDutyIDR"
    Me.colCostLain.Name = "colCostLain"
    Me.colCostLain.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCostBukanImportDutyIDR", "n2")})
    Me.colCostLain.Visible = True
    Me.colCostLain.VisibleIndex = 6
    '
    'colDetTotalImportDuty
    '
    Me.colDetTotalImportDuty.Caption = "Import Duty"
    Me.colDetTotalImportDuty.DisplayFormat.FormatString = "n2"
    Me.colDetTotalImportDuty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colDetTotalImportDuty.FieldName = "TotalCostImportDutyIDR"
    Me.colDetTotalImportDuty.Name = "colDetTotalImportDuty"
    Me.colDetTotalImportDuty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCostImportDutyIDR", "n2")})
    Me.colDetTotalImportDuty.Visible = True
    Me.colDetTotalImportDuty.VisibleIndex = 7
    '
    'GridColumn16
    '
    Me.GridColumn16.Caption = "TotalIDR"
    Me.GridColumn16.DisplayFormat.FormatString = "n2"
    Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn16.FieldName = "TotalPembelianIDR"
    Me.GridColumn16.Name = "GridColumn16"
    Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPembelianIDR", "n2")})
    Me.GridColumn16.Visible = True
    Me.GridColumn16.VisibleIndex = 8
    '
    'xGridMain
    '
    Me.xGridMain.DataSource = Me.XpCollection1
    Me.xGridMain.Dock = System.Windows.Forms.DockStyle.Fill
    GridLevelNode1.LevelTemplate = Me.xGridDetailView
    GridLevelNode1.RelationName = "Detail"
    GridLevelNode2.LevelTemplate = Me.xGridDetailCostView
    GridLevelNode2.RelationName = "DetailCost"
    Me.xGridMain.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
    Me.xGridMain.Location = New System.Drawing.Point(0, 0)
    Me.xGridMain.MainView = Me.xGridMainView
    Me.xGridMain.Name = "xGridMain"
    Me.xGridMain.ShowOnlyPredefinedDetails = True
    Me.xGridMain.Size = New System.Drawing.Size(901, 504)
    Me.xGridMain.TabIndex = 18
    Me.xGridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridDetailCostView, Me.xGridMainView, Me.xGridDetailView})
    '
    'XpCollection1
    '
    Me.XpCollection1.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.Fusoh_PenerimaanInvoice)
    '
    'xGridDetailCostView
    '
    Me.xGridDetailCostView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14})
    Me.xGridDetailCostView.GridControl = Me.xGridMain
    Me.xGridDetailCostView.Name = "xGridDetailCostView"
    Me.xGridDetailCostView.OptionsBehavior.Editable = False
    Me.xGridDetailCostView.OptionsBehavior.ReadOnly = True
    Me.xGridDetailCostView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "No Bukti"
    Me.GridColumn9.FieldName = "Kode"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 0
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Tanggal"
    Me.GridColumn10.FieldName = "Tanggal"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 1
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Vendor"
    Me.GridColumn11.FieldName = "Vendor.Nama"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 2
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "Catatan"
    Me.GridColumn12.FieldName = "Catatan"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 3
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "Uang"
    Me.GridColumn13.FieldName = "Uang.Kode"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 4
    '
    'GridColumn14
    '
    Me.GridColumn14.Caption = "Total"
    Me.GridColumn14.DisplayFormat.FormatString = "n2"
    Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn14.FieldName = "TotalIDR"
    Me.GridColumn14.Name = "GridColumn14"
    Me.GridColumn14.Visible = True
    Me.GridColumn14.VisibleIndex = 5
    '
    'xGridMainView
    '
    Me.xGridMainView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colTanggal, Me.GridColumn8, Me.colCatatan, Me.GridColumn7, Me.colTotal, Me.colTotalCost, Me.colTotalImportDuty, Me.colTotalPembelian, Me.GridColumn15})
    Me.xGridMainView.GridControl = Me.xGridMain
    Me.xGridMainView.Name = "xGridMainView"
    Me.xGridMainView.NewItemRowText = "Tambah Data"
    Me.xGridMainView.OptionsBehavior.Editable = False
    Me.xGridMainView.OptionsBehavior.ReadOnly = True
    Me.xGridMainView.OptionsCustomization.AllowGroup = False
    Me.xGridMainView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridMainView.OptionsView.ShowFooter = True
    Me.xGridMainView.OptionsView.ShowGroupPanel = False
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 1
    '
    'colTanggal
    '
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 2
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Vendor"
    Me.GridColumn8.FieldName = "Vendor.Nama"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 3
    '
    'colCatatan
    '
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 4
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Uang"
    Me.GridColumn7.FieldName = "Uang.Kode"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 5
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total Pembelian"
    Me.colTotal.DisplayFormat.FormatString = "n2"
    Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTotal.FieldName = "TotalIDR"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 6
    '
    'colTotalCost
    '
    Me.colTotalCost.Caption = "Total Cost"
    Me.colTotalCost.DisplayFormat.FormatString = "n2"
    Me.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTotalCost.FieldName = "TotalCostBukanImportDutyIDR"
    Me.colTotalCost.Name = "colTotalCost"
    Me.colTotalCost.Visible = True
    Me.colTotalCost.VisibleIndex = 7
    '
    'colTotalImportDuty
    '
    Me.colTotalImportDuty.Caption = "Import Duty"
    Me.colTotalImportDuty.DisplayFormat.FormatString = "n2"
    Me.colTotalImportDuty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTotalImportDuty.FieldName = "TotalCostImportDutyIDR"
    Me.colTotalImportDuty.Name = "colTotalImportDuty"
    Me.colTotalImportDuty.Visible = True
    Me.colTotalImportDuty.VisibleIndex = 8
    '
    'colTotalPembelian
    '
    Me.colTotalPembelian.Caption = "Total"
    Me.colTotalPembelian.DisplayFormat.FormatString = "n2"
    Me.colTotalPembelian.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTotalPembelian.FieldName = "TotalPembelianIDR"
    Me.colTotalPembelian.Name = "colTotalPembelian"
    Me.colTotalPembelian.Visible = True
    Me.colTotalPembelian.VisibleIndex = 9
    '
    'GridColumn15
    '
    Me.GridColumn15.Caption = "No PO"
    Me.GridColumn15.FieldName = "NoOrder.Kode"
    Me.GridColumn15.Name = "GridColumn15"
    Me.GridColumn15.Visible = True
    Me.GridColumn15.VisibleIndex = 0
    '
    'UI_FusohDataCostSheet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(901, 504)
    Me.Controls.Add(Me.xGridMain)
    Me.Name = "UI_FusohDataCostSheet"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Data Cost Sheet"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDetailView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridMain, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDetailCostView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridMainView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents xGridMain As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridMainView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
	Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents xGridDetailView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents xGridDetailCostView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalPembelian As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCostLain As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotalImportDuty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDetTotalImportDuty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
End Class
