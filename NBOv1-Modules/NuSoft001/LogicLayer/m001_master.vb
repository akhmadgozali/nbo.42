Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute

Namespace Persistent
  <Persistent("m01abank")> _
  Public Class Bank
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kode As String
    Private _nama As String
    Private _norekening As String
    Private _atasnama As String
    Private _keterangan As String

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_name")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("d_accno")> Property NoRekening As String
      Get
        Return _norekening
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoRekening", _norekening, value)
      End Set
    End Property
    <Persistent("d_owner")> Property AtasNama As String
      Get
        Return _atasnama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("AtasNama", _atasnama, value)
      End Set
    End Property
    <Persistent("d_note")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
  End Class
  <Persistent("m01acurrency")> _
  Public Class MataUang
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kode As String
    Private _nama As String
    Private _negara As String
    Private _simbol As String
    Private _keterangan As String
    Private _hutangdagang As Coa
    Private _piutangdagang As Coa
    Private _uangmukapembelian As Coa
    Private _uangmukapenjualan As Coa

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_code"), Size(3)> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_name"), Size(50)> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("d_country"), Size(50)> Property Negara As String
      Get
        Return _negara
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Negara", _negara, value)
      End Set
    End Property
    <Persistent("d_symbol"), Size(3)> Property Simbol As String
      Get
        Return _simbol
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Simbol", _simbol, value)
      End Set
    End Property
    <Persistent("d_note")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
    <Persistent("f_coapayable")> Property HutangDagang As Coa
      Get
        Return _hutangdagang
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("HutangDagang", _hutangdagang, value)
      End Set
    End Property
    <Persistent("f_coareceivable")> Property PiutangDagang As Coa
      Get
        Return _piutangdagang
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("PiutangDagang", _piutangdagang, value)
      End Set
    End Property
    <Persistent("f_coaadvancepurchase")> Property UMPembelian As Coa
      Get
        Return _uangmukapembelian
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("UMPembelian", _uangmukapembelian, value)
      End Set
    End Property
    <Persistent("f_coaadvancesales")> Property UMPenjualan As Coa
      Get
        Return _uangmukapenjualan
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("UMPenjualan", _uangmukapenjualan, value)
      End Set
    End Property

    <Association("fk_matauang_kurs"), Aggregated> ReadOnly Property MataUangKurs As XPCollection(Of MataUangKurs)
      Get
        Return GetCollection(Of MataUangKurs)("MataUangKurs")
      End Get
    End Property
  End Class
  <Persistent("m01bcurrencykurs")>
  Public Class MataUangKurs
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _mataUang As MataUang
    Private _tanggal As Date
    Private _kursUang As Double
    Private _kursPajak As Double

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_currency"), Association("fk_matauang_kurs")> Property MataUang As MataUang
      Get
        Return _mataUang
      End Get
      Set(value As MataUang)
        SetPropertyValue(Of MataUang)("MataUang", _mataUang, value)
      End Set
    End Property
    <Persistent("d_date")> Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
      End Set
    End Property
    <Persistent("d_kurscurrency")> Property KursUang As Double
      Get
        Return _kursUang
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("KursUang", _kursUang, value)
      End Set
    End Property
    <Persistent("d_kurstax")> Property KursPajak As Double
      Get
        Return _kursPajak
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("KursPajak", _kursPajak, value)
      End Set
    End Property
  End Class

  <Persistent("m01acontacttype")> _
  Public Class TipeKontak
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _nama As String

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_name"), Size(30)> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
  End Class
  Public Enum eLevelPenjualan
    <EnumDescription("Level1")> Level1
    <EnumDescription("Level2")> Level2
    <EnumDescription("Level3")> Level3
    <EnumDescription("Level4")> Level4
    <EnumDescription("Level5")> Level5
  End Enum
  Public Enum eJenisKelamin
    <EnumDescription("Pria")> Pria
    <EnumDescription("Wanita")> Wanita
  End Enum
  Public Enum eTipePajak
    <EnumDescription("Tanpa Pajak")> TanpaPajak
    <EnumDescription("Harga Belum Termasuk Pajak")> HargaBelumTermasuk
    <EnumDescription("Harga Sudah Termasuk Pajak")> HargaSudahTermasuk
  End Enum

  <Persistent("m01bcontactview")> Public Class Kontak
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
      Const sumber As String = "Kontak"
      If _Kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode kontak", -2, "", sumber)
        Return False
      End If
      If _Nama Is Nothing Then
        Throw New Utils.Exception("Masukkan nama kontak", -3, "", sumber)
        Return False
      End If
      If _tipeKontak Is Nothing Then
        Throw New Utils.Exception("Masukkan kategori kontak", -4, "", sumber)
        Return False
      End If

      Return True
    End Function

    <Indexed("Kode", Unique:=True)>
    Private _Id As Int64
    Private _tipeKontak As TipeKontak
    Private _Kode As String
    Private _Nama As String
    Private _Alamat As String
    Private _Propinsi As NuSoft.NPO.FixedData.Propinsi
    Private _Kota As NuSoft.NPO.FixedData.Kota
    Private _KodePos As String
    Private _Telepon As String
    Private _Fax As String
    Private _HP1 As String
    Private _HP2 As String
    Private _Email As String
    Private _Keterangan As String
    Private _Aktif As Boolean
    Private _NPWP As String
    Private _NPKP As String
    Private _NPWPAlamat As String
    Private _batasHutang As Double
    Private _batasPiutang As Double

    Private _batasPembelian As Double
    Private _terminPembelian As Persistent.Termin
    Private _karyawanPembelian As Kontak
    Private _fob As Persistent.eTipeFOB
    Private _tipePajakPembelian As eTipePajak
    Private _batasPenjualan As Double
    Private _terminPenjualan As Persistent.Termin
    Private _karyawanPenjualan As Kontak
    Private _levelPenjualan As eLevelPenjualan
    Private _tipePajakPenjualan As eTipePajak
    Private _jenisKelamin As eJenisKelamin
    Private _bank As Bank
    Private _noBank As String
    Private _tglKontrak As Date
    Private _tglLahir As Date
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

    Private _kontakDomestik As Boolean

    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _Id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("f_contacttype")> Property TipeKontak As TipeKontak
      Get
        Return _tipeKontak
      End Get
      Set(value As TipeKontak)
        SetPropertyValue(Of TipeKontak)("TipeKontak", _tipeKontak, value)
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
    <Persistent("d_address")> Property Alamat As String
      Get
        Return _Alamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Alamat", _Alamat, value)
      End Set
    End Property
    <Persistent("f_province")> Property Propinsi As NuSoft.NPO.FixedData.Propinsi
      Get
        Return _Propinsi
      End Get
      Set(value As NuSoft.NPO.FixedData.Propinsi)
        SetPropertyValue(Of NuSoft.NPO.FixedData.Propinsi)("Propinsi", _Propinsi, value)
      End Set
    End Property
    <Persistent("f_district")> Property Kota As NuSoft.NPO.FixedData.Kota
      Get
        Return _Kota
      End Get
      Set(value As NuSoft.NPO.FixedData.Kota)
        SetPropertyValue(Of NuSoft.NPO.FixedData.Kota)("Kota", _Kota, value)
      End Set
    End Property
    <Persistent("d_postal")> Property KodePos As String
      Get
        Return _KodePos
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KodePos", _KodePos, value)
      End Set
    End Property
    <Persistent("d_phone")> Property Telepon As String
      Get
        Return _Telepon
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Telepon", _Telepon, value)
      End Set
    End Property
    <Persistent("d_fax")> Property Fax As String
      Get
        Return _Fax
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Fax", _Fax, value)
      End Set
    End Property
    <Persistent("d_phonecell1")> Property HP1 As String
      Get
        Return _HP1
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("HP1", _HP1, value)
      End Set
    End Property
    <Persistent("d_phonecell2")> Property HP2 As String
      Get
        Return _HP2
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("HP2", _HP2, value)
      End Set
    End Property
    <Persistent("d_email")> Property Email As String
      Get
        Return _Email
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Email", _Email, value)
      End Set
    End Property
    <Persistent("d_note")> Property Keterangan As String
      Get
        Return _Keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _Keterangan, value)
      End Set
    End Property
    <Persistent("d_active")> Property Aktif As Boolean
      Get
        Return _Aktif
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Aktif", _Aktif, value)
      End Set
    End Property
    <Persistent("d_npwp")> Property NPWP As String
      Get
        Return _NPWP
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NPWP", _NPWP, value)
      End Set
    End Property
    <Persistent("d_npkp")> Property NPKP As String
      Get
        Return _NPKP
      End Get
      Set(ByVal value As String)
        SetPropertyValue(Of String)("NPKP", _NPKP, value)
      End Set
    End Property
    <Persistent("d_addresstax")> Property NPWPAlamat As String
      Get
        Return _NPWPAlamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NPWPAlamat", _NPWPAlamat, value)
      End Set
    End Property
    <Persistent("d_limitar")> Property BatasPiutang As Double
      Get
        Return _batasPiutang
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BatasPiutang", _batasPiutang, value)
      End Set
    End Property
    <Persistent("d_limitap")> Property BatasHutang As Double
      Get
        Return _batasHutang
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BatasHutang", _batasHutang, value)
      End Set
    End Property
    <Persistent("d_pembelianbatas")> Property BatasPembelian As Double
      Get
        Return _batasPembelian
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BatasPembelian", _batasPembelian, value)
      End Set
    End Property
    <Persistent("f_pembeliantermin")> Property TerminPembelian As Persistent.Termin
      Get
        Return _terminPembelian
      End Get
      Set(value As Persistent.Termin)
        SetPropertyValue(Of Persistent.Termin)("TerminPembelian", _terminPembelian, value)
      End Set
    End Property
    <Persistent("f_pembeliankaryawan")> Property KaryawanPembelian As NuSoft001.Persistent.Kontak
      Get
        Return _karyawanPembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("KaryawanPembelian", _karyawanPembelian, value)
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
    <Persistent("d_pembeliantaxtype")> Property TipePajakPembelian As eTipePajak
      Get
        Return _tipePajakPembelian
      End Get
      Set(value As eTipePajak)
        SetPropertyValue(Of eTipePajak)("TipePajakPembelian", _tipePajakPembelian, value)
      End Set
    End Property
    <Persistent("d_penjualanbatas")> Property BatasPenjualan As Double
      Get
        Return _batasPenjualan
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BatasPenjualan", _batasPenjualan, value)
      End Set
    End Property
    <Persistent("f_penjualantermin")> Property TerminPenjualan As Persistent.Termin
      Get
        Return _terminPenjualan
      End Get
      Set(value As Persistent.Termin)
        SetPropertyValue(Of Persistent.Termin)("TerminPenjualan", _terminPenjualan, value)
      End Set
    End Property
    <Persistent("f_penjualankaryawan")> Property KaryawanPenjualan As NuSoft001.Persistent.Kontak
      Get
        Return _karyawanPenjualan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("KaryawanPenjualan", _karyawanPenjualan, value)
      End Set
    End Property
    <Persistent("d_penjualanlevel")> Property LevelPenjualan As eLevelPenjualan
      Get
        Return _levelPenjualan
      End Get
      Set(value As eLevelPenjualan)
        SetPropertyValue(Of eLevelPenjualan)("LevelPenjualan", _levelPenjualan, value)
      End Set
    End Property
    <Persistent("d_penjualantaxtype")> Property TipePajakPenjualan As eTipePajak
      Get
        Return _tipePajakPenjualan
      End Get
      Set(value As eTipePajak)
        SetPropertyValue(Of eTipePajak)("TipePajakPenjualan", _tipePajakPenjualan, value)
      End Set
    End Property
    <Persistent("d_jeniskelamin")> Property JenisKelamin As eJenisKelamin
      Get
        Return _jenisKelamin
      End Get
      Set(value As eJenisKelamin)
        SetPropertyValue(Of eJenisKelamin)("JenisKelamin", _jenisKelamin, value)
      End Set
    End Property
    <Persistent("f_bank")> Property Bank As Bank
      Get
        Return _bank
      End Get
      Set(value As Bank)
        SetPropertyValue(Of Bank)("Bank", _bank, value)
      End Set
    End Property
    <Persistent("d_nobank")> Property NoBank As String
      Get
        Return _noBank
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoBank", _noBank, value)
      End Set
    End Property
    <Persistent("d_tglkontrak")> Property TglKontrak As Date
      Get
        Return _tglKontrak
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglKontrak", _tglKontrak, value)
      End Set
    End Property
    <Persistent("d_tgllahir")> Property TglLahir As Date
      Get
        Return _tglLahir
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglLahir", _tglLahir, value)
      End Set
    End Property
    <Persistent("d_custom1")> Property Custom1 As String
      Get
        Return _custom1
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom1", _custom1, value)
      End Set
    End Property
    <Persistent("d_custom2")> Property Custom2 As String
      Get
        Return _custom2
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom2", _custom2, value)
      End Set
    End Property
    <Persistent("d_custom3")> Property Custom3 As String
      Get
        Return _custom3
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom3", _custom3, value)
      End Set
    End Property
    <Persistent("d_custom4")> Property Custom4 As String
      Get
        Return _custom4
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom4", _custom4, value)
      End Set
    End Property
    <Persistent("d_custom5")> Property Custom5 As String
      Get
        Return _custom5
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom5", _custom5, value)
      End Set
    End Property
    <Persistent("d_custom6")> Property Custom6 As String
      Get
        Return _custom6
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom6", _custom6, value)
      End Set
    End Property
    <Persistent("d_custom7")> Property Custom7 As String
      Get
        Return _custom7
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom7", _custom7, value)
      End Set
    End Property
    <Persistent("d_custom8")> Property Custom8 As String
      Get
        Return _custom8
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom8", _custom8, value)
      End Set
    End Property
    <Persistent("d_custom9")> Property Custom9 As String
      Get
        Return _custom9
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom9", _custom9, value)
      End Set
    End Property
    <Persistent("d_custom10")> Property Custom10 As String
      Get
        Return _custom10
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom10", _custom10, value)
      End Set
    End Property

    <Persistent("d_kontakdomestik")> Property KontakDomestik As Boolean
      Get
        Return _kontakDomestik
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("KontakDomestik", _kontakDomestik, value)
      End Set
    End Property

    <NonPersistent()> ReadOnly Property KontakNama As String
      Get
        Return String.Concat(Nama, " [", Kode, "]")
      End Get
    End Property

    <Association("fk_kontak_alamat"), Aggregated> ReadOnly Property KontakAlamat As XPCollection(Of KontakAlamat)
      Get
        Return GetCollection(Of KontakAlamat)("KontakAlamat")
      End Get
    End Property
    <Association("fk_kontak_person"), Aggregated> ReadOnly Property KontakPerson As XPCollection(Of KontakPerson)
      Get
        Return GetCollection(Of KontakPerson)("KontakPerson")
      End Get
    End Property
  End Class
  Public Enum eTipeAlamat
    Kantor = 0
    Gudang = 1
  End Enum
  <Persistent("m01ccontactaddress")> _
  Public Class KontakAlamat
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kontak As Kontak
    Private _tipe As eTipeAlamat
    Private _kode As String
    Private _alamat As String
    Private _telp As String
    Private _fax As String

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_contact"), Association("fk_kontak_alamat")> Property Kontak As Kontak
      Get
        Return _kontak
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Kontak", _kontak, value)
      End Set
    End Property
    <Persistent("d_type")> Property Tipe As eTipeAlamat
      Get
        Return _tipe
      End Get
      Set(value As eTipeAlamat)
        SetPropertyValue(Of eTipeAlamat)("Tipe", _tipe, value)
      End Set
    End Property
    <Persistent("d_code"), Size(25)> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_address"), Size(255)> Property Alamat As String
      Get
        Return _alamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Alamat", _alamat, value)
      End Set
    End Property
    <Persistent("d_phone"), Size(20)> Property Telepon As String
      Get
        Return _telp
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Telepon", _telp, value)
      End Set
    End Property
    <Persistent("d_fax"), Size(20)> Property Fax As String
      Get
        Return _fax
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Fax", _fax, value)
      End Set
    End Property
  End Class
  <Persistent("m01ccontactattention")> _
  Public Class KontakPerson
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _kontak As Kontak
    Private _nama As String
    Private _jabatan As String
    Private _telp As String
    Private _hp As String

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_contact"), Association("fk_kontak_person")> Property Kontak As Kontak
      Get
        Return _kontak
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Kontak", _kontak, value)
      End Set
    End Property
    <Persistent("d_name"), Size(100)> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("d_position"), Size(45)> Property Jabatan As String
      Get
        Return _jabatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Jabatan", _jabatan, value)
      End Set
    End Property
    <Persistent("d_phone"), Size(20)> Property Telepon As String
      Get
        Return _telp
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Telepon", _telp, value)
      End Set
    End Property
    <Persistent("d_mobile"), Size(20)> Property HP As String
      Get
        Return _hp
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("HP", _hp, value)
      End Set
    End Property
  End Class

  Namespace CoaEnum
    Public Enum eLevel1
      Neraca
      RugiLaba
    End Enum
    Public Enum eLevel2
      Aktiva
      Hutang
      Modal
      Pendapatan
      Biaya
    End Enum
    Public Enum eDc
      Debit
      Kredit
    End Enum
    Public Enum eParameter
      None
      Kas
      Bank
    End Enum
    Public Enum eKind
      Kas = 1
      Bank = 2
      Piutang = 3
      Persediaan = 4
      AktivaLancarLainnya = 5
      AktivaTetap = 6
      AkumulasiPenyusutan = 7
      HutangJangkaPendek = 8
      HutangJangkaPanjang = 9
      HutangLancarLainnya = 10
      Modal = 11
      Pendapatan = 12
      HargaPokokPenjualan = 13
      BiayaOperasional = 14
      PendapatanLainLain = 15
      BiayaLainLain = 16
      LabaDitahan = 17
      LabaBerjalan = 18
      Pajak = 19
    End Enum
    Public Enum eGD
      <EnumDescription("Detail")> Detail = 0
      <EnumDescription("General")> General = 1
    End Enum
  End Namespace
  <Persistent("m01acoalevel")> _
  Public Class CoaLevel
    Inherits XPLiteObject

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("p_id"), Key()> Property Id As Integer
    <Persistent("u_code")> Property Kode As String
    <Persistent("d_level1")> Property Level1 As CoaEnum.eLevel1
    <Persistent("d_level2")> Property Level2 As CoaEnum.eLevel2
    <Persistent("d_dc")> Property Dc As CoaEnum.eDc
    <Persistent("d_parameter")> Property Parameter As CoaEnum.eParameter
    <NonPersistent> Property Jenis As CoaEnum.eKind
  End Class
  Public Class CoaLevelCollection
    Implements IList

    Property session As DevExpress.Xpo.UnitOfWork

    Public Sub New(ByVal session As UnitOfWork)
      Me.session = CType(session, UnitOfWork)
    End Sub

    Protected ReadOnly Property Objects As IList
      Get
        Return CreateObjects()
      End Get
    End Property
    Private Function CreateObjects() As IList
      If session Is Nothing Then
        Throw New Utils.Exception("Parameter session belum di set", -11, "Set session di sub new atau property", "CreateObjects")
      End If

      Dim result As New List(Of CoaLevel)

      result.Add(AddItem(CoaEnum.eKind.Kas, "Kas", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Aktiva, CoaEnum.eDc.Debit, CoaEnum.eParameter.Kas))
      result.Add(AddItem(CoaEnum.eKind.Bank, "Bank", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Aktiva, CoaEnum.eDc.Debit, CoaEnum.eParameter.Bank))
      result.Add(AddItem(CoaEnum.eKind.Piutang, "Piutang", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Aktiva, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.Persediaan, "Persediaan", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Aktiva, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.AktivaLancarLainnya, "Aktiva Lancar Lainnya", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Aktiva, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.AktivaTetap, "Aktiva Tetap", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Aktiva, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.AkumulasiPenyusutan, "Akumulasi Penyusutan", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Aktiva, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.HutangJangkaPendek, "Hutang Jangka Pendek", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Hutang, CoaEnum.eDc.Kredit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.HutangJangkaPanjang, "Hutang Jangka Panjang", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Hutang, CoaEnum.eDc.Kredit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.HutangLancarLainnya, "Hutang Lancar Lainnya", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Hutang, CoaEnum.eDc.Kredit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.Modal, "Modal", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Modal, CoaEnum.eDc.Kredit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.Pendapatan, "Pendapatan", CoaEnum.eLevel1.RugiLaba, CoaEnum.eLevel2.Pendapatan, CoaEnum.eDc.Kredit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.HargaPokokPenjualan, "Harga Pokok Penjualan", CoaEnum.eLevel1.RugiLaba, CoaEnum.eLevel2.Biaya, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.BiayaOperasional, "Biaya Operasional", CoaEnum.eLevel1.RugiLaba, CoaEnum.eLevel2.Biaya, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.PendapatanLainLain, "Pendapatan Lain-Lain", CoaEnum.eLevel1.RugiLaba, CoaEnum.eLevel2.Pendapatan, CoaEnum.eDc.Kredit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.BiayaLainLain, "Biaya Lain-Lain", CoaEnum.eLevel1.RugiLaba, CoaEnum.eLevel2.Biaya, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.LabaDitahan, "Laba Ditahan", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Modal, CoaEnum.eDc.Kredit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.LabaBerjalan, "Laba Berjalan", CoaEnum.eLevel1.Neraca, CoaEnum.eLevel2.Modal, CoaEnum.eDc.Kredit, CoaEnum.eParameter.None))
      result.Add(AddItem(CoaEnum.eKind.Pajak, "Pajak", CoaEnum.eLevel1.RugiLaba, CoaEnum.eLevel2.Biaya, CoaEnum.eDc.Debit, CoaEnum.eParameter.None))
      Return result
    End Function
    Private Function AddItem(Id As CoaEnum.eKind, Kode As String, Level1 As CoaEnum.eLevel1, Level2 As CoaEnum.eLevel2, Dc As CoaEnum.eDc, Parameter As CoaEnum.eParameter) As CoaLevel
      Dim result As CoaLevel = session.GetObjectByKey(Of CoaLevel)(CType(Id, Integer))

      If result Is Nothing Then
        result = New CoaLevel(session)
        result.Id = CType(Id, Integer)
        result.Kode = Kode
        result.Level1 = Level1
        result.Level2 = Level2
        result.Dc = Dc
        result.Parameter = Parameter
        result.Jenis = Id
        result.Save()
      End If
      Return result
    End Function

    Public Function Add(value As Object) As Integer Implements System.Collections.IList.Add
      Return Objects.Add(value)
    End Function
    Public Sub Clear() Implements System.Collections.IList.Clear
      Objects.Clear()
    End Sub
    Public Function Contains(value As Object) As Boolean Implements System.Collections.IList.Contains
      Return Objects.Contains(value)
    End Function
    Public Sub CopyTo(array As System.Array, index As Integer) Implements System.Collections.IList.CopyTo
      Objects.CopyTo(array, index)
    End Sub
    Public ReadOnly Property Count As Integer Implements System.Collections.IList.Count
      Get
        Return Objects.Count
      End Get
    End Property
    Public Function IndexOf(value As Object) As Integer Implements System.Collections.IList.IndexOf
      Return Objects.IndexOf(value)
    End Function
    Public Sub Insert(index As Integer, value As Object) Implements System.Collections.IList.Insert
      Objects.Insert(index, value)
    End Sub
    Public ReadOnly Property IsFixedSize As Boolean Implements System.Collections.IList.IsFixedSize
      Get
        Return Objects.IsFixedSize
      End Get
    End Property
    Public ReadOnly Property IsReadOnly As Boolean Implements System.Collections.IList.IsReadOnly
      Get
        Return Objects.IsReadOnly
      End Get
    End Property
    Public ReadOnly Property IsSynchronized As Boolean Implements System.Collections.IList.IsSynchronized
      Get
        Return Objects.IsSynchronized
      End Get
    End Property
    Default Public Property Item(index As Integer) As Object Implements System.Collections.IList.Item
      Get
        Return Objects.Item(index)
      End Get
      Set(value As Object)
        Objects(index) = value
      End Set
    End Property
    Public ReadOnly Property SyncRoot As Object Implements System.Collections.IList.SyncRoot
      Get
        Return Objects.SyncRoot
      End Get
    End Property
    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
      Return Objects.GetEnumerator
    End Function
    Public Sub Remove(value As Object) Implements System.Collections.IList.Remove
      Objects.Remove(value)
    End Sub
    Public Sub RemoveAt(index As Integer) Implements System.Collections.IList.RemoveAt
      Objects.RemoveAt(index)
    End Sub
  End Class
  <Persistent("m01bcoa")> _
  Public Class Coa
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        If _tipe.Parameter = CoaEnum.eParameter.Kas Then
          _bank = Nothing
        ElseIf Not _tipe.Parameter = CoaEnum.eParameter.Bank Then
          _bank = Nothing
        End If
        MyBase.OnSaving()
      End If
    End Sub
    Private Function CheckData() As Boolean
      Const source As String = "Akun"
      If _kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode akun", -1, "", source)
        Return False
      End If
      If _nama = Nothing Then
        Throw New Utils.Exception("Masukkan nama akun", -2, "", source)
        Return False
      End If
      If _matauang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -3, "", source)
        Return False
      End If

      If _tipe.Parameter = CoaEnum.eParameter.Kas OrElse _tipe.Parameter = CoaEnum.eParameter.Bank Then
        If _format = Nothing Then
          Throw New Utils.Exception("Masukkan format nomor", -5, "", source)
          Return False
        End If
      End If
			'If _tipe.Parameter = CoaEnum.eParameter.Bank Then
			'  If _bank Is Nothing Then
			'    Throw New Utils.Exception("Masukkan bank", -4, "", source)
			'    Return False
			'  End If
			'End If

			Return True
    End Function

    Private _id As Int32
    Private _tipe As CoaLevel
    Private _kode As String
    Private _nama As String
    Private _namaCashFlowTambah As String
    Private _namaCashFlowMinus As String
    Private _induk As Coa
    Private _aktif As Boolean
    Private _internal As Boolean
    Private _gabungCashFlow As Boolean
    Private _keterangan As String
    Private _format As String
    Private _matauang As MataUang
    Private _bank As Bank
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _akunIntegrasi As Boolean
    Private _level1 As Coa
    Private _level2 As Coa
    Private _level3 As Coa
    Private _level4 As Coa
    Private _level As Int16
    Private _gd As CoaEnum.eGD
    Private _cashflowIN As CustomReportMain
    Private _cashflowOut As CustomReportMain

    <Persistent("p_id"), Key(True), Indexed("Kode", Unique:=True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_type")> Property Tipe As CoaLevel
      Get
        Return _tipe
      End Get
      Set(value As CoaLevel)
        SetPropertyValue(Of CoaLevel)("Tipe", _tipe, value)
      End Set
    End Property
    <Persistent("u_code"), Size(20)> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_name")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("d_cfp")> Property NamaCashFlowTambah As String
      Get
        Return _namaCashFlowTambah
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NamaCashFlowTambah", _namaCashFlowTambah, value)
      End Set
    End Property
    <Persistent("d_cfm")> Property NamaCashFlowMinus As String
      Get
        Return _namaCashFlowMinus
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NamaCashFlowMinus", _namaCashFlowMinus, value)
      End Set
    End Property
    <Persistent("d_parent")> Property Induk As Coa
      Get
        Return _induk
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Induk", _induk, value)
      End Set
    End Property
    <Persistent("d_active")> Property Aktif As Boolean
      Get
        Return _aktif
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Aktif", _aktif, value)
      End Set
    End Property
    <Persistent("d_cfmerge")> Property GabungCashFlow As Boolean
      Get
        Return _gabungCashFlow
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("GabungCashFlow", _gabungCashFlow, value)
      End Set
    End Property
    <Persistent("d_note")> Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
    <Persistent("d_format")> Property Format As String
      Get
        Return _format
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Format", _format, value)
      End Set
    End Property
    <Persistent("fk_currency")> Property MataUang As MataUang
      Get
        Return _matauang
      End Get
      Set(value As MataUang)
        SetPropertyValue(Of MataUang)("MataUang", _matauang, value)
      End Set
    End Property
    <Persistent("fk_bank")> Property Bank As Bank
      Get
        Return _bank
      End Get
      Set(value As Bank)
        SetPropertyValue(Of Bank)("Bank", _bank, value)
      End Set
    End Property
    <Persistent("fk_division")> Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
      End Set
    End Property
    <Persistent("d_linkaccount")> Property AkunIntegrasi As Boolean
      Get
        Return _akunIntegrasi
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("AkunIntegrasi", _akunIntegrasi, value)
      End Set
    End Property
    '===== leveling coa =====
    <Persistent("d_level")> Property Level As Int16
      Get
        Return _level
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Level", _level, value)
      End Set
    End Property
    <Persistent("f_coa1")> Property Level1 As Coa
      Get
        Return _level1
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Level1", _level1, value)
      End Set
    End Property
    <Persistent("f_coa2")> Property Level2 As Coa
      Get
        Return _level2
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Level2", _level2, value)
      End Set
    End Property
    <Persistent("f_coa3")> Property Level3 As Coa
      Get
        Return _level3
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Level3", _level3, value)
      End Set
    End Property
    <Persistent("f_coa4")> Property Level4 As Coa
      Get
        Return _level4
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Level4", _level4, value)
      End Set
    End Property
    <Persistent("d_gd")> Property GeneralDetail As CoaEnum.eGD
      Get
        Return _gd
      End Get
      Set(value As CoaEnum.eGD)
        SetPropertyValue(Of CoaEnum.eGD)("GeneralDetail", _gd, value)
      End Set
    End Property
    <Persistent("f_cashflowin")> Property ReportCashFlowIN As CustomReportMain
      Get
        Return _cashflowIN
      End Get
      Set(value As CustomReportMain)
        SetPropertyValue(Of CustomReportMain)("ReportCashFlowIN", _cashflowIN, value)
      End Set
    End Property
    <Persistent("f_cashflowout")> Property ReportCashFlowOut As CustomReportMain
      Get
        Return _cashflowOut
      End Get
      Set(value As CustomReportMain)
        SetPropertyValue(Of CustomReportMain)("ReportCashFlowOut", _cashflowOut, value)
      End Set
    End Property

    <PersistentAlias("Concat(Kode,' - ',Nama)")> ReadOnly Property KodeNama As String
      Get
        Return Convert.ToString(EvaluateAlias("KodeNama"))
      End Get
    End Property

    '===== Used for Report
    <NonPersistent()> Property SaldoAwal As Double
    <NonPersistent()> Property KasDebit As Double
    <NonPersistent()> Property KasKredit As Double
    <NonPersistent()> Property BankDebit As Double
    <NonPersistent()> Property BankKredit As Double
    <NonPersistent()> Property JMDebit As Double
    <NonPersistent()> Property JMKredit As Double

    <NonPersistent()> ReadOnly Property MutasiDebit As Double
      Get
        Return KasDebit + BankDebit + JMDebit
      End Get
    End Property
    <NonPersistent()> ReadOnly Property MutasiKredit As Double
      Get
        Return KasKredit + BankKredit + JMKredit
      End Get
    End Property
    <NonPersistent()> ReadOnly Property SaldoAkhir As Double
      Get
        If Tipe.Dc = CoaEnum.eDc.Debit Then
          Return SaldoAwal + (MutasiDebit - MutasiKredit)
        Else
          Return SaldoAwal + (MutasiKredit - MutasiDebit)
        End If
      End Get
    End Property
    ReadOnly Property CFNamaTambah As String
      Get
        If _namaCashFlowTambah = Nothing Then
          Return _nama
        Else
          Return _namaCashFlowTambah
        End If
      End Get
    End Property
    ReadOnly Property CFNamaMinus As String
      Get
        If _namaCashFlowMinus = Nothing Then
          Return _nama
        Else
          Return _namaCashFlowMinus
        End If
      End Get
    End Property
  End Class

  Public Enum StatusTransaksiEnum
    <EnumDescription("Draft/Pending")> Pending = 0
    <EnumDescription("Posting")> Posting = 1
    <EnumDescription("InProgress")> InProgress = 2
    <EnumDescription("Finish")> Finish = 3
    <EnumDescription("Request Approve")> ReqApprove = 4
    <EnumDescription("Approved")> Approved = 5
    <EnumDescription("Closed")> Closed = 8
    <EnumDescription("Rejected")> Rejected = 9
  End Enum

  <Persistent("m01aproject")> _
  Public Class Proyek
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _kode As String
    Private _nama As String
    Private _customer As Persistent.Kontak
    Private _nomorkontrak As String
    Private _tglawal As Date
    Private _tglakhir As Date
    Private _custom1 As String
    Private _custom2 As String
    Private _custom3 As String
    Private _custom4 As String
    Private _custom5 As String
		<Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
			Set(value As Int32)
				SetPropertyValue(Of Int32)("Id", _id, value)
			End Set
		End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_name")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
    <Persistent("d_nokontrak")> Property NoKontrak As String
      Get
        Return _nomorkontrak
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoKontrak", _nomorkontrak, value)
      End Set
    End Property
    <Persistent("f_customer")> Property Customer As Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As Persistent.Kontak)
        SetPropertyValue(Of Persistent.Kontak)("Customer", _customer, value)
      End Set
    End Property
    <Persistent("d_tglawal")> Property TglAwal As Date
      Get
        Return _tglawal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglAwal", _tglawal, value)
      End Set
    End Property
    <Persistent("d_tglakhir")> Property TglAkhir As Date
      Get
        Return _tglakhir
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglAkhir", _tglakhir, value)
      End Set
    End Property
    <Persistent("d_custom1")> Property Custom1 As String
      Get
        Return _custom1
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom1", _custom1, value)
      End Set
    End Property
    <Persistent("d_custom2")> Property Custom2 As String
      Get
        Return _custom2
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom2", _custom2, value)
      End Set
    End Property
    <Persistent("d_custom3")> Property Custom3 As String
      Get
        Return _custom3
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom3", _custom3, value)
      End Set
    End Property
    <Persistent("d_custom4")> Property Custom4 As String
      Get
        Return _custom4
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom4", _custom4, value)
      End Set
    End Property
    <Persistent("d_custom5")> Property Custom5 As String
      Get
        Return _custom5
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom5", _custom5, value)
      End Set
    End Property
		'<Association("m01bproyek_detail"), Aggregated()> ReadOnly Property Detail As XPCollection(Of GlMainDetail)
		'	Get
		'		Return GetCollection(Of GlMainDetail)("Detail")
		'	End Get
		'End Property
	End Class
  <Persistent("m01bprojectsub")> _
  Public Class ProyekSub
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _kode As String
    Private _nama As String
    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_name")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
  End Class
  Public Enum eTipeARAP
    Piutang = 0
    Hutang = 1
    All = 2
    Summary = 3
    PiutangCOA = 4
    HutangCOA = 5
  End Enum
  Public Enum eJenisGiro
    Masuk = 0
    Keluar = 1
  End Enum
  Public Enum eTipePrepayment
    <EnumDescription("Pembayaran DP")> PembayaranDP
    <EnumDescription("Pembayaran Hutang")> PembayaranHutang
    <EnumDescription("Pengajuan Dana")> PengajuanDana
    <EnumDescription("Pembayaran Cicilan")> PembayaranCicilan
    <EnumDescription("Biaya Operasional")> BiayaOperasional
    <EnumDescription("Lain-Lain")> LainLain
  End Enum
  Public Enum eTipePrepayment2
    <EnumDescription("Cash Payment")> PembayaranCash
    <EnumDescription("Bank Payment")> PembayaranBank
    <EnumDescription("Outstanding Payment")> OutStanding
  End Enum
  <Persistent("m01carapsetup")>
  Public Class SetupARAP
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _coa As Coa
    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_coa")> Property COA As Coa
      Get
        Return _coa
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("COA", _coa, value)
      End Set
    End Property
  End Class

  <Persistent("m01vwcoa")> Friend Class xViewCOA
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int32
    Property Tipe As CoaLevel
    Property Kode As String
    Property Nama As String
    Property NamaCashFlowTambah As String
    Property NamaCashFlowMinus As String
    Property Induk As Coa
    Property Aktif As Boolean
    Property GabungCashFlow As Boolean
    Property Keterangan As String
    Property Format As String
    Property AkunIntegrasi As Boolean
    Property MataUang As MataUang
    Property Bank As Bank
    Property Divisi As NPO.Modules.ModSys.Divisi
    Property GeneralDetail As CoaEnum.eGD
    Property Level1 As Coa
    Property Level2 As Coa
    Property Level3 As Coa
    Property Level4 As Coa
    Property Level As Integer
    Property KodeX As String
    Property f_cashflowin As CustomReportMain
    Property f_cashflowout As CustomReportMain
  End Class
End Namespace