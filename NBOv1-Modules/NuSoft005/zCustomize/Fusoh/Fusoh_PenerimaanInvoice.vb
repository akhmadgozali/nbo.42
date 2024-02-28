Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m05cmaininvoicereceipt")> Friend Class Fusoh_PenerimaanInvoice
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _vendor As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _tipe As eTipeInvoicePembelian
    Private _tglberlaku As Date
    Private _arriveddate As Date
    Private _bldate As Date
    Private _termin As Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _jenispajak As eJenisPajak
    Private _pajak As eTipePajak
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    Private _noorder As Fusoh_OrderPembelian
    Private _noexim As Fusoh_Exim
    Private _noparent As Fusoh_PenerimaanInvoice
    Private _nilaisaldoawal As Double
    Private _noreffvendor As String
		Private _jenisCostSheet As String
		Private _revisi As Int16
		'Private _shippingcost As Double

		<Persistent("d_rev")> Property Revisi As Int16
			Get
				Return _revisi
			End Get
			Set(value As Int16)
				SetPropertyValue(Of Int16)("Revisi", _revisi, value)
			End Set
		End Property

		<Persistent("f_vendor")> Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
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
    <Persistent("d_tipe")> Property TipeTransaksi As Persistent.eTipeInvoicePembelian
      Get
        Return _tipe
      End Get
      Set(value As Persistent.eTipeInvoicePembelian)
        SetPropertyValue(Of Persistent.eTipeInvoicePembelian)("TipeTransaksi", _tipe, value)
      End Set
    End Property
    <Persistent("d_duedate")> Property TanggalBerlaku As Date
      Get
        Return _tglberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerlaku", _tglberlaku, value)
      End Set
    End Property
    <Persistent("d_arriveddate")> Property ArrivedDate As Date
      Get
        Return _arriveddate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("ArrivedDate", _arriveddate, value)
      End Set
    End Property
    <Persistent("d_bldate")> Property BLDate As Date
      Get
        Return _bldate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("BLDate", _bldate, value)
      End Set
    End Property
    <Persistent("f_termin")> Property Termin As Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As Persistent.Termin)
        SetPropertyValue(Of Persistent.Termin)("Termin", _termin, value)
      End Set
    End Property
    <Persistent("f_employee")> Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _karyawan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _karyawan, value)
      End Set
    End Property
    <Persistent("f_currency")> Property Uang As NuSoft001.Persistent.MataUang
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
    <Persistent("d_taxcaption")> Property JenisPajak As eJenisPajak
      Get
        Return _jenispajak
      End Get
      Set(value As eJenisPajak)
        SetPropertyValue(Of eJenisPajak)("JenisPajak", _jenispajak, value)
      End Set
    End Property
    <Persistent("d_taxtype")> Property TipePajak As eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As eTipePajak)
        SetPropertyValue(Of eTipePajak)("TipePajak", _pajak, value)
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
    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("d_disc")> Property Discount As Double
      Get
        Return _disc
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Discount", _disc, value)
      End Set
    End Property
    <Persistent("d_othercost")> Property BiayaLain As Double
      Get
        Return _othercost
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
      End Set
    End Property

    <Persistent("d_taxsnppn")> Property NoSNPPN As String
      Get
        Return _nosnppn
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPN", _nosnppn, value)
      End Set
    End Property
    <Persistent("d_taxsnpph")> Property NoSNPPh As String
      Get
        Return _nosnpph
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPh", _nosnpph, value)
      End Set
    End Property
    <Persistent("d_externalnumber")> Property NoReffVendor As String
      Get
        Return _noreffvendor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoReffVendor", _noreffvendor, value)
      End Set
    End Property

    <Persistent("p_idorder")> Property NoOrder As Fusoh_OrderPembelian
      Get
        Return _noorder
      End Get
      Set(value As Fusoh_OrderPembelian)
        SetPropertyValue(Of Fusoh_OrderPembelian)("NoOrder", _noorder, value)
      End Set
    End Property
    <Persistent("p_idexim"), Association("fusoh_fk_exim_invoice")> Property NoExim As Fusoh_Exim
      Get
        Return _noexim
      End Get
      Set(value As Fusoh_Exim)
        SetPropertyValue(Of Fusoh_Exim)("NoExim", _noexim, value)
      End Set
    End Property
    <Persistent("p_idparent"), Association("fk_fusoh_invoice_detail_cost")> Property IndukInvoice As Fusoh_PenerimaanInvoice
      Get
        Return _noparent
      End Get
      Set(value As Fusoh_PenerimaanInvoice)
        SetPropertyValue(Of Fusoh_PenerimaanInvoice)("IndukInvoice", _noparent, value)
      End Set
    End Property

    'property untuk saldo awal hutang
    <Persistent("d_bbvalue")> Property NilaiSaldoAwal As Double
      Get
        Return _nilaisaldoawal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiSaldoAwal", _nilaisaldoawal, value)
      End Set
    End Property

    <Association("fk_fusoh_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_PenerimaanInvoiceDetail)
      Get
        Return GetCollection(Of Fusoh_PenerimaanInvoiceDetail)("Detail")
      End Get
    End Property
    <Association("fk_fusoh_invoice_detail_cost"), Aggregated> ReadOnly Property DetailCost As XPCollection(Of Fusoh_PenerimaanInvoice)
      Get
        Return GetCollection(Of Fusoh_PenerimaanInvoice)("DetailCost")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
		<PersistentAlias("ROUND(Detail.Sum(PPNv),0)")> ReadOnly Property PPN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPN"))
      End Get
    End Property
		<PersistentAlias("ROUND(Detail.Sum(PPHv),0)")> ReadOnly Property PPH As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPH"))
      End Get
    End Property
    ''<PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
    ''	Get
    ''		Return Convert.ToDouble(EvaluateAlias("Total"))
    ''	End Get
    ''End Property
    ''<PersistentAlias("(SubTotal + PPN - PPH) * Kurs")> ReadOnly Property TotalIDR As Double
    ''	Get
    ''		Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
    ''	End Get
    ''End Property
    <PersistentAlias("Detail.Sum(Total)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalIDR)")> ReadOnly Property TotalIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
      End Get
    End Property

    <PersistentAlias("Detail.Sum(Weight)")> ReadOnly Property TotalWeight As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalWeight"))
      End Get
    End Property

    <PersistentAlias("DetailCost.Sum(Total)")> ReadOnly Property TotalCost As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCost"))
      End Get
    End Property
    <PersistentAlias("DetailCost.Sum(TotalIDR)")> ReadOnly Property TotalCostIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostIDR"))
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

    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property

    <PersistentAlias("Total + TotalCost")> ReadOnly Property TotalPembelian As Double
      Get
        'Return Total + TotalCost
        Return Convert.ToDouble(EvaluateAlias("TotalPembelian"))
      End Get
    End Property
		<PersistentAlias("TotalIDR + TotalCostIDR + ShippingCost")> ReadOnly Property TotalPembelianIDR As Double
			Get
				'Return Total + TotalCost
				Return Convert.ToDouble(EvaluateAlias("TotalPembelianIDR"))
			End Get
		End Property
		<PersistentAlias("Detail.Sum(ShippingCost)")> ReadOnly Property ShippingCost As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("ShippingCost"))
			End Get
		End Property

		Private Function CheckData() As Boolean
			Dim source As String = "Penerimaan Invoice [RI]"
			If Regional Is Nothing Then
				Throw New Utils.Exception("Masukkan regional", -1, "", source)
				Return False
			End If
			If Tanggal = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
				Return False
			End If
			If Vendor Is Nothing Then
				Throw New Utils.Exception("Masukkan Vendor", -3, "", source)
				Return False
			End If
			If Uang Is Nothing Then
				Throw New Utils.Exception("Masukkan mata uang", -4, "", source)
			End If
      'If TipeTransaksi = eTipeInvoicePembelian.PakaiPO AndAlso NoOrder Is Nothing Then
      'Throw New Utils.Exception("Masukkan PO", -5, "", source)
      'End If
      If String.IsNullOrEmpty(NoReffVendor) Then
        Throw New Utils.Exception("Masukkan nomor invoice dari vendor", -6, "", source)
      End If

      '======= PINDAH KE DIALOG
      '======= Cek Periode
      '   If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
      '	Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
      '	Return False
      'End If
      ''======= Cek Sebelum Awal Periode
      'If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
      '	Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
      '	Return False
      'End If
      '======= PINDAH KE DIALOG

      'If Not Detail.Count > 0 Then
      '	Throw New Utils.Exception("Masukkan detail invoice", -99, "", source)
      'End If

      'If Uang.Id <> Uang.HutangDagang.MataUang.Id Then
      '	Throw New Utils.Exception("Mata uang untuk coa [Hutang Dagang] tidak sama dengan mata uang transaksi", -7, "", source)
      'End If
      If Session.IsNewObject(Me) Then
				If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
					Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -98, "", source)
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


    '==================== pemisahan import duty dan bukan
    <PersistentAlias("Detail.Sum(TotalBukanImportDuty)")> ReadOnly Property TotalBukanImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDuty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalBukanImportDutyIDR)")> ReadOnly Property TotalBukanImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalImportDuty)")> ReadOnly Property TotalImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalImportDuty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalImportDutyIDR)")> ReadOnly Property TotalImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalKenaImportDuty)")> ReadOnly Property TotalKenaImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDuty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalKenaImportDutyIDR)")> ReadOnly Property TotalKenaImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDutyIDR"))
      End Get
    End Property

    <PersistentAlias("DetailCost.Sum(TotalBukanImportDuty)")> ReadOnly Property TotalCostBukanImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDuty"))
      End Get
    End Property
    <PersistentAlias("DetailCost.Sum(TotalBukanImportDutyIDR)")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("DetailCost.Sum(TotalImportDuty)")> ReadOnly Property TotalCostImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostImportDuty"))
      End Get
    End Property
    <PersistentAlias("DetailCost.Sum(TotalImportDutyIDR)")> ReadOnly Property TotalCostImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
      End Get
    End Property


    '==================== perubahan alur
    <Association("fusoh_eximmain_invoicemain")> ReadOnly Property DaftarExim As XPCollection(Of Fusoh_Exim)
      Get
        Return GetCollection(Of Fusoh_Exim)(NameOf(DaftarExim))
      End Get
    End Property
  End Class

  <Persistent("m05ddetailinvoicereceipt")> Friend Class Fusoh_PenerimaanInvoiceDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_PenerimaanInvoice
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _qty As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _hargaKg As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _disc As Double
    Private _discp As Double
    Private _catatan As String
    Private _idpo As Fusoh_OrderPembelianDetail
    Private _idexim As Fusoh_EximDetail
    Private _kenaImportDuty As Boolean
    Private _totalCostImportDuty As Double
		Private _kuotaImport As Fusoh_KuotaImpor
		Private _shippingcost As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Double

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_invoice_detail")> Property Main As Fusoh_PenerimaanInvoice
      Get
        Return _main
      End Get
      Set(value As Fusoh_PenerimaanInvoice)
        SetPropertyValue(Of Fusoh_PenerimaanInvoice)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
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
		<Persistent("d_shippingcost")> Property ShippingCost As Double
			Get
				Return _shippingcost
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("ShippingCost", _shippingcost, value)
			End Set
		End Property
		<Persistent("d_weight")> Property WeightManual As Double
			Get
				Return _weight
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("WeightManual", _weight, value)
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
    <Persistent("d_price")> Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
      End Set
    End Property
    <Persistent("d_pricekg")> Property HargaKG As Double
      Get
        Return _hargaKg
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaKG", _hargaKg, value)
      End Set
    End Property
    <Persistent("d_disc")> Property Discount As Double
      Get
        Return _disc
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Discount", _disc, value)
      End Set
    End Property
    <Persistent("d_discp")> Property DiscountPersen As Double
      Get
        Return _discp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DiscountPersen", _discp, value)
      End Set
    End Property
    <Persistent("f_taxin")> Property PPN As NuSoft004.Persistent.Pajak
      Get
        Return _ppn
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _ppn, value)
      End Set
    End Property
    <Persistent("d_taxinp")> Property PPNp As Double
      Get
        Return _ppnp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPNp", _ppnp, value)
      End Set
    End Property
    <Persistent("f_taxout")> Property PPH As NuSoft004.Persistent.Pajak
      Get
        Return _pph
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _pph, value)
      End Set
    End Property
    <Persistent("d_taxoutp")> Property PPHp As Double
      Get
        Return _pphp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPHp", _pphp, value)
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
    <Association("fusoh_podetail_invoicedetail"), Persistent("f_idpo")> Property PODetail As Fusoh_OrderPembelianDetail
      Get
        Return _idpo
      End Get
      Set(value As Fusoh_OrderPembelianDetail)
        SetPropertyValue(Of Fusoh_OrderPembelianDetail)("PODetail", _idpo, value)
      End Set
    End Property
    <Persistent("f_idexim")> Property EximDetail As Fusoh_EximDetail
      Get
        Return _idexim
      End Get
      Set(value As Fusoh_EximDetail)
        SetPropertyValue(Of Fusoh_EximDetail)("EximDetail", _idexim, value)
      End Set
    End Property
    <Persistent("d_isimportduty")> Property KenaImportDuty As Boolean
      Get
        Return _kenaImportDuty
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("KenaImportDuty", _kenaImportDuty, value)
      End Set
    End Property
    <Association("fusoh_kuotaimpor_invoicedetail"), Persistent("f_kuotaimport")> Property KuotaImport As Fusoh_KuotaImpor
      Get
        Return _kuotaImport
      End Get
      Set(value As Fusoh_KuotaImpor)
        SetPropertyValue(Of Fusoh_KuotaImpor)("KuotaImport", _kuotaImport, value)
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
    <PersistentAlias("Total * Main.Kurs")> ReadOnly Property TotalIDR As Double
      Get
        'Return Total * Main.Kurs
        Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("DPP"))
      End Get
    End Property
    <PersistentAlias("Harga * Main.Kurs")> ReadOnly Property HargaIDR As Double
      Get
        'Return Harga * Main.Kurs
        Return Convert.ToDouble(EvaluateAlias("HargaIDR"))
      End Get
    End Property

    <PersistentAlias("IsNull(EximDetail.Weight, IsNull(Qty * (PODetail.Weight/PODetail.Qty), Barang.Weight))")> ReadOnly Property Weight As Decimal
			Get
				Return Convert.ToDecimal(EvaluateAlias("Weight"))
			End Get
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
    '<PersistentAlias("IsNull(PODetail.OutDiameter, Barang.OutDiameter)")> ReadOnly Property OutDiameter As Decimal
    '  Get
    '    Return Convert.ToDecimal(EvaluateAlias("OutDiameter"))
    '  End Get
    'End Property
    '<PersistentAlias("IsNull(PODetail.InDiameter, Barang.InDiameter)")> ReadOnly Property InDiameter As Decimal
    '  Get
    '    Return Convert.ToDecimal(EvaluateAlias("InDiameter"))
    '  End Get
    'End Property
    '<PersistentAlias("IsNull(PODetail.Thickness, Barang.Thickness)")> ReadOnly Property Thickness As Decimal
    '  Get
    '    Return Convert.ToDecimal(EvaluateAlias("Thickness"))
    '  End Get
    'End Property
    '<PersistentAlias("IsNull(PODetail.Length, Barang.Length)")> ReadOnly Property Length As Decimal
    '  Get
    '    Return Convert.ToDecimal(EvaluateAlias("Length"))
    '  End Get
    'End Property

    '<PersistentAlias("Qty * (PODetail.Weight/PODetail.Qty)")> ReadOnly Property Weight As Decimal
    '    Get
    '      Return Convert.ToDecimal(EvaluateAlias("Weight"))
    '    End Get
    '  End Property
    'row.HargaPerKg = row.Harga / (row.WeightManual / row.Qty)

    '<PersistentAlias("Iif(WeightManual = 0, 0, Harga / (WeightManual / Qty))")> ReadOnly Property HargaKG As Decimal
    '<PersistentAlias("PODetail.HargaPerKg")> ReadOnly Property HargaKG As Decimal
    '	Get
    '		Return Convert.ToDecimal(EvaluateAlias("HargaKG"))
    '	End Get
    'End Property

    <PersistentAlias("TotalCostBukanImportDuty + TotalCostImportDuty")> ReadOnly Property TotalCost As Double
			Get
				'Return (Total / Main.Total) * Main.TotalCost
				Return Convert.ToDouble(EvaluateAlias("TotalCost"))
			End Get
		End Property
		<PersistentAlias("TotalCostBukanImportDutyIDR + TotalCostImportDutyIDR")> ReadOnly Property TotalCostIDR As Double
      Get
        'Return (Total / Main.TotalIDR) * Main.TotalCostIDR
        Return Convert.ToDouble(EvaluateAlias("TotalCostIDR"))
      End Get
    End Property
    <PersistentAlias("Total + TotalCost")> ReadOnly Property TotalPembelian As Double
      Get
        'Return Total + TotalCost
        Return Convert.ToDouble(EvaluateAlias("TotalPembelian"))
      End Get
    End Property
    <PersistentAlias("TotalIDR + TotalCostIDR")> ReadOnly Property TotalPembelianIDR As Double
      Get
        'Return TotalIDR + TotalCostIDR
        Return Convert.ToDouble(EvaluateAlias("TotalPembelianIDR"))
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

    '==================== pemisahan import duty dan bukan
    '=============== cost sheet detail
    <PersistentAlias("iif(Barang.Custom1='" & Fusoh_Logic.Umum.ImportDutyCustom & "',0,iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal))")> ReadOnly Property TotalBukanImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDuty"))
      End Get
    End Property
    <PersistentAlias("TotalBukanImportDuty * Main.Kurs")> ReadOnly Property TotalBukanImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("iif(Barang.Custom1='" & Fusoh_Logic.Umum.ImportDutyCustom & "',iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal),0)")> ReadOnly Property TotalImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalImportDuty"))
      End Get
    End Property
    <PersistentAlias("TotalImportDuty * Main.Kurs")> ReadOnly Property TotalImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalImportDutyIDR"))
      End Get
    End Property

    '----------- Invoice Weight
    '<PersistentAlias("iif(KenaImportDuty,Total,0)")> ReadOnly Property TotalKenaImportDuty As Double
    '<PersistentAlias("iif(KenaImportDuty,Weight,0)")> ReadOnly Property TotalKenaImportDuty As Double
    <PersistentAlias("iif(TotalCostImportDuty > 0,Weight,0)")> ReadOnly Property TotalKenaImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDuty"))
      End Get
    End Property
    '<PersistentAlias("iif(KenaImportDuty,TotalIDR,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
    '<PersistentAlias("iif(KenaImportDuty,Weight,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
    <PersistentAlias("iif(TotalCostImportDuty > 0,Weight,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDutyIDR"))
      End Get
    End Property
    '<PersistentAlias("(Total / Main.Total) * Main.TotalCostBukanImportDuty")> ReadOnly Property TotalCostBukanImportDuty As Double
    <PersistentAlias("(Weight / Main.TotalWeight) * Main.TotalCostBukanImportDuty")> ReadOnly Property TotalCostBukanImportDuty As Double
      Get
        'Return (Total / Main.Total) * Main.TotalCostBukanImportDuty
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDuty"))
      End Get
    End Property
    '<PersistentAlias("(TotalIDR / Main.TotalIDR) * Main.TotalCostBukanImportDutyIDR")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
    <PersistentAlias("(Weight / Main.TotalWeight) * Main.TotalCostBukanImportDutyIDR")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
      Get
        'Return (Total / Main.TotalIDR) * Main.TotalCostBukanImportDutyIDR
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDutyIDR"))
      End Get
    End Property
    '<PersistentAlias("iif(KenaImportDuty,(TotalKenaImportDuty / Main.TotalKenaImportDuty) * Main.TotalCostImportDuty,0)")> ReadOnly Property TotalCostImportDuty As Double
    '	Get
    '		'Return (Total / Main.Total) * Main.TotalCostImportDuty
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("iif(KenaImportDuty,(TotalKenaImportDutyIDR / Main.TotalKenaImportDutyIDR) * Main.TotalCostImportDutyIDR,0)")> ReadOnly Property TotalCostImportDutyIDR As Double
    '	Get
    '		'Return (Total / Main.TotalIDR) * Main.TotalCostImportDutyIDR
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
    '	End Get
    'End Property
    <Persistent("TotalCostImportDuty")> Property TotalCostImportDuty As Double
      Get
        Return _totalCostImportDuty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalCostImportDuty", _totalCostImportDuty, value)
      End Set
    End Property
    <PersistentAlias("TotalCostImportDuty * Main.Kurs")> ReadOnly Property TotalCostImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
      End Get
    End Property
  End Class

  <Persistent("m06emaininvoice")> Friend Class Fusoh_InvoicePenjualan
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double

    <Persistent("f_currency")> Property Uang As NuSoft001.Persistent.MataUang
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
  End Class
End Namespace


'ALTER TABLE `m05ddetailinvoicereceipt` ADD COLUMN `TotalCostImportDuty` Decimal(18,4) UNSIGNED Not NULL Default 0 AFTER `d_isimportduty`,CHANGE COLUMN `d_isimportduty` `d_isimportduty` TINYINT(1) UNSIGNED Not NULL Default '0' AFTER `f_proyek`;
