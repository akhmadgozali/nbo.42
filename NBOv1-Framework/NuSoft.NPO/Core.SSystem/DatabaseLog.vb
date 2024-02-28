Namespace NuSoft.Core.SSystem
  Public Class DatabaseLog
    Shared Function Save(session As DevExpress.Xpo.Session, ByVal Kategori As NPO.DatabaseLog.Action, ByVal Aktivitas As String, TableName As String, RowId As String, UniqueData As String, UniqueId As String, Detail As List(Of NPO.DatabaseLogDetailChange)) As Boolean
      Dim item As New NPO.DatabaseLog(session)

      Try
        item.User = UserInfo.GetUserModified
        item.Tanggal = Data.Helper.GetTimeStamp(session)
        item.Jenis = Kategori
        item.Aktivitas = Aktivitas
        item.TableName = TableName
        item.RowId = RowId
        item.UniqueData = UniqueData
        item.UniqueId = UniqueId
        item.UserAgent = UserInfo.GetUserAgent
        item.UserHostAddress = UserInfo.GetUserHostAddress(session)
        item.UserHostName = UserInfo.GetUserHostName

        If Detail Is Nothing Then
          item.Save()
        Else
          Dim isSave As Boolean = False
          For Each change As NPO.DatabaseLogDetailChange In Detail
            Dim modInfo As New NPO.DatabaseLogDetail(session) With {.Main = item, .NamaProperty = change.PropertyName, .ValueLama = change.PrevValue, .ValueBaru = change.Value}
            modInfo.Save()
            isSave = True
          Next change

          If isSave Then
            item.Save()
          End If
        End If

        Return True
      Catch ex As Exception
        Throw New Exception(ex.Message, ex.InnerException)
        Return False
      End Try
    End Function
    Shared Function SaveSimpleLog(session As DevExpress.Xpo.Session, ByVal Kategori As NPO.DatabaseLog.Action, ByVal NamaAktivitas As String) As Boolean
      Dim item As New NPO.SimpleLog(session)

      Try
        item.User = UserInfo.GetUserModified
        item.Tanggal = Data.Helper.GetTimeStamp(session)
        item.Jenis = Kategori
        item.Aktivitas = Kategori.ToString & " Data : " & NamaAktivitas
        item.UserAgent = UserInfo.GetUserAgent
        item.UserHostAddress = UserInfo.GetUserHostAddress(session)
        item.UserHostName = UserInfo.GetUserHostName

        Return True
      Catch ex As Exception
        Throw New Exception(ex.Message, ex.InnerException)
        Return False
      End Try
    End Function
  End Class
End Namespace