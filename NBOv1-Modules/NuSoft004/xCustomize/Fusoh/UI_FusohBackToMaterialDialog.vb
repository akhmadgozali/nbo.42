Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Friend Class UI_FusohBackToMaterialDialog
  Private instance As Persistent.Fusoh_StockAdjustment
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of SettingRegional)
  Private editAssign As Boolean = False
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private _bbSerial As List(Of Fusoh_StockDetailSerial_Temp)

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    AllowSave = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BMTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BMTransaksi.xml"))
    End If
  End Sub
  Private Sub BindingDataSource()
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(StatusTransaksiEnum))
    txtGudang.Properties.DataSource = New XPQuery(Of Persistent.Gudang)(session).ToList

    txtItemBJ.Properties.DataSource = New XPQuery(Of Fusoh_Barang)(session).Where(Function(m) m.Aktif AndAlso m.TipeBarang = TipeBarang.BahanJadi).ToList
    txtItemBB.Properties.DataSource = New XPQuery(Of Fusoh_Barang)(session).Where(Function(m) m.Aktif AndAlso m.TipeBarang = TipeBarang.BahanBaku).ToList
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    editAssign = True
    _bbSerial = New List(Of Fusoh_StockDetailSerial_Temp)
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Fusoh_StockAdjustment(session)
      LoadDefault()
      ChangeCode()
      txtGudang.Focus()
    Else
      instance = session.GetObjectByKey(Of Persistent.Fusoh_StockAdjustment)(Convert.ToInt64(IdToEdit))

      txtGudang.EditValue = instance.Gudang
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.StatusTransaksi
      txtUraian.Text = instance.Uraian

      '=== BAHAN JADI
      Dim itemBahanJadi = instance.Detail.ToList.Find(Function(f) f.QtyOut > 0)
      txtItemBJ.EditValue = itemBahanJadi.Barang
      txtQtyBJ.Value = CDec(itemBahanJadi.QtyOut)
      txtStockBJ.EditValue = CDec(txtStockBJ.EditValue) + txtQtyBJ.Value
      txtLengthBJ.Value = itemBahanJadi.Length
      txtIDBJ.EditValue = itemBahanJadi.InDiameter
      txtODBJ.EditValue = itemBahanJadi.OutDiameter
      txtThicknesBJ.EditValue = itemBahanJadi.Thickness
      txtTotalWeightBJ.EditValue = itemBahanJadi.Weight
      txtRemarksBJ.Text = itemBahanJadi.Catatan
      txtKodeProduksi.EditValue = itemBahanJadi.ProduksiDetail

      '=== BAHAN BAKU
      Dim itemBahanBaku = instance.Detail.ToList.Find(Function(f) f.QtyIN > 0)
      txtItemBB.EditValue = itemBahanBaku.Barang
      txtQtyBB.Value = CDec(itemBahanBaku.QtyIN)
      txtLengthBB.Value = itemBahanBaku.Length
      txtIDBB.EditValue = itemBahanBaku.InDiameter
      txtODBB.EditValue = itemBahanBaku.OutDiameter
      txtThicknesBB.EditValue = itemBahanBaku.Thickness
      txtTotalWeightBB.EditValue = itemBahanBaku.Weight
      txtRemarksBB.Text = itemBahanBaku.Catatan

      '======== set serial dari temp
      _bbSerial = New List(Of Fusoh_StockDetailSerial_Temp)
      For j = itemBahanBaku.Serial.Count - 1 To 0 Step -1
        Dim x = itemBahanBaku.Serial(j)
        Dim find = _bbSerial.Find(Function(m) m.Id = x.Id)
        If find Is Nothing Then
          find = New Fusoh_StockDetailSerial_Temp
          find.Id = x.Id
          find.DetailMain = x.DetailMain
          find.LengthIn = x.LengthIn
          find.Serial = x.Serial
          find.MillSheet = x.MillSheet
          _bbSerial.Add(find)
        End If
      Next
    End If
    editAssign = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      Me.Text = "Back To Material : Tambah"
    Else
      Me.Text = "Back To Material : Edit " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl()
      End If
      If Periode.CheckLockedPeriod(session, instance.Tanggal) Then
        DisableControl()
      End If
      If User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
        DisableControl()
      End If
    End If
    txtQtyBJ.Properties.Mask.EditMask = setting.NumericFormatToString
    txtLengthBJ.Properties.Mask.EditMask = setting.NumericFormatToString
    txtODBJ.Properties.Mask.EditMask = setting.NumericFormatToString
    txtIDBJ.Properties.Mask.EditMask = setting.NumericFormatToString
    txtThicknesBJ.Properties.Mask.EditMask = setting.NumericFormatToString
    txtTotalWeightBJ.Properties.Mask.EditMask = setting.NumericFormatToString
    txtStockBJ.Properties.Mask.EditMask = setting.NumericFormatToString

    txtQtyBB.Properties.Mask.EditMask = setting.NumericFormatToString
    txtLengthBB.Properties.Mask.EditMask = setting.NumericFormatToString
    txtODBB.Properties.Mask.EditMask = setting.NumericFormatToString
    txtIDBB.Properties.Mask.EditMask = setting.NumericFormatToString
    txtThicknesBB.Properties.Mask.EditMask = setting.NumericFormatToString
    txtTotalWeightBB.Properties.Mask.EditMask = setting.NumericFormatToString
  End Sub
  Overrides Sub SimpanData()
    If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
      Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    '====== Cek DATA BAHAN JADI
    If txtItemBJ.EditValue Is Nothing Then Throw New Utils.Exception("Pilih bahan jadi", -5)
    If txtQtyBJ.Value <= 0 Then Throw New Utils.Exception("Qty bahan jadi tidak boleh kosong", -6)
    If txtQtyBJ.Value > CDec(txtStockBJ.EditValue) Then Throw New Utils.Exception("Qty bahan jadi tidak boleh lebih dari sisa stok", -6)
    If txtKodeProduksi.EditValue Is Nothing Then Throw New Utils.Exception("Pilih nomor lot", -7)
    'If CType(txtKodeProduksi.EditValue, Fusoh_StokDetail).QtyIn > txtQtyBB.Value Then Throw New Utils.Exception("Sisa Qty produksi tidak mencukupi", -8)

    'QtySisa vwProduksi
    Dim xJali As FusohVwProduksi = New XPCollection(Of FusohVwProduksi)(session, New BinaryOperator("Id", CType(txtKodeProduksi.EditValue, Fusoh_StokDetail).Id, BinaryOperatorType.Equal)).FirstOrDefault
    If xJali.QtySisa < txtQtyBJ.Value Then Throw New Utils.Exception("Sisa Qty produksi tidak mencukupi", -6)

    '====== Cek DATA BAHAN BAKU
    If txtItemBB.EditValue Is Nothing Then Throw New Utils.Exception("Pilih bahan baku", -8)
    If txtQtyBB.Value <= 0 Then Throw New Utils.Exception("Qty bahan baku tidak boleh kosong", -9)
    If txtQtyBB.Value <> _bbSerial.Count Then Throw New Utils.Exception("Jumlah serial tidak sama dengan Qty bahan baku", -9)
    For j = 0 To _bbSerial.Count - 1
      If _bbSerial(j).Serial = "" Then
        Throw New Utils.Exception("Nama serial tidak boleh kosong", -99)
      End If
      If _bbSerial(j).MillSheet = "" Then
        Throw New Utils.Exception("Nama millsheet tidak boleh kosong", -99)
      End If
    Next


    'For i = detailToDelete.Count - 1 To 0 Step -1
    '	detailToDelete(i).Delete()
    'Next

    ''===  cek data
    'If dsJadi.Count < 1 Then
    '	Throw New Utils.Exception("Bahan jadi tidak boleh kosong", -98)
    'End If
    'If dsBaku.Count < 1 Then
    '	Throw New Utils.Exception("Bahan baku tidak boleh kosong", -99)
    'End If
    'For i = 0 To dsJadi.Count - 1
    '	If dsJadi(i).QtyOut = 0 Then
    '		Throw New Utils.Exception("Qty tidak boleh kosong untuk part no. " & dsJadi(i).Barang.Kode, -98)
    '	End If
    'Next
    'For i = 0 To dsBaku.Count - 1
    '	If dsBaku(i).QtyIN = 0 Then
    '		Throw New Utils.Exception("Qty tidak boleh kosong untuk part no. " & dsBaku(i).Barang.Kode, -99)
    '	End If

    '	For j = 0 To dsBaku(i).SerialTemp.Count - 1
    '		If dsBaku(i).SerialTemp(j).Serial = "" Then
    '			Throw New Utils.Exception("Nama serial tidak boleh kosong untuk part no. " & dsBaku(i).Barang.Kode, -99)
    '		End If
    '		If dsBaku(i).SerialTemp(j).MillSheet = "" Then
    '			Throw New Utils.Exception("Nama millsheet tidak boleh kosong untuk part no. " & dsBaku(i).Barang.Kode, -99)
    '		End If
    '	Next
    'Next

    Try
      '======= Simpan Main
      instance.Gudang = If(txtGudang.EditValue Is Nothing, Nothing, CType(txtGudang.EditValue, Gudang))
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = If(txtRegional.EditValue Is Nothing, Nothing, CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional))
      instance.Kode = txtNoTransaksi.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)
      instance.Uraian = txtUraian.Text

      '====== SIMPAN BAHAN JADI
      Dim itemBahanJadi = instance.Detail.ToList.Find(Function(f) f.QtyOut > 0)
      If itemBahanJadi Is Nothing Then itemBahanJadi = New Fusoh_StockAdjustmentDetail(session)
      itemBahanJadi.Main = instance
      itemBahanJadi.Gudang = instance.Gudang
      itemBahanJadi.Barang = CType(txtItemBJ.EditValue, Fusoh_Barang)
      itemBahanJadi.Satuan = itemBahanJadi.Barang.Satuan
      itemBahanJadi.QtyIN = 0
      itemBahanJadi.QtyOut = txtQtyBJ.Value
      itemBahanJadi.Length = txtLengthBJ.Value
      itemBahanJadi.InDiameter = CDec(txtIDBJ.EditValue)
      itemBahanJadi.OutDiameter = CDec(txtODBJ.EditValue)
      itemBahanJadi.Thickness = CDec(txtThicknesBJ.EditValue)
      itemBahanJadi.Weight = CDec(txtTotalWeightBJ.EditValue)
      itemBahanJadi.Catatan = txtRemarksBJ.Text
      itemBahanJadi.ProduksiDetail = CType(txtKodeProduksi.EditValue, Fusoh_StokDetail)
      itemBahanJadi.Harga = itemBahanJadi.ProduksiDetail.Harga
      itemBahanJadi.TotalHPP = CDec(itemBahanJadi.QtyOut * itemBahanJadi.Harga)

      '====== SIMPAN BAHAN BAKU
      Dim itemBahanBaku = instance.Detail.ToList.Find(Function(f) f.QtyIN > 0)
      If itemBahanBaku Is Nothing Then itemBahanBaku = New Fusoh_StockAdjustmentDetail(session)
      itemBahanBaku.Main = instance
      itemBahanBaku.Gudang = instance.Gudang
      itemBahanBaku.Barang = CType(txtItemBB.EditValue, Fusoh_Barang)
      itemBahanBaku.Satuan = itemBahanBaku.Barang.Satuan
      itemBahanBaku.QtyIN = txtQtyBB.Value
      itemBahanBaku.QtyOut = 0
      itemBahanBaku.Length = txtLengthBB.Value
      itemBahanBaku.InDiameter = CDec(txtIDBB.EditValue)
      itemBahanBaku.OutDiameter = CDec(txtODBB.EditValue)
      itemBahanBaku.Thickness = CDec(txtThicknesBB.EditValue)
      itemBahanBaku.Weight = CDec(txtTotalWeightBB.EditValue)
      itemBahanBaku.Catatan = txtRemarksBB.Text
      itemBahanBaku.Harga = itemBahanJadi.ProduksiDetail.Harga

      '======== set serial dari temp
      For j = itemBahanBaku.Serial.Count - 1 To 0 Step -1
        Dim x = itemBahanBaku.Serial(j)
        Dim find = _bbSerial.Find(Function(m) m.Id = x.Id)
        If find Is Nothing Then
          itemBahanBaku.Serial(j).Delete()
        End If
      Next

      For j = 0 To _bbSerial.Count - 1
        Dim x = _bbSerial(j)
        Dim find = itemBahanBaku.Serial.ToList.Find(Function(m) m.Id = x.Id)
        If find Is Nothing Then
          find = New Fusoh_StockAdjustmentDetailSerial(session)
          find.DetailMain = itemBahanBaku
        End If
        find.LengthIn = x.LengthIn
        find.Serial = x.Serial
        find.MillSheet = x.MillSheet
      Next

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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Back To Material -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Back To Material -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -2 : txtTanggal.Focus()
      Case -3 : txtGudang.Focus()
      Case -4 : txtStatus.Focus()
      Case -5 : txtItemBJ.Focus()
      Case -6 : txtQtyBJ.Focus()
      Case -7 : txtKodeProduksi.Focus()
      Case -8 : txtItemBB.Focus()
      Case -9 : txtQtyBB.Focus()
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
    txtGudang.EditValue = CType(txtGudang.Properties.DataSource, List(Of Gudang))(0)
    txtQtyBJ.EditValue = 0.0
    txtQtyBB.EditValue = 0.0
    txtLengthBJ.EditValue = 0.0
    txtLengthBB.EditValue = 0.0
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.BM)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtGudang.Properties.ReadOnly = True
    txtUraian.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True

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
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub txtItemBJ_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtItemBJ.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As Persistent.Fusoh_Barang = CType(e.NewValue, Persistent.Fusoh_Barang)
      txtLengthBJ.EditValue = item.Length
      txtODBJ.EditValue = item.OutDiameter
      txtIDBJ.EditValue = item.InDiameter
      txtThicknesBJ.EditValue = item.Thickness
      txtStockBJ.EditValue = FusohLogic.Item.GetRemainStock(session, item)
      txtQtyBJ.Properties.MaxValue = CDec(txtStockBJ.EditValue)
      txtTotalWeightBJ.EditValue = CDec(txtQtyBJ.EditValue) * FusohLogic.Item.GetWeight(item.OutDiameter, item.Length, item.Thickness)
      txtKodeProduksi.Properties.DataSource = New XPQuery(Of Fusoh_StokDetail)(session).Where(Function(m) m.Barang Is item AndAlso (m.Main.Sumber.Id = Persistent.SumberDataJenis.AM OrElse m.Main.Sumber.Id = Persistent.SumberDataJenis.BS)).ToList
    End If
  End Sub
  Private Sub txtItemBB_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtItemBB.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As Persistent.Fusoh_Barang = CType(e.NewValue, Persistent.Fusoh_Barang)
      txtLengthBB.EditValue = item.Length
      txtODBB.EditValue = item.OutDiameter
      txtIDBB.EditValue = item.InDiameter
      txtThicknesBB.EditValue = item.Thickness
      txtTotalWeightBB.EditValue = CDec(txtQtyBB.EditValue) * FusohLogic.Item.GetWeight(item.OutDiameter, item.Length, item.Thickness)
    End If
  End Sub
  Private Sub txtQtyBJ_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtQtyBJ.EditValueChanging
    If Not e.NewValue Is Nothing AndAlso Not txtItemBJ.EditValue Is Nothing Then
      Dim item As Persistent.Fusoh_Barang = CType(txtItemBJ.EditValue, Persistent.Fusoh_Barang)
      txtTotalWeightBJ.EditValue = CDec(e.NewValue) * FusohLogic.Item.GetWeight(item.OutDiameter, CDec(txtLengthBJ.EditValue), item.Thickness)
    End If
  End Sub
  Private Sub txtLengthBJ_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtLengthBJ.EditValueChanging
    If Not e.NewValue Is Nothing AndAlso Not txtItemBJ.EditValue Is Nothing Then
      Dim item As Persistent.Fusoh_Barang = CType(txtItemBJ.EditValue, Persistent.Fusoh_Barang)
      txtTotalWeightBJ.EditValue = CDec(txtQtyBJ.EditValue) * FusohLogic.Item.GetWeight(item.OutDiameter, CDec(e.NewValue), item.Thickness)
    End If
  End Sub
  Private Sub txtQtyBB_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtQtyBB.EditValueChanging
    If Not e.NewValue Is Nothing AndAlso Not txtItemBB.EditValue Is Nothing Then
      Dim item As Fusoh_Barang = CType(txtItemBB.EditValue, Fusoh_Barang)
      txtTotalWeightBB.EditValue = CDec(e.NewValue) * FusohLogic.Item.GetWeight(item.OutDiameter, CDec(txtLengthBB.EditValue), item.Thickness)
    End If
  End Sub
  Private Sub txtQtyBB_EditValueChanged(sender As Object, e As EventArgs) Handles txtQtyBB.EditValueChanged
    If Not txtQtyBB.EditValue Is Nothing AndAlso Not txtItemBB.EditValue Is Nothing Then
      '==== serial temp
      Dim qty = CDec(txtQtyBB.EditValue)
      Dim item As Persistent.Fusoh_Barang = CType(txtItemBB.EditValue, Persistent.Fusoh_Barang)

      If (qty > _bbSerial.Count) Then
        For j = 0 To qty - _bbSerial.Count - 1
          Dim serial = New Fusoh_StockDetailSerial_Temp With {
            .Id = CLng(j + 1),
            .LengthIn = item.Length,
            .Serial = "",
            .MillSheet = ""
          }
          _bbSerial.Add(serial)
        Next
      ElseIf (qty < _bbSerial.Count) Then
        For j = _bbSerial.Count - 1 To qty Step -1
          _bbSerial.RemoveAt(CInt(j))
        Next
      End If

    End If
  End Sub
  Private Sub txtLengthBB_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtLengthBB.EditValueChanging
    If Not e.NewValue Is Nothing AndAlso Not txtItemBB.EditValue Is Nothing Then
      Dim item As Persistent.Fusoh_Barang = CType(txtItemBB.EditValue, Persistent.Fusoh_Barang)
      txtTotalWeightBB.EditValue = CDec(txtQtyBB.EditValue) * FusohLogic.Item.GetWeight(item.OutDiameter, CDec(e.NewValue), item.Thickness)
    End If
  End Sub

  Private Sub btnSerial_Click(sender As Object, e As EventArgs) Handles btnSerial.Click
    If Not txtItemBB.EditValue Is Nothing AndAlso CDec(txtQtyBB.EditValue) > 0 Then
      Dim frm As New UI_FusohSerialDialog2
      frm.NamaDatabase = Me.NamaDatabase
      frm.MenuId = Me.MenuId
      frm.session = session

      frm.LoadingData(CType(txtItemBB.EditValue, Fusoh_Barang), CInt(txtQtyBB.EditValue), _bbSerial)
      If Not AllowSave Then
        frm.Disable()
      End If
      frm.ShowDialog()
      _bbSerial = frm.SerialData
    End If
  End Sub
End Class