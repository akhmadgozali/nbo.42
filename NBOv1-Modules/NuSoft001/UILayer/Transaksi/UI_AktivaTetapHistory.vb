Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Public Class UI_AktivaTetapHistory
  Private xKodeAsset As String, xPenyusutanPerBulan As Double
  Sub New(KodeAsset As String)
    InitializeComponent()
    AllowSave = False
    NoDropIdentityMap = True
    xKodeAsset = KodeAsset
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AktivaTetapHistoryGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AktivaTetapHistoryGrid.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AktivaTetapHistory.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AktivaTetapHistory.xml"))
    End If
    Dim setting As New Logic.FinaSetting(session)
    colNilaiMasuk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiMasuk.DisplayFormat.FormatString = setting.NumericFormatString
    colNilaiMasuk.SummaryItem.DisplayFormat = setting.NumericFormatString
    colNilaiKeluar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiKeluar.DisplayFormat.FormatString = setting.NumericFormatString
    colNilaiKeluar.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHargaMasuk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaMasuk.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaMasuk.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHargaKeluar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaKeluar.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaKeluar.SummaryItem.DisplayFormat = setting.NumericFormatString



    txtHargaBeli.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtHargaBeli.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiResidu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiResidu.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiBuku.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiBuku.Properties.Mask.EditMask = setting.NumericFormatToString
    txtAkumulasiDepr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtAkumulasiDepr.Properties.Mask.EditMask = setting.NumericFormatToString
    AllowSave = False
  End Sub
  Overrides Sub LoadAfterInitialize()
    Dim xData As Persistent.viewAktivaTetap = session.FindObject(Of Persistent.viewAktivaTetap)(New BinaryOperator("f_asset.Kode", xKodeAsset, BinaryOperatorType.Equal))
    Me.Text = "History Aktiva Tetap : " & xKodeAsset
    If Not xData Is Nothing Then
      txtKode.Text = xData.f_asset.Kode
      txtNama.Text = xData.f_asset.Nama
      txtKelompok.EditValue = xData.f_asset.Kelompok.Kode
      txtUmur.EditValue = xData.f_asset.Kelompok.Umur
      txtTglBeli.EditValue = xData.f_asset.TanggalBeli
      txtHargaBeli.EditValue = xData.f_asset.Harga
      txtQty.EditValue = xData.f_asset.Qty
      txtNilaiResidu.EditValue = xData.d_residuvalue
      txtNilaiBuku.EditValue = xData.d_bookvalue
      txtAkumulasiDepr.EditValue = xData.d_amortization
      xPenyusutanPerBulan = xData.f_asset.Depreciation(0).Nilai

      Dim xDetail As New XPCollection(Of Persistent.AktivaTransaksiDetail)(session, New BinaryOperator("Asset.Kode", xKodeAsset, BinaryOperatorType.Equal))
      xGrid.DataSource = xDetail
    Else
      MsgBox("Data tidak ditemukan.")
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("AktivaTetapHistoryGrid.xml"))
  End Sub
  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data Aktiva Tetap")
  End Sub
  Private Sub btnResetNilai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetNilai.ItemClick
    If MsgBox("Apakah anda ingin mereset nilai transaksi (Penyusutan,Writeoff) aktiva tetap ini?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
      Dim xdtTransaksi As New XPCollection(Of Persistent.AktivaTransaksiDetail)(session, New BinaryOperator("Asset.Kode", xKodeAsset, BinaryOperatorType.Equal), New SortProperty("Main.Tanggal", DevExpress.Xpo.DB.SortingDirection.Ascending))
      Dim xNilaiAktiva As Double = 0, xQty As Double = 0, xQtyOut As Double = 0

      xQty = CDbl(txtQty.EditValue)
      xNilaiAktiva = CDbl(txtHargaBeli.EditValue)

      For pI = 0 To xdtTransaksi.Count - 1
        If xdtTransaksi(pI).Main.Tipe = Persistent.eTipeTransaksiAsset.WriteOff Then
          xQty = xQty - xdtTransaksi(pI).Qty
          xdtTransaksi(pI).NilaiKeluar = xNilaiAktiva
          xdtTransaksi(pI).NilaiBuku = xNilaiAktiva
          xQtyOut = xQtyOut + xdtTransaksi(pI).Qty
          xdtTransaksi(pI).Asset.QtyOut = xQtyOut
        End If
        If xdtTransaksi(pI).Main.Tipe = Persistent.eTipeTransaksiAsset.Penyusutan Then
          xdtTransaksi(pI).Qty = xQty
          xNilaiAktiva = xNilaiAktiva - xPenyusutanPerBulan
        End If
      Next

      session.CommitChanges()
      MsgBox("Proses selesai.")
    End If
  End Sub
End Class