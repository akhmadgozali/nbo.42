Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Friend Class UI_FusohCuttingWIPDialog
  Private instance As Persistent.Fusoh_StokMain
  Private originalData As Persistent.Fusoh_StokMain
  Private isShown As Boolean
  Private editAssign As Boolean = False
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private detailSource As List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True

    colOD.Caption = "OD" & vbCrLf & "(mm)"
    colInD.Caption = "ID" & vbCrLf & "(mm)"
    colThickness.Caption = "T" & vbCrLf & "(mm)"
    colLength.Caption = "L" & vbCrLf & "(mm)"
    colWeight.Caption = "Total" & vbCrLf & "Weight"
    xGridView.IndicatorWidth = 30
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CWTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CWTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CWTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CWTransaksiGrid.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Fusoh_StokMain(session)
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.Fusoh_StokMain)(Convert.ToInt64(IdToEdit))
      originalData = CType(instance.Clone, Persistent.Fusoh_StokMain)
      'Dim sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is instance.OrderProduksi AndAlso Not w.Main Is instance And w.Main.Sumber.Id = Persistent.SumberDataJenis.CW).ToList
      Dim sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is instance.OrderProduksi AndAlso w.Main.Sumber.Id = Persistent.SumberDataJenis.CW).ToList

      txtDempyou.Properties.DataSource = New Persistent.Fusoh_OrderProduksi() {instance.OrderProduksi}
      txtKontak.EditValue = instance.Pelanggan
      txtDempyou.EditValue = instance.OrderProduksi
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.StatusTransaksi

      If Not instance.OrderProduksi Is Nothing Then
        If Not instance.OrderProduksi.SODetail Is Nothing Then
          txtNoPO.Text = instance.OrderProduksi.SODetail.Main.NomorPO
          txtPOLine.Text = instance.OrderProduksi.SODetail.POLine.ToString
          txtPartNo.Text = instance.OrderProduksi.SODetail.Barang.Kode
          txtMaterial.Text = instance.OrderProduksi.SODetail.Barang.Nama
          txtSize.Text = instance.OrderProduksi.SODetail.OutDiameter.ToString("n0") & " x " & instance.OrderProduksi.SODetail.Thickness.ToString("n0")
          txtLength.Text = instance.OrderProduksi.SODetail.Length.ToString("n0")
        End If
        txtGudang.Text = instance.OrderProduksi.Gudang.Kode
        txtQtyDempyou.Value = CDec(instance.OrderProduksi.Qty)
        txtSisaQty.Value = CDec(instance.OrderProduksi.Qty - sdhProses.Sum(Function(s) s.QtyIn) + instance.TotalQtyIn)
        'MsgBox("Jali -->CDec(" & instance.OrderProduksi.Qty & " - " & sdhProses.Sum(Function(s) s.QtyIn) & " + " & instance.TotalQtyIn & ")")
        txtCutting.EditValue = instance.OrderProduksi.Cutting
        txtRMDibutuhkan.EditValue = (instance.OrderProduksi.Cutting + 3) * txtQtyDempyou.Value
      End If

      ' cutting
      '''If instance.DailyProcess.Count > 0 Then
      '''  Dim cutting = instance.DailyProcess.Max(Function(m) m)
      '''  If Not cutting Is Nothing Then
      '''    txtCuttingMesin.EditValue = cutting.Mesin
      '''    txtCuttingShift.Value = cutting.Shift
      '''    txtCuttingProcess.EditValue = cutting.ProcessCutting
      '''    'txtQtyDempyou.Properties.MaxValue = txtSisaQty.Value
      '''    txtCuttingOP.SelectedIndex = cutting.ProcessCutting.DefaultFG - 1
      '''  End If
      '''End If
      txtCuttingQty.Value = CDec(instance.TotalQtyIn)
      txtCuttingNomorLot.Text = instance.DempyouLot
      txtCuttingMesin.EditValue = instance.CuttingMesin
      txtCuttingShift.Value = instance.CuttingShift
      txtCuttingProcess.EditValue = instance.CuttingProcess
      If Not instance.CuttingProcess Is Nothing Then
        txtCuttingOP.SelectedIndex = instance.CuttingProcess.DefaultFG - 1
      End If

      detailSource = Services.TransaksiCuttingWIPService.GetDetailSource(instance, sdhProses)
      xGrid.DataSource = detailSource
      txtDempyou.Properties.ReadOnly = True
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      Me.Text = "Cutting [WIP] : Tambah"
    Else
      Me.Text = "Cutting [WIP] : Edit " & instance.Kode
      'If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
      '  DisableControl()
      'End If
      'If Periode.CheckLockedPeriod(session, instance.Tanggal) Then
      '  DisableControl()
      'End If
      If User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
        DisableControl()
      End If
    End If
  End Sub
  Overrides Sub SimpanData()
		Try
			If detailSource.Count = 0 Then
				Throw New Utils.Exception("Detail Serial kosong, silahkan masukkan nomor SN terlebih dahulu.")
			End If

			'======= cek stok
			Services.TransaksiCuttingWIPService.CheckStokInDetailSource(session, instance, detailSource)

			'======= Simpan Main
			instance.Pelanggan = If(txtKontak.EditValue Is Nothing, Nothing, CType(txtKontak.EditValue, Kontak))
			instance.OrderProduksi = If(txtDempyou.EditValue Is Nothing, Nothing, CType(txtDempyou.EditValue, Persistent.Fusoh_OrderProduksi))
			instance.Tanggal = txtTanggal.DateTime
			instance.Regional = If(txtRegional.EditValue Is Nothing, Nothing, CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional))
			instance.Kode = txtNoTransaksi.Text
			instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)
			instance.Kurs = 1
			instance.DempyouLot = txtCuttingNomorLot.Text

			Dim mesin As Persistent.Fusoh_Mesin = Nothing
			If Not txtCuttingMesin.EditValue Is Nothing Then mesin = CType(txtCuttingMesin.EditValue, Persistent.Fusoh_Mesin)
			Dim cuttingProcess As Persistent.Fusoh_ProcessCutting = Nothing
			If Not txtCuttingProcess.EditValue Is Nothing Then cuttingProcess = CType(txtCuttingProcess.EditValue, Persistent.Fusoh_ProcessCutting)

			'MsgBox("cutting proses : " & cuttingProcess.Nama)

			Services.TransaksiCuttingWIPService.SaveData(session, instance, originalData, mesin, CInt(txtCuttingShift.Value), cuttingProcess, CInt(txtCuttingQty.Value), detailSource)
		Catch ex As Utils.Exception
			Throw New Utils.Exception(ex)
		Catch ex As Exception
			If ex.Message.Contains("Duplicate entry") Then
				'instance.Kode = instance.Number.GetNewNumber.Kode
				'session.CommitChanges()
				Throw New Utils.Exception("Kode '" & instance.Kode & "' sudah pernah diinput." & vbCrLf & "Mohon masukkan kode lain.", 0)
			Else
				Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case 0 : txtNoTransaksi.Focus()
			Case -1 : txtRegional.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtKontak.Focus()
			Case -4 : txtDempyou.Focus()
			Case -5 : xGrid.Focus()
			Case -6 : txtStatus.Focus()
			Case -7 : txtCuttingMesin.Focus()
			Case -8 : txtCuttingProcess.Focus()
			Case -9 : txtCuttingQty.Focus()
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
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(StatusTransaksiEnum))
    txtKontak.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderPenjualan)(session).GroupBy(Function(g) g.Pelanggan).Select(Function(s) s.Key).ToList
    txtCuttingMesin.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_Mesin)(session).ToList()
    txtCuttingProcess.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_ProcessCutting)(session).OrderBy(Function(o) o.Kode).ToList()

    Dim ccc = New XPQuery(Of Persistent.Fusoh_StokMain)(session).Where(Function(w) Not String.IsNullOrEmpty(w.DempyouLot)).GroupBy(Function(g) g.DempyouLot).Select(Function(s) s.Key).ToArray
    If ccc.Count > 0 Then
      Dim collection As New AutoCompleteStringCollection()
      collection.AddRange(ccc)
      txtCuttingNomorLot.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
      txtCuttingNomorLot.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
      txtCuttingNomorLot.MaskBox.AutoCompleteCustomSource = collection
    End If
  End Sub
  Private Sub LoadDefault()
    Dim defaultRegional = UserInfo.GetDefaultRegional(session)
    txtTanggal.EditValue = Now
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    End If
    instance.Tanggal = txtTanggal.DateTime
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)

		txtStatus.EditValue = StatusTransaksiEnum.Posting
		txtCuttingShift.Value = 1
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.CW)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtDempyou.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtCuttingMesin.Properties.ReadOnly = True
    txtCuttingShift.Properties.ReadOnly = True
    txtCuttingNomorLot.Properties.ReadOnly = True
    txtCuttingProcess.Properties.ReadOnly = True
    txtCuttingQty.Properties.ReadOnly = True
    xGridView.OptionsBehavior.ReadOnly = True
    AllowSave = False
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

  Private Sub txtKontak_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      lblKontakNama.Text = CType(e.NewValue, Kontak).Nama
      'isikan data detailnya
      txtPhoneNumber.Text = CType(e.NewValue, Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, Kontak).BatasHutang)

      xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_OrderProduksi)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))

      If Not editAssign Then
        If Tipe = InputType.Tambah Then
          Dim settingWIP As New FusohLogic.FusohWIPSetting(session)
          If settingWIP.TanggalMulaiWIP = Nothing Then
            Utils.Win.MessageBox.Show("Tanggal mulai alur WIP belum ada di Setting WIP", Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
          Else
            txtDempyou.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(m) m.Pelanggan Is e.NewValue AndAlso m.Tanggal >= settingWIP.TanggalMulaiWIP AndAlso (m.StatusTransaksi = StatusTransaksiEnum.InProgress OrElse m.StatusTransaksi = StatusTransaksiEnum.Posting)).ToList
          End If
        Else
          Dim dd As New List(Of Persistent.Fusoh_OrderProduksi)
          dd.Add(instance.OrderProduksi)
          txtDempyou.Properties.DataSource = dd
        End If
      End If
    End If
  End Sub
  Private Sub txtDempyou_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtDempyou.EditValueChanging
    If Not editAssign Then
      If Not e.NewValue Is Nothing Then
        Dim x = CType(e.NewValue, Persistent.Fusoh_OrderProduksi)
        Dim sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is x And w.Main.Sumber.Id = Persistent.SumberDataJenis.CW).ToList
        Dim sisa = CDec(x.Qty - sdhProses.Sum(Function(s) s.QtyIn))

        txtNoPO.Text = x.SODetail.Main.NomorPO
        txtPOLine.Text = x.SODetail.POLine.ToString
        txtGudang.Text = x.Gudang.Kode
        txtPartNo.Text = x.SODetail.Barang.Kode
        txtMaterial.Text = x.SODetail.Barang.Nama
        txtSize.Text = x.SODetail.OutDiameter.ToString("n0") & " x " & x.SODetail.Thickness.ToString("n0")
        txtLength.Text = x.SODetail.Length.ToString("n0")
        txtQtyDempyou.Value = CDec(x.Qty)
        txtSisaQty.Value = sisa

				Dim lebarMataPisau As Double = 3
        If x.NoCutting Then lebarMataPisau = 0
        'MsgBox("Dempyou Cutting :" & x.Cutting)
        Dim dempyouCutting = x.Cutting + lebarMataPisau
				Dim rmDibutuhkan = dempyouCutting * sisa

				txtCutting.EditValue = x.Cutting
				txtCuttingProcess.EditValue = x.SODetail.Barang.MaterialProses
				txtRMDibutuhkan.EditValue = rmDibutuhkan ' (x.Cutting + 3) * sisa

				txtCuttingQty.Properties.MaxValue = sisa
        txtCuttingQty.Value = sisa
        txtCuttingNomorLot.Text = x.NomorLot

        detailSource = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
        'MsgBox("isinya adalah : " & x.BahanBaku.Count)
        For Each det In x.BahanBaku
          Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
          item.Barang = det.Barang
          item.Catatan = det.Catatan
          item.Id = det.Id
          item.Millsheet = det.Millsheet
          item.Serial = det.Serial
          Dim xSerial = sdhProses.FindAll(Function(m) m.Barang Is item.Barang).SelectMany(Function(m) m.Serial).ToList.FindAll(Function(f) f.Serial = item.Serial)
          item.SNLength = CDec(det.SNLength - xSerial.Sum(Function(s) s.LengthOut))

          '====
          item.SNQty = xSerial.Sum(Function(s) s.Qty)

          'item.Length = det.Length
          item.Length = det.Length - xSerial.Sum(Function(s) s.LengthOut)
          item.Qty = det.Qty
          item.Scrap = det.Scrap

          '=== auto length
          Dim sisaLength = CDec(det.Length - xSerial.Sum(Function(s) s.LengthOut))
          Dim jumlahPotong = CInt(sisaLength / dempyouCutting)
          item.Length = jumlahPotong * dempyouCutting

          'MsgBox("SN : " & item.Serial & "--> Sisalength = CDec(" & det.Length & " - " & xSerial.Sum(Function(s) s.LengthOut) & ") --> SN Length :" & item.SNLength)
          'MsgBox("SN : " & item.Serial & "--> " & rmDibutuhkan & " <> " & item.Length)
          If rmDibutuhkan >= item.Length Then
            'MsgBox("SN : " & item.Serial & "(itemlength>sisalength) : " & item.Length > sisaLength & "--> " & item.Length & ">" & sisaLength & " ===> " & dempyouCutting)
            If jumlahPotong = 1 Then
              If item.Length > sisaLength Then
                item.Length = dempyouCutting
              End If
            Else
              If item.Length > sisaLength Then
                item.Length -= dempyouCutting
              End If
            End If
            rmDibutuhkan -= item.Length
          Else
            item.Length = rmDibutuhkan
            rmDibutuhkan = 0
          End If
          'MsgBox("Dibutuhkan : SNLEngth = " & item.SNLength & " <--> ItemLength=" & item.Length)

          item.Qty = CInt(IIf(item.SNLength = item.Length, 1, 0))
          'MsgBox("Selesai : " & item.Serial & "-->" & item.Length)
          If (item.Length > 0) Then detailSource.Add(item)
          If rmDibutuhkan <= 0 Then
            Exit For
          End If
        Next

        xGrid.DataSource = detailSource
      End If
    End If
  End Sub
  Private Sub txtCuttingQty_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtCuttingQty.EditValueChanging
		If Not e.NewValue Is Nothing Then
			If txtDempyou.EditValue Is Nothing Then Return
			Dim dempyou = CType(txtDempyou.EditValue, Persistent.Fusoh_OrderProduksi)
			Dim lebarMataPisau As Double = 3
			If dempyou.NoCutting Then lebarMataPisau = 0
			'Dim dempyouCutting = dempyou.Cutting + lebarMataPisau '3
			'Dim rmDibutuhkan = dempyouCutting * txtCuttingQty.Value
			txtRMDibutuhkan.EditValue = (CDbl(txtCutting.EditValue) + lebarMataPisau) * CDbl(e.NewValue)
		Else
			txtRMDibutuhkan.EditValue = 0
    End If
  End Sub
  Private Sub txtCuttingQty_EditValueChanged(sender As Object, e As EventArgs) Handles txtCuttingQty.EditValueChanged
    If editAssign Then Return
    If txtDempyou.EditValue Is Nothing Then Return

    xGrid.DataSource = Nothing
    detailSource = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
    Dim sdhProses As List(Of Persistent.Fusoh_StokDetail)
    Dim dempyou = CType(txtDempyou.EditValue, Persistent.Fusoh_OrderProduksi)
		Dim lebarMataPisau As Double = 3
		If dempyou.NoCutting Then lebarMataPisau = 0
		Dim dempyouCutting = dempyou.Cutting + lebarMataPisau '3
		Dim rmDibutuhkan = dempyouCutting * txtCuttingQty.Value
		If Tipe = InputType.Tambah Then
			sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is dempyou).ToList
		Else
			instance = session.GetObjectByKey(Of Persistent.Fusoh_StokMain)(Convert.ToInt64(IdToEdit))
      sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is dempyou AndAlso Not w.Main Is instance).ToList
    End If

    For Each det In dempyou.BahanBaku
      Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
      item.Barang = det.Barang
      item.Catatan = det.Catatan
      item.Id = det.Id
      item.Millsheet = det.Millsheet
      item.Serial = det.Serial
      Dim xSerial = sdhProses.FindAll(Function(m) m.Barang Is item.Barang).SelectMany(Function(m) m.Serial).ToList.FindAll(Function(f) f.Serial = item.Serial)
      item.SNLength = CDec(det.SNLength - xSerial.Sum(Function(s) s.LengthOut))
      item.SNQty = xSerial.Sum(Function(s) s.Qty)
      Dim sisaLength = CDec(det.Length - xSerial.Sum(Function(s) s.LengthOut))

      Dim jumlahPotong = CInt(sisaLength / dempyouCutting)
      item.Length = jumlahPotong * dempyouCutting
      If rmDibutuhkan >= item.Length Then
        If item.Length > sisaLength Then
          item.Length -= dempyouCutting
        End If
        rmDibutuhkan -= item.Length
      Else
        item.Length = rmDibutuhkan
        rmDibutuhkan = 0
      End If

      item.Qty = CInt(IIf(item.SNLength = item.Length, 1, 0))
      item.Scrap = det.Scrap
      If (item.Length > 0) Then detailSource.Add(item)
      If rmDibutuhkan <= 0 Then
        Exit For
      End If
    Next
    xGrid.DataSource = detailSource
  End Sub
  Private Sub txtCuttingProcess_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtCuttingProcess.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim val = CType(e.NewValue, Persistent.Fusoh_ProcessCutting)
      txtCuttingOP.SelectedIndex = val.DefaultFG - 1
    End If
  End Sub

  Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Private Sub txtRegional_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtRegional.EditValueChanging
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
        XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
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
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub

  Private Sub xGridView_ShownEditor(sender As Object, e As EventArgs) Handles xGridView.ShownEditor
    If (xGridView.FocusedColumn Is colMaterialLength AndAlso xGridView.ActiveEditor.GetType Is GetType(SpinEdit)) Then
      Dim edit As SpinEdit = CType(xGridView.ActiveEditor, SpinEdit)
      Dim item As NonPersistent.Fusoh_Produksi_BahanBaku_Temp = CType(xGridView.GetRow(xGridView.FocusedRowHandle), NonPersistent.Fusoh_Produksi_BahanBaku_Temp)

      edit.Properties.MaxValue = item.SNLength
    End If
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As NonPersistent.Fusoh_Produksi_BahanBaku_Temp = CType(xGridView.GetRow(e.RowHandle), NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
      If e.Column Is colMaterialLength Then
        row.Qty = 0
        If row.SNLength = CDec(e.Value) AndAlso row.SNQty < 1 Then
          row.Qty = 1
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles xGridView.InvalidRowException
    e.ExceptionMode = ExceptionMode.NoAction
  End Sub
  Private Sub xGridView_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles xGridView.CustomDrawRowIndicator
    If e.RowHandle >= 0 Then
      e.Info.DisplayText = (e.RowHandle + 1).ToString
    End If
  End Sub
	Private Sub colCommandRepo_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles colCommandRepo.ButtonPressed
		Dim row = CType(xGridView.GetFocusedRow, NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
		If e.Button.Kind = ButtonPredefines.Minus Then
			detailSource.Remove(row)
			xGrid.RefreshDataSource()
		End If
	End Sub
	Private Sub btnAmbilUlangSN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilUlangSN.ItemClick
		If txtDempyou.EditValue Is Nothing Then Return

		xGrid.DataSource = Nothing
		detailSource = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
		Dim sdhProses As List(Of Persistent.Fusoh_StokDetail)
		Dim dempyou = CType(txtDempyou.EditValue, Persistent.Fusoh_OrderProduksi)
		Dim lebarMataPisau As Double = 3
		If dempyou.NoCutting Then lebarMataPisau = 0
		'Dim dempyouCutting = dempyou.Cutting + lebarMataPisau '3
		Dim dempyouCutting = dempyou.Cutting '3
		Dim rmDibutuhkan = dempyouCutting * txtCuttingQty.Value
		If Tipe = InputType.Tambah Then
			sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is dempyou).ToList
		Else
			instance = session.GetObjectByKey(Of Persistent.Fusoh_StokMain)(Convert.ToInt64(IdToEdit))
			sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is dempyou AndAlso Not w.Main Is instance And w.QtyOut > 0).ToList
		End If
		'MsgBox("Total SN : " & dempyou.BahanBaku.Count & "-->" & sdhProses.Count & "Cutting : " & dempyouCutting)
		Dim xJali As String = ""
		For Each det In dempyou.BahanBaku
			Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
			item.Barang = det.Barang
			item.Catatan = det.Catatan
			item.Id = det.Id
			item.Millsheet = det.Millsheet
			item.Serial = det.Serial

			Dim xSerial = sdhProses.FindAll(Function(m) m.Barang Is item.Barang).SelectMany(Function(m) m.Serial).ToList.FindAll(Function(f) f.Serial = item.Serial)
			item.SNLength = CDec(det.SNLength - xSerial.Sum(Function(s) s.LengthOut))
			item.SNQty = xSerial.Sum(Function(s) s.Qty)
			Dim sisaLength = CDec(det.Length - xSerial.Sum(Function(s) s.LengthOut))

			Dim jumlahPotong = CInt(sisaLength / dempyouCutting)
			xJali = xJali & vbCrLf & "SN :" & det.Serial & "-->" & item.SNLength & "~" & jumlahPotong
			item.Length = jumlahPotong * dempyouCutting
			If rmDibutuhkan >= item.Length Then
				If item.Length > sisaLength Then
					item.Length -= dempyouCutting
				End If
				rmDibutuhkan -= item.Length
			Else
				item.Length = rmDibutuhkan
				rmDibutuhkan = 0
			End If

			item.Qty = CInt(IIf(item.SNLength = item.Length, 1, 0))
			item.Scrap = det.Scrap
			If (item.Length > 0) Then detailSource.Add(item)
			If rmDibutuhkan <= 0 Then
				Exit For
			End If
		Next
		xGrid.DataSource = detailSource
		'MsgBox(xJali)
	End Sub
End Class