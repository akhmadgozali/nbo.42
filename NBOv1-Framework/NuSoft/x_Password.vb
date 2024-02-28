Public Class x_Password
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Btn2IsClosedButton = True
    AutoCloseOnSave = True
  End Sub
  Public Overrides Sub InitializeData()
    Me.Icon = My.Resources.NusoftIcon
    txtUserId.Text = Core.SSystem.UserInfo.GetUserCode
  End Sub
  Public Overrides Sub Btn1Click()
    If txtPassNew.Text <> txtPassConf.Text Then
      Throw New Utils.Exception("Konfirmasi password tidak sama", -2, "Pastikan tombol CAPS LOCK tidak menyala atau ketik ulang konfirmasi password anda", Me.Text)
    End If
    UserLogin.ChangePassword(txtPassOld.Text, txtPassNew.Text)
    Utils.Win.MessageBox.Show("Ganti Password berhasil", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Public Overrides Sub ErrorBtn1Click(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtPassOld.Focus()
      Case Else : txtPassNew.Focus() : txtPassConf.Text = ""
    End Select
  End Sub
End Class