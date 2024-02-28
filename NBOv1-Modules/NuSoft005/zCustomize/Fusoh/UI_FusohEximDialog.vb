Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class UI_FusohEximDialog
	Private instance As Persistent.Fusoh_Exim
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private settingpurchase As Logic.PurchaseSetting
	Private sumber As Persistent.SumberDataCollection

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
		Persistent.Fusoh_Exim.AutoSaveOnEndEdit = False
		Persistent.Fusoh_EximDetail.AutoSaveOnEndEdit = False
		Persistent.Fusoh_EximDetailSerial.AutoSaveOnEndEdit = False
		AllowSave = True
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		settingpurchase = New Logic.PurchaseSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("EXTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("EXTransaksi.xml"))
		End If
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("EXTransaksiGrid.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("EXTransaksiGrid.xml"))
		End If
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Fusoh_Exim(session)
			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.Fusoh_Exim)(Convert.ToInt64(IdToEdit))
			txtStatus.EditValue = instance.StatusTransaksi
			txtNoTransaksi.Text = instance.Kode
			txtTanggal.EditValue = instance.Tanggal
			txtKontak.EditValue = instance.Vendor
			txtNoPO.Properties.DataSource = New Persistent.Fusoh_OrderPembelian() {instance.PO}
			txtRegional.EditValue = instance.Regional
			txtNoPO.EditValue = instance.PO
			txtKontakPerson.EditValue = instance.PO.KontakPerson
			txtGudang.EditValue = instance.PO.Gudang
			txtPajak.EditValue = instance.PO.TipePajak
			txtVia.EditValue = instance.PO.Via
			txtFOB.EditValue = instance.PO.FOB
			txtTglBerlaku.DateTime = instance.PO.TanggalBerlaku
			txtLeadTime.Text = instance.PO.LeadTime
			txtUang.EditValue = instance.PO.Uang
			txtTermin.EditValue = instance.PO.Termin
			txtKaryawan.EditValue = instance.PO.Karyawan
			txtUraian.Text = instance.PO.Uraian
			txtCatatan.Text = instance.PO.Catatan
			txtReffNo.EditValue = instance.PO.ReffNo
			txtCustom1.EditValue = instance.PO.Custom1
			txtCustom2.EditValue = instance.PO.Custom2
			txtCustom3.EditValue = instance.PO.Custom3
			txtCustom4.EditValue = instance.PO.Custom4
			txtCustom5.EditValue = instance.PO.Custom5

			'=========== serial ke temp
			For i = 0 To instance.Detail.Count - 1
				instance.Detail(i).SerialTemp = New List(Of Persistent.Fusoh_EximDetailSerial_Temp)

				For j = 0 To instance.Detail(i).Detail.Count - 1
					Dim ser = instance.Detail(i).Detail(j)
					Dim serialPersist = New Persistent.Fusoh_EximDetailSerial_Temp
					serialPersist.Id = ser.Id
					serialPersist.Main = ser.Main
					serialPersist.Barang = ser.Barang
					serialPersist.LengthIn = ser.LengthIn
					serialPersist.Serial = ser.Serial
					serialPersist.MillSheet = ser.MillSheet
					instance.Detail(i).SerialTemp.Add(serialPersist)
				Next
			Next

			xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
			instance.Detail.CriteriaString = ""
			xGrid.DataSource = instance.Detail
			txtKontak.Properties.ReadOnly = True
			editAssign = False
		End If

		'xGridView.OptionsBehavior.Editable = False
		'xGridView.OptionsBehavior.ReadOnly = True
		SetNomor()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Exim : Tambah Data"
		Else
			Me.Text = "Exim : Edit Data " & instance.Kode
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
		If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.ReqApprove) Then
			Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
			Exit Sub
		End If

		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Simpan data exim ...")

				'======= Simpan Main
				If Not txtKontak.EditValue Is Nothing Then
					instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
				Else
					instance.Vendor = Nothing
				End If
				instance.Kode = txtNoTransaksi.Text
				instance.Tanggal = txtTanggal.DateTime
				instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
				instance.PO = CType(txtNoPO.EditValue, Persistent.Fusoh_OrderPembelian)
				instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
				instance.PO.StatusTransaksi = StatusTransaksiEnum.Finish

        Dim resultLog As String = ""
        '======== set serial dari temp
        For i = 0 To instance.Detail.Count - 1
          For j = 0 To instance.Detail(i).SerialTemp.Count - 1
            Dim ser = instance.Detail(i).SerialTemp(j)
            If String.IsNullOrEmpty(ser.Serial) Then
              Throw New Utils.Exception("Masukkan nomor serial", -99, "", Text)
            End If
            If String.IsNullOrEmpty(ser.MillSheet) Then
              Throw New Utils.Exception("Masukkan nomor millsheet", -99, "", Text)
            End If

            Dim serialPersist = instance.Detail(i).Detail.ToList.Find(Function(f) f.Id = ser.Id)
            If serialPersist Is Nothing Then
              serialPersist = New Persistent.Fusoh_EximDetailSerial(session)
              serialPersist.Main = ser.Main
            End If
            serialPersist.Barang = ser.Barang
            serialPersist.LengthIn = ser.LengthIn
            serialPersist.Serial = ser.Serial
            serialPersist.MillSheet = ser.MillSheet
            resultLog = resultLog & i & "/" & j & "-->" & ser.Barang.Kode & "~" & ser.Serial & vbCrLf
          Next
        Next
        txtLOG.Text = resultLog

        instance.Save()
        '======= Simpan instance
        session.CommitChanges()
        MsgBox("Proses Simpan Berhasil")
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

      '======= Simple log
      Try
        If Tipe = InputType.Tambah Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Exim [EX] -> " & instance.Kode)
        Else
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Exim [EX] -> " & instance.Kode)
        End If
        session.CommitChanges()
      Catch ex As Exception
      End Try
    End Using
    ''======= Konfirmasi Cetak Laporan
    'Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.PO)
    'frm.txtNoBukti1.EditValue = instance.Kode

    'Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    'Dim reportCode As String = ""
    'reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherPO)
    'message = String.Format(message, "Order Pembelian")

    'Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingpurchase.PreviewReport)
  End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtKontak.Focus()
			Case -4 : txtNoPO.Focus()
			Case -5 : txtStatus.Focus()
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
		If settingpurchase.FilterKontak = True Then
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", settingpurchase.TipeKontak, BinaryOperatorType.Equal))
		Else
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
		End If
		txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtGudang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(session)
		txtTermin.Properties.DataSource = New XPCollection(Of Persistent.Termin)(session)
		txtVia.Properties.DataSource = New XPCollection(Of Persistent.Via)(session)
		txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)

		txtFOB.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipeFOB))
		txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePajak))
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
	End Sub
	Private Sub SetFormat()
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
		txtFOB.EditValue = Persistent.eTipeFOB.Origin
		txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		txtGudang.EditValue = session.GetObjectByKey(Of NuSoft004.Persistent.Gudang)(settingpurchase.GudangDefault)
		txtUraian.EditValue = settingpurchase.UraianPO
		txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
		txtVia.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtVia)
		'txtGudang.EditValue = settingpurchase.
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.EX)
		'instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "IM[Y2]-[M0][X2]"} 'setting.FormatNomor}  IMYY-MMxx
	End Sub
	Private Sub DisableControl()
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

			'Dim criteriaExim As CriteriaOperator = New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal)
			'If Tipe = InputType.Edit Then
			'	criteriaExim = New GroupOperator(GroupOperatorType.And,
			'										 New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal),
			'										 New BinaryOperator("PO", instance.PO, BinaryOperatorType.NotEqual))
			'End If
			'Dim dataExim = New XPCollection(Of Persistent.Fusoh_Exim)(session, criteriaExim)
			'txtNoPO.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_OrderPembelian)(session, New GroupOperator(GroupOperatorType.And,
			'				New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal),
			'				New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}),
			'				New NotOperator(New InOperator("This", dataExim.Select(Function(m) m.PO)))))

			'======================= Khusus Tambah
			Dim dataExim = New XPQuery(Of Persistent.Fusoh_Exim)(session).Where(Function(w) w.Vendor Is e.NewValue).GroupBy(Function(g) g.PO).Select(Function(s) s.Key).ToList
			txtNoPO.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderPembelianDetail)(session).Where(Function(w) _
							w.Main.Vendor Is e.NewValue AndAlso Not dataExim.Contains(w.Main) AndAlso
							(w.Main.StatusTransaksi = StatusTransaksiEnum.Posting OrElse w.Main.StatusTransaksi = StatusTransaksiEnum.InProgress) AndAlso
							w.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Persediaan).GroupBy(Function(g) g.Main).Select(Function(s) s.Key).ToList

			xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_Exim)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))
			ResetDataPO()
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
	End Sub

	Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
	End Sub
	Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("POTransaksiGrid.xml"))
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
	Private Sub txtNoPO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoPO.EditValueChanging
		If Not e.NewValue Is Nothing And editAssign = False Then
			Dim PO As Persistent.Fusoh_OrderPembelian = CType(e.NewValue, Persistent.Fusoh_OrderPembelian)
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

			' Hapus detail yang tidak ada di PO
			'For i = instance.Detail.Count - 1 To 0 Step -1
			'	instance.Detail(i).Delete()
			'Next
			session.Delete(instance.Detail)

      ' Buat detail baru
      ' For i = 0 To PO.Detail.Count - 1
      For i = 0 To PO.Detail.Count - 1
        Dim detail = PO.Detail(i)
        Dim item = New Persistent.Fusoh_EximDetail(session) With {
            .Barang = detail.Barang,
            .Catatan = detail.Catatan,
            .InDiameter = detail.InDiameter,
            .Length = detail.Length,
            .Main = instance,
            .OutDiameter = detail.OutDiameter,
            .PODetail = detail,
            .Qty = detail.Qty,
            .Satuan = detail.Satuan,
            .Thickness = detail.Thickness,
            .Weight = detail.WeightManual '.Weight = detail.Weight
          }
        instance.Detail.Add(item)
        item.SerialTemp = New List(Of Persistent.Fusoh_EximDetailSerial_Temp)

        For j = 0 To item.Qty - 1
          'Dim serial = New Persistent.Fusoh_EximDetailSerial(session)
          Dim serial = New Persistent.Fusoh_EximDetailSerial_Temp
          serial.Id = j + 1
          serial.Barang = item.Barang
          serial.LengthIn = item.Length
          serial.Main = item
          serial.Serial = ""
          serial.MillSheet = ""
          item.SerialTemp.Add(serial)
        Next
      Next

      xGrid.DataSource = instance.Detail
		End If
	End Sub
	Private Sub ResetDataPO()
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
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub

	Private Sub colBarangRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colBarangRepo.ButtonClick
		Dim frm As New UI_FusohEximDialogSerial
    frm.NamaDatabase = Me.NamaDatabase
    frm.MenuId = Me.MenuId
    frm.session = session

    Dim row As Persistent.Fusoh_EximDetail
		row = CType(xGridView.GetFocusedRow, Persistent.Fusoh_EximDetail)
		frm.LoadingData(row)
		If Not AllowSave Then
			frm.Disable()
		End If
		frm.ShowDialog()
	End Sub
End Class