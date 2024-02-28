Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Friend Class UI_SanYuRencanaProduksiDialog
  Private instance As Persistent.SanYu_RencanaProduksi
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of SettingRegional)
  Private detailToDelete As New List(Of Persistent.SanYu_RencanaProduksiDetail)
  Private editAssign As Boolean = False
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.SanYu_RencanaProduksi.AutoSaveOnEndEdit = False
    Persistent.SanYu_RencanaProduksiDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
    txtNoPO.Properties.DataSource = Nothing
    layTipe.Visibility = LayoutVisibility.Never
    AllowSave = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.SanYu_RencanaProduksi(session)

      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.SanYu_RencanaProduksi)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Pelanggan
      txtRegional.EditValue = instance.Regional
      txtUraian.Text = instance.Uraian
      txtStatus.EditValue = instance.StatusTransaksi
      txtNoPO.EditValue = instance.OrderPenjualan

      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Rencana Produksi : Tambah Data"
    Else
      Me.Text = "Rencana Produksi : Edit Data " & instance.Kode
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

    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        splashManager.ShowWaitForm()
        splashManager.SetWaitFormCaption("Silahkan Tunggu")
        splashManager.SetWaitFormDescription("Simpan data rencana produksi ...")

        For i = detailToDelete.Count - 1 To 0 Step -1
          detailToDelete(i).Delete()
        Next

        '======= Simpan Main
        If Not txtKontak.EditValue Is Nothing Then
          instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
        Else
          instance.Pelanggan = Nothing
        End If
        instance.Kode = txtNoTransaksi.Text
        instance.Tanggal = txtTanggal.DateTime
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
        instance.Uraian = txtUraian.Text
        instance.OrderPenjualan = CType(txtNoPO.EditValue, Persistent.SanYu_OrderPenjualan)
        instance.OrderPenjualan.StatusProduksi = True

        instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)

        '======= Simpan instance
        If Tipe = InputType.Tambah Then
          Logic.Umum.SaveLog(session, Persistent.TipeLOG.Add, "Admin", "Rencana Produksi: Tambah " & instance.Kode)
        Else
          Logic.Umum.SaveLog(session, Persistent.TipeLOG.Edit, "Admin", "Rencana Produksi: Edit " & instance.Kode)
        End If

        session.CommitChanges()
        txtNoPO.Properties.DataSource = Nothing
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

    Dim frm As New RF_SanyuVoucherRencanaProduksi(Persistent.SumberDataJenis.OP)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zSanyuVoucherRencanaProduksi)
    message = String.Format(message, "Rencana Produksi")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, False)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -3 : txtTanggal.Focus()
      Case -4 : txtKontak.Focus()
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
    txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Pelanggan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtTipe.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.TipeTransaksi)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    colKodeBahanBakuRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.SanYu_Barang)(session, New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanBaku, BinaryOperatorType.Equal))
    colSatuanRepo.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eSanYuJenisPenjualan))
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
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
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.OP)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    'instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtNoPO.Enabled = False
    txtStatus.Enabled = False
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
      'txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(Session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))

      If Tipe = InputType.Tambah Then
        txtNoPO.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPenjualan)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}), New BinaryOperator("StatusProduksi", False, BinaryOperatorType.Equal)))
      Else
        txtNoPO.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPenjualan)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress, NuSoft001.Persistent.StatusTransaksiEnum.Approved}), New BinaryOperator("StatusProduksi", False, BinaryOperatorType.Equal)), New BinaryOperator("Id", instance.OrderPenjualan.Id, BinaryOperatorType.Equal)))
      End If

      xGHistory.DataSource = New XPCollection(Of Persistent.SanYu_RencanaProduksi)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))
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
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.SanYu_RencanaProduksiDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.SanYu_RencanaProduksiDetail)
      If e.Column Is colKodeBarang Then

      End If
      If e.Column Is colPanjang Then
        row.QtyBaku = (CDbl(e.Value) * row.Lebar * row.Tebal * row.Qty) / 1000000000
      End If
      If e.Column Is colLebar Then
        row.QtyBaku = (row.Panjang * CDbl(e.Value) * row.Tebal * row.Qty) / 1000000000
      End If
      If e.Column Is colTinggi Then
        row.QtyBaku = (row.Panjang * row.Lebar * CDbl(e.Value) * row.Qty) / 1000000000
      End If
      'If e.Column Is colBakuQty2 Then
      '  row.Qty = (row.Panjang * row.Lebar * row.Tebal * CDbl(e.Value)) / 1000000000
      'End If
    End If
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.SanYu_RencanaProduksiDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SanYu_RencanaProduksiDetail)
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
  Private Sub txtNoPO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoPO.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim xDataOrder As New XPCollection(Of Persistent.SanYu_OrderPenjualanDetail)(session, New BinaryOperator("Main", e.NewValue, BinaryOperatorType.Equal))
      Dim data As Persistent.SanYu_RencanaProduksiDetail

      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      For i = 0 To xDataOrder.Count - 1
        data = New Persistent.SanYu_RencanaProduksiDetail(session)
        'data.Main = instance
        data.OrderPenjualan = xDataOrder(i)
        data.Barang = xDataOrder(i).Barang
        data.Qty = xDataOrder(i).QtyPcs
        data.QtyBaku = 0
        instance.Detail.Add(data)
      Next
    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub colNamaBarangRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colNamaBarangRepo.ButtonClick
    'MsgBox("Tampilkan stock barang")
    Dim row As Persistent.SanYu_RencanaProduksiDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SanYu_RencanaProduksiDetail)
    Dim xStock As New XPCollection(Of Persistent.SanYu_StokDetail)(session, New BinaryOperator("Barang", row.BahanBaku, BinaryOperatorType.Equal))
    Dim xJumlahStock As Double = 0
    If xStock.Count > 0 Then
      xJumlahStock = xStock.Sum(Function(x) x.QtyIn - x.QtyOut)
    End If
    MsgBox("Jumlah stock barang untuk " & row.Barang.Kode & "[" & row.Barang.Nama & "] :" & xJumlahStock.ToString("n2"))
  End Sub
End Class