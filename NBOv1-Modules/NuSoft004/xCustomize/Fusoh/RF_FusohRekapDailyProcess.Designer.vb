<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_FusohRekapDailyProcess
	Inherits Core.Win.Forms.FilterForm

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
		Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
		Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
		Me.txtCustomer = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtNoLOT = New DevExpress.XtraEditors.TextEdit()
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoLOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtTgl2
		'
		Me.txtTgl2.EditValue = Nothing
		Me.txtTgl2.Location = New System.Drawing.Point(291, 12)
		Me.txtTgl2.Name = "txtTgl2"
		Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
		Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTgl2.Size = New System.Drawing.Size(168, 20)
		Me.txtTgl2.TabIndex = 104
		'
		'txtTgl1
		'
		Me.txtTgl1.EditValue = Nothing
		Me.txtTgl1.Location = New System.Drawing.Point(94, 12)
		Me.txtTgl1.Name = "txtTgl1"
		Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
		Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTgl1.Size = New System.Drawing.Size(170, 20)
		Me.txtTgl1.TabIndex = 103
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(270, 15)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(15, 13)
		Me.LabelControl4.TabIndex = 114
		Me.LabelControl4.Text = "s/d"
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(9, 67)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl3.TabIndex = 111
		Me.LabelControl3.Text = "Customer"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(9, 15)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
		Me.LabelControl2.TabIndex = 109
		Me.LabelControl2.Text = "Tanggal"
		'
		'LabelControl8
		'
		Me.LabelControl8.Location = New System.Drawing.Point(9, 41)
		Me.LabelControl8.Name = "LabelControl8"
		Me.LabelControl8.Size = New System.Drawing.Size(39, 13)
		Me.LabelControl8.TabIndex = 117
		Me.LabelControl8.Text = "No. LOT"
		'
		'txtCustomer
		'
		Me.txtCustomer.EnterMoveNextControl = True
		Me.txtCustomer.Location = New System.Drawing.Point(94, 64)
		Me.txtCustomer.Name = "txtCustomer"
		Me.txtCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
		Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCustomer.Properties.DisplayMember = "Kode"
		Me.txtCustomer.Properties.NullText = "<Pilih Customer>"
		Me.txtCustomer.Properties.ShowClearButton = False
		Me.txtCustomer.Properties.ShowFooter = False
		Me.txtCustomer.Properties.ValueMember = "Id"
		Me.txtCustomer.Properties.View = Me.SearchLookUpEdit1View
		Me.txtCustomer.Size = New System.Drawing.Size(365, 20)
		Me.txtCustomer.TabIndex = 119
		'
		'SearchLookUpEdit1View
		'
		Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKontakKode, Me.colKontakNama})
		Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
		Me.SearchLookUpEdit1View.OptionsFind.FindDelay = 500
		Me.SearchLookUpEdit1View.OptionsFind.SearchInPreview = True
		Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKontakKode, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'colKontakKode
		'
		Me.colKontakKode.Caption = "Kode"
		Me.colKontakKode.FieldName = "Kode"
		Me.colKontakKode.Name = "colKontakKode"
		Me.colKontakKode.Visible = True
		Me.colKontakKode.VisibleIndex = 0
		Me.colKontakKode.Width = 355
		'
		'colKontakNama
		'
		Me.colKontakNama.Caption = "Nama"
		Me.colKontakNama.FieldName = "Nama"
		Me.colKontakNama.Name = "colKontakNama"
		Me.colKontakNama.Visible = True
		Me.colKontakNama.VisibleIndex = 1
		Me.colKontakNama.Width = 723
		'
		'txtNoLOT
		'
		Me.txtNoLOT.Location = New System.Drawing.Point(94, 38)
		Me.txtNoLOT.Name = "txtNoLOT"
		Me.txtNoLOT.Size = New System.Drawing.Size(365, 20)
		Me.txtNoLOT.TabIndex = 115
		'
		'RF_FusohProcessRequest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(474, 134)
		Me.Controls.Add(Me.txtCustomer)
		Me.Controls.Add(Me.LabelControl8)
		Me.Controls.Add(Me.txtTgl2)
		Me.Controls.Add(Me.txtTgl1)
		Me.Controls.Add(Me.LabelControl4)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.LabelControl2)
		Me.Controls.Add(Me.txtNoLOT)
		Me.Name = "RF_FusohProcessRequest"
		Me.Text = "Filter Laporan - Process Request"
		Me.Controls.SetChildIndex(Me.txtNoLOT, 0)
		Me.Controls.SetChildIndex(Me.LabelControl2, 0)
		Me.Controls.SetChildIndex(Me.LabelControl3, 0)
		Me.Controls.SetChildIndex(Me.LabelControl4, 0)
		Me.Controls.SetChildIndex(Me.txtTgl1, 0)
		Me.Controls.SetChildIndex(Me.txtTgl2, 0)
		Me.Controls.SetChildIndex(Me.LabelControl8, 0)
		Me.Controls.SetChildIndex(Me.txtCustomer, 0)
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoLOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtCustomer As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtNoLOT As DevExpress.XtraEditors.TextEdit
End Class
