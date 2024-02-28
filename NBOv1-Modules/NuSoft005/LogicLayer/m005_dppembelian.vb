Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m05cmaininvoicereceipt")>
  Friend Class DPPembelian
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _idpo As Persistent.OrderPembelian
    'Private _nilaipo As Double
    Private _nilaidppersen As Double
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _nilaidpvalas As Double
    Private _tax As NuSoft004.Persistent.Pajak
    Private _taxp As Double
    Private _taxvalue As Double
    Private _taxcaption As eJenisPajak
    Private _taxserial As String
    Private _remarks As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _gl As Persistent.GlMain
    Private _coaHutang As NuSoft001.Persistent.Coa
    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
      End Set
    End Property
    <Persistent("f_coahutang")> Property CoaHutang As NuSoft001.Persistent.Coa
      Get
        Return _coaHutang
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaHutang", _coaHutang, value)
      End Set
    End Property
    <Persistent("p_idorder"), Association("fk_OrderPembelian_UangMukaPembelian")>
    Property PO As OrderPembelian
      Get
        Return _idpo
      End Get
      Set(value As OrderPembelian)
        SetPropertyValue(Of OrderPembelian)("PO", _idpo, value)
      End Set
    End Property
    <Persistent("d_dppersen")>
    Property NilaiDPpersen As Double
      Get
        Return _nilaidppersen
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiDPpersen", _nilaidppersen, value)
      End Set
    End Property
    <Persistent("f_currency")>
    Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
      End Set
    End Property
    <Persistent("d_kurs")>
    Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("f_dptax")>
    Property Pajak As NuSoft004.Persistent.Pajak
      Get
        Return _tax
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("Pajak", _tax, value)
      End Set
    End Property
    <Persistent("d_dptaxp")>
    Property PajakPersen As Double
      Get
        Return _taxp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PajakPersen", _taxp, value)
      End Set
    End Property
    <Persistent("d_taxcaption")>
    Property JenisPajak As eJenisPajak
      Get
        Return _taxcaption
      End Get
      Set(value As eJenisPajak)
        SetPropertyValue(Of eJenisPajak)("JenisPajak", _taxcaption, value)
      End Set
    End Property
    <Persistent("d_taxsnppn")>
    Property PajakSN As String
      Get
        Return _taxserial
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("PajakSN", _taxserial, value)
      End Set
    End Property
    <Persistent("d_remarks")>
    Property Keterangan As String
      Get
        Return _remarks
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _remarks, value)
      End Set
    End Property
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property
    <Persistent("d_status")>
    Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property

    <NonPersistent()> ReadOnly Property NilaiDP As Double
      Get
        Return (NilaiDPpersen / 100 * PO.SubTotal)
      End Get
    End Property
    <NonPersistent()> ReadOnly Property PPNValue As Double
      Get
        Return (PajakPersen / 100 * NilaiDP)
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TotalInvoice As Double
      Get
        Return (NilaiDP + PPNValue)
      End Get
    End Property


    Private Function CheckData() As Boolean
      Dim source As String = "DP Pembelian [AP]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
      End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
      End If
      If Uang.Id <> Uang.HutangDagang.MataUang.Id Then
        Throw New Utils.Exception("Mata uang untuk coa [Hutang Dagang] tidak sama dengan mata uang transaksi", -7, "", source)
      End If

      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
          Return False
        End If
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
  '<Persistent("m05cmaininvoicereceipt")>
  'Friend Class SaldoAwalHutang
  '  Inherits Persistent.TransactionMain
  '  Public Sub New(ByVal session As UnitOfWork)
  '    MyBase.New(session)
  '  End Sub
  '  Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '    MyBase.New(session, classInfo)
  '  End Sub

  '  Private _id As Int32
  '  Private _vendor As NuSoft001.Persistent.Kontak
  '  Private _uang As NuSoft001.Persistent.MataUang
  '  Private _nilai As Double
  '  Private _kurs As Double
  '  Private _status As NuSoft001.Persistent.StatusTransaksiEnum
  '  Private _keterangan As String
  '  Private _gl As GlMain
  '  <Persistent("f_vendor")>
  '  Property Vendor As NuSoft001.Persistent.Kontak
  '    Get
  '      Return _vendor
  '    End Get
  '    Set(value As NuSoft001.Persistent.Kontak)
  '      SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
  '    End Set
  '  End Property
  '  <Persistent("d_bbvalue")>
  '  Property Nilai As Double
  '    Get
  '      Return _nilai
  '    End Get
  '    Set(value As Double)
  '      SetPropertyValue(Of Double)("Nilai", _nilai, value)
  '    End Set
  '  End Property
  '  <Persistent("f_currency")>
  '  Property Uang As NuSoft001.Persistent.MataUang
  '    Get
  '      Return _uang
  '    End Get
  '    Set(value As NuSoft001.Persistent.MataUang)
  '      SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
  '    End Set
  '  End Property
  '  <Persistent("d_kurs")>
  '  Property Kurs As Double
  '    Get
  '      Return _kurs
  '    End Get
  '    Set(value As Double)
  '      SetPropertyValue(Of Double)("Kurs", _kurs, value)
  '    End Set
  '  End Property
  '  <Persistent("d_status")>
  '  Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
  '    Get
  '      Return _status
  '    End Get
  '    Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
  '      SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
  '    End Set
  '  End Property
  '  <Persistent("d_remarks")>
  '  Property Uraian As String
  '    Get
  '      Return _keterangan
  '    End Get
  '    Set(value As String)
  '      SetPropertyValue(Of String)("Uraian", _keterangan, value)
  '    End Set
  '  End Property
  '  <Persistent("f_gl")> Property Gl As GlMain
  '    Get
  '      Return _gl
  '    End Get
  '    Set(value As GlMain)
  '      SetPropertyValue(Of GlMain)("Gl", _gl, value)
  '    End Set
  '  End Property
  '  Private Function CheckData() As Boolean
  '    Dim source As String = "Saldo Awal Hutang [BP]"
  '    If Regional Is Nothing Then
  '      Throw New Utils.Exception("Masukkan regional", -1, "", source)
  '      Return False
  '    End If
  '    If Tanggal = Nothing Then
  '      Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
  '      Return False
  '    End If
  '    If Vendor Is Nothing Then
  '      Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
  '      Return False
  '    End If
  '    If Uang Is Nothing Then
  '      Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
  '    End If

  '    If Session.IsNewObject(Me) Then
  '      If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
  '        Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
  '        Return False
  '      End If
  '    End If
  '    Return True
  '  End Function
  '  Protected Overrides Sub OnSaving()
  '    If Not CheckData() Then
  '      Return
  '    End If
  '    If Kode = Nothing Then
  '      Kode = Number.GetNewNumber.Kode
  '    End If
  '    MyBase.OnSaving()
  '  End Sub
  'End Class
End Namespace