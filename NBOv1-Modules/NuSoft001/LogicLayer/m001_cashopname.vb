Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO

Namespace Persistent
  <Persistent("m01ccashopname")>
  Public Class CashOpname
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _tanggal As Date
    Private _akun As Coa
    Private _total As Double
    Private _keterangan As String

    <PersistentAlias("GetYear(Tanggal)")> ReadOnly Property Tahun As Integer
      Get
        Return Convert.ToInt32(EvaluateAlias("Tahun"))
      End Get
    End Property
    <PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property

    <Persistent("p_id"), Key(True), Indexed("Tanggal;Akun", Unique:=True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_date")> Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
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
    <Persistent("d_value")> Property Total As Double
      Get
        Return _total
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Total", _total, value)
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

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub
    Private Function CheckData() As Boolean
      Const source As String = "Cash Opname"
      If _tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal cash opname", -1, "", source)
        Return False
      End If
      If _akun Is Nothing Then
        Throw New Utils.Exception("Masukkan akun yang akan dihitung cash opname", -2, "", source)
        Return False
      End If
      If _total = Nothing Then
        Throw New Utils.Exception("Masukkan total nilai cash opname", -2, "", source)
        Return False
      End If

      Return True
    End Function
  End Class
End Namespace