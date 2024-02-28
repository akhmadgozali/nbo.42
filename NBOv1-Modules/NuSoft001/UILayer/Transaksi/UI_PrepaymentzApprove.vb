Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_PrepaymentzApprove
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
    allowAdd = False
    allowDelete = False
    allowEdit = False
  End Sub
  Overrides Sub FirstLoad()
    setting = New Logic.FinaSetting(GetSession)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PPApproveData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PPApproveData.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_PrepaymentDialog
  End Function
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("PPApproveData.xml"))
  End Sub
  Private Sub btnApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApprove.ItemClick
    Dim xID As Int64 = CType(xGridView.GetFocusedRowCellDisplayText(colId), Int64)
    Dim a As New UI_PrepaymentzApproveDialog(True, xID)
    a.session = Me.session
    a.ShowDialog()
  End Sub
  Private Sub btnReject_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReject.ItemClick
    Dim xID As Int64 = CType(xGridView.GetFocusedRowCellDisplayText(colId), Int64)
    Dim a As New UI_PrepaymentzApproveDialog(False, xID)
    a.session = Me.session
    a.ShowDialog()
  End Sub
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

  Private Sub btnCetakApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakApprove.ItemClick
    Dim x As Integer() = Nothing

    If baseView.RowCount < 1 Then
      Exit Sub
    End If

    If TypeOf (baseView) Is DevExpress.XtraGrid.Views.Grid.GridView Then
      Dim viewGrid As DevExpress.XtraGrid.Views.Grid.GridView = CType(baseView, DevExpress.XtraGrid.Views.Grid.GridView)
      If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
        Exit Sub
      End If
      x = viewGrid.GetSelectedRows
    ElseIf TypeOf (baseView) Is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView Then
      Dim viewGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = CType(baseView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
      If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
        Exit Sub
      End If
      x = viewGrid.GetSelectedRows
    End If

    Dim note As List(Of NuSoft.Core.Win.Forms.GridDeletedData) = GetKeteranganHapus(x)
    If note Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan keterangan data yang akan dihapus", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Exit Sub
    End If

    If note.Count > 0 Then
      Dim item As Persistent.PrePaymentMain
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.PrePaymentMain)

      Dim frm As New RF_BuktiHarian(Persistent.SumberDataJenis.PP, MainClass.reportName.VoucherApprovePrepayment)
      frm.txtNoBukti1.EditValue = item.Kode

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim reportCode As String = ""
      message = String.Format(message, "PrePayment")
      reportCode = MainClass.GetReport(MainClass.reportName.VoucherApprovePrepayment)

      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
    End If
  End Sub
End Class