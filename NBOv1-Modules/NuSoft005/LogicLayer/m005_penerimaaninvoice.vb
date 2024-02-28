Imports DevExpress.Xpo
Imports NuSoft.NPO

Namespace Persistent
  <Persistent("m05cmaininvoicereceipt")>
  Friend Class PenerimaanInvoice
    Inherits Persistent.TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

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
    Private _noorder As Persistent.OrderPembelian
    Private _gl As Persistent.GlMain
    Private _nilaidppersen As Double
    Private _nilaisaldoawal As Double
    Private _taxp As Double
    Private _coaHutang As NuSoft001.Persistent.Coa
    Private _noreffvendor As String

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
    <Persistent("f_coahutang")> Property CoaHutang As NuSoft001.Persistent.Coa
      Get
        Return _coaHutang
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaHutang", _coaHutang, value)
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
    <NonPersistent()> ReadOnly Property SelisihKursDP As Double
      Get
        Return (DetailDP.Sum(Function(m) m.NilaiDP) * Kurs) - DetailDP.Sum(Function(m) m.NilaiDP * m.DP.Kurs)
      End Get
    End Property
    <NonPersistent()> ReadOnly Property SelisihKurs As Double
      Get
        Return Detail.Sum(Function(m) m.PenerimaanBarang.SubTotal) - Detail.Sum(Function(m) m.DPP)
      End Get
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
    Property NoOrder As Persistent.OrderPembelian
      Get
        Return _noorder
      End Get
      Set(value As Persistent.OrderPembelian)
        SetPropertyValue(Of Persistent.OrderPembelian)("NoOrder", _noorder, value)
      End Set
    End Property

    'property untuk DP
    <Persistent("d_dppersen")>
    Property NilaiDPpersen As Double
      Get
        Return _nilaidppersen
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiDPpersen", _nilaidppersen, value)
      End Set
    End Property
    <Persistent("d_dptaxp")>
    Property PajakPersen As Double
      Get
        Return _taxp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PajakPersen", _taxp, value)
      End Set
    End Property
    <NonPersistent()> ReadOnly Property DPValue As Double
      Get
        Return (NilaiDPpersen / 100 * NoOrder.SubTotal)
      End Get
    End Property
    <NonPersistent()> ReadOnly Property PPNValue As Double
      Get
        Return (PajakPersen / 100 * DPValue)
      End Get
    End Property
    <NonPersistent()> ReadOnly Property NilaiInvoiceDP As Double
      Get
        Return DPValue + PPNValue
      End Get
    End Property

    'property untuk saldo awal hutang
    <Persistent("d_bbvalue")>
    Property NilaiSaldoAwal As Double
      Get
        Return _nilaisaldoawal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiSaldoAwal", _nilaisaldoawal, value)
      End Set
    End Property


    'property global
    <NonPersistent()> ReadOnly Property NilaiInvoice As Double
      Get
        If Sumber.Id = Persistent.SumberDataJenis.AP Then
          Return NilaiInvoiceDP
        ElseIf Sumber.Id = Persistent.SumberDataJenis.BP Then
          Return NilaiSaldoAwal
        Else
          Return Total
        End If
      End Get
    End Property
    <PersistentAlias("iif(Kurs = 1,0,NilaiInvoice)")> ReadOnly Property NilaiInvoiceValas As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiInvoiceValas"))
      End Get
    End Property
    <PersistentAlias("NilaiInvoice*Kurs")> ReadOnly Property NilaiInvoiceFungsional As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiInvoiceFungsional"))
      End Get
    End Property

    <Association("fk_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PenerimaanInvoiceDetail)
      Get
        Return GetCollection(Of PenerimaanInvoiceDetail)("Detail")
      End Get
    End Property
    <Association("fk_invoice_dp"), Aggregated> ReadOnly Property DetailDP As XPCollection(Of PenerimaanInvoiceDP)
      Get
        Return GetCollection(Of PenerimaanInvoiceDP)("DetailDP")
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
    <PersistentAlias("DetailDP.Sum(NilaiDP+NilaiPajak)")> ReadOnly Property NilaiDP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiDP"))
      End Get
    End Property
    <PersistentAlias("DetailDP.Sum(NilaiPajak)")> ReadOnly Property NilaiDPPajak As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiDPPajak"))
      End Get
    End Property
    <PersistentAlias("(SubTotal + PPN - PPH - NilaiDP)")> ReadOnly Property Total As Double
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

      If Uang.Id <> Uang.HutangDagang.MataUang.Id Then
        Throw New Utils.Exception("Mata uang untuk coa [Hutang Dagang] tidak sama dengan mata uang transaksi", -7, "", source)
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

    'custom 04-03-2023
    <Association("fk_invoice_pembayaranhutang")> ReadOnly Property DaftarPembayaran As XPCollection(Of PembayaranHutangDetail)
      Get
        Return GetCollection(Of PembayaranHutangDetail)(NameOf(DaftarPembayaran))
      End Get
    End Property
    <PersistentAlias(NameOf(DaftarPembayaran) & ".Sum(" & NameOf(PembayaranHutangDetail.NilaiBayar) & ")")> ReadOnly Property JumlahPembayaran As Double
      Get
        Return Convert.ToDouble(EvaluateAlias(NameOf(JumlahPembayaran)))
      End Get
    End Property
    <PersistentAlias(NameOf(PersistentAliasNilaiInvoice) & " - " & NameOf(JumlahPembayaran))> ReadOnly Property SisaHutang As Double
      Get
        Return Convert.ToDouble(EvaluateAlias(NameOf(SisaHutang)))
      End Get
    End Property

    <PersistentAlias("(" & NameOf(NilaiDPpersen) & " / 100) * " & NameOf(NoOrder) & "." & NameOf(OrderPembelian.SubTotal))> ReadOnly Property PersistentAliasDPValue As Double
      Get
        Return Convert.ToDouble(EvaluateAlias(NameOf(PersistentAliasDPValue)))
      End Get
    End Property
    <PersistentAlias("(" & NameOf(PajakPersen) & " / 100) * " & NameOf(PersistentAliasDPValue))> ReadOnly Property PersistentAliasPPNValue As Double
      Get
        Return Convert.ToDouble(EvaluateAlias(NameOf(PersistentAliasPPNValue)))
      End Get
    End Property
    <PersistentAlias(NameOf(PersistentAliasDPValue) & " + " & NameOf(PersistentAliasPPNValue))> ReadOnly Property PersistentAliasNilaiInvoiceDP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias(NameOf(PersistentAliasNilaiInvoiceDP)))
      End Get
    End Property

    <PersistentAlias("Iif(Sumber.Id = 21, " & NameOf(PersistentAliasNilaiInvoiceDP) & ",Iif(Sumber.Id = 37," & NameOf(NilaiSaldoAwal) & "," & NameOf(Total) & "))")> ReadOnly Property PersistentAliasNilaiInvoice As Double
      Get
        Return Convert.ToDouble(EvaluateAlias(NameOf(PersistentAliasNilaiInvoice)))
      End Get
    End Property
  End Class
  <Persistent("m05ddetailinvoicereceipt")>
  Friend Class PenerimaanInvoiceDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.PenerimaanInvoice
    Private _item As NuSoft004.Persistent.Barang
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
    Private _idgr As Persistent.PenerimaanBarangDetail
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
    <Persistent("p_id"), Association("fk_invoice_detail")>
    Property Main As PenerimaanInvoice
      Get
        Return _main
      End Get
      Set(value As PenerimaanInvoice)
        SetPropertyValue(Of PenerimaanInvoice)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Barang)("Barang", _item, value)
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
    Property PenerimaanBarang As Persistent.PenerimaanBarangDetail
      Get
        Return _idgr
      End Get
      Set(value As Persistent.PenerimaanBarangDetail)
        SetPropertyValue(Of Persistent.PenerimaanBarangDetail)("PenerimaanBarang", _idgr, value)
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
    '<PersistentAlias("iif(Main.TipePajak = 1,((Qty * Harga) + PPNv - PPHv), Qty * Harga)")> ReadOnly Property Total As Double
    <PersistentAlias("iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
      '<PersistentAlias("iif(Main.TipePajak = 2,(Qty * Harga) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (Qty * Harga)),Qty * Harga)")> ReadOnly Property DPP As Double
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
  <Persistent("m05ddetailinvoicereceiptdp")>
  Friend Class PenerimaanInvoiceDP
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.PenerimaanInvoice
    Private _dp As Persistent.DPPembelian
    Private _dpnilai As Double
    Private _dpnilaipajak As Double
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_invoice_dp")>
    Property Main As PenerimaanInvoice
      Get
        Return _main
      End Get
      Set(value As PenerimaanInvoice)
        SetPropertyValue(Of PenerimaanInvoice)("Main", _main, value)
      End Set
    End Property
    <Persistent("p_iddp")>
    Property DP As Persistent.DPPembelian
      Get
        Return _dp
      End Get
      Set(value As Persistent.DPPembelian)
        SetPropertyValue(Of Persistent.DPPembelian)("DP", _dp, value)
      End Set
    End Property
    <Persistent("d_value")>
    Property NilaiDP As Double
      Get
        Return _dpnilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiDP", _dpnilai, value)
      End Set
    End Property
    <Persistent("d_valuetax")>
    Property NilaiPajak As Double
      Get
        Return _dpnilaipajak
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiPajak", _dpnilaipajak, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
        Return False
      End If
      If _dpnilai = Nothing Then
        Throw New Utils.Exception("Masukkan Nilai DP", -99, "", source)
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

  <Persistent("m05vwaginginvoice")> Friend Class ViewInvoiceUmur
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property NoInvoice As PenerimaanInvoice
    Property p_id As PenerimaanInvoice
    Property d_payment As Double
    Property d_different As Double
    Property d_differentdays As String
  End Class

  <Persistent("m05vwinvoiceppn")> Public Class ViewInvoicePPN
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property Sumber As Long
    Property Tanggal As Date
    Property Kontak As NuSoft001.Persistent.Kontak
    Property NoBukti As String
    Property Uraian As String
    Property DPP As Double
    Property NilaiPajak As Double
    Property NoFakturPajak As String
  End Class

  <NonPersistent>
  Public Class prSaldoHutang
    Inherits XPLiteObject
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Persistent("Id"), Key> Property Id As Int64
    <Persistent("Terbayar")> Property Nama As String
  End Class
  <NonPersistent> Friend Class NonViewRincianHutang
    Inherits XPLiteObject

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub

    <Key> Property Invoice As PenerimaanInvoice
    Property JumlahBayar As Double
    ReadOnly Property SisaHutang As Double
      Get
        Return Math.Round(Invoice.NilaiInvoice - JumlahBayar, 2)
      End Get
    End Property
  End Class
End Namespace

Namespace Global_Services
  Friend Class PenerimaanInvoice_Services
    Friend Shared Function GetRincianHutang(session As UnitOfWork, perTanggal As Date, regional As NPO.Modules.ModSys.Regional, kontak As NuSoft001.Persistent.Kontak, mataUang As NuSoft001.Persistent.MataUang, tampilkanSaldo0 As Boolean) As List(Of Persistent.NonViewRincianHutang)
      Dim sqlJumlahBayar = "select sum(d_amount) from m05ddetailpayment det left join m05cmainpayment main on det.p_id=main.p_id where main.d_date <= '{0}' and det.p_idinvoice=c.p_id"
      Dim sql = "select cast(p_id as signed) as Invoice,cast(({1}) as double) as JumlahBayar from m05cmaininvoicereceipt c where d_date <= '{0}'"
      If Not regional Is Nothing Then
        sql &= " and u_regional = " & regional.Id
      End If
      If Not kontak Is Nothing Then
        sql &= " and f_vendor = " & kontak.Id
      End If
      If Not mataUang Is Nothing Then
        sql &= " and f_currency = " & mataUang.Id
      End If

      sql = sql.Replace("{1}", sqlJumlahBayar)
      Dim sqlExecute = String.Format(sql, perTanggal.ToString("yyyy-MM-dd"))
      Dim xdata = session.GetObjectsFromQuery(Of Persistent.NonViewRincianHutang)(sqlExecute).ToList()
      If tampilkanSaldo0 Then
        Return xdata
      Else
        Return xdata.Where(Function(w) w.SisaHutang > 0).ToList
      End If
    End Function
  End Class
End Namespace