Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.Utils.CustomAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
	Public Enum JenisBarang
		<EnumDescription("Persediaan")> Persediaan
		<EnumDescription("Jasa")> Jasa
		<EnumDescription("Assembly")> Assembly
	End Enum
	Public Enum TipeBarang
		<EnumDescription("Bahan Jadi")> BahanJadi
		<EnumDescription("Bahan Baku")> BahanBaku
		<EnumDescription("Bahan WIP")> BahanWIP
    <EnumDescription("Jasa")> Jasa
    <EnumDescription("Bahan Pembantu")> BahanPembantu
    <EnumDescription("Bahan Waste")> BahanWaste
  End Enum
  Public Enum eJenisPermintaan
    PermintaanMutasi = 0
    PermintaanPembelian = 1
  End Enum
  Public Enum FusohTipeSO
    <EnumDescription("Fix PO")> Fix = 0
    <EnumDescription("Temp PO")> Temp = 1
    <EnumDescription("Close SO")> Close = 2
  End Enum

  <Persistent("m04acost")> _
  Public Class BiayaLain
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kode As String
    Private _nama As String
    Private _coacost As NuSoft001.Persistent.Coa
    Private _coaincome As NuSoft001.Persistent.Coa

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
    <Persistent("f_coaincome")> Property CoaPendapatan As NuSoft001.Persistent.Coa
      Get
        Return _coaincome
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaPendapatan", _coaincome, value)
      End Set
    End Property
    <Persistent("f_coacost")> Property CoaCost As NuSoft001.Persistent.Coa
      Get
        Return _coacost
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaCost", _coacost, value)
      End Set
    End Property
  End Class
  <Persistent("m04atax")> _
  Public Class Pajak
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kode As String
    Private _nilaipajak As Double

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
    <Persistent("d_valuetax")> Property NilaiPajak As Double
      Get
        Return _nilaipajak
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiPajak", _nilaipajak, value)
      End Set
    End Property
  End Class
  <Persistent("m04auom")> _
  Public Class Satuan
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _kode As String
    Private _nama As String
    Private _nilai As Double
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
    <Persistent("d_value")> Property Nilai As Double
      Get
        Return _nilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _nilai, value)
      End Set
    End Property
  End Class
  <Persistent("m04atype")> _
  Public Class TipeTransaksi
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
      Const source As String = "Tipe Transaksi"
      If _kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode tipe transaksi", -1, "", source)
        Return False
      End If
      If _coaincome Is Nothing Then
        Throw New Utils.Exception("Masukkan COA untuk pendapatan", -2, "", source)
        Return False
      End If
      If _coacost Is Nothing Then
        Throw New Utils.Exception("Masukkan COA untuk HPP", -3, "", source)
        Return False
      End If
      Return True
    End Function

    Private _id As Int32
    Private _kode As String
    Private _coaincome As NuSoft001.Persistent.Coa
    Private _coacost As NuSoft001.Persistent.Coa

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
    <Persistent("f_coaincome")> Property CoaPendapatan As NuSoft001.Persistent.Coa
      Get
        Return _coaincome
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaPendapatan", _coaincome, value)
      End Set
    End Property
    <Persistent("f_coacost")> Property CoaCost As NuSoft001.Persistent.Coa
      Get
        Return _coacost
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaCost", _coacost, value)
      End Set
    End Property
  End Class
  <Persistent("m04awarehouse")> _
  Public Class Gudang
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _kode As String
    Private _nama As String
    Private _alamat As String
    Private _telp As String
    Private _fax As String
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
    <Persistent("d_address")> Property Alamat As String
      Get
        Return _alamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Alamat", _alamat, value)
      End Set
    End Property
    <Persistent("d_telp")> Property NoTelp As String
      Get
        Return _telp
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoTelp", _telp, value)
      End Set
    End Property
    <Persistent("d_fax")> Property NoFax As String
      Get
        Return _fax
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoFax", _fax, value)
      End Set
    End Property
  End Class
  <Persistent("m04bitem")>
  Public Class Barang
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
      Const sumber As String = "Master Item"
      If _Kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -1, "", sumber)
        Return False
      End If
      If _Nama Is Nothing Then
        Throw New Utils.Exception("Masukkan nama barang", -2, "", sumber)
        Return False
      End If
      If _UOM Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan", -3, "", sumber)
        Return False
      End If
      If _UOMD Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan dasar", -4, "", sumber)
        Return False
      End If
      If _Currrency Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -5, "", sumber)
        Return False
      End If
      If _CoaStock Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Persediaan", -7, "", sumber)
        Return False
      End If
      If _CoaIncome Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Pendapatan", -8, "", sumber)
        Return False
      End If
      If _CoaCost Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Biaya [HPP]", -9, "", sumber)
        Return False
      End If
      If _PajakIn Is Nothing Then
        Throw New Utils.Exception("Masukkan Pajak Masukan", -10, "", sumber)
        Return False
      End If
      If _PajakOut Is Nothing Then
        Throw New Utils.Exception("Masukkan Pajak Keluaran", -11, "", sumber)
        Return False
      End If
      Return True
    End Function

    <Indexed("Kode", Unique:=True)>
    Private _Id As Int64
    Private _Kode As String
    Private _Nama As String
    Private _Jenis As JenisBarang
    Private _Tipe As TipeBarang
    Private _UOM As Satuan
    Private _UOMD As Satuan
    Private _Currrency As NuSoft001.Persistent.MataUang
    Private _Currency2 As NPO.Modules.ModSys.Divisi
		Private _HargaFeeAgen As Double
		Private _HargaBeli As Double
		Private _HargaJual1 As Double
    Private _HargaJual2 As Double
    Private _HargaJual3 As Double
    Private _HargaJual4 As Double
    Private _HargaJual5 As Double
    Private _PajakIn As Pajak
    Private _PajakOut As Pajak
    Private _CoaIncome As NuSoft001.Persistent.Coa
    Private _CoaCost As NuSoft001.Persistent.Coa
    Private _CoaStock As NuSoft001.Persistent.Coa
    Private _CoaDiscIn As NuSoft001.Persistent.Coa
    Private _CoaDiscOut As NuSoft001.Persistent.Coa
    Private _CoaReturIn As NuSoft001.Persistent.Coa
    Private _CoaReturOut As NuSoft001.Persistent.Coa
    Private _StockMax As Double
    Private _StockMin As Double
    Private _StockCurrent As Double
    Private _active As Boolean
    Private _stockorder As Double
    Private _kategori As Kategori
    Private _subkategori As SubKategori
    Private _merk As Merk
    Private _note As String
    Private _custom1 As String
    Private _custom2 As String
    Private _custom3 As String
    Private _custom4 As String
    Private _custom5 As String
    Private _custom6 As String
    Private _custom7 As String
    Private _custom8 As String
    Private _custom9 As String
		Private _custom10 As String
		'Private _outDiameter As Decimal
		'Private _inDiameter As Decimal
		'Private _thickness As Decimal
		'Private _length As Decimal

		<Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _Id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _Kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _Kode, value)
      End Set
    End Property
    <Persistent("d_name")> Property Nama As String
      Get
        Return _Nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _Nama, value)
      End Set
    End Property
    <Persistent("f_uom")> Property Satuan As Satuan
      Get
        Return _UOM
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _UOM, value)
      End Set
    End Property
    <Persistent("f_uomd")> Property SatuanD As Satuan
      Get
        Return _UOMD
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("SatuanD", _UOMD, value)
      End Set
    End Property
    <Persistent("d_jenis")> Property Jenis As JenisBarang
      Get
        Return _Jenis
      End Get
      Set(value As JenisBarang)
        SetPropertyValue(Of JenisBarang)("Jenis", _Jenis, value)
      End Set
    End Property
    <Persistent("d_tipe")> Property TipeBarang As TipeBarang
      Get
        Return _Tipe
      End Get
      Set(value As TipeBarang)
        SetPropertyValue(Of TipeBarang)("Jenis", _Tipe, value)
      End Set
    End Property
    <Persistent("f_curency")> Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _Currrency
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _Currrency, value)
      End Set
    End Property
		<Persistent("d_pricelastpurchase")> Property LastPurchase As Double
			Get
				Return _HargaBeli
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("LastPurchase", _HargaBeli, value)
			End Set
		End Property
		<Persistent("d_feeagen")> Property FeeAgen As Double
			Get
				Return _HargaFeeAgen
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("FeeAgen", _hargaFeeAgen, value)
			End Set
		End Property

		<Persistent("d_priceselling1")> Property HargaJual1 As Double
      Get
        Return _HargaJual1
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual1", _HargaJual1, value)
      End Set
    End Property
    <Persistent("d_priceselling2")> Property HargaJual2 As Double
      Get
        Return _HargaJual2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual2", _HargaJual2, value)
      End Set
    End Property
    <Persistent("d_priceselling3")> Property HargaJual3 As Double
      Get
        Return _HargaJual3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual3", _HargaJual3, value)
      End Set
    End Property
    <Persistent("d_priceselling4")> Property HargaJual4 As Double
      Get
        Return _HargaJual4
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual4", _HargaJual4, value)
      End Set
    End Property
    <Persistent("d_priceselling5")> Property HargaJual5 As Double
      Get
        Return _HargaJual5
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual5", _HargaJual5, value)
      End Set
    End Property
    <Persistent("f_taxin")> Property PajakIN As Pajak
      Get
        Return _PajakIn
      End Get
      Set(value As Pajak)
        SetPropertyValue(Of Pajak)("PajakIN", _PajakIn, value)
      End Set
    End Property
    <Persistent("f_taxout")> Property PajakOUT As Pajak
      Get
        Return _PajakOut
      End Get
      Set(value As Pajak)
        SetPropertyValue(Of Pajak)("PajakOUT", _PajakOut, value)
      End Set
    End Property
    <Persistent("f_coaincome")> Property CoaIncome As NuSoft001.Persistent.Coa
      Get
        Return _CoaIncome
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaIncome", _CoaIncome, value)
      End Set
    End Property
    <Persistent("f_coacost")> Property CoaCost As NuSoft001.Persistent.Coa
      Get
        Return _CoaCost
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaCost", _CoaCost, value)
      End Set
    End Property
    <Persistent("f_coastock")> Property CoaStock As NuSoft001.Persistent.Coa
      Get
        Return _CoaStock
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaStock", _CoaStock, value)
      End Set
    End Property
    <Persistent("f_coadiscincome")> Property CoaDiscIncome As NuSoft001.Persistent.Coa
      Get
        Return _CoaDiscIn
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaDiscIncome", _CoaDiscIn, value)
      End Set
    End Property
    <Persistent("f_coadisccost")> Property CoaDiscOut As NuSoft001.Persistent.Coa
      Get
        Return _CoaDiscOut
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaDiscOut", _CoaDiscOut, value)
      End Set
    End Property
    <Persistent("f_coareturnincome")> Property CoaReturnIn As NuSoft001.Persistent.Coa
      Get
        Return _CoaReturIn
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaReturnIn", _CoaReturIn, value)
      End Set
    End Property
    <Persistent("f_coareturncost")> Property CoaReturnOut As NuSoft001.Persistent.Coa
      Get
        Return _CoaReturOut
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaReturnOut", _CoaReturOut, value)
      End Set
    End Property
    <Persistent("d_stockmax")> Property StockMax As Double
      Get
        Return _StockMax
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockMax", _StockMax, value)
      End Set
    End Property
    <Persistent("d_stockmin")> Property StockMin As Double
      Get
        Return _StockMin
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockMin", _StockMin, value)
      End Set
    End Property
    <Persistent("d_stockcurrent")> Property StockCurrent As Double
      Get
        Return _StockCurrent
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockCurrent", _StockCurrent, value)
      End Set
    End Property
    <Persistent("d_aktif")> Property Aktif As Boolean
      Get
        Return _active
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Aktif", _active, value)
      End Set
    End Property
    <Persistent("d_stokreorder")> Property StockOrder As Double
      Get
        Return _stockorder
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockOrder", _stockorder, value)
      End Set
    End Property
    <Persistent("f_kategori")> Property Kategori As Kategori
      Get
        Return _kategori
      End Get
      Set(value As Kategori)
        SetPropertyValue(Of Kategori)("Kategori", _kategori, value)
      End Set
    End Property
    <Persistent("f_subkategori")> Property SubKategori As SubKategori
      Get
        Return _subkategori
      End Get
      Set(value As SubKategori)
        SetPropertyValue(Of SubKategori)("SubKategori", _subkategori, value)
      End Set
    End Property
    <Persistent("f_merk")> Property Merk As Merk
      Get
        Return _merk
      End Get
      Set(value As Merk)
        SetPropertyValue(Of Merk)("Merk", _merk, value)
      End Set
    End Property
    <Persistent("d_note")> Property Note As String
      Get
        Return _note
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Note", _note, value)
      End Set
    End Property
    <Persistent("d_custom1")> Property Custom1 As String
      Get
        Return _custom1
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("HargaJual5", _custom1, value)
      End Set
    End Property
    <Persistent("d_custom2")> Property Custom2 As String
      Get
        Return _custom2
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom2", _custom2, value)
      End Set
    End Property
		<Persistent("d_custom3")> Property Custom3 As String
			Get
				Return _custom3
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom3", _custom3, value)
			End Set
		End Property
		<Persistent("d_custom4")> Property Custom4 As String
			Get
				Return _custom4
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom4", _custom4, value)
			End Set
		End Property
		<Persistent("d_custom5")> Property Custom5 As String
			Get
				Return _custom5
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom5", _custom5, value)
			End Set
		End Property
		<Persistent("d_custom6")> Property Custom6 As String
      Get
        Return _custom6
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom6", _custom6, value)
      End Set
    End Property
    <Persistent("d_custom7")> Property Custom7 As String
      Get
        Return _custom7
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom7", _custom7, value)
      End Set
    End Property
    <Persistent("d_custom8")> Property Custom8 As String
      Get
        Return _custom8
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom8", _custom8, value)
      End Set
    End Property
    <Persistent("d_custom9")> Property Custom9 As String
      Get
        Return _custom9
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom9", _custom9, value)
      End Set
    End Property
		<Persistent("d_custom10")> Property Custom10 As String
			Get
				Return _custom10
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom10", _custom10, value)
			End Set
		End Property
		'<Persistent("d_od")> Property OutDiameter As Decimal
		'	Get
		'		Return _outDiameter
		'	End Get
		'	Set(value As Decimal)
		'		SetPropertyValue(Of Decimal)("OutDiameter", _outDiameter, value)
		'	End Set
		'End Property
		'<Persistent("d_id")> Property InDiameter As Decimal
		'	Get
		'		Return _inDiameter
		'	End Get
		'	Set(value As Decimal)
		'		SetPropertyValue(Of Decimal)("InDiameter", _inDiameter, value)
		'	End Set
		'End Property
		'<Persistent("d_ticknes")> Property Thickness As Decimal
		'	Get
		'		Return _thickness
		'	End Get
		'	Set(value As Decimal)
		'		SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
		'	End Set
		'End Property
		'<Persistent("d_length")> Property Length As Decimal
		'	Get
		'		Return _length
		'	End Get
		'	Set(value As Decimal)
		'		SetPropertyValue(Of Decimal)("Length", _length, value)
		'	End Set
		'End Property

		'<PersistentAlias("concat('OD=', OutDiameter,'; ID=', InDiameter,'; T=',Thickness,'; L=', Length)")> ReadOnly Property Spesifikasi As String
		'	Get
		'		Return EvaluateAlias("Spesifikasi").ToString
		'	End Get
		'End Property

		<Association("fk_item_location"), Aggregated> ReadOnly Property ItemLocation As XPCollection(Of BarangLokasi)
      Get
        Return GetCollection(Of BarangLokasi)("ItemLocation")
      End Get
    End Property
    <Association("fk_item_penyusun"), Aggregated> ReadOnly Property ItemPenyusun As XPCollection(Of BarangAssembly)
      Get
        Return GetCollection(Of BarangAssembly)("ItemPenyusun")
      End Get
    End Property
  End Class

  <Persistent("m04citemlocation")> _
  Public Class BarangLokasi
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _barang As Barang
    Private _gudang As Gudang
    Private _lokasi As String
    <Persistent("primary_main"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_item_location")> Property Barang As Barang
      Get
        Return _barang
      End Get
      Set(value As Barang)
        SetPropertyValue(Of Barang)("Barang", _barang, value)
      End Set
    End Property
    <Persistent("f_warehouse")> Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Telepon", _gudang, value)
      End Set
    End Property
    <Persistent("d_location"), Size(50)> Property Lokasi As String
      Get
        Return _lokasi
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Lokasi", _lokasi, value)
      End Set
    End Property
  End Class
  <Persistent("m04citemassembly")> _
  Public Class BarangAssembly
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _barang As Barang
    Private _barangpenyusun As Barang
    Private _qty As Double
    Private _satuan As Satuan
    Private _catatan As String
    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_item"), Association("fk_item_penyusun")> Property Barang As Barang
      Get
        Return _barang
      End Get
      Set(value As Barang)
        SetPropertyValue(Of Barang)("Barang", _barang, value)
      End Set
    End Property
    <Persistent("f_itemconstituent")> Property BarangPenyusun As Barang
      Get
        Return _barangpenyusun
      End Get
      Set(value As Barang)
        SetPropertyValue(Of Barang)("BarangPenyusun", _barangpenyusun, value)
      End Set
    End Property

    <Persistent("f_uom")> Property Satuan As Satuan
      Get
        Return _satuan
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_qty")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_remarks"), Size(50)> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
  End Class

	<Persistent("m04acategory")>
	Public Class Kategori
		Inherits NPOBase
		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub
		Private _id As Int32
		Private _kode As String
		Private _nama As String

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
	End Class
	<Persistent("m04asubcategory")> _
  Public Class SubKategori
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kode As String
    Private _nama As String
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
  End Class
  <Persistent("m04amerk")> _
  Public Class Merk
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kode As String
    Private _nama As String
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
  End Class


  Public Enum TipeLOG
    <EnumDescription("Tambah Data")> Add = 0
    <EnumDescription("Edit Data")> Edit = 1
    <EnumDescription("Hapus Data")> Delete = 2
  End Enum
  <Persistent("m04zlog")> Public Class zLOG
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
End Namespace
