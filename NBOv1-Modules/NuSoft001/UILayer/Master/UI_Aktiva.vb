Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSplashScreen
Imports System.Windows.Forms
Friend Class UI_Aktiva
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		baseView = xGridView
		KeyField = "Id"
	End Sub
	Public Overrides Sub FirstLoad()
		'load setingan default kolom
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masteraktiva.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masteraktiva.xml"))
		End If
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
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("masteraktiva.xml"))
	End Sub
	Private Sub btnResetUlang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetUlang.ItemClick

		If MsgBox("Apakah anda yakin ingin membuat ulang tabel penyusutan?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
			Dim xDataAsset As New DevExpress.Xpo.XPCollection(Of Persistent.AktivaTetap)(session)
			For pK = 0 To xDataAsset.Count - 1
				'create tabel penyusutannya
				Dim TipePenyusutan As Persistent.ePenyusutanAsset
				Dim xHarga As Double, xResidu As Double, xUmur As Long, txtNilaiPenyusutan As Double

				TipePenyusutan = xDataAsset(pK).Kelompok.TipePenyusutan
				xHarga = xDataAsset(pK).Harga
				xResidu = xDataAsset(pK).NilaiResidu
				xUmur = xDataAsset(pK).Kelompok.Umur

				Dim xDate As Date = xDataAsset(pK).TanggalBeli, xSisaUmur As Long = xUmur, pI As Integer = 1
				txtNilaiPenyusutan = (xHarga - xResidu) / xUmur
				xSisaUmur = xUmur
				If TipePenyusutan = Persistent.ePenyusutanAsset.TanpaPenyusutan Then
					xSisaUmur = 0
					txtNilaiPenyusutan = 0
				End If

				If xDataAsset(pK).Tgl15 = True Then
					If xDataAsset(pK).TanggalBeli.Day > 15 Then
						xDate = DateAdd(DateInterval.Month, 1, xDate)
					End If
				End If

				Do While xSisaUmur > 0
					Dim detail As Persistent.AktivaTetapPenyusutan = xDataAsset(pK).Depreciation.ToList.Find(Function(m) m.Sequence = pI)
					If detail Is Nothing Then
						detail = New Persistent.AktivaTetapPenyusutan(session)
						detail.Sequence = pI
						xDataAsset(pK).Depreciation.Add(detail)
					End If
					If pI = 1 Then
						detail.Month = CShort(13 - Month(xDate))
					Else
						If xSisaUmur > 11 Then
							detail.Month = 12
						Else
							detail.Month = CShort(xSisaUmur)
						End If
					End If
					detail.Sequence = pI
					detail.Year = Year(xDate)
					detail.TglAwal = xDate
					xDate = DateAdd(DateInterval.Month, detail.Month - 1, xDate)
					detail.TglAkhir = xDate
					detail.Nilai = txtNilaiPenyusutan
					xSisaUmur = xSisaUmur - detail.Month
					xDate = DateAdd(DateInterval.Month, 1, xDate)
					pI = pI + 1
				Loop

				For i = xDataAsset(pK).Depreciation.Count - 1 To pI - 1 Step -1
					xDataAsset(pK).Depreciation(i).Delete()
				Next

				If TipePenyusutan = Persistent.ePenyusutanAsset.SaldoMenurun Then
					Dim xNilaiPenyusutan As Double, xNilaiBuku As Double, xPresentase As Double
					xPresentase = 200 / (xUmur)
					xNilaiBuku = CDbl(xDataAsset(pK).Harga) - CDbl(xDataAsset(pK).NilaiResidu)

					For i = 0 To xDataAsset(pK).Depreciation.Count - 1
						If i = xDataAsset(pK).Depreciation.Count - 1 Then
							xNilaiPenyusutan = xNilaiBuku / xDataAsset(pK).Depreciation(i).Month
						Else
							xNilaiPenyusutan = (xPresentase / 100 * xNilaiBuku) / 12
						End If
						xDataAsset(pK).Depreciation(i).Nilai = xNilaiPenyusutan
						xNilaiBuku = xNilaiBuku - (xDataAsset(pK).Depreciation(i).Total)
					Next
				End If
			Next
			session.CommitChanges()
			MsgBox("Proses selesai.")
		End If
	End Sub
	Private Sub btnImporData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImporData.ItemClick
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

						Dim wsName = "AktivaTetap"
						Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
						If Not workSheet Is Nothing Then 'Regional	Kelompok	Kode	Nama	Umur	Qty	HargaBeli	NilaiResidu	TanggalBeli	TanggalPakai	Tgl15	AktivaTidakBerwujud
							Dim usedRange = workSheet.GetUsedRange()
							Dim cellRegional = FindColumnPosition(workSheet, usedRange, "Regional")
							Dim cellKelompok = FindColumnPosition(workSheet, usedRange, "Kelompok")
							Dim cellKode = FindColumnPosition(workSheet, usedRange, "Kode")
							Dim cellNama = FindColumnPosition(workSheet, usedRange, "Nama")
							Dim cellUmur = FindColumnPosition(workSheet, usedRange, "Umur")
							Dim cellQty = FindColumnPosition(workSheet, usedRange, "Qty")
							Dim cellHargaBeli = FindColumnPosition(workSheet, usedRange, "HargaBeli")
							Dim cellNilaiResidu = FindColumnPosition(workSheet, usedRange, "NilaiResidu")
							Dim cellTanggalBeli = FindColumnPosition(workSheet, usedRange, "TanggalBeli")
							Dim cellTanggalPakai = FindColumnPosition(workSheet, usedRange, "TanggalPakai")
							Dim cellTgl15 = FindColumnPosition(workSheet, usedRange, "Tgl15")
							Dim cellAktivaTidakBerwujud = FindColumnPosition(workSheet, usedRange, "AktivaTidakBerwujud")

							Dim listRegional = New XPQuery(Of NPO.Modules.ModSys.Regional)(session).ToList()
							Dim listKelompok = New XPQuery(Of Persistent.AktivaKelompok)(session).ToList()

							Dim xAktiva As New XPCollection(Of Persistent.AktivaTetap)(session)
							For i = 1 To usedRange.RowCount - 1
								Dim xNama As String = Trim(workSheet.Cells(i, cellKode).DisplayText)
								If Trim(xNama) <> "" Then
									Dim cellValueRegional = Trim(workSheet.Cells(i, cellRegional).DisplayText)
									Dim cellValueKelompok = Trim(workSheet.Cells(i, cellKelompok).DisplayText)
									Dim cellValueKode = Trim(workSheet.Cells(i, cellKode).DisplayText)
									Dim cellValueNama = Trim(workSheet.Cells(i, cellNama).DisplayText)
									Dim cellValueUmur = Trim(workSheet.Cells(i, cellUmur).DisplayText)
									Dim cellValueQty = workSheet.Cells(i, cellQty).Value.NumericValue
									Dim cellValueHargaBeli = workSheet.Cells(i, cellHargaBeli).Value.NumericValue
									Dim cellValueNilaiResidu = workSheet.Cells(i, cellNilaiResidu).Value.NumericValue
									Dim cellValueTanggalBeli = Trim(workSheet.Cells(i, cellTanggalBeli).DisplayText)
									Dim cellValueTanggalPakai = Trim(workSheet.Cells(i, cellTanggalPakai).DisplayText)

									Dim xRegional = listRegional.Where(Function(w) w.Kode = cellValueRegional).FirstOrDefault
									Dim xKelompok = listKelompok.Where(Function(w) w.Kode = cellValueKelompok).FirstOrDefault
									Dim xTglBeli As Date = DateTime.Parse(cellValueTanggalBeli)
									Dim xTglPakai As Date = DateTime.Parse(cellValueTanggalPakai)


									Dim xItem As New Persistent.AktivaTetap(session)
									xItem.Regional = xRegional
									xItem.Kelompok = xKelompok
									xItem.Kode = cellValueKode
									xItem.Nama = cellValueNama
									xItem.Qty = cellValueQty
									xItem.Harga = cellValueHargaBeli
									xItem.NilaiResidu = cellValueNilaiResidu
									xItem.TanggalBeli = xTglBeli
									xItem.TanggalPakai = xTglPakai
									xItem.Tgl15 = False
									xItem.Intangible = False
									HitungPenyusutan(xItem, xKelompok, xTglBeli, cellValueHargaBeli, cellValueNilaiResidu, xKelompok.Umur, False)
									xAktiva.Add(xItem)
								End If
							Next
						End If
					End Using
				End Using
				session.CommitChanges()
				If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
				MessageBox.Show("Impor Data Selesai. Silahkan tutup form ini", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
	Sub HitungPenyusutan(instance As Persistent.AktivaTetap, txtKelompok As Persistent.AktivaKelompok, txtTglBeli As Date, txtHargaBeli As Double, txtNilaiResidu As Double, txtUmur As Double, txtTgl15 As Boolean) 'TipePenyusutan As Persistent.ePenyusutanAsset, xHarga As Double, xResidu As Double, xUmur As Long
		Dim TipePenyusutan As Persistent.ePenyusutanAsset
		Dim xHarga As Double, xResidu As Double, xUmur As Long, txtNilaiPenyusutan As Double

		TipePenyusutan = txtKelompok.TipePenyusutan
		xHarga = CDbl(txtHargaBeli)
		xResidu = CDbl(txtNilaiResidu)
		xUmur = CLng(txtUmur)

		Dim xDate As Date = txtTglBeli, xSisaUmur As Long = CType(txtUmur, Long), pI As Integer = 1
		txtNilaiPenyusutan = (xHarga - xResidu) / xUmur
		xSisaUmur = xUmur
		If CType(txtKelompok, Persistent.AktivaKelompok).TipePenyusutan = Persistent.ePenyusutanAsset.TanpaPenyusutan Then
			xSisaUmur = 0
			txtNilaiPenyusutan = 0
		End If

		If txtTgl15 = True Then
			If txtTglBeli.Day > 15 Then
				xDate = DateAdd(DateInterval.Month, 1, xDate)
			End If
		End If

		Do While xSisaUmur > 0
			Dim detail As Persistent.AktivaTetapPenyusutan = instance.Depreciation.ToList.Find(Function(m) m.Sequence = pI)
			If detail Is Nothing Then
				detail = New Persistent.AktivaTetapPenyusutan(session)
				detail.Sequence = pI
				instance.Depreciation.Add(detail)
			End If
			If pI = 1 Then
				detail.Month = CShort(13 - Month(xDate))
			Else
				If xSisaUmur > 11 Then
					detail.Month = 12
				Else
					detail.Month = CShort(xSisaUmur)
				End If
			End If
			detail.Asset = instance
			detail.Sequence = pI
			detail.Year = Year(xDate)
			detail.TglAwal = xDate
			xDate = DateAdd(DateInterval.Month, detail.Month - 1, xDate)
			detail.TglAkhir = xDate
			detail.Nilai = CType(txtNilaiPenyusutan, Double)
			xSisaUmur = xSisaUmur - detail.Month
			xDate = DateAdd(DateInterval.Month, 1, xDate)
			pI = pI + 1
		Loop

		For i = instance.Depreciation.Count - 1 To pI - 1 Step -1
			instance.Depreciation(i).Delete()
		Next

		If TipePenyusutan = Persistent.ePenyusutanAsset.SaldoMenurun Then
			Dim xNilaiPenyusutan As Double, xNilaiBuku As Double, xPresentase As Double
			xPresentase = 200 / (CDbl(txtUmur) / 12)
			xNilaiBuku = CDbl(txtHargaBeli) - CDbl(txtNilaiResidu)

			For i = 0 To instance.Depreciation.Count - 1
				If i = instance.Depreciation.Count - 1 Then
					xNilaiPenyusutan = xNilaiBuku / instance.Depreciation(i).Month
				Else
					xNilaiPenyusutan = (xPresentase / 100 * xNilaiBuku) / 12
				End If
				instance.Depreciation(i).Nilai = xNilaiPenyusutan
				xNilaiBuku = xNilaiBuku - (instance.Depreciation(i).Total)
			Next
		End If
	End Sub
End Class