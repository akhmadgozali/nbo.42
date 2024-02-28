Imports DevExpress.Xpo
Imports NuSoft.NPO

Namespace Persistent
  <Persistent("m05kuotaimpor")> Friend Class SanYu_KuotaImpor
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kodeHS As String
    Private _keterangan As String
    Private _noLampiran As String
    Private _volume As Decimal
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Decimal
    Private _mataUang As NuSoft001.Persistent.MataUang
    Private _negara As String
    Private _pelabuhan As String
    Private _expired As Date

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("d_codehs")> Property KodeHS As String
      Get
        Return _kodeHS
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KodeHS", _kodeHS, value)
      End Set
    End Property
    <Persistent("d_description")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
    <Persistent("d_nolampiran")> Property NoLampiran As String
      Get
        Return _noLampiran
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoLampiran", _noLampiran, value)
      End Set
    End Property
    <Persistent("d_volume")> Property Volume As Decimal
      Get
        Return _volume
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Volume", _volume, value)
      End Set
    End Property
    <Persistent("f_satuan")> Property Satuan As NuSoft004.Persistent.Satuan
      Get
        Return _satuan
      End Get
      Set(value As NuSoft004.Persistent.Satuan)
        SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_harga")> Property Harga As Decimal
      Get
        Return _harga
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Harga", _harga, value)
      End Set
    End Property
    <Persistent("f_matauang")> Property MataUang As NuSoft001.Persistent.MataUang
      Get
        Return _mataUang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _mataUang, value)
      End Set
    End Property
    <Persistent("d_negara")> Property Negara As String
      Get
        Return _negara
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Negara", _negara, value)
      End Set
    End Property
    <Persistent("d_pelabuhan")> Property Pelabuhan As String
      Get
        Return _pelabuhan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Pelabuhan", _pelabuhan, value)
      End Set
    End Property
    <Persistent("d_expired")> Property Expired As Date
      Get
        Return _expired
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Expired", _expired, value)
      End Set
    End Property

    <PersistentAlias("PO.Sum(Tonase)")> ReadOnly Property VolumeTerpakai As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("VolumeTerpakai"))
      End Get
    End Property
    <PersistentAlias("Volume - VolumeTerpakai")> ReadOnly Property SisaVolume As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SisaVolume"))
      End Get
    End Property
    <Association("sanyu_kuotaimpor_podetail"), Aggregated> ReadOnly Property PO As XPCollection(Of SanYu_OrderPembelianDetail)
      Get
        Return GetCollection(Of SanYu_OrderPembelianDetail)("PO")
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Kuota Impor"
      If IsDeleted Then
        Return True
      End If

      If String.IsNullOrEmpty(_kodeHS) Then
        Throw New Utils.Exception("Masukkan kode HS", -1, "", source)
        Return False
      End If
      If String.IsNullOrEmpty(_noLampiran) Then
        Throw New Utils.Exception("Masukkan no lampiran", -2, "", source)
        Return False
      End If
      If _volume = Nothing Then
        Throw New Utils.Exception("Masukkan volume", -3, "", source)
        Return False
      End If
      If _satuan Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan", -4, "", source)
        Return False
      End If
      If _harga = Nothing Then
        Throw New Utils.Exception("Masukkan harga", -5, "", source)
        Return False
      End If
      If _mataUang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
        Return False
      End If
      If String.IsNullOrEmpty(_negara) Then
        Throw New Utils.Exception("Masukkan negara", -7, "", source)
        Return False
      End If
      If String.IsNullOrEmpty(_pelabuhan) Then
        Throw New Utils.Exception("Masukkan pelabuhan", -8, "", source)
        Return False
      End If
      If _expired = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal expired", -9, "", source)
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

  <Persistent("m05cmainorder")>
  Friend Class SanYu_OrderPembelian
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _tipe As NuSoft004.Persistent.TipeTransaksi
    'Private _nopenawaran As Penawaran
    'Private _nopermintaan As PermintaanStock
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _kontakalamat As NuSoft001.Persistent.KontakAlamat
    Private _alamat As String
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _fob As eTipeFOB
    Private _leadtime As String
    Private _termin As Termin
    Private _via As Via
    Private _tglberlaku As Date
    Private _pajak As eTipePajak
    Private _catatan As String
    Private _bagpembelian As NuSoft001.Persistent.Kontak
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _disc As Double
    Private _othercost As Double
    Private _uraian As String
    Private _reffnumber As String
    Private _custom1 As String
    Private _custom2 As String
    Private _custom3 As String
    Private _custom4 As String
    Private _custom5 As String
    Private _custom6 As String
    Private _custom7 As String
    Private _custom8 As String
    Private _custom9 As String
    Private _custom10 As String
    Private _dariDomestik As Boolean

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
    Property Tipe As NuSoft004.Persistent.TipeTransaksi
      Get
        Return _tipe
      End Get
      Set(value As NuSoft004.Persistent.TipeTransaksi)
        SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("Tipe", _tipe, value)
      End Set
    End Property
    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
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
    <Persistent("f_address")> Property KontakAlamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _kontakalamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("Alamat", _kontakalamat, value)
      End Set
    End Property
    <Persistent("d_address")> Property Alamat As String
      Get
        Return _alamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Alamat", _alamat, value)
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
    <Persistent("d_fob")>
    Property FOB As eTipeFOB
      Get
        Return _fob
      End Get
      Set(value As eTipeFOB)
        SetPropertyValue(Of eTipeFOB)("FOB", _fob, value)
      End Set
    End Property
    <Persistent("d_leadtime")>
    Property LeadTime As String
      Get
        Return _leadtime
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("LeadTime", _leadtime, value)
      End Set
    End Property
    <Persistent("f_termin")>
    Property Termin As Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As Persistent.Termin)
        SetPropertyValue(Of Persistent.Termin)("Termin", _termin, value)
      End Set
    End Property
    <Persistent("f_via")>
    Property Via As Persistent.Via
      Get
        Return _via
      End Get
      Set(value As Persistent.Via)
        SetPropertyValue(Of Persistent.Via)("Via", _via, value)
      End Set
    End Property
    <Persistent("d_efectivedate")>
    Property TanggalBerlaku As Date
      Get
        Return _tglberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerlaku", _tglberlaku, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As eTipePajak)
        SetPropertyValue(Of eTipePajak)("Pajak", _pajak, value)
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
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _bagpembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
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
    <Persistent("d_description")>
    Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
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
    <Persistent("d_custom1")>
    Property Custom1 As String
      Get
        Return _custom1
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom1", _custom1, value)
      End Set
    End Property
    <Persistent("d_custom2")>
    Property Custom2 As String
      Get
        Return _custom2
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom2", _custom2, value)
      End Set
    End Property
    <Persistent("d_custom3")>
    Property Custom3 As String
      Get
        Return _custom3
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom3", _custom3, value)
      End Set
    End Property
    <Persistent("d_custom4")>
    Property Custom4 As String
      Get
        Return _custom4
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom4", _custom4, value)
      End Set
    End Property
    <Persistent("d_custom5")>
    Property Custom5 As String
      Get
        Return _custom5
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom5", _custom5, value)
      End Set
    End Property
    <Persistent("d_custom6")>
    Property Custom6 As String
      Get
        Return _custom6
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom6", _custom6, value)
      End Set
    End Property
    <Persistent("d_custom7")>
    Property Custom7 As String
      Get
        Return _custom7
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom7", _custom7, value)
      End Set
    End Property
    <Persistent("d_custom8")>
    Property Custom8 As String
      Get
        Return _custom8
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom8", _custom8, value)
      End Set
    End Property
    <Persistent("d_custom9")>
    Property Custom9 As String
      Get
        Return _custom9
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom9", _custom9, value)
      End Set
    End Property
    <Persistent("d_custom10")>
    Property Custom10 As String
      Get
        Return _custom10
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom10", _custom10, value)
      End Set
    End Property
    <Persistent("d_fromdomestic")> Property DariDomestik As Boolean
      Get
        Return _dariDomestik
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("DariDomestik", _dariDomestik, value)
      End Set
    End Property
    <Association("sanyu_fk_order_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_OrderPembelianDetail)
      Get
        Return GetCollection(Of SanYu_OrderPembelianDetail)("Detail")
      End Get
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
    <NonPersistent()> ReadOnly Property Terbilang As String
      Get
        Return Utils.Common.Character.Terbilang(Total)
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Order Pembelian [PO]"
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
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -5, "", source)
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
  <Persistent("m05ddetailorder")>
  Friend Class SanYu_OrderPembelianDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_OrderPembelian
    Private _item As NuSoft004.Persistent.SanYu_Barang
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _catatan As String
    Private _kuotaImpor As SanYu_KuotaImpor
    Private _tonase As Double

    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("sanyu_fk_order_detail")>
    Property Main As SanYu_OrderPembelian
      Get
        Return _main
      End Get
      Set(value As SanYu_OrderPembelian)
        SetPropertyValue(Of SanYu_OrderPembelian)("Main", _main, value)
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
    <Persistent("d_tonase")>
    Property Tonase As Double
      Get
        Return _tonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tonase", _tonase, value)
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
    <Persistent("d_price")>
    Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
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
    <Persistent("f_kuotaimpor"), Association("sanyu_kuotaimpor_podetail")>
    Property KuotaImpor As SanYu_KuotaImpor
      Get
        Return _kuotaImpor
      End Get
      Set(value As SanYu_KuotaImpor)
        SetPropertyValue(Of SanYu_KuotaImpor)("KuotaImpor", _kuotaImpor, value)
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
    <PersistentAlias("Qty * Harga")> ReadOnly Property SubTotal As Double
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
      Dim source As String = "Order Pembelian [PO]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order pembelian", -99, "", source)
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
      If Not _kuotaImpor Is Nothing Then
        If _kuotaImpor.SisaVolume < 0 Then
          Throw New Utils.Exception("Sisa volume kuota impor " & _kuotaImpor.KodeHS & " habis.", -99, "", source)
          Return False
        End If
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

  'PIB
  <Persistent("m05cmainpib")>
  Friend Class SanYu_PIB
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
    Private _invoicepembelian As NuSoft005.Persistent.SanYu_PenerimaanInvoice
    Private _invoice As NuSoft005.Persistent.SanYu_PenerimaanInvoice
    Private _fasilitas As Boolean
    Private _kiteNoPengajuan As String
    Private _kiteNoDokumen As String
    Private _kiteTglDokumen As Date
    Private _kiteKodeKNT As String
    Private _kiteUmur As Long
    Private _kiteJatuhTempo As Date
    Private _gl As Persistent.GlMain

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
    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
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
    Property InvoicePembelian As SanYu_PenerimaanInvoice
      Get
        Return _invoicepembelian
      End Get
      Set(value As SanYu_PenerimaanInvoice)
        SetPropertyValue(Of SanYu_PenerimaanInvoice)("InvoicePembelian", _invoicepembelian, value)
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

    <Association("sanyu_fk_pib_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PIBDetail)
      Get
        Return GetCollection(Of SanYu_PIBDetail)("Detail")
      End Get
    End Property
    <Association("sanyu_fk_pib_biaya"), Aggregated> ReadOnly Property Biaya As XPCollection(Of SanYu_PIBBiaya)
      Get
        Return GetCollection(Of SanYu_PIBBiaya)("Biaya")
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
    '<Persistent("f_gl")> Property Gl As GlMain
    '  Get
    '    Return _gl
    '  End Get
    '  Set(value As GlMain)
    '    SetPropertyValue(Of GlMain)("Gl", _gl, value)
    '  End Set
    'End Property
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
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
      End If
      If _reffnumber Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor PIB", -5, "", source)
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
  <Persistent("m05ddetailpib")>
  Friend Class SanYu_PIBDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PIB
    Private _idinvoice As SanYu_PenerimaanInvoiceDetail
    Private _kite As Boolean
    Private _item As NuSoft004.Persistent.SanYu_Barang
    Private _qty As Double
    Private _tonase As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _bm As NuSoft004.Persistent.Pajak
    Private _bmp As Double
    Private _disc As Double
    Private _discp As Double
    Private _cif As Double
    Private _catatan As String
    Private _kuotaImpor As Persistent.SanYu_KuotaImpor
    Private _dorder As Int16
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("sanyu_fk_pib_detail")>
    Property Main As SanYu_PIB
      Get
        Return _main
      End Get
      Set(value As SanYu_PIB)
        SetPropertyValue(Of SanYu_PIB)("Main", _main, value)
      End Set
    End Property
    <Persistent("d_order")>
    Property Urutan As Int16
      Get
        Return _dorder
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Urutan", _dorder, value)
      End Set
    End Property

    <Persistent("f_idinvoice")>
    Property InvoiceDetail As Persistent.SanYu_PenerimaanInvoiceDetail
      Get
        Return _idinvoice
      End Get
      Set(value As Persistent.SanYu_PenerimaanInvoiceDetail)
        SetPropertyValue(Of Persistent.SanYu_PenerimaanInvoiceDetail)("InvoiceDetail", _idinvoice, value)
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
    <Persistent("d_tonase")>
    Property Tonase As Double
      Get
        Return _tonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tonase", _tonase, value)
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
    <Persistent("d_cif")>
    Property CIF As Double
      Get
        Return _cif
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("CIF", _cif, value)
      End Set
    End Property
    <PersistentAlias("Qty * Harga")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("CIF * Main.Kurs")> ReadOnly Property CIFKite As Double
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
    <Persistent("f_kuotaimpor")>
    Property KuotaImpor As SanYu_KuotaImpor
      Get
        Return _kuotaImpor
      End Get
      Set(value As SanYu_KuotaImpor)
        SetPropertyValue(Of SanYu_KuotaImpor)("KuotaImpor", _kuotaImpor, value)
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
  <Persistent("m05fbiayapib")>
  Friend Class SanYu_PIBBiaya
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PIB
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
    <Persistent("p_id"), Association("sanyu_fk_pib_biaya")>
    Property Main As SanYu_PIB
      Get
        Return _main
      End Get
      Set(value As SanYu_PIB)
        SetPropertyValue(Of SanYu_PIB)("Main", _main, value)
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

  <Persistent("m04cstockmain")> Friend Class SanYu_PenerimaanBarang
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _vendor As NuSoft001.Persistent.Kontak
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _kontakperson As String
    Private _bagpembelian As NuSoft001.Persistent.Kontak
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _gudang2 As NuSoft004.Persistent.Gudang
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _fromdomestik As Boolean
    Private _orderpembelian As Persistent.SanYu_OrderPembelian
    Private _pib As Persistent.SanYu_PIB
    Private _gl As Persistent.GlMain

    <Persistent("f_contact")> Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
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
    <Persistent("d_remarks")> Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_fromdomestic")>
    Property FromDomestik As Boolean
      Get
        Return _fromdomestik
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("FromDomestik", _fromdomestik, value)
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
        Return _bagpembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
      End Set
    End Property
    <Persistent("f_divisi")> Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Catatan", _divisi, value)
      End Set
    End Property
    <Persistent("f_warehouse2")> Property Gudang2 As NuSoft004.Persistent.Gudang
      Get
        Return _gudang2
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang2", _gudang2, value)
      End Set
    End Property
    <Persistent("f_currency")> Property MataUang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _uang, value)
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
    <Persistent("f_idpo")>
    Property OrderPembelian As SanYu_OrderPembelian
      Get
        Return _orderpembelian
      End Get
      Set(value As SanYu_OrderPembelian)
        SetPropertyValue(Of SanYu_OrderPembelian)("OrderPembelian", _orderpembelian, value)
      End Set
    End Property
    <Persistent("f_idpib")>
    Property PIB As SanYu_PIB
      Get
        Return _pib
      End Get
      Set(value As SanYu_PIB)
        SetPropertyValue(Of SanYu_PIB)("PIB", _pib, value)
      End Set
    End Property
    <Association("fk_SanYu_penerimaan_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PenerimaanBarangDetail)
      Get
        Return GetCollection(Of SanYu_PenerimaanBarangDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
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
    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Barang [GR]"
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
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -5, "", source)
        Return False
      End If
      'If Karyawan Is Nothing Then
      '  Throw New Utils.Exception("Masukkan karyawan penerima barang", -6, "", source)
      '  Return False
      'End If
      If Detail.Sum(Function(m) m.Qty) = 0 Then
        Throw New Utils.Exception("Masukkan nilai qty", -99, "", source)
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
  <Persistent("m04dstockdetail")> Friend Class SanYu_PenerimaanBarangDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PenerimaanBarang
    Private _item As NuSoft004.Persistent.SanYu_Barang
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _catatan As String
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _harga As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _orderdetail As Persistent.SanYu_OrderPembelianDetail
    Private _invoicedetail As Persistent.SanYu_PenerimaanInvoiceDetail
    Private _tonase As Double
    Private _noPIB As SanYu_PIBDetail
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_SanYu_penerimaan_detail")> Property Main As SanYu_PenerimaanBarang
      Get
        Return _main
      End Get
      Set(value As SanYu_PenerimaanBarang)
        SetPropertyValue(Of SanYu_PenerimaanBarang)("Main", _main, value)
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
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
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
    <Persistent("d_qtyin")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_tonase")>
    Property Tonase As Double
      Get
        Return _tonase
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Tonase", _tonase, value)
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
    <Persistent("f_idpod")>
    Property NoOrder As Persistent.SanYu_OrderPembelianDetail
      Get
        Return _orderdetail
      End Get
      Set(value As Persistent.SanYu_OrderPembelianDetail)
        SetPropertyValue(Of Persistent.SanYu_OrderPembelianDetail)("NoOrder", _orderdetail, value)
      End Set
    End Property
    <Persistent("f_idrid")>
    Property NoInvoice As Persistent.SanYu_PenerimaanInvoiceDetail
      Get
        Return _invoicedetail
      End Get
      Set(value As Persistent.SanYu_PenerimaanInvoiceDetail)
        SetPropertyValue(Of Persistent.SanYu_PenerimaanInvoiceDetail)("NoInvoice", _invoicedetail, value)
      End Set
    End Property
    <Persistent("f_idpib")>
    Property NoPIB As Persistent.SanYu_PIBDetail
      Get
        Return _noPIB
      End Get
      Set(value As Persistent.SanYu_PIBDetail)
        SetPropertyValue(Of Persistent.SanYu_PIBDetail)("NoPIB", _noPIB, value)
      End Set
    End Property
    <PersistentAlias("(Qty * Harga)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Barang [GR]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
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

  <Persistent("m05cmaininvoicereceipt")>
  Friend Class SanYu_PenerimaanInvoice
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _tipe As Persistent.eTipeInvoicePembelian
    Private _tglberlaku As Date
    Private _termin As Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _jenispajak As Persistent.eJenisPajak
    Private _pajak As Persistent.eTipePajak
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    Private _noorder As Persistent.SanYu_OrderPembelian
    Private _taxp As Double
    Private _noreffvendor As String
    Private _fromdomestik As Boolean
    Private _gl As Persistent.GlMain
    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
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
    <Persistent("d_tipe")>
    Property TipeTransaksi As Persistent.eTipeInvoicePembelian
      Get
        Return _tipe
      End Get
      Set(value As Persistent.eTipeInvoicePembelian)
        SetPropertyValue(Of Persistent.eTipeInvoicePembelian)("TipeTransaksi", _tipe, value)
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
    Property Termin As Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As Persistent.Termin)
        SetPropertyValue(Of Persistent.Termin)("Termin", _termin, value)
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
    Property JenisPajak As eJenisPajak
      Get
        Return _jenispajak
      End Get
      Set(value As eJenisPajak)
        SetPropertyValue(Of eJenisPajak)("JenisPajak", _jenispajak, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As eTipePajak)
        SetPropertyValue(Of eTipePajak)("TipePajak", _pajak, value)
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
    <Persistent("d_taxsnppn")>
    Property NoSNPPN As String
      Get
        Return _nosnppn
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPN", _nosnppn, value)
      End Set
    End Property
    <Persistent("d_taxsnpph")>
    Property NoSNPPh As String
      Get
        Return _nosnpph
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPh", _nosnpph, value)
      End Set
    End Property
    <Persistent("d_externalnumber")>
    Property NoReffVendor As String
      Get
        Return _noreffvendor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoReffVendor", _noreffvendor, value)
      End Set
    End Property
    <Persistent("p_idorder")>
    Property NoOrder As Persistent.SanYu_OrderPembelian
      Get
        Return _noorder
      End Get
      Set(value As Persistent.SanYu_OrderPembelian)
        SetPropertyValue(Of Persistent.SanYu_OrderPembelian)("NoOrder", _noorder, value)
      End Set
    End Property
    <Persistent("d_fromdomestic")>
    Property FromDomestik As Boolean
      Get
        Return _fromdomestik
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("FromDomestik", _fromdomestik, value)
      End Set
    End Property
    <Association("fk_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PenerimaanInvoiceDetail)
      Get
        Return GetCollection(Of SanYu_PenerimaanInvoiceDetail)("Detail")
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
    <PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
      Get
        Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
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
    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Invoice [RI]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
      End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
      End If

      'If Uang.Id <> Uang.HutangDagang.MataUang.Id Then
      '  Throw New Utils.Exception("Mata uang untuk coa [Hutang Dagang] tidak sama dengan mata uang transaksi", -7, "", source)
      'End If
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
  <Persistent("m05ddetailinvoicereceipt")>
  Friend Class SanYu_PenerimaanInvoiceDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.SanYu_PenerimaanInvoice
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
    Private _idgr As Persistent.SanYu_PenerimaanBarangDetail
    Private _proyek As NuSoft001.Persistent.Proyek
    Private _idpo As Persistent.SanYu_OrderPembelianDetail
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_invoice_detail")>
    Property Main As SanYu_PenerimaanInvoice
      Get
        Return _main
      End Get
      Set(value As SanYu_PenerimaanInvoice)
        SetPropertyValue(Of SanYu_PenerimaanInvoice)("Main", _main, value)
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
    <Persistent("f_idgr")>
    Property PenerimaanBarang As Persistent.SanYu_PenerimaanBarangDetail
      Get
        Return _idgr
      End Get
      Set(value As Persistent.SanYu_PenerimaanBarangDetail)
        SetPropertyValue(Of Persistent.SanYu_PenerimaanBarangDetail)("PenerimaanBarang", _idgr, value)
      End Set
    End Property
    <Persistent("f_po")>
    Property OrderPembelian As Persistent.SanYu_OrderPembelianDetail
      Get
        Return _idpo
      End Get
      Set(value As Persistent.SanYu_OrderPembelianDetail)
        SetPropertyValue(Of Persistent.SanYu_OrderPembelianDetail)("OrderPembelian", _idpo, value)
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
    <PersistentAlias("(Qty * Harga)-(Qty * Discount)")> ReadOnly Property SubTotal As Double
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
        Throw New Utils.Exception("Masukkan data utama Penerimaan Invoice", -99, "", source)
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
      MyBase.OnSaving()
    End Sub
  End Class

  <Persistent("m05cmainpayment")> Friend Class SanYu_PembayaranHutang
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _vendor As NuSoft001.Persistent.Kontak
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

    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
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

    <NonPersistent()> ReadOnly Property TotalGL As Double
      Get
        Return Gl.Saldo
      End Get
    End Property
    <Association("fk_sanyu_pembayaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of SanYu_PembayaranHutangDetail)
      Get
        Return GetCollection(Of SanYu_PembayaranHutangDetail)("Detail")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property SelisihKurs As Double
      Get
        Return Detail.Sum(Function(m) m.NilaiBayar * m.NoInvoice.Kurs) - Detail.Sum(Function(m) m.NilaiBayar * m.Kurs)
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Pembayaran Hutang [VP]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Vendor Is Nothing Then
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
  <Persistent("m05ddetailpayment")>
  Friend Class SanYu_PembayaranHutangDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As SanYu_PembayaranHutang
    Private _idinvoice As SanYu_PenerimaanInvoice
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
    <Persistent("p_id"), Association("fk_sanyu_pembayaran_detail")>
    Property Main As SanYu_PembayaranHutang
      Get
        Return _main
      End Get
      Set(value As SanYu_PembayaranHutang)
        SetPropertyValue(Of SanYu_PembayaranHutang)("Main", _main, value)
      End Set
    End Property
    <Persistent("p_idinvoice")>
    Property NoInvoice As SanYu_PenerimaanInvoice
      Get
        Return _idinvoice
      End Get
      Set(value As SanYu_PenerimaanInvoice)
        SetPropertyValue(Of SanYu_PenerimaanInvoice)("NoInvoice", _idinvoice, value)
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
        Throw New Utils.Exception("Masukkan data utama pembayaran hutang", -99, "", source)
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
  Friend Class SanYu_BayarHutangTemp
    Property NoInvoice As SanYu_PenerimaanInvoice
    Property Urutan As Byte
    Property Terbayar As Double
    Property NilaiBayarCash As Double
    Property Kurs As Double
    Property OK As Boolean
    Property Catatan As String

    ReadOnly Property SisaHutang As Double
      Get
        Return NoInvoice.Total - Terbayar
      End Get
    End Property
  End Class
End Namespace