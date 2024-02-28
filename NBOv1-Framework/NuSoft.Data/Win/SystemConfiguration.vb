Imports System.Configuration

Namespace NuSoft.Data.Win.Configuration
  Public MustInherit Class SystemConfiguration
    Structure Setting
      Public DatabaseServer As String
      Public DatabasePrefiks As String
      Public SyncAuto As String
      Public SyncInterval As String
      Public MultipleInstance As String

      Public UpdateServer As String
      Public UpdatePort As String
      Public UpdateUser As String
      Public UpdatePassword As String
      Public UpdateFileException As String
      Public UpdateFolderException As String
    End Structure

    Const section As String = "SyBiruConfig"
    Shared Function Save(ByVal data As SystemConfiguration.Setting) As Boolean
      Dim config As Global.System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

      Try
        config.AppSettings.Settings.Clear()
        config.AppSettings.Settings.Add("S", data.DatabaseServer)
        config.AppSettings.Settings.Add("P", data.DatabasePrefiks)
        config.AppSettings.Settings.Add("A", data.SyncAuto)
        config.AppSettings.Settings.Add("I", data.SyncInterval)
        config.AppSettings.Settings.Add("M", data.MultipleInstance)

        config.AppSettings.Settings.Add("X1", data.UpdateServer)
        config.AppSettings.Settings.Add("X2", data.UpdatePort)
        config.AppSettings.Settings.Add("X3", data.UpdateUser)
        config.AppSettings.Settings.Add("X4", data.UpdatePassword)
        config.AppSettings.Settings.Add("X5", data.UpdateFileException)
        config.AppSettings.Settings.Add("X6", data.UpdateFolderException)

        config.Save()
        ConfigurationManager.RefreshSection("appSettings")
        Return True
      Catch ex As Exception
        Throw New Utils.Exception(ex.Message, -99, "", "Save UserConfig")
        Return False
      End Try
    End Function
  End Class
End Namespace