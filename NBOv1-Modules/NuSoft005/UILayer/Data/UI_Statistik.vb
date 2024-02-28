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

    Dim xDataRI As New XPCollection(Of Persistent.PenerimaanInvoice)(session, New BetweenOperator("Tanggal", TglAwal.ToString("yyyy-MM-dd"), TglAkhir.ToString("yyyy-MM-dd")))
    Dim b = From z In xDataRI Group z By z.Vendor.Kode, z.Vendor.Nama Into Group Select Kode, Nama, TotalInvoice = Group.Sum(Function(x) x.NilaiInvoice * x.Kurs) Order By TotalInvoice Descending
    nChartRI.Series(0).DataSource = b
    nChartRI.Series(0).TopNOptions.Enabled = True
    nChartRI.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
    nChartRI.Series(0).TopNOptions.Count = 10
    nChartRI.RefreshData()
    Dim xDataGR As New XPCollection(Of Persistent.PenerimaanBarang)(session, New BetweenOperator("Tanggal", TglAwal.ToString("yyyy-MM-dd"), TglAkhir.ToString("yyyy-MM-dd")))
    Dim c = From z In xDataGR Group z By z.Vendor.Kode, z.Vendor.Nama Into Group Select Kode, Nama, TotalTransaksi = Group.Sum(Function(x) x.TotalTransaksi * x.Kurs) Order By TotalTransaksi Descending
    nChartGR.Series(0).DataSource = c
    nChartGR.Series(0).TopNOptions.Enabled = True
    nChartGR.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
    nChartGR.Series(0).TopNOptions.Count = 10
    nChartGR.RefreshData()
    Dim xDataHutang As New XPCollection(Of Persistent.ViewInvoice)(session)
    Dim d = From z In xDataHutang Group z By z.NoInvoice.Vendor.Id, z.NoInvoice.Vendor.Kode, z.NoInvoice.Vendor.Nama Into Group Select Kode, Nama, SisaSaldo = Group.Sum(Function(x) ((x.NoInvoice.NilaiInvoice - x.Terbayar) * x.NoInvoice.Kurs)) Where SisaSaldo > 0 Order By SisaSaldo Descending
    nChartTopHutang.Series(0).DataSource = d
    nChartTopHutang.Series(0).TopNOptions.Enabled = True
    nChartTopHutang.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
    nChartTopHutang.Series(0).TopNOptions.Count = 10
    nChartTopHutang.RefreshData()
    Dim xDataRI2 As New XPCollection(Of Persistent.PenerimaanInvoice)(session, New BinaryOperator("Tahun", Year, BinaryOperatorType.Equal))
    Dim e = From z In xDataRI2 Group z By z.Bulan Into Group Select Bulan = Bulan.ToString("MMMM"), BulanPendek = Bulan.ToString("MM"), TotalInvoice = Group.Sum(Function(x) x.NilaiInvoice * x.Kurs) Order By BulanPendek
    nChartPembelian.Series(0).DataSource = e
    nChartPembelian.RefreshData()
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