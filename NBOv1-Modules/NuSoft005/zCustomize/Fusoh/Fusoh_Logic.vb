Namespace Fusoh_Logic
  Friend Class Umum
    Public Const ImportDutyCustom As String = "ImportDuty"
    Shared Sub xHistoryData(xForm As Object, xSession As DevExpress.Xpo.UnitOfWork, Tipe As UI_FusohCekData.TipeTransaksi, xNoBukti As String)
      Dim xHistory As New UI_FusohCekData(UI_FusohCekData.TipeForm.Dialog)
      xHistory.session = xSession
      xHistory.MenuId = xForm.MenuId
      xHistory.NamaDatabase = xForm.NamaDatabase
      xHistory.txtTipe.EditValue = Tipe
      xHistory.txtNoTransaksi.EditValue = xNoBukti
      xHistory.btnCari_Click(xHistory.btnCari, Nothing)
      xHistory.ShowDialog()
    End Sub
    Shared Sub xHistoryDempyou(xForm As Object, xSession As DevExpress.Xpo.UnitOfWork, xNoBukti As String)
      Dim xHistory As New UI_FusohCekDempyou()
      xHistory.session = xSession
      xHistory.MenuId = xForm.MenuId
      xHistory.NamaDatabase = xForm.NamaDatabase
      'xHistory.txtNoTransaksi.EditValue = xNoBukti
      'xHistory.btnCari_Click(xHistory.btnCari, Nothing)
      xHistory.xNoTransaksi = xNoBukti
      xHistory.ShowDialog()
    End Sub
  End Class

  Friend Class Periode
    Shared Sub CekTanggalLocked(session As DevExpress.Xpo.UnitOfWork, tanggal As Date)
      If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, tanggal) Then
        Throw New Exception("Periode sudah ditutup" & vbCrLf & "Solusi : Hubungi accounting untuk membuka periode")
      End If
      '======= Cek Sebelum Awal Periode
      If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(session, tanggal) Then
        Throw New Exception("Tanggal transaksi sebelum awal periode" & vbCrLf & "Solusi : Silahkan ganti tanggal transaksi")
      End If
    End Sub
  End Class
End Namespace