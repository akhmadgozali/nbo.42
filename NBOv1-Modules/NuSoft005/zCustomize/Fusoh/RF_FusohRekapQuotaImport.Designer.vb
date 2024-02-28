<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_FusohRekapQuotaImport
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
		Me.txtPelabuhan = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.txtKodeHS = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		Me.txtNoLampiran = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
		Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit()
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPelabuhan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKodeHS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoLampiran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtTgl2
		'
		Me.txtTgl2.EditValue = Nothing
		Me.txtTgl2.EnterMoveNextControl = True
		Me.txtTgl2.Location = New System.Drawing.Point(278, 12)
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
		Me.txtTgl1.EnterMoveNextControl = True
		Me.txtTgl1.Location = New System.Drawing.Point(81, 12)
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
		Me.LabelControl4.Location = New System.Drawing.Point(257, 15)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(15, 13)
		Me.LabelControl4.TabIndex = 114
		Me.LabelControl4.Text = "s/d"
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(9, 41)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
		Me.LabelControl3.TabIndex = 111
		Me.LabelControl3.Text = "Pelabuhan"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(9, 15)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
		Me.LabelControl2.TabIndex = 109
		Me.LabelControl2.Text = "Expired"
		'
		'txtPelabuhan
		'
		Me.txtPelabuhan.EnterMoveNextControl = True
		Me.txtPelabuhan.Location = New System.Drawing.Point(81, 38)
		Me.txtPelabuhan.Name = "txtPelabuhan"
		Me.txtPelabuhan.Size = New System.Drawing.Size(367, 20)
		Me.txtPelabuhan.TabIndex = 106
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(9, 67)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
		Me.LabelControl1.TabIndex = 116
		Me.LabelControl1.Text = "Kode HS"
		'
		'txtKodeHS
		'
		Me.txtKodeHS.EnterMoveNextControl = True
		Me.txtKodeHS.Location = New System.Drawing.Point(81, 64)
		Me.txtKodeHS.Name = "txtKodeHS"
		Me.txtKodeHS.Size = New System.Drawing.Size(367, 20)
		Me.txtKodeHS.TabIndex = 115
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(9, 93)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(63, 13)
		Me.LabelControl5.TabIndex = 118
		Me.LabelControl5.Text = "No. Lampiran"
		'
		'txtNoLampiran
		'
		Me.txtNoLampiran.EnterMoveNextControl = True
		Me.txtNoLampiran.Location = New System.Drawing.Point(81, 90)
		Me.txtNoLampiran.Name = "txtNoLampiran"
		Me.txtNoLampiran.Size = New System.Drawing.Size(367, 20)
		Me.txtNoLampiran.TabIndex = 117
		'
		'LabelControl6
		'
		Me.LabelControl6.Location = New System.Drawing.Point(9, 119)
		Me.LabelControl6.Name = "LabelControl6"
		Me.LabelControl6.Size = New System.Drawing.Size(56, 13)
		Me.LabelControl6.TabIndex = 120
		Me.LabelControl6.Text = "Keterangan"
		'
		'txtKeterangan
		'
		Me.txtKeterangan.EnterMoveNextControl = True
		Me.txtKeterangan.Location = New System.Drawing.Point(81, 116)
		Me.txtKeterangan.Name = "txtKeterangan"
		Me.txtKeterangan.Size = New System.Drawing.Size(367, 60)
		Me.txtKeterangan.TabIndex = 119
		'
		'RF_FusohRekapQuotaImport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(462, 224)
		Me.Controls.Add(Me.LabelControl6)
		Me.Controls.Add(Me.LabelControl5)
		Me.Controls.Add(Me.txtNoLampiran)
		Me.Controls.Add(Me.LabelControl1)
		Me.Controls.Add(Me.txtKodeHS)
		Me.Controls.Add(Me.txtTgl2)
		Me.Controls.Add(Me.txtTgl1)
		Me.Controls.Add(Me.LabelControl4)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.LabelControl2)
		Me.Controls.Add(Me.txtPelabuhan)
		Me.Controls.Add(Me.txtKeterangan)
		Me.Name = "RF_FusohRekapQuotaImport"
		Me.Text = "Filter Laporan"
		Me.Controls.SetChildIndex(Me.txtKeterangan, 0)
		Me.Controls.SetChildIndex(Me.txtPelabuhan, 0)
		Me.Controls.SetChildIndex(Me.LabelControl2, 0)
		Me.Controls.SetChildIndex(Me.LabelControl3, 0)
		Me.Controls.SetChildIndex(Me.LabelControl4, 0)
		Me.Controls.SetChildIndex(Me.txtTgl1, 0)
		Me.Controls.SetChildIndex(Me.txtTgl2, 0)
		Me.Controls.SetChildIndex(Me.txtKodeHS, 0)
		Me.Controls.SetChildIndex(Me.LabelControl1, 0)
		Me.Controls.SetChildIndex(Me.txtNoLampiran, 0)
		Me.Controls.SetChildIndex(Me.LabelControl5, 0)
		Me.Controls.SetChildIndex(Me.LabelControl6, 0)
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPelabuhan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKodeHS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoLampiran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtPelabuhan As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtKodeHS As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtNoLampiran As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
End Class
