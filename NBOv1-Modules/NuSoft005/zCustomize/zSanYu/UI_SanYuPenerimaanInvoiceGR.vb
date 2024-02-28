Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_SanYuPenerimaanInvoiceGR
  Property instance As Persistent.SanYu_PenerimaanInvoice
  Property Vendor As NuSoft001.Persistent.Kontak
  Property listGR As List(Of Persistent.SanYu_PenerimaanBarang)
  Property GRResult As List(Of Persistent.SanYu_PenerimaanBarang)
  Overrides Sub InitializeData()
    AutoCloseOnSave = True
    Btn2IsClosedButton = True

    xGrid.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanBarang)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("FromDomestik", 1, BinaryOperatorType.Equal), New BinaryOperator("Vendor", Vendor, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}))) '_source.Where(Function(w) w.SisaLength > 0)
    'For i = 0 To listPO.count - 1
    '  Dim row = xGridView.LocateByValue("Id", listPO(i).Id)
    '  xGridView.SelectRow(row)
    'Next
  End Sub
  Public Overrides Sub Btn1Click()
    GRResult = New List(Of Persistent.SanYu_PenerimaanBarang)
    Dim x = xGridView.GetSelectedRows
    For i = x.GetLowerBound(0) To x.GetUpperBound(0)
      Dim selected = CType(xGridView.GetRow(x(i)), Persistent.SanYu_PenerimaanBarang)
      GRResult.Add(selected)
    Next
  End Sub
End Class