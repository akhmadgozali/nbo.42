Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_RekapData
  Private _ReportName As MainClass.reportName
  Sub New(xReportName As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _ReportName = xReportName
    Select Case _ReportName
      Case MainClass.reportName.RekapPurchaseOrderStock : Me.Text = "Rekap Purchase Order"
    End Select
  End Sub
  Overrides Sub InitializeData()
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtTgl1.DateTime = xAkhirBulan
    txtTgl2.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))
    Select Case _ReportName
      Case MainClass.reportName.RekapPurchaseOrderStock
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.OrderPembelian)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.OrderPembelian)(_sesi)
    End Select
    txtKodeBarang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(_sesi)
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New NuSoft001.Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", setting.Alamat1, GetType(String))
    AddParameter("Alamat2", setting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", setting.BidangUsaha, GetType(String))
    AddParameter("NoFax", setting.NoFax, GetType(String))
    AddParameter("NoTelp", setting.NoTelp, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))


    Select Case _ReportName
      Case MainClass.reportName.RekapPurchaseOrderStock
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.ViewPurchaseOrderStock)(_sesi, CreateCriteriaPO)
    End Select
  End Sub
  Private Sub LaporanRekapxx()
    'Dim details As XPCollection(Of Persistent.zWoojinViewPPN)
    'Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
    '  splashManager.ShowWaitForm()
    '  splashManager.SetWaitFormCaption("Silahkan Tunggu")
    '  splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")

    '  details = New XPCollection(Of Persistent.zWoojinViewPPN)(_sesi, CreateCriteriaPPN)
    '  For pi = 0 To details.Count - 1
    '    Dim xInvoice As Persistent.zWoojinInvoicePenjualan = _sesi.GetObjectByKey(Of Persistent.zWoojinInvoicePenjualan)(details(pi).id)
    '    details(pi).DPP = xInvoice.SubTotal
    '    details(pi).NilaiPajak = xInvoice.PPN
    '  Next

    '  Dim xPurchase As XPCollection(Of NuSoft005.Persistent.ViewInvoicePPN)
    '  xPurchase = NuSoft005.Logic.Purchase.GetInvoicePPN(_sesi, txtTgl1.DateTime, txtTgl2.DateTime)
    '  Dim xData As Persistent.zWoojinViewPPN
    '  For pi = 0 To xPurchase.Count - 1
    '    xData = New Persistent.zWoojinViewPPN(_sesi)
    '    xData.id = xPurchase(pi).Id
    '    xData.Sumber = xPurchase(pi).Sumber
    '    xData.Tanggal = xPurchase(pi).Tanggal
    '    xData.Kontak = xPurchase(pi).Kontak
    '    xData.NoBukti = xPurchase(pi).NoBukti
    '    xData.Uraian = xPurchase(pi).Uraian
    '    xData.DPP = xPurchase(pi).DPP
    '    xData.NilaiPajak = xPurchase(pi).NilaiPajak
    '    xData.NoFakturPajak = xPurchase(pi).NoFakturPajak
    '    details.Add(xData)
    '  Next
    '  splashManager.CloseWaitForm()
    'End Using
    '_dataSource = details

  End Sub
  Private Function CreateCriteriaPO() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("OrderDetail.Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("OrderDetail.Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If Not txtNoBukti1.EditValue = Nothing Then
      If txtNoBukti2.EditValue = Nothing Then
        result.Add(New BinaryOperator("OrderDetail.Main.Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("OrderDetail.Main.Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtKodeBarang.EditValue Is Nothing Then
      result.Add(New BinaryOperator("OrderDetail.Barang.Id", CType(txtKodeBarang.EditValue, NuSoft004.Persistent.Barang).Id, BinaryOperatorType.Equal))
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("OrderDetail.Main.Vendor", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("OrderDetail.Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Sub txtKodeBarang_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtKodeBarang.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtKodeBarang.EditValue = Nothing
    End If
  End Sub
End Class