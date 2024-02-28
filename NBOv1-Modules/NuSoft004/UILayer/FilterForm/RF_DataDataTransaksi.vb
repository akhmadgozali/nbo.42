Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_DataDataTransaksi
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
        Me.Text = "Filter Laporan - Permintaan Barang"
      Case Persistent.SumberDataJenis.ST
        Me.Text = "Filter Laporan - Mutasi Stock"
      Case Persistent.SumberDataJenis.CS
        Me.Text = "Filter Laporan - Pemakaian Barang"
      Case Persistent.SumberDataJenis.AM
        Me.Text = "Filter Laporan - Produksi"
      Case Persistent.SumberDataJenis.PS
        Me.Text = "Filter Laporan - Penyesuaian Stock"
    End Select
  End Sub
  Overrides Sub InitializeData()
    txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(_sesi, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(_sesi)
    txtDivisi.Properties.DataSource = New XPCollection(Of Divisi)(_sesi)
    Select Case _jenis
      Case Persistent.SumberDataJenis.PB
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.PermintaanStock)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.PermintaanStock)(_sesi)
      Case Persistent.SumberDataJenis.ST, Persistent.SumberDataJenis.CS, Persistent.SumberDataJenis.AM, Persistent.SumberDataJenis.PS
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.StockMain)(_sesi, New BinaryOperator("Sumber", _jenis, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.StockMain)(_sesi, New BinaryOperator("Sumber", _jenis, BinaryOperatorType.Equal))
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
      Case Persistent.SumberDataJenis.PB
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PermintaanStockDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.ST, Persistent.SumberDataJenis.CS, Persistent.SumberDataJenis.PS, Persistent.SumberDataJenis.AM
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.StockDetail)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.Text = Nothing Then
      If txtNoBukti2.Text = Nothing Then
        result.Add(New BinaryOperator("Main.Kode", String.Format(format, txtNoBukti1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Main.Kode", txtNoBukti1.Text, txtNoBukti2.Text))
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
      result.Add(New BinaryOperator("Main.Karyawan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtGudang.Text <> "" Then
      result.Add(New BinaryOperator("Main.Gudang", CType(txtGudang.EditValue, Persistent.Gudang), BinaryOperatorType.Like))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Main.Divisi", CType(txtDivisi.EditValue, Divisi), BinaryOperatorType.Like))
    End If
    If txtCatatan.Text <> "" Then
      result.Add(New BinaryOperator("Main.Catatan", String.Format(format, txtCatatan.Text), BinaryOperatorType.Like))
    End If
    If _jenis = Persistent.SumberDataJenis.ST Then
      result.Add(New BinaryOperator("QtyOut", 0, BinaryOperatorType.Greater))
    End If

    Return GroupOperator.And(result)
  End Function
End Class