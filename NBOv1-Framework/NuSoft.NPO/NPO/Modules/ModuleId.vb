Namespace NuSoft.NPO.Modules
	Public Enum ModuleId
		ModSys = &H51D48C1F
    Fina = &H26D3BC89
    AssetManagement = &HBFDAED33
    ProjectManagement = &HC8DDDDA5
    Inventory = &H56B94806
    Purchase = &H21BE7890
		Sales = &HB8B7292A
		TaxManagement = &HCFB019BC
    MasterData = &H5F0F042D
    Operasional = &H280834BB
    Production = &H280834BB
		SirkulasiKoran = &H179E078F
		IklanKoran = &H8E975635
	End Enum

	Friend Class Helper
		Shared Function GetModuleId(Id As ModuleId) As Integer
			Dim en As New Utils.Cryptograph.Encryption.Hash(Utils.Cryptograph.Encryption.Hash.Provider.CRC32)
			Dim key As New Utils.Cryptograph.Encryption.Data(Core.SSystem.UserInfo.GetUserKey)

			For i = 0 To 100
				If Convert.ToInt32(en.Calculate(New Utils.Cryptograph.Encryption.Data(i.ToString), key).Hex, 16) = Convert.ToInt32(Id) Then
					Return i
				End If
			Next

			Return Nothing
		End Function
	End Class
End Namespace