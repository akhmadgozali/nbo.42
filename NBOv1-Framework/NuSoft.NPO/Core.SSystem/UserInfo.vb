Imports System.Text.RegularExpressions

Namespace NuSoft.Core.SSystem
  Public Class UserInfo
    Private Shared _Id As Integer
    Private Shared _UserCode As String
    Private Shared _UserName As String
    Private Shared _UserLevel As Integer
    Private Shared _UserLimitRegional As Boolean
    Private Shared _UserLimitDivisi As Boolean
    Private Shared _UserRegional As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserRegional)
    Private Shared _UserDivisi As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserDivision)
    Private Shared _UserGuid As Guid
    Private Shared _DashboardId As Integer
    Private Shared _DashboardModul As String
    Private Shared _HomeMenu As NPO.SSystem.Menu

    Shared Function GetUserId() As Integer
      If Data.Helper.IsWeb Then
        Return CInt(ConvertAuthName(0))
      Else
        Return _Id
      End If
    End Function
    Shared Function GetUserCode() As String
      If Data.Helper.IsWeb Then
        Using encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}
          Return encryptDES.Decrypt(ConvertAuthName(1))
        End Using
      Else
        Using encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}
          Return encryptDES.Decrypt(_UserCode)
        End Using
      End If
    End Function
    Shared Function GetUserName() As String
      If Data.Helper.IsWeb Then
        Using encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}
          Return encryptDES.Decrypt(ConvertAuthName(2))
        End Using
      Else
        Using encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}
          Return encryptDES.Decrypt(_UserName)
        End Using
      End If
    End Function
    Shared Function GetUserLevel() As Integer
      If Data.Helper.IsWeb Then
        Return CInt(ConvertAuthName(3))
      Else
        Return _UserLevel
      End If
    End Function
    Shared Function GetUserGUID() As Guid
      If Data.Helper.IsWeb Then
        Return Guid.Parse(ConvertAuthName(4))
      Else
        Return _UserGuid
      End If
    End Function
    Shared Function GetUserAgent(Optional request As System.Web.HttpRequest = Nothing) As String
      If Data.Helper.IsWeb Then
        If IsWebAuthLogin() Then
          Return ConvertAuthName(5)
        Else
          Return request.UserAgent
        End If
      Else
        Return String.Format("{0}|{1}|{2}", My.Computer.Info.OSFullName, My.Computer.Info.OSVersion, My.Application.Info.Version.ToString)
      End If
    End Function
    Shared Function GetUserHostAddress(sesi As DevExpress.Xpo.Session, Optional request As System.Web.HttpRequest = Nothing) As String
      If Data.Helper.IsWeb Then
        If IsWebAuthLogin() Then
          Return ConvertAuthName(6)
        Else
          Return request.UserHostAddress
        End If
      Else
        Return sesi.ExecuteScalar("select SUBSTRING_INDEX(USER(), '@', -1)").ToString
      End If
    End Function
    Shared Function GetUserHostName(Optional request As System.Web.HttpRequest = Nothing) As String
      If Data.Helper.IsWeb Then
        If IsWebAuthLogin() Then
          Return ConvertAuthName(7)
        Else
          Return request.UserHostName
        End If
      Else
        Return My.Computer.Name
      End If
    End Function
    Shared Function GetUserModified() As String
      If Data.Helper.IsWeb Then
        Using encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}
          Return String.Format("{0} - {1}", encryptDES.Decrypt(ConvertAuthName(1)), encryptDES.Decrypt(ConvertAuthName(2)))
        End Using
      Else
        Using encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}
          Return String.Format("{0} - {1}", encryptDES.Decrypt(_UserCode), encryptDES.Decrypt(_UserName))
        End Using
      End If
    End Function
    Shared Function GetUserKey() As String
      Return My.Resources.VariableUserKey
    End Function

    Shared Function GetUserDivision() As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserDivision)
      If _UserLimitDivisi Then
        Return _UserDivisi
      Else
        Return Nothing
      End If
    End Function
    Shared Function GetUserRegional(session As DevExpress.Xpo.Session, NamaDatabase As String) As DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Regional)
      If _UserLimitRegional Then
        Dim filter = _UserRegional.Where(Function(m) m.Database.NamaDatabase = NamaDatabase).Select(Function(m) m.Regional)
        Return New DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Regional)(session, New DevExpress.Data.Filtering.InOperator("Id", filter))
      Else
        Return New DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Regional)(session)
      End If
    End Function
    Shared Function GetDefaultRegionalId() As UInt16
      If _UserRegional Is Nothing OrElse _UserRegional.Count < 1 Then
        Return Nothing
      End If
      If _UserRegional.ToList.Exists(Function(m) m.IsDefault = True) Then
        Return _UserRegional.Single(Function(m) m.IsDefault = True).Regional
      Else
        Return _UserRegional(0).Regional
      End If
    End Function
		Shared Function GetDefaultRegional(session As DevExpress.Xpo.Session) As NPO.Modules.ModSys.Regional
			If GetDefaultRegionalId() = Nothing Then
				Dim xp As New DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Regional)(session)
				If xp.Count > 0 Then
					Return xp(0)
				Else
					Return Nothing
				End If
			Else
				Return session.GetObjectByKey(Of NPO.Modules.ModSys.Regional)(GetDefaultRegionalId)
			End If
		End Function

    Shared Function GetDashboardId() As Integer
      If Data.Helper.IsWeb Then
        Return 0 'CInt(ConvertAuthName(3))
      Else
        Return _DashboardId
      End If
    End Function
    Shared Function GetDashboardModul() As String
      If Data.Helper.IsWeb Then
        Return String.Empty 'CInt(ConvertAuthName(3))
      Else
        Return _DashboardModul
      End If
    End Function
    Shared Function GetHomeMenu() As NPO.SSystem.Menu
      Return _HomeMenu
    End Function

    Private Shared Function ConvertAuthName(position As Short) As String
      Dim str As String() = Regex.Split(Global.System.Web.HttpContext.Current.User.Identity.Name, "~\|~") 'authName.Split(New Char() {"~"c, "|"c, "~"c})
      Return str(position)
    End Function
    Private Shared Function IsWebAuthLogin() As Boolean
      Return System.Web.HttpContext.Current.User.Identity.Name <> ""
    End Function
    Sub New(ByVal Id As Integer, ByVal UserCode As String, ByVal UserName As String, ByVal UserLevel As Integer, ByVal UserLimitRegional As Boolean, ByVal UserRegional As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserRegional), ByVal UserLimitDivisi As Boolean, ByVal UserDivisi As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserDivision), DashboardId As Integer, DashboardModul As String, HomeMenu As NPO.SSystem.Menu)
      _Id = Id
      _UserCode = UserCode
      _UserName = UserName
      _UserLevel = UserLevel
      _UserLimitRegional = UserLimitRegional
      _UserRegional = UserRegional
      _UserGuid = Guid.NewGuid
      _UserLimitDivisi = UserLimitDivisi
      _UserDivisi = UserDivisi
      _DashboardId = DashboardId
      _DashboardModul = DashboardModul
      _HomeMenu = HomeMenu
    End Sub
  End Class
End Namespace