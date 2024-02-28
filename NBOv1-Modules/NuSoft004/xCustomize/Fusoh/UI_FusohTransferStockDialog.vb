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

Friend Class UI_FusohTransferStockDialog
  Private instance As Persistent.Fusoh_StokMain
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of SettingRegional)
  Private editAssign As Boolean = False
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private xQtyEdit As Double
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    AllowSave = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(Session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(Session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("TSTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("TSTransaksi.xml"))
    End If
  End Sub
  Private Sub BindingDataSource()
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(Session, NamaDatabase)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(StatusTransaksiEnum))
    txtGudang.Properties.DataSource = New XPQuery(Of Persistent.Gudang)(Session).ToList
    txtPelanggan.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderPenjualan)(session).GroupBy(Function(g) g.Pelanggan).Select(Function(s) s.Key).ToList
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    Session.ReloadChangedObjects()
    editAssign = True


    If Tipe = InputType.Tambah Then
      instance = New Persistent.Fusoh_StokMain(session)
      LoadDefault()
      ChangeCode()
      txtGudang.Focus()
      xQtyEdit = 0
    Else
      instance = session.GetObjectByKey(Of Persistent.Fusoh_StokMain)(Convert.ToInt64(IdToEdit))

      txtGudang.EditValue = instance.Gudang
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.StatusTransaksi
      txtUraian.Text = instance.Catatan
      txtPelanggan.EditValue = instance.Pelanggan

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
			'txtKodeProduksi.EditValue = itemBahanJadi.ProduksiDetail
			Dim xDtWwProduksi As FusohVwProduksi = New XPCollection(Of FusohVwProduksi)(session).Where(Function(w) w.Id = itemBahanJadi.ProduksiDetail.Id).FirstOrDefault
			txtKodeProduksi.EditValue = xDtWwProduksi  'itemBahanJadi.ProduksiDetail.Id

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
      xQtyEdit = CDec(itemBahanBaku.QtyIn)
    End If
    editAssign = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      Me.Text = "Transfer Finish Goods : Tambah"
    Else
      Me.Text = "Transfer Finish Goods : Edit " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl()
      End If
      If Periode.CheckLockedPeriod(Session, instance.Tanggal) Then
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
    If txtItemBJ.EditValue Is Nothing Then Throw New Utils.Exception("Pilih bahan sumber", -5)
    If txtQtyBJ.Value <= 0 Then Throw New Utils.Exception("Qty bahan sumber tidak boleh kosong", -6)
    If txtQtyBJ.Value > CDec(txtStockBJ.EditValue) Then Throw New Utils.Exception("Qty bahan sumber tidak boleh lebih dari sisa stok", -6)
    If txtKodeProduksi.EditValue Is Nothing Then Throw New Utils.Exception("Pilih nomor lot", -7)
    Dim itemBJ = CType(txtItemBJ.EditValue, Fusoh_Barang)
    Dim lot = CType(txtKodeProduksi.EditValue, FusohVwProduksi).StockDetail
    If lot.Barang.Id <> itemBJ.Id Then Throw New Utils.Exception("Pilih nomor lot", -7)

    '====== Cek DATA BAHAN BAKU
    If txtItemBB.EditValue Is Nothing Then Throw New Utils.Exception("Pilih bahan tujuan", -8)
    If txtQtyBB.Value <= 0 Then Throw New Utils.Exception("Qty bahan tujuan tidak boleh kosong", -9)

    If txtQtyBB.Value <> txtQtyBJ.Value Then Throw New Utils.Exception("Qty tujuan tidak sama dengan Qty Sumber", -9)
    If CType(txtItemBJ.EditValue, Persistent.Fusoh_Barang).Id = CType(txtItemBB.EditValue, Persistent.Fusoh_Barang).Id Then Throw New Utils.Exception("Item Barang Sumber tidak boleh sama dengan tujuan", -9)

		'Dim xProduksi As New XPCollection(Of FusohVwProduksi)(session, New BinaryOperator("Id", CType(txtKodeProduksi.EditValue, Fusoh_StokDetail).Id, BinaryOperatorType.Equal))
		'Dim xSisa As Double
		'xSisa = xProduksi(0).QtySisa + xQtyEdit

		If CType(txtKodeProduksi.EditValue, FusohVwProduksi).QtySisa < CType(txtQtyBJ.EditValue, Double) Then
			Throw New Utils.Exception("Qty tidak mencukupi untuk LOT no INI.", -9)
		End If


		Try
      '======= Simpan Main
      instance.Gudang = If(txtGudang.EditValue Is Nothing, Nothing, CType(txtGudang.EditValue, Gudang))
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = If(txtRegional.EditValue Is Nothing, Nothing, CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional))
      instance.Kode = txtNoTransaksi.Text
      instance.Pelanggan = CType(txtPelanggan.EditValue, Kontak)
      instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)
      instance.Kurs = 1
      instance.Catatan = txtUraian.Text

      '====== SIMPAN BAHAN JADI
      Dim itemBahanJadi = instance.Detail.ToList.Find(Function(f) f.QtyOut > 0)
      If itemBahanJadi Is Nothing Then itemBahanJadi = New Fusoh_StokDetail(session)
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

			'itemBahanJadi.ProduksiDetail = CType(txtKodeProduksi.EditValue, Fusoh_StokDetail)
			'itemBahanJadi.Harga = CType(txtKodeProduksi.EditValue, Fusoh_StokDetail).Harga

			itemBahanJadi.ProduksiDetail = CType(txtKodeProduksi.EditValue, FusohVwProduksi).StockDetail
			itemBahanJadi.Harga = CType(txtKodeProduksi.EditValue, FusohVwProduksi).StockDetail.Harga

			itemBahanJadi.TotalHPP = CDec(itemBahanJadi.QtyOut * itemBahanJadi.Harga)
			instance.DempyouLot = itemBahanJadi.ProduksiDetail.Main.DempyouLot


      '====== SIMPAN BAHAN BAKU
      Dim itemBahanBaku = instance.Detail.ToList.Find(Function(f) f.QtyIN > 0)
      If itemBahanBaku Is Nothing Then itemBahanBaku = New Fusoh_StokDetail(session)
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

			'itemBahanBaku.Harga = CType(txtKodeProduksi.EditValue, Fusoh_StokDetail).Harga
			'   itemBahanBaku.ProduksiDetail = CType(txtKodeProduksi.EditValue, Fusoh_StokDetail)
			itemBahanBaku.Harga = CType(txtKodeProduksi.EditValue, FusohVwProduksi).StockDetail.Harga
			itemBahanBaku.ProduksiDetail = CType(txtKodeProduksi.EditValue, FusohVwProduksi).StockDetail

			'======= Simpan instance
			session.CommitChanges()
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
    '======= Simple log
    Try
      If Tipe = InputType.Tambah Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Transfer Finish Goods -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Transfer Finish Goods -> " & instance.Kode)
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

    txtStatus.EditValue = StatusTransaksiEnum.Posting
    txtGudang.EditValue = CType(txtGudang.Properties.DataSource, List(Of Gudang))(0)
    txtQtyBJ.EditValue = 0.0
    txtQtyBB.EditValue = 0.0
    txtLengthBJ.EditValue = 0.0
    txtLengthBB.EditValue = 0.0
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.TS)
    instance.Number = New Logic.NumberClass(Session) With {.FormatNomor = setting.FormatNomor}
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
			txtStockBJ.EditValue = FusohLogic.Item.GetRemainStock(Session, item)
			txtQtyBJ.Properties.MaxValue = CDec(txtStockBJ.EditValue)
			txtTotalWeightBJ.EditValue = CDec(txtQtyBJ.EditValue) * FusohLogic.Item.GetWeight(item.OutDiameter, item.Length, item.Thickness)
			'txtKodeProduksi.Properties.DataSource = New XPQuery(Of Fusoh_StokDetail)(Session).Where(Function(m) m.Barang Is item AndAlso (m.Main.Sumber.Id = Persistent.SumberDataJenis.AM OrElse m.Main.Sumber.Id = Persistent.SumberDataJenis.BS)).ToList

			txtKodeProduksi.Properties.DataSource = New XPQuery(Of FusohVwProduksi)(session).Where(Function(m) m.StockDetail.Barang Is item AndAlso (m.StockDetail.Main.Sumber.Id = Persistent.SumberDataJenis.AM OrElse m.StockDetail.Main.Sumber.Id = Persistent.SumberDataJenis.BS)).ToList

			txtItemBB.Properties.DataSource = New XPQuery(Of Fusoh_Barang)(session).Where(Function(m) m.Aktif AndAlso m.TipeBarang = TipeBarang.BahanJadi AndAlso m.InDiameter = item.InDiameter AndAlso m.OutDiameter = item.OutDiameter AndAlso m.Length = item.Length AndAlso m.Thickness = item.Thickness).ToList
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
  Private Sub txtLengthBB_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtLengthBB.EditValueChanging
    If Not e.NewValue Is Nothing AndAlso Not txtItemBB.EditValue Is Nothing Then
      Dim item As Persistent.Fusoh_Barang = CType(txtItemBB.EditValue, Persistent.Fusoh_Barang)
      txtTotalWeightBB.EditValue = CDec(txtQtyBB.EditValue) * FusohLogic.Item.GetWeight(item.OutDiameter, CDec(e.NewValue), item.Thickness)
    End If
  End Sub
  Private Sub txtPelanggan_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtPelanggan.EditValueChanging
    If Not e.NewValue Is Nothing Then
      'isikan data detailnya
      txtPhoneNumber.Text = CType(e.NewValue, Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, Kontak).BatasHutang)
      'xGHistory.DataSource = New XPCollection(Of Persistent.Fusoh_OrderProduksi)(session, New BinaryOperator("Pelanggan", e.NewValue, BinaryOperatorType.Equal))

      txtItemBJ.Properties.DataSource = New XPQuery(Of Fusoh_Barang)(session).Where(Function(m) m.Aktif AndAlso m.TipeBarang = TipeBarang.BahanJadi AndAlso m.Customer.Id = CType(e.NewValue, Kontak).Id).ToList
    End If
  End Sub

  Private Sub txtKodeProduksi_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtKodeProduksi.EditValueChanging
		'If Not e.NewValue Is Nothing Then
		'  Dim xProduksi As New XPCollection(Of FusohVwProduksi)(session, New BinaryOperator("Id", CType(e.NewValue, Fusoh_StokDetail).Id, BinaryOperatorType.Equal))
		'  If xProduksi.Count > 0 Then
		'    txtInfoLOT.Text = "Qty Produksi : " & xProduksi(0).QtyIN & vbCrLf &
		'                      "Qty SJ : " & xProduksi(0).QtyKirim & vbCrLf &
		'                      "Qty Sisa : " & xProduksi(0).QtySisa & vbCrLf
		'  End If
		'End If
	End Sub
End Class