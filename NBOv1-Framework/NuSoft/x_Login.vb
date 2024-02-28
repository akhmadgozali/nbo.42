Public Class x_Login
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Dim dstPcl0 As String = My.Application.Info.DirectoryPath & "\PCL0.png"
    Dim dstPcl1 As String = My.Application.Info.DirectoryPath & "\PCL1.png"
    Dim dstPcl2 As String = My.Application.Info.DirectoryPath & "\PCL2.png"
    If My.Computer.FileSystem.FileExists(dstPcl0) Then
      Panel1.BackgroundImage = System.Drawing.Image.FromFile(dstPcl0)
    Else
      Panel1.BackgroundImage = My.Resources.PCL0
    End If

    If My.Computer.FileSystem.FileExists(dstPcl1) Then
      Pic1.Image = System.Drawing.Image.FromFile(dstPcl1)
    Else
      Pic1.Image = My.Resources.PCL1
    End If

    If My.Computer.FileSystem.FileExists(dstPcl2) Then
      Pic2.Image = System.Drawing.Image.FromFile(dstPcl2)
    Else
      Pic2.Image = Nothing 'My.Resources.PCL2
    End If
    Me.Icon = My.Resources.NusoftIcon
    lblVersi.Text = String.Format("Versi : {0}.{1}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

    '==== Check Configuration
    Try
      txtUser.Text = My.Settings.LastUser
    Catch ex As Exception
    End Try
  End Sub

  Private Sub txtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyDown
    If e.KeyCode = Keys.Enter Then
      Me.ProcessTabKey(Not e.Shift)
      e.Handled = True
    End If
  End Sub
  Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnLogin_Click(sender, Nothing)
    End If
  End Sub

  Private Sub btnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub
  Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
    Try
      If UserLogin.ValidateUser(txtUser.Text, txtPassword.Text) Then
        My.Settings.LastUser = txtUser.Text
        My.Settings.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
      End If
    Catch ex As Utils.Exception
      ex.ShowWinMessageBox()
      Select Case ex.ErrorNumber
        Case -1 : txtUser.Focus() : txtUser.SelectAll()
        Case Else : txtPassword.Focus() : txtPassword.SelectAll()
      End Select
    End Try
  End Sub
  Private Sub btnSetting_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSetting.Click
		Using Frm As New x_Config()
			Frm.ShowDialog()
		End Using
		txtUser.Focus()
  End Sub
End Class