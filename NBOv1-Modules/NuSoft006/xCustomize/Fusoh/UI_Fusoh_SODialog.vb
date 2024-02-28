Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports DevExpress.XtraEditors

Friend Class UI_Fusoh_SODialog
	Private instance As Persistent.Fusoh_OrderPenjualan
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	Private detailToDelete As New List(Of Persistent.Fusoh_OrderPenjualanDetail)
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private salesSetting As Logic.SalesSetting
	Private masterItem As XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)
	Private masterSatuan As XPCollection(Of NuSoft004.Persistent.Satuan)
	Private masterUang As XPCollection(Of NuSoft001.Persistent.MataUang)
	Private masterPajak As XPCollection(Of NuSoft004.Persistent.Pajak)
	Private masterCoa As XPCollection(Of NuSoft001.Persistent.Coa)
	Private settingItem As NuSoft004.Logic.ItemSetting

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
		Persistent.Fusoh_OrderPenjualan.AutoSaveOnEndEdit = False
		Persistent.Fusoh_OrderPenjualanDetail.AutoSaveOnEndEdit = False

		colOD.Caption = "OD" & vbCrLf & "(mm)"
		colInD.Caption = "ID" & vbCrLf & "(mm)"
		colThickness.Caption = "T" & vbCrLf & "(mm)"
		colLength.Caption = "L" & vbCrLf & "(mm)"
		colQty.Caption = "Min" & vbCrLf & "Qty"
		colWeight.Caption = "Total" & vbCrLf & "Weight"
		colHarga.Caption = "Current Price" & vbCrLf & "$ / JPY"
		colHargaRp.Caption = "Price" & vbCrLf & "Rp / Pcs"
		colTotal.Caption = "Total Price" & vbCrLf & "Rp"

		'colKodeRepoView.Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Kode", .FieldName = "Kode", .Width = 30, .Visible = True})
		'colKodeRepoView.Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Nama", .FieldName = "Nama", .Width = 90, .Visible = True})
		'  colKodeRepoView.Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Out", .FieldName = "OutDiameter", .Width = 90, .Visible = True})
		'  colKodeRepoView.Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "IN", .FieldName = "InDiameter", .Width = 90, .Visible = True})
		'  colKodeRepoView.Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Length", .FieldName = "Length", .Width = 90, .Visible = True})
		'  colKodeRepoView.Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Thicknes", .FieldName = "Thickness", .Width = 90, .Visible = True})
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		salesSetting = New Logic.SalesSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SOTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SOTransaksi.xml"))
		End If
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
		End If
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Fusoh_OrderPenjualan(session)
			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.EditValue = CType(txtKontak.Properties.DataSource, XPCollection(Of NuSoft001.Persistent.Kontak))(0)
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.Fusoh_OrderPenjualan)(Convert.ToInt64(IdToEdit))
			txtNoPenawaran.EditValue = instance.Penawaran
			txtPajak.EditValue = instance.TipePajak
			txtKontak.EditValue = instance.Pelanggan
			txtKontakPerson.EditValue = instance.KontakPerson
			txtAlamat.EditValue = instance.Alamat
			If Not instance.Alamat Is Nothing Then
				txtAlamatText.EditValue = instance.Alamat.Alamat
			End If
			txtTanggal.EditValue = instance.Tanggal
			txtRegional.EditValue = instance.Regional
			txtNoTransaksi.Text = instance.Kode
			txtStatus.EditValue = instance.StatusTransaksi
			txtTermPrice.Text = instance.TermOfPrice
			txtDelivery.DateTime = instance.DeliveryDate
			txtTermin.EditValue = instance.Termin
			txtPayment.Text = instance.Payment
			txtInspection.Text = instance.Inspection
			txtValidiity1.DateTime = instance.TanggalBerlakuAwal
			txtValidiity2.DateTime = instance.TanggalBerlakuAkhir
			txtUang.EditValue = instance.Uang
			txtKurs.Value = instance.Kurs
			txtUraian.Text = instance.Catatan
			txtNoPO.Text = instance.NomorPO
			txtTglPO.DateTime = instance.TanggalPO
			txtTipeSO.EditValue = instance.TipeSO

			xGrid.DataSource = instance.Detail
			editAssign = False
		End If
		''cek untuk dempyou
		'If NuSoft004.FusohLogic.HPP.CheckDempyou(session, Convert.ToInt64(IdToEdit)) = True Then
		'  DisableControl()
		'End If

		SetNomor()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Order Penjualan [SO] : Tambah"
		Else
			Me.Text = "Order Penjualan [SO] : Edit " & instance.Kode
			If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
				DisableControl()
			End If
			If User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
				DisableControl()
			End If
			If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
				'DisableControl()
				xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
				txtStatus.Properties.ReadOnly = True
				colKodeBarang.OptionsColumn.ReadOnly = True
				colQty.OptionsColumn.ReadOnly = True
			Else
				xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
				colKodeBarang.OptionsColumn.ReadOnly = True
				colQty.OptionsColumn.ReadOnly = True
			End If
			If MenuId = 6108 Then
				DisableControl()
				txtStatus.Properties.ReadOnly = False
				xGridView.OptionsBehavior.Editable = True
				colPOLine.OptionsColumn.ReadOnly = True
				colKodeBarang.OptionsColumn.ReadOnly = True
				colOD.OptionsColumn.ReadOnly = True
				colInD.OptionsColumn.ReadOnly = True
				colThickness.OptionsColumn.ReadOnly = True
				colLength.OptionsColumn.ReadOnly = True
				colQty.OptionsColumn.ReadOnly = True
				colHarga.OptionsColumn.ReadOnly = True
				colCatatan.OptionsColumn.ReadOnly = True
				colNoPODetail.OptionsColumn.ReadOnly = True
				colDeliveryDate.OptionsColumn.ReadOnly = True
				colTglSanggup.Visible = True
				colTglSanggup.OptionsColumn.ReadOnly = False
				AllowSave = True
			Else
				colTglSanggup.Visible = True
				colTglSanggup.OptionsColumn.ReadOnly = True
			End If
		End If
	End Sub
	Private Sub DisableControl()
		txtKontak.Properties.ReadOnly = True
		txtKontakPerson.Properties.ReadOnly = True
		txtAlamat.Properties.ReadOnly = True
		txtAlamatText.Properties.ReadOnly = True
		txtTanggal.Properties.ReadOnly = True
		txtRegional.Properties.ReadOnly = True
		txtNoTransaksi.Properties.ReadOnly = True
		txtStatus.Properties.ReadOnly = True
		txtPajak.Properties.ReadOnly = True
		txtNoPenawaran.Properties.ReadOnly = True
		txtTermPrice.Properties.ReadOnly = True
		txtTermin.Properties.ReadOnly = True
		txtPayment.Properties.ReadOnly = True
		txtInspection.Properties.ReadOnly = True
		txtValidiity1.Properties.ReadOnly = True
		txtValidiity2.Properties.ReadOnly = True
		txtUang.Properties.ReadOnly = True
		txtKurs.Properties.ReadOnly = True
		txtUraian.Properties.ReadOnly = True
		xGridView.OptionsBehavior.Editable = False
		AllowSave = False
	End Sub
	Overrides Sub SimpanData()
		If txtStatus.Properties.ReadOnly = False Then
			If MenuId = 6108 Then
				If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
					Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
					Exit Sub
				End If
			Else
				If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.ReqApprove) Then
					Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Req Approve.", 0, "", "Simpan Transaksi")
					Exit Sub
				End If
			End If
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
			instance.Pelanggan = If(txtKontak.EditValue Is Nothing, Nothing, CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak))
			instance.KontakPerson = txtKontakPerson.EditValue
			instance.Alamat = If(txtAlamat.EditValue Is Nothing, Nothing, CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat))
			instance.Tanggal = txtTanggal.DateTime
			instance.Regional = If(txtRegional.EditValue Is Nothing, Nothing, CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional))
			instance.Kode = txtNoTransaksi.Text
			instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)

			instance.Penawaran = If(txtNoPenawaran.EditValue Is Nothing, Nothing, CType(txtNoPenawaran.EditValue, Persistent.Fusoh_Penawaran))
			instance.TipePajak = CType(txtPajak.EditValue, NuSoft005.Persistent.eTipePajak)
			instance.TermOfPrice = txtTermPrice.Text
			instance.DeliveryDate = txtDelivery.DateTime
			instance.Termin = If(txtTermin.EditValue Is Nothing, Nothing, CType(txtTermin.EditValue, NuSoft005.Persistent.Termin))
			instance.Payment = txtPayment.Text
			instance.Inspection = txtInspection.Text
			instance.TanggalBerlakuAwal = txtValidiity1.DateTime
			instance.TanggalBerlakuAkhir = txtValidiity2.DateTime
			instance.Uang = If(txtUang.EditValue Is Nothing, Nothing, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang))
			instance.Kurs = txtKurs.Value
			instance.Catatan = txtUraian.Text
			instance.NomorPO = txtNoPO.Text
			instance.TanggalPO = txtTglPO.DateTime
			instance.TipeSO = CType(txtTipeSO.EditValue, Persistent.FusohTipeSO)

			If Not instance.Penawaran Is Nothing Then
				instance.Penawaran.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
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

		'======= Simple log
		Try
			If Tipe = InputType.Tambah Then
				DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Order Penjualan [SO] -> " & instance.Kode)
			Else
				DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Order Penjualan [SO] -> " & instance.Kode)
			End If
			session.CommitChanges()
		Catch ex As Exception
		End Try

		Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.SO)
		frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
		reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherSO)
		message = String.Format(message, "Order Penjualan")
		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -3 : txtTanggal.Focus()
			Case -4 : txtKontak.Focus()
			Case -5 : txtNoPenawaran.Focus()
			Case -6 : txtUang.Focus()
			Case -7 : txtNoPO.Focus()
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
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
		txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eTipePajak))
		txtTipeSO.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.FusohTipeSO))
		txtTermin.Properties.DataSource = New XPCollection(Of NuSoft005.Persistent.Termin)(session)
		txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
		masterSatuan = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
		masterUang = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
		masterCoa = New XPCollection(Of NuSoft001.Persistent.Coa)(session)
		masterPajak = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
		settingItem = New NuSoft004.Logic.ItemSetting(session)
	End Sub
	Private Sub SetFormat()
		colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQty.DisplayFormat.FormatString = setting.NumericFormatString
		colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHarga.DisplayFormat.FormatString = setting.NumericFormatString
		colHarga.SummaryItem.DisplayFormat = setting.NumericFormatString
		colHargaRp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHargaRp.DisplayFormat.FormatString = setting.NumericFormatString
		colHargaRp.SummaryItem.DisplayFormat = setting.NumericFormatString
		colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colSubTotal.DisplayFormat.FormatString = setting.NumericFormatString
		colSubTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
		colPajakIn.SummaryItem.DisplayFormat = setting.NumericFormatString
		colPajakOut.SummaryItem.DisplayFormat = setting.NumericFormatString
		colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colTotal.DisplayFormat.FormatString = setting.NumericFormatString
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

		txtTipeSO.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipeSO)
		txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.ReqApprove
		txtPajak.EditValue = NuSoft005.Persistent.eTipePajak.TanpaPajak
		txtTermPrice.EditValue = Nothing
		txtTermin.EditValue = Nothing
		txtPayment.EditValue = Nothing
		txtInspection.EditValue = Nothing
		txtValidiity1.EditValue = Nothing
		txtValidiity2.EditValue = Nothing
		txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
		txtKurs.EditValue = 1
		txtUraian.EditValue = salesSetting.UraianSO
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SO)
		'instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "SO[Y2]-[M0][X2]"}
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
			'lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
			'isikan data detailnya
			txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
			txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
			txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

			txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
			txtAlamat.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
			xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_OrderPenjualan)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))

			'If instance.Penawaran Is Nothing Then
			'	'txtNoPenawaran.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_Penawaran)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}), New NullOperator(NameOf(Persistent.Fusoh_Penawaran.TanggalBerlakuAkhir)), New BinaryOperator(NameOf(Persistent.Fusoh_Penawaran.TanggalBerlakuAkhir), txtTanggal.DateTime, BinaryOperatorType.LessOrEqual)))
			'	txtNoPenawaran.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_Penawaran)(session,
			'		New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal),
			'			New InOperator("StatusTransaksi", {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}),
			'			New BinaryOperator("TanggalBerlakuAwal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual),
			'			New BinaryOperator("TanggalBerlakuAkhir", txtTanggal.DateTime, BinaryOperatorType.GreaterOrEqual)))
			'Else
			'	txtNoPenawaran.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_Penawaran)(session,
			'		New GroupOperator(GroupOperatorType.Or,
			'			New GroupOperator(GroupOperatorType.And,
			'				New BinaryOperator("Pelanggan", instance.Pelanggan, BinaryOperatorType.Equal),
			'				New InOperator("StatusTransaksi", {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}),
			'			New BinaryOperator("TanggalBerlakuAwal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual),
			'				New BinaryOperator("TanggalBerlakuAkhir", txtTanggal.DateTime, BinaryOperatorType.GreaterOrEqual)),
			'			New BinaryOperator("Id", instance.Penawaran.Id, BinaryOperatorType.Equal)))
			'End If
			'masterItem = New XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)(session, New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanJadi, BinaryOperatorType.Equal))
			masterItem = New XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)(session,
									 New GroupOperator(GroupOperatorType.And,
									 New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanJadi, BinaryOperatorType.Equal),
									 New BinaryOperator("Customer", e.NewValue, BinaryOperatorType.Equal),
									 New BinaryOperator("Aktif", True, BinaryOperatorType.Equal)))
			colKodeRepo.DataSource = masterItem
			LoadSQ(e.NewValue)
		End If
	End Sub
	Private Sub LoadSQ(kontak As NuSoft001.Persistent.Kontak)
		If kontak Is Nothing Then
			Return
		End If
		If instance.Penawaran Is Nothing Then
			'txtNoPenawaran.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_Penawaran)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}), New NullOperator(NameOf(Persistent.Fusoh_Penawaran.TanggalBerlakuAkhir)), New BinaryOperator(NameOf(Persistent.Fusoh_Penawaran.TanggalBerlakuAkhir), txtTanggal.DateTime, BinaryOperatorType.LessOrEqual)))
			txtNoPenawaran.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_Penawaran)(session,
					New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", kontak, BinaryOperatorType.Equal),
						New InOperator("StatusTransaksi", {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}),
						New BinaryOperator("TanggalBerlakuAwal", txtTanggal.DateTime.Date, BinaryOperatorType.LessOrEqual),
						New BinaryOperator("TanggalBerlakuAkhir", txtTanggal.DateTime.Date, BinaryOperatorType.GreaterOrEqual)))
		Else
			txtNoPenawaran.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_Penawaran)(session,
					New GroupOperator(GroupOperatorType.Or,
						New GroupOperator(GroupOperatorType.And,
							New BinaryOperator("Pelanggan", kontak, BinaryOperatorType.Equal),
							New InOperator("StatusTransaksi", {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}),
						New BinaryOperator("TanggalBerlakuAwal", txtTanggal.DateTime.Date, BinaryOperatorType.LessOrEqual),
							New BinaryOperator("TanggalBerlakuAkhir", txtTanggal.DateTime.Date, BinaryOperatorType.GreaterOrEqual)),
						New BinaryOperator("Id", instance.Penawaran.Id, BinaryOperatorType.Equal)))
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
			LoadSQ(txtKontak.EditValue)
		Catch ex As Exception
			If ex.Message.Contains("Object reference not set to an instance") Then
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
			End If
		End Try
	End Sub
	Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
		If Not e.Value Is Nothing Then
			Dim row As Persistent.Fusoh_OrderPenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_OrderPenjualanDetail)
			If e.Column Is colKodeBarang Then
				If Not row Is Nothing Then
					Dim xbarang As NuSoft004.Persistent.Fusoh_Barang = CType(e.Value, NuSoft004.Persistent.Fusoh_Barang)
					Dim xHarga As Double = 0

					If txtKontak.EditValue Is Nothing Then
						Throw New Exception("Masukkan customer")
					End If
					Select Case CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).LevelPenjualan
						Case NuSoft001.Persistent.eLevelPenjualan.Level1 : xHarga = xbarang.HargaJual1
						Case NuSoft001.Persistent.eLevelPenjualan.Level2 : xHarga = xbarang.HargaJual2
						Case NuSoft001.Persistent.eLevelPenjualan.Level3 : xHarga = xbarang.HargaJual3
						Case NuSoft001.Persistent.eLevelPenjualan.Level4 : xHarga = xbarang.HargaJual4
						Case NuSoft001.Persistent.eLevelPenjualan.Level5 : xHarga = xbarang.HargaJual5
					End Select
					row.Harga = xHarga
					row.PPN = xbarang.PajakIN
					row.PPH = xbarang.PajakOUT
					row.PPNp = xbarang.PajakIN.NilaiPajak
					row.PPHp = xbarang.PajakOUT.NilaiPajak
					row.OutDiameter = xbarang.OutDiameter
					row.InDiameter = xbarang.InDiameter
					row.Thickness = xbarang.Thickness
					row.Length = xbarang.Length
					row.NamaBarang = xbarang.Nama
					'ambilkan harga dari SQ yg berlaku
					Dim xSQ As New XPCollection(Of Persistent.Fusoh_PenawaranDetail)(session, CreateCriteria(row.Barang.Kode))
					If xSQ.Count > 0 Then
						row.Harga = xSQ(0).Harga
					End If
				End If
			End If
			HitungTotal()
		End If
	End Sub
	Private Function CreateCriteria(xKodebarang As String) As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		'result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
		result.Add(New BinaryOperator("Barang", xKodebarang, BinaryOperatorType.Equal))
		result.Add(New BinaryOperator("Main.TanggalBerlakuAwal", txtTanggal.DateTime, BinaryOperatorType.GreaterOrEqual))
		result.Add(New BinaryOperator("Main.TanggalBerlakuAkhir", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
		result.Add(New BinaryOperator("Main.Pelanggan", CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
		Return GroupOperator.And(result)
	End Function
	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
		Dim row As Persistent.Fusoh_OrderPenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_OrderPenjualanDetail)
		row.Barang = Nothing
		row.POLine = instance.Detail.Count
		row.NamaBarang = ""
		row.OutDiameter = 0
		row.InDiameter = 0
		row.Thickness = 0
		row.Length = 0
		row.Qty = 1
		row.Harga = 0
		row.Main = instance
		row.Catatan = ""
		row.NoPODetail = IIf(txtNoPO.Text = txtNoPO.Properties.NullText, String.Empty, txtNoPO.Text)
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Persistent.Fusoh_OrderPenjualanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_OrderPenjualanDetail)
			xGridView.DeleteRow(xGridView.FocusedRowHandle)
			detailToDelete.Add(Id)
		End If
		If e.KeyCode = Windows.Forms.Keys.F12 Then
			Dim xData As Persistent.Fusoh_OrderPenjualanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_OrderPenjualanDetail)
			Dim a As New NuSoft004.Logic.Stock
			a.showDataStock(Me.MenuId, Me.NamaDatabase, session, xData.Barang.Id)
		End If
	End Sub
	Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
	End Sub
	Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
		isShown = True
	End Sub
	Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
		'MyBase.OnKeyDown(e)
		If e.Control AndAlso e.Shift Then
			xGrid.Focus()
		End If
	End Sub
	Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
		ChangeCode()
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub
	Private Sub txtTglBerlaku_EditValueChanged(sender As Object, e As EventArgs)
		txtTanggal.Properties.MaxValue = CDate(txtValidiity1.EditValue)
	End Sub
	Private Sub txtTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles txtTanggal.EditValueChanged
		txtValidiity1.Properties.MinValue = CDate(txtTanggal.EditValue)
	End Sub
	Private Sub txtAlamat_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAlamat.EditValueChanging
		If Not e.NewValue Is Nothing Then
			txtAlamatText.Text = CType(e.NewValue, NuSoft001.Persistent.KontakAlamat).Alamat
		End If
	End Sub
	Private Sub txtNoPenawaran_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtNoPenawaran.EditValueChanging
		If Not e.NewValue Is Nothing And editAssign = False Then
			Dim xDataSO As New XPCollection(Of Persistent.Fusoh_OrderPenjualanDetail)(session, New BinaryOperator("Main.Penawaran", e.NewValue, BinaryOperatorType.Equal))
			Dim item As Persistent.Fusoh_Penawaran = CType(e.NewValue, Persistent.Fusoh_Penawaran)
			Dim data As Persistent.Fusoh_OrderPenjualanDetail
			Dim xIDPenawaran As Persistent.Fusoh_PenawaranDetail

			For i = instance.Detail.Count - 1 To 0 Step -1
				instance.Detail(i).Delete()
			Next

			txtKontakPerson.EditValue = item.KontakPerson
			txtAlamat.EditValue = item.Alamat
			If Not item.Alamat Is Nothing Then
				txtAlamatText.EditValue = item.Alamat.Alamat
			End If
			txtPajak.EditValue = item.TipePajak
			txtUang.EditValue = item.Uang
			txtKurs.Value = item.Kurs
			txtNoPO.Text = item.YourReff
			txtTermPrice.Text = item.TermOfPrice
			txtTermin.EditValue = item.Termin
			txtPayment.Text = item.Payment
			txtInspection.Text = item.Inspection

			For i = 0 To item.Detail.Count - 1
				data = New Persistent.Fusoh_OrderPenjualanDetail(session)
				xIDPenawaran = item.Detail(i)
				Dim bar = masterItem.ToList.Find(Function(f) f.Kode = xIDPenawaran.PartNo)
				If bar Is Nothing Then
					bar = New NuSoft004.Persistent.Fusoh_Barang(session) With {
					.Kode = xIDPenawaran.PartNo,
					.Nama = xIDPenawaran.Material,
					.NamaPart = xIDPenawaran.Barang,
					.Aktif = True,
					.OutDiameter = xIDPenawaran.OutDiameter, .InDiameter = xIDPenawaran.InDiameter,
					.Length = xIDPenawaran.Length, .Thickness = xIDPenawaran.Thickness,
					.Satuan = masterSatuan(0), .SatuanD = masterSatuan(0), .Uang = masterUang(0),
					.TipeBarang = NuSoft004.Persistent.TipeBarang.BahanJadi, .Jenis = NuSoft004.Persistent.JenisBarang.Persediaan,
					.PajakIN = masterPajak.ToList.Find(Function(m) m.Id = settingItem.PajakIN),
					.PajakOUT = masterPajak.ToList.Find(Function(m) m.Id = settingItem.PajakOut),
					.CoaStock = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunPersediaan),
					.CoaIncome = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunPendapatan),
					.CoaCost = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunHPP),
					.CoaDiscIncome = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunDiscPenjualan),
					.CoaDiscOut = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunDiscPembelian),
					.CoaReturnIn = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunReturPenjualan),
					.CoaReturnOut = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunReturPembelian),
					.Customer = CType(txtKontak.EditValue, Kontak)
					}
					masterItem.Add(bar)
				End If
				data.POLine = i + 1
				data.Barang = bar
				data.PPN = bar.PajakIN
				data.PPH = bar.PajakOUT
				data.PPNp = bar.PajakIN.NilaiPajak
				data.PPHp = bar.PajakOUT.NilaiPajak

				data.NamaBarang = xIDPenawaran.Barang
				data.OutDiameter = xIDPenawaran.OutDiameter
				data.InDiameter = xIDPenawaran.InDiameter
				data.Thickness = xIDPenawaran.Thickness
				data.Length = xIDPenawaran.Length
				data.Qty = xIDPenawaran.Qty - xDataSO.Where(Function(m) m.PenawaranDetail Is xIDPenawaran).Sum(Function(n) n.Qty)
				data.Weight = xIDPenawaran.Weight - xDataSO.Where(Function(m) m.PenawaranDetail Is xIDPenawaran).Sum(Function(n) n.Weight)

				data.Harga = xIDPenawaran.Harga
				data.Catatan = xIDPenawaran.Catatan
				data.PenawaranDetail = xIDPenawaran
				instance.Detail.Add(data)
			Next
			HitungTotal()
		End If
	End Sub
	Private Sub txtPajak_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtPajak.EditValueChanging
		If Not e.NewValue Is Nothing AndAlso Not instance Is Nothing Then
			instance.TipePajak = CType(e.NewValue, NuSoft005.Persistent.eTipePajak)
			xGrid.RefreshDataSource()
			HitungTotal()
		End If
	End Sub
	Private Sub txtKurs_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtKurs.EditValueChanging
		If Not e.NewValue Is Nothing AndAlso Not instance Is Nothing Then
			instance.Kurs = e.NewValue
			xGrid.RefreshDataSource()
			HitungTotal()
		End If
	End Sub
	Sub HitungTotal()
		txtSubTotal.EditValue = instance.SubTotal
		txtPPN.EditValue = instance.PPN
		txtPPH.EditValue = instance.PPH
		txtTotal.EditValue = instance.Total
	End Sub

	Private Sub btnImpor_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnImpor.ItemClick
		Dim frm As New UI_Fusoh_SODialogImpor
		frm.session = session
		If frm.ShowDialog = DialogResult.OK Then
			For Each det In frm.SOImporDetail
				'If Not det.Barang Is Nothing Then
				Dim row = instance.Detail.ToList.Find(Function(m) m.POLine = det.POLine)
				If row Is Nothing Then
					row = New Persistent.Fusoh_OrderPenjualanDetail(session) With {.Main = instance, .POLine = det.POLine}
					instance.Detail.Add(row)
				End If
				If det.Barang Is Nothing Then
					det.Barang = New NuSoft004.Persistent.Fusoh_Barang(session) With {
							.Kode = det.KodeBarang, .Nama = det.NamaBarang, .Aktif = True,
							.OutDiameter = det.OutDiameter, .InDiameter = det.InDiameter,
							.Length = det.Length, .Thickness = det.Thickness,
							.Satuan = masterSatuan(0), .SatuanD = masterSatuan(0), .Uang = masterUang(0),
							.TipeBarang = NuSoft004.Persistent.TipeBarang.BahanJadi, .Jenis = NuSoft004.Persistent.JenisBarang.Persediaan,
							.PajakIN = masterPajak.ToList.Find(Function(m) m.Id = settingItem.PajakIN),
							.PajakOUT = masterPajak.ToList.Find(Function(m) m.Id = settingItem.PajakOut),
							.CoaStock = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunPersediaan),
							.CoaIncome = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunPendapatan),
							.CoaCost = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunHPP),
							.CoaDiscIncome = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunDiscPenjualan),
							.CoaDiscOut = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunDiscPembelian),
							.CoaReturnIn = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunReturPenjualan),
							.CoaReturnOut = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunReturPembelian),
							.Customer = CType(txtKontak.EditValue, Kontak)
						}
					masterItem.Add(det.Barang)
				End If
				row.Barang = det.Barang
				row.OutDiameter = det.OutDiameter
				row.InDiameter = det.InDiameter
				row.Thickness = det.Thickness
				row.Length = det.Length
				row.Weight = det.Weight
				row.Qty = det.Qty
				row.Harga = det.Harga
				row.Catatan = det.Catatan

				row.PPN = det.Barang.PajakIN
				row.PPH = det.Barang.PajakOUT
				row.PPNp = det.Barang.PajakIN.NilaiPajak
				row.PPHp = det.Barang.PajakOUT.NilaiPajak
				row.NamaBarang = det.Barang.Nama
				row.NoPODetail = det.NoPODetail
				row.DeliveryDate = det.DeliveryDate
				'End If
			Next
			HitungTotal()
		End If
	End Sub

	Private Sub txtNoPO_LostFocus(sender As Object, e As EventArgs) Handles txtNoPO.LostFocus
		If instance Is Nothing Then Return
		For Each x In instance.Detail
			If String.IsNullOrEmpty(x.NoPODetail) Then
				x.NoPODetail = txtNoPO.Text
			End If
		Next
	End Sub
	Private Sub txtTermin_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtTermin.EditValueChanging
		If Not e.NewValue Is Nothing AndAlso Not instance Is Nothing Then
			txtDelivery.DateTime = DateAdd(DateInterval.Day, CType(e.NewValue, NuSoft005.Persistent.Termin).Tempo, txtTanggal.DateTime)
		End If
	End Sub
	Private Sub btnAmbilSQ_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAmbilSQ.ItemClick
		'MsgBox("Menu ID : " & Me.MenuId)

		If txtKontak.EditValue Is Nothing Then
			XtraMessageBox.Show("Pilih customer terlebih dahulu.", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Exit Sub
		End If
		Dim frm As New UI_Fusoh_SODialogSQ
    frm.Customer = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
    frm.Tanggal = txtTanggal.DateTime
    If Tipe = InputType.Edit Then
			frm.EditedSO = instance
		End If
		frm.session = session

		If (frm.ShowDialog = DialogResult.OK) Then
			Dim xDataSQ As List(Of Persistent.Fusoh_PenawaranDetail) = frm.Result
			Dim xIDPenawaran As Persistent.Fusoh_PenawaranDetail
			Dim xDataSO As New XPCollection(Of Persistent.Fusoh_OrderPenjualanDetail)(session)

			For i = 0 To xDataSQ.Count - 1
				Dim Data = New Persistent.Fusoh_OrderPenjualanDetail(session)
				xIDPenawaran = xDataSQ(i)
				Dim bar = masterItem.ToList.Find(Function(f) f.Kode = xIDPenawaran.PartNo)
				If bar Is Nothing Then
					bar = New NuSoft004.Persistent.Fusoh_Barang(session) With {
					.Kode = xIDPenawaran.PartNo,
					.Nama = xIDPenawaran.Material,
					.NamaPart = xIDPenawaran.Barang,
					.Aktif = True,
					.OutDiameter = xIDPenawaran.OutDiameter, .InDiameter = xIDPenawaran.InDiameter,
					.Length = xIDPenawaran.Length, .Thickness = xIDPenawaran.Thickness,
					.Satuan = masterSatuan(0), .SatuanD = masterSatuan(0), .Uang = masterUang(0),
					.TipeBarang = NuSoft004.Persistent.TipeBarang.BahanJadi, .Jenis = NuSoft004.Persistent.JenisBarang.Persediaan,
					.PajakIN = masterPajak.ToList.Find(Function(m) m.Id = settingItem.PajakIN),
					.PajakOUT = masterPajak.ToList.Find(Function(m) m.Id = settingItem.PajakOut),
					.CoaStock = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunPersediaan),
					.CoaIncome = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunPendapatan),
					.CoaCost = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunHPP),
					.CoaDiscIncome = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunDiscPenjualan),
					.CoaDiscOut = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunDiscPembelian),
					.CoaReturnIn = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunReturPenjualan),
					.CoaReturnOut = masterCoa.ToList.Find(Function(m) m.Id = settingItem.AkunReturPembelian),
							.Customer = CType(txtKontak.EditValue, Kontak)
					}
					masterItem.Add(bar)
				End If
				Data.POLine = i + 1
				Data.Barang = bar
				Data.PPN = bar.PajakIN
				Data.PPH = bar.PajakOUT
				Data.PPNp = bar.PajakIN.NilaiPajak
				Data.PPHp = bar.PajakOUT.NilaiPajak

				Data.NamaBarang = xIDPenawaran.Barang
				Data.OutDiameter = xIDPenawaran.OutDiameter
				Data.InDiameter = xIDPenawaran.InDiameter
				Data.Thickness = xIDPenawaran.Thickness
				Data.Length = xIDPenawaran.Length
				Data.Qty = xIDPenawaran.Qty - xDataSO.Where(Function(m) m.PenawaranDetail Is xIDPenawaran).Sum(Function(n) n.Qty)
				Data.Weight = xIDPenawaran.Weight - xDataSO.Where(Function(m) m.PenawaranDetail Is xIDPenawaran).Sum(Function(n) n.Weight)

				Data.Harga = xIDPenawaran.Harga
				Data.Catatan = xIDPenawaran.Catatan
				Data.PenawaranDetail = xIDPenawaran

				instance.Detail.Add(Data)
			Next
			HitungTotal()
		End If
	End Sub
End Class