Namespace NuSoft.Utils
  Public Class Image
    Shared Function FindImageCodec(ByVal format As System.Drawing.Imaging.ImageFormat) As System.Drawing.Imaging.ImageCodecInfo
      Dim infos As System.Drawing.Imaging.ImageCodecInfo() = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
      For Each item As System.Drawing.Imaging.ImageCodecInfo In infos
        If item.FormatID.Equals(format.Guid) Then
          Return item
        End If
      Next item

      Return Nothing
    End Function
  End Class
End Namespace