Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class UI_FusohSaldoAwal
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		baseView = xGridView
		KeyField = "Id"
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
		Return New UI_FusohSaldoAwalDialog
	End Function
	Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
		Dim result As New List(Of Core.Win.Forms.GridDeletedData)
		Dim item As Core.Win.Forms.GridDeletedData

		For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
			If Not xGridView.IsGroupRow(selectedRows(i)) Then
				item = New Core.Win.Forms.GridDeletedData
				item.Row = selectedRows(i)
				item.Data = String.Format("{0} - {1}", xGridView.GetRowCellValue(selectedRows(i), "Barang.Kode"), xGridView.GetRowCellValue(selectedRows(i), "Barang.Nama"))
				result.Add(item)
			End If
		Next
		Return result
	End Function
	Public Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
		Dim item As Persistent.Fusoh_StokDetail, pPending As Integer
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

		pPending = 0
		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
				item = CType(proxy.OriginalRow, Persistent.Fusoh_StokDetail)

				'cek ada transaksi stok selain saldo awal
				Dim query = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Barang Is item.Barang _
															AndAlso w.Main.Sumber.Id <> Persistent.SumberDataJenis.BS).ToList
				If query.Count > 0 Then
					pPending += 1
				Else
					item.Delete()
				End If
			End If
		Next
		session.CommitChanges()
		If pPending > 0 Then
			Utils.Win.MessageBox.Show("Ada beberapa stok awal yang tidak bisa dihapus, dikarenakan sudah terpakai.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
		End If
		Return True
	End Function
	Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("BSData.xml"))
	End Sub
End Class