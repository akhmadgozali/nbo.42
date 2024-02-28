<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_BukuBesarProyek
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
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.txtAkun1 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.txtAkun2 = New DevExpress.XtraEditors.TextEdit()
    Me.txtPeriodeBulan = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.txtPeriodeTahun = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.txtProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.chkTransaksiKosong = New DevExpress.XtraEditors.CheckEdit()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkTransaksiKosong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LabelControl5
    '
    Me.LabelControl5.Location = New System.Drawing.Point(12, 67)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
    Me.LabelControl5.TabIndex = 9
    Me.LabelControl5.Text = "Kode Akun"
    '
    'txtAkun1
    '
    Me.txtAkun1.Location = New System.Drawing.Point(91, 64)
    Me.txtAkun1.Name = "txtAkun1"
    Me.txtAkun1.Size = New System.Drawing.Size(170, 20)
    Me.txtAkun1.TabIndex = 2
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(12, 15)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
    Me.LabelControl2.TabIndex = 10
    Me.LabelControl2.Text = "Periode"
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(267, 67)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(15, 13)
    Me.LabelControl3.TabIndex = 11
    Me.LabelControl3.Text = "s/d"
    '
    'txtAkun2
    '
    Me.txtAkun2.Location = New System.Drawing.Point(288, 64)
    Me.txtAkun2.Name = "txtAkun2"
    Me.txtAkun2.Size = New System.Drawing.Size(170, 20)
    Me.txtAkun2.TabIndex = 3
    '
    'txtPeriodeBulan
    '
    Me.txtPeriodeBulan.Location = New System.Drawing.Point(91, 12)
    Me.txtPeriodeBulan.Name = "txtPeriodeBulan"
    Me.txtPeriodeBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.txtPeriodeBulan.Size = New System.Drawing.Size(170, 20)
    Me.txtPeriodeBulan.TabIndex = 0
    '
    'txtPeriodeTahun
    '
    Me.txtPeriodeTahun.Location = New System.Drawing.Point(288, 12)
    Me.txtPeriodeTahun.Name = "txtPeriodeTahun"
    Me.txtPeriodeTahun.Properties.Mask.EditMask = "0000"
    Me.txtPeriodeTahun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
    Me.txtPeriodeTahun.Size = New System.Drawing.Size(75, 20)
    Me.txtPeriodeTahun.TabIndex = 1
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(12, 41)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
    Me.LabelControl1.TabIndex = 10
    Me.LabelControl1.Text = "Proyek"
    '
    'txtProyek
    '
    Me.txtProyek.Location = New System.Drawing.Point(91, 38)
    Me.txtProyek.Name = "txtProyek"
    Me.txtProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtProyek.Properties.DisplayMember = "Kode"
    Me.txtProyek.Properties.NullText = ""
    Me.txtProyek.Properties.PopupSizeable = False
    Me.txtProyek.Properties.ValueMember = "This"
    Me.txtProyek.Size = New System.Drawing.Size(170, 20)
    Me.txtProyek.TabIndex = 0
    '
    'chkTransaksiKosong
    '
    Me.chkTransaksiKosong.Location = New System.Drawing.Point(91, 91)
    Me.chkTransaksiKosong.Name = "chkTransaksiKosong"
    Me.chkTransaksiKosong.Properties.Caption = "Tampilkan Transaksi Kosong"
    Me.chkTransaksiKosong.Size = New System.Drawing.Size(367, 19)
    Me.chkTransaksiKosong.TabIndex = 101
    '
    'RF_BukuBesarProyek
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(473, 171)
    Me.Controls.Add(Me.chkTransaksiKosong)
    Me.Controls.Add(Me.txtPeriodeTahun)
    Me.Controls.Add(Me.txtPeriodeBulan)
    Me.Controls.Add(Me.txtAkun2)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.LabelControl5)
    Me.Controls.Add(Me.LabelControl1)
    Me.Controls.Add(Me.txtAkun1)
    Me.Controls.Add(Me.LabelControl2)
    Me.Controls.Add(Me.txtProyek)
    Me.Name = "RF_BukuBesarProyek"
    Me.Text = "Filter Laporan - Buku Besar Proyek"
    Me.Controls.SetChildIndex(Me.txtProyek, 0)
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.txtAkun1, 0)
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.LabelControl5, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.txtAkun2, 0)
    Me.Controls.SetChildIndex(Me.txtPeriodeBulan, 0)
    Me.Controls.SetChildIndex(Me.txtPeriodeTahun, 0)
    Me.Controls.SetChildIndex(Me.chkTransaksiKosong, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkTransaksiKosong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtAkun1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtAkun2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPeriodeBulan As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents txtPeriodeTahun As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents chkTransaksiKosong As DevExpress.XtraEditors.CheckEdit
End Class
