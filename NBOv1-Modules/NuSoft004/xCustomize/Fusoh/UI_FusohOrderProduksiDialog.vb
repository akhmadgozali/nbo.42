Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Friend Class UI_FusohOrderProduksiDialog
	Private instance As Persistent.Fusoh_OrderProduksi
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of SettingRegional)
	Private editAssign As Boolean = False
	Private detailToDelete As New List(Of Persistent.Fusoh_OrderProduksiBahanBaku)
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private masterItem As List(Of Persistent.Fusoh_Barang)

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
		Persistent.Fusoh_OrderPenjualan.AutoSaveOnEndEdit = False
		Persistent.Fusoh_OrderPenjualanDetail.AutoSaveOnEndEdit = False

		colOD.Caption = "OD" & vbCrLf & "(mm)"
		colInD.Caption = "ID" & vbCrLf & "(mm)"
		colThickness.Caption = "T" & vbCrLf & "(mm)"
		colLength.Caption = "L" & vbCrLf & "(mm)"
		colWeight.Caption = "Total" & vbCrLf & "Weight"
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("OPTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("OPTransaksi.xml"))
		End If
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("OPTransaksiGrid.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("OPTransaksiGrid.xml"))
		End If

		txtQty.Properties.MinValue = 1
		txtQty.Properties.MaxValue = Integer.MaxValue
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Fusoh_OrderProduksi(session)
			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.BahanBaku
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.Fusoh_OrderProduksi)(Convert.ToInt64(IdToEdit))

			Dim po As New List(Of Persistent.Fusoh_OrderPenjualan)
			Dim podetail As New List(Of Persistent.Fusoh_OrderPenjualanDetail)
			po.Add(instance.SODetail.Main)
			podetail.Add(instance.SODetail)
			txtNoPO.Properties.DataSource = po
			txtPOLine.Properties.DataSource = podetail

			txtKontak.EditValue = instance.Pelanggan
			txtGudang.EditValue = instance.Gudang
			txtTanggal.EditValue = instance.Tanggal
			txtRegional.EditValue = instance.Regional
			txtNoTransaksi.Text = instance.Kode
			txtStatus.EditValue = instance.StatusTransaksi

			txtNoPDO.EditValue = instance.NomorPDO
			txtNoPO.EditValue = instance.SODetail.Main
			txtPOLine.EditValue = instance.SODetail
			txtQty.Value = CDec(instance.Qty)
			txtCutting.EditValue = instance.Cutting
			txtNoCutting.Checked = instance.NoCutting
			txtPrioritas.Checked = instance.Urgent

			'If txtNoCutting.Checked = False Then
			'  txtCutting.EditValue = CType(txtPOLine.EditValue, Persistent.Fusoh_OrderPenjualanDetail).Barang.LengthCutting '  s.LengthCutting
			'Else
			'  txtCutting.EditValue = CType(txtPOLine.EditValue, Persistent.Fusoh_OrderPenjualanDetail).Barang.Length
			'End If

			txtRMDibutuhkan.EditValue = GetRMDibutuhkan(CDbl(txtCutting.EditValue), txtQty.Value)

			txtNoLOT.Text = instance.NomorLot
			txtNoDrawing.Text = instance.NomorDrawing
			txtDeliveryDate.Text = instance.DeliveryDate
			txtMaterialFlow.EditValue = instance.MaterialFlow

			txtLengthTolerance.Text = instance.LengthTolerance
			txtMaterialCorner.Text = instance.MaterialCorner
			txtColourCode.Text = instance.ColourCode
			txtRemark.Text = instance.Catatan
			txtTargetFinish.Text = instance.TargetFinish

			xGrid.DataSource = instance.BahanBaku
			txtKontak.Properties.ReadOnly = True
			txtNoPO.Properties.ReadOnly = True
			txtPOLine.Properties.ReadOnly = True

			txtPartNo.Text = instance.SODetail.Barang.Kode
			txtMaterial.Text = instance.SODetail.Barang.Nama
			txtSize.Text = instance.SODetail.OutDiameter.ToString("n0") & " x " & instance.SODetail.Thickness.ToString("n0")
			txtLength.Text = instance.SODetail.Length.ToString("n0")
			Dim sisa = BuildPOLineSource(instance.SODetail.Main).Find(Function(w) w.SODetail Is instance.SODetail)
			'txtQty.Properties.MaxValue = CDec(instance.Qty + sisa.Qty)

			editAssign = False
		End If
		SetNomor()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Order Produksi [Dempyou] : Tambah"
		Else
			Me.Text = "Order Produksi [Dempyou] : Edit " & instance.Kode
			If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
				DisableControl()
			End If
			If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
				DisableControl()
			End If
			If User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
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
			'======= Simpan Main
			instance.Pelanggan = If(txtKontak.EditValue Is Nothing, Nothing, CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak))
			instance.Gudang = If(txtGudang.EditValue Is Nothing, Nothing, CType(txtGudang.EditValue, Persistent.Gudang))
			instance.Tanggal = txtTanggal.DateTime
			instance.Regional = If(txtRegional.EditValue Is Nothing, Nothing, CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional))
			instance.Kode = txtNoTransaksi.Text
			instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)

			If Not txtPOLine.EditValue Is Nothing Then
				If Tipe = InputType.Tambah Then
					instance.SODetail = CType(txtPOLine.EditValue, Persistent.DempyouPOLine).SODetail
				Else
					instance.SODetail = CType(txtPOLine.EditValue, Persistent.Fusoh_OrderPenjualanDetail)
				End If
			End If
			instance.Qty = txtQty.Value
			If Not instance.SODetail Is Nothing Then
				instance.Weight = CDec(FusohLogic.Item.GetWeight(instance.SODetail.OutDiameter, instance.SODetail.Length, instance.SODetail.Thickness) * instance.Qty)
			End If

			instance.Cutting = CType(txtCutting.EditValue, Double)

			instance.NomorPDO = txtNoPDO.Text
			instance.NomorLot = txtNoLOT.Text
			instance.NomorDrawing = txtNoDrawing.Text
			instance.DeliveryDate = txtDeliveryDate.Text
			instance.MaterialFlow = txtMaterialFlow.Text

			instance.MaterialCorner = txtMaterialCorner.Text
			instance.ColourCode = txtColourCode.Text
			instance.LengthTolerance = txtLengthTolerance.Text
			instance.Catatan = txtRemark.Text
			instance.TargetFinish = txtTargetFinish.Text
			instance.NoCutting = txtNoCutting.Checked
			instance.Urgent = txtPrioritas.Checked

			'''======== set status SO
			''If Not instance.SODetail Is Nothing Then
			''	Dim xQtySO As Double = instance.SODetail.Main.TotalQty
			''	Dim xQtyDempyou As Double = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(w) w.SODetail.Main Is instance.SODetail.Main).Sum(Function(s) s.Qty) + instance.Qty
			''	If xQtyDempyou < xQtySO Then
			''		instance.SODetail.Main.StatusTransaksi = StatusTransaksiEnum.InProgress
			''	Else
			''		instance.SODetail.Main.StatusTransaksi = StatusTransaksiEnum.Finish
			''	End If
			''End If

			instance.Save()
			'======= Simpan instance
			session.CommitChanges()
		Catch ex As Utils.Exception
			Throw New Utils.Exception(ex)
		Catch ex As Exception
			If ex.Message.Contains("d_nomorlot_UNIQUE") Then
				Throw New Exception("Nomor LOT sudah ada. Silahkan ganti dengan yang lain", ex.InnerException)
			ElseIf ex.Message.Contains("Duplicate entry") Then
				'instance.Kode = instance.Number.GetNewNumber.Kode
				'session.CommitChanges()
				Throw New Utils.Exception("Kode '" & instance.Kode & "' sudah pernah diinput." & vbCrLf & "Mohon masukkan kode lain.", 0)
			Else
				Throw New Exception(ex.Message, ex.InnerException)
			End If
		End Try
		editAssign = False

		'======= Simple log
		Try
			If Tipe = InputType.Tambah Then
				DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Dempyou -> " & instance.Kode)
			Else
				DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Dempyou -> " & instance.Kode)
			End If
			session.CommitChanges()
		Catch ex As Exception
		End Try

		Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.OP)
		frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
		reportCode = MainClass.GetReport(MainClass.reportName.zFusohDempyou)
		message = String.Format(message, "Order Produksi [Dempyou]")
		If Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True) Then

		End If ' salesSetting.PreviewSave)

	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case 0 : txtNoTransaksi.Focus()
			Case -1 : txtRegional.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtKontak.Focus()
			Case -4 : txtGudang.Focus()
			Case -5 : txtPOLine.Focus()
			Case -6 : txtNoLOT.Focus()
			Case -6 : txtDeliveryDate.Focus()
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
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
		txtKontak.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderPenjualan)(session).GroupBy(Function(g) g.Pelanggan).Select(Function(s) s.Key).ToList
		txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)

		IsiBarangJadi(True)

		Dim ccc = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(w) Not String.IsNullOrEmpty(w.NomorLot)).GroupBy(Function(g) g.NomorLot).Select(Function(s) s.Key).ToArray
		If ccc.Count > 0 Then
			Dim collection As New AutoCompleteStringCollection()
			collection.AddRange(ccc)
			txtNoLOT.MaskBox.AutoCompleteSource = Windows.Forms.AutoCompleteSource.CustomSource
			txtNoLOT.MaskBox.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
			txtNoLOT.MaskBox.AutoCompleteCustomSource = collection
		End If
	End Sub
	Private Sub IsiBarangJadi(All As Boolean)
		If All = True Then
			masterItem = New XPQuery(Of Persistent.Fusoh_Barang)(session).Where(Function(w) w.TipeBarang = Persistent.TipeBarang.BahanBaku AndAlso w.Jenis = Persistent.JenisBarang.Persediaan).ToList
			colKodeBarang.Caption = "Part No [All]"
		Else
			Dim listMasterProduksi = CType(txtPOLine.EditValue, Persistent.DempyouPOLine).SODetail.Barang.ItemPenyusun.ToList.Select(Function(s) s.BarangPenyusun)
			MsgBox("List produksi sebanyak : " & listMasterProduksi.Count & "==>" & listMasterProduksi(0).Kode)
			'masterItem = New XPQuery(Of Persistent.Fusoh_Barang)(session).Where(Function(w) w.TipeBarang = Persistent.TipeBarang.BahanBaku AndAlso w.Jenis = Persistent.JenisBarang.Persediaan AndAlso listMasterProduksi.Contains(w)).ToList
			masterItem = New XPQuery(Of Persistent.Fusoh_Barang)(session).Where(Function(w) listMasterProduksi.Contains(w)).ToList
			colKodeBarang.Caption = "Part No [Khusus]"
		End If

		colKodeRepo.DataSource = masterItem
	End Sub

	Private Sub SetFormat()
		'colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQty.DisplayFormat.FormatString = setting.NumericFormatString
		'colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colLengthSN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colLengthSN.DisplayFormat.FormatString = setting.NumericFormatString
		'colLengthSN.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colSN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colSN.DisplayFormat.FormatString = setting.NumericFormatString
		'colSN.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colMillSheet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colMillSheet.DisplayFormat.FormatString = setting.NumericFormatString
		'colMillSheet.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colPajakIn.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colPajakOut.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colTotal.DisplayFormat.FormatString = setting.NumericFormatString
		'colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

		txtCutting.Properties.DisplayFormat.FormatString = setting.NumericFormatToString
		txtCutting.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		txtCutting.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtCutting.Properties.Mask.EditMask = setting.NumericFormatToString

		txtRMDibutuhkan.Properties.DisplayFormat.FormatString = setting.NumericFormatToString
		txtRMDibutuhkan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		txtRMDibutuhkan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtRMDibutuhkan.Properties.Mask.EditMask = setting.NumericFormatToString
		'txtLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		'txtLength.Properties.Mask.EditMask = setting.NumericFormatToString
		'txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		'txtQty.Properties.Mask.EditMask = setting.NumericFormatToString
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

		txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		txtGudang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtGudang)
		txtDeliveryDate.EditValue = "" 'Now.AddDays(7)
		txtMaterialFlow.EditValue = "Cutting"

		txtLengthTolerance.EditValue = Nothing
		txtMaterialCorner.EditValue = Nothing
		txtColourCode.EditValue = Nothing
		txtRemark.EditValue = Nothing
		txtNoCutting.Checked = False
		txtPrioritas.Checked = False
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.OP)
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
	End Sub
	Private Sub DisableControl()
		txtKontak.Properties.ReadOnly = True
		txtGudang.Properties.ReadOnly = True
		txtRegional.Properties.ReadOnly = True
		txtNoTransaksi.Properties.ReadOnly = True
		txtStatus.Properties.ReadOnly = True
		txtTanggal.Properties.ReadOnly = True

		txtNoPO.Properties.ReadOnly = True
		txtPOLine.Properties.ReadOnly = True
		txtQty.Properties.ReadOnly = True

		txtNoLOT.Properties.ReadOnly = True
		txtMaterialFlow.Properties.ReadOnly = True
		txtNoDrawing.Properties.ReadOnly = True
		txtDeliveryDate.Properties.ReadOnly = True

		txtMaterialCorner.Properties.ReadOnly = True
		txtColourCode.Properties.ReadOnly = True
		txtLengthTolerance.Properties.ReadOnly = True
		txtRemark.Properties.ReadOnly = True
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

	Private Sub txtKontak_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtKontak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			'lblKontakNama.Text = CType(e.NewValue, Kontak).Nama
			'isikan data detailnya
			txtPhoneNumber.Text = CType(e.NewValue, Kontak).Telepon
			txtDebitLimit.Text = CStr(CType(e.NewValue, Kontak).BatasPiutang)
			txtCreditLimit.Text = CStr(CType(e.NewValue, Kontak).BatasHutang)

			xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_OrderProduksi)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))

			If Not editAssign Then
				If Tipe = InputType.Tambah Then
					'Dim existingOP = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(w) w.Pelanggan Is e.NewValue).Select(Function(s) s.SODetail.Main)
					'txtNoPO.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderPenjualan)(session).Where(Function(w) _
					'				w.Pelanggan Is e.NewValue AndAlso (w.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting OrElse
					'				w.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress) AndAlso Not existingOP.Contains(w))
					txtNoPO.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderPenjualan)(session) _
						.Where(Function(w) w.Pelanggan Is e.NewValue AndAlso (w.StatusTransaksi = StatusTransaksiEnum.Posting OrElse w.StatusTransaksi = StatusTransaksiEnum.InProgress)).ToList
				Else
					txtNoPO.Properties.DataSource = instance.SODetail.Main
				End If
				txtNoPO.EditValue = Nothing
			End If
		End If
	End Sub
	Private Sub txtPO_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtNoPO.EditValueChanging
		If Not editAssign Then
			If Not e.NewValue Is Nothing Then
				If Tipe = InputType.Tambah Then
					Dim source = BuildPOLineSource(CType(e.NewValue, Persistent.Fusoh_OrderPenjualan))
					txtPOLine.Properties.DataSource = source.Where(Function(w) w.Qty > 0).ToList

					'tanggal delivery
					txtDeliveryDate.Text = CType(e.NewValue, Persistent.Fusoh_OrderPenjualan).DeliveryDate.ToString("dd-MMM-yy")
				Else
					txtPOLine.Properties.DataSource = instance.SODetail
				End If
			End If

			txtPOLine.EditValue = Nothing
			txtPartNo.Text = ""
			txtMaterial.Text = ""
			txtSize.Text = ""
			txtLength.Text = ""
			txtQty.EditValue = 0
		End If
	End Sub
	Private Sub txtPOLine_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtPOLine.EditValueChanging
		If Not editAssign AndAlso Not e.NewValue Is Nothing Then
			Dim s = CType(e.NewValue, Persistent.DempyouPOLine)
			txtPartNo.Text = s.KodeBarang
			txtMaterial.Text = s.NamaBarang
			txtSize.Text = s.OutDiameter.ToString("n0") & " x " & s.Thickness.ToString("n0")
			txtLength.Text = s.Length.ToString("n0")
			txtQty.EditValue = s.Qty
			'MsgBox(s.LengthCutting.ToString() & "/" & (s.LengthCutting + 3) * s.Qty)
			txtCutting.EditValue = s.LengthCutting
			txtMaterialFlow.EditValue = s.MaterialProses.Nama  'NuSoft.Utils.Helper.EnumDescription.GetDescription(s.MaterialProses)
			'txtQty.Properties.MaxValue = CDec(s.Qty)
			txtRMDibutuhkan.EditValue = GetRMDibutuhkan(s.LengthCutting, s.Qty) '(s.LengthCutting + 3) * s.Qty

			txtNoPDO.EditValue = "D" & txtTanggal.DateTime.ToString("yy") & "-" & CType(txtNoPO.EditValue, Persistent.Fusoh_OrderPenjualan).NomorPO & "-" & s.POLine 'D22-LH1203536-33

			IsiBarangJadi(Not chkTampilkanMaster.Checked)
		End If
	End Sub
	Private Sub txtQty_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtQty.EditValueChanging
		If Not editAssign AndAlso Not e.NewValue Is Nothing Then
			txtRMDibutuhkan.EditValue = GetRMDibutuhkan(CDbl(txtCutting.EditValue), CDbl(e.NewValue)) '(CDbl(txtCutting.EditValue) + 3) * CDbl(e.NewValue)
		Else
			txtRMDibutuhkan.EditValue = 0
		End If
	End Sub
	Private Sub txtNoCutting_CheckedChanged(sender As Object, e As EventArgs) Handles txtNoCutting.CheckedChanged
		If Not editAssign Then
			'Dim s = CType(txtPOLine.EditValue, Persistent.Fusoh_OrderPenjualanDetail)

			If Tipe = InputType.Tambah Then
				'instance.SODetail = CType(txtPOLine.EditValue, Persistent.DempyouPOLine).SODetail
				If Not txtPOLine.EditValue Is Nothing Then
					If txtNoCutting.Checked = False Then
						txtCutting.EditValue = CType(txtPOLine.EditValue, Persistent.DempyouPOLine).SODetail.Barang.LengthCutting '  s.LengthCutting
					Else
						txtCutting.EditValue = CType(txtPOLine.EditValue, Persistent.DempyouPOLine).SODetail.Barang.Length.ToString("n0")
					End If
				End If
			Else
				'Dim s = CType(txtPOLine.EditValue, Persistent.Fusoh_OrderPenjualanDetail)
				If Not txtPOLine.EditValue Is Nothing Then
					If txtNoCutting.Checked = False Then
						txtCutting.EditValue = CType(txtPOLine.EditValue, Persistent.Fusoh_OrderPenjualanDetail).Barang.LengthCutting '  s.LengthCutting
					Else
						'txtCutting.EditValue = CType(txtPOLine.EditValue, Persistent.Fusoh_OrderPenjualanDetail).Barang.Length.ToString("n0")
						txtCutting.EditValue = CType(txtPOLine.EditValue, Persistent.Fusoh_OrderPenjualanDetail).Barang.Length
					End If
				End If
			End If

			txtRMDibutuhkan.EditValue = GetRMDibutuhkan(CDbl(txtCutting.EditValue), txtQty.Value)

		End If
	End Sub

	Private Function GetRMDibutuhkan(LengthCutting As Double, Qty As Double) As Double
		Dim lebarMataPisau As Double = 3
		If (txtNoCutting.Checked) Then lebarMataPisau = 0
		Return (LengthCutting + lebarMataPisau) * Qty
	End Function

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
			Dim row As Persistent.Fusoh_OrderProduksiBahanBaku = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_OrderProduksiBahanBaku)
			If e.Column Is colMaterialLength Then
				row.Qty = 0
				If row.SNLength = CDec(e.Value) Then
					row.Qty = 1
				End If
			End If
		End If
	End Sub
	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
		Dim row As Persistent.Fusoh_OrderProduksiBahanBaku = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_OrderProduksiBahanBaku)
		row.Main = instance
		row.Barang = Nothing
		row.Serial = Nothing
		row.SNLength = 0
		row.Length = 0
		row.Qty = 0
		row.Catatan = ""
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Persistent.Fusoh_OrderProduksiBahanBaku = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_OrderProduksiBahanBaku)
			xGridView.DeleteRow(xGridView.FocusedRowHandle)
			detailToDelete.Add(Id)
		End If
		'If e.KeyCode = Windows.Forms.Keys.F12 Then
		'	Dim xData As Persistent.Fusoh_OrderProduksiBahanBaku = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_OrderProduksiBahanBaku)
		'	Dim a As New NuSoft004.Logic.Stock
		'	a.showDataStock(Me.MenuId, Me.NamaDatabase, session, xData.Barang.Id)
		'End If
	End Sub
	Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("OPTransaksiGrid.xml"))
	End Sub
	Private Sub xGridView_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles xGridView.CustomDrawRowIndicator
		If e.RowHandle >= 0 Then
			e.Info.DisplayText = (e.RowHandle + 1).ToString()
		End If
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

	Private Sub xGridView_ShownEditor(sender As Object, e As EventArgs) Handles xGridView.ShownEditor
		If (xGridView.FocusedColumn Is colMaterialLength AndAlso xGridView.ActiveEditor.GetType Is GetType(SpinEdit)) Then
			Dim edit As SpinEdit = CType(xGridView.ActiveEditor, SpinEdit)
			Dim item As Persistent.Fusoh_OrderProduksiBahanBaku = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_OrderProduksiBahanBaku)

			edit.Properties.MaxValue = item.SNLength
		End If
	End Sub
	Private Sub colSNRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colSNRepo.ButtonClick
		If txtNoPO.EditValue Is Nothing Then
			MessageBox.Show("Pilih Nomor PO terlebih dahulu", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If
		If txtPOLine.EditValue Is Nothing Then
			MessageBox.Show("Pilih PO Line terlebih dahulu", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If
		If txtQty.Value = 0 Then
			MessageBox.Show("Qty bahan jadi tidak boleh 0", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If
		If CDbl(txtCutting.EditValue) = 0 Then
			MessageBox.Show("Cutting tidak boleh 0", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		Dim frm As New UI_FusohOrderProduksiSerial
		frm.session = session
		frm.instance = instance
		Dim barang As Persistent.Fusoh_Barang = CType(xGridView.GetRowCellValue(xGridView.FocusedRowHandle, colKodeBarang), Persistent.Fusoh_Barang)
		frm.Item = barang
		frm.Serial = instance.BahanBaku.Where(Function(w) w.Barang Is barang).ToList
		frm.BahanJadiQty = CInt(txtQty.Value)
		frm.BahanJadiCutting = CInt(txtCutting.EditValue) + 3

		If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
			'== hapus tidak terpilih
			For i = instance.BahanBaku.Count - 1 To 0 Step -1
				Dim o = instance.BahanBaku(i)
				If o.Barang Is barang Then
					Dim find = frm.SerialResult.Find(Function(f) f.Barang Is o.Barang AndAlso f.Serial = o.Serial)
					If find Is Nothing Then
						o.Delete()
						instance.BahanBaku.Remove(o)
					End If
				End If
			Next

			'=== set terpilih
			For i = 0 To frm.SerialResult.Count - 1
				Dim s = frm.SerialResult(i)
				Dim fa = instance.BahanBaku.ToList.Find(Function(f) f.Barang Is s.Barang AndAlso f.Serial = s.Serial)
				If fa Is Nothing Then
					instance.BahanBaku.Add(s)
				Else
					xGrid.BeginUpdate()
					fa.SNLength = s.SNLength
					fa.Length = s.Length
					fa.Qty = s.Qty
					xGrid.EndUpdate()
				End If
			Next
		End If
	End Sub

	Private Function BuildPOLineSource(SO As Persistent.Fusoh_OrderPenjualan) As List(Of Persistent.DempyouPOLine)
		Dim dempyou = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(w) w.SODetail.Main Is SO).ToList
		Dim soDetail = New XPQuery(Of Persistent.Fusoh_OrderPenjualanDetail)(session).Where(Function(w) w.Main Is SO).ToList
		Dim listSource As New List(Of Persistent.DempyouPOLine)

		For i = 0 To soDetail.Count - 1
			Dim det = soDetail(i)
			Dim qty = det.Qty
			Dim found = dempyou.FindAll(Function(f) f.SODetail Is det).Sum(Function(s) s.Qty)
			qty = det.Qty - found

			Dim item = New Persistent.DempyouPOLine() With {.SODetail = det, .KodeBarang = det.Barang.Kode, .NamaBarang = det.Barang.Nama, .InDiameter = det.InDiameter, .Length = det.Length, .OutDiameter = det.OutDiameter, .NoPODetail = det.NoPODetail, .POLine = det.POLine, .Qty = qty, .Thickness = det.Thickness, .LengthCutting = det.Barang.LengthCutting, .MaterialProses = det.Barang.MaterialProses}
			item.This = item
			listSource.Add(item)
		Next

		Return listSource
	End Function

	Private Sub chkTampilkanMaster_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles chkTampilkanMaster.EditValueChanging

	End Sub

	Private Sub chkTampilkanMaster_CheckStateChanged(sender As Object, e As EventArgs) Handles chkTampilkanMaster.CheckStateChanged
		If editAssign = False Then IsiBarangJadi(Not chkTampilkanMaster.Checked)
	End Sub
End Class