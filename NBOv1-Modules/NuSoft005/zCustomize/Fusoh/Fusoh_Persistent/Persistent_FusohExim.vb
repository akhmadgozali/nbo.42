Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent

Namespace Persistent_Fusoh
  <Persistent("m05dmainexim")> Friend Class Persistent_FusohExim
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _po As Persistent_FusohOrderPembelian

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
    <Persistent("f_po")> Property PO As Persistent_FusohOrderPembelian
      Get
        Return _po
      End Get
      Set(value As Persistent_FusohOrderPembelian)
        SetPropertyValue(Of Persistent_FusohOrderPembelian)("PO", _po, value)
      End Set
    End Property

    <Association("Persistent_FusohExim_Detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Persistent_FusohEximDetail)
      Get
        Return GetCollection(Of Persistent_FusohEximDetail)("Detail")
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

    '<Association("fusoh_fk_exim_penerimaanbarang")> ReadOnly Property PenerimaanBarang As XPCollection(Of Fusoh_PenerimaanBarang)
    '	Get
    '		Return GetCollection(Of Fusoh_PenerimaanBarang)("PenerimaanBarang")
    '	End Get
    'End Property
    '<PersistentAlias("PenerimaanBarang.Max(Tanggal)")> ReadOnly Property TanggalPenerimaanBarang As DateTime
    '	Get
    '		Return Convert.ToDateTime(EvaluateAlias("TanggalPenerimaanBarang"))
    '	End Get
    'End Property

    <NonPersistent()> Property DetailForSave As List(Of Persistent_FusohEximDetail_ForSave)
  End Class
  <Persistent("m05edetailexim")> Friend Class Persistent_FusohEximDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Persistent_FusohExim
    Private _poDetail As Persistent_FusohOrderPembelianDetail
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
    <Persistent("p_id"), Association("Persistent_FusohExim_Detail")>
    Property Main As Persistent_FusohExim
      Get
        Return _main
      End Get
      Set(value As Persistent_FusohExim)
        SetPropertyValue(Of Persistent_FusohExim)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_pod")> Property PODetail As Persistent_FusohOrderPembelianDetail
      Get
        Return _poDetail
      End Get
      Set(value As Persistent_FusohOrderPembelianDetail)
        SetPropertyValue(Of Persistent_FusohOrderPembelianDetail)("PODetail", _poDetail, value)
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

    <Association("Persistent_FusohExim_Detail_Serial"), Aggregated> ReadOnly Property Detail As XPCollection(Of Persistent_FusohEximDetailSerial)
      Get
        Return GetCollection(Of Persistent_FusohEximDetailSerial)("Detail")
      End Get
    End Property

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
  End Class
  <Persistent("m05fdetaileximserial")> Friend Class Persistent_FusohEximDetailSerial
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Persistent_FusohEximDetail
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
    <Persistent("p_id"), Association("Persistent_FusohExim_Detail_Serial")> Property Main As Persistent_FusohEximDetail
      Get
        Return _main
      End Get
      Set(value As Persistent_FusohEximDetail)
        SetPropertyValue(Of Persistent_FusohEximDetail)("Main", _main, value)
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
  End Class

  Friend Class Persistent_FusohEximDetail_ForSave
    Property Id As Int64
    Property PODetail As Persistent_FusohOrderPembelianDetail
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
    Property Satuan As NuSoft004.Persistent.Satuan
    Property Qty As Double
    Property OutDiameter As Decimal
    Property InDiameter As Decimal
    Property Thickness As Decimal
    Property Length As Decimal
    Property Weight As Decimal
    Property Catatan As String

    Property SerialForSave As List(Of Persistent_FusohEximDetailSerial_ForSave)
  End Class
  Friend Class Persistent_FusohEximDetailSerial_ForSave
    Property Id As Int64
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
    Property Serial As String
    Property MillSheet As String
    Property LengthIn As Decimal
  End Class
End Namespace