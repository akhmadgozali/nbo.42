Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports DevExpress.XtraCharts

Public Class UI_Statistik
  Private setting As Logic.FinaSetting
  Private xPeriodeTanggal As Date, xAkhirPeriode As Date, xAwalPeriode As Date
  Private editasign As Boolean
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    LoadLayout()
    editasign = True
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    setting = New Logic.FinaSetting(session)
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
    editasign = False
    SetFormat()
    fillData(txtBulan.SelectedIndex + 1, CInt(txtTahun.EditValue))
    nChartKas.RuntimeHitTesting = True
    nChartNeraca.RuntimeHitTesting = True
    nChartLR.RuntimeHitTesting = True
  End Sub
  Private Sub fillData(ByVal Month As Integer, ByVal Year As Integer)
    'isi saldo kas/bank
    xAwalPeriode = New Date(CInt(txtTahun.Text), txtBulan.SelectedIndex + 1, 1)
    xPeriodeTanggal = xAwalPeriode.AddMonths(1) 'xPeriodeTanggal.AddMonths(1).AddDays(-(xPeriodeTanggal.AddMonths(1).Day))
    xAkhirPeriode = xPeriodeTanggal.AddDays(-1)

    Dim details As New XPCollection(Of Persistent.Report.BukuBesar)(session, New BinaryOperator("Id", 0, BinaryOperatorType.Equal))
    'Dim xCoa As New XPCollection(Of Persistent.Coa)(session, New GroupOperator(GroupOperatorType.Or, New BinaryOperator("Tipe", 1, BinaryOperatorType.Equal), New BinaryOperator("Tipe", 2, BinaryOperatorType.Equal)))
    Dim xCoa As XPCollection(Of Persistent.Coa)
    xCoa = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.Kas})
    For pi = 0 To xCoa.Count - 1
      Dim item As New Persistent.Report.BukuBesar(session), xSaldoValas As Double = 0.0
      Dim xSaldo As Double = CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, xCoa(pi).Id, xPeriodeTanggal.ToString("yyyy-MM-dd"))))
      If xCoa(pi).MataUang.Id <> setting.MultiMataUangDefault Then
        xSaldoValas = CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceValas, xCoa(pi).Id, xPeriodeTanggal.ToString("yyyy-MM-dd"))))
      End If
      item.AkunDetail = xCoa(pi)
      item.AkunMain = Nothing
      item.Id = 0
      item.Keterangan = "Saldo"
      item.NoBukti = ""
      item.SaldoAwal = 0
      item.SumberData = Nothing
      item.Tanggal = New Date(CInt(txtTahun.Text), txtBulan.SelectedIndex + 1, 1)
      item.Urutan = 0
      item.Debit = 0
      item.Kredit = 0
      item.SaldoAwal = xSaldo
      item.SaldoAwalValas = xSaldoValas
      If xSaldo > 0 Or xSaldoValas > 0 Then
        details.Add(item)
      End If
    Next
    Dim sortCollection As SortingCollection = New SortingCollection()
    sortCollection.Add(New SortProperty("SaldoAwal", DB.SortingDirection.Ascending))
    xGridCOA.DataSource = details
    details.Sorting = sortCollection

    nChartKas.Series(0).DataSource = details
    nChartKas.Series(0).TopNOptions.Enabled = True
    nChartKas.Series(0).TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
    nChartKas.Series(0).TopNOptions.Count = 5
    nChartKas.RefreshData()
    'isikan grafik neraca
    nChartNeraca.Series(0).Points.Clear()
    nChartNeraca.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint("Aktiva", CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetSaldoStatistik, 0, xAkhirPeriode.ToString("yyyy-MM-dd"))))))
    nChartNeraca.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint("Hutang", CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetSaldoStatistik, 1, xAkhirPeriode.ToString("yyyy-MM-dd"))))))
    nChartNeraca.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint("Modal", CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetSaldoStatistik, 2, xAkhirPeriode.ToString("yyyy-MM-dd"))))))
    nChartNeraca.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint("LabaRugi", CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetSaldoStatistik, 3, xAkhirPeriode.ToString("yyyy-MM-dd"))))))

    'isikan grafik labarugi
    nChartLR.Series(0).Points.Clear()
    nChartLR.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint("Pendapatan", CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetSaldoStatistik, 7, xAkhirPeriode.ToString("yyyy-MM-dd"))))))
    nChartLR.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint("Biaya", CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetSaldoStatistik, 8, xAkhirPeriode.ToString("yyyy-MM-dd"))))))
    nChartLR.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint("LabaRugi", CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetSaldoStatistik, 9, xAkhirPeriode.ToString("yyyy-MM-dd"))))))
  End Sub
  Private Sub SetFormat()
    colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldo.DisplayFormat.FormatString = setting.NumericFormatString
    colSaldo.SummaryItem.DisplayFormat = setting.NumericFormatString
    colSaldoValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldoValas.DisplayFormat.FormatString = setting.NumericFormatString
    colSaldoValas.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Private Sub LoadLayout()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("Statistik.xml")) = True Then
      lytStatistik.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("Statistik.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("StatistikGridKasBank.xml")) = True Then
      xGridCoaView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("StatistikGridKasBank.xml"))
    End If
  End Sub
  Private Sub xGridCoaView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridCoaView.ColumnWidthChanged
    xGridCoaView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("StatistikGridKasBank.xml"))
  End Sub
  Private Sub xGridCOA_DoubleClick(sender As Object, e As EventArgs) Handles xGridCOA.DoubleClick
    If Not xGridCoaView.GetFocusedRowCellDisplayText(colKode) Is Nothing Then
      Dim xKode As String = xGridCoaView.GetFocusedRowCellDisplayText(colKode)
      Dim xFilter As CriteriaOperator, result As New List(Of CriteriaOperator)
      result.Add(New BinaryOperator("Akun.Kode", xKode, BinaryOperatorType.Equal))
      result.Add(New BinaryOperator("Main.Tanggal", xAkhirPeriode, BinaryOperatorType.LessOrEqual))
      xFilter = GroupOperator.And(result)
      Dim a As New UI_DaftarGLDetail(xFilter, "Detail GL : " & xKode)
      a.MenuId = Me.MenuId
      a.session = Me.session
      a.NamaDatabase = Me.NamaDatabase
      a.TampilkanData()
      a.ShowMDI()
    End If
  End Sub
  Private Sub btnPrintPreview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPreview.ItemClick
    lytStatistik.ShowPrintPreview()
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    fillData(txtBulan.SelectedIndex + 1, CInt(txtTahun.EditValue))
  End Sub
  Private Sub txtTahun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTahun.EditValueChanging
    If Not e.NewValue Is Nothing And editasign = False Then
      fillData(txtBulan.SelectedIndex + 1, CInt(e.NewValue))
    End If
  End Sub
  Private Sub txtBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBulan.SelectedIndexChanged
    If editAsign = False Then
      fillData(txtBulan.SelectedIndex + 1, CInt(txtTahun.EditValue))
    End If
  End Sub

  Private Sub nChartKas_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles nChartKas.MouseClick
    Dim hi As ChartHitInfo = nChartKas.CalcHitInfo(e.X, e.Y)
    Dim point As SeriesPoint = hi.SeriesPoint
    If point IsNot Nothing Then
      Dim argument As String = point.Argument.ToString()
      Dim xKode As String = xGridCoaView.GetFocusedRowCellDisplayText(colKode)
      Dim xFilter As CriteriaOperator, result As New List(Of CriteriaOperator)
      result.Add(New BinaryOperator("Akun.Nama", point.Argument.ToString(), BinaryOperatorType.Equal))
      result.Add(New BinaryOperator("Main.Tanggal", xAkhirPeriode, BinaryOperatorType.LessOrEqual))
      xFilter = GroupOperator.And(result)
      Dim a As New UI_DaftarGLDetail(xFilter, "Detail GL : " & point.Argument.ToString())
      a.MenuId = Me.MenuId
      a.session = Me.session
      a.NamaDatabase = Me.NamaDatabase
      a.TampilkanData()
      a.ShowMDI()
    End If
  End Sub
  Private Sub nChartNeraca_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles nChartNeraca.MouseClick
    Dim hi As ChartHitInfo = nChartNeraca.CalcHitInfo(e.X, e.Y)
    Dim point As SeriesPoint = hi.SeriesPoint
    If point IsNot Nothing Then
      Dim argument As String = point.Argument.ToString()
      Dim xFilter As CriteriaOperator, result As New List(Of CriteriaOperator)

      Select Case argument.ToString
        Case "Aktiva"
          result.Add(New BinaryOperator("Akun.Tipe.Level2", Persistent.CoaEnum.eLevel2.Aktiva, BinaryOperatorType.Equal))
          result.Add(New BinaryOperator("Main.Tanggal", xAkhirPeriode, BinaryOperatorType.LessOrEqual))
        Case "Hutang"
          result.Add(New BinaryOperator("Akun.Tipe.Level2", Persistent.CoaEnum.eLevel2.Hutang, BinaryOperatorType.Equal))
          result.Add(New BinaryOperator("Main.Tanggal", xAkhirPeriode, BinaryOperatorType.LessOrEqual))
        Case "Modal"
          result.Add(New BinaryOperator("Akun.Tipe.Level2", Persistent.CoaEnum.eLevel2.Modal, BinaryOperatorType.Equal))
          result.Add(New BinaryOperator("Main.Tanggal", xAkhirPeriode, BinaryOperatorType.LessOrEqual))
        Case "LabaRugi"
          result.Add(New BinaryOperator("Akun.Tipe.Level1", Persistent.CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal))
          result.Add(New BetweenOperator("Main.Tanggal", xAwalPeriode, xAkhirPeriode))
      End Select
      xFilter = GroupOperator.And(result)
      Dim a As New UI_DaftarGLDetail(xFilter, "Detail GL : " & point.Argument.ToString())
      a.MenuId = Me.MenuId
      a.session = Me.session
      a.NamaDatabase = Me.NamaDatabase
      a.TampilkanData()
      a.ShowMDI()
    End If
  End Sub
  'Private Sub nChartLR_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles nChartLR.MouseClick
  '  Dim hi As ChartHitInfo = nChartLR.CalcHitInfo(e.X, e.Y)
  '  Dim point As SeriesPoint = hi.SeriesPoint
  '  If point IsNot Nothing Then
  '    Dim argument As String = point.Argument.ToString()
  '    Dim xFilter As CriteriaOperator, result As New List(Of CriteriaOperator)

  '    Select Case argument.ToString
  '      Case "Pendapatan"
  '        result.Add(New BinaryOperator("Akun.Tipe.Level2", Persistent.CoaEnum.eLevel2.Pendapatan, BinaryOperatorType.Equal))
  '        result.Add(New BinaryOperator("Main.Tanggal", xAkhirPeriode, BinaryOperatorType.LessOrEqual))
  '      Case "Biaya"
  '        result.Add(New BinaryOperator("Akun.Tipe.Level2", Persistent.CoaEnum.eLevel2.Biaya, BinaryOperatorType.Equal))
  '        result.Add(New BinaryOperator("Main.Tanggal", xAkhirPeriode, BinaryOperatorType.LessOrEqual))
  '      Case "LabaRugi"
  '        result.Add(New BinaryOperator("Akun.Tipe.Level1", Persistent.CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal))
  '        result.Add(New BetweenOperator("Main.Tanggal", xAwalPeriode, xAkhirPeriode))
  '    End Select
  '    xFilter = GroupOperator.And(result)
  '    Dim a As New UI_DaftarGLDetail(xFilter, "Detail GL : " & point.Argument.ToString())
  '    a.MenuId = Me.MenuId
  '    a.session = Me.session
  '    a.NamaDatabase = Me.NamaDatabase
  '    a.TampilkanData()
  '    a.ShowMDI()
  '  End If
  'End Sub
End Class