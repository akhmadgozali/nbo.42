Friend Class UI_ReportsList
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    UseDbSystem = True
    NeedDelete = True
    NeedInsert = True
    NPO.SSystem.Laporan.AutoSaveOnEndEdit = False
  End Sub

  Private Sub colDbRepo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles colDbRepo.ButtonClick
    Using frm As New UI_ReportListDb(session)
      frm.FilterByReportId(CType(xGridView.GetFocusedRow, NPO.SSystem.Laporan))
      frm.ShowDialog()
    End Using
  End Sub
End Class