Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Public Class UI_FusohCekData
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
				gridSQ.DataSource = New XPCollection(Of Persistent.Fusoh_Penawaran)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like)))
				gridSO.DataSource = New XPCollection(Of Persistent.Fusoh_OrderPenjualan)(session, New BinaryOperator("Penawaran.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
				gridSJ.DataSource = New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(session, New BinaryOperator("SODetail.Main.Penawaran.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like)).GroupBy(Function(g) g.Main).Select(Function(s) s.Key).ToList()
				gridIV.DataSource = New XPCollection(Of Persistent.Fusoh_InvoicePenjualan)(session, New BinaryOperator("NoOrder.Penawaran.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
			Case TipeTransaksi.SO
				Dim so = New XPCollection(Of Persistent.Fusoh_OrderPenjualan)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))

				gridSQ.DataSource = so.Where(Function(w) Not w.Penawaran Is Nothing).GroupBy(Function(g) g.Penawaran).Select(Function(s) s.Key).ToList
				gridSO.DataSource = so
				gridSJ.DataSource = New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(session, New BinaryOperator("SODetail.Main.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like)).GroupBy(Function(g) g.Main).Select(Function(s) s.Key).ToList()
				gridIV.DataSource = New XPCollection(Of Persistent.Fusoh_InvoicePenjualan)(session, New BinaryOperator("NoOrder.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
			Case TipeTransaksi.SJ
				Dim a As New XPCollection(Of Persistent.Fusoh_SuratJalan)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))

				gridSJ.DataSource = a
				If a.Count > 0 Then
					Dim SOList = a.SelectMany(Function(m) m.Detail).Where(Function(w) Not w.SODetail Is Nothing).GroupBy(Function(g) g.SODetail.Main).Select(Function(s) s.Key).ToList()

					gridSQ.DataSource = SOList.Where(Function(w) Not w.Penawaran Is Nothing).GroupBy(Function(g) g.Penawaran).Select(Function(s) s.Key).ToList
					gridSO.DataSource = SOList
					gridIV.DataSource = New XPCollection(Of Persistent.Fusoh_InvoicePenjualan)(session, New InOperator("NoOrder", SOList))
				End If
			Case TipeTransaksi.IV
				Dim invList = New XPCollection(Of Persistent.Fusoh_InvoicePenjualan)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
				Dim soList = invList.Where(Function(w) Not w.NoOrder Is Nothing).GroupBy(Function(g) g.NoOrder).Select(Function(s) s.Key).ToList

				gridSQ.DataSource = soList.Where(Function(w) Not w.Penawaran Is Nothing).GroupBy(Function(g) g.Penawaran).Select(Function(s) s.Key).ToList
				gridSO.DataSource = soList
				gridSJ.DataSource = New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(session, New InOperator("SODetail.Main", soList)).GroupBy(Function(g) g.Main).Select(Function(s) s.Key).ToList()
				gridIV.DataSource = invList
		End Select
	End Sub
End Class