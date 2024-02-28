Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("modulelist")> _
  Public Class Modul
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int16
    <Indexed("Kode", Unique:=True)> Private _kode As String
    Private _nama As String
    Private _keterangan As String

    <Persistent("p_id"), Key()> Property Id As Int16
      Get
        Return _id
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_name")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("d_description")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
  End Class
End Namespace