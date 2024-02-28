Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Friend Class UI_OrderPenjualanDialog
  Private instance As Persistent.OrderPenjualan
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.OrderPenjualanDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.OrderPenjualan.AutoSaveOnEndEdit = False
    Persistent.OrderPenjualanDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    xGridView.OptionsLayout.StoreAllOptions = True
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SOTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SOTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
    End If
    colDivisi.Visible = setting.MultiDivisi
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.OrderPenjualan(session)
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.OrderPenjualan)(Convert.ToInt64(IdToEdit))
      txtStatus.EditValue = instance.StatusTransaksi
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Pelanggan
      txtAlamat.EditValue = instance.KontakAlamat
      If Not instance.KontakAlamat Is Nothing Then
        txtAlamatText.EditValue = instance.KontakAlamat.Alamat
      End If
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtPajak.EditValue = instance.TipePajak
      txtVia.EditValue = instance.Via
      txtFOB.EditValue = instance.FOB
      txtTglBerlaku.DateTime = instance.TanggalBerlaku
      txtLeadTime.EditValue = instance.LeadTime
      txtUang.EditValue = instance.Uang
      txtTermin.EditValue = instance.Termin
      txtKaryawan.EditValue = instance.Karyawan
      txtUraian.Text = instance.Uraian
      txtCatatan.Text = instance.Catatan
      txtTipe.EditValue = instance.TipeTransaksi
      txtNoRef.EditValue = instance.ReffNumber
      txtNoPenawaran.EditValue = instance.NoPenawaran
      txtCustom1.EditValue = instance.Custom1
      txtCustom2.EditValue = instance.Custom2
      txtCustom3.EditValue = instance.Custom3
      txtCustom4.EditValue = instance.Custom4
      txtCustom5.EditValue = instance.Custom5

      xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
      instance.Detail.CriteriaString = ""
      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
    xGridView.OptionsBehavior.Editable = True
    xGridView.OptionsBehavior.ReadOnly = False
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Order Penjualan [SO]: Tambah Data"
    Else
      Me.Text = "Order Penjualan [SO]: Edit Data " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl(True)
      End If
      If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
        DisableControl(False)
      End If
      If NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
        DisableControl(False)
      End If
    End If
  End Sub
  Private Sub DisableControl(xSave As Boolean)
    txtKontak.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtKontakPerson.Properties.ReadOnly = True

    txtAlamat.Properties.ReadOnly = True
    txtAlamatText.Properties.ReadOnly = True
    txtNoPenawaran.Properties.ReadOnly = True
    txtTermin.Properties.ReadOnly = True
    txtTglBerlaku.Properties.ReadOnly = True
    txtPajak.Properties.ReadOnly = True
    txtVia.Properties.ReadOnly = True
    txtUang.Properties.ReadOnly = True
    txtTipe.Properties.ReadOnly = True
    txtKaryawan.Properties.ReadOnly = True
    txtCopySO.Properties.ReadOnly = True
    btnCopy.Enabled = False
    btnAmbilDataSQ.Enabled = False

    colKodeBarang.OptionsColumn.ReadOnly = True
    colQty.OptionsColumn.ReadOnly = True
    colSatuan.OptionsColumn.ReadOnly = True
    colHarga.OptionsColumn.ReadOnly = True
    colDivisi.OptionsColumn.ReadOnly = True
    colDiscount.OptionsColumn.ReadOnly = True
    colDiscountPersen.OptionsColumn.ReadOnly = True
    colCatatan.OptionsColumn.ReadOnly = True
    colProyek.OptionsColumn.ReadOnly = True

    btnRefresh.Enabled = False
    btnRefreshNomor.Enabled = False

    txtTanggal.Properties.ReadOnly = Not xSave
    txtNoRef.Properties.ReadOnly = Not xSave
    txtLeadTime.Properties.ReadOnly = Not xSave
    txtFOB.Properties.ReadOnly = Not xSave
    txtUraian.Properties.ReadOnly = Not xSave
    txtCatatan.Properties.ReadOnly = Not xSave
    AllowSave = xSave
  End Sub

  Overrides Sub SimpanData()
    'If Not dValidation.Validate() Then
    '  Exit Sub
    'End If
    If txtStatus.Properties.ReadOnly = False Then
      If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
        Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
        Exit Sub
      End If
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
      instance.KontakAlamat = CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat)
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.TipePajak = CType(txtPajak.EditValue, NuSoft005.Persistent.eTipePajak)
      instance.Via = CType(txtVia.EditValue, NuSoft005.Persistent.Via)
      instance.FOB = CType(txtFOB.EditValue, NuSoft005.Persistent.eTipeFOB)
      instance.TanggalBerlaku = txtTglBerlaku.DateTime
      instance.LeadTime = txtLeadTime.EditValue
      instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Termin = CType(txtTermin.EditValue, NuSoft005.Persistent.Termin)
      instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
      instance.Uraian = txtUraian.Text
      instance.Catatan = txtCatatan.Text
      instance.NoPenawaran = CType(txtNoPenawaran.EditValue, Persistent.Penawaran)
      instance.TipeTransaksi = CType(txtTipe.EditValue, NuSoft004.Persistent.TipeTransaksi)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.ReffNumber = txtNoRef.Text
      instance.Custom1 = txtCustom1.Text
      instance.Custom2 = txtCustom2.Text
      instance.Custom3 = txtCustom3.Text
      instance.Custom4 = txtCustom4.Text
      instance.Custom5 = txtCustom5.Text
      If salesSetting.AutoUraian = True Then
        If Not instance.Detail(0).Proyek Is Nothing Then
          instance.Uraian = "Travel Order - " & instance.Detail(0).Proyek.Kode
        End If
      End If

      '=== simpan harga ke master data barang
      For Each item In instance.Detail
        Select Case instance.Pelanggan.LevelPenjualan
          Case NuSoft001.Persistent.eLevelPenjualan.Level1 : item.Barang.HargaJual1 = item.Harga
          Case NuSoft001.Persistent.eLevelPenjualan.Level2 : item.Barang.HargaJual2 = item.Harga
          Case NuSoft001.Persistent.eLevelPenjualan.Level3 : item.Barang.HargaJual3 = item.Harga
          Case NuSoft001.Persistent.eLevelPenjualan.Level4 : item.Barang.HargaJual4 = item.Harga
          Case NuSoft001.Persistent.eLevelPenjualan.Level5 : item.Barang.HargaJual5 = item.Harga
        End Select
      Next

      instance.Save()
      ''update status penawaran
      'If Not txtNoPenawaran.EditValue Is Nothing Then
      '  Dim xDataOrder As New XPCollection(Of Persistent.OrderPenjualanDetail)(session, New BinaryOperator("PenawaranDetail.Main.Id", CType(txtNoPenawaran.EditValue, Persistent.Penawaran).Id, BinaryOperatorType.Equal))
      '  Dim xQtySQ As Double, xQtySO As Double
      '  xQtySQ = instance.NoPenawaran.TotalQty
      '  xQtySO = xDataOrder.Sum(Function(n) n.Qty) + instance.TotalQty
      '  If xQtySO < xQtySQ Then
      '    CType(txtNoPenawaran.EditValue, Persistent.Penawaran).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
      '  Else
      '    CType(txtNoPenawaran.EditValue, Persistent.Penawaran).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
      '  End If
      'End If
      Dim noPenawaran = instance.Detail.Where(Function(w) Not w.PenawaranDetail Is Nothing).GroupBy(Function(g) g.PenawaranDetail.Main).Select(Function(s) s.Key).ToList
      For Each itemSQ In noPenawaran
        Dim xDataOrder = New XPQuery(Of Persistent.OrderPenjualanDetail)(session).Where(Function(w) w.PenawaranDetail IsNot Nothing AndAlso w.PenawaranDetail.Main Is itemSQ)
        Dim xQtySQ As Double, xQtySO As Double
        xQtySQ = itemSQ.TotalQty
        xQtySO = xDataOrder.Sum(Function(n) n.Qty) + instance.Detail.Where(Function(w) w.PenawaranDetail IsNot Nothing AndAlso w.PenawaranDetail.Main Is itemSQ).Sum(Function(s) s.Qty)
        If xQtySO < xQtySQ Then
          itemSQ.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
        Else
          itemSQ.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
        End If
      Next

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
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.SO, MainClass.reportName.VoucherSO)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherSO)
    message = String.Format(message, "Order Penjualan")
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
    If salesSetting.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)

    txtCopySO.Properties.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(session)


    txtTermin.Properties.DataSource = New XPCollection(Of NuSoft005.Persistent.Termin)(session)
    txtVia.Properties.DataSource = New XPCollection(Of NuSoft005.Persistent.Via)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session)
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    colProyekRepo.DataSource = New XPCollection(Of NuSoft001.Persistent.Proyek)(session)
    txtTipe.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.TipeTransaksi)(session)
    txtFOB.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eTipeFOB))
    txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eTipePajak))
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))

  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatString
    colPPN.SummaryItem.DisplayFormat = setting.NumericFormatString
    colPPH.SummaryItem.DisplayFormat = setting.NumericFormatString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

    colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSubTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colSubTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
    colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDiscount.DisplayFormat.FormatString = setting.NumericFormatString
    colDiscountPersen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDiscountPersen.DisplayFormat.FormatString = setting.NumericFormatString

    colFeeAgen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colFeeAgen.DisplayFormat.FormatString = setting.NumericFormatString
    colFeeAgen.SummaryItem.DisplayFormat = setting.NumericFormatString


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
    txtPajak.EditValue = NuSoft005.Persistent.eTipePajak.TanpaPajak
    txtFOB.EditValue = NuSoft005.Persistent.eTipeFOB.Origin
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtTipe.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipe)
    txtUraian.EditValue = salesSetting.UraianSO
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SO)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
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
  Private Sub txtKontak_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtKontak.ButtonClick
    If e.Button.Index = 1 Then
      Dim frm As Core.Win.Forms.InputBase = GetAddForm(sender)
      frm.session = session
      frm.Tipe = InputType.Tambah
      frm.Owner = Me
      If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        RefreshLookupSources(sender)
        '        SetValue(sender)
      End If
    End If
  End Sub
  Private Function GetAddForm(sender As Object) As Core.Win.Forms.InputBase
    If sender Is txtKontak Then
      Return New NuSoft001.UI_KontakDialog
      'ElseIf sender Is txtKontak Then
      '  Return New UI_KontakDialog
    Else
      Return Nothing
    End If
  End Function
  Private Sub SetValue(sender As Object)
    'If sender Is txtAkun Then
    '  txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetLastValue(txtAkun)
    'ElseIf sender Is txtKontak Then
    '  txtKontak.EditValue = Core.Win.Component.XtraLookUpEdit.GetLastValue(txtKontak)
    'End If
  End Sub
  Private Sub RefreshLookupSources(sender As Object)
    BindingDataSource()
  End Sub
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim val = CType(e.NewValue, NuSoft001.Persistent.Kontak)
      lblKontakNama.Text = val.Nama
      If Not val.TerminPenjualan Is Nothing Then
        txtTermin.EditValue = session.GetObjectByKey(Of NuSoft005.Persistent.Termin)(val.TerminPenjualan.Id)
      End If
      'isikan data detailnya
      txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

      txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
      If instance.NoPenawaran Is Nothing Then
        txtNoPenawaran.Properties.DataSource = New XPCollection(Of Persistent.Penawaran)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      Else
        txtNoPenawaran.Properties.DataSource = New XPCollection(Of Persistent.Penawaran)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", instance.Pelanggan, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})), New BinaryOperator("Id", instance.NoPenawaran.Id, BinaryOperatorType.Equal)))
      End If
      txtAlamat.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))

      Dim xpTransaksi As New XPCollection(Of Persistent.OrderPenjualan)(session, New BinaryOperator("Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
      xGHistory.DataSource = xpTransaksi

      txtPajak.EditValue = CType(CType(val.TipePajakPenjualan, Integer), NuSoft005.Persistent.eTipePajak)
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
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.OrderPenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.OrderPenjualanDetail)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          If txtKontak.EditValue Is Nothing Then
            MessageBox.Show("Masukkan kontak terlebih dahulu", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtKontak.Focus()
            Return
          End If

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
          row.PPN = xbarang.PajakIN
          row.PPH = xbarang.PajakOUT
          row.PPNp = xbarang.PajakIN.NilaiPajak
          row.PPHp = xbarang.PajakOUT.NilaiPajak
        End If
      End If
      If (e.Column Is colDiscountPersen) Or (e.Column Is colQty) Or (e.Column Is colHarga) Then
        If Not row Is Nothing Then
          'row.Discount = (row.DiscountPersen / 100) * (row.Qty * row.Harga)
          row.Discount = ((row.DiscountPersen / 100) * row.Harga) * row.Qty
        End If
      End If
      HitungTotal()
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.OrderPenjualanDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.OrderPenjualanDetail)
    row.Barang = Nothing
    row.Qty = 1
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.OrderPenjualanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.OrderPenjualanDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
    If e.KeyCode = Windows.Forms.Keys.F12 Then
      Dim xData As Persistent.OrderPenjualanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.OrderPenjualanDetail)
      Dim a As New NuSoft004.Logic.Stock
      a.showDataStock(Me.MenuId, Me.NamaDatabase, session, xData.Barang.Id)
    End If
  End Sub
  Private Sub xGridView_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles xGridView.CustomDrawRowIndicator
    If (e.RowHandle >= 0) Then e.Info.DisplayText = (e.RowHandle + 1).ToString()
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
  Private Sub txtNoPenawaran_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoPenawaran.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim xDataSO As New XPCollection(Of Persistent.OrderPenjualanDetail)(session, New BinaryOperator("Main.NoPenawaran", e.NewValue, BinaryOperatorType.Equal))
      Dim item As Persistent.Penawaran = CType(e.NewValue, Persistent.Penawaran)
      Dim data As Persistent.OrderPenjualanDetail
      Dim xIDPenawaran As Persistent.PenawaranDetail

      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      txtKontakPerson.EditValue = item.KontakPerson
      txtPajak.EditValue = item.TipePajak
      txtVia.EditValue = item.Via
      txtFOB.EditValue = item.FOB
      txtLeadTime.Text = item.LeadTime
      txtUang.EditValue = item.Uang
      If Not item.Termin Is Nothing Then
        txtTermin.EditValue = item.Termin
      End If
      txtAlamat.EditValue = item.Alamat
      If Not item.Alamat Is Nothing Then
        txtAlamatText.EditValue = item.Alamat.Alamat
      End If
      For i = 0 To item.Detail.Count - 1
        data = New Persistent.OrderPenjualanDetail(session)
        xIDPenawaran = item.Detail(i)
        data.Barang = item.Detail(i).Barang
        data.Qty = item.Detail(i).Qty - xDataSO.Where(Function(m) m.PenawaranDetail Is xIDPenawaran).Sum(Function(n) n.Qty)
        data.Satuan = item.Detail(i).Satuan
        data.Harga = item.Detail(i).Harga
        data.PPN = item.Detail(i).PPN
        data.PPH = item.Detail(i).PPH
        data.PPNp = item.Detail(i).PPNp
        data.PPHp = item.Detail(i).PPHp
        data.Catatan = item.Detail(i).Catatan
        data.Divisi = item.Detail(i).Divisi
        data.PenawaranDetail = item.Detail(i)
        instance.Detail.Add(data)
      Next
      HitungTotal()
    End If
  End Sub
  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      instance.TipePajak = CType(e.NewValue, NuSoft005.Persistent.eTipePajak)
      xGrid.RefreshDataSource()
      HitungTotal()
    End If
  End Sub
  Sub HitungTotal()
    txtSubTotal.EditValue = instance.SubTotal
    txtPPN.EditValue = instance.PPN
    txtPPH.EditValue = instance.PPH
    txtTotal.EditValue = instance.Total
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
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

  Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
    If Not txtCopySO.EditValue Is Nothing Then
      Dim Item As Persistent.OrderPenjualan = CType(txtCopySO.EditValue, Persistent.OrderPenjualan)
      Dim data As Persistent.OrderPenjualanDetail

      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      For i = 0 To Item.Detail.Count - 1
        data = New Persistent.OrderPenjualanDetail(session)
        data.Barang = Item.Detail(i).Barang
        data.Qty = Item.Detail(i).Qty
        data.Satuan = Item.Detail(i).Satuan
        data.Harga = Item.Detail(i).Harga
        data.PPN = Item.Detail(i).PPN
        data.PPH = Item.Detail(i).PPH
        data.PPNp = Item.Detail(i).PPNp
        data.PPHp = Item.Detail(i).PPHp
        data.Catatan = Item.Detail(i).Catatan
        data.Divisi = Item.Detail(i).Divisi
        data.Proyek = Item.Detail(i).Proyek
        instance.Detail.Add(data)
      Next
      HitungTotal()
    End If
  End Sub
  Private Sub colHargaRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colHargaRepo.ButtonClick
    If e.Button.Kind = ButtonPredefines.Glyph Then
      If txtKontak.EditValue Is Nothing Then
        MessageBox.Show("Masukkan kontak terlebih dahulu", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        txtKontak.Focus()
        Return
      End If

      Dim kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Dim row = CType(xGridView.GetFocusedRow, Persistent.OrderPenjualanDetail)
      Dim frm As New UI_HistoryHarga
      frm.LoadData(session, kontak, row.Barang, False)
      frm.ShowDialog()
    End If
  End Sub

  Private Sub btnAmbilDataSQ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilDataSQ.ItemClick
    If txtKontak.EditValue Is Nothing Then
      XtraMessageBox.Show("Pilih customer terlebih dahulu.", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    Dim frm As New UI_OrderPenjualanDialogSQ
    frm.Customer = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
    frm.session = session

    If (frm.ShowDialog = DialogResult.OK) Then
      Dim xDataSQ As List(Of Persistent.PenawaranDetail) = frm.Result
      Dim xIDPenawaran As Persistent.PenawaranDetail
      Dim xDataSO As New XPCollection(Of Persistent.OrderPenjualanDetail)(session)

      For i = 0 To xDataSQ.Count - 1
        xIDPenawaran = xDataSQ(i)
        Dim foundExistsSQ = instance.Detail.ToList.Find(Function(f) f.PenawaranDetail Is xIDPenawaran)

        If foundExistsSQ Is Nothing Then
          Dim Data = New Persistent.OrderPenjualanDetail(session)
          Data.Main = instance
          Data.Barang = xIDPenawaran.Barang
          Data.Satuan = xIDPenawaran.Satuan
          Data.Qty = xIDPenawaran.QtyBelumSO '- xDataSO.Where(Function(m) m.PenawaranDetail Is xIDPenawaran).Sum(Function(n) n.Qty)
          Data.Harga = xIDPenawaran.Harga
          Data.Discount = xIDPenawaran.Discount
          Data.DiscountPersen = xIDPenawaran.DiscountPersen
          Data.PPN = xIDPenawaran.PPN
          Data.PPNp = xIDPenawaran.PPNp
          Data.PPH = xIDPenawaran.PPH
          Data.PPHp = xIDPenawaran.PPHp
          Data.Catatan = xIDPenawaran.Catatan
          Data.Divisi = xIDPenawaran.Divisi
          Data.PenawaranDetail = xIDPenawaran

          instance.Detail.Add(Data)
        End If
      Next
      HitungTotal()
    End If
  End Sub
End Class