<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohDailyProses
  Inherits Core.Win.Forms.GridInput

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohDailyProses))
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMesin = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colJamKerja = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colShift = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNoLot = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colFinishGoodSize = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangT = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBarangL = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colProcess = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPelanggan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyDempyou = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCutting = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOP1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOP2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyOP3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQtyFG = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colJamOff = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.xGrid.DataSource = Me.xpCol
		Me.xGrid.Size = New System.Drawing.Size(800, 423)
		'
		'xpCol
		'
		Me.xpCol.DisplayableProperties = resources.GetString("xpCol.DisplayableProperties")
		Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_DailyProcess)
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colTanggal, Me.colMesin, Me.colShift, Me.colJamKerja, Me.colNoLot, Me.colPartNo, Me.colFinishGoodSize, Me.colBarangNama, Me.colBarangOD, Me.colBarangT, Me.colBarangL, Me.colProcess, Me.colPelanggan, Me.colQtyDempyou, Me.colCutting, Me.colQtyOP1, Me.colQtyOP2, Me.colQtyOP3, Me.colQtyFG, Me.colJamOff, Me.colCatatan})
		Me.xGridView.GroupCount = 2
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.ColumnAutoWidth = False
		Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'barMenu
		'
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'colTanggal
		'
		Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colTanggal.FieldName = "Tanggal"
		Me.colTanggal.Name = "colTanggal"
		Me.colTanggal.Visible = True
		Me.colTanggal.VisibleIndex = 0
		Me.colTanggal.Width = 130
		'
		'colPartNo
		'
		Me.colPartNo.Caption = "Part Number (FG)"
		Me.colPartNo.FieldName = "Main.SODetail.Barang.Kode"
		Me.colPartNo.Name = "colPartNo"
		Me.colPartNo.Visible = True
		Me.colPartNo.VisibleIndex = 5
		Me.colPartNo.Width = 120
		'
		'colMesin
		'
		Me.colMesin.Caption = "Mesin"
		Me.colMesin.FieldName = "Mesin.Nama"
		Me.colMesin.Name = "colMesin"
		Me.colMesin.Visible = True
		Me.colMesin.VisibleIndex = 1
		Me.colMesin.Width = 120
		'
		'colJamKerja
		'
		Me.colJamKerja.Caption = "Jam Kerja"
		Me.colJamKerja.FieldName = "JamKerja"
		Me.colJamKerja.Name = "colJamKerja"
		Me.colJamKerja.Visible = True
		Me.colJamKerja.VisibleIndex = 3
		Me.colJamKerja.Width = 60
		'
		'colShift
		'
		Me.colShift.Caption = "Shift"
		Me.colShift.FieldName = "Shift"
		Me.colShift.Name = "colShift"
		Me.colShift.Visible = True
		Me.colShift.VisibleIndex = 2
		Me.colShift.Width = 40
		'
		'colTahun
		'
		Me.colTahun.Caption = "Tahun"
		Me.colTahun.FieldName = "Tahun"
		Me.colTahun.Name = "colTahun"
		Me.colTahun.Visible = True
		Me.colTahun.VisibleIndex = 15
		'
		'colBulan
		'
		Me.colBulan.Caption = "Bulan"
		Me.colBulan.DisplayFormat.FormatString = "MMMM"
		Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.FieldName = "Bulan"
		Me.colBulan.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
		Me.colBulan.GroupFormat.FormatString = "MMMM"
		Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colBulan.Name = "colBulan"
		Me.colBulan.Visible = True
		Me.colBulan.VisibleIndex = 15
		'
		'colNoLot
		'
		Me.colNoLot.Caption = "No. Lot"
		Me.colNoLot.FieldName = "Main.NomorLot"
		Me.colNoLot.Name = "colNoLot"
		Me.colNoLot.Visible = True
		Me.colNoLot.VisibleIndex = 4
		Me.colNoLot.Width = 60
		'
		'colFinishGoodSize
		'
		Me.colFinishGoodSize.Caption = "Finish Good Size"
		Me.colFinishGoodSize.FieldName = "colFinishGoodSize"
		Me.colFinishGoodSize.Name = "colFinishGoodSize"
		Me.colFinishGoodSize.UnboundExpression = "Concat([Main.SODetail.Barang.Nama], ' ',Round([Main.SODetail.Barang.OutDiameter]," &
	"0), ' x ', Round([Main.SODetail.Barang.Thickness],1), ' x ', Round([Main.SODetai" &
	"l.Barang.Length],1))"
		Me.colFinishGoodSize.UnboundType = DevExpress.Data.UnboundColumnType.[String]
		Me.colFinishGoodSize.Visible = True
		Me.colFinishGoodSize.VisibleIndex = 6
		Me.colFinishGoodSize.Width = 150
		'
		'colBarangNama
		'
		Me.colBarangNama.FieldName = "Main.SODetail.Barang.Nama"
		Me.colBarangNama.Name = "colBarangNama"
		'
		'colBarangOD
		'
		Me.colBarangOD.FieldName = "Main.SODetail.Barang.OutDiameter"
		Me.colBarangOD.Name = "colBarangOD"
		'
		'colBarangT
		'
		Me.colBarangT.FieldName = "Main.SODetail.Barang.Thickness"
		Me.colBarangT.Name = "colBarangT"
		'
		'colBarangL
		'
		Me.colBarangL.FieldName = "Main.SODetail.Barang.Length"
		Me.colBarangL.Name = "colBarangL"
		'
		'colProcess
		'
		Me.colProcess.Caption = "Process"
		Me.colProcess.FieldName = "Main.MaterialFlow"
		Me.colProcess.Name = "colProcess"
		Me.colProcess.Visible = True
		Me.colProcess.VisibleIndex = 7
		Me.colProcess.Width = 100
		'
		'colPelanggan
		'
		Me.colPelanggan.Caption = "Customer"
		Me.colPelanggan.FieldName = "Main.Pelanggan.Nama"
		Me.colPelanggan.Name = "colPelanggan"
		Me.colPelanggan.Visible = True
		Me.colPelanggan.VisibleIndex = 8
		Me.colPelanggan.Width = 200
		'
		'colQtyDempyou
		'
		Me.colQtyDempyou.Caption = "Qty Dempyou"
		Me.colQtyDempyou.DisplayFormat.FormatString = "n0"
		Me.colQtyDempyou.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyDempyou.FieldName = "Main.Qty"
		Me.colQtyDempyou.Name = "colQtyDempyou"
		Me.colQtyDempyou.Visible = True
		Me.colQtyDempyou.VisibleIndex = 9
		Me.colQtyDempyou.Width = 80
		'
		'colCutting
		'
		Me.colCutting.Caption = "Cutting"
		Me.colCutting.DisplayFormat.FormatString = "n2"
		Me.colCutting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colCutting.FieldName = "Main.Cutting"
		Me.colCutting.Name = "colCutting"
		Me.colCutting.Visible = True
		Me.colCutting.VisibleIndex = 10
		Me.colCutting.Width = 70
		'
		'colQtyOP1
		'
		Me.colQtyOP1.Caption = "Qty OP 1"
		Me.colQtyOP1.DisplayFormat.FormatString = "n0"
		Me.colQtyOP1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyOP1.FieldName = "QtyOP1"
		Me.colQtyOP1.Name = "colQtyOP1"
		Me.colQtyOP1.Visible = True
		Me.colQtyOP1.VisibleIndex = 11
		Me.colQtyOP1.Width = 60
		'
		'colQtyOP2
		'
		Me.colQtyOP2.Caption = "Qty OP 2"
		Me.colQtyOP2.DisplayFormat.FormatString = "n0"
		Me.colQtyOP2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyOP2.FieldName = "QtyOP2"
		Me.colQtyOP2.Name = "colQtyOP2"
		Me.colQtyOP2.Visible = True
		Me.colQtyOP2.VisibleIndex = 12
		Me.colQtyOP2.Width = 60
		'
		'colQtyOP3
		'
		Me.colQtyOP3.Caption = "Qty OP 3"
		Me.colQtyOP3.DisplayFormat.FormatString = "n0"
		Me.colQtyOP3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyOP3.FieldName = "QtyOP3"
		Me.colQtyOP3.Name = "colQtyOP3"
		Me.colQtyOP3.Visible = True
		Me.colQtyOP3.VisibleIndex = 13
		Me.colQtyOP3.Width = 60
		'
		'colQtyFG
		'
		Me.colQtyFG.Caption = "Qty FG"
		Me.colQtyFG.DisplayFormat.FormatString = "n0"
		Me.colQtyFG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQtyFG.FieldName = "QtyFG"
		Me.colQtyFG.Name = "colQtyFG"
		Me.colQtyFG.Visible = True
		Me.colQtyFG.VisibleIndex = 14
		Me.colQtyFG.Width = 60
		'
		'colJamOff
		'
		Me.colJamOff.Caption = "Stopline"
		Me.colJamOff.FieldName = "JamOff"
		Me.colJamOff.Name = "colJamOff"
		Me.colJamOff.Visible = True
		Me.colJamOff.VisibleIndex = 15
		Me.colJamOff.Width = 60
		'
		'colCatatan
		'
		Me.colCatatan.Caption = "Remarks"
		Me.colCatatan.FieldName = "Catatan"
		Me.colCatatan.Name = "colCatatan"
		Me.colCatatan.Visible = True
		Me.colCatatan.VisibleIndex = 16
		Me.colCatatan.Width = 200
		'
		'UI_FusohDailyProses
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Name = "UI_FusohDailyProses"
		Me.Text = "Daily Proses"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPartNo As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMesin As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colJamKerja As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colShift As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNoLot As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFinishGoodSize As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangOD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangT As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colBarangL As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colProcess As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPelanggan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyDempyou As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCutting As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOP1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOP2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyOP3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQtyFG As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colJamOff As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
End Class
