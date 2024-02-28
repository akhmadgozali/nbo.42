Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent
Friend Class RF_DataDataTransaksi
  Private _jenis As Persistent.SumberDataJenis, _ReportName As MainClass.reportName
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
        Me.Text = "Filter Laporan - Penawaran Penjualan"
      Case Persistent.SumberDataJenis.SO
        Me.Text = "Filter Laporan - Order Penjualan"
      Case Persistent.SumberDataJenis.DP
        Me.Text = "Filter Laporan - Uang Muka Penjualan"
      Case Persistent.SumberDataJenis.SJ
        Me.Text = "Filter Laporan - Pengiriman Barang"
      Case Persistent.SumberDataJenis.IV
        Me.Text = "Filter Laporan - Invoice Penjualan"
      Case Persistent.SumberDataJenis.CP
        Me.Text = "Filter Laporan - Penerimaan Pembayaran Penjualan"
      Case Persistent.SumberDataJenis.RN
        Me.Text = "Filter Laporan - Penerimaan Retur Penjualan"
      Case Persistent.SumberDataJenis.QS
        Me.Text = "Filter Laporan - POS"
    End Select
    If _ReportName = MainClass.reportName.zTravelSisaPiutang Then
      LabelControl4.Visible = False
      txtTgl2.Visible = False
      txtTgl1.DateTime = Now.Date
      txtTgl1.Properties.ReadOnly = True
    End If
  End Sub
  Overrides Sub InitializeData()
    Select Case _jenis
      Case Persistent.SumberDataJenis.SQ
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.Penawaran)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.Penawaran)(_sesi)
      Case Persistent.SumberDataJenis.SO
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.OrderPenjualan)(_sesi)
      Case Persistent.SumberDataJenis.DP
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.DPPenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.DPPenjualan)(_sesi)
      Case Persistent.SumberDataJenis.SJ, Persistent.SumberDataJenis.RN, Persistent.SumberDataJenis.QS
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.IV
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.InvoicePenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.InvoicePenjualan)(_sesi)
      Case Persistent.SumberDataJenis.CP
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.PembayaranPiutang)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.PembayaranPiutang)(_sesi)
        'Case Persistent.SumberDataJenis.RN
        '  txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.RN, BinaryOperatorType.Equal))
        '  txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.RN, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.QS
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.QS, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.PengirimanBarang)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.QS, BinaryOperatorType.Equal))
    End Select
    txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eLembarFP))
    txtPajak.EditValue = Persistent.eLembarFP.Lembar1
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
		AddParameter("TanggalHariIni", Now.Date.ToString("dd-MMM-yyyy"), GetType(String))
		AddParameter("LembarFP", CType(txtPajak.EditValue, Persistent.eLembarFP), GetType(Integer))
		Select Case _jenis
      Case Persistent.SumberDataJenis.SQ
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PenawaranDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.SO
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.OrderPenjualanDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.DP
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.DPPenjualan)(_sesi, CreateCriteriaDP)
      Case Persistent.SumberDataJenis.IV
        Select Case _ReportName
          'Case MainClass.reportName.TravelVoucherIV, MainClass.reportName.TravelVoucherFP
          '  _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.Travel_InvoicePenjualanDetail)(_sesi, CreateCriteria)
          'Case MainClass.reportName.zTravelRekapIV
          '  _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.Travel_InvoicePenjualan)(_sesi, CreateCriteria2)
          Case MainClass.reportName.zTravelSisaPiutang
            _dataSource = New DevExpress.Xpo.XPCollection(Of Travel_Invoice)(_sesi, CreateCriteriaTravel)
          Case Else
            _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.InvoicePenjualanDetail)(_sesi, CreateCriteria)
        End Select
      Case Persistent.SumberDataJenis.CP
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PembayaranPiutangDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.RN
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PenerimaanReturPenjualan)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.SJ, Persistent.SumberDataJenis.QS
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PengirimanBarangDetail)(_sesi, CreateCriteria)
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
      result.Add(New BinaryOperator("Main.Uraian", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaDP() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.EditValue = Nothing Then
      If txtNoBukti2.EditValue = Nothing Then
        result.Add(New BinaryOperator("Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Pelanggan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Uraian", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteria2() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.EditValue = Nothing Then
      If txtNoBukti2.EditValue = Nothing Then
        result.Add(New BinaryOperator("Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Pelanggan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Uraian", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaTravel() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.EditValue = Nothing Then
      If txtNoBukti2.EditValue = Nothing Then
        result.Add(New BinaryOperator("Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Pelanggan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Uraian", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
End Class