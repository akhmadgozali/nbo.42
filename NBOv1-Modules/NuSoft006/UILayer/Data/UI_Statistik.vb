Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Public Class UI_Statistik
  Private setting As NuSoft001.Logic.FinaSetting
  Private editAsign As Boolean
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    LoadLayout()
    editAsign = True
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    setting = New NuSoft001.Logic.FinaSetting(session)
    Dim period = New DevExpress.Xpo.XPCollection(Of NuSoft001.Persistent.Periode)(session)
    txtBulan.Properties.Items.Clear()
    For i = 1 To 12
      txtBulan.Properties.Items.Add(MonthName(i))
    Next
    For i = (Now.Year - 10) To (Now.Year + 10)
      txtTahun.Properties.Items.Add(i.ToString())
    Next

    txtBulan.SelectedIndex = Now.Month - 1
    txtTahun.EditValue = Now.Year
    fillData(txtBulan.SelectedIndex + 1, CInt(txtTahun.EditValue))
    editAsign = False
  End Sub
  Private Sub fillData(ByVal Month As Integer, ByVal Year As Integer)
    Dim TglAwal As Date, TglAkhir As Date
    TglAwal = New Date(Year, Month, 1)
    TglAkhir = TglAwal.AddMonths(1).AddDays(-(TglAwal.AddMonths(1).Day))

    Dim xDataIV As New XPCollection(Of Persistent.InvoicePenjualanDetail)(session, New BetweenOperator("Main.Tanggal", TglAwal.ToString("yyyy-MM-dd"), TglAkhir.ToString("yyyy-MM-dd")))
    Dim b = From z In xDataIV Group z By z.Barang.Kode, z.Barang.Nama Into Group Select Kode, Nama, TotalQty = Group.Sum(Function(x) x.Qty) Order By TotalQty Descending
    nChartProdukTerlaris.Series(0).DataSource = b
    nChartProdukTerlaris.Series(0).TopNOptions.Enabled = True
    nChartProdukTerlaris.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
    nChartProdukTerlaris.Series(0).TopNOptions.Count = 10
    nChartProdukTerlaris.RefreshData()

    Dim c = From z In xDataIV Group z By z.Barang.Kode, z.Barang.Nama Into Group Select Kode, Nama, TotalTransaksi = Group.Sum(Function(x) x.DPP * x.Main.Kurs) Order By TotalTransaksi Descending
    nChartOmzet.Series(0).DataSource = c
    nChartOmzet.Series(0).TopNOptions.Enabled = True
    nChartOmzet.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
    nChartOmzet.Series(0).TopNOptions.Count = 10
    nChartOmzet.RefreshData()

    Dim d = From z In xDataIV Group z By z.Barang.Kode, z.Barang.Nama Into Group Select Kode, Nama, SisaSaldo = Group.Sum(Function(x) ((x.DPP * x.Main.Kurs) - x.PengirimanBarang.NilaiHPP)) Order By SisaSaldo Descending
    nChartLaba.Series(0).DataSource = d
    nChartLaba.Series(0).TopNOptions.Enabled = True
    nChartLaba.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
    nChartLaba.Series(0).TopNOptions.Count = 10
    nChartLaba.RefreshData()

    Dim xDataIV2 As New XPCollection(Of Persistent.InvoicePenjualan)(session, New BinaryOperator("Tahun", Year, BinaryOperatorType.Equal))
    Dim e = From z In xDataIV2 Group z By z.Bulan Into Group Select Bulan = Bulan.ToString("MMMM"), BulanPendek = Bulan.ToString("MM"), TotalInvoice = Group.Sum(Function(x) x.NilaiInvoice * x.Kurs) Order By BulanPendek
    nChartCustomer.Series(0).DataSource = e
    nChartCustomer.RefreshData()
  End Sub
  Private Sub LoadLayout()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("Statistik.xml")) = True Then
      lytStatistik.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("Statistik.xml"))
    End If
  End Sub
  Private Sub btnPrintPreview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPreview.ItemClick
    lytStatistik.ShowPrintPreview()
  End Sub
  Private Sub txtTahun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTahun.EditValueChanging
    If Not e.NewValue Is Nothing And editAsign = False Then
      fillData(txtBulan.SelectedIndex + 1, e.NewValue)
    End If
  End Sub
  Private Sub txtBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBulan.SelectedIndexChanged
    If editAsign = False Then
      fillData(txtBulan.SelectedIndex + 1, txtTahun.EditValue)
    End If
  End Sub
End Class