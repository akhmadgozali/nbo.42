<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_NishiStockOutDialogFindSI
  Inherits Core.Win.Forms.DialogForm

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
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colBLNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIsi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSpekCaseID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSizeCaseno = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colInspectionPartno = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightNett = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightGross = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTruckIN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyGR = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colRemark = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKubikasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSisaQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSisaKubikasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colX = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.colQtySJ = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQtyKubikasiSJ = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTruckOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colGudangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colDivisiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colGudangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(1021, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(1114, 11)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 454)
    Me.PanelControl1.Size = New System.Drawing.Size(1213, 49)
    '
    'xGrid
    '
    Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGrid.Location = New System.Drawing.Point(0, 0)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colGudangRepo, Me.colSatuanRepo, Me.colDivisiRepo, Me.colKodeBarangRepo, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
    Me.xGrid.Size = New System.Drawing.Size(1213, 454)
    Me.xGrid.TabIndex = 17
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xGridView.ColumnPanelRowHeight = 30
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBLNo, Me.colNoInvoice, Me.colIsi, Me.colSpekCaseID, Me.colSizeCaseno, Me.colInspectionPartno, Me.colPartName, Me.colWeightNett, Me.colWeightGross, Me.colTruckIN, Me.colQtyGR, Me.colRemark, Me.colKubikasi, Me.colSisaQty, Me.colSisaKubikasi, Me.colX, Me.colQtySJ, Me.colQtyKubikasiSJ, Me.colTruckOut, Me.colCatatan})
    Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(654, 412, 210, 172)
    StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    StyleFormatCondition1.Appearance.Options.UseBackColor = True
    StyleFormatCondition1.ApplyToRow = True
    StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
    StyleFormatCondition1.Expression = "IsNullOrEmpty([Barang.Nama])"
    Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colBLNo
    '
    Me.colBLNo.Caption = "No BL"
    Me.colBLNo.FieldName = "idGR.Main.JobOrder.d_blno"
    Me.colBLNo.Name = "colBLNo"
    Me.colBLNo.OptionsColumn.AllowEdit = False
    Me.colBLNo.OptionsColumn.ReadOnly = True
    Me.colBLNo.Visible = True
    Me.colBLNo.VisibleIndex = 0
    Me.colBLNo.Width = 53
    '
    'colNoInvoice
    '
    Me.colNoInvoice.Caption = "No Invoice"
    Me.colNoInvoice.FieldName = "idGR.NoInvoice"
    Me.colNoInvoice.Name = "colNoInvoice"
    Me.colNoInvoice.OptionsColumn.AllowEdit = False
    Me.colNoInvoice.OptionsColumn.ReadOnly = True
    Me.colNoInvoice.Visible = True
    Me.colNoInvoice.VisibleIndex = 1
    Me.colNoInvoice.Width = 53
    '
    'colIsi
    '
    Me.colIsi.Caption = "Isi"
    Me.colIsi.FieldName = "idGR.Isi"
    Me.colIsi.Name = "colIsi"
    Me.colIsi.OptionsColumn.AllowEdit = False
    Me.colIsi.OptionsColumn.ReadOnly = True
    Me.colIsi.Visible = True
    Me.colIsi.VisibleIndex = 2
    Me.colIsi.Width = 53
    '
    'colSpekCaseID
    '
    Me.colSpekCaseID.Caption = "Spek"
    Me.colSpekCaseID.FieldName = "idGR.Spek_CaseID"
    Me.colSpekCaseID.Name = "colSpekCaseID"
    Me.colSpekCaseID.OptionsColumn.AllowEdit = False
    Me.colSpekCaseID.OptionsColumn.ReadOnly = True
    Me.colSpekCaseID.Visible = True
    Me.colSpekCaseID.VisibleIndex = 3
    Me.colSpekCaseID.Width = 53
    '
    'colSizeCaseno
    '
    Me.colSizeCaseno.Caption = "Size"
    Me.colSizeCaseno.FieldName = "idGR.Size_CaseNo"
    Me.colSizeCaseno.Name = "colSizeCaseno"
    Me.colSizeCaseno.OptionsColumn.AllowEdit = False
    Me.colSizeCaseno.OptionsColumn.ReadOnly = True
    Me.colSizeCaseno.Visible = True
    Me.colSizeCaseno.VisibleIndex = 4
    Me.colSizeCaseno.Width = 53
    '
    'colInspectionPartno
    '
    Me.colInspectionPartno.Caption = "Inspection"
    Me.colInspectionPartno.FieldName = "idGR.Inspection_PartNo"
    Me.colInspectionPartno.Name = "colInspectionPartno"
    Me.colInspectionPartno.OptionsColumn.AllowEdit = False
    Me.colInspectionPartno.OptionsColumn.ReadOnly = True
    Me.colInspectionPartno.Visible = True
    Me.colInspectionPartno.VisibleIndex = 5
    Me.colInspectionPartno.Width = 53
    '
    'colPartName
    '
    Me.colPartName.Caption = "Part Name"
    Me.colPartName.FieldName = "idGR.PartName"
    Me.colPartName.Name = "colPartName"
    Me.colPartName.Visible = True
    Me.colPartName.VisibleIndex = 6
    Me.colPartName.Width = 53
    '
    'colWeightNett
    '
    Me.colWeightNett.Caption = "Weight Nett"
    Me.colWeightNett.FieldName = "idGR.WeightNett"
    Me.colWeightNett.Name = "colWeightNett"
    Me.colWeightNett.OptionsColumn.AllowEdit = False
    Me.colWeightNett.OptionsColumn.ReadOnly = True
    Me.colWeightNett.Visible = True
    Me.colWeightNett.VisibleIndex = 7
    Me.colWeightNett.Width = 53
    '
    'colWeightGross
    '
    Me.colWeightGross.Caption = "Weight Gross"
    Me.colWeightGross.FieldName = "idGR.WeightGross"
    Me.colWeightGross.Name = "colWeightGross"
    Me.colWeightGross.OptionsColumn.AllowEdit = False
    Me.colWeightGross.OptionsColumn.ReadOnly = True
    Me.colWeightGross.Visible = True
    Me.colWeightGross.VisibleIndex = 8
    Me.colWeightGross.Width = 53
    '
    'colTruckIN
    '
    Me.colTruckIN.Caption = "Truck In"
    Me.colTruckIN.FieldName = "idGR.TruckIn"
    Me.colTruckIN.Name = "colTruckIN"
    Me.colTruckIN.OptionsColumn.AllowEdit = False
    Me.colTruckIN.OptionsColumn.ReadOnly = True
    Me.colTruckIN.Visible = True
    Me.colTruckIN.VisibleIndex = 9
    Me.colTruckIN.Width = 53
    '
    'colQtyGR
    '
    Me.colQtyGR.Caption = "Qty"
    Me.colQtyGR.FieldName = "idGR.QtyIn"
    Me.colQtyGR.Name = "colQtyGR"
    Me.colQtyGR.OptionsColumn.AllowEdit = False
    Me.colQtyGR.OptionsColumn.ReadOnly = True
    Me.colQtyGR.Visible = True
    Me.colQtyGR.VisibleIndex = 10
    Me.colQtyGR.Width = 53
    '
    'colRemark
    '
    Me.colRemark.Caption = "Remark"
    Me.colRemark.FieldName = "idGR.Remark"
    Me.colRemark.Name = "colRemark"
    Me.colRemark.OptionsColumn.AllowEdit = False
    Me.colRemark.OptionsColumn.ReadOnly = True
    Me.colRemark.Visible = True
    Me.colRemark.VisibleIndex = 11
    Me.colRemark.Width = 53
    '
    'colKubikasi
    '
    Me.colKubikasi.Caption = "Qty Kubikasi"
    Me.colKubikasi.FieldName = "idGR.QtyKubikasi"
    Me.colKubikasi.Name = "colKubikasi"
    Me.colKubikasi.OptionsColumn.AllowEdit = False
    Me.colKubikasi.OptionsColumn.ReadOnly = True
    Me.colKubikasi.Visible = True
    Me.colKubikasi.VisibleIndex = 12
    Me.colKubikasi.Width = 53
    '
    'colSisaQty
    '
    Me.colSisaQty.Caption = "Sisa Qty"
    Me.colSisaQty.FieldName = "idGR.QtySisa"
    Me.colSisaQty.Name = "colSisaQty"
    Me.colSisaQty.OptionsColumn.AllowEdit = False
    Me.colSisaQty.OptionsColumn.ReadOnly = True
    Me.colSisaQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colSisaQty.Visible = True
    Me.colSisaQty.VisibleIndex = 13
    Me.colSisaQty.Width = 53
    '
    'colSisaKubikasi
    '
    Me.colSisaKubikasi.Caption = "Sisa Kubikasi"
    Me.colSisaKubikasi.FieldName = "idGR.QtySisaKubikasi"
    Me.colSisaKubikasi.Name = "colSisaKubikasi"
    Me.colSisaKubikasi.OptionsColumn.AllowEdit = False
    Me.colSisaKubikasi.OptionsColumn.ReadOnly = True
    Me.colSisaKubikasi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colSisaKubikasi.Visible = True
    Me.colSisaKubikasi.VisibleIndex = 14
    Me.colSisaKubikasi.Width = 53
    '
    'colX
    '
    Me.colX.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.colX.AppearanceCell.Options.UseBackColor = True
    Me.colX.Caption = "x"
    Me.colX.ColumnEdit = Me.RepositoryItemCheckEdit2
    Me.colX.FieldName = "xSave"
    Me.colX.Name = "colX"
    Me.colX.Visible = True
    Me.colX.VisibleIndex = 15
    Me.colX.Width = 53
    '
    'RepositoryItemCheckEdit2
    '
    Me.RepositoryItemCheckEdit2.AutoHeight = False
    Me.RepositoryItemCheckEdit2.Caption = "Check"
    Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
    '
    'colQtySJ
    '
    Me.colQtySJ.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.colQtySJ.AppearanceCell.Options.UseBackColor = True
    Me.colQtySJ.Caption = "Qty SJ"
    Me.colQtySJ.FieldName = "Qty"
    Me.colQtySJ.Name = "colQtySJ"
    Me.colQtySJ.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQtySJ.Visible = True
    Me.colQtySJ.VisibleIndex = 16
    Me.colQtySJ.Width = 53
    '
    'colQtyKubikasiSJ
    '
    Me.colQtyKubikasiSJ.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.colQtyKubikasiSJ.AppearanceCell.Options.UseBackColor = True
    Me.colQtyKubikasiSJ.Caption = "Qty Kubikasi"
    Me.colQtyKubikasiSJ.FieldName = "QtyKubikasi"
    Me.colQtyKubikasiSJ.Name = "colQtyKubikasiSJ"
    Me.colQtyKubikasiSJ.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQtyKubikasiSJ.Width = 73
    '
    'colTruckOut
    '
    Me.colTruckOut.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.colTruckOut.AppearanceCell.Options.UseBackColor = True
    Me.colTruckOut.Caption = "Truck Out"
    Me.colTruckOut.FieldName = "TruckOut"
    Me.colTruckOut.Name = "colTruckOut"
    Me.colTruckOut.Visible = True
    Me.colTruckOut.VisibleIndex = 17
    Me.colTruckOut.Width = 70
    '
    'colCatatan
    '
    Me.colCatatan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.colCatatan.AppearanceCell.Options.UseBackColor = True
    Me.colCatatan.Caption = "Remark"
    Me.colCatatan.FieldName = "Remark"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 18
    Me.colCatatan.Width = 34
    '
    'colGudangRepo
    '
    Me.colGudangRepo.AutoHeight = False
    Me.colGudangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colGudangRepo.Name = "colGudangRepo"
    Me.colGudangRepo.NullText = "<Pilih Gudang>"
    '
    'colSatuanRepo
    '
    Me.colSatuanRepo.AutoHeight = False
    Me.colSatuanRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colSatuanRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.colSatuanRepo.DisplayMember = "Kode"
    Me.colSatuanRepo.Name = "colSatuanRepo"
    Me.colSatuanRepo.NullText = "<Pilih Satuan>"
    Me.colSatuanRepo.ValueMember = "This"
    '
    'colDivisiRepo
    '
    Me.colDivisiRepo.AutoHeight = False
    Me.colDivisiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colDivisiRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colDivisiRepo.DisplayMember = "Kode"
    Me.colDivisiRepo.Name = "colDivisiRepo"
    Me.colDivisiRepo.NullText = "<Pilih Divisi>"
    Me.colDivisiRepo.ValueMember = "This"
    '
    'colKodeBarangRepo
    '
    Me.colKodeBarangRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKodeBarangRepo.DisplayMember = "Kode"
    Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
    Me.colKodeBarangRepo.NullText = "<Pilih Barang>"
    Me.colKodeBarangRepo.ShowClearButton = False
    Me.colKodeBarangRepo.ShowFooter = False
    Me.colKodeBarangRepo.ValueMember = "This"
    Me.colKodeBarangRepo.View = Me.RepositoryItemSearchLookUpEdit1View
    '
    'RepositoryItemSearchLookUpEdit1View
    '
    Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama, Me.gcSatuan})
    Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
    Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    '
    'gcKode
    '
    Me.gcKode.Caption = "Kode"
    Me.gcKode.FieldName = "Kode"
    Me.gcKode.Name = "gcKode"
    Me.gcKode.Visible = True
    Me.gcKode.VisibleIndex = 0
    Me.gcKode.Width = 293
    '
    'gcNama
    '
    Me.gcNama.Caption = "Nama"
    Me.gcNama.FieldName = "Nama"
    Me.gcNama.Name = "gcNama"
    Me.gcNama.Visible = True
    Me.gcNama.VisibleIndex = 1
    Me.gcNama.Width = 519
    '
    'gcSatuan
    '
    Me.gcSatuan.Caption = "Satuan"
    Me.gcSatuan.FieldName = "Satuan.Nama"
    Me.gcSatuan.Name = "gcSatuan"
    Me.gcSatuan.Visible = True
    Me.gcSatuan.VisibleIndex = 2
    Me.gcSatuan.Width = 266
    '
    'RepositoryItemCheckEdit1
    '
    Me.RepositoryItemCheckEdit1.AutoHeight = False
    Me.RepositoryItemCheckEdit1.Caption = "Check"
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    '
    'UI_NishiStockOutDialogFindSI
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1213, 503)
    Me.Controls.Add(Me.xGrid)
    Me.Name = "UI_NishiStockOutDialogFindSI"
    Me.Text = "Find Stock IN"
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.xGrid, 0)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colGudangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colBLNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoInvoice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIsi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSpekCaseID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSizeCaseno As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colInspectionPartno As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightNett As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightGross As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTruckIN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyGR As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colRemark As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKubikasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSisaQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSisaKubikasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents colGudangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colSatuanRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colDivisiRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents colX As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtySJ As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQtyKubikasiSJ As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTruckOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
End Class
