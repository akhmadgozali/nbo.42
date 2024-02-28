Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m01cpaymentreqmain")>
  Friend Class PengajuanDana
    Inherits TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _kontak As Kontak
    Private _status As StatusTransaksiEnum
    Private _jatuhTempo As Date
    Private _keterangan As String
    Private _akun As Coa
    Private _freg As NPO.Modules.ModSys.Regional
    Private _Gl As GlMain
    <Persistent("f_contact")>
    Property Kontak As Kontak
      Get
        Return _kontak
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Kontak", _kontak, value)
      End Set
    End Property
    <Persistent("f_coa")>
    Property fCOA As Coa
      Get
        Return _akun
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("fCOA", _akun, value)
      End Set
    End Property
    <Persistent("f_reg")>
    Property fREG As NPO.Modules.ModSys.Regional
      Get
        Return _freg
      End Get
      Set(value As NPO.Modules.ModSys.Regional)
        SetPropertyValue(Of NPO.Modules.ModSys.Regional)("fREG", _freg, value)
      End Set
    End Property
    <Persistent("d_status")>
    Property StatusTransaksi As StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As StatusTransaksiEnum)
        SetPropertyValue(Of StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("d_duedate")>
    Property JatuhTempo As Date
      Get
        Return _jatuhTempo
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("JatuhTempo", _jatuhTempo, value)
      End Set
    End Property
    <Persistent("d_note")>
    Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property
    <Persistent("f_gl")>
    Property GL As GlMain
      Get
        Return _Gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("GL", _Gl, value)
      End Set
    End Property
    <Association("fk_permintaanpembayaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PengajuanDanaDetail)
      Get
        Return GetCollection(Of PengajuanDanaDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Jumlah)")> ReadOnly Property Jumlah As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Jumlah"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -3, "", source)
        Return False
      End If
      If Kontak Is Nothing Then
        Throw New Utils.Exception("Masukkan kontak", -4, "", source)
        Return False
      End If
      If fCOA Is Nothing Then
        Throw New Utils.Exception("Masukkan akun kas/bank", -5, "", source)
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
  <Persistent("m01dpaymentreqdetail")>
  Friend Class PengajuanDanaDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As PengajuanDana
    Private _akun As Coa
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _proyek As Persistent.Proyek
    Private _jumlah As Double
    Private _kurs As Double
    Private _mataUang As Persistent.MataUang
    Private _keterangan As String

    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_permintaanpembayaran_detail")>
    Property Main As PengajuanDana
      Get
        Return _main
      End Get
      Set(value As PengajuanDana)
        SetPropertyValue(Of PengajuanDana)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_coa")>
    Property Akun As Coa
      Get
        Return _akun
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Akun", _akun, value)
      End Set
    End Property
    <Persistent("f_division")>
    Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
      End Set
    End Property
    <Persistent("f_proyek")>
    Property Proyek As Persistent.Proyek
      Get
        Return _proyek
      End Get
      Set(value As Persistent.Proyek)
        SetPropertyValue(Of Persistent.Proyek)("Proyek", _proyek, value)
      End Set
    End Property
    <Persistent("d_value")>
    Property Jumlah As Double
      Get
        Return _jumlah
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Jumlah", _jumlah, value)
      End Set
    End Property
    <Persistent("d_rate")>
    Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("d_currency")>
    Property MataUang As Persistent.MataUang
      Get
        Return _mataUang
      End Get
      Set(value As Persistent.MataUang)
        SetPropertyValue(Of Persistent.MataUang)("MataUang", _mataUang, value)
      End Set
    End Property
    <Persistent("d_note")>
    Property Keterangan As String
      Get
        Return _keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _keterangan, value)
      End Set
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama pengajuan dana", -99, "", source)
        Return False
      End If
      If _akun Is Nothing Then
        Throw New Utils.Exception("Masukkan akun detail", -99, "", source)
        Return False
      End If
      If _jumlah = Nothing Then
        Throw New Utils.Exception("Masukkan jumlah uang", -99, "", source)
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