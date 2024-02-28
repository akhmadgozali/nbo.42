<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Fusoh_SQDialogBarang
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
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colNoPart = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colInD = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colThickness = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn1
		'
		Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btn1.Appearance.Options.UseForeColor = True
		Me.btn1.Location = New System.Drawing.Point(306, 12)
		Me.btn1.Text = "&Filter"
		'
		'btn2
		'
		Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
		Me.btn2.Appearance.Options.UseForeColor = True
		Me.btn2.Location = New System.Drawing.Point(399, 12)
		'
		'PanelControl1
		'
		Me.PanelControl1.Location = New System.Drawing.Point(0, 439)
		Me.PanelControl1.Size = New System.Drawing.Size(498, 49)
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 12)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpekRepo})
		Me.xGrid.Size = New System.Drawing.Size(474, 426)
		Me.xGrid.TabIndex = 19
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
		Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.xGridView.ColumnPanelRowHeight = 30
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoPart, Me.colNamaBarang, Me.colOD, Me.colInD, Me.colThickness, Me.colLength})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.NewItemRowText = "Tambah Data"
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
		Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
		Me.xGridView.OptionsView.ShowAutoFilterRow = True
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colNoPart
		'
		Me.colNoPart.Caption = "Part No."
		Me.colNoPart.FieldName = "Kode"
		Me.colNoPart.Name = "colNoPart"
		Me.colNoPart.Visible = True
		Me.colNoPart.VisibleIndex = 0
		Me.colNoPart.Width = 130
		'
		'colNamaBarang
		'
		Me.colNamaBarang.AppearanceCell.Options.UseTextOptions = True
		Me.colNamaBarang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
		Me.colNamaBarang.AppearanceHeader.Options.UseTextOptions = True
		Me.colNamaBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colNamaBarang.Caption = "Material"
		Me.colNamaBarang.FieldName = "Nama"
		Me.colNamaBarang.Name = "colNamaBarang"
		Me.colNamaBarang.Visible = True
		Me.colNamaBarang.VisibleIndex = 1
		Me.colNamaBarang.Width = 130
		'
		'colOD
		'
		Me.colOD.AppearanceCell.Options.UseTextOptions = True
		Me.colOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colOD.AppearanceHeader.Options.UseTextOptions = True
		Me.colOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colOD.Caption = "OD"
		Me.colOD.DisplayFormat.FormatString = "n2"
		Me.colOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colOD.FieldName = "OutDiameter"
		Me.colOD.Name = "colOD"
		Me.colOD.Visible = True
		Me.colOD.VisibleIndex = 2
		Me.colOD.Width = 48
		'
		'colInD
		'
		Me.colInD.AppearanceCell.Options.UseTextOptions = True
		Me.colInD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colInD.AppearanceHeader.Options.UseTextOptions = True
		Me.colInD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colInD.Caption = "ID"
		Me.colInD.DisplayFormat.FormatString = "n2"
		Me.colInD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colInD.FieldName = "InDiameter"
		Me.colInD.Name = "colInD"
		Me.colInD.Visible = True
		Me.colInD.VisibleIndex = 3
		Me.colInD.Width = 48
		'
		'colThickness
		'
		Me.colThickness.AppearanceCell.Options.UseTextOptions = True
		Me.colThickness.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colThickness.AppearanceHeader.Options.UseTextOptions = True
		Me.colThickness.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colThickness.Caption = "T"
		Me.colThickness.DisplayFormat.FormatString = "n2"
		Me.colThickness.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colThickness.FieldName = "Thickness"
		Me.colThickness.Name = "colThickness"
		Me.colThickness.Visible = True
		Me.colThickness.VisibleIndex = 4
		Me.colThickness.Width = 48
		'
		'colLength
		'
		Me.colLength.AppearanceCell.Options.UseTextOptions = True
		Me.colLength.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLength.AppearanceHeader.Options.UseTextOptions = True
		Me.colLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colLength.Caption = "L"
		Me.colLength.DisplayFormat.FormatString = "n2"
		Me.colLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLength.FieldName = "Length"
		Me.colLength.Name = "colLength"
		Me.colLength.Visible = True
		Me.colLength.VisibleIndex = 5
		Me.colLength.Width = 60
		'
		'colSpekRepo
		'
		Me.colSpekRepo.AutoHeight = False
		Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colSpekRepo.Name = "colSpekRepo"
		'
		'UI_Fusoh_SQDialogBarang
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(498, 488)
		Me.Controls.Add(Me.xGrid)
		Me.Name = "UI_Fusoh_SQDialogBarang"
		Me.Text = "Pilih Item"
		Me.Controls.SetChildIndex(Me.PanelControl1, 0)
		Me.Controls.SetChildIndex(Me.xGrid, 0)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colNoPart As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colOD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
	Friend WithEvents colInD As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colThickness As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
End Class
