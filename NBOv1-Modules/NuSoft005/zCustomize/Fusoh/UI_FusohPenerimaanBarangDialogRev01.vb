Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class UI_FusohPenerimaanBarangDialogRev01
  Private instance As Persistent.Fusoh_PenerimaanBarang
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of SettingRegional)
  Private detailToDelete As New List(Of Persistent.Fusoh_PenerimaanBarangDetail)
  Private editAssign As Boolean = False
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection
  'Private inv As List(Of Persistent.Fusoh_PenerimaanInvoice)

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.PenerimaanBarang.AutoSaveOnEndEdit = False
    Persistent.PenerimaanBarangDetail.AutoSaveOnEndEdit = False
    txtNoExim.Properties.DataSource = Nothing
    layTipe.Visibility = LayoutVisibility.Never
    AllowSave = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingpurchase = New Logic.PurchaseSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("GRTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("GRTransaksi.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Fusoh_PenerimaanBarang(session)
      'instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.Fusoh_PenerimaanBarang)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Vendor
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtGudang.EditValue = instance.Gudang
      txtUang.EditValue = instance.MataUang
      txtKurs.EditValue = instance.Kurs
      txtKaryawan.EditValue = instance.Karyawan
      txtUraian.Text = instance.Uraian
      txtNoExim.EditValue = instance.Exim
      txtStatus.EditValue = instance.StatusTransaksi

      '=========== serial ke temp
      For i = 0 To instance.Detail.Count - 1
        instance.Detail(i).DetailSerial_Temp = New List(Of Persistent.Fusoh_PenerimaanBarangDetailSerial_Temp)
        SetSerial(instance.Detail(i))
      Next

      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Penerimaan Barang : Tambah Data"
    Else
      Me.Text = "Penerimaan Barang : Edit Data " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl()
      End If
      If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
        DisableControl()
      End If
      If NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
        DisableControl()
      End If

      For Each detail In instance.Detail
        Dim daftarSerial = detail.DetailSerial.Select(Function(s) s.Serial).ToList
        Dim dempyou = New XPQuery(Of NuSoft004.Persistent.Fusoh_OrderProduksiBahanBaku)(session) _
                  .Where(Function(w) w.Barang Is detail.Barang AndAlso daftarSerial.Contains(w.Serial)).ToList
        If (dempyou.Count > 0) Then
          DisableControl()
          Exit For
        End If
      Next

      AllowSave = True
      txtTanggal.Enabled = True
      txtNoTransaksi.Enabled = True
      txtTanggal.Properties.ReadOnly = False
      txtNoTransaksi.Properties.ReadOnly = False

    End If
  End Sub
  Overrides Sub SimpanData()
		'If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
		'	Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
		'	Exit Sub
		'End If
		If Tipe = InputType.Tambah Then
			instance.Revisi = 0
		Else
			If MsgBox("Apakah anda ingin menambah revisi?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				instance.Revisi = instance.Revisi + 1
			End If
		End If



		Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
			Try
				splashManager.ShowWaitForm()
				splashManager.SetWaitFormCaption("Silahkan Tunggu")
				splashManager.SetWaitFormDescription("Simpan data penerimaan barang ...")

				For i = detailToDelete.Count - 1 To 0 Step -1
					detailToDelete(i).Delete()
				Next

				'======= Simpan Main
				If Not txtKontak.EditValue Is Nothing Then
					instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
				Else
					instance.Vendor = Nothing
				End If
				instance.Kode = txtNoTransaksi.EditValue
				instance.Tanggal = txtTanggal.DateTime
				instance.KontakPerson = txtKontakPerson.EditValue
				instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
				instance.Gudang = CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang)
				instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
				instance.Exim = CType(txtNoExim.EditValue, Persistent.Fusoh_Exim)
				instance.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
				instance.Kurs = CType(txtKurs.Text, Double)
				instance.Uraian = txtUraian.Text
				instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)

				Dim listPODetail = instance.Detail.Where(Function(w) Not w.EximDetail Is Nothing).Select(Function(x) x.EximDetail.PODetail).ToList.Where(Function(x) Not x Is Nothing).ToList
        'Dim listInvoice = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoiceDetail)(session).Where(Function(w) listPODetail.Contains(w.PODetail)).ToList
        For i = 0 To instance.Detail.Count - 1
					'======= start 19-03-10 ===== set harga beli
					Dim detGr = instance.Detail(i)
					Dim detailPO = detGr.EximDetail.PODetail
          Dim invDetail = detGr.EximDetail.RIDetail 'listInvoice.Find(Function(f) f.PODetail Is detailPO)

          If Not detailPO Is Nothing AndAlso invDetail Is Nothing Then '-- jika invoice belum diterima, buat harga beli dari harga order
            detGr.Harga = (detailPO.DPP / detailPO.Qty) * detailPO.Main.Kurs
          Else '-- jika invoice diterima, buat harga beli dari harga invoice
            detGr.Harga = invDetail.TotalPembelianIDR / detGr.Qty
					End If
					'======= end   19-03-10 ===== set harga beli

					'======== set serial dari temp
					Dim selected = instance.Detail(i).DetailSerial_Temp.Where(Function(w) w.State = 1).ToList
					For j = 0 To instance.Detail(i).DetailSerial.Count - 1
						Dim ser = instance.Detail(i).DetailSerial(j)
						Dim serialPersist = selected.Find(Function(f) f.Serial = ser.Serial)
						If serialPersist Is Nothing Then
							ser.Delete()
						End If
					Next

					For j = 0 To selected.Count - 1
						Dim ser = selected(j)
						Dim serialPersist = instance.Detail(i).DetailSerial.ToList.Find(Function(f) f.Serial = ser.Serial)
						If serialPersist Is Nothing Then
							serialPersist = New Persistent.Fusoh_PenerimaanBarangDetailSerial(session)
							serialPersist.DetailMain = ser.DetailMain
						End If
						serialPersist.LengthIn = ser.LengthIn
						serialPersist.Serial = ser.Serial
						serialPersist.MillSheet = ser.MillSheet
					Next
				Next

				If Not instance.Exim Is Nothing Then
					Dim xQtyPO As Double = instance.Exim.TotalQty
					Dim xQtyGR As Double = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim Is instance.Exim).Sum(Function(s) s.TotalQty)
					If (Tipe = InputType.Tambah) Then
						xQtyGR += instance.TotalQty
					End If

					If xQtyGR < xQtyPO Then
						instance.Exim.StatusTransaksi = StatusTransaksiEnum.InProgress
					Else
						instance.Exim.StatusTransaksi = StatusTransaksiEnum.Finish
					End If
				End If

				'======= Simpan instance
				session.CommitChanges()
				txtNoExim.Properties.DataSource = Nothing
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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Penerimaan Barang [GR] -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Penerimaan Barang [GR] -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try

		Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.CSIM, MainClass.reportName.zFusohVoucherGRN)
		frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherGRN)
    message = String.Format(message, "Penerimaan Barang [GRN]")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingpurchase.PreviewReport)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -3 : txtTanggal.Focus()
      Case -4 : txtKontak.Focus()
      Case -5 : txtGudang.Focus()
      Case -6 : txtKaryawan.Focus()
      Case -7 : txtStatus.Focus()
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
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtTipe.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.TipeTransaksi)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
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
    txtUraian.EditValue = settingpurchase.UraianGR
  End Sub
  Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.CSIM)
		'instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "[S][Y2]-[M0][X2]"} 'setting.FormatNomor} CSIM YY-MMxx
	End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtGudang.Enabled = False
    txtNoExim.Enabled = False
    txtKaryawan.Enabled = False
    txtStatus.Enabled = False
    txtKontakPerson.Enabled = False
    txtUraian.Enabled = False
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
    xGridView.OptionsBehavior.ReadOnly = True
    AllowSave = True
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

      Dim poDs As XPCollection(Of Persistent.Fusoh_Exim)
      Dim listCriteria As New List(Of CriteriaOperator)
      Dim listCriteria2 As New List(Of CriteriaOperator)
      If Tipe = InputType.Tambah Then
        Dim status As StatusTransaksiEnum = IIf(settingpurchase.ApprovalPO, StatusTransaksiEnum.Posting, StatusTransaksiEnum.Posting)
        listCriteria2.Add(New BinaryOperator("StatusTransaksi", status, BinaryOperatorType.Equal))
        listCriteria2.Add(New BinaryOperator("StatusTransaksi", StatusTransaksiEnum.InProgress, BinaryOperatorType.Equal))
        listCriteria.Add(New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))
        listCriteria.Add(New GroupOperator(GroupOperatorType.Or, listCriteria2))

        poDs = New XPCollection(Of Persistent.Fusoh_Exim)(session, New GroupOperator(GroupOperatorType.And, listCriteria))
      Else
        poDs = New XPCollection(Of Persistent.Fusoh_Exim)(session, New BinaryOperator("This", instance.Exim, BinaryOperatorType.Equal))
      End If
      poDs.DisplayableProperties = "PO.Kode;Tanggal;Kode;This"
      txtNoExim.Properties.DataSource = poDs
      'inv = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) w.Vendor Is e.NewValue).ToList

      xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_PenerimaanBarang)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))
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
      txtKurs.Text = NuSoft001.Logic.Kurs.getKursBank(session, instance.MataUang, txtTanggal.DateTime)
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub

  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    'If Not e.Value Is Nothing Then
    '	Dim row As Persistent.Fusoh_PenerimaanBarangDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_PenerimaanBarangDetail)
    '	If e.Column Is colQty Then
    '		If txtNoPO.EditValue Is Nothing Then
    '			Return
    '		End If

    '		Dim xDataPenerimaan As New XPCollection(Of Persistent.Fusoh_PenerimaanBarangDetail)(session, New BinaryOperator("Main.Exim", txtNoPO.EditValue, BinaryOperatorType.Equal))
    '		Dim terpakai = xDataPenerimaan.Where(Function(m) m.EximDetail Is row.EximDetail).Sum(Function(n) n.Qty)
    '		If Tipe = InputType.Edit Then
    '			Dim editedData = session.GetObjectByKey(Of Persistent.Fusoh_PenerimaanBarang)(Convert.ToInt64(IdToEdit))
    '			Dim qtyEdit = editedData.Detail.ToList.Find(Function(w) w.Id = row.Id).Qty
    '			terpakai -= qtyEdit
    '		End If
    '		Dim sisa = row.EximDetail.Qty - terpakai

    '		If e.Value > sisa Then
    '			MsgBox("Qty yang anda masukkan melebihi dari sisa order.", MsgBoxStyle.OkOnly, Me.Text)
    '			row.Qty = sisa
    '		End If
    '	End If
    '	row.Weight = row.Qty * NuSoft004.FusohLogic.Item.GetWeight(row.OutDiameter, row.Length, row.Thickness)
    '	SetSerial(row, Nothing)
    'End If
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.Fusoh_PenerimaanBarangDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_PenerimaanBarangDetail)
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
  Private Sub txtNoExim_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoExim.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim xDataPenerimaan = New XPQuery(Of Persistent.Fusoh_PenerimaanBarangDetail)(session).Where(Function(w) w.Main.Exim Is e.NewValue).ToList
      Dim item As Persistent.Fusoh_Exim = CType(e.NewValue, Persistent.Fusoh_Exim)
      Dim data As Persistent.Fusoh_PenerimaanBarangDetail

      If Not item.PO Is Nothing Then
        txtKontakPerson.EditValue = item.PO.KontakPerson
        txtGudang.EditValue = item.PO.Gudang
        txtUang.EditValue = item.PO.Uang
      Else
        Dim det0 = item.Detail(0)
        If Not det0 Is Nothing AndAlso Not det0.PODetail Is Nothing Then
          txtKontakPerson.EditValue = det0.PODetail.Main.KontakPerson
          txtGudang.EditValue = det0.PODetail.Main.Gudang
          txtUang.EditValue = det0.PODetail.Main.Uang
        End If
      End If
      instance.MataUang = CType(txtUang.EditValue, MataUang)
      txtKurs.Text = NuSoft001.Logic.Kurs.getKursBank(session, instance.MataUang, txtTanggal.DateTime)

      ' Hapus detail yang tidak ada di PO
      'For i = instance.Detail.Count - 1 To 0 Step -1
      '	Dim detail = instance.Detail(i)
      '	If item.Detail.ToList.Find(Function(m) m Is detail.EximDetail) Is Nothing Then
      '		detail.Delete()
      '	End If
      'Next
      session.Delete(instance.Detail)

      For i = 0 To item.Detail.Count - 1
        Dim detail = item.Detail(i)
        Dim qty = detail.Qty - xDataPenerimaan.Where(Function(m) m.EximDetail Is detail).Sum(Function(n) n.Qty)

        If qty > 0 Then
          'If instance.Detail.ToList.Find(Function(m) m.EximDetail Is detail) Is Nothing Then
          data = New Persistent.Fusoh_PenerimaanBarangDetail(session)
          data.EximDetail = detail
          data.Barang = data.EximDetail.Barang
          data.OutDiameter = data.EximDetail.OutDiameter
          data.InDiameter = data.EximDetail.InDiameter
          data.Thickness = data.EximDetail.Thickness
          data.Length = data.EximDetail.Length
          data.Qty = qty
          data.WeightR = data.EximDetail.Weight - xDataPenerimaan.Where(Function(m) m.EximDetail Is data.EximDetail).Sum(Function(n) n.Weight)
          data.Weight = data.WeightR

          data.Satuan = data.EximDetail.Satuan
          data.Catatan = data.EximDetail.Catatan
          instance.Detail.Add(data)

          data.DetailSerial_Temp = New List(Of Persistent.Fusoh_PenerimaanBarangDetailSerial_Temp)
          SetSerial(data)
          'End If
        End If
      Next
    End If
  End Sub
  Private Sub SetSerial(row As Persistent.Fusoh_PenerimaanBarangDetail)
    ''=== jika selected nothing alias otomatis
    'If selected Is Nothing Then
    '	selected = row.EximDetail.Detail.ToList
    '	'=== kurangi jumlah serial jika qty lebih kecil
    '	If row.Qty < row.DetailSerial_Temp.Count Then
    '		For i = row.DetailSerial_Temp.Count To row.Qty Step -1
    '			row.DetailSerial_Temp.Remove(row.DetailSerial_Temp(i - 1))
    '		Next
    '	End If
    'Else
    '	'=== kurangi jumlah serial jika qty lebih kecil
    '	If row.Qty < row.DetailSerial_Temp.Count Then
    '		For i = row.DetailSerial_Temp.Count - 1 To 0 Step -1
    '			Dim serial = row.DetailSerial_Temp(i)
    '			Dim find = selected.Find(Function(f) f.Serial = serial.Serial)
    '			If find Is Nothing Then
    '				row.DetailSerial_Temp.Remove(serial)
    '			End If
    '		Next
    '	End If
    'End If

    'Dim usedSerial = New XPQuery(Of Persistent.Fusoh_PenerimaanBarangDetailSerial)(session).Where(Function(w) w.DetailMain.EximDetail Is row.EximDetail) _
    '	.Select(Function(s) s.Serial).ToList
    ''Dim availableSerial = selected.Where(Function(w) Not usedSerial.Contains(w.Serial)).ToList

    'For i = 0 To row.Qty - 1
    '	Dim eximSerial = availableSerial(i)
    '	Dim serial = row.DetailSerial_Temp.Find(Function(f) f.Serial = eximSerial.Serial)
    '	If serial Is Nothing Then
    '		serial = New Persistent.Fusoh_PenerimaanBarangDetailSerial_Temp With {
    '				.DetailMain = row, .Serial = eximSerial.Serial, .MillSheet = eximSerial.MillSheet, .LengthIn = eximSerial.LengthIn
    '			}
    '		row.DetailSerial_Temp.Add(serial)
    '	End If
    'Next

    '=============== konsep baru
    Dim usedSerial = New XPQuery(Of Persistent.Fusoh_PenerimaanBarangDetailSerial)(session).Where(Function(w) w.DetailMain.EximDetail Is row.EximDetail) _
      .Select(Function(s) s.Serial).ToList
    Dim existingSerial As New List(Of String)
    If Tipe = InputType.Edit Then
      For j = 0 To row.DetailSerial.Count - 1
        existingSerial.Add(row.DetailSerial(j).Serial)
        usedSerial.Remove(row.DetailSerial(j).Serial)
      Next
    Else
      existingSerial.AddRange(row.EximDetail.Detail.Select(Function(s) s.Serial))
    End If

    For i = 0 To row.EximDetail.Detail.Count - 1
      Dim eximSerial = row.EximDetail.Detail(i)
      Dim serial = New Persistent.Fusoh_PenerimaanBarangDetailSerial_Temp With {
          .DetailMain = row, .Serial = eximSerial.Serial, .MillSheet = eximSerial.MillSheet, .LengthIn = eximSerial.LengthIn
        }
      If usedSerial.Exists(Function(e) e = serial.Serial) Then
        serial.State = 2
      ElseIf existingSerial.Exists(Function(e) e = serial.Serial) Then
        serial.State = 1
      Else
        serial.State = 0
      End If
      row.DetailSerial_Temp.Add(serial)
    Next
  End Sub

  'Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, Optional Proyek As NuSoft001.Persistent.Proyek = Nothing)
  '	Dim item As Persistent.GlMainDetail
  '	If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
  '		item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
  '	Else
  '		item = New Persistent.GlMainDetail(session)

  '		item.Akun = Akun
  '		item.MataUang = item.Akun.MataUang
  '		item.Main = instance.Gl
  '		item.Urutan = Urutan
  '		item.Debit = Debit
  '		item.Kredit = Kredit
  '		item.Kurs = 1
  '		item.DebitValas = 0
  '		item.KreditValas = 0
  '		item.Proyek = Proyek
  '		instance.Gl.Detail.Add(item)
  '	End If
  'End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub

  Private Sub colSerialRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colSerialRepo.ButtonClick
    Dim frm As New UI_FusohPenerimaanBarangDialogSerial
    frm.session = session

    Dim row As Persistent.Fusoh_PenerimaanBarangDetail
    row = CType(xGridView.GetFocusedRow, Persistent.Fusoh_PenerimaanBarangDetail)

    'Dim usedSerial = New XPQuery(Of Persistent.Fusoh_PenerimaanBarangDetailSerial)(session) _
    '	.Where(Function(w) w.DetailMain.EximDetail Is row.EximDetail) _
    '	.Select(Function(s) s.Serial).ToList

    'If Tipe = InputType.Edit Then
    '	For j = 0 To row.DetailSerial.Count - 1
    '		usedSerial.Remove(row.DetailSerial(j).Serial)
    '	Next
    'End If

    frm.LoadingData(row)
    If Not AllowSave Then
      frm.Disable()
    End If
    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
      row.Qty = row.DetailSerial_Temp.Where(Function(w) w.State = 1).Count 'frm.selectedRows.Count
      row.Weight = row.Qty * NuSoft004.FusohLogic.Item.GetWeight(row.OutDiameter, row.Length, row.Thickness)
    End If
  End Sub
End Class