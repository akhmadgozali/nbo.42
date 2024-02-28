Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls

Friend Class UI_zNishiInvoicePenjualanDialog
  Private instance As Persistent.NishiInvoice
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.NishiInvoiceDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.NishiInvoice.AutoSaveOnEndEdit = False
    Persistent.NishiInvoiceDetail.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVTransaksi.xml")) = True Then
    '  lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVTransaksi.xml"))
    'End If
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml")) = True Then
    '  xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml"))
    'End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.NishiInvoice(session)
      instance.TipePajak = NuSoft005.Persistent.eTipePajak.HargaBelumTermasuk
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.NishiInvoice)(Convert.ToInt64(IdToEdit))
      'load nomor SO kembali
      'txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", instance.Pelanggan, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress, NuSoft001.Persistent.StatusTransaksiEnum.Finish})))

      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Pelanggan
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtTglBerlaku.DateTime = instance.TanggalBerlaku
      txtUang.EditValue = instance.Uang
      txtKurs.Text = instance.Kurs
      txtTermin.EditValue = instance.Termin
      txtUraian.Text = instance.Catatan

      txtTermin.EditValue = instance.Termin
      txtTglBerlaku.EditValue = instance.TanggalBerlaku
      txtNoJO.EditValue = instance.JobOrder
      If Not instance.JobOrder Is Nothing Then
        txtNOBL.Text = instance.JobOrder.d_blno
      End If
      txtStatus.EditValue = instance.StatusTransaksi
      txtAdministrasi.EditValue = instance.BiayaAdministrasi
      txtjenis.EditValue = instance.JenisInvoice
      'txtQuotation.EditValue = instance.a

      xGrid.DataSource = instance.Detail
      SetLayoutGrid(instance.JenisInvoice)
      editAssign = False
    End If
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

    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    'MsgBox("Tipe data : " & Tipe.ToString())

    Try
      '======= Simpan Main
      If Tipe = InputType.Tambah Then
        txtNoTransaksi.EditValue = instance.Number.GetNewNumber.Kode
      End If


      If Not txtKontak.EditValue Is Nothing Then
        instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Pelanggan = Nothing
      End If
      instance.JobOrder = CType(txtNoJO.EditValue, NuSoft004.Persistent.NishiOrderPembelian)
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Kurs = CType(txtKurs.Text, Double)
      instance.Termin = CType(txtTermin.EditValue, NuSoft005.Persistent.Termin)
      instance.TanggalBerlaku = txtTglBerlaku.DateTime
      instance.Catatan = txtUraian.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.BiayaAdministrasi = txtAdministrasi.EditValue
      instance.JenisInvoice = CType(txtjenis.EditValue, NuSoft004.Persistent.NishiJenisInvoice)
      'buatkan jurnalnya
      instance.Gl.Sumber = instance.Sumber
      instance.Gl.Tanggal = txtTanggal.EditValue
      instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gl.Kode = instance.Kode
      instance.Gl.ModuleId = NPO.Modules.ModuleId.Purchase
      instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
      instance.Gl.Kurs = txtKurs.EditValue
      instance.Gl.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.Gl.KontakNama = txtKontak.Text
      instance.Gl.Uraian = txtUraian.Text

      Dim xCoaPiutang As NuSoft001.Persistent.Coa, pRegional As Persistent.xRegional
      'Piutang Dagang  (D) 
      pRegional = session.GetObjectByKey(Of Persistent.xRegional)(CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id)
      If salesSetting.SetingARRegional = False Then
        xCoaPiutang = instance.Uang.PiutangDagang
      Else
        xCoaPiutang = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(pRegional.CoaAR))
      End If
      Dim i As Byte = 1
      SimpanGL(xCoaPiutang, i, instance.Total * instance.Kurs, 0, instance.Total, 0)
      i = i + 1


      If instance.PPH > 0 Then      'PPH (D)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPH)), i, instance.PPH * instance.Kurs, 0, 0, 0)
        i = i + 1
      End If
      If instance.PPN > 0 Then      'PPN (K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPN)), i, 0, instance.PPN * instance.Kurs, 0, 0)
        i = i + 1
      End If

      If instance.BiayaAdministrasi > 0 Then      'Biya Admin (K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaBiayaLain)), i, 0, instance.BiayaAdministrasi * instance.Kurs, 0, 0)
        i = i + 1
      End If

      'Pendapatan (K) -> ambilkan dari seting coa master
      Dim b = From z In instance.Detail Group z By z.Barang.CoaIncome Into Group Select CoaIncome, SubTotal = Group.Sum(Function(x) x.DPP * x.Main.Kurs)
      For Each x In b
        SimpanGL(x.CoaIncome, i, 0, x.SubTotal, 0, 0)
        i = i + 1
      Next

      ''coba tampilkan dulu.
      'Dim xMessage As String = ""
      'MsgBox("Jumlahnya adalah :" & instance.Gl.Detail.Count - 1)
      'For i = 0 To instance.Gl.Detail.Count - 1
      '  xMessage += i & ":" & instance.Gl.Detail(i).Akun.Nama.ToString & " " & instance.Gl.Detail(i).Debit.ToString & "~" & instance.Gl.Detail(i).Kredit.ToString & vbCrLf
      'Next
      'MsgBox(xMessage)


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
    '======= Konfirmasi Cetak Laporan
    Dim frm As New RF_zNishiVoucher(Persistent.SumberDataJenis.IV, MainClass.reportName.zNishiVoucherIV)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zNishiVoucherIV)
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
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtTermin.Properties.DataSource = New XPCollection(Of NuSoft005.Persistent.Termin)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    txtjenis.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft004.Persistent.NishiJenisInvoice))
    colPPNRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    colPPHRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    colKodeBarangRepo1.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session, New BinaryOperator("Jenis", NuSoft004.Persistent.JenisBarang.Jasa, BinaryOperatorType.Equal))
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = "n2"
    colHari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHari.DisplayFormat.FormatString = setting.NumericFormatToString
    colHari.SummaryItem.DisplayFormat = setting.NumericFormatString
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
    txtAdministrasi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtAdministrasi.Properties.Mask.EditMask = setting.NumericFormatToString
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
    txtKurs.Text = 1
    txtAdministrasi.EditValue = 0
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtUraian.EditValue = salesSetting.UraianIV
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))

    txtjenis.EditValue = NuSoft004.Persistent.NishiJenisInvoice.Dok
    SetLayoutGrid(NuSoft004.Persistent.NishiJenisInvoice.Dok)
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.IV)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtUraian.Enabled = False
    txtUang.Enabled = False
    txtKurs.Enabled = False
    txtKontakPerson.Enabled = False
    txtNoInvoiceVendor.Enabled = False
    txtTglBerlaku.Enabled = False
    txtTermin.Enabled = False
    txtNoJO.Enabled = False
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

      txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))

      'If instance.NoOrder Is Nothing Then
      '  txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(Session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Sumber", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal), New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New BinaryOperator("StatusTransaksi", NuSoft001.Persistent.StatusTransaksiEnum.Posting))).GroupBy(Function(m) m.NoOrder).Select(Function(m) m.Key)
      'Else
      'txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(Session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Sumber", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal), New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})), New BinaryOperator("NoOrder", instance.NoOrder.Id, BinaryOperatorType.Equal))).GroupBy(Function(m) m.NoOrder).Select(Function(m) m.Key)
      'End If

      txtNoJO.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))
      colSuratJalanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.NishiStockMain)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))
      txtQuotation.Properties.DataSource = New XPCollection(Of Persistent.NishiQuotation)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))

      Dim xpTransaksi As New XPCollection(Of Persistent.NishiInvoice)(session, New BinaryOperator("Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
      xGHistory.DataSource = xpTransaksi
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
  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
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
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "")
    Dim item As Persistent.GlMainDetail
    If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
    Else
      item = New Persistent.GlMainDetail(session)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Keterangan = Catatan
      If Akun.MataUang.Id = setting.MultiMataUangDefault Then
        item.DebitValas = 0
        item.KreditValas = 0
        item.Kurs = 1
      Else
        item.DebitValas = DebitValas
        item.KreditValas = KreditValas
        item.Kurs = txtKurs.EditValue
      End If
      instance.Gl.Detail.Add(item)
    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.NishiInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.NishiInvoiceDetail)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
          row.Satuan = xbarang.Satuan
          row.Harga = xbarang.HargaJual1
          row.Discount = (row.DiscountPersen / 100) * (row.Qty * row.Harga)
          row.PPN = xbarang.PajakIN
          row.PPH = xbarang.PajakOUT
          row.PPNp = xbarang.PajakIN.NilaiPajak
          row.PPHp = xbarang.PajakOUT.NilaiPajak
        End If
      ElseIf e.Column Is colPPN Then
        If Not row Is Nothing Then
          Dim xPajak As NuSoft004.Persistent.Pajak = CType(e.Value, NuSoft004.Persistent.Pajak)
          row.PPNp = xPajak.NilaiPajak
        End If
      ElseIf e.Column Is colPPh Then
        If Not row Is Nothing Then
          Dim xPajak As NuSoft004.Persistent.Pajak = CType(e.Value, NuSoft004.Persistent.Pajak)
          row.PPHp = xPajak.NilaiPajak
        End If
      End If
      HitungTotal()
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.NishiInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.NishiInvoiceDetail)
    row.Barang = Nothing
    row.Hari = 1
    row.Qty = 1
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.NishiInvoiceDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.NishiInvoiceDetail)
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
  Sub SetLayoutGrid(xJenis As NuSoft004.Persistent.NishiJenisInvoice)
    Select Case xJenis
      Case NuSoft004.Persistent.NishiJenisInvoice.Dok : colHari.Visible = False : colBL.Visible = False : colSuratJalan.Visible = False : colTruck.Visible = False
      Case NuSoft004.Persistent.NishiJenisInvoice.Gudang : colHari.Visible = True : colBL.Visible = False : colSuratJalan.Visible = False : colTruck.Visible = False
      Case NuSoft004.Persistent.NishiJenisInvoice.Truck : colHari.Visible = False : colBL.Visible = True : colSuratJalan.Visible = True : colTruck.Visible = True
    End Select
  End Sub
  Private Sub txtjenis_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtjenis.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As NuSoft004.Persistent.NishiJenisInvoice = CType(e.NewValue, NuSoft004.Persistent.NishiJenisInvoice)
      SetLayoutGrid(item)
    End If
  End Sub
  Private Sub txtNoJO_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtNoJO.EditValueChanging
    If Not e.NewValue Is Nothing Then
      txtNOBL.Text = CType(e.NewValue, NuSoft004.Persistent.NishiOrderPembelian).d_blno
    End If
  End Sub
  Private Sub txtAdministrasi_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtAdministrasi.EditValueChanging
    If Not e.NewValue Is Nothing Then
      'instance.BiayaAdministrasi = CType(e.NewValue, Double)
      HitungTotal()
    End If
  End Sub
  Private Sub txtAdministrasi_EditValueChanged(sender As Object, e As EventArgs) Handles txtAdministrasi.EditValueChanged
    instance.BiayaAdministrasi = txtAdministrasi.EditValue
    HitungTotal()
  End Sub

  Private Sub txtQuotation_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtQuotation.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim item As Persistent.NishiQuotation = CType(e.NewValue, Persistent.NishiQuotation)
      Dim data As Persistent.NishiInvoiceDetail

      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      Dim pI As Integer
      For pI = 0 To item.Detail.Count - 1

        data = New Persistent.NishiInvoiceDetail(session)
        data.Barang = item.Detail(pI).Barang
        data.Hari = 1
        data.Qty = item.Detail(pI).Qty
        data.Satuan = item.Detail(pI).Satuan
        data.Harga = item.Detail(pI).Harga
        data.PPN = item.Detail(pI).Barang.PajakIN
        data.PPNp = item.Detail(pI).Barang.PajakIN.NilaiPajak
        data.PPH = item.Detail(pI).Barang.PajakOUT
        data.PPHp = item.Detail(pI).Barang.PajakOUT.NilaiPajak
        data.Catatan = item.Detail(pI).Catatan
        instance.Detail.Add(data)
      Next
      HitungTotal()
    End If
  End Sub
  Private Sub txtTermin_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtTermin.EditValueChanging
    If Not e.NewValue Is Nothing Then
      txtTglBerlaku.DateTime = DateAdd(DateInterval.Day, CType(e.NewValue, NuSoft005.Persistent.Termin).Tempo, txtTanggal.DateTime)
    End If
  End Sub
End Class