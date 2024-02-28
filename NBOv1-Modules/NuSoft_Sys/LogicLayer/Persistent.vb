Imports DevExpress.Xpo
Imports NuSoft.NPO

Namespace Persistent
  <Persistent("a_division")> Public Class Divisi
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As UInt16
    <Persistent("p_id"), Key()> Property Id As UInt16
      Get
        Return _id
      End Get
      Set(ByVal value As UInt16)
        SetPropertyValue(Of UInt16)("Id", _id, value)
      End Set
    End Property
    Private _kode As String
    <Persistent("u_code")> Property Kode As String
      Get
        Return _kode
      End Get
      Set(ByVal value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
  End Class

  <Persistent("a_regional")> Public Class Regional
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As UInt16
    Private _kode As String
    Private _nama As String
    Private _alamat As String
    Private _kota As String
    Private _propinsi As String
    Private _kodePos As String
    Private _keterangan As String

    <Persistent("p_id"), Key()> Property Id As UInt16
      Get
        Return _id
      End Get
      Set(value As UInt16)
        SetPropertyValue(Of UInt16)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_code"), Size(3)> Property Kode As String
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
    <Persistent("d_address")> Property Alamat As String
      Get
        Return _alamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Alamat", _alamat, value)
      End Set
    End Property
    <Persistent("d_city")> Property Kota As String
      Get
        Return _kota
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kota", _kota, value)
      End Set
    End Property
    <Persistent("d_province")> Property Propinsi As String
      Get
        Return _propinsi
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Propinsi", _propinsi, value)
      End Set
    End Property
    <Persistent("d_postal")> Property KodePos As String
      Get
        Return _kodePos
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KodePos", _kodePos, value)
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

  <Persistent("a_setting")> Public Class Setting
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _modul As Integer
    Private _kode As String
    Private _isi As String
    Private _keterangan As String

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_module")> Property Modul As Integer
      Get
        Return _modul
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Modul", _modul, value)
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
    <Persistent("d_value")> Property Isi As String
      Get
        Return _isi
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Isi", _isi, value)
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
