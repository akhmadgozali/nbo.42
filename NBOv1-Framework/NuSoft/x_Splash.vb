Public Class x_Splash
  Sub New()
    InitializeComponent()
    lblCopy.Text = My.Application.Info.Copyright
  End Sub

  Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
    MyBase.ProcessCommand(cmd, arg)

    Select Case CType(cmd, SplashScreenCommand)
      Case SplashScreenCommand.ChangeProgress : txtProgress.Text = arg.ToString
      Case Else : txtProgress.Text = "Loading ..."
    End Select
  End Sub

  Public Enum SplashScreenCommand
    ChangeProgress
  End Enum
End Class
