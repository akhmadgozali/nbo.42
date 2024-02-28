Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class pjp_TransaksiKK
  Private instance As Persistent.xPJPGLMain
  Private setting As Logic.FinaSetting
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.xPJPGlDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.xPJPGLMain.AutoSaveOnEndEdit = False
    Persistent.xPJPGlDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New Logic.FinaSetting(session)
    colDivisi.Visible = setting.MultiDivisi
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("pjpKKTransaksi.xml")) = True Then
      LayoutControl1.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("pjpKKTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("pjpKKTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("pjpKKTransaksiGrid.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.xPJPGLMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      instance.ModuleId = MainClass.GetModuleId

      xGrid.DataSource = Nothing
      xGridTKI.DataSource = Nothing
      LoadDefault()
      txtUraian.Text = ""
      txtCatatan.Text = ""
      txtValas.EditValue = 0
      txtKurs.EditValue = 1
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
      xGridTKI.DataSource = instance.DetailTKI
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      xGridTKI.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.xPJPGLMain)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}

      txtUraian.Text = instance.Uraian
      txtCatatan.Text = instance.Catatan
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtAkun.EditValue = instance.fCOA
      txtMataUang.Text = instance.MataUang
      txtKurs.EditValue = instance.Kurs
      txtNoTransaksi.Text = instance.Kode
      txtKodeProses.EditValue = instance.ProsesTKI

      xGrid.DataSource = From p In instance.Detail Select p Where p.Urutan <> 0
      xGrid.DataSource = instance.Detail
      xGridTKI.DataSource = instance.DetailTKI
      editAssign = False
      SetSumberKasBank(instance.Akun)
      txtTipe.EditValue = instance.Tipe
    End If
    instance.Detail.CriteriaString = "Urutan <> 0"
    SetNomor()
    ChangeTotal()
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
    If txtKodeProses.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan masukkan kode proses TKI.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If


    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    ChangeTotal()
    Try
      '======= Set GL MAIN
      If Not txtNoTransaksi Is Nothing Then
        instance.Kode = txtNoTransaksi.Text
      End If
      instance.ModuleId = NPO.Modules.ModuleId.Fina
      instance.MataUang = CType(txtAkun.EditValue, Persistent.Coa).MataUang.Simbol 'instance.Akun.MataUang.Simbol
      instance.Kurs = CType(txtKurs.EditValue, Double)

      SimpanHeader()
      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
        instance.KontakNama = lblKontakNama.Text
      Else
        instance.Kontak = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Uraian = txtUraian.Text
      instance.Catatan = txtCatatan.Text
      instance.ProsesTKI = CType(txtKodeProses.EditValue, Persistent.xProsesTKI)

      Dim item As Persistent.xPJPGlDetail
      If Tipe = InputType.Tambah Then
        xGrid.DataSource = From p In instance.Detail Select p Where p.Urutan <> 0

        If instance.Detail.ToList.Exists(Function(m) m.Urutan = 0) Then
          item = instance.Detail.Single(Function(m) m.Urutan = 0)
        Else
          item = New Persistent.xPJPGlDetail(session)

          item.Akun = CType(txtAkun.EditValue, Persistent.Coa)
          item.MataUang = CType(txtAkun.EditValue, Persistent.Coa).MataUang
          item.Main = instance
          item.Urutan = 0
          item.Divisi = Nothing
          instance.Detail.Add(item)
        End If
      Else
        instance.Detail.CriteriaString = ""
        item = instance.Detail.Single(Function(m) m.Urutan = 0)
      End If

      item.Akun = CType(txtAkun.EditValue, Persistent.Coa)
      item.Debit = 0
      item.Kredit = instance.Detail.Sum(Function(m) m.Debit)
      item.Kurs = CType(txtKurs.EditValue, Double)
      item.DebitValas = 0
      item.KreditValas = CType(txtValas.EditValue, Double)
      item.Keterangan = txtUraian.Text

      '======= Simpan instance
      session.CommitChanges()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try

    '======= Konfirmasi Cetak Laporan
    Dim frm As New RF_BuktiHarian(Persistent.SumberDataCollection.GetEnum(instance.Sumber), MainClass.reportName.BuktiKasKeluar)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.BuktiKasKeluar)
    message = String.Format(message, "kas keluar")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -2 : txtAkun.Focus()
      Case -3 : txtUraian.Focus()
      Case -4 : txtTanggal.Focus()
      Case -5, -7 : xGrid.Focus()
    End Select
  End Sub
  Private Sub ChangeCode()
    If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing) Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatAkun) AndAlso (txtAkun.EditValue Is Nothing OrElse instance.Akun Is Nothing) Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatSumber) AndAlso instance.Sumber Is Nothing Then
      Return
    End If

    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    'txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    'txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub BindingDataSource()
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session)
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    colAkunRepo.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang})
    colUangRepo.DataSource = New XPCollection(Of Persistent.MataUang)(session)
    colProyekRepo.DataSource = New XPCollection(Of Persistent.Proyek)(session)

    txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Bank})
    txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.KasBankKeluarTipe))
    'txtKodeProses.Properties.DataSource = New XPCollection(Of Persistent.xProsesTKI)(session)

    If setting.MultiDivisi = True Then
      colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    End If
  End Sub
  Private Sub SetTitle(kode As String)
    Dim x As String = ""
    If kode <> Nothing Then
      x = "#" & kode
    End If
    Me.Text = "Kas Keluar : " & Tipe.ToString & x
  End Sub
  Private Sub SetFormat()
    colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebit.DisplayFormat.FormatString = setting.NumericFormatToString
    colDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colValasDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colValasDebit.DisplayFormat.FormatString = setting.NumericFormatToString
    colValasDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = setting.NumericFormatToString

    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
    txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
    txtValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtValas.Properties.Mask.EditMask = setting.NumericFormatToString

    colNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilai.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilai.SummaryItem.DisplayFormat = setting.NumericFormatString

  End Sub
  Private Sub LoadDefault()
    If xpSettingRegional Is Nothing Then
      xpSettingRegional = New XPCollection(Of Persistent.SettingRegional)(session)
    End If
    defaultRegional = UserInfo.GetDefaultRegional(session)
    'txtKontak.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtKontak)
    txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
    txtTanggal.EditValue = Now
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    End If
    txtTipe.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipe) : LoadDefaultKasBank()
    instance.Tanggal = txtTanggal.DateTime
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
  End Sub
  Private Sub LoadDefaultKasBank()
    If xpSettingRegional.ToList.Exists(Function(m) m.Regional Is defaultRegional) Then
      If Not xpSettingRegional.Single(Function(m) m.Regional Is defaultRegional).AkunKas Is Nothing Then
        txtAkun.EditValue = xpSettingRegional.Single(Function(m) m.Regional Is defaultRegional).AkunKas
      Else
        txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
      End If
    Else
      txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
    End If
  End Sub
  Private Sub SetSumberKasBank(item As Persistent.Coa)
    If editAssign = True Then
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.KK)
    End If
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.KK)
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtTipe.Enabled = False
    txtUraian.Enabled = False
    txtAkun.Enabled = False
    txtMataUang.Enabled = False
    txtKurs.Enabled = False
    xGridView.OptionsBehavior.Editable = False
    txtCatatan.Enabled = False
    AllowSave = False
  End Sub
  Private Sub SimpanHeader()
    instance.Tipe = CType(txtTipe.EditValue, Persistent.KasBankKeluarTipe)
    instance.Akun = CType(txtAkun.EditValue, Persistent.Coa)
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
    'groupPainter.CalcFooterBounds(gi, gi.Bounds)
    Dim delta As Integer = gi.Bounds.Top - vi.Client.Top
    Dim ch As Integer = vi.Client.Height - delta - gi.Bounds.Height - gi.FooterBounds.Height
    e.Height = ch
  End Sub
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      lblKontakNama.Text = CType(e.NewValue, Persistent.Kontak).Nama
    End If
  End Sub
  Private Sub txtAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAkun.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As Persistent.Coa = CType(e.NewValue, Persistent.Coa)
      lblAkunKasBankNama.Text = item.Nama

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
      ChangeTotal()

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
      ElseIf Tipe = InputType.Tambah AndAlso (setting.FormatNomor.Contains(My.Resources.FormatAkun) OrElse setting.FormatNomor.Contains(My.Resources.FormatSumber)) Then
        instance.Akun = item
        SetSumberKasBank(item)
        ChangeCode()
      End If
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
        txtValas.EditValue = instance.Detail.Sum(Function(m) m.Debit) / CType(e.NewValue, Double)
      End If
    End If
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.xPJPGlDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.xPJPGlDetail)
      If Not row Is Nothing Then
        If e.Column Is colNoAkun Then
          Dim akun As Persistent.Coa = CType(e.Value, Persistent.Coa)
          row.MataUang = akun.MataUang
          row.Kurs = Logic.Kurs.getKursBank(session, row.MataUang, txtTanggal.DateTime)
          If row.Debit > 0 Then
            If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
              row.DebitValas = 0
            Else
              row.DebitValas = row.Debit / row.Kurs
            End If
          End If
          If row.Kredit > 0 Then
            If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
              row.KreditValas = 0
            Else
              row.KreditValas = row.Kredit / row.Kurs
            End If
          End If
          row.Divisi = akun.Divisi
        ElseIf e.Column Is colDebit Then
          If row.Debit > 0 Then
            If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
              row.DebitValas = 0
            Else
              row.DebitValas = row.Debit / row.Kurs
            End If
            row.Kredit = 0
            row.KreditValas = 0
          End If
        ElseIf e.Column Is colKurs Then
          If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
            row.Kurs = 1
            row.KreditValas = 0
            row.DebitValas = 0
          Else
            If row.Debit > 0 Then
              row.DebitValas = row.Debit / row.Kurs
            End If
            If row.Kredit > 0 Then
              row.KreditValas = row.Kredit / row.Kurs
            End If
          End If
        ElseIf e.Column Is colValasDebit Then
          If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
            row.DebitValas = 0
          Else
            row.Debit = row.DebitValas * row.Kurs
          End If
        End If
        ChangeTotal()
      End If
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("pjpKKTransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.xPJPGlDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.xPJPGlDetail)
    'row.Akun = CType(Core.Win.Component.XtraLookUpEdit.GetFirstValue(colAkunRepo), Persistent.Coa)
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
      Dim Id As Persistent.xPJPGlDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.xPJPGlDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
      ChangeTotal()
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
  Private Sub ChangeTotal()
    If txtKurs.Properties.ReadOnly = False Then
      txtValas.EditValue = instance.Detail.Sum(Function(m) m.Debit) / CType(txtKurs.EditValue, Double)
    Else
      txtValas.EditValue = 0
    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub xp_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpColTKI.ResolveSession, xpColProses.ResolveSession
    e.Session = session
  End Sub
  Private Sub btnAmbilTKI_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilTKI.ItemClick
    Using frm As New pjp_TransaksiTKIDialog() With {.session = session}
      frm.IdToEdit = instance
      frm.Tipe = Core.Win.Forms.InputBase.InputType.Edit
      frm.ShowDialog()
    End Using
  End Sub
End Class