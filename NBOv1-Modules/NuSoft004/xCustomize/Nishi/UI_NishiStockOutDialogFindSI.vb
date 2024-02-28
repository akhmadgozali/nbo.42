Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports NuSoft.Utils

Friend Class UI_NishiStockOutDialogFindSI
  Property xPelanggan As NuSoft001.Persistent.Kontak
  Property xJenis As Persistent.NishiTipeBarangJO
  Property Result As List(Of Persistent.NishiStockDetailSJ)
  Private xDetailTemp As List(Of Persistent.NishiStockDetailSJ)
  'Property EditedSJ As Persistent.Fusoh_SuratJalan

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    Btn2IsClosedButton = True
  End Sub
  Public Overrides Sub InitializeData()
    Me.Text = "Pilih Stock IN : " + xPelanggan.Nama
    Dim xDataGR As New XPCollection(Of Persistent.NishiStockDetail)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal), New BinaryOperator("Main.Pelanggan", xPelanggan, BinaryOperatorType.Equal), New BinaryOperator("Main.JobOrder.TipeBarangJO", xJenis, BinaryOperatorType.Equal))) ', New BinaryOperator("QtySisa", 0, BinaryOperatorType.Greater)
    xDetailTemp = New List(Of Persistent.NishiStockDetailSJ)
    For pi = 0 To xDataGR.Count - 1
      If xDataGR(pi).QtySisa > 0 Then
        Dim pData As New Persistent.NishiStockDetailSJ
        pData.xSave = False
        pData.idGR = xDataGR(pi)
        pData.Qty = 0
        pData.QtyKubikasi = 0
        pData.Remark = ""
        pData.TruckOut = ""
        xDetailTemp.Add(pData)
      End If
    Next
    xGrid.DataSource = xDetailTemp
  End Sub
  Public Overrides Sub Btn1Click()
    Dim selected = xGridView.GetSelectedRows()
    If (selected.GetUpperBound(0) < 0) Then
      Throw New Exception("Pilih salah satu SO.")
      Exit Sub
    End If

    Result = New List(Of Persistent.NishiStockDetailSJ)
    For i = 0 To xDetailTemp.Count - 1
      If xDetailTemp(i).xSave = True Then
        xDetailTemp(i).Qty = xDetailTemp(i).idGR.QtyIn
        Result.Add(xDetailTemp(i))
      End If
    Next
    'For i = selected.GetLowerBound(0) To selected.GetUpperBound(0)
    '  Result.Add(CType(xGridView.GetRow(selected(i)), Persistent.NishiStockDetailSJ))
    'Next
  End Sub
  Public Overrides Sub ErrorBtn1Click(ex As Exception)
    ex.ShowWinMessageBox()
  End Sub
  Private Sub xGridView_DoubleClick(sender As Object, e As EventArgs) Handles xGridView.DoubleClick
    'Btn1Click()
    'Me.DialogResult = DialogResult.OK
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.NishiStockDetailSJ = CType(xGridView.GetRow(e.RowHandle), Persistent.NishiStockDetailSJ)
      If e.Column Is colX Then
        If CType(e.Value, Boolean) = True Then
          row.Qty = row.idGR.QtyIn
          row.QtyKubikasi = row.idGR.QtyIn2
        End If
      End If
    End If
  End Sub
End Class