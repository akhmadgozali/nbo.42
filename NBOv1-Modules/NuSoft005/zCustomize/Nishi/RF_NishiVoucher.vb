Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_NishiVoucher
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
      Case Persistent.SumberDataJenis.RI
        Me.Text = "Filter Laporan - Biaya JO"
      Case Persistent.SumberDataJenis.VP
        Me.Text = "Filter Laporan - Pembayaran Pembelian"
    End Select
  End Sub
  Overrides Sub InitializeData()
    Select Case _jenis
      Case Persistent.SumberDataJenis.RI
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.NishiPenerimaanInvoice)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.RI, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.NishiPenerimaanInvoice)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.RI, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.VP
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.NishiPembayaranHutang)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.NishiPembayaranHutang)(_sesi)
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
      Case Persistent.SumberDataJenis.RI
        _dataSource = New XPCollection(Of Persistent.NishiPenerimaanInvoice)(_sesi, CreateCriteriaMain)
      Case Persistent.SumberDataJenis.VP
        _dataSource = New XPCollection(Of Persistent.NishiPembayaranHutang)(_sesi, CreateCriteriaMain)
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
      result.Add(New BinaryOperator("Main.Vendor", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaMain() As CriteriaOperator
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
      result.Add(New BinaryOperator("Vendor", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Sub txtTgl1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl1.EditValueChanging
    txtTgl2.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtTgl2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl2.EditValueChanging
    txtTgl1.Properties.MaxValue = CDate(e.NewValue)
  End Sub
End Class