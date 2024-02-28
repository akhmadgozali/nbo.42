Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls

Friend Class UI_SanYuPIBDialog
  Private instance As Persistent.SanYu_PIB
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.SanYu_PIBBiaya)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.SanYu_PIB.AutoSaveOnEndEdit = False
    Persistent.SanYu_PIBBiaya.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingpurchase = New Logic.PurchaseSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("POTransaksi.xml")) = True Then
    '  lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("POTransaksi.xml"))
    'End If
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("POTransaksiGrid.xml")) = True Then
    '  xGridBiayaView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("POTransaksiGrid.xml"))
    'End If
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("ComboBarang.xml")) = True Then
    '  'colKodeBarangRepoGrid.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("ComboBarang.xml"))
    'End If
    LayoutControlGroup5.Selected = True
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.SanYu_PIB(session)
      xGridBiaya.DataSource = Nothing
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGridBiaya.DataSource = instance.Biaya
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGridBiaya.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.SanYu_PIB)(Convert.ToInt64(IdToEdit))
      txtStatus.EditValue = instance.StatusTransaksi
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Vendor
      txtRegional.EditValue = instance.Regional
      txtUraian.Text = instance.Catatan
      'txtReffNo.EditValue = instance.ReffNo
      txtMataUang.Text = instance.Uang.Kode
      txtKurs.EditValue = instance.Kurs
      txtNoPengajuan.EditValue = instance.NoPengajuan
      txtNoPendaftaran.EditValue = instance.NoPendaftaran
      txtTglPendaftaran.EditValue = instance.TglPendaftaran
      txtKPBC.EditValue = instance.KPBC
      txtUmur.EditValue = instance.Umur
      txtJatuhTempo.EditValue = instance.JatuhTempo
      txtNilaiPPNBM.EditValue = instance.TotalPajak
      txtNoIV.EditValue = instance.InvoicePembelian

      xGridBiaya.DataSource = From p In instance.Biaya Select p Where p.Id <> 0
      instance.Biaya.CriteriaString = ""
      xGridBiaya.DataSource = instance.Biaya
      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    xGridBiayaView.OptionsBehavior.Editable = True
    xGridBiayaView.OptionsBehavior.ReadOnly = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "PIB : Tambah Data"
    Else
      Me.Text = "PIB : Edit Data " & instance.Kode
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
    If txtNoPendaftaran.EditValue Is Nothing Then
      Throw New Utils.Exception("Masukkan No PIB.", 0, "", "Simpan Transaksi")
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
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Catatan = txtUraian.Text
      instance.InvoicePembelian = CType(txtNoIV.EditValue, Persistent.SanYu_PenerimaanInvoice)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.Kurs = CType(txtKurs.EditValue, Double)
      instance.ReffNo = txtNoPendaftaran.Text

      instance.NoPengajuan = txtNoPengajuan.EditValue
      instance.NoPendaftaran = txtNoPendaftaran.EditValue
      instance.TglPendaftaran = txtTglPendaftaran.EditValue
      instance.KPBC = txtKPBC.EditValue
      instance.Umur = txtUmur.EditValue
      instance.JatuhTempo = txtJatuhTempo.EditValue

      For pi = 0 To instance.Detail.Count - 1
        instance.Detail(pi).Urutan = pi + 1
      Next

      Logic.Umum.SaveLog(session, IIf(Tipe = InputType.Tambah, Persistent.TipeLOG.Add, Persistent.TipeLOG.Edit), "Admin", "PIB : " & IIf(Tipe = InputType.Tambah, "Tambah", "Edit") & " " & instance.Kode)

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
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -3 : txtUraian.Focus()
      Case -4 : txtTanggal.Focus()
      Case -5, -7 : xGridBiaya.Focus()
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
    colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.SanYu_Barang)(session, New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.Jasa, BinaryOperatorType.Equal))
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colPPNRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    colPPHRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    colBMRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
  End Sub
  Private Sub SetFormat()
    colNilaiCIF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiCIF.DisplayFormat.FormatString = setting.NumericFormatString
    colNilaiCIF.SummaryItem.DisplayFormat = setting.NumericFormatString

    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = "n4"
    colQty.SummaryItem.DisplayFormat = "n4"
    colTonase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTonase.DisplayFormat.FormatString = "n4"
    colTonase.SummaryItem.DisplayFormat = "n4"
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

    colQty2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty2.DisplayFormat.FormatString = "n4"
    colHarga2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga2.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal2.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal2.SummaryItem.DisplayFormat = setting.NumericFormatString

    colCIF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colCIF.DisplayFormat.FormatString = setting.NumericFormatString
    colBMNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colBMNilai.DisplayFormat.FormatString = setting.NumericFormatString
    colPPNNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colPPNNilai.DisplayFormat.FormatString = setting.NumericFormatString

    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = setting.NumericFormatString
    colKurs.SummaryItem.DisplayFormat = setting.NumericFormatString

    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString

    txtNilaiPPNBM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiPPNBM.Properties.Mask.EditMask = setting.NumericFormatToString

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
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtKurs.EditValue = 1
    instance.Kurs = 1
    txtUmur.EditValue = 12
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.PI)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtUraian.Enabled = False
    txtKontakPerson.Enabled = False
    txtNoIV.Enabled = False
    txtNoPendaftaran.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtStatus.Properties.ReadOnly = True
    xGridBiayaView.OptionsBehavior.Editable = False
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

      If Tipe = InputType.Tambah Then
        txtNoIV.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanInvoice)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      Else
        txtNoIV.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanInvoice)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress, NuSoft001.Persistent.StatusTransaksiEnum.Approved})), New BinaryOperator("Id", instance.InvoicePembelian.Id, BinaryOperatorType.Equal)))
      End If

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
  Private Sub xGridBiayaView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridBiayaView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.SanYu_PIBBiaya = CType(xGridBiayaView.GetRow(e.RowHandle), Persistent.SanYu_PIBBiaya)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          'Dim xbarang As NuSoft004.Persistent.Fusoh_Barang = CType(e.Value, NuSoft004.Persistent.Fusoh_Barang)
          'row.OutDiameter = xbarang.OutDiameter
          'row.InDiameter = xbarang.InDiameter
          'row.Length = xbarang.Length
          'row.Thickness = xbarang.Thickness
          'row.Satuan = xbarang.Satuan
          'row.Harga = xbarang.LastPurchase
          'row.PPN = xbarang.PajakIN
          'row.PPH = xbarang.PajakOUT
          'row.PPNp = xbarang.PajakIN.NilaiPajak
          'row.PPHp = xbarang.PajakOUT.NilaiPajak
        End If
      End If
    End If
  End Sub
  Private Sub xGridBiayaView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridBiayaView.InitNewRow
    Dim row As Persistent.SanYu_PIBBiaya = CType(xGridBiayaView.GetRow(e.RowHandle), Persistent.SanYu_PIBBiaya)
    row.Barang = Nothing
    row.Qty = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridBiayaView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridBiayaView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.SanYu_PIBBiaya = CType(xGridBiayaView.GetRow(xGridBiayaView.FocusedRowHandle), Persistent.SanYu_PIBBiaya)
      xGridBiayaView.DeleteRow(xGridBiayaView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub

  Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
    MyBase.OnKeyDown(e)
    If e.Control AndAlso e.Shift Then
      xGridBiaya.Focus()
    End If
  End Sub
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub txtNoPenawaran_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoIV.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      'Dim xDataIV As New XPCollection(Of Persistent.SanYu_PenerimaanInvoice)(session, New BinaryOperator("Id", CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice), BinaryOperatorType.Equal))

      Dim data As Persistent.SanYu_PIBDetail
      Dim xPajakBM As NuSoft004.Persistent.Pajak
      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      xPajakBM = session.GetObjectByKey(Of NuSoft004.Persistent.Pajak)(Convert.ToInt32(settingpurchase.PajakBM))
      instance.Uang = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Uang
      txtMataUang.Text = instance.Uang.Kode
      txtKurs.EditValue = NuSoft001.Logic.Kurs.getKursBank(session, instance.Uang, txtTanggal.DateTime)

      For i = 0 To CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail.Count - 1
        data = New Persistent.SanYu_PIBDetail(session)
        data.InvoiceDetail = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i)

        data.Barang = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).Barang
        data.Qty = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).Qty
        data.Tonase = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).OrderPembelian.Tonase
        data.Satuan = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).Satuan
        data.Harga = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).Harga
        data.PPN = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).PPN
        data.PPNp = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).PPNp
        data.BeaMasuk = xPajakBM
        data.BeaMasukP = xPajakBM.NilaiPajak
        data.Catatan = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).Catatan
        data.KuotaImpor = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).OrderPembelian.KuotaImpor
        data.Kite = CType(e.NewValue, Persistent.SanYu_PenerimaanInvoice).Detail(i).Barang.KITE
        instance.Detail.Add(data)
      Next
      txtNilaiPPNBM.EditValue = instance.TotalPajak
    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub txtKurs_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKurs.EditValueChanging
    instance.Kurs = CType(e.NewValue, Double)
    xGrid.RefreshDataSource()
    txtNilaiPPNBM.EditValue = instance.TotalPajak
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    txtNilaiPPNBM.EditValue = instance.TotalPajak

    If Not e.Value Is Nothing Then
      Dim row As Persistent.SanYu_PIBDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.SanYu_PIBDetail)
      If e.Column Is colBM Then
        If Not row Is Nothing Then
          Dim xBM As NuSoft004.Persistent.Pajak = CType(e.Value, NuSoft004.Persistent.Pajak)
          row.BeaMasukP = xBM.NilaiPajak
        End If
      End If
    End If
    'hitungtotal
    Dim xTotal As Double = 0
    For pi = 0 To instance.Detail.Count - 1
      If instance.Detail(pi).Kite = True Then
        xTotal = xTotal + instance.Detail(pi).PPNNilai + instance.Detail(pi).BMNilai
      End If
    Next
    txtNilaiPPNBM.EditValue = xTotal
  End Sub
  Private Sub txtTglPendaftaran_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTglPendaftaran.DateTimeChanged
    txtJatuhTempo.EditValue = DateAdd(DateInterval.Month, txtUmur.EditValue, txtTglPendaftaran.DateTime)
  End Sub
End Class