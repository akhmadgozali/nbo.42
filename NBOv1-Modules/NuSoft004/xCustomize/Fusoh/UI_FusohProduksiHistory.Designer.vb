<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohProduksiHistory
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
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colNoBukti = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPelanggan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOut = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.xGrid.Size = New System.Drawing.Size(890, 427)
		Me.xGrid.TabIndex = 0
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoBukti, Me.colTanggal, Me.colPelanggan, Me.colQtyOut, Me.colSatuan, Me.colHarga, Me.colTotal})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colNoBukti
		'
		Me.colNoBukti.Caption = "No. Bukti"
		Me.colNoBukti.FieldName = "Main.Kode"
		Me.colNoBukti.Name = "colNoBukti"
		Me.colNoBukti.Visible = True
		Me.colNoBukti.VisibleIndex = 0
		Me.colNoBukti.Width = 120
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggal.FieldName = "Main.Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		Me.colTanggal.Width = 120
		'
		'colPelanggan
		'
		Me.colPelanggan.Caption = "Pelanggan"
		Me.colPelanggan.FieldName = "Main.Pelanggan.Nama"
		Me.colPelanggan.Name = "colPelanggan"
		Me.colPelanggan.Visible = True
		Me.colPelanggan.VisibleIndex = 2
		Me.colPelanggan.Width = 250
		'
		'colQtyOut
		'
		Me.colQtyOut.Caption = "Qty"
		Me.colQtyOut.DisplayFormat.FormatString = "n0"
		Me.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyOut.FieldName = "QtyOut"
		Me.colQtyOut.Name = "colQtyOut"
		Me.colQtyOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQtyOut.Visible = True
		Me.colQtyOut.VisibleIndex = 3
		Me.colQtyOut.Width = 90
		'
		'colSatuan
		'
		Me.colSatuan.Caption = "Satuan"
		Me.colSatuan.FieldName = "Satuan.Nama"
		Me.colSatuan.Name = "colSatuan"
		Me.colSatuan.Visible = True
		Me.colSatuan.VisibleIndex = 4
		Me.colSatuan.Width = 90
		'
		'colHarga
		'
		Me.colHarga.Caption = "Harga"
		Me.colHarga.DisplayFormat.FormatString = "n2"
		Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga.FieldName = "Harga"
		Me.colHarga.Name = "colHarga"
		Me.colHarga.Visible = True
		Me.colHarga.VisibleIndex = 5
		Me.colHarga.Width = 90
		'
		'colTotal
		'
		Me.colTotal.Caption = "Total"
		Me.colTotal.DisplayFormat.FormatString = "n2"
		Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colTotal.FieldName = "TotalHPP"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalHPP", "{0:n2}")})
		Me.colTotal.Visible = True
		Me.colTotal.VisibleIndex = 6
		Me.colTotal.Width = 112
		'
		'UI_FusohProduksiHistory
		'
		Me.AllowMdiBar = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(890, 427)
		Me.Controls.Add(Me.xGrid)
		Me.IsMdiContainer = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "UI_FusohProduksiHistory"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "History Stock"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colNoBukti As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPelanggan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOut As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
End Class
