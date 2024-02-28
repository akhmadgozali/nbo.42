Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_SaldoHutangUmur
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    xChart = nChart
    showChart = True
    showFilter = False
    useFeedbackSource = True
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("DataSaldoHutangUmur.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("DataSaldoHutangUmur.xml"))
    End If

    Dim a As New NuSoft001.Logic.FinaSetting(session)
    colNilaiInvoice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiInvoice.DisplayFormat.FormatString = a.NumericFormatString
    colNilaiBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiBayar.DisplayFormat.FormatString = a.NumericFormatString
    colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldo.DisplayFormat.FormatString = a.NumericFormatString

    Dim xData As New XPCollection(Of Persistent.ViewInvoiceUmur)(session)
    If xData.Count > 0 Then
      xGrid.DataSource = xData
      xGridView.ActiveFilterString = "Not [SisaSaldo] In ('0')"

      Dim b = From z In xData Group z By z.d_differentdays Into Group Select d_differentdays, SisaSaldo = Group.Sum(Function(x) ((x.p_id.Total - x.d_payment) * x.p_id.Kurs)) Where SisaSaldo > 0
      nChart.Series(0).DataSource = b
      nChart.RefreshData()
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("DataSaldoHutangUmur.xml"))
  End Sub
End Class