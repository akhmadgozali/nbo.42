Namespace NuSoft.Core.SSystem
  Public Class SystemLog
    Shared Function Save(session As DevExpress.Xpo.Session, ByVal Kategori As NPO.SSystem.SystemLog.Action, ByVal Aktivitas As String, Optional User As String = "", Optional request As Object = Nothing) As Boolean
      If session Is Nothing Then
        session = Data.DbSystem.GetXPOSession
      End If
      Dim item As New NPO.SSystem.SystemLog(session)

      Try
        If User = "" Then
          item.User = UserInfo.GetUserModified
        Else
          item.User = User
        End If
        item.Tanggal = Data.Helper.GetTimeStamp(session)
        item.Jenis = Kategori
        item.Aktivitas = Aktivitas
        item.UserAgent = UserInfo.GetUserAgent(CType(request, System.Web.HttpRequest))
        item.UserHostAddress = UserInfo.GetUserHostAddress(session, CType(request, System.Web.HttpRequest))
        item.UserHostName = UserInfo.GetUserHostName(CType(request, System.Web.HttpRequest))
        item.Save()
        Return True
      Catch ex As Exception
        'Throw New Utils.Exception(ex.Message & vbCrLf & Global.System.Web.HttpContext.Current.User.Identity.Name)
        Return False
      End Try
    End Function
  End Class
End Namespace