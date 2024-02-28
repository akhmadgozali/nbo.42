Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Public Class UI_CekStockHPP
  Private setting As NuSoft001.Logic.FinaSetting, pKode As String, pGudang As String
  Sub New(zKode As String, zGudang As String, xSession As DevExpress.Xpo.UnitOfWork)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    session = xSession
    pKode = zKode
    pGudang = zGudang
  End Sub
  Overrides Sub FirstLoad()
    setting = New NuSoft001.Logic.FinaSetting(session)
    SetFormat()
    'xGridView.OptionsBehavior.Editable = False
    'xGridView.OptionsBehavior.ReadOnly = True
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CekStockHistory.xml")) = True Then
    '  xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CekStockHistory.xml"))
    'End If
    'xGridView.ActiveFilterString = "[Barang.Kode]='" & pKode & "' and [Gudang.Kode]='" & pGudang & "'"
    xGrid1.DataSource = New XPCollection(Of Persistent.vwHPP)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("f_item.Kode", pKode, BinaryOperatorType.Equal), New BinaryOperator("f_warehouse.Kode", pGudang, BinaryOperatorType.Equal)))
    xGridView1.OptionsBehavior.ReadOnly = True
    xGridView1.OptionsBehavior.Editable = False
  End Sub
  Private Sub SetFormat()
    'colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    'colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
    'colQtyOut.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colStock.DisplayFormat.FormatString = setting.NumericFormatString
    'colStock.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    'xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("CekStockHistory.xml"))
  End Sub
  Private Sub ifSource_ResolveSession(sender As Object, e As ResolveSessionEventArgs)
    e.Session = session
  End Sub
  Private Sub xGrid1_DoubleClick(sender As Object, e As EventArgs) Handles xGrid1.DoubleClick
    If Not xGrid1.DataSource Is Nothing Then
      'MsgBox("OKE")
      'MsgBox("aaa-->" & xGridView1.GetFocusedRowCellDisplayText(colNoBukti))
      'If Not xGridView1.FocusedRowHandle = Nothing Then
      Dim xNoTransaksi As String = xGridView1.GetFocusedRowCellDisplayText(colNoBukti)
      Dim xID As String = xGridView1.GetFocusedRowCellDisplayText(colId)
      xGrid2.DataSource = New XPCollection(Of Persistent.StockDetailHPPReff)(session, New BinaryOperator("DetailIN.Id", xID, BinaryOperatorType.Equal))
      xGridView2.OptionsBehavior.ReadOnly = True
      xGridView2.OptionsBehavior.Editable = False
      lytGroup1.Text = "History Pemakaian HPP : " & xNoTransaksi
      'End If
    End If
  End Sub

  Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
    gridCariHPP.DataSource = New XPCollection(Of Persistent.StockDetailHPPReff)(session, New BinaryOperator("DetailIN.Main.Kode", txtNoTransaksi.Text, BinaryOperatorType.Equal))
  End Sub

  Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
    gridCariHPPView.ExportToXlsx("c:\nusoft\nbo\temp\datahpp.xlsx")
  End Sub
End Class