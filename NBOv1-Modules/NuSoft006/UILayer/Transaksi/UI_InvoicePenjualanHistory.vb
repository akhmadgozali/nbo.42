Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_InvoicePenjualanHistory
  Private _idinvoice As Int64
  Sub New(ByVal xIDInvoice As Int64)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _idinvoice = xIDInvoice
  End Sub
  Overrides Sub FirstLoad()
    Logic.Umum.xLoadLayout(xGridView, "IVDataHistory.xml")
    Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    xGrid.DataSource = New XPCollection(Of Persistent.PembayaranPiutangDetail)(session, New BinaryOperator("NoInvoice.Id", _idinvoice, BinaryOperatorType.Equal))
    Dim Setting As New NuSoft001.Logic.FinaSetting(session)
    colNilaiBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiBayar.DisplayFormat.FormatString = Setting.NumericFormatString
    colNilaiBayarCash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiBayarCash.DisplayFormat.FormatString = Setting.NumericFormatString
    colNilaiBayarRetur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiBayarRetur.DisplayFormat.FormatString = Setting.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = Setting.NumericFormatString
  End Sub
End Class