Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("setting")> _
  Public Class Setting
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _Id As Integer
    Private _Kode As String
    Private _Isi As String

    <Persistent("Id"), Key(True)> Property Id As Integer
      Get
        Return _Id
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Id", _Id, value)
      End Set
    End Property
    <Persistent("Code")> Property Kode As String
      Get
        Return _Kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _Kode, value)
      End Set
    End Property
    <Persistent("Value")> Property Isi As String
      Get
        Return _Isi
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Isi", _Isi, value)
      End Set
    End Property
  End Class
End Namespace