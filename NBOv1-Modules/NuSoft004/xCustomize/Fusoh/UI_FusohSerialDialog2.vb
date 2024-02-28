Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Friend Class UI_FusohSerialDialog2
	Private _item As Persistent.Fusoh_Barang

	ReadOnly Property SerialData As List(Of Persistent.Fusoh_StockDetailSerial_Temp)

	Sub LoadingData(item As Persistent.Fusoh_Barang, jmlQty As Integer, serialData As List(Of Persistent.Fusoh_StockDetailSerial_Temp))
		Me.Text = "Serial Item " & item.Kode & " : " & item.Nama & " Qty : " & jmlQty
		xGridView.IndicatorWidth = 30
		txtUrutan1.Properties.MinValue = 1
		txtUrutan1.Properties.MaxValue = CDec(jmlQty)
		txtUrutan2.Value = CDec(jmlQty)
		_item = item
		_serialData = serialData
		xGrid.DataSource = _serialData

		Dim namaMillsheet = New XPQuery(Of Persistent.Fusoh_StokSerial)(session).Where(Function(w) Not String.IsNullOrEmpty(w.MillSheet)).GroupBy(Function(g) g.MillSheet).Select(Function(s) s.Key).ToArray
		Dim xx = New Windows.Forms.AutoCompleteStringCollection()
		xx.AddRange(namaMillsheet)
		txtMillsheet.MaskBox.AutoCompleteSource = Windows.Forms.AutoCompleteSource.CustomSource
		txtMillsheet.MaskBox.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
		txtMillsheet.MaskBox.AutoCompleteCustomSource = xx
	End Sub
	Sub Disable()
		xGridView.OptionsBehavior.ReadOnly = True
		txtAwalan.Enabled = False
		txtDigit.Enabled = False
		btn1.Enabled = False
		txtUrutan1.Enabled = False
		txtUrutan2.Enabled = False
		txtMillsheet.Enabled = False
		btnMillsheet.Enabled = False
		txtMulaiDari.Enabled = False
		colMillsheetRepo.Buttons(0).Enabled = False
	End Sub

	Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
		Dim format As String = New String("0"c, CInt(txtDigit.Value))
		Dim xerror As String = String.Empty
		Dim mulaiDari = txtMulaiDari.Value

		xGrid.BeginUpdate()
		For i = mulaiDari To _serialData.Count + mulaiDari - 1
			Dim nama As String = txtAwalan.Text & i.ToString(format)
			If CekDuplicate(nama, _serialData(CInt(i - mulaiDari)).Id) Then
				xerror += nama & vbCrLf
			Else
				_serialData(CInt(i - mulaiDari)).Serial = nama
			End If
		Next
		xGrid.EndUpdate()

		If Not String.IsNullOrEmpty(xerror) Then
			XtraMessageBox.Show("Ada nama serial yang tidak bisa digenerate," & vbCrLf & "karena sudah terpakai" & vbCrLf & xerror,
													"Generate Serial", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
		End If
	End Sub
	Private Sub xGridView_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles xGridView.ValidateRow
		Dim View As GridView = CType(sender, GridView)
		Dim serialCol As GridColumn = View.Columns("Serial")
		Dim serialIdCol As GridColumn = View.Columns("Id")
		'Get the value of the second column
		Dim serialValue As String = View.GetRowCellValue(e.RowHandle, serialCol).ToString
		Dim serialId As Int64 = Convert.ToInt64(View.GetRowCellValue(e.RowHandle, serialIdCol))
		'Validity criterion
		If CekDuplicate(serialValue, serialId) Then
			e.Valid = False
			e.ErrorText = "Nama serial ini sudah ada yang pakai"
			'Set errors with specific descriptions for the columns
			View.SetColumnError(serialCol, "Nama serial ini sudah ada yang pakai")
		End If
	End Sub
	Private Function CekDuplicate(namaSerial As String, IdSerial As Int64) As Boolean
		Dim serialDB = New XPQuery(Of Persistent.Fusoh_StokSerial)(session).Where(Function(m) m.DetailMain.Barang Is _item).ToList.Find(Function(m) m.Serial = namaSerial)
		If Not serialDB Is Nothing Then
			If serialDB.Id <> IdSerial Then
				Return True
			End If
		End If

		Return False
	End Function

	Private Sub xGridView_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles xGridView.InvalidRowException
		e.ExceptionMode = ExceptionMode.NoAction
	End Sub
	Private Sub xGridView_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles xGridView.CustomDrawRowIndicator
		If e.RowHandle >= 0 Then
			e.Info.DisplayText = (e.RowHandle + 1).ToString
		End If
	End Sub

	Private Sub txtUrutan1_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtUrutan1.EditValueChanging
		txtUrutan2.Properties.MinValue = CDec(e.NewValue)
		txtUrutan2.Properties.MaxValue = 0
	End Sub

	Private Sub btnMillsheet_Click(sender As Object, e As EventArgs) Handles btnMillsheet.Click
		xGrid.BeginUpdate()
		For i = txtUrutan1.Value To txtUrutan2.Value
			_serialData(CInt(i - 1)).MillSheet = txtMillsheet.Text
		Next
		xGrid.EndUpdate()
	End Sub

	Private Sub colMillsheetRepo_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles colMillsheetRepo.ButtonPressed
		If (e.Button.Kind = ButtonPredefines.Minus) Then
			xGridView.DeleteRow(xGridView.GetRowHandle(xGridView.GetFocusedDataSourceRowIndex))
		End If
	End Sub
End Class