Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m06dmainorder")>
  Friend Class zRexaOrderPenjualan
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _customer As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _kontakalamat As NuSoft001.Persistent.KontakAlamat
    Private _tipe As NuSoft004.Persistent.TipeTransaksi
    Private _tglberlaku As Date
    Private _leadtime As String
    Private _bagpembelian As NuSoft001.Persistent.Kontak
    Private _via As NuSoft005.Persistent.Via
    Private _fob As NuSoft005.Persistent.eTipeFOB
    Private _termin As NuSoft005.Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _uraian As String
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _othercost As Double
    Private _reffnumber As String
    Private _nopenawaran As Persistent.Penawaran
    Private _custom1 As String
    Private _custom2 As String
    Private _custom3 As String
    Private _custom4 As String
    Private _custom5 As String
    Private _periodeawal As Date
    Private _periodeakhir As Date
    Private _gudang As NuSoft004.Persistent.Gudang
    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
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
    <Persistent("f_address")>
    Property KontakAlamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _kontakalamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("KontakAlamat", _kontakalamat, value)
      End Set
    End Property
    <Persistent("f_jenis")>
    Property TipeTransaksi As NuSoft004.Persistent.TipeTransaksi
      Get
        Return _tipe
      End Get
      Set(value As NuSoft004.Persistent.TipeTransaksi)
        SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("TipeTransaksi", _tipe, value)
      End Set
    End Property
    <Persistent("d_efectivedate")>
    Property TanggalBerlaku As Date
      Get
        Return _tglberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of String)("TanggalBerlaku", _tglberlaku, value)
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
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _bagpembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
      End Set
    End Property
    <Persistent("f_via")>
    Property Via As NuSoft005.Persistent.Via
      Get
        Return _via
      End Get
      Set(value As NuSoft005.Persistent.Via)
        SetPropertyValue(Of NuSoft005.Persistent.Via)("Via", _via, value)
      End Set
    End Property
    <Persistent("d_fob")>
    Property FOB As NuSoft005.Persistent.eTipeFOB
      Get
        Return _fob
      End Get
      Set(value As NuSoft005.Persistent.eTipeFOB)
        SetPropertyValue(Of NuSoft005.Persistent.eTipeFOB)("FOB", _fob, value)
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
    <Persistent("d_taxtype")>
    Property TipePajak As NuSoft005.Persistent.eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As NuSoft005.Persistent.eTipePajak)
        SetPropertyValue(Of NuSoft005.Persistent.eTipePajak)("Pajak", _pajak, value)
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
    Property ReffNumber As String
      Get
        Return _reffnumber
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ReffNumber", _reffnumber, value)
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
    <Persistent("d_othercost")>
    Property BiayaLain As Double
      Get
        Return _othercost
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
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
    <Persistent("d_tglperiodeawal")>
    Property PeriodeAwal As Date
      Get
        Return _periodeawal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("PeriodeAwal", _periodeawal, value)
      End Set
    End Property
    <Persistent("d_tglperiodeakhir")>
    Property PeriodeAkhir As Date
      Get
        Return _periodeakhir
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("PeriodeAkhir", _periodeakhir, value)
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
    <PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
      Get
        Return Convert.ToString(EvaluateAlias("Terbilang"))
      End Get
    End Property
    <PersistentAlias("TerbilangEnglish(Total)")> ReadOnly Property TerbilangEnglish As String
      Get
        Return Convert.ToString(EvaluateAlias("TerbilangEnglish"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
      Get
        Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
      End Get
    End Property
    <Association("fk_rexa_order_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of zRexaOrderPenjualanDetail)
      Get
        Return GetCollection(Of zRexaOrderPenjualanDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Order Penjualan [SO]"
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
  <Persistent("m06edetailorder")>
  Friend Class zRexaOrderPenjualanDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.zRexaOrderPenjualan
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
    Private _readystock As Double
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _proyek As NuSoft001.Persistent.Proyek
    Private _idpenawaran As Persistent.PenawaranDetail
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
    <Persistent("p_id"), Association("fk_rexa_order_detail")>
    Property Main As zRexaOrderPenjualan
      Get
        Return _main
      End Get
      Set(value As zRexaOrderPenjualan)
        SetPropertyValue(Of zRexaOrderPenjualan)("Main", _main, value)
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
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
      End Set
    End Property
    <Persistent("f_project")>
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
    <PersistentAlias("(Qty*Harga) - Discount")> ReadOnly Property SubTotal As Double
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
      Dim source As String = "Order Penjualan [SO]"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order penjualan", -99, "", source)
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

  <Persistent("m06emaininvoice")>
  Friend Class zRexaInvoicePenjualan
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _alamat As NuSoft001.Persistent.KontakAlamat
    Private _kontakperson As String
    Private _tipe As NuSoft004.Persistent.TipeTransaksi
    Private _tglberlaku As Date
    Private _termin As NuSoft005.Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _jenispajak As NuSoft005.Persistent.eJenisPajak
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _catatan As String
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    Private _gl As Persistent.GlMain
    Private _nilaidppersen As Double
    Private _taxp As Double
    Private _saldoawal As Double
    Private _periodeawal As Date
    Private _periodeakhir As Date
    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("f_address")>
    Property KontakAlamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _alamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("KontakAlamat", _alamat, value)
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
    <Persistent("f_jenis")>
    Property JenisTransaksi As NuSoft004.Persistent.TipeTransaksi
      Get
        Return _tipe
      End Get
      Set(value As NuSoft004.Persistent.TipeTransaksi)
        SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("JenisTransaksi", _tipe, value)
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
    Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_note")>
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
    <Persistent("d_tglperiodeawal")>
    Property PeriodeAwal As Date
      Get
        Return _periodeawal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("PeriodeAwal", _periodeawal, value)
      End Set
    End Property
    <Persistent("d_tglperiodeakhir")>
    Property PeriodeAkhir As Date
      Get
        Return _periodeakhir
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("PeriodeAkhir", _periodeakhir, value)
      End Set
    End Property
    'property global
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
    <PersistentAlias("(SubTotal + PPN - PPH )")> ReadOnly Property Total As Double
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
    <Association("fk_rexainvoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of zRexaInvoicePenjualanDetail)
      Get
        Return GetCollection(Of zRexaInvoicePenjualanDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Invoice Penjualan [IV]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Customer", -4, "", source)
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
  <Persistent("m06fdetailinvoice")>
  Friend Class zRexaInvoicePenjualanDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.zRexaInvoicePenjualan
    Private _item As NuSoft004.Persistent.Barang
    Private _qty As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _lama As Double
    Private _sewa As String
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _disc As Double
    Private _discp As Double
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _proyek As NuSoft001.Persistent.Proyek
    Private _catatan As String
    Private _idso As Persistent.zRexaOrderPenjualanDetail
    Private _periodeawal As Date
    Private _periodeakhir As Date
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_rexainvoice_detail")>
    Property Main As zRexaInvoicePenjualan
      Get
        Return _main
      End Get
      Set(value As zRexaInvoicePenjualan)
        SetPropertyValue(Of zRexaInvoicePenjualan)("Main", _main, value)
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
    <Persistent("d_lama")>
    Property Lama As Double
      Get
        Return _lama
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Lama", _lama, value)
      End Set
    End Property
    <Persistent("d_sewa")>
    Property Sewa As String
      Get
        Return _sewa
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Sewa", _sewa, value)
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
    <Persistent("f_project")>
    Property Proyek As NuSoft001.Persistent.Proyek
      Get
        Return _proyek
      End Get
      Set(value As NuSoft001.Persistent.Proyek)
        SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
      End Set
    End Property
    <Persistent("f_idso")>
    Property OrderPenjualan As Persistent.zRexaOrderPenjualanDetail
      Get
        Return _idso
      End Get
      Set(value As Persistent.zRexaOrderPenjualanDetail)
        SetPropertyValue(Of Persistent.zRexaOrderPenjualanDetail)("OrderPenjualan", _idso, value)
      End Set
    End Property
    <Persistent("d_tglperiodeawal")>
    Property PeriodeAwal As Date
      Get
        Return _periodeawal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("PeriodeAwal", _periodeawal, value)
      End Set
    End Property
    <Persistent("d_tglperiodeakhir")>
    Property PeriodeAkhir As Date
      Get
        Return _periodeakhir
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("PeriodeAkhir", _periodeakhir, value)
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
    <PersistentAlias("((Qty * Harga)*Lama)")> ReadOnly Property SubTotal As Double
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
        Throw New Utils.Exception("Masukkan data utama Invoice Penjualan", -99, "", source)
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

  <Persistent("m06fmainpayment")>
  Friend Class zRexaPembayaranPiutang
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
    <Persistent("f_customer")>
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
    <Association("fk_rexa_pembayaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of zRexaPembayaranPiutangDetail)
      Get
        Return GetCollection(Of zRexaPembayaranPiutangDetail)("Detail")
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
  <Persistent("m06gdetailpayment")>
  Friend Class zRexaPembayaranPiutangDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.zRexaPembayaranPiutang
    Private _idinvoice As Persistent.zRexaInvoicePenjualan
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
    <Persistent("p_id"), Association("fk_rexa_pembayaran_detail")>
    Property Main As zRexaPembayaranPiutang
      Get
        Return _main
      End Get
      Set(value As zRexaPembayaranPiutang)
        SetPropertyValue(Of zRexaPembayaranPiutang)("Main", _main, value)
      End Set
    End Property
    <Persistent("p_idinvoice")>
    Property NoInvoice As Persistent.zRexaInvoicePenjualan
      Get
        Return _idinvoice
      End Get
      Set(value As Persistent.zRexaInvoicePenjualan)
        SetPropertyValue(Of Persistent.zRexaInvoicePenjualan)("NoInvoice", _idinvoice, value)
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
      NilaiBayar = NilaiBayarCash + NilaiBayarRetur
      MyBase.OnSaving()
    End Sub
  End Class

  'query untuk sisa piutang invoice
  <Persistent("m06vwinvoice")> Friend Class zRexaViewInvoice
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property NoInvoice As zRexaInvoicePenjualan
    Property Urutan As Int64
    Property Terbayar As Double
    Property NilaiBayarCash As Double
    Property Kurs As Double
    Property OK As Boolean
    Property Catatan As String
    Property Pembayaran As zRexaPembayaranPiutangDetail
  End Class
  <Persistent("m06vwaginginvoice")> Friend Class zRexaViewInvoiceUmur
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property p_id As zRexaInvoicePenjualan
    Property NoInvoice As zRexaInvoicePenjualan
    Property d_payment As Double
    Property d_different As Double
    Property d_differentdays As String
  End Class


  <Persistent("m06vwppn")> Friend Class zRexaViewPPN
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property id As Int64
    Property Urutan As Int64
    Property Sumber As NPO.Modules.ModSys.SumberData
    Property InvoicePenjualan As zRexaInvoicePenjualan
    Property InvoicePembelian As zRexaInvoicePenjualan
  End Class

  'stockmain
  <Persistent("m04cstockmain")>
  Friend Class zRexaStockMain
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
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _gudang2 As NuSoft004.Persistent.Gudang
    Private _catatan As String
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _idsalesorder As Persistent.zRexaOrderPenjualan
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _nokendaraan As String
    Private _nosj As String
    Private _supir As String
    Private _gl As Persistent.GlMain
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
    Property Gudang As NuSoft004.Persistent.Gudang
      Get
        Return _gudang
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("f_warehouse2")>
    Property Gudang2 As NuSoft004.Persistent.Gudang
      Get
        Return _gudang2
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang2", _gudang2, value)
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
    <Persistent("f_idso")>
    Property OrderPenjualan As zRexaOrderPenjualan
      Get
        Return _idsalesorder
      End Get
      Set(value As zRexaOrderPenjualan)
        SetPropertyValue(Of zRexaOrderPenjualan)("OrderPenjualan", _idsalesorder, value)
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
    <Persistent("d_nodocument")>
    Property NoSJ As String
      Get
        Return _nosj
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSJ", _nosj, value)
      End Set
    End Property
    <Persistent("d_driver")>
    Property Supir As String
      Get
        Return _supir
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Supir", _supir, value)
      End Set
    End Property
    <Persistent("d_novehicle")>
    Property NoKendaraan As String
      Get
        Return _nokendaraan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoKendaraan", _nokendaraan, value)
      End Set
    End Property
    <Association("fk_rexastock_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of zrexaStockDetail)
      Get
        Return GetCollection(Of zrexaStockDetail)("Detail")
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
    <PersistentAlias("Detail.Sum(QtyIn * HargaIn)")> ReadOnly Property TotalNilaiIN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalNilaiIN"))
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
      If KaryawanKirim Is Nothing Then
        Throw New Utils.Exception("Masukkan Karyawan", -7, "", source)
        Return False
      End If
      If Not Gudang2 Is Nothing Then
        If Gudang2.Id = Gudang.Id Then
          Throw New Utils.Exception("Gudang tujuan tidak boleh sama dengan gudang sumber.", -7, "", source)
          Return False
        End If
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
      'For i = 0 To Detail.Count - 1
      '  Detail(i).Gudang = Gudang
      'Next
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
  Friend Class zRexaStockDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.zRexaStockMain
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _item As NuSoft004.Persistent.Barang
    Private _qtyin As Double
    Private _qtyout As Double
    Private _harga As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _gudang2 As NuSoft004.Persistent.Gudang
    Private _persentase As Double
    Private _catatan As String
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
    <Persistent("p_id"), Association("fk_rexastock_detail")>
    Property Main As zRexaStockMain
      Get
        Return _main
      End Get
      Set(value As zRexaStockMain)
        SetPropertyValue(Of zRexaStockMain)("Main", _main, value)
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
    Property Gudang As NuSoft004.Persistent.Gudang
      Get
        Return _gudang
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("f_warehouse2")>
    Property Gudang2 As NuSoft004.Persistent.Gudang
      Get
        Return _gudang2
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang2", _gudang2, value)
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
    <Persistent("f_proyek")>
    Property Proyek As NuSoft001.Persistent.Proyek
      Get
        Return _proyek
      End Get
      Set(value As NuSoft001.Persistent.Proyek)
        SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
      End Set
    End Property
    <Association("fk_rexastock_detail_hpp"), Aggregated> ReadOnly Property HPPReff As XPCollection(Of zRexaStockDetailHPPReff)
      Get
        Return GetCollection(Of zRexaStockDetailHPPReff)("HPPReff")
      End Get
    End Property
    <PersistentAlias("HPPReff.Sum(NilaiHPP)")> ReadOnly Property NilaiHPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiHPP"))
      End Get
    End Property
    <PersistentAlias("QtyIn * HargaIn")> ReadOnly Property NilaiIN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiIN"))
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
      If QtyIn = 0 And QtyOut = 0 Then
        Throw New Utils.Exception("Masukkan Qty Barang", -99, "", source)
        Return False
      End If
      If Not Session.IsObjectToDelete(Me) Then
        If QtyOut > 0 Then
          If QtyOut > HPPReff.Sum(Function(m) m.Qty) Then
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
  Friend Class zRexaStockDetailHPPReff
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _detail As Persistent.zrexaStockDetail
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
    <Persistent("f_idout"), Association("fk_rexastock_detail_hpp")>
    Property Detail As zrexaStockDetail
      Get
        Return _detail
      End Get
      Set(value As zrexaStockDetail)
        SetPropertyValue(Of zrexaStockDetail)("Main", _detail, value)
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
End Namespace
Namespace Logic
  Friend Class InventorySetting
    Inherits Core.Modules.SettingBase

    Property PreviewSave As Boolean
    Property LockProduksi As Boolean
    Property UraianPermintaan As String
    Property UraianMutasi As String
    Property UraianPenyesuaian As String
    Property UraianStockOpname As String
    Property UraianProduksi As String
    Property SettingCOAAll As Boolean
    Sub New(session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return NuSoft004.MainClass.GetModuleId
    End Function
  End Class
End Namespace