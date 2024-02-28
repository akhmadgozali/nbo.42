Imports DevExpress.Data.Filtering
Public Class UI_PrepaymentzApproveDialog
  Private xIDPP As Int64
  Private xApprove As Boolean
  Private instance As Persistent.PrePaymentMain
  Private setting As Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New(pApprove As Boolean, pidPP As Int64)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    NoDropIdentityMap = True
    xApprove = pApprove
    xIDPP = pidPP
  End Sub
  Overrides Sub LoadBeforeInitialize()
    Me.Text = IIf(xApprove = True, "Approve Prepayment", "Reject Prepayment").ToString
    instance = session.GetObjectByKey(Of Persistent.PrePaymentMain)(Convert.ToInt64(xIDPP))
  End Sub
  Overrides Sub LoadAfterInitialize()
    setting = New Logic.FinaSetting(session)
    sumber = New Persistent.SumberDataCollection(session)
    If Not instance Is Nothing Then
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtVendor.Text = instance.Kontak.Nama
    End If
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.PP)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Overrides Sub SimpanData()
    If txtCatatan.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan input untuk catatan.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    If xApprove = True Then
      instance.Status = NuSoft001.Persistent.StatusTransaksiEnum.Approved
    Else
      instance.Status = NuSoft001.Persistent.StatusTransaksiEnum.Rejected
    End If
    instance.CatatanApprove = txtCatatan.Text
    instance.Save()

    session.CommitChanges()
  End Sub
End Class