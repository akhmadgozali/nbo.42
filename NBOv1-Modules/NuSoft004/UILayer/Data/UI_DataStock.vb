Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class UI_DataStock
  Dim _idItem As Int64
  Sub New(xIDItem As Long)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _idItem = xIDItem
  End Sub
  Overrides Sub FirstLoad()
    Dim setting As New NuSoft001.Logic.FinaSetting(session)

    Dim DataTransaksi As New XPCollection(Of Persistent.StockDetail)(session, New BinaryOperator("Barang.Id", _idItem, BinaryOperatorType.Equal))
    Dim b = From z In DataTransaksi Group z By z.Gudang, z.Barang Into Group Select Gudang, Barang, Stock = Group.Sum(Function(x) x.QtyIn - x.QtyOut)

    xGrid.DataSource = Nothing
    xGrid.DataSource = b

    Dim zBarang As Persistent.Barang = session.FindObject(Of Persistent.Barang)(New BinaryOperator("Id", _idItem, BinaryOperatorType.Equal))
    If Not zBarang Is Nothing Then
      Me.Text = zBarang.Kode & " ~ " & zBarang.Nama
    End If
  End Sub
End Class