Namespace LogicLayer
	Public Class Config
    Inherits Core.Modules.SettingBase

		Property NamaPerusahaan As String
		Property NamaAlias As String
		Property BidangUsaha As String
		Property Slogan As String
		Property Alamat1 As String
		Property Alamat2 As String
		Property KodePos As String
		Property NoTelp As String
		Property NoFax As String

    Sub New(session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
		Public Overrides Function ModuleId() As NPO.Modules.ModuleId
			Return MainClass.GetModuleId
		End Function
	End Class
End Namespace