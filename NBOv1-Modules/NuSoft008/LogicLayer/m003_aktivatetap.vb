Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute

Namespace Persistent
  Public Enum ePenyusutanAsset
    <EnumDescription("Tanpa Penyusutan")> TanpaPenyusutan = 0
    <EnumDescription("Garis Lurus")> GarisLurus = 1
    <EnumDescription("Saldo Menurun")> SaldoMenurun = 2
  End Enum
  Public Enum eTipeTransaksiAsset
    <EnumDescription("Saldo Awal")> SaldoAwal = 0
    <EnumDescription("Pembelian")> Pembelian = 1
    <EnumDescription("Penyusutan")> Penyusutan = 2
    <EnumDescription("Penjualan")> Penjualan = 3
    <EnumDescription("Write Off")> WriteOff = 4
    <EnumDescription("Perbaikan")> Perbaikan = 5
  End Enum

  <Persistent("m02aassettype")> _
  Public Class AktivaKelompok
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub
    Private Function CheckData() As Boolean
      Const sumber As String = "Kelompok Aktiva Tetap"
      If _kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode", -2, "", sumber)
        Return False
      End If
      If TipePenyusutan = ePenyusutanAsset.GarisLurus Or TipePenyusutan = ePenyusutanAsset.SaldoMenurun Then
        If Umur = Nothing Then
          Throw New Utils.Exception("Masukkan Umur", -3, "", sumber)
          Return False
        End If
      End If
      If COAAsset Is Nothing Then
        Throw New Utils.Exception("Masukkan COA Aktiva Tetap", -4, "", sumber)
        Return False
      End If
      If COADepresiasi Is Nothing Then
        Throw New Utils.Exception("Masukkan COA Depresiasi", -5, "", sumber)
        Return False
      End If
      If COAAkumulasiDepr Is Nothing Then
        Throw New Utils.Exception("Masukkan COA Akumulasi Depresiasi", -6, "", sumber)
        Return False
      End If
      If COAWriteOff Is Nothing Then
        Throw New Utils.Exception("Masukkan COA Write Off", -7, "", sumber)
        Return False
      End If
      Return True
    End Function
    Private _id As Int32
    Private _kode As String
    Private _umur As Integer
    Private _tipe As ePenyusutanAsset
    Private _coaasset As Persistent.Coa
    Private _coadepr As Persistent.Coa
    Private _coaakumdepr As Persistent.Coa
    Private _coawriteoff As Persistent.Coa
    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_name")> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_age")> Property Umur As Integer
      Get
        Return _umur
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Umur", _umur, value)
      End Set
    End Property
    <Persistent("d_type")> Property TipePenyusutan As ePenyusutanAsset
      Get
        Return _tipe
      End Get
      Set(value As ePenyusutanAsset)
        SetPropertyValue(Of ePenyusutanAsset)("TipePenyusutan", _tipe, value)
      End Set
    End Property
    <Persistent("f_coaasset")> Property COAAsset As Persistent.Coa
      Get
        Return _coaasset
      End Get
      Set(value As Persistent.Coa)
        SetPropertyValue(Of Persistent.Coa)("Kode", _coaasset, value)
      End Set
    End Property
    <Persistent("f_coadepr")> Property COADepresiasi As Persistent.Coa
      Get
        Return _coadepr
      End Get
      Set(value As Persistent.Coa)
        SetPropertyValue(Of Persistent.Coa)("COADepresiasi", _coadepr, value)
      End Set
    End Property
    <Persistent("f_coaakumdepr")> Property COAAkumulasiDepr As Persistent.Coa
      Get
        Return _coaakumdepr
      End Get
      Set(value As Persistent.Coa)
        SetPropertyValue(Of Persistent.Coa)("COAAkumulasiDepr", _coaakumdepr, value)
      End Set
    End Property
    <Persistent("f_coawriteoff")> Property COAWriteOff As Persistent.Coa
      Get
        Return _coawriteoff
      End Get
      Set(value As Persistent.Coa)
        SetPropertyValue(Of Persistent.Coa)("COAWriteOff", _coawriteoff, value)
      End Set
    End Property
  End Class
  <Persistent("m02bassetview")> _
  Public Class AktivaTetap
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub
    Private Function CheckData() As Boolean
      Const sumber As String = "Aktiva Tetap"
      If _kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode", -2, "", sumber)
        Return False
      End If
      Return True
    End Function
    Private _id As Int32
    Private _kelompok As Persistent.AktivaKelompok
    Private _kode As String
    Private _nama As String
    Private _qtyin As Double
    Private _qtyout As Double
    Private _price As Double
    Private _residu As Double
    Private _nilaibuku As Double
    Private _nilaiamortisasi As Double
    Private _tanggalbeli As Date
    Private _tanggalpakai As Date
    Private _tgl15 As Boolean
    Private _intangible As Boolean
    Private _pembelian As Boolean
    Private _dispose As Boolean
    Private _divisi As NPO.Modules.ModSys.Divisi
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
    <Persistent("d_name")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("f_type")> Property Kelompok As Persistent.AktivaKelompok
      Get
        Return _kelompok
      End Get
      Set(value As Persistent.AktivaKelompok)
        SetPropertyValue(Of Persistent.AktivaKelompok)("Kelompok", _kelompok, value)
      End Set
    End Property
    <Persistent("d_qtyin")> Property Qty As Double
      Get
        Return _qtyin
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qtyin, value)
      End Set
    End Property
    <Persistent("d_qtyout")> Property QtyOut As Double
      Get
        Return _qtyout
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyOut", _qtyout, value)
      End Set
    End Property
    <Persistent("d_price")> Property Harga As Double
      Get
        Return _price
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _price, value)
      End Set
    End Property
    <Persistent("d_residuvalue")> Property NilaiResidu As Double
      Get
        Return _residu
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiResidu", _residu, value)
      End Set
    End Property
    <Persistent("d_bookvalue")> Property NilaiBuku As Double
      Get
        Return _nilaibuku
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBuku", _nilaibuku, value)
      End Set
    End Property
    <Persistent("d_amortisasivalue")> Property NilaiAmortisasi As Double
      Get
        Return _nilaiamortisasi
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiAmortisasi", _nilaiamortisasi, value)
      End Set
    End Property
    <Persistent("d_datepurchase")> Property TanggalBeli As Date
      Get
        Return _tanggalbeli
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBeli", _tanggalbeli, value)
      End Set
    End Property
    <Persistent("d_dateused")> Property TanggalPakai As Date
      Get
        Return _tanggalpakai
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalPakai", _tanggalpakai, value)
      End Set
    End Property
    <Persistent("f_divisi")> Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
      End Set
    End Property
    <Persistent("d_tgl15")> Property Tgl15 As Boolean
      Get
        Return _tgl15
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Tgl15", _tgl15, value)
      End Set
    End Property
    <Persistent("d_intangible")> Property Intangible As Boolean
      Get
        Return _intangible
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Intangible", _intangible, value)
      End Set
    End Property
    <Persistent("d_purchase")> Property Pembelian As Boolean
      Get
        Return _pembelian
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Pembelian", _pembelian, value)
      End Set
    End Property
    <Persistent("d_dispose")> Property Dispose As Boolean
      Get
        Return _dispose
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Dispose", _dispose, value)
      End Set
    End Property
    <Association("fk_asset_depretiation"), Aggregated> ReadOnly Property Depreciation As XPCollection(Of AktivaTetapPenyusutan)
      Get
        Return GetCollection(Of AktivaTetapPenyusutan)("Depreciation")
      End Get
    End Property
  End Class
  <Persistent("m02cassetdepreciation")> _
  Public Class AktivaTetapPenyusutan
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub
    Private Function CheckData() As Boolean
      Const sumber As String = "Aktiva Tetap"
      If _asset Is Nothing Then
        Throw New Utils.Exception("Masukkan Asset terlebih dahulu", -2, "", sumber)
        Return False
      End If
      Return True
    End Function
    Private _id As Int64
    Private _asset As AktivaTetap
    Private _seq As Int32
    Private _year As Int32
    Private _month As Int16
    Private _nilai As Double
    Private _tglawal As Date
    Private _tglakhir As Date
    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_asset"), Association("fk_asset_depretiation")> Property Asset As AktivaTetap
      Get
        Return _asset
      End Get
      Set(value As AktivaTetap)
        SetPropertyValue(Of AktivaTetap)("Asset", _asset, value)
      End Set
    End Property
    <Persistent("d_seq")> Property Sequence As Int32
      Get
        Return _seq
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Sequence", _seq, value)
      End Set
    End Property
    <Persistent("d_year")> Property Year As Int32
      Get
        Return _year
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Year", _year, value)
      End Set
    End Property
    <Persistent("d_month")> Property Month As Int16
      Get
        Return _month
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Month", _month, value)
      End Set
    End Property
    <Persistent("d_value")> Property Nilai As Double
      Get
        Return _nilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _nilai, value)
      End Set
    End Property
    <Persistent("d_begindate")> Property TglAwal As Date
      Get
        Return _tglawal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglAwal", _tglawal, value)
      End Set
    End Property
    <Persistent("d_enddate")> Property TglAkhir As Date
      Get
        Return _tglakhir
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglAkhir", _tglakhir, value)
      End Set
    End Property
    <NonPersistent()> ReadOnly Property Total As Double
      Get
        Return Month * Nilai
      End Get
    End Property
  End Class

End Namespace