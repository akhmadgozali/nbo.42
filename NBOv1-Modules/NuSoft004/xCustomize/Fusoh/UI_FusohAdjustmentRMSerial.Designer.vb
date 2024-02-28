<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohAdjustmentRMSerial
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
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colMillSheet = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSN = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthSN = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMaterialLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtQty = New DevExpress.XtraEditors.SpinEdit()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn1
		'
		Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btn1.Appearance.Options.UseForeColor = True
		Me.btn1.Location = New System.Drawing.Point(165, 12)
		'
		'btn2
		'
		Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
		Me.btn2.Appearance.Options.UseForeColor = True
		Me.btn2.Location = New System.Drawing.Point(258, 12)
		'
		'PanelControl1
		'
		Me.PanelControl1.Location = New System.Drawing.Point(0, 425)
		Me.PanelControl1.Size = New System.Drawing.Size(391, 49)
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 38)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(367, 381)
		Me.xGrid.TabIndex = 19
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
		Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.xGridView.ColumnPanelRowHeight = 30
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMillSheet, Me.colSN, Me.colLengthSN, Me.colMaterialLength})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 23
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
		Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
		Me.xGridView.OptionsView.ShowAutoFilterRow = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colMillSheet
		'
		Me.colMillSheet.AppearanceHeader.Options.UseTextOptions = True
		Me.colMillSheet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colMillSheet.Caption = "Millsheet"
		Me.colMillSheet.FieldName = "MillSheet"
		Me.colMillSheet.Name = "colMillSheet"
		Me.colMillSheet.OptionsColumn.AllowEdit = False
		Me.colMillSheet.OptionsColumn.ReadOnly = True
		Me.colMillSheet.Visible = True
		Me.colMillSheet.VisibleIndex = 1
		Me.colMillSheet.Width = 93
		'
		'colSN
		'
		Me.colSN.AppearanceHeader.Options.UseTextOptions = True
		Me.colSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colSN.Caption = "SN"
		Me.colSN.FieldName = "Serial"
		Me.colSN.Name = "colSN"
		Me.colSN.OptionsColumn.AllowEdit = False
		Me.colSN.OptionsColumn.ReadOnly = True
		Me.colSN.Visible = True
		Me.colSN.VisibleIndex = 2
		Me.colSN.Width = 90
		'
		'colLengthSN
		'
		Me.colLengthSN.AppearanceCell.Options.UseTextOptions = True
		Me.colLengthSN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.colLengthSN.AppearanceHeader.Options.UseTextOptions = True
		Me.colLengthSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLengthSN.Caption = "Length SN"
		Me.colLengthSN.DisplayFormat.FormatString = "n0"
		Me.colLengthSN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLengthSN.FieldName = "LengthIn"
		Me.colLengthSN.Name = "colLengthSN"
		Me.colLengthSN.OptionsColumn.AllowEdit = False
		Me.colLengthSN.OptionsColumn.ReadOnly = True
		Me.colLengthSN.Visible = True
		Me.colLengthSN.VisibleIndex = 3
		Me.colLengthSN.Width = 68
		'
		'colMaterialLength
		'
		Me.colMaterialLength.AppearanceHeader.Options.UseTextOptions = True
		Me.colMaterialLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colMaterialLength.Caption = "Sisa Length"
		Me.colMaterialLength.FieldName = "SisaLength"
		Me.colMaterialLength.Name = "colMaterialLength"
		Me.colMaterialLength.OptionsColumn.AllowEdit = False
		Me.colMaterialLength.OptionsColumn.ReadOnly = True
		Me.colMaterialLength.Visible = True
		Me.colMaterialLength.VisibleIndex = 4
		'
		'txtQty
		'
		Me.txtQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtQty.Location = New System.Drawing.Point(53, 12)
		Me.txtQty.Name = "txtQty"
		Me.txtQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtQty.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtQty.Properties.Mask.EditMask = "n0"
		Me.txtQty.Properties.Mask.UseMaskAsDisplayFormat = True
		Me.txtQty.Size = New System.Drawing.Size(68, 20)
		Me.txtQty.TabIndex = 20
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(35, 13)
		Me.Label1.TabIndex = 21
		Me.Label1.Text = "Qty : "
		'
		'UI_FusohOrderProduksiSerial
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(391, 474)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtQty)
		Me.Controls.Add(Me.xGrid)
		Me.Name = "UI_FusohOrderProduksiSerial"
		Me.Text = "UI_FusohOrderProduksiSerial"
		Me.Controls.SetChildIndex(Me.PanelControl1, 0)
		Me.Controls.SetChildIndex(Me.xGrid, 0)
		Me.Controls.SetChildIndex(Me.txtQty, 0)
		Me.Controls.SetChildIndex(Me.Label1, 0)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSN As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLengthSN As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMaterialLength As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtQty As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents Label1 As Windows.Forms.Label
End Class
