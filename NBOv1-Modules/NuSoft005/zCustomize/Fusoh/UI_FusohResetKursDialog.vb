Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent

Public Class UI_FusohResetKursDialog
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
	End Sub
	Overrides Sub LoadBeforeInitialize()
		txtBulan.Properties.Items.Clear()
		For i = 1 To 12
			Dim tgl = New DateTime(Now.Year, i, 1)
			txtBulan.Properties.Items.Add(tgl.ToString("MMMM"))
		Next
		txtTahun.Properties.MinValue = Now.Year - 10
		txtTahun.Properties.MaxValue = Now.Year + 5

		Dim finaSetting As New NuSoft001.Logic.FinaSetting(session)
		Dim muDef = finaSetting.MultiMataUangDefault
		If muDef <> 0 Then
			txtMataUang.Properties.DataSource = New XPQuery(Of NuSoft001.Persistent.MataUang)(session).Where(Function(w) w.Id <> muDef).ToList()
		Else
			txtMataUang.Properties.DataSource = New XPQuery(Of NuSoft001.Persistent.MataUang)(session)
		End If
	End Sub
	Overrides Sub InitializeData()
		If Tipe = InputType.Tambah Then
			Me.Text = "Reset Kurs: Tambah"
			txtBulan.SelectedIndex = Now.Month - 1
			txtTahun.Value = Now.Year
			txtMataUang.EditValue = Nothing
			txtKurs.Value = 0
			txtKeterangan.Text = ""
		Else
			Dim instance = session.GetObjectByKey(Of Persistent.Fusoh_ResetKurs)(CType(IdToEdit, Int32))
			txtBulan.SelectedIndex = instance.Bulan - 1
			txtTahun.Text = instance.Tahun
			txtMataUang.EditValue = instance.MataUang
			txtKurs.Value = instance.Kurs
			txtKeterangan.Text = instance.Keterangan
			Me.Text = "Reset Kurs : Edit - " & instance.Periode.ToString("MMMM yyyy")

			txtBulan.Enabled = False
			txtTahun.Enabled = False
			txtMataUang.Enabled = False
		End If
	End Sub
	Overrides Sub SimpanData()
		If (txtBulan.SelectedIndex = -1) Then Throw New Utils.Exception("Masukkan bulan", -1)
		If (txtTahun.Value = 0) Then Throw New Utils.Exception("Masukkan tahun", -2)
		If (txtMataUang.EditValue Is Nothing) Then Throw New Utils.Exception("Masukkan mata uang", -3)
		If (txtKurs.Value = 0) Then Throw New Utils.Exception("Kurs tidak boleh 0", -4)
		If Tipe = InputType.Tambah Then
			Dim found = New XPQuery(Of Fusoh_ResetKurs)(session).Where(Function(w) w.Tahun = txtTahun.Value AndAlso w.Bulan = txtBulan.SelectedIndex + 1 AndAlso w.MataUang Is CType(txtMataUang.EditValue, NuSoft001.Persistent.MataUang)).ToList
			If found.Count > 0 Then
				Throw New Utils.Exception(String.Format("Reset kurs untuk periode {0} {1} mata uang {2} sudah pernah dilakukan", txtBulan.Text, txtTahun.Value, txtMataUang.Text), -3)
			End If
		End If

		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Mulai reset kurs ...")

				Dim instance As Fusoh_ResetKurs
				If Tipe = InputType.Tambah Then
					instance = New Fusoh_ResetKurs(session)
				Else
					instance = session.GetObjectByKey(Of Fusoh_ResetKurs)(CType(IdToEdit, Int32))
				End If
				instance.Bulan = txtBulan.SelectedIndex + 1
				instance.Tahun = txtTahun.Value
				instance.MataUang = CType(txtMataUang.EditValue, NuSoft001.Persistent.MataUang)
				instance.Kurs = txtKurs.Value
				instance.Keterangan = txtKeterangan.Text
				instance.Save()

				Dim listAM = New List(Of Fusoh_PenerimaanBarang)
				Dim dataRI = New XPQuery(Of Fusoh_PenerimaanInvoice)(session) _
					.Where(Function(w) w.Sumber.Id = SumberDataJenis.RI AndAlso w.Tanggal.Year = instance.Tahun _
					AndAlso w.Tanggal.Month = instance.Bulan AndAlso w.Uang Is instance.MataUang).ToList
				For Each item In dataRI
					splashManager.SetWaitFormDescription("Update kurs invoice nomor " & item.Kode & " ...")
					' ========= UPDATE INVOICE PEMBELIAN ============
					item.Kurs = instance.Kurs

					' ========= UPDATE HARGA DI PENERIMAAN PEMBELIAN ============
					Dim daftarGrDetail = New XPQuery(Of Fusoh_PenerimaanBarangDetail)(session).Where(Function(w) w.Main.Exim.PO Is item.NoOrder).ToList
					For Each x In daftarGrDetail
						Dim detInvoice = item.Detail.ToList.Find(Function(f) f.PODetail Is x.EximDetail.PODetail)
						If Not detInvoice Is Nothing Then
							x.Harga = (detInvoice.TotalPembelianIDR) / x.Qty 'hpp per qty

							' ========= LIST DATA AM YANG PAKAI PENERIMAAN INI ============
							For Each serial In x.DetailSerial
								Dim serialAM = New XPQuery(Of Fusoh_PenerimaanBarangDetailSerial)(session) _
									.Where(Function(w) w.DetailMain.Main.Sumber.Id = SumberDataJenis.AM AndAlso w.DetailMain.Barang Is serial.DetailMain.Barang _
																		AndAlso w.Serial = serial.Serial AndAlso w.LengthOut > 0) _
								.GroupBy(Function(qq) qq.DetailMain.Main).Select(Function(s) s.Key).ToList
								listAM.AddRange(serialAM)
							Next
						End If
					Next
				Next
				session.CommitChanges()

				splashManager.SetWaitFormDescription("Reset HPP ...")
				For Each am In listAM.GroupBy(Function(x) x.Id).Select(Function(c) c.Key).ToList
					NuSoft004.FusohLogic.HPP.HitungHPPDariProduksi(session, am, False)
				Next
				session.CommitChanges()

			Catch ex As Exception
				Throw New Utils.Exception(ex.Message, ex.InnerException)
			Finally
				splashManager.CloseWaitForm()
			End Try
		End Using
	End Sub
	Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtBulan.Focus()
			Case -2 : txtTahun.Focus()
			Case -3 : txtMataUang.Focus()
			Case -4 : txtKurs.Focus()
			Case Else
		End Select
	End Sub
End Class