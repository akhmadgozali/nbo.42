Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel

Friend Class UI_FusohCostSheetDialog
	Private instance As Persistent.Fusoh_PenerimaanInvoice
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of SettingRegional)
	Private editAssign As Boolean = False
	Private detailToDelete As New List(Of Persistent.Fusoh_PenerimaanInvoiceDetail)
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private settingpurchase As Logic.PurchaseSetting
	Private sumber As Persistent.SumberDataCollection
	Private listInvoiceSdhCostSheet As List(Of Persistent.Fusoh_PenerimaanInvoice)

  Private Const kodeShipmentCost As String = "Shipment Cost"

  Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
		Persistent.PenerimaanInvoice.AutoSaveOnEndEdit = False
		Persistent.PenerimaanInvoiceDetail.AutoSaveOnEndEdit = False
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		settingpurchase = New Logic.PurchaseSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CSTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CSTransaksi.xml"))
		End If
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CSTransaksiGrid.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CSTransaksiGrid.xml"))
		End If
		listInvoiceSdhCostSheet = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) Not w.IndukInvoice Is Nothing).GroupBy(Function(g) g.IndukInvoice).Select(Function(s) s.Key).ToList
		Dim criteriaOperator As New List(Of CriteriaOperator)
		Dim listSumber = New List(Of Persistent.SumberDataJenis)
		listSumber.Add(Persistent.SumberDataJenis.RI)
		listSumber.Add(Persistent.SumberDataJenis.IMV)
		criteriaOperator.Add(New InOperator("Sumber", listSumber))
		criteriaOperator.Add(New NotOperator(New NullOperator("NoExim")))
    'criteriaOperator.Add(New BinaryOperator("NoExim.PO.DariDomestik", False))
    'criteriaOperator.Add(New InOperator("StatusTransaksi", New StatusTransaksiEnum() {StatusTransaksiEnum.InProgress, StatusTransaksiEnum.Posting}))
    criteriaOperator.Add(New NotOperator(New InOperator("This", listInvoiceSdhCostSheet)))
		Dim ops = New XPCollection(Of Persistent.Fusoh_PenerimaanInvoice)(session, New GroupOperator(GroupOperatorType.And, criteriaOperator))
		ops.DisplayableProperties = "This;Kode;Tanggal;NoReffVendor;Vendor.Nama"
		txtNoInvoice.Properties.DataSource = ops
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Fusoh_PenerimaanInvoice(session)
			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.Fusoh_PenerimaanInvoice)(Convert.ToInt64(IdToEdit))
      'txtNoInvoice.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) (w.Sumber Is sumber.GetObject(Persistent.SumberDataJenis.RI) AndAlso Not w.NoExim Is Nothing AndAlso Not w.NoExim.PO.DariDomestik AndAlso (w.StatusTransaksi = StatusTransaksiEnum.InProgress OrElse w.StatusTransaksi = StatusTransaksiEnum.Posting)) OrElse w Is instance.IndukInvoice).ToList
      'sql benar sebelum dibuang harus impor
      'txtNoInvoice.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) _
      '(w.Sumber Is sumber.GetObject(Persistent.SumberDataJenis.RI) AndAlso
      ' Not w.NoExim Is Nothing AndAlso
      ' Not w.NoExim.PO.DariDomestik AndAlso
      ' Not listInvoiceSdhCostSheet.Contains(w)) _
      ' OrElse w Is instance.IndukInvoice).ToList
      txtNoInvoice.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) _
          (w.Sumber Is sumber.GetObject(Persistent.SumberDataJenis.RI) AndAlso
           Not w.NoExim Is Nothing AndAlso
           Not listInvoiceSdhCostSheet.Contains(w)) _
           OrElse w Is instance.IndukInvoice).ToList


      txtKontak.EditValue = instance.Vendor
      txtKontakPerson.EditValue = instance.KontakPerson
			txtTanggal.EditValue = instance.Tanggal
			txtRegional.EditValue = instance.Regional
			txtNoTransaksi.Text = instance.Kode
			txtStatus.EditValue = instance.StatusTransaksi

			txtNoInvoice.EditValue = instance.IndukInvoice
			txtNoInvoiceVendor.EditValue = instance.NoReffVendor
			txtKaryawan.EditValue = instance.Karyawan

			txtTglBerlaku.DateTime = instance.TanggalBerlaku
			txtTermin.EditValue = instance.Termin
			txtUang.EditValue = instance.Uang
			txtKurs.Text = instance.Kurs
			txtTipeTransaksi.EditValue = instance.TipeTransaksi
			txtPajak.EditValue = instance.TipePajak
			txtUraian.Text = instance.Catatan

			txtJenisPajak.EditValue = instance.JenisPajak
			txtNoPPN.Text = instance.NoSNPPN
			txtNoPPH.Text = instance.NoSNPPh

			xGrid.DataSource = instance.Detail
			editAssign = False
			HitungTotal()
		End If
		SetNomor()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Cost Sheet [CS] : Tambah Data"
		Else
			Me.Text = "Cost Sheet [CS] : Edit Data " & instance.Kode
      'If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
      '	DisableControl()
      'End If
      'If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
      '	DisableControl()
      'End If
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
		If txtNoInvoice.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan nomor invoice.", -5, "", "Simpan Transaksi")
			Exit Sub
		End If

		For i = detailToDelete.Count - 1 To 0 Step -1
			detailToDelete(i).Delete()
		Next

		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Simpan data invoice ...")

				'======= Simpan Main
				If Not txtKontak.EditValue Is Nothing Then
					instance.Vendor = CType(txtKontak.EditValue, Kontak)
				Else
					instance.Vendor = Nothing
				End If
				instance.KontakPerson = txtKontakPerson.EditValue
				instance.Tanggal = txtTanggal.DateTime
				instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
				instance.Kode = txtNoTransaksi.Text
				instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)

				instance.IndukInvoice = txtNoInvoice.EditValue
				instance.NoReffVendor = txtNoInvoiceVendor.Text
				instance.Karyawan = CType(txtKaryawan.EditValue, Kontak)

				instance.TanggalBerlaku = txtTglBerlaku.DateTime
				instance.Termin = CType(txtTermin.EditValue, Persistent.Termin)
				instance.Uang = CType(txtUang.EditValue, MataUang)
				instance.Kurs = CType(txtKurs.Text, Double)
				instance.TipeTransaksi = Persistent.eTipeInvoicePembelian.TanpaPO
				instance.TipePajak = CType(txtPajak.EditValue, Persistent.eTipePajak)
				instance.Catatan = txtUraian.Text

				instance.JenisPajak = CType(txtJenisPajak.EditValue, Persistent.eJenisPajak)
				instance.NoSNPPN = txtNoPPN.Text
				instance.NoSNPPh = txtNoPPH.Text
				instance.Save()

				'======= start 19-04-24 ===== set harga beli
				'== 1. Cari Penerimaan
				Dim daftarGr = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim.PO Is instance.IndukInvoice.NoOrder).ToList
				For Each item In daftarGr
					For Each det In item.Detail
						'== 2. Cari Detail Invoice
						Dim detInvoice = instance.IndukInvoice.Detail.ToList.Find(Function(f) f.PODetail Is det.EximDetail.PODetail)
						If Not detInvoice Is Nothing Then
							'Dim hargaBeli = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
							'Dim totalCostSheet = detInvoice.Main.TotalCost
							'Dim totalWeight = detInvoice.Main.NoExim.TotalWeight
							'Dim biayaCost = (totalCostSheet / totalWeight) * detInvoice.EximDetail.Weight

							'det.Harga = hargaBeli + (biayaCost / detInvoice.Qty)
							'If det.Barang.Kode = "RT54-082-06" Then
							'  MsgBox((detInvoice.TotalPembelianIDR.ToString("n2")) & "/" & det.Qty.ToString("n2"))
							'End If
							det.Harga = (detInvoice.TotalPembelianIDR) / det.Qty
						End If
					Next
				Next
				'======= end   19-04-24 ===== set harga beli

				'======= hitung ulang hpp untuk serial yg sudah diproduksi
				Dim param = New List(Of KeyValuePair(Of NuSoft004.Persistent.Fusoh_Barang, List(Of String)))
				For Each detInvoice In instance.IndukInvoice.Detail
					Dim listSerial = New List(Of String)
					param.Add(New KeyValuePair(Of NuSoft004.Persistent.Fusoh_Barang, List(Of String))(detInvoice.Barang, detInvoice.EximDetail.Detail.ToList().Select(Function(n) n.Serial).ToList))
				Next
				NuSoft004.FusohLogic.HPP.HitungUlangHPPDariSerial(session, param)

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
			Finally
				splashManager.CloseWaitForm()
			End Try
		End Using

    '======= Simple log
    Try
      If Tipe = InputType.Tambah Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Cost Sheet [CS] -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Cost Sheet [CS] -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try

    '======= Konfirmasi Cetak Laporan
    'Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.RI)
    'frm.txtNoBukti1.EditValue = instance.Kode
    ''frm.txtTgl1.DateTime = instance.Tanggal
    ''frm.txtTgl2.DateTime = Nothing

    'Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    'Dim reportCode As String = ""
    'reportCode = MainClass.GetReport(MainClass.reportName.VoucherPenerimaanInvoice)
    'message = String.Format(message, "Invoice Pembelian")

    'Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingpurchase.PreviewReport)
  End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtKontak.Focus()
			Case -4 : txtUang.Focus()
			Case -5 : txtNoInvoice.Focus()
			Case -6 : txtNoInvoiceVendor.Focus()
			Case -98 : txtStatus.Focus()
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
		If settingpurchase.FilterKontak = True Then
			txtKontak.Properties.DataSource = New XPCollection(Of Kontak)(session, New BinaryOperator("TipeKontak.Id", settingpurchase.TipeKontak, BinaryOperatorType.Equal))
		Else
			txtKontak.Properties.DataSource = New XPCollection(Of Kontak)(session)
		End If
		txtKaryawan.Properties.DataSource = New XPCollection(Of Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtTermin.Properties.DataSource = New XPCollection(Of Persistent.Termin)(session)
		txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePajak))
		txtJenisPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eJenisPajak))
		txtUang.Properties.DataSource = New XPCollection(Of MataUang)(session)
		txtTipeTransaksi.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipeInvoicePembelian))
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(StatusTransaksiEnum))
		colKodeBarangRepo.DataSource = New XPQuery(Of NuSoft004.Persistent.Fusoh_Barang)(session).Where(Function(w) w.TipeBarang = NuSoft004.Persistent.TipeBarang.Jasa AndAlso w.Jenis = NuSoft004.Persistent.JenisBarang.Jasa).ToList
		colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
	End Sub
	Private Sub SetFormat()
		colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQty.DisplayFormat.FormatString = setting.NumericFormatToString
		colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHarga.DisplayFormat.FormatString = setting.NumericFormatToString
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
		txtPajak.EditValue = Persistent.eTipePajak.TanpaPajak
		txtKurs.Text = 1.0
		txtStatus.EditValue = StatusTransaksiEnum.Posting
		txtTipeTransaksi.EditValue = Persistent.eTipeInvoicePembelian.TanpaPO
		txtUang.EditValue = session.GetObjectByKey(Of MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
		txtUraian.EditValue = settingpurchase.UraianRI
		txtJenisPajak.EditValue = Persistent.eJenisPajak.Penggantian

		txtPajak.Properties.ReadOnly = False
		txtUang.Properties.ReadOnly = False
		xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		xGridView.OptionsBehavior.ReadOnly = False
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.CS)
		'instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "[S][Y2]-[M0][X2]"} 'setting.FormatNomor} CSYY-MMxx
	End Sub
	Private Sub DisableControl()
		txtKontak.Enabled = False
		txtKontakPerson.Enabled = False
		txtTanggal.Enabled = False
		txtRegional.Enabled = False
		txtNoTransaksi.Enabled = False
		txtStatus.Enabled = False
		txtKontak.Properties.ReadOnly = True
		txtTanggal.Properties.ReadOnly = True
		txtNoTransaksi.Properties.ReadOnly = True

		txtNoInvoice.Enabled = False
		txtNoInvoiceVendor.Enabled = False
		txtKaryawan.Enabled = False

		txtTglBerlaku.Enabled = False
		txtTermin.Enabled = False
		txtUang.Enabled = False
		txtKurs.Enabled = False
		txtTipeTransaksi.Enabled = False
		txtPajak.Enabled = False
		txtUraian.Enabled = False

		txtJenisPajak.Enabled = False
		txtNoPPN.Enabled = False
		txtNoPPH.Enabled = False
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
          'ChangeCode()
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
	Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
		ChangeCode()
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
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
	Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
		isShown = True
	End Sub
	Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
		MyBase.OnKeyDown(e)
		If e.Control AndAlso e.Shift Then
			xGrid.Focus()
		End If
	End Sub

	Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			lblKontakNama.Text = CType(e.NewValue, Kontak).Nama
			'isikan data detailnya
			txtPhoneNumber.Text = CType(e.NewValue, Kontak).Telepon
			txtDebitLimit.Text = CStr(CType(e.NewValue, Kontak).BatasPiutang)
			txtCreditLimit.Text = CStr(CType(e.NewValue, Kontak).BatasHutang)
			txtKontakPerson.Properties.DataSource = New XPCollection(Of KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
			xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_PenerimaanInvoice)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))

		End If
	End Sub
	Private Sub HitungTotal()
		txtSubTotal.EditValue = instance.SubTotal
		txtPPN.EditValue = instance.PPN
		txtPPH.EditValue = instance.PPH
		txtTotal.EditValue = instance.Total
	End Sub

  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.Fusoh_PenerimaanInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_PenerimaanInvoiceDetail)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          Dim xbarang As NuSoft004.Persistent.Fusoh_Barang = CType(e.Value, NuSoft004.Persistent.Fusoh_Barang)
          row.Satuan = xbarang.Satuan
          row.Harga = xbarang.LastPurchase
          row.PPN = xbarang.PajakIN
          row.PPH = xbarang.PajakOUT
          row.PPNp = xbarang.PajakIN.NilaiPajak
          row.PPHp = xbarang.PajakOUT.NilaiPajak

          '=====================================
          If xbarang.Custom1 = Fusoh_Logic.Umum.ImportDutyCustom Then
            row.Qty = 1
            If Not txtNoInvoice.EditValue Is Nothing Then
              Dim inv = CType(txtNoInvoice.EditValue, Persistent.Fusoh_PenerimaanInvoice)
              row.Harga = inv.Detail.Sum(Function(m) m.TotalCostImportDuty)
            End If
          End If
          '=====================================
          If xbarang.Kode = kodeShipmentCost AndAlso Not txtNoInvoice.EditValue Is Nothing Then
            Dim inv = CType(txtNoInvoice.EditValue, Persistent.Fusoh_PenerimaanInvoice)
            row.Harga = inv.ShippingCost * inv.Kurs
          End If
        End If
      End If
      HitungTotal()
    End If
  End Sub
  'Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
  '	xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml"))
  'End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
		Dim row As Persistent.Fusoh_PenerimaanInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_PenerimaanInvoiceDetail)
		row.Barang = Nothing
		row.Qty = 0
		row.Main = instance
		row.Catatan = ""
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If CType(txtTipeTransaksi.EditValue, Persistent.eTipeInvoicePembelian) = Persistent.eTipeInvoicePembelian.TanpaPO Then
			If e.KeyCode = Windows.Forms.Keys.Delete Then
				Dim Id As Persistent.Fusoh_PenerimaanInvoiceDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_PenerimaanInvoiceDetail)
				xGridView.DeleteRow(xGridView.FocusedRowHandle)
				detailToDelete.Add(Id)
			End If
		End If
	End Sub
	Private Sub xGridView_ShowingEditor(sender As Object, e As CancelEventArgs) Handles xGridView.ShowingEditor
		Dim item = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_PenerimaanInvoiceDetail)
		If Not item Is Nothing AndAlso Not item.Barang Is Nothing AndAlso item.Barang.Custom1 = Fusoh_Logic.Umum.ImportDutyCustom Then
			e.Cancel = True
		End If
	End Sub

	Private Sub txtNoInvoice_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtNoInvoice.EditValueChanging
		If Not e.NewValue Is Nothing Then
      Dim inv = CType(e.NewValue, Persistent.Fusoh_PenerimaanInvoice)
      txtNoInvoiceVendor.Text = inv.NoReffVendor
      For Each item In instance.Detail
        If item.Barang.Custom1 = Fusoh_Logic.Umum.ImportDutyCustom Then
          item.Harga = inv.Detail.Sum(Function(m) m.TotalCostImportDuty)
        End If

        'Shipment Cost
        If item.Barang.Kode = kodeShipmentCost Then
          item.Harga = inv.ShippingCost * inv.Kurs
        End If
      Next
		End If
	End Sub

  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			instance.TipePajak = CType(e.NewValue, Persistent.eTipePajak)
			xGrid.RefreshDataSource()
			HitungTotal()
		End If
	End Sub

	Private Sub txtUang_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtUang.EditValueChanging
		If Not e.NewValue Is Nothing Then
			SetKurs(e.NewValue)
		End If
	End Sub
	Private Sub SetKurs(mataUang As MataUang)
		If mataUang.Id = setting.MultiMataUangDefault Then
			txtKurs.Text = 1
			txtKurs.Properties.ReadOnly = True
		Else
			txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, mataUang, txtTanggal.DateTime)
			txtKurs.Properties.ReadOnly = False
		End If
	End Sub
End Class