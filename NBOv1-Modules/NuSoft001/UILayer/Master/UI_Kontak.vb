Imports DevExpress.Xpo
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSplashScreen
Imports System.Windows.Forms
Friend Class UI_Kontak
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		baseView = xGridView
		KeyField = "Id"
	End Sub
	Public Overrides Sub FirstLoad()
		'load setingan default kolom
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterkontak.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterkontak.xml"))
		End If
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_KontakDialog
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
				CType(xGridView.GetRow(selectedData(i).Row), Persistent.Kontak).Delete()
			End If
		Next
		session.CommitChanges()
		Return True
	End Function
	Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("masterkontak.xml"))
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

						Dim wsName = "Kontak"
						Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
						If Not workSheet Is Nothing Then 'Kategori	Kode	Nama	JenisKelamin	AlamatPajak
							Dim usedRange = workSheet.GetUsedRange()
							Dim cellKategori = FindColumnPosition(workSheet, usedRange, "Kategori")
							Dim cellKode = FindColumnPosition(workSheet, usedRange, "Kode")
							Dim cellNama = FindColumnPosition(workSheet, usedRange, "Nama")
							Dim cellJenisKelamin = FindColumnPosition(workSheet, usedRange, "JenisKelamin")
							Dim cellAlamatPajak = FindColumnPosition(workSheet, usedRange, "AlamatPajak")

							Dim listKategori = New XPQuery(Of Persistent.TipeKontak)(session).ToList() ' Divisi > (session).ToList();

							Dim xKontak As New XPCollection(Of Persistent.Kontak)(session)
							For i = 1 To usedRange.RowCount - 1
								Dim xNama As String = Trim(workSheet.Cells(i, cellKode).DisplayText)
								If Trim(xNama) <> "" Then
									Dim cellJenisKelaminValue = Trim(workSheet.Cells(i, cellJenisKelamin).DisplayText)
									Dim cellKategoriValue = Trim(workSheet.Cells(i, cellKategori).DisplayText)
									Dim xJenisKelamin As Persistent.eJenisKelamin = CType([Enum].Parse(GetType(Persistent.eJenisKelamin), cellJenisKelaminValue), Persistent.eJenisKelamin)

									Dim xKategori = listKategori.Where(Function(w) w.Nama = cellKategoriValue).FirstOrDefault

									Dim xKodeValue = Trim(workSheet.Cells(i, cellKode).DisplayText)

									Dim zDtKontak = xKontak.Where(Function(w) w.Kode = xKodeValue).ToList()

									If zDtKontak.Count = 0 Then
										Dim xItem As New Persistent.Kontak(session)
										xItem.Kode = Trim(workSheet.Cells(i, cellKode).DisplayText)
										xItem.Nama = Trim(workSheet.Cells(i, cellNama).DisplayText)
										xItem.TipeKontak = xKategori
										xItem.JenisKelamin = xJenisKelamin
										xItem.Alamat = Trim(workSheet.Cells(i, cellAlamatPajak).DisplayText)
										xItem.Aktif = True
										xKontak.Add(xItem)
									End If
								End If
							Next
						End If
					End Using
				End Using
				session.CommitChanges()
				xGrid.Refresh()
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

End Class