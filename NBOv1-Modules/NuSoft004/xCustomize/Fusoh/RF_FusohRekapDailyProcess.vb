Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Friend Class RF_FusohRekapDailyProcess
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    Dim dataCustomer = New XPQuery(Of Persistent.Fusoh_DailyProcess)(_sesi).GroupBy(Function(g) g.CuttingWIP.Pelanggan).Select(Function(x) x.Key).ToList
    txtCustomer.Properties.DataSource = dataCustomer
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

    _dataSource = New XPCollection(Of Persistent.Fusoh_DailyProcess)(_sesi, CreateCriteria)
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("CuttingWIP.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("CuttingWIP.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtNoLOT.Text <> "" Then
      result.Add(New BinaryOperator("CuttingWIP.DempyouLot", String.Format(format, txtNoLOT.Text), BinaryOperatorType.Like))
    End If
    If Not txtCustomer.EditValue Is Nothing Then
      result.Add(New BinaryOperator("CuttingWIP.Pelanggan.Id", txtCustomer.EditValue, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
End Class