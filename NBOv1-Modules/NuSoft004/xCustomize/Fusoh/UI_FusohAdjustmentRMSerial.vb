Imports DevExpress.Data
Imports DevExpress.Xpo

Friend Class UI_FusohAdjustmentRMSerial
	Private editQty As Boolean
	Private listDataSource As List(Of NonPersistent.Fusoh_DataSerial)

	Property Row As NonPersistent.Fusoh_Produksi_BahanBaku_Temp
	Property SerialResult As List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
	Property EditedDetail As List(Of Persistent.Fusoh_StokDetail)

	Overrides Sub InitializeData()
		AutoCloseOnSave = True
		Btn2IsClosedButton = True

		Text = "Pilih serial " & Row.Barang.Kode
		listDataSource = FusohLogic.Item.GetSerialData(session, Row.Barang)
		If Not EditedDetail Is Nothing Then
			Dim editedSerial = EditedDetail.SelectMany(Function(m) m.Serial)
			For Each item In editedSerial
				Dim d = listDataSource.Find(Function(f) f.Serial = item.Serial)
				If Not d Is Nothing Then
					d.LengthOut -= item.LengthOut
				End If
			Next
		End If

		listDataSource = listDataSource.Where(Function(w) w.SisaLength > 0).ToList
		xGrid.DataSource = listDataSource

		For i = 0 To SerialResult.Count - 1
			Dim row = xGridView.LocateByValue("Serial", SerialResult(i).Serial)
			xGridView.SelectRow(row)
		Next

		editQty = True
		txtQty.Properties.MaxValue = listDataSource.Count
		txtQty.Value = SerialResult.Count
		editQty = False
	End Sub
	Public Overrides Sub Btn1Click()
		SerialResult = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)

		Dim x = xGridView.GetSelectedRows
		For i = x.GetLowerBound(0) To x.GetUpperBound(0)
			Dim selected = CType(xGridView.GetRow(x(i)), NonPersistent.Fusoh_DataSerial)
			Dim fi = SerialResult.Find(Function(f) f.Serial = selected.Serial)
			If fi Is Nothing Then
				SerialResult.Add(New NonPersistent.Fusoh_Produksi_BahanBaku_Temp With {
										.Barang = Row.Barang, .Length = CDec(selected.SisaLength), .Millsheet = selected.MillSheet,
										.SNQty = selected.Qty, .Qty = CDbl(IIf(selected.Qty > 0, 0, 1)), .SNLength = CDec(selected.SisaLength),
										.Serial = selected.Serial
								})
			Else
				SerialResult.Add(fi)
			End If
		Next
	End Sub

	Private Sub txtQty_ValueChanged(sender As Object, e As EventArgs) Handles txtQty.ValueChanged
		If editQty Then Exit Sub
		Dim selisihQty = listDataSource.Count - txtQty.Value
		If selisihQty >= 0 Then
			Dim selisihTerpilih = txtQty.Value - xGridView.SelectedRowsCount
			Dim counter As Integer = 0
			If selisihTerpilih > 0 Then
				For i = 0 To xGridView.RowCount - 1
					If Not xGridView.IsRowSelected(i) Then
						xGridView.SelectRow(i)
						counter += 1
						If (counter >= selisihTerpilih) Then Exit For
					End If
				Next
			ElseIf selisihTerpilih < 0 Then
				counter = CInt(Math.Abs(selisihTerpilih))
				For i = xGridView.RowCount - 1 To 0 Step -1
					If xGridView.IsRowSelected(i) Then
						xGridView.UnselectRow(i)
						counter -= 1
						If (counter <= 0) Then Exit For
					End If
				Next
			End If
		End If
	End Sub
	Private Sub xGridView_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles xGridView.SelectionChanged
		editQty = True
		txtQty.Value = xGridView.SelectedRowsCount
		editQty = False
	End Sub
End Class