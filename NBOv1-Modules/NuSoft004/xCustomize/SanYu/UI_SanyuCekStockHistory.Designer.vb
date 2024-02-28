<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanyuCekStockHistory
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
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyIn = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGrid.Location = New System.Drawing.Point(0, 0)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(890, 427)
    Me.xGrid.TabIndex = 0
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView, Me.GridView1})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.colQtyIn, Me.colQtyOut, Me.colHarga, Me.colID})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "No Bukti"
    Me.GridColumn1.FieldName = "Main.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tanggal"
    Me.GridColumn2.FieldName = "Main.Tanggal"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode Barang"
    Me.GridColumn3.FieldName = "Barang.Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Nama Barang"
    Me.GridColumn4.FieldName = "Barang.Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Satuan"
    Me.GridColumn5.FieldName = "Satuan.Kode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    '
    'colQtyIn
    '
    Me.colQtyIn.Caption = "Qty In"
    Me.colQtyIn.DisplayFormat.FormatString = "n0"
    Me.colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQtyIn.FieldName = "QtyIn"
    Me.colQtyIn.Name = "colQtyIn"
    Me.colQtyIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQtyIn.Visible = True
    Me.colQtyIn.VisibleIndex = 5
    '
    'colQtyOut
    '
    Me.colQtyOut.Caption = "Qty Out"
    Me.colQtyOut.DisplayFormat.FormatString = "n0"
    Me.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colQtyOut.FieldName = "QtyOut"
    Me.colQtyOut.Name = "colQtyOut"
    Me.colQtyOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQtyOut.Visible = True
    Me.colQtyOut.VisibleIndex = 6
    '
    'colHarga
    '
    Me.colHarga.Caption = "Harga"
    Me.colHarga.DisplayFormat.FormatString = "n2"
    Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    '
    'colID
    '
    Me.colID.Caption = "Id"
    Me.colID.FieldName = "Id"
    Me.colID.Name = "colID"
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
    Me.GridView1.GridControl = Me.xGrid
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Serial"
    Me.GridColumn6.FieldName = "Serial"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 0
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Length IN"
    Me.GridColumn7.FieldName = "LengthIn"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 1
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Length OUT"
    Me.GridColumn8.FieldName = "LengthOut"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 2
    '
    'UI_SanyuCekStockHistory
    '
    Me.AllowMdiBar = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(890, 427)
    Me.Controls.Add(Me.xGrid)
    Me.IsMdiContainer = True
    Me.Name = "UI_SanyuCekStockHistory"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "History Stock"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
End Class
