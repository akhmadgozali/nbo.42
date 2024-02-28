Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.Metadata

Namespace NuSoft.NPO.Modules.m02
  <Persistent("m02bkasbonmain")>
  Public Class Kasbon
    Inherits NPOBase

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
      InitializeData()
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
      InitializeData()
    End Sub

    <NonPersistent()> Private _transaksiKode As Core.Modules.Global.TransactionCode
    <NonPersistent()> Private _abcConfig As Core.Modules.abc.AbcConfig
    <NonPersistent()> Private _mask As String
    <NonPersistent()> Private _updatedId As UInt64

    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If

      _tahun = _tanggal.Year
      _bulan = _tanggal.Month

      If _transaksiKode.Regional Is Nothing Then
        _transaksiKode.Regional = _regional
      End If
      If _transaksiKode.Tanggal = Nothing Then
        _transaksiKode.Tanggal = _tanggal
      End If

      _urutan = _transaksiKode.GetUrutanDariKode(_noBukti, Not Session.IsNewObject(Me))

      Dim tempId As UInt32 = CType(_regional.Id & _tahun.ToString("0000") & _bulan.ToString("00") & _urutan.ToString("000"), UInt32)
      If Not Session.IsNewObject(Me) AndAlso _id <> tempId Then
        _updatedId = tempId
      Else
        _id = tempId
        _updatedId = tempId
      End If

      MyBase.OnSaving()
    End Sub
    Protected Overrides Sub OnSaved()
      MyBase.OnSaved()
      If _updatedId <> _Id Then
        Session.ExecuteNonQuery(String.Format(My.Resources.SQLUpdateId, ClassInfo.TableName, _updatedId, _id))
      End If
    End Sub
    Protected Overrides Sub OnLoaded()
      GoLoad()
    End Sub

    Sub BuatNomorBuktiBaru()
      _transaksiKode.Regional = _regional
      _transaksiKode.Tanggal = _tanggal
      _transaksiKode.CriteriaName = "_tahun;_bulan;Regional"
      _transaksiKode.CriteriaValue = String.Format("={0};={1};={2}", _tanggal.Year, _tanggal.Month, _regional.Id)
      _transaksiKode.BuatKodeTransaksiBaru()
      _mask = _transaksiKode.MaskKode
      NoBukti = _transaksiKode.NomorKode
    End Sub

    Private Sub InitializeData()
      If Not IsLoading Then
        GoLoad()
      End If
    End Sub
    Private Sub GoLoad()
      _transaksiKode = New Core.Modules.Global.TransactionCode(Session, ClassInfo, "_urutan", "[R]-KB[Y2][M0]-[X3]")
      _abcConfig = New Core.Modules.abc.AbcConfig(Session)
    End Sub
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If _noBukti = Nothing Then
        Throw New Utils.Exception("Masukkan nomor bukti kasbon", -2, "", source)
        Return False
      End If
      If _tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If _kontak = Nothing Then
        Throw New Utils.Exception("Masukkan kontak kasbon", -4, "", source)
        Return False
      End If
      If _jumlah = Nothing Then
        Throw New Utils.Exception("Masukkan jumlah kasbon", -5, "", source)
        Return False
      End If

      Return True
    End Function

    <Persistent("p_id"), Key(), Indexed("_tahun;_bulan;_urutan")> Private _id As UInt32
    Private _regional As abc.Regional
    Private _karyawan As m01.Karyawan
    <Persistent("u_year")> Private _tahun As Integer
    <Persistent("u_month")> Private _bulan As Integer
    <Persistent("u_sequence")> Private _urutan As UInt16
    <Indexed("NoBukti", Unique:=True)> Private _noBukti As String
    Private _tanggal As Date
    Private _tanggalPenyelesaian As Date
    Private _kontak As String
    Private _jumlah As Double
    Private _keperluan As String
    Private _keterangan As String
    Private _gl As GlMain

    ReadOnly Property Mask As String
      Get
        Return _mask
      End Get
    End Property

    ReadOnly Property Id As UInt32
      Get
        Return _id
      End Get
    End Property
    ReadOnly Property Tahun As Integer
      Get
        Return _tahun
      End Get
    End Property
    <PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
    ReadOnly Property Urutan As UInt16
      Get
        Return _urutan
      End Get
    End Property
    <Association("m02kasbon_bayar")> ReadOnly Property Pembayaran As XPCollection(Of BayarKasbon)
      Get
        Return GetCollection(Of BayarKasbon)("Pembayaran")
      End Get
    End Property
    ReadOnly Property CompanyName As String
      Get
        Return _abcConfig.NamaPerusahaan
      End Get
    End Property
    ReadOnly Property Terbilang As String
      Get
        Return Utils.Common.Character.Terbilang(Jumlah).ToUpper
      End Get
    End Property
    ReadOnly Property Sisa As Double
      Get
        Return Jumlah - Pembayaran.ToList.Sum(Function(m) m.Jumlah)
      End Get
    End Property

    <Persistent("f_reg")> Property Regional As abc.Regional
      Get
        Return _regional
      End Get
      Set(value As abc.Regional)
        SetPropertyValue(Of abc.Regional)("Regional", _regional, value)
      End Set
    End Property
    <Persistent("u_code")> Property NoBukti As String
      Get
        Return _noBukti
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoBukti", _noBukti, value)
      End Set
    End Property
    <Persistent("d_date")> Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
      End Set
    End Property
    <Persistent("d_datefinish")> Property TanggalPenyelesaian As Date
      Get
        Return _tanggalPenyelesaian
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalPenyelesaian", _tanggalPenyelesaian, value)
      End Set
    End Property
    <Persistent("d_contact")> Property Kontak As String
      Get
        Return _kontak
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kontak", _kontak, value)
      End Set
    End Property
    <Persistent("d_amount")> Property Jumlah As Double
      Get
        Return _jumlah
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Jumlah", _jumlah, value)
      End Set
    End Property
    <Persistent("d_need")> Property Keperluan As String
      Get
        Return _keperluan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keperluan", _keperluan, value)
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
    <Persistent("transaction_id")> Property Transaksi As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Transaksi", _gl, value)
      End Set
    End Property
  End Class

  <Persistent("m02bspj")>
  Public Class SPJ
    Inherits NPOBase

    <NonPersistent()> Private _abcConfig As Core.Modules.abc.AbcConfig

    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If

      MyBase.OnSaving()
    End Sub
    Protected Overrides Sub OnLoaded()
      GoLoad()
    End Sub

    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If _tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If _id Is Nothing Then
        Throw New Utils.Exception("Masukkan penugasan", -3, "", source)
        Return False
      End If
      If _uangMakan = Nothing Then
        Throw New Utils.Exception("Masukkan nominal uang makan", -4, "", source)
        Return False
      End If
      If _uangSaku = Nothing Then
        Throw New Utils.Exception("Masukkan nominal uang saku", -5, "", source)
        Return False
      End If

      Return True
    End Function

    Private Sub InitializeData()
      If Not IsLoading Then
        GoLoad()
      End If
    End Sub
    Private Sub GoLoad()
      _abcConfig = New Core.Modules.abc.AbcConfig(Session)
    End Sub

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
      InitializeData()
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
      InitializeData()
    End Sub

    Private _id As m01.Penugasan
    Private _regional As abc.Regional
    Private _tanggal As Date
    Private _uangMakan As Double
    Private _hariUangMakan As Int16
    Private _uangSaku As Double
    Private _hariUangSaku As Int16
    Private _biayaHotel As Double
    Private _kasbon As Double
    Private _isLuarDaerah As Boolean
    Private _keterangan As String
    Private _gl As GlMain
    Private _ttdNama As String
    Private _ttdJabatan As String
    Private _ttdProses As String
    Private _ttdSetuju As String

    ReadOnly Property CompanyName As String
      Get
        Return _abcConfig.NamaPerusahaan
      End Get
    End Property
    ReadOnly Property Terbilang As String
      Get
        Return Utils.Common.Character.Terbilang(Total).ToUpper
      End Get
    End Property
    ReadOnly Property Tahun As Integer
      Get
        Return _tanggal.Year
      End Get
    End Property
    <PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
    ReadOnly Property Total As Double
      Get
        Return (_hariUangMakan * _uangMakan) + (_hariUangSaku * _uangSaku)
      End Get
    End Property

    <Persistent("p_id"), Key()> Property Id As m01.Penugasan
      Get
        Return _id
      End Get
      Set(value As m01.Penugasan)
        SetPropertyValue(Of m01.Penugasan)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_reg")> Property Regional As abc.Regional
      Get
        Return _regional
      End Get
      Set(value As abc.Regional)
        SetPropertyValue(Of abc.Regional)("Regional", _regional, value)
      End Set
    End Property
    <Persistent("d_date")> Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
      End Set
    End Property
    <Persistent("d_eat")> Property UangMakan As Double
      Get
        Return _uangMakan
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("UangMakan", _uangMakan, value)
      End Set
    End Property
    <Persistent("d_eatdays")> Property HariUangMakan As Int16
      Get
        Return _hariUangMakan
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("HariUangMakan", _hariUangMakan, value)
      End Set
    End Property
    <Persistent("d_pocket")> Property UangSaku As Double
      Get
        Return _uangSaku
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("UangSaku", _uangSaku, value)
      End Set
    End Property
    <Persistent("d_pocketdays")> Property HariUangSaku As Int16
      Get
        Return _hariUangSaku
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("HariUangSaku", _hariUangSaku, value)
      End Set
    End Property
    <Persistent("d_hotel")> Property BiayaHotel As Double
      Get
        Return _biayaHotel
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaHotel", _biayaHotel, value)
      End Set
    End Property
    <Persistent("d_kasbon")> Property Kasbon As Double
      Get
        Return _kasbon
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kasbon", _kasbon, value)
      End Set
    End Property
    <Persistent("d_outside")> Property LuarDaerah As Boolean
      Get
        Return _isLuarDaerah
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("LuarDaerah", _isLuarDaerah, value)
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
    <Persistent("transaction_id")> Property Transaksi As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Transaksi", _gl, value)
      End Set
    End Property
    <Persistent("d_ttdnama")> Property TtdNama As String
      Get
        Return _ttdNama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TtdNama", _ttdNama, value)
      End Set
    End Property
    <Persistent("d_ttdjabatan")> Property TtdJabatan As String
      Get
        Return _ttdJabatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TtdJabatan", _ttdJabatan, value)
      End Set
    End Property
    <Persistent("d_ttdproses")> Property TtdProses As String
      Get
        Return _ttdProses
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TtdProses", _ttdProses, value)
      End Set
    End Property
    <Persistent("d_ttdsetuju")> Property TtdSetuju As String
      Get
        Return _ttdSetuju
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TtdSetuju", _ttdSetuju, value)
      End Set
    End Property
  End Class

  <Persistent("m02ckasbonpay")>
  Public Class BayarKasbon
    Inherits NPOBase

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
      InitializeData()
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
      InitializeData()
    End Sub

    <NonPersistent()> Private _transaksiKode As Core.Modules.Global.TransactionCode
    <NonPersistent()> Private _mask As String
    <NonPersistent()> Private _updatedId As UInt64
    <NonPersistent()> Private _abcConfig As Core.Modules.abc.AbcConfig

    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If

      _tahun = _tanggal.Year
      _bulan = _tanggal.Month

      If _transaksiKode.Regional Is Nothing Then
        _transaksiKode.Regional = _regional
      End If
      If _transaksiKode.Tanggal = Nothing Then
        _transaksiKode.Tanggal = _tanggal
      End If

      _urutan = _transaksiKode.GetUrutanDariKode(_noBukti, Not Session.IsNewObject(Me))

      Dim tempId As UInt32 = CType(_regional.Id & _tahun.ToString("0000") & _bulan.ToString("00") & _urutan.ToString("000"), UInt32)
      If Not Session.IsNewObject(Me) AndAlso _id <> tempId Then
        _updatedId = tempId
      Else
        _id = tempId
        _updatedId = tempId
      End If

      '===== Jika kasbon terintegrasi dengan gl maka pembayaran ikut terintegrasi juga
      '===== Kasbon --> Piutang Karyawan
      '===== Kasbon --> Kas Keluar

      MyBase.OnSaving()
    End Sub
    Protected Overrides Sub OnSaved()
      MyBase.OnSaved()
      If _updatedId <> _Id Then
        Session.ExecuteNonQuery(String.Format(My.Resources.SQLUpdateId, ClassInfo.TableName, _updatedId, _id))
      End If
    End Sub
    Protected Overrides Sub OnLoaded()
      GoLoad()
    End Sub

    Sub BuatNomorBuktiBaru()
      _transaksiKode.Regional = _regional
      _transaksiKode.Tanggal = _tanggal
      _transaksiKode.CriteriaName = "_tahun;_bulan;Regional"
      _transaksiKode.CriteriaValue = String.Format("={0};={1};={2}", _tanggal.Year, _tanggal.Month, _regional.Id)
      _transaksiKode.BuatKodeTransaksiBaru()
      _mask = _transaksiKode.MaskKode
      NoBukti = _transaksiKode.NomorKode
    End Sub

    Private Sub InitializeData()
      If Not IsLoading Then
        GoLoad()
      End If
    End Sub
    Private Sub GoLoad()
      _transaksiKode = New Core.Modules.Global.TransactionCode(Session, ClassInfo, "_urutan", "[R]-PK[Y2][M0]-[X3]")
      _abcConfig = New Core.Modules.abc.AbcConfig(Session)
    End Sub
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If _noBukti = Nothing Then
        Throw New Utils.Exception("Masukkan nomor bukti pembayaran kasbon", -2, "", source)
        Return False
      End If
      If _tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If _jumlah = Nothing Then
        Throw New Utils.Exception("Masukkan jumlah kasbon", -5, "", source)
        Return False
      End If

      Return True
    End Function

    <Persistent("p_id"), Key(), Indexed("_tahun;_bulan;_urutan")> Private _id As UInt32
    Private _regional As abc.Regional
    Private _kasbon As Kasbon
    <Persistent("u_year")> Private _tahun As Integer
    <Persistent("u_month")> Private _bulan As Integer
    <Persistent("u_sequence")> Private _urutan As UInt16
    <Indexed("NoBukti", Unique:=True)> Private _noBukti As String
    Private _tanggal As Date
    Private _angsuranKe As Byte
    Private _jumlah As Double
    Private _keterangan As String
    Private _gl As GlMain

    ReadOnly Property Mask As String
      Get
        Return _mask
      End Get
    End Property

    ReadOnly Property Id As UInt32
      Get
        Return _id
      End Get
    End Property
    ReadOnly Property Tahun As Integer
      Get
        Return _tahun
      End Get
    End Property
    <PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
    ReadOnly Property Urutan As UInt16
      Get
        Return _urutan
      End Get
    End Property
    ReadOnly Property CompanyName As String
      Get
        Return _abcConfig.NamaPerusahaan
      End Get
    End Property
    ReadOnly Property Terbilang As String
      Get
        Return Utils.Common.Character.Terbilang(Jumlah).ToUpper
      End Get
    End Property
    ReadOnly Property HutangSebelumnya As Double
      Get
        Return Kasbon.Jumlah - (From a In Kasbon.Pembayaran Where a.AngsuranKe < _angsuranKe Select a.Jumlah).Sum
      End Get
    End Property

    <Persistent("f_reg")> Property Regional As abc.Regional
      Get
        Return _regional
      End Get
      Set(value As abc.Regional)
        SetPropertyValue(Of abc.Regional)("Regional", _regional, value)
      End Set
    End Property
    <Persistent("f_main"), Association("m02kasbon_bayar")> Property Kasbon As Kasbon
      Get
        Return _kasbon
      End Get
      Set(value As Kasbon)
        SetPropertyValue(Of Kasbon)("Kasbon", _kasbon, value)
      End Set
    End Property
    <Persistent("u_code")> Property NoBukti As String
      Get
        Return _noBukti
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoBukti", _noBukti, value)
      End Set
    End Property
    <Persistent("d_date")> Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
      End Set
    End Property
    <Persistent("d_installment")> Property AngsuranKe As Byte
      Get
        Return _angsuranKe
      End Get
      Set(value As Byte)
        SetPropertyValue(Of Byte)("AngsuranKe", _angsuranKe, value)
      End Set
    End Property
    <Persistent("d_amount")> Property Jumlah As Double
      Get
        Return _jumlah
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Jumlah", _jumlah, value)
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
    <Persistent("transaction_id")> Property Transaksi As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Transaksi", _gl, value)
      End Set
    End Property
  End Class
End Namespace