Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Utils.CustomAttribute
Public Class RF_BukuBesarStock
  Public Enum TipeForm
    <EnumDescription("Kartu Stock")> KartuStock = 0
    <EnumDescription("Buku Besar Stock")> BukuBesar = 1
    <EnumDescription("Nilai Persediaan")> NilaiPersediaan = 2
		<EnumDescription("Blanko Stock Opname")> BlankoStockOpname = 3
		<EnumDescription("Stock Minimum")> StockMinimum = 4
		<EnumDescription("Transaksi Stock")> TransaksiStock = 5

	End Enum
  Private _tipeForm As TipeForm
	Sub New(xTipe As TipeForm)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_tipeForm = xTipe
		If _tipeForm = TipeForm.NilaiPersediaan Then
			lytTanggal1.Text = "Per Tanggal"
			lytTanggal2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			txtGudang.Properties.ReadOnly = True
		End If
		If _tipeForm = TipeForm.BlankoStockOpname Then
			lytTanggal1.Text = "Periode Opname"
			lytTanggal2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
		End If
		If _tipeForm = TipeForm.StockMinimum Then
			Me.Text = "Filter Report Stock Minimum"
			lytTanggal1.Text = "Per Tanggal"
			lytTanggal2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			txtTglAwal.Properties.ReadOnly = True
			txtGudang.Properties.ReadOnly = False
			txtGudang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtGudang)
			txtKodeBarang1.Enabled = False
			txtKodeBarang2.Enabled = False
			'txtGudang.Properties.Editable = True
		End If

	End Sub
	Overrides Sub InitializeData()
    txtKodeBarang1.Properties.DataSource = New XPCollection(Of Persistent.Barang)(_sesi)
    txtKodeBarang2.Properties.DataSource = New XPCollection(Of Persistent.Barang)(_sesi)
    txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(_sesi)
    txtKategori.Properties.DataSource = New XPCollection(Of Persistent.Kategori)(_sesi)
    txtSubKategori.Properties.DataSource = New XPCollection(Of Persistent.SubKategori)(_sesi)
    txtMerk.Properties.DataSource = New XPCollection(Of Persistent.Merk)(_sesi)
    txtTglAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtTglAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

		If _tipeForm = TipeForm.NilaiPersediaan Then
			txtTglAwal.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))
		Else
			txtTglAkhir.Properties.MinValue = txtTglAwal.DateTime
			txtTglAwal.Properties.MaxValue = txtTglAkhir.DateTime
		End If
		If _tipeForm = TipeForm.StockMinimum Then
			txtGudang.Enabled = True
			txtTglAwal.DateTime = Now.AddDays(1)
		End If
	End Sub
	Overrides Sub Filter()
		Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
		Dim m02Setting As New NuSoft001.Logic.FinaSetting(_sesi)

		AddParameter("Periode", txtTglAwal.DateTime.ToString("dd-MMM-yy") & " " & txtTglAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
		AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
		AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
		AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))
		AddParameter("PeriodeAwal", txtTglAwal.DateTime, GetType(System.DateTime))
		AddParameter("PeriodeAkhir", txtTglAkhir.DateTime, GetType(System.DateTime))
		If Not txtGudang.EditValue Is Nothing Then
			AddParameter("Gudang", CType(txtGudang.EditValue, Persistent.Gudang).Kode, GetType(System.String))
		Else
			AddParameter("Gudang", "All", GetType(System.String))
		End If
		AddParameter("Periode", String.Concat(txtTglAwal.DateTime.ToString("DD-MMM-yyyy"), " s/d ", txtTglAkhir.DateTime.ToString("DD-MMM-yyyy")), GetType(System.String))

		Select Case _tipeForm
			Case TipeForm.KartuStock : KartuStock()
			Case TipeForm.NilaiPersediaan : NilaiStock()
			Case TipeForm.BukuBesar : BukuBesarStock()
			Case TipeForm.StockMinimum : StockMinimum()
			Case TipeForm.TransaksiStock
				_dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.StockDetail)(_sesi, CriteriaTransaksiStock)
			Case Else : DaftarStock()
		End Select
	End Sub
	Private Function CriteriaTransaksiStock() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"
		If Not txtTglAwal.EditValue Is Nothing Then
			If txtTglAkhir.EditValue Is Nothing Then
				result.Add(New BinaryOperator("Main.Tanggal", txtTglAwal.DateTime, BinaryOperatorType.Equal))
			Else
				result.Add(New BetweenOperator("Main.Tanggal", txtTglAwal.DateTime, txtTglAkhir.DateTime))
			End If
		End If

		If Not txtGudang.EditValue Is Nothing Then
			result.Add(New BinaryOperator("Gudang.Id", CType(txtGudang.EditValue, Persistent.Gudang).Id, BinaryOperatorType.Equal))
		End If
		Return GroupOperator.And(result)
	End Function

	Private Sub KartuStock()
    If (txtGudang.EditValue Is Nothing) Then
      Throw New Utils.Exception("Silahkan pilih gudang.", 0, "", "Filter")
      Exit Sub
    End If

    Dim barang As New DevExpress.Xpo.XPCollection(Of Persistent.Barang)(_sesi, CreateCriteriaBarang)
    Dim DataStock As New DevExpress.Xpo.XPCollection(Of Persistent.Report.KartuStock)(_sesi, CreateCriteriaData)
    For i = 0 To barang.Count - 1
      Dim barangId As Int64 = barang(i).Id
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.xSQLFunction.GetBeginningBalanceSPName, 0, barangId, txtTglAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtGudang.EditValue, Persistent.Gudang).Id)))
      Dim saldoNilai As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.xSQLFunction.GetBeginningBalanceSPName, 1, barangId, txtTglAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtGudang.EditValue, Persistent.Gudang).Id)))
      If DataStock.ToList.Exists(Function(m) m.Barang.Id = barangId) Then
        Dim ok = DataStock.ToList.Where(Function(c) c.Barang.Id = barangId)
        For Each x In ok
          x.SaldoAwal = saldo
          x.SaldoAwalNilai = saldoNilai
        Next
      Else
        If chkSaldo.Checked = True Then
          Dim item As New Persistent.Report.KartuStock(_sesi)
          item.Id = barangId
          item.Barang = barang(i)
          item.Masuk = 0
          item.Keluar = 0
          item.NoBukti = "Saldo Awal"
          item.SaldoAwal = saldo
          item.SaldoAwalNilai = saldoNilai
          item.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
          item.Tanggal = txtTglAwal.DateTime
          DataStock.Add(item)
        End If
      End If
    Next
    _dataSource = DataStock
  End Sub
  Private Sub BukuBesarStock()
    If (txtGudang.EditValue Is Nothing) Then
      Throw New Utils.Exception("Silahkan pilih gudang.", 0, "", "Filter")
      Exit Sub
    End If

    Dim barang As New DevExpress.Xpo.XPCollection(Of Persistent.Barang)(_sesi, CreateCriteriaBarang)
    Dim DataStock As New DevExpress.Xpo.XPCollection(Of Persistent.Report.KartuStock)(_sesi, CreateCriteriaData)
    For i = 0 To barang.Count - 1
      Dim barangId As Int64 = barang(i).Id
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.xSQLFunction.GetBeginningBalanceSPName, 0, barangId, txtTglAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtGudang.EditValue, Persistent.Gudang).Id)))
      If DataStock.ToList.Exists(Function(m) m.Barang.Id = barangId) Then
        Dim ok = DataStock.ToList.Where(Function(c) c.Barang.Id = barangId)
        For Each x In ok
          x.SaldoAwal = saldo
        Next
      Else
        If chkSaldo.Checked = True Then
          Dim item As New Persistent.Report.KartuStock(_sesi)
          item.Id = barangId
          item.Barang = barang(i)
          item.Masuk = 0
          item.Keluar = 0
          item.NoBukti = "Saldo Awal"
          item.SaldoAwal = saldo
          item.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
          item.Tanggal = txtTglAwal.DateTime
          DataStock.Add(item)
        End If
      End If
    Next
    _dataSource = DataStock
  End Sub
  Private Sub NilaiStock()
    If (txtTglAwal.EditValue Is Nothing) Then
      Throw New Utils.Exception("Silahkan input Tanggal.", 0, "", "Filter")
      Exit Sub
    End If
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.KartuStock)(_sesi, New BinaryOperator("Tanggal", txtTglAwal.DateTime, BinaryOperatorType.LessOrEqual))
    _dataSource = details
  End Sub
  Private Sub DaftarStock()
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoStock)(_sesi)
    _dataSource = details
  End Sub
  Private Function CreateCriteriaData() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    result.Add(New BetweenOperator("Tanggal", txtTglAwal.DateTime, txtTglAkhir.DateTime))
    If Not txtGudang.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Gudang.Id", CType(txtGudang.EditValue, Persistent.Gudang).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaBarang() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtKodeBarang1.EditValue Is Nothing Then
      If txtKodeBarang2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Kode", CType(txtKodeBarang1.EditValue, Persistent.Barang).Kode, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Kode", CType(txtKodeBarang1.EditValue, Persistent.Barang).Kode, CType(txtKodeBarang2.EditValue, Persistent.Barang).Kode))
      End If
    End If
    If Not txtKategori.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Kategori", CType(txtKategori.EditValue, Persistent.Kategori), BinaryOperatorType.Equal))
    End If

    If Not txtSubKategori.EditValue Is Nothing Then
      result.Add(New BinaryOperator("SubKategori", CType(txtSubKategori.EditValue, Persistent.SubKategori), BinaryOperatorType.Equal))
    End If

    If Not txtMerk.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Merk", CType(txtMerk.EditValue, Persistent.Merk), BinaryOperatorType.Equal))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Sub txtTgl1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTglAwal.EditValueChanging
    txtTglAkhir.Properties.MinValue = CDate(e.NewValue)
  End Sub
	Private Sub txtTgl2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTglAkhir.EditValueChanging
		txtTglAwal.Properties.MaxValue = CDate(e.NewValue)
	End Sub

	Private Sub StockMinimum()
		If (txtGudang.EditValue Is Nothing) Then
			Throw New Utils.Exception("Silahkan pilih gudang.", 0, "", "Filter")
			Exit Sub
		End If
		AddParameter("Periode", txtTglAwal.DateTime, GetType(System.DateTime))
		AddParameter("Gudang", CType(txtGudang.EditValue, Persistent.Gudang).Kode, GetType(System.String))

		Dim barang As New DevExpress.Xpo.XPCollection(Of Persistent.Barang)(_sesi, New BinaryOperator("StockMin", 0, BinaryOperatorType.Greater))
		Dim result As New List(Of StockMinimumClass)
		For i = 0 To barang.Count - 1
			Dim barangId As Int64 = barang(i).Id
			Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.xSQLFunction.GetBeginningBalanceSPName, 0, barangId, txtTglAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtGudang.EditValue, Persistent.Gudang).Id)))
			'Dim saldo As Double = 0

			If saldo < barang(i).StockMin Then
				Dim item = New StockMinimumClass
				item.Barang = barang(i)
				item.StockMinimum = barang(i).StockMin
				item.StockAkhir = saldo
				result.Add(item)
			End If
		Next


		_dataSource = result
	End Sub
	Private Structure StockMinimumClass
		Property Barang As Persistent.Barang
		Property StockMinimum As Double
		Property StockAkhir As Double
	End Structure

End Class