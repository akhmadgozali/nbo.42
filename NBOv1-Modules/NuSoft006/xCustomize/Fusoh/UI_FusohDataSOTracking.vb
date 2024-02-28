Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Public Class UI_FusohDataSOTracking
  Overrides Sub FirstLoad()
    Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    txtTglAwal.DateTime = Now.Date
    txtTglAkhir.DateTime = Now.Date
  End Sub

  Private Sub btnTampilkanData_Click(sender As Object, e As EventArgs) Handles btnTampilkanData.Click
    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        splashManager.ShowWaitForm()
        splashManager.SetWaitFormCaption("Silahkan Tunggu")
        splashManager.SetWaitFormDescription("Mengambil data SO ...")

        Dim result As New List(Of FusohSOTracking)
        Dim SOList = New XPQuery(Of Fusoh_OrderPenjualanDetail)(session).Where(Function(w) w.Main.Tanggal.Date >= txtTglAwal.DateTime AndAlso w.Main.Tanggal.Date <= txtTglAkhir.DateTime AndAlso w.QtySisa > 0).ToList
        Dim statusNotList() As StatusTransaksiEnum = {StatusTransaksiEnum.Pending, StatusTransaksiEnum.InProgress, StatusTransaksiEnum.Posting}

        For Each detailSO In SOList
          If Not statusNotList.Contains(detailSO.Main.StatusTransaksi) Then Continue For

          Dim newItem = New FusohSOTracking
          newItem.SOD = detailSO
          newItem.CatatanJali = "SJnya : " & detailSO.SuratJalanDetail.Where(Function(w) w.QtySJ > 0).Count & "-->" & detailSO.SJListData

          Dim xPI = 0
          Dim xDataSJ = detailSO.SuratJalanDetail.GroupBy(Function(g) g.Main).Select(Function(s) New With {.SJ = s.Key, .QtySJ = s.Sum(Function(x) x.QtySJ)})
          For Each item In xDataSJ
            If item.QtySJ > 0 Then
              Select Case xPI
                Case 0 : newItem.QtySJ1 = item.QtySJ : newItem.TglSJ1 = item.SJ.Tanggal.ToShortDateString
                Case 1 : newItem.QtySJ2 = item.QtySJ : newItem.TglSJ2 = item.SJ.Tanggal.ToShortDateString
                Case 2 : newItem.QtySJ3 = item.QtySJ : newItem.TglSJ3 = item.SJ.Tanggal.ToShortDateString
                Case 3 : newItem.QtySJ4 = item.QtySJ : newItem.TglSJ4 = item.SJ.Tanggal.ToShortDateString
                Case 4 : newItem.QtySJ5 = item.QtySJ : newItem.TglSJ5 = item.SJ.Tanggal.ToShortDateString
                Case 5 : newItem.QtySJ6 = item.QtySJ : newItem.TglSJ6 = item.SJ.Tanggal.ToShortDateString
                Case 6 : newItem.QtySJ7 = item.QtySJ : newItem.TglSJ7 = item.SJ.Tanggal.ToShortDateString
                Case 7 : newItem.QtySJ8 = item.QtySJ : newItem.TglSJ8 = item.SJ.Tanggal.ToShortDateString
                Case 8 : newItem.QtySJ9 = item.QtySJ : newItem.TglSJ9 = item.SJ.Tanggal.ToShortDateString
                Case 9 : newItem.QtySJ10 = item.QtySJ : newItem.TglSJ10 = item.SJ.Tanggal.ToShortDateString
              End Select
              xPI = xPI + 1
            End If
          Next

          'For pi = 0 To detailSO.SuratJalanDetail.Count - 1
          '  If detailSO.SuratJalanDetail(pi).QtySJ > 0 Then
          '    Select Case xPI
          '      Case 0 : newItem.QtySJ1 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ1 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 1 : newItem.QtySJ2 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ2 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 2 : newItem.QtySJ3 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ3 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 3 : newItem.QtySJ4 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ4 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 4 : newItem.QtySJ5 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ5 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 5 : newItem.QtySJ6 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ6 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 6 : newItem.QtySJ7 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ7 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 7 : newItem.QtySJ8 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ8 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 8 : newItem.QtySJ9 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ9 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '      Case 9 : newItem.QtySJ10 = detailSO.SuratJalanDetail(pi).QtySJ : newItem.TglSJ10 = detailSO.SuratJalanDetail(pi).Main.Tanggal.ToShortDateString
          '    End Select

          '    xPI = xPI + 1
          '  End If
          'Next
          result.Add(newItem)
        Next
        xGrid.DataSource = result

      Catch ex As Exception
        splashManager.CloseWaitForm()
        Throw New Exception(ex.Message, ex.InnerException)
      Finally
        If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
      End Try
    End Using
  End Sub

  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data SO")
  End Sub

  'Private Sub xpCol_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles xpCol.ResolveSession
  '  e.Session = Me.session
  'End Sub

  'Private Sub btnExportExcell_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportExcell.ItemClick
  '  NuSoft.Core.Win.Component.XtraGrid.ExportExcel(gridSQ, session, "Data SO")
  'End Sub
End Class