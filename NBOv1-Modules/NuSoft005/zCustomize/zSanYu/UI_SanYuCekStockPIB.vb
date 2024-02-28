Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPivotGrid
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls

Public Class UI_SanYuCekStockPIB
  Private setting As NuSoft001.Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    setting = New NuSoft001.Logic.FinaSetting(session)
    'colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    'colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
    'colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colStock.DisplayFormat.FormatString = setting.NumericFormatString

    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("cekstock.xml")) = True Then
    '  xGridStockView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("cekstock.xml"))
    'End If
  End Sub
  Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click

    Dim DataTransaksi As New XPCollection(Of Persistent.SanYu_PenerimaanBarangDetail)(session, getCriteria)

    xGridStock.DataSource = Nothing
    session.DropIdentityMap()

    xGridStock.DataSource = DataTransaksi
  End Sub
  Private Function getCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    'tambahkan hanya yg ekspor
    result.Add(New BinaryOperator("Main.FromDomestik", False, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Qty", 0, BinaryOperatorType.Greater))
    If Not txtKode.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang.Kode", String.Format(format, txtKode.EditValue), BinaryOperatorType.Like))
    End If
    If Not txtNama.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang.Nama", String.Format(format, txtNama.EditValue), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub xGridStockView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridStockView.ColumnWidthChanged
    'xGridStockView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("cekstock.xml"))
  End Sub
  Private Sub btnCetakData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakData.ItemClick
    printGrid(xGridStock)
  End Sub
  Private Sub btnProduksi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProduksi.ItemClick
    If Not xGridStockView.DataSource Is Nothing Then
      Dim IDPenerimaan As String = xGridStockView.GetFocusedRowCellDisplayText(colId)
      Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)

      Dim a As New NuSoft004.Logic.SanYu
      a.showDataProduksi(Me.MenuId, Me.NamaDatabase, session, IDPenerimaan)
    End If
  End Sub
  Private Sub btnPenjualan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPenjualan.ItemClick
    If Not xGridStockView.DataSource Is Nothing Then
      Dim IDPenerimaan As String = xGridStockView.GetFocusedRowCellDisplayText(colId)
      Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)

      Dim a As New NuSoft006.Logic.SanYu
      a.showDataPenjualan(Me.MenuId, Me.NamaDatabase, session, IDPenerimaan)
    End If

  End Sub
End Class