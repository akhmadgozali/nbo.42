Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Imports NuSoft.NPO.Modules.ModSys
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSplashScreen
Imports System.Windows.Forms
Public Class UI_SaldoAwalHutang
  Private toStringFormat As String
  Sub New()
    InitializeComponent()

    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = False
    useFeedbackSource = True
    ActivateToolTip = False
    UseDbSystem = False
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim Setting As New NuSoft001.Logic.FinaSetting(GetSession)
    Dim CreateCriteria As CriteriaOperator
    toStringFormat = Setting.NumericFormatToString
    colValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colValas.DisplayFormat.FormatString = Setting.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = Setting.NumericFormatString
    colNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilai.DisplayFormat.FormatString = Setting.NumericFormatString
    colNilai.SummaryItem.DisplayFormat = Setting.NumericFormatString
    CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.BP, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria
    btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnposting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BPData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BPData.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_SaldoAwalHutangDialog
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
    Dim item As Persistent.PenerimaanInvoice, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.PenerimaanInvoice)
        If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Or item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
          Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Gl.Id, BinaryOperatorType.Equal))
          If Not zdtGL Is Nothing Then
            zdtGL.Delete()
          End If

          item.Delete()
        Else
          pPending += 1
        End If
      End If
    Next
    session.CommitChanges()
    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    Return True
  End Function
 
  Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
    Dim item As Persistent.PenerimaanInvoice, xGagal As Integer, xMessage As String
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.PenerimaanInvoice)
        If xTipe = "memposting" Then
          xMessage = "Hanya transaksi pending yang bisa dirubah statusnya menjadi posting."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengunposting" Then
          xMessage = "Hanya transaksi posting yang bisa dirubah statusnya menjadi pending."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengclosing" Then
          xMessage = "Transaksi yang sudah selesai tidak dapat diclose."
          If Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish Or item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed
          Else
            xGagal += 1
          End If
        End If
      End If
    Next
    session.CommitChanges()
    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
	Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("BPData.xml"))
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

						Dim wsName = "SaldoAwalHutang"
						Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
						If Not workSheet Is Nothing Then 'NoTransaksi	Regional	Kontak	Nilai	Uang	Kurs	Valas	Keterangan
							Dim usedRange = workSheet.GetUsedRange()
							Dim cellRegional = FindColumnPosition(workSheet, usedRange, "Regional")
							Dim cellNoTransaksi = FindColumnPosition(workSheet, usedRange, "NoTransaksi")
							Dim cellKontak = FindColumnPosition(workSheet, usedRange, "Kontak")
							Dim cellMataUang = FindColumnPosition(workSheet, usedRange, "Uang")
							Dim cellNilai = FindColumnPosition(workSheet, usedRange, "Nilai")
							Dim cellKurs = FindColumnPosition(workSheet, usedRange, "Kurs")
							Dim cellValas = FindColumnPosition(workSheet, usedRange, "Valas")
							Dim cellKeterangan = FindColumnPosition(workSheet, usedRange, "Keterangan")


							Dim listKontak = New XPQuery(Of NuSoft001.Persistent.Kontak)(session).ToList()
							Dim listUang = New XPQuery(Of NuSoft001.Persistent.MataUang)(session).ToList()
							Dim listRegional = New XPQuery(Of NPO.Modules.ModSys.Regional)(session).ToList()
							Dim Setting = New NuSoft001.Logic.FinaSetting(session)
							Dim SettingPurchase = New Logic.PurchaseSetting(session)
							Dim sumber = New Persistent.SumberDataCollection(session)

							Dim xTglSA As Date = New Date(Setting.AwalPeriodeTahun, Setting.AwalPeriodeBulan, 1)

							Dim xPenerimaanInvoice As New XPCollection(Of Persistent.PenerimaanInvoice)(session)
							For i = 1 To usedRange.RowCount - 1
								Dim xNama As String = Trim(workSheet.Cells(i, cellNoTransaksi).DisplayText)
								If Trim(xNama) <> "" Then
									Dim cellValueRegional = Trim(workSheet.Cells(i, cellRegional).DisplayText)
									Dim cellValueNoTransaksi = Trim(workSheet.Cells(i, cellNoTransaksi).DisplayText)
									Dim cellValueKontak = Trim(workSheet.Cells(i, cellKontak).DisplayText)
									Dim cellValueMataUang = Trim(workSheet.Cells(i, cellMataUang).DisplayText)
									Dim cellValueNilai = workSheet.Cells(i, cellNilai).Value.NumericValue
									Dim cellValueKurs = workSheet.Cells(i, cellKurs).Value.NumericValue
									Dim cellValueValas = workSheet.Cells(i, cellValas).Value.NumericValue
									Dim cellValueKeterangan = Trim(workSheet.Cells(i, cellKeterangan).DisplayText)

									Dim xRegional = listRegional.Where(Function(w) w.Kode = cellValueRegional).FirstOrDefault
									Dim xUang = listUang.Where(Function(w) w.Kode = cellValueMataUang).FirstOrDefault
									Dim xKontak = listKontak.Where(Function(w) w.Kode = cellValueKontak).FirstOrDefault

									Dim xItem = New Persistent.PenerimaanInvoice(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = Setting.FormatNomor}}
									xItem.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = Setting.FormatNomor}}
									xItem.Sumber = sumber.GetObject(Persistent.SumberDataJenis.BP)
									xItem.Tanggal = xTglSA
									xItem.Regional = xRegional
									xItem.Kode = cellValueNoTransaksi
									xItem.Vendor = xKontak
									xItem.Uang = xUang
									xItem.Kurs = cellValueKurs
									If xItem.Uang.Id = Setting.MultiMataUangDefault Then
										xItem.NilaiSaldoAwal = cellValueNilai
									Else
										xItem.NilaiSaldoAwal = cellValueValas
									End If
									xItem.Catatan = cellValueKeterangan
									xItem.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
									'==== jurnalnya
									xItem.Gl.Sumber = xItem.Sumber
									xItem.Gl.Tanggal = xItem.Tanggal
									xItem.Gl.Regional = xItem.Regional
									xItem.Gl.Kode = xItem.Kode
									xItem.Gl.ModuleId = NPO.Modules.ModuleId.Purchase
									xItem.Gl.MataUang = xItem.Uang.Simbol
									xItem.Gl.Kurs = cellValueKurs
									xItem.Gl.Kontak = xKontak
									xItem.Gl.KontakNama = xKontak.Nama
									xItem.Gl.Uraian = cellValueKeterangan
									SimpanGL(xItem, Setting, xUang.HutangDagang, 1, 0, cellValueNilai, 0, cellValueValas, cellValueKurs)
									SimpanGL(xItem, Setting, session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(Setting.PenampungSaldoAwal)), 2, cellValueNilai, 0, 0, 0, cellValueKurs, "")
									xPenerimaanInvoice.Add(xItem)
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
	Private Sub SimpanGL(instance As Persistent.PenerimaanInvoice, Setting As NuSoft001.Logic.FinaSetting, Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Kurs As Double, Optional Catatan As String = "")
		Dim item As Persistent.GlMainDetail
		If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
			item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
			item.Akun = Akun
			item.MataUang = item.Akun.MataUang
			item.Main = instance.Gl
			item.Urutan = Urutan
			item.Debit = Debit
			item.Kredit = Kredit
			item.Keterangan = Catatan
			If Akun.MataUang.Id = Setting.MultiMataUangDefault Then
				item.DebitValas = 0
				item.KreditValas = 0
				item.Kurs = 1
			Else
				item.DebitValas = DebitValas
				item.KreditValas = KreditValas
				item.Kurs = Kurs
			End If
		Else
			item = New Persistent.GlMainDetail(session)

			item.Akun = Akun
			item.MataUang = item.Akun.MataUang
			item.Main = instance.Gl
			item.Urutan = Urutan
			item.Debit = Debit
			item.Kredit = Kredit
			item.Keterangan = Catatan
			If Akun.MataUang.Id = Setting.MultiMataUangDefault Then
				item.DebitValas = 0
				item.KreditValas = 0
				item.Kurs = 1
			Else
				item.DebitValas = DebitValas
				item.KreditValas = KreditValas
				item.Kurs = Kurs
			End If
			instance.Gl.Detail.Add(item)
		End If
	End Sub

End Class