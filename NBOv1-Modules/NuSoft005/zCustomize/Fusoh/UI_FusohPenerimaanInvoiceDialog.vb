Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports DevExpress.XtraEditors.Controls

Friend Class UI_FusohPenerimaanInvoiceDialog
  Private instance As Persistent.Fusoh_PenerimaanInvoice
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.Fusoh_PenerimaanInvoiceDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection
  Private exim As List(Of Persistent.Fusoh_Exim)
  Private gr As List(Of Persistent.Fusoh_PenerimaanBarang)

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
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RITransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RITransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml"))
    End If
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
      Dim defaultDate = New DateTime()

      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.Fusoh_PenerimaanInvoice)(Convert.ToInt64(IdToEdit))
      txtKontak.EditValue = instance.Vendor
      txtKontakPerson.EditValue = instance.KontakPerson
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.StatusTransaksi
      txtNoPO.Properties.DataSource = New Persistent.Fusoh_OrderPembelian() {instance.NoOrder}

      txtNoPO.EditValue = instance.NoOrder
      txtNoInvoiceVendor.EditValue = instance.NoReffVendor
      txtKaryawan.EditValue = instance.Karyawan

      If instance.TanggalBerlaku <> defaultDate Then txtTglBerlaku.DateTime = instance.TanggalBerlaku
      txtTermin.EditValue = instance.Termin
      txtUang.EditValue = instance.Uang
      txtKurs.Text = instance.Kurs
      txtTipeTransaksi.EditValue = instance.TipeTransaksi
      txtPajak.EditValue = instance.TipePajak
      txtUraian.Text = instance.Catatan

      txtJenisPajak.EditValue = instance.JenisPajak
      txtNoPPN.Text = instance.NoSNPPN
			txtNoPPH.Text = instance.NoSNPPh
			LoadKuotaImpor(instance.Tanggal)

			If instance.ArrivedDate <> defaultDate Then txtArrivedDate.DateTime = instance.ArrivedDate
      If instance.BLDate <> defaultDate Then txtBLDate.DateTime = instance.BLDate

      Dim listCriteria As New List(Of CriteriaOperator)
      Dim listCriteria2 As New List(Of CriteriaOperator)
      Dim listCriteria3 As New List(Of CriteriaOperator)
      Dim listCriteria4 As New List(Of CriteriaOperator)

      '============== EXIM DOMESTIK && STATUS FINISH || EXIM INTL && STATUS POSTING | INPROGRESS
      listCriteria3.Add(New BinaryOperator("PO.DariDomestik", True))
      listCriteria3.Add(New BinaryOperator("StatusTransaksi", StatusTransaksiEnum.Finish, BinaryOperatorType.Equal))
      listCriteria4.Add(New BinaryOperator("PO.DariDomestik", False))
      listCriteria4.Add(New InOperator("StatusTransaksi", New StatusTransaksiEnum() {StatusTransaksiEnum.Posting, StatusTransaksiEnum.InProgress, StatusTransaksiEnum.Finish}))
      listCriteria2.Add(New GroupOperator(GroupOperatorType.And, listCriteria3))
      listCriteria2.Add(New GroupOperator(GroupOperatorType.And, listCriteria4))
      listCriteria.Add(New BinaryOperator("Vendor", instance.Vendor, BinaryOperatorType.Equal))
      listCriteria.Add(New GroupOperator(GroupOperatorType.Or, listCriteria2))

      exim = New XPCollection(Of Persistent.Fusoh_Exim)(session, New GroupOperator(GroupOperatorType.And, listCriteria)).ToList
      gr = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Vendor Is instance.Vendor).ToList
      xGrid.DataSource = instance.Detail
      editAssign = False
      HitungTotal()
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Penerimaan Invoice [RI] : Tambah Data"
    Else
      Me.Text = "Penerimaan Invoice [RI] : Edit Data " & instance.Kode
      'If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
      '	DisableControl()
      'End If
      'If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
      '  DisableControl()
      'End If
      If NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
        DisableControl()
      End If
      'cek untuk edit hanya boleh sebagian kontrol ketika bukan pending
      'If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
      '  DisableControl2()
      'End If
    End If
  End Sub
  Overrides Sub SimpanData()
    If Tipe = InputType.Tambah Then
      If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
        Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
        Exit Sub
      End If
    End If
    If MsgBox("Apakah kurs yang anda masukkan sudah benar?", vbYesNo, "Konfirmasi") = MsgBoxResult.No Then
      Throw New Utils.Exception("Silahkan benahi kurs anda.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

		If Tipe = InputType.Tambah Then
			instance.Revisi = 0
		Else
			If MsgBox("Apakah anda ingin menambah revisi?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				instance.Revisi = instance.Revisi + 1
			End If
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


        'If txtNoPO.EditValue Is Nothing Then
        If Len(txtNoPO.Text) = 0 Then
          instance.NoOrder = Nothing
        Else
          instance.NoOrder = CType(txtNoPO.EditValue, Persistent.Fusoh_OrderPembelian)
          instance.NoExim = exim.Find(Function(f) f.PO Is instance.NoOrder)
          If Not instance.NoExim Is Nothing Then
            For i = 0 To instance.Detail.Count - 1
              Dim invDetail = instance.Detail(i)
              invDetail.EximDetail = instance.NoExim.Detail.ToList.Find(Function(f) f.PODetail Is invDetail.PODetail)
            Next
          End If
        End If
        instance.NoReffVendor = txtNoInvoiceVendor.Text
        instance.Karyawan = CType(txtKaryawan.EditValue, Kontak)

        instance.TanggalBerlaku = txtTglBerlaku.DateTime
        instance.Termin = CType(txtTermin.EditValue, Persistent.Termin)
        instance.Uang = CType(txtUang.EditValue, MataUang)
        instance.Kurs = CType(txtKurs.Text, Double)
        instance.TipeTransaksi = CType(txtTipeTransaksi.EditValue, Persistent.eTipeInvoicePembelian)
        instance.TipePajak = CType(txtPajak.EditValue, Persistent.eTipePajak)
        instance.Catatan = txtUraian.Text

        instance.JenisPajak = CType(txtJenisPajak.EditValue, Persistent.eJenisPajak)
        instance.NoSNPPN = txtNoPPN.Text
        instance.NoSNPPh = txtNoPPH.Text
        If txtArrivedDate.EditValue Is Nothing Then
          instance.ArrivedDate = Nothing
        Else
          instance.ArrivedDate = txtArrivedDate.DateTime
        End If
        If txtBLDate.EditValue Is Nothing Then
          instance.BLDate = Nothing
        Else
          instance.BLDate = txtBLDate.DateTime
        End If
        instance.Save()

        '======= start 19-03-10 ===== set harga beli
        If Not instance.NoOrder Is Nothing AndAlso instance.NoOrder.DariDomestik = True Then
          Dim daftarGr = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim.PO Is instance.NoOrder).ToList
          Dim singleGr = daftarGr(0)
          If Not gr Is Nothing Then '-- jika sudah diterima barang nya, buat ulang harga beli dari harga invoice
            For Each detGr In singleGr.Detail
              Dim detInvoice = instance.Detail.ToList.Find(Function(f) f.PODetail Is detGr.EximDetail.PODetail)
              'detGr.Harga = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
              detGr.Main.Kurs = 1
              'MsgBox(detInvoice.TotalPembelianIDR.ToString("n2") & "-->" & detInvoice.TotalIDR.ToString("n2") & "+ " & detInvoice.TotalCostIDR.ToString("n2"))
              detGr.Harga = detInvoice.TotalPembelianIDR / detGr.Qty
            Next
          End If
          '======= end   19-03-10 ===== set harga beli
          '=== edit jali : 13 jan 21, reset GR untuk semua domestik maupun impor. karena ada edit nilai impor duty
        ElseIf Not instance.NoOrder Is Nothing AndAlso instance.NoOrder.DariDomestik = False Then 'jika termasuk impor
          Dim daftarGr = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim.PO Is instance.NoOrder).ToList
          If Not daftarGr Is Nothing Then '-- jika sudah diterima barang nya, buat ulang harga beli dari harga invoice
            For pi = 0 To daftarGr.Count - 1
              Dim singleGr = daftarGr(pi)
              For Each detGr In singleGr.Detail
                Dim detInvoice = instance.Detail.ToList.Find(Function(f) f.PODetail Is detGr.EximDetail.PODetail)
                'detGr.Harga = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
                detGr.Main.Kurs = 1
                'MsgBox(detInvoice.TotalPembelianIDR.ToString("n2") & "-->" & detInvoice.TotalIDR.ToString("n2") & "+ " & detInvoice.TotalCostIDR.ToString("n2"))
                detGr.Harga = detInvoice.TotalPembelianIDR / detGr.Qty
              Next
            Next
          End If
        End If

        'update status penerimaan
        If Not instance.NoOrder Is Nothing Then
          If instance.NoExim Is Nothing Then
            '=========== Jasa
            Dim xQtyPO As Double = instance.NoOrder.TotalQty
            Dim xQtyInv As Double = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) w.NoOrder Is instance.NoOrder).Sum(Function(s) s.TotalQty)
            If (Tipe = InputType.Tambah) Then
              xQtyInv += instance.TotalQty
            End If
            If xQtyInv < xQtyPO Then
              instance.NoOrder.StatusTransaksi = StatusTransaksiEnum.InProgress
            Else
              instance.NoOrder.StatusTransaksi = StatusTransaksiEnum.Finish
            End If
          Else
            If Not instance.NoExim Is Nothing Then
              Dim xQtyExim As Double = instance.NoExim.TotalQty
              Dim xQtyInv As Double = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) w.NoExim Is instance.NoExim).Sum(Function(s) s.TotalQty)
              If (Tipe = InputType.Tambah) Then
                xQtyInv += instance.TotalQty
              End If
              Dim status As StatusTransaksiEnum
              If xQtyInv < xQtyExim Then
                status = StatusTransaksiEnum.InProgress
              Else
                status = StatusTransaksiEnum.Finish
              End If

              '======== jika domestik, update status penerimaan barang
              If instance.NoOrder.DariDomestik Then
                If gr.Count > 0 Then
                  Dim findAll = gr.FindAll(Function(f) f.Exim Is instance.NoExim)
                  For Each x In findAll
                    x.StatusTransaksi = status
                  Next
                End If
              Else
                '======== jika intl, update status exim
                instance.NoExim.StatusTransaksi = status
              End If
            End If
          End If
        End If

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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Penerimaan Invoice [RI] -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Penerimaan Invoice [RI] -> " & instance.Kode)
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
      Case -5 : txtNoPO.Focus()
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
    colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)(session, New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanBaku, BinaryOperatorType.Equal))
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
    colTotalCostImportDuty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotalCostImportDuty.DisplayFormat.FormatString = setting.NumericFormatToString
    colTotalCostImportDuty.SummaryItem.DisplayFormat = setting.NumericFormatString

    colHargaKG.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHargaKG.SummaryItem.DisplayFormat = setting.NumericFormatString
    colWeight.SummaryItem.DisplayFormat = setting.NumericFormatString
    colWeight.SummaryItem.DisplayFormat = setting.NumericFormatString



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
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtTipeTransaksi.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipeTransaksi)
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    txtUraian.EditValue = settingpurchase.UraianRI
    txtJenisPajak.EditValue = Persistent.eJenisPajak.Penggantian
    SetTipeTransaksi(txtTipeTransaksi.EditValue)
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.RI)
		'instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "IMV[Y2]-[M0][X2]"} 'setting.FormatNomor}  IMVYY-MMxx
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

    txtNoPO.Enabled = False
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

    txtArrivedDate.Enabled = False
    txtBLDate.Enabled = False

    xGridView.OptionsBehavior.Editable = False
    AllowSave = False
  End Sub
  Private Sub DisableControl2()
    txtKontak.Enabled = False
    txtKontakPerson.Enabled = False
    txtTanggal.Enabled = False
    txtRegional.Enabled = False
    txtNoTransaksi.Enabled = False
    txtStatus.Enabled = False
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True

    txtNoPO.Enabled = False
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

    txtArrivedDate.Enabled = False
    txtBLDate.Enabled = False
    txtArrivedDate.Enabled = False

    xGridView.OptionsBehavior.Editable = True
    colKode.OptionsColumn.ReadOnly = True
    colKode.OptionsColumn.AllowEdit = False
    colKodeBarang.OptionsColumn.ReadOnly = True
    colKodeBarang.OptionsColumn.AllowEdit = False
    colQty.OptionsColumn.ReadOnly = True
    colQty.OptionsColumn.AllowEdit = False
    colHarga.OptionsColumn.ReadOnly = True
    colHarga.OptionsColumn.AllowEdit = False
    colSatuan.OptionsColumn.ReadOnly = True
    colSatuan.OptionsColumn.AllowEdit = False
    colCatatan.OptionsColumn.ReadOnly = True
    colCatatan.OptionsColumn.AllowEdit = False

    colTotalCostImportDuty.OptionsColumn.ReadOnly = False
    colTotalCostImportDuty.OptionsColumn.AllowEdit = True

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
						LoadKuotaImpor(instance.Tanggal)
					Else
						txtTanggal.EditValue = instance.Tanggal
          End If
        Else
          instance.Tanggal = txtTanggal.DateTime
					'ChangeCode()
					LoadKuotaImpor(instance.Tanggal)
				End If
			ElseIf Tipe = InputType.Tambah Then
        instance.Tanggal = txtTanggal.DateTime
        ChangeCode()
				LoadKuotaImpor(instance.Tanggal)
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

      If editAssign Then Exit Sub
      Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
        Try
          splashManager.ShowWaitForm()
          splashManager.SetWaitFormCaption("Silahkan Tunggu")
          splashManager.SetWaitFormDescription("Loading data PO ...")

          Dim listCriteria As New List(Of CriteriaOperator)
          Dim listCriteria2 As New List(Of CriteriaOperator)
          Dim listCriteria3 As New List(Of CriteriaOperator)
          Dim listCriteria4 As New List(Of CriteriaOperator)

          Dim dsPO = New List(Of Persistent.Fusoh_OrderPembelian)
          If Tipe = InputType.Tambah Then
            '=============== PO JASA
            Dim dataPo = New XPQuery(Of Persistent.Fusoh_OrderPembelian)(session).Where(Function(w) _
              w.Vendor Is e.NewValue AndAlso
              (w.StatusTransaksi = StatusTransaksiEnum.Posting OrElse w.StatusTransaksi = StatusTransaksiEnum.InProgress)
              ).ToList
            For Each poJ In dataPo
              If Not poJ.Detail.Where(Function(w) w.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Persediaan).Count > 0 Then
                dsPO.Add(poJ)
              End If
            Next

            '============== EXIM DOMESTIK && STATUS FINISH || EXIM INTL && STATUS POSTING | INPROGRESS
            listCriteria3.Add(New BinaryOperator("PO.DariDomestik", True))
            listCriteria3.Add(New BinaryOperator("StatusTransaksi", StatusTransaksiEnum.Finish, BinaryOperatorType.Equal))
            listCriteria4.Add(New BinaryOperator("PO.DariDomestik", False))
            listCriteria4.Add(New InOperator("StatusTransaksi", New StatusTransaksiEnum() {StatusTransaksiEnum.Posting, StatusTransaksiEnum.InProgress}))
            listCriteria2.Add(New GroupOperator(GroupOperatorType.And, listCriteria3))
            listCriteria2.Add(New GroupOperator(GroupOperatorType.And, listCriteria4))
            listCriteria.Add(New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))
            listCriteria.Add(New GroupOperator(GroupOperatorType.Or, listCriteria2))

            exim = New XPCollection(Of Persistent.Fusoh_Exim)(session, New GroupOperator(GroupOperatorType.And, listCriteria)).ToList
            dsPO.AddRange(exim.Select(Function(s) s.PO))

            If txtTipeTransaksi.EditValue = Persistent.eTipeInvoicePembelian.PakaiPO Then
              session.Delete(instance.Detail)
            End If
          Else
            exim = New XPQuery(Of Persistent.Fusoh_Exim)(session).Where(Function(w) w.Vendor Is e.NewValue).ToList
            dsPO.Add(instance.NoOrder)
          End If
          gr = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Vendor Is e.NewValue).ToList

          txtNoPO.Properties.DataSource = dsPO
          txtNoPO.EditValue = Nothing
        Catch ex As Utils.Exception
          Throw New Utils.Exception(ex)
        Catch ex As Exception
          Throw New Exception(ex.Message, ex.InnerException)
        Finally
          splashManager.CloseWaitForm()
        End Try
      End Using
    End If
  End Sub
  Private Sub txtNoPO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoPO.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim xDataPO As Persistent.Fusoh_OrderPembelian = CType(e.NewValue, Persistent.Fusoh_OrderPembelian)

      txtKontakPerson.EditValue = xDataPO.KontakPerson
      txtPajak.EditValue = xDataPO.TipePajak
      txtUang.EditValue = xDataPO.Uang
      txtTermin.EditValue = xDataPO.Termin
      txtKaryawan.EditValue = xDataPO.Karyawan
      instance.TipePajak = xDataPO.TipePajak
      SetKurs(txtUang.EditValue)
      If Not txtTermin.EditValue Is Nothing Then
        txtTglBerlaku.EditValue = DateAdd(DateInterval.Day, CType(txtTermin.EditValue, Persistent.Termin).Tempo, txtTanggal.DateTime)
      End If

      instance.NoOrder = xDataPO
      instance.NoExim = exim.Find(Function(f) f.PO Is instance.NoOrder)




      session.Delete(instance.Detail)
      Dim xInvDetail = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoiceDetail)(session).Where(Function(w) w.Main.NoOrder Is xDataPO).Select(Function(s) s.PODetail).ToList
      Dim xDataGR = xDataPO.Detail.Where(Function(w) Not xInvDetail.Contains(w))
      For i = 0 To xDataGR.Count - 1
        Dim Data = New Persistent.Fusoh_PenerimaanInvoiceDetail(session)
        Data.Barang = xDataGR(i).Barang
        Data.PODetail = xDataGR(i)
        Data.Qty = xDataGR(i).Qty
        Data.Satuan = xDataGR(i).Satuan
        Data.Harga = xDataGR(i).Harga
        Data.DiscountPersen = 0
        Data.Discount = 0
        Data.PPN = xDataGR(i).PPN
        Data.PPNp = xDataGR(i).PPNp
        Data.PPH = xDataGR(i).PPH
        Data.PPHp = xDataGR(i).PPHp
        Data.Catatan = xDataGR(i).Catatan
        Data.KenaImportDuty = Data.Barang.KenaImportDuty
        Data.KuotaImport = xDataGR(i).KuotaImpor

        If Not instance.NoExim Is Nothing Then
          Dim invDetail = Data
          invDetail.EximDetail = instance.NoExim.Detail.ToList.Find(Function(f) f.PODetail Is invDetail.PODetail)
        End If

        instance.Detail.Add(Data)
      Next
      HitungTotal()
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
          row.KenaImportDuty = xbarang.KenaImportDuty
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

  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      instance.TipePajak = CType(e.NewValue, Persistent.eTipePajak)
      xGrid.RefreshDataSource()
      HitungTotal()
    End If
  End Sub

  Private Sub txtTipeTransaksi_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTipeTransaksi.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      SetTipeTransaksi(CType(e.NewValue, Persistent.eTipeInvoicePembelian))
    End If
  End Sub
  Private Sub SetTipeTransaksi(xTipe As Persistent.eTipeInvoicePembelian)
    If xTipe = Persistent.eTipeInvoicePembelian.PakaiPO Then
      txtPajak.Properties.ReadOnly = True
      txtUang.Properties.ReadOnly = True
      txtNoPO.Enabled = True
      xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
      'xGridView.OptionsBehavior.ReadOnly = True
      colKodeBarang.OptionsColumn.AllowEdit = False
      colNamaBarang.OptionsColumn.AllowEdit = False
      colQty.OptionsColumn.AllowEdit = False
      colSatuan.OptionsColumn.AllowEdit = False
      colHarga.OptionsColumn.AllowEdit = False
      colPPN.OptionsColumn.AllowEdit = False
      colPPH.OptionsColumn.AllowEdit = False
      colTotal.OptionsColumn.AllowEdit = False
      colCatatan.OptionsColumn.AllowEdit = False
      session.Delete(instance.Detail)
    Else
      txtPajak.Properties.ReadOnly = False
      txtUang.Properties.ReadOnly = False
      txtNoPO.Enabled = False
      txtNoPO.EditValue = Nothing
      xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
      'xGridView.OptionsBehavior.ReadOnly = False
      colKodeBarang.OptionsColumn.AllowEdit = True
      colNamaBarang.OptionsColumn.AllowEdit = True
      colQty.OptionsColumn.AllowEdit = True
      colSatuan.OptionsColumn.AllowEdit = True
      colHarga.OptionsColumn.AllowEdit = True
      colPPN.OptionsColumn.AllowEdit = True
      colPPH.OptionsColumn.AllowEdit = True
      colTotal.OptionsColumn.AllowEdit = True
      colCatatan.OptionsColumn.AllowEdit = True
    End If
    HitungTotal()
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

	Private Sub LoadKuotaImpor(tanggal As Date)
		Dim xp = New XPCollection(Of Persistent.Fusoh_KuotaImpor)(session,
													New BinaryOperator("Expired", tanggal.Date, BinaryOperatorType.GreaterOrEqual))

		If Tipe = InputType.Tambah Then
			Dim xp2 = New XPCollection(Of Persistent.Fusoh_KuotaImpor)(session, New GroupOperator(GroupOperatorType.And,
												 New BinaryOperator("Expired", tanggal.Date, BinaryOperatorType.GreaterOrEqual)))
			colNoHSRepo.DataSource = xp2
		Else
			'Dim ddd = instance.Detail.Select(Function(s) s.KuotaImport)
			'colKuotaImporRepo2.DataSource = xp.Where(Function(w) w.SisaVolume > 0 Or ddd.Contains(w))
			'colKuotaImporRepo2.DataSource = xp.Where(Function(w) ddd.Contains(w))

			Dim xp3 = New XPCollection(Of Persistent.Fusoh_KuotaImpor)(session)
			colNoHSRepo.DataSource = xp3
		End If
	End Sub
End Class