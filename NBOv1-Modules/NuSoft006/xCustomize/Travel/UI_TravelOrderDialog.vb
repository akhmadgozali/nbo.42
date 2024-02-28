Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent

Friend Class UI_TravelOrderDialog
	Private instance As Travel_Order
	Private detailToDelete As New List(Of Travel_OrderDetail)
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private salesSetting As Logic.SalesSetting

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
		Travel_Order.AutoSaveOnEndEdit = False
		Travel_OrderDetail.AutoSaveOnEndEdit = False
	End Sub
	Overrides Sub LoadBeforeInitialize()
		xGridView.OptionsLayout.StoreAllOptions = True
		setting = New NuSoft001.Logic.FinaSetting(session)
		salesSetting = New Logic.SalesSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SOTransaksi.xml")) = True Then
		'	lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SOTransaksi.xml"))
		'End If
		'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml")) = True Then
		'	xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
		'End If
		colDivisi.Visible = setting.MultiDivisi
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Travel_Order(session)
			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Travel_Order)(Convert.ToInt64(IdToEdit))
			txtNoTransaksi.Text = instance.Kode
			txtTanggal.EditValue = instance.Tanggal
			txtKontak.EditValue = instance.Pelanggan
			txtAlamat.EditValue = instance.KontakAlamat
			If Not instance.KontakAlamat Is Nothing Then
				txtAlamatText.EditValue = instance.KontakAlamat.Alamat
			End If
			txtRegional.EditValue = instance.Regional
			txtKontakPerson.EditValue = instance.KontakPerson
			txtTglBerlaku.DateTime = instance.TanggalBerlaku
			txtUang.EditValue = instance.Uang
			txtTermin.EditValue = instance.Termin
			txtKaryawan.EditValue = instance.BagPenjualan
			txtUraian.Text = instance.Uraian
			txtCatatan.Text = instance.Catatan
			txtNoRef.EditValue = instance.ReffNumber
			txtCustom1.EditValue = instance.Custom1
			txtCustom2.EditValue = instance.Custom2
			txtCustom3.EditValue = instance.Custom3
			txtCustom4.EditValue = instance.Custom4
			txtCustom5.EditValue = instance.Custom5

			xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
			instance.Detail.CriteriaString = ""
			xGrid.DataSource = instance.Detail
			editAssign = False
			HitungTotal()
		End If
		SetNomor()
		xGridView.OptionsBehavior.Editable = True
		xGridView.OptionsBehavior.ReadOnly = False
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Travel Order [SO]: Tambah Data"
		Else
			Me.Text = "Travel Order [SO]: Edit Data " & instance.Kode
			'If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
			'	DisableControl()
			'End If
			If instance.AutoStatus <> "Posting" Then
				DisableControl()
			End If
			If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
				DisableControl()
			End If
			If NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
				DisableControl()
			End If
		End If
	End Sub
	Private Sub CheckBeforeSave()
		If txtRegional.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan regional", -1)
		End If
		If txtTanggal.DateTime = Nothing Then
			Throw New Utils.Exception("Masukkan tanggal", -2)
		End If
		If txtKontak.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan pelanggan", -3)
		End If
		If txtUang.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan mata uang", -4)
		End If
		If String.IsNullOrEmpty(txtUraian.Text) Then
			Throw New Utils.Exception("Masukkan uraian", -5)
		End If

		For i = 0 To instance.Detail.Count - 1
			If instance.Detail(i).Barang Is Nothing Then
				Throw New Utils.Exception("Masukkan barang", -99)
			End If
			If instance.Detail(i).Qty = Nothing Then
				Throw New Utils.Exception("Qty tidak boleh 0", -99)
			End If
		Next

		' ======== cek kode ========
		If String.IsNullOrEmpty(txtNoTransaksi.Text) Then
			Return
		End If
		If Tipe = InputType.Edit AndAlso txtNoTransaksi.Text.ToLower = instance.Kode.ToLower Then
			Return
		End If

		Dim dataKode = New XPQuery(Of Travel_Order)(session).Where(Function(w) w.Kode = txtNoTransaksi.Text).ToList
		If dataKode.Count > 0 Then
			Throw New Utils.Exception("Kode '" & txtNoTransaksi.Text & "' sudah ada yang memakai." & vbCrLf & "Harap ganti dengan kode lain", -1)
		End If
	End Sub
	Overrides Sub SimpanData()
		'==== Check Data
		CheckBeforeSave()

		For i = detailToDelete.Count - 1 To 0 Step -1
			detailToDelete(i).Delete()
		Next

		Try
			'======= Simpan Main
			If Not txtKontak.EditValue Is Nothing Then
				instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
			Else
				instance.Pelanggan = Nothing
			End If
			instance.KontakAlamat = CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat)
			instance.Tanggal = txtTanggal.DateTime
			instance.Kode = txtNoTransaksi.Text
			instance.KontakPerson = txtKontakPerson.EditValue
			instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			instance.TanggalBerlaku = txtTglBerlaku.DateTime
			instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
			instance.Termin = CType(txtTermin.EditValue, NuSoft005.Persistent.Termin)
			instance.BagPenjualan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
			instance.Uraian = txtUraian.Text
			instance.Catatan = txtCatatan.Text
			instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
			instance.ReffNumber = txtNoRef.Text
			instance.Custom1 = txtCustom1.Text
			instance.Custom2 = txtCustom2.Text
			instance.Custom3 = txtCustom3.Text
			instance.Custom4 = txtCustom4.Text
			instance.Custom5 = txtCustom5.Text
			If salesSetting.AutoUraian = True Then
				If Not instance.Detail(0).Proyek Is Nothing Then
					instance.Uraian = "Travel Order - " & instance.Detail(0).Proyek.Kode
				End If
			End If

			If String.IsNullOrEmpty(txtNoTransaksi.Text) Then
				instance.Kode = instance.Number.GetNewNumber.Kode
			End If
			instance.Save()

			'======= Simpan instance
			session.CommitChanges()
		Catch ex As Utils.Exception
			Throw New Utils.Exception(ex)
		Catch ex As Exception
			If ex.Message.Contains("Duplicate entry") Then
				instance.Kode = instance.Number.GetNewNumber.Kode
				session.CommitChanges()
			Else
				Throw New Exception(ex.Message, ex.InnerException)
			End If
		End Try

		'======= Konfirmasi Cetak Laporan
		Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.SO, MainClass.reportName.VoucherSO)
		frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
		reportCode = MainClass.GetReport(MainClass.reportName.VoucherSO)
		message = String.Format(message, "Travel Order")
		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtKontak.Focus()
			Case -4 : txtUang.Focus()
			Case -5 : txtUraian.Focus()
			Case -99 : xGrid.Focus()
		End Select
	End Sub

	Private Sub ChangeCode()
		If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
			Return
		End If
		If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing) Then
			Return
		End If
		If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatSumber) AndAlso instance.Sumber Is Nothing Then
			Return
		End If

		Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
		txtNoTransaksi.Text = nomor.Kode
	End Sub
	Private Sub BindingDataSource()
		If salesSetting.FilterKontak = True Then
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
		Else
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
		End If
		txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)

		txtTermin.Properties.DataSource = New XPCollection(Of NuSoft005.Persistent.Termin)(session)
		txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
		colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session, New BinaryOperator(NameOf(NuSoft004.Persistent.Barang.Jenis), NuSoft004.Persistent.JenisBarang.Jasa, BinaryOperatorType.Equal))
		colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
		colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    colProyekRepo.DataSource = New XPCollection(Of NuSoft001.Persistent.Proyek)(session)
  End Sub
	Private Sub SetFormat()
		colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQty.DisplayFormat.FormatString = setting.NumericFormatString
		colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHarga.DisplayFormat.FormatString = setting.NumericFormatString
		colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colTotal.DisplayFormat.FormatString = setting.NumericFormatString
		colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

		colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colDiscount.DisplayFormat.FormatString = setting.NumericFormatString
		colDiscountPersen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colDiscountPersen.DisplayFormat.FormatString = setting.NumericFormatString

		txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtTotal.Properties.Mask.EditMask = setting.NumericFormatToString
	End Sub
	Private Sub LoadDefault()
		If xpSettingRegional Is Nothing Then
			xpSettingRegional = New XPCollection(Of NuSoft001.Persistent.SettingRegional)(session)
		End If
		defaultRegional = UserInfo.GetDefaultRegional(session)
		txtTanggal.EditValue = Now
		If Not defaultRegional Is Nothing Then
			txtRegional.EditValue = defaultRegional
		Else
			txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
		End If
		instance.Tanggal = txtTanggal.DateTime
		instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
		txtUraian.EditValue = salesSetting.UraianSO
		txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SO)
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
	End Sub
	Private Sub DisableControl()
		txtKontak.Properties.ReadOnly = True
		txtTanggal.Properties.ReadOnly = True
		txtNoTransaksi.Properties.ReadOnly = True
		txtRegional.Properties.ReadOnly = True
		txtUraian.Properties.ReadOnly = True
		txtKontakPerson.Properties.ReadOnly = True
		txtTglBerlaku.Properties.ReadOnly = True
		txtTermin.Properties.ReadOnly = True
		txtUang.Properties.ReadOnly = True
		txtKaryawan.Properties.ReadOnly = True
		txtNoRef.Enabled = False
		txtCatatan.Properties.ReadOnly = True
		txtUraian.Enabled = False

		btnRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
		barCopySO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

		xGridView.OptionsBehavior.Editable = False
		AllowSave = False
	End Sub
	Private Sub GantiTanggalTahun()
		Dim str As String = "Edit tanggal dengan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

		If Tipe = InputType.Edit AndAlso isShown Then
			If instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
				If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
					instance.Tanggal = txtTanggal.DateTime
					ChangeCode()
				Else
					txtTanggal.EditValue = instance.Tanggal
				End If
			Else
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If
		ElseIf Tipe = InputType.Tambah Then
			instance.Tanggal = txtTanggal.DateTime
			ChangeCode()
		End If
	End Sub
	Private Sub GantiTanggalBulan()
		Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

		If Tipe = InputType.Edit AndAlso isShown Then
			If instance.Tanggal.Month <> CDate(txtTanggal.EditValue).Month OrElse instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
				If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
					instance.Tanggal = txtTanggal.DateTime
					ChangeCode()
				Else
					txtTanggal.EditValue = instance.Tanggal
				End If
			Else
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If
		ElseIf Tipe = InputType.Tambah Then
			instance.Tanggal = txtTanggal.DateTime
			ChangeCode()
		End If
	End Sub

	Private Sub txtKontak_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtKontak.ButtonClick
		If e.Button.Index = 1 Then
			Dim frm As Core.Win.Forms.InputBase = GetAddForm(sender)
			frm.session = session
			frm.Tipe = InputType.Tambah
			frm.Owner = Me
			If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
				RefreshLookupSources(sender)
			End If
		End If
	End Sub
	Private Function GetAddForm(sender As Object) As Core.Win.Forms.InputBase
		If sender Is txtKontak Then
			Return New NuSoft001.UI_KontakDialog
			'ElseIf sender Is txtKontak Then
			'  Return New UI_KontakDialog
		Else
			Return Nothing
		End If
	End Function
	Private Sub RefreshLookupSources(sender As Object)
		BindingDataSource()
	End Sub
	Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
			txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
			txtAlamat.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
		End If
	End Sub
	Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
		Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
		Try
			If Tipe = InputType.Edit AndAlso isShown Then
				If Not instance.Regional Is e.NewValue Then
					If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Regional", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
						instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
						ChangeCode()
					Else
						e.Cancel = True
					End If
				Else
					instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
					ChangeCode()
				End If
			ElseIf Tipe = InputType.Tambah Then
				instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
				ChangeCode()
			End If
		Catch ex As Exception
			If ex.Message.Contains("Object reference not set to an instance") Then
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
			End If
		End Try
	End Sub
	Private Sub txtTanggal_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTanggal.DateTimeChanged
		Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
		Try
			If Tipe = InputType.Edit AndAlso isShown Then
				If instance.Tanggal.Month <> CDate(txtTanggal.EditValue).Month OrElse instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
					If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
						instance.Tanggal = txtTanggal.DateTime
						ChangeCode()
					Else
						txtTanggal.EditValue = instance.Tanggal
					End If
				Else
					instance.Tanggal = txtTanggal.DateTime
					ChangeCode()
				End If
			ElseIf Tipe = InputType.Tambah Then
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If
		Catch ex As Exception
			If ex.Message.Contains("Object reference not set to an instance") Then
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
			End If
		End Try
	End Sub

	Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
		If Not e.Value Is Nothing Then
			Dim row As Travel_OrderDetail = CType(xGridView.GetRow(e.RowHandle), Travel_OrderDetail)
			If e.Column Is colKodeBarang Then
				If Not row Is Nothing Then
					Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
					Dim xHarga As Double = 0
					row.Satuan = xbarang.Satuan
					Select Case CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).LevelPenjualan
						Case NuSoft001.Persistent.eLevelPenjualan.Level1 : xHarga = xbarang.HargaJual1
						Case NuSoft001.Persistent.eLevelPenjualan.Level2 : xHarga = xbarang.HargaJual2
						Case NuSoft001.Persistent.eLevelPenjualan.Level3 : xHarga = xbarang.HargaJual3
						Case NuSoft001.Persistent.eLevelPenjualan.Level4 : xHarga = xbarang.HargaJual4
						Case NuSoft001.Persistent.eLevelPenjualan.Level5 : xHarga = xbarang.HargaJual5
					End Select
					row.Harga = xHarga
				End If
			End If
			If (e.Column Is colDiscountPersen) Or (e.Column Is colQty) Or (e.Column Is colHarga) Then
				If Not row Is Nothing Then
					row.Discount = (row.DiscountPersen / 100) * (row.Qty * row.Harga)
				End If
			End If
			HitungTotal()
		End If
	End Sub
	'Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
	'	xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
	'End Sub
	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
		Dim row As Travel_OrderDetail = CType(xGridView.GetRow(e.RowHandle), Travel_OrderDetail)
		row.Barang = Nothing
		row.Qty = 1
		row.Main = instance
		row.Catatan = ""
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Travel_OrderDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Travel_OrderDetail)
			xGridView.DeleteRow(xGridView.FocusedRowHandle)
			detailToDelete.Add(Id)
		End If
	End Sub

	Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
		isShown = True
	End Sub
	Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
		MyBase.OnKeyDown(e)
		If e.Control AndAlso e.Shift Then
			xGrid.Focus()
		End If
	End Sub
	Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
		ChangeCode()
	End Sub

	Sub HitungTotal()
		txtTotal.EditValue = instance.Total
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub
	Private Sub txtTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles txtTanggal.EditValueChanged
		txtTglBerlaku.Properties.MinValue = txtTanggal.DateTime
	End Sub
	Private Sub txtTglBerlaku_EditValueChanged(sender As Object, e As EventArgs) Handles txtTglBerlaku.EditValueChanged
		txtTanggal.Properties.MaxValue = txtTglBerlaku.DateTime
	End Sub
	Private Sub txtAlamat_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAlamat.EditValueChanging
		If Not e.NewValue Is Nothing Then
			txtAlamatText.Text = CType(e.NewValue, NuSoft001.Persistent.KontakAlamat).Alamat
		End If
	End Sub

	Private Sub btnCopy_Click(sender As Object, e As EventArgs)
		'If Not txtCopySO.EditValue Is Nothing Then
		'	Dim Item As Persistent.OrderPenjualan = CType(txtCopySO.EditValue, Persistent.OrderPenjualan)
		'	Dim data As Persistent.OrderPenjualanDetail

		'	For i = instance.Detail.Count - 1 To 0 Step -1
		'		instance.Detail(i).Delete()
		'	Next

		'	For i = 0 To Item.Detail.Count - 1
		'		data = New Persistent.OrderPenjualanDetail(session)
		'		data.Barang = Item.Detail(i).Barang
		'		data.Qty = Item.Detail(i).Qty
		'		data.Satuan = Item.Detail(i).Satuan
		'		data.Harga = Item.Detail(i).Harga
		'		data.PPN = Item.Detail(i).PPN
		'		data.PPH = Item.Detail(i).PPH
		'		data.PPNp = Item.Detail(i).PPNp
		'		data.PPHp = Item.Detail(i).PPHp
		'		data.Catatan = Item.Detail(i).Catatan
		'		data.Divisi = Item.Detail(i).Divisi
		'		data.Proyek = Item.Detail(i).Proyek
		'		instance.Detail.Add(data)
		'	Next
		'	HitungTotal()
		'End If
	End Sub

	Private Sub barCopySO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barCopySO.ItemClick
		Dim frm As New UI_TravelOrderDialogCopy
		frm.session = session
		frm.LoadData()
		If frm.ShowDialog = DialogResult.OK Then
			If Not frm.SOTerpilih Is Nothing Then
				Dim Item As Travel_Order = frm.SOTerpilih
				Dim data As Travel_OrderDetail

				For i = instance.Detail.Count - 1 To 0 Step -1
					instance.Detail(i).Delete()
				Next

				For i = 0 To Item.Detail.Count - 1
					data = New Travel_OrderDetail(session)
					data.Main = instance
					data.Barang = Item.Detail(i).Barang
					data.Qty = Item.Detail(i).Qty
					data.Satuan = Item.Detail(i).Satuan
					data.Harga = Item.Detail(i).Harga
					data.Catatan = Item.Detail(i).Catatan
					data.Divisi = Item.Detail(i).Divisi
					data.Proyek = Item.Detail(i).Proyek
					instance.Detail.Add(data)
				Next
				HitungTotal()
			End If
		End If
	End Sub
End Class