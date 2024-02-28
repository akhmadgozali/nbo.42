<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_CekStockHPP
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
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.gridCariHPP = New DevExpress.XtraGrid.GridControl()
    Me.gridCariHPPView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiHPP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnCari = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid2 = New DevExpress.XtraGrid.GridControl()
    Me.xGridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xGrid1 = New DevExpress.XtraGrid.GridControl()
    Me.xGridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.cold_qtyin = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.cold_used = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.cold_available = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.gridCariHPP, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gridCariHPPView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.btnExport)
    Me.LayoutControl1.Controls.Add(Me.gridCariHPP)
    Me.LayoutControl1.Controls.Add(Me.btnCari)
    Me.LayoutControl1.Controls.Add(Me.txtNoTransaksi)
    Me.LayoutControl1.Controls.Add(Me.xGrid2)
    Me.LayoutControl1.Controls.Add(Me.xGrid1)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(819, 405)
    Me.LayoutControl1.TabIndex = 0
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'gridCariHPP
    '
    Me.gridCariHPP.Location = New System.Drawing.Point(421, 93)
    Me.gridCariHPP.MainView = Me.gridCariHPPView
    Me.gridCariHPP.Name = "gridCariHPP"
    Me.gridCariHPP.Size = New System.Drawing.Size(374, 288)
    Me.gridCariHPP.TabIndex = 8
    Me.gridCariHPP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridCariHPPView})
    '
    'gridCariHPPView
    '
    Me.gridCariHPPView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn5, Me.colQty1, Me.colNilaiHPP, Me.GridColumn9, Me.GridColumn10, Me.GridColumn7, Me.GridColumn8, Me.GridColumn11})
    Me.gridCariHPPView.GridControl = Me.gridCariHPP
    Me.gridCariHPPView.Name = "gridCariHPPView"
    Me.gridCariHPPView.OptionsBehavior.Editable = False
    Me.gridCariHPPView.OptionsDetail.EnableMasterViewMode = False
    Me.gridCariHPPView.OptionsView.ShowFooter = True
    Me.gridCariHPPView.OptionsView.ShowGroupPanel = False
    Me.gridCariHPPView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Tanggal"
    Me.GridColumn6.FieldName = "Detail.Main.Tanggal"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 1
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "No Transaksi"
    Me.GridColumn5.FieldName = "Detail.Main.Kode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 0
    '
    'colQty1
    '
    Me.colQty1.Caption = "Qty"
    Me.colQty1.FieldName = "Qty"
    Me.colQty1.Name = "colQty1"
    Me.colQty1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQty1.Visible = True
    Me.colQty1.VisibleIndex = 3
    '
    'colNilaiHPP
    '
    Me.colNilaiHPP.Caption = "Nilai HPP"
    Me.colNilaiHPP.FieldName = "NilaiHPP"
    Me.colNilaiHPP.Name = "colNilaiHPP"
    Me.colNilaiHPP.Visible = True
    Me.colNilaiHPP.VisibleIndex = 4
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "Kode Barang Out"
    Me.GridColumn9.FieldName = "Detail.Barang.Kode"
    Me.GridColumn9.Name = "GridColumn9"
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Nama Barang Out"
    Me.GridColumn10.FieldName = "Detail.Barang.Nama"
    Me.GridColumn10.Name = "GridColumn10"
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Kode Barang In"
    Me.GridColumn7.FieldName = "DetailIN.Barang.Kode"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 2
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Nama Barang ‌In"
    Me.GridColumn8.FieldName = "DetailIN.Barang.Nama"
    Me.GridColumn8.Name = "GridColumn8"
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Harga In"
    Me.GridColumn11.FieldName = "DetailIN.NilaiIN"
    Me.GridColumn11.Name = "GridColumn11"
    '
    'btnCari
    '
    Me.btnCari.Location = New System.Drawing.Point(485, 67)
    Me.btnCari.Name = "btnCari"
    Me.btnCari.Size = New System.Drawing.Size(160, 22)
    Me.btnCari.StyleController = Me.LayoutControl1
    Me.btnCari.TabIndex = 7
    Me.btnCari.Text = "Cari"
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(485, 43)
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Size = New System.Drawing.Size(310, 20)
    Me.txtNoTransaksi.StyleController = Me.LayoutControl1
    Me.txtNoTransaksi.TabIndex = 6
    '
    'xGrid2
    '
    Me.xGrid2.Location = New System.Drawing.Point(36, 202)
    Me.xGrid2.MainView = Me.xGridView2
    Me.xGrid2.Name = "xGrid2"
    Me.xGrid2.Size = New System.Drawing.Size(345, 167)
    Me.xGrid2.TabIndex = 5
    Me.xGrid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView2})
    '
    'xGridView2
    '
    Me.xGridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.colQty})
    Me.xGridView2.GridControl = Me.xGrid2
    Me.xGridView2.Name = "xGridView2"
    Me.xGridView2.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView2.OptionsView.ShowFooter = True
    Me.xGridView2.OptionsView.ShowGroupPanel = False
    Me.xGridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn4, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "No Bukti"
    Me.GridColumn1.FieldName = "Detail.Main.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Tanggal"
    Me.GridColumn3.FieldName = "Detail.Main.Tanggal"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 1
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Qty"
    Me.GridColumn4.FieldName = "Detail.QtyOut"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 2
    '
    'colQty
    '
    Me.colQty.Caption = "Qty HPP IN"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 3
    '
    'xGrid1
    '
    Me.xGrid1.Location = New System.Drawing.Point(24, 59)
    Me.xGrid1.MainView = Me.xGridView1
    Me.xGrid1.Name = "xGrid1"
    Me.xGrid1.Size = New System.Drawing.Size(369, 108)
    Me.xGrid1.TabIndex = 4
    Me.xGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView1})
    '
    'xGridView1
    '
    Me.xGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoBukti, Me.GridColumn2, Me.cold_qtyin, Me.cold_used, Me.cold_available, Me.colId})
    Me.xGridView1.GridControl = Me.xGrid1
    Me.xGridView1.Name = "xGridView1"
    Me.xGridView1.OptionsCustomization.AllowGroup = False
    Me.xGridView1.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView1.OptionsView.ShowGroupPanel = False
    '
    'colNoBukti
    '
    Me.colNoBukti.Caption = "No Bukti"
    Me.colNoBukti.FieldName = "Id.Main.Kode"
    Me.colNoBukti.Name = "colNoBukti"
    Me.colNoBukti.Visible = True
    Me.colNoBukti.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tanggal"
    Me.GridColumn2.FieldName = "Id.Main.Tanggal"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'cold_qtyin
    '
    Me.cold_qtyin.Caption = "Qty"
    Me.cold_qtyin.FieldName = "d_qtyin"
    Me.cold_qtyin.Name = "cold_qtyin"
    Me.cold_qtyin.Visible = True
    Me.cold_qtyin.VisibleIndex = 2
    '
    'cold_used
    '
    Me.cold_used.Caption = "Qty Pakai"
    Me.cold_used.FieldName = "d_used"
    Me.cold_used.Name = "cold_used"
    Me.cold_used.Visible = True
    Me.cold_used.VisibleIndex = 3
    '
    'cold_available
    '
    Me.cold_available.Caption = "Sisa"
    Me.cold_available.FieldName = "d_available"
    Me.cold_available.Name = "cold_available"
    Me.cold_available.Visible = True
    Me.cold_available.VisibleIndex = 4
    '
    'colId
    '
    Me.colId.Caption = "Id"
    Me.colId.FieldName = "Id.Id"
    Me.colId.Name = "colId"
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(819, 405)
    Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Pencarian HPP"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(397, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(402, 385)
    Me.LayoutControlGroup2.Text = "Pencarian HPP"
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtNoTransaksi
    Me.LayoutControlItem3.CustomizationFormText = "No Transaksi"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(378, 24)
    Me.LayoutControlItem3.Text = "No Transaksi"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(61, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.btnCari
    Me.LayoutControlItem4.CustomizationFormText = " "
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(228, 26)
    Me.LayoutControlItem4.Text = " "
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(61, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.gridCariHPP
    Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 50)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(378, 292)
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "History HPP"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.lytGroup1})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(397, 385)
    Me.LayoutControlGroup3.Text = "History HPP"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.xGrid1
    Me.LayoutControlItem1.CustomizationFormText = "Data HPP"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(373, 128)
    Me.LayoutControlItem1.Text = "Data HPP"
    Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(61, 13)
    '
    'lytGroup1
    '
    Me.lytGroup1.CustomizationFormText = "History Pemakaian HPP :"
    Me.lytGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
    Me.lytGroup1.Location = New System.Drawing.Point(0, 128)
    Me.lytGroup1.Name = "lytGroup1"
    Me.lytGroup1.Size = New System.Drawing.Size(373, 214)
    Me.lytGroup1.Text = "History Pemakaian HPP :"
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.xGrid2
    Me.LayoutControlItem2.CustomizationFormText = "Data HPP Out"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(349, 171)
    Me.LayoutControlItem2.Text = "Data HPP Out"
    Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem2.TextToControlDistance = 0
    Me.LayoutControlItem2.TextVisible = False
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(347, 0)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'btnExport
    '
    Me.btnExport.Location = New System.Drawing.Point(649, 67)
    Me.btnExport.Name = "btnExport"
    Me.btnExport.Size = New System.Drawing.Size(146, 22)
    Me.btnExport.StyleController = Me.LayoutControl1
    Me.btnExport.TabIndex = 9
    Me.btnExport.Text = "Export Grid"
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.btnExport
    Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(228, 24)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(150, 26)
    Me.LayoutControlItem6.Text = "LayoutControlItem6"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem6.TextToControlDistance = 0
    Me.LayoutControlItem6.TextVisible = False
    '
    'UI_CekStockHPP
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(819, 405)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "UI_CekStockHPP"
    Me.Text = "Data HPP"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.gridCariHPP, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gridCariHPPView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents xGrid1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGrid2 As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents cold_qtyin As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents cold_used As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents cold_available As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents lytGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnCari As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents gridCariHPP As DevExpress.XtraGrid.GridControl
  Friend WithEvents gridCariHPPView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiHPP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
