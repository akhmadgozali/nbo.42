Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSplashScreen

Friend Class UI_Fusoh_SQDialog
  Private instance As Persistent.Fusoh_Penawaran
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.Fusoh_PenawaranDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting
  Private masterItem As XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.Fusoh_Penawaran.AutoSaveOnEndEdit = False
    Persistent.Fusoh_PenawaranDetail.AutoSaveOnEndEdit = False

    colOD.Caption = "OD" & vbCrLf & "(mm)"
    colInD.Caption = "ID" & vbCrLf & "(mm)"
    colThickness.Caption = "T" & vbCrLf & "(mm)"
    colLength.Caption = "L" & vbCrLf & "(mm)"
    colQty.Caption = "Min" & vbCrLf & "Qty"
    colWeight.Caption = "Total" & vbCrLf & "Weight"
    colHarga.Caption = "Current Price"
    colProcessingPrice.Caption = "Processing" & vbCrLf & "Price"
    colHargaRp.Caption = "Price" & vbCrLf & "Rp / Pcs"
    colTotal.Caption = "Total Price" & vbCrLf & "Rp"
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SQTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SQTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SQTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SQTransaksiGrid.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Fusoh_Penawaran(session)
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.EditValue = CType(txtKontak.Properties.DataSource, XPCollection(Of NuSoft001.Persistent.Kontak))(0)
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.Fusoh_Penawaran)(Convert.ToInt64(IdToEdit))
      txtKontak.EditValue = instance.Pelanggan
      txtKontakPerson.EditValue = instance.KontakPerson
      txtAlamat.EditValue = instance.Alamat
      If Not instance.Alamat Is Nothing Then
        txtAlamatText.EditValue = instance.Alamat.Alamat
      End If
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.StatusTransaksi
      txtTermPrice.Text = instance.TermOfPrice
      txtTermin.EditValue = instance.Termin
      txtPayment.Text = instance.Payment
      txtInspection.Text = instance.Inspection
      txtValidiity1.DateTime = instance.TanggalBerlakuAwal
      txtValidiity2.DateTime = instance.TanggalBerlakuAkhir
      txtUang.EditValue = instance.Uang
      txtKurs.Value = instance.Kurs
      txtYourReff.Text = instance.YourReff
      txtOthers.Text = instance.Others
      txtCatatan.Text = instance.Catatan

      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Penawaran Penjualan [SQ] : Tambah"
    Else
      Me.Text = "Penawaran Penjualan [SQ] : Edit " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl()
      End If
      If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
        DisableControl()
      End If
      If User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
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
      If Tipe = InputType.Tambah Then
        instance.Revisi = 0
      Else
        If MsgBox("Apakah anda ingin menambah revisi?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
          instance.Revisi = instance.Revisi + 1
        End If
      End If

      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)

      '======= Simpan Main
      instance.Pelanggan = If(txtKontak.EditValue Is Nothing, Nothing, CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak))
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Alamat = If(txtAlamat.EditValue Is Nothing, Nothing, CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat))
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = If(txtRegional.EditValue Is Nothing, Nothing, CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional))
      instance.Kode = txtNoTransaksi.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)

      instance.TermOfPrice = txtTermPrice.Text
      instance.Termin = If(txtTermin.EditValue Is Nothing, Nothing, CType(txtTermin.EditValue, NuSoft005.Persistent.Termin))
      instance.Payment = txtPayment.Text
      instance.Inspection = txtInspection.Text
      instance.TanggalBerlakuAwal = txtValidiity1.DateTime
      instance.TanggalBerlakuAkhir = txtValidiity2.DateTime
      instance.Uang = If(txtUang.EditValue Is Nothing, Nothing, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang))
      instance.Kurs = txtKurs.Value
      instance.YourReff = txtYourReff.Text
      instance.Others = txtOthers.Text
      instance.Catatan = txtCatatan.Text

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

    '======= Simple log
    Try
      If Tipe = InputType.Tambah Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Penawaran Penjualan [SQ] -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Penawaran Penjualan [SQ] -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try

    Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.SQ)
    frm.txtNoBukti1.EditValue = instance.Kode

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherSQ)
    message = String.Format(message, "Penawaran Penjualan")
    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -2 : txtTanggal.Focus()
      Case -3 : txtKontak.Focus()
      Case -4 : txtUang.Focus()
      Case -5 : txtValidiity1.Focus()
      Case -6 : txtValidiity2.Focus()
      Case -7 : txtNoTransaksi.Focus()
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
    If salesSetting.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    txtTermin.Properties.DataSource = New XPCollection(Of NuSoft005.Persistent.Termin)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatString
    colHarga.SummaryItem.DisplayFormat = setting.NumericFormatString
    colProcessingPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colProcessingPrice.DisplayFormat.FormatString = setting.NumericFormatString
    colProcessingPrice.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHargaRp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaRp.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaRp.SummaryItem.DisplayFormat = setting.NumericFormatString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

    'txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    'txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
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
    txtTermPrice.EditValue = Nothing
    txtTermin.EditValue = Nothing
    txtPayment.EditValue = Nothing
    txtInspection.EditValue = Nothing
    txtValidiity1.EditValue = Nothing
    txtValidiity2.EditValue = Nothing
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    txtKurs.EditValue = 1
    txtOthers.EditValue = salesSetting.UraianSQ
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SQ)
    'instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "[S][Y2]-[X4]"}
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "SQ[Y2]-[M0][X2]"}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtKontakPerson.Enabled = False
    txtAlamat.Enabled = False
    txtAlamatText.Enabled = False
    txtTanggal.Properties.ReadOnly = True
    txtRegional.Enabled = False
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
    txtTermPrice.Enabled = False
    txtTermin.Enabled = False
    txtPayment.Enabled = False
    txtInspection.Enabled = False
    txtValidiity1.Enabled = False
    txtValidiity2.Enabled = False
    txtUang.Enabled = False
    txtKurs.Enabled = False
    txtOthers.Enabled = False
    txtCatatan.Enabled = False
    txtYourReff.Enabled = False
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
      txtAlamat.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakAlamat)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
      xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_Penawaran)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))

      masterItem = New XPCollection(Of NuSoft004.Persistent.Fusoh_Barang)(session,
                   New GroupOperator(GroupOperatorType.And,
                   New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanJadi, BinaryOperatorType.Equal),
                   New BinaryOperator("Customer", e.NewValue, BinaryOperatorType.Equal),
                   New BinaryOperator("Aktif", True, BinaryOperatorType.Equal)))
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
      Dim row As Persistent.Fusoh_PenawaranDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_PenawaranDetail)
      If Not row Is Nothing Then
        If e.Column Is colNoPart Then
          Dim item = masterItem.ToList.Find(Function(m) m.Kode = e.Value)
          If Not item Is Nothing Then
						row.Barang = item.NamaPart
						row.Material = item.Nama
						row.OutDiameter = item.OutDiameter
            row.InDiameter = item.InDiameter
            row.Thickness = item.Thickness
            row.Length = item.Length
            row.Weight = NuSoft004.FusohLogic.Item.GetWeight(row.OutDiameter, row.Length, row.Thickness) * row.Qty

            If Not txtKontak.EditValue Is Nothing Then
              Dim xHarga As Double = 0
              Select Case CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).LevelPenjualan
                Case NuSoft001.Persistent.eLevelPenjualan.Level1 : xHarga = item.HargaJual1
                Case NuSoft001.Persistent.eLevelPenjualan.Level2 : xHarga = item.HargaJual2
                Case NuSoft001.Persistent.eLevelPenjualan.Level3 : xHarga = item.HargaJual3
                Case NuSoft001.Persistent.eLevelPenjualan.Level4 : xHarga = item.HargaJual4
                Case NuSoft001.Persistent.eLevelPenjualan.Level5 : xHarga = item.HargaJual5
              End Select
              row.Harga = xHarga
            End If
          End If
        ElseIf e.Column Is colQty OrElse e.Column Is colOD OrElse e.Column Is colLength OrElse e.Column Is colThickness Then
          row.Weight = NuSoft004.FusohLogic.Item.GetWeight(row.OutDiameter, row.Length, row.Thickness) * row.Qty
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.Fusoh_PenawaranDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_PenawaranDetail)
    row.Barang = Nothing
    row.OutDiameter = 0.0
    row.InDiameter = 0.0
    row.Thickness = 0.0
    row.Length = 0.0
    row.Qty = 0
    row.Harga = 0
    row.HargaProses = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.Fusoh_PenawaranDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_PenawaranDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SQTransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_ShownEditor(sender As Object, e As EventArgs) Handles xGridView.ShownEditor
    Dim view = CType(sender, GridView)
    If view.IsNewItemRow(view.FocusedRowHandle) Then
      view.ActiveEditor.IsModified = True
    End If
    If view.FocusedColumn.FieldName.Equals("PartNo") Then
      Dim currentEditor As ButtonEdit = CType(view.ActiveEditor, ButtonEdit)
      If Not currentEditor Is Nothing Then
        Dim customSource As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        customSource.AddRange(masterItem.Select(Function(m) m.Kode).ToArray)

        currentEditor.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        currentEditor.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        currentEditor.MaskBox.AutoCompleteCustomSource = customSource
      End If
    End If
  End Sub
  Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
    'MyBase.OnKeyDown(e)
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
  Private Sub txtTglBerlaku_EditValueChanged(sender As Object, e As EventArgs) Handles txtValidiity1.EditValueChanged
    txtTanggal.Properties.MaxValue = CDate(txtValidiity1.EditValue)
  End Sub
  Private Sub txtTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles txtTanggal.EditValueChanged
    'txtValidiity1.Properties.MinValue = CDate(txtTanggal.EditValue)
  End Sub
  Private Sub txtAlamat_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAlamat.EditValueChanging
    If Not e.NewValue Is Nothing Then
      txtAlamatText.Text = CType(e.NewValue, NuSoft001.Persistent.KontakAlamat).Alamat
    End If
  End Sub

  Private Sub txtKurs_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtKurs.EditValueChanging
    If Not instance Is Nothing Then
      'MsgBox(e.NewValue)
      instance.Kurs = e.NewValue
      xGrid.RefreshDataSource()
    End If
  End Sub

  Private Sub colPartRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colPartRepo.ButtonClick
    Dim frm As New UI_Fusoh_SQDialogBarang
    frm.LoadingData(masterItem)
    If frm.ShowDialog = DialogResult.OK Then
      'MsgBox(frm.Item.Kode)
      xGridView.SetFocusedValue(frm.Item.Kode)
    End If
  End Sub

  Private Sub txtUang_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtUang.EditValueChanging
    'colHargaRp.Caption = "Price" & vbCrLf & "Rp / Pcs"
    instance.Uang = CType(e.NewValue, NuSoft001.Persistent.MataUang)
    If Not e.NewValue Is Nothing AndAlso Not instance Is Nothing Then
      colHargaRp.Caption = "Price" & vbCrLf & instance.Uang.Kode & " / Pcs"
    End If
  End Sub

  Private Sub btnDownload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDownload.ItemClick
    Using dialog = New SaveFileDialog()
      dialog.Title = "Download Template Impor SQ"
      dialog.FileName = "template_impor_sq.xlsm"
      dialog.Filter = "XLSM Files (*.xlsm)|*.xlsm"
      dialog.OverwritePrompt = True
      If (dialog.ShowDialog() <> DialogResult.OK OrElse String.IsNullOrEmpty(dialog.FileName)) Then Return

      Dim stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NuSoft.NUI.Win.Forms.Modules.NuSoft006.template_impor_sq.xlsm")
      Dim fileStream = New FileStream(dialog.FileName, FileMode.OpenOrCreate)
      For i = 0 To stream.Length - 1
        fileStream.WriteByte(CType(stream.ReadByte(), Byte))
      Next
      fileStream.Close()
      MessageBox.Show("File '" + dialog.FileName + "' selesai di download.", "Download Template Impor SQ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Using
  End Sub
  Private Sub btnImpor_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpor.ItemClick
    Using splashManager As SplashScreenManager = New SplashScreenManager(Me, GetType(x_Wait), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Import data ...")

      Try
        Using dialog = New OpenFileDialog
          dialog.Title = "Pilih File Template"
          dialog.Filter = "XLSM Files (*.xlsm)|*.xlsm"
          If (dialog.ShowDialog() <> DialogResult.OK OrElse String.IsNullOrEmpty(dialog.FileName)) Then Return

          Using stream = New FileStream(dialog.FileName, FileMode.Open)
            Dim xlsControl = New SpreadsheetControl()
            xlsControl.LoadDocument(stream, DocumentFormat.Xlsm)

            Dim wsName = "ImportData"
            Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
            If Not workSheet Is Nothing Then
              Dim cellNamePart = "PartNo"
              Dim cellNameQty = "Min Qty"
              Dim cellNameHarga = "Current Price"
              Dim cellNameHargaProses = "Processing Price"
							Dim cellNameCatatan = "Remarks"
							Dim cellPartName = "PartName"
							Dim CellMaterial = "Material"
							Dim CellIN = "InDiameter"
							Dim CellID = "OutDiameter"
							Dim CellThickness = "Thickness"
							Dim CellLength = "Length"

							Dim usedRange = workSheet.GetUsedRange()
              Dim cellPosNamePart = FindColumnPosition(workSheet, usedRange, cellNamePart)
              Dim cellPosQty = FindColumnPosition(workSheet, usedRange, cellNameQty)
              Dim cellPosHarga = FindColumnPosition(workSheet, usedRange, cellNameHarga)
              Dim cellPosHargaProses = FindColumnPosition(workSheet, usedRange, cellNameHargaProses)
              Dim cellPosCatatan = FindColumnPosition(workSheet, usedRange, cellNameCatatan)

							Dim cellPosPartName = FindColumnPosition(workSheet, usedRange, cellPartName)
							Dim cellPosMaterial = FindColumnPosition(workSheet, usedRange, CellMaterial)
							Dim cellPosIN = FindColumnPosition(workSheet, usedRange, CellIN)
							Dim cellPosOD = FindColumnPosition(workSheet, usedRange, CellID)
							Dim cellPosThickness = FindColumnPosition(workSheet, usedRange, CellThickness)
							Dim cellPosLength = FindColumnPosition(workSheet, usedRange, CellLength)


							For i = 1 To usedRange.RowCount - 1
                Dim xNama As String = Trim(workSheet.Cells(i, cellPosNamePart).DisplayText)
                If Trim(xNama) <> "" Then
									'         Dim item = masterItem.ToList.Find(Function(m) m.Kode = xNama)
									'If Not item Is Nothing Then
									'End If
									Dim xItem As New Persistent.Fusoh_PenawaranDetail(session)
									xItem.PartNo = xNama
									xItem.Barang = Trim(workSheet.Cells(i, cellPosPartName).DisplayText)
									xItem.Material = Trim(workSheet.Cells(i, cellPosMaterial).DisplayText)

									xItem.OutDiameter = workSheet.Cells(i, cellPosOD).Value.NumericValue
									xItem.InDiameter = workSheet.Cells(i, cellPosIN).Value.NumericValue
									xItem.Thickness = workSheet.Cells(i, cellPosThickness).Value.NumericValue
									xItem.Length = workSheet.Cells(i, cellPosLength).Value.NumericValue

									If workSheet.Cells(i, cellPosQty).Value.IsNumeric Then
										xItem.Qty = workSheet.Cells(i, cellPosQty).Value.NumericValue
									End If
									xItem.Weight = NuSoft004.FusohLogic.Item.GetWeight(xItem.OutDiameter, xItem.Length, xItem.Thickness) * xItem.Qty

									If workSheet.Cells(i, cellPosHarga).Value.IsNumeric Then
										xItem.Harga = workSheet.Cells(i, cellPosHarga).Value.NumericValue
									End If
									If workSheet.Cells(i, cellPosHargaProses).Value.IsNumeric Then
										xItem.HargaProses = workSheet.Cells(i, cellPosHargaProses).Value.NumericValue
									End If
									xItem.Catatan = workSheet.Cells(i, cellPosCatatan).DisplayText

									'If xItem.Harga = 0 AndAlso Not txtKontak.EditValue Is Nothing Then
									'	Dim xHarga As Double = 0
									'	Select Case CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).LevelPenjualan
									'		Case NuSoft001.Persistent.eLevelPenjualan.Level1 : xHarga = item.HargaJual1
									'		Case NuSoft001.Persistent.eLevelPenjualan.Level2 : xHarga = item.HargaJual2
									'		Case NuSoft001.Persistent.eLevelPenjualan.Level3 : xHarga = item.HargaJual3
									'		Case NuSoft001.Persistent.eLevelPenjualan.Level4 : xHarga = item.HargaJual4
									'		Case NuSoft001.Persistent.eLevelPenjualan.Level5 : xHarga = item.HargaJual5
									'	End Select
									'	xItem.Harga = xHarga
									'End If

									instance.Detail.Add(xItem)

								End If
              Next
            End If
          End Using
        End Using
        'xGrid.Refresh()
        'xGrid.RefreshDataSource()
        xGrid.Refresh()
        If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
      Catch ex As Exception
        If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
        If ex.Message = "The specified offset refers to the column beyond the worksheet." Then
          MessageBox.Show("Format file excel tidak sesuai dengan format sistem.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
          Throw New Exception(ex.Message, ex.InnerException)
        End If
      Finally
        If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
      End Try
    End Using
  End Sub
  Private Function FindColumnPosition(ws As Worksheet, usedRange As Range, headerName As String) As Integer
    For j = 0 To usedRange.ColumnCount - 1
      Dim x = ws.Cells(0, j).DisplayText.Trim()
      If (ws.Cells(0, j).DisplayText = headerName) Then Return j
      If (x = headerName) Then Return j
    Next
    Return -1
  End Function
End Class