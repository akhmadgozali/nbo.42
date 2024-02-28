Imports NuSoft.Core.Win.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UIX_Dashboard
	Inherits NuSoftForm

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
		Me.SuspendLayout()
		'
		'UIX_Dashboard
		'
		Me.ClientSize = New System.Drawing.Size(822, 417)
		Me.ControlBox = False
		Me.Name = "UIX_Dashboard"
		Me.Text = "Dashboard"
		Me.ResumeLayout(False)

	End Sub
End Class