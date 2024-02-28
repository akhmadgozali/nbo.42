Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Public Class UI_SaldoLR
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
		Dim finasetting As New Logic.FinaSetting(session)
		colSaldoAkhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colSaldoAkhir.DisplayFormat.FormatString = finasetting.NumericFormatString
		Dim xTglAwal = New Date(Now.Year, Now.Month, 1)
		Dim xTglAkhir = New Date(Now.Year, Now.Month, 1)
		xTglAkhir = xTglAkhir.AddMonths(1).AddDays(-(xTglAkhir.AddMonths(1).Day))
		InitData(xTglAwal, xTglAkhir)
		Me.Text = "Saldo LabaRugi"
	End Sub
	Friend Sub InitData(xTglAwal As DateTime, xTglAkhir As DateTime)

		Dim xpCoa As New XPCollection(Of Persistent.Coa)(session, CriteriaOperator.Parse("not Induk is null"))
		Dim a = From x In xpCoa Select x.Induk Distinct
		Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(session, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))

		Dim pI As Integer
		Dim pSaldoCOA As DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar) = Nothing
		pSaldoCOA = New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(session, New BetweenOperator("Tanggal", xTglAwal, xTglAkhir))

		For pI = 0 To details.Count - 1
			details(pI).SaldoAkhir = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Debit - n.Kredit)
			If details(pI).Tipe.Dc = CoaEnum.eDc.Kredit Then details(pI).SaldoAkhir = details(pI).SaldoAkhir * -1
		Next

		xGrid.DataSource = details.Where(Function(w) w.SaldoAkhir <> 0)

		Dim c = From z In details Group z By z.Kode, z.Nama, z.Tipe Into Group Select TipeCoa = Tipe, NamaCOA = Nama, Saldo = Group.Sum(Function(x) x.SaldoAkhir) Where Saldo > 0 AndAlso TipeCoa.Dc = CoaEnum.eDc.Debit
		'Dim series2 As DevExpress.XtraCharts.Series = nChart.Series("Series1")
		'series2.DataSource = c
		'series2.ArgumentDataMember = "NamaCOA"
		'series2.ValueDataMembers.AddRange({"Saldo"})
		'series2.TopNOptions.Enabled = True
		'series2.TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
		'nChart.Titles(0).Text = "Saldo LR " & xTglAwal.ToString("dd-MM-YY") & "s/d" & xTglAkhir.ToString("dd-MM-YY")

		nChart.Series(0).Points.Clear()
		For pI = 0 To c.Count - 1
			nChart.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint(c(pI).NamaCOA, c(pI).Saldo))
		Next
		nChart.Series(0).Points.Add(New DevExpress.XtraCharts.SeriesPoint("Laba", 50000000))
	End Sub
	Private Sub btnFilter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilter.ItemClick
		Dim xform As New UI_DaftarGLFilter
		xform.MenuId = MenuId
		xform.NamaDatabase = NamaDatabase
		xform.session = session
		xform.Owner = Me
		xform.ShowDialog()
	End Sub
End Class