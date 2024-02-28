Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Namespace Persistent
  <Persistent("m04cbeginningbalance")> _
  Friend Class SaldoAwal
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _item As Barang
    Private _gudang As Gudang
    Private _satuan As Satuan
    Private _qty As Double
    Private _harga As Double
    <Persistent("f_item")>
    Property Barang As Barang
      Get
        Return _item
      End Get
      Set(value As Barang)
        SetPropertyValue(Of Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("f_uom")>
    Property Satuan As Satuan
      Get
        Return _satuan
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("f_warehouse")>
    Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("d_qty")>
    Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_price")>
    Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
      End Set
    End Property
    <NonPersistent()> ReadOnly Property Total As Double
      Get
        Return _qty * _harga
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Saldo Awal"
      If Barang Is Nothing Then
        Throw New Utils.Exception("Masukkan Kode Barang", 1, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -2, "", source)
        Return False
      End If
      If _qty <= 0 Then
        Throw New Utils.Exception("Masukkan qty dengan benar", -3, source)
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