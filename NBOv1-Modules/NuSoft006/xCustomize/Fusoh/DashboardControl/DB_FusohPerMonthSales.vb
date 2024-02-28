Imports DevExpress.Xpo

Public Class DB_FusohPerMonthSales
	Private session As UnitOfWork

	Private Sub Me_DatabaseChanged() Handles Me.DatabaseChanged
		session = Data.DbClient.GetXPOSession(NamaDatabase)
		SetDataSource()
	End Sub
	Private Sub SetDataSource()
		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True, DevExpress.XtraSplashScreen.ParentType.UserControl)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Loading Data Per Month Sales ...")

				Dim ds = New XPQuery(Of Persistent.Fusoh_OrderPenjualan)(session) _
				.Where(Function(w) w.Tanggal.Year = Now.Year) _
				.GroupBy(Function(g) New DateTime(g.Tanggal.Year, g.Tanggal.Month, 1)) _
				.Select(Function(s) New With {
					.Tanggal = s.Key,
					.Total = s.Sum(Function(a) a.Total)
				}) _
				.ToList

				xChart.DataSource = ds
			Catch ex As Exception
				Throw New Utils.Exception(ex.Message, ex.InnerException)
			Finally
				splashManager.CloseWaitForm()
			End Try
		End Using
	End Sub
	Friend Sub RefreshDataSource()
		SetDataSource()
	End Sub
End Class
