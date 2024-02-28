Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_SanYuPenerimaanBarangLokal
  Property instance As Persistent.SanYu_PenerimaanBarang
  Property Vendor As NuSoft001.Persistent.Kontak
  Property listPO As List(Of Persistent.SanYu_OrderPembelian)
  Property POResult As List(Of Persistent.SanYu_OrderPembelian)
  Overrides Sub InitializeData()
    AutoCloseOnSave = True
    Btn2IsClosedButton = True

    xGrid.DataSource = New XPCollection(Of Persistent.SanYu_OrderPembelian)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("DariDomestik", 1, BinaryOperatorType.Equal), New BinaryOperator("Vendor", Vendor, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
    'For i = 0 To listPO.count - 1
    '  Dim row = xGridView.LocateByValue("Id", listPO(i).Id)
    '  xGridView.SelectRow(row)
    'Next
  End Sub
  Public Overrides Sub Btn1Click()
    POResult = New List(Of Persistent.SanYu_OrderPembelian)
    Dim x = xGridView.GetSelectedRows
    For i = x.GetLowerBound(0) To x.GetUpperBound(0)
      Dim selected = CType(xGridView.GetRow(x(i)), Persistent.SanYu_OrderPembelian)
      POResult.Add(selected)
    Next
  End Sub
End Class