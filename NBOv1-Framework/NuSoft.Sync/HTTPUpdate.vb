Public Class HTTPUpdate
  Public Event Preparing(ByVal progress As String)
  Public Event StartDownload(ByVal JmlFile As Integer)
  Public Event Progress(ByVal progress As String, ByVal Prosentase As Integer)
  Public Event Selesai()

  Private Const server As String = "119.47.89.4"
  Private ReadOnly syncPath As String = "http://" & server & "/sybirupdate/"
  Private ReadOnly syncReport As String = "http://" & server & "/sybirupdate/report/"
  Private ReadOnly syncFile As String = syncPath & Setting.GetSyncFileName
  Private ReadOnly Filesync As String = Setting.GetTempDir & Setting.GetSyncFileName
  Private Const title As String = "SyBiru.Sync.Check"

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
        If CBool(tableData.Rows(i)("ReportObj")) Then
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
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
      RaiseEvent Selesai()
      Exit Sub
    End Try

    '==== Start download
    RaiseEvent StartDownload(countDownload)
    System.Windows.Forms.Application.DoEvents()

    Try
      countDownload = 0
      For i = 0 To tableData.Rows.Count - 1
        If CBool(tableData.Rows(i)("isDownload")) Then
          RaiseEvent Progress(String.Format("Download file {0} ...", tableData.Rows(i)("FileName")), countDownload)
          countDownload += 1
          System.Windows.Forms.Application.DoEvents()

          If CBool(tableData.Rows(i)("ReportObj")) Then
            Try
              Dim downFile As String = String.Format("{0}Report\{1}", Setting.GetTempDir, tableData.Rows(i)("FileName"))
              My.Computer.Network.DownloadFile(syncReport & tableData.Rows(i)("FileName").ToString, downFile)
            Catch ex As Exception
              If ShowUI Then
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
              End If
              RaiseEvent Selesai()
              Exit Sub
            End Try
          Else
            Try
              Dim downFile As String = Setting.GetTempDir & tableData.Rows(i)("FileName").ToString
              My.Computer.Network.DownloadFile(syncPath & tableData.Rows(i)("FileName").ToString, downFile)
            Catch ex As Exception
              If ShowUI Then
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
      RaiseEvent Progress("Selesai ...", countDownload)
      System.Windows.Forms.Application.DoEvents()
      RaiseEvent Selesai()
      System.Windows.Forms.Application.DoEvents()
    Catch ex As Exception
      If ShowUI Then
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
      RaiseEvent Selesai()
    End Try
  End Sub

  Private Function CekNetworkAndDownloadSyncFile(ShowUI As Boolean) As Boolean
    RaiseEvent Preparing("Cek koneksi ke server ...")
    System.Windows.Forms.Application.DoEvents()

    If Not My.Computer.Network.IsAvailable Then
      If ShowUI Then
        DevExpress.XtraEditors.XtraMessageBox.Show("Tidak ada koneksi jaringan.", title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
      Return False
    End If

    If Not My.Computer.Network.Ping(server, 1000) Then
      If ShowUI Then
        DevExpress.XtraEditors.XtraMessageBox.Show("Koneksi ke server gagal.", title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
      Return False
    End If

    RaiseEvent Preparing("Download sinkronisasi file ...")
    System.Windows.Forms.Application.DoEvents()
    Try
      My.Computer.Network.DownloadFile(syncFile, Filesync)
    Catch ex As Exception
      If ShowUI Then
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
      Return False
    End Try

    Return True
  End Function
  Private Function CreateTableData() As DataTable
    Dim tableData As New DataTable("SyncData")
    Dim colA As New DataColumn("ReportObj", GetType(Boolean))
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