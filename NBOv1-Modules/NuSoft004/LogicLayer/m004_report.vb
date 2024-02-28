Imports DevExpress.Xpo
Namespace Persistent.Report
  <Persistent("m04vwkartustock")> Friend Class KartuStock
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property Tanggal As Date
    Property NoBukti As String
    Property Barang As Persistent.Barang
    Property Uraian As String
    Property SaldoAwal As Double
    Property SaldoAwalNilai As Double
    Property Masuk As Double
    Property Keluar As Double
    Property Harga As Double
    Property HPP As Double
    Property Gudang As Persistent.Gudang
  End Class
  <Persistent("m04vwsaldo")> Friend Class SaldoStock
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property Kode As String
    Property Nama As String
    Property Satuan As Persistent.Satuan
    Property Kategori As Persistent.Kategori
    Property SubKategori As Persistent.SubKategori
    Property Merk As Persistent.Merk
    Property SaldoAwal As Double
    Property QtyIn As Double
    Property QtyOut As Double
    Property SaldoAwalNilai As Double
    Property QtyInNilai As Double
    Property QtyOutNilai As Double
  End Class
End Namespace