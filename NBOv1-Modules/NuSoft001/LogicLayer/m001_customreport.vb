Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.Metadata
Imports NuSoft.NPO

Namespace Persistent
	Public Enum CustomReportTipe
		NeracaAktiva = 1
		NeracaPassiva = 2
		LabaRugi = 3
		HPP = 4
		CashFlow = 5
    PerbandinganNeraca = 6
    NeracaCOA = 7
    LabaRugiCOA = 8
    NeracaSaldoCOA = 9
    LabaRugiCOASummary = 10
	End Enum
	Public Enum CustomReportLevel
		HEADER = 0
		DETAIL = 1
		TOTAL = 2
		SUBTOTAL = 3
		SALDOAWAL = 4
		SALDOAKHIR = 5
		SALDOKHUSUS = 6
	End Enum
	Public Enum CustomReportTandaCashFlow
		Plus
		Minus
	End Enum

	<Persistent("m01zcustomreport")>
	Public Class CustomReportMain
		Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

		<Persistent("p_id"), Key(), Indexed("Tipe;Kode", Unique:=True)> Private _id As Int32
		Private _tipe As CustomReportTipe
		Private _kode As Short
		Private _urutan As Short
		Private _nama As String
		Private _level As CustomReportLevel
		Private _spasi As Byte
		Private _cashFlowTanda As CustomReportTandaCashFlow
		<Persistent("d_sign")> Private _tanda As String

		Protected Overrides Sub OnSaving()
			_id = CInt(_tipe & _kode.ToString("00"))
			MyBase.OnSaving()
		End Sub

		ReadOnly Property Id As Int32
			Get
				Return _id
			End Get
		End Property
		<Persistent("u_kind")> Property Tipe As CustomReportTipe
			Get
				Return _tipe
			End Get
			Set(value As CustomReportTipe)
				SetPropertyValue(Of CustomReportTipe)("Tipe", _tipe, value)
			End Set
		End Property
		<Persistent("u_code")> Property Kode As Short
			Get
				Return _kode
			End Get
			Set(value As Short)
				SetPropertyValue(Of Short)("Kode", _kode, value)
			End Set
		End Property
		<Persistent("d_order")> Property Urutan As Short
			Get
				Return _urutan
			End Get
			Set(value As Short)
				SetPropertyValue(Of Short)("Urutan", _urutan, value)
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
		<Persistent("d_level")> Property Level As CustomReportLevel
			Get
				Return _level
			End Get
			Set(value As CustomReportLevel)
				SetPropertyValue(Of CustomReportLevel)("Level", _level, value)
			End Set
		End Property
		<Persistent("d_space")> Property Spasi As Byte
			Get
				Return _spasi
			End Get
			Set(value As Byte)
				SetPropertyValue(Of Byte)("Spasi", _spasi, value)
			End Set
		End Property
		<NonPersistent()> Property CashFlowTanda As CustomReportTandaCashFlow
			Get
				If _tanda = "+" Then
					Return CustomReportTandaCashFlow.Plus
				Else
					Return CustomReportTandaCashFlow.Minus
				End If
			End Get
			Set(value As CustomReportTandaCashFlow)
				If value = CustomReportTandaCashFlow.Plus Then
					_tanda = "+"
				Else
					_tanda = "-"
				End If
				SetPropertyValue(Of CustomReportTandaCashFlow)("CashFlowTanda", _cashFlowTanda, value)
			End Set
		End Property

		<Association("CustomReportMain-Detail")> ReadOnly Property Detail As XPCollection(Of CustomReportDetail)
			Get
				Return GetCollection(Of CustomReportDetail)("Detail")
			End Get
		End Property

		''===== Used for Report
		'<NonPersistent()> Private _saldo As Double
		'<NonPersistent()> Property Saldo As Double
		'  Get
		'    If Level = CustomReportLevel.DETAIL Then
		'      Return Detail.Sum(Function(m) m.Saldo)
		'    Else
		'      Return _saldo
		'    End If
		'  End Get
		'  Set(value As Double)
		'    _saldo = value
		'  End Set
		'End Property
	End Class

	<Persistent("m01zcustomreportdetail")>
	Public Class CustomReportDetail
		Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

		<Persistent("p_id"), Key(), Indexed("Akun;Main", Unique:=True)> Private _id As Int32
		Private _akun As Coa
		Private _main As CustomReportMain

		Protected Overrides Sub OnSaving()
			_id = CInt(_main.Id & _akun.Id.ToString("000"))
			MyBase.OnSaving()
		End Sub

		<Persistent("f_coa")> Property Akun As Coa
			Get
				Return _akun
			End Get
			Set(value As Coa)
				SetPropertyValue(Of Coa)("Akun", _akun, value)
			End Set
		End Property
		<Association("CustomReportMain-Detail"), Persistent("f_main")> Property Main As CustomReportMain
			Get
				Return _main
			End Get
			Set(value As CustomReportMain)
				SetPropertyValue(Of CustomReportMain)("Main", _main, value)
			End Set
		End Property

		''===== Used for Report
		'<NonPersistent()> Property Saldo As Double
	End Class
End Namespace