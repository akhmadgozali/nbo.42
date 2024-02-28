Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute

Namespace Persistent
  <Persistent("m01cmainprepayment")> _
  Friend Class PrePaymentMain
    Inherits TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(Session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _fReg As NPO.Modules.ModSys.Regional
    Private _Keterangan As String
    Private _Status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _catatanapp As String
    Private _kontak As Kontak
    <Persistent("f_reg")>
    Property fReg As NPO.Modules.ModSys.Regional
      Get
        Return _fReg
      End Get
      Set(value As NPO.Modules.ModSys.Regional)
        SetPropertyValue(Of NPO.Modules.ModSys.Regional)("fReg", _fReg, value)
      End Set
    End Property
    <Persistent("f_contact")>
    Property Kontak As Kontak
      Get
        Return _kontak
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Kontak", _kontak, value)
      End Set
    End Property
    <Persistent("d_note")>
    Property Keterangan As String
      Get
        Return _Keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _Keterangan, value)
      End Set
    End Property
    <Persistent("d_status")>
    Property Status As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _Status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("Status", _Status, value)
      End Set
    End Property
    <Persistent("d_remarksapp")>
    Property CatatanApprove As String
      Get
        Return _catatanapp
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("CatatanApprove", _catatanapp, value)
      End Set
    End Property
    <Association("fk_prepayment_detail"), Aggregated()> ReadOnly Property Detail As XPCollection(Of PrePaymentDetail)
      Get
        Return GetCollection(Of PrePaymentDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Prepayment"
      'If _Main Is Nothing AndAlso Not IsDeleted Then
      '  Throw New Utils.Exception("Masukkan data utama prepayment", -99, "", source)
      '  Return False
      'End If
      'If _Kontak Is Nothing Then
      '  Throw New Utils.Exception("Masukkan kode kontak", -99, "", source)
      '  Return False
      'End If
      'If _Nilai = Nothing Then
      '  Throw New Utils.Exception("Masukkan nilai", -99, "", source)
      '  Return False
      'End If
      If Detail.Count = 0 Then
        Throw New Utils.Exception("Masukkan detail transaksi", -99, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m01ddetailprepayment")> _
  Friend Class PrePaymentDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(Session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _Main As PrePaymentMain
    Private _Id As Int64
    Private _coa As Coa
    Private _Type As eTipePrepayment
    Private _Type2 As eTipePrepayment2
    Private _ReffNo As String
    Private _ReffNo2 As String
    Private _Kontak As Kontak
    Private _MataUang As MataUang
    Private _Nilai As Double
    Private _NilaiPPh23 As Double
    Private _Catatan As String
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_prepayment_detail")>
    Property Main As PrePaymentMain
      Get
        Return _Main
      End Get
      Set(value As PrePaymentMain)
        SetPropertyValue(Of PrePaymentMain)("Main", _Main, value)
      End Set
    End Property
    <Persistent("d_type")>
    Property Type As eTipePrepayment
      Get
        Return _Type
      End Get
      Set(value As eTipePrepayment)
        SetPropertyValue(Of eTipePrepayment)("Type", _Type, value)
      End Set
    End Property
    <Persistent("d_type2")>
    Property Type2 As eTipePrepayment2
      Get
        Return _Type2
      End Get
      Set(value As eTipePrepayment2)
        SetPropertyValue(Of eTipePrepayment2)("Type2", _Type2, value)
      End Set
    End Property
    <Persistent("f_coa")>
    Property Coa As Coa
      Get
        Return _coa
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Coa", _coa, value)
      End Set
    End Property
    <Persistent("d_reff")>
    Property ReffNo As String
      Get
        Return _ReffNo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ReffNo", _ReffNo, value)
      End Set
    End Property
    <Persistent("d_reff2")>
    Property ReffNo2 As String
      Get
        Return _ReffNo2
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ReffNo2", _ReffNo2, value)
      End Set
    End Property
    <Persistent("f_contact")>
    Property Kontak As Kontak
      Get
        Return _Kontak
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Kontak", _Kontak, value)
      End Set
    End Property
    <Persistent("f_currency")>
    Property MataUang As MataUang
      Get
        Return _MataUang
      End Get
      Set(value As MataUang)
        SetPropertyValue(Of MataUang)("MataUang", _MataUang, value)
      End Set
    End Property
    <Persistent("d_value")>
    Property Nilai As Double
      Get
        Return _Nilai
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Nilai", _Nilai, value)
      End Set
    End Property
    <Persistent("d_valuepph")>
    Property NilaiPPh23 As Double
      Get
        Return _NilaiPPh23
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiPPh23", _NilaiPPh23, value)
      End Set
    End Property
    <PersistentAlias("(Nilai - NilaiPPh23)")> ReadOnly Property Total As Double '
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <Persistent("d_note")>
    Property Catatan As String
      Get
        Return _Catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _Catatan, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Prepayment"
      If _Main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama prepayment", -99, "", source)
        Return False
      End If
      If _Kontak Is Nothing Then
        Throw New Utils.Exception("Masukkan kode kontak", -99, "", source)
        Return False
      End If
      If _Nilai = Nothing Then
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