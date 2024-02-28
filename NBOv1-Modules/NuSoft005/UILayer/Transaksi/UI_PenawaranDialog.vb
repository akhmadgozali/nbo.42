Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_PenawaranDialog
  Private instance As Persistent.Penawaran
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.PenawaranDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.Penawaran.AutoSaveOnEndEdit = False
    Persistent.PenawaranDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingpurchase = New Logic.PurchaseSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RQTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RQTransaksi.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Penawaran(session)
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.Penawaran)(Convert.ToInt64(IdToEdit))
      txtTipe.EditValue = instance.TipeTransaksi
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
      txtUraian.Text = instance.Catatan
      txtStatus.EditValue = instance.StatusTransaksi
      txtNoPermintaan.EditValue = instance.NoPermintaan

      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Permintaan Penawaran [RQ] : Tambah"
    Else
      Me.Text = "Permintaan Penawaran [RQ] : Edit " & instance.Kode
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
      If Not txtKontak.EditValue Is Nothing Then
        instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Vendor = Nothing
      End If
      If Tipe = InputType.Tambah Then
        instance.Kode = Nothing
      Else
        instance.Kode = txtNoTransaksi.Text
      End If
      instance.TipeTransaksi = CType(txtTipe.EditValue, NuSoft004.Persistent.TipeTransaksi)
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
      instance.Catatan = txtUraian.Text
      instance.NoPermintaan = CType(txtNoPermintaan.EditValue, Persistent.PermintaanStock)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
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
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.RQ)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherPermintaanPenawaran)
    message = String.Format(message, "penawaran pembelian")
 
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
    txtFOB.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipeFOB))
    txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePajak))
    txtVia.Properties.DataSource = New XPCollection(Of Persistent.Via)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session)
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    txtNoPermintaan.Properties.DataSource = Logic.Permintaan.GetPermintaan(session, New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    txtTipe.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.TipeTransaksi)(session)
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatString
    colHarga.SummaryItem.DisplayFormat = setting.NumericFormatString
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
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtPajak.EditValue = Persistent.eTipePajak.TanpaPajak
    txtFOB.EditValue = Persistent.eTipeFOB.Origin
    txtTipe.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipe)
    instance.TipePajak = Persistent.eTipePajak.TanpaPajak
    txtUraian.EditValue = settingpurchase.UraianRQ
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    txtVia.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtVia)
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.RQ)
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
    txtNoPermintaan.Enabled = False
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

      xGHistory.DataSource = New XPCollection(Of Persistent.Penawaran)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))
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
      Dim row As Persistent.PenawaranDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PenawaranDetail)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
          row.Satuan = xbarang.Satuan
          row.Harga = xbarang.LastPurchase
          row.PPN = xbarang.PajakIN
          row.PPH = xbarang.PajakOUT
          row.PPNp = xbarang.PajakIN.NilaiPajak
          row.PPHp = xbarang.PajakOUT.NilaiPajak
        End If
      End If
      HitungTotal()
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.PenawaranDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PenawaranDetail)
    row.Barang = Nothing
    row.Qty = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.PenawaranDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.PenawaranDetail)
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
  Private Sub txtNoPermintaan_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoPermintaan.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim item As Persistent.PermintaanStock = CType(e.NewValue, Persistent.PermintaanStock)
      Dim data As Persistent.PenawaranDetail
      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next
      txtPajak.EditValue = Persistent.eTipePajak.HargaBelumTermasuk
      instance.TipePajak = Persistent.eTipePajak.HargaBelumTermasuk

      For i = 0 To item.Detail.Count - 1
        data = New Persistent.PenawaranDetail(session)
        data.Barang = item.Detail(i).Barang
        data.Qty = item.Detail(i).Qty
        data.Satuan = item.Detail(i).Satuan
        data.Harga = item.Detail(i).Barang.LastPurchase
        data.PPN = item.Detail(i).Barang.PajakIN
        data.PPH = item.Detail(i).Barang.PajakOUT
        data.PPNp = item.Detail(i).Barang.PajakIN.NilaiPajak
        data.PPHp = item.Detail(i).Barang.PajakOUT.NilaiPajak
        data.Catatan = item.Detail(i).Catatan
        data.PermintaaanDetail = item.Detail(i)
        instance.Detail.Add(data)
      Next
      HitungTotal()
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
End Class