Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.Modules.ModSys
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Namespace Persistent
  <Persistent("m04eproduksimain")> Friend Class SanYu_ProduksiMain
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _f_item As NuSoft004.Persistent.SanYu_Barang
    Private _f_itembaku As NuSoft004.Persistent.SanYu_Barang
    Private _f_idpembelian As Persistent.SanYu_PenerimaanBarangDetail
    Private _d_statusgudang As Int32
    Private _f_produksisebelumnya As Persistent.SanYu_ProduksiMain

    Private _itemwaste As NuSoft004.Persistent.SanYu_Barang
    Private _bahanbakum3 As Double
    Private _bahanbakutonase As Double
    Private _bahanjadim3 As Double
    Private _bahanjaditonase As Double
    Private _bahanwastem3 As Double
    Private _bahanwastetonase As Double
    Private _bahanpembantum3 As Double
    Private _bahanpembantutonase As Double

    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
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
    <Persistent("f_item")> Property ItemJadi As SanYu_Barang
      Get
        Return _f_item
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("ItemJadi", _f_item, value)
      End Set
    End Property
    <Persistent("f_itembaku")> Property ItemBaku As SanYu_Barang
      Get
        Return _f_itembaku
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("ItemBaku", _f_itembaku, value)
      End Set
    End Property
    <Persistent("f_idpembelian")> Property PenerimaanBarang As SanYu_PenerimaanBarangDetail
      Get
        Return _f_idpembelian
      End Get
      Set(value As SanYu_PenerimaanBarangDetail)
        SetPropertyValue(Of SanYu_PenerimaanBarangDetail)("PenerimaanBarang", _f_idpembelian, value)
      End Set
    End Property
    <Persistent("f_produksisebelumnya")> Property ProduksiSebelumnya As SanYu_ProduksiMain
      Get
        Return _f_produksisebelumnya
      End Get
      Set(value As SanYu_ProduksiMain)
        SetPropertyValue(Of SanYu_ProduksiMain)("ProduksiSebelumnya", _f_produksisebelumnya, value)
      End Set
    End Property

    'hitungan finish produksi
    <Persistent("f_itemwaste")> Property ItemWaste As SanYu_Barang
      Get
        Return _itemwaste
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("ItemWaste", _itemwaste, value)
      End Set
    End Property

    <Persistent("d_bahanbaku")> Property BahanBakuM3 As Double
      Get
        Return _bahanbakum3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanBakuM3", _bahanbakum3, value)
      End Set
    End Property
    <Persistent("d_bahanbakutn")> Property BahanBakuTonase As Double
      Get
        Return _bahanbakutonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanBakuTonase", _bahanbakutonase, value)
      End Set
    End Property
    <Persistent("d_bahanjadi")> Property BahanJadiM3 As Double
      Get
        Return _bahanjadim3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanJadiM3", _bahanjadim3, value)
      End Set
    End Property
    <Persistent("d_bahanjaditn")> Property BahanJadiTonase As Double
      Get
        Return _bahanjaditonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanJadiTonase", _bahanjaditonase, value)
      End Set
    End Property
    <Persistent("d_bahanwaste")> Property BahanWasteM3 As Double
      Get
        Return _bahanwastem3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanWasteM3", _bahanwastem3, value)
      End Set
    End Property
    <Persistent("d_bahanwastetn")> Property BahanWasteTonase As Double
      Get
        Return _bahanwastetonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanWasteTonase", _bahanwastetonase, value)
      End Set
    End Property
    <Persistent("d_bahanpembantu")> Property BahanPembantuM3 As Double
      Get
        Return _bahanpembantum3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanPembantuM3", _bahanpembantum3, value)
      End Set
    End Property
    <Persistent("d_bahanpembantutn")> Property BahanPembantuTonase As Double
      Get
        Return _bahanpembantutonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BahanPembantuTonase", _bahanpembantutonase, value)
      End Set
    End Property

    <Association("fk_sanyuproduksi_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_ProduksiDetail)
      Get
        Return GetCollection(Of SanYu_ProduksiDetail)("Detail")
      End Get
    End Property
    <Association("fk_sanyuproduksi_pembantu"), Aggregated> ReadOnly Property Pembantu As XPCollection(Of SanYu_ProduksiPembantu)
      Get
        Return GetCollection(Of SanYu_ProduksiPembantu)("Pembantu")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalVolume As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalVolume"))
      End Get
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
  <Persistent("m04fproduksidetail")> Friend Class SanYu_ProduksiDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_ProduksiMain
    Private _qty As Double
    Private _qty2 As Double
    Private _ukuran As String
    Private _keterangan As String
    Private _panjang As Double
    Private _lebar As Double
    Private _tebal As Double
    Private _idpembelian As Persistent.SanYu_PenerimaanBarangDetail
    Private _xn As Boolean
    Private _tonase As Double
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_sanyuproduksi_detail")> Property Main As SanYu_ProduksiMain
      Get
        Return _main
      End Get
      Set(value As SanYu_ProduksiMain)
        SetPropertyValue(Of SanYu_ProduksiMain)("Main", _main, value)
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
    <Persistent("d_qty2")> Property QtyPcs As Double
      Get
        Return _qty2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyPcs", _qty2, value)
      End Set
    End Property
    <Persistent("d_ukuran")> Property Ukuran As String
      Get
        Return _ukuran
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Ukuran", _ukuran, value)
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
    <Persistent("d_keterangan")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
    <Persistent("f_idpembelian")> Property Pembelian As Persistent.SanYu_PenerimaanBarangDetail
      Get
        Return _idpembelian
      End Get
      Set(value As Persistent.SanYu_PenerimaanBarangDetail)
        SetPropertyValue(Of Persistent.SanYu_PenerimaanBarangDetail)("Pembelian", _idpembelian, value)
      End Set
    End Property
    <Persistent("d_n")> Property xN As Boolean
      Get
        Return _xn
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("xN", _xn, value)
      End Set
    End Property
    <Persistent("d_tonase")> Property Tonase As Double
      Get
        Return _tonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tonase", _tonase, value)
      End Set
    End Property

    <PersistentAlias("Qty * (Pembelian.Tonase / Pembelian.QtyIn)")> ReadOnly Property TonaseP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TonaseP"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
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
  <Persistent("m04fproduksipembantu")> Friend Class SanYu_ProduksiPembantu
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_ProduksiMain
    Private _barang As SanYu_Barang
    Private _qty As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _keterangan As String
    Private _idpembelian As Persistent.SanYu_PenerimaanBarangDetail
    Private _xn As Boolean
    Private _tonase As Double
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_sanyuproduksi_pembantu")> Property Main As SanYu_ProduksiMain
      Get
        Return _main
      End Get
      Set(value As SanYu_ProduksiMain)
        SetPropertyValue(Of SanYu_ProduksiMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As SanYu_Barang
      Get
        Return _barang
      End Get
      Set(value As SanYu_Barang)
        SetPropertyValue(Of SanYu_Barang)("Barang", _barang, value)
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
    <Persistent("f_uom")> Property Satuan As NuSoft004.Persistent.Satuan
      Get
        Return _satuan
      End Get
      Set(value As NuSoft004.Persistent.Satuan)
        SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
    <Persistent("f_idpembelian")> Property Pembelian As Persistent.SanYu_PenerimaanBarangDetail
      Get
        Return _idpembelian
      End Get
      Set(value As Persistent.SanYu_PenerimaanBarangDetail)
        SetPropertyValue(Of Persistent.SanYu_PenerimaanBarangDetail)("Pembelian", _idpembelian, value)
      End Set
    End Property
    <Persistent("d_n")> Property xN As Boolean
      Get
        Return _xn
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("xN", _xn, value)
      End Set
    End Property
    <Persistent("d_tonase")> Property Tonase As Double
      Get
        Return _tonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tonase", _tonase, value)
      End Set
    End Property
    <PersistentAlias("Qty * (Pembelian.Tonase / Pembelian.QtyIn)")> ReadOnly Property TonaseP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TonaseP"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
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
