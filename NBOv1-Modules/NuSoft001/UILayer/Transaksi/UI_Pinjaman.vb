Imports DevExpress.Data.Async.Helpers
Imports DevExpress.XtraGrid.Views.Base

Friend Class UI_Pinjaman
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
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_PinjamanDialog
  End Function

  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = xGridView.GetRowCellValue(selectedRows(i), colKode).ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.Pinjaman
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Pinjaman)

        item.Delete()
      End If
    Next
    session.CommitChanges()

    Return True
  End Function
  Overrides Sub GridViewCustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
    Dim view As ColumnView = CType(sender, ColumnView)
    If view.IsRowLoaded(e.RowHandle) AndAlso e.Column Is colPinjaman Then
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread = CType(xGridView.GetRow(e.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      Dim item As Persistent.Pinjaman = CType(proxy.OriginalRow, Persistent.Pinjaman)
      e.DisplayText = String.Format("{0} {1:" & setting.NumericFormatToString & "}", item.MataUang.Simbol, item.JumlahPinjaman)
    End If
  End Sub
End Class