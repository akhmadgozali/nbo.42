Imports DevExpress.Data.Async.Helpers
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent

Public Class UI_TravelDP
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
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_TravelDPDialog
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
	Overrides Function HapusData(selectedData As List(Of Core.Win.Forms.GridDeletedData)) As Boolean
		Dim kodeError = String.Empty
		Dim item As Travel_DownPayment
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
				item = CType(proxy.OriginalRow, Travel_DownPayment)
				Try
					If item.AutoStatus <> "Posting" Then Throw New Exception("Sudah di proses")
					Dim zGL = item.Gl
					item.Delete()
					If Not zGL Is Nothing Then zGL.Delete()
					session.CommitChanges()
				Catch ex As Exception
					kodeError += vbCrLf & item.Kode
				End Try
			End If
		Next

		If Not String.IsNullOrEmpty(kodeError) Then
			Utils.Win.MessageBox.Show("Kode transaksi berikut tidak dapat dihapus, karena sdh diproses." & kodeError, "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
		End If
		Return True
	End Function

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
			Utils.Win.MessageBox.Show("Masukkan keterangan data yang akan dicetak", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
			Exit Sub
		End If

		If note.Count > 0 Then
			Dim item As Travel_DownPayment
			Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

			proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
			item = CType(proxy.OriginalRow, Travel_DownPayment)

			Dim frm As New RF_TravelDataTransaksi(Persistent.SumberDataJenis.DP, MainClass.reportName.zTravelVoucherDP)
			Dim salesSetting As New Logic.SalesSetting(session)
			frm.txtNoBukti1.EditValue = item.Kode

			Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
			Dim reportCode As String = ""
			reportCode = MainClass.GetReport(MainClass.reportName.zTravelVoucherDP)
			message = String.Format(message, "DP Penjualan")
			Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
		End If
	End Sub
End Class