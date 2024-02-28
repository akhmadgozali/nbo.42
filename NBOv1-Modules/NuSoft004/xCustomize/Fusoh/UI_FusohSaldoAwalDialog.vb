Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Public Class UI_FusohSaldoAwalDialog
	Private instance As Persistent.Fusoh_StokDetail
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private AllowSave As Boolean

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = False
	End Sub
	Overrides Sub LoadBeforeInitialize()
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BSTransaksi.xml")) = True Then
			lytTransaksiSA.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BSTransaksi.xml"))
		End If
		sumber = New Persistent.SumberDataCollection(session)
		txtCustomer.Properties.DataSource = New XPCollection(Of Kontak)(session)
	End Sub
	Overrides Sub InitializeData()
		setting = New NuSoft001.Logic.FinaSetting(session)
		AllowSave = True
		If Tipe = InputType.Tambah Then
			Me.Text = "Saldo Awal: Tambah"
			txtBarang.EditValue = Nothing
			txtHarga.EditValue = 0.0
			txtQty.EditValue = 0.0
			instance = New Persistent.Fusoh_StokDetail(session)
			instance.SerialTemp = New List(Of Persistent.Fusoh_StockDetailSerial_Temp)
		Else
			instance = session.GetObjectByKey(Of Persistent.Fusoh_StokDetail)(CType(IdToEdit, Int64))
			instance.SerialTemp = New List(Of Persistent.Fusoh_StockDetailSerial_Temp)
			txtCustomer.EditValue = instance.Barang.Customer
			txtBarang.EditValue = instance.Barang
			txtQty.EditValue = instance.QtyIn
			txtHarga.EditValue = instance.Harga
			Me.Text = "Saldo Awal: Edit - " & instance.Barang.Kode

			'===== set serial temp
			instance.SerialTemp = New List(Of Persistent.Fusoh_StockDetailSerial_Temp)
			For j = 0 To instance.Serial.Count - 1
				Dim ser = instance.Serial(j)
				Dim serialPersist = New Persistent.Fusoh_StockDetailSerial_Temp
				serialPersist.Id = ser.Id
				serialPersist.LengthIn = ser.LengthIn
				serialPersist.Serial = ser.Serial
				serialPersist.MillSheet = ser.MillSheet
				instance.SerialTemp.Add(serialPersist)
			Next

			'cek dulu apakah sudah pernah diproduksi, cek table dempyou
			Dim dempyou = New XPQuery(Of Persistent.Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang Is instance.Barang) _
				.Select(Function(s) s.Serial).ToList
			For Each serial In instance.Serial
				If dempyou.Contains(serial.Serial) Then
					txtCustomer.Enabled = False
					txtBarang.Enabled = False
					txtQty.Enabled = False
					AllowSave = False
					Exit For
				End If
			Next
		End If
	End Sub
	Overrides Sub LoadAfterInitialize()
		'txtHarga.Properties.Mask.EditMask = setting.NumericFormatToString
		'txtTotal.Properties.Mask.EditMask = setting.NumericFormatToString
	End Sub
	Overrides Sub SimpanData()
		If (txtBarang.EditValue Is Nothing) Then
			Throw New Utils.Exception("Masukkan part no.", -1)
		End If
		If (txtQty.Value = 0) Then
			Throw New Utils.Exception("Masukkan qty", -2)
		End If
    'If (txtHarga.Value = 0) Then
    '	Throw New Utils.Exception("Masukkan harga", -3)
    'End If

    If Tipe = InputType.Tambah Then
			'========== cari stok main saldo awal
			Dim stokMain = New XPQuery(Of Persistent.Fusoh_StokMain)(session).Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.BS) _
				.Take(1).SingleOrDefault

			If (stokMain Is Nothing) Then
				stokMain = New Persistent.Fusoh_StokMain(session)
				stokMain.Sumber = sumber.GetObject(Persistent.SumberDataJenis.BS)
				stokMain.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
				stokMain.Tanggal = DateTime.Now
				stokMain.Regional = New XPQuery(Of NPO.Modules.ModSys.Regional)(session).Take(1).SingleOrDefault
				stokMain.Gudang = New XPQuery(Of Persistent.Gudang)(session).Take(1).SingleOrDefault
				stokMain.Kode = stokMain.Number.GetNewNumber.Kode
				stokMain.StatusTransaksi = StatusTransaksiEnum.Posting
			End If

			instance.Main = stokMain
		End If

		instance.Gudang = instance.Main.Gudang
		instance.Barang = CType(txtBarang.EditValue, Persistent.Fusoh_Barang)
		instance.OutDiameter = instance.Barang.OutDiameter
		instance.InDiameter = instance.Barang.InDiameter
		instance.Thickness = instance.Barang.Thickness
		instance.Length = instance.Barang.Length
		instance.QtyIn = txtQty.Value
		instance.Harga = txtHarga.Value
		instance.Satuan = instance.Barang.Satuan
    instance.Weight = FusohLogic.Item.GetWeight(instance.OutDiameter, instance.Length, instance.Thickness) * txtQty.Value
		'======== set serial dari temp
		For j = instance.Serial.Count - 1 To 0 Step -1
			Dim x = instance.Serial(j)
			Dim find = instance.SerialTemp.Find(Function(m) m.Id = x.Id)
			If find Is Nothing Then
				instance.Serial(j).Delete()
			End If
		Next

		For j = 0 To instance.SerialTemp.Count - 1
			Dim x = instance.SerialTemp(j)
			Dim find = instance.Serial.ToList.Find(Function(m) m.Id = x.Id)
			If find Is Nothing Then
				find = New Persistent.Fusoh_StokSerial(session)
				find.DetailMain = instance
			End If
      find.LengthIn = instance.SerialTemp(j).LengthIn
			find.Serial = instance.SerialTemp(j).Serial
			find.MillSheet = instance.SerialTemp(j).MillSheet
		Next

		'========== update hpp yang sudah terpakai
		Dim daftar = New List(Of KeyValuePair(Of Persistent.Fusoh_Barang, List(Of String)))
		daftar.Add(New KeyValuePair(Of Persistent.Fusoh_Barang, List(Of String))(instance.Barang, instance.Serial.ToList.Select(Function(s) s.Serial).ToList))
		'For Each ser In instance.Serial
		'	daftar.Add(New KeyValuePair(Of Persistent.Fusoh_Barang, String)(instance.Barang, ser.Serial))
		'Next

		If instance.Barang.TipeBarang = Persistent.TipeBarang.BahanBaku Then
			Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
				Try
					splashManager.ShowWaitForm()
					splashManager.SetWaitFormCaption("Silahkan Tunggu")
					splashManager.SetWaitFormDescription("Hitung ulang HPP ...")

					FusohLogic.HPP.HitungUlangHPPDariSerial(session, daftar)
					splashManager.CloseWaitForm()
				Catch ex As Exception
					splashManager.CloseWaitForm()
					Throw New Exception(ex.Message, ex.InnerException)
				End Try
			End Using
		End If

		session.CommitChanges()
	End Sub

	Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtBarang.Focus()
			Case -2 : txtQty.Focus()
			Case -3 : txtHarga.Focus()
			Case Else
		End Select
	End Sub

	Private Sub txtBarang_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtBarang.EditValueChanging
		btnSerial.Enabled = False
		If Not e.NewValue Is Nothing Then
			Dim val = CType(e.NewValue, Persistent.Fusoh_Barang)
			txtMaterial.Text = val.Nama
			txtSatuan.EditValue = val.Satuan.Nama
			'txtHarga.EditValue = val.LastPurchase
			btnSerial.Enabled = val.TipeBarang = Persistent.TipeBarang.BahanBaku

			If val.TipeBarang = Persistent.TipeBarang.BahanBaku Then
				SetSerial()
			Else
				ClearSerial()
			End If
		Else
			txtMaterial.Text = ""
			txtSatuan.EditValue = ""
		End If
	End Sub
	Private Sub txtBarang_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarang.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			txtBarang.EditValue = Nothing
		End If
	End Sub

	Private Sub txtCustomer_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtCustomer.EditValueChanging
		If (e.NewValue Is Nothing) Then
			txtBarang.Properties.DataSource = Nothing
		Else
			Dim val = CType(e.NewValue, Kontak)
			txtBarang.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_Barang)(session).Where(Function(w) w.Customer Is val).ToList
		End If
	End Sub
	Private Sub txtCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomer.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			txtCustomer.EditValue = Nothing
		End If
	End Sub

	Private Sub btnSerial_Click(sender As Object, e As EventArgs) Handles btnSerial.Click
		Dim frm As New UI_FusohSerialDialog1
		frm.NamaDatabase = Me.NamaDatabase
		frm.MenuId = Me.MenuId
		frm.session = session

		instance.Barang = CType(txtBarang.EditValue, Persistent.Fusoh_Barang)
		instance.QtyIn = CDbl(txtQty.Value)
		frm.LoadingData(instance)
		If Not AllowSave Then
			frm.Disable()
		End If
		frm.ShowDialog()
		instance.QtyIn = instance.SerialTemp.Count
		txtQty.Value = instance.SerialTemp.Count
	End Sub

	Private Sub txtQty_ValueChanged(sender As Object, e As EventArgs) Handles txtQty.ValueChanged
		txtTotal.EditValue = txtHarga.Value * txtQty.Value
		instance.QtyIn = CDbl(txtQty.Value)

		'==== serial temp
		If Not (txtBarang.EditValue Is Nothing) Then
			Dim barang = CType(txtBarang.EditValue, Persistent.Fusoh_Barang)
			If barang.TipeBarang = Persistent.TipeBarang.BahanBaku Then
				SetSerial()
			End If
		Else
			ClearSerial()
		End If
	End Sub
	Private Sub txtHarga_ValueChanged(sender As Object, e As EventArgs) Handles txtHarga.ValueChanged
		txtTotal.EditValue = txtHarga.Value * txtQty.Value
	End Sub

	Private Sub SetSerial()
		If (instance.QtyIn > instance.SerialTemp.Count) Then
			For j = 0 To instance.QtyIn - instance.SerialTemp.Count - 1
				Dim serial = New Persistent.Fusoh_StockDetailSerial_Temp With {
						.Id = CLng(j + 1),
						.LengthIn = instance.Length,
						.Serial = "",
						.MillSheet = ""
					}
				instance.SerialTemp.Add(serial)
			Next
		ElseIf (instance.QtyIn < instance.SerialTemp.Count) Then
			For j = instance.SerialTemp.Count - 1 To instance.QtyIn Step -1
				instance.SerialTemp.RemoveAt(CInt(j))
			Next
		End If
	End Sub
	Private Sub ClearSerial()
		instance.SerialTemp.Clear()
	End Sub
End Class