Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports DevExpress.Data.Filtering
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  Public Enum eSanYuJenisPenjualan
    <EnumDescription("Pce")> pPce = 0
    <EnumDescription("Meter")> pMeter = 1
    <EnumDescription("Feet")> pFeet = 2
  End Enum

  <Persistent("m01bcontactview")> Public Class SanYu_Kontak
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
      Const sumber As String = "Kontak"
      If _Kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode kontak", -2, "", sumber)
        Return False
      End If
      If _Nama Is Nothing Then
        Throw New Utils.Exception("Masukkan nama kontak", -3, "", sumber)
        Return False
      End If
      Return True
    End Function

    <Indexed("Kode", Unique:=True)>
    Private _Id As Int64
    Private _tipeKontak As NuSoft001.Persistent.TipeKontak
    Private _Kode As String
    Private _Nama As String
    Private _JenisPenjualan As eSanYuJenisPenjualan
    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _Id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("f_contacttype")> Property TipeKontak As NuSoft001.Persistent.TipeKontak
      Get
        Return _tipeKontak
      End Get
      Set(value As NuSoft001.Persistent.TipeKontak)
        SetPropertyValue(Of NuSoft001.Persistent.TipeKontak)("TipeKontak", _tipeKontak, value)
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
    <Persistent("d_jenispenjualan")> Property JenisPenjualan As eSanYuJenisPenjualan
      Get
        Return _JenisPenjualan
      End Get
      Set(value As eSanYuJenisPenjualan)
        SetPropertyValue(Of eSanYuJenisPenjualan)("JenisPenjualan", _JenisPenjualan, value)
      End Set
    End Property

  End Class

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
    Private _jenispenjualan As eSanYuJenisPenjualan
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
    '<Persistent("d_jenispenjualan")> Property JenisPenjualan As eSanYuJenisPenjualan
    '  Get
    '    Return _jenispenjualan
    '  End Get
    '  Set(value As eSanYuJenisPenjualan)
    '    SetPropertyValue(Of eSanYuJenisPenjualan)("JenisPenjuaan", _jenispenjualan, value)
    '  End Set
    'End Property
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
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_note")> Property Catatan As String
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
    <PersistentAlias("QtyPcs * 2.95")> ReadOnly Property QtyMT As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtyMT"))
      End Get
    End Property
    <PersistentAlias("QtyPcs * 9.7")> ReadOnly Property QtyFT As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtyFT"))
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
    <Association("fk_sanyurencanaproduksi_sodetail"), Aggregated> ReadOnly Property RencanaProduksi As XPCollection(Of SanYu_RencanaProduksiDetail)
      Get
        Return GetCollection(Of SanYu_RencanaProduksiDetail)("RencanaProduksi")
      End Get
    End Property
    <PersistentAlias("RencanaProduksi.Sum(Qty)")> ReadOnly Property QtyRencanaProduksi As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtyRencanaProduksi"))
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

  <Persistent("m04cstockmain")> Friend Class SanYu_PengirimanBarang
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
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _dempyouLot As String
    Private _salesorder As Persistent.SanYu_OrderPenjualan
    Private _gl As GlMain
    Private _batchno As String
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
    <Persistent("f_idso")> Property OrderPenjualan As Persistent.SanYu_OrderPenjualan
      Get
        Return _salesorder
      End Get
      Set(value As Persistent.SanYu_OrderPenjualan)
        SetPropertyValue(Of Persistent.SanYu_OrderPenjualan)("OrderPenjualan", _salesorder, value)
      End Set
    End Property
    <Association("fk_Sanyustokmain_Sanyustokdetail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PengirimanBarangDetail)
      Get
        Return GetCollection(Of SanYu_PengirimanBarangDetail)("Detail")
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
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
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
  <Persistent("m04dstockdetail")> Friend Class SanYu_PengirimanBarangDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PengirimanBarang
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _item As NuSoft004.Persistent.SanYu_Barang
    Private _satuan As NuSoft004.Persistent.Satuan
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
    Private _kontainer As String
    Private _orderpenjualandetail As Persistent.SanYu_OrderPenjualanDetail
    Private _idproduksi As SanYu_PengirimanBarangDetail
    Private _batchno As String

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_Sanyustokmain_Sanyustokdetail")> Property Main As SanYu_PengirimanBarang
      Get
        Return _main
      End Get
      Set(value As SanYu_PengirimanBarang)
        SetPropertyValue(Of SanYu_PengirimanBarang)("Main", _main, value)
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
    <Persistent("f_item")> Property Barang As NuSoft004.Persistent.SanYu_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.SanYu_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.SanYu_Barang)("Barang", _item, value)
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
    <Persistent("d_kontainer")> Property Kontainer As String
      Get
        Return _kontainer
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kontainer", _kontainer, value)
      End Set
    End Property

    <Persistent("f_idsod")> Property OrderPenjualan As Persistent.SanYu_OrderPenjualanDetail
      Get
        Return _orderpenjualandetail
      End Get
      Set(value As Persistent.SanYu_OrderPenjualanDetail)
        SetPropertyValue(Of Persistent.SanYu_OrderPenjualanDetail)("OrderPenjualan", _orderpenjualandetail, value)
      End Set
    End Property
    <Persistent("f_idproduksid")> Property ProduksiID As Persistent.SanYu_PengirimanBarangDetail
      Get
        Return _idproduksi
      End Get
      Set(value As Persistent.SanYu_PengirimanBarangDetail)
        SetPropertyValue(Of Persistent.SanYu_PengirimanBarangDetail)("ProduksiID", _idproduksi, value)
      End Set
    End Property
    <Association("fk_Sanyustokdetail_Sanyustokdetailpacking"), Aggregated> ReadOnly Property DetailPacking As XPCollection(Of SanYu_PengirimanBarangDetailPackingList)
      Get
        Return GetCollection(Of SanYu_PengirimanBarangDetailPackingList)("DetailPacking")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Barang"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama penerimaan barang", -99, "", source)
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
  <Persistent("m04estockdetailpacking")> Friend Class SanYu_PengirimanBarangDetailPackingList
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PengirimanBarangDetail

    Private _karton As String
    Private _barang As NuSoft004.Persistent.SanYu_Barang
    Private _panjang As Double
    Private _lebar As Double
    Private _tebal As Double
    Private _volPcs As Double
    Private _volM3 As Double
    Private _volFeet As Double
    Private _volNW As Double
    Private _volGW As Double
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_Sanyustokdetail_Sanyustokdetailpacking")> Property MainDetail As SanYu_PengirimanBarangDetail
      Get
        Return _main
      End Get
      Set(value As SanYu_PengirimanBarangDetail)
        SetPropertyValue(Of SanYu_PengirimanBarangDetail)("MainDetail", _main, value)
      End Set
    End Property
    <Persistent("d_karton")> Property NoKarton As String
      Get
        Return _karton
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoKarton", _karton, value)
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

    <Persistent("d_volpcs")> Property VolPCS As Double
      Get
        Return _volPcs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("VolPCS", _volPcs, value)
      End Set
    End Property
    <Persistent("d_volm3")> Property VolM3 As Double
      Get
        Return _volM3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("VolM3", _volM3, value)
      End Set
    End Property
    <Persistent("d_volfeet")> Property VolFeet As Double
      Get
        Return _volFeet
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("VolFeet", _volFeet, value)
      End Set
    End Property
    <Persistent("d_nw")> Property VolNW As Double
      Get
        Return _volNW
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("VolNW", _volNW, value)
      End Set
    End Property
    <Persistent("d_gw")> Property VolGW As Double
      Get
        Return _volGW
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("VolGW", _volGW, value)
      End Set
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Packing List Detail"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama penerimaan barang", -99, "", source)
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


  <Persistent("m06emaininvoice")> Friend Class Sanyu_InvoicePenjualan
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _alamat As NuSoft001.Persistent.KontakAlamat
    Private _kontakperson As String
    Private _tipe As NuSoft004.Persistent.TipeTransaksi
    Private _tglberlaku As Date
    Private _termin As NuSoft005.Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _jenispajak As NuSoft005.Persistent.eJenisPajak
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _catatan As String
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    Private _noorder As Persistent.OrderPenjualan
    Private _gl As Persistent.GlMain
    Private _nilaidppersen As Double
    Private _taxp As Double
    Private _saldoawal As Double
    Private _suratjalan As Persistent.SanYu_PengirimanBarang
    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("f_address")>
    Property KontakAlamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _alamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("KontakAlamat", _alamat, value)
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
    <Persistent("f_jenis")>
    Property JenisTransaksi As NuSoft004.Persistent.TipeTransaksi
      Get
        Return _tipe
      End Get
      Set(value As NuSoft004.Persistent.TipeTransaksi)
        SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("JenisTransaksi", _tipe, value)
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
    Property Termin As NuSoft005.Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As NuSoft005.Persistent.Termin)
        SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
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
    Property JenisPajak As NuSoft005.Persistent.eJenisPajak
      Get
        Return _jenispajak
      End Get
      Set(value As NuSoft005.Persistent.eJenisPajak)
        SetPropertyValue(Of NuSoft005.Persistent.eJenisPajak)("JenisPajak", _jenispajak, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As NuSoft005.Persistent.eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As NuSoft005.Persistent.eTipePajak)
        SetPropertyValue(Of NuSoft005.Persistent.eTipePajak)("TipePajak", _pajak, value)
      End Set
    End Property
    <Persistent("d_remarks")>
    Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_note")>
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
    <Persistent("f_idorder")> Property NoPengiriman As Persistent.SanYu_PengirimanBarang
      Get
        Return _suratjalan
      End Get
      Set(value As Persistent.SanYu_PengirimanBarang)
        SetPropertyValue(Of Persistent.SanYu_PengirimanBarang)("NoOrder", _suratjalan, value)
      End Set
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
    <NonPersistent()> ReadOnly Property NilaiInvoice As Double
      Get
        Return Total
      End Get
    End Property
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property
    <Association("fk_sanyu_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Sanyu_InvoicePenjualanDetail)
      Get
        Return GetCollection(Of Sanyu_InvoicePenjualanDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Invoice Penjualan [IV]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Customer", -4, "", source)
        Return False
      End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
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
  <Persistent("m06fdetailinvoice")> Friend Class Sanyu_InvoicePenjualanDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.Sanyu_InvoicePenjualan
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
    Private _idsj As Persistent.SanYu_PengirimanBarangDetail
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_sanyu_invoice_detail")>
    Property Main As Sanyu_InvoicePenjualan
      Get
        Return _main
      End Get
      Set(value As Sanyu_InvoicePenjualan)
        SetPropertyValue(Of Sanyu_InvoicePenjualan)("Main", _main, value)
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
    <Persistent("f_idsj")>
    Property PengirimanBarang As Persistent.SanYu_PengirimanBarangDetail
      Get
        Return _idsj
      End Get
      Set(value As Persistent.SanYu_PengirimanBarangDetail)
        SetPropertyValue(Of Persistent.SanYu_PengirimanBarangDetail)("PengirimanBarang", _idsj, value)
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
    <PersistentAlias("(Qty * Harga) - Discount")> ReadOnly Property SubTotal As Double
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
        Throw New Utils.Exception("Masukkan data utama Invoice Penjualan", -99, "", source)
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
      'If QtyGR Is Nothing Then
      '    _qtygr = 0
      'End If
      MyBase.OnSaving()
    End Sub
  End Class

  'PEB
  <Persistent("m06cmainpeb")>
  Friend Class SanYu_PEB
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
    Private _invoice As Sanyu_InvoicePenjualan
    Private _fasilitas As Boolean
    Private _kiteNoPengajuan As String
    Private _kiteNoDokumen As String
    Private _kiteTglDokumen As Date
    Private _kiteKodeKNT As String
    Private _kiteUmur As Long
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
    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _vendor, value)
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
    Property InvoicePenjualan As Sanyu_InvoicePenjualan
      Get
        Return _invoice
      End Get
      Set(value As Sanyu_InvoicePenjualan)
        SetPropertyValue(Of Sanyu_InvoicePenjualan)("InvoicePembelian", _invoice, value)
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

    <Association("sanyu_fk_peb_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PEBDetail)
      Get
        Return GetCollection(Of SanYu_PEBDetail)("Detail")
      End Get
    End Property
    <Association("sanyu_fk_peb_biaya"), Aggregated> ReadOnly Property Biaya As XPCollection(Of SanYu_PEBBiaya)
      Get
        Return GetCollection(Of SanYu_PEBBiaya)("Biaya")
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
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Pelanggan", -4, "", source)
        Return False
      End If
      If _reffnumber Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor PEB", -5, "", source)
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
  <Persistent("m06ddetailpeb")>
  Friend Class SanYu_PEBDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PEB
    Private _idinvoice As Sanyu_InvoicePenjualanDetail
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
    Private _catatan As String
    Private _idsj As SanYu_PengirimanBarangDetail
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("sanyu_fk_peb_detail")>
    Property Main As SanYu_PEB
      Get
        Return _main
      End Get
      Set(value As SanYu_PEB)
        SetPropertyValue(Of SanYu_PEB)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_idinvoice")>
    Property InvoiceDetail As Persistent.Sanyu_InvoicePenjualanDetail
      Get
        Return _idinvoice
      End Get
      Set(value As Persistent.Sanyu_InvoicePenjualanDetail)
        SetPropertyValue(Of Persistent.Sanyu_InvoicePenjualanDetail)("InvoiceDetail", _idinvoice, value)
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
    <PersistentAlias("Qty * Harga")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("Total * Main.Kurs")> ReadOnly Property CIFKite As Double
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
    <Persistent("f_idsj")>
    Property PengirimanBarang As Persistent.SanYu_PengirimanBarangDetail
      Get
        Return _idsj
      End Get
      Set(value As Persistent.SanYu_PengirimanBarangDetail)
        SetPropertyValue(Of Persistent.SanYu_PengirimanBarangDetail)("PengirimanBarang", _idsj, value)
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
  <Persistent("m06fbiayapeb")>
  Friend Class SanYu_PEBBiaya
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PEB
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
    <Persistent("p_id"), Association("sanyu_fk_peb_biaya")>
    Property Main As SanYu_PEB
      Get
        Return _main
      End Get
      Set(value As SanYu_PEB)
        SetPropertyValue(Of SanYu_PEB)("Main", _main, value)
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

  <Persistent("m06fmainpayment")> Friend Class SanYu_PembayaranPiutang
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _customer As NuSoft001.Persistent.Kontak
    Private _uraian As String
    Private _pembayaranpajak As Boolean
    Private _coakasbank As NuSoft001.Persistent.Coa
    Private _kurs As Double
    Private _total As Double
    Private _totalvalas As Double
    Private _totaladminbank As Double
    Private _totaldiscount As Double
    Private _totalpembulatan As Double
    Private _totalpph As Double
    Private _nomorpph As String
    Private _tipepembayaran As BankCaraBayar
    Private _nomorpembayaran As String
    Private _nomorbank As String
    Private _tgltempo As Date
    Private _gl As GlMain
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum

    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
      End Set
    End Property
    <Persistent("d_taxpayment")>
    Property PembayaranPajak As Boolean
      Get
        Return _pembayaranpajak
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("PembayaranPajak", _pembayaranpajak, value)
      End Set
    End Property
    <Persistent("d_remarks")>
    Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("f_coa")>
    Property coakasbank As NuSoft001.Persistent.Coa
      Get
        Return _coakasbank
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("coakasbank", _coakasbank, value)
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
    <Persistent("d_value")>
    Property Total As Double
      Get
        Return _total
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Total", _total, value)
      End Set
    End Property
    <Persistent("d_valuevalas")>
    Property TotalValas As Double
      Get
        Return _totalvalas
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalValas", _totalvalas, value)
      End Set
    End Property
    <Persistent("d_bankadmin")>
    Property TotalAdminBank As Double
      Get
        Return _totaladminbank
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalAdminBank", _totaladminbank, value)
      End Set
    End Property
    <Persistent("d_discount")>
    Property TotalDiscount As Double
      Get
        Return _totaldiscount
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalDiscount", _totaldiscount, value)
      End Set
    End Property
    <Persistent("d_rounding")>
    Property TotalPembulatan As Double
      Get
        Return _totalpembulatan
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalPembulatan", _totalpembulatan, value)
      End Set
    End Property
    <Persistent("d_pphvalue")>
    Property TotalPPH As Double
      Get
        Return _totalpph
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalPPH", _totalpph, value)
      End Set
    End Property
    <Persistent("d_pphnumber")>
    Property NomorPPH As String
      Get
        Return _nomorpph
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorPPH", _nomorpph, value)
      End Set
    End Property
    <Persistent("d_typepayment")>
    Property BankCaraBayar As BankCaraBayar
      Get
        Return _tipepembayaran
      End Get
      Set(value As BankCaraBayar)
        SetPropertyValue(Of BankCaraBayar)("BankCaraBayar", _tipepembayaran, value)
      End Set
    End Property
    <Persistent("d_numberpayment")>
    Property BankNoPembayaran As String
      Get
        Return _nomorpembayaran
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("BankNoPembayaran", _nomorpembayaran, value)
      End Set
    End Property
    <Persistent("d_bankaccountnumber")>
    Property BankAccount As String
      Get
        Return _nomorbank
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("BankAccount", _nomorbank, value)
      End Set
    End Property
    <Persistent("d_tempo")>
    Property Tempo As Date
      Get
        Return _tgltempo
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tempo", _tgltempo, value)
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
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property

    <Association("fk_sanyupembayaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PembayaranPiutangDetail)
      Get
        Return GetCollection(Of SanYu_PembayaranPiutangDetail)("Detail")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property SelisihKurs As Double
      Get
        Return Detail.Sum(Function(m) m.NilaiBayar * m.NoInvoice.Kurs) - Detail.Sum(Function(m) m.NilaiBayar * m.Kurs)
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Pembayaran Piutang [CP]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
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
  <Persistent("m06gdetailpayment")> Friend Class SanYu_PembayaranPiutangDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PembayaranPiutang
    Private _idinvoice As Sanyu_InvoicePenjualan
    Private _urutan As Byte
    Private _amount As Double
    Private _kurs As Double
    Private _amountcash As Double
    Private _amountreturn As Double
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
    <Persistent("p_id"), Association("fk_sanyupembayaran_detail")>
    Property Main As SanYu_PembayaranPiutang
      Get
        Return _main
      End Get
      Set(value As SanYu_PembayaranPiutang)
        SetPropertyValue(Of SanYu_PembayaranPiutang)("Main", _main, value)
      End Set
    End Property
    <Persistent("p_idinvoice")>
    Property NoInvoice As Sanyu_InvoicePenjualan
      Get
        Return _idinvoice
      End Get
      Set(value As Sanyu_InvoicePenjualan)
        SetPropertyValue(Of Sanyu_InvoicePenjualan)("NoInvoice", _idinvoice, value)
      End Set
    End Property
    <Persistent("d_urutan")> Property Urutan As Byte
      Get
        Return _urutan
      End Get
      Set(value As Byte)
        SetPropertyValue(Of Byte)("Urutan", _urutan, value)
      End Set
    End Property
    <Persistent("d_amount")>
    Property NilaiBayar As Double
      Get
        Return _amount
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayar", _amount, value)
      End Set
    End Property
    <Persistent("d_kurspayment")>
    Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("d_amountcash")>
    Property NilaiBayarCash As Double
      Get
        Return _amountcash
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayarCash", _amountcash, value)
      End Set
    End Property
    <Persistent("d_amountreturn")>
    Property NilaiBayarRetur As Double
      Get
        Return _amountreturn
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayarRetur", _amountreturn, value)
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

    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama pembayaran piutang", -99, "", source)
        Return False
      End If
      If _idinvoice Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor invoice", -99, "", source)
        Return False
      End If
      If _amountcash = 0 Then
        Throw New Utils.Exception("Masukkan jumlah pembayaran", -99, "", source)
        Return False
      End If
      Return True
    End Function

    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      NilaiBayar = NilaiBayarCash + NilaiBayarRetur
      MyBase.OnSaving()
    End Sub
  End Class

  'query untuk sisa piutang invoice
  <Persistent("m06vwinvoice")> Friend Class SanYu_ViewInvoice
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property NoInvoice As Sanyu_InvoicePenjualan
    Property Urutan As Int64
    Property Terbayar As Double
    Property NilaiBayarCash As Double
    Property Kurs As Double
    Property OK As Boolean
    Property Catatan As String
    Property Pembayaran As SanYu_PembayaranPiutangDetail
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
    Private _item As NuSoft004.Persistent.SanYu_Barang
    Private _qty As Double
    Private _itembaku As NuSoft004.Persistent.SanYu_Barang
    Private _qtybaku As Double
    Private _ukuran As String
    Private _panjang As Double
    Private _lebar As Double
    Private _tebal As Double
    Private _mutasi As Boolean

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
    <Persistent("f_so"), Association("fk_sanyurencanaproduksi_sodetail")> Property OrderPenjualan As SanYu_OrderPenjualanDetail
      Get
        Return _idso
      End Get
      Set(value As SanYu_OrderPenjualanDetail)
        SetPropertyValue(Of SanYu_OrderPenjualanDetail)("OrderPenjualan", _idso, value)
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
    <Persistent("d_qty")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("f_itembaku")> Property BahanBaku As NuSoft004.Persistent.SanYu_Barang
      Get
        Return _itembaku
      End Get
      Set(value As NuSoft004.Persistent.SanYu_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.SanYu_Barang)("BahanBaku", _itembaku, value)
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

End Namespace