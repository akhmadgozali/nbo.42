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
    Private _gudang As Gudang
    Private _gudang2 As Gudang
    Private _catatan As String
    Private _type As TipeTransaksi
    Private _gl As Persistent.GlMain
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _idpermintaan As PermintaanStock
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
    <Persistent("f_idrequest")>
    Property PermintaanBarang As PermintaanStock
      Get
        Return _idpermintaan
      End Get
      Set(value As PermintaanStock)
        SetPropertyValue(Of PermintaanStock)("PermintaanBarang", _idpermintaan, value)
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

		<Association("fk_stock_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of StockDetail)
			Get
				Return GetCollection(Of StockDetail)("Detail")
			End Get
		End Property

		<Association("fk_stock_Cost"), Aggregated> ReadOnly Property Cost As XPCollection(Of StockCost)
      Get
        Return GetCollection(Of StockCost)("Cost")
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
		<PersistentAlias("Detail.Sum(TotalQtyHPP)")> ReadOnly Property TotalQtyHPP As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQtyHPP"))
			End Get
		End Property

		<PersistentAlias("Detail.Sum(QtyIn * HargaIn)")> ReadOnly Property TotalNilaiIN As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalNilaiIN"))
			End Get
		End Property

		<PersistentAlias("Detail.Sum(NilaiPersediaan)")> ReadOnly Property NilaiPersediaan As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("NilaiPersediaan"))
			End Get
		End Property
		<PersistentAlias("Detail.Sum(NilaiPersediaanQty)")> ReadOnly Property NilaiPersediaanQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("NilaiPersediaanQty"))
			End Get
		End Property

    <PersistentAlias("Detail.Sum(NilaiPersediaanAlias)")> ReadOnly Property NilaiPersediaanAlias As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiPersediaanAlias"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(NilaiPersediaanQtyAlias)")> ReadOnly Property NilaiPersediaanQtyAlias As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiPersediaanQtyAlias"))
      End Get
    End Property
    <PersistentAlias("(NilaiPersediaanAlias + TotalHPP) - Gl.NilaiPersediaanAlias")> ReadOnly Property SelisihPersediaan As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SelisihPersediaan"))
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
				If Detail(i).Gudang Is Nothing Then
					Detail(i).Gudang = Gudang
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
    Private _item As Barang
    Private _qtyin As Double
    Private _qtyout As Double
    Private _harga As Double
    Private _satuan As Satuan
    Private _gudang As Gudang
    Private _gudang2 As Gudang
    Private _persentase As Double
    Private _catatan As String
    Private _idpermintaan As Persistent.PermintaanStockDetail
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
    <Persistent("f_idrequestd")>
    Property PermintaanBarang As PermintaanStockDetail
      Get
        Return _idpermintaan
      End Get
      Set(value As PermintaanStockDetail)
        SetPropertyValue(Of PermintaanStockDetail)("Satuan", _idpermintaan, value)
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
    <Persistent("f_division")>
    Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
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
    <PersistentAlias("HPPReff.Sum(Qty)")> ReadOnly Property QtyHPPReff As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtyHPPReff"))
      End Get
    End Property

    <PersistentAlias("HPPReff.Sum(NilaiHPP)")> ReadOnly Property NilaiHPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiHPP"))
      End Get
    End Property
		<PersistentAlias("HPPReff.Sum(Qty)")> ReadOnly Property TotalQtyHPP As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQtyHPP"))
			End Get
		End Property
		<PersistentAlias("QtyIn * HargaIn")> ReadOnly Property NilaiIN As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("NilaiIN"))
			End Get
		End Property

    <PersistentAlias("Iif(Barang.Jenis = 1, 0, NilaiIN)")> ReadOnly Property NilaiPersediaanAlias As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiPersediaanAlias"))
      End Get
    End Property
    <PersistentAlias("Iif(Barang.Jenis = 1, 0, QtyIn + QtyOut)")> ReadOnly Property NilaiPersediaanQtyAlias As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiPersediaanQtyAlias"))
      End Get
    End Property

    ReadOnly Property NilaiPersediaan As Double
      Get
        If Barang.Jenis = JenisBarang.Jasa Then
          Return 0
        Else
          Return QtyIn * HargaIn
        End If
      End Get
    End Property
    ReadOnly Property NilaiPersediaanQty As Double
      Get
        If Barang.Jenis = JenisBarang.Jasa Then
          Return 0
        Else
          Return QtyIn + QtyOut
        End If
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

      'If QtyIn > 0 And HargaIn = 0 Then
      '  Throw New Utils.Exception("Masukkan harga barang", -99, "", source)
      '  Return False
      'End If
      If Not Session.IsObjectToDelete(Me) Then
        If QtyIn = 0 And QtyOut = 0 Then
          Throw New Utils.Exception("Masukkan Qty Barang", -99, "", source)
          Return False
        End If

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
  <Persistent("m04dstockcost")>
  Friend Class StockCost
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.StockMain
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
    <Persistent("p_id"), Association("fk_stock_Cost")>
    Property Main As StockMain
      Get
        Return _main
      End Get
      Set(value As StockMain)
        SetPropertyValue(Of StockMain)("Main", _main, value)
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
      Dim source As String = "Stock - Cost"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama stock", -99, "", source)
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

  <Persistent("m04vwhppavailable")> Friend Class vwHPP
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Persistent.StockDetail
    Property f_item As Persistent.Barang
    Property f_warehouse As Persistent.Gudang
    Property d_qtyin As Double
    Property d_qtyout As Double
    Property d_used As Double
    Property d_available As Double
  End Class

  Friend Class StockDetailToSave
    Property Id As Int64
    Property Barang As Barang
    Property Satuan As Satuan
    Property QtyIn As Double
    Property QtyOut As Double
    Property HargaIn As Double
    Property Gudang As Gudang
    Property Gudang2 As Gudang
    Property PermintaanBarang As PermintaanStockDetail
    Property PersentaseHPP As Double
    Property Catatan As String
    Property Divisi As NPO.Modules.ModSys.Divisi
    Property Proyek As NuSoft001.Persistent.Proyek

    ReadOnly Property Stock As Double
      Get
        Return QtyIn - QtyOut
      End Get
    End Property
    ReadOnly Property NilaiIN As Double
      Get
        Return QtyIn * HargaIn
      End Get
    End Property
  End Class
  Friend Class StockCostToSave
    Property Id As Int64
    Property Cost As BiayaLain
    Property Jumlah As Double
    Property Catatan As String
  End Class
End Namespace