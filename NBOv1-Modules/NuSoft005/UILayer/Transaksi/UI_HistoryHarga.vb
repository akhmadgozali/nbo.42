Imports DevExpress.Xpo

Public Class UI_HistoryHarga
  Public Sub LoadData(session As UnitOfWork, barang As NuSoft004.Persistent.Barang)
    txtKodeBarang.Text = barang.Kode
    txtNamaBarang.Text = barang.Nama

    colKode.FieldName = NameOf(Persistent.OrderPembelianDetail.Main) & "." & NameOf(Persistent.OrderPembelian.Kode)
    colTanggal.FieldName = NameOf(Persistent.OrderPembelianDetail.Main) & "." & NameOf(Persistent.OrderPembelian.Tanggal)
    colKodeSupplier.FieldName = NameOf(Persistent.OrderPembelianDetail.Main) & "." & NameOf(Persistent.OrderPembelian.Vendor) & "." & NameOf(NuSoft001.Persistent.Kontak.Kode)
    colNamaSupplier.FieldName = NameOf(Persistent.OrderPembelianDetail.Main) & "." & NameOf(Persistent.OrderPembelian.Vendor) & "." & NameOf(NuSoft001.Persistent.Kontak.Nama)
    colHarga.FieldName = NameOf(Persistent.OrderPembelianDetail.Harga)
    colQty.FieldName = NameOf(Persistent.OrderPembelianDetail.Qty)
    colSatuan.FieldName = NameOf(Persistent.OrderPembelianDetail.Satuan) & "." & NameOf(NuSoft004.Persistent.Satuan.Kode)
    colKeterangan.FieldName = NameOf(Persistent.OrderPembelianDetail.Main) & "." & NameOf(Persistent.OrderPembelian.Uraian)

    Dim ds = New XPQuery(Of Persistent.OrderPembelianDetail)(session).Where(Function(w) w.Barang Is barang).OrderByDescending(Function(o) o.Main.Tanggal).ToList
    xGrid.DataSource = ds
  End Sub
End Class