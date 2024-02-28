Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Friend Class UI_AkunY
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("mastercoaZ.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("mastercoaZ.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_AkunZDialog
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
    Try
      For i = 0 To selectedData.Count - 1
        If Not xGridView.IsGroupRow(selectedData(i).Row) Then
          Dim xID As Int32 = CType(xGridView.GetRow(selectedData(i).Row), Persistent.xViewCOA).Id
          Dim xDataCOA As Persistent.Coa = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(xID)
          xDataCOA.Delete()
        End If
      Next
      session.CommitChanges()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("foreign key constraint") Then
        MsgBox("Data tidak dapat dihapus karena masih terpakai oleh tabel lain.", , "Hapus Data")
        'Throw New Utils.Exception("Data tidak dapat dihapus karena masih terpakai oleh tabel lain.", 0, "", "Hapus")
      Else
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
    Return True
  End Function
  Private Sub btnCopy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCopy.ItemClick
    Dim KodeCOA As String = xGridView.GetFocusedRowCellDisplayText(colKode)
    My.Computer.Clipboard.SetText(KodeCOA)
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("mastercoaZ.xml"))
  End Sub
End Class