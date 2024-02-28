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
    Dim xDataDempyou As New XPCollection(Of NuSoft004.Persistent.Fusoh_OrderProduksi)(session, New BinaryOperator("SODetail.Main.Kode", xNoTransaksi, BinaryOperatorType.Equal))
		xGrid.DataSource = xDataDempyou.Select(Function(w) New With {.Tanggal = w.Tanggal, .Kode = w.Kode, .KodeBarang = w.SODetail.Barang.Kode, .NamaBarang = w.SODetail.Barang.Nama, .Qty = w.Qty, .QtyCutting = w.QtyCutting, .QtyProduksi = w.QtyProduksi, .StatusTransaksi = w.StatusTransaksi, .Produksi = w.Produksi})
	End Sub
End Class