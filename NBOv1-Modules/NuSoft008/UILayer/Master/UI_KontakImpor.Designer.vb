<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_KontakImpor
  Inherits Core.Win.Forms.BlankForm

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
    Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
    Me.SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'SimpleButton1
    '
    Me.SimpleButton1.Location = New System.Drawing.Point(26, 233)
    Me.SimpleButton1.Name = "SimpleButton1"
    Me.SimpleButton1.Size = New System.Drawing.Size(123, 23)
    Me.SimpleButton1.TabIndex = 1
    Me.SimpleButton1.Text = "SimpleButton1"
    '
    'SpreadsheetControl1
    '
    Me.SpreadsheetControl1.Location = New System.Drawing.Point(0, 0)
    Me.SpreadsheetControl1.Name = "SpreadsheetControl1"
    Me.SpreadsheetControl1.Size = New System.Drawing.Size(747, 200)
    Me.SpreadsheetControl1.TabIndex = 2
    Me.SpreadsheetControl1.Text = "SpreadsheetControl1"
    '
    'UI_KontakImpor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Controls.Add(Me.SpreadsheetControl1)
    Me.Controls.Add(Me.SimpleButton1)
    Me.Name = "UI_KontakImpor"
    Me.Text = "UI_KontakImpor"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SpreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
End Class
