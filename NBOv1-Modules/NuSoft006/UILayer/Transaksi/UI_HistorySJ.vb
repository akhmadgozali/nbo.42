Friend Class UI_HistorySJ
  Friend Sub LoadData(so As Persistent.OrderPenjualan)
    txtNomorSO.Text = so.Kode
    txtTanggal.Text = so.Tanggal.ToString("dddd, dd MMMM yyyy")
    txtReffNumber.Text = so.ReffNumber
    txtPelangganKode.Text = so.Pelanggan.Kode
    txtPelangganNama.Text = so.Pelanggan.Nama
    txtUraian.Text = so.Uraian

    xGrid.DataSource = so.Detail
  End Sub
End Class