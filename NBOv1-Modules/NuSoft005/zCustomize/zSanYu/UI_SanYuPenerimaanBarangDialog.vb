Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class UI_SanYuPenerimaanBarangDialog
  Private instance As Persistent.SanYu_PenerimaanBarang
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of SettingRegional)
  Private detailToDelete As New List(Of Persistent.SanYu_PenerimaanBarangDetail)
  Private editAssign As Boolean = False
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection
  Private inv As List(Of Persistent.Fusoh_PenerimaanInvoice)

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.PenerimaanBarang.AutoSaveOnEndEdit = False
    Persistent.PenerimaanBarangDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
    layTipe.Visibility = LayoutVisibility.Never
    AllowSave = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(Session)
    settingpurchase = New Logic.PurchaseSetting(Session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(Session)
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("GRTransaksi.xml")) = True Then
    '  lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("GRTransaksi.xml"))
    'End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    Session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.SanYu_PenerimaanBarang(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.SanYu_PenerimaanBarang)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Vendor
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtGudang.EditValue = instance.Gudang
      txtUang.EditValue = instance.MataUang
      txtKurs.EditValue = instance.Kurs
      txtKaryawan.EditValue = instance.Karyawan
      txtUraian.Text = instance.Uraian
      txtDomestik.Checked = instance.FromDomestik
      txtStatus.EditValue = instance.StatusTransaksi
      txtPIB.EditValue = instance.PIB

      If txtDomestik.Checked = True Then
        lytPIB.Visibility = LayoutVisibility.Never
        btnAmbilData.Enabled = True
      Else
        lytPIB.Visibility = LayoutVisibility.Always
        btnAmbilData.Enabled = False
      End If

      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Penerimaan Barang : Tambah Data"
    Else
      Me.Text = "Penerimaan Barang : Edit Data " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl()
      End If
      If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, instance.Tanggal) Then
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


    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        splashManager.ShowWaitForm()
        splashManager.SetWaitFormCaption("Silahkan Tunggu")
        splashManager.SetWaitFormDescription("Simpan data penerimaan barang ...")


        '======= Simpan Main
        If Not txtKontak.EditValue Is Nothing Then
          instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
        Else
          instance.Vendor = Nothing
        End If
        instance.Kode = txtNoTransaksi.EditValue
        instance.Tanggal = txtTanggal.DateTime
        instance.KontakPerson = txtKontakPerson.EditValue
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
        instance.Gudang = CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang)
        instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
        instance.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
        instance.Kurs = CType(txtKurs.Text, Double)
        instance.Uraian = txtUraian.Text
        instance.FromDomestik = txtDomestik.Checked
        instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending 'CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
        If txtDomestik.Checked = False Then
          instance.PIB = CType(txtPIB.EditValue, Persistent.SanYu_PIB)
        Else
          instance.PIB = Nothing
        End If
        'buatkan jurnalnya
        instance.Gl.Sumber = instance.Sumber
        instance.Gl.Kode = instance.Kode
        instance.Gl.Tanggal = txtTanggal.EditValue
        instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
        instance.Gl.Kode = instance.Kode
        instance.Gl.ModuleId = NPO.Modules.ModuleId.Purchase
        instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
        instance.Gl.Kurs = txtKurs.EditValue
        instance.Gl.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
        instance.Gl.KontakNama = txtKontak.Text
        instance.Gl.Uraian = txtUraian.Text
        Dim i As Byte = 1
        'Persediaan (D)    looping dari setingan master coa
        Dim a = From z In instance.Detail Where z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Persediaan Or z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Assembly Group z By z.Barang.CoaStock Into Group Select CoaStock, SubTotal = Group.Sum(Function(x) x.SubTotal * x.Main.Kurs)
        For Each x In a
          SimpanGL(x.CoaStock, i, x.SubTotal, 0)
          i = i + 1
        Next
        'langsung jadikan biaya ketika jasa
        Dim b = From z In instance.Detail Where z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Jasa Group z By z.Barang.CoaCost Into Group Select CoaCost, SubTotal = Group.Sum(Function(x) x.SubTotal * x.Main.Kurs)
        For Each x In b
          SimpanGL(x.CoaCost, i, x.SubTotal, 0)
          i = i + 1
        Next
        'Hutang Sementara (C)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaHutangSementara)), i + 1, 0, instance.Detail.Sum(Function(m) m.SubTotal * m.Main.Kurs))
        instance.Save()
        '======= Simpan instance
        Logic.Umum.SaveLog(session, IIf(Tipe = InputType.Tambah, Persistent.TipeLOG.Add, Persistent.TipeLOG.Edit), "Admin", "Penerimaan barang : " & IIf(Tipe = InputType.Tambah, "Tambah", "Edit") & " " & instance.Kode)
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
      Finally
        splashManager.CloseWaitForm()
      End Try
    End Using

    Dim frm As New RF_SanYuVoucher(Persistent.SumberDataJenis.GR)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zSanyuVoucherGRN)
    message = String.Format(message, "Penerimaan Barang [GRN]")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingpurchase.PreviewReport)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -3 : txtTanggal.Focus()
      Case -4 : txtKontak.Focus()
      Case -5 : txtGudang.Focus()
      Case -6 : txtKaryawan.Focus()
      Case -7 : txtStatus.Focus()
      Case -99 : xGrid.Focus()
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
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(Session, New BinaryOperator("TipeKontak.Id", settingpurchase.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(Session)
    End If
    txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(Session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(Session, NamaDatabase)
    txtGudang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(Session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(Session)
    txtTipe.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.TipeTransaksi)(Session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    txtPIB.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PIB)(session)
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = "n4"
    colQty.SummaryItem.DisplayFormat = "n4"
    colTonase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTonase.DisplayFormat.FormatString = "n4"
    colTonase.SummaryItem.DisplayFormat = "n4"
    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
  End Sub
  Private Sub LoadDefault()
    If xpSettingRegional Is Nothing Then
      xpSettingRegional = New XPCollection(Of NuSoft001.Persistent.SettingRegional)(Session)
    End If
    defaultRegional = UserInfo.GetDefaultRegional(Session)
    txtTanggal.EditValue = Now
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    End If
    instance.Tanggal = txtTanggal.DateTime
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtUraian.EditValue = settingpurchase.UraianGR
    txtDomestik.Checked = False
    lytPIB.Visibility = LayoutVisibility.Always
    btnAmbilData.Enabled = False
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.GR)
    instance.Number = New Logic.NumberClass(Session) With {.FormatNomor = setting.FormatNomor}
    instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtGudang.Enabled = False
    txtKaryawan.Enabled = False
    txtStatus.Enabled = False
    txtKontakPerson.Enabled = False
    txtUraian.Enabled = False
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
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
      txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(Session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))

      'If Tipe = InputType.Tambah Then
      '  txtNoPO.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPembelian)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      'Else
      '  txtNoPO.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPembelian)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress, NuSoft001.Persistent.StatusTransaksiEnum.Approved})), New BinaryOperator("Id", instance.OrderPembelian.Id, BinaryOperatorType.Equal)))
      'End If

      xGHistory.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanBarang)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))
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
      txtKurs.Text = NuSoft001.Logic.Kurs.getKursBank(Session, instance.MataUang, txtTanggal.DateTime)
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.SanYu_PenerimaanBarangDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SanYu_PenerimaanBarangDetail)
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
  Private Sub txtNoPO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim xDataPenerimaan As New XPCollection(Of Persistent.SanYu_PenerimaanBarangDetail)(session, New BinaryOperator("Main.OrderPembelian", e.NewValue, BinaryOperatorType.Equal))
      Dim item As Persistent.SanYu_OrderPembelian = CType(e.NewValue, Persistent.SanYu_OrderPembelian)
      Dim data As Persistent.SanYu_PenerimaanBarangDetail
      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      txtKontakPerson.EditValue = item.KontakPerson
      txtGudang.EditValue = item.Gudang
      txtUang.EditValue = item.Uang
      instance.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      txtKurs.Text = NuSoft001.Logic.Kurs.getKursBank(session, instance.MataUang, txtTanggal.DateTime)
      For i = 0 To item.Detail.Count - 1
        data = New Persistent.SanYu_PenerimaanBarangDetail(session)
        data.NoOrder = item.Detail(i)
        data.Barang = item.Detail(i).Barang
        data.Qty = item.Detail(i).Qty - xDataPenerimaan.Where(Function(m) m.NoOrder Is data.NoOrder).Sum(Function(n) n.Qty)
        data.Satuan = item.Detail(i).Satuan
        data.Harga = item.Detail(i).DPP / item.Detail(i).Qty
        data.Catatan = item.Detail(i).Catatan
        instance.Detail.Add(data)
      Next
    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub btnAmbilData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilData.ItemClick
    If txtKontak.EditValue Is Nothing Then
      MsgBox("Silahkan pilih vendor terlebih dahulu.", vbInformation, "Informasi")
      Exit Sub
    End If

    If txtDomestik.Checked = True Then
      Dim frm As New UI_SanYuPenerimaanBarangLokal
      frm.session = session
      frm.instance = instance
      frm.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)

      If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        For i = 0 To frm.POResult.Count - 1
          Dim xdt = frm.POResult(i)
          LoadPO(xdt)
        Next
      End If
    Else
      'Dim frm As New UI_SanYuPenerimaanBarangImpor
      'frm.session = session
      'frm.instance = instance
      'frm.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)

      'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
      '  For i = 0 To frm.IVResult.Count - 1
      '    Dim xdt = frm.IVResult(i)
      '    LoadIV(xdt)
      '    Exit For
      '  Next
      'End If
    End If
  End Sub
  'Private Sub LoadIV(xDataIV As Persistent.SanYu_PenerimaanInvoice)
  '  Dim data As Persistent.SanYu_PenerimaanBarangDetail
  '  For i = 0 To xDataIV.Detail.Count - 1
  '    data = New Persistent.SanYu_PenerimaanBarangDetail(session)
  '    data.NoOrder = xDataIV.Detail(i).OrderPembelian
  '    data.NoInvoice = xDataIV.Detail(i)
  '    data.Barang = xDataIV.Detail(i).Barang
  '    data.Qty = xDataIV.Detail(i).Qty
  '    data.Satuan = xDataIV.Detail(i).Satuan
  '    data.Harga = xDataIV.Detail(i).Harga
  '    data.Catatan = xDataIV.Detail(i).Catatan
  '    data.Tonase = xDataIV.Detail(i).OrderPembelian.Tonase
  '    instance.Detail.Add(data)
  '  Next
  'End Sub
  Private Sub LoadPO(xDataPO As Persistent.SanYu_OrderPembelian)
    Dim data As Persistent.SanYu_PenerimaanBarangDetail
    instance.OrderPembelian = xDataPO
    txtUang.EditValue = xDataPO.Uang
    For i = 0 To xDataPO.Detail.Count - 1
      data = New Persistent.SanYu_PenerimaanBarangDetail(session)
      data.NoOrder = xDataPO.Detail(i)
      data.Barang = xDataPO.Detail(i).Barang
      data.Qty = xDataPO.Detail(i).Qty
      data.Satuan = xDataPO.Detail(i).Satuan
      data.Harga = xDataPO.Detail(i).Harga
      data.Catatan = xDataPO.Detail(i).Catatan
      data.Tonase = xDataPO.Detail(i).Tonase
      instance.Detail.Add(data)
    Next
  End Sub
  Private Sub txtNoPIB_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPIB.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim item As Persistent.SanYu_PIB = CType(e.NewValue, Persistent.SanYu_PIB)
      Dim xDataPenerimaan As New XPCollection(Of Persistent.SanYu_PenerimaanBarangDetail)(session, New BinaryOperator("Main.PIB", e.NewValue, BinaryOperatorType.Equal))
      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      Dim data As Persistent.SanYu_PenerimaanBarangDetail

      txtUang.EditValue = item.InvoicePembelian.Uang
      txtKurs.EditValue = item.InvoicePembelian.Kurs

      For i = 0 To item.Detail.Count - 1
        data = New Persistent.SanYu_PenerimaanBarangDetail(session)
        data.NoPIB = item.Detail(i)
        data.Barang = item.Detail(i).Barang
        data.Qty = item.Detail(i).Qty - xDataPenerimaan.Where(Function(m) m.NoPIB Is data.NoPIB).Sum(Function(n) n.Qty)
        data.Satuan = item.Detail(i).Satuan
        data.Harga = item.Detail(i).Harga / item.Detail(i).Qty
        data.Catatan = item.Detail(i).Catatan
        data.Tonase = item.Detail(i).Tonase
        instance.Detail.Add(data)
      Next
    End If
  End Sub
  Private Sub txtDomestik_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtDomestik.EditValueChanging
    If e.NewValue = True Then
      lytPIB.Visibility = LayoutVisibility.Never
      btnAmbilData.Enabled = True
    Else
      lytPIB.Visibility = LayoutVisibility.Always
      btnAmbilData.Enabled = False
    End If
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double)
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
      item.Kurs = 1
      item.DebitValas = 0
      item.KreditValas = 0
      instance.Gl.Detail.Add(item)
    End If
  End Sub
End Class