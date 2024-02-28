Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001
Imports System.Windows.Forms

Friend Class RF_FusohDetailStokBahanBaku
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.Text = "Filter Laporan - Detail Stok Bahan Baku"
	End Sub
	Overrides Sub InitializeData()
		txtTanggal1.DateTime = Now
		txtTanggal2.DateTime = Now
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
		AddParameter("TanggalFilter", txtTanggal1.DateTime, GetType(Date))
		AddParameter("TanggalFilter2", txtTanggal2.DateTime, GetType(Date))

		Dim result As New List(Of DetailStokBahanBakuClass)
		Dim listBarang = New XPCollection(Of Persistent.Fusoh_Barang)(_sesi, CreateCriteria())
		Dim dataStok = New XPQuery(Of Persistent.Fusoh_StokDetail)(_sesi) _
								.Where(Function(w) listBarang.Contains(w.Barang) AndAlso w.Main.Tanggal <= txtTanggal2.DateTime.Date).ToList

		For Each item In listBarang
			Dim stokDetail = dataStok.Where(Function(w) w.Barang Is item)
			Dim saldoAwal = stokDetail.Where(Function(w) w.Main.Tanggal < txtTanggal1.DateTime.Date).Sum(Function(s) s.QtyIn - s.QtyOut)
			Dim qtyIn = stokDetail.Where(Function(w) w.Main.Tanggal >= txtTanggal1.DateTime.Date).Sum(Function(s) s.QtyIn)
			Dim qtyOut = stokDetail.Where(Function(w) w.Main.Tanggal >= txtTanggal1.DateTime.Date).Sum(Function(s) s.QtyOut)

			Dim serialData = stokDetail.SelectMany(Function(d) d.Serial).GroupBy(Function(g) g.Serial) _
        .Select(Function(s) New With {.SisaLength = s.Sum(Function(f) f.SisaLength)})

      Dim ok = serialData.Where(Function(w) w.SisaLength > 0).GroupBy(Function(g) g.SisaLength) _
        .Select(Function(s) New With {.SisaLength = s.Key, .Qty = s.Count()}).ToList

      For Each x In ok
				Dim det = New DetailStokBahanBakuClass
				det.Barang = item
				det.SaldoAwal = saldoAwal
				det.Masuk = qtyIn
				det.Keluar = qtyOut
        'det.SNMillsheet = x.Millsheet
        'det.SNKode = x.Serial
        det.SNLength = x.SisaLength.ToString
				det.SNQty = x.Qty
				If saldoAwal + qtyIn - qtyOut > 0 Then
					result.Add(det)
				Else
					If chkStock0.Checked Then
						result.Add(det)
					End If
				End If
			Next
		Next

		_dataSource = result
	End Sub
	Private Function CreateCriteria() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		result.Add(New BinaryOperator("TipeBarang", Persistent.TipeBarang.BahanBaku, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("BatangTitipan", chkTitipan.Checked, BinaryOperatorType.Equal))
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

	Private Structure DetailStokBahanBakuClass
		Property Barang As Persistent.Fusoh_Barang
		Property SaldoAwal As Double
		Property Masuk As Double
		Property Keluar As Double
		ReadOnly Property Stok As Double
			Get
				Return SaldoAwal + Masuk - Keluar
			End Get
		End Property
    'Property SNMillsheet As String
    Property SNKode As String
    Property SNLength As String
		Property SNQty As Double
	End Structure
End Class