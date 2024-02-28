Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPivotGrid
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Public Class UI_SanYuDataPEB
  Private setting As NuSoft001.Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    setting = New NuSoft001.Logic.FinaSetting(session)
  End Sub
  'Private Function getCriteria() As CriteriaOperator
  '  Dim result As New List(Of CriteriaOperator)
  '  Dim format As String = "%{0}%"
  '  'tambahkan hanya yg ekspor
  '  result.Add(New BinaryOperator("Main.FromDomestik", False, BinaryOperatorType.Equal))
  '  Return GroupOperator.And(result)
  'End Function
  Private Sub ifSource_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles ifSource.ResolveSession
    e.Session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    xGrid.RefreshDataSource()
  End Sub
  Private Sub btnFilterExpert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterExpert.ItemClick
    xGridView.ShowFilterEditor(colNoBukti)
  End Sub
  Private Sub btnFilterAuto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterHariIni.ItemClick, btnFilterBulanIni.ItemClick, btnFilterMingguIni.ItemClick
    Dim result As New List(Of CriteriaOperator)
    If e.Item.Caption.ToString = "Hari Ini" Then
      result.Add(New BinaryOperator("Main.Tanggal", Now.Date, BinaryOperatorType.Equal))
    End If
    If e.Item.Caption.ToString = "Minggu Ini" Then
      Dim dayDiff As Integer = Date.Today.DayOfWeek - DayOfWeek.Monday
      Dim tglAwal As Date = Today.AddDays(-dayDiff)
      Dim tglAkhir As Date = tglAwal.AddDays(6)
      result.Add(New BetweenOperator("Main.Tanggal", tglAwal, tglAkhir))
    End If
    If e.Item.Caption.ToString = "Bulan Ini" Then
      Dim tglawal As Date = New Date(Now.Year, Now.Month, 1)
      Dim tglAkhir As Date = tglawal.AddMonths(1).AddDays(-(tglawal.AddMonths(1).Day))
      result.Add(New BetweenOperator("Main.Tanggal", tglawal, tglAkhir))
    End If
    xGridView.ActiveFilterCriteria = GroupOperator.And(result)
  End Sub
  Private Sub btnFilter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilter.ItemClick
    'Dim xform As New UI_DaftarGLFilter
    'xform.MenuId = MenuId
    'xform.NamaDatabase = NamaDatabase
    'xform.session = session
    'xform.Owner = Me
    'xform.ShowDialog()
  End Sub
  Private Sub btnTampilkanProduksi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTampilkanProduksi.ItemClick
    If Not xGridView.DataSource Is Nothing Then
      Dim xIdProduksi As String = xGridView.GetFocusedRowCellDisplayText(colProduksiID)
      Dim xNoLOT As String = xGridView.GetFocusedRowCellDisplayText(colLotNo)

      Dim a As New NuSoft004.SanYuLogic.Stock
      a.showDataProduksiLOT(Me.MenuId, Me.NamaDatabase, session, xIdProduksi)
    End If
  End Sub
End Class