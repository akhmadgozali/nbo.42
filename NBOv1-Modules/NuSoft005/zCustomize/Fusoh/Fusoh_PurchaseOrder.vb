Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m05cmainorder")>
  Friend Class Fusoh_OrderPembelian
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
    Private _Eta As Date
    Private _Etd As String
    Private _maker As String
    Private _hargashippingcost As Double
		Private _revisi As Int16

		<Persistent("d_rev")> Property Revisi As Int16
			Get
				Return _revisi
			End Get
			Set(value As Int16)
				SetPropertyValue(Of Int16)("Revisi", _revisi, value)
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
    <Persistent("d_eta")>
    Property ETA As Date
      Get
        Return _Eta
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("ETA", _Eta, value)
      End Set
    End Property
    <Persistent("d_etd")>
    Property ETD As String
      Get
        Return _Etd
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ETD", _Etd, value)
      End Set
    End Property
    <Persistent("d_maker")>
    Property Maker As String
      Get
        Return _maker
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Maker", _maker, value)
      End Set
    End Property

    '<Persistent("d_remarksapp")>
    'Property CatatanApprove As String
    '	Get
    '		Return _catatanapp
    '	End Get
    '	Set(value As String)
    '		SetPropertyValue(Of String)("CatatanApprove", _catatanapp, value)
    '	End Set
    'End Property
    '<Persistent("f_idquotation")>
    'Property NoPenawaran As Persistent.Penawaran
    '	Get
    '		Return _nopenawaran
    '	End Get
    '	Set(value As Persistent.Penawaran)
    '		SetPropertyValue(Of Persistent.Penawaran)("NoPenawaran", _nopenawaran, value)
    '	End Set
    'End Property
    <Persistent("d_shippingcost")>
    Property ShippingCost As Double
      Get
        Return _hargashippingcost
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("ShippingCost", _hargashippingcost, value)
      End Set
    End Property

    <Association("fusoh_fk_order_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_OrderPembelianDetail)
      Get
        Return GetCollection(Of Fusoh_OrderPembelianDetail)("Detail")
      End Get
    End Property
    <Association("fusoh_fk_exim_ordermain"), Aggregated> ReadOnly Property Exim As XPCollection(Of Fusoh_Exim)
      Get
        Return GetCollection(Of Fusoh_Exim)("Exim")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property NoReffInvoice As String
      Get
        If Exim.Count > 0 Then
          If Exim(0).InvoicePembelian.Count > 0 Then
            Return Exim(0).InvoicePembelian(0).NoReffVendor
          Else
            Return ""
          End If
        Else
          Return ""
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property ETAActual As String
      Get
        If Exim.Count > 0 Then
          Return Exim(0).TanggalPenerimaanBarang
        Else
          Return ""
        End If
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
    <PersistentAlias("Detail.Sum(WeightManual)")> ReadOnly Property TotalWeight As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalWeight"))
      End Get
    End Property
    <PersistentAlias("(ShippingCost * TotalWeight)")> ReadOnly Property TotalShippingCost As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalShippingCost"))
      End Get
    End Property
    <PersistentAlias("(TotalShippingCost + Total)")> ReadOnly Property GrandTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("GrandTotal"))
      End Get
    End Property
    <NonPersistent()> ReadOnly Property Terbilang As String
      Get
        Return Utils.Common.Character.Terbilang(Total)
      End Get
    End Property
    <NonPersistent()> ReadOnly Property ETAD As Long
      Get
        Return DateDiff(DateInterval.Day, Date.Now(), ETA)
      End Get
    End Property
    <NonPersistent()> ReadOnly Property StatusD As Long
      Get
        Return _status
      End Get
    End Property
    <NonPersistent()> ReadOnly Property xLeadTime As Long
      Get
        Return DateDiff(DateInterval.Day, Tanggal, ETA)
      End Get
    End Property
    '<PersistentAlias("DateDiffDay(Tanggal,TanggalArsip)")> ReadOnly Property LeadTime As Integer
    '  Get
    '    Return Convert.ToInt32(EvaluateAlias("LeadTime"))
    '  End Get
    'End Property

    '<PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
    '  Get
    '    Return Convert.ToString(EvaluateAlias("Terbilang"))
    '  End Get
    'End Property
    '<PersistentAlias("TerbilangEnglish(Total)")> ReadOnly Property TerbilangEnglish As String
    '  Get
    '    Return Convert.ToString(EvaluateAlias("TerbilangEnglish"))
    '  End Get
    'End Property

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
      If _Eta = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal eta", -7, "", source)

      End If

      ''======= PINDAH KE DIALOG
      ''======= Cek Periode
      'If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
      '  Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
      '  Return False
      'End If
      ''======= Cek Sebelum Awal Periode
      'If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
      '  Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
      '  Return False
      'End If
      ''======= PINDAH KE DIALOG

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
  Friend Class Fusoh_OrderPembelianDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_OrderPembelian
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _harga As Double
    Private _hargaPerKg As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _catatan As String
    Private _kuotaImpor As Fusoh_KuotaImpor
    Private _weightm As Decimal

    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fusoh_fk_order_detail")>
    Property Main As Fusoh_OrderPembelian
      Get
        Return _main
      End Get
      Set(value As Fusoh_OrderPembelian)
        SetPropertyValue(Of Fusoh_OrderPembelian)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
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
    <Persistent("d_weightm")> Property WeightManual As Decimal
      Get
        Return _weightm
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("WeightManual", _weightm, value)
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
    <Persistent("d_pricekg")>
    Property HargaPerKg As Double
      Get
        Return _hargaPerKg
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaPerKg", _hargaPerKg, value)
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
    <Persistent("f_kuotaimpor"), Association("fusoh_kuotaimpor_podetail")>
    Property KuotaImpor As Fusoh_KuotaImpor
      Get
        Return _kuotaImpor
      End Get
      Set(value As Fusoh_KuotaImpor)
        SetPropertyValue(Of Fusoh_KuotaImpor)("KuotaImpor", _kuotaImpor, value)
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
    <PersistentAlias("Main.ShippingCost * WeightManual")> ReadOnly Property ShippingCost As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("ShippingCost"))
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

    <Association("fusoh_podetail_revisilength")>
    ReadOnly Property RevisiLength As XPCollection(Of Fusoh_OrderPembelianDetailRevisiLength)
      Get
        Return GetCollection(Of Fusoh_OrderPembelianDetailRevisiLength)("RevisiLength")
      End Get
    End Property
    <PersistentAlias("(Qty * Harga) + ShippingCost")> ReadOnly Property CIFAmount As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("CIFAmount"))
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

    '=================================
    <Association("fusoh_podetail_invoicedetail")> ReadOnly Property InvoiceDetail As XPCollection(Of Fusoh_PenerimaanInvoiceDetail)
      Get
        Return GetCollection(Of Fusoh_PenerimaanInvoiceDetail)(NameOf(InvoiceDetail))
      End Get
    End Property
    <PersistentAlias(NameOf(InvoiceDetail) & ".Sum(" & NameOf(Fusoh_PenerimaanInvoiceDetail.Qty) & ")")> ReadOnly Property QtyInvoice As Double
      Get
        Return Convert.ToDouble(EvaluateAlias(NameOf(QtyInvoice)))
      End Get
    End Property
    <PersistentAlias(NameOf(Qty) & " - " & NameOf(QtyInvoice))> ReadOnly Property SisaQtyDiInvoice As Double
      Get
        Return Convert.ToDouble(EvaluateAlias(NameOf(SisaQtyDiInvoice)))
      End Get
    End Property
  End Class

	<Persistent("m05eporevisilength")> Friend Class Fusoh_OrderPembelianDetailRevisiLength
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _poDetail As Fusoh_OrderPembelianDetail
		Private _lengthLama As Double
		Private _lengthBaru As Double
		Private _keterangan As String

		<Persistent("Id"), Key(True)>
		Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("PODetail"), Association("fusoh_podetail_revisilength")> Property PODetail As Fusoh_OrderPembelianDetail
			Get
				Return _poDetail
			End Get
			Set(value As Fusoh_OrderPembelianDetail)
				SetPropertyValue(Of Fusoh_OrderPembelianDetail)("PODetail", _poDetail, value)
			End Set
		End Property
		<Persistent("LengthLama")> Property LengthLama As Double
			Get
				Return _lengthLama
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("LengthLama", _lengthLama, value)
			End Set
		End Property
		<Persistent("LengthBaru")> Property LengthBaru As Double
			Get
				Return _lengthBaru
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("LengthBaru", _lengthBaru, value)
			End Set
		End Property
		<Persistent("Keterangan")> Property Keterangan As String
			Get
				Return _keterangan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Keterangan", _keterangan, value)
			End Set
		End Property
	End Class

	Friend Class Fusoh_OrderPembelianDetail_Impor
		Property KodeBarang As String
		Property NamaBarang As String
		Property Barang As NuSoft004.Persistent.Fusoh_Barang
		Property OutDiameter As Decimal
		Property InDiameter As Decimal
		Property Thickness As Decimal
		Property Length As Decimal
		Property Qty As Double
		'Property Weight As Decimal
		Property Harga As Double
		Property ShippingCost As Double
		Property Catatan As String
		Property WeightM As Double

		ReadOnly Property Weight As Double
			Get
				Return NuSoft004.FusohLogic.Item.GetWeight(OutDiameter, Length, Thickness)
			End Get
		End Property
		ReadOnly Property SubTotal As Double
			Get
				Return Qty * Harga
			End Get
		End Property
	End Class

End Namespace

Namespace NonPersistent
  Friend Class Fusoh_PORevisiLength
    Property PODetail As Persistent.Fusoh_OrderPembelianDetail
    Property EximDetail As Persistent.Fusoh_EximDetail
    Property GRDetail As Persistent.Fusoh_PenerimaanBarangDetail
    Property Dempyou As List(Of Persistent.Fusoh_OrderProduksi)
    Property Produksi As List(Of Persistent.Fusoh_PenerimaanBarang)
    Property LengthBaru As Double
    Property Keterangan As String

    ReadOnly Property JumlahDempyou As Integer
      Get
        If Dempyou Is Nothing Then
          Return 0
        End If
        Return Dempyou.Count
      End Get
    End Property
    ReadOnly Property JumlahProduksi As Integer
      Get
        If Produksi Is Nothing Then
          Return 0
        End If
        Return Produksi.Count
      End Get
    End Property
    ReadOnly Property JumlahRevisi As Integer
      Get
        Return PODetail.RevisiLength.Count
      End Get
    End Property
  End Class
End Namespace