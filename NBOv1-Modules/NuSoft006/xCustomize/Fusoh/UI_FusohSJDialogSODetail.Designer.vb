<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohSJDialogSODetail
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
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPOLine = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.btn1.Location = New System.Drawing.Point(292, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(385, 11)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 444)
    Me.PanelControl1.Size = New System.Drawing.Size(484, 49)
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(3, 12)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpekRepo})
    Me.xGrid.Size = New System.Drawing.Size(475, 426)
    Me.xGrid.TabIndex = 20
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.GridColumn2, Me.colPOLine, Me.GridColumn1, Me.colQty})
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
    'colKode
    '
    Me.colKode.Caption = "No. SO"
    Me.colKode.FieldName = "Main.Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 1
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "PO Pelanggan"
    Me.GridColumn2.FieldName = "Main.NomorPO"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 2
    '
    'colPOLine
    '
    Me.colPOLine.Caption = "PO Line"
    Me.colPOLine.FieldName = "POLine"
    Me.colPOLine.Name = "colPOLine"
    Me.colPOLine.Visible = True
    Me.colPOLine.VisibleIndex = 3
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode Barang"
    Me.GridColumn1.FieldName = "Barang.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 4
    '
    'colQty
    '
    Me.colQty.Caption = "Qty"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 5
    '
    'colSpekRepo
    '
    Me.colSpekRepo.AutoHeight = False
    Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colSpekRepo.Name = "colSpekRepo"
    '
    'UI_FusohSJDialogSODetail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(484, 493)
    Me.Controls.Add(Me.xGrid)
    Me.Name = "UI_FusohSJDialogSODetail"
    Me.Text = "Daftar SO"
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
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPOLine As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
End Class
