Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports NuSoft.Utils

Friend Class UI_FusohSJDialogSO
	Property Customer As NuSoft001.Persistent.Kontak
	Property Result As List(Of Persistent.Fusoh_OrderPenjualan)
	Property EditedSJ As Persistent.Fusoh_SuratJalan

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
		Btn2IsClosedButton = True
	End Sub
	Public Overrides Sub InitializeData()
		Me.Text = "Pilih SO : " + Customer.Nama
		xGrid.DataSource = New XPQuery(Of Persistent.Fusoh_OrderPenjualan)(session).Where(Function(m) _
											m.Pelanggan Is Customer AndAlso
											(m.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress OrElse
											 m.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting))
	End Sub
	Public Overrides Sub Btn1Click()
		Dim selected = xGridView.GetSelectedRows()
		If (selected.GetUpperBound(0) < 0) Then
			Throw New Exception("Pilih salah satu SO.")
			Exit Sub
		End If

		Result = New List(Of Persistent.Fusoh_OrderPenjualan)
		For i = selected.GetLowerBound(0) To selected.GetUpperBound(0)
			Result.Add(CType(xGridView.GetRow(selected(i)), Persistent.Fusoh_OrderPenjualan))
		Next
	End Sub
	Public Overrides Sub ErrorBtn1Click(ex As Exception)
		ex.ShowWinMessageBox()
	End Sub
	Private Sub xGridView_DoubleClick(sender As Object, e As EventArgs) Handles xGridView.DoubleClick
		'Btn1Click()
		'Me.DialogResult = DialogResult.OK
	End Sub
End Class