Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  Public Enum AutoSearchKontak
    <EnumDescription("Kode Kontak")> KK = 0
    <EnumDescription("Nama Kontak")> NK = 1
  End Enum
  <Persistent("m05atermin")>
  Public Class Termin
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _kode As String
    Private _tempo As Int16
    Private _discount As Int16
    Private _discountp As Double
    Private _penalties As Int16
    Private _penaltiesp As Double

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
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
    <Persistent("d_tempo")> Property Tempo As Int16
      Get
        Return _tempo
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Tempo", _tempo, value)
      End Set
    End Property
    <Persistent("d_discount")> Property DiscDay As Int16
      Get
        Return _discount
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("DiscDay", _discount, value)
      End Set
    End Property
    <Persistent("d_discountp")> Property DiscPersen As Double
      Get
        Return _discountp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DiscPersen", _discountp, value)
      End Set
    End Property
    <Persistent("d_penalties")> Property PenaltiesDay As Int16
      Get
        Return _penalties
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("PenaltiesDay", _penalties, value)
      End Set
    End Property
    <Persistent("d_penaltiesp")> Property PenaltiesPersen As Double
      Get
        Return _discountp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PenaltiesPersen", _discountp, value)
      End Set
    End Property
  End Class
  <Persistent("m05avia")> _
  Public Class Via
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Indexed("Kode", Unique:=True)>
    Private _id As Int32
    Private _kode As String
    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_code"), Size(25)> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
  End Class

  '======= ENUM
  Public Enum eTipeFOB
    <EnumDescription("Origin")> Origin
    <EnumDescription("Destination")> Destination
  End Enum
  Public Enum eTipePajak
    <EnumDescription("Tanpa Pajak")> TanpaPajak
    <EnumDescription("Harga Belum Termasuk Pajak")> HargaBelumTermasuk
    <EnumDescription("Harga Sudah Termasuk Pajak")> HargaSudahTermasuk
  End Enum
  Public Enum eJenisPajak
    <EnumDescription("Harga Jual")> HargaJual
    <EnumDescription("Penggantian")> Penggantian
    <EnumDescription("Harga Jual Dan Penggantian")> HargaJualPenggantian
    <EnumDescription("Uang Muka")> UangMuka
    <EnumDescription("Termin")> Termin
  End Enum
  Public Enum eTipeInvoicePembelian
    <EnumDescription("Pakai PO")> PakaiPO
    <EnumDescription("Tanpa PO")> TanpaPO
  End Enum
  Public Enum eTipeHutangInvoice
    <EnumDescription("Mata Uang")> Uang = 0
    <EnumDescription("Regional")> Regional = 1
    <EnumDescription("Kontak")> Kontak = 2
    <EnumDescription("Manual")> Manual = 3
  End Enum
End Namespace