Friend Class UIX_UserManager
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    KeyField = "Id"
    UseDbSystem = True
    baseView = xGridView
  End Sub

  Public Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UIX_UserManagerDialog
  End Function
  Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      item = New Core.Win.Forms.GridDeletedData
      item.Row = selectedRows(i)
      item.Data = xGridView.GetRowCellValue(selectedRows(i), colKode).ToString
      result.Add(item)
    Next

    Return result
  End Function
  Public Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim itemUser As NPO.SSystem.User

    Try
      session.BeginTransaction()
      For i = 0 To selectedData.Count - 1
        itemUser = CType(xGridView.GetRow(selectedData(i).Row), NPO.SSystem.User)
        session.Delete(itemUser)
      Next

      session.CommitTransaction()
      Return True
    Catch ex As Exception
      session.RollbackTransaction()
      Utils.Win.MessageBox.Show(ex.Message, Me.Text)
      Return False
    End Try
  End Function
End Class