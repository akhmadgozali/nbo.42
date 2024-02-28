Imports DevExpress.Data.Filtering
Friend Class UI_RevaluasiValas
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_RevaluasiValasDialog
  End Function
  Overrides Sub FirstLoad()
    Dim a As New Logic.FinaSetting(GetSession)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RevaluasiValasData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RevaluasiValasData.xml"))
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("RevaluasiValasData.xml"))
  End Sub
  Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = String.Format("{0} - {1}", xGridView.GetRowCellValue(selectedRows(i), "Kode"), xGridView.GetRowCellValue(selectedRows(i), "Nama"))
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Public Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.RevaluasiValas
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        'delete GLnya
        item = CType(xGridView.GetRow(selectedData(i).Row), Persistent.RevaluasiValas)
        For pJ = 0 To item.Detail.Count - 1
          Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Detail(pJ).Gl.Id, BinaryOperatorType.Equal))
          If Not zdtGL Is Nothing Then
            zdtGL.Delete()
          End If
        Next
        item.Delete()
      End If
    Next
    session.CommitChanges()
    Return True
  End Function
End Class