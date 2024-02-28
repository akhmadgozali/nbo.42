Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Friend Class UI_FusohProduksiHistory
	Private _produksi As Persistent.Fusoh_StokMain
	Sub New(produksi As Persistent.Fusoh_StokMain, xSession As DevExpress.Xpo.UnitOfWork)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		session = xSession
		_produksi = produksi
	End Sub
	Overrides Sub FirstLoad()
		xGridView.OptionsBehavior.Editable = False
		xGridView.OptionsBehavior.ReadOnly = True

		Dim singleS = _produksi.Detail.Where(Function(m) m.QtyIn > 0).ToList
		Me.Text = "History Status : " & _produksi.Kode
		If singleS.Count > 0 Then
			Me.Text &= " | " & singleS(0).Barang.Kode & " - " & singleS(0).Barang.Nama & " => Qty : " & singleS(0).QtyIn
		End If

		xGrid.DataSource = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(m) m.ProduksiDetail Is singleS(0)).ToList
	End Sub
End Class