Imports DevExpress.Xpo
Imports NuSoft.Utils

Public Class UI_Fusoh_SQDialogBarang
	Property Item As NuSoft004.Persistent.Fusoh_Barang

	Sub LoadingData(masterItem As XPCollection(Of NuSoft004.Persistent.Fusoh_Barang))
		AutoCloseOnSave = True
		Btn2IsClosedButton = True
		xGrid.DataSource = masterItem
	End Sub

	Public Overrides Sub Btn1Click()
		Dim result = xGridView.GetFocusedRow
		If Not result Is Nothing Then
			Item = CType(result, NuSoft004.Persistent.Fusoh_Barang)
		Else
			Throw New Exception("Pilih item")
		End If
	End Sub
	Public Overrides Sub ErrorBtn1Click(ex As Exception)
		MsgBox(ex.Message)
	End Sub

	Private Sub xGridView_DoubleClick(sender As Object, e As EventArgs) Handles xGridView.DoubleClick
		Btn1Click()
		Me.DialogResult = DialogResult.OK
	End Sub
End Class