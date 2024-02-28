Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohStockTacking
	'Private setting As NuSoft001.Logic.FinaSetting

	Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
		session = Data.DbClient.GetXPOSession(NamaDatabase)
		'setting = New NuSoft001.Logic.FinaSetting(session)
		'colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQty.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyCutting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyCutting.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyOP1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyOP1.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyOP2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyOP2.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyOP3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyOP3.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyOP4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyOP4.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyOP5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyOP5.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyFG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyFG.DisplayFormat.FormatString = setting.NumericFormatString

		txtFTanggalAwal.DateTime = New Date(Now.Year, 1, 1)
    txtFTanggalAkhir.DateTime = New Date(Now.Year, Now.Month, Now.Day)
    txtTanggal.DateTime = New Date(Now.Year, Now.Month, Now.Day)
  End Sub
	Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
		Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
			splashManager.ShowWaitForm()
			splashManager.SetWaitFormCaption("Silahkan Tunggu")
			splashManager.SetWaitFormDescription("Proses pengecekan data ...")

			'Dim xdtDempyou = New XPCollection(Of FusohVwStockTacking)(session, getCriteria).ToList
			'Dim xdtCutting = New XPCollection(Of Fusoh_Produksi)(session, getCriteriaCutting).ToList
			'Dim item As FusohVwStockTacking

			''carikan qty cutting
			'Dim b = From z In xdtCutting Group z By z.OrderProduksi Into Group Select OrderProduksi, pQtyCutting = Group.Sum(Function(x) x.QtyCutting)
			'For Each x In b
			'	item = xdtDempyou.Single(Function(m) m.Id = x.OrderProduksi.Id)
			'	item.QtyCutting = x.pQtyCutting
			'Next

			'Dim xdtDailyProses As New XPCollection(Of Fusoh_DailyProcess)(session, getCriteriaDailyProses)
			'Dim c = From z In xdtDailyProses Group z By z.CuttingWIP.OrderProduksi Into Group Select OrderProduksi, pQtyOP1 = Group.Sum(Function(x) x.QtyOP1), pQtyOP2 = Group.Sum(Function(x) x.QtyOP2), pQtyOP3 = Group.Sum(Function(x) x.QtyOP3), pQtyOP4 = Group.Sum(Function(x) x.QtyOP4), pQtyOP5 = Group.Sum(Function(x) x.QtyOP5), pQtyFG = Group.Sum(Function(x) x.QtyFG)
			'For Each x In c
			'	item = xdtDempyou.Single(Function(m) m.Id = x.OrderProduksi.Id)
			'	item.QtyOP1 = x.pQtyOP1
			'	item.QtyOP2 = x.pQtyOP2
			'	item.QtyOP3 = x.pQtyOP3
			'	item.QtyOP4 = x.pQtyOP4
			'	item.QtyOP5 = x.pQtyOP5
			'	item.QtyFG = x.pQtyFG
			'Next

			'xGrid.DataSource = xdtDempyou

			Try
				Dim result As New List(Of FusohStokTakingNonPersistent)
				Dim dempyouList = New XPCollection(Of Fusoh_OrderProduksi)(session, getCriteria).ToList
				Dim wipList = New XPCollection(Of Fusoh_StokMain)(session, getCriteriaWIP).ToList
				Dim produksiList = New XPQuery(Of Fusoh_StokMain)(session).Where(Function(w) w.Sumber.Id = SumberDataJenis.AM).ToList
				Dim sjDetailList = New XPQuery(Of Fusoh_StokDetail)(session).Where(Function(w) w.Main.Sumber.Id = SumberDataJenis.FD).ToList
				Dim dailyProcessList As New XPCollection(Of Fusoh_DailyProcess)(session, getCriteriaDailyProses)

				For Each dempyou In dempyouList
					Dim newItem = New FusohStokTakingNonPersistent
					newItem.Dempyou = dempyou
					Dim wip = wipList.Where(Function(w) w.OrderProduksi Is dempyou).ToList
					newItem.QtyWIP = 0
					newItem.QtyDelivery = 0
					If Not wip Is Nothing AndAlso wip.Count > 0 Then
						newItem.TanggalWIP = wip.Max(Function(s) s.Tanggal)
						newItem.QtyWIP = wip.Sum(Function(s) s.TotalQtyIn)

						Dim x = produksiList.Where(Function(w) wip.Contains(w.CuttingWIP)).SelectMany(Function(s) s.Detail).Where(Function(w) w.QtyIn > 0).ToList
						Dim y = sjDetailList.Where(Function(w) x.Contains(w.ProduksiDetail)).ToList
						newItem.QtyDelivery = y.Sum(Function(s) s.QtyOut)
					End If

					Dim dailyProcess = dailyProcessList.Where(Function(w) w.CuttingWIP.OrderProduksi Is dempyou).ToList
					newItem.QtyFinishGood = dailyProcess.Sum(Function(s) s.QtyFinishGood) - newItem.QtyDelivery
					Select Case dempyou.SODetail.Barang.MaterialProses.DefaultFG
						Case 0
							newItem.QtyOP5 = Nothing
							newItem.QtyOP4 = Nothing
							newItem.QtyOP3 = Nothing
							newItem.QtyOP2 = Nothing
							newItem.QtyOP1 = Nothing
							newItem.QtyCutting = newItem.QtyWIP - newItem.QtyDelivery - newItem.QtyFinishGood
						Case 1
							newItem.QtyOP5 = Nothing
							newItem.QtyOP4 = Nothing
							newItem.QtyOP3 = Nothing
							newItem.QtyOP2 = Nothing
							newItem.QtyOP1 = dailyProcess.Sum(Function(s) s.QtyOP1) - newItem.QtyDelivery - newItem.QtyFinishGood
							newItem.QtyCutting = newItem.QtyWIP - newItem.QtyDelivery - newItem.QtyFinishGood - If(newItem.QtyOP3, 0) - If(newItem.QtyOP2, 0) - If(newItem.QtyOP1, 0)
						Case 2
							newItem.QtyOP5 = Nothing
							newItem.QtyOP4 = Nothing
							newItem.QtyOP3 = Nothing
							newItem.QtyOP2 = dailyProcess.Sum(Function(s) s.QtyOP2) - newItem.QtyDelivery - newItem.QtyFinishGood
							newItem.QtyOP1 = dailyProcess.Sum(Function(s) s.QtyOP1) - newItem.QtyDelivery - newItem.QtyFinishGood - If(newItem.QtyOP2, 0)
							newItem.QtyCutting = newItem.QtyWIP - newItem.QtyDelivery - newItem.QtyFinishGood - If(newItem.QtyOP2, 0) - If(newItem.QtyOP1, 0)
						Case 3
							newItem.QtyOP5 = Nothing
							newItem.QtyOP4 = Nothing
							newItem.QtyOP3 = dailyProcess.Sum(Function(s) s.QtyOP3) - newItem.QtyDelivery - newItem.QtyFinishGood
							newItem.QtyOP2 = dailyProcess.Sum(Function(s) s.QtyOP2) - newItem.QtyDelivery - newItem.QtyFinishGood - If(newItem.QtyOP3, 0)
							newItem.QtyOP1 = dailyProcess.Sum(Function(s) s.QtyOP1) - newItem.QtyDelivery - newItem.QtyFinishGood - If(newItem.QtyOP3, 0) - If(newItem.QtyOP2, 0)
							newItem.QtyCutting = newItem.QtyWIP - newItem.QtyDelivery - newItem.QtyFinishGood - If(newItem.QtyOP3, 0) - If(newItem.QtyOP2, 0) - If(newItem.QtyOP1, 0)
						Case 4, 5
							newItem.QtyOP5 = Nothing
							newItem.QtyOP4 = Nothing
							newItem.QtyOP3 = Nothing
							newItem.QtyOP2 = Nothing
							newItem.QtyOP1 = Nothing
							newItem.QtyCutting = Nothing
					End Select

					result.Add(newItem)
				Next

				xGrid.DataSource = result
			Catch ex As Exception
				Throw New Exception(ex.Message, ex.InnerException)
			Finally
				If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
			End Try
		End Using

		'MsgBox("Proses selesai")
		'End Using
	End Sub

	Private Function getCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    If Not txtFTanggalAwal.EditValue Is Nothing Then
      If txtFTanggalAkhir.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Tanggal", txtFTanggalAwal.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Tanggal", txtFTanggalAwal.DateTime, txtFTanggalAkhir.DateTime))
      End If
    End If
    Return GroupOperator.And(result)
  End Function
	Private Function getCriteriaWIP() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		result.Add(New BinaryOperator("Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
		result.Add(New BinaryOperator("Sumber.Id", SumberDataJenis.CW, BinaryOperatorType.Equal))
		Return GroupOperator.And(result)
	End Function
	Private Function getCriteriaDelivery() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		result.Add(New BinaryOperator("Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
		result.Add(New BinaryOperator("Sumber.Id", SumberDataJenis.SJ, BinaryOperatorType.Equal))
		Return GroupOperator.And(result)
	End Function

	Private Function getCriteriaCutting() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		If Not txtFTanggalAwal.EditValue Is Nothing Then
			If txtFTanggalAkhir.EditValue Is Nothing Then
				result.Add(New BinaryOperator("OrderProduksi.Tanggal", txtFTanggalAwal.DateTime, BinaryOperatorType.Equal))
			Else
				result.Add(New BetweenOperator("OrderProduksi.Tanggal", txtFTanggalAwal.DateTime, txtFTanggalAkhir.DateTime))
			End If
		End If
		result.Add(New BinaryOperator("Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
		Return GroupOperator.And(result)
	End Function
	Private Function getCriteriaDailyProses() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    If Not txtFTanggalAwal.EditValue Is Nothing Then
      If txtFTanggalAkhir.EditValue Is Nothing Then
        result.Add(New BinaryOperator("CuttingWIP.OrderProduksi.Tanggal", txtFTanggalAwal.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("CuttingWIP.OrderProduksi.Tanggal", txtFTanggalAwal.DateTime, txtFTanggalAkhir.DateTime))
      End If
    End If
    result.Add(New BinaryOperator("Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
    Return GroupOperator.And(result)
  End Function

  Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
		Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Stock Tacking " & txtTanggal.DateTime.ToString("dd-mmm-yy"))
	End Sub
End Class