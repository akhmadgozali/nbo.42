Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports NuSoft.Core.SSystem

Public Class UI_FusohBackToMaterial
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
		CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.BM, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
		ifSource.FixedFilterCriteria = CreateCriteria
		toStringFormat = setting.NumericFormatToString
		btnClosing.Enabled = False
		btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		btnUnposting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BMData.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BMData.xml"))
		End If
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_FusohBackToMaterialDialog
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
		Dim item As Persistent.Fusoh_StockAdjustment, pPending As Integer
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim kodeDelete = ""

    pPending = 0
		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
				item = CType(proxy.OriginalRow, Persistent.Fusoh_StockAdjustment)
				If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
          kodeDelete &= ", " & item.Kode
          item.Delete()
        Else
					pPending += 1
				End If
			End If
		Next
		session.CommitChanges()
    '======= Simple log
    Try
      If kodeDelete <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Back To Material ->" & kodeDelete.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
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
		Dim item As Persistent.Fusoh_StockAdjustment, xGagal As Integer, xMessage As String
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
		xGagal = 0
		xMessage = ""
    Dim kodeStatus = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Fusoh_StockAdjustment)
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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Back To Material " & xTipe & " ->" & kodeStatus.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
	Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("BMData.xml"))
	End Sub
	'Private Sub btnReset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnReset.ItemClick
	'  If Not xGridView.DataSource Is Nothing Then
	'    Dim NomorTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colCode)
	'    Dim xInstance As XPCollection(Of Persistent.Fusoh_StokMain)(session)
	'    Dim xDataProduksi As New XPCollection(Of Persistent.Fusoh_StockDetailSerial)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("DetailMain.Barang.Kode", pKode, BinaryOperatorType.Equal)))



	'    RefreshData()
	'  End If
	'End Sub
End Class