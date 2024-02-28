<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_PenerimaanBarangDialogSerial
	Inherits Core.Win.Forms.BlankForm

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
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(12, 12)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(609, 321)
		Me.xGrid.TabIndex = 100
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colLength, Me.colSerial})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.IndicatorWidth = 30
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colId
		'
		Me.colId.FieldName = "Id"
		Me.colId.Name = "colId"
		'
		'colLength
		'
		Me.colLength.FieldName = "Length"
		Me.colLength.Name = "colLength"
		Me.colLength.Visible = True
		Me.colLength.VisibleIndex = 1
		'
		'colSerial
		'
		Me.colSerial.FieldName = "Serial"
		Me.colSerial.Name = "colSerial"
		Me.colSerial.Visible = True
		Me.colSerial.VisibleIndex = 0
		'
		'UI_PenerimaanBarangDialogSerial
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(633, 344)
		Me.Controls.Add(Me.xGrid)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "UI_PenerimaanBarangDialogSerial"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "UI_PenerimaanBarangDialogSerial"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
End Class
