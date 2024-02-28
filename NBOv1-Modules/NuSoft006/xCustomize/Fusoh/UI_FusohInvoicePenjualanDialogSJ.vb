Imports DevExpress.Xpo
Imports NuSoft.Utils

Friend Class UI_FusohInvoicePenjualanDialogSJ
	Property Customer As NuSoft001.Persistent.Kontak
	Property Result As List(Of Persistent.Fusoh_SuratJalanDetail)
	Property EditedInvoice As Persistent.Fusoh_InvoicePenjualan

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
		Btn2IsClosedButton = True
	End Sub
	Public Overrides Sub InitializeData()
		Dim SJDetailIdSdhProses As List(Of Long)
		If EditedInvoice Is Nothing Then
			SJDetailIdSdhProses = New XPQuery(Of Persistent.Fusoh_InvoicePenjualanDetail)(session).Select(Function(x) x.SuratJalanDetail.Id).ToList
		Else
			SJDetailIdSdhProses = New XPQuery(Of Persistent.Fusoh_InvoicePenjualanDetail)(session).Where(Function(w) Not w.Main Is EditedInvoice).Select(Function(x) x.SuratJalanDetail.Id).ToList
		End If

		xGrid.DataSource = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(m) _
											m.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso m.Main.Pelanggan Is Customer AndAlso Not SJDetailIdSdhProses.Contains(m.Id) AndAlso
											(m.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress OrElse
											 m.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting))
	End Sub
	Public Overrides Sub Btn1Click()
		Dim selected = xGridView.GetSelectedRows()
		If (selected.GetUpperBound(0) < 0) Then
			Throw New Exception("Pilih salah satu Surat Jalan.")
			Exit Sub
		End If

		Result = New List(Of Persistent.Fusoh_SuratJalanDetail)
		For i = selected.GetLowerBound(0) To selected.GetUpperBound(0)
			Result.Add(CType(xGridView.GetRow(selected(i)), Persistent.Fusoh_SuratJalanDetail))
		Next
	End Sub
	Public Overrides Sub ErrorBtn1Click(ex As Exception)
		ex.ShowWinMessageBox()
	End Sub
End Class
