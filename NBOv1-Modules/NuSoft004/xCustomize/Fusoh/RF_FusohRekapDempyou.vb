Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_FusohRekap
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
      Case Persistent.SumberDataJenis.OP : Me.Text = "Filter Laporan - Order Produksi [Dempyou]"
      Case Persistent.SumberDataJenis.AM : Me.Text = "Filter Laporan - Produksi"
    End Select
  End Sub
  Overrides Sub InitializeData()
    Select Case _jenis
      Case Persistent.SumberDataJenis.OP
        Dim x = New XPCollection(Of Persistent.Fusoh_OrderProduksi)(_sesi)
        txtNoBukti1.Properties.DataSource = x
        txtNoBukti2.Properties.DataSource = x
      Case Persistent.SumberDataJenis.AM
        Dim x = New XPCollection(Of Persistent.Fusoh_StokMain)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
        txtNoBukti1.Properties.DataSource = x
        txtNoBukti2.Properties.DataSource = x
    End Select


    Dim z = New XPCollection(Of Persistent.Fusoh_Barang)(_sesi)
    txtBarangFG.Properties.DataSource = z
    txtBarangRM.Properties.DataSource = z
    txtCustomer.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(_sesi)
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
      Case Persistent.SumberDataJenis.OP : _dataSource = New XPCollection(Of Persistent.Fusoh_OrderProduksiBahanBaku)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.AM : _dataSource = New XPCollection(Of Persistent.Fusoh_StokSerial)(_sesi, CreateCriteriaProduksi)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    'result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
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
    If Not txtCustomer.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Main.Pelanggan.Id", txtCustomer.EditValue, BinaryOperatorType.Equal))
    End If
    If txtNoPO.Text <> "" Then
      result.Add(New BinaryOperator("Main.SODetail.Main.Kode", String.Format(format, txtNoPO.Text), BinaryOperatorType.Like))
    End If
    If txtNoLOT.Text <> "" Then
      result.Add(New BinaryOperator("Serial", String.Format(format, txtNoLOT.Text), BinaryOperatorType.Like))
    End If
    If txtMillSheet.Text <> "" Then
      result.Add(New BinaryOperator("Millsheet", String.Format(format, txtMillSheet.Text), BinaryOperatorType.Like))
    End If
    If Not txtBarangFG.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Main.SODetail.Barang.Id", txtBarangFG.EditValue, BinaryOperatorType.Equal))
    End If
    If Not txtBarangRM.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang.Id", txtBarangRM.EditValue, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaProduksi() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    'result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.EditValue Is Nothing Then
      If txtNoBukti2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("DetailMain.Main.Kode ", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("DetailMain.Main.Kode ", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("DetailMain.Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If Not txtCustomer.EditValue Is Nothing Then
      result.Add(New BinaryOperator("DetailMain.Main.Pelanggan.Id", txtCustomer.EditValue, BinaryOperatorType.Equal))
    End If
    If txtNoPO.Text <> "" Then
      result.Add(New BinaryOperator("DetailMain.Main.OrderProduksi.Kode", String.Format(format, txtNoPO.Text), BinaryOperatorType.Like))
    End If
    If txtNoLOT.Text <> "" Then
      result.Add(New BinaryOperator("Serial", String.Format(format, txtNoLOT.Text), BinaryOperatorType.Like))
    End If
    If txtMillSheet.Text <> "" Then
      result.Add(New BinaryOperator("Millsheet", String.Format(format, txtMillSheet.Text), BinaryOperatorType.Like))
    End If
    If Not txtBarangFG.EditValue Is Nothing Then
      result.Add(New BinaryOperator("DetailMain.Main.OrderProduksi.SODetail.Barang.Id", txtBarangFG.EditValue, BinaryOperatorType.Equal))
    End If
    If Not txtBarangRM.EditValue Is Nothing Then
      result.Add(New BinaryOperator("DetailMain.Barang.Id", txtBarangRM.EditValue, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
End Class