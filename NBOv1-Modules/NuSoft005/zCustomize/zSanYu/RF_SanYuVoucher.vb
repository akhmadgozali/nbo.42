Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_SanYuVoucher
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
      Case Persistent.SumberDataJenis.PB
        Me.Text = "Filter Laporan - Permintaan Pembelian"
      Case Persistent.SumberDataJenis.RQ
        Me.Text = "Filter Laporan - Permintaan Penawaran Harga"
      Case Persistent.SumberDataJenis.PO
        Me.Text = "Filter Laporan - Order Pembelian"
      Case Persistent.SumberDataJenis.AP
        Me.Text = "Filter Laporan - Uang Muka Pembelian"
      Case Persistent.SumberDataJenis.GR
        Me.Text = "Filter Laporan - Penerimaan Barang"
      Case Persistent.SumberDataJenis.RI
        Me.Text = "Filter Laporan - Invoice Pembelian"
      Case Persistent.SumberDataJenis.VP
        Me.Text = "Filter Laporan - Pembayaran Pembelian"
      Case Persistent.SumberDataJenis.DN
        Me.Text = "Filter Laporan - Pengiriman Retur Pembelian"
      Case Persistent.SumberDataJenis.PC
        Me.Text = "Filter Laporan - Pembelian Tunai"

    End Select
  End Sub
  Overrides Sub InitializeData()
    Select Case _jenis
      Case Persistent.SumberDataJenis.PO
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPembelian)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.SanYu_OrderPembelian)(_sesi)
      Case Persistent.SumberDataJenis.GR
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanBarang)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanBarang)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.RI
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanInvoice)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.RI, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PenerimaanInvoice)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.RI, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.VP
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PembayaranHutang)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.VP, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.SanYu_PembayaranHutang)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.VP, BinaryOperatorType.Equal))
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
      Case Persistent.SumberDataJenis.PO
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.SanYu_OrderPembelianDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.GR ', Persistent.SumberDataJenis.DN
        _dataSource = New XPCollection(Of Persistent.SanYu_PenerimaanBarangDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.RI ', Persistent.SumberDataJenis.DN
        _dataSource = New XPCollection(Of Persistent.SanYu_PenerimaanInvoiceDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.VP ', Persistent.SumberDataJenis.DN
        _dataSource = New XPCollection(Of Persistent.SanYu_PembayaranHutangDetail)(_sesi, CreateCriteria)
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
  Private Sub txtTgl1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl1.EditValueChanging
    txtTgl2.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtTgl2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl2.EditValueChanging
    txtTgl1.Properties.MaxValue = CDate(e.NewValue)
  End Sub
End Class