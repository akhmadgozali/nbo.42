<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_FusohRekapSerial
  Inherits Core.Win.Forms.FilterForm

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
    Me.chkStock0 = New DevExpress.XtraEditors.CheckEdit()
    Me.txtPerTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtMaterial = New DevExpress.XtraEditors.TextEdit()
    Me.txtPartNo = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.txtCustomer = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.txtMilSheet = New DevExpress.XtraEditors.TextEdit()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkStock0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPerTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPerTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMilSheet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'chkStock0
    '
    Me.chkStock0.Location = New System.Drawing.Point(88, 138)
    Me.chkStock0.Name = "chkStock0"
    Me.chkStock0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.chkStock0.Properties.Caption = "Tampilkan Stock 0"
    Me.chkStock0.Size = New System.Drawing.Size(162, 21)
    Me.chkStock0.TabIndex = 163
    '
    'txtPerTanggal
    '
    Me.txtPerTanggal.EditValue = Nothing
    Me.txtPerTanggal.Location = New System.Drawing.Point(91, 90)
    Me.txtPerTanggal.Name = "txtPerTanggal"
    Me.txtPerTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
    Me.txtPerTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPerTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtPerTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtPerTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtPerTanggal.Size = New System.Drawing.Size(252, 20)
    Me.txtPerTanggal.TabIndex = 161
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(8, 93)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(57, 13)
    Me.LabelControl2.TabIndex = 162
    Me.LabelControl2.Text = "Per Tanggal"
    '
    'txtMaterial
    '
    Me.txtMaterial.Location = New System.Drawing.Point(91, 38)
    Me.txtMaterial.Name = "txtMaterial"
    Me.txtMaterial.Size = New System.Drawing.Size(252, 20)
    Me.txtMaterial.TabIndex = 160
    '
    'txtPartNo
    '
    Me.txtPartNo.Location = New System.Drawing.Point(91, 12)
    Me.txtPartNo.Name = "txtPartNo"
    Me.txtPartNo.Size = New System.Drawing.Size(252, 20)
    Me.txtPartNo.TabIndex = 159
    '
    'LabelControl8
    '
    Me.LabelControl8.Location = New System.Drawing.Point(8, 41)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(65, 13)
    Me.LabelControl8.TabIndex = 158
    Me.LabelControl8.Text = "Material Type"
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(7, 67)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
    Me.LabelControl3.TabIndex = 157
    Me.LabelControl3.Text = "Customer"
    '
    'txtCustomer
    '
    Me.txtCustomer.Location = New System.Drawing.Point(91, 64)
    Me.txtCustomer.Name = "txtCustomer"
    Me.txtCustomer.Size = New System.Drawing.Size(252, 20)
    Me.txtCustomer.TabIndex = 155
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(8, 15)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
    Me.LabelControl1.TabIndex = 156
    Me.LabelControl1.Text = "Part No"
    '
    'LabelControl4
    '
    Me.LabelControl4.Location = New System.Drawing.Point(7, 119)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(45, 13)
    Me.LabelControl4.TabIndex = 165
    Me.LabelControl4.Text = "Mill Sheet"
    '
    'txtMilSheet
    '
    Me.txtMilSheet.Location = New System.Drawing.Point(91, 116)
    Me.txtMilSheet.Name = "txtMilSheet"
    Me.txtMilSheet.Size = New System.Drawing.Size(252, 20)
    Me.txtMilSheet.TabIndex = 164
    '
    'RF_FusohRekapSerial
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(365, 251)
    Me.Controls.Add(Me.LabelControl4)
    Me.Controls.Add(Me.txtMilSheet)
    Me.Controls.Add(Me.chkStock0)
    Me.Controls.Add(Me.txtPerTanggal)
    Me.Controls.Add(Me.LabelControl2)
    Me.Controls.Add(Me.txtMaterial)
    Me.Controls.Add(Me.txtPartNo)
    Me.Controls.Add(Me.LabelControl8)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.txtCustomer)
    Me.Controls.Add(Me.LabelControl1)
    Me.Name = "RF_FusohRekapSerial"
    Me.Text = "Filter Data Serial"
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.txtCustomer, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.LabelControl8, 0)
    Me.Controls.SetChildIndex(Me.txtPartNo, 0)
    Me.Controls.SetChildIndex(Me.txtMaterial, 0)
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.txtPerTanggal, 0)
    Me.Controls.SetChildIndex(Me.chkStock0, 0)
    Me.Controls.SetChildIndex(Me.txtMilSheet, 0)
    Me.Controls.SetChildIndex(Me.LabelControl4, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkStock0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPerTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPerTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPartNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMilSheet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents chkStock0 As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtPerTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtMaterial As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPartNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtCustomer As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtMilSheet As DevExpress.XtraEditors.TextEdit
End Class
