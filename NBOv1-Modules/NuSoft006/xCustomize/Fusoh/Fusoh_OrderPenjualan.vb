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
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _tanggalBerlakuAwal As Date
    Private _tanggalBerlakuAkhir As Date
    Private _termin As NuSoft005.Persistent.Termin
    Private _termOfPrice As String
    Private _payment As String
    Private _inspection As String
    Private _catatan As String
    Private _nopenawaran As Fusoh_Penawaran
    Private _nomorPO As String
    Private _deliverydate As Date
    Private _tglpo As Date
		Private _tipeso As FusohTipeSO
		Private _revisi As Int16

		<Persistent("d_rev")> Property Revisi As Int16
			Get
				Return _revisi
			End Get
			Set(value As Int16)
				SetPropertyValue(Of Int16)("Revisi", _revisi, value)
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
    <Persistent("d_tipeso")> Property TipeSO As FusohTipeSO
      Get
        Return _tipeso
      End Get
      Set(value As FusohTipeSO)
        SetPropertyValue(Of FusohTipeSO)("TipeSO", _tipeso, value)
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
    <Persistent("d_deliverydate")> Property DeliveryDate As Date
      Get
        Return _deliverydate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("DeliveryDate", _deliverydate, value)
      End Set
    End Property
    <Persistent("d_tglpo")> Property TanggalPO As Date
      Get
        Return _tglpo
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalPO", _tglpo, value)
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
    <PersistentAlias("IIf(DeliveryDate is null, AddDays(now(), 999) - now(), DeliveryDate - now())")> ReadOnly Property DeliveryDeadline As Double
      Get
        Return CType(EvaluateAlias("DeliveryDeadline"), TimeSpan).Days
      End Get
    End Property

    <Association("fk_fusoh_orderpenjualandetail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_OrderPenjualanDetail)
      Get
        Return GetCollection(Of Fusoh_OrderPenjualanDetail)("Detail")
      End Get
    End Property
		<PersistentAlias("Detail.Sum(JumlahDempyou)")> ReadOnly Property JumlahDempyou As Integer
			Get
				Return Convert.ToInt32(EvaluateAlias("JumlahDempyou"))
			End Get
		End Property 'QtyKirim
		<PersistentAlias("Detail.Sum(QtyKirim)")> ReadOnly Property QtyKirim As Integer
			Get
				Return Convert.ToInt32(EvaluateAlias("QtyKirim"))
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
			If String.IsNullOrEmpty(NomorPO) Then
				Throw New Utils.Exception("Masukkan nomor PO pelanggan", -7, "", source)
			End If
			If TotalQty = Nothing Then
				Throw New Utils.Exception("Masukkan qty barang", -99, "", source)
			End If
			If Total = Nothing Then
				Throw New Utils.Exception("Total order tidak boleh 0", -99, "", source)
			End If
			''======= Cek Periode
			'If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
			'  Throw New Utils.Exception("Periode sudah ditutup." & vbCrLf & "Hubungi accounting untuk membuka periode", -4, "", source)
			'  Return False
			'End If
			''======= Cek Sebelum Awal Periode
			'If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
			'  Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
			'  Return False
			'End If

			If Session.IsNewObject(Me) Then
				If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.ReqApprove) Then
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
    Private _penawaranDetail As Fusoh_PenawaranDetail
    Private _poLine As Int32
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
    Private _tanggalsanggup As Date
    Private _etaMaterial As Date

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
    <Persistent("f_quotation")> Property PenawaranDetail As Fusoh_PenawaranDetail
      Get
        Return _penawaranDetail
      End Get
      Set(value As Fusoh_PenawaranDetail)
        SetPropertyValue(Of Fusoh_PenawaranDetail)("PenawaranDetail", _penawaranDetail, value)
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
    <Persistent("d_poline")> Property POLine As Int32
      Get
        Return _poLine
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("POLine", _poLine, value)
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
    <Persistent("d_deliverydate")> Property DeliveryDate As Date
      Get
        Return _deliverydate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("DeliveryDate", _deliverydate, value)
      End Set
    End Property
    <Persistent("d_tglsanggup")> Property TanggalSanggup As Date
      Get
        Return _tanggalsanggup
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalSanggup", _tanggalsanggup, value)
      End Set
    End Property
    <Persistent("d_etamaterial")> Property ETAMaterial As Date
      Get
        Return _etaMaterial
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("ETAMaterial", _etaMaterial, value)
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
    <Association("fk_fusoh_so_sj"), Aggregated> ReadOnly Property SuratJalanDetail As XPCollection(Of Fusoh_SuratJalanDetail)
      Get
        Return GetCollection(Of Fusoh_SuratJalanDetail)("SuratJalanDetail")
      End Get
    End Property
    '[NonPersistent] public string DaftarTimNama => string.Join(",", DaftarTim.Select(s => s.Tim.Karyawan.Nama));
    '<NonPersistent()> ReadOnly Property SJListNo As String
    '  Get
    '    Return String.Join(",", SuratJalanDetail.Select(Function(s) s.Main.Kode))
    '  End Get
    'End Property
    '<NonPersistent()> ReadOnly Property SJListTanggal As String
    '  Get
    '    Return String.Join(",", SuratJalanDetail.Select(Function(s) s.Main.Tanggal.ToShortDateString))
    '  End Get
    'End Property
    <NonPersistent()> ReadOnly Property SJListData As String
      Get
        Return String.Join(",", SuratJalanDetail.Select(Function(s) String.Concat(s.Main.Kode, " (", s.Main.Tanggal.ToShortDateString, ")")))
      End Get
    End Property

    <PersistentAlias("SuratJalanDetail.Sum(QtySJ)")> ReadOnly Property QtyKirim As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtyKirim"))
      End Get
    End Property
    <PersistentAlias("Qty - isnull(QtyKirim,0)")> ReadOnly Property QtySisa As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtySisa"))
      End Get
    End Property
    <Association("fk_dempyou_orderpenjualandetail"), Aggregated> ReadOnly Property Dempyou As XPCollection(Of Fusoh_OrderProduksi)
      Get
        Return GetCollection(Of Fusoh_OrderProduksi)("Dempyou")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property JumlahDempyou As Integer
      Get
        Return Dempyou.Count
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

  Friend Class Fusoh_OrderPenjualanDetail_Impor
    Property POLine As String
    Property KodeBarang As String
    Property NamaBarang As String
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
    Property OutDiameter As Decimal
    Property InDiameter As Decimal
    Property Thickness As Decimal
    Property Length As Decimal
    Property Qty As Double
    'Property Weight As Decimal
    Property Harga As Double
    Property Catatan As String
    Property NoPODetail As String
    Property DeliveryDate As Date

    ReadOnly Property Weight As Double
      Get
        Return NuSoft004.FusohLogic.Item.GetWeight(OutDiameter, Length, Thickness)
      End Get
    End Property
    ReadOnly Property SubTotal As Double
      Get
        Return Qty * Harga
      End Get
    End Property
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
    Private _urgent As Boolean

    <Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
      End Set
    End Property
    <Persistent("f_sodetail"), Association("fk_dempyou_orderpenjualandetail")> Property SODetail As Fusoh_OrderPenjualanDetail
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
    <Persistent("d_urgent")> Property Urgent As Boolean
      Get
        Return _urgent
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Urgent", _urgent, value)
      End Set
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Order Produksi"
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
      If SODetail Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor PO Pelanggan", -5, "", source)
        Return False
      End If
      If String.IsNullOrEmpty(NomorLot) Then
        Throw New Utils.Exception("Masukkan nomor lot", -6, "", source)
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

  Friend Class FusohSOTracking
    Property SOD As Fusoh_OrderPenjualanDetail
    Property QtySJ1 As Double
    Property QtySJ2 As Double
    Property QtySJ3 As Double
    Property QtySJ4 As Double
    Property QtySJ5 As Double
    Property QtySJ6 As Double
    Property QtySJ7 As Double
    Property QtySJ8 As Double
    Property QtySJ9 As Double
    Property QtySJ10 As Double
    Property TglSJ1 As String
    Property TglSJ2 As String
    Property TglSJ3 As String
    Property TglSJ4 As String
    Property TglSJ5 As String
    Property TglSJ6 As String
    Property TglSJ7 As String
    Property TglSJ8 As String
    Property TglSJ9 As String
    Property TglSJ10 As String
    Property CatatanJali As String
  End Class

  '<Persistent("m04vwstocktacking")> Friend Class FusohSOTracking
  '  Inherits XPLiteObject
  '  Public Sub New(ByVal session As Session)
  '    MyBase.New(session)
  '  End Sub
  '  Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
  '    MyBase.New(session, classInfo)
  '  End Sub
  '  <Key()> Property Id As Int64
  '  Property SOD As Fusoh_OrderPenjualanDetail
  '  Property QtySJ1 As Double
  '  Property QtySJ2 As Double
  '  Property QtySJ3 As Double
  '  Property QtySJ4 As Double
  '  Property QtySJ5 As Double
  '  Property QtySJ6 As Double
  '  Property QtySJ7 As Double
  '  Property QtySJ8 As Double
  '  Property QtySJ9 As Double
  '  Property QtySJ10 As Double
  '  Property TglSJ1 As Date
  '  Property TglSJ2 As Date
  '  Property TglSJ3 As Date
  '  Property TglSJ4 As Date
  '  Property TglSJ5 As Date
  '  Property TglSJ6 As Date
  '  Property TglSJ7 As Date
  '  Property TglSJ8 As Date
  '  Property TglSJ9 As Date
  '  Property TglSJ10 As Date

  'End Class
End Namespace