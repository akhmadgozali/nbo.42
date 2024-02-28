Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("reportlistdb")> _
  Public Class LaporanPerDatabase
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Integer
    Private _report As Laporan
    Private _database As Database
    Private _namaFile As String
    Private _keterangan As String

    <Persistent("p_id"), Key(), Indexed("Report;Database", unique:=True)> Property Id As Integer
      Get
        Return _id
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_main")> Property Report As Laporan
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
    <Persistent("d_filename")> Property NamaFile As String
      Get
        Return _namaFile
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NamaFile", _namaFile, value)
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
  End Class
End Namespace