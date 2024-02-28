Public Class UI_AktivaKelompok
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
  End Sub
  Public Overrides Sub FirstLoad()
    'load setingan default kolom
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterkelompokaktiva.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterkelompokaktiva.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_AktivaKelompokDialog
  End Function
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
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        CType(xGridView.GetRow(selectedData(i).Row), Persistent.AktivaKelompok).Delete()
      End If
    Next
    session.CommitChanges()
    Return True
  End Function
  Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("masterkelompokaktiva.xml"))
  End Sub
End Class