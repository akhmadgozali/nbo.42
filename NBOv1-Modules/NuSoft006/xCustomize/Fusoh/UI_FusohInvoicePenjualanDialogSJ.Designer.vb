<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohInvoicePenjualanDialogSJ
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
        Me.colNoSJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPODetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.btn1.Location = New System.Drawing.Point(683, 11)
        '
        'btn2
        '
        Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btn2.Appearance.Options.UseForeColor = True
        Me.btn2.Location = New System.Drawing.Point(776, 11)
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(0, 446)
        Me.PanelControl1.Size = New System.Drawing.Size(875, 49)
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(3, 12)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpekRepo})
        Me.xGrid.Size = New System.Drawing.Size(860, 426)
        Me.xGrid.TabIndex = 20
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoSJ, Me.colNoSO, Me.colNoPO, Me.colNoPODetail, Me.colPOLine, Me.colKodeBarang, Me.colQty})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.NewItemRowText = "Tambah Data"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsCustomization.AllowGroup = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.xGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.xGridView.OptionsSelection.MultiSelect = True
        Me.xGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
        Me.xGridView.OptionsView.ShowAutoFilterRow = True
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colNoSJ
        '
        Me.colNoSJ.Caption = "No. SJ"
        Me.colNoSJ.FieldName = "Main.Kode"
        Me.colNoSJ.Name = "colNoSJ"
        Me.colNoSJ.Visible = True
        Me.colNoSJ.VisibleIndex = 1
        Me.colNoSJ.Width = 135
        '
        'colNoSO
        '
        Me.colNoSO.Caption = "No. SO"
        Me.colNoSO.FieldName = "SODetail.Main.Kode"
        Me.colNoSO.Name = "colNoSO"
        Me.colNoSO.Visible = True
        Me.colNoSO.VisibleIndex = 2
        Me.colNoSO.Width = 135
        '
        'colNoPO
        '
        Me.colNoPO.Caption = "PO Pelanggan"
        Me.colNoPO.FieldName = "SODetail.Main.NomorPO"
        Me.colNoPO.Name = "colNoPO"
        Me.colNoPO.Visible = True
        Me.colNoPO.VisibleIndex = 3
        Me.colNoPO.Width = 135
        '
        'colNoPODetail
        '
        Me.colNoPODetail.Caption = "PO Detail"
        Me.colNoPODetail.FieldName = "SODetail.NoPODetail"
        Me.colNoPODetail.Name = "colNoPODetail"
        Me.colNoPODetail.Visible = True
        Me.colNoPODetail.VisibleIndex = 4
        Me.colNoPODetail.Width = 135
        '
        'colPOLine
        '
        Me.colPOLine.Caption = "PO Line"
        Me.colPOLine.FieldName = "SODetail.POLine"
        Me.colPOLine.Name = "colPOLine"
        Me.colPOLine.Visible = True
        Me.colPOLine.VisibleIndex = 5
        Me.colPOLine.Width = 50
        '
        'colKodeBarang
        '
        Me.colKodeBarang.Caption = "Kode Barang"
        Me.colKodeBarang.FieldName = "Barang.Kode"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 6
        Me.colKodeBarang.Width = 135
        '
        'colQty
        '
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 7
        Me.colQty.Width = 87
        '
        'colSpekRepo
        '
        Me.colSpekRepo.AutoHeight = False
        Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colSpekRepo.Name = "colSpekRepo"
        '
        'UI_FusohInvoicePenjualanDialogSJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 495)
        Me.Controls.Add(Me.xGrid)
        Me.Name = "UI_FusohInvoicePenjualanDialogSJ"
        Me.Text = "Daftar Surat Jalan"
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
	Friend WithEvents colNoSO As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
	Friend WithEvents colNoPO As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPOLine As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNoPODetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoSJ As DevExpress.XtraGrid.Columns.GridColumn
End Class
