Imports DevExpress.Xpo

Namespace NuSoft.NPO.Modules.aba
  <Persistent("abablob")> Public Class Blob
    Inherits NPOBase

    Public Sub New()

    End Sub
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private Function CheckData() As Boolean
      If _fileName = Nothing Then
        Throw New Utils.Exception("Masukkan nama file", -1, "", ClassInfo.TableName)
        Return False
      End If
      If _Blob Is Nothing Then
        Throw New Utils.Exception("Masukkan dokumen yang akan diupload", -2, "", ClassInfo.TableName)
        Return False
      End If
      If _ukuran > 1024000 Then
        Throw New Utils.Exception("Ukuran dokumen max 1MB", -3, "", ClassInfo.TableName)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(_Blob)
      _ukuran = ms.Length
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub

    Private _id As Int32
    Private _fileName As String
    Private _ukuran As Long
    Private _Blob As Byte()

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(ByVal value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("d_filename")> Property FileName As String
      Get
        Return _fileName
      End Get
      Set(ByVal value As String)
        SetPropertyValue(Of String)("FileName", _fileName, value)
      End Set
    End Property
    <Persistent("d_size")> Property Ukuran As Long
      Get
        Return _ukuran
      End Get
      Set(ByVal value As Long)
        SetPropertyValue(Of Long)("Ukuran", _ukuran, value)
      End Set
    End Property
    <Persistent("d_blob")> Property Blob As Byte()
      Get
        Return _Blob
      End Get
      Set(ByVal value As Byte())
        SetPropertyValue(Of Byte())("Blob", _Blob, value)
      End Set
    End Property
    <NonPersistent()> Property Image As System.Drawing.Image
      Get
        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(_Blob)
        Dim returnImage As System.Drawing.Image = Drawing.Image.FromStream(ms)
        Return returnImage
      End Get
      Set(ByVal value As System.Drawing.Image)
        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
        value.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Blob = ms.ToArray
      End Set
    End Property
  End Class
End Namespace