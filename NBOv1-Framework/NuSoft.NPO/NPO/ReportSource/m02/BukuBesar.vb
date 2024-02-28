Imports DevExpress.Xpo

Namespace NuSoft.NPO.Modules.m02.Report
  <Persistent("m02vwGL")> Public Class BukuBesar
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property Id As Int64
    Property SumberData As SumberData
    Property Tahun As Int32
    Property Bulan As Int32
    Property Tanggal As Date
    Property NoBukti As String
    Property AkunMain As Coa
    Property Ext As Boolean
    Property AkunDetail As Coa
    Property Urutan As Int16
    Property SaldoAwal As Double
    Property Debit As Double
    Property Kredit As Double
    Property Keterangan As String
  End Class
End Namespace