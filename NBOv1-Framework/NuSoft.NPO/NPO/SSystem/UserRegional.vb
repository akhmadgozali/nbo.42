Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("userregional")> _
  Public Class UserRegional
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Integer
    Private _user As User
    Private _regional As UInt16
    Private _database As Database
    Private _buka As Boolean
    Private _isDefault As Boolean

    <Persistent("p_id"), Key(True), Indexed("User;Regional;Database", unique:=True)> Property Id As Integer
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
    <Persistent("f_wil")> Property Regional As UInt16
      Get
        Return _regional
      End Get
      Set(value As UInt16)
        SetPropertyValue(Of UInt16)("Regional", _regional, value)
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
    <Persistent("d_default")> Property IsDefault As Boolean
      Get
        Return _isDefault
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("IsDefault", _isDefault, value)
      End Set
    End Property
  End Class
End Namespace