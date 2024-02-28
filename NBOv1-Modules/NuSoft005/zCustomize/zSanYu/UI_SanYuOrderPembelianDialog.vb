Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem

Friend Class UI_SanYuOrderPembelianDialog
  Private instance As Persistent.SanYu_OrderPembelian
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.SanYu_OrderPembelianDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.SanYu_OrderPembelian.AutoSaveOnEndEdit = False
    Persistent.SanYu_OrderPembelianDetail.AutoSaveOnEndEdit = False
    Persistent.SanYu_KuotaImpor.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingpurchase = New Logic.PurchaseSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("POTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("POTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("POTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("POTransaksiGrid.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("ComboBarang.xml")) = True Then
      'colKodeBarangRepoGrid.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("ComboBarang.xml"))
    End If
    'Dim inventorySetting As New NuSoft004.Logic.ItemSetting(session)
    'gcCustom1.Caption = inventorySetting.CustomItem1
    'gcCustom2.Caption = inventorySetting.CustomItem2
    'gcCustom3.Caption = inventorySetting.CustomItem3
    'gcCustom4.Caption = inventorySetting.CustomItem4
    'gcCustom5.Caption = inventorySetting.CustomItem5
    'colCustom1.Caption = inventorySetting.CustomItem1
    'colCustom2.Caption = inventorySetting.CustomItem2
    'colCustom3.Caption = inventorySetting.CustomItem3
    'colCustom4.Caption = inventorySetting.CustomItem4
    'colCustom5.Caption = inventorySetting.CustomItem5
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.SanYu_OrderPembelian(session)
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.SanYu_OrderPembelian)(Convert.ToInt64(IdToEdit))
      txtStatus.EditValue = instance.StatusTransaksi
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Vendor
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtGudang.EditValue = instance.Gudang
      txtPajak.EditValue = instance.TipePajak
      txtVia.EditValue = instance.Via
      txtFOB.EditValue = instance.FOB
      txtTglBerlaku.DateTime = instance.TanggalBerlaku
      txtLeadTime.Text = instance.LeadTime
      txtUang.EditValue = instance.Uang
      txtTermin.EditValue = instance.Termin
      txtKaryawan.EditValue = instance.Karyawan
      txtUraian.Text = instance.Uraian
      txtCatatan.Text = instance.Catatan
      txtReffNo.EditValue = instance.ReffNo
      txtCustom1.EditValue = instance.Custom1
      txtCustom2.EditValue = instance.Custom2
      txtCustom3.EditValue = instance.Custom3
      txtCustom4.EditValue = instance.Custom4
      txtCustom5.EditValue = instance.Custom5
      txtDomestik.Checked = instance.DariDomestik
      LoadKuotaImpor(instance.Tanggal)

      xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
      instance.Detail.CriteriaString = ""
      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    xGridView.OptionsBehavior.Editable = True
    xGridView.OptionsBehavior.ReadOnly = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Order Pembelian : Tambah Data"
    Else
      Me.Text = "Order Pembelian : Edit Data " & instance.Kode
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
    If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.ReqApprove) Then
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
      instance.Kode = txtNoTransaksi.Text
      instance.Tanggal = txtTanggal.DateTime
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gudang = CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang)
      instance.TipePajak = CType(txtPajak.EditValue, Persistent.eTipePajak)
      instance.Via = CType(txtVia.EditValue, Persistent.Via)
      instance.FOB = CType(txtFOB.EditValue, Persistent.eTipeFOB)
      instance.TanggalBerlaku = txtTglBerlaku.DateTime
      instance.LeadTime = txtLeadTime.Text
      instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Termin = CType(txtTermin.EditValue, Persistent.Termin)
      instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
      instance.Uraian = txtUraian.Text
      instance.Catatan = txtCatatan.Text
      'instance.NoPenawaran = CType(txtNoPenawaran.EditValue, Persistent.Penawaran)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.Kurs = NuSoft001.Logic.Kurs.getKursBank(session, instance.Uang, txtTanggal.DateTime)
      instance.ReffNo = txtReffNo.Text
      instance.Custom1 = txtCustom1.Text
      instance.Custom2 = txtCustom2.Text
      instance.Custom3 = txtCustom3.Text
      instance.Custom4 = txtCustom4.Text
      instance.Custom5 = txtCustom5.Text
      instance.DariDomestik = txtDomestik.Checked

      Logic.Umum.SaveLog(session, IIf(Tipe = InputType.Tambah, Persistent.TipeLOG.Add, Persistent.TipeLOG.Edit), "Admin", "Order Pembelian : " & IIf(Tipe = InputType.Tambah, "Tambah", "Edit") & " " & instance.Kode)
      instance.Save()
      ''update status penawaran
      'If Not txtNoPenawaran.EditValue Is Nothing Then
      '	Dim xDataOrder As New XPCollection(Of Persistent.OrderPembelianDetail)(session, New BinaryOperator("PenawaranDetail.Main.Id", CType(txtNoPenawaran.EditValue, Persistent.Penawaran).Id, BinaryOperatorType.Equal))
      '	Dim xQtyRQ As Double, xQtyPO As Double
      '	xQtyRQ = instance.NoPenawaran.TotalQty
      '	xQtyPO = xDataOrder.Sum(Function(n) n.Qty) + instance.TotalQty
      '	If xQtyPO < xQtyRQ Then
      '		CType(txtNoPenawaran.EditValue, Persistent.Penawaran).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
      '	Else
      '		CType(txtNoPenawaran.EditValue, Persistent.Penawaran).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
      '	End If
      'End If

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
    Dim frm As New RF_SanYuVoucher(Persistent.SumberDataJenis.PO)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zSanyuVoucherPO)
    message = String.Format(message, "Order Pembelian")

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
    txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtGudang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(session)
    txtTermin.Properties.DataSource = New XPCollection(Of Persistent.Termin)(session)
    txtVia.Properties.DataSource = New XPCollection(Of Persistent.Via)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.SanYu_Barang)(session, New GroupOperator(GroupOperatorType.Or, New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanBaku, BinaryOperatorType.Equal), New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanPembantu, BinaryOperatorType.Equal)))
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colPPNRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    colPPHRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)

    txtFOB.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipeFOB))
    txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePajak))
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
  End Sub
  Private Sub SetFormat()
    colTonase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTonase.DisplayFormat.FormatString = "n4"
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = "n4"
    'colQty.SummaryItem.DisplayFormat = "n4"
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatString
    colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSubTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colSubTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
    colPajakInV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colPajakInV.DisplayFormat.FormatString = setting.NumericFormatString
    colPajakOutV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colPajakOutV.DisplayFormat.FormatString = setting.NumericFormatString
    colPPN.SummaryItem.DisplayFormat = setting.NumericFormatString
    colPPH.SummaryItem.DisplayFormat = setting.NumericFormatString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

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
    txtFOB.EditValue = Persistent.eTipeFOB.Origin
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtGudang.EditValue = session.GetObjectByKey(Of NuSoft004.Persistent.Gudang)(settingpurchase.GudangDefault)
    instance.TipePajak = CType(txtPajak.EditValue, Persistent.eTipePajak)
    txtUraian.EditValue = settingpurchase.UraianPO
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    txtVia.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtVia)
    txtDomestik.Checked = False
    'txtGudang.EditValue = settingpurchase.
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.PO)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtGudang.Enabled = False
    txtUraian.Enabled = False
    txtKontakPerson.Enabled = False
    txtPajak.Enabled = False
    txtVia.Enabled = False
    txtFOB.Enabled = False
    txtTglBerlaku.Enabled = False
    txtLeadTime.Enabled = False
    txtTermin.Enabled = False
    txtUang.Enabled = False
    txtKaryawan.Enabled = False
    txtReffNo.Enabled = False
    txtDomestik.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtStatus.Properties.ReadOnly = True
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

      xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_OrderPembelian)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))
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
            LoadKuotaImpor(instance.Tanggal)
          Else
            txtTanggal.EditValue = instance.Tanggal
          End If
        Else
          instance.Tanggal = txtTanggal.DateTime
          ChangeCode()
          LoadKuotaImpor(instance.Tanggal)
        End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Tanggal = txtTanggal.DateTime
        ChangeCode()
        LoadKuotaImpor(instance.Tanggal)
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
      Dim row As Persistent.SanYu_OrderPembelianDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.SanYu_OrderPembelianDetail)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          Dim xbarang As NuSoft004.Persistent.SanYu_Barang = CType(e.Value, NuSoft004.Persistent.SanYu_Barang)
          row.OutDiameter = xbarang.OutDiameter
          row.InDiameter = xbarang.InDiameter
          row.Length = xbarang.Length
          row.Thickness = xbarang.Thickness
          row.Satuan = xbarang.Satuan
          row.Harga = xbarang.LastPurchase
          row.PPN = xbarang.PajakIN
          row.PPH = xbarang.PajakOUT
          row.PPNp = xbarang.PajakIN.NilaiPajak
          row.PPHp = xbarang.PajakOUT.NilaiPajak
        End If
      End If
      If e.Column Is colPPN Then
        If Not row Is Nothing Then
          Dim xPPN As NuSoft004.Persistent.Pajak = CType(e.Value, NuSoft004.Persistent.Pajak)
          row.PPNp = xPPN.NilaiPajak
        End If
      End If
      If e.Column Is colPPH Then
        If Not row Is Nothing Then
          Dim xPPh As NuSoft004.Persistent.Pajak = CType(e.Value, NuSoft004.Persistent.Pajak)
          row.PPHp = xPPh.NilaiPajak
        End If
      End If
      HitungTotal()
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("POTransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.SanYu_OrderPembelianDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.SanYu_OrderPembelianDetail)
    row.Barang = Nothing
    row.Qty = 0
    row.Tonase = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.SanYu_OrderPembelianDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SanYu_OrderPembelianDetail)
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
  End Sub
  Private Sub txtNoPenawaran_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
    If Not e.NewValue Is Nothing And editAssign = False Then
      'Dim xDataPO As New XPCollection(Of Persistent.OrderPembelianDetail)(session, New BinaryOperator("Main.NoPenawaran", e.NewValue, BinaryOperatorType.Equal))
      'Dim item As Persistent.Penawaran = CType(e.NewValue, Persistent.Penawaran)
      'Dim data As Persistent.OrderPembelianDetail
      'For i = instance.Detail.Count - 1 To 0 Step -1
      '	instance.Detail(i).Delete()
      'Next

      'txtKontakPerson.EditValue = item.KontakPerson
      'txtGudang.EditValue = item.Gudang
      'txtPajak.EditValue = item.TipePajak
      'txtVia.EditValue = item.Via
      'txtFOB.EditValue = item.FOB
      'txtLeadTime.Text = item.LeadTime
      'txtUang.EditValue = item.Uang
      'txtTermin.EditValue = item.Termin
      'txtKaryawan.EditValue = item.Karyawan
      'txtTglBerlaku.EditValue = item.TanggalBerlaku
      'For i = 0 To item.Detail.Count - 1
      '	data = New Persistent.OrderPembelianDetail(session)
      '	data.PenawaranDetail = item.Detail(i)
      '	data.Barang = item.Detail(i).Barang
      '	data.Qty = item.Detail(i).Qty - xDataPO.Where(Function(m) m.PenawaranDetail Is data.PenawaranDetail).Sum(Function(n) n.Qty)
      '	data.Satuan = item.Detail(i).Satuan
      '	data.Harga = item.Detail(i).Harga
      '	data.PPN = item.Detail(i).PPN
      '	data.PPH = item.Detail(i).PPH
      '	data.PPNp = item.Detail(i).PPNp
      '	data.PPHp = item.Detail(i).PPHp
      '	data.Catatan = item.Detail(i).Catatan
      '	data.Divisi = item.Detail(i).Divisi
      '	instance.Detail.Add(data)
      'Next
      'HitungTotal()
    End If
  End Sub
  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      instance.TipePajak = CType(e.NewValue, Persistent.eTipePajak)
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

  Private Sub Impor()
    'Dim work As DevExpress.Spreadsheet.Workbook
    'work.LoadDocument(filePath, DocumentFormat.OpenXml)

    'Dim sheet = work.Worksheets("Permintaan Barang")
    'If Not sheet Is Nothing Then
    '  Dim x = sheet.Rows
    '  For i = 1 To x.LastUsedIndex
    '    Dim kode = x(i)(0).Value.ToString
    '    Dim z = UnitOfWork.FindObject(Of Barang)(New BinaryOperator("Kode", kode, BinaryOperatorType.Equal))
    '    If Not z Is Nothing Then
    '      Dim qty = x(i)(2).Value.ToString
    '      If CDbl(qty) <> 0 Then
    '        Dim item = source.Find(Function(m) m.Barang Is Nothing)
    '        If item Is Nothing Then
    '          item = New PermintaanStockDetail(UnitOfWork)
    '          item.Id = Now.Ticks + i
    '          source.Add(item)
    '        End If
    '        item.Barang = z
    '        item.Qty = CDbl(qty)
    '        item.Satuan = z.Satuan
    '        item.Catatan = x(i)(3).Value.ToString
    '      End If
    '    End If
    '  Next
    'End If

  End Sub
  Private Sub btnAmbilPermintaan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilPermintaan.ItemClick
    'Using frm As New UI_OrderPembelianDialogPR() With {.session = session}
    '	frm.itemToEdit = instance
    '	frm.Tipe = Core.Win.Forms.InputBase.InputType.Edit
    '	frm.ShowDialog()
    'End Using
  End Sub
  Private Sub LoadKuotaImpor(tanggal As Date)
    Dim xp = New XPCollection(Of Persistent.SanYu_KuotaImpor)(session,
                          New BinaryOperator("Expired", tanggal.Date, BinaryOperatorType.GreaterOrEqual))

    'If Tipe = InputType.Tambah Then
    '  colKuotaImporRepo2.DataSource = xp.Where(Function(w) w.SisaVolume > 0)
    'Else
    '  Dim ddd = instance.Detail.Select(Function(s) s.KuotaImpor)
    '  colKuotaImporRepo2.DataSource = xp.Where(Function(w) w.SisaVolume > 0 Or ddd.Contains(w))
    'End If
    colKuotaImporRepo2.DataSource = xp


    'colKuotaImporRepo.DataSource = New XPCollection(Of Persistent.Fusoh_KuotaImpor)(session, New GroupOperator(GroupOperatorType.And,
    '											New BinaryOperator("Expired", tanggal.Date, BinaryOperatorType.GreaterOrEqual),
    '											New BinaryOperator("VolumeTerpakai", 0, BinaryOperatorType.Equal)))
    'MsgBox(colKuotaImporRepo.DataSource.Count)
  End Sub
End Class