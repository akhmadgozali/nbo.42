<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_PrepaidExpenseAmortisasi
  Inherits Core.Win.Forms.InputDialog

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
    Me.pbProses = New DevExpress.XtraEditors.ProgressBarControl()
    Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pbProses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl2.SuspendLayout()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pbProses
    '
    Me.pbProses.Location = New System.Drawing.Point(12, 58)
    Me.pbProses.Name = "pbProses"
    Me.pbProses.Size = New System.Drawing.Size(359, 18)
    Me.pbProses.TabIndex = 100
    '
    'PanelControl2
    '
    Me.PanelControl2.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.PanelControl2.Appearance.Options.UseBackColor = True
    Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.PanelControl2.Controls.Add(Me.LabelControl2)
    Me.PanelControl2.Controls.Add(Me.txtTanggal)
    Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
    Me.PanelControl2.Name = "PanelControl2"
    Me.PanelControl2.Size = New System.Drawing.Size(383, 40)
    Me.PanelControl2.TabIndex = 101
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
    Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
    Me.LabelControl2.TabIndex = 5
    Me.LabelControl2.Text = "Tanggal"
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(56, 9)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(195, 20)
    Me.txtTanggal.TabIndex = 1
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
    Me.LabelControl1.Location = New System.Drawing.Point(12, 82)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(166, 13)
    Me.LabelControl1.TabIndex = 5
    Me.LabelControl1.Text = "Status : Amortisasi - Sewa Gedung"
    '
    'UI_PrepaidExpenseAmortisasi
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(383, 167)
    Me.Controls.Add(Me.LabelControl1)
    Me.Controls.Add(Me.PanelControl2)
    Me.Controls.Add(Me.pbProses)
    Me.Name = "UI_PrepaidExpenseAmortisasi"
    Me.Text = "Amortisasi Prepaid Expense"
    Me.Controls.SetChildIndex(Me.pbProses, 0)
    Me.Controls.SetChildIndex(Me.PanelControl2, 0)
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pbProses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl2.ResumeLayout(False)
    Me.PanelControl2.PerformLayout()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents pbProses As DevExpress.XtraEditors.ProgressBarControl
  Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
