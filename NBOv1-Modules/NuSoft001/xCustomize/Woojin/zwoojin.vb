Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute

Namespace Persistent
  <Persistent("m01cmemo")> _
  Public Class zWoojinMemo
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _tanggal As Date
    Private _nama As String
    Private _jumlah As Double
    Private _keterangan As String

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("d_tanggal")> Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
      End Set
    End Property
    <Persistent("d_nama")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("d_nilai")> Property Nilai As Double
      Get
        Return _jumlah
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _jumlah, value)
      End Set
    End Property
    <Persistent("d_keterangan")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
  End Class
  <Persistent("m01cbrankas")> _
  Public Class zWoojinBrankas
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _tanggal As Date
    Private _keterangan As String
    Private _n1 As Double
    Private _n2 As Double
    Private _n3 As Double
    Private _n4 As Double
    Private _n5 As Double
    Private _n6 As Double
    Private _n7 As Double
    Private _n8 As Double
    Private _n9 As Double
    Private _n10 As Double
    Private _n11 As Double
    Private _n12 As Double
    Private _n13 As Double
    Private _n14 As Double
    Private _n15 As Double
    Private _n16 As Double
    Private _n17 As Double
    Private _n18 As Double
    Private _n19 As Double
    Private _n20 As Double
    Private _n21 As Double
    Private _n22 As Double
    Private _n23 As Double
    Private _n24 As Double
    Private _n25 As Double
    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("d_tanggal")> Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
      End Set
    End Property
    <Persistent("d_keterangan")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _keterangan, value)
      End Set
    End Property
    <Persistent("d_n1")> Property N1 As Double
      Get
        Return _n1
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N1", _n1, value)
      End Set
    End Property
    <Persistent("d_n2")> Property N2 As Double
      Get
        Return _n2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N2", _n2, value)
      End Set
    End Property
    <Persistent("d_n3")> Property N3 As Double
      Get
        Return _n3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N3", _n3, value)
      End Set
    End Property
    <Persistent("d_n4")> Property N4 As Double
      Get
        Return _n4
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N4", _n4, value)
      End Set
    End Property
    <Persistent("d_n5")> Property N5 As Double
      Get
        Return _n5
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N5", _n5, value)
      End Set
    End Property
    <Persistent("d_n6")> Property N6 As Double
      Get
        Return _n6
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N6", _n6, value)
      End Set
    End Property
    <Persistent("d_n7")> Property N7 As Double
      Get
        Return _n7
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N7", _n7, value)
      End Set
    End Property
    <Persistent("d_n8")> Property N8 As Double
      Get
        Return _n8
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N8", _n8, value)
      End Set
    End Property
    <Persistent("d_n9")> Property N9 As Double
      Get
        Return _n9
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N9", _n9, value)
      End Set
    End Property
    <Persistent("d_n10")> Property N10 As Double
      Get
        Return _n10
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N10", _n10, value)
      End Set
    End Property
    <Persistent("d_n11")> Property N11 As Double
      Get
        Return _n11
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N11", _n11, value)
      End Set
    End Property
    <Persistent("d_n12")> Property N12 As Double
      Get
        Return _n12
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N12", _n12, value)
      End Set
    End Property
    <Persistent("d_n13")> Property N13 As Double
      Get
        Return _n13
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N13", _n13, value)
      End Set
    End Property
    <Persistent("d_n14")> Property N14 As Double
      Get
        Return _n14
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N14", _n14, value)
      End Set
    End Property
    <Persistent("d_n15")> Property N15 As Double
      Get
        Return _n15
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N15", _n15, value)
      End Set
    End Property
    <Persistent("d_n16")> Property N16 As Double
      Get
        Return _n16
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N16", _n16, value)
      End Set
    End Property
    <Persistent("d_n17")> Property N17 As Double
      Get
        Return _n17
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N17", _n17, value)
      End Set
    End Property
    <Persistent("d_n18")> Property N18 As Double
      Get
        Return _n18
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N18", _n18, value)
      End Set
    End Property
    <Persistent("d_n19")> Property N19 As Double
      Get
        Return _n19
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N19", _n19, value)
      End Set
    End Property
    <Persistent("d_n20")> Property N20 As Double
      Get
        Return _n20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N20", _n20, value)
      End Set
    End Property
    <Persistent("d_n21")> Property N21 As Double
      Get
        Return _n21
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N21", _n21, value)
      End Set
    End Property
    <Persistent("d_n22")> Property N22 As Double
      Get
        Return _n22
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N22", _n22, value)
      End Set
    End Property
    <Persistent("d_n23")> Property N23 As Double
      Get
        Return _n23
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N23", _n23, value)
      End Set
    End Property
    <Persistent("d_n24")> Property N24 As Double
      Get
        Return _n24
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N24", _n24, value)
      End Set
    End Property
    <Persistent("d_n25")> Property N25 As Double
      Get
        Return _n25
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("N25", _n25, value)
      End Set
    End Property

  End Class
  <Persistent("m01vwglwoojin")> Public Class zWoojinBukuBesar
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property Id As Int64
    Property SumberData As NPO.Modules.ModSys.SumberData
    Property Tahun As Int32
    Property Bulan As Int32
    Property Tanggal As Date
    Property Kontak As Persistent.Kontak
    Property NoBukti As String
    Property AkunMain As Coa
    Property AkunDetail As Coa
    Property Urutan As Int16
    Property SaldoAwal As Double
    Property Debit As Double
    Property Kredit As Double
    Property SaldoAwalValas As Double
    Property DebitValas As Double
    Property KreditValas As Double
    Property Kurs As Double
    Property Keterangan As String
    Property Catatan As String
    Property Proyek As Persistent.Proyek
    Property ProyekSub As Persistent.ProyekSub
    Property Divisi As NPO.Modules.ModSys.Divisi
    Property Tipe As String
  End Class

End Namespace

