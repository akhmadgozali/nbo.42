Imports DevExpress.Xpo
Imports DevExpress.XtraBars

Public Class UI_FusohDataProduksi
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    UseDbSystem = False

    Persistent.FusohVwProduksi.AutoSaveOnEndEdit = False
  End Sub
  Public Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
  End Sub

  Private Sub btnShowSJ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowSJ.ItemClick
    If Not xGridView.DataSource Is Nothing Then
      Dim IDProduksi As Int64 = CInt(xGridView.GetFocusedRowCellDisplayText(colIdTransaksi))
      Dim KodeBarang As String = xGridView.GetFocusedRowCellDisplayText(colKodeItem)
      Dim NoProduksi As String = xGridView.GetFocusedRowCellDisplayText(colNoProduksi)
      Dim frm As New UI_FusohDataProduksiSJ(IDProduksi, MyBase.session, KodeBarang, NoProduksi)
      frm.session = MyBase.session
      frm.MenuId = Me.MenuId
      frm.NamaDatabase = Me.NamaDatabase
      If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        ifSource.Refresh()
      End If
    End If
  End Sub

  Private Sub ifSource_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles ifSource.ResolveSession
    e.Session = session
  End Sub

  Private Sub btnRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefresh.ItemClick
    ifSource.Refresh()
  End Sub

  Private Sub btnCetakData_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCetakData.ItemClick
    printGrid(xGrid)
  End Sub
  Private Sub btnExport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data Produksi")
  End Sub
End Class