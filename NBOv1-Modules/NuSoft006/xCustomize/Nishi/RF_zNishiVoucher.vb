Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_zNishiVoucher
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
      Case Persistent.SumberDataJenis.JO
        Me.Text = "Filter Laporan - Job Order [JO]"
      Case Persistent.SumberDataJenis.DN
        Me.Text = "Filter Laporan - Debit Note"
      Case Persistent.SumberDataJenis.IV
        Me.Text = "Filter Laporan - Invoice Penjualan"
    End Select
  End Sub
  Overrides Sub InitializeData()
    Select Case _jenis
      Case Persistent.SumberDataJenis.JO
        Dim x = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(_sesi)
        txtNoBukti1.Properties.DataSource = x
        txtNoBukti2.Properties.DataSource = x
      Case Persistent.SumberDataJenis.DN ', Persistent.SumberDataJenis.RN, Persistent.SumberDataJenis.QS
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.NishiInvoice)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.NishiInvoice)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.IV
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.NishiInvoice)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.NishiInvoice)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
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
      Case Persistent.SumberDataJenis.JO
        '_dataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(_sesi, CreateCriteriaJO)
        Select Case _ReportName
          'Case MainClass.reportName.zNishiVoucherJOImpor : _dataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(_sesi, CreateCriteriaJO)
          'Case MainClass.reportName.zNishiVoucherJOEkspor : _dataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(_sesi, CreateCriteriaJO)
          Case MainClass.reportName.zNishiRekapJOImpor : _dataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(_sesi, CreateCriteriaJO)
          Case MainClass.reportName.zNishiRekapJOEkspor : _dataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(_sesi, CreateCriteriaJO)
            'Case MainClass.reportName.zNishiRekapJOImpor : _dataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelianDetail)(_sesi, CreateCriteria)
            'Case MainClass.reportName.zNishiRekapJOEkspor : _dataSource = New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelianDetail)(_sesi, CreateCriteria)
          Case MainClass.reportName.zNishiVoucherJOImpor : _dataSource = New XPCollection(Of Persistent.NishiVwJobOrder)(_sesi, CreateCriteriaJOV)
          Case MainClass.reportName.zNishiVoucherJOEkspor : _dataSource = New XPCollection(Of Persistent.NishiVwJobOrder)(_sesi, CreateCriteriaJOV)
        End Select
      Case Persistent.SumberDataJenis.DN
        _dataSource = New XPCollection(Of Persistent.NishiInvoiceDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.IV
        _dataSource = New XPCollection(Of Persistent.NishiInvoiceDetail)(_sesi, CreateCriteria)
      Case Else
        _dataSource = New XPCollection(Of Persistent.NishiInvoiceDetail)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If _ReportName = MainClass.reportName.zNishiRekapJOImpor Then
      result.Add(New BinaryOperator("Main.JenisJO", NuSoft004.Persistent.NishiJenisJO.Impor, BinaryOperatorType.Equal))
    End If
    If _ReportName = MainClass.reportName.zNishiRekapJOEkspor Then
      result.Add(New BinaryOperator("Main.JenisJO", NuSoft004.Persistent.NishiJenisJO.Ekspor, BinaryOperatorType.Equal))
    End If
    If _ReportName = MainClass.reportName.zNishiRekapIVStorage Then
      result.Add(New BinaryOperator("Main.JenisInvoice", NuSoft004.Persistent.NishiJenisInvoice.Gudang, BinaryOperatorType.Equal))
    End If
    If _ReportName = MainClass.reportName.zNishiRekapIVTruck Then
      result.Add(New BinaryOperator("Main.JenisInvoice", NuSoft004.Persistent.NishiJenisInvoice.Truck, BinaryOperatorType.Equal))
    End If


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
  Private Function CreateCriteriaJO() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If _ReportName = MainClass.reportName.zNishiRekapJOImpor Then
      result.Add(New BinaryOperator("JenisJO", NuSoft004.Persistent.NishiJenisJO.Impor, BinaryOperatorType.Equal))
    End If
    If _ReportName = MainClass.reportName.zNishiRekapJOEkspor Then
      result.Add(New BinaryOperator("JenisJO", NuSoft004.Persistent.NishiJenisJO.Ekspor, BinaryOperatorType.Equal))
    End If

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
      result.Add(New BinaryOperator("Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaJOV() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If _ReportName = MainClass.reportName.zNishiRekapJOImpor Then
      result.Add(New BinaryOperator("jo.JenisJO", NuSoft004.Persistent.NishiJenisJO.Impor, BinaryOperatorType.Equal))
    End If
    If _ReportName = MainClass.reportName.zNishiRekapJOEkspor Then
      result.Add(New BinaryOperator("jo.JenisJO", NuSoft004.Persistent.NishiJenisJO.Ekspor, BinaryOperatorType.Equal))
    End If

    result.Add(New BinaryOperator("jo.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.EditValue = Nothing Then
      If txtNoBukti2.EditValue = Nothing Then
        result.Add(New BinaryOperator("jo.Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("jo.Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("jo.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("jo.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("jo.Pelanggan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("jo.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
End Class