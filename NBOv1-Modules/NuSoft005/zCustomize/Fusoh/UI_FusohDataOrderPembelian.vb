Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Public Class UI_FusohDataOrderPembelian
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
  End Sub
  Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    xGrid.DataSource = New XPCollection(Of Persistent.Fusoh_OrderPembelianDetail)(session, New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
  End Sub
  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data Order Pembelian")
  End Sub
End Class