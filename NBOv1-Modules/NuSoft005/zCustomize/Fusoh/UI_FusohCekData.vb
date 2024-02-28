Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Public Class UI_FusohCekData
	Public Enum TipeTransaksi
		<EnumDescription("Order Pembelian")> PO = 0
		<EnumDescription("Exim")> EX = 1
		<EnumDescription("Penerimaan Barang")> GR = 2
		<EnumDescription("Invoice Pembelian")> RI = 3
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
			txtTipe.EditValue = TipeTransaksi.PO
		End If
		txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(TipeTransaksi))
	End Sub
  Public Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
    Select Case txtTipe.EditValue
      Case TipeTransaksi.PO
        Dim poList = New XPCollection(Of Persistent.Fusoh_OrderPembelian)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))

        gridPO.DataSource = poList
        gridEX.DataSource = New XPQuery(Of Persistent.Fusoh_Exim)(session).Where(Function(w) poList.Contains(w.PO)).ToList
        gridGR.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) poList.Contains(w.Exim.PO)).ToList 'New XPCollection(Of Persistent.PenerimaanBarang)(session, New BinaryOperator("NoOrder.Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        gridRI.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) poList.Contains(w.NoOrder)).ToList
      Case TipeTransaksi.EX
        Dim exList = New XPCollection(Of Persistent.Fusoh_Exim)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))

        gridEX.DataSource = exList
        gridPO.DataSource = exList.Where(Function(w) Not w.PO Is Nothing).GroupBy(Function(g) g.PO).Select(Function(s) s.Key).ToList
        gridGR.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) exList.Contains(w.Exim)).ToList
        gridRI.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) exList.Contains(w.NoExim)).ToList
      Case TipeTransaksi.GR
        Dim grList = New XPCollection(Of Persistent.Fusoh_PenerimaanBarang)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        Dim exList = grList.Where(Function(w) Not w.Exim Is Nothing).GroupBy(Function(g) g.Exim).Select(Function(s) s.Key).ToList

        gridGR.DataSource = grList
        gridEX.DataSource = exList
        gridPO.DataSource = exList.Where(Function(w) Not w.PO Is Nothing).GroupBy(Function(g) g.PO).Select(Function(s) s.Key).ToList
        gridRI.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) exList.Contains(w.NoExim)).ToList
      Case TipeTransaksi.RI
        Dim riList = New XPCollection(Of Persistent.Fusoh_PenerimaanInvoice)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        Dim exList = riList.Where(Function(w) Not w.NoExim Is Nothing).GroupBy(Function(g) g.NoExim).Select(Function(s) s.Key).ToList
        Dim poList = riList.Where(Function(w) Not w.NoOrder Is Nothing).GroupBy(Function(g) g.NoOrder).Select(Function(s) s.Key).ToList

        gridRI.DataSource = riList
        gridEX.DataSource = exList
        gridPO.DataSource = poList
        gridGR.DataSource = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) exList.Contains(w.Exim)).ToList
    End Select
  End Sub
End Class