Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001
Imports System.Windows.Forms

Friend Class RF_FusohRekapSerial
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Me.Text = "Filter Laporan - Detail Stok Bahan Baku"
  End Sub
  Overrides Sub InitializeData()
    txtPerTanggal.DateTime = Now
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
    AddParameter("TanggalFilter", txtPerTanggal.DateTime, GetType(Date))

    Dim xd = New XPCollection(Of Persistent.Fusoh_StokSerial)(_sesi, CreateCriteria).GroupBy(Function(g) g.Serial).Select(Function(s) New DetailSN With {.Serial = s.Key, .Barang = s.Max(Function(x) x.DetailMain.Barang), .Length = s.Sum(Function(x) x.LengthIn - x.LengthOut), .Tanggal = s.Min(Function(x) x.DetailMain.Main.Tanggal)}).ToList
    If chkStock0.Checked = True Then
      _dataSource = xd
    Else
      _dataSource = xd.Where(Function(w) w.Length <> 0)
    End If
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("DetailMain.Barang.TipeBarang", Persistent.TipeBarang.BahanBaku, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("DetailMain.Main.Tanggal", txtPerTanggal.DateTime, BinaryOperatorType.LessOrEqual))
    If Not String.IsNullOrEmpty(txtPartNo.Text) Then
      result.Add(New BinaryOperator("DetailMain.Barang.Kode", String.Format(format, txtPartNo.Text), BinaryOperatorType.Like))
    End If
    If Not String.IsNullOrEmpty(txtMaterial.Text) Then
      result.Add(New BinaryOperator("DetailMain.Barang.Nama", String.Format(format, txtMaterial.Text), BinaryOperatorType.Like))
    End If
    If Not String.IsNullOrEmpty(txtCustomer.Text) Then
      result.Add(New BinaryOperator("DetailMain.Barang.Customer.Nama", String.Format(format, txtCustomer.Text), BinaryOperatorType.Like))
    End If
    If Not String.IsNullOrEmpty(txtMilSheet.Text) Then
      result.Add(New BinaryOperator("MillSheet", String.Format(format, txtMilSheet.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
End Class
Public Class DetailSN
  Property Barang As Persistent.Fusoh_Barang
  Property Tanggal As Date
  Property Serial As String
  Property Length As Double
End Class
