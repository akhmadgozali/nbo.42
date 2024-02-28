Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_SanyuVoucher
  Private _jenis As Persistent.SumberDataJenis
  Private _ReportName As MainClass.reportName

  Sub New(jenisTransaksi As SumberData, xReportName As MainClass.reportName)
    Me.New(Persistent.SumberDataCollection.GetEnum(jenisTransaksi), xReportName)
  End Sub
  Sub New(jenisTransaksi As Persistent.SumberDataJenis, xReportName As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _jenis = jenisTransaksi
    _ReportName = xReportName
    Select Case _jenis
      Case Persistent.SumberDataJenis.SQ
        Me.Text = "Filter Laporan - Penawaran [SQ]"
      Case Persistent.SumberDataJenis.SO
        Me.Text = "Filter Laporan - Order Penjualan [SO]"
        'Case Persistent.SumberDataJenis.DP
        '	Me.Text = "Filter Laporan - Uang Muka Penjualan"
      Case Persistent.SumberDataJenis.SJ
        Me.Text = "Filter Laporan"
      Case Persistent.SumberDataJenis.IV
        Me.Text = "Filter Laporan - Invoice Penjualan"
        'Case Persistent.SumberDataJenis.CP
        '	Me.Text = "Filter Laporan - Penerimaan Pembayaran Penjualan"
        'Case Persistent.SumberDataJenis.RN
        '	Me.Text = "Filter Laporan - Penerimaan Retur Penjualan"
        'Case Persistent.SumberDataJenis.QS
        '	Me.Text = "Filter Laporan - POS"
    End Select
  End Sub
  Overrides Sub InitializeData()
    Select Case _jenis
      Case Persistent.SumberDataJenis.SO ', Persistent.SumberDataJenis.RN, Persistent.SumberDataJenis.QS
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPenjualan)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPenjualan)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.SJ ', Persistent.SumberDataJenis.RN, Persistent.SumberDataJenis.QS
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PengirimanBarang)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PengirimanBarang)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.IV
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.Sanyu_InvoicePenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.Sanyu_InvoicePenjualan)(_sesi)
    End Select
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

    Select Case _jenis
      Case Persistent.SumberDataJenis.SO
        _dataSource = New XPCollection(Of Persistent.SanYu_OrderPenjualanDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.SJ
        If _ReportName = MainClass.reportName.zSanyuVoucherPackingList Then
          _dataSource = New XPCollection(Of Persistent.SanYu_PengirimanBarangDetail)(_sesi, CreateCriteria)
        Else
          _dataSource = New XPCollection(Of Persistent.SanYu_PengirimanBarangDetailPackingList)(_sesi, CreateCriteriaPLDetail)
        End If
      Case Persistent.SumberDataJenis.IV
        _dataSource = New XPCollection(Of Persistent.Sanyu_InvoicePenjualanDetail)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.EditValue = Nothing Then
      If txtNoBukti2.EditValue = Nothing Then
        result.Add(New BinaryOperator("Main.Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Main.Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Main.Pelanggan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaPLDetail() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("MainDetail.Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.EditValue = Nothing Then
      If txtNoBukti2.EditValue = Nothing Then
        result.Add(New BinaryOperator("MainDetail.Main.Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("MainDetail.Main.Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("MainDetail.Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("MainDetail.Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("MainDetail.Main.Pelanggan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("MainDetail.Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function

End Class