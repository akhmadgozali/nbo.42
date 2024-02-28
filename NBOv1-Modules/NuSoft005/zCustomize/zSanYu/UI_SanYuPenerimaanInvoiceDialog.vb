Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_SanYuPenerimaanInvoiceDialog
  Private instance As Persistent.SanYu_PenerimaanInvoice
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.SanYu_PenerimaanInvoiceDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.SanYu_PenerimaanInvoice.AutoSaveOnEndEdit = False
    Persistent.SanYu_PenerimaanInvoiceDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingpurchase = New Logic.PurchaseSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RITransaksi.xml")) = True Then
    '  lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RITransaksi.xml"))
    'End If
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml")) = True Then
    '  xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml"))
    'End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.SanYu_PenerimaanInvoice(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else

      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.SanYu_PenerimaanInvoice)(Convert.ToInt64(IdToEdit))
      Dim xTipePajak As Persistent.eTipePajak = instance.TipePajak
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Vendor
      txtDomestik.Checked = instance.FromDomestik
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtTglBerlaku.DateTime = instance.TanggalBerlaku
      txtUang.EditValue = instance.Uang
      txtKurs.Text = instance.Kurs
      txtPajak.EditValue = xTipePajak
      txtTermin.EditValue = instance.Termin
      txtUraian.Text = instance.Catatan
      txtNoInvoiceVendor.EditValue = instance.NoReffVendor

      txtTermin.EditValue = instance.Termin
      txtTglBerlaku.EditValue = instance.TanggalBerlaku
      txtKaryawan.EditValue = instance.Karyawan
      txtStatus.EditValue = instance.StatusTransaksi


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
    If instance.Tanggal > Now Then
      Throw New Utils.Exception("Tanggal tidak boleh melebihi hari ini.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      '======= Simpan Main
      If Tipe = InputType.Tambah Then
        If txtNoTransaksi.EditValue Is Nothing Then
          txtNoTransaksi.EditValue = instance.Number.GetNewNumber.Kode
        End If
      End If

      If Not txtKontak.EditValue Is Nothing Then
        instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Vendor = Nothing
      End If
      instance.Kode = txtNoTransaksi.Text
      instance.Tanggal = txtTanggal.DateTime
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.FromDomestik = txtDomestik.Checked
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.TipePajak = CType(txtPajak.EditValue, Persistent.eTipePajak)
      instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Kurs = CType(txtKurs.Text, Double)
      instance.Termin = CType(txtTermin.EditValue, Persistent.Termin)
      instance.TanggalBerlaku = txtTglBerlaku.DateTime
      instance.Catatan = txtUraian.Text
      instance.NoReffVendor = txtNoInvoiceVendor.Text

      instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      Logic.Umum.SaveLog(session, IIf(Tipe = InputType.Tambah, Persistent.TipeLOG.Add, Persistent.TipeLOG.Edit), "Admin", "Invoice Pembelian : " & IIf(Tipe = InputType.Tambah, "Tambah", "Edit") & " " & instance.Kode)

      instance.Save()

      'update status penerimaan
      If Not instance.NoOrder Is Nothing Then
        Dim c = From z In instance.Detail Group By z.PenerimaanBarang Into Group Select PenerimaanBarang, Qty = Group.Sum(Function(x) x.Qty)
        For Each x In c
          x.PenerimaanBarang.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
        Next
      End If

      'GL nya
      instance.Gl.Sumber = instance.Sumber
      instance.Gl.Kode = instance.Kode
      instance.Gl.Tanggal = txtTanggal.EditValue
      instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gl.Kode = txtNoTransaksi.Text
      instance.Gl.ModuleId = NPO.Modules.ModuleId.Purchase
      instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
      instance.Gl.Kurs = txtKurs.EditValue
      instance.Gl.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.Gl.KontakNama = txtKontak.Text
      instance.Gl.Uraian = txtUraian.Text



      Dim i As Byte = 1
      'hutang sementara  (D) -->ambilkan dari DPP
      If txtDomestik.Checked = False Then
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaHutangSementara)), i, instance.SubTotal * instance.Kurs, 0, instance.SubTotal, 0)
      Else
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaHutangSementara)), i, instance.Detail.Sum(Function(m) m.PenerimaanBarang.SubTotal) * instance.Kurs, 0, instance.Detail.Sum(Function(m) m.PenerimaanBarang.SubTotal), 0)
      End If
      i = i + 1

      If instance.PPN > 0 Then      'PPN (D)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaPPN)), i, (instance.PPN) * instance.Kurs, 0, 0, 0)
        i = i + 1
      End If

      If instance.PPH > 0 Then      'PPH (K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaPPH)), i, 0, instance.PPH * instance.Kurs, 0, 0)
        i = i + 1
      End If

      'hutang (K)
      SimpanGL(instance.Uang.HutangDagang, i, 0, instance.Total * instance.Kurs, 0, instance.Total)
      i = i + 1

      'delete yg diatas i
      If instance.Gl.Detail.Count > i Then
        For pi = instance.Gl.Detail.Count - 1 To i Step -1
          instance.Gl.Detail(pi).Delete()
        Next
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
    End Try
    '======= Konfirmasi Cetak Laporan
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.RI)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zSanyuVoucherRI)
    message = String.Format(message, "Invoice Pembelian")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingpurchase.PreviewReport)
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
    txtTermin.Properties.DataSource = New XPCollection(Of Persistent.Termin)(session)
    txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePajak))
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    colProyekRepo.DataSource = New XPCollection(Of NuSoft001.Persistent.Proyek)(session)
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = "n4"
    colQty.SummaryItem.DisplayFormat = "n4"
    'colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQty.DisplayFormat.FormatString = "n4"
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatToString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colPPH.SummaryItem.DisplayFormat = setting.NumericFormatString
    colPPN.SummaryItem.DisplayFormat = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
    colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSubTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDisc.DisplayFormat.FormatString = setting.NumericFormatToString
    colDiscP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDiscP.DisplayFormat.FormatString = setting.NumericFormatToString

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
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    txtUraian.EditValue = settingpurchase.UraianRI
  End Sub
  'Private Sub SetNomor()
  '  instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.RI)
  '  instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  'End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.RI)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
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
    txtPajak.Enabled = False
    txtNoInvoiceVendor.Enabled = False
    txtTglBerlaku.Enabled = False
    txtTermin.Enabled = False
    txtKaryawan.Enabled = False
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

      xGHistory.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanInvoice)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))

      If editAssign = False Then
        'hapus transaksi detailnya dulu,
        For i = instance.Detail.Count - 1 To 0 Step -1
          instance.Detail(i).Delete()
        Next
      End If
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
  Private Sub HitungTotal()
    txtSubTotal.EditValue = instance.SubTotal
    txtPPN.EditValue = instance.PPN
    txtPPH.EditValue = instance.PPH
    txtTotal.EditValue = instance.Total
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub

  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    HitungTotal()
  End Sub
  'Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
  '  If Not e.Value Is Nothing Then
  '    Dim row As Persistent.PenerimaanInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PenerimaanInvoiceDetail)
  '    If e.Column Is colKodeBarang Then
  '      If Not row Is Nothing Then
  '        Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
  '        row.Satuan = xbarang.Satuan
  '        row.Harga = xbarang.LastPurchase
  '        row.PPN = xbarang.PajakIN
  '        row.PPH = xbarang.PajakOUT
  '        row.PPNp = xbarang.PajakIN.NilaiPajak
  '        row.PPHp = xbarang.PajakOUT.NilaiPajak
  '      End If
  '    End If
  '    HitungTotal()
  '  End If
  'End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.SanYu_PenerimaanInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.SanYu_PenerimaanInvoiceDetail)
    row.Barang = Nothing
    row.Qty = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.SanYu_PenerimaanInvoiceDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SanYu_PenerimaanInvoiceDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      instance.TipePajak = CType(e.NewValue, Persistent.eTipePajak)
      xGrid.RefreshDataSource()
      HitungTotal()
    End If
  End Sub
  Private Sub btnAmbilData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilData.ItemClick
    If txtKontak.EditValue Is Nothing Then
      MsgBox("Silahkan pilih vendor terlebih dahulu.", vbInformation, "Informasi")
      Exit Sub
    End If

    If txtDomestik.Checked = True Then
      Dim frm As New UI_SanYuPenerimaanInvoiceGR
      frm.session = session
      frm.instance = instance
      frm.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      'frm.Serial = instance.BahanBaku.Where(Function(w) w.Barang Is barang).ToList

      If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        For i = 0 To frm.GRResult.Count - 1
          Dim xdt = frm.GRResult(i)
          LoadGR(xdt)
        Next
      End If

    Else
      Dim frm As New UI_SanYuPenerimaanInvoicePO
      frm.session = session
      frm.instance = instance
      frm.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      'frm.Serial = instance.BahanBaku.Where(Function(w) w.Barang Is barang).ToList

      If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        For i = 0 To frm.POResult.Count - 1
          Dim xdt = frm.POResult(i)
          LoadPO(xdt)
        Next
      End If
    End If
  End Sub
  Private Sub LoadPO(xDataPO As Persistent.SanYu_OrderPembelian)
    Dim data As Persistent.SanYu_PenerimaanInvoiceDetail
    txtKontakPerson.EditValue = xDataPO.KontakPerson
    txtPajak.EditValue = xDataPO.TipePajak
    txtUang.EditValue = xDataPO.Uang
    txtTermin.EditValue = xDataPO.Termin
    txtKaryawan.EditValue = xDataPO.Karyawan
    instance.TipePajak = xDataPO.TipePajak
    If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
      txtKurs.Text = 1
      txtKurs.Properties.ReadOnly = True
    Else
      txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
      txtKurs.Properties.ReadOnly = False
    End If
    If Not txtTermin.EditValue Is Nothing Then
      txtTglBerlaku.EditValue = DateAdd(DateInterval.Day, CType(txtTermin.EditValue, Persistent.Termin).Tempo, txtTanggal.DateTime)
    End If
    For i = 0 To xDataPO.Detail.Count - 1
      data = New Persistent.SanYu_PenerimaanInvoiceDetail(session)
      data.OrderPembelian = xDataPO.Detail(i)
      data.Barang = xDataPO.Detail(i).Barang
      data.Qty = xDataPO.Detail(i).Qty
      data.Satuan = xDataPO.Detail(i).Satuan
      data.Harga = xDataPO.Detail(i).Harga
      data.Discount = (data.DiscountPersen / 100) * data.Harga '(row.DiscountPersen / 100) * (row.Harga)
      data.PPN = xDataPO.Detail(i).PPN
      data.PPNp = xDataPO.Detail(i).PPNp
      data.PPH = xDataPO.Detail(i).PPH
      data.PPHp = xDataPO.Detail(i).PPHp
      data.Catatan = xDataPO.Detail(i).Catatan
      instance.Detail.Add(data)
    Next
    HitungTotal()
  End Sub
  Private Sub LoadGR(xDataGR As Persistent.SanYu_PenerimaanBarang)
    Dim data As Persistent.SanYu_PenerimaanInvoiceDetail
    txtKontakPerson.EditValue = xDataGR.KontakPerson
    txtUang.EditValue = xDataGR.Detail(0).NoOrder.Main.Uang
    txtTermin.EditValue = xDataGR.Detail(0).NoOrder.Main.Termin
    txtKaryawan.EditValue = xDataGR.Karyawan
    instance.TipePajak = xDataGR.Detail(0).NoOrder.Main.TipePajak
    If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
      txtKurs.Text = 1
      txtKurs.Properties.ReadOnly = True
    Else
      txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
      txtKurs.Properties.ReadOnly = False
    End If
    If Not txtTermin.EditValue Is Nothing Then
      txtTglBerlaku.EditValue = DateAdd(DateInterval.Day, CType(txtTermin.EditValue, Persistent.Termin).Tempo, txtTanggal.DateTime)
    End If
    For i = 0 To xDataGR.Detail.Count - 1
      data = New Persistent.SanYu_PenerimaanInvoiceDetail(session)
      data.PenerimaanBarang = xDataGR.Detail(i)
      data.OrderPembelian = xDataGR.Detail(i).NoOrder
      data.Barang = xDataGR.Detail(i).Barang
      data.Qty = xDataGR.Detail(i).Qty
      data.Satuan = xDataGR.Detail(i).Satuan
      data.Harga = xDataGR.Detail(i).Harga
      data.Discount = (data.DiscountPersen / 100) * data.Harga '(row.DiscountPersen / 100) * (row.Harga)
      data.PPN = xDataGR.Detail(i).NoOrder.PPN
      data.PPNp = xDataGR.Detail(i).NoOrder.PPNp
      data.PPH = xDataGR.Detail(i).NoOrder.PPH
      data.PPHp = xDataGR.Detail(i).NoOrder.PPHp
      data.Catatan = xDataGR.Detail(i).Catatan
      instance.Detail.Add(data)
    Next
    HitungTotal()
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "", Optional Proyek As NuSoft001.Persistent.Proyek = Nothing)
    Dim item As Persistent.GlMainDetail
    If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)

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
      'item.Proyek = Proyek
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
      'item.Proyek = Proyek
      'MsgBox("Add GL : " & item.Akun.Nama)
      instance.Gl.Detail.Add(item)
    End If
  End Sub
End Class