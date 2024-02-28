<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohForecast
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
		Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaPart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLotPerBatang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBln09StokAkhir = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTahun, Me.colBulan, Me.colCustomer, Me.colTanggal, Me.colPartNo, Me.colNamaPart, Me.colMaterial, Me.colLotPerBatang, Me.colBln09StokAkhir, Me.colKeterangan, Me.colId})
		Me.xGridView.GroupCount = 2
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Descending)})
		'
		'ifSource
		'
		Me.ifSource.DisplayableProperties = "Id;Tanggal;Customer.Nama;BahanJadi.Kode;BahanJadi.Nama;BahanJadi.NamaPart;BahanBa" &
	"ku.Kode;LotPerBatang;Bln09StokAkhir;Tahun;Bulan;Keterangan"
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.Fusoh_Forecast)
		'
		'barMenu
		'
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'colTahun
		'
		Me.colTahun.Caption = "Tahun"
		Me.colTahun.FieldName = "Tahun"
		Me.colTahun.Name = "colTahun"
		Me.colTahun.Visible = True
		Me.colTahun.VisibleIndex = 0
		Me.colTahun.Width = 100
		'
		'colNamaPart
		'
		Me.colNamaPart.Caption = "Part Name"
		Me.colNamaPart.FieldName = "BahanJadi.NamaPart"
		Me.colNamaPart.Name = "colNamaPart"
		Me.colNamaPart.Visible = True
		Me.colNamaPart.VisibleIndex = 3
		Me.colNamaPart.Width = 100
		'
		'colBulan
		'
		Me.colBulan.Caption = "Bulan"
		Me.colBulan.DisplayFormat.FormatString = "MMMM"
		Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.FieldName = "Bulan"
		Me.colBulan.GroupFormat.FormatString = "MMMM"
		Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.Name = "colBulan"
		Me.colBulan.Visible = True
		Me.colBulan.VisibleIndex = 0
		Me.colBulan.Width = 100
		'
		'colPartNo
		'
		Me.colPartNo.Caption = "Part No"
		Me.colPartNo.FieldName = "BahanJadi.Kode"
		Me.colPartNo.Name = "colPartNo"
		Me.colPartNo.Visible = True
		Me.colPartNo.VisibleIndex = 2
		Me.colPartNo.Width = 70
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'colCustomer
		'
		Me.colCustomer.Caption = "Customer"
		Me.colCustomer.FieldName = "Customer.Nama"
		Me.colCustomer.Name = "colCustomer"
		Me.colCustomer.Visible = True
		Me.colCustomer.VisibleIndex = 0
		Me.colCustomer.Width = 150
		'
		'colTanggal
		'
		Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		Me.colTanggal.Width = 90
		'
		'colMaterial
		'
		Me.colMaterial.Caption = "Material"
		Me.colMaterial.FieldName = "BahanBaku.Kode"
		Me.colMaterial.Name = "colMaterial"
		Me.colMaterial.Visible = True
		Me.colMaterial.VisibleIndex = 4
		Me.colMaterial.Width = 100
		'
		'colLotPerBatang
		'
		Me.colLotPerBatang.DisplayFormat.FormatString = "n0"
		Me.colLotPerBatang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLotPerBatang.FieldName = "LotPerBatang"
		Me.colLotPerBatang.Name = "colLotPerBatang"
		Me.colLotPerBatang.Visible = True
		Me.colLotPerBatang.VisibleIndex = 5
		Me.colLotPerBatang.Width = 60
		'
		'colBln09StokAkhir
		'
		Me.colBln09StokAkhir.Caption = "Stok Akhir"
		Me.colBln09StokAkhir.DisplayFormat.FormatString = "n0"
		Me.colBln09StokAkhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colBln09StokAkhir.FieldName = "Bln09StokAkhir"
		Me.colBln09StokAkhir.Name = "colBln09StokAkhir"
		Me.colBln09StokAkhir.Visible = True
		Me.colBln09StokAkhir.VisibleIndex = 6
		Me.colBln09StokAkhir.Width = 60
		'
		'colKeterangan
		'
		Me.colKeterangan.FieldName = "Keterangan"
		Me.colKeterangan.Name = "colKeterangan"
		Me.colKeterangan.Visible = True
		Me.colKeterangan.VisibleIndex = 7
		Me.colKeterangan.Width = 111
		'
		'UI_FusohForecast
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_FusohForecast"
		Me.Text = "Forecast"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaPart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPartNo As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMaterial As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLotPerBatang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBln09StokAkhir As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
End Class
