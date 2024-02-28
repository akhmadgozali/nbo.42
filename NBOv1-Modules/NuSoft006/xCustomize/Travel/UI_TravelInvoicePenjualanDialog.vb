Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Services

Friend Class UI_TravelInvoicePenjualanDialog
	Private instance As Travel_Invoice
	Private isShown As Boolean
	Private editAssign As Boolean = False
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private salesSetting As Logic.SalesSetting
	Private openSO As List(Of Travel_Order)
	Private detailToDelete As New List(Of Travel_InvoiceDetail)

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		salesSetting = New Logic.SalesSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVTransaksi.xml")) = True Then
		'	lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVTransaksi.xml"))
		'End If
		'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml")) = True Then
		'	xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml"))
		'End If
		colHarga.OptionsColumn.AllowEdit = salesSetting.OpenPriceInvoice
		colHarga.OptionsColumn.ReadOnly = Not salesSetting.OpenPriceInvoice
		'txtPajak.Properties.ReadOnly = Not salesSetting.OpenTaxIV
		colDivisi.Visible = setting.MultiDivisi
		editAssign = True
		txtKurs.Properties.MinValue = 1
		txtKurs.Properties.MaxValue = Decimal.MaxValue
		editAssign = False
	End Sub
	Overrides Sub InitializeData()
		'MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Travel_Invoice(session)
			instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Travel_Invoice)(Convert.ToInt64(IdToEdit))

			'======== load so
			If Not instance.TravelOrder Is Nothing Then
				Dim find = openSO.Find(Function(f) f Is instance.TravelOrder)
				If find Is Nothing Then
					openSO.Add(instance.TravelOrder)
				End If
			End If

			txtNoTransaksi.Text = instance.Kode
			txtRegional.EditValue = instance.Regional
			txtTanggal.EditValue = instance.Tanggal
			txtKontak.EditValue = instance.Pelanggan
			txtKontakPerson.EditValue = instance.KontakPerson
			txtAlamat.EditValue = instance.KontakAlamat
			If Not instance.KontakAlamat Is Nothing Then
				txtAlamatText.EditValue = instance.KontakAlamat.Alamat
			End If

			txtTipeInvoice.EditValue = instance.TipeInvoice
			txtTermin.EditValue = instance.Termin
			txtJatuhTempo.DateTime = instance.JatuhTempo
			txtKaryawan.EditValue = instance.BagPenjualan
			txtNoSO.EditValue = instance.TravelOrder
			txtUang.EditValue = instance.Uang
			txtKurs.Value = instance.Kurs
			txtUraian.Text = instance.Uraian
			txtCatatan.Text = instance.Catatan

			xGrid.DataSource = instance.Detail
			editAssign = False
		End If
		xGridView.OptionsBehavior.Editable = True
		xGridView.OptionsBehavior.ReadOnly = False
		SetNomor()
		HitungTotal()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Travel Invoice [IV] : Tambah Data"
		Else
			Me.Text = "Travel Invoice [IV] : Edit Data " & instance.Kode
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
		If txtKontak.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan pelanggan", -1)
		End If
		If txtRegional.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan regional", -2)
		End If
		If txtTanggal.DateTime = Nothing Then
			Throw New Utils.Exception("Masukkan tanggal", -3)
		End If
		If txtTipeInvoice.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan tipe invoice", -4)
		End If
		Dim tipInv = CType(txtTipeInvoice.EditValue, Persistent.eTipeInvoicePenjualan)
		If tipInv = Persistent.eTipeInvoicePenjualan.PakaiSO AndAlso txtNoSO.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan travel order", -5)
		End If
		If txtKurs.Value <= 0 Then
			Throw New Utils.Exception("Kurs harus lebih besar dari 0", -6)
		End If
    If String.IsNullOrEmpty(txtUraian.Text) Then
      Throw New Utils.Exception("Masukkan uraian", -7)
    End If
    If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id <> setting.MultiMataUangDefault Then
      If CType(txtKurs.EditValue, Double) <= 1 Then
        Throw New Utils.Exception("Masukkan kurs", -6)
      End If
    End If


    For Each xItem In instance.Detail
			If xItem.Barang Is Nothing Then
				Throw New Utils.Exception("Masukkan kode barang", -99)
			End If
			If xItem.Qty <= 0 Then
				Throw New Utils.Exception("Masukkan qty", -99)
			End If
			If xItem.Satuan Is Nothing Then
				Throw New Utils.Exception("Masukkan satuan", -99)
			End If
		Next

		' ======== cek kode ========
		If String.IsNullOrEmpty(txtNoTransaksi.Text) Then
			Return
		End If
		If Tipe = InputType.Edit AndAlso txtNoTransaksi.Text.ToLower = instance.Kode.ToLower Then
			Return
		End If

		Dim dataKode = New XPQuery(Of Travel_Invoice)(session).Where(Function(w) w.Kode = txtNoTransaksi.Text).ToList
		If dataKode.Count > 0 Then
			Throw New Utils.Exception("Kode '" & txtNoTransaksi.Text & "' sudah ada yang memakai." & vbCrLf & "Harap ganti dengan kode lain", -9)
		End If
	End Sub
	Overrides Sub SimpanData()
		CheckBeforeSave()

		For i = detailToDelete.Count - 1 To 0 Step -1
			detailToDelete(i).Delete()
		Next

		Try
			'======= Simpan Main
			If String.IsNullOrEmpty(txtNoTransaksi.Text) Then
				txtNoTransaksi.Text = instance.Number.GetNewNumber.Kode
			End If

			instance.Kode = txtNoTransaksi.Text
			instance.Tanggal = txtTanggal.DateTime
			instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			instance.Pelanggan = CType(txtKontak.EditValue, Kontak)
			instance.KontakPerson = txtKontakPerson.EditValue
			instance.KontakAlamat = CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat)

			instance.TipeInvoice = CType(txtTipeInvoice.EditValue, Persistent.eTipeInvoicePenjualan)
			instance.Termin = CType(txtTermin.EditValue, NuSoft005.Persistent.Termin)
			instance.JatuhTempo = txtJatuhTempo.DateTime
			If Not txtKaryawan.EditValue Is Nothing Then
				instance.BagPenjualan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
			Else
				instance.BagPenjualan = Nothing
			End If
			If Not txtNoSO.EditValue Is Nothing Then
				instance.TravelOrder = CType(txtNoSO.EditValue, Travel_Order)
			Else
				instance.TravelOrder = Nothing
			End If

			instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
			instance.Kurs = txtKurs.Value
			instance.Uraian = txtUraian.Text
			instance.Catatan = txtCatatan.Text
			instance.NominalDP = txtDP.Value
			instance.StatusTransaksi = StatusTransaksiEnum.Posting

			'buatkan jurnalnya
			TravelInvoiceServices.SetGL(instance, setting, salesSetting)

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
    Dim frm As New RF_TravelDataTransaksi(Persistent.SumberDataJenis.IV, MainClass.reportName.zTravelVoucherIV)
    frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zTravelVoucherIV)
    message = String.Format(message, "Invoice Penjualan")

		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtKontak.Focus()
			Case -2 : txtRegional.Focus()
			Case -3 : txtTanggal.Focus()
			Case -4 : txtTipeInvoice.Focus()
			Case -5 : txtNoSO.Focus()
			Case -6 : txtKurs.Focus()
			Case -7 : txtUraian.Focus()
			Case -99 : xGrid.Focus()
		End Select
	End Sub

	Private Sub BindingDataSource()
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		If salesSetting.FilterKontak = True Then
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
		Else
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
		End If
		txtTipeInvoice.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipeInvoicePenjualan))
		txtTermin.Properties.DataSource = New XPCollection(Of NuSoft005.Persistent.Termin)(session)
		txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
		txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
		colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session)
		colProyekRepo.DataSource = New XPCollection(Of NuSoft001.Persistent.Proyek)(session)
		openSO = New XPQuery(Of Travel_Order)(session).Where(Function(w) w.AutoStatus = "Posting" OrElse w.AutoStatus = "DP").ToList
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
		'txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
		'txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
		txtNoTransaksi.Text = nomor.Kode
	End Sub
	Private Sub SetFormat()
		txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtSubTotal.Properties.Mask.EditMask = setting.NumericFormatToString
		txtDP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtDP.Properties.Mask.EditMask = setting.NumericFormatToString
		txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtTotal.Properties.Mask.EditMask = setting.NumericFormatToString
		colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQty.DisplayFormat.FormatString = setting.NumericFormatToString
		colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHarga.DisplayFormat.FormatString = setting.NumericFormatToString
		colDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colDisc.DisplayFormat.FormatString = setting.NumericFormatToString
		colDiscP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colDiscP.DisplayFormat.FormatString = setting.NumericFormatToString
		colFOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colFOC.DisplayFormat.FormatString = setting.NumericFormatToString
		colFOC.SummaryItem.DisplayFormat = setting.NumericFormatString
		colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colSubTotal.DisplayFormat.FormatString = setting.NumericFormatToString
		colSubTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
		colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colTotal.DisplayFormat.FormatString = setting.NumericFormatToString
		colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
		colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colKurs.DisplayFormat.FormatString = setting.NumericFormatToString
		colKurs.SummaryItem.DisplayFormat = setting.NumericFormatString
		colNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colNominal.DisplayFormat.FormatString = setting.NumericFormatToString
		colNominal.SummaryItem.DisplayFormat = setting.NumericFormatString
	End Sub
	Private Sub LoadDefault()
		Dim defaultRegional = UserInfo.GetDefaultRegional(session)
		txtTanggal.EditValue = Now
		If Not defaultRegional Is Nothing Then
			txtRegional.EditValue = defaultRegional
		Else
			txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
		End If
		txtTipeInvoice.EditValue = Persistent.eTipeInvoicePenjualan.PakaiSO
		txtKurs.Value = 1
		txtUraian.EditValue = salesSetting.UraianIV
		txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))

		instance.Tanggal = txtTanggal.DateTime
		instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
		instance.TipeInvoice = Persistent.eTipeInvoicePenjualan.PakaiSO
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.IV)
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
	End Sub
	Private Sub DisableControl()
		txtKontak.Enabled = False
		txtKontakPerson.Enabled = False
		txtTanggal.Enabled = False
		txtRegional.Enabled = False
		txtNoTransaksi.Enabled = False
		txtAlamat.Enabled = False

		txtTipeInvoice.Enabled = False
		txtTermin.Enabled = False
		txtJatuhTempo.Enabled = False
		txtKaryawan.Enabled = False
		txtNoSO.Enabled = False
		txtUang.Enabled = False
		txtKurs.Enabled = False
		txtUraian.Enabled = False

		txtCatatan.Enabled = False

		xGridView.OptionsBehavior.Editable = False
		xGridDPView.OptionsBehavior.Editable = False
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
	Private Sub UpdateKurs()
		If editAssign Then Return
		If txtUang.EditValue Is Nothing Then Return
		If CType(txtUang.EditValue, MataUang).Id = setting.MultiMataUangDefault Then
			txtKurs.Value = 1
			txtKurs.Properties.ReadOnly = True
		Else
			txtKurs.Value = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, MataUang), txtTanggal.DateTime)
			txtKurs.Properties.ReadOnly = False
		End If
	End Sub
	Private Sub UpdateSOSource()
		If Not editAssign Then txtNoSO.EditValue = Nothing
		If Not txtKontak.EditValue Is Nothing Then
			Dim plg = CType(txtKontak.EditValue, Kontak)
			txtNoSO.Properties.DataSource = openSO.Where(Function(w) w.Pelanggan Is plg).ToList
		End If
	End Sub
	Private Sub HitungTotal()
		If editAssign Then Return
		Dim nilaiDP As Double = 0
		xGridDP.DataSource = Nothing
		If Not txtNoSO.EditValue Is Nothing Then
			Dim xOrder = CType(txtNoSO.EditValue, Travel_Order)
			Dim daftarDP = xOrder.DaftarDownPayment
			xGridDP.DataSource = daftarDP

			Dim mataUangInvoice = CType(txtUang.EditValue, MataUang)
			Dim kurs = txtKurs.Value
			Dim dpSesuai = daftarDP.Where(Function(w) w.Uang Is mataUangInvoice).Sum(Function(s) s.Nominal)
			Dim dpLain = daftarDP.Where(Function(w) Not w.Uang Is mataUangInvoice).Sum(Function(s) s.NominalKurs)
			nilaiDP = dpSesuai + (dpLain / kurs)
		End If

		txtSubTotal.EditValue = instance.SubTotal
		txtDP.EditValue = nilaiDP
		instance.NominalDP = nilaiDP
		txtTotal.EditValue = instance.Total
	End Sub
	Private Sub SetTipeInvoice(xTipe As Persistent.eTipeInvoicePenjualan)
		instance.TipeInvoice = xTipe
		If xTipe = Persistent.eTipeInvoicePenjualan.PakaiSO Then
			txtNoSO.Enabled = True

			DeleteDetail()
			xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
			xGridView.OptionsBehavior.ReadOnly = True
			colKodeBarang.OptionsColumn.ReadOnly = True
			colQty.OptionsColumn.ReadOnly = True
      colQty.OptionsColumn.ReadOnly = True 'Not salesSetting.OpenPriceInvoice
      colHarga.OptionsColumn.ReadOnly = False
      'colFOC.OptionsColumn.ReadOnly = True
    ElseIf xTipe = Persistent.eTipeInvoicePenjualan.TanpaSO Then
			txtNoSO.Enabled = False

			xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
			xGridView.OptionsBehavior.ReadOnly = False
			colKodeBarang.OptionsColumn.ReadOnly = False
			colQty.OptionsColumn.ReadOnly = False
			colQty.OptionsColumn.ReadOnly = Not salesSetting.OpenPriceInvoice
      'colFOC.OptionsColumn.ReadOnly = True

      If Not editAssign Then txtNoSO.EditValue = Nothing
		End If
	End Sub
	Private Sub DeleteDetail()
		For i = instance.Detail.Count - 1 To 0 Step -1
			detailToDelete.Add(instance.Detail(i))
			instance.Detail(i).Delete()
		Next
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

		UpdateKurs()
		txtJatuhTempo.Properties.MinValue = txtTanggal.DateTime
	End Sub
	Private Sub txtJatuhTempo_EditValueChanged(sender As Object, e As EventArgs) Handles txtJatuhTempo.EditValueChanged
		txtTanggal.Properties.MaxValue = txtJatuhTempo.DateTime
	End Sub
	Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
		ChangeCode()
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub

	Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			lblKontakNama.Text = CType(e.NewValue, Kontak).Nama

			txtKontakPerson.Properties.DataSource = New XPCollection(Of KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
			txtAlamat.Properties.DataSource = New XPCollection(Of KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
		End If
	End Sub
	Private Sub txtKontak_EditValueChanged(sender As Object, e As EventArgs) Handles txtKontak.EditValueChanged
		UpdateSOSource()
	End Sub
	Private Sub txtAlamat_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAlamat.EditValueChanging
		If Not e.NewValue Is Nothing Then
			txtAlamatText.Text = CType(e.NewValue, KontakAlamat).Alamat
		End If
	End Sub

	Private Sub txtTipeInvoice_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTipeInvoice.EditValueChanging
		If Not e.NewValue Is Nothing And editAssign = False Then
			SetTipeInvoice(CType(e.NewValue, Persistent.eTipeInvoicePenjualan))
		End If
	End Sub
	Private Sub txtNoSO_EditValueChanged(sender As Object, e As EventArgs) Handles txtNoSO.EditValueChanged
		If editAssign Then Return
		If txtNoSO.EditValue Is Nothing Then Return

		Dim xDataSO As Travel_Order = CType(txtNoSO.EditValue, Travel_Order)
		Dim data As Travel_InvoiceDetail

		txtKontakPerson.EditValue = xDataSO.KontakPerson
		txtAlamat.EditValue = xDataSO.KontakAlamat
		If Not xDataSO.KontakAlamat Is Nothing Then txtAlamatText.EditValue = xDataSO.KontakAlamat.Alamat
		txtUang.EditValue = xDataSO.Uang
		txtTermin.EditValue = xDataSO.Termin
		txtKaryawan.EditValue = xDataSO.BagPenjualan

		DeleteDetail()
		For Each xItem In xDataSO.Detail
			data = New Travel_InvoiceDetail(session)
			data.Main = instance
			data.Barang = xItem.Barang
			data.Qty = xItem.Qty
			data.Satuan = xItem.Satuan
			data.Harga = xItem.Harga
			data.Discount = xItem.Discount
			data.Catatan = xItem.Catatan
			data.Divisi = xItem.Divisi
			data.Proyek = xItem.Proyek

			'hitung foc nya
			If salesSetting.DiskonCustomer > 0 Then
				Dim pDisc As Integer = data.Qty / salesSetting.DiskonCustomer
				data.FOC = pDisc * data.Harga
			End If

			instance.Detail.Add(data)
		Next

		UpdateKurs()
		HitungTotal()
	End Sub
	Private Sub txtTermin_EditValueChanged(sender As Object, e As EventArgs) Handles txtTermin.EditValueChanged
		If editAssign Then Return
		If txtTermin.EditValue Is Nothing Then Return
		txtJatuhTempo.EditValue = DateAdd(DateInterval.Day, CType(txtTermin.EditValue, NuSoft005.Persistent.Termin).Tempo, txtTanggal.DateTime)
	End Sub
	Private Sub txtUang_EditValueChanged(sender As Object, e As EventArgs) Handles txtUang.EditValueChanged
		HitungTotal()
	End Sub
	Private Sub txtKurs_EditValueChanged(sender As Object, e As EventArgs) Handles txtKurs.EditValueChanged
		HitungTotal()
	End Sub

	Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
		If Not e.Value Is Nothing Then
			Dim row As Travel_InvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Travel_InvoiceDetail)
			If e.Column Is colKodeBarang Then
				If Not row Is Nothing Then
					Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
					Dim xHarga As Double = 0
					row.Satuan = xbarang.Satuan
					Select Case CType(txtKontak.EditValue, Kontak).LevelPenjualan
						Case eLevelPenjualan.Level1 : xHarga = xbarang.HargaJual1
						Case eLevelPenjualan.Level2 : xHarga = xbarang.HargaJual2
						Case eLevelPenjualan.Level3 : xHarga = xbarang.HargaJual3
						Case eLevelPenjualan.Level4 : xHarga = xbarang.HargaJual4
						Case eLevelPenjualan.Level5 : xHarga = xbarang.HargaJual5
					End Select
					row.Harga = xHarga
				End If
			End If
			'If (e.Column Is colDiscountPersen) Or (e.Column Is colQty) Or (e.Column Is colHarga) Then
			'  If Not row Is Nothing Then
			'    row.Discount = (row.DiscountPersen / 100) * (row.Qty * row.Harga)
			'  End If
			'End If
			HitungTotal()
		End If
	End Sub
	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
		Dim row As Travel_InvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Travel_InvoiceDetail)
		row.Barang = Nothing
		row.Qty = 1
		row.Main = instance
		row.FOC = 0
		row.Catatan = ""
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Travel_InvoiceDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Travel_InvoiceDetail)
			xGridView.DeleteRow(xGridView.FocusedRowHandle)
			detailToDelete.Add(Id)
		End If
	End Sub
End Class