Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Namespace Persistent
  <Persistent("m04cstockmain")>
  Friend Class MutasiStock
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
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _idpermintaan As PermintaanStock
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
    <Persistent("f_idrequest")>
    Property PermintaanBarang As PermintaanStock
      Get
        Return _idpermintaan
      End Get
      Set(value As PermintaanStock)
        SetPropertyValue(Of PermintaanStock)("PermintaanBarang", _idpermintaan, value)
      End Set
    End Property
    <Association("fk_mutasi_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of MutasiStockDetail)
      Get
        Return GetCollection(Of MutasiStockDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Mutasi Stock"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If KaryawanKirim Is Nothing Then
        Throw New Utils.Exception("Masukkan karyawan pengirim", -4, "", source)
        Return False
      End If
      If KaryawanTerima Is Nothing Then
        Throw New Utils.Exception("Masukkan karyawan penerima", -5, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -6, "", source)
        Return False
      End If
      If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
        Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      For pi = 0 To Detail.Count - 1
        If Detail(pi).QtyOut > 0 Then
          Detail(pi).Gudang = Gudang
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
  <Persistent("m04dstockdetail")>
  Friend Class MutasiStockDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.MutasiStock
    Private _item As Barang
    Private _qtyin As Double
    Private _qtyout As Double
    Private _satuan As Satuan
    Private _gudang As Gudang
    Private _gudangtujuan As Gudang
    Private _idpermintaan As Persistent.PermintaanStockDetail
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
    <Persistent("p_id"), Association("fk_mutasi_detail")>
    Property Main As MutasiStock
      Get
        Return _main
      End Get
      Set(value As MutasiStock)
        SetPropertyValue(Of MutasiStock)("Main", _main, value)
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
    Property GudangTujuan As Gudang
      Get
        Return _gudangtujuan
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("GudangTujuan", _gudangtujuan, value)
      End Set
    End Property
    <Persistent("f_idrequestd")>
    Property PermintaanBarang As PermintaanStockDetail
      Get
        Return _idpermintaan
      End Get
      Set(value As PermintaanStockDetail)
        SetPropertyValue(Of PermintaanStockDetail)("Satuan", _idpermintaan, value)
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
      Dim source As String = "Mutasi Stock"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama mutasi stock", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _qtyin = Nothing And _qtyout = Nothing Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
        Return False
      End If
      If _qtyin = 0 And _qtyout = 0 Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
        Return False
      End If
      'If _gudangtujuan = Main.Gudang Then
      '  Throw New Utils.Exception("Gudang tujuan tidak boleh sama dengan gudang asal", -99, "", source)
      'End If
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