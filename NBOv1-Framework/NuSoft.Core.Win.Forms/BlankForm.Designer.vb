Namespace NuSoft.Core.Win.Forms
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class BlankForm
    Inherits NuSoftForm

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
      Me.components = New System.ComponentModel.Container()
      Me.session = New DevExpress.Xpo.UnitOfWork(Me.components)
      CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'session
      '
      Me.session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None
      '
      'BlankForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(759, 395)
      Me.Name = "BlankForm"
      Me.Text = "Blank Form"
      CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

    End Sub
    Public WithEvents session As DevExpress.Xpo.UnitOfWork
  End Class
End Namespace