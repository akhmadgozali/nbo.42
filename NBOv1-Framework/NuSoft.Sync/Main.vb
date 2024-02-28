Public Class Main
  Shared Sub Main(ByVal args As String())
    DevExpress.Skins.SkinManager.EnableFormSkins()
    DevExpress.UserSkins.BonusSkins.Register()

    If args.GetUpperBound(0) >= 0 Then
      Select Case args(0)
        '===== register file to xml file
        '===== background update
        '===== foreground update
        '===== apply update [batch file]

        Case "-register" : Register()
        Case "-apply" : ApplyUpdate(args(1))
        Case "-background"
          Dim update As New HTTPUpdate
          update.StartProcess(False)
        Case ("-foreground") : System.Windows.Forms.Application.Run(New Frm_Proses)
        Case Else
      End Select
    Else
      System.Windows.Forms.Application.Run(New Frm_Setting)
    End If
  End Sub

  Shared Sub Register()
    Dim crc As New Utils.CRC32
    Dim tableData As New DataTable("SyncData")
    Dim colA As New DataColumn("ReportObj", GetType(Int16))
    Dim colB As New DataColumn("FileName", GetType(String))
    Dim colC As New DataColumn("CRCData", GetType(String))
    Dim newRow As DataRow
    Dim path As String
    Dim files As String()
    Dim f As System.IO.FileStream
    Dim di As System.IO.DirectoryInfo

    Try
      If My.Computer.FileSystem.FileExists(Setting.GetSyncFileName) Then
        My.Computer.FileSystem.DeleteFile(Setting.GetSyncFileName)
      End If
      tableData.Columns.Add(colA)
      tableData.Columns.Add(colB)
      tableData.Columns.Add(colC)

      '===== Non Report
      path = My.Application.Info.DirectoryPath
      files = System.IO.Directory.GetFiles(path)
      For i = files.GetLowerBound(0) To files.GetUpperBound(0)
        di = New System.IO.DirectoryInfo(files(i))
        f = New System.IO.FileStream(di.FullName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 8192)
        newRow = tableData.NewRow
        newRow("ReportObj") = 0
        newRow("FileName") = di.Name
        newRow("CRCData") = String.Format("{0:X8}", crc.GetCrc32(f))
        tableData.Rows.Add(newRow)
      Next

      '===== Report
      path = My.Application.Info.DirectoryPath & "\Report"
      files = System.IO.Directory.GetFiles(path)
      For i = files.GetLowerBound(0) To files.GetUpperBound(0)
        di = New System.IO.DirectoryInfo(files(i))
        f = New System.IO.FileStream(di.FullName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 8192)
        newRow = tableData.NewRow
        newRow("ReportObj") = 1
        newRow("FileName") = di.Name
        newRow("CRCData") = String.Format("{0:X8}", crc.GetCrc32(f))
        tableData.Rows.Add(newRow)
      Next

      '===== Module
      path = My.Application.Info.DirectoryPath & "\Modules"
      files = System.IO.Directory.GetFiles(path)
      For i = files.GetLowerBound(0) To files.GetUpperBound(0)
        di = New System.IO.DirectoryInfo(files(i))
        f = New System.IO.FileStream(di.FullName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 8192)
        newRow = tableData.NewRow
        newRow("ReportObj") = 2
        newRow("FileName") = di.Name
        newRow("CRCData") = String.Format("{0:X8}", crc.GetCrc32(f))
        tableData.Rows.Add(newRow)
      Next

      tableData.WriteXml(Setting.GetSyncFileName)
    Catch ex As Exception
      DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "SyBiru.Sync.Register", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Shared Sub ApplyUpdate(ByVal ExeName As String)
    Dim reportDirSource As String = Setting.GetTempDir & "\Report\"
    Dim reportDirDesti As String = My.Computer.FileSystem.CurrentDirectory & "\Report\"
    Dim moduleDirSource As String = Setting.GetTempDir & "\Modules\"
    Dim moduleDirDesti As String = My.Computer.FileSystem.CurrentDirectory & "\Modules\"
    Const batchFileName As String = "syupdate.bat"

    Dim a As Process() = System.Diagnostics.Process.GetProcessesByName(ExeName.Replace(".exe", ""))
    For Each p As Process In a
      p.Kill()
      While Not p.HasExited
        System.Windows.Forms.Application.DoEvents()
      End While
    Next

    '=== Dll & exe
    If My.Computer.FileSystem.DirectoryExists(Setting.GetTempDir) Then
      For Each filename In My.Computer.FileSystem.GetFiles(Setting.GetTempDir)
        If System.IO.Path.GetFileName(filename) = My.Application.Info.ProductName & ".exe" Then
          My.Computer.FileSystem.MoveFile(filename, String.Format("{0}\{1}.tmp", My.Computer.FileSystem.CurrentDirectory, System.IO.Path.GetFileName(filename)), True)
          Using srw As System.IO.StreamWriter = System.IO.File.CreateText(batchFileName)
            srw.WriteLine("taskkill /IM " & System.IO.Path.GetFileName(filename))
            srw.WriteLine("del " & System.IO.Path.GetFileName(filename))
            srw.WriteLine(String.Format("ren {0}.tmp {0}", System.IO.Path.GetFileName(filename)))
            srw.WriteLine("del " & batchFileName)
            srw.Close()
          End Using
        Else
          My.Computer.FileSystem.MoveFile(filename, String.Format("{0}\{1}", My.Computer.FileSystem.CurrentDirectory, System.IO.Path.GetFileName(filename)), True)
        End If
      Next
    End If

    '=== Report
    If My.Computer.FileSystem.DirectoryExists(reportDirSource) Then
      For Each filename In My.Computer.FileSystem.GetFiles(reportDirSource)
        My.Computer.FileSystem.MoveFile(filename, reportDirDesti & System.IO.Path.GetFileName(filename), True)
      Next
    End If

    '=== Module
    If My.Computer.FileSystem.DirectoryExists(moduleDirSource) Then
      For Each filename In My.Computer.FileSystem.GetFiles(moduleDirSource)
        My.Computer.FileSystem.MoveFile(filename, moduleDirDesti & System.IO.Path.GetFileName(filename), True)
      Next
    End If

    If My.Computer.FileSystem.DirectoryExists(Setting.GetTempDir) Then
      My.Computer.FileSystem.DeleteDirectory(Setting.GetTempDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End If


    If My.Computer.FileSystem.FileExists(batchFileName) Then
      Process.Start(batchFileName)
    End If
    Process.Start(ExeName)
  End Sub
End Class
