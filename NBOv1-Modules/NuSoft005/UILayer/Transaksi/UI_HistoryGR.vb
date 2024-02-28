Friend Class UI_HistoryGR
  Friend Sub LoadData(po As Persistent.OrderPembelian)
    txtNomorPO.Text = po.Kode
    txtTanggal.Text = po.Tanggal.ToString("dddd, dd MMMM yyyy")
    txtGudang.Text = po.Gudang.Nama
    txtVendorKode.Text = po.Vendor.Kode
    txtVendorNama.Text = po.Vendor.Nama
    txtUraian.Text = po.Uraian

    xGrid.DataSource = po.Detail
  End Sub
End Class