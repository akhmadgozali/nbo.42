Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  Public Enum TipeHPP
    <EnumDescription("Per Barang")> PB = 0
    <EnumDescription("Tipe Transaksi")> TT = 1
  End Enum
  Public Enum AutoSearchKontak
    <EnumDescription("Kode Kontak")> KK = 0
    <EnumDescription("Nama Kontak")> NK = 1
  End Enum
  Public Enum eLembarFP
    <EnumDescription("Lembar 1")> Lembar1
    <EnumDescription("Lembar 2")> Lembar2
    <EnumDescription("Lembar 3")> Lembar3
  End Enum
  Public Enum eTipePPN
    <EnumDescription("Non WAPU")> NP = 0
    <EnumDescription("WAPU")> WP = 1
  End Enum
  Public Enum TipeLOG
    <EnumDescription("Tambah Data")> Add = 0
    <EnumDescription("Edit Data")> Edit = 1
    <EnumDescription("Hapus Data")> Delete = 2
  End Enum
  Public Enum FusohTipeSO
    <EnumDescription("Fix PO")> Fix = 0
    <EnumDescription("Temp PO")> Temp = 1
    <EnumDescription("Close SO")> Close = 2
  End Enum

  <Persistent("a_regional")> Public Class xRegional
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
    Private _coaAR As Int64
    Private _coaAP As Int64

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
    <Persistent("d_coaar")> Property CoaAR As Int64
      Get
        Return _coaAR
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("CoaAR", _coaAR, value)
      End Set
    End Property
    <Persistent("d_coaap")> Property CoaAP As Int64
      Get
        Return _coaAP
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("CoaAP", _coaAP, value)
      End Set
    End Property
  End Class

  <Persistent("m06zlog")> Public Class zLOG
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As UInt64
    Private _komputer As String
    Private _Tipe As Persistent.TipeLOG
    Private _Keterangan As String

    <Persistent("p_id"), Key()> Property Id As UInt64
      Get
        Return _id
      End Get
      Set(value As UInt64)
        SetPropertyValue(Of UInt64)("Id", _id, value)
      End Set
    End Property
    <Persistent("d_komputer"), Size(3)> Property Komputer As String
      Get
        Return _komputer
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Komputer", _komputer, value)
      End Set
    End Property
    <Persistent("d_tipe")> Property TipeLOG As Persistent.TipeLOG
      Get
        Return _Tipe
      End Get
      Set(value As Persistent.TipeLOG)
        SetPropertyValue(Of Persistent.TipeLOG)("TipeLOG", _Tipe, value)
      End Set
    End Property
    <Persistent("d_keterangan")> Property Keterangan As String
      Get
        Return _Keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _Keterangan, value)
      End Set
    End Property
  End Class


  <Persistent("m05ddetailorder")>
  Friend Class OrderPembelianDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _item As NuSoft004.Persistent.Barang
    Private _qty As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _disc As Double
    Private _discp As Double
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _proyek As NuSoft001.Persistent.Proyek
    Private _catatan As String
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("f_uom")>
    Property Satuan As NuSoft004.Persistent.Satuan
      Get
        Return _satuan
      End Get
      Set(value As NuSoft004.Persistent.Satuan)
        SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_qty")>
    Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_price")>
    Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
      End Set
    End Property
    <Persistent("d_disc")>
    Property Discount As Double
      Get
        Return _disc
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Discount", _disc, value)
      End Set
    End Property
    <Persistent("d_discp")>
    Property DiscountPersen As Double
      Get
        Return _discp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DiscountPersen", _discp, value)
      End Set
    End Property
    <Persistent("f_taxin")>
    Property PPN As NuSoft004.Persistent.Pajak
      Get
        Return _ppn
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _ppn, value)
      End Set
    End Property
    <Persistent("d_taxinp")>
    Property PPNp As Double
      Get
        Return _ppnp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPNp", _ppnp, value)
      End Set
    End Property
    <Persistent("f_taxout")>
    Property PPH As NuSoft004.Persistent.Pajak
      Get
        Return _pph
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _pph, value)
      End Set
    End Property
    <Persistent("d_taxoutp")>
    Property PPHp As Double
      Get
        Return _pphp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPHp", _pphp, value)
      End Set
    End Property
    <Persistent("d_remarks")>
    Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("f_division")>
    Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Catatan", _divisi, value)
      End Set
    End Property
    <Persistent("f_proyek")>
    Property Proyek As NuSoft001.Persistent.Proyek
      Get
        Return _proyek
      End Get
      Set(value As NuSoft001.Persistent.Proyek)
        SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
      End Set
    End Property
    <PersistentAlias("(Qty * Harga)-(Qty * Discount)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Order Pembelian [PO]"
      If _item Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _qty = Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class

End Namespace