Imports DevExpress.Xpo

Namespace Persistent.Report
	<Persistent("m01vwCustomReport")> Public Class LK
		Inherits XPLiteObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		<Key()> Property Id As Int64
		Property MainId As Int32
		Property Tipe As CustomReportTipe
		Property Urutan As Int16
		Property Nama As String
		Property Level As CustomReportLevel
		Property Tanda As String
		Property Akun As Coa
		Property Saldo As Nullable(Of Double)
		<NonPersistent()> Property Saldo2 As Nullable(Of Double)
    <NonPersistent()> Property Saldo3 As Nullable(Of Double)
    <PersistentAlias("Akun.Tipe.Id")> ReadOnly Property TipeAkun As Integer
      Get
        Return CInt(EvaluateAlias("TipeAkun"))
      End Get
    End Property

    ReadOnly Property TandaCF As CustomReportTandaCashFlow
			Get
				If Tanda = "+" Then
					Return CustomReportTandaCashFlow.Plus
				Else
					Return CustomReportTandaCashFlow.Minus
				End If
			End Get
		End Property
	End Class

	Public Class Neraca
		Property Id As Integer
		Property NamaAktiva As String
		Property SaldoAktiva As Nullable(Of Double)
		Property NamaPassiva As String
		Property SaldoPassiva As Nullable(Of Double)
		Property LevelAktiva As CustomReportLevel
		Property LevelPassiva As CustomReportLevel
	End Class
	Public Class CashFlow
		Property Id As Integer
		Property Nama As String
		Property Level As CustomReportLevel
		Property Saldo1 As Nullable(Of Double)
		Property Saldo2 As Nullable(Of Double)
		Property Saldo3 As Nullable(Of Double)
		ReadOnly Property JumlahSaldo As Nullable(Of Double)
			Get
				Return Saldo1 + Saldo2 + Saldo3
			End Get
		End Property
	End Class
	Public Class LampiranCashFlowTriwulan
		Property Id As Int64
		Property MainId As Int32
		Property Tipe As CustomReportTipe
		Property Urutan As Int16
		Property Nama As String
		Property Level As CustomReportLevel
		Property TandaCF As CustomReportTandaCashFlow
		Property Akun As Coa
		Property Saldo As Nullable(Of Double)
		Property Saldo2 As Nullable(Of Double)
		Property Saldo3 As Nullable(Of Double)

		ReadOnly Property JumlahSaldo As Nullable(Of Double)
			Get
				Return Saldo + Saldo2 + Saldo3
			End Get
		End Property
	End Class
	Public Class BukuBesarCashFlow
		Property MainId As Int32
		Property Nama As String
		Property Level As CustomReportLevel
		Property TandaCF As CustomReportTandaCashFlow
		Property Akun As Coa
		Property NamaAkun As String
		Property Tanggal As Date
		Property NoBukti As String
		Property Keterangan As String
		Property Saldo As Double
	End Class

	<Persistent("m01vwgl")> Public Class BukuBesar
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
		Property Proyek As Persistent.Proyek
		Property ProyekSub As Persistent.ProyekSub
		Property Divisi As NPO.Modules.ModSys.Divisi
		Property Regional As NPO.Modules.ModSys.Regional
		Property Catatan As String
	End Class
	<Persistent("m01vwpembantubank")> Public Class BukuBesarPembantuBank
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
    Property DebitValas As Double
    Property KreditValas As Double
    Property Keterangan As String
    Property Proyek As Persistent.Proyek
  End Class
  <Persistent("m01vwsaldo")> Public Class SaldoCOA
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property Id As Int64
    Property Tipe As Persistent.CoaLevel
    Property Kode As String
    Property Nama As String
    Property Induk As Coa
    Property Level As Int16
    Property Level1 As Coa
    Property Level2 As Coa
    Property Level3 As Coa
    Property Level4 As Coa
    Property Uang As Persistent.MataUang
    Property SaldoAwal As Double
    Property MutasiDebit As Double
    Property MutasiKredit As Double
    Property SaldoAkhir As Double
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
  End Class

  <Persistent("m01vwgl2")> Public Class vwGL
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property Id As Int64
    Property SumberData As String
    Property Tahun As Int32
    Property Bulan As Int32
    Property Tanggal As Date
    Property KodeKontak As String
    Property NamaKontak As String
    Property NoBukti As String
    Property AkunMainKode As String
    Property AkunMainNama As String
    Property AkunDetailKode As String
    Property AkunDetailNama As String
    Property Urutan As Int16
    Property SaldoAwal As Double
    Property Debit As Double
    Property Kredit As Double
    Property SaldoAwalValas As Double
    Property DebitValas As Double
    Property KreditValas As Double
    Property Kurs As Double
    Property Keterangan As String
    Property Regional As String
    Property Divisi As String
    Property Uang As String
  End Class


  <Persistent("m01varap")> Public Class SaldoARAP
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property f_coa As Persistent.Coa
    Property f_contact As Persistent.Kontak
    Property f_currency As Persistent.MataUang
    Property jumlah As Double
    Property bayar As Double
    Property jumlahvalas As Double
    Property bayarvalas As Double
    Property saldo As Double
    Property saldovalas As Double
  End Class
End Namespace