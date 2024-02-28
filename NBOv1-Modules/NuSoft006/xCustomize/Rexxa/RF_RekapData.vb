Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class zRexaRF_RekapData
  Private _ReportName As MainClass.reportName
  Sub New(xReportName As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _ReportName = xReportName
    Select Case _ReportName
      Case MainClass.reportName.zRexxaRekapAlatGudang2, MainClass.reportName.zRexxaRekapAlatGudang
        lytTanggal1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytTanggal2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytPeriode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lytCheckSaldoNol.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lytCustomer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Select
  End Sub
  Overrides Sub InitializeData()
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtPeriode.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))
    txtTgl1.DateTime = xAkhirBulan
    txtTgl2.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    txtGudang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(_sesi)
    txtCustomer.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(_sesi)
    txtKodeBarang.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(_sesi)

    txtCustomer.EditValue = Nothing
    txtGudang.EditValue = Nothing
    'Dim settingsales As New Logic.SalesSetting(_sesi)
    'txtGudang.EditValue = settingsales.GudangDefault
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
    AddParameter("PeriodeBulan", txtPeriode.DateTime.ToString("MMMM yyyy"), GetType(String))
    Select Case _ReportName
      Case MainClass.reportName.zRexxaRekapMutasiKeluar
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zRexaStockDetail)(_sesi, CreateCriteriaMutasi)
      Case MainClass.reportName.zRexxaRekapMutasiMasuk
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zRexaStockDetail)(_sesi, CreateCriteriaMutasi)
      Case MainClass.reportName.zRexxaRekapAlatGudang
        _dataSource = New XPCollection(Of Persistent.zRexaStockDetail)(_sesi, CreateCriteriaStockGudang)
      Case MainClass.reportName.zRexxaRekapAlatGudang2
        LaporanRekapGudang2()
        Return
    End Select
  End Sub
  Private Function CreateCriteriaMutasi() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.TS, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("QtyIn", 0, BinaryOperatorType.Greater))
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If _ReportName = MainClass.reportName.zRexxaRekapMutasiKeluar Then
      result.Add(New BinaryOperator("Main.Gudang", CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang), BinaryOperatorType.Equal))
    End If
    If _ReportName = MainClass.reportName.zRexxaRekapMutasiMasuk Then
      result.Add(New BinaryOperator("Main.Gudang2", CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang), BinaryOperatorType.Equal))
    End If
    If Not txtCustomer.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Main.OrderPenjualan.Pelanggan", CType(txtCustomer.EditValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
    End If
    If Not txtKodeBarang.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang", CType(txtKodeBarang.EditValue, NuSoft004.Persistent.Barang), BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub LaporanRekapGudang2()
    Dim details As New XPCollection(Of Persistent.SaldoStock)(_sesi)

    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")

      Dim xTglAwal As New Date(txtPeriode.DateTime.Year, txtPeriode.DateTime.Month, 1)

      Dim xSaldoSewa As New XPCollection(Of Persistent.zRexaStockDetail)(_sesi, New GroupOperator(New BinaryOperator("Main.Tanggal", txtPeriode.DateTime, BinaryOperatorType.LessOrEqual), New BinaryOperator("Gudang", CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang), BinaryOperatorType.NotEqual)))
      Dim xSaldoMutasi As New XPCollection(Of Persistent.zRexaStockDetail)(_sesi, New GroupOperator(New BetweenOperator("Main.Tanggal", xTglAwal, txtPeriode.DateTime), New BinaryOperator("Gudang", CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang), BinaryOperatorType.Equal)))
      Dim pI As Integer
      For pI = 0 To details.Count - 1
        details(pI).SaldoAwal = xSaldoSewa.Where(Function(x) x.Barang.Id = details(pI).Id).Sum(Function(z) z.QtyIn - z.QtyOut)
        details(pI).StockIn = xSaldoMutasi.Where(Function(x) x.Barang.Id = details(pI).Id).Sum(Function(z) z.QtyIn)
        details(pI).StockOut = xSaldoMutasi.Where(Function(x) x.Barang.Id = details(pI).Id).Sum(Function(z) z.QtyOut)
      Next

      splashManager.CloseWaitForm()
    End Using
    '_dataSource = details
    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(x) x.SaldoAkhir <> 0 And x.StockIn <> 0 And x.StockOut <> 0).Count > 0 Then
        _dataSource = details.Where(Function(x) x.SaldoAkhir <> 0 And x.StockIn <> 0 And x.StockOut <> 0)
      Else
        _dataSource = details
      End If
    End If
  End Sub
  Private Function CreateCriteriaStockGudang() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    ', New GroupOperator(New BinaryOperator("Main.Tanggal", txtPeriode.DateTime, BinaryOperatorType.LessOrEqual), New BinaryOperator("Gudang", CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang), BinaryOperatorType.NotEqual)))
    result.Add(New BinaryOperator("Main.Tanggal", txtPeriode.DateTime, BinaryOperatorType.LessOrEqual))
    If Not txtGudang.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Gudang", CType(txtGudang.EditValue, NuSoft004.Persistent.Gudang), BinaryOperatorType.Equal))
    End If
    If Not txtKodeBarang.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang", CType(txtKodeBarang.EditValue, NuSoft004.Persistent.Barang), BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
End Class