Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class RF_StockPerTanggal
 Overrides Sub InitializeData()
  txtKodeBarang1.Properties.DataSource = New XPCollection(Of Persistent.Barang)(_sesi)
  txtKodeBarang2.Properties.DataSource = New XPCollection(Of Persistent.Barang)(_sesi)
  txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(_sesi)
  txtKategori.Properties.DataSource = New XPCollection(Of Persistent.Kategori)(_sesi)
  txtSubKategori.Properties.DataSource = New XPCollection(Of Persistent.SubKategori)(_sesi)
  txtMerk.Properties.DataSource = New XPCollection(Of Persistent.Merk)(_sesi)
  txtTanggal.EditValue = Now
 End Sub
 Overrides Sub Filter()
  Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)

  AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
  AddParameter("SloganPerusahaan", abcSetting.Slogan, GetType(System.String))
  AddParameter("AlamatPerusahaan", abcSetting.Alamat1, GetType(System.String))

  If Not txtTanggal.DateTime = Nothing Then
   AddParameter("Periode", txtTanggal.DateTime, GetType(Date))
  End If


  Dim DataStock As New XPCollection(Of Persistent.StockDetail)(_sesi, CreateCriteria)
  Dim detail = From z In DataStock Group z By z.Gudang, z.Barang Into Group Select Barang, QtyIn = Group.Sum(Function(x) x.QtyIn), QtyOut = Group.Sum(Function(x) x.QtyOut), Stock = Group.Sum(Function(x) x.QtyIn - x.QtyOut)

  _dataSource = detail

 End Sub
 Private Function CreateCriteria() As CriteriaOperator
  Dim result As New List(Of CriteriaOperator)
  Dim format As String = "%{0}%"

  If Not txtKodeBarang1.EditValue Is Nothing Then
   If txtKodeBarang2.EditValue Is Nothing Then
    result.Add(New BinaryOperator("Barang.Id", txtKodeBarang1.EditValue, BinaryOperatorType.Equal))
   Else
    result.Add(New BetweenOperator("Barang.Id", txtKodeBarang1.EditValue, txtKodeBarang2.EditValue))
   End If
  End If

  If Not txtTanggal.EditValue Is Nothing Then
   result.Add(New BinaryOperator("Main.Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
  End If

  If Not txtKategori.EditValue Is Nothing Then
   result.Add(New BinaryOperator("Barang.Kategori", txtKategori.EditValue, BinaryOperatorType.Equal))
  End If

  If Not txtSubKategori.EditValue Is Nothing Then
   result.Add(New BinaryOperator("Barang.SubKategori", txtSubKategori.EditValue, BinaryOperatorType.Equal))
  End If

  If Not txtGudang.EditValue Is Nothing Then
   result.Add(New BinaryOperator("Gudang.Id", txtGudang.EditValue, BinaryOperatorType.Equal))
  End If

  If Not txtMerk.EditValue Is Nothing Then
   result.Add(New BinaryOperator("Barang.Merk", txtMerk.EditValue, BinaryOperatorType.Equal))
  End If


  Return GroupOperator.And(result)
 End Function
End Class