Imports DevExpress.Xpo

Namespace Service_Fusoh
  Friend Class Service_FusohInvoice
    Friend Shared Function GetDaftarPODariInvoice(invoice As Persistent.Fusoh_PenerimaanInvoice) As List(Of Persistent.Fusoh_OrderPembelian)
      If Not invoice Is Nothing Then
        Return invoice.Detail.Where(Function(w) Not w.PODetail Is Nothing).GroupBy(Function(g) g.PODetail.Main).Select(Function(s) s.Key).ToList
      End If
      Return Nothing
    End Function

    Friend Shared Sub UpdateStatusPO(session As UnitOfWork, invoice As Persistent.Fusoh_PenerimaanInvoice)
      Dim nomorPO = GetDaftarPODariInvoice(invoice)
      Service_FusohPO.ResetStatusPO(session, nomorPO)
    End Sub
  End Class
End Namespace