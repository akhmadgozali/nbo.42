<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SanYuOrderPenjualanHistory
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
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJenisPenjualan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyPcs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyRencanaProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGrid.Location = New System.Drawing.Point(0, 0)
    Me.xGrid.MainView = Me.gridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(875, 393)
    Me.xGrid.TabIndex = 0
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
    '
    'gridView
    '
    Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.colQty, Me.colJenisPenjualan, Me.colHarga, Me.colTotal, Me.colQtyPcs, Me.colQtyRencanaProduksi})
    Me.gridView.GridControl = Me.xGrid
    Me.gridView.Name = "gridView"
    Me.gridView.OptionsDetail.EnableMasterViewMode = False
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Kode Item"
    Me.GridColumn2.FieldName = "Barang.Kode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 0
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Nama Item"
    Me.GridColumn3.FieldName = "Barang.Nama"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 1
    '
    'colQty
    '
    Me.colQty.Caption = "Qty"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 2
    '
    'colJenisPenjualan
    '
    Me.colJenisPenjualan.Caption = "Satuan"
    Me.colJenisPenjualan.FieldName = "JenisPenjualan"
    Me.colJenisPenjualan.Name = "colJenisPenjualan"
    Me.colJenisPenjualan.Visible = True
    Me.colJenisPenjualan.VisibleIndex = 3
    '
    'colHarga
    '
    Me.colHarga.Caption = "Harga"
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    Me.colHarga.Visible = True
    Me.colHarga.VisibleIndex = 4
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total"
    Me.colTotal.FieldName = "Total"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 5
    '
    'colQtyPcs
    '
    Me.colQtyPcs.Caption = "Qty PCE"
    Me.colQtyPcs.FieldName = "QtyPcs"
    Me.colQtyPcs.Name = "colQtyPcs"
    Me.colQtyPcs.Visible = True
    Me.colQtyPcs.VisibleIndex = 6
    '
    'colQtyRencanaProduksi
    '
    Me.colQtyRencanaProduksi.Caption = "Qty Prod"
    Me.colQtyRencanaProduksi.FieldName = "QtyRencanaProduksi"
    Me.colQtyRencanaProduksi.Name = "colQtyRencanaProduksi"
    Me.colQtyRencanaProduksi.Visible = True
    Me.colQtyRencanaProduksi.VisibleIndex = 7
    '
    'UI_SanYuOrderPenjualanHistory
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(875, 393)
    Me.Controls.Add(Me.xGrid)
    Me.Name = "UI_SanYuOrderPenjualanHistory"
    Me.Text = "UI_SanYuOrderPenjualanHistory"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJenisPenjualan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyPcs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyRencanaProduksi As DevExpress.XtraGrid.Columns.GridColumn
End Class
