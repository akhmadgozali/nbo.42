Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m01cloanmain")>
  Friend Class Pinjaman
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("f_reg")> Private _reg As NPO.Modules.ModSys.Regional
    Private _kontak As Kontak
    Private _mataUang As MataUang
    Private _jumlahPinjaman As Decimal
    Private _termin As Int16
    Private _biaya As Decimal
    Private _tanggalAwal As Date
    Private _keterangan As String

    <Persistent("f_contact")>
    Property Kontak As Kontak
      Get
        Return _kontak
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Kontak", _kontak, value)
      End Set
    End Property
    <Persistent("f_currency")>
    Property MataUang As MataUang
      Get
        Return _mataUang
      End Get
      Set(value As MataUang)
        SetPropertyValue(Of MataUang)("MataUang", _mataUang, value)
      End Set
    End Property
    <Persistent("d_debtvalue")>
    Property JumlahPinjaman As Decimal
      Get
        Return _jumlahPinjaman
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("JumlahPinjaman", _jumlahPinjaman, value)
      End Set
    End Property
    <Persistent("d_terms")>
    Property Termin As Int16
      Get
        Return _termin
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Termin", _termin, value)
      End Set
    End Property
    <Persistent("d_rate")>
    Property Biaya As Decimal
      Get
        Return _biaya
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Biaya", _biaya, value)
      End Set
    End Property
    <Persistent("d_startdate")>
    Property TanggalAwal As Date
      Get
        Return _tanggalAwal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalAwal", _tanggalAwal, value)
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

    <Association("fk_pinjaman_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PinjamanDetail)
      Get
        Return GetCollection(Of PinjamanDetail)("Detail")
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If Kode = Nothing Then
        Throw New Utils.Exception("Masukkan nomor kontrak pinjaman", -1, "", source)
        Return False
      End If
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
      If MataUang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang pinjaman", -5, "", source)
        Return False
      End If
      If JumlahPinjaman = Nothing Then
        Throw New Utils.Exception("Masukkan jumlah pinjaman", -6, "", source)
        Return False
      End If
      If Termin = Nothing Then
        Throw New Utils.Exception("Masukkan termin", -7, "", source)
        Return False
      End If
      If Biaya = Nothing Then
        Throw New Utils.Exception("Masukkan biaya pinjaman", -8, "", source)
        Return False
      End If
      If TanggalAwal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal awal pinjaman", -9, "", source)
        Return False
      End If

      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If

      _reg = Regional

      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m01dloandetail")>
  Friend Class PinjamanDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Pinjaman
    Private _urutan As Int16
    Private _jatuhTempo As Date
    Private _pokok As Decimal
    Private _biaya As Decimal
    Private _sisa As Decimal
    Private _terbayar As Boolean
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
    <Persistent("p_id"), Association("fk_pinjaman_detail")>
    Property Main As Pinjaman
      Get
        Return _main
      End Get
      Set(value As Pinjaman)
        SetPropertyValue(Of Pinjaman)("Main", _main, value)
      End Set
    End Property
    <Persistent("d_seq")>
    Property Urutan As Int16
      Get
        Return _urutan
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Urutan", _urutan, value)
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
    <Persistent("d_valuedebt")>
    Property Pokok As Decimal
      Get
        Return _pokok
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Pokok", _pokok, value)
      End Set
    End Property
    <Persistent("d_valueinterest")>
    Property Biaya As Decimal
      Get
        Return _biaya
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Biaya", _biaya, value)
      End Set
    End Property
    <Persistent("d_valueremain")>
    Property Sisa As Decimal
      Get
        Return _sisa
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Sisa", _sisa, value)
      End Set
    End Property
    <Persistent("d_payment")>
    Property Terbayar As Boolean
      Get
        Return _terbayar
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Terbayar", _terbayar, value)
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
      If _urutan = Nothing Then
        Throw New Utils.Exception("Masukkan urutan cicilan", -99, "", source)
        Return False
      End If
      If _jatuhTempo = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal jatuh tempo", -99, "", source)
        Return False
      End If
      If _pokok = Nothing Then
        Throw New Utils.Exception("Masukkan pokok pinjaman", -99, "", source)
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