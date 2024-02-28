Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem

Friend Class UI_DPPembelianDialog
  Private instance As Persistent.DPPembelian
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.DPPembelian)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private SettingPurchase As Logic.PurchaseSetting

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.DPPembelian.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    SettingPurchase = New Logic.PurchaseSetting(session)
    SetFormat()
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    Logic.Umum.xLoadLayout(lytTransaksi, "DPTransaksi.xml")
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.DPPembelian(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
    Else
      editAssign = True
      instance = session.GetObjectByKey(Of Persistent.DPPembelian)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Vendor
      txtRegional.EditValue = instance.Regional
      txtPO.EditValue = instance.PO
      txtNilaiPO.EditValue = instance.PO.SubTotal
      txtUang.EditValue = instance.Uang
      txtKurs.EditValue = instance.Kurs
      txtNoFakturPajak.Text = instance.PajakSN
      txtUraian.Text = instance.Keterangan

      txtNilaiDPp.EditValue = instance.NilaiDPpersen
      txtStatus.EditValue = instance.StatusTransaksi
      txtPajak.EditValue = instance.Pajak
      txtJenisPajak.EditValue = instance.JenisPajak
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "DP Pembelian : Tambah Data"
    Else
      Me.Text = "DP Pembelian : Edit Data " & instance.Kode
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

    Dim xDPPersen = CType(txtNilaiDPp.EditValue, Double)
    If xDPPersen > 100 Then
      Throw New Utils.Exception("Nilai DP hanya diperbolehkan maksimal 100%.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If
    Dim xPO = CType(txtPO.EditValue, Persistent.OrderPembelian)
    Dim TotalDPSebelumnya = New XPQuery(Of Persistent.DPPembelian)(session).Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.AP AndAlso Not w Is instance And w.PO Is xPO).Sum(Function(s) s.NilaiDPpersen)
    If (xDPPersen + TotalDPSebelumnya) > 100 Then
      Throw New Utils.Exception("Total Nilai DP hanya diperbolehkan maksimal 100%.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If


    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      'Dim xDataInvoice As New XPCollection(Of Persistent.PenerimaanInvoice)(session, New BinaryOperator("NoOrder", CType(txtPO.EditValue, Persistent.OrderPembelian), BinaryOperatorType.Equal))
      Dim xDataInvoice As New XPCollection(Of Persistent.PenerimaanInvoice)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("NoOrder", CType(txtPO.EditValue, Persistent.OrderPembelian), BinaryOperatorType.Equal), New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.RI, BinaryOperatorType.Equal)))
      'cek dulu apakah sudah pernah ada invoice untuk PO ini, jika sudah maka ditolak.
      'alur yang sesuai adalah : PO --> DP --> DP --> Invoice (Tidak ada DP lagi setelah Invoice)
      If xDataInvoice.Count > 0 Then
        Throw New Utils.Exception(String.Format("Sudah ada Invoice untuk PO no {0}, sistem tidak dapat melanjutkan.", CType(txtPO.EditValue, Persistent.OrderPembelian).Kode), -9, "", "Simpan Data")
        Return
      End If

      '======= Simpan Main
      If Not txtKontak.EditValue Is Nothing Then
        instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Vendor = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.PO = CType(txtPO.EditValue, Persistent.OrderPembelian)
      instance.NilaiDPpersen = CType(txtNilaiDPp.EditValue, Double)
      instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Kurs = CType(txtKurs.Text, Double)
      instance.Pajak = CType(txtPajak.EditValue, NuSoft004.Persistent.Pajak)
      instance.PajakPersen = CType(txtPajak.EditValue, NuSoft004.Persistent.Pajak).NilaiPajak
      instance.JenisPajak = CType(txtJenisPajak.EditValue, Persistent.eJenisPajak)
      instance.PajakSN = txtNoFakturPajak.Text
      instance.Keterangan = txtUraian.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.CoaHutang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).HutangDagang
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
      'hutang DP (C)
      SimpanGL(CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).HutangDagang, 0, 0, CDbl(txtNilaiDP.EditValue) + CDbl(txtNilaiPajak.EditValue), 0, 0)

      If instance.PPNValue > 0 Then 'ppn (D)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(SettingPurchase.CoaPPN)), 1, txtNilaiPajak.EditValue, 0, 0, 0)
      End If
      'dp  (D)
      SimpanGL(CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).UMPembelian, 2, txtNilaiDP.EditValue, 0, txtNilaiDPValas.EditValue, 0)

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
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.AP)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherDPPembelian)
    message = String.Format(message, "DP Pembelian")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, SettingPurchase.PreviewReport)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -3 : txtUraian.Focus()
      Case -4 : txtTanggal.Focus()
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
    If SettingPurchase.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", SettingPurchase.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtPajak.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtJenisPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eJenisPajak))
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
  End Sub
  Private Sub SetFormat()
    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiPO.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiDP.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiDPValas.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiPajak.Properties.Mask.EditMask = setting.NumericFormatToString
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
    txtJenisPajak.EditValue = Persistent.eJenisPajak.UangMuka
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtNilaiPO.EditValue = 0.0
    txtNilaiDP.EditValue = 0.0
    txtNilaiDPp.EditValue = 0.0
    txtNilaiPajak.EditValue = 0.0
    txtNilaiDPValas.EditValue = 0.0
    txtKurs.EditValue = 1.0
    txtUraian.EditValue = SettingPurchase.UraianAP
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.AP)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtPO.Properties.ReadOnly = True
    txtNilaiDPp.Properties.ReadOnly = True
    txtKurs.Properties.ReadOnly = True
    txtPajak.Properties.ReadOnly = True
    txtJenisPajak.Properties.ReadOnly = True
    txtNoFakturPajak.Properties.ReadOnly = True
    txtUraian.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
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
      If SettingPurchase.ApprovalPO = True Then
        txtPO.Properties.DataSource = New XPCollection(Of Persistent.OrderPembelian)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Approved, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}), New BinaryOperator(NameOf(Persistent.OrderPembelian.TotalDPPersen), 100, BinaryOperatorType.Less)))
      Else
        txtPO.Properties.DataSource = New XPCollection(Of Persistent.OrderPembelian)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}), New BinaryOperator(NameOf(Persistent.OrderPembelian.TotalDPPersen), 100, BinaryOperatorType.Less)))
      End If
      'txtPO.Properties.DataSource = New XPCollection(Of Persistent.OrderPembelian)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress, NuSoft001.Persistent.StatusTransaksiEnum.Finish})))
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
  End Sub
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub txtPO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPO.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim xPO As Persistent.OrderPembelian = CType(e.NewValue, Persistent.OrderPembelian)
      Dim setting As New NuSoft001.Logic.FinaSetting(session)
      txtNilaiPO.Text = xPO.SubTotal
      txtUang.EditValue = xPO.Uang
      lblNilaiPO.Text = String.Format("{0} {1}", xPO.Uang.Simbol, xPO.SubTotal)
      txtNilaiDP.Text = 0
      txtNilaiDPp.Text = 0
      txtNilaiDPValas.Text = 0
      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtKurs.Text = 1
      Else
        txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, xPO.Uang, txtTanggal.DateTime)
      End If
      '===== set pajak =====
      Dim dataPajak = CType(txtPajak.Properties.DataSource, XPCollection(Of NuSoft004.Persistent.Pajak)).ToList
      If xPO.TipePajak = Persistent.eTipePajak.TanpaPajak Then
        Dim val = dataPajak.Find(Function(f) f.NilaiPajak = 0)
        txtPajak.EditValue = val
      Else
        Dim val = dataPajak.Find(Function(f) f.NilaiPajak = 10 OrElse f.NilaiPajak = 11)
        txtPajak.EditValue = val
      End If

			Dim xPajak As NuSoft004.Persistent.Pajak = CType(txtPajak.EditValue, NuSoft004.Persistent.Pajak)
			txtNilaiPajak.Text = xPajak.NilaiPajak / 100 * CType(txtNilaiDP.Text, Double)

			'=========== Informasi PO ================
			txtPOKode.Text = xPO.Kode
      txtPOTanggal.Text = xPO.Tanggal.ToString("dd MMMM yyyy")
      txtPOGudang.Text = xPO.Gudang.Nama
      txtPOReffNumber.Text = xPO.ReffNo
      txtPOUraian.Text = xPO.Uraian
      xGridPO.DataSource = xPO.Detail
    End If
  End Sub
  Private Sub txtNilaiDPp_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNilaiDPp.EditValueChanging
    'If Not e.NewValue Is Nothing Then
    '  If Not txtUang.EditValue Is Nothing Then
    '    If Not txtPO.EditValue Is Nothing Then
    '      txtNilaiDP.EditValue = ((CType(e.NewValue, Double) / 100) * CDbl(txtNilaiPO.EditValue)) * CDbl(txtKurs.EditValue)
    '      txtUraian.Text = "((" & CType(e.NewValue, Double) & " / 100) * " & CDbl(txtNilaiPO.EditValue) & ") *" & CDbl(txtKurs.EditValue) & "=" & (((e.NewValue / 100) * CDbl(txtNilaiPO.EditValue)) * CDbl(txtKurs.EditValue)).ToString

    '      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
    '        txtNilaiDPValas.EditValue = 0
    '      Else
    '        txtNilaiDPValas.EditValue = ((e.NewValue / 100) * CDbl(txtNilaiPO.EditValue))
    '      End If
    '      If Not txtPajak.EditValue Is Nothing Then
    '        txtNilaiPajak.Text = (CType(txtPajak.EditValue, NuSoft004.Persistent.Pajak).NilaiPajak / 100) * CType(txtNilaiDP.Text, Double)
    '      End If
    '    End If
    '  End If
    'End If
  End Sub
  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim xPajak As NuSoft004.Persistent.Pajak = CType(e.NewValue, NuSoft004.Persistent.Pajak)
      txtNilaiPajak.Text = xPajak.NilaiPajak / 100 * CType(txtNilaiDP.Text, Double)
    End If
  End Sub
	Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double)
		Dim item As Persistent.GlMainDetail
		If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
			item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
		Else
			item = New Persistent.GlMainDetail(session)
			instance.Gl.Detail.Add(item)
		End If
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
			item.Kurs = txtKurs.EditValue
		End If
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub

  Private Sub txtNilaiDPp_EditValueChanged(sender As Object, e As EventArgs) Handles txtNilaiDPp.EditValueChanged
    If Not txtUang.EditValue Is Nothing Then
      If Not txtPO.EditValue Is Nothing Then
        txtNilaiDP.EditValue = ((CType(txtNilaiDPp.EditValue, Double) / 100) * CDbl(txtNilaiPO.EditValue)) * CDbl(txtKurs.EditValue)
				'txtUraian.Text = "((" & CType(txtNilaiDPp.EditValue, Double) & " / 100) * " & CDbl(txtNilaiPO.EditValue) & ") *" & CDbl(txtKurs.EditValue) & "=" & (((CType(txtNilaiDPp.EditValue, Double) / 100) * CDbl(txtNilaiPO.EditValue)) * CDbl(txtKurs.EditValue)).ToString

				Dim xPajak As NuSoft004.Persistent.Pajak = CType(txtPajak.EditValue, NuSoft004.Persistent.Pajak)
				txtNilaiPajak.Text = xPajak.NilaiPajak / 100 * CType(txtNilaiDP.Text, Double)
			End If
    End If
  End Sub
End Class