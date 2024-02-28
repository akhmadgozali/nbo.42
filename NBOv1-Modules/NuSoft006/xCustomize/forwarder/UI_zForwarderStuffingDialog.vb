Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_zForwarderStuffingDialog
  Private instance As Persistent.zForwarderStuffing
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.zForwarderStuffingDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.zForwarderStuffing.AutoSaveOnEndEdit = False
    Persistent.zForwarderStuffingDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    LoadLayout()
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.zForwarderStuffing(session)

      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      ADDDetail("LIFT ON 20'", 0, 0)
      ADDDetail("LIFT ON 40'", 0, 0)
      ADDDetail("LIFT OFF 20'", 0, 0)
      ADDDetail("LIFT OFF 40'", 0, 0)
      ADDDetail("UANG MUAT'", 0, 0)
      ADDDetail("CUSTOMS'", 0, 0)
      ADDDetail("ADM+SEAL'", 0, 0)
      ADDDetail("MATERAI'", 0, 0)
      ADDDetail("BEA CUKAI'", 0, 0)

      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.zForwarderStuffing)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Karyawan
      txtRegional.EditValue = instance.Regional
      txtDestination.EditValue = instance.Destination
      txtTipe.EditValue = instance.Tipe
      txtVessel.EditValue = instance.Vessel
      txtParty.EditValue = instance.Party
      txtInvoiceNo.EditValue = instance.InvoiceNo
      txtTglStuffing.EditValue = instance.TglStuffing
      txtETD.EditValue = instance.ETD
      txtCOA.EditValue = instance.CoaKas
      chkRealisasi.Checked = instance.JurnalRealisasi
      txtStatus.EditValue = instance.StatusTransaksi

      xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
      instance.Detail.CriteriaString = ""
      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Private Sub ADDDetail(zKeterangan As String, zQty As Double, zAnggaran As Double)
    Dim item As Persistent.zForwarderStuffingDetail
    item = New Persistent.zForwarderStuffingDetail(session)

    item.Keterangan = zKeterangan
    item.Qty = zQty
    item.Anggaran = zAnggaran
    instance.Detail.Add(item)
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
    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      If chkRealisasi.Checked = True Then
        txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
        If instance.Realisasi = 0 Then
          Throw New Utils.Exception("Nilai Realisasi 0, Silahkan masukkan data realisasinya.", 0, "", "Simpan Transaksi")
          Exit Sub
        End If
      End If

      If instance.Realisasi > 0 Then
        chkRealisasi.Checked = True
      End If

      '======= Simpan Main
      If txtNoTransaksi.EditValue Is Nothing Then
        ChangeCode()
      End If
      If Not txtKontak.EditValue Is Nothing Then
        instance.Karyawan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Karyawan = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.Vessel = txtVessel.EditValue
      instance.ETD = txtETD.DateTime
      instance.Destination = CType(txtDestination.EditValue, Persistent.zDestination)
      instance.Party = txtParty.EditValue
      instance.InvoiceNo = txtInvoiceNo.EditValue
      instance.TglStuffing = txtTglStuffing.DateTime
      instance.CoaKas = CType(txtCOA.EditValue, NuSoft001.Persistent.Coa)
      instance.JurnalRealisasi = chkRealisasi.Checked

      If Tipe = InputType.Tambah Then
        instance.GL = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      End If
      instance.GL.Sumber = instance.Sumber
      instance.GL.Tanggal = txtTanggal.EditValue
      instance.GL.Kode = instance.Kode
      instance.GL.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.GL.Kode = instance.Kode
      instance.GL.ModuleId = NPO.Modules.ModuleId.Sales
      instance.GL.MataUang = "RP"
      instance.GL.Kurs = 1
      instance.GL.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.GL.KontakNama = txtKontak.Text
      instance.GL.Uraian = "Stuffing"

      SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaCustom3)), 1, instance.Anggaran, 0, 0, 0) 'cash advance
      SimpanGL(CType(txtCOA.EditValue, NuSoft001.Persistent.Coa), 2, 0, instance.Anggaran, 0, 0) 'kas/bank

      'realisasi
      If chkRealisasi.Checked = True Then
        instance.GLRealisasi = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
        instance.GLRealisasi.Sumber = sumber.GetObject(Persistent.SumberDataJenis.TR)
        instance.GLRealisasi.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
        instance.GLRealisasi.Kode = Nothing
        instance.GLRealisasi.Tanggal = txtTanggal.EditValue
        instance.GLRealisasi.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
        instance.GLRealisasi.Kode = instance.Kode
        instance.GLRealisasi.ModuleId = NPO.Modules.ModuleId.Sales
        instance.GLRealisasi.MataUang = "RP"
        instance.GLRealisasi.Kurs = 1
        instance.GLRealisasi.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
        instance.GLRealisasi.KontakNama = txtKontak.Text
        instance.GLRealisasi.Uraian = "Realisasi Stuffing untuk : " & instance.Kode

        SimpanGLRealisasi(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaCustom2)), 2, instance.Realisasi, 0, 0, 0) 'biaya
        'selisih (kas/bank)
        Dim zSelisih As Double = instance.Anggaran - instance.Realisasi
        If zSelisih > 0 Then
          SimpanGLRealisasi(CType(txtCOA.EditValue, NuSoft001.Persistent.Coa), 3, zSelisih, 0, 0, 0) 'biaya
        Else
          zSelisih = zSelisih * -1
          SimpanGLRealisasi(CType(txtCOA.EditValue, NuSoft001.Persistent.Coa), 3, 0, zSelisih, 0, 0) 'biaya
        End If
        SimpanGLRealisasi(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaCustom3)), 4, 0, instance.Anggaran, 0, 0) 'cash advance
      End If


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
    If chkRealisasi.Checked = False Then
      Dim frm As New RF_zForwarderDataData(Persistent.SumberDataJenis.SF)
      frm.txtNoBukti1.EditValue = instance.Kode

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
      Dim reportCode As String = ""
      reportCode = MainClass.GetReport(MainClass.reportName.zForwarderStuffing)
      message = String.Format(message, "Stuffing")
      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
      'cetak jurnalnya
      Dim frm2 As New RF_DataDataJurnal
      frm2.txtNoBukti1.EditValue = instance.Kode
      Dim message2 As String = "Apakah anda ingin mencetak Jurnal Voucher dengan nomor " & instance.Kode & " ?"
      Dim reportCode2 As String = ""
      reportCode2 = MainClass.GetReport(MainClass.reportName.VoucherJurnal)
      message2 = String.Format(message2, "Jurnal Stuffing")
      Core.Win.Report.DirectExecuteReport(frm2, NamaDatabase, reportCode2, message2, salesSetting.PreviewSave)
    Else
      Dim frm2 As New RF_DataDataJurnal
      frm2.txtNoBukti1.EditValue = instance.GLRealisasi.Kode
      Dim message2 As String = "Apakah anda ingin mencetak Jurnal Voucher Realisasi dengan nomor " & instance.GLRealisasi.Kode & " ?"
      Dim reportCode2 As String = ""
      reportCode2 = MainClass.GetReport(MainClass.reportName.VoucherJurnal)
      message2 = String.Format(message2, "Jurnal Stuffing")
      Core.Win.Report.DirectExecuteReport(frm2, NamaDatabase, reportCode2, message2, salesSetting.PreviewSave)
    End If

  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
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
    txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub BindingDataSource()
    txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    txtDestination.Properties.DataSource = New XPCollection(Of Persistent.zDestination)(session)
    txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.zForwarderType))
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    txtCOA.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank})
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colAnggaran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colAnggaran.DisplayFormat.FormatString = setting.NumericFormatToString
    colAnggaran.SummaryItem.DisplayFormat = setting.NumericFormatString
    colRealisasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colRealisasi.DisplayFormat.FormatString = setting.NumericFormatToString
    colRealisasi.SummaryItem.DisplayFormat = setting.NumericFormatString
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
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Pending
    txtDestination.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtDestination)
    txtCOA.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCOA)
    txtTipe.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipe)
  End Sub
  Private Sub LoadLayout()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SFTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SFTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SFTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SFTransaksiGrid.xml"))
    End If
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SF)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtDestination.Properties.ReadOnly = True
    txtTipe.Properties.ReadOnly = True
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
      layKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
      'isikan data detailnya
      txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

      Dim xpTransaksi As New XPCollection(Of Persistent.zForwarderStuffing)(session, New BinaryOperator("Karyawan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
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
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "")
    Dim item As Persistent.GlMainDetail
    If instance.GL.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.GL.Detail.Single(Function(m) m.Urutan = Urutan)
      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.GL
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
        item.Kurs = 1
      End If
    Else
      item = New Persistent.GlMainDetail(session)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.GL
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
        item.Kurs = 1
      End If
      instance.GL.Detail.Add(item)
    End If
  End Sub
  Private Sub SimpanGLRealisasi(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "")
    Dim item As Persistent.GlMainDetail
    If instance.GLRealisasi.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.GLRealisasi.Detail.Single(Function(m) m.Urutan = Urutan)
      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.GLRealisasi
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
        item.Kurs = 1
      End If
    Else
      item = New Persistent.GlMainDetail(session)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.GLRealisasi
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
        item.Kurs = 1
      End If
      instance.GLRealisasi.Detail.Add(item)
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SFTransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.zForwarderStuffingDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.zForwarderStuffingDetail)
    row.Main = instance
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.zForwarderStuffingDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.zForwarderStuffingDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
End Class