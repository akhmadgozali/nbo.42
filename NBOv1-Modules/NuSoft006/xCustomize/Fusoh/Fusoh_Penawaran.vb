Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m06cmainquotation")>
  Friend Class Fusoh_Penawaran
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _alamat As NuSoft001.Persistent.KontakAlamat
    Private _kontakperson As String
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _tanggalBerlakuAwal As Date
    Private _tanggalBerlakuAkhir As Date
    Private _termin As NuSoft005.Persistent.Termin
    Private _termOfPrice As String
    Private _payment As String
    Private _inspection As String
    Private _yourReff As String
    Private _others As String
		Private _catatan As String
		Private _revisi As Int16

		<Persistent("d_rev")> Property Revisi As Int16
			Get
				Return _revisi
			End Get
			Set(value As Int16)
				SetPropertyValue(Of Int16)("Revisi", _revisi, value)
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
    <Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("f_address")> Property Alamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _alamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("Alamat", _alamat, value)
      End Set
    End Property
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
    <Persistent("d_yourreff")> Property YourReff As String
      Get
        Return _yourReff
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("YourReff", _yourReff, value)
      End Set
    End Property
    <Persistent("d_others")> Property Others As String
      Get
        Return _others
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Others", _others, value)
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

    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(SubTotal)")> ReadOnly Property Total As Double
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

    <Association("fk_fusoh_penawaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_PenawaranDetail)
      Get
        Return GetCollection(Of Fusoh_PenawaranDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Penawaran Penjualan [SQ]"
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
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Pelanggan", -3, "", source)
        Return False
      End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -4, "", source)
      End If
      If TanggalBerlakuAwal = Nothing Then
        Throw New Utils.Exception("Masukkan awal tanggal berlaku", -5, "", source)
      End If
      If TanggalBerlakuAkhir = Nothing Then
        Throw New Utils.Exception("Masukkan akhir tanggal berlaku", -5, "", source)
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

  <Persistent("m06ddetailquotation")>
  Friend Class Fusoh_PenawaranDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_Penawaran
    Private _partNo As String
		Private _item As String
		Private _material As String
		Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _qty As Double
    Private _weight As Decimal
    Private _harga As Double
    Private _hargaproses As Double
    Private _catatan As String

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_penawaran_detail")> Property Main As Fusoh_Penawaran
      Get
        Return _main
      End Get
      Set(value As Fusoh_Penawaran)
        SetPropertyValue(Of Fusoh_Penawaran)("Main", _main, value)
      End Set
    End Property
    <Persistent("d_partno")> Property PartNo As String
      Get
        Return _partNo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PartNo", _partNo, value)
      End Set
    End Property
    <Persistent("d_item")> Property Barang As String
      Get
        Return _item
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Barang", _item, value)
      End Set
    End Property
		<Persistent("d_material")> Property Material As String
			Get
				Return _material
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Material", _material, value)
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
    <Persistent("d_qty")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
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
    <Persistent("d_price")> Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
      End Set
    End Property
    <Persistent("d_processingprice")> Property HargaProses As Double
      Get
        Return _hargaproses
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaProses", _hargaproses, value)
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

    <PersistentAlias("(Harga + HargaProses) * Main.Kurs")> ReadOnly Property HargaKurs As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("HargaKurs"))
      End Get
    End Property
    <PersistentAlias("HargaKurs * Qty")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
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
      Dim source As String = "Penawaran Penjualan [SQ]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan barang", -99, "", source)
        Return False
      End If
      If _qty = Nothing Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
        Return False
      End If
      If _harga = Nothing Then
        Throw New Utils.Exception("Masukkan harga", -99, "", source)
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