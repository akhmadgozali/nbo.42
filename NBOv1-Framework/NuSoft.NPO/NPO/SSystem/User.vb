Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("userlist")> _
  Public Class User
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Integer
    <Indexed("Kode", unique:=True)> Private _kode As String
    Private _nama As String
    Private _password As String
    Private _level As Int16
    Private _aktif As Boolean
    Private _limitRegional As Boolean
    Private _limitDivisi As Boolean
    Private _keterangan As String
    Private _dashboardId As Integer
    Private _dashboardModul As String
    Private _homeMenu As Menu

    <Persistent("p_id"), Key(True)> Property Id As Integer
      Get
        Return _id
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Id", _id, value)
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
    <Persistent("d_password")> Property Password As String
      Get
        Return _password
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Password", _password, value)
      End Set
    End Property
    <Persistent("d_level")> Property Level As Int16
      Get
        Return _level
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Level", _level, value)
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
    <Persistent("d_limited")> Property LimitRegional As Boolean
      Get
        Return _limitRegional
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("LimitRegional", _limitRegional, value)
      End Set
    End Property
    <Persistent("d_limitdivision")> Property LimitDivisi As Boolean
      Get
        Return _limitDivisi
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("LimitDivisi", _limitDivisi, value)
      End Set
    End Property
    <Persistent("d_note")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
    Property DashboardId As Integer
      Get
        Return _dashboardId
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("DashboardId", _dashboardId, value)
      End Set
    End Property
    Property DashboardModul As String
      Get
        Return _dashboardModul
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("DashboardModul", _dashboardModul, value)
      End Set
    End Property
    Property HomeMenu As Menu
      Get
        Return _homeMenu
      End Get
      Set(value As Menu)
        SetPropertyValue(Of Menu)("HomeMenu", _homeMenu, value)
      End Set
    End Property
  End Class
End Namespace