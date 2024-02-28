Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_SanyuDataProduksi2
  Dim _idStockProduksi As Int64
  Sub New(xIDStockProduksi As Long)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _idStockProduksi = xIDStockProduksi
  End Sub
  Overrides Sub FirstLoad()
    Dim setting As New NuSoft001.Logic.FinaSetting(session)
    'Dim xStockMain As Long
    'Dim xDataProduksi As New XPCollection(Of Persistent.SanYu_ProduksiDetail)(session, New BinaryOperator("Pembelian.Id", _idPenerimaan, BinaryOperatorType.Equal))
    'Dim b = From z In xDataProduksi Group z By z.Main.RencanaProduksi.Id Into Group Select Id

    Dim xStock As New XPCollection(Of Persistent.SanYu_StokDetail)(session, New BinaryOperator("Id", _idStockProduksi, BinaryOperatorType.Equal))
    Dim xProduksi As New XPCollection(Of Persistent.SanYu_ProduksiMain)(session, New BinaryOperator("StockHasil.Id", xStock(0).Main.Id, BinaryOperatorType.Equal))
    If xProduksi.Count > 0 Then
      Dim xRencanaProduksi As Int64 = xProduksi(0).RencanaProduksi.Id

      Dim xDataProduksi As New XPCollection(Of Persistent.SanYu_ProduksiDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.RencanaProduksi.Id", xRencanaProduksi, BinaryOperatorType.Equal), New BinaryOperator("xN", True, BinaryOperatorType.Equal)))
      xGrid.DataSource = xDataProduksi
    End If
  End Sub
End Class