Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Friend Class UI_PembayaranDialog
  Private instance As Persistent.PembayaranHutang
  Private xdataHutang As List(Of Persistent.DataHutang)
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.PembayaranHutangDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.PembayaranHutang.AutoSaveOnEndEdit = False
    Persistent.PembayaranHutangDetail.AutoSaveOnEndEdit = False
    Persistent.ViewInvoice.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingpurchase = New Logic.PurchaseSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("VPTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("VPTransaksi.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.PembayaranHutang(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      xGrid.DataSource = Nothing
      LoadDefault()
      SetNomor()
      ChangeCode()
      txtKontak.Focus()
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.PembayaranHutang)(Convert.ToInt64(IdToEdit))
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

      txtKontak.EditValue = instance.Vendor
      txtKontak.Properties.ReadOnly = True
      editAssign = False
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl()
      End If
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Pembayaran Hutang [VP] : Tambah Data"
    Else
      Me.Text = "Pembayaran Hutang [VP] : Edit Data " & instance.Kode
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
      If Not txtKontak.EditValue Is Nothing Then
        instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Vendor = Nothing
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
      instance.TotalPPH = CDbl(txtNilaiPPH.EditValue)
      instance.NomorPPH = txtNoPPH.EditValue
      instance.Uraian = txtUraian.EditValue
      'isikan detailnya
      'MsgBox("OKE Utama")
      Dim item As Persistent.PembayaranHutangDetail
      Dim pI As UInt32, SisaHutang As Double
      For pI = 0 To xdataHutang.Count - 1
        If xdataHutang(pI).NilaiBayarCash > 0 Then
          SisaHutang = (xdataHutang(pI).NoInvoice.NilaiInvoice - xdataHutang(pI).Terbayar)
          If xdataHutang(pI).NilaiBayarCash.ToString("n4") <> SisaHutang.ToString("n4") Then
            If xdataHutang(pI).NilaiBayarCash > SisaHutang Then
              Throw New Utils.Exception("Jumlah pembayaran tidak boleh lebih dari sisa piutang." & vbCrLf &
                                        "Nomor Invoice : " & xdataHutang(pI).NoInvoice.Kode & vbCrLf &
                                        "Nilai Pembayaran : " & xdataHutang(pI).NilaiBayarCash.ToString("n4") & vbCrLf &
                                        "Sisa Piutang : " & SisaHutang.ToString("n4"), -9, "", Me.Text)
              Return
            End If
          End If
          'MsgBox("Lolos pengecekan")

          'If xdataHutang(pI).NilaiBayarCash > (xdataHutang(pI).NoInvoice.NilaiInvoice - xdataHutang(pI).Terbayar) Then
          '  Throw New Utils.Exception("Jumlah pembayaran tidak boleh lebih dari sisa piutang.", -9, "", Me.Text)
          '  Return
          'End If

          If instance.Detail.ToList.Exists(Function(m) m.Urutan = pI) Then
            item = instance.Detail.Single(Function(m) m.Urutan = pI)
            item.NoInvoice = xdataHutang(pI).NoInvoice
            item.NilaiBayarCash = xdataHutang(pI).NilaiBayarCash
            item.NilaiBayar = xdataHutang(pI).NilaiBayarCash
            item.Kurs = xdataHutang(pI).Kurs
          Else
            item = New Persistent.PembayaranHutangDetail(session)
            item.NoInvoice = xdataHutang(pI).NoInvoice
            item.NilaiBayarCash = xdataHutang(pI).NilaiBayarCash
            item.NilaiBayar = xdataHutang(pI).NilaiBayarCash
            item.Kurs = xdataHutang(pI).Kurs
            item.Urutan = pI
            instance.Detail.Add(item)
          End If
          If (SisaHutang - xdataHutang(pI).NilaiBayarCash) = 0 Then
            item.NoInvoice.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
          Else
            item.NoInvoice.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
          End If
        End If
      Next
      'MsgBox("OKE GL")
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
      'hutang dagang  (D) 
      'Dim a = From z In instance.Detail Group z By z.NoInvoice.Uang.HutangDagang Into Group Select HutangDagang, SubTotal = Group.Sum(Function(x) x.NilaiBayarCash * x.Kurs), SubTotalValas = Group.Sum(Function(x) x.NilaiBayarCash), Kurs = Group.Average(Function(x) x.Kurs)
      Dim a = From z In instance.Detail Group z By z.NoInvoice.CoaHutang Into Group Select CoaHutang, SubTotal = Group.Sum(Function(x) x.NilaiBayarCash * x.Kurs), SubTotalValas = Group.Sum(Function(x) x.NilaiBayarCash), Kurs = Group.Average(Function(x) x.Kurs)
      For Each x In a
        SimpanGL(x.CoaHutang, i, x.SubTotal, 0, x.SubTotalValas, 0, x.Kurs)
        i = i + 1
      Next

      ''selisih kurs
      If instance.SelisihKurs <> 0 Then

      End If

      If instance.TotalAdminBank > 0 Then 'Biaya Admin Bank (D)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaAdminBank)), i, instance.TotalAdminBank * instance.Kurs, 0, 0, 0, 1)
        i = i + 1
      End If
      If instance.TotalPembulatan > 0 Then 'Pembulatan (D/K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaBiayaPembulatan)), i, instance.TotalPembulatan * instance.Kurs, 0, 0, 0, 1)
        i = i + 1
      ElseIf instance.TotalPembulatan < 0 Then
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaBiayaPembulatan)), i, 0, (instance.TotalPembulatan * instance.Kurs) * -1, 0, 0, 1)
        i = i + 1
      End If
      If instance.TotalDiscount > 0 Then 'Pendapatan (K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaPendapatan)), i, 0, instance.TotalDiscount * instance.Kurs, 0, 0, 1)
        i = i + 1
      End If
      If instance.TotalPPH > 0 Then 'PPH 23(K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaPPH)), i, 0, instance.TotalPPH * instance.Kurs, 0, 0, 1)
        i = i + 1
      End If

      'Kas/Bank (K)
      SimpanGL(instance.coakasbank, i, 0, instance.Total, 0, instance.TotalValas, instance.Kurs)

      'MsgBox("Selesai GL")

      'For pI = 0 To xdataHutang.Count - 1
      '  If session.IsObjectToSave(xdataHutang(pI)) Then
      '    xdataHutang(pI).Reload()
      '  End If
      'Next
      instance.Save()

      'update untuk status invoicenya
      'For pI = 0 To instance.Detail.Count - 1
      '  Dim xDataHutang As New XPCollection(Of Persistent.ViewInvoice)(session, New BinaryOperator("NoInvoice.Id", instance.Detail(pI).NoInvoice.Id, BinaryOperatorType.Equal))
      '  If Not xDataHutang Is Nothing Then
      '    'MsgBox("nilai hutang : " & xDataHutang(0).NoInvoice.Total.ToString("n2") & "--> Bayar : " & xDataHutang(0).Terbayar.ToString("n2"))
      '    If xDataHutang(0).NoInvoice.Total = xDataHutang(0).Terbayar Then
      '      instance.Detail(pI).NoInvoice.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
      '    Else
      '      instance.Detail(pI).NoInvoice.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
      '    End If
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
    '======= Konfirmasi Cetak Laporan
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.VP)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherPembayaranInvoice)
    message = String.Format(message, "Pembayaran Hutang")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingpurchase.PreviewReport)
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
    If settingpurchase.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", settingpurchase.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtCaraBayar.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.BankCaraBayar))
    txtAkun.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank}).Where(Function(w) w.Aktif).ToList
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
    colSisa.SummaryItem.DisplayFormat = setting.NumericFormatString
    colSisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSisa.DisplayFormat.FormatString = setting.NumericFormatToString


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
    txtUraian.Text = settingpurchase.UraianVP
    txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
    txtNilaiKas.Text = 0.0
    txtKurs.Text = 1.0
    txtNilaiValas.EditValue = 0.0
    txtNilaiAdministrasi.EditValue = 0.0
    txtNilaiPembulatan.EditValue = 0.0
    txtNilaiPendapatan.EditValue = 0.0
    txtNilaiPPH.EditValue = 0.0
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtCaraBayar.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCaraBayar)
    If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
      txtKurs.Text = 1.0
      txtKurs.Properties.ReadOnly = True
    Else
      txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
      txtKurs.Properties.ReadOnly = False
    End If
    xGrid.DataSource = Nothing
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.VP)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtUraian.Enabled = False
    txtAkun.Enabled = False
    txtKurs.Enabled = False
    xGridView.OptionsBehavior.Editable = False
    txtCaraBayar.Enabled = False
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
  'Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
  '  If Not e.NewValue Is Nothing Then
  '    lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
  '    'isikan data detailnya
  '    txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
  '    txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
  '    txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

  '    xGHistory.DataSource = New XPCollection(Of Persistent.PembayaranHutang)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))

  '    'isikan transaksinya
  '    Dim Filter As New List(Of CriteriaOperator)
  '    Filter.Add(New BinaryOperator("NoInvoice.Vendor", e.NewValue, BinaryOperatorType.Equal))

  '    xdataHutang = New XPCollection(Of Persistent.ViewInvoice)(session, GroupOperator.And(Filter))

  '    For pI = 0 To xdataHutang.Count - 1
  '      xdataHutang(pI).OK = False
  '      xdataHutang(pI).Urutan = pI
  '      xdataHutang(pI).NilaiBayarCash = 0 ' xdataHutang(pI).NoInvoice.NilaiInvoice - xdataHutang(pI).Terbayar
  '      Dim InvoiceId = xdataHutang(pI).NoInvoice.Id
  '      'MsgBox(xdataHutang(pI).Terbayar.ToString)
  '      If instance.Detail.ToList.Exists(Function(m) m.NoInvoice.Id = InvoiceId) Then
  '        Dim invoice = instance.Detail.ToList.Find(Function(m) m.NoInvoice.Id = InvoiceId)
  '        xdataHutang(pI).OK = True
  '        xdataHutang(pI).NilaiBayarCash = invoice.NilaiBayar
  '        xdataHutang(pI).Terbayar -= invoice.NilaiBayar
  '        xdataHutang(pI).Kurs = invoice.Kurs
  '      Else
  '        'ambilkan kurs dari master kurs
  '        Dim setting As New NuSoft001.Logic.FinaSetting(session)
  '        If xdataHutang(pI).NoInvoice.Uang.Id = setting.MultiMataUangDefault Then
  '          xdataHutang(pI).Kurs = 1.0
  '        Else
  '          xdataHutang(pI).Kurs = NuSoft001.Logic.Kurs.getKursBank(session, xdataHutang(pI).NoInvoice.Uang, txtTanggal.DateTime)
  '        End If
  '      End If
  '    Next
  '    xGrid.DataSource = xdataHutang
  '    If xdataHutang.Count > 0 Then
  '      xGridView.ActiveFilterString = "[ColSisa]>=1"
  '    End If
  '    hitungsaldo()
  '  End If
  'End Sub
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
        Try
          If Not editAssign Then
            splashManager.ShowWaitForm()
            splashManager.SetWaitFormCaption("Silahkan Tunggu")
            splashManager.SetWaitFormDescription("Loading data ...")
          End If

          Dim xKontak = CType(e.NewValue, NuSoft001.Persistent.Kontak)
          lblKontakNama.Text = xKontak.Nama
          txtPhoneNumber.Text = xKontak.Telepon
          txtDebitLimit.Text = CStr(xKontak.BatasPiutang)
          txtCreditLimit.Text = CStr(xKontak.BatasHutang)

          xGHistory.DataSource = New XPCollection(Of Persistent.PembayaranHutang)(session, New BinaryOperator("Vendor", xKontak, BinaryOperatorType.Equal))

          xdataHutang = New XPQuery(Of Persistent.ViewInvoice)(session).Where(Function(w) w.NoInvoice.Vendor Is xKontak).Select(
          Function(s) New Persistent.DataHutang() With {
            .NoInvoice = s.NoInvoice,
            .Terbayar = s.Terbayar,
            .Catatan = s.Catatan,
            .Pembayaran = s.Pembayaran,
            .NilaiBayarCash = 0,
            .OK = False,
            .Urutan = 0,
            .Kurs = 1
          }).ToList

          Dim urutan = 0
          For Each item In xdataHutang
            item.Urutan = urutan
            If instance.Detail.ToList.Exists(Function(m) m.NoInvoice.Id = item.NoInvoice.Id) Then
              Dim invoice = instance.Detail.ToList.Find(Function(m) m.NoInvoice.Id = item.NoInvoice.Id)
              item.OK = True
              item.NilaiBayarCash = invoice.NilaiBayar
              item.Terbayar -= invoice.NilaiBayar
              item.Kurs = invoice.Kurs
            Else
              'ambilkan kurs dari master kurs
              If item.NoInvoice.Uang.Id <> setting.MultiMataUangDefault Then
                item.Kurs = NuSoft001.Logic.Kurs.getKursBank(session, item.NoInvoice.Uang, txtTanggal.DateTime)
              End If
            End If

            urutan += 1
          Next

          xGrid.DataSource = xdataHutang.Where(Function(w) w.SisaHutang > 0).ToList
          hitungsaldo()
        Catch ex As Exception
          XtraMessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
        End Try
      End Using
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
        End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Tanggal = txtTanggal.DateTime
        ChangeCode()
      End If
      If chkPajak.Checked = True Then 'berarti pembayaran pajak, ambilkan kurs dari tanggal invoice agar tidak terjadi selisih kurs
        For pi = 0 To xdataHutang.Count - 1
          xdataHutang(pi).Kurs = xdataHutang(pi).NoInvoice.Kurs
        Next
      Else
        For pi = 0 To xdataHutang.Count - 1
          xdataHutang(pi).Kurs = NuSoft001.Logic.Kurs.getKursBank(session, xdataHutang(pi).NoInvoice.Uang, txtTanggal.DateTime)
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
      xGrid.Focus()
    End If
  End Sub
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub txtAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAkun.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As NuSoft001.Persistent.Coa = CType(e.NewValue, NuSoft001.Persistent.Coa)
      Dim setting As New NuSoft001.Logic.FinaSetting(session)
      lblAkunKasBankNama.Text = item.Nama
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
      For pi = 0 To xdataHutang.Count - 1
        If xdataHutang(pi).OK = True Then
          saldo = saldo + xdataHutang(pi).NilaiBayarCash * xdataHutang(pi).Kurs
        End If
      Next
      If txtNilaiValas.EditValue Is Nothing Then txtNilaiValas.EditValue = 0.0
      If txtNilaiAdministrasi.EditValue Is Nothing Then txtNilaiAdministrasi.EditValue = 0.0
      If txtNilaiPembulatan.EditValue Is Nothing Then txtNilaiPembulatan.EditValue = 0.0
      If txtNilaiPendapatan.EditValue Is Nothing Then txtNilaiPendapatan.EditValue = 0.0
      If txtNilaiPPH.EditValue Is Nothing Then txtNilaiPPH.EditValue = 0.0

      lbTotal.Text = String.Format("{0}.{1}", session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault)).Kode, Format(saldo, setting.FormatAngka))
      txtNilaiKas.EditValue = CDbl(saldo) + ((CDbl(txtNilaiAdministrasi.EditValue) - CDbl(txtNilaiPendapatan.EditValue) - CDbl(txtNilaiPPH.EditValue) + CDbl(txtNilaiPembulatan.EditValue)) * CDbl(txtKurs.EditValue))
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
      For pi = 0 To xdataHutang.Count - 1
        xdataHutang(pi).Kurs = xdataHutang(pi).NoInvoice.Kurs
      Next
    Else
      For pi = 0 To xdataHutang.Count - 1
        xdataHutang(pi).Kurs = NuSoft001.Logic.Kurs.getKursBank(session, xdataHutang(pi).NoInvoice.Uang, txtTanggal.DateTime)
      Next
    End If
  End Sub
  Private Sub xGridView_CellValueChanged1(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    Dim row As Persistent.DataHutang = CType(xGridView.GetRow(e.RowHandle), Persistent.DataHutang)
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
  Private Sub txtCaraBayar_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCaraBayar.EditValueChanging
    If e.NewValue = "Cek / Giro" Or e.NewValue = "Cek / Giro (Tempo)" Then
      layCaraBayarDetail.Expanded = True
    Else
      layCaraBayarDetail.Expanded = False
    End If
  End Sub
  Private Sub colBayarRepo_Click(sender As Object, e As EventArgs) Handles colBayarRepo.Click
    'MsgBox("Set Bayar untuk baris ini")
    Dim row As Persistent.DataHutang = CType(xGridView.GetFocusedRow, Persistent.DataHutang)
    row.NilaiBayarCash = row.NoInvoice.NilaiInvoice - row.Terbayar
    row.OK = True
    hitungsaldo()
    xGridView.RefreshData()
  End Sub
End Class