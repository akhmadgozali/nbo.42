Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent
Imports NuSoft.Utils

Friend Class UI_TravelOrderDialogCopy
	Property SOTerpilih As Travel_Order

	Friend Sub LoadData()
		AutoCloseOnSave = True
		txtCopySO.Properties.DataSource = New XPCollection(Of Travel_Order)(session)
	End Sub
	Public Overrides Sub Btn1Click()
		If txtCopySO.EditValue Is Nothing Then
			Throw New Utils.Exception("Pilih SO terlebih dahulu")
		End If
		SOTerpilih = CType(txtCopySO.EditValue, Travel_Order)
	End Sub
	Public Overrides Sub ErrorBtn1Click(ex As Exception)
		ex.ShowWinMessageBox()
		txtCopySO.Focus()
	End Sub
End Class