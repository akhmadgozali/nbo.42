Imports System.Management
Imports System
Imports System.Text
Imports System.Security.Cryptography

Namespace NuSoft.Utils
	Friend Class SysInfo
		Friend Shared Function GetProcessorId() As String
			Dim strProcessorId As String = String.Empty
			Dim query As New SelectQuery(My.Resources.SysInfoProcQueryName)
			Dim search As New ManagementObjectSearcher(query)
			Dim info As ManagementObject

      'MsgBox(search.Get.Count)
      For Each info In search.Get()
        'MsgBox(info.ToString)
        'For Each xx In info.Properties
        '  MsgBox(xx.Name & "=" & IIf(xx.Value Is Nothing, "", xx.Value).ToString)
        'Next
        strProcessorId = info(My.Resources.SysInfoProcPropName).ToString()
      Next
      'MsgBox(strProcessorId)
			Return strProcessorId
		End Function
		Friend Shared Function GetMotherBoardID() As String
			Dim strMotherBoardID As String = String.Empty
			Dim query As New SelectQuery(My.Resources.SysInfoMoboQueryName)
			Dim search As New ManagementObjectSearcher(query)
			Dim info As ManagementObject

			For Each info In search.Get()
				strMotherBoardID = info(My.Resources.SysInfoMoboPropName).ToString()
			Next
			Return strMotherBoardID
		End Function
		Friend Shared Function GetMACAddress() As String
			Dim mc As ManagementClass = New ManagementClass(My.Resources.SysInfoMACQueryName)
			Dim moc As ManagementObjectCollection = mc.GetInstances()
			Dim MACAddress As String = String.Empty
			For Each mo As ManagementObject In moc
				If (MACAddress.Equals(String.Empty)) Then
					If CBool(mo(My.Resources.SysInfoMACIPName)) Then MACAddress = mo(My.Resources.SysInfoMACPropName).ToString()
					mo.Dispose()
				End If
				MACAddress = MACAddress.Replace(":", String.Empty)
			Next
			Return MACAddress
		End Function
		Friend Shared Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String
			Dim disk As ManagementObject = New ManagementObject(String.Format(My.Resources.SysInfoHDDQueryName, strDriveLetter))
			disk.Get()
			Return disk(My.Resources.SysInfoHDDPropName).ToString()
		End Function
		Friend Shared Function getMD5Hash(ByVal strToHash As String) As String
			Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
			Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

			bytesToHash = md5Obj.ComputeHash(bytesToHash)

			Dim strResult As String = ""

			For Each b As Byte In bytesToHash
				strResult += b.ToString("x2")
			Next

			Return strResult
		End Function
	End Class
End Namespace
