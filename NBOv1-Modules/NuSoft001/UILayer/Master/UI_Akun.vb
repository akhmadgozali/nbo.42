Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSplashScreen
Imports System.Windows.Forms
Friend Class UI_Akun
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    KeyField = "Id"
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("mastercoa.xml")) = True Then
      xTree.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("mastercoa.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputDialog
    Return New UI_AkunDialog
  End Function
  Overrides Function GetKeteranganHapus(selectedRows As DevExpress.XtraTreeList.TreeListMultiSelection) As System.Collections.Generic.List(Of Core.Win.Forms.TreeDeletedData)
    Dim result As New System.Collections.Generic.List(Of Core.Win.Forms.TreeDeletedData)
    Dim item As Core.Win.Forms.TreeDeletedData

    For Each i As DevExpress.XtraTreeList.Nodes.TreeListNode In xTree.Selection
      item = New Core.Win.Forms.TreeDeletedData
      item.Row = i
      item.Data = String.Format("{0} - {1}", i("Kode"), i("Nama"))
      result.Add(item)
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedRows As System.Collections.Generic.List(Of Core.Win.Forms.TreeDeletedData)) As Boolean
    Try
      For i = 0 To selectedRows.Count - 1
        CType(xTree.GetDataRecordByNode(selectedRows(i).Row), Persistent.Coa).Delete()
      Next
      session.CommitChanges()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("foreign key constraint") Then
        MsgBox("Data tidak dapat dihapus karena masih terpakai oleh tabel lain.", , "Hapus Data")
        'Throw New Utils.Exception("Data tidak dapat dihapus karena masih terpakai oleh tabel lain.", 0, "", "Hapus")
      Else
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
    Return True
  End Function
  Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExpand.ItemClick
    xTree.ExpandAll()
  End Sub
  Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCollapse.ItemClick
    xTree.CollapseAll()
  End Sub
  Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
    xTree.SaveLayoutToXml(Logic.Umum.xLokasiLayout("mastercoa.xml"))
  End Sub
  Private Sub btnDetail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetail.ItemClick
    Dim xKode As String = xTree.FocusedNode.GetDisplayText(colKode)
    Dim xNama As String = xTree.FocusedNode.GetDisplayText(colNama)
    Dim xFilter As CriteriaOperator = CreateCriteriaDetail(xKode)
    Dim a As New UI_DaftarGLDetail(xFilter, "Daftar GL : " & xKode & "(" & xNama & ")")
    a.session = Me.session
    a.TampilkanData()
    a.ShowMDI()
  End Sub
	Private Function CreateCriteriaDetail(xKode As String) As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		result.Add(New BinaryOperator("Akun.Kode", xKode, BinaryOperatorType.Equal))
		Return GroupOperator.And(result)
	End Function


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

						Dim wsName = "COA"
						Dim workSheet = xlsControl.Document.Worksheets.ToList.Find(Function(f) f.Name = wsName)
						If Not workSheet Is Nothing Then ' Tipe 	 Kode 	Nama	Uang	Induk
							Dim usedRange = workSheet.GetUsedRange()
							Dim cellTipe = FindColumnPosition(workSheet, usedRange, "Tipe")
							Dim cellKode = FindColumnPosition(workSheet, usedRange, "Kode")
							Dim cellNama = FindColumnPosition(workSheet, usedRange, "Nama")
							Dim cellUang = FindColumnPosition(workSheet, usedRange, "Uang")
							Dim cellInduk = FindColumnPosition(workSheet, usedRange, "Induk")

							Dim listUang = New XPQuery(Of NuSoft001.Persistent.MataUang)(session).ToList() ' Divisi > (session).ToList();
							Dim listTipe = New XPQuery(Of Persistent.CoaLevel)(session).ToList()

							Dim xCOA As New XPCollection(Of Persistent.Coa)(session)
							For i = 1 To usedRange.RowCount - 1
								Dim xNama As String = Trim(workSheet.Cells(i, cellKode).DisplayText)
								If Trim(xNama) <> "" Then
									Dim cellTipeValue = Trim(workSheet.Cells(i, cellTipe).DisplayText)
									Dim cellIndukValue = Trim(workSheet.Cells(i, cellInduk).DisplayText)
									Dim cellUangValue = Trim(workSheet.Cells(i, cellUang).DisplayText)

									Dim xTipe = listTipe.Where(Function(w) w.Kode = cellTipeValue).FirstOrDefault
									Dim xUang = listUang.Where(Function(w) w.Kode = cellUangValue).FirstOrDefault
									Dim xInduk = xCOA.Where(Function(w) w.Kode = cellIndukValue).FirstOrDefault

									Dim xItem As New Persistent.Coa(session)
									xItem.Tipe = xTipe
									xItem.Kode = Trim(workSheet.Cells(i, cellKode).DisplayText)
									xItem.Nama = Trim(workSheet.Cells(i, cellNama).DisplayText)
									xItem.MataUang = xUang
									If Not xInduk Is Nothing Then xItem.Induk = xInduk
									xItem.Aktif = True
									xItem.Format = "-"
									'xItem.Bank = "-"
									xCOA.Add(xItem)
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

End Class