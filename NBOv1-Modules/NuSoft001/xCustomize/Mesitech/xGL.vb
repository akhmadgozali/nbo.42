Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  Public Enum xMesitechStatusTransaksiEnum
    <EnumDescription("Draft/Pending")> Pending = 0
    <EnumDescription("Verifikasi")> Verifikasi = 1
  End Enum

  <Persistent("m01cinvoice")> _
  Public Class InvoiceMesitech
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _Nomor As String
    Private _Tanggal As Date
    Private _Nilai As Double
    
    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_kode")> Property Nomor As String
      Get
        Return _Nomor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nomor", _Nomor, value)
      End Set
    End Property
    <Persistent("d_tanggal")> Property Tanggal As Date
      Get
        Return _Tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _Tanggal, value)
      End Set
    End Property
    <Persistent("d_nilai")> Property Nilai As Double
      Get
        Return _Nilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _Nilai, value)
      End Set
    End Property
  End Class

  <Persistent("m01cmaingl")>
  Friend Class xMesitechGLMain
    Inherits TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("f_reg")> Private _regional As NPO.Modules.ModSys.Regional
    <Persistent("f_source")> Private _sumberData As NPO.Modules.ModSys.SumberData
    '<Persistent("f_coa")> Private _akun As Coa
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
    Private _activity As String
    Private _jobcode As String
    Private _workorder As String
    Private _mengajukan As String
    Private _invoiceno As String
    Private _invoicevalue As Double
    Private _invoiceduedate As Date
    Private _glrealisasiapp As xMesitechGlDetail
    Private _status As xMesitechStatusTransaksiEnum

    '<Persistent("d_status")> Private _status As StatusTransaksiEnum
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
    <Persistent("d_activity"), Size(50)> Property Activity As String
      Get
        Return _activity
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Activity", _activity, value)
      End Set
    End Property
    <Persistent("d_jobcode"), Size(50)> Property JobCode As String
      Get
        Return _jobcode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("JobCode", _jobcode, value)
      End Set
    End Property
    <Persistent("d_workorder"), Size(50)> Property WorkOrder As String
      Get
        Return _workorder
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("WorkOrder", _workorder, value)
      End Set
    End Property
    <Persistent("d_mengajukan"), Size(50)> Property Mengajukan As String
      Get
        Return _mengajukan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Mengajukan", _mengajukan, value)
      End Set
    End Property
    <Persistent("d_invoiceno"), Size(50)> Property InvoiceNo As String
      Get
        Return _invoiceno
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("InvoiceNo", _invoiceno, value)
      End Set
    End Property
    <Persistent("d_invoicevalue")> Property InvoiceValue As Double
      Get
        Return _invoicevalue
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InvoiceNo", _invoicevalue, value)
      End Set
    End Property
    <Persistent("d_invoiceduedate")> Property InvoiceDueDate As Date
      Get
        Return _invoiceduedate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("InvoiceDueDate", _invoiceduedate, value)
      End Set
    End Property
    <Persistent("f_glrealisasiapp")> Property RealisasiGL As xMesitechGlDetail
      Get
        Return _glrealisasiapp
      End Get
      Set(value As xMesitechGlDetail)
        SetPropertyValue(Of xMesitechGlDetail)("RealisasiGL", _glrealisasiapp, value)
      End Set
    End Property
    <Persistent("d_status")> Property Status As xMesitechStatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As xMesitechStatusTransaksiEnum)
        SetPropertyValue(Of xMesitechStatusTransaksiEnum)("Status", _status, value)
      End Set
    End Property
    <Association("m01cmaingl_detail"), Aggregated()> ReadOnly Property Detail As XPCollection(Of xMesitechGlDetail)
      Get
        Return GetCollection(Of xMesitechGlDetail)("Detail")
      End Get
    End Property
    <Association("m01cmaingl_giro"), Aggregated()> ReadOnly Property Giro As XPCollection(Of xMesitechGlGiro)
      Get
        Return GetCollection(Of xMesitechGlGiro)("Giro")
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
        _status = xMesitechStatusTransaksiEnum.Pending
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m01dmaindetail")>
  Friend Class xMesitechGlDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("primary_main"), Key(True), Indexed("Main;Urutan", Unique:=True)> Private _id As Int64
    Private _main As xMesitechGLMain
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
    Private _idInvoice As InvoiceMesitech
    Private _invoiceDBMutasi As Double
    Private _invoiceCRMutasi As Double

    <Persistent("p_id"), Association("m01cmaingl_detail")> Property Main As xMesitechGLMain
      Get
        Return _main
      End Get
      Set(value As xMesitechGLMain)
        SetPropertyValue(Of xMesitechGLMain)("Main", _main, value)
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
    <Persistent("f_appid")> Property NomorAPP As xMesitechGLMain
      Get
        Return _appnumber
      End Get
      Set(value As xMesitechGLMain)
        SetPropertyValue(Of xMesitechGLMain)("NomorAPP", _appnumber, value)
      End Set
    End Property
    <Persistent("d_mutasidbapp")> Property DBMutasiAPP As Double
      Get
        Return _dbmutasiapp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DBMutasiAPP", _dbmutasiapp, value)
      End Set
    End Property
    <Persistent("d_bplain")> Property BPLain As Double
      Get
        Return _bplain
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BPLain", _bplain, value)
      End Set
    End Property
    <PersistentAlias("DBMutasiAPP+BPLain")> ReadOnly Property BersihDibayar As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("BersihDibayar"))
      End Get
    End Property

    <Persistent("d_invoicemutasidb")> Property InvoiceDBMutasi As Double
      Get
        Return _invoiceDBMutasi
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InvoiceDBMutasi", _invoiceDBMutasi, value)
      End Set
    End Property
    <Persistent("d_invoicemutasicr")> Property InvoiceCRMutasi As Double
      Get
        Return _invoiceCRMutasi
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InvoiceCRMutasi", _invoiceCRMutasi, value)
      End Set
    End Property
    <PersistentAlias("Invoice.Nilai-InvoiceDBMutasi+InvoiceCRMutasi")> ReadOnly Property InvoiceBersihDibayar As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("InvoiceBersihDibayar"))
      End Get
    End Property

    <Persistent("f_invoice")> Property Invoice As InvoiceMesitech
      Get
        Return _idInvoice
      End Get
      Set(value As InvoiceMesitech)
        SetPropertyValue(Of InvoiceMesitech)("Invoice", _idInvoice, value)
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
      'If _divisi Is Nothing AndAlso Not IsDeleted Then
      '  Throw New Utils.Exception("Masukkan Divisi", -2, "", source)
      '  Return False
      'End If
      'If _proyek Is Nothing AndAlso Not IsDeleted Then
      '  Throw New Utils.Exception("Masukkan Proyek", -2, "", source)
      '  Return False
      'End If
      'If _proyeksub Is Nothing AndAlso Not IsDeleted Then
      '  Throw New Utils.Exception("Masukkan Proyek Sub", -2, "", source)
      '  Return False
      'End If
      If _divisi Is Nothing AndAlso Not IsDeleted Then
        If _proyek Is Nothing AndAlso Not IsDeleted Then
          Throw New Utils.Exception("Masukkan Proyek atau divisi.", -2, "", source)
          Return False
        End If
      End If
      If Not _proyek Is Nothing And _proyeksub Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan Proyek Sub", -2, "", source)
        Return False
      End If
      If Not _divisi Is Nothing AndAlso Not IsDeleted Then
        If Not _proyek Is Nothing AndAlso Not IsDeleted Then
          Throw New Utils.Exception("Harap mengisi salah satu dari Divisi atau Proyek.", -2, "", source)
          Return False
        End If
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
  Friend Class xMesitechGlGiro
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("primary_main"), Key(True), Indexed("Main", Unique:=True)> Private _id As Int64
    Private _main As xMesitechGLMain
    Private _maincair As xMesitechGLMain
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

    <Persistent("p_id"), Association("m01cmaingl_giro")> Property Main As xMesitechGLMain
      Get
        Return _main
      End Get
      Set(value As xMesitechGLMain)
        SetPropertyValue(Of xMesitechGLMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_idsetlement")> Property TransaksiCair As xMesitechGLMain
      Get
        Return _maincair
      End Get
      Set(value As xMesitechGLMain)
        SetPropertyValue(Of xMesitechGLMain)("TransaksiCair", _maincair, value)
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

  <Persistent("m01vwzglapp")> Friend Class xMesitechViewGL
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property Main As xMesitechGLMain
    Property Urutan As Integer
    Property Debit As Double
    Property Kredit As Double
    Property Kurs As Double
    Property MataUang As MataUang
    Property DebitValas As Double
    Property KreditValas As Double
    Property Divisi As NPO.Modules.ModSys.Divisi
    Property Keterangan As String
    Property Rekonsiliasi As Boolean
    Property Proyek As Proyek
    Property ProyekSub As ProyekSub
    Property NomorAPP As xMesitechGLMain
    Property DBMutasiAPP As Double
    Property BPLain As Double
    Property BersihDibayar As Double
    Property KodeCOA As String
    Property NamaCOA As String
    Property AccountAplied As Coa
  End Class
  <Persistent("m01vwGL")> Public Class xMesitechBukuBesar
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

  <Persistent("m01vwzcashflow")> Friend Class xMesitechViewCashFlow
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As xMesitechGlDetail
    Property main As xMesitechGLMain
    Property coakasbank As Coa
    Property debit As Double
    Property credit As Double
    Property type As String
    Property coalawan As Coa
    Property Tanggal As Date
    Property NoTransaksi As String
    Property Bulan As Integer
    Property Divisi As NPO.Modules.ModSys.Divisi
    Property Proyek As Proyek
    Property ProyekSub As ProyekSub
    Property JmlDebit As Integer
    Property JmlKredit As Integer
    Property JmlKredit2 As Integer
    Property Keterangan As String
    Property Uraian As String
  End Class
  <Persistent("m01vwzcashflowreport")> Friend Class xMesitechCashFlowG
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int32
    Property Kode As String
    Property Tipe As Integer
    Property Urutan As Short
    Property Nama As String
    Property Asign As String
    Property Saldo As Double
  End Class
  <Persistent("m01vwzcashflowreportdetail")> Friend Class xMesitechCashFlowD
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int32
    Property Tipe As Integer
    Property Urutan As Short
    Property Nama As String
    Property Asign As String
    Property COA As Coa
    Property Debit As Double
    Property Kredit As Double
    Property NoTransaksi As String
    Property Tanggal As Date
    Property Divisi As String
    Property Project As String
    Property ProjectSub As String
    Property Level As Int16
    Property Level1 As Coa
    Property Level2 As Coa
    Property Level3 As Coa
    Property Level4 As Coa
    Property m1 As Double
    Property m2 As Double
    Property m3 As Double
    Property m4 As Double
    Property m5 As Double
    Property m6 As Double
    Property m7 As Double
    Property m8 As Double
    Property m9 As Double
    Property m10 As Double
    Property m11 As Double
    Property m12 As Double
    Property Keterangan As String
    Property Uraian As String
  End Class

  <Persistent("m01vwinvoice")> Friend Class xMesitechViewInvoice
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property noinvoice As String
    Property tglinvoice As Date
    Property nodokmemo As String
    Property tgldokmemo As Date
    Property kodeproject As String
    Property namaproject As String
    Property nilaiinvoice As Double
    Property vbdeskripsi As String
    Property vbnodok As String
    Property vbtgl As Date
    Property vbmutasidebit As Double
    Property vbmutasikredit As Double
    Property vbmutasiditerima As Double
  End Class
End Namespace