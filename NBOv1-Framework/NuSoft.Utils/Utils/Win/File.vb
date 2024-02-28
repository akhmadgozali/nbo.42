Namespace NuSoft.Utils.Win
  Public Class File
    Shared Function ShowSaveFileDialog(ByVal title As String, ByVal filter As String) As String
      Return ShowSaveFileDialog(title, filter, "")
    End Function
    Shared Function ShowSaveFileDialog(ByVal title As String, ByVal filter As String, defaultName As String) As String
      Using dlg As Windows.Forms.SaveFileDialog = New Windows.Forms.SaveFileDialog()
        Dim name As String = Windows.Forms.Application.ProductName
        Dim n As Integer = name.LastIndexOf(".") + 1
        If n > 0 Then
          name = name.Substring(n, name.Length - n)
        End If
        If defaultName <> "" Then
          name = defaultName
        End If
        dlg.Title = title
        dlg.FileName = name
        dlg.Filter = filter
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
          Return dlg.FileName
        Else
          Return ""
        End If
      End Using
    End Function
    Shared Function ShowOpenFileDialog(ByVal title As String, ByVal filter As String) As String
      Return ShowOpenFileDialog(title, filter, "")
    End Function
    Shared Function ShowOpenFileDialog(ByVal title As String, ByVal filter As String, defaultName As String) As String
      Using dlg As Windows.Forms.OpenFileDialog = New Windows.Forms.OpenFileDialog
        Dim name As String = Windows.Forms.Application.ProductName
        Dim n As Integer = name.LastIndexOf(".") + 1
        If n > 0 Then
          name = name.Substring(n, name.Length - n)
        End If
        If defaultName <> "" Then
          name = defaultName
        End If
        dlg.Title = title
        dlg.FileName = name
        dlg.Filter = filter
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
          Return dlg.FileName
        Else
          Return ""
        End If
      End Using
    End Function
    Shared Function ShowFolderBrowse(Keterangan As String, defaultPath As String, showNewFolderButton As Boolean) As String
      Using dlg As Windows.Forms.FolderBrowserDialog = New Windows.Forms.FolderBrowserDialog
        dlg.Description = Keterangan
        dlg.SelectedPath = defaultPath
        dlg.ShowNewFolderButton = showNewFolderButton
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
          Return dlg.SelectedPath
        Else
          Return defaultPath
        End If
      End Using
    End Function

    Shared Sub OpenFile(ByVal fileName As String, ByVal title As String)
      OpenFile(fileName, title, True)
    End Sub
    Shared Sub OpenFile(ByVal fileName As String, ByVal title As String, needConfirmation As Boolean)
      If needConfirmation Then
        If DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Apakah anda ingin membuka file {0} ?", fileName), title, Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
          Return
        End If
      End If

      Try
        Using process As System.Diagnostics.Process = New System.Diagnostics.Process()
          process.StartInfo.FileName = fileName
          process.StartInfo.Verb = "Open"
          process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
          process.Start()
        End Using
      Catch
        'Utility.ExceptionBo
        DevExpress.XtraEditors.XtraMessageBox.Show("Tidak dapat menemukan aplikasi yang dapat membuka file ini.", Windows.Forms.Application.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End Try
    End Sub
  End Class
End Namespace