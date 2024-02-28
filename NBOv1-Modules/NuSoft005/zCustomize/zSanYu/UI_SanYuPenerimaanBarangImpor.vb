Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_SanYuPenerimaanBarangImpor
  Property instance As Persistent.SanYu_PenerimaanBarang
  Property Vendor As NuSoft001.Persistent.Kontak
  Property listPO As List(Of Persistent.SanYu_PenerimaanInvoice)
  Property IVResult As List(Of Persistent.SanYu_PenerimaanInvoice)
  Overrides Sub InitializeData()
    AutoCloseOnSave = True
    Btn2IsClosedButton = True

    xGrid.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanInvoice)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", Vendor, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}))) '_source.Where(Function(w) w.SisaLength > 0)
    'For i = 0 To listPO.count - 1
    '  Dim row = xGridView.LocateByValue("Id", listPO(i).Id)
    '  xGridView.SelectRow(row)
    'Next
  End Sub
  Public Overrides Sub Btn1Click()
    IVResult = New List(Of Persistent.SanYu_PenerimaanInvoice)
    Dim x = xGridView.GetSelectedRows
    For i = x.GetLowerBound(0) To x.GetUpperBound(0)
      Dim selected = CType(xGridView.GetRow(x(i)), Persistent.SanYu_PenerimaanInvoice)
      IVResult.Add(selected)
    Next
  End Sub
  

End Class