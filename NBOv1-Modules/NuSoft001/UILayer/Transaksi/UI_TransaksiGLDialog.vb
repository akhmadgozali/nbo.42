Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_TransaksiGLDialog
  Private _jenisTransaksi As JenisTransaksiGL
  Private instance As Persistent.GlMain
  Private setting As Logic.FinaSetting
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.GlMainDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private CASource As List(Of Persistent.SisaCashAdvance)
  Sub New(jenisTransaksi As JenisTransaksiGL)
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.GlMain.AutoSaveOnEndEdit = False
    Persistent.GlMainDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
    _jenisTransaksi = jenisTransaksi
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New Logic.FinaSetting(session)
    CustomizeLayout()
    BindingDataSource()
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.GlMain(session)
      instance.ModuleId = MainClass.GetModuleId

      xGrid.DataSource = Nothing
      LoadDefault()
      txtUraian.Text = ""
      txtCatatan.Text = ""
      txtNoCekGiro.Text = ""
      txtNoAC.Text = ""
      txtValas.EditValue = 0
      txtKurs.EditValue = 1
      txtJatuhTempo.EditValue = Nothing
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.GlMain)(Convert.ToInt64(IdToEdit))
      txtUraian.Text = instance.Uraian
      txtCatatan.Text = instance.Catatan
      txtNoCekGiro.Text = instance.CekGiroNomor
      txtNoAC.Text = instance.CekGiroAC
      txtJatuhTempo.EditValue = instance.CekGiroJatuhTempo
      txtAkunGiro.EditValue = instance.CekGiroAkun
      txtBank.EditValue = instance.CekGiroBank
      txtCaraBayar.EditValue = instance.CaraBayar
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtAkun.EditValue = instance.Akun
      txtMataUang.Text = instance.MataUang
      txtKurs.EditValue = instance.Kurs
      txtNoTransaksi.Text = instance.Kode

      xGrid.DataSource = From p In instance.Detail Select p Where p.Urutan <> 0
      instance.Detail.CriteriaString = "Urutan <> 0"
      xGrid.DataSource = instance.Detail
      editAssign = False
      SetSumberKasBank(instance.Akun)
      If _jenisTransaksi = JenisTransaksiGL.JurnalUmum Then
        CASource.Add(New Persistent.SisaCashAdvance(session) With {.Id = instance.CashAdvance.Id, .Kode = instance.CashAdvance.Kode, .Kontak = instance.CashAdvance.KontakNama, .Tanggal = instance.CashAdvance.Tanggal})
        'txtCashAdvance.Properties.DataSource = Logic.CashAdvance.GetRemainTransaction(session, instance.Id)
        txtCashAdvance.EditValue = instance.CashAdvance.Id
      ElseIf _jenisTransaksi = JenisTransaksiGL.KasBankKeluar Then
        txtTipe.EditValue = instance.Tipe
      End If
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      SetTitle(Nothing)
    Else
      SetTitle(instance.Kode)
      If Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
        DisableControl()
      End If
    End If
  End Sub
  Overrides Sub SimpanData()
    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    ChangeTotalValas()
    Try
      '======= Set GL MAIN
      instance.ModuleId = NPO.Modules.ModuleId.Fina
      instance.MataUang = ""
      instance.Kurs = 1
      SimpanHeader()
      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
        instance.KontakNama = layKontakNama.Text
      Else
        instance.Kontak = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Uraian = txtUraian.Text
      instance.Catatan = txtCatatan.Text
      instance.CaraBayar = CType(txtCaraBayar.EditValue, Persistent.BankCaraBayar)
      SimpanCaraBayar(instance.CaraBayar)

      '======= Jika bukan JM, Tambahkan akun detail kas/bank --> dengan urutan 0
      If _jenisTransaksi = JenisTransaksiGL.KasBankKeluar OrElse _jenisTransaksi = JenisTransaksiGL.KasBankMasuk Then
        Dim item As Persistent.GlMainDetail
        If Tipe = InputType.Tambah Then
          xGrid.DataSource = From p In instance.Detail Select p Where p.Urutan <> 0

          If instance.Detail.ToList.Exists(Function(m) m.Urutan = 0) Then
            item = instance.Detail.Single(Function(m) m.Urutan = 0)
          Else
            item = New Persistent.GlMainDetail(session)

            item.Akun = instance.Akun
            item.MataUang = item.Akun.MataUang
            item.Main = instance
            item.Urutan = 0
            item.Divisi = Nothing
            instance.Detail.Add(item)
          End If
        Else
          instance.Detail.CriteriaString = ""
          item = instance.Detail.Single(Function(m) m.Urutan = 0)
        End If

        Select Case instance.Sumber
          Case Persistent.SumberDataJenis.BK, Persistent.SumberDataJenis.KK
            item.Debit = 0
            item.Kredit = instance.Detail.Sum(Function(m) m.Debit)
            item.Kurs = CType(txtKurs.EditValue, Double)
            item.DebitValas = 0
            item.KreditValas = CType(txtValas.EditValue, Double)
          Case Else
            item.Debit = instance.Detail.Sum(Function(m) m.Kredit)
            item.Kredit = 0
            item.Kurs = CType(txtKurs.EditValue, Double)
            item.DebitValas = CType(txtValas.EditValue, Double)
            item.KreditValas = 0
        End Select
        item.Keterangan = txtUraian.Text
      End If

      '======= Reload Untuk Cash Advance apabila edit
      If _jenisTransaksi = JenisTransaksiGL.JurnalUmum AndAlso Tipe = InputType.Edit Then
        Dim xx = session.GetObjectsToSave()
        For j = 0 To xx.Count - 1
          If Not xx(j) Is Nothing AndAlso xx(j).GetType Is GetType(Persistent.SisaCashAdvance) Then
            CType(xx(j), Persistent.SisaCashAdvance).Reload()
          End If
        Next
      End If

      '======= Simpan instance
      session.CommitChanges()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try

    '======= Konfirmasi Cetak Laporan
    Dim frm As New RF_BuktiHarian(instance.Sumber)
    frm.txtNoBukti1.Text = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    Select Case instance.Sumber
      Case Persistent.SumberDataJenis.BK : reportCode = MainClass.GetReport(MainClass.reportName.BuktiBankKeluar)
        message = String.Format(message, "bank keluar")
      Case Persistent.SumberDataJenis.BM : reportCode = MainClass.GetReport(MainClass.reportName.BuktiBankMasuk)
        message = String.Format(message, "bank masuk")
      Case Persistent.SumberDataJenis.KK : reportCode = MainClass.GetReport(MainClass.reportName.BuktiKasKeluar)
        message = String.Format(message, "kas keluar")
      Case Persistent.SumberDataJenis.KM : reportCode = MainClass.GetReport(MainClass.reportName.BuktiKasMasuk)
        message = String.Format(message, "kas masuk")
      Case Persistent.SumberDataJenis.JU : reportCode = MainClass.GetReport(MainClass.reportName.BuktiJurnalUmum)
        message = String.Format(message, "jurnal umum")
      Case Persistent.SumberDataJenis.JA : reportCode = MainClass.GetReport(MainClass.reportName.BuktiJurnalAdjustment)
        message = String.Format(message, "jurnal adjustment")
    End Select

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -2 : txtAkun.Focus()
      Case -3 : txtUraian.Focus()
      Case -4 : txtTanggal.Focus()
      Case -5, -7 : xGrid.Focus()
      Case -8 : txtCashAdvance.Focus()
    End Select
  End Sub
  Private Sub ChangeCode()
    If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing) Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatAkun) AndAlso (txtAkun.EditValue Is Nothing OrElse instance.Akun Is Nothing) AndAlso (_jenisTransaksi <> JenisTransaksiGL.JurnalAdjusment AndAlso _jenisTransaksi <> JenisTransaksiGL.JurnalUmum) Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatSumber) AndAlso instance.Sumber = Nothing Then
      Return
    End If

    If _jenisTransaksi = JenisTransaksiGL.JurnalAdjusment OrElse _jenisTransaksi = JenisTransaksiGL.JurnalUmum Then
      instance.Akun = Nothing
    End If

    Dim nomor As String = instance.Nomor.NomorBaru
    txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    txtNoTransaksi.Properties.Mask.EditMask = instance.Nomor.Mask
    txtNoTransaksi.Text = nomor
  End Sub
  Private Sub CustomizeLayout()
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.KasBankMasuk
        layCashAdvance.HideToCustomization()
        layCashAdvanceText.HideToCustomization()
        layTipe.HideToCustomization()
        layTipeEmpty.HideToCustomization()
        layAkunKasBank.Text = "Akun Kas/Bank [D]"
        colDebit.Visible = False
        colValasDebit.Visible = False
        If Not setting.MultiMataUangPakai Then
          layMataUang.HideToCustomization()
          layKurs.HideToCustomization()
          colValasKredit.Visible = False
          layAkunValas.HideToCustomization()
        End If
        layKontak.Text = "Sudah Terima Dari"
      Case JenisTransaksiGL.KasBankKeluar
        layCashAdvance.HideToCustomization()
        layCashAdvanceText.HideToCustomization()
        layAkunKasBank.Text = "Akun Kas/Bank [K]"
        colKredit.Visible = False
        colValasKredit.Visible = False
        If Not setting.MultiMataUangPakai Then
          layMataUang.HideToCustomization()
          layKurs.HideToCustomization()
          colValasDebit.Visible = False
          layAkunValas.HideToCustomization()
        End If
        layKontak.Text = "Sudah Bayar Ke"
      Case JenisTransaksiGL.JurnalUmum
        layTipe.HideToCustomization()
        layAkunKasBank.HideToCustomization()
        layAkunKasBankNama.HideToCustomization()
        layMataUang.HideToCustomization()
        layAkunValas.HideToCustomization()
        layKurs.HideToCustomization()
        layCatatan.HideToCustomization()
        layCaraBayar.HideToCustomization()
        layCaraBayarDetail.HideToCustomization()
        layKontak.Text = "Kontak"
        colDebit.Caption = "Debit"
        colKredit.Caption = "Kredit"
        If Not setting.MultiMataUangPakai Then
          colValasDebit.Visible = False
          colValasKredit.Visible = False
          colKurs.Visible = False
        End If
      Case JenisTransaksiGL.JurnalAdjusment
        layCashAdvance.HideToCustomization()
        layCashAdvanceText.HideToCustomization()
        layTipe.HideToCustomization()
        layTipeEmpty.HideToCustomization()
        layAkunKasBank.HideToCustomization()
        layAkunKasBankNama.HideToCustomization()
        layMataUang.HideToCustomization()
        layAkunValas.HideToCustomization()
        layKurs.HideToCustomization()
        layCatatan.HideToCustomization()
        layCaraBayar.HideToCustomization()
        layCaraBayarDetail.HideToCustomization()
        layKontak.Text = "Kontak"
        colDebit.Caption = "Debit"
        colKredit.Caption = "Kredit"
        If Not setting.MultiMataUangPakai Then
          colValasDebit.Visible = False
          colValasKredit.Visible = False
          colKurs.Visible = False
        End If
    End Select
    colDivisi.Visible = setting.MultiDivisi
  End Sub
  Private Sub BindingDataSource()
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session)
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    colAkunRepo.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang})
    colUangRepo.DataSource = New XPCollection(Of Persistent.MataUang)(session)
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.KasBankMasuk
        txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Bank})
        txtCaraBayar.Properties.DataSource = New Persistent.BankCaraBayarCollection
        'colAkunRepo.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang})
        txtAkunGiro.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Piutang})
      Case JenisTransaksiGL.KasBankKeluar
        txtTipe.Properties.DataSource = New Persistent.KasBankKeluarTipeCollection()
        txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Bank})
        txtCaraBayar.Properties.DataSource = New Persistent.BankCaraBayarCollection
        'colAkunRepo.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang})
        txtAkunGiro.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.HutangJangkaPendek})
      Case JenisTransaksiGL.JurnalUmum
        CASource = New DevExpress.Xpo.XPCollection(Of Persistent.SisaCashAdvance)(session).ToList
        txtCashAdvance.Properties.DataSource = CASource
        'colAkunRepo.DataSource = Logic.Coa.GetCoa(session, True)
      Case JenisTransaksiGL.JurnalAdjusment
        'colAkunRepo.DataSource = Logic.Coa.GetCoa(session, True)
    End Select
    If setting.MultiDivisi Then
      colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    End If
  End Sub
  Private Sub SetTitle(kode As String)
    Dim x As String = ""
    If kode <> Nothing Then
      x = "#" & kode
    End If
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.JurnalAdjusment : Me.Text = "Jurnal Adjustment : " & Tipe.ToString & x
      Case JenisTransaksiGL.JurnalUmum : Me.Text = "Jurnal Umum : " & Tipe.ToString & x
      Case JenisTransaksiGL.KasBankKeluar : Me.Text = "Kas/Bank Keluar : " & Tipe.ToString & x
      Case JenisTransaksiGL.KasBankMasuk : Me.Text = "Kas/Bank Masuk : " & Tipe.ToString & x
    End Select
  End Sub
  Private Sub SetFormat()
    colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebit.DisplayFormat.FormatString = setting.NumericFormatToString
    colDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKredit.DisplayFormat.FormatString = setting.NumericFormatToString
    colKredit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colValasDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colValasDebit.DisplayFormat.FormatString = setting.NumericFormatToString
    colValasDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colValasKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colValasKredit.DisplayFormat.FormatString = setting.NumericFormatToString
    colValasKredit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = setting.NumericFormatToString

    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
    txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
    txtValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtValas.Properties.Mask.EditMask = setting.NumericFormatToString

  End Sub
  Private Sub LoadDefault()
    If xpSettingRegional Is Nothing Then
      xpSettingRegional = New XPCollection(Of Persistent.SettingRegional)(session)
    End If
    defaultRegional = UserInfo.GetDefaultRegional(session)
    txtKontak.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtKontak)
    txtTanggal.EditValue = Now
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    End If
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.JurnalUmum
        txtCashAdvance.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCashAdvance)
        'instance.Sumber = Persistent.SumberDataJenis.JU
        'instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.JU)
      Case JenisTransaksiGL.KasBankKeluar
        txtTipe.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipe) : LoadDefaultKasBank()
        'instance.Sumber = Persistent.SumberDataJenis.KK
        'instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.KK)
      Case JenisTransaksiGL.KasBankMasuk : LoadDefaultKasBank()
        'instance.Sumber = Persistent.SumberDataJenis.KM
        'instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.KM)
      Case JenisTransaksiGL.JurnalAdjusment
        'instance.Sumber = Persistent.SumberDataJenis.JA
        'instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.JA)
    End Select
    instance.Tanggal = txtTanggal.DateTime
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
  End Sub
  Private Sub LoadDefaultKasBank()
    txtAkunGiro.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkunGiro)
    If xpSettingRegional.ToList.Exists(Function(m) m.Regional Is defaultRegional) Then
      If Not xpSettingRegional.Single(Function(m) m.Regional Is defaultRegional).AkunKas Is Nothing Then
        txtAkun.EditValue = xpSettingRegional.Single(Function(m) m.Regional Is defaultRegional).AkunKas
      Else
        txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
      End If
    Else
      txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
    End If
    txtCaraBayar.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCaraBayar)
  End Sub
  Private Sub SetSumberKasBank(item As Persistent.Coa)
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.KasBankKeluar
        If item.Tipe.Parameter = Persistent.CoaEnum.eParameter.Kas Then
          instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.KK)
        ElseIf item.Tipe.Parameter = Persistent.CoaEnum.eParameter.Bank Then
          instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.BK)
        End If
      Case JenisTransaksiGL.KasBankMasuk
        If item.Tipe.Parameter = Persistent.CoaEnum.eParameter.Kas Then
          instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.KM)
        ElseIf item.Tipe.Parameter = Persistent.CoaEnum.eParameter.Bank Then
          instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.BM)
        End If
    End Select
  End Sub
  Private Sub SetNomor()
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.JurnalUmum
        instance.Sumber = Persistent.SumberDataJenis.JU
        instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.JU)
      Case JenisTransaksiGL.KasBankKeluar
        instance.Sumber = Persistent.SumberDataJenis.KK
        instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.KK)
      Case JenisTransaksiGL.KasBankMasuk
        instance.Sumber = Persistent.SumberDataJenis.KM
        instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.KM)
      Case JenisTransaksiGL.JurnalAdjusment
        instance.Sumber = Persistent.SumberDataJenis.JA
        instance.Nomor = New Logic.NumberClass(session, Persistent.SumberDataJenis.JA)
    End Select
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtTipe.Enabled = False
    txtCashAdvance.Enabled = False
    txtUraian.Enabled = False
    txtAkun.Enabled = False
    txtMataUang.Enabled = False
    txtKurs.Enabled = False
    xGridView.OptionsBehavior.Editable = False
    txtCatatan.Enabled = False
    txtCaraBayar.Enabled = False
    txtNoCekGiro.Enabled = False
    txtNoAC.Enabled = False
    txtBank.Enabled = False
    txtAkunGiro.Enabled = False
    txtJatuhTempo.Enabled = False
    AllowSave = False
  End Sub
  Private Sub ChangeCaraBayar(item As Persistent.BankCaraBayar)
    Select Case item
      Case Persistent.BankCaraBayar.Tunai, Persistent.BankCaraBayar.Transfer, Persistent.BankCaraBayar.LainLain
        layCaraBayarDetail.Visibility = LayoutVisibility.Never
      Case Persistent.BankCaraBayar.CekGiro
        layCaraBayarDetail.Visibility = LayoutVisibility.Always
        layJatuhTempo.Visibility = LayoutVisibility.Never
      Case Persistent.BankCaraBayar.CekGiroTempo
        layCaraBayarDetail.Visibility = LayoutVisibility.Always
        layJatuhTempo.Visibility = LayoutVisibility.Always
    End Select
  End Sub
  Private Sub SimpanCaraBayar(item As Persistent.BankCaraBayar)
    Select Case item
      Case Persistent.BankCaraBayar.Tunai, Persistent.BankCaraBayar.Transfer, Persistent.BankCaraBayar.LainLain
        instance.CekGiroNomor = ""
        instance.CekGiroAC = ""
        instance.CekGiroJatuhTempo = Nothing
        instance.CekGiroAkun = Nothing
        instance.CekGiroBank = Nothing
      Case Persistent.BankCaraBayar.CekGiro
        instance.CekGiroNomor = txtNoCekGiro.Text
        instance.CekGiroAC = txtNoAC.Text
        instance.CekGiroJatuhTempo = Nothing
        instance.CekGiroAkun = CType(txtAkunGiro.EditValue, Persistent.Coa)
        instance.CekGiroBank = txtBank.Text
      Case Persistent.BankCaraBayar.CekGiroTempo
        instance.CekGiroNomor = txtNoCekGiro.Text
        instance.CekGiroAC = txtNoAC.Text
        instance.CekGiroJatuhTempo = txtJatuhTempo.DateTime
        instance.CekGiroAkun = CType(txtAkunGiro.EditValue, Persistent.Coa)
        instance.CekGiroBank = txtBank.Text
    End Select
  End Sub
  Private Sub SimpanHeader()
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.KasBankMasuk
        instance.Tipe = Nothing
        instance.Akun = CType(txtAkun.EditValue, Persistent.Coa)
      Case JenisTransaksiGL.KasBankKeluar
        instance.Tipe = CType(txtTipe.EditValue, Persistent.KasBankKeluarTipe)
        instance.Akun = CType(txtAkun.EditValue, Persistent.Coa)
      Case JenisTransaksiGL.JurnalUmum
        instance.Tipe = Nothing
        instance.Akun = Nothing
        If Not txtCashAdvance.EditValue Is Nothing Then
          instance.CashAdvance = session.GetObjectByKey(Of Persistent.GlMain)(txtCashAdvance.EditValue)
        End If
      Case JenisTransaksiGL.JurnalAdjusment
        instance.Tipe = Nothing
        instance.Akun = Nothing
        instance.CashAdvance = Nothing
    End Select
  End Sub
  Private Sub SimpanKurs()
    If setting.MultiMataUangPakai Then
      instance.MataUang = txtMataUang.Text
      instance.Kurs = CDbl(txtKurs.EditValue)
      Logic.Kurs.SaveKurs(session, setting.MultiMataUangDefault, instance.Akun.MataUang, instance.Tanggal, CDbl(txtKurs.EditValue))
    End If
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
    groupPainter.CalcFooterBounds(gi, gi.Bounds)
    Dim delta As Integer = gi.Bounds.Top - vi.Client.Top
    Dim ch As Integer = vi.Client.Height - delta - gi.Bounds.Height - gi.FooterBounds.Height
    e.Height = ch
  End Sub
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      layKontakNama.Text = CType(e.NewValue, Persistent.Kontak).Nama
    End If
  End Sub
  Private Sub txtAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAkun.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As Persistent.Coa = CType(e.NewValue, Persistent.Coa)
      layAkunKasBankNama.Text = item.Nama

      If item.Tipe.Id = Persistent.CoaEnum.eKind.Kas Then
        layCaraBayar.Visibility = LayoutVisibility.Never
        layCaraBayarDetail.Visibility = LayoutVisibility.Never
      Else
        layCaraBayar.Visibility = LayoutVisibility.Always
        layCaraBayarDetail.Visibility = LayoutVisibility.Always

        ChangeCaraBayar(CType(txtCaraBayar.EditValue, Persistent.BankCaraBayar))
      End If

      If setting.MultiMataUangPakai Then
        If setting.MultiMataUangDefault <> item.MataUang.Id Then
          txtKurs.Properties.ReadOnly = False
          txtKurs.EditValue = Logic.Kurs.getKursBank(session, item.MataUang, txtTanggal.DateTime)
          txtValas.EditValue = 0
          txtValas.Properties.ReadOnly = True
        Else
          txtKurs.EditValue = 1
          txtKurs.Properties.ReadOnly = True
          txtValas.EditValue = 0
          txtValas.Properties.ReadOnly = True
        End If
        txtMataUang.EditValue = item.MataUang.Kode
      End If
      ChangeTotalValas()

      Dim str As String = "Edit akun akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
      If Tipe = InputType.Edit AndAlso isShown AndAlso setting.FormatNomor.Contains(My.Resources.FormatAkun) Then
        If Not instance.Regional Is e.NewValue Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Akun", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Akun = item
            SetSumberKasBank(item)
            ChangeCode()
          Else
            e.Cancel = True
          End If
        Else
          instance.Akun = item
          SetSumberKasBank(item)
          ChangeCode()
        End If
      ElseIf Tipe = InputType.Tambah AndAlso setting.FormatNomor.Contains(My.Resources.FormatAkun) Then
        instance.Akun = item
        SetSumberKasBank(item)
        ChangeCode()
      End If
    End If
  End Sub
  Private Sub txtCaraBayar_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCaraBayar.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As Persistent.BankCaraBayar = CType(e.NewValue, Persistent.BankCaraBayar)
      ChangeCaraBayar(item)
    End If
  End Sub
  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
    Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit AndAlso isShown AndAlso setting.FormatNomor.Contains(My.Resources.FormatRegional) Then
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
      ElseIf Tipe = InputType.Tambah AndAlso setting.FormatNomor.Contains(My.Resources.FormatRegional) Then
        instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
        ChangeCode()
      End If

      If xpSettingRegional.ToList.Exists(Function(m) m.Regional Is instance.Regional) Then
        If Not xpSettingRegional.Single(Function(m) m.Regional Is instance.Regional).AkunKas Is Nothing Then
          txtAkun.EditValue = xpSettingRegional.Single(Function(m) m.Regional Is instance.Regional).AkunKas
        End If
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      ElseIf ex.Message.Contains("Value cannot be null") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub txtTanggal_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTanggal.DateTimeChanged
    Try
      If setting.FormatNomor.Contains(My.Resources.FormatTahun2) OrElse setting.FormatNomor.Contains(My.Resources.FormatTahun4) Then
        If setting.FormatNomor.Contains(My.Resources.FormatBulanR) OrElse setting.FormatNomor.Contains(My.Resources.FormatBulan0) Then
          GantiTanggalBulan()
        Else
          GantiTanggalTahun()
        End If
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub txtKurs_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKurs.EditValueChanging
    If Not e.NewValue Is Nothing AndAlso Not e.NewValue.ToString = "" Then
      If Not txtAkun.EditValue Is Nothing Then
        If _jenisTransaksi = JenisTransaksiGL.KasBankMasuk Then
          txtValas.EditValue = instance.Detail.Sum(Function(m) m.Kredit) / CType(e.NewValue, Double)
        Else
          txtValas.EditValue = instance.Detail.Sum(Function(m) m.Debit) / CType(e.NewValue, Double)
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.GlMainDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.GlMainDetail)
      If Not row Is Nothing Then
        If e.Column Is colNoAkun Then
          Dim akun As Persistent.Coa = CType(e.Value, Persistent.Coa)
          row.MataUang = akun.MataUang
          row.Kurs = Logic.Kurs.getKursBank(session, row.MataUang, txtTanggal.DateTime)
          If row.Debit > 0 Then
            row.DebitValas = row.Debit / row.Kurs
          End If
          If row.Kredit > 0 Then
            row.KreditValas = row.Kredit / row.Kurs
          End If
          row.Divisi = akun.Divisi
        ElseIf e.Column Is colDebit Then
          If row.Debit > 0 Then
            row.DebitValas = row.Debit / row.Kurs
            row.Kredit = 0
            row.KreditValas = 0
          End If
        ElseIf e.Column Is colKredit Then
          If row.Kredit > 0 Then
            row.KreditValas = row.Kredit / row.Kurs
            row.Debit = 0
            row.DebitValas = 0
          End If
        ElseIf e.Column Is colKurs Then
          If row.Debit > 0 Then
            row.DebitValas = row.Debit / row.Kurs
          End If
          If row.Kredit > 0 Then
            row.KreditValas = row.Kredit / row.Kurs
          End If
        End If
        ChangeTotalValas()
      End If
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.GlMainDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.GlMainDetail)
    row.Akun = Nothing
    row.Debit = 0
    row.Kredit = 0
    row.Kurs = 1
    row.Main = instance
    row.Urutan = CByte(xGridView.RowCount + 1)
    row.Divisi = Nothing
    row.Keterangan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.GlMainDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.GlMainDetail)
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
    'MsgBox("Ini Datanya:" & instance.Detail.Sum(Function(m) m.Kredit) & " / " & CType(txtKurs.EditValue, Double) & "=" & instance.Detail.Sum(Function(m) m.Kredit) / CType(txtKurs.EditValue, Double))
  End Sub
  Private Sub ChangeTotalValas()
    If txtKurs.Properties.ReadOnly = False Then
      If _jenisTransaksi = JenisTransaksiGL.KasBankMasuk Then
        txtValas.EditValue = instance.Detail.Sum(Function(m) m.Kredit) / CType(txtKurs.EditValue, Double)
      Else
        txtValas.EditValue = instance.Detail.Sum(Function(m) m.Debit) / CType(txtKurs.EditValue, Double)
      End If
    Else
      txtValas.EditValue = 0
    End If
  End Sub
End Class