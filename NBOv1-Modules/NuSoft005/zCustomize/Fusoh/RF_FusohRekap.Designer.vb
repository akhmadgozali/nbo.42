<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_FusohRekap
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
		Me.txtKontak = New DevExpress.XtraEditors.TextEdit()
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtTgl2
		'
		Me.txtTgl2.EditValue = Nothing
		Me.txtTgl2.Location = New System.Drawing.Point(290, 12)
		Me.txtTgl2.Name = "txtTgl2"
		Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
		Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTgl2.Size = New System.Drawing.Size(170, 20)
		Me.txtTgl2.TabIndex = 104
		'
		'txtTgl1
		'
		Me.txtTgl1.EditValue = Nothing
		Me.txtTgl1.Location = New System.Drawing.Point(93, 12)
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
		Me.LabelControl4.Location = New System.Drawing.Point(269, 15)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(15, 13)
		Me.LabelControl4.TabIndex = 114
		Me.LabelControl4.Text = "s/d"
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(9, 41)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(34, 13)
		Me.LabelControl3.TabIndex = 111
		Me.LabelControl3.Text = "Vendor"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(9, 15)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
		Me.LabelControl2.TabIndex = 109
		Me.LabelControl2.Text = "Tanggal"
		'
		'txtKontak
		'
		Me.txtKontak.Location = New System.Drawing.Point(93, 38)
		Me.txtKontak.Name = "txtKontak"
		Me.txtKontak.Size = New System.Drawing.Size(367, 20)
		Me.txtKontak.TabIndex = 106
		'
		'RF_FusohRekap
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(474, 109)
		Me.Controls.Add(Me.txtTgl2)
		Me.Controls.Add(Me.txtTgl1)
		Me.Controls.Add(Me.LabelControl4)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.LabelControl2)
		Me.Controls.Add(Me.txtKontak)
		Me.Name = "RF_FusohRekap"
		Me.Text = "Filter Laporan"
		Me.Controls.SetChildIndex(Me.txtKontak, 0)
		Me.Controls.SetChildIndex(Me.LabelControl2, 0)
		Me.Controls.SetChildIndex(Me.LabelControl3, 0)
		Me.Controls.SetChildIndex(Me.LabelControl4, 0)
		Me.Controls.SetChildIndex(Me.txtTgl1, 0)
		Me.Controls.SetChildIndex(Me.txtTgl2, 0)
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtKontak As DevExpress.XtraEditors.TextEdit
End Class
