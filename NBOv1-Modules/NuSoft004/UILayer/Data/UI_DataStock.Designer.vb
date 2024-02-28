<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_DataStock
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
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGrid.Location = New System.Drawing.Point(0, 0)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(411, 237)
    Me.xGrid.TabIndex = 0
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colNama, Me.colStock, Me.colSatuan})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colKode
    '
    Me.colKode.Caption = "Kode Gudang"
    Me.colKode.FieldName = "Gudang.Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colNama
    '
    Me.colNama.Caption = "Nama Gudang"
    Me.colNama.FieldName = "Gudang.Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    '
    'colStock
    '
    Me.colStock.Caption = "Stock"
    Me.colStock.FieldName = "Stock"
    Me.colStock.Name = "colStock"
    Me.colStock.Visible = True
    Me.colStock.VisibleIndex = 2
    '
    'colSatuan
    '
    Me.colSatuan.Caption = "Satuan"
    Me.colSatuan.FieldName = "Barang.Satuan.Kode"
    Me.colSatuan.Name = "colSatuan"
    Me.colSatuan.Visible = True
    Me.colSatuan.VisibleIndex = 3
    '
    'UI_DataStock
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(411, 237)
    Me.Controls.Add(Me.xGrid)
    Me.Name = "UI_DataStock"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Data Stock"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
End Class
