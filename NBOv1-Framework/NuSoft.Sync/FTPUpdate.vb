Public Class FTPUpdate
  Public Event Preparing(ByVal progress As String)
  Public Event StartDownload(ByVal JmlFile As Integer)
  Public Event Progress(ByVal progress As String, ByVal Prosentase As Integer)
  Public Event Selesai()

  Private ftpClient As Utils.FTPSocket.FTPClient
  Private ReadOnly syncPath As String = "/"
  Private ReadOnly syncFile As String = Setting.GetSyncFileName
  Private ReadOnly Filesync As String = Setting.GetTempDir & Setting.GetSyncFileName
  Private ReadOnly syncReport As String = "/Report/"
  Private ReadOnly syncModule As String = "/Modules/"

  Sub New()
    Dim sec As New Utils.Cryptograph.DES

    sec.Key = My.Resources.FTPScramble
    ftpClient = New Utils.FTPSocket.FTPClient(My.Resources.FTPServer, My.Resources.FTPUserName, sec.Decrypt(My.Resources.FTPPassword), CInt(My.Resources.FTPPort))
  End Sub

  Sub StartProcess(ByVal ShowUI As Boolean)
    Dim result As Boolean = True

    '==== Cek Koneksi || Download file sync
    If Not CekNetworkAndDownloadSyncFile(ShowUI) Then
      RaiseEvent Selesai()
      Exit Sub
    End If

    '==== Proses file hasil download
    RaiseEvent Preparing("Proses sinkronisasi ...")
    System.Windows.Forms.Application.DoEvents()

    Dim tableSetting As DataTable = Setting.CreateTable
    Dim tableData As DataTable = CreateTableData()
    Dim crc As New Utils.CRC32
    Dim f As System.IO.FileStream
    Dim tempData, tempFile As String
    Dim countDownload As Integer = 0
    Dim drs As DataRow()

    Try
      tableData.ReadXml(Filesync)
      If My.Computer.FileSystem.FileExists(Setting.GetSettingFile) Then
        tableSetting.ReadXml(Setting.GetSettingFile)
      End If

      For i = 0 To tableData.Rows.Count - 1
        If CInt(tableData.Rows(i)("ReportObj")) = 1 Then
          tempFile = String.Format("{0}\Report\{1}", My.Application.Info.DirectoryPath, tableData.Rows(i)("FileName"))
          If My.Computer.FileSystem.FileExists(Setting.GetSettingFile) Then
            drs = tableSetting.Select(String.Format("FileName='{0}'", tableData.Rows(i)("FileName")))
            If drs.GetUpperBound(0) >= 0 Then
              If Not CBool(drs(0)("Active")) Then
                tableData.Rows(i)("isDownload") = False
                GoTo Lanjut
              End If
            End If
          End If
        ElseIf CInt(tableData.Rows(i)("ReportObj")) = 2 Then
          tempFile = String.Format("{0}\Modules\{1}", My.Application.Info.DirectoryPath, tableData.Rows(i)("FileName"))
        Else
          tempFile = String.Format("{0}\{1}", My.Application.Info.DirectoryPath, tableData.Rows(i)("FileName"))
        End If

        If My.Computer.FileSystem.FileExists(tempFile) Then
          f = New System.IO.FileStream(tempFile, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 8192)
          tempData = String.Format("{0:X8}", crc.GetCrc32(f))
          tableData.Rows(i)("isDownload") = (tableData.Rows(i)("CRCData").ToString <> tempData)
        Else
          tableData.Rows(i)("isDownload") = True
        End If
        If CBool(tableData.Rows(i)("isDownload")) Then
          countDownload += 1
        End If
Lanjut:
      Next
    Catch ex As Exception
      If ShowUI Then
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
      RaiseEvent Selesai()
      Exit Sub
    End Try

    '==== Start download
    RaiseEvent StartDownload(countDownload)
    System.Windows.Forms.Application.DoEvents()

    If Not My.Computer.FileSystem.DirectoryExists(Setting.GetTempDirReport) Then
      My.Computer.FileSystem.CreateDirectory(Setting.GetTempDirReport)
    End If
    If Not My.Computer.FileSystem.DirectoryExists(Setting.GetTempDirModule) Then
      My.Computer.FileSystem.CreateDirectory(Setting.GetTempDirModule)
    End If

    Try
      countDownload = 0
      For i = 0 To tableData.Rows.Count - 1
        If CBool(tableData.Rows(i)("isDownload")) Then
          RaiseEvent Progress(String.Format("Download file {0} ...", tableData.Rows(i)("FileName")), countDownload)
          countDownload += 1
          System.Windows.Forms.Application.DoEvents()

          If CInt(tableData.Rows(i)("ReportObj")) = 1 Then
            Try
              Dim downFile As String = String.Format("{0}{1}", Setting.GetTempDirReport, tableData.Rows(i)("FileName"))
              'My.Computer.Network.DownloadFile(syncReport & tableData.Rows(i)("FileName").ToString, downFile)
              ftpClient.DownloadFile(syncReport & tableData.Rows(i)("FileName").ToString, downFile)
            Catch ex As Exception
              If ShowUI Then
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
              End If
              RaiseEvent Selesai()
              Exit Sub
            End Try
          ElseIf CInt(tableData.Rows(i)("ReportObj")) = 2 Then
            Try
              Dim downFile As String = String.Format("{0}{1}", Setting.GetTempDirModule, tableData.Rows(i)("FileName"))
              ftpClient.DownloadFile(syncModule & tableData.Rows(i)("FileName").ToString, downFile)
            Catch ex As Exception
              If ShowUI Then
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
              End If
              RaiseEvent Selesai()
              Exit Sub
            End Try
          Else
            Try
              Dim downFile As String = Setting.GetTempDir & tableData.Rows(i)("FileName").ToString
              'My.Computer.Network.DownloadFile(syncPath & tableData.Rows(i)("FileName").ToString, downFile)
              ftpClient.DownloadFile(syncPath & tableData.Rows(i)("FileName").ToString, downFile)
            Catch ex As Exception
              If ShowUI Then
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
              End If
              RaiseEvent Selesai()
              Exit Sub
            End Try
          End If
        End If
      Next
      If My.Computer.FileSystem.FileExists(Filesync) Then
        My.Computer.FileSystem.DeleteFile(Filesync)
      End If
      ftpClient.CloseConnection()

      RaiseEvent Progress("Selesai ...", countDownload)
      System.Windows.Forms.Application.DoEvents()
      RaiseEvent Selesai()
      System.Windows.Forms.Application.DoEvents()
    Catch ex As Exception
      If ShowUI Then
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
      RaiseEvent Selesai()
    End Try
  End Sub
  Private Function CekNetworkAndDownloadSyncFile(ShowUI As Boolean) As Boolean
    RaiseEvent Preparing("Cek koneksi ke server ...")
    System.Windows.Forms.Application.DoEvents()

    If Not My.Computer.Network.IsAvailable Then
      If ShowUI Then
        Utils.Win.MessageBox.Show("Tidak ada koneksi jaringan.", My.Resources.Title, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      End If
      Return False
    End If

    If Not My.Computer.Network.Ping(My.Resources.FTPServer, 1000) Then
      If ShowUI Then
        Utils.Win.MessageBox.Show("Koneksi ke server gagal.", My.Resources.Title, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      End If
      Return False
    End If

    If Not My.Computer.FileSystem.DirectoryExists(Setting.GetTempDir) Then
      My.Computer.FileSystem.CreateDirectory(Setting.GetTempDir)
    End If

    RaiseEvent Preparing("Download sinkronisasi file ...")
    System.Windows.Forms.Application.DoEvents()
    Try
      ftpClient.DownloadFile(syncPath & syncFile, Filesync)
    Catch ex As Exception
      If ShowUI Then
        Utils.Win.MessageBox.Show(ex.Message, My.Resources.Title, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      End If
      Return False
    End Try

    Return True
  End Function
  Private Function CreateTableData() As DataTable
    Dim tableData As New DataTable("SyncData")
    Dim colA As New DataColumn("ReportObj", GetType(Int16))
    Dim colB As New DataColumn("FileName", GetType(String))
    Dim colC As New DataColumn("CRCData", GetType(String))
    Dim colD As New DataColumn("IsDownload", GetType(Boolean))

    tableData.Columns.Add(colA)
    tableData.Columns.Add(colB)
    tableData.Columns.Add(colC)
    tableData.Columns.Add(colD)

    Return tableData
  End Function
End Class
