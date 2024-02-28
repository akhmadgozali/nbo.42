Friend Class UI_ReportListDb
  Private reportId As NPO.SSystem.Laporan
  Private deletedObject As New List(Of Object)

  Sub New(ByVal sesi As DevExpress.Xpo.Session)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Session1 = sesi
    Btn2IsClosedButton = True
    NPO.SSystem.LaporanPerDatabase.AutoSaveOnEndEdit = False
  End Sub
  Sub FilterByReportId(ByVal idReport As NPO.SSystem.Laporan)
    reportId = idReport
    xpReport.CriteriaString = "Report.Id=" & reportId.Id
  End Sub
  Public Overrides Sub Btn1Click()
    Try
      Session1.Delete(deletedObject)
      Session1.Save(xpReport)
      Utils.Win.MessageBox.Show("Data berhasil disimpan", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try
  End Sub

  Private Sub xGrid_ProcessGridKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles xGrid.ProcessGridKey
    If e.KeyCode = Windows.Forms.Keys.Delete AndAlso e.Control Then
      If xGridView.FocusedRowHandle >= 0 Then
        xGridView.DeleteRow(xGridView.FocusedRowHandle)
      End If
    End If
  End Sub
  Private Sub xGridView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    xGridView.SetRowCellValue(e.RowHandle, colReport, reportId)
  End Sub
  Private Sub xpReport_CollectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpo.XPCollectionChangedEventArgs) Handles xpReport.CollectionChanged
    If e.CollectionChangedType = DevExpress.Xpo.XPCollectionChangedType.AfterRemove Then
      deletedObject.Add(e.ChangedObject)
    End If
  End Sub
  Private Sub xpReport_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpReport.ResolveSession
    e.Session = Session1
  End Sub
  Private Sub xpDb_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpDb.ResolveSession
    e.Session = Session1
  End Sub
End Class