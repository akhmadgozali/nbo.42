Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Friend Class UI_SanyuPengirimanBarangDialogPacking
  Dim _data As Persistent.SanYu_PengirimanBarangDetail
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
  End Sub
  Sub LoadData(xData As Persistent.SanYu_PengirimanBarangDetail)
    _data = xData
    xGrid.DataSource = _data.DetailPacking
    txtMulaiDari.EditValue = 0
    txtSampai.EditValue = 0
    txtPanjang.EditValue = xData.Barang.Length
    txtLebar.EditValue = xData.Barang.InDiameter
    txtTebal.EditValue = xData.Barang.Thickness



    'txtMulaiDari.EditValue = 180
    'txtSampai.EditValue = 194
    'txtAlkhiran.EditValue = "FSC"
  End Sub
  Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
    Dim mulaiDari = txtMulaiDari.Value

    For i = mulaiDari To txtSampai.Value
      'MsgBox(i.ToString & txtAlkhiran.Text)
      Dim item = New Persistent.SanYu_PengirimanBarangDetailPackingList(session)
      item.NoKarton = i.ToString & txtAlkhiran.Text
      item.Panjang = txtPanjang.EditValue
      item.Lebar = txtLebar.EditValue
      item.Tebal = txtTebal.EditValue
      item.VolPCS = txtVolPCS.EditValue
      item.VolM3 = txtVolM3.EditValue
      item.VolFeet = txtVolFeet.EditValue
      item.VolNW = txtVolNW.EditValue
      item.VolGW = txtVolGW.EditValue
      _data.DetailPacking.Add(item)
    Next
    xGrid.RefreshDataSource()
  End Sub
  Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      'Dim Id As Persistent.SanYu_PengirimanBarangDetailPackingList = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SanYu_PengirimanBarangDetailPackingList)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
    End If
  End Sub
  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    For pi = _data.DetailPacking.Count - 1 To 0 Step -1
      _data.DetailPacking(pi).Delete()
    Next
    xGrid.RefreshDataSource()
  End Sub
End Class