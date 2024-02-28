Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("usermenu")> _
  Public Class UserMenu
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Integer
    Private _user As User
    Private _menu As Menu
    Private _database As Database
    Private _buka As Boolean
    Private _tambah As Boolean
    Private _edit As Boolean
    Private _hapus As Boolean
    Private _eksport As Boolean
    Private _cetak As Boolean

    <Persistent("p_id"), Key(True), Indexed("User;Menu;Database", unique:=True)> Property Id As Integer
      Get
        Return _id
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_user")> Property User As User
      Get
        Return _user
      End Get
      Set(value As User)
        SetPropertyValue(Of User)("User", _user, value)
      End Set
    End Property
    <Persistent("f_menu")> Property Menu As Menu
      Get
        Return _menu
      End Get
      Set(value As Menu)
        SetPropertyValue(Of Menu)("Menu", _menu, value)
      End Set
    End Property
    <Persistent("f_db")> Property Database As Database
      Get
        Return _database
      End Get
      Set(value As Database)
        SetPropertyValue(Of Database)("Database", _database, value)
      End Set
    End Property
    <Persistent("d_open")> Property Buka As Boolean
      Get
        Return _buka
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Buka", _buka, value)
      End Set
    End Property
    <Persistent("d_add")> Property Tambah As Boolean
      Get
        Return _tambah
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Tambah", _tambah, value)
      End Set
    End Property
    <Persistent("d_edit")> Property Edit As Boolean
      Get
        Return _edit
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Edit", _edit, value)
      End Set
    End Property
    <Persistent("d_delete")> Property Hapus As Boolean
      Get
        Return _hapus
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Hapus", _hapus, value)
      End Set
    End Property
    <Persistent("d_export")> Property Eksport As Boolean
      Get
        Return _eksport
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Eksport", _eksport, value)
      End Set
    End Property
    <Persistent("d_print")> Property Cetak As Boolean
      Get
        Return _cetak
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Cetak", _cetak, value)
      End Set
    End Property
  End Class
End Namespace