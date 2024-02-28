Namespace NuSoft.Data
  Public Class DbClient
    Inherits DbParent

    Public Shared Function GetPureConnectionString(ByVal DbName As String) As String
      If DbName = "" Then
        Throw New Utils.Exception("Masukkan nama database.", 1, "Pilih database terlebih dahulu.", "GetPureConnectionString")
      End If

      Try
        cryptDes.Key = Helper.GetKey
        Return String.Format(formatString, Helper.GetServer(cryptDes), cryptDes.Decrypt(format1), cryptDes.Decrypt(format2), cryptDes.Decrypt(format3), DbName)
      Catch ex As Exception
        Throw New Utils.Exception(ex.Message, -99, "", "GetPureConnectionString")
        Return Nothing
      End Try
    End Function
    Public Shared Function GetPureConnection(ByVal DbName As String) As MySql.Data.MySqlClient.MySqlConnection
      Try
        Dim result As New MySql.Data.MySqlClient.MySqlConnection(GetPureConnectionString(DbName))
        result.Open()

        Return result
      Catch ex As Exception
        My.Computer.Clipboard.SetText(ex.Message)
        Throw New Utils.Exception("Ada masalah koneksi ke server", -99, "Periksa kondisi jaringan komputer", "GetPureConnection")
        Return Nothing
      End Try
    End Function
    Public Shared Function GetXPOConnectionString(ByVal DbName As String) As String
      Try
        Return String.Format("XPOProvider=MySql;{0}", GetPureConnectionString(DbName))
      Catch ex As Exception
        Throw New Utils.Exception(ex.Message, -99, "", "GetConnectionString")
        Return Nothing
      End Try
    End Function
    Public Shared Function GetXPOSession(ByVal DbName As String) As DevExpress.Xpo.UnitOfWork
      Try
        Dim result As New DevExpress.Xpo.UnitOfWork() With {.ConnectionString = GetXPOConnectionString(DbName), .AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists}
        result.Connect()
        Return result
      Catch ex As Exception
        My.Computer.Clipboard.SetText(ex.Message)
        Throw New Utils.Exception("Ada masalah koneksi ke server", -99, "Periksa kondisi jaringan komputer", "GetXPOSession")
        Return Nothing
      End Try
    End Function
  End Class
End Namespace