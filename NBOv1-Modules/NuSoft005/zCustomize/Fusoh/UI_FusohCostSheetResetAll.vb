Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent

Friend Class UI_FusohCostSheetResetAll
	Private dataSource As List(Of ResetAllStructure)

	Private Sub UI_FusohProduksiResetAll_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Loading data ...")

				LoadingData()

				splashManager.CloseWaitForm()
			Catch ex As Exception
				splashManager.CloseWaitForm()
				Throw New Exception(ex.Message, ex.InnerException)
			End Try
		End Using
	End Sub
	Private Sub LoadingData()
		Dim allData = New XPQuery(Of Fusoh_PenerimaanInvoice)(session).Where(Function(m) (m.Sumber.Id = SumberDataJenis.RI OrElse m.Sumber.Id = SumberDataJenis.IMV) AndAlso m.TotalCostIDR > 0).ToList()
		dataSource = New List(Of ResetAllStructure)
		For Each item In allData
			Dim source = New ResetAllStructure
			source.Row = item
			source.Detail = New List(Of ResetSingleStructure)

			If item.Sumber.Id = SumberDataJenis.RI Then
				Dim daftarGr = New XPQuery(Of Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim.PO Is item.NoOrder).ToList
				For Each x In daftarGr
					For Each det In x.Detail
						source.Detail.Add(New ResetSingleStructure() With {.Row = det, .Harga = det.Harga})
					Next
				Next
			Else
				Dim daftarGr = New XPQuery(Of Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim.Invoice Is item).ToList
				For Each x In daftarGr
					For Each det In x.Detail
						source.Detail.Add(New ResetSingleStructure() With {.Row = det, .Harga = det.Harga})
					Next
				Next
			End If
			dataSource.Add(source)
		Next

		xGrid.DataSource = dataSource
	End Sub

	Private Async Sub btnStartReset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnStartReset.ItemClick
		Await Task.Run(Of Boolean)(Function() StartReset())
		MsgBox("Proses Reset Selesai.",, Me.Text)
	End Sub
	Private Sub xGridView_RowStyle(sender As Object, e As RowStyleEventArgs) Handles xGridView.RowStyle
		Try
			If (xGridView.IsGroupRow(e.RowHandle)) Then Exit Sub

			Dim item = CType(xGridView.GetRow(e.RowHandle), ResetAllStructure)
			If (item.Status = "Proses") Then
				e.Appearance.BackColor = System.Drawing.Color.Yellow
			ElseIf (item.Status = "Sukses") Then
				e.Appearance.BackColor = System.Drawing.Color.LightGreen
			ElseIf (item.Status.StartsWith("Gagal")) Then
				e.Appearance.BackColor = System.Drawing.Color.PaleVioletRed
			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Function StartReset() As Boolean
		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				btnStartReset.Enabled = False
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Mulai reset HPP ...")

				For i = 0 To xGridView.RowCount - 1
					Dim x = i
					BeginInvoke(New System.Windows.Forms.MethodInvoker(Sub() UpdateRowsMethod(x)))
					ResetHPP(x, splashManager)
				Next

				splashManager.SetWaitFormDescription("Simpan ke database ...")
				session.CommitChanges()
				splashManager.CloseWaitForm()
				btnStartReset.Enabled = True

				Return True
			Catch ex As Exception
				splashManager.CloseWaitForm()
				Throw New Exception(ex.Message, ex.InnerException)
				Return False
			End Try
		End Using
	End Function
	Private Sub ResetHPP(rowHandle As Integer, splashManager As DevExpress.XtraSplashScreen.SplashScreenManager)
		If Not xGridView.IsGroupRow(rowHandle) Then
			Dim item = CType(xGridView.GetRow(rowHandle), ResetAllStructure)
			BeginInvoke(New System.Windows.Forms.MethodInvoker(Sub() xGridView.SetRowCellValue(rowHandle, colStatus, "Proses")))

			splashManager.SetWaitFormDescription("Reset HPP " & item.NomorInvoice & " ...")

			Try
				For Each x In item.Detail
					Dim detInvoice = item.Row.Detail.ToList.Find(Function(f) f.PODetail Is x.Row.EximDetail.PODetail)
					If Not detInvoice Is Nothing Then
						x.Row.Harga = (detInvoice.TotalPembelianIDR) / x.Row.Qty
						x.HargaReset = x.Row.Harga
					End If
				Next

				BeginInvoke(New System.Windows.Forms.MethodInvoker(Sub() xGridView.SetRowCellValue(rowHandle, colStatus, "Sukses")))
			Catch ex As Exception
				BeginInvoke(New System.Windows.Forms.MethodInvoker(Sub() xGridView.SetRowCellValue(rowHandle, colStatus, "Gagal " & ex.Message)))
			End Try
		End If
	End Sub
	Private Sub UpdateRowsMethod(baris As Integer)
		xGridView.FocusedRowHandle = baris
	End Sub
End Class
Friend Class ResetAllStructure
	Public Property Row As Persistent.Fusoh_PenerimaanInvoice
	Public ReadOnly Property NomorInvoice As String
		Get
			Return Row.Kode
		End Get
	End Property
	Public ReadOnly Property Tanggal As Date
		Get
			Return Row.Tanggal
		End Get
	End Property
	Public ReadOnly Property Vendor As String
		Get
			Return Row.Vendor.Nama
		End Get
	End Property
	Public ReadOnly Property NomorPO As String
		Get
			If Row.NoOrder Is Nothing Then
				Return ""
			Else
				Return Row.NoOrder.Kode
			End If
		End Get
	End Property
	Public ReadOnly Property TotalInvoice As Double
		Get
			Return Row.TotalIDR
		End Get
	End Property
	Public ReadOnly Property TotalCostSheet As Double
		Get
			Return Row.TotalCostIDR
		End Get
	End Property
	Public ReadOnly Property TotalInvoiceCostSheet As Double
		Get
			Return TotalInvoice + TotalCostSheet
		End Get
	End Property
	Public Property Status As String

	Public Property Detail As List(Of ResetSingleStructure)
End Class