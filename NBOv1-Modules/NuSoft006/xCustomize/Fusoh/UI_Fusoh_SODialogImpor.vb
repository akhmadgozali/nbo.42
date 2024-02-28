Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Base
Imports NuSoft.Utils

Friend Class UI_Fusoh_SODialogImpor
	Property SOImporDetail As List(Of Persistent.Fusoh_OrderPenjualanDetail_Impor)
	Private barangList As List(Of NuSoft004.Persistent.Fusoh_Barang)

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
		Btn2IsClosedButton = True
	End Sub

	Public Overrides Sub InitializeData()
		barangList = New XPQuery(Of NuSoft004.Persistent.Fusoh_Barang)(session).Where(Function(m) m.TipeBarang = NuSoft004.Persistent.TipeBarang.BahanJadi).ToList
	End Sub
	Public Overrides Sub Btn1Click()

	End Sub
	Public Overrides Sub ErrorBtn1Click(ex As Exception)
		MsgBox(ex.Message)
	End Sub

	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
		Dim namaFile = Utils.Win.File.ShowOpenFileDialog("Buka file CSV", "CSV Files|*.csv", "")
		If Not String.IsNullOrEmpty(namaFile) Then
			txtNamaFile.Text = namaFile
			If IO.File.Exists(namaFile) Then
				SOImporDetail = New List(Of Persistent.Fusoh_OrderPenjualanDetail_Impor)

				Using MyReader As New FileIO.TextFieldParser(namaFile)
					MyReader.TextFieldType = FileIO.FieldType.Delimited
          'MyReader.SetDelimiters(";")
          MyReader.SetDelimiters(txtPemisah.Text)
          Dim currentRow As String()
					While Not MyReader.EndOfData
						Try
							currentRow = MyReader.ReadFields()
							If Not SOImporDetail.Find(Function(f) f.POLine = currentRow(0)) Is Nothing Then
								Throw New Exception("PO Line = " & currentRow(0) & " tidak bisa diproses karena sudah ada sebelumnya")
							End If
							'PO Line;Part No;Material;OD;ID;T;L;Qty;Price;Catatan
							Dim item As New Persistent.Fusoh_OrderPenjualanDetail_Impor
							item.POLine = currentRow(0)
							If item.POLine.Length > 15 Then item.POLine = item.POLine.Substring(0, 15)
							item.KodeBarang = currentRow(1)
							item.Barang = barangList.Find(Function(f) f.Kode = item.KodeBarang)
							If item.Barang Is Nothing Then
								item.NamaBarang = currentRow(2)
							Else
								item.NamaBarang = item.Barang.Nama
							End If
							item.OutDiameter = currentRow(3)
							item.InDiameter = currentRow(4)
							item.Thickness = currentRow(5)
							item.Length = currentRow(6)
							item.Qty = currentRow(7)
							item.Harga = currentRow(8)
							item.Catatan = currentRow(9)
							item.NoPODetail = currentRow(10)
							item.DeliveryDate = currentRow(11)
							SOImporDetail.Add(item)
            Catch ex As FileIO.MalformedLineException
							MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
						Catch ex As Exception
							MsgBox(ex.Message)
						Catch ex As InvalidCastException

						End Try
					End While
				End Using
				xGrid.DataSource = SOImporDetail
			End If
		End If
	End Sub

	Private Sub xGridView_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles xGridView.CellValueChanging
		If e.Column Is colKodeBarang Then
			Dim row = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_OrderPenjualanDetail_Impor)
			row.Barang = barangList.Find(Function(f) f.Kode = e.Value)
		End If
	End Sub
	Private Sub xGridView_ShowingEditor(sender As Object, e As CancelEventArgs) Handles xGridView.ShowingEditor
		If (xGridView.FocusedColumn.FieldName = "NamaBarang") Then
			Dim row = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_OrderPenjualanDetail_Impor)
			If (Not row.Barang Is Nothing) Then
				e.Cancel = True
			End If
		End If
	End Sub
End Class