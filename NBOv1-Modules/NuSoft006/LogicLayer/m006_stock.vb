Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Class KartuStokHelper
  'Shared Function Tambah(session As UnitOfWork, data As Persistent.MutasiStock, datadetail As Persistent.MutasiStockDetail) As Boolean
  '    'Dim newdata As New Persistent.Produksi(session) 'anggap iki kartu stock.
  '    'newdata.BahanBaku = data.Gudang
  '    ''.........
  '    'newdata.Save()
  'End Function
  'Shared Function Edit(session As UnitOfWork, data As Persistent.MutasiStock) As Boolean
  '    'Dim newdata As New Persistent.Produksi(session) 'anggap iki kartu stock.
  '    'newdata.BahanBaku = data.Gudang
  '    ''.........
  '    'newdata.Save()
  'End Function
  'Shared Function Tambah(session As UnitOfWork, data As Persistent.StockMain) As Boolean

  'End Function
End Class
Namespace Persistent
  <Persistent("m04cstockmain")>
  Friend Class StockMain
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _karyawanKirim As NuSoft001.Persistent.Kontak
    Private _karyawanTerima As NuSoft001.Persistent.Kontak
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _catatan As String
    Private _type As NuSoft004.Persistent.TipeTransaksi
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _kurs As Double
    <Persistent("f_contact")>
    Property KaryawanKirim As NuSoft001.Persistent.Kontak
      Get
        Return _karyawanKirim
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("KaryawanKirim", _karyawanKirim, value)
      End Set
    End Property
    <Persistent("f_employee")>
    Property KaryawanTerima As NuSoft001.Persistent.Kontak
      Get
        Return _karyawanTerima
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("KaryawanTerima", _karyawanTerima, value)
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
        Return _type
      End Get
      Set(value As NuSoft004.Persistent.TipeTransaksi)
        SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("TipeTransaksi", _type, value)
      End Set
    End Property
    <Association("fk_stock_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of StockDetail)
      Get
        Return GetCollection(Of StockDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    '<PersistentAlias("KaryawanKirim.Nama")> ReadOnly Property NamaKontak As String
    '  Get
    '    Return Convert.ToString(EvaluateAlias("NamaKontak"))
    '  End Get
    'End Property
    ReadOnly Property NamaKontak As String
      Get
        Return KaryawanKirim.Nama
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Main Stock"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -5, "", source)
        Return False
      End If
      If TipeTransaksi Is Nothing Then
        Throw New Utils.Exception("Masukkan Tipe penyesuaian stock", -6, "", source)
        Return False
      End If
      If KaryawanKirim Is Nothing Then
        Throw New Utils.Exception("Masukkan Karyawan", -7, "", source)
        Return False
      End If
      If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
        Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      For i = 0 To Detail.Count - 1
        Detail(i).Gudang = Gudang
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
  Friend Class StockDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.StockMain
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _item As NuSoft004.Persistent.Barang
    Private _qtyin As Double
    Private _qtyout As Double
    Private _harga As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _gudang As NuSoft004.Persistent.Gudang
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
    <Persistent("p_id"), Association("fk_stock_detail")>
    Property Main As StockMain
      Get
        Return _main
      End Get
      Set(value As StockMain)
        SetPropertyValue(Of StockMain)("Main", _main, value)
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
    <Persistent("d_qtyin")>
    Property QtyIn As Double
      Get
        Return _qtyin
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyIn", _qtyin, value)
      End Set
    End Property
    <Persistent("d_qtyout")>
    Property QtyOut As Double
      Get
        Return _qtyout
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qtyout, value)
      End Set
    End Property
    <Persistent("d_price")>
    Property HargaIn As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaIn", _harga, value)
      End Set
    End Property
    <PersistentAlias("QtyIn - QtyOut")> ReadOnly Property Stock As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Stock"))
      End Get
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
    <Persistent("d_remarks")>
    Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
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
    <Association("fk_stock_detail_hpp"), Aggregated> ReadOnly Property HPPReff As XPCollection(Of StockDetailHPPReff)
      Get
        Return GetCollection(Of StockDetailHPPReff)("HPPReff")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Stock Detail"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama stock", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If QtyIn = 0 And QtyOut = 0 Then
        Throw New Utils.Exception("Masukkan Qty Barang", -99, "", source)
        Return False
      End If
      If QtyIn > 0 And HargaIn = 0 Then
        Throw New Utils.Exception("Masukkan harga barang", -99, "", source)
        Return False
      End If
      If QtyOut > 0 Then
        If QtyOut <> HPPReff.Sum(Function(m) m.Qty) Then
          Throw New Utils.Exception("HPP Barang [" & Barang.Kode & "] tidak tersedia.", -99, "", source)
          Return False
        End If
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      If _qtyin = Nothing Then
        _qtyin = 0
      End If
      If _qtyout = Nothing Then
        _qtyout = 0
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m04estockhpp")>
  Friend Class StockDetailHPPReff
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _detail As Persistent.StockDetail
    Private _detailIN As Persistent.StockDetail
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
    Property Detail As StockDetail
      Get
        Return _detail
      End Get
      Set(value As StockDetail)
        SetPropertyValue(Of StockDetail)("Main", _detail, value)
      End Set
    End Property
    <Persistent("f_idin")>
    Property DetailIN As StockDetail
      Get
        Return _detailIN
      End Get
      Set(value As StockDetail)
        SetPropertyValue(Of StockDetail)("DetailIN", _detailIN, value)
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
    Private Function CheckData() As Boolean
      Dim source As String = "Stock HPP Reff"
      If _detail Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data detail stock", -99, "", source)
        Return False
      End If
      If Qty = 0 Then
        Throw New Utils.Exception("Masukkan Qty Barang", -99, "", source)
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
  <Persistent("m01vwhppavailable")> Friend Class vwHPP
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Persistent.StockDetail
    Property f_item As NuSoft004.Persistent.Barang
    Property f_warehouse As NuSoft004.Persistent.Gudang
    Property d_qtyin As Double
    Property d_qtyout As Double
    Property d_used As Double
    Property d_available As Double
  End Class
End Namespace