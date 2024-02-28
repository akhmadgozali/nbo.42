Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSplashScreen
Imports System.Windows.Forms

Public Class UI_SaldoAwal
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		baseView = xGridView
		KeyField = "Main.Id"
		useMDIforDialog = False
		useFeedbackSource = True
		ActivateToolTip = True
		UseDbSystem = False
	End Sub
	Overrides Sub FirstLoad()
		GetSession()
		Dim setting As New NuSoft001.Logic.FinaSetting(session)
		Dim CreateCriteria As CriteriaOperator
		CreateCriteria = GroupOperator.And(New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.BS, BinaryOperatorType.Equal))
		ifSource.FixedFilterCriteria = CreateCriteria
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BSData.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BSData.xml"))
		End If
		colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
		colHargaIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHargaIn.DisplayFormat.FormatString = setting.NumericFormatString
		colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colTotal.DisplayFormat.FormatString = setting.NumericFormatString
		colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_SaldoAwalDialog
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
		Dim item As Persistent.StockDetail, pPending As Integer
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

		pPending = 0
		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
				item = CType(proxy.OriginalRow, Persistent.StockDetail)
				Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Main.Gl.Id, BinaryOperatorType.Equal))
				If Not zdtGL Is Nothing Then
					zdtGL.Delete()
				End If
				item.Main.Delete()
			End If
		Next
		session.CommitChanges()
		Return True
	End Function
	Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("BSData.xml"))
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

						Dim wsName = "SaldoAwalStock"
						Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
						If Not workSheet Is Nothing Then
							Dim usedRange = workSheet.GetUsedRange()
							Dim cellNoTransaksi = FindColumnPosition(workSheet, usedRange, "NoTransaksi")
							Dim cellRegional = FindColumnPosition(workSheet, usedRange, "Regional")
							Dim cellGudang = FindColumnPosition(workSheet, usedRange, "Gudang")
							Dim cellBarang = FindColumnPosition(workSheet, usedRange, "Barang")
							Dim cellQty = FindColumnPosition(workSheet, usedRange, "Qty")
							Dim cellHarga = FindColumnPosition(workSheet, usedRange, "Harga")
							Dim cellKaryawan = FindColumnPosition(workSheet, usedRange, "Karyawan")

							Dim listBarang = New XPQuery(Of Persistent.Barang)(session).ToList()
							Dim listGudang = New XPQuery(Of Persistent.Gudang)(session).ToList()
							Dim listKontak = New XPQuery(Of NuSoft001.Persistent.Kontak)(session).ToList()
							Dim listRegional = New XPQuery(Of NPO.Modules.ModSys.Regional)(session).ToList()
							Dim settingitem = New Logic.ItemSetting(session)
							Dim setting = New NuSoft001.Logic.FinaSetting(session)
							Dim sumber = New Persistent.SumberDataCollection(session)
							Dim xTglSA As Date = New Date(Setting.AwalPeriodeTahun, Setting.AwalPeriodeBulan, 1)
							Dim xMataUangDefault = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))

							Dim xStockMain As New XPCollection(Of Persistent.StockMain)(session)
							For i = 1 To usedRange.RowCount - 1
								Dim xNama As String = Trim(workSheet.Cells(i, cellNoTransaksi).DisplayText)
								If Trim(xNama) <> "" Then
									Dim cellValueRegional = Trim(workSheet.Cells(i, cellRegional).DisplayText)
									Dim cellValueNoTransaksi = Trim(workSheet.Cells(i, cellNoTransaksi).DisplayText)
									Dim cellValueGudang = Trim(workSheet.Cells(i, cellGudang).DisplayText)
									Dim cellValueBarang = Trim(workSheet.Cells(i, cellBarang).DisplayText)
									Dim cellValueQty = workSheet.Cells(i, cellQty).Value.NumericValue
									Dim cellValueHarga = workSheet.Cells(i, cellHarga).Value.NumericValue
									Dim cellValueKaryawan = Trim(workSheet.Cells(i, cellKaryawan).DisplayText)

									Dim xGudang = listGudang.Where(Function(w) w.Kode = cellValueGudang).FirstOrDefault
									Dim xBarang = listBarang.Where(Function(w) w.Kode = cellValueBarang).FirstOrDefault
									Dim xRegional = listRegional.Where(Function(w) w.Kode = cellValueRegional).FirstOrDefault
									Dim xKontak = listKontak.Where(Function(w) w.Kode = cellValueKaryawan).FirstOrDefault

									'If xGudang Is null Then


									'End If

									'jika sudah ada nomor tsb, skip saja.
									If cellValueQty > 0 Then
										Dim xItem As New Persistent.StockMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
										xItem.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
										'xItem.ModuleId = NPO.Modules.ModuleId.Fina
										xItem.Sumber = sumber.GetObject(Persistent.SumberDataJenis.BS)
										xItem.Regional = xRegional
										xItem.Kode = cellValueNoTransaksi
										xItem.Tanggal = xTglSA
										xItem.Gudang = xGudang
										xItem.KaryawanKirim = xKontak
										xItem.MataUang = xMataUangDefault
										xItem.Kurs = 1
										xItem.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
										'detailnya
										Dim zData = New Persistent.StockDetail(session)
										zData.Main = xItem
										zData.Barang = xBarang
										zData.QtyIn = cellValueQty
										zData.Satuan = xBarang.Satuan
										zData.HargaIn = cellValueHarga
										xItem.Detail.Add(zData)
										'GLnya
										xItem.Gl.Sumber = xItem.Sumber
										xItem.Gl.Tanggal = xItem.Tanggal
										xItem.Gl.Regional = xItem.Regional
										xItem.Gl.Kode = xItem.Kode
										xItem.Gl.ModuleId = NPO.Modules.ModuleId.Inventory
										xItem.Gl.MataUang = xMataUangDefault.Simbol
										xItem.Gl.Kurs = 1
										xItem.Gl.Kontak = xKontak
										xItem.Gl.KontakNama = xKontak.Nama
										xItem.Gl.Uraian = "Saldo Awal Persediaan"
										SimpanGL(xItem, xBarang.CoaStock, 1, cellValueHarga * cellValueQty, 0, 0, 0)
										SimpanGL(xItem, session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(setting.PenampungSaldoAwal)), 2, 0, cellValueHarga * cellValueQty, 0, 0, "")
										xStockMain.Add(xItem)
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
	Private Sub SimpanGL(Instance As Persistent.StockMain, Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "")
		Dim item As Persistent.GlMainDetail
		If Instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
			item = Instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
			item.Akun = Akun
			item.MataUang = item.Akun.MataUang
			item.Main = Instance.Gl
			item.Urutan = Urutan
			item.Debit = Debit
			item.Kredit = Kredit
			item.Keterangan = Catatan
			item.DebitValas = 0
			item.KreditValas = 0
			item.Kurs = 1
		Else
			item = New Persistent.GlMainDetail(session)
			item.Akun = Akun
			item.MataUang = item.Akun.MataUang
			item.Main = Instance.Gl
			item.Urutan = Urutan
			item.Debit = Debit
			item.Kredit = Kredit
			item.Keterangan = Catatan
			item.DebitValas = 0
			item.KreditValas = 0
			item.Kurs = 1
			Instance.Gl.Detail.Add(item)
		End If
	End Sub
End Class