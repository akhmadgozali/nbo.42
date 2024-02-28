Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute

Namespace Logic
  Public Class Giro
    Shared Function SaveGiro(session As UnitOfWork, MataUangDefault As Integer, MataUang As Persistent.MataUang, Tanggal As Date, Kurs As Double) As Boolean
      Try
        If MataUang.Id <> MataUangDefault Then
          Dim criteria As CriteriaOperator = New GroupOperator(GroupOperatorType.And, New BinaryOperator("MataUang", MataUang, BinaryOperatorType.Equal), New BinaryOperator("Tanggal", Tanggal.ToString("yyyy-MM-dd"), BinaryOperatorType.Equal))
          Dim objKurs As Persistent.MataUangKurs = session.FindObject(Of Persistent.MataUangKurs)(criteria)
          If objKurs Is Nothing Then
            objKurs = New Persistent.MataUangKurs(session)
            objKurs.MataUang = MataUang
            objKurs.Tanggal = Tanggal
          End If
          objKurs.KursUang = Kurs
        End If

        Return True
      Catch ex As Exception
        Return False
      End Try
    End Function
  End Class
End Namespace

Namespace Persistent
  <Persistent("m01period")> Public Class Periode
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _Tahun As Int32
    Private _Bulan As Int32
    Private _Kunci As Boolean

    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("u_year")> Property Tahun As Int32
      Get
        Return _Tahun
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Tahun", _Tahun, value)
      End Set
    End Property
    <Persistent("u_month")> Property Bulan As Int32
      Get
        Return _Bulan
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Bulan", _Bulan, value)
      End Set
    End Property
    <Persistent("d_lock")> Property Kunci As Boolean
      Get
        Return _Kunci
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Kunci", _Kunci, value)
      End Set
    End Property

    <PersistentAlias("MonthName(_Bulan)")> _
    ReadOnly Property NamaBulan As String
      Get
        MonthName(2)
        Return EvaluateAlias("NamaBulan").ToString
      End Get
    End Property

    Shared Function CheckLockedPeriod(session As Session, tanggal As Date) As Boolean
      Dim a As Periode = session.FindObject(Of Periode)(DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("Tahun={0} and Bulan={1}", tanggal.Year, tanggal.Month)))

      Return Not a Is Nothing AndAlso a.Kunci = True
    End Function
    Shared Function CheckBeforeBeginningPeriod(session As UnitOfWork, tanggal As Date) As Boolean
      Dim setting = New Logic.FinaSetting(session)
      Dim awalPeriode = New DateTime(setting.AwalPeriodeTahun, setting.AwalPeriodeBulan, 1)
      Return CInt(awalPeriode.ToString("yyyyMM")) > CInt(tanggal.ToString("yyyyMM"))
    End Function
  End Class
  Enum KasBankKeluarTipe
    <EnumDescription("Non")> Non
    <EnumDescription("Cash Advance")> CashAdvance
    <EnumDescription("Prepaid Expense")> PrepaidExpense
  End Enum
  Enum BankCaraBayar
    <EnumDescription("Tunai")> Tunai
    <EnumDescription("Cek / Giro")> CekGiro
    <EnumDescription("Cek / Giro (Tempo)")> CekGiroTempo
    <EnumDescription("Transfer")> Transfer
    <EnumDescription("Lain-Lain")> LainLain
  End Enum
  Enum TipeReportNeraca
    <EnumDescription("Global")> xGlobal
    <EnumDescription("Per Regional")> xRegional
  End Enum
  Enum TipeReportLabaRugi
    <EnumDescription("Global")> xGlobal
    <EnumDescription("Per Regional")> xRegional
    <EnumDescription("Per Divisi")> xDivisi
    <EnumDescription("Per Proyek")> xProyek
  End Enum

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
		<Persistent("d_status")> Private _status As StatusTransaksiEnum
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
		<PersistentAlias("Detail.Sum(Debit - Kredit)")> ReadOnly Property Selisih As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("Selisih"))
			End Get
		End Property
		<PersistentAlias("Terbilang(Saldo)")> ReadOnly Property Terbilang As String
			Get
				Return Convert.ToString(EvaluateAlias("Terbilang"))
			End Get
		End Property
		'<PersistentAlias("Terbilang(Saldo,Akun.MataUang.Nama)")> ReadOnly Property TerbilangMataUang As String
		'  Get
		'    Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
		'  End Get
		'End Property
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
		<NonPersistent()> ReadOnly Property COAKAS As GlMainDetail
			Get
				Return Detail.Where(Function(w) w.Urutan = 0).FirstOrDefault
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
				Throw New Utils.Exception("Saldo tidak boleh nol (" & Detail.Count - 1 & ")", -7, "Periksa lagi transaksi anda", source & "-" & Kode)
				Return False
			End If
			If Detail.Sum(Function(m) m.Kredit) = 0 Then
				Throw New Utils.Exception("Saldo tidak boleh nol (" & Detail.Count - 1 & ")", -7, "Periksa lagi transaksi anda", source & "-" & Kode)
				Return False
			End If

			'======= Cek Seimbang
			Dim sumDebit As Double = Detail.Sum(Function(m) m.Debit)
			Dim sumKredit As Double = Detail.Sum(Function(m) m.Kredit)

			'Throw New Utils.Exception("Debit=" & sumDebit.ToString("n2") & vbCrLf & "Kredit=" & sumKredit.ToString("n2") & vbCrLf & "Jurnal tidak seimbang", -7, "Periksa lagi transaksi anda", source)
			If sumDebit.ToString("n4") <> sumKredit.ToString("n4") Then
				Dim xMessageJurnal As String = ""
				For i = 0 To Detail.Count - 1
					xMessageJurnal += i & ":" & Detail(i).Akun.Nama.ToString & " " & Detail(i).Debit.ToString("n2") & "~" & Detail(i).Kredit.ToString("n2") & vbCrLf
				Next
				Throw New Utils.Exception("No :" & Kode & vbCrLf & "Debit=" & sumDebit.ToString("n2") & vbCrLf & "Kredit=" & sumKredit.ToString("n2") & vbCrLf & "Jurnal tidak seimbang" & vbCrLf & vbCrLf & "Jurnal sistem : " & vbCrLf & xMessageJurnal, -7, "Periksa lagi transaksi anda", source)
				Return False
			End If

			'======= Cek Periode
			If Periode.CheckLockedPeriod(Session, Tanggal) Then
				Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
				Return False
			End If
			'======= Cek Sebelum Awal Periode
			If Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
				Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
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
		Private _urutan As UInt16
		Private _akun As Coa
		Private _debit As Double
		Private _kredit As Double
		Private _kurs As Double
		Private _divisi As NPO.Modules.ModSys.Divisi
		Private _proyek As Persistent.Proyek
		Private _matauang As Persistent.MataUang
		Private _debitv As Double

		Private _creditv As Double
		Private _keterangan As String
		Private _rekonsiliasi As Boolean

		<Persistent("p_id"), Association("m01cmaingl_detail")> Property Main As GlMain
			Get
				Return _main
			End Get
			Set(value As GlMain)
				SetPropertyValue(Of GlMain)("Main", _main, value)
			End Set
		End Property
		<Persistent("p_order")> Property Urutan As UInt16
			Get
				Return _urutan
			End Get
			Set(value As UInt16)
				SetPropertyValue(Of UInt16)("Urutan", _urutan, value)
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
		<NonPersistent()> ReadOnly Property SaldoDebit As Double
			Get
				If Session.IsObjectToDelete(Me) Then
					Return 0
				Else
					Return _debit
				End If
			End Get
		End Property
		<NonPersistent()> ReadOnly Property SaldoKredit As Double
			Get
				If Session.IsObjectToDelete(Me) Then
					Return 0
				Else
					Return _kredit
				End If
			End Get
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
			If _debit = Nothing AndAlso _kredit = Nothing AndAlso Not IsDeleted Then
				Throw New Utils.Exception("#" & _urutan & " Masukkan nilai debit/kredit", -3, "", source)
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

  <Persistent("m01vwcashadvanceremain")>
  Public Class SisaCashAdvance
    Inherits XPLiteObject

    Public Sub New()
    End Sub
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("p_id"), Key> Property Id As Long
    <Persistent("u_code")> Property Kode As String
    <Persistent("d_date")> Property Tanggal As Date
    <Persistent("d_contact")> Property Kontak As String
  End Class

  <Persistent("m01vwgiro")> Friend Class ViewGiro
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property Id As Int64
    Property NoBukti As GlMain
    Property NoBuktiCair As GlMain
    Property CoaGiro As Coa
    Property Uang As MataUang
    Property NoGiro As String
    Property Bank As String
    Property NoACBank As String
    Property TglJatuhTempo As Date
    Property Nilai As Double
    Property Kurs As Double
    Property Status As Boolean
    Property Tipe As eJenisGiro
    Property SelisihHari As Int32
    Property SelisihHariNama As String
  End Class



  <Persistent("m01vwzcashflow")> Friend Class xViewCashFlow
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As GlMainDetail
    Property main As GlMain
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
  <Persistent("m01vwzcashflowreport")> Friend Class xCashFlowG
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
	<Persistent("m01vwzcashflowreportdetail")> Friend Class xCashFlowD
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



	<Persistent("m01vwproyek")> Friend Class ViewProyek
		Inherits XPLiteObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		<Key()> Property Id As Int64
		Property Proyek As Proyek
		Property Pendapatan As Double
		Property Biaya As Double
	End Class
End Namespace