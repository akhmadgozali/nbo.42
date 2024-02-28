Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Namespace Service_Fusoh
  Friend Class Service_FusohPO
    Friend Shared Sub ResetStatusPO(session As UnitOfWork, listPO As List(Of Persistent.Fusoh_OrderPembelian))
      For Each po In listPO
        '=== cek jumlah total qty inv dengan po
        Dim qtyPO = po.Detail.Sum(Function(s) s.Qty)
        Dim qtyInv = po.Detail.SelectMany(Function(x) x.InvoiceDetail).Sum(Function(s) s.Qty)

        If qtyInv <= 0 Then
          po.StatusTransaksi = StatusTransaksiEnum.Posting
        ElseIf qtyInv < qtyPO Then
          po.StatusTransaksi = StatusTransaksiEnum.InProgress
        Else
          po.StatusTransaksi = StatusTransaksiEnum.Finish
        End If
      Next
      session.CommitChanges()
    End Sub
  End Class
End Namespace