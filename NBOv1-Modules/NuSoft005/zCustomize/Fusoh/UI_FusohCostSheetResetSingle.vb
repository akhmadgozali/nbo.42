Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent
Imports NuSoft.Utils.Win

Friend Class UI_FusohCostSheetResetSingle
	Friend Property ItemCostSheet As Persistent.Fusoh_PenerimaanInvoice
	Friend Property ModeShow As Boolean

	Private data As New List(Of ResetSingleStructure)

	Public Overrides Sub FirstLoad()
		If ModeShow Then
			gridBand2.Visible = False
			btnStartReset.Visibility = BarItemVisibility.Never
		End If

		txtSupplier.Text = ItemCostSheet.IndukInvoice.Vendor.Nama
		txtNoCostSheet.Text = ItemCostSheet.Kode
		txtNoInvoice.Text = ItemCostSheet.IndukInvoice.Kode
		If Not ItemCostSheet.IndukInvoice.NoOrder Is Nothing Then
			txtNomorPO.Text = ItemCostSheet.IndukInvoice.NoOrder.Kode
		End If
		txtTotalInvoice.Text = ItemCostSheet.IndukInvoice.TotalIDR.ToString("n2")
		txtTotalCostSheet.Text = ItemCostSheet.IndukInvoice.TotalCostIDR.ToString("n2")
		txtTotalInvoiceCostSheet.Text = (ItemCostSheet.IndukInvoice.TotalIDR + ItemCostSheet.IndukInvoice.TotalCostIDR).ToString("n2")

		If ItemCostSheet.IndukInvoice.Sumber.Id = SumberDataJenis.RI Then
			Dim daftarGr = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim.PO Is ItemCostSheet.IndukInvoice.NoOrder).ToList
			For Each x In daftarGr
				For Each det In x.Detail
					data.Add(New ResetSingleStructure() With {.Row = det, .Harga = det.Harga})
				Next
			Next
		Else
			Dim daftarGr = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim.Invoice Is ItemCostSheet.IndukInvoice).ToList
			For Each x In daftarGr
				For Each det In x.Detail
					data.Add(New ResetSingleStructure() With {.Row = det, .Harga = det.Harga})
				Next
			Next
		End If


		xGrid.DataSource = data
	End Sub
	Private Sub btnStartReset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnStartReset.ItemClick
		xGrid.BeginUpdate()
		For Each x In data
			Dim detInvoice = ItemCostSheet.IndukInvoice.Detail.ToList.Find(Function(f) f.PODetail Is x.Row.EximDetail.PODetail)
			If Not detInvoice Is Nothing Then
				'MsgBox("RI : " & detInvoice.Main.Kode & vbCrLf &
				'			 "Total Pembelian IDR: " & detInvoice.TotalPembelianIDR & vbCrLf &
				'			 "Total Pembelian IDR : " & detInvoice.TotalIDR & " + " & detInvoice.TotalCostIDR & vbCrLf &
				'			 "Total TotalCostIDR IDR : " & detInvoice.TotalCostBukanImportDutyIDR & " + " & detInvoice.TotalCostImportDutyIDR & vbCrLf &
				'			 "TotalCostBukanImportDutyIDR :" & detInvoice.Id & "(" & detInvoice.Weight & " / " & detInvoice.Main.TotalWeight & ") * " & detInvoice.Main.TotalCostBukanImportDutyIDR &
				' "Qty :" & x.Row.Qty)

				x.Row.Harga = (detInvoice.TotalPembelianIDR) / x.Row.Qty
				x.HargaReset = x.Row.Harga
			End If
		Next
		session.CommitChanges()
		xGrid.EndUpdate()
		BandedGridView1.UpdateSummary()
		MessageBox.Show("Reset HPP Selesai")
	End Sub
End Class
Friend Class ResetSingleStructure
	Public Property Row As Persistent.Fusoh_PenerimaanBarangDetail
	Public ReadOnly Property NoPenerimaan As String
		Get
			Return Row.Main.Kode
		End Get
	End Property
	Public ReadOnly Property KodeBarang As String
		Get
			Return Row.Barang.Kode
		End Get
	End Property
	Public ReadOnly Property NamaBarang As String
		Get
			Return Row.Barang.Nama
		End Get
	End Property
	Public ReadOnly Property Qty As Double
		Get
			Return Row.Qty
		End Get
	End Property
	Public Property Harga As Double
	Public ReadOnly Property Subtotal As Double
		Get
			Return Qty * Harga
		End Get
	End Property

	Public Property HargaReset As Double
	Public ReadOnly Property SubtotalReset As Double
		Get
			Return Qty * HargaReset
		End Get
	End Property
End Class