Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraBars

Friend Class UI_AktivaTetap
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		baseView = xGridView
		KeyField = "p_Id"
	End Sub
	Public Overrides Sub FirstLoad()
		'load setingan default kolom
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("aktivatransaksi.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("aktivatransaksi.xml"))
		End If
		GetSession()
		Dim setting As New Logic.FinaSetting(session)
		colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHarga.DisplayFormat.FormatString = setting.NumericFormatToString
		colHarga.SummaryItem.DisplayFormat = setting.NumericFormatString
		colNilaiResidu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colNilaiResidu.DisplayFormat.FormatString = setting.NumericFormatToString
		colNilaiResidu.SummaryItem.DisplayFormat = setting.NumericFormatString
		colNilaiBuku.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colNilaiBuku.DisplayFormat.FormatString = setting.NumericFormatToString
		colNilaiBuku.SummaryItem.DisplayFormat = setting.NumericFormatString
		colNilaiAmortisasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colNilaiAmortisasi.DisplayFormat.FormatString = setting.NumericFormatToString
		colNilaiAmortisasi.SummaryItem.DisplayFormat = setting.NumericFormatString
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_AktivaDialog
	End Function
	Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
		Dim result As New List(Of Core.Win.Forms.GridDeletedData)
		Dim item As Core.Win.Forms.GridDeletedData

		For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
			If Not xGridView.IsGroupRow(selectedRows(i)) Then
				item = New Core.Win.Forms.GridDeletedData
				item.Row = selectedRows(i)
				item.Data = String.Format("{0} - {1}", xGridView.GetRowCellValue(selectedRows(i), "Kode"), xGridView.GetRowCellValue(selectedRows(i), "Nama"))
				result.Add(item)
			End If
		Next
		Return result
	End Function
	Public Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				CType(xGridView.GetRow(selectedData(i).Row), Persistent.AktivaTetap).Delete()
			End If
		Next
		session.CommitChanges()
		Return True
	End Function
	Public Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("aktivatransaksi.xml"))
	End Sub
	Private Sub btnPembelian_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPembelian.ItemClick
		Dim a As New UI_AktivaTetapPembelian
		a.session = Me.session
		a.ShowDialog()
		xpCol.Reload()
	End Sub
	Private Sub btnSaldoAwal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaldoAwal.ItemClick
		Dim a As New UI_AktivaTetapSaldoAwal
		a.session = Me.session
		a.ShowDialog()
		xpCol.Reload()
	End Sub
	Private Sub btnHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistory.ItemClick
		If Not xGridView.GetFocusedRowCellDisplayText(colKode) Is Nothing Then
			Dim xFrm As New UI_AktivaTetapHistory(xGridView.GetFocusedRowCellDisplayText(colKode))
			xFrm.session = Me.session
			xFrm.OwnerMDI = Me
			xFrm.ShowMDI()
		End If
	End Sub
	Private Sub btnPenyusutan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPenyusutan.ItemClick
		Dim a As New UI_AktivaTetapPenyusutan
		a.session = Me.session
		a.ShowDialog()
		xpCol.Reload()
	End Sub
	Private Sub btnPenjualan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPenjualan.ItemClick
		Dim a As New UI_AktivaTetapPenjualan
		a.session = Me.session
		a.ShowDialog()
		xpCol.Reload()
	End Sub
	Private Sub btnWriteOff_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnWriteOff.ItemClick
		Dim a As New UI_AktivaTetapWriteOff
		a.session = Me.session
		a.ShowDialog()
		xpCol.Reload()
	End Sub
	Private Sub btnResetNilaiAktiva_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetNilaiAktiva.ItemClick
		If MsgBox("Apakah anda ingin mereset nilai transaksi (Penyusutan,Writeoff) seluruh aktiva tetap?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
			Dim xDtAktiva As New XPCollection(Of Persistent.AktivaTetap)(session)
			Dim xNilaiAktiva As Double = 0, xQty As Double = 0, xQtyOut As Double = 0, xPenyusutanPerBulan As Double = 0


			For pRow = 0 To xDtAktiva.Count - 1
				Dim xdtTransaksi As New XPCollection(Of Persistent.AktivaTransaksiDetail)(session, New BinaryOperator("Asset.Kode", xDtAktiva(pRow).Kode, BinaryOperatorType.Equal), New SortProperty("Main.Tanggal", DevExpress.Xpo.DB.SortingDirection.Ascending))
				xQty = xDtAktiva(pRow).Qty
				xNilaiAktiva = xDtAktiva(pRow).Harga
				xPenyusutanPerBulan = xDtAktiva(pRow).Depreciation(0).Nilai
				xQtyOut = 0

				For pI = 0 To xdtTransaksi.Count - 1
					If xdtTransaksi(pI).Main.Tipe = Persistent.eTipeTransaksiAsset.WriteOff Then
						xQty = xQty - xdtTransaksi(pI).Qty
						xdtTransaksi(pI).NilaiKeluar = xNilaiAktiva
						xdtTransaksi(pI).NilaiBuku = xNilaiAktiva
						xQtyOut = xQtyOut + xdtTransaksi(pI).Qty
						xdtTransaksi(pI).Asset.QtyOut = xQtyOut
					End If
					If xdtTransaksi(pI).Main.Tipe = Persistent.eTipeTransaksiAsset.Penyusutan Then
						xdtTransaksi(pI).Qty = xQty
						xNilaiAktiva = xNilaiAktiva - xPenyusutanPerBulan
					End If
				Next
			Next

			session.CommitChanges()
			MsgBox("Proses selesai.")
		End If
	End Sub
	Private Sub btnHapusAktiva_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHapusAktiva.ItemClick
		If MsgBox("Apakah anda ingin menghapus transaksi untuk asset ini?Data yang sudah dihapus tidak bisa dikembalikan lagi.", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then


			'Dim xDtAktiva As New XPCollection(Of Persistent.AktivaTetap)(session)
			'Dim xNilaiAktiva As Double = 0, xQty As Double = 0, xQtyOut As Double = 0, xPenyusutanPerBulan As Double = 0


			'For pRow = 0 To xDtAktiva.Count - 1
			'	Dim xdtTransaksi As New XPCollection(Of Persistent.AktivaTransaksiDetail)(session, New BinaryOperator("Asset.Kode", xDtAktiva(pRow).Kode, BinaryOperatorType.Equal), New SortProperty("Main.Tanggal", DevExpress.Xpo.DB.SortingDirection.Ascending))
			'	xQty = xDtAktiva(pRow).Qty
			'	xNilaiAktiva = xDtAktiva(pRow).Harga
			'	xPenyusutanPerBulan = xDtAktiva(pRow).Depreciation(0).Nilai
			'	xQtyOut = 0

			'	For pI = 0 To xdtTransaksi.Count - 1
			'		If xdtTransaksi(pI).Main.Tipe = Persistent.eTipeTransaksiAsset.WriteOff Then
			'			xQty = xQty - xdtTransaksi(pI).Qty
			'			xdtTransaksi(pI).NilaiKeluar = xNilaiAktiva
			'			xdtTransaksi(pI).NilaiBuku = xNilaiAktiva
			'			xQtyOut = xQtyOut + xdtTransaksi(pI).Qty
			'			xdtTransaksi(pI).Asset.QtyOut = xQtyOut
			'		End If
			'		If xdtTransaksi(pI).Main.Tipe = Persistent.eTipeTransaksiAsset.Penyusutan Then
			'			xdtTransaksi(pI).Qty = xQty
			'			xNilaiAktiva = xNilaiAktiva - xPenyusutanPerBulan
			'		End If
			'	Next
			'Next

			session.CommitChanges()
			MsgBox("Proses selesai.")
		End If
	End Sub
End Class