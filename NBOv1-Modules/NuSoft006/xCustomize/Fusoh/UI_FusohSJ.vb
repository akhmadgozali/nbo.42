Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem

Public Class UI_FusohSJ
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
		toStringFormat = setting.NumericFormatToString
    CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.FD, BinaryOperatorType.Equal))
    ifSource.FixedFilterCriteria = CreateCriteria

		btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		btnUnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SJData.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SJData.xml"))
		End If
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_FusohSJDialog
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
		Dim item As Persistent.Fusoh_SuratJalan, pPending As Integer
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim dtSO As New List(Of Persistent.Fusoh_OrderPenjualan)
    Dim dtProduksi As New List(Of Persistent.Fusoh_SuratJalan)
    Dim notDeleted As New List(Of Persistent.Fusoh_SuratJalan)
    Dim kodeDelete = ""

    pPending = 0
		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Fusoh_SuratJalan)


        If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
          'dtSO.Add(item.SO)
          dtProduksi = item.Detail.GroupBy(Function(g) g.ProduksiDetail.Main).Select(Function(s) s.Key).ToList
          'Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Gl.Id, BinaryOperatorType.Equal))
          'If Not zdtGL Is Nothing Then
          '	zdtGL.Delete()
          'End If

          ''======= update status produksi
          'Dim produksi = item.Detail.GroupBy(Function(g) g.ProduksiDetail.Main).Select(Function(s) s.Key)
          'For zJ = 0 To produksi.Count - 1
          '	Dim zProduksi = produksi(zJ)
          '	'Dim xQtyProduksi As Double = item.TotalQtyProduksi
          '	'Dim xQtySJSdh As Double = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.ProduksiDetail.Main Is item).Sum(Function(s) s.Qty)
          '	'Dim xQtySJBlm As Double = item.Detail.Where(Function(w) w.ProduksiDetail.Main Is item).Sum(Function(s) s.Qty)

          '	If (xQtySJBlm + xQtySJSdh) = 0 Then
          '		zProduksi.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          '	Else
          '		zProduksi.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
          '	End If
          'Next

          '======= update status so
          Dim soList = item.Detail.Where(Function(w) Not w.SODetail Is Nothing).GroupBy(Function(g) g.SODetail.Main).Select(Function(s) s.Key)
          For zL = 0 To soList.Count - 1
            Dim so = soList(zL)
            Dim sdhSJ = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.SODetail.Main Is so AndAlso Not w.Main Is item)

            If sdhSJ.Count > 0 Then
              so.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
            Else
              so.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
            End If
          Next

          If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, item.Tanggal) Then
            notDeleted.Add(item)
          ElseIf NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(session, item.Tanggal) Then
            notDeleted.Add(item)
          Else
            kodeDelete &= ", " & item.Kode
            item.Delete()
          End If
        Else
          pPending += 1
				End If
			End If
		Next
		session.CommitChanges()
    '======= Simple log
    Try
      If kodeDelete <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Pengiriman Barang [SJ] ->" & kodeDelete.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    'update status transaksi SO
    For i = dtSO.Count - 1 To 0 Step -1
			Dim xpSJ As New XPCollection(Of Persistent.Fusoh_SuratJalan)(session, New BinaryOperator("SO.Id", dtSO(i).Id, BinaryOperatorType.Equal))
			If xpSJ.Count > 0 Then
				dtSO(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
			Else
				dtSO(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
			End If
		Next

		'update status transaksi AM => 02022020
		For i = dtProduksi.Count - 1 To 0 Step -1
			Dim xProduksi = dtProduksi(i)
			Dim banyakSJ As Double = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.ProduksiDetail.Main Is xProduksi).Count
			If banyakSJ > 0 Then
				xProduksi.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
			Else
				xProduksi.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
			End If
		Next

		session.CommitChanges()

    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If

    If notDeleted.Count > 0 Then
      Dim text As String = ""
      For i = 0 To notDeleted.Count - 1
        text &= vbCrLf & notDeleted(i).Kode
      Next
      Utils.Win.MessageBox.Show("Periode yang sudah ditutup tidak dapat dihapus." & vbCrLf & text, "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If

    Return True
	End Function
	Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
		Dim item As Persistent.Fusoh_SuratJalan
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
		Dim result As String = ""
		Dim xSpace As String, KodeBarang As String, NamaBarang As String, Qty As String ', Harga As String
		Dim num As Integer

		Try
			proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
			item = CType(proxy.OriginalRow, Persistent.Fusoh_SuratJalan)

			Dim a = From p In item.Detail

			For i = 0 To a.Count - 1
				KodeBarang = a(i).Barang.Kode
				NamaBarang = a(i).Barang.Nama
				Qty = a(i).Qty.ToString(toStringFormat) & " (" & a(i).Satuan.Kode & ")"
				num = (KodeBarang.Length + NamaBarang.Length + Qty.Length + 3)
				If num >= 80 Then
					xSpace = " "
				Else
					xSpace = Space(80 - num)
				End If

				result += KodeBarang & " (" & NamaBarang & ")" & xSpace & Qty
				If i <> a.Count - 1 Then
					result += vbCrLf
				End If
			Next
			result += vbCrLf
			result += vbCrLf

			Return result
		Catch ex As Exception
			Return ""
		End Try
	End Function
	Overrides Function GetToolTipTitle(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
		Return view.GetRowCellDisplayText(info.RowHandle, colKode)
	End Function
	Private Sub btnPosting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPosting.ItemClick, btnUnPosting.ItemClick, btnClosing.ItemClick, btnResetStatus.ItemClick
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
				setstatus(note, e.Item.Tag)
				RefreshData()
			End If
		End If
	End Sub
	Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
		Dim item As Persistent.Fusoh_SuratJalan, xGagal As Integer, xMessage As String
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
		xGagal = 0
		xMessage = ""
    Dim kodeStatus = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Fusoh_SuratJalan)
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
				ElseIf xTipe = "mereset" Then
					'cek IV nya, jika kosong set ke posting, jika ada set ke finish
					Dim QtySJ = item.TotalQty
					Dim QtyIV = New XPQuery(Of Persistent.Fusoh_InvoicePenjualanDetail)(session).Where(Function(w) w.SuratJalanDetail.Main Is item).Sum(Function(s) s.Qty)

					If QtyIV = 0 Then
						item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
					Else
						If QtySJ > QtyIV Then
							item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
						Else
							item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
						End If
					End If


				End If
      End If
    Next
    session.CommitChanges()
    '======= Simple log
    Try
      If kodeStatus <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Pengiriman Barang [SJ] " & xTipe & " ->" & kodeStatus.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
	Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SJData.xml"))
	End Sub
	Private Sub btnCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetak.ItemClick
		Dim x As Integer() = Nothing

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

		If note.Count > 0 Then
			Dim item As Persistent.Fusoh_SuratJalan
			Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

			proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
			item = CType(proxy.OriginalRow, Persistent.Fusoh_SuratJalan)

      Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.FD)
      Dim salesSetting As New Logic.SalesSetting(session)
			frm.txtNoBukti1.EditValue = item.Kode

			Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
			Dim reportCode As String = ""
			reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherSJ)
			message = String.Format(message, "Pengiriman Barang")
			Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
		End If
	End Sub

	Private Sub btnHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistory.ItemClick
		Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colKode)
		If Not xNoTransaksi Is Nothing Then
			Fusoh_Logic.Umum.xHistoryData(Me, session, UI_FusohCekData.TipeTransaksi.SJ, xNoTransaksi)
		End If
	End Sub

  Private Sub btnShowLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowLog.ItemClick
    If xGridView.IsDataRow(xGridView.FocusedRowHandle) Then
      Dim frm As New Log_FusohData
      frm.session = session
      frm.TipeData = Persistent.SumberDataJenis.SJ
      Dim proxy = CType(xGridView.GetFocusedRow(), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      Dim item = CType(proxy.OriginalRow, Persistent.Fusoh_SuratJalan)
      frm.Kode = item.Kode
      frm.ShowDialog()
    End If
  End Sub
End Class