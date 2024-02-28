Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Public Class UI_NishiCekStockHistory
  Private setting As NuSoft001.Logic.FinaSetting, pKode As String, pGudang As String
  Sub New(zKode As String, zGudang As String, xSession As DevExpress.Xpo.UnitOfWork)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Session = xSession
    pKode = zKode
    pGudang = zGudang
  End Sub
  Overrides Sub FirstLoad()
    setting = New NuSoft001.Logic.FinaSetting(Session)
    SetFormat()
    xGridView.OptionsBehavior.Editable = False
    xGridView.OptionsBehavior.ReadOnly = True
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CekStockHistory.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CekStockHistory.xml"))
    End If
    xGridView.ActiveFilterString = "[Barang.Kode]='" & pKode & "' and [Gudang.Kode]='" & pGudang & "'"
  End Sub
  Private Sub SetFormat()
    colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
    colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyOut.SummaryItem.DisplayFormat = setting.NumericFormatString
    colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colStock.DisplayFormat.FormatString = setting.NumericFormatString
    colStock.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("CekStockHistory.xml"))
  End Sub
  Private Sub ifSource_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles ifSource.ResolveSession
    e.Session = Session
  End Sub
End Class