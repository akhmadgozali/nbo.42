Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent

Namespace Persistent_Fusoh
  <Persistent("m05cmaininvoicereceipt")> Friend Class Persistent_FusohInvoicePembelian
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
    Private _noorder As Persistent_FusohOrderPembelian
    Private _noexim As Persistent_FusohExim
    Private _noparent As Persistent_FusohInvoicePembelian
    Private _nilaisaldoawal As Double
    Private _noreffvendor As String

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

    <Persistent("p_idorder")> Property NoOrder As Persistent_FusohOrderPembelian
      Get
        Return _noorder
      End Get
      Set(value As Persistent_FusohOrderPembelian)
        SetPropertyValue(Of Persistent_FusohOrderPembelian)("NoOrder", _noorder, value)
      End Set
    End Property
    <Persistent("p_idexim")> Property NoExim As Persistent_FusohExim
      Get
        Return _noexim
      End Get
      Set(value As Persistent_FusohExim)
        SetPropertyValue(Of Persistent_FusohExim)("NoExim", _noexim, value)
      End Set
    End Property
    <Persistent("p_idparent"), Association("Persistent_FusohInvoicePembelian_Induk")> Property IndukInvoice As Persistent_FusohInvoicePembelian
      Get
        Return _noparent
      End Get
      Set(value As Persistent_FusohInvoicePembelian)
        SetPropertyValue(Of Persistent_FusohInvoicePembelian)("IndukInvoice", _noparent, value)
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

    <Association("Persistent_FusohInvoicePembelian_Detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Persistent_FusohInvoicePembelianDetail)
      Get
        Return GetCollection(Of Persistent_FusohInvoicePembelianDetail)("Detail")
      End Get
    End Property
    <Association("Persistent_FusohInvoicePembelian_Induk"), Aggregated> ReadOnly Property DetailCost As XPCollection(Of Persistent_FusohInvoicePembelian)
      Get
        Return GetCollection(Of Persistent_FusohInvoicePembelian)("DetailCost")
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
    <PersistentAlias("TotalIDR + TotalCostIDR")> ReadOnly Property TotalPembelianIDR As Double
      Get
        'Return Total + TotalCost
        Return Convert.ToDouble(EvaluateAlias("TotalPembelianIDR"))
      End Get
    End Property

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

    <NonPersistent()> Property DetailForSave As List(Of Persistent_FusohInvoicePembelianDetail_ForSave)
  End Class
  <Persistent("m05ddetailinvoicereceipt")> Friend Class Persistent_FusohInvoicePembelianDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Persistent_FusohInvoicePembelian
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _qty As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _disc As Double
    Private _discp As Double
    Private _catatan As String
    Private _idpo As Persistent_FusohOrderPembelianDetail
    Private _idexim As Persistent_FusohEximDetail
    Private _kenaImportDuty As Boolean
    Private _totalCostImportDuty As Double

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("Persistent_FusohInvoicePembelian_Detail")> Property Main As Persistent_FusohInvoicePembelian
      Get
        Return _main
      End Get
      Set(value As Persistent_FusohInvoicePembelian)
        SetPropertyValue(Of Persistent_FusohInvoicePembelian)("Main", _main, value)
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
    <Persistent("f_idpo")> Property PODetail As Persistent_FusohOrderPembelianDetail
      Get
        Return _idpo
      End Get
      Set(value As Persistent_FusohOrderPembelianDetail)
        SetPropertyValue(Of Persistent_FusohOrderPembelianDetail)("PODetail", _idpo, value)
      End Set
    End Property
    <Persistent("f_idexim")> Property EximDetail As Persistent_FusohEximDetail
      Get
        Return _idexim
      End Get
      Set(value As Persistent_FusohEximDetail)
        SetPropertyValue(Of Persistent_FusohEximDetail)("EximDetail", _idexim, value)
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

    <PersistentAlias("EximDetail.Weight")> ReadOnly Property Weight As Decimal
      Get
        Return Convert.ToDecimal(EvaluateAlias("Weight"))
      End Get
    End Property

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
    <PersistentAlias("iif(TotalCostImportDuty > 0,Weight,0)")> ReadOnly Property TotalKenaImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDuty"))
      End Get
    End Property
    <PersistentAlias("iif(TotalCostImportDuty > 0,Weight,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("(Weight / Main.TotalWeight) * Main.TotalCostBukanImportDuty")> ReadOnly Property TotalCostBukanImportDuty As Double
      Get
        'Return (Total / Main.Total) * Main.TotalCostBukanImportDuty
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDuty"))
      End Get
    End Property
    <PersistentAlias("(Weight / Main.TotalWeight) * Main.TotalCostBukanImportDutyIDR")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
      Get
        'Return (Total / Main.TotalIDR) * Main.TotalCostBukanImportDutyIDR
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDutyIDR"))
      End Get
    End Property
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
  End Class

  Friend Class Persistent_FusohInvoicePembelianDetail_ForSave
    Property Id As Int64
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
    Property Satuan As NuSoft004.Persistent.Satuan
    Property Qty As Double
    Property Harga As Double
    Property Discount As Double
    Property DiscountPersen As Double
    Property PPN As NuSoft004.Persistent.Pajak
    Property PPNp As Double
    Property PPH As NuSoft004.Persistent.Pajak
    Property PPHp As Double
    Property Catatan As String
    Property PODetail As Persistent_FusohOrderPembelianDetail
    Property EximDetail As Persistent_FusohEximDetail
    Property KenaImportDuty As Boolean
  End Class
End Namespace