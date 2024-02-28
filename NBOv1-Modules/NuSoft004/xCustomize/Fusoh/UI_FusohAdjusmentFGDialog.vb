Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Friend Class UI_FusohAdjusmentFGDialog
	Private instance As Persistent.Fusoh_StokMain
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	Private detailToDelete As New List(Of Persistent.Fusoh_StokDetail)
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	'Private masterItem As XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)
	Private sumberProduksi As List(Of Persistent.Fusoh_StokDetail)

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
		Persistent.Fusoh_StokMain.AutoSaveOnEndEdit = False
		Persistent.Fusoh_StokDetail.AutoSaveOnEndEdit = False
		NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PSTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PSTransaksi.xml"))
		End If
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Fusoh_StokMain(session)
			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.Fusoh_StokMain)(Convert.ToInt64(IdToEdit))
			txtUraian.Text = instance.Catatan
			'txtKontak.EditValue = instance.KaryawanKirim
			txtKontak.EditValue = instance.Pelanggan
			txtTanggal.EditValue = instance.Tanggal
			txtRegional.EditValue = instance.Regional
			txtGudang.EditValue = instance.Gudang
			txtNoTransaksi.Text = instance.Kode
			txtStatus.EditValue = instance.StatusTransaksi

			xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
			instance.Detail.CriteriaString = ""
			xGrid.DataSource = instance.Detail
			editAssign = False
		End If
		SetNomor()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Adjusment FG : Tambah"
		Else
			Me.Text = "Adjusment FG : Edit " & instance.Kode
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

		For i = 0 To instance.Detail.Count - 1
			If instance.Detail(i).Barang.Kode <> instance.Detail(i).ProduksiDetail.Barang.Kode Then
				Throw New Utils.Exception("Kode barang tidak sama.", 0, "", "Simpan Transaksi")
				Exit Sub
			End If

			'======== cek sisa stok =========
			Dim ins = instance.Detail(i)
			Dim stokDibutuhkan = ins.QtyOut
			Dim sisaStok = New XPQuery(Of Persistent.FusohVwProduksi)(session).Where(Function(w) w.KodeItem = ins.Barang.Kode AndAlso w.Id = ins.ProduksiDetail.Id).Sum(Function(s) s.QtySisa)
			If stokDibutuhkan > sisaStok Then
				Throw New Utils.Exception(String.Format("Penyesuaian {0} melebihi sisa stok. Stok sisa {1} dibutuhkan {2}", instance.Detail(i).Barang.Kode, sisaStok, stokDibutuhkan), 0, "", "Simpan Transaksi")
				Exit Sub
			End If
		Next


		Try
			'======= Simpan Main
			instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
			instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			instance.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
			instance.Tanggal = txtTanggal.DateTime
			instance.Kode = txtNoTransaksi.Text
			instance.Catatan = txtUraian.Text
			instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
			instance.Kurs = 1
			instance.Save()

			'======= update hpp keluar
			For Each detail In instance.Detail
				detail.Harga = detail.ProduksiDetail.Harga
				detail.TotalHPP = detail.ProduksiDetail.Harga * detail.QtyOut
			Next

			'======= update status produksi
			'Dim produksi = instance.Detail.GroupBy(Function(g) g.ProduksiDetail.Main).Select(Function(s) s.Key)
			'For i = 0 To produksi.Count - 1
			'  Dim item = produksi(i)
			'  Dim xQtyProduksi As Double = item.TotalQtyProduksi
			'  Dim xQtySJSdh As Double = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.ProduksiDetail.Main Is item).Sum(Function(s) s.Qty)
			'  Dim xQtySJBlm As Double = instance.Detail.Where(Function(w) w.ProduksiDetail.Main Is item).Sum(Function(s) s.Qty)

			'  If (xQtySJBlm + xQtySJSdh) < xQtyProduksi Then
			'    item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
			'  Else
			'    item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
			'  End If
			'Next

			''======= update SO
			'Dim so = instance.Detail.GroupBy(Function(g) g.SODetail.Main).Select(Function(s) s.Key)
			'For i = 0 To so.Count - 1
			'  Dim item = so(i)
			'  Dim xQtySO As Double = item.TotalQty
			'  Dim xQtySJSdh As Double = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.SODetail.Main Is item).Sum(Function(s) s.Qty)
			'  Dim xQtySJBlm As Double = instance.Detail.Where(Function(w) w.SODetail.Main Is item).Sum(Function(s) s.Qty)

			'  If (xQtySJBlm + xQtySJSdh) < xQtySO Then
			'    item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
			'  Else
			'    item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
			'  End If
			'Next


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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Adjustment FG -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Adjustment FG -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try
    'Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.PS)
    'frm.txtNoBukti1.Text = instance.Kode
    'Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    'Dim reportCode As String = ""
    'reportCode = MainClass.GetReport(MainClass.reportName.VoucherPenyesuaianStock)
    'message = String.Format(message, "Penyesuaian Stock")
    'Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
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
		txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
		txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
		txtNoTransaksi.Text = nomor.Kode
	End Sub
	Private Sub BindingDataSource()
		txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)
		'colKodeBarangRepo.DataSource = New XPCollection(Of Persistent.Barang)(session)
		colSatuanRepo.DataSource = New XPCollection(Of Persistent.Satuan)(session)
		colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
	End Sub
	Private Sub SetFormat()
		colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
		colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
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
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.PS)
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
	End Sub
	Private Sub DisableControl()
		txtKontak.Properties.ReadOnly = True
		txtTanggal.Properties.ReadOnly = True
		txtNoTransaksi.Properties.ReadOnly = True
		txtRegional.Properties.ReadOnly = True
		txtGudang.Properties.ReadOnly = True
		txtUraian.Properties.ReadOnly = True
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

	Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
			'isikan data detailnya
			txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
			txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
			txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

			'Dim xpTransaksi As New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("Id", CType(e.NewValue, NuSoft001.Persistent.Kontak).Id, BinaryOperatorType.Equal))

			'masterItem = New XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)(session,
			'             New GroupOperator(GroupOperatorType.And,
			'             New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanJadi, BinaryOperatorType.Equal),
			'             New BinaryOperator("Customer", e.NewValue, BinaryOperatorType.Equal)))

			colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)(session,
									 New GroupOperator(GroupOperatorType.And,
									 New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanJadi, BinaryOperatorType.Equal),
									 New BinaryOperator("Customer", e.NewValue, BinaryOperatorType.Equal),
									 New BinaryOperator("Aktif", True, BinaryOperatorType.Equal)))
			'colProduksiRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Fusoh_StokDetail)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.AM, BinaryOperatorType.Equal), New BinaryOperator("Barang.Customer", e.NewValue, BinaryOperatorType.Equal)))

			' ===== start edit =====
			'colProduksiRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Fusoh_StokDetail)(session, New GroupOperator(GroupOperator.And, New InOperator("Main.Sumber", New Persistent.SumberDataJenis() {Persistent.SumberDataJenis.AM, Persistent.SumberDataJenis.TS, Persistent.SumberDataJenis.BS}), New BinaryOperator("Barang.Customer", e.NewValue, BinaryOperatorType.Equal)))
			Dim dataProduksiId = New XPQuery(Of Persistent.FusohVwProduksi)(session).Where(Function(w) w.QtySisa > 0).Select(Function(s) s.Id).ToList
			sumberProduksi = New XPCollection(Of Persistent.Fusoh_StokDetail)(session, New GroupOperator(GroupOperator.And, New InOperator("Main.Sumber", New Persistent.SumberDataJenis() {Persistent.SumberDataJenis.AM, Persistent.SumberDataJenis.TS, Persistent.SumberDataJenis.BS}), New BinaryOperator("Barang.Customer", e.NewValue, BinaryOperatorType.Equal), New InOperator("Id", dataProduksiId))).ToList
			colProduksiRepo.DataSource = sumberProduksi
			' ===== end edit =====
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
			Dim row As Persistent.Fusoh_StokDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_StokDetail)
			If e.Column Is colKodeBarang Then
				If Not row Is Nothing Then
					Dim xbarang As Persistent.Fusoh_Barang = CType(e.Value, Persistent.Fusoh_Barang)
					row.Satuan = xbarang.Satuan
				End If
			End If
			'If e.Column Is colProduksi Then
			'  If Not row Is Nothing Then
			'    row.Satuan = xbarang.Satuan
			'  End If
			'End If
		End If
	End Sub
	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
		Dim row As Persistent.Fusoh_StokDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_StokDetail)
		row.Barang = Nothing
		'row.QtyIn = 0
		row.Main = instance
		row.Catatan = ""
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Persistent.Fusoh_StokDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_StokDetail)
			xGridView.DeleteRow(xGridView.FocusedRowHandle)
			detailToDelete.Add(Id)
		End If
	End Sub
	Private Sub xGridView_ShownEditor(sender As Object, e As EventArgs) Handles xGridView.ShownEditor
		Dim view As GridView = CType(sender, GridView)
		If view.FocusedColumn Is colProduksi AndAlso view.ActiveEditor.GetType Is GetType(SearchLookUpEdit) Then
			Dim edit As SearchLookUpEdit = CType(view.ActiveEditor, SearchLookUpEdit)
			Dim item As Persistent.Fusoh_Barang = CType(view.GetRowCellValue(xGridView.FocusedRowHandle, colKodeBarang), Persistent.Fusoh_Barang)

			If (item Is Nothing) Then Return
			edit.Properties.DataSource = sumberProduksi.Where(Function(w) w.Barang Is item).ToList
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