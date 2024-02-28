<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_FusohDetailStokBahanBaku
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
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.txtCustomer = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
		Me.txtPartNo = New DevExpress.XtraEditors.TextEdit()
		Me.txtMaterial = New DevExpress.XtraEditors.TextEdit()
		Me.chkStock0 = New DevExpress.XtraEditors.CheckEdit()
		Me.txtTanggal1 = New DevExpress.XtraEditors.DateEdit()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.chkTitipan = New DevExpress.XtraEditors.CheckEdit()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
		Me.txtTanggal2 = New DevExpress.XtraEditors.DateEdit()
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkStock0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkTitipan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggal2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(9, 67)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl3.TabIndex = 111
		Me.LabelControl3.Text = "Customer"
		'
		'txtCustomer
		'
		Me.txtCustomer.Location = New System.Drawing.Point(93, 64)
		Me.txtCustomer.Name = "txtCustomer"
		Me.txtCustomer.Size = New System.Drawing.Size(345, 20)
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
		Me.txtPartNo.Size = New System.Drawing.Size(345, 20)
		Me.txtPartNo.TabIndex = 118
		'
		'txtMaterial
		'
		Me.txtMaterial.Location = New System.Drawing.Point(93, 38)
		Me.txtMaterial.Name = "txtMaterial"
		Me.txtMaterial.Size = New System.Drawing.Size(345, 20)
		Me.txtMaterial.TabIndex = 119
		'
		'chkStock0
		'
		Me.chkStock0.Location = New System.Drawing.Point(90, 139)
		Me.chkStock0.Name = "chkStock0"
		Me.chkStock0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.chkStock0.Properties.Caption = "Tampilkan Stock 0"
		Me.chkStock0.Size = New System.Drawing.Size(162, 21)
		Me.chkStock0.TabIndex = 154
		'
		'txtTanggal1
		'
		Me.txtTanggal1.EditValue = Nothing
		Me.txtTanggal1.Location = New System.Drawing.Point(93, 90)
		Me.txtTanggal1.Name = "txtTanggal1"
		Me.txtTanggal1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
		Me.txtTanggal1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTanggal1.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal1.Size = New System.Drawing.Size(159, 20)
		Me.txtTanggal1.TabIndex = 152
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(10, 93)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(57, 13)
		Me.LabelControl2.TabIndex = 153
		Me.LabelControl2.Text = "Per Tanggal"
		'
		'chkTitipan
		'
		Me.chkTitipan.Location = New System.Drawing.Point(90, 113)
		Me.chkTitipan.Name = "chkTitipan"
		Me.chkTitipan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.chkTitipan.Properties.Caption = "Barang Titipan"
		Me.chkTitipan.Size = New System.Drawing.Size(162, 21)
		Me.chkTitipan.TabIndex = 155
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(258, 93)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(15, 13)
		Me.LabelControl4.TabIndex = 156
		Me.LabelControl4.Text = "s/d"
		'
		'txtTanggal2
		'
		Me.txtTanggal2.EditValue = Nothing
		Me.txtTanggal2.Location = New System.Drawing.Point(279, 90)
		Me.txtTanggal2.Name = "txtTanggal2"
		Me.txtTanggal2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
		Me.txtTanggal2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggal2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTanggal2.Properties.DisplayFormat.FormatString = "D"
		Me.txtTanggal2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTanggal2.Size = New System.Drawing.Size(159, 20)
		Me.txtTanggal2.TabIndex = 157
		'
		'RF_FusohDetailStokBahanBaku
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(454, 211)
		Me.Controls.Add(Me.txtTanggal2)
		Me.Controls.Add(Me.LabelControl4)
		Me.Controls.Add(Me.chkTitipan)
		Me.Controls.Add(Me.chkStock0)
		Me.Controls.Add(Me.txtTanggal1)
		Me.Controls.Add(Me.LabelControl2)
		Me.Controls.Add(Me.txtMaterial)
		Me.Controls.Add(Me.txtPartNo)
		Me.Controls.Add(Me.LabelControl8)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.txtCustomer)
		Me.Controls.Add(Me.LabelControl1)
		Me.Name = "RF_FusohDetailStokBahanBaku"
		Me.Text = "Filter Laporan"
		Me.Controls.SetChildIndex(Me.LabelControl1, 0)
		Me.Controls.SetChildIndex(Me.txtCustomer, 0)
		Me.Controls.SetChildIndex(Me.LabelControl3, 0)
		Me.Controls.SetChildIndex(Me.LabelControl8, 0)
		Me.Controls.SetChildIndex(Me.txtPartNo, 0)
		Me.Controls.SetChildIndex(Me.txtMaterial, 0)
		Me.Controls.SetChildIndex(Me.LabelControl2, 0)
		Me.Controls.SetChildIndex(Me.txtTanggal1, 0)
		Me.Controls.SetChildIndex(Me.chkStock0, 0)
		Me.Controls.SetChildIndex(Me.chkTitipan, 0)
		Me.Controls.SetChildIndex(Me.LabelControl4, 0)
		Me.Controls.SetChildIndex(Me.txtTanggal2, 0)
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkStock0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkTitipan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggal2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPartNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaterial As DevExpress.XtraEditors.TextEdit
	Friend WithEvents chkStock0 As DevExpress.XtraEditors.CheckEdit
	Friend WithEvents txtTanggal1 As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents chkTitipan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTanggal2 As DevExpress.XtraEditors.DateEdit
End Class
