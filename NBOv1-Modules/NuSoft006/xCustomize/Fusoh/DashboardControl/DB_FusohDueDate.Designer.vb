Imports NuSoft.Core.Win.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DB_FusohDueDate
	Inherits NuSoftUserControl

	'UserControl overrides dispose to clean up the component list.
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
		Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
		Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
		Me.xGridViewSJ = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridViewSO = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPOLine = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDeadline = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyKirim = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtySisa = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.xGridViewSJ, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridViewSO, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGridViewSJ
		'
		Me.xGridViewSJ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn11, Me.GridColumn13, Me.GridColumn14})
		Me.xGridViewSJ.GridControl = Me.xGrid
		Me.xGridViewSJ.Name = "xGridViewSJ"
		Me.xGridViewSJ.OptionsBehavior.Editable = False
		Me.xGridViewSJ.OptionsBehavior.ReadOnly = True
		Me.xGridViewSJ.OptionsDetail.EnableMasterViewMode = False
		Me.xGridViewSJ.OptionsView.ShowGroupPanel = False
		'
		'GridColumn7
		'
		Me.GridColumn7.Caption = "Tanggal"
		Me.GridColumn7.FieldName = "Main.Tanggal"
		Me.GridColumn7.Name = "GridColumn7"
		Me.GridColumn7.Visible = True
		Me.GridColumn7.VisibleIndex = 0
		'
		'GridColumn8
		'
		Me.GridColumn8.Caption = "No Transaksi"
		Me.GridColumn8.FieldName = "Main.Kode"
		Me.GridColumn8.Name = "GridColumn8"
		Me.GridColumn8.Visible = True
		Me.GridColumn8.VisibleIndex = 1
		'
		'GridColumn9
		'
		Me.GridColumn9.Caption = "Qty"
		Me.GridColumn9.FieldName = "QtySJ"
		Me.GridColumn9.Name = "GridColumn9"
		Me.GridColumn9.Visible = True
		Me.GridColumn9.VisibleIndex = 2
		'
		'GridColumn11
		'
		Me.GridColumn11.Caption = "Sumber"
		Me.GridColumn11.FieldName = "Main.Sumber.Kode"
		Me.GridColumn11.Name = "GridColumn11"
		'
		'GridColumn13
		'
		Me.GridColumn13.Caption = "No Produksi"
		Me.GridColumn13.FieldName = "ProduksiDetail.Main.Kode"
		Me.GridColumn13.Name = "GridColumn13"
		Me.GridColumn13.Visible = True
		Me.GridColumn13.VisibleIndex = 3
		'
		'GridColumn14
		'
		Me.GridColumn14.Caption = "No SO Produksi"
		Me.GridColumn14.FieldName = "ProduksiDetail.SODetail.Main.Kode"
		Me.GridColumn14.Name = "GridColumn14"
		'
		'xGrid
		'
		Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
		GridLevelNode2.LevelTemplate = Me.xGridViewSJ
		GridLevelNode2.RelationName = "SuratJalanDetail"
		Me.xGrid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
		Me.xGrid.Location = New System.Drawing.Point(0, 0)
		Me.xGrid.MainView = Me.xGridViewSO
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(900, 483)
		Me.xGrid.TabIndex = 9
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridViewSO, Me.xGridViewSJ})
		'
		'xGridViewSO
		'
		Me.xGridViewSO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colTanggal, Me.colCustomer, Me.colKodeBarang, Me.colNamaBarang, Me.colPOLine, Me.colDeliveryDate, Me.colDeadline, Me.colQty, Me.colQtyKirim, Me.colQtySisa})
		StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		StyleFormatCondition2.Appearance.Options.UseBackColor = True
		StyleFormatCondition2.ApplyToRow = True
		StyleFormatCondition2.Column = Me.colDeadline
		StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
		StyleFormatCondition2.Value1 = 0
		Me.xGridViewSO.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
		Me.xGridViewSO.GridControl = Me.xGrid
		Me.xGridViewSO.Name = "xGridViewSO"
		Me.xGridViewSO.OptionsBehavior.Editable = False
		Me.xGridViewSO.OptionsBehavior.ReadOnly = True
		Me.xGridViewSO.OptionsDetail.SmartDetailHeight = True
		Me.xGridViewSO.OptionsView.ShowAutoFilterRow = True
		Me.xGridViewSO.OptionsView.ShowGroupPanel = False
		'
		'colKode
		'
		Me.colKode.Caption = "Kode"
		Me.colKode.FieldName = "Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 0
		'
		'colTanggal
		'
		Me.colTanggal.Caption = "Tanggal"
		Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 1
		'
		'colCustomer
		'
		Me.colCustomer.Caption = "Pelanggan"
		Me.colCustomer.FieldName = "Customer"
		Me.colCustomer.Name = "colCustomer"
		Me.colCustomer.Visible = True
		Me.colCustomer.VisibleIndex = 2
		'
		'colKodeBarang
		'
		Me.colKodeBarang.Caption = "Kode Barang"
		Me.colKodeBarang.FieldName = "BarangKode"
		Me.colKodeBarang.Name = "colKodeBarang"
		Me.colKodeBarang.Visible = True
		Me.colKodeBarang.VisibleIndex = 3
		'
		'colNamaBarang
		'
		Me.colNamaBarang.Caption = "Nama Barang"
		Me.colNamaBarang.FieldName = "BarangNama"
		Me.colNamaBarang.Name = "colNamaBarang"
		Me.colNamaBarang.Visible = True
		Me.colNamaBarang.VisibleIndex = 4
		'
		'colPOLine
		'
		Me.colPOLine.FieldName = "POLine"
		Me.colPOLine.Name = "colPOLine"
		Me.colPOLine.Visible = True
		Me.colPOLine.VisibleIndex = 5
		'
		'colDeliveryDate
		'
		Me.colDeliveryDate.Caption = "Tgl. Delivery"
		Me.colDeliveryDate.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colDeliveryDate.FieldName = "TanggalDelivery"
		Me.colDeliveryDate.Name = "colDeliveryDate"
		Me.colDeliveryDate.Visible = True
		Me.colDeliveryDate.VisibleIndex = 6
		'
		'colDeadline
		'
		Me.colDeadline.Caption = "Deadline"
		Me.colDeadline.FieldName = "Deadline"
		Me.colDeadline.Name = "colDeadline"
		Me.colDeadline.Visible = True
		Me.colDeadline.VisibleIndex = 7
		'
		'colQty
		'
		Me.colQty.FieldName = "QtyOrder"
		Me.colQty.Name = "colQty"
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 8
		'
		'colQtyKirim
		'
		Me.colQtyKirim.FieldName = "QtyKirim"
		Me.colQtyKirim.Name = "colQtyKirim"
		Me.colQtyKirim.Visible = True
		Me.colQtyKirim.VisibleIndex = 9
		'
		'colQtySisa
		'
		Me.colQtySisa.Caption = "Qty Sisa"
		Me.colQtySisa.FieldName = "QtySisa"
		Me.colQtySisa.Name = "colQtySisa"
		Me.colQtySisa.Visible = True
		Me.colQtySisa.VisibleIndex = 10
		'
		'DB_FusohDueDate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.xGrid)
		Me.Name = "DB_FusohDueDate"
		Me.Size = New System.Drawing.Size(900, 483)
		CType(Me.xGridViewSJ, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridViewSO, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridViewSJ As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents xGridViewSO As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyKirim As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtySisa As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPOLine As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDeadline As DevExpress.XtraGrid.Columns.GridColumn
End Class
