Imports DevExpress.Xpo
Imports NuSoft.Utils.CustomAttribute
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent

Public Class UI_TravelCekData
	Public Enum TipeTransaksi
		'<EnumDescription("Penawaran Penjualan")> SQ = 0
		<EnumDescription("Travel Order")> SO = 1
		'<EnumDescription("Pengiriman Barang")> SJ = 2
		'<EnumDescription("DP Penjualan")> DP = 2
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
		If _tipeForm = TipeForm.Dialog Then
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.MinimizeBox = False
			Me.MaximizeBox = False
		End If
	End Sub
	Overrides Sub FirstLoad()
		If _tipeForm = TipeForm.Menu Then
			Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
			txtTipe.EditValue = TipeTransaksi.SO
		End If
		txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(TipeTransaksi))
	End Sub
	Public Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
		Select Case txtTipe.EditValue
			Case TipeTransaksi.SO
				Dim dataSO = New XPQuery(Of Travel_Order)(session).Where(Function(w) w.Kode.Contains(txtNoTransaksi.Text)).ToList
				gridSO.DataSource = dataSO
				gridDP.DataSource = New XPQuery(Of Travel_DownPayment)(session).Where(Function(w) dataSO.Contains(w.TravelOrder)).ToList
				gridIV.DataSource = New XPQuery(Of Travel_Invoice)(session).Where(Function(w) dataSO.Contains(w.TravelOrder)).ToList
				gridCP.DataSource = New XPQuery(Of Travel_PembayaranInvoiceDetail)(session).Where(Function(w) w.Main.Sumber.Id = SumberDataJenis.CP AndAlso dataSO.Contains(w.NoInvoice.TravelOrder)).ToList
				gridRF.DataSource = New XPQuery(Of Travel_PembayaranInvoiceDetail)(session).Where(Function(w) w.Main.Sumber.Id = SumberDataJenis.RF AndAlso dataSO.Contains(w.NoInvoice.TravelOrder)).ToList
			Case TipeTransaksi.IV
				Dim dataIV = New XPQuery(Of Travel_Invoice)(session).Where(Function(w) w.Kode.Contains(txtNoTransaksi.Text)).ToList
				Dim dataSO = New XPQuery(Of Travel_Order)(session).Where(Function(w) dataIV.Select(Function(s) s.TravelOrder).Contains(w)).ToList
				gridSO.DataSource = dataSO
				gridDP.DataSource = New XPQuery(Of Travel_DownPayment)(session).Where(Function(w) dataSO.Contains(w.TravelOrder)).ToList
				gridIV.DataSource = dataIV
				gridCP.DataSource = New XPQuery(Of Travel_PembayaranInvoiceDetail)(session).Where(Function(w) w.Main.Sumber.Id = SumberDataJenis.CP AndAlso dataIV.Contains(w.NoInvoice)).ToList
				gridRF.DataSource = New XPQuery(Of Travel_PembayaranInvoiceDetail)(session).Where(Function(w) w.Main.Sumber.Id = SumberDataJenis.RF AndAlso dataIV.Contains(w.NoInvoice)).ToList
		End Select
	End Sub
End Class