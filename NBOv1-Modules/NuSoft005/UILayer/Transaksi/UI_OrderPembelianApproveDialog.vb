Imports DevExpress.Data.Filtering
Public Class UI_OrderPembelianApproveDialog
  Private xIDPO As Int64
  Private xApprove As Boolean
  Private zdtPO As Persistent.OrderPembelian
  Sub New(pApprove As Boolean, pidPO As Int64)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    NoDropIdentityMap = True
    xApprove = pApprove
    xIDPO = pidPO
  End Sub
  Overrides Sub LoadBeforeInitialize()
    Me.Text = IIf(xApprove = True, "Approve Purchase Order", "Reject Purchase Order")
    zdtPO = session.FindObject(Of Persistent.OrderPembelian)(New BinaryOperator("Id", xIDPO, BinaryOperatorType.Equal))
  End Sub
  Overrides Sub LoadAfterInitialize()
    Me.Text = IIf(xApprove = True, "Approve Purchase Order", "Reject Purchase Order")
    If Not zdtPO Is Nothing Then
      txtNoTransaksi.Text = zdtPO.Kode
      txtTanggal.EditValue = zdtPO.Tanggal
      txtVendor.Text = zdtPO.Vendor.Nama
    End If
  End Sub
  Overrides Sub SimpanData()
    If txtCatatan.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan input untuk catatan.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    If xApprove = True Then
      zdtPO.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Approved
    Else
      zdtPO.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected
    End If
    zdtPO.CatatanApprove = txtCatatan.EditValue

    session.CommitChanges()
  End Sub
End Class