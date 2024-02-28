Imports DevExpress.Xpo
Imports NuSoft.NPO

Namespace Persistent
  <Persistent("m06cmainpib")>
  Friend Class Nishi_PIB
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
    Private _jo As NuSoft004.Persistent.NishiOrderPembelian

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
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _vendor, value)
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
    <Persistent("f_idjo")>
    Property JobOrder As NuSoft004.Persistent.NishiOrderPembelian
      Get
        Return _jo
      End Get
      Set(value As NuSoft004.Persistent.NishiOrderPembelian)
        SetPropertyValue(Of NuSoft004.Persistent.NishiOrderPembelian)("JobOrder", _jo, value)
      End Set
    End Property
    <Association("nishi_fk_pib_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Nishi_PIBDetail)
      Get
        Return GetCollection(Of Nishi_PIBDetail)("Detail")
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
    <NonPersistent()> ReadOnly Property Terbilang As String
      Get
        Return Utils.Common.Character.Terbilang(Total)
      End Get
    End Property
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
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
      End If
      'If _reffnumber Is Nothing Then
      '  Throw New Utils.Exception("Masukkan nomor PIB", -5, "", source)
      '  Return False
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
  <Persistent("m06ddetailpib")>
  Friend Class Nishi_PIBDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Nishi_PIB
    Private _idjo As NuSoft004.Persistent.NishiOrderPembelianDetail
    Private _item As NuSoft004.Persistent.Barang
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
    <Persistent("p_id"), Association("nishi_fk_pib_detail")>
    Property Main As Nishi_PIB
      Get
        Return _main
      End Get
      Set(value As Nishi_PIB)
        SetPropertyValue(Of Nishi_PIB)("Main", _main, value)
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

    <Persistent("f_idjo")>
    Property JobOrder As NuSoft004.Persistent.NishiOrderPembelianDetail
      Get
        Return _idjo
      End Get
      Set(value As NuSoft004.Persistent.NishiOrderPembelianDetail)
        SetPropertyValue(Of NuSoft004.Persistent.NishiOrderPembelianDetail)("JobOrder", _idjo, value)
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

  <Persistent("m05cmaininvoice")>
  Friend Class NishiInvoice
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _tglberlaku As Date
    Private _termin As NuSoft005.Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _jenispajak As NuSoft005.Persistent.eJenisPajak
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    Private _gl As Persistent.GlMain
    Private _coaHutang As NuSoft001.Persistent.Coa
    Private _noreffvendor As String
    Private _nilaisaldoawal As Double
    Private _jobno As NuSoft004.Persistent.NishiOrderPembelian
    Private _jenisInvoice As NuSoft004.Persistent.NishiJenisInvoice
    Private _administrasi As Double
    <Persistent("f_idjo")>
    Property JobOrder As NuSoft004.Persistent.NishiOrderPembelian
      Get
        Return _jobno
      End Get
      Set(value As NuSoft004.Persistent.NishiOrderPembelian)
        SetPropertyValue(Of NuSoft004.Persistent.NishiOrderPembelian)("JobOrder", _jobno, value)
      End Set
    End Property
    <Persistent("d_jenisinvoice")>
    Property JenisInvoice As NuSoft004.Persistent.NishiJenisInvoice
      Get
        Return _jenisInvoice
      End Get
      Set(value As NuSoft004.Persistent.NishiJenisInvoice)
        SetPropertyValue(Of NuSoft004.Persistent.NishiJenisInvoice)("JenisInvoice", _jenisInvoice, value)
      End Set
    End Property
    <Persistent("f_vendor")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
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
    Property Termin As NuSoft005.Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As NuSoft005.Persistent.Termin)
        SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
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
    Property JenisPajak As NuSoft005.Persistent.eJenisPajak
      Get
        Return _jenispajak
      End Get
      Set(value As NuSoft005.Persistent.eJenisPajak)
        SetPropertyValue(Of NuSoft005.Persistent.eJenisPajak)("JenisPajak", _jenispajak, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As NuSoft005.Persistent.eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As NuSoft005.Persistent.eTipePajak)
        SetPropertyValue(Of NuSoft005.Persistent.eTipePajak)("TipePajak", _pajak, value)
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
    <Persistent("d_administrasi")>
    Property BiayaAdministrasi As Double
      Get
        Return _administrasi
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaAdministrasi", _administrasi, value)
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
    'property untuk saldo awal hutang
    <Persistent("d_bbvalue")>
    Property NilaiSaldoAwal As Double
      Get
        Return _nilaisaldoawal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiSaldoAwal", _nilaisaldoawal, value)
      End Set
    End Property 'NilaiInvoice
    <NonPersistent()> ReadOnly Property NilaiInvoice As Double
      Get
        Return Total
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

    <Association("fk_nishiinvoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of NishiInvoiceDetail)
      Get
        Return GetCollection(Of NishiInvoiceDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPNv)")> ReadOnly Property PPN As Double
      Get
        Return Math.Round(Convert.ToDouble(EvaluateAlias("PPN")), 0)
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPHv)")> ReadOnly Property PPH As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPH"))
      End Get
    End Property
    <PersistentAlias("(SubTotal + PPN - PPH + BiayaAdministrasi)")> ReadOnly Property Total As Double
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
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Pelanggan", -4, "", source)
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
  End Class
  <Persistent("m05ddetailinvoice")>
  Friend Class NishiInvoiceDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.NishiInvoice
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
    Private _catatan As String
    Private _hari As Double
    Private _sj As NuSoft004.Persistent.NishiStockMain
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_nishiinvoice_detail")>
    Property Main As NishiInvoice
      Get
        Return _main
      End Get
      Set(value As NishiInvoice)
        SetPropertyValue(Of NishiInvoice)("Main", _main, value)
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
    <Persistent("d_hari")>
    Property Hari As Double
      Get
        Return _hari
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Hari", _hari, value)
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
    <PersistentAlias("(Qty * Harga * Hari)")> ReadOnly Property SubTotal As Double
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
    <Persistent("f_sj")>
    Property SuratJalan As NuSoft004.Persistent.NishiStockMain
      Get
        Return _sj
      End Get
      Set(value As NuSoft004.Persistent.NishiStockMain)
        SetPropertyValue(Of NuSoft004.Persistent.NishiStockMain)("SuratJalan", _sj, value)
      End Set
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

  <Persistent("m05cmainpayment")>
  Friend Class NishiPembayaranPiutang
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _customer As NuSoft001.Persistent.Kontak
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
    <Persistent("f_kontak")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
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
    <Association("fk_nishipembayaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of NishiPembayaranPiutangDetail)
      Get
        Return GetCollection(Of NishiPembayaranPiutangDetail)("Detail")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property SelisihKurs As Double
      Get
        Return Detail.Sum(Function(m) m.NilaiBayar * m.NoInvoice.Kurs) - Detail.Sum(Function(m) m.NilaiBayar * m.Kurs)
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Pembayaran Piutang [CP]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
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
  Friend Class NishiPembayaranPiutangDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.NishiPembayaranPiutang
    Private _idinvoice As Persistent.NishiInvoice
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
    <Persistent("p_id"), Association("fk_nishipembayaran_detail")>
    Property Main As NishiPembayaranPiutang
      Get
        Return _main
      End Get
      Set(value As NishiPembayaranPiutang)
        SetPropertyValue(Of NishiPembayaranPiutang)("Main", _main, value)
      End Set
    End Property
    <Persistent("p_idinvoice")>
    Property NoInvoice As Persistent.NishiInvoice
      Get
        Return _idinvoice
      End Get
      Set(value As Persistent.NishiInvoice)
        SetPropertyValue(Of Persistent.NishiInvoice)("NoInvoice", _idinvoice, value)
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
        Throw New Utils.Exception("Masukkan data utama pembayaran piutang", -99, "", source)
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
      NilaiBayar = NilaiBayarCash
      MyBase.OnSaving()
    End Sub
  End Class

  <Persistent("m06cmainquotation")>
  Friend Class NishiQuotation
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _tglberlaku As Date
    Private _termin As NuSoft005.Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _jenispajak As NuSoft005.Persistent.eJenisPajak
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    Private _jenisInvoice As NuSoft004.Persistent.NishiJenisInvoice
    Private _administrasi As Double
    <Persistent("d_jenisinvoice")>
    Property JenisInvoice As NuSoft004.Persistent.NishiJenisInvoice
      Get
        Return _jenisInvoice
      End Get
      Set(value As NuSoft004.Persistent.NishiJenisInvoice)
        SetPropertyValue(Of NuSoft004.Persistent.NishiJenisInvoice)("JenisInvoice", _jenisInvoice, value)
      End Set
    End Property
    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
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
    Property Termin As NuSoft005.Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As NuSoft005.Persistent.Termin)
        SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
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
    Property JenisPajak As NuSoft005.Persistent.eJenisPajak
      Get
        Return _jenispajak
      End Get
      Set(value As NuSoft005.Persistent.eJenisPajak)
        SetPropertyValue(Of NuSoft005.Persistent.eJenisPajak)("JenisPajak", _jenispajak, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As NuSoft005.Persistent.eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As NuSoft005.Persistent.eTipePajak)
        SetPropertyValue(Of NuSoft005.Persistent.eTipePajak)("TipePajak", _pajak, value)
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
    <Persistent("d_administrasi")>
    Property BiayaAdministrasi As Double
      Get
        Return _administrasi
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaAdministrasi", _administrasi, value)
      End Set
    End Property

    <Association("fk_nishiquotation_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of NishiQuotationDetail)
      Get
        Return GetCollection(Of NishiQuotationDetail)("Detail")
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
    <PersistentAlias("(SubTotal + PPN - PPH + BiayaAdministrasi)")> ReadOnly Property Total As Double
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
      Dim source As String = "Quotation [RI]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Pelanggan", -4, "", source)
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
  End Class
  <Persistent("m06ddetailquotation")>
  Friend Class NishiQuotationDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.NishiQuotation
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
    Private _catatan As String
    Private _hari As Double
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_nishiquotation_detail")>
    Property Main As NishiQuotation
      Get
        Return _main
      End Get
      Set(value As NishiQuotation)
        SetPropertyValue(Of NishiQuotation)("Main", _main, value)
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
    <Persistent("d_hari")>
    Property Hari As Double
      Get
        Return _hari
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Hari", _hari, value)
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


  'query untuk sisa piutang invoice
  <Persistent("m05vwinvoice")> Friend Class NishiViewInvoice
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property NoInvoice As NishiInvoice
    Property Urutan As Int64
    Property Terbayar As Double
    Property NilaiBayarCash As Double
    Property Kurs As Double
    Property OK As Boolean
    Property Catatan As String
    Property Pembayaran As NishiPembayaranPiutangDetail
  End Class
  <Persistent("m05vwjoborder")> Friend Class NishiVwJobOrder
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property id As Int64
    Property jo As NuSoft004.Persistent.NishiOrderPembelian
    Property invno As String
    Property invtanggal As String
  End Class
End Namespace