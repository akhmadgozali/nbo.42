Public Class MainClass
  Shared Function GetSmallImage() As Drawing.Image
    Return My.Resources.gear_16
  End Function
  Shared Function GetLargeImage() As Drawing.Image
    Return My.Resources.gear_32
  End Function
	Shared Function GetModuleId() As NPO.Modules.ModuleId
		Return NPO.Modules.ModuleId.ModSys
	End Function

	Shared Function GetForm(ByVal menuCode As String) As Core.Win.Forms.NuSoftForm
		Select Case GetMenu(menuCode)
			Case menuName.SettingPerusahaan : Return New UI_CompanyProfile
			Case menuName.Divisi : Return New UI_Divisi
			Case menuName.Regional : Return New UI_Regional
			Case Else : Return Nothing
		End Select
	End Function

  Private Enum menuName
		Regional
		Divisi
		SettingPerusahaan
	End Enum
  Private Shared Function GetMenu(ByVal menuCode As String) As menuName
    Select Case menuCode
			Case "0001" : Return menuName.Regional
			Case "0002" : Return menuName.Divisi
			Case "0003" : Return menuName.SettingPerusahaan
      Case Else : Return Nothing
    End Select
  End Function
End Class