Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
  <Persistent("m05dmainexim")> Friend Class Fusoh_Exim
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _po As Fusoh_OrderPembelian
    Private _ri As Fusoh_PenerimaanInvoice

    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("f_vendor")> Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
      End Set
    End Property
    <Persistent("f_po"), Association("fusoh_fk_exim_ordermain")> Property PO As Fusoh_OrderPembelian
      Get
        Return _po
      End Get
      Set(value As Fusoh_OrderPembelian)
        SetPropertyValue(Of Fusoh_OrderPembelian)("PO", _po, value)
      End Set
    End Property
    <Persistent("f_invoicereceipt"), Association("fusoh_eximmain_invoicemain")> Property Invoice As Fusoh_PenerimaanInvoice
      Get
        Return _ri
      End Get
      Set(value As Fusoh_PenerimaanInvoice)
        SetPropertyValue(Of Fusoh_PenerimaanInvoice)(NameOf(Invoice), _ri, value)
      End Set
    End Property

    <Association("fusoh_fk_exim_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_EximDetail)
      Get
        Return GetCollection(Of Fusoh_EximDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Weight)")> ReadOnly Property TotalWeight As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalWeight"))
      End Get
    End Property

    <Association("fusoh_fk_exim_penerimaanbarang")> ReadOnly Property PenerimaanBarang As XPCollection(Of Fusoh_PenerimaanBarang)
      Get
        Return GetCollection(Of Fusoh_PenerimaanBarang)("PenerimaanBarang")
      End Get
    End Property
    <PersistentAlias("PenerimaanBarang.Max(Tanggal)")> ReadOnly Property TanggalPenerimaanBarang As DateTime
      Get
        Return Convert.ToDateTime(EvaluateAlias("TanggalPenerimaanBarang"))
      End Get
    End Property
    <Association("fusoh_fk_exim_invoice")> ReadOnly Property InvoicePembelian As XPCollection(Of Fusoh_PenerimaanInvoice)
      Get
        Return GetCollection(Of Fusoh_PenerimaanInvoice)("InvoicePembelian")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property InvoiceReffVendor As String
      Get
        If InvoicePembelian.Count > 0 Then
          Return InvoicePembelian(0).NoReffVendor
        Else
          Return ""
        End If
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Exim [EX]"
      If IsDeleted Then
        Return True
      End If
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -3, "", source)
        Return False
      End If
      If Vendor.KontakDomestik AndAlso PO Is Nothing Then
        Throw New Utils.Exception("Masukkan PO", -4, "", source)
        Return False
      End If
      If Not Vendor.KontakDomestik AndAlso Invoice Is Nothing Then
        Throw New Utils.Exception("Masukkan Nomor Invoice", -4, "", source)
        Return False
      End If

      ''======= PINDAH KE DIALOG
      ''======= Cek Periode
      'If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
      '  Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
      '  Return False
      'End If
      ''======= Cek Sebelum Awal Periode
      'If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
      '  Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
      '  Return False
      'End If
      ''======= PINDAH KE DIALOG

      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -5, "", source)
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

  <Persistent("m05edetailexim")> Friend Class Fusoh_EximDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_Exim
    Private _poDetail As Fusoh_OrderPembelianDetail
    Private _riDetail As Fusoh_PenerimaanInvoiceDetail
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _catatan As String

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fusoh_fk_exim_detail")>
    Property Main As Fusoh_Exim
      Get
        Return _main
      End Get
      Set(value As Fusoh_Exim)
        SetPropertyValue(Of Fusoh_Exim)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_pod")> Property PODetail As Fusoh_OrderPembelianDetail
      Get
        Return _poDetail
      End Get
      Set(value As Fusoh_OrderPembelianDetail)
        SetPropertyValue(Of Fusoh_OrderPembelianDetail)("PODetail", _poDetail, value)
      End Set
    End Property
    <Persistent("f_rid")> Property RIDetail As Fusoh_PenerimaanInvoiceDetail
      Get
        Return _riDetail
      End Get
      Set(value As Fusoh_PenerimaanInvoiceDetail)
        SetPropertyValue(Of Fusoh_PenerimaanInvoiceDetail)("RIDetail", _riDetail, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("f_uom")> Property Satuan As NuSoft004.Persistent.Satuan
      Get
        Return _satuan
      End Get
      Set(value As NuSoft004.Persistent.Satuan)
        SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_qty")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_od")> Property OutDiameter As Decimal
      Get
        Return _outDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("OutDiameter", _outDiameter, value)
      End Set
    End Property
    <Persistent("d_id")> Property InDiameter As Decimal
      Get
        Return _inDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("InDiameter", _inDiameter, value)
      End Set
    End Property
    <Persistent("d_tickness")> Property Thickness As Decimal
      Get
        Return _thickness
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
      End Set
    End Property
    <Persistent("d_length")> Property Length As Decimal
      Get
        Return _length
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Length", _length, value)
      End Set
    End Property
    <Persistent("d_weight")> Property Weight As Decimal
      Get
        Return _weight
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Weight", _weight, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property

    <Association("fusoh_fk_exim_detailserial"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_EximDetailSerial)
      Get
        Return GetCollection(Of Fusoh_EximDetailSerial)("Detail")
      End Get
    End Property
    <NonPersistent> Property SerialTemp As List(Of Fusoh_EximDetailSerial_Temp)

    <PersistentAlias("Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Exim [EX]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order pembelian", -99, "", source)
        Return False
      End If
      'If _poDetail Is Nothing AndAlso Not IsDeleted Then
      '  Throw New Utils.Exception("Masukkan po detail", -99, "", source)
      '  Return False
      'End If
      If _item Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _qty = Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
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
  <Persistent("m05fdetaileximserial")> Friend Class Fusoh_EximDetailSerial
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_EximDetail
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _serial As String
    Private _millSheet As String
    Private _lengthIn As Decimal

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fusoh_fk_exim_detailserial")> Property Main As Fusoh_EximDetail
      Get
        Return _main
      End Get
      Set(value As Fusoh_EximDetail)
        SetPropertyValue(Of Fusoh_EximDetail)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("d_serial")> Property Serial As String
      Get
        Return _serial
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Serial", _serial, value)
      End Set
    End Property
    <Persistent("d_millsheet")> Property MillSheet As String
      Get
        Return _millSheet
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("MillSheet", _millSheet, value)
      End Set
    End Property
    <Persistent("d_length_in")> Property LengthIn As Decimal
      Get
        Return _lengthIn
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("LengthIn", _lengthIn, value)
      End Set
    End Property

    <PersistentAlias("Main.Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("Main.Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Exim [EX]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order pembelian", -99, "", source)
        Return False
      End If
      If _item Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _serial = Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan nomor serial", -99, "", source)
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

  Friend Class Fusoh_EximDetailSerial_Temp
    Property Id As Int64
    Property Main As Fusoh_EximDetail
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
    Property Serial As String
    Property MillSheet As String
    Property LengthIn As Decimal
  End Class

	<Persistent("m04vwgr")> Friend Class vwFusohPenerimaanBarang
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		<Key()> Property id As Int64
		Property primary_main As Persistent.Fusoh_PenerimaanBarangDetail
		Property Main As Persistent.Fusoh_PenerimaanBarang
		Property exim As Persistent.Fusoh_Exim
		Property ri As Persistent.Fusoh_PenerimaanInvoice
		Property item As NuSoft004.Persistent.Fusoh_Barang
		Property qty As Double
		Property catatan As String
	End Class
End Namespace