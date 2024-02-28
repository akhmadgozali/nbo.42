Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m01cmaingl")>
  Friend Class GlMain
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("f_reg")> Private _regional As NPO.Modules.ModSys.Regional
    <Persistent("f_source")> Private _sumberData As NPO.Modules.ModSys.SumberData
    <Persistent("f_coa")> Private _akun As NuSoft001.Persistent.Coa
    Private _kontak As NuSoft001.Persistent.Kontak
    Private _kontakNama As String
    'Private _tipe As NuSoft001.Persistent.KasBankKeluarTipe
    Private _uraian As String
    'Private _caraBayar As NuSoft001.Persistent.BankCaraBayar
    Private _mataUang As String
    Private _kurs As Double
    Private _catatan As String
    Private _tanggalRekonsiliasi As Date
    Private _cashAdvance As GlMain
    Private _moduleId As NPO.Modules.ModuleId
    <Persistent("d_status")> Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    <Persistent("d_director")> Private _direktur As String
    <Persistent("d_accounting")> Private _akunting As String
    <Persistent("d_cashier")> Private _kasir As String

    <Persistent("f_contact")> Property Kontak As NuSoft001.Persistent.Kontak
      Get
        Return _kontak
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Kontak", _kontak, value)
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
    '<Persistent("d_type")> Property Tipe As NuSoft001.Persistent.KasBankKeluarTipe
    '  Get
    '    Return _tipe
    '  End Get
    '  Set(value As NuSoft001.Persistent.KasBankKeluarTipe)
    '    SetPropertyValue(Of KasBankKeluarTipe)("Tipe", _tipe, value)
    '  End Set
    'End Property
    <Persistent("d_description"), Size(255)> Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    '<Persistent("d_payment")> Property CaraBayar As BankCaraBayar
    '  Get
    '    Return _caraBayar
    '  End Get
    '  Set(value As BankCaraBayar)
    '    SetPropertyValue(Of BankCaraBayar)("CaraBayar", _caraBayar, value)
    '  End Set
    'End Property
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
    <Persistent("x_module")> Property ModuleId As NPO.Modules.ModuleId
      Get
        Return _moduleId
      End Get
      Set(value As NPO.Modules.ModuleId)
        SetPropertyValue(Of NPO.Modules.ModuleId)("ModuleId", _moduleId, value)
      End Set
    End Property
    <Association("m01cmaingl_detail"), Aggregated()> ReadOnly Property Detail As XPCollection(Of GlMainDetail)
      Get
        Return GetCollection(Of GlMainDetail)("Detail")
      End Get
    End Property
    <Association("m01cmaingl_giro"), Aggregated()> ReadOnly Property Giro As XPCollection(Of GlGiro)
      Get
        Return GetCollection(Of GlGiro)("Giro")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Debit)")> ReadOnly Property Saldo As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Saldo"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Saldo)")> ReadOnly Property Terbilang As String
      Get
        Return Convert.ToString(EvaluateAlias("Terbilang"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Saldo,Akun.MataUang.Nama)")> ReadOnly Property TerbilangMataUang As String
      Get
        Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
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
    <PersistentAlias("Detail.Sum(NilaiPersediaanAlias)")> ReadOnly Property NilaiPersediaanAlias As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiPersediaanAlias"))
      End Get
    End Property

    ReadOnly Property NilaiPersediaan As Double
      Get
        Return Detail.Where(Function(w) w.Akun.Tipe.Id = 4).Sum(Function(x) x.Debit + x.Kredit)
      End Get
    End Property


    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
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

      '======= Cek Nol
      'If Detail.Sum(Function(m) m.Debit) = 0 Then
      '  Throw New Utils.Exception("Saldo tidak boleh nol", -7, "Periksa lagi transaksi anda", source)
      '  Return False
      'End If
      'If Detail.Sum(Function(m) m.Kredit) = 0 Then
      '  Throw New Utils.Exception("Saldo tidak boleh nol", -7, "Periksa lagi transaksi anda", source)
      '  Return False
      'End If

      '======= Cek Seimbang
      Dim sumDebit As Double = Detail.Sum(Function(m) m.Debit)
      Dim sumKredit As Double = Detail.Sum(Function(m) m.Kredit)
      If sumDebit.ToString("n4") <> sumKredit.ToString("n4") Then
        Throw New Utils.Exception("Debit=" & sumDebit & vbCrLf & "Kredit=" & sumKredit & vbCrLf & "Jurnal tidak seimbang", -7, "Periksa lagi transaksi anda", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not Session.IsObjectToDelete(Me) Then
        If Not CheckData() Then
          Return
        End If
      End If

      _regional = Regional
      _sumberData = Sumber

      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If

      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m01dmaindetail")>
  Friend Class GlMainDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("primary_main"), Key(True), Indexed("Main;Urutan", Unique:=True)> Private _id As Int64
    Private _main As GlMain
    Private _urutan As Byte
    Private _akun As NuSoft001.Persistent.Coa
    Private _debit As Double
    Private _kredit As Double
    Private _kurs As Double
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _matauang As NuSoft001.Persistent.MataUang
    Private _debitv As Double
    Private _creditv As Double
    Private _keterangan As String
    Private _rekonsiliasi As Boolean
    Private _proyek As NuSoft001.Persistent.Proyek

    <Persistent("p_id"), Association("m01cmaingl_detail")> Property Main As GlMain
      Get
        Return _main
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Main", _main, value)
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
    <Persistent("f_coa")> Property Akun As NuSoft001.Persistent.Coa
      Get
        Return _akun
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("Akun", _akun, value)
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
    <Persistent("f_currency")> Property MataUang As NuSoft001.Persistent.MataUang
      Get
        Return _matauang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _matauang, value)
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
    <Persistent("f_proyek")> Property Proyek As NuSoft001.Persistent.Proyek
      Get
        Return _proyek
      End Get
      Set(value As NuSoft001.Persistent.Proyek)
        SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
      End Set
    End Property
    <PersistentAlias("Iif(Akun.Tipe.Id = 4, Debit + Kredit, 0)")> ReadOnly Property NilaiPersediaanAlias As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiPersediaanAlias"))
      End Get
    End Property

    ReadOnly Property NilaiPersediaan As Double
			Get
				If Akun.Tipe.Jenis = NuSoft001.Persistent.CoaEnum.eKind.Persediaan Then
					Return Debit + Kredit
				Else
					Return 0
				End If
			End Get
		End Property


		Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan property main urutan ke " & _urutan, -1, "", source)
        Return False
      End If
      If _akun Is Nothing Then
        Throw New Utils.Exception("Masukkan akun", -2, "", source)
        Return False
      End If
      'If _debit = Nothing AndAlso _kredit = Nothing Then
      '  Throw New Utils.Exception("Masukkan nilai debit/kredit", -3, "", source)
      '  Return False
      'End If

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
  Friend Class GlGiro
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("primary_main"), Key(True), Indexed("Main", Unique:=True)> Private _id As Int64
    Private _main As GlMain
    Private _maincair As GlMain
    Private _coagiro As NuSoft001.Persistent.Coa
    Private _uang As NuSoft001.Persistent.MataUang
    Private _nogiro As String
    Private _bank As String
    Private _bankacno As String
    Private _jatuhtempo As Date
    Private _nilai As Double
    Private _kurs As Double
    Private _status As Boolean

    <Persistent("p_id"), Association("m01cmaingl_giro")> Property Main As GlMain
      Get
        Return _main
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_idsetlement")> Property TransaksiCair As GlMain
      Get
        Return _maincair
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("TransaksiCair", _maincair, value)
      End Set
    End Property
    <Persistent("f_coagiro")> Property CoaGiro As NuSoft001.Persistent.Coa
      Get
        Return _coagiro
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaGiro", _coagiro, value)
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
End Namespace

