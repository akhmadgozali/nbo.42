Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("userreport")> _
  Public Class UserReport
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Integer
    Private _user As User
    Private _report As Laporan
    Private _database As Database
    Private _buka As Boolean
    Private _eksport As Boolean
    Private _cetak As Boolean

    <Persistent("p_id"), Key(True), Indexed("User;Report;Database", unique:=True)> Property Id As Integer
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
    <Persistent("f_report")> Property Report As Laporan
      Get
        Return _report
      End Get
      Set(value As Laporan)
        SetPropertyValue(Of Laporan)("Report", _report, value)
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
