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
			Case Persistent.SumberDataJenis.FD
				Me.Text = "Filter Laporan - Rekap SJ"
		End Select
	End Sub
	Overrides Sub InitializeData()
		txtTgl1.DateTime = New Date(Now.Year, Now.Month, 1)
		txtTgl2.DateTime = Now
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
			Case Persistent.SumberDataJenis.FD
				Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
					Try
						splashManager.ShowWaitForm()
						splashManager.SetWaitFormCaption("Silahkan Tunggu")
						splashManager.SetWaitFormDescription("Filtering data  ...")

            _dataSource = GetSourceRekapSJ(New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(_sesi, CreateCriteria).ToList, splashManager)

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

		result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
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

		Return GroupOperator.And(result)
	End Function

  Private Function GetSourceRekapSJ(dataSJ As List(Of Persistent.Fusoh_SuratJalanDetail), Splash As DevExpress.XtraSplashScreen.SplashScreenManager) As List(Of RekapSJClass)
    Dim result As New List(Of RekapSJClass)
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

        Dim eximDetailId = grSerial.DetailMain.EximDetail

        If Not grSerial Is Nothing Then
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




      result.Add(New RekapSJClass() With {
        .IdSJDetail = sjDetail.Id,
        .NomorSJ = sjDetail.Main.Kode,
        .TanggalSJ = sjDetail.Main.Tanggal,
        .KodeBarangSJ = sjDetail.Barang.Kode,
        .NamaBarangSJ = sjDetail.Barang.Nama,
        .NamaPartBarangSJ = sjDetail.Barang.NamaPart,
        .QtySJ = sjDetail.Qty,
        .NomorPO = sjDetail.SODetail.NoPODetail,
        .POLine = sjDetail.SODetail.POLine,
        .Keterangan = sjDetail.Barang.Nama & "   " & Math.Round(sjDetail.Barang.OutDiameter, 1) & "X" & Math.Round(sjDetail.Barang.Thickness, 1) & "X" & Math.Round(sjDetail.Barang.Length, 1), '[Barang.Nama] + '   ' + Round([Barang.OutDiameter],1) +'X' +   Round([Barang.Thickness],1) + 'X' +  Round([Barang.Length],1)
        .NamaPelanggan = sjDetail.Main.Pelanggan.Nama,
        .AlamatPelanggan = sjDetail.Main.Pelanggan.Alamat,
        .KodeProduksi = sjDetail.ProduksiDetail.Main.Kode,
        .IdProduksiBahanBaku = 1,
        .KodeBarangBahanBaku = "Kode Bahan Baku",
        .NamaBarangBahanBaku = "Mama Bahan Baku",
        .KodeSerialKeluar = "SN",
        .IdEximDetail = 1,
        .IdPembelianDetail = pembelianId,
        .HargaPembelian = harga,
        .KodePembelian = kodePembelian,
        .TanggalPembelian = tanggalPembelian,
        .KursPembelian = kurs
      })






      ''txtLOG.Text = txtLOG.Text & " " & sjDetail.Main.Tanggal & "->" & sjDetail.Main.Kode & vbCrLf
      ''==== cari bahan baku
      ''Dim produksiBahanBakuSerial = sjDetail.ProduksiDetail.Main.Detail.Where(Function(w) w.Serial.Count > 0).SelectMany(Function(s) s.Serial)
      'If sjDetail.ProduksiDetail.Main.OrderProduksi Is Nothing Then Continue For
      'Dim produksiBahanBakuSerial = sjDetail.ProduksiDetail.Main.OrderProduksi.BahanBaku


      'For Each dataSerial In produksiBahanBakuSerial
      '  '==== cari pembelian
      '  'Dim grSerial = New XPQuery(Of Persistent.Fusoh_SuratJalanDetailSerial)(_sesi) _
      '  '      .Where(Function(w) w.DetailMain.Barang Is dataSerial.DetailMain.Barang _
      '  '      AndAlso w.Serial = dataSerial.Serial AndAlso w.LengthIn > 0) _
      '  '      .ToList.Take(1).SingleOrDefault
      '  Dim grSerial = New XPQuery(Of Persistent.Fusoh_SuratJalanDetailSerial)(_sesi) _
      '        .Where(Function(w) w.DetailMain.Barang Is dataSerial.Barang _
      '        AndAlso w.Serial = dataSerial.Serial AndAlso w.LengthIn > 0) _
      '        .ToList.Take(1).SingleOrDefault

      '  'txtLOG.Text = txtLOG.Text & "Cari Serialnya " & dataSerial.Serial & "->" & (grSerial Is Nothing) & vbCrLf
      '  If Not grSerial Is Nothing Then
      '    Dim eximDetailId = grSerial.DetailMain.EximDetail
      '    Dim pembelianId As Long
      '    Dim kurs As Decimal = 0
      '    Dim harga As Decimal = 0
      '    Dim kodePembelian As String = ""
      '    Dim tanggalPembelian As Date
      '    If (eximDetailId = 0) Then
      '      'txtLOG.Text = txtLOG.Text & "====> Kursnya adalah Exim " & grSerial.DetailMain.Main.Kode & "->" & grSerial.DetailMain.Main.Kurs & vbCrLf
      '      pembelianId = 0
      '      harga = grSerial.DetailMain.Harga
      '      kurs = grSerial.DetailMain.Main.Kurs
      '      kodePembelian = grSerial.DetailMain.Main.Kode
      '      tanggalPembelian = grSerial.DetailMain.Main.Tanggal
      '    Else
      '      Dim detInvoice = New XPQuery(Of Persistent.Fusoh_05PenerimaanInvoicePembelianDetail)(_sesi).Where(Function(w) w.EximDetail = eximDetailId).SingleOrDefault
      '      If (Not detInvoice Is Nothing) Then
      '        'txtLOG.Text = txtLOG.Text & "====> Kursnya adalah RI " & detInvoice.Main.Kode & "->" & detInvoice.Main.Kurs & vbCrLf
      '        pembelianId = detInvoice.Main.Id
      '        harga = detInvoice.Harga
      '        kurs = detInvoice.Main.Kurs
      '        kodePembelian = detInvoice.Main.Kode
      '        tanggalPembelian = detInvoice.Main.Tanggal
      '      End If
      '    End If

      '    '==== add to result
      '    If (kurs > 1) Then
      '      result.Add(New RekapSJClass() With {
      '        .IdSJDetail = sjDetail.Id,
      '        .NomorSJ = sjDetail.Main.Kode,
      '        .TanggalSJ = sjDetail.Main.Tanggal,
      '        .KodeBarangSJ = sjDetail.Barang.Kode,
      '        .NamaBarangSJ = sjDetail.Barang.Nama,
      '        .NamaPartBarangSJ = sjDetail.Barang.NamaPart,
      '        .QtySJ = sjDetail.Qty,
      '        .NomorPO = sjDetail.SODetail.NoPODetail,
      '        .POLine = sjDetail.SODetail.POLine,
      '        .Keterangan = sjDetail.Barang.Nama & "   " & Math.Round(sjDetail.Barang.OutDiameter, 1) & "X" & Math.Round(sjDetail.Barang.Thickness, 1) & "X" & Math.Round(sjDetail.Barang.Length, 1), '[Barang.Nama] + '   ' + Round([Barang.OutDiameter],1) +'X' +   Round([Barang.Thickness],1) + 'X' +  Round([Barang.Length],1)
      '        .NamaPelanggan = sjDetail.Main.Pelanggan.Nama,
      '        .AlamatPelanggan = sjDetail.Main.Pelanggan.Alamat,
      '        .KodeProduksi = sjDetail.ProduksiDetail.Main.Kode,
      '        .IdProduksiBahanBaku = dataSerial.Id,
      '        .KodeBarangBahanBaku = dataSerial.Barang.Kode,
      '        .NamaBarangBahanBaku = dataSerial.Barang.Nama,
      '        .KodeSerialKeluar = dataSerial.Serial,
      '        .IdEximDetail = eximDetailId,
      '        .IdPembelianDetail = pembelianId,
      '        .HargaPembelian = harga,
      '        .KodePembelian = kodePembelian,
      '        .TanggalPembelian = tanggalPembelian,
      '        .KursPembelian = kurs
      '      })
      '    End If
      '  End If
      'Next
    Next
    'MsgBox("OKE pencarian data")
    Return result
  End Function
End Class

Friend Structure RekapSJClass
	Property IdSJDetail As Long
	Property NomorSJ As String
	Property TanggalSJ As Date
	Property KodeBarangSJ As String
	Property NamaBarangSJ As String
	Property NamaPartBarangSJ As String
	Property QtySJ As Double

	Property NomorPO As String
	Property POLine As String
	Property Keterangan As String

	Property NamaPelanggan As String
	Property AlamatPelanggan As String

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