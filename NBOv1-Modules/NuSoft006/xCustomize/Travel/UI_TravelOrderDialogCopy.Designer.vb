<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_TravelOrderDialogCopy
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
		Me.txtCopySO = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCopySO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
        Me.btn1.Appearance.Options.UseForeColor = True
        Me.btn1.Text = "&Copy"
        '
        'btn2
        '
        Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btn2.Appearance.Options.UseForeColor = True
        Me.btn2.Text = "&Batal"
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(0, 76)
        Me.PanelControl1.Size = New System.Drawing.Size(352, 49)
        '
        'txtCopySO
        '
        Me.txtCopySO.Location = New System.Drawing.Point(25, 39)
        Me.txtCopySO.Name = "txtCopySO"
        Me.txtCopySO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCopySO.Properties.DisplayMember = "Kode"
        Me.txtCopySO.Properties.NullText = "<Pilih Nomor SO>"
        Me.txtCopySO.Properties.ValueMember = "This"
        Me.txtCopySO.Properties.View = Me.GridView3
        Me.txtCopySO.Size = New System.Drawing.Size(303, 20)
        Me.txtCopySO.TabIndex = 27
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Kode"
        Me.GridColumn7.FieldName = "Kode"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tanggal"
        Me.GridColumn8.DisplayFormat.FormatString = "dd-MM-yy"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn8.FieldName = "Tanggal"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Pelanggan"
        Me.GridColumn9.FieldName = "Pelanggan.Nama"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Uraian"
        Me.GridColumn10.FieldName = "Uraian"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Pilih Nomor SO"
        '
        'UI_TravelOrderDialogCopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 125)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCopySO)
        Me.Name = "UI_TravelOrderDialogCopy"
        Me.Text = "Copy SO"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtCopySO, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtCopySO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCopySO As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents Label1 As Label
End Class
