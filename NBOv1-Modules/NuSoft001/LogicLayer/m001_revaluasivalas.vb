Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m01crevalmain")>
  Friend Class RevaluasiValas
    Inherits TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _coa As Persistent.Coa
    Private _kontak As Persistent.Kontak
    <Persistent("f_coa")> Property CoaSelisihKurs As Coa
      Get
        Return _coa
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("CoaSelisihKurs", _coa, value)
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
    <Association("fk_reval_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of RevalDetail)
      Get
        Return GetCollection(Of RevalDetail)("Detail")
      End Get
    End Property
    <Association("fk_reval_coa"), Aggregated> ReadOnly Property Coa As XPCollection(Of RevalCoa)
      Get
        Return GetCollection(Of RevalCoa)("Coa")
      End Get
    End Property
    <Association("fk_reval_uang"), Aggregated> ReadOnly Property Uang As XPCollection(Of RevalUang)
      Get
        Return GetCollection(Of RevalUang)("Uang")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Revaluasi Valas"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Sumber Is Nothing Then
        Throw New Utils.Exception("Masukkan sumberdata", -2, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
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
  <Persistent("m01drevaldetail")>
  Friend Class RevalDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.RevaluasiValas
    Private _coa As Persistent.Coa
    Private _kontak As Persistent.Kontak
    Private _nilaivalas As Double
    Private _nilaifungsional As Double
    Private _nilaikurs As Double
    Private _gl As GlMain
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_reval_detail")>
    Property Main As RevaluasiValas
      Get
        Return _main
      End Get
      Set(value As RevaluasiValas)
        SetPropertyValue(Of RevaluasiValas)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_coa")> Property Coa As Coa
      Get
        Return _coa
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Coa", _coa, value)
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
    <Persistent("d_valuevalas")> Property NilaiValas As Double
      Get
        Return _nilaivalas
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiValas", _nilaivalas, value)
      End Set
    End Property
    <Persistent("d_value")> Property NilaiFungsional As Double
      Get
        Return _nilaifungsional
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiFungsional", _nilaifungsional, value)
      End Set
    End Property
    <Persistent("d_kurs")> Property NilaiKurs As Double
      Get
        Return _nilaikurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiKurs", _nilaikurs, value)
      End Set
    End Property
    <PersistentAlias("(NilaiValas * NilaiKurs) - NilaiFungsional ")> ReadOnly Property NilaiSelisih As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiSelisih"))
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
    Private Function CheckData() As Boolean
      Dim source As String = "Revaluasi Valas"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama Revaluasi Valas", -99, "", source)
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
  <Persistent("m01drevalkurs")>
  Friend Class RevalUang
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.RevaluasiValas
    Private _uang As Persistent.MataUang
    Private _kurs As Double
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_reval_uang")>
    Property Main As RevaluasiValas
      Get
        Return _main
      End Get
      Set(value As RevaluasiValas)
        SetPropertyValue(Of RevaluasiValas)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_currency")> Property Uang As MataUang
      Get
        Return _uang
      End Get
      Set(value As MataUang)
        SetPropertyValue(Of MataUang)("Coa", _uang, value)
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
    Private Function CheckData() As Boolean
      Dim source As String = "Revaluasi Valas"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama Revaluasi Valas", -99, "", source)
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
  <Persistent("m01drevalcoa")>
  Friend Class RevalCoa
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.RevaluasiValas
    Private _coa As Persistent.Coa
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_reval_coa")>
    Property Main As RevaluasiValas
      Get
        Return _main
      End Get
      Set(value As RevaluasiValas)
        SetPropertyValue(Of RevaluasiValas)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_coa")> Property Coa As Coa
      Get
        Return _coa
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Coa", _coa, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Revaluasi Valas"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama Revaluasi Valas", -99, "", source)
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