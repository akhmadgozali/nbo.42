Namespace NuSoft.Utils
	Public Class Serial
		Shared Function IsRegister() As Boolean
			If Not My.Computer.FileSystem.FileExists(GetKey) Then
				Return False
			End If

			Return GetPublicKey.Equals(GetPrivateKey)
		End Function
		Shared Function GetSerialCode() As String
			Dim h As New NuSoft.Utils.Cryptograph.Encryption.Hash(Cryptograph.Encryption.Hash.Provider.SHA512)
			Dim d As New NuSoft.Utils.Cryptograph.Encryption.Data(SysInfo.getMD5Hash(SysInfo.GetProcessorId))

			h.Calculate(d)
			Return h.Value.ToHex
		End Function
		Private Shared Function GetKey() As String
			Return My.Application.Info.DirectoryPath & "/" & GetSerialCode()
		End Function
		Private Shared Function GetPrivateKey() As String
			Dim h As New NuSoft.Utils.Cryptograph.Encryption.Hash(Cryptograph.Encryption.Hash.Provider.SHA512)
			Dim d As New NuSoft.Utils.Cryptograph.Encryption.Data(GetSerialCode)
			h.Calculate(d)
			Return h.Value.ToHex
		End Function
		Private Shared Function GetPublicKey() As String
			Dim a As New System.IO.StreamReader(GetKey)
			Return a.ReadToEnd
		End Function
	End Class
End Namespace