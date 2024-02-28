Public Class UI_FusohMasterProcessCutting
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		baseView = xGridView
		KeyField = "Id"
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_FusohMasterProcessCuttingDialog
	End Function
	Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As List(Of Core.Win.Forms.GridDeletedData)
		Dim result As New List(Of Core.Win.Forms.GridDeletedData)
		Dim item As Core.Win.Forms.GridDeletedData

		For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
			If Not xGridView.IsGroupRow(selectedRows(i)) Then
				item = New Core.Win.Forms.GridDeletedData
				item.Row = selectedRows(i)
				item.Data = String.Format("{0} - {1}", xGridView.GetRowCellValue(selectedRows(i), "Id"), xGridView.GetRowCellValue(selectedRows(i), "Nama"))
				result.Add(item)
			End If
		Next
		Return result
	End Function
	Public Overrides Function HapusData(selectedData As List(Of Core.Win.Forms.GridDeletedData)) As Boolean
		Dim listData As New List(Of Persistent.Fusoh_ProcessCutting)
		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				listData.Add(CType(xGridView.GetRow(selectedData(i).Row), Persistent.Fusoh_ProcessCutting))
			End If
		Next

		Try
			Services.MasterProcessCuttingService.DeleteData(session, listData)
		Catch ex As Utils.Exception
			ex.ShowWinMessageBox()
		End Try

		Return True
	End Function
End Class