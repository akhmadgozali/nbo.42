Imports DevExpress.Xpo
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSplashScreen
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering

Public Class UI_Barang
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		baseView = xGridView
		KeyField = "Id"
		xGridView.OptionsDetail.EnableMasterViewMode = False
	End Sub
	Public Overrides Sub FirstLoad()
		Dim settingitem As Logic.ItemSetting
		Dim setting As New NuSoft001.Logic.FinaSetting(GetSession)
		settingitem = New Logic.ItemSetting(GetSession)
		colCustom1.Caption = settingitem.CustomItem1
		colCustom2.Caption = settingitem.CustomItem2
		colCustom3.Caption = settingitem.CustomItem3
		colCustom4.Caption = settingitem.CustomItem4
		colCustom5.Caption = settingitem.CustomItem5

		colHargaBeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHargaBeli.DisplayFormat.FormatString = setting.NumericFormatString
		colHargaJual1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHargaJual1.DisplayFormat.FormatString = setting.NumericFormatString
		colHargaJual2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHargaJual2.DisplayFormat.FormatString = setting.NumericFormatString
		colHargaJual3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHargaJual3.DisplayFormat.FormatString = setting.NumericFormatString
		colHargaJual4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHargaJual4.DisplayFormat.FormatString = setting.NumericFormatString
		colHargaJual5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHargaJual5.DisplayFormat.FormatString = setting.NumericFormatString
    colFeeAgen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colFeeAgen.DisplayFormat.FormatString = setting.NumericFormatString
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masteritem.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masteritem.xml"))
    End If
  End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_BarangDialog
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
				CType(xGridView.GetRow(selectedData(i).Row), Persistent.Barang).Delete()
			End If
		Next
		session.CommitChanges()
		Return True
	End Function
	Public Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("masteritem.xml"))
	End Sub
	Private Sub btnLokasi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLokasi.ItemClick
		Dim frm As New UI_BarangLokasi(session)
		frm.session = session
		frm.MenuId = Me.MenuId
		frm.NamaDatabase = Me.NamaDatabase
		frm.ShowDialog()
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

						Dim wsName = "Barang"
						Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
						If Not workSheet Is Nothing Then 'Jenis	Tipe	Kode	NamaBarang	Satuan	Uang	HargaBeli	HargaJual	 StockMaksimal 	 StockMinimal 	Remarks
							Dim usedRange = workSheet.GetUsedRange()
							Dim cellJenis = FindColumnPosition(workSheet, usedRange, "Jenis")
							Dim cellTipe = FindColumnPosition(workSheet, usedRange, "Tipe")
							Dim cellKode = FindColumnPosition(workSheet, usedRange, "Kode")
							Dim cellNamaBarang = FindColumnPosition(workSheet, usedRange, "NamaBarang")
							Dim cellSatuan = FindColumnPosition(workSheet, usedRange, "Satuan")
							Dim cellUang = FindColumnPosition(workSheet, usedRange, "Uang")

							Dim cellHargaBeli = FindColumnPosition(workSheet, usedRange, "HargaBeli")
							Dim cellHargaJual = FindColumnPosition(workSheet, usedRange, "HargaJual")
							Dim cellStockMaksimal = FindColumnPosition(workSheet, usedRange, "StockMaksimal")
							Dim cellStockMinimal = FindColumnPosition(workSheet, usedRange, "StockMinimal")
							Dim cellRemarks = FindColumnPosition(workSheet, usedRange, "Remarks")

							Dim cellCOAPersediaan = FindColumnPosition(workSheet, usedRange, "COAPersediaan")
							Dim cellCOAPendapatan = FindColumnPosition(workSheet, usedRange, "COAPendapatan")
							Dim cellCOAHPP = FindColumnPosition(workSheet, usedRange, "COABiaya")

							Dim listSatuan = New XPQuery(Of Persistent.Satuan)(session).ToList() ' Divisi > (session).ToList();
							Dim listUang = New XPQuery(Of NuSoft001.Persistent.MataUang)(session).ToList() ' Divisi > (session).ToList();
							Dim listCOA = New XPQuery(Of NuSoft001.Persistent.Coa)(session).ToList() ' Divisi > (session).ToList();
							Dim settingitem = New Logic.ItemSetting(session)

							Dim xBarang As New XPCollection(Of Persistent.Barang)(session)
							For i = 1 To usedRange.RowCount - 1
								Dim xNama As String = Trim(workSheet.Cells(i, cellKode).DisplayText)
								If Trim(xNama) <> "" Then
									Dim cellJenisValue = Trim(workSheet.Cells(i, cellJenis).DisplayText)
									Dim cellTipeValue = Trim(workSheet.Cells(i, cellTipe).DisplayText)
									Dim cellSatuanValue = Trim(workSheet.Cells(i, cellSatuan).DisplayText)
									Dim cellUangValue = Trim(workSheet.Cells(i, cellUang).DisplayText)
									Dim xJenis As Persistent.JenisBarang = CType([Enum].Parse(GetType(Persistent.JenisBarang), cellJenisValue), Persistent.JenisBarang)
									Dim xTipe As Persistent.TipeBarang = CType([Enum].Parse(GetType(Persistent.TipeBarang), cellTipeValue), Persistent.TipeBarang)

									Dim cellCoaPersediaanValue = Trim(workSheet.Cells(i, cellCOAPersediaan).DisplayText)
									Dim cellCoaPendapatanValue = Trim(workSheet.Cells(i, cellCOAPendapatan).DisplayText)
									Dim cellCoaHPPValue = Trim(workSheet.Cells(i, cellCOAHPP).DisplayText)

									Dim xSatuan = listSatuan.Where(Function(w) w.Kode = cellSatuanValue).FirstOrDefault
									Dim xUang = listUang.Where(Function(w) w.Kode = cellUangValue).FirstOrDefault

									Dim xItem As New Persistent.Barang(session)
									xItem.Kode = Trim(workSheet.Cells(i, cellKode).DisplayText)
									xItem.Nama = Trim(workSheet.Cells(i, cellNamaBarang).DisplayText)
									xItem.Jenis = xJenis
									xItem.TipeBarang = xTipe
									xItem.Satuan = xSatuan
									xItem.SatuanD = xSatuan
									xItem.Uang = xUang
									xItem.LastPurchase = workSheet.Cells(i, cellHargaBeli).Value.NumericValue
									xItem.HargaJual1 = workSheet.Cells(i, cellHargaJual).Value.NumericValue
									xItem.StockMax = workSheet.Cells(i, cellStockMaksimal).Value.NumericValue
									xItem.StockMin = workSheet.Cells(i, cellStockMinimal).Value.NumericValue
									xItem.Note = workSheet.Cells(i, cellRemarks).DisplayText


									'xItem.CoaStock = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPersediaan))
									'xItem.CoaIncome = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPendapatan))
									'xItem.CoaCost = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunHPP))
									xItem.CoaStock = listCOA.Where(Function(w) w.Kode = cellCoaPersediaanValue).FirstOrDefault
									xItem.CoaIncome = listCOA.Where(Function(w) w.Kode = cellCoaPendapatanValue).FirstOrDefault
									xItem.CoaCost = listCOA.Where(Function(w) w.Kode = cellCoaHPPValue).FirstOrDefault

									xItem.CoaDiscIncome = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPenjualan))
									xItem.CoaDiscOut = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPembelian))
									xItem.CoaReturnIn = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPenjualan))
									xItem.CoaReturnOut = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPembelian))
									xItem.PajakIN = session.GetObjectByKey(Of Persistent.Pajak)(Convert.ToInt32(settingitem.PajakIN))
									xItem.PajakOUT = session.GetObjectByKey(Of Persistent.Pajak)(Convert.ToInt32(settingitem.PajakOut))

									xBarang.Add(xItem)
								End If
							Next
						End If
					End Using
				End Using
				'xGrid.Refresh()
				'xGrid.RefreshDataSource()
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
	Private Sub btnImporAssembly_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImporAssembly.ItemClick
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

						Dim wsName = "BarangAssembly"
						Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
						If Not workSheet Is Nothing Then 'Kode	NamaBarang	KodePenyusun	NamaPenyusun	Qty	Remarks
							Dim usedRange = workSheet.GetUsedRange()
							Dim cellKode = FindColumnPosition(workSheet, usedRange, "Kode")
							Dim cellNamaBarang = FindColumnPosition(workSheet, usedRange, "NamaBarang")
							Dim cellKodePenyusun = FindColumnPosition(workSheet, usedRange, "KodePenyusun")
							Dim cellNamaPenyusun = FindColumnPosition(workSheet, usedRange, "NamaPenyusun")
							Dim cellQty = FindColumnPosition(workSheet, usedRange, "Qty")
							Dim cellRemarks = FindColumnPosition(workSheet, usedRange, "Remarks")

							Dim listBarang = New XPQuery(Of Persistent.Barang)(session).ToList() ' Divisi > (session).ToList();

							For i = 1 To usedRange.RowCount - 1
								Dim xNama As String = Trim(workSheet.Cells(i, cellKode).DisplayText)
								If Trim(xNama) <> "" Then
									Dim cellValueKode = Trim(workSheet.Cells(i, cellKode).DisplayText)
									Dim xBarang As New XPCollection(Of Persistent.Barang)(session, New BinaryOperator("Kode", cellValueKode, BinaryOperatorType.Equal))
									If xBarang.Count > 0 Then
										Dim pBarang = xBarang(0)

										Dim cellValueKodePenyusun = Trim(workSheet.Cells(i, cellKodePenyusun).DisplayText)
										Dim cellValueQty = workSheet.Cells(i, cellQty).Value.NumericValue
										Dim cellValueRemarks = Trim(workSheet.Cells(i, cellRemarks).DisplayText)

										Dim xPenyusun = listBarang.Where(Function(w) w.Kode = cellValueKodePenyusun).FirstOrDefault

										Dim xItem As New Persistent.BarangAssembly(session)
										xItem.Barang = pBarang
										xItem.BarangPenyusun = xPenyusun
										xItem.Qty = cellValueQty
										xItem.Satuan = xPenyusun.Satuan
										xItem.Catatan = cellValueRemarks
										pBarang.ItemPenyusun.Add(xItem)
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
End Class