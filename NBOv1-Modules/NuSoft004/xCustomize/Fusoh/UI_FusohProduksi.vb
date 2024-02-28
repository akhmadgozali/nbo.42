Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.FusohLogic
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohProduksi
	Private toStringFormat As String
	Sub New()
		InitializeComponent()
		baseView = xGridView
		KeyField = "Id"
		useMDIforDialog = True
		useFeedbackSource = True
		ActivateToolTip = True
		UseDbSystem = False
	End Sub
	Overrides Sub FirstLoad()
		GetSession()
		Dim setting As New NuSoft001.Logic.FinaSetting(session)
		Dim CreateCriteria As CriteriaOperator
		CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.AM, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
		ifSource.FixedFilterCriteria = CreateCriteria
		toStringFormat = setting.NumericFormatToString
		btnClosing.Enabled = False
		btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		btnUnposting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AMData.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AMData.xml"))
		End If
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_FusohProduksiDialog
	End Function
	Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
		Dim result As New List(Of Core.Win.Forms.GridDeletedData)
		Dim item As Core.Win.Forms.GridDeletedData

		For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
			If Not xGridView.IsGroupRow(selectedRows(i)) Then
				item = New Core.Win.Forms.GridDeletedData
				item.Row = selectedRows(i)
				item.Data = xGridView.GetRowCellValue(selectedRows(i), "Kode").ToString
				result.Add(item)
			End If
		Next
		Return result
	End Function
	Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
		'Dim item As Persistent.Fusoh_StokMain, pPending As Integer
		'Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

		'pPending = 0
		'For i = 0 To selectedData.Count - 1
		'  If Not xGridView.IsGroupRow(selectedData(i).Row) Then
		'    proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
		'    item = CType(proxy.OriginalRow, Persistent.Fusoh_StokMain)
		'    If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
		'	'If item.CuttingWIP Is Nothing Then
		'	'	'======= Update status dempyou
		'	'	Dim xpProduksi = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.Id <> item.Id AndAlso w.Main.OrderProduksi Is item.OrderProduksi AndAlso Not w.Main Is item)
		'	'	If xpProduksi.Count = 0 Then
		'	'		item.OrderProduksi.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		'	'	Else
		'	'		item.OrderProduksi.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
		'	'	End If
		'	'Else
		'	'	'======= Update status cutting wip
		'	'	item.CuttingWIP.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		'	'End If

		'	'===== update status
		'	Services.Fusoh_UpdateStatus.UpdateStatusDempyouDariProduksi(session, item, item.TotalQtyIn * -1)
		'	item.Delete()
		'Else
		'      pPending += 1
		'    End If
		'  End If
		'Next
		'session.CommitChanges()
		'If pPending > 0 Then
		'  Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
		'End If

		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
		Dim listDeleteData As New List(Of Fusoh_StokMain)

		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
				listDeleteData.Add(CType(proxy.OriginalRow, Fusoh_StokMain))
			End If
		Next

		Try
			Services.TransaksiProduksi.DeleteData(session, listDeleteData)
		Catch ex As Exception
			Utils.Win.MessageBox.Show(ex.Message, "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
		End Try

		Return True
	End Function

	Private Sub btnPosting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPosting.ItemClick, btnUnposting.ItemClick, btnClosing.ItemClick
		Dim xText As String = String.Format("Apakah anda ingin {0} {1} ?", e.Item.Tag, Me.Text)
		Dim x As Integer() = Nothing
		If allowEdit = False Then
			Utils.Win.MessageBox.Show("Anda tidak mendapatkan hak akses untuk merubah transaksi", "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
			Exit Sub
		End If

		If baseView.RowCount < 1 Then
			Exit Sub
		End If

		If TypeOf (baseView) Is DevExpress.XtraGrid.Views.Grid.GridView Then
			Dim viewGrid As DevExpress.XtraGrid.Views.Grid.GridView = CType(baseView, DevExpress.XtraGrid.Views.Grid.GridView)
			If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
				Exit Sub
			End If
			x = viewGrid.GetSelectedRows
		ElseIf TypeOf (baseView) Is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView Then
			Dim viewGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = CType(baseView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
			If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
				Exit Sub
			End If
			x = viewGrid.GetSelectedRows
		End If

		Dim note As List(Of NuSoft.Core.Win.Forms.GridDeletedData) = GetKeteranganHapus(x)
		If note Is Nothing Then
			Utils.Win.MessageBox.Show("Masukkan keterangan data yang akan dihapus", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
			Exit Sub
		End If

		For i = 0 To note.Count - 1
			xText &= vbCrLf & note(i).Data
		Next

		If Len(xText) > 0 Then
			If Utils.Win.MessageBox.Show(xText, "Update Status " & Me.Text, "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
				setstatus(note, e.Item.Tag.ToString)
				RefreshData()
			End If
		End If
	End Sub
	Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
		Dim item As Persistent.Fusoh_StokMain, xGagal As Integer, xMessage As String
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
		xGagal = 0
		xMessage = ""
    Dim kodeStatus = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Fusoh_StokMain)
        If xTipe = "memposting" Then
          xMessage = "Hanya transaksi pending yang bisa dirubah statusnya menjadi posting."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
            kodeStatus &= ", " & item.Kode
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengunposting" Then
          xMessage = "Hanya transaksi posting yang bisa dirubah statusnya menjadi pending."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
            kodeStatus &= ", " & item.Kode
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengclosing" Then
          xMessage = "Transaksi yang sudah selesai tidak dapat diclose."
          If Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish Or item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
            kodeStatus &= ", " & item.Kode
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed
          Else
            xGagal += 1
          End If
        End If
      End If
    Next
    session.CommitChanges()
    '======= Simple log
    Try
      If kodeStatus <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Produksi " & xTipe & " ->" & kodeStatus.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
	Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("AMData.xml"))
	End Sub
	'Private Sub btnReset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnReset.ItemClick
	'  If Not xGridView.DataSource Is Nothing Then
	'    Dim NomorTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colCode)
	'    Dim xInstance As XPCollection(Of Persistent.Fusoh_StokMain)(session)
	'    Dim xDataProduksi As New XPCollection(Of Persistent.Fusoh_StockDetailSerial)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("DetailMain.Barang.Kode", pKode, BinaryOperatorType.Equal)))



	'    RefreshData()
	'  End If
	'End Sub

	'Private Sub btnShowHPP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnShowHPP.ItemClick, btnHPP2.ItemClick
	'	Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colCode)
	'	If Not xNoTransaksi Is Nothing Then
	'		'Logic.Umum.xHistoryData(Me, session, UI_CekData.TipeTransaksi.SO, xNoTransaksi)
	'		Dim ProduksiAM As New XPCollection(Of Persistent.Fusoh_StokMain)(session, New BinaryOperator("Kode", xNoTransaksi, BinaryOperatorType.Equal))

	'		If ProduksiAM(0).CuttingWIP Is Nothing Then 'show HPP without WIP
	'			Dim hppKeluar = ProduksiAM(0).Detail.Where(Function(w) w.TotalLengthOut > 0)
	'			Dim totalHPPKeluar As Double = 0
	'			Dim xJali As String

	'			xJali = "Rincian HPP Untuk : " & xNoTransaksi & vbCrLf
	'			For Each detail In hppKeluar
	'				Dim totalHPPPerItem As Double = 0
	'				xJali = ""
	'				For Each serial In detail.Serial '===== hitung per serial
	'					'===== cari penerimaan
	'					Dim grSerial = New XPQuery(Of Fusoh_StokSerial)(ProduksiAM.Session) _
	'						.Where(Function(w) w.DetailMain.Barang Is serial.DetailMain.Barang _
	'						AndAlso w.Serial = serial.Serial AndAlso w.LengthIn > 0) _
	'						.ToList.Take(1).SingleOrDefault

	'					If Not grSerial Is Nothing Then
	'						Dim hppPerQty As Double = 0
	'						'===== cari hpp per qty
	'						If (grSerial.DetailMain.EximDetail Is Nothing) Then
	'							hppPerQty = grSerial.DetailMain.Harga
	'						Else
	'							'=== ambil dari invoice
	'							hppPerQty = GetHPPBahanBakuPerQty(ProduksiAM(0).Session, grSerial.DetailMain.EximDetail.Id)
	'						End If

	'						'===== hpp per length serial
	'						If (grSerial.DetailMain.Length = 0) Then
	'							totalHPPPerItem += 0
	'						Else
	'							xJali = xJali & "SN No : " & grSerial.Serial & " : " & ((hppPerQty / grSerial.LengthIn) * serial.LengthOut).ToString("n2") & "=(" & hppPerQty.ToString("n2") & " / " & grSerial.LengthIn.ToString("n2") & ") * " & serial.LengthOut.ToString & vbCrLf
	'							totalHPPPerItem += (hppPerQty / grSerial.LengthIn) * serial.LengthOut
	'						End If
	'						'Throw New Exception(totalHPPPerItem & "/" & hppPerQty & "/" & grSerial.DetailMain.Length & "*" & serial.LengthOut)
	'					End If
	'				Next
	'				'MsgBox(xJali & vbCrLf & "Total HPP : " & totalHPPPerItem.ToString("n2"))

	'				Dim frm As New UI_MessageForm
	'				frm.Text = "Rincian HPP Untuk : " & xNoTransaksi
	'				frm.txt.Text = xJali & vbCrLf & "Total HPP : " & totalHPPPerItem.ToString("n2")
	'				frm.ShowDialog()
	'			Next
	'		Else 'show hpp with WIP
	'			Dim wipMasuk = ProduksiAM(0).CuttingWIP.Detail.Where(Function(w) w.QtyIn > 0)
	'			Dim totalHPP As Double = 0
	'			Dim xJali As String

	'			xJali = "Rincian HPP Untuk : " & xNoTransaksi & vbCrLf
	'			For Each detail In wipMasuk
	'				Dim Hpp = detail.QtyIn * detail.Harga
	'				xJali &= "Item : " & detail.Barang.Nama & ", Qty : " & detail.QtyIn.ToString("n2") & ", Harga : " & detail.Harga.ToString("n2") & ", HPP : " & Hpp.ToString("n2") & vbCrLf
	'				totalHPP += Hpp
	'			Next

	'			Dim frm As New UI_MessageForm
	'			frm.Text = "Rincian HPP Untuk : " & xNoTransaksi
	'			frm.txt.Text = xJali & vbCrLf & "Total HPP : " & totalHPP.ToString("n2")
	'			frm.ShowDialog()
	'		End If
	'	End If
	'End Sub
	'Friend Shared Function GetHPPBahanBakuPerQty(session As UnitOfWork, EximDetailId As Long) As Double
	'	'==== Jika saldo awal ambil harga dari harga saldo awal
	'	Dim detInvoice = New XPQuery(Of Fusoh_PenerimaanInvoiceDetail)(session) _
	'				.Where(Function(w) w.EximDetail.Id = EximDetailId).SingleOrDefault
	'	Dim xKeterangan As String = ""

	'	If (Not detInvoice Is Nothing) Then
	'		'Dim hargaBeli = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
	'		'Dim totalCostSheet = detInvoice.Main.TotalCost
	'		'Dim totalWeight = detInvoice.Main.NoExim.TotalWeight
	'		'Dim biayaCost = (totalCostSheet / totalWeight) * detInvoice.EximDetail.Weight

	'		'==jali 15-juli
	'		Dim hargaBeli = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
	'		Dim totalCostSheet = detInvoice.Main.TotalCost
	'		Dim totalWeight = detInvoice.Main.NoExim.TotalWeight
	'		Dim biayaCost = detInvoice.TotalPembelianIDR

	'		xKeterangan = "Biaya cost : " & biayaCost.ToString("n2") & "-->" & detInvoice.TotalIDR & "+ " & detInvoice.TotalCostIDR & vbCrLf
	'		xKeterangan = xKeterangan & "NIlainya adalah : " & (biayaCost / detInvoice.Qty) & "-->(" & biayaCost & "/" & detInvoice.Qty & ")"
	'		'MsgBox(xKeterangan)
	'		Return (biayaCost / detInvoice.Qty)
	'	Else
	'		Return 0
	'	End If

	'End Function
	'Friend Shared Function GetHPPBahanBakuPerQtyStr(session As UnitOfWork, EximDetailId As Long) As String
	'	'==== Jika saldo awal ambil harga dari harga saldo awal
	'	Dim detInvoice = New XPQuery(Of Fusoh_PenerimaanInvoiceDetail)(session) _
	'				.Where(Function(w) w.EximDetail.Id = EximDetailId).SingleOrDefault

	'	If (Not detInvoice Is Nothing) Then
	'		'Dim hargaBeli = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
	'		'Dim totalCostSheet = detInvoice.Main.TotalCost
	'		'Dim totalWeight = detInvoice.Main.NoExim.TotalWeight
	'		'Dim biayaCost = (totalCostSheet / totalWeight) * detInvoice.EximDetail.Weight

	'		'==jali 15-juli
	'		Dim hargaBeli = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
	'		Dim totalCostSheet = detInvoice.Main.TotalCost
	'		Dim totalWeight = detInvoice.Main.NoExim.TotalWeight
	'		Dim biayaCost = detInvoice.TotalPembelianIDR

	'		' MsgBox("NIlainya adalah : " & hargaBeli + (biayaCost / detInvoice.Qty) & "-->" & hargaBeli & "+ (" & biayaCost & "/" & detInvoice.Qty & ")")
	'		' MsgBox("NIlainya adalah : " & (biayaCost / detInvoice.Qty) & "-->(" & biayaCost & "/" & detInvoice.Qty & ")")

	'		Return detInvoice.Main.Kode & " : " & (biayaCost / detInvoice.Qty).ToString & " --> " & biayaCost.ToString("n2") & "/" & detInvoice.Qty.ToString
	'	Else
	'		Return "0"
	'	End If

	'End Function

	'Private Sub btnResetHPP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnResetHPP.ItemClick
	'	Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colCode)
	'	If Not xNoTransaksi Is Nothing Then
	'		Dim ProduksiAM As New XPCollection(Of Persistent.Fusoh_StokMain)(session, New BinaryOperator("Kode", xNoTransaksi, BinaryOperatorType.Equal))

	'		If ProduksiAM(0).CuttingWIP Is Nothing Then 'without WIP
	'			Dim hppKeluar = ProduksiAM(0).Detail.Where(Function(w) w.TotalLengthOut > 0)
	'			Dim totalHPPKeluar As Double = 0
	'			Dim xJali As String

	'			xJali = "No Transaksi : " & xNoTransaksi & vbCrLf
	'			For Each detail In hppKeluar
	'				xJali = xJali & "Kode Part : " & detail.Barang.Kode & " --> " & detail.QtyOut.ToString("n2") & " Serial : " & detail.Serial.Count & vbCrLf
	'				Dim totalHPPPerItem As Double = 0
	'				For Each serial In detail.Serial '===== hitung per serial
	'					'===== cari penerimaan
	'					Dim grSerial = New XPQuery(Of Fusoh_StokSerial)(ProduksiAM(0).Session) _
	'						.Where(Function(w) w.DetailMain.Barang Is serial.DetailMain.Barang _
	'						AndAlso w.Serial = serial.Serial AndAlso w.LengthIn > 0) _
	'						.ToList.Take(1).SingleOrDefault

	'					If Not grSerial Is Nothing Then
	'						Dim hppPerQty As Double = 0
	'						'===== cari hpp per qty
	'						If (grSerial.DetailMain.EximDetail Is Nothing) Then
	'							xJali = xJali & "Ambilkan dari Exim : " & grSerial.DetailMain.Main.Kode & vbCrLf
	'							hppPerQty = grSerial.DetailMain.Harga
	'						Else
	'							'=== ambil dari invoice
	'							xJali = xJali & "Ambilkan dari IV Pembelian : exim ID = " & grSerial.DetailMain.EximDetail.Id & vbCrLf
	'							xJali = xJali & "Nilai : " & GetHPPBahanBakuPerQtyStr(ProduksiAM(0).Session, grSerial.DetailMain.EximDetail.Id) & vbCrLf
	'							hppPerQty = GetHPPBahanBakuPerQty(ProduksiAM(0).Session, grSerial.DetailMain.EximDetail.Id)
	'						End If

	'						'===== hpp per length serial
	'						If (grSerial.DetailMain.Length = 0) Then
	'							totalHPPPerItem += 0
	'						Else
	'							xJali = xJali & "SN No : " & grSerial.Serial & " : " & ((hppPerQty / grSerial.LengthIn) * serial.LengthOut).ToString("n2") & "=(" & hppPerQty.ToString("n2") & " / " & grSerial.LengthIn.ToString("n2") & ") * " & serial.LengthOut.ToString & vbCrLf
	'							totalHPPPerItem += (hppPerQty / grSerial.LengthIn) * serial.LengthOut
	'						End If
	'					End If
	'				Next
	'				If detail.QtyOut > 0 Then
	'					detail.Harga = totalHPPPerItem / detail.QtyOut
	'				End If
	'				detail.TotalHPP = totalHPPPerItem
	'				totalHPPKeluar += totalHPPPerItem
	'				xJali = xJali & "---------Total HPP : " & totalHPPPerItem.ToString("n2") & "-->" & detail.QtyOut.ToString("n2") & vbCrLf
	'			Next

	'			'===== hitung hpp masuk
	'			Dim hppMasuk = ProduksiAM(0).Detail.Where(Function(w) w.QtyIn > 0)
	'			xJali = xJali & "Totalnya adalah : " & totalHPPKeluar.ToString("n2") & vbCrLf & "akan dibagikan ke total qty " & hppMasuk.Sum(Function(s) s.QtyIn).ToString("n2") & vbCrLf
	'			'MsgBox(xJali)
	'			Dim frm As New UI_MessageForm
	'			frm.Text = "Reset HPP, No. Transaksi : " & xNoTransaksi
	'			frm.txt.Text = xJali
	'			frm.ShowDialog()

	'			Dim totalHPPMasukPerQty As Double = totalHPPKeluar / hppMasuk.Sum(Function(s) s.QtyIn)
	'			Dim pK As Integer
	'			For Each detail In hppMasuk
	'				detail.Harga = totalHPPMasukPerQty
	'				'nah, carikan untuk pengirimannya SJ ini, dan lakukan edit harga
	'				Dim xSJ As New XPCollection(Of Persistent.Fusoh_StokDetail)(ProduksiAM(0).Session, New BinaryOperator("ProduksiDetail.Id", detail.Id, BinaryOperatorType.Equal))
	'				For pK = 0 To xSJ.Count - 1
	'					xSJ(pK).Harga = totalHPPMasukPerQty
	'					xSJ(pK).TotalHPP = totalHPPMasukPerQty * xSJ(pK).QtyOut
	'				Next
	'			Next

	'			ProduksiAM(0).Session.CommitChanges()
	'		Else 'with WIP
	'			Dim wipMasuk = ProduksiAM(0).CuttingWIP.Detail.Where(Function(w) w.QtyIn > 0)
	'			Dim totalHPPKeluar As Double = 0
	'			Dim xJali As String

	'			xJali = "No Transaksi : " & xNoTransaksi & vbCrLf
	'			For Each detail In wipMasuk
	'				Dim totalHPPPerItem As Double = detail.QtyIn * detail.Harga
	'				xJali &= "Item : " & detail.Barang.Nama & ", Qty : " & detail.QtyIn.ToString("n2") & ", Harga : " & detail.Harga.ToString("n2") & ", HPP : " & totalHPPPerItem.ToString("n2") & vbCrLf
	'				totalHPPKeluar += totalHPPPerItem
	'			Next

	'			Dim hppKeluar = ProduksiAM(0).Detail.Where(Function(w) w.QtyOut > 0)
	'			For Each detail In hppKeluar
	'				detail.Harga = totalHPPKeluar / detail.QtyOut
	'				detail.TotalHPP = totalHPPKeluar
	'				xJali = xJali & "---------Total HPP : " & totalHPPKeluar.ToString("n2") & "-->" & detail.QtyOut.ToString("n2") & vbCrLf
	'			Next

	'			'===== hitung hpp masuk
	'			Dim hppMasuk = ProduksiAM(0).Detail.Where(Function(w) w.QtyIn > 0)
	'			xJali = xJali & "Totalnya adalah : " & totalHPPKeluar.ToString("n2") & vbCrLf & "akan dibagikan ke total qty " & hppMasuk.Sum(Function(s) s.QtyIn).ToString("n2") & vbCrLf
	'			'MsgBox(xJali)
	'			Dim frm As New UI_MessageForm
	'			frm.Text = "Reset HPP, No. Transaksi : " & xNoTransaksi
	'			frm.txt.Text = xJali
	'			frm.ShowDialog()

	'			Dim totalHPPMasukPerQty As Double = totalHPPKeluar / hppMasuk.Sum(Function(s) s.QtyIn)
	'			Dim pK As Integer
	'			For Each detail In hppMasuk
	'				detail.Harga = totalHPPMasukPerQty
	'				'nah, carikan untuk pengirimannya SJ ini, dan lakukan edit harga
	'				Dim xSJ As New XPCollection(Of Persistent.Fusoh_StokDetail)(ProduksiAM(0).Session, New BinaryOperator("ProduksiDetail.Id", detail.Id, BinaryOperatorType.Equal))
	'				For pK = 0 To xSJ.Count - 1
	'					xSJ(pK).Harga = totalHPPMasukPerQty
	'					xSJ(pK).TotalHPP = totalHPPMasukPerQty * xSJ(pK).QtyOut
	'				Next
	'			Next

	'			ProduksiAM(0).Session.CommitChanges()
	'		End If
	'	End If
	'	MsgBox("Proses Selesai.")
	'End Sub

	'===============================================================

	Private Sub btnResetAll_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnResetAll.ItemClick
		Dim frm As New UI_FusohProduksiResetAll
		frm.MenuId = Me.MenuId
		frm.NamaDatabase = Me.NamaDatabase
		frm.session = session
		frm.FromCW = False
		frm.ShowDialog()
	End Sub
	'===============================================================

	Private Sub barHistory_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barHistory.ItemClick
		If (xGridView.IsDataRow(xGridView.FocusedRowHandle)) Then
			Dim kodeAM As Persistent.Fusoh_StokMain = CType(CType(xGridView.GetFocusedRow(), ReadonlyThreadSafeProxyForObjectFromAnotherThread).OriginalRow, Persistent.Fusoh_StokMain)
			Dim frm As New UI_FusohProduksiHistory(kodeAM, session)
			frm.session = session
			frm.MenuId = Me.MenuId
			frm.NamaDatabase = Me.NamaDatabase
			frm.ShowDialog()
		End If
	End Sub
	Private Sub barRefreshStatus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barRefreshStatus.ItemClick
		Dim xText As String = "Apakah anda ingin merefresh status AM ?"
		Dim x As Integer() = Nothing

		If xGridView.RowCount < 1 Then
			Exit Sub
		End If

		If xGridView.IsGroupRow(xGridView.FocusedRowHandle) Then
			Exit Sub
		End If
		x = xGridView.GetSelectedRows

		Dim note As New List(Of String)
		For i = x.GetLowerBound(0) To x.GetUpperBound(0)
			If Not xGridView.IsGroupRow(x(i)) Then
				note.Add(xGridView.GetRowCellValue(x(i), "Kode").ToString)
			End If
		Next

		If note Is Nothing Then
			Utils.Win.MessageBox.Show("Masukkan keterangan data yang akan dihapus", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
			Exit Sub
		End If

		For i = 0 To note.Count - 1
			xText &= vbCrLf & note(i)
		Next
		If Utils.Win.MessageBox.Show(xText, "Refresh Status AM", "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
			Dim item As Fusoh_StokMain
			Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
			Dim errorSJlebihBesar As String = String.Empty

			For i = x.GetLowerBound(0) To x.GetUpperBound(0)
				If Not xGridView.IsGroupRow(x(i)) Then
					proxy = CType(xGridView.GetRow(x(i)), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
					item = CType(proxy.OriginalRow, Persistent.Fusoh_StokMain)
					Dim sdhProses = 0
					For j = 0 To item.Detail.Where(Function(w) w.QtyIn > 0).Count - 1
						Dim detailAM = item.Detail(j)
						Dim sjAM = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.ProduksiDetail Is detailAM)
						'== cek sebelumnya inprogres
						If (sjAM.Count > 0 AndAlso Not sdhProses = 1) Then
							Dim jmlKeluar = sjAM.Sum(Function(f) f.QtyOut)
							If detailAM.QtyIn > jmlKeluar Then
								sdhProses = 1
							ElseIf detailAM.QtyIn = jmlKeluar Then
								sdhProses = 2
							Else
								sdhProses = 99
								errorSJlebihBesar &= vbCrLf & item.Kode & " => Qty In (" & detailAM.QtyIn & "), Qty Out (" & jmlKeluar & ")"
								Exit For
							End If
						End If
					Next
					If sdhProses = 2 Then
						item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
					ElseIf sdhProses = 1 Then
						item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
					ElseIf sdhProses = 0 Then
						item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
					End If
				End If
			Next
			session.CommitChanges()
			If errorSJlebihBesar <> String.Empty Then
				Utils.Win.MessageBox.Show("Refresh status error, jumlah SJ lebih besar dari jumlah AM : " & errorSJlebihBesar, "Refresh Status AM", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
			End If
			RefreshData()
		End If
	End Sub

	'===============================================================
	Private Sub btnShowHPP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnShowHPP.ItemClick, btnHPP2.ItemClick
		Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colCode)
		If Not xNoTransaksi Is Nothing Then
			Dim ProduksiAM As New XPCollection(Of Fusoh_StokMain)(session, New BinaryOperator("Kode", xNoTransaksi, BinaryOperatorType.Equal))
			Dim xJali = FusohLogic.HPP.HitungHPPDariProduksi(ProduksiAM(0), False)
			ProduksiAM(0).Session.RollbackTransaction()

			Dim frm As New UI_MessageForm
			frm.Text = "Rincian HPP Untuk : " & xNoTransaksi
			frm.txt.Text = xJali
			frm.ShowDialog()
		End If
	End Sub
	Private Sub btnResetHPP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnResetHPP.ItemClick
		Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colCode)
		If Not xNoTransaksi Is Nothing Then
			Dim ProduksiAM As New XPCollection(Of Fusoh_StokMain)(session, New BinaryOperator("Kode", xNoTransaksi, BinaryOperatorType.Equal))
			Dim xJali = FusohLogic.HPP.HitungHPPDariProduksi(ProduksiAM(0), False)
			Dim frm As New UI_MessageForm
			frm.Text = "Reset HPP, No. Transaksi : " & xNoTransaksi
			frm.txt.Text = xJali
			frm.ShowDialog()
			session.CommitChanges()
		End If
		MsgBox("Proses Selesai.")
	End Sub
	'===============================================================
End Class