Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_FusohVoucher
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
			Case Persistent.SumberDataJenis.SQ
				Me.Text = "Filter Laporan - Penawaran [SQ]"
			Case Persistent.SumberDataJenis.SO
				Me.Text = "Filter Laporan - Order Penjualan [SO]"
        'Case Persistent.SumberDataJenis.DP
        '	Me.Text = "Filter Laporan - Uang Muka Penjualan"
      Case Persistent.SumberDataJenis.FD
        Me.Text = "Filter Laporan"
        txtNoProduksi.Visible = True
        lbNoProduksi.Visible = True
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
      Case Persistent.SumberDataJenis.SQ
        Dim x = New XPCollection(Of Persistent.Fusoh_Penawaran)(_sesi)
        txtNoBukti1.Properties.DataSource = x
        txtNoBukti2.Properties.DataSource = x
      Case Persistent.SumberDataJenis.SO
        Dim x = New XPCollection(Of Persistent.Fusoh_OrderPenjualan)(_sesi)
        txtNoBukti1.Properties.DataSource = x
        txtNoBukti2.Properties.DataSource = x
      Case Persistent.SumberDataJenis.FD ', Persistent.SumberDataJenis.RN, Persistent.SumberDataJenis.QS
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_SuratJalan)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_SuratJalan)(_sesi, New BinaryOperator("Sumber.Id", _jenis, BinaryOperatorType.Equal))
      Case Persistent.SumberDataJenis.IV
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_InvoicePenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_InvoicePenjualan)(_sesi)
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
			Case Persistent.SumberDataJenis.SQ
				_dataSource = New XPCollection(Of Persistent.Fusoh_PenawaranDetail)(_sesi, CreateCriteria)
			Case Persistent.SumberDataJenis.SO
				_dataSource = New XPCollection(Of Persistent.Fusoh_OrderPenjualanDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.IV
        _dataSource = New XPCollection(Of Persistent.Fusoh_InvoicePenjualanDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.FD ', Persistent.SumberDataJenis.QS
        _dataSource = New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(_sesi, CreateCriteria)
		End Select
	End Sub
	Private Function CreateCriteria() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))

		If Not txtNoBukti1.EditValue = Nothing Then
			If txtNoBukti2.EditValue = Nothing Then
				result.Add(New BinaryOperator("Main.Kode", txtNoBukti1.EditValue, BinaryOperatorType.Equal))
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
			result.Add(New BinaryOperator("Main.Pelanggan.Nama", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
		End If
		If txtKeterangan.Text <> "" Then
			result.Add(New BinaryOperator("Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
		End If
    If txtNoProduksi.Text <> "" Then
      result.Add(New BinaryOperator("ProduksiDetail.Main.Kode", String.Format(format, txtNoProduksi.Text), BinaryOperatorType.Like))
    End If

		Return GroupOperator.And(result)
	End Function
End Class