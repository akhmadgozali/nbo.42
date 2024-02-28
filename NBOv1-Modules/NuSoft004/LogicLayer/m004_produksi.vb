Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m04cstockmain")>
  Friend Class Produksi
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _gudangasal As Gudang
    Private _gudangtujuan As Gudang
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _karyawan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _karyawan, value)
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
    <Persistent("f_warehouse")>
    Property GudangAsal As Gudang
      Get
        Return _gudangasal
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("GudangAsal", _gudangasal, value)
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
    <Association("fk_produksi_bahanbaku"), Aggregated> ReadOnly Property BahanBaku As XPCollection(Of ProduksiBahanBaku)
      Get
        Return GetCollection(Of ProduksiBahanBaku)("BahanBaku")
      End Get
    End Property
    <Association("fk_produksi_cost"), Aggregated> ReadOnly Property Cost As XPCollection(Of ProduksiCost)
      Get
        Return GetCollection(Of ProduksiCost)("Cost")
      End Get
    End Property
    <Association("fk_produksi_bahanjadi"), Aggregated> ReadOnly Property BahanJadi As XPCollection(Of ProduksiBahanJadi)
      Get
        Return GetCollection(Of ProduksiBahanJadi)("BahanJadi")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Produksi"
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
      If GudangAsal Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang produksi", -5, "", source)
        Return False
      End If
      If GudangTujuan Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang tujuan", -6, "", source)
        Return False
      End If
      If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
        Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      For i = 0 To BahanBaku.Count - 1
        BahanBaku(i).Gudang = GudangAsal
      Next
      For j = 0 To BahanJadi.Count - 1
        BahanJadi(j).Gudang = GudangTujuan
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
  Friend Class ProduksiBahanBaku
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.Produksi
    Private _item As Barang
    Private _qty As Double
    Private _satuan As Satuan
    Private _gudang As Gudang
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
    <Persistent("p_id"), Association("fk_produksi_bahanbaku")>
    Property Main As Produksi
      Get
        Return _main
      End Get
      Set(value As Produksi)
        SetPropertyValue(Of Produksi)("Main", _main, value)
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
    <Persistent("d_qtyout")>
    Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
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
    <Persistent("f_warehouse")>
    Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Produksi - Bahan Baku"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama produksi", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      'If _qty = Nothing Then
      '  Throw New Utils.Exception("Masukkan qty", -99, "", source)
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
  End Class
  <Persistent("m04dstockcost")>
  Friend Class ProduksiCost
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.Produksi
    Private _cost As Persistent.BiayaLain
    Private _amount As Double
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
    <Persistent("p_id"), Association("fk_produksi_cost")>
    Property Main As Produksi
      Get
        Return _main
      End Get
      Set(value As Produksi)
        SetPropertyValue(Of Produksi)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_cost")>
    Property Cost As Persistent.BiayaLain
      Get
        Return _cost
      End Get
      Set(value As Persistent.BiayaLain)
        SetPropertyValue(Of Persistent.BiayaLain)("COA", _cost, value)
      End Set
    End Property
    <Persistent("d_value")>
    Property Jumlah As Double
      Get
        Return _amount
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Jumlah", _amount, value)
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
      Dim source As String = "Produksi - COA"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama produksi", -99, "", source)
        Return False
      End If
      If _cost Is Nothing Then
        Throw New Utils.Exception("Masukkan kode COA", -99, "", source)
        Return False
      End If
      If _amount = Nothing Then
        Throw New Utils.Exception("Masukkan jumlah", -99, "", source)
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
  <Persistent("m04dstockdetail")>
  Friend Class ProduksiBahanJadi
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.Produksi
    Private _item As Barang
    Private _qty As Double
    Private _satuan As Satuan
    Private _catatan As String
    Private _gudang As Gudang
    Private _persentase As Double
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_produksi_bahanjadi")>
    Property Main As Produksi
      Get
        Return _main
      End Get
      Set(value As Produksi)
        SetPropertyValue(Of Produksi)("Main", _main, value)
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
    Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
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
    <Persistent("d_hppproduction")>
    Property Persentase As Double
      Get
        Return _persentase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Persentase", _persentase, value)
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
    Private Function CheckData() As Boolean
      Dim source As String = "Produksi Bahan Jadi"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama produksi", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      'If _qty = Nothing Then
      '  Throw New Utils.Exception("Masukkan qty", -99, "", source)
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
  End Class
End Namespace