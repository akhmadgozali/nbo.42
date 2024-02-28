Public Class DES
  Implements IDisposable

  Private disposedValue As Boolean ' To detect redundant calls
  'Random Value Vector (Protect against encryption repetition (ex. "aloaloalo" <> "ģ!ģ!ģ!")
  Private Vector() As Byte = {&H12, &H44, &H16, &HEE, &H88, &H15, &HDD, &H41}
  Private TheKey(7) As Byte    '8-Byte Key
  Private mKey As String
  Private ReadOnly objDES As New System.Security.Cryptography.DESCryptoServiceProvider()    'DES Encryption Object

  Public Sub New()
    Key = "iufdihyiyg98y9gyr87y93443904309tu3984pyt03y0by37ytb85598n"
  End Sub
  Public Property Key() As String
    Get
      Return mKey
    End Get
    Set(ByVal strKey As String)
      ' Temporary buffer to hold the key
      Dim arrKeyBuffer(100) As Byte
      Dim AscEncod As New System.Text.ASCIIEncoding
      Dim i As Integer = 0

      Try
        mKey = strKey

        'Convert key string into byte array
        AscEncod.GetBytes(strKey, i, strKey.Length, arrKeyBuffer, i)
      Catch
        Throw New ArgumentException("Key Conversion Error.")
      End Try
      Try
        'Hash the key
        Dim hashSha As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim arrHash() As Byte = hashSha.ComputeHash(arrKeyBuffer)

        'Hold hashed key in TheKey array
        For i = 0 To 7
          TheKey(i) = arrHash(i)
        Next i
      Catch
        Throw New ArgumentException("Hashing Key Error.")
      End Try
    End Set
  End Property
  Public Function Encrypt(ByVal source As String) As String
    Dim memStream As New System.IO.MemoryStream  'Create memory stream to hold encrypted string

    Try
      ' Convert uncrypted string into a byte array
      Dim bufSource() As Byte = System.Text.Encoding.UTF8.GetBytes(source)

      'Crypt the byte array
      Dim crStream As New System.Security.Cryptography.CryptoStream(memStream, objDES.CreateEncryptor(TheKey, Vector), System.Security.Cryptography.CryptoStreamMode.Write)
      crStream.Write(bufSource, 0, bufSource.Length)
      crStream.FlushFinalBlock()

      ' Convert to Base64 String (XMLDOM)
      Return Convert.ToBase64String(memStream.ToArray())
    Catch
      Throw New System.Security.Cryptography.CryptographicException("String encryption Error.")
    End Try
  End Function
  Public Function Decrypt(ByVal source As String) As String
    Dim memStream As New System.IO.MemoryStream  'Create memory stream to hold decypted string
    Dim objDecode As System.Text.Encoding = System.Text.Encoding.UTF8 ' Memory Decode Object

    Try
      ' Uncode strSource
      Dim bufSource() As Byte = Convert.FromBase64String(source)

      'Uncrypt array byte into memory stream'
      Dim crStream As New System.Security.Cryptography.CryptoStream(memStream, objDES.CreateDecryptor(TheKey, Vector), System.Security.Cryptography.CryptoStreamMode.Write)
      crStream.Write(bufSource, 0, bufSource.Length)
      crStream.FlushFinalBlock()

      'Uncode memory stream to string'
      Return objDecode.GetString(memStream.ToArray())
    Catch
      Throw New System.Security.Cryptography.CryptographicException("String decryption Error.")
    End Try
  End Function

#Region "IDisposable Support"
  ' IDisposable
  Protected Overridable Sub Dispose(ByVal disposing As Boolean)
    If Not Me.disposedValue Then
      If disposing Then
        ' TODO: dispose managed state (managed objects).
        objDES.Clear()
      End If

      ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
      ' TODO: set large fields to null.
    End If
    Me.disposedValue = True
  End Sub
  ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
  'Protected Overrides Sub Finalize()
  '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
  '    Dispose(False)
  '    MyBase.Finalize()
  'End Sub

  ' This code added by Visual Basic to correctly implement the disposable pattern.
  Public Sub Dispose() Implements IDisposable.Dispose
    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    Dispose(True)
    GC.SuppressFinalize(Me)
  End Sub
#End Region

End Class
