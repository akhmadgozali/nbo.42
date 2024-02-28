Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Public Class UI_FusohCekDempyou
  Public xNoTransaksi As String
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    Dim xDataGR As New XPCollection(Of Persistent.Fusoh_PenerimaanBarangDetailSerial)(session, New BinaryOperator("DetailMain.Main.Kode", xNoTransaksi, BinaryOperatorType.Equal))

    Dim xDataDempyou As New XPCollection(Of NuSoft004.Persistent.Fusoh_OrderProduksiBahanBaku)(session, New InOperator("Serial", xDataGR.Select(Function(s) s.Serial).ToList))

    xGrid.DataSource = xDataDempyou
  End Sub
End Class