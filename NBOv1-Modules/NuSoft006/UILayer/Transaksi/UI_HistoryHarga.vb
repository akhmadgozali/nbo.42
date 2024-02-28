Imports DevExpress.Xpo

Public Class UI_HistoryHarga
  Public Sub LoadData(session As UnitOfWork, kontak As NuSoft001.Persistent.Kontak, barang As NuSoft004.Persistent.Barang, dariSQ As Boolean)
    txtKodePelanggan.Text = kontak.Kode
    txtNamaPelanggan.Text = kontak.Nama
    txtKodeBarang.Text = barang.Kode
    txtNamaBarang.Text = barang.Nama

    If dariSQ Then
      colKode.FieldName = NameOf(Persistent.PenawaranDetail.Main) & "." & NameOf(Persistent.Penawaran.Kode)
      colTanggal.FieldName = NameOf(Persistent.PenawaranDetail.Main) & "." & NameOf(Persistent.Penawaran.Tanggal)
      colHarga.FieldName = NameOf(Persistent.PenawaranDetail.Harga)
      colQty.FieldName = NameOf(Persistent.PenawaranDetail.Qty)
      colSatuan.FieldName = NameOf(Persistent.PenawaranDetail.Satuan) & "." & NameOf(NuSoft004.Persistent.Satuan.Kode)
      colKeterangan.FieldName = NameOf(Persistent.PenawaranDetail.Main) & "." & NameOf(Persistent.Penawaran.Uraian)

      Dim ds = New XPQuery(Of Persistent.PenawaranDetail)(session).Where(Function(w) w.Barang Is barang AndAlso w.Main.Pelanggan Is kontak).OrderByDescending(Function(o) o.Main.Tanggal).ToList
      xGrid.DataSource = ds
    Else
      colKode.FieldName = NameOf(Persistent.OrderPenjualanDetail.Main) & "." & NameOf(Persistent.OrderPenjualan.Kode)
      colTanggal.FieldName = NameOf(Persistent.OrderPenjualanDetail.Main) & "." & NameOf(Persistent.OrderPenjualan.Tanggal)
      colHarga.FieldName = NameOf(Persistent.OrderPenjualanDetail.Harga)
      colQty.FieldName = NameOf(Persistent.OrderPenjualanDetail.Qty)
      colSatuan.FieldName = NameOf(Persistent.OrderPenjualanDetail.Satuan) & "." & NameOf(NuSoft004.Persistent.Satuan.Kode)
      colKeterangan.FieldName = NameOf(Persistent.OrderPenjualanDetail.Main) & "." & NameOf(Persistent.OrderPenjualan.Uraian)

      Dim ds = New XPQuery(Of Persistent.OrderPenjualanDetail)(session).Where(Function(w) w.Barang Is barang AndAlso w.Main.Pelanggan Is kontak).OrderByDescending(Function(o) o.Main.Tanggal).ToList
      xGrid.DataSource = ds
    End If
  End Sub
End Class