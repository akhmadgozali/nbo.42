Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class UI_SanyuDataStock
  Dim _idPenerimaan As Int64
  Sub New(xIDPenerimaan As Long)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _idPenerimaan = xIDPenerimaan
  End Sub
  Overrides Sub FirstLoad()
    Dim setting As New NuSoft001.Logic.FinaSetting(session)

    'Dim xDataProduksi As New XPCollection(Of Persistent.SanYu_ProduksiDetail)(session, New BinaryOperator("Pembelian.Id", _idPenerimaan, BinaryOperatorType.Equal))
    'Dim b = From z In xDataProduksi Group z By z.Main.RencanaProduksi.Id Into Group Select Id

    'Dim xDataRencanaProduksi As New XPCollection(Of Persistent.SanYu_RencanaProduksi)(session, New InOperator("Id", b.ToArray))

    'Dim xDataProduksiDetail As New XPCollection(Of Persistent.SanYu_ProduksiDetail)(session, New InOperator("Main.RencanaProduksi", xDataRencanaProduksi.ToArray))
    'xGrid.DataSource = Nothing
    Dim xDataProduksiDetail As New XPCollection(Of Persistent.SanYu_ProduksiDetail)(session)
    xGrid.DataSource = Nothing
    xGrid.DataSource = xDataProduksiDetail

  End Sub
End Class