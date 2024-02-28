<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_NishiStockINImpor
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
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_NishiStockINImpor))
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colPort = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIsi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSpekCaseID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSizeCaseno = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colInspectionPartno = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightNett = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightGross = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTruckIN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colRemark = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKubikasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.txtPemisah = New DevExpress.XtraEditors.TextEdit()
    Me.txtNamaFile = New DevExpress.XtraEditors.TextEdit()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPemisah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNamaFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(597, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(690, 11)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 361)
    Me.PanelControl1.Size = New System.Drawing.Size(795, 49)
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 32)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colHargaRepo, Me.colSpekRepo})
    Me.xGrid.Size = New System.Drawing.Size(769, 319)
    Me.xGrid.TabIndex = 121
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xGridView.ColumnPanelRowHeight = 30
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPort, Me.colIsi, Me.colSpekCaseID, Me.colSizeCaseno, Me.colInspectionPartno, Me.colPartName, Me.colWeightNett, Me.colWeightGross, Me.colTruckIN, Me.colQty, Me.colRemark, Me.colKubikasi, Me.GridColumn1, Me.GridColumn2})
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
    'colPort
    '
    Me.colPort.Caption = "PORT"
    Me.colPort.FieldName = "Port"
    Me.colPort.Name = "colPort"
    Me.colPort.Visible = True
    Me.colPort.VisibleIndex = 1
    Me.colPort.Width = 50
    '
    'colIsi
    '
    Me.colIsi.Caption = "Isi"
    Me.colIsi.FieldName = "Isi"
    Me.colIsi.Name = "colIsi"
    Me.colIsi.Visible = True
    Me.colIsi.VisibleIndex = 2
    Me.colIsi.Width = 50
    '
    'colSpekCaseID
    '
    Me.colSpekCaseID.Caption = "Spek"
    Me.colSpekCaseID.FieldName = "Spek_CaseID"
    Me.colSpekCaseID.Name = "colSpekCaseID"
    Me.colSpekCaseID.Visible = True
    Me.colSpekCaseID.VisibleIndex = 3
    Me.colSpekCaseID.Width = 50
    '
    'colSizeCaseno
    '
    Me.colSizeCaseno.Caption = "Size"
    Me.colSizeCaseno.FieldName = "Size_CaseNo"
    Me.colSizeCaseno.Name = "colSizeCaseno"
    Me.colSizeCaseno.Visible = True
    Me.colSizeCaseno.VisibleIndex = 4
    Me.colSizeCaseno.Width = 50
    '
    'colInspectionPartno
    '
    Me.colInspectionPartno.Caption = "Inspection"
    Me.colInspectionPartno.FieldName = "Inspection_PartNo"
    Me.colInspectionPartno.Name = "colInspectionPartno"
    Me.colInspectionPartno.Visible = True
    Me.colInspectionPartno.VisibleIndex = 5
    Me.colInspectionPartno.Width = 50
    '
    'colPartName
    '
    Me.colPartName.Caption = "Part Name"
    Me.colPartName.FieldName = "PartName"
    Me.colPartName.Name = "colPartName"
    Me.colPartName.Visible = True
    Me.colPartName.VisibleIndex = 6
    Me.colPartName.Width = 50
    '
    'colWeightNett
    '
    Me.colWeightNett.Caption = "Weight Nett"
    Me.colWeightNett.FieldName = "WeightNett"
    Me.colWeightNett.Name = "colWeightNett"
    Me.colWeightNett.Visible = True
    Me.colWeightNett.VisibleIndex = 7
    Me.colWeightNett.Width = 50
    '
    'colWeightGross
    '
    Me.colWeightGross.Caption = "Weight Gross"
    Me.colWeightGross.FieldName = "WeightGross"
    Me.colWeightGross.Name = "colWeightGross"
    Me.colWeightGross.Visible = True
    Me.colWeightGross.VisibleIndex = 8
    Me.colWeightGross.Width = 50
    '
    'colTruckIN
    '
    Me.colTruckIN.Caption = "Truck In"
    Me.colTruckIN.FieldName = "TruckIn"
    Me.colTruckIN.Name = "colTruckIN"
    Me.colTruckIN.Visible = True
    Me.colTruckIN.VisibleIndex = 9
    Me.colTruckIN.Width = 50
    '
    'colQty
    '
    Me.colQty.Caption = "Qty"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 10
    Me.colQty.Width = 50
    '
    'colRemark
    '
    Me.colRemark.Caption = "Remark"
    Me.colRemark.FieldName = "Remark"
    Me.colRemark.Name = "colRemark"
    Me.colRemark.Visible = True
    Me.colRemark.VisibleIndex = 11
    Me.colRemark.Width = 50
    '
    'colKubikasi
    '
    Me.colKubikasi.Caption = "Qty Kubikasi"
    Me.colKubikasi.FieldName = "QtyKubikasi"
    Me.colKubikasi.Name = "colKubikasi"
    Me.colKubikasi.Visible = True
    Me.colKubikasi.VisibleIndex = 12
    Me.colKubikasi.Width = 50
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "AsalNegara"
    Me.GridColumn1.FieldName = "AsalNegara"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 13
    Me.GridColumn1.Width = 70
    '
    'colHargaRepo
    '
    Me.colHargaRepo.AutoHeight = False
    Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colHargaRepo.Name = "colHargaRepo"
    '
    'colSpekRepo
    '
    Me.colSpekRepo.AutoHeight = False
    Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colSpekRepo.Name = "colSpekRepo"
    '
    'btnBrowse
    '
    Me.btnBrowse.AutoWidthInLayoutControl = True
    Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
    Me.btnBrowse.Location = New System.Drawing.Point(434, 4)
    Me.btnBrowse.Name = "btnBrowse"
    Me.btnBrowse.Size = New System.Drawing.Size(73, 22)
    Me.btnBrowse.TabIndex = 120
    Me.btnBrowse.Text = "Browse"
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(690, 9)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
    Me.LabelControl1.TabIndex = 118
    Me.LabelControl1.Text = "Pemisah"
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(12, 8)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
    Me.LabelControl3.TabIndex = 119
    Me.LabelControl3.Text = "Nama File"
    '
    'txtPemisah
    '
    Me.txtPemisah.EditValue = ";"
    Me.txtPemisah.Location = New System.Drawing.Point(735, 6)
    Me.txtPemisah.Name = "txtPemisah"
    Me.txtPemisah.Size = New System.Drawing.Size(46, 20)
    Me.txtPemisah.TabIndex = 116
    '
    'txtNamaFile
    '
    Me.txtNamaFile.Location = New System.Drawing.Point(83, 5)
    Me.txtNamaFile.Name = "txtNamaFile"
    Me.txtNamaFile.Properties.ReadOnly = True
    Me.txtNamaFile.Size = New System.Drawing.Size(345, 20)
    Me.txtNamaFile.TabIndex = 117
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "No Invoice"
    Me.GridColumn2.FieldName = "NoInvoice"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 0
    Me.GridColumn2.Width = 81
    '
    'UI_NishiStockINImpor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(795, 410)
    Me.Controls.Add(Me.xGrid)
    Me.Controls.Add(Me.btnBrowse)
    Me.Controls.Add(Me.LabelControl1)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.txtPemisah)
    Me.Controls.Add(Me.txtNamaFile)
    Me.Name = "UI_NishiStockINImpor"
    Me.Text = "UI_NishiStockINImpor"
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.txtNamaFile, 0)
    Me.Controls.SetChildIndex(Me.txtPemisah, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.btnBrowse, 0)
    Me.Controls.SetChildIndex(Me.xGrid, 0)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPemisah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNamaFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents colHargaRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtPemisah As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNamaFile As DevExpress.XtraEditors.TextEdit
  Friend WithEvents colIsi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSpekCaseID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSizeCaseno As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colInspectionPartno As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightNett As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightGross As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTruckIN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colRemark As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKubikasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPort As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
