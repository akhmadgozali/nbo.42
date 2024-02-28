Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohCekStockHistorySerial
  Private setting As NuSoft001.Logic.FinaSetting, pIDTransaksi As Long
  Sub New(IdTransaksi As Long, xSession As DevExpress.Xpo.UnitOfWork, kodeTransaksi As String)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    session = xSession
    pIDTransaksi = IdTransaksi
    Text = "Detail Serial : " & kodeTransaksi
  End Sub
  Overrides Sub FirstLoad()
    setting = New NuSoft001.Logic.FinaSetting(session)
    xGrid.DataSource = New XPCollection(Of Persistent.Fusoh_StokSerial)(session, New BinaryOperator("DetailMain.Id", pIDTransaksi, BinaryOperatorType.Equal))
  End Sub
  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data Stock")
  End Sub
  'Private Function getCriteria() As CriteriaOperator
  '  Dim result As New List(Of CriteriaOperator)
  '  Dim format As String = "%{0}%"
  '  'If Not txtKode.EditValue Is Nothing Then
  '  '  result.Add(New BinaryOperator("Barang.Kode", String.Format(format, txtKode.EditValue), BinaryOperatorType.Like))
  '  'End If
  '  'If Not txtNama.EditValue Is Nothing Then
  '  '  result.Add(New BinaryOperator("Barang.Nama", String.Format(format, txtNama.EditValue), BinaryOperatorType.Like))
  '  'End If
  '  result.Add(New BinaryOperator("Barang.Kode", String.Format(format, pKode), BinaryOperatorType.Like))
  '  Return GroupOperator.And(result)
  'End Function
  Private Sub SetFormat()
    'colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    'colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
    'colQtyOut.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colWeight.DisplayFormat.FormatString = setting.NumericFormatString
    'colWeight.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colWeightIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colWeightIN.DisplayFormat.FormatString = setting.NumericFormatString
    'colWeightIN.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colWeightOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colWeightOut.DisplayFormat.FormatString = setting.NumericFormatString
    'colWeightOut.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
End Class