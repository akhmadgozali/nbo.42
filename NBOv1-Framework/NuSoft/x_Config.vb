Friend Class x_Config
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Me.Icon = My.Resources.NusoftIcon

  End Sub

  Public Overrides Sub InitializeData()
    Btn2IsClosedButton = True

    Try
      Dim encryptDES As New Utils.Cryptograph.DES() With {.Key = Data.Helper.GetKey}
      txtServer.EditValue = Data.Helper.GetServer(encryptDES)
      txtPrefiks.EditValue = Data.Helper.GetPrefiks(encryptDES)
      txtUpdateOtomatis.Checked = CBool(Data.Helper.GetSyncAuto(encryptDES))
      txtUpdateInterval.EditValue = Data.Helper.GetSyncInterval(encryptDES)
      txtMultipleInstance.Checked = CBool(Data.Helper.GetMultipleInstance(encryptDES))

      txtUpdateServer.EditValue = Data.Helper.GetUpdateServer(encryptDES)
      txtUpdatePort.EditValue = Data.Helper.GetUpdatePort(encryptDES)
      txtUpdateUser.EditValue = Data.Helper.GetUpdateUser(encryptDES)
      txtUpdatePass.EditValue = Data.Helper.GetUpdatePassword(encryptDES)
      txtUpdateFileException.EditValue = Data.Helper.GetUpdateFileException(encryptDES)
      txtUpdateFolderException.EditValue = Data.Helper.GetUpdateFolderException(encryptDES)

    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try
  End Sub
  Public Overrides Sub Btn1Click()
    'Dim en As New Utils.Cryptograph.Encryption.Hash(Utils.Cryptograph.Encryption.Hash.Provider.CRC32)
    'Dim key As New Utils.Cryptograph.Encryption.Data(Core.SSystem.UserInfo.GetUserKey)

    'InputBox("11", "", en.Calculate(New Utils.Cryptograph.Encryption.Data("11"), key).Hex.ToString)
    'InputBox("12", "", en.Calculate(New Utils.Cryptograph.Encryption.Data("12"), key).Hex.ToString)

    Try
      Dim encryptDES As New Utils.Cryptograph.DES() With {.Key = Data.Helper.GetKey}

      Dim b As New Data.Win.Configuration.SystemConfiguration.Setting() _
        With {.DatabaseServer = encryptDES.Encrypt(txtServer.Text),
              .DatabasePrefiks = encryptDES.Encrypt(txtPrefiks.Text),
              .SyncAuto = encryptDES.Encrypt(txtUpdateOtomatis.Checked.ToString),
              .SyncInterval = encryptDES.Encrypt(txtUpdateInterval.Text),
              .MultipleInstance = encryptDES.Encrypt(txtMultipleInstance.Checked.ToString),
              .UpdateServer = encryptDES.Encrypt(txtUpdateServer.Text),
              .UpdatePort = encryptDES.Encrypt(txtUpdatePort.Text),
              .UpdateUser = encryptDES.Encrypt(txtUpdateUser.Text),
              .UpdatePassword = encryptDES.Encrypt(txtUpdatePass.Text),
              .UpdateFileException = encryptDES.Encrypt(txtUpdateFileException.Text),
              .UpdateFolderException = encryptDES.Encrypt(txtUpdateFolderException.Text)
              }

      Data.Win.Configuration.SystemConfiguration.Save(b)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    Finally
      Me.DialogResult = Windows.Forms.DialogResult.OK
    End Try
  End Sub
End Class