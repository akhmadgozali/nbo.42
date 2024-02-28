Imports DevExpress.Xpo

Public Class DB_FusohDueDate
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
				splashManager.SetWaitFormDescription("Loading Data Delivery Due Date ...")

				Dim ds = New XPQuery(Of Persistent.Fusoh_OrderPenjualanDetail)(session) _
				.Where(Function(w) w.QtySisa <> 0).ToList _
				.Select(Function(s) New With {
					.Kode = s.Main.Kode,
					.Tanggal = s.Main.Tanggal,
					.Customer = s.Main.Pelanggan.Nama,
					.BarangKode = s.Barang.Kode,
					.BarangNama = s.Barang.Nama,
					.POLine = s.POLine,
					.TanggalDelivery = s.Main.DeliveryDate,
					.Deadline = s.Main.DeliveryDeadline,
					.QtyOrder = s.Qty,
					.QtyKirim = s.QtyKirim,
					.QtySisa = s.QtySisa,
					.SuratJalanDetail = s.SuratJalanDetail.Where(Function(w) w.QtySJ <> 0).ToList
				}) _
				.OrderBy(Function(o) o.Tanggal) _
				.OrderBy(Function(o) o.Deadline) _
				.ToList

				xGrid.DataSource = ds
				xGridViewSO.BestFitColumns()
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
