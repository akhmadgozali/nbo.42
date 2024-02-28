Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Public Class UI_SanyuCekStockHistory
  Private setting As NuSoft001.Logic.FinaSetting, pKode As String
  Sub New(zKode As String, xSession As DevExpress.Xpo.UnitOfWork)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Session = xSession
    pKode = zKode
  End Sub
  Overrides Sub FirstLoad()
    setting = New NuSoft001.Logic.FinaSetting(Session)
    SetFormat()
    xGridView.OptionsBehavior.Editable = True
    xGridView.OptionsBehavior.ReadOnly = True
    'xGridView.ActiveFilterString = "[Barang.Kode]='" & pKode & "'"
    Dim DataTransaksi As New XPCollection(Of Persistent.SanYu_StokDetail)(session, getCriteria)
    xGrid.DataSource = DataTransaksi
  End Sub

  Private Function getCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    'If Not txtKode.EditValue Is Nothing Then
    '  result.Add(New BinaryOperator("Barang.Kode", String.Format(format, txtKode.EditValue), BinaryOperatorType.Like))
    'End If
    'If Not txtNama.EditValue Is Nothing Then
    '  result.Add(New BinaryOperator("Barang.Nama", String.Format(format, txtNama.EditValue), BinaryOperatorType.Like))
    'End If
    result.Add(New BinaryOperator("Barang.Kode", String.Format(format, pKode), BinaryOperatorType.Like))
    Return GroupOperator.And(result)
  End Function
  Private Sub SetFormat()
    colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
    colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyOut.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
End Class