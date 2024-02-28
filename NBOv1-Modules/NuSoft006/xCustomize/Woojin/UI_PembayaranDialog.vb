Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class zWoojinUI_PembayaranDialog
  Private instance As Persistent.zWoojinPembayaranPiutang
  Private xdatapiutang As XPCollection(Of Persistent.zWoojinViewInvoice)
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.zWoojinPembayaranPiutangDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingsales As Logic.SalesSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.zWoojinPembayaranPiutang.AutoSaveOnEndEdit = False
    Persistent.zWoojinPembayaranPiutangDetail.AutoSaveOnEndEdit = False
    Persistent.zWoojinViewInvoice.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingsales = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CPTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CPTransaksi.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.zWoojinPembayaranPiutang(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      xGrid.DataSource = Nothing
      LoadDefault()
      SetNomor()
      ChangeCode()
      txtKontak.Focus()
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.zWoojinPembayaranPiutang)(Convert.ToInt64(IdToEdit))
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.EditValue = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtStatus.EditValue = instance.StatusTransaksi
      chkPajak.EditValue = instance.PembayaranPajak
      txtAkun.EditValue = instance.coakasbank
      txtKurs.EditValue = instance.Kurs
      txtNilaiKas.EditValue = instance.Total
      txtNilaiValas.EditValue = instance.TotalValas
      txtNilaiAdministrasi.EditValue = instance.TotalAdminBank
      txtNilaiPendapatan.EditValue = instance.TotalDiscount
      txtNilaiPembulatan.EditValue = instance.TotalPembulatan
      txtNilaiPPH.EditValue = instance.TotalPPH
      txtNoPPH.EditValue = instance.NomorPPH
      txtUraian.EditValue = instance.Uraian

      txtKontak.EditValue = instance.Pelanggan
      txtKontak.Enabled = False
      txtKontak.Properties.ReadOnly = True
      hitungsaldo()
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Pembayaran Piutang [CP] : Tambah Data"
    Else
      Me.Text = "Pembayaran Piutang [CP] : Edit Data " & instance.Kode
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
    Dim xSaldo As Double = 0
    For pi = 0 To xdatapiutang.Count - 1
      If xdatapiutang(pi).OK = True Then
        xSaldo = xSaldo + xdatapiutang(pi).NilaiBayarCash
      End If
    Next
    If xSaldo = 0 Then
      Throw New Utils.Exception("Silahkan masukkan nilai invoice yang akan dibayar.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If


    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      '======= Simpan Main
      If Not txtKontak.EditValue Is Nothing Then
        instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Pelanggan = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.PembayaranPajak = CType(chkPajak.EditValue, Boolean)
      instance.coakasbank = CType(txtAkun.EditValue, NuSoft001.Persistent.Coa)
      instance.Kurs = txtKurs.EditValue
      instance.Total = txtNilaiKas.EditValue
      instance.TotalValas = txtNilaiValas.EditValue
      instance.TotalAdminBank = txtNilaiAdministrasi.EditValue
      instance.TotalDiscount = txtNilaiPendapatan.EditValue
      instance.TotalPembulatan = txtNilaiPembulatan.EditValue
      instance.TotalPPH = txtNilaiPPH.EditValue
      instance.NomorPPH = txtNoPPH.EditValue
      instance.Uraian = txtUraian.EditValue
      'isikan detailnya

      Dim item As Persistent.zWoojinPembayaranPiutangDetail
      Dim pI As Integer, xUrutan As Byte = 0
      For pI = 0 To xdatapiutang.Count - 1
        If xdatapiutang(pI).NilaiBayarCash > 0 Then
          If xdatapiutang(pI).NilaiBayarCash > (xdatapiutang(pI).NoInvoice.Total - xdatapiutang(pI).Terbayar) Then
            Throw New Utils.Exception("Jumlah pembayaran tidak boleh lebih dari sisa piutang.", -9, "", Me.Text)
            Return
          End If

          If instance.Detail.ToList.Exists(Function(m) m.Urutan = xUrutan) Then
            item = instance.Detail.Single(Function(m) m.Urutan = xUrutan)
            item.NoInvoice = xdatapiutang(pI).NoInvoice
            item.NilaiBayarCash = xdatapiutang(pI).NilaiBayarCash
            item.NilaiBayar = xdatapiutang(pI).NilaiBayarCash
            item.Kurs = xdatapiutang(pI).Kurs
          Else
            item = New Persistent.zWoojinPembayaranPiutangDetail(session)
            item.Urutan = xUrutan
            item.NoInvoice = xdatapiutang(pI).NoInvoice
            item.NilaiBayarCash = xdatapiutang(pI).NilaiBayarCash
            item.NilaiBayar = xdatapiutang(pI).NilaiBayarCash
            item.Kurs = xdatapiutang(pI).Kurs
            instance.Detail.Add(item)
          End If
          xUrutan = xUrutan + 1
        End If
      Next


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

      Dim i As Byte = 1
      'Kas/Bank (D)
      'Biaya Admin(D)
      'PPH(D)
      'Pembulatan(K / D)
      'Pendapatan(K)
      'Piutang(K)
      'Kas/Bank  (D) 
      i = 1
      SimpanGL(txtAkun.EditValue, i, instance.Total * instance.Kurs, 0, instance.TotalValas, 0, instance.Kurs)
      i += 1
      If instance.TotalAdminBank > 0 Then 'Biaya Admin Bank (D)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingsales.CoaAdminBank)), i, instance.TotalAdminBank * instance.Kurs, 0, 0, 0, 1)
        i = i + 1
      End If
      If instance.TotalPPH > 0 Then 'PPH 23(D)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingsales.CoaPPH)), i, instance.TotalPPH * instance.Kurs, 0, 0, 0, 1)
        i = i + 1
      End If
      If instance.TotalPembulatan > 0 Then 'Pembulatan (D/K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingsales.CoaBiayaPembulatan)), i, 0, instance.TotalPembulatan * instance.Kurs, 0, 0, 1)
        i = i + 1
      ElseIf instance.TotalPembulatan < 0 Then
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingsales.CoaBiayaPembulatan)), i, (instance.TotalPembulatan * instance.Kurs) * -1, 0, 0, 0, 1)
        i = i + 1
      End If
      If instance.TotalDiscount > 0 Then 'Pendapatan (K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingsales.CoaPendapatan)), i, 0, instance.TotalDiscount * instance.Kurs, 0, 0, 1)
        i = i + 1
      End If
      'Piutang (K)
      Dim a = From z In instance.Detail Group z By z.NoInvoice.Uang.PiutangDagang Into Group Select PiutangDagang, SubTotal = Group.Sum(Function(x) x.NilaiBayarCash * x.Kurs), SubTotalValas = Group.Sum(Function(x) x.NilaiBayarCash), Kurs = Group.Average(Function(x) x.Kurs)
      For Each x In a
        SimpanGL(x.PiutangDagang, i, 0, x.SubTotal, 0, x.SubTotalValas, x.Kurs)
        i = i + 1
      Next
      ''selisih kurs
      If instance.SelisihKurs <> 0 Then

      End If

      For pI = 0 To xdatapiutang.Count - 1
        If session.IsObjectToSave(xdatapiutang(pI)) Then
          xdatapiutang(pI).Reload()
        End If
      Next

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
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.CP, MainClass.reportName.VoucherCP)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherCP)
    message = String.Format(message, "Pembayaran Piutang")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingsales.PreviewSave)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -3 : txtUraian.Focus()
      Case -4 : txtTanggal.Focus()
        'Case -5, -7 : xGrid.Focus()
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
    If settingsales.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", settingsales.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtCaraBayar.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.BankCaraBayar))
    txtAkun.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank})
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
  End Sub
  Private Sub SetFormat()
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colTerbayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTerbayar.DisplayFormat.FormatString = setting.NumericFormatToString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = setting.NumericFormatToString
    colJumlahBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colJumlahBayar.DisplayFormat.FormatString = setting.NumericFormatToString
    colKursInvoice.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKursInvoice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiKas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiKas.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiValas.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiAdministrasi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiAdministrasi.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiPembulatan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiPembulatan.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiPendapatan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiPendapatan.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiPPH.Properties.Mask.EditMask = setting.NumericFormatToString
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
    txtUraian.Text = settingsales.UraianCP
    txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
    txtNilaiKas.Text = 0
    txtKurs.Text = 1
    txtNilaiValas.Text = 0
    txtNilaiAdministrasi.Text = 0
    txtNilaiPembulatan.Text = 0
    txtNilaiPendapatan.Text = 0
    txtNilaiPPH.Text = 0
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtCaraBayar.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCaraBayar)
    If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
      txtKurs.Text = 1
      txtKurs.Properties.ReadOnly = True
    Else
      txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
      txtKurs.Properties.ReadOnly = False
    End If
    xGrid.DataSource = Nothing
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.CP)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    'txtKontak.Enabled = False
    'txtTanggal.Enabled = False
    'txtNoTransaksi.Enabled = False
    'txtRegional.Enabled = False
    'txtTipe.Enabled = False
    'txtCashAdvance.Enabled = False
    'txtUraian.Enabled = False
    'txtAkun.Enabled = False
    'txtMataUang.Enabled = False
    'txtKurs.Enabled = False
    'xGridView.OptionsBehavior.Editable = False
    'txtCatatan.Enabled = False
    'txtCaraBayar.Enabled = False
    'txtNoCekGiro.Enabled = False
    'txtNoAC.Enabled = False
    'txtBank.Enabled = False
    'txtAkunGiro.Enabled = False
    'txtJatuhTempo.Enabled = False
    'AllowSave = False
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
      txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

      xGHistory.DataSource = New XPCollection(Of Persistent.zWoojinPembayaranPiutang)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))

      'isikan transaksinya
      Dim Filter As New List(Of CriteriaOperator)
      Filter.Add(New BinaryOperator("NoInvoice.Pelanggan", e.NewValue, BinaryOperatorType.Equal))

      xdatapiutang = New XPCollection(Of Persistent.zWoojinViewInvoice)(session, GroupOperator.And(Filter))

      For pI = 0 To xdatapiutang.Count - 1
        xdatapiutang(pI).OK = False
        xdatapiutang(pI).Urutan = pI
        xdatapiutang(pI).NilaiBayarCash = 0.0
        Dim InvoiceId = xdatapiutang(pI).NoInvoice.Id
        If instance.Detail.ToList.Exists(Function(m) m.NoInvoice.Id = InvoiceId) Then
          Dim invoice = instance.Detail.ToList.Find(Function(m) m.NoInvoice.Id = InvoiceId)
          xdatapiutang(pI).OK = True
          xdatapiutang(pI).NilaiBayarCash = invoice.NilaiBayar
          xdatapiutang(pI).Terbayar -= invoice.NilaiBayar
        End If
        'ambilkan kurs dari master kurs
        Dim setting As New NuSoft001.Logic.FinaSetting(session)
        If xdatapiutang(pI).NoInvoice.Uang.Id = setting.MultiMataUangDefault Then
          xdatapiutang(pI).Kurs = 1.0
        Else
          xdatapiutang(pI).Kurs = NuSoft001.Logic.Kurs.getKursBank(session, xdatapiutang(pI).NoInvoice.Uang, txtTanggal.DateTime)
        End If
      Next
      xGrid.DataSource = xdatapiutang
      If xdatapiutang.Count > 0 Then
        xGridView.ActiveFilterString = "[ColSisa]>0"
      End If
      hitungsaldo()
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
      If chkPajak.Checked = True Then 'berarti pembayaran pajak, ambilkan kurs dari tanggal invoice agar tidak terjadi selisih kurs
        For pi = 0 To xdatapiutang.Count - 1
          xdatapiutang(pi).Kurs = xdatapiutang(pi).NoInvoice.Kurs
        Next
      Else
        For pi = 0 To xdatapiutang.Count - 1
          xdatapiutang(pi).Kurs = NuSoft001.Logic.Kurs.getKursBank(session, xdatapiutang(pi).NoInvoice.Uang, txtTanggal.DateTime)
        Next
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
    MyBase.OnKeyDown(e)
    If e.Control AndAlso e.Shift Then
      'xGrid.Focus()
    End If
  End Sub
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub ChangeCaraBayar(item As Persistent.BankCaraBayar)
    'Select Case item
    '  Case NuSoft001.Persistent.BankCaraBayar.Tunai, NuSoft001.Persistent.BankCaraBayar.Transfer, NuSoft001.Persistent.BankCaraBayar.LainLain
    '    layCaraBayarDetail.Visibility = LayoutVisibility.Never
    '  Case NuSoft001.Persistent.BankCaraBayar.CekGiro
    '    layCaraBayarDetail.Visibility = LayoutVisibility.Always
    '    layJatuhTempo.Visibility = LayoutVisibility.Never
    '  Case NuSoft001.Persistent.BankCaraBayar.CekGiroTempo
    '    layCaraBayarDetail.Visibility = LayoutVisibility.Always
    '    layJatuhTempo.Visibility = LayoutVisibility.Always
    'End Select
  End Sub
  'Private Sub txtCaraBayar_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCaraBayar.EditValueChanging
  '  If Not e.NewValue Is Nothing Then
  '    Dim item As NuSoft001.Persistent.BankCaraBayar = CType(e.NewValue, NuSoft001.Persistent.BankCaraBayar)
  '    ChangeCaraBayar(item)
  '  End If
  'End Sub
  Private Sub txtAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAkun.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As NuSoft001.Persistent.Coa = CType(e.NewValue, NuSoft001.Persistent.Coa)
      Dim setting As New NuSoft001.Logic.FinaSetting(session)
      layAkunKasBankNama.Text = item.Nama

      'If item.Tipe.Id = NuSoft001.Persistent.CoaEnum.eKind.Kas Then
      '  layCaraBayar.Visibility = LayoutVisibility.Never
      '  layCaraBayarDetail.Visibility = LayoutVisibility.Never
      'Else
      '  layCaraBayar.Visibility = LayoutVisibility.Always
      '  layCaraBayarDetail.Visibility = LayoutVisibility.Always

      '  'ChangeCaraBayar(CType(txtCaraBayar.EditValue, NuSoft001.Persistent.BankCaraBayar))
      'End If

      txtUang.EditValue = CType(item.MataUang, NuSoft001.Persistent.MataUang)

      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtKurs.Text = 1
        txtKurs.Properties.ReadOnly = True
      Else
        txtKurs.Text = NuSoft001.Logic.Kurs.getKursBank(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
        txtKurs.Properties.ReadOnly = False
      End If
    End If
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
    hitungsaldo()
  End Sub
  Private Sub hitungsaldo()
    Dim saldo As Double
    If Not xGridView.DataSource Is Nothing Then
      saldo = 0
      For pi = 0 To xdatapiutang.Count - 1
        If xdatapiutang(pi).OK = True Then
          saldo = saldo + xdatapiutang(pi).NilaiBayarCash
        End If
      Next
      lbTotal.Text = String.Format("{0}.{1}", session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault)).Kode, Format(saldo, setting.FormatAngka))
      txtNilaiKas.EditValue = CDbl(saldo) + ((CDbl(txtNilaiPendapatan.EditValue) + CDbl(txtNilaiPembulatan.EditValue) - CDbl(txtNilaiAdministrasi.EditValue) - CDbl(txtNilaiPPH.EditValue)) * CDbl(txtKurs.EditValue))
      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtNilaiValas.EditValue = 0
      Else
        txtNilaiValas.EditValue = CDbl(txtNilaiKas.EditValue) / CDbl(txtKurs.EditValue)
      End If
    End If
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Kurs As Double)
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
      If Akun.MataUang.Id = setting.MultiMataUangDefault Then
        item.DebitValas = 0
        item.KreditValas = 0
        item.Kurs = 1
      Else
        item.DebitValas = DebitValas
        item.KreditValas = KreditValas
        item.Kurs = Kurs
      End If
      instance.Gl.Detail.Add(item)
    End If
  End Sub
  Private Sub txtNilaiPPH_EditValueChanged(sender As Object, e As EventArgs) Handles txtNilaiAdministrasi.EditValueChanged, txtNilaiPembulatan.EditValueChanged, txtNilaiPendapatan.EditValueChanged, txtNilaiPPH.EditValueChanged
    hitungsaldo()
  End Sub
  Private Sub chkPajak_CheckedChanged(sender As Object, e As EventArgs) Handles chkPajak.CheckedChanged
    If chkPajak.Checked = True Then 'berarti pembayaran pajak, ambilkan kurs dari tanggal invoice agar tidak terjadi selisih kurs
      For pi = 0 To xdatapiutang.Count - 1
        xdatapiutang(pi).Kurs = xdatapiutang(pi).NoInvoice.Kurs
      Next
    Else
      For pi = 0 To xdatapiutang.Count - 1
        xdatapiutang(pi).Kurs = NuSoft001.Logic.Kurs.getKursBank(session, xdatapiutang(pi).NoInvoice.Uang, txtTanggal.DateTime)
      Next
    End If
  End Sub
  Private Sub xGridView_CellValueChanged1(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    Dim row As Persistent.zWoojinViewInvoice = CType(xGridView.GetRow(e.RowHandle), Persistent.zWoojinViewInvoice)
    If row.NilaiBayarCash = 0 Then
      row.OK = False
    Else
      row.OK = True
    End If
    hitungsaldo()
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
End Class