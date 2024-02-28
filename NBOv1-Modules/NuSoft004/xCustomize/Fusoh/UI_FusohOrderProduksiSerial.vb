Imports DevExpress.Data
Imports DevExpress.Xpo

Friend Class UI_FusohOrderProduksiSerial
	Private _source As List(Of NonPersistent.Fusoh_DataSerial)
	Property Serial As List(Of Persistent.Fusoh_OrderProduksiBahanBaku)
	Property Item As Persistent.Fusoh_Barang
	Property instance As Persistent.Fusoh_OrderProduksi
	Property SerialResult As List(Of Persistent.Fusoh_OrderProduksiBahanBaku)
	Property BahanJadiQty As Integer
	Property BahanJadiCutting As Integer

	'================================= Start 02 - 02 - 2020 =================================
	Private editQty As Boolean
	Private listDataSource As List(Of NonPersistent.Fusoh_DataSerial)
	'================================= End 02 - 02 - 2020 =================================

	Overrides Sub InitializeData()
		AutoCloseOnSave = True
		Btn2IsClosedButton = True

		If Item Is Nothing Then
			Throw New Exception("Masukkan item property.")
		End If

		Text = "Pilih serial " & Item.Kode
		_source = FusohLogic.Item.GetSerialData(session, Item)

    'MsgBox(_source.Count)
    For i = 0 To Serial.Count - 1
      If Not session.IsNewObject(Serial(i)) Then
        Dim Xserial = Serial(i)
        Dim d = _source.Find(Function(f) f.Serial = Xserial.Serial)
        If Not d Is Nothing Then
          d.LengthOut -= Xserial.Length
        End If
      End If
    Next

    'MsgBox(_source.Count & "/" & _source.Where(Function(w) w.SisaLength > 0).Count)
    '================================= Start 02 - 02 - 2020 =================================
    listDataSource = _source.Where(Function(w) w.SisaLength > 0).OrderBy(Function(o) o.Id).OrderBy(Function(o) o.TanggalDatang).ToList
    xGrid.DataSource = listDataSource
    '================================= End 02 - 02 - 2020 =================================

    For i = 0 To Serial.Count - 1
      Dim row = xGridView.LocateByValue("Serial", Serial(i).Serial)
      xGridView.SelectRow(row)
    Next

    '================================= Start 02 - 02 - 2020 =================================
    editQty = True
    txtQty.Properties.MaxValue = listDataSource.Count
    txtQty.Value = Serial.Count
    editQty = False
    '================================= End 02 - 02 - 2020 =================================
  End Sub
	Public Overrides Sub Btn1Click()
		SerialResult = New List(Of Persistent.Fusoh_OrderProduksiBahanBaku)

		Dim x = xGridView.GetSelectedRows
		For i = x.GetLowerBound(0) To x.GetUpperBound(0)
			Dim selected = CType(xGridView.GetRow(x(i)), NonPersistent.Fusoh_DataSerial)
			Dim fi = Serial.Find(Function(f) f.Serial = selected.Serial)
			If fi Is Nothing Then
				Dim newItem = New Persistent.Fusoh_OrderProduksiBahanBaku(session) With {
										.Barang = Item,
										.Millsheet = selected.MillSheet,
										.Main = instance,
										.Length = CDec(IIf(selected.OtomatisLength = 0, selected.SisaLength, selected.OtomatisLength)),
										.SNLength = CDec(selected.SisaLength),
										.Serial = selected.Serial,
										.Weight = selected.Weight
								}
				newItem.Qty = CInt(IIf(newItem.SNLength = newItem.Length, 1, 0))
				SerialResult.Add(newItem)
			Else
				fi.Length = CDec(IIf(selected.OtomatisLength = 0, selected.SisaLength, selected.OtomatisLength))
				fi.SNLength = CDec(selected.SisaLength)
				fi.Qty = CInt(IIf(fi.SNLength = fi.Length, 1, 0))
				SerialResult.Add(fi)
			End If
		Next
	End Sub

	'================================= Start 02 - 02 - 2020 =================================
	Private Sub txtQty_ValueChanged(sender As Object, e As EventArgs) Handles txtQty.ValueChanged
		If editQty Then Exit Sub
		Dim selisihQty = listDataSource.Count - txtQty.Value
		If selisihQty >= 0 Then
			Dim selisihTerpilih = txtQty.Value - xGridView.SelectedRowsCount
			Dim counter As Integer = 0
			'MsgBox("Selisih = " & selisihTerpilih & "; xGridView.RowCount=" & xGridView.RowCount - 1)
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

	Private Sub btnPilihOtomatis_Click(sender As Object, e As EventArgs) Handles btnPilihOtomatis.Click
		xGridView.ClearSelection()
		Dim rmDibutuhkan = BahanJadiCutting * BahanJadiQty
		For i = 0 To xGridView.RowCount - 1
			If Not xGridView.IsRowSelected(i) Then
				Dim selected = CType(xGridView.GetRow(i), NonPersistent.Fusoh_DataSerial)
				If selected.SisaLength >= BahanJadiCutting Then
					Dim jumlahPotong = CInt(selected.SisaLength / BahanJadiCutting)
					selected.OtomatisLength = jumlahPotong * BahanJadiCutting
					If rmDibutuhkan >= selected.OtomatisLength Then
						If selected.OtomatisLength > selected.SisaLength Then
							selected.OtomatisLength -= BahanJadiCutting
						End If
						rmDibutuhkan -= selected.OtomatisLength
					Else
						selected.OtomatisLength = rmDibutuhkan
						rmDibutuhkan = 0
					End If
					'MsgBox("Sisa Length = " & selected.SisaLength & vbCrLf & "Cutting = " & BahanJadiCutting & vbCrLf & "Jml. Potong = " & jumlahPotong & vbCrLf & "OtomatisLength = " & selected.OtomatisLength)
					xGridView.SelectRow(i)
				End If
			End If
			If rmDibutuhkan <= 0 Then
				Exit For
			End If
		Next

	End Sub
	'================================= End 02 - 02 - 2020 =================================
End Class