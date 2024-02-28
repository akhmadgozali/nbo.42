<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohPenerimaanBarangDialogSerial
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
		Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.lytMasterTermin = New DevExpress.XtraLayout.LayoutControl()
		Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytMasterTermin.SuspendLayout()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn1
		'
		Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btn1.Appearance.Options.UseForeColor = True
		Me.btn1.Location = New System.Drawing.Point(332, 11)
		Me.btn1.Text = "&Pilih"
		'
		'btn2
		'
		Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
		Me.btn2.Appearance.Options.UseForeColor = True
		Me.btn2.Location = New System.Drawing.Point(425, 12)
		'
		'PanelControl1
		'
		Me.PanelControl1.Location = New System.Drawing.Point(0, 370)
		Me.PanelControl1.Size = New System.Drawing.Size(524, 49)
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 12)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.ShowOnlyPredefinedDetails = True
		Me.xGrid.Size = New System.Drawing.Size(500, 346)
		Me.xGrid.TabIndex = 0
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMillSheet, Me.colSerial, Me.colId})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsBehavior.ReadOnly = True
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
		Me.xGridView.OptionsDetail.ShowDetailTabs = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
		Me.xGridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colMillSheet
		'
		Me.colMillSheet.Caption = "Nama Millsheet"
		Me.colMillSheet.FieldName = "MillSheet"
		Me.colMillSheet.Name = "colMillSheet"
		Me.colMillSheet.OptionsColumn.AllowEdit = False
		Me.colMillSheet.OptionsColumn.ReadOnly = True
		Me.colMillSheet.Visible = True
		Me.colMillSheet.VisibleIndex = 1
		Me.colMillSheet.Width = 180
		'
		'colSerial
		'
		Me.colSerial.AppearanceCell.Options.UseTextOptions = True
		Me.colSerial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colSerial.AppearanceHeader.Options.UseTextOptions = True
		Me.colSerial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colSerial.Caption = "Nama Serial"
		Me.colSerial.FieldName = "Serial"
		Me.colSerial.Name = "colSerial"
		Me.colSerial.OptionsColumn.AllowEdit = False
		Me.colSerial.OptionsColumn.ReadOnly = True
		Me.colSerial.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
		Me.colSerial.Visible = True
		Me.colSerial.VisibleIndex = 2
		Me.colSerial.Width = 179
		'
		'colId
		'
		Me.colId.Caption = "Id"
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'LayoutControlGroup2
		'
		Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
		Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
		Me.LayoutControlGroup2.Size = New System.Drawing.Size(1108, 94)
		Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
		Me.LayoutControlGroup2.Text = "Info Utama"
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Info Utama"
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(1108, 94)
		Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
		Me.LayoutControlGroup1.Text = "Info Utama"
		'
		'LayoutControlGroup3
		'
		Me.LayoutControlGroup3.CustomizationFormText = "Root"
		Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup3.GroupBordersVisible = False
		Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup3.Name = "Root"
		Me.LayoutControlGroup3.Size = New System.Drawing.Size(443, 117)
		Me.LayoutControlGroup3.Text = "Root"
		Me.LayoutControlGroup3.TextVisible = False
		'
		'LayoutControlGroup4
		'
		Me.LayoutControlGroup4.CustomizationFormText = "Root"
		Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup4.GroupBordersVisible = False
		Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup4.Name = "Root"
		Me.LayoutControlGroup4.Size = New System.Drawing.Size(443, 117)
		Me.LayoutControlGroup4.Text = "Root"
		Me.LayoutControlGroup4.TextVisible = False
		'
		'lytMasterTermin
		'
		Me.lytMasterTermin.Controls.Add(Me.xGrid)
		Me.lytMasterTermin.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytMasterTermin.Location = New System.Drawing.Point(0, 0)
		Me.lytMasterTermin.Name = "lytMasterTermin"
		Me.lytMasterTermin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(782, 232, 250, 350)
		Me.lytMasterTermin.Root = Me.LayoutControlGroup5
		Me.lytMasterTermin.Size = New System.Drawing.Size(524, 370)
		Me.lytMasterTermin.TabIndex = 109
		Me.lytMasterTermin.Text = "LayoutControl1"
		'
		'LayoutControlGroup5
		'
		Me.LayoutControlGroup5.CustomizationFormText = "Root"
		Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup5.GroupBordersVisible = False
		Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
		Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup5.Name = "Root"
		Me.LayoutControlGroup5.Size = New System.Drawing.Size(524, 370)
		Me.LayoutControlGroup5.Text = "Root"
		Me.LayoutControlGroup5.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.xGrid
		Me.LayoutControlItem1.CustomizationFormText = "Barang Serial"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(504, 350)
		Me.LayoutControlItem1.Text = "Barang Serial"
		Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem1.TextToControlDistance = 0
		Me.LayoutControlItem1.TextVisible = False
		'
		'UI_FusohPenerimaanBarangDialogSerial
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(524, 419)
		Me.Controls.Add(Me.lytMasterTermin)
		Me.Name = "UI_FusohPenerimaanBarangDialogSerial"
		Me.Text = "UI_FusohEximDialogSerial"
		Me.Controls.SetChildIndex(Me.PanelControl1, 0)
		Me.Controls.SetChildIndex(Me.lytMasterTermin, 0)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytMasterTermin.ResumeLayout(False)
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents lytMasterTermin As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
End Class
