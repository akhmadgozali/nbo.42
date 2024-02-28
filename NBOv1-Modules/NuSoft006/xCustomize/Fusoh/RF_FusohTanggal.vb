Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Friend Class RF_FusohTanggal
	Private _reportName As MainClass.reportName

	Sub New(reportName As MainClass.reportName)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_reportName = reportName

		Select Case _reportName
			Case MainClass.reportName.zFusohRekapSJKurs
				Me.Text = "Filter Laporan - Rekap SJ Kurs"
		End Select
	End Sub
	Overrides Sub InitializeData()
		Select Case _reportName
			Case MainClass.reportName.zFusohRekapSJKurs
				Dim dsNoBukti = New XPCollection(Of Persistent.Fusoh_SuratJalan)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.FD, BinaryOperatorType.Equal))
				txtNoBukti1.Properties.DataSource = dsNoBukti
				txtNoBukti2.Properties.DataSource = dsNoBukti
				txtTgl1.DateTime = New Date(Now.Year, Now.Month, 1)
				txtTgl2.DateTime = Now
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
		AddParameter("Tanggal1", txtTgl1.DateTime, GetType(Date))
		AddParameter("Tanggal2", txtTgl2.DateTime, GetType(Date))

		Select Case _reportName
			Case MainClass.reportName.zFusohRekapSJKurs
				Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
					Try
						splashManager.ShowWaitForm()
						splashManager.SetWaitFormCaption("Silahkan Tunggu")
						splashManager.SetWaitFormDescription("Filtering data  ...")

            _dataSource = GetSourceRekapSJKurs(New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(_sesi, CreateCriteria).ToList, splashManager)

            splashManager.CloseWaitForm()
					Catch ex As Exception
						splashManager.CloseWaitForm()
						Throw New Exception(ex.Message, ex.InnerException)
					End Try
				End Using
		End Select
	End Sub
	Private Function CreateCriteria() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		Select Case _reportName
			Case MainClass.reportName.zFusohRekapSJKurs
				result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(Persistent.SumberDataJenis.FD), BinaryOperatorType.Equal))
		End Select
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
		If txtNoProduksi.Text <> "" Then
			result.Add(New BinaryOperator("ProduksiDetail.Main.Kode", String.Format(format, txtNoProduksi.Text), BinaryOperatorType.Like))
		End If

		Return GroupOperator.And(result)
	End Function

  Private Function GetSourceRekapSJKurs(dataSJ As List(Of Persistent.Fusoh_SuratJalanDetail), Splash As DevExpress.XtraSplashScreen.SplashScreenManager) As List(Of RekapSJKursClass)
    Dim result As New List(Of RekapSJKursClass)
    Dim xI As Long = 0
    For Each sjDetail In dataSJ
      xI = xI + 1
      Splash.SetWaitFormDescription("Proses ambil kurs pembelian : " & xI & " - " & dataSJ.Count)

      Dim pembelianId As Long
      Dim kurs As Decimal = 0
      Dim harga As Decimal = 0
      Dim kodePembelian As String = ""
      Dim tanggalPembelian As Date

      '==== cari bahan baku
      If Not sjDetail.ProduksiDetail.Main.OrderProduksi Is Nothing Then
        Dim produksiBahanBakuSerial = sjDetail.ProduksiDetail.Main.OrderProduksi.BahanBaku.Take(1).SingleOrDefault
        Dim grSerial = New XPQuery(Of Persistent.Fusoh_SuratJalanDetailSerial)(_sesi) _
                .Where(Function(w) w.Serial = produksiBahanBakuSerial.Serial AndAlso w.LengthIn > 0) _
        .ToList.Take(1).SingleOrDefault

        If Not grSerial Is Nothing Then
          Dim eximDetailId = grSerial.DetailMain.EximDetail

          If (eximDetailId Is Nothing OrElse eximDetailId = 0) Then
            pembelianId = 0
            harga = grSerial.DetailMain.Harga
            kurs = grSerial.DetailMain.Main.Kurs
            kodePembelian = grSerial.DetailMain.Main.Kode
            tanggalPembelian = grSerial.DetailMain.Main.Tanggal
          Else
            Dim detInvoice = New XPQuery(Of Persistent.Fusoh_05PenerimaanInvoicePembelianDetail)(_sesi).Where(Function(w) w.EximDetail = eximDetailId).SingleOrDefault
            If (Not detInvoice Is Nothing) Then
              pembelianId = detInvoice.Main.Id
              harga = detInvoice.Harga
              kurs = detInvoice.Main.Kurs
              kodePembelian = detInvoice.Main.Kode
              tanggalPembelian = detInvoice.Main.Tanggal
            End If
          End If
        End If
      End If

      result.Add(New RekapSJKursClass() With {
              .IdSJDetail = sjDetail.Id,
              .NomorSJ = sjDetail.Main.Kode,
              .TanggalSJ = sjDetail.Main.Tanggal,
              .KodeBarangSJ = sjDetail.Barang.Kode,
              .NamaBarangSJ = sjDetail.Barang.Nama,
              .QtySJ = sjDetail.Qty,
              .KodeProduksi = sjDetail.ProduksiDetail.Main.Kode,
              .IdProduksiBahanBaku = 0, 'dataSerial.Id,
              .KodeBarangBahanBaku = "Kode", 'dataSerial.Barang.Kode,
              .NamaBarangBahanBaku = "Nama", 'dataSerial.Barang.Nama,
              .KodeSerialKeluar = "Serial", 'dataSerial.Serial,
              .IdEximDetail = 0, 'eximDetailId,
              .IdPembelianDetail = 0, 'pembelianId,
              .HargaPembelian = harga, 'harga,
              .KodePembelian = kodePembelian, 'kodePembelian,
              .TanggalPembelian = tanggalPembelian, 'tanggalPembelian,
              .KursPembelian = kurs
            })








      '   For Each dataSerial In produksiBahanBakuSerial
      '	'==== cari pembelian
      '	'Dim grSerial = New XPQuery(Of Persistent.Fusoh_SuratJalanDetailSerial)(_sesi) _
      '	'			.Where(Function(w) w.DetailMain.Barang Is dataSerial.DetailMain.Barang _
      '	'			AndAlso w.Serial = dataSerial.Serial AndAlso w.LengthIn > 0) _
      '	'			.ToList.Take(1).SingleOrDefault
      '	Dim grSerial = New XPQuery(Of Persistent.Fusoh_SuratJalanDetailSerial)(_sesi) _
      '				.Where(Function(w) w.DetailMain.Barang Is dataSerial.Barang _
      '				AndAlso w.Serial = dataSerial.Serial AndAlso w.LengthIn > 0) _
      '				.ToList.Take(1).SingleOrDefault

      '	If Not grSerial Is Nothing Then
      '		Dim eximDetailId = grSerial.DetailMain.EximDetail
      '		Dim pembelianId As Long
      '		Dim kurs As Decimal = 0
      '		Dim harga As Decimal = 0
      '		Dim kodePembelian As String = ""
      '		Dim tanggalPembelian As Date
      '		If (eximDetailId Is Nothing OrElse eximDetailId = 0) Then
      '			pembelianId = 0
      '			harga = grSerial.DetailMain.Harga
      '			kurs = grSerial.DetailMain.Main.Kurs
      '			kodePembelian = grSerial.DetailMain.Main.Kode
      '			tanggalPembelian = grSerial.DetailMain.Main.Tanggal
      '		Else
      '			Dim detInvoice = New XPQuery(Of Persistent.Fusoh_05PenerimaanInvoicePembelianDetail)(_sesi).Where(Function(w) w.EximDetail = eximDetailId).SingleOrDefault
      '			If (Not detInvoice Is Nothing) Then
      '				pembelianId = detInvoice.Main.Id
      '				harga = detInvoice.Harga
      '				kurs = detInvoice.Main.Kurs
      '				kodePembelian = detInvoice.Main.Kode
      '				tanggalPembelian = detInvoice.Main.Tanggal
      '			End If
      '		End If

      '		'==== add to result
      '		If (kurs > 1) Then
      '			result.Add(New RekapSJKursClass() With {
      '				.IdSJDetail = sjDetail.Id,
      '				.NomorSJ = sjDetail.Main.Kode,
      '				.TanggalSJ = sjDetail.Main.Tanggal,
      '				.KodeBarangSJ = sjDetail.Barang.Kode,
      '				.NamaBarangSJ = sjDetail.Barang.Nama,
      '				.QtySJ = sjDetail.Qty,
      '				.KodeProduksi = sjDetail.ProduksiDetail.Main.Kode,
      '				.IdProduksiBahanBaku = dataSerial.Id,
      '				.KodeBarangBahanBaku = dataSerial.Barang.Kode,
      '				.NamaBarangBahanBaku = dataSerial.Barang.Nama,
      '				.KodeSerialKeluar = dataSerial.Serial,
      '				.IdEximDetail = eximDetailId,
      '				.IdPembelianDetail = pembelianId,
      '				.HargaPembelian = harga,
      '				.KodePembelian = kodePembelian,
      '				.TanggalPembelian = tanggalPembelian,
      '				.KursPembelian = kurs
      '			})
      '		End If
      '	End If
      'Next
    Next
    Return result
  End Function
End Class

Friend Structure RekapSJKursClass
	Property IdSJDetail As Long
	Property NomorSJ As String
	Property TanggalSJ As Date
	Property KodeBarangSJ As String
	Property NamaBarangSJ As String
	Property QtySJ As Double
	Property IdProduksiBahanBaku As Long
	Property KodeProduksi As String
	Property KodeBarangBahanBaku As String
	Property NamaBarangBahanBaku As String
	Property KodeSerialKeluar As String
	Property IdEximDetail As Long
	Property IdPembelianDetail As Long
	Property HargaPembelian As Decimal
	Property KodePembelian As String
	Property TanggalPembelian As Date
	Property KursPembelian As Decimal
End Structure