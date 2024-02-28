Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m06dmainorder")> Friend Class Fusoh_OrderPenjualan
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
    'Private _nopenawaran As Fusoh_Penawaran
    Private _nomorPO As String
    'Private _tipeso As FusohTipeSO

    '<Persistent("d_tipeso")> Property TipeSO As FusohTipeSO
    '	Get
    '		Return _tipeso
    '	End Get
    '	Set(value As FusohTipeSO)
    '		SetPropertyValue(Of FusohTipeSO)("TipeSO", _tipeso, value)
    '	End Set
    'End Property

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

    '<Persistent("f_quotation")> Property Penawaran As Fusoh_Penawaran
    '	Get
    '		Return _nopenawaran
    '	End Get
    '	Set(value As Fusoh_Penawaran)
    '		SetPropertyValue(Of Fusoh_Penawaran)("Penawaran", _nopenawaran, value)
    '	End Set
    'End Property
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
  <Persistent("m06edetailorder")> Friend Class Fusoh_OrderPenjualanDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_OrderPenjualan
    'Private _penawaranDetail As Fusoh_PenawaranDetail
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

  <Persistent("m04corderproduksi")> Friend Class Fusoh_OrderProduksi
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _customer As NuSoft001.Persistent.Kontak
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _sodetail As Fusoh_OrderPenjualanDetail
    Private _nomorLot As String
    Private _nomorpdo As String
    Private _nomorDrawing As String
    Private _materialFlow As String
    Private _deliveryDate As String
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _qty As Double
    Private _weight As Decimal
    Private _lengthTolerance As String
    Private _materialCorner As String
    Private _colourCode As String
    Private _cutting As Double
    Private _printCounter As Integer
    Private _printCounterPR As Integer
    Private _targetfinish As String
    Private _noCutting As Boolean

    <Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
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
    <Persistent("f_sodetail")> Property SODetail As Fusoh_OrderPenjualanDetail
      Get
        Return _sodetail
      End Get
      Set(value As Fusoh_OrderPenjualanDetail)
        SetPropertyValue(Of Fusoh_OrderPenjualanDetail)("SODetail", _sodetail, value)
      End Set
    End Property
    <Persistent("d_nomorlot")> Property NomorLot As String
      Get
        Return _nomorLot
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorLot", _nomorLot, value)
      End Set
    End Property
    <Persistent("d_nomorpdo")> Property NomorPDO As String
      Get
        Return _nomorpdo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorPDO", _nomorpdo, value)
      End Set
    End Property
    <Persistent("d_nodrawing")> Property NomorDrawing As String
      Get
        Return _nomorDrawing
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorDrawing", _nomorDrawing, value)
      End Set
    End Property
    <Persistent("d_materialflow")> Property MaterialFlow As String
      Get
        Return _materialFlow
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("MaterialFlow", _materialFlow, value)
      End Set
    End Property
    <Persistent("d_delivery")> Property DeliveryDate As String
      Get
        Return _deliveryDate
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("DeliveryDate", _deliveryDate, value)
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
    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
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
    <Persistent("d_lengthtolerance")> Property LengthTolerance As String
      Get
        Return _lengthTolerance
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("LengthTolerance", _lengthTolerance, value)
      End Set
    End Property
    <Persistent("d_materialcorner")> Property MaterialCorner As String
      Get
        Return _materialCorner
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("MaterialCorner", _materialCorner, value)
      End Set
    End Property
    <Persistent("d_colourcode")> Property ColourCode As String
      Get
        Return _colourCode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ColourCode", _colourCode, value)
      End Set
    End Property
    <Persistent("d_cutting")> Property Cutting As Double
      Get
        Return _cutting
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Cutting", _cutting, value)
      End Set
    End Property
    <Persistent("PrintCounter")> Property PrintCounter As Integer
      Get
        Return _printCounter
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("PrintCounter", _printCounter, value)
      End Set
    End Property
    <Persistent("PrintCounterPR")> Property PrintCounterPR As Integer
      Get
        Return _printCounterPR
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("PrintCounterPR", _printCounterPR, value)
      End Set
    End Property
    <Persistent("d_targetfinish")> Property TargetFinish As String
      Get
        Return _targetfinish
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TargetFinish", _targetfinish, value)
      End Set
    End Property
    <Persistent("d_nocutting")> Property NoCutting As Boolean
      Get
        Return _noCutting
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("NoCutting", _noCutting, value)
      End Set
    End Property

    <Association("fk_orderproduksi_bahanbaku"), Aggregated> ReadOnly Property BahanBaku As XPCollection(Of Fusoh_OrderProduksiBahanBaku)
      Get
        Return GetCollection(Of Fusoh_OrderProduksiBahanBaku)("BahanBaku")
      End Get
    End Property
    '<Association("fk_orderproduksi_daily"), Aggregated> ReadOnly Property DailyProcces As XPCollection(Of Fusoh_OrderProduksiDaily)
    '	Get
    '		Return GetCollection(Of Fusoh_OrderProduksiDaily)("DailyProcces")
    '	End Get
    'End Property
    '<Association("fk_orderproduksi_produksi"), Aggregated> ReadOnly Property Produksi As XPCollection(Of Fusoh_Produksi)
    '	Get
    '		Return GetCollection(Of Fusoh_Produksi)("Produksi")
    '	End Get
    'End Property
    '<PersistentAlias("Produksi.Sum(QtyProduksi)")> ReadOnly Property QtyProduksi As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("QtyProduksi"))
    '	End Get
    'End Property
    '<PersistentAlias("Produksi.Sum(QtyCutting)")> ReadOnly Property QtyCutting As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("QtyCutting"))
    '	End Get
    'End Property
    'Private Function CheckData() As Boolean
    '	Dim source As String = "Order Produksi"
    '	If Regional Is Nothing Then
    '		Throw New Utils.Exception("Masukkan regional", -1, "", source)
    '		Return False
    '	End If
    '	If Tanggal = Nothing Then
    '		Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
    '		Return False
    '	End If
    '	If Pelanggan Is Nothing Then
    '		Throw New Utils.Exception("Masukkan Pelanggan", -3, "", source)
    '		Return False
    '	End If
    '	If Gudang Is Nothing Then
    '		Throw New Utils.Exception("Masukkan gudang", -4, "", source)
    '		Return False
    '	End If
    '	If SODetail Is Nothing Then
    '		Throw New Utils.Exception("Masukkan nomor PO Pelanggan", -5, "", source)
    '		Return False
    '	End If
    '	If String.IsNullOrEmpty(NomorLot) Then
    '		Throw New Utils.Exception("Masukkan nomor lot", -6, "", source)
    '		Return False
    '	End If
    '	'If DeliveryDate = Nothing Then
    '	'	Throw New Utils.Exception("Masukkan tanggal delivery", -7, "", source)
    '	'	Return False
    '	'End If
    '	''======= Cek Periode
    '	'If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
    '	'  Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
    '	'  Return False
    '	'End If
    '	''======= Cek Sebelum Awal Periode
    '	'If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
    '	'  Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
    '	'  Return False
    '	'End If

    '	If Session.IsNewObject(Me) Then
    '		If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
    '			Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
    '			Return False
    '		End If
    '	End If
    '	Return True
    'End Function
    'Protected Overrides Sub OnSaving()
    '	If Not CheckData() Then
    '		Return
    '	End If
    '	If Kode = Nothing Then
    '		Kode = Number.GetNewNumber.Kode
    '	End If
    '	MyBase.OnSaving()
    'End Sub
  End Class
  <Persistent("m04dorderproduksibaku")> Friend Class Fusoh_OrderProduksiBahanBaku
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_OrderProduksi
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _millsheet As String
    Private _serial As String
    Private _snlength As Decimal
    Private _length As Decimal
    Private _qty As Integer
    Private _weight As Double
    Private _catatan As String
    Private _scrap As Boolean

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_orderproduksi_bahanbaku")> Property Main As Fusoh_OrderProduksi
      Get
        Return _main
      End Get
      Set(value As Fusoh_OrderProduksi)
        SetPropertyValue(Of Fusoh_OrderProduksi)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("d_millsheet")> Property Millsheet As String
      Get
        Return _millsheet
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Millsheet", _millsheet, value)
      End Set
    End Property
    <Persistent("d_serial")> Property Serial As String
      Get
        Return _serial
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Serial", _serial, value)
      End Set
    End Property
    <Persistent("d_snlength")> Property SNLength As Decimal
      Get
        Return _snlength
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("SNLength", _snlength, value)
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

    <Persistent("d_qty")> Property Qty As Integer
      Get
        Return _qty
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_weight")> Property Weight As Double
      Get
        Return _weight
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Weight", _weight, value)
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
    <Persistent("d_scrap")> Property Scrap As Boolean
      Get
        Return _scrap
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Scrap", _scrap, value)
      End Set
    End Property
    '<PersistentAlias("Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
    '	Get
    '		Return Convert.ToString(EvaluateAlias("UniqueData"))
    '	End Get
    'End Property

    'Private Function CheckData() As Boolean
    '	Dim source As String = "Order Produksi - Bahan Baku"
    '	If IsDeleted Then
    '		Return True
    '	End If
    '	If _main Is Nothing AndAlso Not IsDeleted Then
    '		Throw New Utils.Exception("Masukkan data utama order produksi", -99, "", source)
    '		Return False
    '	End If
    '	If _item Is Nothing Then
    '		Throw New Utils.Exception("Masukkan barang", -99, "", source)
    '		Return False
    '	End If
    '	If _serial Is Nothing Then
    '		Throw New Utils.Exception("Masukkan serial", -99, "", source)
    '		Return False
    '	End If
    '	If _length = Nothing Then
    '		Throw New Utils.Exception("Masukkan length yang dibutuhkan", -99, "", source)
    '		Return False
    '	End If
    '	Return True
    'End Function
    'Protected Overrides Sub OnSaving()
    '	If Not CheckData() Then
    '		Return
    '	End If
    '	MyBase.OnSaving()
    'End Sub
  End Class

  <Persistent("m04cstockmain")> Friend Class Fusoh_PenerimaanBarang
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _vendor As NuSoft001.Persistent.Kontak
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _kontakperson As String
    Private _bagpembelian As NuSoft001.Persistent.Kontak
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _gudang2 As NuSoft004.Persistent.Gudang
    Private _idExim As Fusoh_Exim
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _gl As GlMain
		Private _orderProduksi As Fusoh_OrderProduksi
		Private _revisi As Int16
		<Persistent("d_rev")> Property Revisi As Int16
			Get
				Return _revisi
			End Get
			Set(value As Int16)
				SetPropertyValue(Of Int16)("Revisi", _revisi, value)
			End Set
		End Property


		<Persistent("f_contact")> Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
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
        Return _bagpembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
      End Set
    End Property
    <Persistent("f_divisi")> Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Catatan", _divisi, value)
      End Set
    End Property
    <Persistent("f_warehouse2")> Property Gudang2 As NuSoft004.Persistent.Gudang
      Get
        Return _gudang2
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang2", _gudang2, value)
      End Set
    End Property
    <Association("fusoh_fk_exim_penerimaanbarang"), Persistent("f_ideximm")> Property Exim As Fusoh_Exim
      Get
        Return _idExim
      End Get
      Set(value As Fusoh_Exim)
        SetPropertyValue(Of Fusoh_Exim)("Exim", _idExim, value)
      End Set
    End Property
    <Persistent("f_currency")> Property MataUang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _uang, value)
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
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property
    <Persistent("f_iddempyou")> Property OrderProduksi As Fusoh_OrderProduksi
      Get
        Return _orderProduksi
      End Get
      Set(value As Fusoh_OrderProduksi)
        SetPropertyValue(Of Fusoh_OrderProduksi)("OrderProduksi", _orderProduksi, value)
      End Set
    End Property

    <Association("fk_fusoh_penerimaan_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_PenerimaanBarangDetail)
      Get
        Return GetCollection(Of Fusoh_PenerimaanBarangDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Barang [GR]"
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
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -5, "", source)
        Return False
      End If
      If Karyawan Is Nothing Then
        Throw New Utils.Exception("Masukkan karyawan penerima barang", -6, "", source)
        Return False
      End If
      '======= Cek Periode
      If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
        Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
        Return False
      End If
      '======= Cek Sebelum Awal Periode
      If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
        Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
        Return False
      End If
      If Detail.Sum(Function(m) m.Qty) = 0 Then
        Throw New Utils.Exception("Masukkan nilai qty", -99, "", source)
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
      For i = 0 To Detail.Count - 1
        Detail(i).Gudang = _gudang
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
  <Persistent("m04dstockdetail")> Friend Class Fusoh_PenerimaanBarangDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_PenerimaanBarang
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _catatan As String
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _harga As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _weightr As Decimal
    Private _eximDetail As Fusoh_EximDetail
    Private _qtyOut As Double
    Private _soDetail As Fusoh_OrderPenjualanDetail

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_penerimaan_detail")> Property Main As Fusoh_PenerimaanBarang
      Get
        Return _main
      End Get
      Set(value As Fusoh_PenerimaanBarang)
        SetPropertyValue(Of Fusoh_PenerimaanBarang)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
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
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("f_uom")> Property Satuan As NuSoft004.Persistent.Satuan
      Get
        Return _satuan
      End Get
      Set(value As NuSoft004.Persistent.Satuan)
        SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_qtyin")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
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
    <Persistent("d_weightr")> Property WeightR As Decimal
      Get
        Return _weightr
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("WeightR", _weightr, value)
      End Set
    End Property
    <Persistent("f_ideximmd")> Property EximDetail As Fusoh_EximDetail
      Get
        Return _eximDetail
      End Get
      Set(value As Fusoh_EximDetail)
        SetPropertyValue(Of Fusoh_EximDetail)("EximDetail", _eximDetail, value)
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

    <Persistent("f_idsod")> Property SODetail As Fusoh_OrderPenjualanDetail
      Get
        Return _soDetail
      End Get
      Set(value As Fusoh_OrderPenjualanDetail)
        SetPropertyValue(Of Fusoh_OrderPenjualanDetail)("SODetail", _soDetail, value)
      End Set
    End Property

    <Association("fk_fusoh_penerimaan_detail_serial"), Aggregated> ReadOnly Property DetailSerial As XPCollection(Of Fusoh_PenerimaanBarangDetailSerial)
      Get
        Return GetCollection(Of Fusoh_PenerimaanBarangDetailSerial)("DetailSerial")
      End Get
    End Property

    Property DetailSerial_Temp As List(Of Fusoh_PenerimaanBarangDetailSerial_Temp)
    <NonPersistent> Property FromRevisiLength As Boolean

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
      Dim source As String = "Penerimaan Barang [GR]"
      If FromRevisiLength Then Return True
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
  <Persistent("m04estockdetailserial")> Friend Class Fusoh_PenerimaanBarangDetailSerial
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _detail As Fusoh_PenerimaanBarangDetail
    Private _serial As String
    Private _millSheet As String
    Private _length As Double
    Private _lengthOut As Double
    Private _qty As Double
    Private _scrap As Boolean

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_penerimaan_detail_serial")> Property DetailMain As Fusoh_PenerimaanBarangDetail
      Get
        Return _detail
      End Get
      Set(value As Fusoh_PenerimaanBarangDetail)
        SetPropertyValue(Of Fusoh_PenerimaanBarangDetail)("DetailMain", _detail, value)
      End Set
    End Property
    <Persistent("d_serial")> Property Serial As String
      Get
        Return _serial
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Serial", _serial, value)
      End Set
    End Property
    <Persistent("d_millsheet")> Property MillSheet As String
      Get
        Return _millSheet
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("MillSheet", _millSheet, value)
      End Set
    End Property
    <Persistent("d_length_in")> Property LengthIn As Double
      Get
        Return _length
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("LengthIn", _length, value)
      End Set
    End Property
    <Persistent("d_length_out")> Property LengthOut As Double
      Get
        Return _lengthOut
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("LengthOut", _lengthOut, value)
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
    <Persistent("d_scrap")> Property Scrap As Boolean
      Get
        Return _scrap
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Scrap", _scrap, value)
      End Set
    End Property

    <PersistentAlias("DetailMain.Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("DetailMain.Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Barang [GR]"
      If IsDeleted Then
        Return True
      End If

      If _detail Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
        Return False
      End If
      If _serial = Nothing Then
        Throw New Utils.Exception("Masukkan data serial", -99, "", source)
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

  Friend Class Fusoh_PenerimaanBarangDetailSerial_Temp
    Property Id As Int64
    Property DetailMain As Fusoh_PenerimaanBarangDetail
    Property Serial As String
    Property MillSheet As String
    Property LengthIn As Double
    Property State As Short '0 = tidak terpilih, 1 = terpilih, 2 = terpakai
  End Class

  <Persistent("m05vwpenerimaanbarang")> Friend Class Fusoh_PenerimaanBarangView
    Inherits XPLiteObject

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key, Persistent("p_id")> Public Property Id As Long
    <Persistent("u_regional")> Public Property Regional As NPO.Modules.ModSys.Regional
    <Persistent("u_source")> Public Property Sumber As NPO.Modules.ModSys.SumberData
    <Persistent("u_year")> Public Property Tahun As Integer
    <PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> Public ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
    <Persistent("u_sequence")> Public Property Urutan As Integer
    <Persistent("u_code")> Public Property Kode As String
    <Persistent("d_date")> Public Property Tanggal As Date
    <Persistent("f_contact")> Public Property Vendor As NuSoft001.Persistent.Kontak
    <Persistent("f_warehouse")> Public Property Gudang As NuSoft004.Persistent.Gudang
    <Persistent("d_remarks")> Public Property Uraian As String
    <Persistent("d_status")> Public Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
    <Persistent("d_person")> Public Property KontakPerson As String
    <Persistent("f_employee")> Public Property Karyawan As NuSoft001.Persistent.Kontak
    <Persistent("f_divisi")> Public Property Divisi As NPO.Modules.ModSys.Divisi
    <Persistent("f_warehouse2")> Public Property Gudang2 As NuSoft004.Persistent.Gudang
    <Persistent("f_ideximm")> Public Property Exim As Fusoh_Exim
    <Persistent("f_currency")> Public Property MataUang As NuSoft001.Persistent.MataUang
    <Persistent("d_kurs")> Public Property Kurs As Double
    <Persistent("f_gl")> Public Property Gl As GlMain
    Public Property NoReffVendor As String
    Public Property TotalQty As Double
    Public Property created_date As DateTime
    Public Property created_user As String
    Public Property last_date As DateTime
		Public Property last_modified As String
		Public Property rev As String
	End Class
End Namespace