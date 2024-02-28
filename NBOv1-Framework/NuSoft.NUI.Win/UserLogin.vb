Public Class UserLogin
  Shared Function ValidateUser(ByVal userId As String, ByVal userPwd As String, Optional request As Object = Nothing) As Boolean
    Dim sesi As DevExpress.Xpo.Session = Data.DbSystem.GetXPOSession

    Using encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}
      If encryptDES.Encrypt(userId.ToLower) = SystemResource() Then
        Return CheckLogin(sesi, encryptDES, userPwd, request)
      Else
        Return CheckLogin(sesi, encryptDES, userId, userPwd, request)
      End If
    End Using
  End Function
  Shared Function ChangePassword(ByVal oldPassword As String, ByVal newPassword As String) As Boolean
    'Const sql1 As String = "update keypages set unique_form=md5(@password)"
    'Const sql2 As String = "update userslist set d_password=md5(@password) whete u_code=@u_code"
    Const cWrongPassMes As String = "Password lama salah"
    Const cWrongPassSol As String = "Masukkan password lama yang benar." & vbCrLf & "Periksa tombol CAPS LOCK menyala atau tidak"
    Const cWrongTitle As String = "Ganti Password"
		Dim sesi = Data.DbSystem.GetXPOSession
		Dim encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}

		Try
			If encryptDES.Encrypt(Core.SSystem.UserInfo.GetUserCode.ToLower) = SystemResource() Then
				'==== Check Old Password
				Dim objKey As NPO.SSystem.Key = GetKeyPages(sesi)
				If objKey.Unique <> Data.Helper.GetSHA2(sesi, encryptDES.Encrypt(oldPassword)).ToString Then
					Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Error, "Change password failed : Wrong old password")
					Throw New Utils.Exception(cWrongPassMes, -1, cWrongPassSol, cWrongTitle)
					Return False
				End If
				'MsgBox("OK")
				'==== Set New Password
				objKey.Unique = Data.Helper.GetSHA2(sesi, encryptDES.Encrypt(newPassword)).ToString
				objKey.Save()
			Else
				'==== Check Old Password
				Dim dataUser As NPO.SSystem.User = sesi.GetObjectByKey(Of NPO.SSystem.User)(Core.SSystem.UserInfo.GetUserId)
				'If sesi.ExecuteQuery("select d_password from userslist where u_code=@u_code", New String() {"@u_code"}, New String() {Core.SSystem.UserInfo.GetUserCode}).ResultSet(0).Rows(0).Values(0).ToString <> GetMD5Password(sesi, oldPassword).ToString Then
				If dataUser.Password <> Data.Helper.GetSHA2(sesi, encryptDES.Encrypt(oldPassword)).ToString Then
					Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Error, "Change password failed : Wrong old password")
					Throw New Utils.Exception(cWrongPassMes, -1, cWrongPassSol, cWrongTitle)
					Return False
				End If
				'==== Set New Password
				dataUser.Password = Data.Helper.GetSHA2(sesi, encryptDES.Encrypt(newPassword)).ToString
				dataUser.Save()
			End If
			sesi.CommitChanges()
			Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Info, "Change Password")

			'==== Set New Password
			'If Core.SSystem.UserInfo.GetUserLevel = 9 Then
			'  sesi.ExecuteNonQuery(sql1, New String() {"@password"}, New String() {newPassword})
			'Else
			'  sesi.ExecuteNonQuery(sql2, New String() {"@password", "@u_code"}, New String() {newPassword, Core.SSystem.UserInfo.GetUserCode})
			'End If

			Return True
		Catch ex As Exception
			Throw New Utils.Exception(ex.Message, -99, "", "ChangePassword")
		Finally
			sesi.Connection.Close()
    End Try
  End Function

  Private Shared Function CheckLogin(ByVal sesi As DevExpress.Xpo.Session, ByVal encryptDES As Utils.Cryptograph.DES, ByVal Pass As String, Optional request As Object = Nothing) As Boolean
    Dim objKey As NPO.SSystem.Key = GetKeyPages(sesi)
    If objKey Is Nothing Then
      Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Error, "Login failed : System password blank", "System", request)
      Throw New Utils.Exception("Cannot generate password", -1, "", "Validate User")
      Return False
    Else
      If objKey.Unique <> Data.Helper.GetSHA2(sesi, encryptDES.Encrypt(Pass)).ToString Then
        Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Error, "Login failed : Wrong system password", "System", request)
        Throw New Utils.Exception("Password anda salah", -2, "Masukkan password dengan benar", "Validate User")
        Return False
      Else
        Dim user As New Core.SSystem.UserInfo(-1, SystemResourceCode1, SystemResourceCode2, 9, False, Nothing, False, Nothing, 0, String.Empty, Nothing)
        Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Info, "Login success", "System", request)

        Return True
      End If
    End If
  End Function
  Private Shared Function CheckLogin(ByVal sesi As DevExpress.Xpo.Session, ByVal encryptDES As Utils.Cryptograph.DES, ByVal Id As String, ByVal Pass As String, Optional request As Object = Nothing) As Boolean
    Dim dataUser As NPO.SSystem.User = sesi.FindObject(Of NPO.SSystem.User)(DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("Kode='{0}'", Id)))

    If dataUser Is Nothing Then
      Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Error, "Login failed : User not exist", Id, request)
      Throw New Utils.Exception("User Id tidak ditemukan ", -1, "Masukkan user id dengan benar", "Validate User")
      Return False
    ElseIf Data.Helper.GetSHA2(sesi, encryptDES.Encrypt(Pass)).ToString <> dataUser.Password Then
      Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Error, "Login failed : Wrong password", Id, request)
      Throw New Utils.Exception("Password yang anda masukkan salah", -2, "Masukkan password dengan benar", "Validate User")
      Return False
    ElseIf Not dataUser.Aktif Then
      Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Error, "Login failed : User not active", Id, request)
      Throw New Utils.Exception("User anda sudah tidak aktif", -1, "Hubungi administrator untuk mengaktifkan user", "Validate User")
      Return False
    Else
      Dim reg As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserRegional)(sesi, DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("User.Id={0} and Buka=True", dataUser.Id)))
      Dim div As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserDivision)(sesi, DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("User.Id={0} and Buka=True", dataUser.Id)))
      Dim user As New Core.SSystem.UserInfo(dataUser.Id, encryptDES.Encrypt(Id), encryptDES.Encrypt(dataUser.Nama), dataUser.Level, dataUser.LimitRegional, reg, dataUser.LimitDivisi, div, dataUser.DashboardId, dataUser.DashboardModul, dataUser.HomeMenu)
      Core.SSystem.SystemLog.Save(sesi, NPO.SSystem.SystemLog.Action.Info, "Login success", Id, request)

      Return True
    End If
  End Function
  Private Shared Function GetKeyPages(ByVal sesi As DevExpress.Xpo.Session) As NPO.SSystem.Key
    Using xpCol As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.Key)(sesi)
      If xpCol.Count > 0 Then
        Return xpCol(0)
      Else
        Return Nothing
      End If
    End Using
  End Function

  Shared Function SystemResource() As String
    Return My.Resources.SystemResource
  End Function
  Shared Function SystemResourceCode1() As String
    Return My.Resources.SystemResourceCode1
  End Function
  Shared Function SystemResourceCode2() As String
    Return My.Resources.SystemResourceCode2
  End Function
End Class