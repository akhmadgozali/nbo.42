Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  <Persistent("m01cmaingl")>
  Friend Class xPJPGLMain
    Inherits TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("f_reg")> Private _regional As NPO.Modules.ModSys.Regional
    <Persistent("f_source")> Private _sumberData As NPO.Modules.ModSys.SumberData
    Private _fcoa As Coa
    Private _kontak As Kontak
    Private _kontakNama As String
    Private _tipe As KasBankKeluarTipe
    Private _uraian As String
    Private _caraBayar As BankCaraBayar
    Private _mataUang As String
    Private _kurs As Double
    Private _catatan As String
    Private _tanggalRekonsiliasi As Date
    Private _cashAdvance As GlMain
    Private _moduleId As NPO.Modules.ModuleId
    Private _prosestki As xProsesTKI

    <Persistent("d_director")> Private _direktur As String
    <Persistent("d_accounting")> Private _akunting As String
    <Persistent("d_cashier")> Private _kasir As String
    <Persistent("f_coa")> Property fCOA As Coa
      Get
        Return _fcoa
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Kontak", _fcoa, value)
      End Set
    End Property
    <Persistent("f_contact")> Property Kontak As Kontak
      Get
        Return _kontak
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Kontak", _kontak, value)
      End Set
    End Property
    <Persistent("d_contact")> Property KontakNama As String
      Get
        Return _kontakNama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakNama", _kontakNama, value)
      End Set
    End Property
    <Persistent("d_type")> Property Tipe As KasBankKeluarTipe
      Get
        Return _tipe
      End Get
      Set(value As KasBankKeluarTipe)
        SetPropertyValue(Of KasBankKeluarTipe)("Tipe", _tipe, value)
      End Set
    End Property
    <Persistent("d_description"), Size(255)> Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_payment")> Property CaraBayar As BankCaraBayar
      Get
        Return _caraBayar
      End Get
      Set(value As BankCaraBayar)
        SetPropertyValue(Of BankCaraBayar)("CaraBayar", _caraBayar, value)
      End Set
    End Property
    <Persistent("d_currency")> Property MataUang As String
      Get
        Return _mataUang
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("MataUang", _mataUang, value)
      End Set
    End Property
    <Persistent("d_rate")> Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("d_note"), Size(255)> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("d_reconciliation")> Property TanggalRekonsiliasi As Date
      Get
        Return _tanggalRekonsiliasi
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalRekonsiliasi", _tanggalRekonsiliasi, value)
      End Set
    End Property
    <Persistent("fk_cashadvance")> Property CashAdvance As GlMain
      Get
        Return _cashAdvance
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("CashAdvance", _cashAdvance, value)
      End Set
    End Property
    <Persistent("x_module")> Property ModuleId As NPO.Modules.ModuleId
      Get
        Return _moduleId
      End Get
      Set(value As NPO.Modules.ModuleId)
        SetPropertyValue(Of NPO.Modules.ModuleId)("ModuleId", _moduleId, value)
      End Set
    End Property
    <Persistent("f_proses")> Property ProsesTKI As xProsesTKI
      Get
        Return _prosestki
      End Get
      Set(value As xProsesTKI)
        SetPropertyValue(Of xProsesTKI)("ProsesTKI", _prosestki, value)
      End Set
    End Property
    <Association("m01cmaingl_detail"), Aggregated()> ReadOnly Property Detail As XPCollection(Of xPJPGlDetail)
      Get
        Return GetCollection(Of xPJPGlDetail)("Detail")
      End Get
    End Property
    <Association("m01cmaingl_giro"), Aggregated()> ReadOnly Property Giro As XPCollection(Of xPJPGlGiro)
      Get
        Return GetCollection(Of xPJPGlGiro)("Giro")
      End Get
    End Property
    <Association("m01cmaingl_tki"), Aggregated()> ReadOnly Property DetailTKI As XPCollection(Of xPJPGlTKI)
      Get
        Return GetCollection(Of xPJPGlTKI)("DetailTKI")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Debit)")> ReadOnly Property Saldo As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Saldo"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(DebitValas + KreditValas)")> ReadOnly Property SaldoValas As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SaldoValas"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(DebitValas)")> ReadOnly Property SaldoValasDebit As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SaldoValasDebit"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(KreditValas)")> ReadOnly Property SaldoValasKredit As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SaldoValasKredit"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Saldo)")> ReadOnly Property Terbilang As String
      Get
        Return Convert.ToString(EvaluateAlias("Terbilang"))
      End Get
    End Property
    <PersistentAlias("_direktur")> ReadOnly Property Direktur As String
      Get
        Return Convert.ToString(EvaluateAlias("Direktur"))
      End Get
    End Property
    <PersistentAlias("_akunting")> ReadOnly Property Akunting As String
      Get
        Return Convert.ToString(EvaluateAlias("Akunting"))
      End Get
    End Property
    <PersistentAlias("_kasir")> ReadOnly Property Kasir As String
      Get
        Return Convert.ToString(EvaluateAlias("Kasir"))
      End Get
    End Property
    'nama TKI 
    '<NonPersistent()> ReadOnly Property NamaTKI As String
    '  Get
    '    Dim xNama As String = ""
    '    If DetailTKI.Count > 0 Then
    '      For pI = 0 To Detail.Count - 1
    '        xNama = xNama & DetailTKI(pI).TKI.Nama & vbCrLf
    '      Next
    '    End If
    '    Return xNama
    '  End Get
    'End Property
    Private Function CheckData() As Boolean
      Dim source As String = "GL Main"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Sumber Is Nothing Then
        Throw New Utils.Exception("Masukkan sumberdata", -2, "", source)
        Return False
      End If
      If _uraian = Nothing Then
        Throw New Utils.Exception("Masukkan keterangan", -3, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -4, "", source)
        Return False
      End If
      If Detail Is Nothing Then
        Throw New Utils.Exception("Masukkan detail jurnal", -5, "", source)
        Return False
      End If
      If _kontak Is Nothing Then
        Throw New Utils.Exception("Masukkan Kontak", -6, "", source)
        Return False
      End If
      For pi = Detail.Count - 1 To 0 Step -1
        If Detail(pi).Akun Is Nothing Then
          Detail(pi).Delete()
        End If
      Next

      '======= Cek Nol
      If Detail.Sum(Function(m) m.Debit) = 0 Then
        Throw New Utils.Exception("Saldo tidak boleh nol", -7, "Periksa lagi transaksi anda", source)
        Return False
      End If
      If Detail.Sum(Function(m) m.Kredit) = 0 Then
        Throw New Utils.Exception("Saldo tidak boleh nol", -7, "Periksa lagi transaksi anda", source)
        Return False
      End If

      '======= Cek Periode
      If Periode.CheckLockedPeriod(Session, Tanggal) Then
        Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      _regional = Regional
      _sumberData = Sumber
      _fcoa = Akun

      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If

      If Session.IsNewObject(Me) Then
        Dim reg As SettingRegional = Session.GetObjectByKey(Of SettingRegional)(_regional.Id)
        If _direktur = Nothing Then
          _direktur = reg.Direktur
        End If
        If _akunting = Nothing Then
          _akunting = reg.Akunting
        End If
        If _kasir = Nothing Then
          If SumberDataCollection.GetEnum(_sumberData) = Persistent.SumberDataJenis.BM OrElse SumberDataCollection.GetEnum(_sumberData) = Persistent.SumberDataJenis.BK Then
            _kasir = reg.KasirBank
          Else
            _kasir = reg.Kasir
          End If
        End If
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m01dmaindetail")>
  Friend Class xPJPGlDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("primary_main"), Key(True), Indexed("Main;Urutan", Unique:=True)> Private _id As Int64
    Private _main As xPJPGLMain
    Private _urutan As Byte
    Private _akun As Coa
    Private _debit As Double
    Private _kredit As Double
    Private _kurs As Double
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _proyek As Persistent.Proyek
    Private _proyeksub As Persistent.ProyekSub
    Private _matauang As Persistent.MataUang
    Private _debitv As Double

    Private _creditv As Double
    Private _keterangan As String
    Private _rekonsiliasi As Boolean
    Private _appnumber As xMesitechGLMain
    Private _dbmutasiapp As Double
    Private _bplain As Double

    <Persistent("p_id"), Association("m01cmaingl_detail")> Property Main As xPJPGLMain
      Get
        Return _main
      End Get
      Set(value As xPJPGLMain)
        SetPropertyValue(Of xPJPGLMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("p_order")> Property Urutan As Byte
      Get
        Return _urutan
      End Get
      Set(value As Byte)
        SetPropertyValue(Of Byte)("Urutan", _urutan, value)
      End Set
    End Property
    <Persistent("f_coa")> Property Akun As Coa
      Get
        Return _akun
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Akun", _akun, value)
      End Set
    End Property
    <Persistent("d_debit")> Property Debit As Double
      Get
        Return _debit
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Debit", _debit, value)
      End Set
    End Property
    <Persistent("d_credit")> Property Kredit As Double
      Get
        Return _kredit
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kredit", _kredit, value)
      End Set
    End Property
    <Persistent("d_rate")> Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("f_currency")> Property MataUang As Persistent.MataUang
      Get
        Return _matauang
      End Get
      Set(value As Persistent.MataUang)
        SetPropertyValue(Of Persistent.MataUang)("MataUang", _matauang, value)
      End Set
    End Property
    <Persistent("d_debitvalas")> Property DebitValas As Double
      Get
        Return _debitv
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DebitValas", _debitv, value)
      End Set
    End Property
    <Persistent("d_creditvalas")> Property KreditValas As Double
      Get
        Return _creditv
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("KreditValas", _creditv, value)
      End Set
    End Property

    <Persistent("f_division")> Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
      End Set
    End Property
    <Persistent("f_proyek")> Property Proyek As Proyek
      Get
        Return _proyek
      End Get
      Set(value As Proyek)
        SetPropertyValue(Of Proyek)("Proyek", _proyek, value)
      End Set
    End Property
    <Persistent("f_proyeksub")> Property ProyekSub As ProyekSub
      Get
        Return _proyeksub
      End Get
      Set(value As ProyekSub)
        SetPropertyValue(Of ProyekSub)("Proyek", _proyeksub, value)
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
    <Persistent("d_rekonsiliasi")> Property Rekonsiliasi As Boolean
      Get
        Return _rekonsiliasi
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Rekonsiliasi", _rekonsiliasi, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan property main urutan ke " & _urutan, -1, "", source)
        Return False
      End If
      If _akun Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan akun", -2, "", source)
        Return False
      End If
      If _akun Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan akun", -2, "", source)
        Return False
      End If

      If _debit = Nothing AndAlso _kredit = Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan nilai debit/kredit", -3, "", source)
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
  <Persistent("m01dmaingiro")>
  Friend Class xPJPGlGiro
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("primary_main"), Key(True), Indexed("Main", Unique:=True)> Private _id As Int64
    Private _main As xPJPGLMain
    Private _maincair As xPJPGLMain
    Private _coagiro As Coa
    Private _uang As MataUang
    Private _nogiro As String
    Private _bank As String
    Private _bankacno As String
    Private _jatuhtempo As Date
    Private _nilai As Double
    Private _kurs As Double
    Private _status As Boolean
    Private _tipe As eJenisGiro

    <Persistent("p_id"), Association("m01cmaingl_giro")> Property Main As xPJPGLMain
      Get
        Return _main
      End Get
      Set(value As xPJPGLMain)
        SetPropertyValue(Of xPJPGLMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_idsetlement")> Property TransaksiCair As xPJPGLMain
      Get
        Return _maincair
      End Get
      Set(value As xPJPGLMain)
        SetPropertyValue(Of xPJPGLMain)("TransaksiCair", _maincair, value)
      End Set
    End Property
    <Persistent("f_coagiro")> Property CoaGiro As Coa
      Get
        Return _coagiro
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("CoaGiro", _coagiro, value)
      End Set
    End Property
    <Persistent("f_currency")> Property Uang As MataUang
      Get
        Return _uang
      End Get
      Set(value As MataUang)
        SetPropertyValue(Of MataUang)("Uang", _uang, value)
      End Set
    End Property
    <Persistent("d_girono")> Property NoGiro As String
      Get
        Return _nogiro
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoGiro", _nogiro, value)
      End Set
    End Property
    <Persistent("d_bank")> Property Bank As String
      Get
        Return _bank
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Bank", _bank, value)
      End Set
    End Property
    <Persistent("d_bankacno")> Property BankAcNo As String
      Get
        Return _bankacno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("BankAcNo", _bankacno, value)
      End Set
    End Property
    <Persistent("d_duedate")> Property JatuhTempo As Date
      Get
        Return _jatuhtempo
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("JatuhTempo", _jatuhtempo, value)
      End Set
    End Property
    <Persistent("d_value")> Property Nilai As Double
      Get
        Return _nilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _nilai, value)
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
    <Persistent("d_type")> Property Tipe As Persistent.eJenisGiro
      Get
        Return _tipe
      End Get
      Set(value As Persistent.eJenisGiro)
        SetPropertyValue(Of eJenisGiro)("Tipe", _tipe, value)
      End Set
    End Property
    <Persistent("d_status")> Property Status As Boolean
      Get
        Return _status
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Status", _status, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m01dmaintki")>
  Friend Class xPJPGlTKI
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("primary_main"), Key(True), Indexed("Main", Unique:=True)> Private _id As Int64
    Private _main As xPJPGLMain
    Private _tki As xPJPTKI
    Private _nilai As Double
    Private _catatan As String

    <Persistent("p_id"), Association("m01cmaingl_tki")> Property Main As xPJPGLMain
      Get
        Return _main
      End Get
      Set(value As xPJPGLMain)
        SetPropertyValue(Of xPJPGLMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_tki")> Property TKI As xPJPTKI
      Get
        Return _tki
      End Get
      Set(value As xPJPTKI)
        SetPropertyValue(Of xPJPTKI)("TKI", _tki, value)
      End Set
    End Property
    <Persistent("d_jumlah")> Property Nilai As Double
      Get
        Return _nilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _nilai, value)
      End Set
    End Property
    <Persistent("d_catatan")> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan property main ", -1, "", source)
        Return False
      End If
      If _tki Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan nama TKI", -2, "", source)
        Return False
      End If

      If _nilai = Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan nilai ", -3, "", source)
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

  <Persistent("m01vwGL")> Public Class xPJPBukuBesar
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property Id As Int64
    Property SumberData As NPO.Modules.ModSys.SumberData
    Property Tahun As Int32
    Property Bulan As Int32
    Property Tanggal As Date
    Property Kontak As Persistent.Kontak
    Property NoBukti As String
    Property AkunMain As Coa
    Property AkunDetail As Coa
    Property Urutan As Int16
    Property SaldoAwal As Double
    Property Debit As Double
    Property Kredit As Double
    Property SaldoAwalValas As Double
    Property DebitValas As Double
    Property KreditValas As Double
    Property Kurs As Double
    Property Keterangan As String
    Property Catatan As String
    Property Divisi As NPO.Modules.ModSys.Divisi
    Property Proyek As Persistent.Proyek
    Property ProyekSub As Persistent.ProyekSub
  End Class

  <Persistent("m01aproses")> _
  Public Class xProsesTKI
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
    <Persistent("u_code")>
    Property kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("kode", _kode, value)
      End Set
    End Property
    <Persistent("d_name")>
    Property nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("nama", _nama, value)
      End Set
    End Property
  End Class

  '==== DARI IPUL
  <Persistent("anegara")> _
  Public Class xPJPTKINegara
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
    Private _mata_uang As String

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("kode")>
    Property kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("kode", _kode, value)
      End Set
    End Property
    <Persistent("nama")>
    Property nama As String
      Get
        Return _nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("nama", _nama, value)
      End Set
    End Property
    <Persistent("mata_uang")>
    Property mata_uang As String
      Get
        Return _mata_uang
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("mata_uang", _mata_uang, value)
      End Set
    End Property
  End Class
  <Persistent("m09_tki")>
  Friend Class xPJPTKI
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _Id As Int64
    Private _Kode As String
    Private _TanggalDaftar As Date
    Private _Negara As xPJPTKINegara
    Private _Cabang As Int64
    Private _Sponsor As Int64
    Private _Agency As Int64
    Private _Nama As String
    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _Id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("kode")>
    Property Kode As String
      Get
        Return _Kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _Kode, value)
      End Set
    End Property
    <Persistent("nama")>
    Property Nama As String
      Get
        Return _Nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _Nama, value)
      End Set
    End Property
    <Persistent("tgl_daftar")>
    Property TanggalDaftar As Date
      Get
        Return _TanggalDaftar
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalDaftar", _TanggalDaftar, value)
      End Set
    End Property
    <Persistent("negara")>
    Property Negara As xPJPTKINegara
      Get
        Return _Negara
      End Get
      Set(value As xPJPTKINegara)
        SetPropertyValue(Of xPJPTKINegara)("Negara", _Negara, value)
      End Set
    End Property
    <Persistent("cabang")>
    Property Cabang As Int64
      Get
        Return _Cabang
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Cabang", _Cabang, value)
      End Set
    End Property
    <Persistent("sponsor")>
    Property Sponsor As Int64
      Get
        Return _Sponsor
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Sponsor", _Sponsor, value)
      End Set
    End Property
    <Persistent("agency")>
    Property Agency As Int64
      Get
        Return _Agency
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Agency", _Agency, value)
      End Set
    End Property


    <Association("main_medicalpra"), Aggregated()> ReadOnly Property MedicalPra As XPCollection(Of xPJPTKIMedicalPra)
      Get
        Return GetCollection(Of xPJPTKIMedicalPra)("MedicalPra")
      End Get
    End Property
    <Association("main_medicalfull"), Aggregated()> ReadOnly Property MedicalFull As XPCollection(Of xPJPTKIMedicalFull)
      Get
        Return GetCollection(Of xPJPTKIMedicalFull)("MedicalFull")
      End Get
    End Property
    <Association("main_paspor"), Aggregated()> ReadOnly Property Paspor As XPCollection(Of xPJPTKIPaspor)
      Get
        Return GetCollection(Of xPJPTKIPaspor)("Paspor")
      End Get
    End Property
    <Association("main_visa"), Aggregated()> ReadOnly Property Visa As XPCollection(Of xPJPTKIVisa)
      Get
        Return GetCollection(Of xPJPTKIVisa)("Visa")
      End Get
    End Property
    <Association("main_berangkat"), Aggregated()> ReadOnly Property Berangkat As XPCollection(Of xPJPTKIPemberangkatan)
      Get
        Return GetCollection(Of xPJPTKIPemberangkatan)("Berangkat")
      End Get
    End Property
    <Association("main_skck"), Aggregated()> ReadOnly Property SKCK As XPCollection(Of xPJPTKISKCK)
      Get
        Return GetCollection(Of xPJPTKISKCK)("SKCK")
      End Get
    End Property
    '==tambahan readonly
    <NonPersistent()> ReadOnly Property TanggalMedicalPra As Date
      Get
        If MedicalPra.Count = 1 Then
          Return MedicalPra(0).Tanggal
        Else
          Return Nothing
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TanggalMedicalFull As Date
      Get
        If MedicalFull.Count = 1 Then
          Return MedicalFull(0).TanggalFull
        Else
          Return Nothing
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TanggalMedicalTerusan As Date
      Get
        If MedicalFull.Count = 1 Then
          Return MedicalFull(0).TanggalTerusan
        Else
          Return Nothing
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TanggalMedicalOnline As Date
      Get
        If MedicalFull.Count = 1 Then
          Return MedicalFull(0).TglMedicalOnline
        Else
          Return Nothing
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TanggalPasporPengajuan As Date
      Get
        If Paspor.Count = 1 Then
          Return Paspor(0).TanggalPasporPengajuan
        Else
          Return Nothing
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TanggalPasporKeluar As Date
      Get
        If Paspor.Count = 1 Then
          Return Paspor(0).TanggalPasporKeluar
        Else
          Return Nothing
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TanggalVisa As Date
      Get
        If Visa.Count = 1 Then
          Return Visa(0).TanggalVisa
        Else
          Return Nothing
        End If
      End Get
    End Property

    <NonPersistent()> ReadOnly Property TanggalTicket As Date
      Get
        If Berangkat.Count = 1 Then
          Return Berangkat(0).TanggalTiket
        Else
          Return Nothing
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TanggalBerangkat As Date
      Get
        If Berangkat.Count = 1 Then
          Return Berangkat(0).TanggalBerangkat
        Else
          Return Nothing
        End If
      End Get
    End Property

    <NonPersistent()> ReadOnly Property TanggalSKCKPengajuan As Date
      Get
        If SKCK.Count = 1 Then
          Return SKCK(0).TanggalPengajuan
        Else
          Return Nothing
        End If
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TanggalSKCKKeluar As Date
      Get
        If SKCK.Count = 1 Then
          Return SKCK(0).TanggalKeluar
        Else
          Return Nothing
        End If
      End Get
    End Property

    Protected Overrides Sub OnSaving()
      MyBase.OnSaving()
    End Sub
  End Class

  <Persistent("dmedicalpra")> _
  Friend Class xPJPTKIMedicalPra
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(Session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _p_id As Int64
    Private _Main As xPJPTKI
    Private _Tanggal As Date
    Private _Medical As Int64
    Private _TglSerti As Date
    Private _NoSerti As String
    Private _Hasil As String
    Private _keterangan As String
    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _p_id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _p_id, value)
      End Set
    End Property
    <Persistent("tki"), Association("main_medicalpra")> Property Main As xPJPTKI
      Get
        Return _Main
      End Get
      Set(value As xPJPTKI)
        SetPropertyValue(Of xPJPTKI)("Main", _Main, value)
      End Set
    End Property
    <Persistent("tgl")>
    Property Tanggal As Date
      Get
        Return _Tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _Tanggal, value)
      End Set
    End Property
    <Persistent("medical")>
    Property Medical As Int64
      Get
        Return _Medical
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Medical", _Medical, value)
      End Set
    End Property
    <Persistent("tgl_serti")>
    Property TglSerti As Date
      Get
        Return _TglSerti
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglSerti", _TglSerti, value)
      End Set
    End Property
    <Persistent("no_serti")>
    Property NoSerti As String
      Get
        Return _NoSerti
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSerti", _NoSerti, value)
      End Set
    End Property
    <Persistent("hasil")>
    Property Hasil As String
      Get
        Return _Hasil
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Hasil", _Hasil, value)
      End Set
    End Property
    <Persistent("keterangan")>
    Property keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("keterangan", _keterangan, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("dmedicalfull")> _
  Friend Class xPJPTKIMedicalFull
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(Session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _p_id As Int64
    Private _Main As xPJPTKI
    Private _TanggalTerusan As Date
    Private _TanggalFull As Date
    Private _Medical As Int64
    Private _Hasil As String
    Private _Keterangan As String
    Private _TglSerti As Date
    Private _NoSerti As String
    Private _TglSertiPerpanjang As Date
    Private _TglMedicalUlang As Date
    Private _TglMedicalOnline As Date
    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _p_id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _p_id, value)
      End Set
    End Property
    <Persistent("tki"), Association("main_medicalfull")> Property Main As xPJPTKI
      Get
        Return _Main
      End Get
      Set(value As xPJPTKI)
        SetPropertyValue(Of xPJPTKI)("Main", _Main, value)
      End Set
    End Property
    <Persistent("tgl_medical_terusan")>
    Property TanggalTerusan As Date
      Get
        Return _TanggalTerusan
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalTerusan", _TanggalTerusan, value)
      End Set
    End Property
    <Persistent("tgl_medical_full")>
    Property TanggalFull As Date
      Get
        Return _TanggalFull
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalFull", _TanggalFull, value)
      End Set
    End Property
    <Persistent("medical")>
    Property Medical As Int64
      Get
        Return _Medical
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Medical", _Medical, value)
      End Set
    End Property
    <Persistent("hasil")>
    Property Hasil As String
      Get
        Return _Hasil
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Hasil", _Hasil, value)
      End Set
    End Property
    <Persistent("keterangan")>
    Property Keterangan As String
      Get
        Return _Keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _Keterangan, value)
      End Set
    End Property
    <Persistent("tgl_serti")>
    Property TglSerti As Date
      Get
        Return _TglSerti
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglSerti", _TglSerti, value)
      End Set
    End Property
    <Persistent("no_serti")>
    Property NoSerti As String
      Get
        Return _NoSerti
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSerti", _NoSerti, value)
      End Set
    End Property
    <Persistent("tgl_serti_perpanjang")>
    Property TglSertiPerpanjang As Date
      Get
        Return _TglSertiPerpanjang
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglSertiPerpanjang", _TglSertiPerpanjang, value)
      End Set
    End Property
    <Persistent("tgl_medical_ulang")>
    Property TglMedicalUlang As Date
      Get
        Return _TglMedicalUlang
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglMedicalUlang", _TglMedicalUlang, value)
      End Set
    End Property
    <Persistent("tgl_medical_online")>
    Property TglMedicalOnline As Date
      Get
        Return _TglMedicalOnline
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglMedicalOnline", _TglMedicalOnline, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("dpaspor")> _
  Friend Class xPJPTKIPaspor
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _p_id As Int64
    Private _Main As xPJPTKI
    Private _TanggalPasporPengajuan As Date
    Private _TanggalPasporKeluar As Date
    Private _Nomor As String
    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _p_id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _p_id, value)
      End Set
    End Property
    <Persistent("tki"), Association("main_paspor")> Property Main As xPJPTKI
      Get
        Return _Main
      End Get
      Set(value As xPJPTKI)
        SetPropertyValue(Of xPJPTKI)("Main", _Main, value)
      End Set
    End Property
    <Persistent("tgl_pengajuan")>
    Property TanggalPasporPengajuan As Date
      Get
        Return _TanggalPasporPengajuan
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalPasporPengajuan", _TanggalPasporPengajuan, value)
      End Set
    End Property
    <Persistent("tgl_keluar")>
    Property TanggalPasporKeluar As Date
      Get
        Return _TanggalPasporKeluar
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalPasporKeluar", _TanggalPasporKeluar, value)
      End Set
    End Property
    <Persistent("nomor")>
    Property Nomor As String
      Get
        Return _Nomor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nomor", _Nomor, value)
      End Set
    End Property
    Protected Overrides Sub OnSaving()
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("dvisa")> _
  Friend Class xPJPTKIVisa
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(Session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _p_id As Int64
    Private _Main As xPJPTKI
    Private _TanggalJO As Date
    Private _TanggalKontrak As Date
    Private _TanggalVisa As Date
    Private _NoVisa As String
    Private _TanggalTETO As Date
    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _p_id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _p_id, value)
      End Set
    End Property
    <Persistent("tki"), Association("main_visa")> Property Main As xPJPTKI
      Get
        Return _Main
      End Get
      Set(value As xPJPTKI)
        SetPropertyValue(Of xPJPTKI)("Main", _Main, value)
      End Set
    End Property
    <Persistent("tgl_jo")>
    Property TanggalJO As Date
      Get
        Return _TanggalJO
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalJO", _TanggalJO, value)
      End Set
    End Property
    <Persistent("tgl_contract")>
    Property TanggalKontrak As Date
      Get
        Return _TanggalKontrak
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalKontrak", _TanggalKontrak, value)
      End Set
    End Property
    <Persistent("tgl_visa")>
    Property TanggalVisa As Date
      Get
        Return _TanggalVisa
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalVisa", _TanggalVisa, value)
      End Set
    End Property
    <Persistent("no_visa")>
    Property NoVisa As String
      Get
        Return _NoVisa
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoVisa", _NoVisa, value)
      End Set
    End Property
    <Persistent("tgl_teto")>
    Property TanggalTETO As Date
      Get
        Return _TanggalTETO
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalTETO", _TanggalTETO, value)
      End Set
    End Property
    Protected Overrides Sub OnSaving()
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("dpemberangkatan")> _
  Friend Class xPJPTKIPemberangkatan
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _p_id As Int64
    Private _Main As xPJPTKI
    Private _TanggalTiket As Date
    Private _TanggalBerangkat As Date
   <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _p_id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _p_id, value)
      End Set
    End Property
    <Persistent("tki"), Association("main_berangkat")> Property Main As xPJPTKI
      Get
        Return _Main
      End Get
      Set(value As xPJPTKI)
        SetPropertyValue(Of xPJPTKI)("Main", _Main, value)
      End Set
    End Property
    <Persistent("tgl_pesan_tiket")>
    Property TanggalTiket As Date
      Get
        Return _TanggalTiket
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalTiket", _TanggalTiket, value)
      End Set
    End Property
    <Persistent("tgl_berangkat")>
    Property TanggalBerangkat As Date
      Get
        Return _TanggalBerangkat
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerangkat", _TanggalBerangkat, value)
      End Set
    End Property
    Protected Overrides Sub OnSaving()
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("dskck")> _
  Friend Class xPJPTKISKCK
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(Session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _p_id As Int64
    Private _main As xPJPTKI
    Private _tgl_pengajuan As Date
    Private _tgl_keluar As Date
    Private _nomor As String
   <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _p_id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _p_id, value)
      End Set
    End Property
    <Persistent("tki"), Association("main_skck")> Property Main As xPJPTKI
      Get
        Return _Main
      End Get
      Set(value As xPJPTKI)
        SetPropertyValue(Of xPJPTKI)("Main", _Main, value)
      End Set
    End Property
    <Persistent("tgl_pengajuan")>
    Property TanggalPengajuan As Date
      Get
        Return _tgl_pengajuan
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("tgl_pengajuan", _tgl_pengajuan, value)
      End Set
    End Property
    <Persistent("tgl_keluar")>
    Property TanggalKeluar As Date
      Get
        Return _tgl_keluar
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("tgl_keluar", _tgl_keluar, value)
      End Set
    End Property
    <Persistent("nomor")>
    Property nomor As String
      Get
        Return _nomor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("nomor", _nomor, value)
      End Set
    End Property
    Protected Overrides Sub OnSaving()
      MyBase.OnSaving()
    End Sub
  End Class
End Namespace