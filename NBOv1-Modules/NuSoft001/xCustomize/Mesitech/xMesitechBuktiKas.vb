Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class xMesitechBuktiKas
  Private instance As Persistent.xMesitechGLMain
  Private setting As Logic.FinaSetting
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.xMesitechGlDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private CASource As List(Of Persistent.SisaCashAdvance)
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.xMesitechGLMain.AutoSaveOnEndEdit = False
    Persistent.xMesitechGlDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New Logic.FinaSetting(session)
    colDivisi.Visible = setting.MultiDivisi
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("xMesitechBuktiKas.xml")) = True Then
      lytTransaksiJU.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("xMesitechBuktiKas.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("xMesitechBuktiKasGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("xMesitechBuktiKasGrid.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.xMesitechGLMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      instance.ModuleId = MainClass.GetModuleId

      xGrid.DataSource = Nothing
      LoadDefault()
      txtUraian.Text = ""
      txtCatatan.Text = ""
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.xMesitechGLMain)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}

      txtUraian.Text = instance.Uraian
      txtCatatan.Text = instance.Catatan
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.Status

      xGrid.DataSource = From p In instance.Detail Select p Where p.Urutan <> 0
      instance.Detail.CriteriaString = "Urutan <> 0"
      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    txtPrint.EditValue = 0
    txtPrint.SelectedIndex = 0
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
    'cek dulu untuk jumlah debit dan jumlah kredit
    Dim xDebit As Double = instance.Detail.Sum(Function(m) m.Debit)
    Dim xKredit As Double = instance.Detail.Sum(Function(m) m.Kredit)

    If xDebit.ToString("n4") <> xKredit.ToString("n4") Then
      Throw New Utils.Exception("Jurnal tidak seimbang. Silahkan perbaiki jurnal terlebih dahulu.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      '======= Set GL MAIN
      If Not txtNoTransaksi Is Nothing Then
        instance.Kode = txtNoTransaksi.Text
      End If
      instance.ModuleId = NPO.Modules.ModuleId.Fina
      instance.MataUang = CType(session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault)), Persistent.MataUang).Simbol 'instance.Akun.MataUang.Simbol
      instance.Kurs = 1
      instance.CaraBayar = Persistent.BankCaraBayar.Tunai
      instance.Tipe = Nothing
      instance.Akun = Nothing
      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
        instance.KontakNama = ""
      Else
        instance.Kontak = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Uraian = txtUraian.Text
      instance.Catatan = txtCatatan.Text
      instance.Status = CType(txtStatus.EditValue, Persistent.xMesitechStatusTransaksiEnum)

      For pi = 0 To instance.Detail.Count - 1
        If Not instance.Detail(pi).NomorAPP Is Nothing Then
          instance.Detail(pi).NomorAPP.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
          instance.Detail(pi).NomorAPP.RealisasiGL = instance.Detail(pi)
        End If
      Next
      '======= Simpan instance
      session.CommitChanges()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try

    '======= Konfirmasi Cetak Laporan
    Dim frm As New RF_MesitechTransaksi(Persistent.SumberDataJenis.KM, MainClass.reportName.BuktiKasMasuk)
    frm.txtNoBukti1.EditValue = instance.Kode
    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    If CType(txtPrint.EditValue, Integer) = 0 Then
      reportCode = MainClass.GetReport(MainClass.reportName.zBuktiKasMasuk)
    Else
      reportCode = MainClass.GetReport(MainClass.reportName.zBuktiKasKeluar)
    End If
    message = String.Format(message, "Bukti Kas")
    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
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
    If setting.FormatNomor.Contains(My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing) Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatSumber) AndAlso instance.Sumber Is Nothing Then
      Return
    End If

    instance.Akun = Nothing

    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    'txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    'txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub BindingDataSource()
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session)
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    colAkunRepo.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang, Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.Kas})
    colUangRepo.DataSource = New XPCollection(Of Persistent.MataUang)(session)
    colProyekRepo.DataSource = New XPCollection(Of Persistent.Proyek)(session)
    colProyekSubRepo.DataSource = New XPCollection(Of Persistent.ProyekSub)(session)
    colAPPrepo.DataSource = New XPCollection(Of Persistent.xMesitechGLMain)(session, New BinaryOperator("Sumber", Persistent.SumberDataJenis.PA, BinaryOperatorType.Equal))
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.xMesitechStatusTransaksiEnum))
  End Sub
  Private Sub SetTitle(kode As String)
    Dim x As String = ""
    If kode <> Nothing Then
      x = "#" & kode
    End If
    Me.Text = "Bukti Kas : " & Tipe.ToString & x
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

    colDBMutasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDBMutasi.DisplayFormat.FormatString = setting.NumericFormatToString
    colDBMutasi.SummaryItem.DisplayFormat = setting.NumericFormatString
    colBPLain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colBPLain.DisplayFormat.FormatString = setting.NumericFormatToString
    colBPLain.SummaryItem.DisplayFormat = setting.NumericFormatString
    colBersihDibayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colBersihDibayar.DisplayFormat.FormatString = setting.NumericFormatToString
    colBersihDibayar.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Private Sub LoadDefault()
    If xpSettingRegional Is Nothing Then
      xpSettingRegional = New XPCollection(Of Persistent.SettingRegional)(session)
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
    txtStatus.EditValue = Persistent.xMesitechStatusTransaksiEnum.Pending
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.KM)
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtUraian.Enabled = False
    xGridView.OptionsBehavior.Editable = False
    txtCatatan.Enabled = False
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
      lblKontakNama.Text = CType(e.NewValue, Persistent.Kontak).Nama
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
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.xMesitechGlDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.xMesitechGlDetail)
      If Not row Is Nothing Then
        If e.Column Is colNoAkun Then
          Dim akun As Persistent.Coa = CType(e.Value, Persistent.Coa)
          row.MataUang = akun.MataUang
          row.Kurs = Logic.Kurs.getKursBank(session, row.MataUang, txtTanggal.DateTime)
          If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
            row.DebitValas = 0
            row.KreditValas = 0
          Else
            row.DebitValas = row.Debit / row.Kurs
            row.KreditValas = row.Kredit / row.Kurs
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
        ElseIf e.Column Is colKredit Then
          If row.Kredit > 0 Then
            If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
              row.KreditValas = 0
            Else
              row.KreditValas = row.Kredit / row.Kurs
            End If
            row.Debit = 0
            row.DebitValas = 0
          End If
        ElseIf e.Column Is colKurs Then
          If row.Kurs = 0 Then
            row.Kurs = 1
          End If
          If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
            row.Kurs = 1
            row.DebitValas = 0
            row.KreditValas = 0
          Else
            row.DebitValas = row.Debit / row.Kurs
            row.KreditValas = row.Kredit / row.Kurs
          End If
        ElseIf e.Column Is colValasDebit Then
          If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
            row.DebitValas = 0
            row.KreditValas = 0
          Else
            row.Kredit = 0
            row.KreditValas = 0
            row.Debit = row.DebitValas * row.Kurs
          End If
        ElseIf e.Column Is colValasKredit Then
          If row.Akun.MataUang.Id = setting.MultiMataUangDefault Then
            row.DebitValas = 0
            row.KreditValas = 0
          Else
            row.Debit = 0
            row.DebitValas = 0
            row.Kredit = row.KreditValas * row.Kurs
          End If
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.xMesitechGlDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.xMesitechGlDetail)
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
      Dim Id As Persistent.xMesitechGlDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.xMesitechGlDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    ElseIf e.KeyCode = Windows.Forms.Keys.F6 Then
      Dim Id As Persistent.xMesitechGlDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.xMesitechGlDetail)
      'Id.Keterangan = "Sama dengan coy"
      Id.Debit = 0
      Id.Kredit = 0
      Dim xDebit As Double = instance.Detail.Sum(Function(x) x.Debit)
      Dim xKredit As Double = instance.Detail.Sum(Function(x) x.Kredit)
      If xDebit > xKredit Then
        Id.Kredit = xDebit - xKredit
      Else
        Id.Debit = xDebit - xKredit
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
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("xMesitechBuktiKasGrid.xml"))
  End Sub
  Private Sub colDebitRepo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles colDebitRepo.KeyDown
    If e.KeyCode = Windows.Forms.Keys.F6 Then
      Dim Id As Persistent.xMesitechGlDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.xMesitechGlDetail)
      Id.Debit = 0
      Id.Kredit = 0
      Dim xDebit As Double = instance.Detail.Sum(Function(x) x.Debit)
      Dim xKredit As Double = instance.Detail.Sum(Function(x) x.Kredit)
      If xDebit > xKredit Then
        Id.Kredit = xDebit - xKredit
      Else
        Id.Debit = xDebit - xKredit
      End If
    End If
  End Sub
  Private Sub colKreditRepo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles colKreditRepo.KeyDown
    If e.KeyCode = Windows.Forms.Keys.F6 Then
      Dim Id As Persistent.xMesitechGlDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.xMesitechGlDetail)
      Id.Debit = 0
      Id.Kredit = 0
      Dim xDebit As Double = instance.Detail.Sum(Function(x) x.Debit)
      Dim xKredit As Double = instance.Detail.Sum(Function(x) x.Kredit)
      If xDebit > xKredit Then
        Id.Kredit = xDebit - xKredit
      Else
        Id.Debit = xDebit - xKredit
      End If
    End If
  End Sub
End Class