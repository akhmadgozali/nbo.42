Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Public Class UI_CekData
  Public Enum TipeTransaksi
    <EnumDescription("Penawaran Penjualan")> SQ = 0
    <EnumDescription("Order Penjualan")> SO = 1
    <EnumDescription("Pengiriman Barang")> SJ = 2
    <EnumDescription("Invoice Penjualan")> IV = 3
  End Enum
  Public Enum TipeForm
    <EnumDescription("Menu")> Menu = 0
    <EnumDescription("Dialog")> Dialog = 1
  End Enum
  Private _tipeForm As TipeForm
  Sub New(xTipeForm As TipeForm)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _tipeForm = xTipeForm
  End Sub
  Overrides Sub FirstLoad()
    If _tipeForm = TipeForm.Menu Then
      Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
      txtTipe.EditValue = TipeTransaksi.SQ
    End If
    txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(TipeTransaksi))
  End Sub
  Public Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
    Select Case txtTipe.EditValue
      Case TipeTransaksi.SQ
        gridSQ.DataSource = New XPCollection(Of Persistent.Penawaran)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like)))
        gridSO.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(session, New BinaryOperator("NoPenawaran.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        gridSJ.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(session, New BinaryOperator("NoOrder.NoPenawaran.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        gridIV.DataSource = New XPCollection(Of Persistent.InvoicePenjualan)(session, New BinaryOperator("NoOrder.NoPenawaran.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
      Case TipeTransaksi.SO
        gridSQ.DataSource = Nothing
        gridSO.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        gridSJ.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(session, New BinaryOperator("NoOrder.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        gridIV.DataSource = New XPCollection(Of Persistent.InvoicePenjualan)(session, New BinaryOperator("NoOrder.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
      Case TipeTransaksi.SJ
        Dim a As New XPCollection(Of Persistent.PengirimanBarang)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        gridSQ.DataSource = Nothing
        gridSO.DataSource = Nothing
        gridSJ.DataSource = a
        If a.Count > 0 Then
          gridIV.DataSource = New XPCollection(Of Persistent.InvoicePenjualan)(session, New BinaryOperator("NoOrder.Kode", "%" & a(0).NoOrder.Kode & "%", BinaryOperatorType.Like))
        End If
      Case TipeTransaksi.IV
        gridSQ.DataSource = Nothing
        gridSO.DataSource = Nothing
        gridSJ.DataSource = Nothing
        gridIV.DataSource = New XPCollection(Of Persistent.InvoicePenjualan)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
    End Select
  End Sub
End Class