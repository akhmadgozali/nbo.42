Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_SaldoHutang
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
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("DataSaldoHutang.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("DataSaldoHutang.xml"))
    End If

    Dim a As New NuSoft001.Logic.FinaSetting(session)
    colNilaiInvoice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiInvoice.DisplayFormat.FormatString = a.NumericFormatString
    colNilaiBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiBayar.DisplayFormat.FormatString = a.NumericFormatString
    colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldo.DisplayFormat.FormatString = a.NumericFormatString

    Dim xData As New XPCollection(Of Persistent.ViewInvoice)(session)

    If xData.Count > 0 Then
      Dim b = From z In xData Group z By z.NoInvoice.Regional, z.NoInvoice.Vendor.Id, z.NoInvoice.Vendor.Kode, z.NoInvoice.Vendor.Nama, z.NoInvoice.Uang Into Group Select Regional, Kode, Nama, MataUang = Uang.Kode, TotalInvoice = Group.Sum(Function(x) x.NoInvoice.NilaiInvoice), TotalBayar = Group.Sum(Function(x) x.Terbayar), SisaSaldo = Group.Sum(Function(x) (x.NoInvoice.NilaiInvoice - x.Terbayar)) Order By Kode
      xGrid.DataSource = b
			'xGridView.ActiveFilterString = "Not [SisaSaldo] In ('0')"
			xGridView.ActiveFilterString = "[SisaSaldo]>=1"

			Dim c = From z In xData Group z By z.NoInvoice.Vendor.Id, z.NoInvoice.Vendor.Kode, z.NoInvoice.Vendor.Nama Into Group Select Kode, Nama, SisaSaldo = Group.Sum(Function(x) ((x.NoInvoice.NilaiInvoice - x.Terbayar) * x.NoInvoice.Kurs)) Where SisaSaldo > 0 Order By SisaSaldo Descending

      nChart.Series(0).DataSource = c
      nChart.Series(0).TopNOptions.Enabled = True
      nChart.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
      nChart.Series(0).TopNOptions.Count = 10
      nChart.Titles(0).Text = "Top 10 Saldo Hutang (" & session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(a.MultiMataUangDefault)).Kode.ToString & ")"
      nChart.RefreshData()
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("DataSaldoHutang.xml"))
  End Sub
End Class