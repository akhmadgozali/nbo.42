<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohSaldoAwal
  Inherits Core.Win.Forms.GridInput

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohSaldoAwal))
		Me.colTipeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.DataSource = Me.ifSource
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipeBarang, Me.colKodeBarang, Me.colNamaBarang, Me.colCustomer, Me.colSatuan, Me.colQtyIn, Me.colHargaIn, Me.colTotal, Me.colId})
		Me.xGridView.GroupCount = 1
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.ShowAutoFilterRow = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTipeBarang, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'ifSource
		'
		Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_StokDetail)
		'
		'barMenu
		'
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'colTipeBarang
		'
		Me.colTipeBarang.Caption = "Tipe Barang"
		Me.colTipeBarang.FieldName = "Barang.TipeBarang"
		Me.colTipeBarang.Name = "colTipeBarang"
		Me.colTipeBarang.Visible = True
		Me.colTipeBarang.VisibleIndex = 3
		'
		'colKodeBarang
		'
		Me.colKodeBarang.Caption = "Part No."
		Me.colKodeBarang.FieldName = "Barang.Kode"
		Me.colKodeBarang.Name = "colKodeBarang"
		Me.colKodeBarang.Visible = True
		Me.colKodeBarang.VisibleIndex = 0
		Me.colKodeBarang.Width = 110
		'
		'colNamaBarang
		'
		Me.colNamaBarang.Caption = "Material"
		Me.colNamaBarang.FieldName = "Barang.Nama"
		Me.colNamaBarang.Name = "colNamaBarang"
		Me.colNamaBarang.Visible = True
		Me.colNamaBarang.VisibleIndex = 1
		Me.colNamaBarang.Width = 113
		'
		'colSatuan
		'
		Me.colSatuan.Caption = "Satuan"
		Me.colSatuan.FieldName = "Satuan.Kode"
		Me.colSatuan.Name = "colSatuan"
		Me.colSatuan.Visible = True
		Me.colSatuan.VisibleIndex = 3
		Me.colSatuan.Width = 89
		'
		'colQtyIn
		'
		Me.colQtyIn.Caption = "Qty"
		Me.colQtyIn.FieldName = "QtyIn"
		Me.colQtyIn.Name = "colQtyIn"
		Me.colQtyIn.Visible = True
		Me.colQtyIn.VisibleIndex = 4
		Me.colQtyIn.Width = 46
		'
		'colHargaIn
		'
		Me.colHargaIn.Caption = "Harga"
		Me.colHargaIn.FieldName = "Harga"
		Me.colHargaIn.Name = "colHargaIn"
		Me.colHargaIn.Visible = True
		Me.colHargaIn.VisibleIndex = 5
		Me.colHargaIn.Width = 59
		'
		'colCustomer
		'
		Me.colCustomer.Caption = "Customer"
		Me.colCustomer.FieldName = "Barang.Customer.Nama"
		Me.colCustomer.Name = "colCustomer"
		Me.colCustomer.Visible = True
		Me.colCustomer.VisibleIndex = 2
		'
		'colTotal
		'
		Me.colTotal.Caption = "Total"
		Me.colTotal.DisplayFormat.FormatString = "n0"
		Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colTotal.FieldName = "colTotal"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colTotal", "{0:n0}")})
		Me.colTotal.UnboundExpression = "[QtyIn] * [Harga]"
		Me.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colTotal.Visible = True
		Me.colTotal.VisibleIndex = 6
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'UI_FusohSaldoAwal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_FusohSaldoAwal"
		Me.Text = "Saldo Awal Stok"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents colTipeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyIn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHargaIn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
End Class
