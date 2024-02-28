Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_FusohStockBalance
	Private _ReportName As MainClass.reportName
	Sub New(xReport As MainClass.reportName)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_ReportName = xReport

		Select Case xReport
			Case MainClass.reportName.zFusohRekapStockBalance : Me.Text = "Filter Laporan - Rekap Stock Balance"
		End Select
	End Sub
	Overrides Sub InitializeData()
		Dim tgl = Now
		txtTanggalAwal.DateTime = New Date(tgl.Year, tgl.Month, 1)
		txtTanggalAkhir.DateTime = New Date(tgl.Year, tgl.Month, Date.DaysInMonth(tgl.Year, tgl.Month))
	End Sub
	Overrides Sub Filter()
		If txtTanggalAwal.EditValue Is Nothing Then
			Throw New Exception("Masukkan tanggal awal")
		End If
		If txtTanggalAkhir.EditValue Is Nothing Then
			Throw New Exception("Masukkan tanggal akhir")
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
		AddParameter("TglAwal", txtTanggalAwal.DateTime, GetType(DateTime))
		AddParameter("TglAkhir", txtTanggalAkhir.DateTime, GetType(DateTime))

		Select Case _ReportName
			Case MainClass.reportName.zFusohRekapStockBalance : StockBalance()
		End Select
	End Sub
	Private Function CreateCriteria() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		result.Add(New BinaryOperator("TipeBarang", Persistent.TipeBarang.Jasa, BinaryOperatorType.NotEqual))
		If CType(txtJenis.EditValue, UInt16) = 1 Then
			result.Add(New BinaryOperator("BatangTitipan", False, BinaryOperatorType.Equal))
		End If
		If CType(txtJenis.EditValue, UInt16) = 2 Then
			result.Add(New BinaryOperator("BatangTitipan", True, BinaryOperatorType.Equal))
		End If

		If Not String.IsNullOrEmpty(txtPartNo.Text) Then
			result.Add(New BinaryOperator("Kode", String.Format(format, txtPartNo.Text), BinaryOperatorType.Like))
		End If
		If Not String.IsNullOrEmpty(txtMaterial.Text) Then
			result.Add(New BinaryOperator("Nama", String.Format(format, txtMaterial.Text), BinaryOperatorType.Like))
		End If
		If Not String.IsNullOrEmpty(txtCustomer.Text) Then
			result.Add(New BinaryOperator("Customer.Nama", String.Format(format, txtCustomer.Text), BinaryOperatorType.Like))
		End If
		Return GroupOperator.And(result)
	End Function
	Private Sub StockBalance()
		Dim result As New List(Of StockBalanceClass)
		Dim listBarang = New XPCollection(Of Persistent.Fusoh_Barang)(_sesi, CreateCriteria())
		Dim awalStok = New XPQuery(Of Persistent.Fusoh_StokDetail)(_sesi).Where(Function(w) w.Main.Tanggal.Date < txtTanggalAwal.DateTime.Date).ToList
		Dim dataStok = New XPQuery(Of Persistent.Fusoh_StokDetail)(_sesi).Where(Function(w) w.Main.Tanggal.Date >= txtTanggalAwal.DateTime.Date AndAlso w.Main.Tanggal.Date <= txtTanggalAkhir.DateTime.Date).ToList

		For Each item In listBarang
			Dim awalDetail = awalStok.Where(Function(w) w.Barang Is item)
			Dim stokDetail = dataStok.Where(Function(w) w.Barang Is item)

			Dim det = New StockBalanceClass
			det.Barang = item
			det.SaldoAwalStok = awalDetail.Sum(Function(s) s.QtyIn - s.QtyOut)
			det.Masuk = stokDetail.Sum(Function(s) s.QtyIn)
			det.Keluar = stokDetail.Sum(Function(s) s.QtyOut)
			det.TransferStock = stokDetail.Where(Function(w) w.Main.Sumber.Id = 107).Sum(Function(s) s.QtyIn)

			det.SaldoAwalLength = awalDetail.Sum(Function(s) s.TotalLength)
			det.LengthIn = stokDetail.Sum(Function(s) s.TotalLengthIn)
			det.LengthOut = stokDetail.Sum(Function(s) s.TotalLengthOut)

			det.TotalWeight = FusohLogic.Item.GetWeight(item.OutDiameter, item.Length, item.Thickness) * det.Stok
			det.TotalWeight2 = stokDetail.Sum(Function(s) s.QtyIn * s.Weight) - stokDetail.Sum(Function(s) s.QtyOut * s.Weight)

			'det.Amount = stokDetail.Sum(Function(s) ((s.QtyIn * s.Harga) * s.Main.Kurs) - (s.TotalHPP))
			det.SaldoAwalAmount = awalDetail.Sum(Function(s) ((s.QtyIn * s.Harga) * s.Main.Kurs) - (s.TotalHPP))
			det.AmountIn = stokDetail.Sum(Function(s) ((s.QtyIn * s.Harga) * s.Main.Kurs))
			det.AmountOut = stokDetail.Sum(Function(s) (s.TotalHPP))

			det.SaldoAwalSerialWeight = awalDetail.Sum(Function(s) s.SerialWeightIN - s.SerialWeightOut)
			det.SerialWeightIN = stokDetail.Sum(Function(s) s.SerialWeightIN)
			det.SerialWeightOut = stokDetail.Sum(Function(s) s.SerialWeightOut)
			result.Add(det)
		Next

		If chkStock0.Checked = True Then
			_dataSource = result
		Else
			_dataSource = result.Where(Function(m) m.SisaLength > 0 Or m.Stok > 0)
		End If
	End Sub
	Private Structure StockBalanceClass
		Property Barang As Persistent.Fusoh_Barang
		Property SaldoAwalStok As Double
		Property Masuk As Double
		Property Keluar As Double
		Property TransferStock As Double
		ReadOnly Property Stok As Double
			Get
				Return SaldoAwalStok + Masuk - Keluar
			End Get
		End Property

		Property SaldoAwalLength As Double
		Property LengthIn As Double
		Property LengthOut As Double
		ReadOnly Property SisaLength As Double
			Get
				Return SaldoAwalLength + LengthIn - LengthOut
			End Get
		End Property

		Property TotalWeight As Double
		Property TotalWeight2 As Double

		Property SaldoAwalAmount As Double
		Property AmountIn As Double
		Property AmountOut As Double
		'Property Amount As Double
		ReadOnly Property Amount As Double
			Get
				Return SaldoAwalAmount + AmountIn - AmountOut
			End Get
		End Property

		Property SaldoAwalSerialWeight As Double
		Property SerialWeightIN As Double
		Property SerialWeightOut As Double
		ReadOnly Property SerialWeight As Double
			Get
				Return SaldoAwalSerialWeight + SerialWeightIN - SerialWeightOut
			End Get
		End Property
	End Structure
End Class