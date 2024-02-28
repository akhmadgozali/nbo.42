Public Class UI_FusohDailyProses
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
  End Sub

  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_FusohDailyProsesDialog
  End Function
  Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = String.Format("{0} - {1} - {2}", xGridView.GetRowCellValue(selectedRows(i), "Mesin.Nama"), xGridView.GetRowCellValue(selectedRows(i), "Main.NomorLot"), xGridView.GetRowCellValue(selectedRows(i), "Main.SODetail.Barang.Kode"))
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Public Overrides Function HapusData(selectedData As List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        CType(xGridView.GetRow(selectedData(i).Row), Persistent.Fusoh_DailyProcess).Delete()
      End If
    Next
    session.CommitChanges()
    Return True
  End Function
End Class