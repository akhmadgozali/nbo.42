Imports DevExpress.Data.Async.Helpers
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSplashScreen
Imports System.Windows.Forms
Friend Class UI_SaldoAwal
  Private toStringFormat As String
  Sub New()
    InitializeComponent()

    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = False
    useFeedbackSource = True
    ActivateToolTip = True
    UseDbSystem = False
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim a As New Logic.FinaSetting(session)
    colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldo.DisplayFormat.FormatString = a.NumericFormatString
    toStringFormat = a.NumericFormatToString
    Dim sumber As New Persistent.SumberDataCollection(session)

    Dim iList As New List(Of SumberData)
    iList.Add(sumber.GetObject(Persistent.SumberDataJenis.SA))
    Dim CreateCriteria As CriteriaOperator
    CreateCriteria = GroupOperator.And(New InOperator("Sumber", iList), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SaldoAwal.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SaldoAwal.xml"))
    End If

  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_SaldoAwalDialog
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
    Dim item As Persistent.GlMain
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim notDeleted As New List(Of Persistent.GlMain)
    Dim notDeletedPeriode As New List(Of Persistent.GlMain)

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.GlMain)

        If Persistent.Periode.CheckLockedPeriod(session, item.Tanggal) Then
          notDeletedPeriode.Add(item)
        ElseIf item.ModuleId <> MainClass.GetModuleId Then
          notDeleted.Add(item)
        Else
          item.Delete()
        End If
      End If
    Next
    session.CommitChanges()

    If notDeletedPeriode.Count > 0 Then
      Dim text As String = My.Resources.GLDeletedPeriode
      For i = 0 To notDeletedPeriode.Count - 1
        text &= vbCrLf & notDeletedPeriode(i).Kode
      Next
      Utils.Win.MessageBox.Show(text, "Hapus " & Me.Text, My.Resources.GLDeletedPeriodeSolution, Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    If notDeleted.Count > 0 Then
      Dim text As String = My.Resources.GLDeletedModul
      For i = 0 To notDeleted.Count - 1
        text &= vbCrLf & notDeleted(i).Kode
      Next
      Utils.Win.MessageBox.Show(text, "Hapus " & Me.Text, My.Resources.GLDeletedModulSolution, Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If

    Return True
  End Function

	Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SaldoAwal.xml"))
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

						Dim wsName = "SaldoAwal"
						Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
						If Not workSheet Is Nothing Then 'COA	Kontak	MataUang	 Nilai 	 Kurs 	 Valas 	Uraian
							Dim usedRange = workSheet.GetUsedRange()
							Dim cellRegional = FindColumnPosition(workSheet, usedRange, "Regional")
							Dim cellNoTransaksi = FindColumnPosition(workSheet, usedRange, "NoTransaksi")
							Dim cellCOA = FindColumnPosition(workSheet, usedRange, "COA")
							Dim cellKontak = FindColumnPosition(workSheet, usedRange, "Kontak")
							Dim cellMataUang = FindColumnPosition(workSheet, usedRange, "MataUang")
							Dim cellNilai = FindColumnPosition(workSheet, usedRange, "Nilai")
							Dim cellKurs = FindColumnPosition(workSheet, usedRange, "Kurs")
							Dim cellValas = FindColumnPosition(workSheet, usedRange, "Valas")
							Dim cellUraian = FindColumnPosition(workSheet, usedRange, "Uraian")


							Dim listCOA = New XPQuery(Of Persistent.Coa)(session).ToList()
							Dim listKontak = New XPQuery(Of Persistent.Kontak)(session).ToList()
							Dim listUang = New XPQuery(Of Persistent.MataUang)(session).ToList()
							Dim listRegional = New XPQuery(Of NPO.Modules.ModSys.Regional)(session).ToList()
							Dim Setting = New Logic.FinaSetting(session)
							Dim sumber = New Persistent.SumberDataCollection(session)

							Dim xTglSA As Date = New Date(Setting.AwalPeriodeTahun, Setting.AwalPeriodeBulan, 1)

							Dim xGLMain As New XPCollection(Of Persistent.GlMain)(session)
							For i = 1 To usedRange.RowCount - 1
								Dim xNama As String = Trim(workSheet.Cells(i, cellCOA).DisplayText)
								If Trim(xNama) <> "" Then
									Dim cellValueRegional = Trim(workSheet.Cells(i, cellRegional).DisplayText)
									Dim cellValueNoTransaksi = Trim(workSheet.Cells(i, cellNoTransaksi).DisplayText)
									Dim cellValueCOA = Trim(workSheet.Cells(i, cellCOA).DisplayText)
									Dim cellValueKontak = Trim(workSheet.Cells(i, cellKontak).DisplayText)
									Dim cellValueMataUang = Trim(workSheet.Cells(i, cellMataUang).DisplayText)
									Dim cellValueNilai = workSheet.Cells(i, cellNilai).Value.NumericValue
									Dim cellValueKurs = workSheet.Cells(i, cellKurs).Value.NumericValue
									Dim cellValueValas = workSheet.Cells(i, cellValas).Value.NumericValue
									Dim cellValueUraian = Trim(workSheet.Cells(i, cellUraian).DisplayText)

									Dim xRegional = listRegional.Where(Function(w) w.Kode = cellValueRegional).FirstOrDefault
									Dim xCoa = listCOA.Where(Function(w) w.Kode = cellValueCOA).FirstOrDefault
									Dim xUang = listUang.Where(Function(w) w.Kode = cellValueMataUang).FirstOrDefault
									Dim xKontak = listKontak.Where(Function(w) w.Kode = cellValueKontak).FirstOrDefault

									Dim xItem = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = Setting.FormatNomor}}
									xItem.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SA)
									xItem.Regional = xRegional
									xItem.Kode = cellValueNoTransaksi
									xItem.Kontak = xKontak
									xItem.ModuleId = NPO.Modules.ModuleId.Fina
									xItem.Tanggal = xTglSA
									xItem.Uraian = cellValueUraian
									xItem.Akun = xCoa
									xItem.Kurs = cellValueKurs
									xItem.MataUang = xUang.Kode.ToString()
									'detail nya

									If xCoa.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
										SimpanJurnal(xItem, 0, CType(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(Setting.PenampungSaldoAwal)), Persistent.Coa), 0, CType(cellValueNilai, Double), 1, 0, 0)
										SimpanJurnal(xItem, 1, xCoa, CType(cellValueNilai, Double), 0, CType(cellValueKurs, Double), CType(cellValueValas, Double), 0)
									Else
										SimpanJurnal(xItem, 0, CType(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(Setting.PenampungSaldoAwal)), Persistent.Coa), CType(cellValueNilai, Double), 0, 1, 0, 0)
										SimpanJurnal(xItem, 1, xCoa, 0, CType(cellValueNilai, Double), CType(cellValueKurs, Double), 0, CType(cellValueValas, Double))
									End If
									xGLMain.Add(xItem)
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
	Private Sub SimpanJurnal(ByVal instance As Persistent.GlMain, ByVal pUrutan As Byte, pAkun As Persistent.Coa, pDebit As Double, pKredit As Double, pKurs As Double, pDebitValas As Double, pKreditValas As Double)
		Dim item As Persistent.GlMainDetail
		If instance.Detail.ToList.Exists(Function(m) m.Urutan = pUrutan) Then
			item = instance.Detail.Single(Function(m) m.Urutan = pUrutan)
			item.Akun = pAkun
			item.MataUang = pAkun.MataUang
			item.Main = instance
			item.Debit = pDebit
			item.Kredit = pKredit
			item.Kurs = pKurs
			item.DebitValas = pDebitValas
			item.KreditValas = pKreditValas
			item.Divisi = Nothing
		Else
			item = New Persistent.GlMainDetail(session)
			item.Urutan = pUrutan
			item.Akun = pAkun
			item.MataUang = pAkun.MataUang
			item.Main = instance
			item.Debit = pDebit
			item.Kredit = pKredit
			item.Kurs = pKurs
			item.DebitValas = pDebitValas
			item.KreditValas = pKreditValas
			item.Divisi = Nothing
			instance.Detail.Add(item)
		End If
	End Sub
End Class