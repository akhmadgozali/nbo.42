Imports DevExpress.Data.Filtering
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_TravelMasterItem
	Private _jenis As JenisBarang

	Sub New(jenis As JenisBarang)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_jenis = jenis
		baseView = xGridView
		KeyField = "Id"
		xpCol.Criteria = New BinaryOperator(NameOf(Barang.Jenis), jenis, BinaryOperatorType.Equal)
	End Sub

	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_TravelMasterItemDialog(_jenis)
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
				CType(xGridView.GetRow(selectedData(i).Row), Barang).Delete()
			End If
		Next
		session.CommitChanges()
		Return True
	End Function
End Class