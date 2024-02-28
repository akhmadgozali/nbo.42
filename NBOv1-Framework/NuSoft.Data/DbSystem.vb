Namespace NuSoft.Data
  Public Class DbSystem
    Inherits DbParent

    Private Const xformat As String = "gpTf1BVSIaI="

    Public Shared Function GetMySqlConnectionString() As String
      Try
        cryptDes.Key = Helper.GetKey
        Dim f As String = My.Application.Info.DirectoryPath & "\" & cryptDes.Decrypt(format6)
        'If Not My.Computer.FileSystem.FileExists(f) Then
        '  Utils.Common.Resources.SaveFile(f, My.Resources.ssl)
        'End If
        Return String.Format(formatString, Helper.GetServer(cryptDes), cryptDes.Decrypt(format1), cryptDes.Decrypt(format2), cryptDes.Decrypt(format3), Helper.GetPrefiks(cryptDes) & cryptDes.Decrypt(format5))
      Catch ex As Exception
        Throw New Utils.Exception(ex.Message, -99, "", "GetConnectionString")
        Return Nothing
      End Try
    End Function
    Public Shared Function GetMySqlConnection() As MySql.Data.MySqlClient.MySqlConnection
      Try
        Dim result As New MySql.Data.MySqlClient.MySqlConnection(GetMySqlConnectionString)
        result.Open()

        Return result
      Catch ex As Exception
        My.Computer.Clipboard.SetText(ex.Message)
        Throw New Utils.Exception("Ada masalah koneksi ke server", -99, "Periksa kondisi jaringan komputer", "GetMySqlConnection")
        Return Nothing
      End Try
    End Function
    Public Shared Function GetMySqlCommand() As MySql.Data.MySqlClient.MySqlCommand
      Dim result As New MySql.Data.MySqlClient.MySqlCommand() With {.Connection = GetMySqlConnection()}
      Return result
    End Function

    Public Shared Function GetXPOConnectionString() As String
      Return String.Format("XpoProvider=MySql;{0}", GetMySqlConnectionString)
    End Function
    Public Shared Function GetXPOSession() As DevExpress.Xpo.UnitOfWork
      Try
        Dim result As New DevExpress.Xpo.UnitOfWork() With {.ConnectionString = GetXPOConnectionString(), .AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists}
        result.Connect()
        Return result
      Catch ex As Exception
        My.Computer.Clipboard.SetText(ex.Message)
        Throw New Utils.Exception(ex.Message, -99, "", "GetConnectionString")
        'Throw New Utils.Exception("Ada masalah koneksi ke server", -99, "Periksa kondisi jaringan komputer", "GetXPOSession")
        Return Nothing
      End Try
    End Function
  End Class
End Namespace