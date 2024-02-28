Public Class MainClass
  Shared Function GetForm(ByVal menuCode As String) As Core.Win.Forms.NuSoftForm
    Select Case menuCode
      Case "1" : Return New UI_DatabaseList
      Case "2" : Return New UI_ModulesList
      Case "3" : Return New UI_MenusList
      Case "4" : Return New UI_ReportsList
      Case "5" : Return New UIX_UserManager
      Case "6" : Return New UIX_UserLogSimple
      Case "7" : Return New UIX_SystemLog
      Case "99" : Return New UIX_Dashboard
      Case Else : Return Nothing
    End Select
  End Function
End Class
