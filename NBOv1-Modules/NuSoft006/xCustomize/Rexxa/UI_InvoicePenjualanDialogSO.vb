Imports DevExpress.Data.Filtering

Public Class zRexaUI_InvoicePenjualanDialogSO
  Private itemToEdit As Persistent.zRexaInvoicePenjualan
  Private _customer As NuSoft001.Persistent.Kontak
  Sub New(xCustomer As NuSoft001.Persistent.Kontak)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    NoDropIdentityMap = True
    _customer = xCustomer
  End Sub
  Overrides Sub LoadBeforeInitialize()
    xGrid.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.OrderPenjualan)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", _customer, BinaryOperatorType.Equal), New BinaryOperator("StatusTransaksi", NuSoft001.Persistent.StatusTransaksiEnum.Posting)))
  End Sub
  Overrides Sub SimpanData()
    Dim item As Persistent.zRexaInvoicePenjualanDetail
    If xGridView.SelectedRowsCount = 0 Then
      Throw New Exception("Silahkan pilih nomor order yang ingin diproses")
      Return
    End If
    Dim xIDOrder As Int64, pI As Long
    For i = 0 To xGridView.SelectedRowsCount - 1
      If (xGridView.GetSelectedRows()(i) >= 0) Then
        xIDOrder = Convert.ToInt64(xGridView.GetRowCellValue(xGridView.GetSelectedRows()(i), "Id").ToString())
        Dim xDataSO As New DevExpress.Xpo.XPCollection(Of Persistent.zRexaOrderPenjualanDetail)(session, New BinaryOperator("Main.Id", xIDOrder, BinaryOperatorType.Equal))
        For pI = 0 To xDataSO.Count - 1
          'cari dahulu, jika ada maka lewati
          If Not itemToEdit.Detail.ToList.Exists(Function(m) m.OrderPenjualan.Id = xDataSO(pI).Id) Then
            item = New Persistent.zRexaInvoicePenjualanDetail(session)
            'item.Main = itemToEdit
            item.Barang = xDataSO(pI).Barang
            item.Qty = xDataSO(pI).Qty
            item.Satuan = xDataSO(pI).Satuan
            item.Harga = xDataSO(pI).Harga
            item.OrderPenjualan = xDataSO(pI)
            itemToEdit.Detail.Add(item)
          End If
        Next
      End If
    Next
  End Sub
End Class