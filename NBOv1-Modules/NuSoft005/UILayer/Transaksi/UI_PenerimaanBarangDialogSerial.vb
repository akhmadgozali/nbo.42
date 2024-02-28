Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Friend Class UI_PenerimaanBarangDialogSerial
	Private itemToEdit As Persistent.PenerimaanBarangDetail

	Sub New(pItemToEdit As Persistent.PenerimaanBarangDetail)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		itemToEdit = pItemToEdit
		Me.Text = "Serial " & itemToEdit.Barang.Nama & " --> Qty : " & itemToEdit.Qty
	End Sub
	Overrides Sub FirstLoad()
		Dim selisih = itemToEdit.Qty - itemToEdit.DetailSerial.Count
		Dim newItem As Persistent.PenerimaanBarangDetailSerial
		For i = 0 To selisih - 1
			newItem = New Persistent.PenerimaanBarangDetailSerial(session)
			newItem.DetailMain = itemToEdit
			itemToEdit.DetailSerial.Add(newItem)
		Next
		xGrid.DataSource = itemToEdit.DetailSerial
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles xGridView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim selisih = itemToEdit.Qty - itemToEdit.DetailSerial.Count
			If Not selisih > 1 Then
				MsgBox("Jumlah barang serial tidak boleh lebih kecil dari qty")
				Exit Sub
			End If

			Dim Id As Persistent.PenerimaanBarangDetailSerial = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.PenerimaanBarangDetailSerial)
			xGridView.DeleteRow(xGridView.FocusedRowHandle)
			Id.Delete()
			itemToEdit.DetailSerial.Remove(Id)
		End If
	End Sub
	Private Sub xGridView_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles xGridView.CustomDrawRowIndicator
		If e.RowHandle >= 0 Then
			e.Info.DisplayText = (e.RowHandle + 1).ToString()
		End If
	End Sub
End Class