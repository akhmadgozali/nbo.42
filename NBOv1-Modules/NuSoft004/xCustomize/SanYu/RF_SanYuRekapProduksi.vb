Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_SanYuRekapProduksi
  Private _reportname As MainClass.reportName
  Sub New(xReportName As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _reportname = xReportName
    Me.Text = "Filter Laporan - Rekap Produksi"
  End Sub
  Overrides Sub InitializeData()

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

    Select Case _reportname
      Case MainClass.reportName.zSanyuRekapProduksi : _dataSource = New XPCollection(Of Persistent.SanYu_ProduksiDetail)(_sesi, CreateCriteria)
      Case MainClass.reportName.zSanyuRekapRandemen : _dataSource = New XPCollection(Of Persistent.SanYu_ProduksiMain)(_sesi, CreateCriteria)
    End Select

  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    'result.Add(New BinaryOperator("TipeBarang", Persistent.TipeBarang.Jasa, BinaryOperatorType.NotEqual))
    'If Not String.IsNullOrEmpty(txtPartNo.Text) Then
    '  result.Add(New BinaryOperator("Kode", String.Format(format, txtPartNo.Text), BinaryOperatorType.Like))
    'End If
    'If Not String.IsNullOrEmpty(txtMaterial.Text) Then
    '  result.Add(New BinaryOperator("Nama", String.Format(format, txtMaterial.Text), BinaryOperatorType.Like))
    'End If
    'If Not String.IsNullOrEmpty(txtItemJadi.Text) Then
    '  result.Add(New BinaryOperator("Customer.Nama", String.Format(format, txtItemJadi.Text), BinaryOperatorType.Like))
    'End If

    Return GroupOperator.And(result)
  End Function
End Class