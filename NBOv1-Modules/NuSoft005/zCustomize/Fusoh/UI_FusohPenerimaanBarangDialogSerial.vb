Imports DevExpress.XtraGrid.Views.Grid
Imports NuSoft.Utils

Friend Class UI_FusohPenerimaanBarangDialogSerial
	Private _data As Persistent.Fusoh_PenerimaanBarangDetail

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
	End Sub
	Sub LoadingData(data As Persistent.Fusoh_PenerimaanBarangDetail)
		Me.Text = "Serial Item " & data.Barang.Kode & " : " & data.Barang.Nama & " Qty : " & data.Qty
		_data = data
		xGridView.IndicatorWidth = 35
		xGrid.DataSource = _data.DetailSerial_Temp.Where(Function(w) w.State <> 2).ToList

		Dim selected = _data.DetailSerial_Temp.Where(Function(w) w.State = 1)
		For i = 0 To selected.Count - 1
			xGridView.SelectRow(xGridView.LocateByValue("Serial", selected(i).Serial))
		Next
	End Sub
	Private Sub xGridView_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles xGridView.CustomDrawRowIndicator
		If e.RowHandle >= 0 Then
			e.Info.DisplayText = (e.RowHandle + 1).ToString
		End If
	End Sub
	Sub Disable()
		xGrid.Enabled = False
		xGridView.OptionsBehavior.Editable = False
		xGridView.OptionsBehavior.ReadOnly = True
		btn1.Enabled = False
	End Sub

	Public Overrides Sub Btn1Click()
		Dim selected = xGridView.GetSelectedRows()
		'If _data.Qty <> selected.GetUpperBound(0) + 1 Then
		'	Throw New Exception("Serial yang dipilih tidak sesuai dengan qty" & vbCrLf & "Serial : " & selected.GetUpperBound(0) + 1 & vbCrLf & "Qty : " & _data.Qty)
		'End If

		For i = 0 To xGridView.RowCount - 1
			Dim serial = CType(xGridView.GetRow(i), Persistent.Fusoh_PenerimaanBarangDetailSerial_Temp)
			If xGridView.IsRowSelected(i) Then
				serial.State = 1
			Else
				serial.State = 0
			End If
		Next
	End Sub
	Public Overrides Sub ErrorBtn1Click(ex As Exception)
		MsgBox(ex.Message)
	End Sub
End Class