Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class RF_StockOpname
 Overrides Sub InitializeData()
  txtKodeBarang1.Properties.DataSource = New XPCollection(Of Persistent.Barang)(_sesi)
  txtKodeBarang2.Properties.DataSource = New XPCollection(Of Persistent.Barang)(_sesi)
  txtKategori.Properties.DataSource = New XPCollection(Of Persistent.Kategori)(_sesi)
  txtSubKategori.Properties.DataSource = New XPCollection(Of Persistent.SubKategori)(_sesi)
  txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(_sesi)
  txtMerk.Properties.DataSource = New XPCollection(Of Persistent.Merk)(_sesi)
 End Sub
 Overrides Sub Filter()
  Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
  AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
  AddParameter("SloganPerusahaan", abcSetting.Slogan, GetType(System.String))
  AddParameter("AlamatPerusahaan", abcSetting.Alamat1, GetType(System.String))

  _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.Barang)(_sesi, CreateCriteria)
 End Sub
 Private Function CreateCriteria() As CriteriaOperator
  Dim result As New List(Of CriteriaOperator)
  Dim format As String = "%{0}%"

  If Not txtKodeBarang1.EditValue Is Nothing Then
   If txtKodeBarang2.EditValue Is Nothing Then
    result.Add(New BinaryOperator("Barang", CType(txtKodeBarang1.EditValue, Persistent.Barang), BinaryOperatorType.Equal))
   Else
    result.Add(New BetweenOperator("Barang", CType(txtKodeBarang1.EditValue, Persistent.Barang), CType(txtKodeBarang2.EditValue, Persistent.Barang)))
   End If
  End If

  If Not txtKategori.EditValue Is Nothing Then
   result.Add(New BinaryOperator("Kategori", CType(txtKategori.EditValue, Persistent.Kategori), BinaryOperatorType.Equal))
  End If
  If Not txtSubKategori.EditValue Is Nothing Then
   result.Add(New BinaryOperator("SubKategori", CType(txtSubKategori.EditValue, Persistent.SubKategori), BinaryOperatorType.Equal))
  End If

  If Not txtGudang.EditValue Is Nothing Then
   result.Add(New BinaryOperator("ItemLocation.Gudang", CType(txtGudang.EditValue, Persistent.Gudang), BinaryOperatorType.Equal))
  End If
  If Not txtMerk.EditValue Is Nothing Then
   result.Add(New BinaryOperator("Merk", CType(txtMerk.EditValue, Persistent.Merk), BinaryOperatorType.Equal))
  End If

  Return GroupOperator.And(result)
 End Function
End Class