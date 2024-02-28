Imports DevExpress.Data.Filtering
Friend Class RF_Asset
  Dim setting As Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtTgl1.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtTgl1.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    setting = New Logic.FinaSetting(_sesi)
    txtAsset.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.AktivaTetap)(_sesi)
    txtKategori.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.AktivaKelompok)(_sesi)

  End Sub
  Overrides Sub Filter()
    If txtTgl1.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode dengan benar", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
    End If

    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New Logic.FinaSetting(_sesi)

    AddParameter("Periode", txtTgl1.DateTime.ToString("dd-MMM-yyyy"), GetType(System.String))
    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))

    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))

    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.viewAktivaTetapTransaksi)(_sesi, CreateCriteria)
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    'If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
    '  Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
    '  result.Add(New InOperator("Divisi", right.ToList))
    'End If
    result.Add(New BinaryOperator("Tanggal", txtTgl1.DateTime, BinaryOperatorType.LessOrEqual))

    If Not txtAsset.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Asset.Kode", txtAsset.Text, BinaryOperatorType.Equal))
    End If
    If Not txtKategori.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Asset.Kelompok.Kode", txtKategori.Text, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function

End Class