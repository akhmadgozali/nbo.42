Imports DevExpress.Xpo

Namespace NuSoft.NPO.Modules.m00
  <Persistent("m00taxout")> _
  Public Class PPnKeluaran1
    Inherits NPOBase

    Public Sub New()

    End Sub
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        If Session.IsNewObject(Me) Then
          If NoSeri = "" Then
            Dim x As NomorFakturBaru = GetReservedNumber(Nothing)
            If x Is Nothing Then
              NoSeri = GetNoSeri(_Tanggal)
              _reserved = Nothing
            Else
              NoSeri = x.NomorFull
              _reserved = Session.GetObjectByKey(Of NomorFakturPajakDetail)(x.Id)
            End If
          End If

          _setting = New Core.Modules.m00.m00TaxSetting(Session)
          _PerusahaanNama = _setting.PerusahaanNama
          _PerusahaanAlamat = _setting.PerusahaanAlamat
          _PerusahaanNPWP = _setting.PerusahaanNPWP
          _PerusahaanTanggalNPWP = _setting.PerusahaanTglPKP
          _PelangganNPKP = PelangganNPWP

          _regionalPajak = Session.GetObjectByKey(Of RegionalPajak)(_regional.Id)
          _TTdNama = _regionalPajak.NamaPenandaTangan
          _TTdJabatan = _regionalPajak.JabatanPenandaTangan
        End If
        _Tahun = Tanggal.Year
        If _reserved Is Nothing Then
          _Sequence = CInt(Right(_NoSeri, 8))
        Else
          _Sequence = _reserved.Id
        End If

        Dim tempId As UInt64 = CType(_Tahun & _Sequence.ToString("00000000"), UInt64)
        If Not Session.IsNewObject(Me) AndAlso _Id <> tempId Then
          _updatedId = tempId
        Else
          _Id = tempId
          _updatedId = tempId
        End If

        MyBase.OnSaving()
      End If
    End Sub
    Protected Overrides Sub OnSaved()
      MyBase.OnSaved()
      If _updatedId <> _Id Then
        'Session.ExecuteQuery(String.Format("update m00taxout set p_id={0} where p_id={1}", updatedId, _Id))
        Session.ExecuteQuery(String.Format(My.Resources.SQLUpdateId, ClassInfo.TableName, updatedId, _Id))
      End If
    End Sub
    Protected Overrides Sub OnLoaded()
      changeMask(Tanggal)
    End Sub
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -1, "", source)
        Return False
      End If
      If _PelangganNama = Nothing Then
        Throw New Utils.Exception("Masukkan nama pelanggan", -2, "", source)
        Return False
      End If
      If _PelangganAlamat = Nothing Then
        Throw New Utils.Exception("Masukkan alamat pelanggan", -3, "", source)
        Return False
      End If
      If _PelangganNPWP = Nothing Then
        Throw New Utils.Exception("Masukkan npwp pelanggan", -4, "", source)
        Return False
      End If
      If _NoInvoice = Nothing Then
        Throw New Utils.Exception("Masukkan nomor invoice dari transaksi", -5, "", source)
        Return False
      End If
      If _ModuleId = Nothing Then
        Throw New Utils.Exception("Masukkan module id", -7, "ModuleId adalah unique id untuk modul SyBiru", source)
        Return False
      End If
      If _regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -11, "", source)
        Return False
      End If

      If Not Session.IsNewObject(Me) Then
        If _PerusahaanNama = Nothing Then
          Throw New Utils.Exception("Masukkan nama perusahaan", -8, "", source)
          Return False
        End If
        If _PerusahaanAlamat = Nothing Then
          Throw New Utils.Exception("Masukkan alamat perusahaan", -9, "", source)
          Return False
        End If
        If _PerusahaanNPWP = Nothing Then
          Throw New Utils.Exception("Masukkan npwp perusahaan", -10, "", source)
          Return False
        End If
        If _RegionalNama = Nothing Then
          Throw New Utils.Exception("Masukkan regional", -11, "", source)
          Return False
        End If
        If _TTdNama = Nothing Then
          Throw New Utils.Exception("Masukkan nama penandatangan", -12, "", source)
          Return False
        End If
      End If

      Return True
    End Function

    Private Function GetNoSeri(tanggal As Date) As String
      '== 010.000-xx.00000011
      Dim _count As Integer = Data.Helper.GetGapsNumber(Session, ClassInfo, "_Sequence", "_Tahun", "=" & Year(tanggal))
      changeMask(tanggal)
      _Sequence = _count
      _Tahun = Year(tanggal)
      Return String.Format("010.000-{0}.{1}", tanggal.ToString("yy"), _count.ToString("00000000"))
    End Function
    Private Function GetReservedNumber(existingNumber As List(Of String)) As NomorFakturBaru
      Dim a As New XPCollection(Of NomorFakturBaru)(Session)

      If existingNumber Is Nothing Then
        If a.Count > 0 Then
          _reserved = Session.GetObjectByKey(Of NomorFakturPajakDetail)(a(0).Id)
          Return a(0)
        End If
      Else
        For i = 0 To a.Count - 1
          Dim nomor As String = a(i).NomorFull
          If Not existingNumber.Exists(Function(m) m = nomor) Then
            _reserved = Session.GetObjectByKey(Of NomorFakturPajakDetail)(a(i).Id)
            If Session.FindObject(Of PPnKeluaran1)(New DevExpress.Data.Filtering.BinaryOperator("NomorFakturPajak", _reserved, DevExpress.Data.Filtering.BinaryOperatorType.Equal)) Is Nothing Then
              Return a(i)
              Exit For
            End If
          End If
        Next
      End If

      Return Nothing
    End Function
    Function GetNoSeriBaru(existingNumber As List(Of String)) As String
      Dim x As NomorFakturBaru = GetReservedNumber(existingNumber)
      If x Is Nothing Then
        _reserved = Nothing
        _NoSeri = GetNoSeri(_Tanggal)
      Else
        _reserved = Session.GetObjectByKey(Of NomorFakturPajakDetail)(x.Id)
        _NoSeri = x.NomorFull
        _seriesNumberMask = x.NomorMask
      End If
      Return _NoSeri
    End Function
    Private Sub changeMask(tanggal As Date)
      _SeriesNumberMask = _mask.Replace("-(\d\d)\.", String.Format("-{0}\.", tanggal.ToString("yy")))
    End Sub

    Private Const _mask As String = "0[1-9][01]\.\d\d\d-(\d\d)\.\d\d\d\d\d\d\d\d"
    <NonPersistent()> Private _updatedId As UInt64
    <NonPersistent()> Private _seriesNumberMask As String = "(0[1-9][01])[.](\d\d\d)-(\d\d)[.](\d\d\d\d\d\d\d\d)"
    <NonPersistent()> Private _regional As abc.Regional
    <NonPersistent()> Private _regionalPajak As RegionalPajak
    <NonPersistent()> Private _setting As Core.Modules.m00.m00TaxSetting

    <Persistent("p_id"), Key()> Private _Id As UInt64
    <Persistent("u_year")> Private _Tahun As Integer
    <Persistent("u_seq")> Private _Sequence As Integer
    <Persistent("d_customernpkp")> Private _PelangganNPKP As String
    <Persistent("d_regional")> Private _RegionalNama As String

    Private _NoSeri As String
    Private _Tanggal As Date
    Private _PerusahaanNama As String
    Private _PerusahaanAlamat As String
    Private _PerusahaanNPWP As String
    Private _PerusahaanTanggalNPWP As Date
    Private _PelangganNama As String
    Private _PelangganAlamat As String
    Private _PelangganNPWP As String
    Private _NoInvoice As String
    Private _Diskon As Double
    Private _UangMuka As Double
    Private _Prosentase As UShort
    Private _TTdNama As String
    Private _TTdJabatan As String
    Private _ModuleId As ModuleId
    Private _Visible As Boolean
    Private _reserved As NomorFakturPajakDetail

    ReadOnly Property Id As UInt64
      Get
        Return _Id
      End Get
    End Property
    ReadOnly Property RegionalNama As String
      Get
        Return _RegionalNama
      End Get
    End Property
    ReadOnly Property updatedId As UInt64
      Get
        Return _updatedId
      End Get
    End Property
    ReadOnly Property SeriesNumberMask As String
      Get
        Return _seriesNumberMask
      End Get
    End Property

    <Persistent("u_seriesnumber")> Property NoSeri As String
      Get
        Return _NoSeri
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSeri", _NoSeri, value)
      End Set
    End Property
    <Persistent("d_date")> Property Tanggal As Date
      Get
        Return _Tanggal
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tanggal", _Tanggal, value)
      End Set
    End Property
    <Persistent("d_companyname")> Property PerusahaanNama As String
      Get
        Return _PerusahaanNama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PerusahaanNama", _PerusahaanNama, value)
      End Set
    End Property
    <Persistent("d_companyaddress")> Property PerusahaanAlamat As String
      Get
        Return _PerusahaanAlamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PerusahaanAlamat", _PerusahaanAlamat, value)
      End Set
    End Property
    <Persistent("d_companynpwp")> Property PerusahaanNPWP As String
      Get
        Return _PerusahaanNPWP
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PerusahaanNPWP", _PerusahaanNPWP, value)
      End Set
    End Property
    <Persistent("d_companynpwpdate")> Property PerusahaanTanggalPKP As Date
      Get
        Return _PerusahaanTanggalNPWP
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("PerusahaanTanggalPKP", _PerusahaanTanggalNPWP, value)
      End Set
    End Property
    <Persistent("d_customername")> Property PelangganNama As String
      Get
        Return _PelangganNama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PelangganNama", _PelangganNama, value)
      End Set
    End Property
    <Persistent("d_customeraddress")> Property PelangganAlamat As String
      Get
        Return _PelangganAlamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PelangganAlamat", _PelangganAlamat, value)
      End Set
    End Property
    <Persistent("d_customernpwp")> Property PelangganNPWP As String
      Get
        Return _PelangganNPWP
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PelangganNPWP", _PelangganNPWP, value)
      End Set
    End Property
    <Persistent("d_invoicenumber")> Property NoInvoice As String
      Get
        Return _NoInvoice
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoInvoice", _NoInvoice, value)
      End Set
    End Property
    <Persistent("d_discount")> Property Diskon As Double
      Get
        Return _Diskon
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Diskon", _Diskon, value)
      End Set
    End Property
    <Persistent("d_downpayment")> Property UangMuka As Double
      Get
        Return _UangMuka
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("UangMuka", _UangMuka, value)
      End Set
    End Property
    <Persistent("d_procentage")> Property Prosentase As UShort
      Get
        Return _Prosentase
      End Get
      Set(value As UShort)
        SetPropertyValue(Of UShort)("Prosentase", _Prosentase, value)
      End Set
    End Property
    <Persistent("d_signing")> Property TTdNama As String
      Get
        Return _TTdNama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TTdNama", _TTdNama, value)
      End Set
    End Property
    <Persistent("d_signingposition")> Property TTdJabatan As String
      Get
        Return _TTdJabatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TTdJabatan", _TTdJabatan, value)
      End Set
    End Property
    <Persistent("x_module")> Property ModuleId As ModuleId
      Get
        Return _ModuleId
      End Get
      Set(value As ModuleId)
        SetPropertyValue(Of ModuleId)("ModuleId", _ModuleId, value)
      End Set
    End Property
    <Persistent("x_visible")> Property Visible As Boolean
      Get
        Return _Visible
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Visible", _Visible, value)
      End Set
    End Property
    <NonPersistent()> Property Regional As abc.Regional
      Get
        Return _regional
      End Get
      Set(value As abc.Regional)
        SetPropertyValue(Of abc.Regional)("Regional", _regional, value)
        SetPropertyValue(Of String)("_RegionalNama", _RegionalNama, value.Nama)
      End Set
    End Property
    <Persistent("fk_reserved")> Property NomorFakturPajak As NomorFakturPajakDetail
      Get
        Return _reserved
      End Get
      Set(value As NomorFakturPajakDetail)
        SetPropertyValue(Of NomorFakturPajakDetail)("NomorFakturPajak", _reserved, value)
      End Set
    End Property

    <Association("TaxDetail"), Aggregated()> _
    ReadOnly Property Detail() As XPCollection(Of PPnKeluaran2)
      Get
        Return GetCollection(Of PPnKeluaran2)("Detail")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property SubTotal As Decimal
      Get
        Dim orderTotal As Decimal
        For Each item As PPnKeluaran2 In Detail
          orderTotal += item.Harga
        Next
        Return orderTotal
      End Get
    End Property
    <PersistentAlias("SubTotal-Diskon-UangMuka")> ReadOnly Property Dpp As Decimal
      Get
        Return Convert.ToDecimal(EvaluateAlias("Dpp"))
      End Get
    End Property
    <PersistentAlias("Dpp*Prosentase/100")> ReadOnly Property PPn As Decimal
      Get
        Return Convert.ToDecimal(EvaluateAlias("PPn"))
      End Get
    End Property
    <PersistentAlias("_Tahun")> ReadOnly Property Tahun As Integer
      Get
        Return _Tahun
      End Get
    End Property
    <PersistentAlias("Concat(_Tahun,'-',Month(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
  End Class

  <Persistent("m00taxoutdetail")> _
  Public Class PPnKeluaran2
    Inherits NPOBase

    Public Sub New()
    End Sub
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _Main Is Nothing Then
        Throw New Utils.Exception("Masukkan keterangan pajak", -1, "", source)
        Return False
      End If
      If _Urutan = Nothing Then
        Throw New Utils.Exception("Masukkan urutan item", -2, "", source)
        Return False
      End If
      If _ItemName = Nothing Then
        Throw New Utils.Exception("Masukkan nama item pajak", -3, "", source)
        Return False
      End If
      If _ItemPrice = Nothing Then
        Throw New Utils.Exception("Masukkan harga item", -4, "", source)
        Return False
      End If

      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If CheckData() Then

        Dim tempId As UInt64 = CType(Main.updatedId & _Urutan, UInt64)
        If Not Session.IsNewObject(Me) AndAlso _Id <> tempId Then
          _updatedId = tempId
        Else
          _Id = tempId
          _updatedId = Nothing
        End If

        MyBase.OnSaving()
      End If
    End Sub
    Protected Overrides Sub OnSaved()
      MyBase.OnSaved()
      If Not _updatedId = Nothing Then
        Session.ExecuteQuery(String.Format("update m00taxoutdetail set primary_main={0} where primary_main={1}", _updatedId, _Id))
      End If
    End Sub

    <NonPersistent()> Private _updatedId As UInt64
    Private _Id As UInt64
    Private _Main As PPnKeluaran1
    Private _Urutan As UShort
    Private _ItemName As String
    Private _ItemPrice As Decimal
    'Private _ItemDiscount As Decimal

    <Persistent("primary_main"), Key()> Property Id As UInt64
      Get
        Return _Id
      End Get
      Set(value As UInt64)
        SetPropertyValue(Of UInt64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("TaxDetail"), Aggregated()> Property Main As PPnKeluaran1
      Get
        Return _Main
      End Get
      Set(value As PPnKeluaran1)
        SetPropertyValue(Of PPnKeluaran1)("Main", _Main, value)
      End Set
    End Property
    <Persistent("p_order")> Property Urutan As UShort
      Get
        Return _Urutan
      End Get
      Set(value As UShort)
        SetPropertyValue(Of UShort)("Urutan", _Urutan, value)
      End Set
    End Property
    <Persistent("d_itemname")> Property Item As String
      Get
        Return _ItemName
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Item", _ItemName, value)
      End Set
    End Property
    <Persistent("d_itemprice")> Property Harga As Decimal
      Get
        Return _ItemPrice
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Harga", _ItemPrice, value)
      End Set
    End Property
    '<Persistent("d_itemdiscount")> Property Diskon As Double
    '  Get
    '    Return _ItemDiscount
    '  End Get
    '  Set(value As Double)
    '    SetPropertyValue(Of Double)("Diskon", _ItemDiscount, value)
    '  End Set
    'End Property
  End Class

  <Persistent("m00zregtax")> _
  Public Class RegionalPajak
    Inherits NPOBase

    Public Sub New()
    End Sub
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.TableName
      If _Id Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If

      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub

    Private _Id As abc.Regional
    Private _SignName As String
    Private _SignPosition As String

    <Persistent("p_id"), Key()> Property Id As abc.Regional
      Get
        Return _Id
      End Get
      Set(value As abc.Regional)
        SetPropertyValue(Of abc.Regional)("Id", _Id, value)
      End Set
    End Property
    <Persistent("d_ttdname")> Property NamaPenandaTangan As String
      Get
        Return _SignName
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NamaPenandaTangan", _SignName, value)
      End Set
    End Property
    <Persistent("d_ttdposition")> Property JabatanPenandaTangan As String
      Get
        Return _SignPosition
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("JabatanPenandaTangan", _SignPosition, value)
      End Set
    End Property
  End Class

  <Persistent("m00areservednumber")> _
  Public Class NomorFakturPajak
    Inherits NPOBase

    <Persistent("p_id"), Key(True)> Private _id As Int32
    Private _tanggalMinta As Date
    Private _tanggalKonfirmasi As Date
    Private _nomorDari As String
    Private _nomorKe As String
    Private _keterangan As String

    ReadOnly Property Id As Int32
      Get
        Return _id
      End Get
    End Property
    <Persistent("d_daterequest")> Property TanggalMinta As Date
      Get
        Return _tanggalMinta
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalMinta", _tanggalMinta, value)
      End Set
    End Property
    <Persistent("d_dateconfirm")> Property TanggalKonfirmasi As Date
      Get
        Return _tanggalKonfirmasi
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalKonfirmasi", _tanggalKonfirmasi, value)
      End Set
    End Property
    <Persistent("d_numberfrom")> Property NomorDari As String
      Get
        Return _nomorDari
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorDari", _nomorDari, value)
      End Set
    End Property
    <Persistent("d_numberto")> Property NomorKe As String
      Get
        Return _nomorKe
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorKe", _nomorKe, value)
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

    <Association("NomorFakturPajak_Detail"), Aggregated()> ReadOnly Property Detail As XPCollection(Of NomorFakturPajakDetail)
      Get
        Return GetCollection(Of NomorFakturPajakDetail)("Detail")
      End Get
    End Property
    ReadOnly Property Locked As Boolean
      Get
        Return CType(Session.Evaluate(Of PPnKeluaran1)(DevExpress.Data.Filtering.CriteriaOperator.Parse("Count()"), New DevExpress.Data.Filtering.BinaryOperator("NomorFakturPajak.Main", Me, DevExpress.Data.Filtering.BinaryOperatorType.Equal)), Int64) > 0
      End Get
    End Property

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Event InsertDetail(number As String)

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        If Not Session.IsNewObject(Me) Then
          Dim xpDel As New XPCollection(Of NomorFakturPajakDetail)(Session, New DevExpress.Data.Filtering.BinaryOperator("Main", Me, DevExpress.Data.Filtering.BinaryOperatorType.Equal))
          Session.Delete(xpDel)
        End If

        'Dim beda As Integer
        'For i = 0 To 13
        '  If NomorDari.Substring(i, 1) <> NomorKe.Substring(i, 1) Then
        '    beda = i
        '    Exit For
        '  End If
        'Next

        'Dim incrNumber As String = NomorDari
        'Dim item As NomorFakturPajakDetail
        'Do Until incrNumber = NomorKe
        '  RaiseEvent InsertDetail(incrNumber)
        '  item = New NomorFakturPajakDetail(Session)
        '  item.Main = Me
        '  item.Nomor = incrNumber
        '  item.Save()

        '  incrNumber = incrementNumber(beda, incrNumber)
        'Loop
        'RaiseEvent InsertDetail(NomorKe)
        'item = New NomorFakturPajakDetail(Session)
        'item.Main = Me
        'item.Nomor = NomorKe
        'item.Save()

        Dim posisi As Integer = NomorDari.IndexOf("-"c) + 1
        Dim kode As String = NomorDari.Substring(0, posisi)
        Dim nomor1 As Integer = CInt(NomorDari.Substring(posisi))
        Dim nomor2 As Integer = CInt(NomorKe.Substring(posisi))

        Dim item As NomorFakturPajakDetail
        For i = nomor1 To nomor2
          Dim a As String = kode & i.ToString
          RaiseEvent InsertDetail(a)

          item = New NomorFakturPajakDetail(Session)
          item.Main = Me
          item.Nomor = a
          item.Save()
        Next
        MyBase.OnSaving()
      End If
    End Sub

    Private Function incrementNumber(posisiBeda As Integer, data As String) As String
      'Try
      Dim result As String = data
      For i = 12 To posisiBeda Step -1
        If IsNumeric(result.Substring(i, 1)) Then
          If result.Substring(i, 1) = "9" Then
            result = result.Substring(0, i) & "0" & result.Substring(i + 1)
          Else
            Return result.Substring(0, i) & (CInt(result.Substring(i, 1)) + 1) & result.Substring(i + 1)
            Exit For
          End If
        Else
          If result.Substring(i, 1) = "Z" Then
            result = result.Substring(0, i) & "A" & result.Substring(i + 1)
          Else
            Return result.Substring(0, i) & Chr(Asc(result.Substring(i, 1)) + 1) & result.Substring(i + 1)
            Exit For
          End If
        End If
      Next

      Return data
      'Catch ex As Exception

      'End Try
    End Function
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _tanggalMinta = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal permintaan nomor", -1, "", source)
        Return False
      End If
      If _tanggalKonfirmasi = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal konfirmasi dari pajak", -2, "", source)
        Return False
      End If
      If _nomorDari = Nothing Then
        Throw New Utils.Exception("Masukkan nomor baru pertama", -3, "", source)
        Return False
      End If
      'If _nomorDari.Length <> 13 Then
      '  Throw New Utils.Exception("Jumlah karakter nomor baru pertama harus 13", -3, "", source)
      '  Return False
      'End If
      If _nomorKe = Nothing Then
        Throw New Utils.Exception("Masukkan nomor baru kedua", -4, "", source)
        Return False
      End If
      'If _nomorKe.Length <> 13 Then
      '  Throw New Utils.Exception("Jumlah karakter nomor baru kedua harus 13", -4, "", source)
      '  Return False
      'End If

      Return True
    End Function
  End Class
  <Persistent("m00breserveddetail")> _
  Public Class NomorFakturPajakDetail
    Inherits NPOBase

    <Persistent("p_id"), Key(True)> Private _id As Int32
    Private _main As NomorFakturPajak
    Private _nomor As String
    Private _keterangan As String

    ReadOnly Property Id As Int32
      Get
        Return _id
      End Get
    End Property
    <Persistent("f_main"), Association("NomorFakturPajak_Detail")> Property Main As NomorFakturPajak
      Get
        Return _main
      End Get
      Set(value As NomorFakturPajak)
        SetPropertyValue(Of NomorFakturPajak)("Main", _main, value)
      End Set
    End Property
    <Persistent("u_number")> Property Nomor As String
      Get
        Return _nomor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nomor", _nomor, value)
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

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub
    Protected Overrides Sub OnDeleting()
      If CType(Session.Evaluate(Of PPnKeluaran1)(DevExpress.Data.Filtering.CriteriaOperator.Parse("Count()"), New DevExpress.Data.Filtering.BinaryOperator("NomorFakturPajak", Me, DevExpress.Data.Filtering.BinaryOperatorType.Equal)), Int64) > 0 Then
        Throw New Utils.Exception("Nomor '" & _nomor & "' ini sudah ada yang memakai", -1, "")
      End If
      MyBase.OnDeleting()
    End Sub

    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor utama", -1, "", source)
        Return False
      End If
      If _nomor = Nothing Then
        Throw New Utils.Exception("Masukkan nomor", -2, "", source)
        Return False
      End If

      Return True
    End Function
  End Class
  <Persistent("m00newreservednumber")> _
  Public Class NomorFakturBaru
    Inherits NPOBase

    <Persistent("p_id"), Key(True)> Private _id As Int32
    Private _main As NomorFakturPajak
    Private _nomor As String
    Private _keterangan As String

    ReadOnly Property Id As Int32
      Get
        Return _id
      End Get
    End Property
    ReadOnly Property NomorMask As String
      Get
        Return "(0[1-9][01])[.]" & _nomor.Replace(".", "[.]")
      End Get
    End Property
    ReadOnly Property NomorFull As String
      Get
        Return "010." & _nomor
      End Get
    End Property
    <Persistent("f_main")> Property Main As NomorFakturPajak
      Get
        Return _main
      End Get
      Set(value As NomorFakturPajak)
        SetPropertyValue(Of NomorFakturPajak)("Main", _main, value)
      End Set
    End Property
    <Persistent("u_number")> Property Nomor As String
      Get
        Return _nomor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nomor", _nomor, value)
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

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
  End Class

  Public Class Helper
    Shared Function GetDefaultNPWP() As String
      Return "00.000.000.0-000.000"
    End Function
  End Class
End Namespace