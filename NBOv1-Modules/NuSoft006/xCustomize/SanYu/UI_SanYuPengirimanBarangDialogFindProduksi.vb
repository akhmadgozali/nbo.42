Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Friend Class UI_SanYuPengirimanBarangDialogFindProduksi
  Dim _data As Persistent.SanYu_PengirimanBarangDetail
  Property AMResult As List(Of Persistent.SanYu_PengirimanBarangDetail)
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
  End Sub
  Sub LoadData(xData As Persistent.SanYu_PengirimanBarangDetail)
    _data = xData

    xGrid.DataSource = New XPCollection(Of Persistent.SanYu_PengirimanBarangDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Barang", _data.Barang, BinaryOperatorType.Equal)))
  End Sub
  Public Overrides Sub Btn1Click()
    Dim x = xGridView.GetSelectedRows
    If x.Count > 1 Then
      Throw New Utils.Exception("Anda hanya diperbolehkan memilih satu data.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    AMResult = New List(Of Persistent.SanYu_PengirimanBarangDetail)
    For i = x.GetLowerBound(0) To x.GetUpperBound(0)
      Dim selected = CType(xGridView.GetRow(x(i)), Persistent.SanYu_PengirimanBarangDetail)
      AMResult.Add(selected)
      _data.ProduksiID = selected
    Next
  End Sub
  Public Overrides Sub ErrorBtn1Click(ex As Utils.Exception)

    MsgBox(ex.ErrorMessage)
  End Sub
End Class