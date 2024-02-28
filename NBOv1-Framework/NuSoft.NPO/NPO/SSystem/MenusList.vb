Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("menulist")> _
  Public Class Menu
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int16
    Private _modul As Modul
    Private _kode As String
    Private _nama As String
    Private _induk As Menu
    Private _aktif As Boolean
    Private _urutan As Int16

    <Persistent("p_id"), Key(), Indexed("Modul;Kode", unique:=True)> Property Id As Int16
      Get
        Return _id
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_module")> Property Modul As Modul
      Get
        Return _modul
      End Get
      Set(value As Modul)
        SetPropertyValue(Of Modul)("Modul", _modul, value)
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
    <Persistent("d_parent"), Association("Parent_Children")> Property Induk As Menu
      Get
        Return _induk
      End Get
      Set(value As Menu)
        SetPropertyValue(Of Menu)("Induk", _induk, value)
      End Set
    End Property
    <Persistent("d_active")> Property Aktif As Boolean
      Get
        Return _aktif
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Aktif", _aktif, value)
      End Set
    End Property
    <Persistent("d_order")> Property Urutan As Int16
      Get
        Return _urutan
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Urutan", _urutan, value)
      End Set
    End Property

    <Association("Parent_Children")> ReadOnly Property Koleksi() As XPCollection(Of Menu)
      Get
        Return GetCollection(Of Menu)("Koleksi")
      End Get
    End Property
  End Class
End Namespace