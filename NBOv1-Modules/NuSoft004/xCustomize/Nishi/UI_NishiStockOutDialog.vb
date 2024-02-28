Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Friend Class UI_NishiStockOutDialog
  Private instance As Persistent.NishiStockMain
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.NishiStockDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private xDetailTemp As List(Of Persistent.NishiStockDetailSJ) 'As Persistent.NishiStockDetailSJ
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.NishiStockMain.AutoSaveOnEndEdit = False
    Persistent.NishiStockDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PSTransaksi.xml")) = True Then
    '  lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PSTransaksi.xml"))
    'End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    'xDetailTemp = New Persistent.NishiStockDetailSJ(session)
    If Tipe = InputType.Tambah Then
      instance = New Persistent.NishiStockMain(session)
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.NishiStockMain)(Convert.ToInt64(IdToEdit))
      txtUraian.Text = instance.Catatan
      txtKontak.EditValue = instance.Pelanggan
      txtDriver.EditValue = instance.KaryawanTerima
      txtAlamat.EditValue = instance.KontakAlamat
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtGudang.EditValue = instance.Gudang
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.StatusTransaksi
      txtJenis.EditValue = instance.TipeBarangJO
      txtTujuan.EditValue = instance.KontakTujuan
      txtTujuanAlamat.EditValue = instance.KontakTujuanAlamat

      txtPBM.EditValue = instance.NoDokumen

      'xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
      'instance.Detail.CriteriaString = ""
      'xGrid.DataSource = instance.Detail
      'isikan detail nya
      xDetailTemp = New List(Of Persistent.NishiStockDetailSJ)
      For pi = 0 To instance.Detail.Count - 1
        Dim pData As New Persistent.NishiStockDetailSJ
        pData.xSave = False
        pData.idGR = instance.Detail(pi).StockIN
        pData.Qty = instance.Detail(pi).QtyOut
        pData.QtyKubikasi = instance.Detail(pi).QtyOut2
        pData.Remark = instance.Detail(pi).Catatan
        pData.TruckOut = instance.Detail(pi).TruckIn
        xDetailTemp.Add(pData)
      Next
      xGrid.DataSource = xDetailTemp
      txtCreate.Text = instance.created_user
      editAssign = False
      DisableControl()
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Stock Out [SJ] : Tambah"
    Else
      Me.Text = "Stock Out [SJ]: Edit " & instance.Kode
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
    If txtGudang.EditValue Is Nothing Then Throw New Utils.Exception("Pilih Gudang", -5)

    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      '======= Simpan Main
      instance.TipeBarangJO = CType(txtJenis.EditValue, Persistent.NishiTipeBarangJO)
      instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.KaryawanTerima = CType(txtDriver.EditValue, NuSoft001.Persistent.Kontak)
      instance.KontakAlamat = CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat)
      instance.KontakTujuan = CType(txtTujuan.EditValue, NuSoft001.Persistent.Kontak)
      instance.KontakTujuanAlamat = CType(txtTujuanAlamat.EditValue, NuSoft001.Persistent.KontakAlamat)
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Catatan = txtUraian.Text
      instance.NoDokumen = txtPBM.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)

      'isikan detail nya
      For pi = 0 To xDetailTemp.Count - 1
        If xDetailTemp(pi).xSave = True Then
          Dim pData As New Persistent.NishiStockDetail(session)
          pData.Isi = xDetailTemp(pi).idGR.Isi
          pData.Spek_CaseID = xDetailTemp(pi).idGR.Spek_CaseID
          pData.Size_CaseNo = xDetailTemp(pi).idGR.Size_CaseNo
          pData.Inspection_PartNo = xDetailTemp(pi).idGR.Inspection_PartNo
          pData.PartName = xDetailTemp(pi).idGR.PartName
          pData.WeightNett = xDetailTemp(pi).idGR.WeightNett
          pData.WeightGross = xDetailTemp(pi).idGR.WeightGross

          pData.StockIN = xDetailTemp(pi).idGR
          pData.QtyOut = xDetailTemp(pi).Qty
          pData.TruckIn = xDetailTemp(pi).TruckOut
          pData.QtyOut2 = xDetailTemp(pi).QtyKubikasi
          pData.Catatan = xDetailTemp(pi).Remark

          'update data GR nya
          pData.StockIN.StockOut = pData
          instance.Detail.Add(pData)
        End If
      Next

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
    Dim reportCode As String = "", xReportName As MainClass.reportName
    If instance.TipeBarangJO = Persistent.NishiTipeBarangJO.Coil Then
      xReportName = MainClass.reportName.zNishiVoucherBarangKeluarCoil
    Else
      xReportName = MainClass.reportName.zNishiVoucherBarangKeluarSteel
    End If
    Dim frm As New RF_NishiVoucher(xReportName)
    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    reportCode = MainClass.GetReport(xReportName)
    frm.txtNoBukti1.EditValue = instance.Kode
    message = String.Format(message, "Surat Jalan")
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
    txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub BindingDataSource()
    Dim xKontak As New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    txtKontak.Properties.DataSource = xKontak
    txtTujuan.Properties.DataSource = xKontak
    txtDriver.Properties.DataSource = xKontak
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)
    colKodeBarangRepo.DataSource = New XPCollection(Of Persistent.Barang)(session)
    colSatuanRepo.DataSource = New XPCollection(Of Persistent.Satuan)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    txtJenis.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.NishiTipeBarangJO))
  End Sub
  Private Sub SetFormat()
    'colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    'colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
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
    txtGudang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtGudang)
    instance.Tanggal = txtTanggal.DateTime
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtJenis.EditValue = Persistent.NishiTipeBarangJO.Coil
    LoadLayout(Persistent.NishiTipeBarangJO.Coil)
    txtCreate.Text = Core.SSystem.UserInfo.GetUserName
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SJ)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtGudang.Properties.ReadOnly = True
    txtUraian.Properties.ReadOnly = True
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

      txtAlamat.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
      'txtNoJO.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))
    End If
  End Sub
  Private Sub txtTujuank_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTujuan.EditValueChanging
    If Not e.NewValue Is Nothing Then
      txtTujuanAlamat.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
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
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.NishiStockDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.NishiStockDetail)
    row.Barang = Nothing
    'row.QtyIn = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.NishiStockDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.NishiStockDetail)
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
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub LoadGR(xPelanggan As NuSoft001.Persistent.Kontak)
    Dim xDataGR As New XPCollection(Of Persistent.NishiStockDetail)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal), New BinaryOperator("Main.Pelanggan", xPelanggan, BinaryOperatorType.Equal), New BinaryOperator("Main.JobOrder.TipeBarangJO", CType(txtJenis.EditValue, Persistent.NishiTipeBarangJO), BinaryOperatorType.Equal))) ', New BinaryOperator("QtySisa", 0, BinaryOperatorType.Greater)
    xDetailTemp = New List(Of Persistent.NishiStockDetailSJ)
    For pi = 0 To xDataGR.Count - 1
      If xDataGR(pi).QtySisa > 0 Then
        Dim pData As New Persistent.NishiStockDetailSJ
        pData.xSave = False
        'pData.idGR.Spek_CaseID
        pData.idGR = xDataGR(pi)
        pData.Qty = 0
        pData.QtyKubikasi = 0
        pData.Remark = ""
        pData.TruckOut = ""
        xDetailTemp.Add(pData)
      End If
    Next
    xGrid.DataSource = xDetailTemp
  End Sub
  Private Sub btnTampilkanData_Click(sender As Object, e As EventArgs) Handles btnTampilkanData.Click
    LoadGR(CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak))
  End Sub
  Private Sub txtJenis_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtJenis.EditValueChanging
    If Not e.NewValue Is Nothing Then
      LoadLayout(CType(e.NewValue, Persistent.NishiTipeBarangJO))
      xDetailTemp = New List(Of Persistent.NishiStockDetailSJ)
      xGrid.DataSource = xDetailTemp
    End If
  End Sub
  Private Sub LoadLayout(Jenis As Persistent.NishiTipeBarangJO)
    'colBLNo
    'colIsi
    'colSpekCaseID
    'colSizeCaseno
    'colInspectionPartno
    'colPartName
    'colWeightNett
    'colWeightGross
    'colTruckIN
    'colQty
    'colRemark
    'colKubikasi
    'colSisaQty
    'colSisaKubikasi
    'colX
    'colQtySJ
    'colQtyKubikasi
    'colCatatan
    If Jenis = Persistent.NishiTipeBarangJO.Coil Then
      colIsi.Visible = False
      colSpekCaseID.Caption = "Specification"
      colSizeCaseno.Caption = "Size"
      colInspectionPartno.Caption = "Inspection No"
      colPartName.Visible = False
      colWeightNett.Visible = True
      colWeightNett.VisibleIndex = 6
      colWeightGross.Visible = True
      colWeightGross.VisibleIndex = 7
      colKubikasi.Visible = False
      colSisaKubikasi.Visible = False
      colQtyKubikasiSJ.Visible = False
    Else
      colIsi.Visible = True
      colIsi.VisibleIndex = 1
      colSpekCaseID.Caption = "Case Id"
      colSizeCaseno.Caption = "Case No"
      colInspectionPartno.Caption = "Parts Number"
      colPartName.Visible = True
      colWeightNett.Visible = False
      colWeightGross.Visible = False
      colSisaKubikasi.Visible = True
      colKubikasi.Visible = True
      colQtyKubikasiSJ.Visible = True
      colInspectionPartno.VisibleIndex = 6
      colPartName.VisibleIndex = 7
      colTruckIN.VisibleIndex = 8
      colRemark.VisibleIndex = 9
      colQtyGR.VisibleIndex = 10
      colSisaQty.VisibleIndex = 11
      colKubikasi.VisibleIndex = 12
      colX.VisibleIndex = 13
      colQtySJ.VisibleIndex = 14
      colQtyKubikasiSJ.VisibleIndex = 15
      colTruckOut.VisibleIndex = 16
      colCatatan.VisibleIndex = 17
    End If
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.NishiStockDetailSJ = CType(xGridView.GetRow(e.RowHandle), Persistent.NishiStockDetailSJ)
      If e.Column Is colX Then
        If CType(e.Value, Boolean) = True Then
          row.Qty = row.idGR.QtyIn
          row.QtyKubikasi = row.idGR.QtyIn2
        End If
      End If
    End If
  End Sub
End Class