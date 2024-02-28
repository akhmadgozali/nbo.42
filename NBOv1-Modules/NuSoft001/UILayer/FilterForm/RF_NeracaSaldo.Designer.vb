<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_NeracaSaldo
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
    Me.txtPeriodeAwal = New DevExpress.XtraEditors.DateEdit()
    Me.txtPeriodeAkhir = New DevExpress.XtraEditors.DateEdit()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LabelControl5
    '
    Me.LabelControl5.Location = New System.Drawing.Point(12, 41)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
    Me.LabelControl5.TabIndex = 9
    Me.LabelControl5.Text = "Kode Akun"
    '
    'txtAkun1
    '
    Me.txtAkun1.Location = New System.Drawing.Point(91, 38)
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
    Me.LabelControl3.Location = New System.Drawing.Point(267, 41)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(15, 13)
    Me.LabelControl3.TabIndex = 11
    Me.LabelControl3.Text = "s/d"
    '
    'txtAkun2
    '
    Me.txtAkun2.Location = New System.Drawing.Point(288, 38)
    Me.txtAkun2.Name = "txtAkun2"
    Me.txtAkun2.Size = New System.Drawing.Size(170, 20)
    Me.txtAkun2.TabIndex = 3
    '
    'txtPeriodeAwal
    '
    Me.txtPeriodeAwal.EditValue = Nothing
    Me.txtPeriodeAwal.Location = New System.Drawing.Point(91, 13)
    Me.txtPeriodeAwal.Name = "txtPeriodeAwal"
    Me.txtPeriodeAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Size = New System.Drawing.Size(170, 20)
    Me.txtPeriodeAwal.TabIndex = 101
    '
    'txtPeriodeAkhir
    '
    Me.txtPeriodeAkhir.EditValue = Nothing
    Me.txtPeriodeAkhir.Location = New System.Drawing.Point(288, 12)
    Me.txtPeriodeAkhir.Name = "txtPeriodeAkhir"
    Me.txtPeriodeAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Size = New System.Drawing.Size(170, 20)
    Me.txtPeriodeAkhir.TabIndex = 102
    '
    'RF_NeracaSaldo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(473, 119)
    Me.Controls.Add(Me.txtPeriodeAkhir)
    Me.Controls.Add(Me.txtPeriodeAwal)
    Me.Controls.Add(Me.txtAkun2)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.LabelControl5)
    Me.Controls.Add(Me.txtAkun1)
    Me.Controls.Add(Me.LabelControl2)
    Me.Name = "RF_NeracaSaldo"
    Me.Text = "Filter Laporan - Neraca Saldo"
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.txtAkun1, 0)
    Me.Controls.SetChildIndex(Me.LabelControl5, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.txtAkun2, 0)
    Me.Controls.SetChildIndex(Me.txtPeriodeAwal, 0)
    Me.Controls.SetChildIndex(Me.txtPeriodeAkhir, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtAkun1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtAkun2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPeriodeAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtPeriodeAkhir As DevExpress.XtraEditors.DateEdit
End Class
