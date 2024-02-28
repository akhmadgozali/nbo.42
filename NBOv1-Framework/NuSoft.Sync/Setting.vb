Public Class Setting
  Shared Function GetTempDir() As String
    Return My.Computer.FileSystem.CurrentDirectory & "\upd\"
  End Function
  Shared Function GetTempDirReport() As String
    Return GetTempDir() & "Report\"
  End Function
  Shared Function GetTempDirModule() As String
    Return GetTempDir() & "Modules\"
  End Function
  'Shared Function GetUpdateFileName() As String
  '	Return GetTempDir() & "SyBiru.Update.bat"
  'End Function
  Shared Function GetSyncFileName() As String
    Return "NuSoft.Update.xml"
  End Function
  Shared Function GetSettingFile() As String
    Return My.Application.Info.DirectoryPath & "\NuSoft.Sync.xml"
  End Function
  Shared Function CreateTable() As DataTable
    Dim result As New DataTable("SyncXML")
    Dim colA As New DataColumn("FileName", GetType(String))
    Dim colB As New DataColumn("Active", GetType(Boolean))

    colA.Unique = True
    result.Columns.Add(colA)
    result.Columns.Add(colB)
    Return result
  End Function
End Class
