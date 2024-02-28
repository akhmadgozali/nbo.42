Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_SanYuPenerimaanInvoicePO
  'Private _source As List(Of NonPersistent.Fusoh_DataSerial)
  'Property Serial As List(Of Persistent.Fusoh_OrderProduksiBahanBaku)
  'Property Item As Persistent.Fusoh_Barang
  'Property SerialResult As List(Of Persistent.Fusoh_OrderProduksiBahanBaku)
  Property instance As Persistent.SanYu_PenerimaanInvoice
  Property Vendor As NuSoft001.Persistent.Kontak
  Property listPO As List(Of Persistent.SanYu_OrderPembelian)
  Property POResult As List(Of Persistent.SanYu_OrderPembelian)
  Overrides Sub InitializeData()
    AutoCloseOnSave = True
    Btn2IsClosedButton = True

    xGrid.DataSource = New XPCollection(Of Persistent.SanYu_OrderPembelian)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("DariDomestik", 0, BinaryOperatorType.Equal), New BinaryOperator("Vendor", Vendor, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}))) '_source.Where(Function(w) w.SisaLength > 0)
    'For i = 0 To listPO.count - 1
    '  Dim row = xGridView.LocateByValue("Id", listPO(i).Id)
    '  xGridView.SelectRow(row)
    'Next
  End Sub
  Public Overrides Sub Btn1Click()
    Dim x = xGridView.GetSelectedRows
    'If x.Count > 1 Then
    '  Throw New Utils.Exception("Anda hanya diperbolehkan memilih satu data.", 0, "", "Simpan Transaksi")
    '  Exit Sub
    'End If

    POResult = New List(Of Persistent.SanYu_OrderPembelian)
    For i = x.GetLowerBound(0) To x.GetUpperBound(0)
      Dim selected = CType(xGridView.GetRow(x(i)), Persistent.SanYu_OrderPembelian)
      POResult.Add(selected)
    Next
  End Sub
End Class