Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Base
Imports NuSoft.Utils
Friend Class UI_FusohOrderPembelianDialogImpor
	Property POImporDetail As List(Of Persistent.Fusoh_OrderPembelianDetail_Impor)
	Private barangList As List(Of NuSoft004.Persistent.Fusoh_Barang)
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
		Btn2IsClosedButton = True
	End Sub

	Public Overrides Sub InitializeData()
		barangList = New XPQuery(Of NuSoft004.Persistent.Fusoh_Barang)(session).Where(Function(m) m.TipeBarang = NuSoft004.Persistent.TipeBarang.BahanBaku).ToList
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
				POImporDetail = New List(Of Persistent.Fusoh_OrderPembelianDetail_Impor)

				Using MyReader As New FileIO.TextFieldParser(namaFile)
					MyReader.TextFieldType = FileIO.FieldType.Delimited
					'MyReader.SetDelimiters(";")
					MyReader.SetDelimiters(txtPemisah.Text)
					Dim currentRow As String()
					While Not MyReader.EndOfData
						Try
							currentRow = MyReader.ReadFields()
							'0      1        2  3  4 5 6   7      8     9         10            11
							'PartNo;Material;OD;ID;T;L;QTY;Weight;Price;Sub Total;Shipping Cost;Remarks

							Dim item As New Persistent.Fusoh_OrderPembelianDetail_Impor
							item.KodeBarang = currentRow(0)
							item.Barang = barangList.Find(Function(f) f.Kode = item.KodeBarang)
							If Not item.Barang Is Nothing Then
								item.NamaBarang = item.Barang.Nama
							Else
								item.NamaBarang = currentRow(1)
							End If

							item.OutDiameter = currentRow(2)
							item.InDiameter = currentRow(3)
							item.Thickness = currentRow(4)
							item.Length = currentRow(5)
							item.Qty = currentRow(6)
							item.WeightM = currentRow(7)
							item.Harga = currentRow(8)
							item.ShippingCost = currentRow(10)
							item.Catatan = currentRow(11)
							POImporDetail.Add(item)
						Catch ex As Exception
							MsgBox(ex.Message)
						Catch ex As InvalidCastException
						End Try
					End While
				End Using
				xGrid.DataSource = POImporDetail
			End If
		End If
	End Sub

	Private Sub xGridView_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles xGridView.CellValueChanging
		If e.Column Is colKodeBarang Then
			Dim row = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_OrderPembelianDetail_Impor)
			row.Barang = barangList.Find(Function(f) f.Kode = e.Value)
		End If
	End Sub
	Private Sub xGridView_ShowingEditor(sender As Object, e As CancelEventArgs) Handles xGridView.ShowingEditor
		If (xGridView.FocusedColumn.FieldName = "NamaBarang") Then
			Dim row = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_OrderPembelianDetail_Impor)
			If (Not row.Barang Is Nothing) Then
				e.Cancel = True
			End If
		End If
	End Sub
End Class