Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors

Friend Class UI_FusohInvoicePenjualanDialog
	Private instance As Persistent.Fusoh_InvoicePenjualan
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	Private detailToDelete As New List(Of Persistent.Fusoh_InvoicePenjualanDetail)
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private salesSetting As Logic.SalesSetting
	Private xIdKontak As String
	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
		Persistent.Fusoh_InvoicePenjualan.AutoSaveOnEndEdit = False
		Persistent.Fusoh_InvoicePenjualanDetail.AutoSaveOnEndEdit = False
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		salesSetting = New Logic.SalesSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		LoadLayout()
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVTransaksi.xml"))
		End If
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml"))
		End If
		colHarga.OptionsColumn.AllowEdit = salesSetting.OpenPriceInvoice
		colHarga.OptionsColumn.ReadOnly = Not salesSetting.OpenPriceInvoice
		txtPajak.Properties.ReadOnly = Not salesSetting.OpenTaxIV
		colPPN.OptionsColumn.ReadOnly = Not salesSetting.OpenTaxIV
		'colPPH.OptionsColumn.ReadOnly = Not salesSetting.OpenTaxIV
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Fusoh_InvoicePenjualan(session)
			'instance.Gl = New Persistent.GlMain(Session) With {.Number = New Logic.NumberClass(Session) With {.FormatNomor = setting.FormatNomor}}

			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.Fusoh_InvoicePenjualan)(Convert.ToInt64(IdToEdit))
			'load nomor SO kembali
			'txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", instance.Pelanggan, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress, NuSoft001.Persistent.StatusTransaksiEnum.Finish})))

			txtNoTransaksi.Text = instance.Kode
			txtTanggal.EditValue = instance.Tanggal
			txtKontak.EditValue = instance.Pelanggan
			txtRegional.EditValue = instance.Regional
			txtKontakPerson.EditValue = instance.KontakPerson
			txtAlamat.EditValue = instance.KontakAlamat
			If Not instance.KontakAlamat Is Nothing Then
				txtAlamatText.EditValue = instance.KontakAlamat.Alamat
			End If
			txtPajak.EditValue = instance.TipePajak
			txtTglBerlaku.DateTime = instance.TanggalBerlaku
			txtUang.EditValue = instance.Uang
			txtKurs.Text = instance.Kurs
			txtPajak.EditValue = instance.TipePajak
			txtTermin.EditValue = instance.Termin
			txtUraian.Text = instance.Uraian
			txtCatatan.Text = instance.Catatan

			txtTermin.EditValue = instance.Termin
			txtTglBerlaku.EditValue = instance.TanggalBerlaku
			txtJenisPajak.EditValue = instance.JenisPajak
			txtNoPPN.Text = instance.NoSNPPN
			txtNoPPH.Text = instance.NoSNPPh
			txtNoSO.EditValue = instance.NoOrder
			txtStatus.EditValue = instance.StatusTransaksi
			txtPenandatangan.EditValue = instance.Karyawan

			xGrid.DataSource = instance.Detail
			editAssign = False
		End If

		'instance.Detail(0).SuratJalanDetail.InDiameter

		xGridView.OptionsBehavior.Editable = True
		xGridView.OptionsBehavior.ReadOnly = False
		SetNomor()
		HitungTotal()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Invoice Penjualan [IV] : Tambah Data"
		Else
			Me.Text = "Invoice Penjualan [IV] : Edit Data " & instance.Kode
			If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
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
	Overrides Sub SimpanData()
		If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
			Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
			Exit Sub
		End If
    ''======= Cek Periode
    If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, txtTanggal.DateTime) Then
      Throw New Utils.Exception("Periode sudah ditutup." & vbCrLf & "Hubungi accounting untuk membuka periode", -4, "", "Simpan Transaksi")
      Exit Sub
    End If
    ''======= Cek Sebelum Awal Periode
    If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(session, txtTanggal.DateTime) Then
      Throw New Utils.Exception("Tanggal transaksi sebelum awal periode" & vbCrLf & "Hubungi accounting untuk membuka periode", -4, "", "Simpan Transaksi")
      Exit Sub
    End If

    For i = detailToDelete.Count - 1 To 0 Step -1
			detailToDelete(i).Delete()
		Next

		Try
			If Tipe = InputType.Tambah Then
				instance.Revisi = 0
			Else
				If MsgBox("Apakah anda ingin menambah revisi?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
					instance.Revisi = instance.Revisi + 1
				End If
			End If

			'======= Simpan Main
			If Tipe = InputType.Tambah Then
				txtNoTransaksi.EditValue = instance.Number.GetNewNumber.Kode
			End If

			If Not txtKontak.EditValue Is Nothing Then
				instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
			Else
				instance.Pelanggan = Nothing
			End If
			If Not txtNoSO.EditValue Is Nothing Then
				instance.NoOrder = CType(txtNoSO.EditValue, Persistent.Fusoh_OrderPenjualan)
			Else
				instance.NoOrder = Nothing
			End If
			instance.Tanggal = txtTanggal.DateTime
			instance.Kode = txtNoTransaksi.Text
			instance.KontakPerson = txtKontakPerson.EditValue
			instance.KontakAlamat = CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat)
			instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			instance.TipePajak = CType(txtPajak.EditValue, NuSoft005.Persistent.eTipePajak)
			instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
			instance.Kurs = CType(txtKurs.Text, Double)
			instance.Termin = CType(txtTermin.EditValue, NuSoft005.Persistent.Termin)
			instance.TanggalBerlaku = txtTglBerlaku.DateTime
			instance.JenisPajak = CType(txtJenisPajak.EditValue, NuSoft005.Persistent.eJenisPajak)
			instance.NoSNPPN = txtNoPPN.Text
			instance.NoSNPPh = txtNoPPH.Text
			instance.Uraian = txtUraian.Text
			instance.Catatan = txtCatatan.Text
			instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
			instance.Karyawan = CType(txtPenandatangan.EditValue, NuSoft001.Persistent.Kontak)
			''buatkan jurnalnya
			'instance.Gl.Sumber = instance.Sumber
			'instance.Gl.Tanggal = txtTanggal.EditValue
			'instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			'instance.Gl.Kode = instance.Kode
			'instance.Gl.ModuleId = NPO.Modules.ModuleId.Purchase
			'instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
			'instance.Gl.Kurs = txtKurs.EditValue
			'instance.Gl.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
			'instance.Gl.KontakNama = txtKontak.Text
			'instance.Gl.Uraian = txtUraian.Text

			'Dim xCoaPiutang As NuSoft001.Persistent.Coa, pRegional As Persistent.xRegional
			''Piutang Dagang  (D) 
			'pRegional = Session.GetObjectByKey(Of Persistent.xRegional)(CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id)
			'If salesSetting.SetingARRegional = False Then
			'	xCoaPiutang = instance.Uang.PiutangDagang
			'Else
			'	xCoaPiutang = Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(pRegional.CoaAR))
			'End If
			'Dim i As Byte = 1
			'SimpanGL(xCoaPiutang, i, instance.Total * instance.Kurs, 0, instance.Total, 0)
			'i = i + 1


			'If instance.PPH > 0 Then      'PPH (D)
			'	SimpanGL(Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPH)), i, instance.PPH * instance.Kurs, 0, 0, 0)
			'	i = i + 1
			'End If
			'If instance.NilaiDP > 0 Then 'DP (D)
			'	SimpanGL(CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).UMPembelian, i, instance.NilaiDP * instance.Kurs, 0, instance.NilaiDP, 0)
			'	i = i + 1
			'	'jika ada selisih kurs dari DP
			'End If
			'If instance.PPN > 0 Then      'PPN (K)
			'	SimpanGL(Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPN)), i, 0, instance.PPN * instance.Kurs, 0, 0)
			'	i = i + 1
			'End If

			''Pendapatan (K) -> ambilkan dari seting coa master
			'Dim b = From z In instance.Detail Group z By z.Barang.CoaIncome Into Group Select CoaIncome, SubTotal = Group.Sum(Function(x) x.DPP * x.Main.Kurs)
			'For Each x In b
			'	SimpanGL(x.CoaIncome, i, 0, x.SubTotal, 0, 0)
			'	i = i + 1
			'Next

			'HPPnya pasang disini,



			'If Not instance.NoOrder Is Nothing Then
			'  Dim c = From z In instance.Detail Group By z.SuratJalanDetail Into Group Select SuratJalanDetail, Qty = Group.Sum(Function(x) x.Qty)
			'  For Each x In c
			'    x.SuratJalanDetail.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
			'  Next
			'End If


			'coba tampilkan dulu.
			'Dim xMessage As String = ""
			'MsgBox("Jumlahnya adalah :" & instance.Gl.Detail.Count - 1)
			'For i = 0 To instance.Gl.Detail.Count - 1
			'  xMessage += i & ":" & instance.Gl.Detail(i).Akun.Nama.ToString & " " & instance.Gl.Detail(i).Debit.ToString & "~" & instance.Gl.Detail(i).Kredit.ToString & vbCrLf
			'Next
			'MsgBox(xMessage)

			'cari nomor SO nya

			Dim c = From z In instance.Detail Group By z.SuratJalanDetail Into Group Select SuratJalanDetail, Qty = Group.Sum(Function(x) x.Qty)
			For Each x In c
				x.SuratJalanDetail.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
			Next

			xIdKontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).Id

			instance.Save()
			'======= Simpan instance
			session.CommitChanges()
			'Fusoh_Logic.InvoicePenjualan.UpdateStatusSuratJalan(session, instance, True)
			Dim b = From z In instance.Detail Group z By z.SuratJalanDetail.Main Into Group Select Main, Qty = Group.Sum(Function(x) x.Qty)
			For Each x In b
				Fusoh_Logic.InvoicePenjualan.UpdateStatusSuratJalan(session, x.Main, True)
			Next

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

    '======= Simple log
    Try
      If Tipe = InputType.Tambah Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Invoice Penjualan [IV] -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Invoice Penjualan [IV] -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try

    '======= Konfirmasi Cetak Laporan
    Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.IV)
		frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
		If xIdKontak = "580" Then
			reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherInvoice2)
		Else
			reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherInvoice)
		End If
		message = String.Format(message, "Invoice Penjualan")

		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -3 : txtUraian.Focus()
			Case -4 : txtTanggal.Focus()
			Case -5, -7 : xGrid.Focus()
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
		'txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
		'txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
		txtNoTransaksi.Text = nomor.Kode
	End Sub
	Private Sub BindingDataSource()
		If salesSetting.FilterKontak = True Then
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
		Else
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
		End If
		txtPenandatangan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))

		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtTermin.Properties.DataSource = New XPCollection(Of NuSoft005.Persistent.Termin)(session)
		txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eTipePajak))
		txtJenisPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eJenisPajak))
		txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
		txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eTipeInvoicePembelian))

		colPPHRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
		colPPNRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
	End Sub
	Private Sub SetFormat()
		colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQty.DisplayFormat.FormatString = setting.NumericFormatToString
		colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHarga.DisplayFormat.FormatString = setting.NumericFormatToString
		colDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colDisc.DisplayFormat.FormatString = setting.NumericFormatToString
		colDiscP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colDiscP.DisplayFormat.FormatString = setting.NumericFormatToString
		colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colSubTotal.DisplayFormat.FormatString = setting.NumericFormatToString
		colSubTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
		colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colTotal.DisplayFormat.FormatString = setting.NumericFormatToString
		colPPH.SummaryItem.DisplayFormat = setting.NumericFormatString
		colPPN.SummaryItem.DisplayFormat = setting.NumericFormatString
		colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
		txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtSubTotal.Properties.Mask.EditMask = setting.NumericFormatToString
		txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtPPN.Properties.Mask.EditMask = setting.NumericFormatToString
		txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtPPH.Properties.Mask.EditMask = setting.NumericFormatToString
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
		txtPajak.EditValue = NuSoft005.Persistent.eTipePajak.TanpaPajak
		txtKurs.Text = 1
		txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		txtUraian.EditValue = salesSetting.UraianIV
		txtJenisPajak.EditValue = NuSoft005.Persistent.eJenisPajak.Penggantian
		txtTipe.EditValue = NuSoft005.Persistent.eTipeInvoicePembelian.PakaiPO
		txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
	End Sub
	Private Sub LoadLayout()
		If salesSetting.MultiSO = True Then
			lyNoOrder.Visibility = LayoutVisibility.Never
			btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
		Else
			lyNoOrder.Visibility = LayoutVisibility.Always
			btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
		End If

		lyNoOrder.Visibility = LayoutVisibility.Never
		btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
		btnAmbilDataSJ.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.IV)
		'instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "SI[Y2]-[M0][X2]"}
	End Sub
	Private Sub DisableControl()
		txtNoTransaksi.Enabled = False
		txtTanggal.Enabled = False
		txtRegional.Enabled = False
		txtKontakPerson.Enabled = False
		txtAlamat.Enabled = False
		txtAlamatText.Enabled = False
    'txtPajak.Enabled = False
    txtTglBerlaku.Enabled = False
		txtUang.Enabled = False
		txtKurs.Enabled = False
		txtTermin.Enabled = False
		txtUraian.Enabled = False
		txtCatatan.Enabled = False
		txtJenisPajak.Enabled = False
		txtNoPPN.Enabled = False
		txtNoPPH.Enabled = False
		txtNoSO.Enabled = False
		txtStatus.Enabled = False
		txtPenandatangan.Enabled = False
		txtKontakPerson.Enabled = False
		txtNoInvoiceVendor.Enabled = False
		xGridView.OptionsBehavior.Editable = False
		colPPH.OptionsColumn.AllowEdit = False
		colPPN.OptionsColumn.AllowEdit = False
		btnAmbilDataSJ.Enabled = False
		AllowSave = False
		txtKontak.Enabled = False
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

	Private Function GetViewInfo(navBar As NavBarControl) As NavBarViewInfo
		Dim fi As FieldInfo = GetType(NavBarControl).GetField("viewInfo", BindingFlags.NonPublic Or BindingFlags.Instance)
		Return CType(fi.GetValue(navBar), NavBarViewInfo)
	End Function
	Private Function GetGroupPainter(navBar As NavBarControl) As ExplorerBarNavGroupPainter
		Dim fi As FieldInfo = GetType(NavBarControl).GetField("groupPainter", BindingFlags.NonPublic Or BindingFlags.Instance)
		Return CType(fi.GetValue(navBar), ExplorerBarNavGroupPainter)
	End Function
	Private Sub navCatatan_CalcGroupClientHeight(sender As Object, e As NavBarCalcGroupClientHeightEventArgs) Handles navCatatan.CalcGroupClientHeight
		Dim vi As NavBarViewInfo = GetViewInfo(NavBarControl1)
		Dim gi As NavGroupInfoArgs = CType(vi.Groups((vi.Groups.Count - 1)), NavGroupInfoArgs)
		Dim groupPainter As ExplorerBarNavGroupPainter = GetGroupPainter(NavBarControl1)
		'groupPainter.CalcFooterBounds(gi, gi.Bounds)
		Dim delta As Integer = gi.Bounds.Top - vi.Client.Top
		Dim ch As Integer = vi.Client.Height - delta - gi.Bounds.Height - gi.FooterBounds.Height
		e.Height = ch
	End Sub

	Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
			'isikan data detailnya
			txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
			txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
			txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

			txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
			txtAlamat.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
			Dim xpTransaksi As New XPCollection(Of Persistent.Fusoh_InvoicePenjualan)(session, New BinaryOperator("Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
			xGHistory.DataSource = xpTransaksi

			If lyNoOrder.Visibility = LayoutVisibility.Never Then Return
			If instance.NoOrder Is Nothing Then
				txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.FD, BinaryOperatorType.Equal), New BinaryOperator("Main.Pelanggan", e.NewValue, BinaryOperatorType.Equal), New BinaryOperator("Main.StatusTransaksi", NuSoft001.Persistent.StatusTransaksiEnum.Posting))).GroupBy(Function(m) m.SODetail.Main).Select(Function(m) m.Key)
			Else
				txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.FD, BinaryOperatorType.Equal), New BinaryOperator("Main.Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("Main.StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})), New BinaryOperator("SODetail.Main.Id", instance.NoOrder.Id, BinaryOperatorType.Equal))).GroupBy(Function(m) m.SODetail.Main).Select(Function(m) m.Key)
			End If
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
		If Not txtUang.EditValue Is Nothing Then
			Dim setting As New NuSoft001.Logic.FinaSetting(session)
			If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
				txtKurs.Text = 1
			Else
				txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
			End If
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
	Private Sub txtNoSO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoSO.EditValueChanging
		If Not e.NewValue Is Nothing And editAssign = False Then
			Dim setting As New NuSoft001.Logic.FinaSetting(session)
			Dim xDataSO As Persistent.Fusoh_OrderPenjualan = CType(e.NewValue, Persistent.Fusoh_OrderPenjualan)
			Dim data As Persistent.Fusoh_InvoicePenjualanDetail
			txtKontakPerson.EditValue = xDataSO.KontakPerson
			txtPajak.EditValue = xDataSO.TipePajak
			txtUang.EditValue = xDataSO.Uang
			txtTermin.EditValue = xDataSO.Termin
			instance.TipePajak = xDataSO.TipePajak
			If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
				txtKurs.Text = 1
				txtKurs.Properties.ReadOnly = True
			Else
				txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
				txtKurs.Properties.ReadOnly = False
			End If
			If Not txtTermin.EditValue Is Nothing Then
				txtTglBerlaku.EditValue = DateAdd(DateInterval.Day, CType(txtTermin.EditValue, NuSoft005.Persistent.Termin).Tempo, txtTanggal.DateTime)
			End If
			'txtAlamat.EditValue = xDataSO.KontakAlamat
			'If Not xDataSO.KontakAlamat Is Nothing Then
			'	txtAlamatText.EditValue = xDataSO.KontakAlamat.Alamat
			'End If


			For i = instance.Detail.Count - 1 To 0 Step -1
				instance.Detail(i).Delete()
			Next
			'Dim xDataSJ As Persistent.PengirimanBarang = session.FindObject(Of Persistent.PengirimanBarang)(New GroupOperator(GroupOperatorType.And, New BinaryOperator("NoOrder", xDataSO, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
			Dim xDataSJ As New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.FD, BinaryOperatorType.Equal), New BinaryOperator("SODetail.Main", xDataSO, BinaryOperatorType.Equal), New InOperator("Main.StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
			If Not xDataSJ Is Nothing Then
				For i = 0 To xDataSJ.Count - 1
					data = New Persistent.Fusoh_InvoicePenjualanDetail(session)
					data.Barang = xDataSJ(i).Barang
					data.Qty = xDataSJ(i).Qty
					data.Satuan = xDataSJ(i).Satuan
					data.Harga = xDataSJ(i).SODetail.Harga
					data.PPN = xDataSJ(i).SODetail.PPN
					data.PPNp = xDataSJ(i).SODetail.PPNp
					data.PPH = xDataSJ(i).SODetail.PPH
					data.PPHp = xDataSJ(i).SODetail.PPHp
					data.Catatan = xDataSJ(i).Catatan
					data.SuratJalanDetail = xDataSJ(i)
					instance.Detail.Add(data)
				Next
			End If

			HitungTotal()
		End If
	End Sub
	Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			instance.TipePajak = CType(e.NewValue, NuSoft005.Persistent.eTipePajak)
			xGrid.RefreshDataSource()
			HitungTotal()
		End If
	End Sub
	Private Sub HitungTotal()
		txtSubTotal.EditValue = instance.SubTotal
		txtPPN.EditValue = instance.PPN
		txtPPH.EditValue = instance.PPH
		txtTotal.EditValue = instance.Total
	End Sub
	'Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "")
	'	Dim item As Persistent.GlMainDetail
	'	If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
	'		item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
	'	Else
	'		item = New Persistent.GlMainDetail(Session)

	'		item.Akun = Akun
	'		item.MataUang = item.Akun.MataUang
	'		item.Main = instance.Gl
	'		item.Urutan = Urutan
	'		item.Debit = Debit
	'		item.Kredit = Kredit
	'		item.Keterangan = Catatan
	'		If Akun.MataUang.Id = setting.MultiMataUangDefault Then
	'			item.DebitValas = 0
	'			item.KreditValas = 0
	'			item.Kurs = 1
	'		Else
	'			item.DebitValas = DebitValas
	'			item.KreditValas = KreditValas
	'			item.Kurs = txtKurs.EditValue
	'		End If
	'		instance.Gl.Detail.Add(item)
	'	End If
	'End Sub
	Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml"))
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub
	Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
		If Not e.Value Is Nothing Then
			Dim row As Persistent.Fusoh_InvoicePenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_InvoicePenjualanDetail)
			'row.Discount = (row.DiscountPersen / 100) * (row.Qty * row.Harga)
			If e.Column Is colPPN Then
				row.PPNp = row.PPN.NilaiPajak
			ElseIf e.Column Is colPPH Then
				row.PPHp = row.PPH.NilaiPajak
			End If
			HitungTotal()
		End If
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Persistent.Fusoh_InvoicePenjualanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_InvoicePenjualanDetail)
			xGridView.DeleteRow(xGridView.FocusedRowHandle)
			detailToDelete.Add(Id)
		End If
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
	Private Sub txtTermin_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTermin.EditValueChanging
		If Not e.NewValue Is Nothing Then
			txtTglBerlaku.DateTime = DateAdd(DateInterval.Day, CType(e.NewValue, NuSoft005.Persistent.Termin).Tempo, txtTanggal.DateTime)
		End If
	End Sub

  Private Sub btnAmbilDataSJ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilDataSJ.ItemClick
    If txtKontak.EditValue Is Nothing Then
      XtraMessageBox.Show("Pilih customer terlebih dahulu.", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    Dim frm As New UI_FusohInvoicePenjualanDialogSJ
    frm.Customer = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
    If Tipe = InputType.Edit Then
      frm.EditedInvoice = instance
    End If
    frm.session = session
    If (frm.ShowDialog = DialogResult.OK) Then
      Dim xDataSJ As List(Of Persistent.Fusoh_SuratJalanDetail) = frm.Result

      'load data SJ
      For i = 0 To xDataSJ.Count - 1
        Dim Data = New Persistent.Fusoh_InvoicePenjualanDetail(session)
        Data.Barang = xDataSJ(i).Barang
        Data.Qty = xDataSJ(i).Qty
        Data.Satuan = xDataSJ(i).Satuan
        Data.Harga = xDataSJ(i).SODetail.Harga
        Data.PPN = xDataSJ(i).SODetail.PPN
        Data.PPNp = xDataSJ(i).SODetail.PPNp
        Data.PPH = xDataSJ(i).SODetail.PPH
        Data.PPHp = xDataSJ(i).SODetail.PPHp
        Data.Catatan = xDataSJ(i).Catatan
        Data.SuratJalanDetail = xDataSJ(i)
        instance.Detail.Add(Data)
      Next

      HitungTotal()
    End If
  End Sub
End Class