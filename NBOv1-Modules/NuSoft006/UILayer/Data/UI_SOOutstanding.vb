Imports DevExpress.Xpo

Public Class UI_SOOutstanding
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    xChart = nChart
    showChart = True
    showFilter = False
    useFeedbackSource = True
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    RefreshData()
  End Sub

  Public Overrides Sub RefreshData()
    Dim dataStok = New XPQuery(Of Persistent.PengirimanBarangDetail)(session).GroupBy(Function(g) g.Barang) _
      .Select(Function(s) New With {.Barang = s.Key, .Stok = s.Sum(Function(x) x.QtyInMinusQtyOut)}).ToList
    Dim ds = New XPQuery(Of Persistent.OrderPenjualanDetail)(session).Where(Function(w) w.QtyBelumDikirim > 0) _
      .Select(Function(s) New With {.NomorSO = s.Main.Kode, .Tanggal = s.Main.Tanggal, .NomorReff = s.Main.ReffNumber, .Barang = s.Barang,
      .Pelanggan = s.Main.Pelanggan, .Keterangan = s.Main.Catatan, .QtySO = s.Qty, .QtyStok = 0}).ToList

    For Each item In ds
      item.QtyStok = dataStok.Find(Function(f) f.Barang Is item.Barang).Stok
    Next

    xGrid.DataSource = ds

    nChart.Series(0).DataSource = ds.GroupBy(Function(g) g.Barang).Select(Function(s) New With {.Barang = s.Key, .QtySO = s.Sum(Function(x) x.QtySO)}).ToList
    nChart.Series(0).TopNOptions.Enabled = True
    nChart.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
    nChart.Series(0).TopNOptions.Count = 10
    nChart.Titles(0).Text = "Top 10 SO Outstanding"
    nChart.RefreshData()
  End Sub
End Class