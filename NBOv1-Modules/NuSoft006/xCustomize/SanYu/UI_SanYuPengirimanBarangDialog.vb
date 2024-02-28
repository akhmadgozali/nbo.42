Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Friend Class UI_SanYuPengirimanBarangDialog
  Private instance As Persistent.SanYu_PengirimanBarang
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.SanYu_PengirimanBarangDetail)
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
    lyUang.Visibility = LayoutVisibility.Never
    lyKurs.Visibility = LayoutVisibility.Never
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(Session)
    salesSetting = New Logic.SalesSetting(Session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(Session)
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
    Session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.SanYu_PengirimanBarang(session)
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
      instance = session.GetObjectByKey(Of Persistent.SanYu_PengirimanBarang)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Pelanggan
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtGudang.EditValue = instance.Gudang
      txtKaryawan.EditValue = instance.Karyawan
      'txtUraian.Text = instance.Uraian
      txtNoSO.EditValue = CType(instance.OrderPenjualan, Persistent.SanYu_OrderPenjualan)
      txtStatus.EditValue = instance.StatusTransaksi
      'txtAlamat.Text = instance.Alamat
      'txtAlamatID.EditValue = CType(instance.AlamatID, NuSoft001.Persistent.KontakAlamat)

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
    If txtGudang.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan pilih gudang terlebih dahulu.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If


    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
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
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gudang = CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang)
      instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
      instance.OrderPenjualan = CType(txtNoSO.EditValue, Persistent.SanYu_OrderPenjualan)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      'hpp
      For pI = 0 To instance.Detail.Count - 1
        instance.Detail(pI).TotalHPP = 1000000
      Next

      'GLnya
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
      Dim a = From z In instance.Detail Group z By z.Barang.CoaCost Into Group Select CoaCost, TotalHPP = Group.Sum(Function(x) x.TotalHPP)
      Dim i As Byte = 1
      For Each x In a
        SimpanGL(x.CoaCost, i, x.TotalHPP, 0)
        i = i + 1
      Next
      'Persediaan (C)
      Dim b = From z In instance.Detail Group z By z.Barang.CoaStock Into Group Select CoaStock, TotalHPP = Group.Sum(Function(x) x.TotalHPP)
      For Each x In b
        SimpanGL(x.CoaStock, i, 0, x.TotalHPP)
        i = i + 1
      Next


      instance.Save()

      'update status penawaran
      'If Not instance.NoOrder Is Nothing Then
      '  Dim xDataSJ As New XPCollection(Of Persistent.PengirimanBarangDetail)(Session, New BinaryOperator("OrderDetail.Main.Id", instance.NoOrder.Id, BinaryOperatorType.Equal))
      '  Dim xQtySO As Double, xQtySJ As Double
      '  xQtySO = instance.NoOrder.TotalQty
      '  xQtySJ = xDataSJ.Sum(Function(n) n.Qty) + instance.TotalQty
      '  If xQtySJ < xQtySO Then
      '    CType(txtNoSO.EditValue, Persistent.OrderPenjualan).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
      '  Else
      '    CType(txtNoSO.EditValue, Persistent.OrderPenjualan).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
      '  End If
      'End If

      Logic.Umum.SaveLog(session, IIf(Tipe = InputType.Tambah, Persistent.TipeLOG.Add, Persistent.TipeLOG.Edit), "Admin", "Pengiriman Penjualan : " & IIf(Tipe = InputType.Tambah, "Tambah", "Edit") & " " & instance.Kode)

      '======= Simpan instance
      session.CommitChanges()
      txtNoSO.Properties.DataSource = Nothing
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("Duplicate entry") Then
        instance.Kode = instance.Number.GetNewNumber.Kode
        Session.CommitChanges()
      Else
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
    Dim frm As New RF_SanyuVoucher(Persistent.SumberDataJenis.SJ, MainClass.reportName.zSanyuVoucherPackingList)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zSanyuVoucherPackingList)
    message = String.Format(message, "Surat Jalan")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
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
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(Session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(Session)
    End If
    txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(Session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(Session, NamaDatabase)
    txtGudang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(Session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(Session)
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
    txtUraian.EditValue = salesSetting.UraianDO
    txtKaryawan.EditValue = Session.GetObjectByKey(Of NuSoft001.Persistent.Kontak)(Convert.ToInt64(salesSetting.KaryawanDefault))
    txtGudang.EditValue = Session.GetObjectByKey(Of NuSoft004.Persistent.Gudang)(Convert.ToInt32(salesSetting.GudangDefault))
  End Sub
  Private Sub LoadLayout()
    If salesSetting.MultiSO = True Then
      lyNoOrder.Visibility = LayoutVisibility.Never
      btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    Else
      lyNoOrder.Visibility = LayoutVisibility.Always
      btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End If
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SJ)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}

  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
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
      txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(Session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
      txtAlamatID.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(Session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))

      If Tipe = InputType.Tambah Then
        txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPenjualan)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      Else
        txtNoSO.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPenjualan)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})), New BinaryOperator("Id", instance.OrderPenjualan.Id, BinaryOperatorType.Equal)))
      End If

      Dim xpTransaksi As New XPCollection(Of Persistent.SanYu_PengirimanBarang)(session, New BinaryOperator("Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
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
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.SanYu_PengirimanBarangDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SanYu_PengirimanBarangDetail)
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
      Dim item As Persistent.SanYu_OrderPenjualan = CType(e.NewValue, Persistent.SanYu_OrderPenjualan)
      Dim data As Persistent.SanYu_PengirimanBarangDetail
      Dim xDataSJ As New XPCollection(Of Persistent.SanYu_PengirimanBarangDetail)(session, New BinaryOperator("Main.OrderPenjualan", e.NewValue, BinaryOperatorType.Equal))

      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      txtKontakPerson.EditValue = item.KontakPerson
      txtUang.EditValue = item.Uang
      Dim pI As Integer
      For pI = 0 To item.Detail.Count - 1
        Dim xQTY As Double
        'xQTY = item.Detail(pI).Qty - xDataSJ.Where(Function(m) m.OrderPenjualan Is item.Detail(pI)).Sum(Function(n) n.QtyOut)
        xQTY = item.Detail(pI).Qty

        If xQTY > 0 Then
          data = New Persistent.SanYu_PengirimanBarangDetail(session)
          data.OrderPenjualan = item.Detail(pI)
          data.Barang = item.Detail(pI).Barang
          data.QtyOut = xQTY ' item.Detail(i).Qty - xDataSJ.Where(Function(m) m.OrderDetail Is data.OrderDetail).Sum(Function(n) n.Qty) 'dikurangi yang sudah dikirim
          data.Satuan = item.Detail(pI).Satuan
          data.Harga = item.Detail(pI).Harga
          data.Catatan = item.Detail(pI).Catatan
          instance.Detail.Add(data)
        End If
      Next
    End If
  End Sub
  Private Sub txtAlamatID_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAlamatID.EditValueChanging
    'If Not e.NewValue Is Nothing Then
    '  txtAlamat.Text = CType(e.NewValue, NuSoft001.Persistent.KontakAlamat).Alamat
    'End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub colCommandRepo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles colCommandRepo.ButtonClick
    Dim row = CType(xGridView.GetFocusedRow, Persistent.SanYu_PengirimanBarangDetail)
    If e.Button.Kind = ButtonPredefines.Ellipsis Then
      Dim frm As New UI_SanyuPengirimanBarangDialogPacking
      frm.NamaDatabase = Me.NamaDatabase
      frm.MenuId = Me.MenuId
      frm.session = session
      frm.LoadData(row)
      frm.ShowDialog()

      'MsgBox("Tampilkan detail packing list nya")
    End If
  End Sub
  Private Sub colProduksiRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colProduksiRepo.ButtonClick
    Dim row = CType(xGridView.GetFocusedRow, Persistent.SanYu_PengirimanBarangDetail)
    Dim frm As New UI_SanYuPengirimanBarangDialogFindProduksi
    frm.NamaDatabase = Me.NamaDatabase
    frm.MenuId = Me.MenuId
    frm.session = session
    frm.LoadData(row)
    frm.ShowDialog()
    xGrid.RefreshDataSource()
  End Sub
End Class