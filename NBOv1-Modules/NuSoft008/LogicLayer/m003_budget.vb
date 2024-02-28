Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO

Namespace Persistent
  <Persistent("m01budget")>
  Public Class Anggaran
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _tahun As UInt16
    Private _akun As Coa
    Private _bulan01 As Double
    Private _bulan02 As Double
    Private _bulan03 As Double
    Private _bulan04 As Double
    Private _bulan05 As Double
    Private _bulan06 As Double
    Private _bulan07 As Double
    Private _bulan08 As Double
    Private _bulan09 As Double
    Private _bulan10 As Double
    Private _bulan11 As Double
    Private _bulan12 As Double
    <Persistent("p_id"), Key(True), Indexed("Tahun;Akun", Unique:=True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("d_year")> Property Tahun As UInt16
      Get
        Return _tahun
      End Get
      Set(value As UInt16)
        SetPropertyValue(Of UInt16)("Tahun", _tahun, value)
      End Set
    End Property
    <Persistent("f_coa")> Property Akun As Coa
      Get
        Return _akun
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Akun", _akun, value)
      End Set
    End Property
    <Persistent("d_value1")> Property Bulan01 As Double
      Get
        Return _bulan01
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan01", _bulan01, value)
      End Set
    End Property
    <Persistent("d_value2")> Property Bulan02 As Double
      Get
        Return _bulan02
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan02", _bulan02, value)
      End Set
    End Property
    <Persistent("d_value3")> Property Bulan03 As Double
      Get
        Return _bulan03
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan03", _bulan03, value)
      End Set
    End Property
    <Persistent("d_value4")> Property Bulan04 As Double
      Get
        Return _bulan04
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan04", _bulan04, value)
      End Set
    End Property
    <Persistent("d_value5")> Property Bulan05 As Double
      Get
        Return _bulan05
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan05", _bulan05, value)
      End Set
    End Property
    <Persistent("d_value6")> Property Bulan06 As Double
      Get
        Return _bulan06
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan06", _bulan06, value)
      End Set
    End Property
    <Persistent("d_value7")> Property Bulan07 As Double
      Get
        Return _bulan07
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan07", _bulan07, value)
      End Set
    End Property
    <Persistent("d_value8")> Property Bulan08 As Double
      Get
        Return _bulan08
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan08", _bulan08, value)
      End Set
    End Property
    <Persistent("d_value9")> Property Bulan09 As Double
      Get
        Return _bulan09
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan09", _bulan09, value)
      End Set
    End Property
    <Persistent("d_value10")> Property Bulan10 As Double
      Get
        Return _bulan10
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan10", _bulan10, value)
      End Set
    End Property
    <Persistent("d_value11")> Property Bulan11 As Double
      Get
        Return _bulan11
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan11", _bulan11, value)
      End Set
    End Property
    <Persistent("d_value12")> Property Bulan12 As Double
      Get
        Return _bulan12
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Bulan12", _bulan12, value)
      End Set
    End Property
  End Class
End Namespace