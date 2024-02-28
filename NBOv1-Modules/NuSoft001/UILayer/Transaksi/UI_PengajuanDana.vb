Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_PengajuanDana
  Private setting As Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.

    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = False
    useFeedbackSource = True
    ActivateToolTip = False
    UseDbSystem = False
  End Sub
  Overrides Sub FirstLoad()
    setting = New Logic.FinaSetting(GetSession)
    colJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colJumlah.DisplayFormat.FormatString = setting.NumericFormatString
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PDData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PDData.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_PengajuanDanaDialog2
  End Function
  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = xGridView.GetRowCellValue(selectedRows(i), "Kode").ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.PengajuanDana
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.PengajuanDana)

        item.Delete()
      End If
    Next
    session.CommitChanges()

    Return True
  End Function
  Private Sub btnCreateTransaksi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateTransaksi.ItemClick
    Dim xNomor As String = xGridView.GetFocusedRowCellDisplayText(colKode)
    Dim instance As Persistent.GlMain
    If Not xNomor Is Nothing Then
      Dim xDataPD As Persistent.PengajuanDana = session.FindObject(Of Persistent.PengajuanDana)(New BinaryOperator("Kode", xNomor, BinaryOperatorType.Equal))
      If Not xDataPD Is Nothing Then
        If Utils.Win.MessageBox.Show("Apakah anda ingin membuat transaksi untuk : " & xNomor, "Konfirmasi", "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
          Dim sumber As Persistent.SumberDataCollection
          setting = New Logic.FinaSetting(session)
          sumber = New Persistent.SumberDataCollection(session)
          instance = New Persistent.GlMain(session)
          instance.Tanggal = Now
          If xDataPD.fCOA.Tipe.Id = Persistent.CoaEnum.eKind.Bank Then
            instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.BK)
          Else
            instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.KK)
          End If
          instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
          instance.Akun = xDataPD.fCOA
          instance.fCOA = xDataPD.fCOA
          instance.Regional = xDataPD.Regional
          instance.Tanggal = Now
          instance.Kontak = xDataPD.Kontak
          instance.Uraian = xDataPD.Keterangan
          Dim xGlD As Persistent.GlMainDetail
          'tambahkan untuk cash nya.
          xGlD = New Persistent.GlMainDetail(session)
          xGlD.Akun = xDataPD.fCOA
          xGlD.Kredit = xDataPD.Jumlah
          xGlD.MataUang = xGlD.Akun.MataUang
          xGlD.Urutan = 0
          instance.Detail.Add(xGlD)
          For pi = 0 To xDataPD.Detail.Count - 1
            xGlD = New Persistent.GlMainDetail(session)
            xGlD.Urutan = CByte(pi + 1)
            xGlD.Akun = xDataPD.Detail(pi).Akun
            xGlD.Debit = xDataPD.Detail(pi).Jumlah
            xGlD.MataUang = xGlD.Akun.MataUang
            xGlD.Keterangan = xDataPD.Detail(pi).Keterangan
            instance.Detail.Add(xGlD)
          Next
          xDataPD.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
          xDataPD.GL = instance
          xDataPD.StatusTransaksi = Persistent.StatusTransaksiEnum.Finish
          session.CommitChanges()
          'cetak
          '======= Konfirmasi Cetak Laporan
          Dim frm As New RF_BuktiHarian(Persistent.SumberDataCollection.GetEnum(instance.Sumber), MainClass.reportName.BuktiPengajuanDana)
          frm.txtNoBukti1.EditValue = instance.Kode

          Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
          Dim reportCode As String = ""
          If xDataPD.fCOA.Tipe.Id = Persistent.CoaEnum.eKind.Bank Then
            reportCode = MainClass.GetReport(MainClass.reportName.BuktiBankKeluar)
          Else
            reportCode = MainClass.GetReport(MainClass.reportName.BuktiKasKeluar)
          End If
          message = String.Format(message, "Kas/Bank Keluar")

          Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)

        End If
      End If
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("PDData.xml"))
  End Sub
End Class