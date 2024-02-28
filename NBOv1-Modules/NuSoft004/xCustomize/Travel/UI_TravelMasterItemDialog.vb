Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Friend Class UI_TravelMasterItemDialog
	Private _jenis As JenisBarang
	Private instance As Barang
	Private settingitem As Logic.ItemSetting

	Sub New(jenis As JenisBarang)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_jenis = jenis
		AutoCloseOnSave = True
	End Sub

	Public Overrides Sub LoadAfterInitialize()
		BindingDataSource()
		settingitem = New Logic.ItemSetting(session)
		If Tipe = InputType.Tambah Then
			Me.Text = "Item: Tambah"
			instance = New Barang(session)
			txtHargaBeli.Value = 0
			txtHargaJual1.Value = 0
			txtHargaJual2.Value = 0
			txtHargaJual3.Value = 0
			txtHargaJual4.Value = 0
			txtHargaJual5.Value = 0
			txtStockMax.Value = 0
			txtStockMin.Value = 0
			txtAktif.Checked = True

			txtAkunPersediaan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPersediaan))
			txtAkunPendapatan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPendapatan))
			txtAkunHPP.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunHPP))
			txtAkunDiscPenjualan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPenjualan))
			txtAkunDiscPembelian.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPembelian))
			txtAkunReturPenjualan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPenjualan))
			txtAkunReturPembelian.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPembelian))
			txtPajakIn.EditValue = session.GetObjectByKey(Of Pajak)(Convert.ToInt32(settingitem.PajakIN))
			txtPajakOut.EditValue = session.GetObjectByKey(Of Pajak)(Convert.ToInt32(settingitem.PajakOut))
			txtUang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtUang)
			txtSatuan.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtSatuan)
			txtSatuanDasar.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtSatuanDasar)
		Else
			instance = session.GetObjectByKey(Of Persistent.Barang)(CType(IdToEdit, Int64))
			txtAktif.EditValue = instance.Aktif
			txtKode.EditValue = instance.Kode
			txtNama.EditValue = instance.Nama
			txtSatuan.EditValue = instance.Satuan
			txtSatuanDasar.EditValue = instance.SatuanD
			txtUang.EditValue = instance.Uang
			txtHargaBeli.Value = CDec(instance.LastPurchase)
			txtHargaJual1.Value = CDec(instance.HargaJual1)
			txtHargaJual2.Value = CDec(instance.HargaJual2)
			txtHargaJual3.Value = CDec(instance.HargaJual3)
			txtHargaJual4.Value = CDec(instance.HargaJual4)
			txtHargaJual5.Value = CDec(instance.HargaJual5)
			txtAkunPersediaan.EditValue = instance.CoaStock
			txtAkunPendapatan.EditValue = instance.CoaIncome
			txtAkunHPP.EditValue = instance.CoaCost
			txtAkunDiscPenjualan.EditValue = instance.CoaDiscIncome
			txtAkunDiscPembelian.EditValue = instance.CoaDiscOut
			txtAkunReturPenjualan.EditValue = instance.CoaReturnIn
			txtAkunReturPembelian.EditValue = instance.CoaReturnOut
			txtPajakIn.EditValue = instance.PajakIN
			txtPajakOut.EditValue = instance.PajakOUT

			txtStockMax.Value = CDec(instance.StockMax)
			txtStockMin.Value = CDec(instance.StockMin)
			txtNote.EditValue = instance.Note

			Me.Text = "Item: Edit - " & instance.Kode
		End If
	End Sub
	Private Sub CheckBeforeSave()
		If String.IsNullOrEmpty(txtKode.Text) Then
			Throw New Utils.Exception("Masukkan kode barang", -1)
		End If
		If String.IsNullOrEmpty(txtNama.Text) Then
			Throw New Utils.Exception("Masukkan nama barang", -2)
		End If
		If txtSatuan.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan satuan", -3)
		End If
		If txtSatuanDasar.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan satuan dasar", -4)
		End If
		If txtUang.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan mata uang", -5)
		End If

		If txtAkunPersediaan.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan nomor coa untuk Persediaan", -11)
		End If
		If txtAkunPendapatan.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan nomor coa untuk Pendapatan", -12)
		End If
		If txtAkunHPP.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan nomor coa untuk Biaya [HPP]", -13)
		End If
		If txtPajakIn.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan Pajak Masukan", -14)
		End If
		If txtPajakOut.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan Pajak Keluaran", -15)
		End If

		' ======== cek kode ========
		If Tipe = InputType.Edit AndAlso txtKode.Text.ToLower = instance.Kode.ToLower Then
			Return
		End If

		Dim dataKode = New XPQuery(Of Barang)(session).Where(Function(w) w.Jenis = _jenis AndAlso w.Kode = txtKode.Text).ToList
		If dataKode.Count > 0 Then
			Throw New Utils.Exception("Kode '" & txtKode.Text & "' sudah ada yang memakai." & vbCrLf & "Harap ganti dengan kode lain", -1)
		End If
	End Sub
	Public Overrides Sub SimpanData()
		CheckBeforeSave()

		instance.Kode = txtKode.Text
		instance.Aktif = txtAktif.Checked
		instance.Nama = txtNama.Text
		instance.Jenis = _jenis
		If _jenis = JenisBarang.Persediaan Then
			instance.TipeBarang = TipeBarang.BahanJadi
		Else
			instance.TipeBarang = TipeBarang.Jasa
		End If
		instance.Satuan = CType(txtSatuan.EditValue, Satuan)
		instance.SatuanD = CType(txtSatuanDasar.EditValue, Satuan)
		instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
		instance.LastPurchase = txtHargaBeli.Value
		instance.HargaJual1 = txtHargaJual1.Value
		instance.HargaJual2 = txtHargaJual2.Value
		instance.HargaJual3 = txtHargaJual3.Value
		instance.HargaJual4 = txtHargaJual4.Value
		instance.HargaJual5 = txtHargaJual5.Value

		instance.CoaStock = CType(txtAkunPersediaan.EditValue, NuSoft001.Persistent.Coa)
		instance.CoaIncome = CType(txtAkunPendapatan.EditValue, NuSoft001.Persistent.Coa)
		instance.CoaCost = CType(txtAkunHPP.EditValue, NuSoft001.Persistent.Coa)
		instance.CoaDiscIncome = CType(txtAkunDiscPenjualan.EditValue, NuSoft001.Persistent.Coa)
		instance.CoaDiscOut = CType(txtAkunDiscPembelian.EditValue, NuSoft001.Persistent.Coa)
		instance.CoaReturnIn = CType(txtAkunReturPenjualan.EditValue, NuSoft001.Persistent.Coa)
		instance.CoaReturnOut = CType(txtAkunReturPembelian.EditValue, NuSoft001.Persistent.Coa)
		instance.PajakIN = CType(txtPajakIn.EditValue, Pajak)
		instance.PajakOUT = CType(txtPajakOut.EditValue, Pajak)

		instance.StockMax = txtStockMax.Value
		instance.StockMin = txtStockMin.Value
		instance.Note = txtNote.Text

		instance.Save()
		session.CommitChanges()
	End Sub
	Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
		ex.ShowWinMessageBox()
		If ex.ErrorNumber <= -10 Then
			TabbedControlGroup1.SelectedTabPage = LayoutControlGroup3
		Else
			TabbedControlGroup1.SelectedTabPage = tabBarangDialogGeneral
		End If
		Select Case ex.ErrorNumber
			Case -1 : txtKode.Focus()
			Case -2 : txtNama.Focus()
			Case -3 : txtSatuan.Focus()
			Case -4 : txtSatuanDasar.Focus()
			Case -5 : txtUang.Focus()
			Case -11 : txtAkunPersediaan.Focus()
			Case -12 : txtAkunPendapatan.Focus()
			Case -13 : txtAkunHPP.Focus()
			Case -14 : txtPajakIn.Focus()
			Case -15 : txtPajakOut.Focus()
		End Select
	End Sub

	Private Sub BindingDataSource()
		Dim xCOA As XPCollection(Of NuSoft001.Persistent.Coa)
		Dim settinginventory As New Logic.InventorySetting(session)
		txtSatuan.Properties.DataSource = New XPCollection(Of Satuan)(session)
		txtSatuanDasar.Properties.DataSource = New XPCollection(Of Satuan)(session)
		txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)

		xCOA = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank, NuSoft001.Persistent.CoaEnum.eKind.Persediaan, NuSoft001.Persistent.CoaEnum.eKind.Piutang, NuSoft001.Persistent.CoaEnum.eKind.AktivaLancarLainnya, NuSoft001.Persistent.CoaEnum.eKind.AktivaTetap, NuSoft001.Persistent.CoaEnum.eKind.AkumulasiPenyusutan, NuSoft001.Persistent.CoaEnum.eKind.HutangJangkaPanjang, NuSoft001.Persistent.CoaEnum.eKind.HutangJangkaPendek, NuSoft001.Persistent.CoaEnum.eKind.HutangLancarLainnya, NuSoft001.Persistent.CoaEnum.eKind.Modal, NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.PendapatanLainLain, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan, NuSoft001.Persistent.CoaEnum.eKind.BiayaOperasional, NuSoft001.Persistent.CoaEnum.eKind.BiayaLainLain})

		If settinginventory.SettingCOAAll = True Then
			txtAkunPersediaan.Properties.DataSource = xCOA
			txtAkunPendapatan.Properties.DataSource = xCOA
			txtAkunHPP.Properties.DataSource = xCOA
			txtAkunDiscPenjualan.Properties.DataSource = xCOA
			txtAkunDiscPembelian.Properties.DataSource = xCOA
			txtAkunReturPenjualan.Properties.DataSource = xCOA
			txtAkunReturPembelian.Properties.DataSource = xCOA
		Else
			txtAkunPersediaan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Persediaan})
			txtAkunPendapatan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan})
			txtAkunHPP.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
			txtAkunDiscPenjualan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
			txtAkunDiscPembelian.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
			txtAkunReturPenjualan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
			txtAkunReturPembelian.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
		End If
		txtPajakIn.Properties.DataSource = New XPCollection(Of Pajak)(session)
		txtPajakOut.Properties.DataSource = New XPCollection(Of Pajak)(session)
	End Sub
End Class