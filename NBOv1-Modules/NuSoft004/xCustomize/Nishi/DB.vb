Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.Utils.CustomAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  Public Enum NishiJenisJO
    <EnumDescription("Ekspor")> Ekspor = 0
    <EnumDescription("Impor")> Impor = 1
  End Enum
  Public Enum NishiTipeBarangJO
    <EnumDescription("Coil")> Coil = 0
    <EnumDescription("Steel")> Steel = 1
    <EnumDescription("Other")> Other = 2
  End Enum
  Public Enum NishiJenisInvoice
    <EnumDescription("Invoice Dokumen")> Dok = 0
    <EnumDescription("Invoice Sewa Gudang")> Gudang = 1
    <EnumDescription("Invoice Trucking")> Truck = 2
  End Enum

  <Persistent("m04bitem")>
  Public Class Nishi_Barang
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub
    Private Function CheckData() As Boolean
      Const sumber As String = "Master Item"
      If _Kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -1, "", sumber)
        Return False
      End If
      If _Nama Is Nothing Then
        Throw New Utils.Exception("Masukkan nama barang", -2, "", sumber)
        Return False
      End If
      If _UOM Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan", -3, "", sumber)
        Return False
      End If
      If _UOMD Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan dasar", -4, "", sumber)
        Return False
      End If
      If _Currrency Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -5, "", sumber)
        Return False
      End If
      If _CoaStock Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Persediaan", -7, "", sumber)
        Return False
      End If
      If _CoaIncome Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Pendapatan", -8, "", sumber)
        Return False
      End If
      If _CoaCost Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Biaya [HPP]", -9, "", sumber)
        Return False
      End If
      If _PajakIn Is Nothing Then
        Throw New Utils.Exception("Masukkan Pajak Masukan", -10, "", sumber)
        Return False
      End If
      If _PajakOut Is Nothing Then
        Throw New Utils.Exception("Masukkan Pajak Keluaran", -11, "", sumber)
        Return False
      End If
      Return True
    End Function

    <Indexed("Kode", Unique:=True)>
    Private _Id As Int64
    Private _Kode As String
    Private _Nama As String
    Private _Jenis As JenisBarang
    Private _Tipe As TipeBarang
    Private _UOM As Satuan
    Private _UOMD As Satuan
    Private _Currrency As NuSoft001.Persistent.MataUang
    Private _Currency2 As NPO.Modules.ModSys.Divisi
    Private _HargaBeli As Double
    Private _HargaJual1 As Double
    Private _HargaJual2 As Double
    Private _HargaJual3 As Double
    Private _HargaJual4 As Double
    Private _HargaJual5 As Double
    Private _PajakIn As Pajak
    Private _PajakOut As Pajak
    Private _CoaIncome As NuSoft001.Persistent.Coa
    Private _CoaCost As NuSoft001.Persistent.Coa
    Private _CoaStock As NuSoft001.Persistent.Coa
    Private _CoaDiscIn As NuSoft001.Persistent.Coa
    Private _CoaDiscOut As NuSoft001.Persistent.Coa
    Private _CoaReturIn As NuSoft001.Persistent.Coa
    Private _CoaReturOut As NuSoft001.Persistent.Coa
    Private _StockMax As Double
    Private _StockMin As Double
    Private _StockCurrent As Double
    Private _active As Boolean
    Private _stockorder As Double
    Private _kategori As Kategori
    Private _subkategori As SubKategori
    Private _merk As Merk
    Private _note As String

    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _Id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _Kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _Kode, value)
      End Set
    End Property
    <Persistent("d_name")> Property Nama As String
      Get
        Return _Nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _Nama, value)
      End Set
    End Property
    <Persistent("f_uom")> Property Satuan As Satuan
      Get
        Return _UOM
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _UOM, value)
      End Set
    End Property
    <Persistent("f_uomd")> Property SatuanD As Satuan
      Get
        Return _UOMD
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("SatuanD", _UOMD, value)
      End Set
    End Property
    <Persistent("d_jenis")> Property Jenis As JenisBarang
      Get
        Return _Jenis
      End Get
      Set(value As JenisBarang)
        SetPropertyValue(Of JenisBarang)("Jenis", _Jenis, value)
      End Set
    End Property
    <Persistent("d_tipe")> Property TipeBarang As TipeBarang
      Get
        Return _Tipe
      End Get
      Set(value As TipeBarang)
        SetPropertyValue(Of TipeBarang)("Jenis", _Tipe, value)
      End Set
    End Property
    <Persistent("f_curency")> Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _Currrency
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _Currrency, value)
      End Set
    End Property
    <Persistent("d_pricelastpurchase")> Property LastPurchase As Double
      Get
        Return _HargaBeli
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("LastPurchase", _HargaBeli, value)
      End Set
    End Property
    <Persistent("d_priceselling1")> Property HargaJual1 As Double
      Get
        Return _HargaJual1
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual1", _HargaJual1, value)
      End Set
    End Property
    <Persistent("d_priceselling2")> Property HargaJual2 As Double
      Get
        Return _HargaJual2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual2", _HargaJual2, value)
      End Set
    End Property
    <Persistent("d_priceselling3")> Property HargaJual3 As Double
      Get
        Return _HargaJual3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual3", _HargaJual3, value)
      End Set
    End Property
    <Persistent("d_priceselling4")> Property HargaJual4 As Double
      Get
        Return _HargaJual4
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual4", _HargaJual4, value)
      End Set
    End Property
    <Persistent("d_priceselling5")> Property HargaJual5 As Double
      Get
        Return _HargaJual5
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual5", _HargaJual5, value)
      End Set
    End Property
    <Persistent("f_taxin")> Property PajakIN As Pajak
      Get
        Return _PajakIn
      End Get
      Set(value As Pajak)
        SetPropertyValue(Of Pajak)("PajakIN", _PajakIn, value)
      End Set
    End Property
    <Persistent("f_taxout")> Property PajakOUT As Pajak
      Get
        Return _PajakOut
      End Get
      Set(value As Pajak)
        SetPropertyValue(Of Pajak)("PajakOUT", _PajakOut, value)
      End Set
    End Property
    <Persistent("f_coaincome")> Property CoaIncome As NuSoft001.Persistent.Coa
      Get
        Return _CoaIncome
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaIncome", _CoaIncome, value)
      End Set
    End Property
    <Persistent("f_coacost")> Property CoaCost As NuSoft001.Persistent.Coa
      Get
        Return _CoaCost
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaCost", _CoaCost, value)
      End Set
    End Property
    <Persistent("f_coastock")> Property CoaStock As NuSoft001.Persistent.Coa
      Get
        Return _CoaStock
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaStock", _CoaStock, value)
      End Set
    End Property
    <Persistent("f_coadiscincome")> Property CoaDiscIncome As NuSoft001.Persistent.Coa
      Get
        Return _CoaDiscIn
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaDiscIncome", _CoaDiscIn, value)
      End Set
    End Property
    <Persistent("f_coadisccost")> Property CoaDiscOut As NuSoft001.Persistent.Coa
      Get
        Return _CoaDiscOut
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaDiscOut", _CoaDiscOut, value)
      End Set
    End Property
    <Persistent("f_coareturnincome")> Property CoaReturnIn As NuSoft001.Persistent.Coa
      Get
        Return _CoaReturIn
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaReturnIn", _CoaReturIn, value)
      End Set
    End Property
    <Persistent("f_coareturncost")> Property CoaReturnOut As NuSoft001.Persistent.Coa
      Get
        Return _CoaReturOut
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaReturnOut", _CoaReturOut, value)
      End Set
    End Property
    <Persistent("d_stockmax")> Property StockMax As Double
      Get
        Return _StockMax
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockMax", _StockMax, value)
      End Set
    End Property
    <Persistent("d_stockmin")> Property StockMin As Double
      Get
        Return _StockMin
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockMin", _StockMin, value)
      End Set
    End Property
    <Persistent("d_stockcurrent")> Property StockCurrent As Double
      Get
        Return _StockCurrent
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockCurrent", _StockCurrent, value)
      End Set
    End Property
    <Persistent("d_aktif")> Property Aktif As Boolean
      Get
        Return _active
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Aktif", _active, value)
      End Set
    End Property
    <Persistent("d_stokreorder")> Property StockOrder As Double
      Get
        Return _stockorder
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockOrder", _stockorder, value)
      End Set
    End Property
    <Persistent("f_kategori")> Property Kategori As Kategori
      Get
        Return _kategori
      End Get
      Set(value As Kategori)
        SetPropertyValue(Of Kategori)("Kategori", _kategori, value)
      End Set
    End Property
    <Persistent("f_subkategori")> Property SubKategori As SubKategori
      Get
        Return _subkategori
      End Get
      Set(value As SubKategori)
        SetPropertyValue(Of SubKategori)("SubKategori", _subkategori, value)
      End Set
    End Property
    <Persistent("f_merk")> Property Merk As Merk
      Get
        Return _merk
      End Get
      Set(value As Merk)
        SetPropertyValue(Of Merk)("Merk", _merk, value)
      End Set
    End Property
    <Persistent("d_note")> Property Note As String
      Get
        Return _note
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Note", _note, value)
      End Set
    End Property
  End Class



  <Persistent("m05cmainorder")>
  Public Class NishiOrderPembelian
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
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _tglberlaku As Date
    Private _leadtime As String
    Private _bagpembelian As NuSoft001.Persistent.Kontak
    Private _fob As Persistent.eTipeFOB
    Private _termin As Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _pajak As Persistent.eTipePajak
    Private _catatan As String
    Private _catatanapp As String
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _disc As Double
    Private _kurs As Double
    Private _othercost As Double
    Private _reffnumber As String
    Private _proyek As NuSoft001.Persistent.Proyek
    Private _jenisJO As NishiJenisJO
    Private _d_blno As String
    Private _d_shipper As String
    Private _d_consignee As String
    Private _d_email As Date
    Private _d_ajouno As String
    Private _d_invono As String
    Private _d_invdate As Date
    Private _d_packingno As String
    Private _d_packingdate As Date
    Private _d_vessel As String
    Private _d_nw As Double
    Private _d_gw As Double
    Private _d_meass As String
    Private _d_party As String
    Private _d_draftpib As Date
    Private _d_billing As Date
    Private _d_bpn As Date
    Private _d_delivery As Date
    Private _d_etd As Date
    Private _d_eta As Date
    Private _d_shippinginstruction As String
    Private _d_npeno As String
    Private _d_pebno As String
    Private _d_coo As Date
    Private _d_pickup As Date
    Private _d_insurance As Date
    Private _d_other As String
    Private _d_do As Date
    Private _d_original As Date
    Private _d_pib As String

    Private _d_20 As String
    Private _d_40 As String
    Private _d_tglbl As Date
    Private _d_tglbc As Date
    Private _d_tglsk As Date
    Private _d_tgldoctag As Date
    Private _d_tujuan As String
    Private _d_tglsi As Date
    Private _d_tglreqtrucking As Date
    Private _d_tglsurattugas As Date

    Private _d_pebtglreq As Date
    Private _d_pebtglterima As Date
    Private _d_bltglreq As Date
    Private _d_bltglterima As Date
    Private _d_blorisurender As String
    Private _d_asuransitglreq As Date
    Private _d_asuransitglterima As Date
    Private _d_cootgldraft As Date
    Private _d_cootglkomunikasi As Date
    Private _d_cootglpersetujuan As Date
    Private _d_polpod As String
    Private _d_nombl As String
    Private _d_nopabean As String
    Private _d_tglaju As Date
    Private _d_sppbtgl As Date
    Private _d_dobyrtgl As Date
    Private _d_doambiltgl As Date
    Private _d_doterbittgl As String
    Private _d_deliverytgl As Date
    Private _d_terimatagihantgl As Date

    Private _d_tipe As NishiTipeBarangJO
    Private _qty As Double
    Private _satuan As String
    Private _amountinvoice As Double

    <Persistent("f_vendor")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _vendor, value)
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
    <Persistent("f_warehouse")>
    Property Gudang As NuSoft004.Persistent.Gudang
      Get
        Return _gudang
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
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
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _bagpembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
      End Set
    End Property
    <Persistent("f_type")>
    Property JenisJO As NishiJenisJO
      Get
        Return _jenisJO
      End Get
      Set(value As NishiJenisJO)
        SetPropertyValue(Of NishiJenisJO)("JenisJO", _jenisJO, value)
      End Set
    End Property
    <Persistent("d_tipebarang")>
    Property TipeBarangJO As NishiTipeBarangJO
      Get
        Return _d_tipe
      End Get
      Set(value As NishiTipeBarangJO)
        SetPropertyValue(Of NishiTipeBarangJO)("TipeBarangJO", _d_tipe, value)
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
    <Persistent("d_satuan")>
    Property Satuan As String
      Get
        Return _satuan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_amountinvoice")>
    Property AmountInvoice As Double
      Get
        Return _amountinvoice
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("AmountInvoice", _amountinvoice, value)
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
    Property ReffNo As String
      Get
        Return _reffnumber
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ReffNo", _reffnumber, value)
      End Set
    End Property
    <Persistent("d_blno")>
    Property d_blno As String
      Get
        Return _d_blno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_blno", _d_blno, value)
      End Set
    End Property
    <Persistent("d_shipper")>
    Property d_shipper As String
      Get
        Return _d_shipper
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_shipper", _d_shipper, value)
      End Set
    End Property
    <Persistent("d_consignee")>
    Property d_consignee As String
      Get
        Return _d_consignee
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_consignee", _d_consignee, value)
      End Set
    End Property
    <Persistent("d_email")>
    Property d_email As Date
      Get
        Return _d_email
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_email", _d_email, value)
      End Set
    End Property
    <Persistent("d_ajouno")>
    Property d_ajouno As String
      Get
        Return _d_ajouno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_ajouno", _d_ajouno, value)
      End Set
    End Property
    <Persistent("d_invono")>
    Property d_invono As String
      Get
        Return _d_invono
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_invono", _d_invono, value)
      End Set
    End Property
    <Persistent("d_invdate")>
    Property d_invdate As Date
      Get
        Return _d_invdate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_invdate", _d_invdate, value)
      End Set
    End Property
    <Persistent("d_packingno")>
    Property d_packingno As String
      Get
        Return _d_packingno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_packingno", _d_packingno, value)
      End Set
    End Property
    <Persistent("d_packingdate")>
    Property d_packingdate As Date
      Get
        Return _d_packingdate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_packingdate", _d_packingdate, value)
      End Set
    End Property
    <Persistent("d_vessel")>
    Property d_vessel As String
      Get
        Return _d_vessel
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_vessel", _d_vessel, value)
      End Set
    End Property
    <Persistent("d_nw")>
    Property d_nw As Double
      Get
        Return _d_nw
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("d_nw", _d_nw, value)
      End Set
    End Property
    <Persistent("d_gw")>
    Property d_gw As Double
      Get
        Return _d_gw
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("d_gw", _d_gw, value)
      End Set
    End Property
    <Persistent("d_meass")>
    Property d_meass As String
      Get
        Return _d_meass
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_meass", _d_meass, value)
      End Set
    End Property
    <Persistent("d_party")>
    Property d_party As String
      Get
        Return _d_party
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_party", _d_party, value)
      End Set
    End Property
    <Persistent("d_draftpib")>
    Property d_draftpib As Date
      Get
        Return _d_draftpib
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_draftpib", _d_draftpib, value)
      End Set
    End Property
    <Persistent("d_billing")>
    Property d_billing As Date
      Get
        Return _d_billing
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_billing", _d_billing, value)
      End Set
    End Property
    <Persistent("d_bpn")>
    Property d_bpn As Date
      Get
        Return _d_bpn
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_bpn", _d_bpn, value)
      End Set
    End Property
    <Persistent("d_delivery")>
    Property d_delivery As Date
      Get
        Return _d_delivery
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_delivery", _d_delivery, value)
      End Set
    End Property
    <Persistent("d_etd")>
    Property d_etd As Date
      Get
        Return _d_etd
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_etd", _d_etd, value)
      End Set
    End Property
    <Persistent("d_eta")>
    Property d_eta As Date
      Get
        Return _d_eta
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_eta", _d_eta, value)
      End Set
    End Property
    <Persistent("d_shippinginstruction")>
    Property d_shippinginstruction As String
      Get
        Return _d_shippinginstruction
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_shippinginstruction", _d_shippinginstruction, value)
      End Set
    End Property
    <Persistent("d_npeno")>
    Property d_npeno As String
      Get
        Return _d_npeno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_npeno", _d_npeno, value)
      End Set
    End Property
    <Persistent("d_pebno")>
    Property d_pebno As String
      Get
        Return _d_pebno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_pebno", _d_pebno, value)
      End Set
    End Property
    <Persistent("d_coo")>
    Property d_coo As Date
      Get
        Return _d_coo
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_coo", _d_coo, value)
      End Set
    End Property
    <Persistent("d_pickup")>
    Property d_pickup As Date
      Get
        Return _d_pickup
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_pickup", _d_pickup, value)
      End Set
    End Property
    <Persistent("d_insurance")>
    Property d_insurance As Date
      Get
        Return _d_insurance
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_insurance", _d_insurance, value)
      End Set
    End Property
    <Persistent("d_other")>
    Property d_other As String
      Get
        Return _d_other
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_other", _d_other, value)
      End Set
    End Property
    <Persistent("d_do")>
    Property d_do As Date
      Get
        Return _d_do
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_do", _d_do, value)
      End Set
    End Property
    <Persistent("d_original")>
    Property d_original As Date
      Get
        Return _d_original
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_original", _d_original, value)
      End Set
    End Property
    <Persistent("d_pib")>
    Property d_pib As String
      Get
        Return _d_pib
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_pib", _d_pib, value)
      End Set
    End Property
    <Persistent("d_20")>
    Property d_20 As String
      Get
        Return _d_20
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_20", _d_20, value)
      End Set
    End Property
    <Persistent("d_40")>
    Property d_40 As String
      Get
        Return _d_40
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_40", _d_40, value)
      End Set
    End Property
    <Persistent("d_tglbl")>
    Property d_tglbl As Date
      Get
        Return _d_tglbl
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_tglbl", _d_tglbl, value)
      End Set
    End Property
    <Persistent("d_tglbc")>
    Property d_tglbc As Date
      Get
        Return _d_tglbc
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_tglbc", _d_tglbc, value)
      End Set
    End Property
    <Persistent("d_tglsk")>
    Property d_tglsk As Date
      Get
        Return _d_tglsk
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_tglsk", _d_tglsk, value)
      End Set
    End Property
    <Persistent("d_tgldoctag")>
    Property d_tgldoctag As Date
      Get
        Return _d_tgldoctag
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_tgldoctag", _d_tgldoctag, value)
      End Set
    End Property
    <Persistent("d_tujuan")>
    Property d_tujuan As String
      Get
        Return _d_tujuan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_tujuan", _d_tujuan, value)
      End Set
    End Property
    <Persistent("d_tglsi")>
    Property d_tglsi As Date
      Get
        Return _d_tglsi
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_tglsi", _d_tglsi, value)
      End Set
    End Property
    <Persistent("d_tglreqtrucking")>
    Property d_tglreqtrucking As Date
      Get
        Return _d_tglreqtrucking
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_tglreqtrucking", _d_tglreqtrucking, value)
      End Set
    End Property
    <Persistent("d_tglsurattugas")>
    Property d_tglsurattugas As Date
      Get
        Return _d_tglsurattugas
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_tglsurattugas", _d_tglsurattugas, value)
      End Set
    End Property
    <Persistent("d_pebtglreq")>
    Property d_pebtglreq As Date
      Get
        Return _d_pebtglreq
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_pebtglreq", _d_pebtglreq, value)
      End Set
    End Property
    <Persistent("d_pebtglterima")>
    Property d_pebtglterima As Date
      Get
        Return _d_pebtglterima
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_pebtglterima", _d_pebtglterima, value)
      End Set
    End Property
    <Persistent("d_bltglreq")>
    Property d_bltglreq As Date
      Get
        Return _d_bltglreq
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_bltglreq", _d_bltglreq, value)
      End Set
    End Property
    <Persistent("d_bltglterima")>
    Property d_bltglterima As Date
      Get
        Return _d_bltglterima
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_bltglterima", _d_bltglterima, value)
      End Set
    End Property
    <Persistent("d_blorisurender")>
    Property d_blorisurender As String
      Get
        Return _d_blorisurender
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_blorisurender", _d_blorisurender, value)
      End Set
    End Property
    <Persistent("d_asuransitglreq")>
    Property d_asuransitglreq As Date
      Get
        Return _d_asuransitglreq
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_asuransitglreq", _d_asuransitglreq, value)
      End Set
    End Property
    <Persistent("d_asuransitglterima")>
    Property d_asuransitglterima As Date
      Get
        Return _d_asuransitglterima
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_asuransitglterima", _d_asuransitglterima, value)
      End Set
    End Property
    <Persistent("d_cootgldraft")>
    Property d_cootgldraft As Date
      Get
        Return _d_cootgldraft
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_cootgldraft", _d_cootgldraft, value)
      End Set
    End Property
    <Persistent("d_cootglkomunikasi")>
    Property d_cootglkomunikasi As Date
      Get
        Return _d_cootglkomunikasi
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_cootglkomunikasi", _d_cootglkomunikasi, value)
      End Set
    End Property
    <Persistent("d_cootglpersetujuan")>
    Property d_cootglpersetujuan As Date
      Get
        Return _d_cootglpersetujuan
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_cootglpersetujuan", _d_cootglpersetujuan, value)
      End Set
    End Property
    <Persistent("d_polpod")>
    Property d_polpod As String
      Get
        Return _d_polpod
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_polpod", _d_polpod, value)
      End Set
    End Property
    <Persistent("d_nombl")>
    Property d_nombl As String
      Get
        Return _d_nombl
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_nombl", _d_nombl, value)
      End Set
    End Property
    <Persistent("d_nopabean")>
    Property d_nopabean As String
      Get
        Return _d_nopabean
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_nopabean", _d_nopabean, value)
      End Set
    End Property
    <Persistent("d_tglaju")>
    Property d_tglaju As Date
      Get
        Return _d_tglaju
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_tglaju", _d_tglaju, value)
      End Set
    End Property
    <Persistent("d_sppbtgl")>
    Property d_sppbtgl As Date
      Get
        Return _d_sppbtgl
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_sppbtgl", _d_sppbtgl, value)
      End Set
    End Property
    <Persistent("d_dobyrtgl")>
    Property d_dobyrtgl As Date
      Get
        Return _d_dobyrtgl
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_dobyrtgl", _d_dobyrtgl, value)
      End Set
    End Property
    <Persistent("d_doambiltgl")>
    Property d_doambiltgl As Date
      Get
        Return _d_doambiltgl
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_doambiltgl", _d_doambiltgl, value)
      End Set
    End Property
    <Persistent("d_doterbittgl")>
    Property d_doterbittgl As String
      Get
        Return _d_doterbittgl
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("d_doterbittgl", _d_doterbittgl, value)
      End Set
    End Property
    <Persistent("d_deliverytgl")>
    Property d_deliverytgl As Date
      Get
        Return _d_deliverytgl
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_deliverytgl", _d_deliverytgl, value)
      End Set
    End Property
    <Persistent("d_terimatagihantgl")>
    Property d_terimatagihantgl As Date
      Get
        Return _d_terimatagihantgl
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("d_terimatagihantgl", _d_terimatagihantgl, value)
      End Set
    End Property





    ReadOnly Property NamaPelanggan As String
      Get
        Return Pelanggan.Nama
      End Get
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
    <Association("fk_nishiorder_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of NishiOrderPembelianDetail)
      Get
        Return GetCollection(Of NishiOrderPembelianDetail)("Detail")
      End Get
    End Property
    <Association("fk_nishiorder_invoice"), Aggregated> ReadOnly Property Invoice As XPCollection(Of NishiOrderPembelianInvoice)
      Get
        Return GetCollection(Of NishiOrderPembelianInvoice)("Invoice")
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
      Dim source As String = "Job Order [JO]"
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
      'If Detail.Count = 0 Then
      '  Throw New Utils.Exception("Masukkan Item Barang", -5, "", source)
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
  <Persistent("m05ddetailorder")>
  Public Class NishiOrderPembelianDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.NishiOrderPembelian
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
    <Persistent("p_id"), Association("fk_nishiorder_detail")>
    Property Main As NishiOrderPembelian
      Get
        Return _main
      End Get
      Set(value As NishiOrderPembelian)
        SetPropertyValue(Of NishiOrderPembelian)("Main", _main, value)
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
    <Persistent("f_proyek")>
    Property Proyek As NuSoft001.Persistent.Proyek
      Get
        Return _proyek
      End Get
      Set(value As NuSoft001.Persistent.Proyek)
        SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
      End Set
    End Property
    <PersistentAlias("iif(Main.TipePajak = 0,0,PPNp / 100 * DPP)")> ReadOnly Property PPNv As Double '
      Get
        Return Convert.ToDouble(EvaluateAlias("PPNv"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 0,0,PPHp / 100 * DPP)")> ReadOnly Property PPHv As Double '
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
      Dim source As String = "Order Pembelian [PO]"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
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
  <Persistent("m05dorderinvoice")>
  Public Class NishiOrderPembelianInvoice
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.NishiOrderPembelian
    Private _noinvoice As String
    Private _tanggal As Date
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_nishiorder_invoice")>
    Property Main As NishiOrderPembelian
      Get
        Return _main
      End Get
      Set(value As NishiOrderPembelian)
        SetPropertyValue(Of NishiOrderPembelian)("Main", _main, value)
      End Set
    End Property
    <Persistent("d_invoiceno")>
    Property InvoiceNo As String
      Get
        Return _noinvoice
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("InvoiceNo", _noinvoice, value)
      End Set
    End Property
    <Persistent("d_invoicedate")>
    Property InvoceDate As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("InvoceDate", _tanggal, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Order Pembelian [PO]"
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

  <Persistent("m04cmainrequest")>
  Public Class NishiPermintaanStock
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _jenis As Persistent.NishiJenisJO
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _gudang As Gudang
    Private _catatan As String
    Private _idjo As Persistent.NishiOrderPembelian
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    <Persistent("f_type")>
    Property Jenis As Persistent.NishiJenisJO
      Get
        Return _jenis
      End Get
      Set(value As Persistent.NishiJenisJO)
        SetPropertyValue(Of Persistent.NishiJenisJO)("Jenis", _jenis, value)
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
    <Persistent("f_warehouse")>
    Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
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
    <Persistent("f_idjo")>
    Property JobOrder As Persistent.NishiOrderPembelian
      Get
        Return _idjo
      End Get
      Set(value As Persistent.NishiOrderPembelian)
        SetPropertyValue(Of Persistent.NishiOrderPembelian)("JobOrder", _idjo, value)
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
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <Association("fk_nishi_permintaan_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of NishiPermintaanStockDetail)
      Get
        Return GetCollection(Of NishiPermintaanStockDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Permintaan Barang"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan pelanggan", -4, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -5, "", source)
        Return False
      End If
      If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
        Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -6, "", source)
        Return False
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
  <Persistent("m04ddetailrequest")>
  Public Class NishiPermintaanStockDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.NishiPermintaanStock
    Private _item As Barang
    Private _qty As Double
    Private _satuan As Satuan
    Private _catatan As String
    Private _idjo As Persistent.NishiOrderPembelianDetail
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_nishi_permintaan_detail")>
    Property Main As NishiPermintaanStock
      Get
        Return _main
      End Get
      Set(value As NishiPermintaanStock)
        SetPropertyValue(Of NishiPermintaanStock)("Main", _main, value)
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
    <Persistent("d_qty")>
    Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
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
    <Persistent("f_idjo")>
    Property JobOrder As Persistent.NishiOrderPembelianDetail
      Get
        Return _idjo
      End Get
      Set(value As Persistent.NishiOrderPembelianDetail)
        SetPropertyValue(Of Persistent.NishiOrderPembelianDetail)("JobOrder", _idjo, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan stock", -99, "", source)
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

  <Persistent("m04cstockmain")>
  Public Class NishiStockMain
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _karyawanTerima As NuSoft001.Persistent.Kontak
    Private _gudang As Gudang
    Private _catatan As String
    Private _type As TipeTransaksi
    Private _idpermintaan As NishiPermintaanStock
    Private _idjoborder As NishiOrderPembelian
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _nokendaraan As String
    Private _nodokumen As String
    Private _kontakalamat As NuSoft001.Persistent.KontakAlamat
    Private _d_tipe As NishiTipeBarangJO
    Private _kontaktujuanalamat As NuSoft001.Persistent.KontakAlamat
    Private _kontaktujuan As NuSoft001.Persistent.Kontak
    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("f_customertujuan")>
    Property KontakTujuan As NuSoft001.Persistent.Kontak
      Get
        Return _kontaktujuan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("KontakTujuan", _kontaktujuan, value)
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
    <Persistent("f_address")>
    Property KontakAlamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _kontakalamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("KontakAlamat", _kontakalamat, value)
      End Set
    End Property
    <Persistent("f_addresstujuan")>
    Property KontakTujuanAlamat As NuSoft001.Persistent.KontakAlamat
      Get
        Return _kontaktujuanalamat
      End Get
      Set(value As NuSoft001.Persistent.KontakAlamat)
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("KontakTujuanAlamat", _kontaktujuanalamat, value)
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
    <Persistent("d_novehicle")>
    Property NoKendaraan As String
      Get
        Return _nokendaraan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoKendaraan", _nokendaraan, value)
      End Set
    End Property
    <Persistent("d_nodocument")>
    Property NoDokumen As String
      Get
        Return _nodokumen
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoDokumen", _nodokumen, value)
      End Set
    End Property
    <Persistent("f_idrequest")>
    Property PermintaanBarang As NishiPermintaanStock
      Get
        Return _idpermintaan
      End Get
      Set(value As NishiPermintaanStock)
        SetPropertyValue(Of NishiPermintaanStock)("PermintaanBarang", _idpermintaan, value)
      End Set
    End Property
    <Persistent("f_idjo")>
    Property JobOrder As NishiOrderPembelian
      Get
        Return _idjoborder
      End Get
      Set(value As NishiOrderPembelian)
        SetPropertyValue(Of NishiOrderPembelian)("JobOrder", _idjoborder, value)
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
    <Association("fk_nishistock_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of NishiStockDetail)
      Get
        Return GetCollection(Of NishiStockDetail)("Detail")
      End Get
    End Property


    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    ReadOnly Property NamaKontak As String
      Get
        Return Pelanggan.Nama
      End Get
    End Property
    ReadOnly Property LamaSewa As Double
      Get
        Return DateDiff(DateInterval.Day, Tanggal, Now) + 1
      End Get
    End Property
    <Persistent("d_tipebarang")>
    Property TipeBarangJO As NishiTipeBarangJO
      Get
        Return _d_tipe
      End Get
      Set(value As NishiTipeBarangJO)
        SetPropertyValue(Of NishiTipeBarangJO)("TipeBarangJO", _d_tipe, value)
      End Set
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
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Pelanggan", -7, "", source)
        Return False
      End If
      If Detail.Count = 0 Then
        Throw New Utils.Exception("Masukkan detail transaksi", -6, "", source)
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
        Detail(i).Gudang = Gudang
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
  Public Class NishiStockDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Persistent.NishiStockMain
    Private _item As Barang
    Private _kode As String
    Private _serial As String
    Private _qtyin As Double
    Private _qtyout As Double
    Private _qtyin2 As Double
    Private _qtyout2 As Double
    Private _harga As Double
    Private _satuan As Satuan
    Private _satuan2 As Satuan
    Private _gudang As Gudang
    Private _catatan As String
    Private _idpermintaan As Persistent.NishiPermintaanStockDetail
    Private _idjoborder As Persistent.NishiOrderPembelianDetail
    Private _Isi As String
    Private _Spek_CaseID As String
    Private _Size_CaseNo As String
    Private _Inspection_PartNo As String
    Private _WeightNett As Double
    Private _WeightGross As Double
    Private _TruckIn As String
    Private _Qty As Double
    Private _Remark As String
    Private _QtyKubikasi As Double
    Private _StockIN As NishiStockDetail
    Private _StockOUT As NishiStockDetail
    Private _partname As String
    Private _port As String
    Private _asalNegara As String
    Private _noinvoce As String
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_nishistock_detail")>
    Property Main As NishiStockMain
      Get
        Return _main
      End Get
      Set(value As NishiStockMain)
        SetPropertyValue(Of NishiStockMain)("Main", _main, value)
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
    <Persistent("f_uom2")>
    Property Satuan2 As Satuan
      Get
        Return _satuan2
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan2", _satuan2, value)
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
        SetPropertyValue(Of Double)("QtyOut", _qtyout, value)
      End Set
    End Property

    <Persistent("d_qtyin2")>
    Property QtyIn2 As Double
      Get
        Return _qtyin2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyIn2", _qtyin2, value)
      End Set
    End Property
    <Persistent("d_qtyout2")>
    Property QtyOut2 As Double
      Get
        Return _qtyout2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyOut2", _qtyout2, value)
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
    <Persistent("f_idrequestd")>
    Property PermintaanBarang As NishiPermintaanStockDetail
      Get
        Return _idpermintaan
      End Get
      Set(value As NishiPermintaanStockDetail)
        SetPropertyValue(Of NishiPermintaanStockDetail)("PermintaanBarang", _idpermintaan, value)
      End Set
    End Property
    '<Persistent("f_idjod")>
    'Property JobOrder As NishiOrderPembelianDetail
    '  Get
    '    Return _idjoborder
    '  End Get
    '  Set(value As NishiOrderPembelianDetail)
    '    SetPropertyValue(Of NishiOrderPembelianDetail)("JobOrder", _idjoborder, value)
    '  End Set
    'End Property
    <Persistent("d_remarks")>
    Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("d_isi")>
    Property Isi As String
      Get
        Return _Isi
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Isi", _Isi, value)
      End Set
    End Property
    <Persistent("d_spek_caseid")>
    Property Spek_CaseID As String
      Get
        Return _Spek_CaseID
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Spek_CaseID", _Spek_CaseID, value)
      End Set
    End Property
    <Persistent("d_size_caseno")>
    Property Size_CaseNo As String
      Get
        Return _Size_CaseNo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Size_CaseNo", _Size_CaseNo, value)
      End Set
    End Property
    <Persistent("d_inspection_partno")>
    Property Inspection_PartNo As String
      Get
        Return _Inspection_PartNo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Inspection_PartNo", _Inspection_PartNo, value)
      End Set
    End Property
    <Persistent("d_partname")>
    Property PartName As String
      Get
        Return _partname
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PartName", _partname, value)
      End Set
    End Property
    <Persistent("d_port")>
    Property Port As String
      Get
        Return _port
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Port", _port, value)
      End Set
    End Property
    <Persistent("d_asalnegara")>
    Property AsalNegara As String
      Get
        Return _asalNegara
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("AsalNegara", _asalNegara, value)
      End Set
    End Property
    <Persistent("d_noinvoice")>
    Property NoInvoice As String
      Get
        Return _noinvoce
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoInvoice", _noinvoce, value)
      End Set
    End Property
    <Persistent("d_weightnett")>
    Property WeightNett As Double
      Get
        Return _WeightNett
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("WeightNett", _WeightNett, value)
      End Set
    End Property
    <Persistent("d_weightgross")>
    Property WeightGross As Double
      Get
        Return _WeightGross
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("WeightGross", _WeightGross, value)
      End Set
    End Property
    <Persistent("d_truckin")>
    Property TruckIn As String
      Get
        Return _TruckIn
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TruckIn", _TruckIn, value)
      End Set
    End Property
    <Persistent("d_qtykubikasi")>
    Property QtyKubikasi As Double
      Get
        Return _QtyKubikasi
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyKubikasi", _QtyKubikasi, value)
      End Set
    End Property

    <Persistent("f_stockin")>
    Property StockIN As NishiStockDetail
      Get
        Return _StockIN
      End Get
      Set(value As NishiStockDetail)
        SetPropertyValue(Of NishiStockDetail)("StockIN", _StockIN, value)
      End Set
    End Property
    <Persistent("f_stockout")>
    Property StockOut As NishiStockDetail
      Get
        Return _StockOUT
      End Get
      Set(value As NishiStockDetail)
        SetPropertyValue(Of NishiStockDetail)("StockOut", _StockOUT, value)
      End Set
    End Property
    <NonPersistent()> ReadOnly Property QtySJ As Double
      Get
        Return StockOut.QtyOut
      End Get
    End Property
    <NonPersistent()> ReadOnly Property QtySisa As Double
      Get
        Dim psisa As Double
        If StockOut Is Nothing Then
          psisa = QtyIn
        Else
          psisa = QtyIn - StockOut.QtyOut
        End If
        Return psisa
      End Get
    End Property

    <NonPersistent()> ReadOnly Property QtySJKubikasi As Double
      Get
        Return StockOut.QtyOut2
      End Get
    End Property
    <NonPersistent()> ReadOnly Property QtySisaKubikasi As Double
      Get
        Dim psisa As Double
        If StockOut Is Nothing Then
          psisa = QtyIn2
        Else
          psisa = QtyIn2 - StockOut.QtyOut2
        End If
        Return psisa
      End Get
    End Property
    <NonPersistent()> ReadOnly Property Kubikasi As Double
      Get
        Dim psisa As Double
        If QtySisa = 0 Then
          psisa = 0
        Else
          psisa = QtyIn2
        End If
        Return psisa
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Stock Detail"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama stock", -99, "", source)
        Return False
      End If
      'If _item Is Nothing Then
      '  Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
      '  Return False
      'End If
      'If Not Session.IsObjectToDelete(Me) Then
      '  If QtyIn = 0 And QtyOut = 0 Then
      '    Throw New Utils.Exception("Masukkan Qty Barang", -99, "", source)
      '    Return False
      '  End If
      'End If
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

  Friend Class NishiStockDetailImpor
    Property Port As String
    Property Isi As String
    Property Spek_CaseID As String
    Property Size_CaseNo As String
    Property Inspection_PartNo As String
    Property PartName As String
    Property WeightNett As Double
    Property WeightGross As Double
    Property TruckIn As String
    Property Qty As Double
    Property Remark As String
    Property QtyKubikasi As Double
    Property AsalNegara As String
    Property NoInvoice As String
  End Class
  Friend Class NishiStockDetailSJ
    Property xSave As Boolean
    Property idGR As NishiStockDetail
    Property TruckOut As String
    Property Qty As Double
    Property QtyKubikasi As Double
    Property Remark As String
  End Class
  'Friend Class NishiVoucherSJ
  '  Property xUtama As NishiStockMain
  '  Property Detail As XPCollection(Of NishiStockDetail)
  '  Property DetailS As XPCollection(Of NishiStockDetail)
  'End Class

End Namespace