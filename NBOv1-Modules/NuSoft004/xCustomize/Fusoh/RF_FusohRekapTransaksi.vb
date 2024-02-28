Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_FusohRekapTransaksi
	Private _ReportName As MainClass.reportName
	Sub New(xReport As MainClass.reportName)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_ReportName = xReport

		Select Case xReport
			Case MainClass.reportName.zFusohMutasiWIP
				Me.Text = "Filter Laporan - Mutasi WIP"
			Case MainClass.reportName.zFusohMutasiWIPDetail
				Me.Text = "Filter Laporan - Mutasi WIP Detail"
		End Select
	End Sub
	Overrides Sub InitializeData()
		Select Case _ReportName
			Case MainClass.reportName.zFusohMutasiWIP
				Dim x = New XPCollection(Of Persistent.Fusoh_Produksi)(_sesi).Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.AM Or w.Sumber.Id = Persistent.SumberDataJenis.CW)
				txtNoBukti1.Properties.DataSource = x
				txtNoBukti2.Properties.DataSource = x
		End Select
		txtBarangJadi.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_Barang)(_sesi)
	End Sub
	Overrides Sub Filter()
		If _ReportName = MainClass.reportName.zFusohMutasiWIPDetail Then
			If txtTgl1.EditValue Is Nothing Then
				Throw New Exception("Masukkan tanggal awal")
			End If
			If txtTgl2.EditValue Is Nothing Then
				Throw New Exception("Masukkan tanggal akhir")
			End If
		End If


		Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
		Dim glSetting As New NuSoft001.Logic.FinaSetting(_sesi)
		AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
		AddParameter("Alamat1", setting.Alamat1, GetType(String))
		AddParameter("Alamat2", setting.Alamat2, GetType(String))
		AddParameter("BidangUsaha", setting.BidangUsaha, GetType(String))
		AddParameter("NoFax", setting.NoFax, GetType(String))
		AddParameter("NoTelp", setting.NoTelp, GetType(String))
		AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
		AddParameter("TglAwal", txtTgl1.DateTime, GetType(DateTime))
		AddParameter("TglAkhir", txtTgl2.DateTime, GetType(DateTime))
		AddParameter("TampilkanDetail", chkTampilkanDetail.Checked, GetType(Boolean))

		Select Case _ReportName
			Case MainClass.reportName.zFusohMutasiWIP
				_dataSource = New XPCollection(Of Persistent.Fusoh_StokDetail)(_sesi, CreateCriteria)
			Case MainClass.reportName.zFusohMutasiWIPDetail
				MutasiWIPDetail()
		End Select
	End Sub
	Private Function CreateCriteria() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		If _ReportName = MainClass.reportName.zFusohMutasiWIP Then
			result.Add(New BinaryOperator("Barang.Kode", "WIP", BinaryOperatorType.Equal))
		End If
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
		If txtKontak.Text <> "" Then
			result.Add(New BinaryOperator("Main.Pelanggan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
		End If
		If txtKeterangan.Text <> "" Then
			result.Add(New BinaryOperator("Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
		End If
		If Not txtBarangJadi.EditValue Is Nothing Then
			result.Add(New BinaryOperator("SODetail.Barang", CType(txtBarangJadi.EditValue, Persistent.Fusoh_Barang), BinaryOperatorType.Equal))
		End If

		Return GroupOperator.And(result)
	End Function
	Private Sub MutasiWIPDetail()
		Dim sql = "
SELECT
  so.primary_main as SOId,
  m04bitem.u_code as KodeBarang,
  m04bitem.d_name as NamaBarang,
  coalesce(Sum(d.d_qtyin),0) AS QtyMasuk,
  coalesce(Sum(d.d_qtyout),0) AS QtyKeluar,
  coalesce(Sum(If(u.d_date < '{0}', d.d_qtyin - d.d_qtyout, 0)),0) AS QtySaldoAwal,
  coalesce(Sum(If(u.d_date >= '{0}', d.d_qtyin, 0)),0) AS QtyMutasiIN,
  coalesce(Sum(If(u.d_date >= '{0}', d.d_qtyout, 0)),0) AS QtyMutasiOut,
  coalesce(Sum(d.d_qtyin - d.d_qtyout),0) AS QtySaldoAkhir,
  coalesce(Sum(d.d_qtyin*d.d_price*u.d_kurs),0) as AmountIN,
  coalesce(Sum(d.d_hpp),0) as AmountOUT,
  coalesce(Sum(If(u.d_date < '{0}', ((d.d_qtyin*d.d_price*u.d_kurs)-d.d_hpp), 0)),0) AS AmountSaldoAwal,
  coalesce(Sum(If(u.d_date >= '{0}', (d.d_qtyin*d.d_price*u.d_kurs), 0)),0) AS AmountMutasiIN,
  coalesce(Sum(If(u.d_date >= '{0}', d.d_hpp, 0)),0) AS AmountMutasiOut,
  coalesce(Sum((d.d_qtyin*d.d_price*u.d_kurs)-d.d_hpp),0) as AmountSaldoAkhir,
  m04bitem.d_od,
  m04bitem.d_id,
  m04bitem.d_ticknes,
  m04bitem.d_length
FROM
  m04dstockdetail d
  LEFT JOIN m04cstockmain u ON d.p_id = u.p_id
  LEFT JOIN m06edetailorder so ON d.f_idsod = so.primary_main
  LEFT JOIN m04bitem ON so.f_item = m04bitem.p_id
WHERE
  d.f_item = 2183 AND
  u.d_date <= '{1}'
GROUP BY
  d.f_item,
  so.primary_main,
  so.f_item,
  m04bitem.u_code,
  m04bitem.d_name,
  m04bitem.d_od,
  m04bitem.d_id,
  m04bitem.d_ticknes,
  m04bitem.d_length
"
		sql = sql.Replace("{0}", txtTgl1.DateTime.ToString("yyyy-MM-dd"))
		sql = sql.Replace("{1}", txtTgl2.DateTime.ToString("yyyy-MM-dd"))
		Dim xdata = _sesi.GetObjectsFromQuery(Of Persistent.NonViewStockWIPDetail)(sql).ToList()

		If chkStock0.Checked = True Then
			_dataSource = xdata
		Else
			_dataSource = xdata.Where(Function(m) m.QtySaldoAwal + m.QtyMutasiIN + m.QtyMutasiOut <> 0)
		End If

	End Sub
End Class