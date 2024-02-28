Imports DevExpress.Xpo
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports System.ComponentModel

Friend Class UI_FusohAdjusmentRMDialog
	Private instance As Persistent.Fusoh_StokMain
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private detailSource As BindingList(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True

		colOD.Caption = "OD" & vbCrLf & "(mm)"
		colInD.Caption = "ID" & vbCrLf & "(mm)"
		colThickness.Caption = "T" & vbCrLf & "(mm)"
		colLength.Caption = "L" & vbCrLf & "(mm)"
		xGridView.IndicatorWidth = 30
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PRTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PRTransaksi.xml"))
		End If
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		detailSource = New BindingList(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
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
			txtUraian.Text = instance.Catatan
			'txtKontak.EditValue = instance.KaryawanKirim
			txtKontak.EditValue = instance.Pelanggan
			txtTanggal.EditValue = instance.Tanggal
			txtRegional.EditValue = instance.Regional
			txtGudang.EditValue = instance.Gudang
			txtNoTransaksi.Text = instance.Kode
			txtStatus.EditValue = instance.StatusTransaksi

			For Each det In instance.Detail
				'If det.QtyOut > 0 Then
				For Each serial In det.Serial
					Dim dataSerial = New XPQuery(Of Fusoh_StokSerial)(session).Where(Function(w) w.DetailMain.Barang Is det.Barang AndAlso w.Serial = serial.Serial)
					Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
					item.Id = det.Id
					item.Barang = det.Barang
					item.Catatan = det.Catatan
					item.Qty = serial.Qty
					item.Millsheet = serial.MillSheet
					item.Serial = serial.Serial
					item.Length = CDec(serial.LengthOut)
					item.SNLength = CDec(dataSerial.Sum(Function(s) s.LengthIn - s.LengthOut) + item.Length)
					item.SNQty = dataSerial.Sum(Function(s) s.Qty) - serial.Qty
					detailSource.Add(item)
				Next
				'End If
			Next
			editAssign = False
		End If
		xGrid.DataSource = detailSource
		SetNomor()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Adjustment RM : Tambah"
		Else
			Me.Text = "Adjustment RM : Edit " & instance.Kode
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

    Try
      '======= cek stok
      Dim errorStok As String = ""
      For i = 0 To detailSource.Count - 1
        Dim bahan = detailSource(i)
        Dim stokSaatIni = New XPQuery(Of Fusoh_StokSerial)(session) _
          .Where(Function(n) n.DetailMain.Barang Is bahan.Barang AndAlso n.Serial = bahan.Serial AndAlso Not n.DetailMain.Main Is instance) _
          .Sum(Function(s) s.LengthIn - s.LengthOut)

        If bahan.Length > stokSaatIni Then
          errorStok &= vbCrLf & String.Format("{0}-{1} ({2}) ==> {3}, tersedia {4}", bahan.Barang.Kode, bahan.Barang.Nama, bahan.Serial, bahan.Length, stokSaatIni)
        End If
      Next
      If errorStok <> "" Then
        Throw New Utils.Exception("Ada beberapa bahan yang kekurangan stok :" & errorStok, -99)
      End If

      '======= Simpan Main
      instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Catatan = txtUraian.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.Kurs = 1
      instance.Save()

      '====== Bahan Baku
      Dim bahanBaku = instance.Detail
      Dim item = detailSource.GroupBy(Function(g) g.Barang).Select(Function(s) s.Key).ToList
      For i = bahanBaku.Count - 1 To 0 Step -1
        Dim baku = bahanBaku(i)
        '====== delete serial
        For j = baku.Serial.Count - 1 To 0 Step -1
          Dim bakuserial = baku.Serial(j)
          Dim foundserial = detailSource.ToList.Find(Function(f) f.Barang Is baku.Barang AndAlso f.Serial = bakuserial.Serial)
          If foundserial Is Nothing Then
            bakuserial.Delete()
            baku.Serial.Remove(bakuserial)
          End If
        Next

        Dim found = item.Find(Function(f) f Is baku.Barang)
        If found Is Nothing Then
          baku.Delete()
          instance.Detail.Remove(baku)
        End If
      Next

      For i = 0 To detailSource.Count - 1
        Dim bahan = detailSource(i)
        Dim found = instance.Detail.ToList.Find(Function(f) f.Barang Is bahan.Barang)
        If found Is Nothing Then
          found = New Fusoh_StokDetail(session)
          found.Main = instance
          found.Barang = bahan.Barang
          found.Gudang = instance.Gudang
          found.QtyIn = 0
          found.QtyOut = detailSource.Where(Function(w) w.Barang Is bahan.Barang).Sum(Function(s) s.Qty)
          found.OutDiameter = found.Barang.OutDiameter
          found.InDiameter = found.Barang.InDiameter
          found.Thickness = found.Barang.Thickness
          found.Length = found.Barang.Length
          found.Weight = FusohLogic.Item.GetWeight(found.OutDiameter, found.Length, found.Thickness)
          found.Satuan = bahan.Barang.SatuanD
          instance.Detail.Add(found)
        Else
          found.QtyOut = detailSource.Where(Function(w) w.Barang Is bahan.Barang).Sum(Function(s) s.Qty)
        End If

        '===== serial
        Dim serial = found.Serial.ToList.Find(Function(f) f.Serial Is bahan.Serial)
        If serial Is Nothing Then
          serial = New Persistent.Fusoh_StokSerial(session)
          serial.DetailMain = found
          serial.Serial = bahan.Serial
          found.Serial.Add(serial)
        End If
        serial.MillSheet = bahan.Millsheet
        serial.LengthIn = 0
        serial.LengthOut = bahan.Length
        serial.Qty = bahan.Qty
      Next

      '======= update hpp
      FusohLogic.HPP.HitungHPPDariProduksi(instance, False)

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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Adjustment RM -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Adjustment RM -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try
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
		txtKontak.Properties.DataSource = New XPQuery(Of NuSoft001.Persistent.Kontak)(session).Where(Function(w) w.TipeKontak.Id = 1).ToList
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))

		colKodeRepo.DataSource = New XPQuery(Of Persistent.Fusoh_Barang)(session).Where(Function(w) w.TipeBarang = Persistent.TipeBarang.BahanBaku AndAlso w.Jenis = Persistent.JenisBarang.Persediaan AndAlso w.Aktif = True).ToList
	End Sub
	Private Sub SetFormat()
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
		txtGudang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtGudang)
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.PR)
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
			Dim row As NonPersistent.Fusoh_Produksi_BahanBaku_Temp = CType(xGridView.GetRow(e.RowHandle), NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
			If e.Column Is colMaterialLength Then
				row.Qty = 0
				If row.SNLength = CDec(e.Value) AndAlso row.SNQty < 1 Then
					row.Qty = 1
				End If
			End If
		End If
	End Sub
	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
		Dim row As NonPersistent.Fusoh_Produksi_BahanBaku_Temp = CType(xGridView.GetRow(e.RowHandle), NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
		row.Barang = Nothing
		row.Serial = Nothing
		row.SNLength = 0
		row.Length = 0
		row.Qty = 0
		row.SNQty = 0
		row.Catatan = ""
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As NonPersistent.Fusoh_Produksi_BahanBaku_Temp = CType(xGridView.GetRow(xGridView.FocusedRowHandle), NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
			xGridView.DeleteRow(xGridView.FocusedRowHandle)
		End If
	End Sub
	Private Sub xGridView_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles xGridView.CustomDrawRowIndicator
		If e.RowHandle >= 0 Then
			e.Info.DisplayText = (e.RowHandle + 1).ToString()
		End If
	End Sub
	Private Sub xGridView_ShownEditor(sender As Object, e As EventArgs) Handles xGridView.ShownEditor
		If (xGridView.FocusedColumn Is colMaterialLength AndAlso xGridView.ActiveEditor.GetType Is GetType(SpinEdit)) Then
			Dim edit As SpinEdit = CType(xGridView.ActiveEditor, SpinEdit)
			Dim item As NonPersistent.Fusoh_Produksi_BahanBaku_Temp = CType(xGridView.GetRow(xGridView.FocusedRowHandle), NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
			If item Is Nothing Then Return

			edit.Properties.MaxValue = item.SNLength
		End If
	End Sub
	Private Sub colSNRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colSNRepo.ButtonClick
		Dim frm As New UI_FusohAdjustmentRMSerial
		frm.session = session
		Dim focusedRow = CType(xGridView.GetRow(xGridView.FocusedRowHandle), NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
		If (focusedRow Is Nothing OrElse focusedRow.Barang Is Nothing) Then Return
		frm.Row = focusedRow
		Dim xSelected = detailSource.Where(Function(w) w.Barang Is focusedRow.Barang).ToList
		frm.SerialResult = xSelected
		frm.EditedDetail = instance.Detail.ToList

		If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
			'== hapus tidak terpilih
			For i = xSelected.Count - 1 To 0 Step -1
				Dim o = xSelected(i)
				If o.Barang Is focusedRow.Barang Then
					Dim find = frm.SerialResult.Find(Function(f) f.Barang Is o.Barang AndAlso f.Serial = o.Serial)
					If find Is Nothing Then
						detailSource.Remove(o)
					End If
				End If
			Next

			'=== set terpilih
			For i = 0 To frm.SerialResult.Count - 1
				Dim s = frm.SerialResult(i)
				Dim fa = detailSource.ToList.Find(Function(f) f.Barang Is s.Barang AndAlso f.Serial = s.Serial)
				If fa Is Nothing Then
					detailSource.Add(s)
				End If
			Next
		End If
	End Sub
	Private Sub xGridView_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles xGridView.InvalidRowException
		e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
	End Sub

	Private Sub barScrap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barScrap.ItemClick
		Dim frm As New UI_FusohAdjustmentRMScrap
		frm.session = session
		Dim xSelected = detailSource.Where(Function(w) w.Scrap).ToList
		frm.SerialResult = xSelected

		If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
			'=== set terpilih
			For i = 0 To frm.SerialResult.Count - 1
				Dim s = frm.SerialResult(i)
				Dim fa = detailSource.ToList.Find(Function(f) f.Barang Is s.Barang AndAlso f.Serial = s.Serial)
				If fa Is Nothing Then
					detailSource.Add(s)
				End If
			Next
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
End Class