<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Divisi
	Inherits Core.Win.Forms.GridBinding

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
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.DataSource = Me.xpCol
		Me.xGrid.Size = New System.Drawing.Size(765, 374)
		'
		'xpCol
		'
		Me.xpCol.ObjectType = GetType(NuSoft.NPO.Modules.ModSys.Divisi)
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKode})
		Me.xGridView.OptionsCustomization.AllowGroup = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowGroupPanel = False
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
		Me.colId.Visible = True
		Me.colId.VisibleIndex = 0
		'
		'colKode
		'
		Me.colKode.FieldName = "Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 1
		'
		'UI_Divisi
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(765, 401)
		Me.Name = "UI_Divisi"
		Me.Text = "Divisi"
		Me.xpCol = Me.xpCol
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
End Class
