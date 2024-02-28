Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohProductionPlan
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
	End Sub
	Overrides Sub FirstLoad()
		session = Data.DbClient.GetXPOSession(NamaDatabase)

		txtFTanggalAwal.DateTime = New Date(Now.Year, 1, 1)
		txtFTanggalAkhir.DateTime = New Date(Now.Year, Now.Month, Now.Day)

		colNoPDO.Caption = "Nomor" & vbCrLf & "PDO"
		colNomorPO.Caption = "Nomor" & vbCrLf & "PO"
		colQty.Caption = "Qty" & vbCrLf & "Process"
		colQtyCutting.Caption = "Qty" & vbCrLf & "Cutting"
		colQtyKampuh.Caption = "Qty" & vbCrLf & "Kampuh"
		colQtyDrill.Caption = "Qty" & vbCrLf & "Drill"
		colQtyFinishGoods.Caption = "Qty" & vbCrLf & "FG"
		colQtyDelivery.Caption = "Qty" & vbCrLf & "Delivery"
    colQtyAdjust.Caption = "Qty" & vbCrLf & "Adjust"
  End Sub
  Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    RefreshData()
  End Sub
  Private Sub RefreshData()
    If txtFTanggalAwal.EditValue Is Nothing Then
      XtraMessageBox.Show("Masukkan tanggal awal filter data", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtFTanggalAwal.Focus()
      Return
    End If
    If txtFTanggalAkhir.EditValue Is Nothing Then
      XtraMessageBox.Show("Masukkan tanggal akhir filter data", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtFTanggalAkhir.Focus()
      Return
    End If

    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Loading data ...")

      Try
        session.DropIdentityMap()

        Dim result As New List(Of FusohProductionPlanNonPersistent)
        Dim dempyouList = New XPQuery(Of Fusoh_OrderProduksi)(session).Where(Function(w) Not String.IsNullOrEmpty(w.NomorPDO) AndAlso w.Tanggal.Date >= txtFTanggalAwal.DateTime AndAlso w.Tanggal.Date <= txtFTanggalAkhir.DateTime).ToList
        Dim wipList = New XPQuery(Of Fusoh_StokMain)(session).Where(Function(w) dempyouList.Contains(w.OrderProduksi) AndAlso w.Sumber.Id = SumberDataJenis.CW).ToList
        Dim produksiList = New XPQuery(Of Fusoh_StokMain)(session).Where(Function(w) w.Sumber.Id = SumberDataJenis.AM).ToList
        Dim sjDetailList = New XPQuery(Of Fusoh_StokDetail)(session).Where(Function(w) w.Main.Sumber.Id = SumberDataJenis.FD).ToList
        Dim dailyProcessList = New XPQuery(Of Fusoh_DailyProcess)(session).Where(Function(w) dempyouList.Contains(w.CuttingWIP.OrderProduksi)).ToList
        Dim adjustList = New XPQuery(Of Fusoh_StokDetail)(session).Where(Function(w) w.Main.Sumber.Id = SumberDataJenis.PS).ToList

        For Each dempyou In dempyouList
          Dim wip = wipList.Where(Function(w) w.OrderProduksi Is dempyou).ToList
          Dim dailyProcess = dailyProcessList.Where(Function(w) w.CuttingWIP.OrderProduksi Is dempyou).ToList

          Dim newItem = New FusohProductionPlanNonPersistent
          newItem.Dempyou = dempyou
          newItem.MaterialSize = dempyou.SODetail.NamaBarang & " " & dempyou.SODetail.Barang.OutDiameter.ToString("n0") & "x" & dempyou.SODetail.Barang.Thickness.ToString("n1") & "x" & dempyou.Cutting.ToString("n1") 'String.Join(vbCrLf, dempyou.BahanBaku.Select(Function(s) s.Barang.FGSize).ToList)
          newItem.Machine = dailyProcess.Max(Function(m) m.Mesin)
          newItem.QtyCutting = wip.Sum(Function(s) s.TotalQtyIn)
          newItem.QtyKampuh = dailyProcess.Sum(Function(s) s.QtyOP2)
          newItem.QtyDrill = Nothing
          If dempyou.SODetail.Barang.MaterialProses.DefaultFG = 3 Then newItem.QtyDrill = dailyProcess.Sum(Function(s) s.QtyOP3)
          newItem.QtyFinishGoods = dailyProcess.Sum(Function(s) s.QtyFinishGood)

          Dim x = produksiList.Where(Function(w) wip.Contains(w.CuttingWIP)).SelectMany(Function(s) s.Detail).Where(Function(w) w.QtyIn > 0).ToList
          Dim y = sjDetailList.Where(Function(w) x.Contains(w.ProduksiDetail)).ToList
          newItem.QtyDelivery = y.Sum(Function(s) s.QtyOut)
          newItem.QtyAdjust = adjustList.Where(Function(w) x.Contains(w.ProduksiDetail)).Sum(Function(s) s.QtyOut)
          newItem.KetAdjust = adjustList.Where(Function(w) x.Contains(w.ProduksiDetail)).Max(Function(s) s.Main.Catatan)

          result.Add(newItem)
        Next

        'result(0).Dempyou.MaterialFlow

        xGrid.DataSource = result
        xGridView.ExpandAllGroups()
        'MsgBox("ISI data grid selesai")
      Catch ex As Exception
        Throw New Exception(ex.Message, ex.InnerException)
      Finally
        If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
      End Try
    End Using
  End Sub
  Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
    Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Production Plan")
  End Sub
  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    RefreshData()
  End Sub
End Class