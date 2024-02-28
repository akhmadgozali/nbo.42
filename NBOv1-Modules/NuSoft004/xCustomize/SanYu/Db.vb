Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.Modules.ModSys
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports NuSoft.Utils.CustomAttribute
Namespace SanYuLogic
  Public Class Item
    Public Shared Function GetWeight(outDiameter As Decimal, length As Decimal, thick As Decimal) As Decimal
      Dim result As Double
      If thick > 0 Then
        result = ((outDiameter - thick) * thick * 0.02466)
      Else
        result = ((outDiameter * outDiameter) * 0.00617)
      End If

      Select Case result
        Case Is < 1 : result = CDec(Math.Round(result, 3))
        Case 1 To 9 : result = CDec(Math.Round(result, 2))
        Case 10 To 99 : result = CDec(Math.Round(result, 1))
        Case Else : result = CDec(Math.Round(result, 0))
      End Select

      Return CDec((result * length) / 1000)
    End Function
    Public Shared Function GetRemainStock(session As UnitOfWork, item As Persistent.SanYu_Barang) As Double
      Dim stok = New XPQuery(Of Persistent.SanYu_StokDetail)(session).Where(Function(w) w.Barang Is item)
      Return stok.Sum(Function(s) s.QtyIn) - stok.Sum(Function(s) s.QtyOut)
    End Function
  End Class
  Public Class Stock
    Public Sub showDataProduksi(xMenuID As Integer, xNamaDatabase As String, session As UnitOfWork, xIDStockPembelian As Int64)
      Dim frm As New UI_SanyuDataProduksi(xIDStockPembelian)
      frm.MenuId = xMenuID
      frm.NamaDatabase = xNamaDatabase
      frm.session = session
      frm.ShowDialog()
    End Sub
    Public Sub showDataProduksiLOT(xMenuID As Integer, xNamaDatabase As String, session As UnitOfWork, xIDStockProduksi As Int64)
      Dim frm As New UI_SanyuDataProduksi2(xIDStockProduksi)
      frm.MenuId = xMenuID
      frm.NamaDatabase = xNamaDatabase
      frm.session = session
      frm.ShowDialog()
    End Sub
  End Class
End Namespace

Namespace Persistent
  Public Enum eSanYuJenisPenjualan
    <EnumDescription("Pce")> pPce = 0
    <EnumDescription("Meter")> pMeter = 1
    <EnumDescription("Feet")> pFeet = 2
  End Enum

  <Persistent("m04bitem")>
  Public Class SanYu_Barang
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
      If _outDiameter = 0 Then
        Throw New Utils.Exception("Masukkan Out Diameter", -12, "", sumber)
        Return False
      End If
      If _inDiameter = 0 Then
        Throw New Utils.Exception("Masukkan In Diameter", -13, "", sumber)
        Return False
      End If
      'If _thickness = 0 Then
      '	Throw New Utils.Exception("Masukkan Thickness", -13, "", sumber)
      '	Return False
      'End If
      If _length = 0 Then
        Throw New Utils.Exception("Masukkan Length", -14, "", sumber)
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
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _customer As Kontak
    Private _gambar As Byte()
    Private _kite As Boolean

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
    <Persistent("d_od")> Property OutDiameter As Decimal
      Get
        Return _outDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("OutDiameter", _outDiameter, value)
      End Set
    End Property
    <Persistent("d_id")> Property InDiameter As Decimal
      Get
        Return _inDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("InDiameter", _inDiameter, value)
      End Set
    End Property
    <Persistent("d_ticknes")> Property Thickness As Decimal
      Get
        Return _thickness
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
      End Set
    End Property
    <Persistent("d_length")> Property Length As Decimal
      Get
        Return _length
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Length", _length, value)
      End Set
    End Property
    <Persistent("d_weight")> Property Weight As Decimal
      Get
        Return _weight
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Weight", _weight, value)
      End Set
    End Property
    <Persistent("f_customer")> Property Customer As Kontak
      Get
        Return _customer
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Customer", _customer, value)
      End Set
    End Property
    <Persistent("d_kite")> Property KITE As Boolean
      Get
        Return _kite
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("KITE", _kite, value)
      End Set
    End Property
    '<Persistent("d_picture")> Property Gambar As Byte()
    '  Get
    '    Return _gambar
    '  End Get
    '  Set(ByVal value As Byte())
    '    SetPropertyValue(Of Byte())("Blob", _gambar, value)
    '  End Set
    'End Property
    '<NonPersistent()> Property Image As System.Drawing.Image
    '  Get
    '    If Gambar Is Nothing Then
    '      Return Nothing
    '    Else
    '      Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(_gambar)
    '      Dim returnImage As System.Drawing.Image = Drawing.Image.FromStream(ms)
    '      Return returnImage
    '    End If
    '  End Get
    '  Set(ByVal value As System.Drawing.Image)
    '    Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
    '    value.Save(ms, value.RawFormat)
    '    Gambar = ms.ToArray
    '  End Set
    'End Property
    <Association("fk_Sanyu_item_location"), Aggregated> ReadOnly Property ItemLocation As XPCollection(Of SanYu_BarangLokasi)
      Get
        Return GetCollection(Of SanYu_BarangLokasi)("ItemLocation")
      End Get
    End Property
    <Association("fk_Sanyu_item_penyusun"), Aggregated> ReadOnly Property ItemPenyusun As XPCollection(Of SanYu_BarangAssembly)
      Get
        Return GetCollection(Of SanYu_BarangAssembly)("ItemPenyusun")
      End Get
    End Property
  End Class
  <Persistent("m04citemlocation")>
  Public Class SanYu_BarangLokasi
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _barang As SanYu_Barang
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
    <Persistent("p_id"), Association("fk_Sanyu_item_location")> Property Barang As SanYu_Barang
      Get
        Return _barang
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("Barang", _barang, value)
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
  <Persistent("m04citemassembly")>
  Public Class SanYu_BarangAssembly
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _barang As SanYu_Barang
    Private _barangpenyusun As SanYu_Barang
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
    <Persistent("f_item"), Association("fk_Sanyu_item_penyusun")> Property Barang As SanYu_Barang
      Get
        Return _barang
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("Barang", _barang, value)
      End Set
    End Property
    <Persistent("f_itemconstituent")> Property BarangPenyusun As SanYu_Barang
      Get
        Return _barangpenyusun
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("BarangPenyusun", _barangpenyusun, value)
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
  Friend Class SanYu_BarangImporTemp
    Property Kode As String
    Property Nama As String
    Property Kategori As Kategori
    Property Jenis As JenisBarang
    Property Tipe As TipeBarang
    Property Satuan As Satuan
    Property Tebal As Decimal
    Property Lebar As Decimal
    Property Panjang As Decimal
    Property FasilitasKite As Boolean
    Property sKategori As Integer
    Property sJenis As Integer
    Property sTipe As Integer
    Property sSatuan As Integer
  End Class

  <Persistent("m04aprosesproduksi")>
  Public Class SanYu_ProsesProduksi
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
    Private _mutasi As Boolean
    Private _finish As Boolean
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
    <Persistent("d_nama")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("d_mutasi")> Property Mutasi As Boolean
      Get
        Return _mutasi
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Nama", _mutasi, value)
      End Set
    End Property
    <Persistent("d_finish")> Property Finish As Boolean
      Get
        Return _finish
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Nama", _finish, value)
      End Set
    End Property
  End Class

  <Persistent("m04crencanaproduksimain")> Friend Class SanYu_RencanaProduksi
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _reffno As String
    Private _idso As Persistent.SanYu_OrderPenjualan

    <Persistent("f_contact")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("d_nodocument")> Property ReffNo As String
      Get
        Return _reffno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ReffNo", _reffno, value)
      End Set
    End Property
    <Persistent("f_idso")> Property OrderPenjualan As Persistent.SanYu_OrderPenjualan
      Get
        Return _idso
      End Get
      Set(value As Persistent.SanYu_OrderPenjualan)
        SetPropertyValue(Of Persistent.SanYu_OrderPenjualan)("OrderPenjualan", _idso, value)
      End Set
    End Property

    <Association("fk_sanyurencanaproduksi_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_RencanaProduksiDetail)
      Get
        Return GetCollection(Of SanYu_RencanaProduksiDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Rencana Produksi"
      If IsDeleted Then
        Return True
      End If
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Pelanggan Is Nothing AndAlso Sumber.Id <> SumberDataJenis.BS Then
        Throw New Utils.Exception("Masukkan pelangan", -3, "", source)
        Return False
      End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -6, "", source)
          Return False
        End If
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m04drencanaproduksidetail")> Friend Class SanYu_RencanaProduksiDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_RencanaProduksi
    Private _idso As SanYu_OrderPenjualanDetail
    Private _item As SanYu_Barang
    Private _qty As Double
    Private _itembaku As SanYu_Barang
    Private _qtybaku As Double
    Private _ukuran As String
    Private _panjang As Double
    Private _lebar As Double
    Private _tebal As Double
    Private _mutasi As Boolean

    Private _idmutasi As SanYu_StokMain
    Private _idstockperoduksi As SanYu_StokMain
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_sanyurencanaproduksi_detail")> Property Main As SanYu_RencanaProduksi
      Get
        Return _main
      End Get
      Set(value As SanYu_RencanaProduksi)
        SetPropertyValue(Of SanYu_RencanaProduksi)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_so")> Property OrderPenjualan As SanYu_OrderPenjualanDetail
      Get
        Return _idso
      End Get
      Set(value As SanYu_OrderPenjualanDetail)
        SetPropertyValue(Of SanYu_OrderPenjualanDetail)("OrderPenjualan", _idso, value)
      End Set
    End Property

    <Persistent("f_item")> Property Barang As SanYu_Barang
      Get
        Return _item
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("Barang", _item, value)
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
    <Persistent("f_itembaku")> Property BahanBaku As SanYu_Barang
      Get
        Return _itembaku
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("BahanBaku", _itembaku, value)
      End Set
    End Property
    <Persistent("d_qtybaku")> Property QtyBaku As Double
      Get
        Return _qtybaku
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyBaku", _qtybaku, value)
      End Set
    End Property
    <Persistent("d_p")> Property Panjang As Double
      Get
        Return _panjang
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Panjang", _panjang, value)
      End Set
    End Property
    <Persistent("d_l")> Property Lebar As Double
      Get
        Return _lebar
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Lebar", _lebar, value)
      End Set
    End Property
    <Persistent("d_t")> Property Tebal As Double
      Get
        Return _tebal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tebal", _tebal, value)
      End Set
    End Property
    <Persistent("d_ukuran")> Property Ukuran As String
      Get
        Return _ukuran
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("String", _ukuran, value)
      End Set
    End Property
    <Persistent("d_mutasibahanbaku")> Property Mutasi As Boolean
      Get
        Return _mutasi
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Mutasi", _mutasi, value)
      End Set
    End Property
    <Persistent("f_mutasi")> Property MutasiID As SanYu_StokMain
      Get
        Return _idmutasi
      End Get
      Set(value As SanYu_StokMain)
        SetPropertyValue(Of SanYu_StokMain)("MutasiID", _idmutasi, value)
      End Set
    End Property
    <Persistent("f_hasil")> Property ProduksiID As SanYu_StokMain
      Get
        Return _idstockperoduksi
      End Get
      Set(value As SanYu_StokMain)
        SetPropertyValue(Of SanYu_StokMain)("ProduksiID", _idstockperoduksi, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Rencana Produksi"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama Rencana Produksi", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
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

  <Persistent("m04eproduksimain")> Friend Class SanYu_ProduksiMain
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _rencanaproduksidetail As SanYu_RencanaProduksiDetail
    Private _f_item As Persistent.SanYu_Barang
    Private _f_itembaku As Persistent.SanYu_Barang
    Private _f_idpembelian As Persistent.SanYu_StokDetail
    Private _f_so As Persistent.SanYu_OrderPenjualanDetail
    Private _f_proses As Persistent.SanYu_ProsesProduksi
    Private _d_statusgudang As Int32
    Private _f_stockfinish As Persistent.SanYu_StokMain
    Private _f_stockid As Persistent.SanYu_StokMain
    Private _f_produksisebelumnya As Persistent.SanYu_ProduksiMain

    Private _itemwaste As Persistent.SanYu_Barang
    Private _bahanbakum3 As Double
    Private _bahanbakutonase As Double
    Private _bahanjadim3 As Double
    Private _bahanjaditonase As Double
    Private _bahanwastem3 As Double
    Private _bahanwastetonase As Double
    Private _bahanpembantum3 As Double
    Private _bahanpembantutonase As Double
    Private _batchno As String

    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("f_contact")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("f_idrencanadetail")> Property RencanaProduksi As Persistent.SanYu_RencanaProduksiDetail
      Get
        Return _rencanaproduksidetail
      End Get
      Set(value As Persistent.SanYu_RencanaProduksiDetail)
        SetPropertyValue(Of NuSoft004.Persistent.SanYu_RencanaProduksiDetail)("RencanaProduksi", _rencanaproduksidetail, value)
      End Set
    End Property
    <Persistent("f_item")> Property ItemJadi As SanYu_Barang
      Get
        Return _f_item
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("ItemJadi", _f_item, value)
      End Set
    End Property
    <Persistent("f_itembaku")> Property ItemBaku As SanYu_Barang
      Get
        Return _f_itembaku
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("ItemBaku", _f_itembaku, value)
      End Set
    End Property
    <Persistent("f_idpembelian")> Property PenerimaanBarang As SanYu_StokDetail
      Get
        Return _f_idpembelian
      End Get
      Set(value As SanYu_StokDetail)
        SetPropertyValue(Of SanYu_StokDetail)("PenerimaanBarang", _f_idpembelian, value)
      End Set
    End Property
    <Persistent("f_so")> Property OrderPenjualan As SanYu_OrderPenjualanDetail
      Get
        Return _f_so
      End Get
      Set(value As SanYu_OrderPenjualanDetail)
        SetPropertyValue(Of SanYu_OrderPenjualanDetail)("OrderPenjualan", _f_so, value)
      End Set
    End Property
    <Persistent("f_proses")> Property Proses As SanYu_ProsesProduksi
      Get
        Return _f_proses
      End Get
      Set(value As SanYu_ProsesProduksi)
        SetPropertyValue(Of SanYu_ProsesProduksi)("Proses", _f_proses, value)
      End Set
    End Property
    <Persistent("d_statusgudang")> Property StatusGudang As Int32
      Get
        Return _d_statusgudang
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("StatusGudang", _d_statusgudang, value)
      End Set
    End Property
    <Persistent("f_stockproses")> Property StockProses As SanYu_StokMain
      Get
        Return _f_stockid
      End Get
      Set(value As SanYu_StokMain)
        SetPropertyValue(Of SanYu_StokMain)("MutasiID", _f_stockid, value)
      End Set
    End Property
    <Persistent("f_stockfinish")> Property StockHasil As SanYu_StokMain
      Get
        Return _f_stockfinish
      End Get
      Set(value As SanYu_StokMain)
        SetPropertyValue(Of SanYu_StokMain)("StockHasil", _f_stockfinish, value)
      End Set
    End Property
    <Persistent("f_produksisebelumnya")> Property ProduksiSebelumnya As SanYu_ProduksiMain
      Get
        Return _f_produksisebelumnya
      End Get
      Set(value As SanYu_ProduksiMain)
        SetPropertyValue(Of SanYu_ProduksiMain)("ProduksiSebelumnya", _f_produksisebelumnya, value)
      End Set
    End Property

    'hitungan finish produksi
    <Persistent("f_itemwaste")> Property ItemWaste As SanYu_Barang
      Get
        Return _itemwaste
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("ItemWaste", _itemwaste, value)
      End Set
    End Property

    <Persistent("d_bahanbaku")> Property BahanBakuM3 As Double
      Get
        Return _bahanbakum3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanBakuM3", _bahanbakum3, value)
      End Set
    End Property
    <Persistent("d_bahanbakutn")> Property BahanBakuTonase As Double
      Get
        Return _bahanbakutonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanBakuTonase", _bahanbakutonase, value)
      End Set
    End Property
    <Persistent("d_bahanjadi")> Property BahanJadiM3 As Double
      Get
        Return _bahanjadim3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanJadiM3", _bahanjadim3, value)
      End Set
    End Property
    <Persistent("d_bahanjaditn")> Property BahanJadiTonase As Double
      Get
        Return _bahanjaditonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanJadiTonase", _bahanjaditonase, value)
      End Set
    End Property
    <Persistent("d_bahanwaste")> Property BahanWasteM3 As Double
      Get
        Return _bahanwastem3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanWasteM3", _bahanwastem3, value)
      End Set
    End Property
    <Persistent("d_bahanwastetn")> Property BahanWasteTonase As Double
      Get
        Return _bahanwastetonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanWasteTonase", _bahanwastetonase, value)
      End Set
    End Property
    <Persistent("d_bahanpembantu")> Property BahanPembantuM3 As Double
      Get
        Return _bahanpembantum3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanPembantuM3", _bahanpembantum3, value)
      End Set
    End Property
    <Persistent("d_bahanpembantutn")> Property BahanPembantuTonase As Double
      Get
        Return _bahanpembantutonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanPembantuTonase", _bahanpembantutonase, value)
      End Set
    End Property
    <Persistent("d_batchno")> Property BatchNo As String
      Get
        Return _batchno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("BatchNo", _batchno, value)
      End Set
    End Property

    <Association("fk_sanyuproduksi_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_ProduksiDetail)
      Get
        Return GetCollection(Of SanYu_ProduksiDetail)("Detail")
      End Get
    End Property
    <Association("fk_sanyuproduksi_pembantu"), Aggregated> ReadOnly Property Pembantu As XPCollection(Of SanYu_ProduksiPembantu)
      Get
        Return GetCollection(Of SanYu_ProduksiPembantu)("Pembantu")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalVolume As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalVolume"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Pelanggan Is Nothing AndAlso Sumber.Id <> SumberDataJenis.BS Then
        Throw New Utils.Exception("Masukkan pelangan", -3, "", source)
        Return False
      End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -6, "", source)
          Return False
        End If
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m04fproduksidetail")> Friend Class SanYu_ProduksiDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_ProduksiMain
    Private _qty As Double
    Private _qty2 As Double
    Private _ukuran As String
    Private _keterangan As String
    Private _panjang As Double
    Private _lebar As Double
    Private _tebal As Double
    Private _idpembelian As Persistent.SanYu_StokDetail
    Private _xn As Boolean
    Private _tonase As Double
    Private _f As Boolean
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_sanyuproduksi_detail")> Property Main As SanYu_ProduksiMain
      Get
        Return _main
      End Get
      Set(value As SanYu_ProduksiMain)
        SetPropertyValue(Of SanYu_ProduksiMain)("Main", _main, value)
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
    <Persistent("d_qty2")> Property QtyPcs As Double
      Get
        Return _qty2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyPcs", _qty2, value)
      End Set
    End Property
    <Persistent("d_ukuran")> Property Ukuran As String
      Get
        Return _ukuran
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Ukuran", _ukuran, value)
      End Set
    End Property
    <Persistent("d_p")> Property Panjang As Double
      Get
        Return _panjang
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Panjang", _panjang, value)
      End Set
    End Property
    <Persistent("d_l")> Property Lebar As Double
      Get
        Return _lebar
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Lebar", _lebar, value)
      End Set
    End Property
    <Persistent("d_t")> Property Tebal As Double
      Get
        Return _tebal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tebal", _tebal, value)
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
    <Persistent("f_idpembelian")> Property Pembelian As Persistent.SanYu_StokDetail
      Get
        Return _idpembelian
      End Get
      Set(value As Persistent.SanYu_StokDetail)
        SetPropertyValue(Of Persistent.SanYu_StokDetail)("Pembelian", _idpembelian, value)
      End Set
    End Property
    <Persistent("d_n")> Property xN As Boolean
      Get
        Return _xn
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("xNew", _xn, value)
      End Set
    End Property
    <Persistent("d_tonase")> Property Tonase As Double
      Get
        Return _tonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tonase", _tonase, value)
      End Set
    End Property

    <PersistentAlias("Qty * (Pembelian.Tonase / Pembelian.QtyIn)")> ReadOnly Property TonaseP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TonaseP"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
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
  <Persistent("m04fproduksipembantu")> Friend Class SanYu_ProduksiPembantu
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_ProduksiMain
    Private _barang As SanYu_Barang
    Private _qty As Double
    Private _satuan As Persistent.Satuan
    Private _keterangan As String
    Private _idpembelian As Persistent.SanYu_StokDetail
    Private _xn As Boolean
    Private _tonase As Double
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_sanyuproduksi_pembantu")> Property Main As SanYu_ProduksiMain
      Get
        Return _main
      End Get
      Set(value As SanYu_ProduksiMain)
        SetPropertyValue(Of SanYu_ProduksiMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As SanYu_Barang
      Get
        Return _barang
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("Barang", _barang, value)
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
    <Persistent("f_uom")> Property Satuan As Persistent.Satuan
      Get
        Return _satuan
      End Get
      Set(value As Persistent.Satuan)
        SetPropertyValue(Of Persistent.Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
    <Persistent("f_idpembelian")> Property Pembelian As Persistent.SanYu_StokDetail
      Get
        Return _idpembelian
      End Get
      Set(value As Persistent.SanYu_StokDetail)
        SetPropertyValue(Of Persistent.SanYu_StokDetail)("Pembelian", _idpembelian, value)
      End Set
    End Property
    <Persistent("d_n")> Property xN As Boolean
      Get
        Return _xn
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("xN", _xn, value)
      End Set
    End Property
    <Persistent("d_tonase")> Property Tonase As Double
      Get
        Return _tonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tonase", _tonase, value)
      End Set
    End Property
    <PersistentAlias("Qty * (Pembelian.Tonase / Pembelian.QtyIn)")> ReadOnly Property TonaseP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TonaseP"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
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

  <Persistent("m04cstockmain")> Friend Class SanYu_StokMain
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _gudang As Gudang
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _kontakperson As String
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _gudang2 As Gudang
    'Private _dempyouLot As String
    Private _batchno As String
    Private _gl As GlMain

    <Persistent("f_contact")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("f_warehouse")> Property Gudang As NuSoft004.Persistent.Gudang
      Get
        Return _gudang
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Catatan As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("d_person")> Property KontakPerson As String
      Get
        Return _kontakperson
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
      End Set
    End Property
    <Persistent("f_employee")> Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _karyawan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _karyawan, value)
      End Set
    End Property
    <Persistent("f_warehouse2")> Property Gudang2 As Gudang
      Get
        Return _gudang2
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang2", _gudang2, value)
      End Set
    End Property
    <Persistent("d_batchno")> Property BatchNo As String
      Get
        Return _batchno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("BatchNo", _batchno, value)
      End Set
    End Property
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property

    <Association("fk_Sanyustokmain_Sanyustokdetail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_StokDetail)
      Get
        Return GetCollection(Of SanYu_StokDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(QtyIn)")> ReadOnly Property TotalQtyIn As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQtyIn"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(QtyOut)")> ReadOnly Property TotalQtyOut As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQtyOut"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Stock Main"
      If IsDeleted Then
        Return True
      End If
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Pelanggan Is Nothing AndAlso Sumber.Id <> SumberDataJenis.BS Then
        Throw New Utils.Exception("Masukkan pelangan", -3, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -4, "", source)
        Return False
      End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -6, "", source)
          Return False
        End If
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      For i = 0 To Detail.Count - 1
        If Detail(i).Gudang Is Nothing Then
          Detail(i).Gudang = _gudang
        End If
      Next
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m04dstockdetail")> Friend Class SanYu_StokDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_StokMain
    Private _order As Int16
    Private _gudang As Gudang
    Private _gudang2 As Gudang
    Private _item As SanYu_Barang
    Private _satuan As Satuan
    Private _qtyIn As Double
    Private _qtyOut As Double
    Private _harga As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _catatan As String
    Private _TotalHPP As Double
    Private _tonase As Double
    Private _produksiDetail As SanYu_StokDetail
    Private _noPIB As Persistent.SanYu_PIBDetail
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_Sanyustokmain_Sanyustokdetail")> Property Main As SanYu_StokMain
      Get
        Return _main
      End Get
      Set(value As SanYu_StokMain)
        SetPropertyValue(Of SanYu_StokMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("d_order")> Property Urutan As Int16
      Get
        Return _order
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Urutan", _order, value)
      End Set
    End Property
    <Persistent("f_warehouse")> Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("f_warehouse2")> Property Gudang2 As Gudang
      Get
        Return _gudang2
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang2, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As SanYu_Barang
      Get
        Return _item
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("Barang", _item, value)
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
    <Persistent("d_qtyin")> Property QtyIn As Double
      Get
        Return _qtyIn
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyIn", _qtyIn, value)
      End Set
    End Property
    <Persistent("d_qtyout")> Property QtyOut As Double
      Get
        Return _qtyOut
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyOut", _qtyOut, value)
      End Set
    End Property
    <Persistent("d_price")> Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
      End Set
    End Property
    <Persistent("d_od")> Property OutDiameter As Decimal
      Get
        Return _outDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("OutDiameter", _outDiameter, value)
      End Set
    End Property
    <Persistent("d_id")> Property InDiameter As Decimal
      Get
        Return _inDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("InDiameter", _inDiameter, value)
      End Set
    End Property
    <Persistent("d_tickness")> Property Thickness As Decimal
      Get
        Return _thickness
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
      End Set
    End Property
    <Persistent("d_length")> Property Length As Decimal
      Get
        Return _length
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Length", _length, value)
      End Set
    End Property
    <Persistent("d_weight")> Property Weight As Decimal
      Get
        Return _weight
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Weight", _weight, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("d_hpp")> Property TotalHPP As Double
      Get
        Return _TotalHPP
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalHPP", _TotalHPP, value)
      End Set
    End Property

    <Persistent("f_idproduksid")> Property ProduksiDetail As SanYu_StokDetail
      Get
        Return _produksiDetail
      End Get
      Set(value As SanYu_StokDetail)
        SetPropertyValue(Of SanYu_StokDetail)("ProduksiDetail", _produksiDetail, value)
      End Set
    End Property
    <Persistent("f_idpib")>
    Property NoPIB As Persistent.SanYu_PIBDetail
      Get
        Return _noPIB
      End Get
      Set(value As Persistent.SanYu_PIBDetail)
        SetPropertyValue(Of Persistent.SanYu_PIBDetail)("NoPIB", _noPIB, value)
      End Set
    End Property
    <PersistentAlias("Serial.Sum(LengthIn)")> ReadOnly Property TotalLengthIn As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalLengthIn"))
      End Get
    End Property
    <PersistentAlias("Serial.Sum(LengthOut)")> ReadOnly Property TotalLengthOut As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalLengthOut"))
      End Get
    End Property
    <PersistentAlias("Serial.Sum(LengthIn-LengthOut)")> ReadOnly Property TotalLength As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalLength"))
      End Get
    End Property
    <Persistent("d_tonase")>
    Property Tonase As Double
      Get
        Return _tonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tonase", _tonase, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
        Return False
      End If
      If _gudang Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan kode gudang", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _satuan Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan barang", -99, "", source)
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
  '<Persistent("m04estockhpp")>
  'Friend Class Sanyu_StockDetailHPPReff
  '  Inherits NPOBase
  '  Public Sub New(ByVal session As UnitOfWork)
  '    MyBase.New(session)
  '  End Sub
  '  Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '    MyBase.New(session, classInfo)
  '  End Sub
  '  Private _id As Int64
  '  Private _detail As Persistent.SanYu_StokDetail
  '  Private _detailIN As Persistent.SanYu_StokDetail
  '  Private _qty As Double
  '  <Persistent("p_id"), Key(True)>
  '  Property Id As Int64
  '    Get
  '      Return _id
  '    End Get
  '    Set(value As Int64)
  '      SetPropertyValue(Of Int64)("Id", _id, value)
  '    End Set
  '  End Property
  '  <Persistent("f_idout"), Association("fk_stock_detail_hpp")>
  '  Property Detail As SanYu_StokDetail
  '    Get
  '      Return _detail
  '    End Get
  '    Set(value As SanYu_StokDetail)
  '      SetPropertyValue(Of SanYu_StokDetail)("Main", _detail, value)
  '    End Set
  '  End Property
  '  <Persistent("f_idin")>
  '  Property DetailIN As SanYu_StokDetail
  '    Get
  '      Return _detailIN
  '    End Get
  '    Set(value As SanYu_StokDetail)
  '      SetPropertyValue(Of SanYu_StokDetail)("DetailIN", _detailIN, value)
  '    End Set
  '  End Property
  '  <Persistent("d_qty")>
  '  Property Qty As Double
  '    Get
  '      Return _qty
  '    End Get
  '    Set(value As Double)
  '      SetPropertyValue(Of Double)("Qty", _qty, value)
  '    End Set
  '  End Property
  '  <PersistentAlias("Qty * (DetailIN.HargaIn * DetailIN.Main.Kurs)")> ReadOnly Property NilaiHPP As Double
  '    Get
  '      Return Convert.ToDouble(EvaluateAlias("NilaiHPP"))
  '    End Get
  '  End Property

  '  Private Function CheckData() As Boolean
  '    Dim source As String = "Stock HPP Reff"
  '    If _detail Is Nothing AndAlso Not IsDeleted Then
  '      Throw New Utils.Exception("Masukkan data detail stock", -99, "", source)
  '      Return False
  '    End If
  '    If Qty = 0 Then
  '      Throw New Utils.Exception("Masukkan Qty Barang", -99, "", source)
  '      Return False
  '    End If
  '    Return True
  '  End Function
  '  Protected Overrides Sub OnSaving()
  '    If Not CheckData() Then
  '      Return
  '    End If
  '    MyBase.OnSaving()
  '  End Sub
  'End Class

  'm006
  <Persistent("m06dmainorder")> Friend Class SanYu_OrderPenjualan
    Inherits TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _customer As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _kontakalamat As NuSoft001.Persistent.KontakAlamat
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _tanggalBerlakuAwal As Date
    Private _tanggalBerlakuAkhir As Date
    Private _termin As NuSoft005.Persistent.Termin
    Private _termOfPrice As String
    Private _payment As String
    Private _inspection As String
    Private _catatan As String
    Private _nomorPO As String
    Private _uraian As String
    Private _via As NuSoft005.Persistent.Via
    Private _statusproduksi As Boolean

    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("d_statusproduksi")> Property StatusProduksi As Boolean
      Get
        Return _statusproduksi
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("StatusProduksi", _statusproduksi, value)
      End Set
    End Property
    <Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
      End Set
    End Property
    <Persistent("f_address")> Property Alamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _kontakalamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("Alamat", _kontakalamat, value)
      End Set
    End Property
    <Persistent("d_contact")> Property KontakPerson As String
      Get
        Return _kontakperson
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
      End Set
    End Property
    <Persistent("f_currency")>
    Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
      End Set
    End Property
    <Persistent("d_kurs")> Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As NuSoft005.Persistent.eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As NuSoft005.Persistent.eTipePajak)
        SetPropertyValue(Of NuSoft005.Persistent.eTipePajak)("Pajak", _pajak, value)
      End Set
    End Property
    <Persistent("f_via")> Property Via As NuSoft005.Persistent.Via
      Get
        Return _via
      End Get
      Set(value As NuSoft005.Persistent.Via)
        SetPropertyValue(Of NuSoft005.Persistent.Via)("Via", _via, value)
      End Set
    End Property
    <Persistent("d_efectivedate1")> Property TanggalBerlakuAwal As Date
      Get
        Return _tanggalBerlakuAwal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerlakuAwal", _tanggalBerlakuAwal, value)
      End Set
    End Property
    <Persistent("d_efectivedate2")> Property TanggalBerlakuAkhir As Date
      Get
        Return _tanggalBerlakuAkhir
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerlakuAkhir", _tanggalBerlakuAkhir, value)
      End Set
    End Property
    <Persistent("f_termin")> Property Termin As NuSoft005.Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As NuSoft005.Persistent.Termin)
        SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
      End Set
    End Property

    <Persistent("d_termofprice")> Property TermOfPrice As String
      Get
        Return _termOfPrice
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TermOfPrice", _termOfPrice, value)
      End Set
    End Property
    <Persistent("d_payment")> Property Payment As String
      Get
        Return _payment
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Payment", _payment, value)
      End Set
    End Property
    <Persistent("d_inspection")> Property Inspection As String
      Get
        Return _inspection
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Inspection", _inspection, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Uraian As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("d_nomorpo")> Property NomorPO As String
      Get
        Return _nomorPO
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorPO", _nomorPO, value)
      End Set
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPNv)")> ReadOnly Property PPN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPN"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPHv)")> ReadOnly Property PPH As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPH"))
      End Get
    End Property
    <PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
      Get
        Return Convert.ToString(EvaluateAlias("Terbilang"))
      End Get
    End Property
    <PersistentAlias("TerbilangEnglish(Total)")> ReadOnly Property TerbilangEnglish As String
      Get
        Return Convert.ToString(EvaluateAlias("TerbilangEnglish"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
      Get
        Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
      End Get
    End Property

    <Association("fk_sanyu_orderpenjualandetail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_OrderPenjualanDetail)
      Get
        Return GetCollection(Of SanYu_OrderPenjualanDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Order Penjualan [SO]"
      If IsDeleted Then
        Return True
      End If
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan customer", -4, "", source)
        Return False
      End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
      End If
      If String.IsNullOrEmpty(NomorPO) Then
        Throw New Utils.Exception("Masukkan nomor PO pelanggan", -7, "", source)
      End If
      If TotalQty = Nothing Then
        Throw New Utils.Exception("Masukkan qty barang", -99, "", source)
      End If
      If Total = Nothing Then
        Throw New Utils.Exception("Total order tidak boleh 0", -99, "", source)
      End If

      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
          Return False
        End If
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m06edetailorder")> Friend Class SanYu_OrderPenjualanDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_OrderPenjualan
    Private _item As NuSoft004.Persistent.SanYu_Barang
    Private _thickness As Decimal
    Private _qty As Double
    Private _qtypcs As Double
    Private _harga As Double
    Private _catatan As String
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _namaBarang As String
    Private _satuan As NuSoft004.Persistent.Satuan

    Private _jenispenjualan As eSanYuJenisPenjualan
    <Persistent("d_jenispenjualan")> Property JenisPenjualan As eSanYuJenisPenjualan
      Get
        Return _jenispenjualan
      End Get
      Set(value As eSanYuJenisPenjualan)
        SetPropertyValue(Of eSanYuJenisPenjualan)("JenisPenjuaan", _jenispenjualan, value)
      End Set
    End Property
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_sanyu_orderpenjualandetail")> Property Main As SanYu_OrderPenjualan
      Get
        Return _main
      End Get
      Set(value As SanYu_OrderPenjualan)
        SetPropertyValue(Of SanYu_OrderPenjualan)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As NuSoft004.Persistent.SanYu_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.SanYu_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.SanYu_Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("d_tickness")> Property Thickness As Decimal
      Get
        Return _thickness
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
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
    <Persistent("d_qtypcs")> Property QtyPcs As Double
      Get
        Return _qtypcs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyPcs", _qtypcs, value)
      End Set
    End Property
    <Persistent("d_price")> Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
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
    <Persistent("f_taxin")> Property PPN As NuSoft004.Persistent.Pajak
      Get
        Return _ppn
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _ppn, value)
      End Set
    End Property
    <Persistent("d_taxinp")> Property PPNp As Double
      Get
        Return _ppnp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPNp", _ppnp, value)
      End Set
    End Property
    <Persistent("f_taxout")> Property PPH As NuSoft004.Persistent.Pajak
      Get
        Return _pph
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _pph, value)
      End Set
    End Property
    <Persistent("d_taxoutp")> Property PPHp As Double
      Get
        Return _pphp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPHp", _pphp, value)
      End Set
    End Property
    <PersistentAlias("Harga * Qty")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("DPP"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 0,0,PPNp / 100 * DPP)")> ReadOnly Property PPNv As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPNv"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 0,0,PPHp / 100 * DPP)")> ReadOnly Property PPHv As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPHv"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <NonPersistent> Property NamaBarang As String
      Get
        If String.IsNullOrEmpty(_namaBarang) Then
          If Barang Is Nothing Then
            Return ""
          Else
            Return Barang.Nama
          End If
        Else
          Return _namaBarang
        End If
      End Get
      Set(value As String)
        _namaBarang = value
      End Set
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Order Penjualan [SO]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order penjualan", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _qty = Nothing Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
        Return False
      End If
      If _harga = 0 Then
        Throw New Utils.Exception("Masukkan harga barang", -99, "", source)
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




  'PIB
  <Persistent("m05cmainpib")>
  Friend Class SanYu_PIB
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _kontakalamat As NuSoft001.Persistent.KontakAlamat
    Private _alamat As String
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _catatan As String
    Private _reffnumber As String
    Private _invoicepembelian As Persistent.SanYu_PenerimaanInvoice
    Private _invoice As Persistent.SanYu_PenerimaanInvoice
    Private _fasilitas As Boolean
    Private _kiteNoPengajuan As String
    Private _kiteNoDokumen As String
    Private _kiteTglDokumen As Date
    Private _kiteKodeKNT As String
    Private _kiteUmur As Integer
    Private _kiteJatuhTempo As Date

    'PIB : No Aju, No Dokumen, Tgl Dokumen, KD KNT, Umur, Jatuh tempo, KITE/NON

    <Persistent("d_status")>
    Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
      End Set
    End Property
    <Persistent("f_currency")>
    Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
      End Set
    End Property
    <Persistent("d_kurs")>
    Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
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
    <Persistent("d_reffnumber")>
    Property ReffNo As String
      Get
        Return _reffnumber
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ReffNo", _reffnumber, value)
      End Set
    End Property
    <Persistent("f_idiv")>
    Property InvoicePembelian As SanYu_PenerimaanInvoice
      Get
        Return _invoicepembelian
      End Get
      Set(value As SanYu_PenerimaanInvoice)
        SetPropertyValue(Of SanYu_PenerimaanInvoice)("InvoicePembelian", _invoicepembelian, value)
      End Set
    End Property

    <Persistent("d_kitepengajuan")>
    Property NoPengajuan As String
      Get
        Return _kiteNoPengajuan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoPengajuan", _kiteNoPengajuan, value)
      End Set
    End Property
    <Persistent("d_kitependaftaran")>
    Property NoPendaftaran As String
      Get
        Return _kiteNoDokumen
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoPendaftaran", _kiteNoDokumen, value)
      End Set
    End Property
    <Persistent("d_kitependaftarantgl")>
    Property TglPendaftaran As Date
      Get
        Return _kiteTglDokumen
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglPendaftaran", _kiteTglDokumen, value)
      End Set
    End Property
    <Persistent("d_kitekpbc")>
    Property KPBC As String
      Get
        Return _kiteKodeKNT
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KPBC", _kiteKodeKNT, value)
      End Set
    End Property
    <Persistent("d_kiteumur")>
    Property Umur As Integer
      Get
        Return _kiteUmur
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Umur", _kiteUmur, value)
      End Set
    End Property
    <Persistent("d_kitetgltempo")>
    Property JatuhTempo As Date
      Get
        Return _kiteJatuhTempo
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("JatuhTempo", _kiteJatuhTempo, value)
      End Set
    End Property

    <Association("sanyu_fk_pib_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PIBDetail)
      Get
        Return GetCollection(Of SanYu_PIBDetail)("Detail")
      End Get
    End Property
    <Association("sanyu_fk_pib_biaya"), Aggregated> ReadOnly Property Biaya As XPCollection(Of SanYu_PIBBiaya)
      Get
        Return GetCollection(Of SanYu_PIBBiaya)("Biaya")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("(SubTotal)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalPajakFasilitas)")> ReadOnly Property TotalPajak As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalPajak"))
      End Get
    End Property
    <NonPersistent()> ReadOnly Property Terbilang As String
      Get
        Return Utils.Common.Character.Terbilang(Total)
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "PIB"
      If IsDeleted Then
        Return True
      End If
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
      End If
      If _reffnumber Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor PIB", -5, "", source)
        Return False
      End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
          Return False
        End If
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m05ddetailpib")>
  Friend Class SanYu_PIBDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PIB
    Private _idinvoice As SanYu_PenerimaanInvoiceDetail
    Private _kite As Boolean
    Private _item As NuSoft004.Persistent.SanYu_Barang
    Private _qty As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _bm As NuSoft004.Persistent.Pajak
    Private _bmp As Double
    Private _disc As Double
    Private _discp As Double
    Private _cif As Double
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
    <Persistent("p_id"), Association("sanyu_fk_pib_detail")>
    Property Main As SanYu_PIB
      Get
        Return _main
      End Get
      Set(value As SanYu_PIB)
        SetPropertyValue(Of SanYu_PIB)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_idinvoice")>
    Property InvoiceDetail As Persistent.SanYu_PenerimaanInvoiceDetail
      Get
        Return _idinvoice
      End Get
      Set(value As Persistent.SanYu_PenerimaanInvoiceDetail)
        SetPropertyValue(Of Persistent.SanYu_PenerimaanInvoiceDetail)("InvoiceDetail", _idinvoice, value)
      End Set
    End Property
    <Persistent("d_kite")>
    Property Kite As Boolean
      Get
        Return _kite
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Kite", _kite, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.SanYu_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.SanYu_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.SanYu_Barang)("Barang", _item, value)
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
    <Persistent("f_taxppn")>
    Property PPN As NuSoft004.Persistent.Pajak
      Get
        Return _ppn
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _ppn, value)
      End Set
    End Property
    <Persistent("d_taxppnp")>
    Property PPNp As Double
      Get
        Return _ppnp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPNp", _ppnp, value)
      End Set
    End Property
    <Persistent("f_taxbm")>
    Property BeaMasuk As NuSoft004.Persistent.Pajak
      Get
        Return _bm
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("BeaMasuk", _bm, value)
      End Set
    End Property
    <Persistent("d_taxbmp")>
    Property BeaMasukP As Double
      Get
        Return _bmp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BeaMasukP", _bmp, value)
      End Set
    End Property
    <Persistent("d_cif")>
    Property CIF As Double
      Get
        Return _cif
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("CIF", _cif, value)
      End Set
    End Property
    <PersistentAlias("Qty * Harga")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("CIF * Main.Kurs")> ReadOnly Property CIFKite As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("CIFKite"))
      End Get
    End Property
    <PersistentAlias("(BeaMasukP / 100) * CIFKite")> ReadOnly Property BMNilai As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("BMNilai"))
      End Get
    End Property
    <PersistentAlias("(PPNp / 100) * (CIFKite + BMNilai)")> ReadOnly Property PPNNilai As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPNNilai"))
      End Get
    End Property
    <PersistentAlias("BMNilai + PPNNilai")> ReadOnly Property TotalPajak As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalPajak"))
      End Get
    End Property
    <PersistentAlias("iif(Kite=0,BMNilai + PPNNilai,0)")> ReadOnly Property TotalPajakFasilitas As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalPajakFasilitas"))
      End Get
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
    '<Persistent("f_kuotaimpor")>
    'Property KuotaImpor As SanYu_KuotaImpor
    '  Get
    '    Return _kuotaImpor
    '  End Get
    '  Set(value As SanYu_KuotaImpor)
    '    SetPropertyValue(Of SanYu_KuotaImpor)("KuotaImpor", _kuotaImpor, value)
    '  End Set
    'End Property
    Private Function CheckData() As Boolean
      Dim source As String = "PIB [PIB]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama pib", -99, "", source)
        Return False
      End If
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
  <Persistent("m05fbiayapib")>
  Friend Class SanYu_PIBBiaya
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PIB
    Private _item As NuSoft004.Persistent.SanYu_Barang
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _harga As Double
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
    <Persistent("p_id"), Association("sanyu_fk_pib_biaya")>
    Property Main As SanYu_PIB
      Get
        Return _main
      End Get
      Set(value As SanYu_PIB)
        SetPropertyValue(Of SanYu_PIB)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.SanYu_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.SanYu_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.SanYu_Barang)("Barang", _item, value)
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
    <PersistentAlias("Qty * Harga")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
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
    Private Function CheckData() As Boolean
      Dim source As String = "PIB [PIB]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama pib", -99, "", source)
        Return False
      End If
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


  <Persistent("m05cmaininvoicereceipt")>
  Friend Class SanYu_PenerimaanInvoice
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _tipe As Persistent.eTipeInvoicePembelian
    Private _tglberlaku As Date
    Private _termin As Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _jenispajak As Persistent.eJenisPajak
    Private _pajak As Persistent.eTipePajak
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    Private _taxp As Double
    Private _noreffvendor As String
    Private _fromdomestik As Boolean
    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
      End Set
    End Property
    <Persistent("d_contact")>
    Property KontakPerson As String
      Get
        Return _kontakperson
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
      End Set
    End Property
    <Persistent("d_tipe")>
    Property TipeTransaksi As Persistent.eTipeInvoicePembelian
      Get
        Return _tipe
      End Get
      Set(value As Persistent.eTipeInvoicePembelian)
        SetPropertyValue(Of Persistent.eTipeInvoicePembelian)("TipeTransaksi", _tipe, value)
      End Set
    End Property
    <Persistent("d_duedate")>
    Property TanggalBerlaku As Date
      Get
        Return _tglberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerlaku", _tglberlaku, value)
      End Set
    End Property
    <Persistent("f_termin")>
    Property Termin As Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As Persistent.Termin)
        SetPropertyValue(Of Persistent.Termin)("Termin", _termin, value)
      End Set
    End Property
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _karyawan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _karyawan, value)
      End Set
    End Property
    <Persistent("f_currency")>
    Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
      End Set
    End Property
    <Persistent("d_kurs")>
    Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("d_taxcaption")>
    Property JenisPajak As eJenisPajak
      Get
        Return _jenispajak
      End Get
      Set(value As eJenisPajak)
        SetPropertyValue(Of eJenisPajak)("JenisPajak", _jenispajak, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As eTipePajak)
        SetPropertyValue(Of eTipePajak)("TipePajak", _pajak, value)
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
    <Persistent("d_status")>
    Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
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
    <Persistent("d_othercost")>
    Property BiayaLain As Double
      Get
        Return _othercost
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
      End Set
    End Property
    <Persistent("d_taxsnppn")>
    Property NoSNPPN As String
      Get
        Return _nosnppn
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPN", _nosnppn, value)
      End Set
    End Property
    <Persistent("d_taxsnpph")>
    Property NoSNPPh As String
      Get
        Return _nosnpph
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPh", _nosnpph, value)
      End Set
    End Property
    <Persistent("d_externalnumber")>
    Property NoReffVendor As String
      Get
        Return _noreffvendor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoReffVendor", _noreffvendor, value)
      End Set
    End Property
    <Persistent("d_fromdomestic")>
    Property FromDomestik As Boolean
      Get
        Return _fromdomestik
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("FromDomestik", _fromdomestik, value)
      End Set
    End Property
    <Association("fk_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PenerimaanInvoiceDetail)
      Get
        Return GetCollection(Of SanYu_PenerimaanInvoiceDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPNv)")> ReadOnly Property PPN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPN"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPHv)")> ReadOnly Property PPH As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPH"))
      End Get
    End Property
    <PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property

    <PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
      Get
        Return Convert.ToString(EvaluateAlias("Terbilang"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
      Get
        Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Invoice [RI]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
      End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
      End If

      'If Uang.Id <> Uang.HutangDagang.MataUang.Id Then
      '  Throw New Utils.Exception("Mata uang untuk coa [Hutang Dagang] tidak sama dengan mata uang transaksi", -7, "", source)
      'End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
          Return False
        End If
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m05ddetailinvoicereceipt")>
  Friend Class SanYu_PenerimaanInvoiceDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.SanYu_PenerimaanInvoice
    Private _item As NuSoft004.Persistent.SanYu_Barang
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
    Private _catatan As String
    Private _proyek As NuSoft001.Persistent.Proyek
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_invoice_detail")>
    Property Main As SanYu_PenerimaanInvoice
      Get
        Return _main
      End Get
      Set(value As SanYu_PenerimaanInvoice)
        SetPropertyValue(Of SanYu_PenerimaanInvoice)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.SanYu_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.SanYu_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.SanYu_Barang)("Barang", _item, value)
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

    <PersistentAlias("iif(Main.TipePajak = 0,0,PPNp / 100 * DPP)")> ReadOnly Property PPNv As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPNv"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 0,0,PPHp / 100 * DPP)")> ReadOnly Property PPHv As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPHv"))
      End Get
    End Property
    <PersistentAlias("(Qty * Harga)-(Qty * Discount)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("DPP"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama Penerimaan Invoice", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _qty = Nothing Then
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
  '<Persistent("m04vwhppavailable")> Friend Class vwSanyuHPP
  '  Inherits XPLiteObject
  '  Public Sub New(ByVal session As Session)
  '    MyBase.New(session)
  '  End Sub
  '  Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
  '    MyBase.New(session, classInfo)
  '  End Sub
  '  <Key()> Property Id As Persistent.SanYu_StokDetail
  '  Property f_item As Persistent.SanYu_Barang
  '  Property f_warehouse As Persistent.Gudang
  '  Property d_qtyin As Double
  '  Property d_qtyout As Double
  '  Property d_used As Double
  '  Property d_available As Double
  'End Class
End Namespace

