Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohProduksiResetAll
	Property FromCW As Boolean
	Private dataSource As List(Of ResetAllStructure)

	Private Sub UI_FusohProduksiResetAll_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Initialize ...")

				Initialize()

				splashManager.CloseWaitForm()
			Catch ex As Exception
				splashManager.CloseWaitForm()
				Throw New Exception(ex.Message, ex.InnerException)
			End Try
		End Using
	End Sub
	Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
		Using splashManager As SplashScreenManager = New SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Loading Data ...")

				LoadingData(splashManager)
			Catch ex As Exception
				Throw New Exception(ex.Message, ex.InnerException)
			Finally
				If splashManager.IsSplashFormVisible Then
					splashManager.CloseWaitForm()
				End If
			End Try
		End Using
	End Sub

	Private Sub Initialize()
		If FromCW Then
			Text = "Reset HPP - Cutting [WIP]"
		Else
			Text = "Reset HPP - Produksi"
		End If
	End Sub
	Private Sub LoadingData(splash As SplashScreenManager)
		'Dim allData = New XPQuery(Of Fusoh_StokMain)(session).Where(Function(m) m.Sumber.Id = SumberDataJenis.AM Or m.Sumber.Id = SumberDataJenis.CW).ToList()
		'MsgBox(CreateCriteria.LegacyToString)
		Dim allData = New XPCollection(Of Fusoh_StokMain)(session, CreateCriteria).ToList()
		Dim totalData = allData.Count
		Dim currentData = 0
		dataSource = New List(Of ResetAllStructure)
		For Each item In allData
			currentData += 1
			splash.SetWaitFormDescription("Loading Data " & currentData.ToString("n0") & " dari " & totalData.ToString("n0") & " ...")

			Dim hppKeluar = item.Detail.Where(Function(w) w.TotalLengthOut > 0 OrElse (w.Barang.TipeBarang = TipeBarang.BahanWIP AndAlso w.QtyOut > 0))
			Dim hppMasuk = item.Detail.Where(Function(w) w.QtyIn > 0)

			Dim source = New ResetAllStructure
			source.Row = item
			source.Id = item.Id
			source.Kode = item.Kode
			source.Tanggal = item.Tanggal
			source.NamaPelanggan = item.Pelanggan.Nama
			source.NomorPO = item.OrderProduksi.SODetail.Main.NomorPO
			source.NomorLot = item.DempyouLot
			source.Catatan = item.Catatan
			source.TotalQtyOut = hppKeluar.Sum(Function(s) s.QtyOut)
			source.HPPOut = New List(Of ResetAllStructureOut)
			source.HPPIn = New List(Of ResetAllStructureIn)

			For Each hppMasukItem In hppMasuk
				source.HPPIn.Add(New ResetAllStructureIn() With {
					.Row = hppMasukItem,
					.Id = hppMasukItem.Id,
					.KodePart = hppMasukItem.Barang.Kode,
					.NamaPart = hppMasukItem.Barang.Nama,
					.Qty = hppMasukItem.QtyIn
				})
			Next

			For Each hppKeluarItem In hppKeluar
				If hppKeluarItem.Barang.TipeBarang = TipeBarang.BahanWIP Then
					If Not item.CuttingWIP Is Nothing Then
						Dim harga = item.CuttingWIP.Detail.Where(Function(w) w.QtyIn > 0).Sum(Function(s) s.Harga)
						Dim data = New ResetAllStructureOut
						data.Row = hppKeluarItem
						data.Id = hppKeluarItem.Id
						data.KodePart = hppKeluarItem.Barang.Kode
						data.NamaPart = hppKeluarItem.Barang.Nama
						data.SerialNumber = ""
						data.Harga = harga
						data.LengthIn = 1
						data.LengthOut = hppKeluarItem.QtyOut
						source.HPPOut.Add(data)
					End If
				Else
					For Each serial In hppKeluarItem.Serial '===== hitung per serial
						'===== cari penerimaan
						Dim grSerial = New XPQuery(Of Fusoh_StokSerial)(session) _
						.Where(Function(w) w.DetailMain.Barang Is serial.DetailMain.Barang _
						AndAlso w.Serial = serial.Serial AndAlso w.LengthIn > 0) _
						.ToList.Take(1).SingleOrDefault

						If Not grSerial Is Nothing Then
							Dim hppPerQty As Double = 0
							'===== cari hpp per qty
							If (grSerial.DetailMain.EximDetail Is Nothing) Then
								hppPerQty = grSerial.DetailMain.Harga
							Else
								'=== ambil dari invoice
								hppPerQty = FusohLogic.HPP.GetHPPBahanBakuPerQty(session, grSerial.DetailMain.EximDetail.Id)
							End If

							'===== hpp per length serial '================
							Dim data = New ResetAllStructureOut
							data.Row = hppKeluarItem
							data.Id = serial.DetailMain.Id
							data.KodePart = serial.DetailMain.Barang.Kode
							data.NamaPart = serial.DetailMain.Barang.Nama
							data.SerialNumber = serial.Serial

							If (grSerial.DetailMain.Length = 0) Then
								data.Harga = 0
								data.LengthIn = 0
								data.LengthOut = 0
							Else
								data.Harga = hppPerQty
								data.LengthIn = grSerial.LengthIn
								data.LengthOut = serial.LengthOut
							End If

							source.HPPOut.Add(data)
						End If
					Next
				End If
			Next

			dataSource.Add(source)
		Next

		xGrid.DataSource = dataSource
	End Sub
	Private Function CreateCriteria() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		If FromCW Then
			result.Add(New BinaryOperator("Sumber.Id", SumberDataJenis.CW, BinaryOperatorType.Equal))
		Else
			result.Add(New BinaryOperator("Sumber.Id", SumberDataJenis.AM, BinaryOperatorType.Equal))
		End If
		If Not txtTgl1.DateTime = Nothing Then
			If txtTgl2.DateTime = Nothing Then
				result.Add(New BinaryOperator("Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
			Else
				result.Add(New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
			End If
		End If
		If txtNoTransaksi1.Text <> "" Then
			If String.IsNullOrEmpty(txtNoTransaksi2.Text) Then
				result.Add(New BinaryOperator("Kode", String.Format(format, txtNoTransaksi1.EditValue), BinaryOperatorType.Like))
			Else
				result.Add(New BetweenOperator("Kode", txtNoTransaksi1.EditValue, txtNoTransaksi2.EditValue))
			End If
		End If
		If txtCustomer.Text <> "" Then
			result.Add(New BinaryOperator("Pelanggan.Nama", String.Format(format, txtCustomer.Text), BinaryOperatorType.Like))
		End If
		If txtNomorPO.Text <> "" Then
			result.Add(New BinaryOperator("OrderProduksi.SODetail.Main.NomorPO", txtNomorPO.Text, BinaryOperatorType.Like))
		End If
		Return GroupOperator.And(result)
	End Function

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

			splashManager.SetWaitFormDescription("Reset HPP " & item.Kode & " ...")

			Try
				'''''''========== update harga dan total hpp keluar
				''''''Dim hppKeluar = item.Row.Detail.Where(Function(w) w.TotalLengthOut > 0)
				''''''For Each hppKeluarItem In hppKeluar
				''''''	Dim totalHPPPerItem = item.HPPOut.Where(Function(w) w.Row Is hppKeluarItem).Sum(Function(x) x.HPP)
				''''''	If hppKeluarItem.QtyOut > 0 Then
				''''''		hppKeluarItem.Harga = totalHPPPerItem / hppKeluarItem.QtyOut
				''''''	End If
				''''''	hppKeluarItem.TotalHPP = totalHPPPerItem
				''''''Next

				'''''''========== update harga dan total hpp masuk
				''''''For Each hppInItem In item.HPPIn
				''''''	hppInItem.Row.Harga = item.HPPPerQty

				''''''	'nah, carikan untuk pengirimannya SJ ini, dan lakukan edit harga
				''''''	Dim xSJ = New XPQuery(Of Fusoh_StokDetail)(session).Where(Function(w) w.ProduksiDetail Is hppInItem.Row).ToList()
				''''''	For pK = 0 To xSJ.Count - 1
				''''''		xSJ(pK).Harga = item.HPPPerQty
				''''''		xSJ(pK).TotalHPP = item.HPPPerQty * xSJ(pK).QtyOut
				''''''	Next
				''''''Next
				FusohLogic.HPP.HitungHPPDariProduksi(item.Row, False)

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
	Public Property Row As Fusoh_StokMain
	Public Property Id As Long
	Public Property Kode As String
	Public Property Tanggal As Date
	Public Property NamaPelanggan As String
	Public Property NomorPO As String
	Public Property NomorLot As String
	Public Property Catatan As String
	Public Property TotalQtyOut As Double
	Public ReadOnly Property TotalHPP As Double
		Get
			Return HPPOut.Sum(Function(s) s.HPP)
		End Get
	End Property
	Public ReadOnly Property TotalQtyIn As Double
		Get
			Return HPPIn.Sum(Function(s) s.Qty)
		End Get
	End Property
	Public ReadOnly Property HPPPerQty As Double
		Get
			Return TotalHPP / TotalQtyIn
		End Get
	End Property
	Public Property Status As String

	Public Property HPPOut As List(Of ResetAllStructureOut)
	Public Property HPPIn As List(Of ResetAllStructureIn)
End Class
Friend Class ResetAllStructureOut
	Public Property Row As Fusoh_StokDetail
	Public Property Id As Long
	Public Property KodePart As String
	Public Property NamaPart As String
	Public Property SerialNumber As String
	Public Property Harga As Double
	Public Property LengthIn As Double
	Public Property LengthOut As Double
	Public ReadOnly Property HPP As Double
		Get
			Return (Harga / LengthIn) * LengthOut
		End Get
	End Property
End Class
Friend Class ResetAllStructureIn
	Public Property Row As Fusoh_StokDetail
	Public Property Id As Long
	Public Property KodePart As String
	Public Property NamaPart As String
	Public Property Qty As Double
End Class
