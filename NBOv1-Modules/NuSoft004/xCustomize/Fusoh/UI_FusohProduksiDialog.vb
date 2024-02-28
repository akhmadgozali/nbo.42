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

Friend Class UI_FusohProduksiDialog
  Private instance As Persistent.Fusoh_StokMain
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of SettingRegional)
  Private editAssign As Boolean = False
  Private defaultRegional As NPO.Modules.ModSys.Regional
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
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AMTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AMTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AMTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AMTransaksiGrid.xml"))
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
      Dim sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is instance.OrderProduksi AndAlso Not w.Main Is instance).ToList

      'txtDempyou.Properties.DataSource = New Persistent.Fusoh_OrderProduksi() {instance.OrderProduksi}
      Dim ds = Services.TransaksiProduksi.GetDempyouData(session, instance.Pelanggan, instance)
      txtDempyou.Properties.DataSource = ds
      txtKontak.EditValue = instance.Pelanggan
      txtDempyou.EditValue = ds(0) 'instance.OrderProduksi
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.StatusTransaksi

      GridControl1.DataSource = ds(0).DailyProcessList

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
        txtCutting.EditValue = instance.OrderProduksi.Cutting

        If instance.CuttingWIP Is Nothing Then
          txtQty.Value = CDec(instance.Detail.Sum(Function(s) s.QtyIn))
          txtQty.Properties.MaxValue = CDec(instance.OrderProduksi.Qty - sdhProses.Sum(Function(s) s.QtyIn))
          txtQty.Enabled = True
          txtRMDibutuhkan.EditValue = (instance.OrderProduksi.Cutting + 3) * txtQty.Value
        Else
          txtQty.Value = CDec(instance.TotalQtyIn)
          txtQty.Properties.MaxValue = CDec(instance.TotalQtyIn)
          txtQty.Enabled = False
          txtRMDibutuhkan.EditValue = 0
        End If

        txtNoLOT.Text = instance.DempyouLot
        txtNoDrawing.Text = instance.OrderProduksi.NomorDrawing
        txtDeliveryDate.Text = instance.OrderProduksi.DeliveryDate
        txtMaterialFlow.EditValue = instance.OrderProduksi.MaterialFlow

        txtLengthTolerance.Text = instance.OrderProduksi.LengthTolerance
        txtMaterialCorner.Text = instance.OrderProduksi.MaterialCorner
        txtColourCode.Text = instance.OrderProduksi.ColourCode
        txtRemark.Text = instance.OrderProduksi.Catatan
      End If

      'Dim xDtSerial As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, New BinaryOperator("", Equals))

      detailSource = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
      If instance.CuttingWIP Is Nothing Then
        Dim xJali As String = ""
        For Each det In instance.Detail
          If det.QtyIn = 0 Then
            'Dim serialNonScrap = det.Serial.Where(Function(w) Not w.Scrap).ToList
            'Dim serialScrap = det.Serial.Where(Function(w) w.Scrap).ToList

            For Each serial In det.Serial 'serialNonScrap
              Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
              item.Barang = det.Barang
              item.Catatan = det.Catatan
              item.Id = det.Id
              item.Millsheet = serial.MillSheet
              item.Serial = serial.Serial
              'MsgBox("DISINI OKE1")
              Dim xSerial = sdhProses.FindAll(Function(m) m.Barang Is item.Barang).SelectMany(Function(m) m.Serial).ToList.FindAll(Function(f) f.Serial = item.Serial)
              Dim xOrder = instance.OrderProduksi.BahanBaku.ToList.Find(Function(w) w.Barang Is item.Barang AndAlso w.Serial = item.Serial)
              'MsgBox("DISINI OKE2")
              'MsgBox("Jumlah data :" & xSerial.Count)
              'MsgBox("Barang : " & item.Barang.Kode & " / Serial :" & item.Serial)
              'jali : 4-jun-2020
              'If xSerial.Count > 0 Then
              item.SNLength = CDec(xOrder.Length - xSerial.Sum(Function(s) s.LengthOut))
              item.Length = CDec(serial.LengthOut)

              'xJali = xJali & vbCrLf & item.Serial & " " & xOrder.Length.ToString() & " - " & xSerial.Sum(Function(s) s.LengthOut).ToString & "=" & CDec(xOrder.SNLength - xSerial.Sum(Function(s) s.LengthOut)).ToString
              'Else
              '  item.SNLength = xOrder.SNLength
              '  item.Length = 0
              'End If
              'MsgBox("DISINI OKE") 

              'edited 08-02-2022 (jika sudah ada yang diseting 1, maka tetep jadikan 0
              Dim xdtSN As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("DetailMain.Barang", item.Barang, BinaryOperatorType.Equal), New BinaryOperator("Serial", item.Serial, BinaryOperatorType.Equal), New BinaryOperator("DetailMain.Id", item.Id, BinaryOperatorType.NotEqual), New BinaryOperator("Qty", 1, BinaryOperatorType.Equal)))
              xJali = xJali & vbCrLf & item.Serial & "~" & item.Id & "-->" & xdtSN.Count
              If xdtSN.Count = 0 Then
                item.Qty = CInt(IIf(item.SNLength = item.Length, 1, 0)) 'CInt(det.QtyOut) edited 10-03-19
              Else
                item.Qty = 0
              End If
              item.Scrap = serial.Scrap
              detailSource.Add(item)
            Next
            'MsgBox(xJali)
            'For Each serial In serialScrap
            '  Dim found = detailSource.Find(Function(f) f.Barang Is serial.DetailMain.Barang AndAlso f.Serial = serial.Serial)
            '  If (Not found Is Nothing) Then
            '    found.Scrap = True
            '  End If
            'Next
          End If
        Next
        'MsgBox("OKE COY")
        colCommand.OptionsColumn.AllowEdit = True
        colCommand.OptionsColumn.ReadOnly = False
        colMaterialLength.OptionsColumn.AllowEdit = True
        colMaterialLength.OptionsColumn.ReadOnly = False
        colScrap.OptionsColumn.AllowEdit = True
        colScrap.OptionsColumn.ReadOnly = False
      Else
        For Each det In instance.Detail.Where(Function(w) w.QtyIn = 0).ToList
          Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
          item.Id = det.Id
          item.Barang = det.Barang
          item.Catatan = det.Catatan
          item.Millsheet = String.Empty
          item.Serial = String.Empty
          item.SNLength = 0
          item.SNQty = 0
          item.Length = 0
          item.Scrap = False
          item.Qty = det.QtyOut
          detailSource.Add(item)
        Next

        colCommand.OptionsColumn.AllowEdit = False
        colCommand.OptionsColumn.ReadOnly = True
        colMaterialLength.OptionsColumn.AllowEdit = False
        colMaterialLength.OptionsColumn.ReadOnly = True
        colScrap.OptionsColumn.AllowEdit = False
        colScrap.OptionsColumn.ReadOnly = True
      End If
      xGrid.DataSource = detailSource
      txtDempyou.Properties.ReadOnly = True
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Produksi : Tambah"
    Else
      Me.Text = "Produksi : Edit " & instance.Kode
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
    'If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
    '  Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
    '  Exit Sub
    'End If

    Try
      '======= cek stok
      Dim errorStok As String = ""
      For i = 0 To detailSource.Count - 1
        Dim bahan = detailSource(i)
        Dim stokSaatIni = New XPQuery(Of Persistent.Fusoh_StokSerial)(session) _
          .Where(Function(n) n.DetailMain.Barang Is bahan.Barang AndAlso n.Serial = bahan.Serial AndAlso Not n.DetailMain.Main Is instance) _
          .Sum(Function(s) s.LengthIn - s.LengthOut)

        If bahan.Length > stokSaatIni Then
          errorStok &= vbCrLf & String.Format("{0}-{1} ({2}) ==> {3}, tersedia {4}", bahan.Barang.Kode, bahan.Barang.Nama, bahan.Serial, bahan.Length, stokSaatIni)
        End If
      Next
      If errorStok <> "" Then
        Throw New Utils.Exception("Ada beberapa bahan yang kekurangan stok :" & errorStok, -99)
      End If
      'If instance.TotalLength = 0 Then
      '  Throw New Utils.Exception("Total Lenght yg digunakan 0", -99)
      'End If

      If txtDempyou.EditValue Is Nothing Then
        Throw New Utils.Exception("Masukkan data dempyou", -5)
      End If
      Dim dempyouValue = CType(txtDempyou.EditValue, NonPersistent.Fusoh_DempyouInProduksi)

      '======= Simpan Main
      instance.Pelanggan = If(txtKontak.EditValue Is Nothing, Nothing, CType(txtKontak.EditValue, Kontak))
      instance.OrderProduksi = dempyouValue.Dempyou ' If(txtDempyou.EditValue Is Nothing, Nothing, CType(txtDempyou.EditValue, Persistent.Fusoh_OrderProduksi))
      instance.CuttingWIP = dempyouValue.CuttingWIP
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = If(txtRegional.EditValue Is Nothing, Nothing, CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional))
      instance.Kode = txtNoTransaksi.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)
      instance.Gudang = instance.OrderProduksi.Gudang
      instance.SO = instance.OrderProduksi.SODetail.Main
      instance.Kurs = 1
      instance.DempyouLot = txtNoLOT.Text

      '======= Bahan jadi
      Dim bahanJadi = instance.Detail.ToList.Find(Function(f) f.QtyIn <> 0)
      If bahanJadi Is Nothing Then
        bahanJadi = New Persistent.Fusoh_StokDetail(session)
        bahanJadi.Main = instance
        instance.Detail.Add(bahanJadi)
      End If
      bahanJadi.Barang = instance.OrderProduksi.SODetail.Barang
      bahanJadi.Gudang = instance.OrderProduksi.Gudang
      bahanJadi.QtyIn = txtQty.Value
      bahanJadi.QtyOut = 0
      bahanJadi.OutDiameter = instance.OrderProduksi.SODetail.OutDiameter
      bahanJadi.InDiameter = instance.OrderProduksi.SODetail.InDiameter
      bahanJadi.Thickness = instance.OrderProduksi.SODetail.Thickness
      bahanJadi.Length = instance.OrderProduksi.SODetail.Length
      bahanJadi.Weight = instance.OrderProduksi.Weight
      bahanJadi.Satuan = instance.OrderProduksi.SODetail.Barang.SatuanD
      bahanJadi.SODetail = instance.OrderProduksi.SODetail

      '====== Bahan Baku
      Dim bahanBaku = instance.Detail.Where(Function(f) f.QtyIn = 0)
      Dim item = detailSource.GroupBy(Function(g) g.Barang).Select(Function(s) s.Key).ToList
      For i = bahanBaku.Count - 1 To 0 Step -1
        Dim baku = bahanBaku(i)
        Dim found = item.Find(Function(f) f Is baku.Barang)
        If found Is Nothing Then
          baku.Delete()
          instance.Detail.Remove(baku)
        End If
      Next

      'For i = 0 To detailSource.Count - 1
      '  Dim bahan = detailSource(i)
      '  Dim found = instance.Detail.ToList.Find(Function(f) f.Barang Is bahan.Barang)
      '  If found Is Nothing Then
      '    found = New Persistent.Fusoh_StokDetail(session)
      '    found.Main = instance
      '    found.Barang = bahan.Barang
      '    found.Gudang = instance.OrderProduksi.Gudang
      '    found.QtyIn = 0
      '    found.QtyOut = detailSource.Where(Function(w) w.Barang Is bahan.Barang).Sum(Function(s) s.Qty)
      '    found.OutDiameter = found.Barang.OutDiameter
      '    found.InDiameter = found.Barang.InDiameter
      '    found.Thickness = found.Barang.Thickness
      '    found.Length = found.Barang.Length
      '    found.Weight = FusohLogic.Item.GetWeight(found.OutDiameter, found.Length, found.Thickness)
      '    'MsgBox(found.OutDiameter & "/" & found.Length & "/" & found.Thickness & "-->" & found.Weight)
      '    found.Satuan = bahan.Barang.SatuanD
      '    found.SODetail = instance.OrderProduksi.SODetail
      '    instance.Detail.Add(found)
      '  Else
      '    found.OutDiameter = found.Barang.OutDiameter
      '    found.InDiameter = found.Barang.InDiameter
      '    found.Thickness = found.Barang.Thickness
      '    found.Length = found.Barang.Length
      '    found.Weight = FusohLogic.Item.GetWeight(found.OutDiameter, found.Length, found.Thickness)
      '    'MsgBox(found.OutDiameter & "/" & found.Length & "/" & found.Thickness & "-->" & found.Weight)
      '    found.QtyOut = detailSource.Where(Function(w) w.Barang Is bahan.Barang).Sum(Function(s) s.Qty)
      '  End If

      '  '===== serial
      '  Dim serial = found.Serial.ToList.Find(Function(f) f.Serial Is bahan.Serial)
      '  If serial Is Nothing Then
      '    serial = New Persistent.Fusoh_StokSerial(session)
      '    serial.DetailMain = found
      '    serial.Serial = bahan.Serial
      '    found.Serial.Add(serial)
      '  End If
      '  serial.MillSheet = bahan.Millsheet
      '  serial.LengthIn = 0
      '  serial.LengthOut = bahan.Length
      '  serial.Qty = bahan.Qty
      'Next

      '======= edited 11-09-21 //=> masukkan fitur scrap ======
      For i = 0 To detailSource.Count - 1
        Dim bahan = detailSource(i)
        Dim found = instance.Detail.ToList.Find(Function(f) f.Barang Is bahan.Barang)
        If found Is Nothing Then
          found = New Persistent.Fusoh_StokDetail(session)
          found.Main = instance
          found.Barang = bahan.Barang
          found.Gudang = instance.OrderProduksi.Gudang
          found.QtyIn = 0
          found.Satuan = bahan.Barang.SatuanD
          found.SODetail = instance.OrderProduksi.SODetail
          instance.Detail.Add(found)
        End If
        found.OutDiameter = found.Barang.OutDiameter
        found.InDiameter = found.Barang.InDiameter
        found.Thickness = found.Barang.Thickness
        found.Length = found.Barang.Length
        found.Weight = FusohLogic.Item.GetWeight(found.OutDiameter, found.Length, found.Thickness)
        'MsgBox(found.OutDiameter & "/" & found.Length & "/" & found.Thickness & "-->" & found.Weight)
        'found.QtyOut = detailSource.Where(Function(w) w.Barang Is bahan.Barang).Sum(Function(s) If(s.Scrap, 1, s.Qty))
        found.QtyOut = detailSource.Where(Function(w) w.Barang Is bahan.Barang).Sum(Function(s) s.Qty)

        '===== serial non scrap
        If bahan.Serial <> String.Empty Then
          Dim serialNonScrap = found.Serial.ToList.Find(Function(f) f.Serial = bahan.Serial) ' AndAlso Not f.Scrap)
          If serialNonScrap Is Nothing Then
            serialNonScrap = New Persistent.Fusoh_StokSerial(session)
            serialNonScrap.DetailMain = found
            serialNonScrap.Serial = bahan.Serial
            found.Serial.Add(serialNonScrap)
          End If
          serialNonScrap.Scrap = bahan.Scrap
          serialNonScrap.MillSheet = bahan.Millsheet
          serialNonScrap.LengthIn = 0
          serialNonScrap.LengthOut = bahan.Length
          serialNonScrap.Qty = bahan.Qty
        End If

        ''===== serial scrap
        'Dim serialScrap = found.Serial.ToList.Find(Function(f) f.Serial = bahan.Serial AndAlso f.Scrap)
        'If bahan.Scrap Then
        '  If bahan.SNLength - bahan.Length > 0 Then
        '    '===== create serial scrap
        '    If serialScrap Is Nothing Then
        '      serialScrap = New Persistent.Fusoh_StokSerial(session)
        '      serialScrap.DetailMain = found
        '      serialScrap.Serial = bahan.Serial
        '      serialScrap.Scrap = True
        '      found.Serial.Add(serialScrap)
        '    End If
        '    serialScrap.MillSheet = bahan.Millsheet
        '    serialScrap.LengthIn = 0
        '    serialScrap.LengthOut = bahan.SNLength - bahan.Length
        '    serialScrap.Qty = 1
        '  Else
        '    '===== delete serial scrap if exist
        '    If Not serialScrap Is Nothing Then serialScrap.Delete()
        '  End If
        'Else
        '  '===== delete serial scrap if exist
        '  If Not serialScrap Is Nothing Then serialScrap.Delete()
        'End If
      Next

      '======= update hpp
      FusohLogic.HPP.HitungHPPDariProduksi(instance, False)

			''======= update status dempyou or cutting wip
			'If dempyouValue.CuttingWIP Is Nothing Then
			'  If Not instance.OrderProduksi Is Nothing Then
			'    Dim xQtyDempyou As Double = instance.OrderProduksi.Qty
			'    Dim xQtyProduksi As Double = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is instance.OrderProduksi).Sum(Function(s) s.QtyIn) + txtQty.Value
			'    If xQtyProduksi < xQtyDempyou Then
			'      instance.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.InProgress
			'    Else
			'      instance.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.Finish
			'    End If
			'  End If
			'Else
			'  If Not instance.CuttingWIP Is Nothing Then
			'    Dim xQtyCutting As Double = instance.CuttingWIP.TotalQtyIn
			'    Dim xQtyProduksi As Double = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.CuttingWIP Is instance.CuttingWIP).Sum(Function(s) s.QtyIn) + txtQty.Value
			'    If xQtyProduksi < xQtyCutting Then
			'      instance.CuttingWIP.StatusTransaksi = StatusTransaksiEnum.InProgress
			'    Else
			'      instance.CuttingWIP.StatusTransaksi = StatusTransaksiEnum.Finish
			'    End If
			'  End If
			'End If
			Services.Fusoh_UpdateStatus.UpdateStatusDempyouDariProduksi(session, instance, txtQty.Value)

			'====== set kolom produksi di daily process
			If Not dempyouValue.DailyProcessList Is Nothing Then
				For Each x In dempyouValue.DailyProcessList
					x.Produksi = instance
				Next
			End If

			instance.Save()
      '======= Simpan instance
      session.CommitChanges()
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

    '======= Simple log
    Try
      If Tipe = InputType.Tambah Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Produksi -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Produksi -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try

    'Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.OP)
    'frm.txtNoBukti1.EditValue = instance.Kode

    'Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    'Dim reportCode As String = ""
    'reportCode = MainClass.GetReport(MainClass.reportName.zFusohDempyou)
    'message = String.Format(message, "Order Produksi [Dempyou]")
    'Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True) ' salesSetting.PreviewSave)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
			Case 0 : txtNoTransaksi.Focus()
			Case -1 : txtRegional.Focus()
      Case -2 : txtTanggal.Focus()
      Case -3 : txtKontak.Focus()
      Case -4
      Case -5 : txtDempyou.Focus()
      Case -6 : txtStatus.Focus()
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
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    txtKontak.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderPenjualan)(session).GroupBy(Function(g) g.Pelanggan).Select(Function(s) s.Key).ToList

    Dim ccc = New XPQuery(Of Persistent.Fusoh_StokMain)(session).Where(Function(w) Not String.IsNullOrEmpty(w.DempyouLot)).GroupBy(Function(g) g.DempyouLot).Select(Function(s) s.Key).ToArray
    If ccc.Count > 0 Then
      Dim collection As New AutoCompleteStringCollection()
      collection.AddRange(ccc)
      txtNoLOT.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
      txtNoLOT.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
      txtNoLOT.MaskBox.AutoCompleteCustomSource = collection
    End If
  End Sub
  Private Sub SetFormat()
    'colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQty.DisplayFormat.FormatString = setting.NumericFormatString
    'colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colLengthSN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colLengthSN.DisplayFormat.FormatString = setting.NumericFormatString
    'colLengthSN.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colSN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colSN.DisplayFormat.FormatString = setting.NumericFormatString
    'colSN.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colMillSheet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colMillSheet.DisplayFormat.FormatString = setting.NumericFormatString
    'colMillSheet.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colPajakIn.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colPajakOut.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    'colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

    'txtPartNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    'txtPartNo.Properties.Mask.EditMask = setting.NumericFormatToString
    'txtSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    'txtSize.Properties.Mask.EditMask = setting.NumericFormatToString
    'txtLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    'txtLength.Properties.Mask.EditMask = setting.NumericFormatToString
    'txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    'txtQty.Properties.Mask.EditMask = setting.NumericFormatToString
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

    txtStatus.EditValue = StatusTransaksiEnum.Posting
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.AM)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtDempyou.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtQty.Properties.ReadOnly = True
    txtNoLOT.Properties.ReadOnly = True
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

  Private Sub DempyouOrQtyChanged(dempyouValue As NonPersistent.Fusoh_DempyouInProduksi, justProcesDetail As Boolean, QtyBahanJadi As Decimal)
    If Not justProcesDetail Then
      txtNoPO.Text = dempyouValue.Dempyou.SODetail.Main.NomorPO
      txtPOLine.Text = dempyouValue.Dempyou.SODetail.POLine.ToString
      txtGudang.Text = dempyouValue.Dempyou.Gudang.Kode
      txtPartNo.Text = dempyouValue.Dempyou.SODetail.Barang.Kode
      txtMaterial.Text = dempyouValue.Dempyou.SODetail.Barang.Nama
      txtSize.Text = dempyouValue.Dempyou.SODetail.OutDiameter.ToString("n0") & " x " & dempyouValue.Dempyou.SODetail.Thickness.ToString("n0")
      txtLength.Text = dempyouValue.Dempyou.SODetail.Length.ToString("n0")

      txtNoLOT.Text = dempyouValue.Dempyou.NomorLot
      txtNoDrawing.Text = dempyouValue.Dempyou.NomorDrawing
      txtDeliveryDate.Text = dempyouValue.Dempyou.DeliveryDate
      txtMaterialFlow.EditValue = dempyouValue.Dempyou.MaterialFlow

      txtLengthTolerance.Text = dempyouValue.Dempyou.LengthTolerance
      txtMaterialCorner.Text = dempyouValue.Dempyou.MaterialCorner
      txtColourCode.Text = dempyouValue.Dempyou.ColourCode
      txtRemark.Text = dempyouValue.Dempyou.Catatan
    End If

    xGrid.DataSource = Nothing
    detailSource = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
    'MsgBox("OKE COY")
    If dempyouValue.CuttingWIP Is Nothing Then 'dempyou lama
      'MsgBox("Sudah ada cutting WIP sebelumnya")
      Dim dempyouLamaProduksi As List(Of Persistent.Fusoh_StokDetail)
      If Tipe = InputType.Tambah Then
        dempyouLamaProduksi = New XPQuery(Of Persistent.Fusoh_StokDetail)(session) _
          .Where(Function(w) w.Main.OrderProduksi Is dempyouValue.Dempyou AndAlso w.Main.CuttingWIP Is Nothing).ToList
      Else
        'instance = session.GetObjectByKey(Of Persistent.Fusoh_StokMain)(Convert.ToInt64(IdToEdit))
        'sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is dempyou AndAlso Not w.Main Is instance).ToList
        dempyouLamaProduksi = New XPQuery(Of Persistent.Fusoh_StokDetail)(session) _
          .Where(Function(w) w.Main.OrderProduksi Is dempyouValue.Dempyou AndAlso w.Main.CuttingWIP Is Nothing AndAlso Not w.Main Is instance).ToList
      End If

			If Not justProcesDetail Then QtyBahanJadi = CDec(dempyouValue.Dempyou.Qty - dempyouLamaProduksi.Sum(Function(s) s.QtyIn))
			Dim lebarMataPisau As Double = 3
      If dempyouValue.Dempyou.NoCutting Then lebarMataPisau = 0

      Dim dempyouCutting As Double = dempyouValue.Dempyou.Cutting + lebarMataPisau

      Dim rmDibutuhkan = dempyouCutting * QtyBahanJadi

      txtRMDibutuhkan.EditValue = rmDibutuhkan '(x.Cutting + 3) * sisa
      If Not justProcesDetail Then
        editAssign = True
        txtQty.Value = QtyBahanJadi
        txtQty.Properties.MaxValue = QtyBahanJadi
        txtCutting.EditValue = dempyouValue.Dempyou.Cutting
        txtQty.Enabled = True
        editAssign = False
      End If

      For Each det In dempyouValue.Dempyou.BahanBaku
        Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
        item.Barang = det.Barang
        item.Catatan = det.Catatan
        item.Id = det.Id
        item.Millsheet = det.Millsheet
        item.Serial = det.Serial
        Dim xSerial = dempyouLamaProduksi.FindAll(Function(m) m.Barang Is item.Barang).SelectMany(Function(m) m.Serial).ToList.FindAll(Function(f) f.Serial = item.Serial)
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
      colCommand.OptionsColumn.AllowEdit = True
      colCommand.OptionsColumn.ReadOnly = False
      colMaterialLength.OptionsColumn.AllowEdit = True
      colMaterialLength.OptionsColumn.ReadOnly = False
      colScrap.OptionsColumn.AllowEdit = True
      colScrap.OptionsColumn.ReadOnly = False

    Else ' Cutting WIP
      'MsgBox("Disini codenya")
      txtRMDibutuhkan.EditValue = 0
      If Not justProcesDetail Then
        editAssign = True
				QtyBahanJadi = CDec(dempyouValue.QtyDailyProcess) 'CDec(dempyouValue.CuttingWIP.TotalQtyIn)
				txtQty.Value = QtyBahanJadi
        txtQty.Properties.MaxValue = QtyBahanJadi
        txtCutting.EditValue = dempyouValue.Dempyou.Cutting
        txtQty.Enabled = False
        editAssign = False
      End If

			' Masukkan barang wip di detail
			Dim bahanWIP = dempyouValue.CuttingWIP.Detail.Where(Function(w) w.QtyIn <> 0).ToList
			Dim jmlDetail = bahanWIP.Count
			For Each det In bahanWIP.ToList
				Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
				item.Id = det.Id
				item.Barang = det.Barang
				item.Catatan = det.Catatan
				item.Millsheet = String.Empty
				item.Serial = String.Empty
				item.SNLength = 0
				item.SNQty = 0
				item.Length = 0
				item.Scrap = False
				item.Qty = QtyBahanJadi / jmlDetail 'det.QtyIn
				detailSource.Add(item)
			Next

			colCommand.OptionsColumn.AllowEdit = False
      colCommand.OptionsColumn.ReadOnly = True
      colMaterialLength.OptionsColumn.AllowEdit = False
      colMaterialLength.OptionsColumn.ReadOnly = True
      colScrap.OptionsColumn.AllowEdit = False
      colScrap.OptionsColumn.ReadOnly = True
    End If
    xGrid.DataSource = detailSource
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
        'If Tipe = InputType.Tambah Then
        '  'Dim sdhProses = New XPQuery(Of Persistent.Fusoh_StokMain)(session).Where(Function(f) Not f.OrderProduksi Is Nothing).GroupBy(Function(d) d.OrderProduksi).Select(Function(s) s.Key)
        '  'txtDempyou.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(m) m.Pelanggan Is e.NewValue AndAlso Not sdhProses.Contains(m))
        '  txtDempyou.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(m) m.Pelanggan Is e.NewValue AndAlso (m.StatusTransaksi = StatusTransaksiEnum.InProgress OrElse m.StatusTransaksi = StatusTransaksiEnum.Posting)).ToList
        'Else
        '  Dim dd As New List(Of Persistent.Fusoh_OrderProduksi)
        '  dd.Add(instance.OrderProduksi)
        '  txtDempyou.Properties.DataSource = dd
        'End
        txtDempyou.Properties.DataSource = Services.TransaksiProduksi.GetDempyouData(session, CType(e.NewValue, Kontak), If(Tipe = InputType.Tambah, Nothing, instance))
      End If
    End If
  End Sub
  Private Sub txtDempyou_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtDempyou.EditValueChanging
    If Not editAssign Then
      If Not e.NewValue Is Nothing Then
        Dim x = CType(e.NewValue, NonPersistent.Fusoh_DempyouInProduksi)
        DempyouOrQtyChanged(x, False, CDec(x.Dempyou.Qty))
        GridControl1.DataSource = CType(e.NewValue, NonPersistent.Fusoh_DempyouInProduksi).DailyProcessList
      End If
    End If
  End Sub
  'Private Sub txtQty_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtQty.EditValueChanging
  '  If Not e.NewValue Is Nothing Then
  '    txtRMDibutuhkan.EditValue = (CDbl(txtCutting.EditValue) + 3) * CDbl(e.NewValue)
  '  Else
  '    txtRMDibutuhkan.EditValue = 0
  '  End If
  'End Sub
  Private Sub txtQty_EditValueChanged(sender As Object, e As EventArgs) Handles txtQty.EditValueChanged
    If editAssign Then Return
    If txtDempyou.EditValue Is Nothing Then Return

    DempyouOrQtyChanged(CType(txtDempyou.EditValue, NonPersistent.Fusoh_DempyouInProduksi), True, txtQty.Value)

    'xGrid.DataSource = Nothing
    'detailSource = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
    'Dim sdhProses As List(Of Persistent.Fusoh_StokDetail)
    'Dim dempyou = CType(txtDempyou.EditValue, Persistent.Fusoh_OrderProduksi)
    'Dim dempyouCutting = dempyou.Cutting + 3
    'Dim rmDibutuhkan = dempyouCutting * txtQty.Value
    'If Tipe = InputType.Tambah Then
    '  sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is dempyou).ToList
    'Else
    '  instance = session.GetObjectByKey(Of Persistent.Fusoh_StokMain)(Convert.ToInt64(IdToEdit))
    '  sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is dempyou AndAlso Not w.Main Is instance).ToList
    'End If

    'For Each det In dempyou.BahanBaku
    '  Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
    '  item.Barang = det.Barang
    '  item.Catatan = det.Catatan
    '  item.Id = det.Id
    '  item.Millsheet = det.Millsheet
    '  item.Serial = det.Serial
    '  Dim xSerial = sdhProses.FindAll(Function(m) m.Barang Is item.Barang).SelectMany(Function(m) m.Serial).ToList.FindAll(Function(f) f.Serial = item.Serial)
    '  item.SNLength = CDec(det.SNLength - xSerial.Sum(Function(s) s.LengthOut))
    '  item.SNQty = xSerial.Sum(Function(s) s.Qty)
    '  Dim sisaLength = CDec(det.Length - xSerial.Sum(Function(s) s.LengthOut))

    '  Dim jumlahPotong = CInt(sisaLength / dempyouCutting)
    '  item.Length = jumlahPotong * dempyouCutting
    '  If rmDibutuhkan >= item.Length Then
    '    If item.Length > sisaLength Then
    '      item.Length -= dempyouCutting
    '    End If
    '    rmDibutuhkan -= item.Length
    '  Else
    '    item.Length = rmDibutuhkan
    '    rmDibutuhkan = 0
    '  End If

    '  item.Qty = CInt(IIf(item.SNLength = item.Length, 1, 0))
    '  item.Scrap = det.Scrap
    '  If (item.Length > 0) Then detailSource.Add(item)
    '  If rmDibutuhkan <= 0 Then
    '    Exit For
    '  End If
    'Next
    'xGrid.DataSource = detailSource
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
  Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  'Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
  '	'MyBase.OnKeyDown(e)
  '	If e.Control AndAlso e.Shift Then
  '		xGrid.Focus()
  '	End If
  'End Sub
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub

  Private Sub xGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles xGridView.KeyDown
    'If e.KeyCode = Windows.Forms.Keys.Delete Then
    '  Dim Id As Persistent.SanYu_OrderPembelianDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SanYu_OrderPembelianDetail)
    '  xGridView.DeleteRow(xGridView.FocusedRowHandle)
    '  detailToDelete.Add(Id)
    'End If
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

  Private Sub colCommandRepo_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles colCommandRepo.ButtonPressed
    Dim row = CType(xGridView.GetFocusedRow, NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
    If e.Button.Kind = ButtonPredefines.Minus Then
      detailSource.Remove(row)
      xGrid.RefreshDataSource()
    End If
  End Sub
  Private Sub xGridView_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles xGridView.InvalidRowException
    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
  End Sub
  Private Sub xGridView_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles xGridView.CustomDrawRowIndicator
    If e.RowHandle >= 0 Then
      e.Info.DisplayText = (e.RowHandle + 1).ToString
    End If
  End Sub
End Class