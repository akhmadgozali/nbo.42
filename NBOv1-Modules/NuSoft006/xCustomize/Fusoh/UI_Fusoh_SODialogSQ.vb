Imports DevExpress.Xpo
Imports NuSoft.Utils

Friend Class UI_Fusoh_SODialogSQ
  Property Customer As NuSoft001.Persistent.Kontak
  Property Tanggal As Date
  Property Result As List(Of Persistent.Fusoh_PenawaranDetail)
	Property EditedSO As Persistent.Fusoh_OrderPenjualan

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
		Btn2IsClosedButton = True
	End Sub
	Public Overrides Sub InitializeData()
		Dim SQDetailSudahProses As List(Of Long)

		If EditedSO Is Nothing Then
			SQDetailSudahProses = New XPQuery(Of Persistent.Fusoh_OrderPenjualanDetail)(session).Where(Function(w) w.PenawaranDetail IsNot Nothing).Select(Function(x) x.PenawaranDetail.Id).ToList
		Else
			SQDetailSudahProses = New XPQuery(Of Persistent.Fusoh_OrderPenjualanDetail)(session).Where(Function(w) Not w.Main Is EditedSO And w.PenawaranDetail IsNot Nothing).Select(Function(x) x.PenawaranDetail.Id).ToList
		End If

    xGrid.DataSource = New XPQuery(Of Persistent.Fusoh_PenawaranDetail)(session).Where(Function(m) _
                      m.Main.Pelanggan Is Customer AndAlso Not SQDetailSudahProses.Contains(m.Id) AndAlso
                      (m.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress OrElse
                       m.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) AndAlso
                       m.Main.TanggalBerlakuAkhir >= Tanggal)
  End Sub
	Public Overrides Sub Btn1Click()
		Dim selected = xGridView.GetSelectedRows()
		If (selected.GetUpperBound(0) < 0) Then
			Throw New Exception("Pilih salah satu barang.")
			Exit Sub
		End If

		Result = New List(Of Persistent.Fusoh_PenawaranDetail)
		For i = selected.GetLowerBound(0) To selected.GetUpperBound(0)
			Result.Add(CType(xGridView.GetRow(selected(i)), Persistent.Fusoh_PenawaranDetail))
		Next
	End Sub
	Public Overrides Sub ErrorBtn1Click(ex As Exception)
		ex.ShowWinMessageBox()
	End Sub
End Class
