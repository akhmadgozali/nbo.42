Namespace NuSoft.Utils
  Public Class Binary
    Shared Function ConvertToBinary(ByVal Image As System.Drawing.Image) As Byte()
      Dim result As Byte()

      Using ms As New IO.MemoryStream
        Image.Save(ms, Image.RawFormat)
        result = ms.ToArray()
      End Using

      Return result
    End Function
    Shared Function ConvertToBinary(ByVal pathFile As String) As Byte()
      Dim fs As System.IO.FileStream
      Dim FileSize As Integer
      Dim result() As Byte

      fs = New System.IO.FileStream(pathFile, IO.FileMode.Open, IO.FileAccess.Read)
      FileSize = CInt(fs.Length)

      result = New Byte(FileSize) {}
      fs.Read(result, 0, FileSize)
      fs.Close()

      Return result
    End Function
  End Class
End Namespace