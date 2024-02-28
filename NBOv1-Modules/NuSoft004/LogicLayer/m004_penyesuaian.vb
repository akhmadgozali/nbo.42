Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m04cstockmain")>
  Friend Class PenyesuaianStock
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _gudang As Gudang
    Private _type As TipeTransaksi
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    <Persistent("f_type")>
    Property TipeTransaksi As TipeTransaksi
      Get
        Return _type
      End Get
      Set(value As TipeTransaksi)
        SetPropertyValue(Of TipeTransaksi)("TipeTransaksi", _type, value)
      End Set
    End Property
    <Persistent("f_contact")>
    Property Kontak As NuSoft001.Persistent.Kontak
      Get
        Return _karyawan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Kontak", _karyawan, value)
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
    <Persistent("f_warehouse")>
    Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
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
    <Association("fk_penyesuaian_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PenyesuaianStockDetail)
      Get
        Return GetCollection(Of PenyesuaianStockDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Penyesuaian Stock"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Karyawan Is Nothing Then
        Throw New Utils.Exception("Masukkan karyawan", -4, "", source)
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
      If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
        Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      For i = 0 To Detail.Count - 1
        Detail(i).gudang = Gudang
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
  Friend Class PenyesuaianStockDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.PenyesuaianStock
    Private _item As Barang
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _qtyin As Double
    Private _qtyout As Double
    Private _harga As Double
    Private _satuan As Satuan
    Private _catatan As String
    Private _gudang As Gudang
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_penyesuaian_detail")>
    Property Main As PenyesuaianStock
      Get
        Return _main
      End Get
      Set(value As PenyesuaianStock)
        SetPropertyValue(Of PenyesuaianStock)("Main", _main, value)
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
    <Persistent("f_warehouse")>
    Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
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
        SetPropertyValue(Of Double)("QtyOut", _qtyout, value)
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
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Penyesuaian Stock"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama penyesuaian stock", -99, "", source)
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
End Namespace