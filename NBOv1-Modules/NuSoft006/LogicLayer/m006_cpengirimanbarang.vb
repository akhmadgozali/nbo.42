Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m04cstockmain")>
  Friend Class PengirimanBarang
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _idorder As Persistent.OrderPenjualan
    Private _kontakperson As String
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _alamatid As NuSoft001.Persistent.KontakAlamat
    Private _alamat As String
    Private _bagpembelian As NuSoft001.Persistent.Kontak
    Private _nokendaraan As String
    Private _nosj As String
    Private _supir As String
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _tipe As NuSoft004.Persistent.TipeTransaksi
    Private _tipepajak As NuSoft005.Persistent.eTipePajak
    Private _poscash As Double
    Private _posdebit As Double
    Private _poscredit As Double
    Private _GL As Persistent.GlMain
    <Persistent("f_contact")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("d_person")>
    Property KontakPerson As String
      Get
        Return _kontakperson
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
      End Set
    End Property
    <Persistent("f_warehouse")>
    Property Gudang As NuSoft004.Persistent.Gudang
      Get
        Return _gudang
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _bagpembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
      End Set
    End Property
    <Persistent("f_address")>
    Property AlamatID As NuSoft001.Persistent.KontakAlamat
      Get
        Return _alamatid
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("Alamat", _alamatid, value)
      End Set
    End Property
    <Persistent("d_address")>
    Property Alamat As String
      Get
        Return _alamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Alamat", _alamat, value)
      End Set
    End Property
    <Persistent("d_nodocument")>
    Property NoSJ As String
      Get
        Return _nosj
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSJ", _nosj, value)
      End Set
    End Property
    <Persistent("d_driver")>
    Property Supir As String
      Get
        Return _supir
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Supir", _supir, value)
      End Set
    End Property
    <Persistent("d_novehicle")>
    Property NoKendaraan As String
      Get
        Return _nokendaraan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoKendaraan", _nokendaraan, value)
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
    <Persistent("f_currency")>
    Property MataUang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _uang, value)
      End Set
    End Property
    <Persistent("f_idso"), Association("fk_OrderPenjualan_PengirimanBarang")>
    Property NoOrder As Persistent.OrderPenjualan
      Get
        Return _idorder
      End Get
      Set(value As Persistent.OrderPenjualan)
        SetPropertyValue(Of Persistent.OrderPenjualan)("NoOrder", _idorder, value)
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
    <Persistent("d_status")>
    Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("f_type")>
    Property TipeTransaksi As NuSoft004.Persistent.TipeTransaksi
      Get
        Return _tipe
      End Get
      Set(value As NuSoft004.Persistent.TipeTransaksi)
        SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("TipeTransaksi", _tipe, value)
      End Set
    End Property
    'property POS
    <Persistent("d_taxtype")>
    Property TipePajak As NuSoft005.Persistent.eTipePajak
      Get
        Return _tipepajak
      End Get
      Set(value As NuSoft005.Persistent.eTipePajak)
        SetPropertyValue(Of NuSoft005.Persistent.eTipePajak)("TipePajak", _tipepajak, value)
      End Set
    End Property
    <Persistent("d_poscash")>
    Property POSCash As Double
      Get
        Return _poscash
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("POSCash", _poscash, value)
      End Set
    End Property
    <Persistent("d_poscredit")>
    Property POSCredit As Double
      Get
        Return _poscredit
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("POSCredit", _poscredit, value)
      End Set
    End Property
    <Persistent("d_posdebit")>
    Property POSDebit As Double
      Get
        Return _posdebit
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("POSDebit", _posdebit, value)
      End Set
    End Property
    <PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property POSDPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("POSDPP"))
      End Get
    End Property
    <PersistentAlias("iif(TipePajak = 0, 0 , 0.1 * POSDPP)")> ReadOnly Property POSNilaiPPN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("POSNilaiPPN"))
      End Get
    End Property
    <PersistentAlias("POSDPP + POSNilaiPPN")> ReadOnly Property POSTotalTransaksi As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("POSTotalTransaksi"))
      End Get
    End Property

    <PersistentAlias("Detail.Sum(SubTotal)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property


    <Association("fk_pengiriman_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PengirimanBarangDetail)
      Get
        Return GetCollection(Of PengirimanBarangDetail)("Detail")
      End Get
    End Property
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _GL
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _GL, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Pengiriman Barang [SJ]"
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
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -5, "", source)
        Return False
      End If
      If Karyawan Is Nothing Then
        Throw New Utils.Exception("Masukkan karyawan pengirim (Bag. Gudang)", -6, "", source)
        Return False
      End If
      If Detail.Sum(Function(m) m.Qty) = 0 AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan nilai qty", -7, "", source)
      End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -8, "", source)
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
  <Persistent("m04dstockdetail")>
  Friend Class PengirimanBarangDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.PengirimanBarang
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _item As NuSoft004.Persistent.Barang
    Private _qty As Double
    Private _qtyin As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _disc As Double
    Private _discp As Double
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _idso As Persistent.OrderPenjualanDetail
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
    <Persistent("p_id"), Association("fk_pengiriman_detail")>
    Property Main As PengirimanBarang
      Get
        Return _main
      End Get
      Set(value As PengirimanBarang)
        SetPropertyValue(Of PengirimanBarang)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_warehouse")>
    Property Gudang As NuSoft004.Persistent.Gudang
      Get
        Return _gudang
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
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
    <Persistent("d_qtyout")>
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
    <Persistent("f_idsod"), Association("fk_OrderPenjualanDetail_PengirimanBarangDetail")>
    Property OrderDetail As Persistent.OrderPenjualanDetail
      Get
        Return _idso
      End Get
      Set(value As Persistent.OrderPenjualanDetail)
        SetPropertyValue(Of Persistent.OrderPenjualanDetail)("PermintaanDetail", _idso, value)
      End Set
    End Property
    <PersistentAlias("Qty * Harga")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 2,0.909090909 * SubTotal,SubTotal)")> ReadOnly Property DPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("DPP"))
      End Get
    End Property

    <PersistentAlias("HPPReff.Sum(NilaiHPP)")> ReadOnly Property NilaiHPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiHPP"))
      End Get
    End Property
    <Association("fk_stock_detail_hpp"), Aggregated> ReadOnly Property HPPReff As XPCollection(Of PengirimanBarangDetailHPP)
      Get
        Return GetCollection(Of PengirimanBarangDetailHPP)("HPPReff")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Pengiriman Barang [SJ]"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama pengiriman barang", -99, "", source)
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
      'If Qty > HPPReff.Sum(Function(m) m.Qty) Then
      '  Throw New Utils.Exception("HPP Barang [" & Barang.Kode & "] tidak tersedia.", -99, "", source)
      '  Return False
      'End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub

    <Persistent("d_qtyin")>
    Property QtyIn As Double
      Get
        Return _qtyin
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyIn", _qtyin, value)
      End Set
    End Property
    <PersistentAlias("QtyIn - Qty")> ReadOnly Property QtyInMinusQtyOut As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtyInMinusQtyOut"))
      End Get
    End Property
  End Class
  <Persistent("m04estockhpp")>
  Friend Class PengirimanBarangDetailHPP
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _idpenjualan As PengirimanBarangDetail
    Private _idpembelian As StockDetail
    Private _qty As Double
    <Persistent("p_id"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_idout"), Association("fk_stock_detail_hpp")>
    Property PengirimanBarang As PengirimanBarangDetail
      Get
        Return _idpenjualan
      End Get
      Set(value As PengirimanBarangDetail)
        SetPropertyValue(Of PengirimanBarangDetail)("Main", _idpenjualan, value)
      End Set
    End Property
    <Persistent("f_idin")>
    Property PenerimaanBarang As StockDetail
      Get
        Return _idpembelian
      End Get
      Set(value As StockDetail)
        SetPropertyValue(Of StockDetail)("Main", _idpembelian, value)
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
    <PersistentAlias("Qty * (PenerimaanBarang.HargaIn * PenerimaanBarang.Main.Kurs)")> ReadOnly Property NilaiHPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiHPP"))
      End Get
    End Property
    Protected Overrides Sub OnSaving()
      MyBase.OnSaving()
    End Sub
  End Class
End Namespace