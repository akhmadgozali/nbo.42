Imports System.IO
Imports System.Reflection
Imports NuSoft.Utils.Win

Public Class Main
  Shared Sub Main(ByVal args() As String)
    '==== check instance
    Dim encryptDES As New NuSoft.Utils.Cryptograph.DES() With {.Key = Data.Helper.GetKey}
    If Not CBool(Data.Helper.GetMultipleInstance(encryptDES)) Then
      Using previousInstance As Process = checkInstance()
        If Not previousInstance Is Nothing Then
          DevExpress.XtraEditors.XtraMessageBox.Show("Aplikasi sudah berjalan.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
          Exit Sub
        End If
      End Using
    End If

    'If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\upd") Then
    '  Process.Start("NuSoft.Sync.exe", String.Format("-apply {0}.exe", My.Application.Info.ProductName))
    '  Exit Sub
    'End If

    Dim isRedirectUpdate As Boolean = True
    If args.GetUpperBound(0) >= 0 Then
      If args(0) = "noupdate" Then isRedirectUpdate = False
    End If

    If isRedirectUpdate Then
      Dim AppFullPath = Assembly.GetExecutingAssembly().Location
      Dim mainDirectory As String = Path.GetDirectoryName(AppFullPath)
      Dim updateFileName As String = Path.Combine(mainDirectory, "Nusoft.Update.exe")

      If IO.File.Exists(updateFileName) Then
        Dim server = Data.Helper.GetUpdateServer(encryptDES)
        Dim port = Data.Helper.GetUpdatePort(encryptDES)
        Dim user = Data.Helper.GetUpdateUser(encryptDES)
        Dim password = Data.Helper.GetUpdatePassword(encryptDES)
        Dim fileException = Data.Helper.GetUpdateFileException(encryptDES)
        Dim folderException = Data.Helper.GetUpdateFolderException(encryptDES)

        If Not String.IsNullOrEmpty(server) AndAlso Not String.IsNullOrEmpty(port) AndAlso Not String.IsNullOrEmpty(user) AndAlso Not String.IsNullOrEmpty(password) Then
          Dim appArgument = "--server={0} --port={1} --user={2} --password={3} --transfer={4} --caller=""{5}"" --fileexception={6} --folderexception={7}"
          appArgument = String.Format(appArgument, server, port, user, password, "FTP", AppFullPath, fileException, folderException)

          'InputBox("", "", updateFileName & appArgument)
          Dim p = Process.Start(updateFileName, appArgument)
          Exit Sub
        End If
      End If
    End If

    DevExpress.UserSkins.BonusSkins.Register()
    DevExpress.Skins.SkinManager.EnableFormSkins()
    DevExpress.Skins.SkinManager.EnableMdiFormSkins()
    System.Windows.Forms.Application.EnableVisualStyles()
    System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(True)
    NPO.NPOFunction.Register()

    Try
      If My.Settings.SkinName <> "" Then
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(My.Settings.SkinName)
      End If
    Catch ex As Exception
    End Try

		'Using x As New x_Serial(x_Serial.Mode.Admin)
		'	If Not x.ShowDialog = DialogResult.OK Then
		'		Exit Sub
		'	End If
		'End Using

		''==== check serial
		'If Not Utils.Serial.IsRegister Then
		'  Using x As New x_Serial(x_Serial.Mode.User)
		'    If Not x.ShowDialog = DialogResult.OK Then
		'      Exit Sub
		'    End If
		'  End Using
		'End If
		System.Windows.Forms.Application.Run(New x_Main)
	End Sub
  Shared Function checkInstance() As Process
    Dim cProcess As Process = Process.GetCurrentProcess()
    Dim aProcesses() As Process = Process.GetProcessesByName(cProcess.ProcessName)
    'loop through all the processes that are currently running on the
    'system that have the same name
    For Each process As Process In aProcesses
      'Ignore the currently running process
      If process.Id <> cProcess.Id Then
        'Check if the process is running using the same EXE as this one
        If Reflection.Assembly.GetExecutingAssembly().Location = cProcess.MainModule.FileName Then
          'if so return to the calling function with the instance of the process
          Return process
        End If
      End If
    Next
    'if nothing was found then this is the only instance, so return null
    Return Nothing
  End Function
End Class
