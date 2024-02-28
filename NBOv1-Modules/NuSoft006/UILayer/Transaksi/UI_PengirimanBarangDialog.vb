Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Friend Class UI_PengirimanBarangDialog
  Private instance As Persistent.PengirimanBarang
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.PengirimanBarangDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.PengirimanBarang.AutoSaveOnEndEdit = False
    Persistent.PengirimanBarangDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
    txtNoSO.Properties.DataSource = Nothing
    layTipe.Visibility = LayoutVisibility.Never
    lyUang.Visibility = LayoutVisibility.Never
    lyKurs.Visibility = LayoutVisibility.Never
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    LoadLayout()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SJTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SJTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SJTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SJTransaksiGrid.xml"))
    End If
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
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
      'txtNoTransaksi.EditValue = instance.Number.GetNewNumber.Kode
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.PengirimanBarang)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Pelanggan
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtAlamat.Text = instance.Alamat
      txtGudang.EditValue = instance.Gudang
      txtUang.EditValue = instance.MataUang
      txtKurs.EditValue = instance.Kurs
      txtNoDokumen.Text = instance.NoSJ
      txtNamaDriver.Text = instance.Supir
      txtNoKendaraan.Text = instance.NoKendaraan
      txtKaryawan.EditValue = instance.Karyawan
      txtUraian.Text = instance.Uraian
      txtNoSO.EditValue = CType(instance.NoOrder, Persistent.OrderPenjualan)
      txtStatus.EditValue = instance.StatusTransaksi
      txtTipe.EditValue = instance.TipeTransaksi
      txtAlamat.Text = instance.Alamat
      txtAlamatID.EditValue = CType(instance.AlamatID, NuSoft001.Persistent.KontakAlamat)

      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Pengiriman Barang [SJ]: Tambah Data"
    Else
      Me.Text = "Pengiriman Barang [SJ]: Edit Data " & instance.Kode
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
  Overrides Sub SimpanData()
    If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
      Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If
    If txtGudang.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan pilih gudang terlebih dahulu.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next
    For pX = 0 To instance.Detail.Count - 1
      instance.Detail(pX).Gudang = CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang)
      'For pJ = 0 To instance.Detail(pX).HPPReff.Count - 1
      '  instance.Detail(pX).HPPReff(pJ).Delete()
      'Next
      'For pJ = instance.Detail(pX).HPPReff.Count - 1 To 0 Step -1
      '  instance.Detail(pX).HPPReff(pJ).Delete()
      'Next
    Next

    Try
      '======= Simpan Main
      If Tipe = InputType.Tambah Then
        txtNoTransaksi.EditValue = instance.Number.GetNewNumber.Kode
      End If

      If Not txtKontak.EditValue Is Nothing Then
        instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Pelanggan = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      'instance.Kode = instance.Number.GetNewNumber.Kode
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.NoSJ = txtNoDokumen.Text
      instance.Supir = txtNamaDriver.Text
      instance.NoKendaraan = txtNoKendaraan.Text
      instance.Gudang = CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang)
      instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
      instance.NoOrder = CType(txtNoSO.EditValue, Persistent.OrderPenjualan)
      instance.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Kurs = CType(txtKurs.Text, Double)
      instance.Uraian = txtUraian.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.TipeTransaksi = CType(txtTipe.EditValue, NuSoft004.Persistent.TipeTransaksi)
      instance.Alamat = txtAlamat.Text
      instance.AlamatID = CType(txtAlamatID.EditValue, NuSoft001.Persistent.KontakAlamat)
      Dim data As Persistent.PengirimanBarangDetailHPP, pI As Integer, pJ As Integer
      For pI = 0 To instance.Detail.Count - 1
        Dim pQTY As Double = 0.0
        pQTY = instance.Detail(pI).Qty
        If instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
          Dim xDataHPP As New XPCollection(Of Persistent.vwHPP)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("f_item.Id", instance.Detail(pI).Barang.Id, BinaryOperatorType.Equal), New BinaryOperator("d_available", 0, BinaryOperatorType.Greater), New BinaryOperator("f_warehouse.Id", instance.Detail(pI).Gudang.Id, BinaryOperatorType.Equal)))
          For pJ = 0 To xDataHPP.Count - 1
            If xDataHPP(pJ).f_item.Jenis <> NuSoft004.Persistent.JenisBarang.Jasa Then
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
            End If
          Next
        End If
      Next
      If instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
        Dim pK As Integer
        For pK = 0 To instance.Detail.Count - 1
          If instance.Detail(pK).Barang.Jenis <> NuSoft004.Persistent.JenisBarang.Jasa Then
            If instance.Detail(pK).Qty > instance.Detail(pK).HPPReff.Sum(Function(m) m.Qty) Then
              Throw New Utils.Exception("HPP Barang [" & instance.Detail(pK).Barang.Kode & "] tidak tersedia.", -99, "", "")
              Exit Sub
            End If
          End If
        Next
        For pK = 0 To instance.Detail.Count - 1
          If instance.Detail(pK).Barang.Jenis <> NuSoft004.Persistent.JenisBarang.Jasa Then
            If instance.Detail(pK).Qty <> instance.Detail(pK).HPPReff.Sum(Function(m) m.Qty) Then
              Throw New Utils.Exception("Qty HPP Barang [" & instance.Detail(pK).Barang.Kode & "] tidak sama.", -99, "", "")
              Exit Sub
            End If
          End If
        Next
      End If
      instance.Save()

      'MsgBox("OKE deh sebelum buat jurnal")
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
      ''HPP (D)    looping dari setingan master coa
      Dim a = From z In instance.Detail Group z By z.Barang.CoaCost Into Group Select CoaCost, NilaiHPP = Group.Sum(Function(x) x.NilaiHPP)
      Dim i As Byte = 1
      For Each x In a
        'If x.NilaiHPP > 0 Then
        '  SimpanGL(x.CoaCost, i, x.NilaiHPP, 0)
        'End If
        SimpanGL(x.CoaCost, i, x.NilaiHPP, 0)
        i = i + 1
      Next
      'Persediaan (C)
      Dim b = From z In instance.Detail Group z By z.Barang.CoaStock Into Group Select CoaStock, NilaiHPP = Group.Sum(Function(x) x.NilaiHPP)
      For Each x In b
        'If x.NilaiHPP > 0 Then
        '  SimpanGL(x.CoaStock, i, 0, x.NilaiHPP)
        'End If
        SimpanGL(x.CoaStock, i, 0, x.NilaiHPP)
        i = i + 1
      Next

      If instance.Gl.Detail.Count > i Then
        For pI = i To instance.Gl.Detail.Count - 1 Step -1
          instance.Gl.Detail(i).Delete()
        Next
      End If
      'If instance.Gl.Saldo = 0 Then
      '  instance.Gl = Nothing
      '  instance.Gl.Delete()
      'End If

      'update status penawaran
      If Not instance.NoOrder Is Nothing Then
        Dim xDataSJ As New XPCollection(Of Persistent.PengirimanBarangDetail)(session, New BinaryOperator("OrderDetail.Main.Id", instance.NoOrder.Id, BinaryOperatorType.Equal))
        Dim xQtySO As Double, xQtySJ As Double
        xQtySO = instance.NoOrder.TotalQty
        xQtySJ = xDataSJ.Sum(Function(n) n.Qty) + instance.TotalQty
        If xQtySJ < xQtySO Then
          CType(txtNoSO.EditValue, Persistent.OrderPenjualan).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
        Else
          CType(txtNoSO.EditValue, Persistent.OrderPenjualan).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
        End If
      End If

      '======= Simpan instance
      session.CommitChanges()
      txtNoSO.Properties.DataSource = Nothing
    Catch ex As Utils.Exception
      RollbackDataHPPKetikaAdaErrorPadaSaatSimpan()
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("Duplicate entry") Then
        instance.Kode = instance.Number.GetNewNumber.Kode
        session.CommitChanges()
      Else
        RollbackDataHPPKetikaAdaErrorPadaSaatSimpan()
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.SJ, MainClass.reportName.VoucherSJ)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherSJ)
    message = String.Format(message, "Surat Jalan")

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
    txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtGudang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtTipe.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.TipeTransaksi)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
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
    txtUraian.EditValue = salesSetting.UraianDO
    txtKaryawan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Kontak)(Convert.ToInt64(salesSetting.KaryawanDefault))
    txtGudang.EditValue = session.GetObjectByKey(Of NuSoft004.Persistent.Gudang)(Convert.ToInt32(salesSetting.GudangDefault))
  End Sub
  Private Sub LoadLayout()
    If salesSetting.MultiSO = True Then
      lyNoOrder.Visibility = LayoutVisibility.Never
      btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    Else
      lyNoOrder.Visibility = LayoutVisibility.Always
      btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End If
    colDivisi.Visible = setting.MultiDivisi
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SJ)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl(xSave As Boolean)
    txtKontak.Enabled = False
    txtKontak.Enabled = False
    'txtNoTransaksi.Enabled = False
    txtNoTransaksi.Properties.ReadOnly = True
    txtRegional.Enabled = False
    txtGudang.Enabled = False
    txtNoDokumen.Enabled = False
    txtNoKendaraan.Enabled = False
    txtNamaDriver.Enabled = False
    txtNoSO.Enabled = False
    txtKaryawan.Enabled = False
    txtStatus.Enabled = False
    txtKontakPerson.Enabled = False
    txtAlamat.Enabled = False
    txtAlamatID.Enabled = False
    txtAlamat.Enabled = False
    txtAlamatID.Enabled = False
    'xGridView.OptionsBehavior.Editable = False
    xGridView.OptionsBehavior.ReadOnly = True

    btnRefresh.Enabled = False
    btnRefreshNomor.Enabled = False

    txtTanggal.Enabled = xSave
    txtTanggal.Enabled = xSave
    txtUraian.Enabled = xSave
    txtUraian.Enabled = xSave
    AllowSave = xSave
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
      txtAlamatID.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))

      If Tipe = InputType.Tambah Then
        txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      Else
        txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})), New BinaryOperator("Id", instance.NoOrder.Id, BinaryOperatorType.Equal)))
      End If

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
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.PengirimanBarangDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.PengirimanBarangDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SJTransaksiGrid.xml"))
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
  Private Sub txtNoPO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoSO.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim item As Persistent.OrderPenjualan = CType(e.NewValue, Persistent.OrderPenjualan)
      Dim data As Persistent.PengirimanBarangDetail
      Dim xDataSJ As New XPCollection(Of Persistent.PengirimanBarangDetail)(session, New BinaryOperator("Main.NoOrder", e.NewValue, BinaryOperatorType.Equal))

      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      txtKontakPerson.EditValue = item.KontakPerson
      txtUang.EditValue = item.Uang
      txtTipe.EditValue = item.TipeTransaksi
      txtKurs.Text = 1 'ambilkan kurs sesuai tanggal
      txtAlamatID.EditValue = item.KontakAlamat
      If Not item.KontakAlamat Is Nothing Then
        txtAlamat.EditValue = item.KontakAlamat.Alamat
      End If
      Dim pI As Integer
      For pI = 0 To item.Detail.Count - 1
        Dim xQTY As Double
        xQTY = item.Detail(pI).Qty - xDataSJ.Where(Function(m) m.OrderDetail Is item.Detail(pI)).Sum(Function(n) n.Qty)

        If xQTY > 0 Then
          data = New Persistent.PengirimanBarangDetail(session)
          data.OrderDetail = item.Detail(pI)
          data.Barang = item.Detail(pI).Barang
          data.Qty = xQTY ' item.Detail(i).Qty - xDataSJ.Where(Function(m) m.OrderDetail Is data.OrderDetail).Sum(Function(n) n.Qty) 'dikurangi yang sudah dikirim
          data.Satuan = item.Detail(pI).Satuan
          data.Harga = item.Detail(pI).Harga
          data.Catatan = item.Detail(pI).Catatan
          data.Divisi = item.Detail(pI).Divisi
          instance.Detail.Add(data)
        End If
      Next
    End If
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
  Private Sub txtAlamatID_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAlamatID.EditValueChanging
    If Not e.NewValue Is Nothing Then
      txtAlamat.Text = CType(e.NewValue, NuSoft001.Persistent.KontakAlamat).Alamat
    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub

  Private Sub colCekStokRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colCekStokRepo.ButtonClick
    Dim x = CType(xGridView.GetFocusedRow, Persistent.PengirimanBarangDetail)
    If x Is Nothing OrElse x.Barang Is Nothing Then Exit Sub
    If txtGudang.EditValue Is Nothing Then
      XtraMessageBox.Show("Masukkan gudang terlebih dahulu", "Cek Stok", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    Dim msg = "Kode Barang : {0}" & vbCrLf & "Nama Barang : {1}" & vbCrLf & "Gudang : {2}" & vbCrLf & "Stok : {3}"
    Dim gudang = CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang)
    Dim stok = New XPQuery(Of Persistent.StockDetail)(session).Where(Function(w) w.Barang Is x.Barang And w.Gudang Is gudang).Sum(Function(s) s.QtyIn - s.QtyOut)

    XtraMessageBox.Show(String.Format(msg, x.Barang.Kode, x.Barang.Nama, gudang.Nama, stok), "Cek Stok", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub RollbackDataHPPKetikaAdaErrorPadaSaatSimpan()
    For pK = 0 To instance.Detail.Count - 1
      Dim det = instance.Detail(pK)
      For j = det.HPPReff.Count - 1 To 0 Step -1
        Dim ref = det.HPPReff(j)
        det.HPPReff.Remove(ref)
        ref.Delete()
      Next
    Next
  End Sub
End Class