Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem

Friend Class UI_TMShipByPDialog
	Private instance As Persistent.Tm_OrderPenjualan
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	Private detailToDelete As New List(Of Persistent.Tm_OrderPenjualanDetail)
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private salesSetting As Logic.SalesSetting

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
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
		'colDivisi.Visible = setting.MultiDivisi
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Tm_OrderPenjualan(session)
			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtVehicle.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.Tm_OrderPenjualan)(Convert.ToInt64(IdToEdit))
			txtVehicle.Text = instance.Vehicle
			txtCarrierCompany.Text = instance.CarrierCompany
			txtTanggal.EditValue = instance.Tanggal
			txtRegional.EditValue = instance.Regional
			txtNoTransaksi.Text = instance.Kode
			txtStatus.EditValue = instance.StatusTransaksi
			Dim xdata = CType(txtShipmentUOM.Properties.DataSource, XPCollection(Of NuSoft004.Persistent.Satuan))
			txtShipmentUOM.EditValue = xdata.ToList.Find(Function(f) f.Kode = instance.ShipmentUOM)
			txtShipmentCreatedFrom.EditValue = instance.ShipmentCreatedFrom
			txtShipmentStatus.EditValue = instance.ShipmentStatus
			txtShipmentSequence.Text = instance.ShipmentSequence
			txtPriority.Checked = instance.PriorityShipment
			txtDescription.Text = instance.Description
			txtRemarks.Text = instance.Remarks
			txtDriver.EditValue = instance.Driver

			Dim dataX = New XPQuery(Of Persistent.Tm_OrderPenjualanDetail)(session).GroupBy(Function(g) g.PenawaranDetail).Select(Function(s) s.Key)
			Dim exist = instance.Detail.GroupBy(Function(g) g.PenawaranDetail).Select(Function(s) s.Key)
			Dim x = New XPCollection(Of Persistent.Tm_PenawaranDetail)(session, New GroupOperator(GroupOperatorType.Or, New NotOperator(New InOperator("This", dataX)), New InOperator("This", exist)))
			'x.DisplayableProperties = "This;Main.Kode;Main.Pelanggan.Nama;Barang.Nama;Qty;Kode"
			colKodeBarangRepo.DataSource = x

			xGrid.DataSource = instance.Detail
			editAssign = False
		End If
		SetNomor()
		xGridView.OptionsBehavior.Editable = True
		xGridView.OptionsBehavior.ReadOnly = False
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Shipment by Product: Add"
		Else
			Me.Text = "Shipment by Product: Edit " & instance.Kode
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

		For i = detailToDelete.Count - 1 To 0 Step -1
			detailToDelete(i).Delete()
		Next

		Try
			'======= Simpan Main
			instance.Vehicle = txtVehicle.Text
			instance.CarrierCompany = txtCarrierCompany.Text
			instance.Tanggal = txtTanggal.DateTime
			instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			instance.Kode = txtNoTransaksi.Text
			instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
			instance.ShipmentUOM = txtShipmentUOM.Text
			instance.ShipmentCreatedFrom = txtShipmentCreatedFrom.EditValue
			instance.ShipmentStatus = txtShipmentStatus.EditValue
			instance.ShipmentSequence = txtShipmentSequence.Text
			instance.PriorityShipment = txtPriority.Checked
			instance.Description = txtDescription.Text
			instance.Remarks = txtRemarks.Text
			instance.Driver = txtDriver.Text
			instance.Save()

			'update status penawaran
			'If Not txtShipmentUOM.EditValue Is Nothing Then
			'	Dim xDataOrder As New XPCollection(Of Persistent.OrderPenjualanDetail)(session, New BinaryOperator("PenawaranDetail.Main.Id", CType(txtShipmentUOM.EditValue, Persistent.Penawaran).Id, BinaryOperatorType.Equal))
			'	Dim xQtySQ As Double, xQtySO As Double
			'	xQtySQ = instance.NoPenawaran.TotalQty
			'	xQtySO = xDataOrder.Sum(Function(n) n.Qty) + instance.TotalQty
			'	If xQtySO < xQtySQ Then
			'		CType(txtShipmentUOM.EditValue, Persistent.Penawaran).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
			'	Else
			'		CType(txtShipmentUOM.EditValue, Persistent.Penawaran).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
			'	End If
			'End If
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
		Dim frm As New RF_TMVoucher(Persistent.SumberDataJenis.SO)
		frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
		reportCode = MainClass.GetReport(MainClass.reportName.tSuratJalan)
		message = String.Format(message, "Surat Jalan")
		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -3 : txtDescription.Focus()
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
		txtNoTransaksi.Text = nomor.Kode
	End Sub
	Private Sub BindingDataSource()
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtShipmentUOM.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
		txtVehicle.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eVehicle))
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))

		Dim dataX = New XPQuery(Of Persistent.Tm_OrderPenjualanDetail)(session).GroupBy(Function(g) g.PenawaranDetail).Select(Function(s) s.Key)
		Dim x = New XPCollection(Of Persistent.Tm_PenawaranDetail)(session, New NotOperator(New InOperator("This", dataX)))
		'x.DisplayableProperties = "This;Main.Kode;Main.Pelanggan.Nama;Barang.Nama;Qty;Kode"
		colKodeBarangRepo.DataSource = x
	End Sub
	Private Sub SetFormat()
		'colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQty.DisplayFormat.FormatString = setting.NumericFormatString
		'colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colHarga.DisplayFormat.FormatString = setting.NumericFormatString
		'colPPN.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colPPH.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colTotal.DisplayFormat.FormatString = setting.NumericFormatString
		'colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

		'colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colSubTotal.DisplayFormat.FormatString = setting.NumericFormatString
		'colSubTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colDiscount.DisplayFormat.FormatString = setting.NumericFormatString
		'colDiscountPersen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colDiscountPersen.DisplayFormat.FormatString = setting.NumericFormatString

		'txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		'txtSubTotal.Properties.Mask.EditMask = setting.NumericFormatToString
		'txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		'txtPPN.Properties.Mask.EditMask = setting.NumericFormatToString
		'txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		'txtPPH.Properties.Mask.EditMask = setting.NumericFormatToString
		'txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		'txtTotal.Properties.Mask.EditMask = setting.NumericFormatToString
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
		txtVehicle.EditValue = Persistent.eVehicle.Niaga1
		txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		txtShipmentUOM.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtShipmentUOM)
		txtShipmentCreatedFrom.SelectedIndex = 0
		'txtDescription.EditValue = salesSetting.UraianSO
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SO)
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
	End Sub
	Private Sub DisableControl()
		txtVehicle.Properties.ReadOnly = True
		txtCarrierCompany.Properties.ReadOnly = True
		txtTanggal.Properties.ReadOnly = True
		txtRegional.Properties.ReadOnly = True
		txtNoTransaksi.Properties.ReadOnly = True
		txtStatus.Properties.ReadOnly = True
		txtShipmentUOM.Properties.ReadOnly = True
		txtShipmentCreatedFrom.Properties.ReadOnly = True
		txtDriver.Properties.ReadOnly = True
		txtShipmentStatus.Properties.ReadOnly = True
		txtShipmentSequence.Properties.ReadOnly = True
		txtPriority.Properties.ReadOnly = True
		txtRemarks.Properties.ReadOnly = True
		txtDescription.Properties.ReadOnly = True
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
	Private Sub RefreshLookupSources(sender As Object)
		BindingDataSource()
	End Sub
	Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtVehicle.EditValueChanging
		If Not e.NewValue Is Nothing Then
			txtCarrierCompany.Text = Utils.Helper.EnumDescription.GetDescription(e.NewValue)
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
			Dim row As Persistent.Tm_OrderPenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Tm_OrderPenjualanDetail)
			If e.Column Is colOrder Then
				If Not row Is Nothing Then
					row.Qty = row.PenawaranDetail.Qty
				End If
			End If
		End If
	End Sub
	Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
		'xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
	End Sub
	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
		Dim row As Persistent.Tm_OrderPenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Tm_OrderPenjualanDetail)
		row.PenawaranDetail = Nothing
		row.Qty = 0
		row.Main = instance
		row.Destination = ""
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Persistent.Tm_OrderPenjualanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Tm_OrderPenjualanDetail)
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
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub
End Class