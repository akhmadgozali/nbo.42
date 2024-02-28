Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m04cstockmain")> Friend Class Fusoh_SuratJalan
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _kontakperson As String
    Private _nokendaraan As String
    Private _jenisKendaraan As String
    Private _supir As String
    Private _dempyouLot As String
    Private _orderProduksi As NuSoft004.Persistent.Fusoh_OrderProduksi

    Private _kurs As Double
    Private _sjOtomatisProduksi As Boolean
		Private _revisi As Int16

		<Persistent("d_rev")> Property Revisi As Int16
			Get
				Return _revisi
			End Get
			Set(value As Int16)
				SetPropertyValue(Of Int16)("Revisi", _revisi, value)
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
    <Persistent("d_nodocument")> Property JenisKendaraan As String
      Get
        Return _jenisKendaraan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("JenisKendaraan", _jenisKendaraan, value)
      End Set
    End Property
    <Persistent("d_driver")> Property Supir As String
      Get
        Return _supir
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Supir", _supir, value)
      End Set
    End Property
    <Persistent("d_novehicle")> Property NoKendaraan As String
      Get
        Return _nokendaraan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoKendaraan", _nokendaraan, value)
      End Set
    End Property
    <Persistent("d_dempyoulot")> Property DempyouLot As String
      Get
        Return _dempyouLot
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("DempyouLot", _dempyouLot, value)
      End Set
    End Property
    <Persistent("f_iddempyou")> Property OrderProduksi As NuSoft004.Persistent.Fusoh_OrderProduksi
      Get
        Return _orderProduksi
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_OrderProduksi)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_OrderProduksi)("OrderProduksi", _orderProduksi, value)
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
    <Persistent("SJOtomatisProduksi")> Property SJOtomatisProduksi As Boolean
      Get
        Return _sjOtomatisProduksi
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("SJOtomatisProduksi", _sjOtomatisProduksi, value)
      End Set
    End Property


    <Association("fk_fusoh_surat_jalan"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_SuratJalanDetail)
      Get
        Return GetCollection(Of Fusoh_SuratJalanDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(QtyProduksi)")> ReadOnly Property TotalQtyProduksi As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQtyProduksi"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Surat Jalan [SJ]"
      If IsDeleted Then
        Return True
      End If
      'If Regional Is Nothing Then
      '	Throw New Utils.Exception("Masukkan regional", -1, "", source)
      '	Return False
      'End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Pelanggan Is Nothing AndAlso (Sumber.Id <> SumberDataJenis.BS AndAlso Sumber.Id <> SumberDataJenis.AM) Then
        Throw New Utils.Exception("Masukkan pelanggan", -3, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -4, "", source)
        Return False
      End If
      If Sumber.Id = SumberDataJenis.SJ Then
        If String.IsNullOrEmpty(Supir) Then
          Throw New Utils.Exception("Masukkan nama supir", -5, "", source)
          Return False
        End If
        If String.IsNullOrEmpty(NoKendaraan) Then
          Throw New Utils.Exception("Masukkan nomor kendaran", -6, "", source)
          Return False
        End If
        If String.IsNullOrEmpty(JenisKendaraan) Then
          Throw New Utils.Exception("Masukkan jenis kendaran", -7, "", source)
          Return False
        End If

        If TotalQty = 0 Then
          Throw New Utils.Exception("Masukkan nilai qty", -99, "", source)
        End If
      End If
      ''======= Cek Periode
      'If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
      '  Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
      '  Return False
      'End If
      ''======= Cek Sebelum Awal Periode
      'If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
      '  Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
      '  Return False
      'End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -98, "", source)
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
  <Persistent("m04dstockdetail")> Friend Class Fusoh_SuratJalanDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_SuratJalan
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _catatan As String
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _qtyProduksi As Double
    'Private _qtyout As Double
    Private _harga As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _noPallet As String
    Private _grossWeight As Decimal
    Private _soDetail As Fusoh_OrderPenjualanDetail
    Private _produksiDetail As Fusoh_SuratJalanDetail
    Private _TotalHPP As Double

    Private _eximDetail As Nullable(Of Long)


    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_surat_jalan")> Property Main As Fusoh_SuratJalan
      Get
        Return _main
      End Get
      Set(value As Fusoh_SuratJalan)
        SetPropertyValue(Of Fusoh_SuratJalan)("Main", _main, value)
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
    <Persistent("d_qtyin")> Property QtyProduksi As Double
      Get
        Return _qtyProduksi
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyProduksi", _qtyProduksi, value)
      End Set
    End Property
    <Persistent("d_qtyout")> Property Qty As Double
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
    <Persistent("d_nopallet")> Property NoPallet As String
      Get
        Return _noPallet
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoPallet", _noPallet, value)
      End Set
    End Property
    <Persistent("d_grossweight")> Property GrossWeight As Decimal
      Get
        Return _grossWeight
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("GrossWeight", _grossWeight, value)
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
    <Persistent("f_idsod"), Association("fk_fusoh_so_sj")> Property SODetail As Fusoh_OrderPenjualanDetail
      Get
        Return _soDetail
      End Get
      Set(value As Fusoh_OrderPenjualanDetail)
        SetPropertyValue(Of Fusoh_OrderPenjualanDetail)("SODetail", _soDetail, value)
      End Set
    End Property
    '<NonPersistent()> ReadOnly Property QtySJ As Double
    '	Get
    '		If Main.Sumber.Kode = "FD" Then
    '			Return _qty
    '		Else
    '			Return 0
    '		End If
    '	End Get
    'End Property
    <PersistentAlias("Iif(Main.Sumber.Kode = 'FD', Qty, 0)")> ReadOnly Property QtySJ As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtySJ"))
      End Get
    End Property
    <Persistent("f_idproduksid"), Association("FusohSuratJalanDetail_Produksi")> Property ProduksiDetail As Fusoh_SuratJalanDetail
      Get
        Return _produksiDetail
      End Get
      Set(value As Fusoh_SuratJalanDetail)
        SetPropertyValue(Of Fusoh_SuratJalanDetail)("ProduksiDetail", _produksiDetail, value)
      End Set
    End Property


    <Persistent("f_ideximmd")> Property EximDetail As Nullable(Of Long)
      Get
        Return _eximDetail
      End Get
      Set(value As Nullable(Of Long))
        SetPropertyValue(Of Nullable(Of Long))("EximDetail", _eximDetail, value)
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
      Dim source As String = "Surat Jalan [SJ]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama surat jalan", -99, "", source)
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
      'If String.IsNullOrEmpty(NoPallet) Then
      '	Throw New Utils.Exception("Masukkan nama pallet", -99, "", source)
      '	Return False
      'End If

      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub

    <Association("FusohSuratJalanDetail_Produksi")> ReadOnly Property ProduksiCollection As XPCollection(Of Fusoh_SuratJalanDetail)
      Get
        Return GetCollection(Of Fusoh_SuratJalanDetail)("ProduksiCollection")
      End Get
    End Property
    <Association("FusohSuratJalanDetail_Serial")> ReadOnly Property Serial As XPCollection(Of Fusoh_SuratJalanDetailSerial)
      Get
        Return GetCollection(Of Fusoh_SuratJalanDetailSerial)("Serial")
      End Get
    End Property

    <NonPersistent> Property SisaQty As Double
  End Class
  <Persistent("m04estockdetailserial")> Friend Class Fusoh_SuratJalanDetailSerial
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _detail As Fusoh_SuratJalanDetail
    Private _millSheet As String
    Private _serial As String
    Private _lengthIn As Double
    Private _lengthOut As Double
    Private _qty As Double

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("FusohSuratJalanDetail_Serial")> Property DetailMain As Fusoh_SuratJalanDetail
      Get
        Return _detail
      End Get
      Set(value As Fusoh_SuratJalanDetail)
        SetPropertyValue(Of Fusoh_SuratJalanDetail)("DetailMain", _detail, value)
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
    <Persistent("d_serial")> Property Serial As String
      Get
        Return _serial
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Serial", _serial, value)
      End Set
    End Property
    <Persistent("d_length_in")> Property LengthIn As Double
      Get
        Return _lengthIn
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("LengthIn", _lengthIn, value)
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

    <PersistentAlias("LengthIn - LengthOut")> ReadOnly Property SisaLength As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SisaLength"))
      End Get
    End Property
    '<PersistentAlias("iif(LengthIn = 0 , 0 , (DetailMain.Barang.Weight * (LengthIn / DetailMain.Barang.Length)))")> ReadOnly Property WeightIN As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("WeightIN")) '(DetailMain.Barang.Weight * (x.LengthIn / x.DetailMain.Barang.Length))
    '	End Get
    'End Property
    '<PersistentAlias("iif(LengthOut = 0 , 0 , ((LengthOut / DetailMain.Barang.Length) * DetailMain.Weight))")> ReadOnly Property WeightOUT As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("WeightOUT"))
    '	End Get
    'End Property
    'Private Function CheckData() As Boolean
    '	Dim source As String = "Produksi [AM]"
    '	If IsDeleted Then
    '		Return True
    '	End If

    '	If _detail Is Nothing AndAlso Not IsDeleted Then
    '		Throw New Utils.Exception("Masukkan data utama produksi detail", -99, "", source)
    '		Return False
    '	End If
    '	If _serial = Nothing Then
    '		Throw New Utils.Exception("Masukkan data serial", -99, "", source)
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
  End Class


  <Persistent("m05cmaininvoicereceipt")> Friend Class Fusoh_05PenerimaanInvoicePembelian
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _vendor As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    'Private _tipe As eTipeInvoicePembelian
    Private _tglberlaku As Date
    Private _arriveddate As Date
    Private _bldate As Date
    'Private _termin As Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    'Private _jenispajak As eJenisPajak
    'Private _pajak As eTipePajak
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    'Private _noorder As Fusoh_OrderPembelian
    'Private _noexim As Fusoh_Exim
    'Private _noparent As Fusoh_PenerimaanInvoice
    Private _nilaisaldoawal As Double
    Private _noreffvendor As String
    'Private _jenisCostSheet As String

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
    '<Persistent("d_tipe")>
    'Property TipeTransaksi As Persistent.eTipeInvoicePembelian
    '	Get
    '		Return _tipe
    '	End Get
    '	Set(value As Persistent.eTipeInvoicePembelian)
    '		SetPropertyValue(Of Persistent.eTipeInvoicePembelian)("TipeTransaksi", _tipe, value)
    '	End Set
    'End Property
    <Persistent("d_duedate")>
    Property TanggalBerlaku As Date
      Get
        Return _tglberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerlaku", _tglberlaku, value)
      End Set
    End Property
    <Persistent("d_arriveddate")> Property ArrivedDate As Date
      Get
        Return _arriveddate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("ArrivedDate", _arriveddate, value)
      End Set
    End Property
    <Persistent("d_bldate")> Property BLDate As Date
      Get
        Return _bldate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("BLDate", _bldate, value)
      End Set
    End Property
    '<Persistent("f_termin")>
    'Property Termin As Persistent.Termin
    '	Get
    '		Return _termin
    '	End Get
    '	Set(value As Persistent.Termin)
    '		SetPropertyValue(Of Persistent.Termin)("Termin", _termin, value)
    '	End Set
    'End Property
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
    '<Persistent("d_taxcaption")>
    'Property JenisPajak As eJenisPajak
    '	Get
    '		Return _jenispajak
    '	End Get
    '	Set(value As eJenisPajak)
    '		SetPropertyValue(Of eJenisPajak)("JenisPajak", _jenispajak, value)
    '	End Set
    'End Property
    '<Persistent("d_taxtype")>
    'Property TipePajak As eTipePajak
    '	Get
    '		Return _pajak
    '	End Get
    '	Set(value As eTipePajak)
    '		SetPropertyValue(Of eTipePajak)("TipePajak", _pajak, value)
    '	End Set
    'End Property
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

    <Persistent("d_taxsnppn")> Property NoSNPPN As String
      Get
        Return _nosnppn
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPN", _nosnppn, value)
      End Set
    End Property
    <Persistent("d_taxsnpph")> Property NoSNPPh As String
      Get
        Return _nosnpph
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPh", _nosnpph, value)
      End Set
    End Property
    <Persistent("d_externalnumber")> Property NoReffVendor As String
      Get
        Return _noreffvendor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoReffVendor", _noreffvendor, value)
      End Set
    End Property

    '<Persistent("p_idorder")> Property NoOrder As Fusoh_OrderPembelian
    '	Get
    '		Return _noorder
    '	End Get
    '	Set(value As Fusoh_OrderPembelian)
    '		SetPropertyValue(Of Fusoh_OrderPembelian)("NoOrder", _noorder, value)
    '	End Set
    'End Property
    '<Persistent("p_idexim")> Property NoExim As Fusoh_Exim
    '	Get
    '		Return _noexim
    '	End Get
    '	Set(value As Fusoh_Exim)
    '		SetPropertyValue(Of Fusoh_Exim)("NoExim", _noexim, value)
    '	End Set
    'End Property
    '<Persistent("p_idparent"), Association("fk_fusoh_invoice_detail_cost")> Property IndukInvoice As Fusoh_PenerimaanInvoice
    '	Get
    '		Return _noparent
    '	End Get
    '	Set(value As Fusoh_PenerimaanInvoice)
    '		SetPropertyValue(Of Fusoh_PenerimaanInvoice)("IndukInvoice", _noparent, value)
    '	End Set
    'End Property

    'property untuk saldo awal hutang
    <Persistent("d_bbvalue")> Property NilaiSaldoAwal As Double
      Get
        Return _nilaisaldoawal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiSaldoAwal", _nilaisaldoawal, value)
      End Set
    End Property

    <Association("fk_05fusoh_invoicepembelian_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_05PenerimaanInvoicePembelianDetail)
      Get
        Return GetCollection(Of Fusoh_05PenerimaanInvoicePembelianDetail)("Detail")
      End Get
    End Property
    '<Association("fk_fusoh_invoice_detail_cost"), Aggregated> ReadOnly Property DetailCost As XPCollection(Of Fusoh_PenerimaanInvoice)
    '	Get
    '		Return GetCollection(Of Fusoh_PenerimaanInvoice)("DetailCost")
    '	End Get
    'End Property
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
    ''''<PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
    ''''	Get
    ''''		Return Convert.ToDouble(EvaluateAlias("Total"))
    ''''	End Get
    ''''End Property
    '''''<PersistentAlias("(SubTotal + PPN - PPH) * Kurs")> ReadOnly Property TotalIDR As Double
    ''''	Get
    ''''		Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
    ''''	End Get
    ''''End Property
    '<PersistentAlias("Detail.Sum(Total)")> ReadOnly Property Total As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("Total"))
    '	End Get
    'End Property
    '<PersistentAlias("Detail.Sum(TotalIDR)")> ReadOnly Property TotalIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
    '	End Get
    'End Property

    '<PersistentAlias("Detail.Sum(Weight)")> ReadOnly Property TotalWeight As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalWeight"))
    '	End Get
    'End Property

    '<PersistentAlias("DetailCost.Sum(Total)")> ReadOnly Property TotalCost As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalCost"))
    '	End Get
    'End Property
    '<PersistentAlias("DetailCost.Sum(TotalIDR)")> ReadOnly Property TotalCostIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostIDR"))
    '	End Get
    'End Property
    '<PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
    '	Get
    '		Return Convert.ToString(EvaluateAlias("Terbilang"))
    '	End Get
    'End Property
    '<PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
    '	Get
    '		Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
    '	End Get
    'End Property

    '<PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalQty"))
    '	End Get
    'End Property

    '<PersistentAlias("Total + TotalCost")> ReadOnly Property TotalPembelian As Double
    '	Get
    '		'Return Total + TotalCost
    '		Return Convert.ToDouble(EvaluateAlias("TotalPembelian"))
    '	End Get
    'End Property
    '<PersistentAlias("TotalIDR + TotalCostIDR")> ReadOnly Property TotalPembelianIDR As Double
    '	Get
    '		'Return Total + TotalCost
    '		Return Convert.ToDouble(EvaluateAlias("TotalPembelianIDR"))
    '	End Get
    'End Property

    'Private Function CheckData() As Boolean
    '	Dim source As String = "Penerimaan Invoice [RI]"
    '	If Regional Is Nothing Then
    '		Throw New Utils.Exception("Masukkan regional", -1, "", source)
    '		Return False
    '	End If
    '	If Tanggal = Nothing Then
    '		Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
    '		Return False
    '	End If
    '	If Vendor Is Nothing Then
    '		Throw New Utils.Exception("Masukkan Vendor", -3, "", source)
    '		Return False
    '	End If
    '	If Uang Is Nothing Then
    '		Throw New Utils.Exception("Masukkan mata uang", -4, "", source)
    '	End If
    '	If TipeTransaksi = eTipeInvoicePembelian.PakaiPO AndAlso NoOrder Is Nothing Then
    '		Throw New Utils.Exception("Masukkan PO", -5, "", source)
    '	End If
    '	If String.IsNullOrEmpty(NoReffVendor) Then
    '		Throw New Utils.Exception("Masukkan nomor invoice dari vendor", -6, "", source)
    '	End If
    '	'If Not Detail.Count > 0 Then
    '	'	Throw New Utils.Exception("Masukkan detail invoice", -99, "", source)
    '	'End If

    '	'If Uang.Id <> Uang.HutangDagang.MataUang.Id Then
    '	'	Throw New Utils.Exception("Mata uang untuk coa [Hutang Dagang] tidak sama dengan mata uang transaksi", -7, "", source)
    '	'End If
    '	If Session.IsNewObject(Me) Then
    '		If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
    '			Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -98, "", source)
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


    ''==================== pemisahan import duty dan bukan
    '<PersistentAlias("Detail.Sum(TotalBukanImportDuty)")> ReadOnly Property TotalBukanImportDuty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("Detail.Sum(TotalBukanImportDutyIDR)")> ReadOnly Property TotalBukanImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDutyIDR"))
    '	End Get
    'End Property
    '<PersistentAlias("Detail.Sum(TotalImportDuty)")> ReadOnly Property TotalImportDuty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("Detail.Sum(TotalImportDutyIDR)")> ReadOnly Property TotalImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalImportDutyIDR"))
    '	End Get
    'End Property
    '<PersistentAlias("Detail.Sum(TotalKenaImportDuty)")> ReadOnly Property TotalKenaImportDuty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("Detail.Sum(TotalKenaImportDutyIDR)")> ReadOnly Property TotalKenaImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDutyIDR"))
    '	End Get
    'End Property

    '<PersistentAlias("DetailCost.Sum(TotalBukanImportDuty)")> ReadOnly Property TotalCostBukanImportDuty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("DetailCost.Sum(TotalBukanImportDutyIDR)")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDutyIDR"))
    '	End Get
    'End Property
    '<PersistentAlias("DetailCost.Sum(TotalImportDuty)")> ReadOnly Property TotalCostImportDuty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("DetailCost.Sum(TotalImportDutyIDR)")> ReadOnly Property TotalCostImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
    '	End Get
    'End Property
  End Class
  <Persistent("m05ddetailinvoicereceipt")> Friend Class Fusoh_05PenerimaanInvoicePembelianDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_05PenerimaanInvoicePembelian
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _qty As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _disc As Double
    Private _discp As Double
    Private _catatan As String
    'Private _idpo As Fusoh_OrderPembelianDetail
    'Private _idexim As Fusoh_EximDetail
    Private _idexim As Long
    Private _kenaImportDuty As Boolean
    Private _totalCostImportDuty As Double

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_05fusoh_invoicepembelian_detail")> Property Main As Fusoh_05PenerimaanInvoicePembelian
      Get
        Return _main
      End Get
      Set(value As Fusoh_05PenerimaanInvoicePembelian)
        SetPropertyValue(Of Fusoh_05PenerimaanInvoicePembelian)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
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
    '<Persistent("f_idpo")> Property PODetail As Fusoh_OrderPembelianDetail
    '	Get
    '		Return _idpo
    '	End Get
    '	Set(value As Fusoh_OrderPembelianDetail)
    '		SetPropertyValue(Of Fusoh_OrderPembelianDetail)("PODetail", _idpo, value)
    '	End Set
    'End Property
    '<Persistent("f_idexim")> Property EximDetail As Fusoh_EximDetail
    '	Get
    '		Return _idexim
    '	End Get
    '	Set(value As Fusoh_EximDetail)
    '		SetPropertyValue(Of Fusoh_EximDetail)("EximDetail", _idexim, value)
    '	End Set
    'End Property
    <Persistent("f_idexim")> Property EximDetail As Long
      Get
        Return _idexim
      End Get
      Set(value As Long)
        SetPropertyValue(Of Long)("EximDetail", _idexim, value)
      End Set
    End Property
    <Persistent("d_isimportduty")> Property KenaImportDuty As Boolean
      Get
        Return _kenaImportDuty
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("KenaImportDuty", _kenaImportDuty, value)
      End Set
    End Property

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
    '<PersistentAlias("(Qty * Harga)-(Qty * Discount)")> ReadOnly Property SubTotal As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("SubTotal"))
    '	End Get
    'End Property
    '<PersistentAlias("iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal)")> ReadOnly Property Total As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("Total"))
    '	End Get
    'End Property
    '<PersistentAlias("Total * Main.Kurs")> ReadOnly Property TotalIDR As Double
    '	Get
    '		'Return Total * Main.Kurs
    '		Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
    '	End Get
    'End Property
    '<PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("DPP"))
    '	End Get
    'End Property
    '<PersistentAlias("Harga * Main.Kurs")> ReadOnly Property HargaIDR As Double
    '	Get
    '		'Return Harga * Main.Kurs
    '		Return Convert.ToDouble(EvaluateAlias("HargaIDR"))
    '	End Get
    'End Property

    '<PersistentAlias("EximDetail.Weight")> ReadOnly Property Weight As Decimal
    '	Get
    '		Return Convert.ToDecimal(EvaluateAlias("Weight"))
    '	End Get
    'End Property

    '<PersistentAlias("TotalCostBukanImportDuty + TotalCostImportDuty")> ReadOnly Property TotalCost As Double
    '	Get
    '		'Return (Total / Main.Total) * Main.TotalCost
    '		Return Convert.ToDouble(EvaluateAlias("TotalCost"))
    '	End Get
    'End Property
    '<PersistentAlias("TotalCostBukanImportDutyIDR + TotalCostImportDutyIDR")> ReadOnly Property TotalCostIDR As Double
    '	Get
    '		'Return (Total / Main.TotalIDR) * Main.TotalCostIDR
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostIDR"))
    '	End Get
    'End Property
    '<PersistentAlias("Total + TotalCost")> ReadOnly Property TotalPembelian As Double
    '	Get
    '		'Return Total + TotalCost
    '		Return Convert.ToDouble(EvaluateAlias("TotalPembelian"))
    '	End Get
    'End Property
    '<PersistentAlias("TotalIDR + TotalCostIDR")> ReadOnly Property TotalPembelianIDR As Double
    '	Get
    '		'Return TotalIDR + TotalCostIDR
    '		Return Convert.ToDouble(EvaluateAlias("TotalPembelianIDR"))
    '	End Get
    'End Property
    'Private Function CheckData() As Boolean
    '	Dim source As String = ClassInfo.FullName
    '	If _main Is Nothing AndAlso Not IsDeleted Then
    '		Throw New Utils.Exception("Masukkan data utama Penerimaan Invoice", -99, "", source)
    '		Return False
    '	End If
    '	If _item Is Nothing Then
    '		Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
    '		Return False
    '	End If
    '	If _qty = Nothing Then
    '		Throw New Utils.Exception("Masukkan qty", -99, "", source)
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

    ''==================== pemisahan import duty dan bukan
    ''=============== cost sheet detail
    '<PersistentAlias("iif(Barang.Custom1='" & Fusoh_Logic.Umum.ImportDutyCustom & "',0,iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal))")> ReadOnly Property TotalBukanImportDuty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("TotalBukanImportDuty * Main.Kurs")> ReadOnly Property TotalBukanImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDutyIDR"))
    '	End Get
    'End Property
    '<PersistentAlias("iif(Barang.Custom1='" & Fusoh_Logic.Umum.ImportDutyCustom & "',iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal),0)")> ReadOnly Property TotalImportDuty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("TotalImportDuty * Main.Kurs")> ReadOnly Property TotalImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalImportDutyIDR"))
    '	End Get
    'End Property

    ''----------- Invoice Weight
    ''<PersistentAlias("iif(KenaImportDuty,Total,0)")> ReadOnly Property TotalKenaImportDuty As Double
    ''<PersistentAlias("iif(KenaImportDuty,Weight,0)")> ReadOnly Property TotalKenaImportDuty As Double
    '<PersistentAlias("iif(TotalCostImportDuty > 0,Weight,0)")> ReadOnly Property TotalKenaImportDuty As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDuty"))
    '	End Get
    'End Property
    ''<PersistentAlias("iif(KenaImportDuty,TotalIDR,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
    ''<PersistentAlias("iif(KenaImportDuty,Weight,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
    '<PersistentAlias("iif(TotalCostImportDuty > 0,Weight,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDutyIDR"))
    '	End Get
    'End Property
    ''<PersistentAlias("(Total / Main.Total) * Main.TotalCostBukanImportDuty")> ReadOnly Property TotalCostBukanImportDuty As Double
    '<PersistentAlias("(Weight / Main.TotalWeight) * Main.TotalCostBukanImportDuty")> ReadOnly Property TotalCostBukanImportDuty As Double
    '	Get
    '		'Return (Total / Main.Total) * Main.TotalCostBukanImportDuty
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDuty"))
    '	End Get
    'End Property
    ''<PersistentAlias("(TotalIDR / Main.TotalIDR) * Main.TotalCostBukanImportDutyIDR")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
    '<PersistentAlias("(Weight / Main.TotalWeight) * Main.TotalCostBukanImportDutyIDR")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
    '	Get
    '		'Return (Total / Main.TotalIDR) * Main.TotalCostBukanImportDutyIDR
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDutyIDR"))
    '	End Get
    'End Property
    ''<PersistentAlias("iif(KenaImportDuty,(TotalKenaImportDuty / Main.TotalKenaImportDuty) * Main.TotalCostImportDuty,0)")> ReadOnly Property TotalCostImportDuty As Double
    ''	Get
    ''		'Return (Total / Main.Total) * Main.TotalCostImportDuty
    ''		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDuty"))
    ''	End Get
    ''End Property
    ''<PersistentAlias("iif(KenaImportDuty,(TotalKenaImportDutyIDR / Main.TotalKenaImportDutyIDR) * Main.TotalCostImportDutyIDR,0)")> ReadOnly Property TotalCostImportDutyIDR As Double
    ''	Get
    ''		'Return (Total / Main.TotalIDR) * Main.TotalCostImportDutyIDR
    ''		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
    ''	End Get
    ''End Property
    '<Persistent("TotalCostImportDuty")> Property TotalCostImportDuty As Double
    '	Get
    '		Return _totalCostImportDuty
    '	End Get
    '	Set(value As Double)
    '		SetPropertyValue(Of Double)("TotalCostImportDuty", _totalCostImportDuty, value)
    '	End Set
    'End Property
    '<PersistentAlias("TotalCostImportDuty * Main.Kurs")> ReadOnly Property TotalCostImportDutyIDR As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
    '	End Get
    'End Property

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
  End Class


  <Persistent("m04vwproduksi")> Friend Class FusohVwProduksi
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Fusoh_SuratJalanDetail
    Property Kode As String
    Property KodeItem As String
    Property NamaItem As String
    Property Tanggal As Date
    Property NoPDO As String
    Property LOT As String
    Property QtyIN As Double
    Property QtyKirim As Double
    <PersistentAlias("QtyIN - QtyKirim")> ReadOnly Property QtySisa As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtySisa"))
      End Get
    End Property
  End Class
End Namespace