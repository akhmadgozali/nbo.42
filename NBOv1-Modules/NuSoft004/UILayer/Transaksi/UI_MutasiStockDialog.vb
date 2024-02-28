﻿Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_MutasiStockDialog
  Private instance As Persistent.StockMain
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.StockDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settinginventory As Logic.InventorySetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.StockMain.AutoSaveOnEndEdit = False
    Persistent.StockDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settinginventory = New Logic.InventorySetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("STTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("STTransaksi.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.StockMain(session)
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.StockMain)(Convert.ToInt64(IdToEdit))
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.KaryawanKirim
      txtNoTransaksi.Text = instance.Kode
      'txtNoPermintaan.EditValue = instance.PermintaanBarang
      txtUraian.Text = instance.Catatan
      txtKaryawanTerima.EditValue = instance.KaryawanTerima
      txtRegional.EditValue = instance.Regional
      txtGudang.EditValue = instance.Gudang
      txtStatus.EditValue = instance.StatusTransaksi

      xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    instance.Detail.CriteriaString = "QtyOut>0"
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Mutasi Stock : Tambah"
    Else
      Me.Text = "Mutasi Stock : Edit " & instance.Kode
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
    If txtGudang.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan input gudang sumber.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If
    For pI = 0 To instance.Detail.Count - 1
      If CType(txtGudang.EditValue, Persistent.Gudang).Id = instance.Detail(pI).Gudang2.Id Then
        Throw New Utils.Exception("Gudang tujuan tidak boleh sama dengan gudang sumber #." & pI, 0, "", "Simpan Transaksi")
        Exit Sub
      End If
    Next
    If CType(txtKaryawanTerima.EditValue, NuSoft001.Persistent.Kontak).Id = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).Id Then
      Throw New Utils.Exception("Karyawan pengirim tidak boleh sama dengan karyawan penerima", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      '======= Simpan Main
      instance.KaryawanKirim = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.KaryawanTerima = CType(txtKaryawanTerima.EditValue, NuSoft001.Persistent.Kontak)
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.PermintaanBarang = CType(txtNoPermintaan.EditValue, Persistent.PermintaanStock)
      instance.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Catatan = txtUraian.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.MataUang = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
      instance.Kurs = 1
      'buatkan hppnya barang keluar
      Dim data As Persistent.StockDetailHPPReff
      For pI = 0 To instance.Detail.Count - 1
        instance.Detail(pI).Gudang = instance.Gudang
        Dim pQTY As Double
        pQTY = instance.Detail(pI).QtyOut
        Dim xDataHPP As New XPCollection(Of Persistent.vwHPP)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("f_item.Id", instance.Detail(pI).Barang.Id, BinaryOperatorType.Equal), New BinaryOperator("d_available", 0, BinaryOperatorType.Greater), New BinaryOperator("f_warehouse.Id", instance.Detail(pI).Gudang.Id, BinaryOperatorType.Equal)))
        For pJ = 0 To xDataHPP.Count - 1
          data = New Persistent.StockDetailHPPReff(session)
          data.DetailIN = xDataHPP(pJ).Id
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
      Dim xDataDetail As Persistent.StockDetail
      'buatkan barang masuknya
      For pI = 0 To instance.Detail.Count - 1
				xDataDetail = New Persistent.StockDetail(session)
				xDataDetail.Gudang = instance.Detail(pI).Gudang2
				xDataDetail.Barang = instance.Detail(pI).Barang
        xDataDetail.QtyIn = instance.Detail(pI).QtyOut
        xDataDetail.Satuan = instance.Detail(pI).Satuan
        xDataDetail.Catatan = instance.Detail(pI).Catatan
        xDataDetail.HargaIn = instance.Detail(pI).NilaiHPP / instance.Detail(pI).QtyOut
				instance.Detail(pI).HargaIn = instance.Detail(pI).NilaiHPP / instance.Detail(pI).QtyOut
				instance.Detail.Add(xDataDetail)
      Next

      instance.Save()
      If Not txtNoPermintaan.EditValue Is Nothing Then
        CType(txtNoPermintaan.EditValue, Persistent.PermintaanStock).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
      End If

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
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.ST)
    frm.txtNoBukti1.Text = instance.Kode
    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherMutasiStock)
    message = String.Format(message, "Mutasi Barang")

  Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settinginventory.PreviewSave)
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
    txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub BindingDataSource()
    txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtKaryawanTerima.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)
    colKodeBarangRepo.DataSource = New XPCollection(Of Persistent.Barang)(session, New BinaryOperator("Jenis", Persistent.JenisBarang.Jasa, BinaryOperatorType.NotEqual))
    colSatuanRepo.DataSource = New XPCollection(Of Persistent.Satuan)(session)
    colGudangRepo.DataSource = New XPCollection(Of Persistent.Gudang)(session)
    txtNoPermintaan.Properties.DataSource = Logic.Permintaan.GetPermintaan(session, New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
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
    txtUraian.Text = settinginventory.UraianMutasi
    txtStatus.Properties.ReadOnly = True
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.ST)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Enabled = False
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtRegional.Enabled = False
    txtGudang.Enabled = False
    txtDivisi.Enabled = False
    txtKaryawanTerima.Enabled = False
    txtUraian.Enabled = False
    xGridView.OptionsBehavior.Editable = False
    txtStatus.Properties.ReadOnly = True
    txtNoPermintaan.Properties.ReadOnly = True
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

      'Dim xpTransaksi As New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("Id", CType(e.NewValue, NuSoft001.Persistent.Kontak).Id, BinaryOperatorType.Equal))
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
      If e.Column Is colKodeBarang Then
        Dim row As Persistent.StockDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.StockDetail)
        If Not row Is Nothing Then
          Dim xbarang As Persistent.Barang = CType(e.Value, Persistent.Barang)
          row.Satuan = xbarang.Satuan
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.StockDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.StockDetail)
    row.Barang = Nothing
    row.QtyOut = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.StockDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.StockDetail)
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
    If Not e.NewValue Is Nothing Then
      Dim item As Persistent.PermintaanStock = CType(e.NewValue, Persistent.PermintaanStock)
      Dim data As Persistent.StockDetail
      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next

      For i = 0 To item.Detail.Count - 1
        data = New Persistent.StockDetail(session)
        data.Barang = item.Detail(i).Barang
        data.QtyOut = item.Detail(i).Qty
        data.Satuan = item.Detail(i).Satuan
        data.Catatan = item.Detail(i).Catatan
        data.PermintaanBarang = item.Detail(i)
        instance.Detail.Add(data)
      Next
    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
End Class
