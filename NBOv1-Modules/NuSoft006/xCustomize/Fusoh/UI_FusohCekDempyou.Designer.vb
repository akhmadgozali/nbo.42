<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohCekDempyou
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
		Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
		Me.xGridProduksi = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colStatusTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridProduksi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGridProduksi
		'
		Me.xGridProduksi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn46, Me.GridColumn47, Me.colQtyProduksi, Me.GridColumn48, Me.GridColumn50})
		Me.xGridProduksi.GridControl = Me.xGrid
		Me.xGridProduksi.Name = "xGridProduksi"
		Me.xGridProduksi.OptionsBehavior.Editable = False
		Me.xGridProduksi.OptionsDetail.EnableMasterViewMode = False
		Me.xGridProduksi.OptionsView.ShowGroupPanel = False
		'
		'GridColumn46
		'
		Me.GridColumn46.Caption = "No Bukti"
		Me.GridColumn46.FieldName = "Kode"
		Me.GridColumn46.Name = "GridColumn46"
		Me.GridColumn46.Visible = True
		Me.GridColumn46.VisibleIndex = 1
		'
		'GridColumn47
		'
		Me.GridColumn47.Caption = "Tanggal"
		Me.GridColumn47.FieldName = "Tanggal"
		Me.GridColumn47.Name = "GridColumn47"
		Me.GridColumn47.Visible = True
		Me.GridColumn47.VisibleIndex = 2
		'
		'colQtyProduksi
		'
		Me.colQtyProduksi.Caption = "Qty"
		Me.colQtyProduksi.FieldName = "TotalQty"
		Me.colQtyProduksi.Name = "colQtyProduksi"
		Me.colQtyProduksi.Visible = True
		Me.colQtyProduksi.VisibleIndex = 3
		'
		'GridColumn48
		'
		Me.GridColumn48.Caption = "Status"
		Me.GridColumn48.FieldName = "StatusTransaksi"
		Me.GridColumn48.Name = "GridColumn48"
		Me.GridColumn48.Visible = True
		Me.GridColumn48.VisibleIndex = 4
		'
		'GridColumn50
		'
		Me.GridColumn50.Caption = "Sumber"
		Me.GridColumn50.FieldName = "Sumber.Kode"
		Me.GridColumn50.Name = "GridColumn50"
		Me.GridColumn50.Visible = True
		Me.GridColumn50.VisibleIndex = 0
		'
		'xGrid
		'
		Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
		GridLevelNode1.LevelTemplate = Me.xGridProduksi
		GridLevelNode1.RelationName = "Produksi"
		Me.xGrid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
		Me.xGrid.Location = New System.Drawing.Point(0, 0)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(800, 450)
		Me.xGrid.TabIndex = 11
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView, Me.xGridProduksi})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId2, Me.colTanggal, Me.colKode, Me.GridColumn1, Me.GridColumn2, Me.colQty, Me.colStatusTransaksi, Me.GridColumn3, Me.GridColumn4})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsBehavior.ReadOnly = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colId2
		'
		Me.colId2.FieldName = "Id"
		Me.colId2.Name = "colId2"
		Me.colId2.OptionsColumn.ReadOnly = True
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 0
		'
		'colKode
		'
		Me.colKode.Caption = "No Dempyou"
		Me.colKode.FieldName = "Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 1
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Part No"
		Me.GridColumn1.FieldName = "KodeBarang"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 2
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Part Name"
		Me.GridColumn2.FieldName = "NamaBarang"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 3
		'
		'colQty
		'
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 4
		'
		'colStatusTransaksi
		'
		Me.colStatusTransaksi.FieldName = "StatusTransaksi"
		Me.colStatusTransaksi.Name = "colStatusTransaksi"
		Me.colStatusTransaksi.Visible = True
		Me.colStatusTransaksi.VisibleIndex = 5
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "QtyCutting"
		Me.GridColumn3.FieldName = "QtyCutting"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 6
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Qty Produksi"
		Me.GridColumn4.FieldName = "QtyProduksi"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 7
		'
		'UI_FusohCekDempyou
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.xGrid)
		Me.Name = "UI_FusohCekDempyou"
		Me.Text = "UI_FusohCekDempyou"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridProduksi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatusTransaksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents xGridProduksi As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyProduksi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
End Class
