Imports DevExpress.Xpo

Namespace NuSoft.NPO.Modules.m02.Report
  <Persistent("m02vwCustomReport")> Public Class LK
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
End Namespace