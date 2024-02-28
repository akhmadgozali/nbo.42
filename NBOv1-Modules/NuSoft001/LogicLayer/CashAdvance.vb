Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace Logic
  Public Class CashAdvance
    Shared Function GetRemainTransaction(session As UnitOfWork, idForEdit As Int64) As List(Of DB.SelectStatementResultRow)
      Dim sql As String
      If idForEdit = Nothing Then
        sql = My.Resources.SQLCARemain
      Else
        sql = String.Format(My.Resources.SQLCARemainEdit, idForEdit)
      End If

      Return session.ExecuteQueryWithMetadata(sql).ResultSet(0).Rows.ToList
    End Function
  End Class
End Namespace