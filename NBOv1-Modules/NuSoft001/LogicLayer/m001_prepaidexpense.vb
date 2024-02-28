Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m01cprepaidmain")>
  Friend Class PrepaidExpense
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("p_id"), Key(True)> Private _id As Int32
    Private _gl As GlMain
    Private _nilai As Double
    Private _tglawal As Date
    Private _umur As Int16
    Private _coaprepaid As Persistent.Coa
    Private _coabiaya As Persistent.Coa
    Private _coakasbank As Persistent.Coa

    <PersistentAlias("_id")> ReadOnly Property Id As Int32
      Get
        Return Convert.ToInt32(EvaluateAlias("Id"))
      End Get
    End Property
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property
    <Persistent("d_value")>
    Property Nilai As Double
      Get
        Return _nilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _nilai, value)
      End Set
    End Property
    <Persistent("d_startdate")>
    Property TanggalMulai As Date
      Get
        Return _tglawal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalMulai", _tglawal, value)
      End Set
    End Property
    <Persistent("d_age")>
    Property Umur As Int16
      Get
        Return _umur
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Umur", _umur, value)
      End Set
    End Property
    <Persistent("f_coaprepaid")>
    Property CoaPrepaid As NuSoft001.Persistent.Coa
      Get
        Return _coaprepaid
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaPrepaid", _coaprepaid, value)
      End Set
    End Property
    <Persistent("f_coaexpense")>
    Property CoaExpense As NuSoft001.Persistent.Coa
      Get
        Return _coabiaya
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaExpense", _coabiaya, value)
      End Set
    End Property
    <Persistent("f_coacashbank")>
    Property CoaKasBank As NuSoft001.Persistent.Coa
      Get
        Return _coakasbank
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaKasBank", _coakasbank, value)
      End Set
    End Property
    ReadOnly Property TanggalSelesai As Date
      Get
        Return TanggalMulai.AddMonths(Umur)
      End Get
    End Property
    ReadOnly Property NilaiPerBulan As Double
      Get
        Return Nilai / Umur
      End Get
    End Property
    ReadOnly Property Akumulasi As Double
      Get
        Return Detail.Where(Function(m) Not m.Gl Is Nothing).Sum(Function(n) n.Nilai)
      End Get
    End Property
    <Association("fk_prepaid_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PrepaidDetail)
      Get
        Return GetCollection(Of PrepaidDetail)("Detail")
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Prepaid Expense"
      If _gl Is Nothing Then
        Throw New Utils.Exception("Masukkan data yang valid", -1, "", source)
        Return False
      End If
      If _nilai = Nothing Then
        Throw New Utils.Exception("Masukkan nilai amortisasi", -2, "", source)
        Return False
      End If
      If _tglawal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal awal amortisasi", -3, "", source)
        Return False
      End If
      If _umur = Nothing Then
        Throw New Utils.Exception("Masukkan umur amortisasi", -4, "", source)
        Return False
      End If
      If _coaprepaid Is Nothing Then
        Throw New Utils.Exception("Masukkan akun biaya dibayar dimuka", -5, "", source)
        Return False
      End If
      If _coabiaya Is Nothing Then
        Throw New Utils.Exception("Masukkan akun biaya operasional", -6, "", source)
        Return False
      End If
      If _coakasbank Is Nothing Then
        Throw New Utils.Exception("Masukkan akun kas/bank", -7, "", source)
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

  <Persistent("m01dprepaidamortization")>
  Friend Class PrepaidDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("p_id"), Key(True)> Private _id As Int64
    Private _main As PrepaidExpense
    Private _urutan As Int16
    Private _tanggal As Date
    Private _nilai As Double
    Private _gl As GlMain

    <PersistentAlias("_id")> ReadOnly Property Id As Int64
      Get
        Return Convert.ToInt64(EvaluateAlias("Id"))
      End Get
    End Property
    <Persistent("f_main"), Association("fk_prepaid_detail")>
    Property Main As PrepaidExpense
      Get
        Return _main
      End Get
      Set(value As PrepaidExpense)
        SetPropertyValue(Of PrepaidExpense)("Main", _main, value)
      End Set
    End Property
    <Persistent("u_seq")>
    Property Urutan As Int16
      Get
        Return _urutan
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Urutan", _urutan, value)
      End Set
    End Property
    <Persistent("d_date")>
    Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
      End Set
    End Property
    <Persistent("d_value")>
    Property Nilai As Double
      Get
        Return _nilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _nilai, value)
      End Set
    End Property
    <Persistent("fk_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Prepaid Expense"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama Prepaid Expense", -99, "", source)
        Return False
      End If
      If _urutan = Nothing Then
        Throw New Utils.Exception("Masukkan urutan", -99, "", source)
        Return False
      End If
      If _tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -99, "", source)
        Return False
      End If
      If _nilai = Nothing Then
        Throw New Utils.Exception("Masukkan nilai", -99, "", source)
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
End Namespace