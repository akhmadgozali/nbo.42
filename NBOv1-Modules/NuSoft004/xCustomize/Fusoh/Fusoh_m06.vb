Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m06cmainquotation")>
  Public Class Fusoh_Penawaran
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _alamat As NuSoft001.Persistent.KontakAlamat
    Private _kontakperson As String
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    'Private _pajak As eTipePajak
    Private _tanggalBerlakuAwal As Date
    Private _tanggalBerlakuAkhir As Date
    'Private _termin As Termin
    Private _termOfPrice As String
    Private _payment As String
    Private _inspection As String
    Private _yourReff As String
    Private _catatan As String

    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("f_address")> Property Alamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _alamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("Alamat", _alamat, value)
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
    '<Persistent("d_taxtype")>
    'Property TipePajak As eTipePajak
    '	Get
    '		Return _pajak
    '	End Get
    '	Set(value As eTipePajak)
    '		SetPropertyValue(Of eTipePajak)("Pajak", _pajak, value)
    '	End Set
    'End Property
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
    '<Persistent("f_termin")> Property Termin As Termin
    '	Get
    '		Return _termin
    '	End Get
    '	Set(value As Termin)
    '		SetPropertyValue(Of Termin)("Termin", _termin, value)
    '	End Set
    'End Property

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
    <Persistent("d_yourreff")> Property YourReff As String
      Get
        Return _yourReff
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("YourReff", _yourReff, value)
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

    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(SubTotal)")> ReadOnly Property Total As Double
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

    <Association("fk_fusoh_penawaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_PenawaranDetail)
      Get
        Return GetCollection(Of Fusoh_PenawaranDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Penawaran Penjualan [SQ]"
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
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Pelanggan", -3, "", source)
        Return False
      End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -4, "", source)
      End If
      If TanggalBerlakuAwal = Nothing Then
        Throw New Utils.Exception("Masukkan awal tanggal berlaku", -5, "", source)
      End If
      If TanggalBerlakuAkhir = Nothing Then
        Throw New Utils.Exception("Masukkan akhir tanggal berlaku", -5, "", source)
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
  <Persistent("m06ddetailquotation")>
  Public Class Fusoh_PenawaranDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_Penawaran
    Private _partNo As String
    Private _item As String
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _qty As Double
    Private _weight As Decimal
    Private _harga As Double
    Private _catatan As String

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_penawaran_detail")> Property Main As Fusoh_Penawaran
      Get
        Return _main
      End Get
      Set(value As Fusoh_Penawaran)
        SetPropertyValue(Of Fusoh_Penawaran)("Main", _main, value)
      End Set
    End Property
    <Persistent("d_partno")> Property PartNo As String
      Get
        Return _partNo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PartNo", _partNo, value)
      End Set
    End Property
    <Persistent("d_item")> Property Barang As String
      Get
        Return _item
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Barang", _item, value)
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
    <Persistent("d_qty")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
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

    <PersistentAlias("Harga * Main.Kurs")> ReadOnly Property HargaKurs As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("HargaKurs"))
      End Get
    End Property
    <PersistentAlias("HargaKurs * Qty")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property

    <PersistentAlias("Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Penawaran Penjualan [SQ]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan barang", -99, "", source)
        Return False
      End If
      If _qty = Nothing Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
        Return False
      End If
      If _harga = Nothing Then
        Throw New Utils.Exception("Masukkan harga", -99, "", source)
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

  <Persistent("m06dmainorder")> Public Class Fusoh_OrderPenjualan
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
    'Private _pajak As eTipePajak
    Private _tanggalBerlakuAwal As Date
    Private _tanggalBerlakuAkhir As Date
    Private _termin As Termin
    Private _termOfPrice As String
    Private _deliverydate As Date
    Private _payment As String
    Private _inspection As String
    Private _catatan As String
    Private _nopenawaran As Fusoh_Penawaran
    Private _nomorPO As String
    Private _tipeso As FusohTipeSO
    <Persistent("d_tipeso")> Property TipeSO As FusohTipeSO
      Get
        Return _tipeso
      End Get
      Set(value As FusohTipeSO)
        SetPropertyValue(Of FusohTipeSO)("TipeSO", _tipeso, value)
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
    '<Persistent("d_taxtype")>
    'Property TipePajak As eTipePajak
    '	Get
    '		Return _pajak
    '	End Get
    '	Set(value As eTipePajak)
    '		SetPropertyValue(Of eTipePajak)("Pajak", _pajak, value)
    '	End Set
    'End Property
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
    '<Persistent("f_termin")> Property Termin As Termin
    '	Get
    '		Return _termin
    '	End Get
    '	Set(value As Termin)
    '		SetPropertyValue(Of Termin)("Termin", _termin, value)
    '	End Set
    'End Property
    <Persistent("d_deliverydate")> Property DeliveryDate As Date
      Get
        Return _deliverydate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("DeliveryDate", _deliverydate, value)
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
    <Persistent("d_remarks")> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property

    <Persistent("f_quotation")> Property Penawaran As Fusoh_Penawaran
      Get
        Return _nopenawaran
      End Get
      Set(value As Fusoh_Penawaran)
        SetPropertyValue(Of Fusoh_Penawaran)("Penawaran", _nopenawaran, value)
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
    '<PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("SubTotal"))
    '	End Get
    'End Property
    '<PersistentAlias("Detail.Sum(PPNv)")> ReadOnly Property PPN As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("PPN"))
    '	End Get
    'End Property
    '<PersistentAlias("Detail.Sum(PPHv)")> ReadOnly Property PPH As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("PPH"))
    '	End Get
    'End Property
    '<PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("Total"))
    '	End Get
    'End Property
    '<PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
    '	Get
    '		Return Convert.ToString(EvaluateAlias("Terbilang"))
    '	End Get
    'End Property
    '<PersistentAlias("TerbilangEnglish(Total)")> ReadOnly Property TerbilangEnglish As String
    '	Get
    '		Return Convert.ToString(EvaluateAlias("TerbilangEnglish"))
    '	End Get
    'End Property
    '<PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
    '	Get
    '		Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
    '	End Get
    'End Property

    <Association("fk_fusoh_orderpenjualandetail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_OrderPenjualanDetail)
      Get
        Return GetCollection(Of Fusoh_OrderPenjualanDetail)("Detail")
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
      'If Penawaran Is Nothing Then
      '	Throw New Utils.Exception("Masukkan penawaran", -5, "", source)
      '	Return False
      'End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
      End If
      If TotalQty = Nothing Then
        Throw New Utils.Exception("Masukkan qty barang", -99, "", source)
      End If
      'If Total = Nothing Then
      '	Throw New Utils.Exception("Total order tidak boleh 0", -99, "", source)
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
  <Persistent("m06edetailorder")> Public Class Fusoh_OrderPenjualanDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_OrderPenjualan
    Private _penawaranDetail As Fusoh_PenawaranDetail
    Private _poLine As String
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _qty As Double
    Private _weight As Decimal
    Private _harga As Double
    Private _catatan As String
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _namaBarang As String
    Private _noPODetail As String
    Private _deliverydate As Date

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_orderpenjualandetail")> Property Main As Fusoh_OrderPenjualan
      Get
        Return _main
      End Get
      Set(value As Fusoh_OrderPenjualan)
        SetPropertyValue(Of Fusoh_OrderPenjualan)("Main", _main, value)
      End Set
    End Property
    '<Persistent("f_quotation")> Property PenawaranDetail As Fusoh_PenawaranDetail
    '	Get
    '		Return _penawaranDetail
    '	End Get
    '	Set(value As Fusoh_PenawaranDetail)
    '		SetPropertyValue(Of Fusoh_PenawaranDetail)("PenawaranDetail", _penawaranDetail, value)
    '	End Set
    'End Property
    <Persistent("f_item")> Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("d_poline")> Property POLine As String
      Get
        Return _poLine
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("POLine", _poLine, value)
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
    <Persistent("d_qty")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
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
    <Persistent("d_nopodetail")> Property NoPODetail As String
      Get
        Return _noPODetail
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoPODetail", _noPODetail, value)
      End Set
    End Property


    <PersistentAlias("Harga * Main.Kurs")> ReadOnly Property HargaKurs As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("HargaKurs"))
      End Get
    End Property
    <PersistentAlias("HargaKurs * Qty")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <Persistent("d_deliverydate")> Property DeliveryDate As Date
      Get
        Return _deliverydate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("DeliveryDate", _deliverydate, value)
      End Set
    End Property

    '<PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("DPP"))
    '	End Get
    'End Property
    '<PersistentAlias("iif(Main.TipePajak = 0,0,PPNp / 100 * DPP)")> ReadOnly Property PPNv As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("PPNv"))
    '	End Get
    'End Property
    '<PersistentAlias("iif(Main.TipePajak = 0,0,PPHp / 100 * DPP)")> ReadOnly Property PPHv As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("PPHv"))
    '	End Get
    'End Property
    '<PersistentAlias("iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal)")> ReadOnly Property Total As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("Total"))
    '	End Get
    'End Property

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
    <PersistentAlias("Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
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