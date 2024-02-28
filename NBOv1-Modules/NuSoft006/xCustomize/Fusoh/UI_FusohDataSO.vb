Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Public Class UI_FusohDataSO
  Overrides Sub FirstLoad()
    Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
  End Sub
  Private Sub xpCol_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles xpCol.ResolveSession
    e.Session = Me.session
  End Sub

  Private Sub btnExportExcell_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportExcell.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(gridSQ, session, "Data SO")
  End Sub
End Class