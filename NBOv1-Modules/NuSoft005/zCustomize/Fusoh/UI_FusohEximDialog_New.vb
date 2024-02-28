Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class UI_FusohEximDialog_New
	Private editAssign As Boolean = False
	Private setting As NuSoft001.Logic.FinaSetting
	Private settingpurchase As Logic.PurchaseSetting
	Private originalEdit As Persistent_Fusoh.Persistent_FusohExim
	Private bindingList As List(Of Persistent_Fusoh.Persistent_FusohEximDetail_ForSave)

	Sub New()
		InitializeComponent()
		AllowSave = True
	End Sub
	Protected Overrides Sub OnKeyDown(e As Windows.Forms.KeyEventArgs)
		MyBase.OnKeyDown(e)
		If e.Control AndAlso e.Shift Then
			xGrid.Focus()
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

	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub
	Private Sub txtKontak_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtKontak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			Dim kontak = CType(e.NewValue, Kontak)
			lblKontakNama.Text = kontak.Nama
			txtPhoneNumber.Text = kontak.Telepon
			txtDebitLimit.Text = kontak.BatasPiutang.ToString("n0")
			txtCreditLimit.Text = kontak.BatasHutang.ToString("n0")

			txtKontakPerson.Properties.DataSource = New XPCollection(Of KontakPerson)(session, New BinaryOperator(NameOf(KontakPerson.Kontak), e.NewValue, BinaryOperatorType.Equal))

			'======================= Khusus Tambah
			If Tipe = InputType.Tambah Then
				Dim dataExim = New XPQuery(Of Persistent_Fusoh.Persistent_FusohExim)(session).Where(Function(w) w.Vendor Is kontak).GroupBy(Function(g) g.PO).Select(Function(s) s.Key).ToList
				txtNoPO.Properties.DataSource = New XPQuery(Of Persistent_Fusoh.Persistent_FusohOrderPembelianDetail)(session).Where(Function(w) _
							w.Main.Vendor Is e.NewValue AndAlso Not dataExim.Contains(w.Main) AndAlso
							(w.Main.StatusTransaksi = StatusTransaksiEnum.Posting OrElse w.Main.StatusTransaksi = StatusTransaksiEnum.InProgress) AndAlso
							w.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Persediaan).GroupBy(Function(g) g.Main).Select(Function(s) s.Key).ToList

				txtKontakPerson.EditValue = Nothing
				txtGudang.EditValue = Nothing
				txtPajak.EditValue = Nothing
				txtVia.EditValue = Nothing
				txtFOB.EditValue = Nothing
				txtTglBerlaku.DateTime = Nothing
				txtLeadTime.Text = Nothing
				txtUang.EditValue = Nothing
				txtTermin.EditValue = Nothing
				txtKaryawan.EditValue = Nothing
				txtUraian.Text = Nothing
				txtCatatan.Text = Nothing
				txtReffNo.EditValue = Nothing
				txtCustom1.EditValue = Nothing
				txtCustom2.EditValue = Nothing
				txtCustom3.EditValue = Nothing
				txtCustom4.EditValue = Nothing
				txtCustom5.EditValue = Nothing

				txtSubTotal.EditValue = 0
				txtPPN.EditValue = 0
				txtPPH.EditValue = 0
				txtTotal.EditValue = 0

				xGrid.DataSource = Nothing
			End If

			xGHistory.DataSource = New XPCollection(Of Persistent_Fusoh.Persistent_FusohExim)(session, New BinaryOperator(NameOf(Persistent_Fusoh.Persistent_FusohExim.Vendor), kontak, BinaryOperatorType.Equal))
		End If
	End Sub
	Private Sub txtNoPO_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtNoPO.EditValueChanging
		If Not e.NewValue Is Nothing And editAssign = False Then
			Dim PO As Persistent_Fusoh.Persistent_FusohOrderPembelian = CType(e.NewValue, Persistent_Fusoh.Persistent_FusohOrderPembelian)
			txtKontakPerson.EditValue = PO.KontakPerson
			txtGudang.EditValue = PO.Gudang
			txtPajak.EditValue = PO.TipePajak
			txtVia.EditValue = PO.Via
			txtFOB.EditValue = PO.FOB
			txtTglBerlaku.DateTime = PO.TanggalBerlaku
			txtLeadTime.Text = PO.LeadTime
			txtUang.EditValue = PO.Uang
			txtTermin.EditValue = PO.Termin
			txtKaryawan.EditValue = PO.Karyawan
			txtUraian.Text = PO.Uraian
			txtCatatan.Text = PO.Catatan
			txtReffNo.EditValue = PO.ReffNo
			txtCustom1.EditValue = PO.Custom1
			txtCustom2.EditValue = PO.Custom2
			txtCustom3.EditValue = PO.Custom3
			txtCustom4.EditValue = PO.Custom4
			txtCustom5.EditValue = PO.Custom5

			txtSubTotal.EditValue = PO.SubTotal
			txtPPN.EditValue = PO.PPN
			txtPPH.EditValue = PO.PPH
			txtTotal.EditValue = PO.Total

			xGrid.BeginUpdate()
			bindingList = New List(Of Persistent_Fusoh.Persistent_FusohEximDetail_ForSave)
			For i = 0 To PO.Detail.Count - 1
				Dim detail = PO.Detail(i)
				Dim item = New Persistent_Fusoh.Persistent_FusohEximDetail_ForSave With {
						.Barang = detail.Barang,
						.Catatan = detail.Catatan,
						.InDiameter = detail.InDiameter,
						.Length = detail.Length,
						.OutDiameter = detail.OutDiameter,
						.PODetail = detail,
						.Qty = detail.Qty,
						.Satuan = detail.Satuan,
						.Thickness = detail.Thickness,
						.Weight = detail.Weight
					}
				item.SerialForSave = New List(Of Persistent_Fusoh.Persistent_FusohEximDetailSerial_ForSave)
				For j = 0 To item.Qty - 1
					item.SerialForSave.Add(New Persistent_Fusoh.Persistent_FusohEximDetailSerial_ForSave With {
						.Id = j + 1,
						.Barang = item.Barang,
						.LengthIn = item.Length,
						.Serial = "",
						.MillSheet = ""
					})
				Next
				bindingList.Add(item)
			Next
			xGrid.EndUpdate()
			xGrid.DataSource = bindingList
		End If
	End Sub

	Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
		Try
			xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("POTransaksiGrid.xml"))
		Catch ex As Exception

		End Try
	End Sub
	Private Sub colBarangRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colBarangRepo.ButtonClick
		Dim frm As New UI_FusohEximDialogSerial_New
		frm.NamaDatabase = Me.NamaDatabase
		frm.MenuId = Me.MenuId
		frm.session = session

		Dim row As Persistent_Fusoh.Persistent_FusohEximDetail_ForSave
		row = CType(xGridView.GetFocusedRow, Persistent_Fusoh.Persistent_FusohEximDetail_ForSave)
		frm.LoadingData(row)
		If Not AllowSave Then
			frm.Disable()
		End If
		frm.ShowDialog()
	End Sub

	Private Sub CheckDisableControl(obj As Persistent_Fusoh.Persistent_FusohExim)
		Dim disable As Boolean
		Try
			disable = False
			Service_Fusoh.Service_FusohExim.CheckIsInUse(session, obj)
			If User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
				disable = True
			End If
		Catch ex As Exception
			disable = True
		End Try

		If disable Then
			txtKontak.Enabled = False
			txtRegional.Enabled = False
			txtGudang.Enabled = False
			txtUraian.Enabled = False
			txtKontakPerson.Enabled = False
			txtPajak.Enabled = False
			txtVia.Enabled = False
			txtFOB.Enabled = False
			txtTglBerlaku.Enabled = False
			txtLeadTime.Enabled = False
			txtTermin.Enabled = False
			txtUang.Enabled = False
			txtKaryawan.Enabled = False
			txtNoPO.Enabled = False
			txtTanggal.Properties.ReadOnly = True
			txtNoTransaksi.Properties.ReadOnly = True
			txtStatus.Properties.ReadOnly = True
			xGridView.OptionsBehavior.ReadOnly = True
			AllowSave = False
		End If
	End Sub
	Private Sub BindingDataSource()
		If settingpurchase.FilterKontak = True Then
			txtKontak.Properties.DataSource = New XPCollection(Of Kontak)(session, New BinaryOperator(NameOf(Kontak.TipeKontak) & "." & NameOf(TipeKontak.Id), settingpurchase.TipeKontak, BinaryOperatorType.Equal))
		Else
			txtKontak.Properties.DataSource = New XPCollection(Of Kontak)(session)
		End If
		txtKaryawan.Properties.DataSource = New XPCollection(Of Kontak)(session, New BinaryOperator(NameOf(Kontak.TipeKontak) & "." & NameOf(TipeKontak.Nama), "Karyawan", BinaryOperatorType.Equal))
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtGudang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(session)
		txtTermin.Properties.DataSource = New XPCollection(Of Persistent.Termin)(session)
		txtVia.Properties.DataSource = New XPCollection(Of Persistent.Via)(session)
		txtUang.Properties.DataSource = New XPCollection(Of MataUang)(session)

		txtFOB.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipeFOB))
		txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePajak))
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(StatusTransaksiEnum))
	End Sub

	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		settingpurchase = New Logic.PurchaseSetting(session)

		BindingDataSource()

		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("EXTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("EXTransaksi.xml"))
		End If
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("EXTransaksiGrid.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("EXTransaksiGrid.xml"))
		End If

		colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQty.DisplayFormat.FormatString = setting.NumericFormatString
		colQty.SummaryItem.DisplayFormat = setting.NumericFormatString

		txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtSubTotal.Properties.Mask.EditMask = setting.NumericFormatToString
		txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtPPN.Properties.Mask.EditMask = setting.NumericFormatToString
		txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtPPH.Properties.Mask.EditMask = setting.NumericFormatToString
		txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtTotal.Properties.Mask.EditMask = setting.NumericFormatToString
	End Sub
	Overrides Sub InitializeData()
		bindingList = New List(Of Persistent_Fusoh.Persistent_FusohEximDetail_ForSave)

		If Tipe = InputType.Tambah Then
			Me.Text = "Exim : Tambah Data"
			Dim defaultRegional = UserInfo.GetDefaultRegional(session)
			If Not defaultRegional Is Nothing Then
				txtRegional.EditValue = defaultRegional
			Else
				txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
			End If
			txtTanggal.EditValue = Now
			txtStatus.EditValue = StatusTransaksiEnum.Posting
			txtPajak.EditValue = Persistent.eTipePajak.TanpaPajak
			txtFOB.EditValue = Persistent.eTipeFOB.Origin
			txtGudang.EditValue = session.GetObjectByKey(Of NuSoft004.Persistent.Gudang)(settingpurchase.GudangDefault)
			txtUang.EditValue = session.GetObjectByKey(Of MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
			txtVia.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtVia)
			txtUraian.EditValue = settingpurchase.UraianPO
		Else
			editAssign = True
			originalEdit = session.GetObjectByKey(Of Persistent_Fusoh.Persistent_FusohExim)(Convert.ToInt64(IdToEdit))
			txtNoPO.Properties.DataSource = New Persistent_Fusoh.Persistent_FusohOrderPembelian() {originalEdit.PO}
			Me.Text = "Exim : Edit Data " & originalEdit.Kode

			txtStatus.EditValue = originalEdit.StatusTransaksi
			txtNoTransaksi.Text = originalEdit.Kode
			txtTanggal.EditValue = originalEdit.Tanggal
			txtKontak.EditValue = originalEdit.Vendor
			txtRegional.EditValue = originalEdit.Regional
			txtNoPO.EditValue = originalEdit.PO
			txtKontakPerson.EditValue = originalEdit.PO.KontakPerson
			txtGudang.EditValue = originalEdit.PO.Gudang
			txtPajak.EditValue = originalEdit.PO.TipePajak
			txtVia.EditValue = originalEdit.PO.Via
			txtFOB.EditValue = originalEdit.PO.FOB
			txtTglBerlaku.DateTime = originalEdit.PO.TanggalBerlaku
			txtLeadTime.Text = originalEdit.PO.LeadTime
			txtUang.EditValue = originalEdit.PO.Uang
			txtTermin.EditValue = originalEdit.PO.Termin
			txtKaryawan.EditValue = originalEdit.PO.Karyawan
			txtUraian.Text = originalEdit.PO.Uraian
			txtCatatan.Text = originalEdit.PO.Catatan
			txtReffNo.EditValue = originalEdit.PO.ReffNo
			txtCustom1.EditValue = originalEdit.PO.Custom1
			txtCustom2.EditValue = originalEdit.PO.Custom2
			txtCustom3.EditValue = originalEdit.PO.Custom3
			txtCustom4.EditValue = originalEdit.PO.Custom4
			txtCustom5.EditValue = originalEdit.PO.Custom5

			bindingList = originalEdit.DetailForSave

			CheckDisableControl(originalEdit)
			txtKontak.Properties.ReadOnly = True
			editAssign = False
		End If

		xGrid.DataSource = bindingList
		txtKontak.Focus()
	End Sub
	Overrides Sub SimpanData()
		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Simpan data exim ...")

				Dim instance As Persistent_Fusoh.Persistent_FusohExim
				If (Tipe = InputType.Tambah) Then
					instance = New Persistent_Fusoh.Persistent_FusohExim(session)
				Else
					instance = session.GetObjectByKey(Of Persistent_Fusoh.Persistent_FusohExim)(Convert.ToInt64(IdToEdit))
				End If
				Dim service = New Service_Fusoh.Service_FusohExim(session, originalEdit)

				'======= Simpan Main
				If txtKontak.EditValue Is Nothing Then
					instance.Vendor = Nothing
				Else
					instance.Vendor = CType(txtKontak.EditValue, Kontak)
				End If
				instance.Kode = txtNoTransaksi.Text
				instance.Tanggal = txtTanggal.DateTime
				If txtRegional.EditValue Is Nothing Then
					instance.Regional = Nothing
				Else
					instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
				End If
				If txtNoPO.EditValue Is Nothing Then
					instance.PO = Nothing
				Else
					instance.PO = CType(txtNoPO.EditValue, Persistent_Fusoh.Persistent_FusohOrderPembelian)
				End If
				instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)
				instance.DetailForSave = bindingList
				service.Save(instance)
			Catch ex As Utils.Exception
				Throw New Utils.Exception(ex)
			Catch ex As Exception
				Throw New Exception(ex.Message, ex.InnerException)
			Finally
				splashManager.CloseWaitForm()
			End Try
		End Using
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case 0 : txtStatus.Focus()
			Case -1 : txtRegional.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtKontak.Focus()
			Case -4 : txtNoPO.Focus()
			Case -5 : txtStatus.Focus()
			Case -99 : xGrid.Focus()
		End Select
	End Sub
End Class