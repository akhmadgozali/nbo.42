<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_Fusoh_SODialogImpor
	Inherits Core.Win.Forms.DialogForm

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Fusoh_SODialogImpor))
		Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.txtNamaFile = New DevExpress.XtraEditors.TextEdit()
		Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colPOLine = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.colInD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
		Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNoPODetail = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.txtPemisah = New DevExpress.XtraEditors.TextEdit()
		Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		CType(Me.txtNamaFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPemisah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn1
		'
		Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btn1.Appearance.Options.UseForeColor = True
		Me.btn1.Location = New System.Drawing.Point(936, 12)
		Me.btn1.Text = "&Impor"
		'
		'btn2
		'
		Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
		Me.btn2.Appearance.Options.UseForeColor = True
		Me.btn2.Location = New System.Drawing.Point(1029, 12)
		'
		'PanelControl1
		'
		Me.PanelControl1.Location = New System.Drawing.Point(0, 358)
		Me.PanelControl1.Size = New System.Drawing.Size(1128, 49)
		'
		'colNamaBarang
		'
		Me.colNamaBarang.AppearanceCell.Options.UseTextOptions = True
		Me.colNamaBarang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colNamaBarang.AppearanceHeader.Options.UseTextOptions = True
		Me.colNamaBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colNamaBarang.Caption = "Material"
		Me.colNamaBarang.FieldName = "NamaBarang"
		Me.colNamaBarang.Name = "colNamaBarang"
		Me.colNamaBarang.Visible = True
		Me.colNamaBarang.VisibleIndex = 3
		Me.colNamaBarang.Width = 151
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(12, 15)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl3.TabIndex = 113
		Me.LabelControl3.Text = "Nama File"
		'
		'txtNamaFile
		'
		Me.txtNamaFile.Location = New System.Drawing.Point(83, 12)
		Me.txtNamaFile.Name = "txtNamaFile"
		Me.txtNamaFile.Properties.ReadOnly = True
		Me.txtNamaFile.Size = New System.Drawing.Size(619, 20)
		Me.txtNamaFile.TabIndex = 112
		'
		'btnBrowse
		'
		Me.btnBrowse.AutoWidthInLayoutControl = True
		Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
		Me.btnBrowse.Location = New System.Drawing.Point(708, 11)
		Me.btnBrowse.Name = "btnBrowse"
		Me.btnBrowse.Size = New System.Drawing.Size(73, 22)
		Me.btnBrowse.TabIndex = 114
		Me.btnBrowse.Text = "Browse"
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 39)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colHargaRepo, Me.colSpekRepo})
		Me.xGrid.Size = New System.Drawing.Size(1104, 319)
		Me.xGrid.TabIndex = 115
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
		Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.xGridView.ColumnPanelRowHeight = 30
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPOLine, Me.colKodeBarang, Me.colNamaBarang, Me.colOD, Me.colInD, Me.colThickness, Me.colLength, Me.colQty, Me.colWeight, Me.colHarga, Me.colSubTotal, Me.colCatatan, Me.colNoPODetail, Me.colDeliveryDate})
		StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		StyleFormatCondition1.Appearance.Options.UseBackColor = True
		StyleFormatCondition1.ApplyToRow = True
		StyleFormatCondition1.Column = Me.colNamaBarang
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
		'colPOLine
		'
		Me.colPOLine.Caption = "PO Line"
		Me.colPOLine.FieldName = "POLine"
		Me.colPOLine.Name = "colPOLine"
		Me.colPOLine.OptionsColumn.AllowEdit = False
		Me.colPOLine.OptionsColumn.ReadOnly = True
		Me.colPOLine.Visible = True
		Me.colPOLine.VisibleIndex = 1
		Me.colPOLine.Width = 74
		'
		'colKodeBarang
		'
		Me.colKodeBarang.AppearanceHeader.Options.UseTextOptions = True
		Me.colKodeBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colKodeBarang.Caption = "Part No."
		Me.colKodeBarang.FieldName = "KodeBarang"
		Me.colKodeBarang.Name = "colKodeBarang"
		Me.colKodeBarang.Visible = True
		Me.colKodeBarang.VisibleIndex = 2
		Me.colKodeBarang.Width = 134
		'
		'colOD
		'
		Me.colOD.AppearanceCell.Options.UseTextOptions = True
		Me.colOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colOD.AppearanceHeader.Options.UseTextOptions = True
		Me.colOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colOD.Caption = "OD"
		Me.colOD.ColumnEdit = Me.colSpekRepo
		Me.colOD.DisplayFormat.FormatString = "n1"
		Me.colOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colOD.FieldName = "OutDiameter"
		Me.colOD.Name = "colOD"
		Me.colOD.Visible = True
		Me.colOD.VisibleIndex = 4
		Me.colOD.Width = 44
		'
		'colSpekRepo
		'
		Me.colSpekRepo.AutoHeight = False
		Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colSpekRepo.Name = "colSpekRepo"
		'
		'colInD
		'
		Me.colInD.AppearanceCell.Options.UseTextOptions = True
		Me.colInD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colInD.AppearanceHeader.Options.UseTextOptions = True
		Me.colInD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colInD.Caption = "ID"
		Me.colInD.ColumnEdit = Me.colSpekRepo
		Me.colInD.DisplayFormat.FormatString = "n1"
		Me.colInD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colInD.FieldName = "InDiameter"
		Me.colInD.Name = "colInD"
		Me.colInD.Visible = True
		Me.colInD.VisibleIndex = 5
		Me.colInD.Width = 44
		'
		'colThickness
		'
		Me.colThickness.AppearanceCell.Options.UseTextOptions = True
		Me.colThickness.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colThickness.AppearanceHeader.Options.UseTextOptions = True
		Me.colThickness.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colThickness.Caption = "T"
		Me.colThickness.ColumnEdit = Me.colSpekRepo
		Me.colThickness.DisplayFormat.FormatString = "n1"
		Me.colThickness.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colThickness.FieldName = "Thickness"
		Me.colThickness.Name = "colThickness"
		Me.colThickness.Visible = True
		Me.colThickness.VisibleIndex = 6
		Me.colThickness.Width = 44
		'
		'colLength
		'
		Me.colLength.AppearanceCell.Options.UseTextOptions = True
		Me.colLength.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLength.AppearanceHeader.Options.UseTextOptions = True
		Me.colLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLength.Caption = "L"
		Me.colLength.ColumnEdit = Me.colSpekRepo
		Me.colLength.DisplayFormat.FormatString = "n1"
		Me.colLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLength.FieldName = "Length"
		Me.colLength.Name = "colLength"
		Me.colLength.Visible = True
		Me.colLength.VisibleIndex = 7
		Me.colLength.Width = 44
		'
		'colQty
		'
		Me.colQty.AppearanceCell.Options.UseTextOptions = True
		Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colQty.AppearanceHeader.Options.UseTextOptions = True
		Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colQty.Caption = "Qty"
		Me.colQty.ColumnEdit = Me.colSpekRepo
		Me.colQty.DisplayFormat.FormatString = "n2"
		Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colQty.FieldName = "Qty"
		Me.colQty.Name = "colQty"
		Me.colQty.OptionsColumn.AllowSize = False
		Me.colQty.OptionsColumn.FixedWidth = True
		Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colQty.Visible = True
		Me.colQty.VisibleIndex = 8
		Me.colQty.Width = 50
		'
		'colWeight
		'
		Me.colWeight.AppearanceCell.Options.UseTextOptions = True
		Me.colWeight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colWeight.AppearanceHeader.Options.UseTextOptions = True
		Me.colWeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colWeight.Caption = "Weight"
		Me.colWeight.DisplayFormat.FormatString = "n1"
		Me.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colWeight.FieldName = "Weight"
		Me.colWeight.Name = "colWeight"
		Me.colWeight.OptionsColumn.AllowEdit = False
		Me.colWeight.OptionsColumn.ReadOnly = True
		Me.colWeight.Visible = True
		Me.colWeight.VisibleIndex = 9
		Me.colWeight.Width = 57
		'
		'colHarga
		'
		Me.colHarga.AppearanceCell.Options.UseTextOptions = True
		Me.colHarga.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colHarga.AppearanceHeader.Options.UseTextOptions = True
		Me.colHarga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colHarga.Caption = "Price"
		Me.colHarga.ColumnEdit = Me.colHargaRepo
		Me.colHarga.DisplayFormat.FormatString = "n2"
		Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colHarga.FieldName = "Harga"
		Me.colHarga.Name = "colHarga"
		Me.colHarga.Visible = True
		Me.colHarga.VisibleIndex = 10
		Me.colHarga.Width = 78
		'
		'colHargaRepo
		'
		Me.colHargaRepo.AutoHeight = False
		Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colHargaRepo.Name = "colHargaRepo"
		'
		'colSubTotal
		'
		Me.colSubTotal.AppearanceHeader.Options.UseTextOptions = True
		Me.colSubTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colSubTotal.Caption = "Sub Total"
		Me.colSubTotal.DisplayFormat.FormatString = "n2"
		Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSubTotal.FieldName = "SubTotal"
		Me.colSubTotal.Name = "colSubTotal"
		Me.colSubTotal.OptionsColumn.AllowEdit = False
		Me.colSubTotal.OptionsColumn.ReadOnly = True
		Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colSubTotal.Visible = True
		Me.colSubTotal.VisibleIndex = 11
		Me.colSubTotal.Width = 101
		'
		'colCatatan
		'
		Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
		Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
		Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colCatatan.Caption = "Remarks"
		Me.colCatatan.FieldName = "Catatan"
		Me.colCatatan.Name = "colCatatan"
		Me.colCatatan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colCatatan.Visible = True
		Me.colCatatan.VisibleIndex = 12
		Me.colCatatan.Width = 188
		'
		'colNoPODetail
		'
		Me.colNoPODetail.Caption = "No. PO"
		Me.colNoPODetail.FieldName = "NoPODetail"
		Me.colNoPODetail.Name = "colNoPODetail"
		Me.colNoPODetail.Visible = True
		Me.colNoPODetail.VisibleIndex = 0
		Me.colNoPODetail.Width = 100
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(891, 15)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
		Me.LabelControl1.TabIndex = 113
		Me.LabelControl1.Text = "Pemisah"
		'
		'txtPemisah
		'
		Me.txtPemisah.EditValue = ","
		Me.txtPemisah.Location = New System.Drawing.Point(936, 12)
		Me.txtPemisah.Name = "txtPemisah"
		Me.txtPemisah.Properties.ReadOnly = True
		Me.txtPemisah.Size = New System.Drawing.Size(46, 20)
		Me.txtPemisah.TabIndex = 112
		'
		'colDeliveryDate
		'
		Me.colDeliveryDate.Caption = "Delivery Date"
		Me.colDeliveryDate.DisplayFormat.FormatString = "dd MMM yyyy"
		Me.colDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
		Me.colDeliveryDate.FieldName = "DeliveryDate"
		Me.colDeliveryDate.Name = "colDeliveryDate"
		Me.colDeliveryDate.Visible = True
		Me.colDeliveryDate.VisibleIndex = 13
		'
		'UI_Fusoh_SODialogImpor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1128, 407)
		Me.Controls.Add(Me.xGrid)
		Me.Controls.Add(Me.btnBrowse)
		Me.Controls.Add(Me.LabelControl1)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.txtPemisah)
		Me.Controls.Add(Me.txtNamaFile)
		Me.Name = "UI_Fusoh_SODialogImpor"
		Me.Text = "Impor SO dari CSV"
		Me.Controls.SetChildIndex(Me.PanelControl1, 0)
		Me.Controls.SetChildIndex(Me.txtNamaFile, 0)
		Me.Controls.SetChildIndex(Me.txtPemisah, 0)
		Me.Controls.SetChildIndex(Me.LabelControl3, 0)
		Me.Controls.SetChildIndex(Me.LabelControl1, 0)
		Me.Controls.SetChildIndex(Me.btnBrowse, 0)
		Me.Controls.SetChildIndex(Me.xGrid, 0)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		CType(Me.txtNamaFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPemisah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtNamaFile As DevExpress.XtraEditors.TextEdit
	Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colPOLine As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colOD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
	Friend WithEvents colInD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colThickness As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colHargaRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
	Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtPemisah As DevExpress.XtraEditors.TextEdit
	Friend WithEvents colNoPODetail As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
