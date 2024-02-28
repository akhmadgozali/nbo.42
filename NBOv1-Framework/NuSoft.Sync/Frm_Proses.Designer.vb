<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Proses
  Inherits DevExpress.XtraEditors.XtraForm

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
    Me.PB = New DevExpress.XtraEditors.ProgressBarControl()
    Me.MB = New DevExpress.XtraEditors.MarqueeProgressBarControl()
    Me.lbl = New DevExpress.XtraEditors.LabelControl()
    Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
    CType(Me.PB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PB
    '
    Me.PB.Location = New System.Drawing.Point(14, 10)
    Me.PB.Name = "PB"
    Me.PB.Properties.ShowTitle = True
    Me.PB.Size = New System.Drawing.Size(497, 26)
    Me.PB.TabIndex = 0
    '
    'MB
    '
    Me.MB.EditValue = "0"
    Me.MB.Location = New System.Drawing.Point(14, 10)
    Me.MB.Name = "MB"
    Me.MB.Size = New System.Drawing.Size(497, 26)
    Me.MB.TabIndex = 1
    '
    'lbl
    '
    Me.lbl.Location = New System.Drawing.Point(14, 42)
    Me.lbl.Name = "lbl"
    Me.lbl.Size = New System.Drawing.Size(12, 13)
    Me.lbl.TabIndex = 2
    Me.lbl.Text = "..."
    '
    'BackgroundWorker1
    '
    Me.BackgroundWorker1.WorkerReportsProgress = True
    '
    'Frm_Proses
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(527, 67)
    Me.Controls.Add(Me.lbl)
    Me.Controls.Add(Me.MB)
    Me.Controls.Add(Me.PB)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Frm_Proses"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Proses Sync"
    CType(Me.PB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PB As DevExpress.XtraEditors.ProgressBarControl
  Friend WithEvents MB As DevExpress.XtraEditors.MarqueeProgressBarControl
  Friend WithEvents lbl As DevExpress.XtraEditors.LabelControl
  Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
