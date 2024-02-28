Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class zRexaRF_DataDataTransaksi
  Private _jenis As Persistent.SumberDataJenis
  Sub New(jenisTransaksi As SumberData)
    Me.New(Persistent.SumberDataCollection.GetEnum(jenisTransaksi))
  End Sub
  Sub New(jenisTransaksi As Persistent.SumberDataJenis)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _jenis = jenisTransaksi

    Select Case _jenis
      Case Persistent.SumberDataJenis.SO
        Me.Text = "Filter Laporan - Order Penjualan"
      Case Persistent.SumberDataJenis.IV
        Me.Text = "Filter Laporan - Invoice Penjualan"
      Case Persistent.SumberDataJenis.CP
        Me.Text = "Filter Laporan - Penerimaan Pembayaran Penjualan"
      Case Persistent.SumberDataJenis.TS
        Me.Text = "Filter Laporan - Mutasi Barang"
    End Select
  End Sub
  Overrides Sub InitializeData()
    Select Case _jenis
      Case Persistent.SumberDataJenis.SO
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.zRexaOrderPenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.zRexaOrderPenjualan)(_sesi)
      Case Persistent.SumberDataJenis.IV
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.zRexaInvoicePenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.zRexaInvoicePenjualan)(_sesi)
      Case Persistent.SumberDataJenis.CP
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.zRexaPembayaranPiutang)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.zRexaPembayaranPiutang)(_sesi)
      Case Persistent.SumberDataJenis.TS
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.zRexaStockMain)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.zRexaStockMain)(_sesi)
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
    AddParameter("LembarFP", CType(txtPajak.EditValue, Persistent.eLembarFP), GetType(Integer))
    Select Case _jenis
      Case Persistent.SumberDataJenis.SO
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zRexaOrderPenjualanDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.IV
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zRexaInvoicePenjualanDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.CP
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zRexaPembayaranPiutangDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.TS
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zRexaStockDetail)(_sesi, CreateCriteria)
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
    If _jenis = Persistent.SumberDataJenis.TS Then
      result.Add(New BinaryOperator("QtyOut", 0, BinaryOperatorType.Greater))
    End If

    Return GroupOperator.And(result)
  End Function
End Class