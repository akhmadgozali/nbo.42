<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_SaldoARAP
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
    Me.txtTgl = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtKontak = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtAkun = New DevExpress.XtraEditors.LookUpEdit()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtTgl
    '
    Me.txtTgl.EditValue = Nothing
    Me.txtTgl.Location = New System.Drawing.Point(96, 9)
    Me.txtTgl.Name = "txtTgl"
    Me.txtTgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl.Size = New System.Drawing.Size(170, 20)
    Me.txtTgl.TabIndex = 3
    '
    'LabelControl5
    '
    Me.LabelControl5.Location = New System.Drawing.Point(12, 38)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
    Me.LabelControl5.TabIndex = 9
    Me.LabelControl5.Text = "Kode Akun"
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(12, 64)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
    Me.LabelControl3.TabIndex = 10
    Me.LabelControl3.Text = "Kontak"
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
    Me.LabelControl2.TabIndex = 8
    Me.LabelControl2.Text = "Tanggal"
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(96, 61)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = ""
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Size = New System.Drawing.Size(170, 20)
    Me.txtKontak.TabIndex = 5
    '
    'txtAkun
    '
    Me.txtAkun.Location = New System.Drawing.Point(96, 35)
    Me.txtAkun.Name = "txtAkun"
    Me.txtAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtAkun.Properties.DisplayMember = "Kode"
    Me.txtAkun.Properties.NullText = ""
    Me.txtAkun.Properties.ValueMember = "This"
    Me.txtAkun.Size = New System.Drawing.Size(170, 20)
    Me.txtAkun.TabIndex = 4
    '
    'RF_SaldoARAP
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(316, 173)
    Me.Controls.Add(Me.txtTgl)
    Me.Controls.Add(Me.LabelControl5)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.LabelControl2)
    Me.Controls.Add(Me.txtKontak)
    Me.Controls.Add(Me.txtAkun)
    Me.Name = "RF_SaldoARAP"
    Me.Text = "Filter Transaksi"
    Me.Controls.SetChildIndex(Me.txtAkun, 0)
    Me.Controls.SetChildIndex(Me.txtKontak, 0)
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.LabelControl5, 0)
    Me.Controls.SetChildIndex(Me.txtTgl, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtTgl As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtKontak As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtAkun As DevExpress.XtraEditors.LookUpEdit
End Class
