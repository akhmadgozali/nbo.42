﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_SanyuVoucher
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
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit()
    Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtKontak = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.txtNoBukti1 = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoBukti2 = New DevExpress.XtraEditors.LookUpEdit()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LabelControl7
    '
    Me.LabelControl7.Location = New System.Drawing.Point(272, 15)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(15, 13)
    Me.LabelControl7.TabIndex = 125
    Me.LabelControl7.Text = "s/d"
    '
    'LabelControl6
    '
    Me.LabelControl6.Location = New System.Drawing.Point(11, 93)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(56, 13)
    Me.LabelControl6.TabIndex = 124
    Me.LabelControl6.Text = "Keterangan"
    '
    'txtKeterangan
    '
    Me.txtKeterangan.Location = New System.Drawing.Point(95, 90)
    Me.txtKeterangan.Name = "txtKeterangan"
    Me.txtKeterangan.Size = New System.Drawing.Size(367, 20)
    Me.txtKeterangan.TabIndex = 120
    '
    'txtTgl2
    '
    Me.txtTgl2.EditValue = Nothing
    Me.txtTgl2.Location = New System.Drawing.Point(293, 38)
    Me.txtTgl2.Name = "txtTgl2"
    Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl2.Size = New System.Drawing.Size(170, 20)
    Me.txtTgl2.TabIndex = 118
    '
    'txtTgl1
    '
    Me.txtTgl1.EditValue = Nothing
    Me.txtTgl1.Location = New System.Drawing.Point(96, 38)
    Me.txtTgl1.Name = "txtTgl1"
    Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl1.Size = New System.Drawing.Size(170, 20)
    Me.txtTgl1.TabIndex = 117
    '
    'LabelControl4
    '
    Me.LabelControl4.Location = New System.Drawing.Point(272, 41)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(15, 13)
    Me.LabelControl4.TabIndex = 126
    Me.LabelControl4.Text = "s/d"
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(11, 67)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
    Me.LabelControl3.TabIndex = 123
    Me.LabelControl3.Text = "Customer"
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(12, 41)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
    Me.LabelControl2.TabIndex = 122
    Me.LabelControl2.Text = "Tanggal"
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(95, 64)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Size = New System.Drawing.Size(367, 20)
    Me.txtKontak.TabIndex = 119
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
    Me.LabelControl1.TabIndex = 121
    Me.LabelControl1.Text = "No. Bukti"
    '
    'txtNoBukti1
    '
    Me.txtNoBukti1.Location = New System.Drawing.Point(96, 12)
    Me.txtNoBukti1.Name = "txtNoBukti1"
    Me.txtNoBukti1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoBukti1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "No Transaksi")})
    Me.txtNoBukti1.Properties.DisplayMember = "Kode"
    Me.txtNoBukti1.Properties.NullText = ""
    Me.txtNoBukti1.Properties.ValueMember = "Kode"
    Me.txtNoBukti1.Size = New System.Drawing.Size(170, 20)
    Me.txtNoBukti1.TabIndex = 115
    '
    'txtNoBukti2
    '
    Me.txtNoBukti2.Location = New System.Drawing.Point(293, 12)
    Me.txtNoBukti2.Name = "txtNoBukti2"
    Me.txtNoBukti2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoBukti2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "No Transaksi")})
    Me.txtNoBukti2.Properties.DisplayMember = "Kode"
    Me.txtNoBukti2.Properties.NullText = ""
    Me.txtNoBukti2.Properties.ValueMember = "Kode"
    Me.txtNoBukti2.Size = New System.Drawing.Size(170, 20)
    Me.txtNoBukti2.TabIndex = 116
    '
    'RF_SanyuVoucher
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(475, 175)
    Me.Controls.Add(Me.LabelControl7)
    Me.Controls.Add(Me.LabelControl6)
    Me.Controls.Add(Me.txtKeterangan)
    Me.Controls.Add(Me.txtTgl2)
    Me.Controls.Add(Me.txtTgl1)
    Me.Controls.Add(Me.LabelControl4)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.LabelControl2)
    Me.Controls.Add(Me.txtKontak)
    Me.Controls.Add(Me.LabelControl1)
    Me.Controls.Add(Me.txtNoBukti1)
    Me.Controls.Add(Me.txtNoBukti2)
    Me.Name = "RF_SanyuVoucher"
    Me.Text = "Voucher Transaksi"
    Me.Controls.SetChildIndex(Me.txtNoBukti2, 0)
    Me.Controls.SetChildIndex(Me.txtNoBukti1, 0)
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.txtKontak, 0)
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.LabelControl4, 0)
    Me.Controls.SetChildIndex(Me.txtTgl1, 0)
    Me.Controls.SetChildIndex(Me.txtTgl2, 0)
    Me.Controls.SetChildIndex(Me.txtKeterangan, 0)
    Me.Controls.SetChildIndex(Me.LabelControl6, 0)
    Me.Controls.SetChildIndex(Me.LabelControl7, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtKontak As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtNoBukti1 As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNoBukti2 As DevExpress.XtraEditors.LookUpEdit
End Class
