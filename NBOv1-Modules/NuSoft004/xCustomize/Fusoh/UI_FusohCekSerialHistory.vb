Imports DevExpress.Xpo

Public Class UI_FusohCekSerialHistory
	Private pSerial As String, pItem As String
	Sub New(xSession As UnitOfWork, item As String, serial As String)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		session = xSession
		pItem = item
		pSerial = serial

		Text = "History Serial : " & item & " (" & serial & ")"
	End Sub
  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data Stock")
  End Sub
  Overrides Sub FirstLoad()
    xGridView.OptionsBehavior.Editable = False
    xGridView.OptionsBehavior.ReadOnly = True

    '==== start edit sbm 03-Apr-2021 ================

    '''''xGrid.DataSource = New XPQuery(Of Persistent.Fusoh_StokSerial)(session).Where(Function(w) w.Serial = pSerial AndAlso w.DetailMain.Barang.Kode = pItem).ToList
    Dim ds = New XPQuery(Of Persistent.Fusoh_StokSerial)(session).Where(Function(w) w.Serial = pSerial AndAlso w.DetailMain.Barang.Kode = pItem) _
    .Select(Function(s) New With {
                .NoBukti = s.DetailMain.Main.Kode,
                .Tanggal = s.DetailMain.Main.Tanggal,
                .Gudang = s.DetailMain.Gudang.Nama,
                .LengthIn = s.LengthIn,
                .LengthOut = s.LengthOut,
                .KodeDempyou = s.DetailMain.Main.OrderProduksi.Kode,
                .SisaDempyou = 0.0
              }).ToList

    Dim orderItem = New XPQuery(Of Persistent.Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang.Kode = pItem AndAlso w.Serial = pSerial).ToList

		For i = 0 To orderItem.Count - 1
			Dim xo = orderItem(i)

			' cek sudah diproduksi
			Dim sdhProduksi = ds.Where(Function(w) w.KodeDempyou = xo.Main.Kode).Sum(Function(s) s.LengthOut)
			Dim o = orderItem.Sum(Function(s) s.Length)

      If o > sdhProduksi Then
        '.SisaDempyou = CDbl(o - sdhProduksi)
        ds.Add(New With {.NoBukti = xo.Main.Kode, .Tanggal = xo.Main.Tanggal, .Gudang = xo.Main.Gudang.Nama, .LengthIn = 0.0, .LengthOut = 0.0, .KodeDempyou = xo.Main.Kode, .SisaDempyou = CDbl(xo.Length)})
      End If
    Next
    'ds(0).KodeDempyou

    xGrid.DataSource = ds.OrderByDescending(Function(o) o.Tanggal).ToList
    'xGridView.Editable = True
    '==== end edit sbm 03-Apr-2021 ================
  End Sub
End Class