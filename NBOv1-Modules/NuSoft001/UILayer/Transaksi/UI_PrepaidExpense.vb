Friend Class UI_PrepaidExpense
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
    'Menu.MenuItems.Add("Amortisasi", AddressOf Me.clearAllMenuItemClick)
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim setting As New Logic.FinaSetting(session)
    colNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilai.DisplayFormat.FormatString = setting.NumericFormatString
    colNilai.SummaryItem.DisplayFormat = setting.NumericFormatString
    colUmur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colUmur.DisplayFormat.FormatString = setting.NumericFormatString
    colAmortisasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colAmortisasi.DisplayFormat.FormatString = setting.NumericFormatString
    colAmortisasi.SummaryItem.DisplayFormat = setting.NumericFormatString
    colAmortisasiJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colAmortisasiJumlah.DisplayFormat.FormatString = setting.NumericFormatString
    colAmortisasiJumlah.SummaryItem.DisplayFormat = setting.NumericFormatString
    colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldo.DisplayFormat.FormatString = setting.NumericFormatString
    colSaldo.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_PrepaidExpenseDialog
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
				Dim item = CType(xGridView.GetRow(selectedData(i).Row), Persistent.PrepaidExpense)

				For pi = 0 To item.Detail.Count - 1
					If Not item.Detail(pi).Gl Is Nothing Then
						item.Detail(pi).Gl.Delete()
					End If
				Next
				If Not item.Gl Is Nothing Then item.Gl.Delete()
				item.Delete()

				'CType(xGridView.GetRow(selectedData(i).Row), Persistent.PrepaidExpense).Gl.Delete()
				'CType(xGridView.GetRow(selectedData(i).Row), Persistent.PrepaidExpense).Delete()
			End If
		Next
    session.CommitChanges()
    Return True
  End Function
  Private Sub mnAmortisasi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnAmortisasi.ItemClick
    Dim xform As New UI_PrepaidExpenseAmortisasi
    xform.ShowDialog()
  End Sub
End Class