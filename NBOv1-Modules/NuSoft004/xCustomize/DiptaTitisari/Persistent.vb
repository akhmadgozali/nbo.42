Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  Public Enum xePosisi
    Atas = 0
    Bawah = 1
  End Enum
  <Persistent("m04alocation")> _
  Public Class xDiptaMasterLOkasi
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kode As String
    Private _dblok As UInt16
    Private _dkolom As String
    Private _dbaris As UInt16
    Private _dposisi As xePosisi

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
    <Persistent("d_blok")> Property Blok As UInt16
      Get
        Return _dblok
      End Get
      Set(value As UInt16)
        SetPropertyValue(Of UInt16)("Blok", _dblok, value)
      End Set
    End Property
    <Persistent("d_kolom")> Property Kolom As String
      Get
        Return _dkolom
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kolom", _dkolom, value)
      End Set
    End Property
    <Persistent("d_baris")> Property Baris As UInt16
      Get
        Return _dbaris
      End Get
      Set(value As UInt16)
        SetPropertyValue(Of UInt16)("CoaCost", _dbaris, value)
      End Set
    End Property
    <Persistent("d_posisi")> Property Posisi As xePosisi
      Get
        Return _dposisi
      End Get
      Set(value As xePosisi)
        SetPropertyValue(Of xePosisi)("Posisi", _dposisi, value)
      End Set
    End Property
  End Class

  <Persistent("m04cstockmain")>
  Friend Class xDiptaStockMain
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
    Private _gudang As Gudang
    Private _gudang2 As Gudang
    Private _catatan As String
    Private _type As TipeTransaksi
    Private _gl As Persistent.GlMain
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
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
    Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("f_warehouse2")>
    Property Gudang2 As Gudang
      Get
        Return _gudang2
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang2", _gudang2, value)
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
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property
    <Persistent("f_type")>
    Property TipeTransaksi As TipeTransaksi
      Get
        Return _type
      End Get
      Set(value As TipeTransaksi)
        SetPropertyValue(Of TipeTransaksi)("TipeTransaksi", _type, value)
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

    <Association("fk_stock_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of xDiptaStockDetail)
      Get
        Return GetCollection(Of xDiptaStockDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(NilaiHPP)")> ReadOnly Property TotalHPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalHPP"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(QtyIn * HargaIn)")> ReadOnly Property TotalNilaiIN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalNilaiIN"))
      End Get
    End Property
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
      If Sumber.Id = Persistent.SumberDataJenis.PS Then
        If TipeTransaksi Is Nothing Then
          Throw New Utils.Exception("Masukkan Tipe penyesuaian stock", -6, "", source)
          Return False
        End If
      End If
      If KaryawanKirim Is Nothing Then
        Throw New Utils.Exception("Masukkan Karyawan", -7, "", source)
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
  Friend Class xDiptaStockDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.xDiptaStockMain
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _item As Barang
    Private _qtyin As Double
    Private _qtyout As Double
    Private _harga As Double
    Private _satuan As Satuan
    Private _gudang As Gudang
    Private _gudang2 As Gudang
    Private _persentase As Double
    Private _catatan As String
    Private _proyek As NuSoft001.Persistent.Proyek
    Private _lokasi As Persistent.xDiptaMasterLOkasi
    Private _tanggalexpired As Date
    Private _palet As UInt32
    Private _paletID As String
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
    Property Main As xDiptaStockMain
      Get
        Return _main
      End Get
      Set(value As xDiptaStockMain)
        SetPropertyValue(Of xDiptaStockMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As Barang
      Get
        Return _item
      End Get
      Set(value As Barang)
        SetPropertyValue(Of Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("f_uom")>
    Property Satuan As Satuan
      Get
        Return _satuan
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _satuan, value)
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
    Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("f_warehouse2")>
    Property Gudang2 As Gudang
      Get
        Return _gudang2
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang2", _gudang2, value)
      End Set
    End Property
    <Persistent("d_hppproduction")>
    Property PersentaseHPP As Double
      Get
        Return _persentase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PersentaseHPP", _persentase, value)
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
    <Persistent("f_lokasi")>
    Property Lokasi As Persistent.xDiptaMasterLOkasi
      Get
        Return _lokasi
      End Get
      Set(value As Persistent.xDiptaMasterLOkasi)
        SetPropertyValue(Of Persistent.xDiptaMasterLOkasi)("Lokasi", _lokasi, value)
      End Set
    End Property
    <Persistent("d_expired")>
    Property ExpiredDate As Date
      Get
        Return _tanggalexpired
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("ExpiredDate", _tanggalexpired, value)
      End Set
    End Property
    <Persistent("d_palet")>
    Property Palet As UInt32
      Get
        Return _palet
      End Get
      Set(value As UInt32)
        SetPropertyValue(Of UInt32)("Palet", _palet, value)
      End Set
    End Property
    <Persistent("d_paletid")>
    Property PaletID As String
      Get
        Return _paletID
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PaletID", _paletID, value)
      End Set
    End Property



    <Association("fk_stock_detail_hpp"), Aggregated> ReadOnly Property HPPReff As XPCollection(Of xDiptaStockDetailHPPReff)
      Get
        Return GetCollection(Of xDiptaStockDetailHPPReff)("HPPReff")
      End Get
    End Property
    <PersistentAlias("HPPReff.Sum(NilaiHPP)")> ReadOnly Property NilaiHPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiHPP"))
      End Get
    End Property
    <PersistentAlias("QtyIn * HargaIn")> ReadOnly Property NilaiIN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiIN"))
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
      If Not Session.IsObjectToDelete(Me) Then
        If QtyOut > 0 Then
          If QtyOut <> HPPReff.Sum(Function(m) m.Qty) Then
            Throw New Utils.Exception("HPP Barang [" & Barang.Kode & "] tidak tersedia.", -99, "", source)
            Return False
          End If
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
  Friend Class xDiptaStockDetailHPPReff
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _detail As Persistent.xDiptaStockDetail
    Private _detailIN As Persistent.xDiptaStockDetail
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
    Property Detail As xDiptaStockDetail
      Get
        Return _detail
      End Get
      Set(value As xDiptaStockDetail)
        SetPropertyValue(Of xDiptaStockDetail)("Main", _detail, value)
      End Set
    End Property
    <Persistent("f_idin")>
    Property DetailIN As xDiptaStockDetail
      Get
        Return _detailIN
      End Get
      Set(value As xDiptaStockDetail)
        SetPropertyValue(Of xDiptaStockDetail)("DetailIN", _detailIN, value)
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
    <PersistentAlias("Qty * (DetailIN.HargaIn * DetailIN.Main.Kurs)")> ReadOnly Property NilaiHPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiHPP"))
      End Get
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

End Namespace