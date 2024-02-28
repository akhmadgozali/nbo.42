Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("dblist")> _
  Public Class Database
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _Id As UInt16
    <Indexed("NamaPerusahaan", unique:=True)> Private _namaPerusahaan As String
    Private _namaAlias As String
    <Indexed("NamaDatabase", unique:=True)> Private _namaDatabase As String
    Private _Aktif As Boolean

    <Persistent("p_id"), Key()> Property Id As UInt16
      Get
        Return _Id
      End Get
      Set(value As UInt16)
        SetPropertyValue(Of UInt16)("Id", _Id, value)
      End Set
    End Property
    <Persistent("u_code")> Property NamaPerusahaan As String
      Get
        Return _namaPerusahaan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NamaPerusahaan", _namaPerusahaan, value)
      End Set
    End Property
    <Persistent("d_name")> Property NamaAlias As String
      Get
        Return _namaAlias
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NamaAlias", _namaAlias, value)
      End Set
    End Property
    <Persistent("d_dbname")> Property NamaDatabase As String
      Get
        Return _namaDatabase
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NamaDatabase", _namaDatabase, value)
      End Set
    End Property
    <Persistent("d_active")> Property Aktif As Boolean
      Get
        Return _Aktif
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Aktif", _Aktif, value)
      End Set
    End Property
  End Class
End Namespace