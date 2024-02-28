Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_BuktiHarian
  Private _jenis As Persistent.SumberDataJenis
  Private _reportname As MainClass.reportName
  Private _all As Boolean
  Private xxx As Persistent.AktivaKelompok

  Sub New(jenisTransaksi As SumberData, xReportName As MainClass.reportName)
    Me.New(Persistent.SumberDataCollection.GetEnum(jenisTransaksi), xReportName)
  End Sub
  Sub New(jenisTransaksi As Persistent.SumberDataJenis, xReportName As MainClass.reportName, Optional ByVal TampilkanSemua As Boolean = False)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _jenis = jenisTransaksi
    _all = TampilkanSemua
    _reportname = xReportName
    If _all = True Then
      Me.Text = "Filter Laporan - Jurnal Voucher"
      LabelControl5.Visible = False
      txtAkun.Visible = False
      txtKeterangan.Location = txtKontak.Location
      LabelControl6.Location = LabelControl3.Location
      txtKontak.Location = txtAkun.Location
      LabelControl3.Location = LabelControl5.Location
      Me.Height = Me.Height + (txtAkun.Location.Y - txtKeterangan.Location.Y)
    Else
      Select Case _jenis
        Case Persistent.SumberDataJenis.KK
          Me.Text = "Filter Laporan - Bukti Kas Keluar"
        Case Persistent.SumberDataJenis.KM
          Me.Text = "Filter Laporan - Bukti Kas Masuk"
        Case Persistent.SumberDataJenis.BK
          Me.Text = "Filter Laporan - Bukti Bank Keluar"
        Case Persistent.SumberDataJenis.BM
          Me.Text = "Filter Laporan - Bukti Bank Masuk"
        Case Persistent.SumberDataJenis.JU, Persistent.SumberDataJenis.JA, Persistent.SumberDataJenis.PD
          Select Case _jenis
            Case Persistent.SumberDataJenis.JU : Me.Text = "Filter Laporan - Bukti Jurnal Umum"
            Case Persistent.SumberDataJenis.JA : Me.Text = "Filter Laporan - Bukti Jurnal Adjustment"
            Case Persistent.SumberDataJenis.PD : Me.Text = "Filter Laporan - Bukti Pengajuan Dana"
          End Select
          LabelControl5.Visible = False
          txtAkun.Visible = False
          txtKeterangan.Location = txtKontak.Location
          LabelControl6.Location = LabelControl3.Location
          txtKontak.Location = txtAkun.Location
          LabelControl3.Location = LabelControl5.Location
          Me.Height = Me.Height + (txtAkun.Location.Y - txtKeterangan.Location.Y)
        Case Persistent.SumberDataJenis.PP
          Me.Text = "Filter Laporan - Bukti PrePayment"
      End Select
    End If
  End Sub
  Overrides Sub InitializeData()
    If _all = True Then
      txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi)
      txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi)
    Else
      Select Case _jenis
        Case Persistent.SumberDataJenis.PP
          txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.PrePaymentMain)(_sesi)
          txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.PrePaymentMain)(_sesi)
        Case Else
          txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi, New BinaryOperator("Sumber", _jenis, BinaryOperatorType.Equal))
          txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi, New BinaryOperator("Sumber", _jenis, BinaryOperatorType.Equal))
      End Select
    End If
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
    AddParameter("Periode1", txtTgl1.DateTime, GetType(Date))
    AddParameter("Periode2", txtTgl2.DateTime, GetType(Date))
    Select Case _jenis
      Case Persistent.SumberDataJenis.PD
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PengajuanDanaDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.PP
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PrePaymentDetail)(_sesi, CreateCriteria)
      Case Else
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.GlMainDetail)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If _all = False Then
      result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    End If

    Select Case _jenis
      Case Persistent.SumberDataJenis.PD
      Case Persistent.SumberDataJenis.JU, Persistent.SumberDataJenis.JA
      Case Persistent.SumberDataJenis.PP
      Case Persistent.SumberDataJenis.KK, Persistent.SumberDataJenis.BK, Persistent.SumberDataJenis.BM, Persistent.SumberDataJenis.BK
        result.Add(New BinaryOperator("Urutan", 0, BinaryOperatorType.NotEqual))
    End Select

    If Not txtNoBukti1.EditValue Is Nothing Then
      If txtNoBukti2.EditValue Is Nothing Then
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

    If txtAkun.Text <> "" Then
      result.Add(New BinaryOperator("Main.Akun", String.Format(format, txtAkun.Text), BinaryOperatorType.Like))
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Main.KontakNama", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Main.Uraian", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    If _reportname = MainClass.reportName.APPRekap Or _reportname = MainClass.reportName.APPRekapTerbit Or _reportname = MainClass.reportName.APPRekapBayar Then
      result.Add(New BinaryOperator("fCoa.Kode", String.Format(format, ""), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
End Class