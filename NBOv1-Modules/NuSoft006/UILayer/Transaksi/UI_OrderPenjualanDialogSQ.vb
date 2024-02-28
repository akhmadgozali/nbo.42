Imports DevExpress.Xpo
Imports NuSoft.Utils

Friend Class UI_OrderPenjualanDialogSQ
  Property Customer As NuSoft001.Persistent.Kontak
  Property Result As List(Of Persistent.PenawaranDetail)

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    Btn2IsClosedButton = True
  End Sub
	Public Overrides Sub InitializeData()
		xGrid.DataSource = New XPQuery(Of Persistent.PenawaranDetail)(session).Where(Function(m) _
											m.Main.Pelanggan Is Customer AndAlso m.QtyBelumSO > 0 AndAlso
											(m.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress OrElse
											 m.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting))
	End Sub
	Public Overrides Sub Btn1Click()
    Dim selected = xGridView.GetSelectedRows()
    If (selected.GetUpperBound(0) < 0) Then
      Throw New Exception("Pilih salah satu barang.")
      Exit Sub
    End If

    Result = New List(Of Persistent.PenawaranDetail)
    For i = selected.GetLowerBound(0) To selected.GetUpperBound(0)
      Result.Add(CType(xGridView.GetRow(selected(i)), Persistent.PenawaranDetail))
    Next
  End Sub
  Public Overrides Sub ErrorBtn1Click(ex As Exception)
    ex.ShowWinMessageBox()
  End Sub
End Class
