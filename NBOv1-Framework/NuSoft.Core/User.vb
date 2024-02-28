Namespace NuSoft.Core.SSystem
  Public Class User
    Shared Function GetPrivilegesMenu(ByVal kodeMenu As String, ByVal namaDatabase As String) As NPO.NonPersistent.MenuPrivileges
      Dim result As New NPO.NonPersistent.MenuPrivileges

      If UserInfo.GetUserLevel = 9 Then
        result.Buka = True
        result.Tambah = True
        result.Edit = True
        result.Hapus = True
        result.Eksport = True
        result.Cetak = True
      Else
        Dim resultMenu As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserMenu)(Data.DbSystem.GetXPOSession, DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("User.Id={0} and Menu.Kode='{1}' and Database.NamaDatabase='{2}'", UserInfo.GetUserId, kodeMenu, namaDatabase)))
        result.Buka = resultMenu(0).Buka
        result.Tambah = resultMenu(0).Tambah
        result.Edit = resultMenu(0).Edit
        result.Hapus = resultMenu(0).Hapus
        result.Eksport = resultMenu(0).Eksport
        result.Cetak = resultMenu(0).Cetak
      End If

      Return result
    End Function
    Shared Function GetPrivilegesMenu(ByVal idMenu As Integer, ByVal namaDatabase As String) As NPO.NonPersistent.MenuPrivileges
      Dim result As New NPO.NonPersistent.MenuPrivileges

      If UserInfo.GetUserLevel = 9 Then
        result.Buka = True
        result.Tambah = True
        result.Edit = True
        result.Hapus = True
        result.Eksport = True
        result.Cetak = True
      ElseIf UserInfo.GetUserLevel = 3 And idMenu >= 1 And idMenu <= 7 Then
        result.Buka = True
        result.Tambah = True
        result.Edit = True
        result.Hapus = True
        result.Eksport = True
        result.Cetak = True
      ElseIf UserInfo.GetUserLevel = 2 And idMenu >= 5 And idMenu <= 7 Then
        result.Buka = True
        result.Tambah = True
        result.Edit = True
        result.Hapus = True
        result.Eksport = True
        result.Cetak = True
      Else
        Dim resultMenu As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserMenu)(Data.DbSystem.GetXPOSession, DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("User.Id={0} and Menu.Id={1} and Database.NamaDatabase='{2}'", UserInfo.GetUserId, idMenu, namaDatabase)))
        If resultMenu.Count > 0 Then
          result.Buka = resultMenu(0).Buka
          result.Tambah = resultMenu(0).Tambah
          result.Edit = resultMenu(0).Edit
          result.Hapus = resultMenu(0).Hapus
          result.Eksport = resultMenu(0).Eksport
          result.Cetak = resultMenu(0).Cetak
        End If
      End If

      Return result
    End Function
    Shared Function GetPrivilegesReport(ByVal idReport As Integer, ByVal namaDatabase As String) As NPO.NonPersistent.ReportPrivileges
      Dim result As New NPO.NonPersistent.ReportPrivileges

      If UserInfo.GetUserLevel = 9 Then
        result.Buka = True
        result.Eksport = True
        result.Cetak = True
      Else
        Dim resultMenu As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserReport)(Data.DbSystem.GetXPOSession, DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("User.Id={0} and Report.Id={1} and Database.NamaDatabase='{2}'", UserInfo.GetUserId, idReport, namaDatabase)))
        result.Buka = resultMenu(0).Buka
        result.Eksport = resultMenu(0).Eksport
        result.Cetak = resultMenu(0).Cetak
      End If

      Return result
    End Function
  End Class
End Namespace