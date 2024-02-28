Friend Class UI_FusohAdjustmentRMScrap
	Private listDataSource As List(Of NonPersistent.Fusoh_DataSerial)

	Property SerialResult As List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)

	Overrides Sub InitializeData()
		AutoCloseOnSave = True
		Btn2IsClosedButton = True

		listDataSource = FusohLogic.Item.GetScrapData(session).Where(Function(w) w.SisaLength > 0).ToList
		xGrid.DataSource = listDataSource

		For i = 0 To SerialResult.Count - 1
			Dim row = xGridView.LocateByValue("Serial", SerialResult(i).Serial)
			xGridView.SelectRow(row)
		Next
	End Sub
	Public Overrides Sub Btn1Click()
		SerialResult = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)

		Dim x = xGridView.GetSelectedRows
		For i = x.GetLowerBound(0) To x.GetUpperBound(0)
			Dim selected = CType(xGridView.GetRow(x(i)), NonPersistent.Fusoh_DataSerial)
			Dim fi = SerialResult.Find(Function(f) f.Serial = selected.Serial)
			If fi Is Nothing Then
				SerialResult.Add(New NonPersistent.Fusoh_Produksi_BahanBaku_Temp With {
										.Barang = selected.Barang, .Length = CDec(selected.SisaLength), .Millsheet = selected.MillSheet,
										.SNQty = selected.Qty, .Qty = CDbl(IIf(selected.Qty > 0, 0, 1)), .SNLength = CDec(selected.SisaLength),
										.Serial = selected.Serial, .Scrap = True
								})
			Else
				SerialResult.Add(fi)
			End If
		Next
	End Sub
End Class