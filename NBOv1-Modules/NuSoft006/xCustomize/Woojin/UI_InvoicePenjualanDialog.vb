Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class zWoojinUI_InvoicePenjualanDialog
  Private instance As Persistent.zWoojinInvoicePenjualan
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.zWoojinInvoicePenjualanDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.zWoojinInvoicePenjualan.AutoSaveOnEndEdit = False
    Persistent.zWoojinInvoicePenjualanDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    LoadLayout()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.zWoojinInvoicePenjualan(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.zWoojinInvoicePenjualan)(Convert.ToInt64(IdToEdit))

      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Pelanggan
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtAlamat.EditValue = instance.KontakAlamat
      If Not instance.KontakAlamat Is Nothing Then
        txtAlamatText.EditValue = instance.KontakAlamat.Alamat
      End If
      txtPajak.EditValue = instance.TipePajak
      txtTglBerlaku.DateTime = instance.TanggalBerlaku
      txtUang.EditValue = instance.Uang
      txtKurs.Text = instance.Kurs
      txtPajak.EditValue = instance.TipePajak
      txtUraian.Text = instance.Uraian
      txtCatatan.Text = instance.Catatan
      txtTipeTransaksi.EditValue = instance.JenisTransaksi
      txtNoSO.EditValue = instance.OrderPenjualan
      txtDP.EditValue = instance.DDP
      txtRetensi.EditValue = instance.Retensi

      txtTglBerlaku.EditValue = instance.TanggalBerlaku
      txtJenisPajak.EditValue = instance.JenisPajak
      txtNoPPN.Text = instance.NoSNPPN
      txtNoPPH.Text = instance.NoSNPPh
      txtStatus.EditValue = instance.StatusTransaksi

      txtPPHPersen.EditValue = instance.PPHPersen

      xGrid.DataSource = instance.Detail
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

    Try
      '======= Simpan Main
      If Tipe = InputType.Tambah Then
        If txtNoTransaksi.EditValue Is Nothing Then
          txtNoTransaksi.EditValue = instance.Number.GetNewNumber.Kode
        End If
      End If


      If Not txtKontak.EditValue Is Nothing Then
        instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Pelanggan = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.KontakAlamat = CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat)
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.TipePajak = CType(txtPajak.EditValue, NuSoft005.Persistent.eTipePajak)
      instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Kurs = CType(txtKurs.Text, Double)
      instance.OrderPenjualan = CType(txtNoSO.EditValue, Persistent.zWoojinOrderPenjualan)
      instance.TanggalBerlaku = txtTglBerlaku.DateTime
      instance.JenisPajak = CType(txtJenisPajak.EditValue, NuSoft005.Persistent.eJenisPajak)
      instance.NoSNPPN = txtNoPPN.Text
      instance.NoSNPPh = txtNoPPH.Text
      instance.Uraian = txtUraian.Text
      instance.Catatan = txtCatatan.Text
      instance.PPHPersen = CDbl(txtPPHPersen.EditValue)
      instance.JenisTransaksi = CType(txtTipeTransaksi.EditValue, NuSoft004.Persistent.TipeTransaksi)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.DDP = CDbl(txtDP.EditValue)
      instance.Retensi = CDbl(txtRetensi.EditValue)
      'buatkan jurnalnya
      instance.Gl.Sumber = instance.Sumber
      instance.Gl.Tanggal = txtTanggal.EditValue
      instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gl.Kode = txtNoTransaksi.EditValue
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

      'pendapatan
      SimpanGL(CType(txtTipeTransaksi.EditValue, NuSoft004.Persistent.TipeTransaksi).CoaPendapatan, i, 0, instance.SubTotal2, 0, 0, , instance.OrderPenjualan.Proyek)

      'updatekan untuk status SOnya
      instance.OrderPenjualan.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress

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
    Dim frm As New zWoojinRF_DataDataTransaksi(Persistent.SumberDataJenis.IV)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zWoojinVoucherIV)
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
    txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eTipePajak))
    txtJenisPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eJenisPajak))
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    txtTipeTransaksi.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.TipeTransaksi)(session)
    txtTipeTransaksi.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipeTransaksi)

    colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session)
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    colProyekRepo.DataSource = New XPCollection(Of NuSoft001.Persistent.Proyek)(session)
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatToString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
    txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtSubTotal.Properties.Mask.EditMask = setting.NumericFormatToString
    txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtPPN.Properties.Mask.EditMask = setting.NumericFormatToString
    txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtPPH.Properties.Mask.EditMask = setting.NumericFormatToString
    txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtTotal.Properties.Mask.EditMask = setting.NumericFormatToString

    txtDP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDP.Properties.Mask.EditMask = setting.NumericFormatToString
    txtRetensi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtRetensi.Properties.Mask.EditMask = setting.NumericFormatToString
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
    instance.PPHPersen = 0
    txtPajak.EditValue = NuSoft005.Persistent.eTipePajak.TanpaPajak
    txtKurs.Text = 1
    txtDP.EditValue = 0
    txtRetensi.EditValue = 0
    txtPPHPersen.EditValue = 3
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtUraian.EditValue = salesSetting.UraianIV
    txtJenisPajak.EditValue = NuSoft005.Persistent.eJenisPajak.Penggantian
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    txtTipeTransaksi.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipeTransaksi)
  End Sub
  Private Sub LoadLayout()
    colDivisi.Visible = setting.MultiDivisi
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.IV)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtNoSO.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtUraian.Properties.ReadOnly = True
    txtUang.Properties.ReadOnly = True
    txtKurs.Properties.ReadOnly = True
    txtKontakPerson.Properties.ReadOnly = True
    txtPajak.Properties.ReadOnly = True
    txtTglBerlaku.Properties.ReadOnly = True
    txtJenisPajak.Properties.ReadOnly = True
    txtNoPPN.Properties.ReadOnly = True
    txtNoPPH.Properties.ReadOnly = True
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

      txtAlamat.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))

      Dim xpTransaksi As New XPCollection(Of Persistent.zWoojinInvoicePenjualan)(session, New BinaryOperator("Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
      xGHistory.DataSource = xpTransaksi

      If instance.OrderPenjualan Is Nothing Then
        txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.zWoojinOrderPenjualan)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Sumber", Persistent.SumberDataJenis.SO, BinaryOperatorType.Equal), New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      Else
        txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.zWoojinOrderPenjualan)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Sumber", Persistent.SumberDataJenis.SO, BinaryOperatorType.Equal), New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})), New BinaryOperator("Id", instance.OrderPenjualan.Id, BinaryOperatorType.Equal)))
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
  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      instance.TipePajak = CType(e.NewValue, NuSoft005.Persistent.eTipePajak)
      xGrid.RefreshDataSource()
      HitungTotal()
    End If
  End Sub
  Private Sub HitungTotal()
    txtSubTotal.EditValue = instance.SubTotal2
    txtPPN.EditValue = instance.PPN
    txtPPH.EditValue = instance.PPH
    txtTotal.EditValue = instance.Total
  End Sub
  Private Sub xHitung_EditValueChanged(sender As Object, e As EventArgs) Handles txtDP.EditValueChanged, txtRetensi.EditValueChanged
    If editAssign = False Then
      instance.DDP = txtDP.EditValue
      instance.Retensi = txtRetensi.EditValue
      HitungTotal()
    End If
  End Sub

  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "", Optional zProyek As NuSoft001.Persistent.Proyek = Nothing)
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
      item.Proyek = zProyek
      instance.Gl.Detail.Add(item)
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("IVTransaksiGrid.xml"))
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    Dim row As Persistent.zWoojinInvoicePenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.zWoojinInvoicePenjualanDetail)
    If e.Column Is colKodeBarang Then
      If Not row Is Nothing Then
        Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
        Dim xHarga As Double = 0
        row.Satuan = xbarang.Satuan
        Select Case CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).LevelPenjualan
          Case NuSoft001.Persistent.eLevelPenjualan.Level1 : xHarga = xbarang.HargaJual1
          Case NuSoft001.Persistent.eLevelPenjualan.Level2 : xHarga = xbarang.HargaJual2
          Case NuSoft001.Persistent.eLevelPenjualan.Level3 : xHarga = xbarang.HargaJual3
          Case NuSoft001.Persistent.eLevelPenjualan.Level4 : xHarga = xbarang.HargaJual4
          Case NuSoft001.Persistent.eLevelPenjualan.Level5 : xHarga = xbarang.HargaJual5
        End Select
        row.Harga = xHarga
      End If
    End If
    HitungTotal()
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.zWoojinInvoicePenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.zWoojinInvoicePenjualanDetail)
    row.Barang = Nothing
    row.Qty = 1
    row.Harga = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.zWoojinInvoicePenjualanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.zWoojinInvoicePenjualanDetail)
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
  Private Sub txtAlamat_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAlamat.EditValueChanging
    If Not e.NewValue Is Nothing Then
      txtAlamatText.Text = CType(e.NewValue, NuSoft001.Persistent.KontakAlamat).Alamat
    End If
  End Sub
  Private Sub txtTermin_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
    If Not e.NewValue Is Nothing Then

    End If
  End Sub
  Private Sub txtNoSO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoSO.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim setting As New NuSoft001.Logic.FinaSetting(session)
      Dim xDataSO As Persistent.zWoojinOrderPenjualan = CType(e.NewValue, Persistent.zWoojinOrderPenjualan)
      Dim data As Persistent.zWoojinInvoicePenjualanDetail
      txtKontakPerson.EditValue = xDataSO.KontakPerson
      txtPajak.EditValue = xDataSO.TipePajak
      txtUang.EditValue = xDataSO.Uang
      instance.TipePajak = xDataSO.TipePajak
      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtKurs.Text = 1
        txtKurs.Properties.ReadOnly = True
      Else
        txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
        txtKurs.Properties.ReadOnly = False
      End If
      txtAlamat.EditValue = xDataSO.KontakAlamat
      If Not xDataSO.KontakAlamat Is Nothing Then
        txtAlamatText.EditValue = xDataSO.KontakAlamat.Alamat
      End If


      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next
      Dim xDataSOD As New XPCollection(Of Persistent.zWoojinOrderPenjualanDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main", xDataSO, BinaryOperatorType.Equal), New InOperator("Main.StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      If Not xDataSOD Is Nothing Then
        For i = 0 To xDataSOD.Count - 1
          data = New Persistent.zWoojinInvoicePenjualanDetail(session)
          data.Barang = xDataSOD(i).Barang
          data.Qty = xDataSOD(i).Qty
          data.Satuan = xDataSOD(i).Satuan
          data.Harga = xDataSOD(i).Harga
          data.Catatan = xDataSOD(i).Catatan
          data.Divisi = xDataSOD(i).Divisi
          data.OrderPenjualan = xDataSOD(i)
          instance.Detail.Add(data)
        Next
      End If
      HitungTotal()
    End If
  End Sub

  Private Sub txtPPHPersen_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPPHPersen.EditValueChanging
    instance.PPHPersen = CType(e.NewValue, Double)
    HitungTotal()
  End Sub
End Class