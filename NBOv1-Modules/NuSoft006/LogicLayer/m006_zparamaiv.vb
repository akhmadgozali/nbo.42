Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m06dmaininvoiceparama")>
  Friend Class zParamaInvoicePenjualan
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _customer As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _tglberlaku As Date
    Private _leadtime As String
    Private _bagpembelian As NuSoft001.Persistent.Kontak
    Private _via As NuSoft005.Persistent.Via
    Private _fob As NuSoft005.Persistent.eTipeFOB
    Private _termin As NuSoft005.Persistent.Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _pajak As NuSoft005.Persistent.eTipePajak
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _othercost As Double
    Private _noPPN As String
    Private _gl As Persistent.GlMain
    Private _so As Persistent.zParamaOrderPenjualan
    Private _proyek As NuSoft001.Persistent.Proyek
    <Persistent("f_customer")>
    Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
      End Set
    End Property
    <Persistent("d_contact")>
    Property KontakPerson As String
      Get
        Return _kontakperson
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
      End Set
    End Property
    <Persistent("d_efectivedate")>
    Property TanggalBerlaku As Date
      Get
        Return _tglberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of String)("TanggalBerlaku", _tglberlaku, value)
      End Set
    End Property
    <Persistent("d_leadtime")>
    Property LeadTime As String
      Get
        Return _leadtime
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("LeadTime", _leadtime, value)
      End Set
    End Property
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _bagpembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
      End Set
    End Property
    <Persistent("f_via")>
    Property Via As NuSoft005.Persistent.Via
      Get
        Return _via
      End Get
      Set(value As NuSoft005.Persistent.Via)
        SetPropertyValue(Of NuSoft005.Persistent.Via)("Via", _via, value)
      End Set
    End Property
    <Persistent("d_fob")>
    Property FOB As NuSoft005.Persistent.eTipeFOB
      Get
        Return _fob
      End Get
      Set(value As NuSoft005.Persistent.eTipeFOB)
        SetPropertyValue(Of NuSoft005.Persistent.eTipeFOB)("FOB", _fob, value)
      End Set
    End Property
    <Persistent("f_termin")>
    Property Termin As NuSoft005.Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As NuSoft005.Persistent.Termin)
        SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
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
    <Persistent("d_taxtype")>
    Property TipePajak As NuSoft005.Persistent.eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As NuSoft005.Persistent.eTipePajak)
        SetPropertyValue(Of NuSoft005.Persistent.eTipePajak)("Pajak", _pajak, value)
      End Set
    End Property
    <Persistent("d_nofakturppn")>
    Property NoSNPPN As String
      Get
        Return _noPPN
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPN", _noPPN, value)
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
    '<Persistent("f_proyek")>
    'Property Proyek As NuSoft001.Persistent.Proyek
    '  Get
    '    Return _proyek
    '  End Get
    '  Set(value As NuSoft001.Persistent.Proyek)
    '    SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
    '  End Set
    'End Property
    <Persistent("d_status")>
    Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("d_othercost")>
    Property BiayaLain As Double
      Get
        Return _othercost
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
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
    <Persistent("f_order")> Property NoOrder As zParamaOrderPenjualan
      Get
        Return _so
      End Get
      Set(value As zParamaOrderPenjualan)
        SetPropertyValue(Of zParamaOrderPenjualan)("NoOrder", _so, value)
      End Set
    End Property
    <PersistentAlias("Detail.Sum(SubTotal)")> ReadOnly Property xSubTotal As Double 'jika harga sudah termasuk pajak maka kalikan 110/100
      Get
        Return Convert.ToDouble(EvaluateAlias("xSubTotal"))
      End Get
    End Property
    <PersistentAlias("iif(TipePajak = 2 , (0.90909090 * xSubTotal) , xSubTotal)")> ReadOnly Property SubTotal As Double 'jika harga sudah termasuk pajak maka kalikan 110/100
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("iif(TipePajak = 0 , 0 , (0.1 * (SubTotal)))")> ReadOnly Property PPN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPN"))
      End Get
    End Property
    <PersistentAlias("SubTotal + PPN")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
      Get
        Return Convert.ToString(EvaluateAlias("Terbilang"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
      Get
        Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
      End Get
    End Property
    <NonPersistent()> ReadOnly Property NilaiInvoice As Double
      Get
        Return Total
      End Get
    End Property
    <Association("fk_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of zParamaInvoicePenjualanDetail)
      Get
        Return GetCollection(Of zParamaInvoicePenjualanDetail)("Detail")
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Invoice Penjualan [IV]"
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
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
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
  <Persistent("m06edetailinvoiceparama")>
  Friend Class zParamaInvoicePenjualanDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.zParamaInvoicePenjualan
    Private _desc As String
    Private _person As Double
    Private _days As Double
    Private _price As Double
    Private _header As Boolean
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_invoice_detail")>
    Property Main As zParamaInvoicePenjualan
      Get
        Return _main
      End Get
      Set(value As zParamaInvoicePenjualan)
        SetPropertyValue(Of zParamaInvoicePenjualan)("Main", _main, value)
      End Set
    End Property
    <Persistent("d_header")>
    Property Header As Boolean
      Get
        Return _header
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Header", _header, value)
      End Set
    End Property
    <Persistent("d_description")>
    Property Description As String
      Get
        Return _desc
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Description", _desc, value)
      End Set
    End Property
    <Persistent("d_person")>
    Property Person As Double
      Get
        Return _person
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Person", _person, value)
      End Set
    End Property
    <Persistent("d_days")>
    Property Days As Double
      Get
        Return _days
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Days", _days, value)
      End Set
    End Property
    <Persistent("d_price")>
    Property Harga As Double
      Get
        Return _price
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _price, value)
      End Set
    End Property
    <PersistentAlias("Days * Harga")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Invoice Penjualan [IV]"
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order penjualan", -99, "", source)
        Return False
      End If
      If _desc Is Nothing Then
        Throw New Utils.Exception("Masukkan Keterangan", -99, "", source)
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