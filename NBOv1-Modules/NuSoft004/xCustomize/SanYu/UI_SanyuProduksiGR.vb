Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_SanyuProduksiGR
  Property instance As Persistent.SanYu_ProduksiPembantu
  Property Vendor As NuSoft001.Persistent.Kontak
  Property listGR As List(Of Persistent.SanYu_StokDetail)
  Property GRResult As List(Of Persistent.SanYu_StokDetail)
  Overrides Sub InitializeData()
    AutoCloseOnSave = True
    Btn2IsClosedButton = True

    xGrid.DataSource = New XPCollection(Of Persistent.SanYu_StokDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.gr, BinaryOperatorType.Equal), New BinaryOperator("Barang.Id", instance.Barang.Id, BinaryOperatorType.Equal))) '_source.Where(Function(w) w.SisaLength > 0)

    'For i = 0 To listPO.count - 1
    '  Dim row = xGridView.LocateByValue("Id", listPO(i).Id)
    '  xGridView.SelectRow(row)
    'Next
  End Sub
  Public Overrides Sub Btn1Click()
    GRResult = New List(Of Persistent.SanYu_StokDetail)
    Dim x = xGridView.GetSelectedRows
    For i = x.GetLowerBound(0) To x.GetUpperBound(0)
      Dim selected = CType(xGridView.GetRow(x(i)), Persistent.SanYu_StokDetail)
      GRResult.Add(selected)
    Next
  End Sub
End Class