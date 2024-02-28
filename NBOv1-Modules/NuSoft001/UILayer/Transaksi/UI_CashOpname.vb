Imports DevExpress.Data.Async.Helpers
Imports DevExpress.XtraGrid.Views.Base

Friend Class UI_CashOpname
  Private toStringFormat As String
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
    GetSession()
    setting = New Logic.FinaSetting(session)
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_CashOpnameDialog
  End Function

  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = CDate(xGridView.GetRowCellValue(selectedRows(i), colTanggal)).ToString("dd MMM yyyy") & " -- " & xGridView.GetRowCellValue(selectedRows(i), colAkun).ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.CashOpname
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim notDeletedPeriode As New List(Of Persistent.CashOpname)

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.CashOpname)

        If Persistent.Periode.CheckLockedPeriod(session, item.Tanggal) Then
          notDeletedPeriode.Add(item)
        Else
          item.Delete()
        End If
      End If
    Next
    session.CommitChanges()

    If notDeletedPeriode.Count > 0 Then
      Dim text As String = My.Resources.GLDeletedPeriode
      For i = 0 To notDeletedPeriode.Count - 1
        text &= vbCrLf & String.Format("{0} -- {1} | {2}", notDeletedPeriode(i).Tanggal, notDeletedPeriode(i).Akun.Kode, notDeletedPeriode(i).Akun.Nama)
      Next
      Utils.Win.MessageBox.Show(text, "Hapus " & Me.Text, My.Resources.GLDeletedPeriodeSolution, Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If

    Return True
  End Function
  Overrides Sub GridViewCustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
    Dim view As ColumnView = CType(sender, ColumnView)
    If view.IsRowLoaded(e.RowHandle) AndAlso e.Column Is colSaldo Then
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread = CType(xGridView.GetRow(e.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      Dim item As Persistent.CashOpname = CType(proxy.OriginalRow, Persistent.CashOpname)
      e.DisplayText = String.Format("{0} {1:" & setting.NumericFormatToString & "}", item.Akun.MataUang.Simbol, item.Total)
    End If
  End Sub
End Class