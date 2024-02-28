Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_POSDialog
  Private instance As Persistent.PengirimanBarang
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.PengirimanBarangDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting
  Private xUang As NuSoft001.Persistent.MataUang
  Private xKasir As NuSoft001.Persistent.Kontak
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.PengirimanBarang.AutoSaveOnEndEdit = False
    Persistent.PengirimanBarangDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    xUang = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("QSDialog.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("QSDialog.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("QSDialogGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("QSDialogGrid.xml"))
    End If
    If salesSetting.POSAddRowGrid = True Then
      xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Else
      xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
    End If
    If salesSetting.POSBarangCombo = True Then
      lytBarangBarcode.Visibility = LayoutVisibility.Never
      lytBarangCombo.Visibility = LayoutVisibility.Always
    Else
      lytBarangBarcode.Visibility = LayoutVisibility.Always
      lytBarangCombo.Visibility = LayoutVisibility.Never
    End If
    'DockPanel2.FloatForm.KeyPreview = False
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.PengirimanBarang(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      HitungTotal()
      txtBarcode.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.PengirimanBarang)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Pelanggan
      txtRegional.EditValue = instance.Regional
      txtGudang.EditValue = instance.Gudang
      txtUang.EditValue = instance.MataUang
      txtKurs.EditValue = instance.Kurs
      txtKaryawan.EditValue = instance.Karyawan
      txtUraian.Text = instance.Uraian
      txtStatus.EditValue = instance.StatusTransaksi

      txtCash.EditValue = instance.POSCash
      txtKredit.EditValue = instance.POSCredit
      txtDebit.EditValue = instance.POSDebit

      HitungTotal()
      HitungKembalian()

      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Point Of Sale [QS]: Tambah Data"
    Else
      Me.Text = "Point Of Sale [QS]: Edit Data " & instance.Kode
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
    Dim xJmlCard As Double
    xJmlCard = CDbl(CDbl(txtDebit.EditValue) + CDbl(txtKredit.EditValue))

    If CDbl(txtCash.EditValue) + xJmlCard < instance.POSTotalTransaksi Then
      Throw New Utils.Exception("Pembayaran kurang.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If


    If txtCash.EditValue > 0 Then
      If xJmlCard > instance.POSTotalTransaksi Then
        Throw New Utils.Exception("Pembayaran dengan memakai kartu debit/kredit tidak boleh lebih besar dari transaksi.", 0, "", "Simpan Transaksi")
        Exit Sub
      End If
    Else
      If xJmlCard.ToString("n4") <> instance.POSTotalTransaksi.ToString("n4") Then
        Throw New Utils.Exception("Pembayaran dengan memakai kartu debit/kredit tidak boleh lebih besar dari transaksi.", 0, "", "Simpan Transaksi")
        Exit Sub
      End If
    End If


    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next
    For pI = 0 To instance.Detail.Count - 1
      For pJ = 0 To instance.Detail(pI).HPPReff.Count - 1
        instance.Detail(pI).HPPReff(pJ).Delete()
      Next
    Next


    Try
      '======= Simpan Main
      If Not txtKontak.EditValue Is Nothing Then
        instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Pelanggan = Nothing
      End If
      If txtNoTransaksi.Text Is Nothing OrElse txtNoTransaksi.Text = "" Then
        Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
        txtNoTransaksi.Text = nomor.Kode
      End If

      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gudang = CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang)
      instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
      instance.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Kurs = CType(txtKurs.Text, Double)
      instance.Uraian = txtUraian.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)

      Dim data As Persistent.PengirimanBarangDetailHPP
      For pI = 0 To instance.Detail.Count - 1
        instance.Detail(pI).Gudang = instance.Gudang
        Dim pQTY As Double
        pQTY = instance.Detail(pI).Qty
        Dim xDataHPP As New XPCollection(Of Persistent.vwHPP)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("f_item.Id", instance.Detail(pI).Barang.Id, BinaryOperatorType.Equal), New BinaryOperator("d_available", 0, BinaryOperatorType.Greater), New BinaryOperator("f_warehouse.Id", instance.Detail(pI).Gudang.Id, BinaryOperatorType.Equal)))
        For pJ = 0 To xDataHPP.Count - 1
          data = New Persistent.PengirimanBarangDetailHPP(session)
          data.PenerimaanBarang = xDataHPP(pJ).Id
          If pQTY > xDataHPP(pJ).d_available Then
            pQTY = pQTY - xDataHPP(pJ).d_available
            data.Qty = xDataHPP(pJ).d_available
          Else
            data.Qty = pQTY
            pQTY = 0
          End If
          instance.Detail(pI).HPPReff.Add(data)
          If pQTY = 0 Then
            Exit For
          End If
        Next
      Next

      instance.POSCash = CDbl(txtCash.EditValue)
      instance.POSCredit = CDbl(txtKredit.EditValue)
      instance.POSDebit = CDbl(txtDebit.EditValue)


      For pJ = 0 To instance.Detail.Count - 1
        If instance.Detail(pJ).Qty > instance.Detail(pJ).HPPReff.Sum(Function(m) m.Qty) Then
          Throw New Utils.Exception("HPP Barang [" & instance.Detail(pJ).Barang.Kode & "] tidak tersedia.", -99, "", "")
          Exit Sub
        End If
      Next
      instance.Save()


      'For pJ = 0 To instance.Detail(0).HPPReff.Count - 1
      '  MsgBox("HPP : " & instance.Detail(0).HPPReff(pJ).PenerimaanBarang.HargaIn)
      'Next

      'buatkan jurnalnya
      instance.Gl.Sumber = instance.Sumber
      instance.Gl.Tanggal = txtTanggal.EditValue
      instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gl.Kode = txtNoTransaksi.Text
      instance.Gl.ModuleId = NPO.Modules.ModuleId.Sales
      instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
      instance.Gl.Kurs = txtKurs.EditValue
      instance.Gl.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.Gl.KontakNama = txtKontak.Text
      instance.Gl.Uraian = txtUraian.Text

      ''HPP (D)    looping dari setingan master coa
      Dim a = From z In instance.Detail Group z By z.Barang.CoaCost Into Group Select CoaCost, NilaiHPP = Group.Sum(Function(x) x.NilaiHPP)
      Dim i As Byte = 1
      For Each x In a
        SimpanGL(x.CoaCost, i, x.NilaiHPP, 0)
        i = i + 1
      Next
      'Persediaan (C)
      Dim b = From z In instance.Detail Group z By z.Barang.CoaStock Into Group Select CoaStock, NilaiHPP = Group.Sum(Function(x) x.NilaiHPP)
      For Each x In b
        SimpanGL(x.CoaStock, i, 0, x.NilaiHPP)
        i = i + 1
      Next

      'jurnal pendapatannya,ppn, cash.
      If instance.POSNilaiPPN > 0 Then
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPN)), i, 0, instance.POSNilaiPPN)
        i = i + 1
      End If
      If instance.POSCash > 0 Then
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.POSCOACash)), i, instance.POSCash - CDbl(txtKembalian.EditValue), 0)
        i = i + 1
      End If
      If instance.POSCredit > 0 Then
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.POSCOACredit)), i, instance.POSCredit, 0)
        i = i + 1
      End If
      If instance.POSDebit > 0 Then
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.POSCOADebit)), i, instance.POSDebit, 0)
        i = i + 1
      End If
      SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.POSCoaPendapatan)), i, 0, instance.POSTotalTransaksi - instance.POSNilaiPPN)

      For pi = i To instance.Gl.Detail.Count - 1
        instance.Gl.Detail(i).Delete()
      Next

      xKasir = instance.Karyawan
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
    System.Diagnostics.Process.Start("http://" & salesSetting.POSServerStruk & "/struk.php?db=" & NamaDatabase & "&nomor=" & txtNoTransaksi.Text)

    ''cetak struk
    'Dim myProcess As New Process()
    'myProcess.StartInfo.FileName = "C:\Program Files\Secure Time Attendance\SecureAttendanceRetrieve.exe"
    'myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
    'myProcess.Start()


    'Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.QS)
    'frm.txtNoBukti1.EditValue = instance.Kode

    'Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    'Dim reportCode As String = ""
    'reportCode = MainClass.GetReport(MainClass.reportName.VoucherSJ)
    'message = String.Format(message, "Point Of Sale")

    'Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
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
    txtGudang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session)
    txtKodeBarang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session)
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatToString
    colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSubTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colSubTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

    txtCash.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtCash.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDebit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDebit.Properties.Mask.EditMask = setting.NumericFormatToString
    txtKredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKredit.Properties.Mask.EditMask = setting.NumericFormatToString
    txtKembalian.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKembalian.Properties.Mask.EditMask = setting.NumericFormatToString
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
    txtUraian.EditValue = salesSetting.UraianQS
    txtKontak.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Kontak)(Convert.ToInt64(salesSetting.POSPelanggan))
    txtKaryawan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Kontak)(Convert.ToInt64(salesSetting.KaryawanDefault))
    instance.TipePajak = CType(salesSetting.POSPajak, NuSoft005.Persistent.eTipePajak)
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    txtGudang.EditValue = session.GetObjectByKey(Of NuSoft004.Persistent.Gudang)(Convert.ToInt32(salesSetting.GudangDefault))
    txtKurs.EditValue = 1.0
    txtCash.EditValue = 0.0
    txtDebit.EditValue = 0.0
    txtKredit.EditValue = 0.0
    txtKembalian.EditValue = 0.0
    txtQty.EditValue = 1.0
    If Not xKasir Is Nothing Then
      txtKaryawan.EditValue = xKasir
    End If
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.QS)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtGudang.Enabled = False
    txtKaryawan.Enabled = False
    txtStatus.Enabled = False
    txtUraian.Enabled = False
    xGridView.OptionsBehavior.Editable = False
    xGridView.OptionsBehavior.ReadOnly = True
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

      Dim xpTransaksi As New XPCollection(Of Persistent.PengirimanBarang)(session, New BinaryOperator("Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
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
      Dim row As Persistent.PengirimanBarangDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PengirimanBarangDetail)
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
      HitungKembalian()
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.PengirimanBarangDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PengirimanBarangDetail)
    row.Barang = Nothing
    row.Qty = 1
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.PengirimanBarangDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.PengirimanBarangDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("QSDialogGrid.xml"))
  End Sub
  Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double)
    Dim item As Persistent.GlMainDetail
    If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Kurs = 1
      item.DebitValas = 0
      item.KreditValas = 0
    Else
      item = New Persistent.GlMainDetail(session)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Kurs = 1
      item.DebitValas = 0
      item.KreditValas = 0
      instance.Gl.Detail.Add(item)
    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub HitungTotal()
    lbTotalTransaksi.Text = "Total : " & xUang.Simbol & " " & instance.POSTotalTransaksi.ToString("n2")
    lbPPN.Text = "PPN : " & instance.POSNilaiPPN.ToString("n2")
    lbDPP.Text = "DPP : " & instance.POSDPP.ToString("n2")
    txtCash.EditValue = instance.POSTotalTransaksi
  End Sub
  Private Sub HitungKembalian()
    txtKembalian.EditValue = (CDbl(txtCash.EditValue) + CDbl(txtDebit.EditValue) + CDbl(txtKredit.EditValue)) - instance.POSTotalTransaksi
    If txtKembalian.EditValue < 0 Then txtKembalian.EditValue = 0
  End Sub
  Private Sub Pembayaran_EditValueChanged(sender As Object, e As EventArgs) Handles txtCash.EditValueChanged, txtDebit.EditValueChanged, txtKredit.EditValueChanged
    HitungKembalian()
  End Sub
  Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
    'isikan ke grid nya.
    Dim item As Persistent.PengirimanBarangDetail, xHarga As Double
    Dim xKodeItem As String = ""
    If salesSetting.POSBarangCombo = True Then
      xKodeItem = CType(txtKodeBarang.EditValue, NuSoft004.Persistent.Barang).Kode
    Else
      xKodeItem = txtBarcode.EditValue
    End If
    Dim xData As New XPCollection(Of NuSoft004.Persistent.Barang)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Kode", xKodeItem, BinaryOperatorType.Like)))
    If xData.Count > 0 Then
      If instance.Detail.ToList.Exists(Function(m) m.Barang.Id = xData(0).Id) Then
        item = instance.Detail.Single(Function(m) m.Barang.Id = xData(0).Id)
        item.Qty = item.Qty + CDbl(txtQty.EditValue)
      Else
        item = New Persistent.PengirimanBarangDetail(session)
        item.Barang = xData(0)
        item.Satuan = xData(0).Satuan
        item.Qty = txtQty.EditValue

        Select Case CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).LevelPenjualan
          Case NuSoft001.Persistent.eLevelPenjualan.Level1 : xHarga = xData(0).HargaJual1
          Case NuSoft001.Persistent.eLevelPenjualan.Level2 : xHarga = xData(0).HargaJual2
          Case NuSoft001.Persistent.eLevelPenjualan.Level3 : xHarga = xData(0).HargaJual3
          Case NuSoft001.Persistent.eLevelPenjualan.Level4 : xHarga = xData(0).HargaJual4
          Case NuSoft001.Persistent.eLevelPenjualan.Level5 : xHarga = xData(0).HargaJual5
        End Select
        item.Harga = xHarga
        instance.Detail.Add(item)
      End If
      HitungTotal()
      HitungKembalian()
    Else
      MsgBox("Kode Barcode tidak ditemukan.", vbOKOnly, "Barcode")
    End If
    txtBarcode.Focus()
  End Sub
  Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Enter Then
      btnAddRow_Click(sender, e)
    End If
  End Sub
  Private Sub btnCetakStruk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakStruk.ItemClick
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiStruk("\Struk.exe")) = True Then
    '  Dim myProcess As New Process()
    '  Process.Start(Logic.Umum.xLokasiStruk("\Struk.exe"), NamaDatabase.ToString & "~" & txtNoTransaksi.Text)
    'End If
    System.Diagnostics.Process.Start("http://" & salesSetting.POSServerStruk & "/struk.php?db=" & NamaDatabase & "&nomor=" & txtNoTransaksi.Text)
  End Sub


End Class