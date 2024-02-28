Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.Utils.CustomAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  Enum BankCaraBayar
    <EnumDescription("Tunai")> Tunai
    <EnumDescription("Cek / Giro")> CekGiro
    <EnumDescription("Cek / Giro (Tempo")> CekGiroTempo
    <EnumDescription("Transfer")> Transfer
    <EnumDescription("Lain-Lain")> LainLain
  End Enum

  <Persistent("m06cmainpayment")>
  Friend Class PembayaranPiutang
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _customer As NuSoft001.Persistent.Kontak
    Private _uraian As String
    Private _pembayaranpajak As Boolean
    Private _coakasbank As NuSoft001.Persistent.Coa
    Private _kurs As Double
    Private _total As Double
    Private _totalvalas As Double
    Private _totaladminbank As Double
    Private _totaldiscount As Double
    Private _totalpembulatan As Double
    Private _totalpph As Double
    Private _nomorpph As String
    Private _tipepembayaran As BankCaraBayar
    Private _nomorpembayaran As String
    Private _nomorbank As String
    Private _tgltempo As Date
    Private _gl As GlMain
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
      End Set
    End Property
    <Persistent("d_taxpayment")>
    Property PembayaranPajak As Boolean
      Get
        Return _pembayaranpajak
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("PembayaranPajak", _pembayaranpajak, value)
      End Set
    End Property
    <Persistent("d_remarks")>
    Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("f_coa")>
    Property coakasbank As NuSoft001.Persistent.Coa
      Get
        Return _coakasbank
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("coakasbank", _coakasbank, value)
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
    <Persistent("d_value")>
    Property Total As Double
      Get
        Return _total
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Total", _total, value)
      End Set
    End Property
    <Persistent("d_valuevalas")>
    Property TotalValas As Double
      Get
        Return _totalvalas
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalValas", _totalvalas, value)
      End Set
    End Property
    <Persistent("d_bankadmin")>
    Property TotalAdminBank As Double
      Get
        Return _totaladminbank
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalAdminBank", _totaladminbank, value)
      End Set
    End Property
    <Persistent("d_discount")>
    Property TotalDiscount As Double
      Get
        Return _totaldiscount
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalDiscount", _totaldiscount, value)
      End Set
    End Property
    <Persistent("d_rounding")>
    Property TotalPembulatan As Double
      Get
        Return _totalpembulatan
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalPembulatan", _totalpembulatan, value)
      End Set
    End Property
    <Persistent("d_pphvalue")>
    Property TotalPPH As Double
      Get
        Return _totalpph
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalPPH", _totalpph, value)
      End Set
    End Property
    <Persistent("d_pphnumber")>
    Property NomorPPH As String
      Get
        Return _nomorpph
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorPPH", _nomorpph, value)
      End Set
    End Property
    <Persistent("d_typepayment")>
    Property BankCaraBayar As BankCaraBayar
      Get
        Return _tipepembayaran
      End Get
      Set(value As BankCaraBayar)
        SetPropertyValue(Of BankCaraBayar)("BankCaraBayar", _tipepembayaran, value)
      End Set
    End Property
    <Persistent("d_numberpayment")>
    Property BankNoPembayaran As String
      Get
        Return _nomorpembayaran
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("BankNoPembayaran", _nomorpembayaran, value)
      End Set
    End Property
    <Persistent("d_bankaccountnumber")>
    Property BankAccount As String
      Get
        Return _nomorbank
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("BankAccount", _nomorbank, value)
      End Set
    End Property
    <Persistent("d_tempo")>
    Property Tempo As Date
      Get
        Return _tgltempo
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("Tempo", _tgltempo, value)
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
    <Persistent("f_gl")> Property Gl As GlMain
      Get
        Return _gl
      End Get
      Set(value As GlMain)
        SetPropertyValue(Of GlMain)("Gl", _gl, value)
      End Set
    End Property
    <Association("fk_pembayaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PembayaranPiutangDetail)
      Get
        Return GetCollection(Of PembayaranPiutangDetail)("Detail")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property SelisihKurs As Double
      Get
        Return Detail.Sum(Function(m) m.NilaiBayar * m.NoInvoice.Kurs) - Detail.Sum(Function(m) m.NilaiBayar * m.Kurs)
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Pembayaran Piutang [CP]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
        Return False
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
  <Persistent("m06ddetailpayment")>
  Friend Class PembayaranPiutangDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.PembayaranPiutang
    Private _idinvoice As Persistent.InvoicePenjualan
    Private _urutan As Byte
    Private _amount As Double
    Private _kurs As Double
    Private _amountcash As Double
    Private _amountreturn As Double
    Private _catatan As String
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_pembayaran_detail")>
    Property Main As PembayaranPiutang
      Get
        Return _main
      End Get
      Set(value As PembayaranPiutang)
        SetPropertyValue(Of PembayaranPiutang)("Main", _main, value)
      End Set
    End Property
    <Persistent("p_idinvoice")>
    Property NoInvoice As Persistent.InvoicePenjualan
      Get
        Return _idinvoice
      End Get
      Set(value As Persistent.InvoicePenjualan)
        SetPropertyValue(Of Persistent.InvoicePenjualan)("NoInvoice", _idinvoice, value)
      End Set
    End Property
    <Persistent("d_urutan")> Property Urutan As Byte
      Get
        Return _urutan
      End Get
      Set(value As Byte)
        SetPropertyValue(Of Byte)("Urutan", _urutan, value)
      End Set
    End Property
    <Persistent("d_amount")>
    Property NilaiBayar As Double
      Get
        Return _amount
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayar", _amount, value)
      End Set
    End Property
    <Persistent("d_kurspayment")>
    Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("d_amountcash")>
    Property NilaiBayarCash As Double
      Get
        Return _amountcash
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayarCash", _amountcash, value)
      End Set
    End Property
    <Persistent("d_amountreturn")>
    Property NilaiBayarRetur As Double
      Get
        Return _amountreturn
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayarRetur", _amountreturn, value)
      End Set
    End Property
    <Persistent("d_remarks")>
    Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama pembayaran hutang", -99, "", source)
        Return False
      End If
      If _idinvoice Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor invoice", -99, "", source)
        Return False
      End If
      If _amountcash = 0 Then
        Throw New Utils.Exception("Masukkan jumlah pembayaran", -99, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      NilaiBayar = NilaiBayarCash + NilaiBayarRetur
      MyBase.OnSaving()
    End Sub
  End Class

  'query untuk sisa piutang invoice
  <Persistent("m06vwinvoice")> Friend Class ViewInvoice
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property NoInvoice As InvoicePenjualan
    Property Urutan As Byte
    Property Terbayar As Double
    Property NilaiBayarCash As Double
    Property Kurs As Double
    Property OK As Boolean
    Property Catatan As String
  End Class
End Namespace