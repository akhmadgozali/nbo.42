Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO

Namespace NuSoft.Utils.FTPSocket
  Public Class FTPClient
    Property Server As String
    Property User As String
    Property Pass As String
    Property Port As Integer
    ReadOnly Property KodeStatus As Integer
      Get
        Return _codeStatus
      End Get
    End Property
    Property IsBinary As Boolean
      Get
        Return _isBinary
      End Get
      Set(value As Boolean)
        If (_isBinary = value) Then
          Return
        End If
        If value Then
          SendCommand("TYPE I")
        Else
          SendCommand("TYPE A")
        End If
        If (_codeStatus <> 200) Then
          Return
        End If
      End Set
    End Property

    Private ftpSocket As Socket
    Private _codeStatus As Integer
    Private _buffer As Byte() = New Byte(511) {}
    Private _bytes As Integer
    Private _statusMessage, _result As String
    Private _isBinary As Boolean

    Sub New()

    End Sub
    Sub New(server As String)
      Me.New(server, "")
    End Sub
    Sub New(server As String, user As String)
      Me.New(server, user, "")
    End Sub
    Sub New(server As String, user As String, pass As String)
      Me.New(server, user, pass, Nothing)
    End Sub
    Sub New(server As String, user As String, pass As String, port As Integer)
      Me.Server = server
      Me.User = user
      Me.Pass = pass
      If port = Nothing Then
        Me.Port = 21
      Else
        Me.Port = port
      End If
    End Sub

    Private Function Login() As Boolean
      If ftpSocket Is Nothing Then
        ftpSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
      End If

      If ftpSocket.Connected Then
        Return True
      End If

      Dim remoteAddress As IPAddress = Dns.GetHostEntry(Server).AddressList(0)
      Dim addrEndPoint As IPEndPoint = New IPEndPoint(remoteAddress, Port)
      ftpSocket.Connect(addrEndPoint)
      ReadResponse()
      If (_codeStatus <> 220) Then '//220->Server Ready for New User
        CloseConnection()
        Throw New Utils.Exception("Tidak dapat terhubung ke server")
        Return False
      End If

      If Not SendUserCommand() Then
        Return False
      End If

      If (_codeStatus <> 230) Then '//If Not Logged in!
        If Not SendPassCommand() Then
          Return False
        End If
      End If

      Return True
    End Function
    Private Sub LogOut()
      If Not ftpSocket Is Nothing Then
        ftpSocket.Close()
        ftpSocket = Nothing
      End If
    End Sub
    Private Sub ReadResponse()
      _statusMessage = ""
      _result = SplitResponse()
      'MsgBox("Response = " & _result)
      _codeStatus = Integer.Parse(_result.Substring(0, 3))
    End Sub
    Private Function SplitResponse() As String
      Try
        While True
          _bytes = ftpSocket.Receive(_buffer, _buffer.Length, 0) ' //Number Of Bytes (Count)
          _statusMessage += Encoding.ASCII.GetString(_buffer, 0, _bytes) ' //Convert to String
          If (_bytes < _buffer.Length) Then
            Exit While
          End If
        End While

        If _statusMessage = "" Then
          Throw New Utils.Exception("Tidak bisa koneksi ke FTP Server." & vbCrLf & "Cek koneksi internet atau port ftp " & Port)
        End If

        Dim msg As String() = _statusMessage.Split(vbLf.ToCharArray)
        If (_statusMessage.Length > 2) Then
          _statusMessage = msg(msg.Length - 2) '  //Remove Last \n
        Else
          _statusMessage = msg(0)
        End If

        If Not (_statusMessage.Substring(3, 1).Equals(" ")) Then
          Return SplitResponse()
        Else
          Return _statusMessage
        End If
      Catch ex As Exception
        ftpSocket.Close()
        Throw New Utils.Exception(ex.Message)
        Return ""
      End Try
    End Function
    Private Sub SendCommand(message As String)
      Dim CommandBytes As Byte() = Encoding.ASCII.GetBytes((message & vbCr & vbLf).ToCharArray())
      'MsgBox("Send COmmand = " & message)
      ftpSocket.Send(CommandBytes, CommandBytes.Length, SocketFlags.None)
      ReadResponse()
    End Sub
    Private Function OpenSocketForTransfer() As Socket
      SendCommand("PASV")
      '//response from server is the IP and port number for the client in "(" & ")"
      Dim tranferSocket As Socket = Nothing
      Dim ipEndPoint As IPEndPoint = Nothing
      Dim indx1 As Integer = _result.IndexOf("(")
      Dim indx2 As Integer = _result.IndexOf(")")
      Dim IpPort As String = _result.Substring((indx1 + 1), (indx2 - indx1) - 1)
      Dim Parts As Integer() = New Integer(5) {}
      Dim PartCount As Integer = 0
      Dim Buffer As String = ""

      Dim i As Integer = 0
      While i < IpPort.Length AndAlso PartCount <= 6
        Dim chr As Char = Char.Parse(IpPort.Substring(i, 1)) ' //Convert To Char
        If (Char.IsDigit(chr)) Then '//Are Chars Numeric? 
          Buffer += chr
        ElseIf (chr <> ",") Then '//Pasv Result should come only numeric and ',' Chars
          Throw New Utils.Exception("Status : Wrong PASV result->" + _result)
          Return Nothing
        Else
          If (chr = "," OrElse i + 1 = IpPort.Length) Then
            Try
              Parts(PartCount) = Integer.Parse(Buffer)
              PartCount += 1
              'Parts(System.Math.Max(System.Threading.Interlocked.Increment(PartCount), PartCount - 1)) = Int32.Parse(Buffer)
              Buffer = ""
            Catch ex As Exception
              Throw New Utils.Exception("Status : Wrong PASV result (not supported?): " + _result)
              Return Nothing
            End Try
          End If
        End If

        i += 1
      End While

      Parts(PartCount) = Integer.Parse(Buffer)
      Dim ipAddress As String = Parts(0) & "." & Parts(1) & "." & Parts(2) & "." & Parts(3)
      Dim port As Integer = (Parts(4) << 8) + Parts(5) ';  //Parts[4] <<8 = Parts[4]*256
      'MsgBox("IP Address = " & ipAddress & "/Port = " & port)
      Try
        tranferSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        '//ipEndPoint = new IPEndPoint(Dns.GetHostEntry(ipAddress).AddressList[0], port);
        ipEndPoint = New IPEndPoint(Net.IPAddress.Parse(ipAddress), port)
        tranferSocket.Connect(ipEndPoint)
      Catch ex As Exception
        If Not tranferSocket Is Nothing AndAlso tranferSocket.Connected Then
          tranferSocket.Close()
        End If
        Throw New Utils.Exception("Status : Can't connect to remote server ->" + ex.Message + " \n")
        Return Nothing
      End Try

      Return tranferSocket
    End Function

    Private Function SendUserCommand() As Boolean
      SendCommand(String.Format(My.Resources.FTPSocketSendUser, User))
      'ReadResponse()
      If (Not (_codeStatus = 331 OrElse _codeStatus = 230) OrElse _codeStatus = 530) Then '//230->Logged in , 331->UserName Okey,Need Password , 530->Login Fail
        LogOut()
        Throw New Utils.Exception("User name salah")
        Return False
      Else
        Return True
      End If
    End Function
    Private Function SendPassCommand() As Boolean
      SendCommand(String.Format(My.Resources.FTPSocketSendPass, Pass))
      'ReadResponse()
      If Not (_codeStatus = 230 OrElse _codeStatus = 202) Then '//202 ->Command Not implemented(Password Not Required)
        LogOut()
        Throw New Utils.Exception("Password salah")
        Return False
      Else
        Return True
      End If
    End Function
    Private Sub SendQuitCommand()
      SendCommand(My.Resources.FTPSocketSendQuit)
    End Sub

    Sub CloseConnection()
      If Not ftpSocket Is Nothing Then
        SendQuitCommand()
      End If
      LogOut()
    End Sub
    Function IsLogged() As Boolean
      Return Not ftpSocket Is Nothing AndAlso ftpSocket.Connected
    End Function
    Function DownloadFile(ftpPath As String, localPath As String) As Boolean
      If Not IsLogged() Then
        If Not Login() Then
          Return False
        End If
      End If

      IsBinary = True
      Dim output As FileStream = Nothing
      If Not File.Exists(localPath) Then
        output = File.Create(localPath)
      Else
        output = New FileStream(localPath, FileMode.Open)
      End If
      Dim dataSocket As Socket = OpenSocketForTransfer()

      SendCommand("RETR " + ftpPath)
      If (_codeStatus <> 150 AndAlso _codeStatus <> 125) Then
        Throw New Utils.Exception("Status : " + _result.Substring(4) + "\n")
        Return False
      End If

      Dim timeout As DateTime = DateTime.Now.AddSeconds(30)
      While (timeout > DateTime.Now)
        _bytes = dataSocket.Receive(_buffer, _buffer.Length, 0)
        output.Write(_buffer, 0, _bytes)
        If (_bytes <= 0) Then
          Exit While
        End If
      End While
      output.Close()
      If (dataSocket.Connected) Then
        dataSocket.Close()
      End If
      ReadResponse()
      If (_codeStatus <> 226 AndAlso _codeStatus <> 250) Then
        Throw New Utils.Exception("Status : " + _result.Substring(4) + "\n")
        Return False
      End If
      Return True
    End Function
    Function UploadFile(LocalPath As String) As Boolean
      If Not IsLogged() Then
        If Not Login() Then
          Return False
        End If
      End If

      Dim dataSocket As Socket = Nothing
      dataSocket = OpenSocketForTransfer()
      SendCommand("STOR " + System.IO.Path.GetFileName(LocalPath))
      If (_codeStatus <> 125 AndAlso _codeStatus <> 150) Then
        Throw New Utils.Exception("Status : " + _result.Substring(4) + "\n")
        Return False
      End If

      Dim input As FileStream = New FileStream(LocalPath, FileMode.Open)
      While ((CInt(_bytes = input.Read(_buffer, 0, _buffer.Length)) > 0))
        dataSocket.Send(_buffer, _bytes, 0)
      End While
      input.Close()
      If (dataSocket.Connected) Then
        dataSocket.Close()
      End If
      ReadResponse()
      If (_codeStatus <> 226 AndAlso _codeStatus <> 250) Then
        Throw New Utils.Exception("Status : " + _result.Substring(4) + "\n")
        Return False
      End If
      Return True
    End Function
  End Class
End Namespace