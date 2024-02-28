<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_FusohStockBalance
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
		Me.txtTanggalAwal = New DevExpress.XtraEditors.DateEdit()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.txtCustomer = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
		Me.txtPartNo = New DevExpress.XtraEditors.TextEdit()
		Me.txtMaterial = New DevExpress.XtraEditors.TextEdit()
		Me.chkStock0 = New DevExpress.XtraEditors.CheckEdit()
		Me.txtTanggalAkhir = New DevExpress.XtraEditors.DateEdit()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
		Me.chkTitipan = New DevExpress.XtraEditors.CheckEdit()
		Me.txtJenis = New DevExpress.XtraEditors.RadioGroup()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkStock0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkTitipan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtTanggalAwal
		'
		Me.txtTanggalAwal.EditValue = Nothing
		Me.txtTanggalAwal.Location = New System.Drawing.Point(93, 90)
		Me.txtTanggalAwal.Name = "txtTanggalAwal"
		Me.txtTanggalAwal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
		Me.txtTanggalAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggalAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTanggalAwal.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggalAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggalAwal.Size = New System.Drawing.Size(200, 20)
		Me.txtTanggalAwal.TabIndex = 103
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
		Me.LabelControl2.Location = New System.Drawing.Point(10, 93)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
		Me.LabelControl2.TabIndex = 109
		Me.LabelControl2.Text = "Periode"
		'
		'txtCustomer
		'
		Me.txtCustomer.Location = New System.Drawing.Point(93, 64)
		Me.txtCustomer.Name = "txtCustomer"
		Me.txtCustomer.Size = New System.Drawing.Size(427, 20)
		Me.txtCustomer.TabIndex = 106
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(10, 15)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
		Me.LabelControl1.TabIndex = 108
		Me.LabelControl1.Text = "Part No"
		'
		'LabelControl8
		'
		Me.LabelControl8.Location = New System.Drawing.Point(10, 41)
		Me.LabelControl8.Name = "LabelControl8"
		Me.LabelControl8.Size = New System.Drawing.Size(65, 13)
		Me.LabelControl8.TabIndex = 117
		Me.LabelControl8.Text = "Material Type"
		'
		'txtPartNo
		'
		Me.txtPartNo.Location = New System.Drawing.Point(93, 12)
		Me.txtPartNo.Name = "txtPartNo"
		Me.txtPartNo.Size = New System.Drawing.Size(427, 20)
		Me.txtPartNo.TabIndex = 118
		'
		'txtMaterial
		'
		Me.txtMaterial.Location = New System.Drawing.Point(93, 38)
		Me.txtMaterial.Name = "txtMaterial"
		Me.txtMaterial.Size = New System.Drawing.Size(427, 20)
		Me.txtMaterial.TabIndex = 119
		'
		'chkStock0
		'
		Me.chkStock0.Location = New System.Drawing.Point(90, 116)
		Me.chkStock0.Name = "chkStock0"
		Me.chkStock0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.chkStock0.Properties.Caption = "Tampilkan Stock 0"
		Me.chkStock0.Size = New System.Drawing.Size(162, 21)
		Me.chkStock0.TabIndex = 151
		'
		'txtTanggalAkhir
		'
		Me.txtTanggalAkhir.EditValue = Nothing
		Me.txtTanggalAkhir.Location = New System.Drawing.Point(320, 90)
		Me.txtTanggalAkhir.Name = "txtTanggalAkhir"
		Me.txtTanggalAkhir.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
		Me.txtTanggalAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggalAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTanggalAkhir.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggalAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggalAkhir.Size = New System.Drawing.Size(200, 20)
		Me.txtTanggalAkhir.TabIndex = 152
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(299, 93)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(15, 13)
		Me.LabelControl4.TabIndex = 153
		Me.LabelControl4.Text = "s/d"
		'
		'chkTitipan
		'
		Me.chkTitipan.Location = New System.Drawing.Point(403, 158)
		Me.chkTitipan.Name = "chkTitipan"
		Me.chkTitipan.Properties.Caption = "Barang Titipan"
		Me.chkTitipan.Size = New System.Drawing.Size(174, 19)
		Me.chkTitipan.TabIndex = 154
		Me.chkTitipan.Visible = False
		'
		'txtJenis
		'
		Me.txtJenis.EditValue = CType(1, Short)
		Me.txtJenis.Location = New System.Drawing.Point(93, 143)
		Me.txtJenis.Name = "txtJenis"
		Me.txtJenis.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "All"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Stock"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Titipan")})
		Me.txtJenis.Size = New System.Drawing.Size(200, 56)
		Me.txtJenis.TabIndex = 155
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(10, 143)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(24, 13)
		Me.LabelControl5.TabIndex = 156
		Me.LabelControl5.Text = "Jenis"
		'
		'RF_FusohStockBalance
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(536, 263)
		Me.Controls.Add(Me.LabelControl5)
		Me.Controls.Add(Me.txtJenis)
		Me.Controls.Add(Me.chkTitipan)
		Me.Controls.Add(Me.LabelControl4)
		Me.Controls.Add(Me.txtTanggalAkhir)
		Me.Controls.Add(Me.chkStock0)
		Me.Controls.Add(Me.txtMaterial)
		Me.Controls.Add(Me.txtPartNo)
		Me.Controls.Add(Me.LabelControl8)
		Me.Controls.Add(Me.txtTanggalAwal)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.LabelControl2)
		Me.Controls.Add(Me.txtCustomer)
		Me.Controls.Add(Me.LabelControl1)
		Me.Name = "RF_FusohStockBalance"
		Me.Text = "Filter Laporan"
		Me.Controls.SetChildIndex(Me.LabelControl1, 0)
		Me.Controls.SetChildIndex(Me.txtCustomer, 0)
		Me.Controls.SetChildIndex(Me.LabelControl2, 0)
		Me.Controls.SetChildIndex(Me.LabelControl3, 0)
		Me.Controls.SetChildIndex(Me.txtTanggalAwal, 0)
		Me.Controls.SetChildIndex(Me.LabelControl8, 0)
		Me.Controls.SetChildIndex(Me.txtPartNo, 0)
		Me.Controls.SetChildIndex(Me.txtMaterial, 0)
		Me.Controls.SetChildIndex(Me.chkStock0, 0)
		Me.Controls.SetChildIndex(Me.txtTanggalAkhir, 0)
		Me.Controls.SetChildIndex(Me.LabelControl4, 0)
		Me.Controls.SetChildIndex(Me.chkTitipan, 0)
		Me.Controls.SetChildIndex(Me.txtJenis, 0)
		Me.Controls.SetChildIndex(Me.LabelControl5, 0)
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkStock0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkTitipan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtTanggalAwal As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtCustomer As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtPartNo As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtMaterial As DevExpress.XtraEditors.TextEdit
	Friend WithEvents chkStock0 As DevExpress.XtraEditors.CheckEdit
	Friend WithEvents txtTanggalAkhir As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents chkTitipan As DevExpress.XtraEditors.CheckEdit
	Friend WithEvents txtJenis As DevExpress.XtraEditors.RadioGroup
	Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
