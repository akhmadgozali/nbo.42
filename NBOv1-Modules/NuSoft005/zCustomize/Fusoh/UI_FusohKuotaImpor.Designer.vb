<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohKuotaImpor
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
		Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
		Me.xGridInvoice = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeHS = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNoLampiran = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colVolume = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMataUang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNegara = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPelabuhan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colExpired = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSisa = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTerpakai = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPerijinan = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.DataSource = Me.xpCol
		GridLevelNode1.LevelTemplate = Me.xGridInvoice
		GridLevelNode1.RelationName = "Invoice"
		Me.xGrid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridInvoice})
		'
		'xpCol
		'
		Me.xpCol.DisplayableProperties = "Id;KodeHS;Keterangan;NoLampiran;Volume;Satuan.Kode;Harga;MataUang.Kode;Negara;Pel" &
		"abuhan;Expired;SisaVolume;VolumeTerpakai;NoPerijinan;Invoice"
		Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.Fusoh_KuotaImpor)
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPerijinan, Me.colKodeHS, Me.colNoLampiran, Me.colVolume, Me.colTerpakai, Me.colSisa, Me.colSatuan, Me.colHarga, Me.colMataUang, Me.colNegara, Me.colPelabuhan, Me.colExpired, Me.colKeterangan, Me.colId})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		'
		'barMenu
		'
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'xGridInvoice
		'
		Me.xGridInvoice.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn1, Me.GridColumn4, Me.colQty, Me.GridColumn5, Me.colWeight})
		Me.xGridInvoice.GridControl = Me.xGrid
		Me.xGridInvoice.Name = "xGridInvoice"
		Me.xGridInvoice.OptionsDetail.EnableMasterViewMode = False
		Me.xGridInvoice.OptionsView.ShowFooter = True
		Me.xGridInvoice.OptionsView.ShowGroupPanel = False
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "No Bukti"
		Me.GridColumn2.FieldName = "Main.Kode"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Tanggal"
		Me.GridColumn3.FieldName = "Main.Tanggal"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 2
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Part No"
		Me.GridColumn1.FieldName = "Barang.Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Part Name"
		Me.GridColumn4.FieldName = "Barang.Nama"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 3
		'
		'colQty
		'
		Me.colQty.Caption = "Qty"
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 4
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Satuan"
		Me.GridColumn5.FieldName = "Satuan.Kode"
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.Visible = True
		Me.GridColumn5.VisibleIndex = 5
		'
		'colWeight
		'
		Me.colWeight.Caption = "Weight"
		Me.colWeight.DisplayFormat.FormatString = "n2"
		Me.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colWeight.FieldName = "WeightManual"
		Me.colWeight.Name = "colWeight"
		Me.colWeight.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colWeight.Visible = True
		Me.colWeight.VisibleIndex = 6
		'
		'colKodeHS
		'
		Me.colKodeHS.FieldName = "KodeHS"
		Me.colKodeHS.Name = "colKodeHS"
		Me.colKodeHS.Visible = True
		Me.colKodeHS.VisibleIndex = 1
		'
		'colKeterangan
		'
		Me.colKeterangan.FieldName = "Keterangan"
		Me.colKeterangan.Name = "colKeterangan"
		Me.colKeterangan.Visible = True
		Me.colKeterangan.VisibleIndex = 12
		'
		'colNoLampiran
		'
		Me.colNoLampiran.FieldName = "NoLampiran"
		Me.colNoLampiran.Name = "colNoLampiran"
		Me.colNoLampiran.Visible = True
		Me.colNoLampiran.VisibleIndex = 2
		'
		'colVolume
		'
		Me.colVolume.DisplayFormat.FormatString = "n0"
		Me.colVolume.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colVolume.FieldName = "Volume"
		Me.colVolume.Name = "colVolume"
		Me.colVolume.Visible = True
		Me.colVolume.VisibleIndex = 3
		'
		'colSatuan
		'
		Me.colSatuan.Caption = "Satuan"
		Me.colSatuan.FieldName = "Satuan.Kode"
		Me.colSatuan.Name = "colSatuan"
		Me.colSatuan.OptionsColumn.ReadOnly = True
		Me.colSatuan.Visible = True
		Me.colSatuan.VisibleIndex = 6
		'
		'colHarga
		'
		Me.colHarga.DisplayFormat.FormatString = "n0"
		Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga.FieldName = "Harga"
		Me.colHarga.Name = "colHarga"
		Me.colHarga.Visible = True
		Me.colHarga.VisibleIndex = 7
		'
		'colMataUang
		'
		Me.colMataUang.Caption = "Mata Uang"
		Me.colMataUang.FieldName = "MataUang.Kode"
		Me.colMataUang.Name = "colMataUang"
		Me.colMataUang.OptionsColumn.ReadOnly = True
		Me.colMataUang.Visible = True
		Me.colMataUang.VisibleIndex = 8
		'
		'colNegara
		'
		Me.colNegara.FieldName = "Negara"
		Me.colNegara.Name = "colNegara"
		Me.colNegara.Visible = True
		Me.colNegara.VisibleIndex = 9
		'
		'colPelabuhan
		'
		Me.colPelabuhan.FieldName = "Pelabuhan"
		Me.colPelabuhan.Name = "colPelabuhan"
		Me.colPelabuhan.Visible = True
		Me.colPelabuhan.VisibleIndex = 10
		'
		'colExpired
		'
		Me.colExpired.DisplayFormat.FormatString = "dd-MMM-yy"
		Me.colExpired.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colExpired.FieldName = "Expired"
		Me.colExpired.Name = "colExpired"
		Me.colExpired.Visible = True
		Me.colExpired.VisibleIndex = 11
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'colSisa
		'
		Me.colSisa.Caption = "Sisa Volume"
		Me.colSisa.DisplayFormat.FormatString = "n0"
		Me.colSisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSisa.FieldName = "SisaVolume"
		Me.colSisa.Name = "colSisa"
		Me.colSisa.Visible = True
		Me.colSisa.VisibleIndex = 5
		'
		'colTerpakai
		'
		Me.colTerpakai.Caption = "Terpakai"
		Me.colTerpakai.DisplayFormat.FormatString = "n0"
		Me.colTerpakai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colTerpakai.FieldName = "VolumeTerpakai"
		Me.colTerpakai.Name = "colTerpakai"
		Me.colTerpakai.Visible = True
		Me.colTerpakai.VisibleIndex = 4
		'
		'colPerijinan
		'
		Me.colPerijinan.Caption = "No Perijinan"
		Me.colPerijinan.FieldName = "NoPerijinan"
		Me.colPerijinan.Name = "colPerijinan"
		Me.colPerijinan.Visible = True
		Me.colPerijinan.VisibleIndex = 0
		'
		'UI_FusohKuotaImpor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 395)
		Me.Name = "UI_FusohKuotaImpor"
		Me.Text = "Kuota Impor"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridInvoice, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents colKodeHS As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNoLampiran As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colVolume As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMataUang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNegara As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPelabuhan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colExpired As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTerpakai As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSisa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPerijinan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents xGridInvoice As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
End Class
