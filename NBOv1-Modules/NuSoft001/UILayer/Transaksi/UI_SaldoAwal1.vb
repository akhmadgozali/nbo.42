Imports DevExpress.Data.Async.Helpers
Friend Class UI_SaldoAwal1
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = False
    useFeedbackSource = True
    ActivateToolTip = False
    UseDbSystem = False
  End Sub
  Overrides Sub FirstLoad()
    Dim a As New Logic.FinaSetting(GetSession)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SaldoAwal.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SaldoAwal.xml"))
    End If
    'colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colDebit.DisplayFormat.FormatString = a.NumericFormatString
    'colDebit.SummaryItem.DisplayFormat = a.NumericFormatString
    'colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colKredit.DisplayFormat.FormatString = a.NumericFormatString
    'colKredit.SummaryItem.DisplayFormat = a.NumericFormatString
    'colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colKurs.DisplayFormat.FormatString = a.NumericFormatString
    'colKurs.SummaryItem.DisplayFormat = a.NumericFormatString
    'colDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colDebitValas.DisplayFormat.FormatString = a.NumericFormatString
    'colDebitValas.SummaryItem.DisplayFormat = a.NumericFormatString
    'colKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colKreditValas.DisplayFormat.FormatString = a.NumericFormatString
    'colKreditValas.SummaryItem.DisplayFormat = a.NumericFormatString
    'ifSource.FixedFilterCriteria = New DevExpress.Data.Filtering.InOperator("Sumber", Persistent.SumberDataJenis.SA)
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SaldoAwal.xml"))
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_SaldoAwalDialog
  End Function
  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = xGridView.GetRowCellValue(selectedRows(i), "Kode").ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.PengajuanDana
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.PengajuanDana)

        item.Delete()
      End If
    Next
    session.CommitChanges()
    Return True
  End Function
End Class